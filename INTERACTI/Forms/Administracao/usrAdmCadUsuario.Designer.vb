<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrAdmCadUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrAdmCadUsuario))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings2 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboDepartamentoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDepartamentoFiltro = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUsuarioFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboPerfilFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNomeFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarFuncionario = New System.Windows.Forms.Button()
        Me.cboFuncionario = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.grpAssinaturaDigital = New Janus.Windows.EditControls.UIGroupBox()
        Me.picAssinaturaDigital = New System.Windows.Forms.PictureBox()
        Me.btnLimparArquivo = New Janus.Windows.EditControls.UIButton()
        Me.txtAssinaturaDigital = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblAssinaturaDigital = New System.Windows.Forms.Label()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarVendedor = New System.Windows.Forms.Button()
        Me.cboVendedor = New Janus.Windows.EditControls.UIComboBox()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtRamal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRamal = New System.Windows.Forms.Label()
        Me.txtCelular = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.btnCadastrarPerfil = New System.Windows.Forms.Button()
        Me.btnCadastrarDepartamento = New System.Windows.Forms.Button()
        Me.txtTelefone = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.cboDepartamento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblConfirmarSenha = New System.Windows.Forms.Label()
        Me.txtConfirmarSenha = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.txtSenha = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboPerfil = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPerfil = New System.Windows.Forms.Label()
        Me.txtNome = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.grpAssinaturaDigital, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAssinaturaDigital.SuspendLayout()
        CType(Me.picAssinaturaDigital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
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
        resources.ApplyResources(Me.tabMain, "tabMain")
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
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
        resources.ApplyResources(Me.pagLista, "pagLista")
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Name = "pagLista"
        Me.pagLista.TabStop = True
        '
        'btnExcelGrid
        '
        resources.ApplyResources(Me.btnExcelGrid, "btnExcelGrid")
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        resources.ApplyResources(Me.btnAgruparGrid, "btnAgruparGrid")
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        resources.ApplyResources(Me.btnConfigurarGrid, "btnConfigurarGrid")
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        resources.ApplyResources(Me.grdListagem, "grdListagem")
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        resources.ApplyResources(grdListagem_DesignTimeLayout, "grdListagem_DesignTimeLayout")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.FrozenColumns = 2
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        resources.ApplyResources(Me.grpFiltro, "grpFiltro")
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboDepartamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDepartamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.Label7)
        Me.grpFiltro.Controls.Add(Me.txtUsuarioFiltro)
        Me.grpFiltro.Controls.Add(Me.cboPerfilFiltro)
        Me.grpFiltro.Controls.Add(Me.Label6)
        Me.grpFiltro.Controls.Add(Me.txtNomeFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboDepartamentoFiltro
        '
        resources.ApplyResources(Me.cboDepartamentoFiltro, "cboDepartamentoFiltro")
        Me.cboDepartamentoFiltro.Name = "cboDepartamentoFiltro"
        Me.cboDepartamentoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblDepartamentoFiltro
        '
        resources.ApplyResources(Me.lblDepartamentoFiltro, "lblDepartamentoFiltro")
        Me.lblDepartamentoFiltro.Name = "lblDepartamentoFiltro"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'txtUsuarioFiltro
        '
        Me.txtUsuarioFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtUsuarioFiltro, "txtUsuarioFiltro")
        Me.txtUsuarioFiltro.MaxLength = 20
        Me.txtUsuarioFiltro.Name = "txtUsuarioFiltro"
        '
        'cboPerfilFiltro
        '
        resources.ApplyResources(Me.cboPerfilFiltro, "cboPerfilFiltro")
        Me.cboPerfilFiltro.Name = "cboPerfilFiltro"
        Me.cboPerfilFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'txtNomeFiltro
        '
        Me.txtNomeFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtNomeFiltro, "txtNomeFiltro")
        Me.txtNomeFiltro.MaxLength = 70
        Me.txtNomeFiltro.Name = "txtNomeFiltro"
        '
        'lblDescricaoFiltro
        '
        resources.ApplyResources(Me.lblDescricaoFiltro, "lblDescricaoFiltro")
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        '
        'btnFiltrar
        '
        resources.ApplyResources(Me.btnFiltrar, "btnFiltrar")
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControl
        '
        resources.ApplyResources(Me.grpControl, "grpControl")
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.lblCongelarColuna)
        Me.grpControl.Controls.Add(Me.cboCongelarColuna)
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        resources.ApplyResources(Me.lblCongelarColuna, "lblCongelarColuna")
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        '
        'cboCongelarColuna
        '
        resources.ApplyResources(Me.cboCongelarColuna, "cboCongelarColuna")
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.TabStop = False
        '
        'btnNovo1
        '
        resources.ApplyResources(Me.btnNovo1, "btnNovo1")
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        resources.ApplyResources(Me.btnSair, "btnSair")
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        resources.ApplyResources(Me.btnExcluir, "btnExcluir")
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.UiGroupBox2)
        Me.pagDados.Controls.Add(Me.grpAssinaturaDigital)
        Me.pagDados.Controls.Add(Me.UiGroupBox1)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        resources.ApplyResources(Me.pagDados, "pagDados")
        Me.pagDados.Key = "padDados"
        Me.pagDados.Name = "pagDados"
        Me.pagDados.TabStop = True
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.btnCadastrarFuncionario)
        Me.UiGroupBox2.Controls.Add(Me.cboFuncionario)
        Me.UiGroupBox2.Controls.Add(Me.lblFuncionario)
        Me.UiGroupBox2.FormatStyle.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.UiGroupBox2, "UiGroupBox2")
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox2.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarFuncionario
        '
        Me.btnCadastrarFuncionario.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarFuncionario, "btnCadastrarFuncionario")
        Me.btnCadastrarFuncionario.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario"
        Me.btnCadastrarFuncionario.TabStop = False
        Me.btnCadastrarFuncionario.UseVisualStyleBackColor = True
        '
        'cboFuncionario
        '
        resources.ApplyResources(Me.cboFuncionario, "cboFuncionario")
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblFuncionario
        '
        resources.ApplyResources(Me.lblFuncionario, "lblFuncionario")
        Me.lblFuncionario.Name = "lblFuncionario"
        '
        'grpAssinaturaDigital
        '
        Me.grpAssinaturaDigital.BackColor = System.Drawing.Color.Transparent
        Me.grpAssinaturaDigital.Controls.Add(Me.picAssinaturaDigital)
        Me.grpAssinaturaDigital.Controls.Add(Me.btnLimparArquivo)
        Me.grpAssinaturaDigital.Controls.Add(Me.txtAssinaturaDigital)
        Me.grpAssinaturaDigital.Controls.Add(Me.btnArquivo)
        Me.grpAssinaturaDigital.Controls.Add(Me.lblAssinaturaDigital)
        Me.grpAssinaturaDigital.FormatStyle.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.grpAssinaturaDigital, "grpAssinaturaDigital")
        Me.grpAssinaturaDigital.Name = "grpAssinaturaDigital"
        Me.grpAssinaturaDigital.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpAssinaturaDigital.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpAssinaturaDigital.VisualStyleManager = Me.vsmMain
        '
        'picAssinaturaDigital
        '
        resources.ApplyResources(Me.picAssinaturaDigital, "picAssinaturaDigital")
        Me.picAssinaturaDigital.BackColor = System.Drawing.SystemColors.Window
        Me.picAssinaturaDigital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAssinaturaDigital.Name = "picAssinaturaDigital"
        Me.picAssinaturaDigital.TabStop = False
        '
        'btnLimparArquivo
        '
        resources.ApplyResources(Me.btnLimparArquivo, "btnLimparArquivo")
        Me.btnLimparArquivo.Image = Global.INTERACTI.My.Resources.Resources.limpar
        Me.btnLimparArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnLimparArquivo.Name = "btnLimparArquivo"
        Me.btnLimparArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        SuperTipSettings1.HeaderText = "Assinatura Digital"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = "Clique para apagar o Arquivo selecionado"
        Me.jstTip.SetSuperTip(Me.btnLimparArquivo, SuperTipSettings1)
        Me.btnLimparArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtAssinaturaDigital
        '
        resources.ApplyResources(Me.txtAssinaturaDigital, "txtAssinaturaDigital")
        Me.txtAssinaturaDigital.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAssinaturaDigital.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAssinaturaDigital.MaxLength = 60
        Me.txtAssinaturaDigital.Name = "txtAssinaturaDigital"
        Me.txtAssinaturaDigital.ReadOnly = True
        Me.txtAssinaturaDigital.TabStop = False
        '
        'btnArquivo
        '
        resources.ApplyResources(Me.btnArquivo, "btnArquivo")
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        SuperTipSettings2.HeaderText = "Assinatura Digital"
        SuperTipSettings2.ImageListProvider = Nothing
        SuperTipSettings2.Text = "Clique para selecionar o Arquivo"
        Me.jstTip.SetSuperTip(Me.btnArquivo, SuperTipSettings2)
        Me.btnArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblAssinaturaDigital
        '
        resources.ApplyResources(Me.lblAssinaturaDigital, "lblAssinaturaDigital")
        Me.lblAssinaturaDigital.Name = "lblAssinaturaDigital"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.btnCadastrarVendedor)
        Me.UiGroupBox1.Controls.Add(Me.cboVendedor)
        Me.UiGroupBox1.Controls.Add(Me.lblVendedor)
        Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.UiGroupBox1, "UiGroupBox1")
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarVendedor
        '
        Me.btnCadastrarVendedor.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarVendedor, "btnCadastrarVendedor")
        Me.btnCadastrarVendedor.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarVendedor.Name = "btnCadastrarVendedor"
        Me.btnCadastrarVendedor.TabStop = False
        Me.btnCadastrarVendedor.UseVisualStyleBackColor = True
        '
        'cboVendedor
        '
        resources.ApplyResources(Me.cboVendedor, "cboVendedor")
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblVendedor
        '
        resources.ApplyResources(Me.lblVendedor, "lblVendedor")
        Me.lblVendedor.Name = "lblVendedor"
        '
        'grpControl2
        '
        resources.ApplyResources(Me.grpControl2, "grpControl2")
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        resources.ApplyResources(Me.btnNovo, "btnNovo")
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        resources.ApplyResources(Me.btnVoltar, "btnVoltar")
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        resources.ApplyResources(Me.btnSalvar, "btnSalvar")
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        resources.ApplyResources(Me.grpDados, "grpDados")
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtRamal)
        Me.grpDados.Controls.Add(Me.lblRamal)
        Me.grpDados.Controls.Add(Me.txtCelular)
        Me.grpDados.Controls.Add(Me.lblCelular)
        Me.grpDados.Controls.Add(Me.btnCadastrarPerfil)
        Me.grpDados.Controls.Add(Me.btnCadastrarDepartamento)
        Me.grpDados.Controls.Add(Me.txtTelefone)
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.cboDepartamento)
        Me.grpDados.Controls.Add(Me.lblDepartamento)
        Me.grpDados.Controls.Add(Me.lblTelefone)
        Me.grpDados.Controls.Add(Me.lblEmail)
        Me.grpDados.Controls.Add(Me.txtEmail)
        Me.grpDados.Controls.Add(Me.lblConfirmarSenha)
        Me.grpDados.Controls.Add(Me.txtConfirmarSenha)
        Me.grpDados.Controls.Add(Me.lblSenha)
        Me.grpDados.Controls.Add(Me.txtSenha)
        Me.grpDados.Controls.Add(Me.lblUsuario)
        Me.grpDados.Controls.Add(Me.txtUsuario)
        Me.grpDados.Controls.Add(Me.cboPerfil)
        Me.grpDados.Controls.Add(Me.lblPerfil)
        Me.grpDados.Controls.Add(Me.txtNome)
        Me.grpDados.Controls.Add(Me.lblNome)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtRamal
        '
        resources.ApplyResources(Me.txtRamal, "txtRamal")
        Me.txtRamal.MaxLength = 20
        Me.txtRamal.Name = "txtRamal"
        Me.txtRamal.Numeric = True
        '
        'lblRamal
        '
        resources.ApplyResources(Me.lblRamal, "lblRamal")
        Me.lblRamal.Name = "lblRamal"
        '
        'txtCelular
        '
        resources.ApplyResources(Me.txtCelular, "txtCelular")
        Me.txtCelular.Mask = "(00) 0000-0000"
        Me.txtCelular.MaxLength = 20
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Numeric = True
        '
        'lblCelular
        '
        resources.ApplyResources(Me.lblCelular, "lblCelular")
        Me.lblCelular.Name = "lblCelular"
        '
        'btnCadastrarPerfil
        '
        Me.btnCadastrarPerfil.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarPerfil, "btnCadastrarPerfil")
        Me.btnCadastrarPerfil.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarPerfil.Name = "btnCadastrarPerfil"
        Me.btnCadastrarPerfil.TabStop = False
        Me.btnCadastrarPerfil.UseVisualStyleBackColor = True
        '
        'btnCadastrarDepartamento
        '
        Me.btnCadastrarDepartamento.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarDepartamento, "btnCadastrarDepartamento")
        Me.btnCadastrarDepartamento.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarDepartamento.Name = "btnCadastrarDepartamento"
        Me.btnCadastrarDepartamento.TabStop = False
        Me.btnCadastrarDepartamento.UseVisualStyleBackColor = True
        '
        'txtTelefone
        '
        resources.ApplyResources(Me.txtTelefone, "txtTelefone")
        Me.txtTelefone.Mask = "(00) 0000-0000"
        Me.txtTelefone.MaxLength = 20
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Numeric = True
        '
        'lblAtivo
        '
        resources.ApplyResources(Me.lblAtivo, "lblAtivo")
        Me.lblAtivo.Name = "lblAtivo"
        '
        'cboAtivo
        '
        resources.ApplyResources(Me.cboAtivo, "cboAtivo")
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem1, "UiComboBoxItem1")
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem2, "UiComboBoxItem2")
        Me.cboAtivo.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'cboDepartamento
        '
        resources.ApplyResources(Me.cboDepartamento, "cboDepartamento")
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblDepartamento
        '
        resources.ApplyResources(Me.lblDepartamento, "lblDepartamento")
        Me.lblDepartamento.Name = "lblDepartamento"
        '
        'lblTelefone
        '
        resources.ApplyResources(Me.lblTelefone, "lblTelefone")
        Me.lblTelefone.Name = "lblTelefone"
        '
        'lblEmail
        '
        resources.ApplyResources(Me.lblEmail, "lblEmail")
        Me.lblEmail.Name = "lblEmail"
        '
        'txtEmail
        '
        resources.ApplyResources(Me.txtEmail, "txtEmail")
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        '
        'lblConfirmarSenha
        '
        resources.ApplyResources(Me.lblConfirmarSenha, "lblConfirmarSenha")
        Me.lblConfirmarSenha.Name = "lblConfirmarSenha"
        '
        'txtConfirmarSenha
        '
        Me.txtConfirmarSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtConfirmarSenha, "txtConfirmarSenha")
        Me.txtConfirmarSenha.MaxLength = 20
        Me.txtConfirmarSenha.Name = "txtConfirmarSenha"
        Me.txtConfirmarSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        '
        'lblSenha
        '
        resources.ApplyResources(Me.lblSenha, "lblSenha")
        Me.lblSenha.Name = "lblSenha"
        '
        'txtSenha
        '
        Me.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtSenha, "txtSenha")
        Me.txtSenha.MaxLength = 20
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        '
        'lblUsuario
        '
        resources.ApplyResources(Me.lblUsuario, "lblUsuario")
        Me.lblUsuario.Name = "lblUsuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtUsuario, "txtUsuario")
        Me.txtUsuario.MaxLength = 20
        Me.txtUsuario.Name = "txtUsuario"
        '
        'cboPerfil
        '
        resources.ApplyResources(Me.cboPerfil, "cboPerfil")
        Me.cboPerfil.Name = "cboPerfil"
        Me.cboPerfil.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblPerfil
        '
        resources.ApplyResources(Me.lblPerfil, "lblPerfil")
        Me.lblPerfil.Name = "lblPerfil"
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtNome, "txtNome")
        Me.txtNome.MaxLength = 70
        Me.txtNome.Name = "txtNome"
        '
        'lblNome
        '
        resources.ApplyResources(Me.lblNome, "lblNome")
        Me.lblNome.Name = "lblNome"
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 3000
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'usrAdmCadUsuario
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrAdmCadUsuario"
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
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.grpAssinaturaDigital, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAssinaturaDigital.ResumeLayout(False)
        Me.grpAssinaturaDigital.PerformLayout()
        CType(Me.picAssinaturaDigital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
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
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNome As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNomeFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboPerfil As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblPerfil As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblConfirmarSenha As System.Windows.Forms.Label
    Friend WithEvents txtConfirmarSenha As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblSenha As System.Windows.Forms.Label
    Friend WithEvents txtSenha As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblTelefone As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboPerfilFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboDepartamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents cboDepartamentoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDepartamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtTelefone As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnCadastrarPerfil As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarDepartamento As System.Windows.Forms.Button
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarVendedor As System.Windows.Forms.Button
    Friend WithEvents cboVendedor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblVendedor As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents txtRamal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRamal As System.Windows.Forms.Label
    Friend WithEvents txtCelular As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents grpAssinaturaDigital As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtAssinaturaDigital As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblAssinaturaDigital As System.Windows.Forms.Label
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnLimparArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents picAssinaturaDigital As System.Windows.Forms.PictureBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarFuncionario As Button
    Friend WithEvents cboFuncionario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFuncionario As Label
End Class
