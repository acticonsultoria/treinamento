<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrEstMovimentacaoManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrEstMovimentacaoManual))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpEndereco = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtLote = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnProcurarItem = New System.Windows.Forms.Button()
        Me.btnCadastrarDeposito = New System.Windows.Forms.Button()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.cboDeposito = New Janus.Windows.EditControls.UIComboBox()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.lblCodigoProduto = New System.Windows.Forms.Label()
        Me.cboCodigoProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipoMovimentacao = New System.Windows.Forms.Label()
        Me.cboTipoMovimentacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDataMovimentacao = New System.Windows.Forms.Label()
        Me.dtpDataMovimentacao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtDescritivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.lblDescritivo = New System.Windows.Forms.Label()
        CType(Me.tabMain,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabMain.SuspendLayout
        Me.pagListagem.SuspendLayout
        CType(Me.grpEndereco,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpEndereco.SuspendLayout
        CType(Me.grdListagem,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grpControl,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpControl.SuspendLayout
        CType(Me.grpFiltro,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpFiltro.SuspendLayout
        Me.SuspendLayout
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
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grpEndereco)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpControl)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = true
        Me.pagListagem.Text = "Estoque - Movimentação Manual"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 5
        Me.btnExcelGrid.TabStop = false
        Me.btnExcelGrid.UseVisualStyleBackColor = false
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 4
        Me.btnAgruparGrid.TabStop = false
        Me.btnAgruparGrid.UseVisualStyleBackColor = false
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 3
        Me.btnConfigurarGrid.TabStop = false
        Me.btnConfigurarGrid.UseVisualStyleBackColor = false
        '
        'grpEndereco
        '
        Me.grpEndereco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpEndereco.BackColor = System.Drawing.Color.Transparent
        Me.grpEndereco.Controls.Add(Me.txtLote)
        Me.grpEndereco.Controls.Add(Me.lblDescricao)
        Me.grpEndereco.Controls.Add(Me.txtDescricao)
        Me.grpEndereco.Controls.Add(Me.btnProcurarItem)
        Me.grpEndereco.Controls.Add(Me.btnCadastrarDeposito)
        Me.grpEndereco.Controls.Add(Me.lblQuantidade)
        Me.grpEndereco.Controls.Add(Me.txtQuantidade)
        Me.grpEndereco.Controls.Add(Me.lblDeposito)
        Me.grpEndereco.Controls.Add(Me.cboDeposito)
        Me.grpEndereco.Controls.Add(Me.lblLote)
        Me.grpEndereco.Controls.Add(Me.btnExcluir)
        Me.grpEndereco.Controls.Add(Me.btnInserir)
        Me.grpEndereco.Controls.Add(Me.lblCodigoProduto)
        Me.grpEndereco.Controls.Add(Me.cboCodigoProduto)
        Me.grpEndereco.Location = New System.Drawing.Point(8, 70)
        Me.grpEndereco.Name = "grpEndereco"
        Me.grpEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEndereco.Size = New System.Drawing.Size(897, 104)
        Me.grpEndereco.TabIndex = 1
        Me.grpEndereco.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpEndereco.VisualStyleManager = Me.vsmMain
        '
        'txtLote
        '
        Me.txtLote.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtLote.Location = New System.Drawing.Point(9, 74)
        Me.txtLote.MaxLength = 50
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(120, 20)
        Me.txtLote.TabIndex = 6
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = true
        Me.lblDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricao.Location = New System.Drawing.Point(132, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 3
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(135, 34)
        Me.txtDescricao.MaxLength = 120
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = true
        Me.txtDescricao.Size = New System.Drawing.Size(491, 20)
        Me.txtDescricao.TabIndex = 4
        Me.txtDescricao.TabStop = false
        '
        'btnProcurarItem
        '
        Me.btnProcurarItem.FlatAppearance.BorderSize = 0
        Me.btnProcurarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItem.Image = Global.INTERACTI.My.Resources.search
        Me.btnProcurarItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItem.Location = New System.Drawing.Point(112, 15)
        Me.btnProcurarItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItem.Name = "btnProcurarItem"
        Me.btnProcurarItem.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItem.TabIndex = 2
        Me.btnProcurarItem.TabStop = false
        Me.btnProcurarItem.UseVisualStyleBackColor = true
        '
        'btnCadastrarDeposito
        '
        Me.btnCadastrarDeposito.FlatAppearance.BorderSize = 0
        Me.btnCadastrarDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarDeposito.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarDeposito.Location = New System.Drawing.Point(135, 58)
        Me.btnCadastrarDeposito.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarDeposito.Name = "btnCadastrarDeposito"
        Me.btnCadastrarDeposito.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarDeposito.TabIndex = 7
        Me.btnCadastrarDeposito.TabStop = false
        Me.btnCadastrarDeposito.UseVisualStyleBackColor = true
        '
        'lblQuantidade
        '
        Me.lblQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblQuantidade.AutoSize = true
        Me.lblQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidade.Location = New System.Drawing.Point(523, 57)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 10
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(526, 74)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidade.TabIndex = 11
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblDeposito
        '
        Me.lblDeposito.AutoSize = true
        Me.lblDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDeposito.Location = New System.Drawing.Point(151, 57)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(52, 14)
        Me.lblDeposito.TabIndex = 8
        Me.lblDeposito.Text = "Depósito:"
        '
        'cboDeposito
        '
        Me.cboDeposito.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cboDeposito.AutoSize = false
        Me.cboDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDeposito.Location = New System.Drawing.Point(135, 74)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDeposito.Size = New System.Drawing.Size(385, 20)
        Me.cboDeposito.TabIndex = 9
        '
        'lblLote
        '
        Me.lblLote.AutoSize = true
        Me.lblLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLote.Location = New System.Drawing.Point(6, 57)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(31, 14)
        Me.lblLote.TabIndex = 5
        Me.lblLote.Text = "Lote:"
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(797, 71)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 13
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(700, 71)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 12
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblCodigoProduto
        '
        Me.lblCodigoProduto.AutoSize = true
        Me.lblCodigoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProduto.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        Me.lblCodigoProduto.Size = New System.Drawing.Size(83, 14)
        Me.lblCodigoProduto.TabIndex = 0
        Me.lblCodigoProduto.Text = "Código Produto:"
        '
        'cboCodigoProduto
        '
        Me.cboCodigoProduto.AutoSize = false
        Me.cboCodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCodigoProduto.Location = New System.Drawing.Point(9, 34)
        Me.cboCodigoProduto.Name = "cboCodigoProduto"
        Me.cboCodigoProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigoProduto.Size = New System.Drawing.Size(120, 20)
        Me.cboCodigoProduto.TabIndex = 1
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = true
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grdListagem.CellToolTipText = "Duplo clique para editar o registro"
        Me.grdListagem.ColumnAutoResize = true
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"),Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = false
        Me.grdListagem.Location = New System.Drawing.Point(8, 183)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = true
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 297)
        Me.grdListagem.TabIndex = 2
        Me.grdListagem.TabStop = false
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnNovo)
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 6
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.novo
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
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
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
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"),System.Drawing.Image)
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
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblTipoMovimentacao)
        Me.grpFiltro.Controls.Add(Me.cboTipoMovimentacao)
        Me.grpFiltro.Controls.Add(Me.lblDataMovimentacao)
        Me.grpFiltro.Controls.Add(Me.dtpDataMovimentacao)
        Me.grpFiltro.Controls.Add(Me.txtDescritivo)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDocumento)
        Me.grpFiltro.Controls.Add(Me.lblNumeroDocumento)
        Me.grpFiltro.Controls.Add(Me.lblDescritivo)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblTipoMovimentacao
        '
        Me.lblTipoMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblTipoMovimentacao.AutoSize = true
        Me.lblTipoMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoMovimentacao.Location = New System.Drawing.Point(629, 17)
        Me.lblTipoMovimentacao.Name = "lblTipoMovimentacao"
        Me.lblTipoMovimentacao.Size = New System.Drawing.Size(117, 14)
        Me.lblTipoMovimentacao.TabIndex = 4
        Me.lblTipoMovimentacao.Text = "Tipo de Movimentação:"
        '
        'cboTipoMovimentacao
        '
        Me.cboTipoMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cboTipoMovimentacao.AutoSize = false
        Me.cboTipoMovimentacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoMovimentacao.Location = New System.Drawing.Point(632, 34)
        Me.cboTipoMovimentacao.Name = "cboTipoMovimentacao"
        Me.cboTipoMovimentacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoMovimentacao.Size = New System.Drawing.Size(148, 20)
        Me.cboTipoMovimentacao.TabIndex = 5
        '
        'lblDataMovimentacao
        '
        Me.lblDataMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblDataMovimentacao.AutoSize = true
        Me.lblDataMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataMovimentacao.Location = New System.Drawing.Point(783, 17)
        Me.lblDataMovimentacao.Name = "lblDataMovimentacao"
        Me.lblDataMovimentacao.Size = New System.Drawing.Size(104, 14)
        Me.lblDataMovimentacao.TabIndex = 6
        Me.lblDataMovimentacao.Text = "Data Movimentação:"
        '
        'dtpDataMovimentacao
        '
        Me.dtpDataMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataMovimentacao.DropDownCalendar.Name = ""
        Me.dtpDataMovimentacao.Location = New System.Drawing.Point(786, 34)
        Me.dtpDataMovimentacao.Name = "dtpDataMovimentacao"
        Me.dtpDataMovimentacao.Size = New System.Drawing.Size(102, 20)
        Me.dtpDataMovimentacao.TabIndex = 7
        '
        'txtDescritivo
        '
        Me.txtDescritivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtDescritivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtDescritivo.Location = New System.Drawing.Point(135, 34)
        Me.txtDescritivo.MaxLength = 100
        Me.txtDescritivo.Name = "txtDescritivo"
        Me.txtDescritivo.Size = New System.Drawing.Size(491, 20)
        Me.txtDescritivo.TabIndex = 3
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumento.MaxLength = 20
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(120, 20)
        Me.txtNumeroDocumento.TabIndex = 1
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = true
        Me.lblNumeroDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 0
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'lblDescritivo
        '
        Me.lblDescritivo.AutoSize = true
        Me.lblDescritivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescritivo.Location = New System.Drawing.Point(132, 17)
        Me.lblDescritivo.Name = "lblDescritivo"
        Me.lblDescritivo.Size = New System.Drawing.Size(58, 14)
        Me.lblDescritivo.TabIndex = 2
        Me.lblDescritivo.Text = "Descritivo:"
        '
        'usrEstMovimentacaoManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 14!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrEstMovimentacaoManual"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabMain.ResumeLayout(false)
        Me.pagListagem.ResumeLayout(false)
        CType(Me.grpEndereco,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpEndereco.ResumeLayout(false)
        Me.grpEndereco.PerformLayout
        CType(Me.grdListagem,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpControl,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpControl.ResumeLayout(false)
        CType(Me.grpFiltro,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpFiltro.ResumeLayout(false)
        Me.grpFiltro.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDescritivo As System.Windows.Forms.Label
    Friend WithEvents grpEndereco As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDeposito As System.Windows.Forms.Label
    Friend WithEvents cboDeposito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCodigoProduto As System.Windows.Forms.Label
    Friend WithEvents cboCodigoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCadastrarDeposito As System.Windows.Forms.Button
    Friend WithEvents btnProcurarItem As System.Windows.Forms.Button
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDescritivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipoMovimentacao As System.Windows.Forms.Label
    Friend WithEvents cboTipoMovimentacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDataMovimentacao As System.Windows.Forms.Label
    Friend WithEvents dtpDataMovimentacao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtLote As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button

End Class
