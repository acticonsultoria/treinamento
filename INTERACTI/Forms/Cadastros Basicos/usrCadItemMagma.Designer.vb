<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadItemMagma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadItemMagma))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtTabelaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTabelaFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.txtCategoriaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCategoriaFiltro = New System.Windows.Forms.Label()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.txtProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProdutoFiltro = New System.Windows.Forms.Label()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grdControles = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnImportarItensExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControlesEdicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.grpDadosProtocolo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtPrecoConsumidor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPrecoConsumidor = New System.Windows.Forms.Label()
        Me.txtPrecoConsultor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPrecoConsultor = New System.Windows.Forms.Label()
        Me.txtCategoria = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.txtProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtTabela = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTabela = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdControles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdControles.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpControlesEdicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControlesEdicao.SuspendLayout()
        CType(Me.grpDadosProtocolo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosProtocolo.SuspendLayout()
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
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(839, 411)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grdControles)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(837, 388)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Item - Magma "
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(58, 300)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 4
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(34, 300)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 3
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtTabelaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTabelaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.txtCategoriaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCategoriaFiltro)
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblProdutoFiltro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(826, 63)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtTabelaFiltro
        '
        Me.txtTabelaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTabelaFiltro.Location = New System.Drawing.Point(553, 34)
        Me.txtTabelaFiltro.MaxLength = 20
        Me.txtTabelaFiltro.Name = "txtTabelaFiltro"
        Me.txtTabelaFiltro.Size = New System.Drawing.Size(80, 20)
        Me.txtTabelaFiltro.TabIndex = 17
        '
        'lblTabelaFiltro
        '
        Me.lblTabelaFiltro.AutoSize = True
        Me.lblTabelaFiltro.Location = New System.Drawing.Point(550, 17)
        Me.lblTabelaFiltro.Name = "lblTabelaFiltro"
        Me.lblTabelaFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblTabelaFiltro.TabIndex = 16
        Me.lblTabelaFiltro.Text = "Tabela:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnFiltrar.Location = New System.Drawing.Point(725, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 0
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtCategoriaFiltro
        '
        Me.txtCategoriaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCategoriaFiltro.Location = New System.Drawing.Point(639, 34)
        Me.txtCategoriaFiltro.MaxLength = 20
        Me.txtCategoriaFiltro.Name = "txtCategoriaFiltro"
        Me.txtCategoriaFiltro.Size = New System.Drawing.Size(80, 20)
        Me.txtCategoriaFiltro.TabIndex = 13
        '
        'lblCategoriaFiltro
        '
        Me.lblCategoriaFiltro.AutoSize = True
        Me.lblCategoriaFiltro.Location = New System.Drawing.Point(636, 17)
        Me.lblCategoriaFiltro.Name = "lblCategoriaFiltro"
        Me.lblCategoriaFiltro.Size = New System.Drawing.Size(56, 14)
        Me.lblCategoriaFiltro.TabIndex = 14
        Me.lblCategoriaFiltro.Text = "Categoria:"
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(115, 34)
        Me.txtDescricaoFiltro.MaxLength = 20
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(432, 20)
        Me.txtDescricaoFiltro.TabIndex = 6
        '
        'lblDescricaoFiltro
        '
        Me.lblDescricaoFiltro.AutoSize = True
        Me.lblDescricaoFiltro.Location = New System.Drawing.Point(112, 17)
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        Me.lblDescricaoFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoFiltro.TabIndex = 5
        Me.lblDescricaoFiltro.Text = "Descrição:"
        '
        'txtProdutoFiltro
        '
        Me.txtProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtProdutoFiltro.MaxLength = 20
        Me.txtProdutoFiltro.Name = "txtProdutoFiltro"
        Me.txtProdutoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtProdutoFiltro.TabIndex = 1
        '
        'lblProdutoFiltro
        '
        Me.lblProdutoFiltro.AutoSize = True
        Me.lblProdutoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblProdutoFiltro.Name = "lblProdutoFiltro"
        Me.lblProdutoFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblProdutoFiltro.TabIndex = 0
        Me.lblProdutoFiltro.Text = "Produto:"
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(10, 300)
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
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Location = New System.Drawing.Point(8, 72)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(826, 244)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grdControles
        '
        Me.grdControles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdControles.BackColor = System.Drawing.Color.Transparent
        Me.grdControles.Controls.Add(Me.btnExcluir)
        Me.grdControles.Controls.Add(Me.btnImportarItensExcel)
        Me.grdControles.Controls.Add(Me.btnSair)
        Me.grdControles.Location = New System.Drawing.Point(8, 322)
        Me.grdControles.Name = "grdControles"
        Me.grdControles.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grdControles.Size = New System.Drawing.Size(826, 63)
        Me.grdControles.TabIndex = 6
        Me.grdControles.VisualStyleManager = Me.vsmMain
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnExcluir.Location = New System.Drawing.Point(628, 22)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImportarItensExcel
        '
        Me.btnImportarItensExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportarItensExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnImportarItensExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarItensExcel.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnImportarItensExcel.Location = New System.Drawing.Point(472, 22)
        Me.btnImportarItensExcel.Name = "btnImportarItensExcel"
        Me.btnImportarItensExcel.Size = New System.Drawing.Size(150, 23)
        Me.btnImportarItensExcel.TabIndex = 2
        Me.btnImportarItensExcel.Text = "Importar Itens *.xls"
        Me.btnImportarItensExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(725, 22)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpControlesEdicao)
        Me.pagDados.Controls.Add(Me.grpDadosProtocolo)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(837, 388)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados Item - Magma "
        '
        'grpControlesEdicao
        '
        Me.grpControlesEdicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControlesEdicao.BackColor = System.Drawing.Color.Transparent
        Me.grpControlesEdicao.Controls.Add(Me.btnSalvar)
        Me.grpControlesEdicao.Controls.Add(Me.btnVoltar)
        Me.grpControlesEdicao.Location = New System.Drawing.Point(8, 334)
        Me.grpControlesEdicao.Name = "grpControlesEdicao"
        Me.grpControlesEdicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControlesEdicao.Size = New System.Drawing.Size(826, 51)
        Me.grpControlesEdicao.TabIndex = 1
        Me.grpControlesEdicao.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.Location = New System.Drawing.Point(629, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnVoltar.Location = New System.Drawing.Point(726, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 1
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDadosProtocolo
        '
        Me.grpDadosProtocolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosProtocolo.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosProtocolo.Controls.Add(Me.txtPrecoConsumidor)
        Me.grpDadosProtocolo.Controls.Add(Me.lblPrecoConsumidor)
        Me.grpDadosProtocolo.Controls.Add(Me.txtPrecoConsultor)
        Me.grpDadosProtocolo.Controls.Add(Me.lblPrecoConsultor)
        Me.grpDadosProtocolo.Controls.Add(Me.txtCategoria)
        Me.grpDadosProtocolo.Controls.Add(Me.lblCategoria)
        Me.grpDadosProtocolo.Controls.Add(Me.lblProduto)
        Me.grpDadosProtocolo.Controls.Add(Me.txtProduto)
        Me.grpDadosProtocolo.Controls.Add(Me.txtDescricao)
        Me.grpDadosProtocolo.Controls.Add(Me.lblDescricao)
        Me.grpDadosProtocolo.Controls.Add(Me.txtTabela)
        Me.grpDadosProtocolo.Controls.Add(Me.lblTabela)
        Me.grpDadosProtocolo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosProtocolo.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosProtocolo.Name = "grpDadosProtocolo"
        Me.grpDadosProtocolo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosProtocolo.Size = New System.Drawing.Size(826, 65)
        Me.grpDadosProtocolo.TabIndex = 0
        Me.grpDadosProtocolo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosProtocolo.VisualStyleManager = Me.vsmMain
        '
        'txtPrecoConsumidor
        '
        Me.txtPrecoConsumidor.DecimalDigits = 2
        Me.txtPrecoConsumidor.Location = New System.Drawing.Point(722, 34)
        Me.txtPrecoConsumidor.MaxLength = 0
        Me.txtPrecoConsumidor.Name = "txtPrecoConsumidor"
        Me.txtPrecoConsumidor.Size = New System.Drawing.Size(95, 20)
        Me.txtPrecoConsumidor.TabIndex = 19
        Me.txtPrecoConsumidor.Text = "0,00"
        Me.txtPrecoConsumidor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPrecoConsumidor
        '
        Me.lblPrecoConsumidor.AutoSize = True
        Me.lblPrecoConsumidor.Location = New System.Drawing.Point(719, 17)
        Me.lblPrecoConsumidor.Name = "lblPrecoConsumidor"
        Me.lblPrecoConsumidor.Size = New System.Drawing.Size(98, 14)
        Me.lblPrecoConsumidor.TabIndex = 18
        Me.lblPrecoConsumidor.Text = "Preço Consumidor:"
        '
        'txtPrecoConsultor
        '
        Me.txtPrecoConsultor.DecimalDigits = 2
        Me.txtPrecoConsultor.Location = New System.Drawing.Point(625, 34)
        Me.txtPrecoConsultor.MaxLength = 0
        Me.txtPrecoConsultor.Name = "txtPrecoConsultor"
        Me.txtPrecoConsultor.Size = New System.Drawing.Size(91, 20)
        Me.txtPrecoConsultor.TabIndex = 17
        Me.txtPrecoConsultor.Text = "0,00"
        Me.txtPrecoConsultor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPrecoConsultor
        '
        Me.lblPrecoConsultor.AutoSize = True
        Me.lblPrecoConsultor.Location = New System.Drawing.Point(622, 17)
        Me.lblPrecoConsultor.Name = "lblPrecoConsultor"
        Me.lblPrecoConsultor.Size = New System.Drawing.Size(87, 14)
        Me.lblPrecoConsultor.TabIndex = 16
        Me.lblPrecoConsultor.Text = "Preço Consultor:"
        '
        'txtCategoria
        '
        Me.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCategoria.Location = New System.Drawing.Point(541, 34)
        Me.txtCategoria.MaxLength = 20
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(78, 20)
        Me.txtCategoria.TabIndex = 13
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(538, 18)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(56, 14)
        Me.lblCategoria.TabIndex = 12
        Me.lblCategoria.Text = "Categoria:"
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(6, 17)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 10
        Me.lblProduto.Text = "Produto:"
        '
        'txtProduto
        '
        Me.txtProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.Enabled = False
        Me.txtProduto.Location = New System.Drawing.Point(9, 34)
        Me.txtProduto.MaxLength = 20
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(100, 20)
        Me.txtProduto.TabIndex = 11
        Me.txtProduto.TabStop = False
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Enabled = False
        Me.txtDescricao.Location = New System.Drawing.Point(115, 34)
        Me.txtDescricao.MaxLength = 20
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(341, 20)
        Me.txtDescricao.TabIndex = 5
        Me.txtDescricao.TabStop = False
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(112, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 4
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtTabela
        '
        Me.txtTabela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTabela.Location = New System.Drawing.Point(462, 34)
        Me.txtTabela.MaxLength = 20
        Me.txtTabela.Name = "txtTabela"
        Me.txtTabela.Size = New System.Drawing.Size(73, 20)
        Me.txtTabela.TabIndex = 9
        '
        'lblTabela
        '
        Me.lblTabela.AutoSize = True
        Me.lblTabela.Location = New System.Drawing.Point(459, 17)
        Me.lblTabela.Name = "lblTabela"
        Me.lblTabela.Size = New System.Drawing.Size(41, 14)
        Me.lblTabela.TabIndex = 8
        Me.lblTabela.Text = "Tabela:"
        '
        'usrCadItemMagma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadItemMagma"
        Me.Size = New System.Drawing.Size(839, 411)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdControles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdControles.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpControlesEdicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControlesEdicao.ResumeLayout(False)
        CType(Me.grpDadosProtocolo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosProtocolo.ResumeLayout(False)
        Me.grpDadosProtocolo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdControles As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents txtProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtCategoriaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCategoriaFiltro As System.Windows.Forms.Label
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents txtCategoria As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents grpDadosProtocolo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents txtProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtTabela As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTabela As System.Windows.Forms.Label
    Friend WithEvents grpControlesEdicao As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnImportarItensExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtTabelaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTabelaFiltro As System.Windows.Forms.Label
    Friend WithEvents txtPrecoConsumidor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPrecoConsumidor As System.Windows.Forms.Label
    Friend WithEvents txtPrecoConsultor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPrecoConsultor As System.Windows.Forms.Label

End Class
