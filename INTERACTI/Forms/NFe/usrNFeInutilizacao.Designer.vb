<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrNFeInutilizacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrNFeInutilizacao))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtSerieFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerieFiltro = New System.Windows.Forms.Label()
        Me.txtNotaFiscalFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNotaFiscalFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataInicioFiltro = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboAno = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNotaFiscalFinal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtNotaFiscalInicial = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNotaFiscalFinal = New System.Windows.Forms.Label()
        Me.lblNotaFiscalInicial = New System.Windows.Forms.Label()
        Me.cboSerie = New Janus.Windows.EditControls.UIComboBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.cboModelo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.txtJustificativa = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblJustificativa = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnInutilizarNumeracao = New Janus.Windows.EditControls.UIButton()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNCMFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
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
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
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
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControle)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 453)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Lista de Numeração Inutilizada"
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 373)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 3
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
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
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        Me.grdListagem.ColumnAutoResize = True
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
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Location = New System.Drawing.Point(8, 76)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 314)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
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
        Me.grpFiltro.Controls.Add(Me.txtSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.lblSerieFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataInicioFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtSerieFiltro
        '
        Me.txtSerieFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieFiltro.Location = New System.Drawing.Point(119, 34)
        Me.txtSerieFiltro.MaxLength = 3
        Me.txtSerieFiltro.Name = "txtSerieFiltro"
        Me.txtSerieFiltro.Size = New System.Drawing.Size(60, 20)
        Me.txtSerieFiltro.TabIndex = 3
        '
        'lblSerieFiltro
        '
        Me.lblSerieFiltro.AutoSize = True
        Me.lblSerieFiltro.Location = New System.Drawing.Point(116, 17)
        Me.lblSerieFiltro.Name = "lblSerieFiltro"
        Me.lblSerieFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblSerieFiltro.TabIndex = 2
        Me.lblSerieFiltro.Text = "Série:"
        '
        'txtNotaFiscalFiltro
        '
        Me.txtNotaFiscalFiltro.IncludeLiterals = False
        Me.txtNotaFiscalFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNotaFiscalFiltro.MaxLength = 9
        Me.txtNotaFiscalFiltro.Name = "txtNotaFiscalFiltro"
        Me.txtNotaFiscalFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNotaFiscalFiltro.Size = New System.Drawing.Size(104, 20)
        Me.txtNotaFiscalFiltro.TabIndex = 1
        '
        'lblNotaFiscalFiltro
        '
        Me.lblNotaFiscalFiltro.AutoSize = True
        Me.lblNotaFiscalFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNotaFiscalFiltro.Name = "lblNotaFiscalFiltro"
        Me.lblNotaFiscalFiltro.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscalFiltro.TabIndex = 0
        Me.lblNotaFiscalFiltro.Text = "Nota Fiscal:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 7
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(299, 34)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 6
        Me.dtpDataTerminoFiltro.Value = New Date(2012, 9, 6, 0, 0, 0, 0)
        '
        'dtpDataInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(185, 34)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInicioFiltro.TabIndex = 5
        Me.dtpDataInicioFiltro.Value = New Date(2012, 9, 6, 0, 0, 0, 0)
        '
        'lblDataInicioFiltro
        '
        Me.lblDataInicioFiltro.AutoSize = True
        Me.lblDataInicioFiltro.Location = New System.Drawing.Point(182, 17)
        Me.lblDataInicioFiltro.Name = "lblDataInicioFiltro"
        Me.lblDataInicioFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDataInicioFiltro.TabIndex = 4
        Me.lblDataInicioFiltro.Text = "Data Início:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnVisualizarImpressao)
        Me.grpControle.Controls.Add(Me.btnNovo1)
        Me.grpControle.Controls.Add(Me.lblCongelarColuna)
        Me.grpControle.Controls.Add(Me.cboCongelarColuna)
        Me.grpControle.Controls.Add(Me.btnExcel)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 393)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(897, 51)
        Me.grpControle.TabIndex = 4
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnVisualizarImpressao
        '
        Me.btnVisualizarImpressao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarImpressao.Image = Global.INTERACTI.My.Resources.imprimir
        Me.btnVisualizarImpressao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarImpressao.Location = New System.Drawing.Point(494, 17)
        Me.btnVisualizarImpressao.Name = "btnVisualizarImpressao"
        Me.btnVisualizarImpressao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarImpressao.Size = New System.Drawing.Size(200, 23)
        Me.btnVisualizarImpressao.TabIndex = 3
        Me.btnVisualizarImpressao.Text = "Visualizar Impressão"
        Me.btnVisualizarImpressao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(700, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 4
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 0
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 1
        Me.cboCongelarColuna.TabStop = False
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(397, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 2
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 5
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Inutilização de Numeração da NF-e"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.cboAno)
        Me.grpDados.Controls.Add(Me.txtNotaFiscalFinal)
        Me.grpDados.Controls.Add(Me.txtNotaFiscalInicial)
        Me.grpDados.Controls.Add(Me.lblNotaFiscalFinal)
        Me.grpDados.Controls.Add(Me.lblNotaFiscalInicial)
        Me.grpDados.Controls.Add(Me.cboSerie)
        Me.grpDados.Controls.Add(Me.lblModelo)
        Me.grpDados.Controls.Add(Me.cboModelo)
        Me.grpDados.Controls.Add(Me.lblSerie)
        Me.grpDados.Controls.Add(Me.lblAno)
        Me.grpDados.Controls.Add(Me.txtJustificativa)
        Me.grpDados.Controls.Add(Me.lblJustificativa)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 387)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'cboAno
        '
        Me.cboAno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAno.Location = New System.Drawing.Point(9, 34)
        Me.cboAno.Name = "cboAno"
        Me.cboAno.Size = New System.Drawing.Size(76, 20)
        Me.cboAno.TabIndex = 1
        '
        'txtNotaFiscalFinal
        '
        Me.txtNotaFiscalFinal.DecimalDigits = 0
        Me.txtNotaFiscalFinal.Location = New System.Drawing.Point(380, 34)
        Me.txtNotaFiscalFinal.MaxLength = 9
        Me.txtNotaFiscalFinal.Name = "txtNotaFiscalFinal"
        Me.txtNotaFiscalFinal.Size = New System.Drawing.Size(122, 20)
        Me.txtNotaFiscalFinal.TabIndex = 9
        Me.txtNotaFiscalFinal.Text = "0"
        Me.txtNotaFiscalFinal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtNotaFiscalFinal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtNotaFiscalInicial
        '
        Me.txtNotaFiscalInicial.DecimalDigits = 0
        Me.txtNotaFiscalInicial.Location = New System.Drawing.Point(252, 34)
        Me.txtNotaFiscalInicial.MaxLength = 9
        Me.txtNotaFiscalInicial.Name = "txtNotaFiscalInicial"
        Me.txtNotaFiscalInicial.Size = New System.Drawing.Size(122, 20)
        Me.txtNotaFiscalInicial.TabIndex = 7
        Me.txtNotaFiscalInicial.Text = "0"
        Me.txtNotaFiscalInicial.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtNotaFiscalInicial.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNotaFiscalFinal
        '
        Me.lblNotaFiscalFinal.AutoSize = True
        Me.lblNotaFiscalFinal.Location = New System.Drawing.Point(377, 17)
        Me.lblNotaFiscalFinal.Name = "lblNotaFiscalFinal"
        Me.lblNotaFiscalFinal.Size = New System.Drawing.Size(73, 14)
        Me.lblNotaFiscalFinal.TabIndex = 8
        Me.lblNotaFiscalFinal.Text = "Nº NF-e Final:"
        '
        'lblNotaFiscalInicial
        '
        Me.lblNotaFiscalInicial.AutoSize = True
        Me.lblNotaFiscalInicial.Location = New System.Drawing.Point(249, 17)
        Me.lblNotaFiscalInicial.Name = "lblNotaFiscalInicial"
        Me.lblNotaFiscalInicial.Size = New System.Drawing.Size(77, 14)
        Me.lblNotaFiscalInicial.TabIndex = 6
        Me.lblNotaFiscalInicial.Text = "Nº NF-e Inicial:"
        '
        'cboSerie
        '
        Me.cboSerie.AutoSize = False
        Me.cboSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSerie.Location = New System.Drawing.Point(194, 34)
        Me.cboSerie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSerie.Name = "cboSerie"
        Me.cboSerie.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSerie.Size = New System.Drawing.Size(52, 20)
        Me.cboSerie.TabIndex = 5
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.BackColor = System.Drawing.Color.Transparent
        Me.lblModelo.Location = New System.Drawing.Point(88, 17)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(44, 14)
        Me.lblModelo.TabIndex = 2
        Me.lblModelo.Text = "Modelo:"
        '
        'cboModelo
        '
        Me.cboModelo.AutoSize = False
        Me.cboModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboModelo.Location = New System.Drawing.Point(91, 34)
        Me.cboModelo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboModelo.Name = "cboModelo"
        Me.cboModelo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboModelo.Size = New System.Drawing.Size(97, 20)
        Me.cboModelo.TabIndex = 3
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(191, 17)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(35, 14)
        Me.lblSerie.TabIndex = 4
        Me.lblSerie.Text = "Série:"
        '
        'lblAno
        '
        Me.lblAno.AutoSize = True
        Me.lblAno.Location = New System.Drawing.Point(6, 17)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(30, 14)
        Me.lblAno.TabIndex = 0
        Me.lblAno.Text = "Ano:"
        '
        'txtJustificativa
        '
        Me.txtJustificativa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJustificativa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJustificativa.Location = New System.Drawing.Point(9, 74)
        Me.txtJustificativa.MaxLength = 255
        Me.txtJustificativa.Multiline = True
        Me.txtJustificativa.Name = "txtJustificativa"
        Me.txtJustificativa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJustificativa.Size = New System.Drawing.Size(879, 304)
        Me.txtJustificativa.TabIndex = 11
        '
        'lblJustificativa
        '
        Me.lblJustificativa.AutoSize = True
        Me.lblJustificativa.Location = New System.Drawing.Point(6, 57)
        Me.lblJustificativa.Name = "lblJustificativa"
        Me.lblJustificativa.Size = New System.Drawing.Size(67, 14)
        Me.lblJustificativa.TabIndex = 10
        Me.lblJustificativa.Text = "Justificativa:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnInutilizarNumeracao)
        Me.grpControl2.Location = New System.Drawing.Point(8, 393)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(897, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(700, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 1
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(797, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 2
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInutilizarNumeracao
        '
        Me.btnInutilizarNumeracao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInutilizarNumeracao.Image = Global.INTERACTI.My.Resources.cancelar
        Me.btnInutilizarNumeracao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInutilizarNumeracao.Location = New System.Drawing.Point(494, 17)
        Me.btnInutilizarNumeracao.Name = "btnInutilizarNumeracao"
        Me.btnInutilizarNumeracao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInutilizarNumeracao.Size = New System.Drawing.Size(200, 23)
        Me.btnInutilizarNumeracao.TabIndex = 0
        Me.btnInutilizarNumeracao.Text = "Inutilizar Numeração da NF-e"
        Me.btnInutilizarNumeracao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(121, 34)
        Me.txtDescricaoFiltro.MaxLength = 250
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(375, 20)
        Me.txtDescricaoFiltro.TabIndex = 3
        '
        'txtNCMFiltro
        '
        Me.txtNCMFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNCMFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNCMFiltro.MaxLength = 15
        Me.txtNCMFiltro.Name = "txtNCMFiltro"
        Me.txtNCMFiltro.Size = New System.Drawing.Size(106, 20)
        Me.txtNCMFiltro.TabIndex = 1
        '
        'usrNFeInutilizacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrNFeInutilizacao"
        Me.Size = New System.Drawing.Size(915, 476)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.grpControle.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnInutilizarNumeracao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNotaFiscalFinal As System.Windows.Forms.Label
    Friend WithEvents lblNotaFiscalInicial As System.Windows.Forms.Label
    Friend WithEvents cboSerie As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents cboModelo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents lblAno As System.Windows.Forms.Label
    Friend WithEvents txtJustificativa As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblJustificativa As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNCMFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNotaFiscalFinal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtNotaFiscalInicial As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents cboAno As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataInicioFiltro As System.Windows.Forms.Label
    Friend WithEvents txtSerieFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerieFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscalFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNotaFiscalFiltro As System.Windows.Forms.Label
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVisualizarImpressao As Janus.Windows.EditControls.UIButton

End Class
