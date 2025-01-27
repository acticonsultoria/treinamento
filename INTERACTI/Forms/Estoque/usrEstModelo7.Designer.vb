<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrEstModelo7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrEstModelo7))
        Dim grdSintetico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Series1 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series()
        Dim Title1 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagAnalitico = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagSintetico = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdSintetico = New Janus.Windows.GridEX.GridEX()
        Me.btnConfigurarGridAmostra = New System.Windows.Forms.Button()
        Me.btnExcelGridAmostra = New System.Windows.Forms.Button()
        Me.btnAgruparGridAmostra = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnInserirAmostra = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluirAmostra = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkGerarBlocoK = New Janus.Windows.EditControls.UICheckBox()
        Me.dtpDataReferenciaFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataReferenciaFiltro = New System.Windows.Forms.Label()
        Me.txtCodigoProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoProdutoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.chrDados = New Dundas.Charting.WinControl.Chart()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagAnalitico.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagSintetico.SuspendLayout()
        CType(Me.grdSintetico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.chrDados, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.tabDados)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Estoque - Modelo 7"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 80)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 401)
        Me.tabDados.TabIndex = 6
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagAnalitico, Me.pagSintetico})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagAnalitico
        '
        Me.pagAnalitico.Controls.Add(Me.grdListagem)
        Me.pagAnalitico.Key = "pagAnalitico"
        Me.pagAnalitico.Location = New System.Drawing.Point(1, 22)
        Me.pagAnalitico.Name = "pagAnalitico"
        Me.pagAnalitico.Size = New System.Drawing.Size(895, 378)
        Me.pagAnalitico.TabStop = True
        Me.pagAnalitico.Text = "Analítico"
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "e o Cabeçalho da Coluna aqui para Agrupar</GroupByBoxInfo></LocalizableData>"
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.DynamicFiltering = True
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxInfoFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.grdListagem.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.Location = New System.Drawing.Point(3, 3)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(889, 372)
        Me.grdListagem.TabIndex = 2
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'pagSintetico
        '
        Me.pagSintetico.Controls.Add(Me.grdSintetico)
        Me.pagSintetico.Controls.Add(Me.btnConfigurarGridAmostra)
        Me.pagSintetico.Controls.Add(Me.btnExcelGridAmostra)
        Me.pagSintetico.Controls.Add(Me.btnAgruparGridAmostra)
        Me.pagSintetico.Controls.Add(Me.Button3)
        Me.pagSintetico.Controls.Add(Me.btnInserirAmostra)
        Me.pagSintetico.Controls.Add(Me.btnExcluirAmostra)
        Me.pagSintetico.Key = "pagSintetico"
        Me.pagSintetico.Location = New System.Drawing.Point(1, 22)
        Me.pagSintetico.Name = "pagSintetico"
        Me.pagSintetico.Size = New System.Drawing.Size(895, 378)
        Me.pagSintetico.TabStop = True
        Me.pagSintetico.Text = "Sintético"
        '
        'grdSintetico
        '
        Me.grdSintetico.AlternatingColors = True
        Me.grdSintetico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSintetico.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "e o Cabeçalho da Coluna aqui para Agrupar</GroupByBoxInfo></LocalizableData>"
        grdSintetico_DesignTimeLayout.LayoutString = resources.GetString("grdSintetico_DesignTimeLayout.LayoutString")
        Me.grdSintetico.DesignTimeLayout = grdSintetico_DesignTimeLayout
        Me.grdSintetico.DynamicFiltering = True
        Me.grdSintetico.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdSintetico.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdSintetico.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdSintetico.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdSintetico.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdSintetico.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdSintetico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdSintetico.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdSintetico.GroupByBoxInfoFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.grdSintetico.GroupByBoxVisible = False
        Me.grdSintetico.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdSintetico.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdSintetico.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.White
        Me.grdSintetico.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdSintetico.Location = New System.Drawing.Point(3, 3)
        Me.grdSintetico.Name = "grdSintetico"
        Me.grdSintetico.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdSintetico.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdSintetico.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdSintetico.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdSintetico.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdSintetico.Size = New System.Drawing.Size(889, 372)
        Me.grdSintetico.TabIndex = 26
        Me.grdSintetico.TabStop = False
        Me.grdSintetico.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdSintetico.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdSintetico.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdSintetico.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdSintetico.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdSintetico.VisualStyleManager = Me.vsmMain
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
        Me.btnInserirAmostra.Location = New System.Drawing.Point(3736, 7)
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
        Me.btnExcluirAmostra.Location = New System.Drawing.Point(3736, 36)
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
        Me.grpFiltro.Controls.Add(Me.chkGerarBlocoK)
        Me.grpFiltro.Controls.Add(Me.dtpDataReferenciaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataReferenciaFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCodigoProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 71)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'chkGerarBlocoK
        '
        Me.chkGerarBlocoK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkGerarBlocoK.Location = New System.Drawing.Point(700, 36)
        Me.chkGerarBlocoK.Name = "chkGerarBlocoK"
        Me.chkGerarBlocoK.Size = New System.Drawing.Size(85, 17)
        Me.chkGerarBlocoK.TabIndex = 19
        Me.chkGerarBlocoK.Text = "Gerar Bloco K"
        '
        'dtpDataReferenciaFiltro
        '
        Me.dtpDataReferenciaFiltro.CustomFormat = "MMMM/yyyy"
        Me.dtpDataReferenciaFiltro.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpDataReferenciaFiltro.DropDownCalendar.Name = ""
        Me.dtpDataReferenciaFiltro.Location = New System.Drawing.Point(165, 33)
        Me.dtpDataReferenciaFiltro.Name = "dtpDataReferenciaFiltro"
        Me.dtpDataReferenciaFiltro.Size = New System.Drawing.Size(136, 20)
        Me.dtpDataReferenciaFiltro.TabIndex = 18
        '
        'lblDataReferenciaFiltro
        '
        Me.lblDataReferenciaFiltro.AutoSize = True
        Me.lblDataReferenciaFiltro.Location = New System.Drawing.Point(162, 16)
        Me.lblDataReferenciaFiltro.Name = "lblDataReferenciaFiltro"
        Me.lblDataReferenciaFiltro.Size = New System.Drawing.Size(88, 14)
        Me.lblDataReferenciaFiltro.TabIndex = 17
        Me.lblDataReferenciaFiltro.Text = "Data Referência:"
        '
        'txtCodigoProdutoFiltro
        '
        Me.txtCodigoProdutoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtCodigoProdutoFiltro.MaxLength = 60
        Me.txtCodigoProdutoFiltro.Name = "txtCodigoProdutoFiltro"
        Me.txtCodigoProdutoFiltro.Size = New System.Drawing.Size(150, 20)
        Me.txtCodigoProdutoFiltro.TabIndex = 5
        '
        'lblCodigoProdutoFiltro
        '
        Me.lblCodigoProdutoFiltro.AutoSize = True
        Me.lblCodigoProdutoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProdutoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigoProdutoFiltro.Name = "lblCodigoProdutoFiltro"
        Me.lblCodigoProdutoFiltro.Size = New System.Drawing.Size(98, 14)
        Me.lblCodigoProdutoFiltro.TabIndex = 4
        Me.lblCodigoProdutoFiltro.Text = "Código do Produto:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 34)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 18
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
        Me.grpControle.Size = New System.Drawing.Size(897, 51)
        Me.grpControle.TabIndex = 2
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(700, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 1
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'chrDados
        '
        Me.chrDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chrDados.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrDados.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrDados.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.AxisX.Title = "Data"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.AxisY.Title = "Fator Cambial"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.Name = "Default"
        Me.chrDados.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Default"
        Me.chrDados.Legends.Add(Legend1)
        Me.chrDados.Location = New System.Drawing.Point(9, 178)
        Me.chrDados.Name = "chrDados"
        Me.chrDados.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Series1.ChartType = "Line"
        Series1.CustomAttributes = "LabelStyle=Bottom"
        Series1.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Series1.Name = "Default"
        Series1.ShowLabelAsValue = True
        Series1.SmartLabels.Enabled = True
        Series1.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series1.YValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Me.chrDados.Series.Add(Series1)
        Me.chrDados.Size = New System.Drawing.Size(897, 324)
        Me.chrDados.TabIndex = 4
        Title1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Title1.Name = "Variação Cambial"
        Title1.Text = "Variação Cambial"
        Me.chrDados.Titles.Add(Title1)
        Me.chrDados.UI.Toolbar.Enabled = True
        '
        'usrEstModelo7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.chrDados)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrEstModelo7"
        Me.Size = New System.Drawing.Size(915, 566)
        Me.Tag = "S"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagAnalitico.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagSintetico.ResumeLayout(False)
        CType(Me.grdSintetico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        CType(Me.chrDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtCodigoProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents chrDados As Dundas.Charting.WinControl.Chart
    Friend WithEvents dtpDataReferenciaFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataReferenciaFiltro As System.Windows.Forms.Label
    Friend WithEvents chkGerarBlocoK As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagAnalitico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagSintetico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdSintetico As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGridAmostra As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridAmostra As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridAmostra As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnInserirAmostra As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluirAmostra As Janus.Windows.EditControls.UIButton

End Class
