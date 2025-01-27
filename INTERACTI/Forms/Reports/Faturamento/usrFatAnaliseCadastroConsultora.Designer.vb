<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFatAnaliseCadastroConsultora
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFatAnaliseCadastroConsultora))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblLegendaRegraVenda = New System.Windows.Forms.Label()
        Me.picLegendaRegraVenda = New System.Windows.Forms.PictureBox()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnAtualizarSite = New Janus.Windows.EditControls.UIButton()
        Me.btnExcelListagem = New Janus.Windows.EditControls.UIButton()
        Me.btnImportarPlanilha = New Janus.Windows.EditControls.UIButton()
        Me.btnExportarExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtSetorFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigoConsultoraFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomeFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSemanaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblSemanaFiltro = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaRegraVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme2.Name = "Scheme"
        JanusColorScheme2.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme2.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme2)
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
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grpLegenda)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Análise de Cadastro"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.Label5)
        Me.grpLegenda.Controls.Add(Me.PictureBox2)
        Me.grpLegenda.Controls.Add(Me.Label4)
        Me.grpLegenda.Controls.Add(Me.PictureBox1)
        Me.grpLegenda.Controls.Add(Me.lblLegendaRegraVenda)
        Me.grpLegenda.Controls.Add(Me.picLegendaRegraVenda)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(261, 51)
        Me.grpLegenda.TabIndex = 94
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(198, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 14)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Aceito"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(179, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(13, 14)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(122, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 14)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Pendente"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Peru
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(103, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(13, 14)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'lblLegendaRegraVenda
        '
        Me.lblLegendaRegraVenda.AutoSize = True
        Me.lblLegendaRegraVenda.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaRegraVenda.Name = "lblLegendaRegraVenda"
        Me.lblLegendaRegraVenda.Size = New System.Drawing.Size(72, 14)
        Me.lblLegendaRegraVenda.TabIndex = 0
        Me.lblLegendaRegraVenda.Text = "Não Entregue"
        '
        'picLegendaRegraVenda
        '
        Me.picLegendaRegraVenda.BackColor = System.Drawing.Color.Black
        Me.picLegendaRegraVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaRegraVenda.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaRegraVenda.Name = "picLegendaRegraVenda"
        Me.picLegendaRegraVenda.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaRegraVenda.TabIndex = 16
        Me.picLegendaRegraVenda.TabStop = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(13, 463)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(44, 15)
        Me.btnConfigurarGrid.TabIndex = 92
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.DynamicFiltering = True
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.KeepRowSettings = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 87)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 393)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnAtualizarSite)
        Me.grpControl.Controls.Add(Me.btnExcelListagem)
        Me.grpControl.Controls.Add(Me.btnImportarPlanilha)
        Me.grpControl.Controls.Add(Me.btnExportarExcel)
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(275, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(715, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnAtualizarSite
        '
        Me.btnAtualizarSite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtualizarSite.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnAtualizarSite.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAtualizarSite.Location = New System.Drawing.Point(417, 17)
        Me.btnAtualizarSite.Name = "btnAtualizarSite"
        Me.btnAtualizarSite.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAtualizarSite.Size = New System.Drawing.Size(95, 23)
        Me.btnAtualizarSite.TabIndex = 7
        Me.btnAtualizarSite.Text = "Atualizar Site"
        Me.btnAtualizarSite.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcelListagem
        '
        Me.btnExcelListagem.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelListagem.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcelListagem.ImageSize = New System.Drawing.Size(13, 13)
        Me.btnExcelListagem.Location = New System.Drawing.Point(230, 17)
        Me.btnExcelListagem.Name = "btnExcelListagem"
        Me.btnExcelListagem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcelListagem.Size = New System.Drawing.Size(131, 23)
        Me.btnExcelListagem.TabIndex = 6
        Me.btnExcelListagem.Text = "Exportar Listagem"
        Me.btnExcelListagem.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImportarPlanilha
        '
        Me.btnImportarPlanilha.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnImportarPlanilha.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarPlanilha.ImageSize = New System.Drawing.Size(13, 13)
        Me.btnImportarPlanilha.Location = New System.Drawing.Point(118, 17)
        Me.btnImportarPlanilha.Name = "btnImportarPlanilha"
        Me.btnImportarPlanilha.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportarPlanilha.Size = New System.Drawing.Size(106, 23)
        Me.btnImportarPlanilha.TabIndex = 5
        Me.btnImportarPlanilha.Text = "Importar Planilha"
        Me.btnImportarPlanilha.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExportarExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExportarExcel.ImageSize = New System.Drawing.Size(13, 13)
        Me.btnExportarExcel.Location = New System.Drawing.Point(6, 17)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExportarExcel.Size = New System.Drawing.Size(106, 23)
        Me.btnExportarExcel.TabIndex = 4
        Me.btnExportarExcel.Text = "Exportar Planilha"
        Me.btnExportarExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.Location = New System.Drawing.Point(518, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 3
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(615, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtSetorFiltro)
        Me.grpFiltro.Controls.Add(Me.Label3)
        Me.grpFiltro.Controls.Add(Me.txtCodigoConsultoraFiltro)
        Me.grpFiltro.Controls.Add(Me.Label2)
        Me.grpFiltro.Controls.Add(Me.txtNomeFiltro)
        Me.grpFiltro.Controls.Add(Me.Label1)
        Me.grpFiltro.Controls.Add(Me.txtSemanaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblSemanaFiltro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 77)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtSetorFiltro
        '
        Me.txtSetorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSetorFiltro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSetorFiltro.Location = New System.Drawing.Point(723, 37)
        Me.txtSetorFiltro.MaxLength = 0
        Me.txtSetorFiltro.Name = "txtSetorFiltro"
        Me.txtSetorFiltro.Size = New System.Drawing.Size(141, 20)
        Me.txtSetorFiltro.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(720, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 14)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Setor:"
        '
        'txtCodigoConsultoraFiltro
        '
        Me.txtCodigoConsultoraFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoConsultoraFiltro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoConsultoraFiltro.Location = New System.Drawing.Point(569, 37)
        Me.txtCodigoConsultoraFiltro.MaxLength = 0
        Me.txtCodigoConsultoraFiltro.Name = "txtCodigoConsultoraFiltro"
        Me.txtCodigoConsultoraFiltro.Size = New System.Drawing.Size(148, 20)
        Me.txtCodigoConsultoraFiltro.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(566, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 14)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Codigo Consultora:"
        '
        'txtNomeFiltro
        '
        Me.txtNomeFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeFiltro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeFiltro.Location = New System.Drawing.Point(114, 37)
        Me.txtNomeFiltro.MaxLength = 0
        Me.txtNomeFiltro.Name = "txtNomeFiltro"
        Me.txtNomeFiltro.Size = New System.Drawing.Size(449, 20)
        Me.txtNomeFiltro.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 14)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nome:"
        '
        'txtSemanaFiltro
        '
        Me.txtSemanaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSemanaFiltro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSemanaFiltro.Location = New System.Drawing.Point(15, 37)
        Me.txtSemanaFiltro.Mask = "00/0000"
        Me.txtSemanaFiltro.MaxLength = 5
        Me.txtSemanaFiltro.Name = "txtSemanaFiltro"
        Me.txtSemanaFiltro.Size = New System.Drawing.Size(93, 20)
        Me.txtSemanaFiltro.TabIndex = 15
        Me.txtSemanaFiltro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 34)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 14
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblSemanaFiltro
        '
        Me.lblSemanaFiltro.AutoSize = True
        Me.lblSemanaFiltro.Location = New System.Drawing.Point(12, 20)
        Me.lblSemanaFiltro.Name = "lblSemanaFiltro"
        Me.lblSemanaFiltro.Size = New System.Drawing.Size(96, 14)
        Me.lblSemanaFiltro.TabIndex = 3
        Me.lblSemanaFiltro.Text = "Semana Cadastro:"
        '
        'usrFatAnaliseCadastroConsultora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFatAnaliseCadastroConsultora"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaRegraVenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblSemanaFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents txtNomeFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSemanaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtSetorFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoConsultoraFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaRegraVenda As System.Windows.Forms.Label
    Friend WithEvents picLegendaRegraVenda As System.Windows.Forms.PictureBox
    Friend WithEvents btnExportarExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnImportarPlanilha As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelListagem As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAtualizarSite As Janus.Windows.EditControls.UIButton

End Class
