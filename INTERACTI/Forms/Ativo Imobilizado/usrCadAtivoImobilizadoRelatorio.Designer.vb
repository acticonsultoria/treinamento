<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadAtivoImobilizadoRelatorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadAtivoImobilizadoRelatorio))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagDepreciacao = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelDados = New System.Windows.Forms.Button()
        Me.btnAgruparGridDados = New System.Windows.Forms.Button()
        Me.btnConfigurarGridDados = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.btnConfigurarGridAmostra = New System.Windows.Forms.Button()
        Me.btnExcelGridAmostra = New System.Windows.Forms.Button()
        Me.btnAgruparGridAmostra = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnInserirAmostra = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluirAmostra = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFiltro = New System.Windows.Forms.Label()
        Me.cboAtivoImobilizadoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAtivoImobilizadoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagDepreciacao.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.tabDados)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControle)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório - Ativo Imobilizado"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 76)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(982, 401)
        Me.tabDados.TabIndex = 107
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDepreciacao})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagDepreciacao
        '
        Me.pagDepreciacao.Controls.Add(Me.btnExcelDados)
        Me.pagDepreciacao.Controls.Add(Me.btnAgruparGridDados)
        Me.pagDepreciacao.Controls.Add(Me.btnConfigurarGridDados)
        Me.pagDepreciacao.Controls.Add(Me.grdListagem)
        Me.pagDepreciacao.Controls.Add(Me.btnConfigurarGridAmostra)
        Me.pagDepreciacao.Controls.Add(Me.btnExcelGridAmostra)
        Me.pagDepreciacao.Controls.Add(Me.btnAgruparGridAmostra)
        Me.pagDepreciacao.Controls.Add(Me.Button3)
        Me.pagDepreciacao.Controls.Add(Me.btnInserirAmostra)
        Me.pagDepreciacao.Controls.Add(Me.btnExcluirAmostra)
        Me.pagDepreciacao.Key = "pagDepreciacao"
        Me.pagDepreciacao.Location = New System.Drawing.Point(1, 22)
        Me.pagDepreciacao.Name = "pagDepreciacao"
        Me.pagDepreciacao.Size = New System.Drawing.Size(980, 378)
        Me.pagDepreciacao.TabStop = True
        Me.pagDepreciacao.Text = "Depreciação"
        '
        'btnExcelDados
        '
        Me.btnExcelDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelDados.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelDados.FlatAppearance.BorderSize = 0
        Me.btnExcelDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelDados.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelDados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelDados.Location = New System.Drawing.Point(55, 354)
        Me.btnExcelDados.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelDados.Name = "btnExcelDados"
        Me.btnExcelDados.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelDados.TabIndex = 32
        Me.btnExcelDados.TabStop = False
        Me.btnExcelDados.UseVisualStyleBackColor = False
        '
        'btnAgruparGridDados
        '
        Me.btnAgruparGridDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridDados.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridDados.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridDados.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridDados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridDados.Location = New System.Drawing.Point(29, 354)
        Me.btnAgruparGridDados.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridDados.Name = "btnAgruparGridDados"
        Me.btnAgruparGridDados.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridDados.TabIndex = 31
        Me.btnAgruparGridDados.TabStop = False
        Me.btnAgruparGridDados.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridDados
        '
        Me.btnConfigurarGridDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridDados.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridDados.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridDados.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridDados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridDados.Location = New System.Drawing.Point(5, 354)
        Me.btnConfigurarGridDados.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridDados.Name = "btnConfigurarGridDados"
        Me.btnConfigurarGridDados.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridDados.TabIndex = 30
        Me.btnConfigurarGridDados.TabStop = False
        Me.btnConfigurarGridDados.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(3, 3)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(972, 368)
        Me.grdListagem.TabIndex = 105
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
        'btnConfigurarGridAmostra
        '
        Me.btnConfigurarGridAmostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridAmostra.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridAmostra.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridAmostra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridAmostra.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridAmostra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridAmostra.Location = New System.Drawing.Point(11, 1378)
        Me.btnConfigurarGridAmostra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridAmostra.Name = "btnConfigurarGridAmostra"
        Me.btnConfigurarGridAmostra.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridAmostra.TabIndex = 25
        Me.btnConfigurarGridAmostra.TabStop = False
        Me.btnConfigurarGridAmostra.UseVisualStyleBackColor = False
        '
        'btnExcelGridAmostra
        '
        Me.btnExcelGridAmostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridAmostra.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridAmostra.FlatAppearance.BorderSize = 0
        Me.btnExcelGridAmostra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridAmostra.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridAmostra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridAmostra.Location = New System.Drawing.Point(57, 1378)
        Me.btnExcelGridAmostra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridAmostra.Name = "btnExcelGridAmostra"
        Me.btnExcelGridAmostra.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridAmostra.TabIndex = 24
        Me.btnExcelGridAmostra.TabStop = False
        Me.btnExcelGridAmostra.UseVisualStyleBackColor = False
        '
        'btnAgruparGridAmostra
        '
        Me.btnAgruparGridAmostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridAmostra.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridAmostra.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridAmostra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridAmostra.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridAmostra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridAmostra.Location = New System.Drawing.Point(33, 1378)
        Me.btnAgruparGridAmostra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridAmostra.Name = "btnAgruparGridAmostra"
        Me.btnAgruparGridAmostra.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridAmostra.TabIndex = 23
        Me.btnAgruparGridAmostra.TabStop = False
        Me.btnAgruparGridAmostra.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(11, 1380)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 15)
        Me.Button3.TabIndex = 22
        Me.Button3.TabStop = False
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnInserirAmostra
        '
        Me.btnInserirAmostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirAmostra.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirAmostra.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirAmostra.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirAmostra.Location = New System.Drawing.Point(3821, 7)
        Me.btnInserirAmostra.Name = "btnInserirAmostra"
        Me.btnInserirAmostra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirAmostra.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirAmostra.TabIndex = 14
        Me.btnInserirAmostra.Text = "Inserir"
        Me.btnInserirAmostra.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluirAmostra
        '
        Me.btnExcluirAmostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirAmostra.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirAmostra.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirAmostra.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirAmostra.Location = New System.Drawing.Point(3821, 36)
        Me.btnExcluirAmostra.Name = "btnExcluirAmostra"
        Me.btnExcluirAmostra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirAmostra.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirAmostra.TabIndex = 15
        Me.btnExcluirAmostra.Text = "Excluir"
        Me.btnExcluirAmostra.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.dtpDataFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataFiltro)
        Me.grpFiltro.Controls.Add(Me.cboAtivoImobilizadoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblAtivoImobilizadoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 67)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'dtpDataFiltro
        '
        Me.dtpDataFiltro.CustomFormat = "MM/yyyy"
        Me.dtpDataFiltro.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpDataFiltro.DropDownCalendar.Name = ""
        Me.dtpDataFiltro.Location = New System.Drawing.Point(9, 37)
        Me.dtpDataFiltro.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.dtpDataFiltro.Name = "dtpDataFiltro"
        Me.dtpDataFiltro.Size = New System.Drawing.Size(73, 20)
        Me.dtpDataFiltro.TabIndex = 17
        Me.dtpDataFiltro.Value = New Date(2021, 1, 1, 0, 0, 0, 0)
        '
        'lblDataFiltro
        '
        Me.lblDataFiltro.AutoSize = True
        Me.lblDataFiltro.Location = New System.Drawing.Point(6, 19)
        Me.lblDataFiltro.Name = "lblDataFiltro"
        Me.lblDataFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataFiltro.TabIndex = 16
        Me.lblDataFiltro.Text = "Data:"
        '
        'cboAtivoImobilizadoFiltro
        '
        Me.cboAtivoImobilizadoFiltro.AutoSize = False
        Me.cboAtivoImobilizadoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAtivoImobilizadoFiltro.Location = New System.Drawing.Point(88, 37)
        Me.cboAtivoImobilizadoFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboAtivoImobilizadoFiltro.Name = "cboAtivoImobilizadoFiltro"
        Me.cboAtivoImobilizadoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivoImobilizadoFiltro.Size = New System.Drawing.Size(326, 20)
        Me.cboAtivoImobilizadoFiltro.TabIndex = 0
        '
        'lblAtivoImobilizadoFiltro
        '
        Me.lblAtivoImobilizadoFiltro.AutoSize = True
        Me.lblAtivoImobilizadoFiltro.Location = New System.Drawing.Point(85, 19)
        Me.lblAtivoImobilizadoFiltro.Name = "lblAtivoImobilizadoFiltro"
        Me.lblAtivoImobilizadoFiltro.Size = New System.Drawing.Size(90, 14)
        Me.lblAtivoImobilizadoFiltro.TabIndex = 9
        Me.lblAtivoImobilizadoFiltro.Text = "Ativo Imobilizado:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 34)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 3
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(982, 51)
        Me.grpControle.TabIndex = 2
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(882, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrCadAtivoImobilizadoRelatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadAtivoImobilizadoRelatorio"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagDepreciacao.ResumeLayout(False)
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
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboAtivoImobilizadoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblAtivoImobilizadoFiltro As System.Windows.Forms.Label
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDepreciacao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnExcelDados As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridDados As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridDados As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGridAmostra As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridAmostra As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridAmostra As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnInserirAmostra As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluirAmostra As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFiltro As System.Windows.Forms.Label

End Class
