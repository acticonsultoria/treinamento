<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrIntImportacaoNFeTXT_V4_Magma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrIntImportacaoNFeTXT_V4_Magma))
        Dim grdVolumes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdVolumes_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grdControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagNotaFiscal = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblPasta = New System.Windows.Forms.Label()
        Me.txtPasta = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnPasta = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.pagVolumes = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPastaVolumes = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnPastaVolumes = New Janus.Windows.EditControls.UIButton()
        Me.grdVolumes = New Janus.Windows.GridEX.GridEX()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaArquivoImportado = New System.Windows.Forms.Label()
        Me.picLegendaArquivoImportado = New System.Windows.Forms.PictureBox()
        CType(Me.grdControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdControl.SuspendLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagNotaFiscal.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagVolumes.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdVolumes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaArquivoImportado, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'grdControl
        '
        Me.grdControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdControl.BackColor = System.Drawing.Color.Transparent
        Me.grdControl.Controls.Add(Me.btnNovo)
        Me.grdControl.Controls.Add(Me.btnSalvar)
        Me.grdControl.Controls.Add(Me.btnSair)
        Me.grdControl.Location = New System.Drawing.Point(265, 483)
        Me.grdControl.Name = "grdControl"
        Me.grdControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grdControl.Size = New System.Drawing.Size(640, 51)
        Me.grdControl.TabIndex = 6
        Me.grdControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(346, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(443, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(540, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpLegenda)
        Me.pagDados.Controls.Add(Me.grdControl)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Importar Nota Fiscal Eletrônica - TXT"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.FocusOnClick = False
        Me.tabDados.Location = New System.Drawing.Point(8, 3)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(897, 474)
        Me.tabDados.TabIndex = 92
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagNotaFiscal, Me.pagVolumes})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagNotaFiscal
        '
        Me.pagNotaFiscal.Controls.Add(Me.grpDados)
        Me.pagNotaFiscal.Controls.Add(Me.grdListagem)
        Me.pagNotaFiscal.Location = New System.Drawing.Point(1, 22)
        Me.pagNotaFiscal.Name = "pagNotaFiscal"
        Me.pagNotaFiscal.Size = New System.Drawing.Size(895, 451)
        Me.pagNotaFiscal.TabStop = True
        Me.pagNotaFiscal.Text = "Nota Fiscal"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblPasta)
        Me.grpDados.Controls.Add(Me.txtPasta)
        Me.grpDados.Controls.Add(Me.btnPasta)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(879, 64)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblPasta
        '
        Me.lblPasta.AutoSize = True
        Me.lblPasta.Location = New System.Drawing.Point(6, 17)
        Me.lblPasta.Name = "lblPasta"
        Me.lblPasta.Size = New System.Drawing.Size(92, 14)
        Me.lblPasta.TabIndex = 6
        Me.lblPasta.Text = "Pasta de Arquivo:"
        '
        'txtPasta
        '
        Me.txtPasta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPasta.BackColor = System.Drawing.SystemColors.Info
        Me.txtPasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPasta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasta.Location = New System.Drawing.Point(9, 34)
        Me.txtPasta.MaxLength = 50
        Me.txtPasta.Name = "txtPasta"
        Me.txtPasta.ReadOnly = True
        Me.txtPasta.Size = New System.Drawing.Size(839, 20)
        Me.txtPasta.TabIndex = 7
        Me.txtPasta.TabStop = False
        '
        'btnPasta
        '
        Me.btnPasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPasta.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPasta.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnPasta.Location = New System.Drawing.Point(847, 34)
        Me.btnPasta.Name = "btnPasta"
        Me.btnPasta.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPasta.Size = New System.Drawing.Size(23, 20)
        Me.btnPasta.TabIndex = 8
        Me.btnPasta.Text = "..."
        Me.btnPasta.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        Me.grdListagem.FilterRowFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.FilterRowFormatStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(8, 73)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(879, 368)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'pagVolumes
        '
        Me.pagVolumes.Controls.Add(Me.UiGroupBox1)
        Me.pagVolumes.Controls.Add(Me.grdVolumes)
        Me.pagVolumes.Location = New System.Drawing.Point(1, 22)
        Me.pagVolumes.Name = "pagVolumes"
        Me.pagVolumes.Size = New System.Drawing.Size(895, 451)
        Me.pagVolumes.TabStop = True
        Me.pagVolumes.Text = "Volumes"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Controls.Add(Me.txtPastaVolumes)
        Me.UiGroupBox1.Controls.Add(Me.btnPastaVolumes)
        Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(879, 64)
        Me.UiGroupBox1.TabIndex = 2
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Pasta de Arquivo:"
        '
        'txtPastaVolumes
        '
        Me.txtPastaVolumes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPastaVolumes.BackColor = System.Drawing.SystemColors.Info
        Me.txtPastaVolumes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPastaVolumes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPastaVolumes.Location = New System.Drawing.Point(9, 34)
        Me.txtPastaVolumes.MaxLength = 50
        Me.txtPastaVolumes.Name = "txtPastaVolumes"
        Me.txtPastaVolumes.ReadOnly = True
        Me.txtPastaVolumes.Size = New System.Drawing.Size(839, 20)
        Me.txtPastaVolumes.TabIndex = 7
        Me.txtPastaVolumes.TabStop = False
        '
        'btnPastaVolumes
        '
        Me.btnPastaVolumes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPastaVolumes.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPastaVolumes.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnPastaVolumes.Location = New System.Drawing.Point(847, 34)
        Me.btnPastaVolumes.Name = "btnPastaVolumes"
        Me.btnPastaVolumes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPastaVolumes.Size = New System.Drawing.Size(23, 20)
        Me.btnPastaVolumes.TabIndex = 8
        Me.btnPastaVolumes.Text = "..."
        Me.btnPastaVolumes.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdVolumes
        '
        Me.grdVolumes.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdVolumes.AlternatingColors = True
        Me.grdVolumes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdVolumes.ColumnAutoResize = True
        grdVolumes_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdVolumes_DesignTimeLayout_Reference_0.Instance"), Object)
        grdVolumes_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdVolumes_DesignTimeLayout_Reference_0})
        grdVolumes_DesignTimeLayout.LayoutString = resources.GetString("grdVolumes_DesignTimeLayout.LayoutString")
        Me.grdVolumes.DesignTimeLayout = grdVolumes_DesignTimeLayout
        Me.grdVolumes.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdVolumes.FilterRowFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.[True]
        Me.grdVolumes.FilterRowFormatStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdVolumes.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdVolumes.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdVolumes.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdVolumes.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdVolumes.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdVolumes.GroupByBoxVisible = False
        Me.grdVolumes.Location = New System.Drawing.Point(8, 73)
        Me.grdVolumes.Name = "grdVolumes"
        Me.grdVolumes.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdVolumes.RecordNavigator = True
        Me.grdVolumes.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdVolumes.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdVolumes.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdVolumes.Size = New System.Drawing.Size(879, 368)
        Me.grdVolumes.TabIndex = 3
        Me.grdVolumes.TabStop = False
        Me.grdVolumes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdVolumes.VisualStyleManager = Me.vsmMain
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaArquivoImportado)
        Me.grpLegenda.Controls.Add(Me.picLegendaArquivoImportado)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(248, 51)
        Me.grpLegenda.TabIndex = 5
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaArquivoImportado
        '
        Me.lblLegendaArquivoImportado.AutoSize = True
        Me.lblLegendaArquivoImportado.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaArquivoImportado.Name = "lblLegendaArquivoImportado"
        Me.lblLegendaArquivoImportado.Size = New System.Drawing.Size(216, 14)
        Me.lblLegendaArquivoImportado.TabIndex = 0
        Me.lblLegendaArquivoImportado.Text = "Arquivo de Nota Fiscal Eletrônica Importada"
        '
        'picLegendaArquivoImportado
        '
        Me.picLegendaArquivoImportado.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaArquivoImportado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaArquivoImportado.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaArquivoImportado.Name = "picLegendaArquivoImportado"
        Me.picLegendaArquivoImportado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaArquivoImportado.TabIndex = 8
        Me.picLegendaArquivoImportado.TabStop = False
        '
        'usrIntImportacaoNFeTXT_V4_Magma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrIntImportacaoNFeTXT_V4_Magma"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.grdControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdControl.ResumeLayout(False)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagNotaFiscal.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagVolumes.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grdVolumes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaArquivoImportado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblPasta As System.Windows.Forms.Label
    Friend WithEvents txtPasta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Private WithEvents btnPasta As Janus.Windows.EditControls.UIButton
    Private WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaArquivoImportado As System.Windows.Forms.Label
    Friend WithEvents picLegendaArquivoImportado As System.Windows.Forms.PictureBox
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagNotaFiscal As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagVolumes As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPastaVolumes As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Private WithEvents btnPastaVolumes As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdVolumes As Janus.Windows.GridEX.GridEX

End Class
