<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrIntImportacaoBoleto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrIntImportacaoBoleto))
        Dim grdImportacao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCpfCnpj = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtRazaoSocial = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.lblRazaoSocial = New System.Windows.Forms.Label()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNossoNum = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroDoc = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumDoc = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblNossoNum = New System.Windows.Forms.Label()
        Me.dtpDataTermino = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.dtpDataInicio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton()
        Me.btnImprimirHTML = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnImprimirBoleto = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo1 = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.pagDespesa = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridArquivo = New System.Windows.Forms.Button()
        Me.btnAgruparGridArquivo = New System.Windows.Forms.Button()
        Me.btnConfigurarGridArquivo = New System.Windows.Forms.Button()
        Me.grdImportacao = New Janus.Windows.GridEX.GridEX()
        Me.grpArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.UiButton2 = New Janus.Windows.EditControls.UIButton()
        Me.lblCNAB = New System.Windows.Forms.Label()
        Me.cboCNAB = New Janus.Windows.EditControls.UIComboBox()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.grdControlesEdicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnEnviarEmail = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltar = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        Me.pagDespesa.SuspendLayout()
        CType(Me.grdImportacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdControlesEdicao.SuspendLayout()
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
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDespesa})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Importar Boleto"
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnAutoResize = True
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 75)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 404)
        Me.grdListagem.TabIndex = 27
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = CType(resources.GetObject("btnExcelGrid.Image"), System.Drawing.Image)
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 461)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 26
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = CType(resources.GetObject("btnAgruparGrid.Image"), System.Drawing.Image)
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 461)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 25
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = CType(resources.GetObject("btnConfigurarGrid.Image"), System.Drawing.Image)
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 461)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 4
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtCpfCnpj)
        Me.grpFiltro.Controls.Add(Me.txtRazaoSocial)
        Me.grpFiltro.Controls.Add(Me.lblCpf)
        Me.grpFiltro.Controls.Add(Me.lblRazaoSocial)
        Me.grpFiltro.Controls.Add(Me.txtValor)
        Me.grpFiltro.Controls.Add(Me.txtNossoNum)
        Me.grpFiltro.Controls.Add(Me.txtNumeroDoc)
        Me.grpFiltro.Controls.Add(Me.lblNumDoc)
        Me.grpFiltro.Controls.Add(Me.lblValor)
        Me.grpFiltro.Controls.Add(Me.lblNossoNum)
        Me.grpFiltro.Controls.Add(Me.dtpDataTermino)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicio)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 66)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtCpfCnpj
        '
        Me.txtCpfCnpj.Location = New System.Drawing.Point(429, 35)
        Me.txtCpfCnpj.MaxLength = 35
        Me.txtCpfCnpj.Name = "txtCpfCnpj"
        Me.txtCpfCnpj.Size = New System.Drawing.Size(135, 20)
        Me.txtCpfCnpj.TabIndex = 35
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazaoSocial.Location = New System.Drawing.Point(570, 35)
        Me.txtRazaoSocial.MaxLength = 35
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        Me.txtRazaoSocial.Size = New System.Drawing.Size(256, 20)
        Me.txtRazaoSocial.TabIndex = 34
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(426, 18)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(57, 14)
        Me.lblCpf.TabIndex = 33
        Me.lblCpf.Text = "CPF/CNPJ:"
        '
        'lblRazaoSocial
        '
        Me.lblRazaoSocial.AutoSize = True
        Me.lblRazaoSocial.Location = New System.Drawing.Point(567, 18)
        Me.lblRazaoSocial.Name = "lblRazaoSocial"
        Me.lblRazaoSocial.Size = New System.Drawing.Size(73, 14)
        Me.lblRazaoSocial.TabIndex = 32
        Me.lblRazaoSocial.Text = "Razão Social:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(147, 35)
        Me.txtValor.MaxLength = 35
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(135, 20)
        Me.txtValor.TabIndex = 31
        '
        'txtNossoNum
        '
        Me.txtNossoNum.Location = New System.Drawing.Point(288, 35)
        Me.txtNossoNum.MaxLength = 35
        Me.txtNossoNum.Name = "txtNossoNum"
        Me.txtNossoNum.Size = New System.Drawing.Size(135, 20)
        Me.txtNossoNum.TabIndex = 30
        '
        'txtNumeroDoc
        '
        Me.txtNumeroDoc.Location = New System.Drawing.Point(6, 35)
        Me.txtNumeroDoc.MaxLength = 35
        Me.txtNumeroDoc.Name = "txtNumeroDoc"
        Me.txtNumeroDoc.Size = New System.Drawing.Size(135, 20)
        Me.txtNumeroDoc.TabIndex = 29
        '
        'lblNumDoc
        '
        Me.lblNumDoc.AutoSize = True
        Me.lblNumDoc.Location = New System.Drawing.Point(3, 18)
        Me.lblNumDoc.Name = "lblNumDoc"
        Me.lblNumDoc.Size = New System.Drawing.Size(104, 14)
        Me.lblNumDoc.TabIndex = 28
        Me.lblNumDoc.Text = "Numero Documento:"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(144, 18)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(35, 14)
        Me.lblValor.TabIndex = 27
        Me.lblValor.Text = "Valor:"
        '
        'lblNossoNum
        '
        Me.lblNossoNum.AutoSize = True
        Me.lblNossoNum.Location = New System.Drawing.Point(285, 18)
        Me.lblNossoNum.Name = "lblNossoNum"
        Me.lblNossoNum.Size = New System.Drawing.Size(81, 14)
        Me.lblNossoNum.TabIndex = 26
        Me.lblNossoNum.Text = "Nosso Número:"
        '
        'dtpDataTermino
        '
        '
        '
        '
        Me.dtpDataTermino.DropDownCalendar.Name = ""
        Me.dtpDataTermino.Location = New System.Drawing.Point(947, 35)
        Me.dtpDataTermino.Name = "dtpDataTermino"
        Me.dtpDataTermino.ShowCheckBox = True
        Me.dtpDataTermino.Size = New System.Drawing.Size(109, 20)
        Me.dtpDataTermino.TabIndex = 25
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(829, 18)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 14
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'dtpDataInicio
        '
        '
        '
        '
        Me.dtpDataInicio.DropDownCalendar.Name = ""
        Me.dtpDataInicio.Location = New System.Drawing.Point(832, 35)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.ShowCheckBox = True
        Me.dtpDataInicio.Size = New System.Drawing.Size(109, 20)
        Me.dtpDataInicio.TabIndex = 15
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = CType(resources.GetObject("btnFiltrar.Image"), System.Drawing.Image)
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 36)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 23
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.UiButton1)
        Me.grpControle.Controls.Add(Me.btnImprimirHTML)
        Me.grpControle.Controls.Add(Me.btnExcluir)
        Me.grpControle.Controls.Add(Me.btnImprimirBoleto)
        Me.grpControle.Controls.Add(Me.btnNovo1)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(897, 51)
        Me.grpControle.TabIndex = 3
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'UiButton1
        '
        Me.UiButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UiButton1.Image = Global.INTERACTI.My.Resources.Resources.email
        Me.UiButton1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.UiButton1.Location = New System.Drawing.Point(6, 17)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiButton1.Size = New System.Drawing.Size(150, 23)
        Me.UiButton1.TabIndex = 8
        Me.UiButton1.Text = "E-mail (direto)"
        Me.UiButton1.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImprimirHTML
        '
        Me.btnImprimirHTML.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirHTML.Image = Global.INTERACTI.My.Resources.Resources.xml
        Me.btnImprimirHTML.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimirHTML.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnImprimirHTML.Location = New System.Drawing.Point(409, 17)
        Me.btnImprimirHTML.Name = "btnImprimirHTML"
        Me.btnImprimirHTML.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimirHTML.Size = New System.Drawing.Size(91, 23)
        Me.btnImprimirHTML.TabIndex = 6
        Me.btnImprimirHTML.Text = "HTML"
        Me.btnImprimirHTML.Visible = False
        Me.btnImprimirHTML.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(506, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 5
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImprimirBoleto
        '
        Me.btnImprimirBoleto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirBoleto.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimirBoleto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimirBoleto.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnImprimirBoleto.Location = New System.Drawing.Point(603, 17)
        Me.btnImprimirBoleto.Name = "btnImprimirBoleto"
        Me.btnImprimirBoleto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimirBoleto.Size = New System.Drawing.Size(91, 23)
        Me.btnImprimirBoleto.TabIndex = 3
        Me.btnImprimirBoleto.Text = "Imprimir"
        Me.btnImprimirBoleto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo1
        '
        Me.btnNovo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo1.Image = CType(resources.GetObject("btnNovo1.Image"), System.Drawing.Image)
        Me.btnNovo1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo1.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo1.Location = New System.Drawing.Point(700, 17)
        Me.btnNovo1.Name = "btnNovo1"
        Me.btnNovo1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo1.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo1.TabIndex = 2
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
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDespesa
        '
        Me.pagDespesa.Controls.Add(Me.btnExcelGridArquivo)
        Me.pagDespesa.Controls.Add(Me.btnAgruparGridArquivo)
        Me.pagDespesa.Controls.Add(Me.btnConfigurarGridArquivo)
        Me.pagDespesa.Controls.Add(Me.grdImportacao)
        Me.pagDespesa.Controls.Add(Me.grpArquivo)
        Me.pagDespesa.Controls.Add(Me.grdControlesEdicao)
        Me.pagDespesa.Key = "pagDespesa"
        Me.pagDespesa.Location = New System.Drawing.Point(1, 22)
        Me.pagDespesa.Name = "pagDespesa"
        Me.pagDespesa.Size = New System.Drawing.Size(913, 543)
        Me.pagDespesa.TabStop = True
        Me.pagDespesa.Text = "Importar Boleto"
        '
        'btnExcelGridArquivo
        '
        Me.btnExcelGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnExcelGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridArquivo.Image = CType(resources.GetObject("btnExcelGridArquivo.Image"), System.Drawing.Image)
        Me.btnExcelGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridArquivo.Location = New System.Drawing.Point(57, 462)
        Me.btnExcelGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridArquivo.Name = "btnExcelGridArquivo"
        Me.btnExcelGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridArquivo.TabIndex = 30
        Me.btnExcelGridArquivo.TabStop = False
        Me.btnExcelGridArquivo.UseVisualStyleBackColor = False
        '
        'btnAgruparGridArquivo
        '
        Me.btnAgruparGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridArquivo.Image = CType(resources.GetObject("btnAgruparGridArquivo.Image"), System.Drawing.Image)
        Me.btnAgruparGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridArquivo.Location = New System.Drawing.Point(33, 462)
        Me.btnAgruparGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridArquivo.Name = "btnAgruparGridArquivo"
        Me.btnAgruparGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridArquivo.TabIndex = 29
        Me.btnAgruparGridArquivo.TabStop = False
        Me.btnAgruparGridArquivo.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridArquivo
        '
        Me.btnConfigurarGridArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridArquivo.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridArquivo.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridArquivo.Image = CType(resources.GetObject("btnConfigurarGridArquivo.Image"), System.Drawing.Image)
        Me.btnConfigurarGridArquivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridArquivo.Location = New System.Drawing.Point(10, 462)
        Me.btnConfigurarGridArquivo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridArquivo.Name = "btnConfigurarGridArquivo"
        Me.btnConfigurarGridArquivo.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridArquivo.TabIndex = 28
        Me.btnConfigurarGridArquivo.TabStop = False
        Me.btnConfigurarGridArquivo.UseVisualStyleBackColor = False
        '
        'grdImportacao
        '
        Me.grdImportacao.AllowChildTableGroups = True
        Me.grdImportacao.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdImportacao.AlternatingColors = True
        Me.grdImportacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdImportacao.AutoEdit = True
        grdImportacao_DesignTimeLayout.LayoutString = resources.GetString("grdImportacao_DesignTimeLayout.LayoutString")
        Me.grdImportacao.DesignTimeLayout = grdImportacao_DesignTimeLayout
        Me.grdImportacao.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdImportacao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdImportacao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdImportacao.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdImportacao.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdImportacao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdImportacao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdImportacao.FrozenColumns = 5
        Me.grdImportacao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdImportacao.GroupByBoxVisible = False
        Me.grdImportacao.Hierarchical = True
        Me.grdImportacao.Location = New System.Drawing.Point(8, 80)
        Me.grdImportacao.Name = "grdImportacao"
        Me.grdImportacao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdImportacao.RecordNavigator = True
        Me.grdImportacao.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdImportacao.SelectedFormatStyle.BackColor = System.Drawing.Color.PaleTurquoise
        Me.grdImportacao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdImportacao.Size = New System.Drawing.Size(897, 399)
        Me.grdImportacao.TabIndex = 31
        Me.grdImportacao.TabStop = False
        Me.grdImportacao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdImportacao.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdImportacao.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdImportacao.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdImportacao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdImportacao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdImportacao.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdImportacao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdImportacao.VisualStyleManager = Me.vsmMain
        '
        'grpArquivo
        '
        Me.grpArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpArquivo.Controls.Add(Me.UiButton2)
        Me.grpArquivo.Controls.Add(Me.lblCNAB)
        Me.grpArquivo.Controls.Add(Me.cboCNAB)
        Me.grpArquivo.Controls.Add(Me.txtArquivo)
        Me.grpArquivo.Controls.Add(Me.btnArquivo)
        Me.grpArquivo.Controls.Add(Me.lblArquivo)
        Me.grpArquivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpArquivo.Location = New System.Drawing.Point(8, 3)
        Me.grpArquivo.Name = "grpArquivo"
        Me.grpArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpArquivo.Size = New System.Drawing.Size(897, 67)
        Me.grpArquivo.TabIndex = 1
        Me.grpArquivo.Text = "Arquivo"
        Me.grpArquivo.VisualStyleManager = Me.vsmMain
        '
        'UiButton2
        '
        Me.UiButton2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.UiButton2.ImageSize = New System.Drawing.Size(13, 16)
        Me.UiButton2.Location = New System.Drawing.Point(617, 36)
        Me.UiButton2.Name = "UiButton2"
        Me.UiButton2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiButton2.Size = New System.Drawing.Size(99, 20)
        Me.UiButton2.TabIndex = 14
        Me.UiButton2.Text = "Importar Crédito"
        Me.UiButton2.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblCNAB
        '
        Me.lblCNAB.AutoSize = True
        Me.lblCNAB.Location = New System.Drawing.Point(3, 19)
        Me.lblCNAB.Name = "lblCNAB"
        Me.lblCNAB.Size = New System.Drawing.Size(39, 14)
        Me.lblCNAB.TabIndex = 12
        Me.lblCNAB.Text = "CNAB:"
        '
        'cboCNAB
        '
        Me.cboCNAB.AutoSize = False
        Me.cboCNAB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCNAB.Location = New System.Drawing.Point(7, 36)
        Me.cboCNAB.Name = "cboCNAB"
        Me.cboCNAB.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCNAB.Size = New System.Drawing.Size(92, 20)
        Me.cboCNAB.TabIndex = 13
        '
        'txtArquivo
        '
        Me.txtArquivo.BackColor = System.Drawing.SystemColors.Info
        Me.txtArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArquivo.Location = New System.Drawing.Point(105, 36)
        Me.txtArquivo.MaxLength = 50
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(489, 20)
        Me.txtArquivo.TabIndex = 10
        Me.txtArquivo.TabStop = False
        '
        'btnArquivo
        '
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnArquivo.Location = New System.Drawing.Point(593, 36)
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivo.Size = New System.Drawing.Size(23, 20)
        Me.btnArquivo.TabIndex = 11
        Me.btnArquivo.Text = "..."
        Me.btnArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivo
        '
        Me.lblArquivo.AutoSize = True
        Me.lblArquivo.Location = New System.Drawing.Point(102, 19)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(48, 14)
        Me.lblArquivo.TabIndex = 1
        Me.lblArquivo.Text = "Arquivo:"
        '
        'grdControlesEdicao
        '
        Me.grdControlesEdicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdControlesEdicao.BackColor = System.Drawing.Color.Transparent
        Me.grdControlesEdicao.Controls.Add(Me.btnEnviarEmail)
        Me.grdControlesEdicao.Controls.Add(Me.btnVoltar)
        Me.grdControlesEdicao.Location = New System.Drawing.Point(8, 483)
        Me.grdControlesEdicao.Name = "grdControlesEdicao"
        Me.grdControlesEdicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grdControlesEdicao.Size = New System.Drawing.Size(897, 51)
        Me.grdControlesEdicao.TabIndex = 3
        Me.grdControlesEdicao.VisualStyleManager = Me.vsmMain
        '
        'btnEnviarEmail
        '
        Me.btnEnviarEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarEmail.Image = Global.INTERACTI.My.Resources.Resources.email
        Me.btnEnviarEmail.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnEnviarEmail.Location = New System.Drawing.Point(7, 17)
        Me.btnEnviarEmail.Name = "btnEnviarEmail"
        Me.btnEnviarEmail.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnEnviarEmail.Size = New System.Drawing.Size(150, 23)
        Me.btnEnviarEmail.TabIndex = 8
        Me.btnEnviarEmail.Text = "E-mail (direto)"
        Me.btnEnviarEmail.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltar
        '
        Me.btnVoltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltar.Image = CType(resources.GetObject("btnVoltar.Image"), System.Drawing.Image)
        Me.btnVoltar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltar.Location = New System.Drawing.Point(797, 17)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltar.TabIndex = 0
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrIntImportacaoBoleto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrIntImportacaoBoleto"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.pagDespesa.ResumeLayout(False)
        CType(Me.grdImportacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdControlesEdicao.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDespesa As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdControlesEdicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataInicio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents grpArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Private WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridArquivo As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridArquivo As System.Windows.Forms.Button
    Friend WithEvents grdImportacao As Janus.Windows.GridEX.GridEX
    Friend WithEvents dtpDataTermino As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblCNAB As System.Windows.Forms.Label
    Friend WithEvents cboCNAB As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNumDoc As System.Windows.Forms.Label
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents lblNossoNum As System.Windows.Forms.Label
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNossoNum As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroDoc As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCpfCnpj As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtRazaoSocial As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCpf As System.Windows.Forms.Label
    Friend WithEvents lblRazaoSocial As System.Windows.Forms.Label
    Friend WithEvents btnImprimirBoleto As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnImprimirHTML As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnEnviarEmail As Janus.Windows.EditControls.UIButton
    Private WithEvents UiButton2 As Janus.Windows.EditControls.UIButton

End Class
