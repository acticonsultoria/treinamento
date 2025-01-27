<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrdApontamentoIssartel
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
        Dim JanusColorScheme5 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdApontamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdApontamento_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdApontamentoIssartel))
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSubProjeto = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblProjeto = New System.Windows.Forms.Label()
        Me.lblOrdemProducaoLabel = New System.Windows.Forms.Label()
        Me.lblOrdemProducaoValor = New System.Windows.Forms.Label()
        Me.lblCodigoProdutoValor = New System.Windows.Forms.Label()
        Me.lblTipoApontamentoLabel = New System.Windows.Forms.Label()
        Me.lblCodigoProdutoLabel = New System.Windows.Forms.Label()
        Me.lblQuantidadeRejeitoLabel = New System.Windows.Forms.Label()
        Me.lblTipoApontamentoValor = New System.Windows.Forms.Label()
        Me.lblQuantidadeRejeitoValor = New System.Windows.Forms.Label()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grdApontamento = New Janus.Windows.GridEX.GridEX()
        Me.grpApontamento = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtQuantidadePlanejada = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboOrdemProducao = New Janus.Windows.EditControls.UIComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDataInicio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataTermino = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboEquipamento = New Janus.Windows.EditControls.UIComboBox()
        Me.cboFuncionario = New Janus.Windows.EditControls.UIComboBox()
        Me.cboOperacao = New Janus.Windows.EditControls.UIComboBox()
        Me.cboTipoApontamento = New Janus.Windows.EditControls.UIComboBox()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadePlanejada = New System.Windows.Forms.Label()
        Me.lblEquipamento = New System.Windows.Forms.Label()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.lblOPOperacao = New System.Windows.Forms.Label()
        Me.lblTipoApontamento = New System.Windows.Forms.Label()
        Me.grpControlFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.lblDataAbertura = New System.Windows.Forms.Label()
        Me.dtpDataAbertura = New Janus.Windows.CalendarCombo.CalendarCombo()
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
        Me.pagLista.Location = New System.Drawing.Point(1, 24)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(1177, 429)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Apontamento de Produção"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.Label4)
        Me.UiGroupBox1.Controls.Add(Me.lblSubProjeto)
        Me.UiGroupBox1.Controls.Add(Me.Label3)
        Me.UiGroupBox1.Controls.Add(Me.lblProjeto)
        Me.UiGroupBox1.Controls.Add(Me.lblOrdemProducaoLabel)
        Me.UiGroupBox1.Controls.Add(Me.lblOrdemProducaoValor)
        Me.UiGroupBox1.Controls.Add(Me.lblCodigoProdutoValor)
        Me.UiGroupBox1.Controls.Add(Me.lblTipoApontamentoLabel)
        Me.UiGroupBox1.Controls.Add(Me.lblCodigoProdutoLabel)
        Me.UiGroupBox1.Controls.Add(Me.lblQuantidadeRejeitoLabel)
        Me.UiGroupBox1.Controls.Add(Me.lblTipoApontamentoValor)
        Me.UiGroupBox1.Controls.Add(Me.lblQuantidadeRejeitoValor)
        Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox1.Location = New System.Drawing.Point(848, 3)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(321, 184)
        Me.UiGroupBox1.TabIndex = 2
        Me.UiGroupBox1.Text = "Dados da Ordem de Produção"
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Moccasin
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(7, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Sub Projeto:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSubProjeto
        '
        Me.lblSubProjeto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSubProjeto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSubProjeto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubProjeto.Location = New System.Drawing.Point(133, 154)
        Me.lblSubProjeto.Name = "lblSubProjeto"
        Me.lblSubProjeto.Size = New System.Drawing.Size(178, 20)
        Me.lblSubProjeto.TabIndex = 11
        Me.lblSubProjeto.Text = "-"
        Me.lblSubProjeto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Moccasin
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(7, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Projeto:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProjeto
        '
        Me.lblProjeto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblProjeto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblProjeto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblProjeto.Location = New System.Drawing.Point(133, 128)
        Me.lblProjeto.Name = "lblProjeto"
        Me.lblProjeto.Size = New System.Drawing.Size(178, 20)
        Me.lblProjeto.TabIndex = 9
        Me.lblProjeto.Text = "-"
        Me.lblProjeto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrdemProducaoLabel
        '
        Me.lblOrdemProducaoLabel.BackColor = System.Drawing.Color.Moccasin
        Me.lblOrdemProducaoLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdemProducaoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOrdemProducaoLabel.Location = New System.Drawing.Point(7, 24)
        Me.lblOrdemProducaoLabel.Name = "lblOrdemProducaoLabel"
        Me.lblOrdemProducaoLabel.Size = New System.Drawing.Size(116, 20)
        Me.lblOrdemProducaoLabel.TabIndex = 0
        Me.lblOrdemProducaoLabel.Text = "Ordem de Produção:"
        Me.lblOrdemProducaoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrdemProducaoValor
        '
        Me.lblOrdemProducaoValor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOrdemProducaoValor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOrdemProducaoValor.Location = New System.Drawing.Point(129, 24)
        Me.lblOrdemProducaoValor.Name = "lblOrdemProducaoValor"
        Me.lblOrdemProducaoValor.Size = New System.Drawing.Size(178, 20)
        Me.lblOrdemProducaoValor.TabIndex = 4
        Me.lblOrdemProducaoValor.Text = "-"
        Me.lblOrdemProducaoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'lblQuantidadeRejeitoLabel
        '
        Me.lblQuantidadeRejeitoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeRejeitoLabel.BackColor = System.Drawing.Color.Moccasin
        Me.lblQuantidadeRejeitoLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantidadeRejeitoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeRejeitoLabel.Location = New System.Drawing.Point(7, 102)
        Me.lblQuantidadeRejeitoLabel.Name = "lblQuantidadeRejeitoLabel"
        Me.lblQuantidadeRejeitoLabel.Size = New System.Drawing.Size(116, 20)
        Me.lblQuantidadeRejeitoLabel.TabIndex = 3
        Me.lblQuantidadeRejeitoLabel.Text = "Quantidade Rejeito:"
        Me.lblQuantidadeRejeitoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'lblQuantidadeRejeitoValor
        '
        Me.lblQuantidadeRejeitoValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeRejeitoValor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblQuantidadeRejeitoValor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeRejeitoValor.Location = New System.Drawing.Point(133, 102)
        Me.lblQuantidadeRejeitoValor.Name = "lblQuantidadeRejeitoValor"
        Me.lblQuantidadeRejeitoValor.Size = New System.Drawing.Size(178, 20)
        Me.lblQuantidadeRejeitoValor.TabIndex = 7
        Me.lblQuantidadeRejeitoValor.Text = "-"
        Me.lblQuantidadeRejeitoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'vsmMain
        '
        JanusColorScheme5.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme5.Name = "Scheme"
        JanusColorScheme5.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme5.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme5.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme5)
        Me.vsmMain.DefaultColorScheme = Nothing
        '
        'grdApontamento
        '
        Me.grdApontamento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdApontamento.AlternatingColors = True
        Me.grdApontamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdApontamento_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdApontamento_DesignTimeLayout_Reference_0.Instance"), Object)
        grdApontamento_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdApontamento_DesignTimeLayout_Reference_0})
        grdApontamento_DesignTimeLayout.LayoutString = resources.GetString("grdApontamento_DesignTimeLayout.LayoutString")
        Me.grdApontamento.DesignTimeLayout = grdApontamento_DesignTimeLayout
        Me.grdApontamento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdApontamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdApontamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdApontamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdApontamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdApontamento.FrozenColumns = 3
        Me.grdApontamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdApontamento.GroupByBoxVisible = False
        Me.grdApontamento.Location = New System.Drawing.Point(8, 197)
        Me.grdApontamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdApontamento.Name = "grdApontamento"
        Me.grdApontamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdApontamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdApontamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdApontamento.Size = New System.Drawing.Size(1161, 169)
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
        Me.grpApontamento.Controls.Add(Me.dtpDataAbertura)
        Me.grpApontamento.Controls.Add(Me.lblDataAbertura)
        Me.grpApontamento.Controls.Add(Me.txtQuantidadePlanejada)
        Me.grpApontamento.Controls.Add(Me.Label6)
        Me.grpApontamento.Controls.Add(Me.cboOrdemProducao)
        Me.grpApontamento.Controls.Add(Me.Label5)
        Me.grpApontamento.Controls.Add(Me.Label2)
        Me.grpApontamento.Controls.Add(Me.Label1)
        Me.grpApontamento.Controls.Add(Me.dtpDataInicio)
        Me.grpApontamento.Controls.Add(Me.dtpDataTermino)
        Me.grpApontamento.Controls.Add(Me.cboEquipamento)
        Me.grpApontamento.Controls.Add(Me.cboFuncionario)
        Me.grpApontamento.Controls.Add(Me.cboOperacao)
        Me.grpApontamento.Controls.Add(Me.cboTipoApontamento)
        Me.grpApontamento.Controls.Add(Me.txtQuantidade)
        Me.grpApontamento.Controls.Add(Me.lblQuantidadePlanejada)
        Me.grpApontamento.Controls.Add(Me.lblEquipamento)
        Me.grpApontamento.Controls.Add(Me.lblFuncionario)
        Me.grpApontamento.Controls.Add(Me.lblOPOperacao)
        Me.grpApontamento.Controls.Add(Me.lblTipoApontamento)
        Me.grpApontamento.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpApontamento.Location = New System.Drawing.Point(8, 3)
        Me.grpApontamento.Name = "grpApontamento"
        Me.grpApontamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpApontamento.Size = New System.Drawing.Size(834, 184)
        Me.grpApontamento.TabIndex = 0
        Me.grpApontamento.Text = "Apontamento"
        Me.grpApontamento.VisualStyleManager = Me.vsmMain
        '
        'txtQuantidadePlanejada
        '
        Me.txtQuantidadePlanejada.DecimalDigits = 4
        Me.txtQuantidadePlanejada.Enabled = False
        Me.txtQuantidadePlanejada.Location = New System.Drawing.Point(12, 153)
        Me.txtQuantidadePlanejada.Name = "txtQuantidadePlanejada"
        Me.txtQuantidadePlanejada.Size = New System.Drawing.Size(111, 23)
        Me.txtQuantidadePlanejada.TabIndex = 32
        Me.txtQuantidadePlanejada.Text = "0,0000"
        Me.txtQuantidadePlanejada.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(9, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Quantidade Planejada:"
        '
        'cboOrdemProducao
        '
        Me.cboOrdemProducao.Location = New System.Drawing.Point(169, 34)
        Me.cboOrdemProducao.Name = "cboOrdemProducao"
        Me.cboOrdemProducao.Size = New System.Drawing.Size(156, 23)
        Me.cboOrdemProducao.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(166, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Ordem de Produção:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(166, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Data Término:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(6, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
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
        Me.dtpDataInicio.Size = New System.Drawing.Size(156, 23)
        Me.dtpDataInicio.TabIndex = 21
        '
        'dtpDataTermino
        '
        Me.dtpDataTermino.DateFormat = Janus.Windows.CalendarCombo.DateFormat.DateTime
        '
        '
        '
        Me.dtpDataTermino.DropDownCalendar.Name = ""
        Me.dtpDataTermino.Location = New System.Drawing.Point(169, 74)
        Me.dtpDataTermino.Name = "dtpDataTermino"
        Me.dtpDataTermino.ShowCheckBox = True
        Me.dtpDataTermino.Size = New System.Drawing.Size(156, 23)
        Me.dtpDataTermino.TabIndex = 22
        '
        'cboEquipamento
        '
        Me.cboEquipamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboEquipamento.Location = New System.Drawing.Point(9, 114)
        Me.cboEquipamento.Name = "cboEquipamento"
        Me.cboEquipamento.Size = New System.Drawing.Size(816, 23)
        Me.cboEquipamento.TabIndex = 7
        '
        'cboFuncionario
        '
        Me.cboFuncionario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFuncionario.BackColor = System.Drawing.Color.White
        Me.cboFuncionario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFuncionario.Location = New System.Drawing.Point(505, 73)
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Size = New System.Drawing.Size(320, 23)
        Me.cboFuncionario.TabIndex = 5
        '
        'cboOperacao
        '
        Me.cboOperacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboOperacao.Location = New System.Drawing.Point(331, 34)
        Me.cboOperacao.Name = "cboOperacao"
        Me.cboOperacao.Size = New System.Drawing.Size(494, 23)
        Me.cboOperacao.TabIndex = 3
        '
        'cboTipoApontamento
        '
        Me.cboTipoApontamento.Enabled = False
        Me.cboTipoApontamento.Location = New System.Drawing.Point(9, 34)
        Me.cboTipoApontamento.Name = "cboTipoApontamento"
        Me.cboTipoApontamento.Size = New System.Drawing.Size(154, 23)
        Me.cboTipoApontamento.TabIndex = 1
        '
        'txtQuantidade
        '
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(129, 153)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(105, 23)
        Me.txtQuantidade.TabIndex = 13
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadePlanejada
        '
        Me.lblQuantidadePlanejada.AutoSize = True
        Me.lblQuantidadePlanejada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadePlanejada.Location = New System.Drawing.Point(126, 136)
        Me.lblQuantidadePlanejada.Name = "lblQuantidadePlanejada"
        Me.lblQuantidadePlanejada.Size = New System.Drawing.Size(86, 16)
        Me.lblQuantidadePlanejada.TabIndex = 12
        Me.lblQuantidadePlanejada.Text = "Quantidade:"
        '
        'lblEquipamento
        '
        Me.lblEquipamento.AutoSize = True
        Me.lblEquipamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEquipamento.Location = New System.Drawing.Point(6, 97)
        Me.lblEquipamento.Name = "lblEquipamento"
        Me.lblEquipamento.Size = New System.Drawing.Size(95, 16)
        Me.lblEquipamento.TabIndex = 6
        Me.lblEquipamento.Text = "Equipamento:"
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFuncionario.Location = New System.Drawing.Point(502, 57)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(87, 16)
        Me.lblFuncionario.TabIndex = 4
        Me.lblFuncionario.Text = "Funcionário:"
        '
        'lblOPOperacao
        '
        Me.lblOPOperacao.AutoSize = True
        Me.lblOPOperacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOPOperacao.Location = New System.Drawing.Point(331, 17)
        Me.lblOPOperacao.Name = "lblOPOperacao"
        Me.lblOPOperacao.Size = New System.Drawing.Size(75, 16)
        Me.lblOPOperacao.TabIndex = 2
        Me.lblOPOperacao.Text = "Operação:"
        '
        'lblTipoApontamento
        '
        Me.lblTipoApontamento.AutoSize = True
        Me.lblTipoApontamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoApontamento.Location = New System.Drawing.Point(6, 17)
        Me.lblTipoApontamento.Name = "lblTipoApontamento"
        Me.lblTipoApontamento.Size = New System.Drawing.Size(146, 16)
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
        Me.grpControlFiltro.Location = New System.Drawing.Point(8, 369)
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
        'lblDataAbertura
        '
        Me.lblDataAbertura.AutoSize = True
        Me.lblDataAbertura.Location = New System.Drawing.Point(331, 57)
        Me.lblDataAbertura.Name = "lblDataAbertura"
        Me.lblDataAbertura.Size = New System.Drawing.Size(100, 16)
        Me.lblDataAbertura.TabIndex = 34
        Me.lblDataAbertura.Text = "Data Abertura:"
        '
        'dtpDataAbertura
        '
        Me.dtpDataAbertura.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dtpDataAbertura.DateFormat = Janus.Windows.CalendarCombo.DateFormat.DateTime
        '
        '
        '
        Me.dtpDataAbertura.DropDownCalendar.Name = ""
        Me.dtpDataAbertura.Location = New System.Drawing.Point(330, 74)
        Me.dtpDataAbertura.Name = "dtpDataAbertura"
        Me.dtpDataAbertura.ReadOnly = True
        Me.dtpDataAbertura.Size = New System.Drawing.Size(169, 23)
        Me.dtpDataAbertura.TabIndex = 35
        Me.dtpDataAbertura.Value = New Date(2012, 9, 6, 0, 0, 0, 0)
        '
        'usrPrdApontamentoIssartel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "usrPrdApontamentoIssartel"
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
    Friend WithEvents lblEquipamento As System.Windows.Forms.Label
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents lblCodigoProdutoValor As System.Windows.Forms.Label
    Friend WithEvents lblCodigoProdutoLabel As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents lblOrdemProducaoValor As System.Windows.Forms.Label
    Friend WithEvents lblOrdemProducaoLabel As System.Windows.Forms.Label
    Friend WithEvents grdApontamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblQuantidadePlanejada As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeRejeitoValor As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeRejeitoLabel As System.Windows.Forms.Label
    Friend WithEvents lblTipoApontamentoValor As System.Windows.Forms.Label
    Friend WithEvents lblTipoApontamentoLabel As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTipoApontamento As System.Windows.Forms.Label
    Friend WithEvents cboTipoApontamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboEquipamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboFuncionario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDataInicio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataTermino As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboOrdemProducao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSubProjeto As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblProjeto As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadePlanejada As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblDataAbertura As System.Windows.Forms.Label
    Friend WithEvents dtpDataAbertura As Janus.Windows.CalendarCombo.CalendarCombo

End Class
