<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrdApontamentoManual
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
        Dim grdApontamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdApontamento_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrdApontamentoManual))
        Dim grdApontamento_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpDadosVendaCliente = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboTurno = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.txtTempo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTempo = New System.Windows.Forms.Label()
        Me.lblQuantidadeRejeito = New System.Windows.Forms.Label()
        Me.txtQuantidadeRejeito = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeProduzida = New System.Windows.Forms.Label()
        Me.txtQuantidadeProduzida = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnCadastrarFuncionario = New System.Windows.Forms.Button()
        Me.cboFuncionario = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.dtpData = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.txtOperacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOperacao = New System.Windows.Forms.Label()
        Me.txtCentroTrabalho = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCentroTrabalho = New System.Windows.Forms.Label()
        Me.txtOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducao = New System.Windows.Forms.Label()
        Me.grdApontamento = New Janus.Windows.GridEX.GridEX()
        Me.grpControlFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpDadosVendaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosVendaCliente.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControlFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControlFiltro.SuspendLayout()
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
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grpDadosVendaCliente)
        Me.pagLista.Controls.Add(Me.grpDados)
        Me.pagLista.Controls.Add(Me.grdApontamento)
        Me.pagLista.Controls.Add(Me.grpControlFiltro)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(925, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Apontamento Manual"
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 4
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 3
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpDadosVendaCliente
        '
        Me.grpDadosVendaCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosVendaCliente.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosVendaCliente.Controls.Add(Me.cboTurno)
        Me.grpDadosVendaCliente.Controls.Add(Me.lblTurno)
        Me.grpDadosVendaCliente.Controls.Add(Me.txtTempo)
        Me.grpDadosVendaCliente.Controls.Add(Me.lblTempo)
        Me.grpDadosVendaCliente.Controls.Add(Me.lblQuantidadeRejeito)
        Me.grpDadosVendaCliente.Controls.Add(Me.txtQuantidadeRejeito)
        Me.grpDadosVendaCliente.Controls.Add(Me.lblQuantidadeProduzida)
        Me.grpDadosVendaCliente.Controls.Add(Me.txtQuantidadeProduzida)
        Me.grpDadosVendaCliente.Controls.Add(Me.btnCadastrarFuncionario)
        Me.grpDadosVendaCliente.Controls.Add(Me.cboFuncionario)
        Me.grpDadosVendaCliente.Controls.Add(Me.lblFuncionario)
        Me.grpDadosVendaCliente.Controls.Add(Me.lblData)
        Me.grpDadosVendaCliente.Controls.Add(Me.dtpData)
        Me.grpDadosVendaCliente.Controls.Add(Me.btnExcluir)
        Me.grpDadosVendaCliente.Controls.Add(Me.btnInserir)
        Me.grpDadosVendaCliente.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosVendaCliente.Location = New System.Drawing.Point(8, 70)
        Me.grpDadosVendaCliente.Name = "grpDadosVendaCliente"
        Me.grpDadosVendaCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosVendaCliente.Size = New System.Drawing.Size(909, 104)
        Me.grpDadosVendaCliente.TabIndex = 1
        Me.grpDadosVendaCliente.VisualStyleManager = Me.vsmMain
        '
        'cboTurno
        '
        Me.cboTurno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTurno.Location = New System.Drawing.Point(554, 34)
        Me.cboTurno.Name = "cboTurno"
        Me.cboTurno.Size = New System.Drawing.Size(226, 20)
        Me.cboTurno.TabIndex = 8
        '
        'lblTurno
        '
        Me.lblTurno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTurno.AutoSize = True
        Me.lblTurno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTurno.Location = New System.Drawing.Point(551, 17)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(38, 14)
        Me.lblTurno.TabIndex = 7
        Me.lblTurno.Text = "Turno:"
        '
        'txtTempo
        '
        Me.txtTempo.Location = New System.Drawing.Point(115, 34)
        Me.txtTempo.Mask = "00:00:00"
        Me.txtTempo.Name = "txtTempo"
        Me.txtTempo.Size = New System.Drawing.Size(100, 20)
        Me.txtTempo.TabIndex = 3
        Me.txtTempo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblTempo
        '
        Me.lblTempo.AutoSize = True
        Me.lblTempo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTempo.Location = New System.Drawing.Point(112, 17)
        Me.lblTempo.Name = "lblTempo"
        Me.lblTempo.Size = New System.Drawing.Size(41, 14)
        Me.lblTempo.TabIndex = 2
        Me.lblTempo.Text = "Tempo:"
        '
        'lblQuantidadeRejeito
        '
        Me.lblQuantidadeRejeito.AutoSize = True
        Me.lblQuantidadeRejeito.Location = New System.Drawing.Point(112, 57)
        Me.lblQuantidadeRejeito.Name = "lblQuantidadeRejeito"
        Me.lblQuantidadeRejeito.Size = New System.Drawing.Size(71, 14)
        Me.lblQuantidadeRejeito.TabIndex = 11
        Me.lblQuantidadeRejeito.Text = "Qtde. Rejeito:"
        '
        'txtQuantidadeRejeito
        '
        Me.txtQuantidadeRejeito.DecimalDigits = 4
        Me.txtQuantidadeRejeito.Location = New System.Drawing.Point(115, 74)
        Me.txtQuantidadeRejeito.Name = "txtQuantidadeRejeito"
        Me.txtQuantidadeRejeito.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeRejeito.TabIndex = 12
        Me.txtQuantidadeRejeito.Text = "0,0000"
        Me.txtQuantidadeRejeito.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeProduzida
        '
        Me.lblQuantidadeProduzida.AutoSize = True
        Me.lblQuantidadeProduzida.Location = New System.Drawing.Point(6, 57)
        Me.lblQuantidadeProduzida.Name = "lblQuantidadeProduzida"
        Me.lblQuantidadeProduzida.Size = New System.Drawing.Size(87, 14)
        Me.lblQuantidadeProduzida.TabIndex = 9
        Me.lblQuantidadeProduzida.Text = "Qtde. Produzida:"
        '
        'txtQuantidadeProduzida
        '
        Me.txtQuantidadeProduzida.DecimalDigits = 4
        Me.txtQuantidadeProduzida.Location = New System.Drawing.Point(9, 74)
        Me.txtQuantidadeProduzida.Name = "txtQuantidadeProduzida"
        Me.txtQuantidadeProduzida.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeProduzida.TabIndex = 10
        Me.txtQuantidadeProduzida.Text = "0,0000"
        Me.txtQuantidadeProduzida.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'btnCadastrarFuncionario
        '
        Me.btnCadastrarFuncionario.FlatAppearance.BorderSize = 0
        Me.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarFuncionario.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarFuncionario.Location = New System.Drawing.Point(221, 18)
        Me.btnCadastrarFuncionario.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario"
        Me.btnCadastrarFuncionario.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarFuncionario.TabIndex = 4
        Me.btnCadastrarFuncionario.TabStop = False
        Me.btnCadastrarFuncionario.UseVisualStyleBackColor = True
        '
        'cboFuncionario
        '
        Me.cboFuncionario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFuncionario.Location = New System.Drawing.Point(221, 34)
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Size = New System.Drawing.Size(327, 20)
        Me.cboFuncionario.TabIndex = 6
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFuncionario.Location = New System.Drawing.Point(237, 17)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(66, 14)
        Me.lblFuncionario.TabIndex = 5
        Me.lblFuncionario.Text = "Funcionário:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(6, 17)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(32, 14)
        Me.lblData.TabIndex = 0
        Me.lblData.Text = "Data:"
        '
        'dtpData
        '
        '
        '
        '
        Me.dtpData.DropDownCalendar.Name = ""
        Me.dtpData.Location = New System.Drawing.Point(9, 34)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(100, 20)
        Me.dtpData.TabIndex = 1
        Me.dtpData.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(809, 71)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 22
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(809, 42)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 21
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtProduto)
        Me.grpDados.Controls.Add(Me.lblProduto)
        Me.grpDados.Controls.Add(Me.txtOperacao)
        Me.grpDados.Controls.Add(Me.lblOperacao)
        Me.grpDados.Controls.Add(Me.txtCentroTrabalho)
        Me.grpDados.Controls.Add(Me.lblCentroTrabalho)
        Me.grpDados.Controls.Add(Me.txtOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblOrdemProducao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(909, 64)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtProduto
        '
        Me.txtProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.Location = New System.Drawing.Point(115, 34)
        Me.txtProduto.MaxLength = 20
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.ReadOnly = True
        Me.txtProduto.Size = New System.Drawing.Size(246, 20)
        Me.txtProduto.TabIndex = 3
        Me.txtProduto.TabStop = False
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(112, 17)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 2
        Me.lblProduto.Text = "Produto:"
        '
        'txtOperacao
        '
        Me.txtOperacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOperacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOperacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOperacao.Location = New System.Drawing.Point(649, 34)
        Me.txtOperacao.MaxLength = 20
        Me.txtOperacao.Name = "txtOperacao"
        Me.txtOperacao.ReadOnly = True
        Me.txtOperacao.Size = New System.Drawing.Size(251, 20)
        Me.txtOperacao.TabIndex = 7
        Me.txtOperacao.TabStop = False
        '
        'lblOperacao
        '
        Me.lblOperacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOperacao.AutoSize = True
        Me.lblOperacao.Location = New System.Drawing.Point(646, 17)
        Me.lblOperacao.Name = "lblOperacao"
        Me.lblOperacao.Size = New System.Drawing.Size(58, 14)
        Me.lblOperacao.TabIndex = 6
        Me.lblOperacao.Text = "Operação:"
        '
        'txtCentroTrabalho
        '
        Me.txtCentroTrabalho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCentroTrabalho.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCentroTrabalho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCentroTrabalho.Location = New System.Drawing.Point(367, 34)
        Me.txtCentroTrabalho.MaxLength = 20
        Me.txtCentroTrabalho.Name = "txtCentroTrabalho"
        Me.txtCentroTrabalho.ReadOnly = True
        Me.txtCentroTrabalho.Size = New System.Drawing.Size(276, 20)
        Me.txtCentroTrabalho.TabIndex = 5
        Me.txtCentroTrabalho.TabStop = False
        '
        'lblCentroTrabalho
        '
        Me.lblCentroTrabalho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCentroTrabalho.AutoSize = True
        Me.lblCentroTrabalho.Location = New System.Drawing.Point(364, 17)
        Me.lblCentroTrabalho.Name = "lblCentroTrabalho"
        Me.lblCentroTrabalho.Size = New System.Drawing.Size(102, 14)
        Me.lblCentroTrabalho.TabIndex = 4
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
        'grdApontamento
        '
        Me.grdApontamento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdApontamento.AlternatingColors = True
        Me.grdApontamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdApontamento.ColumnAutoResize = True
        grdApontamento_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdApontamento_DesignTimeLayout_Reference_0.Instance"), Object)
        grdApontamento_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdApontamento_DesignTimeLayout_Reference_1.Instance"), Object)
        grdApontamento_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdApontamento_DesignTimeLayout_Reference_0, grdApontamento_DesignTimeLayout_Reference_1})
        grdApontamento_DesignTimeLayout.LayoutString = resources.GetString("grdApontamento_DesignTimeLayout.LayoutString")
        Me.grdApontamento.DesignTimeLayout = grdApontamento_DesignTimeLayout
        Me.grdApontamento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdApontamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdApontamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdApontamento.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdApontamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdApontamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdApontamento.FrozenColumns = 2
        Me.grdApontamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdApontamento.GroupByBoxVisible = False
        Me.grdApontamento.Location = New System.Drawing.Point(8, 183)
        Me.grdApontamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdApontamento.Name = "grdApontamento"
        Me.grdApontamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdApontamento.RecordNavigator = True
        Me.grdApontamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdApontamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdApontamento.Size = New System.Drawing.Size(909, 297)
        Me.grdApontamento.TabIndex = 2
        Me.grdApontamento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdApontamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdApontamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdApontamento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdApontamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdApontamento.VisualStyleManager = Me.vsmMain
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
        Me.grpControlFiltro.TabIndex = 5
        Me.grpControlFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
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
        'frmPrdApontamentoManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 581)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmPrdApontamentoManual"
        Me.ShowInTaskbar = false
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Apontamento de Produção - Manual"
        CType(Me.tabMain,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabMain.ResumeLayout(false)
        Me.pagLista.ResumeLayout(false)
        CType(Me.grpDadosVendaCliente,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpDadosVendaCliente.ResumeLayout(false)
        Me.grpDadosVendaCliente.PerformLayout
        CType(Me.grpDados,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpDados.ResumeLayout(false)
        Me.grpDados.PerformLayout
        CType(Me.grdApontamento,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpControlFiltro,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpControlFiltro.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grpDadosVendaCliente As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpData As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents txtOperacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOperacao As System.Windows.Forms.Label
    Friend WithEvents txtCentroTrabalho As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCentroTrabalho As System.Windows.Forms.Label
    Friend WithEvents txtOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents grdApontamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpControlFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCadastrarFuncionario As System.Windows.Forms.Button
    Friend WithEvents cboFuncionario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents txtProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeRejeito As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeRejeito As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeProduzida As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeProduzida As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboTurno As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents txtTempo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTempo As System.Windows.Forms.Label
End Class
