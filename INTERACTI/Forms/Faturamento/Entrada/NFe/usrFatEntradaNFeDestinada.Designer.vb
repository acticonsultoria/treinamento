<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFatEntradaNFeDestinada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFatEntradaNFeDestinada))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdListagem_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.Image")
        Dim grdListagem_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.Image")
        Dim grdListagem_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.Image")
        Dim grdListagem_DesignTimeLayout_Reference_5 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.Image")
        Dim grdListagem_DesignTimeLayout_Reference_6 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column7.Image")
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdCCe_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdNFeCancelada_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagNFe = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaNFeBaixada = New System.Windows.Forms.Label()
        Me.picLegendaNFeBaixada = New System.Windows.Forms.PictureBox()
        Me.lblLegendaNFeManifestada = New System.Windows.Forms.Label()
        Me.picLegendaNFeManifestada = New System.Windows.Forms.PictureBox()
        Me.lblLegendaNFeEntrada = New System.Windows.Forms.Label()
        Me.picLegendaNFeEntrada = New System.Windows.Forms.PictureBox()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkListarCTeCancelado = New System.Windows.Forms.CheckBox()
        Me.chkSomentePendencia = New System.Windows.Forms.CheckBox()
        Me.cboTipoDocumentoFiscalFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoTipoDocumentoFiscalFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.txtEmitenteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNotaFiscalFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEmitenteFiltro = New System.Windows.Forms.Label()
        Me.lblNotaFiscalFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.grpControleNFe = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImportarCTe = New Janus.Windows.EditControls.UIButton()
        Me.btnManifestarRecebimento = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvarArquivoXML = New Janus.Windows.EditControls.UIButton()
        Me.btnAtualizarConsulta = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagCartaCorrecao = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridCCe = New System.Windows.Forms.Button()
        Me.btnAgruparGridCCe = New System.Windows.Forms.Button()
        Me.grpControleCCe = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSairCCe = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltroCCe = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtEmitenteCCeFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNotaFiscalCCeFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEmitenteCCeFiltro = New System.Windows.Forms.Label()
        Me.lblNotaFiscalCCeFiltro = New System.Windows.Forms.Label()
        Me.dtpDataEmissaoInicioCCeFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoTerminoCCeFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissaoCCeFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrarCCe = New Janus.Windows.EditControls.UIButton()
        Me.btnConfigurarGridCCe = New System.Windows.Forms.Button()
        Me.grdCCe = New Janus.Windows.GridEX.GridEX()
        Me.pagNFeCancelada = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridNFeCancelada = New System.Windows.Forms.Button()
        Me.btnAgruparGridNFeCancelada = New System.Windows.Forms.Button()
        Me.grpFiltroNFeCancelada = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtEmitenteNFeCanceladaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNotaFiscalNFeCanceladaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEmitenteNFeCanceladaFiltro = New System.Windows.Forms.Label()
        Me.lblNotaFiscalCanceladaFiltro = New System.Windows.Forms.Label()
        Me.dtpDataEmissaoInicioNFeCanceladaFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoTerminoNFeCanceladaFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissaoNFeCanceladaFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrarNFeCancelada = New Janus.Windows.EditControls.UIButton()
        Me.grpControleNFeCancelada = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSairNFeCancelada = New Janus.Windows.EditControls.UIButton()
        Me.btnConfigurarGridNFeCancelada = New System.Windows.Forms.Button()
        Me.grdNFeCancelada = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabMain.SuspendLayout
        Me.pagNFe.SuspendLayout
        CType(Me.grdListagem,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grpLegenda,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpLegenda.SuspendLayout
        CType(Me.picLegendaNFeBaixada,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picLegendaNFeManifestada,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picLegendaNFeEntrada,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grpFiltro,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpFiltro.SuspendLayout
        CType(Me.grpControleNFe,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpControleNFe.SuspendLayout
        Me.pagCartaCorrecao.SuspendLayout
        CType(Me.grpControleCCe,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpControleCCe.SuspendLayout
        CType(Me.grpFiltroCCe,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpFiltroCCe.SuspendLayout
        CType(Me.grdCCe,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pagNFeCancelada.SuspendLayout
        CType(Me.grpFiltroNFeCancelada,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpFiltroNFeCancelada.SuspendLayout
        CType(Me.grpControleNFeCancelada,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpControleNFeCancelada.SuspendLayout
        CType(Me.grdNFeCancelada,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
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
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = false
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagNFe, Me.pagCartaCorrecao, Me.pagNFeCancelada})
        Me.tabMain.TabStop = false
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagNFe
        '
        Me.pagNFe.Controls.Add(Me.btnExcelGrid)
        Me.pagNFe.Controls.Add(Me.btnAgruparGrid)
        Me.pagNFe.Controls.Add(Me.btnConfigurarGrid)
        Me.pagNFe.Controls.Add(Me.grdListagem)
        Me.pagNFe.Controls.Add(Me.grpLegenda)
        Me.pagNFe.Controls.Add(Me.grpFiltro)
        Me.pagNFe.Controls.Add(Me.grpControleNFe)
        Me.pagNFe.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagNFe.Key = "pagNFe"
        Me.pagNFe.Location = New System.Drawing.Point(1, 22)
        Me.pagNFe.Name = "pagNFe"
        Me.pagNFe.Size = New System.Drawing.Size(913, 543)
        Me.pagNFe.TabStop = true
        Me.pagNFe.Text = "NF-e Destinada"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 442)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 3
        Me.btnExcelGrid.TabStop = false
        Me.btnExcelGrid.UseVisualStyleBackColor = false
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 442)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 2
        Me.btnAgruparGrid.TabStop = false
        Me.btnAgruparGrid.UseVisualStyleBackColor = false
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 442)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 1
        Me.btnConfigurarGrid.TabStop = false
        Me.btnConfigurarGrid.UseVisualStyleBackColor = false
        '
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = true
        Me.grdListagem.AlternatingColors = true
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"),Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"),Object)
        grdListagem_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_2.Instance"),Object)
        grdListagem_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_3.Instance"),Object)
        grdListagem_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_4.Instance"),Object)
        grdListagem_DesignTimeLayout_Reference_5.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_5.Instance"),Object)
        grdListagem_DesignTimeLayout_Reference_6.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_6.Instance"),Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1, grdListagem_DesignTimeLayout_Reference_2, grdListagem_DesignTimeLayout_Reference_3, grdListagem_DesignTimeLayout_Reference_4, grdListagem_DesignTimeLayout_Reference_5, grdListagem_DesignTimeLayout_Reference_6})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = false
        Me.grdListagem.Hierarchical = true
        Me.grdListagem.Location = New System.Drawing.Point(8, 117)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = true
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 342)
        Me.grdListagem.TabIndex = 0
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaNFeBaixada)
        Me.grpLegenda.Controls.Add(Me.picLegendaNFeBaixada)
        Me.grpLegenda.Controls.Add(Me.lblLegendaNFeManifestada)
        Me.grpLegenda.Controls.Add(Me.picLegendaNFeManifestada)
        Me.grpLegenda.Controls.Add(Me.lblLegendaNFeEntrada)
        Me.grpLegenda.Controls.Add(Me.picLegendaNFeEntrada)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 466)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(316, 68)
        Me.grpLegenda.TabIndex = 4
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaNFeBaixada
        '
        Me.lblLegendaNFeBaixada.AutoSize = true
        Me.lblLegendaNFeBaixada.Location = New System.Drawing.Point(123, 21)
        Me.lblLegendaNFeBaixada.Name = "lblLegendaNFeBaixada"
        Me.lblLegendaNFeBaixada.Size = New System.Drawing.Size(72, 14)
        Me.lblLegendaNFeBaixada.TabIndex = 1
        Me.lblLegendaNFeBaixada.Text = "NF-e Baixada"
        '
        'picLegendaNFeBaixada
        '
        Me.picLegendaNFeBaixada.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaNFeBaixada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaNFeBaixada.Location = New System.Drawing.Point(104, 21)
        Me.picLegendaNFeBaixada.Name = "picLegendaNFeBaixada"
        Me.picLegendaNFeBaixada.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaNFeBaixada.TabIndex = 12
        Me.picLegendaNFeBaixada.TabStop = false
        '
        'lblLegendaNFeManifestada
        '
        Me.lblLegendaNFeManifestada.AutoSize = true
        Me.lblLegendaNFeManifestada.Location = New System.Drawing.Point(220, 21)
        Me.lblLegendaNFeManifestada.Name = "lblLegendaNFeManifestada"
        Me.lblLegendaNFeManifestada.Size = New System.Drawing.Size(92, 14)
        Me.lblLegendaNFeManifestada.TabIndex = 2
        Me.lblLegendaNFeManifestada.Text = "NF-e Manifestada"
        '
        'picLegendaNFeManifestada
        '
        Me.picLegendaNFeManifestada.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaNFeManifestada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaNFeManifestada.Location = New System.Drawing.Point(201, 21)
        Me.picLegendaNFeManifestada.Name = "picLegendaNFeManifestada"
        Me.picLegendaNFeManifestada.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaNFeManifestada.TabIndex = 10
        Me.picLegendaNFeManifestada.TabStop = false
        '
        'lblLegendaNFeEntrada
        '
        Me.lblLegendaNFeEntrada.AutoSize = true
        Me.lblLegendaNFeEntrada.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaNFeEntrada.Name = "lblLegendaNFeEntrada"
        Me.lblLegendaNFeEntrada.Size = New System.Drawing.Size(70, 14)
        Me.lblLegendaNFeEntrada.TabIndex = 0
        Me.lblLegendaNFeEntrada.Text = "NF-e Entrada"
        '
        'picLegendaNFeEntrada
        '
        Me.picLegendaNFeEntrada.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaNFeEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaNFeEntrada.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaNFeEntrada.Name = "picLegendaNFeEntrada"
        Me.picLegendaNFeEntrada.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaNFeEntrada.TabIndex = 8
        Me.picLegendaNFeEntrada.TabStop = false
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.chkListarCTeCancelado)
        Me.grpFiltro.Controls.Add(Me.chkSomentePendencia)
        Me.grpFiltro.Controls.Add(Me.cboTipoDocumentoFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoTipoDocumentoFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.txtEmitenteFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.lblEmitenteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'chkListarCTeCancelado
        '
        Me.chkListarCTeCancelado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkListarCTeCancelado.Checked = true
        Me.chkListarCTeCancelado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkListarCTeCancelado.Location = New System.Drawing.Point(702, 22)
        Me.chkListarCTeCancelado.Name = "chkListarCTeCancelado"
        Me.chkListarCTeCancelado.Size = New System.Drawing.Size(89, 43)
        Me.chkListarCTeCancelado.TabIndex = 41
        Me.chkListarCTeCancelado.Text = "Listar CT-e cancelado"
        Me.chkListarCTeCancelado.UseVisualStyleBackColor = true
        '
        'chkSomentePendencia
        '
        Me.chkSomentePendencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkSomentePendencia.Checked = true
        Me.chkSomentePendencia.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSomentePendencia.Location = New System.Drawing.Point(802, 22)
        Me.chkSomentePendencia.Name = "chkSomentePendencia"
        Me.chkSomentePendencia.Size = New System.Drawing.Size(89, 43)
        Me.chkSomentePendencia.TabIndex = 40
        Me.chkSomentePendencia.Text = "Somente Pendências"
        Me.chkSomentePendencia.UseVisualStyleBackColor = true
        '
        'cboTipoDocumentoFiscalFiltro
        '
        Me.cboTipoDocumentoFiscalFiltro.AutoSize = false
        Me.cboTipoDocumentoFiscalFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoDocumentoFiscalFiltro.Location = New System.Drawing.Point(237, 74)
        Me.cboTipoDocumentoFiscalFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoDocumentoFiscalFiltro.Name = "cboTipoDocumentoFiscalFiltro"
        Me.cboTipoDocumentoFiscalFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoDocumentoFiscalFiltro.Size = New System.Drawing.Size(108, 20)
        Me.cboTipoDocumentoFiscalFiltro.TabIndex = 10
        '
        'lblCodigoTipoDocumentoFiscalFiltro
        '
        Me.lblCodigoTipoDocumentoFiscalFiltro.AutoSize = true
        Me.lblCodigoTipoDocumentoFiscalFiltro.Location = New System.Drawing.Point(234, 57)
        Me.lblCodigoTipoDocumentoFiscalFiltro.Name = "lblCodigoTipoDocumentoFiscalFiltro"
        Me.lblCodigoTipoDocumentoFiscalFiltro.Size = New System.Drawing.Size(102, 14)
        Me.lblCodigoTipoDocumentoFiscalFiltro.TabIndex = 9
        Me.lblCodigoTipoDocumentoFiscalFiltro.Text = "Tipo do Documento:"
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = true
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(9, 74)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = false
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(222, 20)
        Me.cboStatusFiltro.TabIndex = 8
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = true
        Me.lblStatusFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 7
        Me.lblStatusFiltro.Text = "Status:"
        '
        'txtEmitenteFiltro
        '
        Me.txtEmitenteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmitenteFiltro.Location = New System.Drawing.Point(351, 34)
        Me.txtEmitenteFiltro.MaxLength = 50
        Me.txtEmitenteFiltro.Name = "txtEmitenteFiltro"
        Me.txtEmitenteFiltro.Size = New System.Drawing.Size(440, 20)
        Me.txtEmitenteFiltro.TabIndex = 6
        '
        'txtNotaFiscalFiltro
        '
        Me.txtNotaFiscalFiltro.IncludeLiterals = false
        Me.txtNotaFiscalFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNotaFiscalFiltro.Name = "txtNotaFiscalFiltro"
        Me.txtNotaFiscalFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNotaFiscalFiltro.Size = New System.Drawing.Size(108, 20)
        Me.txtNotaFiscalFiltro.TabIndex = 1
        '
        'lblEmitenteFiltro
        '
        Me.lblEmitenteFiltro.AutoSize = true
        Me.lblEmitenteFiltro.Location = New System.Drawing.Point(348, 17)
        Me.lblEmitenteFiltro.Name = "lblEmitenteFiltro"
        Me.lblEmitenteFiltro.Size = New System.Drawing.Size(50, 14)
        Me.lblEmitenteFiltro.TabIndex = 5
        Me.lblEmitenteFiltro.Text = "Emitente:"
        '
        'lblNotaFiscalFiltro
        '
        Me.lblNotaFiscalFiltro.AutoSize = true
        Me.lblNotaFiscalFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNotaFiscalFiltro.Name = "lblNotaFiscalFiltro"
        Me.lblNotaFiscalFiltro.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscalFiltro.TabIndex = 0
        Me.lblNotaFiscalFiltro.Text = "Nota Fiscal:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 11
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'dtpDataEmissaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(123, 34)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = true
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 3
        Me.dtpDataEmissaoInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataEmissaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(237, 34)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = true
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 4
        Me.dtpDataEmissaoTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = true
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(120, 17)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 2
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'grpControleNFe
        '
        Me.grpControleNFe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpControleNFe.BackColor = System.Drawing.Color.Transparent
        Me.grpControleNFe.Controls.Add(Me.btnImportarCTe)
        Me.grpControleNFe.Controls.Add(Me.btnManifestarRecebimento)
        Me.grpControleNFe.Controls.Add(Me.btnSalvarArquivoXML)
        Me.grpControleNFe.Controls.Add(Me.btnAtualizarConsulta)
        Me.grpControleNFe.Controls.Add(Me.btnSair)
        Me.grpControleNFe.Location = New System.Drawing.Point(333, 463)
        Me.grpControleNFe.Name = "grpControleNFe"
        Me.grpControleNFe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleNFe.Size = New System.Drawing.Size(572, 71)
        Me.grpControleNFe.TabIndex = 5
        Me.grpControleNFe.VisualStyleManager = Me.vsmMain
        '
        'btnImportarCTe
        '
        Me.btnImportarCTe.Image = Global.INTERACTI.My.Resources.Resources.download
        Me.btnImportarCTe.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarCTe.Location = New System.Drawing.Point(157, 13)
        Me.btnImportarCTe.Name = "btnImportarCTe"
        Me.btnImportarCTe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportarCTe.Size = New System.Drawing.Size(145, 23)
        Me.btnImportarCTe.TabIndex = 5
        Me.btnImportarCTe.Text = "Importar CT-e Destinada"
        Me.btnImportarCTe.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnManifestarRecebimento
        '
        Me.btnManifestarRecebimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnManifestarRecebimento.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnManifestarRecebimento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnManifestarRecebimento.Location = New System.Drawing.Point(6, 42)
        Me.btnManifestarRecebimento.Name = "btnManifestarRecebimento"
        Me.btnManifestarRecebimento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnManifestarRecebimento.Size = New System.Drawing.Size(145, 23)
        Me.btnManifestarRecebimento.TabIndex = 1
        Me.btnManifestarRecebimento.Text = "Manifestar Recebimento"
        Me.btnManifestarRecebimento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvarArquivoXML
        '
        Me.btnSalvarArquivoXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSalvarArquivoXML.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvarArquivoXML.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvarArquivoXML.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvarArquivoXML.Location = New System.Drawing.Point(321, 42)
        Me.btnSalvarArquivoXML.Name = "btnSalvarArquivoXML"
        Me.btnSalvarArquivoXML.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvarArquivoXML.Size = New System.Drawing.Size(145, 23)
        Me.btnSalvarArquivoXML.TabIndex = 2
        Me.btnSalvarArquivoXML.Text = "Salvar Arquivo XML"
        Me.btnSalvarArquivoXML.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAtualizarConsulta
        '
        Me.btnAtualizarConsulta.Image = Global.INTERACTI.My.Resources.Resources.download
        Me.btnAtualizarConsulta.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAtualizarConsulta.Location = New System.Drawing.Point(6, 13)
        Me.btnAtualizarConsulta.Name = "btnAtualizarConsulta"
        Me.btnAtualizarConsulta.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAtualizarConsulta.Size = New System.Drawing.Size(145, 23)
        Me.btnAtualizarConsulta.TabIndex = 0
        Me.btnAtualizarConsulta.Text = "Importar NF-e Destinada"
        Me.btnAtualizarConsulta.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(472, 42)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagCartaCorrecao
        '
        Me.pagCartaCorrecao.Controls.Add(Me.btnExcelGridCCe)
        Me.pagCartaCorrecao.Controls.Add(Me.btnAgruparGridCCe)
        Me.pagCartaCorrecao.Controls.Add(Me.grpControleCCe)
        Me.pagCartaCorrecao.Controls.Add(Me.grpFiltroCCe)
        Me.pagCartaCorrecao.Controls.Add(Me.btnConfigurarGridCCe)
        Me.pagCartaCorrecao.Controls.Add(Me.grdCCe)
        Me.pagCartaCorrecao.Key = "pagCartaCorrecao"
        Me.pagCartaCorrecao.Location = New System.Drawing.Point(1, 22)
        Me.pagCartaCorrecao.Name = "pagCartaCorrecao"
        Me.pagCartaCorrecao.Size = New System.Drawing.Size(913, 543)
        Me.pagCartaCorrecao.TabStop = true
        Me.pagCartaCorrecao.Text = "NF-e Carta de Correção"
        '
        'btnExcelGridCCe
        '
        Me.btnExcelGridCCe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridCCe.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridCCe.FlatAppearance.BorderSize = 0
        Me.btnExcelGridCCe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridCCe.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridCCe.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridCCe.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGridCCe.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridCCe.Name = "btnExcelGridCCe"
        Me.btnExcelGridCCe.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridCCe.TabIndex = 5
        Me.btnExcelGridCCe.TabStop = false
        Me.btnExcelGridCCe.UseVisualStyleBackColor = false
        '
        'btnAgruparGridCCe
        '
        Me.btnAgruparGridCCe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridCCe.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridCCe.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridCCe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridCCe.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridCCe.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridCCe.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGridCCe.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridCCe.Name = "btnAgruparGridCCe"
        Me.btnAgruparGridCCe.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridCCe.TabIndex = 4
        Me.btnAgruparGridCCe.TabStop = false
        Me.btnAgruparGridCCe.UseVisualStyleBackColor = false
        '
        'grpControleCCe
        '
        Me.grpControleCCe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpControleCCe.BackColor = System.Drawing.Color.Transparent
        Me.grpControleCCe.Controls.Add(Me.btnSairCCe)
        Me.grpControleCCe.Location = New System.Drawing.Point(8, 483)
        Me.grpControleCCe.Name = "grpControleCCe"
        Me.grpControleCCe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleCCe.Size = New System.Drawing.Size(897, 51)
        Me.grpControleCCe.TabIndex = 3
        Me.grpControleCCe.VisualStyleManager = Me.vsmMain
        '
        'btnSairCCe
        '
        Me.btnSairCCe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSairCCe.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSairCCe.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSairCCe.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSairCCe.Location = New System.Drawing.Point(797, 17)
        Me.btnSairCCe.Name = "btnSairCCe"
        Me.btnSairCCe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSairCCe.Size = New System.Drawing.Size(91, 23)
        Me.btnSairCCe.TabIndex = 0
        Me.btnSairCCe.Text = "Sair"
        Me.btnSairCCe.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltroCCe
        '
        Me.grpFiltroCCe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpFiltroCCe.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltroCCe.Controls.Add(Me.txtEmitenteCCeFiltro)
        Me.grpFiltroCCe.Controls.Add(Me.txtNotaFiscalCCeFiltro)
        Me.grpFiltroCCe.Controls.Add(Me.lblEmitenteCCeFiltro)
        Me.grpFiltroCCe.Controls.Add(Me.lblNotaFiscalCCeFiltro)
        Me.grpFiltroCCe.Controls.Add(Me.dtpDataEmissaoInicioCCeFiltro)
        Me.grpFiltroCCe.Controls.Add(Me.dtpDataEmissaoTerminoCCeFiltro)
        Me.grpFiltroCCe.Controls.Add(Me.lblDataEmissaoCCeFiltro)
        Me.grpFiltroCCe.Controls.Add(Me.btnFiltrarCCe)
        Me.grpFiltroCCe.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltroCCe.Name = "grpFiltroCCe"
        Me.grpFiltroCCe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltroCCe.Size = New System.Drawing.Size(897, 64)
        Me.grpFiltroCCe.TabIndex = 0
        Me.grpFiltroCCe.VisualStyleManager = Me.vsmMain
        '
        'txtEmitenteCCeFiltro
        '
        Me.txtEmitenteCCeFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtEmitenteCCeFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmitenteCCeFiltro.Location = New System.Drawing.Point(351, 34)
        Me.txtEmitenteCCeFiltro.MaxLength = 50
        Me.txtEmitenteCCeFiltro.Name = "txtEmitenteCCeFiltro"
        Me.txtEmitenteCCeFiltro.Size = New System.Drawing.Size(400, 20)
        Me.txtEmitenteCCeFiltro.TabIndex = 6
        '
        'txtNotaFiscalCCeFiltro
        '
        Me.txtNotaFiscalCCeFiltro.IncludeLiterals = false
        Me.txtNotaFiscalCCeFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNotaFiscalCCeFiltro.Name = "txtNotaFiscalCCeFiltro"
        Me.txtNotaFiscalCCeFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNotaFiscalCCeFiltro.Size = New System.Drawing.Size(108, 20)
        Me.txtNotaFiscalCCeFiltro.TabIndex = 1
        '
        'lblEmitenteCCeFiltro
        '
        Me.lblEmitenteCCeFiltro.AutoSize = true
        Me.lblEmitenteCCeFiltro.Location = New System.Drawing.Point(348, 17)
        Me.lblEmitenteCCeFiltro.Name = "lblEmitenteCCeFiltro"
        Me.lblEmitenteCCeFiltro.Size = New System.Drawing.Size(50, 14)
        Me.lblEmitenteCCeFiltro.TabIndex = 5
        Me.lblEmitenteCCeFiltro.Text = "Emitente:"
        '
        'lblNotaFiscalCCeFiltro
        '
        Me.lblNotaFiscalCCeFiltro.AutoSize = true
        Me.lblNotaFiscalCCeFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNotaFiscalCCeFiltro.Name = "lblNotaFiscalCCeFiltro"
        Me.lblNotaFiscalCCeFiltro.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscalCCeFiltro.TabIndex = 0
        Me.lblNotaFiscalCCeFiltro.Text = "Nota Fiscal:"
        '
        'dtpDataEmissaoInicioCCeFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioCCeFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioCCeFiltro.Location = New System.Drawing.Point(123, 34)
        Me.dtpDataEmissaoInicioCCeFiltro.Name = "dtpDataEmissaoInicioCCeFiltro"
        Me.dtpDataEmissaoInicioCCeFiltro.ShowCheckBox = true
        Me.dtpDataEmissaoInicioCCeFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoInicioCCeFiltro.TabIndex = 3
        Me.dtpDataEmissaoInicioCCeFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataEmissaoTerminoCCeFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoCCeFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoCCeFiltro.Location = New System.Drawing.Point(237, 34)
        Me.dtpDataEmissaoTerminoCCeFiltro.Name = "dtpDataEmissaoTerminoCCeFiltro"
        Me.dtpDataEmissaoTerminoCCeFiltro.ShowCheckBox = true
        Me.dtpDataEmissaoTerminoCCeFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoTerminoCCeFiltro.TabIndex = 4
        Me.dtpDataEmissaoTerminoCCeFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataEmissaoCCeFiltro
        '
        Me.lblDataEmissaoCCeFiltro.AutoSize = true
        Me.lblDataEmissaoCCeFiltro.Location = New System.Drawing.Point(120, 17)
        Me.lblDataEmissaoCCeFiltro.Name = "lblDataEmissaoCCeFiltro"
        Me.lblDataEmissaoCCeFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoCCeFiltro.TabIndex = 2
        Me.lblDataEmissaoCCeFiltro.Text = "Data Emissão:"
        '
        'btnFiltrarCCe
        '
        Me.btnFiltrarCCe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnFiltrarCCe.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrarCCe.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrarCCe.Location = New System.Drawing.Point(797, 31)
        Me.btnFiltrarCCe.Name = "btnFiltrarCCe"
        Me.btnFiltrarCCe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrarCCe.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrarCCe.TabIndex = 7
        Me.btnFiltrarCCe.Text = "Filtrar"
        Me.btnFiltrarCCe.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnConfigurarGridCCe
        '
        Me.btnConfigurarGridCCe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridCCe.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridCCe.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridCCe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridCCe.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridCCe.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridCCe.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGridCCe.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridCCe.Name = "btnConfigurarGridCCe"
        Me.btnConfigurarGridCCe.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridCCe.TabIndex = 2
        Me.btnConfigurarGridCCe.TabStop = false
        Me.btnConfigurarGridCCe.UseVisualStyleBackColor = false
        '
        'grdCCe
        '
        Me.grdCCe.AllowChildTableGroups = true
        Me.grdCCe.AlternatingColors = true
        Me.grdCCe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grdCCe.ColumnAutoResize = true
        grdCCe_DesignTimeLayout.LayoutString = resources.GetString("grdCCe_DesignTimeLayout.LayoutString")
        Me.grdCCe.DesignTimeLayout = grdCCe_DesignTimeLayout
        Me.grdCCe.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdCCe.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdCCe.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdCCe.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdCCe.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdCCe.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdCCe.GroupByBoxVisible = false
        Me.grdCCe.Hierarchical = true
        Me.grdCCe.Location = New System.Drawing.Point(8, 77)
        Me.grdCCe.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdCCe.Name = "grdCCe"
        Me.grdCCe.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdCCe.RecordNavigator = true
        Me.grdCCe.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdCCe.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdCCe.Size = New System.Drawing.Size(897, 403)
        Me.grdCCe.TabIndex = 1
        Me.grdCCe.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdCCe.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdCCe.VisualStyleManager = Me.vsmMain
        '
        'pagNFeCancelada
        '
        Me.pagNFeCancelada.Controls.Add(Me.btnExcelGridNFeCancelada)
        Me.pagNFeCancelada.Controls.Add(Me.btnAgruparGridNFeCancelada)
        Me.pagNFeCancelada.Controls.Add(Me.grpFiltroNFeCancelada)
        Me.pagNFeCancelada.Controls.Add(Me.grpControleNFeCancelada)
        Me.pagNFeCancelada.Controls.Add(Me.btnConfigurarGridNFeCancelada)
        Me.pagNFeCancelada.Controls.Add(Me.grdNFeCancelada)
        Me.pagNFeCancelada.Key = "pagNFeCancelada"
        Me.pagNFeCancelada.Location = New System.Drawing.Point(1, 22)
        Me.pagNFeCancelada.Name = "pagNFeCancelada"
        Me.pagNFeCancelada.Size = New System.Drawing.Size(913, 543)
        Me.pagNFeCancelada.TabStop = true
        Me.pagNFeCancelada.Text = "NF-e Cancelada"
        '
        'btnExcelGridNFeCancelada
        '
        Me.btnExcelGridNFeCancelada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridNFeCancelada.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridNFeCancelada.FlatAppearance.BorderSize = 0
        Me.btnExcelGridNFeCancelada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridNFeCancelada.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridNFeCancelada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridNFeCancelada.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGridNFeCancelada.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridNFeCancelada.Name = "btnExcelGridNFeCancelada"
        Me.btnExcelGridNFeCancelada.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridNFeCancelada.TabIndex = 7
        Me.btnExcelGridNFeCancelada.TabStop = false
        Me.btnExcelGridNFeCancelada.UseVisualStyleBackColor = false
        '
        'btnAgruparGridNFeCancelada
        '
        Me.btnAgruparGridNFeCancelada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridNFeCancelada.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridNFeCancelada.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridNFeCancelada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridNFeCancelada.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridNFeCancelada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridNFeCancelada.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGridNFeCancelada.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridNFeCancelada.Name = "btnAgruparGridNFeCancelada"
        Me.btnAgruparGridNFeCancelada.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridNFeCancelada.TabIndex = 6
        Me.btnAgruparGridNFeCancelada.TabStop = false
        Me.btnAgruparGridNFeCancelada.UseVisualStyleBackColor = false
        '
        'grpFiltroNFeCancelada
        '
        Me.grpFiltroNFeCancelada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpFiltroNFeCancelada.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltroNFeCancelada.Controls.Add(Me.txtEmitenteNFeCanceladaFiltro)
        Me.grpFiltroNFeCancelada.Controls.Add(Me.txtNotaFiscalNFeCanceladaFiltro)
        Me.grpFiltroNFeCancelada.Controls.Add(Me.lblEmitenteNFeCanceladaFiltro)
        Me.grpFiltroNFeCancelada.Controls.Add(Me.lblNotaFiscalCanceladaFiltro)
        Me.grpFiltroNFeCancelada.Controls.Add(Me.dtpDataEmissaoInicioNFeCanceladaFiltro)
        Me.grpFiltroNFeCancelada.Controls.Add(Me.dtpDataEmissaoTerminoNFeCanceladaFiltro)
        Me.grpFiltroNFeCancelada.Controls.Add(Me.lblDataEmissaoNFeCanceladaFiltro)
        Me.grpFiltroNFeCancelada.Controls.Add(Me.btnFiltrarNFeCancelada)
        Me.grpFiltroNFeCancelada.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltroNFeCancelada.Name = "grpFiltroNFeCancelada"
        Me.grpFiltroNFeCancelada.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltroNFeCancelada.Size = New System.Drawing.Size(897, 64)
        Me.grpFiltroNFeCancelada.TabIndex = 0
        Me.grpFiltroNFeCancelada.VisualStyleManager = Me.vsmMain
        '
        'txtEmitenteNFeCanceladaFiltro
        '
        Me.txtEmitenteNFeCanceladaFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtEmitenteNFeCanceladaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmitenteNFeCanceladaFiltro.Location = New System.Drawing.Point(351, 34)
        Me.txtEmitenteNFeCanceladaFiltro.MaxLength = 50
        Me.txtEmitenteNFeCanceladaFiltro.Name = "txtEmitenteNFeCanceladaFiltro"
        Me.txtEmitenteNFeCanceladaFiltro.Size = New System.Drawing.Size(400, 20)
        Me.txtEmitenteNFeCanceladaFiltro.TabIndex = 6
        '
        'txtNotaFiscalNFeCanceladaFiltro
        '
        Me.txtNotaFiscalNFeCanceladaFiltro.IncludeLiterals = false
        Me.txtNotaFiscalNFeCanceladaFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNotaFiscalNFeCanceladaFiltro.Name = "txtNotaFiscalNFeCanceladaFiltro"
        Me.txtNotaFiscalNFeCanceladaFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNotaFiscalNFeCanceladaFiltro.Size = New System.Drawing.Size(108, 20)
        Me.txtNotaFiscalNFeCanceladaFiltro.TabIndex = 1
        '
        'lblEmitenteNFeCanceladaFiltro
        '
        Me.lblEmitenteNFeCanceladaFiltro.AutoSize = true
        Me.lblEmitenteNFeCanceladaFiltro.Location = New System.Drawing.Point(348, 17)
        Me.lblEmitenteNFeCanceladaFiltro.Name = "lblEmitenteNFeCanceladaFiltro"
        Me.lblEmitenteNFeCanceladaFiltro.Size = New System.Drawing.Size(50, 14)
        Me.lblEmitenteNFeCanceladaFiltro.TabIndex = 5
        Me.lblEmitenteNFeCanceladaFiltro.Text = "Emitente:"
        '
        'lblNotaFiscalCanceladaFiltro
        '
        Me.lblNotaFiscalCanceladaFiltro.AutoSize = true
        Me.lblNotaFiscalCanceladaFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNotaFiscalCanceladaFiltro.Name = "lblNotaFiscalCanceladaFiltro"
        Me.lblNotaFiscalCanceladaFiltro.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscalCanceladaFiltro.TabIndex = 0
        Me.lblNotaFiscalCanceladaFiltro.Text = "Nota Fiscal:"
        '
        'dtpDataEmissaoInicioNFeCanceladaFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioNFeCanceladaFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioNFeCanceladaFiltro.Location = New System.Drawing.Point(123, 34)
        Me.dtpDataEmissaoInicioNFeCanceladaFiltro.Name = "dtpDataEmissaoInicioNFeCanceladaFiltro"
        Me.dtpDataEmissaoInicioNFeCanceladaFiltro.ShowCheckBox = true
        Me.dtpDataEmissaoInicioNFeCanceladaFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoInicioNFeCanceladaFiltro.TabIndex = 3
        Me.dtpDataEmissaoInicioNFeCanceladaFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataEmissaoTerminoNFeCanceladaFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoNFeCanceladaFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoNFeCanceladaFiltro.Location = New System.Drawing.Point(237, 34)
        Me.dtpDataEmissaoTerminoNFeCanceladaFiltro.Name = "dtpDataEmissaoTerminoNFeCanceladaFiltro"
        Me.dtpDataEmissaoTerminoNFeCanceladaFiltro.ShowCheckBox = true
        Me.dtpDataEmissaoTerminoNFeCanceladaFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoTerminoNFeCanceladaFiltro.TabIndex = 4
        Me.dtpDataEmissaoTerminoNFeCanceladaFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataEmissaoNFeCanceladaFiltro
        '
        Me.lblDataEmissaoNFeCanceladaFiltro.AutoSize = true
        Me.lblDataEmissaoNFeCanceladaFiltro.Location = New System.Drawing.Point(120, 17)
        Me.lblDataEmissaoNFeCanceladaFiltro.Name = "lblDataEmissaoNFeCanceladaFiltro"
        Me.lblDataEmissaoNFeCanceladaFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoNFeCanceladaFiltro.TabIndex = 2
        Me.lblDataEmissaoNFeCanceladaFiltro.Text = "Data Emissão:"
        '
        'btnFiltrarNFeCancelada
        '
        Me.btnFiltrarNFeCancelada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnFiltrarNFeCancelada.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrarNFeCancelada.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrarNFeCancelada.Location = New System.Drawing.Point(797, 31)
        Me.btnFiltrarNFeCancelada.Name = "btnFiltrarNFeCancelada"
        Me.btnFiltrarNFeCancelada.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrarNFeCancelada.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrarNFeCancelada.TabIndex = 7
        Me.btnFiltrarNFeCancelada.Text = "Filtrar"
        Me.btnFiltrarNFeCancelada.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControleNFeCancelada
        '
        Me.grpControleNFeCancelada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpControleNFeCancelada.BackColor = System.Drawing.Color.Transparent
        Me.grpControleNFeCancelada.Controls.Add(Me.btnSairNFeCancelada)
        Me.grpControleNFeCancelada.Location = New System.Drawing.Point(8, 483)
        Me.grpControleNFeCancelada.Name = "grpControleNFeCancelada"
        Me.grpControleNFeCancelada.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleNFeCancelada.Size = New System.Drawing.Size(897, 51)
        Me.grpControleNFeCancelada.TabIndex = 3
        Me.grpControleNFeCancelada.VisualStyleManager = Me.vsmMain
        '
        'btnSairNFeCancelada
        '
        Me.btnSairNFeCancelada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSairNFeCancelada.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSairNFeCancelada.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSairNFeCancelada.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSairNFeCancelada.Location = New System.Drawing.Point(797, 17)
        Me.btnSairNFeCancelada.Name = "btnSairNFeCancelada"
        Me.btnSairNFeCancelada.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSairNFeCancelada.Size = New System.Drawing.Size(91, 23)
        Me.btnSairNFeCancelada.TabIndex = 0
        Me.btnSairNFeCancelada.Text = "Sair"
        Me.btnSairNFeCancelada.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnConfigurarGridNFeCancelada
        '
        Me.btnConfigurarGridNFeCancelada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridNFeCancelada.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridNFeCancelada.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridNFeCancelada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridNFeCancelada.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridNFeCancelada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridNFeCancelada.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGridNFeCancelada.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridNFeCancelada.Name = "btnConfigurarGridNFeCancelada"
        Me.btnConfigurarGridNFeCancelada.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridNFeCancelada.TabIndex = 2
        Me.btnConfigurarGridNFeCancelada.TabStop = false
        Me.btnConfigurarGridNFeCancelada.UseVisualStyleBackColor = false
        '
        'grdNFeCancelada
        '
        Me.grdNFeCancelada.AllowChildTableGroups = true
        Me.grdNFeCancelada.AlternatingColors = true
        Me.grdNFeCancelada.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grdNFeCancelada.ColumnAutoResize = true
        grdNFeCancelada_DesignTimeLayout.LayoutString = resources.GetString("grdNFeCancelada_DesignTimeLayout.LayoutString")
        Me.grdNFeCancelada.DesignTimeLayout = grdNFeCancelada_DesignTimeLayout
        Me.grdNFeCancelada.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdNFeCancelada.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdNFeCancelada.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdNFeCancelada.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdNFeCancelada.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdNFeCancelada.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdNFeCancelada.GroupByBoxVisible = false
        Me.grdNFeCancelada.Hierarchical = true
        Me.grdNFeCancelada.Location = New System.Drawing.Point(8, 77)
        Me.grdNFeCancelada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdNFeCancelada.Name = "grdNFeCancelada"
        Me.grdNFeCancelada.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdNFeCancelada.RecordNavigator = true
        Me.grdNFeCancelada.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdNFeCancelada.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdNFeCancelada.Size = New System.Drawing.Size(897, 403)
        Me.grdNFeCancelada.TabIndex = 1
        Me.grdNFeCancelada.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdNFeCancelada.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdNFeCancelada.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdNFeCancelada.VisualStyleManager = Me.vsmMain
        '
        'usrFatEntradaNFeDestinada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 14!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFatEntradaNFeDestinada"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabMain.ResumeLayout(false)
        Me.pagNFe.ResumeLayout(false)
        CType(Me.grdListagem,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpLegenda,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpLegenda.ResumeLayout(false)
        Me.grpLegenda.PerformLayout
        CType(Me.picLegendaNFeBaixada,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picLegendaNFeManifestada,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picLegendaNFeEntrada,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpFiltro,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpFiltro.ResumeLayout(false)
        Me.grpFiltro.PerformLayout
        CType(Me.grpControleNFe,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpControleNFe.ResumeLayout(false)
        Me.pagCartaCorrecao.ResumeLayout(false)
        CType(Me.grpControleCCe,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpControleCCe.ResumeLayout(false)
        CType(Me.grpFiltroCCe,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpFiltroCCe.ResumeLayout(false)
        Me.grpFiltroCCe.PerformLayout
        CType(Me.grdCCe,System.ComponentModel.ISupportInitialize).EndInit
        Me.pagNFeCancelada.ResumeLayout(false)
        CType(Me.grpFiltroNFeCancelada,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpFiltroNFeCancelada.ResumeLayout(false)
        Me.grpFiltroNFeCancelada.PerformLayout
        CType(Me.grpControleNFeCancelada,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpControleNFeCancelada.ResumeLayout(false)
        CType(Me.grdNFeCancelada,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagNFe As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControleNFe As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAtualizarConsulta As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaNFeEntrada As System.Windows.Forms.Label
    Friend WithEvents picLegendaNFeEntrada As System.Windows.Forms.PictureBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblLegendaNFeBaixada As System.Windows.Forms.Label
    Friend WithEvents picLegendaNFeBaixada As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaNFeManifestada As System.Windows.Forms.Label
    Friend WithEvents picLegendaNFeManifestada As System.Windows.Forms.PictureBox
    Friend WithEvents btnSalvarArquivoXML As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagCartaCorrecao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnConfigurarGridCCe As System.Windows.Forms.Button
    Friend WithEvents grdCCe As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagNFeCancelada As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnConfigurarGridNFeCancelada As System.Windows.Forms.Button
    Friend WithEvents grdNFeCancelada As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtEmitenteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNotaFiscalFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblEmitenteFiltro As System.Windows.Forms.Label
    Friend WithEvents lblNotaFiscalFiltro As System.Windows.Forms.Label
    Friend WithEvents grpFiltroCCe As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataEmissaoInicioCCeFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoCCeFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtEmitenteCCeFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNotaFiscalCCeFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataEmissaoCCeFiltro As System.Windows.Forms.Label
    Friend WithEvents lblEmitenteCCeFiltro As System.Windows.Forms.Label
    Friend WithEvents lblNotaFiscalCCeFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrarCCe As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControleCCe As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSairCCe As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControleNFeCancelada As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSairNFeCancelada As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltroNFeCancelada As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataEmissaoInicioNFeCanceladaFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoNFeCanceladaFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtEmitenteNFeCanceladaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNotaFiscalNFeCanceladaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataEmissaoNFeCanceladaFiltro As System.Windows.Forms.Label
    Friend WithEvents lblEmitenteNFeCanceladaFiltro As System.Windows.Forms.Label
    Friend WithEvents lblNotaFiscalCanceladaFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrarNFeCancelada As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnManifestarRecebimento As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridCCe As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridCCe As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridNFeCancelada As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridNFeCancelada As System.Windows.Forms.Button
    Friend WithEvents lblCodigoTipoDocumentoFiscalFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumentoFiscalFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnImportarCTe As Janus.Windows.EditControls.UIButton
    Friend WithEvents chkSomentePendencia As System.Windows.Forms.CheckBox
    Friend WithEvents chkListarCTeCancelado As System.Windows.Forms.CheckBox

End Class
