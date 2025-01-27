<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCmp000000010
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCmp000000010))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboUnidadeMedidaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUnidadeMedidaFiltro = New System.Windows.Forms.Label()
        Me.btnProcurarFormatoAgulhaFiltro = New System.Windows.Forms.Button()
        Me.btnProcurarCorFiltro = New System.Windows.Forms.Button()
        Me.btnProcurarMarcaFiltro = New System.Windows.Forms.Button()
        Me.btnProcurarEspecialidadeFiltro = New System.Windows.Forms.Button()
        Me.btnProcurarBitolaFiltro = New System.Windows.Forms.Button()
        Me.btnProcurarTamanhoAgulhaFiltro = New System.Windows.Forms.Button()
        Me.btnProcurarDiametroFiltro = New System.Windows.Forms.Button()
        Me.btnProcurarMaterialFiltro = New System.Windows.Forms.Button()
        Me.lblCorFiltro = New System.Windows.Forms.Label()
        Me.cboCorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMarcaFiltro = New System.Windows.Forms.Label()
        Me.cboMarcaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblEspecialidadeFiltro = New System.Windows.Forms.Label()
        Me.cboEspecialidadeFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblBitolaFiltro = New System.Windows.Forms.Label()
        Me.cboBitolaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFormatoAgulhaFiltro = New System.Windows.Forms.Label()
        Me.cboFormatoAgulhaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTamanhoAgulhaFiltro = New System.Windows.Forms.Label()
        Me.cboTamanhoAgulhaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDiametroFiltro = New System.Windows.Forms.Label()
        Me.cboDiametroFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMaterialFiltro = New System.Windows.Forms.Label()
        Me.cboMaterialFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblConsiderarPedidoVendaFiltro = New System.Windows.Forms.Label()
        Me.cboConsiderarPedidoVendaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtEstoqueMinimoFiltro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.btnCadastrarRevisao = New System.Windows.Forms.Button()
        Me.lblRevisaoFiltro = New System.Windows.Forms.Label()
        Me.cboRevisaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnProcurarProdutoFiltro = New System.Windows.Forms.Button()
        Me.txtProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProdutoFiltro = New System.Windows.Forms.Label()
        Me.lblGrupoItemFiltro = New System.Windows.Forms.Label()
        Me.cboGrupoItemFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblEstoqueMinimoFiltro = New System.Windows.Forms.Label()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnPedidoCompra = New Janus.Windows.EditControls.UIButton()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
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
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório Compras - CMP000000010"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(9, 463)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 4
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboUnidadeMedidaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblUnidadeMedidaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarFormatoAgulhaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarCorFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarMarcaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarEspecialidadeFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarBitolaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarTamanhoAgulhaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarDiametroFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarMaterialFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCorFiltro)
        Me.grpFiltro.Controls.Add(Me.cboCorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblMarcaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboMarcaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblEspecialidadeFiltro)
        Me.grpFiltro.Controls.Add(Me.cboEspecialidadeFiltro)
        Me.grpFiltro.Controls.Add(Me.lblBitolaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboBitolaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFormatoAgulhaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboFormatoAgulhaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTamanhoAgulhaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTamanhoAgulhaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDiametroFiltro)
        Me.grpFiltro.Controls.Add(Me.cboDiametroFiltro)
        Me.grpFiltro.Controls.Add(Me.lblMaterialFiltro)
        Me.grpFiltro.Controls.Add(Me.cboMaterialFiltro)
        Me.grpFiltro.Controls.Add(Me.lblConsiderarPedidoVendaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboConsiderarPedidoVendaFiltro)
        Me.grpFiltro.Controls.Add(Me.txtEstoqueMinimoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.btnCadastrarRevisao)
        Me.grpFiltro.Controls.Add(Me.lblRevisaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboRevisaoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.cboGrupoItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblEstoqueMinimoFiltro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 147)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboUnidadeMedidaFiltro
        '
        Me.cboUnidadeMedidaFiltro.AutoSize = False
        Me.cboUnidadeMedidaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedidaFiltro.Location = New System.Drawing.Point(730, 117)
        Me.cboUnidadeMedidaFiltro.Name = "cboUnidadeMedidaFiltro"
        Me.cboUnidadeMedidaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedidaFiltro.Size = New System.Drawing.Size(125, 20)
        Me.cboUnidadeMedidaFiltro.TabIndex = 35
        '
        'lblUnidadeMedidaFiltro
        '
        Me.lblUnidadeMedidaFiltro.AutoSize = True
        Me.lblUnidadeMedidaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUnidadeMedidaFiltro.Location = New System.Drawing.Point(727, 100)
        Me.lblUnidadeMedidaFiltro.Name = "lblUnidadeMedidaFiltro"
        Me.lblUnidadeMedidaFiltro.Size = New System.Drawing.Size(125, 14)
        Me.lblUnidadeMedidaFiltro.TabIndex = 34
        Me.lblUnidadeMedidaFiltro.Text = "Und. Medida Referência:"
        '
        'btnProcurarFormatoAgulhaFiltro
        '
        Me.btnProcurarFormatoAgulhaFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarFormatoAgulhaFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarFormatoAgulhaFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarFormatoAgulhaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarFormatoAgulhaFiltro.Location = New System.Drawing.Point(576, 59)
        Me.btnProcurarFormatoAgulhaFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarFormatoAgulhaFiltro.Name = "btnProcurarFormatoAgulhaFiltro"
        Me.btnProcurarFormatoAgulhaFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarFormatoAgulhaFiltro.TabIndex = 36
        Me.btnProcurarFormatoAgulhaFiltro.TabStop = False
        Me.btnProcurarFormatoAgulhaFiltro.Tag = "tb_cad_formato_agulha|4038"
        Me.btnProcurarFormatoAgulhaFiltro.UseVisualStyleBackColor = True
        '
        'btnProcurarCorFiltro
        '
        Me.btnProcurarCorFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarCorFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCorFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCorFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCorFiltro.Location = New System.Drawing.Point(838, 59)
        Me.btnProcurarCorFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCorFiltro.Name = "btnProcurarCorFiltro"
        Me.btnProcurarCorFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCorFiltro.TabIndex = 35
        Me.btnProcurarCorFiltro.TabStop = False
        Me.btnProcurarCorFiltro.Tag = "tb_cad_cor_fio|4041"
        Me.btnProcurarCorFiltro.UseVisualStyleBackColor = True
        '
        'btnProcurarMarcaFiltro
        '
        Me.btnProcurarMarcaFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarMarcaFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarMarcaFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarMarcaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarMarcaFiltro.Location = New System.Drawing.Point(707, 98)
        Me.btnProcurarMarcaFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarMarcaFiltro.Name = "btnProcurarMarcaFiltro"
        Me.btnProcurarMarcaFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarMarcaFiltro.TabIndex = 33
        Me.btnProcurarMarcaFiltro.TabStop = False
        Me.btnProcurarMarcaFiltro.Tag = "tb_cad_item_marca|199"
        Me.btnProcurarMarcaFiltro.UseVisualStyleBackColor = True
        '
        'btnProcurarEspecialidadeFiltro
        '
        Me.btnProcurarEspecialidadeFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarEspecialidadeFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarEspecialidadeFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarEspecialidadeFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarEspecialidadeFiltro.Location = New System.Drawing.Point(314, 98)
        Me.btnProcurarEspecialidadeFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarEspecialidadeFiltro.Name = "btnProcurarEspecialidadeFiltro"
        Me.btnProcurarEspecialidadeFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarEspecialidadeFiltro.TabIndex = 30
        Me.btnProcurarEspecialidadeFiltro.TabStop = False
        Me.btnProcurarEspecialidadeFiltro.Tag = "tb_cad_especialidade|4035"
        Me.btnProcurarEspecialidadeFiltro.UseVisualStyleBackColor = True
        '
        'btnProcurarBitolaFiltro
        '
        Me.btnProcurarBitolaFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarBitolaFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarBitolaFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarBitolaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarBitolaFiltro.Location = New System.Drawing.Point(707, 59)
        Me.btnProcurarBitolaFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarBitolaFiltro.Name = "btnProcurarBitolaFiltro"
        Me.btnProcurarBitolaFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarBitolaFiltro.TabIndex = 24
        Me.btnProcurarBitolaFiltro.TabStop = False
        Me.btnProcurarBitolaFiltro.Tag = "tb_cad_bitola|4037"
        Me.btnProcurarBitolaFiltro.UseVisualStyleBackColor = True
        '
        'btnProcurarTamanhoAgulhaFiltro
        '
        Me.btnProcurarTamanhoAgulhaFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarTamanhoAgulhaFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarTamanhoAgulhaFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarTamanhoAgulhaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarTamanhoAgulhaFiltro.Location = New System.Drawing.Point(445, 59)
        Me.btnProcurarTamanhoAgulhaFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarTamanhoAgulhaFiltro.Name = "btnProcurarTamanhoAgulhaFiltro"
        Me.btnProcurarTamanhoAgulhaFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarTamanhoAgulhaFiltro.TabIndex = 20
        Me.btnProcurarTamanhoAgulhaFiltro.TabStop = False
        Me.btnProcurarTamanhoAgulhaFiltro.Tag = "tb_cad_tamanho_agulha|4036"
        Me.btnProcurarTamanhoAgulhaFiltro.UseVisualStyleBackColor = True
        '
        'btnProcurarDiametroFiltro
        '
        Me.btnProcurarDiametroFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarDiametroFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarDiametroFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarDiametroFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarDiametroFiltro.Location = New System.Drawing.Point(314, 59)
        Me.btnProcurarDiametroFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarDiametroFiltro.Name = "btnProcurarDiametroFiltro"
        Me.btnProcurarDiametroFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarDiametroFiltro.TabIndex = 18
        Me.btnProcurarDiametroFiltro.TabStop = False
        Me.btnProcurarDiametroFiltro.Tag = "tb_cad_diametro_fio|4039"
        Me.btnProcurarDiametroFiltro.UseVisualStyleBackColor = True
        '
        'btnProcurarMaterialFiltro
        '
        Me.btnProcurarMaterialFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarMaterialFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarMaterialFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarMaterialFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarMaterialFiltro.Location = New System.Drawing.Point(183, 59)
        Me.btnProcurarMaterialFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarMaterialFiltro.Name = "btnProcurarMaterialFiltro"
        Me.btnProcurarMaterialFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarMaterialFiltro.TabIndex = 13
        Me.btnProcurarMaterialFiltro.TabStop = False
        Me.btnProcurarMaterialFiltro.Tag = "tb_cad_material|4018"
        Me.btnProcurarMaterialFiltro.UseVisualStyleBackColor = True
        '
        'lblCorFiltro
        '
        Me.lblCorFiltro.AutoSize = True
        Me.lblCorFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCorFiltro.Location = New System.Drawing.Point(727, 60)
        Me.lblCorFiltro.Name = "lblCorFiltro"
        Me.lblCorFiltro.Size = New System.Drawing.Size(27, 14)
        Me.lblCorFiltro.TabIndex = 26
        Me.lblCorFiltro.Text = "Cor:"
        '
        'cboCorFiltro
        '
        Me.cboCorFiltro.AutoSize = False
        Me.cboCorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCorFiltro.Location = New System.Drawing.Point(730, 77)
        Me.cboCorFiltro.Name = "cboCorFiltro"
        Me.cboCorFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCorFiltro.Size = New System.Drawing.Size(125, 20)
        Me.cboCorFiltro.TabIndex = 27
        '
        'lblMarcaFiltro
        '
        Me.lblMarcaFiltro.AutoSize = True
        Me.lblMarcaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarcaFiltro.Location = New System.Drawing.Point(334, 100)
        Me.lblMarcaFiltro.Name = "lblMarcaFiltro"
        Me.lblMarcaFiltro.Size = New System.Drawing.Size(40, 14)
        Me.lblMarcaFiltro.TabIndex = 31
        Me.lblMarcaFiltro.Text = "Marca:"
        '
        'cboMarcaFiltro
        '
        Me.cboMarcaFiltro.AutoSize = False
        Me.cboMarcaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMarcaFiltro.Location = New System.Drawing.Point(337, 117)
        Me.cboMarcaFiltro.Name = "cboMarcaFiltro"
        Me.cboMarcaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMarcaFiltro.Size = New System.Drawing.Size(387, 20)
        Me.cboMarcaFiltro.TabIndex = 32
        '
        'lblEspecialidadeFiltro
        '
        Me.lblEspecialidadeFiltro.AutoSize = True
        Me.lblEspecialidadeFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEspecialidadeFiltro.Location = New System.Drawing.Point(5, 100)
        Me.lblEspecialidadeFiltro.Name = "lblEspecialidadeFiltro"
        Me.lblEspecialidadeFiltro.Size = New System.Drawing.Size(76, 14)
        Me.lblEspecialidadeFiltro.TabIndex = 28
        Me.lblEspecialidadeFiltro.Text = "Especialidade:"
        '
        'cboEspecialidadeFiltro
        '
        Me.cboEspecialidadeFiltro.AutoSize = False
        Me.cboEspecialidadeFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEspecialidadeFiltro.Location = New System.Drawing.Point(8, 117)
        Me.cboEspecialidadeFiltro.Name = "cboEspecialidadeFiltro"
        Me.cboEspecialidadeFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboEspecialidadeFiltro.Size = New System.Drawing.Size(323, 20)
        Me.cboEspecialidadeFiltro.TabIndex = 29
        '
        'lblBitolaFiltro
        '
        Me.lblBitolaFiltro.AutoSize = True
        Me.lblBitolaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBitolaFiltro.Location = New System.Drawing.Point(596, 60)
        Me.lblBitolaFiltro.Name = "lblBitolaFiltro"
        Me.lblBitolaFiltro.Size = New System.Drawing.Size(36, 14)
        Me.lblBitolaFiltro.TabIndex = 23
        Me.lblBitolaFiltro.Text = "Bitola:"
        '
        'cboBitolaFiltro
        '
        Me.cboBitolaFiltro.AutoSize = False
        Me.cboBitolaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboBitolaFiltro.Location = New System.Drawing.Point(599, 77)
        Me.cboBitolaFiltro.Name = "cboBitolaFiltro"
        Me.cboBitolaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboBitolaFiltro.Size = New System.Drawing.Size(125, 20)
        Me.cboBitolaFiltro.TabIndex = 25
        Me.cboBitolaFiltro.Tag = ""
        '
        'lblFormatoAgulhaFiltro
        '
        Me.lblFormatoAgulhaFiltro.AutoSize = True
        Me.lblFormatoAgulhaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFormatoAgulhaFiltro.Location = New System.Drawing.Point(465, 60)
        Me.lblFormatoAgulhaFiltro.Name = "lblFormatoAgulhaFiltro"
        Me.lblFormatoAgulhaFiltro.Size = New System.Drawing.Size(100, 14)
        Me.lblFormatoAgulhaFiltro.TabIndex = 21
        Me.lblFormatoAgulhaFiltro.Text = "Formato da Agulha:"
        '
        'cboFormatoAgulhaFiltro
        '
        Me.cboFormatoAgulhaFiltro.AutoSize = False
        Me.cboFormatoAgulhaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFormatoAgulhaFiltro.Location = New System.Drawing.Point(468, 77)
        Me.cboFormatoAgulhaFiltro.Name = "cboFormatoAgulhaFiltro"
        Me.cboFormatoAgulhaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFormatoAgulhaFiltro.Size = New System.Drawing.Size(125, 20)
        Me.cboFormatoAgulhaFiltro.TabIndex = 22
        '
        'lblTamanhoAgulhaFiltro
        '
        Me.lblTamanhoAgulhaFiltro.AutoSize = True
        Me.lblTamanhoAgulhaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTamanhoAgulhaFiltro.Location = New System.Drawing.Point(334, 60)
        Me.lblTamanhoAgulhaFiltro.Name = "lblTamanhoAgulhaFiltro"
        Me.lblTamanhoAgulhaFiltro.Size = New System.Drawing.Size(89, 14)
        Me.lblTamanhoAgulhaFiltro.TabIndex = 18
        Me.lblTamanhoAgulhaFiltro.Text = "Tamanho Agulha:"
        '
        'cboTamanhoAgulhaFiltro
        '
        Me.cboTamanhoAgulhaFiltro.AutoSize = False
        Me.cboTamanhoAgulhaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTamanhoAgulhaFiltro.Location = New System.Drawing.Point(337, 77)
        Me.cboTamanhoAgulhaFiltro.Name = "cboTamanhoAgulhaFiltro"
        Me.cboTamanhoAgulhaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTamanhoAgulhaFiltro.Size = New System.Drawing.Size(125, 20)
        Me.cboTamanhoAgulhaFiltro.TabIndex = 19
        '
        'lblDiametroFiltro
        '
        Me.lblDiametroFiltro.AutoSize = True
        Me.lblDiametroFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDiametroFiltro.Location = New System.Drawing.Point(203, 60)
        Me.lblDiametroFiltro.Name = "lblDiametroFiltro"
        Me.lblDiametroFiltro.Size = New System.Drawing.Size(52, 14)
        Me.lblDiametroFiltro.TabIndex = 15
        Me.lblDiametroFiltro.Text = "Diâmetro:"
        '
        'cboDiametroFiltro
        '
        Me.cboDiametroFiltro.AutoSize = False
        Me.cboDiametroFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDiametroFiltro.Location = New System.Drawing.Point(206, 77)
        Me.cboDiametroFiltro.Name = "cboDiametroFiltro"
        Me.cboDiametroFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDiametroFiltro.Size = New System.Drawing.Size(125, 20)
        Me.cboDiametroFiltro.TabIndex = 17
        '
        'lblMaterialFiltro
        '
        Me.lblMaterialFiltro.AutoSize = True
        Me.lblMaterialFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaterialFiltro.Location = New System.Drawing.Point(5, 60)
        Me.lblMaterialFiltro.Name = "lblMaterialFiltro"
        Me.lblMaterialFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblMaterialFiltro.TabIndex = 12
        Me.lblMaterialFiltro.Text = "Material:"
        '
        'cboMaterialFiltro
        '
        Me.cboMaterialFiltro.AutoSize = False
        Me.cboMaterialFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMaterialFiltro.Location = New System.Drawing.Point(8, 77)
        Me.cboMaterialFiltro.Name = "cboMaterialFiltro"
        Me.cboMaterialFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMaterialFiltro.Size = New System.Drawing.Size(192, 20)
        Me.cboMaterialFiltro.TabIndex = 14
        '
        'lblConsiderarPedidoVendaFiltro
        '
        Me.lblConsiderarPedidoVendaFiltro.AutoSize = True
        Me.lblConsiderarPedidoVendaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConsiderarPedidoVendaFiltro.Location = New System.Drawing.Point(203, 20)
        Me.lblConsiderarPedidoVendaFiltro.Name = "lblConsiderarPedidoVendaFiltro"
        Me.lblConsiderarPedidoVendaFiltro.Size = New System.Drawing.Size(84, 14)
        Me.lblConsiderarPedidoVendaFiltro.TabIndex = 5
        Me.lblConsiderarPedidoVendaFiltro.Text = "Considerar P.V.:"
        '
        'cboConsiderarPedidoVendaFiltro
        '
        Me.cboConsiderarPedidoVendaFiltro.Location = New System.Drawing.Point(206, 37)
        Me.cboConsiderarPedidoVendaFiltro.Name = "cboConsiderarPedidoVendaFiltro"
        Me.cboConsiderarPedidoVendaFiltro.Size = New System.Drawing.Size(125, 20)
        Me.cboConsiderarPedidoVendaFiltro.TabIndex = 6
        '
        'txtEstoqueMinimoFiltro
        '
        Me.txtEstoqueMinimoFiltro.DecimalDigits = 2
        Me.txtEstoqueMinimoFiltro.Location = New System.Drawing.Point(100, 37)
        Me.txtEstoqueMinimoFiltro.Name = "txtEstoqueMinimoFiltro"
        Me.txtEstoqueMinimoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtEstoqueMinimoFiltro.TabIndex = 4
        Me.txtEstoqueMinimoFiltro.Text = "0,00"
        Me.txtEstoqueMinimoFiltro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 114)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 36
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCadastrarRevisao
        '
        Me.btnCadastrarRevisao.FlatAppearance.BorderSize = 0
        Me.btnCadastrarRevisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarRevisao.Image = CType(resources.GetObject("btnCadastrarRevisao.Image"), System.Drawing.Image)
        Me.btnCadastrarRevisao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarRevisao.Location = New System.Drawing.Point(8, 21)
        Me.btnCadastrarRevisao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarRevisao.Name = "btnCadastrarRevisao"
        Me.btnCadastrarRevisao.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarRevisao.TabIndex = 0
        Me.btnCadastrarRevisao.TabStop = False
        Me.btnCadastrarRevisao.UseVisualStyleBackColor = True
        '
        'lblRevisaoFiltro
        '
        Me.lblRevisaoFiltro.AutoSize = True
        Me.lblRevisaoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRevisaoFiltro.Location = New System.Drawing.Point(24, 20)
        Me.lblRevisaoFiltro.Name = "lblRevisaoFiltro"
        Me.lblRevisaoFiltro.Size = New System.Drawing.Size(49, 14)
        Me.lblRevisaoFiltro.TabIndex = 1
        Me.lblRevisaoFiltro.Text = "Revisão:"
        '
        'cboRevisaoFiltro
        '
        Me.cboRevisaoFiltro.AutoSize = False
        Me.cboRevisaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboRevisaoFiltro.Location = New System.Drawing.Point(8, 37)
        Me.cboRevisaoFiltro.Name = "cboRevisaoFiltro"
        Me.cboRevisaoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboRevisaoFiltro.Size = New System.Drawing.Size(86, 20)
        Me.cboRevisaoFiltro.TabIndex = 2
        '
        'btnProcurarProdutoFiltro
        '
        Me.btnProcurarProdutoFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarProdutoFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProdutoFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProdutoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProdutoFiltro.Location = New System.Drawing.Point(576, 19)
        Me.btnProcurarProdutoFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProdutoFiltro.Name = "btnProcurarProdutoFiltro"
        Me.btnProcurarProdutoFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProdutoFiltro.TabIndex = 8
        Me.btnProcurarProdutoFiltro.TabStop = False
        Me.btnProcurarProdutoFiltro.UseVisualStyleBackColor = True
        '
        'txtProdutoFiltro
        '
        Me.txtProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoFiltro.Location = New System.Drawing.Point(337, 37)
        Me.txtProdutoFiltro.MaxLength = 120
        Me.txtProdutoFiltro.Name = "txtProdutoFiltro"
        Me.txtProdutoFiltro.Size = New System.Drawing.Size(256, 20)
        Me.txtProdutoFiltro.TabIndex = 9
        '
        'lblProdutoFiltro
        '
        Me.lblProdutoFiltro.AutoSize = True
        Me.lblProdutoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblProdutoFiltro.Location = New System.Drawing.Point(334, 20)
        Me.lblProdutoFiltro.Name = "lblProdutoFiltro"
        Me.lblProdutoFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblProdutoFiltro.TabIndex = 7
        Me.lblProdutoFiltro.Text = "Produto:"
        '
        'lblGrupoItemFiltro
        '
        Me.lblGrupoItemFiltro.AutoSize = True
        Me.lblGrupoItemFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGrupoItemFiltro.Location = New System.Drawing.Point(596, 20)
        Me.lblGrupoItemFiltro.Name = "lblGrupoItemFiltro"
        Me.lblGrupoItemFiltro.Size = New System.Drawing.Size(69, 14)
        Me.lblGrupoItemFiltro.TabIndex = 10
        Me.lblGrupoItemFiltro.Text = "Grupo - Item:"
        '
        'cboGrupoItemFiltro
        '
        Me.cboGrupoItemFiltro.AutoSize = False
        Me.cboGrupoItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoItemFiltro.Location = New System.Drawing.Point(599, 37)
        Me.cboGrupoItemFiltro.Name = "cboGrupoItemFiltro"
        Me.cboGrupoItemFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItemFiltro.Size = New System.Drawing.Size(256, 20)
        Me.cboGrupoItemFiltro.TabIndex = 11
        '
        'lblEstoqueMinimoFiltro
        '
        Me.lblEstoqueMinimoFiltro.AutoSize = True
        Me.lblEstoqueMinimoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEstoqueMinimoFiltro.Location = New System.Drawing.Point(97, 20)
        Me.lblEstoqueMinimoFiltro.Name = "lblEstoqueMinimoFiltro"
        Me.lblEstoqueMinimoFiltro.Size = New System.Drawing.Size(93, 14)
        Me.lblEstoqueMinimoFiltro.TabIndex = 3
        Me.lblEstoqueMinimoFiltro.Text = "x Estoque Mínimo:"
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 1
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 160)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 320)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnPedidoCompra)
        Me.grpControl.Controls.Add(Me.btnVisualizarImpressao)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(982, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnPedidoCompra
        '
        Me.btnPedidoCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPedidoCompra.Image = Global.INTERACTI.My.Resources.Resources.compras
        Me.btnPedidoCompra.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPedidoCompra.Location = New System.Drawing.Point(726, 17)
        Me.btnPedidoCompra.Name = "btnPedidoCompra"
        Me.btnPedidoCompra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPedidoCompra.Size = New System.Drawing.Size(150, 23)
        Me.btnPedidoCompra.TabIndex = 15
        Me.btnPedidoCompra.Text = "Gerar Pedido Compra"
        Me.btnPedidoCompra.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVisualizarImpressao
        '
        Me.btnVisualizarImpressao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarImpressao.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnVisualizarImpressao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarImpressao.Location = New System.Drawing.Point(570, 17)
        Me.btnVisualizarImpressao.Name = "btnVisualizarImpressao"
        Me.btnVisualizarImpressao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarImpressao.Size = New System.Drawing.Size(150, 23)
        Me.btnVisualizarImpressao.TabIndex = 0
        Me.btnVisualizarImpressao.Text = "Visualizar Impressão"
        Me.btnVisualizarImpressao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrCmp000000010
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCmp000000010"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
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
    Friend WithEvents btnVisualizarImpressao As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtEstoqueMinimoFiltro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblEstoqueMinimoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblConsiderarPedidoVendaFiltro As System.Windows.Forms.Label
    Friend WithEvents cboConsiderarPedidoVendaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnProcurarMarcaFiltro As System.Windows.Forms.Button
    Friend WithEvents btnProcurarEspecialidadeFiltro As System.Windows.Forms.Button
    Friend WithEvents btnProcurarBitolaFiltro As System.Windows.Forms.Button
    Friend WithEvents btnProcurarTamanhoAgulhaFiltro As System.Windows.Forms.Button
    Friend WithEvents btnProcurarDiametroFiltro As System.Windows.Forms.Button
    Friend WithEvents btnProcurarMaterialFiltro As System.Windows.Forms.Button
    Friend WithEvents lblCorFiltro As System.Windows.Forms.Label
    Friend WithEvents cboCorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMarcaFiltro As System.Windows.Forms.Label
    Friend WithEvents cboMarcaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblEspecialidadeFiltro As System.Windows.Forms.Label
    Friend WithEvents cboEspecialidadeFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblBitolaFiltro As System.Windows.Forms.Label
    Friend WithEvents cboBitolaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFormatoAgulhaFiltro As System.Windows.Forms.Label
    Friend WithEvents cboFormatoAgulhaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTamanhoAgulhaFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTamanhoAgulhaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDiametroFiltro As System.Windows.Forms.Label
    Friend WithEvents cboDiametroFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMaterialFiltro As System.Windows.Forms.Label
    Friend WithEvents cboMaterialFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarRevisao As System.Windows.Forms.Button
    Friend WithEvents lblRevisaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboRevisaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnProcurarProdutoFiltro As System.Windows.Forms.Button
    Friend WithEvents txtProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblGrupoItemFiltro As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItemFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnProcurarCorFiltro As System.Windows.Forms.Button
    Friend WithEvents btnProcurarFormatoAgulhaFiltro As System.Windows.Forms.Button
    Friend WithEvents cboUnidadeMedidaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUnidadeMedidaFiltro As System.Windows.Forms.Label
    Friend WithEvents btnPedidoCompra As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button

End Class
