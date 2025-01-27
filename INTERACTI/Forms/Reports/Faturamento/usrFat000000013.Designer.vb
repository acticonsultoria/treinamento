<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFat000000013
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
        Dim cboStatusNotaFiscal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFat000000013))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboStatusNotaFiscal = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblStatusNotaFiscal = New System.Windows.Forms.Label()
        Me.lblIntegraFinanceiro = New System.Windows.Forms.Label()
        Me.cboIntegraFinanceiro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMostrarValores = New System.Windows.Forms.Label()
        Me.cboMostrarValores = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNotaFiscal = New System.Windows.Forms.Label()
        Me.txtNotaFiscal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.dtpDataTermino = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.btnProcurarParceiroNegocio = New System.Windows.Forms.Button()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.lblTipoDocumentoFiscal = New System.Windows.Forms.Label()
        Me.cboTipoDocumentoFiscal = New Janus.Windows.EditControls.UIComboBox()
        Me.cboParceiroNegocio = New Janus.Windows.EditControls.UIComboBox()
        Me.lblParceiroNegocio = New System.Windows.Forms.Label()
        Me.picSistema = New System.Windows.Forms.PictureBox()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(507, 394)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.picSistema)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(505, 371)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório Faturamento - FAT000000013"
        '
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboStatusNotaFiscal)
        Me.grpFiltro.Controls.Add(Me.lblStatusNotaFiscal)
        Me.grpFiltro.Controls.Add(Me.lblIntegraFinanceiro)
        Me.grpFiltro.Controls.Add(Me.cboIntegraFinanceiro)
        Me.grpFiltro.Controls.Add(Me.lblMostrarValores)
        Me.grpFiltro.Controls.Add(Me.cboMostrarValores)
        Me.grpFiltro.Controls.Add(Me.lblNotaFiscal)
        Me.grpFiltro.Controls.Add(Me.txtNotaFiscal)
        Me.grpFiltro.Controls.Add(Me.dtpDataTermino)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicio)
        Me.grpFiltro.Controls.Add(Me.btnProcurarParceiroNegocio)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissao)
        Me.grpFiltro.Controls.Add(Me.lblTipoDocumentoFiscal)
        Me.grpFiltro.Controls.Add(Me.cboTipoDocumentoFiscal)
        Me.grpFiltro.Controls.Add(Me.cboParceiroNegocio)
        Me.grpFiltro.Controls.Add(Me.lblParceiroNegocio)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 120)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(489, 191)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboStatusNotaFiscal
        '
        Me.cboStatusNotaFiscal.AllowDrop = True
        Me.cboStatusNotaFiscal.ButtonCancelText = "Cancelar"
        Me.cboStatusNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusNotaFiscal_DesignTimeLayout.LayoutString = resources.GetString("cboStatusNotaFiscal_DesignTimeLayout.LayoutString")
        Me.cboStatusNotaFiscal.DesignTimeLayout = cboStatusNotaFiscal_DesignTimeLayout
        Me.cboStatusNotaFiscal.Location = New System.Drawing.Point(9, 120)
        Me.cboStatusNotaFiscal.Name = "cboStatusNotaFiscal"
        Me.cboStatusNotaFiscal.SaveSettings = False
        Me.cboStatusNotaFiscal.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusNotaFiscal.Size = New System.Drawing.Size(471, 20)
        Me.cboStatusNotaFiscal.TabIndex = 21
        Me.cboStatusNotaFiscal.ValuesDataMember = Nothing
        '
        'lblStatusNotaFiscal
        '
        Me.lblStatusNotaFiscal.AutoSize = True
        Me.lblStatusNotaFiscal.Location = New System.Drawing.Point(6, 103)
        Me.lblStatusNotaFiscal.Name = "lblStatusNotaFiscal"
        Me.lblStatusNotaFiscal.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusNotaFiscal.TabIndex = 20
        Me.lblStatusNotaFiscal.Text = "Status:"
        '
        'lblIntegraFinanceiro
        '
        Me.lblIntegraFinanceiro.AutoSize = True
        Me.lblIntegraFinanceiro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIntegraFinanceiro.Location = New System.Drawing.Point(6, 143)
        Me.lblIntegraFinanceiro.Name = "lblIntegraFinanceiro"
        Me.lblIntegraFinanceiro.Size = New System.Drawing.Size(96, 14)
        Me.lblIntegraFinanceiro.TabIndex = 18
        Me.lblIntegraFinanceiro.Text = "Integra Financeiro:"
        '
        'cboIntegraFinanceiro
        '
        Me.cboIntegraFinanceiro.AutoSize = False
        Me.cboIntegraFinanceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "ENTRADA"
        UiComboBoxItem1.Value = "E"
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "SAÍDA"
        UiComboBoxItem2.Value = "S"
        Me.cboIntegraFinanceiro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboIntegraFinanceiro.Location = New System.Drawing.Point(9, 160)
        Me.cboIntegraFinanceiro.Name = "cboIntegraFinanceiro"
        Me.cboIntegraFinanceiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboIntegraFinanceiro.Size = New System.Drawing.Size(222, 20)
        Me.cboIntegraFinanceiro.TabIndex = 19
        '
        'lblMostrarValores
        '
        Me.lblMostrarValores.AutoSize = True
        Me.lblMostrarValores.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMostrarValores.Location = New System.Drawing.Point(234, 143)
        Me.lblMostrarValores.Name = "lblMostrarValores"
        Me.lblMostrarValores.Size = New System.Drawing.Size(87, 14)
        Me.lblMostrarValores.TabIndex = 16
        Me.lblMostrarValores.Text = "Mostrar Valores:"
        '
        'cboMostrarValores
        '
        Me.cboMostrarValores.AutoSize = False
        Me.cboMostrarValores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "ENTRADA"
        UiComboBoxItem3.Value = "E"
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "SAÍDA"
        UiComboBoxItem4.Value = "S"
        Me.cboMostrarValores.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboMostrarValores.Location = New System.Drawing.Point(237, 160)
        Me.cboMostrarValores.Name = "cboMostrarValores"
        Me.cboMostrarValores.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMostrarValores.Size = New System.Drawing.Size(243, 20)
        Me.cboMostrarValores.TabIndex = 17
        '
        'lblNotaFiscal
        '
        Me.lblNotaFiscal.AutoSize = True
        Me.lblNotaFiscal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNotaFiscal.Location = New System.Drawing.Point(234, 61)
        Me.lblNotaFiscal.Name = "lblNotaFiscal"
        Me.lblNotaFiscal.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscal.TabIndex = 15
        Me.lblNotaFiscal.Text = "Nota Fiscal:"
        '
        'txtNotaFiscal
        '
        Me.txtNotaFiscal.Location = New System.Drawing.Point(237, 78)
        Me.txtNotaFiscal.Name = "txtNotaFiscal"
        Me.txtNotaFiscal.Size = New System.Drawing.Size(91, 20)
        Me.txtNotaFiscal.TabIndex = 14
        '
        'dtpDataTermino
        '
        '
        '
        '
        Me.dtpDataTermino.DropDownCalendar.Name = ""
        Me.dtpDataTermino.Location = New System.Drawing.Point(123, 78)
        Me.dtpDataTermino.Name = "dtpDataTermino"
        Me.dtpDataTermino.ShowCheckBox = True
        Me.dtpDataTermino.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataTermino.TabIndex = 7
        Me.dtpDataTermino.Value = New Date(2012, 3, 27, 0, 0, 0, 0)
        '
        'dtpDataInicio
        '
        '
        '
        '
        Me.dtpDataInicio.DropDownCalendar.Name = ""
        Me.dtpDataInicio.Location = New System.Drawing.Point(9, 78)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.ShowCheckBox = True
        Me.dtpDataInicio.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInicio.TabIndex = 6
        Me.dtpDataInicio.Value = New Date(2012, 3, 27, 0, 0, 0, 0)
        '
        'btnProcurarParceiroNegocio
        '
        Me.btnProcurarParceiroNegocio.FlatAppearance.BorderSize = 0
        Me.btnProcurarParceiroNegocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarParceiroNegocio.Image = Global.INTERACTI.My.Resources.search
        Me.btnProcurarParceiroNegocio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarParceiroNegocio.Location = New System.Drawing.Point(463, 18)
        Me.btnProcurarParceiroNegocio.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarParceiroNegocio.Name = "btnProcurarParceiroNegocio"
        Me.btnProcurarParceiroNegocio.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarParceiroNegocio.TabIndex = 2
        Me.btnProcurarParceiroNegocio.TabStop = False
        Me.btnProcurarParceiroNegocio.UseVisualStyleBackColor = True
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(6, 61)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissao.TabIndex = 5
        Me.lblDataEmissao.Text = "Data Emissão:"
        '
        'lblTipoDocumentoFiscal
        '
        Me.lblTipoDocumentoFiscal.AutoSize = True
        Me.lblTipoDocumentoFiscal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoDocumentoFiscal.Location = New System.Drawing.Point(331, 61)
        Me.lblTipoDocumentoFiscal.Name = "lblTipoDocumentoFiscal"
        Me.lblTipoDocumentoFiscal.Size = New System.Drawing.Size(133, 14)
        Me.lblTipoDocumentoFiscal.TabIndex = 3
        Me.lblTipoDocumentoFiscal.Text = "Tipo de Documento Fiscal:"
        '
        'cboTipoDocumentoFiscal
        '
        Me.cboTipoDocumentoFiscal.AutoSize = False
        Me.cboTipoDocumentoFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "ENTRADA"
        UiComboBoxItem5.Value = "E"
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "SAÍDA"
        UiComboBoxItem6.Value = "S"
        Me.cboTipoDocumentoFiscal.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboTipoDocumentoFiscal.Location = New System.Drawing.Point(334, 78)
        Me.cboTipoDocumentoFiscal.Name = "cboTipoDocumentoFiscal"
        Me.cboTipoDocumentoFiscal.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoDocumentoFiscal.Size = New System.Drawing.Size(146, 20)
        Me.cboTipoDocumentoFiscal.TabIndex = 4
        '
        'cboParceiroNegocio
        '
        Me.cboParceiroNegocio.AutoSize = False
        Me.cboParceiroNegocio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboParceiroNegocio.Location = New System.Drawing.Point(9, 37)
        Me.cboParceiroNegocio.Name = "cboParceiroNegocio"
        Me.cboParceiroNegocio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboParceiroNegocio.Size = New System.Drawing.Size(471, 20)
        Me.cboParceiroNegocio.TabIndex = 1
        '
        'lblParceiroNegocio
        '
        Me.lblParceiroNegocio.AutoSize = True
        Me.lblParceiroNegocio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblParceiroNegocio.Location = New System.Drawing.Point(6, 20)
        Me.lblParceiroNegocio.Name = "lblParceiroNegocio"
        Me.lblParceiroNegocio.Size = New System.Drawing.Size(107, 14)
        Me.lblParceiroNegocio.TabIndex = 0
        Me.lblParceiroNegocio.Text = "Parceiro de Negócio:"
        '
        'picSistema
        '
        Me.picSistema.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picSistema.BackColor = System.Drawing.Color.White
        Me.picSistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSistema.Image = Global.INTERACTI.My.Resources.Interacti
        Me.picSistema.Location = New System.Drawing.Point(8, 8)
        Me.picSistema.Name = "picSistema"
        Me.picSistema.Size = New System.Drawing.Size(489, 109)
        Me.picSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSistema.TabIndex = 15
        Me.picSistema.TabStop = False
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnVisualizarImpressao)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 311)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(489, 51)
        Me.grpControl.TabIndex = 1
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnVisualizarImpressao
        '
        Me.btnVisualizarImpressao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarImpressao.Image = Global.INTERACTI.My.Resources.imprimir
        Me.btnVisualizarImpressao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarImpressao.Location = New System.Drawing.Point(183, 17)
        Me.btnVisualizarImpressao.Name = "btnVisualizarImpressao"
        Me.btnVisualizarImpressao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarImpressao.Size = New System.Drawing.Size(200, 23)
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
        Me.btnSair.Location = New System.Drawing.Point(389, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrFat0000000012
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFat0000000012"
        Me.Size = New System.Drawing.Size(507, 394)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents picSistema As System.Windows.Forms.PictureBox
    Friend WithEvents btnVisualizarImpressao As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents lblTipoDocumentoFiscal As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumentoFiscal As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboParceiroNegocio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblParceiroNegocio As System.Windows.Forms.Label
    Friend WithEvents btnProcurarParceiroNegocio As System.Windows.Forms.Button
    Friend WithEvents dtpDataTermino As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblIntegraFinanceiro As System.Windows.Forms.Label
    Friend WithEvents cboIntegraFinanceiro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMostrarValores As System.Windows.Forms.Label
    Friend WithEvents cboMostrarValores As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboStatusNotaFiscal As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblStatusNotaFiscal As System.Windows.Forms.Label

End Class
