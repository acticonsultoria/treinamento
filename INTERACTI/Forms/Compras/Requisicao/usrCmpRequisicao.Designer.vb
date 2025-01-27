<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usrCmpRequisicao
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
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCmpRequisicao))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdListagem_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.Image")
        Dim grdListagem_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.Image")
        Dim grdListagem_DesignTimeLayout_Reference_5 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.Image")
        Dim grdListagem_DesignTimeLayout_Reference_6 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column14.Image")
        Dim cboStatusRequisicaoFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdItem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdItem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings2 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim SuperTipSettings3 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim grdArquivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaEntregaEfetuada = New System.Windows.Forms.Label()
        Me.picLegendaEntregaEfetuada = New System.Windows.Forms.PictureBox()
        Me.lblLegendaCancelado = New System.Windows.Forms.Label()
        Me.picLegendaCancelado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaPedidoCompra = New System.Windows.Forms.Label()
        Me.picLegendaPedidoCompra = New System.Windows.Forms.PictureBox()
        Me.lblLegendaCotando = New System.Windows.Forms.Label()
        Me.picLegendaCotando = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAprovado = New System.Windows.Forms.Label()
        Me.picLegendaAprovado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAguardandoAprovacao = New System.Windows.Forms.Label()
        Me.picLegendaAguardandoAprovacao = New System.Windows.Forms.PictureBox()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarItemFiltro = New System.Windows.Forms.Button()
        Me.cboAprovadorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAprovadorFiltro = New System.Windows.Forms.Label()
        Me.cboRequisitanteFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblRequisitanteFiltro = New System.Windows.Forms.Label()
        Me.cboStatusRequisicaoFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.dtpDataRequisicaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataRequisicaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblItemFiltro = New System.Windows.Forms.Label()
        Me.txtItemFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroRequisicaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.lblDataRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.lblStatusRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosRequisicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboRequisitante = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumeroRequisicao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRequisicao = New System.Windows.Forms.Label()
        Me.lblRequisitante = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColunaItem = New System.Windows.Forms.Label()
        Me.cboCongelarColunaItem = New Janus.Windows.EditControls.UIComboBox()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagItem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnOcultarExibir = New Janus.Windows.EditControls.UIButton()
        Me.grdItem = New Janus.Windows.GridEX.GridEX()
        Me.grpItem = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovoItem = New Janus.Windows.EditControls.UIButton()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPesoEspecifico = New System.Windows.Forms.Label()
        Me.txtPesoEspecifico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtPeso = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.txtMedida1 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMedida3 = New System.Windows.Forms.Label()
        Me.txtMedida2 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtMedida3 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMedida2 = New System.Windows.Forms.Label()
        Me.lblMedida4 = New System.Windows.Forms.Label()
        Me.txtMedida4 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMedida1 = New System.Windows.Forms.Label()
        Me.txtQtdRequisicao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQtdRequisicao = New System.Windows.Forms.Label()
        Me.lblObservacaoInterna = New System.Windows.Forms.Label()
        Me.txtObservacaoInterna = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboGrupoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOrdemDeProducaoPai = New System.Windows.Forms.Label()
        Me.btnFindGrupoItem = New System.Windows.Forms.Button()
        Me.cboOrdemDeProducaoPai = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPartNumberPai = New System.Windows.Forms.Label()
        Me.cboPartNumberPai = New Janus.Windows.EditControls.UIComboBox()
        Me.lblGrupoItem = New System.Windows.Forms.Label()
        Me.txtQuantidadeAberto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeAberto = New System.Windows.Forms.Label()
        Me.dtpDataNecessidadeItem = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblCodigoItem = New System.Windows.Forms.Label()
        Me.lblJustificativaItem = New System.Windows.Forms.Label()
        Me.cboContaContabilItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblContaContabilItem = New System.Windows.Forms.Label()
        Me.lblCentroGastoItem = New System.Windows.Forms.Label()
        Me.cboCentroGastoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblComplementoItem = New System.Windows.Forms.Label()
        Me.txtComplementoItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataNecessidadeItem = New System.Windows.Forms.Label()
        Me.lblUnidadeMedidaItem = New System.Windows.Forms.Label()
        Me.cboUnidadeMedidaItem = New Janus.Windows.EditControls.UIComboBox()
        Me.txtQuantidadeItem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeItem = New System.Windows.Forms.Label()
        Me.txtJustificativaItem = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.btnProcurarContaContabil = New System.Windows.Forms.Button()
        Me.btnQuantidadeAberto = New System.Windows.Forms.Button()
        Me.btnProcurarCentroGasto = New System.Windows.Forms.Button()
        Me.btnCadastrarCentroGastoItem = New System.Windows.Forms.Button()
        Me.btnCadastrarContaContabilItem = New System.Windows.Forms.Button()
        Me.btnCadastrarUnidadeMedidaItem = New System.Windows.Forms.Button()
        Me.btnExcluirItem = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirItem = New Janus.Windows.EditControls.UIButton()
        Me.txtCodigoProdutoNovo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboItem = New Janus.Windows.EditControls.UIComboBox()
        Me.pagArquivo = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdArquivo = New Janus.Windows.GridEX.GridEX()
        Me.grpArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtTituloArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTituloArquivo = New System.Windows.Forms.Label()
        Me.btnExcluirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirArquivo = New Janus.Windows.EditControls.UIButton()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaEntregaEfetuada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaPedidoCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaCotando, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaAprovado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaAguardandoAprovacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpDadosRequisicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosRequisicao.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagItem.SuspendLayout()
        CType(Me.grdItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItem.SuspendLayout()
        Me.pagArquivo.SuspendLayout()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Requisição de Compra"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaEntregaEfetuada)
        Me.grpLegenda.Controls.Add(Me.picLegendaEntregaEfetuada)
        Me.grpLegenda.Controls.Add(Me.lblLegendaCancelado)
        Me.grpLegenda.Controls.Add(Me.picLegendaCancelado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaPedidoCompra)
        Me.grpLegenda.Controls.Add(Me.picLegendaPedidoCompra)
        Me.grpLegenda.Controls.Add(Me.lblLegendaCotando)
        Me.grpLegenda.Controls.Add(Me.picLegendaCotando)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAprovado)
        Me.grpLegenda.Controls.Add(Me.picLegendaAprovado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAguardandoAprovacao)
        Me.grpLegenda.Controls.Add(Me.picLegendaAguardandoAprovacao)
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(353, 51)
        Me.grpLegenda.TabIndex = 4
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaEntregaEfetuada
        '
        Me.lblLegendaEntregaEfetuada.AutoSize = True
        Me.lblLegendaEntregaEfetuada.Location = New System.Drawing.Point(259, 30)
        Me.lblLegendaEntregaEfetuada.Name = "lblLegendaEntregaEfetuada"
        Me.lblLegendaEntregaEfetuada.Size = New System.Drawing.Size(90, 14)
        Me.lblLegendaEntregaEfetuada.TabIndex = 5
        Me.lblLegendaEntregaEfetuada.Text = "Entrega Efetuada"
        '
        'picLegendaEntregaEfetuada
        '
        Me.picLegendaEntregaEfetuada.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaEntregaEfetuada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaEntregaEfetuada.Location = New System.Drawing.Point(240, 30)
        Me.picLegendaEntregaEfetuada.Name = "picLegendaEntregaEfetuada"
        Me.picLegendaEntregaEfetuada.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaEntregaEfetuada.TabIndex = 24
        Me.picLegendaEntregaEfetuada.TabStop = False
        '
        'lblLegendaCancelado
        '
        Me.lblLegendaCancelado.AutoSize = True
        Me.lblLegendaCancelado.Location = New System.Drawing.Point(176, 30)
        Me.lblLegendaCancelado.Name = "lblLegendaCancelado"
        Me.lblLegendaCancelado.Size = New System.Drawing.Size(58, 14)
        Me.lblLegendaCancelado.TabIndex = 3
        Me.lblLegendaCancelado.Text = "Cancelado"
        '
        'picLegendaCancelado
        '
        Me.picLegendaCancelado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCancelado.Location = New System.Drawing.Point(157, 30)
        Me.picLegendaCancelado.Name = "picLegendaCancelado"
        Me.picLegendaCancelado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCancelado.TabIndex = 22
        Me.picLegendaCancelado.TabStop = False
        '
        'lblLegendaPedidoCompra
        '
        Me.lblLegendaPedidoCompra.AutoSize = True
        Me.lblLegendaPedidoCompra.Location = New System.Drawing.Point(28, 30)
        Me.lblLegendaPedidoCompra.Name = "lblLegendaPedidoCompra"
        Me.lblLegendaPedidoCompra.Size = New System.Drawing.Size(94, 14)
        Me.lblLegendaPedidoCompra.TabIndex = 1
        Me.lblLegendaPedidoCompra.Text = "Pedido de Compra"
        '
        'picLegendaPedidoCompra
        '
        Me.picLegendaPedidoCompra.BackColor = System.Drawing.Color.Purple
        Me.picLegendaPedidoCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaPedidoCompra.Location = New System.Drawing.Point(9, 30)
        Me.picLegendaPedidoCompra.Name = "picLegendaPedidoCompra"
        Me.picLegendaPedidoCompra.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaPedidoCompra.TabIndex = 20
        Me.picLegendaPedidoCompra.TabStop = False
        '
        'lblLegendaCotando
        '
        Me.lblLegendaCotando.AutoSize = True
        Me.lblLegendaCotando.Location = New System.Drawing.Point(259, 13)
        Me.lblLegendaCotando.Name = "lblLegendaCotando"
        Me.lblLegendaCotando.Size = New System.Drawing.Size(47, 14)
        Me.lblLegendaCotando.TabIndex = 4
        Me.lblLegendaCotando.Text = "Cotando"
        '
        'picLegendaCotando
        '
        Me.picLegendaCotando.BackColor = System.Drawing.Color.MediumVioletRed
        Me.picLegendaCotando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCotando.Location = New System.Drawing.Point(240, 13)
        Me.picLegendaCotando.Name = "picLegendaCotando"
        Me.picLegendaCotando.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCotando.TabIndex = 8
        Me.picLegendaCotando.TabStop = False
        '
        'lblLegendaAprovado
        '
        Me.lblLegendaAprovado.AutoSize = True
        Me.lblLegendaAprovado.Location = New System.Drawing.Point(176, 13)
        Me.lblLegendaAprovado.Name = "lblLegendaAprovado"
        Me.lblLegendaAprovado.Size = New System.Drawing.Size(55, 14)
        Me.lblLegendaAprovado.TabIndex = 2
        Me.lblLegendaAprovado.Text = "Aprovada"
        '
        'picLegendaAprovado
        '
        Me.picLegendaAprovado.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaAprovado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAprovado.Location = New System.Drawing.Point(157, 13)
        Me.picLegendaAprovado.Name = "picLegendaAprovado"
        Me.picLegendaAprovado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAprovado.TabIndex = 6
        Me.picLegendaAprovado.TabStop = False
        '
        'lblLegendaAguardandoAprovacao
        '
        Me.lblLegendaAguardandoAprovacao.AutoSize = True
        Me.lblLegendaAguardandoAprovacao.Location = New System.Drawing.Point(28, 13)
        Me.lblLegendaAguardandoAprovacao.Name = "lblLegendaAguardandoAprovacao"
        Me.lblLegendaAguardandoAprovacao.Size = New System.Drawing.Size(123, 14)
        Me.lblLegendaAguardandoAprovacao.TabIndex = 0
        Me.lblLegendaAguardandoAprovacao.Text = "Aguardando Aprovação"
        '
        'picLegendaAguardandoAprovacao
        '
        Me.picLegendaAguardandoAprovacao.BackColor = System.Drawing.Color.DarkGray
        Me.picLegendaAguardandoAprovacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAguardandoAprovacao.Location = New System.Drawing.Point(9, 13)
        Me.picLegendaAguardandoAprovacao.Name = "picLegendaAguardandoAprovacao"
        Me.picLegendaAguardandoAprovacao.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAguardandoAprovacao.TabIndex = 4
        Me.picLegendaAguardandoAprovacao.TabStop = False
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
        grdListagem_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_4.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_5.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_5.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_6.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_6.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2, grdListagem_DesignTimeLayout_Reference_3, grdListagem_DesignTimeLayout_Reference_4, grdListagem_DesignTimeLayout_Reference_5, grdListagem_DesignTimeLayout_Reference_6})
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
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 364)
        Me.grdListagem.TabIndex = 1
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
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnProcurarItemFiltro)
        Me.grpFiltro.Controls.Add(Me.cboAprovadorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblAprovadorFiltro)
        Me.grpFiltro.Controls.Add(Me.cboRequisitanteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblRequisitanteFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataRequisicaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataRequisicaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblItemFiltro)
        Me.grpFiltro.Controls.Add(Me.txtItemFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusRequisicaoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarItemFiltro
        '
        Me.btnProcurarItemFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarItemFiltro.FlatAppearance.BorderSize = 0
        Me.btnProcurarItemFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItemFiltro.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarItemFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItemFiltro.Location = New System.Drawing.Point(753, 56)
        Me.btnProcurarItemFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItemFiltro.Name = "btnProcurarItemFiltro"
        Me.btnProcurarItemFiltro.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItemFiltro.TabIndex = 12
        Me.btnProcurarItemFiltro.TabStop = False
        Me.btnProcurarItemFiltro.UseVisualStyleBackColor = True
        '
        'cboAprovadorFiltro
        '
        Me.cboAprovadorFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAprovadorFiltro.AutoSize = False
        Me.cboAprovadorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAprovadorFiltro.Location = New System.Drawing.Point(508, 34)
        Me.cboAprovadorFiltro.Name = "cboAprovadorFiltro"
        Me.cboAprovadorFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAprovadorFiltro.Size = New System.Drawing.Size(262, 20)
        Me.cboAprovadorFiltro.TabIndex = 7
        Me.cboAprovadorFiltro.Visible = False
        '
        'lblAprovadorFiltro
        '
        Me.lblAprovadorFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAprovadorFiltro.AutoSize = True
        Me.lblAprovadorFiltro.Location = New System.Drawing.Point(505, 17)
        Me.lblAprovadorFiltro.Name = "lblAprovadorFiltro"
        Me.lblAprovadorFiltro.Size = New System.Drawing.Size(62, 14)
        Me.lblAprovadorFiltro.TabIndex = 6
        Me.lblAprovadorFiltro.Text = "Aprovador:"
        Me.lblAprovadorFiltro.Visible = False
        '
        'cboRequisitanteFiltro
        '
        Me.cboRequisitanteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboRequisitanteFiltro.AutoSize = False
        Me.cboRequisitanteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboRequisitanteFiltro.Location = New System.Drawing.Point(237, 34)
        Me.cboRequisitanteFiltro.Name = "cboRequisitanteFiltro"
        Me.cboRequisitanteFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboRequisitanteFiltro.Size = New System.Drawing.Size(265, 20)
        Me.cboRequisitanteFiltro.TabIndex = 5
        '
        'lblRequisitanteFiltro
        '
        Me.lblRequisitanteFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRequisitanteFiltro.AutoSize = True
        Me.lblRequisitanteFiltro.Location = New System.Drawing.Point(234, 17)
        Me.lblRequisitanteFiltro.Name = "lblRequisitanteFiltro"
        Me.lblRequisitanteFiltro.Size = New System.Drawing.Size(69, 14)
        Me.lblRequisitanteFiltro.TabIndex = 4
        Me.lblRequisitanteFiltro.Text = "Requisitante:"
        '
        'cboStatusRequisicaoFiltro
        '
        Me.cboStatusRequisicaoFiltro.AllowDrop = True
        Me.cboStatusRequisicaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStatusRequisicaoFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusRequisicaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusRequisicaoFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusRequisicaoFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusRequisicaoFiltro.DesignTimeLayout = cboStatusRequisicaoFiltro_DesignTimeLayout
        Me.cboStatusRequisicaoFiltro.Location = New System.Drawing.Point(123, 34)
        Me.cboStatusRequisicaoFiltro.Name = "cboStatusRequisicaoFiltro"
        Me.cboStatusRequisicaoFiltro.SaveSettings = False
        Me.cboStatusRequisicaoFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusRequisicaoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.cboStatusRequisicaoFiltro.TabIndex = 3
        Me.cboStatusRequisicaoFiltro.ValuesDataMember = Nothing
        '
        'dtpDataRequisicaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataRequisicaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataRequisicaoTerminoFiltro.Location = New System.Drawing.Point(123, 74)
        Me.dtpDataRequisicaoTerminoFiltro.Name = "dtpDataRequisicaoTerminoFiltro"
        Me.dtpDataRequisicaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataRequisicaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataRequisicaoTerminoFiltro.TabIndex = 10
        '
        'dtpDataRequisicaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataRequisicaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataRequisicaoInicioFiltro.Location = New System.Drawing.Point(9, 74)
        Me.dtpDataRequisicaoInicioFiltro.Name = "dtpDataRequisicaoInicioFiltro"
        Me.dtpDataRequisicaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataRequisicaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataRequisicaoInicioFiltro.TabIndex = 9
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 14
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblItemFiltro
        '
        Me.lblItemFiltro.AutoSize = True
        Me.lblItemFiltro.Location = New System.Drawing.Point(234, 57)
        Me.lblItemFiltro.Name = "lblItemFiltro"
        Me.lblItemFiltro.Size = New System.Drawing.Size(29, 14)
        Me.lblItemFiltro.TabIndex = 11
        Me.lblItemFiltro.Text = "Item:"
        '
        'txtItemFiltro
        '
        Me.txtItemFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemFiltro.Location = New System.Drawing.Point(237, 74)
        Me.txtItemFiltro.MaxLength = 120
        Me.txtItemFiltro.Name = "txtItemFiltro"
        Me.txtItemFiltro.Size = New System.Drawing.Size(533, 20)
        Me.txtItemFiltro.TabIndex = 13
        '
        'txtNumeroRequisicaoFiltro
        '
        Me.txtNumeroRequisicaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRequisicaoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroRequisicaoFiltro.MaxLength = 20
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
        Me.lblDataRequisicaoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblDataRequisicaoFiltro.Name = "lblDataRequisicaoFiltro"
        Me.lblDataRequisicaoFiltro.Size = New System.Drawing.Size(103, 14)
        Me.lblDataRequisicaoFiltro.TabIndex = 8
        Me.lblDataRequisicaoFiltro.Text = "Data da Requisição:"
        '
        'lblStatusRequisicaoFiltro
        '
        Me.lblStatusRequisicaoFiltro.AutoSize = True
        Me.lblStatusRequisicaoFiltro.Location = New System.Drawing.Point(120, 17)
        Me.lblStatusRequisicaoFiltro.Name = "lblStatusRequisicaoFiltro"
        Me.lblStatusRequisicaoFiltro.Size = New System.Drawing.Size(97, 14)
        Me.lblStatusRequisicaoFiltro.TabIndex = 2
        Me.lblStatusRequisicaoFiltro.Text = "Status Requisição:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnExcluir)
        Me.grpControle.Controls.Add(Me.btnNovo1)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(370, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(535, 51)
        Me.grpControle.TabIndex = 5
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(338, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(241, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 1
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(435, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpDadosRequisicao)
        Me.pagDados.Controls.Add(Me.grpControl)
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagLista"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Requisição de Compra"
        '
        'grpDadosRequisicao
        '
        Me.grpDadosRequisicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosRequisicao.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosRequisicao.Controls.Add(Me.cboRequisitante)
        Me.grpDadosRequisicao.Controls.Add(Me.txtNumeroRequisicao)
        Me.grpDadosRequisicao.Controls.Add(Me.lblNumeroRequisicao)
        Me.grpDadosRequisicao.Controls.Add(Me.lblRequisitante)
        Me.grpDadosRequisicao.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosRequisicao.Name = "grpDadosRequisicao"
        Me.grpDadosRequisicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosRequisicao.Size = New System.Drawing.Size(897, 63)
        Me.grpDadosRequisicao.TabIndex = 0
        Me.grpDadosRequisicao.VisualStyleManager = Me.vsmMain
        '
        'cboRequisitante
        '
        Me.cboRequisitante.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboRequisitante.AutoSize = False
        Me.cboRequisitante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboRequisitante.Location = New System.Drawing.Point(123, 34)
        Me.cboRequisitante.Name = "cboRequisitante"
        Me.cboRequisitante.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboRequisitante.Size = New System.Drawing.Size(765, 20)
        Me.cboRequisitante.TabIndex = 1
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
        Me.txtNumeroRequisicao.TabIndex = 0
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
        'lblRequisitante
        '
        Me.lblRequisitante.AutoSize = True
        Me.lblRequisitante.Location = New System.Drawing.Point(120, 17)
        Me.lblRequisitante.Name = "lblRequisitante"
        Me.lblRequisitante.Size = New System.Drawing.Size(69, 14)
        Me.lblRequisitante.TabIndex = 4
        Me.lblRequisitante.Text = "Requisitante:"
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.lblCongelarColunaItem)
        Me.grpControl.Controls.Add(Me.cboCongelarColunaItem)
        Me.grpControl.Controls.Add(Me.btnImprimir)
        Me.grpControl.Controls.Add(Me.btnNovo)
        Me.grpControl.Controls.Add(Me.btnVoltar)
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColunaItem
        '
        Me.lblCongelarColunaItem.AutoSize = True
        Me.lblCongelarColunaItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColunaItem.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColunaItem.Name = "lblCongelarColunaItem"
        Me.lblCongelarColunaItem.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColunaItem.TabIndex = 7
        Me.lblCongelarColunaItem.Text = "Congelar Coluna:"
        '
        'cboCongelarColunaItem
        '
        Me.cboCongelarColunaItem.AutoSize = False
        Me.cboCongelarColunaItem.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColunaItem.Name = "cboCongelarColunaItem"
        Me.cboCongelarColunaItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColunaItem.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColunaItem.TabIndex = 8
        Me.cboCongelarColunaItem.TabStop = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(700, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(91, 23)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(506, 17)
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
        Me.btnVoltar.Location = New System.Drawing.Point(797, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 3
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(603, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 72)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 408)
        Me.tabDados.TabIndex = 1
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagItem, Me.pagArquivo})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagItem
        '
        Me.pagItem.Controls.Add(Me.btnOcultarExibir)
        Me.pagItem.Controls.Add(Me.grdItem)
        Me.pagItem.Controls.Add(Me.grpItem)
        Me.pagItem.Key = "pagItem"
        Me.pagItem.Location = New System.Drawing.Point(1, 22)
        Me.pagItem.Name = "pagItem"
        Me.pagItem.Size = New System.Drawing.Size(895, 385)
        Me.pagItem.TabStop = True
        Me.pagItem.Text = "Itens"
        '
        'btnOcultarExibir
        '
        Me.btnOcultarExibir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOcultarExibir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnOcultarExibir.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnOcultarExibir.Location = New System.Drawing.Point(8, 358)
        Me.btnOcultarExibir.Name = "btnOcultarExibir"
        Me.btnOcultarExibir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnOcultarExibir.Size = New System.Drawing.Size(77, 18)
        Me.btnOcultarExibir.TabIndex = 79
        Me.btnOcultarExibir.Text = "Ocultar/Exibir "
        Me.btnOcultarExibir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdItem
        '
        Me.grdItem.AlternatingColors = True
        Me.grdItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdItem.AutoEdit = True
        grdItem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdItem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdItem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdItem_DesignTimeLayout_Reference_0})
        grdItem_DesignTimeLayout.LayoutString = resources.GetString("grdItem_DesignTimeLayout.LayoutString")
        Me.grdItem.DesignTimeLayout = grdItem_DesignTimeLayout
        Me.grdItem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdItem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdItem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdItem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdItem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdItem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdItem.FrozenColumns = 2
        Me.grdItem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdItem.GroupByBoxVisible = False
        Me.grdItem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdItem.Location = New System.Drawing.Point(8, 232)
        Me.grdItem.Name = "grdItem"
        Me.grdItem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdItem.RecordNavigator = True
        Me.grdItem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdItem.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdItem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdItem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdItem.Size = New System.Drawing.Size(879, 144)
        Me.grdItem.TabIndex = 2
        Me.grdItem.TabStop = False
        Me.grdItem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdItem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdItem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdItem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdItem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdItem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdItem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdItem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdItem.VisualStyleManager = Me.vsmMain
        '
        'grpItem
        '
        Me.grpItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpItem.BackColor = System.Drawing.Color.Transparent
        Me.grpItem.Controls.Add(Me.btnNovoItem)
        Me.grpItem.Controls.Add(Me.lblDescricao)
        Me.grpItem.Controls.Add(Me.txtDescricao)
        Me.grpItem.Controls.Add(Me.lblPesoEspecifico)
        Me.grpItem.Controls.Add(Me.txtPesoEspecifico)
        Me.grpItem.Controls.Add(Me.txtPeso)
        Me.grpItem.Controls.Add(Me.lblPeso)
        Me.grpItem.Controls.Add(Me.txtMedida1)
        Me.grpItem.Controls.Add(Me.lblMedida3)
        Me.grpItem.Controls.Add(Me.txtMedida2)
        Me.grpItem.Controls.Add(Me.txtMedida3)
        Me.grpItem.Controls.Add(Me.lblMedida2)
        Me.grpItem.Controls.Add(Me.lblMedida4)
        Me.grpItem.Controls.Add(Me.txtMedida4)
        Me.grpItem.Controls.Add(Me.lblMedida1)
        Me.grpItem.Controls.Add(Me.txtQtdRequisicao)
        Me.grpItem.Controls.Add(Me.lblQtdRequisicao)
        Me.grpItem.Controls.Add(Me.lblObservacaoInterna)
        Me.grpItem.Controls.Add(Me.txtObservacaoInterna)
        Me.grpItem.Controls.Add(Me.lblObservacao)
        Me.grpItem.Controls.Add(Me.txtObservacao)
        Me.grpItem.Controls.Add(Me.cboGrupoItem)
        Me.grpItem.Controls.Add(Me.lblOrdemDeProducaoPai)
        Me.grpItem.Controls.Add(Me.btnFindGrupoItem)
        Me.grpItem.Controls.Add(Me.cboOrdemDeProducaoPai)
        Me.grpItem.Controls.Add(Me.lblPartNumberPai)
        Me.grpItem.Controls.Add(Me.cboPartNumberPai)
        Me.grpItem.Controls.Add(Me.lblGrupoItem)
        Me.grpItem.Controls.Add(Me.txtQuantidadeAberto)
        Me.grpItem.Controls.Add(Me.lblQuantidadeAberto)
        Me.grpItem.Controls.Add(Me.dtpDataNecessidadeItem)
        Me.grpItem.Controls.Add(Me.lblCodigoItem)
        Me.grpItem.Controls.Add(Me.lblJustificativaItem)
        Me.grpItem.Controls.Add(Me.cboContaContabilItem)
        Me.grpItem.Controls.Add(Me.lblContaContabilItem)
        Me.grpItem.Controls.Add(Me.lblCentroGastoItem)
        Me.grpItem.Controls.Add(Me.cboCentroGastoItem)
        Me.grpItem.Controls.Add(Me.lblComplementoItem)
        Me.grpItem.Controls.Add(Me.txtComplementoItem)
        Me.grpItem.Controls.Add(Me.lblDataNecessidadeItem)
        Me.grpItem.Controls.Add(Me.lblUnidadeMedidaItem)
        Me.grpItem.Controls.Add(Me.cboUnidadeMedidaItem)
        Me.grpItem.Controls.Add(Me.txtQuantidadeItem)
        Me.grpItem.Controls.Add(Me.lblQuantidadeItem)
        Me.grpItem.Controls.Add(Me.txtJustificativaItem)
        Me.grpItem.Controls.Add(Me.btnProcurarContaContabil)
        Me.grpItem.Controls.Add(Me.btnQuantidadeAberto)
        Me.grpItem.Controls.Add(Me.btnProcurarCentroGasto)
        Me.grpItem.Controls.Add(Me.btnCadastrarCentroGastoItem)
        Me.grpItem.Controls.Add(Me.btnCadastrarContaContabilItem)
        Me.grpItem.Controls.Add(Me.btnCadastrarUnidadeMedidaItem)
        Me.grpItem.Controls.Add(Me.btnExcluirItem)
        Me.grpItem.Controls.Add(Me.btnInserirItem)
        Me.grpItem.Controls.Add(Me.txtCodigoProdutoNovo)
        Me.grpItem.Controls.Add(Me.cboItem)
        Me.grpItem.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpItem.Location = New System.Drawing.Point(8, 3)
        Me.grpItem.Name = "grpItem"
        Me.grpItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpItem.Size = New System.Drawing.Size(879, 223)
        Me.grpItem.TabIndex = 0
        Me.grpItem.VisualStyleManager = Me.vsmMain
        '
        'btnNovoItem
        '
        Me.btnNovoItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovoItem.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovoItem.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovoItem.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovoItem.Location = New System.Drawing.Point(779, 172)
        Me.btnNovoItem.Name = "btnNovoItem"
        Me.btnNovoItem.Size = New System.Drawing.Size(91, 23)
        Me.btnNovoItem.TabIndex = 67
        Me.btnNovoItem.Text = "Novo"
        Me.btnNovoItem.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(591, 59)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 65
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.Location = New System.Drawing.Point(591, 76)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(282, 20)
        Me.txtDescricao.TabIndex = 60
        '
        'lblPesoEspecifico
        '
        Me.lblPesoEspecifico.AutoSize = True
        Me.lblPesoEspecifico.Location = New System.Drawing.Point(427, 60)
        Me.lblPesoEspecifico.Name = "lblPesoEspecifico"
        Me.lblPesoEspecifico.Size = New System.Drawing.Size(87, 14)
        Me.lblPesoEspecifico.TabIndex = 61
        Me.lblPesoEspecifico.Tag = ""
        Me.lblPesoEspecifico.Text = "Peso Específico:"
        '
        'txtPesoEspecifico
        '
        Me.txtPesoEspecifico.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPesoEspecifico.DecimalDigits = 2
        Me.txtPesoEspecifico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtPesoEspecifico.Location = New System.Drawing.Point(430, 76)
        Me.txtPesoEspecifico.MaxLength = 0
        Me.txtPesoEspecifico.Name = "txtPesoEspecifico"
        Me.txtPesoEspecifico.Size = New System.Drawing.Size(85, 20)
        Me.txtPesoEspecifico.TabIndex = 62
        Me.txtPesoEspecifico.TabStop = False
        Me.txtPesoEspecifico.Tag = ""
        Me.txtPesoEspecifico.Text = "0,00"
        Me.txtPesoEspecifico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtPeso
        '
        Me.txtPeso.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPeso.DecimalDigits = 4
        Me.txtPeso.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtPeso.Location = New System.Drawing.Point(521, 76)
        Me.txtPeso.MaxLength = 0
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.ReadOnly = True
        Me.txtPeso.Size = New System.Drawing.Size(64, 20)
        Me.txtPeso.TabIndex = 64
        Me.txtPeso.Tag = ""
        Me.txtPeso.Text = "0,0000"
        Me.txtPeso.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(520, 60)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(34, 14)
        Me.lblPeso.TabIndex = 63
        Me.lblPeso.Tag = ""
        Me.lblPeso.Text = "Peso:"
        '
        'txtMedida1
        '
        Me.txtMedida1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMedida1.DecimalDigits = 2
        Me.txtMedida1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtMedida1.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General
        Me.txtMedida1.FormatString = "0.00"
        Me.txtMedida1.Location = New System.Drawing.Point(495, 34)
        Me.txtMedida1.MaxLength = 0
        Me.txtMedida1.Name = "txtMedida1"
        Me.txtMedida1.Size = New System.Drawing.Size(90, 20)
        Me.txtMedida1.TabIndex = 51
        Me.txtMedida1.Tag = ""
        Me.txtMedida1.Text = "0,00"
        Me.txtMedida1.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMedida3
        '
        Me.lblMedida3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMedida3.AutoSize = True
        Me.lblMedida3.Location = New System.Drawing.Point(684, 17)
        Me.lblMedida3.Name = "lblMedida3"
        Me.lblMedida3.Size = New System.Drawing.Size(53, 14)
        Me.lblMedida3.TabIndex = 57
        Me.lblMedida3.Tag = ""
        Me.lblMedida3.Text = "Medida 3:"
        '
        'txtMedida2
        '
        Me.txtMedida2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMedida2.DecimalDigits = 2
        Me.txtMedida2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtMedida2.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General
        Me.txtMedida2.FormatString = "0.00"
        Me.txtMedida2.Location = New System.Drawing.Point(591, 34)
        Me.txtMedida2.MaxLength = 0
        Me.txtMedida2.Name = "txtMedida2"
        Me.txtMedida2.Size = New System.Drawing.Size(90, 20)
        Me.txtMedida2.TabIndex = 52
        Me.txtMedida2.Tag = ""
        Me.txtMedida2.Text = "0,00"
        Me.txtMedida2.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtMedida3
        '
        Me.txtMedida3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMedida3.DecimalDigits = 2
        Me.txtMedida3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtMedida3.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General
        Me.txtMedida3.FormatString = "0.00"
        Me.txtMedida3.Location = New System.Drawing.Point(687, 34)
        Me.txtMedida3.MaxLength = 0
        Me.txtMedida3.Name = "txtMedida3"
        Me.txtMedida3.Size = New System.Drawing.Size(90, 20)
        Me.txtMedida3.TabIndex = 53
        Me.txtMedida3.Tag = ""
        Me.txtMedida3.Text = "0,00"
        Me.txtMedida3.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMedida2
        '
        Me.lblMedida2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMedida2.AutoSize = True
        Me.lblMedida2.Location = New System.Drawing.Point(588, 17)
        Me.lblMedida2.Name = "lblMedida2"
        Me.lblMedida2.Size = New System.Drawing.Size(53, 14)
        Me.lblMedida2.TabIndex = 56
        Me.lblMedida2.Tag = ""
        Me.lblMedida2.Text = "Medida 2:"
        '
        'lblMedida4
        '
        Me.lblMedida4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMedida4.AutoSize = True
        Me.lblMedida4.Location = New System.Drawing.Point(780, 17)
        Me.lblMedida4.Name = "lblMedida4"
        Me.lblMedida4.Size = New System.Drawing.Size(53, 14)
        Me.lblMedida4.TabIndex = 58
        Me.lblMedida4.Tag = ""
        Me.lblMedida4.Text = "Medida 4:"
        '
        'txtMedida4
        '
        Me.txtMedida4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMedida4.DecimalDigits = 2
        Me.txtMedida4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtMedida4.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General
        Me.txtMedida4.FormatString = "0.00"
        Me.txtMedida4.Location = New System.Drawing.Point(783, 34)
        Me.txtMedida4.MaxLength = 0
        Me.txtMedida4.Name = "txtMedida4"
        Me.txtMedida4.Size = New System.Drawing.Size(90, 20)
        Me.txtMedida4.TabIndex = 54
        Me.txtMedida4.Tag = ""
        Me.txtMedida4.Text = "0,00"
        Me.txtMedida4.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMedida1
        '
        Me.lblMedida1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMedida1.AutoSize = True
        Me.lblMedida1.Location = New System.Drawing.Point(492, 17)
        Me.lblMedida1.Name = "lblMedida1"
        Me.lblMedida1.Size = New System.Drawing.Size(53, 14)
        Me.lblMedida1.TabIndex = 55
        Me.lblMedida1.Tag = ""
        Me.lblMedida1.Text = "Medida 1:"
        '
        'txtQtdRequisicao
        '
        Me.txtQtdRequisicao.DecimalDigits = 4
        Me.txtQtdRequisicao.Location = New System.Drawing.Point(127, 76)
        Me.txtQtdRequisicao.MaxLength = 0
        Me.txtQtdRequisicao.Name = "txtQtdRequisicao"
        Me.txtQtdRequisicao.Size = New System.Drawing.Size(98, 20)
        Me.txtQtdRequisicao.TabIndex = 49
        Me.txtQtdRequisicao.Text = "0,0000"
        Me.txtQtdRequisicao.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQtdRequisicao
        '
        Me.lblQtdRequisicao.AutoSize = True
        Me.lblQtdRequisicao.Location = New System.Drawing.Point(124, 58)
        Me.lblQtdRequisicao.Name = "lblQtdRequisicao"
        Me.lblQtdRequisicao.Size = New System.Drawing.Size(86, 14)
        Me.lblQtdRequisicao.TabIndex = 50
        Me.lblQtdRequisicao.Text = "Qtd. Requisição:"
        '
        'lblObservacaoInterna
        '
        Me.lblObservacaoInterna.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblObservacaoInterna.AutoSize = True
        Me.lblObservacaoInterna.Location = New System.Drawing.Point(556, 139)
        Me.lblObservacaoInterna.Name = "lblObservacaoInterna"
        Me.lblObservacaoInterna.Size = New System.Drawing.Size(106, 14)
        Me.lblObservacaoInterna.TabIndex = 48
        Me.lblObservacaoInterna.Text = "Observação Interna:"
        '
        'txtObservacaoInterna
        '
        Me.txtObservacaoInterna.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacaoInterna.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacaoInterna.Location = New System.Drawing.Point(559, 155)
        Me.txtObservacaoInterna.MaxLength = 100
        Me.txtObservacaoInterna.Name = "txtObservacaoInterna"
        Me.txtObservacaoInterna.Size = New System.Drawing.Size(214, 20)
        Me.txtObservacaoInterna.TabIndex = 47
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.Location = New System.Drawing.Point(337, 139)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacao.TabIndex = 46
        Me.lblObservacao.Text = "Observação:"
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Location = New System.Drawing.Point(340, 155)
        Me.txtObservacao.MaxLength = 100
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(213, 20)
        Me.txtObservacao.TabIndex = 45
        '
        'cboGrupoItem
        '
        Me.cboGrupoItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboGrupoItem.AutoSize = False
        Me.cboGrupoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoItem.Location = New System.Drawing.Point(9, 34)
        Me.cboGrupoItem.Name = "cboGrupoItem"
        Me.cboGrupoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItem.ReadOnly = True
        Me.cboGrupoItem.Size = New System.Drawing.Size(325, 20)
        Me.cboGrupoItem.TabIndex = 1
        Me.cboGrupoItem.Tag = ""
        '
        'lblOrdemDeProducaoPai
        '
        Me.lblOrdemDeProducaoPai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOrdemDeProducaoPai.AutoSize = True
        Me.lblOrdemDeProducaoPai.Location = New System.Drawing.Point(492, 99)
        Me.lblOrdemDeProducaoPai.Name = "lblOrdemDeProducaoPai"
        Me.lblOrdemDeProducaoPai.Size = New System.Drawing.Size(123, 14)
        Me.lblOrdemDeProducaoPai.TabIndex = 41
        Me.lblOrdemDeProducaoPai.Text = "Ordem de Produção Pai:"
        '
        'btnFindGrupoItem
        '
        Me.btnFindGrupoItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFindGrupoItem.FlatAppearance.BorderSize = 0
        Me.btnFindGrupoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindGrupoItem.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnFindGrupoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFindGrupoItem.Location = New System.Drawing.Point(316, 17)
        Me.btnFindGrupoItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFindGrupoItem.Name = "btnFindGrupoItem"
        Me.btnFindGrupoItem.Size = New System.Drawing.Size(17, 16)
        Me.btnFindGrupoItem.TabIndex = 2
        Me.btnFindGrupoItem.TabStop = False
        Me.btnFindGrupoItem.Tag = ""
        Me.btnFindGrupoItem.UseVisualStyleBackColor = True
        '
        'cboOrdemDeProducaoPai
        '
        Me.cboOrdemDeProducaoPai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboOrdemDeProducaoPai.AutoSize = False
        Me.cboOrdemDeProducaoPai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOrdemDeProducaoPai.Location = New System.Drawing.Point(495, 116)
        Me.cboOrdemDeProducaoPai.Name = "cboOrdemDeProducaoPai"
        Me.cboOrdemDeProducaoPai.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboOrdemDeProducaoPai.Size = New System.Drawing.Size(148, 20)
        Me.cboOrdemDeProducaoPai.TabIndex = 9
        '
        'lblPartNumberPai
        '
        Me.lblPartNumberPai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPartNumberPai.AutoSize = True
        Me.lblPartNumberPai.Location = New System.Drawing.Point(337, 99)
        Me.lblPartNumberPai.Name = "lblPartNumberPai"
        Me.lblPartNumberPai.Size = New System.Drawing.Size(86, 14)
        Me.lblPartNumberPai.TabIndex = 39
        Me.lblPartNumberPai.Text = "Part Number Pai:"
        '
        'cboPartNumberPai
        '
        Me.cboPartNumberPai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPartNumberPai.AutoSize = False
        Me.cboPartNumberPai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPartNumberPai.Location = New System.Drawing.Point(340, 116)
        Me.cboPartNumberPai.Name = "cboPartNumberPai"
        Me.cboPartNumberPai.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPartNumberPai.Size = New System.Drawing.Size(149, 20)
        Me.cboPartNumberPai.TabIndex = 8
        '
        'lblGrupoItem
        '
        Me.lblGrupoItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGrupoItem.AutoSize = True
        Me.lblGrupoItem.BackColor = System.Drawing.Color.Transparent
        Me.lblGrupoItem.ForeColor = System.Drawing.Color.Firebrick
        Me.lblGrupoItem.Location = New System.Drawing.Point(6, 17)
        Me.lblGrupoItem.Name = "lblGrupoItem"
        Me.lblGrupoItem.Size = New System.Drawing.Size(62, 14)
        Me.lblGrupoItem.TabIndex = 42
        Me.lblGrupoItem.Tag = ""
        Me.lblGrupoItem.Text = "Grupo Item:"
        '
        'txtQuantidadeAberto
        '
        Me.txtQuantidadeAberto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeAberto.DecimalDigits = 4
        Me.txtQuantidadeAberto.Location = New System.Drawing.Point(9, 76)
        Me.txtQuantidadeAberto.MaxLength = 0
        Me.txtQuantidadeAberto.Name = "txtQuantidadeAberto"
        Me.txtQuantidadeAberto.ReadOnly = True
        Me.txtQuantidadeAberto.Size = New System.Drawing.Size(112, 20)
        SuperTipSettings1.HeaderText = "Quantidade em Aberto"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = "Σ Quantidade de Pedido de Compra em Trânsito."
        Me.jstTip.SetSuperTip(Me.txtQuantidadeAberto, SuperTipSettings1)
        Me.txtQuantidadeAberto.TabIndex = 6
        Me.txtQuantidadeAberto.TabStop = False
        Me.txtQuantidadeAberto.Text = "0,0000"
        Me.txtQuantidadeAberto.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeAberto
        '
        Me.lblQuantidadeAberto.AutoSize = True
        Me.lblQuantidadeAberto.Location = New System.Drawing.Point(29, 60)
        Me.lblQuantidadeAberto.Name = "lblQuantidadeAberto"
        Me.lblQuantidadeAberto.Size = New System.Drawing.Size(71, 14)
        SuperTipSettings2.HeaderText = "Quantidade em Aberto"
        SuperTipSettings2.ImageListProvider = Nothing
        SuperTipSettings2.Text = "Σ Quantidade de Pedido de Compra em Trânsito."
        Me.jstTip.SetSuperTip(Me.lblQuantidadeAberto, SuperTipSettings2)
        Me.lblQuantidadeAberto.TabIndex = 19
        Me.lblQuantidadeAberto.Text = "Qtde. Aberto:"
        '
        'dtpDataNecessidadeItem
        '
        Me.dtpDataNecessidadeItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataNecessidadeItem.DropDownCalendar.Name = ""
        Me.dtpDataNecessidadeItem.Location = New System.Drawing.Point(649, 116)
        Me.dtpDataNecessidadeItem.Name = "dtpDataNecessidadeItem"
        Me.dtpDataNecessidadeItem.ShowCheckBox = True
        Me.dtpDataNecessidadeItem.Size = New System.Drawing.Size(124, 20)
        Me.dtpDataNecessidadeItem.TabIndex = 10
        '
        'lblCodigoItem
        '
        Me.lblCodigoItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodigoItem.AutoSize = True
        Me.lblCodigoItem.Location = New System.Drawing.Point(337, 17)
        Me.lblCodigoItem.Name = "lblCodigoItem"
        Me.lblCodigoItem.Size = New System.Drawing.Size(119, 14)
        Me.lblCodigoItem.TabIndex = 3
        Me.lblCodigoItem.Text = "Código Produto (Novo):"
        '
        'lblJustificativaItem
        '
        Me.lblJustificativaItem.AutoSize = True
        Me.lblJustificativaItem.Location = New System.Drawing.Point(337, 179)
        Me.lblJustificativaItem.Name = "lblJustificativaItem"
        Me.lblJustificativaItem.Size = New System.Drawing.Size(67, 14)
        Me.lblJustificativaItem.TabIndex = 34
        Me.lblJustificativaItem.Text = "Justificativa:"
        '
        'cboContaContabilItem
        '
        Me.cboContaContabilItem.AutoSize = False
        Me.cboContaContabilItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabilItem.Location = New System.Drawing.Point(9, 196)
        Me.cboContaContabilItem.Name = "cboContaContabilItem"
        Me.cboContaContabilItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabilItem.Size = New System.Drawing.Size(325, 20)
        Me.cboContaContabilItem.TabIndex = 13
        '
        'lblContaContabilItem
        '
        Me.lblContaContabilItem.AutoSize = True
        Me.lblContaContabilItem.Location = New System.Drawing.Point(25, 179)
        Me.lblContaContabilItem.Name = "lblContaContabilItem"
        Me.lblContaContabilItem.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabilItem.TabIndex = 31
        Me.lblContaContabilItem.Text = "Conta Contábil:"
        '
        'lblCentroGastoItem
        '
        Me.lblCentroGastoItem.AutoSize = True
        Me.lblCentroGastoItem.BackColor = System.Drawing.Color.Transparent
        Me.lblCentroGastoItem.Location = New System.Drawing.Point(25, 139)
        Me.lblCentroGastoItem.Name = "lblCentroGastoItem"
        Me.lblCentroGastoItem.Size = New System.Drawing.Size(89, 14)
        Me.lblCentroGastoItem.TabIndex = 27
        Me.lblCentroGastoItem.Text = "Centro de Gasto:"
        '
        'cboCentroGastoItem
        '
        Me.cboCentroGastoItem.AutoSize = False
        Me.cboCentroGastoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboCentroGastoItem.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboCentroGastoItem.Location = New System.Drawing.Point(9, 156)
        Me.cboCentroGastoItem.Name = "cboCentroGastoItem"
        Me.cboCentroGastoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroGastoItem.Size = New System.Drawing.Size(325, 20)
        Me.cboCentroGastoItem.TabIndex = 12
        '
        'lblComplementoItem
        '
        Me.lblComplementoItem.AutoSize = True
        Me.lblComplementoItem.Location = New System.Drawing.Point(6, 99)
        Me.lblComplementoItem.Name = "lblComplementoItem"
        Me.lblComplementoItem.Size = New System.Drawing.Size(74, 14)
        Me.lblComplementoItem.TabIndex = 12
        Me.lblComplementoItem.Text = "Complemento:"
        '
        'txtComplementoItem
        '
        Me.txtComplementoItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComplementoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplementoItem.Location = New System.Drawing.Point(9, 116)
        Me.txtComplementoItem.MaxLength = 100
        Me.txtComplementoItem.Name = "txtComplementoItem"
        Me.txtComplementoItem.Size = New System.Drawing.Size(325, 20)
        Me.txtComplementoItem.TabIndex = 7
        '
        'lblDataNecessidadeItem
        '
        Me.lblDataNecessidadeItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataNecessidadeItem.AutoSize = True
        Me.lblDataNecessidadeItem.Location = New System.Drawing.Point(646, 99)
        Me.lblDataNecessidadeItem.Name = "lblDataNecessidadeItem"
        Me.lblDataNecessidadeItem.Size = New System.Drawing.Size(98, 14)
        Me.lblDataNecessidadeItem.TabIndex = 24
        Me.lblDataNecessidadeItem.Text = "Data Necessidade:"
        '
        'lblUnidadeMedidaItem
        '
        Me.lblUnidadeMedidaItem.AutoSize = True
        Me.lblUnidadeMedidaItem.ForeColor = System.Drawing.Color.Firebrick
        Me.lblUnidadeMedidaItem.Location = New System.Drawing.Point(228, 60)
        Me.lblUnidadeMedidaItem.Name = "lblUnidadeMedidaItem"
        Me.lblUnidadeMedidaItem.Size = New System.Drawing.Size(58, 14)
        Me.lblUnidadeMedidaItem.TabIndex = 22
        Me.lblUnidadeMedidaItem.Text = "Und. Med.:"
        '
        'cboUnidadeMedidaItem
        '
        Me.cboUnidadeMedidaItem.AutoSize = False
        Me.cboUnidadeMedidaItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedidaItem.Location = New System.Drawing.Point(231, 76)
        Me.cboUnidadeMedidaItem.Name = "cboUnidadeMedidaItem"
        Me.cboUnidadeMedidaItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedidaItem.Size = New System.Drawing.Size(102, 20)
        Me.cboUnidadeMedidaItem.TabIndex = 11
        '
        'txtQuantidadeItem
        '
        Me.txtQuantidadeItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeItem.DecimalDigits = 4
        Me.txtQuantidadeItem.Location = New System.Drawing.Point(340, 76)
        Me.txtQuantidadeItem.MaxLength = 0
        Me.txtQuantidadeItem.Name = "txtQuantidadeItem"
        Me.txtQuantidadeItem.ReadOnly = True
        Me.txtQuantidadeItem.Size = New System.Drawing.Size(84, 20)
        Me.txtQuantidadeItem.TabIndex = 5
        Me.txtQuantidadeItem.Text = "0,0000"
        Me.txtQuantidadeItem.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeItem
        '
        Me.lblQuantidadeItem.AutoSize = True
        Me.lblQuantidadeItem.ForeColor = System.Drawing.Color.Firebrick
        Me.lblQuantidadeItem.Location = New System.Drawing.Point(337, 60)
        Me.lblQuantidadeItem.Name = "lblQuantidadeItem"
        Me.lblQuantidadeItem.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeItem.TabIndex = 16
        Me.lblQuantidadeItem.Text = "Quantidade:"
        '
        'txtJustificativaItem
        '
        Me.txtJustificativaItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJustificativaItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJustificativaItem.Location = New System.Drawing.Point(340, 196)
        Me.txtJustificativaItem.MaxLength = 500
        Me.txtJustificativaItem.Multiline = True
        Me.txtJustificativaItem.Name = "txtJustificativaItem"
        Me.txtJustificativaItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJustificativaItem.Size = New System.Drawing.Size(433, 20)
        Me.txtJustificativaItem.TabIndex = 14
        '
        'btnProcurarContaContabil
        '
        Me.btnProcurarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnProcurarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarContaContabil.Location = New System.Drawing.Point(317, 178)
        Me.btnProcurarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarContaContabil.Name = "btnProcurarContaContabil"
        Me.btnProcurarContaContabil.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarContaContabil.TabIndex = 32
        Me.btnProcurarContaContabil.TabStop = False
        Me.btnProcurarContaContabil.UseVisualStyleBackColor = True
        '
        'btnQuantidadeAberto
        '
        Me.btnQuantidadeAberto.FlatAppearance.BorderSize = 0
        Me.btnQuantidadeAberto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuantidadeAberto.Image = Global.INTERACTI.My.Resources.Resources.grid
        Me.btnQuantidadeAberto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnQuantidadeAberto.Location = New System.Drawing.Point(9, 57)
        Me.btnQuantidadeAberto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnQuantidadeAberto.Name = "btnQuantidadeAberto"
        Me.btnQuantidadeAberto.Size = New System.Drawing.Size(17, 16)
        SuperTipSettings3.HeaderText = "Quantidade em Aberto"
        SuperTipSettings3.ImageListProvider = Nothing
        SuperTipSettings3.Text = "Σ Quantidade de Pedido de Compra em Trânsito."
        Me.jstTip.SetSuperTip(Me.btnQuantidadeAberto, SuperTipSettings3)
        Me.btnQuantidadeAberto.TabIndex = 18
        Me.btnQuantidadeAberto.TabStop = False
        Me.btnQuantidadeAberto.UseVisualStyleBackColor = True
        '
        'btnProcurarCentroGasto
        '
        Me.btnProcurarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnProcurarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCentroGasto.Location = New System.Drawing.Point(317, 138)
        Me.btnProcurarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCentroGasto.Name = "btnProcurarCentroGasto"
        Me.btnProcurarCentroGasto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCentroGasto.TabIndex = 28
        Me.btnProcurarCentroGasto.TabStop = False
        Me.btnProcurarCentroGasto.UseVisualStyleBackColor = True
        '
        'btnCadastrarCentroGastoItem
        '
        Me.btnCadastrarCentroGastoItem.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroGastoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroGastoItem.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCentroGastoItem.Location = New System.Drawing.Point(9, 140)
        Me.btnCadastrarCentroGastoItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroGastoItem.Name = "btnCadastrarCentroGastoItem"
        Me.btnCadastrarCentroGastoItem.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroGastoItem.TabIndex = 26
        Me.btnCadastrarCentroGastoItem.TabStop = False
        Me.btnCadastrarCentroGastoItem.UseVisualStyleBackColor = True
        '
        'btnCadastrarContaContabilItem
        '
        Me.btnCadastrarContaContabilItem.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaContabilItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaContabilItem.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaContabilItem.Location = New System.Drawing.Point(9, 180)
        Me.btnCadastrarContaContabilItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaContabilItem.Name = "btnCadastrarContaContabilItem"
        Me.btnCadastrarContaContabilItem.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaContabilItem.TabIndex = 30
        Me.btnCadastrarContaContabilItem.TabStop = False
        Me.btnCadastrarContaContabilItem.UseVisualStyleBackColor = True
        '
        'btnCadastrarUnidadeMedidaItem
        '
        Me.btnCadastrarUnidadeMedidaItem.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUnidadeMedidaItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUnidadeMedidaItem.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarUnidadeMedidaItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUnidadeMedidaItem.Location = New System.Drawing.Point(320, 60)
        Me.btnCadastrarUnidadeMedidaItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUnidadeMedidaItem.Name = "btnCadastrarUnidadeMedidaItem"
        Me.btnCadastrarUnidadeMedidaItem.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarUnidadeMedidaItem.TabIndex = 21
        Me.btnCadastrarUnidadeMedidaItem.TabStop = False
        Me.btnCadastrarUnidadeMedidaItem.UseVisualStyleBackColor = True
        '
        'btnExcluirItem
        '
        Me.btnExcluirItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirItem.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirItem.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirItem.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirItem.Location = New System.Drawing.Point(779, 143)
        Me.btnExcluirItem.Name = "btnExcluirItem"
        Me.btnExcluirItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirItem.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirItem.TabIndex = 16
        Me.btnExcluirItem.Text = "Excluir"
        Me.btnExcluirItem.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirItem
        '
        Me.btnInserirItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirItem.Image = CType(resources.GetObject("btnInserirItem.Image"), System.Drawing.Image)
        Me.btnInserirItem.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirItem.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirItem.Location = New System.Drawing.Point(779, 114)
        Me.btnInserirItem.Name = "btnInserirItem"
        Me.btnInserirItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirItem.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirItem.TabIndex = 15
        Me.btnInserirItem.Text = "Inserir"
        Me.btnInserirItem.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtCodigoProdutoNovo
        '
        Me.txtCodigoProdutoNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigoProdutoNovo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigoProdutoNovo.Location = New System.Drawing.Point(340, 34)
        Me.txtCodigoProdutoNovo.Name = "txtCodigoProdutoNovo"
        Me.txtCodigoProdutoNovo.ReadOnly = True
        Me.txtCodigoProdutoNovo.Size = New System.Drawing.Size(149, 20)
        Me.txtCodigoProdutoNovo.TabIndex = 66
        '
        'cboItem
        '
        Me.cboItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboItem.AutoSize = False
        Me.cboItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboItem.Location = New System.Drawing.Point(340, 34)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboItem.ReadOnly = True
        Me.cboItem.Size = New System.Drawing.Size(149, 20)
        Me.cboItem.TabIndex = 3
        '
        'pagArquivo
        '
        Me.pagArquivo.Controls.Add(Me.grdArquivo)
        Me.pagArquivo.Controls.Add(Me.grpArquivo)
        Me.pagArquivo.Key = "pagArquivo"
        Me.pagArquivo.Location = New System.Drawing.Point(1, 22)
        Me.pagArquivo.Name = "pagArquivo"
        Me.pagArquivo.Size = New System.Drawing.Size(895, 385)
        Me.pagArquivo.TabStop = True
        Me.pagArquivo.Text = "Arquivos"
        '
        'grdArquivo
        '
        Me.grdArquivo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdArquivo.AlternatingColors = True
        Me.grdArquivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdArquivo.ColumnAutoResize = True
        grdArquivo_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdArquivo_DesignTimeLayout_Reference_0.Instance"), Object)
        grdArquivo_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdArquivo_DesignTimeLayout_Reference_0})
        grdArquivo_DesignTimeLayout.LayoutString = resources.GetString("grdArquivo_DesignTimeLayout.LayoutString")
        Me.grdArquivo.DesignTimeLayout = grdArquivo_DesignTimeLayout
        Me.grdArquivo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdArquivo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdArquivo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdArquivo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdArquivo.FrozenColumns = 3
        Me.grdArquivo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdArquivo.GroupByBoxVisible = False
        Me.grdArquivo.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdArquivo.Location = New System.Drawing.Point(8, 113)
        Me.grdArquivo.Name = "grdArquivo"
        Me.grdArquivo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdArquivo.RecordNavigator = True
        Me.grdArquivo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdArquivo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdArquivo.Size = New System.Drawing.Size(879, 269)
        Me.grdArquivo.TabIndex = 4
        Me.grdArquivo.TabStop = False
        Me.grdArquivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdArquivo.VisualStyleManager = Me.vsmMain
        '
        'grpArquivo
        '
        Me.grpArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpArquivo.Controls.Add(Me.btnArquivo)
        Me.grpArquivo.Controls.Add(Me.lblArquivo)
        Me.grpArquivo.Controls.Add(Me.txtArquivo)
        Me.grpArquivo.Controls.Add(Me.txtTituloArquivo)
        Me.grpArquivo.Controls.Add(Me.lblTituloArquivo)
        Me.grpArquivo.Controls.Add(Me.btnExcluirArquivo)
        Me.grpArquivo.Controls.Add(Me.btnInserirArquivo)
        Me.grpArquivo.Location = New System.Drawing.Point(8, 3)
        Me.grpArquivo.Name = "grpArquivo"
        Me.grpArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpArquivo.Size = New System.Drawing.Size(879, 104)
        Me.grpArquivo.TabIndex = 0
        Me.grpArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpArquivo.VisualStyleManager = Me.vsmMain
        '
        'btnArquivo
        '
        Me.btnArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnArquivo.Location = New System.Drawing.Point(742, 71)
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivo.Size = New System.Drawing.Size(20, 20)
        Me.btnArquivo.TabIndex = 2
        Me.btnArquivo.Text = "..."
        Me.btnArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivo
        '
        Me.lblArquivo.AutoSize = True
        Me.lblArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblArquivo.Location = New System.Drawing.Point(6, 54)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(48, 14)
        Me.lblArquivo.TabIndex = 15
        Me.lblArquivo.Text = "Arquivo:"
        '
        'txtArquivo
        '
        Me.txtArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivo.Location = New System.Drawing.Point(9, 71)
        Me.txtArquivo.MaxLength = 500
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(753, 20)
        Me.txtArquivo.TabIndex = 1
        Me.txtArquivo.TabStop = False
        '
        'txtTituloArquivo
        '
        Me.txtTituloArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTituloArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTituloArquivo.Location = New System.Drawing.Point(9, 34)
        Me.txtTituloArquivo.MaxLength = 100
        Me.txtTituloArquivo.Name = "txtTituloArquivo"
        Me.txtTituloArquivo.Size = New System.Drawing.Size(751, 20)
        Me.txtTituloArquivo.TabIndex = 0
        '
        'lblTituloArquivo
        '
        Me.lblTituloArquivo.AutoSize = True
        Me.lblTituloArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTituloArquivo.Location = New System.Drawing.Point(6, 17)
        Me.lblTituloArquivo.Name = "lblTituloArquivo"
        Me.lblTituloArquivo.Size = New System.Drawing.Size(35, 14)
        Me.lblTituloArquivo.TabIndex = 13
        Me.lblTituloArquivo.Text = "Titulo:"
        '
        'btnExcluirArquivo
        '
        Me.btnExcluirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirArquivo.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirArquivo.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirArquivo.Location = New System.Drawing.Point(779, 71)
        Me.btnExcluirArquivo.Name = "btnExcluirArquivo"
        Me.btnExcluirArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirArquivo.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirArquivo.TabIndex = 4
        Me.btnExcluirArquivo.Text = "Excluir"
        Me.btnExcluirArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirArquivo
        '
        Me.btnInserirArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirArquivo.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirArquivo.Location = New System.Drawing.Point(779, 42)
        Me.btnInserirArquivo.Name = "btnInserirArquivo"
        Me.btnInserirArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirArquivo.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirArquivo.TabIndex = 3
        Me.btnInserirArquivo.Text = "Inserir"
        Me.btnInserirArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'usrCmpRequisicao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCmpRequisicao"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaEntregaEfetuada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaPedidoCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaCotando, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaAprovado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaAguardandoAprovacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpDadosRequisicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosRequisicao.ResumeLayout(False)
        Me.grpDadosRequisicao.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagItem.ResumeLayout(False)
        CType(Me.grdItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItem.ResumeLayout(False)
        Me.grpItem.PerformLayout()
        Me.pagArquivo.ResumeLayout(False)
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDadosRequisicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblRequisitante As System.Windows.Forms.Label
    Friend WithEvents lblNumeroRequisicao As System.Windows.Forms.Label
    Friend WithEvents cboRequisitante As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroRequisicao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblItemFiltro As System.Windows.Forms.Label
    Friend WithEvents txtItemFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroRequisicaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblStatusRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpItem As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCentroGastoItem As System.Windows.Forms.Label
    Friend WithEvents cboCentroGastoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblComplementoItem As System.Windows.Forms.Label
    Friend WithEvents txtComplementoItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataNecessidadeItem As System.Windows.Forms.Label
    Friend WithEvents lblUnidadeMedidaItem As System.Windows.Forms.Label
    Friend WithEvents cboUnidadeMedidaItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtQuantidadeItem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeItem As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarUnidadeMedidaItem As System.Windows.Forms.Button
    Friend WithEvents btnExcluirItem As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirItem As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCadastrarContaContabilItem As System.Windows.Forms.Button
    Friend WithEvents cboContaContabilItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblContaContabilItem As System.Windows.Forms.Label
    Friend WithEvents lblJustificativaItem As System.Windows.Forms.Label
    Friend WithEvents txtJustificativaItem As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents btnCadastrarCentroGastoItem As System.Windows.Forms.Button
    Friend WithEvents grdItem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoItem As System.Windows.Forms.Label
    Friend WithEvents dtpDataRequisicaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataRequisicaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataNecessidadeItem As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnProcurarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagItem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagArquivo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents txtQuantidadeAberto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeAberto As System.Windows.Forms.Label
    Friend WithEvents btnQuantidadeAberto As System.Windows.Forms.Button
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnProcurarContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnProcurarItemFiltro As System.Windows.Forms.Button
    Friend WithEvents cboAprovadorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblAprovadorFiltro As System.Windows.Forms.Label
    Friend WithEvents cboRequisitanteFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblRequisitanteFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatusRequisicaoFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaEntregaEfetuada As System.Windows.Forms.Label
    Friend WithEvents picLegendaEntregaEfetuada As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCancelado As System.Windows.Forms.Label
    Friend WithEvents picLegendaCancelado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaPedidoCompra As System.Windows.Forms.Label
    Friend WithEvents picLegendaPedidoCompra As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCotando As System.Windows.Forms.Label
    Friend WithEvents picLegendaCotando As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAprovado As System.Windows.Forms.Label
    Friend WithEvents picLegendaAprovado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAguardandoAprovacao As System.Windows.Forms.Label
    Friend WithEvents picLegendaAguardandoAprovacao As System.Windows.Forms.PictureBox
    Friend WithEvents grpArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCongelarColunaItem As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColunaItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblOrdemDeProducaoPai As System.Windows.Forms.Label
    Friend WithEvents cboOrdemDeProducaoPai As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblPartNumberPai As System.Windows.Forms.Label
    Friend WithEvents cboPartNumberPai As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboGrupoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnFindGrupoItem As System.Windows.Forms.Button
    Friend WithEvents lblGrupoItem As System.Windows.Forms.Label
    Friend WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtTituloArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTituloArquivo As System.Windows.Forms.Label
    Friend WithEvents grdArquivo As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblObservacaoInterna As Label
    Friend WithEvents txtObservacaoInterna As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblObservacao As Label
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtQtdRequisicao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQtdRequisicao As Label
    Friend WithEvents txtMedida1 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMedida3 As Label
    Friend WithEvents txtMedida2 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtMedida3 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMedida2 As Label
    Friend WithEvents lblMedida4 As Label
    Friend WithEvents txtMedida4 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMedida1 As Label
    Friend WithEvents lblDescricao As Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPesoEspecifico As Label
    Friend WithEvents txtPesoEspecifico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtPeso As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPeso As Label
    Friend WithEvents txtCodigoProdutoNovo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnOcultarExibir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovoItem As Janus.Windows.EditControls.UIButton
End Class
