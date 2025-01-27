<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrAdmInteractiCompare
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrAdmInteractiCompare))
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.btnComparar = New Janus.Windows.EditControls.UIButton()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpDestino = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtBancoDadosDestino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblBancoDadosDestino = New System.Windows.Forms.Label()
        Me.txtSenhaDestino = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblSenhaDestino = New System.Windows.Forms.Label()
        Me.txtUsuarioDestino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblUsuarioDestino = New System.Windows.Forms.Label()
        Me.txtNomeServidorDestino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNomeServidorDestino = New System.Windows.Forms.Label()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExecutar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpOrigem = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtBancoDadosOrigem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblBancoDadosOrigem = New System.Windows.Forms.Label()
        Me.txtSenhaOrigem = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblSenhaOrigem = New System.Windows.Forms.Label()
        Me.txtUsuarioOrigem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblUsuarioOrigem = New System.Windows.Forms.Label()
        Me.txtNomeServidorOrigem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNomeServidorOrigem = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDestino.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpOrigem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOrigem.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 467)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpDestino)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.grpOrigem)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 444)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Interacti - Database Compare"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(458, 418)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 32
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(434, 418)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 10
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFiltro)
        Me.grpFiltro.Controls.Add(Me.btnComparar)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 263)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(392, 67)
        Me.grpFiltro.TabIndex = 2
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtFiltro
        '
        Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltro.Location = New System.Drawing.Point(9, 37)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(154, 20)
        Me.txtFiltro.TabIndex = 1
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Location = New System.Drawing.Point(6, 20)
        Me.lblFiltro.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(86, 14)
        Me.lblFiltro.TabIndex = 0
        Me.lblFiltro.Text = "Nome da Tabela:"
        '
        'btnComparar
        '
        Me.btnComparar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnComparar.Image = Global.INTERACTI.My.Resources.duplicar
        Me.btnComparar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnComparar.Location = New System.Drawing.Point(293, 34)
        Me.btnComparar.Name = "btnComparar"
        Me.btnComparar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnComparar.Size = New System.Drawing.Size(90, 23)
        Me.btnComparar.TabIndex = 2
        Me.btnComparar.Text = "Comparar"
        Me.btnComparar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'grpDestino
        '
        Me.grpDestino.BackColor = System.Drawing.Color.Transparent
        Me.grpDestino.Controls.Add(Me.txtBancoDadosDestino)
        Me.grpDestino.Controls.Add(Me.lblBancoDadosDestino)
        Me.grpDestino.Controls.Add(Me.txtSenhaDestino)
        Me.grpDestino.Controls.Add(Me.lblSenhaDestino)
        Me.grpDestino.Controls.Add(Me.txtUsuarioDestino)
        Me.grpDestino.Controls.Add(Me.lblUsuarioDestino)
        Me.grpDestino.Controls.Add(Me.txtNomeServidorDestino)
        Me.grpDestino.Controls.Add(Me.lblNomeServidorDestino)
        Me.grpDestino.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDestino.Location = New System.Drawing.Point(8, 133)
        Me.grpDestino.Name = "grpDestino"
        Me.grpDestino.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDestino.Size = New System.Drawing.Size(392, 127)
        Me.grpDestino.TabIndex = 1
        Me.grpDestino.Text = "Database Destino"
        Me.grpDestino.VisualStyleManager = Me.vsmMain
        '
        'txtBancoDadosDestino
        '
        Me.txtBancoDadosDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBancoDadosDestino.Location = New System.Drawing.Point(133, 97)
        Me.txtBancoDadosDestino.Name = "txtBancoDadosDestino"
        Me.txtBancoDadosDestino.Size = New System.Drawing.Size(250, 20)
        Me.txtBancoDadosDestino.TabIndex = 7
        '
        'lblBancoDadosDestino
        '
        Me.lblBancoDadosDestino.AutoSize = True
        Me.lblBancoDadosDestino.Location = New System.Drawing.Point(6, 100)
        Me.lblBancoDadosDestino.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblBancoDadosDestino.Name = "lblBancoDadosDestino"
        Me.lblBancoDadosDestino.Size = New System.Drawing.Size(90, 14)
        Me.lblBancoDadosDestino.TabIndex = 6
        Me.lblBancoDadosDestino.Text = "Banco de Dados:"
        '
        'txtSenhaDestino
        '
        Me.txtSenhaDestino.Location = New System.Drawing.Point(133, 71)
        Me.txtSenhaDestino.MaxLength = 20
        Me.txtSenhaDestino.Name = "txtSenhaDestino"
        Me.txtSenhaDestino.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaDestino.Size = New System.Drawing.Size(113, 20)
        Me.txtSenhaDestino.TabIndex = 5
        Me.txtSenhaDestino.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'lblSenhaDestino
        '
        Me.lblSenhaDestino.AutoSize = True
        Me.lblSenhaDestino.Location = New System.Drawing.Point(6, 74)
        Me.lblSenhaDestino.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblSenhaDestino.Name = "lblSenhaDestino"
        Me.lblSenhaDestino.Size = New System.Drawing.Size(41, 14)
        Me.lblSenhaDestino.TabIndex = 4
        Me.lblSenhaDestino.Text = "Senha:"
        '
        'txtUsuarioDestino
        '
        Me.txtUsuarioDestino.Location = New System.Drawing.Point(133, 45)
        Me.txtUsuarioDestino.Name = "txtUsuarioDestino"
        Me.txtUsuarioDestino.Size = New System.Drawing.Size(113, 20)
        Me.txtUsuarioDestino.TabIndex = 3
        '
        'lblUsuarioDestino
        '
        Me.lblUsuarioDestino.AutoSize = True
        Me.lblUsuarioDestino.Location = New System.Drawing.Point(6, 48)
        Me.lblUsuarioDestino.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblUsuarioDestino.Name = "lblUsuarioDestino"
        Me.lblUsuarioDestino.Size = New System.Drawing.Size(47, 14)
        Me.lblUsuarioDestino.TabIndex = 2
        Me.lblUsuarioDestino.Text = "Usuário:"
        '
        'txtNomeServidorDestino
        '
        Me.txtNomeServidorDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeServidorDestino.Location = New System.Drawing.Point(133, 19)
        Me.txtNomeServidorDestino.Name = "txtNomeServidorDestino"
        Me.txtNomeServidorDestino.Size = New System.Drawing.Size(250, 20)
        Me.txtNomeServidorDestino.TabIndex = 1
        '
        'lblNomeServidorDestino
        '
        Me.lblNomeServidorDestino.AutoSize = True
        Me.lblNomeServidorDestino.Location = New System.Drawing.Point(6, 22)
        Me.lblNomeServidorDestino.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblNomeServidorDestino.Name = "lblNomeServidorDestino"
        Me.lblNomeServidorDestino.Size = New System.Drawing.Size(96, 14)
        Me.lblNomeServidorDestino.TabIndex = 0
        Me.lblNomeServidorDestino.Text = "Nome do Servidor:"
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(410, 418)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 5
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
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(409, 9)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(496, 426)
        Me.grdListagem.TabIndex = 4
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnExecutar)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 384)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(392, 51)
        Me.grpControl.TabIndex = 3
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnExecutar
        '
        Me.btnExecutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecutar.Image = Global.INTERACTI.My.Resources.run
        Me.btnExecutar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExecutar.Location = New System.Drawing.Point(197, 17)
        Me.btnExecutar.Name = "btnExecutar"
        Me.btnExecutar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExecutar.Size = New System.Drawing.Size(90, 23)
        Me.btnExecutar.TabIndex = 0
        Me.btnExecutar.Text = "Executar"
        Me.btnExecutar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(293, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(90, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpOrigem
        '
        Me.grpOrigem.BackColor = System.Drawing.Color.Transparent
        Me.grpOrigem.Controls.Add(Me.txtBancoDadosOrigem)
        Me.grpOrigem.Controls.Add(Me.lblBancoDadosOrigem)
        Me.grpOrigem.Controls.Add(Me.txtSenhaOrigem)
        Me.grpOrigem.Controls.Add(Me.lblSenhaOrigem)
        Me.grpOrigem.Controls.Add(Me.txtUsuarioOrigem)
        Me.grpOrigem.Controls.Add(Me.lblUsuarioOrigem)
        Me.grpOrigem.Controls.Add(Me.txtNomeServidorOrigem)
        Me.grpOrigem.Controls.Add(Me.lblNomeServidorOrigem)
        Me.grpOrigem.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpOrigem.Location = New System.Drawing.Point(8, 3)
        Me.grpOrigem.Name = "grpOrigem"
        Me.grpOrigem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpOrigem.Size = New System.Drawing.Size(392, 127)
        Me.grpOrigem.TabIndex = 0
        Me.grpOrigem.Text = "Database Origem"
        Me.grpOrigem.VisualStyleManager = Me.vsmMain
        '
        'txtBancoDadosOrigem
        '
        Me.txtBancoDadosOrigem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBancoDadosOrigem.Location = New System.Drawing.Point(133, 97)
        Me.txtBancoDadosOrigem.Name = "txtBancoDadosOrigem"
        Me.txtBancoDadosOrigem.Size = New System.Drawing.Size(250, 20)
        Me.txtBancoDadosOrigem.TabIndex = 7
        '
        'lblBancoDadosOrigem
        '
        Me.lblBancoDadosOrigem.AutoSize = True
        Me.lblBancoDadosOrigem.Location = New System.Drawing.Point(6, 100)
        Me.lblBancoDadosOrigem.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblBancoDadosOrigem.Name = "lblBancoDadosOrigem"
        Me.lblBancoDadosOrigem.Size = New System.Drawing.Size(90, 14)
        Me.lblBancoDadosOrigem.TabIndex = 6
        Me.lblBancoDadosOrigem.Text = "Banco de Dados:"
        '
        'txtSenhaOrigem
        '
        Me.txtSenhaOrigem.Location = New System.Drawing.Point(133, 71)
        Me.txtSenhaOrigem.MaxLength = 20
        Me.txtSenhaOrigem.Name = "txtSenhaOrigem"
        Me.txtSenhaOrigem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaOrigem.Size = New System.Drawing.Size(113, 20)
        Me.txtSenhaOrigem.TabIndex = 5
        Me.txtSenhaOrigem.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005
        '
        'lblSenhaOrigem
        '
        Me.lblSenhaOrigem.AutoSize = True
        Me.lblSenhaOrigem.Location = New System.Drawing.Point(6, 74)
        Me.lblSenhaOrigem.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblSenhaOrigem.Name = "lblSenhaOrigem"
        Me.lblSenhaOrigem.Size = New System.Drawing.Size(41, 14)
        Me.lblSenhaOrigem.TabIndex = 4
        Me.lblSenhaOrigem.Text = "Senha:"
        '
        'txtUsuarioOrigem
        '
        Me.txtUsuarioOrigem.Location = New System.Drawing.Point(133, 45)
        Me.txtUsuarioOrigem.Name = "txtUsuarioOrigem"
        Me.txtUsuarioOrigem.Size = New System.Drawing.Size(113, 20)
        Me.txtUsuarioOrigem.TabIndex = 3
        '
        'lblUsuarioOrigem
        '
        Me.lblUsuarioOrigem.AutoSize = True
        Me.lblUsuarioOrigem.Location = New System.Drawing.Point(6, 48)
        Me.lblUsuarioOrigem.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblUsuarioOrigem.Name = "lblUsuarioOrigem"
        Me.lblUsuarioOrigem.Size = New System.Drawing.Size(47, 14)
        Me.lblUsuarioOrigem.TabIndex = 2
        Me.lblUsuarioOrigem.Text = "Usuário:"
        '
        'txtNomeServidorOrigem
        '
        Me.txtNomeServidorOrigem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeServidorOrigem.Location = New System.Drawing.Point(133, 19)
        Me.txtNomeServidorOrigem.Name = "txtNomeServidorOrigem"
        Me.txtNomeServidorOrigem.Size = New System.Drawing.Size(250, 20)
        Me.txtNomeServidorOrigem.TabIndex = 1
        '
        'lblNomeServidorOrigem
        '
        Me.lblNomeServidorOrigem.AutoSize = True
        Me.lblNomeServidorOrigem.Location = New System.Drawing.Point(6, 22)
        Me.lblNomeServidorOrigem.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblNomeServidorOrigem.Name = "lblNomeServidorOrigem"
        Me.lblNomeServidorOrigem.Size = New System.Drawing.Size(96, 14)
        Me.lblNomeServidorOrigem.TabIndex = 0
        Me.lblNomeServidorOrigem.Text = "Nome do Servidor:"
        '
        'ToolTip
        '
        Me.ToolTip.AutomaticDelay = 0
        Me.ToolTip.AutoPopDelay = 5000
        Me.ToolTip.InitialDelay = 0
        Me.ToolTip.ReshowDelay = 0
        Me.ToolTip.ShowAlways = True
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'usrAdmInteractiCompare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "usrAdmInteractiCompare"
        Me.Size = New System.Drawing.Size(915, 467)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpDestino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDestino.ResumeLayout(False)
        Me.grpDestino.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grpOrigem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOrigem.ResumeLayout(False)
        Me.grpOrigem.PerformLayout()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents grpOrigem As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnComparar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnExecutar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDestino As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtBancoDadosDestino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblBancoDadosDestino As System.Windows.Forms.Label
    Friend WithEvents txtSenhaDestino As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblSenhaDestino As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioDestino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblUsuarioDestino As System.Windows.Forms.Label
    Friend WithEvents txtNomeServidorDestino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNomeServidorDestino As System.Windows.Forms.Label
    Friend WithEvents txtBancoDadosOrigem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblBancoDadosOrigem As System.Windows.Forms.Label
    Friend WithEvents txtSenhaOrigem As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblSenhaOrigem As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioOrigem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblUsuarioOrigem As System.Windows.Forms.Label
    Friend WithEvents txtNomeServidorOrigem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNomeServidorOrigem As System.Windows.Forms.Label
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFiltro As System.Windows.Forms.Label
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button

End Class
