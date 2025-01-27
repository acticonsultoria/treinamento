<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrdVisaoProducao
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
        Dim grdMaquinaAtual_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdVisaoProducao))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdMaquinaAtual = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnRetrair = New Janus.Windows.EditControls.UIButton()
        Me.btnExpandir = New Janus.Windows.EditControls.UIButton()
        Me.cboRecursoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblRecursoFiltro = New System.Windows.Forms.Label()
        Me.cboColaboradorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblColaboradorFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.cboProcessoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblProcessoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegenda5 = New System.Windows.Forms.Label()
        Me.picLegenda5 = New System.Windows.Forms.PictureBox()
        Me.lblLegenda6 = New System.Windows.Forms.Label()
        Me.picLegenda6 = New System.Windows.Forms.PictureBox()
        Me.lblLegenda3 = New System.Windows.Forms.Label()
        Me.picLegenda3 = New System.Windows.Forms.PictureBox()
        Me.lblLegenda2 = New System.Windows.Forms.Label()
        Me.picLegenda2 = New System.Windows.Forms.PictureBox()
        Me.lblLegenda4 = New System.Windows.Forms.Label()
        Me.picLegendaCancelado = New System.Windows.Forms.PictureBox()
        Me.lblLegenda1 = New System.Windows.Forms.Label()
        Me.picLegenda1 = New System.Windows.Forms.PictureBox()
        Me.jstMain = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.pagSintetico = New Janus.Windows.UI.Tab.UITabPage()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cboTipo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdMaquinaAtual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegenda5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegenda6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegenda3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegenda2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegenda1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(966, 459)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.grdMaquinaAtual)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(964, 436)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Visão da Produção"
        '
        'grdMaquinaAtual
        '
        Me.grdMaquinaAtual.AlternatingColors = True
        Me.grdMaquinaAtual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdMaquinaAtual.CardSpacing = 0
        Me.grdMaquinaAtual.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both
        grdMaquinaAtual_DesignTimeLayout.LayoutString = resources.GetString("grdMaquinaAtual_DesignTimeLayout.LayoutString")
        Me.grdMaquinaAtual.DesignTimeLayout = grdMaquinaAtual_DesignTimeLayout
        Me.grdMaquinaAtual.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdMaquinaAtual.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdMaquinaAtual.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdMaquinaAtual.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdMaquinaAtual.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdMaquinaAtual.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdMaquinaAtual.GroupByBoxVisible = False
        Me.grdMaquinaAtual.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdMaquinaAtual.Location = New System.Drawing.Point(9, 78)
        Me.grdMaquinaAtual.Name = "grdMaquinaAtual"
        Me.grdMaquinaAtual.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdMaquinaAtual.RecordNavigator = True
        Me.grdMaquinaAtual.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdMaquinaAtual.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdMaquinaAtual.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdMaquinaAtual.Size = New System.Drawing.Size(947, 352)
        Me.grdMaquinaAtual.TabIndex = 7
        Me.grdMaquinaAtual.TabStop = False
        Me.grdMaquinaAtual.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdMaquinaAtual.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdMaquinaAtual.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdMaquinaAtual.View = Janus.Windows.GridEX.View.CardView
        Me.grdMaquinaAtual.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdMaquinaAtual.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboTipo)
        Me.grpFiltro.Controls.Add(Me.lblTipo)
        Me.grpFiltro.Controls.Add(Me.btnRetrair)
        Me.grpFiltro.Controls.Add(Me.btnExpandir)
        Me.grpFiltro.Controls.Add(Me.cboRecursoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblRecursoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboColaboradorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblColaboradorFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.cboProcessoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblProcessoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(745, 69)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnRetrair
        '
        Me.btnRetrair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRetrair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnRetrair.Location = New System.Drawing.Point(648, 37)
        Me.btnRetrair.Name = "btnRetrair"
        Me.btnRetrair.Size = New System.Drawing.Size(91, 23)
        Me.btnRetrair.TabIndex = 21
        Me.btnRetrair.Tag = ""
        Me.btnRetrair.Text = "Retrair"
        Me.btnRetrair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExpandir
        '
        Me.btnExpandir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExpandir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExpandir.Location = New System.Drawing.Point(648, 14)
        Me.btnExpandir.Name = "btnExpandir"
        Me.btnExpandir.Size = New System.Drawing.Size(91, 23)
        Me.btnExpandir.TabIndex = 20
        Me.btnExpandir.Tag = ""
        Me.btnExpandir.Text = "Expandir"
        Me.btnExpandir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboRecursoFiltro
        '
        Me.cboRecursoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboRecursoFiltro.AutoSize = False
        Me.cboRecursoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboRecursoFiltro.Location = New System.Drawing.Point(402, 34)
        Me.cboRecursoFiltro.Name = "cboRecursoFiltro"
        Me.cboRecursoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboRecursoFiltro.Size = New System.Drawing.Size(48, 20)
        Me.cboRecursoFiltro.TabIndex = 19
        '
        'lblRecursoFiltro
        '
        Me.lblRecursoFiltro.AutoSize = True
        Me.lblRecursoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRecursoFiltro.Location = New System.Drawing.Point(399, 17)
        Me.lblRecursoFiltro.Name = "lblRecursoFiltro"
        Me.lblRecursoFiltro.Size = New System.Drawing.Size(51, 14)
        Me.lblRecursoFiltro.TabIndex = 18
        Me.lblRecursoFiltro.Text = "Recurso:"
        '
        'cboColaboradorFiltro
        '
        Me.cboColaboradorFiltro.AutoSize = False
        Me.cboColaboradorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboColaboradorFiltro.Location = New System.Drawing.Point(256, 34)
        Me.cboColaboradorFiltro.Name = "cboColaboradorFiltro"
        Me.cboColaboradorFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboColaboradorFiltro.Size = New System.Drawing.Size(140, 20)
        Me.cboColaboradorFiltro.TabIndex = 17
        '
        'lblColaboradorFiltro
        '
        Me.lblColaboradorFiltro.AutoSize = True
        Me.lblColaboradorFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColaboradorFiltro.Location = New System.Drawing.Point(253, 17)
        Me.lblColaboradorFiltro.Name = "lblColaboradorFiltro"
        Me.lblColaboradorFiltro.Size = New System.Drawing.Size(69, 14)
        Me.lblColaboradorFiltro.TabIndex = 16
        Me.lblColaboradorFiltro.Text = "Colaborador:"
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AutoSize = False
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboStatusFiltro.Location = New System.Drawing.Point(119, 34)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboStatusFiltro.Size = New System.Drawing.Size(131, 20)
        Me.cboStatusFiltro.TabIndex = 15
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStatusFiltro.Location = New System.Drawing.Point(116, 17)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 14
        Me.lblStatusFiltro.Text = "Status:"
        '
        'cboProcessoFiltro
        '
        Me.cboProcessoFiltro.AutoSize = False
        Me.cboProcessoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProcessoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.cboProcessoFiltro.Name = "cboProcessoFiltro"
        Me.cboProcessoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboProcessoFiltro.Size = New System.Drawing.Size(104, 20)
        Me.cboProcessoFiltro.TabIndex = 13
        '
        'lblProcessoFiltro
        '
        Me.lblProcessoFiltro.AutoSize = True
        Me.lblProcessoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblProcessoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblProcessoFiltro.Name = "lblProcessoFiltro"
        Me.lblProcessoFiltro.Size = New System.Drawing.Size(56, 14)
        Me.lblProcessoFiltro.TabIndex = 11
        Me.lblProcessoFiltro.Text = "Processo:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(541, 34)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 12
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegenda5)
        Me.grpLegenda.Controls.Add(Me.picLegenda5)
        Me.grpLegenda.Controls.Add(Me.lblLegenda6)
        Me.grpLegenda.Controls.Add(Me.picLegenda6)
        Me.grpLegenda.Controls.Add(Me.lblLegenda3)
        Me.grpLegenda.Controls.Add(Me.picLegenda3)
        Me.grpLegenda.Controls.Add(Me.lblLegenda2)
        Me.grpLegenda.Controls.Add(Me.picLegenda2)
        Me.grpLegenda.Controls.Add(Me.lblLegenda4)
        Me.grpLegenda.Controls.Add(Me.picLegendaCancelado)
        Me.grpLegenda.Controls.Add(Me.lblLegenda1)
        Me.grpLegenda.Controls.Add(Me.picLegenda1)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(759, 3)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(197, 68)
        Me.grpLegenda.TabIndex = 8
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegenda5
        '
        Me.lblLegenda5.AutoSize = True
        Me.lblLegenda5.Location = New System.Drawing.Point(28, 47)
        Me.lblLegenda5.Name = "lblLegenda5"
        Me.lblLegenda5.Size = New System.Drawing.Size(28, 14)
        Me.lblLegenda5.TabIndex = 21
        Me.lblLegenda5.Text = "RNC"
        '
        'picLegenda5
        '
        Me.picLegenda5.BackColor = System.Drawing.Color.Purple
        Me.picLegenda5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegenda5.Location = New System.Drawing.Point(9, 47)
        Me.picLegenda5.Name = "picLegenda5"
        Me.picLegenda5.Size = New System.Drawing.Size(13, 14)
        Me.picLegenda5.TabIndex = 24
        Me.picLegenda5.TabStop = False
        '
        'lblLegenda6
        '
        Me.lblLegenda6.AutoSize = True
        Me.lblLegenda6.Location = New System.Drawing.Point(115, 47)
        Me.lblLegenda6.Name = "lblLegenda6"
        Me.lblLegenda6.Size = New System.Drawing.Size(74, 14)
        Me.lblLegenda6.TabIndex = 22
        Me.lblLegenda6.Text = "Sem atividade"
        '
        'picLegenda6
        '
        Me.picLegenda6.BackColor = System.Drawing.Color.Black
        Me.picLegenda6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegenda6.Location = New System.Drawing.Point(96, 47)
        Me.picLegenda6.Name = "picLegenda6"
        Me.picLegenda6.Size = New System.Drawing.Size(13, 14)
        Me.picLegenda6.TabIndex = 23
        Me.picLegenda6.TabStop = False
        '
        'lblLegenda3
        '
        Me.lblLegenda3.AutoSize = True
        Me.lblLegenda3.Location = New System.Drawing.Point(115, 13)
        Me.lblLegenda3.Name = "lblLegenda3"
        Me.lblLegenda3.Size = New System.Drawing.Size(52, 14)
        Me.lblLegenda3.TabIndex = 1
        Me.lblLegenda3.Text = "Atrasado"
        '
        'picLegenda3
        '
        Me.picLegenda3.BackColor = System.Drawing.Color.Firebrick
        Me.picLegenda3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegenda3.Location = New System.Drawing.Point(96, 13)
        Me.picLegenda3.Name = "picLegenda3"
        Me.picLegenda3.Size = New System.Drawing.Size(13, 14)
        Me.picLegenda3.TabIndex = 20
        Me.picLegenda3.TabStop = False
        '
        'lblLegenda2
        '
        Me.lblLegenda2.AutoSize = True
        Me.lblLegenda2.Location = New System.Drawing.Point(28, 30)
        Me.lblLegenda2.Name = "lblLegenda2"
        Me.lblLegenda2.Size = New System.Drawing.Size(53, 14)
        Me.lblLegenda2.TabIndex = 2
        Me.lblLegenda2.Text = "Produção"
        '
        'picLegenda2
        '
        Me.picLegenda2.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegenda2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegenda2.Location = New System.Drawing.Point(9, 30)
        Me.picLegenda2.Name = "picLegenda2"
        Me.picLegenda2.Size = New System.Drawing.Size(13, 14)
        Me.picLegenda2.TabIndex = 18
        Me.picLegenda2.TabStop = False
        '
        'lblLegenda4
        '
        Me.lblLegenda4.AutoSize = True
        Me.lblLegenda4.Location = New System.Drawing.Point(115, 30)
        Me.lblLegenda4.Name = "lblLegenda4"
        Me.lblLegenda4.Size = New System.Drawing.Size(66, 14)
        Me.lblLegenda4.TabIndex = 3
        Me.lblLegenda4.Text = "Manutenção"
        '
        'picLegendaCancelado
        '
        Me.picLegendaCancelado.BackColor = System.Drawing.Color.DarkBlue
        Me.picLegendaCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCancelado.Location = New System.Drawing.Point(96, 30)
        Me.picLegendaCancelado.Name = "picLegendaCancelado"
        Me.picLegendaCancelado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCancelado.TabIndex = 16
        Me.picLegendaCancelado.TabStop = False
        '
        'lblLegenda1
        '
        Me.lblLegenda1.AutoSize = True
        Me.lblLegenda1.Location = New System.Drawing.Point(28, 13)
        Me.lblLegenda1.Name = "lblLegenda1"
        Me.lblLegenda1.Size = New System.Drawing.Size(35, 14)
        Me.lblLegenda1.TabIndex = 0
        Me.lblLegenda1.Text = "Setup"
        '
        'picLegenda1
        '
        Me.picLegenda1.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegenda1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegenda1.Location = New System.Drawing.Point(9, 13)
        Me.picLegenda1.Name = "picLegenda1"
        Me.picLegenda1.Size = New System.Drawing.Size(13, 14)
        Me.picLegenda1.TabIndex = 4
        Me.picLegenda1.TabStop = False
        '
        'jstMain
        '
        Me.jstMain.AutoPopDelay = 60000
        Me.jstMain.ImageList = Nothing
        Me.jstMain.ShowAlways = True
        '
        'pagSintetico
        '
        Me.pagSintetico.Location = New System.Drawing.Point(1, 22)
        Me.pagSintetico.Name = "pagSintetico"
        Me.pagSintetico.Size = New System.Drawing.Size(946, 291)
        Me.pagSintetico.TabStop = True
        Me.pagSintetico.Text = "Sintético"
        '
        'Timer1
        '
        '
        'cboTipo
        '
        Me.cboTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipo.AutoSize = False
        Me.cboTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipo.Location = New System.Drawing.Point(456, 34)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipo.Size = New System.Drawing.Size(79, 20)
        Me.cboTipo.TabIndex = 23
        '
        'lblTipo
        '
        Me.lblTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipo.AutoSize = True
        Me.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipo.Location = New System.Drawing.Point(453, 17)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 14)
        Me.lblTipo.TabIndex = 22
        Me.lblTipo.Text = "Tipo:"
        '
        'usrPrdVisaoProducao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrPrdVisaoProducao"
        Me.Size = New System.Drawing.Size(966, 459)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdMaquinaAtual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegenda5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegenda6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegenda3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegenda2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaCancelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegenda1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents jstMain As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents lblProcessoFiltro As System.Windows.Forms.Label
    Friend WithEvents pagSintetico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdMaquinaAtual As Janus.Windows.GridEX.GridEX
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cboProcessoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboRecursoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblRecursoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboColaboradorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblColaboradorFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegenda5 As System.Windows.Forms.Label
    Friend WithEvents picLegenda5 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegenda6 As System.Windows.Forms.Label
    Friend WithEvents picLegenda6 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegenda3 As System.Windows.Forms.Label
    Friend WithEvents picLegenda3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegenda2 As System.Windows.Forms.Label
    Friend WithEvents picLegenda2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegenda4 As System.Windows.Forms.Label
    Friend WithEvents picLegendaCancelado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegenda1 As System.Windows.Forms.Label
    Friend WithEvents picLegenda1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRetrair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExpandir As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboTipo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label

End Class
