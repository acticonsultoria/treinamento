<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenOrcamentoProduto
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenOrcamentoProduto))
        Dim grdProducao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdMateriaPrima_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdMateriaPrima_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdCusto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdCusto_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagProducao = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridProducao = New System.Windows.Forms.Button()
        Me.btnAgruparGridProducao = New System.Windows.Forms.Button()
        Me.btnConfigurarGridProducao = New System.Windows.Forms.Button()
        Me.grdProducao = New Janus.Windows.GridEX.GridEX()
        Me.grpProduto = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtRevisaoDesenho = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNCM = New System.Windows.Forms.Label()
        Me.cboNCM = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarNCM = New System.Windows.Forms.Button()
        Me.btnArquivoDesenho = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivoDesenho = New System.Windows.Forms.Label()
        Me.txtArquivoDesenho = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRevisaoDesenho = New System.Windows.Forms.Label()
        Me.txtDesenho = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDesenho = New System.Windows.Forms.Label()
        Me.lblGrupoItem = New System.Windows.Forms.Label()
        Me.cboGrupoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarGrupoItem = New System.Windows.Forms.Button()
        Me.lblUnidadeMedida = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.cboUnidadeMedida = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarUnidadeMedida = New System.Windows.Forms.Button()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.pagMateriaPrima = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridMateriaPrima = New System.Windows.Forms.Button()
        Me.grpMateriaPrima = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtMargemLucroMateriaPrima = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtValorTotalMateriaPrima = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTotalMateriaPrima = New System.Windows.Forms.Label()
        Me.txtValorUnitarioDescontoMateriaPrima = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnitarioDescontoMateriaPrima = New System.Windows.Forms.Label()
        Me.lblDescricaoProduto = New System.Windows.Forms.Label()
        Me.txtDescricaoMateriaPrima = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboMateriaPrima = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMateriaPrima = New System.Windows.Forms.Label()
        Me.txtCustoMedioMateriaPrima = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCustoMedioMateriaPrima = New System.Windows.Forms.Label()
        Me.lblMargemLucroMateriaPrima = New System.Windows.Forms.Label()
        Me.lblUnidadeMedidaMateriaPrima = New System.Windows.Forms.Label()
        Me.cboUnidadeMedidaMateriaPrima = New Janus.Windows.EditControls.UIComboBox()
        Me.txtQuantidadeMateriaPrima = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeMateriaPrima = New System.Windows.Forms.Label()
        Me.btnCadastrarUnidadeMedidaMateriaPrima = New System.Windows.Forms.Button()
        Me.btnProcurarMateriaPrima = New System.Windows.Forms.Button()
        Me.btnCadastrarMateriaPrima = New System.Windows.Forms.Button()
        Me.btnExcluirMateriaPrima = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirMateriaPrima = New Janus.Windows.EditControls.UIButton()
        Me.btnAgruparGridMateriaPrima = New System.Windows.Forms.Button()
        Me.btnConfigurarGridMateriaPrima = New System.Windows.Forms.Button()
        Me.grdMateriaPrima = New Janus.Windows.GridEX.GridEX()
        Me.pagSubContrato = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridCusto = New System.Windows.Forms.Button()
        Me.btnAgruparGridCusto = New System.Windows.Forms.Button()
        Me.btnConfigurarGridCusto = New System.Windows.Forms.Button()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblDescricaoCusto = New System.Windows.Forms.Label()
        Me.txtDescricaoCusto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboTipoCusto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoCusto = New System.Windows.Forms.Label()
        Me.txtValorCusto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorCusto = New System.Windows.Forms.Label()
        Me.btnExcluirCusto = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirCusto = New Janus.Windows.EditControls.UIButton()
        Me.grdCusto = New Janus.Windows.GridEX.GridEX()
        Me.pagCalculo = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpCalculo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorIR = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.txtValorTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblLinha = New System.Windows.Forms.Label()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtValorTaxaFinanceira = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTaxaFinanceira = New System.Windows.Forms.Label()
        Me.txtTaxaFinanceira = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorSubtotal3 = New System.Windows.Forms.Label()
        Me.txtValorSubtotal3 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtValorCOFINS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtValorPIS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtValorICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaIR = New System.Windows.Forms.Label()
        Me.txtAliquotaIR = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaCOFINS = New System.Windows.Forms.Label()
        Me.txtAliquotaCOFINS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaPIS = New System.Windows.Forms.Label()
        Me.txtAliquotaPIS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaICMS = New System.Windows.Forms.Label()
        Me.txtAliquotaICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorMateriaPrima = New System.Windows.Forms.Label()
        Me.txtValorMateriaPrima = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorSubtotal2 = New System.Windows.Forms.Label()
        Me.txtValorSubtotal2 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtValorMargem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMargem = New System.Windows.Forms.Label()
        Me.txtMargem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorSubtotal1 = New System.Windows.Forms.Label()
        Me.txtValorSubtotal1 = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTransportadora = New System.Windows.Forms.Label()
        Me.txtValorTransportadora = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorSubcontrato = New System.Windows.Forms.Label()
        Me.txtValorSubcontrato = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorFerramentas = New System.Windows.Forms.Label()
        Me.txtValorFerramentas = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorPadronizados = New System.Windows.Forms.Label()
        Me.txtValorPadronizados = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorEmbalagem = New System.Windows.Forms.Label()
        Me.txtValorEmbalagem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTratamentoTermico = New System.Windows.Forms.Label()
        Me.txtValorTratamentoTermico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTratamentoSuperficial = New System.Windows.Forms.Label()
        Me.txtValorTratamentoSuperficial = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorPintura = New System.Windows.Forms.Label()
        Me.txtValorPintura = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorMaoObra = New System.Windows.Forms.Label()
        Me.txtValorMaoObra = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagProducao.SuspendLayout()
        CType(Me.grdProducao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProduto.SuspendLayout()
        Me.pagMateriaPrima.SuspendLayout()
        CType(Me.grpMateriaPrima, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMateriaPrima.SuspendLayout()
        CType(Me.grdMateriaPrima, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagSubContrato.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdCusto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagCalculo.SuspendLayout()
        CType(Me.grpCalculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCalculo.SuspendLayout()
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
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(970, 544)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Controls.Add(Me.tabDados)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(968, 521)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Dados do Produto"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 461)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(952, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(755, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(852, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 6)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(952, 452)
        Me.tabDados.TabIndex = 0
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagProducao, Me.pagMateriaPrima, Me.pagSubContrato, Me.pagCalculo})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagProducao
        '
        Me.pagProducao.Controls.Add(Me.btnExcelGridProducao)
        Me.pagProducao.Controls.Add(Me.btnAgruparGridProducao)
        Me.pagProducao.Controls.Add(Me.btnConfigurarGridProducao)
        Me.pagProducao.Controls.Add(Me.grdProducao)
        Me.pagProducao.Controls.Add(Me.grpProduto)
        Me.pagProducao.Key = "pagProducao"
        Me.pagProducao.Location = New System.Drawing.Point(1, 22)
        Me.pagProducao.Name = "pagProducao"
        Me.pagProducao.Size = New System.Drawing.Size(950, 429)
        Me.pagProducao.TabStop = True
        Me.pagProducao.Text = "Dados do Produto"
        '
        'btnExcelGridProducao
        '
        Me.btnExcelGridProducao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridProducao.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridProducao.FlatAppearance.BorderSize = 0
        Me.btnExcelGridProducao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridProducao.Image = CType(resources.GetObject("btnExcelGridProducao.Image"), System.Drawing.Image)
        Me.btnExcelGridProducao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridProducao.Location = New System.Drawing.Point(524, 403)
        Me.btnExcelGridProducao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridProducao.Name = "btnExcelGridProducao"
        Me.btnExcelGridProducao.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridProducao.TabIndex = 5
        Me.btnExcelGridProducao.TabStop = False
        Me.btnExcelGridProducao.UseVisualStyleBackColor = False
        '
        'btnAgruparGridProducao
        '
        Me.btnAgruparGridProducao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridProducao.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridProducao.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridProducao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridProducao.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridProducao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridProducao.Location = New System.Drawing.Point(500, 403)
        Me.btnAgruparGridProducao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridProducao.Name = "btnAgruparGridProducao"
        Me.btnAgruparGridProducao.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridProducao.TabIndex = 4
        Me.btnAgruparGridProducao.TabStop = False
        Me.btnAgruparGridProducao.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridProducao
        '
        Me.btnConfigurarGridProducao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridProducao.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridProducao.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridProducao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridProducao.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridProducao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridProducao.Location = New System.Drawing.Point(476, 403)
        Me.btnConfigurarGridProducao.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridProducao.Name = "btnConfigurarGridProducao"
        Me.btnConfigurarGridProducao.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridProducao.TabIndex = 3
        Me.btnConfigurarGridProducao.TabStop = False
        Me.btnConfigurarGridProducao.UseVisualStyleBackColor = False
        '
        'grdProducao
        '
        Me.grdProducao.AlternatingColors = True
        Me.grdProducao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProducao.AutoEdit = True
        Me.grdProducao.ColumnAutoResize = True
        grdProducao_DesignTimeLayout.LayoutString = resources.GetString("grdProducao_DesignTimeLayout.LayoutString")
        Me.grdProducao.DesignTimeLayout = grdProducao_DesignTimeLayout
        Me.grdProducao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdProducao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdProducao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProducao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProducao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProducao.GroupByBoxVisible = False
        Me.grdProducao.Location = New System.Drawing.Point(475, 9)
        Me.grdProducao.Name = "grdProducao"
        Me.grdProducao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProducao.RecordNavigator = True
        Me.grdProducao.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdProducao.SelectedFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdProducao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProducao.Size = New System.Drawing.Size(467, 411)
        Me.grdProducao.TabIndex = 2
        Me.grdProducao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProducao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdProducao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdProducao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdProducao.VisualStyleManager = Me.vsmMain
        '
        'grpProduto
        '
        Me.grpProduto.BackColor = System.Drawing.Color.Transparent
        Me.grpProduto.Controls.Add(Me.txtRevisaoDesenho)
        Me.grpProduto.Controls.Add(Me.lblNCM)
        Me.grpProduto.Controls.Add(Me.cboNCM)
        Me.grpProduto.Controls.Add(Me.btnCadastrarNCM)
        Me.grpProduto.Controls.Add(Me.btnArquivoDesenho)
        Me.grpProduto.Controls.Add(Me.lblArquivoDesenho)
        Me.grpProduto.Controls.Add(Me.txtArquivoDesenho)
        Me.grpProduto.Controls.Add(Me.lblRevisaoDesenho)
        Me.grpProduto.Controls.Add(Me.txtDesenho)
        Me.grpProduto.Controls.Add(Me.lblDesenho)
        Me.grpProduto.Controls.Add(Me.lblGrupoItem)
        Me.grpProduto.Controls.Add(Me.cboGrupoItem)
        Me.grpProduto.Controls.Add(Me.btnCadastrarGrupoItem)
        Me.grpProduto.Controls.Add(Me.lblUnidadeMedida)
        Me.grpProduto.Controls.Add(Me.lblDescricao)
        Me.grpProduto.Controls.Add(Me.cboUnidadeMedida)
        Me.grpProduto.Controls.Add(Me.btnCadastrarUnidadeMedida)
        Me.grpProduto.Controls.Add(Me.txtDescricao)
        Me.grpProduto.Controls.Add(Me.txtCodigo)
        Me.grpProduto.Controls.Add(Me.lblCodigo)
        Me.grpProduto.Location = New System.Drawing.Point(8, 3)
        Me.grpProduto.Name = "grpProduto"
        Me.grpProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpProduto.Size = New System.Drawing.Size(458, 224)
        Me.grpProduto.TabIndex = 0
        Me.grpProduto.VisualStyleManager = Me.vsmMain
        '
        'txtRevisaoDesenho
        '
        Me.txtRevisaoDesenho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRevisaoDesenho.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtRevisaoDesenho.Location = New System.Drawing.Point(376, 74)
        Me.txtRevisaoDesenho.MaxLength = 20
        Me.txtRevisaoDesenho.Name = "txtRevisaoDesenho"
        Me.txtRevisaoDesenho.Size = New System.Drawing.Size(73, 20)
        Me.txtRevisaoDesenho.TabIndex = 8
        '
        'lblNCM
        '
        Me.lblNCM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNCM.AutoSize = True
        Me.lblNCM.Location = New System.Drawing.Point(123, 177)
        Me.lblNCM.Name = "lblNCM"
        Me.lblNCM.Size = New System.Drawing.Size(32, 14)
        Me.lblNCM.TabIndex = 20
        Me.lblNCM.Text = "NCM:"
        '
        'cboNCM
        '
        Me.cboNCM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboNCM.AutoSize = False
        Me.cboNCM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNCM.Location = New System.Drawing.Point(107, 194)
        Me.cboNCM.Name = "cboNCM"
        Me.cboNCM.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNCM.Size = New System.Drawing.Size(106, 20)
        Me.cboNCM.TabIndex = 21
        '
        'btnCadastrarNCM
        '
        Me.btnCadastrarNCM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarNCM.FlatAppearance.BorderSize = 0
        Me.btnCadastrarNCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarNCM.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarNCM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarNCM.Location = New System.Drawing.Point(107, 178)
        Me.btnCadastrarNCM.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarNCM.Name = "btnCadastrarNCM"
        Me.btnCadastrarNCM.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarNCM.TabIndex = 19
        Me.btnCadastrarNCM.TabStop = False
        Me.btnCadastrarNCM.UseVisualStyleBackColor = True
        '
        'btnArquivoDesenho
        '
        Me.btnArquivoDesenho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivoDesenho.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivoDesenho.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnArquivoDesenho.Location = New System.Drawing.Point(429, 114)
        Me.btnArquivoDesenho.Name = "btnArquivoDesenho"
        Me.btnArquivoDesenho.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivoDesenho.Size = New System.Drawing.Size(20, 20)
        Me.btnArquivoDesenho.TabIndex = 11
        Me.btnArquivoDesenho.Text = "..."
        Me.btnArquivoDesenho.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivoDesenho
        '
        Me.lblArquivoDesenho.AutoSize = True
        Me.lblArquivoDesenho.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblArquivoDesenho.Location = New System.Drawing.Point(6, 97)
        Me.lblArquivoDesenho.Name = "lblArquivoDesenho"
        Me.lblArquivoDesenho.Size = New System.Drawing.Size(48, 14)
        Me.lblArquivoDesenho.TabIndex = 9
        Me.lblArquivoDesenho.Text = "Arquivo:"
        '
        'txtArquivoDesenho
        '
        Me.txtArquivoDesenho.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivoDesenho.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtArquivoDesenho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivoDesenho.Location = New System.Drawing.Point(9, 114)
        Me.txtArquivoDesenho.MaxLength = 500
        Me.txtArquivoDesenho.Name = "txtArquivoDesenho"
        Me.txtArquivoDesenho.ReadOnly = True
        Me.txtArquivoDesenho.Size = New System.Drawing.Size(421, 20)
        Me.txtArquivoDesenho.TabIndex = 10
        Me.txtArquivoDesenho.TabStop = False
        '
        'lblRevisaoDesenho
        '
        Me.lblRevisaoDesenho.AutoSize = True
        Me.lblRevisaoDesenho.Location = New System.Drawing.Point(373, 57)
        Me.lblRevisaoDesenho.Name = "lblRevisaoDesenho"
        Me.lblRevisaoDesenho.Size = New System.Drawing.Size(49, 14)
        Me.lblRevisaoDesenho.TabIndex = 7
        Me.lblRevisaoDesenho.Text = "Revisão:"
        '
        'txtDesenho
        '
        Me.txtDesenho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesenho.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtDesenho.Location = New System.Drawing.Point(169, 74)
        Me.txtDesenho.MaxLength = 20
        Me.txtDesenho.Name = "txtDesenho"
        Me.txtDesenho.Size = New System.Drawing.Size(201, 20)
        Me.txtDesenho.TabIndex = 6
        '
        'lblDesenho
        '
        Me.lblDesenho.AutoSize = True
        Me.lblDesenho.Location = New System.Drawing.Point(166, 57)
        Me.lblDesenho.Name = "lblDesenho"
        Me.lblDesenho.Size = New System.Drawing.Size(53, 14)
        Me.lblDesenho.TabIndex = 5
        Me.lblDesenho.Text = "Desenho:"
        '
        'lblGrupoItem
        '
        Me.lblGrupoItem.AutoSize = True
        Me.lblGrupoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGrupoItem.Location = New System.Drawing.Point(25, 17)
        Me.lblGrupoItem.Name = "lblGrupoItem"
        Me.lblGrupoItem.Size = New System.Drawing.Size(69, 14)
        Me.lblGrupoItem.TabIndex = 1
        Me.lblGrupoItem.Text = "Grupo - Item:"
        '
        'cboGrupoItem
        '
        Me.cboGrupoItem.AutoSize = False
        Me.cboGrupoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoItem.Location = New System.Drawing.Point(9, 34)
        Me.cboGrupoItem.Name = "cboGrupoItem"
        Me.cboGrupoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItem.Size = New System.Drawing.Size(439, 20)
        Me.cboGrupoItem.TabIndex = 2
        '
        'btnCadastrarGrupoItem
        '
        Me.btnCadastrarGrupoItem.FlatAppearance.BorderSize = 0
        Me.btnCadastrarGrupoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarGrupoItem.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarGrupoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarGrupoItem.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarGrupoItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarGrupoItem.Name = "btnCadastrarGrupoItem"
        Me.btnCadastrarGrupoItem.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarGrupoItem.TabIndex = 0
        Me.btnCadastrarGrupoItem.TabStop = False
        Me.btnCadastrarGrupoItem.UseVisualStyleBackColor = True
        '
        'lblUnidadeMedida
        '
        Me.lblUnidadeMedida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUnidadeMedida.AutoSize = True
        Me.lblUnidadeMedida.Location = New System.Drawing.Point(25, 177)
        Me.lblUnidadeMedida.Name = "lblUnidadeMedida"
        Me.lblUnidadeMedida.Size = New System.Drawing.Size(58, 14)
        Me.lblUnidadeMedida.TabIndex = 17
        Me.lblUnidadeMedida.Text = "Und. Med.:"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(6, 137)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 12
        Me.lblDescricao.Text = "Descrição:"
        '
        'cboUnidadeMedida
        '
        Me.cboUnidadeMedida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboUnidadeMedida.AutoSize = False
        Me.cboUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedida.Location = New System.Drawing.Point(9, 194)
        Me.cboUnidadeMedida.Name = "cboUnidadeMedida"
        Me.cboUnidadeMedida.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedida.Size = New System.Drawing.Size(92, 20)
        Me.cboUnidadeMedida.TabIndex = 18
        '
        'btnCadastrarUnidadeMedida
        '
        Me.btnCadastrarUnidadeMedida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarUnidadeMedida.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUnidadeMedida.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarUnidadeMedida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUnidadeMedida.Location = New System.Drawing.Point(9, 178)
        Me.btnCadastrarUnidadeMedida.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUnidadeMedida.Name = "btnCadastrarUnidadeMedida"
        Me.btnCadastrarUnidadeMedida.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarUnidadeMedida.TabIndex = 16
        Me.btnCadastrarUnidadeMedida.TabStop = False
        Me.btnCadastrarUnidadeMedida.UseVisualStyleBackColor = True
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(9, 154)
        Me.txtDescricao.MaxLength = 60
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(440, 20)
        Me.txtDescricao.TabIndex = 13
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtCodigo.Location = New System.Drawing.Point(9, 74)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(154, 20)
        Me.txtCodigo.TabIndex = 4
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(6, 57)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigo.TabIndex = 3
        Me.lblCodigo.Text = "Código:"
        '
        'pagMateriaPrima
        '
        Me.pagMateriaPrima.Controls.Add(Me.btnExcelGridMateriaPrima)
        Me.pagMateriaPrima.Controls.Add(Me.grpMateriaPrima)
        Me.pagMateriaPrima.Controls.Add(Me.btnAgruparGridMateriaPrima)
        Me.pagMateriaPrima.Controls.Add(Me.btnConfigurarGridMateriaPrima)
        Me.pagMateriaPrima.Controls.Add(Me.grdMateriaPrima)
        Me.pagMateriaPrima.Key = "pagMateriaPrima"
        Me.pagMateriaPrima.Location = New System.Drawing.Point(1, 22)
        Me.pagMateriaPrima.Name = "pagMateriaPrima"
        Me.pagMateriaPrima.Size = New System.Drawing.Size(950, 429)
        Me.pagMateriaPrima.TabStop = True
        Me.pagMateriaPrima.Text = "Matéria Prima"
        '
        'btnExcelGridMateriaPrima
        '
        Me.btnExcelGridMateriaPrima.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridMateriaPrima.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridMateriaPrima.FlatAppearance.BorderSize = 0
        Me.btnExcelGridMateriaPrima.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridMateriaPrima.Image = CType(resources.GetObject("btnExcelGridMateriaPrima.Image"), System.Drawing.Image)
        Me.btnExcelGridMateriaPrima.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridMateriaPrima.Location = New System.Drawing.Point(57, 403)
        Me.btnExcelGridMateriaPrima.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridMateriaPrima.Name = "btnExcelGridMateriaPrima"
        Me.btnExcelGridMateriaPrima.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridMateriaPrima.TabIndex = 28
        Me.btnExcelGridMateriaPrima.TabStop = False
        Me.btnExcelGridMateriaPrima.UseVisualStyleBackColor = False
        '
        'grpMateriaPrima
        '
        Me.grpMateriaPrima.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMateriaPrima.BackColor = System.Drawing.Color.Transparent
        Me.grpMateriaPrima.Controls.Add(Me.txtMargemLucroMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.txtValorTotalMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.lblValorTotalMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.txtValorUnitarioDescontoMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.lblValorUnitarioDescontoMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.lblDescricaoProduto)
        Me.grpMateriaPrima.Controls.Add(Me.txtDescricaoMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.cboMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.lblMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.txtCustoMedioMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.lblCustoMedioMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.lblMargemLucroMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.lblUnidadeMedidaMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.cboUnidadeMedidaMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.txtQuantidadeMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.lblQuantidadeMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.btnCadastrarUnidadeMedidaMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.btnProcurarMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.btnCadastrarMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.btnExcluirMateriaPrima)
        Me.grpMateriaPrima.Controls.Add(Me.btnInserirMateriaPrima)
        Me.grpMateriaPrima.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMateriaPrima.Location = New System.Drawing.Point(8, 3)
        Me.grpMateriaPrima.Name = "grpMateriaPrima"
        Me.grpMateriaPrima.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMateriaPrima.Size = New System.Drawing.Size(934, 104)
        Me.grpMateriaPrima.TabIndex = 3
        Me.grpMateriaPrima.VisualStyleManager = Me.vsmMain
        '
        'txtMargemLucroMateriaPrima
        '
        Me.txtMargemLucroMateriaPrima.DecimalDigits = 2
        Me.txtMargemLucroMateriaPrima.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtMargemLucroMateriaPrima.Location = New System.Drawing.Point(300, 74)
        Me.txtMargemLucroMateriaPrima.MaxLength = 0
        Me.txtMargemLucroMateriaPrima.Name = "txtMargemLucroMateriaPrima"
        Me.txtMargemLucroMateriaPrima.Size = New System.Drawing.Size(91, 20)
        Me.txtMargemLucroMateriaPrima.TabIndex = 18
        Me.txtMargemLucroMateriaPrima.Text = "0,00"
        Me.txtMargemLucroMateriaPrima.Value = 0.0R
        Me.txtMargemLucroMateriaPrima.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'txtValorTotalMateriaPrima
        '
        Me.txtValorTotalMateriaPrima.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTotalMateriaPrima.DecimalDigits = 4
        Me.txtValorTotalMateriaPrima.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorTotalMateriaPrima.Location = New System.Drawing.Point(494, 74)
        Me.txtValorTotalMateriaPrima.MaxLength = 0
        Me.txtValorTotalMateriaPrima.Name = "txtValorTotalMateriaPrima"
        Me.txtValorTotalMateriaPrima.Size = New System.Drawing.Size(91, 20)
        Me.txtValorTotalMateriaPrima.TabIndex = 22
        Me.txtValorTotalMateriaPrima.TabStop = False
        Me.txtValorTotalMateriaPrima.Text = "0,0000"
        Me.txtValorTotalMateriaPrima.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblValorTotalMateriaPrima
        '
        Me.lblValorTotalMateriaPrima.AutoSize = True
        Me.lblValorTotalMateriaPrima.Location = New System.Drawing.Point(491, 57)
        Me.lblValorTotalMateriaPrima.Name = "lblValorTotalMateriaPrima"
        Me.lblValorTotalMateriaPrima.Size = New System.Drawing.Size(60, 14)
        Me.lblValorTotalMateriaPrima.TabIndex = 21
        Me.lblValorTotalMateriaPrima.Text = "Valor Total:"
        '
        'txtValorUnitarioDescontoMateriaPrima
        '
        Me.txtValorUnitarioDescontoMateriaPrima.DecimalDigits = 4
        Me.txtValorUnitarioDescontoMateriaPrima.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorUnitarioDescontoMateriaPrima.Location = New System.Drawing.Point(397, 74)
        Me.txtValorUnitarioDescontoMateriaPrima.MaxLength = 0
        Me.txtValorUnitarioDescontoMateriaPrima.Name = "txtValorUnitarioDescontoMateriaPrima"
        Me.txtValorUnitarioDescontoMateriaPrima.Size = New System.Drawing.Size(91, 20)
        Me.txtValorUnitarioDescontoMateriaPrima.TabIndex = 20
        Me.txtValorUnitarioDescontoMateriaPrima.Text = "0,0000"
        Me.txtValorUnitarioDescontoMateriaPrima.Value = 0.0R
        Me.txtValorUnitarioDescontoMateriaPrima.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblValorUnitarioDescontoMateriaPrima
        '
        Me.lblValorUnitarioDescontoMateriaPrima.AutoSize = True
        Me.lblValorUnitarioDescontoMateriaPrima.Location = New System.Drawing.Point(394, 57)
        Me.lblValorUnitarioDescontoMateriaPrima.Name = "lblValorUnitarioDescontoMateriaPrima"
        Me.lblValorUnitarioDescontoMateriaPrima.Size = New System.Drawing.Size(87, 14)
        Me.lblValorUnitarioDescontoMateriaPrima.TabIndex = 19
        Me.lblValorUnitarioDescontoMateriaPrima.Text = "Preço de Venda:"
        '
        'lblDescricaoProduto
        '
        Me.lblDescricaoProduto.AutoSize = True
        Me.lblDescricaoProduto.Location = New System.Drawing.Point(200, 17)
        Me.lblDescricaoProduto.Name = "lblDescricaoProduto"
        Me.lblDescricaoProduto.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoProduto.TabIndex = 4
        Me.lblDescricaoProduto.Text = "Descrição:"
        '
        'txtDescricaoMateriaPrima
        '
        Me.txtDescricaoMateriaPrima.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoMateriaPrima.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoMateriaPrima.Location = New System.Drawing.Point(203, 34)
        Me.txtDescricaoMateriaPrima.MaxLength = 60
        Me.txtDescricaoMateriaPrima.Name = "txtDescricaoMateriaPrima"
        Me.txtDescricaoMateriaPrima.ReadOnly = True
        Me.txtDescricaoMateriaPrima.Size = New System.Drawing.Size(576, 20)
        Me.txtDescricaoMateriaPrima.TabIndex = 5
        Me.txtDescricaoMateriaPrima.TabStop = False
        '
        'cboMateriaPrima
        '
        Me.cboMateriaPrima.AutoSize = False
        Me.cboMateriaPrima.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMateriaPrima.Location = New System.Drawing.Point(9, 34)
        Me.cboMateriaPrima.Name = "cboMateriaPrima"
        Me.cboMateriaPrima.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMateriaPrima.Size = New System.Drawing.Size(188, 20)
        Me.cboMateriaPrima.TabIndex = 3
        '
        'lblMateriaPrima
        '
        Me.lblMateriaPrima.AutoSize = True
        Me.lblMateriaPrima.Location = New System.Drawing.Point(25, 17)
        Me.lblMateriaPrima.Name = "lblMateriaPrima"
        Me.lblMateriaPrima.Size = New System.Drawing.Size(74, 14)
        Me.lblMateriaPrima.TabIndex = 1
        Me.lblMateriaPrima.Text = "Matéria Prima:"
        '
        'txtCustoMedioMateriaPrima
        '
        Me.txtCustoMedioMateriaPrima.DecimalDigits = 4
        Me.txtCustoMedioMateriaPrima.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustoMedioMateriaPrima.Location = New System.Drawing.Point(203, 74)
        Me.txtCustoMedioMateriaPrima.MaxLength = 0
        Me.txtCustoMedioMateriaPrima.Name = "txtCustoMedioMateriaPrima"
        Me.txtCustoMedioMateriaPrima.Size = New System.Drawing.Size(91, 20)
        Me.txtCustoMedioMateriaPrima.TabIndex = 12
        Me.txtCustoMedioMateriaPrima.Text = "0,0000"
        Me.txtCustoMedioMateriaPrima.Value = 0.0R
        Me.txtCustoMedioMateriaPrima.ValueType = Janus.Windows.GridEX.NumericEditValueType.[Double]
        '
        'lblCustoMedioMateriaPrima
        '
        Me.lblCustoMedioMateriaPrima.AutoSize = True
        Me.lblCustoMedioMateriaPrima.Location = New System.Drawing.Point(200, 57)
        Me.lblCustoMedioMateriaPrima.Name = "lblCustoMedioMateriaPrima"
        Me.lblCustoMedioMateriaPrima.Size = New System.Drawing.Size(69, 14)
        Me.lblCustoMedioMateriaPrima.TabIndex = 11
        Me.lblCustoMedioMateriaPrima.Text = "Custo Médio:"
        '
        'lblMargemLucroMateriaPrima
        '
        Me.lblMargemLucroMateriaPrima.AutoSize = True
        Me.lblMargemLucroMateriaPrima.Location = New System.Drawing.Point(297, 57)
        Me.lblMargemLucroMateriaPrima.Name = "lblMargemLucroMateriaPrima"
        Me.lblMargemLucroMateriaPrima.Size = New System.Drawing.Size(69, 14)
        Me.lblMargemLucroMateriaPrima.TabIndex = 17
        Me.lblMargemLucroMateriaPrima.Text = "Margem (%):"
        '
        'lblUnidadeMedidaMateriaPrima
        '
        Me.lblUnidadeMedidaMateriaPrima.AutoSize = True
        Me.lblUnidadeMedidaMateriaPrima.Location = New System.Drawing.Point(122, 57)
        Me.lblUnidadeMedidaMateriaPrima.Name = "lblUnidadeMedidaMateriaPrima"
        Me.lblUnidadeMedidaMateriaPrima.Size = New System.Drawing.Size(58, 14)
        Me.lblUnidadeMedidaMateriaPrima.TabIndex = 9
        Me.lblUnidadeMedidaMateriaPrima.Text = "Und. Med.:"
        '
        'cboUnidadeMedidaMateriaPrima
        '
        Me.cboUnidadeMedidaMateriaPrima.AutoSize = False
        Me.cboUnidadeMedidaMateriaPrima.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedidaMateriaPrima.Location = New System.Drawing.Point(106, 74)
        Me.cboUnidadeMedidaMateriaPrima.Name = "cboUnidadeMedidaMateriaPrima"
        Me.cboUnidadeMedidaMateriaPrima.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedidaMateriaPrima.Size = New System.Drawing.Size(91, 20)
        Me.cboUnidadeMedidaMateriaPrima.TabIndex = 10
        '
        'txtQuantidadeMateriaPrima
        '
        Me.txtQuantidadeMateriaPrima.DecimalDigits = 4
        Me.txtQuantidadeMateriaPrima.Location = New System.Drawing.Point(9, 74)
        Me.txtQuantidadeMateriaPrima.MaxLength = 0
        Me.txtQuantidadeMateriaPrima.Name = "txtQuantidadeMateriaPrima"
        Me.txtQuantidadeMateriaPrima.Size = New System.Drawing.Size(91, 20)
        Me.txtQuantidadeMateriaPrima.TabIndex = 7
        Me.txtQuantidadeMateriaPrima.Text = "0,0000"
        Me.txtQuantidadeMateriaPrima.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeMateriaPrima
        '
        Me.lblQuantidadeMateriaPrima.AutoSize = True
        Me.lblQuantidadeMateriaPrima.Location = New System.Drawing.Point(6, 57)
        Me.lblQuantidadeMateriaPrima.Name = "lblQuantidadeMateriaPrima"
        Me.lblQuantidadeMateriaPrima.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeMateriaPrima.TabIndex = 6
        Me.lblQuantidadeMateriaPrima.Text = "Quantidade:"
        '
        'btnCadastrarUnidadeMedidaMateriaPrima
        '
        Me.btnCadastrarUnidadeMedidaMateriaPrima.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUnidadeMedidaMateriaPrima.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUnidadeMedidaMateriaPrima.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarUnidadeMedidaMateriaPrima.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUnidadeMedidaMateriaPrima.Location = New System.Drawing.Point(106, 58)
        Me.btnCadastrarUnidadeMedidaMateriaPrima.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUnidadeMedidaMateriaPrima.Name = "btnCadastrarUnidadeMedidaMateriaPrima"
        Me.btnCadastrarUnidadeMedidaMateriaPrima.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarUnidadeMedidaMateriaPrima.TabIndex = 8
        Me.btnCadastrarUnidadeMedidaMateriaPrima.TabStop = False
        Me.btnCadastrarUnidadeMedidaMateriaPrima.UseVisualStyleBackColor = True
        '
        'btnProcurarMateriaPrima
        '
        Me.btnProcurarMateriaPrima.FlatAppearance.BorderSize = 0
        Me.btnProcurarMateriaPrima.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarMateriaPrima.Image = Global.INTERACTI.My.Resources.search
        Me.btnProcurarMateriaPrima.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarMateriaPrima.Location = New System.Drawing.Point(179, 15)
        Me.btnProcurarMateriaPrima.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarMateriaPrima.Name = "btnProcurarMateriaPrima"
        Me.btnProcurarMateriaPrima.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarMateriaPrima.TabIndex = 2
        Me.btnProcurarMateriaPrima.TabStop = False
        Me.btnProcurarMateriaPrima.UseVisualStyleBackColor = True
        '
        'btnCadastrarMateriaPrima
        '
        Me.btnCadastrarMateriaPrima.FlatAppearance.BorderSize = 0
        Me.btnCadastrarMateriaPrima.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarMateriaPrima.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarMateriaPrima.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarMateriaPrima.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarMateriaPrima.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarMateriaPrima.Name = "btnCadastrarMateriaPrima"
        Me.btnCadastrarMateriaPrima.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarMateriaPrima.TabIndex = 0
        Me.btnCadastrarMateriaPrima.TabStop = False
        Me.btnCadastrarMateriaPrima.UseVisualStyleBackColor = True
        '
        'btnExcluirMateriaPrima
        '
        Me.btnExcluirMateriaPrima.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirMateriaPrima.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirMateriaPrima.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirMateriaPrima.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirMateriaPrima.Location = New System.Drawing.Point(834, 71)
        Me.btnExcluirMateriaPrima.Name = "btnExcluirMateriaPrima"
        Me.btnExcluirMateriaPrima.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirMateriaPrima.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirMateriaPrima.TabIndex = 24
        Me.btnExcluirMateriaPrima.Text = "Excluir"
        Me.btnExcluirMateriaPrima.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirMateriaPrima
        '
        Me.btnInserirMateriaPrima.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirMateriaPrima.Image = CType(resources.GetObject("btnInserirMateriaPrima.Image"), System.Drawing.Image)
        Me.btnInserirMateriaPrima.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirMateriaPrima.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirMateriaPrima.Location = New System.Drawing.Point(834, 42)
        Me.btnInserirMateriaPrima.Name = "btnInserirMateriaPrima"
        Me.btnInserirMateriaPrima.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirMateriaPrima.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirMateriaPrima.TabIndex = 23
        Me.btnInserirMateriaPrima.Text = "Inserir"
        Me.btnInserirMateriaPrima.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAgruparGridMateriaPrima
        '
        Me.btnAgruparGridMateriaPrima.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridMateriaPrima.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridMateriaPrima.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridMateriaPrima.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridMateriaPrima.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridMateriaPrima.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridMateriaPrima.Location = New System.Drawing.Point(33, 403)
        Me.btnAgruparGridMateriaPrima.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridMateriaPrima.Name = "btnAgruparGridMateriaPrima"
        Me.btnAgruparGridMateriaPrima.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridMateriaPrima.TabIndex = 27
        Me.btnAgruparGridMateriaPrima.TabStop = False
        Me.btnAgruparGridMateriaPrima.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridMateriaPrima
        '
        Me.btnConfigurarGridMateriaPrima.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridMateriaPrima.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridMateriaPrima.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridMateriaPrima.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridMateriaPrima.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridMateriaPrima.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridMateriaPrima.Location = New System.Drawing.Point(9, 403)
        Me.btnConfigurarGridMateriaPrima.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridMateriaPrima.Name = "btnConfigurarGridMateriaPrima"
        Me.btnConfigurarGridMateriaPrima.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridMateriaPrima.TabIndex = 5
        Me.btnConfigurarGridMateriaPrima.TabStop = False
        Me.btnConfigurarGridMateriaPrima.UseVisualStyleBackColor = False
        '
        'grdMateriaPrima
        '
        Me.grdMateriaPrima.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdMateriaPrima.AlternatingColors = True
        Me.grdMateriaPrima.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdMateriaPrima.AutoEdit = True
        Me.grdMateriaPrima.ColumnAutoResize = True
        grdMateriaPrima_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdMateriaPrima_DesignTimeLayout_Reference_0.Instance"), Object)
        grdMateriaPrima_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdMateriaPrima_DesignTimeLayout_Reference_0})
        grdMateriaPrima_DesignTimeLayout.LayoutString = resources.GetString("grdMateriaPrima_DesignTimeLayout.LayoutString")
        Me.grdMateriaPrima.DesignTimeLayout = grdMateriaPrima_DesignTimeLayout
        Me.grdMateriaPrima.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdMateriaPrima.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdMateriaPrima.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdMateriaPrima.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdMateriaPrima.FrozenColumns = 2
        Me.grdMateriaPrima.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdMateriaPrima.GroupByBoxVisible = False
        Me.grdMateriaPrima.Location = New System.Drawing.Point(8, 116)
        Me.grdMateriaPrima.Name = "grdMateriaPrima"
        Me.grdMateriaPrima.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdMateriaPrima.RecordNavigator = True
        Me.grdMateriaPrima.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdMateriaPrima.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdMateriaPrima.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdMateriaPrima.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdMateriaPrima.Size = New System.Drawing.Size(934, 304)
        Me.grdMateriaPrima.TabIndex = 4
        Me.grdMateriaPrima.TabStop = False
        Me.grdMateriaPrima.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdMateriaPrima.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdMateriaPrima.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdMateriaPrima.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdMateriaPrima.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdMateriaPrima.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdMateriaPrima.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdMateriaPrima.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdMateriaPrima.VisualStyleManager = Me.vsmMain
        '
        'pagSubContrato
        '
        Me.pagSubContrato.Controls.Add(Me.btnExcelGridCusto)
        Me.pagSubContrato.Controls.Add(Me.btnAgruparGridCusto)
        Me.pagSubContrato.Controls.Add(Me.btnConfigurarGridCusto)
        Me.pagSubContrato.Controls.Add(Me.UiGroupBox1)
        Me.pagSubContrato.Controls.Add(Me.grdCusto)
        Me.pagSubContrato.Key = "pagSubContrato"
        Me.pagSubContrato.Location = New System.Drawing.Point(1, 22)
        Me.pagSubContrato.Name = "pagSubContrato"
        Me.pagSubContrato.Size = New System.Drawing.Size(950, 429)
        Me.pagSubContrato.TabStop = True
        Me.pagSubContrato.Text = "Subcontrato / Outros"
        '
        'btnExcelGridCusto
        '
        Me.btnExcelGridCusto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridCusto.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridCusto.FlatAppearance.BorderSize = 0
        Me.btnExcelGridCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridCusto.Image = CType(resources.GetObject("btnExcelGridCusto.Image"), System.Drawing.Image)
        Me.btnExcelGridCusto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridCusto.Location = New System.Drawing.Point(57, 403)
        Me.btnExcelGridCusto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridCusto.Name = "btnExcelGridCusto"
        Me.btnExcelGridCusto.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridCusto.TabIndex = 4
        Me.btnExcelGridCusto.TabStop = False
        Me.btnExcelGridCusto.UseVisualStyleBackColor = False
        '
        'btnAgruparGridCusto
        '
        Me.btnAgruparGridCusto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridCusto.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridCusto.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridCusto.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGridCusto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridCusto.Location = New System.Drawing.Point(33, 403)
        Me.btnAgruparGridCusto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridCusto.Name = "btnAgruparGridCusto"
        Me.btnAgruparGridCusto.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridCusto.TabIndex = 3
        Me.btnAgruparGridCusto.TabStop = False
        Me.btnAgruparGridCusto.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridCusto
        '
        Me.btnConfigurarGridCusto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridCusto.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridCusto.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridCusto.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridCusto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridCusto.Location = New System.Drawing.Point(9, 403)
        Me.btnConfigurarGridCusto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridCusto.Name = "btnConfigurarGridCusto"
        Me.btnConfigurarGridCusto.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridCusto.TabIndex = 2
        Me.btnConfigurarGridCusto.TabStop = False
        Me.btnConfigurarGridCusto.UseVisualStyleBackColor = False
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.lblDescricaoCusto)
        Me.UiGroupBox1.Controls.Add(Me.txtDescricaoCusto)
        Me.UiGroupBox1.Controls.Add(Me.cboTipoCusto)
        Me.UiGroupBox1.Controls.Add(Me.lblTipoCusto)
        Me.UiGroupBox1.Controls.Add(Me.txtValorCusto)
        Me.UiGroupBox1.Controls.Add(Me.lblValorCusto)
        Me.UiGroupBox1.Controls.Add(Me.btnExcluirCusto)
        Me.UiGroupBox1.Controls.Add(Me.btnInserirCusto)
        Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(934, 64)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'lblDescricaoCusto
        '
        Me.lblDescricaoCusto.AutoSize = True
        Me.lblDescricaoCusto.Location = New System.Drawing.Point(200, 17)
        Me.lblDescricaoCusto.Name = "lblDescricaoCusto"
        Me.lblDescricaoCusto.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoCusto.TabIndex = 2
        Me.lblDescricaoCusto.Text = "Descrição:"
        '
        'txtDescricaoCusto
        '
        Me.txtDescricaoCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoCusto.Location = New System.Drawing.Point(203, 34)
        Me.txtDescricaoCusto.MaxLength = 60
        Me.txtDescricaoCusto.Name = "txtDescricaoCusto"
        Me.txtDescricaoCusto.Size = New System.Drawing.Size(384, 20)
        Me.txtDescricaoCusto.TabIndex = 3
        '
        'cboTipoCusto
        '
        Me.cboTipoCusto.AutoSize = False
        Me.cboTipoCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoCusto.Location = New System.Drawing.Point(9, 34)
        Me.cboTipoCusto.Name = "cboTipoCusto"
        Me.cboTipoCusto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoCusto.Size = New System.Drawing.Size(188, 20)
        Me.cboTipoCusto.TabIndex = 1
        '
        'lblTipoCusto
        '
        Me.lblTipoCusto.AutoSize = True
        Me.lblTipoCusto.Location = New System.Drawing.Point(6, 17)
        Me.lblTipoCusto.Name = "lblTipoCusto"
        Me.lblTipoCusto.Size = New System.Drawing.Size(30, 14)
        Me.lblTipoCusto.TabIndex = 0
        Me.lblTipoCusto.Text = "Tipo:"
        '
        'txtValorCusto
        '
        Me.txtValorCusto.DecimalDigits = 2
        Me.txtValorCusto.Location = New System.Drawing.Point(593, 34)
        Me.txtValorCusto.MaxLength = 0
        Me.txtValorCusto.Name = "txtValorCusto"
        Me.txtValorCusto.Size = New System.Drawing.Size(91, 20)
        Me.txtValorCusto.TabIndex = 5
        Me.txtValorCusto.Text = "0,00"
        Me.txtValorCusto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorCusto
        '
        Me.lblValorCusto.AutoSize = True
        Me.lblValorCusto.Location = New System.Drawing.Point(590, 17)
        Me.lblValorCusto.Name = "lblValorCusto"
        Me.lblValorCusto.Size = New System.Drawing.Size(35, 14)
        Me.lblValorCusto.TabIndex = 4
        Me.lblValorCusto.Text = "Valor:"
        '
        'btnExcluirCusto
        '
        Me.btnExcluirCusto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirCusto.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluirCusto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirCusto.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirCusto.Location = New System.Drawing.Point(834, 31)
        Me.btnExcluirCusto.Name = "btnExcluirCusto"
        Me.btnExcluirCusto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirCusto.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirCusto.TabIndex = 7
        Me.btnExcluirCusto.Text = "Excluir"
        Me.btnExcluirCusto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirCusto
        '
        Me.btnInserirCusto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirCusto.Image = CType(resources.GetObject("btnInserirCusto.Image"), System.Drawing.Image)
        Me.btnInserirCusto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirCusto.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirCusto.Location = New System.Drawing.Point(737, 31)
        Me.btnInserirCusto.Name = "btnInserirCusto"
        Me.btnInserirCusto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirCusto.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirCusto.TabIndex = 6
        Me.btnInserirCusto.Text = "Inserir"
        Me.btnInserirCusto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdCusto
        '
        Me.grdCusto.AlternatingColors = True
        Me.grdCusto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCusto.AutoEdit = True
        Me.grdCusto.ColumnAutoResize = True
        grdCusto_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdCusto_DesignTimeLayout_Reference_0.Instance"), Object)
        grdCusto_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdCusto_DesignTimeLayout_Reference_0})
        grdCusto_DesignTimeLayout.LayoutString = resources.GetString("grdCusto_DesignTimeLayout.LayoutString")
        Me.grdCusto.DesignTimeLayout = grdCusto_DesignTimeLayout
        Me.grdCusto.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdCusto.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdCusto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdCusto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdCusto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdCusto.GroupByBoxVisible = False
        Me.grdCusto.Location = New System.Drawing.Point(8, 76)
        Me.grdCusto.Name = "grdCusto"
        Me.grdCusto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdCusto.RecordNavigator = True
        Me.grdCusto.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdCusto.SelectedFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdCusto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdCusto.Size = New System.Drawing.Size(934, 344)
        Me.grdCusto.TabIndex = 1
        Me.grdCusto.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdCusto.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdCusto.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdCusto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdCusto.VisualStyleManager = Me.vsmMain
        '
        'pagCalculo
        '
        Me.pagCalculo.Controls.Add(Me.grpCalculo)
        Me.pagCalculo.Key = "pagCalculo"
        Me.pagCalculo.Location = New System.Drawing.Point(1, 22)
        Me.pagCalculo.Name = "pagCalculo"
        Me.pagCalculo.Size = New System.Drawing.Size(950, 429)
        Me.pagCalculo.TabStop = True
        Me.pagCalculo.Text = "Cálculos"
        '
        'grpCalculo
        '
        Me.grpCalculo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCalculo.BackColor = System.Drawing.Color.Transparent
        Me.grpCalculo.Controls.Add(Me.txtValorIR)
        Me.grpCalculo.Controls.Add(Me.lblValorTotal)
        Me.grpCalculo.Controls.Add(Me.txtValorTotal)
        Me.grpCalculo.Controls.Add(Me.lblLinha)
        Me.grpCalculo.Controls.Add(Me.lblObservacao)
        Me.grpCalculo.Controls.Add(Me.txtObservacao)
        Me.grpCalculo.Controls.Add(Me.txtValorTaxaFinanceira)
        Me.grpCalculo.Controls.Add(Me.lblTaxaFinanceira)
        Me.grpCalculo.Controls.Add(Me.txtTaxaFinanceira)
        Me.grpCalculo.Controls.Add(Me.lblValorSubtotal3)
        Me.grpCalculo.Controls.Add(Me.txtValorSubtotal3)
        Me.grpCalculo.Controls.Add(Me.txtValorCOFINS)
        Me.grpCalculo.Controls.Add(Me.txtValorPIS)
        Me.grpCalculo.Controls.Add(Me.txtValorICMS)
        Me.grpCalculo.Controls.Add(Me.lblAliquotaIR)
        Me.grpCalculo.Controls.Add(Me.txtAliquotaIR)
        Me.grpCalculo.Controls.Add(Me.lblAliquotaCOFINS)
        Me.grpCalculo.Controls.Add(Me.txtAliquotaCOFINS)
        Me.grpCalculo.Controls.Add(Me.lblAliquotaPIS)
        Me.grpCalculo.Controls.Add(Me.txtAliquotaPIS)
        Me.grpCalculo.Controls.Add(Me.lblAliquotaICMS)
        Me.grpCalculo.Controls.Add(Me.txtAliquotaICMS)
        Me.grpCalculo.Controls.Add(Me.lblValorMateriaPrima)
        Me.grpCalculo.Controls.Add(Me.txtValorMateriaPrima)
        Me.grpCalculo.Controls.Add(Me.lblValorSubtotal2)
        Me.grpCalculo.Controls.Add(Me.txtValorSubtotal2)
        Me.grpCalculo.Controls.Add(Me.txtValorMargem)
        Me.grpCalculo.Controls.Add(Me.lblMargem)
        Me.grpCalculo.Controls.Add(Me.txtMargem)
        Me.grpCalculo.Controls.Add(Me.lblValorSubtotal1)
        Me.grpCalculo.Controls.Add(Me.txtValorSubtotal1)
        Me.grpCalculo.Controls.Add(Me.lblValorTransportadora)
        Me.grpCalculo.Controls.Add(Me.txtValorTransportadora)
        Me.grpCalculo.Controls.Add(Me.lblValorSubcontrato)
        Me.grpCalculo.Controls.Add(Me.txtValorSubcontrato)
        Me.grpCalculo.Controls.Add(Me.lblValorFerramentas)
        Me.grpCalculo.Controls.Add(Me.txtValorFerramentas)
        Me.grpCalculo.Controls.Add(Me.lblValorPadronizados)
        Me.grpCalculo.Controls.Add(Me.txtValorPadronizados)
        Me.grpCalculo.Controls.Add(Me.lblValorEmbalagem)
        Me.grpCalculo.Controls.Add(Me.txtValorEmbalagem)
        Me.grpCalculo.Controls.Add(Me.lblValorTratamentoTermico)
        Me.grpCalculo.Controls.Add(Me.txtValorTratamentoTermico)
        Me.grpCalculo.Controls.Add(Me.lblValorTratamentoSuperficial)
        Me.grpCalculo.Controls.Add(Me.txtValorTratamentoSuperficial)
        Me.grpCalculo.Controls.Add(Me.lblValorPintura)
        Me.grpCalculo.Controls.Add(Me.txtValorPintura)
        Me.grpCalculo.Controls.Add(Me.lblValorMaoObra)
        Me.grpCalculo.Controls.Add(Me.txtValorMaoObra)
        Me.grpCalculo.Location = New System.Drawing.Point(8, 3)
        Me.grpCalculo.Name = "grpCalculo"
        Me.grpCalculo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCalculo.Size = New System.Drawing.Size(934, 417)
        Me.grpCalculo.TabIndex = 0
        Me.grpCalculo.VisualStyleManager = Me.vsmMain
        '
        'txtValorIR
        '
        Me.txtValorIR.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorIR.Location = New System.Drawing.Point(825, 98)
        Me.txtValorIR.Name = "txtValorIR"
        Me.txtValorIR.ReadOnly = True
        Me.txtValorIR.Size = New System.Drawing.Size(100, 20)
        Me.txtValorIR.TabIndex = 53
        Me.txtValorIR.TabStop = False
        Me.txtValorIR.Text = "0,00"
        Me.txtValorIR.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblValorTotal.Location = New System.Drawing.Point(639, 127)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(67, 14)
        Me.lblValorTotal.TabIndex = 48
        Me.lblValorTotal.Text = "Valor Total:"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackColor = System.Drawing.Color.SteelBlue
        Me.txtValorTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorTotal.ForeColor = System.Drawing.Color.White
        Me.txtValorTotal.Location = New System.Drawing.Point(719, 124)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtValorTotal.TabIndex = 49
        Me.txtValorTotal.TabStop = False
        Me.txtValorTotal.Text = "0,00"
        Me.txtValorTotal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblLinha
        '
        Me.lblLinha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLinha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLinha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLinha.Location = New System.Drawing.Point(9, 289)
        Me.lblLinha.Name = "lblLinha"
        Me.lblLinha.Size = New System.Drawing.Size(916, 1)
        Me.lblLinha.TabIndex = 50
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.Location = New System.Drawing.Point(6, 306)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacao.TabIndex = 51
        Me.lblObservacao.Text = "Observação:"
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.Location = New System.Drawing.Point(9, 323)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(916, 84)
        Me.txtObservacao.TabIndex = 52
        '
        'txtValorTaxaFinanceira
        '
        Me.txtValorTaxaFinanceira.Location = New System.Drawing.Point(478, 97)
        Me.txtValorTaxaFinanceira.Name = "txtValorTaxaFinanceira"
        Me.txtValorTaxaFinanceira.Size = New System.Drawing.Size(100, 20)
        Me.txtValorTaxaFinanceira.TabIndex = 45
        Me.txtValorTaxaFinanceira.Text = "0,00"
        Me.txtValorTaxaFinanceira.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblTaxaFinanceira
        '
        Me.lblTaxaFinanceira.AutoSize = True
        Me.lblTaxaFinanceira.Location = New System.Drawing.Point(292, 100)
        Me.lblTaxaFinanceira.Name = "lblTaxaFinanceira"
        Me.lblTaxaFinanceira.Size = New System.Drawing.Size(78, 14)
        Me.lblTaxaFinanceira.TabIndex = 43
        Me.lblTaxaFinanceira.Text = "Tx. Financeira:"
        '
        'txtTaxaFinanceira
        '
        Me.txtTaxaFinanceira.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtTaxaFinanceira.Location = New System.Drawing.Point(372, 97)
        Me.txtTaxaFinanceira.Name = "txtTaxaFinanceira"
        Me.txtTaxaFinanceira.Size = New System.Drawing.Size(100, 20)
        Me.txtTaxaFinanceira.TabIndex = 44
        Me.txtTaxaFinanceira.Text = "0,00%"
        Me.txtTaxaFinanceira.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorSubtotal3
        '
        Me.lblValorSubtotal3.AutoSize = True
        Me.lblValorSubtotal3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblValorSubtotal3.Location = New System.Drawing.Point(292, 127)
        Me.lblValorSubtotal3.Name = "lblValorSubtotal3"
        Me.lblValorSubtotal3.Size = New System.Drawing.Size(72, 14)
        Me.lblValorSubtotal3.TabIndex = 41
        Me.lblValorSubtotal3.Text = "Subtotal (3):"
        '
        'txtValorSubtotal3
        '
        Me.txtValorSubtotal3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorSubtotal3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorSubtotal3.Location = New System.Drawing.Point(372, 124)
        Me.txtValorSubtotal3.Name = "txtValorSubtotal3"
        Me.txtValorSubtotal3.ReadOnly = True
        Me.txtValorSubtotal3.Size = New System.Drawing.Size(100, 20)
        Me.txtValorSubtotal3.TabIndex = 42
        Me.txtValorSubtotal3.TabStop = False
        Me.txtValorSubtotal3.Text = "0,00"
        Me.txtValorSubtotal3.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtValorCOFINS
        '
        Me.txtValorCOFINS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorCOFINS.Location = New System.Drawing.Point(825, 72)
        Me.txtValorCOFINS.Name = "txtValorCOFINS"
        Me.txtValorCOFINS.ReadOnly = True
        Me.txtValorCOFINS.Size = New System.Drawing.Size(100, 20)
        Me.txtValorCOFINS.TabIndex = 38
        Me.txtValorCOFINS.TabStop = False
        Me.txtValorCOFINS.Text = "0,00"
        Me.txtValorCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtValorPIS
        '
        Me.txtValorPIS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorPIS.Location = New System.Drawing.Point(825, 46)
        Me.txtValorPIS.Name = "txtValorPIS"
        Me.txtValorPIS.ReadOnly = True
        Me.txtValorPIS.Size = New System.Drawing.Size(100, 20)
        Me.txtValorPIS.TabIndex = 35
        Me.txtValorPIS.TabStop = False
        Me.txtValorPIS.Text = "0,00"
        Me.txtValorPIS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtValorICMS
        '
        Me.txtValorICMS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorICMS.Location = New System.Drawing.Point(825, 20)
        Me.txtValorICMS.Name = "txtValorICMS"
        Me.txtValorICMS.ReadOnly = True
        Me.txtValorICMS.Size = New System.Drawing.Size(100, 20)
        Me.txtValorICMS.TabIndex = 29
        Me.txtValorICMS.TabStop = False
        Me.txtValorICMS.Text = "0,00"
        Me.txtValorICMS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaIR
        '
        Me.lblAliquotaIR.AutoSize = True
        Me.lblAliquotaIR.Location = New System.Drawing.Point(639, 101)
        Me.lblAliquotaIR.Name = "lblAliquotaIR"
        Me.lblAliquotaIR.Size = New System.Drawing.Size(19, 14)
        Me.lblAliquotaIR.TabIndex = 39
        Me.lblAliquotaIR.Text = "IR:"
        '
        'txtAliquotaIR
        '
        Me.txtAliquotaIR.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaIR.Location = New System.Drawing.Point(719, 98)
        Me.txtAliquotaIR.Name = "txtAliquotaIR"
        Me.txtAliquotaIR.Size = New System.Drawing.Size(100, 20)
        Me.txtAliquotaIR.TabIndex = 40
        Me.txtAliquotaIR.Text = "0,00%"
        Me.txtAliquotaIR.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaCOFINS
        '
        Me.lblAliquotaCOFINS.AutoSize = True
        Me.lblAliquotaCOFINS.Location = New System.Drawing.Point(639, 75)
        Me.lblAliquotaCOFINS.Name = "lblAliquotaCOFINS"
        Me.lblAliquotaCOFINS.Size = New System.Drawing.Size(47, 14)
        Me.lblAliquotaCOFINS.TabIndex = 36
        Me.lblAliquotaCOFINS.Text = "COFINS:"
        '
        'txtAliquotaCOFINS
        '
        Me.txtAliquotaCOFINS.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaCOFINS.Location = New System.Drawing.Point(719, 72)
        Me.txtAliquotaCOFINS.Name = "txtAliquotaCOFINS"
        Me.txtAliquotaCOFINS.Size = New System.Drawing.Size(100, 20)
        Me.txtAliquotaCOFINS.TabIndex = 37
        Me.txtAliquotaCOFINS.Text = "0,00%"
        Me.txtAliquotaCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaPIS
        '
        Me.lblAliquotaPIS.AutoSize = True
        Me.lblAliquotaPIS.Location = New System.Drawing.Point(639, 49)
        Me.lblAliquotaPIS.Name = "lblAliquotaPIS"
        Me.lblAliquotaPIS.Size = New System.Drawing.Size(25, 14)
        Me.lblAliquotaPIS.TabIndex = 33
        Me.lblAliquotaPIS.Text = "PIS:"
        '
        'txtAliquotaPIS
        '
        Me.txtAliquotaPIS.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaPIS.Location = New System.Drawing.Point(719, 46)
        Me.txtAliquotaPIS.Name = "txtAliquotaPIS"
        Me.txtAliquotaPIS.Size = New System.Drawing.Size(100, 20)
        Me.txtAliquotaPIS.TabIndex = 34
        Me.txtAliquotaPIS.Text = "0,00%"
        Me.txtAliquotaPIS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaICMS
        '
        Me.lblAliquotaICMS.AutoSize = True
        Me.lblAliquotaICMS.Location = New System.Drawing.Point(639, 23)
        Me.lblAliquotaICMS.Name = "lblAliquotaICMS"
        Me.lblAliquotaICMS.Size = New System.Drawing.Size(34, 14)
        Me.lblAliquotaICMS.TabIndex = 27
        Me.lblAliquotaICMS.Text = "ICMS:"
        '
        'txtAliquotaICMS
        '
        Me.txtAliquotaICMS.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaICMS.Location = New System.Drawing.Point(719, 20)
        Me.txtAliquotaICMS.Name = "txtAliquotaICMS"
        Me.txtAliquotaICMS.Size = New System.Drawing.Size(100, 20)
        Me.txtAliquotaICMS.TabIndex = 28
        Me.txtAliquotaICMS.Text = "0,00%"
        Me.txtAliquotaICMS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorMateriaPrima
        '
        Me.lblValorMateriaPrima.AutoSize = True
        Me.lblValorMateriaPrima.Location = New System.Drawing.Point(292, 48)
        Me.lblValorMateriaPrima.Name = "lblValorMateriaPrima"
        Me.lblValorMateriaPrima.Size = New System.Drawing.Size(74, 14)
        Me.lblValorMateriaPrima.TabIndex = 23
        Me.lblValorMateriaPrima.Text = "Matéria Prima:"
        '
        'txtValorMateriaPrima
        '
        Me.txtValorMateriaPrima.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorMateriaPrima.Location = New System.Drawing.Point(372, 45)
        Me.txtValorMateriaPrima.Name = "txtValorMateriaPrima"
        Me.txtValorMateriaPrima.ReadOnly = True
        Me.txtValorMateriaPrima.Size = New System.Drawing.Size(100, 20)
        Me.txtValorMateriaPrima.TabIndex = 24
        Me.txtValorMateriaPrima.TabStop = False
        Me.txtValorMateriaPrima.Text = "0,00"
        Me.txtValorMateriaPrima.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorSubtotal2
        '
        Me.lblValorSubtotal2.AutoSize = True
        Me.lblValorSubtotal2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblValorSubtotal2.Location = New System.Drawing.Point(292, 74)
        Me.lblValorSubtotal2.Name = "lblValorSubtotal2"
        Me.lblValorSubtotal2.Size = New System.Drawing.Size(72, 14)
        Me.lblValorSubtotal2.TabIndex = 25
        Me.lblValorSubtotal2.Text = "Subtotal (2):"
        '
        'txtValorSubtotal2
        '
        Me.txtValorSubtotal2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorSubtotal2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorSubtotal2.Location = New System.Drawing.Point(372, 71)
        Me.txtValorSubtotal2.Name = "txtValorSubtotal2"
        Me.txtValorSubtotal2.ReadOnly = True
        Me.txtValorSubtotal2.Size = New System.Drawing.Size(100, 20)
        Me.txtValorSubtotal2.TabIndex = 26
        Me.txtValorSubtotal2.TabStop = False
        Me.txtValorSubtotal2.Text = "0,00"
        Me.txtValorSubtotal2.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtValorMargem
        '
        Me.txtValorMargem.Location = New System.Drawing.Point(478, 19)
        Me.txtValorMargem.Name = "txtValorMargem"
        Me.txtValorMargem.Size = New System.Drawing.Size(100, 20)
        Me.txtValorMargem.TabIndex = 22
        Me.txtValorMargem.Text = "0,00"
        Me.txtValorMargem.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMargem
        '
        Me.lblMargem.AutoSize = True
        Me.lblMargem.Location = New System.Drawing.Point(292, 22)
        Me.lblMargem.Name = "lblMargem"
        Me.lblMargem.Size = New System.Drawing.Size(48, 14)
        Me.lblMargem.TabIndex = 20
        Me.lblMargem.Text = "Margem:"
        '
        'txtMargem
        '
        Me.txtMargem.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtMargem.Location = New System.Drawing.Point(372, 19)
        Me.txtMargem.Name = "txtMargem"
        Me.txtMargem.Size = New System.Drawing.Size(100, 20)
        Me.txtMargem.TabIndex = 21
        Me.txtMargem.Text = "0,00%"
        Me.txtMargem.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorSubtotal1
        '
        Me.lblValorSubtotal1.AutoSize = True
        Me.lblValorSubtotal1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblValorSubtotal1.Location = New System.Drawing.Point(6, 258)
        Me.lblValorSubtotal1.Name = "lblValorSubtotal1"
        Me.lblValorSubtotal1.Size = New System.Drawing.Size(72, 14)
        Me.lblValorSubtotal1.TabIndex = 18
        Me.lblValorSubtotal1.Text = "Subtotal (1):"
        '
        'txtValorSubtotal1
        '
        Me.txtValorSubtotal1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorSubtotal1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorSubtotal1.Location = New System.Drawing.Point(130, 255)
        Me.txtValorSubtotal1.Name = "txtValorSubtotal1"
        Me.txtValorSubtotal1.ReadOnly = True
        Me.txtValorSubtotal1.Size = New System.Drawing.Size(100, 20)
        Me.txtValorSubtotal1.TabIndex = 19
        Me.txtValorSubtotal1.TabStop = False
        Me.txtValorSubtotal1.Text = "0,00"
        Me.txtValorSubtotal1.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorTransportadora
        '
        Me.lblValorTransportadora.AutoSize = True
        Me.lblValorTransportadora.Location = New System.Drawing.Point(6, 205)
        Me.lblValorTransportadora.Name = "lblValorTransportadora"
        Me.lblValorTransportadora.Size = New System.Drawing.Size(85, 14)
        Me.lblValorTransportadora.TabIndex = 14
        Me.lblValorTransportadora.Text = "Transportadora:"
        '
        'txtValorTransportadora
        '
        Me.txtValorTransportadora.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTransportadora.Location = New System.Drawing.Point(130, 202)
        Me.txtValorTransportadora.Name = "txtValorTransportadora"
        Me.txtValorTransportadora.ReadOnly = True
        Me.txtValorTransportadora.Size = New System.Drawing.Size(100, 20)
        Me.txtValorTransportadora.TabIndex = 15
        Me.txtValorTransportadora.TabStop = False
        Me.txtValorTransportadora.Text = "0,00"
        Me.txtValorTransportadora.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorSubcontrato
        '
        Me.lblValorSubcontrato.AutoSize = True
        Me.lblValorSubcontrato.Location = New System.Drawing.Point(6, 232)
        Me.lblValorSubcontrato.Name = "lblValorSubcontrato"
        Me.lblValorSubcontrato.Size = New System.Drawing.Size(69, 14)
        Me.lblValorSubcontrato.TabIndex = 16
        Me.lblValorSubcontrato.Text = "Subcontrato:"
        '
        'txtValorSubcontrato
        '
        Me.txtValorSubcontrato.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorSubcontrato.Location = New System.Drawing.Point(130, 229)
        Me.txtValorSubcontrato.Name = "txtValorSubcontrato"
        Me.txtValorSubcontrato.ReadOnly = True
        Me.txtValorSubcontrato.Size = New System.Drawing.Size(100, 20)
        Me.txtValorSubcontrato.TabIndex = 17
        Me.txtValorSubcontrato.TabStop = False
        Me.txtValorSubcontrato.Text = "0,00"
        Me.txtValorSubcontrato.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorFerramentas
        '
        Me.lblValorFerramentas.AutoSize = True
        Me.lblValorFerramentas.Location = New System.Drawing.Point(6, 179)
        Me.lblValorFerramentas.Name = "lblValorFerramentas"
        Me.lblValorFerramentas.Size = New System.Drawing.Size(71, 14)
        Me.lblValorFerramentas.TabIndex = 12
        Me.lblValorFerramentas.Text = "Ferramentas:"
        '
        'txtValorFerramentas
        '
        Me.txtValorFerramentas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorFerramentas.Location = New System.Drawing.Point(130, 176)
        Me.txtValorFerramentas.Name = "txtValorFerramentas"
        Me.txtValorFerramentas.ReadOnly = True
        Me.txtValorFerramentas.Size = New System.Drawing.Size(100, 20)
        Me.txtValorFerramentas.TabIndex = 13
        Me.txtValorFerramentas.TabStop = False
        Me.txtValorFerramentas.Text = "0,00"
        Me.txtValorFerramentas.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorPadronizados
        '
        Me.lblValorPadronizados.AutoSize = True
        Me.lblValorPadronizados.Location = New System.Drawing.Point(6, 153)
        Me.lblValorPadronizados.Name = "lblValorPadronizados"
        Me.lblValorPadronizados.Size = New System.Drawing.Size(76, 14)
        Me.lblValorPadronizados.TabIndex = 10
        Me.lblValorPadronizados.Text = "Padronizados:"
        '
        'txtValorPadronizados
        '
        Me.txtValorPadronizados.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorPadronizados.Location = New System.Drawing.Point(130, 150)
        Me.txtValorPadronizados.Name = "txtValorPadronizados"
        Me.txtValorPadronizados.ReadOnly = True
        Me.txtValorPadronizados.Size = New System.Drawing.Size(100, 20)
        Me.txtValorPadronizados.TabIndex = 11
        Me.txtValorPadronizados.TabStop = False
        Me.txtValorPadronizados.Text = "0,00"
        Me.txtValorPadronizados.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorEmbalagem
        '
        Me.lblValorEmbalagem.AutoSize = True
        Me.lblValorEmbalagem.Location = New System.Drawing.Point(6, 127)
        Me.lblValorEmbalagem.Name = "lblValorEmbalagem"
        Me.lblValorEmbalagem.Size = New System.Drawing.Size(64, 14)
        Me.lblValorEmbalagem.TabIndex = 8
        Me.lblValorEmbalagem.Text = "Embalagem:"
        '
        'txtValorEmbalagem
        '
        Me.txtValorEmbalagem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorEmbalagem.Location = New System.Drawing.Point(130, 124)
        Me.txtValorEmbalagem.Name = "txtValorEmbalagem"
        Me.txtValorEmbalagem.ReadOnly = True
        Me.txtValorEmbalagem.Size = New System.Drawing.Size(100, 20)
        Me.txtValorEmbalagem.TabIndex = 9
        Me.txtValorEmbalagem.TabStop = False
        Me.txtValorEmbalagem.Text = "0,00"
        Me.txtValorEmbalagem.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorTratamentoTermico
        '
        Me.lblValorTratamentoTermico.AutoSize = True
        Me.lblValorTratamentoTermico.Location = New System.Drawing.Point(6, 101)
        Me.lblValorTratamentoTermico.Name = "lblValorTratamentoTermico"
        Me.lblValorTratamentoTermico.Size = New System.Drawing.Size(105, 14)
        Me.lblValorTratamentoTermico.TabIndex = 6
        Me.lblValorTratamentoTermico.Text = "Tratamento Térmico:"
        '
        'txtValorTratamentoTermico
        '
        Me.txtValorTratamentoTermico.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTratamentoTermico.Location = New System.Drawing.Point(130, 98)
        Me.txtValorTratamentoTermico.Name = "txtValorTratamentoTermico"
        Me.txtValorTratamentoTermico.ReadOnly = True
        Me.txtValorTratamentoTermico.Size = New System.Drawing.Size(100, 20)
        Me.txtValorTratamentoTermico.TabIndex = 7
        Me.txtValorTratamentoTermico.TabStop = False
        Me.txtValorTratamentoTermico.Text = "0,00"
        Me.txtValorTratamentoTermico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorTratamentoSuperficial
        '
        Me.lblValorTratamentoSuperficial.AutoSize = True
        Me.lblValorTratamentoSuperficial.Location = New System.Drawing.Point(6, 75)
        Me.lblValorTratamentoSuperficial.Name = "lblValorTratamentoSuperficial"
        Me.lblValorTratamentoSuperficial.Size = New System.Drawing.Size(118, 14)
        Me.lblValorTratamentoSuperficial.TabIndex = 4
        Me.lblValorTratamentoSuperficial.Text = "Tratamento Superficial:"
        '
        'txtValorTratamentoSuperficial
        '
        Me.txtValorTratamentoSuperficial.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTratamentoSuperficial.Location = New System.Drawing.Point(130, 72)
        Me.txtValorTratamentoSuperficial.Name = "txtValorTratamentoSuperficial"
        Me.txtValorTratamentoSuperficial.ReadOnly = True
        Me.txtValorTratamentoSuperficial.Size = New System.Drawing.Size(100, 20)
        Me.txtValorTratamentoSuperficial.TabIndex = 5
        Me.txtValorTratamentoSuperficial.TabStop = False
        Me.txtValorTratamentoSuperficial.Text = "0,00"
        Me.txtValorTratamentoSuperficial.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorPintura
        '
        Me.lblValorPintura.AutoSize = True
        Me.lblValorPintura.Location = New System.Drawing.Point(6, 49)
        Me.lblValorPintura.Name = "lblValorPintura"
        Me.lblValorPintura.Size = New System.Drawing.Size(43, 14)
        Me.lblValorPintura.TabIndex = 2
        Me.lblValorPintura.Text = "Pintura:"
        '
        'txtValorPintura
        '
        Me.txtValorPintura.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorPintura.Location = New System.Drawing.Point(130, 46)
        Me.txtValorPintura.Name = "txtValorPintura"
        Me.txtValorPintura.ReadOnly = True
        Me.txtValorPintura.Size = New System.Drawing.Size(100, 20)
        Me.txtValorPintura.TabIndex = 3
        Me.txtValorPintura.TabStop = False
        Me.txtValorPintura.Text = "0,00"
        Me.txtValorPintura.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorMaoObra
        '
        Me.lblValorMaoObra.AutoSize = True
        Me.lblValorMaoObra.Location = New System.Drawing.Point(6, 23)
        Me.lblValorMaoObra.Name = "lblValorMaoObra"
        Me.lblValorMaoObra.Size = New System.Drawing.Size(72, 14)
        Me.lblValorMaoObra.TabIndex = 0
        Me.lblValorMaoObra.Text = "Mão de Obra:"
        '
        'txtValorMaoObra
        '
        Me.txtValorMaoObra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorMaoObra.Location = New System.Drawing.Point(130, 20)
        Me.txtValorMaoObra.Name = "txtValorMaoObra"
        Me.txtValorMaoObra.ReadOnly = True
        Me.txtValorMaoObra.Size = New System.Drawing.Size(100, 20)
        Me.txtValorMaoObra.TabIndex = 1
        Me.txtValorMaoObra.TabStop = False
        Me.txtValorMaoObra.Text = "0,00"
        Me.txtValorMaoObra.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'frmVenOrcamentoProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 559)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVenOrcamentoProduto"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Orçamento - Dados do Produto"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagProducao.ResumeLayout(False)
        CType(Me.grdProducao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProduto.ResumeLayout(False)
        Me.grpProduto.PerformLayout()
        Me.pagMateriaPrima.ResumeLayout(False)
        CType(Me.grpMateriaPrima, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMateriaPrima.ResumeLayout(False)
        Me.grpMateriaPrima.PerformLayout()
        CType(Me.grdMateriaPrima, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagSubContrato.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grdCusto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagCalculo.ResumeLayout(False)
        CType(Me.grpCalculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCalculo.ResumeLayout(False)
        Me.grpCalculo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdProducao As Janus.Windows.GridEX.GridEX
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagProducao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnConfigurarGridProducao As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAgruparGridProducao As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridMateriaPrimaExcel As System.Windows.Forms.Button
    Friend WithEvents pagMateriaPrima As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnAgruparGridMateriaPrima As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridMateriaPrima As System.Windows.Forms.Button
    Friend WithEvents grpMateriaPrima As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorTotalMateriaPrima As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTotalMateriaPrima As System.Windows.Forms.Label
    Friend WithEvents txtValorUnitarioDescontoMateriaPrima As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnitarioDescontoMateriaPrima As System.Windows.Forms.Label
    Friend WithEvents lblDescricaoProduto As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoMateriaPrima As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboMateriaPrima As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMateriaPrima As System.Windows.Forms.Label
    Friend WithEvents txtCustoMedioMateriaPrima As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCustoMedioMateriaPrima As System.Windows.Forms.Label
    Friend WithEvents lblMargemLucroMateriaPrima As System.Windows.Forms.Label
    Friend WithEvents lblUnidadeMedidaMateriaPrima As System.Windows.Forms.Label
    Friend WithEvents cboUnidadeMedidaMateriaPrima As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtQuantidadeMateriaPrima As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeMateriaPrima As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarUnidadeMedidaMateriaPrima As System.Windows.Forms.Button
    Friend WithEvents btnProcurarMateriaPrima As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarMateriaPrima As System.Windows.Forms.Button
    Friend WithEvents btnExcluirMateriaPrima As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirMateriaPrima As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdMateriaPrima As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagSubContrato As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdCusto As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelGridProducao As System.Windows.Forms.Button
    Friend WithEvents txtMargemLucroMateriaPrima As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents grpProduto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDesenho As System.Windows.Forms.Label
    Friend WithEvents lblGrupoItem As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarGrupoItem As System.Windows.Forms.Button
    Friend WithEvents lblUnidadeMedida As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents cboUnidadeMedida As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarUnidadeMedida As System.Windows.Forms.Button
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtRevisaoDesenho As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRevisaoDesenho As System.Windows.Forms.Label
    Friend WithEvents txtDesenho As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnArquivoDesenho As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblArquivoDesenho As System.Windows.Forms.Label
    Friend WithEvents txtArquivoDesenho As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNCM As System.Windows.Forms.Label
    Friend WithEvents cboNCM As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarNCM As System.Windows.Forms.Button
    Friend WithEvents pagCalculo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnExcelGridMateriaPrima As System.Windows.Forms.Button
    Friend WithEvents grpCalculo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDescricaoCusto As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoCusto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboTipoCusto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoCusto As System.Windows.Forms.Label
    Friend WithEvents txtValorCusto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorCusto As System.Windows.Forms.Label
    Friend WithEvents btnExcluirCusto As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirCusto As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelGridCusto As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridCusto As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridCusto As System.Windows.Forms.Button
    Friend WithEvents lblValorMateriaPrima As System.Windows.Forms.Label
    Friend WithEvents txtValorMateriaPrima As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorSubtotal2 As System.Windows.Forms.Label
    Friend WithEvents txtValorSubtotal2 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtValorMargem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMargem As System.Windows.Forms.Label
    Friend WithEvents txtMargem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorSubtotal1 As System.Windows.Forms.Label
    Friend WithEvents txtValorSubtotal1 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTransportadora As System.Windows.Forms.Label
    Friend WithEvents txtValorTransportadora As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorSubcontrato As System.Windows.Forms.Label
    Friend WithEvents txtValorSubcontrato As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorFerramentas As System.Windows.Forms.Label
    Friend WithEvents txtValorFerramentas As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorPadronizados As System.Windows.Forms.Label
    Friend WithEvents txtValorPadronizados As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorEmbalagem As System.Windows.Forms.Label
    Friend WithEvents txtValorEmbalagem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTratamentoTermico As System.Windows.Forms.Label
    Friend WithEvents txtValorTratamentoTermico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTratamentoSuperficial As System.Windows.Forms.Label
    Friend WithEvents txtValorTratamentoSuperficial As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorPintura As System.Windows.Forms.Label
    Friend WithEvents txtValorPintura As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorMaoObra As System.Windows.Forms.Label
    Friend WithEvents txtValorMaoObra As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents txtValorTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblLinha As System.Windows.Forms.Label
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtValorTaxaFinanceira As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTaxaFinanceira As System.Windows.Forms.Label
    Friend WithEvents txtTaxaFinanceira As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorSubtotal3 As System.Windows.Forms.Label
    Friend WithEvents txtValorSubtotal3 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtValorCOFINS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtValorPIS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtValorICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaIR As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaIR As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaCOFINS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaCOFINS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaPIS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaPIS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaICMS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtValorIR As Janus.Windows.GridEX.EditControls.NumericEditBox
End Class
