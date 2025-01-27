<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFatControleDevolucao
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
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFatControleDevolucao))
        Dim cboCFOPFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegendaAutozidadaParaUso = New System.Windows.Forms.PictureBox()
        Me.lblLegendaRejeitada = New System.Windows.Forms.Label()
        Me.picLegendaRejeitada = New System.Windows.Forms.PictureBox()
        Me.lblAguardandoRetorno = New System.Windows.Forms.Label()
        Me.pigAguardandoRetorno = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAguardandoTransmissao = New System.Windows.Forms.Label()
        Me.picLegendaAguardandoTransmissao = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAutozidadaParaUso = New System.Windows.Forms.Label()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.txtFornecedorFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFornecedorFiltro = New System.Windows.Forms.Label()
        Me.cboCFOPFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblCFOPFiltro = New System.Windows.Forms.Label()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.txtNFRemessaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblNFRemessaFiltro = New System.Windows.Forms.Label()
        Me.grpPedidoVenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaAutozidadaParaUso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaRejeitada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pigAguardandoRetorno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaAguardandoTransmissao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpPedidoVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPedidoVenda.SuspendLayout()
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
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 1
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pagTabela.Controls.Add(Me.grpLegenda)
        Me.pagTabela.Controls.Add(Me.btnExcelGrid)
        Me.pagTabela.Controls.Add(Me.btnAgruparGrid)
        Me.pagTabela.Controls.Add(Me.btnConfigurarGrid)
        Me.pagTabela.Controls.Add(Me.grpFiltro)
        Me.pagTabela.Controls.Add(Me.grpPedidoVenda)
        Me.pagTabela.Controls.Add(Me.grdListagem)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(913, 543)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Devolução"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.picLegendaAutozidadaParaUso)
        Me.grpLegenda.Controls.Add(Me.lblLegendaRejeitada)
        Me.grpLegenda.Controls.Add(Me.picLegendaRejeitada)
        Me.grpLegenda.Controls.Add(Me.lblAguardandoRetorno)
        Me.grpLegenda.Controls.Add(Me.pigAguardandoRetorno)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAguardandoTransmissao)
        Me.grpLegenda.Controls.Add(Me.picLegendaAguardandoTransmissao)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAutozidadaParaUso)
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(323, 51)
        Me.grpLegenda.TabIndex = 91
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picLegendaAutozidadaParaUso
        '
        Me.picLegendaAutozidadaParaUso.BackColor = System.Drawing.Color.Green
        Me.picLegendaAutozidadaParaUso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAutozidadaParaUso.Location = New System.Drawing.Point(166, 13)
        Me.picLegendaAutozidadaParaUso.Name = "picLegendaAutozidadaParaUso"
        Me.picLegendaAutozidadaParaUso.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAutozidadaParaUso.TabIndex = 16
        Me.picLegendaAutozidadaParaUso.TabStop = False
        '
        'lblLegendaRejeitada
        '
        Me.lblLegendaRejeitada.AutoSize = True
        Me.lblLegendaRejeitada.Location = New System.Drawing.Point(185, 30)
        Me.lblLegendaRejeitada.Name = "lblLegendaRejeitada"
        Me.lblLegendaRejeitada.Size = New System.Drawing.Size(92, 14)
        Me.lblLegendaRejeitada.TabIndex = 3
        Me.lblLegendaRejeitada.Text = "Retorno Atrasado"
        '
        'picLegendaRejeitada
        '
        Me.picLegendaRejeitada.BackColor = System.Drawing.Color.DarkRed
        Me.picLegendaRejeitada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaRejeitada.Location = New System.Drawing.Point(166, 30)
        Me.picLegendaRejeitada.Name = "picLegendaRejeitada"
        Me.picLegendaRejeitada.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaRejeitada.TabIndex = 12
        Me.picLegendaRejeitada.TabStop = False
        '
        'lblAguardandoRetorno
        '
        Me.lblAguardandoRetorno.AutoSize = True
        Me.lblAguardandoRetorno.Location = New System.Drawing.Point(28, 30)
        Me.lblAguardandoRetorno.Name = "lblAguardandoRetorno"
        Me.lblAguardandoRetorno.Size = New System.Drawing.Size(80, 14)
        Me.lblAguardandoRetorno.TabIndex = 1
        Me.lblAguardandoRetorno.Text = "Retorno Parcial"
        '
        'pigAguardandoRetorno
        '
        Me.pigAguardandoRetorno.BackColor = System.Drawing.Color.SteelBlue
        Me.pigAguardandoRetorno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pigAguardandoRetorno.Location = New System.Drawing.Point(9, 30)
        Me.pigAguardandoRetorno.Name = "pigAguardandoRetorno"
        Me.pigAguardandoRetorno.Size = New System.Drawing.Size(13, 14)
        Me.pigAguardandoRetorno.TabIndex = 10
        Me.pigAguardandoRetorno.TabStop = False
        '
        'lblLegendaAguardandoTransmissao
        '
        Me.lblLegendaAguardandoTransmissao.AutoSize = True
        Me.lblLegendaAguardandoTransmissao.Location = New System.Drawing.Point(28, 13)
        Me.lblLegendaAguardandoTransmissao.Name = "lblLegendaAguardandoTransmissao"
        Me.lblLegendaAguardandoTransmissao.Size = New System.Drawing.Size(108, 14)
        Me.lblLegendaAguardandoTransmissao.TabIndex = 0
        Me.lblLegendaAguardandoTransmissao.Text = "Aguardando Retorno"
        '
        'picLegendaAguardandoTransmissao
        '
        Me.picLegendaAguardandoTransmissao.BackColor = System.Drawing.Color.DarkGray
        Me.picLegendaAguardandoTransmissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAguardandoTransmissao.Location = New System.Drawing.Point(9, 13)
        Me.picLegendaAguardandoTransmissao.Name = "picLegendaAguardandoTransmissao"
        Me.picLegendaAguardandoTransmissao.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAguardandoTransmissao.TabIndex = 4
        Me.picLegendaAguardandoTransmissao.TabStop = False
        '
        'lblLegendaAutozidadaParaUso
        '
        Me.lblLegendaAutozidadaParaUso.AutoSize = True
        Me.lblLegendaAutozidadaParaUso.Location = New System.Drawing.Point(185, 13)
        Me.lblLegendaAutozidadaParaUso.Name = "lblLegendaAutozidadaParaUso"
        Me.lblLegendaAutozidadaParaUso.Size = New System.Drawing.Size(92, 14)
        Me.lblLegendaAutozidadaParaUso.TabIndex = 2
        Me.lblLegendaAutozidadaParaUso.Text = "Retorno Completo"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 460)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 90
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 460)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 89
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 460)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 88
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
        Me.grpFiltro.Controls.Add(Me.txtFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.cboCFOPFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCFOPFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNFRemessaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblNFRemessaFiltro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 101)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(9, 75)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(200, 20)
        Me.cboStatusFiltro.TabIndex = 36
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 35
        Me.lblStatusFiltro.Text = "Status:"
        '
        'txtFornecedorFiltro
        '
        Me.txtFornecedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFornecedorFiltro.Location = New System.Drawing.Point(329, 34)
        Me.txtFornecedorFiltro.MaxLength = 20
        Me.txtFornecedorFiltro.Name = "txtFornecedorFiltro"
        Me.txtFornecedorFiltro.Size = New System.Drawing.Size(365, 20)
        Me.txtFornecedorFiltro.TabIndex = 33
        '
        'lblFornecedorFiltro
        '
        Me.lblFornecedorFiltro.AutoSize = True
        Me.lblFornecedorFiltro.Location = New System.Drawing.Point(326, 17)
        Me.lblFornecedorFiltro.Name = "lblFornecedorFiltro"
        Me.lblFornecedorFiltro.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedorFiltro.TabIndex = 32
        Me.lblFornecedorFiltro.Text = "Fornecedor:"
        '
        'cboCFOPFiltro
        '
        Me.cboCFOPFiltro.AllowDrop = True
        Me.cboCFOPFiltro.ButtonCancelText = "Cancelar"
        Me.cboCFOPFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboCFOPFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboCFOPFiltro_DesignTimeLayout.LayoutString")
        Me.cboCFOPFiltro.DesignTimeLayout = cboCFOPFiltro_DesignTimeLayout
        Me.cboCFOPFiltro.Location = New System.Drawing.Point(700, 34)
        Me.cboCFOPFiltro.Name = "cboCFOPFiltro"
        Me.cboCFOPFiltro.SaveSettings = False
        Me.cboCFOPFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboCFOPFiltro.Size = New System.Drawing.Size(91, 20)
        Me.cboCFOPFiltro.TabIndex = 31
        Me.cboCFOPFiltro.ValuesDataMember = Nothing
        '
        'lblCFOPFiltro
        '
        Me.lblCFOPFiltro.AutoSize = True
        Me.lblCFOPFiltro.Location = New System.Drawing.Point(697, 17)
        Me.lblCFOPFiltro.Name = "lblCFOPFiltro"
        Me.lblCFOPFiltro.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOPFiltro.TabIndex = 30
        Me.lblCFOPFiltro.Text = "CFOP:"
        '
        'dtpDataEmissaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(101, 34)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 28
        '
        'dtpDataEmissaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(215, 34)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 29
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(98, 17)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 27
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'txtNFRemessaFiltro
        '
        Me.txtNFRemessaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNFRemessaFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNFRemessaFiltro.MaxLength = 20
        Me.txtNFRemessaFiltro.Name = "txtNFRemessaFiltro"
        Me.txtNFRemessaFiltro.Size = New System.Drawing.Size(86, 20)
        Me.txtNFRemessaFiltro.TabIndex = 26
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 68)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 23
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblNFRemessaFiltro
        '
        Me.lblNFRemessaFiltro.AutoSize = True
        Me.lblNFRemessaFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNFRemessaFiltro.Name = "lblNFRemessaFiltro"
        Me.lblNFRemessaFiltro.Size = New System.Drawing.Size(71, 14)
        Me.lblNFRemessaFiltro.TabIndex = 0
        Me.lblNFRemessaFiltro.Text = "NF Remessa:"
        '
        'grpPedidoVenda
        '
        Me.grpPedidoVenda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPedidoVenda.BackColor = System.Drawing.Color.Transparent
        Me.grpPedidoVenda.Controls.Add(Me.btnVisualizarImpressao)
        Me.grpPedidoVenda.Controls.Add(Me.btnSair)
        Me.grpPedidoVenda.Location = New System.Drawing.Point(337, 483)
        Me.grpPedidoVenda.Name = "grpPedidoVenda"
        Me.grpPedidoVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPedidoVenda.Size = New System.Drawing.Size(568, 51)
        Me.grpPedidoVenda.TabIndex = 5
        Me.grpPedidoVenda.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpPedidoVenda.VisualStyleManager = Me.vsmMain
        '
        'btnVisualizarImpressao
        '
        Me.btnVisualizarImpressao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarImpressao.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnVisualizarImpressao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarImpressao.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnVisualizarImpressao.Location = New System.Drawing.Point(325, 17)
        Me.btnVisualizarImpressao.Name = "btnVisualizarImpressao"
        Me.btnVisualizarImpressao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarImpressao.Size = New System.Drawing.Size(137, 23)
        Me.btnVisualizarImpressao.TabIndex = 2
        Me.btnVisualizarImpressao.Text = "Visualizar Impressão"
        Me.btnVisualizarImpressao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(468, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 8
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 111)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 366)
        Me.grdListagem.TabIndex = 36
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
        'usrFatControleDevolucao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFatControleDevolucao"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaAutozidadaParaUso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaRejeitada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pigAguardandoRetorno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaAguardandoTransmissao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpPedidoVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPedidoVenda.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblNFRemessaFiltro As System.Windows.Forms.Label
    Friend WithEvents grpPedidoVenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtNFRemessaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboCFOPFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblCFOPFiltro As System.Windows.Forms.Label
    Friend WithEvents txtFornecedorFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFornecedorFiltro As System.Windows.Forms.Label
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaAutozidadaParaUso As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaRejeitada As System.Windows.Forms.Label
    Friend WithEvents picLegendaRejeitada As System.Windows.Forms.PictureBox
    Friend WithEvents lblAguardandoRetorno As System.Windows.Forms.Label
    Friend WithEvents pigAguardandoRetorno As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAguardandoTransmissao As System.Windows.Forms.Label
    Friend WithEvents picLegendaAguardandoTransmissao As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAutozidadaParaUso As System.Windows.Forms.Label
    Friend WithEvents btnVisualizarImpressao As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox

End Class
