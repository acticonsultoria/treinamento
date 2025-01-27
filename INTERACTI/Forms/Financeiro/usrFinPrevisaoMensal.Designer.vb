<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFinPrevisaoMensal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFinPrevisaoMensal))
        Dim grdMensal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picAntecipado = New System.Windows.Forms.PictureBox()
        Me.lblAntecipado = New System.Windows.Forms.Label()
        Me.lblTituloAberto = New System.Windows.Forms.Label()
        Me.picTituloAberto = New System.Windows.Forms.PictureBox()
        Me.picTituloQuitado = New System.Windows.Forms.PictureBox()
        Me.lblTituloQuitado = New System.Windows.Forms.Label()
        Me.picTituloParcialmenteQuitado = New System.Windows.Forms.PictureBox()
        Me.lblTituloParcialmenteQuitado = New System.Windows.Forms.Label()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagAnalitico = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagMensal = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdMensal = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboTipoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoFiltro = New System.Windows.Forms.Label()
        Me.chkReceita = New Janus.Windows.EditControls.UICheckBox()
        Me.chkDespesa = New Janus.Windows.EditControls.UICheckBox()
        Me.chkForecast = New Janus.Windows.EditControls.UICheckBox()
        Me.chkPrevisao = New Janus.Windows.EditControls.UICheckBox()
        Me.chkFaturado = New Janus.Windows.EditControls.UICheckBox()
        Me.chkRecebido = New Janus.Windows.EditControls.UICheckBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblPeriodoFiltro = New System.Windows.Forms.Label()
        Me.dtpPeriodoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpPeriodoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAntecipado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTituloAberto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTituloQuitado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTituloParcialmenteQuitado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagAnalitico.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagMensal.SuspendLayout()
        CType(Me.grdMensal, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pagLista.Controls.Add(Me.tabDados)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório Financeiro - Previsão Mensal"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.PictureBox1)
        Me.grpLegenda.Controls.Add(Me.Label1)
        Me.grpLegenda.Controls.Add(Me.picAntecipado)
        Me.grpLegenda.Controls.Add(Me.lblAntecipado)
        Me.grpLegenda.Controls.Add(Me.lblTituloAberto)
        Me.grpLegenda.Controls.Add(Me.picTituloAberto)
        Me.grpLegenda.Controls.Add(Me.picTituloQuitado)
        Me.grpLegenda.Controls.Add(Me.lblTituloQuitado)
        Me.grpLegenda.Controls.Add(Me.picTituloParcialmenteQuitado)
        Me.grpLegenda.Controls.Add(Me.lblTituloParcialmenteQuitado)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 482)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(265, 51)
        Me.grpLegenda.TabIndex = 3
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Firebrick
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(197, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(13, 14)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 14)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Pago"
        '
        'picAntecipado
        '
        Me.picAntecipado.BackColor = System.Drawing.Color.Peru
        Me.picAntecipado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAntecipado.Location = New System.Drawing.Point(106, 31)
        Me.picAntecipado.Name = "picAntecipado"
        Me.picAntecipado.Size = New System.Drawing.Size(13, 14)
        Me.picAntecipado.TabIndex = 18
        Me.picAntecipado.TabStop = False
        '
        'lblAntecipado
        '
        Me.lblAntecipado.AutoSize = True
        Me.lblAntecipado.Location = New System.Drawing.Point(125, 31)
        Me.lblAntecipado.Name = "lblAntecipado"
        Me.lblAntecipado.Size = New System.Drawing.Size(50, 14)
        Me.lblAntecipado.TabIndex = 17
        Me.lblAntecipado.Text = "Forecast"
        '
        'lblTituloAberto
        '
        Me.lblTituloAberto.AutoSize = True
        Me.lblTituloAberto.Location = New System.Drawing.Point(28, 13)
        Me.lblTituloAberto.Name = "lblTituloAberto"
        Me.lblTituloAberto.Size = New System.Drawing.Size(49, 14)
        Me.lblTituloAberto.TabIndex = 0
        Me.lblTituloAberto.Text = "Previsão"
        '
        'picTituloAberto
        '
        Me.picTituloAberto.BackColor = System.Drawing.Color.DarkGray
        Me.picTituloAberto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTituloAberto.Location = New System.Drawing.Point(9, 13)
        Me.picTituloAberto.Name = "picTituloAberto"
        Me.picTituloAberto.Size = New System.Drawing.Size(13, 14)
        Me.picTituloAberto.TabIndex = 14
        Me.picTituloAberto.TabStop = False
        '
        'picTituloQuitado
        '
        Me.picTituloQuitado.BackColor = System.Drawing.Color.ForestGreen
        Me.picTituloQuitado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTituloQuitado.Location = New System.Drawing.Point(106, 13)
        Me.picTituloQuitado.Name = "picTituloQuitado"
        Me.picTituloQuitado.Size = New System.Drawing.Size(13, 14)
        Me.picTituloQuitado.TabIndex = 12
        Me.picTituloQuitado.TabStop = False
        '
        'lblTituloQuitado
        '
        Me.lblTituloQuitado.AutoSize = True
        Me.lblTituloQuitado.Location = New System.Drawing.Point(125, 13)
        Me.lblTituloQuitado.Name = "lblTituloQuitado"
        Me.lblTituloQuitado.Size = New System.Drawing.Size(52, 14)
        Me.lblTituloQuitado.TabIndex = 2
        Me.lblTituloQuitado.Text = "Recebido"
        '
        'picTituloParcialmenteQuitado
        '
        Me.picTituloParcialmenteQuitado.BackColor = System.Drawing.Color.SteelBlue
        Me.picTituloParcialmenteQuitado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTituloParcialmenteQuitado.Location = New System.Drawing.Point(9, 31)
        Me.picTituloParcialmenteQuitado.Name = "picTituloParcialmenteQuitado"
        Me.picTituloParcialmenteQuitado.Size = New System.Drawing.Size(13, 14)
        Me.picTituloParcialmenteQuitado.TabIndex = 16
        Me.picTituloParcialmenteQuitado.TabStop = False
        '
        'lblTituloParcialmenteQuitado
        '
        Me.lblTituloParcialmenteQuitado.AutoSize = True
        Me.lblTituloParcialmenteQuitado.Location = New System.Drawing.Point(28, 31)
        Me.lblTituloParcialmenteQuitado.Name = "lblTituloParcialmenteQuitado"
        Me.lblTituloParcialmenteQuitado.Size = New System.Drawing.Size(50, 14)
        Me.lblTituloParcialmenteQuitado.TabIndex = 1
        Me.lblTituloParcialmenteQuitado.Text = "Faturado"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 80)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(982, 397)
        Me.tabDados.TabIndex = 1
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagAnalitico, Me.pagMensal})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagAnalitico
        '
        Me.pagAnalitico.Controls.Add(Me.grdListagem)
        Me.pagAnalitico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagAnalitico.Key = "pagLista"
        Me.pagAnalitico.Location = New System.Drawing.Point(1, 22)
        Me.pagAnalitico.Name = "pagAnalitico"
        Me.pagAnalitico.Size = New System.Drawing.Size(980, 374)
        Me.pagAnalitico.TabStop = True
        Me.pagAnalitico.Text = "Analítico"
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(11, 12)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(958, 347)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'pagMensal
        '
        Me.pagMensal.Controls.Add(Me.grdMensal)
        Me.pagMensal.Location = New System.Drawing.Point(1, 22)
        Me.pagMensal.Name = "pagMensal"
        Me.pagMensal.Size = New System.Drawing.Size(980, 374)
        Me.pagMensal.TabStop = True
        Me.pagMensal.Text = "Mensal"
        '
        'grdMensal
        '
        Me.grdMensal.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdMensal.AlternatingColors = True
        Me.grdMensal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdMensal.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdMensal_DesignTimeLayout.LayoutString = resources.GetString("grdMensal_DesignTimeLayout.LayoutString")
        Me.grdMensal.DesignTimeLayout = grdMensal_DesignTimeLayout
        Me.grdMensal.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdMensal.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdMensal.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdMensal.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdMensal.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdMensal.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdMensal.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdMensal.GroupByBoxVisible = False
        Me.grdMensal.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdMensal.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.grdMensal.Hierarchical = True
        Me.grdMensal.Location = New System.Drawing.Point(11, 14)
        Me.grdMensal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdMensal.Name = "grdMensal"
        Me.grdMensal.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdMensal.RecordNavigator = True
        Me.grdMensal.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdMensal.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdMensal.Size = New System.Drawing.Size(958, 347)
        Me.grdMensal.TabIndex = 2
        Me.grdMensal.TabStop = False
        Me.grdMensal.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdMensal.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdMensal.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdMensal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdMensal.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnExcel)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(279, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(711, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnExcel.Location = New System.Drawing.Point(514, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 5
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(611, 17)
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
        Me.grpFiltro.Controls.Add(Me.cboTipoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoFiltro)
        Me.grpFiltro.Controls.Add(Me.chkReceita)
        Me.grpFiltro.Controls.Add(Me.chkDespesa)
        Me.grpFiltro.Controls.Add(Me.chkForecast)
        Me.grpFiltro.Controls.Add(Me.chkPrevisao)
        Me.grpFiltro.Controls.Add(Me.chkFaturado)
        Me.grpFiltro.Controls.Add(Me.chkRecebido)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblPeriodoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpPeriodoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpPeriodoInicioFiltro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 73)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboTipoFiltro
        '
        Me.cboTipoFiltro.AutoSize = False
        Me.cboTipoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoFiltro.Location = New System.Drawing.Point(12, 37)
        Me.cboTipoFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoFiltro.Name = "cboTipoFiltro"
        Me.cboTipoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoFiltro.Size = New System.Drawing.Size(151, 20)
        Me.cboTipoFiltro.TabIndex = 1
        '
        'lblTipoFiltro
        '
        Me.lblTipoFiltro.AutoSize = True
        Me.lblTipoFiltro.Location = New System.Drawing.Point(9, 20)
        Me.lblTipoFiltro.Name = "lblTipoFiltro"
        Me.lblTipoFiltro.Size = New System.Drawing.Size(56, 14)
        Me.lblTipoFiltro.TabIndex = 0
        Me.lblTipoFiltro.Text = "Tipo Filtro:"
        '
        'chkReceita
        '
        Me.chkReceita.Checked = True
        Me.chkReceita.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkReceita.ForeColor = System.Drawing.Color.ForestGreen
        Me.chkReceita.Location = New System.Drawing.Point(415, 39)
        Me.chkReceita.Name = "chkReceita"
        Me.chkReceita.Size = New System.Drawing.Size(53, 17)
        Me.chkReceita.TabIndex = 6
        Me.chkReceita.Text = "Receita"
        '
        'chkDespesa
        '
        Me.chkDespesa.Checked = True
        Me.chkDespesa.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDespesa.ForeColor = System.Drawing.Color.Firebrick
        Me.chkDespesa.Location = New System.Drawing.Point(415, 20)
        Me.chkDespesa.Name = "chkDespesa"
        Me.chkDespesa.Size = New System.Drawing.Size(60, 17)
        Me.chkDespesa.TabIndex = 5
        Me.chkDespesa.Text = "Despesa"
        '
        'chkForecast
        '
        Me.chkForecast.Checked = True
        Me.chkForecast.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkForecast.Location = New System.Drawing.Point(578, 39)
        Me.chkForecast.Name = "chkForecast"
        Me.chkForecast.Size = New System.Drawing.Size(102, 16)
        Me.chkForecast.TabIndex = 10
        Me.chkForecast.Text = "Forecast"
        '
        'chkPrevisao
        '
        Me.chkPrevisao.Checked = True
        Me.chkPrevisao.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrevisao.Location = New System.Drawing.Point(578, 20)
        Me.chkPrevisao.Name = "chkPrevisao"
        Me.chkPrevisao.Size = New System.Drawing.Size(102, 16)
        Me.chkPrevisao.TabIndex = 9
        Me.chkPrevisao.Text = "Previsão"
        '
        'chkFaturado
        '
        Me.chkFaturado.Checked = True
        Me.chkFaturado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFaturado.Location = New System.Drawing.Point(504, 39)
        Me.chkFaturado.Name = "chkFaturado"
        Me.chkFaturado.Size = New System.Drawing.Size(102, 16)
        Me.chkFaturado.TabIndex = 8
        Me.chkFaturado.Text = "Faturado"
        '
        'chkRecebido
        '
        Me.chkRecebido.Checked = True
        Me.chkRecebido.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRecebido.Location = New System.Drawing.Point(504, 20)
        Me.chkRecebido.Name = "chkRecebido"
        Me.chkRecebido.Size = New System.Drawing.Size(102, 16)
        Me.chkRecebido.TabIndex = 7
        Me.chkRecebido.Text = "Recebido"
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
        Me.btnFiltrar.TabIndex = 11
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblPeriodoFiltro
        '
        Me.lblPeriodoFiltro.AutoSize = True
        Me.lblPeriodoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPeriodoFiltro.Location = New System.Drawing.Point(166, 20)
        Me.lblPeriodoFiltro.Name = "lblPeriodoFiltro"
        Me.lblPeriodoFiltro.Size = New System.Drawing.Size(46, 14)
        Me.lblPeriodoFiltro.TabIndex = 2
        Me.lblPeriodoFiltro.Text = "Período:"
        '
        'dtpPeriodoTerminoFiltro
        '
        Me.dtpPeriodoTerminoFiltro.CustomFormat = "dd/MM/yyyy"
        Me.dtpPeriodoTerminoFiltro.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpPeriodoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpPeriodoTerminoFiltro.Location = New System.Drawing.Point(283, 37)
        Me.dtpPeriodoTerminoFiltro.Name = "dtpPeriodoTerminoFiltro"
        Me.dtpPeriodoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpPeriodoTerminoFiltro.TabIndex = 4
        '
        'dtpPeriodoInicioFiltro
        '
        Me.dtpPeriodoInicioFiltro.CustomFormat = "dd/MM/yyyy"
        Me.dtpPeriodoInicioFiltro.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpPeriodoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpPeriodoInicioFiltro.Location = New System.Drawing.Point(169, 37)
        Me.dtpPeriodoInicioFiltro.Name = "dtpPeriodoInicioFiltro"
        Me.dtpPeriodoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpPeriodoInicioFiltro.TabIndex = 3
        '
        'usrFinPrevisaoMensal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFinPrevisaoMensal"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAntecipado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTituloAberto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTituloQuitado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTituloParcialmenteQuitado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagAnalitico.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagMensal.ResumeLayout(False)
        CType(Me.grdMensal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
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
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblPeriodoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpPeriodoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpPeriodoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagAnalitico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagMensal As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdMensal As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picAntecipado As System.Windows.Forms.PictureBox
    Friend WithEvents lblAntecipado As System.Windows.Forms.Label
    Friend WithEvents lblTituloAberto As System.Windows.Forms.Label
    Friend WithEvents picTituloAberto As System.Windows.Forms.PictureBox
    Friend WithEvents picTituloQuitado As System.Windows.Forms.PictureBox
    Friend WithEvents lblTituloQuitado As System.Windows.Forms.Label
    Friend WithEvents picTituloParcialmenteQuitado As System.Windows.Forms.PictureBox
    Friend WithEvents lblTituloParcialmenteQuitado As System.Windows.Forms.Label
    Friend WithEvents chkForecast As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkPrevisao As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkFaturado As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkRecebido As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkReceita As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkDespesa As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents lblTipoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
