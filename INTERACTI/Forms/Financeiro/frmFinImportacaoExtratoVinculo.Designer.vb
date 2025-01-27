<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinImportacaoExtratoVinculo
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
        Dim grdVinculo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdVinculo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinImportacaoExtratoVinculo))
        Dim grdVinculo_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdVinculo = New Janus.Windows.GridEX.GridEX()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboBancoContaTransferencia = New Janus.Windows.EditControls.UIComboBox()
        Me.lblBancoContaTransferencia = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtTipo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtDataEmissao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVincular = New Janus.Windows.EditControls.UIButton()
        Me.btnCadastrarDocumento = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpCriteriosIntervalos = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblVinculado = New System.Windows.Forms.Label()
        Me.cboVinculado = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTituloFinanceiro = New System.Windows.Forms.Label()
        Me.txtValorCriterio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboTituloFinanceiro = New Janus.Windows.EditControls.UIComboBox()
        Me.txtDataCriterio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.chkValor = New Janus.Windows.EditControls.UICheckBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.chkData = New Janus.Windows.EditControls.UICheckBox()
        Me.dtpDataTermino = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataVencimentoFiltro = New System.Windows.Forms.Label()
        Me.dtpDataInicio = New Janus.Windows.CalendarCombo.CalendarCombo()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grdVinculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpCriteriosIntervalos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCriteriosIntervalos.SuspendLayout()
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
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(767, 407)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.btnExcelGrid)
        Me.pagTabela.Controls.Add(Me.btnAgruparGrid)
        Me.pagTabela.Controls.Add(Me.btnConfigurarGrid)
        Me.pagTabela.Controls.Add(Me.grdVinculo)
        Me.pagTabela.Controls.Add(Me.grpDados)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Controls.Add(Me.grpCriteriosIntervalos)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(765, 384)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Vínculo"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 304)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 25
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 304)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 24
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 304)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 11
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdVinculo
        '
        Me.grdVinculo.AlternatingColors = True
        Me.grdVinculo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdVinculo.AutoEdit = True
        Me.grdVinculo.ColumnAutoResize = True
        grdVinculo_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdVinculo_DesignTimeLayout_Reference_0.Instance"), Object)
        grdVinculo_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdVinculo_DesignTimeLayout_Reference_1.Instance"), Object)
        grdVinculo_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdVinculo_DesignTimeLayout_Reference_0, grdVinculo_DesignTimeLayout_Reference_1})
        grdVinculo_DesignTimeLayout.LayoutString = resources.GetString("grdVinculo_DesignTimeLayout.LayoutString")
        Me.grdVinculo.DesignTimeLayout = grdVinculo_DesignTimeLayout
        Me.grdVinculo.DynamicFiltering = True
        Me.grdVinculo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdVinculo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdVinculo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdVinculo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdVinculo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdVinculo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdVinculo.GroupByBoxVisible = False
        Me.grdVinculo.Hierarchical = True
        Me.grdVinculo.Location = New System.Drawing.Point(8, 191)
        Me.grdVinculo.Name = "grdVinculo"
        Me.grdVinculo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdVinculo.RecordNavigator = True
        Me.grdVinculo.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdVinculo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdVinculo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdVinculo.Size = New System.Drawing.Size(749, 130)
        Me.grdVinculo.TabIndex = 3
        Me.grdVinculo.TabStop = False
        Me.grdVinculo.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdVinculo.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdVinculo.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdVinculo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdVinculo.VisualStyleManager = Me.vsmMain
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.cboBancoContaTransferencia)
        Me.grpDados.Controls.Add(Me.lblBancoContaTransferencia)
        Me.grpDados.Controls.Add(Me.lblTipo)
        Me.grpDados.Controls.Add(Me.txtTipo)
        Me.grpDados.Controls.Add(Me.lblData)
        Me.grpDados.Controls.Add(Me.lblValor)
        Me.grpDados.Controls.Add(Me.txtDataEmissao)
        Me.grpDados.Controls.Add(Me.txtValor)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblNumeroDocumento)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Controls.Add(Me.txtNumeroDocumento)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(749, 108)
        Me.grpDados.TabIndex = 0
        Me.grpDados.Text = "Dados do Arquivo"
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'cboBancoContaTransferencia
        '
        Me.cboBancoContaTransferencia.AutoSize = False
        Me.cboBancoContaTransferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboBancoContaTransferencia.Location = New System.Drawing.Point(7, 74)
        Me.cboBancoContaTransferencia.Name = "cboBancoContaTransferencia"
        Me.cboBancoContaTransferencia.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboBancoContaTransferencia.Size = New System.Drawing.Size(472, 20)
        Me.cboBancoContaTransferencia.TabIndex = 12
        '
        'lblBancoContaTransferencia
        '
        Me.lblBancoContaTransferencia.AutoSize = True
        Me.lblBancoContaTransferencia.Location = New System.Drawing.Point(4, 57)
        Me.lblBancoContaTransferencia.Name = "lblBancoContaTransferencia"
        Me.lblBancoContaTransferencia.Size = New System.Drawing.Size(170, 14)
        Me.lblBancoContaTransferencia.TabIndex = 10
        Me.lblBancoContaTransferencia.Text = "Conta Bancária de Transferência:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(564, 17)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 14)
        Me.lblTipo.TabIndex = 4
        Me.lblTipo.Text = "Tipo:"
        '
        'txtTipo
        '
        Me.txtTipo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipo.Location = New System.Drawing.Point(567, 34)
        Me.txtTipo.MaxLength = 250
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(89, 20)
        Me.txtTipo.TabIndex = 5
        Me.txtTipo.TabStop = False
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(482, 17)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(32, 14)
        Me.lblData.TabIndex = 2
        Me.lblData.Text = "Data:"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(659, 17)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(35, 14)
        Me.lblValor.TabIndex = 8
        Me.lblValor.Text = "Valor:"
        '
        'txtDataEmissao
        '
        Me.txtDataEmissao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataEmissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataEmissao.Location = New System.Drawing.Point(485, 34)
        Me.txtDataEmissao.MaxLength = 250
        Me.txtDataEmissao.Name = "txtDataEmissao"
        Me.txtDataEmissao.ReadOnly = True
        Me.txtDataEmissao.Size = New System.Drawing.Size(76, 20)
        Me.txtDataEmissao.TabIndex = 3
        Me.txtDataEmissao.TabStop = False
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor.Location = New System.Drawing.Point(662, 34)
        Me.txtValor.MaxLength = 250
        Me.txtValor.Name = "txtValor"
        Me.txtValor.ReadOnly = True
        Me.txtValor.Size = New System.Drawing.Size(83, 20)
        Me.txtValor.TabIndex = 7
        Me.txtValor.TabStop = False
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(113, 34)
        Me.txtDescricao.MaxLength = 250
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(366, 20)
        Me.txtDescricao.TabIndex = 6
        Me.txtDescricao.TabStop = False
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(3, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 0
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(113, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 9
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(6, 34)
        Me.txtNumeroDocumento.MaxLength = 250
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.ReadOnly = True
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(101, 20)
        Me.txtNumeroDocumento.TabIndex = 1
        Me.txtNumeroDocumento.TabStop = False
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnVincular)
        Me.grpControl2.Controls.Add(Me.btnCadastrarDocumento)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 324)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(749, 51)
        Me.grpControl2.TabIndex = 2
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnVincular
        '
        Me.btnVincular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVincular.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnVincular.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVincular.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnVincular.Location = New System.Drawing.Point(397, 17)
        Me.btnVincular.Name = "btnVincular"
        Me.btnVincular.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVincular.Size = New System.Drawing.Size(94, 23)
        Me.btnVincular.TabIndex = 4
        Me.btnVincular.Text = "Vincular"
        Me.btnVincular.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCadastrarDocumento
        '
        Me.btnCadastrarDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarDocumento.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnCadastrarDocumento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCadastrarDocumento.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnCadastrarDocumento.Location = New System.Drawing.Point(497, 17)
        Me.btnCadastrarDocumento.Name = "btnCadastrarDocumento"
        Me.btnCadastrarDocumento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCadastrarDocumento.Size = New System.Drawing.Size(146, 23)
        Me.btnCadastrarDocumento.TabIndex = 3
        Me.btnCadastrarDocumento.Text = "Cadastrar Documento"
        Me.btnCadastrarDocumento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(649, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpCriteriosIntervalos
        '
        Me.grpCriteriosIntervalos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCriteriosIntervalos.BackColor = System.Drawing.Color.Transparent
        Me.grpCriteriosIntervalos.Controls.Add(Me.dtpDataTermino)
        Me.grpCriteriosIntervalos.Controls.Add(Me.lblDataVencimentoFiltro)
        Me.grpCriteriosIntervalos.Controls.Add(Me.dtpDataInicio)
        Me.grpCriteriosIntervalos.Controls.Add(Me.lblVinculado)
        Me.grpCriteriosIntervalos.Controls.Add(Me.cboVinculado)
        Me.grpCriteriosIntervalos.Controls.Add(Me.lblTituloFinanceiro)
        Me.grpCriteriosIntervalos.Controls.Add(Me.txtValorCriterio)
        Me.grpCriteriosIntervalos.Controls.Add(Me.cboTituloFinanceiro)
        Me.grpCriteriosIntervalos.Controls.Add(Me.txtDataCriterio)
        Me.grpCriteriosIntervalos.Controls.Add(Me.chkValor)
        Me.grpCriteriosIntervalos.Controls.Add(Me.btnFiltrar)
        Me.grpCriteriosIntervalos.Controls.Add(Me.chkData)
        Me.grpCriteriosIntervalos.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpCriteriosIntervalos.Location = New System.Drawing.Point(8, 119)
        Me.grpCriteriosIntervalos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpCriteriosIntervalos.Name = "grpCriteriosIntervalos"
        Me.grpCriteriosIntervalos.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCriteriosIntervalos.Size = New System.Drawing.Size(749, 65)
        Me.grpCriteriosIntervalos.TabIndex = 14
        Me.grpCriteriosIntervalos.Text = "Critérios - Intervalos"
        Me.grpCriteriosIntervalos.VisualStyleManager = Me.vsmMain
        '
        'lblVinculado
        '
        Me.lblVinculado.AutoSize = True
        Me.lblVinculado.Location = New System.Drawing.Point(220, 41)
        Me.lblVinculado.Name = "lblVinculado"
        Me.lblVinculado.Size = New System.Drawing.Size(58, 14)
        Me.lblVinculado.TabIndex = 27
        Me.lblVinculado.Text = "Vinculado:"
        '
        'cboVinculado
        '
        Me.cboVinculado.AutoSize = False
        Me.cboVinculado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboVinculado.Location = New System.Drawing.Point(311, 39)
        Me.cboVinculado.Name = "cboVinculado"
        Me.cboVinculado.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboVinculado.Size = New System.Drawing.Size(152, 20)
        Me.cboVinculado.TabIndex = 28
        '
        'lblTituloFinanceiro
        '
        Me.lblTituloFinanceiro.AutoSize = True
        Me.lblTituloFinanceiro.Location = New System.Drawing.Point(220, 16)
        Me.lblTituloFinanceiro.Name = "lblTituloFinanceiro"
        Me.lblTituloFinanceiro.Size = New System.Drawing.Size(88, 14)
        Me.lblTituloFinanceiro.TabIndex = 10
        Me.lblTituloFinanceiro.Text = "Titulo Financeiro:"
        '
        'txtValorCriterio
        '
        Me.txtValorCriterio.DecimalDigits = 2
        Me.txtValorCriterio.Location = New System.Drawing.Point(113, 14)
        Me.txtValorCriterio.Name = "txtValorCriterio"
        Me.txtValorCriterio.Size = New System.Drawing.Size(99, 20)
        Me.txtValorCriterio.TabIndex = 26
        Me.txtValorCriterio.Text = "0,00"
        Me.txtValorCriterio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtValorCriterio.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'cboTituloFinanceiro
        '
        Me.cboTituloFinanceiro.AutoSize = False
        Me.cboTituloFinanceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTituloFinanceiro.Location = New System.Drawing.Point(311, 14)
        Me.cboTituloFinanceiro.Name = "cboTituloFinanceiro"
        Me.cboTituloFinanceiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTituloFinanceiro.Size = New System.Drawing.Size(152, 20)
        Me.cboTituloFinanceiro.TabIndex = 11
        '
        'txtDataCriterio
        '
        Me.txtDataCriterio.DecimalDigits = 0
        Me.txtDataCriterio.Location = New System.Drawing.Point(113, 39)
        Me.txtDataCriterio.Name = "txtDataCriterio"
        Me.txtDataCriterio.Size = New System.Drawing.Size(99, 20)
        Me.txtDataCriterio.TabIndex = 25
        Me.txtDataCriterio.Text = "0"
        Me.txtDataCriterio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtDataCriterio.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'chkValor
        '
        Me.chkValor.Location = New System.Drawing.Point(6, 16)
        Me.chkValor.Name = "chkValor"
        Me.chkValor.Size = New System.Drawing.Size(102, 16)
        Me.chkValor.TabIndex = 2
        Me.chkValor.Text = "Valor"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(649, 32)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 24
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'chkData
        '
        Me.chkData.Location = New System.Drawing.Point(6, 41)
        Me.chkData.Name = "chkData"
        Me.chkData.Size = New System.Drawing.Size(55, 16)
        Me.chkData.TabIndex = 3
        Me.chkData.Text = "Data"
        '
        'dtpDataTermino
        '
        '
        '
        '
        Me.dtpDataTermino.DropDownCalendar.Name = ""
        Me.dtpDataTermino.Location = New System.Drawing.Point(584, 39)
        Me.dtpDataTermino.Name = "dtpDataTermino"
        Me.dtpDataTermino.ShowCheckBox = True
        Me.dtpDataTermino.Size = New System.Drawing.Size(109, 20)
        Me.dtpDataTermino.TabIndex = 31
        '
        'lblDataVencimentoFiltro
        '
        Me.lblDataVencimentoFiltro.AutoSize = True
        Me.lblDataVencimentoFiltro.Location = New System.Drawing.Point(466, 22)
        Me.lblDataVencimentoFiltro.Name = "lblDataVencimentoFiltro"
        Me.lblDataVencimentoFiltro.Size = New System.Drawing.Size(91, 14)
        Me.lblDataVencimentoFiltro.TabIndex = 29
        Me.lblDataVencimentoFiltro.Text = "Data Vencimento:"
        '
        'dtpDataInicio
        '
        '
        '
        '
        Me.dtpDataInicio.DropDownCalendar.Name = ""
        Me.dtpDataInicio.Location = New System.Drawing.Point(469, 39)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.ShowCheckBox = True
        Me.dtpDataInicio.Size = New System.Drawing.Size(109, 20)
        Me.dtpDataInicio.TabIndex = 30
        '
        'frmFinImportacaoExtratoVinculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 422)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinImportacaoExtratoVinculo"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Importação Extrato - Vínculo"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grdVinculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpCriteriosIntervalos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCriteriosIntervalos.ResumeLayout(False)
        Me.grpCriteriosIntervalos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDataEmissao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtTipo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents chkValor As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkData As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents grpCriteriosIntervalos As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtValorCriterio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtDataCriterio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTituloFinanceiro As System.Windows.Forms.Label
    Friend WithEvents cboTituloFinanceiro As Janus.Windows.EditControls.UIComboBox
    Private WithEvents btnCadastrarDocumento As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboBancoContaTransferencia As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblBancoContaTransferencia As System.Windows.Forms.Label
    Friend WithEvents lblVinculado As System.Windows.Forms.Label
    Friend WithEvents cboVinculado As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdVinculo As Janus.Windows.GridEX.GridEX
    Private WithEvents btnVincular As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataTermino As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataVencimentoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataInicio As Janus.Windows.CalendarCombo.CalendarCombo
End Class
