<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrEstRequisicaoPagar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrEstRequisicaoPagar))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpEntrega = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.cboFuncionario = New Janus.Windows.EditControls.UIComboBox()
        Me.lblQuantidadeRequisicao = New System.Windows.Forms.Label()
        Me.txtQuantidadeRequisicao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnPagarRequisicao = New Janus.Windows.EditControls.UIButton()
        Me.txtLocalizacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblLocalizacao = New System.Windows.Forms.Label()
        Me.lblQuantidadeEstoque = New System.Windows.Forms.Label()
        Me.txtQuantidadeEstoque = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.cboLote = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.cboDeposito = New Janus.Windows.EditControls.UIComboBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataNecessidadeTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataNecessidadeInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataRequisicaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataRequisicaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataNecessidadeFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblProdutoFiltro = New System.Windows.Forms.Label()
        Me.txtProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroRequisicaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.lblDataRequisicaoFiltro = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.lblCodigoProdutoAlternativo = New System.Windows.Forms.Label()
        Me.cboCodigoProdutoAlternativo = New Janus.Windows.EditControls.UIComboBox()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEntrega.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(1030, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.grpEntrega)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControl)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 24)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(1028, 541)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Requisição de Estoque - Pagar"
        '
        'grpEntrega
        '
        Me.grpEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEntrega.BackColor = System.Drawing.Color.Transparent
        Me.grpEntrega.Controls.Add(Me.lblFuncionario)
        Me.grpEntrega.Controls.Add(Me.cboFuncionario)
        Me.grpEntrega.Controls.Add(Me.lblQuantidadeRequisicao)
        Me.grpEntrega.Controls.Add(Me.txtQuantidadeRequisicao)
        Me.grpEntrega.Controls.Add(Me.btnPagarRequisicao)
        Me.grpEntrega.Controls.Add(Me.txtLocalizacao)
        Me.grpEntrega.Controls.Add(Me.lblLocalizacao)
        Me.grpEntrega.Controls.Add(Me.lblQuantidadeEstoque)
        Me.grpEntrega.Controls.Add(Me.txtQuantidadeEstoque)
        Me.grpEntrega.Controls.Add(Me.lblLote)
        Me.grpEntrega.Controls.Add(Me.cboLote)
        Me.grpEntrega.Controls.Add(Me.lblDeposito)
        Me.grpEntrega.Controls.Add(Me.cboDeposito)
        Me.grpEntrega.Controls.Add(Me.lblQuantidade)
        Me.grpEntrega.Controls.Add(Me.txtQuantidade)
        Me.grpEntrega.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEntrega.Location = New System.Drawing.Point(8, 414)
        Me.grpEntrega.Name = "grpEntrega"
        Me.grpEntrega.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEntrega.Size = New System.Drawing.Size(1012, 64)
        Me.grpEntrega.TabIndex = 0
        Me.grpEntrega.VisualStyleManager = Me.vsmMain
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFuncionario.Location = New System.Drawing.Point(9, 17)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(141, 16)
        Me.lblFuncionario.TabIndex = 15
        Me.lblFuncionario.Text = "Funcionário a Pagar:"
        '
        'cboFuncionario
        '
        Me.cboFuncionario.AutoSize = False
        Me.cboFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFuncionario.Location = New System.Drawing.Point(12, 34)
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFuncionario.Size = New System.Drawing.Size(125, 20)
        Me.cboFuncionario.TabIndex = 0
        '
        'lblQuantidadeRequisicao
        '
        Me.lblQuantidadeRequisicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeRequisicao.AutoSize = True
        Me.lblQuantidadeRequisicao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeRequisicao.Location = New System.Drawing.Point(541, 17)
        Me.lblQuantidadeRequisicao.Name = "lblQuantidadeRequisicao"
        Me.lblQuantidadeRequisicao.Size = New System.Drawing.Size(121, 16)
        Me.lblQuantidadeRequisicao.TabIndex = 13
        Me.lblQuantidadeRequisicao.Text = "Qtde. Requisição:"
        '
        'txtQuantidadeRequisicao
        '
        Me.txtQuantidadeRequisicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeRequisicao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeRequisicao.DecimalDigits = 6
        Me.txtQuantidadeRequisicao.Location = New System.Drawing.Point(544, 34)
        Me.txtQuantidadeRequisicao.Name = "txtQuantidadeRequisicao"
        Me.txtQuantidadeRequisicao.ReadOnly = True
        Me.txtQuantidadeRequisicao.Size = New System.Drawing.Size(90, 23)
        Me.txtQuantidadeRequisicao.TabIndex = 4
        Me.txtQuantidadeRequisicao.TabStop = False
        Me.txtQuantidadeRequisicao.Text = "0,000000"
        Me.txtQuantidadeRequisicao.Value = New Decimal(New Integer() {0, 0, 0, 393216})
        '
        'btnPagarRequisicao
        '
        Me.btnPagarRequisicao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPagarRequisicao.Image = CType(resources.GetObject("btnPagarRequisicao.Image"), System.Drawing.Image)
        Me.btnPagarRequisicao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPagarRequisicao.Location = New System.Drawing.Point(912, 31)
        Me.btnPagarRequisicao.Name = "btnPagarRequisicao"
        Me.btnPagarRequisicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPagarRequisicao.Size = New System.Drawing.Size(91, 23)
        Me.btnPagarRequisicao.TabIndex = 7
        Me.btnPagarRequisicao.Text = "Pagar"
        Me.btnPagarRequisicao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtLocalizacao
        '
        Me.txtLocalizacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLocalizacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLocalizacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocalizacao.Location = New System.Drawing.Point(308, 34)
        Me.txtLocalizacao.MaxLength = 50
        Me.txtLocalizacao.Name = "txtLocalizacao"
        Me.txtLocalizacao.ReadOnly = True
        Me.txtLocalizacao.Size = New System.Drawing.Size(80, 23)
        Me.txtLocalizacao.TabIndex = 2
        Me.txtLocalizacao.TabStop = False
        Me.txtLocalizacao.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblLocalizacao
        '
        Me.lblLocalizacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLocalizacao.AutoSize = True
        Me.lblLocalizacao.Location = New System.Drawing.Point(305, 17)
        Me.lblLocalizacao.Name = "lblLocalizacao"
        Me.lblLocalizacao.Size = New System.Drawing.Size(86, 16)
        Me.lblLocalizacao.TabIndex = 4
        Me.lblLocalizacao.Text = "Localização:"
        '
        'lblQuantidadeEstoque
        '
        Me.lblQuantidadeEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeEstoque.AutoSize = True
        Me.lblQuantidadeEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeEstoque.Location = New System.Drawing.Point(637, 17)
        Me.lblQuantidadeEstoque.Name = "lblQuantidadeEstoque"
        Me.lblQuantidadeEstoque.Size = New System.Drawing.Size(103, 16)
        Me.lblQuantidadeEstoque.TabIndex = 8
        Me.lblQuantidadeEstoque.Text = "Qtde. Estoque:"
        '
        'txtQuantidadeEstoque
        '
        Me.txtQuantidadeEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeEstoque.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeEstoque.DecimalDigits = 6
        Me.txtQuantidadeEstoque.Location = New System.Drawing.Point(640, 34)
        Me.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque"
        Me.txtQuantidadeEstoque.ReadOnly = True
        Me.txtQuantidadeEstoque.Size = New System.Drawing.Size(75, 23)
        Me.txtQuantidadeEstoque.TabIndex = 5
        Me.txtQuantidadeEstoque.TabStop = False
        Me.txtQuantidadeEstoque.Text = "0,000000"
        Me.txtQuantidadeEstoque.Value = New Decimal(New Integer() {0, 0, 0, 393216})
        '
        'lblLote
        '
        Me.lblLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLote.AutoSize = True
        Me.lblLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLote.Location = New System.Drawing.Point(391, 17)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(40, 16)
        Me.lblLote.TabIndex = 6
        Me.lblLote.Text = "Lote:"
        '
        'cboLote
        '
        Me.cboLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboLote.AutoSize = False
        Me.cboLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboLote.Location = New System.Drawing.Point(394, 34)
        Me.cboLote.Name = "cboLote"
        Me.cboLote.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboLote.Size = New System.Drawing.Size(144, 20)
        Me.cboLote.TabIndex = 3
        '
        'lblDeposito
        '
        Me.lblDeposito.AutoSize = True
        Me.lblDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDeposito.Location = New System.Drawing.Point(140, 17)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(68, 16)
        Me.lblDeposito.TabIndex = 2
        Me.lblDeposito.Text = "Depósito:"
        '
        'cboDeposito
        '
        Me.cboDeposito.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDeposito.AutoSize = False
        Me.cboDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDeposito.Location = New System.Drawing.Point(143, 34)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDeposito.Size = New System.Drawing.Size(159, 20)
        Me.cboDeposito.TabIndex = 1
        '
        'lblQuantidade
        '
        Me.lblQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidade.Location = New System.Drawing.Point(718, 17)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(86, 16)
        Me.lblQuantidade.TabIndex = 10
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidade.DecimalDigits = 6
        Me.txtQuantidade.Location = New System.Drawing.Point(721, 34)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(62, 23)
        Me.txtQuantidade.TabIndex = 6
        Me.txtQuantidade.Text = "0,000000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 393216})
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.dtpDataNecessidadeTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataNecessidadeInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataRequisicaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataRequisicaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataNecessidadeFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroRequisicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataRequisicaoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(1012, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'dtpDataNecessidadeTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataNecessidadeTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataNecessidadeTerminoFiltro.Location = New System.Drawing.Point(581, 34)
        Me.dtpDataNecessidadeTerminoFiltro.Name = "dtpDataNecessidadeTerminoFiltro"
        Me.dtpDataNecessidadeTerminoFiltro.ShowCheckBox = True
        Me.dtpDataNecessidadeTerminoFiltro.Size = New System.Drawing.Size(108, 23)
        Me.dtpDataNecessidadeTerminoFiltro.TabIndex = 15
        Me.dtpDataNecessidadeTerminoFiltro.Value = New Date(2013, 1, 6, 0, 0, 0, 0)
        '
        'dtpDataNecessidadeInicioFiltro
        '
        '
        '
        '
        Me.dtpDataNecessidadeInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataNecessidadeInicioFiltro.Location = New System.Drawing.Point(467, 34)
        Me.dtpDataNecessidadeInicioFiltro.Name = "dtpDataNecessidadeInicioFiltro"
        Me.dtpDataNecessidadeInicioFiltro.ShowCheckBox = True
        Me.dtpDataNecessidadeInicioFiltro.Size = New System.Drawing.Size(108, 23)
        Me.dtpDataNecessidadeInicioFiltro.TabIndex = 14
        Me.dtpDataNecessidadeInicioFiltro.Value = New Date(2013, 1, 6, 0, 0, 0, 0)
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
        Me.dtpDataRequisicaoTerminoFiltro.Size = New System.Drawing.Size(108, 23)
        Me.dtpDataRequisicaoTerminoFiltro.TabIndex = 4
        Me.dtpDataRequisicaoTerminoFiltro.Value = New Date(2013, 1, 6, 0, 0, 0, 0)
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
        Me.dtpDataRequisicaoInicioFiltro.Size = New System.Drawing.Size(108, 23)
        Me.dtpDataRequisicaoInicioFiltro.TabIndex = 3
        Me.dtpDataRequisicaoInicioFiltro.Value = New Date(2013, 1, 6, 0, 0, 0, 0)
        '
        'lblDataNecessidadeFiltro
        '
        Me.lblDataNecessidadeFiltro.AutoSize = True
        Me.lblDataNecessidadeFiltro.Location = New System.Drawing.Point(464, 17)
        Me.lblDataNecessidadeFiltro.Name = "lblDataNecessidadeFiltro"
        Me.lblDataNecessidadeFiltro.Size = New System.Drawing.Size(147, 16)
        Me.lblDataNecessidadeFiltro.TabIndex = 13
        Me.lblDataNecessidadeFiltro.Text = "Data de Necessidade:"
        '
        'txtNumeroDocumentoFiltro
        '
        Me.txtNumeroDocumentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumentoFiltro.Location = New System.Drawing.Point(353, 34)
        Me.txtNumeroDocumentoFiltro.MaxLength = 8
        Me.txtNumeroDocumentoFiltro.Name = "txtNumeroDocumentoFiltro"
        Me.txtNumeroDocumentoFiltro.Size = New System.Drawing.Size(108, 23)
        Me.txtNumeroDocumentoFiltro.TabIndex = 8
        '
        'lblNumeroDocumentoFiltro
        '
        Me.lblNumeroDocumentoFiltro.AutoSize = True
        Me.lblNumeroDocumentoFiltro.Location = New System.Drawing.Point(350, 17)
        Me.lblNumeroDocumentoFiltro.Name = "lblNumeroDocumentoFiltro"
        Me.lblNumeroDocumentoFiltro.Size = New System.Drawing.Size(140, 16)
        Me.lblNumeroDocumentoFiltro.TabIndex = 7
        Me.lblNumeroDocumentoFiltro.Text = "Ordem de Produção:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(912, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 16
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblProdutoFiltro
        '
        Me.lblProdutoFiltro.AutoSize = True
        Me.lblProdutoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblProdutoFiltro.Name = "lblProdutoFiltro"
        Me.lblProdutoFiltro.Size = New System.Drawing.Size(62, 16)
        Me.lblProdutoFiltro.TabIndex = 11
        Me.lblProdutoFiltro.Text = "Produto:"
        '
        'txtProdutoFiltro
        '
        Me.txtProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtProdutoFiltro.MaxLength = 100
        Me.txtProdutoFiltro.Name = "txtProdutoFiltro"
        Me.txtProdutoFiltro.Size = New System.Drawing.Size(680, 23)
        Me.txtProdutoFiltro.TabIndex = 12
        '
        'txtNumeroRequisicaoFiltro
        '
        Me.txtNumeroRequisicaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRequisicaoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroRequisicaoFiltro.MaxLength = 8
        Me.txtNumeroRequisicaoFiltro.Name = "txtNumeroRequisicaoFiltro"
        Me.txtNumeroRequisicaoFiltro.Size = New System.Drawing.Size(108, 23)
        Me.txtNumeroRequisicaoFiltro.TabIndex = 1
        '
        'lblNumeroRequisicaoFiltro
        '
        Me.lblNumeroRequisicaoFiltro.AutoSize = True
        Me.lblNumeroRequisicaoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroRequisicaoFiltro.Name = "lblNumeroRequisicaoFiltro"
        Me.lblNumeroRequisicaoFiltro.Size = New System.Drawing.Size(100, 16)
        Me.lblNumeroRequisicaoFiltro.TabIndex = 0
        Me.lblNumeroRequisicaoFiltro.Text = "Nº Requisição:"
        '
        'lblDataRequisicaoFiltro
        '
        Me.lblDataRequisicaoFiltro.AutoSize = True
        Me.lblDataRequisicaoFiltro.Location = New System.Drawing.Point(120, 17)
        Me.lblDataRequisicaoFiltro.Name = "lblDataRequisicaoFiltro"
        Me.lblDataRequisicaoFiltro.Size = New System.Drawing.Size(136, 16)
        Me.lblDataRequisicaoFiltro.TabIndex = 2
        Me.lblDataRequisicaoFiltro.Text = "Data da Requisição:"
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.lblCodigoProdutoAlternativo)
        Me.grpControl.Controls.Add(Me.cboCodigoProdutoAlternativo)
        Me.grpControl.Location = New System.Drawing.Point(8, 481)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(1012, 51)
        Me.grpControl.TabIndex = 5
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(912, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblCodigoProdutoAlternativo
        '
        Me.lblCodigoProdutoAlternativo.AutoSize = True
        Me.lblCodigoProdutoAlternativo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProdutoAlternativo.Location = New System.Drawing.Point(86, 8)
        Me.lblCodigoProdutoAlternativo.Name = "lblCodigoProdutoAlternativo"
        Me.lblCodigoProdutoAlternativo.Size = New System.Drawing.Size(181, 16)
        Me.lblCodigoProdutoAlternativo.TabIndex = 0
        Me.lblCodigoProdutoAlternativo.Text = "Código Produto Alternativo:"
        Me.lblCodigoProdutoAlternativo.Visible = False
        '
        'cboCodigoProdutoAlternativo
        '
        Me.cboCodigoProdutoAlternativo.AutoSize = False
        Me.cboCodigoProdutoAlternativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCodigoProdutoAlternativo.Location = New System.Drawing.Point(89, 25)
        Me.cboCodigoProdutoAlternativo.Name = "cboCodigoProdutoAlternativo"
        Me.cboCodigoProdutoAlternativo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigoProdutoAlternativo.Size = New System.Drawing.Size(40, 20)
        Me.cboCodigoProdutoAlternativo.TabIndex = 1
        Me.cboCodigoProdutoAlternativo.Visible = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 1
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
        Me.grdListagem.Size = New System.Drawing.Size(1012, 292)
        Me.grdListagem.TabIndex = 6
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdListagem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.UpdateOnLeave = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'usrEstRequisicaoPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrEstRequisicaoPagar"
        Me.Size = New System.Drawing.Size(1030, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEntrega.ResumeLayout(False)
        Me.grpEntrega.PerformLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNumeroDocumentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroRequisicaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataRequisicaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblDataNecessidadeFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataNecessidadeTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataNecessidadeInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataRequisicaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataRequisicaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents grpEntrega As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents cboLote As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDeposito As System.Windows.Forms.Label
    Friend WithEvents cboDeposito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtLocalizacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblLocalizacao As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeEstoque As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeEstoque As Janus.Windows.GridEX.EditControls.NumericEditBox
    Private WithEvents btnPagarRequisicao As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCodigoProdutoAlternativo As System.Windows.Forms.Label
    Friend WithEvents cboCodigoProdutoAlternativo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblQuantidadeRequisicao As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeRequisicao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents cboFuncionario As Janus.Windows.EditControls.UIComboBox

End Class
