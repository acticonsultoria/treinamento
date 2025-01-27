<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadVeiculoMDFe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadVeiculoMDFe))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtPlacaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRenavamFiltro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRNTRCFiltro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboUFFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.cboTipoCarroceriaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        Me.txtPlacaVeiculo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPlacaVeiculo = New System.Windows.Forms.Label()
        Me.txtRenavamVeiculo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblRenavamVeiculo = New System.Windows.Forms.Label()
        Me.txtRntrcVeiculo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblRntrcVeiculo = New System.Windows.Forms.Label()
        Me.cboUF = New Janus.Windows.EditControls.UIComboBox()
        Me.cboTipoCarroceriaVeiculo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoCarroceriaVeiculo = New System.Windows.Forms.Label()
        Me.lblUFVeiculo = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
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
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.UiGroupBox1)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpControl)
        resources.ApplyResources(Me.pagLista, "pagLista")
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Name = "pagLista"
        Me.pagLista.TabStop = True
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
        'UiGroupBox1
        '
        resources.ApplyResources(Me.UiGroupBox1, "UiGroupBox1")
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.txtPlacaFiltro)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Controls.Add(Me.txtRenavamFiltro)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.txtRNTRCFiltro)
        Me.UiGroupBox1.Controls.Add(Me.Label4)
        Me.UiGroupBox1.Controls.Add(Me.cboUFFiltro)
        Me.UiGroupBox1.Controls.Add(Me.cboTipoCarroceriaFiltro)
        Me.UiGroupBox1.Controls.Add(Me.Label5)
        Me.UiGroupBox1.Controls.Add(Me.Label6)
        Me.UiGroupBox1.Controls.Add(Me.btnFiltrar)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'txtPlacaFiltro
        '
        Me.txtPlacaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtPlacaFiltro, "txtPlacaFiltro")
        Me.txtPlacaFiltro.MaxLength = 7
        Me.txtPlacaFiltro.Name = "txtPlacaFiltro"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'txtRenavamFiltro
        '
        Me.txtRenavamFiltro.BackColor = System.Drawing.Color.White
        Me.txtRenavamFiltro.DecimalDigits = 0
        resources.ApplyResources(Me.txtRenavamFiltro, "txtRenavamFiltro")
        Me.txtRenavamFiltro.MaxLength = 11
        Me.txtRenavamFiltro.Name = "txtRenavamFiltro"
        Me.txtRenavamFiltro.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Name = "Label2"
        '
        'txtRNTRCFiltro
        '
        Me.txtRNTRCFiltro.BackColor = System.Drawing.Color.White
        Me.txtRNTRCFiltro.DecimalDigits = 0
        resources.ApplyResources(Me.txtRNTRCFiltro, "txtRNTRCFiltro")
        Me.txtRNTRCFiltro.MaxLength = 8
        Me.txtRNTRCFiltro.Name = "txtRNTRCFiltro"
        Me.txtRNTRCFiltro.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Name = "Label4"
        '
        'cboUFFiltro
        '
        resources.ApplyResources(Me.cboUFFiltro, "cboUFFiltro")
        Me.cboUFFiltro.Name = "cboUFFiltro"
        Me.cboUFFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'cboTipoCarroceriaFiltro
        '
        resources.ApplyResources(Me.cboTipoCarroceriaFiltro, "cboTipoCarroceriaFiltro")
        Me.cboTipoCarroceriaFiltro.Name = "cboTipoCarroceriaFiltro"
        Me.cboTipoCarroceriaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
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
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        resources.ApplyResources(Me.grdListagem, "grdListagem")
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        resources.ApplyResources(grdListagem_DesignTimeLayout, "grdListagem_DesignTimeLayout")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Manual
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
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
        Me.grpControl.Controls.Add(Me.btnExcel)
        Me.grpControl.Controls.Add(Me.btnNovo1)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnExcluir)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.VisualStyleManager = Me.vsmMain
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
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpDados)
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
        Me.grpDados.Controls.Add(Me.Label3)
        Me.grpDados.Controls.Add(Me.cboAtivo)
        Me.grpDados.Controls.Add(Me.txtPlacaVeiculo)
        Me.grpDados.Controls.Add(Me.lblPlacaVeiculo)
        Me.grpDados.Controls.Add(Me.txtRenavamVeiculo)
        Me.grpDados.Controls.Add(Me.lblRenavamVeiculo)
        Me.grpDados.Controls.Add(Me.txtRntrcVeiculo)
        Me.grpDados.Controls.Add(Me.lblRntrcVeiculo)
        Me.grpDados.Controls.Add(Me.cboUF)
        Me.grpDados.Controls.Add(Me.cboTipoCarroceriaVeiculo)
        Me.grpDados.Controls.Add(Me.lblTipoCarroceriaVeiculo)
        Me.grpDados.Controls.Add(Me.lblUFVeiculo)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Name = "Label3"
        '
        'cboAtivo
        '
        resources.ApplyResources(Me.cboAtivo, "cboAtivo")
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtPlacaVeiculo
        '
        Me.txtPlacaVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtPlacaVeiculo, "txtPlacaVeiculo")
        Me.txtPlacaVeiculo.MaxLength = 7
        Me.txtPlacaVeiculo.Name = "txtPlacaVeiculo"
        '
        'lblPlacaVeiculo
        '
        resources.ApplyResources(Me.lblPlacaVeiculo, "lblPlacaVeiculo")
        Me.lblPlacaVeiculo.BackColor = System.Drawing.Color.Transparent
        Me.lblPlacaVeiculo.Name = "lblPlacaVeiculo"
        '
        'txtRenavamVeiculo
        '
        Me.txtRenavamVeiculo.BackColor = System.Drawing.Color.White
        Me.txtRenavamVeiculo.DecimalDigits = 0
        resources.ApplyResources(Me.txtRenavamVeiculo, "txtRenavamVeiculo")
        Me.txtRenavamVeiculo.MaxLength = 11
        Me.txtRenavamVeiculo.Name = "txtRenavamVeiculo"
        Me.txtRenavamVeiculo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblRenavamVeiculo
        '
        resources.ApplyResources(Me.lblRenavamVeiculo, "lblRenavamVeiculo")
        Me.lblRenavamVeiculo.BackColor = System.Drawing.Color.Transparent
        Me.lblRenavamVeiculo.Name = "lblRenavamVeiculo"
        '
        'txtRntrcVeiculo
        '
        Me.txtRntrcVeiculo.BackColor = System.Drawing.Color.White
        Me.txtRntrcVeiculo.DecimalDigits = 0
        resources.ApplyResources(Me.txtRntrcVeiculo, "txtRntrcVeiculo")
        Me.txtRntrcVeiculo.MaxLength = 8
        Me.txtRntrcVeiculo.Name = "txtRntrcVeiculo"
        Me.txtRntrcVeiculo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblRntrcVeiculo
        '
        resources.ApplyResources(Me.lblRntrcVeiculo, "lblRntrcVeiculo")
        Me.lblRntrcVeiculo.BackColor = System.Drawing.Color.Transparent
        Me.lblRntrcVeiculo.Name = "lblRntrcVeiculo"
        '
        'cboUF
        '
        resources.ApplyResources(Me.cboUF, "cboUF")
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'cboTipoCarroceriaVeiculo
        '
        resources.ApplyResources(Me.cboTipoCarroceriaVeiculo, "cboTipoCarroceriaVeiculo")
        Me.cboTipoCarroceriaVeiculo.Name = "cboTipoCarroceriaVeiculo"
        Me.cboTipoCarroceriaVeiculo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblTipoCarroceriaVeiculo
        '
        resources.ApplyResources(Me.lblTipoCarroceriaVeiculo, "lblTipoCarroceriaVeiculo")
        Me.lblTipoCarroceriaVeiculo.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoCarroceriaVeiculo.Name = "lblTipoCarroceriaVeiculo"
        '
        'lblUFVeiculo
        '
        resources.ApplyResources(Me.lblUFVeiculo, "lblUFVeiculo")
        Me.lblUFVeiculo.Name = "lblUFVeiculo"
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
        'UiTabPage1
        '
        Me.UiTabPage1.Key = "pagVendas"
        resources.ApplyResources(Me.UiTabPage1, "UiTabPage1")
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.TabStop = True
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 3000
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'usrCadVeiculoMDFe
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrCadVeiculoMDFe"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
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
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents txtPlacaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRenavamFiltro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRNTRCFiltro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboUFFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboTipoCarroceriaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPlacaVeiculo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPlacaVeiculo As System.Windows.Forms.Label
    Friend WithEvents txtRenavamVeiculo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblRenavamVeiculo As System.Windows.Forms.Label
    Friend WithEvents txtRntrcVeiculo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblRntrcVeiculo As System.Windows.Forms.Label
    Friend WithEvents cboUF As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboTipoCarroceriaVeiculo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoCarroceriaVeiculo As System.Windows.Forms.Label
    Friend WithEvents lblUFVeiculo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox

End Class
