<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrd000000006
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrd000000006))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaEmProcesso = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picLegendaCancelado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaEmQualidade = New System.Windows.Forms.Label()
        Me.picLegendaConcluido = New System.Windows.Forms.PictureBox()
        Me.lblLegendaFinalizado = New System.Windows.Forms.Label()
        Me.picLegendaProducao = New System.Windows.Forms.PictureBox()
        Me.lblAguardandoLiberacao = New System.Windows.Forms.Label()
        Me.picLegendaAguardandoEstoque = New System.Windows.Forms.PictureBox()
        Me.lblLegendaLiberado = New System.Windows.Forms.Label()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.btnExcelListagem = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.dtpDataFechamentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataFechamentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFechamentoFiltro = New System.Windows.Forms.Label()
        Me.dtpDataAberturaTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataAberturaInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataAberturaFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.cboFuncionarioFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaConcluido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaProducao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaAguardandoEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grpLegenda)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.btnExcelListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório de Produção - Apontamento - PRD000000006"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaEmProcesso)
        Me.grpLegenda.Controls.Add(Me.PictureBox1)
        Me.grpLegenda.Controls.Add(Me.picLegendaCancelado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaEmQualidade)
        Me.grpLegenda.Controls.Add(Me.picLegendaConcluido)
        Me.grpLegenda.Controls.Add(Me.lblLegendaFinalizado)
        Me.grpLegenda.Controls.Add(Me.picLegendaProducao)
        Me.grpLegenda.Controls.Add(Me.lblAguardandoLiberacao)
        Me.grpLegenda.Controls.Add(Me.picLegendaAguardandoEstoque)
        Me.grpLegenda.Controls.Add(Me.lblLegendaLiberado)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(334, 51)
        Me.grpLegenda.TabIndex = 104
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaEmProcesso
        '
        Me.lblLegendaEmProcesso.AutoSize = True
        Me.lblLegendaEmProcesso.Location = New System.Drawing.Point(173, 14)
        Me.lblLegendaEmProcesso.Name = "lblLegendaEmProcesso"
        Me.lblLegendaEmProcesso.Size = New System.Drawing.Size(70, 14)
        Me.lblLegendaEmProcesso.TabIndex = 23
        Me.lblLegendaEmProcesso.Text = "Em Processo"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Peru
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(154, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'picLegendaCancelado
        '
        Me.picLegendaCancelado.BackColor = System.Drawing.Color.DarkViolet
        Me.picLegendaCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCancelado.Location = New System.Drawing.Point(154, 34)
        Me.picLegendaCancelado.Name = "picLegendaCancelado"
        Me.picLegendaCancelado.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaCancelado.TabIndex = 17
        Me.picLegendaCancelado.TabStop = False
        '
        'lblLegendaEmQualidade
        '
        Me.lblLegendaEmQualidade.AutoSize = True
        Me.lblLegendaEmQualidade.Location = New System.Drawing.Point(173, 34)
        Me.lblLegendaEmQualidade.Name = "lblLegendaEmQualidade"
        Me.lblLegendaEmQualidade.Size = New System.Drawing.Size(72, 14)
        Me.lblLegendaEmQualidade.TabIndex = 16
        Me.lblLegendaEmQualidade.Text = "Em Qualidade"
        '
        'picLegendaConcluido
        '
        Me.picLegendaConcluido.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaConcluido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaConcluido.Location = New System.Drawing.Point(249, 14)
        Me.picLegendaConcluido.Name = "picLegendaConcluido"
        Me.picLegendaConcluido.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaConcluido.TabIndex = 11
        Me.picLegendaConcluido.TabStop = False
        '
        'lblLegendaFinalizado
        '
        Me.lblLegendaFinalizado.AutoSize = True
        Me.lblLegendaFinalizado.Location = New System.Drawing.Point(270, 14)
        Me.lblLegendaFinalizado.Name = "lblLegendaFinalizado"
        Me.lblLegendaFinalizado.Size = New System.Drawing.Size(55, 14)
        Me.lblLegendaFinalizado.TabIndex = 0
        Me.lblLegendaFinalizado.Text = "Finalizado"
        '
        'picLegendaProducao
        '
        Me.picLegendaProducao.BackColor = System.Drawing.Color.DarkGray
        Me.picLegendaProducao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaProducao.Location = New System.Drawing.Point(9, 13)
        Me.picLegendaProducao.Name = "picLegendaProducao"
        Me.picLegendaProducao.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaProducao.TabIndex = 13
        Me.picLegendaProducao.TabStop = False
        '
        'lblAguardandoLiberacao
        '
        Me.lblAguardandoLiberacao.AutoSize = True
        Me.lblAguardandoLiberacao.Location = New System.Drawing.Point(30, 13)
        Me.lblAguardandoLiberacao.Name = "lblAguardandoLiberacao"
        Me.lblAguardandoLiberacao.Size = New System.Drawing.Size(118, 14)
        Me.lblAguardandoLiberacao.TabIndex = 1
        Me.lblAguardandoLiberacao.Text = "Aguardando Liberação"
        '
        'picLegendaAguardandoEstoque
        '
        Me.picLegendaAguardandoEstoque.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaAguardandoEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAguardandoEstoque.Location = New System.Drawing.Point(9, 30)
        Me.picLegendaAguardandoEstoque.Name = "picLegendaAguardandoEstoque"
        Me.picLegendaAguardandoEstoque.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaAguardandoEstoque.TabIndex = 19
        Me.picLegendaAguardandoEstoque.TabStop = False
        '
        'lblLegendaLiberado
        '
        Me.lblLegendaLiberado.AutoSize = True
        Me.lblLegendaLiberado.Location = New System.Drawing.Point(30, 30)
        Me.lblLegendaLiberado.Name = "lblLegendaLiberado"
        Me.lblLegendaLiberado.Size = New System.Drawing.Size(49, 14)
        Me.lblLegendaLiberado.TabIndex = 18
        Me.lblLegendaLiberado.Text = "Liberado"
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(11, 460)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 101
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'btnExcelListagem
        '
        Me.btnExcelListagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelListagem.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelListagem.FlatAppearance.BorderSize = 0
        Me.btnExcelListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelListagem.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelListagem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelListagem.Location = New System.Drawing.Point(35, 460)
        Me.btnExcelListagem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelListagem.Name = "btnExcelListagem"
        Me.btnExcelListagem.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelListagem.TabIndex = 102
        Me.btnExcelListagem.TabStop = False
        Me.btnExcelListagem.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataFechamentoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataFechamentoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataFechamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataAberturaTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataAberturaInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataAberturaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblFuncionario)
        Me.grpFiltro.Controls.Add(Me.cboFuncionarioFiltro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 75)
        Me.grpFiltro.TabIndex = 93
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(713, 37)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(163, 20)
        Me.cboStatusFiltro.TabIndex = 26
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(710, 20)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 25
        Me.lblStatusFiltro.Text = "Status:"
        '
        'dtpDataFechamentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataFechamentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataFechamentoTerminoFiltro.Location = New System.Drawing.Point(328, 37)
        Me.dtpDataFechamentoTerminoFiltro.Name = "dtpDataFechamentoTerminoFiltro"
        Me.dtpDataFechamentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataFechamentoTerminoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataFechamentoTerminoFiltro.TabIndex = 24
        Me.dtpDataFechamentoTerminoFiltro.Value = New Date(2012, 9, 6, 0, 0, 0, 0)
        '
        'dtpDataFechamentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataFechamentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataFechamentoInicioFiltro.Location = New System.Drawing.Point(222, 37)
        Me.dtpDataFechamentoInicioFiltro.Name = "dtpDataFechamentoInicioFiltro"
        Me.dtpDataFechamentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataFechamentoInicioFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataFechamentoInicioFiltro.TabIndex = 23
        Me.dtpDataFechamentoInicioFiltro.Value = New Date(2012, 9, 6, 0, 0, 0, 0)
        '
        'lblDataFechamentoFiltro
        '
        Me.lblDataFechamentoFiltro.AutoSize = True
        Me.lblDataFechamentoFiltro.Location = New System.Drawing.Point(219, 20)
        Me.lblDataFechamentoFiltro.Name = "lblDataFechamentoFiltro"
        Me.lblDataFechamentoFiltro.Size = New System.Drawing.Size(94, 14)
        Me.lblDataFechamentoFiltro.TabIndex = 22
        Me.lblDataFechamentoFiltro.Text = "Data Fechamento:"
        '
        'dtpDataAberturaTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataAberturaTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataAberturaTerminoFiltro.Location = New System.Drawing.Point(116, 37)
        Me.dtpDataAberturaTerminoFiltro.Name = "dtpDataAberturaTerminoFiltro"
        Me.dtpDataAberturaTerminoFiltro.ShowCheckBox = True
        Me.dtpDataAberturaTerminoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataAberturaTerminoFiltro.TabIndex = 21
        Me.dtpDataAberturaTerminoFiltro.Value = New Date(2012, 9, 6, 0, 0, 0, 0)
        '
        'dtpDataAberturaInicioFiltro
        '
        '
        '
        '
        Me.dtpDataAberturaInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataAberturaInicioFiltro.Location = New System.Drawing.Point(10, 37)
        Me.dtpDataAberturaInicioFiltro.Name = "dtpDataAberturaInicioFiltro"
        Me.dtpDataAberturaInicioFiltro.ShowCheckBox = True
        Me.dtpDataAberturaInicioFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataAberturaInicioFiltro.TabIndex = 20
        Me.dtpDataAberturaInicioFiltro.Value = New Date(2012, 9, 6, 0, 0, 0, 0)
        '
        'lblDataAberturaFiltro
        '
        Me.lblDataAberturaFiltro.AutoSize = True
        Me.lblDataAberturaFiltro.Location = New System.Drawing.Point(7, 20)
        Me.lblDataAberturaFiltro.Name = "lblDataAberturaFiltro"
        Me.lblDataAberturaFiltro.Size = New System.Drawing.Size(77, 14)
        Me.lblDataAberturaFiltro.TabIndex = 19
        Me.lblDataAberturaFiltro.Text = "Data Abertura:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 34)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 18
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFuncionario.Location = New System.Drawing.Point(431, 20)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(66, 14)
        Me.lblFuncionario.TabIndex = 0
        Me.lblFuncionario.Text = "Funcionário:"
        '
        'cboFuncionarioFiltro
        '
        Me.cboFuncionarioFiltro.Location = New System.Drawing.Point(434, 37)
        Me.cboFuncionarioFiltro.Name = "cboFuncionarioFiltro"
        Me.cboFuncionarioFiltro.Size = New System.Drawing.Size(273, 20)
        Me.cboFuncionarioFiltro.TabIndex = 1
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(348, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(642, 51)
        Me.grpControl.TabIndex = 4
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(542, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 84)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 393)
        Me.grdListagem.TabIndex = 103
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'usrPrd000000006
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrPrd000000006"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaConcluido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaProducao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaAguardandoEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents cboFuncionarioFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelListagem As System.Windows.Forms.Button
    Friend WithEvents dtpDataAberturaTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataAberturaInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataAberturaFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaEmProcesso As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picLegendaCancelado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaEmQualidade As System.Windows.Forms.Label
    Friend WithEvents picLegendaConcluido As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaFinalizado As System.Windows.Forms.Label
    Friend WithEvents picLegendaProducao As System.Windows.Forms.PictureBox
    Friend WithEvents lblAguardandoLiberacao As System.Windows.Forms.Label
    Friend WithEvents picLegendaAguardandoEstoque As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaLiberado As System.Windows.Forms.Label
    Friend WithEvents dtpDataFechamentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataFechamentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFechamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label

End Class
