<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFat000000024
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFat000000024))
        Dim grdDuplicata_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdServico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdServico_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdArquivos_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdArquivos_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdArquivos_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdEvento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdEvento_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim GridEX2_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX2_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridListagem = New System.Windows.Forms.Button()
        Me.btnAgruparGridListagem = New System.Windows.Forms.Button()
        Me.btnConfigurarGridListagem = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExportarExcel = New Janus.Windows.EditControls.UIButton()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.grpDuplicata = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboCondicaoPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCondicaoPagamento = New System.Windows.Forms.Label()
        Me.cboFormaPagamento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFormaPagamento = New System.Windows.Forms.Label()
        Me.btnCalcularDuplicata = New Janus.Windows.EditControls.UIButton()
        Me.txtIntervaloParcela = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblIntervaloParcela = New System.Windows.Forms.Label()
        Me.txtNumeroParcela = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroParcela = New System.Windows.Forms.Label()
        Me.grdDuplicata = New Janus.Windows.GridEX.GridEX()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkConsolidacao = New Janus.Windows.EditControls.UICheckBox()
        Me.btnEventoMultiplo = New System.Windows.Forms.Button()
        Me.chkAta = New Janus.Windows.EditControls.UICheckBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtpDataRetornoRevisao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpDataEnvioRevisao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCobrancaAssinatura = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtpDataEnvioDepartamentos = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtpDataEnvioCliente = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtpDataDigitalizacao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtpDataRetornoRegistro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpDataEntradaRegistro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpDataRetornoAssinatura = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpDataEnvioAssinatura = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpDataFinalizado = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpDataSolicitacao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtEventoConteudo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObjetivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtInscricaoINSS = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.chkOutros = New Janus.Windows.EditControls.UICheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPIS = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.chkCopia = New Janus.Windows.EditControls.UICheckBox()
        Me.dtpDataAguardar = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpData = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.chkAguardarAte = New Janus.Windows.EditControls.UICheckBox()
        Me.chkBuscaremos = New Janus.Windows.EditControls.UICheckBox()
        Me.chkDeixara = New Janus.Windows.EditControls.UICheckBox()
        Me.chkCND = New Janus.Windows.EditControls.UICheckBox()
        Me.chkDeixou = New Janus.Windows.EditControls.UICheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkAlteracao = New Janus.Windows.EditControls.UICheckBox()
        Me.txtDocumentosNecessarios = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtFuncionarioAtendente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.chkBaixa = New Janus.Windows.EditControls.UICheckBox()
        Me.lblDescricaoProduto = New System.Windows.Forms.Label()
        Me.chkAbertura = New Janus.Windows.EditControls.UICheckBox()
        Me.txtObservacaoOS = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblObjetivo = New System.Windows.Forms.Label()
        Me.grdServico = New Janus.Windows.GridEX.GridEX()
        Me.grpServico = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtValorTotalServico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtObservacaoServico = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboServico = New Janus.Windows.EditControls.UIComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExcluirServico = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirServico = New Janus.Windows.EditControls.UIButton()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluirArquivos = New Janus.Windows.EditControls.UIButton()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDocumento = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton()
        Me.txtArquivos = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblArquivos = New System.Windows.Forms.Label()
        Me.btnVisualizarArquivo = New Janus.Windows.EditControls.UIButton()
        Me.grdArquivos = New Janus.Windows.GridEX.GridEX()
        Me.grdEvento = New Janus.Windows.GridEX.GridEX()
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtObservacaoEvento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboEvento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblEvento = New System.Windows.Forms.Label()
        Me.btnExcluirEvento = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirEvento = New Janus.Windows.EditControls.UIButton()
        Me.pagProduto = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiComboBox3 = New Janus.Windows.EditControls.UIComboBox()
        Me.UiGroupBox6 = New Janus.Windows.EditControls.UIGroupBox()
        Me.GridEX2 = New Janus.Windows.GridEX.GridEX()
        Me.btnExcelGridServico = New System.Windows.Forms.Button()
        Me.btnAgruparGridServico = New System.Windows.Forms.Button()
        Me.btnConfigurarGridServico = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.chkDetalhado = New Janus.Windows.EditControls.UICheckBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpDuplicata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDuplicata.SuspendLayout()
        CType(Me.grdDuplicata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdServico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpServico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpServico.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.grdArquivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEvento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.UiGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox6.SuspendLayout()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.btnExcelGridListagem)
        Me.pagLista.Controls.Add(Me.btnAgruparGridListagem)
        Me.pagLista.Controls.Add(Me.btnConfigurarGridListagem)
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório Faturamento - FAT000000024"
        '
        'btnExcelGridListagem
        '
        Me.btnExcelGridListagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridListagem.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridListagem.FlatAppearance.BorderSize = 0
        Me.btnExcelGridListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridListagem.Image = CType(resources.GetObject("btnExcelGridListagem.Image"), System.Drawing.Image)
        Me.btnExcelGridListagem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridListagem.Location = New System.Drawing.Point(57, 460)
        Me.btnExcelGridListagem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridListagem.Name = "btnExcelGridListagem"
        Me.btnExcelGridListagem.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridListagem.TabIndex = 4
        Me.btnExcelGridListagem.TabStop = False
        Me.btnExcelGridListagem.UseVisualStyleBackColor = False
        '
        'btnAgruparGridListagem
        '
        Me.btnAgruparGridListagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridListagem.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridListagem.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridListagem.Image = CType(resources.GetObject("btnAgruparGridListagem.Image"), System.Drawing.Image)
        Me.btnAgruparGridListagem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridListagem.Location = New System.Drawing.Point(33, 460)
        Me.btnAgruparGridListagem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridListagem.Name = "btnAgruparGridListagem"
        Me.btnAgruparGridListagem.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridListagem.TabIndex = 3
        Me.btnAgruparGridListagem.TabStop = False
        Me.btnAgruparGridListagem.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridListagem
        '
        Me.btnConfigurarGridListagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridListagem.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridListagem.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridListagem.Image = CType(resources.GetObject("btnConfigurarGridListagem.Image"), System.Drawing.Image)
        Me.btnConfigurarGridListagem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridListagem.Location = New System.Drawing.Point(9, 460)
        Me.btnConfigurarGridListagem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridListagem.Name = "btnConfigurarGridListagem"
        Me.btnConfigurarGridListagem.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridListagem.TabIndex = 2
        Me.btnConfigurarGridListagem.TabStop = False
        Me.btnConfigurarGridListagem.UseVisualStyleBackColor = False
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
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 79)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 397)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(37, 353)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 3
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(13, 353)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnExportarExcel)
        Me.grpControl.Controls.Add(Me.lblCongelarColuna)
        Me.grpControl.Controls.Add(Me.cboCongelarColuna)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(982, 51)
        Me.grpControl.TabIndex = 5
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportarExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExportarExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExportarExcel.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnExportarExcel.Location = New System.Drawing.Point(693, 17)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExportarExcel.Size = New System.Drawing.Size(183, 23)
        Me.btnExportarExcel.TabIndex = 2
        Me.btnExportarExcel.Text = "Exportar Excel"
        Me.btnExportarExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(7, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 0
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(102, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 1
        Me.cboCongelarColuna.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(882, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
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
        Me.grpFiltro.Controls.Add(Me.chkDetalhado)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 70)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
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
        Me.btnFiltrar.TabIndex = 3
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'dtpDataEmissaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(126, 37)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 2
        '
        'dtpDataEmissaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(12, 37)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 1
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(9, 20)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 0
        Me.lblDataEmissaoFiltro.Text = "Data:"
        '
        'grpDuplicata
        '
        Me.grpDuplicata.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDuplicata.BackColor = System.Drawing.Color.Transparent
        Me.grpDuplicata.Controls.Add(Me.cboCondicaoPagamento)
        Me.grpDuplicata.Controls.Add(Me.lblCondicaoPagamento)
        Me.grpDuplicata.Controls.Add(Me.cboFormaPagamento)
        Me.grpDuplicata.Controls.Add(Me.lblFormaPagamento)
        Me.grpDuplicata.Controls.Add(Me.btnCalcularDuplicata)
        Me.grpDuplicata.Controls.Add(Me.txtIntervaloParcela)
        Me.grpDuplicata.Controls.Add(Me.lblIntervaloParcela)
        Me.grpDuplicata.Controls.Add(Me.txtNumeroParcela)
        Me.grpDuplicata.Controls.Add(Me.lblNumeroParcela)
        Me.grpDuplicata.Controls.Add(Me.grdDuplicata)
        Me.grpDuplicata.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDuplicata.Location = New System.Drawing.Point(977, 3)
        Me.grpDuplicata.Name = "grpDuplicata"
        Me.grpDuplicata.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDuplicata.Size = New System.Drawing.Size(251, 385)
        Me.grpDuplicata.TabIndex = 3
        Me.grpDuplicata.Text = "Duplicata"
        Me.grpDuplicata.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDuplicata.VisualStyleManager = Me.vsmMain
        '
        'cboCondicaoPagamento
        '
        Me.cboCondicaoPagamento.AutoSize = False
        Me.cboCondicaoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCondicaoPagamento.Location = New System.Drawing.Point(9, 80)
        Me.cboCondicaoPagamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCondicaoPagamento.Name = "cboCondicaoPagamento"
        Me.cboCondicaoPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCondicaoPagamento.Size = New System.Drawing.Size(233, 20)
        Me.cboCondicaoPagamento.TabIndex = 68
        '
        'lblCondicaoPagamento
        '
        Me.lblCondicaoPagamento.AutoSize = True
        Me.lblCondicaoPagamento.Location = New System.Drawing.Point(6, 62)
        Me.lblCondicaoPagamento.Name = "lblCondicaoPagamento"
        Me.lblCondicaoPagamento.Size = New System.Drawing.Size(127, 13)
        Me.lblCondicaoPagamento.TabIndex = 67
        Me.lblCondicaoPagamento.Text = "Condição de Pagamento:"
        '
        'cboFormaPagamento
        '
        Me.cboFormaPagamento.AutoSize = False
        Me.cboFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFormaPagamento.Location = New System.Drawing.Point(9, 36)
        Me.cboFormaPagamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboFormaPagamento.Name = "cboFormaPagamento"
        Me.cboFormaPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFormaPagamento.Size = New System.Drawing.Size(233, 20)
        Me.cboFormaPagamento.TabIndex = 66
        '
        'lblFormaPagamento
        '
        Me.lblFormaPagamento.AutoSize = True
        Me.lblFormaPagamento.Location = New System.Drawing.Point(6, 19)
        Me.lblFormaPagamento.Name = "lblFormaPagamento"
        Me.lblFormaPagamento.Size = New System.Drawing.Size(111, 13)
        Me.lblFormaPagamento.TabIndex = 65
        Me.lblFormaPagamento.Text = "Forma de Pagamento:"
        '
        'btnCalcularDuplicata
        '
        Me.btnCalcularDuplicata.Image = Global.INTERACTI.My.Resources.Resources.calculadora
        Me.btnCalcularDuplicata.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCalcularDuplicata.Location = New System.Drawing.Point(151, 159)
        Me.btnCalcularDuplicata.Name = "btnCalcularDuplicata"
        Me.btnCalcularDuplicata.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCalcularDuplicata.Size = New System.Drawing.Size(91, 23)
        Me.btnCalcularDuplicata.TabIndex = 6
        Me.btnCalcularDuplicata.Text = "Calcular"
        Me.btnCalcularDuplicata.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtIntervaloParcela
        '
        Me.txtIntervaloParcela.DecimalDigits = 0
        Me.txtIntervaloParcela.Location = New System.Drawing.Point(9, 161)
        Me.txtIntervaloParcela.Name = "txtIntervaloParcela"
        Me.txtIntervaloParcela.Size = New System.Drawing.Size(108, 20)
        Me.txtIntervaloParcela.TabIndex = 5
        Me.txtIntervaloParcela.Text = "0"
        Me.txtIntervaloParcela.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblIntervaloParcela
        '
        Me.lblIntervaloParcela.AutoSize = True
        Me.lblIntervaloParcela.Location = New System.Drawing.Point(6, 144)
        Me.lblIntervaloParcela.Name = "lblIntervaloParcela"
        Me.lblIntervaloParcela.Size = New System.Drawing.Size(96, 13)
        Me.lblIntervaloParcela.TabIndex = 4
        Me.lblIntervaloParcela.Text = "Int. entre Parcelas:"
        '
        'txtNumeroParcela
        '
        Me.txtNumeroParcela.DecimalDigits = 0
        Me.txtNumeroParcela.Location = New System.Drawing.Point(9, 121)
        Me.txtNumeroParcela.Name = "txtNumeroParcela"
        Me.txtNumeroParcela.Size = New System.Drawing.Size(108, 20)
        Me.txtNumeroParcela.TabIndex = 3
        Me.txtNumeroParcela.Text = "0"
        Me.txtNumeroParcela.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumeroParcela
        '
        Me.lblNumeroParcela.AutoSize = True
        Me.lblNumeroParcela.Location = New System.Drawing.Point(6, 104)
        Me.lblNumeroParcela.Name = "lblNumeroParcela"
        Me.lblNumeroParcela.Size = New System.Drawing.Size(66, 13)
        Me.lblNumeroParcela.TabIndex = 2
        Me.lblNumeroParcela.Text = "Nº Parcelas:"
        '
        'grdDuplicata
        '
        Me.grdDuplicata.AlternatingColors = True
        Me.grdDuplicata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDuplicata.CellToolTipText = "Duplo Clique para editar o Registro"
        grdDuplicata_DesignTimeLayout.LayoutString = resources.GetString("grdDuplicata_DesignTimeLayout.LayoutString")
        Me.grdDuplicata.DesignTimeLayout = grdDuplicata_DesignTimeLayout
        Me.grdDuplicata.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdDuplicata.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdDuplicata.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdDuplicata.GroupByBoxVisible = False
        Me.grdDuplicata.Location = New System.Drawing.Point(9, 193)
        Me.grdDuplicata.Name = "grdDuplicata"
        Me.grdDuplicata.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdDuplicata.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdDuplicata.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdDuplicata.Size = New System.Drawing.Size(233, 182)
        Me.grdDuplicata.TabIndex = 7
        Me.grdDuplicata.TabStop = False
        Me.grdDuplicata.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdDuplicata.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdDuplicata.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdDuplicata.VisualStyleManager = Me.vsmMain
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.chkConsolidacao)
        Me.UiGroupBox1.Controls.Add(Me.btnEventoMultiplo)
        Me.UiGroupBox1.Controls.Add(Me.chkAta)
        Me.UiGroupBox1.Controls.Add(Me.Label26)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataRetornoRevisao)
        Me.UiGroupBox1.Controls.Add(Me.Label25)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataEnvioRevisao)
        Me.UiGroupBox1.Controls.Add(Me.Label21)
        Me.UiGroupBox1.Controls.Add(Me.txtCobrancaAssinatura)
        Me.UiGroupBox1.Controls.Add(Me.Label20)
        Me.UiGroupBox1.Controls.Add(Me.Label18)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataEnvioDepartamentos)
        Me.UiGroupBox1.Controls.Add(Me.Label19)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataEnvioCliente)
        Me.UiGroupBox1.Controls.Add(Me.Label17)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataDigitalizacao)
        Me.UiGroupBox1.Controls.Add(Me.Label16)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataRetornoRegistro)
        Me.UiGroupBox1.Controls.Add(Me.Label15)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataEntradaRegistro)
        Me.UiGroupBox1.Controls.Add(Me.Label14)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataRetornoAssinatura)
        Me.UiGroupBox1.Controls.Add(Me.Label13)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataEnvioAssinatura)
        Me.UiGroupBox1.Controls.Add(Me.Label12)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataFinalizado)
        Me.UiGroupBox1.Controls.Add(Me.Label11)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataSolicitacao)
        Me.UiGroupBox1.Controls.Add(Me.txtEventoConteudo)
        Me.UiGroupBox1.Controls.Add(Me.Label4)
        Me.UiGroupBox1.Controls.Add(Me.txtObjetivo)
        Me.UiGroupBox1.Controls.Add(Me.Label8)
        Me.UiGroupBox1.Controls.Add(Me.txtInscricaoINSS)
        Me.UiGroupBox1.Controls.Add(Me.chkOutros)
        Me.UiGroupBox1.Controls.Add(Me.Label7)
        Me.UiGroupBox1.Controls.Add(Me.txtPIS)
        Me.UiGroupBox1.Controls.Add(Me.chkCopia)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataAguardar)
        Me.UiGroupBox1.Controls.Add(Me.dtpData)
        Me.UiGroupBox1.Controls.Add(Me.chkAguardarAte)
        Me.UiGroupBox1.Controls.Add(Me.chkBuscaremos)
        Me.UiGroupBox1.Controls.Add(Me.chkDeixara)
        Me.UiGroupBox1.Controls.Add(Me.chkCND)
        Me.UiGroupBox1.Controls.Add(Me.chkDeixou)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.Label5)
        Me.UiGroupBox1.Controls.Add(Me.chkAlteracao)
        Me.UiGroupBox1.Controls.Add(Me.txtDocumentosNecessarios)
        Me.UiGroupBox1.Controls.Add(Me.txtFuncionarioAtendente)
        Me.UiGroupBox1.Controls.Add(Me.chkBaixa)
        Me.UiGroupBox1.Controls.Add(Me.lblDescricaoProduto)
        Me.UiGroupBox1.Controls.Add(Me.chkAbertura)
        Me.UiGroupBox1.Controls.Add(Me.txtObservacaoOS)
        Me.UiGroupBox1.Controls.Add(Me.lblObjetivo)
        Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox1.Location = New System.Drawing.Point(9, 3)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(962, 385)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.Text = "Dados"
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'chkConsolidacao
        '
        Me.chkConsolidacao.Location = New System.Drawing.Point(363, 62)
        Me.chkConsolidacao.Name = "chkConsolidacao"
        Me.chkConsolidacao.Size = New System.Drawing.Size(95, 25)
        Me.chkConsolidacao.TabIndex = 59
        Me.chkConsolidacao.Text = "Consolidação"
        '
        'btnEventoMultiplo
        '
        Me.btnEventoMultiplo.FlatAppearance.BorderSize = 0
        Me.btnEventoMultiplo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEventoMultiplo.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnEventoMultiplo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEventoMultiplo.Location = New System.Drawing.Point(418, 92)
        Me.btnEventoMultiplo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEventoMultiplo.Name = "btnEventoMultiplo"
        Me.btnEventoMultiplo.Size = New System.Drawing.Size(13, 13)
        Me.btnEventoMultiplo.TabIndex = 19
        Me.btnEventoMultiplo.TabStop = False
        Me.btnEventoMultiplo.UseVisualStyleBackColor = True
        '
        'chkAta
        '
        Me.chkAta.Location = New System.Drawing.Point(158, 62)
        Me.chkAta.Name = "chkAta"
        Me.chkAta.Size = New System.Drawing.Size(39, 25)
        Me.chkAta.TabIndex = 12
        Me.chkAta.Text = "Ata"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(336, 133)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(98, 13)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = "Data Ret. Revisão:"
        '
        'dtpDataRetornoRevisao
        '
        Me.dtpDataRetornoRevisao.Checked = False
        '
        '
        '
        Me.dtpDataRetornoRevisao.DropDownCalendar.Name = ""
        Me.dtpDataRetornoRevisao.Location = New System.Drawing.Point(338, 150)
        Me.dtpDataRetornoRevisao.Name = "dtpDataRetornoRevisao"
        Me.dtpDataRetornoRevisao.ShowCheckBox = True
        Me.dtpDataRetornoRevisao.Size = New System.Drawing.Size(101, 20)
        Me.dtpDataRetornoRevisao.TabIndex = 29
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(226, 133)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(100, 13)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = "Data Env. Revisão:"
        '
        'dtpDataEnvioRevisao
        '
        Me.dtpDataEnvioRevisao.Checked = False
        '
        '
        '
        Me.dtpDataEnvioRevisao.DropDownCalendar.Name = ""
        Me.dtpDataEnvioRevisao.Location = New System.Drawing.Point(228, 150)
        Me.dtpDataEnvioRevisao.Name = "dtpDataEnvioRevisao"
        Me.dtpDataEnvioRevisao.ShowCheckBox = True
        Me.dtpDataEnvioRevisao.Size = New System.Drawing.Size(104, 20)
        Me.dtpDataEnvioRevisao.TabIndex = 27
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(565, 133)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(128, 13)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Cobranças da Assinatura:"
        '
        'txtCobrancaAssinatura
        '
        Me.txtCobrancaAssinatura.BackColor = System.Drawing.Color.White
        Me.txtCobrancaAssinatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCobrancaAssinatura.Location = New System.Drawing.Point(569, 150)
        Me.txtCobrancaAssinatura.MaxLength = 60
        Me.txtCobrancaAssinatura.Name = "txtCobrancaAssinatura"
        Me.txtCobrancaAssinatura.Size = New System.Drawing.Size(184, 20)
        Me.txtCobrancaAssinatura.TabIndex = 33
        Me.txtCobrancaAssinatura.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 297)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 13)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "Observação:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(443, 176)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 13)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Data Envio Dptos.:"
        '
        'dtpDataEnvioDepartamentos
        '
        Me.dtpDataEnvioDepartamentos.Checked = False
        '
        '
        '
        Me.dtpDataEnvioDepartamentos.DropDownCalendar.Name = ""
        Me.dtpDataEnvioDepartamentos.Location = New System.Drawing.Point(445, 193)
        Me.dtpDataEnvioDepartamentos.Name = "dtpDataEnvioDepartamentos"
        Me.dtpDataEnvioDepartamentos.ShowCheckBox = True
        Me.dtpDataEnvioDepartamentos.Size = New System.Drawing.Size(118, 20)
        Me.dtpDataEnvioDepartamentos.TabIndex = 45
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(336, 176)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 13)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Data Envio Cliente:"
        '
        'dtpDataEnvioCliente
        '
        Me.dtpDataEnvioCliente.Checked = False
        '
        '
        '
        Me.dtpDataEnvioCliente.DropDownCalendar.Name = ""
        Me.dtpDataEnvioCliente.Location = New System.Drawing.Point(338, 193)
        Me.dtpDataEnvioCliente.Name = "dtpDataEnvioCliente"
        Me.dtpDataEnvioCliente.ShowCheckBox = True
        Me.dtpDataEnvioCliente.Size = New System.Drawing.Size(101, 20)
        Me.dtpDataEnvioCliente.TabIndex = 43
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(226, 176)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 13)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Data Digitalização:"
        '
        'dtpDataDigitalizacao
        '
        Me.dtpDataDigitalizacao.Checked = False
        '
        '
        '
        Me.dtpDataDigitalizacao.DropDownCalendar.Name = ""
        Me.dtpDataDigitalizacao.Location = New System.Drawing.Point(228, 193)
        Me.dtpDataDigitalizacao.Name = "dtpDataDigitalizacao"
        Me.dtpDataDigitalizacao.ShowCheckBox = True
        Me.dtpDataDigitalizacao.Size = New System.Drawing.Size(104, 20)
        Me.dtpDataDigitalizacao.TabIndex = 41
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(118, 176)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Data Ret. Registro:"
        '
        'dtpDataRetornoRegistro
        '
        Me.dtpDataRetornoRegistro.Checked = False
        '
        '
        '
        Me.dtpDataRetornoRegistro.DropDownCalendar.Name = ""
        Me.dtpDataRetornoRegistro.Location = New System.Drawing.Point(120, 193)
        Me.dtpDataRetornoRegistro.Name = "dtpDataRetornoRegistro"
        Me.dtpDataRetornoRegistro.ShowCheckBox = True
        Me.dtpDataRetornoRegistro.Size = New System.Drawing.Size(102, 20)
        Me.dtpDataRetornoRegistro.TabIndex = 39
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Data Ent. Registro:"
        '
        'dtpDataEntradaRegistro
        '
        Me.dtpDataEntradaRegistro.Checked = False
        '
        '
        '
        Me.dtpDataEntradaRegistro.DropDownCalendar.Name = ""
        Me.dtpDataEntradaRegistro.Location = New System.Drawing.Point(12, 193)
        Me.dtpDataEntradaRegistro.Name = "dtpDataEntradaRegistro"
        Me.dtpDataEntradaRegistro.ShowCheckBox = True
        Me.dtpDataEntradaRegistro.Size = New System.Drawing.Size(102, 20)
        Me.dtpDataEntradaRegistro.TabIndex = 37
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(757, 132)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Data Ret. Assinatura:"
        '
        'dtpDataRetornoAssinatura
        '
        Me.dtpDataRetornoAssinatura.Checked = False
        '
        '
        '
        Me.dtpDataRetornoAssinatura.DropDownCalendar.Name = ""
        Me.dtpDataRetornoAssinatura.Location = New System.Drawing.Point(759, 149)
        Me.dtpDataRetornoAssinatura.Name = "dtpDataRetornoAssinatura"
        Me.dtpDataRetornoAssinatura.ShowCheckBox = True
        Me.dtpDataRetornoAssinatura.Size = New System.Drawing.Size(110, 20)
        Me.dtpDataRetornoAssinatura.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(442, 133)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Data Env. Assinatura:"
        '
        'dtpDataEnvioAssinatura
        '
        Me.dtpDataEnvioAssinatura.Checked = False
        '
        '
        '
        Me.dtpDataEnvioAssinatura.DropDownCalendar.Name = ""
        Me.dtpDataEnvioAssinatura.Location = New System.Drawing.Point(444, 150)
        Me.dtpDataEnvioAssinatura.Name = "dtpDataEnvioAssinatura"
        Me.dtpDataEnvioAssinatura.ShowCheckBox = True
        Me.dtpDataEnvioAssinatura.Size = New System.Drawing.Size(119, 20)
        Me.dtpDataEnvioAssinatura.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(118, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Data Finalização:"
        '
        'dtpDataFinalizado
        '
        Me.dtpDataFinalizado.Checked = False
        '
        '
        '
        Me.dtpDataFinalizado.DropDownCalendar.Name = ""
        Me.dtpDataFinalizado.Location = New System.Drawing.Point(120, 150)
        Me.dtpDataFinalizado.Name = "dtpDataFinalizado"
        Me.dtpDataFinalizado.ShowCheckBox = True
        Me.dtpDataFinalizado.Size = New System.Drawing.Size(102, 20)
        Me.dtpDataFinalizado.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Data Solicitação:"
        '
        'dtpDataSolicitacao
        '
        Me.dtpDataSolicitacao.Checked = False
        '
        '
        '
        Me.dtpDataSolicitacao.DropDownCalendar.Name = ""
        Me.dtpDataSolicitacao.Location = New System.Drawing.Point(12, 150)
        Me.dtpDataSolicitacao.Name = "dtpDataSolicitacao"
        Me.dtpDataSolicitacao.ShowCheckBox = True
        Me.dtpDataSolicitacao.Size = New System.Drawing.Size(102, 20)
        Me.dtpDataSolicitacao.TabIndex = 23
        '
        'txtEventoConteudo
        '
        Me.txtEventoConteudo.BackColor = System.Drawing.Color.White
        Me.txtEventoConteudo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEventoConteudo.Location = New System.Drawing.Point(417, 108)
        Me.txtEventoConteudo.MaxLength = 60
        Me.txtEventoConteudo.Name = "txtEventoConteudo"
        Me.txtEventoConteudo.Size = New System.Drawing.Size(449, 20)
        Me.txtEventoConteudo.TabIndex = 21
        Me.txtEventoConteudo.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(432, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Eventos/Conteúdo:"
        '
        'txtObjetivo
        '
        Me.txtObjetivo.BackColor = System.Drawing.Color.White
        Me.txtObjetivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObjetivo.Location = New System.Drawing.Point(11, 108)
        Me.txtObjetivo.MaxLength = 60
        Me.txtObjetivo.Name = "txtObjetivo"
        Me.txtObjetivo.Size = New System.Drawing.Size(400, 20)
        Me.txtObjetivo.TabIndex = 18
        Me.txtObjetivo.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(454, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Inscrição do INSS:"
        '
        'txtInscricaoINSS
        '
        Me.txtInscricaoINSS.BackColor = System.Drawing.Color.White
        Me.txtInscricaoINSS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInscricaoINSS.Location = New System.Drawing.Point(456, 275)
        Me.txtInscricaoINSS.MaxLength = 60
        Me.txtInscricaoINSS.Name = "txtInscricaoINSS"
        Me.txtInscricaoINSS.Size = New System.Drawing.Size(412, 20)
        Me.txtInscricaoINSS.TabIndex = 56
        Me.txtInscricaoINSS.TabStop = False
        '
        'chkOutros
        '
        Me.chkOutros.Location = New System.Drawing.Point(463, 62)
        Me.chkOutros.Name = "chkOutros"
        Me.chkOutros.Size = New System.Drawing.Size(68, 25)
        Me.chkOutros.TabIndex = 16
        Me.chkOutros.Text = "Outros"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "PIS:"
        '
        'txtPIS
        '
        Me.txtPIS.BackColor = System.Drawing.Color.White
        Me.txtPIS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPIS.Location = New System.Drawing.Point(12, 275)
        Me.txtPIS.MaxLength = 60
        Me.txtPIS.Name = "txtPIS"
        Me.txtPIS.Size = New System.Drawing.Size(438, 20)
        Me.txtPIS.TabIndex = 54
        Me.txtPIS.TabStop = False
        '
        'chkCopia
        '
        Me.chkCopia.Location = New System.Drawing.Point(255, 62)
        Me.chkCopia.Name = "chkCopia"
        Me.chkCopia.Size = New System.Drawing.Size(50, 25)
        Me.chkCopia.TabIndex = 14
        Me.chkCopia.Text = "Cópia"
        '
        'dtpDataAguardar
        '
        Me.dtpDataAguardar.Checked = False
        '
        '
        '
        Me.dtpDataAguardar.DropDownCalendar.Name = ""
        Me.dtpDataAguardar.Location = New System.Drawing.Point(766, 232)
        Me.dtpDataAguardar.Name = "dtpDataAguardar"
        Me.dtpDataAguardar.ShowCheckBox = True
        Me.dtpDataAguardar.Size = New System.Drawing.Size(102, 20)
        Me.dtpDataAguardar.TabIndex = 52
        '
        'dtpData
        '
        '
        '
        '
        Me.dtpData.DropDownCalendar.Name = ""
        Me.dtpData.Location = New System.Drawing.Point(311, 36)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(98, 20)
        Me.dtpData.TabIndex = 3
        '
        'chkAguardarAte
        '
        Me.chkAguardarAte.Location = New System.Drawing.Point(675, 230)
        Me.chkAguardarAte.Name = "chkAguardarAte"
        Me.chkAguardarAte.Size = New System.Drawing.Size(88, 25)
        Me.chkAguardarAte.TabIndex = 51
        Me.chkAguardarAte.Text = "Aguardar até:"
        '
        'chkBuscaremos
        '
        Me.chkBuscaremos.Location = New System.Drawing.Point(586, 230)
        Me.chkBuscaremos.Name = "chkBuscaremos"
        Me.chkBuscaremos.Size = New System.Drawing.Size(93, 25)
        Me.chkBuscaremos.TabIndex = 50
        Me.chkBuscaremos.Text = "Buscaremos"
        '
        'chkDeixara
        '
        Me.chkDeixara.Location = New System.Drawing.Point(520, 230)
        Me.chkDeixara.Name = "chkDeixara"
        Me.chkDeixara.Size = New System.Drawing.Size(68, 25)
        Me.chkDeixara.TabIndex = 49
        Me.chkDeixara.Text = "Deixará"
        '
        'chkCND
        '
        Me.chkCND.Location = New System.Drawing.Point(311, 62)
        Me.chkCND.Name = "chkCND"
        Me.chkCND.Size = New System.Drawing.Size(68, 25)
        Me.chkCND.TabIndex = 15
        Me.chkCND.Text = "CND"
        '
        'chkDeixou
        '
        Me.chkDeixou.Location = New System.Drawing.Point(457, 230)
        Me.chkDeixou.Name = "chkDeixou"
        Me.chkDeixou.Size = New System.Drawing.Size(68, 25)
        Me.chkDeixou.TabIndex = 48
        Me.chkDeixou.Text = "Deixou"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(311, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Data:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Documentos Necessários:"
        '
        'chkAlteracao
        '
        Me.chkAlteracao.Location = New System.Drawing.Point(80, 62)
        Me.chkAlteracao.Name = "chkAlteracao"
        Me.chkAlteracao.Size = New System.Drawing.Size(68, 25)
        Me.chkAlteracao.TabIndex = 11
        Me.chkAlteracao.Text = "Alteração"
        '
        'txtDocumentosNecessarios
        '
        Me.txtDocumentosNecessarios.BackColor = System.Drawing.Color.White
        Me.txtDocumentosNecessarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDocumentosNecessarios.Location = New System.Drawing.Point(13, 235)
        Me.txtDocumentosNecessarios.MaxLength = 60
        Me.txtDocumentosNecessarios.Name = "txtDocumentosNecessarios"
        Me.txtDocumentosNecessarios.Size = New System.Drawing.Size(437, 20)
        Me.txtDocumentosNecessarios.TabIndex = 47
        Me.txtDocumentosNecessarios.TabStop = False
        '
        'txtFuncionarioAtendente
        '
        Me.txtFuncionarioAtendente.BackColor = System.Drawing.Color.White
        Me.txtFuncionarioAtendente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFuncionarioAtendente.Location = New System.Drawing.Point(10, 37)
        Me.txtFuncionarioAtendente.MaxLength = 60
        Me.txtFuncionarioAtendente.Name = "txtFuncionarioAtendente"
        Me.txtFuncionarioAtendente.Size = New System.Drawing.Size(295, 20)
        Me.txtFuncionarioAtendente.TabIndex = 1
        Me.txtFuncionarioAtendente.TabStop = False
        '
        'chkBaixa
        '
        Me.chkBaixa.Location = New System.Drawing.Point(203, 62)
        Me.chkBaixa.Name = "chkBaixa"
        Me.chkBaixa.Size = New System.Drawing.Size(68, 25)
        Me.chkBaixa.TabIndex = 13
        Me.chkBaixa.Text = "Baixa"
        '
        'lblDescricaoProduto
        '
        Me.lblDescricaoProduto.AutoSize = True
        Me.lblDescricaoProduto.Location = New System.Drawing.Point(7, 20)
        Me.lblDescricaoProduto.Name = "lblDescricaoProduto"
        Me.lblDescricaoProduto.Size = New System.Drawing.Size(117, 13)
        Me.lblDescricaoProduto.TabIndex = 0
        Me.lblDescricaoProduto.Text = "Funcionário Atendente:"
        '
        'chkAbertura
        '
        Me.chkAbertura.Location = New System.Drawing.Point(10, 62)
        Me.chkAbertura.Name = "chkAbertura"
        Me.chkAbertura.Size = New System.Drawing.Size(68, 25)
        Me.chkAbertura.TabIndex = 10
        Me.chkAbertura.Text = "Abertura"
        '
        'txtObservacaoOS
        '
        Me.txtObservacaoOS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtObservacaoOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacaoOS.Location = New System.Drawing.Point(10, 314)
        Me.txtObservacaoOS.MaxLength = 5000
        Me.txtObservacaoOS.Multiline = True
        Me.txtObservacaoOS.Name = "txtObservacaoOS"
        Me.txtObservacaoOS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacaoOS.Size = New System.Drawing.Size(859, 56)
        Me.txtObservacaoOS.TabIndex = 0
        '
        'lblObjetivo
        '
        Me.lblObjetivo.AutoSize = True
        Me.lblObjetivo.Location = New System.Drawing.Point(7, 91)
        Me.lblObjetivo.Name = "lblObjetivo"
        Me.lblObjetivo.Size = New System.Drawing.Size(122, 13)
        Me.lblObjetivo.TabIndex = 17
        Me.lblObjetivo.Text = "Descrição dos Serviços:"
        '
        'grdServico
        '
        Me.grdServico.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdServico.AlternatingColors = True
        Me.grdServico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdServico.AutoEdit = True
        grdServico_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdServico_DesignTimeLayout_Reference_0.Instance"), Object)
        grdServico_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdServico_DesignTimeLayout_Reference_0})
        grdServico_DesignTimeLayout.LayoutString = resources.GetString("grdServico_DesignTimeLayout.LayoutString")
        Me.grdServico.DesignTimeLayout = grdServico_DesignTimeLayout
        Me.grdServico.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdServico.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdServico.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdServico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdServico.FrozenColumns = 2
        Me.grdServico.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdServico.GroupByBoxVisible = False
        Me.grdServico.Location = New System.Drawing.Point(9, 116)
        Me.grdServico.Name = "grdServico"
        Me.grdServico.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdServico.RecordNavigator = True
        Me.grdServico.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdServico.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdServico.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdServico.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdServico.Size = New System.Drawing.Size(1220, 266)
        Me.grdServico.TabIndex = 1
        Me.grdServico.TabStop = False
        Me.grdServico.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdServico.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdServico.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdServico.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdServico.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdServico.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdServico.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdServico.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdServico.VisualStyleManager = Me.vsmMain
        '
        'grpServico
        '
        Me.grpServico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpServico.BackColor = System.Drawing.Color.Transparent
        Me.grpServico.Controls.Add(Me.Label10)
        Me.grpServico.Controls.Add(Me.txtValorTotalServico)
        Me.grpServico.Controls.Add(Me.txtObservacaoServico)
        Me.grpServico.Controls.Add(Me.Label9)
        Me.grpServico.Controls.Add(Me.cboServico)
        Me.grpServico.Controls.Add(Me.Label6)
        Me.grpServico.Controls.Add(Me.btnExcluirServico)
        Me.grpServico.Controls.Add(Me.btnInserirServico)
        Me.grpServico.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpServico.Location = New System.Drawing.Point(8, 3)
        Me.grpServico.Name = "grpServico"
        Me.grpServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpServico.Size = New System.Drawing.Size(1220, 107)
        Me.grpServico.TabIndex = 0
        Me.grpServico.Text = "Custos"
        Me.grpServico.VisualStyleManager = Me.vsmMain
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Observação:"
        '
        'txtValorTotalServico
        '
        Me.txtValorTotalServico.DecimalDigits = 2
        Me.txtValorTotalServico.Location = New System.Drawing.Point(547, 35)
        Me.txtValorTotalServico.Name = "txtValorTotalServico"
        Me.txtValorTotalServico.Size = New System.Drawing.Size(144, 20)
        Me.txtValorTotalServico.TabIndex = 3
        Me.txtValorTotalServico.Text = "0,00"
        Me.txtValorTotalServico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtObservacaoServico
        '
        Me.txtObservacaoServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacaoServico.Location = New System.Drawing.Point(9, 75)
        Me.txtObservacaoServico.MaxLength = 500
        Me.txtObservacaoServico.Name = "txtObservacaoServico"
        Me.txtObservacaoServico.Size = New System.Drawing.Size(768, 20)
        Me.txtObservacaoServico.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(544, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Valor Total:"
        '
        'cboServico
        '
        Me.cboServico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboServico.AutoSize = False
        Me.cboServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboServico.Location = New System.Drawing.Point(10, 35)
        Me.cboServico.Name = "cboServico"
        Me.cboServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboServico.Size = New System.Drawing.Size(531, 20)
        Me.cboServico.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Serviço:"
        '
        'btnExcluirServico
        '
        Me.btnExcluirServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirServico.Image = CType(resources.GetObject("btnExcluirServico.Image"), System.Drawing.Image)
        Me.btnExcluirServico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirServico.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirServico.Location = New System.Drawing.Point(1120, 48)
        Me.btnExcluirServico.Name = "btnExcluirServico"
        Me.btnExcluirServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirServico.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirServico.TabIndex = 7
        Me.btnExcluirServico.Text = "Excluir"
        Me.btnExcluirServico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirServico
        '
        Me.btnInserirServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirServico.Image = CType(resources.GetObject("btnInserirServico.Image"), System.Drawing.Image)
        Me.btnInserirServico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirServico.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirServico.Location = New System.Drawing.Point(1120, 19)
        Me.btnInserirServico.Name = "btnInserirServico"
        Me.btnInserirServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirServico.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirServico.TabIndex = 6
        Me.btnInserirServico.Text = "Inserir"
        Me.btnInserirServico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.btnExcluirArquivos)
        Me.UiGroupBox2.Controls.Add(Me.btnInserir)
        Me.UiGroupBox2.Controls.Add(Me.lblDescricao)
        Me.UiGroupBox2.Controls.Add(Me.txtDocumento)
        Me.UiGroupBox2.Controls.Add(Me.UiButton1)
        Me.UiGroupBox2.Controls.Add(Me.txtArquivos)
        Me.UiGroupBox2.Controls.Add(Me.lblArquivos)
        Me.UiGroupBox2.Controls.Add(Me.btnVisualizarArquivo)
        Me.UiGroupBox2.Location = New System.Drawing.Point(9, 5)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.Size = New System.Drawing.Size(219, 92)
        Me.UiGroupBox2.TabIndex = 0
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'btnExcluirArquivos
        '
        Me.btnExcluirArquivos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirArquivos.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirArquivos.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirArquivos.Location = New System.Drawing.Point(1111, 51)
        Me.btnExcluirArquivos.Name = "btnExcluirArquivos"
        Me.btnExcluirArquivos.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirArquivos.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirArquivos.TabIndex = 7
        Me.btnExcluirArquivos.Text = "Excluir"
        Me.btnExcluirArquivos.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(1111, 22)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 6
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricao.Location = New System.Drawing.Point(9, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(58, 13)
        Me.lblDescricao.TabIndex = 0
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(12, 34)
        Me.txtDocumento.MaxLength = 0
        Me.txtDocumento.Multiline = True
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(385, 20)
        Me.txtDocumento.TabIndex = 1
        '
        'UiButton1
        '
        Me.UiButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiButton1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.UiButton1.ImageSize = New System.Drawing.Size(14, 14)
        Me.UiButton1.Location = New System.Drawing.Point(65, 34)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiButton1.Size = New System.Drawing.Size(20, 20)
        Me.UiButton1.TabIndex = 5
        Me.UiButton1.Text = "..."
        Me.UiButton1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtArquivos
        '
        Me.txtArquivos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArquivos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivos.Location = New System.Drawing.Point(403, 34)
        Me.txtArquivos.MaxLength = 255
        Me.txtArquivos.Name = "txtArquivos"
        Me.txtArquivos.ReadOnly = True
        Me.txtArquivos.Size = New System.Drawing.Size(0, 20)
        Me.txtArquivos.TabIndex = 3
        Me.txtArquivos.TabStop = False
        '
        'lblArquivos
        '
        Me.lblArquivos.AutoSize = True
        Me.lblArquivos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblArquivos.Location = New System.Drawing.Point(402, 18)
        Me.lblArquivos.Name = "lblArquivos"
        Me.lblArquivos.Size = New System.Drawing.Size(46, 13)
        Me.lblArquivos.TabIndex = 2
        Me.lblArquivos.Text = "Arquivo:"
        '
        'btnVisualizarArquivo
        '
        Me.btnVisualizarArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarArquivo.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnVisualizarArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.btnVisualizarArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnVisualizarArquivo.Location = New System.Drawing.Point(46, 34)
        Me.btnVisualizarArquivo.Name = "btnVisualizarArquivo"
        Me.btnVisualizarArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarArquivo.Size = New System.Drawing.Size(20, 20)
        Me.btnVisualizarArquivo.TabIndex = 4
        Me.btnVisualizarArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        grdArquivos_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdArquivos_DesignTimeLayout_Reference_2.Instance"), Object)
        grdArquivos_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdArquivos_DesignTimeLayout_Reference_0, grdArquivos_DesignTimeLayout_Reference_1, grdArquivos_DesignTimeLayout_Reference_2})
        grdArquivos_DesignTimeLayout.LayoutString = resources.GetString("grdArquivos_DesignTimeLayout.LayoutString")
        Me.grdArquivos.DesignTimeLayout = grdArquivos_DesignTimeLayout
        Me.grdArquivos.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdArquivos.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdArquivos.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdArquivos.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdArquivos.GroupByBoxVisible = False
        Me.grdArquivos.Location = New System.Drawing.Point(9, 103)
        Me.grdArquivos.Name = "grdArquivos"
        Me.grdArquivos.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdArquivos.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdArquivos.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdArquivos.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdArquivos.Size = New System.Drawing.Size(219, 272)
        Me.grdArquivos.TabIndex = 2
        Me.grdArquivos.TabStop = False
        Me.grdArquivos.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdArquivos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'grdEvento
        '
        Me.grdEvento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdEvento.AlternatingColors = True
        Me.grdEvento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdEvento.AutoEdit = True
        grdEvento_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdEvento_DesignTimeLayout_Reference_0.Instance"), Object)
        grdEvento_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdEvento_DesignTimeLayout_Reference_0})
        grdEvento_DesignTimeLayout.LayoutString = resources.GetString("grdEvento_DesignTimeLayout.LayoutString")
        Me.grdEvento.DesignTimeLayout = grdEvento_DesignTimeLayout
        Me.grdEvento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdEvento.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdEvento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdEvento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdEvento.FrozenColumns = 2
        Me.grdEvento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdEvento.GroupByBoxVisible = False
        Me.grdEvento.Location = New System.Drawing.Point(8, 116)
        Me.grdEvento.Name = "grdEvento"
        Me.grdEvento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdEvento.RecordNavigator = True
        Me.grdEvento.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdEvento.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdEvento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdEvento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdEvento.Size = New System.Drawing.Size(220, 266)
        Me.grdEvento.TabIndex = 2
        Me.grdEvento.TabStop = False
        Me.grdEvento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdEvento.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdEvento.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdEvento.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdEvento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdEvento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdEvento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdEvento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdEvento.VisualStyleManager = Me.vsmMain
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox3.Controls.Add(Me.Label27)
        Me.UiGroupBox3.Controls.Add(Me.txtObservacaoEvento)
        Me.UiGroupBox3.Controls.Add(Me.cboEvento)
        Me.UiGroupBox3.Controls.Add(Me.lblEvento)
        Me.UiGroupBox3.Controls.Add(Me.btnExcluirEvento)
        Me.UiGroupBox3.Controls.Add(Me.btnInserirEvento)
        Me.UiGroupBox3.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox3.Location = New System.Drawing.Point(8, 3)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox3.Size = New System.Drawing.Size(220, 107)
        Me.UiGroupBox3.TabIndex = 0
        Me.UiGroupBox3.Text = "Eventos"
        Me.UiGroupBox3.VisualStyleManager = Me.vsmMain
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 58)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(68, 13)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Observação:"
        '
        'txtObservacaoEvento
        '
        Me.txtObservacaoEvento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacaoEvento.Location = New System.Drawing.Point(9, 75)
        Me.txtObservacaoEvento.MaxLength = 500
        Me.txtObservacaoEvento.Name = "txtObservacaoEvento"
        Me.txtObservacaoEvento.Size = New System.Drawing.Size(768, 20)
        Me.txtObservacaoEvento.TabIndex = 3
        '
        'cboEvento
        '
        Me.cboEvento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboEvento.AutoSize = False
        Me.cboEvento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEvento.Location = New System.Drawing.Point(10, 35)
        Me.cboEvento.Name = "cboEvento"
        Me.cboEvento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboEvento.Size = New System.Drawing.Size(0, 20)
        Me.cboEvento.TabIndex = 1
        '
        'lblEvento
        '
        Me.lblEvento.AutoSize = True
        Me.lblEvento.Location = New System.Drawing.Point(10, 18)
        Me.lblEvento.Name = "lblEvento"
        Me.lblEvento.Size = New System.Drawing.Size(44, 13)
        Me.lblEvento.TabIndex = 0
        Me.lblEvento.Text = "Evento:"
        '
        'btnExcluirEvento
        '
        Me.btnExcluirEvento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirEvento.Image = CType(resources.GetObject("btnExcluirEvento.Image"), System.Drawing.Image)
        Me.btnExcluirEvento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirEvento.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirEvento.Location = New System.Drawing.Point(120, 48)
        Me.btnExcluirEvento.Name = "btnExcluirEvento"
        Me.btnExcluirEvento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirEvento.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirEvento.TabIndex = 5
        Me.btnExcluirEvento.Text = "Excluir"
        Me.btnExcluirEvento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirEvento
        '
        Me.btnInserirEvento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirEvento.Image = CType(resources.GetObject("btnInserirEvento.Image"), System.Drawing.Image)
        Me.btnInserirEvento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirEvento.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirEvento.Location = New System.Drawing.Point(120, 19)
        Me.btnInserirEvento.Name = "btnInserirEvento"
        Me.btnInserirEvento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirEvento.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirEvento.TabIndex = 4
        Me.btnInserirEvento.Text = "Inserir"
        Me.btnInserirEvento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagProduto
        '
        Me.pagProduto.Key = "pagItem"
        Me.pagProduto.Location = New System.Drawing.Point(1, 22)
        Me.pagProduto.Name = "pagProduto"
        Me.pagProduto.Size = New System.Drawing.Size(655, 434)
        Me.pagProduto.TabStop = True
        Me.pagProduto.Text = "Dados Gerais"
        '
        'UiComboBox3
        '
        Me.UiComboBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiComboBox3.AutoSize = False
        Me.UiComboBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UiComboBox3.Location = New System.Drawing.Point(10, 35)
        Me.UiComboBox3.Name = "UiComboBox3"
        Me.UiComboBox3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiComboBox3.Size = New System.Drawing.Size(0, 20)
        Me.UiComboBox3.TabIndex = 1
        '
        'UiGroupBox6
        '
        Me.UiGroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox6.Controls.Add(Me.UiComboBox3)
        Me.UiGroupBox6.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox6.Location = New System.Drawing.Point(8, 3)
        Me.UiGroupBox6.Name = "UiGroupBox6"
        Me.UiGroupBox6.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox6.Size = New System.Drawing.Size(639, 107)
        Me.UiGroupBox6.TabIndex = 0
        Me.UiGroupBox6.Text = "Custos"
        Me.UiGroupBox6.VisualStyleManager = Me.vsmMain
        '
        'GridEX2
        '
        Me.GridEX2.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX2.AlternatingColors = True
        Me.GridEX2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX2.AutoEdit = True
        GridEX2_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridEX2_DesignTimeLayout_Reference_0.Instance"), Object)
        GridEX2_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridEX2_DesignTimeLayout_Reference_0})
        GridEX2_DesignTimeLayout.LayoutString = resources.GetString("GridEX2_DesignTimeLayout.LayoutString")
        Me.GridEX2.DesignTimeLayout = GridEX2_DesignTimeLayout
        Me.GridEX2.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridEX2.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.GridEX2.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.GridEX2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.GridEX2.FrozenColumns = 2
        Me.GridEX2.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridEX2.GroupByBoxVisible = False
        Me.GridEX2.Location = New System.Drawing.Point(9, 116)
        Me.GridEX2.Name = "GridEX2"
        Me.GridEX2.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridEX2.RecordNavigator = True
        Me.GridEX2.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.GridEX2.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX2.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.GridEX2.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.GridEX2.Size = New System.Drawing.Size(639, 309)
        Me.GridEX2.TabIndex = 1
        Me.GridEX2.TabStop = False
        Me.GridEX2.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX2.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.GridEX2.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.GridEX2.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridEX2.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.GridEX2.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.GridEX2.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridEX2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.GridEX2.VisualStyleManager = Me.vsmMain
        '
        'btnExcelGridServico
        '
        Me.btnExcelGridServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridServico.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridServico.FlatAppearance.BorderSize = 0
        Me.btnExcelGridServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridServico.Image = CType(resources.GetObject("btnExcelGridServico.Image"), System.Drawing.Image)
        Me.btnExcelGridServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridServico.Location = New System.Drawing.Point(57, 365)
        Me.btnExcelGridServico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridServico.Name = "btnExcelGridServico"
        Me.btnExcelGridServico.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridServico.TabIndex = 96
        Me.btnExcelGridServico.TabStop = False
        Me.btnExcelGridServico.UseVisualStyleBackColor = False
        '
        'btnAgruparGridServico
        '
        Me.btnAgruparGridServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridServico.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridServico.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridServico.Image = CType(resources.GetObject("btnAgruparGridServico.Image"), System.Drawing.Image)
        Me.btnAgruparGridServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridServico.Location = New System.Drawing.Point(33, 365)
        Me.btnAgruparGridServico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridServico.Name = "btnAgruparGridServico"
        Me.btnAgruparGridServico.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridServico.TabIndex = 95
        Me.btnAgruparGridServico.TabStop = False
        Me.btnAgruparGridServico.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridServico
        '
        Me.btnConfigurarGridServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridServico.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridServico.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridServico.Image = CType(resources.GetObject("btnConfigurarGridServico.Image"), System.Drawing.Image)
        Me.btnConfigurarGridServico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridServico.Location = New System.Drawing.Point(9, 365)
        Me.btnConfigurarGridServico.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridServico.Name = "btnConfigurarGridServico"
        Me.btnConfigurarGridServico.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridServico.TabIndex = 2
        Me.btnConfigurarGridServico.TabStop = False
        Me.btnConfigurarGridServico.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(57, 408)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 15)
        Me.Button2.TabIndex = 96
        Me.Button2.TabStop = False
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(33, 408)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 15)
        Me.Button3.TabIndex = 95
        Me.Button3.TabStop = False
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button4.Location = New System.Drawing.Point(9, 408)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 15)
        Me.Button4.TabIndex = 2
        Me.Button4.TabStop = False
        Me.Button4.UseVisualStyleBackColor = False
        '
        'chkDetalhado
        '
        Me.chkDetalhado.Checked = True
        Me.chkDetalhado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDetalhado.Location = New System.Drawing.Point(240, 38)
        Me.chkDetalhado.Name = "chkDetalhado"
        Me.chkDetalhado.Size = New System.Drawing.Size(291, 15)
        Me.chkDetalhado.TabIndex = 6
        Me.chkDetalhado.Text = "Detalhado"
        Me.chkDetalhado.UseCompatibleTextRendering = False
        '
        'usrFat000000024
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFat000000024"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpDuplicata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDuplicata.ResumeLayout(False)
        Me.grpDuplicata.PerformLayout()
        CType(Me.grdDuplicata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grdServico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpServico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpServico.ResumeLayout(False)
        Me.grpServico.PerformLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.grdArquivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEvento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        Me.UiGroupBox3.PerformLayout()
        CType(Me.UiGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox6.ResumeLayout(False)
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpDuplicata As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboCondicaoPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCondicaoPagamento As System.Windows.Forms.Label
    Friend WithEvents cboFormaPagamento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFormaPagamento As System.Windows.Forms.Label
    Friend WithEvents btnCalcularDuplicata As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtIntervaloParcela As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblIntervaloParcela As System.Windows.Forms.Label
    Friend WithEvents txtNumeroParcela As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroParcela As System.Windows.Forms.Label
    Friend WithEvents grdDuplicata As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents chkConsolidacao As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents btnEventoMultiplo As System.Windows.Forms.Button
    Friend WithEvents chkAta As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpDataRetornoRevisao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpDataEnvioRevisao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCobrancaAssinatura As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpDataEnvioDepartamentos As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents dtpDataEnvioCliente As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtpDataDigitalizacao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpDataRetornoRegistro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpDataEntradaRegistro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpDataRetornoAssinatura As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpDataEnvioAssinatura As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpDataFinalizado As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpDataSolicitacao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtEventoConteudo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtObjetivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtInscricaoINSS As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents chkOutros As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPIS As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents chkCopia As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents dtpDataAguardar As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpData As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents chkAguardarAte As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkBuscaremos As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkDeixara As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkCND As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkDeixou As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkAlteracao As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents txtDocumentosNecessarios As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtFuncionarioAtendente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents chkBaixa As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents lblDescricaoProduto As System.Windows.Forms.Label
    Friend WithEvents chkAbertura As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents txtObservacaoOS As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblObjetivo As System.Windows.Forms.Label
    Friend WithEvents btnExcelGridServico As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridServico As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridServico As System.Windows.Forms.Button
    Friend WithEvents grdServico As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpServico As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtValorTotalServico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtObservacaoServico As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboServico As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnExcluirServico As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirServico As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluirArquivos As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtDocumento As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtArquivos As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblArquivos As System.Windows.Forms.Label
    Friend WithEvents btnVisualizarArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdArquivos As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdEvento As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtObservacaoEvento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboEvento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblEvento As System.Windows.Forms.Label
    Friend WithEvents btnExcluirEvento As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirEvento As Janus.Windows.EditControls.UIButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents pagProduto As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiComboBox3 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents UiGroupBox6 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents GridEX2 As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelGridListagem As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridListagem As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridListagem As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Private WithEvents btnExportarExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents chkDetalhado As Janus.Windows.EditControls.UICheckBox

End Class
