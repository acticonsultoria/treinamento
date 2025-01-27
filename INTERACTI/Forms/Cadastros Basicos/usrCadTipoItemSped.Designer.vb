<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadTipoItemSped
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadTipoItemSped))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblNCM = New System.Windows.Forms.Label()
        Me.cboNCM = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoItem = New System.Windows.Forms.Label()
        Me.cboTipoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.txtDesc = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnSalvar1 = New Janus.Windows.EditControls.UIButton()
        Me.lblGrupoItem = New System.Windows.Forms.Label()
        Me.cboGrupoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataFinanceiro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFinanceiro = New System.Windows.Forms.Label()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.dtpDataCompetencia = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataCompetencia = New System.Windows.Forms.Label()
        Me.btnProcurarContaContabil = New System.Windows.Forms.Button()
        Me.lblContaContabil = New System.Windows.Forms.Label()
        Me.cboContaContabil = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarContaContabil = New System.Windows.Forms.Button()
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
        Me.tabMain.Size = New System.Drawing.Size(915, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
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
        Me.pagLista.Text = "Tipo Item Sped"
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 374)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(49, 15)
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
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(8, 114)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 277)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblNCM)
        Me.grpFiltro.Controls.Add(Me.cboNCM)
        Me.grpFiltro.Controls.Add(Me.lblTipoItem)
        Me.grpFiltro.Controls.Add(Me.cboTipoItem)
        Me.grpFiltro.Controls.Add(Me.lblCodigo)
        Me.grpFiltro.Controls.Add(Me.lblDesc)
        Me.grpFiltro.Controls.Add(Me.txtDesc)
        Me.grpFiltro.Controls.Add(Me.txtCodigo)
        Me.grpFiltro.Controls.Add(Me.btnSalvar1)
        Me.grpFiltro.Controls.Add(Me.lblGrupoItem)
        Me.grpFiltro.Controls.Add(Me.cboGrupoItem)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 105)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblNCM
        '
        Me.lblNCM.AutoSize = True
        Me.lblNCM.Location = New System.Drawing.Point(732, 17)
        Me.lblNCM.Name = "lblNCM"
        Me.lblNCM.Size = New System.Drawing.Size(32, 14)
        Me.lblNCM.TabIndex = 63
        Me.lblNCM.Text = "NCM:"
        '
        'cboNCM
        '
        Me.cboNCM.AutoSize = False
        Me.cboNCM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNCM.Location = New System.Drawing.Point(732, 34)
        Me.cboNCM.Name = "cboNCM"
        Me.cboNCM.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNCM.Size = New System.Drawing.Size(131, 20)
        Me.cboNCM.TabIndex = 64
        '
        'lblTipoItem
        '
        Me.lblTipoItem.AutoSize = True
        Me.lblTipoItem.Location = New System.Drawing.Point(8, 57)
        Me.lblTipoItem.Name = "lblTipoItem"
        Me.lblTipoItem.Size = New System.Drawing.Size(52, 14)
        Me.lblTipoItem.TabIndex = 61
        Me.lblTipoItem.Text = "Tipo Item:"
        '
        'cboTipoItem
        '
        Me.cboTipoItem.AutoSize = False
        Me.cboTipoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoItem.Location = New System.Drawing.Point(8, 74)
        Me.cboTipoItem.Name = "cboTipoItem"
        Me.cboTipoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoItem.Size = New System.Drawing.Size(217, 20)
        Me.cboTipoItem.TabIndex = 62
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(5, 17)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(65, 14)
        Me.lblCodigo.TabIndex = 60
        Me.lblCodigo.Text = "Código Item:"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(127, 17)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(59, 14)
        Me.lblDesc.TabIndex = 58
        Me.lblDesc.Text = "Descrição:"
        '
        'txtDesc
        '
        Me.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc.Location = New System.Drawing.Point(130, 34)
        Me.txtDesc.MaxLength = 100
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(373, 20)
        Me.txtDesc.TabIndex = 57
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(8, 34)
        Me.txtCodigo.MaxLength = 100
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(116, 20)
        Me.txtCodigo.TabIndex = 55
        '
        'btnSalvar1
        '
        Me.btnSalvar1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSalvar1.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar1.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar1.Location = New System.Drawing.Point(800, 71)
        Me.btnSalvar1.Name = "btnSalvar1"
        Me.btnSalvar1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar1.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar1.TabIndex = 2
        Me.btnSalvar1.Text = "Salvar"
        Me.btnSalvar1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblGrupoItem
        '
        Me.lblGrupoItem.AutoSize = True
        Me.lblGrupoItem.Location = New System.Drawing.Point(509, 17)
        Me.lblGrupoItem.Name = "lblGrupoItem"
        Me.lblGrupoItem.Size = New System.Drawing.Size(62, 14)
        Me.lblGrupoItem.TabIndex = 53
        Me.lblGrupoItem.Text = "Grupo Item:"
        '
        'cboGrupoItem
        '
        Me.cboGrupoItem.AutoSize = False
        Me.cboGrupoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoItem.Location = New System.Drawing.Point(509, 34)
        Me.cboGrupoItem.Name = "cboGrupoItem"
        Me.cboGrupoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItem.Size = New System.Drawing.Size(217, 20)
        Me.cboGrupoItem.TabIndex = 54
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(800, 42)
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
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 394)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 3
        Me.grpControl.VisualStyleManager = Me.vsmMain
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
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(8, 394)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(897, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.dtpDataFinanceiro)
        Me.grpDados.Controls.Add(Me.lblDataFinanceiro)
        Me.grpDados.Controls.Add(Me.txtValor)
        Me.grpDados.Controls.Add(Me.lblValor)
        Me.grpDados.Controls.Add(Me.dtpDataCompetencia)
        Me.grpDados.Controls.Add(Me.lblDataCompetencia)
        Me.grpDados.Controls.Add(Me.btnProcurarContaContabil)
        Me.grpDados.Controls.Add(Me.lblContaContabil)
        Me.grpDados.Controls.Add(Me.cboContaContabil)
        Me.grpDados.Controls.Add(Me.btnCadastrarContaContabil)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 120)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblAtivo
        '
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.Location = New System.Drawing.Point(807, 17)
        Me.lblAtivo.Name = "lblAtivo"
        Me.lblAtivo.Size = New System.Drawing.Size(34, 13)
        Me.lblAtivo.TabIndex = 60
        Me.lblAtivo.Text = "Ativo:"
        '
        'cboAtivo
        '
        Me.cboAtivo.AutoSize = False
        Me.cboAtivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAtivo.Location = New System.Drawing.Point(810, 34)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivo.Size = New System.Drawing.Size(81, 20)
        Me.cboAtivo.TabIndex = 61
        '
        'dtpDataFinanceiro
        '
        Me.dtpDataFinanceiro.CustomFormat = "MM/yyyy"
        Me.dtpDataFinanceiro.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpDataFinanceiro.DropDownCalendar.Name = ""
        Me.dtpDataFinanceiro.Location = New System.Drawing.Point(109, 77)
        Me.dtpDataFinanceiro.MaxDate = New Date(9998, 12, 1, 0, 0, 0, 0)
        Me.dtpDataFinanceiro.Name = "dtpDataFinanceiro"
        Me.dtpDataFinanceiro.Size = New System.Drawing.Size(82, 20)
        Me.dtpDataFinanceiro.TabIndex = 59
        '
        'lblDataFinanceiro
        '
        Me.lblDataFinanceiro.AutoSize = True
        Me.lblDataFinanceiro.Location = New System.Drawing.Point(106, 60)
        Me.lblDataFinanceiro.Name = "lblDataFinanceiro"
        Me.lblDataFinanceiro.Size = New System.Drawing.Size(85, 13)
        Me.lblDataFinanceiro.TabIndex = 58
        Me.lblDataFinanceiro.Text = "Data Financeiro:"
        '
        'txtValor
        '
        Me.txtValor.DecimalDigits = 2
        Me.txtValor.Location = New System.Drawing.Point(197, 77)
        Me.txtValor.MaxLength = 0
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(99, 20)
        Me.txtValor.TabIndex = 57
        Me.txtValor.Text = "0,00"
        Me.txtValor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(194, 60)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(34, 13)
        Me.lblValor.TabIndex = 56
        Me.lblValor.Text = "Valor:"
        '
        'dtpDataCompetencia
        '
        Me.dtpDataCompetencia.CustomFormat = "MM/yyyy"
        Me.dtpDataCompetencia.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpDataCompetencia.DropDownCalendar.Name = ""
        Me.dtpDataCompetencia.Location = New System.Drawing.Point(9, 77)
        Me.dtpDataCompetencia.MaxDate = New Date(9998, 12, 1, 0, 0, 0, 0)
        Me.dtpDataCompetencia.Name = "dtpDataCompetencia"
        Me.dtpDataCompetencia.Size = New System.Drawing.Size(94, 20)
        Me.dtpDataCompetencia.TabIndex = 55
        '
        'lblDataCompetencia
        '
        Me.lblDataCompetencia.AutoSize = True
        Me.lblDataCompetencia.Location = New System.Drawing.Point(6, 60)
        Me.lblDataCompetencia.Name = "lblDataCompetencia"
        Me.lblDataCompetencia.Size = New System.Drawing.Size(98, 13)
        Me.lblDataCompetencia.TabIndex = 54
        Me.lblDataCompetencia.Text = "Data Competência:"
        '
        'btnProcurarContaContabil
        '
        Me.btnProcurarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnProcurarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarContaContabil.Location = New System.Drawing.Point(256, 17)
        Me.btnProcurarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarContaContabil.Name = "btnProcurarContaContabil"
        Me.btnProcurarContaContabil.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarContaContabil.TabIndex = 53
        Me.btnProcurarContaContabil.TabStop = False
        Me.btnProcurarContaContabil.UseVisualStyleBackColor = True
        '
        'lblContaContabil
        '
        Me.lblContaContabil.AutoSize = True
        Me.lblContaContabil.Location = New System.Drawing.Point(22, 17)
        Me.lblContaContabil.Name = "lblContaContabil"
        Me.lblContaContabil.Size = New System.Drawing.Size(79, 13)
        Me.lblContaContabil.TabIndex = 51
        Me.lblContaContabil.Text = "Conta Contábil:"
        '
        'cboContaContabil
        '
        Me.cboContaContabil.AutoSize = False
        Me.cboContaContabil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabil.Location = New System.Drawing.Point(9, 34)
        Me.cboContaContabil.Name = "cboContaContabil"
        Me.cboContaContabil.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabil.Size = New System.Drawing.Size(267, 20)
        Me.cboContaContabil.TabIndex = 52
        '
        'btnCadastrarContaContabil
        '
        Me.btnCadastrarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaContabil.Location = New System.Drawing.Point(6, 17)
        Me.btnCadastrarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaContabil.Name = "btnCadastrarContaContabil"
        Me.btnCadastrarContaContabil.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaContabil.TabIndex = 50
        Me.btnCadastrarContaContabil.TabStop = False
        Me.btnCadastrarContaContabil.UseVisualStyleBackColor = True
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(282, 34)
        Me.txtDescricao.MaxLength = 50
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(522, 20)
        Me.txtDescricao.TabIndex = 9
        Me.txtDescricao.TabStop = False
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(279, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(58, 13)
        Me.lblDescricao.TabIndex = 8
        Me.lblDescricao.Text = "Descrição:"
        '
        'usrCadTipoItemSped
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadTipoItemSped"
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
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnProcurarContaContabil As System.Windows.Forms.Button
    Friend WithEvents lblContaContabil As System.Windows.Forms.Label
    Friend WithEvents cboContaContabil As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarContaContabil As System.Windows.Forms.Button
    Friend WithEvents dtpDataCompetencia As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataCompetencia As System.Windows.Forms.Label
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents lblGrupoItem As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents dtpDataFinanceiro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFinanceiro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnSalvar1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtDesc As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents lblTipoItem As System.Windows.Forms.Label
    Friend WithEvents cboTipoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNCM As System.Windows.Forms.Label
    Friend WithEvents cboNCM As Janus.Windows.EditControls.UIComboBox

End Class
