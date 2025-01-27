<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrEstLocalizacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrEstLocalizacao))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpExcel = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtPlanilha = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPlanilha = New System.Windows.Forms.Label()
        Me.txtLinhaInicio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtArquivoExcel = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblLinhaInicio = New System.Windows.Forms.Label()
        Me.btnArquivoExcel = New Janus.Windows.EditControls.UIButton()
        Me.cboConfiguracaoColunaLocalizacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblArquivoExcel = New System.Windows.Forms.Label()
        Me.lblConfiguracaoColunaLocalizacao = New System.Windows.Forms.Label()
        Me.lblConfiguracaoColunaCodigoItem = New System.Windows.Forms.Label()
        Me.cboConfiguracaoColunaCodigoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblDepositoFiltro = New System.Windows.Forms.Label()
        Me.cboDepositoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtLocalizacaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblLocalizacaoFiltro = New System.Windows.Forms.Label()
        Me.lblGrupoItemFiltro = New System.Windows.Forms.Label()
        Me.cboGrupoItemFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtCodigoProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoProdutoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpExcel.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grpExcel)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Estoque - Localização"
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 4
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 3
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpExcel
        '
        Me.grpExcel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpExcel.BackColor = System.Drawing.Color.Transparent
        Me.grpExcel.Controls.Add(Me.txtPlanilha)
        Me.grpExcel.Controls.Add(Me.lblPlanilha)
        Me.grpExcel.Controls.Add(Me.txtLinhaInicio)
        Me.grpExcel.Controls.Add(Me.txtArquivoExcel)
        Me.grpExcel.Controls.Add(Me.lblLinhaInicio)
        Me.grpExcel.Controls.Add(Me.btnArquivoExcel)
        Me.grpExcel.Controls.Add(Me.cboConfiguracaoColunaLocalizacao)
        Me.grpExcel.Controls.Add(Me.lblArquivoExcel)
        Me.grpExcel.Controls.Add(Me.lblConfiguracaoColunaLocalizacao)
        Me.grpExcel.Controls.Add(Me.lblConfiguracaoColunaCodigoItem)
        Me.grpExcel.Controls.Add(Me.cboConfiguracaoColunaCodigoItem)
        Me.grpExcel.Location = New System.Drawing.Point(8, 110)
        Me.grpExcel.Name = "grpExcel"
        Me.grpExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpExcel.Size = New System.Drawing.Size(897, 104)
        Me.grpExcel.TabIndex = 1
        Me.grpExcel.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpExcel.VisualStyleManager = Me.vsmMain
        '
        'txtPlanilha
        '
        Me.txtPlanilha.Location = New System.Drawing.Point(447, 74)
        Me.txtPlanilha.MaxLength = 35
        Me.txtPlanilha.Name = "txtPlanilha"
        Me.txtPlanilha.Size = New System.Drawing.Size(132, 20)
        Me.txtPlanilha.TabIndex = 10
        '
        'lblPlanilha
        '
        Me.lblPlanilha.AutoSize = True
        Me.lblPlanilha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPlanilha.Location = New System.Drawing.Point(444, 57)
        Me.lblPlanilha.Name = "lblPlanilha"
        Me.lblPlanilha.Size = New System.Drawing.Size(46, 14)
        Me.lblPlanilha.TabIndex = 9
        Me.lblPlanilha.Text = "Planilha:"
        '
        'txtLinhaInicio
        '
        Me.txtLinhaInicio.DecimalDigits = 0
        Me.txtLinhaInicio.Location = New System.Drawing.Point(301, 74)
        Me.txtLinhaInicio.Name = "txtLinhaInicio"
        Me.txtLinhaInicio.Size = New System.Drawing.Size(140, 20)
        Me.txtLinhaInicio.TabIndex = 8
        Me.txtLinhaInicio.Text = "0"
        Me.txtLinhaInicio.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtArquivoExcel
        '
        Me.txtArquivoExcel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivoExcel.BackColor = System.Drawing.SystemColors.Info
        Me.txtArquivoExcel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivoExcel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArquivoExcel.Location = New System.Drawing.Point(9, 34)
        Me.txtArquivoExcel.MaxLength = 50
        Me.txtArquivoExcel.Name = "txtArquivoExcel"
        Me.txtArquivoExcel.ReadOnly = True
        Me.txtArquivoExcel.Size = New System.Drawing.Size(857, 20)
        Me.txtArquivoExcel.TabIndex = 1
        Me.txtArquivoExcel.TabStop = False
        '
        'lblLinhaInicio
        '
        Me.lblLinhaInicio.AutoSize = True
        Me.lblLinhaInicio.Location = New System.Drawing.Point(298, 57)
        Me.lblLinhaInicio.Name = "lblLinhaInicio"
        Me.lblLinhaInicio.Size = New System.Drawing.Size(63, 14)
        Me.lblLinhaInicio.TabIndex = 7
        Me.lblLinhaInicio.Text = "Linha Início:"
        '
        'btnArquivoExcel
        '
        Me.btnArquivoExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivoExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivoExcel.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnArquivoExcel.Location = New System.Drawing.Point(865, 34)
        Me.btnArquivoExcel.Name = "btnArquivoExcel"
        Me.btnArquivoExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivoExcel.Size = New System.Drawing.Size(23, 20)
        Me.btnArquivoExcel.TabIndex = 2
        Me.btnArquivoExcel.Text = "..."
        Me.btnArquivoExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboConfiguracaoColunaLocalizacao
        '
        Me.cboConfiguracaoColunaLocalizacao.AutoSize = False
        Me.cboConfiguracaoColunaLocalizacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaLocalizacao.Location = New System.Drawing.Point(155, 74)
        Me.cboConfiguracaoColunaLocalizacao.Name = "cboConfiguracaoColunaLocalizacao"
        Me.cboConfiguracaoColunaLocalizacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaLocalizacao.Size = New System.Drawing.Size(140, 20)
        Me.cboConfiguracaoColunaLocalizacao.TabIndex = 6
        '
        'lblArquivoExcel
        '
        Me.lblArquivoExcel.AutoSize = True
        Me.lblArquivoExcel.Location = New System.Drawing.Point(6, 17)
        Me.lblArquivoExcel.Name = "lblArquivoExcel"
        Me.lblArquivoExcel.Size = New System.Drawing.Size(77, 14)
        Me.lblArquivoExcel.TabIndex = 0
        Me.lblArquivoExcel.Text = "Arquivo Excel:"
        '
        'lblConfiguracaoColunaLocalizacao
        '
        Me.lblConfiguracaoColunaLocalizacao.AutoSize = True
        Me.lblConfiguracaoColunaLocalizacao.Location = New System.Drawing.Point(152, 57)
        Me.lblConfiguracaoColunaLocalizacao.Name = "lblConfiguracaoColunaLocalizacao"
        Me.lblConfiguracaoColunaLocalizacao.Size = New System.Drawing.Size(111, 14)
        Me.lblConfiguracaoColunaLocalizacao.TabIndex = 5
        Me.lblConfiguracaoColunaLocalizacao.Text = "Coluna - Localização:"
        '
        'lblConfiguracaoColunaCodigoItem
        '
        Me.lblConfiguracaoColunaCodigoItem.AutoSize = True
        Me.lblConfiguracaoColunaCodigoItem.Location = New System.Drawing.Point(6, 57)
        Me.lblConfiguracaoColunaCodigoItem.Name = "lblConfiguracaoColunaCodigoItem"
        Me.lblConfiguracaoColunaCodigoItem.Size = New System.Drawing.Size(126, 14)
        Me.lblConfiguracaoColunaCodigoItem.TabIndex = 3
        Me.lblConfiguracaoColunaCodigoItem.Text = "Coluna - Código Produto:"
        '
        'cboConfiguracaoColunaCodigoItem
        '
        Me.cboConfiguracaoColunaCodigoItem.AutoSize = False
        Me.cboConfiguracaoColunaCodigoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaCodigoItem.Location = New System.Drawing.Point(9, 74)
        Me.cboConfiguracaoColunaCodigoItem.Name = "cboConfiguracaoColunaCodigoItem"
        Me.cboConfiguracaoColunaCodigoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaCodigoItem.Size = New System.Drawing.Size(140, 20)
        Me.cboConfiguracaoColunaCodigoItem.TabIndex = 4
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblDepositoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboDepositoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtLocalizacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblLocalizacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.cboGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCodigoProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblDepositoFiltro
        '
        Me.lblDepositoFiltro.AutoSize = True
        Me.lblDepositoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDepositoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblDepositoFiltro.Name = "lblDepositoFiltro"
        Me.lblDepositoFiltro.Size = New System.Drawing.Size(52, 14)
        Me.lblDepositoFiltro.TabIndex = 0
        Me.lblDepositoFiltro.Text = "Depósito:"
        '
        'cboDepositoFiltro
        '
        Me.cboDepositoFiltro.AutoSize = False
        Me.cboDepositoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDepositoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.cboDepositoFiltro.Name = "cboDepositoFiltro"
        Me.cboDepositoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDepositoFiltro.Size = New System.Drawing.Size(343, 20)
        Me.cboDepositoFiltro.TabIndex = 1
        '
        'txtLocalizacaoFiltro
        '
        Me.txtLocalizacaoFiltro.Location = New System.Drawing.Point(585, 74)
        Me.txtLocalizacaoFiltro.MaxLength = 35
        Me.txtLocalizacaoFiltro.Name = "txtLocalizacaoFiltro"
        Me.txtLocalizacaoFiltro.Size = New System.Drawing.Size(150, 20)
        Me.txtLocalizacaoFiltro.TabIndex = 9
        '
        'lblLocalizacaoFiltro
        '
        Me.lblLocalizacaoFiltro.AutoSize = True
        Me.lblLocalizacaoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLocalizacaoFiltro.Location = New System.Drawing.Point(582, 57)
        Me.lblLocalizacaoFiltro.Name = "lblLocalizacaoFiltro"
        Me.lblLocalizacaoFiltro.Size = New System.Drawing.Size(68, 14)
        Me.lblLocalizacaoFiltro.TabIndex = 8
        Me.lblLocalizacaoFiltro.Text = "Localização:"
        '
        'lblGrupoItemFiltro
        '
        Me.lblGrupoItemFiltro.AutoSize = True
        Me.lblGrupoItemFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGrupoItemFiltro.Location = New System.Drawing.Point(355, 17)
        Me.lblGrupoItemFiltro.Name = "lblGrupoItemFiltro"
        Me.lblGrupoItemFiltro.Size = New System.Drawing.Size(69, 14)
        Me.lblGrupoItemFiltro.TabIndex = 2
        Me.lblGrupoItemFiltro.Text = "Grupo - Item:"
        '
        'cboGrupoItemFiltro
        '
        Me.cboGrupoItemFiltro.AutoSize = False
        Me.cboGrupoItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoItemFiltro.Location = New System.Drawing.Point(358, 34)
        Me.cboGrupoItemFiltro.Name = "cboGrupoItemFiltro"
        Me.cboGrupoItemFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItemFiltro.Size = New System.Drawing.Size(377, 20)
        Me.cboGrupoItemFiltro.TabIndex = 3
        '
        'txtCodigoProdutoFiltro
        '
        Me.txtCodigoProdutoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtCodigoProdutoFiltro.MaxLength = 60
        Me.txtCodigoProdutoFiltro.Name = "txtCodigoProdutoFiltro"
        Me.txtCodigoProdutoFiltro.Size = New System.Drawing.Size(150, 20)
        Me.txtCodigoProdutoFiltro.TabIndex = 5
        '
        'lblCodigoProdutoFiltro
        '
        Me.lblCodigoProdutoFiltro.AutoSize = True
        Me.lblCodigoProdutoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProdutoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblCodigoProdutoFiltro.Name = "lblCodigoProdutoFiltro"
        Me.lblCodigoProdutoFiltro.Size = New System.Drawing.Size(83, 14)
        Me.lblCodigoProdutoFiltro.TabIndex = 4
        Me.lblCodigoProdutoFiltro.Text = "Código Produto:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 10
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(165, 74)
        Me.txtDescricaoFiltro.MaxLength = 120
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(414, 20)
        Me.txtDescricaoFiltro.TabIndex = 7
        '
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(162, 57)
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        Me.lblDescricaoFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoFiltro.TabIndex = 6
        Me.lblDescricaoFiltro.Text = "Descrição:"
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.Location = New System.Drawing.Point(8, 223)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 257)
        Me.grdListagem.TabIndex = 2
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
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 5
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(603, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 0
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
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
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'usrEstLocalizacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrEstLocalizacao"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpExcel.ResumeLayout(False)
        Me.grpExcel.PerformLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtLocalizacaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblLocalizacaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblGrupoItemFiltro As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItemFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtCodigoProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpExcel As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtLinhaInicio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtArquivoExcel As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblLinhaInicio As System.Windows.Forms.Label
    Private WithEvents btnArquivoExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboConfiguracaoColunaLocalizacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblArquivoExcel As System.Windows.Forms.Label
    Friend WithEvents lblConfiguracaoColunaLocalizacao As System.Windows.Forms.Label
    Friend WithEvents lblConfiguracaoColunaCodigoItem As System.Windows.Forms.Label
    Friend WithEvents cboConfiguracaoColunaCodigoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDepositoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboDepositoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents txtPlanilha As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPlanilha As System.Windows.Forms.Label

End Class
