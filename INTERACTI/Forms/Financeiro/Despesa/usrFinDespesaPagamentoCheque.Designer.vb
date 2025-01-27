<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFinDespesaPagamentoCheque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFinDespesaPagamentoCheque))
        Dim grdPagamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdPagamento_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdParcela_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblParcelaVencimentoFuturo = New System.Windows.Forms.Label()
        Me.picParcelaVencimentoFuturo = New System.Windows.Forms.PictureBox()
        Me.lblParcelaVencimentoAtrasado = New System.Windows.Forms.Label()
        Me.picParcelaVencimentoAtrasado = New System.Windows.Forms.PictureBox()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpValorSelecionado = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblValorTitulo = New System.Windows.Forms.Label()
        Me.lblLabelValorTitulo = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnPagar1 = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblAdiantamentoFiltro = New System.Windows.Forms.Label()
        Me.cboAdiantamentoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataVencimentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataVencimentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorFiltro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorFiltro = New System.Windows.Forms.Label()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoFiltro = New System.Windows.Forms.Label()
        Me.lblFornecedorFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblDataVencimentoFiltro = New System.Windows.Forms.Label()
        Me.txtFornecedorFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridPagamento = New System.Windows.Forms.Button()
        Me.btnAgruparGridPagamento = New System.Windows.Forms.Button()
        Me.btnExcelGridParcela = New System.Windows.Forms.Button()
        Me.btnAgruparGridParcela = New System.Windows.Forms.Button()
        Me.btnConfigurarGridPagamento = New System.Windows.Forms.Button()
        Me.btnConfigurarGridParcela = New System.Windows.Forms.Button()
        Me.grpControle2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnPagar = New Janus.Windows.EditControls.UIButton()
        Me.grdPagamento = New Janus.Windows.GridEX.GridEX()
        Me.grdParcela = New Janus.Windows.GridEX.GridEX()
        Me.grpPagamento = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluirPagamento = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirPagamento = New Janus.Windows.EditControls.UIButton()
        Me.btnCadastrarContaBancaria = New System.Windows.Forms.Button()
        Me.lblTipoDocumentoPagamento = New System.Windows.Forms.Label()
        Me.cboTipoDocumentoPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblContaBancaria = New System.Windows.Forms.Label()
        Me.cboContaBancaria = New Janus.Windows.EditControls.UIComboBox()
        Me.grpCheque = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnAtualizarCheque = New System.Windows.Forms.Button()
        Me.btnAtualizar = New Janus.Windows.EditControls.UIButton()
        Me.lblNumeroCheque = New System.Windows.Forms.Label()
        Me.dtpDataCompensacaoCheque = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboCheque = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataPagamentoCheque = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataCompensacaoCheque = New System.Windows.Forms.Label()
        Me.txtValorCheque = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorCheque = New System.Windows.Forms.Label()
        Me.lblDataPagamentoCheque = New System.Windows.Forms.Label()
        Me.lblPreDatadoCheque = New System.Windows.Forms.Label()
        Me.cboPreDatadoCheque = New Janus.Windows.EditControls.UIComboBox()
        Me.txtFavorecidoCheque = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFavorecidoCheque = New System.Windows.Forms.Label()
        Me.grpChequeTerceiro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataPagamentoChequeTerceiro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorChequeTerceiro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorChequeTerceiro = New System.Windows.Forms.Label()
        Me.txtPreDatadoChequeTerceiro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPreDatadoChequeTerceiro = New System.Windows.Forms.Label()
        Me.cboNumeroDocumentoChequeTerceiro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNumeroDocumentoChequeTerceiro = New System.Windows.Forms.Label()
        Me.txtDataRecebimentoChequeTerceiro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataRecebimentoChequeTerceiro = New System.Windows.Forms.Label()
        Me.txtContaChequeTerceiro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblContaChequeTerceiro = New System.Windows.Forms.Label()
        Me.txtAgenciaChequeTerceiro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblAgenciaChequeTerceiro = New System.Windows.Forms.Label()
        Me.txtBancoChequeTerceiro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblBancoChequeTerceiro = New System.Windows.Forms.Label()
        Me.lblDataPagamentoChequeTerceiro = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picParcelaVencimentoFuturo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picParcelaVencimentoAtrasado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpValorSelecionado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpValorSelecionado.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle2.SuspendLayout()
        CType(Me.grdPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdParcela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPagamento.SuspendLayout()
        CType(Me.grpCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCheque.SuspendLayout()
        CType(Me.grpChequeTerceiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpChequeTerceiro.SuspendLayout()
        Me.SuspendLayout()
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
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpValorSelecionado)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(998, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Baixar Duplicatas"
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
        Me.btnAgruparGrid.TabIndex = 14
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
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
        Me.btnConfigurarGrid.TabIndex = 11
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblParcelaVencimentoFuturo)
        Me.grpLegenda.Controls.Add(Me.picParcelaVencimentoFuturo)
        Me.grpLegenda.Controls.Add(Me.lblParcelaVencimentoAtrasado)
        Me.grpLegenda.Controls.Add(Me.picParcelaVencimentoAtrasado)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(183, 51)
        Me.grpLegenda.TabIndex = 6
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblParcelaVencimentoFuturo
        '
        Me.lblParcelaVencimentoFuturo.AutoSize = True
        Me.lblParcelaVencimentoFuturo.Location = New System.Drawing.Point(28, 13)
        Me.lblParcelaVencimentoFuturo.Name = "lblParcelaVencimentoFuturo"
        Me.lblParcelaVencimentoFuturo.Size = New System.Drawing.Size(151, 14)
        Me.lblParcelaVencimentoFuturo.TabIndex = 0
        Me.lblParcelaVencimentoFuturo.Text = "Duplicata - Vencimento Futuro"
        '
        'picParcelaVencimentoFuturo
        '
        Me.picParcelaVencimentoFuturo.BackColor = System.Drawing.Color.DarkGray
        Me.picParcelaVencimentoFuturo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picParcelaVencimentoFuturo.Location = New System.Drawing.Point(9, 13)
        Me.picParcelaVencimentoFuturo.Name = "picParcelaVencimentoFuturo"
        Me.picParcelaVencimentoFuturo.Size = New System.Drawing.Size(13, 14)
        Me.picParcelaVencimentoFuturo.TabIndex = 14
        Me.picParcelaVencimentoFuturo.TabStop = False
        '
        'lblParcelaVencimentoAtrasado
        '
        Me.lblParcelaVencimentoAtrasado.AutoSize = True
        Me.lblParcelaVencimentoAtrasado.Location = New System.Drawing.Point(28, 30)
        Me.lblParcelaVencimentoAtrasado.Name = "lblParcelaVencimentoAtrasado"
        Me.lblParcelaVencimentoAtrasado.Size = New System.Drawing.Size(105, 14)
        Me.lblParcelaVencimentoAtrasado.TabIndex = 1
        Me.lblParcelaVencimentoAtrasado.Text = "Duplicata - Atrasada"
        '
        'picParcelaVencimentoAtrasado
        '
        Me.picParcelaVencimentoAtrasado.BackColor = System.Drawing.Color.Firebrick
        Me.picParcelaVencimentoAtrasado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picParcelaVencimentoAtrasado.Location = New System.Drawing.Point(9, 30)
        Me.picParcelaVencimentoAtrasado.Name = "picParcelaVencimentoAtrasado"
        Me.picParcelaVencimentoAtrasado.Size = New System.Drawing.Size(13, 14)
        Me.picParcelaVencimentoAtrasado.TabIndex = 8
        Me.picParcelaVencimentoAtrasado.TabStop = False
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
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 1
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 364)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpValorSelecionado
        '
        Me.grpValorSelecionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpValorSelecionado.BackColor = System.Drawing.Color.Transparent
        Me.grpValorSelecionado.Controls.Add(Me.lblValorTitulo)
        Me.grpValorSelecionado.Controls.Add(Me.lblLabelValorTitulo)
        Me.grpValorSelecionado.Location = New System.Drawing.Point(200, 483)
        Me.grpValorSelecionado.Name = "grpValorSelecionado"
        Me.grpValorSelecionado.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpValorSelecionado.Size = New System.Drawing.Size(207, 51)
        Me.grpValorSelecionado.TabIndex = 3
        Me.grpValorSelecionado.VisualStyleManager = Me.vsmMain
        '
        'lblValorTitulo
        '
        Me.lblValorTitulo.AutoSize = True
        Me.lblValorTitulo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblValorTitulo.Location = New System.Drawing.Point(120, 22)
        Me.lblValorTitulo.Name = "lblValorTitulo"
        Me.lblValorTitulo.Size = New System.Drawing.Size(44, 14)
        Me.lblValorTitulo.TabIndex = 1
        Me.lblValorTitulo.Text = "R$ 0,00"
        '
        'lblLabelValorTitulo
        '
        Me.lblLabelValorTitulo.AutoSize = True
        Me.lblLabelValorTitulo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLabelValorTitulo.Location = New System.Drawing.Point(6, 22)
        Me.lblLabelValorTitulo.Name = "lblLabelValorTitulo"
        Me.lblLabelValorTitulo.Size = New System.Drawing.Size(108, 14)
        Me.lblLabelValorTitulo.TabIndex = 0
        Me.lblLabelValorTitulo.Text = "Valor Selecionado:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.lblCongelarColuna)
        Me.grpControle.Controls.Add(Me.cboCongelarColuna)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Controls.Add(Me.btnPagar1)
        Me.grpControle.Location = New System.Drawing.Point(416, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(574, 51)
        Me.grpControle.TabIndex = 4
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 11
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 12
        Me.cboCongelarColuna.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(474, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnPagar1
        '
        Me.btnPagar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPagar1.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnPagar1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPagar1.Location = New System.Drawing.Point(318, 17)
        Me.btnPagar1.Name = "btnPagar1"
        Me.btnPagar1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPagar1.Size = New System.Drawing.Size(150, 23)
        Me.btnPagar1.TabIndex = 0
        Me.btnPagar1.Text = "Baixar Duplicatas"
        Me.btnPagar1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblAdiantamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboAdiantamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataVencimentoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataVencimentoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.txtValorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblValorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblDataVencimentoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtFornecedorFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblAdiantamentoFiltro
        '
        Me.lblAdiantamentoFiltro.AutoSize = True
        Me.lblAdiantamentoFiltro.Location = New System.Drawing.Point(321, 57)
        Me.lblAdiantamentoFiltro.Name = "lblAdiantamentoFiltro"
        Me.lblAdiantamentoFiltro.Size = New System.Drawing.Size(76, 14)
        Me.lblAdiantamentoFiltro.TabIndex = 12
        Me.lblAdiantamentoFiltro.Text = "Adiantamento:"
        '
        'cboAdiantamentoFiltro
        '
        Me.cboAdiantamentoFiltro.AutoSize = False
        Me.cboAdiantamentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAdiantamentoFiltro.Location = New System.Drawing.Point(324, 74)
        Me.cboAdiantamentoFiltro.Name = "cboAdiantamentoFiltro"
        Me.cboAdiantamentoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAdiantamentoFiltro.Size = New System.Drawing.Size(128, 20)
        Me.cboAdiantamentoFiltro.TabIndex = 13
        '
        'dtpDataVencimentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataVencimentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoTerminoFiltro.Location = New System.Drawing.Point(114, 74)
        Me.dtpDataVencimentoTerminoFiltro.Name = "dtpDataVencimentoTerminoFiltro"
        Me.dtpDataVencimentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataVencimentoTerminoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataVencimentoTerminoFiltro.TabIndex = 9
        '
        'dtpDataVencimentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataVencimentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoInicioFiltro.Location = New System.Drawing.Point(9, 74)
        Me.dtpDataVencimentoInicioFiltro.Name = "dtpDataVencimentoInicioFiltro"
        Me.dtpDataVencimentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataVencimentoInicioFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataVencimentoInicioFiltro.TabIndex = 8
        '
        'dtpDataEmissaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(219, 34)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 4
        '
        'dtpDataEmissaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(114, 34)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 3
        '
        'txtValorFiltro
        '
        Me.txtValorFiltro.Location = New System.Drawing.Point(219, 74)
        Me.txtValorFiltro.Name = "txtValorFiltro"
        Me.txtValorFiltro.Size = New System.Drawing.Size(99, 20)
        Me.txtValorFiltro.TabIndex = 11
        Me.txtValorFiltro.Text = "0,00"
        Me.txtValorFiltro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorFiltro
        '
        Me.lblValorFiltro.AutoSize = True
        Me.lblValorFiltro.Location = New System.Drawing.Point(216, 57)
        Me.lblValorFiltro.Name = "lblValorFiltro"
        Me.lblValorFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblValorFiltro.TabIndex = 10
        Me.lblValorFiltro.Text = "Valor:"
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(111, 17)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 2
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'txtNumeroDocumentoFiltro
        '
        Me.txtNumeroDocumentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumentoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumentoFiltro.MaxLength = 20
        Me.txtNumeroDocumentoFiltro.Name = "txtNumeroDocumentoFiltro"
        Me.txtNumeroDocumentoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.txtNumeroDocumentoFiltro.TabIndex = 1
        '
        'lblNumeroDocumentoFiltro
        '
        Me.lblNumeroDocumentoFiltro.AutoSize = True
        Me.lblNumeroDocumentoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumentoFiltro.Name = "lblNumeroDocumentoFiltro"
        Me.lblNumeroDocumentoFiltro.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumentoFiltro.TabIndex = 0
        Me.lblNumeroDocumentoFiltro.Text = "Nº Documento:"
        '
        'lblFornecedorFiltro
        '
        Me.lblFornecedorFiltro.AutoSize = True
        Me.lblFornecedorFiltro.Location = New System.Drawing.Point(321, 17)
        Me.lblFornecedorFiltro.Name = "lblFornecedorFiltro"
        Me.lblFornecedorFiltro.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedorFiltro.TabIndex = 5
        Me.lblFornecedorFiltro.Text = "Fornecedor:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 14
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDataVencimentoFiltro
        '
        Me.lblDataVencimentoFiltro.AutoSize = True
        Me.lblDataVencimentoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblDataVencimentoFiltro.Name = "lblDataVencimentoFiltro"
        Me.lblDataVencimentoFiltro.Size = New System.Drawing.Size(91, 14)
        Me.lblDataVencimentoFiltro.TabIndex = 7
        Me.lblDataVencimentoFiltro.Text = "Data Vencimento:"
        '
        'txtFornecedorFiltro
        '
        Me.txtFornecedorFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFornecedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFornecedorFiltro.Location = New System.Drawing.Point(324, 34)
        Me.txtFornecedorFiltro.MaxLength = 20
        Me.txtFornecedorFiltro.Name = "txtFornecedorFiltro"
        Me.txtFornecedorFiltro.Size = New System.Drawing.Size(385, 20)
        Me.txtFornecedorFiltro.TabIndex = 6
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnExcelGridPagamento)
        Me.pagDados.Controls.Add(Me.btnAgruparGridPagamento)
        Me.pagDados.Controls.Add(Me.btnExcelGridParcela)
        Me.pagDados.Controls.Add(Me.btnAgruparGridParcela)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridPagamento)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridParcela)
        Me.pagDados.Controls.Add(Me.grpControle2)
        Me.pagDados.Controls.Add(Me.grdPagamento)
        Me.pagDados.Controls.Add(Me.grdParcela)
        Me.pagDados.Controls.Add(Me.grpPagamento)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(998, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Baixar Duplicatas"
        '
        'btnExcelGridPagamento
        '
        Me.btnExcelGridPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridPagamento.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridPagamento.FlatAppearance.BorderSize = 0
        Me.btnExcelGridPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridPagamento.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridPagamento.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGridPagamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridPagamento.Name = "btnExcelGridPagamento"
        Me.btnExcelGridPagamento.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridPagamento.TabIndex = 28
        Me.btnExcelGridPagamento.TabStop = False
        Me.btnExcelGridPagamento.UseVisualStyleBackColor = False
        '
        'btnAgruparGridPagamento
        '
        Me.btnAgruparGridPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridPagamento.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridPagamento.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridPagamento.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridPagamento.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGridPagamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridPagamento.Name = "btnAgruparGridPagamento"
        Me.btnAgruparGridPagamento.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridPagamento.TabIndex = 27
        Me.btnAgruparGridPagamento.TabStop = False
        Me.btnAgruparGridPagamento.UseVisualStyleBackColor = False
        '
        'btnExcelGridParcela
        '
        Me.btnExcelGridParcela.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridParcela.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridParcela.FlatAppearance.BorderSize = 0
        Me.btnExcelGridParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridParcela.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridParcela.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridParcela.Location = New System.Drawing.Point(57, 185)
        Me.btnExcelGridParcela.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridParcela.Name = "btnExcelGridParcela"
        Me.btnExcelGridParcela.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridParcela.TabIndex = 26
        Me.btnExcelGridParcela.TabStop = False
        Me.btnExcelGridParcela.UseVisualStyleBackColor = False
        '
        'btnAgruparGridParcela
        '
        Me.btnAgruparGridParcela.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridParcela.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridParcela.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridParcela.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridParcela.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridParcela.Location = New System.Drawing.Point(33, 185)
        Me.btnAgruparGridParcela.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridParcela.Name = "btnAgruparGridParcela"
        Me.btnAgruparGridParcela.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridParcela.TabIndex = 25
        Me.btnAgruparGridParcela.TabStop = False
        Me.btnAgruparGridParcela.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridPagamento
        '
        Me.btnConfigurarGridPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridPagamento.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridPagamento.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridPagamento.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridPagamento.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGridPagamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridPagamento.Name = "btnConfigurarGridPagamento"
        Me.btnConfigurarGridPagamento.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridPagamento.TabIndex = 4
        Me.btnConfigurarGridPagamento.TabStop = False
        Me.btnConfigurarGridPagamento.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridParcela
        '
        Me.btnConfigurarGridParcela.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridParcela.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridParcela.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridParcela.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridParcela.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridParcela.Location = New System.Drawing.Point(9, 185)
        Me.btnConfigurarGridParcela.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridParcela.Name = "btnConfigurarGridParcela"
        Me.btnConfigurarGridParcela.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridParcela.TabIndex = 1
        Me.btnConfigurarGridParcela.TabStop = False
        Me.btnConfigurarGridParcela.UseVisualStyleBackColor = False
        '
        'grpControle2
        '
        Me.grpControle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle2.BackColor = System.Drawing.Color.Transparent
        Me.grpControle2.Controls.Add(Me.btnVoltar)
        Me.grpControle2.Controls.Add(Me.btnPagar)
        Me.grpControle2.Location = New System.Drawing.Point(8, 483)
        Me.grpControle2.Name = "grpControle2"
        Me.grpControle2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle2.Size = New System.Drawing.Size(982, 51)
        Me.grpControle2.TabIndex = 5
        Me.grpControle2.VisualStyleManager = Me.vsmMain
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(882, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 1
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnPagar
        '
        Me.btnPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPagar.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnPagar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPagar.Location = New System.Drawing.Point(726, 17)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPagar.Size = New System.Drawing.Size(150, 23)
        Me.btnPagar.TabIndex = 0
        Me.btnPagar.Text = "Baixar Duplicatas"
        Me.btnPagar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdPagamento
        '
        Me.grdPagamento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdPagamento.AlternatingColors = True
        Me.grdPagamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPagamento.AutoEdit = True
        grdPagamento_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdPagamento_DesignTimeLayout_Reference_0.Instance"), Object)
        grdPagamento_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdPagamento_DesignTimeLayout_Reference_0})
        grdPagamento_DesignTimeLayout.LayoutString = resources.GetString("grdPagamento_DesignTimeLayout.LayoutString")
        Me.grdPagamento.DesignTimeLayout = grdPagamento_DesignTimeLayout
        Me.grdPagamento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdPagamento.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdPagamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPagamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPagamento.FrozenColumns = 2
        Me.grdPagamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPagamento.GroupByBoxVisible = False
        Me.grdPagamento.Location = New System.Drawing.Point(8, 318)
        Me.grdPagamento.Name = "grdPagamento"
        Me.grdPagamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPagamento.RecordNavigator = True
        Me.grdPagamento.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdPagamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdPagamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPagamento.Size = New System.Drawing.Size(982, 162)
        Me.grdPagamento.TabIndex = 3
        Me.grdPagamento.TabStop = False
        Me.grdPagamento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPagamento.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdPagamento.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdPagamento.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdPagamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdPagamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPagamento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdPagamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPagamento.VisualStyleManager = Me.vsmMain
        '
        'grdParcela
        '
        Me.grdParcela.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdParcela_DesignTimeLayout.LayoutString = resources.GetString("grdParcela_DesignTimeLayout.LayoutString")
        Me.grdParcela.DesignTimeLayout = grdParcela_DesignTimeLayout
        Me.grdParcela.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdParcela.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdParcela.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdParcela.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdParcela.FrozenColumns = 1
        Me.grdParcela.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdParcela.GroupByBoxVisible = False
        Me.grdParcela.Location = New System.Drawing.Point(8, 9)
        Me.grdParcela.Name = "grdParcela"
        Me.grdParcela.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdParcela.RecordNavigator = True
        Me.grdParcela.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdParcela.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdParcela.Size = New System.Drawing.Size(982, 193)
        Me.grdParcela.TabIndex = 0
        Me.grdParcela.TabStop = False
        Me.grdParcela.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdParcela.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdParcela.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdParcela.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdParcela.VisualStyleManager = Me.vsmMain
        '
        'grpPagamento
        '
        Me.grpPagamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPagamento.BackColor = System.Drawing.Color.Transparent
        Me.grpPagamento.Controls.Add(Me.btnExcluirPagamento)
        Me.grpPagamento.Controls.Add(Me.btnInserirPagamento)
        Me.grpPagamento.Controls.Add(Me.btnCadastrarContaBancaria)
        Me.grpPagamento.Controls.Add(Me.lblTipoDocumentoPagamento)
        Me.grpPagamento.Controls.Add(Me.cboTipoDocumentoPagamento)
        Me.grpPagamento.Controls.Add(Me.lblContaBancaria)
        Me.grpPagamento.Controls.Add(Me.cboContaBancaria)
        Me.grpPagamento.Controls.Add(Me.grpCheque)
        Me.grpPagamento.Controls.Add(Me.grpChequeTerceiro)
        Me.grpPagamento.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpPagamento.Location = New System.Drawing.Point(8, 205)
        Me.grpPagamento.Name = "grpPagamento"
        Me.grpPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPagamento.Size = New System.Drawing.Size(982, 104)
        Me.grpPagamento.TabIndex = 2
        Me.grpPagamento.VisualStyleManager = Me.vsmMain
        '
        'btnExcluirPagamento
        '
        Me.btnExcluirPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirPagamento.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirPagamento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirPagamento.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirPagamento.Location = New System.Drawing.Point(882, 71)
        Me.btnExcluirPagamento.Name = "btnExcluirPagamento"
        Me.btnExcluirPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirPagamento.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirPagamento.TabIndex = 12
        Me.btnExcluirPagamento.Text = "Excluir"
        Me.btnExcluirPagamento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirPagamento
        '
        Me.btnInserirPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirPagamento.Image = CType(resources.GetObject("btnInserirPagamento.Image"), System.Drawing.Image)
        Me.btnInserirPagamento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirPagamento.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirPagamento.Location = New System.Drawing.Point(882, 42)
        Me.btnInserirPagamento.Name = "btnInserirPagamento"
        Me.btnInserirPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirPagamento.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirPagamento.TabIndex = 11
        Me.btnInserirPagamento.Text = "Inserir"
        Me.btnInserirPagamento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCadastrarContaBancaria
        '
        Me.btnCadastrarContaBancaria.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaBancaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaBancaria.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaBancaria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaBancaria.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarContaBancaria.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaBancaria.Name = "btnCadastrarContaBancaria"
        Me.btnCadastrarContaBancaria.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaBancaria.TabIndex = 0
        Me.btnCadastrarContaBancaria.TabStop = False
        Me.btnCadastrarContaBancaria.UseVisualStyleBackColor = True
        '
        'lblTipoDocumentoPagamento
        '
        Me.lblTipoDocumentoPagamento.AutoSize = True
        Me.lblTipoDocumentoPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoDocumentoPagamento.Location = New System.Drawing.Point(6, 57)
        Me.lblTipoDocumentoPagamento.Name = "lblTipoDocumentoPagamento"
        Me.lblTipoDocumentoPagamento.Size = New System.Drawing.Size(111, 14)
        Me.lblTipoDocumentoPagamento.TabIndex = 3
        Me.lblTipoDocumentoPagamento.Text = "Forma de Pagamento:"
        '
        'cboTipoDocumentoPagamento
        '
        Me.cboTipoDocumentoPagamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoDocumentoPagamento.AutoSize = False
        Me.cboTipoDocumentoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoDocumentoPagamento.Location = New System.Drawing.Point(9, 74)
        Me.cboTipoDocumentoPagamento.Name = "cboTipoDocumentoPagamento"
        Me.cboTipoDocumentoPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoDocumentoPagamento.Size = New System.Drawing.Size(273, 20)
        Me.cboTipoDocumentoPagamento.TabIndex = 4
        '
        'lblContaBancaria
        '
        Me.lblContaBancaria.AutoSize = True
        Me.lblContaBancaria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContaBancaria.Location = New System.Drawing.Point(25, 17)
        Me.lblContaBancaria.Name = "lblContaBancaria"
        Me.lblContaBancaria.Size = New System.Drawing.Size(84, 14)
        Me.lblContaBancaria.TabIndex = 1
        Me.lblContaBancaria.Text = "Conta Bancária:"
        '
        'cboContaBancaria
        '
        Me.cboContaBancaria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboContaBancaria.AutoSize = False
        Me.cboContaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaBancaria.Location = New System.Drawing.Point(9, 34)
        Me.cboContaBancaria.Name = "cboContaBancaria"
        Me.cboContaBancaria.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaBancaria.Size = New System.Drawing.Size(273, 20)
        Me.cboContaBancaria.TabIndex = 2
        '
        'grpCheque
        '
        Me.grpCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCheque.BackColor = System.Drawing.Color.Transparent
        Me.grpCheque.BorderColor = System.Drawing.Color.Transparent
        Me.grpCheque.Controls.Add(Me.btnAtualizarCheque)
        Me.grpCheque.Controls.Add(Me.btnAtualizar)
        Me.grpCheque.Controls.Add(Me.lblNumeroCheque)
        Me.grpCheque.Controls.Add(Me.dtpDataCompensacaoCheque)
        Me.grpCheque.Controls.Add(Me.cboCheque)
        Me.grpCheque.Controls.Add(Me.dtpDataPagamentoCheque)
        Me.grpCheque.Controls.Add(Me.lblDataCompensacaoCheque)
        Me.grpCheque.Controls.Add(Me.txtValorCheque)
        Me.grpCheque.Controls.Add(Me.lblValorCheque)
        Me.grpCheque.Controls.Add(Me.lblDataPagamentoCheque)
        Me.grpCheque.Controls.Add(Me.lblPreDatadoCheque)
        Me.grpCheque.Controls.Add(Me.cboPreDatadoCheque)
        Me.grpCheque.Controls.Add(Me.txtFavorecidoCheque)
        Me.grpCheque.Controls.Add(Me.lblFavorecidoCheque)
        Me.grpCheque.Location = New System.Drawing.Point(284, 0)
        Me.grpCheque.Name = "grpCheque"
        Me.grpCheque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCheque.Size = New System.Drawing.Size(505, 104)
        Me.grpCheque.TabIndex = 1
        Me.grpCheque.Visible = False
        Me.grpCheque.VisualStyleManager = Me.vsmMain
        '
        'btnAtualizarCheque
        '
        Me.btnAtualizarCheque.FlatAppearance.BorderSize = 0
        Me.btnAtualizarCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizarCheque.Image = CType(resources.GetObject("btnAtualizarCheque.Image"), System.Drawing.Image)
        Me.btnAtualizarCheque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAtualizarCheque.Location = New System.Drawing.Point(94, 13)
        Me.btnAtualizarCheque.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAtualizarCheque.Name = "btnAtualizarCheque"
        Me.btnAtualizarCheque.Size = New System.Drawing.Size(18, 20)
        Me.btnAtualizarCheque.TabIndex = 28
        Me.btnAtualizarCheque.TabStop = False
        Me.btnAtualizarCheque.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtualizar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnAtualizar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAtualizar.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnAtualizar.Location = New System.Drawing.Point(315, 71)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAtualizar.Size = New System.Drawing.Size(103, 23)
        Me.btnAtualizar.TabIndex = 15
        Me.btnAtualizar.Text = "Atualizar Valor"
        Me.btnAtualizar.Visible = False
        Me.btnAtualizar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblNumeroCheque
        '
        Me.lblNumeroCheque.AutoSize = True
        Me.lblNumeroCheque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroCheque.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroCheque.Name = "lblNumeroCheque"
        Me.lblNumeroCheque.Size = New System.Drawing.Size(62, 14)
        Me.lblNumeroCheque.TabIndex = 13
        Me.lblNumeroCheque.Text = "Nº Cheque:"
        '
        'dtpDataCompensacaoCheque
        '
        '
        '
        '
        Me.dtpDataCompensacaoCheque.DropDownCalendar.Name = ""
        Me.dtpDataCompensacaoCheque.Location = New System.Drawing.Point(216, 74)
        Me.dtpDataCompensacaoCheque.Name = "dtpDataCompensacaoCheque"
        Me.dtpDataCompensacaoCheque.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataCompensacaoCheque.TabIndex = 9
        '
        'cboCheque
        '
        Me.cboCheque.AutoSize = False
        Me.cboCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCheque.Location = New System.Drawing.Point(9, 34)
        Me.cboCheque.Name = "cboCheque"
        Me.cboCheque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCheque.Size = New System.Drawing.Size(104, 20)
        Me.cboCheque.TabIndex = 14
        '
        'dtpDataPagamentoCheque
        '
        '
        '
        '
        Me.dtpDataPagamentoCheque.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoCheque.Location = New System.Drawing.Point(119, 34)
        Me.dtpDataPagamentoCheque.Name = "dtpDataPagamentoCheque"
        Me.dtpDataPagamentoCheque.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoCheque.TabIndex = 1
        '
        'lblDataCompensacaoCheque
        '
        Me.lblDataCompensacaoCheque.AutoSize = True
        Me.lblDataCompensacaoCheque.Location = New System.Drawing.Point(213, 57)
        Me.lblDataCompensacaoCheque.Name = "lblDataCompensacaoCheque"
        Me.lblDataCompensacaoCheque.Size = New System.Drawing.Size(88, 14)
        Me.lblDataCompensacaoCheque.TabIndex = 8
        Me.lblDataCompensacaoCheque.Text = "Pré-datado para:"
        '
        'txtValorCheque
        '
        Me.txtValorCheque.Location = New System.Drawing.Point(9, 74)
        Me.txtValorCheque.Name = "txtValorCheque"
        Me.txtValorCheque.Size = New System.Drawing.Size(104, 20)
        Me.txtValorCheque.TabIndex = 3
        Me.txtValorCheque.Text = "0,00"
        Me.txtValorCheque.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorCheque
        '
        Me.lblValorCheque.AutoSize = True
        Me.lblValorCheque.Location = New System.Drawing.Point(6, 57)
        Me.lblValorCheque.Name = "lblValorCheque"
        Me.lblValorCheque.Size = New System.Drawing.Size(75, 14)
        Me.lblValorCheque.TabIndex = 10
        Me.lblValorCheque.Text = "Valor Cheque:"
        '
        'lblDataPagamentoCheque
        '
        Me.lblDataPagamentoCheque.AutoSize = True
        Me.lblDataPagamentoCheque.Location = New System.Drawing.Point(116, 17)
        Me.lblDataPagamentoCheque.Name = "lblDataPagamentoCheque"
        Me.lblDataPagamentoCheque.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoCheque.TabIndex = 2
        Me.lblDataPagamentoCheque.Text = "Data Pgto.:"
        '
        'lblPreDatadoCheque
        '
        Me.lblPreDatadoCheque.AutoSize = True
        Me.lblPreDatadoCheque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPreDatadoCheque.Location = New System.Drawing.Point(116, 57)
        Me.lblPreDatadoCheque.Name = "lblPreDatadoCheque"
        Me.lblPreDatadoCheque.Size = New System.Drawing.Size(63, 14)
        Me.lblPreDatadoCheque.TabIndex = 6
        Me.lblPreDatadoCheque.Text = "Pré-datado:"
        '
        'cboPreDatadoCheque
        '
        Me.cboPreDatadoCheque.AutoSize = False
        Me.cboPreDatadoCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPreDatadoCheque.Location = New System.Drawing.Point(119, 74)
        Me.cboPreDatadoCheque.Name = "cboPreDatadoCheque"
        Me.cboPreDatadoCheque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPreDatadoCheque.Size = New System.Drawing.Size(91, 20)
        Me.cboPreDatadoCheque.TabIndex = 4
        '
        'txtFavorecidoCheque
        '
        Me.txtFavorecidoCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFavorecidoCheque.Location = New System.Drawing.Point(216, 34)
        Me.txtFavorecidoCheque.MaxLength = 100
        Me.txtFavorecidoCheque.Name = "txtFavorecidoCheque"
        Me.txtFavorecidoCheque.Size = New System.Drawing.Size(289, 20)
        Me.txtFavorecidoCheque.TabIndex = 2
        '
        'lblFavorecidoCheque
        '
        Me.lblFavorecidoCheque.AutoSize = True
        Me.lblFavorecidoCheque.Location = New System.Drawing.Point(213, 17)
        Me.lblFavorecidoCheque.Name = "lblFavorecidoCheque"
        Me.lblFavorecidoCheque.Size = New System.Drawing.Size(64, 14)
        Me.lblFavorecidoCheque.TabIndex = 4
        Me.lblFavorecidoCheque.Text = "Favorecido:"
        '
        'grpChequeTerceiro
        '
        Me.grpChequeTerceiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpChequeTerceiro.BackColor = System.Drawing.Color.Transparent
        Me.grpChequeTerceiro.BorderColor = System.Drawing.Color.Transparent
        Me.grpChequeTerceiro.Controls.Add(Me.dtpDataPagamentoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.txtValorChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblValorChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.txtPreDatadoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblPreDatadoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.cboNumeroDocumentoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblNumeroDocumentoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.txtDataRecebimentoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblDataRecebimentoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.txtContaChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblContaChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.txtAgenciaChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblAgenciaChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.txtBancoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblBancoChequeTerceiro)
        Me.grpChequeTerceiro.Controls.Add(Me.lblDataPagamentoChequeTerceiro)
        Me.grpChequeTerceiro.Location = New System.Drawing.Point(289, 0)
        Me.grpChequeTerceiro.Name = "grpChequeTerceiro"
        Me.grpChequeTerceiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpChequeTerceiro.Size = New System.Drawing.Size(505, 104)
        Me.grpChequeTerceiro.TabIndex = 1
        Me.grpChequeTerceiro.Visible = False
        Me.grpChequeTerceiro.VisualStyleManager = Me.vsmMain
        '
        'dtpDataPagamentoChequeTerceiro
        '
        '
        '
        '
        Me.dtpDataPagamentoChequeTerceiro.DropDownCalendar.Name = ""
        Me.dtpDataPagamentoChequeTerceiro.Location = New System.Drawing.Point(119, 34)
        Me.dtpDataPagamentoChequeTerceiro.Name = "dtpDataPagamentoChequeTerceiro"
        Me.dtpDataPagamentoChequeTerceiro.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataPagamentoChequeTerceiro.TabIndex = 2
        '
        'txtValorChequeTerceiro
        '
        Me.txtValorChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorChequeTerceiro.Location = New System.Drawing.Point(310, 74)
        Me.txtValorChequeTerceiro.Name = "txtValorChequeTerceiro"
        Me.txtValorChequeTerceiro.ReadOnly = True
        Me.txtValorChequeTerceiro.Size = New System.Drawing.Size(98, 20)
        Me.txtValorChequeTerceiro.TabIndex = 9
        Me.txtValorChequeTerceiro.TabStop = False
        Me.txtValorChequeTerceiro.Text = "0,00"
        Me.txtValorChequeTerceiro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorChequeTerceiro
        '
        Me.lblValorChequeTerceiro.AutoSize = True
        Me.lblValorChequeTerceiro.Location = New System.Drawing.Point(307, 57)
        Me.lblValorChequeTerceiro.Name = "lblValorChequeTerceiro"
        Me.lblValorChequeTerceiro.Size = New System.Drawing.Size(75, 14)
        Me.lblValorChequeTerceiro.TabIndex = 12
        Me.lblValorChequeTerceiro.Text = "Valor Cheque:"
        '
        'txtPreDatadoChequeTerceiro
        '
        Me.txtPreDatadoChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPreDatadoChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPreDatadoChequeTerceiro.Location = New System.Drawing.Point(216, 74)
        Me.txtPreDatadoChequeTerceiro.MaxLength = 20
        Me.txtPreDatadoChequeTerceiro.Name = "txtPreDatadoChequeTerceiro"
        Me.txtPreDatadoChequeTerceiro.ReadOnly = True
        Me.txtPreDatadoChequeTerceiro.Size = New System.Drawing.Size(88, 20)
        Me.txtPreDatadoChequeTerceiro.TabIndex = 8
        Me.txtPreDatadoChequeTerceiro.TabStop = False
        '
        'lblPreDatadoChequeTerceiro
        '
        Me.lblPreDatadoChequeTerceiro.AutoSize = True
        Me.lblPreDatadoChequeTerceiro.Location = New System.Drawing.Point(213, 57)
        Me.lblPreDatadoChequeTerceiro.Name = "lblPreDatadoChequeTerceiro"
        Me.lblPreDatadoChequeTerceiro.Size = New System.Drawing.Size(88, 14)
        Me.lblPreDatadoChequeTerceiro.TabIndex = 10
        Me.lblPreDatadoChequeTerceiro.Text = "Pré-datado para:"
        '
        'cboNumeroDocumentoChequeTerceiro
        '
        Me.cboNumeroDocumentoChequeTerceiro.AutoSize = False
        Me.cboNumeroDocumentoChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNumeroDocumentoChequeTerceiro.Location = New System.Drawing.Point(9, 34)
        Me.cboNumeroDocumentoChequeTerceiro.Name = "cboNumeroDocumentoChequeTerceiro"
        Me.cboNumeroDocumentoChequeTerceiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNumeroDocumentoChequeTerceiro.Size = New System.Drawing.Size(104, 20)
        Me.cboNumeroDocumentoChequeTerceiro.TabIndex = 1
        '
        'lblNumeroDocumentoChequeTerceiro
        '
        Me.lblNumeroDocumentoChequeTerceiro.AutoSize = True
        Me.lblNumeroDocumentoChequeTerceiro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumentoChequeTerceiro.Name = "lblNumeroDocumentoChequeTerceiro"
        Me.lblNumeroDocumentoChequeTerceiro.Size = New System.Drawing.Size(62, 14)
        Me.lblNumeroDocumentoChequeTerceiro.TabIndex = 0
        Me.lblNumeroDocumentoChequeTerceiro.Text = "Nº Cheque:"
        '
        'txtDataRecebimentoChequeTerceiro
        '
        Me.txtDataRecebimentoChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataRecebimentoChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataRecebimentoChequeTerceiro.Location = New System.Drawing.Point(119, 74)
        Me.txtDataRecebimentoChequeTerceiro.MaxLength = 20
        Me.txtDataRecebimentoChequeTerceiro.Name = "txtDataRecebimentoChequeTerceiro"
        Me.txtDataRecebimentoChequeTerceiro.ReadOnly = True
        Me.txtDataRecebimentoChequeTerceiro.Size = New System.Drawing.Size(91, 20)
        Me.txtDataRecebimentoChequeTerceiro.TabIndex = 7
        Me.txtDataRecebimentoChequeTerceiro.TabStop = False
        '
        'lblDataRecebimentoChequeTerceiro
        '
        Me.lblDataRecebimentoChequeTerceiro.AutoSize = True
        Me.lblDataRecebimentoChequeTerceiro.Location = New System.Drawing.Point(116, 57)
        Me.lblDataRecebimentoChequeTerceiro.Name = "lblDataRecebimentoChequeTerceiro"
        Me.lblDataRecebimentoChequeTerceiro.Size = New System.Drawing.Size(72, 14)
        Me.lblDataRecebimentoChequeTerceiro.TabIndex = 8
        Me.lblDataRecebimentoChequeTerceiro.Text = "Recebido em:"
        '
        'txtContaChequeTerceiro
        '
        Me.txtContaChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtContaChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContaChequeTerceiro.Location = New System.Drawing.Point(9, 74)
        Me.txtContaChequeTerceiro.MaxLength = 20
        Me.txtContaChequeTerceiro.Name = "txtContaChequeTerceiro"
        Me.txtContaChequeTerceiro.ReadOnly = True
        Me.txtContaChequeTerceiro.Size = New System.Drawing.Size(104, 20)
        Me.txtContaChequeTerceiro.TabIndex = 4
        Me.txtContaChequeTerceiro.TabStop = False
        '
        'lblContaChequeTerceiro
        '
        Me.lblContaChequeTerceiro.AutoSize = True
        Me.lblContaChequeTerceiro.Location = New System.Drawing.Point(6, 57)
        Me.lblContaChequeTerceiro.Name = "lblContaChequeTerceiro"
        Me.lblContaChequeTerceiro.Size = New System.Drawing.Size(38, 14)
        Me.lblContaChequeTerceiro.TabIndex = 6
        Me.lblContaChequeTerceiro.Text = "Conta:"
        '
        'txtAgenciaChequeTerceiro
        '
        Me.txtAgenciaChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAgenciaChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAgenciaChequeTerceiro.Location = New System.Drawing.Point(414, 34)
        Me.txtAgenciaChequeTerceiro.MaxLength = 20
        Me.txtAgenciaChequeTerceiro.Name = "txtAgenciaChequeTerceiro"
        Me.txtAgenciaChequeTerceiro.ReadOnly = True
        Me.txtAgenciaChequeTerceiro.Size = New System.Drawing.Size(91, 20)
        Me.txtAgenciaChequeTerceiro.TabIndex = 6
        Me.txtAgenciaChequeTerceiro.TabStop = False
        '
        'lblAgenciaChequeTerceiro
        '
        Me.lblAgenciaChequeTerceiro.AutoSize = True
        Me.lblAgenciaChequeTerceiro.Location = New System.Drawing.Point(411, 17)
        Me.lblAgenciaChequeTerceiro.Name = "lblAgenciaChequeTerceiro"
        Me.lblAgenciaChequeTerceiro.Size = New System.Drawing.Size(50, 14)
        Me.lblAgenciaChequeTerceiro.TabIndex = 4
        Me.lblAgenciaChequeTerceiro.Text = "Agência:"
        '
        'txtBancoChequeTerceiro
        '
        Me.txtBancoChequeTerceiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBancoChequeTerceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBancoChequeTerceiro.Location = New System.Drawing.Point(216, 34)
        Me.txtBancoChequeTerceiro.MaxLength = 20
        Me.txtBancoChequeTerceiro.Name = "txtBancoChequeTerceiro"
        Me.txtBancoChequeTerceiro.ReadOnly = True
        Me.txtBancoChequeTerceiro.Size = New System.Drawing.Size(192, 20)
        Me.txtBancoChequeTerceiro.TabIndex = 4
        Me.txtBancoChequeTerceiro.TabStop = False
        '
        'lblBancoChequeTerceiro
        '
        Me.lblBancoChequeTerceiro.AutoSize = True
        Me.lblBancoChequeTerceiro.Location = New System.Drawing.Point(213, 17)
        Me.lblBancoChequeTerceiro.Name = "lblBancoChequeTerceiro"
        Me.lblBancoChequeTerceiro.Size = New System.Drawing.Size(41, 14)
        Me.lblBancoChequeTerceiro.TabIndex = 2
        Me.lblBancoChequeTerceiro.Text = "Banco:"
        '
        'lblDataPagamentoChequeTerceiro
        '
        Me.lblDataPagamentoChequeTerceiro.AutoSize = True
        Me.lblDataPagamentoChequeTerceiro.Location = New System.Drawing.Point(116, 17)
        Me.lblDataPagamentoChequeTerceiro.Name = "lblDataPagamentoChequeTerceiro"
        Me.lblDataPagamentoChequeTerceiro.Size = New System.Drawing.Size(59, 14)
        Me.lblDataPagamentoChequeTerceiro.TabIndex = 14
        Me.lblDataPagamentoChequeTerceiro.Text = "Data Pgto.:"
        '
        'usrFinDespesaPagamentoCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFinDespesaPagamentoCheque"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picParcelaVencimentoFuturo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picParcelaVencimentoAtrasado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpValorSelecionado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpValorSelecionado.ResumeLayout(False)
        Me.grpValorSelecionado.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.grpControle.PerformLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle2.ResumeLayout(False)
        CType(Me.grdPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdParcela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPagamento.ResumeLayout(False)
        Me.grpPagamento.PerformLayout()
        CType(Me.grpCheque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCheque.ResumeLayout(False)
        Me.grpCheque.PerformLayout()
        CType(Me.grpChequeTerceiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpChequeTerceiro.ResumeLayout(False)
        Me.grpChequeTerceiro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNumeroDocumentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblFornecedorFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataVencimentoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Private WithEvents btnPagar1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpValorSelecionado As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblValorTitulo As System.Windows.Forms.Label
    Friend WithEvents lblLabelValorTitulo As System.Windows.Forms.Label
    Friend WithEvents txtValorFiltro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorFiltro As System.Windows.Forms.Label
    Friend WithEvents txtFornecedorFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grdParcela As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpControle2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Private WithEvents btnPagar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdPagamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpPagamento As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluirPagamento As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirPagamento As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCadastrarContaBancaria As System.Windows.Forms.Button
    Friend WithEvents lblTipoDocumentoPagamento As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumentoPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblContaBancaria As System.Windows.Forms.Label
    Friend WithEvents cboContaBancaria As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpChequeTerceiro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataPagamentoChequeTerceiro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValorChequeTerceiro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents txtPreDatadoChequeTerceiro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPreDatadoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents cboNumeroDocumentoChequeTerceiro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNumeroDocumentoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents txtDataRecebimentoChequeTerceiro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataRecebimentoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents txtContaChequeTerceiro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblContaChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents txtAgenciaChequeTerceiro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAgenciaChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents txtBancoChequeTerceiro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblBancoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoChequeTerceiro As System.Windows.Forms.Label
    Friend WithEvents grpCheque As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataCompensacaoCheque As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPagamentoCheque As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataCompensacaoCheque As System.Windows.Forms.Label
    Friend WithEvents txtValorCheque As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorCheque As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamentoCheque As System.Windows.Forms.Label
    Friend WithEvents lblPreDatadoCheque As System.Windows.Forms.Label
    Friend WithEvents cboPreDatadoCheque As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtFavorecidoCheque As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFavorecidoCheque As System.Windows.Forms.Label
    Friend WithEvents dtpDataVencimentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataVencimentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblParcelaVencimentoFuturo As System.Windows.Forms.Label
    Friend WithEvents picParcelaVencimentoFuturo As System.Windows.Forms.PictureBox
    Friend WithEvents lblParcelaVencimentoAtrasado As System.Windows.Forms.Label
    Friend WithEvents picParcelaVencimentoAtrasado As System.Windows.Forms.PictureBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridPagamento As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridParcela As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblAdiantamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboAdiantamentoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridPagamento As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridPagamento As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridParcela As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridParcela As System.Windows.Forms.Button
    Friend WithEvents lblNumeroCheque As System.Windows.Forms.Label
    Friend WithEvents cboCheque As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnAtualizar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAtualizarCheque As System.Windows.Forms.Button

End Class
