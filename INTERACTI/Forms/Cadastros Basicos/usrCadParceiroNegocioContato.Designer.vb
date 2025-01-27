<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadParceiroNegocioContato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadParceiroNegocioContato))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdContato_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdContato_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdContato_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpTipoParceiroNegocio = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkDespachante = New Janus.Windows.EditControls.UICheckBox()
        Me.chkAgenteLogistico = New Janus.Windows.EditControls.UICheckBox()
        Me.chkFornecedor = New Janus.Windows.EditControls.UICheckBox()
        Me.chkCliente = New Janus.Windows.EditControls.UICheckBox()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtPersonalidade = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtSegmento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtRegimeTributario = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSegmento = New System.Windows.Forms.Label()
        Me.txtCNAE = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCNAE = New System.Windows.Forms.Label()
        Me.lblRegimeTributario = New System.Windows.Forms.Label()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPersonalidade = New System.Windows.Forms.Label()
        Me.txtNomeFantasia = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNomeFantasia = New System.Windows.Forms.Label()
        Me.txtRazaoSocial = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRazaoSocial = New System.Windows.Forms.Label()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagContato = New Janus.Windows.UI.Tab.UITabPage()
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
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpTipoParceiroNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTipoParceiroNegocio.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagContato.SuspendLayout()
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
        Me.pagDados.Controls.Add(Me.grpControl)
        Me.pagDados.Controls.Add(Me.grpTipoParceiroNegocio)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.tabDados)
        resources.ApplyResources(Me.pagDados, "pagDados")
        Me.pagDados.Key = "padDados"
        Me.pagDados.Name = "pagDados"
        Me.pagDados.TabStop = True
        '
        'grpControl
        '
        resources.ApplyResources(Me.grpControl, "grpControl")
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.VisualStyleManager = Me.vsmMain
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
        'grpTipoParceiroNegocio
        '
        resources.ApplyResources(Me.grpTipoParceiroNegocio, "grpTipoParceiroNegocio")
        Me.grpTipoParceiroNegocio.BackColor = System.Drawing.Color.Transparent
        Me.grpTipoParceiroNegocio.Controls.Add(Me.chkDespachante)
        Me.grpTipoParceiroNegocio.Controls.Add(Me.chkAgenteLogistico)
        Me.grpTipoParceiroNegocio.Controls.Add(Me.chkFornecedor)
        Me.grpTipoParceiroNegocio.Controls.Add(Me.chkCliente)
        Me.grpTipoParceiroNegocio.Name = "grpTipoParceiroNegocio"
        Me.grpTipoParceiroNegocio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpTipoParceiroNegocio.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpTipoParceiroNegocio.VisualStyleManager = Me.vsmMain
        '
        'chkDespachante
        '
        resources.ApplyResources(Me.chkDespachante, "chkDespachante")
        Me.chkDespachante.Name = "chkDespachante"
        '
        'chkAgenteLogistico
        '
        resources.ApplyResources(Me.chkAgenteLogistico, "chkAgenteLogistico")
        Me.chkAgenteLogistico.Name = "chkAgenteLogistico"
        '
        'chkFornecedor
        '
        resources.ApplyResources(Me.chkFornecedor, "chkFornecedor")
        Me.chkFornecedor.Name = "chkFornecedor"
        '
        'chkCliente
        '
        resources.ApplyResources(Me.chkCliente, "chkCliente")
        Me.chkCliente.Name = "chkCliente"
        '
        'grpDados
        '
        resources.ApplyResources(Me.grpDados, "grpDados")
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtPersonalidade)
        Me.grpDados.Controls.Add(Me.txtSegmento)
        Me.grpDados.Controls.Add(Me.txtRegimeTributario)
        Me.grpDados.Controls.Add(Me.lblSegmento)
        Me.grpDados.Controls.Add(Me.txtCNAE)
        Me.grpDados.Controls.Add(Me.lblCNAE)
        Me.grpDados.Controls.Add(Me.lblRegimeTributario)
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.lblPersonalidade)
        Me.grpDados.Controls.Add(Me.txtNomeFantasia)
        Me.grpDados.Controls.Add(Me.lblNomeFantasia)
        Me.grpDados.Controls.Add(Me.txtRazaoSocial)
        Me.grpDados.Controls.Add(Me.lblRazaoSocial)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtPersonalidade
        '
        Me.txtPersonalidade.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.txtPersonalidade, "txtPersonalidade")
        Me.txtPersonalidade.MaxLength = 7
        Me.txtPersonalidade.Name = "txtPersonalidade"
        Me.txtPersonalidade.ReadOnly = True
        Me.txtPersonalidade.TabStop = False
        '
        'txtSegmento
        '
        Me.txtSegmento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSegmento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtSegmento, "txtSegmento")
        Me.txtSegmento.MaxLength = 60
        Me.txtSegmento.Name = "txtSegmento"
        Me.txtSegmento.ReadOnly = True
        Me.txtSegmento.TabStop = False
        '
        'txtRegimeTributario
        '
        resources.ApplyResources(Me.txtRegimeTributario, "txtRegimeTributario")
        Me.txtRegimeTributario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRegimeTributario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRegimeTributario.MaxLength = 60
        Me.txtRegimeTributario.Name = "txtRegimeTributario"
        Me.txtRegimeTributario.ReadOnly = True
        Me.txtRegimeTributario.TabStop = False
        '
        'lblSegmento
        '
        resources.ApplyResources(Me.lblSegmento, "lblSegmento")
        Me.lblSegmento.Name = "lblSegmento"
        '
        'txtCNAE
        '
        Me.txtCNAE.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.txtCNAE, "txtCNAE")
        Me.txtCNAE.MaxLength = 7
        Me.txtCNAE.Name = "txtCNAE"
        Me.txtCNAE.ReadOnly = True
        Me.txtCNAE.TabStop = False
        '
        'lblCNAE
        '
        resources.ApplyResources(Me.lblCNAE, "lblCNAE")
        Me.lblCNAE.Name = "lblCNAE"
        '
        'lblRegimeTributario
        '
        resources.ApplyResources(Me.lblRegimeTributario, "lblRegimeTributario")
        Me.lblRegimeTributario.Name = "lblRegimeTributario"
        '
        'lblAtivo
        '
        resources.ApplyResources(Me.lblAtivo, "lblAtivo")
        Me.lblAtivo.Name = "lblAtivo"
        '
        'cboAtivo
        '
        resources.ApplyResources(Me.cboAtivo, "cboAtivo")
        Me.cboAtivo.BackColor = System.Drawing.Color.WhiteSmoke
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem1, "UiComboBoxItem1")
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem2, "UiComboBoxItem2")
        Me.cboAtivo.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivo.ReadOnly = True
        Me.cboAtivo.TabStop = False
        '
        'lblPersonalidade
        '
        resources.ApplyResources(Me.lblPersonalidade, "lblPersonalidade")
        Me.lblPersonalidade.Name = "lblPersonalidade"
        '
        'txtNomeFantasia
        '
        resources.ApplyResources(Me.txtNomeFantasia, "txtNomeFantasia")
        Me.txtNomeFantasia.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeFantasia.MaxLength = 60
        Me.txtNomeFantasia.Name = "txtNomeFantasia"
        Me.txtNomeFantasia.ReadOnly = True
        Me.txtNomeFantasia.TabStop = False
        '
        'lblNomeFantasia
        '
        resources.ApplyResources(Me.lblNomeFantasia, "lblNomeFantasia")
        Me.lblNomeFantasia.Name = "lblNomeFantasia"
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtRazaoSocial, "txtRazaoSocial")
        Me.txtRazaoSocial.MaxLength = 60
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        Me.txtRazaoSocial.ReadOnly = True
        Me.txtRazaoSocial.TabStop = False
        '
        'lblRazaoSocial
        '
        resources.ApplyResources(Me.lblRazaoSocial, "lblRazaoSocial")
        Me.lblRazaoSocial.Name = "lblRazaoSocial"
        '
        'tabDados
        '
        resources.ApplyResources(Me.tabDados, "tabDados")
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagContato})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagContato
        '
        Me.pagContato.Controls.Add(Me.btnExcelGridContato)
        Me.pagContato.Controls.Add(Me.btnAgruparGridContato)
        Me.pagContato.Controls.Add(Me.btnConfigurarGridContato)
        Me.pagContato.Controls.Add(Me.grdContato)
        Me.pagContato.Controls.Add(Me.grpEndereco)
        Me.pagContato.Key = "pagContato"
        resources.ApplyResources(Me.pagContato, "pagContato")
        Me.pagContato.Name = "pagContato"
        Me.pagContato.TabStop = True
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
        Me.dtpDataAniversario.Checked = False
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
        Me.txtCelularContato.Mask = "!(##) 00000-0000"
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
        'usrCadParceiroNegocioContato
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrCadParceiroNegocioContato"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grpTipoParceiroNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTipoParceiroNegocio.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagContato.ResumeLayout(False)
        CType(Me.grdContato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEndereco.ResumeLayout(False)
        Me.grpEndereco.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagContato As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblPersonalidade As System.Windows.Forms.Label
    Friend WithEvents txtNomeFantasia As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNomeFantasia As System.Windows.Forms.Label
    Friend WithEvents txtRazaoSocial As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRazaoSocial As System.Windows.Forms.Label
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpTipoParceiroNegocio As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents chkFornecedor As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkCliente As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents lblRegimeTributario As System.Windows.Forms.Label
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents grdContato As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtCNAE As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCNAE As System.Windows.Forms.Label
    Friend WithEvents lblSegmento As System.Windows.Forms.Label
    Friend WithEvents chkAgenteLogistico As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkDespachante As Janus.Windows.EditControls.UICheckBox
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
    Friend WithEvents txtPersonalidade As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtSegmento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtRegimeTributario As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton

End Class
