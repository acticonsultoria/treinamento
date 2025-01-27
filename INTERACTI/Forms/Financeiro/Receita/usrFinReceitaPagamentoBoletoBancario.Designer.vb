<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFinReceitaPagamentoBoletoBancario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFinReceitaPagamentoBoletoBancario))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdParcela_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblParcelaVencimentoFuturo = New System.Windows.Forms.Label()
        Me.picParcelaVencimentoFuturo = New System.Windows.Forms.PictureBox()
        Me.lblParcelaVencimentoAtrasado = New System.Windows.Forms.Label()
        Me.picParcelaVencimentoAtrasado = New System.Windows.Forms.PictureBox()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpValorSelecionado = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblValorTitulo = New System.Windows.Forms.Label()
        Me.lblLabelValorTitulo = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnPagar1 = New Janus.Windows.EditControls.UIButton()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataVencimentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataVencimentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtCarteiraFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCarteiraFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoPagamentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoPagamentoFiltro = New System.Windows.Forms.Label()
        Me.txtValorFiltro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorFiltro = New System.Windows.Forms.Label()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroDocumentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumentoFiltro = New System.Windows.Forms.Label()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblDataVencimentoFiltro = New System.Windows.Forms.Label()
        Me.txtClienteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboTipoDocumentoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoDocumentoFiltro = New System.Windows.Forms.Label()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.webBrowser = New System.Windows.Forms.WebBrowser()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridParcela = New System.Windows.Forms.Button()
        Me.btnAgruparGridParcela = New System.Windows.Forms.Button()
        Me.btnConfigurarGridParcela = New System.Windows.Forms.Button()
        Me.grpControle2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnPagar = New Janus.Windows.EditControls.UIButton()
        Me.grdParcela = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picParcelaVencimentoFuturo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picParcelaVencimentoAtrasado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpValorSelecionado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpValorSelecionado.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDados.SuspendLayout()
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle2.SuspendLayout()
        CType(Me.grdParcela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.grpValorSelecionado)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.webBrowser)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(998, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Boletos Bancários"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 30
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 28
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 29
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblParcelaVencimentoFuturo)
        Me.grpLegenda.Controls.Add(Me.picParcelaVencimentoFuturo)
        Me.grpLegenda.Controls.Add(Me.lblParcelaVencimentoAtrasado)
        Me.grpLegenda.Controls.Add(Me.picParcelaVencimentoAtrasado)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(191, 51)
        Me.grpLegenda.TabIndex = 2
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblParcelaVencimentoFuturo
        '
        Me.lblParcelaVencimentoFuturo.AutoSize = True
        Me.lblParcelaVencimentoFuturo.Location = New System.Drawing.Point(28, 13)
        Me.lblParcelaVencimentoFuturo.Name = "lblParcelaVencimentoFuturo"
        Me.lblParcelaVencimentoFuturo.Size = New System.Drawing.Size(159, 14)
        Me.lblParcelaVencimentoFuturo.TabIndex = 0
        Me.lblParcelaVencimentoFuturo.Text = "Boletos com Vencimento Futuro"
        '
        'picParcelaVencimentoFuturo
        '
        Me.picParcelaVencimentoFuturo.BackColor = System.Drawing.Color.DarkGray
        Me.picParcelaVencimentoFuturo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picParcelaVencimentoFuturo.Location = New System.Drawing.Point(9, 13)
        Me.picParcelaVencimentoFuturo.Name = "picParcelaVencimentoFuturo"
        Me.picParcelaVencimentoFuturo.Size = New System.Drawing.Size(13, 14)
        Me.picParcelaVencimentoFuturo.TabIndex = 14
        Me.picParcelaVencimentoFuturo.TabStop = False
        '
        'lblParcelaVencimentoAtrasado
        '
        Me.lblParcelaVencimentoAtrasado.AutoSize = True
        Me.lblParcelaVencimentoAtrasado.Location = New System.Drawing.Point(28, 30)
        Me.lblParcelaVencimentoAtrasado.Name = "lblParcelaVencimentoAtrasado"
        Me.lblParcelaVencimentoAtrasado.Size = New System.Drawing.Size(96, 14)
        Me.lblParcelaVencimentoAtrasado.TabIndex = 1
        Me.lblParcelaVencimentoAtrasado.Text = "Boletos Atrasados"
        '
        'picParcelaVencimentoAtrasado
        '
        Me.picParcelaVencimentoAtrasado.BackColor = System.Drawing.Color.Firebrick
        Me.picParcelaVencimentoAtrasado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picParcelaVencimentoAtrasado.Location = New System.Drawing.Point(9, 30)
        Me.picParcelaVencimentoAtrasado.Name = "picParcelaVencimentoAtrasado"
        Me.picParcelaVencimentoAtrasado.Size = New System.Drawing.Size(13, 14)
        Me.picParcelaVencimentoAtrasado.TabIndex = 8
        Me.picParcelaVencimentoAtrasado.TabStop = False
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
        'grpValorSelecionado
        '
        Me.grpValorSelecionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpValorSelecionado.BackColor = System.Drawing.Color.Transparent
        Me.grpValorSelecionado.Controls.Add(Me.lblValorTitulo)
        Me.grpValorSelecionado.Controls.Add(Me.lblLabelValorTitulo)
        Me.grpValorSelecionado.Location = New System.Drawing.Point(208, 483)
        Me.grpValorSelecionado.Name = "grpValorSelecionado"
        Me.grpValorSelecionado.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpValorSelecionado.Size = New System.Drawing.Size(207, 51)
        Me.grpValorSelecionado.TabIndex = 3
        Me.grpValorSelecionado.VisualStyleManager = Me.vsmMain
        '
        'lblValorTitulo
        '
        Me.lblValorTitulo.AutoSize = True
        Me.lblValorTitulo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblValorTitulo.Location = New System.Drawing.Point(120, 22)
        Me.lblValorTitulo.Name = "lblValorTitulo"
        Me.lblValorTitulo.Size = New System.Drawing.Size(44, 14)
        Me.lblValorTitulo.TabIndex = 1
        Me.lblValorTitulo.Text = "R$ 0,00"
        '
        'lblLabelValorTitulo
        '
        Me.lblLabelValorTitulo.AutoSize = True
        Me.lblLabelValorTitulo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLabelValorTitulo.Location = New System.Drawing.Point(6, 22)
        Me.lblLabelValorTitulo.Name = "lblLabelValorTitulo"
        Me.lblLabelValorTitulo.Size = New System.Drawing.Size(108, 14)
        Me.lblLabelValorTitulo.TabIndex = 0
        Me.lblLabelValorTitulo.Text = "Valor Selecionado:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnPagar1)
        Me.grpControle.Controls.Add(Me.lblCongelarColuna)
        Me.grpControle.Controls.Add(Me.cboCongelarColuna)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(424, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(566, 51)
        Me.grpControle.TabIndex = 4
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnPagar1
        '
        Me.btnPagar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPagar1.Image = Global.INTERACTI.My.Resources.aprovar
        Me.btnPagar1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPagar1.Location = New System.Drawing.Point(260, 17)
        Me.btnPagar1.Name = "btnPagar1"
        Me.btnPagar1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPagar1.Size = New System.Drawing.Size(200, 23)
        Me.btnPagar1.TabIndex = 13
        Me.btnPagar1.Text = "Baixar Boleto Bancário"
        Me.btnPagar1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 11
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 12
        Me.cboCongelarColuna.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(466, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.dtpDataVencimentoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataVencimentoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCarteiraFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCarteiraFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDocumentoPagamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroDocumentoPagamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtValorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblValorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblDataVencimentoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoDocumentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoDocumentoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'dtpDataVencimentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataVencimentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoTerminoFiltro.Location = New System.Drawing.Point(114, 74)
        Me.dtpDataVencimentoTerminoFiltro.Name = "dtpDataVencimentoTerminoFiltro"
        Me.dtpDataVencimentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataVencimentoTerminoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataVencimentoTerminoFiltro.TabIndex = 11
        '
        'dtpDataVencimentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataVencimentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataVencimentoInicioFiltro.Location = New System.Drawing.Point(9, 74)
        Me.dtpDataVencimentoInicioFiltro.Name = "dtpDataVencimentoInicioFiltro"
        Me.dtpDataVencimentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataVencimentoInicioFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataVencimentoInicioFiltro.TabIndex = 10
        '
        'dtpDataEmissaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(403, 34)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 6
        '
        'dtpDataEmissaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(298, 34)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 5
        '
        'txtCarteiraFiltro
        '
        Me.txtCarteiraFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCarteiraFiltro.Location = New System.Drawing.Point(219, 74)
        Me.txtCarteiraFiltro.MaxLength = 10
        Me.txtCarteiraFiltro.Name = "txtCarteiraFiltro"
        Me.txtCarteiraFiltro.Size = New System.Drawing.Size(73, 20)
        Me.txtCarteiraFiltro.TabIndex = 13
        '
        'lblCarteiraFiltro
        '
        Me.lblCarteiraFiltro.AutoSize = True
        Me.lblCarteiraFiltro.Location = New System.Drawing.Point(216, 57)
        Me.lblCarteiraFiltro.Name = "lblCarteiraFiltro"
        Me.lblCarteiraFiltro.Size = New System.Drawing.Size(48, 14)
        Me.lblCarteiraFiltro.TabIndex = 12
        Me.lblCarteiraFiltro.Text = "Carteira:"
        '
        'txtNumeroDocumentoPagamentoFiltro
        '
        Me.txtNumeroDocumentoPagamentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumentoPagamentoFiltro.Location = New System.Drawing.Point(298, 74)
        Me.txtNumeroDocumentoPagamentoFiltro.MaxLength = 100
        Me.txtNumeroDocumentoPagamentoFiltro.Name = "txtNumeroDocumentoPagamentoFiltro"
        Me.txtNumeroDocumentoPagamentoFiltro.Size = New System.Drawing.Size(204, 20)
        Me.txtNumeroDocumentoPagamentoFiltro.TabIndex = 15
        '
        'lblNumeroDocumentoPagamentoFiltro
        '
        Me.lblNumeroDocumentoPagamentoFiltro.AutoSize = True
        Me.lblNumeroDocumentoPagamentoFiltro.Location = New System.Drawing.Point(295, 57)
        Me.lblNumeroDocumentoPagamentoFiltro.Name = "lblNumeroDocumentoPagamentoFiltro"
        Me.lblNumeroDocumentoPagamentoFiltro.Size = New System.Drawing.Size(150, 14)
        Me.lblNumeroDocumentoPagamentoFiltro.TabIndex = 14
        Me.lblNumeroDocumentoPagamentoFiltro.Text = "Nº Documento de Pagamento:"
        '
        'txtValorFiltro
        '
        Me.txtValorFiltro.Location = New System.Drawing.Point(508, 74)
        Me.txtValorFiltro.Name = "txtValorFiltro"
        Me.txtValorFiltro.Size = New System.Drawing.Size(99, 20)
        Me.txtValorFiltro.TabIndex = 17
        Me.txtValorFiltro.Text = "0,00"
        Me.txtValorFiltro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorFiltro
        '
        Me.lblValorFiltro.AutoSize = True
        Me.lblValorFiltro.Location = New System.Drawing.Point(505, 57)
        Me.lblValorFiltro.Name = "lblValorFiltro"
        Me.lblValorFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblValorFiltro.TabIndex = 16
        Me.lblValorFiltro.Text = "Valor:"
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(295, 17)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 4
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'txtNumeroDocumentoFiltro
        '
        Me.txtNumeroDocumentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumentoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumentoFiltro.MaxLength = 20
        Me.txtNumeroDocumentoFiltro.Name = "txtNumeroDocumentoFiltro"
        Me.txtNumeroDocumentoFiltro.Size = New System.Drawing.Size(99, 20)
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
        Me.lblClienteFiltro.Location = New System.Drawing.Point(505, 17)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteFiltro.TabIndex = 7
        Me.lblClienteFiltro.Text = "Cliente:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 18
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDataVencimentoFiltro
        '
        Me.lblDataVencimentoFiltro.AutoSize = True
        Me.lblDataVencimentoFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblDataVencimentoFiltro.Name = "lblDataVencimentoFiltro"
        Me.lblDataVencimentoFiltro.Size = New System.Drawing.Size(91, 14)
        Me.lblDataVencimentoFiltro.TabIndex = 9
        Me.lblDataVencimentoFiltro.Text = "Data Vencimento:"
        '
        'txtClienteFiltro
        '
        Me.txtClienteFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClienteFiltro.Location = New System.Drawing.Point(508, 34)
        Me.txtClienteFiltro.MaxLength = 20
        Me.txtClienteFiltro.Name = "txtClienteFiltro"
        Me.txtClienteFiltro.Size = New System.Drawing.Size(358, 20)
        Me.txtClienteFiltro.TabIndex = 8
        '
        'cboTipoDocumentoFiltro
        '
        Me.cboTipoDocumentoFiltro.AutoSize = False
        Me.cboTipoDocumentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoDocumentoFiltro.Location = New System.Drawing.Point(114, 34)
        Me.cboTipoDocumentoFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoDocumentoFiltro.Name = "cboTipoDocumentoFiltro"
        Me.cboTipoDocumentoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoDocumentoFiltro.Size = New System.Drawing.Size(178, 20)
        Me.cboTipoDocumentoFiltro.TabIndex = 3
        '
        'lblTipoDocumentoFiltro
        '
        Me.lblTipoDocumentoFiltro.AutoSize = True
        Me.lblTipoDocumentoFiltro.Location = New System.Drawing.Point(111, 17)
        Me.lblTipoDocumentoFiltro.Name = "lblTipoDocumentoFiltro"
        Me.lblTipoDocumentoFiltro.Size = New System.Drawing.Size(102, 14)
        Me.lblTipoDocumentoFiltro.TabIndex = 2
        Me.lblTipoDocumentoFiltro.Text = "Tipo do Documento:"
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 4
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.Location = New System.Drawing.Point(8, 116)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 364)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'webBrowser
        '
        Me.webBrowser.Location = New System.Drawing.Point(802, 378)
        Me.webBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBrowser.Name = "webBrowser"
        Me.webBrowser.Size = New System.Drawing.Size(72, 31)
        Me.webBrowser.TabIndex = 14
        Me.webBrowser.Visible = False
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnExcelGridParcela)
        Me.pagDados.Controls.Add(Me.btnAgruparGridParcela)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridParcela)
        Me.pagDados.Controls.Add(Me.grpControle2)
        Me.pagDados.Controls.Add(Me.grdParcela)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(998, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Baixar Boletos Bancários"
        '
        'btnExcelGridParcela
        '
        Me.btnExcelGridParcela.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridParcela.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridParcela.FlatAppearance.BorderSize = 0
        Me.btnExcelGridParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridParcela.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGridParcela.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridParcela.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGridParcela.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridParcela.Name = "btnExcelGridParcela"
        Me.btnExcelGridParcela.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridParcela.TabIndex = 33
        Me.btnExcelGridParcela.TabStop = False
        Me.btnExcelGridParcela.UseVisualStyleBackColor = False
        '
        'btnAgruparGridParcela
        '
        Me.btnAgruparGridParcela.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridParcela.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridParcela.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridParcela.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridParcela.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridParcela.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGridParcela.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridParcela.Name = "btnAgruparGridParcela"
        Me.btnAgruparGridParcela.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridParcela.TabIndex = 31
        Me.btnAgruparGridParcela.TabStop = False
        Me.btnAgruparGridParcela.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridParcela
        '
        Me.btnConfigurarGridParcela.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridParcela.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridParcela.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridParcela.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridParcela.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridParcela.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGridParcela.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridParcela.Name = "btnConfigurarGridParcela"
        Me.btnConfigurarGridParcela.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridParcela.TabIndex = 32
        Me.btnConfigurarGridParcela.TabStop = False
        Me.btnConfigurarGridParcela.UseVisualStyleBackColor = False
        '
        'grpControle2
        '
        Me.grpControle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle2.BackColor = System.Drawing.Color.Transparent
        Me.grpControle2.Controls.Add(Me.btnVoltar)
        Me.grpControle2.Controls.Add(Me.btnPagar)
        Me.grpControle2.Location = New System.Drawing.Point(8, 483)
        Me.grpControle2.Name = "grpControle2"
        Me.grpControle2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle2.Size = New System.Drawing.Size(982, 51)
        Me.grpControle2.TabIndex = 16
        Me.grpControle2.VisualStyleManager = Me.vsmMain
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(883, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(90, 23)
        Me.btnVoltar.TabIndex = 1
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnPagar
        '
        Me.btnPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPagar.Image = Global.INTERACTI.My.Resources.aprovar
        Me.btnPagar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPagar.Location = New System.Drawing.Point(677, 17)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPagar.Size = New System.Drawing.Size(200, 23)
        Me.btnPagar.TabIndex = 0
        Me.btnPagar.Text = "Baixar Boleto Bancário"
        Me.btnPagar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdParcela
        '
        Me.grdParcela.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdParcela_DesignTimeLayout.LayoutString = resources.GetString("grdParcela_DesignTimeLayout.LayoutString")
        Me.grdParcela.DesignTimeLayout = grdParcela_DesignTimeLayout
        Me.grdParcela.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdParcela.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdParcela.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdParcela.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdParcela.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdParcela.GroupByBoxVisible = False
        Me.grdParcela.Location = New System.Drawing.Point(8, 9)
        Me.grdParcela.Name = "grdParcela"
        Me.grdParcela.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdParcela.RecordNavigator = True
        Me.grdParcela.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdParcela.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdParcela.Size = New System.Drawing.Size(982, 471)
        Me.grdParcela.TabIndex = 15
        Me.grdParcela.TabStop = False
        Me.grdParcela.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdParcela.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdParcela.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdParcela.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdParcela.VisualStyleManager = Me.vsmMain
        '
        'usrFinReceitaPagamentoBoletoBancario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFinReceitaPagamentoBoletoBancario"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picParcelaVencimentoFuturo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picParcelaVencimentoAtrasado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpValorSelecionado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpValorSelecionado.ResumeLayout(False)
        Me.grpValorSelecionado.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.grpControle.PerformLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpControle2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle2.ResumeLayout(False)
        CType(Me.grdParcela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNumeroDocumentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataVencimentoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblParcelaVencimentoFuturo As System.Windows.Forms.Label
    Friend WithEvents picParcelaVencimentoFuturo As System.Windows.Forms.PictureBox
    Friend WithEvents lblParcelaVencimentoAtrasado As System.Windows.Forms.Label
    Friend WithEvents picParcelaVencimentoAtrasado As System.Windows.Forms.PictureBox
    Friend WithEvents txtValorFiltro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorFiltro As System.Windows.Forms.Label
    Friend WithEvents lblTipoDocumentoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumentoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtClienteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents txtNumeroDocumentoPagamentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumentoPagamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCarteiraFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCarteiraFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataVencimentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataVencimentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents webBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents grpValorSelecionado As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblValorTitulo As System.Windows.Forms.Label
    Friend WithEvents lblLabelValorTitulo As System.Windows.Forms.Label
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdParcela As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpControle2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Private WithEvents btnPagar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Private WithEvents btnPagar1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelGridParcela As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridParcela As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridParcela As System.Windows.Forms.Button

End Class
