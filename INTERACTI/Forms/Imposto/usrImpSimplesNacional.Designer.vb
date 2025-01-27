<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrImpSimplesNacional
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
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrImpSimplesNacional))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grdDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkFaixaAtiva = New System.Windows.Forms.CheckBox()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.lblISS = New System.Windows.Forms.Label()
        Me.txtISS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblICMS = New System.Windows.Forms.Label()
        Me.txtICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCPP = New System.Windows.Forms.Label()
        Me.txtCPP = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPIS = New System.Windows.Forms.Label()
        Me.txtPIS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCSLL = New System.Windows.Forms.Label()
        Me.txtCSLL = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCOFINS = New System.Windows.Forms.Label()
        Me.txtCOFINS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblIRPJ = New System.Windows.Forms.Label()
        Me.txtIRPJ = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquota = New System.Windows.Forms.Label()
        Me.txtAliquota = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtReceitaBrutaFinal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtReceitaBrutaInicio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblReceitaBruta = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboTipoEmpresa = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoEmpresa = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdDados.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
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
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnExcelGrid)
        Me.pagDados.Controls.Add(Me.btnConfigurarGrid)
        Me.pagDados.Controls.Add(Me.grdListagem)
        Me.pagDados.Controls.Add(Me.grdDados)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Faixa do Simples Nacional"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(33, 373)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 29
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 373)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 13
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnAutoResize = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(8, 183)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 207)
        Me.grdListagem.TabIndex = 2
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grdDados
        '
        Me.grdDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDados.BackColor = System.Drawing.Color.Transparent
        Me.grdDados.Controls.Add(Me.chkFaixaAtiva)
        Me.grdDados.Controls.Add(Me.btnExcluir)
        Me.grdDados.Controls.Add(Me.btnInserir)
        Me.grdDados.Controls.Add(Me.lblISS)
        Me.grdDados.Controls.Add(Me.txtISS)
        Me.grdDados.Controls.Add(Me.lblICMS)
        Me.grdDados.Controls.Add(Me.txtICMS)
        Me.grdDados.Controls.Add(Me.lblCPP)
        Me.grdDados.Controls.Add(Me.txtCPP)
        Me.grdDados.Controls.Add(Me.lblPIS)
        Me.grdDados.Controls.Add(Me.txtPIS)
        Me.grdDados.Controls.Add(Me.lblCSLL)
        Me.grdDados.Controls.Add(Me.txtCSLL)
        Me.grdDados.Controls.Add(Me.lblCOFINS)
        Me.grdDados.Controls.Add(Me.txtCOFINS)
        Me.grdDados.Controls.Add(Me.lblIRPJ)
        Me.grdDados.Controls.Add(Me.txtIRPJ)
        Me.grdDados.Controls.Add(Me.lblAliquota)
        Me.grdDados.Controls.Add(Me.txtAliquota)
        Me.grdDados.Controls.Add(Me.txtReceitaBrutaFinal)
        Me.grdDados.Controls.Add(Me.txtReceitaBrutaInicio)
        Me.grdDados.Controls.Add(Me.lblReceitaBruta)
        Me.grdDados.Location = New System.Drawing.Point(8, 70)
        Me.grdDados.Name = "grdDados"
        Me.grdDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grdDados.Size = New System.Drawing.Size(897, 104)
        Me.grdDados.TabIndex = 1
        Me.grdDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grdDados.VisualStyleManager = Me.vsmMain
        '
        'chkFaixaAtiva
        '
        Me.chkFaixaAtiva.AutoSize = True
        Me.chkFaixaAtiva.Location = New System.Drawing.Point(529, 76)
        Me.chkFaixaAtiva.Name = "chkFaixaAtiva"
        Me.chkFaixaAtiva.Size = New System.Drawing.Size(79, 18)
        Me.chkFaixaAtiva.TabIndex = 19
        Me.chkFaixaAtiva.Text = "Faixa Ativa"
        Me.chkFaixaAtiva.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(797, 71)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 21
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(797, 42)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 20
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblISS
        '
        Me.lblISS.AutoSize = True
        Me.lblISS.Location = New System.Drawing.Point(422, 57)
        Me.lblISS.Name = "lblISS"
        Me.lblISS.Size = New System.Drawing.Size(26, 14)
        Me.lblISS.TabIndex = 17
        Me.lblISS.Text = "ISS:"
        '
        'txtISS
        '
        Me.txtISS.Location = New System.Drawing.Point(425, 74)
        Me.txtISS.Name = "txtISS"
        Me.txtISS.Size = New System.Drawing.Size(98, 20)
        Me.txtISS.TabIndex = 18
        Me.txtISS.Text = "0,00"
        Me.txtISS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblICMS
        '
        Me.lblICMS.AutoSize = True
        Me.lblICMS.Location = New System.Drawing.Point(318, 57)
        Me.lblICMS.Name = "lblICMS"
        Me.lblICMS.Size = New System.Drawing.Size(34, 14)
        Me.lblICMS.TabIndex = 15
        Me.lblICMS.Text = "ICMS:"
        '
        'txtICMS
        '
        Me.txtICMS.Location = New System.Drawing.Point(321, 74)
        Me.txtICMS.Name = "txtICMS"
        Me.txtICMS.Size = New System.Drawing.Size(98, 20)
        Me.txtICMS.TabIndex = 16
        Me.txtICMS.Text = "0,00"
        Me.txtICMS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblCPP
        '
        Me.lblCPP.AutoSize = True
        Me.lblCPP.Location = New System.Drawing.Point(214, 57)
        Me.lblCPP.Name = "lblCPP"
        Me.lblCPP.Size = New System.Drawing.Size(29, 14)
        Me.lblCPP.TabIndex = 13
        Me.lblCPP.Text = "CPP:"
        '
        'txtCPP
        '
        Me.txtCPP.Location = New System.Drawing.Point(217, 74)
        Me.txtCPP.Name = "txtCPP"
        Me.txtCPP.Size = New System.Drawing.Size(98, 20)
        Me.txtCPP.TabIndex = 14
        Me.txtCPP.Text = "0,00"
        Me.txtCPP.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPIS
        '
        Me.lblPIS.AutoSize = True
        Me.lblPIS.Location = New System.Drawing.Point(110, 57)
        Me.lblPIS.Name = "lblPIS"
        Me.lblPIS.Size = New System.Drawing.Size(25, 14)
        Me.lblPIS.TabIndex = 11
        Me.lblPIS.Text = "PIS:"
        '
        'txtPIS
        '
        Me.txtPIS.Location = New System.Drawing.Point(113, 74)
        Me.txtPIS.Name = "txtPIS"
        Me.txtPIS.Size = New System.Drawing.Size(98, 20)
        Me.txtPIS.TabIndex = 12
        Me.txtPIS.Text = "0,00"
        Me.txtPIS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblCSLL
        '
        Me.lblCSLL.AutoSize = True
        Me.lblCSLL.Location = New System.Drawing.Point(422, 17)
        Me.lblCSLL.Name = "lblCSLL"
        Me.lblCSLL.Size = New System.Drawing.Size(36, 14)
        Me.lblCSLL.TabIndex = 7
        Me.lblCSLL.Text = "CSLL:"
        '
        'txtCSLL
        '
        Me.txtCSLL.Location = New System.Drawing.Point(425, 34)
        Me.txtCSLL.Name = "txtCSLL"
        Me.txtCSLL.Size = New System.Drawing.Size(98, 20)
        Me.txtCSLL.TabIndex = 8
        Me.txtCSLL.Text = "0,00"
        Me.txtCSLL.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblCOFINS
        '
        Me.lblCOFINS.AutoSize = True
        Me.lblCOFINS.Location = New System.Drawing.Point(6, 57)
        Me.lblCOFINS.Name = "lblCOFINS"
        Me.lblCOFINS.Size = New System.Drawing.Size(47, 14)
        Me.lblCOFINS.TabIndex = 9
        Me.lblCOFINS.Text = "COFINS:"
        '
        'txtCOFINS
        '
        Me.txtCOFINS.Location = New System.Drawing.Point(9, 74)
        Me.txtCOFINS.Name = "txtCOFINS"
        Me.txtCOFINS.Size = New System.Drawing.Size(98, 20)
        Me.txtCOFINS.TabIndex = 10
        Me.txtCOFINS.Text = "0,00"
        Me.txtCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblIRPJ
        '
        Me.lblIRPJ.AutoSize = True
        Me.lblIRPJ.Location = New System.Drawing.Point(318, 17)
        Me.lblIRPJ.Name = "lblIRPJ"
        Me.lblIRPJ.Size = New System.Drawing.Size(30, 14)
        Me.lblIRPJ.TabIndex = 5
        Me.lblIRPJ.Text = "IRPJ:"
        '
        'txtIRPJ
        '
        Me.txtIRPJ.Location = New System.Drawing.Point(321, 34)
        Me.txtIRPJ.Name = "txtIRPJ"
        Me.txtIRPJ.Size = New System.Drawing.Size(98, 20)
        Me.txtIRPJ.TabIndex = 6
        Me.txtIRPJ.Text = "0,00"
        Me.txtIRPJ.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquota
        '
        Me.lblAliquota.AutoSize = True
        Me.lblAliquota.Location = New System.Drawing.Point(214, 17)
        Me.lblAliquota.Name = "lblAliquota"
        Me.lblAliquota.Size = New System.Drawing.Size(49, 14)
        Me.lblAliquota.TabIndex = 3
        Me.lblAliquota.Text = "Alíquota:"
        '
        'txtAliquota
        '
        Me.txtAliquota.Location = New System.Drawing.Point(217, 34)
        Me.txtAliquota.Name = "txtAliquota"
        Me.txtAliquota.Size = New System.Drawing.Size(98, 20)
        Me.txtAliquota.TabIndex = 4
        Me.txtAliquota.Text = "0,00"
        Me.txtAliquota.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtReceitaBrutaFinal
        '
        Me.txtReceitaBrutaFinal.Location = New System.Drawing.Point(113, 34)
        Me.txtReceitaBrutaFinal.Name = "txtReceitaBrutaFinal"
        Me.txtReceitaBrutaFinal.Size = New System.Drawing.Size(98, 20)
        Me.txtReceitaBrutaFinal.TabIndex = 2
        Me.txtReceitaBrutaFinal.Text = "0,00"
        Me.txtReceitaBrutaFinal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtReceitaBrutaInicio
        '
        Me.txtReceitaBrutaInicio.Location = New System.Drawing.Point(9, 34)
        Me.txtReceitaBrutaInicio.Name = "txtReceitaBrutaInicio"
        Me.txtReceitaBrutaInicio.Size = New System.Drawing.Size(98, 20)
        Me.txtReceitaBrutaInicio.TabIndex = 1
        Me.txtReceitaBrutaInicio.Text = "0,00"
        Me.txtReceitaBrutaInicio.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblReceitaBruta
        '
        Me.lblReceitaBruta.AutoSize = True
        Me.lblReceitaBruta.Location = New System.Drawing.Point(6, 17)
        Me.lblReceitaBruta.Name = "lblReceitaBruta"
        Me.lblReceitaBruta.Size = New System.Drawing.Size(142, 14)
        Me.lblReceitaBruta.TabIndex = 0
        Me.lblReceitaBruta.Text = "Receita Bruta em 12 meses:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 393)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(897, 51)
        Me.grpControl2.TabIndex = 3
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.cboTipoEmpresa)
        Me.grpDados.Controls.Add(Me.lblTipoEmpresa)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 64)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'cboTipoEmpresa
        '
        Me.cboTipoEmpresa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoEmpresa.AutoSize = False
        Me.cboTipoEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboTipoEmpresa.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboTipoEmpresa.Location = New System.Drawing.Point(9, 34)
        Me.cboTipoEmpresa.Name = "cboTipoEmpresa"
        Me.cboTipoEmpresa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoEmpresa.Size = New System.Drawing.Size(879, 20)
        Me.cboTipoEmpresa.TabIndex = 1
        '
        'lblTipoEmpresa
        '
        Me.lblTipoEmpresa.AutoSize = True
        Me.lblTipoEmpresa.Location = New System.Drawing.Point(6, 17)
        Me.lblTipoEmpresa.Name = "lblTipoEmpresa"
        Me.lblTipoEmpresa.Size = New System.Drawing.Size(90, 14)
        Me.lblTipoEmpresa.TabIndex = 0
        Me.lblTipoEmpresa.Text = "Tipo de Empresa:"
        '
        'usrImpSimplesNacional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrImpSimplesNacional"
        Me.Size = New System.Drawing.Size(915, 476)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdDados.ResumeLayout(False)
        Me.grdDados.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTipoEmpresa As System.Windows.Forms.Label
    Friend WithEvents grdDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblReceitaBruta As System.Windows.Forms.Label
    Friend WithEvents txtReceitaBrutaInicio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtReceitaBrutaFinal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtAliquota As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquota As System.Windows.Forms.Label
    Friend WithEvents lblCSLL As System.Windows.Forms.Label
    Friend WithEvents txtCSLL As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCOFINS As System.Windows.Forms.Label
    Friend WithEvents txtCOFINS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblIRPJ As System.Windows.Forms.Label
    Friend WithEvents txtIRPJ As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCPP As System.Windows.Forms.Label
    Friend WithEvents txtCPP As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPIS As System.Windows.Forms.Label
    Friend WithEvents txtPIS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblISS As System.Windows.Forms.Label
    Friend WithEvents txtISS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblICMS As System.Windows.Forms.Label
    Friend WithEvents txtICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboTipoEmpresa As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents chkFaixaAtiva As System.Windows.Forms.CheckBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button

End Class
