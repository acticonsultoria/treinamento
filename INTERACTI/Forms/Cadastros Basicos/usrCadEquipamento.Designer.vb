<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadEquipamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadEquipamento))
        Dim grdArquivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCodigoFiltro = New System.Windows.Forms.Label()
        Me.txtCodigoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpCalibracao = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtProximaCalibracao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtUltimaCalibracao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.txtSituacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSituacao = New System.Windows.Forms.Label()
        Me.lblProximaCalibracao = New System.Windows.Forms.Label()
        Me.lblUltimaCalibracao = New System.Windows.Forms.Label()
        Me.txtStatus = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.grpLocalizacao = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblColaborador = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.txtColaborador = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtArea = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagArquivo = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdArquivo = New Janus.Windows.GridEX.GridEX()
        Me.grpArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnExcluirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.txtTituloArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTituloArquivo = New System.Windows.Forms.Label()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtPontosCalibracao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPontosCalibracao = New System.Windows.Forms.Label()
        Me.cboFrequenciaCalibracao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFrequenciaCalibracao = New System.Windows.Forms.Label()
        Me.txtFrequenciaCalibracao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCriterioAceitacao = New System.Windows.Forms.Label()
        Me.txtCriterioAceitacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblResolucao = New System.Windows.Forms.Label()
        Me.txtResolucao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCapacidade = New System.Windows.Forms.Label()
        Me.txtCapacidade = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
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
        CType(Me.grpCalibracao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCalibracao.SuspendLayout()
        CType(Me.grpLocalizacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLocalizacao.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagArquivo.SuspendLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(915, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 453)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Equipamentos"
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
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 2
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
        Me.txtCodigoFiltro.MaxLength = 100
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
        Me.txtDescricaoFiltro.MaxLength = 300
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(361, 20)
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
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 8
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
        Me.grpControl.TabIndex = 4
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
        Me.pagDados.Controls.Add(Me.grpCalibracao)
        Me.pagDados.Controls.Add(Me.grpLocalizacao)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Equipamentos"
        '
        'grpCalibracao
        '
        Me.grpCalibracao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCalibracao.BackColor = System.Drawing.Color.Transparent
        Me.grpCalibracao.Controls.Add(Me.txtProximaCalibracao)
        Me.grpCalibracao.Controls.Add(Me.txtUltimaCalibracao)
        Me.grpCalibracao.Controls.Add(Me.txtObservacao)
        Me.grpCalibracao.Controls.Add(Me.lblObservacao)
        Me.grpCalibracao.Controls.Add(Me.txtSituacao)
        Me.grpCalibracao.Controls.Add(Me.lblSituacao)
        Me.grpCalibracao.Controls.Add(Me.lblProximaCalibracao)
        Me.grpCalibracao.Controls.Add(Me.lblUltimaCalibracao)
        Me.grpCalibracao.Controls.Add(Me.txtStatus)
        Me.grpCalibracao.Controls.Add(Me.lblStatus)
        Me.grpCalibracao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpCalibracao.Location = New System.Drawing.Point(8, 185)
        Me.grpCalibracao.Name = "grpCalibracao"
        Me.grpCalibracao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCalibracao.Size = New System.Drawing.Size(897, 62)
        Me.grpCalibracao.TabIndex = 2
        Me.grpCalibracao.Text = "Calibração"
        Me.grpCalibracao.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpCalibracao.VisualStyleManager = Me.vsmMain
        '
        'txtProximaCalibracao
        '
        Me.txtProximaCalibracao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProximaCalibracao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProximaCalibracao.Location = New System.Drawing.Point(240, 34)
        Me.txtProximaCalibracao.MaxLength = 100
        Me.txtProximaCalibracao.Name = "txtProximaCalibracao"
        Me.txtProximaCalibracao.ReadOnly = True
        Me.txtProximaCalibracao.Size = New System.Drawing.Size(100, 20)
        Me.txtProximaCalibracao.TabIndex = 2
        Me.txtProximaCalibracao.TabStop = False
        '
        'txtUltimaCalibracao
        '
        Me.txtUltimaCalibracao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUltimaCalibracao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUltimaCalibracao.Location = New System.Drawing.Point(135, 34)
        Me.txtUltimaCalibracao.MaxLength = 100
        Me.txtUltimaCalibracao.Name = "txtUltimaCalibracao"
        Me.txtUltimaCalibracao.ReadOnly = True
        Me.txtUltimaCalibracao.Size = New System.Drawing.Size(100, 20)
        Me.txtUltimaCalibracao.TabIndex = 1
        Me.txtUltimaCalibracao.TabStop = False
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Location = New System.Drawing.Point(472, 34)
        Me.txtObservacao.MaxLength = 4000
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(419, 20)
        Me.txtObservacao.TabIndex = 4
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.Location = New System.Drawing.Point(469, 17)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacao.TabIndex = 10
        Me.lblObservacao.Text = "Observação:"
        '
        'txtSituacao
        '
        Me.txtSituacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSituacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSituacao.Location = New System.Drawing.Point(346, 34)
        Me.txtSituacao.MaxLength = 100
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.ReadOnly = True
        Me.txtSituacao.Size = New System.Drawing.Size(120, 20)
        Me.txtSituacao.TabIndex = 3
        Me.txtSituacao.TabStop = False
        '
        'lblSituacao
        '
        Me.lblSituacao.AutoSize = True
        Me.lblSituacao.Location = New System.Drawing.Point(343, 17)
        Me.lblSituacao.Name = "lblSituacao"
        Me.lblSituacao.Size = New System.Drawing.Size(52, 14)
        Me.lblSituacao.TabIndex = 8
        Me.lblSituacao.Text = "Situação:"
        '
        'lblProximaCalibracao
        '
        Me.lblProximaCalibracao.AutoSize = True
        Me.lblProximaCalibracao.Location = New System.Drawing.Point(237, 17)
        Me.lblProximaCalibracao.Name = "lblProximaCalibracao"
        Me.lblProximaCalibracao.Size = New System.Drawing.Size(102, 14)
        Me.lblProximaCalibracao.TabIndex = 6
        Me.lblProximaCalibracao.Text = "Próxima Calibração:"
        '
        'lblUltimaCalibracao
        '
        Me.lblUltimaCalibracao.AutoSize = True
        Me.lblUltimaCalibracao.Location = New System.Drawing.Point(132, 17)
        Me.lblUltimaCalibracao.Name = "lblUltimaCalibracao"
        Me.lblUltimaCalibracao.Size = New System.Drawing.Size(92, 14)
        Me.lblUltimaCalibracao.TabIndex = 4
        Me.lblUltimaCalibracao.Text = "Última Calibração:"
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStatus.Location = New System.Drawing.Point(9, 34)
        Me.txtStatus.MaxLength = 100
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(120, 20)
        Me.txtStatus.TabIndex = 0
        Me.txtStatus.TabStop = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(6, 17)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(41, 14)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Status:"
        '
        'grpLocalizacao
        '
        Me.grpLocalizacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpLocalizacao.BackColor = System.Drawing.Color.Transparent
        Me.grpLocalizacao.Controls.Add(Me.lblColaborador)
        Me.grpLocalizacao.Controls.Add(Me.lblArea)
        Me.grpLocalizacao.Controls.Add(Me.txtColaborador)
        Me.grpLocalizacao.Controls.Add(Me.txtArea)
        Me.grpLocalizacao.ForeColor = System.Drawing.Color.Black
        Me.grpLocalizacao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLocalizacao.Location = New System.Drawing.Point(8, 115)
        Me.grpLocalizacao.Name = "grpLocalizacao"
        Me.grpLocalizacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLocalizacao.Size = New System.Drawing.Size(897, 64)
        Me.grpLocalizacao.TabIndex = 1
        Me.grpLocalizacao.Tag = ""
        Me.grpLocalizacao.Text = "Localização"
        Me.grpLocalizacao.VisualStyleManager = Me.vsmMain
        '
        'lblColaborador
        '
        Me.lblColaborador.AutoSize = True
        Me.lblColaborador.Location = New System.Drawing.Point(142, 17)
        Me.lblColaborador.Name = "lblColaborador"
        Me.lblColaborador.Size = New System.Drawing.Size(69, 14)
        Me.lblColaborador.TabIndex = 4
        Me.lblColaborador.Text = "Colaborador:"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(6, 17)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(34, 14)
        Me.lblArea.TabIndex = 2
        Me.lblArea.Text = "Área:"
        '
        'txtColaborador
        '
        Me.txtColaborador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColaborador.Location = New System.Drawing.Point(145, 34)
        Me.txtColaborador.MaxLength = 100
        Me.txtColaborador.Name = "txtColaborador"
        Me.txtColaborador.Size = New System.Drawing.Size(130, 20)
        Me.txtColaborador.TabIndex = 1
        '
        'txtArea
        '
        Me.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArea.Location = New System.Drawing.Point(9, 34)
        Me.txtArea.MaxLength = 100
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(130, 20)
        Me.txtArea.TabIndex = 0
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
        Me.grpControl2.TabIndex = 0
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
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 253)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 137)
        Me.tabDados.TabIndex = 3
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagArquivo})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagArquivo
        '
        Me.pagArquivo.Controls.Add(Me.grdArquivo)
        Me.pagArquivo.Controls.Add(Me.grpArquivo)
        Me.pagArquivo.Key = "pagArquivo"
        Me.pagArquivo.Location = New System.Drawing.Point(1, 22)
        Me.pagArquivo.Name = "pagArquivo"
        Me.pagArquivo.Size = New System.Drawing.Size(895, 114)
        Me.pagArquivo.TabStop = True
        Me.pagArquivo.Text = "Arquivos"
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
        grdArquivo_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdArquivo_DesignTimeLayout_Reference_0})
        grdArquivo_DesignTimeLayout.LayoutString = resources.GetString("grdArquivo_DesignTimeLayout.LayoutString")
        Me.grdArquivo.DesignTimeLayout = grdArquivo_DesignTimeLayout
        Me.grdArquivo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdArquivo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdArquivo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdArquivo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdArquivo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdArquivo.FrozenColumns = 3
        Me.grdArquivo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdArquivo.GroupByBoxVisible = False
        Me.grdArquivo.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdArquivo.Location = New System.Drawing.Point(8, 72)
        Me.grdArquivo.Name = "grdArquivo"
        Me.grdArquivo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdArquivo.RecordNavigator = True
        Me.grdArquivo.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdArquivo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdArquivo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdArquivo.Size = New System.Drawing.Size(879, 39)
        Me.grdArquivo.TabIndex = 2
        Me.grdArquivo.TabStop = False
        Me.grdArquivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdArquivo.VisualStyleManager = Me.vsmMain
        '
        'grpArquivo
        '
        Me.grpArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpArquivo.Controls.Add(Me.btnArquivo)
        Me.grpArquivo.Controls.Add(Me.lblArquivo)
        Me.grpArquivo.Controls.Add(Me.txtArquivo)
        Me.grpArquivo.Controls.Add(Me.btnExcluirArquivo)
        Me.grpArquivo.Controls.Add(Me.btnInserirArquivo)
        Me.grpArquivo.Controls.Add(Me.txtTituloArquivo)
        Me.grpArquivo.Controls.Add(Me.lblTituloArquivo)
        Me.grpArquivo.Location = New System.Drawing.Point(8, 3)
        Me.grpArquivo.Name = "grpArquivo"
        Me.grpArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpArquivo.Size = New System.Drawing.Size(879, 63)
        Me.grpArquivo.TabIndex = 0
        Me.grpArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpArquivo.VisualStyleManager = Me.vsmMain
        '
        'btnArquivo
        '
        Me.btnArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnArquivo.Location = New System.Drawing.Point(637, 34)
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivo.Size = New System.Drawing.Size(20, 20)
        Me.btnArquivo.TabIndex = 2
        Me.btnArquivo.Text = "..."
        Me.btnArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivo
        '
        Me.lblArquivo.AutoSize = True
        Me.lblArquivo.Location = New System.Drawing.Point(294, 17)
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
        Me.txtArquivo.Location = New System.Drawing.Point(297, 34)
        Me.txtArquivo.MaxLength = 500
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(341, 20)
        Me.txtArquivo.TabIndex = 1
        Me.txtArquivo.TabStop = False
        '
        'btnExcluirArquivo
        '
        Me.btnExcluirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirArquivo.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirArquivo.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirArquivo.Location = New System.Drawing.Point(782, 31)
        Me.btnExcluirArquivo.Name = "btnExcluirArquivo"
        Me.btnExcluirArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirArquivo.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirArquivo.TabIndex = 4
        Me.btnExcluirArquivo.Text = "Excluir"
        Me.btnExcluirArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirArquivo
        '
        Me.btnInserirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirArquivo.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirArquivo.Location = New System.Drawing.Point(685, 31)
        Me.btnInserirArquivo.Name = "btnInserirArquivo"
        Me.btnInserirArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirArquivo.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirArquivo.TabIndex = 3
        Me.btnInserirArquivo.Text = "Inserir"
        Me.btnInserirArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtTituloArquivo
        '
        Me.txtTituloArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTituloArquivo.Location = New System.Drawing.Point(9, 34)
        Me.txtTituloArquivo.MaxLength = 100
        Me.txtTituloArquivo.Name = "txtTituloArquivo"
        Me.txtTituloArquivo.Size = New System.Drawing.Size(282, 20)
        Me.txtTituloArquivo.TabIndex = 0
        '
        'lblTituloArquivo
        '
        Me.lblTituloArquivo.AutoSize = True
        Me.lblTituloArquivo.Location = New System.Drawing.Point(6, 17)
        Me.lblTituloArquivo.Name = "lblTituloArquivo"
        Me.lblTituloArquivo.Size = New System.Drawing.Size(59, 14)
        Me.lblTituloArquivo.TabIndex = 0
        Me.lblTituloArquivo.Text = "Descrição:"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtPontosCalibracao)
        Me.grpDados.Controls.Add(Me.lblPontosCalibracao)
        Me.grpDados.Controls.Add(Me.cboFrequenciaCalibracao)
        Me.grpDados.Controls.Add(Me.lblFrequenciaCalibracao)
        Me.grpDados.Controls.Add(Me.txtFrequenciaCalibracao)
        Me.grpDados.Controls.Add(Me.lblCriterioAceitacao)
        Me.grpDados.Controls.Add(Me.txtCriterioAceitacao)
        Me.grpDados.Controls.Add(Me.lblResolucao)
        Me.grpDados.Controls.Add(Me.txtResolucao)
        Me.grpDados.Controls.Add(Me.lblCapacidade)
        Me.grpDados.Controls.Add(Me.txtCapacidade)
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.lblCodigo)
        Me.grpDados.Controls.Add(Me.txtCodigo)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 106)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtPontosCalibracao
        '
        Me.txtPontosCalibracao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPontosCalibracao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPontosCalibracao.Location = New System.Drawing.Point(144, 74)
        Me.txtPontosCalibracao.MaxLength = 500
        Me.txtPontosCalibracao.Name = "txtPontosCalibracao"
        Me.txtPontosCalibracao.Size = New System.Drawing.Size(604, 20)
        Me.txtPontosCalibracao.TabIndex = 8
        '
        'lblPontosCalibracao
        '
        Me.lblPontosCalibracao.AutoSize = True
        Me.lblPontosCalibracao.Location = New System.Drawing.Point(141, 57)
        Me.lblPontosCalibracao.Name = "lblPontosCalibracao"
        Me.lblPontosCalibracao.Size = New System.Drawing.Size(94, 14)
        Me.lblPontosCalibracao.TabIndex = 23
        Me.lblPontosCalibracao.Text = "Pontos Calibração"
        '
        'cboFrequenciaCalibracao
        '
        Me.cboFrequenciaCalibracao.AutoSize = False
        Me.cboFrequenciaCalibracao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboFrequenciaCalibracao.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboFrequenciaCalibracao.Location = New System.Drawing.Point(44, 73)
        Me.cboFrequenciaCalibracao.Name = "cboFrequenciaCalibracao"
        Me.cboFrequenciaCalibracao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFrequenciaCalibracao.ReadOnly = True
        Me.cboFrequenciaCalibracao.Size = New System.Drawing.Size(95, 20)
        Me.cboFrequenciaCalibracao.TabIndex = 7
        Me.cboFrequenciaCalibracao.TabStop = False
        '
        'lblFrequenciaCalibracao
        '
        Me.lblFrequenciaCalibracao.AutoSize = True
        Me.lblFrequenciaCalibracao.Location = New System.Drawing.Point(6, 57)
        Me.lblFrequenciaCalibracao.Name = "lblFrequenciaCalibracao"
        Me.lblFrequenciaCalibracao.Size = New System.Drawing.Size(133, 14)
        Me.lblFrequenciaCalibracao.TabIndex = 21
        Me.lblFrequenciaCalibracao.Text = "Frequência de Calibração:"
        '
        'txtFrequenciaCalibracao
        '
        Me.txtFrequenciaCalibracao.DecimalDigits = 0
        Me.txtFrequenciaCalibracao.Location = New System.Drawing.Point(9, 74)
        Me.txtFrequenciaCalibracao.Name = "txtFrequenciaCalibracao"
        Me.txtFrequenciaCalibracao.Size = New System.Drawing.Size(29, 20)
        Me.txtFrequenciaCalibracao.TabIndex = 6
        Me.txtFrequenciaCalibracao.Text = "0"
        Me.txtFrequenciaCalibracao.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblCriterioAceitacao
        '
        Me.lblCriterioAceitacao.AutoSize = True
        Me.lblCriterioAceitacao.Location = New System.Drawing.Point(751, 17)
        Me.lblCriterioAceitacao.Name = "lblCriterioAceitacao"
        Me.lblCriterioAceitacao.Size = New System.Drawing.Size(110, 14)
        Me.lblCriterioAceitacao.TabIndex = 14
        Me.lblCriterioAceitacao.Text = "Critério de Aceitação:"
        '
        'txtCriterioAceitacao
        '
        Me.txtCriterioAceitacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCriterioAceitacao.Location = New System.Drawing.Point(754, 34)
        Me.txtCriterioAceitacao.MaxLength = 100
        Me.txtCriterioAceitacao.Name = "txtCriterioAceitacao"
        Me.txtCriterioAceitacao.Size = New System.Drawing.Size(137, 20)
        Me.txtCriterioAceitacao.TabIndex = 5
        '
        'lblResolucao
        '
        Me.lblResolucao.AutoSize = True
        Me.lblResolucao.Location = New System.Drawing.Point(625, 17)
        Me.lblResolucao.Name = "lblResolucao"
        Me.lblResolucao.Size = New System.Drawing.Size(61, 14)
        Me.lblResolucao.TabIndex = 12
        Me.lblResolucao.Text = "Resolução:"
        '
        'txtResolucao
        '
        Me.txtResolucao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResolucao.Location = New System.Drawing.Point(628, 34)
        Me.txtResolucao.MaxLength = 100
        Me.txtResolucao.Name = "txtResolucao"
        Me.txtResolucao.Size = New System.Drawing.Size(120, 20)
        Me.txtResolucao.TabIndex = 4
        '
        'lblCapacidade
        '
        Me.lblCapacidade.AutoSize = True
        Me.lblCapacidade.Location = New System.Drawing.Point(499, 17)
        Me.lblCapacidade.Name = "lblCapacidade"
        Me.lblCapacidade.Size = New System.Drawing.Size(67, 14)
        Me.lblCapacidade.TabIndex = 10
        Me.lblCapacidade.Text = "Capacidade:"
        '
        'txtCapacidade
        '
        Me.txtCapacidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCapacidade.Location = New System.Drawing.Point(502, 34)
        Me.txtCapacidade.MaxLength = 100
        Me.txtCapacidade.Name = "txtCapacidade"
        Me.txtCapacidade.Size = New System.Drawing.Size(120, 20)
        Me.txtCapacidade.TabIndex = 3
        '
        'lblAtivo
        '
        Me.lblAtivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.Location = New System.Drawing.Point(751, 57)
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
        Me.txtCodigo.MaxLength = 100
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(130, 20)
        Me.txtCodigo.TabIndex = 1
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
        Me.cboAtivo.Location = New System.Drawing.Point(754, 74)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivo.Size = New System.Drawing.Size(76, 20)
        Me.cboAtivo.TabIndex = 9
        '
        'txtDescricao
        '
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(144, 34)
        Me.txtDescricao.MaxLength = 300
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(352, 20)
        Me.txtDescricao.TabIndex = 2
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(141, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição:"
        '
        'usrCadEquipamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadEquipamento"
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
        CType(Me.grpCalibracao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCalibracao.ResumeLayout(False)
        Me.grpCalibracao.PerformLayout()
        CType(Me.grpLocalizacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLocalizacao.ResumeLayout(False)
        Me.grpLocalizacao.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagArquivo.ResumeLayout(False)
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
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
    Friend WithEvents grpCalibracao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCodigoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagArquivo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnExcluirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtTituloArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTituloArquivo As System.Windows.Forms.Label
    Friend WithEvents grdArquivo As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblCriterioAceitacao As System.Windows.Forms.Label
    Friend WithEvents txtCriterioAceitacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblResolucao As System.Windows.Forms.Label
    Friend WithEvents txtResolucao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCapacidade As System.Windows.Forms.Label
    Friend WithEvents txtCapacidade As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpLocalizacao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblColaborador As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents txtColaborador As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtArea As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtStatus As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtPontosCalibracao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPontosCalibracao As System.Windows.Forms.Label
    Friend WithEvents cboFrequenciaCalibracao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFrequenciaCalibracao As System.Windows.Forms.Label
    Friend WithEvents txtFrequenciaCalibracao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents txtSituacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSituacao As System.Windows.Forms.Label
    Friend WithEvents lblProximaCalibracao As System.Windows.Forms.Label
    Friend WithEvents lblUltimaCalibracao As System.Windows.Forms.Label
    Friend WithEvents txtProximaCalibracao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtUltimaCalibracao As Janus.Windows.GridEX.EditControls.MaskedEditBox

End Class
