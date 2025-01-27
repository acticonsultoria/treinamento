<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrEstTransferenciaDeposito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrEstTransferenciaDeposito))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpEndereco = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLocalizacao = New System.Windows.Forms.Label()
        Me.txtLocalizacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSaldoDestino = New System.Windows.Forms.Label()
        Me.txtSaldoDestino = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblSaldoOrigem = New System.Windows.Forms.Label()
        Me.txtSaldoOrigem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnProcurarItem = New System.Windows.Forms.Button()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.cboLote = New Janus.Windows.EditControls.UIComboBox()
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
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.btnCadastrarDepositoOrigem = New System.Windows.Forms.Button()
        Me.btnCadastrarDepositoDestino = New System.Windows.Forms.Button()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.cboDepositoOrigem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDepositoDestino = New System.Windows.Forms.Label()
        Me.lblDepositoOrigem = New System.Windows.Forms.Label()
        Me.cboDepositoDestino = New Janus.Windows.EditControls.UIComboBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEndereco.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.grpEndereco)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpControl)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Estoque - Transferência de Depósito"
        '
        'grpEndereco
        '
        Me.grpEndereco.BackColor = System.Drawing.Color.Transparent
        Me.grpEndereco.Controls.Add(Me.lblLocalizacao)
        Me.grpEndereco.Controls.Add(Me.txtLocalizacao)
        Me.grpEndereco.Controls.Add(Me.lblSaldoDestino)
        Me.grpEndereco.Controls.Add(Me.txtSaldoDestino)
        Me.grpEndereco.Controls.Add(Me.lblSaldoOrigem)
        Me.grpEndereco.Controls.Add(Me.txtSaldoOrigem)
        Me.grpEndereco.Controls.Add(Me.lblDescricao)
        Me.grpEndereco.Controls.Add(Me.txtDescricao)
        Me.grpEndereco.Controls.Add(Me.btnProcurarItem)
        Me.grpEndereco.Controls.Add(Me.lblQuantidade)
        Me.grpEndereco.Controls.Add(Me.txtQuantidade)
        Me.grpEndereco.Controls.Add(Me.lblLote)
        Me.grpEndereco.Controls.Add(Me.cboLote)
        Me.grpEndereco.Controls.Add(Me.btnExcluir)
        Me.grpEndereco.Controls.Add(Me.btnInserir)
        Me.grpEndereco.Controls.Add(Me.lblCodigoProduto)
        Me.grpEndereco.Controls.Add(Me.cboCodigoProduto)
        Me.grpEndereco.Location = New System.Drawing.Point(8, 110)
        Me.grpEndereco.Name = "grpEndereco"
        Me.grpEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEndereco.Size = New System.Drawing.Size(897, 104)
        Me.grpEndereco.TabIndex = 1
        Me.grpEndereco.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpEndereco.VisualStyleManager = Me.vsmMain
        '
        'lblLocalizacao
        '
        Me.lblLocalizacao.AutoSize = True
        Me.lblLocalizacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLocalizacao.Location = New System.Drawing.Point(502, 57)
        Me.lblLocalizacao.Name = "lblLocalizacao"
        Me.lblLocalizacao.Size = New System.Drawing.Size(68, 14)
        Me.lblLocalizacao.TabIndex = 13
        Me.lblLocalizacao.Text = "Localização:"
        '
        'txtLocalizacao
        '
        Me.txtLocalizacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalizacao.Location = New System.Drawing.Point(505, 74)
        Me.txtLocalizacao.MaxLength = 20
        Me.txtLocalizacao.Name = "txtLocalizacao"
        Me.txtLocalizacao.Size = New System.Drawing.Size(151, 20)
        Me.txtLocalizacao.TabIndex = 14
        '
        'lblSaldoDestino
        '
        Me.lblSaldoDestino.AutoSize = True
        Me.lblSaldoDestino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSaldoDestino.Location = New System.Drawing.Point(267, 57)
        Me.lblSaldoDestino.Name = "lblSaldoDestino"
        Me.lblSaldoDestino.Size = New System.Drawing.Size(76, 14)
        Me.lblSaldoDestino.TabIndex = 9
        Me.lblSaldoDestino.Text = "Saldo Destino:"
        '
        'txtSaldoDestino
        '
        Me.txtSaldoDestino.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSaldoDestino.Location = New System.Drawing.Point(270, 74)
        Me.txtSaldoDestino.Name = "txtSaldoDestino"
        Me.txtSaldoDestino.ReadOnly = True
        Me.txtSaldoDestino.Size = New System.Drawing.Size(103, 20)
        Me.txtSaldoDestino.TabIndex = 10
        Me.txtSaldoDestino.Text = "0,00"
        Me.txtSaldoDestino.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblSaldoOrigem
        '
        Me.lblSaldoOrigem.AutoSize = True
        Me.lblSaldoOrigem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSaldoOrigem.Location = New System.Drawing.Point(162, 57)
        Me.lblSaldoOrigem.Name = "lblSaldoOrigem"
        Me.lblSaldoOrigem.Size = New System.Drawing.Size(74, 14)
        Me.lblSaldoOrigem.TabIndex = 7
        Me.lblSaldoOrigem.Text = "Saldo Origem:"
        '
        'txtSaldoOrigem
        '
        Me.txtSaldoOrigem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSaldoOrigem.Location = New System.Drawing.Point(165, 74)
        Me.txtSaldoOrigem.Name = "txtSaldoOrigem"
        Me.txtSaldoOrigem.ReadOnly = True
        Me.txtSaldoOrigem.Size = New System.Drawing.Size(99, 20)
        Me.txtSaldoOrigem.TabIndex = 8
        Me.txtSaldoOrigem.Text = "0,00"
        Me.txtSaldoOrigem.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricao.Location = New System.Drawing.Point(162, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 3
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(165, 34)
        Me.txtDescricao.MaxLength = 20
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(491, 20)
        Me.txtDescricao.TabIndex = 4
        Me.txtDescricao.TabStop = False
        '
        'btnProcurarItem
        '
        Me.btnProcurarItem.FlatAppearance.BorderSize = 0
        Me.btnProcurarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItem.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItem.Location = New System.Drawing.Point(142, 15)
        Me.btnProcurarItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItem.Name = "btnProcurarItem"
        Me.btnProcurarItem.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItem.TabIndex = 2
        Me.btnProcurarItem.TabStop = False
        Me.btnProcurarItem.UseVisualStyleBackColor = True
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidade.Location = New System.Drawing.Point(376, 58)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 11
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(379, 75)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(120, 20)
        Me.txtQuantidade.TabIndex = 12
        Me.txtQuantidade.Text = "0,00"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLote.Location = New System.Drawing.Point(6, 57)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(31, 14)
        Me.lblLote.TabIndex = 5
        Me.lblLote.Text = "Lote:"
        '
        'cboLote
        '
        Me.cboLote.AutoSize = False
        Me.cboLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboLote.Location = New System.Drawing.Point(9, 74)
        Me.cboLote.Name = "cboLote"
        Me.cboLote.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboLote.Size = New System.Drawing.Size(150, 20)
        Me.cboLote.TabIndex = 6
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(797, 71)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 16
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        Me.btnInserir.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(700, 71)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 15
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblCodigoProduto
        '
        Me.lblCodigoProduto.AutoSize = True
        Me.lblCodigoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProduto.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        Me.lblCodigoProduto.Size = New System.Drawing.Size(83, 14)
        Me.lblCodigoProduto.TabIndex = 0
        Me.lblCodigoProduto.Text = "Código Produto:"
        '
        'cboCodigoProduto
        '
        Me.cboCodigoProduto.AutoSize = False
        Me.cboCodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCodigoProduto.Location = New System.Drawing.Point(9, 34)
        Me.cboCodigoProduto.Name = "cboCodigoProduto"
        Me.cboCodigoProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigoProduto.Size = New System.Drawing.Size(150, 20)
        Me.cboCodigoProduto.TabIndex = 1
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.CellToolTipText = "Duplo clique para editar o registro"
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(8, 223)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 257)
        Me.grdListagem.TabIndex = 2
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnNovo)
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 3
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
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
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtNumeroDocumento)
        Me.grpFiltro.Controls.Add(Me.lblNumeroDocumento)
        Me.grpFiltro.Controls.Add(Me.btnCadastrarDepositoOrigem)
        Me.grpFiltro.Controls.Add(Me.btnCadastrarDepositoDestino)
        Me.grpFiltro.Controls.Add(Me.txtObservacao)
        Me.grpFiltro.Controls.Add(Me.lblObservacao)
        Me.grpFiltro.Controls.Add(Me.cboDepositoOrigem)
        Me.grpFiltro.Controls.Add(Me.lblDepositoDestino)
        Me.grpFiltro.Controls.Add(Me.lblDepositoOrigem)
        Me.grpFiltro.Controls.Add(Me.cboDepositoDestino)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroDocumento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumento.MaxLength = 20
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.ReadOnly = True
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(120, 20)
        Me.txtNumeroDocumento.TabIndex = 1
        Me.txtNumeroDocumento.TabStop = False
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroDocumento.TabIndex = 0
        Me.lblNumeroDocumento.Text = "N° Documento:"
        '
        'btnCadastrarDepositoOrigem
        '
        Me.btnCadastrarDepositoOrigem.FlatAppearance.BorderSize = 0
        Me.btnCadastrarDepositoOrigem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarDepositoOrigem.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarDepositoOrigem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarDepositoOrigem.Location = New System.Drawing.Point(135, 18)
        Me.btnCadastrarDepositoOrigem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarDepositoOrigem.Name = "btnCadastrarDepositoOrigem"
        Me.btnCadastrarDepositoOrigem.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarDepositoOrigem.TabIndex = 2
        Me.btnCadastrarDepositoOrigem.TabStop = False
        Me.btnCadastrarDepositoOrigem.UseVisualStyleBackColor = True
        '
        'btnCadastrarDepositoDestino
        '
        Me.btnCadastrarDepositoDestino.FlatAppearance.BorderSize = 0
        Me.btnCadastrarDepositoDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarDepositoDestino.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarDepositoDestino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarDepositoDestino.Location = New System.Drawing.Point(9, 58)
        Me.btnCadastrarDepositoDestino.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarDepositoDestino.Name = "btnCadastrarDepositoDestino"
        Me.btnCadastrarDepositoDestino.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarDepositoDestino.TabIndex = 5
        Me.btnCadastrarDepositoDestino.TabStop = False
        Me.btnCadastrarDepositoDestino.UseVisualStyleBackColor = True
        '
        'txtObservacao
        '
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Location = New System.Drawing.Point(455, 34)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(433, 60)
        Me.txtObservacao.TabIndex = 9
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblObservacao.Location = New System.Drawing.Point(452, 17)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacao.TabIndex = 8
        Me.lblObservacao.Text = "Observação:"
        '
        'cboDepositoOrigem
        '
        Me.cboDepositoOrigem.AutoSize = False
        Me.cboDepositoOrigem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDepositoOrigem.Location = New System.Drawing.Point(135, 34)
        Me.cboDepositoOrigem.Name = "cboDepositoOrigem"
        Me.cboDepositoOrigem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDepositoOrigem.Size = New System.Drawing.Size(314, 20)
        Me.cboDepositoOrigem.TabIndex = 4
        '
        'lblDepositoDestino
        '
        Me.lblDepositoDestino.AutoSize = True
        Me.lblDepositoDestino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDepositoDestino.Location = New System.Drawing.Point(25, 57)
        Me.lblDepositoDestino.Name = "lblDepositoDestino"
        Me.lblDepositoDestino.Size = New System.Drawing.Size(91, 14)
        Me.lblDepositoDestino.TabIndex = 6
        Me.lblDepositoDestino.Text = "Depósito Destino:"
        '
        'lblDepositoOrigem
        '
        Me.lblDepositoOrigem.AutoSize = True
        Me.lblDepositoOrigem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDepositoOrigem.Location = New System.Drawing.Point(151, 17)
        Me.lblDepositoOrigem.Name = "lblDepositoOrigem"
        Me.lblDepositoOrigem.Size = New System.Drawing.Size(104, 14)
        Me.lblDepositoOrigem.TabIndex = 3
        Me.lblDepositoOrigem.Text = "Depósito de Origem:"
        '
        'cboDepositoDestino
        '
        Me.cboDepositoDestino.AutoSize = False
        Me.cboDepositoDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDepositoDestino.Location = New System.Drawing.Point(9, 74)
        Me.cboDepositoDestino.Name = "cboDepositoDestino"
        Me.cboDepositoDestino.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDepositoDestino.Size = New System.Drawing.Size(440, 20)
        Me.cboDepositoDestino.TabIndex = 7
        '
        'usrEstTransferenciaDeposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrEstTransferenciaDeposito"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEndereco.ResumeLayout(False)
        Me.grpEndereco.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboDepositoOrigem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDepositoOrigem As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents grpEndereco As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDepositoDestino As System.Windows.Forms.Label
    Friend WithEvents cboDepositoDestino As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents cboLote As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCodigoProduto As System.Windows.Forms.Label
    Friend WithEvents cboCodigoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCadastrarDepositoDestino As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarDepositoOrigem As System.Windows.Forms.Button
    Friend WithEvents btnProcurarItem As System.Windows.Forms.Button
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSaldoDestino As System.Windows.Forms.Label
    Friend WithEvents txtSaldoDestino As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblSaldoOrigem As System.Windows.Forms.Label
    Friend WithEvents txtSaldoOrigem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblLocalizacao As System.Windows.Forms.Label
    Friend WithEvents txtLocalizacao As Janus.Windows.GridEX.EditControls.MaskedEditBox

End Class
