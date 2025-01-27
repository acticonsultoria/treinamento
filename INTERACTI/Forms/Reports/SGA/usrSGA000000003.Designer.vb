<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrSGA000000003
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrSGA000000003))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.picSistema = New System.Windows.Forms.PictureBox()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkImprimirProtocolo = New Janus.Windows.EditControls.UICheckBox()
        Me.optImprimirSomenteEntregaFisica = New System.Windows.Forms.RadioButton()
        Me.optImprimirTodos = New System.Windows.Forms.RadioButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.txtMensagem = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblMensagem = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.cboCliente = New Janus.Windows.EditControls.UIComboBox()
        Me.txtCodigoCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoCliente = New System.Windows.Forms.Label()
        Me.cboDataTermino = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataTermino = New System.Windows.Forms.Label()
        Me.cboDataInicial = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.cboEmpresa = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDataInicial = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVisualizarImpressaoSeparado = New Janus.Windows.EditControls.UIButton()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.lblAtivo = New System.Windows.Forms.Label()
        Me.cboAtivo = New Janus.Windows.EditControls.UIComboBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(553, 608)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.picSistema)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(551, 585)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório SGA - Impressão de Planilhas"
        '
        'picSistema
        '
        Me.picSistema.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picSistema.BackColor = System.Drawing.Color.White
        Me.picSistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSistema.Image = Global.INTERACTI.My.Resources.Resources.interacti
        Me.picSistema.Location = New System.Drawing.Point(8, 8)
        Me.picSistema.Name = "picSistema"
        Me.picSistema.Size = New System.Drawing.Size(535, 109)
        Me.picSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSistema.TabIndex = 15
        Me.picSistema.TabStop = False
        '
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblAtivo)
        Me.grpFiltro.Controls.Add(Me.cboAtivo)
        Me.grpFiltro.Controls.Add(Me.chkImprimirProtocolo)
        Me.grpFiltro.Controls.Add(Me.optImprimirSomenteEntregaFisica)
        Me.grpFiltro.Controls.Add(Me.optImprimirTodos)
        Me.grpFiltro.Controls.Add(Me.grdListagem)
        Me.grpFiltro.Controls.Add(Me.txtMensagem)
        Me.grpFiltro.Controls.Add(Me.lblMensagem)
        Me.grpFiltro.Controls.Add(Me.lblCliente)
        Me.grpFiltro.Controls.Add(Me.cboCliente)
        Me.grpFiltro.Controls.Add(Me.txtCodigoCliente)
        Me.grpFiltro.Controls.Add(Me.lblCodigoCliente)
        Me.grpFiltro.Controls.Add(Me.cboDataTermino)
        Me.grpFiltro.Controls.Add(Me.lblDataTermino)
        Me.grpFiltro.Controls.Add(Me.cboDataInicial)
        Me.grpFiltro.Controls.Add(Me.lblEmpresa)
        Me.grpFiltro.Controls.Add(Me.cboEmpresa)
        Me.grpFiltro.Controls.Add(Me.lblDataInicial)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 120)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(535, 396)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'chkImprimirProtocolo
        '
        Me.chkImprimirProtocolo.Checked = True
        Me.chkImprimirProtocolo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkImprimirProtocolo.Location = New System.Drawing.Point(392, 80)
        Me.chkImprimirProtocolo.Name = "chkImprimirProtocolo"
        Me.chkImprimirProtocolo.Size = New System.Drawing.Size(119, 18)
        Me.chkImprimirProtocolo.TabIndex = 18
        Me.chkImprimirProtocolo.Text = "Imprimir Protocolos"
        '
        'optImprimirSomenteEntregaFisica
        '
        Me.optImprimirSomenteEntregaFisica.AutoSize = True
        Me.optImprimirSomenteEntregaFisica.Checked = True
        Me.optImprimirSomenteEntregaFisica.Location = New System.Drawing.Point(320, 34)
        Me.optImprimirSomenteEntregaFisica.Name = "optImprimirSomenteEntregaFisica"
        Me.optImprimirSomenteEntregaFisica.Size = New System.Drawing.Size(174, 18)
        Me.optImprimirSomenteEntregaFisica.TabIndex = 20
        Me.optImprimirSomenteEntregaFisica.TabStop = True
        Me.optImprimirSomenteEntregaFisica.Text = "Imprimir somente entrega física"
        Me.optImprimirSomenteEntregaFisica.UseVisualStyleBackColor = True
        '
        'optImprimirTodos
        '
        Me.optImprimirTodos.AutoSize = True
        Me.optImprimirTodos.Location = New System.Drawing.Point(223, 34)
        Me.optImprimirTodos.Name = "optImprimirTodos"
        Me.optImprimirTodos.Size = New System.Drawing.Size(91, 18)
        Me.optImprimirTodos.TabIndex = 19
        Me.optImprimirTodos.Text = "Imprimir todos"
        Me.optImprimirTodos.UseVisualStyleBackColor = True
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.AutoEdit = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.DynamicFiltering = True
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 2
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(10, 227)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(516, 160)
        Me.grdListagem.TabIndex = 18
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdListagem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'txtMensagem
        '
        Me.txtMensagem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMensagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMensagem.Location = New System.Drawing.Point(10, 161)
        Me.txtMensagem.MaxLength = 0
        Me.txtMensagem.Multiline = True
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensagem.Size = New System.Drawing.Size(516, 60)
        Me.txtMensagem.TabIndex = 17
        '
        'lblMensagem
        '
        Me.lblMensagem.AutoSize = True
        Me.lblMensagem.Location = New System.Drawing.Point(7, 144)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(62, 14)
        Me.lblMensagem.TabIndex = 16
        Me.lblMensagem.Text = "Mensagem:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(101, 101)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 14
        Me.lblCliente.Text = "Cliente:"
        '
        'cboCliente
        '
        Me.cboCliente.AutoSize = False
        Me.cboCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCliente.Location = New System.Drawing.Point(104, 118)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCliente.Size = New System.Drawing.Size(422, 20)
        Me.cboCliente.TabIndex = 15
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoCliente.Location = New System.Drawing.Point(10, 118)
        Me.txtCodigoCliente.MaxLength = 50
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(88, 20)
        Me.txtCodigoCliente.TabIndex = 13
        '
        'lblCodigoCliente
        '
        Me.lblCodigoCliente.AutoSize = True
        Me.lblCodigoCliente.Location = New System.Drawing.Point(7, 101)
        Me.lblCodigoCliente.Name = "lblCodigoCliente"
        Me.lblCodigoCliente.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigoCliente.TabIndex = 12
        Me.lblCodigoCliente.Text = "Código:"
        '
        'cboDataTermino
        '
        Me.cboDataTermino.CustomFormat = "MMM, yyyy"
        Me.cboDataTermino.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.cboDataTermino.DropDownCalendar.Name = ""
        Me.cboDataTermino.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cboDataTermino.Location = New System.Drawing.Point(114, 34)
        Me.cboDataTermino.Name = "cboDataTermino"
        Me.cboDataTermino.Size = New System.Drawing.Size(99, 20)
        Me.cboDataTermino.TabIndex = 11
        Me.cboDataTermino.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataTermino
        '
        Me.lblDataTermino.AutoSize = True
        Me.lblDataTermino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataTermino.Location = New System.Drawing.Point(111, 17)
        Me.lblDataTermino.Name = "lblDataTermino"
        Me.lblDataTermino.Size = New System.Drawing.Size(73, 14)
        Me.lblDataTermino.TabIndex = 10
        Me.lblDataTermino.Text = "Data Término:"
        '
        'cboDataInicial
        '
        Me.cboDataInicial.CustomFormat = "MMM, yyyy"
        Me.cboDataInicial.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.cboDataInicial.DropDownCalendar.Name = ""
        Me.cboDataInicial.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cboDataInicial.Location = New System.Drawing.Point(9, 34)
        Me.cboDataInicial.Name = "cboDataInicial"
        Me.cboDataInicial.Size = New System.Drawing.Size(99, 20)
        Me.cboDataInicial.TabIndex = 9
        Me.cboDataInicial.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEmpresa.Location = New System.Drawing.Point(7, 61)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(52, 14)
        Me.lblEmpresa.TabIndex = 4
        Me.lblEmpresa.Text = "Empresa:"
        '
        'cboEmpresa
        '
        Me.cboEmpresa.AutoSize = False
        Me.cboEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEmpresa.Location = New System.Drawing.Point(9, 78)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboEmpresa.Size = New System.Drawing.Size(291, 20)
        Me.cboEmpresa.TabIndex = 5
        '
        'lblDataInicial
        '
        Me.lblDataInicial.AutoSize = True
        Me.lblDataInicial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataInicial.Location = New System.Drawing.Point(6, 17)
        Me.lblDataInicial.Name = "lblDataInicial"
        Me.lblDataInicial.Size = New System.Drawing.Size(61, 14)
        Me.lblDataInicial.TabIndex = 0
        Me.lblDataInicial.Text = "Data Inicial:"
        '
        'grpControl
        '
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnVisualizarImpressaoSeparado)
        Me.grpControl.Controls.Add(Me.btnVisualizarImpressao)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 522)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(535, 56)
        Me.grpControl.TabIndex = 1
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnVisualizarImpressaoSeparado
        '
        Me.btnVisualizarImpressaoSeparado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarImpressaoSeparado.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnVisualizarImpressaoSeparado.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarImpressaoSeparado.Location = New System.Drawing.Point(223, 23)
        Me.btnVisualizarImpressaoSeparado.Name = "btnVisualizarImpressaoSeparado"
        Me.btnVisualizarImpressaoSeparado.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarImpressaoSeparado.Size = New System.Drawing.Size(206, 23)
        Me.btnVisualizarImpressaoSeparado.TabIndex = 2
        Me.btnVisualizarImpressaoSeparado.Text = "Imprimir Faturas/Protocolos Em Lote"
        Me.btnVisualizarImpressaoSeparado.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVisualizarImpressao
        '
        Me.btnVisualizarImpressao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarImpressao.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnVisualizarImpressao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarImpressao.Location = New System.Drawing.Point(14, 22)
        Me.btnVisualizarImpressao.Name = "btnVisualizarImpressao"
        Me.btnVisualizarImpressao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarImpressao.Size = New System.Drawing.Size(203, 23)
        Me.btnVisualizarImpressao.TabIndex = 0
        Me.btnVisualizarImpressao.Text = "Imprimir Faturas/Protocolos Avulso"
        Me.btnVisualizarImpressao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(435, 23)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblAtivo
        '
        Me.lblAtivo.AutoSize = True
        Me.lblAtivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAtivo.Location = New System.Drawing.Point(303, 61)
        Me.lblAtivo.Name = "lblAtivo"
        Me.lblAtivo.Size = New System.Drawing.Size(41, 14)
        Me.lblAtivo.TabIndex = 22
        Me.lblAtivo.Text = "Ativos:"
        '
        'cboAtivo
        '
        Me.cboAtivo.AutoSize = False
        Me.cboAtivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAtivo.Location = New System.Drawing.Point(306, 78)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAtivo.Size = New System.Drawing.Size(78, 20)
        Me.cboAtivo.TabIndex = 21
        '
        'usrSGA000000003
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrSGA000000003"
        Me.Size = New System.Drawing.Size(553, 608)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataInicial As System.Windows.Forms.Label
    Friend WithEvents picSistema As System.Windows.Forms.PictureBox
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents cboEmpresa As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnVisualizarImpressao As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboDataInicial As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboDataTermino As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataTermino As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents cboCliente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtCodigoCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoCliente As System.Windows.Forms.Label
    Friend WithEvents txtMensagem As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblMensagem As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents optImprimirTodos As System.Windows.Forms.RadioButton
    Friend WithEvents optImprimirSomenteEntregaFisica As System.Windows.Forms.RadioButton
    Friend WithEvents chkImprimirProtocolo As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents btnVisualizarImpressaoSeparado As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblAtivo As System.Windows.Forms.Label
    Friend WithEvents cboAtivo As Janus.Windows.EditControls.UIComboBox

End Class
