<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrd000000007
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrd000000007))
        Dim grdConsolidado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagDetalhado = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelDados = New System.Windows.Forms.Button()
        Me.btnAgruparGridDados = New System.Windows.Forms.Button()
        Me.btnConfigurarGridDados = New System.Windows.Forms.Button()
        Me.btnConfigurarGridAmostra = New System.Windows.Forms.Button()
        Me.btnExcelGridAmostra = New System.Windows.Forms.Button()
        Me.btnAgruparGridAmostra = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnInserirAmostra = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluirAmostra = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagConsolidado = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelConsolidado = New System.Windows.Forms.Button()
        Me.btnAgruparConsolidado = New System.Windows.Forms.Button()
        Me.btnConfigurarConsolidado = New System.Windows.Forms.Button()
        Me.grdConsolidado = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblDataFiltro = New System.Windows.Forms.Label()
        Me.jstMain = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.btnContext = New Janus.Windows.UI.CommandBars.UIContextMenu()
        Me.cmdManager = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.btnVisualizarHistorico = New Janus.Windows.UI.CommandBars.UICommand("btnVisualizarHistorico")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.btnVisualizarHistorico1 = New Janus.Windows.UI.CommandBars.UICommand("btnVisualizarHistorico")
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagDetalhado.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagConsolidado.SuspendLayout()
        CType(Me.grdConsolidado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.btnContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(913, 453)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpFiltro)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(911, 430)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Relatório de Apontamento - PRD000000007"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 73)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(895, 292)
        Me.tabDados.TabIndex = 3
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDetalhado, Me.pagConsolidado})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagDetalhado
        '
        Me.pagDetalhado.Controls.Add(Me.btnExcelDados)
        Me.pagDetalhado.Controls.Add(Me.btnAgruparGridDados)
        Me.pagDetalhado.Controls.Add(Me.btnConfigurarGridDados)
        Me.pagDetalhado.Controls.Add(Me.btnConfigurarGridAmostra)
        Me.pagDetalhado.Controls.Add(Me.btnExcelGridAmostra)
        Me.pagDetalhado.Controls.Add(Me.btnAgruparGridAmostra)
        Me.pagDetalhado.Controls.Add(Me.Button3)
        Me.pagDetalhado.Controls.Add(Me.btnInserirAmostra)
        Me.pagDetalhado.Controls.Add(Me.btnExcluirAmostra)
        Me.pagDetalhado.Controls.Add(Me.grdListagem)
        Me.pagDetalhado.Key = "pagDetalhado"
        Me.pagDetalhado.Location = New System.Drawing.Point(1, 22)
        Me.pagDetalhado.Name = "pagDetalhado"
        Me.pagDetalhado.Size = New System.Drawing.Size(893, 269)
        Me.pagDetalhado.TabStop = True
        Me.pagDetalhado.Text = "Detalhado"
        '
        'btnExcelDados
        '
        Me.btnExcelDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelDados.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelDados.FlatAppearance.BorderSize = 0
        Me.btnExcelDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelDados.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelDados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelDados.Location = New System.Drawing.Point(56, 247)
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
        Me.btnAgruparGridDados.Location = New System.Drawing.Point(29, 247)
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
        Me.btnConfigurarGridDados.Location = New System.Drawing.Point(6, 247)
        Me.btnConfigurarGridDados.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridDados.Name = "btnConfigurarGridDados"
        Me.btnConfigurarGridDados.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridDados.TabIndex = 30
        Me.btnConfigurarGridDados.TabStop = False
        Me.btnConfigurarGridDados.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridAmostra
        '
        Me.btnConfigurarGridAmostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridAmostra.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridAmostra.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridAmostra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridAmostra.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridAmostra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridAmostra.Location = New System.Drawing.Point(11, 1269)
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
        Me.btnExcelGridAmostra.Location = New System.Drawing.Point(57, 1269)
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
        Me.btnAgruparGridAmostra.Location = New System.Drawing.Point(33, 1269)
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
        Me.Button3.Location = New System.Drawing.Point(11, 1271)
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
        Me.btnInserirAmostra.Location = New System.Drawing.Point(3734, 7)
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
        Me.btnExcluirAmostra.Location = New System.Drawing.Point(3734, 36)
        Me.btnExcluirAmostra.Name = "btnExcluirAmostra"
        Me.btnExcluirAmostra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirAmostra.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirAmostra.TabIndex = 15
        Me.btnExcluirAmostra.Text = "Excluir"
        Me.btnExcluirAmostra.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 1
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Location = New System.Drawing.Point(3, 3)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(882, 261)
        Me.grdListagem.TabIndex = 2
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
        'pagConsolidado
        '
        Me.pagConsolidado.Controls.Add(Me.btnExcelConsolidado)
        Me.pagConsolidado.Controls.Add(Me.btnAgruparConsolidado)
        Me.pagConsolidado.Controls.Add(Me.btnConfigurarConsolidado)
        Me.pagConsolidado.Controls.Add(Me.grdConsolidado)
        Me.pagConsolidado.Key = "pagConsolidado"
        Me.pagConsolidado.Location = New System.Drawing.Point(1, 22)
        Me.pagConsolidado.Name = "pagConsolidado"
        Me.pagConsolidado.Size = New System.Drawing.Size(893, 269)
        Me.pagConsolidado.TabStop = True
        Me.pagConsolidado.Text = "Consolidado"
        '
        'btnExcelConsolidado
        '
        Me.btnExcelConsolidado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelConsolidado.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelConsolidado.FlatAppearance.BorderSize = 0
        Me.btnExcelConsolidado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelConsolidado.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelConsolidado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelConsolidado.Location = New System.Drawing.Point(55, 248)
        Me.btnExcelConsolidado.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelConsolidado.Name = "btnExcelConsolidado"
        Me.btnExcelConsolidado.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelConsolidado.TabIndex = 35
        Me.btnExcelConsolidado.TabStop = False
        Me.btnExcelConsolidado.UseVisualStyleBackColor = False
        '
        'btnAgruparConsolidado
        '
        Me.btnAgruparConsolidado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparConsolidado.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparConsolidado.FlatAppearance.BorderSize = 0
        Me.btnAgruparConsolidado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparConsolidado.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparConsolidado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparConsolidado.Location = New System.Drawing.Point(30, 248)
        Me.btnAgruparConsolidado.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparConsolidado.Name = "btnAgruparConsolidado"
        Me.btnAgruparConsolidado.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparConsolidado.TabIndex = 34
        Me.btnAgruparConsolidado.TabStop = False
        Me.btnAgruparConsolidado.UseVisualStyleBackColor = False
        '
        'btnConfigurarConsolidado
        '
        Me.btnConfigurarConsolidado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarConsolidado.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarConsolidado.FlatAppearance.BorderSize = 0
        Me.btnConfigurarConsolidado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarConsolidado.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarConsolidado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarConsolidado.Location = New System.Drawing.Point(6, 248)
        Me.btnConfigurarConsolidado.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarConsolidado.Name = "btnConfigurarConsolidado"
        Me.btnConfigurarConsolidado.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarConsolidado.TabIndex = 33
        Me.btnConfigurarConsolidado.TabStop = False
        Me.btnConfigurarConsolidado.UseVisualStyleBackColor = False
        '
        'grdConsolidado
        '
        Me.grdConsolidado.AllowChildTableGroups = True
        Me.grdConsolidado.AlternatingColors = True
        Me.grdConsolidado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdConsolidado.AutoEdit = True
        Me.grdConsolidado.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdConsolidado_DesignTimeLayout.LayoutString = resources.GetString("grdConsolidado_DesignTimeLayout.LayoutString")
        Me.grdConsolidado.DesignTimeLayout = grdConsolidado_DesignTimeLayout
        Me.grdConsolidado.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdConsolidado.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdConsolidado.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdConsolidado.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdConsolidado.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdConsolidado.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdConsolidado.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdConsolidado.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdConsolidado.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdConsolidado.GroupByBoxVisible = False
        Me.grdConsolidado.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdConsolidado.Location = New System.Drawing.Point(3, 3)
        Me.grdConsolidado.Name = "grdConsolidado"
        Me.grdConsolidado.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdConsolidado.RecordNavigator = True
        Me.grdConsolidado.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdConsolidado.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdConsolidado.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdConsolidado.Size = New System.Drawing.Size(884, 262)
        Me.grdConsolidado.TabIndex = 3
        Me.grdConsolidado.TabStop = False
        Me.grdConsolidado.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdConsolidado.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdConsolidado.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdConsolidado.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdConsolidado.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdConsolidado.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdConsolidado.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdConsolidado.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdConsolidado.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 371)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(895, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(795, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.dtpDataFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblDataFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(895, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
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
        Me.dtpDataFiltro.Location = New System.Drawing.Point(9, 34)
        Me.dtpDataFiltro.Name = "dtpDataFiltro"
        Me.dtpDataFiltro.Size = New System.Drawing.Size(73, 20)
        Me.dtpDataFiltro.TabIndex = 15
        Me.dtpDataFiltro.Value = New Date(2016, 3, 9, 8, 48, 2, 0)
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(798, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 6
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDataFiltro
        '
        Me.lblDataFiltro.AutoSize = True
        Me.lblDataFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblDataFiltro.Name = "lblDataFiltro"
        Me.lblDataFiltro.Size = New System.Drawing.Size(30, 14)
        Me.lblDataFiltro.TabIndex = 0
        Me.lblDataFiltro.Text = "Mês:"
        '
        'jstMain
        '
        Me.jstMain.AutoPopDelay = 15000
        Me.jstMain.ImageList = Nothing
        Me.jstMain.InitialDelay = 100
        '
        'btnContext
        '
        Me.btnContext.CommandManager = Me.cmdManager
        Me.btnContext.Key = "btnVisualizarHistorico"
        '
        'cmdManager
        '
        Me.cmdManager.BottomRebar = Me.BottomRebar1
        Me.cmdManager.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.btnVisualizarHistorico})
        Me.cmdManager.ContainerControl = Me
        Me.cmdManager.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.btnContext})
        Me.cmdManager.Id = New System.Guid("5b956b7e-52af-4ec5-8050-bf6b6569bebe")
        Me.cmdManager.LeftRebar = Me.LeftRebar1
        Me.cmdManager.RightRebar = Me.RightRebar1
        Me.cmdManager.Tag = Nothing
        Me.cmdManager.TopRebar = Me.TopRebar1
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.cmdManager
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 453)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.Size = New System.Drawing.Size(913, 0)
        '
        'btnVisualizarHistorico
        '
        Me.btnVisualizarHistorico.Key = "btnVisualizarHistorico"
        Me.btnVisualizarHistorico.Name = "btnVisualizarHistorico"
        Me.btnVisualizarHistorico.Text = "Visualizar Histório"
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.cmdManager
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 453)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.cmdManager
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(913, 0)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.Size = New System.Drawing.Size(0, 453)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandManager = Me.cmdManager
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(913, 0)
        '
        'btnVisualizarHistorico1
        '
        Me.btnVisualizarHistorico1.Key = "btnVisualizarHistorico"
        Me.btnVisualizarHistorico1.Name = "btnVisualizarHistorico1"
        '
        'usrPrd000000007
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.TopRebar1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrPrd000000007"
        Me.Size = New System.Drawing.Size(913, 453)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagDetalhado.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagConsolidado.ResumeLayout(False)
        CType(Me.grdConsolidado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.btnContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataFiltro As System.Windows.Forms.Label
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents jstMain As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnContext As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents cmdManager As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents btnVisualizarHistorico As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents btnVisualizarHistorico1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDetalhado As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnExcelDados As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridDados As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridDados As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridAmostra As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridAmostra As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridAmostra As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnInserirAmostra As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluirAmostra As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagConsolidado As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdConsolidado As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelConsolidado As System.Windows.Forms.Button
    Friend WithEvents btnAgruparConsolidado As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarConsolidado As System.Windows.Forms.Button

End Class
