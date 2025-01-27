<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadCadernoServico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadCadernoServico))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdComposicao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdComposicao_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridComposicao = New System.Windows.Forms.Button()
        Me.btnAgruparGridComposicao = New System.Windows.Forms.Button()
        Me.btnConfigurarGridComposicao = New System.Windows.Forms.Button()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnColarComposicao = New Janus.Windows.EditControls.UIButton()
        Me.btnCopiarComposicao = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.spcMain = New System.Windows.Forms.SplitContainer()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grdComposicao = New Janus.Windows.GridEX.GridEX()
        Me.grpComposicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCoeficiente = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCoeficiente = New System.Windows.Forms.Label()
        Me.txtPercentualHI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPercentualHI = New System.Windows.Forms.Label()
        Me.btnProcurarItem = New System.Windows.Forms.Button()
        Me.cboTipo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.btnExcluirComposicao = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirComposicao = New Janus.Windows.EditControls.UIButton()
        Me.txtPercentualHP = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPercentualHP = New System.Windows.Forms.Label()
        Me.cboItemComposicao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblItemComposicao = New System.Windows.Forms.Label()
        Me.btnCadastrarUnidadeMedidaComposicao = New System.Windows.Forms.Button()
        Me.cboUnidadeMedidaComposicao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUnidadeMedidaComposicao = New System.Windows.Forms.Label()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtPercentualHIServico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPercentualHIServico = New System.Windows.Forms.Label()
        Me.txtPercentualHPServico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPercentualHPServico = New System.Windows.Forms.Label()
        Me.txtCoeficienteServico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCoeficienteServico = New System.Windows.Forms.Label()
        Me.btnCadastrarUnidadeMedida = New System.Windows.Forms.Button()
        Me.cboUnidadeMedida = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUnidadeMedida = New System.Windows.Forms.Label()
        Me.btnCadastrarEspecie = New System.Windows.Forms.Button()
        Me.lblEspecie = New System.Windows.Forms.Label()
        Me.cboEspecie = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarGrupoItem = New System.Windows.Forms.Button()
        Me.cboGrupoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblGrupoItem = New System.Windows.Forms.Label()
        Me.txtCodigoServico = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoServico = New System.Windows.Forms.Label()
        Me.lblDescricaoServico = New System.Windows.Forms.Label()
        Me.txtDescricaoServico = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GridEX2 = New Janus.Windows.GridEX.GridEX()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.UiButton3 = New Janus.Windows.EditControls.UIButton()
        Me.UiButton4 = New Janus.Windows.EditControls.UIButton()
        Me.NumericEditBox3 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.UiComboBox3 = New Janus.Windows.EditControls.UIComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericEditBox4 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UiComboBox4 = New Janus.Windows.EditControls.UIComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MaskedEditBox1 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UiComboBox5 = New Janus.Windows.EditControls.UIComboBox()
        Me.UiButton5 = New Janus.Windows.EditControls.UIButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MaskedEditBox2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.UiButton6 = New Janus.Windows.EditControls.UIButton()
        Me.UiButton7 = New Janus.Windows.EditControls.UIButton()
        Me.MaskedEditBox3 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GridEX3 = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcMain.Panel1.SuspendLayout()
        Me.spcMain.Panel2.SuspendLayout()
        Me.spcMain.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdComposicao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpComposicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpComposicao.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnExcelGridComposicao)
        Me.pagLista.Controls.Add(Me.btnAgruparGridComposicao)
        Me.pagLista.Controls.Add(Me.btnConfigurarGridComposicao)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.spcMain)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Caderno de Serviço"
        '
        'btnExcelGridComposicao
        '
        Me.btnExcelGridComposicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridComposicao.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridComposicao.FlatAppearance.BorderSize = 0
        Me.btnExcelGridComposicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridComposicao.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridComposicao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridComposicao.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGridComposicao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridComposicao.Name = "btnExcelGridComposicao"
        Me.btnExcelGridComposicao.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridComposicao.TabIndex = 3
        Me.btnExcelGridComposicao.TabStop = False
        Me.btnExcelGridComposicao.UseVisualStyleBackColor = False
        '
        'btnAgruparGridComposicao
        '
        Me.btnAgruparGridComposicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridComposicao.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridComposicao.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridComposicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridComposicao.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridComposicao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridComposicao.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGridComposicao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridComposicao.Name = "btnAgruparGridComposicao"
        Me.btnAgruparGridComposicao.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridComposicao.TabIndex = 2
        Me.btnAgruparGridComposicao.TabStop = False
        Me.btnAgruparGridComposicao.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridComposicao
        '
        Me.btnConfigurarGridComposicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridComposicao.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridComposicao.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridComposicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridComposicao.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridComposicao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridComposicao.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGridComposicao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridComposicao.Name = "btnConfigurarGridComposicao"
        Me.btnConfigurarGridComposicao.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridComposicao.TabIndex = 1
        Me.btnConfigurarGridComposicao.TabStop = False
        Me.btnConfigurarGridComposicao.UseVisualStyleBackColor = False
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnColarComposicao)
        Me.grpControl.Controls.Add(Me.btnCopiarComposicao)
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 4
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnColarComposicao
        '
        Me.btnColarComposicao.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnColarComposicao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnColarComposicao.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnColarComposicao.Location = New System.Drawing.Point(106, 17)
        Me.btnColarComposicao.Name = "btnColarComposicao"
        Me.btnColarComposicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnColarComposicao.Size = New System.Drawing.Size(91, 23)
        Me.btnColarComposicao.TabIndex = 4
        Me.btnColarComposicao.Text = "Colar"
        Me.btnColarComposicao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCopiarComposicao
        '
        Me.btnCopiarComposicao.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnCopiarComposicao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCopiarComposicao.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnCopiarComposicao.Location = New System.Drawing.Point(9, 17)
        Me.btnCopiarComposicao.Name = "btnCopiarComposicao"
        Me.btnCopiarComposicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCopiarComposicao.Size = New System.Drawing.Size(91, 23)
        Me.btnCopiarComposicao.TabIndex = 3
        Me.btnCopiarComposicao.Text = "Copiar"
        Me.btnCopiarComposicao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
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
        Me.btnExcluir.TabIndex = 1
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'spcMain
        '
        Me.spcMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.spcMain.BackColor = System.Drawing.Color.Transparent
        Me.spcMain.Location = New System.Drawing.Point(8, 8)
        Me.spcMain.Name = "spcMain"
        Me.spcMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcMain.Panel1
        '
        Me.spcMain.Panel1.Controls.Add(Me.btnConfigurarGrid)
        Me.spcMain.Panel1.Controls.Add(Me.btnExcelGrid)
        Me.spcMain.Panel1.Controls.Add(Me.grdListagem)
        '
        'spcMain.Panel2
        '
        Me.spcMain.Panel2.Controls.Add(Me.grdComposicao)
        Me.spcMain.Panel2.Controls.Add(Me.grpComposicao)
        Me.spcMain.Size = New System.Drawing.Size(897, 472)
        Me.spcMain.SplitterDistance = 260
        Me.spcMain.TabIndex = 0
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(4, 243)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 1
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(28, 243)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 2
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        Me.grdListagem.ColumnAutoResize = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 1
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.grdListagem.Location = New System.Drawing.Point(0, 3)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 257)
        Me.grdListagem.TabIndex = 0
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
        'grdComposicao
        '
        Me.grdComposicao.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdComposicao.AlternatingColors = True
        Me.grdComposicao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdComposicao.ColumnAutoResize = True
        grdComposicao_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdComposicao_DesignTimeLayout_Reference_0.Instance"), Object)
        grdComposicao_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdComposicao_DesignTimeLayout_Reference_0})
        grdComposicao_DesignTimeLayout.LayoutString = resources.GetString("grdComposicao_DesignTimeLayout.LayoutString")
        Me.grdComposicao.DesignTimeLayout = grdComposicao_DesignTimeLayout
        Me.grdComposicao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdComposicao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdComposicao.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdComposicao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdComposicao.FrozenColumns = 3
        Me.grdComposicao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdComposicao.GroupByBoxVisible = False
        Me.grdComposicao.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdComposicao.Location = New System.Drawing.Point(0, 72)
        Me.grdComposicao.Name = "grdComposicao"
        Me.grdComposicao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdComposicao.RecordNavigator = True
        Me.grdComposicao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdComposicao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdComposicao.Size = New System.Drawing.Size(897, 136)
        Me.grdComposicao.TabIndex = 1
        Me.grdComposicao.TabStop = False
        Me.grdComposicao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdComposicao.VisualStyleManager = Me.vsmMain
        '
        'grpComposicao
        '
        Me.grpComposicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpComposicao.BackColor = System.Drawing.Color.Transparent
        Me.grpComposicao.Controls.Add(Me.txtCoeficiente)
        Me.grpComposicao.Controls.Add(Me.lblCoeficiente)
        Me.grpComposicao.Controls.Add(Me.txtPercentualHI)
        Me.grpComposicao.Controls.Add(Me.lblPercentualHI)
        Me.grpComposicao.Controls.Add(Me.btnProcurarItem)
        Me.grpComposicao.Controls.Add(Me.cboTipo)
        Me.grpComposicao.Controls.Add(Me.lblTipo)
        Me.grpComposicao.Controls.Add(Me.btnExcluirComposicao)
        Me.grpComposicao.Controls.Add(Me.btnInserirComposicao)
        Me.grpComposicao.Controls.Add(Me.txtPercentualHP)
        Me.grpComposicao.Controls.Add(Me.lblPercentualHP)
        Me.grpComposicao.Controls.Add(Me.cboItemComposicao)
        Me.grpComposicao.Controls.Add(Me.lblItemComposicao)
        Me.grpComposicao.Controls.Add(Me.btnCadastrarUnidadeMedidaComposicao)
        Me.grpComposicao.Controls.Add(Me.cboUnidadeMedidaComposicao)
        Me.grpComposicao.Controls.Add(Me.lblUnidadeMedidaComposicao)
        Me.grpComposicao.Location = New System.Drawing.Point(0, -1)
        Me.grpComposicao.Name = "grpComposicao"
        Me.grpComposicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpComposicao.Size = New System.Drawing.Size(897, 64)
        Me.grpComposicao.TabIndex = 0
        Me.grpComposicao.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpComposicao.VisualStyleManager = Me.vsmMain
        '
        'txtCoeficiente
        '
        Me.txtCoeficiente.DecimalDigits = 4
        Me.txtCoeficiente.Location = New System.Drawing.Point(314, 34)
        Me.txtCoeficiente.Name = "txtCoeficiente"
        Me.txtCoeficiente.Size = New System.Drawing.Size(101, 20)
        Me.txtCoeficiente.TabIndex = 6
        Me.txtCoeficiente.Text = "0,0000"
        Me.txtCoeficiente.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblCoeficiente
        '
        Me.lblCoeficiente.AutoSize = True
        Me.lblCoeficiente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCoeficiente.Location = New System.Drawing.Point(311, 17)
        Me.lblCoeficiente.Name = "lblCoeficiente"
        Me.lblCoeficiente.Size = New System.Drawing.Size(64, 14)
        Me.lblCoeficiente.TabIndex = 5
        Me.lblCoeficiente.Text = "Coeficiente:"
        '
        'txtPercentualHI
        '
        Me.txtPercentualHI.DecimalDigits = 2
        Me.txtPercentualHI.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtPercentualHI.Location = New System.Drawing.Point(615, 34)
        Me.txtPercentualHI.Name = "txtPercentualHI"
        Me.txtPercentualHI.Size = New System.Drawing.Size(70, 20)
        Me.txtPercentualHI.TabIndex = 13
        Me.txtPercentualHI.Text = "0,00%"
        Me.txtPercentualHI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPercentualHI
        '
        Me.lblPercentualHI.AutoSize = True
        Me.lblPercentualHI.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPercentualHI.Location = New System.Drawing.Point(612, 17)
        Me.lblPercentualHI.Name = "lblPercentualHI"
        Me.lblPercentualHI.Size = New System.Drawing.Size(38, 14)
        Me.lblPercentualHI.TabIndex = 12
        Me.lblPercentualHI.Text = "% H.I.:"
        '
        'btnProcurarItem
        '
        Me.btnProcurarItem.FlatAppearance.BorderSize = 0
        Me.btnProcurarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItem.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItem.Location = New System.Drawing.Point(291, 16)
        Me.btnProcurarItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItem.Name = "btnProcurarItem"
        Me.btnProcurarItem.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItem.TabIndex = 4
        Me.btnProcurarItem.TabStop = False
        Me.btnProcurarItem.UseVisualStyleBackColor = True
        '
        'cboTipo
        '
        Me.cboTipo.AutoSize = False
        Me.cboTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipo.Location = New System.Drawing.Point(9, 34)
        Me.cboTipo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipo.Size = New System.Drawing.Size(114, 20)
        Me.cboTipo.TabIndex = 1
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(6, 17)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 14)
        Me.lblTipo.TabIndex = 0
        Me.lblTipo.Text = "Tipo:"
        '
        'btnExcluirComposicao
        '
        Me.btnExcluirComposicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirComposicao.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirComposicao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirComposicao.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirComposicao.Location = New System.Drawing.Point(797, 31)
        Me.btnExcluirComposicao.Name = "btnExcluirComposicao"
        Me.btnExcluirComposicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirComposicao.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirComposicao.TabIndex = 15
        Me.btnExcluirComposicao.Text = "Excluir"
        Me.btnExcluirComposicao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirComposicao
        '
        Me.btnInserirComposicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirComposicao.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirComposicao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirComposicao.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirComposicao.Location = New System.Drawing.Point(700, 31)
        Me.btnInserirComposicao.Name = "btnInserirComposicao"
        Me.btnInserirComposicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirComposicao.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirComposicao.TabIndex = 14
        Me.btnInserirComposicao.Text = "Inserir"
        Me.btnInserirComposicao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtPercentualHP
        '
        Me.txtPercentualHP.DecimalDigits = 2
        Me.txtPercentualHP.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtPercentualHP.Location = New System.Drawing.Point(539, 34)
        Me.txtPercentualHP.Name = "txtPercentualHP"
        Me.txtPercentualHP.Size = New System.Drawing.Size(70, 20)
        Me.txtPercentualHP.TabIndex = 11
        Me.txtPercentualHP.Text = "0,00%"
        Me.txtPercentualHP.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPercentualHP
        '
        Me.lblPercentualHP.AutoSize = True
        Me.lblPercentualHP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPercentualHP.Location = New System.Drawing.Point(536, 17)
        Me.lblPercentualHP.Name = "lblPercentualHP"
        Me.lblPercentualHP.Size = New System.Drawing.Size(41, 14)
        Me.lblPercentualHP.TabIndex = 10
        Me.lblPercentualHP.Text = "% H.P.:"
        '
        'cboItemComposicao
        '
        Me.cboItemComposicao.AutoSize = False
        Me.cboItemComposicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboItemComposicao.Location = New System.Drawing.Point(129, 34)
        Me.cboItemComposicao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboItemComposicao.Name = "cboItemComposicao"
        Me.cboItemComposicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboItemComposicao.Size = New System.Drawing.Size(179, 20)
        Me.cboItemComposicao.TabIndex = 3
        '
        'lblItemComposicao
        '
        Me.lblItemComposicao.AutoSize = True
        Me.lblItemComposicao.Location = New System.Drawing.Point(126, 17)
        Me.lblItemComposicao.Name = "lblItemComposicao"
        Me.lblItemComposicao.Size = New System.Drawing.Size(44, 14)
        Me.lblItemComposicao.TabIndex = 2
        Me.lblItemComposicao.Text = "Serviço"
        '
        'btnCadastrarUnidadeMedidaComposicao
        '
        Me.btnCadastrarUnidadeMedidaComposicao.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUnidadeMedidaComposicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUnidadeMedidaComposicao.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarUnidadeMedidaComposicao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUnidadeMedidaComposicao.Location = New System.Drawing.Point(421, 18)
        Me.btnCadastrarUnidadeMedidaComposicao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUnidadeMedidaComposicao.Name = "btnCadastrarUnidadeMedidaComposicao"
        Me.btnCadastrarUnidadeMedidaComposicao.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarUnidadeMedidaComposicao.TabIndex = 7
        Me.btnCadastrarUnidadeMedidaComposicao.TabStop = False
        Me.btnCadastrarUnidadeMedidaComposicao.UseVisualStyleBackColor = True
        '
        'cboUnidadeMedidaComposicao
        '
        Me.cboUnidadeMedidaComposicao.AutoSize = False
        Me.cboUnidadeMedidaComposicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedidaComposicao.Location = New System.Drawing.Point(421, 34)
        Me.cboUnidadeMedidaComposicao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboUnidadeMedidaComposicao.Name = "cboUnidadeMedidaComposicao"
        Me.cboUnidadeMedidaComposicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedidaComposicao.Size = New System.Drawing.Size(112, 20)
        Me.cboUnidadeMedidaComposicao.TabIndex = 9
        '
        'lblUnidadeMedidaComposicao
        '
        Me.lblUnidadeMedidaComposicao.AutoSize = True
        Me.lblUnidadeMedidaComposicao.Location = New System.Drawing.Point(437, 17)
        Me.lblUnidadeMedidaComposicao.Name = "lblUnidadeMedidaComposicao"
        Me.lblUnidadeMedidaComposicao.Size = New System.Drawing.Size(86, 14)
        Me.lblUnidadeMedidaComposicao.TabIndex = 8
        Me.lblUnidadeMedidaComposicao.Text = "Unidade Medida:"
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
        Me.pagDados.Text = "Caderno de Serviço"
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
        Me.grpDados.Controls.Add(Me.txtPercentualHIServico)
        Me.grpDados.Controls.Add(Me.lblPercentualHIServico)
        Me.grpDados.Controls.Add(Me.txtPercentualHPServico)
        Me.grpDados.Controls.Add(Me.lblPercentualHPServico)
        Me.grpDados.Controls.Add(Me.txtCoeficienteServico)
        Me.grpDados.Controls.Add(Me.lblCoeficienteServico)
        Me.grpDados.Controls.Add(Me.btnCadastrarUnidadeMedida)
        Me.grpDados.Controls.Add(Me.cboUnidadeMedida)
        Me.grpDados.Controls.Add(Me.lblUnidadeMedida)
        Me.grpDados.Controls.Add(Me.btnCadastrarEspecie)
        Me.grpDados.Controls.Add(Me.lblEspecie)
        Me.grpDados.Controls.Add(Me.cboEspecie)
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.btnCadastrarGrupoItem)
        Me.grpDados.Controls.Add(Me.cboGrupoItem)
        Me.grpDados.Controls.Add(Me.lblGrupoItem)
        Me.grpDados.Controls.Add(Me.txtCodigoServico)
        Me.grpDados.Controls.Add(Me.lblCodigoServico)
        Me.grpDados.Controls.Add(Me.lblDescricaoServico)
        Me.grpDados.Controls.Add(Me.txtDescricaoServico)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 250)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtPercentualHIServico
        '
        Me.txtPercentualHIServico.DecimalDigits = 2
        Me.txtPercentualHIServico.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtPercentualHIServico.Location = New System.Drawing.Point(425, 74)
        Me.txtPercentualHIServico.Name = "txtPercentualHIServico"
        Me.txtPercentualHIServico.Size = New System.Drawing.Size(70, 20)
        Me.txtPercentualHIServico.TabIndex = 18
        Me.txtPercentualHIServico.Text = "0,00%"
        Me.txtPercentualHIServico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPercentualHIServico
        '
        Me.lblPercentualHIServico.AutoSize = True
        Me.lblPercentualHIServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPercentualHIServico.Location = New System.Drawing.Point(422, 57)
        Me.lblPercentualHIServico.Name = "lblPercentualHIServico"
        Me.lblPercentualHIServico.Size = New System.Drawing.Size(38, 14)
        Me.lblPercentualHIServico.TabIndex = 17
        Me.lblPercentualHIServico.Text = "% H.I.:"
        '
        'txtPercentualHPServico
        '
        Me.txtPercentualHPServico.DecimalDigits = 2
        Me.txtPercentualHPServico.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtPercentualHPServico.Location = New System.Drawing.Point(349, 74)
        Me.txtPercentualHPServico.Name = "txtPercentualHPServico"
        Me.txtPercentualHPServico.Size = New System.Drawing.Size(70, 20)
        Me.txtPercentualHPServico.TabIndex = 16
        Me.txtPercentualHPServico.Text = "0,00%"
        Me.txtPercentualHPServico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPercentualHPServico
        '
        Me.lblPercentualHPServico.AutoSize = True
        Me.lblPercentualHPServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPercentualHPServico.Location = New System.Drawing.Point(346, 57)
        Me.lblPercentualHPServico.Name = "lblPercentualHPServico"
        Me.lblPercentualHPServico.Size = New System.Drawing.Size(41, 14)
        Me.lblPercentualHPServico.TabIndex = 15
        Me.lblPercentualHPServico.Text = "% H.P.:"
        '
        'txtCoeficienteServico
        '
        Me.txtCoeficienteServico.DecimalDigits = 4
        Me.txtCoeficienteServico.Location = New System.Drawing.Point(135, 74)
        Me.txtCoeficienteServico.Name = "txtCoeficienteServico"
        Me.txtCoeficienteServico.Size = New System.Drawing.Size(101, 20)
        Me.txtCoeficienteServico.TabIndex = 11
        Me.txtCoeficienteServico.Text = "0,0000"
        Me.txtCoeficienteServico.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblCoeficienteServico
        '
        Me.lblCoeficienteServico.AutoSize = True
        Me.lblCoeficienteServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCoeficienteServico.Location = New System.Drawing.Point(132, 57)
        Me.lblCoeficienteServico.Name = "lblCoeficienteServico"
        Me.lblCoeficienteServico.Size = New System.Drawing.Size(64, 14)
        Me.lblCoeficienteServico.TabIndex = 10
        Me.lblCoeficienteServico.Text = "Coeficiente:"
        '
        'btnCadastrarUnidadeMedida
        '
        Me.btnCadastrarUnidadeMedida.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUnidadeMedida.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarUnidadeMedida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUnidadeMedida.Location = New System.Drawing.Point(241, 58)
        Me.btnCadastrarUnidadeMedida.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUnidadeMedida.Name = "btnCadastrarUnidadeMedida"
        Me.btnCadastrarUnidadeMedida.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarUnidadeMedida.TabIndex = 12
        Me.btnCadastrarUnidadeMedida.TabStop = False
        Me.btnCadastrarUnidadeMedida.UseVisualStyleBackColor = True
        '
        'cboUnidadeMedida
        '
        Me.cboUnidadeMedida.AutoSize = False
        Me.cboUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedida.Location = New System.Drawing.Point(242, 74)
        Me.cboUnidadeMedida.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboUnidadeMedida.Name = "cboUnidadeMedida"
        Me.cboUnidadeMedida.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedida.Size = New System.Drawing.Size(101, 20)
        Me.cboUnidadeMedida.TabIndex = 14
        '
        'lblUnidadeMedida
        '
        Me.lblUnidadeMedida.AutoSize = True
        Me.lblUnidadeMedida.Location = New System.Drawing.Point(257, 57)
        Me.lblUnidadeMedida.Name = "lblUnidadeMedida"
        Me.lblUnidadeMedida.Size = New System.Drawing.Size(69, 14)
        Me.lblUnidadeMedida.TabIndex = 13
        Me.lblUnidadeMedida.Text = "Und. Medida:"
        '
        'btnCadastrarEspecie
        '
        Me.btnCadastrarEspecie.FlatAppearance.BorderSize = 0
        Me.btnCadastrarEspecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarEspecie.Image = CType(resources.GetObject("btnCadastrarEspecie.Image"), System.Drawing.Image)
        Me.btnCadastrarEspecie.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarEspecie.Location = New System.Drawing.Point(501, 18)
        Me.btnCadastrarEspecie.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarEspecie.Name = "btnCadastrarEspecie"
        Me.btnCadastrarEspecie.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarEspecie.TabIndex = 3
        Me.btnCadastrarEspecie.TabStop = False
        Me.btnCadastrarEspecie.UseVisualStyleBackColor = True
        '
        'lblEspecie
        '
        Me.lblEspecie.AutoSize = True
        Me.lblEspecie.Location = New System.Drawing.Point(517, 17)
        Me.lblEspecie.Name = "lblEspecie"
        Me.lblEspecie.Size = New System.Drawing.Size(48, 14)
        Me.lblEspecie.TabIndex = 4
        Me.lblEspecie.Text = "Espécie:"
        '
        'cboEspecie
        '
        Me.cboEspecie.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboEspecie.AutoSize = False
        Me.cboEspecie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEspecie.Location = New System.Drawing.Point(501, 34)
        Me.cboEspecie.Name = "cboEspecie"
        Me.cboEspecie.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboEspecie.Size = New System.Drawing.Size(291, 20)
        Me.cboEspecie.TabIndex = 5
        '
        'lblAtivo
        '
        Me.lblAtivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.Location = New System.Drawing.Point(795, 17)
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
        Me.cboAtivo.Location = New System.Drawing.Point(798, 34)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivo.Size = New System.Drawing.Size(90, 20)
        Me.cboAtivo.TabIndex = 7
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
        Me.cboGrupoItem.AutoSize = False
        Me.cboGrupoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoItem.Location = New System.Drawing.Point(9, 34)
        Me.cboGrupoItem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboGrupoItem.Name = "cboGrupoItem"
        Me.cboGrupoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItem.Size = New System.Drawing.Size(486, 20)
        Me.cboGrupoItem.TabIndex = 2
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
        Me.txtCodigoServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoServico.Location = New System.Drawing.Point(9, 74)
        Me.txtCodigoServico.MaxLength = 60
        Me.txtCodigoServico.Name = "txtCodigoServico"
        Me.txtCodigoServico.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigoServico.TabIndex = 9
        '
        'lblCodigoServico
        '
        Me.lblCodigoServico.AutoSize = True
        Me.lblCodigoServico.Location = New System.Drawing.Point(6, 57)
        Me.lblCodigoServico.Name = "lblCodigoServico"
        Me.lblCodigoServico.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigoServico.TabIndex = 8
        Me.lblCodigoServico.Text = "Código:"
        '
        'lblDescricaoServico
        '
        Me.lblDescricaoServico.AutoSize = True
        Me.lblDescricaoServico.Location = New System.Drawing.Point(6, 97)
        Me.lblDescricaoServico.Name = "lblDescricaoServico"
        Me.lblDescricaoServico.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoServico.TabIndex = 19
        Me.lblDescricaoServico.Text = "Descrição:"
        '
        'txtDescricaoServico
        '
        Me.txtDescricaoServico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoServico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricaoServico.Location = New System.Drawing.Point(9, 114)
        Me.txtDescricaoServico.MaxLength = 120
        Me.txtDescricaoServico.Multiline = True
        Me.txtDescricaoServico.Name = "txtDescricaoServico"
        Me.txtDescricaoServico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescricaoServico.Size = New System.Drawing.Size(879, 126)
        Me.txtDescricaoServico.TabIndex = 20
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(0, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(0, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 0
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(0, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 0
        '
        'GridEX2
        '
        Me.GridEX2.Location = New System.Drawing.Point(0, 0)
        Me.GridEX2.Name = "GridEX2"
        Me.GridEX2.Size = New System.Drawing.Size(400, 376)
        Me.GridEX2.TabIndex = 0
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.UiGroupBox2.TabIndex = 0
        '
        'UiButton3
        '
        Me.UiButton3.Location = New System.Drawing.Point(0, 0)
        Me.UiButton3.Name = "UiButton3"
        Me.UiButton3.Size = New System.Drawing.Size(75, 23)
        Me.UiButton3.TabIndex = 0
        '
        'UiButton4
        '
        Me.UiButton4.Location = New System.Drawing.Point(0, 0)
        Me.UiButton4.Name = "UiButton4"
        Me.UiButton4.Size = New System.Drawing.Size(75, 23)
        Me.UiButton4.TabIndex = 0
        '
        'NumericEditBox3
        '
        Me.NumericEditBox3.Location = New System.Drawing.Point(0, 0)
        Me.NumericEditBox3.Name = "NumericEditBox3"
        Me.NumericEditBox3.Size = New System.Drawing.Size(100, 20)
        Me.NumericEditBox3.TabIndex = 0
        Me.NumericEditBox3.Text = "0,00"
        Me.NumericEditBox3.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 0
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(0, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 0
        '
        'UiComboBox3
        '
        Me.UiComboBox3.Location = New System.Drawing.Point(0, 0)
        Me.UiComboBox3.Name = "UiComboBox3"
        Me.UiComboBox3.Size = New System.Drawing.Size(176, 20)
        Me.UiComboBox3.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 0
        '
        'NumericEditBox4
        '
        Me.NumericEditBox4.Location = New System.Drawing.Point(0, 0)
        Me.NumericEditBox4.Name = "NumericEditBox4"
        Me.NumericEditBox4.Size = New System.Drawing.Size(100, 20)
        Me.NumericEditBox4.TabIndex = 0
        Me.NumericEditBox4.Text = "0,00"
        Me.NumericEditBox4.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 0
        '
        'UiComboBox4
        '
        Me.UiComboBox4.Location = New System.Drawing.Point(0, 0)
        Me.UiComboBox4.Name = "UiComboBox4"
        Me.UiComboBox4.Size = New System.Drawing.Size(176, 20)
        Me.UiComboBox4.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 0
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(0, 0)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 0
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(0, 0)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 0
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(0, 0)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 0
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.UiGroupBox3.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 0
        '
        'MaskedEditBox1
        '
        Me.MaskedEditBox1.Location = New System.Drawing.Point(0, 0)
        Me.MaskedEditBox1.Name = "MaskedEditBox1"
        Me.MaskedEditBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedEditBox1.TabIndex = 0
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(0, 0)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 0
        '
        'UiComboBox5
        '
        Me.UiComboBox5.Location = New System.Drawing.Point(0, 0)
        Me.UiComboBox5.Name = "UiComboBox5"
        Me.UiComboBox5.Size = New System.Drawing.Size(176, 20)
        Me.UiComboBox5.TabIndex = 0
        '
        'UiButton5
        '
        Me.UiButton5.Location = New System.Drawing.Point(0, 0)
        Me.UiButton5.Name = "UiButton5"
        Me.UiButton5.Size = New System.Drawing.Size(75, 23)
        Me.UiButton5.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 23)
        Me.Label11.TabIndex = 0
        '
        'MaskedEditBox2
        '
        Me.MaskedEditBox2.Location = New System.Drawing.Point(0, 0)
        Me.MaskedEditBox2.Name = "MaskedEditBox2"
        Me.MaskedEditBox2.Size = New System.Drawing.Size(100, 20)
        Me.MaskedEditBox2.TabIndex = 0
        '
        'UiButton6
        '
        Me.UiButton6.Location = New System.Drawing.Point(0, 0)
        Me.UiButton6.Name = "UiButton6"
        Me.UiButton6.Size = New System.Drawing.Size(75, 23)
        Me.UiButton6.TabIndex = 0
        '
        'UiButton7
        '
        Me.UiButton7.Location = New System.Drawing.Point(0, 0)
        Me.UiButton7.Name = "UiButton7"
        Me.UiButton7.Size = New System.Drawing.Size(75, 23)
        Me.UiButton7.TabIndex = 0
        '
        'MaskedEditBox3
        '
        Me.MaskedEditBox3.Location = New System.Drawing.Point(0, 0)
        Me.MaskedEditBox3.Name = "MaskedEditBox3"
        Me.MaskedEditBox3.Size = New System.Drawing.Size(100, 20)
        Me.MaskedEditBox3.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 23)
        Me.Label12.TabIndex = 0
        '
        'GridEX3
        '
        Me.GridEX3.Location = New System.Drawing.Point(0, 0)
        Me.GridEX3.Name = "GridEX3"
        Me.GridEX3.Size = New System.Drawing.Size(400, 376)
        Me.GridEX3.TabIndex = 0
        '
        'usrCadCadernoServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadCadernoServico"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.spcMain.Panel1.ResumeLayout(False)
        Me.spcMain.Panel2.ResumeLayout(False)
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcMain.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdComposicao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpComposicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpComposicao.ResumeLayout(False)
        Me.grpComposicao.PerformLayout()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtDescricaoServico As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtCodigoServico As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoServico As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblGrupoItem As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarGrupoItem As System.Windows.Forms.Button
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarEspecie As System.Windows.Forms.Button
    Friend WithEvents lblEspecie As System.Windows.Forms.Label
    Friend WithEvents cboEspecie As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarUnidadeMedida As System.Windows.Forms.Button
    Friend WithEvents cboUnidadeMedida As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUnidadeMedida As System.Windows.Forms.Label
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GridEX2 As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiButton3 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton4 As Janus.Windows.EditControls.UIButton
    Friend WithEvents NumericEditBox3 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents UiComboBox3 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NumericEditBox4 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UiComboBox4 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MaskedEditBox1 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents UiComboBox5 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents UiButton5 As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MaskedEditBox2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents UiButton6 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton7 As Janus.Windows.EditControls.UIButton
    Friend WithEvents MaskedEditBox3 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GridEX3 As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnAgruparGridComposicao As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridComposicao As System.Windows.Forms.Button
    Friend WithEvents grdComposicao As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpComposicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboTipo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents btnExcluirComposicao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirComposicao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCadastrarUnidadeMedidaComposicao As System.Windows.Forms.Button
    Friend WithEvents cboUnidadeMedidaComposicao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUnidadeMedidaComposicao As System.Windows.Forms.Label
    Friend WithEvents txtPercentualHP As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPercentualHP As System.Windows.Forms.Label
    Friend WithEvents cboItemComposicao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblItemComposicao As System.Windows.Forms.Label
    Friend WithEvents btnExcelGridComposicao As System.Windows.Forms.Button
    Friend WithEvents btnProcurarItem As System.Windows.Forms.Button
    Friend WithEvents txtPercentualHI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPercentualHI As System.Windows.Forms.Label
    Friend WithEvents spcMain As System.Windows.Forms.SplitContainer
    Friend WithEvents txtCoeficiente As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCoeficiente As System.Windows.Forms.Label
    Friend WithEvents txtCoeficienteServico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCoeficienteServico As System.Windows.Forms.Label
    Friend WithEvents txtPercentualHIServico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPercentualHIServico As System.Windows.Forms.Label
    Friend WithEvents txtPercentualHPServico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPercentualHPServico As System.Windows.Forms.Label
    Friend WithEvents btnColarComposicao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCopiarComposicao As Janus.Windows.EditControls.UIButton

End Class
