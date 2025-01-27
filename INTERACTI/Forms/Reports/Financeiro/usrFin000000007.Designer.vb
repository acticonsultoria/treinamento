<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFin000000007
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFin000000007))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelListagem = New System.Windows.Forms.Button()
        Me.btnConfiguraGridListagem = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkLeSix = New Janus.Windows.EditControls.UICheckBox()
        Me.cboCentroCusto = New Janus.Windows.EditControls.UIComboBox()
        Me.chkLavalpa = New Janus.Windows.EditControls.UICheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboAgrupadoPorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.cboTipoDataFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAgrupadoPorFiltro = New System.Windows.Forms.Label()
        Me.btnProcurarCliente = New System.Windows.Forms.Button()
        Me.lblSegmentoFiltro = New System.Windows.Forms.Label()
        Me.cboSegmentoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoDataFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFiltro = New System.Windows.Forms.Label()
        Me.cboClienteFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.grpParceiro = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkParceiro = New Janus.Windows.EditControls.UICheckBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpParceiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpParceiro.SuspendLayout()
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
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.btnExcelListagem)
        Me.pagLista.Controls.Add(Me.btnConfiguraGridListagem)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório Financeiro - FIN000000007"
        '
        'btnExcelListagem
        '
        Me.btnExcelListagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelListagem.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelListagem.FlatAppearance.BorderSize = 0
        Me.btnExcelListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelListagem.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelListagem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelListagem.Location = New System.Drawing.Point(33, 463)
        Me.btnExcelListagem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelListagem.Name = "btnExcelListagem"
        Me.btnExcelListagem.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelListagem.TabIndex = 100
        Me.btnExcelListagem.TabStop = False
        Me.btnExcelListagem.UseVisualStyleBackColor = False
        '
        'btnConfiguraGridListagem
        '
        Me.btnConfiguraGridListagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfiguraGridListagem.BackColor = System.Drawing.Color.Transparent
        Me.btnConfiguraGridListagem.FlatAppearance.BorderSize = 0
        Me.btnConfiguraGridListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguraGridListagem.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfiguraGridListagem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfiguraGridListagem.Location = New System.Drawing.Point(9, 463)
        Me.btnConfiguraGridListagem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfiguraGridListagem.Name = "btnConfiguraGridListagem"
        Me.btnConfiguraGridListagem.Size = New System.Drawing.Size(24, 15)
        Me.btnConfiguraGridListagem.TabIndex = 99
        Me.btnConfiguraGridListagem.TabStop = False
        Me.btnConfiguraGridListagem.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnAutoResize = True
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
        Me.grdListagem.Location = New System.Drawing.Point(8, 119)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 361)
        Me.grdListagem.TabIndex = 94
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnVisualizarImpressao)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(982, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnVisualizarImpressao
        '
        Me.btnVisualizarImpressao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarImpressao.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnVisualizarImpressao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarImpressao.Location = New System.Drawing.Point(676, 17)
        Me.btnVisualizarImpressao.Name = "btnVisualizarImpressao"
        Me.btnVisualizarImpressao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarImpressao.Size = New System.Drawing.Size(200, 23)
        Me.btnVisualizarImpressao.TabIndex = 1
        Me.btnVisualizarImpressao.Text = "Visualizar Impressão"
        Me.btnVisualizarImpressao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.chkLeSix)
        Me.grpFiltro.Controls.Add(Me.cboCentroCusto)
        Me.grpFiltro.Controls.Add(Me.chkLavalpa)
        Me.grpFiltro.Controls.Add(Me.Label1)
        Me.grpFiltro.Controls.Add(Me.cboAgrupadoPorFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoDataFiltro)
        Me.grpFiltro.Controls.Add(Me.lblAgrupadoPorFiltro)
        Me.grpFiltro.Controls.Add(Me.btnProcurarCliente)
        Me.grpFiltro.Controls.Add(Me.lblSegmentoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboSegmentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoDataFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataFiltro)
        Me.grpFiltro.Controls.Add(Me.cboClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.grpParceiro)
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
        'chkLeSix
        '
        Me.chkLeSix.Enabled = False
        Me.chkLeSix.Location = New System.Drawing.Point(809, 48)
        Me.chkLeSix.Name = "chkLeSix"
        Me.chkLeSix.Size = New System.Drawing.Size(65, 18)
        Me.chkLeSix.TabIndex = 20
        Me.chkLeSix.Text = "Le Six"
        '
        'cboCentroCusto
        '
        Me.cboCentroCusto.Location = New System.Drawing.Point(611, 77)
        Me.cboCentroCusto.Name = "cboCentroCusto"
        Me.cboCentroCusto.Size = New System.Drawing.Size(175, 20)
        Me.cboCentroCusto.TabIndex = 15
        '
        'chkLavalpa
        '
        Me.chkLavalpa.Enabled = False
        Me.chkLavalpa.Location = New System.Drawing.Point(809, 68)
        Me.chkLavalpa.Name = "chkLavalpa"
        Me.chkLavalpa.Size = New System.Drawing.Size(65, 18)
        Me.chkLavalpa.TabIndex = 21
        Me.chkLavalpa.Text = "Lavalpa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(608, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 14)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Centro de Custo:"
        '
        'cboAgrupadoPorFiltro
        '
        Me.cboAgrupadoPorFiltro.Location = New System.Drawing.Point(430, 77)
        Me.cboAgrupadoPorFiltro.Name = "cboAgrupadoPorFiltro"
        Me.cboAgrupadoPorFiltro.Size = New System.Drawing.Size(175, 20)
        Me.cboAgrupadoPorFiltro.TabIndex = 12
        '
        'cboTipoDataFiltro
        '
        Me.cboTipoDataFiltro.Location = New System.Drawing.Point(10, 77)
        Me.cboTipoDataFiltro.Name = "cboTipoDataFiltro"
        Me.cboTipoDataFiltro.Size = New System.Drawing.Size(222, 20)
        Me.cboTipoDataFiltro.TabIndex = 8
        '
        'lblAgrupadoPorFiltro
        '
        Me.lblAgrupadoPorFiltro.AutoSize = True
        Me.lblAgrupadoPorFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAgrupadoPorFiltro.Location = New System.Drawing.Point(427, 60)
        Me.lblAgrupadoPorFiltro.Name = "lblAgrupadoPorFiltro"
        Me.lblAgrupadoPorFiltro.Size = New System.Drawing.Size(77, 14)
        Me.lblAgrupadoPorFiltro.TabIndex = 13
        Me.lblAgrupadoPorFiltro.Text = "Agrupado Por:"
        '
        'btnProcurarCliente
        '
        Me.btnProcurarCliente.FlatAppearance.BorderSize = 0
        Me.btnProcurarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCliente.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCliente.Location = New System.Drawing.Point(588, 19)
        Me.btnProcurarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCliente.Name = "btnProcurarCliente"
        Me.btnProcurarCliente.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCliente.TabIndex = 4
        Me.btnProcurarCliente.TabStop = False
        Me.btnProcurarCliente.UseVisualStyleBackColor = True
        '
        'lblSegmentoFiltro
        '
        Me.lblSegmentoFiltro.AutoSize = True
        Me.lblSegmentoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSegmentoFiltro.Location = New System.Drawing.Point(7, 20)
        Me.lblSegmentoFiltro.Name = "lblSegmentoFiltro"
        Me.lblSegmentoFiltro.Size = New System.Drawing.Size(58, 14)
        Me.lblSegmentoFiltro.TabIndex = 0
        Me.lblSegmentoFiltro.Text = "Segmento:"
        '
        'cboSegmentoFiltro
        '
        Me.cboSegmentoFiltro.Location = New System.Drawing.Point(10, 37)
        Me.cboSegmentoFiltro.Name = "cboSegmentoFiltro"
        Me.cboSegmentoFiltro.Size = New System.Drawing.Size(222, 20)
        Me.cboSegmentoFiltro.TabIndex = 1
        '
        'lblTipoDataFiltro
        '
        Me.lblTipoDataFiltro.AutoSize = True
        Me.lblTipoDataFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoDataFiltro.Location = New System.Drawing.Point(7, 60)
        Me.lblTipoDataFiltro.Name = "lblTipoDataFiltro"
        Me.lblTipoDataFiltro.Size = New System.Drawing.Size(70, 14)
        Me.lblTipoDataFiltro.TabIndex = 7
        Me.lblTipoDataFiltro.Text = "Tipo de Data:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(883, 74)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 14
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblClienteFiltro.Location = New System.Drawing.Point(235, 20)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteFiltro.TabIndex = 2
        Me.lblClienteFiltro.Text = "Cliente:"
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(334, 77)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(90, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 11
        '
        'dtpDataInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(238, 77)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(90, 20)
        Me.dtpDataInicioFiltro.TabIndex = 10
        '
        'lblDataFiltro
        '
        Me.lblDataFiltro.AutoSize = True
        Me.lblDataFiltro.Location = New System.Drawing.Point(235, 60)
        Me.lblDataFiltro.Name = "lblDataFiltro"
        Me.lblDataFiltro.Size = New System.Drawing.Size(32, 14)
        Me.lblDataFiltro.TabIndex = 9
        Me.lblDataFiltro.Text = "Data:"
        '
        'cboClienteFiltro
        '
        Me.cboClienteFiltro.Location = New System.Drawing.Point(238, 37)
        Me.cboClienteFiltro.Name = "cboClienteFiltro"
        Me.cboClienteFiltro.Size = New System.Drawing.Size(367, 20)
        Me.cboClienteFiltro.TabIndex = 3
        '
        'grpParceiro
        '
        Me.grpParceiro.BackColor = System.Drawing.Color.Transparent
        Me.grpParceiro.Controls.Add(Me.chkParceiro)
        Me.grpParceiro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpParceiro.Location = New System.Drawing.Point(792, 33)
        Me.grpParceiro.Name = "grpParceiro"
        Me.grpParceiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpParceiro.Size = New System.Drawing.Size(89, 60)
        Me.grpParceiro.TabIndex = 22
        Me.grpParceiro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpParceiro.VisualStyleManager = Me.vsmMain
        '
        'chkParceiro
        '
        Me.chkParceiro.Location = New System.Drawing.Point(6, -2)
        Me.chkParceiro.Name = "chkParceiro"
        Me.chkParceiro.Size = New System.Drawing.Size(65, 18)
        Me.chkParceiro.TabIndex = 20
        '
        'usrFin000000007
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFin000000007"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpParceiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpParceiro.ResumeLayout(False)
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
    Friend WithEvents cboClienteFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFiltro As System.Windows.Forms.Label
    Friend WithEvents lblTipoDataFiltro As System.Windows.Forms.Label
    Friend WithEvents lblSegmentoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboSegmentoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnProcurarCliente As System.Windows.Forms.Button
    Friend WithEvents lblAgrupadoPorFiltro As System.Windows.Forms.Label
    Friend WithEvents cboAgrupadoPorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboTipoDataFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboCentroCusto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkLeSix As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkLavalpa As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents grpParceiro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents chkParceiro As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelListagem As System.Windows.Forms.Button
    Friend WithEvents btnConfiguraGridListagem As System.Windows.Forms.Button

End Class
