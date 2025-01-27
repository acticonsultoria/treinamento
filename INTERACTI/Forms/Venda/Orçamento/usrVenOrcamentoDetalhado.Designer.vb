<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrVenOrcamentoDetalhado
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
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column12.Image")
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column15.Image")
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrVenOrcamentoDetalhado))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegandaExpirado = New System.Windows.Forms.Label()
        Me.picLegendaExpirado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaEncerrado = New System.Windows.Forms.Label()
        Me.picLegendaEncerrado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAprovado = New System.Windows.Forms.Label()
        Me.picLegendaAprovado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaDeclinado = New System.Windows.Forms.Label()
        Me.picLegendaDeclinado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaNegociacao = New System.Windows.Forms.Label()
        Me.picLegendaNegociacao = New System.Windows.Forms.PictureBox()
        Me.lblLegendaReprovado = New System.Windows.Forms.Label()
        Me.picLegendaReprovado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaElaboracao = New System.Windows.Forms.Label()
        Me.picLegendaElaboracao = New System.Windows.Forms.PictureBox()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtClienteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroOrcamentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroOrcamentoFiltro = New System.Windows.Forms.Label()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaExpirado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaEncerrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaAprovado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaDeclinado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaNegociacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaReprovado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaElaboracao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
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
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Orçamento de Venda - Lista detalhada"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegandaExpirado)
        Me.grpLegenda.Controls.Add(Me.picLegendaExpirado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaEncerrado)
        Me.grpLegenda.Controls.Add(Me.picLegendaEncerrado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAprovado)
        Me.grpLegenda.Controls.Add(Me.picLegendaAprovado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaDeclinado)
        Me.grpLegenda.Controls.Add(Me.picLegendaDeclinado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaNegociacao)
        Me.grpLegenda.Controls.Add(Me.picLegendaNegociacao)
        Me.grpLegenda.Controls.Add(Me.lblLegendaReprovado)
        Me.grpLegenda.Controls.Add(Me.picLegendaReprovado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaElaboracao)
        Me.grpLegenda.Controls.Add(Me.picLegendaElaboracao)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(384, 51)
        Me.grpLegenda.TabIndex = 90
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegandaExpirado
        '
        Me.lblLegandaExpirado.AutoSize = True
        Me.lblLegandaExpirado.Location = New System.Drawing.Point(224, 13)
        Me.lblLegandaExpirado.Name = "lblLegandaExpirado"
        Me.lblLegandaExpirado.Size = New System.Drawing.Size(49, 14)
        Me.lblLegandaExpirado.TabIndex = 27
        Me.lblLegandaExpirado.Text = "Expirado"
        '
        'picLegendaExpirado
        '
        Me.picLegendaExpirado.BackColor = System.Drawing.Color.Red
        Me.picLegendaExpirado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaExpirado.Location = New System.Drawing.Point(205, 13)
        Me.picLegendaExpirado.Name = "picLegendaExpirado"
        Me.picLegendaExpirado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaExpirado.TabIndex = 28
        Me.picLegendaExpirado.TabStop = False
        '
        'lblLegendaEncerrado
        '
        Me.lblLegendaEncerrado.AutoSize = True
        Me.lblLegendaEncerrado.Location = New System.Drawing.Point(224, 30)
        Me.lblLegendaEncerrado.Name = "lblLegendaEncerrado"
        Me.lblLegendaEncerrado.Size = New System.Drawing.Size(57, 14)
        Me.lblLegendaEncerrado.TabIndex = 25
        Me.lblLegendaEncerrado.Text = "Encerrado"
        '
        'picLegendaEncerrado
        '
        Me.picLegendaEncerrado.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaEncerrado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaEncerrado.Location = New System.Drawing.Point(205, 30)
        Me.picLegendaEncerrado.Name = "picLegendaEncerrado"
        Me.picLegendaEncerrado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaEncerrado.TabIndex = 26
        Me.picLegendaEncerrado.TabStop = False
        '
        'lblLegendaAprovado
        '
        Me.lblLegendaAprovado.AutoSize = True
        Me.lblLegendaAprovado.Location = New System.Drawing.Point(133, 13)
        Me.lblLegendaAprovado.Name = "lblLegendaAprovado"
        Me.lblLegendaAprovado.Size = New System.Drawing.Size(55, 14)
        Me.lblLegendaAprovado.TabIndex = 23
        Me.lblLegendaAprovado.Text = "Aprovado"
        '
        'picLegendaAprovado
        '
        Me.picLegendaAprovado.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaAprovado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAprovado.Location = New System.Drawing.Point(114, 13)
        Me.picLegendaAprovado.Name = "picLegendaAprovado"
        Me.picLegendaAprovado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAprovado.TabIndex = 24
        Me.picLegendaAprovado.TabStop = False
        '
        'lblLegendaDeclinado
        '
        Me.lblLegendaDeclinado.AutoSize = True
        Me.lblLegendaDeclinado.Location = New System.Drawing.Point(133, 30)
        Me.lblLegendaDeclinado.Name = "lblLegendaDeclinado"
        Me.lblLegendaDeclinado.Size = New System.Drawing.Size(54, 14)
        Me.lblLegendaDeclinado.TabIndex = 21
        Me.lblLegendaDeclinado.Text = "Declinado"
        '
        'picLegendaDeclinado
        '
        Me.picLegendaDeclinado.BackColor = System.Drawing.Color.Peru
        Me.picLegendaDeclinado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaDeclinado.Location = New System.Drawing.Point(114, 30)
        Me.picLegendaDeclinado.Name = "picLegendaDeclinado"
        Me.picLegendaDeclinado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaDeclinado.TabIndex = 22
        Me.picLegendaDeclinado.TabStop = False
        '
        'lblLegendaNegociacao
        '
        Me.lblLegendaNegociacao.AutoSize = True
        Me.lblLegendaNegociacao.Location = New System.Drawing.Point(28, 30)
        Me.lblLegendaNegociacao.Name = "lblLegendaNegociacao"
        Me.lblLegendaNegociacao.Size = New System.Drawing.Size(64, 14)
        Me.lblLegendaNegociacao.TabIndex = 2
        Me.lblLegendaNegociacao.Text = "Negociação"
        '
        'picLegendaNegociacao
        '
        Me.picLegendaNegociacao.BackColor = System.Drawing.Color.Purple
        Me.picLegendaNegociacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaNegociacao.Location = New System.Drawing.Point(9, 30)
        Me.picLegendaNegociacao.Name = "picLegendaNegociacao"
        Me.picLegendaNegociacao.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaNegociacao.TabIndex = 18
        Me.picLegendaNegociacao.TabStop = False
        '
        'lblLegendaReprovado
        '
        Me.lblLegendaReprovado.AutoSize = True
        Me.lblLegendaReprovado.Location = New System.Drawing.Point(309, 13)
        Me.lblLegendaReprovado.Name = "lblLegendaReprovado"
        Me.lblLegendaReprovado.Size = New System.Drawing.Size(60, 14)
        Me.lblLegendaReprovado.TabIndex = 3
        Me.lblLegendaReprovado.Text = "Reprovado"
        '
        'picLegendaReprovado
        '
        Me.picLegendaReprovado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaReprovado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaReprovado.Location = New System.Drawing.Point(290, 13)
        Me.picLegendaReprovado.Name = "picLegendaReprovado"
        Me.picLegendaReprovado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaReprovado.TabIndex = 16
        Me.picLegendaReprovado.TabStop = False
        '
        'lblLegendaElaboracao
        '
        Me.lblLegendaElaboracao.AutoSize = True
        Me.lblLegendaElaboracao.Location = New System.Drawing.Point(28, 13)
        Me.lblLegendaElaboracao.Name = "lblLegendaElaboracao"
        Me.lblLegendaElaboracao.Size = New System.Drawing.Size(61, 14)
        Me.lblLegendaElaboracao.TabIndex = 0
        Me.lblLegendaElaboracao.Text = "Elaboração"
        '
        'picLegendaElaboracao
        '
        Me.picLegendaElaboracao.BackColor = System.Drawing.Color.DarkGray
        Me.picLegendaElaboracao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaElaboracao.Location = New System.Drawing.Point(9, 13)
        Me.picLegendaElaboracao.Name = "picLegendaElaboracao"
        Me.picLegendaElaboracao.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaElaboracao.TabIndex = 4
        Me.picLegendaElaboracao.TabStop = False
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 89
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 14
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 9
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.txtClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroOrcamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroOrcamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 73)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtClienteFiltro
        '
        Me.txtClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClienteFiltro.Location = New System.Drawing.Point(114, 34)
        Me.txtClienteFiltro.MaxLength = 60
        Me.txtClienteFiltro.Name = "txtClienteFiltro"
        Me.txtClienteFiltro.Size = New System.Drawing.Size(222, 20)
        Me.txtClienteFiltro.TabIndex = 6
        '
        'txtNumeroOrcamentoFiltro
        '
        Me.txtNumeroOrcamentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOrcamentoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroOrcamentoFiltro.MaxLength = 20
        Me.txtNumeroOrcamentoFiltro.Name = "txtNumeroOrcamentoFiltro"
        Me.txtNumeroOrcamentoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.txtNumeroOrcamentoFiltro.TabIndex = 1
        '
        'lblNumeroOrcamentoFiltro
        '
        Me.lblNumeroOrcamentoFiltro.AutoSize = True
        Me.lblNumeroOrcamentoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroOrcamentoFiltro.Name = "lblNumeroOrcamentoFiltro"
        Me.lblNumeroOrcamentoFiltro.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroOrcamentoFiltro.TabIndex = 0
        Me.lblNumeroOrcamentoFiltro.Text = "Nº Orçamento:"
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.Location = New System.Drawing.Point(111, 17)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteFiltro.TabIndex = 5
        Me.lblClienteFiltro.Text = "Cliente:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 21
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.lblCongelarColuna)
        Me.grpControle.Controls.Add(Me.cboCongelarColuna)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(398, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(507, 51)
        Me.grpControle.TabIndex = 3
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 3
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 4
        Me.cboCongelarColuna.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(407, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 82)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 396)
        Me.grdListagem.TabIndex = 91
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(339, 17)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 12
        Me.lblStatusFiltro.Text = "Status:"
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(342, 34)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(417, 20)
        Me.cboStatusFiltro.TabIndex = 13
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'usrVenOrcamentoDetalhado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrVenOrcamentoDetalhado"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaExpirado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaEncerrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaAprovado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaDeclinado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaNegociacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaReprovado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaElaboracao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.grpControle.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNumeroOrcamentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroOrcamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtClienteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegandaExpirado As System.Windows.Forms.Label
    Friend WithEvents picLegendaExpirado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaEncerrado As System.Windows.Forms.Label
    Friend WithEvents picLegendaEncerrado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAprovado As System.Windows.Forms.Label
    Friend WithEvents picLegendaAprovado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaDeclinado As System.Windows.Forms.Label
    Friend WithEvents picLegendaDeclinado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaNegociacao As System.Windows.Forms.Label
    Friend WithEvents picLegendaNegociacao As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaReprovado As System.Windows.Forms.Label
    Friend WithEvents picLegendaReprovado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaElaboracao As System.Windows.Forms.Label
    Friend WithEvents picLegendaElaboracao As System.Windows.Forms.PictureBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label

End Class
