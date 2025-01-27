<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usrCadGrupoItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim UiComboBoxItem11 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem12 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem13 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem14 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem15 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem16 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem17 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem18 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem19 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem20 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.txtGrupoItemFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblGrupoItemFiltro = New System.Windows.Forms.Label()
        Me.trvMainGrupo = New System.Windows.Forms.TreeView()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnDuplicarEstrutura = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipoItemSPED = New System.Windows.Forms.Label()
        Me.cboTipoItemSPED = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoPerfil = New System.Windows.Forms.Label()
        Me.cboTipoPerfil = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMaterial = New System.Windows.Forms.Label()
        Me.cboMaterial = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSigla = New System.Windows.Forms.Label()
        Me.txtSigla = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblGrupoItemPai = New System.Windows.Forms.Label()
        Me.lblCodigoGrupoItem = New System.Windows.Forms.Label()
        Me.txtCodigoGrupoItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.cboGrupoItemPai = New Janus.Windows.EditControls.UIComboBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
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
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpFiltro)
        Me.pagDados.Controls.Add(Me.trvMainGrupo)
        Me.pagDados.Controls.Add(Me.grpControl)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Grupo de Item"
        '
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.txtGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblGrupoItemFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(343, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(243, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 16
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtGrupoItemFiltro
        '
        Me.txtGrupoItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrupoItemFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtGrupoItemFiltro.MaxLength = 100
        Me.txtGrupoItemFiltro.Name = "txtGrupoItemFiltro"
        Me.txtGrupoItemFiltro.Size = New System.Drawing.Size(218, 20)
        Me.txtGrupoItemFiltro.TabIndex = 1
        '
        'lblGrupoItemFiltro
        '
        Me.lblGrupoItemFiltro.AutoSize = True
        Me.lblGrupoItemFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblGrupoItemFiltro.Name = "lblGrupoItemFiltro"
        Me.lblGrupoItemFiltro.Size = New System.Drawing.Size(77, 14)
        Me.lblGrupoItemFiltro.TabIndex = 0
        Me.lblGrupoItemFiltro.Text = "Grupo de Item:"
        '
        'trvMainGrupo
        '
        Me.trvMainGrupo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvMainGrupo.CheckBoxes = True
        Me.trvMainGrupo.FullRowSelect = True
        Me.trvMainGrupo.ItemHeight = 20
        Me.trvMainGrupo.Location = New System.Drawing.Point(8, 76)
        Me.trvMainGrupo.Name = "trvMainGrupo"
        Me.trvMainGrupo.ShowLines = False
        Me.trvMainGrupo.ShowNodeToolTips = True
        Me.trvMainGrupo.Size = New System.Drawing.Size(343, 404)
        Me.trvMainGrupo.TabIndex = 1
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnDuplicarEstrutura)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Controls.Add(Me.btnNovo)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 3
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnDuplicarEstrutura
        '
        Me.btnDuplicarEstrutura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDuplicarEstrutura.Image = Global.INTERACTI.My.Resources.Resources.duplicar
        Me.btnDuplicarEstrutura.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnDuplicarEstrutura.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnDuplicarEstrutura.Location = New System.Drawing.Point(337, 17)
        Me.btnDuplicarEstrutura.Name = "btnDuplicarEstrutura"
        Me.btnDuplicarEstrutura.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnDuplicarEstrutura.Size = New System.Drawing.Size(163, 23)
        Me.btnDuplicarEstrutura.TabIndex = 4
        Me.btnDuplicarEstrutura.Text = "Duplicar Estrutura"
        Me.btnDuplicarEstrutura.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(506, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 0
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.btnNovo.TabIndex = 1
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
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
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblTipoItemSPED)
        Me.grpDados.Controls.Add(Me.cboTipoItemSPED)
        Me.grpDados.Controls.Add(Me.lblTipoPerfil)
        Me.grpDados.Controls.Add(Me.cboTipoPerfil)
        Me.grpDados.Controls.Add(Me.lblMaterial)
        Me.grpDados.Controls.Add(Me.cboMaterial)
        Me.grpDados.Controls.Add(Me.lblSigla)
        Me.grpDados.Controls.Add(Me.txtSigla)
        Me.grpDados.Controls.Add(Me.lblGrupoItemPai)
        Me.grpDados.Controls.Add(Me.lblCodigoGrupoItem)
        Me.grpDados.Controls.Add(Me.txtCodigoGrupoItem)
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Controls.Add(Me.cboGrupoItemPai)
        Me.grpDados.Location = New System.Drawing.Point(360, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(545, 233)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblTipoItemSPED
        '
        Me.lblTipoItemSPED.AutoSize = True
        Me.lblTipoItemSPED.Location = New System.Drawing.Point(7, 184)
        Me.lblTipoItemSPED.Name = "lblTipoItemSPED"
        Me.lblTipoItemSPED.Size = New System.Drawing.Size(81, 14)
        Me.lblTipoItemSPED.TabIndex = 16
        Me.lblTipoItemSPED.Text = "Tipo Item SPED:"
        '
        'cboTipoItemSPED
        '
        Me.cboTipoItemSPED.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoItemSPED.AutoSize = False
        Me.cboTipoItemSPED.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem11.FormatStyle.Alpha = 0
        UiComboBoxItem11.IsSeparator = False
        UiComboBoxItem11.Text = "SIM"
        UiComboBoxItem11.Value = True
        UiComboBoxItem12.FormatStyle.Alpha = 0
        UiComboBoxItem12.IsSeparator = False
        UiComboBoxItem12.Text = "NÃO"
        UiComboBoxItem12.Value = False
        Me.cboTipoItemSPED.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem11, UiComboBoxItem12})
        Me.cboTipoItemSPED.Location = New System.Drawing.Point(10, 201)
        Me.cboTipoItemSPED.Name = "cboTipoItemSPED"
        Me.cboTipoItemSPED.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoItemSPED.Size = New System.Drawing.Size(526, 20)
        Me.cboTipoItemSPED.TabIndex = 17
        '
        'lblTipoPerfil
        '
        Me.lblTipoPerfil.AutoSize = True
        Me.lblTipoPerfil.Location = New System.Drawing.Point(7, 141)
        Me.lblTipoPerfil.Name = "lblTipoPerfil"
        Me.lblTipoPerfil.Size = New System.Drawing.Size(57, 14)
        Me.lblTipoPerfil.TabIndex = 12
        Me.lblTipoPerfil.Text = "Tipo Perfil:"
        '
        'cboTipoPerfil
        '
        Me.cboTipoPerfil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoPerfil.AutoSize = False
        Me.cboTipoPerfil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem13.FormatStyle.Alpha = 0
        UiComboBoxItem13.IsSeparator = False
        UiComboBoxItem13.Text = "SIM"
        UiComboBoxItem13.Value = True
        UiComboBoxItem14.FormatStyle.Alpha = 0
        UiComboBoxItem14.IsSeparator = False
        UiComboBoxItem14.Text = "NÃO"
        UiComboBoxItem14.Value = False
        Me.cboTipoPerfil.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem13, UiComboBoxItem14})
        Me.cboTipoPerfil.Location = New System.Drawing.Point(10, 158)
        Me.cboTipoPerfil.Name = "cboTipoPerfil"
        Me.cboTipoPerfil.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoPerfil.Size = New System.Drawing.Size(526, 20)
        Me.cboTipoPerfil.TabIndex = 13
        '
        'lblMaterial
        '
        Me.lblMaterial.AutoSize = True
        Me.lblMaterial.Location = New System.Drawing.Point(7, 99)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(47, 14)
        Me.lblMaterial.TabIndex = 10
        Me.lblMaterial.Text = "Material:"
        '
        'cboMaterial
        '
        Me.cboMaterial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMaterial.AutoSize = False
        Me.cboMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem15.FormatStyle.Alpha = 0
        UiComboBoxItem15.IsSeparator = False
        UiComboBoxItem15.Text = "SIM"
        UiComboBoxItem15.Value = True
        UiComboBoxItem16.FormatStyle.Alpha = 0
        UiComboBoxItem16.IsSeparator = False
        UiComboBoxItem16.Text = "NÃO"
        UiComboBoxItem16.Value = False
        Me.cboMaterial.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem15, UiComboBoxItem16})
        Me.cboMaterial.Location = New System.Drawing.Point(10, 116)
        Me.cboMaterial.Name = "cboMaterial"
        Me.cboMaterial.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMaterial.Size = New System.Drawing.Size(526, 20)
        Me.cboMaterial.TabIndex = 11
        '
        'lblSigla
        '
        Me.lblSigla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSigla.AutoSize = True
        Me.lblSigla.Location = New System.Drawing.Point(443, 17)
        Me.lblSigla.Name = "lblSigla"
        Me.lblSigla.Size = New System.Drawing.Size(33, 14)
        Me.lblSigla.TabIndex = 4
        Me.lblSigla.Text = "Sigla:"
        '
        'txtSigla
        '
        Me.txtSigla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSigla.Location = New System.Drawing.Point(446, 34)
        Me.txtSigla.MaxLength = 20
        Me.txtSigla.Name = "txtSigla"
        Me.txtSigla.Size = New System.Drawing.Size(90, 20)
        Me.txtSigla.TabIndex = 5
        '
        'lblGrupoItemPai
        '
        Me.lblGrupoItemPai.AutoSize = True
        Me.lblGrupoItemPai.Location = New System.Drawing.Point(6, 57)
        Me.lblGrupoItemPai.Name = "lblGrupoItemPai"
        Me.lblGrupoItemPai.Size = New System.Drawing.Size(94, 14)
        Me.lblGrupoItemPai.TabIndex = 6
        Me.lblGrupoItemPai.Text = "Grupo de Item Pai:"
        '
        'lblCodigoGrupoItem
        '
        Me.lblCodigoGrupoItem.AutoSize = True
        Me.lblCodigoGrupoItem.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigoGrupoItem.Name = "lblCodigoGrupoItem"
        Me.lblCodigoGrupoItem.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigoGrupoItem.TabIndex = 0
        Me.lblCodigoGrupoItem.Text = "Código:"
        '
        'txtCodigoGrupoItem
        '
        Me.txtCodigoGrupoItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigoGrupoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoGrupoItem.DisabledBackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigoGrupoItem.Location = New System.Drawing.Point(9, 34)
        Me.txtCodigoGrupoItem.MaxLength = 20
        Me.txtCodigoGrupoItem.Name = "txtCodigoGrupoItem"
        Me.txtCodigoGrupoItem.ReadOnly = True
        Me.txtCodigoGrupoItem.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigoGrupoItem.TabIndex = 1
        '
        'lblAtivo
        '
        Me.lblAtivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.Location = New System.Drawing.Point(443, 57)
        Me.lblAtivo.Name = "lblAtivo"
        Me.lblAtivo.Size = New System.Drawing.Size(35, 14)
        Me.lblAtivo.TabIndex = 8
        Me.lblAtivo.Text = "Ativo:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(135, 34)
        Me.txtDescricao.MaxLength = 100
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(304, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'cboAtivo
        '
        Me.cboAtivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAtivo.AutoSize = False
        Me.cboAtivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem17.FormatStyle.Alpha = 0
        UiComboBoxItem17.IsSeparator = False
        UiComboBoxItem17.Text = "SIM"
        UiComboBoxItem17.Value = True
        UiComboBoxItem18.FormatStyle.Alpha = 0
        UiComboBoxItem18.IsSeparator = False
        UiComboBoxItem18.Text = "NÃO"
        UiComboBoxItem18.Value = False
        Me.cboAtivo.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem17, UiComboBoxItem18})
        Me.cboAtivo.Location = New System.Drawing.Point(446, 74)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivo.Size = New System.Drawing.Size(90, 20)
        Me.cboAtivo.TabIndex = 9
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
        'cboGrupoItemPai
        '
        Me.cboGrupoItemPai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboGrupoItemPai.AutoSize = False
        Me.cboGrupoItemPai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem19.FormatStyle.Alpha = 0
        UiComboBoxItem19.IsSeparator = False
        UiComboBoxItem19.Text = "SIM"
        UiComboBoxItem19.Value = True
        UiComboBoxItem20.FormatStyle.Alpha = 0
        UiComboBoxItem20.IsSeparator = False
        UiComboBoxItem20.Text = "NÃO"
        UiComboBoxItem20.Value = False
        Me.cboGrupoItemPai.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem19, UiComboBoxItem20})
        Me.cboGrupoItemPai.Location = New System.Drawing.Point(9, 74)
        Me.cboGrupoItemPai.Name = "cboGrupoItemPai"
        Me.cboGrupoItemPai.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItemPai.Size = New System.Drawing.Size(431, 20)
        Me.cboGrupoItemPai.TabIndex = 7
        '
        'usrCadGrupoItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadGrupoItem"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents trvMainGrupo As System.Windows.Forms.TreeView
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtGrupoItemFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblGrupoItemFiltro As System.Windows.Forms.Label
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblGrupoItemPai As System.Windows.Forms.Label
    Friend WithEvents lblCodigoGrupoItem As System.Windows.Forms.Label
    Friend WithEvents txtCodigoGrupoItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItemPai As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSigla As System.Windows.Forms.Label
    Friend WithEvents txtSigla As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipoPerfil As System.Windows.Forms.Label
    Friend WithEvents cboTipoPerfil As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMaterial As System.Windows.Forms.Label
    Friend WithEvents cboMaterial As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoItemSPED As System.Windows.Forms.Label
    Friend WithEvents cboTipoItemSPED As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnDuplicarEstrutura As Janus.Windows.EditControls.UIButton
End Class
