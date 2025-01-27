<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEmissaoItemImportar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEmissaoItemImportar))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.ofaMain = New Janus.Windows.Ribbon.OfficeFormAdorner(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpCaminho = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboCFOP = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCFOP = New System.Windows.Forms.Label()
        Me.txtPlanilha = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblPlanilha = New System.Windows.Forms.Label()
        Me.btnProcurar = New Janus.Windows.EditControls.UIButton()
        Me.btnCarregarPlanilha = New Janus.Windows.EditControls.UIButton()
        Me.txtCaminhoPlanilha = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblCaminhoPlaninha = New System.Windows.Forms.Label()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControleDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImportar = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltarDados = New Janus.Windows.EditControls.UIButton()
        Me.pagTributos = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabTributo = New Janus.Windows.UI.Tab.UITab()
        Me.pagICMS = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpICMSST = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtIVA = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.txtAliquotaICMSST = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaICMSST = New System.Windows.Forms.Label()
        Me.txtPorcentagemReducaoBCICMSST = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPorcentagemReducaoBCICMSST = New System.Windows.Forms.Label()
        Me.grpSituacaoTributariaICMS = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboSituacaoTributariaICMS = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSituacaoTributariaICMS = New System.Windows.Forms.Label()
        Me.txtDescricaoSituacaoTributariaICMS = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblDescricaoSituacaoTributariaICMS = New System.Windows.Forms.Label()
        Me.grpICMS = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtAliquotaICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaICMS = New System.Windows.Forms.Label()
        Me.txtPorcentagemReducaoBCICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPorcentagemReducaoBCICMS = New System.Windows.Forms.Label()
        Me.pagIPI = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpValoresIPI = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtAliquotaIPI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaIPI = New System.Windows.Forms.Label()
        Me.grpSituacaoTributariaIPI = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboSituacaoTributariaIPI = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSituacaoTributariaIPI = New System.Windows.Forms.Label()
        Me.txtDescricaoSituacaoTributariaIPI = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblDescricaoSituacaoTributariaIPI = New System.Windows.Forms.Label()
        Me.pagPIS = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpPISST = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtAliquotaPISST = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaPISST = New System.Windows.Forms.Label()
        Me.grpPIS = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtAliquotaPIS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaPIS = New System.Windows.Forms.Label()
        Me.grpSituacaoTributariaPIS = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboSituacaoTributariaPIS = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSituacaoTributariaPIS = New System.Windows.Forms.Label()
        Me.txtDescricaoSituacaoTributariaPIS = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblDescricaoSituacaoTributariaPIS = New System.Windows.Forms.Label()
        Me.pagCOFINS = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpCOFINSST = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtAliquotaCOFINSST = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaCOFINSST = New System.Windows.Forms.Label()
        Me.grpCOFINS = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtAliquotaCOFINS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaCOFINS = New System.Windows.Forms.Label()
        Me.grpSituacaoTributariaCOFINS = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboSituacaoTributariaCOFINS = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSituacaoTributariaCOFINS = New System.Windows.Forms.Label()
        Me.txtDescricaoSituacaoTributariaCOFINS = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblDescricaoSituacaoTributariaCOFINS = New System.Windows.Forms.Label()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImportar2 = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltarTributos = New Janus.Windows.EditControls.UIButton()
        Me.pagDeclaracaoImportacao = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox17 = New Janus.Windows.EditControls.UIGroupBox()
        Me.UiButton3 = New Janus.Windows.EditControls.UIButton()
        Me.UiButton4 = New Janus.Windows.EditControls.UIButton()
        CType(Me.ofaMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpCaminho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCaminho.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControleDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleDados.SuspendLayout()
        Me.pagTributos.SuspendLayout()
        CType(Me.tabTributo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTributo.SuspendLayout()
        Me.pagICMS.SuspendLayout()
        CType(Me.grpICMSST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpICMSST.SuspendLayout()
        CType(Me.grpSituacaoTributariaICMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSituacaoTributariaICMS.SuspendLayout()
        CType(Me.grpICMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpICMS.SuspendLayout()
        Me.pagIPI.SuspendLayout()
        CType(Me.grpValoresIPI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpValoresIPI.SuspendLayout()
        CType(Me.grpSituacaoTributariaIPI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSituacaoTributariaIPI.SuspendLayout()
        Me.pagPIS.SuspendLayout()
        CType(Me.grpPISST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPISST.SuspendLayout()
        CType(Me.grpPIS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPIS.SuspendLayout()
        CType(Me.grpSituacaoTributariaPIS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSituacaoTributariaPIS.SuspendLayout()
        Me.pagCOFINS.SuspendLayout()
        CType(Me.grpCOFINSST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCOFINSST.SuspendLayout()
        CType(Me.grpCOFINS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCOFINS.SuspendLayout()
        CType(Me.grpSituacaoTributariaCOFINS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSituacaoTributariaCOFINS.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox17.SuspendLayout()
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
        'ofaMain
        '
        Me.ofaMain.Form = Me
        Me.ofaMain.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Silver
        Me.ofaMain.Office2007CustomColor = System.Drawing.Color.Empty
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(7, 5)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(835, 388)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados, Me.pagTributos, Me.pagDeclaracaoImportacao})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pagDados.Controls.Add(Me.grpCaminho)
        Me.pagDados.Controls.Add(Me.grdListagem)
        Me.pagDados.Controls.Add(Me.grpControleDados)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(833, 365)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados"
        '
        'grpCaminho
        '
        Me.grpCaminho.BackColor = System.Drawing.Color.Transparent
        Me.grpCaminho.Controls.Add(Me.cboCFOP)
        Me.grpCaminho.Controls.Add(Me.lblCFOP)
        Me.grpCaminho.Controls.Add(Me.txtPlanilha)
        Me.grpCaminho.Controls.Add(Me.lblPlanilha)
        Me.grpCaminho.Controls.Add(Me.btnProcurar)
        Me.grpCaminho.Controls.Add(Me.btnCarregarPlanilha)
        Me.grpCaminho.Controls.Add(Me.txtCaminhoPlanilha)
        Me.grpCaminho.Controls.Add(Me.lblCaminhoPlaninha)
        Me.grpCaminho.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpCaminho.Location = New System.Drawing.Point(8, 5)
        Me.grpCaminho.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpCaminho.Name = "grpCaminho"
        Me.grpCaminho.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCaminho.Size = New System.Drawing.Size(753, 99)
        Me.grpCaminho.TabIndex = 4
        Me.grpCaminho.VisualStyleManager = Me.vsmMain
        '
        'cboCFOP
        '
        Me.cboCFOP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCFOP.AutoSize = False
        Me.cboCFOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCFOP.Location = New System.Drawing.Point(9, 68)
        Me.cboCFOP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCFOP.Name = "cboCFOP"
        Me.cboCFOP.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCFOP.Size = New System.Drawing.Size(176, 20)
        Me.cboCFOP.TabIndex = 12
        '
        'lblCFOP
        '
        Me.lblCFOP.AutoSize = True
        Me.lblCFOP.BackColor = System.Drawing.Color.Transparent
        Me.lblCFOP.Location = New System.Drawing.Point(6, 50)
        Me.lblCFOP.Name = "lblCFOP"
        Me.lblCFOP.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOP.TabIndex = 11
        Me.lblCFOP.Text = "CFOP:"
        '
        'txtPlanilha
        '
        Me.txtPlanilha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlanilha.Location = New System.Drawing.Point(516, 28)
        Me.txtPlanilha.MaxLength = 50
        Me.txtPlanilha.Name = "txtPlanilha"
        Me.txtPlanilha.Size = New System.Drawing.Size(109, 20)
        Me.txtPlanilha.TabIndex = 10
        Me.txtPlanilha.Text = "PLAN1"
        '
        'lblPlanilha
        '
        Me.lblPlanilha.AutoSize = True
        Me.lblPlanilha.Location = New System.Drawing.Point(512, 11)
        Me.lblPlanilha.Name = "lblPlanilha"
        Me.lblPlanilha.Size = New System.Drawing.Size(46, 14)
        Me.lblPlanilha.TabIndex = 9
        Me.lblPlanilha.Text = "Planilha:"
        '
        'btnProcurar
        '
        Me.btnProcurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnProcurar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnProcurar.Location = New System.Drawing.Point(487, 28)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnProcurar.Size = New System.Drawing.Size(23, 20)
        Me.btnProcurar.TabIndex = 8
        Me.btnProcurar.Text = "..."
        Me.btnProcurar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCarregarPlanilha
        '
        Me.btnCarregarPlanilha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCarregarPlanilha.Image = Global.SysACTi.My.Resources.Resources.importar
        Me.btnCarregarPlanilha.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCarregarPlanilha.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnCarregarPlanilha.Location = New System.Drawing.Point(631, 25)
        Me.btnCarregarPlanilha.Name = "btnCarregarPlanilha"
        Me.btnCarregarPlanilha.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCarregarPlanilha.Size = New System.Drawing.Size(113, 23)
        Me.btnCarregarPlanilha.TabIndex = 7
        Me.btnCarregarPlanilha.Text = "Carregar Planilha"
        Me.btnCarregarPlanilha.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtCaminhoPlanilha
        '
        Me.txtCaminhoPlanilha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCaminhoPlanilha.Location = New System.Drawing.Point(9, 28)
        Me.txtCaminhoPlanilha.MaxLength = 0
        Me.txtCaminhoPlanilha.Name = "txtCaminhoPlanilha"
        Me.txtCaminhoPlanilha.Size = New System.Drawing.Size(481, 20)
        Me.txtCaminhoPlanilha.TabIndex = 6
        '
        'lblCaminhoPlaninha
        '
        Me.lblCaminhoPlaninha.AutoSize = True
        Me.lblCaminhoPlaninha.BackColor = System.Drawing.Color.Transparent
        Me.lblCaminhoPlaninha.Location = New System.Drawing.Point(6, 11)
        Me.lblCaminhoPlaninha.Name = "lblCaminhoPlaninha"
        Me.lblCaminhoPlaninha.Size = New System.Drawing.Size(90, 14)
        Me.lblCaminhoPlaninha.TabIndex = 0
        Me.lblCaminhoPlaninha.Text = "Caminho Planilha:"
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.BoundMode = Janus.Windows.GridEX.BoundMode.Unbound
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(8, 111)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(753, 186)
        Me.grdListagem.TabIndex = 3
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControleDados
        '
        Me.grpControleDados.BackColor = System.Drawing.Color.Transparent
        Me.grpControleDados.Controls.Add(Me.btnImportar)
        Me.grpControleDados.Controls.Add(Me.btnVoltarDados)
        Me.grpControleDados.Location = New System.Drawing.Point(8, 303)
        Me.grpControleDados.Name = "grpControleDados"
        Me.grpControleDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleDados.Size = New System.Drawing.Size(753, 51)
        Me.grpControleDados.TabIndex = 1
        Me.grpControleDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControleDados.VisualStyleManager = Me.vsmMain
        '
        'btnImportar
        '
        Me.btnImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportar.Image = Global.SysACTi.My.Resources.Resources.aprovar
        Me.btnImportar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnImportar.Location = New System.Drawing.Point(556, 17)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportar.Size = New System.Drawing.Size(91, 23)
        Me.btnImportar.TabIndex = 0
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltarDados
        '
        Me.btnVoltarDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltarDados.Image = Global.SysACTi.My.Resources.Resources.voltar
        Me.btnVoltarDados.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltarDados.Location = New System.Drawing.Point(653, 17)
        Me.btnVoltarDados.Name = "btnVoltarDados"
        Me.btnVoltarDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltarDados.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltarDados.TabIndex = 1
        Me.btnVoltarDados.Text = "Voltar"
        Me.btnVoltarDados.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagTributos
        '
        Me.pagTributos.Controls.Add(Me.tabTributo)
        Me.pagTributos.Controls.Add(Me.UiGroupBox1)
        Me.pagTributos.Key = "pagTributos"
        Me.pagTributos.Location = New System.Drawing.Point(1, 22)
        Me.pagTributos.Name = "pagTributos"
        Me.pagTributos.Size = New System.Drawing.Size(823, 365)
        Me.pagTributos.TabStop = True
        Me.pagTributos.Text = "Tributos"
        '
        'tabTributo
        '
        Me.tabTributo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabTributo.BackColor = System.Drawing.Color.Transparent
        Me.tabTributo.FocusOnClick = False
        Me.tabTributo.Location = New System.Drawing.Point(8, 7)
        Me.tabTributo.Name = "tabTributo"
        Me.tabTributo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabTributo.Size = New System.Drawing.Size(803, 293)
        Me.tabTributo.TabIndex = 1
        Me.tabTributo.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagICMS, Me.pagIPI, Me.pagPIS, Me.pagCOFINS})
        Me.tabTributo.TabStop = False
        Me.tabTributo.VisualStyleManager = Me.vsmMain
        '
        'pagICMS
        '
        Me.pagICMS.Controls.Add(Me.grpICMSST)
        Me.pagICMS.Controls.Add(Me.grpSituacaoTributariaICMS)
        Me.pagICMS.Controls.Add(Me.grpICMS)
        Me.pagICMS.Key = "pagICMS"
        Me.pagICMS.Location = New System.Drawing.Point(1, 22)
        Me.pagICMS.Name = "pagICMS"
        Me.pagICMS.Size = New System.Drawing.Size(801, 270)
        Me.pagICMS.TabStop = True
        Me.pagICMS.Text = "ICMS"
        '
        'grpICMSST
        '
        Me.grpICMSST.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpICMSST.BackColor = System.Drawing.Color.Transparent
        Me.grpICMSST.Controls.Add(Me.txtIVA)
        Me.grpICMSST.Controls.Add(Me.lblIVA)
        Me.grpICMSST.Controls.Add(Me.txtAliquotaICMSST)
        Me.grpICMSST.Controls.Add(Me.lblAliquotaICMSST)
        Me.grpICMSST.Controls.Add(Me.txtPorcentagemReducaoBCICMSST)
        Me.grpICMSST.Controls.Add(Me.lblPorcentagemReducaoBCICMSST)
        Me.grpICMSST.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpICMSST.Location = New System.Drawing.Point(8, 143)
        Me.grpICMSST.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpICMSST.Name = "grpICMSST"
        Me.grpICMSST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpICMSST.Size = New System.Drawing.Size(785, 67)
        Me.grpICMSST.TabIndex = 16
        Me.grpICMSST.Text = "ICMS ST"
        Me.grpICMSST.VisualStyleManager = Me.vsmMain
        '
        'txtIVA
        '
        Me.txtIVA.Enabled = False
        Me.txtIVA.Location = New System.Drawing.Point(9, 37)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(117, 20)
        Me.txtIVA.TabIndex = 36
        Me.txtIVA.Tag = "|10|30|70|90|"
        Me.txtIVA.Text = "0,00"
        Me.txtIVA.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Location = New System.Drawing.Point(6, 20)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(27, 14)
        Me.lblIVA.TabIndex = 35
        Me.lblIVA.Text = "IVA:"
        '
        'txtAliquotaICMSST
        '
        Me.txtAliquotaICMSST.Enabled = False
        Me.txtAliquotaICMSST.Location = New System.Drawing.Point(255, 37)
        Me.txtAliquotaICMSST.Name = "txtAliquotaICMSST"
        Me.txtAliquotaICMSST.Size = New System.Drawing.Size(117, 20)
        Me.txtAliquotaICMSST.TabIndex = 32
        Me.txtAliquotaICMSST.Tag = "|10|30|70|90|"
        Me.txtAliquotaICMSST.Text = "0,00"
        Me.txtAliquotaICMSST.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaICMSST
        '
        Me.lblAliquotaICMSST.AutoSize = True
        Me.lblAliquotaICMSST.Location = New System.Drawing.Point(252, 20)
        Me.lblAliquotaICMSST.Name = "lblAliquotaICMSST"
        Me.lblAliquotaICMSST.Size = New System.Drawing.Size(91, 14)
        Me.lblAliquotaICMSST.TabIndex = 31
        Me.lblAliquotaICMSST.Text = "Alíquota ICMS ST:"
        '
        'txtPorcentagemReducaoBCICMSST
        '
        Me.txtPorcentagemReducaoBCICMSST.Enabled = False
        Me.txtPorcentagemReducaoBCICMSST.Location = New System.Drawing.Point(132, 37)
        Me.txtPorcentagemReducaoBCICMSST.Name = "txtPorcentagemReducaoBCICMSST"
        Me.txtPorcentagemReducaoBCICMSST.Size = New System.Drawing.Size(117, 20)
        Me.txtPorcentagemReducaoBCICMSST.TabIndex = 21
        Me.txtPorcentagemReducaoBCICMSST.Tag = "|10|30|70|90|"
        Me.txtPorcentagemReducaoBCICMSST.Text = "0,00"
        Me.txtPorcentagemReducaoBCICMSST.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPorcentagemReducaoBCICMSST
        '
        Me.lblPorcentagemReducaoBCICMSST.AutoSize = True
        Me.lblPorcentagemReducaoBCICMSST.Location = New System.Drawing.Point(129, 20)
        Me.lblPorcentagemReducaoBCICMSST.Name = "lblPorcentagemReducaoBCICMSST"
        Me.lblPorcentagemReducaoBCICMSST.Size = New System.Drawing.Size(104, 14)
        Me.lblPorcentagemReducaoBCICMSST.TabIndex = 20
        Me.lblPorcentagemReducaoBCICMSST.Text = "% Red. BC ICMS ST:"
        '
        'grpSituacaoTributariaICMS
        '
        Me.grpSituacaoTributariaICMS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSituacaoTributariaICMS.BackColor = System.Drawing.Color.Transparent
        Me.grpSituacaoTributariaICMS.Controls.Add(Me.cboSituacaoTributariaICMS)
        Me.grpSituacaoTributariaICMS.Controls.Add(Me.lblSituacaoTributariaICMS)
        Me.grpSituacaoTributariaICMS.Controls.Add(Me.txtDescricaoSituacaoTributariaICMS)
        Me.grpSituacaoTributariaICMS.Controls.Add(Me.lblDescricaoSituacaoTributariaICMS)
        Me.grpSituacaoTributariaICMS.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpSituacaoTributariaICMS.Location = New System.Drawing.Point(8, 3)
        Me.grpSituacaoTributariaICMS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSituacaoTributariaICMS.Name = "grpSituacaoTributariaICMS"
        Me.grpSituacaoTributariaICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSituacaoTributariaICMS.Size = New System.Drawing.Size(785, 67)
        Me.grpSituacaoTributariaICMS.TabIndex = 15
        Me.grpSituacaoTributariaICMS.Text = "Situação Tributária do ICMS"
        Me.grpSituacaoTributariaICMS.VisualStyleManager = Me.vsmMain
        '
        'cboSituacaoTributariaICMS
        '
        Me.cboSituacaoTributariaICMS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSituacaoTributariaICMS.AutoSize = False
        Me.cboSituacaoTributariaICMS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSituacaoTributariaICMS.Location = New System.Drawing.Point(9, 37)
        Me.cboSituacaoTributariaICMS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSituacaoTributariaICMS.Name = "cboSituacaoTributariaICMS"
        Me.cboSituacaoTributariaICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSituacaoTributariaICMS.Size = New System.Drawing.Size(167, 20)
        Me.cboSituacaoTributariaICMS.TabIndex = 16
        '
        'lblSituacaoTributariaICMS
        '
        Me.lblSituacaoTributariaICMS.AutoSize = True
        Me.lblSituacaoTributariaICMS.BackColor = System.Drawing.Color.Transparent
        Me.lblSituacaoTributariaICMS.Location = New System.Drawing.Point(6, 20)
        Me.lblSituacaoTributariaICMS.Name = "lblSituacaoTributariaICMS"
        Me.lblSituacaoTributariaICMS.Size = New System.Drawing.Size(100, 14)
        Me.lblSituacaoTributariaICMS.TabIndex = 15
        Me.lblSituacaoTributariaICMS.Text = "Situação Tributária:"
        '
        'txtDescricaoSituacaoTributariaICMS
        '
        Me.txtDescricaoSituacaoTributariaICMS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoSituacaoTributariaICMS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoSituacaoTributariaICMS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoSituacaoTributariaICMS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricaoSituacaoTributariaICMS.Location = New System.Drawing.Point(132, 37)
        Me.txtDescricaoSituacaoTributariaICMS.MaxLength = 50
        Me.txtDescricaoSituacaoTributariaICMS.Name = "txtDescricaoSituacaoTributariaICMS"
        Me.txtDescricaoSituacaoTributariaICMS.ReadOnly = True
        Me.txtDescricaoSituacaoTributariaICMS.Size = New System.Drawing.Size(644, 20)
        Me.txtDescricaoSituacaoTributariaICMS.TabIndex = 14
        Me.txtDescricaoSituacaoTributariaICMS.TabStop = False
        '
        'lblDescricaoSituacaoTributariaICMS
        '
        Me.lblDescricaoSituacaoTributariaICMS.AutoSize = True
        Me.lblDescricaoSituacaoTributariaICMS.BackColor = System.Drawing.Color.Transparent
        Me.lblDescricaoSituacaoTributariaICMS.Location = New System.Drawing.Point(129, 20)
        Me.lblDescricaoSituacaoTributariaICMS.Name = "lblDescricaoSituacaoTributariaICMS"
        Me.lblDescricaoSituacaoTributariaICMS.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoSituacaoTributariaICMS.TabIndex = 13
        Me.lblDescricaoSituacaoTributariaICMS.Text = "Descrição:"
        '
        'grpICMS
        '
        Me.grpICMS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpICMS.BackColor = System.Drawing.Color.Transparent
        Me.grpICMS.Controls.Add(Me.txtAliquotaICMS)
        Me.grpICMS.Controls.Add(Me.lblAliquotaICMS)
        Me.grpICMS.Controls.Add(Me.txtPorcentagemReducaoBCICMS)
        Me.grpICMS.Controls.Add(Me.lblPorcentagemReducaoBCICMS)
        Me.grpICMS.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpICMS.Location = New System.Drawing.Point(8, 73)
        Me.grpICMS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpICMS.Name = "grpICMS"
        Me.grpICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpICMS.Size = New System.Drawing.Size(785, 67)
        Me.grpICMS.TabIndex = 13
        Me.grpICMS.Text = "ICMS"
        Me.grpICMS.VisualStyleManager = Me.vsmMain
        '
        'txtAliquotaICMS
        '
        Me.txtAliquotaICMS.Enabled = False
        Me.txtAliquotaICMS.Location = New System.Drawing.Point(132, 37)
        Me.txtAliquotaICMS.Name = "txtAliquotaICMS"
        Me.txtAliquotaICMS.Size = New System.Drawing.Size(117, 20)
        Me.txtAliquotaICMS.TabIndex = 32
        Me.txtAliquotaICMS.Tag = "|00|10|20|70|90|"
        Me.txtAliquotaICMS.Text = "0,00"
        Me.txtAliquotaICMS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaICMS
        '
        Me.lblAliquotaICMS.AutoSize = True
        Me.lblAliquotaICMS.Location = New System.Drawing.Point(129, 20)
        Me.lblAliquotaICMS.Name = "lblAliquotaICMS"
        Me.lblAliquotaICMS.Size = New System.Drawing.Size(76, 14)
        Me.lblAliquotaICMS.TabIndex = 31
        Me.lblAliquotaICMS.Text = "Alíquota ICMS:"
        '
        'txtPorcentagemReducaoBCICMS
        '
        Me.txtPorcentagemReducaoBCICMS.Enabled = False
        Me.txtPorcentagemReducaoBCICMS.FormatString = "0.00000"
        Me.txtPorcentagemReducaoBCICMS.Location = New System.Drawing.Point(9, 37)
        Me.txtPorcentagemReducaoBCICMS.Name = "txtPorcentagemReducaoBCICMS"
        Me.txtPorcentagemReducaoBCICMS.Size = New System.Drawing.Size(117, 20)
        Me.txtPorcentagemReducaoBCICMS.TabIndex = 21
        Me.txtPorcentagemReducaoBCICMS.Tag = "|20|70|90|"
        Me.txtPorcentagemReducaoBCICMS.Text = "0,00000"
        Me.txtPorcentagemReducaoBCICMS.Value = New Decimal(New Integer() {0, 0, 0, 327680})
        '
        'lblPorcentagemReducaoBCICMS
        '
        Me.lblPorcentagemReducaoBCICMS.AutoSize = True
        Me.lblPorcentagemReducaoBCICMS.Location = New System.Drawing.Point(6, 20)
        Me.lblPorcentagemReducaoBCICMS.Name = "lblPorcentagemReducaoBCICMS"
        Me.lblPorcentagemReducaoBCICMS.Size = New System.Drawing.Size(89, 14)
        Me.lblPorcentagemReducaoBCICMS.TabIndex = 20
        Me.lblPorcentagemReducaoBCICMS.Text = "% Red. BC ICMS:"
        '
        'pagIPI
        '
        Me.pagIPI.Controls.Add(Me.grpValoresIPI)
        Me.pagIPI.Controls.Add(Me.grpSituacaoTributariaIPI)
        Me.pagIPI.Key = "pagIPI"
        Me.pagIPI.Location = New System.Drawing.Point(1, 22)
        Me.pagIPI.Name = "pagIPI"
        Me.pagIPI.Size = New System.Drawing.Size(751, 270)
        Me.pagIPI.TabStop = True
        Me.pagIPI.Text = "IPI"
        '
        'grpValoresIPI
        '
        Me.grpValoresIPI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpValoresIPI.BackColor = System.Drawing.Color.Transparent
        Me.grpValoresIPI.Controls.Add(Me.txtAliquotaIPI)
        Me.grpValoresIPI.Controls.Add(Me.lblAliquotaIPI)
        Me.grpValoresIPI.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpValoresIPI.Location = New System.Drawing.Point(8, 78)
        Me.grpValoresIPI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpValoresIPI.Name = "grpValoresIPI"
        Me.grpValoresIPI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpValoresIPI.Size = New System.Drawing.Size(735, 67)
        Me.grpValoresIPI.TabIndex = 22
        Me.grpValoresIPI.Text = "Valores"
        Me.grpValoresIPI.VisualStyleManager = Me.vsmMain
        '
        'txtAliquotaIPI
        '
        Me.txtAliquotaIPI.Enabled = False
        Me.txtAliquotaIPI.Location = New System.Drawing.Point(12, 37)
        Me.txtAliquotaIPI.Name = "txtAliquotaIPI"
        Me.txtAliquotaIPI.Size = New System.Drawing.Size(114, 20)
        Me.txtAliquotaIPI.TabIndex = 21
        Me.txtAliquotaIPI.Text = "0,00"
        Me.txtAliquotaIPI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaIPI
        '
        Me.lblAliquotaIPI.AutoSize = True
        Me.lblAliquotaIPI.Location = New System.Drawing.Point(9, 20)
        Me.lblAliquotaIPI.Name = "lblAliquotaIPI"
        Me.lblAliquotaIPI.Size = New System.Drawing.Size(49, 14)
        Me.lblAliquotaIPI.TabIndex = 20
        Me.lblAliquotaIPI.Text = "Alíquota:"
        '
        'grpSituacaoTributariaIPI
        '
        Me.grpSituacaoTributariaIPI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSituacaoTributariaIPI.BackColor = System.Drawing.Color.Transparent
        Me.grpSituacaoTributariaIPI.Controls.Add(Me.cboSituacaoTributariaIPI)
        Me.grpSituacaoTributariaIPI.Controls.Add(Me.lblSituacaoTributariaIPI)
        Me.grpSituacaoTributariaIPI.Controls.Add(Me.txtDescricaoSituacaoTributariaIPI)
        Me.grpSituacaoTributariaIPI.Controls.Add(Me.lblDescricaoSituacaoTributariaIPI)
        Me.grpSituacaoTributariaIPI.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpSituacaoTributariaIPI.Location = New System.Drawing.Point(8, 3)
        Me.grpSituacaoTributariaIPI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSituacaoTributariaIPI.Name = "grpSituacaoTributariaIPI"
        Me.grpSituacaoTributariaIPI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSituacaoTributariaIPI.Size = New System.Drawing.Size(735, 67)
        Me.grpSituacaoTributariaIPI.TabIndex = 21
        Me.grpSituacaoTributariaIPI.Text = "Situação Tributária do IPI"
        Me.grpSituacaoTributariaIPI.VisualStyleManager = Me.vsmMain
        '
        'cboSituacaoTributariaIPI
        '
        Me.cboSituacaoTributariaIPI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSituacaoTributariaIPI.AutoSize = False
        Me.cboSituacaoTributariaIPI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSituacaoTributariaIPI.Location = New System.Drawing.Point(9, 37)
        Me.cboSituacaoTributariaIPI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSituacaoTributariaIPI.Name = "cboSituacaoTributariaIPI"
        Me.cboSituacaoTributariaIPI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSituacaoTributariaIPI.Size = New System.Drawing.Size(117, 20)
        Me.cboSituacaoTributariaIPI.TabIndex = 16
        '
        'lblSituacaoTributariaIPI
        '
        Me.lblSituacaoTributariaIPI.AutoSize = True
        Me.lblSituacaoTributariaIPI.BackColor = System.Drawing.Color.Transparent
        Me.lblSituacaoTributariaIPI.Location = New System.Drawing.Point(6, 20)
        Me.lblSituacaoTributariaIPI.Name = "lblSituacaoTributariaIPI"
        Me.lblSituacaoTributariaIPI.Size = New System.Drawing.Size(100, 14)
        Me.lblSituacaoTributariaIPI.TabIndex = 15
        Me.lblSituacaoTributariaIPI.Text = "Situação Tributária:"
        '
        'txtDescricaoSituacaoTributariaIPI
        '
        Me.txtDescricaoSituacaoTributariaIPI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoSituacaoTributariaIPI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoSituacaoTributariaIPI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoSituacaoTributariaIPI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricaoSituacaoTributariaIPI.Location = New System.Drawing.Point(132, 37)
        Me.txtDescricaoSituacaoTributariaIPI.MaxLength = 50
        Me.txtDescricaoSituacaoTributariaIPI.Name = "txtDescricaoSituacaoTributariaIPI"
        Me.txtDescricaoSituacaoTributariaIPI.ReadOnly = True
        Me.txtDescricaoSituacaoTributariaIPI.Size = New System.Drawing.Size(594, 20)
        Me.txtDescricaoSituacaoTributariaIPI.TabIndex = 14
        Me.txtDescricaoSituacaoTributariaIPI.TabStop = False
        '
        'lblDescricaoSituacaoTributariaIPI
        '
        Me.lblDescricaoSituacaoTributariaIPI.AutoSize = True
        Me.lblDescricaoSituacaoTributariaIPI.BackColor = System.Drawing.Color.Transparent
        Me.lblDescricaoSituacaoTributariaIPI.Location = New System.Drawing.Point(129, 20)
        Me.lblDescricaoSituacaoTributariaIPI.Name = "lblDescricaoSituacaoTributariaIPI"
        Me.lblDescricaoSituacaoTributariaIPI.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoSituacaoTributariaIPI.TabIndex = 13
        Me.lblDescricaoSituacaoTributariaIPI.Text = "Descrição:"
        '
        'pagPIS
        '
        Me.pagPIS.Controls.Add(Me.grpPISST)
        Me.pagPIS.Controls.Add(Me.grpPIS)
        Me.pagPIS.Controls.Add(Me.grpSituacaoTributariaPIS)
        Me.pagPIS.Key = "pagPIS"
        Me.pagPIS.Location = New System.Drawing.Point(1, 22)
        Me.pagPIS.Name = "pagPIS"
        Me.pagPIS.Size = New System.Drawing.Size(751, 270)
        Me.pagPIS.TabStop = True
        Me.pagPIS.Text = "PIS"
        '
        'grpPISST
        '
        Me.grpPISST.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPISST.BackColor = System.Drawing.Color.Transparent
        Me.grpPISST.Controls.Add(Me.txtAliquotaPISST)
        Me.grpPISST.Controls.Add(Me.lblAliquotaPISST)
        Me.grpPISST.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpPISST.Location = New System.Drawing.Point(8, 143)
        Me.grpPISST.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpPISST.Name = "grpPISST"
        Me.grpPISST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPISST.Size = New System.Drawing.Size(735, 67)
        Me.grpPISST.TabIndex = 25
        Me.grpPISST.Text = "PIS ST"
        Me.grpPISST.VisualStyleManager = Me.vsmMain
        '
        'txtAliquotaPISST
        '
        Me.txtAliquotaPISST.Enabled = False
        Me.txtAliquotaPISST.Location = New System.Drawing.Point(9, 37)
        Me.txtAliquotaPISST.Name = "txtAliquotaPISST"
        Me.txtAliquotaPISST.Size = New System.Drawing.Size(114, 20)
        Me.txtAliquotaPISST.TabIndex = 21
        Me.txtAliquotaPISST.Text = "0,00"
        Me.txtAliquotaPISST.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaPISST
        '
        Me.lblAliquotaPISST.AutoSize = True
        Me.lblAliquotaPISST.Location = New System.Drawing.Point(6, 20)
        Me.lblAliquotaPISST.Name = "lblAliquotaPISST"
        Me.lblAliquotaPISST.Size = New System.Drawing.Size(49, 14)
        Me.lblAliquotaPISST.TabIndex = 20
        Me.lblAliquotaPISST.Text = "Alíquota:"
        '
        'grpPIS
        '
        Me.grpPIS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPIS.BackColor = System.Drawing.Color.Transparent
        Me.grpPIS.Controls.Add(Me.txtAliquotaPIS)
        Me.grpPIS.Controls.Add(Me.lblAliquotaPIS)
        Me.grpPIS.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpPIS.Location = New System.Drawing.Point(8, 73)
        Me.grpPIS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpPIS.Name = "grpPIS"
        Me.grpPIS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPIS.Size = New System.Drawing.Size(735, 67)
        Me.grpPIS.TabIndex = 23
        Me.grpPIS.Text = "PIS"
        Me.grpPIS.VisualStyleManager = Me.vsmMain
        '
        'txtAliquotaPIS
        '
        Me.txtAliquotaPIS.Enabled = False
        Me.txtAliquotaPIS.Location = New System.Drawing.Point(9, 37)
        Me.txtAliquotaPIS.Name = "txtAliquotaPIS"
        Me.txtAliquotaPIS.Size = New System.Drawing.Size(114, 20)
        Me.txtAliquotaPIS.TabIndex = 21
        Me.txtAliquotaPIS.Tag = "|01|02|"
        Me.txtAliquotaPIS.Text = "0,00"
        Me.txtAliquotaPIS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaPIS
        '
        Me.lblAliquotaPIS.AutoSize = True
        Me.lblAliquotaPIS.Location = New System.Drawing.Point(6, 20)
        Me.lblAliquotaPIS.Name = "lblAliquotaPIS"
        Me.lblAliquotaPIS.Size = New System.Drawing.Size(49, 14)
        Me.lblAliquotaPIS.TabIndex = 20
        Me.lblAliquotaPIS.Text = "Alíquota:"
        '
        'grpSituacaoTributariaPIS
        '
        Me.grpSituacaoTributariaPIS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSituacaoTributariaPIS.BackColor = System.Drawing.Color.Transparent
        Me.grpSituacaoTributariaPIS.Controls.Add(Me.cboSituacaoTributariaPIS)
        Me.grpSituacaoTributariaPIS.Controls.Add(Me.lblSituacaoTributariaPIS)
        Me.grpSituacaoTributariaPIS.Controls.Add(Me.txtDescricaoSituacaoTributariaPIS)
        Me.grpSituacaoTributariaPIS.Controls.Add(Me.lblDescricaoSituacaoTributariaPIS)
        Me.grpSituacaoTributariaPIS.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpSituacaoTributariaPIS.Location = New System.Drawing.Point(8, 3)
        Me.grpSituacaoTributariaPIS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSituacaoTributariaPIS.Name = "grpSituacaoTributariaPIS"
        Me.grpSituacaoTributariaPIS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSituacaoTributariaPIS.Size = New System.Drawing.Size(735, 67)
        Me.grpSituacaoTributariaPIS.TabIndex = 22
        Me.grpSituacaoTributariaPIS.Text = "Situação Tributária do PIS"
        Me.grpSituacaoTributariaPIS.VisualStyleManager = Me.vsmMain
        '
        'cboSituacaoTributariaPIS
        '
        Me.cboSituacaoTributariaPIS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSituacaoTributariaPIS.AutoSize = False
        Me.cboSituacaoTributariaPIS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSituacaoTributariaPIS.Location = New System.Drawing.Point(9, 37)
        Me.cboSituacaoTributariaPIS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSituacaoTributariaPIS.Name = "cboSituacaoTributariaPIS"
        Me.cboSituacaoTributariaPIS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSituacaoTributariaPIS.Size = New System.Drawing.Size(117, 20)
        Me.cboSituacaoTributariaPIS.TabIndex = 16
        '
        'lblSituacaoTributariaPIS
        '
        Me.lblSituacaoTributariaPIS.AutoSize = True
        Me.lblSituacaoTributariaPIS.BackColor = System.Drawing.Color.Transparent
        Me.lblSituacaoTributariaPIS.Location = New System.Drawing.Point(6, 20)
        Me.lblSituacaoTributariaPIS.Name = "lblSituacaoTributariaPIS"
        Me.lblSituacaoTributariaPIS.Size = New System.Drawing.Size(100, 14)
        Me.lblSituacaoTributariaPIS.TabIndex = 15
        Me.lblSituacaoTributariaPIS.Text = "Situação Tributária:"
        '
        'txtDescricaoSituacaoTributariaPIS
        '
        Me.txtDescricaoSituacaoTributariaPIS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoSituacaoTributariaPIS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoSituacaoTributariaPIS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoSituacaoTributariaPIS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricaoSituacaoTributariaPIS.Location = New System.Drawing.Point(132, 37)
        Me.txtDescricaoSituacaoTributariaPIS.MaxLength = 50
        Me.txtDescricaoSituacaoTributariaPIS.Name = "txtDescricaoSituacaoTributariaPIS"
        Me.txtDescricaoSituacaoTributariaPIS.ReadOnly = True
        Me.txtDescricaoSituacaoTributariaPIS.Size = New System.Drawing.Size(594, 20)
        Me.txtDescricaoSituacaoTributariaPIS.TabIndex = 14
        Me.txtDescricaoSituacaoTributariaPIS.TabStop = False
        '
        'lblDescricaoSituacaoTributariaPIS
        '
        Me.lblDescricaoSituacaoTributariaPIS.AutoSize = True
        Me.lblDescricaoSituacaoTributariaPIS.BackColor = System.Drawing.Color.Transparent
        Me.lblDescricaoSituacaoTributariaPIS.Location = New System.Drawing.Point(129, 20)
        Me.lblDescricaoSituacaoTributariaPIS.Name = "lblDescricaoSituacaoTributariaPIS"
        Me.lblDescricaoSituacaoTributariaPIS.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoSituacaoTributariaPIS.TabIndex = 13
        Me.lblDescricaoSituacaoTributariaPIS.Text = "Descrição:"
        '
        'pagCOFINS
        '
        Me.pagCOFINS.Controls.Add(Me.grpCOFINSST)
        Me.pagCOFINS.Controls.Add(Me.grpCOFINS)
        Me.pagCOFINS.Controls.Add(Me.grpSituacaoTributariaCOFINS)
        Me.pagCOFINS.Key = "pagCOFINS"
        Me.pagCOFINS.Location = New System.Drawing.Point(1, 22)
        Me.pagCOFINS.Name = "pagCOFINS"
        Me.pagCOFINS.Size = New System.Drawing.Size(751, 270)
        Me.pagCOFINS.TabStop = True
        Me.pagCOFINS.Text = "COFINS"
        '
        'grpCOFINSST
        '
        Me.grpCOFINSST.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCOFINSST.BackColor = System.Drawing.Color.Transparent
        Me.grpCOFINSST.Controls.Add(Me.txtAliquotaCOFINSST)
        Me.grpCOFINSST.Controls.Add(Me.lblAliquotaCOFINSST)
        Me.grpCOFINSST.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpCOFINSST.Location = New System.Drawing.Point(8, 143)
        Me.grpCOFINSST.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpCOFINSST.Name = "grpCOFINSST"
        Me.grpCOFINSST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCOFINSST.Size = New System.Drawing.Size(735, 67)
        Me.grpCOFINSST.TabIndex = 31
        Me.grpCOFINSST.Text = "COFINS ST"
        Me.grpCOFINSST.VisualStyleManager = Me.vsmMain
        '
        'txtAliquotaCOFINSST
        '
        Me.txtAliquotaCOFINSST.Enabled = False
        Me.txtAliquotaCOFINSST.Location = New System.Drawing.Point(9, 37)
        Me.txtAliquotaCOFINSST.Name = "txtAliquotaCOFINSST"
        Me.txtAliquotaCOFINSST.Size = New System.Drawing.Size(114, 20)
        Me.txtAliquotaCOFINSST.TabIndex = 21
        Me.txtAliquotaCOFINSST.Text = "0,00"
        Me.txtAliquotaCOFINSST.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaCOFINSST
        '
        Me.lblAliquotaCOFINSST.AutoSize = True
        Me.lblAliquotaCOFINSST.Location = New System.Drawing.Point(6, 20)
        Me.lblAliquotaCOFINSST.Name = "lblAliquotaCOFINSST"
        Me.lblAliquotaCOFINSST.Size = New System.Drawing.Size(49, 14)
        Me.lblAliquotaCOFINSST.TabIndex = 20
        Me.lblAliquotaCOFINSST.Text = "Alíquota:"
        '
        'grpCOFINS
        '
        Me.grpCOFINS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCOFINS.BackColor = System.Drawing.Color.Transparent
        Me.grpCOFINS.Controls.Add(Me.txtAliquotaCOFINS)
        Me.grpCOFINS.Controls.Add(Me.lblAliquotaCOFINS)
        Me.grpCOFINS.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpCOFINS.Location = New System.Drawing.Point(8, 73)
        Me.grpCOFINS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpCOFINS.Name = "grpCOFINS"
        Me.grpCOFINS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCOFINS.Size = New System.Drawing.Size(735, 67)
        Me.grpCOFINS.TabIndex = 28
        Me.grpCOFINS.Text = "COFINS"
        Me.grpCOFINS.VisualStyleManager = Me.vsmMain
        '
        'txtAliquotaCOFINS
        '
        Me.txtAliquotaCOFINS.Enabled = False
        Me.txtAliquotaCOFINS.Location = New System.Drawing.Point(9, 37)
        Me.txtAliquotaCOFINS.Name = "txtAliquotaCOFINS"
        Me.txtAliquotaCOFINS.Size = New System.Drawing.Size(114, 20)
        Me.txtAliquotaCOFINS.TabIndex = 21
        Me.txtAliquotaCOFINS.Tag = "|01|02|"
        Me.txtAliquotaCOFINS.Text = "0,00"
        Me.txtAliquotaCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaCOFINS
        '
        Me.lblAliquotaCOFINS.AutoSize = True
        Me.lblAliquotaCOFINS.Location = New System.Drawing.Point(6, 20)
        Me.lblAliquotaCOFINS.Name = "lblAliquotaCOFINS"
        Me.lblAliquotaCOFINS.Size = New System.Drawing.Size(49, 14)
        Me.lblAliquotaCOFINS.TabIndex = 20
        Me.lblAliquotaCOFINS.Text = "Alíquota:"
        '
        'grpSituacaoTributariaCOFINS
        '
        Me.grpSituacaoTributariaCOFINS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSituacaoTributariaCOFINS.BackColor = System.Drawing.Color.Transparent
        Me.grpSituacaoTributariaCOFINS.Controls.Add(Me.cboSituacaoTributariaCOFINS)
        Me.grpSituacaoTributariaCOFINS.Controls.Add(Me.lblSituacaoTributariaCOFINS)
        Me.grpSituacaoTributariaCOFINS.Controls.Add(Me.txtDescricaoSituacaoTributariaCOFINS)
        Me.grpSituacaoTributariaCOFINS.Controls.Add(Me.lblDescricaoSituacaoTributariaCOFINS)
        Me.grpSituacaoTributariaCOFINS.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpSituacaoTributariaCOFINS.Location = New System.Drawing.Point(8, 3)
        Me.grpSituacaoTributariaCOFINS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSituacaoTributariaCOFINS.Name = "grpSituacaoTributariaCOFINS"
        Me.grpSituacaoTributariaCOFINS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSituacaoTributariaCOFINS.Size = New System.Drawing.Size(735, 67)
        Me.grpSituacaoTributariaCOFINS.TabIndex = 25
        Me.grpSituacaoTributariaCOFINS.Text = "Situação Tributária do COFINS"
        Me.grpSituacaoTributariaCOFINS.VisualStyleManager = Me.vsmMain
        '
        'cboSituacaoTributariaCOFINS
        '
        Me.cboSituacaoTributariaCOFINS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSituacaoTributariaCOFINS.AutoSize = False
        Me.cboSituacaoTributariaCOFINS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSituacaoTributariaCOFINS.Location = New System.Drawing.Point(9, 37)
        Me.cboSituacaoTributariaCOFINS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSituacaoTributariaCOFINS.Name = "cboSituacaoTributariaCOFINS"
        Me.cboSituacaoTributariaCOFINS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSituacaoTributariaCOFINS.Size = New System.Drawing.Size(117, 20)
        Me.cboSituacaoTributariaCOFINS.TabIndex = 16
        '
        'lblSituacaoTributariaCOFINS
        '
        Me.lblSituacaoTributariaCOFINS.AutoSize = True
        Me.lblSituacaoTributariaCOFINS.BackColor = System.Drawing.Color.Transparent
        Me.lblSituacaoTributariaCOFINS.Location = New System.Drawing.Point(6, 20)
        Me.lblSituacaoTributariaCOFINS.Name = "lblSituacaoTributariaCOFINS"
        Me.lblSituacaoTributariaCOFINS.Size = New System.Drawing.Size(100, 14)
        Me.lblSituacaoTributariaCOFINS.TabIndex = 15
        Me.lblSituacaoTributariaCOFINS.Text = "Situação Tributária:"
        '
        'txtDescricaoSituacaoTributariaCOFINS
        '
        Me.txtDescricaoSituacaoTributariaCOFINS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoSituacaoTributariaCOFINS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoSituacaoTributariaCOFINS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoSituacaoTributariaCOFINS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricaoSituacaoTributariaCOFINS.Location = New System.Drawing.Point(132, 37)
        Me.txtDescricaoSituacaoTributariaCOFINS.MaxLength = 50
        Me.txtDescricaoSituacaoTributariaCOFINS.Name = "txtDescricaoSituacaoTributariaCOFINS"
        Me.txtDescricaoSituacaoTributariaCOFINS.ReadOnly = True
        Me.txtDescricaoSituacaoTributariaCOFINS.Size = New System.Drawing.Size(594, 20)
        Me.txtDescricaoSituacaoTributariaCOFINS.TabIndex = 14
        Me.txtDescricaoSituacaoTributariaCOFINS.TabStop = False
        '
        'lblDescricaoSituacaoTributariaCOFINS
        '
        Me.lblDescricaoSituacaoTributariaCOFINS.AutoSize = True
        Me.lblDescricaoSituacaoTributariaCOFINS.BackColor = System.Drawing.Color.Transparent
        Me.lblDescricaoSituacaoTributariaCOFINS.Location = New System.Drawing.Point(129, 20)
        Me.lblDescricaoSituacaoTributariaCOFINS.Name = "lblDescricaoSituacaoTributariaCOFINS"
        Me.lblDescricaoSituacaoTributariaCOFINS.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoSituacaoTributariaCOFINS.TabIndex = 13
        Me.lblDescricaoSituacaoTributariaCOFINS.Text = "Descrição:"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.btnImportar2)
        Me.UiGroupBox1.Controls.Add(Me.btnVoltarTributos)
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 303)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(753, 51)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'btnImportar2
        '
        Me.btnImportar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportar2.Image = Global.SysACTi.My.Resources.Resources.aprovar
        Me.btnImportar2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportar2.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnImportar2.Location = New System.Drawing.Point(556, 17)
        Me.btnImportar2.Name = "btnImportar2"
        Me.btnImportar2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportar2.Size = New System.Drawing.Size(91, 23)
        Me.btnImportar2.TabIndex = 2
        Me.btnImportar2.Text = "Importar"
        Me.btnImportar2.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltarTributos
        '
        Me.btnVoltarTributos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltarTributos.Image = Global.SysACTi.My.Resources.Resources.voltar
        Me.btnVoltarTributos.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltarTributos.Location = New System.Drawing.Point(653, 17)
        Me.btnVoltarTributos.Name = "btnVoltarTributos"
        Me.btnVoltarTributos.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltarTributos.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltarTributos.TabIndex = 1
        Me.btnVoltarTributos.Text = "Voltar"
        Me.btnVoltarTributos.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagDeclaracaoImportacao
        '
        Me.pagDeclaracaoImportacao.Key = "pagDeclaracaoImportacao"
        Me.pagDeclaracaoImportacao.Location = New System.Drawing.Point(1, 22)
        Me.pagDeclaracaoImportacao.Name = "pagDeclaracaoImportacao"
        Me.pagDeclaracaoImportacao.Size = New System.Drawing.Size(769, 410)
        Me.pagDeclaracaoImportacao.TabStop = True
        Me.pagDeclaracaoImportacao.TabVisible = False
        Me.pagDeclaracaoImportacao.Text = "Declaração de Importação"
        '
        'UiGroupBox17
        '
        Me.UiGroupBox17.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox17.Controls.Add(Me.UiButton3)
        Me.UiGroupBox17.Controls.Add(Me.UiButton4)
        Me.UiGroupBox17.Location = New System.Drawing.Point(8, 350)
        Me.UiGroupBox17.Name = "UiGroupBox17"
        Me.UiGroupBox17.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox17.Size = New System.Drawing.Size(753, 51)
        Me.UiGroupBox17.TabIndex = 5
        Me.UiGroupBox17.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox17.VisualStyleManager = Me.vsmMain
        '
        'UiButton3
        '
        Me.UiButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiButton3.Image = Global.SysACTi.My.Resources.Resources.salvar
        Me.UiButton3.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.UiButton3.ImageSize = New System.Drawing.Size(14, 14)
        Me.UiButton3.Location = New System.Drawing.Point(556, 17)
        Me.UiButton3.Name = "UiButton3"
        Me.UiButton3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiButton3.Size = New System.Drawing.Size(91, 23)
        Me.UiButton3.TabIndex = 1
        Me.UiButton3.Text = "Inserir"
        Me.UiButton3.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'UiButton4
        '
        Me.UiButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiButton4.Image = Global.SysACTi.My.Resources.Resources.voltar
        Me.UiButton4.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.UiButton4.Location = New System.Drawing.Point(653, 17)
        Me.UiButton4.Name = "UiButton4"
        Me.UiButton4.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiButton4.Size = New System.Drawing.Size(91, 23)
        Me.UiButton4.TabIndex = 2
        Me.UiButton4.Text = "Voltar"
        Me.UiButton4.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmFatEmissaoItemImportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(902, 509)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEmissaoItemImportar"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Produtos / Serviços"
        CType(Me.ofaMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpCaminho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCaminho.ResumeLayout(False)
        Me.grpCaminho.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControleDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleDados.ResumeLayout(False)
        Me.pagTributos.ResumeLayout(False)
        CType(Me.tabTributo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTributo.ResumeLayout(False)
        Me.pagICMS.ResumeLayout(False)
        CType(Me.grpICMSST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpICMSST.ResumeLayout(False)
        Me.grpICMSST.PerformLayout()
        CType(Me.grpSituacaoTributariaICMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSituacaoTributariaICMS.ResumeLayout(False)
        Me.grpSituacaoTributariaICMS.PerformLayout()
        CType(Me.grpICMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpICMS.ResumeLayout(False)
        Me.grpICMS.PerformLayout()
        Me.pagIPI.ResumeLayout(False)
        CType(Me.grpValoresIPI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpValoresIPI.ResumeLayout(False)
        Me.grpValoresIPI.PerformLayout()
        CType(Me.grpSituacaoTributariaIPI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSituacaoTributariaIPI.ResumeLayout(False)
        Me.grpSituacaoTributariaIPI.PerformLayout()
        Me.pagPIS.ResumeLayout(False)
        CType(Me.grpPISST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPISST.ResumeLayout(False)
        Me.grpPISST.PerformLayout()
        CType(Me.grpPIS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPIS.ResumeLayout(False)
        Me.grpPIS.PerformLayout()
        CType(Me.grpSituacaoTributariaPIS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSituacaoTributariaPIS.ResumeLayout(False)
        Me.grpSituacaoTributariaPIS.PerformLayout()
        Me.pagCOFINS.ResumeLayout(False)
        CType(Me.grpCOFINSST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCOFINSST.ResumeLayout(False)
        Me.grpCOFINSST.PerformLayout()
        CType(Me.grpCOFINS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCOFINS.ResumeLayout(False)
        Me.grpCOFINS.PerformLayout()
        CType(Me.grpSituacaoTributariaCOFINS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSituacaoTributariaCOFINS.ResumeLayout(False)
        Me.grpSituacaoTributariaCOFINS.PerformLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.UiGroupBox17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox17.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents ofaMain As Janus.Windows.Ribbon.OfficeFormAdorner
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControleDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltarDados As Janus.Windows.EditControls.UIButton
    Private WithEvents btnImportar As Janus.Windows.EditControls.UIButton
    Friend WithEvents pagTributos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagDeclaracaoImportacao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiGroupBox17 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents UiButton3 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton4 As Janus.Windows.EditControls.UIButton
    Friend WithEvents tabTributo As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagICMS As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpICMSST As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtIVA As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblIVA As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaICMSST As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaICMSST As System.Windows.Forms.Label
    Friend WithEvents txtPorcentagemReducaoBCICMSST As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPorcentagemReducaoBCICMSST As System.Windows.Forms.Label
    Friend WithEvents grpSituacaoTributariaICMS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboSituacaoTributariaICMS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSituacaoTributariaICMS As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoSituacaoTributariaICMS As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblDescricaoSituacaoTributariaICMS As System.Windows.Forms.Label
    Friend WithEvents grpICMS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtAliquotaICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaICMS As System.Windows.Forms.Label
    Friend WithEvents txtPorcentagemReducaoBCICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPorcentagemReducaoBCICMS As System.Windows.Forms.Label
    Friend WithEvents pagIPI As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpValoresIPI As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtAliquotaIPI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaIPI As System.Windows.Forms.Label
    Friend WithEvents grpSituacaoTributariaIPI As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboSituacaoTributariaIPI As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSituacaoTributariaIPI As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoSituacaoTributariaIPI As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblDescricaoSituacaoTributariaIPI As System.Windows.Forms.Label
    Friend WithEvents pagPIS As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpPISST As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtAliquotaPISST As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaPISST As System.Windows.Forms.Label
    Friend WithEvents grpPIS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtAliquotaPIS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaPIS As System.Windows.Forms.Label
    Friend WithEvents grpSituacaoTributariaPIS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboSituacaoTributariaPIS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSituacaoTributariaPIS As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoSituacaoTributariaPIS As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblDescricaoSituacaoTributariaPIS As System.Windows.Forms.Label
    Friend WithEvents pagCOFINS As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpCOFINSST As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtAliquotaCOFINSST As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaCOFINSST As System.Windows.Forms.Label
    Friend WithEvents grpCOFINS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtAliquotaCOFINS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaCOFINS As System.Windows.Forms.Label
    Friend WithEvents grpSituacaoTributariaCOFINS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboSituacaoTributariaCOFINS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSituacaoTributariaCOFINS As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoSituacaoTributariaCOFINS As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblDescricaoSituacaoTributariaCOFINS As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVoltarTributos As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpCaminho As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCaminhoPlaninha As System.Windows.Forms.Label
    Friend WithEvents txtCaminhoPlanilha As Janus.Windows.GridEX.EditControls.EditBox
    Private WithEvents btnProcurar As Janus.Windows.EditControls.UIButton
    Private WithEvents btnCarregarPlanilha As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtPlanilha As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblPlanilha As System.Windows.Forms.Label
    Private WithEvents btnImportar2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboCFOP As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCFOP As System.Windows.Forms.Label
End Class
