<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadProdutoBOM2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadProdutoBOM2))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem7 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem8 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVoltarItem = New System.Windows.Forms.Button()
        Me.txtItemAnterior = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblItemAnterior = New System.Windows.Forms.Label()
        Me.btnCadastrarItemLote = New Janus.Windows.EditControls.UIButton()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.cboCodigoProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoProduto = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.grpDadosMaterial = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboNivelInspecao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNivelInspecao = New System.Windows.Forms.Label()
        Me.cboUnidadeMedidaQuantidade = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUnidadeMedidaQuantidade = New System.Windows.Forms.Label()
        Me.cboUnidadeMedida = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUnidadeMedida = New System.Windows.Forms.Label()
        Me.btnCadastrarUnidadeMedida = New System.Windows.Forms.Button()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.grpDimensao = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboUnidadeMedidaDimensao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUnidadeMedidaDimensao = New System.Windows.Forms.Label()
        Me.lblDimensao = New System.Windows.Forms.Label()
        Me.txtDimensao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtAltura = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtComprimento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.lblComprimento = New System.Windows.Forms.Label()
        Me.txtLargura = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblLargura = New System.Windows.Forms.Label()
        Me.lblMP = New System.Windows.Forms.Label()
        Me.txtMP = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDET = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDET = New System.Windows.Forms.Label()
        Me.txtSC = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblSC = New System.Windows.Forms.Label()
        Me.btnNovoMaterial = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.btnProcurarItem = New System.Windows.Forms.Button()
        Me.btnCadastrarItem = New System.Windows.Forms.Button()
        Me.lblCodigoItem = New System.Windows.Forms.Label()
        Me.cboCodigoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDescricaoItem = New System.Windows.Forms.Label()
        Me.txtDescricaoItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnPesquisarBOM = New Janus.Windows.EditControls.UIButton()
        Me.btnCompararRequisicao = New Janus.Windows.EditControls.UIButton()
        Me.btnImprimirRelatorio = New Janus.Windows.EditControls.UIButton()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpDadosMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosMaterial.SuspendLayout()
        CType(Me.grpDimensao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDimensao.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(1045, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grdListagem)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grpDadosMaterial)
        Me.pagDados.Controls.Add(Me.grpControl)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(1043, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Produto - BOM"
        '
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 5
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 195)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(1027, 282)
        Me.grdListagem.TabIndex = 3
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdListagem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.btnVoltarItem)
        Me.grpDados.Controls.Add(Me.txtItemAnterior)
        Me.grpDados.Controls.Add(Me.lblItemAnterior)
        Me.grpDados.Controls.Add(Me.btnCadastrarItemLote)
        Me.grpDados.Controls.Add(Me.btnProcurarProduto)
        Me.grpDados.Controls.Add(Me.cboCodigoProduto)
        Me.grpDados.Controls.Add(Me.lblCodigoProduto)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(1027, 64)
        Me.grpDados.TabIndex = 0
        Me.grpDados.Text = "Dados do Produto"
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'btnVoltarItem
        '
        Me.btnVoltarItem.FlatAppearance.BorderSize = 0
        Me.btnVoltarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltarItem.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnVoltarItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnVoltarItem.Location = New System.Drawing.Point(728, 15)
        Me.btnVoltarItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnVoltarItem.Name = "btnVoltarItem"
        Me.btnVoltarItem.Size = New System.Drawing.Size(17, 16)
        Me.btnVoltarItem.TabIndex = 8
        Me.btnVoltarItem.TabStop = False
        Me.btnVoltarItem.UseVisualStyleBackColor = True
        '
        'txtItemAnterior
        '
        Me.txtItemAnterior.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtItemAnterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemAnterior.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtItemAnterior.Location = New System.Drawing.Point(510, 34)
        Me.txtItemAnterior.MaxLength = 120
        Me.txtItemAnterior.Name = "txtItemAnterior"
        Me.txtItemAnterior.ReadOnly = True
        Me.txtItemAnterior.Size = New System.Drawing.Size(235, 20)
        Me.txtItemAnterior.TabIndex = 7
        Me.txtItemAnterior.TabStop = False
        '
        'lblItemAnterior
        '
        Me.lblItemAnterior.AutoSize = True
        Me.lblItemAnterior.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblItemAnterior.Location = New System.Drawing.Point(507, 19)
        Me.lblItemAnterior.Name = "lblItemAnterior"
        Me.lblItemAnterior.Size = New System.Drawing.Size(70, 14)
        Me.lblItemAnterior.TabIndex = 6
        Me.lblItemAnterior.Text = "Item Anterior:"
        '
        'btnCadastrarItemLote
        '
        Me.btnCadastrarItemLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarItemLote.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnCadastrarItemLote.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCadastrarItemLote.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnCadastrarItemLote.Location = New System.Drawing.Point(930, 17)
        Me.btnCadastrarItemLote.Name = "btnCadastrarItemLote"
        Me.btnCadastrarItemLote.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCadastrarItemLote.Size = New System.Drawing.Size(88, 37)
        Me.btnCadastrarItemLote.TabIndex = 5
        Me.btnCadastrarItemLote.Text = "Cadastrar Item Lote"
        Me.btnCadastrarItemLote.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProduto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProduto.Location = New System.Drawing.Point(246, 17)
        Me.btnProcurarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProduto.TabIndex = 1
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'cboCodigoProduto
        '
        Me.cboCodigoProduto.Location = New System.Drawing.Point(9, 34)
        Me.cboCodigoProduto.Name = "cboCodigoProduto"
        Me.cboCodigoProduto.Size = New System.Drawing.Size(254, 20)
        Me.cboCodigoProduto.TabIndex = 2
        '
        'lblCodigoProduto
        '
        Me.lblCodigoProduto.AutoSize = True
        Me.lblCodigoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProduto.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        Me.lblCodigoProduto.Size = New System.Drawing.Size(83, 14)
        Me.lblCodigoProduto.TabIndex = 0
        Me.lblCodigoProduto.Text = "Código Produto:"
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDescricao.Location = New System.Drawing.Point(269, 34)
        Me.txtDescricao.MaxLength = 120
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(235, 20)
        Me.txtDescricao.TabIndex = 4
        Me.txtDescricao.TabStop = False
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricao.Location = New System.Drawing.Point(266, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 3
        Me.lblDescricao.Text = "Descrição:"
        '
        'grpDadosMaterial
        '
        Me.grpDadosMaterial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosMaterial.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosMaterial.Controls.Add(Me.cboNivelInspecao)
        Me.grpDadosMaterial.Controls.Add(Me.lblNivelInspecao)
        Me.grpDadosMaterial.Controls.Add(Me.cboUnidadeMedidaQuantidade)
        Me.grpDadosMaterial.Controls.Add(Me.lblUnidadeMedidaQuantidade)
        Me.grpDadosMaterial.Controls.Add(Me.cboUnidadeMedida)
        Me.grpDadosMaterial.Controls.Add(Me.lblUnidadeMedida)
        Me.grpDadosMaterial.Controls.Add(Me.btnCadastrarUnidadeMedida)
        Me.grpDadosMaterial.Controls.Add(Me.txtQuantidade)
        Me.grpDadosMaterial.Controls.Add(Me.lblQuantidade)
        Me.grpDadosMaterial.Controls.Add(Me.grpDimensao)
        Me.grpDadosMaterial.Controls.Add(Me.lblMP)
        Me.grpDadosMaterial.Controls.Add(Me.txtMP)
        Me.grpDadosMaterial.Controls.Add(Me.txtDET)
        Me.grpDadosMaterial.Controls.Add(Me.lblDET)
        Me.grpDadosMaterial.Controls.Add(Me.txtSC)
        Me.grpDadosMaterial.Controls.Add(Me.lblSC)
        Me.grpDadosMaterial.Controls.Add(Me.btnNovoMaterial)
        Me.grpDadosMaterial.Controls.Add(Me.btnExcluir)
        Me.grpDadosMaterial.Controls.Add(Me.btnInserir)
        Me.grpDadosMaterial.Controls.Add(Me.btnProcurarItem)
        Me.grpDadosMaterial.Controls.Add(Me.btnCadastrarItem)
        Me.grpDadosMaterial.Controls.Add(Me.lblCodigoItem)
        Me.grpDadosMaterial.Controls.Add(Me.cboCodigoItem)
        Me.grpDadosMaterial.Controls.Add(Me.lblDescricaoItem)
        Me.grpDadosMaterial.Controls.Add(Me.txtDescricaoItem)
        Me.grpDadosMaterial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpDadosMaterial.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosMaterial.Location = New System.Drawing.Point(8, 70)
        Me.grpDadosMaterial.Name = "grpDadosMaterial"
        Me.grpDadosMaterial.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosMaterial.Size = New System.Drawing.Size(1027, 119)
        Me.grpDadosMaterial.TabIndex = 2
        Me.grpDadosMaterial.Text = "Dados do Material"
        Me.grpDadosMaterial.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosMaterial.VisualStyleManager = Me.vsmMain
        '
        'cboNivelInspecao
        '
        Me.cboNivelInspecao.AutoSize = False
        Me.cboNivelInspecao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = ""
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = ""
        Me.cboNivelInspecao.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboNivelInspecao.Location = New System.Drawing.Point(782, 33)
        Me.cboNivelInspecao.Name = "cboNivelInspecao"
        Me.cboNivelInspecao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNivelInspecao.Size = New System.Drawing.Size(121, 20)
        Me.cboNivelInspecao.TabIndex = 4
        '
        'lblNivelInspecao
        '
        Me.lblNivelInspecao.AutoSize = True
        Me.lblNivelInspecao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNivelInspecao.Location = New System.Drawing.Point(779, 16)
        Me.lblNivelInspecao.Name = "lblNivelInspecao"
        Me.lblNivelInspecao.Size = New System.Drawing.Size(80, 14)
        Me.lblNivelInspecao.TabIndex = 19
        Me.lblNivelInspecao.Text = "Nível Inspeção:"
        '
        'cboUnidadeMedidaQuantidade
        '
        Me.cboUnidadeMedidaQuantidade.AutoSize = False
        Me.cboUnidadeMedidaQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = ""
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = ""
        Me.cboUnidadeMedidaQuantidade.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboUnidadeMedidaQuantidade.Location = New System.Drawing.Point(701, 33)
        Me.cboUnidadeMedidaQuantidade.Name = "cboUnidadeMedidaQuantidade"
        Me.cboUnidadeMedidaQuantidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedidaQuantidade.Size = New System.Drawing.Size(75, 20)
        Me.cboUnidadeMedidaQuantidade.TabIndex = 3
        '
        'lblUnidadeMedidaQuantidade
        '
        Me.lblUnidadeMedidaQuantidade.AutoSize = True
        Me.lblUnidadeMedidaQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUnidadeMedidaQuantidade.Location = New System.Drawing.Point(698, 16)
        Me.lblUnidadeMedidaQuantidade.Name = "lblUnidadeMedidaQuantidade"
        Me.lblUnidadeMedidaQuantidade.Size = New System.Drawing.Size(78, 14)
        Me.lblUnidadeMedidaQuantidade.TabIndex = 6
        Me.lblUnidadeMedidaQuantidade.Text = "Und. Med. Qtd:"
        '
        'cboUnidadeMedida
        '
        Me.cboUnidadeMedida.AutoSize = False
        Me.cboUnidadeMedida.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = ""
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = ""
        Me.cboUnidadeMedida.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboUnidadeMedida.Location = New System.Drawing.Point(9, 86)
        Me.cboUnidadeMedida.Name = "cboUnidadeMedida"
        Me.cboUnidadeMedida.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedida.ReadOnly = True
        Me.cboUnidadeMedida.Size = New System.Drawing.Size(107, 20)
        Me.cboUnidadeMedida.TabIndex = 5
        '
        'lblUnidadeMedida
        '
        Me.lblUnidadeMedida.AutoSize = True
        Me.lblUnidadeMedida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUnidadeMedida.Location = New System.Drawing.Point(25, 69)
        Me.lblUnidadeMedida.Name = "lblUnidadeMedida"
        Me.lblUnidadeMedida.Size = New System.Drawing.Size(58, 14)
        Me.lblUnidadeMedida.TabIndex = 7
        Me.lblUnidadeMedida.Text = "Und. Med.:"
        '
        'btnCadastrarUnidadeMedida
        '
        Me.btnCadastrarUnidadeMedida.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUnidadeMedida.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarUnidadeMedida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUnidadeMedida.Location = New System.Drawing.Point(7, 70)
        Me.btnCadastrarUnidadeMedida.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUnidadeMedida.Name = "btnCadastrarUnidadeMedida"
        Me.btnCadastrarUnidadeMedida.Size = New System.Drawing.Size(20, 13)
        Me.btnCadastrarUnidadeMedida.TabIndex = 8
        Me.btnCadastrarUnidadeMedida.TabStop = False
        Me.btnCadastrarUnidadeMedida.UseVisualStyleBackColor = True
        '
        'txtQuantidade
        '
        Me.txtQuantidade.DecimalDigits = 2
        Me.txtQuantidade.Location = New System.Drawing.Point(633, 33)
        Me.txtQuantidade.MaxLength = 15
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(62, 20)
        Me.txtQuantidade.TabIndex = 2
        Me.txtQuantidade.Text = "0,00"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidade.Location = New System.Drawing.Point(630, 15)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 4
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'grpDimensao
        '
        Me.grpDimensao.BackColor = System.Drawing.Color.Transparent
        Me.grpDimensao.Controls.Add(Me.cboUnidadeMedidaDimensao)
        Me.grpDimensao.Controls.Add(Me.lblUnidadeMedidaDimensao)
        Me.grpDimensao.Controls.Add(Me.lblDimensao)
        Me.grpDimensao.Controls.Add(Me.txtDimensao)
        Me.grpDimensao.Controls.Add(Me.txtAltura)
        Me.grpDimensao.Controls.Add(Me.txtComprimento)
        Me.grpDimensao.Controls.Add(Me.lblAltura)
        Me.grpDimensao.Controls.Add(Me.lblComprimento)
        Me.grpDimensao.Controls.Add(Me.txtLargura)
        Me.grpDimensao.Controls.Add(Me.lblLargura)
        Me.grpDimensao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDimensao.Location = New System.Drawing.Point(310, 56)
        Me.grpDimensao.Name = "grpDimensao"
        Me.grpDimensao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDimensao.Size = New System.Drawing.Size(481, 55)
        Me.grpDimensao.TabIndex = 12
        Me.grpDimensao.Visible = False
        Me.grpDimensao.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDimensao.VisualStyleManager = Me.vsmMain
        '
        'cboUnidadeMedidaDimensao
        '
        Me.cboUnidadeMedidaDimensao.AutoSize = False
        Me.cboUnidadeMedidaDimensao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem7.FormatStyle.Alpha = 0
        UiComboBoxItem7.IsSeparator = False
        UiComboBoxItem7.Text = ""
        UiComboBoxItem8.FormatStyle.Alpha = 0
        UiComboBoxItem8.IsSeparator = False
        UiComboBoxItem8.Text = ""
        Me.cboUnidadeMedidaDimensao.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem7, UiComboBoxItem8})
        Me.cboUnidadeMedidaDimensao.Location = New System.Drawing.Point(234, 29)
        Me.cboUnidadeMedidaDimensao.Name = "cboUnidadeMedidaDimensao"
        Me.cboUnidadeMedidaDimensao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedidaDimensao.Size = New System.Drawing.Size(70, 20)
        Me.cboUnidadeMedidaDimensao.TabIndex = 3
        '
        'lblUnidadeMedidaDimensao
        '
        Me.lblUnidadeMedidaDimensao.AutoSize = True
        Me.lblUnidadeMedidaDimensao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUnidadeMedidaDimensao.Location = New System.Drawing.Point(231, 12)
        Me.lblUnidadeMedidaDimensao.Name = "lblUnidadeMedidaDimensao"
        Me.lblUnidadeMedidaDimensao.Size = New System.Drawing.Size(58, 14)
        Me.lblUnidadeMedidaDimensao.TabIndex = 6
        Me.lblUnidadeMedidaDimensao.Text = "Und. Med.:"
        '
        'lblDimensao
        '
        Me.lblDimensao.AutoSize = True
        Me.lblDimensao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDimensao.Location = New System.Drawing.Point(307, 13)
        Me.lblDimensao.Name = "lblDimensao"
        Me.lblDimensao.Size = New System.Drawing.Size(57, 14)
        Me.lblDimensao.TabIndex = 8
        Me.lblDimensao.Text = "Dimensão:"
        '
        'txtDimensao
        '
        Me.txtDimensao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDimensao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDimensao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDimensao.Location = New System.Drawing.Point(310, 29)
        Me.txtDimensao.MaxLength = 120
        Me.txtDimensao.Name = "txtDimensao"
        Me.txtDimensao.ReadOnly = True
        Me.txtDimensao.Size = New System.Drawing.Size(165, 20)
        Me.txtDimensao.TabIndex = 4
        Me.txtDimensao.TabStop = False
        '
        'txtAltura
        '
        Me.txtAltura.BackColor = System.Drawing.Color.White
        Me.txtAltura.DecimalDigits = 0
        Me.txtAltura.Location = New System.Drawing.Point(158, 29)
        Me.txtAltura.MaxLength = 100
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.ReadOnly = True
        Me.txtAltura.Size = New System.Drawing.Size(70, 20)
        Me.txtAltura.TabIndex = 2
        Me.txtAltura.Text = "0"
        Me.txtAltura.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtComprimento
        '
        Me.txtComprimento.BackColor = System.Drawing.Color.White
        Me.txtComprimento.DecimalDigits = 0
        Me.txtComprimento.Location = New System.Drawing.Point(6, 30)
        Me.txtComprimento.MaxLength = 100
        Me.txtComprimento.Name = "txtComprimento"
        Me.txtComprimento.ReadOnly = True
        Me.txtComprimento.Size = New System.Drawing.Size(70, 20)
        Me.txtComprimento.TabIndex = 0
        Me.txtComprimento.Text = "0"
        Me.txtComprimento.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAltura.Location = New System.Drawing.Point(155, 12)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(39, 14)
        Me.lblAltura.TabIndex = 4
        Me.lblAltura.Text = "Altura:"
        '
        'lblComprimento
        '
        Me.lblComprimento.AutoSize = True
        Me.lblComprimento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblComprimento.Location = New System.Drawing.Point(3, 13)
        Me.lblComprimento.Name = "lblComprimento"
        Me.lblComprimento.Size = New System.Drawing.Size(72, 14)
        Me.lblComprimento.TabIndex = 0
        Me.lblComprimento.Text = "Comprimento:"
        '
        'txtLargura
        '
        Me.txtLargura.BackColor = System.Drawing.Color.White
        Me.txtLargura.DecimalDigits = 0
        Me.txtLargura.Location = New System.Drawing.Point(82, 30)
        Me.txtLargura.MaxLength = 100
        Me.txtLargura.Name = "txtLargura"
        Me.txtLargura.ReadOnly = True
        Me.txtLargura.Size = New System.Drawing.Size(70, 20)
        Me.txtLargura.TabIndex = 1
        Me.txtLargura.Text = "0"
        Me.txtLargura.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLargura
        '
        Me.lblLargura.AutoSize = True
        Me.lblLargura.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLargura.Location = New System.Drawing.Point(79, 13)
        Me.lblLargura.Name = "lblLargura"
        Me.lblLargura.Size = New System.Drawing.Size(48, 14)
        Me.lblLargura.TabIndex = 2
        Me.lblLargura.Text = "Largura:"
        '
        'lblMP
        '
        Me.lblMP.AutoSize = True
        Me.lblMP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMP.Location = New System.Drawing.Point(239, 69)
        Me.lblMP.Name = "lblMP"
        Me.lblMP.Size = New System.Drawing.Size(24, 14)
        Me.lblMP.TabIndex = 14
        Me.lblMP.Text = "MP:"
        '
        'txtMP
        '
        Me.txtMP.BackColor = System.Drawing.Color.White
        Me.txtMP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMP.Location = New System.Drawing.Point(242, 86)
        Me.txtMP.MaxLength = 2
        Me.txtMP.Name = "txtMP"
        Me.txtMP.Size = New System.Drawing.Size(62, 20)
        Me.txtMP.TabIndex = 8
        '
        'txtDET
        '
        Me.txtDET.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDET.DecimalDigits = 0
        Me.txtDET.FormatString = "000"
        Me.txtDET.Location = New System.Drawing.Point(182, 86)
        Me.txtDET.MaxLength = 3
        Me.txtDET.Name = "txtDET"
        Me.txtDET.ReadOnly = True
        Me.txtDET.Size = New System.Drawing.Size(54, 20)
        Me.txtDET.TabIndex = 7
        Me.txtDET.Text = "000"
        Me.txtDET.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblDET
        '
        Me.lblDET.AutoSize = True
        Me.lblDET.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDET.Location = New System.Drawing.Point(179, 69)
        Me.lblDET.Name = "lblDET"
        Me.lblDET.Size = New System.Drawing.Size(28, 14)
        Me.lblDET.TabIndex = 12
        Me.lblDET.Text = "DET:"
        '
        'txtSC
        '
        Me.txtSC.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSC.DecimalDigits = 0
        Me.txtSC.FormatString = "000"
        Me.txtSC.Location = New System.Drawing.Point(122, 86)
        Me.txtSC.MaxLength = 3
        Me.txtSC.Name = "txtSC"
        Me.txtSC.ReadOnly = True
        Me.txtSC.Size = New System.Drawing.Size(54, 20)
        Me.txtSC.TabIndex = 6
        Me.txtSC.Text = "000"
        Me.txtSC.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSC
        '
        Me.lblSC.AutoSize = True
        Me.lblSC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSC.Location = New System.Drawing.Point(119, 69)
        Me.lblSC.Name = "lblSC"
        Me.lblSC.Size = New System.Drawing.Size(24, 14)
        Me.lblSC.TabIndex = 10
        Me.lblSC.Text = "SC:"
        '
        'btnNovoMaterial
        '
        Me.btnNovoMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovoMaterial.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovoMaterial.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovoMaterial.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovoMaterial.Location = New System.Drawing.Point(930, 88)
        Me.btnNovoMaterial.Name = "btnNovoMaterial"
        Me.btnNovoMaterial.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovoMaterial.Size = New System.Drawing.Size(91, 23)
        Me.btnNovoMaterial.TabIndex = 11
        Me.btnNovoMaterial.Text = "Novo"
        Me.btnNovoMaterial.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(930, 59)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 10
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(930, 30)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 9
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnProcurarItem
        '
        Me.btnProcurarItem.FlatAppearance.BorderSize = 0
        Me.btnProcurarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItem.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItem.Location = New System.Drawing.Point(287, 14)
        Me.btnProcurarItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItem.Name = "btnProcurarItem"
        Me.btnProcurarItem.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItem.TabIndex = 2
        Me.btnProcurarItem.TabStop = False
        Me.btnProcurarItem.UseVisualStyleBackColor = True
        '
        'btnCadastrarItem
        '
        Me.btnCadastrarItem.FlatAppearance.BorderSize = 0
        Me.btnCadastrarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarItem.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarItem.Location = New System.Drawing.Point(9, 16)
        Me.btnCadastrarItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarItem.Name = "btnCadastrarItem"
        Me.btnCadastrarItem.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarItem.TabIndex = 0
        Me.btnCadastrarItem.TabStop = False
        Me.btnCadastrarItem.UseVisualStyleBackColor = True
        '
        'lblCodigoItem
        '
        Me.lblCodigoItem.AutoSize = True
        Me.lblCodigoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoItem.Location = New System.Drawing.Point(25, 15)
        Me.lblCodigoItem.Name = "lblCodigoItem"
        Me.lblCodigoItem.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigoItem.TabIndex = 1
        Me.lblCodigoItem.Text = "Código:"
        '
        'cboCodigoItem
        '
        Me.cboCodigoItem.Location = New System.Drawing.Point(9, 32)
        Me.cboCodigoItem.Name = "cboCodigoItem"
        Me.cboCodigoItem.Size = New System.Drawing.Size(295, 20)
        Me.cboCodigoItem.TabIndex = 0
        '
        'lblDescricaoItem
        '
        Me.lblDescricaoItem.AutoSize = True
        Me.lblDescricaoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricaoItem.Location = New System.Drawing.Point(307, 15)
        Me.lblDescricaoItem.Name = "lblDescricaoItem"
        Me.lblDescricaoItem.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoItem.TabIndex = 2
        Me.lblDescricaoItem.Text = "Descrição:"
        '
        'txtDescricaoItem
        '
        Me.txtDescricaoItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoItem.Location = New System.Drawing.Point(310, 32)
        Me.txtDescricaoItem.MaxLength = 120
        Me.txtDescricaoItem.Name = "txtDescricaoItem"
        Me.txtDescricaoItem.ReadOnly = True
        Me.txtDescricaoItem.Size = New System.Drawing.Size(317, 20)
        Me.txtDescricaoItem.TabIndex = 1
        Me.txtDescricaoItem.TabStop = False
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnPesquisarBOM)
        Me.grpControl.Controls.Add(Me.btnCompararRequisicao)
        Me.grpControl.Controls.Add(Me.btnImprimirRelatorio)
        Me.grpControl.Controls.Add(Me.btnImprimir)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(1027, 51)
        Me.grpControl.TabIndex = 4
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnPesquisarBOM
        '
        Me.btnPesquisarBOM.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPesquisarBOM.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnPesquisarBOM.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPesquisarBOM.Location = New System.Drawing.Point(404, 17)
        Me.btnPesquisarBOM.Name = "btnPesquisarBOM"
        Me.btnPesquisarBOM.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPesquisarBOM.Size = New System.Drawing.Size(134, 23)
        Me.btnPesquisarBOM.TabIndex = 4
        Me.btnPesquisarBOM.Text = "Pesquisar BOM"
        Me.btnPesquisarBOM.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCompararRequisicao
        '
        Me.btnCompararRequisicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCompararRequisicao.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnCompararRequisicao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCompararRequisicao.Location = New System.Drawing.Point(544, 17)
        Me.btnCompararRequisicao.Name = "btnCompararRequisicao"
        Me.btnCompararRequisicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCompararRequisicao.Size = New System.Drawing.Size(151, 23)
        Me.btnCompararRequisicao.TabIndex = 3
        Me.btnCompararRequisicao.Text = "Comparar Requisição"
        Me.btnCompararRequisicao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImprimirRelatorio
        '
        Me.btnImprimirRelatorio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirRelatorio.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimirRelatorio.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimirRelatorio.Location = New System.Drawing.Point(699, 17)
        Me.btnImprimirRelatorio.Name = "btnImprimirRelatorio"
        Me.btnImprimirRelatorio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimirRelatorio.Size = New System.Drawing.Size(108, 23)
        Me.btnImprimirRelatorio.TabIndex = 0
        Me.btnImprimirRelatorio.Text = "Imprimir Relatório"
        Me.btnImprimirRelatorio.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(813, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimir.Size = New System.Drawing.Size(108, 23)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Gerar Tabela"
        Me.btnImprimir.Visible = False
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(927, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrCadProdutoBOM2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadProdutoBOM2"
        Me.Size = New System.Drawing.Size(1045, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpDadosMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosMaterial.ResumeLayout(False)
        Me.grpDadosMaterial.PerformLayout()
        CType(Me.grpDimensao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDimensao.ResumeLayout(False)
        Me.grpDimensao.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDadosMaterial As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnProcurarItem As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarItem As System.Windows.Forms.Button
    Friend WithEvents lblCodigoItem As System.Windows.Forms.Label
    Friend WithEvents cboCodigoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDescricaoItem As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents cboCodigoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoProduto As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents btnNovoMaterial As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnImprimirRelatorio As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblMP As System.Windows.Forms.Label
    Friend WithEvents txtMP As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDET As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDET As System.Windows.Forms.Label
    Friend WithEvents txtSC As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblSC As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnCadastrarItemLote As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDimensao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboUnidadeMedida As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUnidadeMedida As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarUnidadeMedida As System.Windows.Forms.Button
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents cboUnidadeMedidaDimensao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUnidadeMedidaDimensao As System.Windows.Forms.Label
    Friend WithEvents lblDimensao As System.Windows.Forms.Label
    Friend WithEvents txtDimensao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtAltura As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtComprimento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAltura As System.Windows.Forms.Label
    Friend WithEvents lblComprimento As System.Windows.Forms.Label
    Friend WithEvents txtLargura As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblLargura As System.Windows.Forms.Label
    Friend WithEvents cboUnidadeMedidaQuantidade As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUnidadeMedidaQuantidade As System.Windows.Forms.Label
    Friend WithEvents MaskedEditBox1 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblItemAnterior As System.Windows.Forms.Label
    Friend WithEvents txtItemAnterior As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnVoltarItem As System.Windows.Forms.Button
    Friend WithEvents cboNivelInspecao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNivelInspecao As System.Windows.Forms.Label
    Friend WithEvents btnCompararRequisicao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnPesquisarBOM As Janus.Windows.EditControls.UIButton

End Class
