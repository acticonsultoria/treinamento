<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrdApontamentoParada
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
        Dim grdApontamentoParada_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdApontamentoParada_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrdApontamentoParada))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.grpDadosVendaCliente = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboMotivoParada = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMotivoParada = New System.Windows.Forms.Label()
        Me.dtpDataReabertura = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataReabertura = New System.Windows.Forms.Label()
        Me.dtpDataParada = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataParada = New System.Windows.Forms.Label()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtFuncionario = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.txtDataTermino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataTermino = New System.Windows.Forms.Label()
        Me.txtDataInicio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.txtOperacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOperacao = New System.Windows.Forms.Label()
        Me.txtCentroTrabalho = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCentroTrabalho = New System.Windows.Forms.Label()
        Me.txtOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducao = New System.Windows.Forms.Label()
        Me.grdApontamentoParada = New Janus.Windows.GridEX.GridEX()
        Me.grpControlFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.btnCadastrarMotivoParada = New System.Windows.Forms.Button()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        CType(Me.grpDadosVendaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosVendaCliente.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grdApontamentoParada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControlFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControlFiltro.SuspendLayout()
        Me.pagLista.SuspendLayout()
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
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(927, 566)
        Me.tabMain.TabIndex = 1
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'grpDadosVendaCliente
        '
        Me.grpDadosVendaCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosVendaCliente.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosVendaCliente.Controls.Add(Me.btnCadastrarMotivoParada)
        Me.grpDadosVendaCliente.Controls.Add(Me.cboMotivoParada)
        Me.grpDadosVendaCliente.Controls.Add(Me.lblMotivoParada)
        Me.grpDadosVendaCliente.Controls.Add(Me.dtpDataReabertura)
        Me.grpDadosVendaCliente.Controls.Add(Me.lblDataReabertura)
        Me.grpDadosVendaCliente.Controls.Add(Me.dtpDataParada)
        Me.grpDadosVendaCliente.Controls.Add(Me.lblDataParada)
        Me.grpDadosVendaCliente.Controls.Add(Me.btnExcluir)
        Me.grpDadosVendaCliente.Controls.Add(Me.btnInserir)
        Me.grpDadosVendaCliente.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosVendaCliente.Location = New System.Drawing.Point(8, 110)
        Me.grpDadosVendaCliente.Name = "grpDadosVendaCliente"
        Me.grpDadosVendaCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosVendaCliente.Size = New System.Drawing.Size(909, 64)
        Me.grpDadosVendaCliente.TabIndex = 1
        Me.grpDadosVendaCliente.VisualStyleManager = Me.vsmMain
        '
        'cboMotivoParada
        '
        Me.cboMotivoParada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMotivoParada.Location = New System.Drawing.Point(321, 34)
        Me.cboMotivoParada.Name = "cboMotivoParada"
        Me.cboMotivoParada.Size = New System.Drawing.Size(327, 20)
        Me.cboMotivoParada.TabIndex = 6
        '
        'lblMotivoParada
        '
        Me.lblMotivoParada.AutoSize = True
        Me.lblMotivoParada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMotivoParada.Location = New System.Drawing.Point(337, 17)
        Me.lblMotivoParada.Name = "lblMotivoParada"
        Me.lblMotivoParada.Size = New System.Drawing.Size(93, 14)
        Me.lblMotivoParada.TabIndex = 5
        Me.lblMotivoParada.Text = "Motivo da Parada:"
        '
        'dtpDataReabertura
        '
        Me.dtpDataReabertura.DateFormat = Janus.Windows.CalendarCombo.DateFormat.DateTime
        '
        '
        '
        Me.dtpDataReabertura.DropDownCalendar.Name = ""
        Me.dtpDataReabertura.Location = New System.Drawing.Point(165, 34)
        Me.dtpDataReabertura.Name = "dtpDataReabertura"
        Me.dtpDataReabertura.ShowCheckBox = True
        Me.dtpDataReabertura.Size = New System.Drawing.Size(150, 20)
        Me.dtpDataReabertura.TabIndex = 2
        Me.dtpDataReabertura.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataReabertura
        '
        Me.lblDataReabertura.AutoSize = True
        Me.lblDataReabertura.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataReabertura.Location = New System.Drawing.Point(162, 17)
        Me.lblDataReabertura.Name = "lblDataReabertura"
        Me.lblDataReabertura.Size = New System.Drawing.Size(89, 14)
        Me.lblDataReabertura.TabIndex = 3
        Me.lblDataReabertura.Text = "Data Reabertura:"
        '
        'dtpDataParada
        '
        Me.dtpDataParada.DateFormat = Janus.Windows.CalendarCombo.DateFormat.DateTime
        '
        '
        '
        Me.dtpDataParada.DropDownCalendar.Name = ""
        Me.dtpDataParada.Location = New System.Drawing.Point(9, 34)
        Me.dtpDataParada.Name = "dtpDataParada"
        Me.dtpDataParada.Size = New System.Drawing.Size(150, 20)
        Me.dtpDataParada.TabIndex = 1
        Me.dtpDataParada.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDataParada
        '
        Me.lblDataParada.AutoSize = True
        Me.lblDataParada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataParada.Location = New System.Drawing.Point(6, 17)
        Me.lblDataParada.Name = "lblDataParada"
        Me.lblDataParada.Size = New System.Drawing.Size(69, 14)
        Me.lblDataParada.TabIndex = 0
        Me.lblDataParada.Text = "Data Parada:"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtFuncionario)
        Me.grpDados.Controls.Add(Me.lblFuncionario)
        Me.grpDados.Controls.Add(Me.txtDataTermino)
        Me.grpDados.Controls.Add(Me.lblDataTermino)
        Me.grpDados.Controls.Add(Me.txtDataInicio)
        Me.grpDados.Controls.Add(Me.lblDataInicio)
        Me.grpDados.Controls.Add(Me.txtOperacao)
        Me.grpDados.Controls.Add(Me.lblOperacao)
        Me.grpDados.Controls.Add(Me.txtCentroTrabalho)
        Me.grpDados.Controls.Add(Me.lblCentroTrabalho)
        Me.grpDados.Controls.Add(Me.txtOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblOrdemProducao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(909, 104)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtFuncionario
        '
        Me.txtFuncionario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFuncionario.Location = New System.Drawing.Point(9, 74)
        Me.txtFuncionario.MaxLength = 20
        Me.txtFuncionario.Name = "txtFuncionario"
        Me.txtFuncionario.ReadOnly = True
        Me.txtFuncionario.Size = New System.Drawing.Size(382, 20)
        Me.txtFuncionario.TabIndex = 11
        Me.txtFuncionario.TabStop = False
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.Location = New System.Drawing.Point(6, 57)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(66, 14)
        Me.lblFuncionario.TabIndex = 10
        Me.lblFuncionario.Text = "Funcionário:"
        '
        'txtDataTermino
        '
        Me.txtDataTermino.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDataTermino.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataTermino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataTermino.Location = New System.Drawing.Point(780, 34)
        Me.txtDataTermino.MaxLength = 20
        Me.txtDataTermino.Name = "txtDataTermino"
        Me.txtDataTermino.ReadOnly = True
        Me.txtDataTermino.Size = New System.Drawing.Size(120, 20)
        Me.txtDataTermino.TabIndex = 9
        Me.txtDataTermino.TabStop = False
        '
        'lblDataTermino
        '
        Me.lblDataTermino.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataTermino.AutoSize = True
        Me.lblDataTermino.Location = New System.Drawing.Point(777, 17)
        Me.lblDataTermino.Name = "lblDataTermino"
        Me.lblDataTermino.Size = New System.Drawing.Size(73, 14)
        Me.lblDataTermino.TabIndex = 8
        Me.lblDataTermino.Text = "Data Término:"
        '
        'txtDataInicio
        '
        Me.txtDataInicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDataInicio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataInicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataInicio.Location = New System.Drawing.Point(654, 34)
        Me.txtDataInicio.MaxLength = 20
        Me.txtDataInicio.Name = "txtDataInicio"
        Me.txtDataInicio.ReadOnly = True
        Me.txtDataInicio.Size = New System.Drawing.Size(120, 20)
        Me.txtDataInicio.TabIndex = 7
        Me.txtDataInicio.TabStop = False
        '
        'lblDataInicio
        '
        Me.lblDataInicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.Location = New System.Drawing.Point(651, 17)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(59, 14)
        Me.lblDataInicio.TabIndex = 6
        Me.lblDataInicio.Text = "Data Início:"
        '
        'txtOperacao
        '
        Me.txtOperacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOperacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOperacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOperacao.Location = New System.Drawing.Point(397, 34)
        Me.txtOperacao.MaxLength = 20
        Me.txtOperacao.Name = "txtOperacao"
        Me.txtOperacao.ReadOnly = True
        Me.txtOperacao.Size = New System.Drawing.Size(251, 20)
        Me.txtOperacao.TabIndex = 5
        Me.txtOperacao.TabStop = False
        '
        'lblOperacao
        '
        Me.lblOperacao.AutoSize = True
        Me.lblOperacao.Location = New System.Drawing.Point(394, 17)
        Me.lblOperacao.Name = "lblOperacao"
        Me.lblOperacao.Size = New System.Drawing.Size(58, 14)
        Me.lblOperacao.TabIndex = 4
        Me.lblOperacao.Text = "Operação:"
        '
        'txtCentroTrabalho
        '
        Me.txtCentroTrabalho.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCentroTrabalho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCentroTrabalho.Location = New System.Drawing.Point(115, 34)
        Me.txtCentroTrabalho.MaxLength = 20
        Me.txtCentroTrabalho.Name = "txtCentroTrabalho"
        Me.txtCentroTrabalho.ReadOnly = True
        Me.txtCentroTrabalho.Size = New System.Drawing.Size(276, 20)
        Me.txtCentroTrabalho.TabIndex = 2
        Me.txtCentroTrabalho.TabStop = False
        '
        'lblCentroTrabalho
        '
        Me.lblCentroTrabalho.AutoSize = True
        Me.lblCentroTrabalho.Location = New System.Drawing.Point(112, 17)
        Me.lblCentroTrabalho.Name = "lblCentroTrabalho"
        Me.lblCentroTrabalho.Size = New System.Drawing.Size(102, 14)
        Me.lblCentroTrabalho.TabIndex = 3
        Me.lblCentroTrabalho.Text = "Centro de Trabalho:"
        '
        'txtOrdemProducao
        '
        Me.txtOrdemProducao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdemProducao.Location = New System.Drawing.Point(9, 34)
        Me.txtOrdemProducao.MaxLength = 20
        Me.txtOrdemProducao.Name = "txtOrdemProducao"
        Me.txtOrdemProducao.ReadOnly = True
        Me.txtOrdemProducao.Size = New System.Drawing.Size(100, 20)
        Me.txtOrdemProducao.TabIndex = 1
        Me.txtOrdemProducao.TabStop = False
        '
        'lblOrdemProducao
        '
        Me.lblOrdemProducao.AutoSize = True
        Me.lblOrdemProducao.Location = New System.Drawing.Point(6, 17)
        Me.lblOrdemProducao.Name = "lblOrdemProducao"
        Me.lblOrdemProducao.Size = New System.Drawing.Size(91, 14)
        Me.lblOrdemProducao.TabIndex = 0
        Me.lblOrdemProducao.Text = "Ordem Produção:"
        '
        'grdApontamentoParada
        '
        Me.grdApontamentoParada.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdApontamentoParada.AlternatingColors = True
        Me.grdApontamentoParada.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdApontamentoParada.ColumnAutoResize = True
        grdApontamentoParada_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdApontamentoParada_DesignTimeLayout_Reference_0.Instance"), Object)
        grdApontamentoParada_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdApontamentoParada_DesignTimeLayout_Reference_0})
        grdApontamentoParada_DesignTimeLayout.LayoutString = resources.GetString("grdApontamentoParada_DesignTimeLayout.LayoutString")
        Me.grdApontamentoParada.DesignTimeLayout = grdApontamentoParada_DesignTimeLayout
        Me.grdApontamentoParada.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdApontamentoParada.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdApontamentoParada.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdApontamentoParada.FrozenColumns = 3
        Me.grdApontamentoParada.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdApontamentoParada.GroupByBoxVisible = False
        Me.grdApontamentoParada.Location = New System.Drawing.Point(8, 183)
        Me.grdApontamentoParada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdApontamentoParada.Name = "grdApontamentoParada"
        Me.grdApontamentoParada.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdApontamentoParada.RecordNavigator = True
        Me.grdApontamentoParada.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdApontamentoParada.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdApontamentoParada.Size = New System.Drawing.Size(909, 297)
        Me.grdApontamentoParada.TabIndex = 2
        Me.grdApontamentoParada.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdApontamentoParada.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdApontamentoParada.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdApontamentoParada.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdApontamentoParada.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdApontamentoParada.VisualStyleManager = Me.vsmMain
        '
        'grpControlFiltro
        '
        Me.grpControlFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControlFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpControlFiltro.Controls.Add(Me.btnNovo)
        Me.grpControlFiltro.Controls.Add(Me.btnSair)
        Me.grpControlFiltro.Location = New System.Drawing.Point(8, 483)
        Me.grpControlFiltro.Name = "grpControlFiltro"
        Me.grpControlFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControlFiltro.Size = New System.Drawing.Size(909, 51)
        Me.grpControlFiltro.TabIndex = 3
        Me.grpControlFiltro.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grpDadosVendaCliente)
        Me.pagLista.Controls.Add(Me.grpDados)
        Me.pagLista.Controls.Add(Me.grdApontamentoParada)
        Me.pagLista.Controls.Add(Me.grpControlFiltro)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(925, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Apontamento de Produção - Parada"
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 16
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 15
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'btnCadastrarMotivoParada
        '
        Me.btnCadastrarMotivoParada.FlatAppearance.BorderSize = 0
        Me.btnCadastrarMotivoParada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarMotivoParada.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarMotivoParada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarMotivoParada.Location = New System.Drawing.Point(321, 18)
        Me.btnCadastrarMotivoParada.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarMotivoParada.Name = "btnCadastrarMotivoParada"
        Me.btnCadastrarMotivoParada.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarMotivoParada.TabIndex = 4
        Me.btnCadastrarMotivoParada.TabStop = False
        Me.btnCadastrarMotivoParada.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(809, 31)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 8
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(712, 31)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 7
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(712, 18)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(809, 18)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmPrdApontamentoParada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 581)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrdApontamentoParada"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Apontamento de Produção - Rejeito"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        CType(Me.grpDadosVendaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosVendaCliente.ResumeLayout(False)
        Me.grpDadosVendaCliente.PerformLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grdApontamentoParada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControlFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControlFiltro.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grpDadosVendaCliente As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarMotivoParada As System.Windows.Forms.Button
    Friend WithEvents cboMotivoParada As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMotivoParada As System.Windows.Forms.Label
    Friend WithEvents dtpDataReabertura As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataReabertura As System.Windows.Forms.Label
    Friend WithEvents dtpDataParada As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataParada As System.Windows.Forms.Label
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtFuncionario As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents txtDataTermino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataTermino As System.Windows.Forms.Label
    Friend WithEvents txtDataInicio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataInicio As System.Windows.Forms.Label
    Friend WithEvents txtOperacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOperacao As System.Windows.Forms.Label
    Friend WithEvents txtCentroTrabalho As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCentroTrabalho As System.Windows.Forms.Label
    Friend WithEvents txtOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents grdApontamentoParada As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpControlFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
End Class
