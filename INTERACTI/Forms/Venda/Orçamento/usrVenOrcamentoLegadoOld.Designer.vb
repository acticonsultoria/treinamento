<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrVenOrcamentoLegadoOld
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrVenOrcamentoLegadoOld))
        Dim grdItem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdCheckList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCodigoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoFiltro = New System.Windows.Forms.Label()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagItem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdItem = New Janus.Windows.GridEX.GridEX()
        Me.pagChecklist = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdCheckList = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImportarPlanilha = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNatureza = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNatureza = New System.Windows.Forms.Label()
        Me.txtContato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblContato = New System.Windows.Forms.Label()
        Me.txtDocumentoCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDocumentoCliente = New System.Windows.Forms.Label()
        Me.txtOrcamentista = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrcamentista = New System.Windows.Forms.Label()
        Me.txtFolha = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFolha = New System.Windows.Forms.Label()
        Me.txtCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.dtpDataOrcamento = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataOrcamento = New System.Windows.Forms.Label()
        Me.txtNumeroOrcamento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroOrcamento = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagItem.SuspendLayout()
        CType(Me.grdItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagChecklist.SuspendLayout()
        CType(Me.grdCheckList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(915, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 453)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Orçamento Legado"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(33, 373)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 86
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 373)
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
        Me.grdListagem.ColumnAutoResize = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(8, 76)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 314)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtCodigoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtCodigoFiltro
        '
        Me.txtCodigoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtCodigoFiltro.MaxLength = 20
        Me.txtCodigoFiltro.Name = "txtCodigoFiltro"
        Me.txtCodigoFiltro.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigoFiltro.TabIndex = 1
        '
        'lblCodigoFiltro
        '
        Me.lblCodigoFiltro.AutoSize = True
        Me.lblCodigoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigoFiltro.Name = "lblCodigoFiltro"
        Me.lblCodigoFiltro.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigoFiltro.TabIndex = 0
        Me.lblCodigoFiltro.Text = "Código:"
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(135, 34)
        Me.txtDescricaoFiltro.MaxLength = 100
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(636, 20)
        Me.txtDescricaoFiltro.TabIndex = 3
        '
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(132, 17)
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        Me.lblDescricaoFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoFiltro.TabIndex = 2
        Me.lblDescricaoFiltro.Text = "Descrição:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 4
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Location = New System.Drawing.Point(8, 393)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 3
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(603, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 1
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(700, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 2
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Orçamento Legado"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 117)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 270)
        Me.tabDados.TabIndex = 2
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagItem, Me.pagChecklist})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagItem
        '
        Me.pagItem.Controls.Add(Me.grdItem)
        Me.pagItem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagItem.Key = "pagLista"
        Me.pagItem.Location = New System.Drawing.Point(1, 22)
        Me.pagItem.Name = "pagItem"
        Me.pagItem.Size = New System.Drawing.Size(895, 247)
        Me.pagItem.TabStop = True
        Me.pagItem.Text = "Item"
        '
        'grdItem
        '
        Me.grdItem.AlternatingColors = True
        Me.grdItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdItem_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><CellToolTip>TruncatedText</CellToolTip><GroupCondit" & _
    "ion /><RowHeight>20</RowHeight></RootTable></GridEXLayoutData>"
        Me.grdItem.DesignTimeLayout = grdItem_DesignTimeLayout
        Me.grdItem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdItem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdItem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed
        Me.grdItem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdItem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdItem.GroupByBoxVisible = False
        Me.grdItem.Location = New System.Drawing.Point(8, 8)
        Me.grdItem.Name = "grdItem"
        Me.grdItem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdItem.RecordNavigator = True
        Me.grdItem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdItem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdItem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdItem.Size = New System.Drawing.Size(879, 232)
        Me.grdItem.TabIndex = 1
        Me.grdItem.TabStop = False
        Me.grdItem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdItem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdItem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdItem.VisualStyleManager = Me.vsmMain
        '
        'pagChecklist
        '
        Me.pagChecklist.Controls.Add(Me.grdCheckList)
        Me.pagChecklist.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagChecklist.Key = "padDados"
        Me.pagChecklist.Location = New System.Drawing.Point(1, 22)
        Me.pagChecklist.Name = "pagChecklist"
        Me.pagChecklist.Size = New System.Drawing.Size(895, 247)
        Me.pagChecklist.TabStop = True
        Me.pagChecklist.Text = "Checklist"
        '
        'grdCheckList
        '
        Me.grdCheckList.AlternatingColors = True
        Me.grdCheckList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdCheckList_DesignTimeLayout.LayoutString = resources.GetString("grdCheckList_DesignTimeLayout.LayoutString")
        Me.grdCheckList.DesignTimeLayout = grdCheckList_DesignTimeLayout
        Me.grdCheckList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdCheckList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdCheckList.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed
        Me.grdCheckList.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdCheckList.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdCheckList.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdCheckList.GroupByBoxVisible = False
        Me.grdCheckList.Location = New System.Drawing.Point(8, 7)
        Me.grdCheckList.Name = "grdCheckList"
        Me.grdCheckList.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdCheckList.RecordNavigator = True
        Me.grdCheckList.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdCheckList.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdCheckList.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdCheckList.Size = New System.Drawing.Size(879, 232)
        Me.grdCheckList.TabIndex = 2
        Me.grdCheckList.TabStop = False
        Me.grdCheckList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdCheckList.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnImportarPlanilha)
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(8, 393)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(897, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnImportarPlanilha
        '
        Me.btnImportarPlanilha.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnImportarPlanilha.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarPlanilha.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnImportarPlanilha.Location = New System.Drawing.Point(14, 17)
        Me.btnImportarPlanilha.Name = "btnImportarPlanilha"
        Me.btnImportarPlanilha.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportarPlanilha.Size = New System.Drawing.Size(162, 23)
        Me.btnImportarPlanilha.TabIndex = 3
        Me.btnImportarPlanilha.Text = "Importar Planilha"
        Me.btnImportarPlanilha.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(603, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(797, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 2
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(700, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtNatureza)
        Me.grpDados.Controls.Add(Me.lblNatureza)
        Me.grpDados.Controls.Add(Me.txtContato)
        Me.grpDados.Controls.Add(Me.lblContato)
        Me.grpDados.Controls.Add(Me.txtDocumentoCliente)
        Me.grpDados.Controls.Add(Me.lblDocumentoCliente)
        Me.grpDados.Controls.Add(Me.txtOrcamentista)
        Me.grpDados.Controls.Add(Me.lblOrcamentista)
        Me.grpDados.Controls.Add(Me.txtFolha)
        Me.grpDados.Controls.Add(Me.lblFolha)
        Me.grpDados.Controls.Add(Me.txtCliente)
        Me.grpDados.Controls.Add(Me.lblCliente)
        Me.grpDados.Controls.Add(Me.dtpDataOrcamento)
        Me.grpDados.Controls.Add(Me.lblDataOrcamento)
        Me.grpDados.Controls.Add(Me.txtNumeroOrcamento)
        Me.grpDados.Controls.Add(Me.lblNumeroOrcamento)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 108)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtNatureza
        '
        Me.txtNatureza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNatureza.Location = New System.Drawing.Point(615, 76)
        Me.txtNatureza.MaxLength = 20
        Me.txtNatureza.Name = "txtNatureza"
        Me.txtNatureza.Size = New System.Drawing.Size(263, 20)
        Me.txtNatureza.TabIndex = 15
        '
        'lblNatureza
        '
        Me.lblNatureza.AutoSize = True
        Me.lblNatureza.Location = New System.Drawing.Point(612, 59)
        Me.lblNatureza.Name = "lblNatureza"
        Me.lblNatureza.Size = New System.Drawing.Size(54, 14)
        Me.lblNatureza.TabIndex = 14
        Me.lblNatureza.Text = "Natureza:"
        '
        'txtContato
        '
        Me.txtContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContato.Location = New System.Drawing.Point(232, 76)
        Me.txtContato.MaxLength = 20
        Me.txtContato.Name = "txtContato"
        Me.txtContato.Size = New System.Drawing.Size(377, 20)
        Me.txtContato.TabIndex = 13
        '
        'lblContato
        '
        Me.lblContato.AutoSize = True
        Me.lblContato.Location = New System.Drawing.Point(229, 59)
        Me.lblContato.Name = "lblContato"
        Me.lblContato.Size = New System.Drawing.Size(47, 14)
        Me.lblContato.TabIndex = 12
        Me.lblContato.Text = "Contato:"
        '
        'txtDocumentoCliente
        '
        Me.txtDocumentoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDocumentoCliente.Location = New System.Drawing.Point(9, 76)
        Me.txtDocumentoCliente.MaxLength = 20
        Me.txtDocumentoCliente.Name = "txtDocumentoCliente"
        Me.txtDocumentoCliente.Size = New System.Drawing.Size(217, 20)
        Me.txtDocumentoCliente.TabIndex = 11
        '
        'lblDocumentoCliente
        '
        Me.lblDocumentoCliente.AutoSize = True
        Me.lblDocumentoCliente.Location = New System.Drawing.Point(6, 59)
        Me.lblDocumentoCliente.Name = "lblDocumentoCliente"
        Me.lblDocumentoCliente.Size = New System.Drawing.Size(99, 14)
        Me.lblDocumentoCliente.TabIndex = 10
        Me.lblDocumentoCliente.Text = "Documento Cliente:"
        '
        'txtOrcamentista
        '
        Me.txtOrcamentista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrcamentista.Location = New System.Drawing.Point(615, 34)
        Me.txtOrcamentista.MaxLength = 20
        Me.txtOrcamentista.Name = "txtOrcamentista"
        Me.txtOrcamentista.Size = New System.Drawing.Size(263, 20)
        Me.txtOrcamentista.TabIndex = 9
        '
        'lblOrcamentista
        '
        Me.lblOrcamentista.AutoSize = True
        Me.lblOrcamentista.Location = New System.Drawing.Point(612, 17)
        Me.lblOrcamentista.Name = "lblOrcamentista"
        Me.lblOrcamentista.Size = New System.Drawing.Size(74, 14)
        Me.lblOrcamentista.TabIndex = 8
        Me.lblOrcamentista.Text = "Orçamentista:"
        '
        'txtFolha
        '
        Me.txtFolha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolha.Location = New System.Drawing.Point(524, 34)
        Me.txtFolha.MaxLength = 20
        Me.txtFolha.Name = "txtFolha"
        Me.txtFolha.Size = New System.Drawing.Size(85, 20)
        Me.txtFolha.TabIndex = 7
        '
        'lblFolha
        '
        Me.lblFolha.AutoSize = True
        Me.lblFolha.Location = New System.Drawing.Point(521, 17)
        Me.lblFolha.Name = "lblFolha"
        Me.lblFolha.Size = New System.Drawing.Size(36, 14)
        Me.lblFolha.TabIndex = 6
        Me.lblFolha.Text = "Folha:"
        '
        'txtCliente
        '
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(232, 34)
        Me.txtCliente.MaxLength = 20
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(286, 20)
        Me.txtCliente.TabIndex = 5
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(229, 17)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 4
        Me.lblCliente.Text = "Cliente:"
        '
        'dtpDataOrcamento
        '
        '
        '
        '
        Me.dtpDataOrcamento.DropDownCalendar.Name = ""
        Me.dtpDataOrcamento.Location = New System.Drawing.Point(118, 34)
        Me.dtpDataOrcamento.Name = "dtpDataOrcamento"
        Me.dtpDataOrcamento.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataOrcamento.TabIndex = 3
        Me.dtpDataOrcamento.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'lblDataOrcamento
        '
        Me.lblDataOrcamento.AutoSize = True
        Me.lblDataOrcamento.Location = New System.Drawing.Point(115, 17)
        Me.lblDataOrcamento.Name = "lblDataOrcamento"
        Me.lblDataOrcamento.Size = New System.Drawing.Size(88, 14)
        Me.lblDataOrcamento.TabIndex = 2
        Me.lblDataOrcamento.Text = "Data Orçamento:"
        '
        'txtNumeroOrcamento
        '
        Me.txtNumeroOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOrcamento.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroOrcamento.MaxLength = 20
        Me.txtNumeroOrcamento.Name = "txtNumeroOrcamento"
        Me.txtNumeroOrcamento.Size = New System.Drawing.Size(103, 20)
        Me.txtNumeroOrcamento.TabIndex = 1
        '
        'lblNumeroOrcamento
        '
        Me.lblNumeroOrcamento.AutoSize = True
        Me.lblNumeroOrcamento.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroOrcamento.Name = "lblNumeroOrcamento"
        Me.lblNumeroOrcamento.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroOrcamento.TabIndex = 0
        Me.lblNumeroOrcamento.Text = "Nº Orçamento:"
        '
        'usrVenOrcamentoLegado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrVenOrcamentoLegado"
        Me.Size = New System.Drawing.Size(915, 476)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagItem.ResumeLayout(False)
        CType(Me.grdItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagChecklist.ResumeLayout(False)
        CType(Me.grdCheckList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents txtCodigoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroOrcamento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroOrcamento As System.Windows.Forms.Label
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagItem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdItem As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagChecklist As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents dtpDataOrcamento As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataOrcamento As System.Windows.Forms.Label
    Friend WithEvents txtNatureza As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNatureza As System.Windows.Forms.Label
    Friend WithEvents txtContato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblContato As System.Windows.Forms.Label
    Friend WithEvents txtDocumentoCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDocumentoCliente As System.Windows.Forms.Label
    Friend WithEvents txtOrcamentista As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrcamentista As System.Windows.Forms.Label
    Friend WithEvents txtFolha As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFolha As System.Windows.Forms.Label
    Friend WithEvents txtCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents btnImportarPlanilha As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdCheckList As Janus.Windows.GridEX.GridEX

End Class
