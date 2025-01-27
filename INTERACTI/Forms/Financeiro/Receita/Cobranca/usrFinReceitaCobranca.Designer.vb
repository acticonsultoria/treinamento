<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFinReceitaCobranca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFinReceitaCobranca))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProtesto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnRelatorioEntrega = New Janus.Windows.EditControls.UIButton()
        Me.btnCartaBoleto = New Janus.Windows.EditControls.UIButton()
        Me.btnEnviarSMS = New Janus.Windows.EditControls.UIButton()
        Me.btnEnviarEmail = New Janus.Windows.EditControls.UIButton()
        Me.btnEnviarProtesto = New Janus.Windows.EditControls.UIButton()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarCliente = New System.Windows.Forms.Button()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataVencimentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataVencimentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtClienteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoFiltro = New System.Windows.Forms.Label()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblDataVencimentoFiltro = New System.Windows.Forms.Label()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaGeradoArquivo = New System.Windows.Forms.Label()
        Me.picLegendaGeradoArquivo = New System.Windows.Forms.PictureBox()
        Me.grpSMS = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboTextoSMS = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarSMS = New System.Windows.Forms.Button()
        Me.lblMensagemSMS = New System.Windows.Forms.Label()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgrupaGrid = New System.Windows.Forms.Button()
        Me.btnConfiguraGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.pagProtesto = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTituloAberto = New System.Windows.Forms.Label()
        Me.picTituloAberto = New System.Windows.Forms.PictureBox()
        Me.lblTituloCancelado = New System.Windows.Forms.Label()
        Me.picTituloCancelado = New System.Windows.Forms.PictureBox()
        Me.grpProtesto = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblStatusProtesto = New System.Windows.Forms.Label()
        Me.dtpDataVencimentoTerminoProtesto = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataVencimentoInicioProtesto = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtClienteProtesto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblClienteProtesto = New System.Windows.Forms.Label()
        Me.btnFiltrarProtesto = New Janus.Windows.EditControls.UIButton()
        Me.lblDataVencimentoFiltroProtesto = New System.Windows.Forms.Label()
        Me.btnAgrupaGridProtesto = New System.Windows.Forms.Button()
        Me.btnConfiguraGridProtesto = New System.Windows.Forms.Button()
        Me.grdProtesto = New Janus.Windows.GridEX.GridEX()
        Me.grpControleProtesto = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnPlanilhaProtesto = New Janus.Windows.EditControls.UIButton()
        Me.btnDesfazerProtesto = New Janus.Windows.EditControls.UIButton()
        Me.btnSairProtesto = New Janus.Windows.EditControls.UIButton()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.picLegendaGeradoArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSMS.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagProtesto.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picTituloAberto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTituloCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpProtesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProtesto.SuspendLayout()
        CType(Me.grdProtesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControleProtesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleProtesto.SuspendLayout()
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
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnRelatorioEntrega)
        Me.grpControle.Controls.Add(Me.btnCartaBoleto)
        Me.grpControle.Controls.Add(Me.btnEnviarSMS)
        Me.grpControle.Controls.Add(Me.btnEnviarEmail)
        Me.grpControle.Controls.Add(Me.btnEnviarProtesto)
        Me.grpControle.Controls.Add(Me.btnImprimir)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(200, 480)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(954, 54)
        Me.grpControle.TabIndex = 0
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnRelatorioEntrega
        '
        Me.btnRelatorioEntrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRelatorioEntrega.Image = Global.INTERACTI.My.Resources.Resources.truck
        Me.btnRelatorioEntrega.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnRelatorioEntrega.Location = New System.Drawing.Point(8, 17)
        Me.btnRelatorioEntrega.Name = "btnRelatorioEntrega"
        Me.btnRelatorioEntrega.Size = New System.Drawing.Size(135, 23)
        Me.btnRelatorioEntrega.TabIndex = 8
        Me.btnRelatorioEntrega.Text = "Relatório de Entrega"
        Me.btnRelatorioEntrega.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCartaBoleto
        '
        Me.btnCartaBoleto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCartaBoleto.Image = Global.INTERACTI.My.Resources.Resources.duplicar
        Me.btnCartaBoleto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCartaBoleto.Location = New System.Drawing.Point(149, 17)
        Me.btnCartaBoleto.Name = "btnCartaBoleto"
        Me.btnCartaBoleto.Size = New System.Drawing.Size(135, 23)
        Me.btnCartaBoleto.TabIndex = 7
        Me.btnCartaBoleto.Text = "Carta Boleto"
        Me.btnCartaBoleto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnEnviarSMS
        '
        Me.btnEnviarSMS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarSMS.Image = Global.INTERACTI.My.Resources.Resources.telefone
        Me.btnEnviarSMS.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnEnviarSMS.Location = New System.Drawing.Point(572, 17)
        Me.btnEnviarSMS.Name = "btnEnviarSMS"
        Me.btnEnviarSMS.Size = New System.Drawing.Size(135, 23)
        Me.btnEnviarSMS.TabIndex = 6
        Me.btnEnviarSMS.Text = "Enviar SMS"
        Me.btnEnviarSMS.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnEnviarEmail
        '
        Me.btnEnviarEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarEmail.Image = Global.INTERACTI.My.Resources.Resources.email
        Me.btnEnviarEmail.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnEnviarEmail.Location = New System.Drawing.Point(290, 17)
        Me.btnEnviarEmail.Name = "btnEnviarEmail"
        Me.btnEnviarEmail.Size = New System.Drawing.Size(135, 23)
        Me.btnEnviarEmail.TabIndex = 5
        Me.btnEnviarEmail.Text = "Enviar Email"
        Me.btnEnviarEmail.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnEnviarProtesto
        '
        Me.btnEnviarProtesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarProtesto.Image = CType(resources.GetObject("btnEnviarProtesto.Image"), System.Drawing.Image)
        Me.btnEnviarProtesto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnEnviarProtesto.Location = New System.Drawing.Point(431, 17)
        Me.btnEnviarProtesto.Name = "btnEnviarProtesto"
        Me.btnEnviarProtesto.Size = New System.Drawing.Size(135, 23)
        Me.btnEnviarProtesto.TabIndex = 4
        Me.btnEnviarProtesto.Text = "Enviar para Protesto"
        Me.btnEnviarProtesto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(713, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(135, 23)
        Me.btnImprimir.TabIndex = 0
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(854, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnProcurarCliente)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataVencimentoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataVencimentoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.txtClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblDataVencimentoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(1146, 59)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarCliente
        '
        Me.btnProcurarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarCliente.FlatAppearance.BorderSize = 0
        Me.btnProcurarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCliente.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCliente.Location = New System.Drawing.Point(820, 14)
        Me.btnProcurarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCliente.Name = "btnProcurarCliente"
        Me.btnProcurarCliente.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCliente.TabIndex = 11
        Me.btnProcurarCliente.TabStop = False
        Me.btnProcurarCliente.UseVisualStyleBackColor = True
        '
        'dtpDataEmissaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(192, 33)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(97, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 4
        '
        'dtpDataEmissaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(91, 33)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(95, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 3
        '
        'dtpDataVencimentoTerminoFiltro
        '
        Me.dtpDataVencimentoTerminoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataVencimentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoTerminoFiltro.Location = New System.Drawing.Point(944, 32)
        Me.dtpDataVencimentoTerminoFiltro.Name = "dtpDataVencimentoTerminoFiltro"
        Me.dtpDataVencimentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataVencimentoTerminoFiltro.Size = New System.Drawing.Size(96, 20)
        Me.dtpDataVencimentoTerminoFiltro.TabIndex = 9
        '
        'dtpDataVencimentoInicioFiltro
        '
        Me.dtpDataVencimentoInicioFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataVencimentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoInicioFiltro.Location = New System.Drawing.Point(843, 33)
        Me.dtpDataVencimentoInicioFiltro.Name = "dtpDataVencimentoInicioFiltro"
        Me.dtpDataVencimentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataVencimentoInicioFiltro.Size = New System.Drawing.Size(95, 20)
        Me.dtpDataVencimentoInicioFiltro.TabIndex = 8
        '
        'txtClienteFiltro
        '
        Me.txtClienteFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClienteFiltro.Location = New System.Drawing.Point(295, 33)
        Me.txtClienteFiltro.MaxLength = 20
        Me.txtClienteFiltro.Name = "txtClienteFiltro"
        Me.txtClienteFiltro.Size = New System.Drawing.Size(542, 20)
        Me.txtClienteFiltro.TabIndex = 6
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(88, 16)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 2
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'txtNumeroDocumentoFiltro
        '
        Me.txtNumeroDocumentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumentoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumentoFiltro.MaxLength = 20
        Me.txtNumeroDocumentoFiltro.Name = "txtNumeroDocumentoFiltro"
        Me.txtNumeroDocumentoFiltro.Size = New System.Drawing.Size(76, 20)
        Me.txtNumeroDocumentoFiltro.TabIndex = 1
        '
        'lblNumeroDocumentoFiltro
        '
        Me.lblNumeroDocumentoFiltro.AutoSize = True
        Me.lblNumeroDocumentoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumentoFiltro.Name = "lblNumeroDocumentoFiltro"
        Me.lblNumeroDocumentoFiltro.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumentoFiltro.TabIndex = 0
        Me.lblNumeroDocumentoFiltro.Text = "Nº Documento:"
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.Location = New System.Drawing.Point(292, 16)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteFiltro.TabIndex = 5
        Me.lblClienteFiltro.Text = "Cliente:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(1046, 29)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 12
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDataVencimentoFiltro
        '
        Me.lblDataVencimentoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataVencimentoFiltro.AutoSize = True
        Me.lblDataVencimentoFiltro.Location = New System.Drawing.Point(840, 15)
        Me.lblDataVencimentoFiltro.Name = "lblDataVencimentoFiltro"
        Me.lblDataVencimentoFiltro.Size = New System.Drawing.Size(91, 14)
        Me.lblDataVencimentoFiltro.TabIndex = 7
        Me.lblDataVencimentoFiltro.Text = "Data Vencimento:"
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(1164, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagProtesto})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.UiGroupBox1)
        Me.pagListagem.Controls.Add(Me.grpSMS)
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgrupaGrid)
        Me.pagListagem.Controls.Add(Me.btnConfiguraGrid)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(1162, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Cobrança"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.lblLegendaGeradoArquivo)
        Me.UiGroupBox1.Controls.Add(Me.picLegendaGeradoArquivo)
        Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 480)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(186, 54)
        Me.UiGroupBox1.TabIndex = 98
        Me.UiGroupBox1.Text = "Legenda"
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaGeradoArquivo
        '
        Me.lblLegendaGeradoArquivo.AutoSize = True
        Me.lblLegendaGeradoArquivo.Location = New System.Drawing.Point(48, 24)
        Me.lblLegendaGeradoArquivo.Name = "lblLegendaGeradoArquivo"
        Me.lblLegendaGeradoArquivo.Size = New System.Drawing.Size(105, 14)
        Me.lblLegendaGeradoArquivo.TabIndex = 1
        Me.lblLegendaGeradoArquivo.Text = "Gerada Carta Boleto"
        '
        'picLegendaGeradoArquivo
        '
        Me.picLegendaGeradoArquivo.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaGeradoArquivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaGeradoArquivo.Location = New System.Drawing.Point(32, 24)
        Me.picLegendaGeradoArquivo.Name = "picLegendaGeradoArquivo"
        Me.picLegendaGeradoArquivo.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaGeradoArquivo.TabIndex = 4
        Me.picLegendaGeradoArquivo.TabStop = False
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
        Me.grpSMS.Location = New System.Drawing.Point(8, 403)
        Me.grpSMS.Name = "grpSMS"
        Me.grpSMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSMS.Size = New System.Drawing.Size(1146, 75)
        Me.grpSMS.TabIndex = 97
        Me.grpSMS.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpSMS.VisualStyleManager = Me.vsmMain
        '
        'cboTextoSMS
        '
        Me.cboTextoSMS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTextoSMS.AutoSize = False
        Me.cboTextoSMS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTextoSMS.Location = New System.Drawing.Point(7, 34)
        Me.cboTextoSMS.Name = "cboTextoSMS"
        Me.cboTextoSMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTextoSMS.Size = New System.Drawing.Size(1130, 20)
        Me.cboTextoSMS.TabIndex = 22
        '
        'btnCadastrarSMS
        '
        Me.btnCadastrarSMS.FlatAppearance.BorderSize = 0
        Me.btnCadastrarSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarSMS.Image = CType(resources.GetObject("btnCadastrarSMS.Image"), System.Drawing.Image)
        Me.btnCadastrarSMS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarSMS.Location = New System.Drawing.Point(7, 17)
        Me.btnCadastrarSMS.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarSMS.Name = "btnCadastrarSMS"
        Me.btnCadastrarSMS.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarSMS.TabIndex = 23
        Me.btnCadastrarSMS.TabStop = False
        Me.btnCadastrarSMS.UseVisualStyleBackColor = True
        '
        'lblMensagemSMS
        '
        Me.lblMensagemSMS.AutoSize = True
        Me.lblMensagemSMS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMensagemSMS.Location = New System.Drawing.Point(23, 16)
        Me.lblMensagemSMS.Name = "lblMensagemSMS"
        Me.lblMensagemSMS.Size = New System.Drawing.Size(87, 14)
        Me.lblMensagemSMS.TabIndex = 20
        Me.lblMensagemSMS.Text = "Mensagem SMS:"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 380)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 91
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgrupaGrid
        '
        Me.btnAgrupaGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgrupaGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgrupaGrid.FlatAppearance.BorderSize = 0
        Me.btnAgrupaGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgrupaGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgrupaGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgrupaGrid.Location = New System.Drawing.Point(34, 380)
        Me.btnAgrupaGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgrupaGrid.Name = "btnAgrupaGrid"
        Me.btnAgrupaGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgrupaGrid.TabIndex = 96
        Me.btnAgrupaGrid.TabStop = False
        Me.btnAgrupaGrid.UseVisualStyleBackColor = False
        '
        'btnConfiguraGrid
        '
        Me.btnConfiguraGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfiguraGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfiguraGrid.FlatAppearance.BorderSize = 0
        Me.btnConfiguraGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguraGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfiguraGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfiguraGrid.Location = New System.Drawing.Point(10, 380)
        Me.btnConfiguraGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfiguraGrid.Name = "btnConfiguraGrid"
        Me.btnConfiguraGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfiguraGrid.TabIndex = 95
        Me.btnConfiguraGrid.TabStop = False
        Me.btnConfiguraGrid.UseVisualStyleBackColor = False
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
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 68)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(1146, 329)
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
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 333)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 10
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 333)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'pagProtesto
        '
        Me.pagProtesto.Controls.Add(Me.grpLegenda)
        Me.pagProtesto.Controls.Add(Me.grpProtesto)
        Me.pagProtesto.Controls.Add(Me.btnAgrupaGridProtesto)
        Me.pagProtesto.Controls.Add(Me.btnConfiguraGridProtesto)
        Me.pagProtesto.Controls.Add(Me.grdProtesto)
        Me.pagProtesto.Controls.Add(Me.grpControleProtesto)
        Me.pagProtesto.Location = New System.Drawing.Point(1, 22)
        Me.pagProtesto.Name = "pagProtesto"
        Me.pagProtesto.Size = New System.Drawing.Size(1162, 543)
        Me.pagProtesto.TabStop = True
        Me.pagProtesto.Text = "Protesto"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblTituloAberto)
        Me.grpLegenda.Controls.Add(Me.picTituloAberto)
        Me.grpLegenda.Controls.Add(Me.lblTituloCancelado)
        Me.grpLegenda.Controls.Add(Me.picTituloCancelado)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(3, 489)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(158, 51)
        Me.grpLegenda.TabIndex = 98
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblTituloAberto
        '
        Me.lblTituloAberto.AutoSize = True
        Me.lblTituloAberto.Location = New System.Drawing.Point(28, 13)
        Me.lblTituloAberto.Name = "lblTituloAberto"
        Me.lblTituloAberto.Size = New System.Drawing.Size(110, 14)
        Me.lblTituloAberto.TabIndex = 0
        Me.lblTituloAberto.Text = "Aguardando Protesto"
        '
        'picTituloAberto
        '
        Me.picTituloAberto.BackColor = System.Drawing.Color.DarkGray
        Me.picTituloAberto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTituloAberto.Location = New System.Drawing.Point(9, 13)
        Me.picTituloAberto.Name = "picTituloAberto"
        Me.picTituloAberto.Size = New System.Drawing.Size(13, 14)
        Me.picTituloAberto.TabIndex = 14
        Me.picTituloAberto.TabStop = False
        '
        'lblTituloCancelado
        '
        Me.lblTituloCancelado.AutoSize = True
        Me.lblTituloCancelado.Location = New System.Drawing.Point(28, 33)
        Me.lblTituloCancelado.Name = "lblTituloCancelado"
        Me.lblTituloCancelado.Size = New System.Drawing.Size(59, 14)
        Me.lblTituloCancelado.TabIndex = 3
        Me.lblTituloCancelado.Text = "Protestado"
        '
        'picTituloCancelado
        '
        Me.picTituloCancelado.BackColor = System.Drawing.Color.Firebrick
        Me.picTituloCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTituloCancelado.Location = New System.Drawing.Point(9, 33)
        Me.picTituloCancelado.Name = "picTituloCancelado"
        Me.picTituloCancelado.Size = New System.Drawing.Size(13, 14)
        Me.picTituloCancelado.TabIndex = 8
        Me.picTituloCancelado.TabStop = False
        '
        'grpProtesto
        '
        Me.grpProtesto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProtesto.BackColor = System.Drawing.Color.Transparent
        Me.grpProtesto.Controls.Add(Me.cboStatusFiltro)
        Me.grpProtesto.Controls.Add(Me.lblStatusProtesto)
        Me.grpProtesto.Controls.Add(Me.dtpDataVencimentoTerminoProtesto)
        Me.grpProtesto.Controls.Add(Me.dtpDataVencimentoInicioProtesto)
        Me.grpProtesto.Controls.Add(Me.txtClienteProtesto)
        Me.grpProtesto.Controls.Add(Me.lblClienteProtesto)
        Me.grpProtesto.Controls.Add(Me.btnFiltrarProtesto)
        Me.grpProtesto.Controls.Add(Me.lblDataVencimentoFiltroProtesto)
        Me.grpProtesto.Location = New System.Drawing.Point(5, 3)
        Me.grpProtesto.Name = "grpProtesto"
        Me.grpProtesto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpProtesto.Size = New System.Drawing.Size(1154, 59)
        Me.grpProtesto.TabIndex = 97
        Me.grpProtesto.VisualStyleManager = Me.vsmMain
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(909, 32)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(139, 20)
        Me.cboStatusFiltro.TabIndex = 19
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'lblStatusProtesto
        '
        Me.lblStatusProtesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatusProtesto.AutoSize = True
        Me.lblStatusProtesto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStatusProtesto.Location = New System.Drawing.Point(906, 15)
        Me.lblStatusProtesto.Name = "lblStatusProtesto"
        Me.lblStatusProtesto.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusProtesto.TabIndex = 13
        Me.lblStatusProtesto.Text = "Status:"
        '
        'dtpDataVencimentoTerminoProtesto
        '
        Me.dtpDataVencimentoTerminoProtesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataVencimentoTerminoProtesto.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoTerminoProtesto.Location = New System.Drawing.Point(807, 32)
        Me.dtpDataVencimentoTerminoProtesto.Name = "dtpDataVencimentoTerminoProtesto"
        Me.dtpDataVencimentoTerminoProtesto.ShowCheckBox = True
        Me.dtpDataVencimentoTerminoProtesto.Size = New System.Drawing.Size(96, 20)
        Me.dtpDataVencimentoTerminoProtesto.TabIndex = 9
        '
        'dtpDataVencimentoInicioProtesto
        '
        Me.dtpDataVencimentoInicioProtesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataVencimentoInicioProtesto.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoInicioProtesto.Location = New System.Drawing.Point(706, 33)
        Me.dtpDataVencimentoInicioProtesto.Name = "dtpDataVencimentoInicioProtesto"
        Me.dtpDataVencimentoInicioProtesto.ShowCheckBox = True
        Me.dtpDataVencimentoInicioProtesto.Size = New System.Drawing.Size(95, 20)
        Me.dtpDataVencimentoInicioProtesto.TabIndex = 8
        '
        'txtClienteProtesto
        '
        Me.txtClienteProtesto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClienteProtesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClienteProtesto.Location = New System.Drawing.Point(6, 33)
        Me.txtClienteProtesto.MaxLength = 20
        Me.txtClienteProtesto.Name = "txtClienteProtesto"
        Me.txtClienteProtesto.Size = New System.Drawing.Size(694, 20)
        Me.txtClienteProtesto.TabIndex = 6
        '
        'lblClienteProtesto
        '
        Me.lblClienteProtesto.AutoSize = True
        Me.lblClienteProtesto.Location = New System.Drawing.Point(6, 16)
        Me.lblClienteProtesto.Name = "lblClienteProtesto"
        Me.lblClienteProtesto.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteProtesto.TabIndex = 5
        Me.lblClienteProtesto.Text = "Cliente:"
        '
        'btnFiltrarProtesto
        '
        Me.btnFiltrarProtesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrarProtesto.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrarProtesto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrarProtesto.Location = New System.Drawing.Point(1054, 29)
        Me.btnFiltrarProtesto.Name = "btnFiltrarProtesto"
        Me.btnFiltrarProtesto.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrarProtesto.TabIndex = 12
        Me.btnFiltrarProtesto.Tag = ""
        Me.btnFiltrarProtesto.Text = "Filtrar"
        Me.btnFiltrarProtesto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDataVencimentoFiltroProtesto
        '
        Me.lblDataVencimentoFiltroProtesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataVencimentoFiltroProtesto.AutoSize = True
        Me.lblDataVencimentoFiltroProtesto.Location = New System.Drawing.Point(703, 15)
        Me.lblDataVencimentoFiltroProtesto.Name = "lblDataVencimentoFiltroProtesto"
        Me.lblDataVencimentoFiltroProtesto.Size = New System.Drawing.Size(91, 14)
        Me.lblDataVencimentoFiltroProtesto.TabIndex = 7
        Me.lblDataVencimentoFiltroProtesto.Text = "Data Vencimento:"
        '
        'btnAgrupaGridProtesto
        '
        Me.btnAgrupaGridProtesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgrupaGridProtesto.BackColor = System.Drawing.Color.Transparent
        Me.btnAgrupaGridProtesto.FlatAppearance.BorderSize = 0
        Me.btnAgrupaGridProtesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgrupaGridProtesto.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgrupaGridProtesto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgrupaGridProtesto.Location = New System.Drawing.Point(29, 466)
        Me.btnAgrupaGridProtesto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgrupaGridProtesto.Name = "btnAgrupaGridProtesto"
        Me.btnAgrupaGridProtesto.Size = New System.Drawing.Size(24, 15)
        Me.btnAgrupaGridProtesto.TabIndex = 93
        Me.btnAgrupaGridProtesto.TabStop = False
        Me.btnAgrupaGridProtesto.UseVisualStyleBackColor = False
        '
        'btnConfiguraGridProtesto
        '
        Me.btnConfiguraGridProtesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfiguraGridProtesto.BackColor = System.Drawing.Color.Transparent
        Me.btnConfiguraGridProtesto.FlatAppearance.BorderSize = 0
        Me.btnConfiguraGridProtesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguraGridProtesto.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfiguraGridProtesto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfiguraGridProtesto.Location = New System.Drawing.Point(5, 466)
        Me.btnConfiguraGridProtesto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfiguraGridProtesto.Name = "btnConfiguraGridProtesto"
        Me.btnConfiguraGridProtesto.Size = New System.Drawing.Size(24, 15)
        Me.btnConfiguraGridProtesto.TabIndex = 92
        Me.btnConfiguraGridProtesto.TabStop = False
        Me.btnConfiguraGridProtesto.UseVisualStyleBackColor = False
        '
        'grdProtesto
        '
        Me.grdProtesto.AlternatingColors = True
        Me.grdProtesto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdProtesto_DesignTimeLayout.LayoutString = resources.GetString("grdProtesto_DesignTimeLayout.LayoutString")
        Me.grdProtesto.DesignTimeLayout = grdProtesto_DesignTimeLayout
        Me.grdProtesto.DynamicFiltering = True
        Me.grdProtesto.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdProtesto.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdProtesto.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdProtesto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProtesto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProtesto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProtesto.GroupByBoxVisible = False
        Me.grdProtesto.Location = New System.Drawing.Point(3, 68)
        Me.grdProtesto.Name = "grdProtesto"
        Me.grdProtesto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProtesto.RecordNavigator = True
        Me.grdProtesto.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdProtesto.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProtesto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProtesto.Size = New System.Drawing.Size(1156, 415)
        Me.grdProtesto.TabIndex = 96
        Me.grdProtesto.TabStop = False
        Me.grdProtesto.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProtesto.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdProtesto.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdProtesto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdProtesto.VisualStyleManager = Me.vsmMain
        '
        'grpControleProtesto
        '
        Me.grpControleProtesto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControleProtesto.BackColor = System.Drawing.Color.Transparent
        Me.grpControleProtesto.Controls.Add(Me.btnPlanilhaProtesto)
        Me.grpControleProtesto.Controls.Add(Me.btnDesfazerProtesto)
        Me.grpControleProtesto.Controls.Add(Me.btnSairProtesto)
        Me.grpControleProtesto.Location = New System.Drawing.Point(167, 489)
        Me.grpControleProtesto.Name = "grpControleProtesto"
        Me.grpControleProtesto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleProtesto.Size = New System.Drawing.Size(992, 51)
        Me.grpControleProtesto.TabIndex = 95
        Me.grpControleProtesto.VisualStyleManager = Me.vsmMain
        '
        'btnPlanilhaProtesto
        '
        Me.btnPlanilhaProtesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPlanilhaProtesto.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnPlanilhaProtesto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPlanilhaProtesto.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnPlanilhaProtesto.Location = New System.Drawing.Point(640, 17)
        Me.btnPlanilhaProtesto.Name = "btnPlanilhaProtesto"
        Me.btnPlanilhaProtesto.Size = New System.Drawing.Size(120, 23)
        Me.btnPlanilhaProtesto.TabIndex = 5
        Me.btnPlanilhaProtesto.Text = "Planilha de Envio"
        Me.btnPlanilhaProtesto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnDesfazerProtesto
        '
        Me.btnDesfazerProtesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDesfazerProtesto.Image = CType(resources.GetObject("btnDesfazerProtesto.Image"), System.Drawing.Image)
        Me.btnDesfazerProtesto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnDesfazerProtesto.Location = New System.Drawing.Point(766, 17)
        Me.btnDesfazerProtesto.Name = "btnDesfazerProtesto"
        Me.btnDesfazerProtesto.Size = New System.Drawing.Size(120, 23)
        Me.btnDesfazerProtesto.TabIndex = 4
        Me.btnDesfazerProtesto.Text = "Desfazer Protesto"
        Me.btnDesfazerProtesto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSairProtesto
        '
        Me.btnSairProtesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSairProtesto.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSairProtesto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSairProtesto.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSairProtesto.Location = New System.Drawing.Point(892, 17)
        Me.btnSairProtesto.Name = "btnSairProtesto"
        Me.btnSairProtesto.Size = New System.Drawing.Size(91, 23)
        Me.btnSairProtesto.TabIndex = 3
        Me.btnSairProtesto.Text = "Sair"
        Me.btnSairProtesto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrFinReceitaCobranca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFinReceitaCobranca"
        Me.Size = New System.Drawing.Size(1164, 566)
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.picLegendaGeradoArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSMS.ResumeLayout(False)
        Me.grpSMS.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagProtesto.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picTituloAberto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTituloCancelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpProtesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProtesto.ResumeLayout(False)
        Me.grpProtesto.PerformLayout()
        CType(Me.grdProtesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControleProtesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleProtesto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataVencimentoFiltro As System.Windows.Forms.Label
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents txtClienteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents dtpDataVencimentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataVencimentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnProcurarCliente As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagProtesto As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnAgrupaGridProtesto As System.Windows.Forms.Button
    Friend WithEvents btnConfiguraGridProtesto As System.Windows.Forms.Button
    Friend WithEvents grpControleProtesto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSairProtesto As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdProtesto As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnEnviarSMS As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnEnviarEmail As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnEnviarProtesto As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCartaBoleto As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAgrupaGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfiguraGrid As System.Windows.Forms.Button
    Friend WithEvents grpSMS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboTextoSMS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarSMS As System.Windows.Forms.Button
    Friend WithEvents lblMensagemSMS As System.Windows.Forms.Label
    Friend WithEvents btnRelatorioEntrega As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpProtesto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataVencimentoTerminoProtesto As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataVencimentoInicioProtesto As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtClienteProtesto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblClienteProtesto As System.Windows.Forms.Label
    Friend WithEvents btnFiltrarProtesto As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataVencimentoFiltroProtesto As System.Windows.Forms.Label
    Friend WithEvents btnPlanilhaProtesto As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblStatusProtesto As System.Windows.Forms.Label
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTituloAberto As System.Windows.Forms.Label
    Friend WithEvents picTituloAberto As System.Windows.Forms.PictureBox
    Friend WithEvents lblTituloCancelado As System.Windows.Forms.Label
    Friend WithEvents picTituloCancelado As System.Windows.Forms.PictureBox
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents btnDesfazerProtesto As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaGeradoArquivo As System.Windows.Forms.Label
    Friend WithEvents picLegendaGeradoArquivo As System.Windows.Forms.PictureBox

End Class
