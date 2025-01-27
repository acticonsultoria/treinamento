<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadServico
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadServico))
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
        Me.cboGrupoItemFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblGrupoItemFiltro = New System.Windows.Forms.Label()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCodigoServicoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoServicoFiltro = New System.Windows.Forms.Label()
        Me.lblDescricaoServicoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblPrecoVenda = New System.Windows.Forms.Label()
        Me.txtPrecoVenda = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.grpNFSe = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblPercentualAproximadoTributos = New System.Windows.Forms.Label()
        Me.txtPercentualAproximadoTributos = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaISS = New System.Windows.Forms.Label()
        Me.txtAliquotaISS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtItemServico = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCodigoAtividade = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCNAE = New System.Windows.Forms.Label()
        Me.lblCodigoAtividade = New System.Windows.Forms.Label()
        Me.txtCNAE = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblItemServico = New System.Windows.Forms.Label()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarGrupoItem = New System.Windows.Forms.Button()
        Me.cboGrupoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblGrupoItem = New System.Windows.Forms.Label()
        Me.txtCodigoServico = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoServico = New System.Windows.Forms.Label()
        Me.txtDescricaoServico = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblDescricaoServico = New System.Windows.Forms.Label()
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
        CType(Me.grpNFSe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNFSe.SuspendLayout()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme2.Name = "Scheme"
        JanusColorScheme2.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme2.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme2)
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
        Me.pagLista.Text = "Serviço"
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
        Me.btnExcelGrid.TabIndex = 13
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
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 463)
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
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 364)
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
        Me.grpFiltro.Controls.Add(Me.cboGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCodigoServicoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoServicoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoServicoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboGrupoItemFiltro
        '
        Me.cboGrupoItemFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboGrupoItemFiltro.AutoSize = False
        Me.cboGrupoItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoItemFiltro.Location = New System.Drawing.Point(9, 34)
        Me.cboGrupoItemFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboGrupoItemFiltro.Name = "cboGrupoItemFiltro"
        Me.cboGrupoItemFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItemFiltro.Size = New System.Drawing.Size(571, 20)
        Me.cboGrupoItemFiltro.TabIndex = 1
        '
        'lblGrupoItemFiltro
        '
        Me.lblGrupoItemFiltro.AutoSize = True
        Me.lblGrupoItemFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblGrupoItemFiltro.Name = "lblGrupoItemFiltro"
        Me.lblGrupoItemFiltro.Size = New System.Drawing.Size(69, 14)
        Me.lblGrupoItemFiltro.TabIndex = 0
        Me.lblGrupoItemFiltro.Text = "Grupo - Item:"
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtDescricaoFiltro.MaxLength = 120
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(760, 20)
        Me.txtDescricaoFiltro.TabIndex = 9
        '
        'txtCodigoServicoFiltro
        '
        Me.txtCodigoServicoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigoServicoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoServicoFiltro.Location = New System.Drawing.Point(586, 34)
        Me.txtCodigoServicoFiltro.MaxLength = 60
        Me.txtCodigoServicoFiltro.Name = "txtCodigoServicoFiltro"
        Me.txtCodigoServicoFiltro.Size = New System.Drawing.Size(181, 20)
        Me.txtCodigoServicoFiltro.TabIndex = 5
        '
        'lblCodigoServicoFiltro
        '
        Me.lblCodigoServicoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodigoServicoFiltro.AutoSize = True
        Me.lblCodigoServicoFiltro.Location = New System.Drawing.Point(583, 17)
        Me.lblCodigoServicoFiltro.Name = "lblCodigoServicoFiltro"
        Me.lblCodigoServicoFiltro.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigoServicoFiltro.TabIndex = 4
        Me.lblCodigoServicoFiltro.Text = "Código:"
        '
        'lblDescricaoServicoFiltro
        '
        Me.lblDescricaoServicoFiltro.AutoSize = True
        Me.lblDescricaoServicoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblDescricaoServicoFiltro.Name = "lblDescricaoServicoFiltro"
        Me.lblDescricaoServicoFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoServicoFiltro.TabIndex = 8
        Me.lblDescricaoServicoFiltro.Text = "Descrição:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 10
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
        Me.grpControl.TabIndex = 3
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
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Serviço"
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
        Me.grpDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblPrecoVenda)
        Me.grpDados.Controls.Add(Me.txtPrecoVenda)
        Me.grpDados.Controls.Add(Me.grpNFSe)
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.btnCadastrarGrupoItem)
        Me.grpDados.Controls.Add(Me.cboGrupoItem)
        Me.grpDados.Controls.Add(Me.lblGrupoItem)
        Me.grpDados.Controls.Add(Me.txtCodigoServico)
        Me.grpDados.Controls.Add(Me.lblCodigoServico)
        Me.grpDados.Controls.Add(Me.txtDescricaoServico)
        Me.grpDados.Controls.Add(Me.lblDescricaoServico)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 474)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblPrecoVenda
        '
        Me.lblPrecoVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrecoVenda.AutoSize = True
        Me.lblPrecoVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPrecoVenda.Location = New System.Drawing.Point(672, 17)
        Me.lblPrecoVenda.Name = "lblPrecoVenda"
        Me.lblPrecoVenda.Size = New System.Drawing.Size(87, 14)
        Me.lblPrecoVenda.TabIndex = 4
        Me.lblPrecoVenda.Text = "Preço de Venda:"
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrecoVenda.DecimalDigits = 2
        Me.txtPrecoVenda.Location = New System.Drawing.Point(675, 34)
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.Size = New System.Drawing.Size(108, 20)
        Me.txtPrecoVenda.TabIndex = 3
        Me.txtPrecoVenda.Text = "0,00"
        Me.txtPrecoVenda.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'grpNFSe
        '
        Me.grpNFSe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpNFSe.BackColor = System.Drawing.Color.Transparent
        Me.grpNFSe.Controls.Add(Me.lblPercentualAproximadoTributos)
        Me.grpNFSe.Controls.Add(Me.txtPercentualAproximadoTributos)
        Me.grpNFSe.Controls.Add(Me.lblAliquotaISS)
        Me.grpNFSe.Controls.Add(Me.txtAliquotaISS)
        Me.grpNFSe.Controls.Add(Me.txtItemServico)
        Me.grpNFSe.Controls.Add(Me.txtCodigoAtividade)
        Me.grpNFSe.Controls.Add(Me.lblCNAE)
        Me.grpNFSe.Controls.Add(Me.lblCodigoAtividade)
        Me.grpNFSe.Controls.Add(Me.txtCNAE)
        Me.grpNFSe.Controls.Add(Me.lblItemServico)
        Me.grpNFSe.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpNFSe.Location = New System.Drawing.Point(6, 170)
        Me.grpNFSe.Name = "grpNFSe"
        Me.grpNFSe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpNFSe.Size = New System.Drawing.Size(882, 65)
        Me.grpNFSe.TabIndex = 9
        Me.grpNFSe.Text = "Nota Fiscal de Serviço Eletrônica"
        Me.grpNFSe.VisualStyleManager = Me.vsmMain
        '
        'lblPercentualAproximadoTributos
        '
        Me.lblPercentualAproximadoTributos.AutoSize = True
        Me.lblPercentualAproximadoTributos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPercentualAproximadoTributos.Location = New System.Drawing.Point(653, 17)
        Me.lblPercentualAproximadoTributos.Name = "lblPercentualAproximadoTributos"
        Me.lblPercentualAproximadoTributos.Size = New System.Drawing.Size(137, 14)
        Me.lblPercentualAproximadoTributos.TabIndex = 8
        Me.lblPercentualAproximadoTributos.Text = "% Aproximado de Tributos:"
        '
        'txtPercentualAproximadoTributos
        '
        Me.txtPercentualAproximadoTributos.DecimalDigits = 2
        Me.txtPercentualAproximadoTributos.Location = New System.Drawing.Point(656, 34)
        Me.txtPercentualAproximadoTributos.Name = "txtPercentualAproximadoTributos"
        Me.txtPercentualAproximadoTributos.Size = New System.Drawing.Size(214, 20)
        Me.txtPercentualAproximadoTributos.TabIndex = 5
        Me.txtPercentualAproximadoTributos.Text = "0,00"
        Me.txtPercentualAproximadoTributos.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaISS
        '
        Me.lblAliquotaISS.AutoSize = True
        Me.lblAliquotaISS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAliquotaISS.Location = New System.Drawing.Point(512, 17)
        Me.lblAliquotaISS.Name = "lblAliquotaISS"
        Me.lblAliquotaISS.Size = New System.Drawing.Size(68, 14)
        Me.lblAliquotaISS.TabIndex = 6
        Me.lblAliquotaISS.Text = "Alíquota ISS:"
        '
        'txtAliquotaISS
        '
        Me.txtAliquotaISS.DecimalDigits = 2
        Me.txtAliquotaISS.Location = New System.Drawing.Point(515, 34)
        Me.txtAliquotaISS.Name = "txtAliquotaISS"
        Me.txtAliquotaISS.Size = New System.Drawing.Size(135, 20)
        Me.txtAliquotaISS.TabIndex = 4
        Me.txtAliquotaISS.Text = "0,00"
        Me.txtAliquotaISS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtItemServico
        '
        Me.txtItemServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemServico.Location = New System.Drawing.Point(9, 34)
        Me.txtItemServico.MaxLength = 60
        Me.txtItemServico.Name = "txtItemServico"
        Me.txtItemServico.Size = New System.Drawing.Size(188, 20)
        Me.txtItemServico.TabIndex = 1
        '
        'txtCodigoAtividade
        '
        Me.txtCodigoAtividade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoAtividade.Location = New System.Drawing.Point(321, 34)
        Me.txtCodigoAtividade.MaxLength = 60
        Me.txtCodigoAtividade.Name = "txtCodigoAtividade"
        Me.txtCodigoAtividade.Size = New System.Drawing.Size(188, 20)
        Me.txtCodigoAtividade.TabIndex = 3
        '
        'lblCNAE
        '
        Me.lblCNAE.AutoSize = True
        Me.lblCNAE.Location = New System.Drawing.Point(200, 17)
        Me.lblCNAE.Name = "lblCNAE"
        Me.lblCNAE.Size = New System.Drawing.Size(38, 14)
        Me.lblCNAE.TabIndex = 2
        Me.lblCNAE.Text = "CNAE:"
        '
        'lblCodigoAtividade
        '
        Me.lblCodigoAtividade.AutoSize = True
        Me.lblCodigoAtividade.Location = New System.Drawing.Point(318, 17)
        Me.lblCodigoAtividade.Name = "lblCodigoAtividade"
        Me.lblCodigoAtividade.Size = New System.Drawing.Size(90, 14)
        Me.lblCodigoAtividade.TabIndex = 4
        Me.lblCodigoAtividade.Text = "Código Atividade:"
        '
        'txtCNAE
        '
        Me.txtCNAE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCNAE.Location = New System.Drawing.Point(203, 34)
        Me.txtCNAE.MaxLength = 9
        Me.txtCNAE.Name = "txtCNAE"
        Me.txtCNAE.Numeric = True
        Me.txtCNAE.Size = New System.Drawing.Size(112, 20)
        Me.txtCNAE.TabIndex = 2
        '
        'lblItemServico
        '
        Me.lblItemServico.AutoSize = True
        Me.lblItemServico.Location = New System.Drawing.Point(6, 17)
        Me.lblItemServico.Name = "lblItemServico"
        Me.lblItemServico.Size = New System.Drawing.Size(110, 14)
        Me.lblItemServico.TabIndex = 0
        Me.lblItemServico.Text = "Item Serviço (LC116):"
        '
        'lblAtivo
        '
        Me.lblAtivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.Location = New System.Drawing.Point(786, 17)
        Me.lblAtivo.Name = "lblAtivo"
        Me.lblAtivo.Size = New System.Drawing.Size(35, 14)
        Me.lblAtivo.TabIndex = 6
        Me.lblAtivo.Text = "Ativo:"
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
        Me.cboAtivo.Location = New System.Drawing.Point(789, 34)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivo.Size = New System.Drawing.Size(90, 20)
        Me.cboAtivo.TabIndex = 4
        '
        'btnCadastrarGrupoItem
        '
        Me.btnCadastrarGrupoItem.FlatAppearance.BorderSize = 0
        Me.btnCadastrarGrupoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarGrupoItem.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarGrupoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarGrupoItem.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarGrupoItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarGrupoItem.Name = "btnCadastrarGrupoItem"
        Me.btnCadastrarGrupoItem.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarGrupoItem.TabIndex = 0
        Me.btnCadastrarGrupoItem.TabStop = False
        Me.btnCadastrarGrupoItem.UseVisualStyleBackColor = True
        '
        'cboGrupoItem
        '
        Me.cboGrupoItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboGrupoItem.AutoSize = False
        Me.cboGrupoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoItem.Location = New System.Drawing.Point(9, 34)
        Me.cboGrupoItem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboGrupoItem.Name = "cboGrupoItem"
        Me.cboGrupoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItem.Size = New System.Drawing.Size(402, 20)
        Me.cboGrupoItem.TabIndex = 1
        '
        'lblGrupoItem
        '
        Me.lblGrupoItem.AutoSize = True
        Me.lblGrupoItem.Location = New System.Drawing.Point(25, 17)
        Me.lblGrupoItem.Name = "lblGrupoItem"
        Me.lblGrupoItem.Size = New System.Drawing.Size(69, 14)
        Me.lblGrupoItem.TabIndex = 1
        Me.lblGrupoItem.Text = "Grupo - Item:"
        '
        'txtCodigoServico
        '
        Me.txtCodigoServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigoServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoServico.Location = New System.Drawing.Point(417, 34)
        Me.txtCodigoServico.MaxLength = 60
        Me.txtCodigoServico.Name = "txtCodigoServico"
        Me.txtCodigoServico.Size = New System.Drawing.Size(252, 20)
        Me.txtCodigoServico.TabIndex = 2
        '
        'lblCodigoServico
        '
        Me.lblCodigoServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodigoServico.AutoSize = True
        Me.lblCodigoServico.Location = New System.Drawing.Point(414, 17)
        Me.lblCodigoServico.Name = "lblCodigoServico"
        Me.lblCodigoServico.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigoServico.TabIndex = 3
        Me.lblCodigoServico.Text = "Código:"
        '
        'txtDescricaoServico
        '
        Me.txtDescricaoServico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoServico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricaoServico.Location = New System.Drawing.Point(9, 74)
        Me.txtDescricaoServico.MaxLength = 5000
        Me.txtDescricaoServico.Multiline = True
        Me.txtDescricaoServico.Name = "txtDescricaoServico"
        Me.txtDescricaoServico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescricaoServico.Size = New System.Drawing.Size(879, 90)
        Me.txtDescricaoServico.TabIndex = 5
        '
        'lblDescricaoServico
        '
        Me.lblDescricaoServico.AutoSize = True
        Me.lblDescricaoServico.Location = New System.Drawing.Point(6, 57)
        Me.lblDescricaoServico.Name = "lblDescricaoServico"
        Me.lblDescricaoServico.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoServico.TabIndex = 7
        Me.lblDescricaoServico.Text = "Descrição:"
        '
        'usrCadServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadServico"
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
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpNFSe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNFSe.ResumeLayout(False)
        Me.grpNFSe.PerformLayout()
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
    Friend WithEvents lblDescricaoServico As System.Windows.Forms.Label
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDescricaoServicoFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtDescricaoServico As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtCodigoServico As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoServico As System.Windows.Forms.Label
    Friend WithEvents txtCodigoServicoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoServicoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblGrupoItem As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents cboGrupoItemFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblGrupoItemFiltro As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnCadastrarGrupoItem As System.Windows.Forms.Button
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents txtCNAE As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCNAE As System.Windows.Forms.Label
    Friend WithEvents grpNFSe As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtCodigoAtividade As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoAtividade As System.Windows.Forms.Label
    Friend WithEvents txtItemServico As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblItemServico As System.Windows.Forms.Label
    Friend WithEvents lblAliquotaISS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaISS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPrecoVenda As System.Windows.Forms.Label
    Friend WithEvents txtPrecoVenda As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPercentualAproximadoTributos As System.Windows.Forms.Label
    Friend WithEvents txtPercentualAproximadoTributos As Janus.Windows.GridEX.EditControls.NumericEditBox

End Class
