<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadItemGrupoItem
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
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdDestino_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadItemGrupoItem))
        Dim grdOrigem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridDestino = New System.Windows.Forms.Button()
        Me.btnExcelGridOrigem = New System.Windows.Forms.Button()
        Me.btnOrigem = New Janus.Windows.EditControls.UIButton()
        Me.btnDestino = New Janus.Windows.EditControls.UIButton()
        Me.grpDestino = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarItemDestino = New System.Windows.Forms.Button()
        Me.btnCadastrarGrupoItemDestino = New System.Windows.Forms.Button()
        Me.txtItemDestino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblItemDestino = New System.Windows.Forms.Label()
        Me.cboGrupoItemDestino = New Janus.Windows.EditControls.UIComboBox()
        Me.lblGrupoItemDestino = New System.Windows.Forms.Label()
        Me.btnConfigurarGridDestino = New System.Windows.Forms.Button()
        Me.grdDestino = New Janus.Windows.GridEX.GridEX()
        Me.btnConfigurarGridOrigem = New System.Windows.Forms.Button()
        Me.grdOrigem = New Janus.Windows.GridEX.GridEX()
        Me.grpOrigem = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarItemOrigem = New System.Windows.Forms.Button()
        Me.btnCadastrarGrupoItemOrigem = New System.Windows.Forms.Button()
        Me.txtItemOrigem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblItemOrigem = New System.Windows.Forms.Label()
        Me.cboGrupoItemOrigem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblGrupoItemOrigem = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDestino.SuspendLayout()
        CType(Me.grdDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdOrigem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpOrigem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOrigem.SuspendLayout()
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
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnExcelGridDestino)
        Me.pagLista.Controls.Add(Me.btnExcelGridOrigem)
        Me.pagLista.Controls.Add(Me.btnOrigem)
        Me.pagLista.Controls.Add(Me.btnDestino)
        Me.pagLista.Controls.Add(Me.grpDestino)
        Me.pagLista.Controls.Add(Me.btnConfigurarGridDestino)
        Me.pagLista.Controls.Add(Me.grdDestino)
        Me.pagLista.Controls.Add(Me.btnConfigurarGridOrigem)
        Me.pagLista.Controls.Add(Me.grdOrigem)
        Me.pagLista.Controls.Add(Me.grpOrigem)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 453)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Grupo de Produto - Alterar"
        '
        'btnExcelGridDestino
        '
        Me.btnExcelGridDestino.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridDestino.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridDestino.FlatAppearance.BorderSize = 0
        Me.btnExcelGridDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridDestino.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridDestino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridDestino.Location = New System.Drawing.Point(506, 373)
        Me.btnExcelGridDestino.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridDestino.Name = "btnExcelGridDestino"
        Me.btnExcelGridDestino.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridDestino.TabIndex = 7
        Me.btnExcelGridDestino.TabStop = False
        Me.btnExcelGridDestino.UseVisualStyleBackColor = False
        '
        'btnExcelGridOrigem
        '
        Me.btnExcelGridOrigem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridOrigem.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridOrigem.FlatAppearance.BorderSize = 0
        Me.btnExcelGridOrigem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridOrigem.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridOrigem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridOrigem.Location = New System.Drawing.Point(33, 373)
        Me.btnExcelGridOrigem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridOrigem.Name = "btnExcelGridOrigem"
        Me.btnExcelGridOrigem.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridOrigem.TabIndex = 3
        Me.btnExcelGridOrigem.TabStop = False
        Me.btnExcelGridOrigem.UseVisualStyleBackColor = False
        '
        'btnOrigem
        '
        Me.btnOrigem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOrigem.Image = Global.INTERACTI.My.Resources.seta_esquerda
        Me.btnOrigem.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.btnOrigem.Location = New System.Drawing.Point(438, 254)
        Me.btnOrigem.Name = "btnOrigem"
        Me.btnOrigem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnOrigem.Size = New System.Drawing.Size(37, 24)
        Me.btnOrigem.TabIndex = 9
        Me.btnOrigem.TabStop = False
        Me.btnOrigem.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnDestino
        '
        Me.btnDestino.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDestino.Image = Global.INTERACTI.My.Resources.seta_direita
        Me.btnDestino.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.btnDestino.Location = New System.Drawing.Point(438, 224)
        Me.btnDestino.Name = "btnDestino"
        Me.btnDestino.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnDestino.Size = New System.Drawing.Size(37, 24)
        Me.btnDestino.TabIndex = 8
        Me.btnDestino.TabStop = False
        Me.btnDestino.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDestino
        '
        Me.grpDestino.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDestino.BackColor = System.Drawing.Color.Transparent
        Me.grpDestino.Controls.Add(Me.btnProcurarItemDestino)
        Me.grpDestino.Controls.Add(Me.btnCadastrarGrupoItemDestino)
        Me.grpDestino.Controls.Add(Me.txtItemDestino)
        Me.grpDestino.Controls.Add(Me.lblItemDestino)
        Me.grpDestino.Controls.Add(Me.cboGrupoItemDestino)
        Me.grpDestino.Controls.Add(Me.lblGrupoItemDestino)
        Me.grpDestino.Location = New System.Drawing.Point(481, 3)
        Me.grpDestino.Name = "grpDestino"
        Me.grpDestino.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDestino.Size = New System.Drawing.Size(424, 104)
        Me.grpDestino.TabIndex = 4
        Me.grpDestino.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarItemDestino
        '
        Me.btnProcurarItemDestino.FlatAppearance.BorderSize = 0
        Me.btnProcurarItemDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItemDestino.Image = Global.INTERACTI.My.Resources.search
        Me.btnProcurarItemDestino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItemDestino.Location = New System.Drawing.Point(398, 56)
        Me.btnProcurarItemDestino.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItemDestino.Name = "btnProcurarItemDestino"
        Me.btnProcurarItemDestino.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItemDestino.TabIndex = 5
        Me.btnProcurarItemDestino.TabStop = False
        Me.btnProcurarItemDestino.UseVisualStyleBackColor = True
        '
        'btnCadastrarGrupoItemDestino
        '
        Me.btnCadastrarGrupoItemDestino.FlatAppearance.BorderSize = 0
        Me.btnCadastrarGrupoItemDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarGrupoItemDestino.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarGrupoItemDestino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarGrupoItemDestino.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarGrupoItemDestino.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarGrupoItemDestino.Name = "btnCadastrarGrupoItemDestino"
        Me.btnCadastrarGrupoItemDestino.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarGrupoItemDestino.TabIndex = 0
        Me.btnCadastrarGrupoItemDestino.TabStop = False
        Me.btnCadastrarGrupoItemDestino.UseVisualStyleBackColor = True
        '
        'txtItemDestino
        '
        Me.txtItemDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemDestino.Location = New System.Drawing.Point(9, 74)
        Me.txtItemDestino.MaxLength = 120
        Me.txtItemDestino.Name = "txtItemDestino"
        Me.txtItemDestino.Size = New System.Drawing.Size(406, 20)
        Me.txtItemDestino.TabIndex = 4
        '
        'lblItemDestino
        '
        Me.lblItemDestino.AutoSize = True
        Me.lblItemDestino.Location = New System.Drawing.Point(6, 57)
        Me.lblItemDestino.Name = "lblItemDestino"
        Me.lblItemDestino.Size = New System.Drawing.Size(29, 14)
        Me.lblItemDestino.TabIndex = 3
        Me.lblItemDestino.Text = "Item:"
        '
        'cboGrupoItemDestino
        '
        Me.cboGrupoItemDestino.AutoSize = False
        Me.cboGrupoItemDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboGrupoItemDestino.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboGrupoItemDestino.Location = New System.Drawing.Point(9, 34)
        Me.cboGrupoItemDestino.Name = "cboGrupoItemDestino"
        Me.cboGrupoItemDestino.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItemDestino.Size = New System.Drawing.Size(406, 20)
        Me.cboGrupoItemDestino.TabIndex = 2
        '
        'lblGrupoItemDestino
        '
        Me.lblGrupoItemDestino.AutoSize = True
        Me.lblGrupoItemDestino.Location = New System.Drawing.Point(25, 17)
        Me.lblGrupoItemDestino.Name = "lblGrupoItemDestino"
        Me.lblGrupoItemDestino.Size = New System.Drawing.Size(77, 14)
        Me.lblGrupoItemDestino.TabIndex = 1
        Me.lblGrupoItemDestino.Text = "Grupo de Item:"
        '
        'btnConfigurarGridDestino
        '
        Me.btnConfigurarGridDestino.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridDestino.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridDestino.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridDestino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridDestino.Location = New System.Drawing.Point(482, 373)
        Me.btnConfigurarGridDestino.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridDestino.Name = "btnConfigurarGridDestino"
        Me.btnConfigurarGridDestino.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridDestino.TabIndex = 6
        Me.btnConfigurarGridDestino.TabStop = False
        Me.btnConfigurarGridDestino.UseVisualStyleBackColor = False
        '
        'grdDestino
        '
        Me.grdDestino.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdDestino.AlternatingColors = True
        Me.grdDestino.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdDestino_DesignTimeLayout.LayoutString = resources.GetString("grdDestino_DesignTimeLayout.LayoutString")
        Me.grdDestino.DesignTimeLayout = grdDestino_DesignTimeLayout
        Me.grdDestino.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdDestino.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdDestino.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdDestino.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdDestino.FrozenColumns = 3
        Me.grdDestino.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdDestino.GroupByBoxVisible = False
        Me.grdDestino.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdDestino.Location = New System.Drawing.Point(481, 116)
        Me.grdDestino.Name = "grdDestino"
        Me.grdDestino.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdDestino.RecordNavigator = True
        Me.grdDestino.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdDestino.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdDestino.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdDestino.Size = New System.Drawing.Size(424, 274)
        Me.grdDestino.TabIndex = 5
        Me.grdDestino.TabStop = False
        Me.grdDestino.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdDestino.VisualStyleManager = Me.vsmMain
        '
        'btnConfigurarGridOrigem
        '
        Me.btnConfigurarGridOrigem.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridOrigem.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridOrigem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridOrigem.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridOrigem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridOrigem.Location = New System.Drawing.Point(9, 373)
        Me.btnConfigurarGridOrigem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridOrigem.Name = "btnConfigurarGridOrigem"
        Me.btnConfigurarGridOrigem.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridOrigem.TabIndex = 2
        Me.btnConfigurarGridOrigem.TabStop = False
        Me.btnConfigurarGridOrigem.UseVisualStyleBackColor = False
        '
        'grdOrigem
        '
        Me.grdOrigem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdOrigem.AlternatingColors = True
        Me.grdOrigem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdOrigem_DesignTimeLayout.LayoutString = resources.GetString("grdOrigem_DesignTimeLayout.LayoutString")
        Me.grdOrigem.DesignTimeLayout = grdOrigem_DesignTimeLayout
        Me.grdOrigem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdOrigem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrigem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdOrigem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrigem.FrozenColumns = 3
        Me.grdOrigem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrigem.GroupByBoxVisible = False
        Me.grdOrigem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdOrigem.Location = New System.Drawing.Point(8, 116)
        Me.grdOrigem.Name = "grdOrigem"
        Me.grdOrigem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrigem.RecordNavigator = True
        Me.grdOrigem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdOrigem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOrigem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrigem.Size = New System.Drawing.Size(424, 274)
        Me.grdOrigem.TabIndex = 1
        Me.grdOrigem.TabStop = False
        Me.grdOrigem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrigem.VisualStyleManager = Me.vsmMain
        '
        'grpOrigem
        '
        Me.grpOrigem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOrigem.BackColor = System.Drawing.Color.Transparent
        Me.grpOrigem.Controls.Add(Me.btnProcurarItemOrigem)
        Me.grpOrigem.Controls.Add(Me.btnCadastrarGrupoItemOrigem)
        Me.grpOrigem.Controls.Add(Me.txtItemOrigem)
        Me.grpOrigem.Controls.Add(Me.lblItemOrigem)
        Me.grpOrigem.Controls.Add(Me.cboGrupoItemOrigem)
        Me.grpOrigem.Controls.Add(Me.lblGrupoItemOrigem)
        Me.grpOrigem.Location = New System.Drawing.Point(8, 3)
        Me.grpOrigem.Name = "grpOrigem"
        Me.grpOrigem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpOrigem.Size = New System.Drawing.Size(424, 104)
        Me.grpOrigem.TabIndex = 0
        Me.grpOrigem.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarItemOrigem
        '
        Me.btnProcurarItemOrigem.FlatAppearance.BorderSize = 0
        Me.btnProcurarItemOrigem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItemOrigem.Image = Global.INTERACTI.My.Resources.search
        Me.btnProcurarItemOrigem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItemOrigem.Location = New System.Drawing.Point(398, 56)
        Me.btnProcurarItemOrigem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItemOrigem.Name = "btnProcurarItemOrigem"
        Me.btnProcurarItemOrigem.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItemOrigem.TabIndex = 5
        Me.btnProcurarItemOrigem.TabStop = False
        Me.btnProcurarItemOrigem.UseVisualStyleBackColor = True
        '
        'btnCadastrarGrupoItemOrigem
        '
        Me.btnCadastrarGrupoItemOrigem.FlatAppearance.BorderSize = 0
        Me.btnCadastrarGrupoItemOrigem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarGrupoItemOrigem.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarGrupoItemOrigem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarGrupoItemOrigem.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarGrupoItemOrigem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarGrupoItemOrigem.Name = "btnCadastrarGrupoItemOrigem"
        Me.btnCadastrarGrupoItemOrigem.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarGrupoItemOrigem.TabIndex = 0
        Me.btnCadastrarGrupoItemOrigem.TabStop = False
        Me.btnCadastrarGrupoItemOrigem.UseVisualStyleBackColor = True
        '
        'txtItemOrigem
        '
        Me.txtItemOrigem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemOrigem.Location = New System.Drawing.Point(9, 74)
        Me.txtItemOrigem.MaxLength = 120
        Me.txtItemOrigem.Name = "txtItemOrigem"
        Me.txtItemOrigem.Size = New System.Drawing.Size(406, 20)
        Me.txtItemOrigem.TabIndex = 4
        '
        'lblItemOrigem
        '
        Me.lblItemOrigem.AutoSize = True
        Me.lblItemOrigem.Location = New System.Drawing.Point(6, 57)
        Me.lblItemOrigem.Name = "lblItemOrigem"
        Me.lblItemOrigem.Size = New System.Drawing.Size(29, 14)
        Me.lblItemOrigem.TabIndex = 3
        Me.lblItemOrigem.Text = "Item:"
        '
        'cboGrupoItemOrigem
        '
        Me.cboGrupoItemOrigem.AutoSize = False
        Me.cboGrupoItemOrigem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboGrupoItemOrigem.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboGrupoItemOrigem.Location = New System.Drawing.Point(9, 34)
        Me.cboGrupoItemOrigem.Name = "cboGrupoItemOrigem"
        Me.cboGrupoItemOrigem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItemOrigem.Size = New System.Drawing.Size(406, 20)
        Me.cboGrupoItemOrigem.TabIndex = 2
        '
        'lblGrupoItemOrigem
        '
        Me.lblGrupoItemOrigem.AutoSize = True
        Me.lblGrupoItemOrigem.Location = New System.Drawing.Point(25, 17)
        Me.lblGrupoItemOrigem.Name = "lblGrupoItemOrigem"
        Me.lblGrupoItemOrigem.Size = New System.Drawing.Size(77, 14)
        Me.lblGrupoItemOrigem.TabIndex = 1
        Me.lblGrupoItemOrigem.Text = "Grupo de Item:"
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 393)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 10
        Me.grpControl.VisualStyleManager = Me.vsmMain
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
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrCadItemGrupoItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadItemGrupoItem"
        Me.Size = New System.Drawing.Size(915, 476)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpDestino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDestino.ResumeLayout(False)
        Me.grpDestino.PerformLayout()
        CType(Me.grdDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdOrigem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpOrigem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOrigem.ResumeLayout(False)
        Me.grpOrigem.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpOrigem As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblItemOrigem As System.Windows.Forms.Label
    Friend WithEvents txtItemOrigem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grdOrigem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGridOrigem As System.Windows.Forms.Button
    Friend WithEvents lblGrupoItemOrigem As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItemOrigem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarGrupoItemOrigem As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridDestino As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridOrigem As System.Windows.Forms.Button
    Friend WithEvents btnOrigem As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnDestino As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDestino As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarGrupoItemDestino As System.Windows.Forms.Button
    Friend WithEvents txtItemDestino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblItemDestino As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItemDestino As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblGrupoItemDestino As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGridDestino As System.Windows.Forms.Button
    Friend WithEvents grdDestino As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnProcurarItemDestino As System.Windows.Forms.Button
    Friend WithEvents btnProcurarItemOrigem As System.Windows.Forms.Button

End Class
