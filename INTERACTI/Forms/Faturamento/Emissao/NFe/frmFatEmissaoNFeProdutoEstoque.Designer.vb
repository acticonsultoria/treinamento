<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEmissaoNFeProdutoEstoque
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim grdEstoque_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdEstoque_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEmissaoNFeProdutoEstoque))
        Dim grdEstoque_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.pagLote = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpProduto = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtQuantidadeNotaFiscalTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeNotaFiscalTotal = New System.Windows.Forms.Label()
        Me.txtProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.grpSalvarLote = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.grdEstoque = New Janus.Windows.GridEX.GridEX()
        Me.grpEstoque = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtReferencia = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.txtQuantidadePedidoCompra = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadePedidoCompra = New System.Windows.Forms.Label()
        Me.lblPedidoCompraItem = New System.Windows.Forms.Label()
        Me.cboPedidoCompraItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPedidoCompra = New System.Windows.Forms.Label()
        Me.cboPedidoCompra = New Janus.Windows.EditControls.UIComboBox()
        Me.txtQuantidadeNotaFiscal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeNotaFiscal = New System.Windows.Forms.Label()
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
        Me.txtLote = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboLote = New Janus.Windows.EditControls.UIComboBox()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLote.SuspendLayout()
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProduto.SuspendLayout()
        CType(Me.grpSalvarLote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSalvarLote.SuspendLayout()
        CType(Me.grdEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEstoque.SuspendLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
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
        'pagLote
        '
        Me.pagLote.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLote.Controls.Add(Me.grpProduto)
        Me.pagLote.Controls.Add(Me.grpSalvarLote)
        Me.pagLote.Controls.Add(Me.grdEstoque)
        Me.pagLote.Controls.Add(Me.grpEstoque)
        Me.pagLote.Location = New System.Drawing.Point(1, 22)
        Me.pagLote.Name = "pagLote"
        Me.pagLote.Size = New System.Drawing.Size(840, 460)
        Me.pagLote.TabStop = True
        Me.pagLote.Text = "Dados do Estoque"
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(10, 380)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(26, 15)
        Me.btnConfigurarGrid.TabIndex = 3
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpProduto
        '
        Me.grpProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProduto.BackColor = System.Drawing.Color.Transparent
        Me.grpProduto.Controls.Add(Me.txtQuantidadeNotaFiscalTotal)
        Me.grpProduto.Controls.Add(Me.lblQuantidadeNotaFiscalTotal)
        Me.grpProduto.Controls.Add(Me.txtProduto)
        Me.grpProduto.Controls.Add(Me.lblProduto)
        Me.grpProduto.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpProduto.Location = New System.Drawing.Point(8, 4)
        Me.grpProduto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpProduto.Name = "grpProduto"
        Me.grpProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpProduto.Size = New System.Drawing.Size(824, 66)
        Me.grpProduto.TabIndex = 0
        Me.grpProduto.Text = "Identificação do Produto"
        Me.grpProduto.VisualStyleManager = Me.vsmMain
        '
        'txtQuantidadeNotaFiscalTotal
        '
        Me.txtQuantidadeNotaFiscalTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeNotaFiscalTotal.DecimalDigits = 4
        Me.txtQuantidadeNotaFiscalTotal.Location = New System.Drawing.Point(698, 37)
        Me.txtQuantidadeNotaFiscalTotal.Name = "txtQuantidadeNotaFiscalTotal"
        Me.txtQuantidadeNotaFiscalTotal.ReadOnly = True
        Me.txtQuantidadeNotaFiscalTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeNotaFiscalTotal.TabIndex = 3
        Me.txtQuantidadeNotaFiscalTotal.TabStop = False
        Me.txtQuantidadeNotaFiscalTotal.Text = "0,0000"
        Me.txtQuantidadeNotaFiscalTotal.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeNotaFiscalTotal
        '
        Me.lblQuantidadeNotaFiscalTotal.AutoSize = True
        Me.lblQuantidadeNotaFiscalTotal.Location = New System.Drawing.Point(695, 20)
        Me.lblQuantidadeNotaFiscalTotal.Name = "lblQuantidadeNotaFiscalTotal"
        Me.lblQuantidadeNotaFiscalTotal.Size = New System.Drawing.Size(92, 14)
        Me.lblQuantidadeNotaFiscalTotal.TabIndex = 2
        Me.lblQuantidadeNotaFiscalTotal.Text = "Qtde. Nota Fiscal:"
        '
        'txtProduto
        '
        Me.txtProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.Location = New System.Drawing.Point(9, 37)
        Me.txtProduto.MaxLength = 250
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(683, 20)
        Me.txtProduto.TabIndex = 1
        Me.txtProduto.TabStop = False
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(6, 20)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 0
        Me.lblProduto.Text = "Produto:"
        '
        'grpSalvarLote
        '
        Me.grpSalvarLote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSalvarLote.BackColor = System.Drawing.Color.Transparent
        Me.grpSalvarLote.Controls.Add(Me.Label1)
        Me.grpSalvarLote.Controls.Add(Me.btnVoltar)
        Me.grpSalvarLote.Location = New System.Drawing.Point(8, 400)
        Me.grpSalvarLote.Name = "grpSalvarLote"
        Me.grpSalvarLote.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSalvarLote.Size = New System.Drawing.Size(824, 51)
        Me.grpSalvarLote.TabIndex = 4
        Me.grpSalvarLote.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpSalvarLote.VisualStyleManager = Me.vsmMain
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(612, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Obs.: O Interacti não valida a [Qtde. Nota Fiscal] x [Qtde. Estoque] neste moment" & _
    "o mas, sim, na hora da Emissão da NF-e."
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(724, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 0
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdEstoque
        '
        Me.grdEstoque.AllowDrop = True
        Me.grdEstoque.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdEstoque.AlternatingColors = True
        Me.grdEstoque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdEstoque.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        grdEstoque_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdEstoque_DesignTimeLayout_Reference_0.Instance"), Object)
        grdEstoque_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdEstoque_DesignTimeLayout_Reference_1.Instance"), Object)
        grdEstoque_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdEstoque_DesignTimeLayout_Reference_0, grdEstoque_DesignTimeLayout_Reference_1})
        grdEstoque_DesignTimeLayout.LayoutString = resources.GetString("grdEstoque_DesignTimeLayout.LayoutString")
        Me.grdEstoque.DesignTimeLayout = grdEstoque_DesignTimeLayout
        Me.grdEstoque.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdEstoque.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdEstoque.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdEstoque.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdEstoque.FocusCellFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdEstoque.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdEstoque.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdEstoque.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdEstoque.GroupByBoxVisible = False
        Me.grdEstoque.Location = New System.Drawing.Point(8, 188)
        Me.grdEstoque.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdEstoque.Name = "grdEstoque"
        Me.grdEstoque.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdEstoque.RecordNavigator = True
        Me.grdEstoque.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdEstoque.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdEstoque.Size = New System.Drawing.Size(824, 209)
        Me.grdEstoque.TabIndex = 2
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
        Me.grpEstoque.Controls.Add(Me.txtReferencia)
        Me.grpEstoque.Controls.Add(Me.lblReferencia)
        Me.grpEstoque.Controls.Add(Me.txtQuantidadePedidoCompra)
        Me.grpEstoque.Controls.Add(Me.lblQuantidadePedidoCompra)
        Me.grpEstoque.Controls.Add(Me.lblPedidoCompraItem)
        Me.grpEstoque.Controls.Add(Me.cboPedidoCompraItem)
        Me.grpEstoque.Controls.Add(Me.lblPedidoCompra)
        Me.grpEstoque.Controls.Add(Me.cboPedidoCompra)
        Me.grpEstoque.Controls.Add(Me.txtQuantidadeNotaFiscal)
        Me.grpEstoque.Controls.Add(Me.lblQuantidadeNotaFiscal)
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
        Me.grpEstoque.Controls.Add(Me.txtLote)
        Me.grpEstoque.Controls.Add(Me.cboLote)
        Me.grpEstoque.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEstoque.Location = New System.Drawing.Point(8, 73)
        Me.grpEstoque.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEstoque.Name = "grpEstoque"
        Me.grpEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEstoque.Size = New System.Drawing.Size(824, 107)
        Me.grpEstoque.TabIndex = 1
        Me.grpEstoque.Text = "Dados de Movimentação do Estoque"
        Me.grpEstoque.VisualStyleManager = Me.vsmMain
        '
        'txtReferencia
        '
        Me.txtReferencia.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferencia.Location = New System.Drawing.Point(495, 79)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.ReadOnly = True
        Me.txtReferencia.Size = New System.Drawing.Size(206, 20)
        Me.txtReferencia.TabIndex = 8
        Me.txtReferencia.TabStop = False
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Location = New System.Drawing.Point(492, 64)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(63, 14)
        Me.lblReferencia.TabIndex = 34
        Me.lblReferencia.Text = "Referência:"
        '
        'txtQuantidadePedidoCompra
        '
        Me.txtQuantidadePedidoCompra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadePedidoCompra.DecimalDigits = 4
        Me.txtQuantidadePedidoCompra.Location = New System.Drawing.Point(389, 80)
        Me.txtQuantidadePedidoCompra.Name = "txtQuantidadePedidoCompra"
        Me.txtQuantidadePedidoCompra.ReadOnly = True
        Me.txtQuantidadePedidoCompra.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadePedidoCompra.TabIndex = 7
        Me.txtQuantidadePedidoCompra.Text = "0,0000"
        Me.txtQuantidadePedidoCompra.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadePedidoCompra
        '
        Me.lblQuantidadePedidoCompra.AutoSize = True
        Me.lblQuantidadePedidoCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadePedidoCompra.Location = New System.Drawing.Point(386, 64)
        Me.lblQuantidadePedidoCompra.Name = "lblQuantidadePedidoCompra"
        Me.lblQuantidadePedidoCompra.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadePedidoCompra.TabIndex = 33
        Me.lblQuantidadePedidoCompra.Text = "Quantidade:"
        '
        'lblPedidoCompraItem
        '
        Me.lblPedidoCompraItem.AutoSize = True
        Me.lblPedidoCompraItem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblPedidoCompraItem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblPedidoCompraItem.Location = New System.Drawing.Point(174, 64)
        Me.lblPedidoCompraItem.Name = "lblPedidoCompraItem"
        Me.lblPedidoCompraItem.Size = New System.Drawing.Size(29, 14)
        Me.lblPedidoCompraItem.TabIndex = 30
        Me.lblPedidoCompraItem.Text = "Item:"
        '
        'cboPedidoCompraItem
        '
        Me.cboPedidoCompraItem.AutoSize = False
        Me.cboPedidoCompraItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPedidoCompraItem.Location = New System.Drawing.Point(177, 80)
        Me.cboPedidoCompraItem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboPedidoCompraItem.Name = "cboPedidoCompraItem"
        Me.cboPedidoCompraItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPedidoCompraItem.Size = New System.Drawing.Size(206, 20)
        Me.cboPedidoCompraItem.TabIndex = 6
        '
        'lblPedidoCompra
        '
        Me.lblPedidoCompra.AutoSize = True
        Me.lblPedidoCompra.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblPedidoCompra.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblPedidoCompra.Location = New System.Drawing.Point(6, 64)
        Me.lblPedidoCompra.Name = "lblPedidoCompra"
        Me.lblPedidoCompra.Size = New System.Drawing.Size(82, 14)
        Me.lblPedidoCompra.TabIndex = 28
        Me.lblPedidoCompra.Text = "Pedido Compra:"
        '
        'cboPedidoCompra
        '
        Me.cboPedidoCompra.AutoSize = False
        Me.cboPedidoCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPedidoCompra.Location = New System.Drawing.Point(9, 79)
        Me.cboPedidoCompra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboPedidoCompra.Name = "cboPedidoCompra"
        Me.cboPedidoCompra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPedidoCompra.Size = New System.Drawing.Size(162, 20)
        Me.cboPedidoCompra.TabIndex = 5
        '
        'txtQuantidadeNotaFiscal
        '
        Me.txtQuantidadeNotaFiscal.DecimalDigits = 4
        Me.txtQuantidadeNotaFiscal.Location = New System.Drawing.Point(389, 37)
        Me.txtQuantidadeNotaFiscal.Name = "txtQuantidadeNotaFiscal"
        Me.txtQuantidadeNotaFiscal.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeNotaFiscal.TabIndex = 2
        Me.txtQuantidadeNotaFiscal.Text = "0,0000"
        Me.txtQuantidadeNotaFiscal.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeNotaFiscal
        '
        Me.lblQuantidadeNotaFiscal.AutoSize = True
        Me.lblQuantidadeNotaFiscal.Location = New System.Drawing.Point(386, 19)
        Me.lblQuantidadeNotaFiscal.Name = "lblQuantidadeNotaFiscal"
        Me.lblQuantidadeNotaFiscal.Size = New System.Drawing.Size(92, 14)
        Me.lblQuantidadeNotaFiscal.TabIndex = 7
        Me.lblQuantidadeNotaFiscal.Text = "Qtde. Nota Fiscal:"
        '
        'txtFatorConversao
        '
        Me.txtFatorConversao.DecimalDigits = 4
        Me.txtFatorConversao.Location = New System.Drawing.Point(495, 36)
        Me.txtFatorConversao.Name = "txtFatorConversao"
        Me.txtFatorConversao.Size = New System.Drawing.Size(100, 20)
        Me.txtFatorConversao.TabIndex = 3
        Me.txtFatorConversao.Text = "0,0000"
        Me.txtFatorConversao.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblFatorConversao
        '
        Me.lblFatorConversao.AutoSize = True
        Me.lblFatorConversao.Location = New System.Drawing.Point(492, 19)
        Me.lblFatorConversao.Name = "lblFatorConversao"
        Me.lblFatorConversao.Size = New System.Drawing.Size(91, 14)
        Me.lblFatorConversao.TabIndex = 9
        Me.lblFatorConversao.Text = "Fator Conversão:"
        '
        'lblSaldoEstoque
        '
        Me.lblSaldoEstoque.AutoSize = True
        Me.lblSaldoEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSaldoEstoque.Location = New System.Drawing.Point(386, 20)
        Me.lblSaldoEstoque.Name = "lblSaldoEstoque"
        Me.lblSaldoEstoque.Size = New System.Drawing.Size(79, 14)
        Me.lblSaldoEstoque.TabIndex = 5
        Me.lblSaldoEstoque.Text = "Saldo Estoque:"
        '
        'txtSaldoEstoque
        '
        Me.txtSaldoEstoque.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSaldoEstoque.DecimalDigits = 4
        Me.txtSaldoEstoque.Location = New System.Drawing.Point(389, 37)
        Me.txtSaldoEstoque.Name = "txtSaldoEstoque"
        Me.txtSaldoEstoque.ReadOnly = True
        Me.txtSaldoEstoque.Size = New System.Drawing.Size(76, 20)
        Me.txtSaldoEstoque.TabIndex = 6
        Me.txtSaldoEstoque.TabStop = False
        Me.txtSaldoEstoque.Text = "0,0000"
        Me.txtSaldoEstoque.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'cboDeposito
        '
        Me.cboDeposito.AutoSize = False
        Me.cboDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDeposito.Location = New System.Drawing.Point(9, 37)
        Me.cboDeposito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDeposito.Size = New System.Drawing.Size(162, 20)
        Me.cboDeposito.TabIndex = 0
        '
        'txtQuantidadeEstoque
        '
        Me.txtQuantidadeEstoque.DecimalDigits = 4
        Me.txtQuantidadeEstoque.Location = New System.Drawing.Point(601, 36)
        Me.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque"
        Me.txtQuantidadeEstoque.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeEstoque.TabIndex = 4
        Me.txtQuantidadeEstoque.Text = "0,0000"
        Me.txtQuantidadeEstoque.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeEstoque
        '
        Me.lblQuantidadeEstoque.AutoSize = True
        Me.lblQuantidadeEstoque.Location = New System.Drawing.Point(598, 19)
        Me.lblQuantidadeEstoque.Name = "lblQuantidadeEstoque"
        Me.lblQuantidadeEstoque.Size = New System.Drawing.Size(75, 14)
        Me.lblQuantidadeEstoque.TabIndex = 11
        Me.lblQuantidadeEstoque.Text = "Qtde. Estoque"
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.Location = New System.Drawing.Point(174, 20)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(31, 14)
        Me.lblLote.TabIndex = 2
        Me.lblLote.Text = "Lote:"
        '
        'lblDeposito
        '
        Me.lblDeposito.AutoSize = True
        Me.lblDeposito.Location = New System.Drawing.Point(6, 20)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(52, 14)
        Me.lblDeposito.TabIndex = 0
        Me.lblDeposito.Text = "Depósito:"
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(724, 62)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 10
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(724, 33)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 9
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtLote
        '
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Location = New System.Drawing.Point(177, 37)
        Me.txtLote.MaxLength = 50
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(206, 20)
        Me.txtLote.TabIndex = 1
        '
        'cboLote
        '
        Me.cboLote.AutoSize = False
        Me.cboLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboLote.Location = New System.Drawing.Point(177, 37)
        Me.cboLote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboLote.Name = "cboLote"
        Me.cboLote.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboLote.Size = New System.Drawing.Size(206, 20)
        Me.cboLote.TabIndex = 4
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(842, 483)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLote})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'frmFatEmissaoNFeProdutoEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 498)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEmissaoNFeProdutoEstoque"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário de Emissão de Nota Fiscal Eletrônica - Informação do Estoque"
        Me.pagLote.ResumeLayout(False)
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProduto.ResumeLayout(False)
        Me.grpProduto.PerformLayout()
        CType(Me.grpSalvarLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSalvarLote.ResumeLayout(False)
        Me.grpSalvarLote.PerformLayout()
        CType(Me.grdEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEstoque.ResumeLayout(False)
        Me.grpEstoque.PerformLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents pagLote As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpSalvarLote As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdEstoque As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpEstoque As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Private WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents grpProduto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtQuantidadeNotaFiscalTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeNotaFiscalTotal As System.Windows.Forms.Label
    Friend WithEvents txtProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents lblSaldoEstoque As System.Windows.Forms.Label
    Friend WithEvents txtSaldoEstoque As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboLote As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboDeposito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtQuantidadeEstoque As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeEstoque As System.Windows.Forms.Label
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents lblDeposito As System.Windows.Forms.Label
    Friend WithEvents txtLote As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFatorConversao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblFatorConversao As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeNotaFiscal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents txtReferencia As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblReferencia As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadePedidoCompra As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadePedidoCompra As System.Windows.Forms.Label
    Friend WithEvents lblPedidoCompraItem As System.Windows.Forms.Label
    Friend WithEvents cboPedidoCompraItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblPedidoCompra As System.Windows.Forms.Label
    Friend WithEvents cboPedidoCompra As Janus.Windows.EditControls.UIComboBox
End Class
