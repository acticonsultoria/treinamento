<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFat000000023
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFat000000023))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboTipoDocumentoFiscal = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoItem = New System.Windows.Forms.Label()
        Me.txtCodigoItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNotaFiscal = New System.Windows.Forms.Label()
        Me.txtNotaFiscal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataTermino = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.btnProcurarParceiroNegocio = New System.Windows.Forms.Button()
        Me.lblDataEntrada = New System.Windows.Forms.Label()
        Me.lblTipoDocumentoFiscal = New System.Windows.Forms.Label()
        Me.cboParceiroNegocio = New Janus.Windows.EditControls.UIComboBox()
        Me.lblParceiroNegocio = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNCMFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.chkExibirCancelada = New Janus.Windows.EditControls.UICheckBox()
        Me.chkSomenteFatura = New Janus.Windows.EditControls.UICheckBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.vsmMain.DefaultColorScheme = Nothing
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControle)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 453)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório de Faturamento - FAT000000023"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 373)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 90
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 373)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 3
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 373)
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
        Me.grdListagem.AutoEdit = True
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Location = New System.Drawing.Point(8, 73)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 317)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdListagem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.chkSomenteFatura)
        Me.grpFiltro.Controls.Add(Me.chkExibirCancelada)
        Me.grpFiltro.Controls.Add(Me.cboTipoDocumentoFiscal)
        Me.grpFiltro.Controls.Add(Me.lblCodigoItem)
        Me.grpFiltro.Controls.Add(Me.txtCodigoItem)
        Me.grpFiltro.Controls.Add(Me.lblNotaFiscal)
        Me.grpFiltro.Controls.Add(Me.txtNotaFiscal)
        Me.grpFiltro.Controls.Add(Me.dtpDataTermino)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicio)
        Me.grpFiltro.Controls.Add(Me.btnProcurarParceiroNegocio)
        Me.grpFiltro.Controls.Add(Me.lblDataEntrada)
        Me.grpFiltro.Controls.Add(Me.lblTipoDocumentoFiscal)
        Me.grpFiltro.Controls.Add(Me.cboParceiroNegocio)
        Me.grpFiltro.Controls.Add(Me.lblParceiroNegocio)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboTipoDocumentoFiscal
        '
        Me.cboTipoDocumentoFiscal.AutoSize = False
        Me.cboTipoDocumentoFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "ENTRADA"
        UiComboBoxItem1.Value = "E"
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "SAÍDA"
        UiComboBoxItem2.Value = "S"
        Me.cboTipoDocumentoFiscal.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboTipoDocumentoFiscal.Location = New System.Drawing.Point(498, 34)
        Me.cboTipoDocumentoFiscal.Name = "cboTipoDocumentoFiscal"
        Me.cboTipoDocumentoFiscal.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoDocumentoFiscal.Size = New System.Drawing.Size(130, 20)
        Me.cboTipoDocumentoFiscal.TabIndex = 37
        '
        'lblCodigoItem
        '
        Me.lblCodigoItem.AutoSize = True
        Me.lblCodigoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoItem.Location = New System.Drawing.Point(631, 17)
        Me.lblCodigoItem.Name = "lblCodigoItem"
        Me.lblCodigoItem.Size = New System.Drawing.Size(65, 14)
        Me.lblCodigoItem.TabIndex = 36
        Me.lblCodigoItem.Text = "Código Item:"
        '
        'txtCodigoItem
        '
        Me.txtCodigoItem.Location = New System.Drawing.Point(634, 34)
        Me.txtCodigoItem.Name = "txtCodigoItem"
        Me.txtCodigoItem.Size = New System.Drawing.Size(81, 20)
        Me.txtCodigoItem.TabIndex = 35
        '
        'lblNotaFiscal
        '
        Me.lblNotaFiscal.AutoSize = True
        Me.lblNotaFiscal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNotaFiscal.Location = New System.Drawing.Point(398, 17)
        Me.lblNotaFiscal.Name = "lblNotaFiscal"
        Me.lblNotaFiscal.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscal.TabIndex = 32
        Me.lblNotaFiscal.Text = "Nota Fiscal:"
        '
        'txtNotaFiscal
        '
        Me.txtNotaFiscal.Location = New System.Drawing.Point(401, 34)
        Me.txtNotaFiscal.Name = "txtNotaFiscal"
        Me.txtNotaFiscal.Size = New System.Drawing.Size(91, 20)
        Me.txtNotaFiscal.TabIndex = 31
        '
        'dtpDataTermino
        '
        '
        '
        '
        Me.dtpDataTermino.DropDownCalendar.Name = ""
        Me.dtpDataTermino.Location = New System.Drawing.Point(299, 34)
        Me.dtpDataTermino.Name = "dtpDataTermino"
        Me.dtpDataTermino.ShowCheckBox = True
        Me.dtpDataTermino.Size = New System.Drawing.Size(96, 20)
        Me.dtpDataTermino.TabIndex = 30
        Me.dtpDataTermino.Value = New Date(2012, 3, 27, 0, 0, 0, 0)
        '
        'dtpDataInicio
        '
        '
        '
        '
        Me.dtpDataInicio.DropDownCalendar.Name = ""
        Me.dtpDataInicio.Location = New System.Drawing.Point(197, 34)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.ShowCheckBox = True
        Me.dtpDataInicio.Size = New System.Drawing.Size(96, 20)
        Me.dtpDataInicio.TabIndex = 29
        Me.dtpDataInicio.Value = New Date(2012, 3, 27, 0, 0, 0, 0)
        '
        'btnProcurarParceiroNegocio
        '
        Me.btnProcurarParceiroNegocio.FlatAppearance.BorderSize = 0
        Me.btnProcurarParceiroNegocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarParceiroNegocio.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarParceiroNegocio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarParceiroNegocio.Location = New System.Drawing.Point(174, 16)
        Me.btnProcurarParceiroNegocio.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarParceiroNegocio.Name = "btnProcurarParceiroNegocio"
        Me.btnProcurarParceiroNegocio.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarParceiroNegocio.TabIndex = 26
        Me.btnProcurarParceiroNegocio.TabStop = False
        Me.btnProcurarParceiroNegocio.UseVisualStyleBackColor = True
        '
        'lblDataEntrada
        '
        Me.lblDataEntrada.AutoSize = True
        Me.lblDataEntrada.Location = New System.Drawing.Point(194, 17)
        Me.lblDataEntrada.Name = "lblDataEntrada"
        Me.lblDataEntrada.Size = New System.Drawing.Size(89, 14)
        Me.lblDataEntrada.TabIndex = 28
        Me.lblDataEntrada.Text = "Data Documento:"
        '
        'lblTipoDocumentoFiscal
        '
        Me.lblTipoDocumentoFiscal.AutoSize = True
        Me.lblTipoDocumentoFiscal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoDocumentoFiscal.Location = New System.Drawing.Point(495, 18)
        Me.lblTipoDocumentoFiscal.Name = "lblTipoDocumentoFiscal"
        Me.lblTipoDocumentoFiscal.Size = New System.Drawing.Size(133, 14)
        Me.lblTipoDocumentoFiscal.TabIndex = 27
        Me.lblTipoDocumentoFiscal.Text = "Tipo de Documento Fiscal:"
        '
        'cboParceiroNegocio
        '
        Me.cboParceiroNegocio.AutoSize = False
        Me.cboParceiroNegocio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboParceiroNegocio.Location = New System.Drawing.Point(9, 34)
        Me.cboParceiroNegocio.Name = "cboParceiroNegocio"
        Me.cboParceiroNegocio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboParceiroNegocio.Size = New System.Drawing.Size(182, 20)
        Me.cboParceiroNegocio.TabIndex = 25
        '
        'lblParceiroNegocio
        '
        Me.lblParceiroNegocio.AutoSize = True
        Me.lblParceiroNegocio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblParceiroNegocio.Location = New System.Drawing.Point(6, 17)
        Me.lblParceiroNegocio.Name = "lblParceiroNegocio"
        Me.lblParceiroNegocio.Size = New System.Drawing.Size(107, 14)
        Me.lblParceiroNegocio.TabIndex = 24
        Me.lblParceiroNegocio.Text = "Parceiro de Negócio:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 7
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnVisualizarImpressao)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 393)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(897, 51)
        Me.grpControle.TabIndex = 4
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnVisualizarImpressao
        '
        Me.btnVisualizarImpressao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarImpressao.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnVisualizarImpressao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarImpressao.Location = New System.Drawing.Point(647, 17)
        Me.btnVisualizarImpressao.Name = "btnVisualizarImpressao"
        Me.btnVisualizarImpressao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarImpressao.Size = New System.Drawing.Size(144, 23)
        Me.btnVisualizarImpressao.TabIndex = 3
        Me.btnVisualizarImpressao.Text = "Visualizar Impressão"
        Me.btnVisualizarImpressao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFiltro.Location = New System.Drawing.Point(121, 34)
        Me.txtDescricaoFiltro.MaxLength = 250
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        Me.txtDescricaoFiltro.Size = New System.Drawing.Size(375, 20)
        Me.txtDescricaoFiltro.TabIndex = 3
        '
        'txtNCMFiltro
        '
        Me.txtNCMFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNCMFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNCMFiltro.MaxLength = 15
        Me.txtNCMFiltro.Name = "txtNCMFiltro"
        Me.txtNCMFiltro.Size = New System.Drawing.Size(106, 20)
        Me.txtNCMFiltro.TabIndex = 1
        '
        'chkExibirCancelada
        '
        Me.chkExibirCancelada.Checked = True
        Me.chkExibirCancelada.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkExibirCancelada.Location = New System.Drawing.Point(721, 18)
        Me.chkExibirCancelada.Name = "chkExibirCancelada"
        Me.chkExibirCancelada.Size = New System.Drawing.Size(97, 17)
        Me.chkExibirCancelada.TabIndex = 38
        Me.chkExibirCancelada.Text = "Exibir Cancelada"
        '
        'chkSomenteFatura
        '
        Me.chkSomenteFatura.Location = New System.Drawing.Point(721, 41)
        Me.chkSomenteFatura.Name = "chkSomenteFatura"
        Me.chkSomenteFatura.Size = New System.Drawing.Size(97, 17)
        Me.chkSomenteFatura.TabIndex = 39
        Me.chkSomenteFatura.Text = "Somente Fatura"
        '
        'usrFat000000023
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFat000000023"
        Me.Size = New System.Drawing.Size(915, 476)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNCMFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents lblCodigoItem As System.Windows.Forms.Label
    Friend WithEvents txtCodigoItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents dtpDataTermino As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnProcurarParceiroNegocio As System.Windows.Forms.Button
    Friend WithEvents lblDataEntrada As System.Windows.Forms.Label
    Friend WithEvents lblTipoDocumentoFiscal As System.Windows.Forms.Label
    Friend WithEvents cboParceiroNegocio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblParceiroNegocio As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumentoFiscal As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnVisualizarImpressao As Janus.Windows.EditControls.UIButton
    Friend WithEvents chkExibirCancelada As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkSomenteFatura As Janus.Windows.EditControls.UICheckBox

End Class
