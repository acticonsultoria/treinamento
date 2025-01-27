<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCmp000000008
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
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.ChildTables.Table0.Columns.Column0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCmp000000008))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegendaCertificadoEmDia = New System.Windows.Forms.PictureBox()
        Me.lblLegendaCertificadoEmDia = New System.Windows.Forms.Label()
        Me.picLegendaCertificadoVencido = New System.Windows.Forms.PictureBox()
        Me.lblLegendaCertificadoVencido = New System.Windows.Forms.Label()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblNumeroDiasVencimentoFiltro = New System.Windows.Forms.Label()
        Me.txtNumeroDiasVencimentoFiltro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboMunicipioFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUFFiltro = New System.Windows.Forms.Label()
        Me.cboUFFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMunicipioFiltro = New System.Windows.Forms.Label()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblClassificacaoFiltro = New System.Windows.Forms.Label()
        Me.cboClassificacaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaCertificadoEmDia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaCertificadoVencido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
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
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório Compras - CMP000000008"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.picLegendaCertificadoEmDia)
        Me.grpLegenda.Controls.Add(Me.lblLegendaCertificadoEmDia)
        Me.grpLegenda.Controls.Add(Me.picLegendaCertificadoVencido)
        Me.grpLegenda.Controls.Add(Me.lblLegendaCertificadoVencido)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(265, 51)
        Me.grpLegenda.TabIndex = 30
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picLegendaCertificadoEmDia
        '
        Me.picLegendaCertificadoEmDia.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaCertificadoEmDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCertificadoEmDia.Location = New System.Drawing.Point(10, 21)
        Me.picLegendaCertificadoEmDia.Name = "picLegendaCertificadoEmDia"
        Me.picLegendaCertificadoEmDia.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCertificadoEmDia.TabIndex = 22
        Me.picLegendaCertificadoEmDia.TabStop = False
        '
        'lblLegendaCertificadoEmDia
        '
        Me.lblLegendaCertificadoEmDia.AutoSize = True
        Me.lblLegendaCertificadoEmDia.Location = New System.Drawing.Point(29, 21)
        Me.lblLegendaCertificadoEmDia.Name = "lblLegendaCertificadoEmDia"
        Me.lblLegendaCertificadoEmDia.Size = New System.Drawing.Size(100, 14)
        Me.lblLegendaCertificadoEmDia.TabIndex = 0
        Me.lblLegendaCertificadoEmDia.Text = "Certificados em Dia"
        '
        'picLegendaCertificadoVencido
        '
        Me.picLegendaCertificadoVencido.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaCertificadoVencido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCertificadoVencido.Location = New System.Drawing.Point(135, 21)
        Me.picLegendaCertificadoVencido.Name = "picLegendaCertificadoVencido"
        Me.picLegendaCertificadoVencido.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCertificadoVencido.TabIndex = 4
        Me.picLegendaCertificadoVencido.TabStop = False
        '
        'lblLegendaCertificadoVencido
        '
        Me.lblLegendaCertificadoVencido.AutoSize = True
        Me.lblLegendaCertificadoVencido.Location = New System.Drawing.Point(154, 21)
        Me.lblLegendaCertificadoVencido.Name = "lblLegendaCertificadoVencido"
        Me.lblLegendaCertificadoVencido.Size = New System.Drawing.Size(107, 14)
        Me.lblLegendaCertificadoVencido.TabIndex = 1
        Me.lblLegendaCertificadoVencido.Text = "Certificados Vencido"
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
        Me.btnAgruparGrid.TabIndex = 29
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
        Me.btnConfigurarGrid.TabIndex = 28
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 119)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 361)
        Me.grdListagem.TabIndex = 27
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.lblCongelarColuna)
        Me.grpControl.Controls.Add(Me.cboCongelarColuna)
        Me.grpControl.Controls.Add(Me.btnExcel)
        Me.grpControl.Controls.Add(Me.btnVisualizarImpressao)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(282, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(708, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(5, 22)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 13
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(100, 19)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 14
        Me.cboCongelarColuna.TabStop = False
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(355, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 12
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVisualizarImpressao
        '
        Me.btnVisualizarImpressao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarImpressao.Image = Global.INTERACTI.My.Resources.imprimir
        Me.btnVisualizarImpressao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarImpressao.Location = New System.Drawing.Point(452, 17)
        Me.btnVisualizarImpressao.Name = "btnVisualizarImpressao"
        Me.btnVisualizarImpressao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarImpressao.Size = New System.Drawing.Size(150, 23)
        Me.btnVisualizarImpressao.TabIndex = 0
        Me.btnVisualizarImpressao.Text = "Visualizar Impressão"
        Me.btnVisualizarImpressao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(608, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
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
        Me.grpFiltro.Controls.Add(Me.lblNumeroDiasVencimentoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDiasVencimentoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboMunicipioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblUFFiltro)
        Me.grpFiltro.Controls.Add(Me.cboUFFiltro)
        Me.grpFiltro.Controls.Add(Me.lblMunicipioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblClassificacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboClassificacaoFiltro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 107)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblNumeroDiasVencimentoFiltro
        '
        Me.lblNumeroDiasVencimentoFiltro.AutoSize = True
        Me.lblNumeroDiasVencimentoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroDiasVencimentoFiltro.Location = New System.Drawing.Point(202, 60)
        Me.lblNumeroDiasVencimentoFiltro.Name = "lblNumeroDiasVencimentoFiltro"
        Me.lblNumeroDiasVencimentoFiltro.Size = New System.Drawing.Size(105, 14)
        Me.lblNumeroDiasVencimentoFiltro.TabIndex = 8
        Me.lblNumeroDiasVencimentoFiltro.Text = "Nº Dias Vencimento:"
        '
        'txtNumeroDiasVencimentoFiltro
        '
        Me.txtNumeroDiasVencimentoFiltro.DecimalDigits = 0
        Me.txtNumeroDiasVencimentoFiltro.Location = New System.Drawing.Point(205, 77)
        Me.txtNumeroDiasVencimentoFiltro.Name = "txtNumeroDiasVencimentoFiltro"
        Me.txtNumeroDiasVencimentoFiltro.Size = New System.Drawing.Size(115, 20)
        Me.txtNumeroDiasVencimentoFiltro.TabIndex = 9
        Me.txtNumeroDiasVencimentoFiltro.Text = "0"
        Me.txtNumeroDiasVencimentoFiltro.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cboMunicipioFiltro
        '
        Me.cboMunicipioFiltro.AutoSize = False
        Me.cboMunicipioFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMunicipioFiltro.Location = New System.Drawing.Point(390, 37)
        Me.cboMunicipioFiltro.Name = "cboMunicipioFiltro"
        Me.cboMunicipioFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMunicipioFiltro.Size = New System.Drawing.Size(302, 20)
        Me.cboMunicipioFiltro.TabIndex = 5
        '
        'lblUFFiltro
        '
        Me.lblUFFiltro.AutoSize = True
        Me.lblUFFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUFFiltro.Location = New System.Drawing.Point(323, 20)
        Me.lblUFFiltro.Name = "lblUFFiltro"
        Me.lblUFFiltro.Size = New System.Drawing.Size(23, 14)
        Me.lblUFFiltro.TabIndex = 2
        Me.lblUFFiltro.Text = "UF:"
        '
        'cboUFFiltro
        '
        Me.cboUFFiltro.AutoSize = False
        Me.cboUFFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUFFiltro.Location = New System.Drawing.Point(326, 37)
        Me.cboUFFiltro.Name = "cboUFFiltro"
        Me.cboUFFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUFFiltro.Size = New System.Drawing.Size(58, 20)
        Me.cboUFFiltro.TabIndex = 3
        '
        'lblMunicipioFiltro
        '
        Me.lblMunicipioFiltro.AutoSize = True
        Me.lblMunicipioFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMunicipioFiltro.Location = New System.Drawing.Point(387, 20)
        Me.lblMunicipioFiltro.Name = "lblMunicipioFiltro"
        Me.lblMunicipioFiltro.Size = New System.Drawing.Size(54, 14)
        Me.lblMunicipioFiltro.TabIndex = 4
        Me.lblMunicipioFiltro.Text = "Município:"
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStatusFiltro.Location = New System.Drawing.Point(5, 60)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 6
        Me.lblStatusFiltro.Text = "Status:"
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.Location = New System.Drawing.Point(8, 77)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(191, 20)
        Me.cboStatusFiltro.TabIndex = 7
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 74)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 10
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblClassificacaoFiltro
        '
        Me.lblClassificacaoFiltro.AutoSize = True
        Me.lblClassificacaoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblClassificacaoFiltro.Location = New System.Drawing.Point(5, 20)
        Me.lblClassificacaoFiltro.Name = "lblClassificacaoFiltro"
        Me.lblClassificacaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblClassificacaoFiltro.TabIndex = 0
        Me.lblClassificacaoFiltro.Text = "Classificação:"
        '
        'cboClassificacaoFiltro
        '
        Me.cboClassificacaoFiltro.Location = New System.Drawing.Point(8, 37)
        Me.cboClassificacaoFiltro.Name = "cboClassificacaoFiltro"
        Me.cboClassificacaoFiltro.Size = New System.Drawing.Size(312, 20)
        Me.cboClassificacaoFiltro.TabIndex = 1
        '
        'usrCmp000000008
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCmp000000008"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaCertificadoEmDia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaCertificadoVencido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVisualizarImpressao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboClassificacaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblClassificacaoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboMunicipioFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUFFiltro As System.Windows.Forms.Label
    Friend WithEvents cboUFFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMunicipioFiltro As System.Windows.Forms.Label
    Friend WithEvents lblNumeroDiasVencimentoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDiasVencimentoFiltro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaCertificadoEmDia As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCertificadoEmDia As System.Windows.Forms.Label
    Friend WithEvents picLegendaCertificadoVencido As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaCertificadoVencido As System.Windows.Forms.Label
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX

End Class
