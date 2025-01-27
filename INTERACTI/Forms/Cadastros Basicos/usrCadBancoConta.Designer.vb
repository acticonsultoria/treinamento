<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadBancoConta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadBancoConta))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdContato_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdContato_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdContato_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.txtDigitoContaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtContaFilltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblContaFiltro = New System.Windows.Forms.Label()
        Me.lblBancoFiltro = New System.Windows.Forms.Label()
        Me.cboBancoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtAgenciaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblAgenciaFiltro = New System.Windows.Forms.Label()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblAplicacao = New System.Windows.Forms.Label()
        Me.cboAplicacao = New Janus.Windows.EditControls.UIComboBox()
        Me.txtDigitoConta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtConta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblConta = New System.Windows.Forms.Label()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.cboBanco = New Janus.Windows.EditControls.UIComboBox()
        Me.txtAgencia = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblAgencia = New System.Windows.Forms.Label()
        Me.btnCadastrarBanco = New System.Windows.Forms.Button()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagDadosGerais = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosGerais = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarCEP = New System.Windows.Forms.Button()
        Me.btnCadastrarPais = New System.Windows.Forms.Button()
        Me.cboMunicipio = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumero = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtComplemento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtBairro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.cboPais = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.txtCEP = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.cboUF = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblLogradouro = New System.Windows.Forms.Label()
        Me.txtLogradouro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
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
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDados.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagDadosGerais.SuspendLayout()
        CType(Me.grpDadosGerais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosGerais.SuspendLayout()
        Me.pagContato.SuspendLayout()
        CType(Me.grdContato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEndereco.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
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
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grdListagem)
        resources.ApplyResources(Me.pagLista, "pagLista")
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Name = "pagLista"
        Me.pagLista.TabStop = True
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
        'grpControl
        '
        resources.ApplyResources(Me.grpControl, "grpControl")
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        resources.ApplyResources(Me.btnNovo1, "btnNovo1")
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'btnExcluir
        '
        resources.ApplyResources(Me.btnExcluir, "btnExcluir")
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        resources.ApplyResources(Me.grpFiltro, "grpFiltro")
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.txtDigitoContaFiltro)
        Me.grpFiltro.Controls.Add(Me.txtContaFilltro)
        Me.grpFiltro.Controls.Add(Me.lblContaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblBancoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboBancoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtAgenciaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblAgenciaFiltro)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
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
        'txtDigitoContaFiltro
        '
        Me.txtDigitoContaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtDigitoContaFiltro, "txtDigitoContaFiltro")
        Me.txtDigitoContaFiltro.MaxLength = 2
        Me.txtDigitoContaFiltro.Name = "txtDigitoContaFiltro"
        '
        'txtContaFilltro
        '
        Me.txtContaFilltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtContaFilltro, "txtContaFilltro")
        Me.txtContaFilltro.MaxLength = 10
        Me.txtContaFilltro.Name = "txtContaFilltro"
        '
        'lblContaFiltro
        '
        resources.ApplyResources(Me.lblContaFiltro, "lblContaFiltro")
        Me.lblContaFiltro.Name = "lblContaFiltro"
        '
        'lblBancoFiltro
        '
        resources.ApplyResources(Me.lblBancoFiltro, "lblBancoFiltro")
        Me.lblBancoFiltro.Name = "lblBancoFiltro"
        '
        'cboBancoFiltro
        '
        resources.ApplyResources(Me.cboBancoFiltro, "cboBancoFiltro")
        Me.cboBancoFiltro.Name = "cboBancoFiltro"
        Me.cboBancoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtAgenciaFiltro
        '
        Me.txtAgenciaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtAgenciaFiltro, "txtAgenciaFiltro")
        Me.txtAgenciaFiltro.MaxLength = 10
        Me.txtAgenciaFiltro.Name = "txtAgenciaFiltro"
        '
        'lblAgenciaFiltro
        '
        resources.ApplyResources(Me.lblAgenciaFiltro, "lblAgenciaFiltro")
        Me.lblAgenciaFiltro.Name = "lblAgenciaFiltro"
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        resources.ApplyResources(Me.grdListagem, "grdListagem")
        Me.grdListagem.CellToolTipText = "Duplo clique para editar o registro"
        Me.grdListagem.ColumnAutoResize = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        resources.ApplyResources(grdListagem_DesignTimeLayout, "grdListagem_DesignTimeLayout")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.FrozenColumns = 3
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        resources.ApplyResources(Me.pagDados, "pagDados")
        Me.pagDados.Key = "padDados"
        Me.pagDados.Name = "pagDados"
        Me.pagDados.TabStop = True
        '
        'grpDados
        '
        resources.ApplyResources(Me.grpDados, "grpDados")
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblAplicacao)
        Me.grpDados.Controls.Add(Me.cboAplicacao)
        Me.grpDados.Controls.Add(Me.txtDigitoConta)
        Me.grpDados.Controls.Add(Me.txtConta)
        Me.grpDados.Controls.Add(Me.lblConta)
        Me.grpDados.Controls.Add(Me.lblAtivo)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.lblBanco)
        Me.grpDados.Controls.Add(Me.cboBanco)
        Me.grpDados.Controls.Add(Me.txtAgencia)
        Me.grpDados.Controls.Add(Me.lblAgencia)
        Me.grpDados.Controls.Add(Me.btnCadastrarBanco)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblAplicacao
        '
        resources.ApplyResources(Me.lblAplicacao, "lblAplicacao")
        Me.lblAplicacao.Name = "lblAplicacao"
        '
        'cboAplicacao
        '
        resources.ApplyResources(Me.cboAplicacao, "cboAplicacao")
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem1, "UiComboBoxItem1")
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem2, "UiComboBoxItem2")
        Me.cboAplicacao.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboAplicacao.Name = "cboAplicacao"
        Me.cboAplicacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtDigitoConta
        '
        Me.txtDigitoConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtDigitoConta, "txtDigitoConta")
        Me.txtDigitoConta.MaxLength = 2
        Me.txtDigitoConta.Name = "txtDigitoConta"
        '
        'txtConta
        '
        Me.txtConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtConta, "txtConta")
        Me.txtConta.MaxLength = 10
        Me.txtConta.Name = "txtConta"
        '
        'lblConta
        '
        resources.ApplyResources(Me.lblConta, "lblConta")
        Me.lblConta.Name = "lblConta"
        '
        'lblAtivo
        '
        resources.ApplyResources(Me.lblAtivo, "lblAtivo")
        Me.lblAtivo.Name = "lblAtivo"
        '
        'cboAtivo
        '
        resources.ApplyResources(Me.cboAtivo, "cboAtivo")
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem3, "UiComboBoxItem3")
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem4, "UiComboBoxItem4")
        Me.cboAtivo.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblBanco
        '
        resources.ApplyResources(Me.lblBanco, "lblBanco")
        Me.lblBanco.Name = "lblBanco"
        '
        'cboBanco
        '
        resources.ApplyResources(Me.cboBanco, "cboBanco")
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtAgencia
        '
        Me.txtAgencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtAgencia, "txtAgencia")
        Me.txtAgencia.MaxLength = 10
        Me.txtAgencia.Name = "txtAgencia"
        '
        'lblAgencia
        '
        resources.ApplyResources(Me.lblAgencia, "lblAgencia")
        Me.lblAgencia.Name = "lblAgencia"
        '
        'btnCadastrarBanco
        '
        Me.btnCadastrarBanco.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarBanco, "btnCadastrarBanco")
        Me.btnCadastrarBanco.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarBanco.Name = "btnCadastrarBanco"
        Me.btnCadastrarBanco.TabStop = False
        Me.btnCadastrarBanco.UseVisualStyleBackColor = True
        '
        'tabDados
        '
        resources.ApplyResources(Me.tabDados, "tabDados")
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDadosGerais, Me.pagContato})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagDadosGerais
        '
        Me.pagDadosGerais.Controls.Add(Me.grpDadosGerais)
        Me.pagDadosGerais.Key = "pagDadosGerais"
        resources.ApplyResources(Me.pagDadosGerais, "pagDadosGerais")
        Me.pagDadosGerais.Name = "pagDadosGerais"
        Me.pagDadosGerais.TabStop = True
        '
        'grpDadosGerais
        '
        resources.ApplyResources(Me.grpDadosGerais, "grpDadosGerais")
        Me.grpDadosGerais.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosGerais.Controls.Add(Me.btnProcurarCEP)
        Me.grpDadosGerais.Controls.Add(Me.btnCadastrarPais)
        Me.grpDadosGerais.Controls.Add(Me.cboMunicipio)
        Me.grpDadosGerais.Controls.Add(Me.txtNumero)
        Me.grpDadosGerais.Controls.Add(Me.txtComplemento)
        Me.grpDadosGerais.Controls.Add(Me.txtBairro)
        Me.grpDadosGerais.Controls.Add(Me.txtObservacao)
        Me.grpDadosGerais.Controls.Add(Me.lblObservacao)
        Me.grpDadosGerais.Controls.Add(Me.lblPais)
        Me.grpDadosGerais.Controls.Add(Me.cboPais)
        Me.grpDadosGerais.Controls.Add(Me.lblCEP)
        Me.grpDadosGerais.Controls.Add(Me.txtCEP)
        Me.grpDadosGerais.Controls.Add(Me.lblComplemento)
        Me.grpDadosGerais.Controls.Add(Me.lblUF)
        Me.grpDadosGerais.Controls.Add(Me.cboUF)
        Me.grpDadosGerais.Controls.Add(Me.lblMunicipio)
        Me.grpDadosGerais.Controls.Add(Me.lblBairro)
        Me.grpDadosGerais.Controls.Add(Me.lblNumero)
        Me.grpDadosGerais.Controls.Add(Me.lblLogradouro)
        Me.grpDadosGerais.Controls.Add(Me.txtLogradouro)
        Me.grpDadosGerais.Name = "grpDadosGerais"
        Me.grpDadosGerais.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosGerais.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosGerais.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarCEP
        '
        Me.btnProcurarCEP.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnProcurarCEP, "btnProcurarCEP")
        Me.btnProcurarCEP.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCEP.Name = "btnProcurarCEP"
        Me.btnProcurarCEP.TabStop = False
        Me.btnProcurarCEP.UseVisualStyleBackColor = True
        '
        'btnCadastrarPais
        '
        Me.btnCadastrarPais.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnCadastrarPais, "btnCadastrarPais")
        Me.btnCadastrarPais.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarPais.Name = "btnCadastrarPais"
        Me.btnCadastrarPais.TabStop = False
        Me.btnCadastrarPais.UseVisualStyleBackColor = True
        '
        'cboMunicipio
        '
        resources.ApplyResources(Me.cboMunicipio, "cboMunicipio")
        Me.cboMunicipio.Name = "cboMunicipio"
        Me.cboMunicipio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtNumero
        '
        resources.ApplyResources(Me.txtNumero, "txtNumero")
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.MaxLength = 60
        Me.txtNumero.Name = "txtNumero"
        '
        'txtComplemento
        '
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtComplemento, "txtComplemento")
        Me.txtComplemento.MaxLength = 60
        Me.txtComplemento.Name = "txtComplemento"
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtBairro, "txtBairro")
        Me.txtBairro.MaxLength = 60
        Me.txtBairro.Name = "txtBairro"
        '
        'txtObservacao
        '
        resources.ApplyResources(Me.txtObservacao, "txtObservacao")
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.MaxLength = 500
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        '
        'lblObservacao
        '
        resources.ApplyResources(Me.lblObservacao, "lblObservacao")
        Me.lblObservacao.Name = "lblObservacao"
        '
        'lblPais
        '
        resources.ApplyResources(Me.lblPais, "lblPais")
        Me.lblPais.Name = "lblPais"
        '
        'cboPais
        '
        resources.ApplyResources(Me.cboPais, "cboPais")
        Me.cboPais.Name = "cboPais"
        Me.cboPais.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblCEP
        '
        resources.ApplyResources(Me.lblCEP, "lblCEP")
        Me.lblCEP.Name = "lblCEP"
        '
        'txtCEP
        '
        resources.ApplyResources(Me.txtCEP, "txtCEP")
        Me.txtCEP.Mask = "00000-000"
        Me.txtCEP.MaxLength = 10
        Me.txtCEP.Name = "txtCEP"
        '
        'lblComplemento
        '
        resources.ApplyResources(Me.lblComplemento, "lblComplemento")
        Me.lblComplemento.Name = "lblComplemento"
        '
        'lblUF
        '
        resources.ApplyResources(Me.lblUF, "lblUF")
        Me.lblUF.Name = "lblUF"
        '
        'cboUF
        '
        resources.ApplyResources(Me.cboUF, "cboUF")
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblMunicipio
        '
        resources.ApplyResources(Me.lblMunicipio, "lblMunicipio")
        Me.lblMunicipio.Name = "lblMunicipio"
        '
        'lblBairro
        '
        resources.ApplyResources(Me.lblBairro, "lblBairro")
        Me.lblBairro.Name = "lblBairro"
        '
        'lblNumero
        '
        resources.ApplyResources(Me.lblNumero, "lblNumero")
        Me.lblNumero.Name = "lblNumero"
        '
        'lblLogradouro
        '
        resources.ApplyResources(Me.lblLogradouro, "lblLogradouro")
        Me.lblLogradouro.Name = "lblLogradouro"
        '
        'txtLogradouro
        '
        resources.ApplyResources(Me.txtLogradouro, "txtLogradouro")
        Me.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogradouro.MaxLength = 60
        Me.txtLogradouro.Name = "txtLogradouro"
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
        Me.grdContato.ColumnAutoResize = True
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
        'grpControl2
        '
        resources.ApplyResources(Me.grpControl2, "grpControl2")
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo)
        Me.grpControl2.Controls.Add(Me.btnVoltar)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        resources.ApplyResources(Me.btnNovo, "btnNovo")
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        resources.ApplyResources(Me.btnVoltar, "btnVoltar")
        Me.btnVoltar.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        resources.ApplyResources(Me.btnSalvar, "btnSalvar")
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrCadBancoConta
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrCadBancoConta"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagDadosGerais.ResumeLayout(False)
        CType(Me.grpDadosGerais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosGerais.ResumeLayout(False)
        Me.grpDadosGerais.PerformLayout()
        Me.pagContato.ResumeLayout(False)
        CType(Me.grdContato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEndereco.ResumeLayout(False)
        Me.grpEndereco.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDadosGerais As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagContato As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblBanco As System.Windows.Forms.Label
    Friend WithEvents cboBanco As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtAgencia As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAgencia As System.Windows.Forms.Label
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtDigitoConta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtConta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblConta As System.Windows.Forms.Label
    Friend WithEvents txtDigitoContaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtContaFilltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblContaFiltro As System.Windows.Forms.Label
    Friend WithEvents lblBancoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboBancoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtAgenciaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAgenciaFiltro As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarBanco As System.Windows.Forms.Button
    Friend WithEvents grpDadosGerais As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnProcurarCEP As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarPais As System.Windows.Forms.Button
    Friend WithEvents cboMunicipio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumero As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtComplemento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtBairro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents lblPais As System.Windows.Forms.Label
    Friend WithEvents cboPais As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCEP As System.Windows.Forms.Label
    Friend WithEvents txtCEP As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblComplemento As System.Windows.Forms.Label
    Friend WithEvents lblUF As System.Windows.Forms.Label
    Friend WithEvents cboUF As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMunicipio As System.Windows.Forms.Label
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblLogradouro As System.Windows.Forms.Label
    Friend WithEvents txtLogradouro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grdContato As Janus.Windows.GridEX.GridEX
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
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridContato As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridContato As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridContato As System.Windows.Forms.Button
    Friend WithEvents lblAplicacao As System.Windows.Forms.Label
    Friend WithEvents cboAplicacao As Janus.Windows.EditControls.UIComboBox

End Class
