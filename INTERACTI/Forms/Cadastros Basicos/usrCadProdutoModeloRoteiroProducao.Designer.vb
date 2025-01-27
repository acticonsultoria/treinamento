<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadProdutoModeloRoteiroProducao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadProdutoModeloRoteiroProducao))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpModelo = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboPadrao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPadrao = New System.Windows.Forms.Label()
        Me.lblQuantidadeAmostra = New System.Windows.Forms.Label()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.txtQuantidadeAmostra = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnCadastrarMaquina = New System.Windows.Forms.Button()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.lblMaquina = New System.Windows.Forms.Label()
        Me.cboMaquina = New Janus.Windows.EditControls.UIComboBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.txtModelo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.btnCadastrarProduto = New System.Windows.Forms.Button()
        Me.cboProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.txtDescricaoProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoProduto = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpModelo.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
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
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnExcelGrid)
        Me.pagDados.Controls.Add(Me.btnAgruparGrid)
        Me.pagDados.Controls.Add(Me.btnConfigurarGrid)
        Me.pagDados.Controls.Add(Me.grdListagem)
        Me.pagDados.Controls.Add(Me.grpModelo)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grpControle)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Modelo de Roteiro - Produção"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 373)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 7
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 373)
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
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 373)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 3
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
        Me.grdListagem.ColumnAutoResize = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Location = New System.Drawing.Point(8, 183)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 207)
        Me.grdListagem.TabIndex = 2
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpModelo
        '
        Me.grpModelo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpModelo.BackColor = System.Drawing.Color.Transparent
        Me.grpModelo.Controls.Add(Me.cboPadrao)
        Me.grpModelo.Controls.Add(Me.lblPadrao)
        Me.grpModelo.Controls.Add(Me.lblQuantidadeAmostra)
        Me.grpModelo.Controls.Add(Me.btnExcluir)
        Me.grpModelo.Controls.Add(Me.txtQuantidadeAmostra)
        Me.grpModelo.Controls.Add(Me.btnCadastrarMaquina)
        Me.grpModelo.Controls.Add(Me.btnInserir)
        Me.grpModelo.Controls.Add(Me.lblMaquina)
        Me.grpModelo.Controls.Add(Me.cboMaquina)
        Me.grpModelo.Controls.Add(Me.lblModelo)
        Me.grpModelo.Controls.Add(Me.txtModelo)
        Me.grpModelo.Controls.Add(Me.txtDescricao)
        Me.grpModelo.Controls.Add(Me.lblDescricao)
        Me.grpModelo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpModelo.Location = New System.Drawing.Point(8, 70)
        Me.grpModelo.Name = "grpModelo"
        Me.grpModelo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpModelo.Size = New System.Drawing.Size(897, 104)
        Me.grpModelo.TabIndex = 1
        Me.grpModelo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpModelo.VisualStyleManager = Me.vsmMain
        '
        'cboPadrao
        '
        Me.cboPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPadrao.Location = New System.Drawing.Point(586, 74)
        Me.cboPadrao.Name = "cboPadrao"
        Me.cboPadrao.Size = New System.Drawing.Size(94, 20)
        Me.cboPadrao.TabIndex = 10
        '
        'lblPadrao
        '
        Me.lblPadrao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPadrao.AutoSize = True
        Me.lblPadrao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPadrao.Location = New System.Drawing.Point(583, 57)
        Me.lblPadrao.Name = "lblPadrao"
        Me.lblPadrao.Size = New System.Drawing.Size(44, 14)
        Me.lblPadrao.TabIndex = 9
        Me.lblPadrao.Text = "Padrão:"
        '
        'lblQuantidadeAmostra
        '
        Me.lblQuantidadeAmostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeAmostra.AutoSize = True
        Me.lblQuantidadeAmostra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeAmostra.Location = New System.Drawing.Point(583, 17)
        Me.lblQuantidadeAmostra.Name = "lblQuantidadeAmostra"
        Me.lblQuantidadeAmostra.Size = New System.Drawing.Size(79, 14)
        Me.lblQuantidadeAmostra.TabIndex = 4
        Me.lblQuantidadeAmostra.Text = "Qtde. Amostra:"
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(797, 71)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 12
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtQuantidadeAmostra
        '
        Me.txtQuantidadeAmostra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeAmostra.DecimalDigits = 4
        Me.txtQuantidadeAmostra.Location = New System.Drawing.Point(586, 34)
        Me.txtQuantidadeAmostra.MaxLength = 15
        Me.txtQuantidadeAmostra.Name = "txtQuantidadeAmostra"
        Me.txtQuantidadeAmostra.Size = New System.Drawing.Size(94, 20)
        Me.txtQuantidadeAmostra.TabIndex = 5
        Me.txtQuantidadeAmostra.Text = "0,0000"
        Me.txtQuantidadeAmostra.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'btnCadastrarMaquina
        '
        Me.btnCadastrarMaquina.FlatAppearance.BorderSize = 0
        Me.btnCadastrarMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarMaquina.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarMaquina.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarMaquina.Location = New System.Drawing.Point(9, 58)
        Me.btnCadastrarMaquina.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarMaquina.Name = "btnCadastrarMaquina"
        Me.btnCadastrarMaquina.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarMaquina.TabIndex = 6
        Me.btnCadastrarMaquina.TabStop = False
        Me.btnCadastrarMaquina.UseVisualStyleBackColor = True
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(797, 42)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 11
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblMaquina
        '
        Me.lblMaquina.AutoSize = True
        Me.lblMaquina.Location = New System.Drawing.Point(25, 57)
        Me.lblMaquina.Name = "lblMaquina"
        Me.lblMaquina.Size = New System.Drawing.Size(129, 14)
        Me.lblMaquina.TabIndex = 7
        Me.lblMaquina.Text = "Máquina ou Equipamento:"
        '
        'cboMaquina
        '
        Me.cboMaquina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMaquina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMaquina.Location = New System.Drawing.Point(9, 74)
        Me.cboMaquina.Name = "cboMaquina"
        Me.cboMaquina.Size = New System.Drawing.Size(571, 20)
        Me.cboMaquina.TabIndex = 8
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(6, 17)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(44, 14)
        Me.lblModelo.TabIndex = 0
        Me.lblModelo.Text = "Modelo:"
        '
        'txtModelo
        '
        Me.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModelo.Location = New System.Drawing.Point(9, 34)
        Me.txtModelo.MaxLength = 20
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(204, 20)
        Me.txtModelo.TabIndex = 1
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(219, 34)
        Me.txtDescricao.MaxLength = 100
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(361, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(216, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição:"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.btnProcurarProduto)
        Me.grpDados.Controls.Add(Me.btnCadastrarProduto)
        Me.grpDados.Controls.Add(Me.cboProduto)
        Me.grpDados.Controls.Add(Me.lblProduto)
        Me.grpDados.Controls.Add(Me.txtDescricaoProduto)
        Me.grpDados.Controls.Add(Me.lblDescricaoProduto)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 64)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProduto.Image = Global.INTERACTI.My.Resources.search
        Me.btnProcurarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProduto.Location = New System.Drawing.Point(196, 16)
        Me.btnProcurarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProduto.TabIndex = 2
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'btnCadastrarProduto
        '
        Me.btnCadastrarProduto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarProduto.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarProduto.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarProduto.Name = "btnCadastrarProduto"
        Me.btnCadastrarProduto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarProduto.TabIndex = 0
        Me.btnCadastrarProduto.TabStop = False
        Me.btnCadastrarProduto.UseVisualStyleBackColor = True
        '
        'cboProduto
        '
        Me.cboProduto.Location = New System.Drawing.Point(9, 34)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Size = New System.Drawing.Size(204, 20)
        Me.cboProduto.TabIndex = 3
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblProduto.Location = New System.Drawing.Point(25, 17)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(83, 14)
        Me.lblProduto.TabIndex = 1
        Me.lblProduto.Text = "Código Produto:"
        '
        'txtDescricaoProduto
        '
        Me.txtDescricaoProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoProduto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDescricaoProduto.Location = New System.Drawing.Point(219, 34)
        Me.txtDescricaoProduto.MaxLength = 120
        Me.txtDescricaoProduto.Name = "txtDescricaoProduto"
        Me.txtDescricaoProduto.ReadOnly = True
        Me.txtDescricaoProduto.Size = New System.Drawing.Size(669, 20)
        Me.txtDescricaoProduto.TabIndex = 5
        Me.txtDescricaoProduto.TabStop = False
        '
        'lblDescricaoProduto
        '
        Me.lblDescricaoProduto.AutoSize = True
        Me.lblDescricaoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricaoProduto.Location = New System.Drawing.Point(216, 17)
        Me.lblDescricaoProduto.Name = "lblDescricaoProduto"
        Me.lblDescricaoProduto.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoProduto.TabIndex = 4
        Me.lblDescricaoProduto.Text = "Descrição:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnNovo)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 393)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(897, 51)
        Me.grpControle.TabIndex = 5
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(700, 17)
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
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
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
        'usrCadProdutoModeloRoteiroProducao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadProdutoModeloRoteiroProducao"
        Me.Size = New System.Drawing.Size(915, 476)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpModelo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpModelo.ResumeLayout(False)
        Me.grpModelo.PerformLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpModelo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarMaquina As System.Windows.Forms.Button
    Friend WithEvents lblMaquina As System.Windows.Forms.Label
    Friend WithEvents cboMaquina As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents txtModelo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarProduto As System.Windows.Forms.Button
    Friend WithEvents cboProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoProduto As System.Windows.Forms.Label
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblQuantidadeAmostra As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeAmostra As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents cboPadrao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblPadrao As System.Windows.Forms.Label

End Class
