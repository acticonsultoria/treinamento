<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadFormatoMP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadFormatoMP))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtQuantidadeMedidas = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblFormula = New System.Windows.Forms.Label()
        Me.txtFormula = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpControleBCICMS = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnValor = New Janus.Windows.EditControls.UIButton()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnMedida4 = New Janus.Windows.EditControls.UIButton()
        Me.btnMedida2 = New Janus.Windows.EditControls.UIButton()
        Me.btnMedida1 = New Janus.Windows.EditControls.UIButton()
        Me.btnC = New Janus.Windows.EditControls.UIButton()
        Me.btnCE = New Janus.Windows.EditControls.UIButton()
        Me.btnFechaParenteses = New Janus.Windows.EditControls.UIButton()
        Me.btnAbreParenteses = New Janus.Windows.EditControls.UIButton()
        Me.btnDivide = New Janus.Windows.EditControls.UIButton()
        Me.btnMultiplica = New Janus.Windows.EditControls.UIButton()
        Me.btnSubtrai = New Janus.Windows.EditControls.UIButton()
        Me.btnDensidade = New Janus.Windows.EditControls.UIButton()
        Me.btnMedida3 = New Janus.Windows.EditControls.UIButton()
        Me.btnSoma = New Janus.Windows.EditControls.UIButton()
        Me.cboQuantidadeMedidas = New Janus.Windows.EditControls.UIComboBox()
        Me.txtMedida4 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMedida4 = New System.Windows.Forms.Label()
        Me.txtMedida3 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMedida3 = New System.Windows.Forms.Label()
        Me.txtMedida2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMedida2 = New System.Windows.Forms.Label()
        Me.txtMedida1 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMedida1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
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
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpControleBCICMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleBCICMS.SuspendLayout()
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
        Me.pagLista.Text = "Formato de Matéria Prima"
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
        Me.grpFiltro.Controls.Add(Me.txtQuantidadeMedidas)
        Me.grpFiltro.Controls.Add(Me.Label2)
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
        'txtQuantidadeMedidas
        '
        Me.txtQuantidadeMedidas.DecimalDigits = 0
        Me.txtQuantidadeMedidas.Location = New System.Drawing.Point(671, 34)
        Me.txtQuantidadeMedidas.MaxLength = 0
        Me.txtQuantidadeMedidas.Name = "txtQuantidadeMedidas"
        Me.txtQuantidadeMedidas.Size = New System.Drawing.Size(120, 20)
        Me.txtQuantidadeMedidas.TabIndex = 37
        Me.txtQuantidadeMedidas.Text = "0"
        Me.txtQuantidadeMedidas.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(668, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Quantidade de Medidas:"
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
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(135, 34)
        Me.txtDescricaoFiltro.MaxLength = 100
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(530, 20)
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
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Formato de Matéria Prima"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
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
        Me.grpDados.Controls.Add(Me.lblFormula)
        Me.grpDados.Controls.Add(Me.txtFormula)
        Me.grpDados.Controls.Add(Me.grpControleBCICMS)
        Me.grpDados.Controls.Add(Me.cboQuantidadeMedidas)
        Me.grpDados.Controls.Add(Me.txtMedida4)
        Me.grpDados.Controls.Add(Me.lblMedida4)
        Me.grpDados.Controls.Add(Me.txtMedida3)
        Me.grpDados.Controls.Add(Me.lblMedida3)
        Me.grpDados.Controls.Add(Me.txtMedida2)
        Me.grpDados.Controls.Add(Me.lblMedida2)
        Me.grpDados.Controls.Add(Me.txtMedida1)
        Me.grpDados.Controls.Add(Me.lblMedida1)
        Me.grpDados.Controls.Add(Me.Label1)
        Me.grpDados.Controls.Add(Me.txtCodigo)
        Me.grpDados.Controls.Add(Me.lblCodigo)
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 247)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblFormula
        '
        Me.lblFormula.AutoSize = True
        Me.lblFormula.Location = New System.Drawing.Point(257, 110)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(48, 14)
        Me.lblFormula.TabIndex = 18
        Me.lblFormula.Text = "Fórmula:"
        '
        'txtFormula
        '
        Me.txtFormula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFormula.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFormula.Location = New System.Drawing.Point(260, 127)
        Me.txtFormula.MaxLength = 500
        Me.txtFormula.Name = "txtFormula"
        Me.txtFormula.ReadOnly = True
        Me.txtFormula.Size = New System.Drawing.Size(617, 20)
        Me.txtFormula.TabIndex = 19
        Me.txtFormula.TabStop = False
        '
        'grpControleBCICMS
        '
        Me.grpControleBCICMS.BackColor = System.Drawing.Color.Transparent
        Me.grpControleBCICMS.Controls.Add(Me.btnValor)
        Me.grpControleBCICMS.Controls.Add(Me.txtValor)
        Me.grpControleBCICMS.Controls.Add(Me.btnMedida4)
        Me.grpControleBCICMS.Controls.Add(Me.btnMedida2)
        Me.grpControleBCICMS.Controls.Add(Me.btnMedida1)
        Me.grpControleBCICMS.Controls.Add(Me.btnC)
        Me.grpControleBCICMS.Controls.Add(Me.btnCE)
        Me.grpControleBCICMS.Controls.Add(Me.btnFechaParenteses)
        Me.grpControleBCICMS.Controls.Add(Me.btnAbreParenteses)
        Me.grpControleBCICMS.Controls.Add(Me.btnDivide)
        Me.grpControleBCICMS.Controls.Add(Me.btnMultiplica)
        Me.grpControleBCICMS.Controls.Add(Me.btnSubtrai)
        Me.grpControleBCICMS.Controls.Add(Me.btnDensidade)
        Me.grpControleBCICMS.Controls.Add(Me.btnMedida3)
        Me.grpControleBCICMS.Controls.Add(Me.btnSoma)
        Me.grpControleBCICMS.Location = New System.Drawing.Point(9, 109)
        Me.grpControleBCICMS.Name = "grpControleBCICMS"
        Me.grpControleBCICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleBCICMS.Size = New System.Drawing.Size(236, 125)
        Me.grpControleBCICMS.TabIndex = 17
        Me.grpControleBCICMS.VisualStyleManager = Me.vsmMain
        '
        'btnValor
        '
        Me.btnValor.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnValor.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnValor.Location = New System.Drawing.Point(188, 72)
        Me.btnValor.Name = "btnValor"
        Me.btnValor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnValor.Size = New System.Drawing.Size(39, 20)
        Me.btnValor.TabIndex = 23
        Me.btnValor.TabStop = False
        Me.btnValor.Tag = ""
        Me.btnValor.Text = "Valor"
        Me.btnValor.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(121, 72)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(68, 20)
        Me.txtValor.TabIndex = 22
        Me.txtValor.TabStop = False
        Me.txtValor.Text = "0,00"
        Me.txtValor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'btnMedida4
        '
        Me.btnMedida4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMedida4.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnMedida4.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnMedida4.Location = New System.Drawing.Point(121, 46)
        Me.btnMedida4.Name = "btnMedida4"
        Me.btnMedida4.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnMedida4.Size = New System.Drawing.Size(106, 20)
        Me.btnMedida4.TabIndex = 4
        Me.btnMedida4.TabStop = False
        Me.btnMedida4.Tag = "|MEDIDA 4|"
        Me.btnMedida4.Text = "Medida 4"
        Me.btnMedida4.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnMedida2
        '
        Me.btnMedida2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMedida2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnMedida2.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnMedida2.Location = New System.Drawing.Point(121, 20)
        Me.btnMedida2.Name = "btnMedida2"
        Me.btnMedida2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnMedida2.Size = New System.Drawing.Size(106, 20)
        Me.btnMedida2.TabIndex = 2
        Me.btnMedida2.TabStop = False
        Me.btnMedida2.Tag = "|MEDIDA 2|"
        Me.btnMedida2.Text = "Medida 2"
        Me.btnMedida2.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnMedida1
        '
        Me.btnMedida1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMedida1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnMedida1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnMedida1.Location = New System.Drawing.Point(9, 20)
        Me.btnMedida1.Name = "btnMedida1"
        Me.btnMedida1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnMedida1.Size = New System.Drawing.Size(106, 20)
        Me.btnMedida1.TabIndex = 1
        Me.btnMedida1.TabStop = False
        Me.btnMedida1.Tag = "|MEDIDA 1|"
        Me.btnMedida1.Text = "Medida 1"
        Me.btnMedida1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnC
        '
        Me.btnC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnC.Location = New System.Drawing.Point(205, 97)
        Me.btnC.Name = "btnC"
        Me.btnC.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnC.Size = New System.Drawing.Size(22, 20)
        Me.btnC.TabIndex = 21
        Me.btnC.TabStop = False
        Me.btnC.Tag = ""
        Me.btnC.Text = "C"
        Me.btnC.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCE
        '
        Me.btnCE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCE.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCE.Location = New System.Drawing.Point(177, 97)
        Me.btnCE.Name = "btnCE"
        Me.btnCE.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCE.Size = New System.Drawing.Size(22, 20)
        Me.btnCE.TabIndex = 20
        Me.btnCE.TabStop = False
        Me.btnCE.Tag = ""
        Me.btnCE.Text = "CE"
        Me.btnCE.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnFechaParenteses
        '
        Me.btnFechaParenteses.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechaParenteses.Enabled = False
        Me.btnFechaParenteses.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechaParenteses.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFechaParenteses.Location = New System.Drawing.Point(149, 97)
        Me.btnFechaParenteses.Name = "btnFechaParenteses"
        Me.btnFechaParenteses.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFechaParenteses.Size = New System.Drawing.Size(22, 20)
        Me.btnFechaParenteses.TabIndex = 19
        Me.btnFechaParenteses.TabStop = False
        Me.btnFechaParenteses.Tag = ")"
        Me.btnFechaParenteses.Text = ")"
        Me.btnFechaParenteses.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAbreParenteses
        '
        Me.btnAbreParenteses.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbreParenteses.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbreParenteses.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAbreParenteses.Location = New System.Drawing.Point(121, 97)
        Me.btnAbreParenteses.Name = "btnAbreParenteses"
        Me.btnAbreParenteses.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAbreParenteses.Size = New System.Drawing.Size(22, 20)
        Me.btnAbreParenteses.TabIndex = 18
        Me.btnAbreParenteses.TabStop = False
        Me.btnAbreParenteses.Tag = "("
        Me.btnAbreParenteses.Text = "("
        Me.btnAbreParenteses.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnDivide
        '
        Me.btnDivide.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDivide.Enabled = False
        Me.btnDivide.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnDivide.Location = New System.Drawing.Point(93, 97)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnDivide.Size = New System.Drawing.Size(22, 20)
        Me.btnDivide.TabIndex = 17
        Me.btnDivide.TabStop = False
        Me.btnDivide.Tag = "/"
        Me.btnDivide.Text = "/"
        Me.btnDivide.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnMultiplica
        '
        Me.btnMultiplica.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMultiplica.Enabled = False
        Me.btnMultiplica.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplica.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnMultiplica.Location = New System.Drawing.Point(65, 97)
        Me.btnMultiplica.Name = "btnMultiplica"
        Me.btnMultiplica.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnMultiplica.Size = New System.Drawing.Size(22, 20)
        Me.btnMultiplica.TabIndex = 16
        Me.btnMultiplica.TabStop = False
        Me.btnMultiplica.Tag = "*"
        Me.btnMultiplica.Text = "x"
        Me.btnMultiplica.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSubtrai
        '
        Me.btnSubtrai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubtrai.Enabled = False
        Me.btnSubtrai.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtrai.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSubtrai.Location = New System.Drawing.Point(37, 97)
        Me.btnSubtrai.Name = "btnSubtrai"
        Me.btnSubtrai.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSubtrai.Size = New System.Drawing.Size(22, 20)
        Me.btnSubtrai.TabIndex = 15
        Me.btnSubtrai.TabStop = False
        Me.btnSubtrai.Tag = "-"
        Me.btnSubtrai.Text = "–"
        Me.btnSubtrai.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnDensidade
        '
        Me.btnDensidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDensidade.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnDensidade.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnDensidade.Location = New System.Drawing.Point(9, 72)
        Me.btnDensidade.Name = "btnDensidade"
        Me.btnDensidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnDensidade.Size = New System.Drawing.Size(106, 20)
        Me.btnDensidade.TabIndex = 5
        Me.btnDensidade.TabStop = False
        Me.btnDensidade.Tag = "|DENSIDADE|"
        Me.btnDensidade.Text = "Densidade"
        Me.btnDensidade.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnMedida3
        '
        Me.btnMedida3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMedida3.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnMedida3.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnMedida3.Location = New System.Drawing.Point(9, 46)
        Me.btnMedida3.Name = "btnMedida3"
        Me.btnMedida3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnMedida3.Size = New System.Drawing.Size(106, 20)
        Me.btnMedida3.TabIndex = 3
        Me.btnMedida3.TabStop = False
        Me.btnMedida3.Tag = "|MEDIDA 3|"
        Me.btnMedida3.Text = "Medida 3"
        Me.btnMedida3.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSoma
        '
        Me.btnSoma.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSoma.Enabled = False
        Me.btnSoma.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoma.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSoma.Location = New System.Drawing.Point(9, 97)
        Me.btnSoma.Name = "btnSoma"
        Me.btnSoma.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSoma.Size = New System.Drawing.Size(22, 20)
        Me.btnSoma.TabIndex = 14
        Me.btnSoma.TabStop = False
        Me.btnSoma.Tag = "+"
        Me.btnSoma.Text = "+"
        Me.btnSoma.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboQuantidadeMedidas
        '
        Me.cboQuantidadeMedidas.AutoSize = False
        Me.cboQuantidadeMedidas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboQuantidadeMedidas.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboQuantidadeMedidas.Location = New System.Drawing.Point(9, 74)
        Me.cboQuantidadeMedidas.Name = "cboQuantidadeMedidas"
        Me.cboQuantidadeMedidas.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboQuantidadeMedidas.Size = New System.Drawing.Size(134, 20)
        Me.cboQuantidadeMedidas.TabIndex = 16
        '
        'txtMedida4
        '
        Me.txtMedida4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMedida4.Location = New System.Drawing.Point(538, 75)
        Me.txtMedida4.MaxLength = 20
        Me.txtMedida4.Name = "txtMedida4"
        Me.txtMedida4.Size = New System.Drawing.Size(126, 20)
        Me.txtMedida4.TabIndex = 15
        '
        'lblMedida4
        '
        Me.lblMedida4.AutoSize = True
        Me.lblMedida4.Location = New System.Drawing.Point(536, 58)
        Me.lblMedida4.Name = "lblMedida4"
        Me.lblMedida4.Size = New System.Drawing.Size(98, 14)
        Me.lblMedida4.TabIndex = 14
        Me.lblMedida4.Text = "Nome da Medida 4:"
        '
        'txtMedida3
        '
        Me.txtMedida3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMedida3.Location = New System.Drawing.Point(414, 74)
        Me.txtMedida3.MaxLength = 20
        Me.txtMedida3.Name = "txtMedida3"
        Me.txtMedida3.Size = New System.Drawing.Size(118, 20)
        Me.txtMedida3.TabIndex = 13
        '
        'lblMedida3
        '
        Me.lblMedida3.AutoSize = True
        Me.lblMedida3.Location = New System.Drawing.Point(411, 57)
        Me.lblMedida3.Name = "lblMedida3"
        Me.lblMedida3.Size = New System.Drawing.Size(98, 14)
        Me.lblMedida3.TabIndex = 12
        Me.lblMedida3.Text = "Nome da Medida 3:"
        '
        'txtMedida2
        '
        Me.txtMedida2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMedida2.Location = New System.Drawing.Point(286, 74)
        Me.txtMedida2.MaxLength = 20
        Me.txtMedida2.Name = "txtMedida2"
        Me.txtMedida2.Size = New System.Drawing.Size(122, 20)
        Me.txtMedida2.TabIndex = 11
        '
        'lblMedida2
        '
        Me.lblMedida2.AutoSize = True
        Me.lblMedida2.Location = New System.Drawing.Point(284, 57)
        Me.lblMedida2.Name = "lblMedida2"
        Me.lblMedida2.Size = New System.Drawing.Size(98, 14)
        Me.lblMedida2.TabIndex = 10
        Me.lblMedida2.Text = "Nome da Medida 2:"
        '
        'txtMedida1
        '
        Me.txtMedida1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMedida1.Location = New System.Drawing.Point(149, 74)
        Me.txtMedida1.MaxLength = 20
        Me.txtMedida1.Name = "txtMedida1"
        Me.txtMedida1.Size = New System.Drawing.Size(131, 20)
        Me.txtMedida1.TabIndex = 9
        '
        'lblMedida1
        '
        Me.lblMedida1.AutoSize = True
        Me.lblMedida1.Location = New System.Drawing.Point(146, 57)
        Me.lblMedida1.Name = "lblMedida1"
        Me.lblMedida1.Size = New System.Drawing.Size(98, 14)
        Me.lblMedida1.TabIndex = 8
        Me.lblMedida1.Text = "Nome da Medida 1:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Quantidade de Medidas:"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(9, 34)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(134, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'lblAtivo
        '
        Me.lblAtivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.Location = New System.Drawing.Point(781, 17)
        Me.lblAtivo.Name = "lblAtivo"
        Me.lblAtivo.Size = New System.Drawing.Size(35, 14)
        Me.lblAtivo.TabIndex = 4
        Me.lblAtivo.Text = "Ativo:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(149, 34)
        Me.txtDescricao.MaxLength = 100
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(629, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'cboAtivo
        '
        Me.cboAtivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.cboAtivo.Location = New System.Drawing.Point(784, 34)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivo.Size = New System.Drawing.Size(102, 20)
        Me.cboAtivo.TabIndex = 5
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(146, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição:"
        '
        'usrCadFormatoMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadFormatoMP"
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
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControleBCICMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleBCICMS.ResumeLayout(False)
        Me.grpControleBCICMS.PerformLayout()
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
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents txtCodigoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboQuantidadeMedidas As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtMedida4 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMedida4 As System.Windows.Forms.Label
    Friend WithEvents txtMedida3 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMedida3 As System.Windows.Forms.Label
    Friend WithEvents txtMedida2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMedida2 As System.Windows.Forms.Label
    Friend WithEvents txtMedida1 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMedida1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeMedidas As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents grpControleBCICMS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnMedida4 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnMedida2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnMedida1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnC As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCE As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFechaParenteses As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAbreParenteses As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnDivide As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnMultiplica As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSubtrai As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnDensidade As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnMedida3 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSoma As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblFormula As System.Windows.Forms.Label
    Friend WithEvents txtFormula As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnValor As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.NumericEditBox

End Class
