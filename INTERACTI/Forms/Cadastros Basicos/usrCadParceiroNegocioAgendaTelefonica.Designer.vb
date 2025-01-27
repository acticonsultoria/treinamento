<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadParceiroNegocioAgendaTelefonica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadParceiroNegocioAgendaTelefonica))
        Dim grdContato_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdContato_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdContato_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdCliente_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagContato = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdContato = New Janus.Windows.GridEX.GridEX()
        Me.pagCliente = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdCliente = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnEmailCadastro = New Janus.Windows.EditControls.UIButton()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnEmailCadastroASCON = New Janus.Windows.EditControls.UIButton()
        Me.btnEnviarEmailAniversario = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNumeroClienteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroCliente = New System.Windows.Forms.Label()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFiltro = New System.Windows.Forms.Label()
        Me.lblTipoDataFiltro = New System.Windows.Forms.Label()
        Me.cboTipoDataFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtComplementoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCelularContatoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCelularContato = New System.Windows.Forms.Label()
        Me.txtTelefoneContatoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTelefoneContato = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.txtRazaoSocialFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomeContatoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNomeContato = New System.Windows.Forms.Label()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagContato.SuspendLayout()
        CType(Me.grdContato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagCliente.SuspendLayout()
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
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
        resources.ApplyResources(Me.tabMain, "tabMain")
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpControl)
        Me.pagDados.Controls.Add(Me.grpFiltro)
        resources.ApplyResources(Me.pagDados, "pagDados")
        Me.pagDados.Key = "padDados"
        Me.pagDados.Name = "pagDados"
        Me.pagDados.TabStop = True
        '
        'tabDados
        '
        resources.ApplyResources(Me.tabDados, "tabDados")
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagContato, Me.pagCliente})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagContato
        '
        Me.pagContato.Controls.Add(Me.grdContato)
        resources.ApplyResources(Me.pagContato, "pagContato")
        Me.pagContato.Key = "padDados"
        Me.pagContato.Name = "pagContato"
        Me.pagContato.TabStop = True
        '
        'grdContato
        '
        Me.grdContato.AlternatingColors = True
        resources.ApplyResources(Me.grdContato, "grdContato")
        grdContato_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdContato_DesignTimeLayout_Reference_0.Instance"), Object)
        grdContato_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdContato_DesignTimeLayout_Reference_1.Instance"), Object)
        grdContato_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdContato_DesignTimeLayout_Reference_0, grdContato_DesignTimeLayout_Reference_1})
        resources.ApplyResources(grdContato_DesignTimeLayout, "grdContato_DesignTimeLayout")
        Me.grdContato.DesignTimeLayout = grdContato_DesignTimeLayout
        Me.grdContato.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdContato.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdContato.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdContato.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdContato.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdContato.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdContato.GroupByBoxVisible = False
        Me.grdContato.Hierarchical = True
        Me.grdContato.Name = "grdContato"
        Me.grdContato.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdContato.RecordNavigator = True
        Me.grdContato.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdContato.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdContato.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdContato.TabStop = False
        Me.grdContato.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdContato.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdContato.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdContato.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdContato.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdContato.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdContato.VisualStyleManager = Me.vsmMain
        '
        'pagCliente
        '
        Me.pagCliente.Controls.Add(Me.grdCliente)
        resources.ApplyResources(Me.pagCliente, "pagCliente")
        Me.pagCliente.Name = "pagCliente"
        Me.pagCliente.TabStop = True
        '
        'grdCliente
        '
        Me.grdCliente.AlternatingColors = True
        resources.ApplyResources(Me.grdCliente, "grdCliente")
        resources.ApplyResources(grdCliente_DesignTimeLayout, "grdCliente_DesignTimeLayout")
        Me.grdCliente.DesignTimeLayout = grdCliente_DesignTimeLayout
        Me.grdCliente.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdCliente.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdCliente.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdCliente.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdCliente.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdCliente.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdCliente.GroupByBoxVisible = False
        Me.grdCliente.Hierarchical = True
        Me.grdCliente.Name = "grdCliente"
        Me.grdCliente.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdCliente.RecordNavigator = True
        Me.grdCliente.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdCliente.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdCliente.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdCliente.TabStop = False
        Me.grdCliente.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdCliente.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdCliente.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdCliente.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdCliente.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdCliente.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdCliente.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        resources.ApplyResources(Me.grpControl, "grpControl")
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnEmailCadastro)
        Me.grpControl.Controls.Add(Me.btnExcel)
        Me.grpControl.Controls.Add(Me.btnEmailCadastroASCON)
        Me.grpControl.Controls.Add(Me.btnEnviarEmailAniversario)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnEmailCadastro
        '
        resources.ApplyResources(Me.btnEmailCadastro, "btnEmailCadastro")
        Me.btnEmailCadastro.Image = Global.INTERACTI.My.Resources.Resources.email
        Me.btnEmailCadastro.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnEmailCadastro.Name = "btnEmailCadastro"
        Me.btnEmailCadastro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnEmailCadastro.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'btnEmailCadastroASCON
        '
        resources.ApplyResources(Me.btnEmailCadastroASCON, "btnEmailCadastroASCON")
        Me.btnEmailCadastroASCON.Image = Global.INTERACTI.My.Resources.Resources.email
        Me.btnEmailCadastroASCON.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnEmailCadastroASCON.Name = "btnEmailCadastroASCON"
        Me.btnEmailCadastroASCON.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnEmailCadastroASCON.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnEnviarEmailAniversario
        '
        resources.ApplyResources(Me.btnEnviarEmailAniversario, "btnEnviarEmailAniversario")
        Me.btnEnviarEmailAniversario.Image = Global.INTERACTI.My.Resources.Resources.email
        Me.btnEnviarEmailAniversario.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnEnviarEmailAniversario.Name = "btnEnviarEmailAniversario"
        Me.btnEnviarEmailAniversario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnEnviarEmailAniversario.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'grpFiltro
        '
        resources.ApplyResources(Me.grpFiltro, "grpFiltro")
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtNumeroClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroCliente)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoDataFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoDataFiltro)
        Me.grpFiltro.Controls.Add(Me.txtComplementoFiltro)
        Me.grpFiltro.Controls.Add(Me.Label2)
        Me.grpFiltro.Controls.Add(Me.txtCelularContatoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCelularContato)
        Me.grpFiltro.Controls.Add(Me.txtTelefoneContatoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTelefoneContato)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.txtRazaoSocialFiltro)
        Me.grpFiltro.Controls.Add(Me.Label1)
        Me.grpFiltro.Controls.Add(Me.txtNomeContatoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNomeContato)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroClienteFiltro
        '
        resources.ApplyResources(Me.txtNumeroClienteFiltro, "txtNumeroClienteFiltro")
        Me.txtNumeroClienteFiltro.MaxLength = 5
        Me.txtNumeroClienteFiltro.Name = "txtNumeroClienteFiltro"
        SuperTipSettings1.HeaderText = "Código de Integração"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = "Utilizado para empresas que possuem Webservice para input de Pedido de Compra"
        Me.jstTip.SetSuperTip(Me.txtNumeroClienteFiltro, SuperTipSettings1)
        '
        'lblNumeroCliente
        '
        resources.ApplyResources(Me.lblNumeroCliente, "lblNumeroCliente")
        Me.lblNumeroCliente.Name = "lblNumeroCliente"
        '
        'dtpDataInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        resources.ApplyResources(Me.dtpDataInicioFiltro, "dtpDataInicioFiltro")
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        resources.ApplyResources(Me.dtpDataTerminoFiltro, "dtpDataTerminoFiltro")
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        '
        'lblDataFiltro
        '
        resources.ApplyResources(Me.lblDataFiltro, "lblDataFiltro")
        Me.lblDataFiltro.Name = "lblDataFiltro"
        '
        'lblTipoDataFiltro
        '
        resources.ApplyResources(Me.lblTipoDataFiltro, "lblTipoDataFiltro")
        Me.lblTipoDataFiltro.Name = "lblTipoDataFiltro"
        '
        'cboTipoDataFiltro
        '
        resources.ApplyResources(Me.cboTipoDataFiltro, "cboTipoDataFiltro")
        Me.cboTipoDataFiltro.Name = "cboTipoDataFiltro"
        Me.cboTipoDataFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtComplementoFiltro
        '
        Me.txtComplementoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtComplementoFiltro, "txtComplementoFiltro")
        Me.txtComplementoFiltro.MaxLength = 70
        Me.txtComplementoFiltro.Name = "txtComplementoFiltro"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtCelularContatoFiltro
        '
        resources.ApplyResources(Me.txtCelularContatoFiltro, "txtCelularContatoFiltro")
        Me.txtCelularContatoFiltro.Mask = "!(##) 00000-0000"
        Me.txtCelularContatoFiltro.MaxLength = 0
        Me.txtCelularContatoFiltro.Name = "txtCelularContatoFiltro"
        '
        'lblCelularContato
        '
        resources.ApplyResources(Me.lblCelularContato, "lblCelularContato")
        Me.lblCelularContato.Name = "lblCelularContato"
        '
        'txtTelefoneContatoFiltro
        '
        resources.ApplyResources(Me.txtTelefoneContatoFiltro, "txtTelefoneContatoFiltro")
        Me.txtTelefoneContatoFiltro.MaxLength = 10
        Me.txtTelefoneContatoFiltro.Name = "txtTelefoneContatoFiltro"
        '
        'lblTelefoneContato
        '
        resources.ApplyResources(Me.lblTelefoneContato, "lblTelefoneContato")
        Me.lblTelefoneContato.Name = "lblTelefoneContato"
        '
        'btnFiltrar
        '
        resources.ApplyResources(Me.btnFiltrar, "btnFiltrar")
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtRazaoSocialFiltro
        '
        Me.txtRazaoSocialFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtRazaoSocialFiltro, "txtRazaoSocialFiltro")
        Me.txtRazaoSocialFiltro.MaxLength = 70
        Me.txtRazaoSocialFiltro.Name = "txtRazaoSocialFiltro"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtNomeContatoFiltro
        '
        Me.txtNomeContatoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtNomeContatoFiltro, "txtNomeContatoFiltro")
        Me.txtNomeContatoFiltro.MaxLength = 70
        Me.txtNomeContatoFiltro.Name = "txtNomeContatoFiltro"
        '
        'lblNomeContato
        '
        resources.ApplyResources(Me.lblNomeContato, "lblNomeContato")
        Me.lblNomeContato.Name = "lblNomeContato"
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
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'usrCadParceiroNegocioAgendaTelefonica
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrCadParceiroNegocioAgendaTelefonica"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagContato.ResumeLayout(False)
        CType(Me.grdContato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagCliente.ResumeLayout(False)
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNomeContatoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNomeContato As System.Windows.Forms.Label
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents MaskedEditBox1 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCelularContatoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCelularContato As System.Windows.Forms.Label
    Friend WithEvents txtTelefoneContatoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTelefoneContato As System.Windows.Forms.Label
    Friend WithEvents txtRazaoSocialFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtComplementoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagContato As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdContato As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagCliente As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnEmailCadastroASCON As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnEnviarEmailAniversario As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblTipoDataFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoDataFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFiltro As System.Windows.Forms.Label
    Friend WithEvents grdCliente As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnEmailCadastro As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtNumeroClienteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroCliente As System.Windows.Forms.Label

End Class
