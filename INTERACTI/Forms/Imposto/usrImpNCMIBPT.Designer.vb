<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrImpNCMIBPT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrImpNCMIBPT))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.grpArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        Me.lblLinhaInicio = New System.Windows.Forms.Label()
        Me.txtLinhaInicio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grdControlesEdicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDadosArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboEXTipi = New Janus.Windows.EditControls.UIComboBox()
        Me.lblEXTipi = New System.Windows.Forms.Label()
        Me.cboColunaVersao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaVersao = New System.Windows.Forms.Label()
        Me.cboColunaFonte = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaFonte = New System.Windows.Forms.Label()
        Me.cboColunaChave = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaChave = New System.Windows.Forms.Label()
        Me.cboColunaVigenciaTermino = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaVigenciaTermino = New System.Windows.Forms.Label()
        Me.cboColunaVigenciaInicio = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaVigenciaInicio = New System.Windows.Forms.Label()
        Me.cboColunaImpostoMunicipal = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaImpostoMunicipal = New System.Windows.Forms.Label()
        Me.cboColunaImpostoEstadual = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaImpostoEstadual = New System.Windows.Forms.Label()
        Me.cboColunaImpostoFederalImportado = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaImpostoFederalImportado = New System.Windows.Forms.Label()
        Me.lblColunaNCM = New System.Windows.Forms.Label()
        Me.cboColunaNCM = New Janus.Windows.EditControls.UIComboBox()
        Me.cboColunaImpostoFederalNacional = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColunaImpostoFederalNacional = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdControlesEdicao.SuspendLayout()
        CType(Me.grpDadosArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosArquivo.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(1000, 654)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnExcelGrid)
        Me.pagDados.Controls.Add(Me.btnAgruparGrid)
        Me.pagDados.Controls.Add(Me.grpArquivo)
        Me.pagDados.Controls.Add(Me.btnConfigurarGrid)
        Me.pagDados.Controls.Add(Me.grdListagem)
        Me.pagDados.Controls.Add(Me.grdControlesEdicao)
        Me.pagDados.Controls.Add(Me.grpDadosArquivo)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(998, 631)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "NCM - Nomenclatura Comum do Mercosul - Alíquota IBPT"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(328, 551)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 6
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(304, 551)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 5
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'grpArquivo
        '
        Me.grpArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpArquivo.Controls.Add(Me.txtArquivo)
        Me.grpArquivo.Controls.Add(Me.lblArquivo)
        Me.grpArquivo.Controls.Add(Me.btnArquivo)
        Me.grpArquivo.Controls.Add(Me.lblLinhaInicio)
        Me.grpArquivo.Controls.Add(Me.txtLinhaInicio)
        Me.grpArquivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpArquivo.Location = New System.Drawing.Point(8, 3)
        Me.grpArquivo.Name = "grpArquivo"
        Me.grpArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpArquivo.Size = New System.Drawing.Size(982, 64)
        Me.grpArquivo.TabIndex = 0
        Me.grpArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpArquivo.VisualStyleManager = Me.vsmMain
        '
        'txtArquivo
        '
        Me.txtArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivo.BackColor = System.Drawing.SystemColors.Info
        Me.txtArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArquivo.Location = New System.Drawing.Point(131, 34)
        Me.txtArquivo.MaxLength = 50
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(820, 20)
        Me.txtArquivo.TabIndex = 9
        Me.txtArquivo.TabStop = False
        '
        'lblArquivo
        '
        Me.lblArquivo.AutoSize = True
        Me.lblArquivo.Location = New System.Drawing.Point(128, 17)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(48, 14)
        Me.lblArquivo.TabIndex = 8
        Me.lblArquivo.Text = "Arquivo:"
        '
        'btnArquivo
        '
        Me.btnArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnArquivo.Location = New System.Drawing.Point(950, 34)
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivo.Size = New System.Drawing.Size(23, 20)
        Me.btnArquivo.TabIndex = 10
        Me.btnArquivo.Text = "..."
        Me.btnArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblLinhaInicio
        '
        Me.lblLinhaInicio.AutoSize = True
        Me.lblLinhaInicio.Location = New System.Drawing.Point(6, 17)
        Me.lblLinhaInicio.Name = "lblLinhaInicio"
        Me.lblLinhaInicio.Size = New System.Drawing.Size(63, 14)
        Me.lblLinhaInicio.TabIndex = 3
        Me.lblLinhaInicio.Text = "Linha Início:"
        '
        'txtLinhaInicio
        '
        Me.txtLinhaInicio.DecimalDigits = 0
        Me.txtLinhaInicio.Location = New System.Drawing.Point(9, 34)
        Me.txtLinhaInicio.Name = "txtLinhaInicio"
        Me.txtLinhaInicio.Size = New System.Drawing.Size(116, 20)
        Me.txtLinhaInicio.TabIndex = 2
        Me.txtLinhaInicio.Text = "0"
        Me.txtLinhaInicio.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(280, 551)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 4
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Location = New System.Drawing.Point(279, 76)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(711, 492)
        Me.grdListagem.TabIndex = 3
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grdControlesEdicao
        '
        Me.grdControlesEdicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdControlesEdicao.BackColor = System.Drawing.Color.Transparent
        Me.grdControlesEdicao.Controls.Add(Me.btnNovo)
        Me.grdControlesEdicao.Controls.Add(Me.btnSair)
        Me.grdControlesEdicao.Controls.Add(Me.btnSalvar)
        Me.grdControlesEdicao.Location = New System.Drawing.Point(8, 571)
        Me.grdControlesEdicao.Name = "grdControlesEdicao"
        Me.grdControlesEdicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grdControlesEdicao.Size = New System.Drawing.Size(982, 51)
        Me.grdControlesEdicao.TabIndex = 7
        Me.grdControlesEdicao.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(688, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(882, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(785, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDadosArquivo
        '
        Me.grpDadosArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpDadosArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosArquivo.Controls.Add(Me.cboEXTipi)
        Me.grpDadosArquivo.Controls.Add(Me.lblEXTipi)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaVersao)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaVersao)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaFonte)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaFonte)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaChave)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaChave)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaVigenciaTermino)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaVigenciaTermino)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaVigenciaInicio)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaVigenciaInicio)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaImpostoMunicipal)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaImpostoMunicipal)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaImpostoEstadual)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaImpostoEstadual)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaImpostoFederalImportado)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaImpostoFederalImportado)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaNCM)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaNCM)
        Me.grpDadosArquivo.Controls.Add(Me.cboColunaImpostoFederalNacional)
        Me.grpDadosArquivo.Controls.Add(Me.lblColunaImpostoFederalNacional)
        Me.grpDadosArquivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosArquivo.Location = New System.Drawing.Point(8, 70)
        Me.grpDadosArquivo.Name = "grpDadosArquivo"
        Me.grpDadosArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosArquivo.Size = New System.Drawing.Size(262, 498)
        Me.grpDadosArquivo.TabIndex = 8
        Me.grpDadosArquivo.Text = "Configuração da Planilha Excel"
        Me.grpDadosArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosArquivo.VisualStyleManager = Me.vsmMain
        '
        'cboEXTipi
        '
        Me.cboEXTipi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboEXTipi.AutoSize = False
        Me.cboEXTipi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEXTipi.Location = New System.Drawing.Point(138, 45)
        Me.cboEXTipi.Name = "cboEXTipi"
        Me.cboEXTipi.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboEXTipi.Size = New System.Drawing.Size(116, 20)
        Me.cboEXTipi.TabIndex = 3
        '
        'lblEXTipi
        '
        Me.lblEXTipi.AutoSize = True
        Me.lblEXTipi.Location = New System.Drawing.Point(6, 48)
        Me.lblEXTipi.Name = "lblEXTipi"
        Me.lblEXTipi.Size = New System.Drawing.Size(23, 14)
        Me.lblEXTipi.TabIndex = 2
        Me.lblEXTipi.Text = "EX:"
        '
        'cboColunaVersao
        '
        Me.cboColunaVersao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboColunaVersao.AutoSize = False
        Me.cboColunaVersao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaVersao.Location = New System.Drawing.Point(138, 253)
        Me.cboColunaVersao.Name = "cboColunaVersao"
        Me.cboColunaVersao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaVersao.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaVersao.TabIndex = 19
        '
        'lblColunaVersao
        '
        Me.lblColunaVersao.AutoSize = True
        Me.lblColunaVersao.Location = New System.Drawing.Point(6, 256)
        Me.lblColunaVersao.Name = "lblColunaVersao"
        Me.lblColunaVersao.Size = New System.Drawing.Size(45, 14)
        Me.lblColunaVersao.TabIndex = 18
        Me.lblColunaVersao.Text = "Versão:"
        '
        'cboColunaFonte
        '
        Me.cboColunaFonte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboColunaFonte.AutoSize = False
        Me.cboColunaFonte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaFonte.Location = New System.Drawing.Point(138, 279)
        Me.cboColunaFonte.Name = "cboColunaFonte"
        Me.cboColunaFonte.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaFonte.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaFonte.TabIndex = 21
        '
        'lblColunaFonte
        '
        Me.lblColunaFonte.AutoSize = True
        Me.lblColunaFonte.Location = New System.Drawing.Point(6, 282)
        Me.lblColunaFonte.Name = "lblColunaFonte"
        Me.lblColunaFonte.Size = New System.Drawing.Size(37, 14)
        Me.lblColunaFonte.TabIndex = 20
        Me.lblColunaFonte.Text = "Fonte:"
        '
        'cboColunaChave
        '
        Me.cboColunaChave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboColunaChave.AutoSize = False
        Me.cboColunaChave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaChave.Location = New System.Drawing.Point(138, 227)
        Me.cboColunaChave.Name = "cboColunaChave"
        Me.cboColunaChave.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaChave.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaChave.TabIndex = 17
        '
        'lblColunaChave
        '
        Me.lblColunaChave.AutoSize = True
        Me.lblColunaChave.Location = New System.Drawing.Point(6, 230)
        Me.lblColunaChave.Name = "lblColunaChave"
        Me.lblColunaChave.Size = New System.Drawing.Size(41, 14)
        Me.lblColunaChave.TabIndex = 16
        Me.lblColunaChave.Text = "Chave:"
        '
        'cboColunaVigenciaTermino
        '
        Me.cboColunaVigenciaTermino.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboColunaVigenciaTermino.AutoSize = False
        Me.cboColunaVigenciaTermino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaVigenciaTermino.Location = New System.Drawing.Point(138, 201)
        Me.cboColunaVigenciaTermino.Name = "cboColunaVigenciaTermino"
        Me.cboColunaVigenciaTermino.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaVigenciaTermino.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaVigenciaTermino.TabIndex = 15
        '
        'lblColunaVigenciaTermino
        '
        Me.lblColunaVigenciaTermino.AutoSize = True
        Me.lblColunaVigenciaTermino.Location = New System.Drawing.Point(6, 204)
        Me.lblColunaVigenciaTermino.Name = "lblColunaVigenciaTermino"
        Me.lblColunaVigenciaTermino.Size = New System.Drawing.Size(93, 14)
        Me.lblColunaVigenciaTermino.TabIndex = 14
        Me.lblColunaVigenciaTermino.Text = "Vigência Término:"
        '
        'cboColunaVigenciaInicio
        '
        Me.cboColunaVigenciaInicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboColunaVigenciaInicio.AutoSize = False
        Me.cboColunaVigenciaInicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaVigenciaInicio.Location = New System.Drawing.Point(138, 175)
        Me.cboColunaVigenciaInicio.Name = "cboColunaVigenciaInicio"
        Me.cboColunaVigenciaInicio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaVigenciaInicio.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaVigenciaInicio.TabIndex = 13
        '
        'lblColunaVigenciaInicio
        '
        Me.lblColunaVigenciaInicio.AutoSize = True
        Me.lblColunaVigenciaInicio.Location = New System.Drawing.Point(6, 178)
        Me.lblColunaVigenciaInicio.Name = "lblColunaVigenciaInicio"
        Me.lblColunaVigenciaInicio.Size = New System.Drawing.Size(79, 14)
        Me.lblColunaVigenciaInicio.TabIndex = 12
        Me.lblColunaVigenciaInicio.Text = "Vigência Início:"
        '
        'cboColunaImpostoMunicipal
        '
        Me.cboColunaImpostoMunicipal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboColunaImpostoMunicipal.AutoSize = False
        Me.cboColunaImpostoMunicipal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaImpostoMunicipal.Location = New System.Drawing.Point(138, 149)
        Me.cboColunaImpostoMunicipal.Name = "cboColunaImpostoMunicipal"
        Me.cboColunaImpostoMunicipal.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaImpostoMunicipal.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaImpostoMunicipal.TabIndex = 11
        '
        'lblColunaImpostoMunicipal
        '
        Me.lblColunaImpostoMunicipal.AutoSize = True
        Me.lblColunaImpostoMunicipal.Location = New System.Drawing.Point(6, 152)
        Me.lblColunaImpostoMunicipal.Name = "lblColunaImpostoMunicipal"
        Me.lblColunaImpostoMunicipal.Size = New System.Drawing.Size(54, 14)
        Me.lblColunaImpostoMunicipal.TabIndex = 10
        Me.lblColunaImpostoMunicipal.Text = "Municipal:"
        '
        'cboColunaImpostoEstadual
        '
        Me.cboColunaImpostoEstadual.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboColunaImpostoEstadual.AutoSize = False
        Me.cboColunaImpostoEstadual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaImpostoEstadual.Location = New System.Drawing.Point(138, 123)
        Me.cboColunaImpostoEstadual.Name = "cboColunaImpostoEstadual"
        Me.cboColunaImpostoEstadual.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaImpostoEstadual.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaImpostoEstadual.TabIndex = 9
        '
        'lblColunaImpostoEstadual
        '
        Me.lblColunaImpostoEstadual.AutoSize = True
        Me.lblColunaImpostoEstadual.Location = New System.Drawing.Point(6, 126)
        Me.lblColunaImpostoEstadual.Name = "lblColunaImpostoEstadual"
        Me.lblColunaImpostoEstadual.Size = New System.Drawing.Size(51, 14)
        Me.lblColunaImpostoEstadual.TabIndex = 8
        Me.lblColunaImpostoEstadual.Text = "Estadual:"
        '
        'cboColunaImpostoFederalImportado
        '
        Me.cboColunaImpostoFederalImportado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboColunaImpostoFederalImportado.AutoSize = False
        Me.cboColunaImpostoFederalImportado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaImpostoFederalImportado.Location = New System.Drawing.Point(138, 97)
        Me.cboColunaImpostoFederalImportado.Name = "cboColunaImpostoFederalImportado"
        Me.cboColunaImpostoFederalImportado.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaImpostoFederalImportado.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaImpostoFederalImportado.TabIndex = 7
        '
        'lblColunaImpostoFederalImportado
        '
        Me.lblColunaImpostoFederalImportado.AutoSize = True
        Me.lblColunaImpostoFederalImportado.Location = New System.Drawing.Point(6, 100)
        Me.lblColunaImpostoFederalImportado.Name = "lblColunaImpostoFederalImportado"
        Me.lblColunaImpostoFederalImportado.Size = New System.Drawing.Size(102, 14)
        Me.lblColunaImpostoFederalImportado.TabIndex = 6
        Me.lblColunaImpostoFederalImportado.Text = "Importados Federal:"
        '
        'lblColunaNCM
        '
        Me.lblColunaNCM.AutoSize = True
        Me.lblColunaNCM.Location = New System.Drawing.Point(6, 22)
        Me.lblColunaNCM.Name = "lblColunaNCM"
        Me.lblColunaNCM.Size = New System.Drawing.Size(68, 14)
        Me.lblColunaNCM.TabIndex = 0
        Me.lblColunaNCM.Text = "Código NCM:"
        '
        'cboColunaNCM
        '
        Me.cboColunaNCM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboColunaNCM.AutoSize = False
        Me.cboColunaNCM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaNCM.Location = New System.Drawing.Point(138, 19)
        Me.cboColunaNCM.Name = "cboColunaNCM"
        Me.cboColunaNCM.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaNCM.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaNCM.TabIndex = 1
        '
        'cboColunaImpostoFederalNacional
        '
        Me.cboColunaImpostoFederalNacional.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboColunaImpostoFederalNacional.AutoSize = False
        Me.cboColunaImpostoFederalNacional.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColunaImpostoFederalNacional.Location = New System.Drawing.Point(138, 71)
        Me.cboColunaImpostoFederalNacional.Name = "cboColunaImpostoFederalNacional"
        Me.cboColunaImpostoFederalNacional.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColunaImpostoFederalNacional.Size = New System.Drawing.Size(116, 20)
        Me.cboColunaImpostoFederalNacional.TabIndex = 5
        '
        'lblColunaImpostoFederalNacional
        '
        Me.lblColunaImpostoFederalNacional.AutoSize = True
        Me.lblColunaImpostoFederalNacional.Location = New System.Drawing.Point(6, 74)
        Me.lblColunaImpostoFederalNacional.Name = "lblColunaImpostoFederalNacional"
        Me.lblColunaImpostoFederalNacional.Size = New System.Drawing.Size(90, 14)
        Me.lblColunaImpostoFederalNacional.TabIndex = 4
        Me.lblColunaImpostoFederalNacional.Text = "Nacional Federal:"
        '
        'usrImpNCMIBPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrImpNCMIBPT"
        Me.Size = New System.Drawing.Size(1000, 654)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdControlesEdicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdControlesEdicao.ResumeLayout(False)
        CType(Me.grpDadosArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosArquivo.ResumeLayout(False)
        Me.grpDadosArquivo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdControlesEdicao As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Private WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grpArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents lblLinhaInicio As System.Windows.Forms.Label
    Friend WithEvents txtLinhaInicio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents grpDadosArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboColunaVersao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaVersao As System.Windows.Forms.Label
    Friend WithEvents cboColunaFonte As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaFonte As System.Windows.Forms.Label
    Friend WithEvents cboColunaChave As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaChave As System.Windows.Forms.Label
    Friend WithEvents cboColunaVigenciaTermino As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaVigenciaTermino As System.Windows.Forms.Label
    Friend WithEvents cboColunaVigenciaInicio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaVigenciaInicio As System.Windows.Forms.Label
    Friend WithEvents cboColunaImpostoMunicipal As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaImpostoMunicipal As System.Windows.Forms.Label
    Friend WithEvents cboColunaImpostoEstadual As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaImpostoEstadual As System.Windows.Forms.Label
    Friend WithEvents cboColunaImpostoFederalImportado As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaImpostoFederalImportado As System.Windows.Forms.Label
    Friend WithEvents lblColunaNCM As System.Windows.Forms.Label
    Friend WithEvents cboColunaNCM As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboColunaImpostoFederalNacional As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColunaImpostoFederalNacional As System.Windows.Forms.Label
    Friend WithEvents cboEXTipi As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblEXTipi As System.Windows.Forms.Label

End Class
