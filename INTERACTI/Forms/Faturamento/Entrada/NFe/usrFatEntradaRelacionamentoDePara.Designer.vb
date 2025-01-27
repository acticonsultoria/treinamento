<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFatEntradaRelacionamentoDePara
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFatEntradaRelacionamentoDePara))
        Dim grdProdutoAcabado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProdutoEmProcesso_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataFinalFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEntradaFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.chkItensValidacaoBlocoH = New Janus.Windows.EditControls.UICheckBox()
        Me.chkItensValidacaoBlocoK = New Janus.Windows.EditControls.UICheckBox()
        Me.grdProdutoAcabado = New Janus.Windows.GridEX.GridEX()
        Me.grdProdutoEmProcesso = New Janus.Windows.GridEX.GridEX()
        Me.btnExcelProdutoAcabado = New System.Windows.Forms.Button()
        Me.btnExcelProdutoEmProcesso = New System.Windows.Forms.Button()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdProdutoAcabado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProdutoEmProcesso, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpControl)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagLista"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Relacionamento De - Para"
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        Me.grdListagem.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "e o Cabeçalho da Coluna aqui para Agrupar</GroupByBoxInfo></LocalizableData>"
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(3, 74)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(907, 410)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnExcel)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(3, 490)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(907, 51)
        Me.grpControl.TabIndex = 93
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(710, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 4
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(807, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.dtpDataFinalFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEntradaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(3, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(907, 65)
        Me.grpFiltro.TabIndex = 90
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'dtpDataFinalFiltro
        '
        Me.dtpDataFinalFiltro.Checked = False
        Me.dtpDataFinalFiltro.CustomFormat = "dd/MM/yyyy"
        Me.dtpDataFinalFiltro.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpDataFinalFiltro.DropDownCalendar.FirstMonth = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.dtpDataFinalFiltro.DropDownCalendar.Name = ""
        Me.dtpDataFinalFiltro.DropDownCalendar.Visible = False
        Me.dtpDataFinalFiltro.Location = New System.Drawing.Point(134, 29)
        Me.dtpDataFinalFiltro.MaxDate = New Date(9998, 12, 1, 0, 0, 0, 0)
        Me.dtpDataFinalFiltro.Name = "dtpDataFinalFiltro"
        Me.dtpDataFinalFiltro.ShowCheckBox = True
        Me.dtpDataFinalFiltro.Size = New System.Drawing.Size(119, 20)
        Me.dtpDataFinalFiltro.TabIndex = 0
        '
        'dtpDataInicioFiltro
        '
        Me.dtpDataInicioFiltro.CustomFormat = "dd/MM/yyyy"
        Me.dtpDataInicioFiltro.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.FirstMonth = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.DropDownCalendar.Visible = False
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(9, 29)
        Me.dtpDataInicioFiltro.MaxDate = New Date(9998, 12, 1, 0, 0, 0, 0)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(119, 20)
        Me.dtpDataInicioFiltro.TabIndex = 5
        '
        'lblDataEntradaFiltro
        '
        Me.lblDataEntradaFiltro.AutoSize = True
        Me.lblDataEntradaFiltro.Location = New System.Drawing.Point(6, 12)
        Me.lblDataEntradaFiltro.Name = "lblDataEntradaFiltro"
        Me.lblDataEntradaFiltro.Size = New System.Drawing.Size(72, 14)
        Me.lblDataEntradaFiltro.TabIndex = 0
        Me.lblDataEntradaFiltro.Text = "Data Entrada:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(807, 29)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 8
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'chkItensValidacaoBlocoH
        '
        Me.chkItensValidacaoBlocoH.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkItensValidacaoBlocoH.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.chkItensValidacaoBlocoH.ForeColor = System.Drawing.Color.Firebrick
        Me.chkItensValidacaoBlocoH.Location = New System.Drawing.Point(7, 355)
        Me.chkItensValidacaoBlocoH.Name = "chkItensValidacaoBlocoH"
        Me.chkItensValidacaoBlocoH.Size = New System.Drawing.Size(72, 16)
        Me.chkItensValidacaoBlocoH.TabIndex = 22
        Me.chkItensValidacaoBlocoH.Text = "Validação "
        '
        'chkItensValidacaoBlocoK
        '
        Me.chkItensValidacaoBlocoK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkItensValidacaoBlocoK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.chkItensValidacaoBlocoK.ForeColor = System.Drawing.Color.Firebrick
        Me.chkItensValidacaoBlocoK.Location = New System.Drawing.Point(7, 355)
        Me.chkItensValidacaoBlocoK.Name = "chkItensValidacaoBlocoK"
        Me.chkItensValidacaoBlocoK.Size = New System.Drawing.Size(72, 16)
        Me.chkItensValidacaoBlocoK.TabIndex = 23
        Me.chkItensValidacaoBlocoK.Text = "Validação "
        '
        'grdProdutoAcabado
        '
        Me.grdProdutoAcabado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdProdutoAcabado.AlternatingColors = True
        Me.grdProdutoAcabado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProdutoAcabado.ColumnAutoResize = True
        grdProdutoAcabado_DesignTimeLayout.LayoutString = resources.GetString("grdProdutoAcabado_DesignTimeLayout.LayoutString")
        Me.grdProdutoAcabado.DesignTimeLayout = grdProdutoAcabado_DesignTimeLayout
        Me.grdProdutoAcabado.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdProdutoAcabado.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdProdutoAcabado.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdProdutoAcabado.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProdutoAcabado.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProdutoAcabado.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProdutoAcabado.GroupByBoxVisible = False
        Me.grdProdutoAcabado.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdProdutoAcabado.Hierarchical = True
        Me.grdProdutoAcabado.Location = New System.Drawing.Point(5, 11)
        Me.grdProdutoAcabado.Name = "grdProdutoAcabado"
        Me.grdProdutoAcabado.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProdutoAcabado.RecordNavigator = True
        Me.grdProdutoAcabado.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdProdutoAcabado.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProdutoAcabado.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProdutoAcabado.Size = New System.Drawing.Size(893, 299)
        Me.grdProdutoAcabado.TabIndex = 3
        Me.grdProdutoAcabado.TabStop = False
        Me.grdProdutoAcabado.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProdutoAcabado.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdProdutoAcabado.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdProdutoAcabado.VisualStyleManager = Me.vsmMain
        '
        'grdProdutoEmProcesso
        '
        Me.grdProdutoEmProcesso.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdProdutoEmProcesso.AlternatingColors = True
        Me.grdProdutoEmProcesso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProdutoEmProcesso.ColumnAutoResize = True
        grdProdutoEmProcesso_DesignTimeLayout.LayoutString = resources.GetString("grdProdutoEmProcesso_DesignTimeLayout.LayoutString")
        Me.grdProdutoEmProcesso.DesignTimeLayout = grdProdutoEmProcesso_DesignTimeLayout
        Me.grdProdutoEmProcesso.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdProdutoEmProcesso.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdProdutoEmProcesso.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdProdutoEmProcesso.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProdutoEmProcesso.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProdutoEmProcesso.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProdutoEmProcesso.GroupByBoxVisible = False
        Me.grdProdutoEmProcesso.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdProdutoEmProcesso.Hierarchical = True
        Me.grdProdutoEmProcesso.Location = New System.Drawing.Point(5, 11)
        Me.grdProdutoEmProcesso.Name = "grdProdutoEmProcesso"
        Me.grdProdutoEmProcesso.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProdutoEmProcesso.RecordNavigator = True
        Me.grdProdutoEmProcesso.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdProdutoEmProcesso.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProdutoEmProcesso.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProdutoEmProcesso.Size = New System.Drawing.Size(893, 299)
        Me.grdProdutoEmProcesso.TabIndex = 4
        Me.grdProdutoEmProcesso.TabStop = False
        Me.grdProdutoEmProcesso.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProdutoEmProcesso.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdProdutoEmProcesso.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdProdutoEmProcesso.VisualStyleManager = Me.vsmMain
        '
        'btnExcelProdutoAcabado
        '
        Me.btnExcelProdutoAcabado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelProdutoAcabado.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelProdutoAcabado.FlatAppearance.BorderSize = 0
        Me.btnExcelProdutoAcabado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelProdutoAcabado.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelProdutoAcabado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcelProdutoAcabado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelProdutoAcabado.Location = New System.Drawing.Point(8, 293)
        Me.btnExcelProdutoAcabado.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelProdutoAcabado.Name = "btnExcelProdutoAcabado"
        Me.btnExcelProdutoAcabado.Size = New System.Drawing.Size(56, 16)
        Me.btnExcelProdutoAcabado.TabIndex = 18
        Me.btnExcelProdutoAcabado.TabStop = False
        Me.btnExcelProdutoAcabado.Tag = "grdProdutoAcabado"
        Me.btnExcelProdutoAcabado.UseVisualStyleBackColor = False
        '
        'btnExcelProdutoEmProcesso
        '
        Me.btnExcelProdutoEmProcesso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelProdutoEmProcesso.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelProdutoEmProcesso.FlatAppearance.BorderSize = 0
        Me.btnExcelProdutoEmProcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelProdutoEmProcesso.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelProdutoEmProcesso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcelProdutoEmProcesso.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelProdutoEmProcesso.Location = New System.Drawing.Point(8, 293)
        Me.btnExcelProdutoEmProcesso.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelProdutoEmProcesso.Name = "btnExcelProdutoEmProcesso"
        Me.btnExcelProdutoEmProcesso.Size = New System.Drawing.Size(56, 16)
        Me.btnExcelProdutoEmProcesso.TabIndex = 19
        Me.btnExcelProdutoEmProcesso.TabStop = False
        Me.btnExcelProdutoEmProcesso.Tag = "grdProdutoEmProcesso"
        Me.btnExcelProdutoEmProcesso.UseVisualStyleBackColor = False
        '
        'usrFatEntradaRelacionamentoDePara
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFatEntradaRelacionamentoDePara"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdProdutoAcabado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProdutoEmProcesso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents chkItensValidacaoBlocoH As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkItensValidacaoBlocoK As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents btnExcelProdutoAcabado As System.Windows.Forms.Button
    Friend WithEvents grdProdutoAcabado As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelProdutoEmProcesso As System.Windows.Forms.Button
    Friend WithEvents grdProdutoEmProcesso As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataFinalFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEntradaFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton

End Class
