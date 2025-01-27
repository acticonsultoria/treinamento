<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCmpPedidoReaprovar
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
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCmpPedidoReaprovar))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim cboGrupoItemFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboRequisitanteFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblFolloUpFiltro = New System.Windows.Forms.Label()
        Me.cboFollowUpFitro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumeroCotacaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroCotacaoFiltro = New System.Windows.Forms.Label()
        Me.btnProcurarItemFiltro = New System.Windows.Forms.Button()
        Me.txtItemFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblItemFiltro = New System.Windows.Forms.Label()
        Me.cboGrupoItemFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblGrupoItemFiltro = New System.Windows.Forms.Label()
        Me.txtReferenciaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblReferenciaFiltro = New System.Windows.Forms.Label()
        Me.cboRequisitanteFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.dtpDataPedidoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPedidoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtNumeroPedidoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedidoFiltro = New System.Windows.Forms.Label()
        Me.lblRequisitanteFiltro = New System.Windows.Forms.Label()
        Me.txtFornecedorFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFornecedorFiltro = New System.Windows.Forms.Label()
        Me.lblDataPedidoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
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
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(933, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(931, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Pedido de Compra - Reaprovar"
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
        Me.btnAgruparGrid.TabIndex = 23
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
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2})
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
        Me.grdListagem.Location = New System.Drawing.Point(8, 156)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(915, 324)
        Me.grdListagem.TabIndex = 5
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
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblFolloUpFiltro)
        Me.grpFiltro.Controls.Add(Me.cboFollowUpFitro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroCotacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroCotacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarItemFiltro)
        Me.grpFiltro.Controls.Add(Me.txtItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblItemFiltro)
        Me.grpFiltro.Controls.Add(Me.cboGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.txtReferenciaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblReferenciaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboRequisitanteFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPedidoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPedidoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroPedidoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroPedidoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblRequisitanteFiltro)
        Me.grpFiltro.Controls.Add(Me.txtFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPedidoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(915, 144)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblFolloUpFiltro
        '
        Me.lblFolloUpFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFolloUpFiltro.AutoSize = True
        Me.lblFolloUpFiltro.Location = New System.Drawing.Point(666, 17)
        Me.lblFolloUpFiltro.Name = "lblFolloUpFiltro"
        Me.lblFolloUpFiltro.Size = New System.Drawing.Size(58, 14)
        Me.lblFolloUpFiltro.TabIndex = 7
        Me.lblFolloUpFiltro.Text = "Follow Up:"
        '
        'cboFollowUpFitro
        '
        Me.cboFollowUpFitro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFollowUpFitro.AutoSize = False
        Me.cboFollowUpFitro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFollowUpFitro.Location = New System.Drawing.Point(669, 34)
        Me.cboFollowUpFitro.Name = "cboFollowUpFitro"
        Me.cboFollowUpFitro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFollowUpFitro.Size = New System.Drawing.Size(90, 20)
        Me.cboFollowUpFitro.TabIndex = 8
        '
        'txtNumeroCotacaoFiltro
        '
        Me.txtNumeroCotacaoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroCotacaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroCotacaoFiltro.Location = New System.Drawing.Point(669, 74)
        Me.txtNumeroCotacaoFiltro.MaxLength = 20
        Me.txtNumeroCotacaoFiltro.Name = "txtNumeroCotacaoFiltro"
        Me.txtNumeroCotacaoFiltro.Size = New System.Drawing.Size(90, 20)
        Me.txtNumeroCotacaoFiltro.TabIndex = 16
        '
        'lblNumeroCotacaoFiltro
        '
        Me.lblNumeroCotacaoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroCotacaoFiltro.AutoSize = True
        Me.lblNumeroCotacaoFiltro.Location = New System.Drawing.Point(666, 57)
        Me.lblNumeroCotacaoFiltro.Name = "lblNumeroCotacaoFiltro"
        Me.lblNumeroCotacaoFiltro.Size = New System.Drawing.Size(65, 14)
        Me.lblNumeroCotacaoFiltro.TabIndex = 15
        Me.lblNumeroCotacaoFiltro.Text = "Nº Cotação:"
        '
        'btnProcurarItemFiltro
        '
        Me.btnProcurarItemFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarItemFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarItemFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItemFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarItemFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItemFiltro.Location = New System.Drawing.Point(477, 95)
        Me.btnProcurarItemFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItemFiltro.Name = "btnProcurarItemFiltro"
        Me.btnProcurarItemFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItemFiltro.TabIndex = 19
        Me.btnProcurarItemFiltro.TabStop = False
        Me.btnProcurarItemFiltro.UseVisualStyleBackColor = True
        '
        'txtItemFiltro
        '
        Me.txtItemFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemFiltro.Location = New System.Drawing.Point(9, 114)
        Me.txtItemFiltro.MaxLength = 120
        Me.txtItemFiltro.Name = "txtItemFiltro"
        Me.txtItemFiltro.Size = New System.Drawing.Size(486, 20)
        Me.txtItemFiltro.TabIndex = 18
        '
        'lblItemFiltro
        '
        Me.lblItemFiltro.AutoSize = True
        Me.lblItemFiltro.Location = New System.Drawing.Point(6, 97)
        Me.lblItemFiltro.Name = "lblItemFiltro"
        Me.lblItemFiltro.Size = New System.Drawing.Size(29, 14)
        Me.lblItemFiltro.TabIndex = 17
        Me.lblItemFiltro.Text = "Item:"
        '
        'cboGrupoItemFiltro
        '
        Me.cboGrupoItemFiltro.AllowDrop = True
        Me.cboGrupoItemFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboGrupoItemFiltro.ButtonCancelText = "Cancelar"
        Me.cboGrupoItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboGrupoItemFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboGrupoItemFiltro_DesignTimeLayout.LayoutString")
        Me.cboGrupoItemFiltro.DesignTimeLayout = cboGrupoItemFiltro_DesignTimeLayout
        Me.cboGrupoItemFiltro.Location = New System.Drawing.Point(501, 114)
        Me.cboGrupoItemFiltro.Name = "cboGrupoItemFiltro"
        Me.cboGrupoItemFiltro.SaveSettings = False
        Me.cboGrupoItemFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboGrupoItemFiltro.Size = New System.Drawing.Size(258, 20)
        Me.cboGrupoItemFiltro.TabIndex = 21
        Me.cboGrupoItemFiltro.ValuesDataMember = Nothing
        '
        'lblGrupoItemFiltro
        '
        Me.lblGrupoItemFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGrupoItemFiltro.AutoSize = True
        Me.lblGrupoItemFiltro.Location = New System.Drawing.Point(498, 97)
        Me.lblGrupoItemFiltro.Name = "lblGrupoItemFiltro"
        Me.lblGrupoItemFiltro.Size = New System.Drawing.Size(77, 14)
        Me.lblGrupoItemFiltro.TabIndex = 20
        Me.lblGrupoItemFiltro.Text = "Grupo de Item:"
        '
        'txtReferenciaFiltro
        '
        Me.txtReferenciaFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReferenciaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferenciaFiltro.Location = New System.Drawing.Point(228, 74)
        Me.txtReferenciaFiltro.MaxLength = 500
        Me.txtReferenciaFiltro.Name = "txtReferenciaFiltro"
        Me.txtReferenciaFiltro.Size = New System.Drawing.Size(435, 20)
        Me.txtReferenciaFiltro.TabIndex = 14
        '
        'lblReferenciaFiltro
        '
        Me.lblReferenciaFiltro.AutoSize = True
        Me.lblReferenciaFiltro.Location = New System.Drawing.Point(225, 57)
        Me.lblReferenciaFiltro.Name = "lblReferenciaFiltro"
        Me.lblReferenciaFiltro.Size = New System.Drawing.Size(63, 14)
        Me.lblReferenciaFiltro.TabIndex = 13
        Me.lblReferenciaFiltro.Text = "Referência:"
        '
        'cboRequisitanteFiltro
        '
        Me.cboRequisitanteFiltro.AllowDrop = True
        Me.cboRequisitanteFiltro.ButtonCancelText = "Cancelar"
        Me.cboRequisitanteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboRequisitanteFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboRequisitanteFiltro_DesignTimeLayout.LayoutString")
        Me.cboRequisitanteFiltro.DesignTimeLayout = cboRequisitanteFiltro_DesignTimeLayout
        Me.cboRequisitanteFiltro.Location = New System.Drawing.Point(9, 74)
        Me.cboRequisitanteFiltro.Name = "cboRequisitanteFiltro"
        Me.cboRequisitanteFiltro.SaveSettings = False
        Me.cboRequisitanteFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboRequisitanteFiltro.Size = New System.Drawing.Size(213, 20)
        Me.cboRequisitanteFiltro.TabIndex = 10
        Me.cboRequisitanteFiltro.ValuesDataMember = Nothing
        '
        'dtpDataPedidoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataPedidoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPedidoInicioFiltro.Location = New System.Drawing.Point(114, 34)
        Me.dtpDataPedidoInicioFiltro.Name = "dtpDataPedidoInicioFiltro"
        Me.dtpDataPedidoInicioFiltro.ShowCheckBox = True
        Me.dtpDataPedidoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPedidoInicioFiltro.TabIndex = 3
        '
        'dtpDataPedidoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataPedidoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPedidoTerminoFiltro.Location = New System.Drawing.Point(228, 34)
        Me.dtpDataPedidoTerminoFiltro.Name = "dtpDataPedidoTerminoFiltro"
        Me.dtpDataPedidoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataPedidoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPedidoTerminoFiltro.TabIndex = 4
        '
        'txtNumeroPedidoFiltro
        '
        Me.txtNumeroPedidoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedidoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroPedidoFiltro.MaxLength = 20
        Me.txtNumeroPedidoFiltro.Name = "txtNumeroPedidoFiltro"
        Me.txtNumeroPedidoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.txtNumeroPedidoFiltro.TabIndex = 1
        '
        'lblNumeroPedidoFiltro
        '
        Me.lblNumeroPedidoFiltro.AutoSize = True
        Me.lblNumeroPedidoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroPedidoFiltro.Name = "lblNumeroPedidoFiltro"
        Me.lblNumeroPedidoFiltro.Size = New System.Drawing.Size(57, 14)
        Me.lblNumeroPedidoFiltro.TabIndex = 0
        Me.lblNumeroPedidoFiltro.Text = "Nº Pedido:"
        '
        'lblRequisitanteFiltro
        '
        Me.lblRequisitanteFiltro.AutoSize = True
        Me.lblRequisitanteFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblRequisitanteFiltro.Name = "lblRequisitanteFiltro"
        Me.lblRequisitanteFiltro.Size = New System.Drawing.Size(69, 14)
        Me.lblRequisitanteFiltro.TabIndex = 9
        Me.lblRequisitanteFiltro.Text = "Requisitante:"
        '
        'txtFornecedorFiltro
        '
        Me.txtFornecedorFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFornecedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFornecedorFiltro.Location = New System.Drawing.Point(342, 34)
        Me.txtFornecedorFiltro.MaxLength = 60
        Me.txtFornecedorFiltro.Name = "txtFornecedorFiltro"
        Me.txtFornecedorFiltro.Size = New System.Drawing.Size(321, 20)
        Me.txtFornecedorFiltro.TabIndex = 6
        '
        'lblFornecedorFiltro
        '
        Me.lblFornecedorFiltro.AutoSize = True
        Me.lblFornecedorFiltro.Location = New System.Drawing.Point(339, 17)
        Me.lblFornecedorFiltro.Name = "lblFornecedorFiltro"
        Me.lblFornecedorFiltro.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedorFiltro.TabIndex = 5
        Me.lblFornecedorFiltro.Text = "Fornecedor:"
        '
        'lblDataPedidoFiltro
        '
        Me.lblDataPedidoFiltro.AutoSize = True
        Me.lblDataPedidoFiltro.Location = New System.Drawing.Point(111, 17)
        Me.lblDataPedidoFiltro.Name = "lblDataPedidoFiltro"
        Me.lblDataPedidoFiltro.Size = New System.Drawing.Size(67, 14)
        Me.lblDataPedidoFiltro.TabIndex = 2
        Me.lblDataPedidoFiltro.Text = "Data Pedido:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(815, 111)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 22
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnExcel)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(915, 51)
        Me.grpControle.TabIndex = 3
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(718, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 0
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(815, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 1
        Me.jstTip.BodyWidth = 400
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 1
        Me.jstTip.ShowAlways = True
        '
        'usrCmpPedidoReaprovar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCmpPedidoReaprovar"
        Me.Size = New System.Drawing.Size(933, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblFornecedorFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataPedidoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtFornecedorFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRequisitanteFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPedidoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroPedidoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataPedidoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPedidoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboRequisitanteFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents txtReferenciaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblReferenciaFiltro As System.Windows.Forms.Label
    Friend WithEvents btnProcurarItemFiltro As System.Windows.Forms.Button
    Friend WithEvents txtItemFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblItemFiltro As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItemFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblGrupoItemFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroCotacaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroCotacaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblFolloUpFiltro As System.Windows.Forms.Label
    Friend WithEvents cboFollowUpFitro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button

End Class
