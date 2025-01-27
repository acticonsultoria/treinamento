<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadProdutoBOM2_BKP
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
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegendaItemFantasma = New System.Windows.Forms.PictureBox()
        Me.lblLegendaItemFantasma = New System.Windows.Forms.Label()
        Me.picLegendaGeraOP = New System.Windows.Forms.PictureBox()
        Me.lblLegendaGeraOP = New System.Windows.Forms.Label()
        Me.picLegendaMPHD = New System.Windows.Forms.PictureBox()
        Me.lblLegendaMPHD = New System.Windows.Forms.Label()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.cboCodigoProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoProduto = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.grpDadosMaterial = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblPosicao = New System.Windows.Forms.Label()
        Me.txtPosicao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnNovoMaterial = New Janus.Windows.EditControls.UIButton()
        Me.grpFind = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtFind = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFind = New System.Windows.Forms.Label()
        Me.btnLocalizar = New Janus.Windows.EditControls.UIButton()
        Me.btnImportarEstrutura = New Janus.Windows.EditControls.UIButton()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.txtReferencia = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.btnProcurarItem = New System.Windows.Forms.Button()
        Me.btnCadastrarItem = New System.Windows.Forms.Button()
        Me.lblCodigoItem = New System.Windows.Forms.Label()
        Me.cboCodigoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDescricaoItem = New System.Windows.Forms.Label()
        Me.txtDescricaoItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTipoItem = New System.Windows.Forms.Label()
        Me.cboTipoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.btnProcurarItemOriginal = New System.Windows.Forms.Button()
        Me.btnCadastrarUnidadeMedida = New System.Windows.Forms.Button()
        Me.lblUnidadeMedida = New System.Windows.Forms.Label()
        Me.cboUnidadeMedida = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoItemOriginal = New System.Windows.Forms.Label()
        Me.cboCodigoItemOriginal = New Janus.Windows.EditControls.UIComboBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDescricaoItemOriginal = New System.Windows.Forms.Label()
        Me.txtDescricaoItemOriginal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.trvMain = New System.Windows.Forms.TreeView()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImprimirRelatorio = New Janus.Windows.EditControls.UIButton()
        Me.btnRecolher = New Janus.Windows.EditControls.UIButton()
        Me.btnExpandir = New Janus.Windows.EditControls.UIButton()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.lblSC = New System.Windows.Forms.Label()
        Me.txtSC = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtDET = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDET = New System.Windows.Forms.Label()
        Me.lblMP = New System.Windows.Forms.Label()
        Me.txtMP = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaItemFantasma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaGeraOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaMPHD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpDadosMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosMaterial.SuspendLayout()
        CType(Me.grpFind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFind.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpLegenda)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grpDadosMaterial)
        Me.pagDados.Controls.Add(Me.trvMain)
        Me.pagDados.Controls.Add(Me.grpControl)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "padDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Produto - BOM"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.picLegendaItemFantasma)
        Me.grpLegenda.Controls.Add(Me.lblLegendaItemFantasma)
        Me.grpLegenda.Controls.Add(Me.picLegendaGeraOP)
        Me.grpLegenda.Controls.Add(Me.lblLegendaGeraOP)
        Me.grpLegenda.Controls.Add(Me.picLegendaMPHD)
        Me.grpLegenda.Controls.Add(Me.lblLegendaMPHD)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(221, 51)
        Me.grpLegenda.TabIndex = 5
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picLegendaItemFantasma
        '
        Me.picLegendaItemFantasma.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaItemFantasma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaItemFantasma.Location = New System.Drawing.Point(105, 13)
        Me.picLegendaItemFantasma.Name = "picLegendaItemFantasma"
        Me.picLegendaItemFantasma.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaItemFantasma.TabIndex = 17
        Me.picLegendaItemFantasma.TabStop = False
        Me.picLegendaItemFantasma.Visible = False
        '
        'lblLegendaItemFantasma
        '
        Me.lblLegendaItemFantasma.AutoSize = True
        Me.lblLegendaItemFantasma.Location = New System.Drawing.Point(126, 13)
        Me.lblLegendaItemFantasma.Name = "lblLegendaItemFantasma"
        Me.lblLegendaItemFantasma.Size = New System.Drawing.Size(76, 14)
        Me.lblLegendaItemFantasma.TabIndex = 3
        Me.lblLegendaItemFantasma.Text = "Item Fantasma"
        Me.lblLegendaItemFantasma.Visible = False
        '
        'picLegendaGeraOP
        '
        Me.picLegendaGeraOP.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaGeraOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaGeraOP.Location = New System.Drawing.Point(9, 13)
        Me.picLegendaGeraOP.Name = "picLegendaGeraOP"
        Me.picLegendaGeraOP.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaGeraOP.TabIndex = 11
        Me.picLegendaGeraOP.TabStop = False
        '
        'lblLegendaGeraOP
        '
        Me.lblLegendaGeraOP.AutoSize = True
        Me.lblLegendaGeraOP.Location = New System.Drawing.Point(30, 13)
        Me.lblLegendaGeraOP.Name = "lblLegendaGeraOP"
        Me.lblLegendaGeraOP.Size = New System.Drawing.Size(48, 14)
        Me.lblLegendaGeraOP.TabIndex = 2
        Me.lblLegendaGeraOP.Text = "Gera OP"
        '
        'picLegendaMPHD
        '
        Me.picLegendaMPHD.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaMPHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaMPHD.Location = New System.Drawing.Point(9, 30)
        Me.picLegendaMPHD.Name = "picLegendaMPHD"
        Me.picLegendaMPHD.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaMPHD.TabIndex = 19
        Me.picLegendaMPHD.TabStop = False
        '
        'lblLegendaMPHD
        '
        Me.lblLegendaMPHD.AutoSize = True
        Me.lblLegendaMPHD.Location = New System.Drawing.Point(30, 30)
        Me.lblLegendaMPHD.Name = "lblLegendaMPHD"
        Me.lblLegendaMPHD.Size = New System.Drawing.Size(90, 14)
        Me.lblLegendaMPHD.TabIndex = 1
        Me.lblLegendaMPHD.Text = "MP / Componente"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblPosicao)
        Me.grpDados.Controls.Add(Me.btnProcurarProduto)
        Me.grpDados.Controls.Add(Me.txtPosicao)
        Me.grpDados.Controls.Add(Me.cboCodigoProduto)
        Me.grpDados.Controls.Add(Me.lblCodigoProduto)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Controls.Add(Me.lblReferencia)
        Me.grpDados.Controls.Add(Me.txtReferencia)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 64)
        Me.grpDados.TabIndex = 1
        Me.grpDados.Text = "Dados do Produto"
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProduto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProduto.Location = New System.Drawing.Point(142, 16)
        Me.btnProcurarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProduto.TabIndex = 2
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'cboCodigoProduto
        '
        Me.cboCodigoProduto.Location = New System.Drawing.Point(9, 34)
        Me.cboCodigoProduto.Name = "cboCodigoProduto"
        Me.cboCodigoProduto.Size = New System.Drawing.Size(150, 20)
        Me.cboCodigoProduto.TabIndex = 1
        '
        'lblCodigoProduto
        '
        Me.lblCodigoProduto.AutoSize = True
        Me.lblCodigoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProduto.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        Me.lblCodigoProduto.Size = New System.Drawing.Size(83, 14)
        Me.lblCodigoProduto.TabIndex = 0
        Me.lblCodigoProduto.Text = "Código Produto:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDescricao.Location = New System.Drawing.Point(165, 34)
        Me.txtDescricao.MaxLength = 120
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(723, 20)
        Me.txtDescricao.TabIndex = 4
        Me.txtDescricao.TabStop = False
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricao.Location = New System.Drawing.Point(162, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 3
        Me.lblDescricao.Text = "Descrição:"
        '
        'grpDadosMaterial
        '
        Me.grpDadosMaterial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosMaterial.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosMaterial.Controls.Add(Me.lblMP)
        Me.grpDadosMaterial.Controls.Add(Me.txtMP)
        Me.grpDadosMaterial.Controls.Add(Me.txtDET)
        Me.grpDadosMaterial.Controls.Add(Me.lblDET)
        Me.grpDadosMaterial.Controls.Add(Me.txtSC)
        Me.grpDadosMaterial.Controls.Add(Me.lblSC)
        Me.grpDadosMaterial.Controls.Add(Me.btnNovoMaterial)
        Me.grpDadosMaterial.Controls.Add(Me.grpFind)
        Me.grpDadosMaterial.Controls.Add(Me.btnImportarEstrutura)
        Me.grpDadosMaterial.Controls.Add(Me.btnExcluir)
        Me.grpDadosMaterial.Controls.Add(Me.btnInserir)
        Me.grpDadosMaterial.Controls.Add(Me.btnProcurarItem)
        Me.grpDadosMaterial.Controls.Add(Me.btnCadastrarItem)
        Me.grpDadosMaterial.Controls.Add(Me.lblCodigoItem)
        Me.grpDadosMaterial.Controls.Add(Me.cboCodigoItem)
        Me.grpDadosMaterial.Controls.Add(Me.lblDescricaoItem)
        Me.grpDadosMaterial.Controls.Add(Me.txtDescricaoItem)
        Me.grpDadosMaterial.Controls.Add(Me.lblTipoItem)
        Me.grpDadosMaterial.Controls.Add(Me.cboTipoItem)
        Me.grpDadosMaterial.Controls.Add(Me.btnProcurarItemOriginal)
        Me.grpDadosMaterial.Controls.Add(Me.btnCadastrarUnidadeMedida)
        Me.grpDadosMaterial.Controls.Add(Me.lblUnidadeMedida)
        Me.grpDadosMaterial.Controls.Add(Me.cboUnidadeMedida)
        Me.grpDadosMaterial.Controls.Add(Me.lblCodigoItemOriginal)
        Me.grpDadosMaterial.Controls.Add(Me.cboCodigoItemOriginal)
        Me.grpDadosMaterial.Controls.Add(Me.lblQuantidade)
        Me.grpDadosMaterial.Controls.Add(Me.txtQuantidade)
        Me.grpDadosMaterial.Controls.Add(Me.lblDescricaoItemOriginal)
        Me.grpDadosMaterial.Controls.Add(Me.txtDescricaoItemOriginal)
        Me.grpDadosMaterial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpDadosMaterial.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosMaterial.Location = New System.Drawing.Point(8, 70)
        Me.grpDadosMaterial.Name = "grpDadosMaterial"
        Me.grpDadosMaterial.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosMaterial.Size = New System.Drawing.Size(897, 150)
        Me.grpDadosMaterial.TabIndex = 3
        Me.grpDadosMaterial.Text = "Dados do Material"
        Me.grpDadosMaterial.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosMaterial.VisualStyleManager = Me.vsmMain
        '
        'lblPosicao
        '
        Me.lblPosicao.AutoSize = True
        Me.lblPosicao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPosicao.Location = New System.Drawing.Point(598, 2)
        Me.lblPosicao.Name = "lblPosicao"
        Me.lblPosicao.Size = New System.Drawing.Size(48, 14)
        Me.lblPosicao.TabIndex = 5
        Me.lblPosicao.Text = "Posição:"
        Me.lblPosicao.Visible = False
        '
        'txtPosicao
        '
        Me.txtPosicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPosicao.BackColor = System.Drawing.Color.White
        Me.txtPosicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPosicao.Location = New System.Drawing.Point(601, 19)
        Me.txtPosicao.MaxLength = 120
        Me.txtPosicao.Name = "txtPosicao"
        Me.txtPosicao.Size = New System.Drawing.Size(157, 20)
        Me.txtPosicao.TabIndex = 6
        Me.txtPosicao.Visible = False
        '
        'btnNovoMaterial
        '
        Me.btnNovoMaterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovoMaterial.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovoMaterial.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovoMaterial.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovoMaterial.Location = New System.Drawing.Point(800, 118)
        Me.btnNovoMaterial.Name = "btnNovoMaterial"
        Me.btnNovoMaterial.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovoMaterial.Size = New System.Drawing.Size(91, 23)
        Me.btnNovoMaterial.TabIndex = 0
        Me.btnNovoMaterial.Text = "Novo"
        Me.btnNovoMaterial.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFind
        '
        Me.grpFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFind.BackColor = System.Drawing.Color.Transparent
        Me.grpFind.Controls.Add(Me.txtFind)
        Me.grpFind.Controls.Add(Me.lblFind)
        Me.grpFind.Controls.Add(Me.btnLocalizar)
        Me.grpFind.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFind.Location = New System.Drawing.Point(493, 100)
        Me.grpFind.Name = "grpFind"
        Me.grpFind.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFind.Size = New System.Drawing.Size(278, 44)
        Me.grpFind.TabIndex = 26
        Me.grpFind.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFind.VisualStyleManager = Me.vsmMain
        '
        'txtFind
        '
        Me.txtFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFind.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFind.Location = New System.Drawing.Point(51, 16)
        Me.txtFind.MaxLength = 120
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(105, 20)
        Me.txtFind.TabIndex = 1
        '
        'lblFind
        '
        Me.lblFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFind.AutoSize = True
        Me.lblFind.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFind.Location = New System.Drawing.Point(9, 18)
        Me.lblFind.Name = "lblFind"
        Me.lblFind.Size = New System.Drawing.Size(36, 14)
        Me.lblFind.TabIndex = 0
        Me.lblFind.Text = "Texto:"
        '
        'btnLocalizar
        '
        Me.btnLocalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLocalizar.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnLocalizar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnLocalizar.Location = New System.Drawing.Point(162, 13)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnLocalizar.Size = New System.Drawing.Size(91, 23)
        Me.btnLocalizar.TabIndex = 2
        Me.btnLocalizar.Text = "Procurar"
        Me.btnLocalizar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImportarEstrutura
        '
        Me.btnImportarEstrutura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportarEstrutura.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnImportarEstrutura.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarEstrutura.Location = New System.Drawing.Point(740, 31)
        Me.btnImportarEstrutura.Name = "btnImportarEstrutura"
        Me.btnImportarEstrutura.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportarEstrutura.Size = New System.Drawing.Size(148, 23)
        Me.btnImportarEstrutura.TabIndex = 7
        Me.btnImportarEstrutura.Text = "Importar Estrutura"
        Me.btnImportarEstrutura.Visible = False
        Me.btnImportarEstrutura.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblReferencia.Location = New System.Drawing.Point(761, 2)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(63, 14)
        Me.lblReferencia.TabIndex = 7
        Me.lblReferencia.Text = "Referência:"
        Me.lblReferencia.Visible = False
        '
        'txtReferencia
        '
        Me.txtReferencia.DecimalDigits = 0
        Me.txtReferencia.Location = New System.Drawing.Point(764, 19)
        Me.txtReferencia.MaxLength = 15
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(108, 20)
        Me.txtReferencia.TabIndex = 8
        Me.txtReferencia.Text = "0"
        Me.txtReferencia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtReferencia.Visible = False
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(800, 89)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 28
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(800, 60)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 27
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnProcurarItem
        '
        Me.btnProcurarItem.FlatAppearance.BorderSize = 0
        Me.btnProcurarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItem.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItem.Location = New System.Drawing.Point(142, 56)
        Me.btnProcurarItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItem.Name = "btnProcurarItem"
        Me.btnProcurarItem.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItem.TabIndex = 12
        Me.btnProcurarItem.TabStop = False
        Me.btnProcurarItem.UseVisualStyleBackColor = True
        '
        'btnCadastrarItem
        '
        Me.btnCadastrarItem.FlatAppearance.BorderSize = 0
        Me.btnCadastrarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarItem.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarItem.Location = New System.Drawing.Point(9, 58)
        Me.btnCadastrarItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarItem.Name = "btnCadastrarItem"
        Me.btnCadastrarItem.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarItem.TabIndex = 9
        Me.btnCadastrarItem.TabStop = False
        Me.btnCadastrarItem.UseVisualStyleBackColor = True
        '
        'lblCodigoItem
        '
        Me.lblCodigoItem.AutoSize = True
        Me.lblCodigoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoItem.Location = New System.Drawing.Point(25, 57)
        Me.lblCodigoItem.Name = "lblCodigoItem"
        Me.lblCodigoItem.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigoItem.TabIndex = 10
        Me.lblCodigoItem.Text = "Código:"
        '
        'cboCodigoItem
        '
        Me.cboCodigoItem.Location = New System.Drawing.Point(9, 74)
        Me.cboCodigoItem.Name = "cboCodigoItem"
        Me.cboCodigoItem.Size = New System.Drawing.Size(150, 20)
        Me.cboCodigoItem.TabIndex = 11
        '
        'lblDescricaoItem
        '
        Me.lblDescricaoItem.AutoSize = True
        Me.lblDescricaoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricaoItem.Location = New System.Drawing.Point(162, 57)
        Me.lblDescricaoItem.Name = "lblDescricaoItem"
        Me.lblDescricaoItem.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoItem.TabIndex = 13
        Me.lblDescricaoItem.Text = "Descrição:"
        '
        'txtDescricaoItem
        '
        Me.txtDescricaoItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoItem.Location = New System.Drawing.Point(165, 74)
        Me.txtDescricaoItem.MaxLength = 120
        Me.txtDescricaoItem.Name = "txtDescricaoItem"
        Me.txtDescricaoItem.ReadOnly = True
        Me.txtDescricaoItem.Size = New System.Drawing.Size(606, 20)
        Me.txtDescricaoItem.TabIndex = 14
        Me.txtDescricaoItem.TabStop = False
        '
        'lblTipoItem
        '
        Me.lblTipoItem.AutoSize = True
        Me.lblTipoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoItem.Location = New System.Drawing.Point(6, 17)
        Me.lblTipoItem.Name = "lblTipoItem"
        Me.lblTipoItem.Size = New System.Drawing.Size(30, 14)
        Me.lblTipoItem.TabIndex = 2
        Me.lblTipoItem.Text = "Tipo:"
        '
        'cboTipoItem
        '
        Me.cboTipoItem.Location = New System.Drawing.Point(9, 34)
        Me.cboTipoItem.Name = "cboTipoItem"
        Me.cboTipoItem.Size = New System.Drawing.Size(150, 20)
        Me.cboTipoItem.TabIndex = 3
        '
        'btnProcurarItemOriginal
        '
        Me.btnProcurarItemOriginal.FlatAppearance.BorderSize = 0
        Me.btnProcurarItemOriginal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItemOriginal.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarItemOriginal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItemOriginal.Location = New System.Drawing.Point(298, 16)
        Me.btnProcurarItemOriginal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItemOriginal.Name = "btnProcurarItemOriginal"
        Me.btnProcurarItemOriginal.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItemOriginal.TabIndex = 6
        Me.btnProcurarItemOriginal.TabStop = False
        Me.btnProcurarItemOriginal.UseVisualStyleBackColor = True
        '
        'btnCadastrarUnidadeMedida
        '
        Me.btnCadastrarUnidadeMedida.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUnidadeMedida.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarUnidadeMedida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUnidadeMedida.Location = New System.Drawing.Point(111, 102)
        Me.btnCadastrarUnidadeMedida.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUnidadeMedida.Name = "btnCadastrarUnidadeMedida"
        Me.btnCadastrarUnidadeMedida.Size = New System.Drawing.Size(20, 13)
        Me.btnCadastrarUnidadeMedida.TabIndex = 17
        Me.btnCadastrarUnidadeMedida.TabStop = False
        Me.btnCadastrarUnidadeMedida.UseVisualStyleBackColor = True
        '
        'lblUnidadeMedida
        '
        Me.lblUnidadeMedida.AutoSize = True
        Me.lblUnidadeMedida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUnidadeMedida.Location = New System.Drawing.Point(129, 101)
        Me.lblUnidadeMedida.Name = "lblUnidadeMedida"
        Me.lblUnidadeMedida.Size = New System.Drawing.Size(58, 14)
        Me.lblUnidadeMedida.TabIndex = 18
        Me.lblUnidadeMedida.Text = "Und. Med.:"
        '
        'cboUnidadeMedida
        '
        Me.cboUnidadeMedida.AutoSize = False
        Me.cboUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = ""
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = ""
        Me.cboUnidadeMedida.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboUnidadeMedida.Location = New System.Drawing.Point(113, 118)
        Me.cboUnidadeMedida.Name = "cboUnidadeMedida"
        Me.cboUnidadeMedida.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedida.Size = New System.Drawing.Size(97, 20)
        Me.cboUnidadeMedida.TabIndex = 19
        '
        'lblCodigoItemOriginal
        '
        Me.lblCodigoItemOriginal.AutoSize = True
        Me.lblCodigoItemOriginal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoItemOriginal.Location = New System.Drawing.Point(162, 17)
        Me.lblCodigoItemOriginal.Name = "lblCodigoItemOriginal"
        Me.lblCodigoItemOriginal.Size = New System.Drawing.Size(82, 14)
        Me.lblCodigoItemOriginal.TabIndex = 4
        Me.lblCodigoItemOriginal.Text = "Código Original:"
        '
        'cboCodigoItemOriginal
        '
        Me.cboCodigoItemOriginal.Location = New System.Drawing.Point(165, 34)
        Me.cboCodigoItemOriginal.Name = "cboCodigoItemOriginal"
        Me.cboCodigoItemOriginal.Size = New System.Drawing.Size(150, 20)
        Me.cboCodigoItemOriginal.TabIndex = 5
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidade.Location = New System.Drawing.Point(6, 101)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 15
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.DecimalDigits = 6
        Me.txtQuantidade.Location = New System.Drawing.Point(9, 118)
        Me.txtQuantidade.MaxLength = 15
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(98, 20)
        Me.txtQuantidade.TabIndex = 16
        Me.txtQuantidade.Text = "0,000000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 393216})
        '
        'lblDescricaoItemOriginal
        '
        Me.lblDescricaoItemOriginal.AutoSize = True
        Me.lblDescricaoItemOriginal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricaoItemOriginal.Location = New System.Drawing.Point(318, 17)
        Me.lblDescricaoItemOriginal.Name = "lblDescricaoItemOriginal"
        Me.lblDescricaoItemOriginal.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoItemOriginal.TabIndex = 7
        Me.lblDescricaoItemOriginal.Text = "Descrição:"
        '
        'txtDescricaoItemOriginal
        '
        Me.txtDescricaoItemOriginal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoItemOriginal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoItemOriginal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoItemOriginal.Location = New System.Drawing.Point(321, 34)
        Me.txtDescricaoItemOriginal.MaxLength = 120
        Me.txtDescricaoItemOriginal.Name = "txtDescricaoItemOriginal"
        Me.txtDescricaoItemOriginal.ReadOnly = True
        Me.txtDescricaoItemOriginal.Size = New System.Drawing.Size(413, 20)
        Me.txtDescricaoItemOriginal.TabIndex = 8
        Me.txtDescricaoItemOriginal.TabStop = False
        '
        'trvMain
        '
        Me.trvMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trvMain.CheckBoxes = True
        Me.trvMain.FullRowSelect = True
        Me.trvMain.ItemHeight = 20
        Me.trvMain.Location = New System.Drawing.Point(8, 226)
        Me.trvMain.Name = "trvMain"
        Me.trvMain.ShowLines = False
        Me.trvMain.ShowNodeToolTips = True
        Me.trvMain.Size = New System.Drawing.Size(897, 254)
        Me.trvMain.TabIndex = 2
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnImprimirRelatorio)
        Me.grpControl.Controls.Add(Me.btnRecolher)
        Me.grpControl.Controls.Add(Me.btnExpandir)
        Me.grpControl.Controls.Add(Me.btnImprimir)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(235, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(670, 51)
        Me.grpControl.TabIndex = 3
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnImprimirRelatorio
        '
        Me.btnImprimirRelatorio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirRelatorio.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimirRelatorio.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimirRelatorio.Location = New System.Drawing.Point(342, 17)
        Me.btnImprimirRelatorio.Name = "btnImprimirRelatorio"
        Me.btnImprimirRelatorio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimirRelatorio.Size = New System.Drawing.Size(108, 23)
        Me.btnImprimirRelatorio.TabIndex = 5
        Me.btnImprimirRelatorio.Text = "Imprimir Relatório"
        Me.btnImprimirRelatorio.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnRecolher
        '
        Me.btnRecolher.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRecolher.Image = Global.INTERACTI.My.Resources.Resources.resize
        Me.btnRecolher.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnRecolher.Location = New System.Drawing.Point(103, 17)
        Me.btnRecolher.Name = "btnRecolher"
        Me.btnRecolher.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnRecolher.Size = New System.Drawing.Size(91, 23)
        Me.btnRecolher.TabIndex = 4
        Me.btnRecolher.Text = "Recolher"
        Me.btnRecolher.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExpandir
        '
        Me.btnExpandir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExpandir.Image = Global.INTERACTI.My.Resources.Resources.cadastro_basico
        Me.btnExpandir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExpandir.Location = New System.Drawing.Point(6, 17)
        Me.btnExpandir.Name = "btnExpandir"
        Me.btnExpandir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExpandir.Size = New System.Drawing.Size(91, 23)
        Me.btnExpandir.TabIndex = 3
        Me.btnExpandir.Text = "Expandir"
        Me.btnExpandir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(456, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimir.Size = New System.Drawing.Size(108, 23)
        Me.btnImprimir.TabIndex = 0
        Me.btnImprimir.Text = "Gerar Tabela"
        Me.btnImprimir.Visible = False
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(570, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblSC
        '
        Me.lblSC.AutoSize = True
        Me.lblSC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSC.Location = New System.Drawing.Point(213, 102)
        Me.lblSC.Name = "lblSC"
        Me.lblSC.Size = New System.Drawing.Size(24, 14)
        Me.lblSC.TabIndex = 20
        Me.lblSC.Text = "SC:"
        '
        'txtSC
        '
        Me.txtSC.DecimalDigits = 0
        Me.txtSC.FormatString = "00"
        Me.txtSC.Location = New System.Drawing.Point(216, 119)
        Me.txtSC.MaxLength = 2
        Me.txtSC.Name = "txtSC"
        Me.txtSC.Size = New System.Drawing.Size(54, 20)
        Me.txtSC.TabIndex = 21
        Me.txtSC.Text = "00"
        Me.txtSC.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtDET
        '
        Me.txtDET.DecimalDigits = 0
        Me.txtDET.FormatString = "000"
        Me.txtDET.Location = New System.Drawing.Point(276, 119)
        Me.txtDET.MaxLength = 3
        Me.txtDET.Name = "txtDET"
        Me.txtDET.Size = New System.Drawing.Size(54, 20)
        Me.txtDET.TabIndex = 23
        Me.txtDET.Text = "000"
        Me.txtDET.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblDET
        '
        Me.lblDET.AutoSize = True
        Me.lblDET.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDET.Location = New System.Drawing.Point(273, 102)
        Me.lblDET.Name = "lblDET"
        Me.lblDET.Size = New System.Drawing.Size(28, 14)
        Me.lblDET.TabIndex = 22
        Me.lblDET.Text = "DET:"
        '
        'lblMP
        '
        Me.lblMP.AutoSize = True
        Me.lblMP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMP.Location = New System.Drawing.Point(333, 102)
        Me.lblMP.Name = "lblMP"
        Me.lblMP.Size = New System.Drawing.Size(24, 14)
        Me.lblMP.TabIndex = 24
        Me.lblMP.Text = "MP:"
        '
        'txtMP
        '
        Me.txtMP.BackColor = System.Drawing.Color.White
        Me.txtMP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMP.Location = New System.Drawing.Point(336, 119)
        Me.txtMP.MaxLength = 2
        Me.txtMP.Name = "txtMP"
        Me.txtMP.Size = New System.Drawing.Size(62, 20)
        Me.txtMP.TabIndex = 25
        '
        'usrCadProdutoBOM2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadProdutoBOM2"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaItemFantasma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaGeraOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaMPHD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpDadosMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosMaterial.ResumeLayout(False)
        Me.grpDadosMaterial.PerformLayout()
        CType(Me.grpFind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFind.ResumeLayout(False)
        Me.grpFind.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents trvMain As System.Windows.Forms.TreeView
    Friend WithEvents grpDadosMaterial As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTipoItem As System.Windows.Forms.Label
    Friend WithEvents cboTipoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnProcurarItemOriginal As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarUnidadeMedida As System.Windows.Forms.Button
    Friend WithEvents lblUnidadeMedida As System.Windows.Forms.Label
    Friend WithEvents cboUnidadeMedida As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoItemOriginal As System.Windows.Forms.Label
    Friend WithEvents cboCodigoItemOriginal As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDescricaoItemOriginal As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoItemOriginal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnProcurarItem As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarItem As System.Windows.Forms.Button
    Friend WithEvents lblCodigoItem As System.Windows.Forms.Label
    Friend WithEvents cboCodigoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDescricaoItem As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents cboCodigoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoProduto As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents lblReferencia As System.Windows.Forms.Label
    Friend WithEvents txtReferencia As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaItemFantasma As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaItemFantasma As System.Windows.Forms.Label
    Friend WithEvents picLegendaGeraOP As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaGeraOP As System.Windows.Forms.Label
    Friend WithEvents picLegendaMPHD As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaMPHD As System.Windows.Forms.Label
    Friend WithEvents btnLocalizar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnRecolher As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExpandir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblFind As System.Windows.Forms.Label
    Friend WithEvents txtFind As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnImportarEstrutura As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFind As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovoMaterial As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnImprimirRelatorio As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblPosicao As System.Windows.Forms.Label
    Friend WithEvents txtPosicao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMP As System.Windows.Forms.Label
    Friend WithEvents txtMP As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDET As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDET As System.Windows.Forms.Label
    Friend WithEvents txtSC As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblSC As System.Windows.Forms.Label

End Class
