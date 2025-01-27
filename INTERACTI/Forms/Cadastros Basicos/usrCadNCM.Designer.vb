<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadNCM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadNCM))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblNCMFiltro = New System.Windows.Forms.Label()
        Me.txtNCMFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpIPI = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorUnidadeIPI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnidadeIPI = New System.Windows.Forms.Label()
        Me.cboTipoCalculoIPI = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoCalculoIPI = New System.Windows.Forms.Label()
        Me.lblAliquotaIPI = New System.Windows.Forms.Label()
        Me.txtAliquotaIPI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.grpCupomFiscal = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboAliquotaICMS = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAliquotaICMS = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarNCM = New System.Windows.Forms.Button()
        Me.txtMensagem = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblMensagem = New System.Windows.Forms.Label()
        Me.lblListaCAMEX = New System.Windows.Forms.Label()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.cboListaCAMEX = New Janus.Windows.EditControls.UIComboBox()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblEXTipi = New System.Windows.Forms.Label()
        Me.txtEXTipi = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNCM = New System.Windows.Forms.Label()
        Me.txtNCM = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpIPI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpIPI.SuspendLayout()
        CType(Me.grpCupomFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCupomFiscal.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(1000, 500)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 477)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "NCM - Nomenclatura Comum do Mercosul"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 397)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 12
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 397)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 11
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 397)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 10
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
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.FrozenColumns = 2
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(8, 76)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 338)
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
        Me.grpFiltro.Controls.Add(Me.lblNCMFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNCMFiltro)
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblNCMFiltro
        '
        Me.lblNCMFiltro.AutoSize = True
        Me.lblNCMFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNCMFiltro.Name = "lblNCMFiltro"
        Me.lblNCMFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblNCMFiltro.TabIndex = 0
        Me.lblNCMFiltro.Text = "NCM:"
        '
        'txtNCMFiltro
        '
        Me.txtNCMFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNCMFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNCMFiltro.MaxLength = 8
        Me.txtNCMFiltro.Name = "txtNCMFiltro"
        Me.txtNCMFiltro.Size = New System.Drawing.Size(110, 20)
        Me.txtNCMFiltro.TabIndex = 1
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(125, 34)
        Me.txtDescricaoFiltro.MaxLength = 250
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(646, 20)
        Me.txtDescricaoFiltro.TabIndex = 3
        '
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(122, 17)
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
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 31)
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
        Me.grpControl.Controls.Add(Me.lblCongelarColuna)
        Me.grpControl.Controls.Add(Me.cboCongelarColuna)
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Location = New System.Drawing.Point(8, 417)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(982, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 7
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 8
        Me.cboCongelarColuna.TabStop = False
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(688, 17)
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
        Me.btnSair.Location = New System.Drawing.Point(882, 17)
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
        Me.btnExcluir.Location = New System.Drawing.Point(785, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 2
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpIPI)
        Me.pagDados.Controls.Add(Me.grpCupomFiscal)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(998, 477)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "NCM - Nomenclatura Comum do Mercosul"
        '
        'grpIPI
        '
        Me.grpIPI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpIPI.BackColor = System.Drawing.Color.Transparent
        Me.grpIPI.Controls.Add(Me.txtValorUnidadeIPI)
        Me.grpIPI.Controls.Add(Me.lblValorUnidadeIPI)
        Me.grpIPI.Controls.Add(Me.cboTipoCalculoIPI)
        Me.grpIPI.Controls.Add(Me.lblTipoCalculoIPI)
        Me.grpIPI.Controls.Add(Me.lblAliquotaIPI)
        Me.grpIPI.Controls.Add(Me.txtAliquotaIPI)
        Me.grpIPI.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpIPI.Location = New System.Drawing.Point(8, 227)
        Me.grpIPI.Name = "grpIPI"
        Me.grpIPI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpIPI.Size = New System.Drawing.Size(982, 67)
        Me.grpIPI.TabIndex = 1
        Me.grpIPI.Text = "Dados do IPI"
        Me.grpIPI.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpIPI.VisualStyleManager = Me.vsmMain
        '
        'txtValorUnidadeIPI
        '
        Me.txtValorUnidadeIPI.DecimalDigits = 4
        Me.txtValorUnidadeIPI.Enabled = False
        Me.txtValorUnidadeIPI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorUnidadeIPI.Location = New System.Drawing.Point(357, 37)
        Me.txtValorUnidadeIPI.Name = "txtValorUnidadeIPI"
        Me.txtValorUnidadeIPI.Size = New System.Drawing.Size(110, 20)
        Me.txtValorUnidadeIPI.TabIndex = 5
        Me.txtValorUnidadeIPI.Text = "0,0000"
        Me.txtValorUnidadeIPI.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblValorUnidadeIPI
        '
        Me.lblValorUnidadeIPI.AutoSize = True
        Me.lblValorUnidadeIPI.Location = New System.Drawing.Point(354, 20)
        Me.lblValorUnidadeIPI.Name = "lblValorUnidadeIPI"
        Me.lblValorUnidadeIPI.Size = New System.Drawing.Size(98, 14)
        Me.lblValorUnidadeIPI.TabIndex = 4
        Me.lblValorUnidadeIPI.Text = "Valor Unidade (IPI):"
        '
        'cboTipoCalculoIPI
        '
        Me.cboTipoCalculoIPI.AutoSize = False
        Me.cboTipoCalculoIPI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoCalculoIPI.Location = New System.Drawing.Point(9, 37)
        Me.cboTipoCalculoIPI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoCalculoIPI.Name = "cboTipoCalculoIPI"
        Me.cboTipoCalculoIPI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoCalculoIPI.Size = New System.Drawing.Size(226, 20)
        Me.cboTipoCalculoIPI.TabIndex = 1
        '
        'lblTipoCalculoIPI
        '
        Me.lblTipoCalculoIPI.AutoSize = True
        Me.lblTipoCalculoIPI.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoCalculoIPI.Location = New System.Drawing.Point(6, 20)
        Me.lblTipoCalculoIPI.Name = "lblTipoCalculoIPI"
        Me.lblTipoCalculoIPI.Size = New System.Drawing.Size(83, 14)
        Me.lblTipoCalculoIPI.TabIndex = 0
        Me.lblTipoCalculoIPI.Text = "Tipo de Cálculo:"
        '
        'lblAliquotaIPI
        '
        Me.lblAliquotaIPI.AutoSize = True
        Me.lblAliquotaIPI.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAliquotaIPI.Location = New System.Drawing.Point(238, 20)
        Me.lblAliquotaIPI.Name = "lblAliquotaIPI"
        Me.lblAliquotaIPI.Size = New System.Drawing.Size(33, 14)
        Me.lblAliquotaIPI.TabIndex = 2
        Me.lblAliquotaIPI.Text = "% IPI:"
        '
        'txtAliquotaIPI
        '
        Me.txtAliquotaIPI.Location = New System.Drawing.Point(241, 37)
        Me.txtAliquotaIPI.Name = "txtAliquotaIPI"
        Me.txtAliquotaIPI.Size = New System.Drawing.Size(110, 20)
        Me.txtAliquotaIPI.TabIndex = 3
        Me.txtAliquotaIPI.Text = "0,00"
        Me.txtAliquotaIPI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'grpCupomFiscal
        '
        Me.grpCupomFiscal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCupomFiscal.BackColor = System.Drawing.Color.Transparent
        Me.grpCupomFiscal.Controls.Add(Me.cboAliquotaICMS)
        Me.grpCupomFiscal.Controls.Add(Me.lblAliquotaICMS)
        Me.grpCupomFiscal.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpCupomFiscal.Location = New System.Drawing.Point(8, 297)
        Me.grpCupomFiscal.Name = "grpCupomFiscal"
        Me.grpCupomFiscal.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCupomFiscal.Size = New System.Drawing.Size(982, 67)
        Me.grpCupomFiscal.TabIndex = 2
        Me.grpCupomFiscal.Text = "Dados do ICMS - Emissão de Cupom Fiscal"
        Me.grpCupomFiscal.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpCupomFiscal.VisualStyleManager = Me.vsmMain
        '
        'cboAliquotaICMS
        '
        Me.cboAliquotaICMS.AutoSize = False
        Me.cboAliquotaICMS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAliquotaICMS.Location = New System.Drawing.Point(9, 37)
        Me.cboAliquotaICMS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboAliquotaICMS.Name = "cboAliquotaICMS"
        Me.cboAliquotaICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAliquotaICMS.Size = New System.Drawing.Size(226, 20)
        Me.cboAliquotaICMS.TabIndex = 1
        '
        'lblAliquotaICMS
        '
        Me.lblAliquotaICMS.AutoSize = True
        Me.lblAliquotaICMS.Location = New System.Drawing.Point(6, 20)
        Me.lblAliquotaICMS.Name = "lblAliquotaICMS"
        Me.lblAliquotaICMS.Size = New System.Drawing.Size(76, 14)
        Me.lblAliquotaICMS.TabIndex = 0
        Me.lblAliquotaICMS.Text = "Alíquota ICMS:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(8, 417)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(982, 51)
        Me.grpControl2.TabIndex = 3
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(688, 17)
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
        Me.btnVoltar.Location = New System.Drawing.Point(882, 17)
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
        Me.btnSalvar.Location = New System.Drawing.Point(785, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.btnProcurarNCM)
        Me.grpDados.Controls.Add(Me.txtMensagem)
        Me.grpDados.Controls.Add(Me.lblMensagem)
        Me.grpDados.Controls.Add(Me.lblListaCAMEX)
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.cboListaCAMEX)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.lblEXTipi)
        Me.grpDados.Controls.Add(Me.txtEXTipi)
        Me.grpDados.Controls.Add(Me.lblNCM)
        Me.grpDados.Controls.Add(Me.txtNCM)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(982, 221)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarNCM
        '
        Me.btnProcurarNCM.FlatAppearance.BorderSize = 0
        Me.btnProcurarNCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarNCM.Image = CType(resources.GetObject("btnProcurarNCM.Image"), System.Drawing.Image)
        Me.btnProcurarNCM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarNCM.Location = New System.Drawing.Point(102, 16)
        Me.btnProcurarNCM.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarNCM.Name = "btnProcurarNCM"
        Me.btnProcurarNCM.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarNCM.TabIndex = 16
        Me.btnProcurarNCM.TabStop = False
        Me.btnProcurarNCM.UseVisualStyleBackColor = True
        '
        'txtMensagem
        '
        Me.txtMensagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMensagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMensagem.Location = New System.Drawing.Point(9, 114)
        Me.txtMensagem.MaxLength = 700
        Me.txtMensagem.Multiline = True
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensagem.Size = New System.Drawing.Size(964, 97)
        Me.txtMensagem.TabIndex = 15
        '
        'lblMensagem
        '
        Me.lblMensagem.AutoSize = True
        Me.lblMensagem.Location = New System.Drawing.Point(6, 97)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(226, 14)
        Me.lblMensagem.TabIndex = 14
        Me.lblMensagem.Text = "Mensagem - Dados Adicionais da Nota Fiscal:"
        '
        'lblListaCAMEX
        '
        Me.lblListaCAMEX.AutoSize = True
        Me.lblListaCAMEX.Location = New System.Drawing.Point(6, 57)
        Me.lblListaCAMEX.Name = "lblListaCAMEX"
        Me.lblListaCAMEX.Size = New System.Drawing.Size(87, 14)
        Me.lblListaCAMEX.TabIndex = 8
        Me.lblListaCAMEX.Text = "Lista do CAMEX:"
        '
        'lblAtivo
        '
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.Location = New System.Drawing.Point(238, 57)
        Me.lblAtivo.Name = "lblAtivo"
        Me.lblAtivo.Size = New System.Drawing.Size(35, 14)
        Me.lblAtivo.TabIndex = 12
        Me.lblAtivo.Text = "Ativo:"
        '
        'cboListaCAMEX
        '
        Me.cboListaCAMEX.AutoSize = False
        Me.cboListaCAMEX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboListaCAMEX.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboListaCAMEX.Location = New System.Drawing.Point(9, 74)
        Me.cboListaCAMEX.Name = "cboListaCAMEX"
        Me.cboListaCAMEX.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboListaCAMEX.Size = New System.Drawing.Size(110, 20)
        Me.cboListaCAMEX.TabIndex = 9
        '
        'cboAtivo
        '
        Me.cboAtivo.AutoSize = False
        Me.cboAtivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboAtivo.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboAtivo.Location = New System.Drawing.Point(241, 74)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivo.Size = New System.Drawing.Size(90, 20)
        Me.cboAtivo.TabIndex = 13
        '
        'lblEXTipi
        '
        Me.lblEXTipi.AutoSize = True
        Me.lblEXTipi.Location = New System.Drawing.Point(122, 57)
        Me.lblEXTipi.Name = "lblEXTipi"
        Me.lblEXTipi.Size = New System.Drawing.Size(42, 14)
        Me.lblEXTipi.TabIndex = 10
        Me.lblEXTipi.Text = "EX TIPI:"
        '
        'txtEXTipi
        '
        Me.txtEXTipi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEXTipi.Location = New System.Drawing.Point(125, 74)
        Me.txtEXTipi.MaxLength = 3
        Me.txtEXTipi.Name = "txtEXTipi"
        Me.txtEXTipi.Size = New System.Drawing.Size(110, 20)
        Me.txtEXTipi.TabIndex = 11
        '
        'lblNCM
        '
        Me.lblNCM.AutoSize = True
        Me.lblNCM.Location = New System.Drawing.Point(6, 17)
        Me.lblNCM.Name = "lblNCM"
        Me.lblNCM.Size = New System.Drawing.Size(32, 14)
        Me.lblNCM.TabIndex = 0
        Me.lblNCM.Text = "NCM:"
        '
        'txtNCM
        '
        Me.txtNCM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNCM.Location = New System.Drawing.Point(9, 34)
        Me.txtNCM.MaxLength = 8
        Me.txtNCM.Name = "txtNCM"
        Me.txtNCM.Size = New System.Drawing.Size(110, 20)
        Me.txtNCM.TabIndex = 1
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(125, 34)
        Me.txtDescricao.MaxLength = 250
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(848, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(122, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição:"
        '
        'usrCadNCM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadNCM"
        Me.Size = New System.Drawing.Size(1000, 500)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpIPI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpIPI.ResumeLayout(False)
        Me.grpIPI.PerformLayout()
        CType(Me.grpCupomFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCupomFiscal.ResumeLayout(False)
        Me.grpCupomFiscal.PerformLayout()
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
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblNCMFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNCMFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNCM As System.Windows.Forms.Label
    Friend WithEvents txtNCM As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblEXTipi As System.Windows.Forms.Label
    Friend WithEvents txtEXTipi As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtValorUnidadeIPI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnidadeIPI As System.Windows.Forms.Label
    Friend WithEvents cboTipoCalculoIPI As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoCalculoIPI As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaIPI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaIPI As System.Windows.Forms.Label
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpCupomFiscal As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboAliquotaICMS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblAliquotaICMS As System.Windows.Forms.Label
    Friend WithEvents grpIPI As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents lblListaCAMEX As System.Windows.Forms.Label
    Friend WithEvents cboListaCAMEX As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtMensagem As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblMensagem As System.Windows.Forms.Label
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnProcurarNCM As System.Windows.Forms.Button

End Class
