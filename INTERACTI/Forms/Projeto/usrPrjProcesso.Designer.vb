<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrjProcesso
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
        Dim JanusColorScheme7 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim cboFaseFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdEtapa_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdEtapa_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrjProcesso))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelDados = New System.Windows.Forms.Button()
        Me.btnAgruparGridDados = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboFaseFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblFaseFiltro = New System.Windows.Forms.Label()
        Me.lblPartNumberFiltro = New System.Windows.Forms.Label()
        Me.txtPartNumberFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.btnConfigurarGridDados = New System.Windows.Forms.Button()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnAlterarLote = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.grpEtapa = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.dtpDataResposta = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataResposta = New System.Windows.Forms.Label()
        Me.dtpDataTermino = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataTermino = New System.Windows.Forms.Label()
        Me.dtpDataInicio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.dtpDataPrevisao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPrevisao = New System.Windows.Forms.Label()
        Me.lblEtapa = New System.Windows.Forms.Label()
        Me.txtEtapa = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnInserirEtapa = New Janus.Windows.EditControls.UIButton()
        Me.grdEtapa = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDadosPedido = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataConclusaoValidacao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblConclusaoValidacao = New System.Windows.Forms.Label()
        Me.dtpDataEntrega = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEntrega = New System.Windows.Forms.Label()
        Me.dtpDataLiberacaoProducao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblLiberacaoProducao = New System.Windows.Forms.Label()
        Me.chkInovacao = New Janus.Windows.EditControls.UICheckBox()
        Me.dtpDataLiberacaoCliente = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataLiberacaoCliente = New System.Windows.Forms.Label()
        Me.cboProjetista = New Janus.Windows.EditControls.UIComboBox()
        Me.lblProjetista = New System.Windows.Forms.Label()
        Me.cboInternoExterno = New Janus.Windows.EditControls.UIComboBox()
        Me.lblInternoExterno = New System.Windows.Forms.Label()
        Me.lblCodigoCliente = New System.Windows.Forms.Label()
        Me.txtCodigoCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboFase = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFase = New System.Windows.Forms.Label()
        Me.txtCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtPartNumber = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboTipoProjeto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoProjeto = New System.Windows.Forms.Label()
        Me.txtPOLinha = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPOLinha = New System.Windows.Forms.Label()
        Me.lblOrdemProducao = New System.Windows.Forms.Label()
        Me.txtPO = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboOrdemProducao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPO = New System.Windows.Forms.Label()
        Me.lblRC = New System.Windows.Forms.Label()
        Me.dtpDataProjeto = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtNs = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataProjeto = New System.Windows.Forms.Label()
        Me.txtOM = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNs = New System.Windows.Forms.Label()
        Me.txtRC = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtAtivoFixo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOM = New System.Windows.Forms.Label()
        Me.lblAtivoFixo = New System.Windows.Forms.Label()
        Me.lblPartNumber = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDados.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grpEtapa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEtapa.SuspendLayout()
        CType(Me.grdEtapa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpDadosPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosPedido.SuspendLayout()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme7.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme7.Name = "Scheme"
        JanusColorScheme7.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme7.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme7.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme7)
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
        Me.tabMain.Size = New System.Drawing.Size(1000, 541)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnExcelDados)
        Me.pagLista.Controls.Add(Me.btnAgruparGridDados)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.btnConfigurarGridDados)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 518)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Projeto - Processo"
        '
        'btnExcelDados
        '
        Me.btnExcelDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelDados.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelDados.FlatAppearance.BorderSize = 0
        Me.btnExcelDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelDados.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelDados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelDados.Location = New System.Drawing.Point(64, 435)
        Me.btnExcelDados.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelDados.Name = "btnExcelDados"
        Me.btnExcelDados.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelDados.TabIndex = 32
        Me.btnExcelDados.TabStop = False
        Me.btnExcelDados.UseVisualStyleBackColor = False
        '
        'btnAgruparGridDados
        '
        Me.btnAgruparGridDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridDados.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridDados.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridDados.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridDados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridDados.Location = New System.Drawing.Point(38, 435)
        Me.btnAgruparGridDados.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridDados.Name = "btnAgruparGridDados"
        Me.btnAgruparGridDados.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridDados.TabIndex = 31
        Me.btnAgruparGridDados.TabStop = False
        Me.btnAgruparGridDados.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboFaseFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFaseFiltro)
        Me.grpFiltro.Controls.Add(Me.lblPartNumberFiltro)
        Me.grpFiltro.Controls.Add(Me.txtPartNumberFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 67)
        Me.grpFiltro.TabIndex = 93
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboFaseFiltro
        '
        Me.cboFaseFiltro.AllowDrop = True
        Me.cboFaseFiltro.ButtonCancelText = "Cancelar"
        Me.cboFaseFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboFaseFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboFaseFiltro_DesignTimeLayout.LayoutString")
        Me.cboFaseFiltro.DesignTimeLayout = cboFaseFiltro_DesignTimeLayout
        Me.cboFaseFiltro.Location = New System.Drawing.Point(489, 35)
        Me.cboFaseFiltro.Name = "cboFaseFiltro"
        Me.cboFaseFiltro.SaveSettings = False
        Me.cboFaseFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboFaseFiltro.Size = New System.Drawing.Size(175, 20)
        Me.cboFaseFiltro.TabIndex = 3
        Me.cboFaseFiltro.ValuesDataMember = Nothing
        '
        'lblFaseFiltro
        '
        Me.lblFaseFiltro.AutoSize = True
        Me.lblFaseFiltro.BackColor = System.Drawing.Color.Transparent
        Me.lblFaseFiltro.Location = New System.Drawing.Point(486, 17)
        Me.lblFaseFiltro.Name = "lblFaseFiltro"
        Me.lblFaseFiltro.Size = New System.Drawing.Size(34, 14)
        Me.lblFaseFiltro.TabIndex = 84
        Me.lblFaseFiltro.Text = "Fase:"
        '
        'lblPartNumberFiltro
        '
        Me.lblPartNumberFiltro.AutoSize = True
        Me.lblPartNumberFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblPartNumberFiltro.Name = "lblPartNumberFiltro"
        Me.lblPartNumberFiltro.Size = New System.Drawing.Size(69, 14)
        Me.lblPartNumberFiltro.TabIndex = 80
        Me.lblPartNumberFiltro.Text = "Part Number:"
        '
        'txtPartNumberFiltro
        '
        Me.txtPartNumberFiltro.IncludeLiterals = False
        Me.txtPartNumberFiltro.Location = New System.Drawing.Point(9, 35)
        Me.txtPartNumberFiltro.MaxLength = 100
        Me.txtPartNumberFiltro.Name = "txtPartNumberFiltro"
        Me.txtPartNumberFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtPartNumberFiltro.Size = New System.Drawing.Size(474, 20)
        Me.txtPartNumberFiltro.TabIndex = 2
        Me.txtPartNumberFiltro.TabStop = False
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 32)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 6
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnConfigurarGridDados
        '
        Me.btnConfigurarGridDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridDados.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridDados.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridDados.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridDados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridDados.Location = New System.Drawing.Point(14, 435)
        Me.btnConfigurarGridDados.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridDados.Name = "btnConfigurarGridDados"
        Me.btnConfigurarGridDados.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridDados.TabIndex = 30
        Me.btnConfigurarGridDados.TabStop = False
        Me.btnConfigurarGridDados.UseVisualStyleBackColor = False
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnAlterarLote)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 458)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(982, 51)
        Me.grpControl.TabIndex = 0
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnAlterarLote
        '
        Me.btnAlterarLote.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnAlterarLote.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAlterarLote.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnAlterarLote.Location = New System.Drawing.Point(18, 17)
        Me.btnAlterarLote.Name = "btnAlterarLote"
        Me.btnAlterarLote.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAlterarLote.Size = New System.Drawing.Size(150, 23)
        Me.btnAlterarLote.TabIndex = 3
        Me.btnAlterarLote.Text = "Atualização em lote"
        Me.btnAlterarLote.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.Location = New System.Drawing.Point(785, 18)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 1
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(688, 18)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 0
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
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 5
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(9, 76)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(981, 376)
        Me.grdListagem.TabIndex = 105
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdListagem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.SplitContainer1)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDadosPedido)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(998, 518)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Location = New System.Drawing.Point(8, 169)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpEtapa)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdEtapa)
        Me.SplitContainer1.Size = New System.Drawing.Size(982, 287)
        Me.SplitContainer1.SplitterDistance = 100
        Me.SplitContainer1.TabIndex = 100
        '
        'grpEtapa
        '
        Me.grpEtapa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEtapa.BackColor = System.Drawing.Color.Transparent
        Me.grpEtapa.Controls.Add(Me.lblObservacao)
        Me.grpEtapa.Controls.Add(Me.txtObservacao)
        Me.grpEtapa.Controls.Add(Me.dtpDataResposta)
        Me.grpEtapa.Controls.Add(Me.lblDataResposta)
        Me.grpEtapa.Controls.Add(Me.dtpDataTermino)
        Me.grpEtapa.Controls.Add(Me.lblDataTermino)
        Me.grpEtapa.Controls.Add(Me.dtpDataInicio)
        Me.grpEtapa.Controls.Add(Me.lblDataInicio)
        Me.grpEtapa.Controls.Add(Me.dtpDataPrevisao)
        Me.grpEtapa.Controls.Add(Me.lblDataPrevisao)
        Me.grpEtapa.Controls.Add(Me.lblEtapa)
        Me.grpEtapa.Controls.Add(Me.txtEtapa)
        Me.grpEtapa.Controls.Add(Me.btnInserirEtapa)
        Me.grpEtapa.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEtapa.Location = New System.Drawing.Point(3, -3)
        Me.grpEtapa.Name = "grpEtapa"
        Me.grpEtapa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEtapa.Size = New System.Drawing.Size(979, 99)
        Me.grpEtapa.TabIndex = 94
        Me.grpEtapa.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpEtapa.VisualStyleManager = Me.vsmMain
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.Location = New System.Drawing.Point(6, 54)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacao.TabIndex = 90
        Me.lblObservacao.Text = "Observação:"
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.Location = New System.Drawing.Point(9, 71)
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(961, 20)
        Me.txtObservacao.TabIndex = 89
        '
        'dtpDataResposta
        '
        Me.dtpDataResposta.Checked = False
        '
        '
        '
        Me.dtpDataResposta.DropDownCalendar.Name = ""
        Me.dtpDataResposta.DropDownCalendar.Visible = False
        Me.dtpDataResposta.Location = New System.Drawing.Point(521, 30)
        Me.dtpDataResposta.Name = "dtpDataResposta"
        Me.dtpDataResposta.Size = New System.Drawing.Size(113, 20)
        Me.dtpDataResposta.TabIndex = 88
        Me.dtpDataResposta.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataResposta
        '
        Me.lblDataResposta.AutoSize = True
        Me.lblDataResposta.Location = New System.Drawing.Point(518, 13)
        Me.lblDataResposta.Name = "lblDataResposta"
        Me.lblDataResposta.Size = New System.Drawing.Size(81, 14)
        Me.lblDataResposta.TabIndex = 87
        Me.lblDataResposta.Text = "Data Resposta:"
        '
        'dtpDataTermino
        '
        Me.dtpDataTermino.Checked = False
        '
        '
        '
        Me.dtpDataTermino.DropDownCalendar.Name = ""
        Me.dtpDataTermino.DropDownCalendar.Visible = False
        Me.dtpDataTermino.Location = New System.Drawing.Point(402, 30)
        Me.dtpDataTermino.Name = "dtpDataTermino"
        Me.dtpDataTermino.Size = New System.Drawing.Size(113, 20)
        Me.dtpDataTermino.TabIndex = 86
        Me.dtpDataTermino.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataTermino
        '
        Me.lblDataTermino.AutoSize = True
        Me.lblDataTermino.Location = New System.Drawing.Point(399, 13)
        Me.lblDataTermino.Name = "lblDataTermino"
        Me.lblDataTermino.Size = New System.Drawing.Size(73, 14)
        Me.lblDataTermino.TabIndex = 85
        Me.lblDataTermino.Text = "Data Término:"
        '
        'dtpDataInicio
        '
        Me.dtpDataInicio.Checked = False
        '
        '
        '
        Me.dtpDataInicio.DropDownCalendar.Name = ""
        Me.dtpDataInicio.DropDownCalendar.Visible = False
        Me.dtpDataInicio.Location = New System.Drawing.Point(283, 30)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.Size = New System.Drawing.Size(113, 20)
        Me.dtpDataInicio.TabIndex = 84
        Me.dtpDataInicio.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.Location = New System.Drawing.Point(280, 13)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(59, 14)
        Me.lblDataInicio.TabIndex = 83
        Me.lblDataInicio.Text = "Data Inicio:"
        '
        'dtpDataPrevisao
        '
        Me.dtpDataPrevisao.Checked = False
        '
        '
        '
        Me.dtpDataPrevisao.DropDownCalendar.Name = ""
        Me.dtpDataPrevisao.DropDownCalendar.Visible = False
        Me.dtpDataPrevisao.Location = New System.Drawing.Point(164, 30)
        Me.dtpDataPrevisao.Name = "dtpDataPrevisao"
        Me.dtpDataPrevisao.Size = New System.Drawing.Size(113, 20)
        Me.dtpDataPrevisao.TabIndex = 82
        Me.dtpDataPrevisao.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataPrevisao
        '
        Me.lblDataPrevisao.AutoSize = True
        Me.lblDataPrevisao.Location = New System.Drawing.Point(161, 13)
        Me.lblDataPrevisao.Name = "lblDataPrevisao"
        Me.lblDataPrevisao.Size = New System.Drawing.Size(77, 14)
        Me.lblDataPrevisao.TabIndex = 81
        Me.lblDataPrevisao.Text = "Data Previsão:"
        '
        'lblEtapa
        '
        Me.lblEtapa.AutoSize = True
        Me.lblEtapa.Location = New System.Drawing.Point(6, 12)
        Me.lblEtapa.Name = "lblEtapa"
        Me.lblEtapa.Size = New System.Drawing.Size(37, 14)
        Me.lblEtapa.TabIndex = 80
        Me.lblEtapa.Text = "Etapa:"
        '
        'txtEtapa
        '
        Me.txtEtapa.IncludeLiterals = False
        Me.txtEtapa.Location = New System.Drawing.Point(9, 31)
        Me.txtEtapa.MaxLength = 100
        Me.txtEtapa.Name = "txtEtapa"
        Me.txtEtapa.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtEtapa.Size = New System.Drawing.Size(149, 20)
        Me.txtEtapa.TabIndex = 2
        Me.txtEtapa.TabStop = False
        '
        'btnInserirEtapa
        '
        Me.btnInserirEtapa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirEtapa.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnInserirEtapa.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirEtapa.Location = New System.Drawing.Point(879, 30)
        Me.btnInserirEtapa.Name = "btnInserirEtapa"
        Me.btnInserirEtapa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirEtapa.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirEtapa.TabIndex = 6
        Me.btnInserirEtapa.Text = "Inserir"
        Me.btnInserirEtapa.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdEtapa
        '
        Me.grdEtapa.AlternatingColors = True
        Me.grdEtapa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdEtapa.CellToolTipText = "Duplo clique para editar o registro"
        grdEtapa_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdEtapa_DesignTimeLayout_Reference_0.Instance"), Object)
        grdEtapa_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdEtapa_DesignTimeLayout_Reference_0})
        grdEtapa_DesignTimeLayout.LayoutString = resources.GetString("grdEtapa_DesignTimeLayout.LayoutString")
        Me.grdEtapa.DesignTimeLayout = grdEtapa_DesignTimeLayout
        Me.grdEtapa.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdEtapa.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdEtapa.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdEtapa.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdEtapa.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdEtapa.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdEtapa.GroupByBoxVisible = False
        Me.grdEtapa.Location = New System.Drawing.Point(3, 3)
        Me.grdEtapa.Name = "grdEtapa"
        Me.grdEtapa.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdEtapa.RecordNavigator = True
        Me.grdEtapa.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdEtapa.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdEtapa.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdEtapa.Size = New System.Drawing.Size(975, 177)
        Me.grdEtapa.TabIndex = 0
        Me.grdEtapa.TabStop = False
        Me.grdEtapa.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdEtapa.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(6, 462)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(989, 50)
        Me.grpControl2.TabIndex = 99
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(695, 17)
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
        Me.btnVoltar.Location = New System.Drawing.Point(889, 17)
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
        Me.btnSalvar.Location = New System.Drawing.Point(792, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDadosPedido
        '
        Me.grpDadosPedido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosPedido.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosPedido.Controls.Add(Me.lblCodigo)
        Me.grpDadosPedido.Controls.Add(Me.txtCodigo)
        Me.grpDadosPedido.Controls.Add(Me.dtpDataConclusaoValidacao)
        Me.grpDadosPedido.Controls.Add(Me.lblConclusaoValidacao)
        Me.grpDadosPedido.Controls.Add(Me.dtpDataEntrega)
        Me.grpDadosPedido.Controls.Add(Me.lblDataEntrega)
        Me.grpDadosPedido.Controls.Add(Me.dtpDataLiberacaoProducao)
        Me.grpDadosPedido.Controls.Add(Me.lblLiberacaoProducao)
        Me.grpDadosPedido.Controls.Add(Me.chkInovacao)
        Me.grpDadosPedido.Controls.Add(Me.dtpDataLiberacaoCliente)
        Me.grpDadosPedido.Controls.Add(Me.lblDataLiberacaoCliente)
        Me.grpDadosPedido.Controls.Add(Me.cboProjetista)
        Me.grpDadosPedido.Controls.Add(Me.lblProjetista)
        Me.grpDadosPedido.Controls.Add(Me.cboInternoExterno)
        Me.grpDadosPedido.Controls.Add(Me.lblInternoExterno)
        Me.grpDadosPedido.Controls.Add(Me.lblCodigoCliente)
        Me.grpDadosPedido.Controls.Add(Me.txtCodigoCliente)
        Me.grpDadosPedido.Controls.Add(Me.cboFase)
        Me.grpDadosPedido.Controls.Add(Me.lblFase)
        Me.grpDadosPedido.Controls.Add(Me.txtCliente)
        Me.grpDadosPedido.Controls.Add(Me.lblCliente)
        Me.grpDadosPedido.Controls.Add(Me.txtPartNumber)
        Me.grpDadosPedido.Controls.Add(Me.cboTipoProjeto)
        Me.grpDadosPedido.Controls.Add(Me.lblTipoProjeto)
        Me.grpDadosPedido.Controls.Add(Me.txtPOLinha)
        Me.grpDadosPedido.Controls.Add(Me.lblPOLinha)
        Me.grpDadosPedido.Controls.Add(Me.lblOrdemProducao)
        Me.grpDadosPedido.Controls.Add(Me.txtPO)
        Me.grpDadosPedido.Controls.Add(Me.cboOrdemProducao)
        Me.grpDadosPedido.Controls.Add(Me.lblPO)
        Me.grpDadosPedido.Controls.Add(Me.lblRC)
        Me.grpDadosPedido.Controls.Add(Me.dtpDataProjeto)
        Me.grpDadosPedido.Controls.Add(Me.txtNs)
        Me.grpDadosPedido.Controls.Add(Me.lblDataProjeto)
        Me.grpDadosPedido.Controls.Add(Me.txtOM)
        Me.grpDadosPedido.Controls.Add(Me.lblNs)
        Me.grpDadosPedido.Controls.Add(Me.txtRC)
        Me.grpDadosPedido.Controls.Add(Me.txtAtivoFixo)
        Me.grpDadosPedido.Controls.Add(Me.lblOM)
        Me.grpDadosPedido.Controls.Add(Me.lblAtivoFixo)
        Me.grpDadosPedido.Controls.Add(Me.lblPartNumber)
        Me.grpDadosPedido.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosPedido.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosPedido.Name = "grpDadosPedido"
        Me.grpDadosPedido.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosPedido.Size = New System.Drawing.Size(982, 163)
        Me.grpDadosPedido.TabIndex = 0
        Me.grpDadosPedido.Text = "Dados de Projeto"
        Me.grpDadosPedido.VisualStyleManager = Me.vsmMain
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(6, 18)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(9, 35)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(109, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'dtpDataConclusaoValidacao
        '
        Me.dtpDataConclusaoValidacao.Checked = False
        '
        '
        '
        Me.dtpDataConclusaoValidacao.DropDownCalendar.Name = ""
        Me.dtpDataConclusaoValidacao.DropDownCalendar.Visible = False
        Me.dtpDataConclusaoValidacao.Location = New System.Drawing.Point(598, 125)
        Me.dtpDataConclusaoValidacao.Name = "dtpDataConclusaoValidacao"
        Me.dtpDataConclusaoValidacao.ShowCheckBox = True
        Me.dtpDataConclusaoValidacao.Size = New System.Drawing.Size(131, 20)
        Me.dtpDataConclusaoValidacao.TabIndex = 37
        Me.dtpDataConclusaoValidacao.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblConclusaoValidacao
        '
        Me.lblConclusaoValidacao.AutoSize = True
        Me.lblConclusaoValidacao.Location = New System.Drawing.Point(595, 108)
        Me.lblConclusaoValidacao.Name = "lblConclusaoValidacao"
        Me.lblConclusaoValidacao.Size = New System.Drawing.Size(111, 14)
        Me.lblConclusaoValidacao.TabIndex = 36
        Me.lblConclusaoValidacao.Text = "Conclusão Validação:"
        '
        'dtpDataEntrega
        '
        Me.dtpDataEntrega.Checked = False
        '
        '
        '
        Me.dtpDataEntrega.DropDownCalendar.Name = ""
        Me.dtpDataEntrega.DropDownCalendar.Visible = False
        Me.dtpDataEntrega.Location = New System.Drawing.Point(476, 125)
        Me.dtpDataEntrega.Name = "dtpDataEntrega"
        Me.dtpDataEntrega.ShowCheckBox = True
        Me.dtpDataEntrega.Size = New System.Drawing.Size(116, 20)
        Me.dtpDataEntrega.TabIndex = 35
        Me.dtpDataEntrega.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataEntrega
        '
        Me.lblDataEntrega.AutoSize = True
        Me.lblDataEntrega.Location = New System.Drawing.Point(473, 108)
        Me.lblDataEntrega.Name = "lblDataEntrega"
        Me.lblDataEntrega.Size = New System.Drawing.Size(72, 14)
        Me.lblDataEntrega.TabIndex = 34
        Me.lblDataEntrega.Text = "Data Entrega:"
        '
        'dtpDataLiberacaoProducao
        '
        Me.dtpDataLiberacaoProducao.Checked = False
        '
        '
        '
        Me.dtpDataLiberacaoProducao.DropDownCalendar.Name = ""
        Me.dtpDataLiberacaoProducao.DropDownCalendar.Visible = False
        Me.dtpDataLiberacaoProducao.Location = New System.Drawing.Point(354, 125)
        Me.dtpDataLiberacaoProducao.Name = "dtpDataLiberacaoProducao"
        Me.dtpDataLiberacaoProducao.ShowCheckBox = True
        Me.dtpDataLiberacaoProducao.Size = New System.Drawing.Size(116, 20)
        Me.dtpDataLiberacaoProducao.TabIndex = 33
        Me.dtpDataLiberacaoProducao.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblLiberacaoProducao
        '
        Me.lblLiberacaoProducao.AutoSize = True
        Me.lblLiberacaoProducao.Location = New System.Drawing.Point(351, 108)
        Me.lblLiberacaoProducao.Name = "lblLiberacaoProducao"
        Me.lblLiberacaoProducao.Size = New System.Drawing.Size(107, 14)
        Me.lblLiberacaoProducao.TabIndex = 32
        Me.lblLiberacaoProducao.Text = "Liberação Produção:"
        '
        'chkInovacao
        '
        Me.chkInovacao.Location = New System.Drawing.Point(755, 125)
        Me.chkInovacao.Name = "chkInovacao"
        Me.chkInovacao.Size = New System.Drawing.Size(61, 17)
        Me.chkInovacao.TabIndex = 38
        Me.chkInovacao.Text = "Inovação"
        '
        'dtpDataLiberacaoCliente
        '
        Me.dtpDataLiberacaoCliente.Checked = False
        '
        '
        '
        Me.dtpDataLiberacaoCliente.DropDownCalendar.Name = ""
        Me.dtpDataLiberacaoCliente.DropDownCalendar.Visible = False
        Me.dtpDataLiberacaoCliente.Location = New System.Drawing.Point(233, 125)
        Me.dtpDataLiberacaoCliente.Name = "dtpDataLiberacaoCliente"
        Me.dtpDataLiberacaoCliente.ShowCheckBox = True
        Me.dtpDataLiberacaoCliente.Size = New System.Drawing.Size(115, 20)
        Me.dtpDataLiberacaoCliente.TabIndex = 31
        Me.dtpDataLiberacaoCliente.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataLiberacaoCliente
        '
        Me.lblDataLiberacaoCliente.AutoSize = True
        Me.lblDataLiberacaoCliente.Location = New System.Drawing.Point(230, 108)
        Me.lblDataLiberacaoCliente.Name = "lblDataLiberacaoCliente"
        Me.lblDataLiberacaoCliente.Size = New System.Drawing.Size(118, 14)
        Me.lblDataLiberacaoCliente.TabIndex = 30
        Me.lblDataLiberacaoCliente.Text = "Data Liberação Cliente:"
        '
        'cboProjetista
        '
        Me.cboProjetista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProjetista.Location = New System.Drawing.Point(9, 125)
        Me.cboProjetista.Name = "cboProjetista"
        Me.cboProjetista.Size = New System.Drawing.Size(218, 20)
        Me.cboProjetista.TabIndex = 29
        '
        'lblProjetista
        '
        Me.lblProjetista.AutoSize = True
        Me.lblProjetista.Location = New System.Drawing.Point(6, 108)
        Me.lblProjetista.Name = "lblProjetista"
        Me.lblProjetista.Size = New System.Drawing.Size(54, 14)
        Me.lblProjetista.TabIndex = 28
        Me.lblProjetista.Text = "Projetista:"
        '
        'cboInternoExterno
        '
        Me.cboInternoExterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboInternoExterno.Location = New System.Drawing.Point(849, 78)
        Me.cboInternoExterno.Name = "cboInternoExterno"
        Me.cboInternoExterno.Size = New System.Drawing.Size(116, 20)
        Me.cboInternoExterno.TabIndex = 27
        '
        'lblInternoExterno
        '
        Me.lblInternoExterno.AutoSize = True
        Me.lblInternoExterno.Location = New System.Drawing.Point(846, 61)
        Me.lblInternoExterno.Name = "lblInternoExterno"
        Me.lblInternoExterno.Size = New System.Drawing.Size(83, 14)
        Me.lblInternoExterno.TabIndex = 26
        Me.lblInternoExterno.Text = "Interno/Externo:"
        '
        'lblCodigoCliente
        '
        Me.lblCodigoCliente.AutoSize = True
        Me.lblCodigoCliente.Location = New System.Drawing.Point(6, 62)
        Me.lblCodigoCliente.Name = "lblCodigoCliente"
        Me.lblCodigoCliente.Size = New System.Drawing.Size(78, 14)
        Me.lblCodigoCliente.TabIndex = 14
        Me.lblCodigoCliente.Text = "Código Cliente:"
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoCliente.Location = New System.Drawing.Point(9, 79)
        Me.txtCodigoCliente.MaxLength = 20
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(109, 20)
        Me.txtCodigoCliente.TabIndex = 15
        '
        'cboFase
        '
        Me.cboFase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFase.AutoSize = False
        Me.cboFase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFase.Location = New System.Drawing.Point(849, 125)
        Me.cboFase.Name = "cboFase"
        Me.cboFase.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFase.Size = New System.Drawing.Size(116, 20)
        Me.cboFase.TabIndex = 40
        '
        'lblFase
        '
        Me.lblFase.AutoSize = True
        Me.lblFase.Location = New System.Drawing.Point(846, 108)
        Me.lblFase.Name = "lblFase"
        Me.lblFase.Size = New System.Drawing.Size(34, 14)
        Me.lblFase.TabIndex = 39
        Me.lblFase.Text = "Fase:"
        '
        'txtCliente
        '
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(354, 35)
        Me.txtCliente.MaxLength = 20
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(116, 20)
        Me.txtCliente.TabIndex = 5
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(351, 18)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 4
        Me.lblCliente.Text = "Cliente:"
        '
        'txtPartNumber
        '
        Me.txtPartNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartNumber.Location = New System.Drawing.Point(124, 79)
        Me.txtPartNumber.MaxLength = 20
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.Size = New System.Drawing.Size(224, 20)
        Me.txtPartNumber.TabIndex = 17
        '
        'cboTipoProjeto
        '
        Me.cboTipoProjeto.AutoSize = False
        Me.cboTipoProjeto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoProjeto.Location = New System.Drawing.Point(476, 35)
        Me.cboTipoProjeto.Name = "cboTipoProjeto"
        Me.cboTipoProjeto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoProjeto.Size = New System.Drawing.Size(116, 20)
        Me.cboTipoProjeto.TabIndex = 7
        '
        'lblTipoProjeto
        '
        Me.lblTipoProjeto.AutoSize = True
        Me.lblTipoProjeto.Location = New System.Drawing.Point(473, 18)
        Me.lblTipoProjeto.Name = "lblTipoProjeto"
        Me.lblTipoProjeto.Size = New System.Drawing.Size(66, 14)
        Me.lblTipoProjeto.TabIndex = 6
        Me.lblTipoProjeto.Text = "Tipo Projeto:"
        '
        'txtPOLinha
        '
        Me.txtPOLinha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPOLinha.Location = New System.Drawing.Point(735, 35)
        Me.txtPOLinha.MaxLength = 20
        Me.txtPOLinha.Name = "txtPOLinha"
        Me.txtPOLinha.Size = New System.Drawing.Size(108, 20)
        Me.txtPOLinha.TabIndex = 11
        '
        'lblPOLinha
        '
        Me.lblPOLinha.AutoSize = True
        Me.lblPOLinha.Location = New System.Drawing.Point(732, 18)
        Me.lblPOLinha.Name = "lblPOLinha"
        Me.lblPOLinha.Size = New System.Drawing.Size(53, 14)
        Me.lblPOLinha.TabIndex = 10
        Me.lblPOLinha.Text = "PO Linha:"
        '
        'lblOrdemProducao
        '
        Me.lblOrdemProducao.AutoSize = True
        Me.lblOrdemProducao.Location = New System.Drawing.Point(121, 18)
        Me.lblOrdemProducao.Name = "lblOrdemProducao"
        Me.lblOrdemProducao.Size = New System.Drawing.Size(106, 14)
        Me.lblOrdemProducao.TabIndex = 2
        Me.lblOrdemProducao.Text = "Ordem de Produção:"
        '
        'txtPO
        '
        Me.txtPO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPO.Location = New System.Drawing.Point(598, 35)
        Me.txtPO.MaxLength = 20
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(131, 20)
        Me.txtPO.TabIndex = 9
        '
        'cboOrdemProducao
        '
        Me.cboOrdemProducao.AutoSize = False
        Me.cboOrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOrdemProducao.Location = New System.Drawing.Point(124, 35)
        Me.cboOrdemProducao.Name = "cboOrdemProducao"
        Me.cboOrdemProducao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboOrdemProducao.Size = New System.Drawing.Size(224, 20)
        Me.cboOrdemProducao.TabIndex = 3
        '
        'lblPO
        '
        Me.lblPO.AutoSize = True
        Me.lblPO.Location = New System.Drawing.Point(595, 18)
        Me.lblPO.Name = "lblPO"
        Me.lblPO.Size = New System.Drawing.Size(24, 14)
        Me.lblPO.TabIndex = 8
        Me.lblPO.Text = "PO:"
        '
        'lblRC
        '
        Me.lblRC.AutoSize = True
        Me.lblRC.Location = New System.Drawing.Point(846, 18)
        Me.lblRC.Name = "lblRC"
        Me.lblRC.Size = New System.Drawing.Size(24, 14)
        Me.lblRC.TabIndex = 12
        Me.lblRC.Text = "RC:"
        '
        'dtpDataProjeto
        '
        Me.dtpDataProjeto.Checked = False
        '
        '
        '
        Me.dtpDataProjeto.DropDownCalendar.Name = ""
        Me.dtpDataProjeto.DropDownCalendar.Visible = False
        Me.dtpDataProjeto.Location = New System.Drawing.Point(735, 79)
        Me.dtpDataProjeto.Name = "dtpDataProjeto"
        Me.dtpDataProjeto.ShowCheckBox = True
        Me.dtpDataProjeto.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataProjeto.TabIndex = 25
        Me.dtpDataProjeto.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'txtNs
        '
        Me.txtNs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNs.Location = New System.Drawing.Point(354, 79)
        Me.txtNs.MaxLength = 20
        Me.txtNs.Name = "txtNs"
        Me.txtNs.Size = New System.Drawing.Size(116, 20)
        Me.txtNs.TabIndex = 19
        '
        'lblDataProjeto
        '
        Me.lblDataProjeto.AutoSize = True
        Me.lblDataProjeto.Location = New System.Drawing.Point(732, 61)
        Me.lblDataProjeto.Name = "lblDataProjeto"
        Me.lblDataProjeto.Size = New System.Drawing.Size(68, 14)
        Me.lblDataProjeto.TabIndex = 24
        Me.lblDataProjeto.Text = "Data Projeto:"
        '
        'txtOM
        '
        Me.txtOM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOM.Location = New System.Drawing.Point(476, 79)
        Me.txtOM.MaxLength = 20
        Me.txtOM.Name = "txtOM"
        Me.txtOM.Size = New System.Drawing.Size(116, 20)
        Me.txtOM.TabIndex = 21
        '
        'lblNs
        '
        Me.lblNs.AutoSize = True
        Me.lblNs.Location = New System.Drawing.Point(351, 62)
        Me.lblNs.Name = "lblNs"
        Me.lblNs.Size = New System.Drawing.Size(24, 14)
        Me.lblNs.TabIndex = 18
        Me.lblNs.Text = "NS:"
        '
        'txtRC
        '
        Me.txtRC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRC.Location = New System.Drawing.Point(849, 35)
        Me.txtRC.MaxLength = 20
        Me.txtRC.Name = "txtRC"
        Me.txtRC.Size = New System.Drawing.Size(116, 20)
        Me.txtRC.TabIndex = 13
        '
        'txtAtivoFixo
        '
        Me.txtAtivoFixo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAtivoFixo.Location = New System.Drawing.Point(598, 79)
        Me.txtAtivoFixo.MaxLength = 20
        Me.txtAtivoFixo.Name = "txtAtivoFixo"
        Me.txtAtivoFixo.Size = New System.Drawing.Size(131, 20)
        Me.txtAtivoFixo.TabIndex = 23
        '
        'lblOM
        '
        Me.lblOM.AutoSize = True
        Me.lblOM.Location = New System.Drawing.Point(473, 62)
        Me.lblOM.Name = "lblOM"
        Me.lblOM.Size = New System.Drawing.Size(26, 14)
        Me.lblOM.TabIndex = 20
        Me.lblOM.Text = "OM:"
        '
        'lblAtivoFixo
        '
        Me.lblAtivoFixo.AutoSize = True
        Me.lblAtivoFixo.Location = New System.Drawing.Point(595, 62)
        Me.lblAtivoFixo.Name = "lblAtivoFixo"
        Me.lblAtivoFixo.Size = New System.Drawing.Size(58, 14)
        Me.lblAtivoFixo.TabIndex = 22
        Me.lblAtivoFixo.Text = "Ativo Fixo:"
        '
        'lblPartNumber
        '
        Me.lblPartNumber.AutoSize = True
        Me.lblPartNumber.Location = New System.Drawing.Point(121, 62)
        Me.lblPartNumber.Name = "lblPartNumber"
        Me.lblPartNumber.Size = New System.Drawing.Size(69, 14)
        Me.lblPartNumber.TabIndex = 16
        Me.lblPartNumber.Text = "Part Number:"
        '
        'usrPrjProcesso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrPrjProcesso"
        Me.Size = New System.Drawing.Size(1000, 541)
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
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grpEtapa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEtapa.ResumeLayout(False)
        Me.grpEtapa.PerformLayout()
        CType(Me.grdEtapa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpDadosPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosPedido.ResumeLayout(False)
        Me.grpDadosPedido.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblPartNumberFiltro As System.Windows.Forms.Label
    Friend WithEvents txtPartNumberFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdEtapa As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboFaseFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblFaseFiltro As System.Windows.Forms.Label
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDadosPedido As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataProjeto As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataProjeto As System.Windows.Forms.Label
    Friend WithEvents lblPartNumber As System.Windows.Forms.Label
    Friend WithEvents cboOrdemProducao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtPOLinha As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPOLinha As System.Windows.Forms.Label
    Friend WithEvents txtPO As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPO As System.Windows.Forms.Label
    Friend WithEvents txtNs As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtOM As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNs As System.Windows.Forms.Label
    Friend WithEvents txtAtivoFixo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOM As System.Windows.Forms.Label
    Friend WithEvents lblAtivoFixo As System.Windows.Forms.Label
    Friend WithEvents txtRC As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRC As System.Windows.Forms.Label
    Friend WithEvents btnExcelDados As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridDados As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridDados As System.Windows.Forms.Button
    Friend WithEvents cboTipoProjeto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoProjeto As System.Windows.Forms.Label
    Friend WithEvents txtPartNumber As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboFase As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFase As System.Windows.Forms.Label
    Friend WithEvents txtCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblCodigoCliente As System.Windows.Forms.Label
    Friend WithEvents txtCodigoCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataLiberacaoCliente As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataLiberacaoCliente As System.Windows.Forms.Label
    Friend WithEvents cboProjetista As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblProjetista As System.Windows.Forms.Label
    Friend WithEvents cboInternoExterno As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblInternoExterno As System.Windows.Forms.Label
    Friend WithEvents dtpDataConclusaoValidacao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblConclusaoValidacao As System.Windows.Forms.Label
    Friend WithEvents dtpDataEntrega As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEntrega As System.Windows.Forms.Label
    Friend WithEvents dtpDataLiberacaoProducao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblLiberacaoProducao As System.Windows.Forms.Label
    Friend WithEvents chkInovacao As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnAlterarLote As Janus.Windows.EditControls.UIButton
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents grpEtapa As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblEtapa As Label
    Friend WithEvents txtEtapa As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnInserirEtapa As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataPrevisao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataPrevisao As Label
    Friend WithEvents dtpDataResposta As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataResposta As Label
    Friend WithEvents dtpDataTermino As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataTermino As Label
    Friend WithEvents dtpDataInicio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataInicio As Label
    Friend WithEvents lblObservacao As Label
    Friend WithEvents txtObservacao As TextBox
End Class
