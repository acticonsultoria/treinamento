<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadProdutoBOM
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadProdutoBOM))
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdBOM_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdBOM_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.UiComboBox1 = New Janus.Windows.EditControls.UIComboBox()
        Me.UiComboBox2 = New Janus.Windows.EditControls.UIComboBox()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGridBOM = New System.Windows.Forms.Button()
        Me.grpProduto = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.cboCodigoProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.grpTotal = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtTotalDesconto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotalDesconto = New System.Windows.Forms.Label()
        Me.txtTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpBOM = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarItemOriginal = New System.Windows.Forms.Button()
        Me.lblCodigoItemOriginal = New System.Windows.Forms.Label()
        Me.cboCodigoItemOriginal = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDescricaoItemOriginal = New System.Windows.Forms.Label()
        Me.txtDescricaoItemOriginal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTipoItem = New System.Windows.Forms.Label()
        Me.cboTipoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.btnProcurarItem = New System.Windows.Forms.Button()
        Me.btnCadastrarUnidadeMedida = New System.Windows.Forms.Button()
        Me.txtValorUnitarioDesconto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnitarioDesconto = New System.Windows.Forms.Label()
        Me.txtDescontoValor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDescontoValor = New System.Windows.Forms.Label()
        Me.txtDescontoPercentual = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDescontoPercentual = New System.Windows.Forms.Label()
        Me.txtValorTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.txtValorUnitario = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnitario = New System.Windows.Forms.Label()
        Me.lblUnidadeMedida = New System.Windows.Forms.Label()
        Me.cboUnidadeMedida = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarItem = New System.Windows.Forms.Button()
        Me.lblCodigoItem = New System.Windows.Forms.Label()
        Me.cboCodigoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDescricaoItem = New System.Windows.Forms.Label()
        Me.txtDescricaoItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.grdBOM = New Janus.Windows.GridEX.GridEX()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpOutros = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtTotalOutros = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotalOutros = New System.Windows.Forms.Label()
        Me.txtDescontoPercentualMaoObra = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtTotalMaoObra = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotalEmbalagem = New System.Windows.Forms.Label()
        Me.txtTotalEmbalagem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDescontoPercentualMaoObra = New System.Windows.Forms.Label()
        Me.lblTotalMaoObra = New System.Windows.Forms.Label()
        Me.lblTotalTransporte = New System.Windows.Forms.Label()
        Me.txtTotalTransporte = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.UiButton2 = New Janus.Windows.EditControls.UIButton()
        Me.btnCadastrarItemLote = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProduto.SuspendLayout()
        CType(Me.grpTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTotal.SuspendLayout()
        CType(Me.grpBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBOM.SuspendLayout()
        CType(Me.grdBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grpOutros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOutros.SuspendLayout()
        Me.SuspendLayout()
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
        'UiComboBox1
        '
        resources.ApplyResources(Me.UiComboBox1, "UiComboBox1")
        Me.UiComboBox1.Name = "UiComboBox1"
        '
        'UiComboBox2
        '
        resources.ApplyResources(Me.UiComboBox2, "UiComboBox2")
        Me.UiComboBox2.Name = "UiComboBox2"
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.tabMain, "tabMain")
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnExcelGrid)
        Me.pagDados.Controls.Add(Me.btnAgruparGridBOM)
        Me.pagDados.Controls.Add(Me.grpProduto)
        Me.pagDados.Controls.Add(Me.grpTotal)
        Me.pagDados.Controls.Add(Me.btnConfigurarGrid)
        Me.pagDados.Controls.Add(Me.grpBOM)
        Me.pagDados.Controls.Add(Me.grdBOM)
        Me.pagDados.Controls.Add(Me.grpControle)
        Me.pagDados.Controls.Add(Me.grpOutros)
        Me.pagDados.Key = "pagDados"
        resources.ApplyResources(Me.pagDados, "pagDados")
        Me.pagDados.Name = "pagDados"
        Me.pagDados.TabStop = True
        '
        'btnExcelGrid
        '
        resources.ApplyResources(Me.btnExcelGrid, "btnExcelGrid")
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGridBOM
        '
        resources.ApplyResources(Me.btnAgruparGridBOM, "btnAgruparGridBOM")
        Me.btnAgruparGridBOM.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridBOM.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridBOM.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridBOM.Name = "btnAgruparGridBOM"
        Me.btnAgruparGridBOM.TabStop = False
        Me.btnAgruparGridBOM.UseVisualStyleBackColor = False
        '
        'grpProduto
        '
        resources.ApplyResources(Me.grpProduto, "grpProduto")
        Me.grpProduto.BackColor = System.Drawing.Color.Transparent
        Me.grpProduto.Controls.Add(Me.btnCadastrarItemLote)
        Me.grpProduto.Controls.Add(Me.btnProcurarProduto)
        Me.grpProduto.Controls.Add(Me.cboCodigoProduto)
        Me.grpProduto.Controls.Add(Me.Label1)
        Me.grpProduto.Controls.Add(Me.txtDescricao)
        Me.grpProduto.Controls.Add(Me.lblDescricao)
        Me.grpProduto.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpProduto.Name = "grpProduto"
        Me.grpProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpProduto.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpProduto.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnProcurarProduto, "btnProcurarProduto")
        Me.btnProcurarProduto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'cboCodigoProduto
        '
        resources.ApplyResources(Me.cboCodigoProduto, "cboCodigoProduto")
        Me.cboCodigoProduto.Name = "cboCodigoProduto"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtDescricao
        '
        resources.ApplyResources(Me.txtDescricao, "txtDescricao")
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.MaxLength = 120
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.TabStop = False
        '
        'lblDescricao
        '
        resources.ApplyResources(Me.lblDescricao, "lblDescricao")
        Me.lblDescricao.Name = "lblDescricao"
        '
        'grpTotal
        '
        resources.ApplyResources(Me.grpTotal, "grpTotal")
        Me.grpTotal.BackColor = System.Drawing.Color.Transparent
        Me.grpTotal.Controls.Add(Me.txtTotalDesconto)
        Me.grpTotal.Controls.Add(Me.lblTotalDesconto)
        Me.grpTotal.Controls.Add(Me.txtTotal)
        Me.grpTotal.Controls.Add(Me.lblTotal)
        Me.grpTotal.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpTotal.Name = "grpTotal"
        Me.grpTotal.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpTotal.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpTotal.VisualStyleManager = Me.vsmMain
        '
        'txtTotalDesconto
        '
        resources.ApplyResources(Me.txtTotalDesconto, "txtTotalDesconto")
        Me.txtTotalDesconto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalDesconto.DecimalDigits = 2
        Me.txtTotalDesconto.MaxLength = 15
        Me.txtTotalDesconto.Name = "txtTotalDesconto"
        Me.txtTotalDesconto.ReadOnly = True
        Me.txtTotalDesconto.TabStop = False
        Me.txtTotalDesconto.Value = 0.0R
        Me.txtTotalDesconto.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblTotalDesconto
        '
        resources.ApplyResources(Me.lblTotalDesconto, "lblTotalDesconto")
        Me.lblTotalDesconto.Name = "lblTotalDesconto"
        '
        'txtTotal
        '
        resources.ApplyResources(Me.txtTotal, "txtTotal")
        Me.txtTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotal.DecimalDigits = 2
        Me.txtTotal.MaxLength = 15
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.TabStop = False
        Me.txtTotal.Value = 0.0R
        Me.txtTotal.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblTotal
        '
        resources.ApplyResources(Me.lblTotal, "lblTotal")
        Me.lblTotal.Name = "lblTotal"
        '
        'btnConfigurarGrid
        '
        resources.ApplyResources(Me.btnConfigurarGrid, "btnConfigurarGrid")
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpBOM
        '
        resources.ApplyResources(Me.grpBOM, "grpBOM")
        Me.grpBOM.BackColor = System.Drawing.Color.Transparent
        Me.grpBOM.Controls.Add(Me.btnProcurarItemOriginal)
        Me.grpBOM.Controls.Add(Me.lblCodigoItemOriginal)
        Me.grpBOM.Controls.Add(Me.cboCodigoItemOriginal)
        Me.grpBOM.Controls.Add(Me.lblDescricaoItemOriginal)
        Me.grpBOM.Controls.Add(Me.txtDescricaoItemOriginal)
        Me.grpBOM.Controls.Add(Me.lblTipoItem)
        Me.grpBOM.Controls.Add(Me.cboTipoItem)
        Me.grpBOM.Controls.Add(Me.btnProcurarItem)
        Me.grpBOM.Controls.Add(Me.btnCadastrarUnidadeMedida)
        Me.grpBOM.Controls.Add(Me.txtValorUnitarioDesconto)
        Me.grpBOM.Controls.Add(Me.lblValorUnitarioDesconto)
        Me.grpBOM.Controls.Add(Me.txtDescontoValor)
        Me.grpBOM.Controls.Add(Me.lblDescontoValor)
        Me.grpBOM.Controls.Add(Me.txtDescontoPercentual)
        Me.grpBOM.Controls.Add(Me.lblDescontoPercentual)
        Me.grpBOM.Controls.Add(Me.txtValorTotal)
        Me.grpBOM.Controls.Add(Me.lblValorTotal)
        Me.grpBOM.Controls.Add(Me.txtValorUnitario)
        Me.grpBOM.Controls.Add(Me.lblValorUnitario)
        Me.grpBOM.Controls.Add(Me.lblUnidadeMedida)
        Me.grpBOM.Controls.Add(Me.cboUnidadeMedida)
        Me.grpBOM.Controls.Add(Me.btnCadastrarItem)
        Me.grpBOM.Controls.Add(Me.lblCodigoItem)
        Me.grpBOM.Controls.Add(Me.cboCodigoItem)
        Me.grpBOM.Controls.Add(Me.lblQuantidade)
        Me.grpBOM.Controls.Add(Me.txtQuantidade)
        Me.grpBOM.Controls.Add(Me.lblDescricaoItem)
        Me.grpBOM.Controls.Add(Me.txtDescricaoItem)
        Me.grpBOM.Controls.Add(Me.btnExcluir)
        Me.grpBOM.Controls.Add(Me.btnInserir)
        Me.grpBOM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpBOM.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpBOM.Name = "grpBOM"
        Me.grpBOM.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpBOM.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpBOM.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarItemOriginal
        '
        Me.btnProcurarItemOriginal.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnProcurarItemOriginal, "btnProcurarItemOriginal")
        Me.btnProcurarItemOriginal.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarItemOriginal.Name = "btnProcurarItemOriginal"
        Me.btnProcurarItemOriginal.TabStop = False
        Me.btnProcurarItemOriginal.UseVisualStyleBackColor = True
        '
        'lblCodigoItemOriginal
        '
        resources.ApplyResources(Me.lblCodigoItemOriginal, "lblCodigoItemOriginal")
        Me.lblCodigoItemOriginal.Name = "lblCodigoItemOriginal"
        '
        'cboCodigoItemOriginal
        '
        resources.ApplyResources(Me.cboCodigoItemOriginal, "cboCodigoItemOriginal")
        Me.cboCodigoItemOriginal.Name = "cboCodigoItemOriginal"
        '
        'lblDescricaoItemOriginal
        '
        resources.ApplyResources(Me.lblDescricaoItemOriginal, "lblDescricaoItemOriginal")
        Me.lblDescricaoItemOriginal.Name = "lblDescricaoItemOriginal"
        '
        'txtDescricaoItemOriginal
        '
        resources.ApplyResources(Me.txtDescricaoItemOriginal, "txtDescricaoItemOriginal")
        Me.txtDescricaoItemOriginal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoItemOriginal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoItemOriginal.MaxLength = 120
        Me.txtDescricaoItemOriginal.Name = "txtDescricaoItemOriginal"
        Me.txtDescricaoItemOriginal.ReadOnly = True
        Me.txtDescricaoItemOriginal.TabStop = False
        '
        'lblTipoItem
        '
        resources.ApplyResources(Me.lblTipoItem, "lblTipoItem")
        Me.lblTipoItem.Name = "lblTipoItem"
        '
        'cboTipoItem
        '
        resources.ApplyResources(Me.cboTipoItem, "cboTipoItem")
        Me.cboTipoItem.Name = "cboTipoItem"
        '
        'btnProcurarItem
        '
        Me.btnProcurarItem.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnProcurarItem, "btnProcurarItem")
        Me.btnProcurarItem.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarItem.Name = "btnProcurarItem"
        Me.btnProcurarItem.TabStop = False
        Me.btnProcurarItem.UseVisualStyleBackColor = True
        '
        'btnCadastrarUnidadeMedida
        '
        Me.btnCadastrarUnidadeMedida.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarUnidadeMedida, "btnCadastrarUnidadeMedida")
        Me.btnCadastrarUnidadeMedida.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarUnidadeMedida.Name = "btnCadastrarUnidadeMedida"
        Me.btnCadastrarUnidadeMedida.TabStop = False
        Me.btnCadastrarUnidadeMedida.UseVisualStyleBackColor = True
        '
        'txtValorUnitarioDesconto
        '
        Me.txtValorUnitarioDesconto.DecimalDigits = 4
        resources.ApplyResources(Me.txtValorUnitarioDesconto, "txtValorUnitarioDesconto")
        Me.txtValorUnitarioDesconto.MaxLength = 15
        Me.txtValorUnitarioDesconto.Name = "txtValorUnitarioDesconto"
        Me.txtValorUnitarioDesconto.Value = 0.0R
        Me.txtValorUnitarioDesconto.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblValorUnitarioDesconto
        '
        resources.ApplyResources(Me.lblValorUnitarioDesconto, "lblValorUnitarioDesconto")
        Me.lblValorUnitarioDesconto.Name = "lblValorUnitarioDesconto"
        '
        'txtDescontoValor
        '
        Me.txtDescontoValor.DecimalDigits = 4
        resources.ApplyResources(Me.txtDescontoValor, "txtDescontoValor")
        Me.txtDescontoValor.MaxLength = 15
        Me.txtDescontoValor.Name = "txtDescontoValor"
        Me.txtDescontoValor.Value = 0.0R
        Me.txtDescontoValor.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblDescontoValor
        '
        resources.ApplyResources(Me.lblDescontoValor, "lblDescontoValor")
        Me.lblDescontoValor.Name = "lblDescontoValor"
        '
        'txtDescontoPercentual
        '
        Me.txtDescontoPercentual.DecimalDigits = 5
        resources.ApplyResources(Me.txtDescontoPercentual, "txtDescontoPercentual")
        Me.txtDescontoPercentual.MaxLength = 15
        Me.txtDescontoPercentual.Name = "txtDescontoPercentual"
        Me.txtDescontoPercentual.Value = 0.0R
        Me.txtDescontoPercentual.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblDescontoPercentual
        '
        resources.ApplyResources(Me.lblDescontoPercentual, "lblDescontoPercentual")
        Me.lblDescontoPercentual.Name = "lblDescontoPercentual"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTotal.DecimalDigits = 2
        resources.ApplyResources(Me.txtValorTotal, "txtValorTotal")
        Me.txtValorTotal.MaxLength = 15
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.TabStop = False
        Me.txtValorTotal.Value = 0.0R
        Me.txtValorTotal.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblValorTotal
        '
        resources.ApplyResources(Me.lblValorTotal, "lblValorTotal")
        Me.lblValorTotal.Name = "lblValorTotal"
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorUnitario.DecimalDigits = 4
        resources.ApplyResources(Me.txtValorUnitario, "txtValorUnitario")
        Me.txtValorUnitario.MaxLength = 15
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.TabStop = False
        Me.txtValorUnitario.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblValorUnitario
        '
        resources.ApplyResources(Me.lblValorUnitario, "lblValorUnitario")
        Me.lblValorUnitario.Name = "lblValorUnitario"
        '
        'lblUnidadeMedida
        '
        resources.ApplyResources(Me.lblUnidadeMedida, "lblUnidadeMedida")
        Me.lblUnidadeMedida.Name = "lblUnidadeMedida"
        '
        'cboUnidadeMedida
        '
        resources.ApplyResources(Me.cboUnidadeMedida, "cboUnidadeMedida")
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem3, "UiComboBoxItem3")
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem4, "UiComboBoxItem4")
        Me.cboUnidadeMedida.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboUnidadeMedida.Name = "cboUnidadeMedida"
        Me.cboUnidadeMedida.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'btnCadastrarItem
        '
        Me.btnCadastrarItem.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarItem, "btnCadastrarItem")
        Me.btnCadastrarItem.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarItem.Name = "btnCadastrarItem"
        Me.btnCadastrarItem.TabStop = False
        Me.btnCadastrarItem.UseVisualStyleBackColor = True
        '
        'lblCodigoItem
        '
        resources.ApplyResources(Me.lblCodigoItem, "lblCodigoItem")
        Me.lblCodigoItem.Name = "lblCodigoItem"
        '
        'cboCodigoItem
        '
        resources.ApplyResources(Me.cboCodigoItem, "cboCodigoItem")
        Me.cboCodigoItem.Name = "cboCodigoItem"
        '
        'lblQuantidade
        '
        resources.ApplyResources(Me.lblQuantidade, "lblQuantidade")
        Me.lblQuantidade.Name = "lblQuantidade"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.DecimalDigits = 4
        resources.ApplyResources(Me.txtQuantidade, "txtQuantidade")
        Me.txtQuantidade.MaxLength = 15
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblDescricaoItem
        '
        resources.ApplyResources(Me.lblDescricaoItem, "lblDescricaoItem")
        Me.lblDescricaoItem.Name = "lblDescricaoItem"
        '
        'txtDescricaoItem
        '
        resources.ApplyResources(Me.txtDescricaoItem, "txtDescricaoItem")
        Me.txtDescricaoItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoItem.MaxLength = 120
        Me.txtDescricaoItem.Name = "txtDescricaoItem"
        Me.txtDescricaoItem.ReadOnly = True
        Me.txtDescricaoItem.TabStop = False
        '
        'btnExcluir
        '
        resources.ApplyResources(Me.btnExcluir, "btnExcluir")
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        resources.ApplyResources(Me.btnInserir, "btnInserir")
        Me.btnInserir.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdBOM
        '
        Me.grdBOM.AlternatingColors = True
        resources.ApplyResources(Me.grdBOM, "grdBOM")
        Me.grdBOM.AutoEdit = True
        grdBOM_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdBOM_DesignTimeLayout_Reference_0.Instance"), Object)
        grdBOM_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdBOM_DesignTimeLayout_Reference_0})
        resources.ApplyResources(grdBOM_DesignTimeLayout, "grdBOM_DesignTimeLayout")
        Me.grdBOM.DesignTimeLayout = grdBOM_DesignTimeLayout
        Me.grdBOM.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdBOM.FrozenColumns = 2
        Me.grdBOM.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdBOM.GroupByBoxVisible = False
        Me.grdBOM.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdBOM.Name = "grdBOM"
        Me.grdBOM.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdBOM.RecordNavigator = True
        Me.grdBOM.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdBOM.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdBOM.TabStop = False
        Me.grdBOM.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdBOM.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdBOM.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdBOM.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdBOM.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdBOM.VisualStyleManager = Me.vsmMain
        '
        'grpControle
        '
        resources.ApplyResources(Me.grpControle, "grpControle")
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnImprimir)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnImprimir
        '
        resources.ApplyResources(Me.btnImprimir, "btnImprimir")
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        resources.ApplyResources(Me.btnSair, "btnSair")
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpOutros
        '
        resources.ApplyResources(Me.grpOutros, "grpOutros")
        Me.grpOutros.BackColor = System.Drawing.Color.Transparent
        Me.grpOutros.Controls.Add(Me.txtTotalOutros)
        Me.grpOutros.Controls.Add(Me.lblTotalOutros)
        Me.grpOutros.Controls.Add(Me.txtDescontoPercentualMaoObra)
        Me.grpOutros.Controls.Add(Me.txtTotalMaoObra)
        Me.grpOutros.Controls.Add(Me.lblTotalEmbalagem)
        Me.grpOutros.Controls.Add(Me.txtTotalEmbalagem)
        Me.grpOutros.Controls.Add(Me.lblDescontoPercentualMaoObra)
        Me.grpOutros.Controls.Add(Me.lblTotalMaoObra)
        Me.grpOutros.Controls.Add(Me.lblTotalTransporte)
        Me.grpOutros.Controls.Add(Me.txtTotalTransporte)
        Me.grpOutros.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpOutros.Name = "grpOutros"
        Me.grpOutros.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpOutros.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpOutros.VisualStyleManager = Me.vsmMain
        '
        'txtTotalOutros
        '
        Me.txtTotalOutros.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalOutros.DecimalDigits = 2
        resources.ApplyResources(Me.txtTotalOutros, "txtTotalOutros")
        Me.txtTotalOutros.MaxLength = 15
        Me.txtTotalOutros.Name = "txtTotalOutros"
        Me.txtTotalOutros.ReadOnly = True
        Me.txtTotalOutros.TabStop = False
        Me.txtTotalOutros.Value = 0.0R
        Me.txtTotalOutros.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblTotalOutros
        '
        resources.ApplyResources(Me.lblTotalOutros, "lblTotalOutros")
        Me.lblTotalOutros.Name = "lblTotalOutros"
        '
        'txtDescontoPercentualMaoObra
        '
        Me.txtDescontoPercentualMaoObra.DecimalDigits = 5
        resources.ApplyResources(Me.txtDescontoPercentualMaoObra, "txtDescontoPercentualMaoObra")
        Me.txtDescontoPercentualMaoObra.MaxLength = 15
        Me.txtDescontoPercentualMaoObra.Name = "txtDescontoPercentualMaoObra"
        Me.txtDescontoPercentualMaoObra.Value = 0.0R
        Me.txtDescontoPercentualMaoObra.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'txtTotalMaoObra
        '
        resources.ApplyResources(Me.txtTotalMaoObra, "txtTotalMaoObra")
        Me.txtTotalMaoObra.MaxLength = 15
        Me.txtTotalMaoObra.Name = "txtTotalMaoObra"
        Me.txtTotalMaoObra.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTotalEmbalagem
        '
        resources.ApplyResources(Me.lblTotalEmbalagem, "lblTotalEmbalagem")
        Me.lblTotalEmbalagem.Name = "lblTotalEmbalagem"
        '
        'txtTotalEmbalagem
        '
        resources.ApplyResources(Me.txtTotalEmbalagem, "txtTotalEmbalagem")
        Me.txtTotalEmbalagem.MaxLength = 15
        Me.txtTotalEmbalagem.Name = "txtTotalEmbalagem"
        Me.txtTotalEmbalagem.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblDescontoPercentualMaoObra
        '
        resources.ApplyResources(Me.lblDescontoPercentualMaoObra, "lblDescontoPercentualMaoObra")
        Me.lblDescontoPercentualMaoObra.Name = "lblDescontoPercentualMaoObra"
        '
        'lblTotalMaoObra
        '
        resources.ApplyResources(Me.lblTotalMaoObra, "lblTotalMaoObra")
        Me.lblTotalMaoObra.Name = "lblTotalMaoObra"
        '
        'lblTotalTransporte
        '
        resources.ApplyResources(Me.lblTotalTransporte, "lblTotalTransporte")
        Me.lblTotalTransporte.Name = "lblTotalTransporte"
        '
        'txtTotalTransporte
        '
        resources.ApplyResources(Me.txtTotalTransporte, "txtTotalTransporte")
        Me.txtTotalTransporte.MaxLength = 15
        Me.txtTotalTransporte.Name = "txtTotalTransporte"
        Me.txtTotalTransporte.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'UiButton2
        '
        Me.UiButton2.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.UiButton2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.UiButton2, "UiButton2")
        Me.UiButton2.Name = "UiButton2"
        Me.UiButton2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiButton2.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCadastrarItemLote
        '
        resources.ApplyResources(Me.btnCadastrarItemLote, "btnCadastrarItemLote")
        Me.btnCadastrarItemLote.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnCadastrarItemLote.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCadastrarItemLote.Name = "btnCadastrarItemLote"
        Me.btnCadastrarItemLote.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCadastrarItemLote.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrCadProdutoBOM
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrCadProdutoBOM"
        CType(Me.tabMain,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabMain.ResumeLayout(false)
        Me.pagDados.ResumeLayout(false)
        CType(Me.grpProduto,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpProduto.ResumeLayout(false)
        Me.grpProduto.PerformLayout
        CType(Me.grpTotal,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpTotal.ResumeLayout(false)
        Me.grpTotal.PerformLayout
        CType(Me.grpBOM,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpBOM.ResumeLayout(false)
        Me.grpBOM.PerformLayout
        CType(Me.grdBOM,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpControle,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpControle.ResumeLayout(false)
        CType(Me.grpOutros,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpOutros.ResumeLayout(false)
        Me.grpOutros.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiComboBox1 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents UiComboBox2 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grdBOM As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpBOM As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblUnidadeMedida As System.Windows.Forms.Label
    Friend WithEvents cboUnidadeMedida As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarItem As System.Windows.Forms.Button
    Friend WithEvents lblCodigoItem As System.Windows.Forms.Label
    Friend WithEvents cboCodigoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDescricaoItem As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpOutros As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDescontoPercentualMaoObra As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtTotalMaoObra As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalEmbalagem As System.Windows.Forms.Label
    Friend WithEvents txtTotalEmbalagem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDescontoPercentualMaoObra As System.Windows.Forms.Label
    Friend WithEvents txtTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalMaoObra As System.Windows.Forms.Label
    Friend WithEvents lblTotalTransporte As System.Windows.Forms.Label
    Friend WithEvents txtTotalTransporte As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnCadastrarUnidadeMedida As System.Windows.Forms.Button
    Friend WithEvents txtValorUnitarioDesconto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnitarioDesconto As System.Windows.Forms.Label
    Friend WithEvents txtDescontoValor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDescontoValor As System.Windows.Forms.Label
    Friend WithEvents txtDescontoPercentual As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDescontoPercentual As System.Windows.Forms.Label
    Friend WithEvents txtValorTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents txtValorUnitario As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnitario As System.Windows.Forms.Label
    Friend WithEvents btnProcurarItem As System.Windows.Forms.Button
    Friend WithEvents lblTipoItem As System.Windows.Forms.Label
    Friend WithEvents cboTipoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtTotalOutros As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalOutros As System.Windows.Forms.Label
    Friend WithEvents grpTotal As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtTotalDesconto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalDesconto As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpProduto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents cboCodigoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents btnProcurarItemOriginal As System.Windows.Forms.Button
    Friend WithEvents lblCodigoItemOriginal As System.Windows.Forms.Label
    Friend WithEvents cboCodigoItemOriginal As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDescricaoItemOriginal As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoItemOriginal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnAgruparGridBOM As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarItemLote As Janus.Windows.EditControls.UIButton

End Class
