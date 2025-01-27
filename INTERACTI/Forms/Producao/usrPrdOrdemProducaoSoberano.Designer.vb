<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrdOrdemProducaoSoberano
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
        Dim JanusColorScheme3 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdOrdemProducaoSoberano))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpProduto = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtQuantidadeCarretel = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtQuantidadeBobina = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCodigoIntegracao = New System.Windows.Forms.Label()
        Me.txtCodigoIntegracao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCor = New System.Windows.Forms.Label()
        Me.cboCor = New Janus.Windows.EditControls.UIComboBox()
        Me.lblBitola = New System.Windows.Forms.Label()
        Me.cboBitola = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoProduto = New System.Windows.Forms.Label()
        Me.cboTipoProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOperador = New System.Windows.Forms.Label()
        Me.cboOperador = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMaquina = New System.Windows.Forms.Label()
        Me.cboMaquina = New Janus.Windows.EditControls.UIComboBox()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.txtLote = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataEmissao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.txtQuantidadeRolo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.jstMain = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.btnContext = New Janus.Windows.UI.CommandBars.UIContextMenu()
        Me.cmdManager = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.btnVisualizarHistorico = New Janus.Windows.UI.CommandBars.UICommand("btnVisualizarHistorico")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar()
        Me.btnVisualizarHistorico1 = New Janus.Windows.UI.CommandBars.UICommand("btnVisualizarHistorico")
        Me.lblQuantidadeRolo = New System.Windows.Forms.Label()
        Me.lblQuantidadeBobina = New System.Windows.Forms.Label()
        Me.lblQuantidadeCarretel = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProduto.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.btnContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme3.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme3.Name = "Scheme"
        JanusColorScheme3.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme3.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme3.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme3)
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
        Me.tabMain.Size = New System.Drawing.Size(639, 260)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpProduto)
        Me.pagDados.Controls.Add(Me.grpControl)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(637, 237)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados da Ordem de Produção"
        '
        'grpProduto
        '
        Me.grpProduto.BackColor = System.Drawing.Color.Transparent
        Me.grpProduto.Controls.Add(Me.lblQuantidadeCarretel)
        Me.grpProduto.Controls.Add(Me.lblQuantidadeBobina)
        Me.grpProduto.Controls.Add(Me.lblQuantidadeRolo)
        Me.grpProduto.Controls.Add(Me.txtQuantidadeCarretel)
        Me.grpProduto.Controls.Add(Me.txtQuantidadeBobina)
        Me.grpProduto.Controls.Add(Me.lblCodigoIntegracao)
        Me.grpProduto.Controls.Add(Me.txtCodigoIntegracao)
        Me.grpProduto.Controls.Add(Me.lblCor)
        Me.grpProduto.Controls.Add(Me.cboCor)
        Me.grpProduto.Controls.Add(Me.lblBitola)
        Me.grpProduto.Controls.Add(Me.cboBitola)
        Me.grpProduto.Controls.Add(Me.lblTipoProduto)
        Me.grpProduto.Controls.Add(Me.cboTipoProduto)
        Me.grpProduto.Controls.Add(Me.lblOperador)
        Me.grpProduto.Controls.Add(Me.cboOperador)
        Me.grpProduto.Controls.Add(Me.lblMaquina)
        Me.grpProduto.Controls.Add(Me.cboMaquina)
        Me.grpProduto.Controls.Add(Me.lblLote)
        Me.grpProduto.Controls.Add(Me.txtLote)
        Me.grpProduto.Controls.Add(Me.dtpDataEmissao)
        Me.grpProduto.Controls.Add(Me.lblDataEmissao)
        Me.grpProduto.Controls.Add(Me.txtQuantidadeRolo)
        Me.grpProduto.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpProduto.Location = New System.Drawing.Point(6, 9)
        Me.grpProduto.Name = "grpProduto"
        Me.grpProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpProduto.Size = New System.Drawing.Size(617, 158)
        Me.grpProduto.TabIndex = 0
        Me.grpProduto.Text = "Dados do Produto"
        Me.grpProduto.VisualStyleManager = Me.vsmMain
        '
        'txtQuantidadeCarretel
        '
        Me.txtQuantidadeCarretel.DecimalDigits = 0
        Me.txtQuantidadeCarretel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQuantidadeCarretel.Location = New System.Drawing.Point(211, 77)
        Me.txtQuantidadeCarretel.Name = "txtQuantidadeCarretel"
        Me.txtQuantidadeCarretel.Size = New System.Drawing.Size(95, 20)
        Me.txtQuantidadeCarretel.TabIndex = 13
        Me.txtQuantidadeCarretel.Text = "0"
        Me.txtQuantidadeCarretel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtQuantidadeBobina
        '
        Me.txtQuantidadeBobina.DecimalDigits = 0
        Me.txtQuantidadeBobina.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQuantidadeBobina.Location = New System.Drawing.Point(110, 77)
        Me.txtQuantidadeBobina.Name = "txtQuantidadeBobina"
        Me.txtQuantidadeBobina.Size = New System.Drawing.Size(95, 20)
        Me.txtQuantidadeBobina.TabIndex = 11
        Me.txtQuantidadeBobina.Text = "0"
        Me.txtQuantidadeBobina.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblCodigoIntegracao
        '
        Me.lblCodigoIntegracao.AutoSize = True
        Me.lblCodigoIntegracao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoIntegracao.Location = New System.Drawing.Point(464, 17)
        Me.lblCodigoIntegracao.Name = "lblCodigoIntegracao"
        Me.lblCodigoIntegracao.Size = New System.Drawing.Size(97, 14)
        Me.lblCodigoIntegracao.TabIndex = 6
        Me.lblCodigoIntegracao.Text = "Código Integração:"
        '
        'txtCodigoIntegracao
        '
        Me.txtCodigoIntegracao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigoIntegracao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoIntegracao.Location = New System.Drawing.Point(467, 34)
        Me.txtCodigoIntegracao.MaxLength = 500
        Me.txtCodigoIntegracao.Name = "txtCodigoIntegracao"
        Me.txtCodigoIntegracao.ReadOnly = True
        Me.txtCodigoIntegracao.Size = New System.Drawing.Size(136, 20)
        Me.txtCodigoIntegracao.TabIndex = 7
        Me.txtCodigoIntegracao.TabStop = False
        '
        'lblCor
        '
        Me.lblCor.AutoSize = True
        Me.lblCor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCor.Location = New System.Drawing.Point(344, 16)
        Me.lblCor.Name = "lblCor"
        Me.lblCor.Size = New System.Drawing.Size(27, 14)
        Me.lblCor.TabIndex = 4
        Me.lblCor.Text = "Cor:"
        '
        'cboCor
        '
        Me.cboCor.AutoSize = False
        Me.cboCor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCor.Location = New System.Drawing.Point(347, 33)
        Me.cboCor.Name = "cboCor"
        Me.cboCor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCor.Size = New System.Drawing.Size(114, 20)
        Me.cboCor.TabIndex = 5
        '
        'lblBitola
        '
        Me.lblBitola.AutoSize = True
        Me.lblBitola.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBitola.Location = New System.Drawing.Point(267, 16)
        Me.lblBitola.Name = "lblBitola"
        Me.lblBitola.Size = New System.Drawing.Size(36, 14)
        Me.lblBitola.TabIndex = 2
        Me.lblBitola.Text = "Bitola:"
        '
        'cboBitola
        '
        Me.cboBitola.AutoSize = False
        Me.cboBitola.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboBitola.Location = New System.Drawing.Point(270, 33)
        Me.cboBitola.Name = "cboBitola"
        Me.cboBitola.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboBitola.Size = New System.Drawing.Size(71, 20)
        Me.cboBitola.TabIndex = 3
        '
        'lblTipoProduto
        '
        Me.lblTipoProduto.AutoSize = True
        Me.lblTipoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoProduto.Location = New System.Drawing.Point(6, 16)
        Me.lblTipoProduto.Name = "lblTipoProduto"
        Me.lblTipoProduto.Size = New System.Drawing.Size(85, 14)
        Me.lblTipoProduto.TabIndex = 0
        Me.lblTipoProduto.Text = "Tipo de Produto:"
        '
        'cboTipoProduto
        '
        Me.cboTipoProduto.AutoSize = False
        Me.cboTipoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoProduto.Location = New System.Drawing.Point(9, 33)
        Me.cboTipoProduto.Name = "cboTipoProduto"
        Me.cboTipoProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoProduto.Size = New System.Drawing.Size(255, 20)
        Me.cboTipoProduto.TabIndex = 1
        '
        'lblOperador
        '
        Me.lblOperador.AutoSize = True
        Me.lblOperador.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOperador.Location = New System.Drawing.Point(237, 102)
        Me.lblOperador.Name = "lblOperador"
        Me.lblOperador.Size = New System.Drawing.Size(56, 14)
        Me.lblOperador.TabIndex = 18
        Me.lblOperador.Text = "Operador:"
        '
        'cboOperador
        '
        Me.cboOperador.AutoSize = False
        Me.cboOperador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOperador.Location = New System.Drawing.Point(240, 119)
        Me.cboOperador.Name = "cboOperador"
        Me.cboOperador.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboOperador.Size = New System.Drawing.Size(254, 20)
        Me.cboOperador.TabIndex = 19
        '
        'lblMaquina
        '
        Me.lblMaquina.AutoSize = True
        Me.lblMaquina.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaquina.Location = New System.Drawing.Point(6, 102)
        Me.lblMaquina.Name = "lblMaquina"
        Me.lblMaquina.Size = New System.Drawing.Size(50, 14)
        Me.lblMaquina.TabIndex = 16
        Me.lblMaquina.Text = "Máquina:"
        '
        'cboMaquina
        '
        Me.cboMaquina.AutoSize = False
        Me.cboMaquina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMaquina.Location = New System.Drawing.Point(9, 119)
        Me.cboMaquina.Name = "cboMaquina"
        Me.cboMaquina.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMaquina.Size = New System.Drawing.Size(225, 20)
        Me.cboMaquina.TabIndex = 17
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLote.Location = New System.Drawing.Point(309, 60)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(31, 14)
        Me.lblLote.TabIndex = 14
        Me.lblLote.Text = "Lote:"
        '
        'txtLote
        '
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Location = New System.Drawing.Point(312, 77)
        Me.txtLote.MaxLength = 500
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(291, 20)
        Me.txtLote.TabIndex = 15
        '
        'dtpDataEmissao
        '
        '
        '
        '
        Me.dtpDataEmissao.DropDownCalendar.Name = ""
        Me.dtpDataEmissao.Location = New System.Drawing.Point(500, 119)
        Me.dtpDataEmissao.Name = "dtpDataEmissao"
        Me.dtpDataEmissao.Size = New System.Drawing.Size(103, 20)
        Me.dtpDataEmissao.TabIndex = 21
        Me.dtpDataEmissao.Value = New Date(2012, 9, 6, 0, 0, 0, 0)
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(497, 102)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissao.TabIndex = 20
        Me.lblDataEmissao.Text = "Data Emissão:"
        '
        'txtQuantidadeRolo
        '
        Me.txtQuantidadeRolo.DecimalDigits = 0
        Me.txtQuantidadeRolo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQuantidadeRolo.Location = New System.Drawing.Point(9, 77)
        Me.txtQuantidadeRolo.Name = "txtQuantidadeRolo"
        Me.txtQuantidadeRolo.Size = New System.Drawing.Size(95, 20)
        Me.txtQuantidadeRolo.TabIndex = 9
        Me.txtQuantidadeRolo.Text = "0"
        Me.txtQuantidadeRolo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'grpControl
        '
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Location = New System.Drawing.Point(6, 173)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(617, 51)
        Me.grpControl.TabIndex = 1
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(515, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(418, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'jstMain
        '
        Me.jstMain.AutoPopDelay = 15000
        Me.jstMain.ImageList = Nothing
        Me.jstMain.InitialDelay = 100
        '
        'btnContext
        '
        Me.btnContext.CommandManager = Me.cmdManager
        Me.btnContext.Key = "btnVisualizarHistorico"
        '
        'cmdManager
        '
        Me.cmdManager.BottomRebar = Me.BottomRebar1
        Me.cmdManager.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.btnVisualizarHistorico})
        Me.cmdManager.ContainerControl = Me
        Me.cmdManager.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.btnContext})
        Me.cmdManager.Id = New System.Guid("5b956b7e-52af-4ec5-8050-bf6b6569bebe")
        Me.cmdManager.LeftRebar = Me.LeftRebar1
        Me.cmdManager.RightRebar = Me.RightRebar1
        Me.cmdManager.Tag = Nothing
        Me.cmdManager.TopRebar = Me.TopRebar1
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.cmdManager
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 453)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.Size = New System.Drawing.Size(913, 0)
        '
        'btnVisualizarHistorico
        '
        Me.btnVisualizarHistorico.Key = "btnVisualizarHistorico"
        Me.btnVisualizarHistorico.Name = "btnVisualizarHistorico"
        Me.btnVisualizarHistorico.Text = "Visualizar Histório"
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.cmdManager
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 453)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.cmdManager
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(913, 0)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.Size = New System.Drawing.Size(0, 453)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandManager = Me.cmdManager
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(639, 0)
        '
        'btnVisualizarHistorico1
        '
        Me.btnVisualizarHistorico1.Key = "btnVisualizarHistorico"
        Me.btnVisualizarHistorico1.Name = "btnVisualizarHistorico1"
        '
        'lblQuantidadeRolo
        '
        Me.lblQuantidadeRolo.AutoSize = True
        Me.lblQuantidadeRolo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblQuantidadeRolo.ForeColor = System.Drawing.Color.Firebrick
        Me.lblQuantidadeRolo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeRolo.Location = New System.Drawing.Point(6, 60)
        Me.lblQuantidadeRolo.Name = "lblQuantidadeRolo"
        Me.lblQuantidadeRolo.Size = New System.Drawing.Size(63, 14)
        Me.lblQuantidadeRolo.TabIndex = 22
        Me.lblQuantidadeRolo.Text = "Qtde Rolo:"
        '
        'lblQuantidadeBobina
        '
        Me.lblQuantidadeBobina.AutoSize = True
        Me.lblQuantidadeBobina.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblQuantidadeBobina.ForeColor = System.Drawing.Color.Firebrick
        Me.lblQuantidadeBobina.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeBobina.Location = New System.Drawing.Point(107, 60)
        Me.lblQuantidadeBobina.Name = "lblQuantidadeBobina"
        Me.lblQuantidadeBobina.Size = New System.Drawing.Size(76, 14)
        Me.lblQuantidadeBobina.TabIndex = 23
        Me.lblQuantidadeBobina.Text = "Qtde Bobina:"
        '
        'lblQuantidadeCarretel
        '
        Me.lblQuantidadeCarretel.AutoSize = True
        Me.lblQuantidadeCarretel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblQuantidadeCarretel.ForeColor = System.Drawing.Color.Firebrick
        Me.lblQuantidadeCarretel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeCarretel.Location = New System.Drawing.Point(208, 60)
        Me.lblQuantidadeCarretel.Name = "lblQuantidadeCarretel"
        Me.lblQuantidadeCarretel.Size = New System.Drawing.Size(84, 14)
        Me.lblQuantidadeCarretel.TabIndex = 24
        Me.lblQuantidadeCarretel.Text = "Qtde Carretel:"
        '
        'usrPrdOrdemProducaoSoberano
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.TopRebar1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrPrdOrdemProducaoSoberano"
        Me.Size = New System.Drawing.Size(639, 260)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProduto.ResumeLayout(False)
        Me.grpProduto.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.btnContext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents jstMain As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnContext As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents cmdManager As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents btnVisualizarHistorico As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents btnVisualizarHistorico1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents grpProduto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtQuantidadeRolo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataEmissao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents lblOperador As System.Windows.Forms.Label
    Friend WithEvents cboOperador As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMaquina As System.Windows.Forms.Label
    Friend WithEvents cboMaquina As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents txtLote As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCor As System.Windows.Forms.Label
    Friend WithEvents cboCor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblBitola As System.Windows.Forms.Label
    Friend WithEvents cboBitola As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoProduto As System.Windows.Forms.Label
    Friend WithEvents cboTipoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoIntegracao As System.Windows.Forms.Label
    Friend WithEvents txtCodigoIntegracao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtQuantidadeCarretel As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtQuantidadeBobina As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeCarretel As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeBobina As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeRolo As System.Windows.Forms.Label

End Class
