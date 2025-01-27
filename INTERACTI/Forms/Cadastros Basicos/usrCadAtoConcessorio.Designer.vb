<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadAtoConcessorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadAtoConcessorio))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column0.Image")
        Dim grdListagem_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table1.Columns.Column0.Image")
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Series1 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series()
        Dim Title1 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title()
        Dim grdDI_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdDI_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdDI_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdRE_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdRE_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdRE_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdProduto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProduto_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaBaixado = New System.Windows.Forms.Label()
        Me.picLegendaBaixado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaFechado = New System.Windows.Forms.Label()
        Me.picLegendaFechado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAberto = New System.Windows.Forms.Label()
        Me.picLegendaAberto = New System.Windows.Forms.PictureBox()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboStatusFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.cboModalidadeAtoConcessorioFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblModalidadeAtoConcessorioFiltro = New System.Windows.Forms.Label()
        Me.cboTipoAtoConcessorioFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoAtoConcessorioFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblDataVigenteFiltro = New System.Windows.Forms.Label()
        Me.dtpDataVigenteFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtNumeroAtoConcessorioFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroAtoConcessorioFiltro = New System.Windows.Forms.Label()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtStatusAtoConcessorio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblStatusAtoConcessorio = New System.Windows.Forms.Label()
        Me.lblSaldoAtoConcessorio = New System.Windows.Forms.Label()
        Me.txtSaldoAtoConcessorio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboModalidadeAtoConcessorio = New Janus.Windows.EditControls.UIComboBox()
        Me.lblModalidadeAtoConcessorio = New System.Windows.Forms.Label()
        Me.cboTipoAtoConcessorio = New Janus.Windows.EditControls.UIComboBox()
        Me.btnArquivoAtoConcessorio = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivoAtoConcessorio = New System.Windows.Forms.Label()
        Me.txtArquivoAtoConcessorio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTipoAtoConcessorio = New System.Windows.Forms.Label()
        Me.lblValorExportado = New System.Windows.Forms.Label()
        Me.txtValorExportado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorImportado = New System.Windows.Forms.Label()
        Me.txtValorImportado = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDataValidade = New System.Windows.Forms.Label()
        Me.dtpDataValidade = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataAbertura = New System.Windows.Forms.Label()
        Me.dtpDataAbertura = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtNumeroAtoConcessorio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroAtoConcessorio = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagResumo = New Janus.Windows.UI.Tab.UITabPage()
        Me.chrAtoConcessorio = New Dundas.Charting.WinControl.Chart()
        Me.pagDI = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDI = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblValorMoedaCorrenteDI = New System.Windows.Forms.Label()
        Me.txtValorMoedaCorrenteDI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblFatorCambialDI = New System.Windows.Forms.Label()
        Me.txtFatorCambialDI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboMoedaDI = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMoedaDI = New System.Windows.Forms.Label()
        Me.txtNumeroDI = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataRegistroDI = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtLocalDesembaracoDI = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataDesembaracoDI = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblValorDI = New System.Windows.Forms.Label()
        Me.txtValorDI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnArquivoDI = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivoDI = New System.Windows.Forms.Label()
        Me.txtArquivoDI = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataDesembaracoDI = New System.Windows.Forms.Label()
        Me.lblLocalDesembaracoDI = New System.Windows.Forms.Label()
        Me.lblDataRegistroDI = New System.Windows.Forms.Label()
        Me.lblNumeroDI = New System.Windows.Forms.Label()
        Me.btnExcluirDI = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirDI = New Janus.Windows.EditControls.UIButton()
        Me.cboTipoImportacaoDI = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoImportacaoDI = New System.Windows.Forms.Label()
        Me.grdDI = New Janus.Windows.GridEX.GridEX()
        Me.pagRE = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdRE = New Janus.Windows.GridEX.GridEX()
        Me.grpRE = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarContratoCambio = New System.Windows.Forms.Button()
        Me.cboContratoCambio = New Janus.Windows.EditControls.UIComboBox()
        Me.lblContratoCambio = New System.Windows.Forms.Label()
        Me.lblValorMoedaCorrenteRE = New System.Windows.Forms.Label()
        Me.txtValorMoedaCorrenteRE = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblFatorCambialRE = New System.Windows.Forms.Label()
        Me.txtFatorCambialRE = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboMoedaRE = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMoedaRE = New System.Windows.Forms.Label()
        Me.txtValorRE = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtLocalEmbarqueRE = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataRegistroRE = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtNumeroRE = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblValorRE = New System.Windows.Forms.Label()
        Me.lblLocalEmbarqueRE = New System.Windows.Forms.Label()
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivoRE = New System.Windows.Forms.Label()
        Me.txtArquivoRE = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataRegistroRE = New System.Windows.Forms.Label()
        Me.lblNumeroRE = New System.Windows.Forms.Label()
        Me.btnExcluirRE = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirRE = New Janus.Windows.EditControls.UIButton()
        Me.pagLaudoTecnico = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpProduto = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarProduto = New System.Windows.Forms.Button()
        Me.cboCodigoProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoProduto = New System.Windows.Forms.Label()
        Me.lblDescricaoProduto = New System.Windows.Forms.Label()
        Me.txtDescricaoProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnExcluirProduto = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirProduto = New Janus.Windows.EditControls.UIButton()
        Me.grdProduto = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaBaixado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaFechado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaAberto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagResumo.SuspendLayout()
        CType(Me.chrAtoConcessorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDI.SuspendLayout()
        CType(Me.grpDI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDI.SuspendLayout()
        CType(Me.grdDI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagRE.SuspendLayout()
        CType(Me.grdRE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpRE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRE.SuspendLayout()
        Me.pagLaudoTecnico.SuspendLayout()
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProduto.SuspendLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
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
        resources.ApplyResources(Me.tabMain, "tabMain")
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grpLegenda)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpControl)
        resources.ApplyResources(Me.pagLista, "pagLista")
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Name = "pagLista"
        Me.pagLista.TabStop = True
        '
        'grpLegenda
        '
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaBaixado)
        Me.grpLegenda.Controls.Add(Me.picLegendaBaixado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaFechado)
        Me.grpLegenda.Controls.Add(Me.picLegendaFechado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAberto)
        Me.grpLegenda.Controls.Add(Me.picLegendaAberto)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.grpLegenda, "grpLegenda")
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaBaixado
        '
        resources.ApplyResources(Me.lblLegendaBaixado, "lblLegendaBaixado")
        Me.lblLegendaBaixado.Name = "lblLegendaBaixado"
        '
        'picLegendaBaixado
        '
        Me.picLegendaBaixado.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaBaixado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.picLegendaBaixado, "picLegendaBaixado")
        Me.picLegendaBaixado.Name = "picLegendaBaixado"
        Me.picLegendaBaixado.TabStop = False
        '
        'lblLegendaFechado
        '
        resources.ApplyResources(Me.lblLegendaFechado, "lblLegendaFechado")
        Me.lblLegendaFechado.Name = "lblLegendaFechado"
        '
        'picLegendaFechado
        '
        Me.picLegendaFechado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaFechado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.picLegendaFechado, "picLegendaFechado")
        Me.picLegendaFechado.Name = "picLegendaFechado"
        Me.picLegendaFechado.TabStop = False
        '
        'lblLegendaAberto
        '
        resources.ApplyResources(Me.lblLegendaAberto, "lblLegendaAberto")
        Me.lblLegendaAberto.Name = "lblLegendaAberto"
        '
        'picLegendaAberto
        '
        Me.picLegendaAberto.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaAberto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.picLegendaAberto, "picLegendaAberto")
        Me.picLegendaAberto.Name = "picLegendaAberto"
        Me.picLegendaAberto.TabStop = False
        '
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.cboModalidadeAtoConcessorioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblModalidadeAtoConcessorioFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoAtoConcessorioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoAtoConcessorioFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblDataVigenteFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataVigenteFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroAtoConcessorioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroAtoConcessorioFiltro)
        Me.grpFiltro.Controls.Add(Me.txtDescricaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDescricaoFiltro)
        resources.ApplyResources(Me.grpFiltro, "grpFiltro")
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboStatusFiltro
        '
        resources.ApplyResources(Me.cboStatusFiltro, "cboStatusFiltro")
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblStatusFiltro
        '
        resources.ApplyResources(Me.lblStatusFiltro, "lblStatusFiltro")
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        '
        'cboModalidadeAtoConcessorioFiltro
        '
        resources.ApplyResources(Me.cboModalidadeAtoConcessorioFiltro, "cboModalidadeAtoConcessorioFiltro")
        Me.cboModalidadeAtoConcessorioFiltro.Name = "cboModalidadeAtoConcessorioFiltro"
        Me.cboModalidadeAtoConcessorioFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblModalidadeAtoConcessorioFiltro
        '
        resources.ApplyResources(Me.lblModalidadeAtoConcessorioFiltro, "lblModalidadeAtoConcessorioFiltro")
        Me.lblModalidadeAtoConcessorioFiltro.Name = "lblModalidadeAtoConcessorioFiltro"
        '
        'cboTipoAtoConcessorioFiltro
        '
        resources.ApplyResources(Me.cboTipoAtoConcessorioFiltro, "cboTipoAtoConcessorioFiltro")
        Me.cboTipoAtoConcessorioFiltro.Name = "cboTipoAtoConcessorioFiltro"
        Me.cboTipoAtoConcessorioFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblTipoAtoConcessorioFiltro
        '
        resources.ApplyResources(Me.lblTipoAtoConcessorioFiltro, "lblTipoAtoConcessorioFiltro")
        Me.lblTipoAtoConcessorioFiltro.Name = "lblTipoAtoConcessorioFiltro"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnFiltrar, "btnFiltrar")
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDataVigenteFiltro
        '
        resources.ApplyResources(Me.lblDataVigenteFiltro, "lblDataVigenteFiltro")
        Me.lblDataVigenteFiltro.Name = "lblDataVigenteFiltro"
        '
        'dtpDataVigenteFiltro
        '
        '
        '
        '
        Me.dtpDataVigenteFiltro.DropDownCalendar.Name = ""
        resources.ApplyResources(Me.dtpDataVigenteFiltro, "dtpDataVigenteFiltro")
        Me.dtpDataVigenteFiltro.Name = "dtpDataVigenteFiltro"
        Me.dtpDataVigenteFiltro.ShowCheckBox = True
        Me.dtpDataVigenteFiltro.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'txtNumeroAtoConcessorioFiltro
        '
        resources.ApplyResources(Me.txtNumeroAtoConcessorioFiltro, "txtNumeroAtoConcessorioFiltro")
        Me.txtNumeroAtoConcessorioFiltro.MaxLength = 20
        Me.txtNumeroAtoConcessorioFiltro.Name = "txtNumeroAtoConcessorioFiltro"
        '
        'lblNumeroAtoConcessorioFiltro
        '
        resources.ApplyResources(Me.lblNumeroAtoConcessorioFiltro, "lblNumeroAtoConcessorioFiltro")
        Me.lblNumeroAtoConcessorioFiltro.Name = "lblNumeroAtoConcessorioFiltro"
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtDescricaoFiltro, "txtDescricaoFiltro")
        Me.txtDescricaoFiltro.MaxLength = 100
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        '
        'lblDescricaoFiltro
        '
        resources.ApplyResources(Me.lblDescricaoFiltro, "lblDescricaoFiltro")
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_3.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2, grdListagem_DesignTimeLayout_Reference_3})
        resources.ApplyResources(grdListagem_DesignTimeLayout, "grdListagem_DesignTimeLayout")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        resources.ApplyResources(Me.grdListagem, "grdListagem")
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        resources.ApplyResources(Me.grpControl, "grpControl")
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnExcel)
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnExcel
        '
        resources.ApplyResources(Me.btnExcel, "btnExcel")
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo1
        '
        resources.ApplyResources(Me.btnNovo1, "btnNovo1")
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        resources.ApplyResources(Me.btnSair, "btnSair")
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        resources.ApplyResources(Me.btnExcluir, "btnExcluir")
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        resources.ApplyResources(Me.pagDados, "pagDados")
        Me.pagDados.Key = "padDados"
        Me.pagDados.Name = "pagDados"
        Me.pagDados.TabStop = True
        '
        'grpDados
        '
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtStatusAtoConcessorio)
        Me.grpDados.Controls.Add(Me.lblStatusAtoConcessorio)
        Me.grpDados.Controls.Add(Me.lblSaldoAtoConcessorio)
        Me.grpDados.Controls.Add(Me.txtSaldoAtoConcessorio)
        Me.grpDados.Controls.Add(Me.cboModalidadeAtoConcessorio)
        Me.grpDados.Controls.Add(Me.lblModalidadeAtoConcessorio)
        Me.grpDados.Controls.Add(Me.cboTipoAtoConcessorio)
        Me.grpDados.Controls.Add(Me.btnArquivoAtoConcessorio)
        Me.grpDados.Controls.Add(Me.lblArquivoAtoConcessorio)
        Me.grpDados.Controls.Add(Me.txtArquivoAtoConcessorio)
        Me.grpDados.Controls.Add(Me.lblTipoAtoConcessorio)
        Me.grpDados.Controls.Add(Me.lblValorExportado)
        Me.grpDados.Controls.Add(Me.txtValorExportado)
        Me.grpDados.Controls.Add(Me.lblValorImportado)
        Me.grpDados.Controls.Add(Me.txtValorImportado)
        Me.grpDados.Controls.Add(Me.lblValor)
        Me.grpDados.Controls.Add(Me.txtValor)
        Me.grpDados.Controls.Add(Me.lblDataValidade)
        Me.grpDados.Controls.Add(Me.dtpDataValidade)
        Me.grpDados.Controls.Add(Me.lblDataAbertura)
        Me.grpDados.Controls.Add(Me.dtpDataAbertura)
        Me.grpDados.Controls.Add(Me.txtNumeroAtoConcessorio)
        Me.grpDados.Controls.Add(Me.lblNumeroAtoConcessorio)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        resources.ApplyResources(Me.grpDados, "grpDados")
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtStatusAtoConcessorio
        '
        Me.txtStatusAtoConcessorio.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.txtStatusAtoConcessorio, "txtStatusAtoConcessorio")
        Me.txtStatusAtoConcessorio.MaxLength = 20
        Me.txtStatusAtoConcessorio.Name = "txtStatusAtoConcessorio"
        Me.txtStatusAtoConcessorio.ReadOnly = True
        Me.txtStatusAtoConcessorio.TabStop = False
        Me.txtStatusAtoConcessorio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblStatusAtoConcessorio
        '
        resources.ApplyResources(Me.lblStatusAtoConcessorio, "lblStatusAtoConcessorio")
        Me.lblStatusAtoConcessorio.Name = "lblStatusAtoConcessorio"
        '
        'lblSaldoAtoConcessorio
        '
        resources.ApplyResources(Me.lblSaldoAtoConcessorio, "lblSaldoAtoConcessorio")
        Me.lblSaldoAtoConcessorio.Name = "lblSaldoAtoConcessorio"
        '
        'txtSaldoAtoConcessorio
        '
        Me.txtSaldoAtoConcessorio.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.txtSaldoAtoConcessorio, "txtSaldoAtoConcessorio")
        Me.txtSaldoAtoConcessorio.Name = "txtSaldoAtoConcessorio"
        Me.txtSaldoAtoConcessorio.ReadOnly = True
        Me.txtSaldoAtoConcessorio.TabStop = False
        Me.txtSaldoAtoConcessorio.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'cboModalidadeAtoConcessorio
        '
        resources.ApplyResources(Me.cboModalidadeAtoConcessorio, "cboModalidadeAtoConcessorio")
        Me.cboModalidadeAtoConcessorio.Name = "cboModalidadeAtoConcessorio"
        Me.cboModalidadeAtoConcessorio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblModalidadeAtoConcessorio
        '
        resources.ApplyResources(Me.lblModalidadeAtoConcessorio, "lblModalidadeAtoConcessorio")
        Me.lblModalidadeAtoConcessorio.Name = "lblModalidadeAtoConcessorio"
        '
        'cboTipoAtoConcessorio
        '
        resources.ApplyResources(Me.cboTipoAtoConcessorio, "cboTipoAtoConcessorio")
        Me.cboTipoAtoConcessorio.Name = "cboTipoAtoConcessorio"
        Me.cboTipoAtoConcessorio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'btnArquivoAtoConcessorio
        '
        resources.ApplyResources(Me.btnArquivoAtoConcessorio, "btnArquivoAtoConcessorio")
        Me.btnArquivoAtoConcessorio.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivoAtoConcessorio.Name = "btnArquivoAtoConcessorio"
        Me.btnArquivoAtoConcessorio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivoAtoConcessorio.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivoAtoConcessorio
        '
        resources.ApplyResources(Me.lblArquivoAtoConcessorio, "lblArquivoAtoConcessorio")
        Me.lblArquivoAtoConcessorio.Name = "lblArquivoAtoConcessorio"
        '
        'txtArquivoAtoConcessorio
        '
        Me.txtArquivoAtoConcessorio.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.txtArquivoAtoConcessorio, "txtArquivoAtoConcessorio")
        Me.txtArquivoAtoConcessorio.MaxLength = 500
        Me.txtArquivoAtoConcessorio.Name = "txtArquivoAtoConcessorio"
        Me.txtArquivoAtoConcessorio.ReadOnly = True
        Me.txtArquivoAtoConcessorio.TabStop = False
        '
        'lblTipoAtoConcessorio
        '
        resources.ApplyResources(Me.lblTipoAtoConcessorio, "lblTipoAtoConcessorio")
        Me.lblTipoAtoConcessorio.Name = "lblTipoAtoConcessorio"
        '
        'lblValorExportado
        '
        resources.ApplyResources(Me.lblValorExportado, "lblValorExportado")
        Me.lblValorExportado.Name = "lblValorExportado"
        '
        'txtValorExportado
        '
        Me.txtValorExportado.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.txtValorExportado, "txtValorExportado")
        Me.txtValorExportado.Name = "txtValorExportado"
        Me.txtValorExportado.ReadOnly = True
        Me.txtValorExportado.TabStop = False
        Me.txtValorExportado.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorImportado
        '
        resources.ApplyResources(Me.lblValorImportado, "lblValorImportado")
        Me.lblValorImportado.Name = "lblValorImportado"
        '
        'txtValorImportado
        '
        Me.txtValorImportado.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.txtValorImportado, "txtValorImportado")
        Me.txtValorImportado.Name = "txtValorImportado"
        Me.txtValorImportado.ReadOnly = True
        Me.txtValorImportado.TabStop = False
        Me.txtValorImportado.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValor
        '
        resources.ApplyResources(Me.lblValor, "lblValor")
        Me.lblValor.Name = "lblValor"
        '
        'txtValor
        '
        resources.ApplyResources(Me.txtValor, "txtValor")
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblDataValidade
        '
        resources.ApplyResources(Me.lblDataValidade, "lblDataValidade")
        Me.lblDataValidade.Name = "lblDataValidade"
        '
        'dtpDataValidade
        '
        '
        '
        '
        Me.dtpDataValidade.DropDownCalendar.Name = ""
        resources.ApplyResources(Me.dtpDataValidade, "dtpDataValidade")
        Me.dtpDataValidade.Name = "dtpDataValidade"
        Me.dtpDataValidade.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblDataAbertura
        '
        resources.ApplyResources(Me.lblDataAbertura, "lblDataAbertura")
        Me.lblDataAbertura.Name = "lblDataAbertura"
        '
        'dtpDataAbertura
        '
        '
        '
        '
        Me.dtpDataAbertura.DropDownCalendar.Name = ""
        resources.ApplyResources(Me.dtpDataAbertura, "dtpDataAbertura")
        Me.dtpDataAbertura.Name = "dtpDataAbertura"
        Me.dtpDataAbertura.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'txtNumeroAtoConcessorio
        '
        resources.ApplyResources(Me.txtNumeroAtoConcessorio, "txtNumeroAtoConcessorio")
        Me.txtNumeroAtoConcessorio.MaxLength = 20
        Me.txtNumeroAtoConcessorio.Name = "txtNumeroAtoConcessorio"
        '
        'lblNumeroAtoConcessorio
        '
        resources.ApplyResources(Me.lblNumeroAtoConcessorio, "lblNumeroAtoConcessorio")
        Me.lblNumeroAtoConcessorio.Name = "lblNumeroAtoConcessorio"
        '
        'txtDescricao
        '
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtDescricao, "txtDescricao")
        Me.txtDescricao.MaxLength = 100
        Me.txtDescricao.Name = "txtDescricao"
        '
        'lblDescricao
        '
        resources.ApplyResources(Me.lblDescricao, "lblDescricao")
        Me.lblDescricao.Name = "lblDescricao"
        '
        'tabDados
        '
        resources.ApplyResources(Me.tabDados, "tabDados")
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagResumo, Me.pagDI, Me.pagRE, Me.pagLaudoTecnico})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagResumo
        '
        Me.pagResumo.Controls.Add(Me.chrAtoConcessorio)
        Me.pagResumo.Key = "pagResumo"
        resources.ApplyResources(Me.pagResumo, "pagResumo")
        Me.pagResumo.Name = "pagResumo"
        Me.pagResumo.TabStop = True
        '
        'chrAtoConcessorio
        '
        resources.ApplyResources(Me.chrAtoConcessorio, "chrAtoConcessorio")
        Me.chrAtoConcessorio.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrAtoConcessorio.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrAtoConcessorio.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.AxisX.Title = "Data"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.AxisY.Title = "Valor"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.Name = "Default"
        Me.chrAtoConcessorio.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Default"
        Me.chrAtoConcessorio.Legends.Add(Legend1)
        Me.chrAtoConcessorio.Name = "chrAtoConcessorio"
        Me.chrAtoConcessorio.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Series1.CustomAttributes = "LabelStyle=Bottom"
        Series1.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Series1.Name = "Default"
        Series1.ShowLabelAsValue = True
        Series1.SmartLabels.Enabled = True
        Series1.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series1.YValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Me.chrAtoConcessorio.Series.Add(Series1)
        Title1.Name = "Title1"
        Me.chrAtoConcessorio.Titles.Add(Title1)
        Me.chrAtoConcessorio.UI.Toolbar.Enabled = True
        '
        'pagDI
        '
        Me.pagDI.Controls.Add(Me.grpDI)
        Me.pagDI.Controls.Add(Me.grdDI)
        Me.pagDI.Key = "pagDI"
        resources.ApplyResources(Me.pagDI, "pagDI")
        Me.pagDI.Name = "pagDI"
        Me.pagDI.TabStop = True
        '
        'grpDI
        '
        Me.grpDI.BackColor = System.Drawing.Color.Transparent
        Me.grpDI.Controls.Add(Me.lblValorMoedaCorrenteDI)
        Me.grpDI.Controls.Add(Me.txtValorMoedaCorrenteDI)
        Me.grpDI.Controls.Add(Me.lblFatorCambialDI)
        Me.grpDI.Controls.Add(Me.txtFatorCambialDI)
        Me.grpDI.Controls.Add(Me.cboMoedaDI)
        Me.grpDI.Controls.Add(Me.lblMoedaDI)
        Me.grpDI.Controls.Add(Me.txtNumeroDI)
        Me.grpDI.Controls.Add(Me.dtpDataRegistroDI)
        Me.grpDI.Controls.Add(Me.txtLocalDesembaracoDI)
        Me.grpDI.Controls.Add(Me.dtpDataDesembaracoDI)
        Me.grpDI.Controls.Add(Me.lblValorDI)
        Me.grpDI.Controls.Add(Me.txtValorDI)
        Me.grpDI.Controls.Add(Me.btnArquivoDI)
        Me.grpDI.Controls.Add(Me.lblArquivoDI)
        Me.grpDI.Controls.Add(Me.txtArquivoDI)
        Me.grpDI.Controls.Add(Me.lblDataDesembaracoDI)
        Me.grpDI.Controls.Add(Me.lblLocalDesembaracoDI)
        Me.grpDI.Controls.Add(Me.lblDataRegistroDI)
        Me.grpDI.Controls.Add(Me.lblNumeroDI)
        Me.grpDI.Controls.Add(Me.btnExcluirDI)
        Me.grpDI.Controls.Add(Me.btnInserirDI)
        Me.grpDI.Controls.Add(Me.cboTipoImportacaoDI)
        Me.grpDI.Controls.Add(Me.lblTipoImportacaoDI)
        resources.ApplyResources(Me.grpDI, "grpDI")
        Me.grpDI.Name = "grpDI"
        Me.grpDI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDI.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDI.VisualStyleManager = Me.vsmMain
        '
        'lblValorMoedaCorrenteDI
        '
        resources.ApplyResources(Me.lblValorMoedaCorrenteDI, "lblValorMoedaCorrenteDI")
        Me.lblValorMoedaCorrenteDI.Name = "lblValorMoedaCorrenteDI"
        '
        'txtValorMoedaCorrenteDI
        '
        Me.txtValorMoedaCorrenteDI.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.txtValorMoedaCorrenteDI, "txtValorMoedaCorrenteDI")
        Me.txtValorMoedaCorrenteDI.Name = "txtValorMoedaCorrenteDI"
        Me.txtValorMoedaCorrenteDI.ReadOnly = True
        Me.txtValorMoedaCorrenteDI.TabStop = False
        Me.txtValorMoedaCorrenteDI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblFatorCambialDI
        '
        resources.ApplyResources(Me.lblFatorCambialDI, "lblFatorCambialDI")
        Me.lblFatorCambialDI.Name = "lblFatorCambialDI"
        '
        'txtFatorCambialDI
        '
        Me.txtFatorCambialDI.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.txtFatorCambialDI, "txtFatorCambialDI")
        Me.txtFatorCambialDI.Name = "txtFatorCambialDI"
        Me.txtFatorCambialDI.ReadOnly = True
        Me.txtFatorCambialDI.TabStop = False
        Me.txtFatorCambialDI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'cboMoedaDI
        '
        resources.ApplyResources(Me.cboMoedaDI, "cboMoedaDI")
        Me.cboMoedaDI.Name = "cboMoedaDI"
        Me.cboMoedaDI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblMoedaDI
        '
        resources.ApplyResources(Me.lblMoedaDI, "lblMoedaDI")
        Me.lblMoedaDI.Name = "lblMoedaDI"
        '
        'txtNumeroDI
        '
        resources.ApplyResources(Me.txtNumeroDI, "txtNumeroDI")
        Me.txtNumeroDI.MaxLength = 20
        Me.txtNumeroDI.Name = "txtNumeroDI"
        '
        'dtpDataRegistroDI
        '
        '
        '
        '
        Me.dtpDataRegistroDI.DropDownCalendar.Name = ""
        resources.ApplyResources(Me.dtpDataRegistroDI, "dtpDataRegistroDI")
        Me.dtpDataRegistroDI.Name = "dtpDataRegistroDI"
        Me.dtpDataRegistroDI.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'txtLocalDesembaracoDI
        '
        Me.txtLocalDesembaracoDI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtLocalDesembaracoDI, "txtLocalDesembaracoDI")
        Me.txtLocalDesembaracoDI.MaxLength = 60
        Me.txtLocalDesembaracoDI.Name = "txtLocalDesembaracoDI"
        '
        'dtpDataDesembaracoDI
        '
        '
        '
        '
        Me.dtpDataDesembaracoDI.DropDownCalendar.Name = ""
        resources.ApplyResources(Me.dtpDataDesembaracoDI, "dtpDataDesembaracoDI")
        Me.dtpDataDesembaracoDI.Name = "dtpDataDesembaracoDI"
        Me.dtpDataDesembaracoDI.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblValorDI
        '
        resources.ApplyResources(Me.lblValorDI, "lblValorDI")
        Me.lblValorDI.Name = "lblValorDI"
        '
        'txtValorDI
        '
        resources.ApplyResources(Me.txtValorDI, "txtValorDI")
        Me.txtValorDI.Name = "txtValorDI"
        Me.txtValorDI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'btnArquivoDI
        '
        resources.ApplyResources(Me.btnArquivoDI, "btnArquivoDI")
        Me.btnArquivoDI.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivoDI.Name = "btnArquivoDI"
        Me.btnArquivoDI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivoDI.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivoDI
        '
        resources.ApplyResources(Me.lblArquivoDI, "lblArquivoDI")
        Me.lblArquivoDI.Name = "lblArquivoDI"
        '
        'txtArquivoDI
        '
        Me.txtArquivoDI.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.txtArquivoDI, "txtArquivoDI")
        Me.txtArquivoDI.MaxLength = 500
        Me.txtArquivoDI.Name = "txtArquivoDI"
        Me.txtArquivoDI.ReadOnly = True
        Me.txtArquivoDI.TabStop = False
        '
        'lblDataDesembaracoDI
        '
        resources.ApplyResources(Me.lblDataDesembaracoDI, "lblDataDesembaracoDI")
        Me.lblDataDesembaracoDI.Name = "lblDataDesembaracoDI"
        '
        'lblLocalDesembaracoDI
        '
        resources.ApplyResources(Me.lblLocalDesembaracoDI, "lblLocalDesembaracoDI")
        Me.lblLocalDesembaracoDI.Name = "lblLocalDesembaracoDI"
        '
        'lblDataRegistroDI
        '
        resources.ApplyResources(Me.lblDataRegistroDI, "lblDataRegistroDI")
        Me.lblDataRegistroDI.Name = "lblDataRegistroDI"
        '
        'lblNumeroDI
        '
        resources.ApplyResources(Me.lblNumeroDI, "lblNumeroDI")
        Me.lblNumeroDI.Name = "lblNumeroDI"
        '
        'btnExcluirDI
        '
        Me.btnExcluirDI.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirDI.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnExcluirDI, "btnExcluirDI")
        Me.btnExcluirDI.Name = "btnExcluirDI"
        Me.btnExcluirDI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirDI.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirDI
        '
        Me.btnInserirDI.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirDI.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnInserirDI, "btnInserirDI")
        Me.btnInserirDI.Name = "btnInserirDI"
        Me.btnInserirDI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirDI.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboTipoImportacaoDI
        '
        resources.ApplyResources(Me.cboTipoImportacaoDI, "cboTipoImportacaoDI")
        Me.cboTipoImportacaoDI.Name = "cboTipoImportacaoDI"
        Me.cboTipoImportacaoDI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblTipoImportacaoDI
        '
        resources.ApplyResources(Me.lblTipoImportacaoDI, "lblTipoImportacaoDI")
        Me.lblTipoImportacaoDI.Name = "lblTipoImportacaoDI"
        '
        'grdDI
        '
        Me.grdDI.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdDI.AlternatingColors = True
        resources.ApplyResources(Me.grdDI, "grdDI")
        grdDI_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdDI_DesignTimeLayout_Reference_0.Instance"), Object)
        grdDI_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdDI_DesignTimeLayout_Reference_1.Instance"), Object)
        grdDI_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdDI_DesignTimeLayout_Reference_0, grdDI_DesignTimeLayout_Reference_1})
        resources.ApplyResources(grdDI_DesignTimeLayout, "grdDI_DesignTimeLayout")
        Me.grdDI.DesignTimeLayout = grdDI_DesignTimeLayout
        Me.grdDI.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdDI.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdDI.GroupByBoxVisible = False
        Me.grdDI.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdDI.Name = "grdDI"
        Me.grdDI.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdDI.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdDI.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdDI.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdDI.TabStop = False
        Me.grdDI.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdDI.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdDI.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdDI.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdDI.VisualStyleManager = Me.vsmMain
        '
        'pagRE
        '
        Me.pagRE.Controls.Add(Me.grdRE)
        Me.pagRE.Controls.Add(Me.grpRE)
        Me.pagRE.Key = "pagRE"
        resources.ApplyResources(Me.pagRE, "pagRE")
        Me.pagRE.Name = "pagRE"
        Me.pagRE.TabStop = True
        '
        'grdRE
        '
        Me.grdRE.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdRE.AlternatingColors = True
        resources.ApplyResources(Me.grdRE, "grdRE")
        grdRE_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdRE_DesignTimeLayout_Reference_0.Instance"), Object)
        grdRE_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdRE_DesignTimeLayout_Reference_1.Instance"), Object)
        grdRE_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdRE_DesignTimeLayout_Reference_0, grdRE_DesignTimeLayout_Reference_1})
        resources.ApplyResources(grdRE_DesignTimeLayout, "grdRE_DesignTimeLayout")
        Me.grdRE.DesignTimeLayout = grdRE_DesignTimeLayout
        Me.grdRE.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdRE.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdRE.GroupByBoxVisible = False
        Me.grdRE.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdRE.Name = "grdRE"
        Me.grdRE.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdRE.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdRE.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdRE.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdRE.TabStop = False
        Me.grdRE.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdRE.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdRE.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdRE.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdRE.VisualStyleManager = Me.vsmMain
        '
        'grpRE
        '
        Me.grpRE.BackColor = System.Drawing.Color.Transparent
        Me.grpRE.Controls.Add(Me.btnCadastrarContratoCambio)
        Me.grpRE.Controls.Add(Me.cboContratoCambio)
        Me.grpRE.Controls.Add(Me.lblContratoCambio)
        Me.grpRE.Controls.Add(Me.lblValorMoedaCorrenteRE)
        Me.grpRE.Controls.Add(Me.txtValorMoedaCorrenteRE)
        Me.grpRE.Controls.Add(Me.lblFatorCambialRE)
        Me.grpRE.Controls.Add(Me.txtFatorCambialRE)
        Me.grpRE.Controls.Add(Me.cboMoedaRE)
        Me.grpRE.Controls.Add(Me.lblMoedaRE)
        Me.grpRE.Controls.Add(Me.txtValorRE)
        Me.grpRE.Controls.Add(Me.txtLocalEmbarqueRE)
        Me.grpRE.Controls.Add(Me.dtpDataRegistroRE)
        Me.grpRE.Controls.Add(Me.txtNumeroRE)
        Me.grpRE.Controls.Add(Me.lblValorRE)
        Me.grpRE.Controls.Add(Me.lblLocalEmbarqueRE)
        Me.grpRE.Controls.Add(Me.UiButton1)
        Me.grpRE.Controls.Add(Me.lblArquivoRE)
        Me.grpRE.Controls.Add(Me.txtArquivoRE)
        Me.grpRE.Controls.Add(Me.lblDataRegistroRE)
        Me.grpRE.Controls.Add(Me.lblNumeroRE)
        Me.grpRE.Controls.Add(Me.btnExcluirRE)
        Me.grpRE.Controls.Add(Me.btnInserirRE)
        resources.ApplyResources(Me.grpRE, "grpRE")
        Me.grpRE.Name = "grpRE"
        Me.grpRE.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpRE.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpRE.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarContratoCambio
        '
        Me.btnCadastrarContratoCambio.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarContratoCambio, "btnCadastrarContratoCambio")
        Me.btnCadastrarContratoCambio.Name = "btnCadastrarContratoCambio"
        Me.btnCadastrarContratoCambio.TabStop = False
        Me.btnCadastrarContratoCambio.UseVisualStyleBackColor = True
        '
        'cboContratoCambio
        '
        resources.ApplyResources(Me.cboContratoCambio, "cboContratoCambio")
        Me.cboContratoCambio.Name = "cboContratoCambio"
        Me.cboContratoCambio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblContratoCambio
        '
        resources.ApplyResources(Me.lblContratoCambio, "lblContratoCambio")
        Me.lblContratoCambio.Name = "lblContratoCambio"
        '
        'lblValorMoedaCorrenteRE
        '
        resources.ApplyResources(Me.lblValorMoedaCorrenteRE, "lblValorMoedaCorrenteRE")
        Me.lblValorMoedaCorrenteRE.Name = "lblValorMoedaCorrenteRE"
        '
        'txtValorMoedaCorrenteRE
        '
        Me.txtValorMoedaCorrenteRE.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.txtValorMoedaCorrenteRE, "txtValorMoedaCorrenteRE")
        Me.txtValorMoedaCorrenteRE.Name = "txtValorMoedaCorrenteRE"
        Me.txtValorMoedaCorrenteRE.ReadOnly = True
        Me.txtValorMoedaCorrenteRE.TabStop = False
        Me.txtValorMoedaCorrenteRE.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblFatorCambialRE
        '
        resources.ApplyResources(Me.lblFatorCambialRE, "lblFatorCambialRE")
        Me.lblFatorCambialRE.Name = "lblFatorCambialRE"
        '
        'txtFatorCambialRE
        '
        Me.txtFatorCambialRE.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.txtFatorCambialRE, "txtFatorCambialRE")
        Me.txtFatorCambialRE.Name = "txtFatorCambialRE"
        Me.txtFatorCambialRE.ReadOnly = True
        Me.txtFatorCambialRE.TabStop = False
        Me.txtFatorCambialRE.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'cboMoedaRE
        '
        resources.ApplyResources(Me.cboMoedaRE, "cboMoedaRE")
        Me.cboMoedaRE.Name = "cboMoedaRE"
        Me.cboMoedaRE.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblMoedaRE
        '
        resources.ApplyResources(Me.lblMoedaRE, "lblMoedaRE")
        Me.lblMoedaRE.Name = "lblMoedaRE"
        '
        'txtValorRE
        '
        resources.ApplyResources(Me.txtValorRE, "txtValorRE")
        Me.txtValorRE.Name = "txtValorRE"
        Me.txtValorRE.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtLocalEmbarqueRE
        '
        Me.txtLocalEmbarqueRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtLocalEmbarqueRE, "txtLocalEmbarqueRE")
        Me.txtLocalEmbarqueRE.MaxLength = 60
        Me.txtLocalEmbarqueRE.Name = "txtLocalEmbarqueRE"
        '
        'dtpDataRegistroRE
        '
        '
        '
        '
        Me.dtpDataRegistroRE.DropDownCalendar.Name = ""
        resources.ApplyResources(Me.dtpDataRegistroRE, "dtpDataRegistroRE")
        Me.dtpDataRegistroRE.Name = "dtpDataRegistroRE"
        Me.dtpDataRegistroRE.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'txtNumeroRE
        '
        resources.ApplyResources(Me.txtNumeroRE, "txtNumeroRE")
        Me.txtNumeroRE.MaxLength = 20
        Me.txtNumeroRE.Name = "txtNumeroRE"
        '
        'lblValorRE
        '
        resources.ApplyResources(Me.lblValorRE, "lblValorRE")
        Me.lblValorRE.Name = "lblValorRE"
        '
        'lblLocalEmbarqueRE
        '
        resources.ApplyResources(Me.lblLocalEmbarqueRE, "lblLocalEmbarqueRE")
        Me.lblLocalEmbarqueRE.Name = "lblLocalEmbarqueRE"
        '
        'UiButton1
        '
        resources.ApplyResources(Me.UiButton1, "UiButton1")
        Me.UiButton1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiButton1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivoRE
        '
        resources.ApplyResources(Me.lblArquivoRE, "lblArquivoRE")
        Me.lblArquivoRE.Name = "lblArquivoRE"
        '
        'txtArquivoRE
        '
        Me.txtArquivoRE.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.txtArquivoRE, "txtArquivoRE")
        Me.txtArquivoRE.MaxLength = 100
        Me.txtArquivoRE.Name = "txtArquivoRE"
        Me.txtArquivoRE.ReadOnly = True
        Me.txtArquivoRE.TabStop = False
        '
        'lblDataRegistroRE
        '
        resources.ApplyResources(Me.lblDataRegistroRE, "lblDataRegistroRE")
        Me.lblDataRegistroRE.Name = "lblDataRegistroRE"
        '
        'lblNumeroRE
        '
        resources.ApplyResources(Me.lblNumeroRE, "lblNumeroRE")
        Me.lblNumeroRE.Name = "lblNumeroRE"
        '
        'btnExcluirRE
        '
        Me.btnExcluirRE.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirRE.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnExcluirRE, "btnExcluirRE")
        Me.btnExcluirRE.Name = "btnExcluirRE"
        Me.btnExcluirRE.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirRE.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirRE
        '
        Me.btnInserirRE.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirRE.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnInserirRE, "btnInserirRE")
        Me.btnInserirRE.Name = "btnInserirRE"
        Me.btnInserirRE.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirRE.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagLaudoTecnico
        '
        Me.pagLaudoTecnico.Controls.Add(Me.grpProduto)
        Me.pagLaudoTecnico.Controls.Add(Me.grdProduto)
        Me.pagLaudoTecnico.Key = "pagLaudoTecnico"
        resources.ApplyResources(Me.pagLaudoTecnico, "pagLaudoTecnico")
        Me.pagLaudoTecnico.Name = "pagLaudoTecnico"
        Me.pagLaudoTecnico.TabStop = True
        '
        'grpProduto
        '
        Me.grpProduto.BackColor = System.Drawing.Color.Transparent
        Me.grpProduto.Controls.Add(Me.btnCadastrarProduto)
        Me.grpProduto.Controls.Add(Me.cboCodigoProduto)
        Me.grpProduto.Controls.Add(Me.lblCodigoProduto)
        Me.grpProduto.Controls.Add(Me.lblDescricaoProduto)
        Me.grpProduto.Controls.Add(Me.txtDescricaoProduto)
        Me.grpProduto.Controls.Add(Me.btnExcluirProduto)
        Me.grpProduto.Controls.Add(Me.btnInserirProduto)
        resources.ApplyResources(Me.grpProduto, "grpProduto")
        Me.grpProduto.Name = "grpProduto"
        Me.grpProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpProduto.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpProduto.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarProduto
        '
        Me.btnCadastrarProduto.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarProduto, "btnCadastrarProduto")
        Me.btnCadastrarProduto.Name = "btnCadastrarProduto"
        Me.btnCadastrarProduto.TabStop = False
        Me.btnCadastrarProduto.UseVisualStyleBackColor = True
        '
        'cboCodigoProduto
        '
        resources.ApplyResources(Me.cboCodigoProduto, "cboCodigoProduto")
        Me.cboCodigoProduto.Name = "cboCodigoProduto"
        Me.cboCodigoProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblCodigoProduto
        '
        resources.ApplyResources(Me.lblCodigoProduto, "lblCodigoProduto")
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        '
        'lblDescricaoProduto
        '
        resources.ApplyResources(Me.lblDescricaoProduto, "lblDescricaoProduto")
        Me.lblDescricaoProduto.Name = "lblDescricaoProduto"
        '
        'txtDescricaoProduto
        '
        Me.txtDescricaoProduto.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.txtDescricaoProduto, "txtDescricaoProduto")
        Me.txtDescricaoProduto.MaxLength = 120
        Me.txtDescricaoProduto.Name = "txtDescricaoProduto"
        Me.txtDescricaoProduto.ReadOnly = True
        Me.txtDescricaoProduto.TabStop = False
        '
        'btnExcluirProduto
        '
        Me.btnExcluirProduto.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnExcluirProduto, "btnExcluirProduto")
        Me.btnExcluirProduto.Name = "btnExcluirProduto"
        Me.btnExcluirProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirProduto
        '
        Me.btnInserirProduto.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnInserirProduto, "btnInserirProduto")
        Me.btnInserirProduto.Name = "btnInserirProduto"
        Me.btnInserirProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdProduto
        '
        Me.grdProduto.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdProduto.AlternatingColors = True
        resources.ApplyResources(Me.grdProduto, "grdProduto")
        grdProduto_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdProduto_DesignTimeLayout_Reference_0.Instance"), Object)
        grdProduto_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdProduto_DesignTimeLayout_Reference_0})
        resources.ApplyResources(grdProduto_DesignTimeLayout, "grdProduto_DesignTimeLayout")
        Me.grdProduto.DesignTimeLayout = grdProduto_DesignTimeLayout
        Me.grdProduto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProduto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProduto.GroupByBoxVisible = False
        Me.grdProduto.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdProduto.Name = "grdProduto"
        Me.grdProduto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProduto.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdProduto.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdProduto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProduto.TabStop = False
        Me.grdProduto.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProduto.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdProduto.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdProduto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdProduto.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        resources.ApplyResources(Me.grpControl2, "grpControl2")
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnNovo, "btnNovo")
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnVoltar, "btnVoltar")
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnSalvar, "btnSalvar")
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Key = "pagVendas"
        resources.ApplyResources(Me.UiTabPage1, "UiTabPage1")
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.TabStop = True
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 3000
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'usrCadAtoConcessorio
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrCadAtoConcessorio"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaBaixado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaFechado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaAberto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagResumo.ResumeLayout(False)
        CType(Me.chrAtoConcessorio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDI.ResumeLayout(False)
        CType(Me.grpDI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDI.ResumeLayout(False)
        Me.grpDI.PerformLayout()
        CType(Me.grdDI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagRE.ResumeLayout(False)
        CType(Me.grdRE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpRE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRE.ResumeLayout(False)
        Me.grpRE.PerformLayout()
        Me.pagLaudoTecnico.ResumeLayout(False)
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProduto.ResumeLayout(False)
        Me.grpProduto.PerformLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagResumo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDI As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdDI As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNumeroAtoConcessorio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroAtoConcessorio As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDataValidade As System.Windows.Forms.Label
    Friend WithEvents dtpDataValidade As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataAbertura As System.Windows.Forms.Label
    Friend WithEvents dtpDataAbertura As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblValorExportado As System.Windows.Forms.Label
    Friend WithEvents txtValorExportado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorImportado As System.Windows.Forms.Label
    Friend WithEvents txtValorImportado As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents chrAtoConcessorio As Dundas.Charting.WinControl.Chart
    Friend WithEvents pagRE As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDI As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnArquivoDI As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivoDI As System.Windows.Forms.Label
    Friend WithEvents txtArquivoDI As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataDesembaracoDI As System.Windows.Forms.Label
    Friend WithEvents lblLocalDesembaracoDI As System.Windows.Forms.Label
    Friend WithEvents lblDataRegistroDI As System.Windows.Forms.Label
    Friend WithEvents lblNumeroDI As System.Windows.Forms.Label
    Friend WithEvents btnExcluirDI As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirDI As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpRE As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLocalEmbarqueRE As System.Windows.Forms.Label
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivoRE As System.Windows.Forms.Label
    Friend WithEvents txtArquivoRE As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataRegistroRE As System.Windows.Forms.Label
    Friend WithEvents lblNumeroRE As System.Windows.Forms.Label
    Friend WithEvents btnExcluirRE As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirRE As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataVigenteFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataVigenteFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtNumeroAtoConcessorioFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroAtoConcessorioFiltro As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblTipoAtoConcessorio As System.Windows.Forms.Label
    Friend WithEvents btnArquivoAtoConcessorio As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivoAtoConcessorio As System.Windows.Forms.Label
    Friend WithEvents txtArquivoAtoConcessorio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtStatusAtoConcessorio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblStatusAtoConcessorio As System.Windows.Forms.Label
    Friend WithEvents lblSaldoAtoConcessorio As System.Windows.Forms.Label
    Friend WithEvents txtSaldoAtoConcessorio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboModalidadeAtoConcessorio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblModalidadeAtoConcessorio As System.Windows.Forms.Label
    Friend WithEvents cboTipoAtoConcessorio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboStatusFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents cboModalidadeAtoConcessorioFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblModalidadeAtoConcessorioFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoAtoConcessorioFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoAtoConcessorioFiltro As System.Windows.Forms.Label
    Friend WithEvents lblValorDI As System.Windows.Forms.Label
    Friend WithEvents txtValorDI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorRE As System.Windows.Forms.Label
    Friend WithEvents lblValorMoedaCorrenteDI As System.Windows.Forms.Label
    Friend WithEvents txtValorMoedaCorrenteDI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblFatorCambialDI As System.Windows.Forms.Label
    Friend WithEvents txtFatorCambialDI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboMoedaDI As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMoedaDI As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDI As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataRegistroDI As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtLocalDesembaracoDI As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataDesembaracoDI As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboTipoImportacaoDI As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoImportacaoDI As System.Windows.Forms.Label
    Friend WithEvents txtLocalEmbarqueRE As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataRegistroRE As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtNumeroRE As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents pagLaudoTecnico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents cboContratoCambio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblContratoCambio As System.Windows.Forms.Label
    Friend WithEvents lblValorMoedaCorrenteRE As System.Windows.Forms.Label
    Friend WithEvents txtValorMoedaCorrenteRE As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblFatorCambialRE As System.Windows.Forms.Label
    Friend WithEvents txtFatorCambialRE As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboMoedaRE As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMoedaRE As System.Windows.Forms.Label
    Friend WithEvents txtValorRE As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnCadastrarContratoCambio As System.Windows.Forms.Button
    Friend WithEvents grdRE As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdProduto As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpProduto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarProduto As System.Windows.Forms.Button
    Friend WithEvents cboCodigoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoProduto As System.Windows.Forms.Label
    Friend WithEvents lblDescricaoProduto As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnExcluirProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirProduto As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaBaixado As System.Windows.Forms.Label
    Friend WithEvents picLegendaBaixado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaFechado As System.Windows.Forms.Label
    Friend WithEvents picLegendaFechado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAberto As System.Windows.Forms.Label
    Friend WithEvents picLegendaAberto As System.Windows.Forms.PictureBox

End Class
