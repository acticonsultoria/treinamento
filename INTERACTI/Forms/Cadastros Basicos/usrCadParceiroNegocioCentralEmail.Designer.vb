<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadParceiroNegocioCentralEmail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadParceiroNegocioCentralEmail))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdContato_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdContato_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdContato_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnEnviarEmail = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtContato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.cboEmpresa = New Janus.Windows.EditControls.UIComboBox()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.lblContato = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.cboTipoEmail = New Janus.Windows.EditControls.UIComboBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblTipoEmail = New System.Windows.Forms.Label()
        Me.btnExcelGridContato = New System.Windows.Forms.Button()
        Me.btnAgruparGridContato = New System.Windows.Forms.Button()
        Me.btnConfigurarGridContato = New System.Windows.Forms.Button()
        Me.grdContato = New Janus.Windows.GridEX.GridEX()
        Me.grpEndereco = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarTipoContato = New System.Windows.Forms.Button()
        Me.dtpDataAniversario = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataAniversario = New System.Windows.Forms.Label()
        Me.txtCelularContato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCelularContato = New System.Windows.Forms.Label()
        Me.txtTelefoneContato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTipoContato = New System.Windows.Forms.Label()
        Me.cboTipoContato = New Janus.Windows.EditControls.UIComboBox()
        Me.txtEmailContato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtComplementoContato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNomeContato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblComplementoContato = New System.Windows.Forms.Label()
        Me.lblEmailContato = New System.Windows.Forms.Label()
        Me.lblTelefoneContato = New System.Windows.Forms.Label()
        Me.lblNomeContato = New System.Windows.Forms.Label()
        Me.btnExcluirContato = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvarContato = New Janus.Windows.EditControls.UIButton()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grdContato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEndereco.SuspendLayout()
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
        Me.pagDados.Controls.Add(Me.btnAgruparGrid)
        Me.pagDados.Controls.Add(Me.btnExcelGrid)
        Me.pagDados.Controls.Add(Me.btnConfigurarGrid)
        Me.pagDados.Controls.Add(Me.grdListagem)
        Me.pagDados.Controls.Add(Me.grpControl)
        Me.pagDados.Controls.Add(Me.grpDados)
        resources.ApplyResources(Me.pagDados, "pagDados")
        Me.pagDados.Key = "padDados"
        Me.pagDados.Name = "pagDados"
        Me.pagDados.TabStop = True
        '
        'btnAgruparGrid
        '
        resources.ApplyResources(Me.btnAgruparGrid, "btnAgruparGrid")
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnExcelGrid
        '
        resources.ApplyResources(Me.btnExcelGrid, "btnExcelGrid")
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        resources.ApplyResources(Me.btnConfigurarGrid, "btnConfigurarGrid")
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        resources.ApplyResources(Me.grdListagem, "grdListagem")
        resources.ApplyResources(grdListagem_DesignTimeLayout, "grdListagem_DesignTimeLayout")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        resources.ApplyResources(Me.grpControl, "grpControl")
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnEnviarEmail)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnEnviarEmail
        '
        resources.ApplyResources(Me.btnEnviarEmail, "btnEnviarEmail")
        Me.btnEnviarEmail.Image = Global.INTERACTI.My.Resources.Resources.email
        Me.btnEnviarEmail.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnEnviarEmail.Name = "btnEnviarEmail"
        Me.btnEnviarEmail.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnEnviarEmail.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'grpDados
        '
        resources.ApplyResources(Me.grpDados, "grpDados")
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtCliente)
        Me.grpDados.Controls.Add(Me.txtContato)
        Me.grpDados.Controls.Add(Me.txtArquivo)
        Me.grpDados.Controls.Add(Me.btnArquivo)
        Me.grpDados.Controls.Add(Me.lblArquivo)
        Me.grpDados.Controls.Add(Me.cboEmpresa)
        Me.grpDados.Controls.Add(Me.lblEmpresa)
        Me.grpDados.Controls.Add(Me.lblContato)
        Me.grpDados.Controls.Add(Me.lblCliente)
        Me.grpDados.Controls.Add(Me.cboTipoEmail)
        Me.grpDados.Controls.Add(Me.btnFiltrar)
        Me.grpDados.Controls.Add(Me.lblTipoEmail)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtCliente
        '
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtCliente, "txtCliente")
        Me.txtCliente.MaxLength = 500
        Me.txtCliente.Name = "txtCliente"
        '
        'txtContato
        '
        Me.txtContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtContato, "txtContato")
        Me.txtContato.MaxLength = 500
        Me.txtContato.Name = "txtContato"
        '
        'txtArquivo
        '
        resources.ApplyResources(Me.txtArquivo, "txtArquivo")
        Me.txtArquivo.BackColor = System.Drawing.SystemColors.Info
        Me.txtArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivo.MaxLength = 50
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.TabStop = False
        '
        'btnArquivo
        '
        resources.ApplyResources(Me.btnArquivo, "btnArquivo")
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivo
        '
        resources.ApplyResources(Me.lblArquivo, "lblArquivo")
        Me.lblArquivo.Name = "lblArquivo"
        '
        'cboEmpresa
        '
        resources.ApplyResources(Me.cboEmpresa, "cboEmpresa")
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblEmpresa
        '
        resources.ApplyResources(Me.lblEmpresa, "lblEmpresa")
        Me.lblEmpresa.Name = "lblEmpresa"
        '
        'lblContato
        '
        resources.ApplyResources(Me.lblContato, "lblContato")
        Me.lblContato.Name = "lblContato"
        '
        'lblCliente
        '
        resources.ApplyResources(Me.lblCliente, "lblCliente")
        Me.lblCliente.Name = "lblCliente"
        '
        'cboTipoEmail
        '
        resources.ApplyResources(Me.cboTipoEmail, "cboTipoEmail")
        Me.cboTipoEmail.Name = "cboTipoEmail"
        Me.cboTipoEmail.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
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
        'lblTipoEmail
        '
        resources.ApplyResources(Me.lblTipoEmail, "lblTipoEmail")
        Me.lblTipoEmail.Name = "lblTipoEmail"
        '
        'btnExcelGridContato
        '
        resources.ApplyResources(Me.btnExcelGridContato, "btnExcelGridContato")
        Me.btnExcelGridContato.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridContato.FlatAppearance.BorderSize = 0
        Me.btnExcelGridContato.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridContato.Name = "btnExcelGridContato"
        Me.btnExcelGridContato.TabStop = False
        Me.btnExcelGridContato.UseVisualStyleBackColor = False
        '
        'btnAgruparGridContato
        '
        resources.ApplyResources(Me.btnAgruparGridContato, "btnAgruparGridContato")
        Me.btnAgruparGridContato.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridContato.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridContato.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridContato.Name = "btnAgruparGridContato"
        Me.btnAgruparGridContato.TabStop = False
        Me.btnAgruparGridContato.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridContato
        '
        resources.ApplyResources(Me.btnConfigurarGridContato, "btnConfigurarGridContato")
        Me.btnConfigurarGridContato.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridContato.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridContato.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridContato.Name = "btnConfigurarGridContato"
        Me.btnConfigurarGridContato.TabStop = False
        Me.btnConfigurarGridContato.UseVisualStyleBackColor = False
        '
        'grdContato
        '
        Me.grdContato.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdContato.AlternatingColors = True
        resources.ApplyResources(Me.grdContato, "grdContato")
        grdContato_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdContato_DesignTimeLayout_Reference_0.Instance"), Object)
        grdContato_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdContato_DesignTimeLayout_Reference_1.Instance"), Object)
        grdContato_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdContato_DesignTimeLayout_Reference_0, grdContato_DesignTimeLayout_Reference_1})
        resources.ApplyResources(grdContato_DesignTimeLayout, "grdContato_DesignTimeLayout")
        Me.grdContato.DesignTimeLayout = grdContato_DesignTimeLayout
        Me.grdContato.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdContato.FrozenColumns = 3
        Me.grdContato.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdContato.GroupByBoxVisible = False
        Me.grdContato.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdContato.Name = "grdContato"
        Me.grdContato.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdContato.RecordNavigator = True
        Me.grdContato.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdContato.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdContato.TabStop = False
        Me.grdContato.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdContato.VisualStyleManager = Me.vsmMain
        '
        'grpEndereco
        '
        resources.ApplyResources(Me.grpEndereco, "grpEndereco")
        Me.grpEndereco.BackColor = System.Drawing.Color.Transparent
        Me.grpEndereco.Controls.Add(Me.btnCadastrarTipoContato)
        Me.grpEndereco.Controls.Add(Me.dtpDataAniversario)
        Me.grpEndereco.Controls.Add(Me.lblDataAniversario)
        Me.grpEndereco.Controls.Add(Me.txtCelularContato)
        Me.grpEndereco.Controls.Add(Me.lblCelularContato)
        Me.grpEndereco.Controls.Add(Me.txtTelefoneContato)
        Me.grpEndereco.Controls.Add(Me.lblTipoContato)
        Me.grpEndereco.Controls.Add(Me.cboTipoContato)
        Me.grpEndereco.Controls.Add(Me.txtEmailContato)
        Me.grpEndereco.Controls.Add(Me.txtComplementoContato)
        Me.grpEndereco.Controls.Add(Me.txtNomeContato)
        Me.grpEndereco.Controls.Add(Me.lblComplementoContato)
        Me.grpEndereco.Controls.Add(Me.lblEmailContato)
        Me.grpEndereco.Controls.Add(Me.lblTelefoneContato)
        Me.grpEndereco.Controls.Add(Me.lblNomeContato)
        Me.grpEndereco.Controls.Add(Me.btnExcluirContato)
        Me.grpEndereco.Controls.Add(Me.btnSalvarContato)
        Me.grpEndereco.Name = "grpEndereco"
        Me.grpEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEndereco.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpEndereco.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarTipoContato
        '
        Me.btnCadastrarTipoContato.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarTipoContato, "btnCadastrarTipoContato")
        Me.btnCadastrarTipoContato.Name = "btnCadastrarTipoContato"
        Me.btnCadastrarTipoContato.TabStop = False
        Me.btnCadastrarTipoContato.UseVisualStyleBackColor = True
        '
        'dtpDataAniversario
        '
        '
        '
        '
        Me.dtpDataAniversario.DropDownCalendar.Name = ""
        resources.ApplyResources(Me.dtpDataAniversario, "dtpDataAniversario")
        Me.dtpDataAniversario.Name = "dtpDataAniversario"
        Me.dtpDataAniversario.ShowCheckBox = True
        Me.dtpDataAniversario.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblDataAniversario
        '
        resources.ApplyResources(Me.lblDataAniversario, "lblDataAniversario")
        Me.lblDataAniversario.Name = "lblDataAniversario"
        '
        'txtCelularContato
        '
        resources.ApplyResources(Me.txtCelularContato, "txtCelularContato")
        Me.txtCelularContato.Mask = "!(##) 0000-0000"
        Me.txtCelularContato.MaxLength = 10
        Me.txtCelularContato.Name = "txtCelularContato"
        '
        'lblCelularContato
        '
        resources.ApplyResources(Me.lblCelularContato, "lblCelularContato")
        Me.lblCelularContato.Name = "lblCelularContato"
        '
        'txtTelefoneContato
        '
        resources.ApplyResources(Me.txtTelefoneContato, "txtTelefoneContato")
        Me.txtTelefoneContato.Mask = "!(##) 0000-0000"
        Me.txtTelefoneContato.MaxLength = 10
        Me.txtTelefoneContato.Name = "txtTelefoneContato"
        '
        'lblTipoContato
        '
        resources.ApplyResources(Me.lblTipoContato, "lblTipoContato")
        Me.lblTipoContato.Name = "lblTipoContato"
        '
        'cboTipoContato
        '
        resources.ApplyResources(Me.cboTipoContato, "cboTipoContato")
        Me.cboTipoContato.Name = "cboTipoContato"
        Me.cboTipoContato.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtEmailContato
        '
        Me.txtEmailContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        resources.ApplyResources(Me.txtEmailContato, "txtEmailContato")
        Me.txtEmailContato.MaxLength = 100
        Me.txtEmailContato.Name = "txtEmailContato"
        '
        'txtComplementoContato
        '
        Me.txtComplementoContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtComplementoContato, "txtComplementoContato")
        Me.txtComplementoContato.MaxLength = 50
        Me.txtComplementoContato.Name = "txtComplementoContato"
        '
        'txtNomeContato
        '
        Me.txtNomeContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtNomeContato, "txtNomeContato")
        Me.txtNomeContato.MaxLength = 70
        Me.txtNomeContato.Name = "txtNomeContato"
        '
        'lblComplementoContato
        '
        resources.ApplyResources(Me.lblComplementoContato, "lblComplementoContato")
        Me.lblComplementoContato.Name = "lblComplementoContato"
        '
        'lblEmailContato
        '
        resources.ApplyResources(Me.lblEmailContato, "lblEmailContato")
        Me.lblEmailContato.Name = "lblEmailContato"
        '
        'lblTelefoneContato
        '
        resources.ApplyResources(Me.lblTelefoneContato, "lblTelefoneContato")
        Me.lblTelefoneContato.Name = "lblTelefoneContato"
        '
        'lblNomeContato
        '
        resources.ApplyResources(Me.lblNomeContato, "lblNomeContato")
        Me.lblNomeContato.Name = "lblNomeContato"
        '
        'btnExcluirContato
        '
        resources.ApplyResources(Me.btnExcluirContato, "btnExcluirContato")
        Me.btnExcluirContato.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirContato.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirContato.Name = "btnExcluirContato"
        Me.btnExcluirContato.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirContato.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvarContato
        '
        resources.ApplyResources(Me.btnSalvarContato, "btnSalvarContato")
        Me.btnSalvarContato.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvarContato.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvarContato.Name = "btnSalvarContato"
        Me.btnSalvarContato.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvarContato.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'usrCadParceiroNegocioCentralEmail
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrCadParceiroNegocioCentralEmail"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grdContato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEndereco.ResumeLayout(False)
        Me.grpEndereco.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents grdContato As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelGridContato As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridContato As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridContato As System.Windows.Forms.Button
    Friend WithEvents grpEndereco As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarTipoContato As System.Windows.Forms.Button
    Friend WithEvents dtpDataAniversario As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataAniversario As System.Windows.Forms.Label
    Friend WithEvents txtCelularContato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCelularContato As System.Windows.Forms.Label
    Friend WithEvents txtTelefoneContato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipoContato As System.Windows.Forms.Label
    Friend WithEvents cboTipoContato As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtEmailContato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtComplementoContato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNomeContato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblComplementoContato As System.Windows.Forms.Label
    Friend WithEvents lblEmailContato As System.Windows.Forms.Label
    Friend WithEvents lblTelefoneContato As System.Windows.Forms.Label
    Friend WithEvents lblNomeContato As System.Windows.Forms.Label
    Friend WithEvents btnExcluirContato As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvarContato As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnEnviarEmail As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblTipoEmail As System.Windows.Forms.Label
    Friend WithEvents cboEmpresa As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents lblContato As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents cboTipoEmail As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Private WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents txtCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtContato As Janus.Windows.GridEX.EditControls.MaskedEditBox

End Class
