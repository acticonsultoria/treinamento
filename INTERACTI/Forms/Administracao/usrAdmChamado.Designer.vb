<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrAdmChamado
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrAdmChamado))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdArquivos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivos_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim grdArquivos_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdComentario_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdComentario_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Series1 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series()
        Dim Series2 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series()
        Dim Title1 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title()
        Dim CommandUIItem1 As Dundas.Charting.WinControl.CommandUIItem = New Dundas.Charting.WinControl.CommandUIItem("SaveImage", "")
        Dim CommandUIItem2 As Dundas.Charting.WinControl.CommandUIItem = New Dundas.Charting.WinControl.CommandUIItem("Copy", "")
        Dim CommandUIItem3 As Dundas.Charting.WinControl.CommandUIItem = New Dundas.Charting.WinControl.CommandUIItem("Print", "")
        Dim CommandUIItem4 As Dundas.Charting.WinControl.CommandUIItem = New Dundas.Charting.WinControl.CommandUIItem("PrintPreview", "")
        Dim CommandUIItem5 As Dundas.Charting.WinControl.CommandUIItem = New Dundas.Charting.WinControl.CommandUIItem("Separator", "")
        Dim CommandUIItem6 As Dundas.Charting.WinControl.CommandUIItem = New Dundas.Charting.WinControl.CommandUIItem("SelectChartGroup", "")
        Dim CommandUIItem7 As Dundas.Charting.WinControl.CommandUIItem = New Dundas.Charting.WinControl.CommandUIItem("ToggleLegend", "")
        Dim CommandUIItem8 As Dundas.Charting.WinControl.CommandUIItem = New Dundas.Charting.WinControl.CommandUIItem("Toggle3D", "")
        Dim CommandUIItem9 As Dundas.Charting.WinControl.CommandUIItem = New Dundas.Charting.WinControl.CommandUIItem("Separator", "")
        Dim CommandUIItem10 As Dundas.Charting.WinControl.CommandUIItem = New Dundas.Charting.WinControl.CommandUIItem("AddAnnotationGroup", "")
        Dim CommandUIItem11 As Dundas.Charting.WinControl.CommandUIItem = New Dundas.Charting.WinControl.CommandUIItem("Separator", "")
        Dim CommandUIItem12 As Dundas.Charting.WinControl.CommandUIItem = New Dundas.Charting.WinControl.CommandUIItem("Properties", "")
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaLiberada = New System.Windows.Forms.Label()
        Me.picLiberado = New System.Windows.Forms.PictureBox()
        Me.lblLegAguardandoCliente = New System.Windows.Forms.Label()
        Me.pctAguardandoCliente = New System.Windows.Forms.PictureBox()
        Me.lblAberta = New System.Windows.Forms.Label()
        Me.picParcialmenteEntregue = New System.Windows.Forms.PictureBox()
        Me.lblConcluida = New System.Windows.Forms.Label()
        Me.picEntregue = New System.Windows.Forms.PictureBox()
        Me.lblCancelada = New System.Windows.Forms.Label()
        Me.picLegendaCancelado = New System.Windows.Forms.PictureBox()
        Me.lblIniciada = New System.Windows.Forms.Label()
        Me.picLegendaTipoOrcamento = New System.Windows.Forms.PictureBox()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtSolicitanteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.lblSolicitanteFiltro = New System.Windows.Forms.Label()
        Me.lblTipoChamadoFiltro = New System.Windows.Forms.Label()
        Me.cboTipoAtividadeFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoFiltro = New System.Windows.Forms.Label()
        Me.txtCodigoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtTituloFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTituloFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDadosChamado = New Janus.Windows.UI.Tab.UITab()
        Me.pagArquivos = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdArquivos = New Janus.Windows.GridEX.GridEX()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.pagComentario = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdComentario = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnAutorizarAtividade = New Janus.Windows.EditControls.UIButton()
        Me.btnAgCliente = New Janus.Windows.EditControls.UIButton()
        Me.btnIniciar = New Janus.Windows.EditControls.UIButton()
        Me.btnFinalizarChamado = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirComentario = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtPrazoResposta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPrazoResposta = New System.Windows.Forms.Label()
        Me.txtDataAutorizacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataAutorizacao = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.txtTela = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTela = New System.Windows.Forms.Label()
        Me.txtModulo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblModulo = New System.Windows.Forms.Label()
        Me.cboPrioridade = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPrioridade = New System.Windows.Forms.Label()
        Me.dtpDataChamado = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtSolicitante = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSolicitante = New System.Windows.Forms.Label()
        Me.txtStatus = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblDefinicao = New System.Windows.Forms.Label()
        Me.lblTipoChamado = New System.Windows.Forms.Label()
        Me.cboTipoAtividade = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDataChamado = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtTitulo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pagGrafico = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair2 = New Janus.Windows.EditControls.UIButton()
        Me.chrGrafico = New Dundas.Charting.WinControl.Chart()
        Me.grpGrafico = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboEixoY2 = New Janus.Windows.EditControls.UIComboBox()
        Me.lblEixoY2 = New System.Windows.Forms.Label()
        Me.txtMeta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMeta = New System.Windows.Forms.Label()
        Me.cboIntervalo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblIntervaloAgrupamento = New System.Windows.Forms.Label()
        Me.cboTipo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cboEixoY = New Janus.Windows.EditControls.UIComboBox()
        Me.lblValorEixoY = New System.Windows.Forms.Label()
        Me.cboSerie = New Janus.Windows.EditControls.UIComboBox()
        Me.btnGerarGrafico = New Janus.Windows.EditControls.UIButton()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLiberado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctAguardandoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picParcialmenteEntregue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEntregue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaTipoOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.tabDadosChamado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDadosChamado.SuspendLayout()
        Me.pagArquivos.SuspendLayout()
        CType(Me.grdArquivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagComentario.SuspendLayout()
        CType(Me.grdComentario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        Me.pagGrafico.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.chrGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGrafico.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(1200, 565)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados, Me.pagGrafico})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grpLegenda)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(1198, 542)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Controle de Chamados"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaLiberada)
        Me.grpLegenda.Controls.Add(Me.picLiberado)
        Me.grpLegenda.Controls.Add(Me.lblLegAguardandoCliente)
        Me.grpLegenda.Controls.Add(Me.pctAguardandoCliente)
        Me.grpLegenda.Controls.Add(Me.lblAberta)
        Me.grpLegenda.Controls.Add(Me.picParcialmenteEntregue)
        Me.grpLegenda.Controls.Add(Me.lblConcluida)
        Me.grpLegenda.Controls.Add(Me.picEntregue)
        Me.grpLegenda.Controls.Add(Me.lblCancelada)
        Me.grpLegenda.Controls.Add(Me.picLegendaCancelado)
        Me.grpLegenda.Controls.Add(Me.lblIniciada)
        Me.grpLegenda.Controls.Add(Me.picLegendaTipoOrcamento)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(7, 486)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(351, 51)
        Me.grpLegenda.TabIndex = 9
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaLiberada
        '
        Me.lblLegendaLiberada.AutoSize = True
        Me.lblLegendaLiberada.Location = New System.Drawing.Point(225, 30)
        Me.lblLegendaLiberada.Name = "lblLegendaLiberada"
        Me.lblLegendaLiberada.Size = New System.Drawing.Size(107, 14)
        Me.lblLegendaLiberada.TabIndex = 23
        Me.lblLegendaLiberada.Text = "Atividade Autorizada"
        '
        'picLiberado
        '
        Me.picLiberado.BackColor = System.Drawing.Color.Peru
        Me.picLiberado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLiberado.Location = New System.Drawing.Point(206, 30)
        Me.picLiberado.Name = "picLiberado"
        Me.picLiberado.Size = New System.Drawing.Size(13, 14)
        Me.picLiberado.TabIndex = 24
        Me.picLiberado.TabStop = False
        '
        'lblLegAguardandoCliente
        '
        Me.lblLegAguardandoCliente.AutoSize = True
        Me.lblLegAguardandoCliente.Location = New System.Drawing.Point(225, 13)
        Me.lblLegAguardandoCliente.Name = "lblLegAguardandoCliente"
        Me.lblLegAguardandoCliente.Size = New System.Drawing.Size(56, 14)
        Me.lblLegAguardandoCliente.TabIndex = 21
        Me.lblLegAguardandoCliente.Text = "Ag Cliente"
        '
        'pctAguardandoCliente
        '
        Me.pctAguardandoCliente.BackColor = System.Drawing.Color.Purple
        Me.pctAguardandoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctAguardandoCliente.Location = New System.Drawing.Point(206, 13)
        Me.pctAguardandoCliente.Name = "pctAguardandoCliente"
        Me.pctAguardandoCliente.Size = New System.Drawing.Size(13, 14)
        Me.pctAguardandoCliente.TabIndex = 22
        Me.pctAguardandoCliente.TabStop = False
        '
        'lblAberta
        '
        Me.lblAberta.AutoSize = True
        Me.lblAberta.Location = New System.Drawing.Point(28, 13)
        Me.lblAberta.Name = "lblAberta"
        Me.lblAberta.Size = New System.Drawing.Size(40, 14)
        Me.lblAberta.TabIndex = 1
        Me.lblAberta.Text = "Aberto"
        '
        'picParcialmenteEntregue
        '
        Me.picParcialmenteEntregue.BackColor = System.Drawing.Color.DarkGray
        Me.picParcialmenteEntregue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picParcialmenteEntregue.Location = New System.Drawing.Point(9, 13)
        Me.picParcialmenteEntregue.Name = "picParcialmenteEntregue"
        Me.picParcialmenteEntregue.Size = New System.Drawing.Size(13, 14)
        Me.picParcialmenteEntregue.TabIndex = 20
        Me.picParcialmenteEntregue.TabStop = False
        '
        'lblConcluida
        '
        Me.lblConcluida.AutoSize = True
        Me.lblConcluida.Location = New System.Drawing.Point(28, 30)
        Me.lblConcluida.Name = "lblConcluida"
        Me.lblConcluida.Size = New System.Drawing.Size(54, 14)
        Me.lblConcluida.TabIndex = 2
        Me.lblConcluida.Text = "Concluído"
        '
        'picEntregue
        '
        Me.picEntregue.BackColor = System.Drawing.Color.ForestGreen
        Me.picEntregue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picEntregue.Location = New System.Drawing.Point(9, 30)
        Me.picEntregue.Name = "picEntregue"
        Me.picEntregue.Size = New System.Drawing.Size(13, 14)
        Me.picEntregue.TabIndex = 18
        Me.picEntregue.TabStop = False
        '
        'lblCancelada
        '
        Me.lblCancelada.AutoSize = True
        Me.lblCancelada.Location = New System.Drawing.Point(141, 30)
        Me.lblCancelada.Name = "lblCancelada"
        Me.lblCancelada.Size = New System.Drawing.Size(58, 14)
        Me.lblCancelada.TabIndex = 3
        Me.lblCancelada.Text = "Cancelado"
        '
        'picLegendaCancelado
        '
        Me.picLegendaCancelado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCancelado.Location = New System.Drawing.Point(122, 30)
        Me.picLegendaCancelado.Name = "picLegendaCancelado"
        Me.picLegendaCancelado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCancelado.TabIndex = 16
        Me.picLegendaCancelado.TabStop = False
        '
        'lblIniciada
        '
        Me.lblIniciada.AutoSize = True
        Me.lblIniciada.Location = New System.Drawing.Point(141, 13)
        Me.lblIniciada.Name = "lblIniciada"
        Me.lblIniciada.Size = New System.Drawing.Size(43, 14)
        Me.lblIniciada.TabIndex = 0
        Me.lblIniciada.Text = "Iniciado"
        '
        'picLegendaTipoOrcamento
        '
        Me.picLegendaTipoOrcamento.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaTipoOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaTipoOrcamento.Location = New System.Drawing.Point(122, 13)
        Me.picLegendaTipoOrcamento.Name = "picLegendaTipoOrcamento"
        Me.picLegendaTipoOrcamento.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaTipoOrcamento.TabIndex = 4
        Me.picLegendaTipoOrcamento.TabStop = False
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
        'grdListagem
        '
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
        Me.grdListagem.DynamicFiltering = True
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(8, 120)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(1184, 363)
        Me.grdListagem.TabIndex = 7
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricao)
        Me.grpFiltro.Controls.Add(Me.txtSolicitanteFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblSolicitanteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoChamadoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoAtividadeFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCodigoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtTituloFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTituloFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(7, 6)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(1182, 110)
        Me.grpFiltro.TabIndex = 6
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(405, 74)
        Me.txtDescricaoFiltro.MaxLength = 100
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(671, 20)
        Me.txtDescricaoFiltro.TabIndex = 9
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(402, 57)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 14
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtSolicitanteFiltro
        '
        Me.txtSolicitanteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSolicitanteFiltro.Location = New System.Drawing.Point(309, 34)
        Me.txtSolicitanteFiltro.MaxLength = 20
        Me.txtSolicitanteFiltro.Name = "txtSolicitanteFiltro"
        Me.txtSolicitanteFiltro.Size = New System.Drawing.Size(90, 20)
        Me.txtSolicitanteFiltro.TabIndex = 4
        '
        'dtpDataInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(9, 34)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInicioFiltro.TabIndex = 1
        Me.dtpDataInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(123, 34)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 2
        Me.dtpDataTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataFiltro
        '
        Me.lblDataFiltro.AutoSize = True
        Me.lblDataFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblDataFiltro.Name = "lblDataFiltro"
        Me.lblDataFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataFiltro.TabIndex = 0
        Me.lblDataFiltro.Text = "Data:"
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
        Me.cboStatusFiltro.Location = New System.Drawing.Point(508, 34)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(665, 20)
        Me.cboStatusFiltro.TabIndex = 6
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(508, 17)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 9
        Me.lblStatusFiltro.Text = "Status:"
        '
        'lblSolicitanteFiltro
        '
        Me.lblSolicitanteFiltro.AutoSize = True
        Me.lblSolicitanteFiltro.Location = New System.Drawing.Point(306, 17)
        Me.lblSolicitanteFiltro.Name = "lblSolicitanteFiltro"
        Me.lblSolicitanteFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblSolicitanteFiltro.TabIndex = 5
        Me.lblSolicitanteFiltro.Text = "Solicitante:"
        '
        'lblTipoChamadoFiltro
        '
        Me.lblTipoChamadoFiltro.AutoSize = True
        Me.lblTipoChamadoFiltro.Location = New System.Drawing.Point(402, 17)
        Me.lblTipoChamadoFiltro.Name = "lblTipoChamadoFiltro"
        Me.lblTipoChamadoFiltro.Size = New System.Drawing.Size(30, 14)
        Me.lblTipoChamadoFiltro.TabIndex = 7
        Me.lblTipoChamadoFiltro.Text = "Tipo:"
        '
        'cboTipoAtividadeFiltro
        '
        Me.cboTipoAtividadeFiltro.AutoSize = False
        Me.cboTipoAtividadeFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboTipoAtividadeFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboTipoAtividadeFiltro.Location = New System.Drawing.Point(405, 34)
        Me.cboTipoAtividadeFiltro.Name = "cboTipoAtividadeFiltro"
        Me.cboTipoAtividadeFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoAtividadeFiltro.Size = New System.Drawing.Size(97, 20)
        Me.cboTipoAtividadeFiltro.TabIndex = 5
        '
        'lblCodigoFiltro
        '
        Me.lblCodigoFiltro.AutoSize = True
        Me.lblCodigoFiltro.Location = New System.Drawing.Point(235, 17)
        Me.lblCodigoFiltro.Name = "lblCodigoFiltro"
        Me.lblCodigoFiltro.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigoFiltro.TabIndex = 3
        Me.lblCodigoFiltro.Text = "Código:"
        '
        'txtCodigoFiltro
        '
        Me.txtCodigoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoFiltro.Location = New System.Drawing.Point(238, 34)
        Me.txtCodigoFiltro.MaxLength = 20
        Me.txtCodigoFiltro.Name = "txtCodigoFiltro"
        Me.txtCodigoFiltro.Size = New System.Drawing.Size(65, 20)
        Me.txtCodigoFiltro.TabIndex = 3
        '
        'txtTituloFiltro
        '
        Me.txtTituloFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTituloFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtTituloFiltro.MaxLength = 100
        Me.txtTituloFiltro.Name = "txtTituloFiltro"
        Me.txtTituloFiltro.Size = New System.Drawing.Size(390, 20)
        Me.txtTituloFiltro.TabIndex = 8
        '
        'lblTituloFiltro
        '
        Me.lblTituloFiltro.AutoSize = True
        Me.lblTituloFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblTituloFiltro.Name = "lblTituloFiltro"
        Me.lblTituloFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblTituloFiltro.TabIndex = 7
        Me.lblTituloFiltro.Text = "Título:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(1082, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 10
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnExcel)
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(364, 486)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(825, 51)
        Me.grpControl.TabIndex = 5
        Me.grpControl.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(531, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 1
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(628, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 2
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(725, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.tabDadosChamado)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(1198, 542)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados do Chamado"
        '
        'tabDadosChamado
        '
        Me.tabDadosChamado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDadosChamado.BackColor = System.Drawing.Color.Transparent
        Me.tabDadosChamado.FocusOnClick = False
        Me.tabDadosChamado.Location = New System.Drawing.Point(8, 230)
        Me.tabDadosChamado.Name = "tabDadosChamado"
        Me.tabDadosChamado.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDadosChamado.ShowFocusRectangle = False
        Me.tabDadosChamado.Size = New System.Drawing.Size(1180, 252)
        Me.tabDadosChamado.TabIndex = 1
        Me.tabDadosChamado.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagArquivos, Me.pagComentario})
        Me.tabDadosChamado.TabStop = False
        Me.tabDadosChamado.VisualStyleManager = Me.vsmMain
        '
        'pagArquivos
        '
        Me.pagArquivos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pagArquivos.Controls.Add(Me.grdArquivos)
        Me.pagArquivos.Controls.Add(Me.btnArquivo)
        Me.pagArquivos.Controls.Add(Me.txtArquivo)
        Me.pagArquivos.Key = "pagArquivos"
        Me.pagArquivos.Location = New System.Drawing.Point(1, 22)
        Me.pagArquivos.Name = "pagArquivos"
        Me.pagArquivos.Size = New System.Drawing.Size(1178, 229)
        Me.pagArquivos.TabStop = True
        Me.pagArquivos.Text = "Arquivos"
        '
        'grdArquivos
        '
        Me.grdArquivos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdArquivos.AlternatingColors = True
        Me.grdArquivos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdArquivos.ColumnAutoResize = True
        Me.grdArquivos.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.DisplayedCellsAndHeader
        grdArquivos_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdArquivos_DesignTimeLayout_Reference_0.Instance"), Object)
        grdArquivos_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdArquivos_DesignTimeLayout_Reference_1.Instance"), Object)
        grdArquivos_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdArquivos_DesignTimeLayout_Reference_0, grdArquivos_DesignTimeLayout_Reference_1})
        grdArquivos_DesignTimeLayout.LayoutString = resources.GetString("grdArquivos_DesignTimeLayout.LayoutString")
        Me.grdArquivos.DesignTimeLayout = grdArquivos_DesignTimeLayout
        Me.grdArquivos.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdArquivos.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdArquivos.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdArquivos.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdArquivos.GroupByBoxVisible = False
        Me.grdArquivos.Location = New System.Drawing.Point(3, 29)
        Me.grdArquivos.Name = "grdArquivos"
        Me.grdArquivos.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdArquivos.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdArquivos.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdArquivos.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdArquivos.Size = New System.Drawing.Size(1172, 197)
        Me.grdArquivos.TabIndex = 2
        Me.grdArquivos.TabStop = False
        Me.grdArquivos.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdArquivos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'btnArquivo
        '
        Me.btnArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnArquivo.Location = New System.Drawing.Point(1155, 3)
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivo.Size = New System.Drawing.Size(20, 20)
        Me.btnArquivo.TabIndex = 1
        Me.btnArquivo.Text = "..."
        Me.btnArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtArquivo
        '
        Me.txtArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivo.Location = New System.Drawing.Point(3, 3)
        Me.txtArquivo.MaxLength = 255
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(1172, 20)
        Me.txtArquivo.TabIndex = 0
        Me.txtArquivo.TabStop = False
        '
        'pagComentario
        '
        Me.pagComentario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pagComentario.Controls.Add(Me.grdComentario)
        Me.pagComentario.Key = "pagComentario"
        Me.pagComentario.Location = New System.Drawing.Point(1, 33)
        Me.pagComentario.Name = "pagComentario"
        Me.pagComentario.Size = New System.Drawing.Size(1178, 218)
        Me.pagComentario.TabStop = True
        Me.pagComentario.Text = "Comentários"
        '
        'grdComentario
        '
        Me.grdComentario.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdComentario.AlternatingColors = True
        Me.grdComentario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdComentario.ColumnAutoResize = True
        Me.grdComentario.ColumnAutoSizeMode = Janus.Windows.GridEX.ColumnAutoSizeMode.DisplayedCellsAndHeader
        grdComentario_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdComentario_DesignTimeLayout_Reference_0.Instance"), Object)
        grdComentario_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdComentario_DesignTimeLayout_Reference_0})
        grdComentario_DesignTimeLayout.LayoutString = resources.GetString("grdComentario_DesignTimeLayout.LayoutString")
        Me.grdComentario.DesignTimeLayout = grdComentario_DesignTimeLayout
        Me.grdComentario.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdComentario.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdComentario.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdComentario.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdComentario.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdComentario.GroupByBoxVisible = False
        Me.grdComentario.Location = New System.Drawing.Point(3, 3)
        Me.grdComentario.Name = "grdComentario"
        Me.grdComentario.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdComentario.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdComentario.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdComentario.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdComentario.Size = New System.Drawing.Size(1172, 212)
        Me.grdComentario.TabIndex = 33
        Me.grdComentario.TabStop = False
        Me.grdComentario.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdComentario.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnAutorizarAtividade)
        Me.grpControl2.Controls.Add(Me.btnAgCliente)
        Me.grpControl2.Controls.Add(Me.btnIniciar)
        Me.grpControl2.Controls.Add(Me.btnFinalizarChamado)
        Me.grpControl2.Controls.Add(Me.btnInserirComentario)
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Location = New System.Drawing.Point(8, 488)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(1180, 51)
        Me.grpControl2.TabIndex = 0
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'btnAutorizarAtividade
        '
        Me.btnAutorizarAtividade.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnAutorizarAtividade.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAutorizarAtividade.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnAutorizarAtividade.Location = New System.Drawing.Point(203, 17)
        Me.btnAutorizarAtividade.Name = "btnAutorizarAtividade"
        Me.btnAutorizarAtividade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAutorizarAtividade.Size = New System.Drawing.Size(146, 23)
        Me.btnAutorizarAtividade.TabIndex = 7
        Me.btnAutorizarAtividade.Text = "Autorizar Atividade"
        Me.btnAutorizarAtividade.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAgCliente
        '
        Me.btnAgCliente.Image = Global.INTERACTI.My.Resources.Resources.run
        Me.btnAgCliente.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAgCliente.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnAgCliente.Location = New System.Drawing.Point(106, 17)
        Me.btnAgCliente.Name = "btnAgCliente"
        Me.btnAgCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAgCliente.Size = New System.Drawing.Size(91, 23)
        Me.btnAgCliente.TabIndex = 6
        Me.btnAgCliente.Text = "AG Cliente"
        Me.btnAgCliente.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnIniciar
        '
        Me.btnIniciar.Image = Global.INTERACTI.My.Resources.Resources.relogio
        Me.btnIniciar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnIniciar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnIniciar.Location = New System.Drawing.Point(9, 17)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnIniciar.Size = New System.Drawing.Size(91, 23)
        Me.btnIniciar.TabIndex = 5
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnFinalizarChamado
        '
        Me.btnFinalizarChamado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinalizarChamado.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnFinalizarChamado.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFinalizarChamado.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnFinalizarChamado.Location = New System.Drawing.Point(660, 17)
        Me.btnFinalizarChamado.Name = "btnFinalizarChamado"
        Me.btnFinalizarChamado.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFinalizarChamado.Size = New System.Drawing.Size(91, 23)
        Me.btnFinalizarChamado.TabIndex = 4
        Me.btnFinalizarChamado.Text = "Finalizar"
        Me.btnFinalizarChamado.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirComentario
        '
        Me.btnInserirComentario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirComentario.Image = CType(resources.GetObject("btnInserirComentario.Image"), System.Drawing.Image)
        Me.btnInserirComentario.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirComentario.Location = New System.Drawing.Point(757, 17)
        Me.btnInserirComentario.Name = "btnInserirComentario"
        Me.btnInserirComentario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirComentario.Size = New System.Drawing.Size(123, 23)
        Me.btnInserirComentario.TabIndex = 0
        Me.btnInserirComentario.Text = "Inserir Comentário"
        Me.btnInserirComentario.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(886, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 1
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(1080, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
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
        Me.btnSalvar.Location = New System.Drawing.Point(983, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtPrazoResposta)
        Me.grpDados.Controls.Add(Me.lblPrazoResposta)
        Me.grpDados.Controls.Add(Me.txtDataAutorizacao)
        Me.grpDados.Controls.Add(Me.lblDataAutorizacao)
        Me.grpDados.Controls.Add(Me.txtNumeroDocumento)
        Me.grpDados.Controls.Add(Me.lblNumeroDocumento)
        Me.grpDados.Controls.Add(Me.txtTela)
        Me.grpDados.Controls.Add(Me.lblTela)
        Me.grpDados.Controls.Add(Me.txtModulo)
        Me.grpDados.Controls.Add(Me.lblModulo)
        Me.grpDados.Controls.Add(Me.cboPrioridade)
        Me.grpDados.Controls.Add(Me.lblPrioridade)
        Me.grpDados.Controls.Add(Me.dtpDataChamado)
        Me.grpDados.Controls.Add(Me.txtSolicitante)
        Me.grpDados.Controls.Add(Me.lblSolicitante)
        Me.grpDados.Controls.Add(Me.txtStatus)
        Me.grpDados.Controls.Add(Me.lblStatus)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDefinicao)
        Me.grpDados.Controls.Add(Me.lblTipoChamado)
        Me.grpDados.Controls.Add(Me.cboTipoAtividade)
        Me.grpDados.Controls.Add(Me.lblDataChamado)
        Me.grpDados.Controls.Add(Me.lblCodigo)
        Me.grpDados.Controls.Add(Me.txtCodigo)
        Me.grpDados.Controls.Add(Me.txtTitulo)
        Me.grpDados.Controls.Add(Me.lblTitulo)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(1180, 221)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'txtPrazoResposta
        '
        Me.txtPrazoResposta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrazoResposta.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPrazoResposta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrazoResposta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrazoResposta.Location = New System.Drawing.Point(1055, 74)
        Me.txtPrazoResposta.MaxLength = 100
        Me.txtPrazoResposta.Name = "txtPrazoResposta"
        Me.txtPrazoResposta.ReadOnly = True
        Me.txtPrazoResposta.Size = New System.Drawing.Size(116, 20)
        Me.txtPrazoResposta.TabIndex = 32
        Me.txtPrazoResposta.TabStop = False
        '
        'lblPrazoResposta
        '
        Me.lblPrazoResposta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrazoResposta.AutoSize = True
        Me.lblPrazoResposta.Location = New System.Drawing.Point(1052, 57)
        Me.lblPrazoResposta.Name = "lblPrazoResposta"
        Me.lblPrazoResposta.Size = New System.Drawing.Size(87, 14)
        Me.lblPrazoResposta.TabIndex = 31
        Me.lblPrazoResposta.Text = "Prazo Resposta:"
        '
        'txtDataAutorizacao
        '
        Me.txtDataAutorizacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDataAutorizacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataAutorizacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataAutorizacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataAutorizacao.Location = New System.Drawing.Point(1055, 34)
        Me.txtDataAutorizacao.MaxLength = 100
        Me.txtDataAutorizacao.Name = "txtDataAutorizacao"
        Me.txtDataAutorizacao.ReadOnly = True
        Me.txtDataAutorizacao.Size = New System.Drawing.Size(116, 20)
        Me.txtDataAutorizacao.TabIndex = 30
        Me.txtDataAutorizacao.TabStop = False
        '
        'lblDataAutorizacao
        '
        Me.lblDataAutorizacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataAutorizacao.AutoSize = True
        Me.lblDataAutorizacao.Location = New System.Drawing.Point(1052, 17)
        Me.lblDataAutorizacao.Name = "lblDataAutorizacao"
        Me.lblDataAutorizacao.Size = New System.Drawing.Size(93, 14)
        Me.lblDataAutorizacao.TabIndex = 29
        Me.lblDataAutorizacao.Text = "Data Autorização:"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(971, 74)
        Me.txtNumeroDocumento.MaxLength = 100
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(78, 20)
        Me.txtNumeroDocumento.TabIndex = 6
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(968, 57)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroDocumento.TabIndex = 25
        Me.lblNumeroDocumento.Text = "N° Documento:"
        '
        'txtTela
        '
        Me.txtTela.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTela.Location = New System.Drawing.Point(805, 74)
        Me.txtTela.MaxLength = 100
        Me.txtTela.Name = "txtTela"
        Me.txtTela.Size = New System.Drawing.Size(160, 20)
        Me.txtTela.TabIndex = 5
        '
        'lblTela
        '
        Me.lblTela.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTela.AutoSize = True
        Me.lblTela.Location = New System.Drawing.Point(802, 57)
        Me.lblTela.Name = "lblTela"
        Me.lblTela.Size = New System.Drawing.Size(29, 14)
        Me.lblTela.TabIndex = 23
        Me.lblTela.Text = "Tela:"
        '
        'txtModulo
        '
        Me.txtModulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtModulo.Location = New System.Drawing.Point(624, 74)
        Me.txtModulo.MaxLength = 100
        Me.txtModulo.Name = "txtModulo"
        Me.txtModulo.Size = New System.Drawing.Size(175, 20)
        Me.txtModulo.TabIndex = 4
        '
        'lblModulo
        '
        Me.lblModulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblModulo.AutoSize = True
        Me.lblModulo.Location = New System.Drawing.Point(621, 57)
        Me.lblModulo.Name = "lblModulo"
        Me.lblModulo.Size = New System.Drawing.Size(44, 14)
        Me.lblModulo.TabIndex = 10
        Me.lblModulo.Text = "Módulo:"
        '
        'cboPrioridade
        '
        Me.cboPrioridade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPrioridade.AutoSize = False
        Me.cboPrioridade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboPrioridade.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboPrioridade.Location = New System.Drawing.Point(971, 34)
        Me.cboPrioridade.Name = "cboPrioridade"
        Me.cboPrioridade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPrioridade.Size = New System.Drawing.Size(78, 20)
        Me.cboPrioridade.TabIndex = 2
        '
        'lblPrioridade
        '
        Me.lblPrioridade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrioridade.AutoSize = True
        Me.lblPrioridade.Location = New System.Drawing.Point(970, 17)
        Me.lblPrioridade.Name = "lblPrioridade"
        Me.lblPrioridade.Size = New System.Drawing.Size(58, 14)
        Me.lblPrioridade.TabIndex = 8
        Me.lblPrioridade.Text = "Prioridade:"
        '
        'dtpDataChamado
        '
        Me.dtpDataChamado.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.dtpDataChamado.DropDownCalendar.Name = ""
        Me.dtpDataChamado.Location = New System.Drawing.Point(96, 34)
        Me.dtpDataChamado.Name = "dtpDataChamado"
        Me.dtpDataChamado.ReadOnly = True
        Me.dtpDataChamado.Size = New System.Drawing.Size(86, 20)
        Me.dtpDataChamado.TabIndex = 2
        Me.dtpDataChamado.TabStop = False
        Me.dtpDataChamado.Value = New Date(2017, 8, 17, 0, 0, 0, 0)
        '
        'txtSolicitante
        '
        Me.txtSolicitante.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSolicitante.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSolicitante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSolicitante.Location = New System.Drawing.Point(624, 34)
        Me.txtSolicitante.MaxLength = 100
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.ReadOnly = True
        Me.txtSolicitante.Size = New System.Drawing.Size(175, 20)
        Me.txtSolicitante.TabIndex = 3
        Me.txtSolicitante.TabStop = False
        '
        'lblSolicitante
        '
        Me.lblSolicitante.AutoSize = True
        Me.lblSolicitante.Location = New System.Drawing.Point(621, 17)
        Me.lblSolicitante.Name = "lblSolicitante"
        Me.lblSolicitante.Size = New System.Drawing.Size(59, 14)
        Me.lblSolicitante.TabIndex = 4
        Me.lblSolicitante.Text = "Solicitante:"
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStatus.Location = New System.Drawing.Point(188, 34)
        Me.txtStatus.MaxLength = 255
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(430, 20)
        Me.txtStatus.TabIndex = 14
        Me.txtStatus.TabStop = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(185, 17)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(41, 14)
        Me.lblStatus.TabIndex = 16
        Me.lblStatus.Text = "Status:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.Location = New System.Drawing.Point(9, 114)
        Me.txtDescricao.MaxLength = 0
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescricao.Size = New System.Drawing.Size(1163, 101)
        Me.txtDescricao.TabIndex = 7
        '
        'lblDefinicao
        '
        Me.lblDefinicao.AutoSize = True
        Me.lblDefinicao.Location = New System.Drawing.Point(6, 97)
        Me.lblDefinicao.Name = "lblDefinicao"
        Me.lblDefinicao.Size = New System.Drawing.Size(59, 14)
        Me.lblDefinicao.TabIndex = 8
        Me.lblDefinicao.Text = "Descrição:"
        '
        'lblTipoChamado
        '
        Me.lblTipoChamado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoChamado.AutoSize = True
        Me.lblTipoChamado.Location = New System.Drawing.Point(802, 17)
        Me.lblTipoChamado.Name = "lblTipoChamado"
        Me.lblTipoChamado.Size = New System.Drawing.Size(30, 14)
        Me.lblTipoChamado.TabIndex = 6
        Me.lblTipoChamado.Text = "Tipo:"
        '
        'cboTipoAtividade
        '
        Me.cboTipoAtividade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoAtividade.AutoSize = False
        Me.cboTipoAtividade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "SIM"
        UiComboBoxItem5.Value = True
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "NÃO"
        UiComboBoxItem6.Value = False
        Me.cboTipoAtividade.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboTipoAtividade.Location = New System.Drawing.Point(805, 34)
        Me.cboTipoAtividade.Name = "cboTipoAtividade"
        Me.cboTipoAtividade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoAtividade.Size = New System.Drawing.Size(160, 20)
        Me.cboTipoAtividade.TabIndex = 1
        '
        'lblDataChamado
        '
        Me.lblDataChamado.AutoSize = True
        Me.lblDataChamado.Location = New System.Drawing.Point(93, 17)
        Me.lblDataChamado.Name = "lblDataChamado"
        Me.lblDataChamado.Size = New System.Drawing.Size(80, 14)
        Me.lblDataChamado.TabIndex = 2
        Me.lblDataChamado.Text = "Data Chamado:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(9, 34)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(81, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.TabStop = False
        '
        'txtTitulo
        '
        Me.txtTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTitulo.Location = New System.Drawing.Point(9, 74)
        Me.txtTitulo.MaxLength = 1000
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(609, 20)
        Me.txtTitulo.TabIndex = 3
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(6, 56)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(35, 14)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "Título:"
        '
        'pagGrafico
        '
        Me.pagGrafico.Controls.Add(Me.UiGroupBox2)
        Me.pagGrafico.Controls.Add(Me.chrGrafico)
        Me.pagGrafico.Controls.Add(Me.grpGrafico)
        Me.pagGrafico.Key = "pagGrafico"
        Me.pagGrafico.Location = New System.Drawing.Point(1, 22)
        Me.pagGrafico.Name = "pagGrafico"
        Me.pagGrafico.Size = New System.Drawing.Size(1198, 542)
        Me.pagGrafico.TabStop = True
        Me.pagGrafico.TabVisible = False
        Me.pagGrafico.Text = "Gráfico"
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.btnSair2)
        Me.UiGroupBox2.Location = New System.Drawing.Point(7, 488)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.Size = New System.Drawing.Size(1185, 51)
        Me.UiGroupBox2.TabIndex = 4
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'btnSair2
        '
        Me.btnSair2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSair2.Image = CType(resources.GetObject("btnSair2.Image"), System.Drawing.Image)
        Me.btnSair2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair2.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair2.Location = New System.Drawing.Point(1088, 18)
        Me.btnSair2.Name = "btnSair2"
        Me.btnSair2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair2.Size = New System.Drawing.Size(91, 23)
        Me.btnSair2.TabIndex = 3
        Me.btnSair2.Text = "Sair"
        Me.btnSair2.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'chrGrafico
        '
        Me.chrGrafico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrGrafico.BackColor = System.Drawing.Color.WhiteSmoke
        Me.chrGrafico.BackGradientEndColor = System.Drawing.Color.White
        Me.chrGrafico.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft
        Me.chrGrafico.BorderLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chrGrafico.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrGrafico.BorderSkin.FrameBackColor = System.Drawing.Color.CornflowerBlue
        Me.chrGrafico.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.CornflowerBlue
        Me.chrGrafico.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.Area3DStyle.Light = Dundas.Charting.WinControl.LightStyle.Realistic
        ChartArea1.AxisX.LabelsAutoFit = False
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.AxisX.LabelStyle.IntervalOffset = 0.0R
        ChartArea1.AxisX.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorGrid.Interval = 0.0R
        ChartArea1.AxisX.MajorGrid.IntervalOffset = 0.0R
        ChartArea1.AxisX.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX.MajorTickMark.Interval = 0.0R
        ChartArea1.AxisX.MajorTickMark.IntervalOffset = 0.0R
        ChartArea1.AxisX.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX.ScrollBar.Size = 10.0R
        ChartArea1.AxisX.Title = "Ano/Mês"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.AxisX2.LabelStyle.Interval = 0.0R
        ChartArea1.AxisX2.LabelStyle.IntervalOffset = 0.0R
        ChartArea1.AxisX2.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MajorGrid.Interval = 0.0R
        ChartArea1.AxisX2.MajorGrid.IntervalOffset = 0.0R
        ChartArea1.AxisX2.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX2.MajorTickMark.Interval = 0.0R
        ChartArea1.AxisX2.MajorTickMark.IntervalOffset = 0.0R
        ChartArea1.AxisX2.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.LabelsAutoFit = False
        ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.AxisY.LabelStyle.Interval = 0.0R
        ChartArea1.AxisY.LabelStyle.IntervalOffset = 0.0R
        ChartArea1.AxisY.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MajorGrid.Interval = 0.0R
        ChartArea1.AxisY.MajorGrid.IntervalOffset = 0.0R
        ChartArea1.AxisY.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.MajorTickMark.Interval = 0.0R
        ChartArea1.AxisY.MajorTickMark.IntervalOffset = 0.0R
        ChartArea1.AxisY.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.Title = "Índice QE (%)"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.AxisY2.LabelStyle.Interval = 0.0R
        ChartArea1.AxisY2.LabelStyle.IntervalOffset = 0.0R
        ChartArea1.AxisY2.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.MajorGrid.Interval = 0.0R
        ChartArea1.AxisY2.MajorGrid.IntervalOffset = 0.0R
        ChartArea1.AxisY2.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY2.MajorTickMark.Interval = 0.0R
        ChartArea1.AxisY2.MajorTickMark.IntervalOffset = 0.0R
        ChartArea1.AxisY2.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.BackColor = System.Drawing.Color.White
        ChartArea1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        ChartArea1.EquallySizedAxesFont = True
        ChartArea1.Name = "Default"
        ChartArea1.ShadowOffset = 2
        Me.chrGrafico.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.AutoFitText = False
        Legend1.BorderColor = System.Drawing.Color.Black
        Legend1.Docking = Dundas.Charting.WinControl.LegendDocking.Bottom
        Legend1.Font = New System.Drawing.Font("Arial", 6.75!)
        Legend1.LegendStyle = Dundas.Charting.WinControl.LegendStyle.Row
        Legend1.Name = "Default"
        Me.chrGrafico.Legends.Add(Legend1)
        Me.chrGrafico.Location = New System.Drawing.Point(7, 75)
        Me.chrGrafico.Name = "chrGrafico"
        Me.chrGrafico.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series1.Font = New System.Drawing.Font("Arial", 6.75!)
        Series1.Name = "Valor"
        Series1.ShadowOffset = 1
        Series1.ShowLabelAsValue = True
        Series1.SmartLabels.Enabled = True
        Series1.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series1.YValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series2.Font = New System.Drawing.Font("Arial", 6.75!)
        Series2.Name = "Quantidade"
        Series2.ShadowOffset = 1
        Series2.ShowLabelAsValue = True
        Series2.SmartLabels.Enabled = True
        Series2.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series2.YValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Me.chrGrafico.Series.Add(Series1)
        Me.chrGrafico.Series.Add(Series2)
        Me.chrGrafico.Size = New System.Drawing.Size(1185, 406)
        Me.chrGrafico.TabIndex = 23
        Me.chrGrafico.Tag = "S"
        Title1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Title1.Name = "Title1"
        Title1.Text = "Performace Fornecedor - Índice QE"
        Me.chrGrafico.Titles.Add(Title1)
        Me.chrGrafico.UI.Toolbar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chrGrafico.UI.Toolbar.BorderSkin.PageColor = System.Drawing.Color.Transparent
        Me.chrGrafico.UI.Toolbar.Enabled = True
        CommandUIItem1.CommandName = "SaveImage"
        CommandUIItem2.CommandName = "Copy"
        CommandUIItem3.CommandName = "Print"
        CommandUIItem4.CommandName = "PrintPreview"
        CommandUIItem5.CommandName = "Separator"
        CommandUIItem6.CommandName = "SelectChartGroup"
        CommandUIItem7.CommandName = "ToggleLegend"
        CommandUIItem8.CommandName = "Toggle3D"
        CommandUIItem9.CommandName = "Separator"
        CommandUIItem10.CommandName = "AddAnnotationGroup"
        CommandUIItem11.CommandName = "Separator"
        CommandUIItem12.CommandName = "Properties"
        Me.chrGrafico.UI.Toolbar.Items.Add(CommandUIItem1)
        Me.chrGrafico.UI.Toolbar.Items.Add(CommandUIItem2)
        Me.chrGrafico.UI.Toolbar.Items.Add(CommandUIItem3)
        Me.chrGrafico.UI.Toolbar.Items.Add(CommandUIItem4)
        Me.chrGrafico.UI.Toolbar.Items.Add(CommandUIItem5)
        Me.chrGrafico.UI.Toolbar.Items.Add(CommandUIItem6)
        Me.chrGrafico.UI.Toolbar.Items.Add(CommandUIItem7)
        Me.chrGrafico.UI.Toolbar.Items.Add(CommandUIItem8)
        Me.chrGrafico.UI.Toolbar.Items.Add(CommandUIItem9)
        Me.chrGrafico.UI.Toolbar.Items.Add(CommandUIItem10)
        Me.chrGrafico.UI.Toolbar.Items.Add(CommandUIItem11)
        Me.chrGrafico.UI.Toolbar.Items.Add(CommandUIItem12)
        '
        'grpGrafico
        '
        Me.grpGrafico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpGrafico.BackColor = System.Drawing.Color.Transparent
        Me.grpGrafico.Controls.Add(Me.cboEixoY2)
        Me.grpGrafico.Controls.Add(Me.lblEixoY2)
        Me.grpGrafico.Controls.Add(Me.txtMeta)
        Me.grpGrafico.Controls.Add(Me.lblMeta)
        Me.grpGrafico.Controls.Add(Me.cboIntervalo)
        Me.grpGrafico.Controls.Add(Me.lblIntervaloAgrupamento)
        Me.grpGrafico.Controls.Add(Me.cboTipo)
        Me.grpGrafico.Controls.Add(Me.lblTipo)
        Me.grpGrafico.Controls.Add(Me.cboEixoY)
        Me.grpGrafico.Controls.Add(Me.lblValorEixoY)
        Me.grpGrafico.Controls.Add(Me.cboSerie)
        Me.grpGrafico.Controls.Add(Me.btnGerarGrafico)
        Me.grpGrafico.Controls.Add(Me.lblSerie)
        Me.grpGrafico.Location = New System.Drawing.Point(7, 5)
        Me.grpGrafico.Name = "grpGrafico"
        Me.grpGrafico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpGrafico.Size = New System.Drawing.Size(1185, 64)
        Me.grpGrafico.TabIndex = 22
        Me.grpGrafico.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'cboEixoY2
        '
        Me.cboEixoY2.AutoSize = False
        Me.cboEixoY2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEixoY2.Location = New System.Drawing.Point(337, 31)
        Me.cboEixoY2.Name = "cboEixoY2"
        Me.cboEixoY2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboEixoY2.Size = New System.Drawing.Size(158, 20)
        Me.cboEixoY2.TabIndex = 3
        '
        'lblEixoY2
        '
        Me.lblEixoY2.AutoSize = True
        Me.lblEixoY2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEixoY2.Location = New System.Drawing.Point(334, 14)
        Me.lblEixoY2.Name = "lblEixoY2"
        Me.lblEixoY2.Size = New System.Drawing.Size(95, 14)
        Me.lblEixoY2.TabIndex = 2
        Me.lblEixoY2.Text = "EixoY² (Opcional):"
        '
        'txtMeta
        '
        Me.txtMeta.FormatString = "0"
        Me.txtMeta.Location = New System.Drawing.Point(829, 31)
        Me.txtMeta.Name = "txtMeta"
        Me.txtMeta.Size = New System.Drawing.Size(110, 20)
        Me.txtMeta.TabIndex = 11
        Me.txtMeta.Text = "0"
        Me.txtMeta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMeta
        '
        Me.lblMeta.AutoSize = True
        Me.lblMeta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMeta.Location = New System.Drawing.Point(826, 14)
        Me.lblMeta.Name = "lblMeta"
        Me.lblMeta.Size = New System.Drawing.Size(33, 14)
        Me.lblMeta.TabIndex = 10
        Me.lblMeta.Text = "Meta:"
        '
        'cboIntervalo
        '
        Me.cboIntervalo.AutoSize = False
        Me.cboIntervalo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboIntervalo.Location = New System.Drawing.Point(665, 31)
        Me.cboIntervalo.Name = "cboIntervalo"
        Me.cboIntervalo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboIntervalo.Size = New System.Drawing.Size(158, 20)
        Me.cboIntervalo.TabIndex = 9
        '
        'lblIntervaloAgrupamento
        '
        Me.lblIntervaloAgrupamento.AutoSize = True
        Me.lblIntervaloAgrupamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIntervaloAgrupamento.Location = New System.Drawing.Point(662, 14)
        Me.lblIntervaloAgrupamento.Name = "lblIntervaloAgrupamento"
        Me.lblIntervaloAgrupamento.Size = New System.Drawing.Size(151, 14)
        Me.lblIntervaloAgrupamento.TabIndex = 8
        Me.lblIntervaloAgrupamento.Text = "Intervalo Agrupamento (Data):"
        '
        'cboTipo
        '
        Me.cboTipo.AutoSize = False
        Me.cboTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipo.Location = New System.Drawing.Point(501, 31)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipo.Size = New System.Drawing.Size(158, 20)
        Me.cboTipo.TabIndex = 7
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipo.Location = New System.Drawing.Point(498, 14)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 14)
        Me.lblTipo.TabIndex = 6
        Me.lblTipo.Text = "Tipo:"
        '
        'cboEixoY
        '
        Me.cboEixoY.AutoSize = False
        Me.cboEixoY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEixoY.Location = New System.Drawing.Point(173, 31)
        Me.cboEixoY.Name = "cboEixoY"
        Me.cboEixoY.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboEixoY.Size = New System.Drawing.Size(158, 20)
        Me.cboEixoY.TabIndex = 5
        '
        'lblValorEixoY
        '
        Me.lblValorEixoY.AutoSize = True
        Me.lblValorEixoY.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValorEixoY.Location = New System.Drawing.Point(170, 14)
        Me.lblValorEixoY.Name = "lblValorEixoY"
        Me.lblValorEixoY.Size = New System.Drawing.Size(40, 14)
        Me.lblValorEixoY.TabIndex = 4
        Me.lblValorEixoY.Text = "Eixo Y:"
        '
        'cboSerie
        '
        Me.cboSerie.AutoSize = False
        Me.cboSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSerie.Location = New System.Drawing.Point(9, 31)
        Me.cboSerie.Name = "cboSerie"
        Me.cboSerie.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSerie.Size = New System.Drawing.Size(158, 20)
        Me.cboSerie.TabIndex = 1
        '
        'btnGerarGrafico
        '
        Me.btnGerarGrafico.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnGerarGrafico.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnGerarGrafico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarGrafico.Location = New System.Drawing.Point(1032, 28)
        Me.btnGerarGrafico.Name = "btnGerarGrafico"
        Me.btnGerarGrafico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnGerarGrafico.Size = New System.Drawing.Size(143, 23)
        Me.btnGerarGrafico.TabIndex = 12
        Me.btnGerarGrafico.Text = "Gerar Gráfico"
        Me.btnGerarGrafico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSerie.Location = New System.Drawing.Point(6, 14)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(89, 14)
        Me.lblSerie.TabIndex = 0
        Me.lblSerie.Text = "Série do Gráfico:"
        '
        'ToolTip
        '
        Me.ToolTip.AutomaticDelay = 0
        Me.ToolTip.AutoPopDelay = 5000
        Me.ToolTip.InitialDelay = 0
        Me.ToolTip.ReshowDelay = 0
        Me.ToolTip.ShowAlways = True
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'usrAdmChamado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "usrAdmChamado"
        Me.Size = New System.Drawing.Size(1200, 565)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLiberado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctAguardandoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picParcialmenteEntregue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEntregue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaTipoOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.tabDadosChamado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDadosChamado.ResumeLayout(False)
        Me.pagArquivos.ResumeLayout(False)
        Me.pagArquivos.PerformLayout()
        CType(Me.grdArquivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagComentario.ResumeLayout(False)
        CType(Me.grdComentario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.pagGrafico.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        CType(Me.chrGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGrafico.ResumeLayout(False)
        Me.grpGrafico.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagGrafico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtSolicitanteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents lblSolicitanteFiltro As System.Windows.Forms.Label
    Friend WithEvents lblTipoChamadoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoAtividadeFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCodigoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtTituloFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTituloFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents txtTela As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTela As System.Windows.Forms.Label
    Friend WithEvents txtModulo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblModulo As System.Windows.Forms.Label
    Friend WithEvents cboPrioridade As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblPrioridade As System.Windows.Forms.Label
    Friend WithEvents dtpDataChamado As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtSolicitante As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSolicitante As System.Windows.Forms.Label
    Friend WithEvents txtStatus As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblDefinicao As System.Windows.Forms.Label
    Friend WithEvents lblTipoChamado As System.Windows.Forms.Label
    Friend WithEvents cboTipoAtividade As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDataChamado As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtTitulo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnInserirComentario As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents chrGrafico As Dundas.Charting.WinControl.Chart
    Friend WithEvents grpGrafico As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboEixoY2 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblEixoY2 As System.Windows.Forms.Label
    Friend WithEvents txtMeta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMeta As System.Windows.Forms.Label
    Friend WithEvents cboIntervalo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblIntervaloAgrupamento As System.Windows.Forms.Label
    Friend WithEvents cboTipo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents cboEixoY As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblValorEixoY As System.Windows.Forms.Label
    Friend WithEvents cboSerie As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnGerarGrafico As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents tabDadosChamado As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagArquivos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagComentario As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdComentario As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdArquivos As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblAberta As System.Windows.Forms.Label
    Friend WithEvents picParcialmenteEntregue As System.Windows.Forms.PictureBox
    Friend WithEvents lblConcluida As System.Windows.Forms.Label
    Friend WithEvents picEntregue As System.Windows.Forms.PictureBox
    Friend WithEvents lblCancelada As System.Windows.Forms.Label
    Friend WithEvents picLegendaCancelado As System.Windows.Forms.PictureBox
    Friend WithEvents lblIniciada As System.Windows.Forms.Label
    Friend WithEvents picLegendaTipoOrcamento As System.Windows.Forms.PictureBox
    Friend WithEvents btnFinalizarChamado As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblLegAguardandoCliente As System.Windows.Forms.Label
    Friend WithEvents pctAguardandoCliente As System.Windows.Forms.PictureBox
    Friend WithEvents btnAgCliente As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnIniciar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAutorizarAtividade As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataAutorizacao As Label
    Friend WithEvents txtDataAutorizacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblLegendaLiberada As Label
    Friend WithEvents picLiberado As PictureBox
    Friend WithEvents txtPrazoResposta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPrazoResposta As Label
End Class
