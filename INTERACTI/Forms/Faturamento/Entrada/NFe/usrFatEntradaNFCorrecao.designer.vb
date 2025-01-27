<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFatEntradaNFCorrecao
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
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim cboCFOPFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdLote_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdLote_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFatEntradaNFCorrecao))
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipoOperacaoFiltro = New System.Windows.Forms.Label()
        Me.cboTipoOperacaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataEntradaInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEntradaTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEntradaFiltro = New System.Windows.Forms.Label()
        Me.txtLoteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblLoteFiltro = New System.Windows.Forms.Label()
        Me.lblProdutoFiltro = New System.Windows.Forms.Label()
        Me.txtProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroDocumentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoFiltro = New System.Windows.Forms.Label()
        Me.cboCFOPFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.lblCFOPFiltro = New System.Windows.Forms.Label()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtEmitenteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtSerieFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerieFiltro = New System.Windows.Forms.Label()
        Me.txtNotaFiscalFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.lblEmitenteFiltro = New System.Windows.Forms.Label()
        Me.lblNotaFiscalFiltro = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLote = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnAtualizarPedidoCompra = New System.Windows.Forms.Button()
        Me.lblLoteQuantidadeDocumento = New System.Windows.Forms.Label()
        Me.txtLoteQuantidadeDocumento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboLoteProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.cboLoteNumeroDocumento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoOperacao = New System.Windows.Forms.Label()
        Me.cboLoteTipoOperacao = New Janus.Windows.EditControls.UIComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCentroGasto = New System.Windows.Forms.Label()
        Me.cboLoteCentroGasto = New Janus.Windows.EditControls.UIComboBox()
        Me.cboLoteControlaQualidade = New Janus.Windows.EditControls.UIComboBox()
        Me.lblContaContabil = New System.Windows.Forms.Label()
        Me.cboLoteContaContabil = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUnidadeMedida = New System.Windows.Forms.Label()
        Me.cboLoteUnidadeMedida = New Janus.Windows.EditControls.UIComboBox()
        Me.lblQuantidadeEstoque = New System.Windows.Forms.Label()
        Me.txtLoteQuantidadeEstoque = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDataFabricacao = New System.Windows.Forms.Label()
        Me.dtpLoteDataFabricacao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataValidade = New System.Windows.Forms.Label()
        Me.dtpLoteDataValidade = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.txtLoteFabricante = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFatorConversao = New System.Windows.Forms.Label()
        Me.txtLoteFatorConversao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.cboLoteDeposito = New Janus.Windows.EditControls.UIComboBox()
        Me.lblLoteQuantidade = New System.Windows.Forms.Label()
        Me.txtLoteQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnExcelGridProduto = New System.Windows.Forms.Button()
        Me.btnAgruparGridProduto = New System.Windows.Forms.Button()
        Me.btnConfigurarGridProduto = New System.Windows.Forms.Button()
        Me.grpItem = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboCSTICMS = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCSTICMS = New System.Windows.Forms.Label()
        Me.cboCSTIPI = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCSTIPI = New System.Windows.Forms.Label()
        Me.txtNotaFiscal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblBCICMS = New System.Windows.Forms.Label()
        Me.txtBCICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorICMS = New System.Windows.Forms.Label()
        Me.txtValorICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBCIPI = New System.Windows.Forms.Label()
        Me.txtBCIPI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorIPI = New System.Windows.Forms.Label()
        Me.txtValorIPI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtNCM = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNCM = New System.Windows.Forms.Label()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.txtValorTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnitario = New System.Windows.Forms.Label()
        Me.txtValorUnitario = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnFindCFOPDestinacao = New System.Windows.Forms.Button()
        Me.btnCadastrarCFOP = New System.Windows.Forms.Button()
        Me.lblCFOP = New System.Windows.Forms.Label()
        Me.cboCFOP = New Janus.Windows.EditControls.UIComboBox()
        Me.txtUnidadeMedida = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grdLote = New Janus.Windows.GridEX.GridEX()
        Me.btnCadastrarProduto = New System.Windows.Forms.Button()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpLote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLote.SuspendLayout()
        CType(Me.grpItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItem.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grdLote, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(1031, 700)
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
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(1029, 677)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Entrada - Nota Fiscal - Correção"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 597)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 4
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 597)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 3
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 597)
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
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 157)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(1013, 457)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
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
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblTipoOperacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoOperacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEntradaInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEntradaTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEntradaFiltro)
        Me.grpFiltro.Controls.Add(Me.txtLoteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblLoteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboCFOPFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCFOPFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtEmitenteFiltro)
        Me.grpFiltro.Controls.Add(Me.txtSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.lblSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblEmitenteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNotaFiscalFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(1013, 144)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblTipoOperacaoFiltro
        '
        Me.lblTipoOperacaoFiltro.AutoSize = True
        Me.lblTipoOperacaoFiltro.Location = New System.Drawing.Point(116, 97)
        Me.lblTipoOperacaoFiltro.Name = "lblTipoOperacaoFiltro"
        Me.lblTipoOperacaoFiltro.Size = New System.Drawing.Size(96, 14)
        Me.lblTipoOperacaoFiltro.TabIndex = 18
        Me.lblTipoOperacaoFiltro.Text = "Tipo de Operação:"
        '
        'cboTipoOperacaoFiltro
        '
        Me.cboTipoOperacaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoOperacaoFiltro.Location = New System.Drawing.Point(119, 114)
        Me.cboTipoOperacaoFiltro.Name = "cboTipoOperacaoFiltro"
        Me.cboTipoOperacaoFiltro.Size = New System.Drawing.Size(189, 20)
        Me.cboTipoOperacaoFiltro.TabIndex = 19
        '
        'dtpDataEntradaInicioFiltro
        '
        Me.dtpDataEntradaInicioFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataEntradaInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEntradaInicioFiltro.Location = New System.Drawing.Point(668, 74)
        Me.dtpDataEntradaInicioFiltro.Name = "dtpDataEntradaInicioFiltro"
        Me.dtpDataEntradaInicioFiltro.ShowCheckBox = True
        Me.dtpDataEntradaInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEntradaInicioFiltro.TabIndex = 14
        Me.dtpDataEntradaInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataEntradaTerminoFiltro
        '
        Me.dtpDataEntradaTerminoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataEntradaTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEntradaTerminoFiltro.Location = New System.Drawing.Point(782, 74)
        Me.dtpDataEntradaTerminoFiltro.Name = "dtpDataEntradaTerminoFiltro"
        Me.dtpDataEntradaTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEntradaTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEntradaTerminoFiltro.TabIndex = 15
        Me.dtpDataEntradaTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataEntradaFiltro
        '
        Me.lblDataEntradaFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataEntradaFiltro.AutoSize = True
        Me.lblDataEntradaFiltro.Location = New System.Drawing.Point(665, 57)
        Me.lblDataEntradaFiltro.Name = "lblDataEntradaFiltro"
        Me.lblDataEntradaFiltro.Size = New System.Drawing.Size(72, 14)
        Me.lblDataEntradaFiltro.TabIndex = 13
        Me.lblDataEntradaFiltro.Text = "Data Entrada:"
        '
        'txtLoteFiltro
        '
        Me.txtLoteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLoteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLoteFiltro.Location = New System.Drawing.Point(544, 74)
        Me.txtLoteFiltro.MaxLength = 50
        Me.txtLoteFiltro.Name = "txtLoteFiltro"
        Me.txtLoteFiltro.Size = New System.Drawing.Size(118, 20)
        Me.txtLoteFiltro.TabIndex = 12
        '
        'lblLoteFiltro
        '
        Me.lblLoteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoteFiltro.AutoSize = True
        Me.lblLoteFiltro.Location = New System.Drawing.Point(541, 57)
        Me.lblLoteFiltro.Name = "lblLoteFiltro"
        Me.lblLoteFiltro.Size = New System.Drawing.Size(31, 14)
        Me.lblLoteFiltro.TabIndex = 11
        Me.lblLoteFiltro.Text = "Lote:"
        '
        'lblProdutoFiltro
        '
        Me.lblProdutoFiltro.AutoSize = True
        Me.lblProdutoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblProdutoFiltro.Name = "lblProdutoFiltro"
        Me.lblProdutoFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblProdutoFiltro.TabIndex = 9
        Me.lblProdutoFiltro.Text = "Produto:"
        '
        'txtProdutoFiltro
        '
        Me.txtProdutoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtProdutoFiltro.MaxLength = 120
        Me.txtProdutoFiltro.Name = "txtProdutoFiltro"
        Me.txtProdutoFiltro.Size = New System.Drawing.Size(529, 20)
        Me.txtProdutoFiltro.TabIndex = 10
        '
        'txtNumeroDocumentoFiltro
        '
        Me.txtNumeroDocumentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumentoFiltro.Location = New System.Drawing.Point(314, 114)
        Me.txtNumeroDocumentoFiltro.MaxLength = 20
        Me.txtNumeroDocumentoFiltro.Name = "txtNumeroDocumentoFiltro"
        Me.txtNumeroDocumentoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.txtNumeroDocumentoFiltro.TabIndex = 21
        '
        'lblNumeroDocumentoFiltro
        '
        Me.lblNumeroDocumentoFiltro.AutoSize = True
        Me.lblNumeroDocumentoFiltro.Location = New System.Drawing.Point(311, 97)
        Me.lblNumeroDocumentoFiltro.Name = "lblNumeroDocumentoFiltro"
        Me.lblNumeroDocumentoFiltro.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumentoFiltro.TabIndex = 20
        Me.lblNumeroDocumentoFiltro.Text = "Nº Documento:"
        '
        'cboCFOPFiltro
        '
        Me.cboCFOPFiltro.AllowDrop = True
        Me.cboCFOPFiltro.ButtonCancelText = "Cancelar"
        Me.cboCFOPFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboCFOPFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboCFOPFiltro_DesignTimeLayout.LayoutString")
        Me.cboCFOPFiltro.DesignTimeLayout = cboCFOPFiltro_DesignTimeLayout
        Me.cboCFOPFiltro.Location = New System.Drawing.Point(9, 114)
        Me.cboCFOPFiltro.Name = "cboCFOPFiltro"
        Me.cboCFOPFiltro.SaveSettings = False
        Me.cboCFOPFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboCFOPFiltro.Size = New System.Drawing.Size(104, 20)
        Me.cboCFOPFiltro.TabIndex = 17
        Me.cboCFOPFiltro.ValuesDataMember = Nothing
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(428, 114)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(462, 20)
        Me.cboStatusFiltro.TabIndex = 23
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(425, 97)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 22
        Me.lblStatusFiltro.Text = "Status:"
        '
        'lblCFOPFiltro
        '
        Me.lblCFOPFiltro.AutoSize = True
        Me.lblCFOPFiltro.Location = New System.Drawing.Point(6, 97)
        Me.lblCFOPFiltro.Name = "lblCFOPFiltro"
        Me.lblCFOPFiltro.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOPFiltro.TabIndex = 16
        Me.lblCFOPFiltro.Text = "CFOP:"
        '
        'dtpDataEmissaoInicioFiltro
        '
        Me.dtpDataEmissaoInicioFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(668, 34)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 7
        Me.dtpDataEmissaoInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataEmissaoTerminoFiltro
        '
        Me.dtpDataEmissaoTerminoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(782, 34)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 8
        Me.dtpDataEmissaoTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'txtEmitenteFiltro
        '
        Me.txtEmitenteFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmitenteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmitenteFiltro.Location = New System.Drawing.Point(185, 34)
        Me.txtEmitenteFiltro.MaxLength = 60
        Me.txtEmitenteFiltro.Name = "txtEmitenteFiltro"
        Me.txtEmitenteFiltro.Size = New System.Drawing.Size(477, 20)
        Me.txtEmitenteFiltro.TabIndex = 5
        '
        'txtSerieFiltro
        '
        Me.txtSerieFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieFiltro.Location = New System.Drawing.Point(119, 34)
        Me.txtSerieFiltro.MaxLength = 3
        Me.txtSerieFiltro.Name = "txtSerieFiltro"
        Me.txtSerieFiltro.Size = New System.Drawing.Size(60, 20)
        Me.txtSerieFiltro.TabIndex = 3
        '
        'lblSerieFiltro
        '
        Me.lblSerieFiltro.AutoSize = True
        Me.lblSerieFiltro.Location = New System.Drawing.Point(116, 17)
        Me.lblSerieFiltro.Name = "lblSerieFiltro"
        Me.lblSerieFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblSerieFiltro.TabIndex = 2
        Me.lblSerieFiltro.Text = "Série:"
        '
        'txtNotaFiscalFiltro
        '
        Me.txtNotaFiscalFiltro.IncludeLiterals = False
        Me.txtNotaFiscalFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNotaFiscalFiltro.MaxLength = 9
        Me.txtNotaFiscalFiltro.Name = "txtNotaFiscalFiltro"
        Me.txtNotaFiscalFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNotaFiscalFiltro.Size = New System.Drawing.Size(104, 20)
        Me.txtNotaFiscalFiltro.TabIndex = 1
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(913, 111)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 24
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(665, 17)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 6
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'lblEmitenteFiltro
        '
        Me.lblEmitenteFiltro.AutoSize = True
        Me.lblEmitenteFiltro.Location = New System.Drawing.Point(182, 17)
        Me.lblEmitenteFiltro.Name = "lblEmitenteFiltro"
        Me.lblEmitenteFiltro.Size = New System.Drawing.Size(50, 14)
        Me.lblEmitenteFiltro.TabIndex = 4
        Me.lblEmitenteFiltro.Text = "Emitente:"
        '
        'lblNotaFiscalFiltro
        '
        Me.lblNotaFiscalFiltro.AutoSize = True
        Me.lblNotaFiscalFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNotaFiscalFiltro.Name = "lblNotaFiscalFiltro"
        Me.lblNotaFiscalFiltro.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscalFiltro.TabIndex = 0
        Me.lblNotaFiscalFiltro.Text = "Nota Fiscal:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 617)
        Me.grpControle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(1013, 51)
        Me.grpControle.TabIndex = 6
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(913, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpLote)
        Me.pagDados.Controls.Add(Me.btnExcelGridProduto)
        Me.pagDados.Controls.Add(Me.btnAgruparGridProduto)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridProduto)
        Me.pagDados.Controls.Add(Me.grpItem)
        Me.pagDados.Controls.Add(Me.grpControl)
        Me.pagDados.Controls.Add(Me.grdLote)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(1029, 677)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Entrada - Nota Fiscal - Correção"
        '
        'grpLote
        '
        Me.grpLote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpLote.BackColor = System.Drawing.Color.Transparent
        Me.grpLote.Controls.Add(Me.btnAtualizarPedidoCompra)
        Me.grpLote.Controls.Add(Me.lblLoteQuantidadeDocumento)
        Me.grpLote.Controls.Add(Me.txtLoteQuantidadeDocumento)
        Me.grpLote.Controls.Add(Me.Label2)
        Me.grpLote.Controls.Add(Me.cboLoteProduto)
        Me.grpLote.Controls.Add(Me.lblNumeroDocumento)
        Me.grpLote.Controls.Add(Me.cboLoteNumeroDocumento)
        Me.grpLote.Controls.Add(Me.lblTipoOperacao)
        Me.grpLote.Controls.Add(Me.cboLoteTipoOperacao)
        Me.grpLote.Controls.Add(Me.Label6)
        Me.grpLote.Controls.Add(Me.lblCentroGasto)
        Me.grpLote.Controls.Add(Me.cboLoteCentroGasto)
        Me.grpLote.Controls.Add(Me.cboLoteControlaQualidade)
        Me.grpLote.Controls.Add(Me.lblContaContabil)
        Me.grpLote.Controls.Add(Me.cboLoteContaContabil)
        Me.grpLote.Controls.Add(Me.lblUnidadeMedida)
        Me.grpLote.Controls.Add(Me.cboLoteUnidadeMedida)
        Me.grpLote.Controls.Add(Me.lblQuantidadeEstoque)
        Me.grpLote.Controls.Add(Me.txtLoteQuantidadeEstoque)
        Me.grpLote.Controls.Add(Me.lblDataFabricacao)
        Me.grpLote.Controls.Add(Me.dtpLoteDataFabricacao)
        Me.grpLote.Controls.Add(Me.lblDataValidade)
        Me.grpLote.Controls.Add(Me.dtpLoteDataValidade)
        Me.grpLote.Controls.Add(Me.lblLote)
        Me.grpLote.Controls.Add(Me.txtLoteFabricante)
        Me.grpLote.Controls.Add(Me.lblFatorConversao)
        Me.grpLote.Controls.Add(Me.txtLoteFatorConversao)
        Me.grpLote.Controls.Add(Me.btnExcluir)
        Me.grpLote.Controls.Add(Me.btnInserir)
        Me.grpLote.Controls.Add(Me.lblDeposito)
        Me.grpLote.Controls.Add(Me.cboLoteDeposito)
        Me.grpLote.Controls.Add(Me.lblLoteQuantidade)
        Me.grpLote.Controls.Add(Me.txtLoteQuantidade)
        Me.grpLote.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLote.Location = New System.Drawing.Point(8, 123)
        Me.grpLote.Name = "grpLote"
        Me.grpLote.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLote.Size = New System.Drawing.Size(1013, 150)
        Me.grpLote.TabIndex = 2
        Me.grpLote.VisualStyleManager = Me.vsmMain
        '
        'btnAtualizarPedidoCompra
        '
        Me.btnAtualizarPedidoCompra.FlatAppearance.BorderSize = 0
        Me.btnAtualizarPedidoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizarPedidoCompra.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnAtualizarPedidoCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAtualizarPedidoCompra.Location = New System.Drawing.Point(870, 16)
        Me.btnAtualizarPedidoCompra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAtualizarPedidoCompra.Name = "btnAtualizarPedidoCompra"
        Me.btnAtualizarPedidoCompra.Size = New System.Drawing.Size(15, 13)
        Me.btnAtualizarPedidoCompra.TabIndex = 73
        Me.btnAtualizarPedidoCompra.TabStop = False
        Me.btnAtualizarPedidoCompra.UseVisualStyleBackColor = True
        '
        'lblLoteQuantidadeDocumento
        '
        Me.lblLoteQuantidadeDocumento.AutoSize = True
        Me.lblLoteQuantidadeDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLoteQuantidadeDocumento.Location = New System.Drawing.Point(777, 16)
        Me.lblLoteQuantidadeDocumento.Name = "lblLoteQuantidadeDocumento"
        Me.lblLoteQuantidadeDocumento.Size = New System.Drawing.Size(93, 14)
        Me.lblLoteQuantidadeDocumento.TabIndex = 60
        Me.lblLoteQuantidadeDocumento.Text = "Qtde. Documento:"
        '
        'txtLoteQuantidadeDocumento
        '
        Me.txtLoteQuantidadeDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLoteQuantidadeDocumento.DecimalDigits = 4
        Me.txtLoteQuantidadeDocumento.Location = New System.Drawing.Point(780, 33)
        Me.txtLoteQuantidadeDocumento.Name = "txtLoteQuantidadeDocumento"
        Me.txtLoteQuantidadeDocumento.ReadOnly = True
        Me.txtLoteQuantidadeDocumento.Size = New System.Drawing.Size(105, 20)
        Me.txtLoteQuantidadeDocumento.TabIndex = 3
        Me.txtLoteQuantidadeDocumento.TabStop = False
        Me.txtLoteQuantidadeDocumento.Text = "0,0000"
        Me.txtLoteQuantidadeDocumento.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(336, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 14)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Produto:"
        '
        'cboLoteProduto
        '
        Me.cboLoteProduto.AutoSize = False
        Me.cboLoteProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboLoteProduto.Location = New System.Drawing.Point(339, 32)
        Me.cboLoteProduto.Name = "cboLoteProduto"
        Me.cboLoteProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboLoteProduto.Size = New System.Drawing.Size(435, 20)
        Me.cboLoteProduto.TabIndex = 2
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(225, 16)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 54
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'cboLoteNumeroDocumento
        '
        Me.cboLoteNumeroDocumento.AutoSize = False
        Me.cboLoteNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboLoteNumeroDocumento.Location = New System.Drawing.Point(228, 32)
        Me.cboLoteNumeroDocumento.Name = "cboLoteNumeroDocumento"
        Me.cboLoteNumeroDocumento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboLoteNumeroDocumento.Size = New System.Drawing.Size(105, 20)
        Me.cboLoteNumeroDocumento.TabIndex = 1
        '
        'lblTipoOperacao
        '
        Me.lblTipoOperacao.AutoSize = True
        Me.lblTipoOperacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoOperacao.Location = New System.Drawing.Point(3, 15)
        Me.lblTipoOperacao.Name = "lblTipoOperacao"
        Me.lblTipoOperacao.Size = New System.Drawing.Size(96, 14)
        Me.lblTipoOperacao.TabIndex = 0
        Me.lblTipoOperacao.Text = "Tipo de Operação:"
        '
        'cboLoteTipoOperacao
        '
        Me.cboLoteTipoOperacao.AutoSize = False
        Me.cboLoteTipoOperacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboLoteTipoOperacao.Location = New System.Drawing.Point(6, 32)
        Me.cboLoteTipoOperacao.Name = "cboLoteTipoOperacao"
        Me.cboLoteTipoOperacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboLoteTipoOperacao.Size = New System.Drawing.Size(216, 20)
        Me.cboLoteTipoOperacao.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(336, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 14)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Controla Qualidade:"
        '
        'lblCentroGasto
        '
        Me.lblCentroGasto.AutoSize = True
        Me.lblCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCentroGasto.Location = New System.Drawing.Point(447, 100)
        Me.lblCentroGasto.Name = "lblCentroGasto"
        Me.lblCentroGasto.Size = New System.Drawing.Size(89, 14)
        Me.lblCentroGasto.TabIndex = 45
        Me.lblCentroGasto.Text = "Centro de Gasto:"
        '
        'cboLoteCentroGasto
        '
        Me.cboLoteCentroGasto.AutoSize = False
        Me.cboLoteCentroGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboLoteCentroGasto.Location = New System.Drawing.Point(450, 117)
        Me.cboLoteCentroGasto.Name = "cboLoteCentroGasto"
        Me.cboLoteCentroGasto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboLoteCentroGasto.Size = New System.Drawing.Size(435, 20)
        Me.cboLoteCentroGasto.TabIndex = 16
        '
        'cboLoteControlaQualidade
        '
        Me.cboLoteControlaQualidade.AutoSize = False
        Me.cboLoteControlaQualidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboLoteControlaQualidade.Location = New System.Drawing.Point(339, 117)
        Me.cboLoteControlaQualidade.Name = "cboLoteControlaQualidade"
        Me.cboLoteControlaQualidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboLoteControlaQualidade.Size = New System.Drawing.Size(105, 20)
        Me.cboLoteControlaQualidade.TabIndex = 15
        '
        'lblContaContabil
        '
        Me.lblContaContabil.AutoSize = True
        Me.lblContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContaContabil.Location = New System.Drawing.Point(666, 58)
        Me.lblContaContabil.Name = "lblContaContabil"
        Me.lblContaContabil.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabil.TabIndex = 49
        Me.lblContaContabil.Text = "Conta Contábil:"
        '
        'cboLoteContaContabil
        '
        Me.cboLoteContaContabil.AutoSize = False
        Me.cboLoteContaContabil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboLoteContaContabil.Location = New System.Drawing.Point(669, 76)
        Me.cboLoteContaContabil.Name = "cboLoteContaContabil"
        Me.cboLoteContaContabil.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboLoteContaContabil.Size = New System.Drawing.Size(216, 20)
        Me.cboLoteContaContabil.TabIndex = 10
        '
        'lblUnidadeMedida
        '
        Me.lblUnidadeMedida.AutoSize = True
        Me.lblUnidadeMedida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUnidadeMedida.Location = New System.Drawing.Point(114, 59)
        Me.lblUnidadeMedida.Name = "lblUnidadeMedida"
        Me.lblUnidadeMedida.Size = New System.Drawing.Size(69, 14)
        Me.lblUnidadeMedida.TabIndex = 19
        Me.lblUnidadeMedida.Text = "Und. Medida:"
        '
        'cboLoteUnidadeMedida
        '
        Me.cboLoteUnidadeMedida.AutoSize = False
        Me.cboLoteUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboLoteUnidadeMedida.Location = New System.Drawing.Point(117, 76)
        Me.cboLoteUnidadeMedida.Name = "cboLoteUnidadeMedida"
        Me.cboLoteUnidadeMedida.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboLoteUnidadeMedida.Size = New System.Drawing.Size(105, 20)
        Me.cboLoteUnidadeMedida.TabIndex = 5
        '
        'lblQuantidadeEstoque
        '
        Me.lblQuantidadeEstoque.AutoSize = True
        Me.lblQuantidadeEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeEstoque.Location = New System.Drawing.Point(336, 59)
        Me.lblQuantidadeEstoque.Name = "lblQuantidadeEstoque"
        Me.lblQuantidadeEstoque.Size = New System.Drawing.Size(78, 14)
        Me.lblQuantidadeEstoque.TabIndex = 23
        Me.lblQuantidadeEstoque.Text = "Qtde. Estoque:"
        '
        'txtLoteQuantidadeEstoque
        '
        Me.txtLoteQuantidadeEstoque.DecimalDigits = 4
        Me.txtLoteQuantidadeEstoque.Location = New System.Drawing.Point(339, 76)
        Me.txtLoteQuantidadeEstoque.Name = "txtLoteQuantidadeEstoque"
        Me.txtLoteQuantidadeEstoque.Size = New System.Drawing.Size(105, 20)
        Me.txtLoteQuantidadeEstoque.TabIndex = 8
        Me.txtLoteQuantidadeEstoque.Text = "0,0000"
        Me.txtLoteQuantidadeEstoque.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblDataFabricacao
        '
        Me.lblDataFabricacao.AutoSize = True
        Me.lblDataFabricacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataFabricacao.Location = New System.Drawing.Point(3, 102)
        Me.lblDataFabricacao.Name = "lblDataFabricacao"
        Me.lblDataFabricacao.Size = New System.Drawing.Size(89, 14)
        Me.lblDataFabricacao.TabIndex = 30
        Me.lblDataFabricacao.Text = "Data Fabricação:"
        '
        'dtpLoteDataFabricacao
        '
        '
        '
        '
        Me.dtpLoteDataFabricacao.DropDownCalendar.Name = ""
        Me.dtpLoteDataFabricacao.Location = New System.Drawing.Point(6, 119)
        Me.dtpLoteDataFabricacao.Name = "dtpLoteDataFabricacao"
        Me.dtpLoteDataFabricacao.ShowCheckBox = True
        Me.dtpLoteDataFabricacao.Size = New System.Drawing.Size(105, 20)
        Me.dtpLoteDataFabricacao.TabIndex = 11
        Me.dtpLoteDataFabricacao.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataValidade
        '
        Me.lblDataValidade.AutoSize = True
        Me.lblDataValidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataValidade.Location = New System.Drawing.Point(225, 100)
        Me.lblDataValidade.Name = "lblDataValidade"
        Me.lblDataValidade.Size = New System.Drawing.Size(76, 14)
        Me.lblDataValidade.TabIndex = 34
        Me.lblDataValidade.Text = "Data Validade:"
        '
        'dtpLoteDataValidade
        '
        '
        '
        '
        Me.dtpLoteDataValidade.DropDownCalendar.Name = ""
        Me.dtpLoteDataValidade.Location = New System.Drawing.Point(228, 117)
        Me.dtpLoteDataValidade.Name = "dtpLoteDataValidade"
        Me.dtpLoteDataValidade.ShowCheckBox = True
        Me.dtpLoteDataValidade.Size = New System.Drawing.Size(105, 20)
        Me.dtpLoteDataValidade.TabIndex = 13
        Me.dtpLoteDataValidade.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLote.Location = New System.Drawing.Point(114, 101)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(85, 14)
        Me.lblLote.TabIndex = 28
        Me.lblLote.Text = "Lote Fabricante:"
        '
        'txtLoteFabricante
        '
        Me.txtLoteFabricante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLoteFabricante.Location = New System.Drawing.Point(117, 118)
        Me.txtLoteFabricante.MaxLength = 50
        Me.txtLoteFabricante.Name = "txtLoteFabricante"
        Me.txtLoteFabricante.Size = New System.Drawing.Size(105, 20)
        Me.txtLoteFabricante.TabIndex = 12
        '
        'lblFatorConversao
        '
        Me.lblFatorConversao.AutoSize = True
        Me.lblFatorConversao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFatorConversao.Location = New System.Drawing.Point(225, 59)
        Me.lblFatorConversao.Name = "lblFatorConversao"
        Me.lblFatorConversao.Size = New System.Drawing.Size(91, 14)
        Me.lblFatorConversao.TabIndex = 6
        Me.lblFatorConversao.Text = "Fator Conversão:"
        '
        'txtLoteFatorConversao
        '
        Me.txtLoteFatorConversao.DecimalDigits = 4
        Me.txtLoteFatorConversao.Location = New System.Drawing.Point(228, 76)
        Me.txtLoteFatorConversao.Name = "txtLoteFatorConversao"
        Me.txtLoteFatorConversao.Size = New System.Drawing.Size(105, 20)
        Me.txtLoteFatorConversao.TabIndex = 7
        Me.txtLoteFatorConversao.Text = "0,0000"
        Me.txtLoteFatorConversao.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(916, 115)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 18
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = CType(resources.GetObject("btnInserir.Image"), System.Drawing.Image)
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(916, 86)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 17
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDeposito
        '
        Me.lblDeposito.AutoSize = True
        Me.lblDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDeposito.Location = New System.Drawing.Point(447, 59)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(52, 14)
        Me.lblDeposito.TabIndex = 26
        Me.lblDeposito.Text = "Depósito:"
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProduto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProduto.Location = New System.Drawing.Point(982, 15)
        Me.btnProcurarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProduto.TabIndex = 9
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'cboLoteDeposito
        '
        Me.cboLoteDeposito.AutoSize = False
        Me.cboLoteDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboLoteDeposito.Location = New System.Drawing.Point(450, 76)
        Me.cboLoteDeposito.Name = "cboLoteDeposito"
        Me.cboLoteDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboLoteDeposito.Size = New System.Drawing.Size(213, 20)
        Me.cboLoteDeposito.TabIndex = 9
        '
        'lblLoteQuantidade
        '
        Me.lblLoteQuantidade.AutoSize = True
        Me.lblLoteQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLoteQuantidade.Location = New System.Drawing.Point(3, 59)
        Me.lblLoteQuantidade.Name = "lblLoteQuantidade"
        Me.lblLoteQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblLoteQuantidade.TabIndex = 16
        Me.lblLoteQuantidade.Text = "Quantidade:"
        '
        'txtLoteQuantidade
        '
        Me.txtLoteQuantidade.DecimalDigits = 4
        Me.txtLoteQuantidade.Location = New System.Drawing.Point(6, 76)
        Me.txtLoteQuantidade.Name = "txtLoteQuantidade"
        Me.txtLoteQuantidade.Size = New System.Drawing.Size(105, 20)
        Me.txtLoteQuantidade.TabIndex = 4
        Me.txtLoteQuantidade.Text = "0,0000"
        Me.txtLoteQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'btnExcelGridProduto
        '
        Me.btnExcelGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridProduto.FlatAppearance.BorderSize = 0
        Me.btnExcelGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridProduto.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridProduto.Location = New System.Drawing.Point(50, 592)
        Me.btnExcelGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridProduto.Name = "btnExcelGridProduto"
        Me.btnExcelGridProduto.Size = New System.Drawing.Size(20, 15)
        Me.btnExcelGridProduto.TabIndex = 6
        Me.btnExcelGridProduto.TabStop = False
        Me.btnExcelGridProduto.UseVisualStyleBackColor = False
        '
        'btnAgruparGridProduto
        '
        Me.btnAgruparGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridProduto.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridProduto.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridProduto.Location = New System.Drawing.Point(30, 592)
        Me.btnAgruparGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridProduto.Name = "btnAgruparGridProduto"
        Me.btnAgruparGridProduto.Size = New System.Drawing.Size(20, 15)
        Me.btnAgruparGridProduto.TabIndex = 5
        Me.btnAgruparGridProduto.TabStop = False
        Me.btnAgruparGridProduto.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridProduto
        '
        Me.btnConfigurarGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridProduto.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridProduto.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridProduto.Location = New System.Drawing.Point(10, 592)
        Me.btnConfigurarGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridProduto.Name = "btnConfigurarGridProduto"
        Me.btnConfigurarGridProduto.Size = New System.Drawing.Size(20, 15)
        Me.btnConfigurarGridProduto.TabIndex = 4
        Me.btnConfigurarGridProduto.TabStop = False
        Me.btnConfigurarGridProduto.UseVisualStyleBackColor = False
        '
        'grpItem
        '
        Me.grpItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpItem.BackColor = System.Drawing.Color.Transparent
        Me.grpItem.Controls.Add(Me.cboCSTICMS)
        Me.grpItem.Controls.Add(Me.lblCSTICMS)
        Me.grpItem.Controls.Add(Me.cboCSTIPI)
        Me.grpItem.Controls.Add(Me.lblCSTIPI)
        Me.grpItem.Controls.Add(Me.txtNotaFiscal)
        Me.grpItem.Controls.Add(Me.Label7)
        Me.grpItem.Controls.Add(Me.lblBCICMS)
        Me.grpItem.Controls.Add(Me.txtBCICMS)
        Me.grpItem.Controls.Add(Me.lblValorICMS)
        Me.grpItem.Controls.Add(Me.txtValorICMS)
        Me.grpItem.Controls.Add(Me.lblBCIPI)
        Me.grpItem.Controls.Add(Me.txtBCIPI)
        Me.grpItem.Controls.Add(Me.lblValorIPI)
        Me.grpItem.Controls.Add(Me.txtValorIPI)
        Me.grpItem.Controls.Add(Me.txtNCM)
        Me.grpItem.Controls.Add(Me.lblNCM)
        Me.grpItem.Controls.Add(Me.lblValorTotal)
        Me.grpItem.Controls.Add(Me.txtValorTotal)
        Me.grpItem.Controls.Add(Me.lblValorUnitario)
        Me.grpItem.Controls.Add(Me.txtValorUnitario)
        Me.grpItem.Controls.Add(Me.btnFindCFOPDestinacao)
        Me.grpItem.Controls.Add(Me.btnCadastrarCFOP)
        Me.grpItem.Controls.Add(Me.lblCFOP)
        Me.grpItem.Controls.Add(Me.cboCFOP)
        Me.grpItem.Controls.Add(Me.txtUnidadeMedida)
        Me.grpItem.Controls.Add(Me.Label4)
        Me.grpItem.Controls.Add(Me.lblProduto)
        Me.grpItem.Controls.Add(Me.Label14)
        Me.grpItem.Controls.Add(Me.txtQuantidade)
        Me.grpItem.Controls.Add(Me.cboProduto)
        Me.grpItem.Controls.Add(Me.btnProcurarProduto)
        Me.grpItem.Controls.Add(Me.btnCadastrarProduto)
        Me.grpItem.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpItem.Location = New System.Drawing.Point(8, 3)
        Me.grpItem.Name = "grpItem"
        Me.grpItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpItem.Size = New System.Drawing.Size(1013, 114)
        Me.grpItem.TabIndex = 0
        Me.grpItem.VisualStyleManager = Me.vsmMain
        '
        'cboCSTICMS
        '
        Me.cboCSTICMS.AutoSize = False
        Me.cboCSTICMS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCSTICMS.Location = New System.Drawing.Point(783, 77)
        Me.cboCSTICMS.Name = "cboCSTICMS"
        Me.cboCSTICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCSTICMS.Size = New System.Drawing.Size(50, 20)
        Me.cboCSTICMS.TabIndex = 11
        '
        'lblCSTICMS
        '
        Me.lblCSTICMS.AutoSize = True
        Me.lblCSTICMS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCSTICMS.Location = New System.Drawing.Point(780, 60)
        Me.lblCSTICMS.Name = "lblCSTICMS"
        Me.lblCSTICMS.Size = New System.Drawing.Size(57, 14)
        Me.lblCSTICMS.TabIndex = 72
        Me.lblCSTICMS.Text = "CST ICMS:"
        '
        'cboCSTIPI
        '
        Me.cboCSTIPI.AutoSize = False
        Me.cboCSTIPI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCSTIPI.Location = New System.Drawing.Point(561, 77)
        Me.cboCSTIPI.Name = "cboCSTIPI"
        Me.cboCSTIPI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCSTIPI.Size = New System.Drawing.Size(50, 20)
        Me.cboCSTIPI.TabIndex = 8
        '
        'lblCSTIPI
        '
        Me.lblCSTIPI.AutoSize = True
        Me.lblCSTIPI.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCSTIPI.Location = New System.Drawing.Point(558, 60)
        Me.lblCSTIPI.Name = "lblCSTIPI"
        Me.lblCSTIPI.Size = New System.Drawing.Size(43, 14)
        Me.lblCSTIPI.TabIndex = 70
        Me.lblCSTIPI.Text = "CST IPI:"
        '
        'txtNotaFiscal
        '
        Me.txtNotaFiscal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaFiscal.Location = New System.Drawing.Point(117, 33)
        Me.txtNotaFiscal.MaxLength = 50
        Me.txtNotaFiscal.Name = "txtNotaFiscal"
        Me.txtNotaFiscal.Size = New System.Drawing.Size(105, 20)
        Me.txtNotaFiscal.TabIndex = 1
        Me.txtNotaFiscal.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(114, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 14)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Nº Nota Fiscal:"
        '
        'lblBCICMS
        '
        Me.lblBCICMS.AutoSize = True
        Me.lblBCICMS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBCICMS.Location = New System.Drawing.Point(919, 60)
        Me.lblBCICMS.Name = "lblBCICMS"
        Me.lblBCICMS.Size = New System.Drawing.Size(51, 14)
        Me.lblBCICMS.TabIndex = 66
        Me.lblBCICMS.Text = "BC ICMS:"
        '
        'txtBCICMS
        '
        Me.txtBCICMS.DecimalDigits = 4
        Me.txtBCICMS.Location = New System.Drawing.Point(922, 77)
        Me.txtBCICMS.Name = "txtBCICMS"
        Me.txtBCICMS.Size = New System.Drawing.Size(77, 20)
        Me.txtBCICMS.TabIndex = 13
        Me.txtBCICMS.Text = "0,0000"
        Me.txtBCICMS.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblValorICMS
        '
        Me.lblValorICMS.AutoSize = True
        Me.lblValorICMS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValorICMS.Location = New System.Drawing.Point(836, 60)
        Me.lblValorICMS.Name = "lblValorICMS"
        Me.lblValorICMS.Size = New System.Drawing.Size(62, 14)
        Me.lblValorICMS.TabIndex = 64
        Me.lblValorICMS.Text = "Valor ICMS:"
        '
        'txtValorICMS
        '
        Me.txtValorICMS.DecimalDigits = 4
        Me.txtValorICMS.Location = New System.Drawing.Point(839, 77)
        Me.txtValorICMS.Name = "txtValorICMS"
        Me.txtValorICMS.Size = New System.Drawing.Size(77, 20)
        Me.txtValorICMS.TabIndex = 12
        Me.txtValorICMS.Text = "0,0000"
        Me.txtValorICMS.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblBCIPI
        '
        Me.lblBCIPI.AutoSize = True
        Me.lblBCIPI.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBCIPI.Location = New System.Drawing.Point(697, 60)
        Me.lblBCIPI.Name = "lblBCIPI"
        Me.lblBCIPI.Size = New System.Drawing.Size(37, 14)
        Me.lblBCIPI.TabIndex = 62
        Me.lblBCIPI.Text = "BC IPI:"
        '
        'txtBCIPI
        '
        Me.txtBCIPI.DecimalDigits = 4
        Me.txtBCIPI.Location = New System.Drawing.Point(700, 77)
        Me.txtBCIPI.Name = "txtBCIPI"
        Me.txtBCIPI.Size = New System.Drawing.Size(77, 20)
        Me.txtBCIPI.TabIndex = 10
        Me.txtBCIPI.Text = "0,0000"
        Me.txtBCIPI.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblValorIPI
        '
        Me.lblValorIPI.AutoSize = True
        Me.lblValorIPI.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValorIPI.Location = New System.Drawing.Point(614, 59)
        Me.lblValorIPI.Name = "lblValorIPI"
        Me.lblValorIPI.Size = New System.Drawing.Size(48, 14)
        Me.lblValorIPI.TabIndex = 60
        Me.lblValorIPI.Text = "Valor IPI:"
        '
        'txtValorIPI
        '
        Me.txtValorIPI.DecimalDigits = 4
        Me.txtValorIPI.Location = New System.Drawing.Point(617, 77)
        Me.txtValorIPI.Name = "txtValorIPI"
        Me.txtValorIPI.Size = New System.Drawing.Size(77, 20)
        Me.txtValorIPI.TabIndex = 9
        Me.txtValorIPI.Text = "0,0000"
        Me.txtValorIPI.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'txtNCM
        '
        Me.txtNCM.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNCM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNCM.Location = New System.Drawing.Point(6, 77)
        Me.txtNCM.MaxLength = 50
        Me.txtNCM.Name = "txtNCM"
        Me.txtNCM.Size = New System.Drawing.Size(105, 20)
        Me.txtNCM.TabIndex = 3
        Me.txtNCM.TabStop = False
        '
        'lblNCM
        '
        Me.lblNCM.AutoSize = True
        Me.lblNCM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNCM.Location = New System.Drawing.Point(3, 60)
        Me.lblNCM.Name = "lblNCM"
        Me.lblNCM.Size = New System.Drawing.Size(32, 14)
        Me.lblNCM.TabIndex = 58
        Me.lblNCM.Text = "NCM:"
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValorTotal.Location = New System.Drawing.Point(447, 60)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(60, 14)
        Me.lblValorTotal.TabIndex = 56
        Me.lblValorTotal.Text = "Valor Total:"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTotal.DecimalDigits = 4
        Me.txtValorTotal.Location = New System.Drawing.Point(450, 77)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(105, 20)
        Me.txtValorTotal.TabIndex = 7
        Me.txtValorTotal.TabStop = False
        Me.txtValorTotal.Text = "0,0000"
        Me.txtValorTotal.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblValorUnitario
        '
        Me.lblValorUnitario.AutoSize = True
        Me.lblValorUnitario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValorUnitario.Location = New System.Drawing.Point(336, 60)
        Me.lblValorUnitario.Name = "lblValorUnitario"
        Me.lblValorUnitario.Size = New System.Drawing.Size(74, 14)
        Me.lblValorUnitario.TabIndex = 54
        Me.lblValorUnitario.Text = "Valor Unitário:"
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorUnitario.DecimalDigits = 4
        Me.txtValorUnitario.Location = New System.Drawing.Point(339, 77)
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.Size = New System.Drawing.Size(105, 20)
        Me.txtValorUnitario.TabIndex = 6
        Me.txtValorUnitario.TabStop = False
        Me.txtValorUnitario.Text = "0,0000"
        Me.txtValorUnitario.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'btnFindCFOPDestinacao
        '
        Me.btnFindCFOPDestinacao.FlatAppearance.BorderSize = 0
        Me.btnFindCFOPDestinacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindCFOPDestinacao.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnFindCFOPDestinacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFindCFOPDestinacao.Location = New System.Drawing.Point(94, 15)
        Me.btnFindCFOPDestinacao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFindCFOPDestinacao.Name = "btnFindCFOPDestinacao"
        Me.btnFindCFOPDestinacao.Size = New System.Drawing.Size(17, 16)
        Me.btnFindCFOPDestinacao.TabIndex = 3
        Me.btnFindCFOPDestinacao.TabStop = False
        Me.btnFindCFOPDestinacao.UseVisualStyleBackColor = True
        '
        'btnCadastrarCFOP
        '
        Me.btnCadastrarCFOP.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCFOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCFOP.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCFOP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCFOP.Location = New System.Drawing.Point(6, 18)
        Me.btnCadastrarCFOP.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCFOP.Name = "btnCadastrarCFOP"
        Me.btnCadastrarCFOP.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCFOP.TabIndex = 0
        Me.btnCadastrarCFOP.TabStop = False
        Me.btnCadastrarCFOP.UseVisualStyleBackColor = True
        '
        'lblCFOP
        '
        Me.lblCFOP.AutoSize = True
        Me.lblCFOP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCFOP.Location = New System.Drawing.Point(22, 17)
        Me.lblCFOP.Name = "lblCFOP"
        Me.lblCFOP.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOP.TabIndex = 1
        Me.lblCFOP.Text = "CFOP:"
        '
        'cboCFOP
        '
        Me.cboCFOP.AutoSize = False
        Me.cboCFOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCFOP.Location = New System.Drawing.Point(6, 34)
        Me.cboCFOP.Name = "cboCFOP"
        Me.cboCFOP.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCFOP.Size = New System.Drawing.Size(105, 20)
        Me.cboCFOP.TabIndex = 0
        '
        'txtUnidadeMedida
        '
        Me.txtUnidadeMedida.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidadeMedida.Location = New System.Drawing.Point(117, 77)
        Me.txtUnidadeMedida.MaxLength = 50
        Me.txtUnidadeMedida.Name = "txtUnidadeMedida"
        Me.txtUnidadeMedida.Size = New System.Drawing.Size(105, 20)
        Me.txtUnidadeMedida.TabIndex = 4
        Me.txtUnidadeMedida.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(114, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 14)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Und. Medida:"
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblProduto.Location = New System.Drawing.Point(244, 17)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 8
        Me.lblProduto.Text = "Produto:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(225, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 14)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(228, 77)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(105, 20)
        Me.txtQuantidade.TabIndex = 5
        Me.txtQuantidade.TabStop = False
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'cboProduto
        '
        Me.cboProduto.AutoSize = False
        Me.cboProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProduto.Location = New System.Drawing.Point(228, 33)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboProduto.Size = New System.Drawing.Size(771, 20)
        Me.cboProduto.TabIndex = 2
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnVoltar)
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Location = New System.Drawing.Point(8, 616)
        Me.grpControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(1013, 51)
        Me.grpControl.TabIndex = 0
        Me.grpControl.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(913, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 1
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(816, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdLote
        '
        Me.grdLote.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdLote.AlternatingColors = True
        Me.grdLote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdLote.AutoEdit = True
        grdLote_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdLote_DesignTimeLayout_Reference_0.Instance"), Object)
        grdLote_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdLote_DesignTimeLayout_Reference_0})
        grdLote_DesignTimeLayout.LayoutString = resources.GetString("grdLote_DesignTimeLayout.LayoutString")
        Me.grdLote.DesignTimeLayout = grdLote_DesignTimeLayout
        Me.grdLote.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdLote.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdLote.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdLote.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdLote.FrozenColumns = 2
        Me.grdLote.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdLote.GroupByBoxVisible = False
        Me.grdLote.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdLote.Location = New System.Drawing.Point(8, 279)
        Me.grdLote.Name = "grdLote"
        Me.grdLote.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdLote.RecordNavigator = True
        Me.grdLote.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdLote.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdLote.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdLote.Size = New System.Drawing.Size(1013, 330)
        Me.grdLote.TabIndex = 3
        Me.grdLote.TabStop = False
        Me.grdLote.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdLote.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdLote.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdLote.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdLote.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdLote.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdLote.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdLote.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdLote.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarProduto
        '
        Me.btnCadastrarProduto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarProduto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarProduto.Location = New System.Drawing.Point(228, 18)
        Me.btnCadastrarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarProduto.Name = "btnCadastrarProduto"
        Me.btnCadastrarProduto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarProduto.TabIndex = 7
        Me.btnCadastrarProduto.TabStop = False
        Me.btnCadastrarProduto.UseVisualStyleBackColor = True
        '
        'usrFatEntradaNFCorrecao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "usrFatEntradaNFCorrecao"
        Me.Size = New System.Drawing.Size(1031, 700)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLote.ResumeLayout(False)
        Me.grpLote.PerformLayout()
        CType(Me.grpItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItem.ResumeLayout(False)
        Me.grpItem.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grdLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtEmitenteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtSerieFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerieFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscalFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblEmitenteFiltro As System.Windows.Forms.Label
    Friend WithEvents lblNotaFiscalFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtNumeroDocumentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboCFOPFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents lblCFOPFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents dtpDataEntradaInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEntradaTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEntradaFiltro As System.Windows.Forms.Label
    Friend WithEvents txtLoteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblLoteFiltro As System.Windows.Forms.Label
    Friend WithEvents lblProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblTipoOperacaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoOperacaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents grpItem As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridProduto As System.Windows.Forms.Button
    Friend WithEvents txtUnidadeMedida As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblBCIPI As System.Windows.Forms.Label
    Friend WithEvents txtBCIPI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorIPI As System.Windows.Forms.Label
    Friend WithEvents txtValorIPI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtNCM As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNCM As System.Windows.Forms.Label
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents txtValorTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnitario As System.Windows.Forms.Label
    Friend WithEvents txtValorUnitario As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnFindCFOPDestinacao As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCFOP As System.Windows.Forms.Button
    Friend WithEvents lblCFOP As System.Windows.Forms.Label
    Friend WithEvents cboCFOP As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblBCICMS As System.Windows.Forms.Label
    Friend WithEvents txtBCICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorICMS As System.Windows.Forms.Label
    Friend WithEvents txtValorICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents grpLote As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblUnidadeMedida As System.Windows.Forms.Label
    Friend WithEvents cboLoteUnidadeMedida As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblQuantidadeEstoque As System.Windows.Forms.Label
    Friend WithEvents txtLoteQuantidadeEstoque As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDataFabricacao As System.Windows.Forms.Label
    Friend WithEvents dtpLoteDataFabricacao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataValidade As System.Windows.Forms.Label
    Friend WithEvents dtpLoteDataValidade As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents txtLoteFabricante As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFatorConversao As System.Windows.Forms.Label
    Friend WithEvents txtLoteFatorConversao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDeposito As System.Windows.Forms.Label
    Friend WithEvents cboLoteDeposito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblLoteQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtLoteQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboLoteControlaQualidade As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdLote As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblCentroGasto As System.Windows.Forms.Label
    Friend WithEvents cboLoteCentroGasto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblContaContabil As System.Windows.Forms.Label
    Friend WithEvents cboLoteContaContabil As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNotaFiscal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboCSTICMS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCSTIPI As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCSTIPI As System.Windows.Forms.Label
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents lblCSTICMS As System.Windows.Forms.Label
    Friend WithEvents btnAtualizarPedidoCompra As System.Windows.Forms.Button
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents cboLoteNumeroDocumento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoOperacao As System.Windows.Forms.Label
    Friend WithEvents cboLoteTipoOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboLoteProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblLoteQuantidadeDocumento As System.Windows.Forms.Label
    Friend WithEvents txtLoteQuantidadeDocumento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnCadastrarProduto As System.Windows.Forms.Button

End Class
