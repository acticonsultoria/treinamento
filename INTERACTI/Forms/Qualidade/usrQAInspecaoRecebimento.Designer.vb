<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrQAInspecaoRecebimento
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
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrQAInspecaoRecebimento))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegendaEntregue = New System.Windows.Forms.PictureBox()
        Me.lblLegendaEntregue = New System.Windows.Forms.Label()
        Me.picLegendaAguardandoEntrega = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAguardandoEntrega = New System.Windows.Forms.Label()
        Me.lblLegendaAtrasado = New System.Windows.Forms.Label()
        Me.picLegendaAtrasado = New System.Windows.Forms.PictureBox()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkAguardandoInspecao = New Janus.Windows.EditControls.UICheckBox()
        Me.dtpDataEntregaInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEntregaTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEntregaFiltro = New System.Windows.Forms.Label()
        Me.lblFolloUpFiltro = New System.Windows.Forms.Label()
        Me.cboFollowUpFitro = New Janus.Windows.EditControls.UIComboBox()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.dtpDataPrevisaoEntregaInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPrevisaoEntregaTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.txtItemFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblItemFiltro = New System.Windows.Forms.Label()
        Me.txtFornecedorFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroPedidoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedidoFiltro = New System.Windows.Forms.Label()
        Me.lblFornecedorFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblPrazoEntregaFiltro = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaEntregue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaAguardandoEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaAtrasado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
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
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(998, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Inspeção de Recebimento"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 58
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 464)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 13
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 3
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 117)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 363)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.picLegendaEntregue)
        Me.grpLegenda.Controls.Add(Me.lblLegendaEntregue)
        Me.grpLegenda.Controls.Add(Me.picLegendaAguardandoEntrega)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAguardandoEntrega)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAtrasado)
        Me.grpLegenda.Controls.Add(Me.picLegendaAtrasado)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(291, 51)
        Me.grpLegenda.TabIndex = 3
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picLegendaEntregue
        '
        Me.picLegendaEntregue.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaEntregue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaEntregue.Location = New System.Drawing.Point(141, 21)
        Me.picLegendaEntregue.Name = "picLegendaEntregue"
        Me.picLegendaEntregue.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaEntregue.TabIndex = 22
        Me.picLegendaEntregue.TabStop = False
        '
        'lblLegendaEntregue
        '
        Me.lblLegendaEntregue.AutoSize = True
        Me.lblLegendaEntregue.Location = New System.Drawing.Point(160, 21)
        Me.lblLegendaEntregue.Name = "lblLegendaEntregue"
        Me.lblLegendaEntregue.Size = New System.Drawing.Size(50, 14)
        Me.lblLegendaEntregue.TabIndex = 1
        Me.lblLegendaEntregue.Text = "Entregue"
        '
        'picLegendaAguardandoEntrega
        '
        Me.picLegendaAguardandoEntrega.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaAguardandoEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAguardandoEntrega.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaAguardandoEntrega.Name = "picLegendaAguardandoEntrega"
        Me.picLegendaAguardandoEntrega.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAguardandoEntrega.TabIndex = 20
        Me.picLegendaAguardandoEntrega.TabStop = False
        '
        'lblLegendaAguardandoEntrega
        '
        Me.lblLegendaAguardandoEntrega.AutoSize = True
        Me.lblLegendaAguardandoEntrega.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaAguardandoEntrega.Name = "lblLegendaAguardandoEntrega"
        Me.lblLegendaAguardandoEntrega.Size = New System.Drawing.Size(107, 14)
        Me.lblLegendaAguardandoEntrega.TabIndex = 0
        Me.lblLegendaAguardandoEntrega.Text = "Aguardando Entrega"
        '
        'lblLegendaAtrasado
        '
        Me.lblLegendaAtrasado.AutoSize = True
        Me.lblLegendaAtrasado.Location = New System.Drawing.Point(235, 21)
        Me.lblLegendaAtrasado.Name = "lblLegendaAtrasado"
        Me.lblLegendaAtrasado.Size = New System.Drawing.Size(52, 14)
        Me.lblLegendaAtrasado.TabIndex = 2
        Me.lblLegendaAtrasado.Text = "Atrasado"
        '
        'picLegendaAtrasado
        '
        Me.picLegendaAtrasado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaAtrasado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAtrasado.Location = New System.Drawing.Point(216, 21)
        Me.picLegendaAtrasado.Name = "picLegendaAtrasado"
        Me.picLegendaAtrasado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAtrasado.TabIndex = 4
        Me.picLegendaAtrasado.TabStop = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.chkAguardandoInspecao)
        Me.grpFiltro.Controls.Add(Me.dtpDataEntregaInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEntregaTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEntregaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFolloUpFiltro)
        Me.grpFiltro.Controls.Add(Me.cboFollowUpFitro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPrevisaoEntregaInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPrevisaoEntregaTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.txtItemFiltro)
        Me.grpFiltro.Controls.Add(Me.lblItemFiltro)
        Me.grpFiltro.Controls.Add(Me.txtFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNumeroPedidoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroPedidoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFornecedorFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblPrazoEntregaFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'chkAguardandoInspecao
        '
        Me.chkAguardandoInspecao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAguardandoInspecao.Location = New System.Drawing.Point(849, 34)
        Me.chkAguardandoInspecao.Name = "chkAguardandoInspecao"
        Me.chkAguardandoInspecao.Size = New System.Drawing.Size(127, 16)
        Me.chkAguardandoInspecao.TabIndex = 20
        Me.chkAguardandoInspecao.Text = "Aguardando Inspeção"
        '
        'dtpDataEntregaInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEntregaInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEntregaInicioFiltro.Location = New System.Drawing.Point(342, 74)
        Me.dtpDataEntregaInicioFiltro.Name = "dtpDataEntregaInicioFiltro"
        Me.dtpDataEntregaInicioFiltro.ShowCheckBox = True
        Me.dtpDataEntregaInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEntregaInicioFiltro.TabIndex = 18
        Me.dtpDataEntregaInicioFiltro.Value = New Date(2020, 6, 15, 0, 0, 0, 0)
        '
        'dtpDataEntregaTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEntregaTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEntregaTerminoFiltro.Location = New System.Drawing.Point(456, 74)
        Me.dtpDataEntregaTerminoFiltro.Name = "dtpDataEntregaTerminoFiltro"
        Me.dtpDataEntregaTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEntregaTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEntregaTerminoFiltro.TabIndex = 19
        Me.dtpDataEntregaTerminoFiltro.Value = New Date(2020, 6, 15, 0, 0, 0, 0)
        '
        'lblDataEntregaFiltro
        '
        Me.lblDataEntregaFiltro.AutoSize = True
        Me.lblDataEntregaFiltro.Location = New System.Drawing.Point(339, 57)
        Me.lblDataEntregaFiltro.Name = "lblDataEntregaFiltro"
        Me.lblDataEntregaFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblDataEntregaFiltro.TabIndex = 17
        Me.lblDataEntregaFiltro.Text = "Entrega:"
        '
        'lblFolloUpFiltro
        '
        Me.lblFolloUpFiltro.AutoSize = True
        Me.lblFolloUpFiltro.Location = New System.Drawing.Point(687, 17)
        Me.lblFolloUpFiltro.Name = "lblFolloUpFiltro"
        Me.lblFolloUpFiltro.Size = New System.Drawing.Size(58, 14)
        Me.lblFolloUpFiltro.TabIndex = 7
        Me.lblFolloUpFiltro.Text = "Follow Up:"
        '
        'cboFollowUpFitro
        '
        Me.cboFollowUpFitro.AutoSize = False
        Me.cboFollowUpFitro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFollowUpFitro.Location = New System.Drawing.Point(690, 34)
        Me.cboFollowUpFitro.Name = "cboFollowUpFitro"
        Me.cboFollowUpFitro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFollowUpFitro.Size = New System.Drawing.Size(90, 20)
        Me.cboFollowUpFitro.TabIndex = 8
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(570, 74)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(210, 20)
        Me.cboStatusFiltro.TabIndex = 15
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'dtpDataPrevisaoEntregaInicioFiltro
        '
        '
        '
        '
        Me.dtpDataPrevisaoEntregaInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPrevisaoEntregaInicioFiltro.Location = New System.Drawing.Point(114, 34)
        Me.dtpDataPrevisaoEntregaInicioFiltro.Name = "dtpDataPrevisaoEntregaInicioFiltro"
        Me.dtpDataPrevisaoEntregaInicioFiltro.ShowCheckBox = True
        Me.dtpDataPrevisaoEntregaInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPrevisaoEntregaInicioFiltro.TabIndex = 3
        Me.dtpDataPrevisaoEntregaInicioFiltro.Value = New Date(2020, 6, 15, 0, 0, 0, 0)
        '
        'dtpDataPrevisaoEntregaTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataPrevisaoEntregaTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPrevisaoEntregaTerminoFiltro.Location = New System.Drawing.Point(228, 34)
        Me.dtpDataPrevisaoEntregaTerminoFiltro.Name = "dtpDataPrevisaoEntregaTerminoFiltro"
        Me.dtpDataPrevisaoEntregaTerminoFiltro.ShowCheckBox = True
        Me.dtpDataPrevisaoEntregaTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPrevisaoEntregaTerminoFiltro.TabIndex = 4
        Me.dtpDataPrevisaoEntregaTerminoFiltro.Value = New Date(2020, 6, 15, 0, 0, 0, 0)
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(567, 57)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 14
        Me.lblStatusFiltro.Text = "Status:"
        '
        'txtItemFiltro
        '
        Me.txtItemFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemFiltro.Location = New System.Drawing.Point(9, 74)
        Me.txtItemFiltro.MaxLength = 60
        Me.txtItemFiltro.Name = "txtItemFiltro"
        Me.txtItemFiltro.Size = New System.Drawing.Size(327, 20)
        Me.txtItemFiltro.TabIndex = 10
        '
        'lblItemFiltro
        '
        Me.lblItemFiltro.AutoSize = True
        Me.lblItemFiltro.Location = New System.Drawing.Point(6, 57)
        Me.lblItemFiltro.Name = "lblItemFiltro"
        Me.lblItemFiltro.Size = New System.Drawing.Size(29, 14)
        Me.lblItemFiltro.TabIndex = 9
        Me.lblItemFiltro.Text = "Item:"
        '
        'txtFornecedorFiltro
        '
        Me.txtFornecedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFornecedorFiltro.Location = New System.Drawing.Point(342, 34)
        Me.txtFornecedorFiltro.MaxLength = 60
        Me.txtFornecedorFiltro.Name = "txtFornecedorFiltro"
        Me.txtFornecedorFiltro.Size = New System.Drawing.Size(342, 20)
        Me.txtFornecedorFiltro.TabIndex = 6
        '
        'txtNumeroPedidoFiltro
        '
        Me.txtNumeroPedidoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedidoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroPedidoFiltro.MaxLength = 20
        Me.txtNumeroPedidoFiltro.Name = "txtNumeroPedidoFiltro"
        Me.txtNumeroPedidoFiltro.Size = New System.Drawing.Size(99, 20)
        Me.txtNumeroPedidoFiltro.TabIndex = 1
        '
        'lblNumeroPedidoFiltro
        '
        Me.lblNumeroPedidoFiltro.AutoSize = True
        Me.lblNumeroPedidoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroPedidoFiltro.Name = "lblNumeroPedidoFiltro"
        Me.lblNumeroPedidoFiltro.Size = New System.Drawing.Size(57, 14)
        Me.lblNumeroPedidoFiltro.TabIndex = 0
        Me.lblNumeroPedidoFiltro.Text = "Nº Pedido:"
        '
        'lblFornecedorFiltro
        '
        Me.lblFornecedorFiltro.AutoSize = True
        Me.lblFornecedorFiltro.Location = New System.Drawing.Point(339, 17)
        Me.lblFornecedorFiltro.Name = "lblFornecedorFiltro"
        Me.lblFornecedorFiltro.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedorFiltro.TabIndex = 5
        Me.lblFornecedorFiltro.Text = "Fornecedor:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 16
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblPrazoEntregaFiltro
        '
        Me.lblPrazoEntregaFiltro.AutoSize = True
        Me.lblPrazoEntregaFiltro.Location = New System.Drawing.Point(111, 17)
        Me.lblPrazoEntregaFiltro.Name = "lblPrazoEntregaFiltro"
        Me.lblPrazoEntregaFiltro.Size = New System.Drawing.Size(107, 14)
        Me.lblPrazoEntregaFiltro.TabIndex = 2
        Me.lblPrazoEntregaFiltro.Text = "Previsão de Entrega:"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.lblCongelarColuna)
        Me.grpControle.Controls.Add(Me.cboCongelarColuna)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(308, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(682, 51)
        Me.grpControle.TabIndex = 4
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(6, 22)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 0
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(101, 19)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(92, 20)
        Me.cboCongelarColuna.TabIndex = 1
        Me.cboCongelarColuna.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(582, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrQAInspecaoRecebimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 14!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrQAInspecaoRecebimento"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabMain.ResumeLayout(false)
        Me.pagListagem.ResumeLayout(false)
        CType(Me.grdListagem,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpLegenda,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpLegenda.ResumeLayout(false)
        Me.grpLegenda.PerformLayout
        CType(Me.picLegendaEntregue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picLegendaAguardandoEntrega,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picLegendaAtrasado,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpFiltro,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpFiltro.ResumeLayout(false)
        Me.grpFiltro.PerformLayout
        CType(Me.grpControle,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpControle.ResumeLayout(false)
        Me.grpControle.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNumeroPedidoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroPedidoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblFornecedorFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblPrazoEntregaFiltro As System.Windows.Forms.Label
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaAtrasado As System.Windows.Forms.Label
    Friend WithEvents picLegendaAtrasado As System.Windows.Forms.PictureBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtFornecedorFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtItemFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblItemFiltro As System.Windows.Forms.Label
    Friend WithEvents picLegendaEntregue As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaEntregue As System.Windows.Forms.Label
    Friend WithEvents picLegendaAguardandoEntrega As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAguardandoEntrega As System.Windows.Forms.Label
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataPrevisaoEntregaInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPrevisaoEntregaTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents lblFolloUpFiltro As System.Windows.Forms.Label
    Friend WithEvents cboFollowUpFitro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents dtpDataEntregaInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEntregaTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEntregaFiltro As System.Windows.Forms.Label
    Friend WithEvents chkAguardandoInspecao As Janus.Windows.EditControls.UICheckBox

End Class
