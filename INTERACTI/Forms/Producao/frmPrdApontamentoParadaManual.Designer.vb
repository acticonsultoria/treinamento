<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrdApontamentoParadaManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrdApontamentoParadaManual))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpDadosVendaCliente = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarGrupoMotivoParada = New System.Windows.Forms.Button()
        Me.lblGrupoMotivoParada = New System.Windows.Forms.Label()
        Me.cboGrupoMotivoParada = New Janus.Windows.EditControls.UIComboBox()
        Me.txtTempoParada = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnCadastrarMotivoParada = New System.Windows.Forms.Button()
        Me.cboMotivoParada = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMotivoParada = New System.Windows.Forms.Label()
        Me.lblTempoParada = New System.Windows.Forms.Label()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtFuncionario = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.txtOperacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOperacao = New System.Windows.Forms.Label()
        Me.txtCentroTrabalho = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCentroTrabalho = New System.Windows.Forms.Label()
        Me.txtOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducao = New System.Windows.Forms.Label()
        Me.grdApontamentoParada = New Janus.Windows.GridEX.GridEX()
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
        CType(Me.grdApontamentoParada, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'grpDadosVendaCliente
        '
        Me.grpDadosVendaCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosVendaCliente.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosVendaCliente.Controls.Add(Me.btnCadastrarGrupoMotivoParada)
        Me.grpDadosVendaCliente.Controls.Add(Me.lblGrupoMotivoParada)
        Me.grpDadosVendaCliente.Controls.Add(Me.cboGrupoMotivoParada)
        Me.grpDadosVendaCliente.Controls.Add(Me.txtTempoParada)
        Me.grpDadosVendaCliente.Controls.Add(Me.btnCadastrarMotivoParada)
        Me.grpDadosVendaCliente.Controls.Add(Me.cboMotivoParada)
        Me.grpDadosVendaCliente.Controls.Add(Me.lblMotivoParada)
        Me.grpDadosVendaCliente.Controls.Add(Me.lblTempoParada)
        Me.grpDadosVendaCliente.Controls.Add(Me.btnExcluir)
        Me.grpDadosVendaCliente.Controls.Add(Me.btnInserir)
        Me.grpDadosVendaCliente.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosVendaCliente.Location = New System.Drawing.Point(8, 70)
        Me.grpDadosVendaCliente.Name = "grpDadosVendaCliente"
        Me.grpDadosVendaCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosVendaCliente.Size = New System.Drawing.Size(909, 64)
        Me.grpDadosVendaCliente.TabIndex = 1
        Me.grpDadosVendaCliente.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarGrupoMotivoParada
        '
        Me.btnCadastrarGrupoMotivoParada.FlatAppearance.BorderSize = 0
        Me.btnCadastrarGrupoMotivoParada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarGrupoMotivoParada.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarGrupoMotivoParada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarGrupoMotivoParada.Location = New System.Drawing.Point(115, 18)
        Me.btnCadastrarGrupoMotivoParada.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarGrupoMotivoParada.Name = "btnCadastrarGrupoMotivoParada"
        Me.btnCadastrarGrupoMotivoParada.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarGrupoMotivoParada.TabIndex = 2
        Me.btnCadastrarGrupoMotivoParada.TabStop = False
        Me.btnCadastrarGrupoMotivoParada.UseVisualStyleBackColor = True
        '
        'lblGrupoMotivoParada
        '
        Me.lblGrupoMotivoParada.AutoSize = True
        Me.lblGrupoMotivoParada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGrupoMotivoParada.Location = New System.Drawing.Point(131, 17)
        Me.lblGrupoMotivoParada.Name = "lblGrupoMotivoParada"
        Me.lblGrupoMotivoParada.Size = New System.Drawing.Size(133, 14)
        Me.lblGrupoMotivoParada.TabIndex = 3
        Me.lblGrupoMotivoParada.Text = "Grupo - Motivo de Parada:"
        '
        'cboGrupoMotivoParada
        '
        Me.cboGrupoMotivoParada.Location = New System.Drawing.Point(115, 34)
        Me.cboGrupoMotivoParada.Name = "cboGrupoMotivoParada"
        Me.cboGrupoMotivoParada.Size = New System.Drawing.Size(276, 20)
        Me.cboGrupoMotivoParada.TabIndex = 4
        '
        'txtTempoParada
        '
        Me.txtTempoParada.Location = New System.Drawing.Point(9, 34)
        Me.txtTempoParada.Mask = "00:00:00"
        Me.txtTempoParada.Name = "txtTempoParada"
        Me.txtTempoParada.Size = New System.Drawing.Size(100, 20)
        Me.txtTempoParada.TabIndex = 1
        Me.txtTempoParada.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'btnCadastrarMotivoParada
        '
        Me.btnCadastrarMotivoParada.FlatAppearance.BorderSize = 0
        Me.btnCadastrarMotivoParada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarMotivoParada.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarMotivoParada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarMotivoParada.Location = New System.Drawing.Point(397, 18)
        Me.btnCadastrarMotivoParada.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarMotivoParada.Name = "btnCadastrarMotivoParada"
        Me.btnCadastrarMotivoParada.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarMotivoParada.TabIndex = 5
        Me.btnCadastrarMotivoParada.TabStop = False
        Me.btnCadastrarMotivoParada.UseVisualStyleBackColor = True
        '
        'cboMotivoParada
        '
        Me.cboMotivoParada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMotivoParada.Location = New System.Drawing.Point(397, 34)
        Me.cboMotivoParada.Name = "cboMotivoParada"
        Me.cboMotivoParada.Size = New System.Drawing.Size(251, 20)
        Me.cboMotivoParada.TabIndex = 7
        '
        'lblMotivoParada
        '
        Me.lblMotivoParada.AutoSize = True
        Me.lblMotivoParada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMotivoParada.Location = New System.Drawing.Point(413, 17)
        Me.lblMotivoParada.Name = "lblMotivoParada"
        Me.lblMotivoParada.Size = New System.Drawing.Size(93, 14)
        Me.lblMotivoParada.TabIndex = 6
        Me.lblMotivoParada.Text = "Motivo de Parada:"
        '
        'lblTempoParada
        '
        Me.lblTempoParada.AutoSize = True
        Me.lblTempoParada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTempoParada.Location = New System.Drawing.Point(6, 17)
        Me.lblTempoParada.Name = "lblTempoParada"
        Me.lblTempoParada.Size = New System.Drawing.Size(78, 14)
        Me.lblTempoParada.TabIndex = 0
        Me.lblTempoParada.Text = "Tempo Parada:"
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
        Me.btnExcluir.TabIndex = 9
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
        Me.btnInserir.TabIndex = 8
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtFuncionario)
        Me.grpDados.Controls.Add(Me.lblFuncionario)
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
        'txtFuncionario
        '
        Me.txtFuncionario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFuncionario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFuncionario.Location = New System.Drawing.Point(656, 34)
        Me.txtFuncionario.MaxLength = 20
        Me.txtFuncionario.Name = "txtFuncionario"
        Me.txtFuncionario.ReadOnly = True
        Me.txtFuncionario.Size = New System.Drawing.Size(244, 20)
        Me.txtFuncionario.TabIndex = 11
        Me.txtFuncionario.TabStop = False
        '
        'lblFuncionario
        '
        Me.lblFuncionario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.Location = New System.Drawing.Point(653, 17)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(66, 14)
        Me.lblFuncionario.TabIndex = 10
        Me.lblFuncionario.Text = "Funcionário:"
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
        Me.txtOperacao.Size = New System.Drawing.Size(253, 20)
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
        Me.grdApontamentoParada.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdApontamentoParada.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdApontamentoParada.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdApontamentoParada.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdApontamentoParada.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdApontamentoParada.FrozenColumns = 3
        Me.grdApontamentoParada.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdApontamentoParada.GroupByBoxVisible = False
        Me.grdApontamentoParada.Location = New System.Drawing.Point(8, 144)
        Me.grdApontamentoParada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdApontamentoParada.Name = "grdApontamentoParada"
        Me.grdApontamentoParada.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdApontamentoParada.RecordNavigator = True
        Me.grdApontamentoParada.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdApontamentoParada.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdApontamentoParada.Size = New System.Drawing.Size(909, 336)
        Me.grdApontamentoParada.TabIndex = 2
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
        'frmPrdApontamentoParadaManual
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
        Me.Name = "frmPrdApontamentoParadaManual"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Apontamento de Produção - Rejeito"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpDadosVendaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosVendaCliente.ResumeLayout(False)
        Me.grpDadosVendaCliente.PerformLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grdApontamentoParada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControlFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControlFiltro.ResumeLayout(False)
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
    Friend WithEvents lblTempoParada As System.Windows.Forms.Label
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtFuncionario As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
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
    Friend WithEvents btnCadastrarGrupoMotivoParada As System.Windows.Forms.Button
    Friend WithEvents lblGrupoMotivoParada As System.Windows.Forms.Label
    Friend WithEvents cboGrupoMotivoParada As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtTempoParada As Janus.Windows.GridEX.EditControls.MaskedEditBox
End Class
