<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrEstRequisicaoIssartel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrEstRequisicaoIssartel))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column0.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column2.Image")
        Dim cboTipoRequisicaoFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProduto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProduto_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGridRequisicao = New System.Windows.Forms.Button()
        Me.btnConfigurarGridRequisicao = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCancelada = New System.Windows.Forms.Label()
        Me.picCancelada = New System.Windows.Forms.PictureBox()
        Me.lblRequisicaoPaga = New System.Windows.Forms.Label()
        Me.picRequisicaoPaga = New System.Windows.Forms.PictureBox()
        Me.picNaoAtendida = New System.Windows.Forms.PictureBox()
        Me.lblParcialmentePaga = New System.Windows.Forms.Label()
        Me.picParcialmentePaga = New System.Windows.Forms.PictureBox()
        Me.lblNaoAtendida = New System.Windows.Forms.Label()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboTipoRequisicaoFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.dtpDataRequisicaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataRequisicaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoFiltro = New System.Windows.Forms.Label()
        Me.lblTipoRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblProdutoFiltro = New System.Windows.Forms.Label()
        Me.txtProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroRequisicaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.lblDataRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGridProduto = New System.Windows.Forms.Button()
        Me.btnConfigurarGridProduto = New System.Windows.Forms.Button()
        Me.grdProduto = New Janus.Windows.GridEX.GridEX()
        Me.grpItem = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDET = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDET = New System.Windows.Forms.Label()
        Me.txtSC = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblSC = New System.Windows.Forms.Label()
        Me.lblObservacaoBom = New System.Windows.Forms.Label()
        Me.txtObservacaoBOM = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboUnidadeMedidaDimensao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUnidadeMedidaDimensao = New System.Windows.Forms.Label()
        Me.lblDimensao = New System.Windows.Forms.Label()
        Me.txtDimensao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtAltura = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtComprimento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.lblComprimento = New System.Windows.Forms.Label()
        Me.txtLargura = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblLargura = New System.Windows.Forms.Label()
        Me.lblTipoItem = New System.Windows.Forms.Label()
        Me.cboTipoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.dtpDataNecessidade = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.btnCadastrarMotivo = New System.Windows.Forms.Button()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricaoProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboMotivoRequisicao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMotivoRequisicao = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.cboProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.btnCadastrarProduto = New System.Windows.Forms.Button()
        Me.btnExcluirProduto = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirProduto = New Janus.Windows.EditControls.UIButton()
        Me.lblDataNecessidade = New System.Windows.Forms.Label()
        Me.grpRequisicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataRequisicao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboNumeroDocumento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.cboTipoRequisicao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoRequisicao = New System.Windows.Forms.Label()
        Me.lblDataRequisicao = New System.Windows.Forms.Label()
        Me.txtNumeroRequisicao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRequisicao = New System.Windows.Forms.Label()
        Me.txtReferencia = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCancelada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRequisicaoPaga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNaoAtendida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picParcialmentePaga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItem.SuspendLayout()
        CType(Me.grpRequisicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRequisicao.SuspendLayout()
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
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(1131, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnAgruparGridRequisicao)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGridRequisicao)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(1129, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Lista de Requisição"
        '
        'btnAgruparGridRequisicao
        '
        Me.btnAgruparGridRequisicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridRequisicao.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridRequisicao.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridRequisicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridRequisicao.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridRequisicao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridRequisicao.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGridRequisicao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridRequisicao.Name = "btnAgruparGridRequisicao"
        Me.btnAgruparGridRequisicao.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridRequisicao.TabIndex = 3
        Me.btnAgruparGridRequisicao.TabStop = False
        Me.btnAgruparGridRequisicao.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridRequisicao
        '
        Me.btnConfigurarGridRequisicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridRequisicao.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridRequisicao.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridRequisicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridRequisicao.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridRequisicao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridRequisicao.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGridRequisicao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridRequisicao.Name = "btnConfigurarGridRequisicao"
        Me.btnConfigurarGridRequisicao.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridRequisicao.TabIndex = 2
        Me.btnConfigurarGridRequisicao.TabStop = False
        Me.btnConfigurarGridRequisicao.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_3.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2, grdListagem_DesignTimeLayout_Reference_3})
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
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(1113, 364)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdListagem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.Label1)
        Me.grpLegenda.Controls.Add(Me.PictureBox1)
        Me.grpLegenda.Controls.Add(Me.lblCancelada)
        Me.grpLegenda.Controls.Add(Me.picCancelada)
        Me.grpLegenda.Controls.Add(Me.lblRequisicaoPaga)
        Me.grpLegenda.Controls.Add(Me.picRequisicaoPaga)
        Me.grpLegenda.Controls.Add(Me.picNaoAtendida)
        Me.grpLegenda.Controls.Add(Me.lblParcialmentePaga)
        Me.grpLegenda.Controls.Add(Me.picParcialmentePaga)
        Me.grpLegenda.Controls.Add(Me.lblNaoAtendida)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(386, 51)
        Me.grpLegenda.TabIndex = 4
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(261, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 14)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Perda"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Peru
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(242, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(13, 14)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'lblCancelada
        '
        Me.lblCancelada.AutoSize = True
        Me.lblCancelada.Location = New System.Drawing.Point(140, 30)
        Me.lblCancelada.Name = "lblCancelada"
        Me.lblCancelada.Size = New System.Drawing.Size(58, 14)
        Me.lblCancelada.TabIndex = 3
        Me.lblCancelada.Text = "Cancelada"
        '
        'picCancelada
        '
        Me.picCancelada.BackColor = System.Drawing.Color.Firebrick
        Me.picCancelada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCancelada.Location = New System.Drawing.Point(121, 30)
        Me.picCancelada.Name = "picCancelada"
        Me.picCancelada.Size = New System.Drawing.Size(13, 14)
        Me.picCancelada.TabIndex = 20
        Me.picCancelada.TabStop = False
        '
        'lblRequisicaoPaga
        '
        Me.lblRequisicaoPaga.AutoSize = True
        Me.lblRequisicaoPaga.Location = New System.Drawing.Point(28, 30)
        Me.lblRequisicaoPaga.Name = "lblRequisicaoPaga"
        Me.lblRequisicaoPaga.Size = New System.Drawing.Size(87, 14)
        Me.lblRequisicaoPaga.TabIndex = 1
        Me.lblRequisicaoPaga.Text = "Requisição Paga"
        '
        'picRequisicaoPaga
        '
        Me.picRequisicaoPaga.BackColor = System.Drawing.Color.ForestGreen
        Me.picRequisicaoPaga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRequisicaoPaga.Location = New System.Drawing.Point(9, 30)
        Me.picRequisicaoPaga.Name = "picRequisicaoPaga"
        Me.picRequisicaoPaga.Size = New System.Drawing.Size(13, 14)
        Me.picRequisicaoPaga.TabIndex = 6
        Me.picRequisicaoPaga.TabStop = False
        '
        'picNaoAtendida
        '
        Me.picNaoAtendida.BackColor = System.Drawing.Color.DarkGray
        Me.picNaoAtendida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picNaoAtendida.Location = New System.Drawing.Point(9, 13)
        Me.picNaoAtendida.Name = "picNaoAtendida"
        Me.picNaoAtendida.Size = New System.Drawing.Size(13, 14)
        Me.picNaoAtendida.TabIndex = 4
        Me.picNaoAtendida.TabStop = False
        '
        'lblParcialmentePaga
        '
        Me.lblParcialmentePaga.AutoSize = True
        Me.lblParcialmentePaga.Location = New System.Drawing.Point(140, 13)
        Me.lblParcialmentePaga.Name = "lblParcialmentePaga"
        Me.lblParcialmentePaga.Size = New System.Drawing.Size(95, 14)
        Me.lblParcialmentePaga.TabIndex = 2
        Me.lblParcialmentePaga.Text = "Parcialmente Paga"
        '
        'picParcialmentePaga
        '
        Me.picParcialmentePaga.BackColor = System.Drawing.Color.SteelBlue
        Me.picParcialmentePaga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picParcialmentePaga.Location = New System.Drawing.Point(121, 13)
        Me.picParcialmentePaga.Name = "picParcialmentePaga"
        Me.picParcialmentePaga.Size = New System.Drawing.Size(13, 14)
        Me.picParcialmentePaga.TabIndex = 18
        Me.picParcialmentePaga.TabStop = False
        '
        'lblNaoAtendida
        '
        Me.lblNaoAtendida.AutoSize = True
        Me.lblNaoAtendida.Location = New System.Drawing.Point(28, 13)
        Me.lblNaoAtendida.Name = "lblNaoAtendida"
        Me.lblNaoAtendida.Size = New System.Drawing.Size(71, 14)
        Me.lblNaoAtendida.TabIndex = 0
        Me.lblNaoAtendida.Text = "Não Atendida"
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboTipoRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataRequisicaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataRequisicaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataRequisicaoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(1113, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboTipoRequisicaoFiltro
        '
        Me.cboTipoRequisicaoFiltro.AllowDrop = True
        Me.cboTipoRequisicaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoRequisicaoFiltro.ButtonCancelText = "Cancelar"
        Me.cboTipoRequisicaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboTipoRequisicaoFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboTipoRequisicaoFiltro_DesignTimeLayout.LayoutString")
        Me.cboTipoRequisicaoFiltro.DesignTimeLayout = cboTipoRequisicaoFiltro_DesignTimeLayout
        Me.cboTipoRequisicaoFiltro.Location = New System.Drawing.Point(351, 34)
        Me.cboTipoRequisicaoFiltro.Name = "cboTipoRequisicaoFiltro"
        Me.cboTipoRequisicaoFiltro.SaveSettings = False
        Me.cboTipoRequisicaoFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboTipoRequisicaoFiltro.Size = New System.Drawing.Size(419, 20)
        Me.cboTipoRequisicaoFiltro.TabIndex = 6
        Me.cboTipoRequisicaoFiltro.ValuesDataMember = Nothing
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(489, 74)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(421, 20)
        Me.cboStatusFiltro.TabIndex = 12
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'dtpDataRequisicaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataRequisicaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataRequisicaoTerminoFiltro.Location = New System.Drawing.Point(237, 34)
        Me.dtpDataRequisicaoTerminoFiltro.Name = "dtpDataRequisicaoTerminoFiltro"
        Me.dtpDataRequisicaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataRequisicaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataRequisicaoTerminoFiltro.TabIndex = 4
        '
        'dtpDataRequisicaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataRequisicaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataRequisicaoInicioFiltro.Location = New System.Drawing.Point(123, 34)
        Me.dtpDataRequisicaoInicioFiltro.Name = "dtpDataRequisicaoInicioFiltro"
        Me.dtpDataRequisicaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataRequisicaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataRequisicaoInicioFiltro.TabIndex = 3
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(486, 57)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 11
        Me.lblStatusFiltro.Text = "Status:"
        '
        'txtNumeroDocumentoFiltro
        '
        Me.txtNumeroDocumentoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroDocumentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumentoFiltro.Location = New System.Drawing.Point(776, 34)
        Me.txtNumeroDocumentoFiltro.MaxLength = 8
        Me.txtNumeroDocumentoFiltro.Name = "txtNumeroDocumentoFiltro"
        Me.txtNumeroDocumentoFiltro.Size = New System.Drawing.Size(134, 20)
        Me.txtNumeroDocumentoFiltro.TabIndex = 8
        '
        'lblNumeroDocumentoFiltro
        '
        Me.lblNumeroDocumentoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroDocumentoFiltro.AutoSize = True
        Me.lblNumeroDocumentoFiltro.Location = New System.Drawing.Point(773, 17)
        Me.lblNumeroDocumentoFiltro.Name = "lblNumeroDocumentoFiltro"
        Me.lblNumeroDocumentoFiltro.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumentoFiltro.TabIndex = 7
        Me.lblNumeroDocumentoFiltro.Text = "Nº Documento:"
        '
        'lblTipoRequisicaoFiltro
        '
        Me.lblTipoRequisicaoFiltro.AutoSize = True
        Me.lblTipoRequisicaoFiltro.Location = New System.Drawing.Point(348, 17)
        Me.lblTipoRequisicaoFiltro.Name = "lblTipoRequisicaoFiltro"
        Me.lblTipoRequisicaoFiltro.Size = New System.Drawing.Size(101, 14)
        Me.lblTipoRequisicaoFiltro.TabIndex = 5
        Me.lblTipoRequisicaoFiltro.Text = "Tipo de Requisição:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(1013, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 13
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblProdutoFiltro
        '
        Me.lblProdutoFiltro.AutoSize = True
        Me.lblProdutoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblProdutoFiltro.Name = "lblProdutoFiltro"
        Me.lblProdutoFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblProdutoFiltro.TabIndex = 9
        Me.lblProdutoFiltro.Text = "Produto:"
        '
        'txtProdutoFiltro
        '
        Me.txtProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtProdutoFiltro.MaxLength = 100
        Me.txtProdutoFiltro.Name = "txtProdutoFiltro"
        Me.txtProdutoFiltro.Size = New System.Drawing.Size(474, 20)
        Me.txtProdutoFiltro.TabIndex = 10
        '
        'txtNumeroRequisicaoFiltro
        '
        Me.txtNumeroRequisicaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRequisicaoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroRequisicaoFiltro.MaxLength = 8
        Me.txtNumeroRequisicaoFiltro.Name = "txtNumeroRequisicaoFiltro"
        Me.txtNumeroRequisicaoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.txtNumeroRequisicaoFiltro.TabIndex = 1
        '
        'lblNumeroRequisicaoFiltro
        '
        Me.lblNumeroRequisicaoFiltro.AutoSize = True
        Me.lblNumeroRequisicaoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroRequisicaoFiltro.Name = "lblNumeroRequisicaoFiltro"
        Me.lblNumeroRequisicaoFiltro.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroRequisicaoFiltro.TabIndex = 0
        Me.lblNumeroRequisicaoFiltro.Text = "Nº Requisição:"
        '
        'lblDataRequisicaoFiltro
        '
        Me.lblDataRequisicaoFiltro.AutoSize = True
        Me.lblDataRequisicaoFiltro.Location = New System.Drawing.Point(120, 17)
        Me.lblDataRequisicaoFiltro.Name = "lblDataRequisicaoFiltro"
        Me.lblDataRequisicaoFiltro.Size = New System.Drawing.Size(103, 14)
        Me.lblDataRequisicaoFiltro.TabIndex = 2
        Me.lblDataRequisicaoFiltro.Text = "Data da Requisição:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnExcluir)
        Me.grpControle.Controls.Add(Me.btnExcel)
        Me.grpControle.Controls.Add(Me.btnNovo1)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(400, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(721, 51)
        Me.grpControle.TabIndex = 5
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(427, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 2
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(330, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 0
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(524, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 3
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(621, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnExcelGrid)
        Me.pagDados.Controls.Add(Me.btnAgruparGridProduto)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridProduto)
        Me.pagDados.Controls.Add(Me.grdProduto)
        Me.pagDados.Controls.Add(Me.grpItem)
        Me.pagDados.Controls.Add(Me.grpRequisicao)
        Me.pagDados.Controls.Add(Me.grpControl)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagLista"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(1129, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados da Requisição de Estoque"
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
        Me.btnExcelGrid.TabIndex = 5
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGridProduto
        '
        Me.btnAgruparGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridProduto.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridProduto.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridProduto.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridProduto.Name = "btnAgruparGridProduto"
        Me.btnAgruparGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridProduto.TabIndex = 4
        Me.btnAgruparGridProduto.TabStop = False
        Me.btnAgruparGridProduto.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridProduto
        '
        Me.btnConfigurarGridProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridProduto.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridProduto.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridProduto.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGridProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridProduto.Name = "btnConfigurarGridProduto"
        Me.btnConfigurarGridProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridProduto.TabIndex = 3
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
        Me.grdProduto.AutoEdit = True
        grdProduto_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdProduto_DesignTimeLayout_Reference_0.Instance"), Object)
        grdProduto_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdProduto_DesignTimeLayout_Reference_0})
        grdProduto_DesignTimeLayout.LayoutString = resources.GetString("grdProduto_DesignTimeLayout.LayoutString")
        Me.grdProduto.DesignTimeLayout = grdProduto_DesignTimeLayout
        Me.grdProduto.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdProduto.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdProduto.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdProduto.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdProduto.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdProduto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProduto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProduto.FrozenColumns = 2
        Me.grdProduto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProduto.GroupByBoxVisible = False
        Me.grdProduto.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdProduto.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdProduto.Location = New System.Drawing.Point(8, 185)
        Me.grdProduto.Name = "grdProduto"
        Me.grdProduto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProduto.RecordNavigator = True
        Me.grdProduto.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdProduto.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProduto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProduto.Size = New System.Drawing.Size(1113, 295)
        Me.grdProduto.TabIndex = 2
        Me.grdProduto.TabStop = False
        Me.grdProduto.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdProduto.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdProduto.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdProduto.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdProduto.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdProduto.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdProduto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdProduto.VisualStyleManager = Me.vsmMain
        '
        'grpItem
        '
        Me.grpItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpItem.BackColor = System.Drawing.Color.Transparent
        Me.grpItem.Controls.Add(Me.txtDET)
        Me.grpItem.Controls.Add(Me.lblDET)
        Me.grpItem.Controls.Add(Me.txtSC)
        Me.grpItem.Controls.Add(Me.lblSC)
        Me.grpItem.Controls.Add(Me.lblObservacaoBom)
        Me.grpItem.Controls.Add(Me.txtObservacaoBOM)
        Me.grpItem.Controls.Add(Me.cboUnidadeMedidaDimensao)
        Me.grpItem.Controls.Add(Me.lblUnidadeMedidaDimensao)
        Me.grpItem.Controls.Add(Me.lblDimensao)
        Me.grpItem.Controls.Add(Me.txtDimensao)
        Me.grpItem.Controls.Add(Me.txtAltura)
        Me.grpItem.Controls.Add(Me.txtComprimento)
        Me.grpItem.Controls.Add(Me.lblAltura)
        Me.grpItem.Controls.Add(Me.lblComprimento)
        Me.grpItem.Controls.Add(Me.txtLargura)
        Me.grpItem.Controls.Add(Me.lblLargura)
        Me.grpItem.Controls.Add(Me.lblTipoItem)
        Me.grpItem.Controls.Add(Me.cboTipoItem)
        Me.grpItem.Controls.Add(Me.dtpDataNecessidade)
        Me.grpItem.Controls.Add(Me.btnCadastrarMotivo)
        Me.grpItem.Controls.Add(Me.lblDescricao)
        Me.grpItem.Controls.Add(Me.txtDescricaoProduto)
        Me.grpItem.Controls.Add(Me.cboMotivoRequisicao)
        Me.grpItem.Controls.Add(Me.lblMotivoRequisicao)
        Me.grpItem.Controls.Add(Me.txtQuantidade)
        Me.grpItem.Controls.Add(Me.lblQuantidade)
        Me.grpItem.Controls.Add(Me.cboProduto)
        Me.grpItem.Controls.Add(Me.lblProduto)
        Me.grpItem.Controls.Add(Me.btnProcurarProduto)
        Me.grpItem.Controls.Add(Me.btnCadastrarProduto)
        Me.grpItem.Controls.Add(Me.btnExcluirProduto)
        Me.grpItem.Controls.Add(Me.btnInserirProduto)
        Me.grpItem.Controls.Add(Me.lblDataNecessidade)
        Me.grpItem.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpItem.Location = New System.Drawing.Point(8, 69)
        Me.grpItem.Name = "grpItem"
        Me.grpItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpItem.Size = New System.Drawing.Size(1113, 107)
        Me.grpItem.TabIndex = 1
        Me.grpItem.Text = "Dados do Produto"
        Me.grpItem.VisualStyleManager = Me.vsmMain
        '
        'txtDET
        '
        Me.txtDET.DecimalDigits = 0
        Me.txtDET.FormatString = "000"
        Me.txtDET.Location = New System.Drawing.Point(966, 78)
        Me.txtDET.MaxLength = 3
        Me.txtDET.Name = "txtDET"
        Me.txtDET.Size = New System.Drawing.Size(40, 20)
        Me.txtDET.TabIndex = 14
        Me.txtDET.Text = "000"
        Me.txtDET.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblDET
        '
        Me.lblDET.AutoSize = True
        Me.lblDET.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDET.Location = New System.Drawing.Point(964, 61)
        Me.lblDET.Name = "lblDET"
        Me.lblDET.Size = New System.Drawing.Size(28, 14)
        Me.lblDET.TabIndex = 27
        Me.lblDET.Text = "DET:"
        '
        'txtSC
        '
        Me.txtSC.DecimalDigits = 0
        Me.txtSC.FormatString = "000"
        Me.txtSC.Location = New System.Drawing.Point(916, 78)
        Me.txtSC.MaxLength = 3
        Me.txtSC.Name = "txtSC"
        Me.txtSC.Size = New System.Drawing.Size(43, 20)
        Me.txtSC.TabIndex = 13
        Me.txtSC.Text = "000"
        Me.txtSC.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSC
        '
        Me.lblSC.AutoSize = True
        Me.lblSC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSC.Location = New System.Drawing.Point(913, 61)
        Me.lblSC.Name = "lblSC"
        Me.lblSC.Size = New System.Drawing.Size(24, 14)
        Me.lblSC.TabIndex = 25
        Me.lblSC.Text = "SC:"
        '
        'lblObservacaoBom
        '
        Me.lblObservacaoBom.AutoSize = True
        Me.lblObservacaoBom.Location = New System.Drawing.Point(534, 61)
        Me.lblObservacaoBom.Name = "lblObservacaoBom"
        Me.lblObservacaoBom.Size = New System.Drawing.Size(96, 14)
        Me.lblObservacaoBom.TabIndex = 24
        Me.lblObservacaoBom.Text = "Observação BOM:"
        '
        'txtObservacaoBOM
        '
        Me.txtObservacaoBOM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacaoBOM.Location = New System.Drawing.Point(537, 78)
        Me.txtObservacaoBOM.MaxLength = 100
        Me.txtObservacaoBOM.Name = "txtObservacaoBOM"
        Me.txtObservacaoBOM.Size = New System.Drawing.Size(373, 20)
        Me.txtObservacaoBOM.TabIndex = 12
        '
        'cboUnidadeMedidaDimensao
        '
        Me.cboUnidadeMedidaDimensao.AutoSize = False
        Me.cboUnidadeMedidaDimensao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = ""
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = ""
        Me.cboUnidadeMedidaDimensao.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboUnidadeMedidaDimensao.Location = New System.Drawing.Point(290, 78)
        Me.cboUnidadeMedidaDimensao.Name = "cboUnidadeMedidaDimensao"
        Me.cboUnidadeMedidaDimensao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedidaDimensao.Size = New System.Drawing.Size(70, 20)
        Me.cboUnidadeMedidaDimensao.TabIndex = 9
        Me.cboUnidadeMedidaDimensao.Visible = False
        '
        'lblUnidadeMedidaDimensao
        '
        Me.lblUnidadeMedidaDimensao.AutoSize = True
        Me.lblUnidadeMedidaDimensao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUnidadeMedidaDimensao.Location = New System.Drawing.Point(287, 61)
        Me.lblUnidadeMedidaDimensao.Name = "lblUnidadeMedidaDimensao"
        Me.lblUnidadeMedidaDimensao.Size = New System.Drawing.Size(58, 14)
        Me.lblUnidadeMedidaDimensao.TabIndex = 18
        Me.lblUnidadeMedidaDimensao.Text = "Und. Med.:"
        Me.lblUnidadeMedidaDimensao.Visible = False
        '
        'lblDimensao
        '
        Me.lblDimensao.AutoSize = True
        Me.lblDimensao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDimensao.Location = New System.Drawing.Point(363, 61)
        Me.lblDimensao.Name = "lblDimensao"
        Me.lblDimensao.Size = New System.Drawing.Size(57, 14)
        Me.lblDimensao.TabIndex = 20
        Me.lblDimensao.Text = "Dimensão:"
        Me.lblDimensao.Visible = False
        '
        'txtDimensao
        '
        Me.txtDimensao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDimensao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDimensao.Location = New System.Drawing.Point(366, 78)
        Me.txtDimensao.MaxLength = 120
        Me.txtDimensao.Name = "txtDimensao"
        Me.txtDimensao.ReadOnly = True
        Me.txtDimensao.Size = New System.Drawing.Size(165, 20)
        Me.txtDimensao.TabIndex = 11
        Me.txtDimensao.TabStop = False
        Me.txtDimensao.Visible = False
        '
        'txtAltura
        '
        Me.txtAltura.BackColor = System.Drawing.Color.White
        Me.txtAltura.DecimalDigits = 0
        Me.txtAltura.Location = New System.Drawing.Point(239, 78)
        Me.txtAltura.MaxLength = 100
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(45, 20)
        Me.txtAltura.TabIndex = 8
        Me.txtAltura.Text = "0"
        Me.txtAltura.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAltura.Visible = False
        '
        'txtComprimento
        '
        Me.txtComprimento.BackColor = System.Drawing.Color.White
        Me.txtComprimento.DecimalDigits = 0
        Me.txtComprimento.Location = New System.Drawing.Point(102, 78)
        Me.txtComprimento.MaxLength = 100
        Me.txtComprimento.Name = "txtComprimento"
        Me.txtComprimento.Size = New System.Drawing.Size(70, 20)
        Me.txtComprimento.TabIndex = 6
        Me.txtComprimento.Text = "0"
        Me.txtComprimento.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtComprimento.Visible = False
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAltura.Location = New System.Drawing.Point(236, 61)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(39, 14)
        Me.lblAltura.TabIndex = 16
        Me.lblAltura.Text = "Altura:"
        Me.lblAltura.Visible = False
        '
        'lblComprimento
        '
        Me.lblComprimento.AutoSize = True
        Me.lblComprimento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblComprimento.Location = New System.Drawing.Point(99, 61)
        Me.lblComprimento.Name = "lblComprimento"
        Me.lblComprimento.Size = New System.Drawing.Size(72, 14)
        Me.lblComprimento.TabIndex = 12
        Me.lblComprimento.Text = "Comprimento:"
        Me.lblComprimento.Visible = False
        '
        'txtLargura
        '
        Me.txtLargura.BackColor = System.Drawing.Color.White
        Me.txtLargura.DecimalDigits = 0
        Me.txtLargura.Location = New System.Drawing.Point(178, 78)
        Me.txtLargura.MaxLength = 100
        Me.txtLargura.Name = "txtLargura"
        Me.txtLargura.Size = New System.Drawing.Size(55, 20)
        Me.txtLargura.TabIndex = 7
        Me.txtLargura.Text = "0"
        Me.txtLargura.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLargura.Visible = False
        '
        'lblLargura
        '
        Me.lblLargura.AutoSize = True
        Me.lblLargura.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLargura.Location = New System.Drawing.Point(175, 61)
        Me.lblLargura.Name = "lblLargura"
        Me.lblLargura.Size = New System.Drawing.Size(48, 14)
        Me.lblLargura.TabIndex = 14
        Me.lblLargura.Text = "Largura:"
        Me.lblLargura.Visible = False
        '
        'lblTipoItem
        '
        Me.lblTipoItem.AutoSize = True
        Me.lblTipoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoItem.Location = New System.Drawing.Point(662, 20)
        Me.lblTipoItem.Name = "lblTipoItem"
        Me.lblTipoItem.Size = New System.Drawing.Size(67, 14)
        Me.lblTipoItem.TabIndex = 6
        Me.lblTipoItem.Text = "Tipo de Item:"
        '
        'cboTipoItem
        '
        Me.cboTipoItem.Location = New System.Drawing.Point(665, 37)
        Me.cboTipoItem.Name = "cboTipoItem"
        Me.cboTipoItem.Size = New System.Drawing.Size(127, 20)
        Me.cboTipoItem.TabIndex = 3
        '
        'dtpDataNecessidade
        '
        '
        '
        '
        Me.dtpDataNecessidade.DropDownCalendar.Name = ""
        Me.dtpDataNecessidade.Location = New System.Drawing.Point(798, 37)
        Me.dtpDataNecessidade.Name = "dtpDataNecessidade"
        Me.dtpDataNecessidade.ShowCheckBox = True
        Me.dtpDataNecessidade.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataNecessidade.TabIndex = 4
        '
        'btnCadastrarMotivo
        '
        Me.btnCadastrarMotivo.FlatAppearance.BorderSize = 0
        Me.btnCadastrarMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarMotivo.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarMotivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarMotivo.Location = New System.Drawing.Point(537, 20)
        Me.btnCadastrarMotivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarMotivo.Name = "btnCadastrarMotivo"
        Me.btnCadastrarMotivo.Size = New System.Drawing.Size(14, 13)
        Me.btnCadastrarMotivo.TabIndex = 4
        Me.btnCadastrarMotivo.TabStop = False
        Me.btnCadastrarMotivo.UseVisualStyleBackColor = True
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(174, 20)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtDescricaoProduto
        '
        Me.txtDescricaoProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoProduto.Location = New System.Drawing.Point(177, 37)
        Me.txtDescricaoProduto.Name = "txtDescricaoProduto"
        Me.txtDescricaoProduto.ReadOnly = True
        Me.txtDescricaoProduto.Size = New System.Drawing.Size(354, 20)
        Me.txtDescricaoProduto.TabIndex = 1
        Me.txtDescricaoProduto.TabStop = False
        '
        'cboMotivoRequisicao
        '
        Me.cboMotivoRequisicao.AutoSize = False
        Me.cboMotivoRequisicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMotivoRequisicao.Location = New System.Drawing.Point(537, 37)
        Me.cboMotivoRequisicao.Name = "cboMotivoRequisicao"
        Me.cboMotivoRequisicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMotivoRequisicao.Size = New System.Drawing.Size(122, 20)
        Me.cboMotivoRequisicao.TabIndex = 2
        '
        'lblMotivoRequisicao
        '
        Me.lblMotivoRequisicao.AutoSize = True
        Me.lblMotivoRequisicao.Location = New System.Drawing.Point(553, 20)
        Me.lblMotivoRequisicao.Name = "lblMotivoRequisicao"
        Me.lblMotivoRequisicao.Size = New System.Drawing.Size(41, 14)
        Me.lblMotivoRequisicao.TabIndex = 8
        Me.lblMotivoRequisicao.Text = "Motivo:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQuantidade.Location = New System.Drawing.Point(9, 78)
        Me.txtQuantidade.MaxLength = 0
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(87, 20)
        Me.txtQuantidade.TabIndex = 5
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(6, 61)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(90, 14)
        Me.lblQuantidade.TabIndex = 10
        Me.lblQuantidade.Text = "Quantidade Total:"
        '
        'cboProduto
        '
        Me.cboProduto.AutoSize = False
        Me.cboProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProduto.Location = New System.Drawing.Point(9, 37)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboProduto.Size = New System.Drawing.Size(162, 20)
        Me.cboProduto.TabIndex = 0
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(25, 20)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 1
        Me.lblProduto.Text = "Produto:"
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProduto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProduto.Location = New System.Drawing.Point(154, 18)
        Me.btnProcurarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProduto.TabIndex = 3
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'btnCadastrarProduto
        '
        Me.btnCadastrarProduto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarProduto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarProduto.Location = New System.Drawing.Point(9, 21)
        Me.btnCadastrarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarProduto.Name = "btnCadastrarProduto"
        Me.btnCadastrarProduto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarProduto.TabIndex = 0
        Me.btnCadastrarProduto.TabStop = False
        Me.btnCadastrarProduto.UseVisualStyleBackColor = True
        '
        'btnExcluirProduto
        '
        Me.btnExcluirProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirProduto.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirProduto.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirProduto.Location = New System.Drawing.Point(1013, 74)
        Me.btnExcluirProduto.Name = "btnExcluirProduto"
        Me.btnExcluirProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirProduto.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirProduto.TabIndex = 16
        Me.btnExcluirProduto.Text = "Excluir"
        Me.btnExcluirProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirProduto
        '
        Me.btnInserirProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirProduto.Image = CType(resources.GetObject("btnInserirProduto.Image"), System.Drawing.Image)
        Me.btnInserirProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirProduto.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirProduto.Location = New System.Drawing.Point(1013, 45)
        Me.btnInserirProduto.Name = "btnInserirProduto"
        Me.btnInserirProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirProduto.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirProduto.TabIndex = 15
        Me.btnInserirProduto.Text = "Inserir"
        Me.btnInserirProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDataNecessidade
        '
        Me.lblDataNecessidade.AutoSize = True
        Me.lblDataNecessidade.Location = New System.Drawing.Point(795, 20)
        Me.lblDataNecessidade.Name = "lblDataNecessidade"
        Me.lblDataNecessidade.Size = New System.Drawing.Size(113, 14)
        Me.lblDataNecessidade.TabIndex = 8
        Me.lblDataNecessidade.Text = "Data da Necessidade:"
        '
        'grpRequisicao
        '
        Me.grpRequisicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpRequisicao.BackColor = System.Drawing.Color.Transparent
        Me.grpRequisicao.Controls.Add(Me.dtpDataRequisicao)
        Me.grpRequisicao.Controls.Add(Me.cboNumeroDocumento)
        Me.grpRequisicao.Controls.Add(Me.lblNumeroDocumento)
        Me.grpRequisicao.Controls.Add(Me.cboTipoRequisicao)
        Me.grpRequisicao.Controls.Add(Me.lblTipoRequisicao)
        Me.grpRequisicao.Controls.Add(Me.lblDataRequisicao)
        Me.grpRequisicao.Controls.Add(Me.txtNumeroRequisicao)
        Me.grpRequisicao.Controls.Add(Me.lblNumeroRequisicao)
        Me.grpRequisicao.Controls.Add(Me.txtReferencia)
        Me.grpRequisicao.Location = New System.Drawing.Point(8, 3)
        Me.grpRequisicao.Name = "grpRequisicao"
        Me.grpRequisicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpRequisicao.Size = New System.Drawing.Size(1113, 63)
        Me.grpRequisicao.TabIndex = 0
        Me.grpRequisicao.VisualStyleManager = Me.vsmMain
        '
        'dtpDataRequisicao
        '
        '
        '
        '
        Me.dtpDataRequisicao.DropDownCalendar.Name = ""
        Me.dtpDataRequisicao.Location = New System.Drawing.Point(123, 34)
        Me.dtpDataRequisicao.Name = "dtpDataRequisicao"
        Me.dtpDataRequisicao.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataRequisicao.TabIndex = 3
        '
        'cboNumeroDocumento
        '
        Me.cboNumeroDocumento.AutoSize = False
        Me.cboNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNumeroDocumento.Location = New System.Drawing.Point(481, 34)
        Me.cboNumeroDocumento.Name = "cboNumeroDocumento"
        Me.cboNumeroDocumento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNumeroDocumento.Size = New System.Drawing.Size(190, 20)
        Me.cboNumeroDocumento.TabIndex = 7
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(478, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 6
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'cboTipoRequisicao
        '
        Me.cboTipoRequisicao.AutoSize = False
        Me.cboTipoRequisicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoRequisicao.Location = New System.Drawing.Point(237, 34)
        Me.cboTipoRequisicao.Name = "cboTipoRequisicao"
        Me.cboTipoRequisicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoRequisicao.Size = New System.Drawing.Size(238, 20)
        Me.cboTipoRequisicao.TabIndex = 5
        '
        'lblTipoRequisicao
        '
        Me.lblTipoRequisicao.AutoSize = True
        Me.lblTipoRequisicao.Location = New System.Drawing.Point(234, 17)
        Me.lblTipoRequisicao.Name = "lblTipoRequisicao"
        Me.lblTipoRequisicao.Size = New System.Drawing.Size(101, 14)
        Me.lblTipoRequisicao.TabIndex = 4
        Me.lblTipoRequisicao.Text = "Tipo de Requisição:"
        '
        'lblDataRequisicao
        '
        Me.lblDataRequisicao.AutoSize = True
        Me.lblDataRequisicao.Location = New System.Drawing.Point(120, 17)
        Me.lblDataRequisicao.Name = "lblDataRequisicao"
        Me.lblDataRequisicao.Size = New System.Drawing.Size(103, 14)
        Me.lblDataRequisicao.TabIndex = 2
        Me.lblDataRequisicao.Text = "Data da Requisição:"
        '
        'txtNumeroRequisicao
        '
        Me.txtNumeroRequisicao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroRequisicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRequisicao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroRequisicao.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroRequisicao.MaxLength = 20
        Me.txtNumeroRequisicao.Name = "txtNumeroRequisicao"
        Me.txtNumeroRequisicao.ReadOnly = True
        Me.txtNumeroRequisicao.Size = New System.Drawing.Size(108, 20)
        Me.txtNumeroRequisicao.TabIndex = 1
        Me.txtNumeroRequisicao.TabStop = False
        Me.txtNumeroRequisicao.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblNumeroRequisicao
        '
        Me.lblNumeroRequisicao.AutoSize = True
        Me.lblNumeroRequisicao.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroRequisicao.Name = "lblNumeroRequisicao"
        Me.lblNumeroRequisicao.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroRequisicao.TabIndex = 0
        Me.lblNumeroRequisicao.Text = "Nº Requisição:"
        '
        'txtReferencia
        '
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferencia.Location = New System.Drawing.Point(481, 34)
        Me.txtReferencia.MaxLength = 100
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(407, 20)
        Me.txtReferencia.TabIndex = 8
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnNovo)
        Me.grpControl.Controls.Add(Me.btnVoltar)
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Location = New System.Drawing.Point(9, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(1112, 51)
        Me.grpControl.TabIndex = 5
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(818, 17)
        Me.btnNovo.Name = "btnNovo"
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
        Me.btnVoltar.Location = New System.Drawing.Point(1012, 17)
        Me.btnVoltar.Name = "btnVoltar"
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
        Me.btnSalvar.Location = New System.Drawing.Point(915, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrEstRequisicaoIssartel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrEstRequisicaoIssartel"
        Me.Size = New System.Drawing.Size(1131, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCancelada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRequisicaoPaga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNaoAtendida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picParcialmentePaga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItem.ResumeLayout(False)
        Me.grpItem.PerformLayout()
        CType(Me.grpRequisicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRequisicao.ResumeLayout(False)
        Me.grpRequisicao.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpRequisicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNumeroRequisicao As System.Windows.Forms.Label
    Friend WithEvents txtNumeroRequisicao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroRequisicaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblRequisicaoPaga As System.Windows.Forms.Label
    Friend WithEvents picRequisicaoPaga As System.Windows.Forms.PictureBox
    Friend WithEvents lblNaoAtendida As System.Windows.Forms.Label
    Friend WithEvents picNaoAtendida As System.Windows.Forms.PictureBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Private WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpItem As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarProduto As System.Windows.Forms.Button
    Friend WithEvents btnExcluirProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdProduto As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents lblDataRequisicao As System.Windows.Forms.Label
    Friend WithEvents cboTipoRequisicao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoRequisicao As System.Windows.Forms.Label
    Friend WithEvents lblDataNecessidade As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblTipoRequisicaoFiltro As System.Windows.Forms.Label
    Private WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents lblParcialmentePaga As System.Windows.Forms.Label
    Friend WithEvents picParcialmentePaga As System.Windows.Forms.PictureBox
    Friend WithEvents cboNumeroDocumento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboMotivoRequisicao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMotivoRequisicao As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarMotivo As System.Windows.Forms.Button
    Friend WithEvents dtpDataRequisicaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataRequisicaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataNecessidade As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataRequisicao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents cboTipoRequisicaoFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents btnConfigurarGridRequisicao As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridProduto As System.Windows.Forms.Button
    Friend WithEvents lblCancelada As System.Windows.Forms.Label
    Friend WithEvents picCancelada As System.Windows.Forms.PictureBox
    Friend WithEvents btnAgruparGridProduto As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridRequisicao As System.Windows.Forms.Button
    Friend WithEvents txtReferencia As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipoItem As System.Windows.Forms.Label
    Friend WithEvents cboTipoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboUnidadeMedidaDimensao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUnidadeMedidaDimensao As System.Windows.Forms.Label
    Friend WithEvents lblDimensao As System.Windows.Forms.Label
    Friend WithEvents txtDimensao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtAltura As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtComprimento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAltura As System.Windows.Forms.Label
    Friend WithEvents lblComprimento As System.Windows.Forms.Label
    Friend WithEvents txtLargura As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblLargura As System.Windows.Forms.Label
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents lblObservacaoBom As System.Windows.Forms.Label
    Friend WithEvents txtObservacaoBOM As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDET As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDET As System.Windows.Forms.Label
    Friend WithEvents txtSC As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblSC As System.Windows.Forms.Label

End Class
