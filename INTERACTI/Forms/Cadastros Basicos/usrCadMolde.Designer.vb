<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadMolde
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadMolde))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdMaquina_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdMaquina_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdProduto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProduto_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdQualidade_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdQualidade_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivo_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings2 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings3 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings4 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblNumeroCavidadesFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroCavidadesFiltro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCodigoFiltro = New System.Windows.Forms.Label()
        Me.txtCodigoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagMaquina = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridMaquina = New System.Windows.Forms.Button()
        Me.btnAgruparGridMaquina = New System.Windows.Forms.Button()
        Me.grpMaquina = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDescricaoMaquina = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoMaquina = New System.Windows.Forms.Label()
        Me.btnCadastrarMaquina = New System.Windows.Forms.Button()
        Me.lblCodigoMaquina = New System.Windows.Forms.Label()
        Me.cboCodigoMaquina = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcluirMaquina = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirMaquina = New Janus.Windows.EditControls.UIButton()
        Me.btnConfigurarGridMaquina = New System.Windows.Forms.Button()
        Me.grdMaquina = New Janus.Windows.GridEX.GridEX()
        Me.pagProduto = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridProduto = New System.Windows.Forms.Button()
        Me.btnAgruparGridProduto = New System.Windows.Forms.Button()
        Me.grpProduto = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.lblNumeroCavidadesProduto = New System.Windows.Forms.Label()
        Me.txtNumeroCavidadesProduto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtDescricaoProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoProduto = New System.Windows.Forms.Label()
        Me.btnCadastrarProduto = New System.Windows.Forms.Button()
        Me.lblCodigoProduto = New System.Windows.Forms.Label()
        Me.cboCodigoProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcluirProduto = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirProduto = New Janus.Windows.EditControls.UIButton()
        Me.btnConfigurarGridProduto = New System.Windows.Forms.Button()
        Me.grdProduto = New Janus.Windows.GridEX.GridEX()
        Me.pagQualidade = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridQualidade = New System.Windows.Forms.Button()
        Me.btnAgruparGridQualidade = New System.Windows.Forms.Button()
        Me.btnConfigurarGridQualidade = New System.Windows.Forms.Button()
        Me.grdQualidade = New Janus.Windows.GridEX.GridEX()
        Me.grpQualidade = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarCentroTrabalho = New System.Windows.Forms.Button()
        Me.lblCentroTrabalho = New System.Windows.Forms.Label()
        Me.cboCentroTrabalho = New Janus.Windows.EditControls.UIComboBox()
        Me.lblApontaQualidade = New System.Windows.Forms.Label()
        Me.cboApontaQualidade = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFrequenciaQualidade = New System.Windows.Forms.Label()
        Me.txtFrequenciaQualidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorMaximoQualidade = New System.Windows.Forms.Label()
        Me.txtValorMaximoQualidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorMinimoQualidade = New System.Windows.Forms.Label()
        Me.txtValorMinimoQualidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorNominalQualidade = New System.Windows.Forms.Label()
        Me.txtObservacaoQualidade = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.cboCaracteristicaInspecionarQualidade = New Janus.Windows.EditControls.UIComboBox()
        Me.txtValorNominalQualidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblObservacaoQualidade = New System.Windows.Forms.Label()
        Me.lblCaracteristicaInspecionarQualidade = New System.Windows.Forms.Label()
        Me.btnCadastrarCaracteristicaInspecionarQualidade = New System.Windows.Forms.Button()
        Me.btnExcluirQualidade = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirQualidade = New Janus.Windows.EditControls.UIButton()
        Me.pagArquivo = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridArquivo = New System.Windows.Forms.Button()
        Me.btnAgruparGridArquivo = New System.Windows.Forms.Button()
        Me.btnConfigurarGridArquivo = New System.Windows.Forms.Button()
        Me.grpArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblRevisaoArquivo = New System.Windows.Forms.Label()
        Me.txtRevisaoArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnCadastrarTipoArquivo = New System.Windows.Forms.Button()
        Me.lblTipoArquivo = New System.Windows.Forms.Label()
        Me.cboTipoArquivo = New Janus.Windows.EditControls.UIComboBox()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnExcluirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.txtDescricaoArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoArquivo = New System.Windows.Forms.Label()
        Me.grdArquivo = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtReferencia = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtTempoMaquina = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtTempoMaoObra = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtTempoSetupMaquina = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.lblTempoMaquina = New System.Windows.Forms.Label()
        Me.lblTempoMaoObra = New System.Windows.Forms.Label()
        Me.lblTempoSetupMaquina = New System.Windows.Forms.Label()
        Me.lblPerdaCompulsoria = New System.Windows.Forms.Label()
        Me.txtPerdaCompulsoria = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroCavidades = New System.Windows.Forms.Label()
        Me.txtNumeroCavidades = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.lblConjunto = New System.Windows.Forms.Label()
        Me.txtConjunto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagMaquina.SuspendLayout()
        CType(Me.grpMaquina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMaquina.SuspendLayout()
        CType(Me.grdMaquina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagProduto.SuspendLayout()
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProduto.SuspendLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagQualidade.SuspendLayout()
        CType(Me.grdQualidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpQualidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpQualidade.SuspendLayout()
        Me.pagArquivo.SuspendLayout()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Molde"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 92
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
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
        Me.btnAgruparGrid.TabIndex = 6
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
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblNumeroCavidadesFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroCavidadesFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCodigoFiltro)
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
        'lblNumeroCavidadesFiltro
        '
        Me.lblNumeroCavidadesFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroCavidadesFiltro.AutoSize = True
        Me.lblNumeroCavidadesFiltro.Location = New System.Drawing.Point(679, 17)
        Me.lblNumeroCavidadesFiltro.Name = "lblNumeroCavidadesFiltro"
        Me.lblNumeroCavidadesFiltro.Size = New System.Drawing.Size(76, 14)
        Me.lblNumeroCavidadesFiltro.TabIndex = 4
        Me.lblNumeroCavidadesFiltro.Text = "Nº Cavidades:"
        '
        'txtNumeroCavidadesFiltro
        '
        Me.txtNumeroCavidadesFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroCavidadesFiltro.DecimalDigits = 0
        Me.txtNumeroCavidadesFiltro.Location = New System.Drawing.Point(682, 34)
        Me.txtNumeroCavidadesFiltro.Name = "txtNumeroCavidadesFiltro"
        Me.txtNumeroCavidadesFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroCavidadesFiltro.TabIndex = 5
        Me.txtNumeroCavidadesFiltro.Text = "0"
        Me.txtNumeroCavidadesFiltro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtNumeroCavidadesFiltro.Value = New Decimal(New Integer() {0, 0, 0, 0})
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
        'txtCodigoFiltro
        '
        Me.txtCodigoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtCodigoFiltro.MaxLength = 30
        Me.txtCodigoFiltro.Name = "txtCodigoFiltro"
        Me.txtCodigoFiltro.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigoFiltro.TabIndex = 1
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(135, 34)
        Me.txtDescricaoFiltro.MaxLength = 100
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(541, 20)
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
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 6
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
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 3
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.novo
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
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.excluir
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
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 3
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 76)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 404)
        Me.grdListagem.TabIndex = 4
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Molde"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 113)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 367)
        Me.tabDados.TabIndex = 1
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagMaquina, Me.pagProduto, Me.pagQualidade, Me.pagArquivo})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagMaquina
        '
        Me.pagMaquina.Controls.Add(Me.btnExcelGridMaquina)
        Me.pagMaquina.Controls.Add(Me.btnAgruparGridMaquina)
        Me.pagMaquina.Controls.Add(Me.grpMaquina)
        Me.pagMaquina.Controls.Add(Me.btnConfigurarGridMaquina)
        Me.pagMaquina.Controls.Add(Me.grdMaquina)
        Me.pagMaquina.Key = "pagMaquina"
        Me.pagMaquina.Location = New System.Drawing.Point(1, 22)
        Me.pagMaquina.Name = "pagMaquina"
        Me.pagMaquina.Size = New System.Drawing.Size(895, 344)
        Me.pagMaquina.TabStop = True
        Me.pagMaquina.Text = "Máquina / Equipamento"
        '
        'btnExcelGridMaquina
        '
        Me.btnExcelGridMaquina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridMaquina.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridMaquina.FlatAppearance.BorderSize = 0
        Me.btnExcelGridMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridMaquina.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridMaquina.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridMaquina.Location = New System.Drawing.Point(57, 318)
        Me.btnExcelGridMaquina.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridMaquina.Name = "btnExcelGridMaquina"
        Me.btnExcelGridMaquina.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridMaquina.TabIndex = 92
        Me.btnExcelGridMaquina.TabStop = False
        Me.btnExcelGridMaquina.UseVisualStyleBackColor = False
        '
        'btnAgruparGridMaquina
        '
        Me.btnAgruparGridMaquina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridMaquina.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridMaquina.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridMaquina.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridMaquina.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridMaquina.Location = New System.Drawing.Point(33, 318)
        Me.btnAgruparGridMaquina.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridMaquina.Name = "btnAgruparGridMaquina"
        Me.btnAgruparGridMaquina.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridMaquina.TabIndex = 9
        Me.btnAgruparGridMaquina.TabStop = False
        Me.btnAgruparGridMaquina.UseVisualStyleBackColor = False
        '
        'grpMaquina
        '
        Me.grpMaquina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMaquina.BackColor = System.Drawing.Color.Transparent
        Me.grpMaquina.Controls.Add(Me.txtDescricaoMaquina)
        Me.grpMaquina.Controls.Add(Me.lblDescricaoMaquina)
        Me.grpMaquina.Controls.Add(Me.btnCadastrarMaquina)
        Me.grpMaquina.Controls.Add(Me.lblCodigoMaquina)
        Me.grpMaquina.Controls.Add(Me.cboCodigoMaquina)
        Me.grpMaquina.Controls.Add(Me.btnExcluirMaquina)
        Me.grpMaquina.Controls.Add(Me.btnInserirMaquina)
        Me.grpMaquina.Location = New System.Drawing.Point(8, 3)
        Me.grpMaquina.Name = "grpMaquina"
        Me.grpMaquina.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMaquina.Size = New System.Drawing.Size(879, 64)
        Me.grpMaquina.TabIndex = 6
        Me.grpMaquina.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpMaquina.VisualStyleManager = Me.vsmMain
        '
        'txtDescricaoMaquina
        '
        Me.txtDescricaoMaquina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoMaquina.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoMaquina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoMaquina.Location = New System.Drawing.Point(165, 34)
        Me.txtDescricaoMaquina.MaxLength = 100
        Me.txtDescricaoMaquina.Name = "txtDescricaoMaquina"
        Me.txtDescricaoMaquina.ReadOnly = True
        Me.txtDescricaoMaquina.Size = New System.Drawing.Size(502, 20)
        Me.txtDescricaoMaquina.TabIndex = 5
        Me.txtDescricaoMaquina.TabStop = False
        '
        'lblDescricaoMaquina
        '
        Me.lblDescricaoMaquina.AutoSize = True
        Me.lblDescricaoMaquina.Location = New System.Drawing.Point(162, 17)
        Me.lblDescricaoMaquina.Name = "lblDescricaoMaquina"
        Me.lblDescricaoMaquina.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoMaquina.TabIndex = 4
        Me.lblDescricaoMaquina.Text = "Descrição:"
        '
        'btnCadastrarMaquina
        '
        Me.btnCadastrarMaquina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarMaquina.FlatAppearance.BorderSize = 0
        Me.btnCadastrarMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarMaquina.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarMaquina.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarMaquina.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarMaquina.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarMaquina.Name = "btnCadastrarMaquina"
        Me.btnCadastrarMaquina.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarMaquina.TabIndex = 0
        Me.btnCadastrarMaquina.TabStop = False
        Me.btnCadastrarMaquina.UseVisualStyleBackColor = True
        '
        'lblCodigoMaquina
        '
        Me.lblCodigoMaquina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCodigoMaquina.AutoSize = True
        Me.lblCodigoMaquina.Location = New System.Drawing.Point(25, 17)
        Me.lblCodigoMaquina.Name = "lblCodigoMaquina"
        Me.lblCodigoMaquina.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigoMaquina.TabIndex = 1
        Me.lblCodigoMaquina.Text = "Código:"
        '
        'cboCodigoMaquina
        '
        Me.cboCodigoMaquina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboCodigoMaquina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCodigoMaquina.Location = New System.Drawing.Point(9, 34)
        Me.cboCodigoMaquina.Name = "cboCodigoMaquina"
        Me.cboCodigoMaquina.Size = New System.Drawing.Size(150, 20)
        Me.cboCodigoMaquina.TabIndex = 3
        '
        'btnExcluirMaquina
        '
        Me.btnExcluirMaquina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirMaquina.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirMaquina.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirMaquina.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirMaquina.Location = New System.Drawing.Point(779, 31)
        Me.btnExcluirMaquina.Name = "btnExcluirMaquina"
        Me.btnExcluirMaquina.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirMaquina.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirMaquina.TabIndex = 8
        Me.btnExcluirMaquina.Text = "Excluir"
        Me.btnExcluirMaquina.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirMaquina
        '
        Me.btnInserirMaquina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirMaquina.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserirMaquina.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirMaquina.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirMaquina.Location = New System.Drawing.Point(682, 31)
        Me.btnInserirMaquina.Name = "btnInserirMaquina"
        Me.btnInserirMaquina.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirMaquina.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirMaquina.TabIndex = 7
        Me.btnInserirMaquina.Text = "Inserir"
        Me.btnInserirMaquina.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnConfigurarGridMaquina
        '
        Me.btnConfigurarGridMaquina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridMaquina.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridMaquina.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridMaquina.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridMaquina.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridMaquina.Location = New System.Drawing.Point(9, 318)
        Me.btnConfigurarGridMaquina.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridMaquina.Name = "btnConfigurarGridMaquina"
        Me.btnConfigurarGridMaquina.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridMaquina.TabIndex = 8
        Me.btnConfigurarGridMaquina.TabStop = False
        Me.btnConfigurarGridMaquina.UseVisualStyleBackColor = False
        '
        'grdMaquina
        '
        Me.grdMaquina.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdMaquina.AlternatingColors = True
        Me.grdMaquina.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdMaquina.ColumnAutoResize = True
        grdMaquina_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdMaquina_DesignTimeLayout_Reference_0.Instance"), Object)
        grdMaquina_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdMaquina_DesignTimeLayout_Reference_0})
        grdMaquina_DesignTimeLayout.LayoutString = resources.GetString("grdMaquina_DesignTimeLayout.LayoutString")
        Me.grdMaquina.DesignTimeLayout = grdMaquina_DesignTimeLayout
        Me.grdMaquina.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdMaquina.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdMaquina.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdMaquina.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdMaquina.FrozenColumns = 3
        Me.grdMaquina.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdMaquina.GroupByBoxVisible = False
        Me.grdMaquina.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdMaquina.Location = New System.Drawing.Point(8, 76)
        Me.grdMaquina.Name = "grdMaquina"
        Me.grdMaquina.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdMaquina.RecordNavigator = True
        Me.grdMaquina.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdMaquina.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdMaquina.Size = New System.Drawing.Size(879, 259)
        Me.grdMaquina.TabIndex = 7
        Me.grdMaquina.TabStop = False
        Me.grdMaquina.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdMaquina.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdMaquina.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdMaquina.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdMaquina.VisualStyleManager = Me.vsmMain
        '
        'pagProduto
        '
        Me.pagProduto.Controls.Add(Me.btnExcelGridProduto)
        Me.pagProduto.Controls.Add(Me.btnAgruparGridProduto)
        Me.pagProduto.Controls.Add(Me.grpProduto)
        Me.pagProduto.Controls.Add(Me.btnConfigurarGridProduto)
        Me.pagProduto.Controls.Add(Me.grdProduto)
        Me.pagProduto.Key = "pagProduto"
        Me.pagProduto.Location = New System.Drawing.Point(1, 22)
        Me.pagProduto.Name = "pagProduto"
        Me.pagProduto.Size = New System.Drawing.Size(895, 344)
        Me.pagProduto.TabStop = True
        Me.pagProduto.Text = "Produtos"
        '
        'btnExcelGridProduto
        '
        Me.btnExcelGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridProduto.FlatAppearance.BorderSize = 0
        Me.btnExcelGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridProduto.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridProduto.Location = New System.Drawing.Point(57, 318)
        Me.btnExcelGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridProduto.Name = "btnExcelGridProduto"
        Me.btnExcelGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridProduto.TabIndex = 92
        Me.btnExcelGridProduto.TabStop = False
        Me.btnExcelGridProduto.UseVisualStyleBackColor = False
        '
        'btnAgruparGridProduto
        '
        Me.btnAgruparGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridProduto.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridProduto.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridProduto.Location = New System.Drawing.Point(33, 318)
        Me.btnAgruparGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridProduto.Name = "btnAgruparGridProduto"
        Me.btnAgruparGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridProduto.TabIndex = 5
        Me.btnAgruparGridProduto.TabStop = False
        Me.btnAgruparGridProduto.UseVisualStyleBackColor = False
        '
        'grpProduto
        '
        Me.grpProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProduto.BackColor = System.Drawing.Color.Transparent
        Me.grpProduto.Controls.Add(Me.btnProcurarProduto)
        Me.grpProduto.Controls.Add(Me.lblNumeroCavidadesProduto)
        Me.grpProduto.Controls.Add(Me.txtNumeroCavidadesProduto)
        Me.grpProduto.Controls.Add(Me.txtDescricaoProduto)
        Me.grpProduto.Controls.Add(Me.lblDescricaoProduto)
        Me.grpProduto.Controls.Add(Me.btnCadastrarProduto)
        Me.grpProduto.Controls.Add(Me.lblCodigoProduto)
        Me.grpProduto.Controls.Add(Me.cboCodigoProduto)
        Me.grpProduto.Controls.Add(Me.btnExcluirProduto)
        Me.grpProduto.Controls.Add(Me.btnInserirProduto)
        Me.grpProduto.Controls.Add(Me.lblConjunto)
        Me.grpProduto.Controls.Add(Me.txtConjunto)
        Me.grpProduto.Location = New System.Drawing.Point(8, 3)
        Me.grpProduto.Name = "grpProduto"
        Me.grpProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpProduto.Size = New System.Drawing.Size(879, 64)
        Me.grpProduto.TabIndex = 0
        Me.grpProduto.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpProduto.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProduto.Image = Global.INTERACTI.My.Resources.search
        Me.btnProcurarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProduto.Location = New System.Drawing.Point(248, 15)
        Me.btnProcurarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProduto.TabIndex = 2
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'lblNumeroCavidadesProduto
        '
        Me.lblNumeroCavidadesProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroCavidadesProduto.AutoSize = True
        Me.lblNumeroCavidadesProduto.Location = New System.Drawing.Point(564, 17)
        Me.lblNumeroCavidadesProduto.Name = "lblNumeroCavidadesProduto"
        Me.lblNumeroCavidadesProduto.Size = New System.Drawing.Size(76, 14)
        Me.lblNumeroCavidadesProduto.TabIndex = 5
        Me.lblNumeroCavidadesProduto.Text = "Nº Cavidades:"
        '
        'txtNumeroCavidadesProduto
        '
        Me.txtNumeroCavidadesProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroCavidadesProduto.DecimalDigits = 0
        Me.txtNumeroCavidadesProduto.Location = New System.Drawing.Point(567, 34)
        Me.txtNumeroCavidadesProduto.Name = "txtNumeroCavidadesProduto"
        Me.txtNumeroCavidadesProduto.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroCavidadesProduto.TabIndex = 6
        Me.txtNumeroCavidadesProduto.Text = "0"
        Me.txtNumeroCavidadesProduto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtDescricaoProduto
        '
        Me.txtDescricaoProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoProduto.Location = New System.Drawing.Point(271, 34)
        Me.txtDescricaoProduto.MaxLength = 100
        Me.txtDescricaoProduto.Name = "txtDescricaoProduto"
        Me.txtDescricaoProduto.ReadOnly = True
        Me.txtDescricaoProduto.Size = New System.Drawing.Size(290, 20)
        Me.txtDescricaoProduto.TabIndex = 5
        Me.txtDescricaoProduto.TabStop = False
        '
        'lblDescricaoProduto
        '
        Me.lblDescricaoProduto.AutoSize = True
        Me.lblDescricaoProduto.Location = New System.Drawing.Point(268, 17)
        Me.lblDescricaoProduto.Name = "lblDescricaoProduto"
        Me.lblDescricaoProduto.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoProduto.TabIndex = 4
        Me.lblDescricaoProduto.Text = "Descrição:"
        '
        'btnCadastrarProduto
        '
        Me.btnCadastrarProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarProduto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarProduto.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarProduto.Location = New System.Drawing.Point(115, 18)
        Me.btnCadastrarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarProduto.Name = "btnCadastrarProduto"
        Me.btnCadastrarProduto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarProduto.TabIndex = 0
        Me.btnCadastrarProduto.TabStop = False
        Me.btnCadastrarProduto.UseVisualStyleBackColor = True
        '
        'lblCodigoProduto
        '
        Me.lblCodigoProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCodigoProduto.AutoSize = True
        Me.lblCodigoProduto.Location = New System.Drawing.Point(131, 17)
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        Me.lblCodigoProduto.Size = New System.Drawing.Size(83, 14)
        Me.lblCodigoProduto.TabIndex = 1
        Me.lblCodigoProduto.Text = "Código Produto:"
        '
        'cboCodigoProduto
        '
        Me.cboCodigoProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboCodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCodigoProduto.Location = New System.Drawing.Point(115, 34)
        Me.cboCodigoProduto.Name = "cboCodigoProduto"
        Me.cboCodigoProduto.Size = New System.Drawing.Size(150, 20)
        Me.cboCodigoProduto.TabIndex = 3
        '
        'btnExcluirProduto
        '
        Me.btnExcluirProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirProduto.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirProduto.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirProduto.Location = New System.Drawing.Point(779, 31)
        Me.btnExcluirProduto.Name = "btnExcluirProduto"
        Me.btnExcluirProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirProduto.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirProduto.TabIndex = 8
        Me.btnExcluirProduto.Text = "Excluir"
        Me.btnExcluirProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirProduto
        '
        Me.btnInserirProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirProduto.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserirProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirProduto.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirProduto.Location = New System.Drawing.Point(682, 31)
        Me.btnInserirProduto.Name = "btnInserirProduto"
        Me.btnInserirProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirProduto.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirProduto.TabIndex = 7
        Me.btnInserirProduto.Text = "Inserir"
        Me.btnInserirProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnConfigurarGridProduto
        '
        Me.btnConfigurarGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridProduto.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridProduto.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridProduto.Location = New System.Drawing.Point(9, 318)
        Me.btnConfigurarGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridProduto.Name = "btnConfigurarGridProduto"
        Me.btnConfigurarGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridProduto.TabIndex = 2
        Me.btnConfigurarGridProduto.TabStop = False
        Me.btnConfigurarGridProduto.UseVisualStyleBackColor = False
        '
        'grdProduto
        '
        Me.grdProduto.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdProduto.AlternatingColors = True
        Me.grdProduto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProduto.ColumnAutoResize = True
        grdProduto_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdProduto_DesignTimeLayout_Reference_0.Instance"), Object)
        grdProduto_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdProduto_DesignTimeLayout_Reference_0})
        grdProduto_DesignTimeLayout.LayoutString = resources.GetString("grdProduto_DesignTimeLayout.LayoutString")
        Me.grdProduto.DesignTimeLayout = grdProduto_DesignTimeLayout
        Me.grdProduto.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdProduto.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdProduto.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdProduto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProduto.FrozenColumns = 3
        Me.grdProduto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProduto.GroupByBoxVisible = False
        Me.grdProduto.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdProduto.Location = New System.Drawing.Point(8, 76)
        Me.grdProduto.Name = "grdProduto"
        Me.grdProduto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProduto.RecordNavigator = True
        Me.grdProduto.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProduto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProduto.Size = New System.Drawing.Size(879, 259)
        Me.grdProduto.TabIndex = 1
        Me.grdProduto.TabStop = False
        Me.grdProduto.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdProduto.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdProduto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdProduto.VisualStyleManager = Me.vsmMain
        '
        'pagQualidade
        '
        Me.pagQualidade.Controls.Add(Me.btnExcelGridQualidade)
        Me.pagQualidade.Controls.Add(Me.btnAgruparGridQualidade)
        Me.pagQualidade.Controls.Add(Me.btnConfigurarGridQualidade)
        Me.pagQualidade.Controls.Add(Me.grdQualidade)
        Me.pagQualidade.Controls.Add(Me.grpQualidade)
        Me.pagQualidade.Key = "pagQualidade"
        Me.pagQualidade.Location = New System.Drawing.Point(1, 22)
        Me.pagQualidade.Name = "pagQualidade"
        Me.pagQualidade.Size = New System.Drawing.Size(895, 344)
        Me.pagQualidade.TabStop = True
        Me.pagQualidade.Text = "Dados de Qualidade"
        '
        'btnExcelGridQualidade
        '
        Me.btnExcelGridQualidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridQualidade.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridQualidade.FlatAppearance.BorderSize = 0
        Me.btnExcelGridQualidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridQualidade.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridQualidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridQualidade.Location = New System.Drawing.Point(57, 318)
        Me.btnExcelGridQualidade.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridQualidade.Name = "btnExcelGridQualidade"
        Me.btnExcelGridQualidade.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridQualidade.TabIndex = 92
        Me.btnExcelGridQualidade.TabStop = False
        Me.btnExcelGridQualidade.UseVisualStyleBackColor = False
        '
        'btnAgruparGridQualidade
        '
        Me.btnAgruparGridQualidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridQualidade.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridQualidade.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridQualidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridQualidade.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridQualidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridQualidade.Location = New System.Drawing.Point(33, 318)
        Me.btnAgruparGridQualidade.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridQualidade.Name = "btnAgruparGridQualidade"
        Me.btnAgruparGridQualidade.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridQualidade.TabIndex = 3
        Me.btnAgruparGridQualidade.TabStop = False
        Me.btnAgruparGridQualidade.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridQualidade
        '
        Me.btnConfigurarGridQualidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridQualidade.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridQualidade.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridQualidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridQualidade.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridQualidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridQualidade.Location = New System.Drawing.Point(9, 318)
        Me.btnConfigurarGridQualidade.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridQualidade.Name = "btnConfigurarGridQualidade"
        Me.btnConfigurarGridQualidade.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridQualidade.TabIndex = 2
        Me.btnConfigurarGridQualidade.TabStop = False
        Me.btnConfigurarGridQualidade.UseVisualStyleBackColor = False
        '
        'grdQualidade
        '
        Me.grdQualidade.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdQualidade.AlternatingColors = True
        Me.grdQualidade.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdQualidade_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdQualidade_DesignTimeLayout_Reference_0.Instance"), Object)
        grdQualidade_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdQualidade_DesignTimeLayout_Reference_0})
        grdQualidade_DesignTimeLayout.LayoutString = resources.GetString("grdQualidade_DesignTimeLayout.LayoutString")
        Me.grdQualidade.DesignTimeLayout = grdQualidade_DesignTimeLayout
        Me.grdQualidade.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdQualidade.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdQualidade.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdQualidade.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdQualidade.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdQualidade.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdQualidade.GroupByBoxVisible = False
        Me.grdQualidade.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdQualidade.Location = New System.Drawing.Point(8, 116)
        Me.grdQualidade.Name = "grdQualidade"
        Me.grdQualidade.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdQualidade.RecordNavigator = True
        Me.grdQualidade.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdQualidade.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdQualidade.Size = New System.Drawing.Size(879, 219)
        Me.grdQualidade.TabIndex = 1
        Me.grdQualidade.TabStop = False
        Me.grdQualidade.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdQualidade.VisualStyleManager = Me.vsmMain
        '
        'grpQualidade
        '
        Me.grpQualidade.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpQualidade.BackColor = System.Drawing.Color.Transparent
        Me.grpQualidade.Controls.Add(Me.btnCadastrarCentroTrabalho)
        Me.grpQualidade.Controls.Add(Me.lblCentroTrabalho)
        Me.grpQualidade.Controls.Add(Me.cboCentroTrabalho)
        Me.grpQualidade.Controls.Add(Me.lblApontaQualidade)
        Me.grpQualidade.Controls.Add(Me.cboApontaQualidade)
        Me.grpQualidade.Controls.Add(Me.lblFrequenciaQualidade)
        Me.grpQualidade.Controls.Add(Me.txtFrequenciaQualidade)
        Me.grpQualidade.Controls.Add(Me.lblValorMaximoQualidade)
        Me.grpQualidade.Controls.Add(Me.txtValorMaximoQualidade)
        Me.grpQualidade.Controls.Add(Me.lblValorMinimoQualidade)
        Me.grpQualidade.Controls.Add(Me.txtValorMinimoQualidade)
        Me.grpQualidade.Controls.Add(Me.lblValorNominalQualidade)
        Me.grpQualidade.Controls.Add(Me.txtObservacaoQualidade)
        Me.grpQualidade.Controls.Add(Me.cboCaracteristicaInspecionarQualidade)
        Me.grpQualidade.Controls.Add(Me.txtValorNominalQualidade)
        Me.grpQualidade.Controls.Add(Me.lblObservacaoQualidade)
        Me.grpQualidade.Controls.Add(Me.lblCaracteristicaInspecionarQualidade)
        Me.grpQualidade.Controls.Add(Me.btnCadastrarCaracteristicaInspecionarQualidade)
        Me.grpQualidade.Controls.Add(Me.btnExcluirQualidade)
        Me.grpQualidade.Controls.Add(Me.btnInserirQualidade)
        Me.grpQualidade.Location = New System.Drawing.Point(8, 3)
        Me.grpQualidade.Name = "grpQualidade"
        Me.grpQualidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpQualidade.Size = New System.Drawing.Size(879, 104)
        Me.grpQualidade.TabIndex = 0
        Me.grpQualidade.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpQualidade.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarCentroTrabalho
        '
        Me.btnCadastrarCentroTrabalho.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroTrabalho.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroTrabalho.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarCentroTrabalho.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCentroTrabalho.Location = New System.Drawing.Point(275, 18)
        Me.btnCadastrarCentroTrabalho.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroTrabalho.Name = "btnCadastrarCentroTrabalho"
        Me.btnCadastrarCentroTrabalho.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroTrabalho.TabIndex = 3
        Me.btnCadastrarCentroTrabalho.TabStop = False
        Me.btnCadastrarCentroTrabalho.UseVisualStyleBackColor = True
        '
        'lblCentroTrabalho
        '
        Me.lblCentroTrabalho.AutoSize = True
        Me.lblCentroTrabalho.Location = New System.Drawing.Point(291, 17)
        Me.lblCentroTrabalho.Name = "lblCentroTrabalho"
        Me.lblCentroTrabalho.Size = New System.Drawing.Size(87, 14)
        Me.lblCentroTrabalho.TabIndex = 4
        Me.lblCentroTrabalho.Text = "Centro Trabalho:"
        '
        'cboCentroTrabalho
        '
        Me.cboCentroTrabalho.Location = New System.Drawing.Point(275, 34)
        Me.cboCentroTrabalho.Name = "cboCentroTrabalho"
        Me.cboCentroTrabalho.Size = New System.Drawing.Size(258, 20)
        Me.cboCentroTrabalho.TabIndex = 5
        '
        'lblApontaQualidade
        '
        Me.lblApontaQualidade.AutoSize = True
        Me.lblApontaQualidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblApontaQualidade.Location = New System.Drawing.Point(6, 57)
        Me.lblApontaQualidade.Name = "lblApontaQualidade"
        Me.lblApontaQualidade.Size = New System.Drawing.Size(45, 14)
        Me.lblApontaQualidade.TabIndex = 6
        Me.lblApontaQualidade.Text = "Aponta:"
        '
        'cboApontaQualidade
        '
        Me.cboApontaQualidade.Location = New System.Drawing.Point(9, 74)
        Me.cboApontaQualidade.Name = "cboApontaQualidade"
        Me.cboApontaQualidade.Size = New System.Drawing.Size(100, 20)
        Me.cboApontaQualidade.TabIndex = 7
        '
        'lblFrequenciaQualidade
        '
        Me.lblFrequenciaQualidade.AutoSize = True
        Me.lblFrequenciaQualidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFrequenciaQualidade.Location = New System.Drawing.Point(430, 57)
        Me.lblFrequenciaQualidade.Name = "lblFrequenciaQualidade"
        Me.lblFrequenciaQualidade.Size = New System.Drawing.Size(64, 14)
        Me.lblFrequenciaQualidade.TabIndex = 14
        Me.lblFrequenciaQualidade.Text = "Frequência:"
        '
        'txtFrequenciaQualidade
        '
        Me.txtFrequenciaQualidade.DecimalDigits = 0
        Me.txtFrequenciaQualidade.Location = New System.Drawing.Point(433, 74)
        Me.txtFrequenciaQualidade.Name = "txtFrequenciaQualidade"
        Me.txtFrequenciaQualidade.Size = New System.Drawing.Size(100, 20)
        Me.txtFrequenciaQualidade.TabIndex = 15
        Me.txtFrequenciaQualidade.Text = "0"
        Me.txtFrequenciaQualidade.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblValorMaximoQualidade
        '
        Me.lblValorMaximoQualidade.AutoSize = True
        Me.lblValorMaximoQualidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValorMaximoQualidade.Location = New System.Drawing.Point(324, 57)
        Me.lblValorMaximoQualidade.Name = "lblValorMaximoQualidade"
        Me.lblValorMaximoQualidade.Size = New System.Drawing.Size(74, 14)
        Me.lblValorMaximoQualidade.TabIndex = 12
        Me.lblValorMaximoQualidade.Text = "Valor Máximo:"
        '
        'txtValorMaximoQualidade
        '
        Me.txtValorMaximoQualidade.DecimalDigits = 4
        Me.txtValorMaximoQualidade.Location = New System.Drawing.Point(327, 74)
        Me.txtValorMaximoQualidade.Name = "txtValorMaximoQualidade"
        Me.txtValorMaximoQualidade.Size = New System.Drawing.Size(100, 20)
        Me.txtValorMaximoQualidade.TabIndex = 13
        Me.txtValorMaximoQualidade.Text = "0,0000"
        Me.txtValorMaximoQualidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblValorMinimoQualidade
        '
        Me.lblValorMinimoQualidade.AutoSize = True
        Me.lblValorMinimoQualidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValorMinimoQualidade.Location = New System.Drawing.Point(218, 57)
        Me.lblValorMinimoQualidade.Name = "lblValorMinimoQualidade"
        Me.lblValorMinimoQualidade.Size = New System.Drawing.Size(70, 14)
        Me.lblValorMinimoQualidade.TabIndex = 10
        Me.lblValorMinimoQualidade.Text = "Valor Mínimo:"
        '
        'txtValorMinimoQualidade
        '
        Me.txtValorMinimoQualidade.DecimalDigits = 4
        Me.txtValorMinimoQualidade.Location = New System.Drawing.Point(221, 74)
        Me.txtValorMinimoQualidade.Name = "txtValorMinimoQualidade"
        Me.txtValorMinimoQualidade.Size = New System.Drawing.Size(100, 20)
        Me.txtValorMinimoQualidade.TabIndex = 11
        Me.txtValorMinimoQualidade.Text = "0,0000"
        Me.txtValorMinimoQualidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblValorNominalQualidade
        '
        Me.lblValorNominalQualidade.AutoSize = True
        Me.lblValorNominalQualidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValorNominalQualidade.Location = New System.Drawing.Point(112, 57)
        Me.lblValorNominalQualidade.Name = "lblValorNominalQualidade"
        Me.lblValorNominalQualidade.Size = New System.Drawing.Size(75, 14)
        Me.lblValorNominalQualidade.TabIndex = 8
        Me.lblValorNominalQualidade.Text = "Valor Nominal:"
        '
        'txtObservacaoQualidade
        '
        Me.txtObservacaoQualidade.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacaoQualidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacaoQualidade.Location = New System.Drawing.Point(539, 34)
        Me.txtObservacaoQualidade.MaxLength = 1000
        Me.txtObservacaoQualidade.Multiline = True
        Me.txtObservacaoQualidade.Name = "txtObservacaoQualidade"
        Me.txtObservacaoQualidade.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacaoQualidade.Size = New System.Drawing.Size(225, 60)
        Me.txtObservacaoQualidade.TabIndex = 17
        '
        'cboCaracteristicaInspecionarQualidade
        '
        Me.cboCaracteristicaInspecionarQualidade.Location = New System.Drawing.Point(9, 34)
        Me.cboCaracteristicaInspecionarQualidade.Name = "cboCaracteristicaInspecionarQualidade"
        Me.cboCaracteristicaInspecionarQualidade.Size = New System.Drawing.Size(260, 20)
        Me.cboCaracteristicaInspecionarQualidade.TabIndex = 2
        '
        'txtValorNominalQualidade
        '
        Me.txtValorNominalQualidade.DecimalDigits = 4
        Me.txtValorNominalQualidade.Location = New System.Drawing.Point(115, 74)
        Me.txtValorNominalQualidade.Name = "txtValorNominalQualidade"
        Me.txtValorNominalQualidade.Size = New System.Drawing.Size(100, 20)
        Me.txtValorNominalQualidade.TabIndex = 9
        Me.txtValorNominalQualidade.Text = "0,0000"
        Me.txtValorNominalQualidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblObservacaoQualidade
        '
        Me.lblObservacaoQualidade.AutoSize = True
        Me.lblObservacaoQualidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblObservacaoQualidade.Location = New System.Drawing.Point(536, 17)
        Me.lblObservacaoQualidade.Name = "lblObservacaoQualidade"
        Me.lblObservacaoQualidade.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacaoQualidade.TabIndex = 16
        Me.lblObservacaoQualidade.Text = "Observação:"
        '
        'lblCaracteristicaInspecionarQualidade
        '
        Me.lblCaracteristicaInspecionarQualidade.AutoSize = True
        Me.lblCaracteristicaInspecionarQualidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCaracteristicaInspecionarQualidade.Location = New System.Drawing.Point(25, 17)
        Me.lblCaracteristicaInspecionarQualidade.Name = "lblCaracteristicaInspecionarQualidade"
        Me.lblCaracteristicaInspecionarQualidade.Size = New System.Drawing.Size(148, 14)
        Me.lblCaracteristicaInspecionarQualidade.TabIndex = 1
        Me.lblCaracteristicaInspecionarQualidade.Text = "Características a Inspecionar"
        '
        'btnCadastrarCaracteristicaInspecionarQualidade
        '
        Me.btnCadastrarCaracteristicaInspecionarQualidade.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCaracteristicaInspecionarQualidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCaracteristicaInspecionarQualidade.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarCaracteristicaInspecionarQualidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCaracteristicaInspecionarQualidade.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarCaracteristicaInspecionarQualidade.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCaracteristicaInspecionarQualidade.Name = "btnCadastrarCaracteristicaInspecionarQualidade"
        Me.btnCadastrarCaracteristicaInspecionarQualidade.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCaracteristicaInspecionarQualidade.TabIndex = 0
        Me.btnCadastrarCaracteristicaInspecionarQualidade.TabStop = False
        Me.btnCadastrarCaracteristicaInspecionarQualidade.UseVisualStyleBackColor = True
        '
        'btnExcluirQualidade
        '
        Me.btnExcluirQualidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirQualidade.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirQualidade.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirQualidade.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirQualidade.Location = New System.Drawing.Point(779, 71)
        Me.btnExcluirQualidade.Name = "btnExcluirQualidade"
        Me.btnExcluirQualidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirQualidade.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirQualidade.TabIndex = 19
        Me.btnExcluirQualidade.Text = "Excluir"
        Me.btnExcluirQualidade.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirQualidade
        '
        Me.btnInserirQualidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirQualidade.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserirQualidade.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirQualidade.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirQualidade.Location = New System.Drawing.Point(779, 42)
        Me.btnInserirQualidade.Name = "btnInserirQualidade"
        Me.btnInserirQualidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirQualidade.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirQualidade.TabIndex = 18
        Me.btnInserirQualidade.Text = "Inserir"
        Me.btnInserirQualidade.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagArquivo
        '
        Me.pagArquivo.Controls.Add(Me.btnExcelGridArquivo)
        Me.pagArquivo.Controls.Add(Me.btnAgruparGridArquivo)
        Me.pagArquivo.Controls.Add(Me.btnConfigurarGridArquivo)
        Me.pagArquivo.Controls.Add(Me.grpArquivo)
        Me.pagArquivo.Controls.Add(Me.grdArquivo)
        Me.pagArquivo.Key = "pagArquivo"
        Me.pagArquivo.Location = New System.Drawing.Point(1, 22)
        Me.pagArquivo.Name = "pagArquivo"
        Me.pagArquivo.Size = New System.Drawing.Size(895, 344)
        Me.pagArquivo.TabStop = True
        Me.pagArquivo.Text = "Arquivos"
        '
        'btnExcelGridArquivo
        '
        Me.btnExcelGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnExcelGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridArquivo.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridArquivo.Location = New System.Drawing.Point(57, 318)
        Me.btnExcelGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridArquivo.Name = "btnExcelGridArquivo"
        Me.btnExcelGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridArquivo.TabIndex = 92
        Me.btnExcelGridArquivo.TabStop = False
        Me.btnExcelGridArquivo.UseVisualStyleBackColor = False
        '
        'btnAgruparGridArquivo
        '
        Me.btnAgruparGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridArquivo.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridArquivo.Location = New System.Drawing.Point(33, 318)
        Me.btnAgruparGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridArquivo.Name = "btnAgruparGridArquivo"
        Me.btnAgruparGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridArquivo.TabIndex = 4
        Me.btnAgruparGridArquivo.TabStop = False
        Me.btnAgruparGridArquivo.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridArquivo
        '
        Me.btnConfigurarGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridArquivo.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridArquivo.Location = New System.Drawing.Point(9, 318)
        Me.btnConfigurarGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridArquivo.Name = "btnConfigurarGridArquivo"
        Me.btnConfigurarGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridArquivo.TabIndex = 2
        Me.btnConfigurarGridArquivo.TabStop = False
        Me.btnConfigurarGridArquivo.UseVisualStyleBackColor = False
        '
        'grpArquivo
        '
        Me.grpArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpArquivo.Controls.Add(Me.lblRevisaoArquivo)
        Me.grpArquivo.Controls.Add(Me.txtRevisaoArquivo)
        Me.grpArquivo.Controls.Add(Me.btnCadastrarTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.lblTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.cboTipoArquivo)
        Me.grpArquivo.Controls.Add(Me.btnArquivo)
        Me.grpArquivo.Controls.Add(Me.lblArquivo)
        Me.grpArquivo.Controls.Add(Me.txtArquivo)
        Me.grpArquivo.Controls.Add(Me.btnExcluirArquivo)
        Me.grpArquivo.Controls.Add(Me.btnInserirArquivo)
        Me.grpArquivo.Controls.Add(Me.txtDescricaoArquivo)
        Me.grpArquivo.Controls.Add(Me.lblDescricaoArquivo)
        Me.grpArquivo.Location = New System.Drawing.Point(8, 3)
        Me.grpArquivo.Name = "grpArquivo"
        Me.grpArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpArquivo.Size = New System.Drawing.Size(879, 104)
        Me.grpArquivo.TabIndex = 0
        Me.grpArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpArquivo.VisualStyleManager = Me.vsmMain
        '
        'lblRevisaoArquivo
        '
        Me.lblRevisaoArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRevisaoArquivo.AutoSize = True
        Me.lblRevisaoArquivo.Location = New System.Drawing.Point(575, 17)
        Me.lblRevisaoArquivo.Name = "lblRevisaoArquivo"
        Me.lblRevisaoArquivo.Size = New System.Drawing.Size(49, 14)
        Me.lblRevisaoArquivo.TabIndex = 2
        Me.lblRevisaoArquivo.Text = "Revisão:"
        '
        'txtRevisaoArquivo
        '
        Me.txtRevisaoArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRevisaoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRevisaoArquivo.Location = New System.Drawing.Point(578, 34)
        Me.txtRevisaoArquivo.MaxLength = 5
        Me.txtRevisaoArquivo.Name = "txtRevisaoArquivo"
        Me.txtRevisaoArquivo.Size = New System.Drawing.Size(89, 20)
        Me.txtRevisaoArquivo.TabIndex = 3
        '
        'btnCadastrarTipoArquivo
        '
        Me.btnCadastrarTipoArquivo.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTipoArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTipoArquivo.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarTipoArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarTipoArquivo.Location = New System.Drawing.Point(9, 58)
        Me.btnCadastrarTipoArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarTipoArquivo.Name = "btnCadastrarTipoArquivo"
        Me.btnCadastrarTipoArquivo.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarTipoArquivo.TabIndex = 4
        Me.btnCadastrarTipoArquivo.TabStop = False
        Me.btnCadastrarTipoArquivo.UseVisualStyleBackColor = True
        '
        'lblTipoArquivo
        '
        Me.lblTipoArquivo.AutoSize = True
        Me.lblTipoArquivo.Location = New System.Drawing.Point(25, 57)
        Me.lblTipoArquivo.Name = "lblTipoArquivo"
        Me.lblTipoArquivo.Size = New System.Drawing.Size(85, 14)
        Me.lblTipoArquivo.TabIndex = 5
        Me.lblTipoArquivo.Text = "Tipo do Arquivo:"
        '
        'cboTipoArquivo
        '
        Me.cboTipoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoArquivo.Location = New System.Drawing.Point(9, 74)
        Me.cboTipoArquivo.Name = "cboTipoArquivo"
        Me.cboTipoArquivo.Size = New System.Drawing.Size(240, 20)
        Me.cboTipoArquivo.TabIndex = 6
        '
        'btnArquivo
        '
        Me.btnArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnArquivo.Location = New System.Drawing.Point(647, 74)
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivo.Size = New System.Drawing.Size(20, 20)
        Me.btnArquivo.TabIndex = 9
        Me.btnArquivo.Text = "..."
        Me.btnArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivo
        '
        Me.lblArquivo.AutoSize = True
        Me.lblArquivo.Location = New System.Drawing.Point(252, 57)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(48, 14)
        Me.lblArquivo.TabIndex = 7
        Me.lblArquivo.Text = "Arquivo:"
        '
        'txtArquivo
        '
        Me.txtArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivo.Location = New System.Drawing.Point(255, 74)
        Me.txtArquivo.MaxLength = 500
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(393, 20)
        Me.txtArquivo.TabIndex = 8
        Me.txtArquivo.TabStop = False
        '
        'btnExcluirArquivo
        '
        Me.btnExcluirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirArquivo.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirArquivo.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirArquivo.Location = New System.Drawing.Point(779, 71)
        Me.btnExcluirArquivo.Name = "btnExcluirArquivo"
        Me.btnExcluirArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirArquivo.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirArquivo.TabIndex = 11
        Me.btnExcluirArquivo.Text = "Excluir"
        Me.btnExcluirArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirArquivo
        '
        Me.btnInserirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirArquivo.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserirArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirArquivo.Location = New System.Drawing.Point(779, 42)
        Me.btnInserirArquivo.Name = "btnInserirArquivo"
        Me.btnInserirArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirArquivo.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirArquivo.TabIndex = 10
        Me.btnInserirArquivo.Text = "Inserir"
        Me.btnInserirArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtDescricaoArquivo
        '
        Me.txtDescricaoArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoArquivo.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricaoArquivo.MaxLength = 100
        Me.txtDescricaoArquivo.Name = "txtDescricaoArquivo"
        Me.txtDescricaoArquivo.Size = New System.Drawing.Size(563, 20)
        Me.txtDescricaoArquivo.TabIndex = 1
        '
        'lblDescricaoArquivo
        '
        Me.lblDescricaoArquivo.AutoSize = True
        Me.lblDescricaoArquivo.Location = New System.Drawing.Point(6, 17)
        Me.lblDescricaoArquivo.Name = "lblDescricaoArquivo"
        Me.lblDescricaoArquivo.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoArquivo.TabIndex = 0
        Me.lblDescricaoArquivo.Text = "Descrição:"
        '
        'grdArquivo
        '
        Me.grdArquivo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdArquivo.AlternatingColors = True
        Me.grdArquivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdArquivo.ColumnAutoResize = True
        grdArquivo_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdArquivo_DesignTimeLayout_Reference_0.Instance"), Object)
        grdArquivo_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdArquivo_DesignTimeLayout_Reference_1.Instance"), Object)
        grdArquivo_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdArquivo_DesignTimeLayout_Reference_0, grdArquivo_DesignTimeLayout_Reference_1})
        grdArquivo_DesignTimeLayout.LayoutString = resources.GetString("grdArquivo_DesignTimeLayout.LayoutString")
        Me.grdArquivo.DesignTimeLayout = grdArquivo_DesignTimeLayout
        Me.grdArquivo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdArquivo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdArquivo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdArquivo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdArquivo.FrozenColumns = 3
        Me.grdArquivo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdArquivo.GroupByBoxVisible = False
        Me.grdArquivo.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdArquivo.Location = New System.Drawing.Point(8, 116)
        Me.grdArquivo.Name = "grdArquivo"
        Me.grdArquivo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdArquivo.RecordNavigator = True
        Me.grdArquivo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdArquivo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdArquivo.Size = New System.Drawing.Size(879, 219)
        Me.grdArquivo.TabIndex = 5
        Me.grdArquivo.TabStop = False
        Me.grdArquivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdArquivo.VisualStyleManager = Me.vsmMain
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
        Me.grpControl2.TabIndex = 2
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.novo
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
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtReferencia)
        Me.grpDados.Controls.Add(Me.txtTempoMaquina)
        Me.grpDados.Controls.Add(Me.txtTempoMaoObra)
        Me.grpDados.Controls.Add(Me.txtTempoSetupMaquina)
        Me.grpDados.Controls.Add(Me.lblReferencia)
        Me.grpDados.Controls.Add(Me.lblTempoMaquina)
        Me.grpDados.Controls.Add(Me.lblTempoMaoObra)
        Me.grpDados.Controls.Add(Me.lblTempoSetupMaquina)
        Me.grpDados.Controls.Add(Me.lblPerdaCompulsoria)
        Me.grpDados.Controls.Add(Me.txtPerdaCompulsoria)
        Me.grpDados.Controls.Add(Me.lblNumeroCavidades)
        Me.grpDados.Controls.Add(Me.txtNumeroCavidades)
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.lblCodigo)
        Me.grpDados.Controls.Add(Me.txtCodigo)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 104)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtReferencia
        '
        Me.txtReferencia.DecimalDigits = 0
        Me.txtReferencia.Location = New System.Drawing.Point(387, 74)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(120, 20)
        SuperTipSettings1.HeaderText = "Ref. Ciclo"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = "Quantidade de ciclo feito no tempo informado."
        Me.jstTip.SetSuperTip(Me.txtReferencia, SuperTipSettings1)
        Me.txtReferencia.TabIndex = 17
        Me.txtReferencia.Text = "0"
        Me.txtReferencia.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtReferencia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtTempoMaquina
        '
        Me.txtTempoMaquina.Location = New System.Drawing.Point(261, 74)
        Me.txtTempoMaquina.Mask = "00:00:00"
        Me.txtTempoMaquina.Name = "txtTempoMaquina"
        Me.txtTempoMaquina.Size = New System.Drawing.Size(120, 20)
        SuperTipSettings2.FooterText = "Formato HH:MM:SS"
        SuperTipSettings2.HeaderText = "Tempo Máquina"
        SuperTipSettings2.ImageListProvider = Nothing
        SuperTipSettings2.Text = "Tempo de Máquina utilizado para a quantidade de ciclo especificada no campo Ref. " & _
    "Ciclo."
        Me.jstTip.SetSuperTip(Me.txtTempoMaquina, SuperTipSettings2)
        Me.txtTempoMaquina.TabIndex = 15
        Me.txtTempoMaquina.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtTempoMaoObra
        '
        Me.txtTempoMaoObra.Location = New System.Drawing.Point(135, 74)
        Me.txtTempoMaoObra.Mask = "00:00:00"
        Me.txtTempoMaoObra.Name = "txtTempoMaoObra"
        Me.txtTempoMaoObra.Size = New System.Drawing.Size(120, 20)
        SuperTipSettings3.FooterText = "Formato HH:MM:SS"
        SuperTipSettings3.HeaderText = "Tempo M.O"
        SuperTipSettings3.ImageListProvider = Nothing
        SuperTipSettings3.Text = "Tempo de Mão de Obra utilizado para a quantidade de ciclo especificada no campo R" & _
    "ef. Ciclo."
        Me.jstTip.SetSuperTip(Me.txtTempoMaoObra, SuperTipSettings3)
        Me.txtTempoMaoObra.TabIndex = 13
        Me.txtTempoMaoObra.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtTempoSetupMaquina
        '
        Me.txtTempoSetupMaquina.Location = New System.Drawing.Point(9, 74)
        Me.txtTempoSetupMaquina.Mask = "00:00:00"
        Me.txtTempoSetupMaquina.Name = "txtTempoSetupMaquina"
        Me.txtTempoSetupMaquina.Size = New System.Drawing.Size(120, 20)
        SuperTipSettings4.FooterText = "Formato HH:MM:SS"
        SuperTipSettings4.HeaderText = "Tempo Setup"
        SuperTipSettings4.ImageListProvider = Nothing
        SuperTipSettings4.Text = "Tempo de Setup utilizado para liberar a produção." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Este campo não está vinculad" & _
    "o ao campo Ref. Ciclo"
        Me.jstTip.SetSuperTip(Me.txtTempoSetupMaquina, SuperTipSettings4)
        Me.txtTempoSetupMaquina.TabIndex = 11
        Me.txtTempoSetupMaquina.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblReferencia.Location = New System.Drawing.Point(384, 57)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(56, 14)
        Me.lblReferencia.TabIndex = 16
        Me.lblReferencia.Text = "Ref. Ciclo:"
        '
        'lblTempoMaquina
        '
        Me.lblTempoMaquina.AutoSize = True
        Me.lblTempoMaquina.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTempoMaquina.Location = New System.Drawing.Point(258, 57)
        Me.lblTempoMaquina.Name = "lblTempoMaquina"
        Me.lblTempoMaquina.Size = New System.Drawing.Size(84, 14)
        Me.lblTempoMaquina.TabIndex = 14
        Me.lblTempoMaquina.Text = "Tempo Máquina:"
        '
        'lblTempoMaoObra
        '
        Me.lblTempoMaoObra.AutoSize = True
        Me.lblTempoMaoObra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTempoMaoObra.Location = New System.Drawing.Point(132, 57)
        Me.lblTempoMaoObra.Name = "lblTempoMaoObra"
        Me.lblTempoMaoObra.Size = New System.Drawing.Size(63, 14)
        Me.lblTempoMaoObra.TabIndex = 12
        Me.lblTempoMaoObra.Text = "Tempo M.O."
        '
        'lblTempoSetupMaquina
        '
        Me.lblTempoSetupMaquina.AutoSize = True
        Me.lblTempoSetupMaquina.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTempoSetupMaquina.Location = New System.Drawing.Point(6, 57)
        Me.lblTempoSetupMaquina.Name = "lblTempoSetupMaquina"
        Me.lblTempoSetupMaquina.Size = New System.Drawing.Size(72, 14)
        Me.lblTempoSetupMaquina.TabIndex = 10
        Me.lblTempoSetupMaquina.Text = "Tempo Setup:"
        '
        'lblPerdaCompulsoria
        '
        Me.lblPerdaCompulsoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPerdaCompulsoria.AutoSize = True
        Me.lblPerdaCompulsoria.Location = New System.Drawing.Point(579, 17)
        Me.lblPerdaCompulsoria.Name = "lblPerdaCompulsoria"
        Me.lblPerdaCompulsoria.Size = New System.Drawing.Size(100, 14)
        Me.lblPerdaCompulsoria.TabIndex = 4
        Me.lblPerdaCompulsoria.Text = "Perda Compulsória:"
        '
        'txtPerdaCompulsoria
        '
        Me.txtPerdaCompulsoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPerdaCompulsoria.DecimalDigits = 4
        Me.txtPerdaCompulsoria.Location = New System.Drawing.Point(582, 34)
        Me.txtPerdaCompulsoria.Name = "txtPerdaCompulsoria"
        Me.txtPerdaCompulsoria.Size = New System.Drawing.Size(120, 20)
        Me.txtPerdaCompulsoria.TabIndex = 5
        Me.txtPerdaCompulsoria.Text = "0,0000"
        Me.txtPerdaCompulsoria.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblNumeroCavidades
        '
        Me.lblNumeroCavidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroCavidades.AutoSize = True
        Me.lblNumeroCavidades.Location = New System.Drawing.Point(705, 17)
        Me.lblNumeroCavidades.Name = "lblNumeroCavidades"
        Me.lblNumeroCavidades.Size = New System.Drawing.Size(76, 14)
        Me.lblNumeroCavidades.TabIndex = 6
        Me.lblNumeroCavidades.Text = "Nº Cavidades:"
        '
        'txtNumeroCavidades
        '
        Me.txtNumeroCavidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroCavidades.DecimalDigits = 0
        Me.txtNumeroCavidades.Location = New System.Drawing.Point(708, 34)
        Me.txtNumeroCavidades.Name = "txtNumeroCavidades"
        Me.txtNumeroCavidades.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroCavidades.TabIndex = 7
        Me.txtNumeroCavidades.Text = "0"
        Me.txtNumeroCavidades.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtNumeroCavidades.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblAtivo
        '
        Me.lblAtivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.Location = New System.Drawing.Point(811, 17)
        Me.lblAtivo.Name = "lblAtivo"
        Me.lblAtivo.Size = New System.Drawing.Size(35, 14)
        Me.lblAtivo.TabIndex = 8
        Me.lblAtivo.Text = "Ativo:"
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
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(9, 34)
        Me.txtCodigo.MaxLength = 30
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'cboAtivo
        '
        Me.cboAtivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAtivo.AutoSize = False
        Me.cboAtivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboAtivo.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboAtivo.Location = New System.Drawing.Point(814, 34)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivo.Size = New System.Drawing.Size(74, 20)
        Me.cboAtivo.TabIndex = 9
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(135, 34)
        Me.txtDescricao.MaxLength = 100
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(441, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(132, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição:"
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'lblConjunto
        '
        Me.lblConjunto.AutoSize = True
        Me.lblConjunto.Location = New System.Drawing.Point(6, 17)
        Me.lblConjunto.Name = "lblConjunto"
        Me.lblConjunto.Size = New System.Drawing.Size(52, 14)
        Me.lblConjunto.TabIndex = 9
        Me.lblConjunto.Text = "Conjunto:"
        '
        'txtConjunto
        '
        Me.txtConjunto.DecimalDigits = 0
        Me.txtConjunto.Location = New System.Drawing.Point(9, 34)
        Me.txtConjunto.Name = "txtConjunto"
        Me.txtConjunto.Size = New System.Drawing.Size(100, 20)
        Me.txtConjunto.TabIndex = 10
        Me.txtConjunto.Text = "0"
        Me.txtConjunto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'usrCadMolde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadMolde"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDados.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagMaquina.ResumeLayout(False)
        CType(Me.grpMaquina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMaquina.ResumeLayout(False)
        Me.grpMaquina.PerformLayout()
        CType(Me.grdMaquina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagProduto.ResumeLayout(False)
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProduto.ResumeLayout(False)
        Me.grpProduto.PerformLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagQualidade.ResumeLayout(False)
        CType(Me.grdQualidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpQualidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpQualidade.ResumeLayout(False)
        Me.grpQualidade.PerformLayout()
        Me.pagArquivo.ResumeLayout(False)
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents lblNumeroCavidades As System.Windows.Forms.Label
    Friend WithEvents txtNumeroCavidades As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroCavidadesFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroCavidadesFiltro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCodigoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCodigoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagProduto As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpProduto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNumeroCavidadesProduto As System.Windows.Forms.Label
    Friend WithEvents txtNumeroCavidadesProduto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtDescricaoProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoProduto As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarProduto As System.Windows.Forms.Button
    Friend WithEvents lblCodigoProduto As System.Windows.Forms.Label
    Friend WithEvents cboCodigoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcluirProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnConfigurarGridProduto As System.Windows.Forms.Button
    Friend WithEvents grdProduto As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagArquivo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnConfigurarGridArquivo As System.Windows.Forms.Button
    Friend WithEvents grpArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarTipoArquivo As System.Windows.Forms.Button
    Friend WithEvents lblTipoArquivo As System.Windows.Forms.Label
    Friend WithEvents cboTipoArquivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnExcluirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtDescricaoArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoArquivo As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents lblRevisaoArquivo As System.Windows.Forms.Label
    Friend WithEvents txtRevisaoArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnAgruparGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents grdArquivo As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblPerdaCompulsoria As System.Windows.Forms.Label
    Friend WithEvents txtPerdaCompulsoria As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents pagQualidade As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnAgruparGridQualidade As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridQualidade As System.Windows.Forms.Button
    Friend WithEvents grdQualidade As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpQualidade As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblApontaQualidade As System.Windows.Forms.Label
    Friend WithEvents cboApontaQualidade As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFrequenciaQualidade As System.Windows.Forms.Label
    Friend WithEvents txtFrequenciaQualidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorMaximoQualidade As System.Windows.Forms.Label
    Friend WithEvents txtValorMaximoQualidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorMinimoQualidade As System.Windows.Forms.Label
    Friend WithEvents txtValorMinimoQualidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorNominalQualidade As System.Windows.Forms.Label
    Friend WithEvents txtObservacaoQualidade As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents cboCaracteristicaInspecionarQualidade As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtValorNominalQualidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblObservacaoQualidade As System.Windows.Forms.Label
    Friend WithEvents lblCaracteristicaInspecionarQualidade As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarCaracteristicaInspecionarQualidade As System.Windows.Forms.Button
    Friend WithEvents btnExcluirQualidade As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirQualidade As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagMaquina As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnAgruparGridMaquina As System.Windows.Forms.Button
    Friend WithEvents grpMaquina As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDescricaoMaquina As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoMaquina As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarMaquina As System.Windows.Forms.Button
    Friend WithEvents lblCodigoMaquina As System.Windows.Forms.Label
    Friend WithEvents cboCodigoMaquina As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcluirMaquina As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirMaquina As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnConfigurarGridMaquina As System.Windows.Forms.Button
    Friend WithEvents grdMaquina As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnCadastrarCentroTrabalho As System.Windows.Forms.Button
    Friend WithEvents lblCentroTrabalho As System.Windows.Forms.Label
    Friend WithEvents cboCentroTrabalho As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtReferencia As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtTempoMaquina As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtTempoMaoObra As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtTempoSetupMaquina As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblReferencia As System.Windows.Forms.Label
    Friend WithEvents lblTempoMaquina As System.Windows.Forms.Label
    Friend WithEvents lblTempoMaoObra As System.Windows.Forms.Label
    Friend WithEvents lblTempoSetupMaquina As System.Windows.Forms.Label
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridMaquina As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridQualidade As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridArquivo As System.Windows.Forms.Button
    Friend WithEvents lblConjunto As System.Windows.Forms.Label
    Friend WithEvents txtConjunto As Janus.Windows.GridEX.EditControls.NumericEditBox

End Class
