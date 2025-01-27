<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrIntConciliacaoBancaria
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
        Dim grdRemessa_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrIntConciliacaoBancaria))
        Dim grdRetorno_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdRetorno_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim grdPagamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagRemessa = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaGeradoArquivo = New System.Windows.Forms.Label()
        Me.picLegendaGeradoArquivo = New System.Windows.Forms.PictureBox()
        Me.btnExcelGridRemessa = New System.Windows.Forms.Button()
        Me.btnAgruparGridRemessa = New System.Windows.Forms.Button()
        Me.btnConfigurarGridRemessa = New System.Windows.Forms.Button()
        Me.grdRemessa = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltros = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnFiltrarRemessa = New Janus.Windows.EditControls.UIButton()
        Me.dtpDataEmissaoRemessaInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoRemessaTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblBancoContaRemessa = New System.Windows.Forms.Label()
        Me.cboBancoContaRemessa = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDataEmissaoRemessaFiltro = New System.Windows.Forms.Label()
        Me.grpControleRemessa = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnSairRemessa = New Janus.Windows.EditControls.UIButton()
        Me.btnGerarArquivoRemessa = New Janus.Windows.EditControls.UIButton()
        Me.pagRetorno = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridRetorno = New System.Windows.Forms.Button()
        Me.grpLegendaRetorno = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegendaBoletoPago = New System.Windows.Forms.PictureBox()
        Me.lblLegendaBoletoPago = New System.Windows.Forms.Label()
        Me.picLegendaBoletoRejeitado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaBoletoAberto = New System.Windows.Forms.Label()
        Me.lblLegendaBoletoRejeitado = New System.Windows.Forms.Label()
        Me.picLegendaBoletoAberto = New System.Windows.Forms.PictureBox()
        Me.grpControleRetorno = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovoRetorno = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvarRetorno = New Janus.Windows.EditControls.UIButton()
        Me.btnSairRetorno = New Janus.Windows.EditControls.UIButton()
        Me.grdRetorno = New Janus.Windows.GridEX.GridEX()
        Me.grpDadosArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtArquivoRetorno = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnImportarRetorno = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivoRetorno = New System.Windows.Forms.Label()
        Me.lblContaBancariaRetorno = New System.Windows.Forms.Label()
        Me.cboBancoContaRetorno = New Janus.Windows.EditControls.UIComboBox()
        Me.pagPagamento = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridPagamento = New System.Windows.Forms.Button()
        Me.btnAgruparGridPagamento = New System.Windows.Forms.Button()
        Me.btnConfigurarGridPagamento = New System.Windows.Forms.Button()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImportarExcelPagamento = New Janus.Windows.EditControls.UIButton()
        Me.UiButton3 = New Janus.Windows.EditControls.UIButton()
        Me.btnGerarArquivoPagamento = New Janus.Windows.EditControls.UIButton()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataEmissaoPagamentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoPagamentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissaoPagamentoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrarPagamento = New Janus.Windows.EditControls.UIButton()
        Me.grdPagamento = New Janus.Windows.GridEX.GridEX()
        Me.lblTipoServico = New System.Windows.Forms.Label()
        Me.cboTipoServico = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFormaLancamento = New System.Windows.Forms.Label()
        Me.cboFormaLancamento = New Janus.Windows.EditControls.UIComboBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagRemessa.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaGeradoArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRemessa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltros.SuspendLayout()
        CType(Me.grpControleRemessa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleRemessa.SuspendLayout()
        Me.pagRetorno.SuspendLayout()
        CType(Me.grpLegendaRetorno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegendaRetorno.SuspendLayout()
        CType(Me.picLegendaBoletoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaBoletoRejeitado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaBoletoAberto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControleRetorno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleRetorno.SuspendLayout()
        CType(Me.grdRetorno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDadosArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosArquivo.SuspendLayout()
        Me.pagPagamento.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(956, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagRemessa, Me.pagRetorno, Me.pagPagamento})
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagRemessa
        '
        Me.pagRemessa.Controls.Add(Me.grpLegenda)
        Me.pagRemessa.Controls.Add(Me.btnExcelGridRemessa)
        Me.pagRemessa.Controls.Add(Me.btnAgruparGridRemessa)
        Me.pagRemessa.Controls.Add(Me.btnConfigurarGridRemessa)
        Me.pagRemessa.Controls.Add(Me.grdRemessa)
        Me.pagRemessa.Controls.Add(Me.grpFiltros)
        Me.pagRemessa.Controls.Add(Me.grpControleRemessa)
        Me.pagRemessa.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagRemessa.Key = "pagLista"
        Me.pagRemessa.Location = New System.Drawing.Point(1, 22)
        Me.pagRemessa.Name = "pagRemessa"
        Me.pagRemessa.Size = New System.Drawing.Size(954, 543)
        Me.pagRemessa.TabStop = True
        Me.pagRemessa.Text = "Boleto Bancário - Remessa"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaGeradoArquivo)
        Me.grpLegenda.Controls.Add(Me.picLegendaGeradoArquivo)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(246, 51)
        Me.grpLegenda.TabIndex = 94
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaGeradoArquivo
        '
        Me.lblLegendaGeradoArquivo.AutoSize = True
        Me.lblLegendaGeradoArquivo.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaGeradoArquivo.Name = "lblLegendaGeradoArquivo"
        Me.lblLegendaGeradoArquivo.Size = New System.Drawing.Size(214, 14)
        Me.lblLegendaGeradoArquivo.TabIndex = 1
        Me.lblLegendaGeradoArquivo.Text = "Gerado Arquivo de Remessa para o Banco"
        '
        'picLegendaGeradoArquivo
        '
        Me.picLegendaGeradoArquivo.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaGeradoArquivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaGeradoArquivo.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaGeradoArquivo.Name = "picLegendaGeradoArquivo"
        Me.picLegendaGeradoArquivo.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaGeradoArquivo.TabIndex = 4
        Me.picLegendaGeradoArquivo.TabStop = False
        '
        'btnExcelGridRemessa
        '
        Me.btnExcelGridRemessa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridRemessa.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridRemessa.FlatAppearance.BorderSize = 0
        Me.btnExcelGridRemessa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridRemessa.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridRemessa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridRemessa.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGridRemessa.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridRemessa.Name = "btnExcelGridRemessa"
        Me.btnExcelGridRemessa.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridRemessa.TabIndex = 93
        Me.btnExcelGridRemessa.TabStop = False
        Me.btnExcelGridRemessa.UseVisualStyleBackColor = False
        '
        'btnAgruparGridRemessa
        '
        Me.btnAgruparGridRemessa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridRemessa.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridRemessa.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridRemessa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridRemessa.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridRemessa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridRemessa.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGridRemessa.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridRemessa.Name = "btnAgruparGridRemessa"
        Me.btnAgruparGridRemessa.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridRemessa.TabIndex = 25
        Me.btnAgruparGridRemessa.TabStop = False
        Me.btnAgruparGridRemessa.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridRemessa
        '
        Me.btnConfigurarGridRemessa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridRemessa.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridRemessa.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridRemessa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridRemessa.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridRemessa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridRemessa.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGridRemessa.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridRemessa.Name = "btnConfigurarGridRemessa"
        Me.btnConfigurarGridRemessa.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridRemessa.TabIndex = 2
        Me.btnConfigurarGridRemessa.TabStop = False
        Me.btnConfigurarGridRemessa.UseVisualStyleBackColor = False
        '
        'grdRemessa
        '
        Me.grdRemessa.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdRemessa.AlternatingColors = True
        Me.grdRemessa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRemessa.ColumnAutoResize = True
        grdRemessa_DesignTimeLayout.LayoutString = resources.GetString("grdRemessa_DesignTimeLayout.LayoutString")
        Me.grdRemessa.DesignTimeLayout = grdRemessa_DesignTimeLayout
        Me.grdRemessa.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdRemessa.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdRemessa.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdRemessa.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdRemessa.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdRemessa.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdRemessa.GroupByBoxVisible = False
        Me.grdRemessa.Location = New System.Drawing.Point(8, 76)
        Me.grdRemessa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdRemessa.Name = "grdRemessa"
        Me.grdRemessa.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdRemessa.RecordNavigator = True
        Me.grdRemessa.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdRemessa.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdRemessa.Size = New System.Drawing.Size(938, 404)
        Me.grdRemessa.TabIndex = 1
        Me.grdRemessa.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdRemessa.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdRemessa.VisualStyleManager = Me.vsmMain
        '
        'grpFiltros
        '
        Me.grpFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltros.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltros.Controls.Add(Me.btnFiltrarRemessa)
        Me.grpFiltros.Controls.Add(Me.dtpDataEmissaoRemessaInicioFiltro)
        Me.grpFiltros.Controls.Add(Me.dtpDataEmissaoRemessaTerminoFiltro)
        Me.grpFiltros.Controls.Add(Me.lblBancoContaRemessa)
        Me.grpFiltros.Controls.Add(Me.cboBancoContaRemessa)
        Me.grpFiltros.Controls.Add(Me.lblDataEmissaoRemessaFiltro)
        Me.grpFiltros.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltros.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltros.Name = "grpFiltros"
        Me.grpFiltros.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltros.Size = New System.Drawing.Size(938, 64)
        Me.grpFiltros.TabIndex = 0
        Me.grpFiltros.VisualStyleManager = Me.vsmMain
        '
        'btnFiltrarRemessa
        '
        Me.btnFiltrarRemessa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrarRemessa.Image = CType(resources.GetObject("btnFiltrarRemessa.Image"), System.Drawing.Image)
        Me.btnFiltrarRemessa.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrarRemessa.Location = New System.Drawing.Point(838, 31)
        Me.btnFiltrarRemessa.Name = "btnFiltrarRemessa"
        Me.btnFiltrarRemessa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrarRemessa.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrarRemessa.TabIndex = 5
        Me.btnFiltrarRemessa.Text = "Filtrar"
        Me.btnFiltrarRemessa.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'dtpDataEmissaoRemessaInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoRemessaInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoRemessaInicioFiltro.Location = New System.Drawing.Point(9, 34)
        Me.dtpDataEmissaoRemessaInicioFiltro.Name = "dtpDataEmissaoRemessaInicioFiltro"
        Me.dtpDataEmissaoRemessaInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoRemessaInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoRemessaInicioFiltro.TabIndex = 1
        Me.dtpDataEmissaoRemessaInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataEmissaoRemessaTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoRemessaTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoRemessaTerminoFiltro.Location = New System.Drawing.Point(123, 34)
        Me.dtpDataEmissaoRemessaTerminoFiltro.Name = "dtpDataEmissaoRemessaTerminoFiltro"
        Me.dtpDataEmissaoRemessaTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoRemessaTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoRemessaTerminoFiltro.TabIndex = 2
        Me.dtpDataEmissaoRemessaTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblBancoContaRemessa
        '
        Me.lblBancoContaRemessa.AutoSize = True
        Me.lblBancoContaRemessa.Location = New System.Drawing.Point(234, 17)
        Me.lblBancoContaRemessa.Name = "lblBancoContaRemessa"
        Me.lblBancoContaRemessa.Size = New System.Drawing.Size(84, 14)
        Me.lblBancoContaRemessa.TabIndex = 3
        Me.lblBancoContaRemessa.Text = "Conta Bancária:"
        '
        'cboBancoContaRemessa
        '
        Me.cboBancoContaRemessa.AutoSize = False
        Me.cboBancoContaRemessa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboBancoContaRemessa.Location = New System.Drawing.Point(237, 34)
        Me.cboBancoContaRemessa.Name = "cboBancoContaRemessa"
        Me.cboBancoContaRemessa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboBancoContaRemessa.Size = New System.Drawing.Size(395, 20)
        Me.cboBancoContaRemessa.TabIndex = 4
        '
        'lblDataEmissaoRemessaFiltro
        '
        Me.lblDataEmissaoRemessaFiltro.AutoSize = True
        Me.lblDataEmissaoRemessaFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblDataEmissaoRemessaFiltro.Name = "lblDataEmissaoRemessaFiltro"
        Me.lblDataEmissaoRemessaFiltro.Size = New System.Drawing.Size(90, 14)
        Me.lblDataEmissaoRemessaFiltro.TabIndex = 0
        Me.lblDataEmissaoRemessaFiltro.Text = "Data de Emissão:"
        '
        'grpControleRemessa
        '
        Me.grpControleRemessa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControleRemessa.BackColor = System.Drawing.Color.Transparent
        Me.grpControleRemessa.Controls.Add(Me.btnImprimir)
        Me.grpControleRemessa.Controls.Add(Me.btnSairRemessa)
        Me.grpControleRemessa.Controls.Add(Me.btnGerarArquivoRemessa)
        Me.grpControleRemessa.Location = New System.Drawing.Point(263, 483)
        Me.grpControleRemessa.Name = "grpControleRemessa"
        Me.grpControleRemessa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleRemessa.Size = New System.Drawing.Size(683, 51)
        Me.grpControleRemessa.TabIndex = 3
        Me.grpControleRemessa.VisualStyleManager = Me.vsmMain
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(6, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimir.Size = New System.Drawing.Size(91, 23)
        Me.btnImprimir.TabIndex = 6
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSairRemessa
        '
        Me.btnSairRemessa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSairRemessa.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSairRemessa.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSairRemessa.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSairRemessa.Location = New System.Drawing.Point(583, 17)
        Me.btnSairRemessa.Name = "btnSairRemessa"
        Me.btnSairRemessa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSairRemessa.Size = New System.Drawing.Size(91, 23)
        Me.btnSairRemessa.TabIndex = 2
        Me.btnSairRemessa.Text = "Sair"
        Me.btnSairRemessa.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnGerarArquivoRemessa
        '
        Me.btnGerarArquivoRemessa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGerarArquivoRemessa.Image = Global.INTERACTI.My.Resources.Resources.download
        Me.btnGerarArquivoRemessa.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarArquivoRemessa.Location = New System.Drawing.Point(377, 17)
        Me.btnGerarArquivoRemessa.Name = "btnGerarArquivoRemessa"
        Me.btnGerarArquivoRemessa.Size = New System.Drawing.Size(200, 23)
        Me.btnGerarArquivoRemessa.TabIndex = 1
        Me.btnGerarArquivoRemessa.Text = "Gerar Arquivo de Remessa"
        Me.btnGerarArquivoRemessa.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagRetorno
        '
        Me.pagRetorno.Controls.Add(Me.btnExcelGridRetorno)
        Me.pagRetorno.Controls.Add(Me.grpLegendaRetorno)
        Me.pagRetorno.Controls.Add(Me.grpControleRetorno)
        Me.pagRetorno.Controls.Add(Me.grdRetorno)
        Me.pagRetorno.Controls.Add(Me.grpDadosArquivo)
        Me.pagRetorno.Location = New System.Drawing.Point(1, 22)
        Me.pagRetorno.Name = "pagRetorno"
        Me.pagRetorno.Size = New System.Drawing.Size(954, 543)
        Me.pagRetorno.TabStop = True
        Me.pagRetorno.Text = "Boleto Bancário - Retorno"
        '
        'btnExcelGridRetorno
        '
        Me.btnExcelGridRetorno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridRetorno.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridRetorno.FlatAppearance.BorderSize = 0
        Me.btnExcelGridRetorno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridRetorno.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridRetorno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridRetorno.Location = New System.Drawing.Point(9, 463)
        Me.btnExcelGridRetorno.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridRetorno.Name = "btnExcelGridRetorno"
        Me.btnExcelGridRetorno.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridRetorno.TabIndex = 93
        Me.btnExcelGridRetorno.TabStop = False
        Me.btnExcelGridRetorno.UseVisualStyleBackColor = False
        '
        'grpLegendaRetorno
        '
        Me.grpLegendaRetorno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegendaRetorno.BackColor = System.Drawing.Color.Transparent
        Me.grpLegendaRetorno.Controls.Add(Me.picLegendaBoletoPago)
        Me.grpLegendaRetorno.Controls.Add(Me.lblLegendaBoletoPago)
        Me.grpLegendaRetorno.Controls.Add(Me.picLegendaBoletoRejeitado)
        Me.grpLegendaRetorno.Controls.Add(Me.lblLegendaBoletoAberto)
        Me.grpLegendaRetorno.Controls.Add(Me.lblLegendaBoletoRejeitado)
        Me.grpLegendaRetorno.Controls.Add(Me.picLegendaBoletoAberto)
        Me.grpLegendaRetorno.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegendaRetorno.Location = New System.Drawing.Point(8, 483)
        Me.grpLegendaRetorno.Name = "grpLegendaRetorno"
        Me.grpLegendaRetorno.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegendaRetorno.Size = New System.Drawing.Size(313, 51)
        Me.grpLegendaRetorno.TabIndex = 4
        Me.grpLegendaRetorno.Text = "Legenda"
        Me.grpLegendaRetorno.VisualStyleManager = Me.vsmMain
        '
        'picLegendaBoletoPago
        '
        Me.picLegendaBoletoPago.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaBoletoPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaBoletoPago.Location = New System.Drawing.Point(6, 20)
        Me.picLegendaBoletoPago.Name = "picLegendaBoletoPago"
        Me.picLegendaBoletoPago.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaBoletoPago.TabIndex = 4
        Me.picLegendaBoletoPago.TabStop = False
        '
        'lblLegendaBoletoPago
        '
        Me.lblLegendaBoletoPago.AutoSize = True
        Me.lblLegendaBoletoPago.Location = New System.Drawing.Point(25, 20)
        Me.lblLegendaBoletoPago.Name = "lblLegendaBoletoPago"
        Me.lblLegendaBoletoPago.Size = New System.Drawing.Size(64, 14)
        Me.lblLegendaBoletoPago.TabIndex = 0
        Me.lblLegendaBoletoPago.Text = "Boleto Pago"
        '
        'picLegendaBoletoRejeitado
        '
        Me.picLegendaBoletoRejeitado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaBoletoRejeitado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaBoletoRejeitado.Location = New System.Drawing.Point(206, 20)
        Me.picLegendaBoletoRejeitado.Name = "picLegendaBoletoRejeitado"
        Me.picLegendaBoletoRejeitado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaBoletoRejeitado.TabIndex = 14
        Me.picLegendaBoletoRejeitado.TabStop = False
        '
        'lblLegendaBoletoAberto
        '
        Me.lblLegendaBoletoAberto.AutoSize = True
        Me.lblLegendaBoletoAberto.Location = New System.Drawing.Point(112, 20)
        Me.lblLegendaBoletoAberto.Name = "lblLegendaBoletoAberto"
        Me.lblLegendaBoletoAberto.Size = New System.Drawing.Size(89, 14)
        Me.lblLegendaBoletoAberto.TabIndex = 1
        Me.lblLegendaBoletoAberto.Text = "Boleto em Aberto"
        '
        'lblLegendaBoletoRejeitado
        '
        Me.lblLegendaBoletoRejeitado.AutoSize = True
        Me.lblLegendaBoletoRejeitado.Location = New System.Drawing.Point(225, 20)
        Me.lblLegendaBoletoRejeitado.Name = "lblLegendaBoletoRejeitado"
        Me.lblLegendaBoletoRejeitado.Size = New System.Drawing.Size(84, 14)
        Me.lblLegendaBoletoRejeitado.TabIndex = 2
        Me.lblLegendaBoletoRejeitado.Text = "Boleto Rejeitado"
        '
        'picLegendaBoletoAberto
        '
        Me.picLegendaBoletoAberto.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaBoletoAberto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaBoletoAberto.Location = New System.Drawing.Point(93, 20)
        Me.picLegendaBoletoAberto.Name = "picLegendaBoletoAberto"
        Me.picLegendaBoletoAberto.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaBoletoAberto.TabIndex = 16
        Me.picLegendaBoletoAberto.TabStop = False
        '
        'grpControleRetorno
        '
        Me.grpControleRetorno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControleRetorno.BackColor = System.Drawing.Color.Transparent
        Me.grpControleRetorno.Controls.Add(Me.btnNovoRetorno)
        Me.grpControleRetorno.Controls.Add(Me.btnSalvarRetorno)
        Me.grpControleRetorno.Controls.Add(Me.btnSairRetorno)
        Me.grpControleRetorno.Location = New System.Drawing.Point(330, 483)
        Me.grpControleRetorno.Name = "grpControleRetorno"
        Me.grpControleRetorno.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleRetorno.Size = New System.Drawing.Size(616, 51)
        Me.grpControleRetorno.TabIndex = 3
        Me.grpControleRetorno.VisualStyleManager = Me.vsmMain
        '
        'btnNovoRetorno
        '
        Me.btnNovoRetorno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovoRetorno.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovoRetorno.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovoRetorno.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovoRetorno.Location = New System.Drawing.Point(322, 16)
        Me.btnNovoRetorno.Name = "btnNovoRetorno"
        Me.btnNovoRetorno.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovoRetorno.Size = New System.Drawing.Size(91, 23)
        Me.btnNovoRetorno.TabIndex = 3
        Me.btnNovoRetorno.Text = "Novo"
        Me.btnNovoRetorno.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvarRetorno
        '
        Me.btnSalvarRetorno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvarRetorno.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvarRetorno.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvarRetorno.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvarRetorno.Location = New System.Drawing.Point(419, 16)
        Me.btnSalvarRetorno.Name = "btnSalvarRetorno"
        Me.btnSalvarRetorno.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvarRetorno.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvarRetorno.TabIndex = 1
        Me.btnSalvarRetorno.Text = "Salvar"
        Me.btnSalvarRetorno.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSairRetorno
        '
        Me.btnSairRetorno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSairRetorno.Image = CType(resources.GetObject("btnSairRetorno.Image"), System.Drawing.Image)
        Me.btnSairRetorno.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSairRetorno.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSairRetorno.Location = New System.Drawing.Point(516, 16)
        Me.btnSairRetorno.Name = "btnSairRetorno"
        Me.btnSairRetorno.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSairRetorno.Size = New System.Drawing.Size(91, 23)
        Me.btnSairRetorno.TabIndex = 2
        Me.btnSairRetorno.Text = "Sair"
        Me.btnSairRetorno.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdRetorno
        '
        Me.grdRetorno.AlternatingColors = True
        Me.grdRetorno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRetorno.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "e o Cabeçalho da Coluna aqui para Agrupar</GroupByBoxInfo></LocalizableData>"
        Me.grdRetorno.ColumnAutoResize = True
        grdRetorno_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdRetorno_DesignTimeLayout_Reference_0.Instance"), Object)
        grdRetorno_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdRetorno_DesignTimeLayout_Reference_0})
        grdRetorno_DesignTimeLayout.LayoutString = resources.GetString("grdRetorno_DesignTimeLayout.LayoutString")
        Me.grdRetorno.DesignTimeLayout = grdRetorno_DesignTimeLayout
        Me.grdRetorno.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdRetorno.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdRetorno.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdRetorno.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdRetorno.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdRetorno.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdRetorno.FrozenColumns = 1
        Me.grdRetorno.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdRetorno.GroupByBoxVisible = False
        Me.grdRetorno.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdRetorno.Location = New System.Drawing.Point(8, 76)
        Me.grdRetorno.Name = "grdRetorno"
        Me.grdRetorno.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdRetorno.RecordNavigator = True
        Me.grdRetorno.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdRetorno.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdRetorno.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdRetorno.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdRetorno.Size = New System.Drawing.Size(938, 404)
        Me.grdRetorno.TabIndex = 1
        Me.grdRetorno.TabStop = False
        Me.grdRetorno.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdRetorno.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdRetorno.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdRetorno.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdRetorno.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'grpDadosArquivo
        '
        Me.grpDadosArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosArquivo.Controls.Add(Me.txtArquivoRetorno)
        Me.grpDadosArquivo.Controls.Add(Me.btnImportarRetorno)
        Me.grpDadosArquivo.Controls.Add(Me.lblArquivoRetorno)
        Me.grpDadosArquivo.Controls.Add(Me.lblContaBancariaRetorno)
        Me.grpDadosArquivo.Controls.Add(Me.cboBancoContaRetorno)
        Me.grpDadosArquivo.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosArquivo.Name = "grpDadosArquivo"
        Me.grpDadosArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosArquivo.Size = New System.Drawing.Size(938, 64)
        Me.grpDadosArquivo.TabIndex = 0
        Me.grpDadosArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosArquivo.VisualStyleManager = Me.vsmMain
        '
        'txtArquivoRetorno
        '
        Me.txtArquivoRetorno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivoRetorno.BackColor = System.Drawing.SystemColors.Info
        Me.txtArquivoRetorno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivoRetorno.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArquivoRetorno.Location = New System.Drawing.Point(410, 34)
        Me.txtArquivoRetorno.MaxLength = 50
        Me.txtArquivoRetorno.Name = "txtArquivoRetorno"
        Me.txtArquivoRetorno.ReadOnly = True
        Me.txtArquivoRetorno.Size = New System.Drawing.Size(500, 20)
        Me.txtArquivoRetorno.TabIndex = 3
        Me.txtArquivoRetorno.TabStop = False
        '
        'btnImportarRetorno
        '
        Me.btnImportarRetorno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportarRetorno.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarRetorno.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnImportarRetorno.Location = New System.Drawing.Point(909, 34)
        Me.btnImportarRetorno.Name = "btnImportarRetorno"
        Me.btnImportarRetorno.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportarRetorno.Size = New System.Drawing.Size(20, 20)
        Me.btnImportarRetorno.TabIndex = 4
        Me.btnImportarRetorno.Text = "..."
        Me.btnImportarRetorno.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivoRetorno
        '
        Me.lblArquivoRetorno.AutoSize = True
        Me.lblArquivoRetorno.Location = New System.Drawing.Point(407, 17)
        Me.lblArquivoRetorno.Name = "lblArquivoRetorno"
        Me.lblArquivoRetorno.Size = New System.Drawing.Size(89, 14)
        Me.lblArquivoRetorno.TabIndex = 2
        Me.lblArquivoRetorno.Text = "Arquivo Retorno:"
        '
        'lblContaBancariaRetorno
        '
        Me.lblContaBancariaRetorno.AutoSize = True
        Me.lblContaBancariaRetorno.Location = New System.Drawing.Point(6, 17)
        Me.lblContaBancariaRetorno.Name = "lblContaBancariaRetorno"
        Me.lblContaBancariaRetorno.Size = New System.Drawing.Size(84, 14)
        Me.lblContaBancariaRetorno.TabIndex = 0
        Me.lblContaBancariaRetorno.Text = "Conta Bancária:"
        '
        'cboBancoContaRetorno
        '
        Me.cboBancoContaRetorno.AutoSize = False
        Me.cboBancoContaRetorno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboBancoContaRetorno.Location = New System.Drawing.Point(9, 34)
        Me.cboBancoContaRetorno.Name = "cboBancoContaRetorno"
        Me.cboBancoContaRetorno.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboBancoContaRetorno.Size = New System.Drawing.Size(395, 20)
        Me.cboBancoContaRetorno.TabIndex = 1
        '
        'pagPagamento
        '
        Me.pagPagamento.Controls.Add(Me.btnExcelGridPagamento)
        Me.pagPagamento.Controls.Add(Me.btnAgruparGridPagamento)
        Me.pagPagamento.Controls.Add(Me.btnConfigurarGridPagamento)
        Me.pagPagamento.Controls.Add(Me.UiGroupBox2)
        Me.pagPagamento.Controls.Add(Me.UiGroupBox1)
        Me.pagPagamento.Controls.Add(Me.grdPagamento)
        Me.pagPagamento.Location = New System.Drawing.Point(1, 22)
        Me.pagPagamento.Name = "pagPagamento"
        Me.pagPagamento.Size = New System.Drawing.Size(954, 543)
        Me.pagPagamento.TabStop = True
        Me.pagPagamento.Text = "Pagamento - Remessa"
        '
        'btnExcelGridPagamento
        '
        Me.btnExcelGridPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridPagamento.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridPagamento.FlatAppearance.BorderSize = 0
        Me.btnExcelGridPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridPagamento.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridPagamento.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGridPagamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridPagamento.Name = "btnExcelGridPagamento"
        Me.btnExcelGridPagamento.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridPagamento.TabIndex = 96
        Me.btnExcelGridPagamento.TabStop = False
        Me.btnExcelGridPagamento.UseVisualStyleBackColor = False
        '
        'btnAgruparGridPagamento
        '
        Me.btnAgruparGridPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridPagamento.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridPagamento.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridPagamento.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridPagamento.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGridPagamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridPagamento.Name = "btnAgruparGridPagamento"
        Me.btnAgruparGridPagamento.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridPagamento.TabIndex = 95
        Me.btnAgruparGridPagamento.TabStop = False
        Me.btnAgruparGridPagamento.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridPagamento
        '
        Me.btnConfigurarGridPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridPagamento.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridPagamento.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridPagamento.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridPagamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridPagamento.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGridPagamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridPagamento.Name = "btnConfigurarGridPagamento"
        Me.btnConfigurarGridPagamento.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridPagamento.TabIndex = 94
        Me.btnConfigurarGridPagamento.TabStop = False
        Me.btnConfigurarGridPagamento.UseVisualStyleBackColor = False
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.btnImportarExcelPagamento)
        Me.UiGroupBox2.Controls.Add(Me.UiButton3)
        Me.UiGroupBox2.Controls.Add(Me.btnGerarArquivoPagamento)
        Me.UiGroupBox2.Location = New System.Drawing.Point(8, 483)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.Size = New System.Drawing.Size(938, 51)
        Me.UiGroupBox2.TabIndex = 4
        Me.UiGroupBox2.VisualStyleManager = Me.vsmMain
        '
        'btnImportarExcelPagamento
        '
        Me.btnImportarExcelPagamento.Image = Global.INTERACTI.My.Resources.Resources.upload
        Me.btnImportarExcelPagamento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarExcelPagamento.Location = New System.Drawing.Point(9, 17)
        Me.btnImportarExcelPagamento.Name = "btnImportarExcelPagamento"
        Me.btnImportarExcelPagamento.Size = New System.Drawing.Size(137, 23)
        Me.btnImportarExcelPagamento.TabIndex = 3
        Me.btnImportarExcelPagamento.Text = "Importar Excel"
        Me.btnImportarExcelPagamento.Visible = False
        Me.btnImportarExcelPagamento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'UiButton3
        '
        Me.UiButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiButton3.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.UiButton3.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.UiButton3.ImageSize = New System.Drawing.Size(19, 16)
        Me.UiButton3.Location = New System.Drawing.Point(838, 17)
        Me.UiButton3.Name = "UiButton3"
        Me.UiButton3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiButton3.Size = New System.Drawing.Size(91, 23)
        Me.UiButton3.TabIndex = 2
        Me.UiButton3.Text = "Sair"
        Me.UiButton3.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnGerarArquivoPagamento
        '
        Me.btnGerarArquivoPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGerarArquivoPagamento.Image = Global.INTERACTI.My.Resources.Resources.download
        Me.btnGerarArquivoPagamento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarArquivoPagamento.Location = New System.Drawing.Point(695, 17)
        Me.btnGerarArquivoPagamento.Name = "btnGerarArquivoPagamento"
        Me.btnGerarArquivoPagamento.Size = New System.Drawing.Size(137, 23)
        Me.btnGerarArquivoPagamento.TabIndex = 1
        Me.btnGerarArquivoPagamento.Text = "Gerar Arquivo"
        Me.btnGerarArquivoPagamento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.lblFormaLancamento)
        Me.UiGroupBox1.Controls.Add(Me.cboFormaLancamento)
        Me.UiGroupBox1.Controls.Add(Me.lblTipoServico)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataEmissaoPagamentoInicioFiltro)
        Me.UiGroupBox1.Controls.Add(Me.cboTipoServico)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataEmissaoPagamentoTerminoFiltro)
        Me.UiGroupBox1.Controls.Add(Me.lblDataEmissaoPagamentoFiltro)
        Me.UiGroupBox1.Controls.Add(Me.btnFiltrarPagamento)
        Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(938, 64)
        Me.UiGroupBox1.TabIndex = 1
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'dtpDataEmissaoPagamentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoPagamentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoPagamentoInicioFiltro.Location = New System.Drawing.Point(9, 34)
        Me.dtpDataEmissaoPagamentoInicioFiltro.Name = "dtpDataEmissaoPagamentoInicioFiltro"
        Me.dtpDataEmissaoPagamentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoPagamentoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoPagamentoInicioFiltro.TabIndex = 7
        Me.dtpDataEmissaoPagamentoInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataEmissaoPagamentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoPagamentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoPagamentoTerminoFiltro.Location = New System.Drawing.Point(123, 34)
        Me.dtpDataEmissaoPagamentoTerminoFiltro.Name = "dtpDataEmissaoPagamentoTerminoFiltro"
        Me.dtpDataEmissaoPagamentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoPagamentoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoPagamentoTerminoFiltro.TabIndex = 8
        Me.dtpDataEmissaoPagamentoTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataEmissaoPagamentoFiltro
        '
        Me.lblDataEmissaoPagamentoFiltro.AutoSize = True
        Me.lblDataEmissaoPagamentoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblDataEmissaoPagamentoFiltro.Name = "lblDataEmissaoPagamentoFiltro"
        Me.lblDataEmissaoPagamentoFiltro.Size = New System.Drawing.Size(90, 14)
        Me.lblDataEmissaoPagamentoFiltro.TabIndex = 6
        Me.lblDataEmissaoPagamentoFiltro.Text = "Data de Emissão:"
        '
        'btnFiltrarPagamento
        '
        Me.btnFiltrarPagamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrarPagamento.Image = CType(resources.GetObject("btnFiltrarPagamento.Image"), System.Drawing.Image)
        Me.btnFiltrarPagamento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrarPagamento.Location = New System.Drawing.Point(838, 31)
        Me.btnFiltrarPagamento.Name = "btnFiltrarPagamento"
        Me.btnFiltrarPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrarPagamento.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrarPagamento.TabIndex = 5
        Me.btnFiltrarPagamento.Text = "Filtrar"
        Me.btnFiltrarPagamento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdPagamento
        '
        Me.grdPagamento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdPagamento.AlternatingColors = True
        Me.grdPagamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPagamento.ColumnAutoResize = True
        grdPagamento_DesignTimeLayout.LayoutString = resources.GetString("grdPagamento_DesignTimeLayout.LayoutString")
        Me.grdPagamento.DesignTimeLayout = grdPagamento_DesignTimeLayout
        Me.grdPagamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPagamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPagamento.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdPagamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPagamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPagamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPagamento.GroupByBoxVisible = False
        Me.grdPagamento.Location = New System.Drawing.Point(8, 76)
        Me.grdPagamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdPagamento.Name = "grdPagamento"
        Me.grdPagamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPagamento.RecordNavigator = True
        Me.grdPagamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdPagamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPagamento.Size = New System.Drawing.Size(938, 404)
        Me.grdPagamento.TabIndex = 2
        Me.grdPagamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPagamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPagamento.VisualStyleManager = Me.vsmMain
        '
        'lblTipoServico
        '
        Me.lblTipoServico.AutoSize = True
        Me.lblTipoServico.Location = New System.Drawing.Point(234, 17)
        Me.lblTipoServico.Name = "lblTipoServico"
        Me.lblTipoServico.Size = New System.Drawing.Size(85, 14)
        Me.lblTipoServico.TabIndex = 5
        Me.lblTipoServico.Text = "Tipo do Serviço:"
        '
        'cboTipoServico
        '
        Me.cboTipoServico.AutoSize = False
        Me.cboTipoServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoServico.Location = New System.Drawing.Point(237, 34)
        Me.cboTipoServico.Name = "cboTipoServico"
        Me.cboTipoServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoServico.Size = New System.Drawing.Size(183, 20)
        Me.cboTipoServico.TabIndex = 6
        '
        'lblFormaLancamento
        '
        Me.lblFormaLancamento.AutoSize = True
        Me.lblFormaLancamento.Location = New System.Drawing.Point(423, 17)
        Me.lblFormaLancamento.Name = "lblFormaLancamento"
        Me.lblFormaLancamento.Size = New System.Drawing.Size(117, 14)
        Me.lblFormaLancamento.TabIndex = 9
        Me.lblFormaLancamento.Text = "Forma de Lançamento:"
        '
        'cboFormaLancamento
        '
        Me.cboFormaLancamento.AutoSize = False
        Me.cboFormaLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFormaLancamento.Location = New System.Drawing.Point(426, 34)
        Me.cboFormaLancamento.Name = "cboFormaLancamento"
        Me.cboFormaLancamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFormaLancamento.Size = New System.Drawing.Size(183, 20)
        Me.cboFormaLancamento.TabIndex = 10
        '
        'usrIntConciliacaoBancaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrIntConciliacaoBancaria"
        Me.Size = New System.Drawing.Size(956, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagRemessa.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaGeradoArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRemessa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltros.ResumeLayout(False)
        Me.grpFiltros.PerformLayout()
        CType(Me.grpControleRemessa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleRemessa.ResumeLayout(False)
        Me.pagRetorno.ResumeLayout(False)
        CType(Me.grpLegendaRetorno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegendaRetorno.ResumeLayout(False)
        Me.grpLegendaRetorno.PerformLayout()
        CType(Me.picLegendaBoletoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaBoletoRejeitado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaBoletoAberto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControleRetorno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleRetorno.ResumeLayout(False)
        CType(Me.grdRetorno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDadosArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosArquivo.ResumeLayout(False)
        Me.grpDadosArquivo.PerformLayout()
        Me.pagPagamento.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grdPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagRemessa As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControleRemessa As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnGerarArquivoRemessa As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltros As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataEmissaoRemessaFiltro As System.Windows.Forms.Label
    Friend WithEvents btnSairRemessa As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdRemessa As Janus.Windows.GridEX.GridEX
    Friend WithEvents dtpDataEmissaoRemessaInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoRemessaTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnFiltrarRemessa As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblBancoContaRemessa As System.Windows.Forms.Label
    Friend WithEvents cboBancoContaRemessa As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnConfigurarGridRemessa As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridRemessa As System.Windows.Forms.Button
    Friend WithEvents pagRetorno As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDadosArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtArquivoRetorno As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Private WithEvents btnImportarRetorno As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivoRetorno As System.Windows.Forms.Label
    Friend WithEvents grpControleRetorno As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSalvarRetorno As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSairRetorno As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdRetorno As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblContaBancariaRetorno As System.Windows.Forms.Label
    Friend WithEvents cboBancoContaRetorno As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnNovoRetorno As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpLegendaRetorno As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaBoletoPago As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaBoletoPago As System.Windows.Forms.Label
    Friend WithEvents picLegendaBoletoRejeitado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaBoletoAberto As System.Windows.Forms.Label
    Friend WithEvents lblLegendaBoletoRejeitado As System.Windows.Forms.Label
    Friend WithEvents picLegendaBoletoAberto As System.Windows.Forms.PictureBox
    Friend WithEvents btnExcelGridRemessa As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridRetorno As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaGeradoArquivo As System.Windows.Forms.Label
    Friend WithEvents picLegendaGeradoArquivo As System.Windows.Forms.PictureBox
    Friend WithEvents pagPagamento As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiButton3 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnGerarArquivoPagamento As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrarPagamento As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnImportarExcelPagamento As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataEmissaoPagamentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoPagamentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEmissaoPagamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnExcelGridPagamento As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridPagamento As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridPagamento As System.Windows.Forms.Button
    Friend WithEvents grdPagamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblTipoServico As System.Windows.Forms.Label
    Friend WithEvents cboTipoServico As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFormaLancamento As System.Windows.Forms.Label
    Friend WithEvents cboFormaLancamento As Janus.Windows.EditControls.UIComboBox

End Class
