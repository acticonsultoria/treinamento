<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEmissaoNFeAcaoEmLote
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEmissaoNFeAcaoEmLote))
        Dim grdNotaFiscalLote_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdDeposito_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpSMS = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboTextoSMS = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarSMS = New System.Windows.Forms.Button()
        Me.lblMensagemSMS = New System.Windows.Forms.Label()
        Me.oProgressBar = New System.Windows.Forms.ProgressBar()
        Me.grpStatus = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtQuantidadeEnviadaEmail = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeEnviadaEmail = New System.Windows.Forms.Label()
        Me.txtQuantidadeAutorizada = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeAutorizada = New System.Windows.Forms.Label()
        Me.txtQuantidadeCancelada = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeCancelada = New System.Windows.Forms.Label()
        Me.txtQuantidadeRejeitada = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeRejeitada = New System.Windows.Forms.Label()
        Me.txtQuantidadeAguardandoRetorno = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeAguardandoRetorno = New System.Windows.Forms.Label()
        Me.txtQuantidadeAguardandoTransmissao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeAguardandoTransmissao = New System.Windows.Forms.Label()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdNotaFiscalLote = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImprimirConferencia = New Janus.Windows.EditControls.UIButton()
        Me.btnBoletoHTML = New Janus.Windows.EditControls.UIButton()
        Me.btnEmailOutlook = New Janus.Windows.EditControls.UIButton()
        Me.btnEnviarSMS = New Janus.Windows.EditControls.UIButton()
        Me.btnBoletoNFe = New Janus.Windows.EditControls.UIButton()
        Me.btnValidarInutilizacao = New Janus.Windows.EditControls.UIButton()
        Me.btnValidarEstoque = New Janus.Windows.EditControls.UIButton()
        Me.btnCancelarNFe = New Janus.Windows.EditControls.UIButton()
        Me.btnExportarXML = New Janus.Windows.EditControls.UIButton()
        Me.lblNFeFinal = New System.Windows.Forms.Label()
        Me.lblNFeInicial = New System.Windows.Forms.Label()
        Me.txtNotaFiscalFinal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPagamentoAVista = New System.Windows.Forms.Label()
        Me.txtNotaFiscalInicial = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnExportarPDF = New Janus.Windows.EditControls.UIButton()
        Me.btnImprimirNFe = New Janus.Windows.EditControls.UIButton()
        Me.btnExportarBoletoBancario = New Janus.Windows.EditControls.UIButton()
        Me.btnEnviarEmail = New Janus.Windows.EditControls.UIButton()
        Me.btnRetornarNFE = New Janus.Windows.EditControls.UIButton()
        Me.btnTransmitirNFE = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagEstoque = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosEstoque = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar2 = New Janus.Windows.EditControls.UIButton()
        Me.btnAlterarLocalizacao = New Janus.Windows.EditControls.UIButton()
        Me.btnAlterarDeposito = New Janus.Windows.EditControls.UIButton()
        Me.lblLocalizacao = New System.Windows.Forms.Label()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.cboDeposito = New Janus.Windows.EditControls.UIComboBox()
        Me.cboLocalizacao = New Janus.Windows.EditControls.UIComboBox()
        Me.btnSair2 = New Janus.Windows.EditControls.UIButton()
        Me.grdDeposito = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpSMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSMS.SuspendLayout()
        CType(Me.grpStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStatus.SuspendLayout()
        CType(Me.grdNotaFiscalLote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        Me.pagEstoque.SuspendLayout()
        CType(Me.grpDadosEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosEstoque.SuspendLayout()
        CType(Me.grdDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme2.Name = "Scheme"
        JanusColorScheme2.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme2.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme2)
        Me.vsmMain.DefaultColorScheme = Nothing
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowCloseButton = True
        Me.tabMain.Size = New System.Drawing.Size(1019, 567)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela, Me.pagEstoque})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.AllowClose = False
        Me.pagTabela.Controls.Add(Me.grpSMS)
        Me.pagTabela.Controls.Add(Me.oProgressBar)
        Me.pagTabela.Controls.Add(Me.grpStatus)
        Me.pagTabela.Controls.Add(Me.btnExcelGrid)
        Me.pagTabela.Controls.Add(Me.btnAgruparGrid)
        Me.pagTabela.Controls.Add(Me.btnConfigurarGrid)
        Me.pagTabela.Controls.Add(Me.grdNotaFiscalLote)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(1017, 544)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Lista de Notas Fiscais"
        '
        'grpSMS
        '
        Me.grpSMS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSMS.BackColor = System.Drawing.Color.Transparent
        Me.grpSMS.Controls.Add(Me.cboTextoSMS)
        Me.grpSMS.Controls.Add(Me.btnCadastrarSMS)
        Me.grpSMS.Controls.Add(Me.lblMensagemSMS)
        Me.grpSMS.ForeColor = System.Drawing.Color.Black
        Me.grpSMS.Location = New System.Drawing.Point(8, 245)
        Me.grpSMS.Name = "grpSMS"
        Me.grpSMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSMS.Size = New System.Drawing.Size(1006, 63)
        Me.grpSMS.TabIndex = 6
        Me.grpSMS.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpSMS.VisualStyleManager = Me.vsmMain
        '
        'cboTextoSMS
        '
        Me.cboTextoSMS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTextoSMS.AutoSize = False
        Me.cboTextoSMS.Location = New System.Drawing.Point(12, 34)
        Me.cboTextoSMS.Name = "cboTextoSMS"
        Me.cboTextoSMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTextoSMS.Size = New System.Drawing.Size(974, 20)
        Me.cboTextoSMS.TabIndex = 12
        '
        'btnCadastrarSMS
        '
        Me.btnCadastrarSMS.FlatAppearance.BorderSize = 0
        Me.btnCadastrarSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarSMS.Image = CType(resources.GetObject("btnCadastrarSMS.Image"), System.Drawing.Image)
        Me.btnCadastrarSMS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarSMS.Location = New System.Drawing.Point(12, 17)
        Me.btnCadastrarSMS.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarSMS.Name = "btnCadastrarSMS"
        Me.btnCadastrarSMS.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarSMS.TabIndex = 21
        Me.btnCadastrarSMS.TabStop = False
        Me.btnCadastrarSMS.UseVisualStyleBackColor = True
        '
        'lblMensagemSMS
        '
        Me.lblMensagemSMS.AutoSize = True
        Me.lblMensagemSMS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMensagemSMS.Location = New System.Drawing.Point(28, 16)
        Me.lblMensagemSMS.Name = "lblMensagemSMS"
        Me.lblMensagemSMS.Size = New System.Drawing.Size(87, 14)
        Me.lblMensagemSMS.TabIndex = 20
        Me.lblMensagemSMS.Text = "Mensagem SMS:"
        '
        'oProgressBar
        '
        Me.oProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oProgressBar.Location = New System.Drawing.Point(8, 388)
        Me.oProgressBar.Name = "oProgressBar"
        Me.oProgressBar.Size = New System.Drawing.Size(1001, 36)
        Me.oProgressBar.TabIndex = 5
        '
        'grpStatus
        '
        Me.grpStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpStatus.BackColor = System.Drawing.Color.Transparent
        Me.grpStatus.Controls.Add(Me.txtQuantidadeEnviadaEmail)
        Me.grpStatus.Controls.Add(Me.lblQuantidadeEnviadaEmail)
        Me.grpStatus.Controls.Add(Me.txtQuantidadeAutorizada)
        Me.grpStatus.Controls.Add(Me.lblQuantidadeAutorizada)
        Me.grpStatus.Controls.Add(Me.txtQuantidadeCancelada)
        Me.grpStatus.Controls.Add(Me.lblQuantidadeCancelada)
        Me.grpStatus.Controls.Add(Me.txtQuantidadeRejeitada)
        Me.grpStatus.Controls.Add(Me.lblQuantidadeRejeitada)
        Me.grpStatus.Controls.Add(Me.txtQuantidadeAguardandoRetorno)
        Me.grpStatus.Controls.Add(Me.lblQuantidadeAguardandoRetorno)
        Me.grpStatus.Controls.Add(Me.txtQuantidadeAguardandoTransmissao)
        Me.grpStatus.Controls.Add(Me.lblQuantidadeAguardandoTransmissao)
        Me.grpStatus.ForeColor = System.Drawing.Color.Black
        Me.grpStatus.Location = New System.Drawing.Point(8, 316)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpStatus.Size = New System.Drawing.Size(1001, 63)
        Me.grpStatus.TabIndex = 0
        Me.grpStatus.Text = "Status"
        Me.grpStatus.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpStatus.VisualStyleManager = Me.vsmMain
        '
        'txtQuantidadeEnviadaEmail
        '
        Me.txtQuantidadeEnviadaEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeEnviadaEmail.DecimalDigits = 0
        Me.txtQuantidadeEnviadaEmail.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQuantidadeEnviadaEmail.ForeColor = System.Drawing.Color.Purple
        Me.txtQuantidadeEnviadaEmail.Location = New System.Drawing.Point(745, 32)
        Me.txtQuantidadeEnviadaEmail.Name = "txtQuantidadeEnviadaEmail"
        Me.txtQuantidadeEnviadaEmail.ReadOnly = True
        Me.txtQuantidadeEnviadaEmail.Size = New System.Drawing.Size(136, 20)
        Me.txtQuantidadeEnviadaEmail.TabIndex = 11
        Me.txtQuantidadeEnviadaEmail.Text = "0"
        Me.txtQuantidadeEnviadaEmail.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblQuantidadeEnviadaEmail
        '
        Me.lblQuantidadeEnviadaEmail.AutoSize = True
        Me.lblQuantidadeEnviadaEmail.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblQuantidadeEnviadaEmail.ForeColor = System.Drawing.Color.Purple
        Me.lblQuantidadeEnviadaEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeEnviadaEmail.Location = New System.Drawing.Point(742, 16)
        Me.lblQuantidadeEnviadaEmail.Name = "lblQuantidadeEnviadaEmail"
        Me.lblQuantidadeEnviadaEmail.Size = New System.Drawing.Size(105, 14)
        Me.lblQuantidadeEnviadaEmail.TabIndex = 10
        Me.lblQuantidadeEnviadaEmail.Text = "Qtd Enviada Email:"
        '
        'txtQuantidadeAutorizada
        '
        Me.txtQuantidadeAutorizada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeAutorizada.DecimalDigits = 0
        Me.txtQuantidadeAutorizada.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQuantidadeAutorizada.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtQuantidadeAutorizada.Location = New System.Drawing.Point(603, 32)
        Me.txtQuantidadeAutorizada.Name = "txtQuantidadeAutorizada"
        Me.txtQuantidadeAutorizada.ReadOnly = True
        Me.txtQuantidadeAutorizada.Size = New System.Drawing.Size(136, 20)
        Me.txtQuantidadeAutorizada.TabIndex = 9
        Me.txtQuantidadeAutorizada.Text = "0"
        Me.txtQuantidadeAutorizada.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblQuantidadeAutorizada
        '
        Me.lblQuantidadeAutorizada.AutoSize = True
        Me.lblQuantidadeAutorizada.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblQuantidadeAutorizada.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblQuantidadeAutorizada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeAutorizada.Location = New System.Drawing.Point(600, 16)
        Me.lblQuantidadeAutorizada.Name = "lblQuantidadeAutorizada"
        Me.lblQuantidadeAutorizada.Size = New System.Drawing.Size(91, 14)
        Me.lblQuantidadeAutorizada.TabIndex = 8
        Me.lblQuantidadeAutorizada.Text = "Qtd Autorizada:"
        '
        'txtQuantidadeCancelada
        '
        Me.txtQuantidadeCancelada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeCancelada.DecimalDigits = 0
        Me.txtQuantidadeCancelada.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQuantidadeCancelada.ForeColor = System.Drawing.Color.Firebrick
        Me.txtQuantidadeCancelada.Location = New System.Drawing.Point(461, 32)
        Me.txtQuantidadeCancelada.Name = "txtQuantidadeCancelada"
        Me.txtQuantidadeCancelada.ReadOnly = True
        Me.txtQuantidadeCancelada.Size = New System.Drawing.Size(136, 20)
        Me.txtQuantidadeCancelada.TabIndex = 7
        Me.txtQuantidadeCancelada.Text = "0"
        Me.txtQuantidadeCancelada.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblQuantidadeCancelada
        '
        Me.lblQuantidadeCancelada.AutoSize = True
        Me.lblQuantidadeCancelada.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblQuantidadeCancelada.ForeColor = System.Drawing.Color.Firebrick
        Me.lblQuantidadeCancelada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeCancelada.Location = New System.Drawing.Point(458, 16)
        Me.lblQuantidadeCancelada.Name = "lblQuantidadeCancelada"
        Me.lblQuantidadeCancelada.Size = New System.Drawing.Size(88, 14)
        Me.lblQuantidadeCancelada.TabIndex = 6
        Me.lblQuantidadeCancelada.Text = "Qtd Cancelada:"
        '
        'txtQuantidadeRejeitada
        '
        Me.txtQuantidadeRejeitada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeRejeitada.DecimalDigits = 0
        Me.txtQuantidadeRejeitada.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQuantidadeRejeitada.ForeColor = System.Drawing.Color.Peru
        Me.txtQuantidadeRejeitada.Location = New System.Drawing.Point(319, 32)
        Me.txtQuantidadeRejeitada.Name = "txtQuantidadeRejeitada"
        Me.txtQuantidadeRejeitada.ReadOnly = True
        Me.txtQuantidadeRejeitada.Size = New System.Drawing.Size(136, 20)
        Me.txtQuantidadeRejeitada.TabIndex = 5
        Me.txtQuantidadeRejeitada.Text = "0"
        Me.txtQuantidadeRejeitada.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblQuantidadeRejeitada
        '
        Me.lblQuantidadeRejeitada.AutoSize = True
        Me.lblQuantidadeRejeitada.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblQuantidadeRejeitada.ForeColor = System.Drawing.Color.Peru
        Me.lblQuantidadeRejeitada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeRejeitada.Location = New System.Drawing.Point(316, 16)
        Me.lblQuantidadeRejeitada.Name = "lblQuantidadeRejeitada"
        Me.lblQuantidadeRejeitada.Size = New System.Drawing.Size(82, 14)
        Me.lblQuantidadeRejeitada.TabIndex = 4
        Me.lblQuantidadeRejeitada.Text = "Qtd Rejeitada:"
        '
        'txtQuantidadeAguardandoRetorno
        '
        Me.txtQuantidadeAguardandoRetorno.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeAguardandoRetorno.DecimalDigits = 0
        Me.txtQuantidadeAguardandoRetorno.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQuantidadeAguardandoRetorno.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtQuantidadeAguardandoRetorno.Location = New System.Drawing.Point(177, 32)
        Me.txtQuantidadeAguardandoRetorno.Name = "txtQuantidadeAguardandoRetorno"
        Me.txtQuantidadeAguardandoRetorno.ReadOnly = True
        Me.txtQuantidadeAguardandoRetorno.Size = New System.Drawing.Size(136, 20)
        Me.txtQuantidadeAguardandoRetorno.TabIndex = 3
        Me.txtQuantidadeAguardandoRetorno.Text = "0"
        Me.txtQuantidadeAguardandoRetorno.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblQuantidadeAguardandoRetorno
        '
        Me.lblQuantidadeAguardandoRetorno.AutoSize = True
        Me.lblQuantidadeAguardandoRetorno.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblQuantidadeAguardandoRetorno.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblQuantidadeAguardandoRetorno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeAguardandoRetorno.Location = New System.Drawing.Point(174, 16)
        Me.lblQuantidadeAguardandoRetorno.Name = "lblQuantidadeAguardandoRetorno"
        Me.lblQuantidadeAguardandoRetorno.Size = New System.Drawing.Size(122, 14)
        Me.lblQuantidadeAguardandoRetorno.TabIndex = 2
        Me.lblQuantidadeAguardandoRetorno.Text = "Qtd Aguard. Retorno:"
        '
        'txtQuantidadeAguardandoTransmissao
        '
        Me.txtQuantidadeAguardandoTransmissao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeAguardandoTransmissao.DecimalDigits = 0
        Me.txtQuantidadeAguardandoTransmissao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQuantidadeAguardandoTransmissao.ForeColor = System.Drawing.Color.DimGray
        Me.txtQuantidadeAguardandoTransmissao.Location = New System.Drawing.Point(12, 32)
        Me.txtQuantidadeAguardandoTransmissao.Name = "txtQuantidadeAguardandoTransmissao"
        Me.txtQuantidadeAguardandoTransmissao.ReadOnly = True
        Me.txtQuantidadeAguardandoTransmissao.Size = New System.Drawing.Size(159, 20)
        Me.txtQuantidadeAguardandoTransmissao.TabIndex = 1
        Me.txtQuantidadeAguardandoTransmissao.Text = "0"
        Me.txtQuantidadeAguardandoTransmissao.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblQuantidadeAguardandoTransmissao
        '
        Me.lblQuantidadeAguardandoTransmissao.AutoSize = True
        Me.lblQuantidadeAguardandoTransmissao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblQuantidadeAguardandoTransmissao.ForeColor = System.Drawing.Color.DimGray
        Me.lblQuantidadeAguardandoTransmissao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeAguardandoTransmissao.Location = New System.Drawing.Point(9, 16)
        Me.lblQuantidadeAguardandoTransmissao.Name = "lblQuantidadeAguardandoTransmissao"
        Me.lblQuantidadeAguardandoTransmissao.Size = New System.Drawing.Size(147, 14)
        Me.lblQuantidadeAguardandoTransmissao.TabIndex = 0
        Me.lblQuantidadeAguardandoTransmissao.Text = "Qtd Aguard.Transmissão:"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 223)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 3
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 223)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 2
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 223)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 1
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdNotaFiscalLote
        '
        Me.grdNotaFiscalLote.AlternatingColors = True
        Me.grdNotaFiscalLote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdNotaFiscalLote_DesignTimeLayout.LayoutString = resources.GetString("grdNotaFiscalLote_DesignTimeLayout.LayoutString")
        Me.grdNotaFiscalLote.DesignTimeLayout = grdNotaFiscalLote_DesignTimeLayout
        Me.grdNotaFiscalLote.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdNotaFiscalLote.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdNotaFiscalLote.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdNotaFiscalLote.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdNotaFiscalLote.GroupByBoxVisible = False
        Me.grdNotaFiscalLote.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdNotaFiscalLote.Location = New System.Drawing.Point(8, 7)
        Me.grdNotaFiscalLote.Name = "grdNotaFiscalLote"
        Me.grdNotaFiscalLote.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdNotaFiscalLote.RecordNavigator = True
        Me.grdNotaFiscalLote.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdNotaFiscalLote.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdNotaFiscalLote.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdNotaFiscalLote.Size = New System.Drawing.Size(1001, 232)
        Me.grdNotaFiscalLote.TabIndex = 0
        Me.grdNotaFiscalLote.TabStop = False
        Me.grdNotaFiscalLote.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdNotaFiscalLote.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdNotaFiscalLote.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdNotaFiscalLote.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdNotaFiscalLote.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdNotaFiscalLote.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdNotaFiscalLote.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdNotaFiscalLote.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnImprimirConferencia)
        Me.grpControl2.Controls.Add(Me.btnBoletoHTML)
        Me.grpControl2.Controls.Add(Me.btnEmailOutlook)
        Me.grpControl2.Controls.Add(Me.txtNotaFiscalFinal)
        Me.grpControl2.Controls.Add(Me.txtNotaFiscalInicial)
        Me.grpControl2.Controls.Add(Me.btnEnviarSMS)
        Me.grpControl2.Controls.Add(Me.lblPagamentoAVista)
        Me.grpControl2.Controls.Add(Me.btnBoletoNFe)
        Me.grpControl2.Controls.Add(Me.lblNFeInicial)
        Me.grpControl2.Controls.Add(Me.btnValidarInutilizacao)
        Me.grpControl2.Controls.Add(Me.lblNFeFinal)
        Me.grpControl2.Controls.Add(Me.btnValidarEstoque)
        Me.grpControl2.Controls.Add(Me.btnCancelarNFe)
        Me.grpControl2.Controls.Add(Me.btnExportarXML)
        Me.grpControl2.Controls.Add(Me.btnExportarPDF)
        Me.grpControl2.Controls.Add(Me.btnImprimirNFe)
        Me.grpControl2.Controls.Add(Me.btnExportarBoletoBancario)
        Me.grpControl2.Controls.Add(Me.btnEnviarEmail)
        Me.grpControl2.Controls.Add(Me.btnRetornarNFE)
        Me.grpControl2.Controls.Add(Me.btnTransmitirNFE)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 430)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(1001, 105)
        Me.grpControl2.TabIndex = 4
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnImprimirConferencia
        '
        Me.btnImprimirConferencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirConferencia.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnImprimirConferencia.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimirConferencia.Location = New System.Drawing.Point(434, 15)
        Me.btnImprimirConferencia.Name = "btnImprimirConferencia"
        Me.btnImprimirConferencia.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimirConferencia.Size = New System.Drawing.Size(138, 23)
        Me.btnImprimirConferencia.TabIndex = 28
        Me.btnImprimirConferencia.Text = "Imprimir Conferência"
        Me.btnImprimirConferencia.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnBoletoHTML
        '
        Me.btnBoletoHTML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBoletoHTML.Image = Global.INTERACTI.My.Resources.Resources.xml
        Me.btnBoletoHTML.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnBoletoHTML.Location = New System.Drawing.Point(434, 44)
        Me.btnBoletoHTML.Name = "btnBoletoHTML"
        Me.btnBoletoHTML.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnBoletoHTML.Size = New System.Drawing.Size(138, 23)
        Me.btnBoletoHTML.TabIndex = 27
        Me.btnBoletoHTML.Text = "Boleto HTML"
        Me.btnBoletoHTML.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnEmailOutlook
        '
        Me.btnEmailOutlook.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEmailOutlook.Image = Global.INTERACTI.My.Resources.Resources.email
        Me.btnEmailOutlook.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnEmailOutlook.Location = New System.Drawing.Point(291, 76)
        Me.btnEmailOutlook.Name = "btnEmailOutlook"
        Me.btnEmailOutlook.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnEmailOutlook.Size = New System.Drawing.Size(137, 23)
        Me.btnEmailOutlook.TabIndex = 26
        Me.btnEmailOutlook.Text = "E-mail (Outlook)"
        Me.btnEmailOutlook.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnEnviarSMS
        '
        Me.btnEnviarSMS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarSMS.Image = Global.INTERACTI.My.Resources.Resources.telefone
        Me.btnEnviarSMS.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnEnviarSMS.Location = New System.Drawing.Point(9, 76)
        Me.btnEnviarSMS.Name = "btnEnviarSMS"
        Me.btnEnviarSMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnEnviarSMS.Size = New System.Drawing.Size(120, 23)
        Me.btnEnviarSMS.TabIndex = 25
        Me.btnEnviarSMS.Text = "Enviar SMS"
        Me.btnEnviarSMS.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnBoletoNFe
        '
        Me.btnBoletoNFe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBoletoNFe.Image = Global.INTERACTI.My.Resources.Resources.cadastro_basico
        Me.btnBoletoNFe.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnBoletoNFe.Location = New System.Drawing.Point(434, 76)
        Me.btnBoletoNFe.Name = "btnBoletoNFe"
        Me.btnBoletoNFe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnBoletoNFe.Size = New System.Drawing.Size(138, 23)
        Me.btnBoletoNFe.TabIndex = 24
        Me.btnBoletoNFe.Text = "Boleto + NF-e"
        Me.btnBoletoNFe.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnValidarInutilizacao
        '
        Me.btnValidarInutilizacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnValidarInutilizacao.Image = Global.INTERACTI.My.Resources.Resources.cadastro_basico
        Me.btnValidarInutilizacao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnValidarInutilizacao.Location = New System.Drawing.Point(578, 44)
        Me.btnValidarInutilizacao.Name = "btnValidarInutilizacao"
        Me.btnValidarInutilizacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnValidarInutilizacao.Size = New System.Drawing.Size(133, 23)
        Me.btnValidarInutilizacao.TabIndex = 23
        Me.btnValidarInutilizacao.Text = "Validar Inutilização"
        Me.btnValidarInutilizacao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnValidarEstoque
        '
        Me.btnValidarEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnValidarEstoque.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnValidarEstoque.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnValidarEstoque.Location = New System.Drawing.Point(578, 15)
        Me.btnValidarEstoque.Name = "btnValidarEstoque"
        Me.btnValidarEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnValidarEstoque.Size = New System.Drawing.Size(133, 23)
        Me.btnValidarEstoque.TabIndex = 22
        Me.btnValidarEstoque.Text = "Validar Estoque"
        Me.btnValidarEstoque.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCancelarNFe
        '
        Me.btnCancelarNFe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarNFe.Image = Global.INTERACTI.My.Resources.Resources.cancelar
        Me.btnCancelarNFe.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCancelarNFe.Location = New System.Drawing.Point(578, 76)
        Me.btnCancelarNFe.Name = "btnCancelarNFe"
        Me.btnCancelarNFe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCancelarNFe.Size = New System.Drawing.Size(133, 23)
        Me.btnCancelarNFe.TabIndex = 21
        Me.btnCancelarNFe.Text = "Cancelar NF-e"
        Me.btnCancelarNFe.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExportarXML
        '
        Me.btnExportarXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExportarXML.Image = Global.INTERACTI.My.Resources.Resources.xml
        Me.btnExportarXML.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExportarXML.Location = New System.Drawing.Point(135, 44)
        Me.btnExportarXML.Name = "btnExportarXML"
        Me.btnExportarXML.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExportarXML.Size = New System.Drawing.Size(150, 23)
        Me.btnExportarXML.TabIndex = 20
        Me.btnExportarXML.Text = "Exportar XML"
        Me.btnExportarXML.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblNFeFinal
        '
        Me.lblNFeFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNFeFinal.AutoSize = True
        Me.lblNFeFinal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNFeFinal.Location = New System.Drawing.Point(920, 14)
        Me.lblNFeFinal.Name = "lblNFeFinal"
        Me.lblNFeFinal.Size = New System.Drawing.Size(54, 14)
        Me.lblNFeFinal.TabIndex = 19
        Me.lblNFeFinal.Text = "NFe Final:"
        '
        'lblNFeInicial
        '
        Me.lblNFeInicial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNFeInicial.AutoSize = True
        Me.lblNFeInicial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNFeInicial.Location = New System.Drawing.Point(845, 14)
        Me.lblNFeInicial.Name = "lblNFeInicial"
        Me.lblNFeInicial.Size = New System.Drawing.Size(58, 14)
        Me.lblNFeInicial.TabIndex = 18
        Me.lblNFeInicial.Text = "NFe Inicial:"
        '
        'txtNotaFiscalFinal
        '
        Me.txtNotaFiscalFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotaFiscalFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaFiscalFinal.Location = New System.Drawing.Point(923, 31)
        Me.txtNotaFiscalFinal.MaxLength = 50
        Me.txtNotaFiscalFinal.Name = "txtNotaFiscalFinal"
        Me.txtNotaFiscalFinal.Size = New System.Drawing.Size(69, 20)
        Me.txtNotaFiscalFinal.TabIndex = 17
        '
        'lblPagamentoAVista
        '
        Me.lblPagamentoAVista.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPagamentoAVista.AutoSize = True
        Me.lblPagamentoAVista.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPagamentoAVista.Location = New System.Drawing.Point(744, 31)
        Me.lblPagamentoAVista.Name = "lblPagamentoAVista"
        Me.lblPagamentoAVista.Size = New System.Drawing.Size(98, 14)
        Me.lblPagamentoAVista.TabIndex = 16
        Me.lblPagamentoAVista.Text = "Pagamento à vista:"
        '
        'txtNotaFiscalInicial
        '
        Me.txtNotaFiscalInicial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotaFiscalInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaFiscalInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotaFiscalInicial.ForeColor = System.Drawing.Color.Black
        Me.txtNotaFiscalInicial.Location = New System.Drawing.Point(848, 31)
        Me.txtNotaFiscalInicial.MaxLength = 50
        Me.txtNotaFiscalInicial.Name = "txtNotaFiscalInicial"
        Me.txtNotaFiscalInicial.Size = New System.Drawing.Size(69, 20)
        Me.txtNotaFiscalInicial.TabIndex = 15
        Me.txtNotaFiscalInicial.UseCompatibleTextRendering = True
        '
        'btnExportarPDF
        '
        Me.btnExportarPDF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExportarPDF.Image = Global.INTERACTI.My.Resources.Resources.pdf
        Me.btnExportarPDF.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExportarPDF.Location = New System.Drawing.Point(291, 44)
        Me.btnExportarPDF.Name = "btnExportarPDF"
        Me.btnExportarPDF.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExportarPDF.Size = New System.Drawing.Size(137, 23)
        Me.btnExportarPDF.TabIndex = 5
        Me.btnExportarPDF.Text = "Exportar NFe para PDF"
        Me.btnExportarPDF.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImprimirNFe
        '
        Me.btnImprimirNFe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirNFe.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimirNFe.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimirNFe.Location = New System.Drawing.Point(291, 15)
        Me.btnImprimirNFe.Name = "btnImprimirNFe"
        Me.btnImprimirNFe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimirNFe.Size = New System.Drawing.Size(137, 23)
        Me.btnImprimirNFe.TabIndex = 4
        Me.btnImprimirNFe.Text = "Imprimir NF-e"
        Me.btnImprimirNFe.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExportarBoletoBancario
        '
        Me.btnExportarBoletoBancario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExportarBoletoBancario.Image = CType(resources.GetObject("btnExportarBoletoBancario.Image"), System.Drawing.Image)
        Me.btnExportarBoletoBancario.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExportarBoletoBancario.Location = New System.Drawing.Point(135, 15)
        Me.btnExportarBoletoBancario.Name = "btnExportarBoletoBancario"
        Me.btnExportarBoletoBancario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExportarBoletoBancario.Size = New System.Drawing.Size(150, 23)
        Me.btnExportarBoletoBancario.TabIndex = 6
        Me.btnExportarBoletoBancario.Text = "Exportar Boleto"
        Me.btnExportarBoletoBancario.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnEnviarEmail
        '
        Me.btnEnviarEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarEmail.Image = Global.INTERACTI.My.Resources.Resources.email
        Me.btnEnviarEmail.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnEnviarEmail.Location = New System.Drawing.Point(135, 76)
        Me.btnEnviarEmail.Name = "btnEnviarEmail"
        Me.btnEnviarEmail.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnEnviarEmail.Size = New System.Drawing.Size(150, 23)
        Me.btnEnviarEmail.TabIndex = 7
        Me.btnEnviarEmail.Text = "E-mail NFe / Boleto / SMS"
        Me.btnEnviarEmail.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnRetornarNFE
        '
        Me.btnRetornarNFE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRetornarNFE.Image = Global.INTERACTI.My.Resources.Resources.download
        Me.btnRetornarNFE.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnRetornarNFE.Location = New System.Drawing.Point(9, 44)
        Me.btnRetornarNFE.Name = "btnRetornarNFE"
        Me.btnRetornarNFE.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnRetornarNFE.Size = New System.Drawing.Size(120, 23)
        Me.btnRetornarNFE.TabIndex = 3
        Me.btnRetornarNFE.Text = "Retornar NF-e"
        Me.btnRetornarNFE.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnTransmitirNFE
        '
        Me.btnTransmitirNFE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTransmitirNFE.Image = Global.INTERACTI.My.Resources.Resources.upload
        Me.btnTransmitirNFE.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnTransmitirNFE.Location = New System.Drawing.Point(9, 15)
        Me.btnTransmitirNFE.Name = "btnTransmitirNFE"
        Me.btnTransmitirNFE.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnTransmitirNFE.Size = New System.Drawing.Size(120, 23)
        Me.btnTransmitirNFE.TabIndex = 2
        Me.btnTransmitirNFE.Text = "Transmitir NF-e"
        Me.btnTransmitirNFE.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(842, 73)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(150, 23)
        Me.btnSair.TabIndex = 8
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagEstoque
        '
        Me.pagEstoque.Controls.Add(Me.grpDadosEstoque)
        Me.pagEstoque.Controls.Add(Me.grdDeposito)
        Me.pagEstoque.Location = New System.Drawing.Point(1, 22)
        Me.pagEstoque.Name = "pagEstoque"
        Me.pagEstoque.Size = New System.Drawing.Size(912, 544)
        Me.pagEstoque.TabStop = True
        Me.pagEstoque.Text = "Dados do Estoque"
        '
        'grpDadosEstoque
        '
        Me.grpDadosEstoque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosEstoque.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosEstoque.Controls.Add(Me.btnSalvar2)
        Me.grpDadosEstoque.Controls.Add(Me.btnAlterarLocalizacao)
        Me.grpDadosEstoque.Controls.Add(Me.btnAlterarDeposito)
        Me.grpDadosEstoque.Controls.Add(Me.lblLocalizacao)
        Me.grpDadosEstoque.Controls.Add(Me.lblDeposito)
        Me.grpDadosEstoque.Controls.Add(Me.cboDeposito)
        Me.grpDadosEstoque.Controls.Add(Me.cboLocalizacao)
        Me.grpDadosEstoque.Controls.Add(Me.btnSair2)
        Me.grpDadosEstoque.Location = New System.Drawing.Point(8, 462)
        Me.grpDadosEstoque.Name = "grpDadosEstoque"
        Me.grpDadosEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosEstoque.Size = New System.Drawing.Size(896, 75)
        Me.grpDadosEstoque.TabIndex = 5
        Me.grpDadosEstoque.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosEstoque.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar2
        '
        Me.btnSalvar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar2.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar2.Location = New System.Drawing.Point(796, 12)
        Me.btnSalvar2.Name = "btnSalvar2"
        Me.btnSalvar2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar2.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar2.TabIndex = 27
        Me.btnSalvar2.Text = "Salvar"
        Me.btnSalvar2.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAlterarLocalizacao
        '
        Me.btnAlterarLocalizacao.Image = Global.INTERACTI.My.Resources.Resources.nota
        Me.btnAlterarLocalizacao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAlterarLocalizacao.Location = New System.Drawing.Point(271, 40)
        Me.btnAlterarLocalizacao.Name = "btnAlterarLocalizacao"
        Me.btnAlterarLocalizacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAlterarLocalizacao.Size = New System.Drawing.Size(150, 23)
        Me.btnAlterarLocalizacao.TabIndex = 26
        Me.btnAlterarLocalizacao.Text = "Alterar Localização"
        Me.btnAlterarLocalizacao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAlterarDeposito
        '
        Me.btnAlterarDeposito.Image = Global.INTERACTI.My.Resources.Resources.truck
        Me.btnAlterarDeposito.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAlterarDeposito.Location = New System.Drawing.Point(271, 11)
        Me.btnAlterarDeposito.Name = "btnAlterarDeposito"
        Me.btnAlterarDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAlterarDeposito.Size = New System.Drawing.Size(150, 23)
        Me.btnAlterarDeposito.TabIndex = 23
        Me.btnAlterarDeposito.Text = "Alterar Depósito"
        Me.btnAlterarDeposito.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblLocalizacao
        '
        Me.lblLocalizacao.AutoSize = True
        Me.lblLocalizacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLocalizacao.Location = New System.Drawing.Point(6, 46)
        Me.lblLocalizacao.Name = "lblLocalizacao"
        Me.lblLocalizacao.Size = New System.Drawing.Size(68, 14)
        Me.lblLocalizacao.TabIndex = 24
        Me.lblLocalizacao.Text = "Localização:"
        '
        'lblDeposito
        '
        Me.lblDeposito.AutoSize = True
        Me.lblDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDeposito.Location = New System.Drawing.Point(6, 17)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(52, 14)
        Me.lblDeposito.TabIndex = 0
        Me.lblDeposito.Text = "Depósito:"
        '
        'cboDeposito
        '
        Me.cboDeposito.AutoSize = False
        Me.cboDeposito.Location = New System.Drawing.Point(80, 14)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDeposito.Size = New System.Drawing.Size(185, 20)
        Me.cboDeposito.TabIndex = 1
        Me.cboDeposito.TabStop = False
        '
        'cboLocalizacao
        '
        Me.cboLocalizacao.AutoSize = False
        Me.cboLocalizacao.Location = New System.Drawing.Point(80, 43)
        Me.cboLocalizacao.Name = "cboLocalizacao"
        Me.cboLocalizacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboLocalizacao.Size = New System.Drawing.Size(185, 20)
        Me.cboLocalizacao.TabIndex = 25
        Me.cboLocalizacao.TabStop = False
        '
        'btnSair2
        '
        Me.btnSair2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair2.Image = CType(resources.GetObject("btnSair2.Image"), System.Drawing.Image)
        Me.btnSair2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair2.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair2.Location = New System.Drawing.Point(796, 40)
        Me.btnSair2.Name = "btnSair2"
        Me.btnSair2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair2.Size = New System.Drawing.Size(91, 23)
        Me.btnSair2.TabIndex = 8
        Me.btnSair2.Text = "Sair"
        Me.btnSair2.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdDeposito
        '
        Me.grdDeposito.AlternatingColors = True
        Me.grdDeposito.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDeposito.AutoEdit = True
        grdDeposito_DesignTimeLayout.LayoutString = resources.GetString("grdDeposito_DesignTimeLayout.LayoutString")
        Me.grdDeposito.DesignTimeLayout = grdDeposito_DesignTimeLayout
        Me.grdDeposito.DynamicFiltering = True
        Me.grdDeposito.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdDeposito.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdDeposito.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdDeposito.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdDeposito.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdDeposito.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdDeposito.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdDeposito.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdDeposito.GroupByBoxVisible = False
        Me.grdDeposito.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdDeposito.Location = New System.Drawing.Point(8, 7)
        Me.grdDeposito.Name = "grdDeposito"
        Me.grdDeposito.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdDeposito.RecordNavigator = True
        Me.grdDeposito.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdDeposito.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdDeposito.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdDeposito.Size = New System.Drawing.Size(896, 449)
        Me.grdDeposito.TabIndex = 1
        Me.grdDeposito.TabStop = False
        Me.grdDeposito.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdDeposito.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdDeposito.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdDeposito.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdDeposito.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdDeposito.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdDeposito.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdDeposito.VisualStyleManager = Me.vsmMain
        '
        'frmFatEmissaoNFeAcaoEmLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 582)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEmissaoNFeAcaoEmLote"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ação em Lote"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpSMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSMS.ResumeLayout(False)
        Me.grpSMS.PerformLayout()
        CType(Me.grpStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStatus.ResumeLayout(False)
        Me.grpStatus.PerformLayout()
        CType(Me.grdNotaFiscalLote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.grpControl2.PerformLayout()
        Me.pagEstoque.ResumeLayout(False)
        CType(Me.grpDadosEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosEstoque.ResumeLayout(False)
        Me.grpDadosEstoque.PerformLayout()
        CType(Me.grdDeposito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdNotaFiscalLote As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnRetornarNFE As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnTransmitirNFE As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnEnviarEmail As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExportarBoletoBancario As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnImprimirNFe As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExportarPDF As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents txtNotaFiscalFinal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPagamentoAVista As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscalInicial As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNFeFinal As System.Windows.Forms.Label
    Friend WithEvents lblNFeInicial As System.Windows.Forms.Label
    Friend WithEvents btnExportarXML As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCancelarNFe As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpStatus As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblQuantidadeAguardandoTransmissao As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeAguardandoTransmissao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtQuantidadeAguardandoRetorno As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeAguardandoRetorno As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeEnviadaEmail As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeEnviadaEmail As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeAutorizada As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeAutorizada As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeCancelada As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeCancelada As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeRejeitada As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeRejeitada As System.Windows.Forms.Label
    Friend WithEvents btnValidarEstoque As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnValidarInutilizacao As Janus.Windows.EditControls.UIButton
    Friend WithEvents oProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents btnBoletoNFe As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagEstoque As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDadosEstoque As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnAlterarLocalizacao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAlterarDeposito As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblLocalizacao As System.Windows.Forms.Label
    Friend WithEvents lblDeposito As System.Windows.Forms.Label
    Friend WithEvents cboDeposito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboLocalizacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnSair2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdDeposito As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnSalvar2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnEnviarSMS As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnEmailOutlook As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpSMS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblMensagemSMS As System.Windows.Forms.Label
    Friend WithEvents btnBoletoHTML As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCadastrarSMS As System.Windows.Forms.Button
    Friend WithEvents cboTextoSMS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnImprimirConferencia As Janus.Windows.EditControls.UIButton
End Class
