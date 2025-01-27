<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadCFOP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadCFOP))
        Dim grdTipoOperacaoNotaFiscal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdDepositoQualidade_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdDeposito_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCFOPFiltro = New System.Windows.Forms.Label()
        Me.txtCFOPFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNaturezaOperacaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNaturezaOperacaoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridTipoOperacaoNotaFiscal = New System.Windows.Forms.Button()
        Me.btnExcelGridDeposito = New System.Windows.Forms.Button()
        Me.btnExcelGridDepositoQualidade = New System.Windows.Forms.Button()
        Me.btnConfigurarGridDepositoQualidade = New System.Windows.Forms.Button()
        Me.btnConfigurarGridDeposito = New System.Windows.Forms.Button()
        Me.btnConfigurarGridTipoOperacaoNotaFiscal = New System.Windows.Forms.Button()
        Me.grdTipoOperacaoNotaFiscal = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtMensagem = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblMensagem = New System.Windows.Forms.Label()
        Me.lblGeraFinanceiro = New System.Windows.Forms.Label()
        Me.cboGeraFinanceiro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoMovimentacaoEstoque = New System.Windows.Forms.Label()
        Me.cboTipoMovimentacaoEstoque = New Janus.Windows.EditControls.UIComboBox()
        Me.txtAplicacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblAplicacao = New System.Windows.Forms.Label()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.lblCFOP = New System.Windows.Forms.Label()
        Me.txtCFOP = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNaturezaOperacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNaturezaOperacao = New System.Windows.Forms.Label()
        Me.grdDepositoQualidade = New Janus.Windows.GridEX.GridEX()
        Me.grdDeposito = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grdTipoOperacaoNotaFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grdDepositoQualidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
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
        Me.pagLista.Size = New System.Drawing.Size(913, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "CFOP"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 73
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 72
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
        Me.btnConfigurarGrid.TabIndex = 71
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
        Me.grdListagem.Size = New System.Drawing.Size(897, 404)
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
        Me.grpFiltro.Controls.Add(Me.lblCFOPFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCFOPFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNaturezaOperacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNaturezaOperacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblCFOPFiltro
        '
        Me.lblCFOPFiltro.AutoSize = True
        Me.lblCFOPFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblCFOPFiltro.Name = "lblCFOPFiltro"
        Me.lblCFOPFiltro.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOPFiltro.TabIndex = 0
        Me.lblCFOPFiltro.Text = "CFOP:"
        '
        'txtCFOPFiltro
        '
        Me.txtCFOPFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCFOPFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtCFOPFiltro.MaxLength = 4
        Me.txtCFOPFiltro.Name = "txtCFOPFiltro"
        Me.txtCFOPFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtCFOPFiltro.TabIndex = 1
        '
        'txtNaturezaOperacaoFiltro
        '
        Me.txtNaturezaOperacaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNaturezaOperacaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNaturezaOperacaoFiltro.Location = New System.Drawing.Point(115, 34)
        Me.txtNaturezaOperacaoFiltro.MaxLength = 350
        Me.txtNaturezaOperacaoFiltro.Name = "txtNaturezaOperacaoFiltro"
        Me.txtNaturezaOperacaoFiltro.Size = New System.Drawing.Size(579, 20)
        Me.txtNaturezaOperacaoFiltro.TabIndex = 3
        '
        'lblNaturezaOperacaoFiltro
        '
        Me.lblNaturezaOperacaoFiltro.AutoSize = True
        Me.lblNaturezaOperacaoFiltro.Location = New System.Drawing.Point(112, 17)
        Me.lblNaturezaOperacaoFiltro.Name = "lblNaturezaOperacaoFiltro"
        Me.lblNaturezaOperacaoFiltro.Size = New System.Drawing.Size(105, 14)
        Me.lblNaturezaOperacaoFiltro.TabIndex = 2
        Me.lblNaturezaOperacaoFiltro.Text = "Natureza Operação:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.grpControl.Controls.Add(Me.lblCongelarColuna)
        Me.grpControl.Controls.Add(Me.cboCongelarColuna)
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
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
        Me.lblCongelarColuna.TabIndex = 9
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 10
        Me.cboCongelarColuna.TabStop = False
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
        Me.pagDados.Controls.Add(Me.btnExcelGridTipoOperacaoNotaFiscal)
        Me.pagDados.Controls.Add(Me.btnExcelGridDeposito)
        Me.pagDados.Controls.Add(Me.btnExcelGridDepositoQualidade)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridDepositoQualidade)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridDeposito)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridTipoOperacaoNotaFiscal)
        Me.pagDados.Controls.Add(Me.grdTipoOperacaoNotaFiscal)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grdDepositoQualidade)
        Me.pagDados.Controls.Add(Me.grdDeposito)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "CFOP"
        '
        'btnExcelGridTipoOperacaoNotaFiscal
        '
        Me.btnExcelGridTipoOperacaoNotaFiscal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridTipoOperacaoNotaFiscal.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridTipoOperacaoNotaFiscal.FlatAppearance.BorderSize = 0
        Me.btnExcelGridTipoOperacaoNotaFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridTipoOperacaoNotaFiscal.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridTipoOperacaoNotaFiscal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridTipoOperacaoNotaFiscal.Location = New System.Drawing.Point(33, 463)
        Me.btnExcelGridTipoOperacaoNotaFiscal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridTipoOperacaoNotaFiscal.Name = "btnExcelGridTipoOperacaoNotaFiscal"
        Me.btnExcelGridTipoOperacaoNotaFiscal.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridTipoOperacaoNotaFiscal.TabIndex = 76
        Me.btnExcelGridTipoOperacaoNotaFiscal.TabStop = False
        Me.btnExcelGridTipoOperacaoNotaFiscal.UseVisualStyleBackColor = False
        '
        'btnExcelGridDeposito
        '
        Me.btnExcelGridDeposito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridDeposito.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridDeposito.FlatAppearance.BorderSize = 0
        Me.btnExcelGridDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridDeposito.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridDeposito.Location = New System.Drawing.Point(384, 463)
        Me.btnExcelGridDeposito.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridDeposito.Name = "btnExcelGridDeposito"
        Me.btnExcelGridDeposito.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridDeposito.TabIndex = 75
        Me.btnExcelGridDeposito.TabStop = False
        Me.btnExcelGridDeposito.UseVisualStyleBackColor = False
        '
        'btnExcelGridDepositoQualidade
        '
        Me.btnExcelGridDepositoQualidade.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridDepositoQualidade.FlatAppearance.BorderSize = 0
        Me.btnExcelGridDepositoQualidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridDepositoQualidade.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridDepositoQualidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridDepositoQualidade.Location = New System.Drawing.Point(384, 312)
        Me.btnExcelGridDepositoQualidade.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridDepositoQualidade.Name = "btnExcelGridDepositoQualidade"
        Me.btnExcelGridDepositoQualidade.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridDepositoQualidade.TabIndex = 74
        Me.btnExcelGridDepositoQualidade.TabStop = False
        Me.btnExcelGridDepositoQualidade.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridDepositoQualidade
        '
        Me.btnConfigurarGridDepositoQualidade.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridDepositoQualidade.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridDepositoQualidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridDepositoQualidade.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridDepositoQualidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridDepositoQualidade.Location = New System.Drawing.Point(360, 312)
        Me.btnConfigurarGridDepositoQualidade.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridDepositoQualidade.Name = "btnConfigurarGridDepositoQualidade"
        Me.btnConfigurarGridDepositoQualidade.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridDepositoQualidade.TabIndex = 3
        Me.btnConfigurarGridDepositoQualidade.TabStop = False
        Me.btnConfigurarGridDepositoQualidade.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridDeposito
        '
        Me.btnConfigurarGridDeposito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridDeposito.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridDeposito.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridDeposito.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridDeposito.Location = New System.Drawing.Point(360, 463)
        Me.btnConfigurarGridDeposito.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridDeposito.Name = "btnConfigurarGridDeposito"
        Me.btnConfigurarGridDeposito.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridDeposito.TabIndex = 5
        Me.btnConfigurarGridDeposito.TabStop = False
        Me.btnConfigurarGridDeposito.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridTipoOperacaoNotaFiscal
        '
        Me.btnConfigurarGridTipoOperacaoNotaFiscal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridTipoOperacaoNotaFiscal.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridTipoOperacaoNotaFiscal.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridTipoOperacaoNotaFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridTipoOperacaoNotaFiscal.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridTipoOperacaoNotaFiscal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridTipoOperacaoNotaFiscal.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGridTipoOperacaoNotaFiscal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridTipoOperacaoNotaFiscal.Name = "btnConfigurarGridTipoOperacaoNotaFiscal"
        Me.btnConfigurarGridTipoOperacaoNotaFiscal.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridTipoOperacaoNotaFiscal.TabIndex = 1
        Me.btnConfigurarGridTipoOperacaoNotaFiscal.TabStop = False
        Me.btnConfigurarGridTipoOperacaoNotaFiscal.UseVisualStyleBackColor = False
        '
        'grdTipoOperacaoNotaFiscal
        '
        Me.grdTipoOperacaoNotaFiscal.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdTipoOperacaoNotaFiscal.AlternatingColors = True
        Me.grdTipoOperacaoNotaFiscal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdTipoOperacaoNotaFiscal.ColumnAutoResize = True
        grdTipoOperacaoNotaFiscal_DesignTimeLayout.LayoutString = resources.GetString("grdTipoOperacaoNotaFiscal_DesignTimeLayout.LayoutString")
        Me.grdTipoOperacaoNotaFiscal.DesignTimeLayout = grdTipoOperacaoNotaFiscal_DesignTimeLayout
        Me.grdTipoOperacaoNotaFiscal.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdTipoOperacaoNotaFiscal.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdTipoOperacaoNotaFiscal.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdTipoOperacaoNotaFiscal.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdTipoOperacaoNotaFiscal.FrozenColumns = 3
        Me.grdTipoOperacaoNotaFiscal.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdTipoOperacaoNotaFiscal.GroupByBoxVisible = False
        Me.grdTipoOperacaoNotaFiscal.Location = New System.Drawing.Point(8, 186)
        Me.grdTipoOperacaoNotaFiscal.Name = "grdTipoOperacaoNotaFiscal"
        Me.grdTipoOperacaoNotaFiscal.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdTipoOperacaoNotaFiscal.RecordNavigator = True
        Me.grdTipoOperacaoNotaFiscal.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdTipoOperacaoNotaFiscal.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdTipoOperacaoNotaFiscal.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdTipoOperacaoNotaFiscal.Size = New System.Drawing.Size(342, 294)
        Me.grdTipoOperacaoNotaFiscal.TabIndex = 0
        Me.grdTipoOperacaoNotaFiscal.TabStop = False
        Me.grdTipoOperacaoNotaFiscal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdTipoOperacaoNotaFiscal.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(8, 483)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(897, 51)
        Me.grpControl2.TabIndex = 6
        Me.grpControl2.VisualStyleManager = Me.vsmMain
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
        Me.grpDados.Controls.Add(Me.txtMensagem)
        Me.grpDados.Controls.Add(Me.lblMensagem)
        Me.grpDados.Controls.Add(Me.lblGeraFinanceiro)
        Me.grpDados.Controls.Add(Me.cboGeraFinanceiro)
        Me.grpDados.Controls.Add(Me.lblTipoMovimentacaoEstoque)
        Me.grpDados.Controls.Add(Me.cboTipoMovimentacaoEstoque)
        Me.grpDados.Controls.Add(Me.txtAplicacao)
        Me.grpDados.Controls.Add(Me.lblAplicacao)
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.lblCFOP)
        Me.grpDados.Controls.Add(Me.txtCFOP)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.txtNaturezaOperacao)
        Me.grpDados.Controls.Add(Me.lblNaturezaOperacao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 174)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtMensagem
        '
        Me.txtMensagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMensagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMensagem.Location = New System.Drawing.Point(581, 74)
        Me.txtMensagem.MaxLength = 700
        Me.txtMensagem.Multiline = True
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensagem.Size = New System.Drawing.Size(307, 50)
        Me.txtMensagem.TabIndex = 7
        '
        'lblMensagem
        '
        Me.lblMensagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMensagem.AutoSize = True
        Me.lblMensagem.Location = New System.Drawing.Point(578, 57)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(226, 14)
        Me.lblMensagem.TabIndex = 6
        Me.lblMensagem.Text = "Mensagem - Dados Adicionais da Nota Fiscal:"
        '
        'lblGeraFinanceiro
        '
        Me.lblGeraFinanceiro.AutoSize = True
        Me.lblGeraFinanceiro.Location = New System.Drawing.Point(220, 127)
        Me.lblGeraFinanceiro.Name = "lblGeraFinanceiro"
        Me.lblGeraFinanceiro.Size = New System.Drawing.Size(87, 14)
        Me.lblGeraFinanceiro.TabIndex = 10
        Me.lblGeraFinanceiro.Text = "Gera Financeiro:"
        '
        'cboGeraFinanceiro
        '
        Me.cboGeraFinanceiro.AutoSize = False
        Me.cboGeraFinanceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboGeraFinanceiro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboGeraFinanceiro.Location = New System.Drawing.Point(223, 144)
        Me.cboGeraFinanceiro.Name = "cboGeraFinanceiro"
        Me.cboGeraFinanceiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGeraFinanceiro.Size = New System.Drawing.Size(120, 20)
        Me.cboGeraFinanceiro.TabIndex = 11
        '
        'lblTipoMovimentacaoEstoque
        '
        Me.lblTipoMovimentacaoEstoque.AutoSize = True
        Me.lblTipoMovimentacaoEstoque.Location = New System.Drawing.Point(6, 127)
        Me.lblTipoMovimentacaoEstoque.Name = "lblTipoMovimentacaoEstoque"
        Me.lblTipoMovimentacaoEstoque.Size = New System.Drawing.Size(174, 14)
        Me.lblTipoMovimentacaoEstoque.TabIndex = 8
        Me.lblTipoMovimentacaoEstoque.Text = "Tipo de Movimentação de Estoque:"
        '
        'cboTipoMovimentacaoEstoque
        '
        Me.cboTipoMovimentacaoEstoque.AutoSize = False
        Me.cboTipoMovimentacaoEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboTipoMovimentacaoEstoque.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboTipoMovimentacaoEstoque.Location = New System.Drawing.Point(9, 144)
        Me.cboTipoMovimentacaoEstoque.Name = "cboTipoMovimentacaoEstoque"
        Me.cboTipoMovimentacaoEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoMovimentacaoEstoque.Size = New System.Drawing.Size(208, 20)
        Me.cboTipoMovimentacaoEstoque.TabIndex = 9
        '
        'txtAplicacao
        '
        Me.txtAplicacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAplicacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAplicacao.Location = New System.Drawing.Point(9, 74)
        Me.txtAplicacao.MaxLength = 700
        Me.txtAplicacao.Multiline = True
        Me.txtAplicacao.Name = "txtAplicacao"
        Me.txtAplicacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAplicacao.Size = New System.Drawing.Size(566, 50)
        Me.txtAplicacao.TabIndex = 5
        '
        'lblAplicacao
        '
        Me.lblAplicacao.AutoSize = True
        Me.lblAplicacao.Location = New System.Drawing.Point(6, 57)
        Me.lblAplicacao.Name = "lblAplicacao"
        Me.lblAplicacao.Size = New System.Drawing.Size(58, 14)
        Me.lblAplicacao.TabIndex = 4
        Me.lblAplicacao.Text = "Aplicação:"
        '
        'lblAtivo
        '
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.Location = New System.Drawing.Point(346, 127)
        Me.lblAtivo.Name = "lblAtivo"
        Me.lblAtivo.Size = New System.Drawing.Size(35, 14)
        Me.lblAtivo.TabIndex = 14
        Me.lblAtivo.Text = "Ativo:"
        '
        'lblCFOP
        '
        Me.lblCFOP.AutoSize = True
        Me.lblCFOP.Location = New System.Drawing.Point(6, 17)
        Me.lblCFOP.Name = "lblCFOP"
        Me.lblCFOP.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOP.TabIndex = 0
        Me.lblCFOP.Text = "CFOP:"
        '
        'txtCFOP
        '
        Me.txtCFOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCFOP.Location = New System.Drawing.Point(9, 34)
        Me.txtCFOP.MaxLength = 4
        Me.txtCFOP.Name = "txtCFOP"
        Me.txtCFOP.Size = New System.Drawing.Size(100, 20)
        Me.txtCFOP.TabIndex = 1
        '
        'cboAtivo
        '
        Me.cboAtivo.AutoSize = False
        Me.cboAtivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "SIM"
        UiComboBoxItem5.Value = True
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "NÃO"
        UiComboBoxItem6.Value = False
        Me.cboAtivo.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboAtivo.Location = New System.Drawing.Point(349, 144)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivo.Size = New System.Drawing.Size(100, 20)
        Me.cboAtivo.TabIndex = 15
        '
        'txtNaturezaOperacao
        '
        Me.txtNaturezaOperacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNaturezaOperacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNaturezaOperacao.Location = New System.Drawing.Point(115, 34)
        Me.txtNaturezaOperacao.MaxLength = 350
        Me.txtNaturezaOperacao.Name = "txtNaturezaOperacao"
        Me.txtNaturezaOperacao.Size = New System.Drawing.Size(773, 20)
        Me.txtNaturezaOperacao.TabIndex = 3
        '
        'lblNaturezaOperacao
        '
        Me.lblNaturezaOperacao.AutoSize = True
        Me.lblNaturezaOperacao.Location = New System.Drawing.Point(112, 17)
        Me.lblNaturezaOperacao.Name = "lblNaturezaOperacao"
        Me.lblNaturezaOperacao.Size = New System.Drawing.Size(105, 14)
        Me.lblNaturezaOperacao.TabIndex = 2
        Me.lblNaturezaOperacao.Text = "Natureza Operação:"
        '
        'grdDepositoQualidade
        '
        Me.grdDepositoQualidade.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdDepositoQualidade.AlternatingColors = True
        Me.grdDepositoQualidade.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDepositoQualidade.ColumnAutoResize = True
        grdDepositoQualidade_DesignTimeLayout.LayoutString = resources.GetString("grdDepositoQualidade_DesignTimeLayout.LayoutString")
        Me.grdDepositoQualidade.DesignTimeLayout = grdDepositoQualidade_DesignTimeLayout
        Me.grdDepositoQualidade.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdDepositoQualidade.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdDepositoQualidade.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdDepositoQualidade.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdDepositoQualidade.FrozenColumns = 3
        Me.grdDepositoQualidade.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdDepositoQualidade.GroupByBoxVisible = False
        Me.grdDepositoQualidade.HeaderFormatStyle.BackColor = System.Drawing.Color.LightGray
        Me.grdDepositoQualidade.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdDepositoQualidade.Location = New System.Drawing.Point(359, 186)
        Me.grdDepositoQualidade.Name = "grdDepositoQualidade"
        Me.grdDepositoQualidade.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdDepositoQualidade.RecordNavigator = True
        Me.grdDepositoQualidade.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdDepositoQualidade.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdDepositoQualidade.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdDepositoQualidade.Size = New System.Drawing.Size(546, 143)
        Me.grdDepositoQualidade.TabIndex = 2
        Me.grdDepositoQualidade.TabStop = False
        Me.grdDepositoQualidade.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdDepositoQualidade.VisualStyleManager = Me.vsmMain
        '
        'grdDeposito
        '
        Me.grdDeposito.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdDeposito.AlternatingColors = True
        Me.grdDeposito.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDeposito.ColumnAutoResize = True
        grdDeposito_DesignTimeLayout.LayoutString = resources.GetString("grdDeposito_DesignTimeLayout.LayoutString")
        Me.grdDeposito.DesignTimeLayout = grdDeposito_DesignTimeLayout
        Me.grdDeposito.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdDeposito.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdDeposito.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdDeposito.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdDeposito.FrozenColumns = 3
        Me.grdDeposito.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdDeposito.GroupByBoxVisible = False
        Me.grdDeposito.Location = New System.Drawing.Point(359, 338)
        Me.grdDeposito.Name = "grdDeposito"
        Me.grdDeposito.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdDeposito.RecordNavigator = True
        Me.grdDeposito.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdDeposito.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdDeposito.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdDeposito.Size = New System.Drawing.Size(546, 142)
        Me.grdDeposito.TabIndex = 4
        Me.grdDeposito.TabStop = False
        Me.grdDeposito.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdDeposito.VisualStyleManager = Me.vsmMain
        '
        'usrCadCFOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadCFOP"
        Me.Size = New System.Drawing.Size(915, 566)
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
        CType(Me.grdTipoOperacaoNotaFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grdDepositoQualidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDeposito, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblNaturezaOperacao As System.Windows.Forms.Label
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblNaturezaOperacaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNaturezaOperacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNaturezaOperacaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblCFOPFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCFOPFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCFOP As System.Windows.Forms.Label
    Friend WithEvents txtCFOP As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtAplicacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblAplicacao As System.Windows.Forms.Label
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblGeraFinanceiro As System.Windows.Forms.Label
    Friend WithEvents cboGeraFinanceiro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoMovimentacaoEstoque As System.Windows.Forms.Label
    Friend WithEvents cboTipoMovimentacaoEstoque As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdTipoOperacaoNotaFiscal As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdDepositoQualidade As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGridDeposito As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridTipoOperacaoNotaFiscal As System.Windows.Forms.Button
    Friend WithEvents grdDeposito As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGridDepositoQualidade As System.Windows.Forms.Button
    Friend WithEvents txtMensagem As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblMensagem As System.Windows.Forms.Label
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridTipoOperacaoNotaFiscal As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridDeposito As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridDepositoQualidade As System.Windows.Forms.Button

End Class
