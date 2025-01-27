<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrdApontamentoServico
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
        Dim grdApontamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdApontamento_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdApontamentoServico))
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblOrdemServico = New System.Windows.Forms.Label()
        Me.lblOrdemServicoValor = New System.Windows.Forms.Label()
        Me.lblCodigoProdutoValor = New System.Windows.Forms.Label()
        Me.lblTipoApontamentoLabel = New System.Windows.Forms.Label()
        Me.lblCodigoProdutoLabel = New System.Windows.Forms.Label()
        Me.lblTipoApontamentoValor = New System.Windows.Forms.Label()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grdApontamento = New Janus.Windows.GridEX.GridEX()
        Me.grpApontamento = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboOrdemServico = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOrdemServico1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDataInicio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataTermino = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboFuncionario = New Janus.Windows.EditControls.UIComboBox()
        Me.cboOperacao = New Janus.Windows.EditControls.UIComboBox()
        Me.cboTipoApontamento = New Janus.Windows.EditControls.UIComboBox()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadePlanejada = New System.Windows.Forms.Label()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.lblOPOperacao = New System.Windows.Forms.Label()
        Me.lblTipoApontamento = New System.Windows.Forms.Label()
        Me.grpControlFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpApontamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpApontamento.SuspendLayout()
        CType(Me.grpControlFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControlFiltro.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(1179, 454)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.UiGroupBox1)
        Me.pagLista.Controls.Add(Me.grdApontamento)
        Me.pagLista.Controls.Add(Me.grpApontamento)
        Me.pagLista.Controls.Add(Me.grpControlFiltro)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(1177, 431)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Apontamento de Produção"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.lblOrdemServico)
        Me.UiGroupBox1.Controls.Add(Me.lblOrdemServicoValor)
        Me.UiGroupBox1.Controls.Add(Me.lblCodigoProdutoValor)
        Me.UiGroupBox1.Controls.Add(Me.lblTipoApontamentoLabel)
        Me.UiGroupBox1.Controls.Add(Me.lblCodigoProdutoLabel)
        Me.UiGroupBox1.Controls.Add(Me.lblTipoApontamentoValor)
        Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox1.Location = New System.Drawing.Point(848, 3)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(321, 148)
        Me.UiGroupBox1.TabIndex = 2
        Me.UiGroupBox1.Text = "Dados da Ordem de Despesa"
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'lblOrdemServico
        '
        Me.lblOrdemServico.BackColor = System.Drawing.Color.Moccasin
        Me.lblOrdemServico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdemServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOrdemServico.Location = New System.Drawing.Point(7, 24)
        Me.lblOrdemServico.Name = "lblOrdemServico"
        Me.lblOrdemServico.Size = New System.Drawing.Size(116, 20)
        Me.lblOrdemServico.TabIndex = 0
        Me.lblOrdemServico.Text = "Ordem de Serviço:"
        Me.lblOrdemServico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrdemServicoValor
        '
        Me.lblOrdemServicoValor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOrdemServicoValor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOrdemServicoValor.Location = New System.Drawing.Point(129, 24)
        Me.lblOrdemServicoValor.Name = "lblOrdemServicoValor"
        Me.lblOrdemServicoValor.Size = New System.Drawing.Size(178, 20)
        Me.lblOrdemServicoValor.TabIndex = 4
        Me.lblOrdemServicoValor.Text = "-"
        Me.lblOrdemServicoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodigoProdutoValor
        '
        Me.lblCodigoProdutoValor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCodigoProdutoValor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProdutoValor.Location = New System.Drawing.Point(129, 50)
        Me.lblCodigoProdutoValor.Name = "lblCodigoProdutoValor"
        Me.lblCodigoProdutoValor.Size = New System.Drawing.Size(178, 20)
        Me.lblCodigoProdutoValor.TabIndex = 5
        Me.lblCodigoProdutoValor.Text = "-"
        Me.lblCodigoProdutoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoApontamentoLabel
        '
        Me.lblTipoApontamentoLabel.BackColor = System.Drawing.Color.Moccasin
        Me.lblTipoApontamentoLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoApontamentoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoApontamentoLabel.Location = New System.Drawing.Point(7, 76)
        Me.lblTipoApontamentoLabel.Name = "lblTipoApontamentoLabel"
        Me.lblTipoApontamentoLabel.Size = New System.Drawing.Size(116, 20)
        Me.lblTipoApontamentoLabel.TabIndex = 2
        Me.lblTipoApontamentoLabel.Text = "Tipo de Apontamento:"
        Me.lblTipoApontamentoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodigoProdutoLabel
        '
        Me.lblCodigoProdutoLabel.BackColor = System.Drawing.Color.Moccasin
        Me.lblCodigoProdutoLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoProdutoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProdutoLabel.Location = New System.Drawing.Point(7, 50)
        Me.lblCodigoProdutoLabel.Name = "lblCodigoProdutoLabel"
        Me.lblCodigoProdutoLabel.Size = New System.Drawing.Size(116, 20)
        Me.lblCodigoProdutoLabel.TabIndex = 1
        Me.lblCodigoProdutoLabel.Text = "Código do Produto:"
        Me.lblCodigoProdutoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoApontamentoValor
        '
        Me.lblTipoApontamentoValor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTipoApontamentoValor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoApontamentoValor.Location = New System.Drawing.Point(132, 76)
        Me.lblTipoApontamentoValor.Name = "lblTipoApontamentoValor"
        Me.lblTipoApontamentoValor.Size = New System.Drawing.Size(178, 20)
        Me.lblTipoApontamentoValor.TabIndex = 6
        Me.lblTipoApontamentoValor.Text = "-"
        Me.lblTipoApontamentoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'grdApontamento
        '
        Me.grdApontamento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdApontamento.AlternatingColors = True
        Me.grdApontamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdApontamento.ColumnAutoResize = True
        grdApontamento_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdApontamento_DesignTimeLayout_Reference_0.Instance"), Object)
        grdApontamento_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdApontamento_DesignTimeLayout_Reference_0})
        grdApontamento_DesignTimeLayout.LayoutString = resources.GetString("grdApontamento_DesignTimeLayout.LayoutString")
        Me.grdApontamento.DesignTimeLayout = grdApontamento_DesignTimeLayout
        Me.grdApontamento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdApontamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdApontamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdApontamento.FrozenColumns = 3
        Me.grdApontamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdApontamento.GroupByBoxVisible = False
        Me.grdApontamento.Location = New System.Drawing.Point(8, 158)
        Me.grdApontamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdApontamento.Name = "grdApontamento"
        Me.grdApontamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdApontamento.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdApontamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdApontamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdApontamento.Size = New System.Drawing.Size(1161, 210)
        Me.grdApontamento.TabIndex = 3
        Me.grdApontamento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdApontamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdApontamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdApontamento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdApontamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdApontamento.VisualStyleManager = Me.vsmMain
        '
        'grpApontamento
        '
        Me.grpApontamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpApontamento.BackColor = System.Drawing.Color.Transparent
        Me.grpApontamento.Controls.Add(Me.cboOrdemServico)
        Me.grpApontamento.Controls.Add(Me.lblOrdemServico1)
        Me.grpApontamento.Controls.Add(Me.Label2)
        Me.grpApontamento.Controls.Add(Me.Label1)
        Me.grpApontamento.Controls.Add(Me.dtpDataInicio)
        Me.grpApontamento.Controls.Add(Me.dtpDataTermino)
        Me.grpApontamento.Controls.Add(Me.cboFuncionario)
        Me.grpApontamento.Controls.Add(Me.cboOperacao)
        Me.grpApontamento.Controls.Add(Me.cboTipoApontamento)
        Me.grpApontamento.Controls.Add(Me.txtQuantidade)
        Me.grpApontamento.Controls.Add(Me.lblQuantidadePlanejada)
        Me.grpApontamento.Controls.Add(Me.lblFuncionario)
        Me.grpApontamento.Controls.Add(Me.lblOPOperacao)
        Me.grpApontamento.Controls.Add(Me.lblTipoApontamento)
        Me.grpApontamento.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpApontamento.Location = New System.Drawing.Point(8, 3)
        Me.grpApontamento.Name = "grpApontamento"
        Me.grpApontamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpApontamento.Size = New System.Drawing.Size(834, 148)
        Me.grpApontamento.TabIndex = 0
        Me.grpApontamento.Text = "Apontamento"
        Me.grpApontamento.VisualStyleManager = Me.vsmMain
        '
        'cboOrdemServico
        '
        Me.cboOrdemServico.Location = New System.Drawing.Point(169, 34)
        Me.cboOrdemServico.Name = "cboOrdemServico"
        Me.cboOrdemServico.Size = New System.Drawing.Size(427, 20)
        Me.cboOrdemServico.TabIndex = 30
        '
        'lblOrdemServico1
        '
        Me.lblOrdemServico1.AutoSize = True
        Me.lblOrdemServico1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOrdemServico1.Location = New System.Drawing.Point(166, 17)
        Me.lblOrdemServico1.Name = "lblOrdemServico1"
        Me.lblOrdemServico1.Size = New System.Drawing.Size(97, 14)
        Me.lblOrdemServico1.TabIndex = 29
        Me.lblOrdemServico1.Text = "Ordem de Serviço:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(196, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 14)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Data Término:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(6, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 14)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Data Inicio:"
        '
        'dtpDataInicio
        '
        Me.dtpDataInicio.DateFormat = Janus.Windows.CalendarCombo.DateFormat.DateTime
        '
        '
        '
        Me.dtpDataInicio.DropDownCalendar.Name = ""
        Me.dtpDataInicio.Location = New System.Drawing.Point(7, 73)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.ShowCheckBox = True
        Me.dtpDataInicio.Size = New System.Drawing.Size(186, 20)
        Me.dtpDataInicio.TabIndex = 21
        '
        'dtpDataTermino
        '
        Me.dtpDataTermino.DateFormat = Janus.Windows.CalendarCombo.DateFormat.DateTime
        '
        '
        '
        Me.dtpDataTermino.DropDownCalendar.Name = ""
        Me.dtpDataTermino.Location = New System.Drawing.Point(199, 73)
        Me.dtpDataTermino.Name = "dtpDataTermino"
        Me.dtpDataTermino.ShowCheckBox = True
        Me.dtpDataTermino.Size = New System.Drawing.Size(187, 20)
        Me.dtpDataTermino.TabIndex = 22
        '
        'cboFuncionario
        '
        Me.cboFuncionario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFuncionario.BackColor = System.Drawing.Color.White
        Me.cboFuncionario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFuncionario.Location = New System.Drawing.Point(392, 74)
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Size = New System.Drawing.Size(433, 20)
        Me.cboFuncionario.TabIndex = 5
        '
        'cboOperacao
        '
        Me.cboOperacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboOperacao.Location = New System.Drawing.Point(602, 34)
        Me.cboOperacao.Name = "cboOperacao"
        Me.cboOperacao.Size = New System.Drawing.Size(223, 20)
        Me.cboOperacao.TabIndex = 3
        '
        'cboTipoApontamento
        '
        Me.cboTipoApontamento.Enabled = False
        Me.cboTipoApontamento.Location = New System.Drawing.Point(9, 34)
        Me.cboTipoApontamento.Name = "cboTipoApontamento"
        Me.cboTipoApontamento.Size = New System.Drawing.Size(154, 20)
        Me.cboTipoApontamento.TabIndex = 1
        '
        'txtQuantidade
        '
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(9, 112)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(105, 20)
        Me.txtQuantidade.TabIndex = 13
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadePlanejada
        '
        Me.lblQuantidadePlanejada.AutoSize = True
        Me.lblQuantidadePlanejada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadePlanejada.Location = New System.Drawing.Point(6, 95)
        Me.lblQuantidadePlanejada.Name = "lblQuantidadePlanejada"
        Me.lblQuantidadePlanejada.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadePlanejada.TabIndex = 12
        Me.lblQuantidadePlanejada.Text = "Quantidade:"
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFuncionario.Location = New System.Drawing.Point(389, 57)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(66, 14)
        Me.lblFuncionario.TabIndex = 4
        Me.lblFuncionario.Text = "Funcionário:"
        '
        'lblOPOperacao
        '
        Me.lblOPOperacao.AutoSize = True
        Me.lblOPOperacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOPOperacao.Location = New System.Drawing.Point(599, 17)
        Me.lblOPOperacao.Name = "lblOPOperacao"
        Me.lblOPOperacao.Size = New System.Drawing.Size(58, 14)
        Me.lblOPOperacao.TabIndex = 2
        Me.lblOPOperacao.Text = "Operação:"
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
        Me.grpControlFiltro.Controls.Add(Me.btnSalvar)
        Me.grpControlFiltro.Controls.Add(Me.btnNovo)
        Me.grpControlFiltro.Controls.Add(Me.btnSair)
        Me.grpControlFiltro.Location = New System.Drawing.Point(8, 371)
        Me.grpControlFiltro.Name = "grpControlFiltro"
        Me.grpControlFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControlFiltro.Size = New System.Drawing.Size(1161, 51)
        Me.grpControlFiltro.TabIndex = 4
        Me.grpControlFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnSalvar.Location = New System.Drawing.Point(964, 18)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 3
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(867, 18)
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
        Me.btnSair.Location = New System.Drawing.Point(1061, 18)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 500
        '
        'usrPrdApontamentoServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "usrPrdApontamentoServico"
        Me.Size = New System.Drawing.Size(1179, 454)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpApontamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpApontamento.ResumeLayout(False)
        Me.grpApontamento.PerformLayout()
        CType(Me.grpControlFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControlFiltro.ResumeLayout(False)
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
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents lblCodigoProdutoValor As System.Windows.Forms.Label
    Friend WithEvents lblCodigoProdutoLabel As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents lblOrdemServicoValor As System.Windows.Forms.Label
    Friend WithEvents lblOrdemServico As System.Windows.Forms.Label
    Friend WithEvents grdApontamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblQuantidadePlanejada As System.Windows.Forms.Label
    Friend WithEvents lblTipoApontamentoValor As System.Windows.Forms.Label
    Friend WithEvents lblTipoApontamentoLabel As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTipoApontamento As System.Windows.Forms.Label
    Friend WithEvents cboTipoApontamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboFuncionario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDataInicio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataTermino As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboOrdemServico As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblOrdemServico1 As System.Windows.Forms.Label

End Class
