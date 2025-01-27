<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenHistoricoProduto
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
        Dim grdVendas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenHistoricoProduto))
        Dim grdCompras_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabHistorico = New Janus.Windows.UI.Tab.UITab()
        Me.pagHistorico = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCodigoNCM = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoNCM = New System.Windows.Forms.Label()
        Me.txtGrupoItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricao2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao2 = New System.Windows.Forms.Label()
        Me.txtCodigoEAN = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblGrupoItem = New System.Windows.Forms.Label()
        Me.lblCodigoEAN = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGridVenda = New System.Windows.Forms.Button()
        Me.btnConfigurarGridVenda = New System.Windows.Forms.Button()
        Me.grdVendas = New Janus.Windows.GridEX.GridEX()
        Me.pagCompra = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGridCompra = New System.Windows.Forms.Button()
        Me.btnConfigurarGridCompra = New System.Windows.Forms.Button()
        Me.grdCompras = New Janus.Windows.GridEX.GridEX()
        Me.btnExcelGridVendas = New System.Windows.Forms.Button()
        Me.btnExcelGridCompras = New System.Windows.Forms.Button()
        CType(Me.tabHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHistorico.SuspendLayout()
        Me.pagHistorico.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grdVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagCompra.SuspendLayout()
        CType(Me.grdCompras, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'tabHistorico
        '
        Me.tabHistorico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabHistorico.Location = New System.Drawing.Point(7, 7)
        Me.tabHistorico.Name = "tabHistorico"
        Me.tabHistorico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabHistorico.Size = New System.Drawing.Size(899, 524)
        Me.tabHistorico.TabIndex = 1
        Me.tabHistorico.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagHistorico})
        Me.tabHistorico.TabStop = False
        Me.tabHistorico.VisualStyleManager = Me.vsmMain
        '
        'pagHistorico
        '
        Me.pagHistorico.Controls.Add(Me.grpDados)
        Me.pagHistorico.Controls.Add(Me.tabMain)
        Me.pagHistorico.Key = "pagHistorico"
        Me.pagHistorico.Location = New System.Drawing.Point(1, 22)
        Me.pagHistorico.Name = "pagHistorico"
        Me.pagHistorico.Size = New System.Drawing.Size(897, 501)
        Me.pagHistorico.TabStop = True
        Me.pagHistorico.Text = "Histórico do Produto"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtCodigoNCM)
        Me.grpDados.Controls.Add(Me.lblCodigoNCM)
        Me.grpDados.Controls.Add(Me.txtGrupoItem)
        Me.grpDados.Controls.Add(Me.txtCodigo)
        Me.grpDados.Controls.Add(Me.txtDescricao2)
        Me.grpDados.Controls.Add(Me.lblDescricao2)
        Me.grpDados.Controls.Add(Me.txtCodigoEAN)
        Me.grpDados.Controls.Add(Me.lblGrupoItem)
        Me.grpDados.Controls.Add(Me.lblCodigoEAN)
        Me.grpDados.Controls.Add(Me.lblCodigo)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(881, 107)
        Me.grpDados.TabIndex = 6
        Me.grpDados.Text = "Dados do Produto"
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtCodigoNCM
        '
        Me.txtCodigoNCM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigoNCM.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigoNCM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoNCM.Location = New System.Drawing.Point(749, 37)
        Me.txtCodigoNCM.MaxLength = 14
        Me.txtCodigoNCM.Name = "txtCodigoNCM"
        Me.txtCodigoNCM.ReadOnly = True
        Me.txtCodigoNCM.Size = New System.Drawing.Size(123, 20)
        Me.txtCodigoNCM.TabIndex = 15
        Me.txtCodigoNCM.TabStop = False
        '
        'lblCodigoNCM
        '
        Me.lblCodigoNCM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodigoNCM.AutoSize = True
        Me.lblCodigoNCM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoNCM.Location = New System.Drawing.Point(746, 20)
        Me.lblCodigoNCM.Name = "lblCodigoNCM"
        Me.lblCodigoNCM.Size = New System.Drawing.Size(32, 14)
        Me.lblCodigoNCM.TabIndex = 14
        Me.lblCodigoNCM.Text = "NCM:"
        '
        'txtGrupoItem
        '
        Me.txtGrupoItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGrupoItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtGrupoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrupoItem.Location = New System.Drawing.Point(267, 37)
        Me.txtGrupoItem.MaxLength = 120
        Me.txtGrupoItem.Name = "txtGrupoItem"
        Me.txtGrupoItem.ReadOnly = True
        Me.txtGrupoItem.Size = New System.Drawing.Size(476, 20)
        Me.txtGrupoItem.TabIndex = 13
        Me.txtGrupoItem.TabStop = False
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigo.Location = New System.Drawing.Point(9, 37)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(123, 20)
        Me.txtCodigo.TabIndex = 4
        Me.txtCodigo.TabStop = False
        '
        'txtDescricao2
        '
        Me.txtDescricao2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao2.Location = New System.Drawing.Point(9, 77)
        Me.txtDescricao2.MaxLength = 500
        Me.txtDescricao2.Name = "txtDescricao2"
        Me.txtDescricao2.ReadOnly = True
        Me.txtDescricao2.Size = New System.Drawing.Size(863, 20)
        Me.txtDescricao2.TabIndex = 12
        Me.txtDescricao2.TabStop = False
        '
        'lblDescricao2
        '
        Me.lblDescricao2.AutoSize = True
        Me.lblDescricao2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricao2.Location = New System.Drawing.Point(6, 60)
        Me.lblDescricao2.Name = "lblDescricao2"
        Me.lblDescricao2.Size = New System.Drawing.Size(66, 14)
        Me.lblDescricao2.TabIndex = 11
        Me.lblDescricao2.Text = "Descrição ²:"
        '
        'txtCodigoEAN
        '
        Me.txtCodigoEAN.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigoEAN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoEAN.Location = New System.Drawing.Point(138, 37)
        Me.txtCodigoEAN.MaxLength = 14
        Me.txtCodigoEAN.Name = "txtCodigoEAN"
        Me.txtCodigoEAN.ReadOnly = True
        Me.txtCodigoEAN.Size = New System.Drawing.Size(123, 20)
        Me.txtCodigoEAN.TabIndex = 6
        Me.txtCodigoEAN.TabStop = False
        '
        'lblGrupoItem
        '
        Me.lblGrupoItem.AutoSize = True
        Me.lblGrupoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGrupoItem.Location = New System.Drawing.Point(264, 20)
        Me.lblGrupoItem.Name = "lblGrupoItem"
        Me.lblGrupoItem.Size = New System.Drawing.Size(69, 14)
        Me.lblGrupoItem.TabIndex = 1
        Me.lblGrupoItem.Text = "Grupo - Item:"
        '
        'lblCodigoEAN
        '
        Me.lblCodigoEAN.AutoSize = True
        Me.lblCodigoEAN.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoEAN.Location = New System.Drawing.Point(135, 20)
        Me.lblCodigoEAN.Name = "lblCodigoEAN"
        Me.lblCodigoEAN.Size = New System.Drawing.Size(67, 14)
        Me.lblCodigoEAN.TabIndex = 5
        Me.lblCodigoEAN.Text = "Código EAN:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigo.Location = New System.Drawing.Point(6, 20)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigo.TabIndex = 3
        Me.lblCodigo.Text = "Código:"
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Location = New System.Drawing.Point(8, 116)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(881, 377)
        Me.tabMain.TabIndex = 1
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela, Me.pagCompra})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.btnExcelGridVendas)
        Me.pagTabela.Controls.Add(Me.btnAgruparGridVenda)
        Me.pagTabela.Controls.Add(Me.btnConfigurarGridVenda)
        Me.pagTabela.Controls.Add(Me.grdVendas)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(879, 354)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Vendas"
        '
        'btnAgruparGridVenda
        '
        Me.btnAgruparGridVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridVenda.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridVenda.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridVenda.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridVenda.Location = New System.Drawing.Point(33, 329)
        Me.btnAgruparGridVenda.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridVenda.Name = "btnAgruparGridVenda"
        Me.btnAgruparGridVenda.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridVenda.TabIndex = 5
        Me.btnAgruparGridVenda.TabStop = False
        Me.btnAgruparGridVenda.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridVenda
        '
        Me.btnConfigurarGridVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridVenda.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridVenda.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridVenda.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridVenda.Location = New System.Drawing.Point(9, 329)
        Me.btnConfigurarGridVenda.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridVenda.Name = "btnConfigurarGridVenda"
        Me.btnConfigurarGridVenda.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridVenda.TabIndex = 4
        Me.btnConfigurarGridVenda.TabStop = False
        Me.btnConfigurarGridVenda.UseVisualStyleBackColor = False
        '
        'grdVendas
        '
        Me.grdVendas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdVendas.AlternatingColors = True
        Me.grdVendas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdVendas.AutoEdit = True
        Me.grdVendas.ColumnAutoResize = True
        Me.grdVendas.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdVendas_DesignTimeLayout.LayoutString = resources.GetString("grdVendas_DesignTimeLayout.LayoutString")
        Me.grdVendas.DesignTimeLayout = grdVendas_DesignTimeLayout
        Me.grdVendas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grdVendas.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdVendas.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdVendas.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdVendas.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdVendas.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdVendas.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdVendas.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdVendas.GroupByBoxVisible = False
        Me.grdVendas.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdVendas.Location = New System.Drawing.Point(8, 8)
        Me.grdVendas.Name = "grdVendas"
        Me.grdVendas.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdVendas.RecordNavigator = True
        Me.grdVendas.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdVendas.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdVendas.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdVendas.SelectedFormatStyle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grdVendas.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdVendas.Size = New System.Drawing.Size(863, 338)
        Me.grdVendas.TabIndex = 2
        Me.grdVendas.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdVendas.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdVendas.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdVendas.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdVendas.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdVendas.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdVendas.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdVendas.VisualStyleManager = Me.vsmMain
        '
        'pagCompra
        '
        Me.pagCompra.Controls.Add(Me.btnExcelGridCompras)
        Me.pagCompra.Controls.Add(Me.btnAgruparGridCompra)
        Me.pagCompra.Controls.Add(Me.btnConfigurarGridCompra)
        Me.pagCompra.Controls.Add(Me.grdCompras)
        Me.pagCompra.Key = "pagCompra"
        Me.pagCompra.Location = New System.Drawing.Point(1, 22)
        Me.pagCompra.Name = "pagCompra"
        Me.pagCompra.Size = New System.Drawing.Size(879, 354)
        Me.pagCompra.TabStop = True
        Me.pagCompra.Text = "Compras"
        '
        'btnAgruparGridCompra
        '
        Me.btnAgruparGridCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridCompra.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridCompra.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridCompra.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridCompra.Location = New System.Drawing.Point(33, 329)
        Me.btnAgruparGridCompra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridCompra.Name = "btnAgruparGridCompra"
        Me.btnAgruparGridCompra.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridCompra.TabIndex = 5
        Me.btnAgruparGridCompra.TabStop = False
        Me.btnAgruparGridCompra.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridCompra
        '
        Me.btnConfigurarGridCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridCompra.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridCompra.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridCompra.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridCompra.Location = New System.Drawing.Point(9, 329)
        Me.btnConfigurarGridCompra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridCompra.Name = "btnConfigurarGridCompra"
        Me.btnConfigurarGridCompra.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridCompra.TabIndex = 4
        Me.btnConfigurarGridCompra.TabStop = False
        Me.btnConfigurarGridCompra.UseVisualStyleBackColor = False
        '
        'grdCompras
        '
        Me.grdCompras.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdCompras.AlternatingColors = True
        Me.grdCompras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCompras.AutoEdit = True
        Me.grdCompras.ColumnAutoResize = True
        Me.grdCompras.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdCompras_DesignTimeLayout.LayoutString = resources.GetString("grdCompras_DesignTimeLayout.LayoutString")
        Me.grdCompras.DesignTimeLayout = grdCompras_DesignTimeLayout
        Me.grdCompras.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grdCompras.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdCompras.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdCompras.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdCompras.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdCompras.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdCompras.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdCompras.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdCompras.GroupByBoxVisible = False
        Me.grdCompras.Location = New System.Drawing.Point(8, 8)
        Me.grdCompras.Name = "grdCompras"
        Me.grdCompras.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdCompras.RecordNavigator = True
        Me.grdCompras.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdCompras.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdCompras.SelectedFormatStyle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grdCompras.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdCompras.Size = New System.Drawing.Size(863, 338)
        Me.grdCompras.TabIndex = 3
        Me.grdCompras.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdCompras.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdCompras.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdCompras.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdCompras.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdCompras.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdCompras.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdCompras.VisualStyleManager = Me.vsmMain
        '
        'btnExcelGridVendas
        '
        Me.btnExcelGridVendas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridVendas.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridVendas.FlatAppearance.BorderSize = 0
        Me.btnExcelGridVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridVendas.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridVendas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridVendas.Location = New System.Drawing.Point(57, 329)
        Me.btnExcelGridVendas.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridVendas.Name = "btnExcelGridVendas"
        Me.btnExcelGridVendas.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridVendas.TabIndex = 93
        Me.btnExcelGridVendas.TabStop = False
        Me.btnExcelGridVendas.UseVisualStyleBackColor = False
        '
        'btnExcelGridCompras
        '
        Me.btnExcelGridCompras.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridCompras.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridCompras.FlatAppearance.BorderSize = 0
        Me.btnExcelGridCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridCompras.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridCompras.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridCompras.Location = New System.Drawing.Point(57, 329)
        Me.btnExcelGridCompras.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridCompras.Name = "btnExcelGridCompras"
        Me.btnExcelGridCompras.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridCompras.TabIndex = 93
        Me.btnExcelGridCompras.TabStop = False
        Me.btnExcelGridCompras.UseVisualStyleBackColor = False
        '
        'frmVenHistoricoProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 538)
        Me.Controls.Add(Me.tabHistorico)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVenHistoricoProduto"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Produto: "
        CType(Me.tabHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHistorico.ResumeLayout(False)
        Me.pagHistorico.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grdVendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagCompra.ResumeLayout(False)
        CType(Me.grdCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabHistorico As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagHistorico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtCodigoNCM As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoNCM As System.Windows.Forms.Label
    Friend WithEvents txtGrupoItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDescricao2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoEAN As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblGrupoItem As System.Windows.Forms.Label
    Friend WithEvents lblCodigoEAN As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdVendas As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagCompra As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdCompras As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnAgruparGridCompra As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridCompra As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridVenda As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridVenda As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridVendas As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridCompras As System.Windows.Forms.Button
End Class
