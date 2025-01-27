<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadItemLote
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
        Dim grdItens_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdItens_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadItemLote))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdItens = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarClasse = New System.Windows.Forms.Button()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.txtPartNumberFinal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.lblPartNumberFinal = New System.Windows.Forms.Label()
        Me.txtDET = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtSC = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.chkDireito = New Janus.Windows.EditControls.UICheckBox()
        Me.chkEsquerdo = New Janus.Windows.EditControls.UICheckBox()
        Me.lblDET = New System.Windows.Forms.Label()
        Me.lblSC = New System.Windows.Forms.Label()
        Me.txtNumeroDesenho = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDesenho = New System.Windows.Forms.Label()
        Me.lblNCM = New System.Windows.Forms.Label()
        Me.cboNCM = New Janus.Windows.EditControls.UIComboBox()
        Me.txtDescricaoFinal2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFinal2 = New System.Windows.Forms.Label()
        Me.txtComplemento2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblComplemento2 = New System.Windows.Forms.Label()
        Me.txtDescricao2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao2 = New System.Windows.Forms.Label()
        Me.txtDescricaoFinal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoFinal = New System.Windows.Forms.Label()
        Me.txtComplemento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cboTipo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblClasse = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboClasse = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.chkItemCompra = New Janus.Windows.EditControls.UICheckBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pagDados.Controls.Add(Me.grdItens)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 453)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Cadastro de Item em Lote"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(35, 373)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 88
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(11, 373)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 87
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdItens
        '
        Me.grdItens.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdItens.AlternatingColors = True
        Me.grdItens.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdItens.ColumnAutoResize = True
        grdItens_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdItens_DesignTimeLayout_Reference_0.Instance"), Object)
        grdItens_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdItens_DesignTimeLayout_Reference_0})
        grdItens_DesignTimeLayout.LayoutString = resources.GetString("grdItens_DesignTimeLayout.LayoutString")
        Me.grdItens.DesignTimeLayout = grdItens_DesignTimeLayout
        Me.grdItens.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdItens.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdItens.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed
        Me.grdItens.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdItens.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdItens.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdItens.GroupByBoxVisible = False
        Me.grdItens.Location = New System.Drawing.Point(8, 199)
        Me.grdItens.Name = "grdItens"
        Me.grdItens.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdItens.RecordNavigator = True
        Me.grdItens.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdItens.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdItens.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdItens.Size = New System.Drawing.Size(897, 191)
        Me.grdItens.TabIndex = 2
        Me.grdItens.TabStop = False
        Me.grdItens.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdItens.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdItens.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdItens.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdItens.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnNovo1)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 393)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(897, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(700, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 31
        Me.btnNovo1.Text = "Novo"
        Me.btnNovo1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.chkItemCompra)
        Me.grpDados.Controls.Add(Me.btnProcurarClasse)
        Me.grpDados.Controls.Add(Me.btnExcluir)
        Me.grpDados.Controls.Add(Me.txtPartNumberFinal)
        Me.grpDados.Controls.Add(Me.btnInserir)
        Me.grpDados.Controls.Add(Me.lblPartNumberFinal)
        Me.grpDados.Controls.Add(Me.txtDET)
        Me.grpDados.Controls.Add(Me.txtSC)
        Me.grpDados.Controls.Add(Me.chkDireito)
        Me.grpDados.Controls.Add(Me.chkEsquerdo)
        Me.grpDados.Controls.Add(Me.lblDET)
        Me.grpDados.Controls.Add(Me.lblSC)
        Me.grpDados.Controls.Add(Me.txtNumeroDesenho)
        Me.grpDados.Controls.Add(Me.lblNumeroDesenho)
        Me.grpDados.Controls.Add(Me.lblNCM)
        Me.grpDados.Controls.Add(Me.cboNCM)
        Me.grpDados.Controls.Add(Me.txtDescricaoFinal2)
        Me.grpDados.Controls.Add(Me.lblDescricaoFinal2)
        Me.grpDados.Controls.Add(Me.txtComplemento2)
        Me.grpDados.Controls.Add(Me.lblComplemento2)
        Me.grpDados.Controls.Add(Me.txtDescricao2)
        Me.grpDados.Controls.Add(Me.lblDescricao2)
        Me.grpDados.Controls.Add(Me.txtDescricaoFinal)
        Me.grpDados.Controls.Add(Me.lblDescricaoFinal)
        Me.grpDados.Controls.Add(Me.txtComplemento)
        Me.grpDados.Controls.Add(Me.lblComplemento)
        Me.grpDados.Controls.Add(Me.lblTipo)
        Me.grpDados.Controls.Add(Me.cboTipo)
        Me.grpDados.Controls.Add(Me.lblClasse)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.cboClasse)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 187)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarClasse
        '
        Me.btnProcurarClasse.FlatAppearance.BorderSize = 0
        Me.btnProcurarClasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarClasse.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarClasse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarClasse.Location = New System.Drawing.Point(762, 16)
        Me.btnProcurarClasse.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarClasse.Name = "btnProcurarClasse"
        Me.btnProcurarClasse.Size = New System.Drawing.Size(17, 15)
        Me.btnProcurarClasse.TabIndex = 30
        Me.btnProcurarClasse.TabStop = False
        Me.btnProcurarClasse.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.Location = New System.Drawing.Point(797, 160)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 29
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtPartNumberFinal
        '
        Me.txtPartNumberFinal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPartNumberFinal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPartNumberFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartNumberFinal.Location = New System.Drawing.Point(586, 154)
        Me.txtPartNumberFinal.MaxLength = 100
        Me.txtPartNumberFinal.Name = "txtPartNumberFinal"
        Me.txtPartNumberFinal.ReadOnly = True
        Me.txtPartNumberFinal.Size = New System.Drawing.Size(205, 20)
        Me.txtPartNumberFinal.TabIndex = 27
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(797, 137)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 28
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblPartNumberFinal
        '
        Me.lblPartNumberFinal.AutoSize = True
        Me.lblPartNumberFinal.Location = New System.Drawing.Point(583, 137)
        Me.lblPartNumberFinal.Name = "lblPartNumberFinal"
        Me.lblPartNumberFinal.Size = New System.Drawing.Size(94, 14)
        Me.lblPartNumberFinal.TabIndex = 26
        Me.lblPartNumberFinal.Text = "Part Number Final:"
        '
        'txtDET
        '
        Me.txtDET.DecimalDigits = 0
        Me.txtDET.FormatString = "000"
        Me.txtDET.Location = New System.Drawing.Point(403, 154)
        Me.txtDET.MaxLength = 3
        Me.txtDET.Name = "txtDET"
        Me.txtDET.Size = New System.Drawing.Size(90, 20)
        Me.txtDET.TabIndex = 23
        Me.txtDET.Text = "000"
        Me.txtDET.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtSC
        '
        Me.txtSC.DecimalDigits = 0
        Me.txtSC.FormatString = "00"
        Me.txtSC.Location = New System.Drawing.Point(307, 154)
        Me.txtSC.MaxLength = 2
        Me.txtSC.Name = "txtSC"
        Me.txtSC.Size = New System.Drawing.Size(90, 20)
        Me.txtSC.TabIndex = 21
        Me.txtSC.Text = "00"
        Me.txtSC.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'chkDireito
        '
        Me.chkDireito.Location = New System.Drawing.Point(499, 160)
        Me.chkDireito.Name = "chkDireito"
        Me.chkDireito.Size = New System.Drawing.Size(81, 18)
        Me.chkDireito.TabIndex = 25
        Me.chkDireito.Text = "Direito"
        '
        'chkEsquerdo
        '
        Me.chkEsquerdo.Location = New System.Drawing.Point(499, 140)
        Me.chkEsquerdo.Name = "chkEsquerdo"
        Me.chkEsquerdo.Size = New System.Drawing.Size(81, 18)
        Me.chkEsquerdo.TabIndex = 24
        Me.chkEsquerdo.Text = "Esquerdo"
        '
        'lblDET
        '
        Me.lblDET.AutoSize = True
        Me.lblDET.Location = New System.Drawing.Point(400, 137)
        Me.lblDET.Name = "lblDET"
        Me.lblDET.Size = New System.Drawing.Size(28, 14)
        Me.lblDET.TabIndex = 22
        Me.lblDET.Text = "DET:"
        '
        'lblSC
        '
        Me.lblSC.AutoSize = True
        Me.lblSC.Location = New System.Drawing.Point(304, 137)
        Me.lblSC.Name = "lblSC"
        Me.lblSC.Size = New System.Drawing.Size(24, 14)
        Me.lblSC.TabIndex = 20
        Me.lblSC.Text = "SC:"
        '
        'txtNumeroDesenho
        '
        Me.txtNumeroDesenho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDesenho.Location = New System.Drawing.Point(94, 154)
        Me.txtNumeroDesenho.MaxLength = 100
        Me.txtNumeroDesenho.Name = "txtNumeroDesenho"
        Me.txtNumeroDesenho.Size = New System.Drawing.Size(207, 20)
        Me.txtNumeroDesenho.TabIndex = 19
        '
        'lblNumeroDesenho
        '
        Me.lblNumeroDesenho.AutoSize = True
        Me.lblNumeroDesenho.Location = New System.Drawing.Point(91, 137)
        Me.lblNumeroDesenho.Name = "lblNumeroDesenho"
        Me.lblNumeroDesenho.Size = New System.Drawing.Size(68, 14)
        Me.lblNumeroDesenho.TabIndex = 18
        Me.lblNumeroDesenho.Text = "Nº Desenho:"
        '
        'lblNCM
        '
        Me.lblNCM.AutoSize = True
        Me.lblNCM.Location = New System.Drawing.Point(6, 137)
        Me.lblNCM.Name = "lblNCM"
        Me.lblNCM.Size = New System.Drawing.Size(32, 14)
        Me.lblNCM.TabIndex = 16
        Me.lblNCM.Text = "NCM:"
        '
        'cboNCM
        '
        Me.cboNCM.AutoSize = False
        Me.cboNCM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboNCM.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboNCM.Location = New System.Drawing.Point(9, 154)
        Me.cboNCM.Name = "cboNCM"
        Me.cboNCM.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNCM.Size = New System.Drawing.Size(79, 20)
        Me.cboNCM.TabIndex = 17
        '
        'txtDescricaoFinal2
        '
        Me.txtDescricaoFinal2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoFinal2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoFinal2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFinal2.Location = New System.Drawing.Point(499, 114)
        Me.txtDescricaoFinal2.MaxLength = 100
        Me.txtDescricaoFinal2.Name = "txtDescricaoFinal2"
        Me.txtDescricaoFinal2.ReadOnly = True
        Me.txtDescricaoFinal2.Size = New System.Drawing.Size(379, 20)
        Me.txtDescricaoFinal2.TabIndex = 15
        '
        'lblDescricaoFinal2
        '
        Me.lblDescricaoFinal2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescricaoFinal2.AutoSize = True
        Me.lblDescricaoFinal2.Location = New System.Drawing.Point(496, 97)
        Me.lblDescricaoFinal2.Name = "lblDescricaoFinal2"
        Me.lblDescricaoFinal2.Size = New System.Drawing.Size(93, 14)
        Me.lblDescricaoFinal2.TabIndex = 14
        Me.lblDescricaoFinal2.Text = "Descrição Final 2:"
        '
        'txtComplemento2
        '
        Me.txtComplemento2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComplemento2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento2.Location = New System.Drawing.Point(307, 114)
        Me.txtComplemento2.MaxLength = 100
        Me.txtComplemento2.Name = "txtComplemento2"
        Me.txtComplemento2.Size = New System.Drawing.Size(186, 20)
        Me.txtComplemento2.TabIndex = 13
        '
        'lblComplemento2
        '
        Me.lblComplemento2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblComplemento2.AutoSize = True
        Me.lblComplemento2.Location = New System.Drawing.Point(304, 97)
        Me.lblComplemento2.Name = "lblComplemento2"
        Me.lblComplemento2.Size = New System.Drawing.Size(74, 14)
        Me.lblComplemento2.TabIndex = 12
        Me.lblComplemento2.Text = "Complemento:"
        '
        'txtDescricao2
        '
        Me.txtDescricao2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao2.Location = New System.Drawing.Point(9, 114)
        Me.txtDescricao2.MaxLength = 100
        Me.txtDescricao2.Name = "txtDescricao2"
        Me.txtDescricao2.ReadOnly = True
        Me.txtDescricao2.Size = New System.Drawing.Size(292, 20)
        Me.txtDescricao2.TabIndex = 11
        '
        'lblDescricao2
        '
        Me.lblDescricao2.AutoSize = True
        Me.lblDescricao2.Location = New System.Drawing.Point(6, 97)
        Me.lblDescricao2.Name = "lblDescricao2"
        Me.lblDescricao2.Size = New System.Drawing.Size(68, 14)
        Me.lblDescricao2.TabIndex = 10
        Me.lblDescricao2.Text = "Descrição 2:"
        '
        'txtDescricaoFinal
        '
        Me.txtDescricaoFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoFinal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoFinal.Location = New System.Drawing.Point(499, 74)
        Me.txtDescricaoFinal.MaxLength = 100
        Me.txtDescricaoFinal.Name = "txtDescricaoFinal"
        Me.txtDescricaoFinal.ReadOnly = True
        Me.txtDescricaoFinal.Size = New System.Drawing.Size(379, 20)
        Me.txtDescricaoFinal.TabIndex = 9
        '
        'lblDescricaoFinal
        '
        Me.lblDescricaoFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescricaoFinal.AutoSize = True
        Me.lblDescricaoFinal.Location = New System.Drawing.Point(496, 57)
        Me.lblDescricaoFinal.Name = "lblDescricaoFinal"
        Me.lblDescricaoFinal.Size = New System.Drawing.Size(84, 14)
        Me.lblDescricaoFinal.TabIndex = 8
        Me.lblDescricaoFinal.Text = "Descrição Final:"
        '
        'txtComplemento
        '
        Me.txtComplemento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento.Location = New System.Drawing.Point(307, 74)
        Me.txtComplemento.MaxLength = 100
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(186, 20)
        Me.txtComplemento.TabIndex = 7
        '
        'lblComplemento
        '
        Me.lblComplemento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(304, 57)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(74, 14)
        Me.lblComplemento.TabIndex = 6
        Me.lblComplemento.Text = "Complemento:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(6, 17)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 14)
        Me.lblTipo.TabIndex = 0
        Me.lblTipo.Text = "Tipo:"
        '
        'cboTipo
        '
        Me.cboTipo.AutoSize = False
        Me.cboTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboTipo.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboTipo.Location = New System.Drawing.Point(9, 34)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipo.Size = New System.Drawing.Size(292, 20)
        Me.cboTipo.TabIndex = 1
        '
        'lblClasse
        '
        Me.lblClasse.AutoSize = True
        Me.lblClasse.Location = New System.Drawing.Point(304, 17)
        Me.lblClasse.Name = "lblClasse"
        Me.lblClasse.Size = New System.Drawing.Size(43, 14)
        Me.lblClasse.TabIndex = 2
        Me.lblClasse.Text = "Classe:"
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(9, 74)
        Me.txtDescricao.MaxLength = 100
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(292, 20)
        Me.txtDescricao.TabIndex = 5
        '
        'cboClasse
        '
        Me.cboClasse.AutoSize = False
        Me.cboClasse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "SIM"
        UiComboBoxItem5.Value = True
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "NÃO"
        UiComboBoxItem6.Value = False
        Me.cboClasse.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboClasse.Location = New System.Drawing.Point(307, 34)
        Me.cboClasse.Name = "cboClasse"
        Me.cboClasse.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboClasse.Size = New System.Drawing.Size(472, 20)
        Me.cboClasse.TabIndex = 3
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(6, 57)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 4
        Me.lblDescricao.Text = "Descrição:"
        '
        'chkItemCompra
        '
        Me.chkItemCompra.Location = New System.Drawing.Point(797, 36)
        Me.chkItemCompra.Name = "chkItemCompra"
        Me.chkItemCompra.Size = New System.Drawing.Size(81, 18)
        Me.chkItemCompra.TabIndex = 31
        Me.chkItemCompra.Text = "Item Compra"
        '
        'usrCadItemLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadItemLote"
        Me.Size = New System.Drawing.Size(915, 476)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboClasse As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblClasse As System.Windows.Forms.Label
    Friend WithEvents lblSC As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDesenho As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDesenho As System.Windows.Forms.Label
    Friend WithEvents lblNCM As System.Windows.Forms.Label
    Friend WithEvents cboNCM As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtDescricaoFinal2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFinal2 As System.Windows.Forms.Label
    Friend WithEvents txtComplemento2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblComplemento2 As System.Windows.Forms.Label
    Friend WithEvents txtDescricao2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao2 As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoFinal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFinal As System.Windows.Forms.Label
    Friend WithEvents txtComplemento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblComplemento As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents cboTipo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdItens As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblDET As System.Windows.Forms.Label
    Friend WithEvents chkDireito As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkEsquerdo As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents txtPartNumberFinal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPartNumberFinal As System.Windows.Forms.Label
    Friend WithEvents txtDET As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtSC As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnProcurarClasse As System.Windows.Forms.Button
    Private WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents chkItemCompra As Janus.Windows.EditControls.UICheckBox

End Class
