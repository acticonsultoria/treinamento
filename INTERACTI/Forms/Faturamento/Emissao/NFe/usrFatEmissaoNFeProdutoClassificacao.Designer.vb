<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFatEmissaoNFeProdutoClassificacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFatEmissaoNFeProdutoClassificacao))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdEstoque_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdEstoque_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.btnConfigurarGridListagem = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpDadosProdutoFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.txtDestinatarioFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNotaFiscalFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNotaFiscalFiltro = New System.Windows.Forms.Label()
        Me.lblDestinatarioFiltro = New System.Windows.Forms.Label()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.cboProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblProdutoFiltro = New System.Windows.Forms.Label()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpSalvarLote = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVoltarEstoque = New Janus.Windows.EditControls.UIButton()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdEstoque = New Janus.Windows.GridEX.GridEX()
        Me.grpEstoque = New Janus.Windows.EditControls.UIGroupBox()
        Me.brnGerarNovoLote = New System.Windows.Forms.Button()
        Me.btnProcurarItem = New System.Windows.Forms.Button()
        Me.cboCodigoProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboUnidadeMedida = New Janus.Windows.EditControls.UIComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLote = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtFatorConversao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblFatorConversao = New System.Windows.Forms.Label()
        Me.lblSaldoEstoque = New System.Windows.Forms.Label()
        Me.txtSaldoEstoque = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboDeposito = New Janus.Windows.EditControls.UIComboBox()
        Me.txtQuantidadeEstoque = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeEstoque = New System.Windows.Forms.Label()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.grpProduto = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtUnidadeMedida = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantidadeNotaFiscalTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeNotaFiscalTotal = New System.Windows.Forms.Label()
        Me.txtProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDadosProdutoFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosProdutoFiltro.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpSalvarLote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSalvarLote.SuspendLayout()
        CType(Me.grdEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEstoque.SuspendLayout()
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProduto.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(815, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.UiGroupBox2)
        Me.pagLista.Controls.Add(Me.btnConfigurarGridListagem)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpDadosProdutoFiltro)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(813, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Produtos"
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.btnSair)
        Me.UiGroupBox2.Location = New System.Drawing.Point(3, 480)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.Size = New System.Drawing.Size(802, 49)
        Me.UiGroupBox2.TabIndex = 3
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox2.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(696, 15)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'btnConfigurarGridListagem
        '
        Me.btnConfigurarGridListagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridListagem.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridListagem.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridListagem.Image = CType(resources.GetObject("btnConfigurarGridListagem.Image"), System.Drawing.Image)
        Me.btnConfigurarGridListagem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridListagem.Location = New System.Drawing.Point(10, 462)
        Me.btnConfigurarGridListagem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridListagem.Name = "btnConfigurarGridListagem"
        Me.btnConfigurarGridListagem.Size = New System.Drawing.Size(48, 15)
        Me.btnConfigurarGridListagem.TabIndex = 2
        Me.btnConfigurarGridListagem.TabStop = False
        Me.btnConfigurarGridListagem.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
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
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 124)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(797, 355)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpDadosProdutoFiltro
        '
        Me.grpDadosProdutoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosProdutoFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosProdutoFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpDadosProdutoFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpDadosProdutoFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpDadosProdutoFiltro.Controls.Add(Me.txtDestinatarioFiltro)
        Me.grpDadosProdutoFiltro.Controls.Add(Me.txtNotaFiscalFiltro)
        Me.grpDadosProdutoFiltro.Controls.Add(Me.lblNotaFiscalFiltro)
        Me.grpDadosProdutoFiltro.Controls.Add(Me.lblDestinatarioFiltro)
        Me.grpDadosProdutoFiltro.Controls.Add(Me.btnProcurarProduto)
        Me.grpDadosProdutoFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpDadosProdutoFiltro.Controls.Add(Me.cboProduto)
        Me.grpDadosProdutoFiltro.Controls.Add(Me.lblProdutoFiltro)
        Me.grpDadosProdutoFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosProdutoFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosProdutoFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDadosProdutoFiltro.Name = "grpDadosProdutoFiltro"
        Me.grpDadosProdutoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosProdutoFiltro.Size = New System.Drawing.Size(797, 113)
        Me.grpDadosProdutoFiltro.TabIndex = 0
        Me.grpDadosProdutoFiltro.Text = "Identificação do Produto"
        Me.grpDadosProdutoFiltro.VisualStyleManager = Me.vsmMain
        '
        'dtpDataEmissaoInicioFiltro
        '
        Me.dtpDataEmissaoInicioFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(525, 37)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 4
        '
        'dtpDataEmissaoTerminoFiltro
        '
        Me.dtpDataEmissaoTerminoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(641, 37)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 5
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(525, 20)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 3
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'txtDestinatarioFiltro
        '
        Me.txtDestinatarioFiltro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDestinatarioFiltro.IncludeLiterals = False
        Me.txtDestinatarioFiltro.Location = New System.Drawing.Point(9, 77)
        Me.txtDestinatarioFiltro.MaxLength = 9
        Me.txtDestinatarioFiltro.Name = "txtDestinatarioFiltro"
        Me.txtDestinatarioFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtDestinatarioFiltro.Size = New System.Drawing.Size(510, 20)
        Me.txtDestinatarioFiltro.TabIndex = 7
        '
        'txtNotaFiscalFiltro
        '
        Me.txtNotaFiscalFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotaFiscalFiltro.IncludeLiterals = False
        Me.txtNotaFiscalFiltro.Location = New System.Drawing.Point(525, 77)
        Me.txtNotaFiscalFiltro.MaxLength = 9
        Me.txtNotaFiscalFiltro.Name = "txtNotaFiscalFiltro"
        Me.txtNotaFiscalFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNotaFiscalFiltro.Size = New System.Drawing.Size(104, 20)
        Me.txtNotaFiscalFiltro.TabIndex = 8
        '
        'lblNotaFiscalFiltro
        '
        Me.lblNotaFiscalFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNotaFiscalFiltro.AutoSize = True
        Me.lblNotaFiscalFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNotaFiscalFiltro.Location = New System.Drawing.Point(525, 60)
        Me.lblNotaFiscalFiltro.Name = "lblNotaFiscalFiltro"
        Me.lblNotaFiscalFiltro.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscalFiltro.TabIndex = 9
        Me.lblNotaFiscalFiltro.Text = "Nota Fiscal:"
        '
        'lblDestinatarioFiltro
        '
        Me.lblDestinatarioFiltro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDestinatarioFiltro.AutoSize = True
        Me.lblDestinatarioFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDestinatarioFiltro.Location = New System.Drawing.Point(6, 60)
        Me.lblDestinatarioFiltro.Name = "lblDestinatarioFiltro"
        Me.lblDestinatarioFiltro.Size = New System.Drawing.Size(67, 14)
        Me.lblDestinatarioFiltro.TabIndex = 6
        Me.lblDestinatarioFiltro.Text = "Destinatário:"
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProduto.Image = CType(resources.GetObject("btnProcurarProduto.Image"), System.Drawing.Image)
        Me.btnProcurarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProduto.Location = New System.Drawing.Point(502, 17)
        Me.btnProcurarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProduto.TabIndex = 2
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = CType(resources.GetObject("btnFiltrar.Image"), System.Drawing.Image)
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnFiltrar.Location = New System.Drawing.Point(691, 77)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 10
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboProduto
        '
        Me.cboProduto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboProduto.AutoSize = False
        Me.cboProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProduto.Location = New System.Drawing.Point(9, 37)
        Me.cboProduto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboProduto.Size = New System.Drawing.Size(510, 20)
        Me.cboProduto.TabIndex = 1
        '
        'lblProdutoFiltro
        '
        Me.lblProdutoFiltro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProdutoFiltro.AutoSize = True
        Me.lblProdutoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblProdutoFiltro.Location = New System.Drawing.Point(6, 20)
        Me.lblProdutoFiltro.Name = "lblProdutoFiltro"
        Me.lblProdutoFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblProdutoFiltro.TabIndex = 0
        Me.lblProdutoFiltro.Text = "Produto:"
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpSalvarLote)
        Me.pagDados.Controls.Add(Me.btnConfigurarGrid)
        Me.pagDados.Controls.Add(Me.grdEstoque)
        Me.pagDados.Controls.Add(Me.grpEstoque)
        Me.pagDados.Controls.Add(Me.grpProduto)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(813, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados de Estoque"
        '
        'grpSalvarLote
        '
        Me.grpSalvarLote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSalvarLote.BackColor = System.Drawing.Color.Transparent
        Me.grpSalvarLote.Controls.Add(Me.btnSalvar)
        Me.grpSalvarLote.Controls.Add(Me.Label1)
        Me.grpSalvarLote.Controls.Add(Me.btnVoltarEstoque)
        Me.grpSalvarLote.Location = New System.Drawing.Point(8, 485)
        Me.grpSalvarLote.Name = "grpSalvarLote"
        Me.grpSalvarLote.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSalvarLote.Size = New System.Drawing.Size(797, 51)
        Me.grpSalvarLote.TabIndex = 0
        Me.grpSalvarLote.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpSalvarLote.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.Location = New System.Drawing.Point(599, 15)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(7, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(468, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Obs.: O Interacti não valida a [Qtde. Nota Fiscal] x [Qtde. Estoque] neste moment" & _
            "o mas, sim, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "na hora da Emissão da NF-e."
        '
        'btnVoltarEstoque
        '
        Me.btnVoltarEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltarEstoque.Image = CType(resources.GetObject("btnVoltarEstoque.Image"), System.Drawing.Image)
        Me.btnVoltarEstoque.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltarEstoque.Location = New System.Drawing.Point(696, 15)
        Me.btnVoltarEstoque.Name = "btnVoltarEstoque"
        Me.btnVoltarEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltarEstoque.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltarEstoque.TabIndex = 1
        Me.btnVoltarEstoque.Text = "Voltar"
        Me.btnVoltarEstoque.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = CType(resources.GetObject("btnConfigurarGrid.Image"), System.Drawing.Image)
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(10, 468)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(49, 15)
        Me.btnConfigurarGrid.TabIndex = 4
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdEstoque
        '
        Me.grdEstoque.AllowDrop = True
        Me.grdEstoque.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdEstoque.AlternatingColors = True
        Me.grdEstoque.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdEstoque.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        grdEstoque_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdEstoque_DesignTimeLayout_Reference_0.Instance"), Object)
        grdEstoque_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdEstoque_DesignTimeLayout_Reference_0})
        grdEstoque_DesignTimeLayout.LayoutString = resources.GetString("grdEstoque_DesignTimeLayout.LayoutString")
        Me.grdEstoque.DesignTimeLayout = grdEstoque_DesignTimeLayout
        Me.grdEstoque.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdEstoque.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdEstoque.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdEstoque.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdEstoque.FocusCellFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdEstoque.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdEstoque.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdEstoque.FrozenColumns = 3
        Me.grdEstoque.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdEstoque.GroupByBoxVisible = False
        Me.grdEstoque.Location = New System.Drawing.Point(8, 185)
        Me.grdEstoque.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdEstoque.Name = "grdEstoque"
        Me.grdEstoque.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdEstoque.RecordNavigator = True
        Me.grdEstoque.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdEstoque.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdEstoque.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdEstoque.Size = New System.Drawing.Size(797, 300)
        Me.grdEstoque.TabIndex = 3
        Me.grdEstoque.TabStop = False
        Me.grdEstoque.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdEstoque.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdEstoque.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdEstoque.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdEstoque.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdEstoque.VisualStyleManager = Me.vsmMain
        '
        'grpEstoque
        '
        Me.grpEstoque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEstoque.BackColor = System.Drawing.Color.Transparent
        Me.grpEstoque.Controls.Add(Me.brnGerarNovoLote)
        Me.grpEstoque.Controls.Add(Me.btnProcurarItem)
        Me.grpEstoque.Controls.Add(Me.cboCodigoProduto)
        Me.grpEstoque.Controls.Add(Me.Label4)
        Me.grpEstoque.Controls.Add(Me.cboUnidadeMedida)
        Me.grpEstoque.Controls.Add(Me.Label3)
        Me.grpEstoque.Controls.Add(Me.txtLote)
        Me.grpEstoque.Controls.Add(Me.txtFatorConversao)
        Me.grpEstoque.Controls.Add(Me.lblFatorConversao)
        Me.grpEstoque.Controls.Add(Me.lblSaldoEstoque)
        Me.grpEstoque.Controls.Add(Me.txtSaldoEstoque)
        Me.grpEstoque.Controls.Add(Me.cboDeposito)
        Me.grpEstoque.Controls.Add(Me.txtQuantidadeEstoque)
        Me.grpEstoque.Controls.Add(Me.lblQuantidadeEstoque)
        Me.grpEstoque.Controls.Add(Me.lblLote)
        Me.grpEstoque.Controls.Add(Me.lblDeposito)
        Me.grpEstoque.Controls.Add(Me.btnExcluir)
        Me.grpEstoque.Controls.Add(Me.btnInserir)
        Me.grpEstoque.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEstoque.Location = New System.Drawing.Point(8, 70)
        Me.grpEstoque.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEstoque.Name = "grpEstoque"
        Me.grpEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEstoque.Size = New System.Drawing.Size(797, 107)
        Me.grpEstoque.TabIndex = 2
        Me.grpEstoque.Text = "Dados de Movimentação do Estoque"
        Me.grpEstoque.VisualStyleManager = Me.vsmMain
        '
        'brnGerarNovoLote
        '
        Me.brnGerarNovoLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.brnGerarNovoLote.FlatAppearance.BorderSize = 0
        Me.brnGerarNovoLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brnGerarNovoLote.Image = CType(resources.GetObject("brnGerarNovoLote.Image"), System.Drawing.Image)
        Me.brnGerarNovoLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.brnGerarNovoLote.Location = New System.Drawing.Point(424, 19)
        Me.brnGerarNovoLote.Margin = New System.Windows.Forms.Padding(0)
        Me.brnGerarNovoLote.Name = "brnGerarNovoLote"
        Me.brnGerarNovoLote.Size = New System.Drawing.Size(17, 16)
        Me.brnGerarNovoLote.TabIndex = 17
        Me.brnGerarNovoLote.TabStop = False
        Me.brnGerarNovoLote.UseVisualStyleBackColor = True
        '
        'btnProcurarItem
        '
        Me.btnProcurarItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarItem.FlatAppearance.BorderSize = 0
        Me.btnProcurarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItem.Image = CType(resources.GetObject("btnProcurarItem.Image"), System.Drawing.Image)
        Me.btnProcurarItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItem.Location = New System.Drawing.Point(661, 18)
        Me.btnProcurarItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItem.Name = "btnProcurarItem"
        Me.btnProcurarItem.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItem.TabIndex = 16
        Me.btnProcurarItem.TabStop = False
        Me.btnProcurarItem.UseVisualStyleBackColor = True
        '
        'cboCodigoProduto
        '
        Me.cboCodigoProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCodigoProduto.AutoSize = False
        Me.cboCodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCodigoProduto.Location = New System.Drawing.Point(555, 37)
        Me.cboCodigoProduto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCodigoProduto.Name = "cboCodigoProduto"
        Me.cboCodigoProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigoProduto.Size = New System.Drawing.Size(123, 20)
        Me.cboCodigoProduto.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(554, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Código do Produto:"
        '
        'cboUnidadeMedida
        '
        Me.cboUnidadeMedida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboUnidadeMedida.AutoSize = False
        Me.cboUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedida.Enabled = False
        Me.cboUnidadeMedida.Location = New System.Drawing.Point(115, 77)
        Me.cboUnidadeMedida.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboUnidadeMedida.Name = "cboUnidadeMedida"
        Me.cboUnidadeMedida.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedida.Size = New System.Drawing.Size(199, 20)
        Me.cboUnidadeMedida.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(114, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Unidade Medida:"
        '
        'txtLote
        '
        Me.txtLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLote.IncludeLiterals = False
        Me.txtLote.Location = New System.Drawing.Point(426, 37)
        Me.txtLote.MaxLength = 15
        Me.txtLote.Name = "txtLote"
        Me.txtLote.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtLote.Size = New System.Drawing.Size(122, 20)
        Me.txtLote.TabIndex = 3
        '
        'txtFatorConversao
        '
        Me.txtFatorConversao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFatorConversao.DecimalDigits = 4
        Me.txtFatorConversao.Location = New System.Drawing.Point(320, 77)
        Me.txtFatorConversao.Name = "txtFatorConversao"
        Me.txtFatorConversao.Size = New System.Drawing.Size(122, 20)
        Me.txtFatorConversao.TabIndex = 11
        Me.txtFatorConversao.Text = "1,0000"
        Me.txtFatorConversao.Value = New Decimal(New Integer() {10000, 0, 0, 262144})
        '
        'lblFatorConversao
        '
        Me.lblFatorConversao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFatorConversao.AutoSize = True
        Me.lblFatorConversao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFatorConversao.Location = New System.Drawing.Point(319, 60)
        Me.lblFatorConversao.Name = "lblFatorConversao"
        Me.lblFatorConversao.Size = New System.Drawing.Size(91, 14)
        Me.lblFatorConversao.TabIndex = 10
        Me.lblFatorConversao.Text = "Fator Conversão:"
        '
        'lblSaldoEstoque
        '
        Me.lblSaldoEstoque.AutoSize = True
        Me.lblSaldoEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSaldoEstoque.Location = New System.Drawing.Point(6, 60)
        Me.lblSaldoEstoque.Name = "lblSaldoEstoque"
        Me.lblSaldoEstoque.Size = New System.Drawing.Size(79, 14)
        Me.lblSaldoEstoque.TabIndex = 6
        Me.lblSaldoEstoque.Text = "Saldo Estoque:"
        '
        'txtSaldoEstoque
        '
        Me.txtSaldoEstoque.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSaldoEstoque.DecimalDigits = 4
        Me.txtSaldoEstoque.Location = New System.Drawing.Point(9, 77)
        Me.txtSaldoEstoque.Name = "txtSaldoEstoque"
        Me.txtSaldoEstoque.ReadOnly = True
        Me.txtSaldoEstoque.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldoEstoque.TabIndex = 7
        Me.txtSaldoEstoque.TabStop = False
        Me.txtSaldoEstoque.Text = "0,0000"
        Me.txtSaldoEstoque.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'cboDeposito
        '
        Me.cboDeposito.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDeposito.AutoSize = False
        Me.cboDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDeposito.Location = New System.Drawing.Point(9, 37)
        Me.cboDeposito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDeposito.Size = New System.Drawing.Size(411, 20)
        Me.cboDeposito.TabIndex = 1
        '
        'txtQuantidadeEstoque
        '
        Me.txtQuantidadeEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeEstoque.DecimalDigits = 2
        Me.txtQuantidadeEstoque.Location = New System.Drawing.Point(448, 77)
        Me.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque"
        Me.txtQuantidadeEstoque.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeEstoque.TabIndex = 13
        Me.txtQuantidadeEstoque.Text = "0,00"
        Me.txtQuantidadeEstoque.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblQuantidadeEstoque
        '
        Me.lblQuantidadeEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeEstoque.AutoSize = True
        Me.lblQuantidadeEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeEstoque.Location = New System.Drawing.Point(448, 60)
        Me.lblQuantidadeEstoque.Name = "lblQuantidadeEstoque"
        Me.lblQuantidadeEstoque.Size = New System.Drawing.Size(75, 14)
        Me.lblQuantidadeEstoque.TabIndex = 12
        Me.lblQuantidadeEstoque.Text = "Qtde. Estoque"
        '
        'lblLote
        '
        Me.lblLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLote.AutoSize = True
        Me.lblLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLote.Location = New System.Drawing.Point(441, 20)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(31, 14)
        Me.lblLote.TabIndex = 2
        Me.lblLote.Text = "Lote:"
        '
        'lblDeposito
        '
        Me.lblDeposito.AutoSize = True
        Me.lblDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDeposito.Location = New System.Drawing.Point(8, 20)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(52, 14)
        Me.lblDeposito.TabIndex = 0
        Me.lblDeposito.Text = "Depósito:"
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(696, 65)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 15
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = CType(resources.GetObject("btnInserir.Image"), System.Drawing.Image)
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(696, 37)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 14
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpProduto
        '
        Me.grpProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProduto.BackColor = System.Drawing.Color.Transparent
        Me.grpProduto.Controls.Add(Me.txtUnidadeMedida)
        Me.grpProduto.Controls.Add(Me.Label2)
        Me.grpProduto.Controls.Add(Me.txtQuantidadeNotaFiscalTotal)
        Me.grpProduto.Controls.Add(Me.lblQuantidadeNotaFiscalTotal)
        Me.grpProduto.Controls.Add(Me.txtProduto)
        Me.grpProduto.Controls.Add(Me.lblProduto)
        Me.grpProduto.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpProduto.Location = New System.Drawing.Point(8, 3)
        Me.grpProduto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpProduto.Name = "grpProduto"
        Me.grpProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpProduto.Size = New System.Drawing.Size(797, 65)
        Me.grpProduto.TabIndex = 1
        Me.grpProduto.Text = "Identificação do Produto"
        Me.grpProduto.VisualStyleManager = Me.vsmMain
        '
        'txtUnidadeMedida
        '
        Me.txtUnidadeMedida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUnidadeMedida.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUnidadeMedida.Enabled = False
        Me.txtUnidadeMedida.IncludeLiterals = False
        Me.txtUnidadeMedida.Location = New System.Drawing.Point(580, 37)
        Me.txtUnidadeMedida.MaxLength = 9
        Me.txtUnidadeMedida.Name = "txtUnidadeMedida"
        Me.txtUnidadeMedida.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtUnidadeMedida.Size = New System.Drawing.Size(98, 20)
        Me.txtUnidadeMedida.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(579, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Unidade Medida:"
        '
        'txtQuantidadeNotaFiscalTotal
        '
        Me.txtQuantidadeNotaFiscalTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeNotaFiscalTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeNotaFiscalTotal.DecimalDigits = 4
        Me.txtQuantidadeNotaFiscalTotal.Location = New System.Drawing.Point(684, 37)
        Me.txtQuantidadeNotaFiscalTotal.Name = "txtQuantidadeNotaFiscalTotal"
        Me.txtQuantidadeNotaFiscalTotal.ReadOnly = True
        Me.txtQuantidadeNotaFiscalTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeNotaFiscalTotal.TabIndex = 5
        Me.txtQuantidadeNotaFiscalTotal.TabStop = False
        Me.txtQuantidadeNotaFiscalTotal.Text = "0,0000"
        Me.txtQuantidadeNotaFiscalTotal.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeNotaFiscalTotal
        '
        Me.lblQuantidadeNotaFiscalTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeNotaFiscalTotal.AutoSize = True
        Me.lblQuantidadeNotaFiscalTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeNotaFiscalTotal.Location = New System.Drawing.Point(684, 20)
        Me.lblQuantidadeNotaFiscalTotal.Name = "lblQuantidadeNotaFiscalTotal"
        Me.lblQuantidadeNotaFiscalTotal.Size = New System.Drawing.Size(92, 14)
        Me.lblQuantidadeNotaFiscalTotal.TabIndex = 4
        Me.lblQuantidadeNotaFiscalTotal.Text = "Qtde. Nota Fiscal:"
        '
        'txtProduto
        '
        Me.txtProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.Location = New System.Drawing.Point(9, 37)
        Me.txtProduto.MaxLength = 250
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(565, 20)
        Me.txtProduto.TabIndex = 1
        Me.txtProduto.TabStop = False
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblProduto.Location = New System.Drawing.Point(8, 20)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 0
        Me.lblProduto.Text = "Produto:"
        '
        'ToolTip
        '
        Me.ToolTip.AutomaticDelay = 0
        Me.ToolTip.AutoPopDelay = 5000
        Me.ToolTip.InitialDelay = 0
        Me.ToolTip.ReshowDelay = 0
        Me.ToolTip.ShowAlways = True
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'usrFatEmissaoNFeProdutoClassificacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "usrFatEmissaoNFeProdutoClassificacao"
        Me.Size = New System.Drawing.Size(815, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDadosProdutoFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosProdutoFiltro.ResumeLayout(False)
        Me.grpDadosProdutoFiltro.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpSalvarLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSalvarLote.ResumeLayout(False)
        Me.grpSalvarLote.PerformLayout()
        CType(Me.grdEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEstoque.ResumeLayout(False)
        Me.grpEstoque.PerformLayout()
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProduto.ResumeLayout(False)
        Me.grpProduto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents grpDadosProdutoFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtDestinatarioFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNotaFiscalFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNotaFiscalFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDestinatarioFiltro As System.Windows.Forms.Label
    Private WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGridListagem As System.Windows.Forms.Button
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpProduto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtQuantidadeNotaFiscalTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeNotaFiscalTotal As System.Windows.Forms.Label
    Friend WithEvents txtProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents grpEstoque As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtFatorConversao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblFatorConversao As System.Windows.Forms.Label
    Friend WithEvents lblSaldoEstoque As System.Windows.Forms.Label
    Friend WithEvents txtSaldoEstoque As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboDeposito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtQuantidadeEstoque As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeEstoque As System.Windows.Forms.Label
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents lblDeposito As System.Windows.Forms.Label
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Private WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdEstoque As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grpSalvarLote As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVoltarEstoque As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtLote As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents cboProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboUnidadeMedida As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUnidadeMedida As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboCodigoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnProcurarItem As System.Windows.Forms.Button
    Friend WithEvents brnGerarNovoLote As System.Windows.Forms.Button

End Class
