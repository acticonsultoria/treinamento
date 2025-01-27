<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadParceiroNegocioRelacionamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadParceiroNegocioRelacionamento))
        Dim grdContasRecebidas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdContasAberto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings2 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings3 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings4 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim grdContato_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdContato_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdContato_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdEndereco_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdEndereco_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdEndereco_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim grdPedidoVendaProduto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdPedidoVenda_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdOrcamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdOrcamentoProduto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdNotaFiscal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdNotaFiscalProduto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagOperacoesFinanceiras = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridContasAberto = New System.Windows.Forms.Button()
        Me.btnAgruparGridContasAberto = New System.Windows.Forms.Button()
        Me.btnConfigurarGridContasAberto = New System.Windows.Forms.Button()
        Me.btnExcelGridContasRecebidas = New System.Windows.Forms.Button()
        Me.btnAgruparGridContasRecebidas = New System.Windows.Forms.Button()
        Me.btnConfigurarGridContasRecebidas = New System.Windows.Forms.Button()
        Me.grdContasRecebidas = New Janus.Windows.GridEX.GridEX()
        Me.grdContasAberto = New Janus.Windows.GridEX.GridEX()
        Me.pagDadosGerais = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosGerais = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblTipoInscricaoEstadual = New System.Windows.Forms.Label()
        Me.cboTipoInscricaoEstadual = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarVendedorInterno = New System.Windows.Forms.Button()
        Me.lblVendedorInterno = New System.Windows.Forms.Label()
        Me.dtpDataCadastro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataCadastro = New System.Windows.Forms.Label()
        Me.dtpDataFundacao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataFundacao = New System.Windows.Forms.Label()
        Me.btnCadastrarVendedor = New System.Windows.Forms.Button()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.cboVendedor = New Janus.Windows.EditControls.UIComboBox()
        Me.txtInscricaoEstadualSubstitutoTriburario = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoEstadualSubstitutoTriburario = New System.Windows.Forms.Label()
        Me.txtTelefoneRecado = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTelefoneRecado = New System.Windows.Forms.Label()
        Me.txtFax = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.txtTelefone2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTelefone2 = New System.Windows.Forms.Label()
        Me.txtEmail = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtTelefone1 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTelefone1 = New System.Windows.Forms.Label()
        Me.txtInscricaoSuframa = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoSuframa = New System.Windows.Forms.Label()
        Me.cboMunicipio = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumero = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtComplemento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtBairro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.cboPais = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.txtCEP = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.cboUF = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblLogradouro = New System.Windows.Forms.Label()
        Me.txtInscricaoMunicipal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoMunicipal = New System.Windows.Forms.Label()
        Me.txtInscricaoEstadual = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoEstadual = New System.Windows.Forms.Label()
        Me.txtCnpjCpf = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCnpjCpf = New System.Windows.Forms.Label()
        Me.txtLogradouro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnProcurarCEP = New System.Windows.Forms.Button()
        Me.btnCadastrarPais = New System.Windows.Forms.Button()
        Me.cboVendedorInterno = New Janus.Windows.EditControls.UIComboBox()
        Me.pagContatos = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpEndereco = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarTipoContato = New System.Windows.Forms.Button()
        Me.dtpDataAniversario = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataAniversario = New System.Windows.Forms.Label()
        Me.txtCelularContato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCelularContato = New System.Windows.Forms.Label()
        Me.txtTelefoneContato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTipoContato = New System.Windows.Forms.Label()
        Me.cboTipoContato = New Janus.Windows.EditControls.UIComboBox()
        Me.txtEmailContato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtComplementoContato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNomeContato = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblComplementoContato = New System.Windows.Forms.Label()
        Me.lblEmailContato = New System.Windows.Forms.Label()
        Me.lblTelefoneContato = New System.Windows.Forms.Label()
        Me.lblNomeContato = New System.Windows.Forms.Label()
        Me.btnExcluirContato = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvarContato = New Janus.Windows.EditControls.UIButton()
        Me.btnExcelGridContato = New System.Windows.Forms.Button()
        Me.btnAgruparGridContato = New System.Windows.Forms.Button()
        Me.btnConfigurarGridContato = New System.Windows.Forms.Button()
        Me.grdContato = New Janus.Windows.GridEX.GridEX()
        Me.pagEnderecos = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridEndereco = New System.Windows.Forms.Button()
        Me.btnAgruparGridEndereco = New System.Windows.Forms.Button()
        Me.btnConfigurarGridEndereco = New System.Windows.Forms.Button()
        Me.grdEndereco = New Janus.Windows.GridEX.GridEX()
        Me.grpEnderecoCobranca = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluirEndereco = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvarEndereco = New Janus.Windows.EditControls.UIButton()
        Me.btnProcurarCepEndereco = New System.Windows.Forms.Button()
        Me.btnCadastrarPaisEndereco = New System.Windows.Forms.Button()
        Me.cboMunicipioEndereco = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumeroEndereco = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtComplementoEndereco = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtBairroEndereco = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPaisEndereco = New System.Windows.Forms.Label()
        Me.cboPaisEndereco = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCepEndereco = New System.Windows.Forms.Label()
        Me.txtCepEndereco = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblComplementoEndereco = New System.Windows.Forms.Label()
        Me.lblUFEndereco = New System.Windows.Forms.Label()
        Me.cboUFEndereco = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMunicipioEndereco = New System.Windows.Forms.Label()
        Me.lblBairroEndereco = New System.Windows.Forms.Label()
        Me.lblNumeroEndereco = New System.Windows.Forms.Label()
        Me.lblLogradouroEndereco = New System.Windows.Forms.Label()
        Me.txtLogradouroEndereco = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTipoEndereco = New System.Windows.Forms.Label()
        Me.cboTipoEndereco = New Janus.Windows.EditControls.UIComboBox()
        Me.pagPedidoVenda = New Janus.Windows.UI.Tab.UITabPage()
        Me.dtpDataTerminoPedidoVenda = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioPedidoVenda = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblPeriodoPedidoVenda = New System.Windows.Forms.Label()
        Me.btnExcelGridPedidoVendaProduto = New System.Windows.Forms.Button()
        Me.btnAgruparGridPedidoVendaProduto = New System.Windows.Forms.Button()
        Me.btnConfigurarGridPedidoVendaProduto = New System.Windows.Forms.Button()
        Me.grdPedidoVendaProduto = New Janus.Windows.GridEX.GridEX()
        Me.btnExcelGridPedido = New System.Windows.Forms.Button()
        Me.btnAgruparGridPedido = New System.Windows.Forms.Button()
        Me.btnConfigurarGridPedido = New System.Windows.Forms.Button()
        Me.grdPedidoVenda = New Janus.Windows.GridEX.GridEX()
        Me.pagOrcamento = New Janus.Windows.UI.Tab.UITabPage()
        Me.dtpDataTerminoOrcamento = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioOrcamento = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblPeriodoOrcamento = New System.Windows.Forms.Label()
        Me.btnExcelGridOrcamentoProduto = New System.Windows.Forms.Button()
        Me.btnAgruparGridOrcamentoProduto = New System.Windows.Forms.Button()
        Me.btnConfigurarGridOrcamentoProduto = New System.Windows.Forms.Button()
        Me.btnExcelGridOrcamento = New System.Windows.Forms.Button()
        Me.btnAgruparGridOrcamento = New System.Windows.Forms.Button()
        Me.btnConfigurarGridOrcamento = New System.Windows.Forms.Button()
        Me.grdOrcamento = New Janus.Windows.GridEX.GridEX()
        Me.grdOrcamentoProduto = New Janus.Windows.GridEX.GridEX()
        Me.pagNotaFiscal = New Janus.Windows.UI.Tab.UITabPage()
        Me.dtpDataTerminoNotaFiscal = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioNotaFiscal = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblPeriodoNotaFiscal = New System.Windows.Forms.Label()
        Me.btnExcelGridNotaFiscalProduto = New System.Windows.Forms.Button()
        Me.btnAgruparGridNotaFiscalProduto = New System.Windows.Forms.Button()
        Me.btnConfigurarGridNotaFiscalProduto = New System.Windows.Forms.Button()
        Me.btnExcelGridNotaFiscal = New System.Windows.Forms.Button()
        Me.btnAgruparGridNotaFiscal = New System.Windows.Forms.Button()
        Me.btnConfigurarGridNotaFiscal = New System.Windows.Forms.Button()
        Me.grdNotaFiscal = New Janus.Windows.GridEX.GridEX()
        Me.grdNotaFiscalProduto = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblPersonalidade = New System.Windows.Forms.Label()
        Me.cboPersonalidade = New Janus.Windows.EditControls.UIComboBox()
        Me.btnProcurarParceiroNegocio = New System.Windows.Forms.Button()
        Me.cboParceiroNegocioFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblParceiroNegocioFiltro = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagOperacoesFinanceiras.SuspendLayout()
        CType(Me.grdContasRecebidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdContasAberto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDadosGerais.SuspendLayout()
        CType(Me.grpDadosGerais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosGerais.SuspendLayout()
        Me.pagContatos.SuspendLayout()
        CType(Me.grpEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEndereco.SuspendLayout()
        CType(Me.grdContato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagEnderecos.SuspendLayout()
        CType(Me.grdEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpEnderecoCobranca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEnderecoCobranca.SuspendLayout()
        Me.pagPedidoVenda.SuspendLayout()
        CType(Me.grdPedidoVendaProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPedidoVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagOrcamento.SuspendLayout()
        CType(Me.grdOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdOrcamentoProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagNotaFiscal.SuspendLayout()
        CType(Me.grdNotaFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdNotaFiscalProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.tabDados)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpControl)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(998, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Parceiro de Negócio - Relacionamento"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.FlatBorderColor = System.Drawing.Color.Transparent
        Me.tabDados.Location = New System.Drawing.Point(8, 73)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(982, 407)
        Me.tabDados.TabIndex = 3
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagOperacoesFinanceiras, Me.pagDadosGerais, Me.pagContatos, Me.pagEnderecos, Me.pagPedidoVenda, Me.pagOrcamento, Me.pagNotaFiscal})
        Me.tabDados.TabStop = False
        Me.tabDados.Tag = ""
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagOperacoesFinanceiras
        '
        Me.pagOperacoesFinanceiras.Controls.Add(Me.btnExcelGridContasAberto)
        Me.pagOperacoesFinanceiras.Controls.Add(Me.btnAgruparGridContasAberto)
        Me.pagOperacoesFinanceiras.Controls.Add(Me.btnConfigurarGridContasAberto)
        Me.pagOperacoesFinanceiras.Controls.Add(Me.btnExcelGridContasRecebidas)
        Me.pagOperacoesFinanceiras.Controls.Add(Me.btnAgruparGridContasRecebidas)
        Me.pagOperacoesFinanceiras.Controls.Add(Me.btnConfigurarGridContasRecebidas)
        Me.pagOperacoesFinanceiras.Controls.Add(Me.grdContasRecebidas)
        Me.pagOperacoesFinanceiras.Controls.Add(Me.grdContasAberto)
        Me.pagOperacoesFinanceiras.Key = "pagTituloPendentes"
        Me.pagOperacoesFinanceiras.Location = New System.Drawing.Point(1, 22)
        Me.pagOperacoesFinanceiras.Name = "pagOperacoesFinanceiras"
        Me.pagOperacoesFinanceiras.Size = New System.Drawing.Size(980, 384)
        Me.pagOperacoesFinanceiras.TabStop = True
        Me.pagOperacoesFinanceiras.Text = "Histórico Financeiro"
        '
        'btnExcelGridContasAberto
        '
        Me.btnExcelGridContasAberto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridContasAberto.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridContasAberto.FlatAppearance.BorderSize = 0
        Me.btnExcelGridContasAberto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridContasAberto.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridContasAberto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridContasAberto.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridContasAberto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridContasAberto.Name = "btnExcelGridContasAberto"
        Me.btnExcelGridContasAberto.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridContasAberto.TabIndex = 22
        Me.btnExcelGridContasAberto.TabStop = False
        Me.btnExcelGridContasAberto.UseVisualStyleBackColor = False
        '
        'btnAgruparGridContasAberto
        '
        Me.btnAgruparGridContasAberto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridContasAberto.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridContasAberto.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridContasAberto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridContasAberto.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridContasAberto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridContasAberto.Location = New System.Drawing.Point(33, 358)
        Me.btnAgruparGridContasAberto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridContasAberto.Name = "btnAgruparGridContasAberto"
        Me.btnAgruparGridContasAberto.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridContasAberto.TabIndex = 21
        Me.btnAgruparGridContasAberto.TabStop = False
        Me.btnAgruparGridContasAberto.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridContasAberto
        '
        Me.btnConfigurarGridContasAberto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridContasAberto.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridContasAberto.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridContasAberto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridContasAberto.Image = CType(resources.GetObject("btnConfigurarGridContasAberto.Image"), System.Drawing.Image)
        Me.btnConfigurarGridContasAberto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridContasAberto.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridContasAberto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridContasAberto.Name = "btnConfigurarGridContasAberto"
        Me.btnConfigurarGridContasAberto.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridContasAberto.TabIndex = 20
        Me.btnConfigurarGridContasAberto.TabStop = False
        Me.btnConfigurarGridContasAberto.UseVisualStyleBackColor = False
        '
        'btnExcelGridContasRecebidas
        '
        Me.btnExcelGridContasRecebidas.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridContasRecebidas.FlatAppearance.BorderSize = 0
        Me.btnExcelGridContasRecebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridContasRecebidas.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridContasRecebidas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridContasRecebidas.Location = New System.Drawing.Point(57, 171)
        Me.btnExcelGridContasRecebidas.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridContasRecebidas.Name = "btnExcelGridContasRecebidas"
        Me.btnExcelGridContasRecebidas.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridContasRecebidas.TabIndex = 18
        Me.btnExcelGridContasRecebidas.TabStop = False
        Me.btnExcelGridContasRecebidas.UseVisualStyleBackColor = False
        '
        'btnAgruparGridContasRecebidas
        '
        Me.btnAgruparGridContasRecebidas.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridContasRecebidas.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridContasRecebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridContasRecebidas.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridContasRecebidas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridContasRecebidas.Location = New System.Drawing.Point(33, 171)
        Me.btnAgruparGridContasRecebidas.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridContasRecebidas.Name = "btnAgruparGridContasRecebidas"
        Me.btnAgruparGridContasRecebidas.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridContasRecebidas.TabIndex = 17
        Me.btnAgruparGridContasRecebidas.TabStop = False
        Me.btnAgruparGridContasRecebidas.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridContasRecebidas
        '
        Me.btnConfigurarGridContasRecebidas.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridContasRecebidas.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridContasRecebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridContasRecebidas.Image = CType(resources.GetObject("btnConfigurarGridContasRecebidas.Image"), System.Drawing.Image)
        Me.btnConfigurarGridContasRecebidas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridContasRecebidas.Location = New System.Drawing.Point(9, 171)
        Me.btnConfigurarGridContasRecebidas.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridContasRecebidas.Name = "btnConfigurarGridContasRecebidas"
        Me.btnConfigurarGridContasRecebidas.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridContasRecebidas.TabIndex = 8
        Me.btnConfigurarGridContasRecebidas.TabStop = False
        Me.btnConfigurarGridContasRecebidas.UseVisualStyleBackColor = False
        '
        'grdContasRecebidas
        '
        Me.grdContasRecebidas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdContasRecebidas.AlternatingColors = True
        Me.grdContasRecebidas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdContasRecebidas_DesignTimeLayout.LayoutString = resources.GetString("grdContasRecebidas_DesignTimeLayout.LayoutString")
        Me.grdContasRecebidas.DesignTimeLayout = grdContasRecebidas_DesignTimeLayout
        Me.grdContasRecebidas.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdContasRecebidas.FilterRowFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.[True]
        Me.grdContasRecebidas.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdContasRecebidas.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdContasRecebidas.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdContasRecebidas.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdContasRecebidas.GroupByBoxVisible = False
        Me.grdContasRecebidas.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdContasRecebidas.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdContasRecebidas.Location = New System.Drawing.Point(8, 9)
        Me.grdContasRecebidas.Name = "grdContasRecebidas"
        Me.grdContasRecebidas.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdContasRecebidas.RecordNavigator = True
        Me.grdContasRecebidas.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdContasRecebidas.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdContasRecebidas.Size = New System.Drawing.Size(964, 179)
        Me.grdContasRecebidas.TabIndex = 2
        Me.grdContasRecebidas.TabStop = False
        Me.grdContasRecebidas.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdContasRecebidas.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdContasRecebidas.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdContasRecebidas.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdContasRecebidas.VisualStyleManager = Me.vsmMain
        '
        'grdContasAberto
        '
        Me.grdContasAberto.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdContasAberto.AlternatingColors = True
        Me.grdContasAberto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdContasAberto.ColumnAutoResize = True
        grdContasAberto_DesignTimeLayout.LayoutString = resources.GetString("grdContasAberto_DesignTimeLayout.LayoutString")
        Me.grdContasAberto.DesignTimeLayout = grdContasAberto_DesignTimeLayout
        Me.grdContasAberto.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdContasAberto.FilterRowFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.[True]
        Me.grdContasAberto.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdContasAberto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdContasAberto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdContasAberto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdContasAberto.GroupByBoxVisible = False
        Me.grdContasAberto.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdContasAberto.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdContasAberto.Location = New System.Drawing.Point(8, 197)
        Me.grdContasAberto.Name = "grdContasAberto"
        Me.grdContasAberto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdContasAberto.RecordNavigator = True
        Me.grdContasAberto.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdContasAberto.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdContasAberto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdContasAberto.Size = New System.Drawing.Size(964, 178)
        Me.grdContasAberto.TabIndex = 19
        Me.grdContasAberto.TabStop = False
        Me.grdContasAberto.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdContasAberto.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdContasAberto.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdContasAberto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdContasAberto.VisualStyleManager = Me.vsmMain
        '
        'pagDadosGerais
        '
        Me.pagDadosGerais.Controls.Add(Me.grpDadosGerais)
        Me.pagDadosGerais.Key = "pagDadosGerais"
        Me.pagDadosGerais.Location = New System.Drawing.Point(1, 22)
        Me.pagDadosGerais.Name = "pagDadosGerais"
        Me.pagDadosGerais.Size = New System.Drawing.Size(980, 384)
        Me.pagDadosGerais.TabStop = True
        Me.pagDadosGerais.Text = "Dados Gerais"
        '
        'grpDadosGerais
        '
        Me.grpDadosGerais.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosGerais.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosGerais.Controls.Add(Me.lblTipoInscricaoEstadual)
        Me.grpDadosGerais.Controls.Add(Me.cboTipoInscricaoEstadual)
        Me.grpDadosGerais.Controls.Add(Me.btnCadastrarVendedorInterno)
        Me.grpDadosGerais.Controls.Add(Me.lblVendedorInterno)
        Me.grpDadosGerais.Controls.Add(Me.dtpDataCadastro)
        Me.grpDadosGerais.Controls.Add(Me.lblDataCadastro)
        Me.grpDadosGerais.Controls.Add(Me.dtpDataFundacao)
        Me.grpDadosGerais.Controls.Add(Me.lblDataFundacao)
        Me.grpDadosGerais.Controls.Add(Me.btnCadastrarVendedor)
        Me.grpDadosGerais.Controls.Add(Me.lblVendedor)
        Me.grpDadosGerais.Controls.Add(Me.cboVendedor)
        Me.grpDadosGerais.Controls.Add(Me.txtInscricaoEstadualSubstitutoTriburario)
        Me.grpDadosGerais.Controls.Add(Me.lblInscricaoEstadualSubstitutoTriburario)
        Me.grpDadosGerais.Controls.Add(Me.txtTelefoneRecado)
        Me.grpDadosGerais.Controls.Add(Me.lblTelefoneRecado)
        Me.grpDadosGerais.Controls.Add(Me.txtFax)
        Me.grpDadosGerais.Controls.Add(Me.lblFax)
        Me.grpDadosGerais.Controls.Add(Me.txtTelefone2)
        Me.grpDadosGerais.Controls.Add(Me.lblTelefone2)
        Me.grpDadosGerais.Controls.Add(Me.txtEmail)
        Me.grpDadosGerais.Controls.Add(Me.lblEmail)
        Me.grpDadosGerais.Controls.Add(Me.txtTelefone1)
        Me.grpDadosGerais.Controls.Add(Me.lblTelefone1)
        Me.grpDadosGerais.Controls.Add(Me.txtInscricaoSuframa)
        Me.grpDadosGerais.Controls.Add(Me.lblInscricaoSuframa)
        Me.grpDadosGerais.Controls.Add(Me.cboMunicipio)
        Me.grpDadosGerais.Controls.Add(Me.txtNumero)
        Me.grpDadosGerais.Controls.Add(Me.txtComplemento)
        Me.grpDadosGerais.Controls.Add(Me.txtBairro)
        Me.grpDadosGerais.Controls.Add(Me.txtObservacao)
        Me.grpDadosGerais.Controls.Add(Me.lblObservacao)
        Me.grpDadosGerais.Controls.Add(Me.lblPais)
        Me.grpDadosGerais.Controls.Add(Me.cboPais)
        Me.grpDadosGerais.Controls.Add(Me.lblCEP)
        Me.grpDadosGerais.Controls.Add(Me.txtCEP)
        Me.grpDadosGerais.Controls.Add(Me.lblComplemento)
        Me.grpDadosGerais.Controls.Add(Me.lblUF)
        Me.grpDadosGerais.Controls.Add(Me.cboUF)
        Me.grpDadosGerais.Controls.Add(Me.lblMunicipio)
        Me.grpDadosGerais.Controls.Add(Me.lblBairro)
        Me.grpDadosGerais.Controls.Add(Me.lblNumero)
        Me.grpDadosGerais.Controls.Add(Me.lblLogradouro)
        Me.grpDadosGerais.Controls.Add(Me.txtInscricaoMunicipal)
        Me.grpDadosGerais.Controls.Add(Me.lblInscricaoMunicipal)
        Me.grpDadosGerais.Controls.Add(Me.txtInscricaoEstadual)
        Me.grpDadosGerais.Controls.Add(Me.lblInscricaoEstadual)
        Me.grpDadosGerais.Controls.Add(Me.txtCnpjCpf)
        Me.grpDadosGerais.Controls.Add(Me.lblCnpjCpf)
        Me.grpDadosGerais.Controls.Add(Me.txtLogradouro)
        Me.grpDadosGerais.Controls.Add(Me.btnProcurarCEP)
        Me.grpDadosGerais.Controls.Add(Me.btnCadastrarPais)
        Me.grpDadosGerais.Controls.Add(Me.cboVendedorInterno)
        Me.grpDadosGerais.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosGerais.Name = "grpDadosGerais"
        Me.grpDadosGerais.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosGerais.Size = New System.Drawing.Size(964, 373)
        Me.grpDadosGerais.TabIndex = 1
        Me.grpDadosGerais.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosGerais.VisualStyleManager = Me.vsmMain
        '
        'lblTipoInscricaoEstadual
        '
        Me.lblTipoInscricaoEstadual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoInscricaoEstadual.AutoSize = True
        Me.lblTipoInscricaoEstadual.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoInscricaoEstadual.Location = New System.Drawing.Point(616, 57)
        Me.lblTipoInscricaoEstadual.Name = "lblTipoInscricaoEstadual"
        Me.lblTipoInscricaoEstadual.Size = New System.Drawing.Size(136, 14)
        Me.lblTipoInscricaoEstadual.TabIndex = 19
        Me.lblTipoInscricaoEstadual.Text = "Tipo de Inscrição Estadual:"
        '
        'cboTipoInscricaoEstadual
        '
        Me.cboTipoInscricaoEstadual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoInscricaoEstadual.AutoSize = False
        Me.cboTipoInscricaoEstadual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoInscricaoEstadual.Location = New System.Drawing.Point(619, 74)
        Me.cboTipoInscricaoEstadual.Name = "cboTipoInscricaoEstadual"
        Me.cboTipoInscricaoEstadual.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoInscricaoEstadual.Size = New System.Drawing.Size(336, 20)
        Me.cboTipoInscricaoEstadual.TabIndex = 20
        '
        'btnCadastrarVendedorInterno
        '
        Me.btnCadastrarVendedorInterno.FlatAppearance.BorderSize = 0
        Me.btnCadastrarVendedorInterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarVendedorInterno.Image = CType(resources.GetObject("btnCadastrarVendedorInterno.Image"), System.Drawing.Image)
        Me.btnCadastrarVendedorInterno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarVendedorInterno.Location = New System.Drawing.Point(475, 138)
        Me.btnCadastrarVendedorInterno.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarVendedorInterno.Name = "btnCadastrarVendedorInterno"
        Me.btnCadastrarVendedorInterno.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarVendedorInterno.TabIndex = 42
        Me.btnCadastrarVendedorInterno.TabStop = False
        Me.btnCadastrarVendedorInterno.UseVisualStyleBackColor = True
        '
        'lblVendedorInterno
        '
        Me.lblVendedorInterno.AutoSize = True
        Me.lblVendedorInterno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVendedorInterno.Location = New System.Drawing.Point(491, 137)
        Me.lblVendedorInterno.Name = "lblVendedorInterno"
        Me.lblVendedorInterno.Size = New System.Drawing.Size(93, 14)
        Me.lblVendedorInterno.TabIndex = 43
        Me.lblVendedorInterno.Text = "Vendedor Interno:"
        '
        'dtpDataCadastro
        '
        '
        '
        '
        Me.dtpDataCadastro.DropDownCalendar.Name = ""
        Me.dtpDataCadastro.Location = New System.Drawing.Point(847, 154)
        Me.dtpDataCadastro.Name = "dtpDataCadastro"
        Me.dtpDataCadastro.ShowCheckBox = True
        Me.dtpDataCadastro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataCadastro.TabIndex = 48
        Me.dtpDataCadastro.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblDataCadastro
        '
        Me.lblDataCadastro.AutoSize = True
        Me.lblDataCadastro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataCadastro.Location = New System.Drawing.Point(844, 137)
        Me.lblDataCadastro.Name = "lblDataCadastro"
        Me.lblDataCadastro.Size = New System.Drawing.Size(79, 14)
        Me.lblDataCadastro.TabIndex = 47
        Me.lblDataCadastro.Text = "Data Cadastro:"
        '
        'dtpDataFundacao
        '
        '
        '
        '
        Me.dtpDataFundacao.DropDownCalendar.Name = ""
        Me.dtpDataFundacao.Location = New System.Drawing.Point(733, 154)
        Me.dtpDataFundacao.Name = "dtpDataFundacao"
        Me.dtpDataFundacao.ShowCheckBox = True
        Me.dtpDataFundacao.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataFundacao.TabIndex = 46
        Me.dtpDataFundacao.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblDataFundacao
        '
        Me.lblDataFundacao.AutoSize = True
        Me.lblDataFundacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataFundacao.Location = New System.Drawing.Point(730, 137)
        Me.lblDataFundacao.Name = "lblDataFundacao"
        Me.lblDataFundacao.Size = New System.Drawing.Size(83, 14)
        Me.lblDataFundacao.TabIndex = 45
        Me.lblDataFundacao.Text = "Data Fundação:"
        '
        'btnCadastrarVendedor
        '
        Me.btnCadastrarVendedor.FlatAppearance.BorderSize = 0
        Me.btnCadastrarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarVendedor.Image = CType(resources.GetObject("btnCadastrarVendedor.Image"), System.Drawing.Image)
        Me.btnCadastrarVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarVendedor.Location = New System.Drawing.Point(247, 138)
        Me.btnCadastrarVendedor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarVendedor.Name = "btnCadastrarVendedor"
        Me.btnCadastrarVendedor.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarVendedor.TabIndex = 39
        Me.btnCadastrarVendedor.TabStop = False
        Me.btnCadastrarVendedor.UseVisualStyleBackColor = True
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVendedor.Location = New System.Drawing.Point(263, 137)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(97, 14)
        Me.lblVendedor.TabIndex = 40
        Me.lblVendedor.Text = "Vendedor Externo:"
        '
        'cboVendedor
        '
        Me.cboVendedor.AutoSize = False
        Me.cboVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboVendedor.Location = New System.Drawing.Point(247, 154)
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboVendedor.Size = New System.Drawing.Size(222, 20)
        Me.cboVendedor.TabIndex = 41
        '
        'txtInscricaoEstadualSubstitutoTriburario
        '
        Me.txtInscricaoEstadualSubstitutoTriburario.Location = New System.Drawing.Point(128, 114)
        Me.txtInscricaoEstadualSubstitutoTriburario.MaxLength = 14
        Me.txtInscricaoEstadualSubstitutoTriburario.Name = "txtInscricaoEstadualSubstitutoTriburario"
        Me.txtInscricaoEstadualSubstitutoTriburario.Size = New System.Drawing.Size(113, 20)
        SuperTipSettings1.ImageListProvider = Nothing
        Me.jstTip.SetSuperTip(Me.txtInscricaoEstadualSubstitutoTriburario, SuperTipSettings1)
        Me.txtInscricaoEstadualSubstitutoTriburario.TabIndex = 24
        '
        'lblInscricaoEstadualSubstitutoTriburario
        '
        Me.lblInscricaoEstadualSubstitutoTriburario.AutoSize = True
        Me.lblInscricaoEstadualSubstitutoTriburario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInscricaoEstadualSubstitutoTriburario.Location = New System.Drawing.Point(125, 97)
        Me.lblInscricaoEstadualSubstitutoTriburario.Name = "lblInscricaoEstadualSubstitutoTriburario"
        Me.lblInscricaoEstadualSubstitutoTriburario.Size = New System.Drawing.Size(82, 14)
        Me.lblInscricaoEstadualSubstitutoTriburario.TabIndex = 23
        Me.lblInscricaoEstadualSubstitutoTriburario.Text = "IE Subs. Tribut.:"
        '
        'txtTelefoneRecado
        '
        Me.txtTelefoneRecado.Location = New System.Drawing.Point(128, 154)
        Me.txtTelefoneRecado.Mask = "!(##) 0000-0000"
        Me.txtTelefoneRecado.MaxLength = 10
        Me.txtTelefoneRecado.Name = "txtTelefoneRecado"
        Me.txtTelefoneRecado.Size = New System.Drawing.Size(113, 20)
        Me.txtTelefoneRecado.TabIndex = 38
        '
        'lblTelefoneRecado
        '
        Me.lblTelefoneRecado.AutoSize = True
        Me.lblTelefoneRecado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTelefoneRecado.Location = New System.Drawing.Point(125, 137)
        Me.lblTelefoneRecado.Name = "lblTelefoneRecado"
        Me.lblTelefoneRecado.Size = New System.Drawing.Size(47, 14)
        Me.lblTelefoneRecado.TabIndex = 37
        Me.lblTelefoneRecado.Text = "Recado:"
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(9, 154)
        Me.txtFax.Mask = "!(##) 0000-0000"
        Me.txtFax.MaxLength = 10
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(113, 20)
        Me.txtFax.TabIndex = 36
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFax.Location = New System.Drawing.Point(6, 137)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(28, 14)
        Me.lblFax.TabIndex = 35
        Me.lblFax.Text = "Fax:"
        '
        'txtTelefone2
        '
        Me.txtTelefone2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefone2.Location = New System.Drawing.Point(847, 114)
        Me.txtTelefone2.Mask = "!(##) 0000-0000"
        Me.txtTelefone2.MaxLength = 10
        Me.txtTelefone2.Name = "txtTelefone2"
        Me.txtTelefone2.Size = New System.Drawing.Size(108, 20)
        Me.txtTelefone2.TabIndex = 34
        '
        'lblTelefone2
        '
        Me.lblTelefone2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTelefone2.AutoSize = True
        Me.lblTelefone2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTelefone2.Location = New System.Drawing.Point(844, 97)
        Me.lblTelefone2.Name = "lblTelefone2"
        Me.lblTelefone2.Size = New System.Drawing.Size(60, 14)
        Me.lblTelefone2.TabIndex = 33
        Me.lblTelefone2.Text = "Telefone 2:"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Location = New System.Drawing.Point(475, 114)
        Me.txtEmail.MaxLength = 60
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(252, 20)
        Me.txtEmail.TabIndex = 30
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEmail.Location = New System.Drawing.Point(472, 97)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(38, 14)
        Me.lblEmail.TabIndex = 29
        Me.lblEmail.Text = "E-mail:"
        '
        'txtTelefone1
        '
        Me.txtTelefone1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefone1.Location = New System.Drawing.Point(733, 114)
        Me.txtTelefone1.Mask = "!(##) 0000-0000"
        Me.txtTelefone1.MaxLength = 10
        Me.txtTelefone1.Name = "txtTelefone1"
        Me.txtTelefone1.Size = New System.Drawing.Size(108, 20)
        Me.txtTelefone1.TabIndex = 32
        '
        'lblTelefone1
        '
        Me.lblTelefone1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTelefone1.AutoSize = True
        Me.lblTelefone1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTelefone1.Location = New System.Drawing.Point(730, 97)
        Me.lblTelefone1.Name = "lblTelefone1"
        Me.lblTelefone1.Size = New System.Drawing.Size(60, 14)
        Me.lblTelefone1.TabIndex = 31
        Me.lblTelefone1.Text = "Telefone 1:"
        '
        'txtInscricaoSuframa
        '
        Me.txtInscricaoSuframa.Location = New System.Drawing.Point(361, 114)
        Me.txtInscricaoSuframa.MaxLength = 9
        Me.txtInscricaoSuframa.Name = "txtInscricaoSuframa"
        Me.txtInscricaoSuframa.Size = New System.Drawing.Size(108, 20)
        SuperTipSettings2.HeaderText = "Inscrição Suframa"
        SuperTipSettings2.ImageListProvider = Nothing
        SuperTipSettings2.Text = "Preencher Inscrição Suframa (somente números)"
        Me.jstTip.SetSuperTip(Me.txtInscricaoSuframa, SuperTipSettings2)
        Me.txtInscricaoSuframa.TabIndex = 28
        '
        'lblInscricaoSuframa
        '
        Me.lblInscricaoSuframa.AutoSize = True
        Me.lblInscricaoSuframa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInscricaoSuframa.Location = New System.Drawing.Point(358, 97)
        Me.lblInscricaoSuframa.Name = "lblInscricaoSuframa"
        Me.lblInscricaoSuframa.Size = New System.Drawing.Size(98, 14)
        Me.lblInscricaoSuframa.TabIndex = 27
        Me.lblInscricaoSuframa.Text = "Inscrição Suframa:"
        '
        'cboMunicipio
        '
        Me.cboMunicipio.AutoSize = False
        Me.cboMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMunicipio.Location = New System.Drawing.Point(311, 34)
        Me.cboMunicipio.Name = "cboMunicipio"
        Me.cboMunicipio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMunicipio.Size = New System.Drawing.Size(302, 20)
        Me.cboMunicipio.TabIndex = 8
        '
        'txtNumero
        '
        Me.txtNumero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.Location = New System.Drawing.Point(891, 34)
        Me.txtNumero.MaxLength = 60
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(64, 20)
        Me.txtNumero.TabIndex = 12
        '
        'txtComplemento
        '
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento.Location = New System.Drawing.Point(247, 74)
        Me.txtComplemento.MaxLength = 60
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(252, 20)
        Me.txtComplemento.TabIndex = 16
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Location = New System.Drawing.Point(9, 74)
        Me.txtBairro.MaxLength = 60
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(232, 20)
        Me.txtBairro.TabIndex = 14
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Location = New System.Drawing.Point(9, 194)
        Me.txtObservacao.MaxLength = 0
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacao.Size = New System.Drawing.Size(946, 170)
        Me.txtObservacao.TabIndex = 50
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblObservacao.Location = New System.Drawing.Point(6, 177)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacao.TabIndex = 49
        Me.lblObservacao.Text = "Observação:"
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPais.Location = New System.Drawing.Point(98, 17)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(30, 14)
        Me.lblPais.TabIndex = 3
        Me.lblPais.Text = "País:"
        '
        'cboPais
        '
        Me.cboPais.AutoSize = False
        Me.cboPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPais.Location = New System.Drawing.Point(82, 34)
        Me.cboPais.Name = "cboPais"
        Me.cboPais.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPais.Size = New System.Drawing.Size(159, 20)
        Me.cboPais.TabIndex = 4
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCEP.Location = New System.Drawing.Point(6, 17)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(29, 14)
        Me.lblCEP.TabIndex = 0
        Me.lblCEP.Text = "CEP:"
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(9, 34)
        Me.txtCEP.Mask = "00000-000"
        Me.txtCEP.MaxLength = 10
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(67, 20)
        Me.txtCEP.TabIndex = 1
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblComplemento.Location = New System.Drawing.Point(244, 57)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(74, 14)
        Me.lblComplemento.TabIndex = 15
        Me.lblComplemento.Text = "Complemento:"
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUF.Location = New System.Drawing.Point(244, 17)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(23, 14)
        Me.lblUF.TabIndex = 5
        Me.lblUF.Text = "UF:"
        '
        'cboUF
        '
        Me.cboUF.AutoSize = False
        Me.cboUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUF.Location = New System.Drawing.Point(247, 34)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUF.Size = New System.Drawing.Size(58, 20)
        Me.cboUF.TabIndex = 6
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMunicipio.Location = New System.Drawing.Point(308, 17)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(54, 14)
        Me.lblMunicipio.TabIndex = 7
        Me.lblMunicipio.Text = "Município:"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBairro.Location = New System.Drawing.Point(6, 57)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(39, 14)
        Me.lblBairro.TabIndex = 13
        Me.lblBairro.Text = "Bairro:"
        '
        'lblNumero
        '
        Me.lblNumero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumero.AutoSize = True
        Me.lblNumero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumero.Location = New System.Drawing.Point(888, 17)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(47, 14)
        Me.lblNumero.TabIndex = 11
        Me.lblNumero.Text = "Número:"
        '
        'lblLogradouro
        '
        Me.lblLogradouro.AutoSize = True
        Me.lblLogradouro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLogradouro.Location = New System.Drawing.Point(616, 17)
        Me.lblLogradouro.Name = "lblLogradouro"
        Me.lblLogradouro.Size = New System.Drawing.Size(66, 14)
        Me.lblLogradouro.TabIndex = 9
        Me.lblLogradouro.Text = "Logradouro:"
        '
        'txtInscricaoMunicipal
        '
        Me.txtInscricaoMunicipal.Location = New System.Drawing.Point(247, 114)
        Me.txtInscricaoMunicipal.MaxLength = 15
        Me.txtInscricaoMunicipal.Name = "txtInscricaoMunicipal"
        Me.txtInscricaoMunicipal.Size = New System.Drawing.Size(108, 20)
        SuperTipSettings3.HeaderText = "Inscrição Municipal"
        SuperTipSettings3.ImageListProvider = Nothing
        SuperTipSettings3.Text = "Preencher Inscrição Municipal (somente números)"
        Me.jstTip.SetSuperTip(Me.txtInscricaoMunicipal, SuperTipSettings3)
        Me.txtInscricaoMunicipal.TabIndex = 26
        '
        'lblInscricaoMunicipal
        '
        Me.lblInscricaoMunicipal.AutoSize = True
        Me.lblInscricaoMunicipal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInscricaoMunicipal.Location = New System.Drawing.Point(244, 97)
        Me.lblInscricaoMunicipal.Name = "lblInscricaoMunicipal"
        Me.lblInscricaoMunicipal.Size = New System.Drawing.Size(101, 14)
        Me.lblInscricaoMunicipal.TabIndex = 25
        Me.lblInscricaoMunicipal.Text = "Inscrição Municipal:"
        '
        'txtInscricaoEstadual
        '
        Me.txtInscricaoEstadual.Location = New System.Drawing.Point(9, 114)
        Me.txtInscricaoEstadual.MaxLength = 14
        Me.txtInscricaoEstadual.Name = "txtInscricaoEstadual"
        Me.txtInscricaoEstadual.Size = New System.Drawing.Size(113, 20)
        SuperTipSettings4.HeaderText = "Inscrição Estadual"
        SuperTipSettings4.ImageListProvider = Nothing
        SuperTipSettings4.Text = resources.GetString("SuperTipSettings4.Text")
        Me.jstTip.SetSuperTip(Me.txtInscricaoEstadual, SuperTipSettings4)
        Me.txtInscricaoEstadual.TabIndex = 22
        '
        'lblInscricaoEstadual
        '
        Me.lblInscricaoEstadual.AutoSize = True
        Me.lblInscricaoEstadual.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInscricaoEstadual.Location = New System.Drawing.Point(6, 97)
        Me.lblInscricaoEstadual.Name = "lblInscricaoEstadual"
        Me.lblInscricaoEstadual.Size = New System.Drawing.Size(92, 14)
        Me.lblInscricaoEstadual.TabIndex = 21
        Me.lblInscricaoEstadual.Text = "Incrição Estadual:"
        '
        'txtCnpjCpf
        '
        Me.txtCnpjCpf.Location = New System.Drawing.Point(505, 74)
        Me.txtCnpjCpf.MaxLength = 20
        Me.txtCnpjCpf.Name = "txtCnpjCpf"
        Me.txtCnpjCpf.Size = New System.Drawing.Size(108, 20)
        Me.txtCnpjCpf.TabIndex = 18
        '
        'lblCnpjCpf
        '
        Me.lblCnpjCpf.AutoSize = True
        Me.lblCnpjCpf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCnpjCpf.Location = New System.Drawing.Point(502, 57)
        Me.lblCnpjCpf.Name = "lblCnpjCpf"
        Me.lblCnpjCpf.Size = New System.Drawing.Size(35, 14)
        Me.lblCnpjCpf.TabIndex = 17
        Me.lblCnpjCpf.Text = "CNPJ:"
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogradouro.Location = New System.Drawing.Point(619, 34)
        Me.txtLogradouro.MaxLength = 60
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(266, 20)
        Me.txtLogradouro.TabIndex = 10
        '
        'btnProcurarCEP
        '
        Me.btnProcurarCEP.FlatAppearance.BorderSize = 0
        Me.btnProcurarCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCEP.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCEP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCEP.Location = New System.Drawing.Point(59, 15)
        Me.btnProcurarCEP.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCEP.Name = "btnProcurarCEP"
        Me.btnProcurarCEP.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCEP.TabIndex = 2
        Me.btnProcurarCEP.TabStop = False
        Me.btnProcurarCEP.UseVisualStyleBackColor = True
        '
        'btnCadastrarPais
        '
        Me.btnCadastrarPais.FlatAppearance.BorderSize = 0
        Me.btnCadastrarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarPais.Image = CType(resources.GetObject("btnCadastrarPais.Image"), System.Drawing.Image)
        Me.btnCadastrarPais.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarPais.Location = New System.Drawing.Point(82, 18)
        Me.btnCadastrarPais.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarPais.Name = "btnCadastrarPais"
        Me.btnCadastrarPais.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarPais.TabIndex = 3
        Me.btnCadastrarPais.TabStop = False
        Me.btnCadastrarPais.UseVisualStyleBackColor = True
        '
        'cboVendedorInterno
        '
        Me.cboVendedorInterno.AutoSize = False
        Me.cboVendedorInterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboVendedorInterno.Location = New System.Drawing.Point(475, 154)
        Me.cboVendedorInterno.Name = "cboVendedorInterno"
        Me.cboVendedorInterno.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboVendedorInterno.Size = New System.Drawing.Size(252, 20)
        Me.cboVendedorInterno.TabIndex = 44
        '
        'pagContatos
        '
        Me.pagContatos.Controls.Add(Me.grpEndereco)
        Me.pagContatos.Controls.Add(Me.btnExcelGridContato)
        Me.pagContatos.Controls.Add(Me.btnAgruparGridContato)
        Me.pagContatos.Controls.Add(Me.btnConfigurarGridContato)
        Me.pagContatos.Controls.Add(Me.grdContato)
        Me.pagContatos.Key = "pagContatos"
        Me.pagContatos.Location = New System.Drawing.Point(1, 22)
        Me.pagContatos.Name = "pagContatos"
        Me.pagContatos.Size = New System.Drawing.Size(980, 384)
        Me.pagContatos.TabStop = True
        Me.pagContatos.Text = "Contatos"
        '
        'grpEndereco
        '
        Me.grpEndereco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEndereco.BackColor = System.Drawing.Color.Transparent
        Me.grpEndereco.Controls.Add(Me.btnCadastrarTipoContato)
        Me.grpEndereco.Controls.Add(Me.dtpDataAniversario)
        Me.grpEndereco.Controls.Add(Me.lblDataAniversario)
        Me.grpEndereco.Controls.Add(Me.txtCelularContato)
        Me.grpEndereco.Controls.Add(Me.lblCelularContato)
        Me.grpEndereco.Controls.Add(Me.txtTelefoneContato)
        Me.grpEndereco.Controls.Add(Me.lblTipoContato)
        Me.grpEndereco.Controls.Add(Me.cboTipoContato)
        Me.grpEndereco.Controls.Add(Me.txtEmailContato)
        Me.grpEndereco.Controls.Add(Me.txtComplementoContato)
        Me.grpEndereco.Controls.Add(Me.txtNomeContato)
        Me.grpEndereco.Controls.Add(Me.lblComplementoContato)
        Me.grpEndereco.Controls.Add(Me.lblEmailContato)
        Me.grpEndereco.Controls.Add(Me.lblTelefoneContato)
        Me.grpEndereco.Controls.Add(Me.lblNomeContato)
        Me.grpEndereco.Controls.Add(Me.btnExcluirContato)
        Me.grpEndereco.Controls.Add(Me.btnSalvarContato)
        Me.grpEndereco.Location = New System.Drawing.Point(8, 3)
        Me.grpEndereco.Name = "grpEndereco"
        Me.grpEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEndereco.Size = New System.Drawing.Size(964, 104)
        Me.grpEndereco.TabIndex = 22
        Me.grpEndereco.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpEndereco.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarTipoContato
        '
        Me.btnCadastrarTipoContato.FlatAppearance.BorderSize = 0
        Me.btnCadastrarTipoContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarTipoContato.Image = CType(resources.GetObject("btnCadastrarTipoContato.Image"), System.Drawing.Image)
        Me.btnCadastrarTipoContato.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarTipoContato.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarTipoContato.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarTipoContato.Name = "btnCadastrarTipoContato"
        Me.btnCadastrarTipoContato.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarTipoContato.TabIndex = 16
        Me.btnCadastrarTipoContato.TabStop = False
        Me.btnCadastrarTipoContato.UseVisualStyleBackColor = True
        '
        'dtpDataAniversario
        '
        '
        '
        '
        Me.dtpDataAniversario.DropDownCalendar.Name = ""
        Me.dtpDataAniversario.Location = New System.Drawing.Point(650, 34)
        Me.dtpDataAniversario.Name = "dtpDataAniversario"
        Me.dtpDataAniversario.ShowCheckBox = True
        Me.dtpDataAniversario.Size = New System.Drawing.Size(102, 20)
        Me.dtpDataAniversario.TabIndex = 9
        Me.dtpDataAniversario.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblDataAniversario
        '
        Me.lblDataAniversario.AutoSize = True
        Me.lblDataAniversario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataAniversario.Location = New System.Drawing.Point(647, 17)
        Me.lblDataAniversario.Name = "lblDataAniversario"
        Me.lblDataAniversario.Size = New System.Drawing.Size(66, 14)
        Me.lblDataAniversario.TabIndex = 8
        Me.lblDataAniversario.Text = "Aniversário:"
        '
        'txtCelularContato
        '
        Me.txtCelularContato.Location = New System.Drawing.Point(558, 34)
        Me.txtCelularContato.Mask = "!(##) 0000-0000"
        Me.txtCelularContato.MaxLength = 10
        Me.txtCelularContato.Name = "txtCelularContato"
        Me.txtCelularContato.Size = New System.Drawing.Size(86, 20)
        Me.txtCelularContato.TabIndex = 7
        '
        'lblCelularContato
        '
        Me.lblCelularContato.AutoSize = True
        Me.lblCelularContato.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCelularContato.Location = New System.Drawing.Point(555, 17)
        Me.lblCelularContato.Name = "lblCelularContato"
        Me.lblCelularContato.Size = New System.Drawing.Size(43, 14)
        Me.lblCelularContato.TabIndex = 6
        Me.lblCelularContato.Text = "Celular:"
        '
        'txtTelefoneContato
        '
        Me.txtTelefoneContato.Location = New System.Drawing.Point(466, 34)
        Me.txtTelefoneContato.Mask = "!(##) 0000-0000"
        Me.txtTelefoneContato.MaxLength = 10
        Me.txtTelefoneContato.Name = "txtTelefoneContato"
        Me.txtTelefoneContato.Size = New System.Drawing.Size(86, 20)
        Me.txtTelefoneContato.TabIndex = 5
        '
        'lblTipoContato
        '
        Me.lblTipoContato.AutoSize = True
        Me.lblTipoContato.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoContato.Location = New System.Drawing.Point(25, 17)
        Me.lblTipoContato.Name = "lblTipoContato"
        Me.lblTipoContato.Size = New System.Drawing.Size(70, 14)
        Me.lblTipoContato.TabIndex = 0
        Me.lblTipoContato.Text = "Tipo Contato:"
        '
        'cboTipoContato
        '
        Me.cboTipoContato.AutoSize = False
        Me.cboTipoContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoContato.Location = New System.Drawing.Point(9, 34)
        Me.cboTipoContato.Name = "cboTipoContato"
        Me.cboTipoContato.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoContato.Size = New System.Drawing.Size(120, 20)
        Me.cboTipoContato.TabIndex = 1
        '
        'txtEmailContato
        '
        Me.txtEmailContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmailContato.Location = New System.Drawing.Point(9, 74)
        Me.txtEmailContato.MaxLength = 100
        Me.txtEmailContato.Name = "txtEmailContato"
        Me.txtEmailContato.Size = New System.Drawing.Size(451, 20)
        Me.txtEmailContato.TabIndex = 11
        '
        'txtComplementoContato
        '
        Me.txtComplementoContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplementoContato.Location = New System.Drawing.Point(466, 74)
        Me.txtComplementoContato.MaxLength = 50
        Me.txtComplementoContato.Name = "txtComplementoContato"
        Me.txtComplementoContato.Size = New System.Drawing.Size(286, 20)
        Me.txtComplementoContato.TabIndex = 13
        '
        'txtNomeContato
        '
        Me.txtNomeContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeContato.Location = New System.Drawing.Point(135, 34)
        Me.txtNomeContato.MaxLength = 70
        Me.txtNomeContato.Name = "txtNomeContato"
        Me.txtNomeContato.Size = New System.Drawing.Size(325, 20)
        Me.txtNomeContato.TabIndex = 3
        '
        'lblComplementoContato
        '
        Me.lblComplementoContato.AutoSize = True
        Me.lblComplementoContato.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblComplementoContato.Location = New System.Drawing.Point(463, 57)
        Me.lblComplementoContato.Name = "lblComplementoContato"
        Me.lblComplementoContato.Size = New System.Drawing.Size(74, 14)
        Me.lblComplementoContato.TabIndex = 12
        Me.lblComplementoContato.Text = "Complemento:"
        '
        'lblEmailContato
        '
        Me.lblEmailContato.AutoSize = True
        Me.lblEmailContato.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEmailContato.Location = New System.Drawing.Point(6, 57)
        Me.lblEmailContato.Name = "lblEmailContato"
        Me.lblEmailContato.Size = New System.Drawing.Size(38, 14)
        Me.lblEmailContato.TabIndex = 10
        Me.lblEmailContato.Text = "E-mail:"
        '
        'lblTelefoneContato
        '
        Me.lblTelefoneContato.AutoSize = True
        Me.lblTelefoneContato.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTelefoneContato.Location = New System.Drawing.Point(463, 17)
        Me.lblTelefoneContato.Name = "lblTelefoneContato"
        Me.lblTelefoneContato.Size = New System.Drawing.Size(51, 14)
        Me.lblTelefoneContato.TabIndex = 4
        Me.lblTelefoneContato.Text = "Telefone:"
        '
        'lblNomeContato
        '
        Me.lblNomeContato.AutoSize = True
        Me.lblNomeContato.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNomeContato.Location = New System.Drawing.Point(132, 17)
        Me.lblNomeContato.Name = "lblNomeContato"
        Me.lblNomeContato.Size = New System.Drawing.Size(37, 14)
        Me.lblNomeContato.TabIndex = 2
        Me.lblNomeContato.Text = "Nome:"
        '
        'btnExcluirContato
        '
        Me.btnExcluirContato.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirContato.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirContato.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirContato.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirContato.Location = New System.Drawing.Point(864, 71)
        Me.btnExcluirContato.Name = "btnExcluirContato"
        Me.btnExcluirContato.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirContato.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirContato.TabIndex = 15
        Me.btnExcluirContato.Text = "Excluir"
        Me.btnExcluirContato.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvarContato
        '
        Me.btnSalvarContato.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvarContato.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvarContato.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvarContato.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvarContato.Location = New System.Drawing.Point(864, 42)
        Me.btnSalvarContato.Name = "btnSalvarContato"
        Me.btnSalvarContato.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvarContato.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvarContato.TabIndex = 14
        Me.btnSalvarContato.Text = "Inserir"
        Me.btnSalvarContato.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcelGridContato
        '
        Me.btnExcelGridContato.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridContato.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridContato.FlatAppearance.BorderSize = 0
        Me.btnExcelGridContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridContato.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridContato.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridContato.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridContato.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridContato.Name = "btnExcelGridContato"
        Me.btnExcelGridContato.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridContato.TabIndex = 21
        Me.btnExcelGridContato.TabStop = False
        Me.btnExcelGridContato.UseVisualStyleBackColor = False
        '
        'btnAgruparGridContato
        '
        Me.btnAgruparGridContato.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridContato.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridContato.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridContato.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridContato.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridContato.Location = New System.Drawing.Point(33, 358)
        Me.btnAgruparGridContato.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridContato.Name = "btnAgruparGridContato"
        Me.btnAgruparGridContato.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridContato.TabIndex = 20
        Me.btnAgruparGridContato.TabStop = False
        Me.btnAgruparGridContato.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridContato
        '
        Me.btnConfigurarGridContato.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridContato.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridContato.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridContato.Image = CType(resources.GetObject("btnConfigurarGridContato.Image"), System.Drawing.Image)
        Me.btnConfigurarGridContato.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridContato.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridContato.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridContato.Name = "btnConfigurarGridContato"
        Me.btnConfigurarGridContato.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridContato.TabIndex = 19
        Me.btnConfigurarGridContato.TabStop = False
        Me.btnConfigurarGridContato.UseVisualStyleBackColor = False
        '
        'grdContato
        '
        Me.grdContato.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdContato.AlternatingColors = True
        Me.grdContato.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdContato_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdContato_DesignTimeLayout_Reference_0.Instance"), Object)
        grdContato_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdContato_DesignTimeLayout_Reference_1.Instance"), Object)
        grdContato_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdContato_DesignTimeLayout_Reference_0, grdContato_DesignTimeLayout_Reference_1})
        grdContato_DesignTimeLayout.LayoutString = resources.GetString("grdContato_DesignTimeLayout.LayoutString")
        Me.grdContato.DesignTimeLayout = grdContato_DesignTimeLayout
        Me.grdContato.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdContato.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdContato.FrozenColumns = 3
        Me.grdContato.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdContato.GroupByBoxVisible = False
        Me.grdContato.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdContato.Location = New System.Drawing.Point(8, 116)
        Me.grdContato.Name = "grdContato"
        Me.grdContato.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdContato.RecordNavigator = True
        Me.grdContato.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdContato.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdContato.Size = New System.Drawing.Size(964, 259)
        Me.grdContato.TabIndex = 23
        Me.grdContato.TabStop = False
        Me.grdContato.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdContato.VisualStyleManager = Me.vsmMain
        '
        'pagEnderecos
        '
        Me.pagEnderecos.Controls.Add(Me.btnExcelGridEndereco)
        Me.pagEnderecos.Controls.Add(Me.btnAgruparGridEndereco)
        Me.pagEnderecos.Controls.Add(Me.btnConfigurarGridEndereco)
        Me.pagEnderecos.Controls.Add(Me.grdEndereco)
        Me.pagEnderecos.Controls.Add(Me.grpEnderecoCobranca)
        Me.pagEnderecos.Key = "pagEnderecos"
        Me.pagEnderecos.Location = New System.Drawing.Point(1, 22)
        Me.pagEnderecos.Name = "pagEnderecos"
        Me.pagEnderecos.Size = New System.Drawing.Size(980, 384)
        Me.pagEnderecos.TabStop = True
        Me.pagEnderecos.Text = "Endereços"
        '
        'btnExcelGridEndereco
        '
        Me.btnExcelGridEndereco.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridEndereco.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridEndereco.FlatAppearance.BorderSize = 0
        Me.btnExcelGridEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridEndereco.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridEndereco.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridEndereco.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridEndereco.Name = "btnExcelGridEndereco"
        Me.btnExcelGridEndereco.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridEndereco.TabIndex = 24
        Me.btnExcelGridEndereco.TabStop = False
        Me.btnExcelGridEndereco.UseVisualStyleBackColor = False
        '
        'btnAgruparGridEndereco
        '
        Me.btnAgruparGridEndereco.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridEndereco.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridEndereco.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridEndereco.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridEndereco.Location = New System.Drawing.Point(33, 358)
        Me.btnAgruparGridEndereco.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridEndereco.Name = "btnAgruparGridEndereco"
        Me.btnAgruparGridEndereco.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridEndereco.TabIndex = 23
        Me.btnAgruparGridEndereco.TabStop = False
        Me.btnAgruparGridEndereco.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridEndereco
        '
        Me.btnConfigurarGridEndereco.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridEndereco.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridEndereco.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridEndereco.Image = CType(resources.GetObject("btnConfigurarGridEndereco.Image"), System.Drawing.Image)
        Me.btnConfigurarGridEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridEndereco.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridEndereco.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridEndereco.Name = "btnConfigurarGridEndereco"
        Me.btnConfigurarGridEndereco.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridEndereco.TabIndex = 22
        Me.btnConfigurarGridEndereco.TabStop = False
        Me.btnConfigurarGridEndereco.UseVisualStyleBackColor = False
        '
        'grdEndereco
        '
        Me.grdEndereco.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdEndereco.AlternatingColors = True
        Me.grdEndereco.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdEndereco_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdEndereco_DesignTimeLayout_Reference_0.Instance"), Object)
        grdEndereco_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdEndereco_DesignTimeLayout_Reference_1.Instance"), Object)
        grdEndereco_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdEndereco_DesignTimeLayout_Reference_0, grdEndereco_DesignTimeLayout_Reference_1})
        grdEndereco_DesignTimeLayout.LayoutString = resources.GetString("grdEndereco_DesignTimeLayout.LayoutString")
        Me.grdEndereco.DesignTimeLayout = grdEndereco_DesignTimeLayout
        Me.grdEndereco.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdEndereco.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdEndereco.FrozenColumns = 2
        Me.grdEndereco.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdEndereco.GroupByBoxVisible = False
        Me.grdEndereco.Location = New System.Drawing.Point(8, 116)
        Me.grdEndereco.Name = "grdEndereco"
        Me.grdEndereco.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdEndereco.RecordNavigator = True
        Me.grdEndereco.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdEndereco.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdEndereco.Size = New System.Drawing.Size(964, 259)
        Me.grdEndereco.TabIndex = 26
        Me.grdEndereco.TabStop = False
        Me.grdEndereco.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdEndereco.VisualStyleManager = Me.vsmMain
        '
        'grpEnderecoCobranca
        '
        Me.grpEnderecoCobranca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEnderecoCobranca.BackColor = System.Drawing.Color.Transparent
        Me.grpEnderecoCobranca.Controls.Add(Me.btnExcluirEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.btnSalvarEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.btnProcurarCepEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.btnCadastrarPaisEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.cboMunicipioEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.txtNumeroEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.txtComplementoEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.txtBairroEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.lblPaisEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.cboPaisEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.lblCepEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.txtCepEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.lblComplementoEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.lblUFEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.cboUFEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.lblMunicipioEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.lblBairroEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.lblNumeroEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.lblLogradouroEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.txtLogradouroEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.lblTipoEndereco)
        Me.grpEnderecoCobranca.Controls.Add(Me.cboTipoEndereco)
        Me.grpEnderecoCobranca.Location = New System.Drawing.Point(8, 3)
        Me.grpEnderecoCobranca.Name = "grpEnderecoCobranca"
        Me.grpEnderecoCobranca.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEnderecoCobranca.Size = New System.Drawing.Size(964, 104)
        Me.grpEnderecoCobranca.TabIndex = 25
        Me.grpEnderecoCobranca.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpEnderecoCobranca.VisualStyleManager = Me.vsmMain
        '
        'btnExcluirEndereco
        '
        Me.btnExcluirEndereco.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirEndereco.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirEndereco.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirEndereco.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirEndereco.Location = New System.Drawing.Point(864, 71)
        Me.btnExcluirEndereco.Name = "btnExcluirEndereco"
        Me.btnExcluirEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirEndereco.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirEndereco.TabIndex = 21
        Me.btnExcluirEndereco.Text = "Excluir"
        Me.btnExcluirEndereco.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvarEndereco
        '
        Me.btnSalvarEndereco.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvarEndereco.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvarEndereco.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvarEndereco.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvarEndereco.Location = New System.Drawing.Point(767, 71)
        Me.btnSalvarEndereco.Name = "btnSalvarEndereco"
        Me.btnSalvarEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvarEndereco.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvarEndereco.TabIndex = 20
        Me.btnSalvarEndereco.Text = "Inserir"
        Me.btnSalvarEndereco.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnProcurarCepEndereco
        '
        Me.btnProcurarCepEndereco.FlatAppearance.BorderSize = 0
        Me.btnProcurarCepEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCepEndereco.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCepEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCepEndereco.Location = New System.Drawing.Point(185, 15)
        Me.btnProcurarCepEndereco.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCepEndereco.Name = "btnProcurarCepEndereco"
        Me.btnProcurarCepEndereco.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCepEndereco.TabIndex = 4
        Me.btnProcurarCepEndereco.TabStop = False
        Me.btnProcurarCepEndereco.UseVisualStyleBackColor = True
        '
        'btnCadastrarPaisEndereco
        '
        Me.btnCadastrarPaisEndereco.FlatAppearance.BorderSize = 0
        Me.btnCadastrarPaisEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarPaisEndereco.Image = CType(resources.GetObject("btnCadastrarPaisEndereco.Image"), System.Drawing.Image)
        Me.btnCadastrarPaisEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarPaisEndereco.Location = New System.Drawing.Point(208, 18)
        Me.btnCadastrarPaisEndereco.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarPaisEndereco.Name = "btnCadastrarPaisEndereco"
        Me.btnCadastrarPaisEndereco.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarPaisEndereco.TabIndex = 5
        Me.btnCadastrarPaisEndereco.TabStop = False
        Me.btnCadastrarPaisEndereco.UseVisualStyleBackColor = True
        '
        'cboMunicipioEndereco
        '
        Me.cboMunicipioEndereco.AutoSize = False
        Me.cboMunicipioEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMunicipioEndereco.Location = New System.Drawing.Point(416, 34)
        Me.cboMunicipioEndereco.Name = "cboMunicipioEndereco"
        Me.cboMunicipioEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMunicipioEndereco.Size = New System.Drawing.Size(200, 20)
        Me.cboMunicipioEndereco.TabIndex = 11
        '
        'txtNumeroEndereco
        '
        Me.txtNumeroEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroEndereco.Location = New System.Drawing.Point(9, 74)
        Me.txtNumeroEndereco.MaxLength = 60
        Me.txtNumeroEndereco.Name = "txtNumeroEndereco"
        Me.txtNumeroEndereco.Size = New System.Drawing.Size(67, 20)
        Me.txtNumeroEndereco.TabIndex = 15
        '
        'txtComplementoEndereco
        '
        Me.txtComplementoEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplementoEndereco.Location = New System.Drawing.Point(352, 74)
        Me.txtComplementoEndereco.MaxLength = 60
        Me.txtComplementoEndereco.Name = "txtComplementoEndereco"
        Me.txtComplementoEndereco.Size = New System.Drawing.Size(264, 20)
        Me.txtComplementoEndereco.TabIndex = 19
        '
        'txtBairroEndereco
        '
        Me.txtBairroEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairroEndereco.Location = New System.Drawing.Point(82, 74)
        Me.txtBairroEndereco.MaxLength = 60
        Me.txtBairroEndereco.Name = "txtBairroEndereco"
        Me.txtBairroEndereco.Size = New System.Drawing.Size(264, 20)
        Me.txtBairroEndereco.TabIndex = 17
        '
        'lblPaisEndereco
        '
        Me.lblPaisEndereco.AutoSize = True
        Me.lblPaisEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPaisEndereco.Location = New System.Drawing.Point(224, 17)
        Me.lblPaisEndereco.Name = "lblPaisEndereco"
        Me.lblPaisEndereco.Size = New System.Drawing.Size(30, 14)
        Me.lblPaisEndereco.TabIndex = 6
        Me.lblPaisEndereco.Text = "País:"
        '
        'cboPaisEndereco
        '
        Me.cboPaisEndereco.AutoSize = False
        Me.cboPaisEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPaisEndereco.Location = New System.Drawing.Point(208, 34)
        Me.cboPaisEndereco.Name = "cboPaisEndereco"
        Me.cboPaisEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPaisEndereco.Size = New System.Drawing.Size(138, 20)
        Me.cboPaisEndereco.TabIndex = 7
        '
        'lblCepEndereco
        '
        Me.lblCepEndereco.AutoSize = True
        Me.lblCepEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCepEndereco.Location = New System.Drawing.Point(132, 17)
        Me.lblCepEndereco.Name = "lblCepEndereco"
        Me.lblCepEndereco.Size = New System.Drawing.Size(29, 14)
        Me.lblCepEndereco.TabIndex = 2
        Me.lblCepEndereco.Text = "CEP:"
        '
        'txtCepEndereco
        '
        Me.txtCepEndereco.Location = New System.Drawing.Point(135, 34)
        Me.txtCepEndereco.Mask = "00000-000"
        Me.txtCepEndereco.MaxLength = 10
        Me.txtCepEndereco.Name = "txtCepEndereco"
        Me.txtCepEndereco.Size = New System.Drawing.Size(67, 20)
        Me.txtCepEndereco.TabIndex = 3
        '
        'lblComplementoEndereco
        '
        Me.lblComplementoEndereco.AutoSize = True
        Me.lblComplementoEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblComplementoEndereco.Location = New System.Drawing.Point(349, 57)
        Me.lblComplementoEndereco.Name = "lblComplementoEndereco"
        Me.lblComplementoEndereco.Size = New System.Drawing.Size(74, 14)
        Me.lblComplementoEndereco.TabIndex = 18
        Me.lblComplementoEndereco.Text = "Complemento:"
        '
        'lblUFEndereco
        '
        Me.lblUFEndereco.AutoSize = True
        Me.lblUFEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUFEndereco.Location = New System.Drawing.Point(349, 17)
        Me.lblUFEndereco.Name = "lblUFEndereco"
        Me.lblUFEndereco.Size = New System.Drawing.Size(23, 14)
        Me.lblUFEndereco.TabIndex = 8
        Me.lblUFEndereco.Text = "UF:"
        '
        'cboUFEndereco
        '
        Me.cboUFEndereco.AutoSize = False
        Me.cboUFEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUFEndereco.Location = New System.Drawing.Point(352, 34)
        Me.cboUFEndereco.Name = "cboUFEndereco"
        Me.cboUFEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUFEndereco.Size = New System.Drawing.Size(58, 20)
        Me.cboUFEndereco.TabIndex = 9
        '
        'lblMunicipioEndereco
        '
        Me.lblMunicipioEndereco.AutoSize = True
        Me.lblMunicipioEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMunicipioEndereco.Location = New System.Drawing.Point(413, 17)
        Me.lblMunicipioEndereco.Name = "lblMunicipioEndereco"
        Me.lblMunicipioEndereco.Size = New System.Drawing.Size(54, 14)
        Me.lblMunicipioEndereco.TabIndex = 10
        Me.lblMunicipioEndereco.Text = "Município:"
        '
        'lblBairroEndereco
        '
        Me.lblBairroEndereco.AutoSize = True
        Me.lblBairroEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBairroEndereco.Location = New System.Drawing.Point(79, 57)
        Me.lblBairroEndereco.Name = "lblBairroEndereco"
        Me.lblBairroEndereco.Size = New System.Drawing.Size(39, 14)
        Me.lblBairroEndereco.TabIndex = 16
        Me.lblBairroEndereco.Text = "Bairro:"
        '
        'lblNumeroEndereco
        '
        Me.lblNumeroEndereco.AutoSize = True
        Me.lblNumeroEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroEndereco.Location = New System.Drawing.Point(6, 57)
        Me.lblNumeroEndereco.Name = "lblNumeroEndereco"
        Me.lblNumeroEndereco.Size = New System.Drawing.Size(47, 14)
        Me.lblNumeroEndereco.TabIndex = 14
        Me.lblNumeroEndereco.Text = "Número:"
        '
        'lblLogradouroEndereco
        '
        Me.lblLogradouroEndereco.AutoSize = True
        Me.lblLogradouroEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLogradouroEndereco.Location = New System.Drawing.Point(619, 17)
        Me.lblLogradouroEndereco.Name = "lblLogradouroEndereco"
        Me.lblLogradouroEndereco.Size = New System.Drawing.Size(66, 14)
        Me.lblLogradouroEndereco.TabIndex = 12
        Me.lblLogradouroEndereco.Text = "Logradouro:"
        '
        'txtLogradouroEndereco
        '
        Me.txtLogradouroEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogradouroEndereco.Location = New System.Drawing.Point(622, 34)
        Me.txtLogradouroEndereco.MaxLength = 60
        Me.txtLogradouroEndereco.Name = "txtLogradouroEndereco"
        Me.txtLogradouroEndereco.Size = New System.Drawing.Size(248, 20)
        Me.txtLogradouroEndereco.TabIndex = 13
        '
        'lblTipoEndereco
        '
        Me.lblTipoEndereco.AutoSize = True
        Me.lblTipoEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoEndereco.Location = New System.Drawing.Point(6, 17)
        Me.lblTipoEndereco.Name = "lblTipoEndereco"
        Me.lblTipoEndereco.Size = New System.Drawing.Size(94, 14)
        Me.lblTipoEndereco.TabIndex = 0
        Me.lblTipoEndereco.Text = "Tipo de Endereço:"
        '
        'cboTipoEndereco
        '
        Me.cboTipoEndereco.AutoSize = False
        Me.cboTipoEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoEndereco.Location = New System.Drawing.Point(9, 34)
        Me.cboTipoEndereco.Name = "cboTipoEndereco"
        Me.cboTipoEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoEndereco.Size = New System.Drawing.Size(120, 20)
        Me.cboTipoEndereco.TabIndex = 1
        '
        'pagPedidoVenda
        '
        Me.pagPedidoVenda.Controls.Add(Me.dtpDataTerminoPedidoVenda)
        Me.pagPedidoVenda.Controls.Add(Me.dtpDataInicioPedidoVenda)
        Me.pagPedidoVenda.Controls.Add(Me.lblPeriodoPedidoVenda)
        Me.pagPedidoVenda.Controls.Add(Me.btnExcelGridPedidoVendaProduto)
        Me.pagPedidoVenda.Controls.Add(Me.btnAgruparGridPedidoVendaProduto)
        Me.pagPedidoVenda.Controls.Add(Me.btnConfigurarGridPedidoVendaProduto)
        Me.pagPedidoVenda.Controls.Add(Me.grdPedidoVendaProduto)
        Me.pagPedidoVenda.Controls.Add(Me.btnExcelGridPedido)
        Me.pagPedidoVenda.Controls.Add(Me.btnAgruparGridPedido)
        Me.pagPedidoVenda.Controls.Add(Me.btnConfigurarGridPedido)
        Me.pagPedidoVenda.Controls.Add(Me.grdPedidoVenda)
        Me.pagPedidoVenda.Key = "pagPedidoVenda"
        Me.pagPedidoVenda.Location = New System.Drawing.Point(1, 22)
        Me.pagPedidoVenda.Name = "pagPedidoVenda"
        Me.pagPedidoVenda.Size = New System.Drawing.Size(980, 384)
        Me.pagPedidoVenda.TabStop = True
        Me.pagPedidoVenda.Text = "Pedido de Venda"
        '
        'dtpDataTerminoPedidoVenda
        '
        '
        '
        '
        Me.dtpDataTerminoPedidoVenda.DropDownCalendar.Name = ""
        Me.dtpDataTerminoPedidoVenda.Location = New System.Drawing.Point(163, 8)
        Me.dtpDataTerminoPedidoVenda.Name = "dtpDataTerminoPedidoVenda"
        Me.dtpDataTerminoPedidoVenda.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataTerminoPedidoVenda.TabIndex = 2
        Me.dtpDataTerminoPedidoVenda.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'dtpDataInicioPedidoVenda
        '
        '
        '
        '
        Me.dtpDataInicioPedidoVenda.DropDownCalendar.Name = ""
        Me.dtpDataInicioPedidoVenda.Location = New System.Drawing.Point(57, 8)
        Me.dtpDataInicioPedidoVenda.Name = "dtpDataInicioPedidoVenda"
        Me.dtpDataInicioPedidoVenda.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataInicioPedidoVenda.TabIndex = 1
        Me.dtpDataInicioPedidoVenda.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblPeriodoPedidoVenda
        '
        Me.lblPeriodoPedidoVenda.AutoSize = True
        Me.lblPeriodoPedidoVenda.BackColor = System.Drawing.Color.Transparent
        Me.lblPeriodoPedidoVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPeriodoPedidoVenda.Location = New System.Drawing.Point(5, 11)
        Me.lblPeriodoPedidoVenda.Name = "lblPeriodoPedidoVenda"
        Me.lblPeriodoPedidoVenda.Size = New System.Drawing.Size(46, 14)
        Me.lblPeriodoPedidoVenda.TabIndex = 0
        Me.lblPeriodoPedidoVenda.Text = "Período:"
        '
        'btnExcelGridPedidoVendaProduto
        '
        Me.btnExcelGridPedidoVendaProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridPedidoVendaProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridPedidoVendaProduto.FlatAppearance.BorderSize = 0
        Me.btnExcelGridPedidoVendaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridPedidoVendaProduto.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridPedidoVendaProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridPedidoVendaProduto.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridPedidoVendaProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridPedidoVendaProduto.Name = "btnExcelGridPedidoVendaProduto"
        Me.btnExcelGridPedidoVendaProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridPedidoVendaProduto.TabIndex = 10
        Me.btnExcelGridPedidoVendaProduto.TabStop = False
        Me.btnExcelGridPedidoVendaProduto.UseVisualStyleBackColor = False
        '
        'btnAgruparGridPedidoVendaProduto
        '
        Me.btnAgruparGridPedidoVendaProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridPedidoVendaProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridPedidoVendaProduto.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridPedidoVendaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridPedidoVendaProduto.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridPedidoVendaProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridPedidoVendaProduto.Location = New System.Drawing.Point(33, 358)
        Me.btnAgruparGridPedidoVendaProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridPedidoVendaProduto.Name = "btnAgruparGridPedidoVendaProduto"
        Me.btnAgruparGridPedidoVendaProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridPedidoVendaProduto.TabIndex = 9
        Me.btnAgruparGridPedidoVendaProduto.TabStop = False
        Me.btnAgruparGridPedidoVendaProduto.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridPedidoVendaProduto
        '
        Me.btnConfigurarGridPedidoVendaProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridPedidoVendaProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridPedidoVendaProduto.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridPedidoVendaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridPedidoVendaProduto.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridPedidoVendaProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridPedidoVendaProduto.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridPedidoVendaProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridPedidoVendaProduto.Name = "btnConfigurarGridPedidoVendaProduto"
        Me.btnConfigurarGridPedidoVendaProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridPedidoVendaProduto.TabIndex = 8
        Me.btnConfigurarGridPedidoVendaProduto.TabStop = False
        Me.btnConfigurarGridPedidoVendaProduto.UseVisualStyleBackColor = False
        '
        'grdPedidoVendaProduto
        '
        Me.grdPedidoVendaProduto.AlternatingColors = True
        Me.grdPedidoVendaProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPedidoVendaProduto.AutoEdit = True
        Me.grdPedidoVendaProduto.ColumnAutoResize = True
        grdPedidoVendaProduto_DesignTimeLayout.LayoutString = resources.GetString("grdPedidoVendaProduto_DesignTimeLayout.LayoutString")
        Me.grdPedidoVendaProduto.DesignTimeLayout = grdPedidoVendaProduto_DesignTimeLayout
        Me.grdPedidoVendaProduto.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grdPedidoVendaProduto.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPedidoVendaProduto.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPedidoVendaProduto.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdPedidoVendaProduto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPedidoVendaProduto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPedidoVendaProduto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPedidoVendaProduto.GroupByBoxVisible = False
        Me.grdPedidoVendaProduto.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdPedidoVendaProduto.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdPedidoVendaProduto.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedidoVendaProduto.Hierarchical = True
        Me.grdPedidoVendaProduto.Location = New System.Drawing.Point(8, 197)
        Me.grdPedidoVendaProduto.Name = "grdPedidoVendaProduto"
        Me.grdPedidoVendaProduto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPedidoVendaProduto.RecordNavigator = True
        Me.grdPedidoVendaProduto.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdPedidoVendaProduto.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedidoVendaProduto.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdPedidoVendaProduto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPedidoVendaProduto.Size = New System.Drawing.Size(964, 178)
        Me.grdPedidoVendaProduto.TabIndex = 7
        Me.grdPedidoVendaProduto.TabStop = False
        Me.grdPedidoVendaProduto.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedidoVendaProduto.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdPedidoVendaProduto.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPedidoVendaProduto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPedidoVendaProduto.VisualStyleManager = Me.vsmMain
        '
        'btnExcelGridPedido
        '
        Me.btnExcelGridPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridPedido.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridPedido.FlatAppearance.BorderSize = 0
        Me.btnExcelGridPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridPedido.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridPedido.Location = New System.Drawing.Point(57, 171)
        Me.btnExcelGridPedido.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridPedido.Name = "btnExcelGridPedido"
        Me.btnExcelGridPedido.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridPedido.TabIndex = 6
        Me.btnExcelGridPedido.TabStop = False
        Me.btnExcelGridPedido.UseVisualStyleBackColor = False
        '
        'btnAgruparGridPedido
        '
        Me.btnAgruparGridPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridPedido.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridPedido.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridPedido.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridPedido.Location = New System.Drawing.Point(33, 171)
        Me.btnAgruparGridPedido.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridPedido.Name = "btnAgruparGridPedido"
        Me.btnAgruparGridPedido.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridPedido.TabIndex = 5
        Me.btnAgruparGridPedido.TabStop = False
        Me.btnAgruparGridPedido.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridPedido
        '
        Me.btnConfigurarGridPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridPedido.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridPedido.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridPedido.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridPedido.Location = New System.Drawing.Point(9, 171)
        Me.btnConfigurarGridPedido.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridPedido.Name = "btnConfigurarGridPedido"
        Me.btnConfigurarGridPedido.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridPedido.TabIndex = 4
        Me.btnConfigurarGridPedido.TabStop = False
        Me.btnConfigurarGridPedido.UseVisualStyleBackColor = False
        '
        'grdPedidoVenda
        '
        Me.grdPedidoVenda.AlternatingColors = True
        Me.grdPedidoVenda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPedidoVenda.AutoEdit = True
        Me.grdPedidoVenda.ColumnAutoResize = True
        grdPedidoVenda_DesignTimeLayout.LayoutString = resources.GetString("grdPedidoVenda_DesignTimeLayout.LayoutString")
        Me.grdPedidoVenda.DesignTimeLayout = grdPedidoVenda_DesignTimeLayout
        Me.grdPedidoVenda.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grdPedidoVenda.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPedidoVenda.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPedidoVenda.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdPedidoVenda.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPedidoVenda.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPedidoVenda.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPedidoVenda.GroupByBoxVisible = False
        Me.grdPedidoVenda.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdPedidoVenda.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdPedidoVenda.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedidoVenda.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.grdPedidoVenda.Hierarchical = True
        Me.grdPedidoVenda.Location = New System.Drawing.Point(8, 35)
        Me.grdPedidoVenda.Name = "grdPedidoVenda"
        Me.grdPedidoVenda.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPedidoVenda.RecordNavigator = True
        Me.grdPedidoVenda.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdPedidoVenda.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedidoVenda.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdPedidoVenda.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPedidoVenda.Size = New System.Drawing.Size(964, 153)
        Me.grdPedidoVenda.TabIndex = 3
        Me.grdPedidoVenda.TabStop = False
        Me.grdPedidoVenda.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedidoVenda.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdPedidoVenda.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPedidoVenda.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPedidoVenda.VisualStyleManager = Me.vsmMain
        '
        'pagOrcamento
        '
        Me.pagOrcamento.Controls.Add(Me.dtpDataTerminoOrcamento)
        Me.pagOrcamento.Controls.Add(Me.dtpDataInicioOrcamento)
        Me.pagOrcamento.Controls.Add(Me.lblPeriodoOrcamento)
        Me.pagOrcamento.Controls.Add(Me.btnExcelGridOrcamentoProduto)
        Me.pagOrcamento.Controls.Add(Me.btnAgruparGridOrcamentoProduto)
        Me.pagOrcamento.Controls.Add(Me.btnConfigurarGridOrcamentoProduto)
        Me.pagOrcamento.Controls.Add(Me.btnExcelGridOrcamento)
        Me.pagOrcamento.Controls.Add(Me.btnAgruparGridOrcamento)
        Me.pagOrcamento.Controls.Add(Me.btnConfigurarGridOrcamento)
        Me.pagOrcamento.Controls.Add(Me.grdOrcamento)
        Me.pagOrcamento.Controls.Add(Me.grdOrcamentoProduto)
        Me.pagOrcamento.Key = "pagOrcamento"
        Me.pagOrcamento.Location = New System.Drawing.Point(1, 22)
        Me.pagOrcamento.Name = "pagOrcamento"
        Me.pagOrcamento.Size = New System.Drawing.Size(980, 384)
        Me.pagOrcamento.TabStop = True
        Me.pagOrcamento.Text = "Orçamento"
        '
        'dtpDataTerminoOrcamento
        '
        '
        '
        '
        Me.dtpDataTerminoOrcamento.DropDownCalendar.Name = ""
        Me.dtpDataTerminoOrcamento.Location = New System.Drawing.Point(163, 8)
        Me.dtpDataTerminoOrcamento.Name = "dtpDataTerminoOrcamento"
        Me.dtpDataTerminoOrcamento.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataTerminoOrcamento.TabIndex = 2
        Me.dtpDataTerminoOrcamento.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'dtpDataInicioOrcamento
        '
        '
        '
        '
        Me.dtpDataInicioOrcamento.DropDownCalendar.Name = ""
        Me.dtpDataInicioOrcamento.Location = New System.Drawing.Point(57, 8)
        Me.dtpDataInicioOrcamento.Name = "dtpDataInicioOrcamento"
        Me.dtpDataInicioOrcamento.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataInicioOrcamento.TabIndex = 1
        Me.dtpDataInicioOrcamento.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblPeriodoOrcamento
        '
        Me.lblPeriodoOrcamento.AutoSize = True
        Me.lblPeriodoOrcamento.BackColor = System.Drawing.Color.Transparent
        Me.lblPeriodoOrcamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPeriodoOrcamento.Location = New System.Drawing.Point(5, 11)
        Me.lblPeriodoOrcamento.Name = "lblPeriodoOrcamento"
        Me.lblPeriodoOrcamento.Size = New System.Drawing.Size(46, 14)
        Me.lblPeriodoOrcamento.TabIndex = 0
        Me.lblPeriodoOrcamento.Text = "Período:"
        '
        'btnExcelGridOrcamentoProduto
        '
        Me.btnExcelGridOrcamentoProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridOrcamentoProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridOrcamentoProduto.FlatAppearance.BorderSize = 0
        Me.btnExcelGridOrcamentoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridOrcamentoProduto.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridOrcamentoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridOrcamentoProduto.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridOrcamentoProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridOrcamentoProduto.Name = "btnExcelGridOrcamentoProduto"
        Me.btnExcelGridOrcamentoProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridOrcamentoProduto.TabIndex = 10
        Me.btnExcelGridOrcamentoProduto.TabStop = False
        Me.btnExcelGridOrcamentoProduto.UseVisualStyleBackColor = False
        '
        'btnAgruparGridOrcamentoProduto
        '
        Me.btnAgruparGridOrcamentoProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridOrcamentoProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridOrcamentoProduto.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridOrcamentoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridOrcamentoProduto.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridOrcamentoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridOrcamentoProduto.Location = New System.Drawing.Point(33, 358)
        Me.btnAgruparGridOrcamentoProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridOrcamentoProduto.Name = "btnAgruparGridOrcamentoProduto"
        Me.btnAgruparGridOrcamentoProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridOrcamentoProduto.TabIndex = 9
        Me.btnAgruparGridOrcamentoProduto.TabStop = False
        Me.btnAgruparGridOrcamentoProduto.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridOrcamentoProduto
        '
        Me.btnConfigurarGridOrcamentoProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridOrcamentoProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridOrcamentoProduto.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridOrcamentoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridOrcamentoProduto.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridOrcamentoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridOrcamentoProduto.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridOrcamentoProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridOrcamentoProduto.Name = "btnConfigurarGridOrcamentoProduto"
        Me.btnConfigurarGridOrcamentoProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridOrcamentoProduto.TabIndex = 8
        Me.btnConfigurarGridOrcamentoProduto.TabStop = False
        Me.btnConfigurarGridOrcamentoProduto.UseVisualStyleBackColor = False
        '
        'btnExcelGridOrcamento
        '
        Me.btnExcelGridOrcamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridOrcamento.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridOrcamento.FlatAppearance.BorderSize = 0
        Me.btnExcelGridOrcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridOrcamento.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridOrcamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridOrcamento.Location = New System.Drawing.Point(57, 171)
        Me.btnExcelGridOrcamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridOrcamento.Name = "btnExcelGridOrcamento"
        Me.btnExcelGridOrcamento.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridOrcamento.TabIndex = 6
        Me.btnExcelGridOrcamento.TabStop = False
        Me.btnExcelGridOrcamento.UseVisualStyleBackColor = False
        '
        'btnAgruparGridOrcamento
        '
        Me.btnAgruparGridOrcamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridOrcamento.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridOrcamento.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridOrcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridOrcamento.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridOrcamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridOrcamento.Location = New System.Drawing.Point(33, 171)
        Me.btnAgruparGridOrcamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridOrcamento.Name = "btnAgruparGridOrcamento"
        Me.btnAgruparGridOrcamento.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridOrcamento.TabIndex = 5
        Me.btnAgruparGridOrcamento.TabStop = False
        Me.btnAgruparGridOrcamento.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridOrcamento
        '
        Me.btnConfigurarGridOrcamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridOrcamento.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridOrcamento.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridOrcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridOrcamento.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridOrcamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridOrcamento.Location = New System.Drawing.Point(9, 171)
        Me.btnConfigurarGridOrcamento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridOrcamento.Name = "btnConfigurarGridOrcamento"
        Me.btnConfigurarGridOrcamento.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridOrcamento.TabIndex = 4
        Me.btnConfigurarGridOrcamento.TabStop = False
        Me.btnConfigurarGridOrcamento.UseVisualStyleBackColor = False
        '
        'grdOrcamento
        '
        Me.grdOrcamento.AlternatingColors = True
        Me.grdOrcamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdOrcamento.AutoEdit = True
        Me.grdOrcamento.ColumnAutoResize = True
        grdOrcamento_DesignTimeLayout.LayoutString = resources.GetString("grdOrcamento_DesignTimeLayout.LayoutString")
        Me.grdOrcamento.DesignTimeLayout = grdOrcamento_DesignTimeLayout
        Me.grdOrcamento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grdOrcamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdOrcamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrcamento.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdOrcamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrcamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOrcamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrcamento.GroupByBoxVisible = False
        Me.grdOrcamento.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdOrcamento.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdOrcamento.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamento.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.grdOrcamento.Hierarchical = True
        Me.grdOrcamento.Location = New System.Drawing.Point(8, 35)
        Me.grdOrcamento.Name = "grdOrcamento"
        Me.grdOrcamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamento.RecordNavigator = True
        Me.grdOrcamento.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdOrcamento.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamento.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdOrcamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamento.Size = New System.Drawing.Size(964, 153)
        Me.grdOrcamento.TabIndex = 3
        Me.grdOrcamento.TabStop = False
        Me.grdOrcamento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdOrcamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOrcamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamento.VisualStyleManager = Me.vsmMain
        '
        'grdOrcamentoProduto
        '
        Me.grdOrcamentoProduto.AlternatingColors = True
        Me.grdOrcamentoProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdOrcamentoProduto.AutoEdit = True
        Me.grdOrcamentoProduto.ColumnAutoResize = True
        grdOrcamentoProduto_DesignTimeLayout.LayoutString = resources.GetString("grdOrcamentoProduto_DesignTimeLayout.LayoutString")
        Me.grdOrcamentoProduto.DesignTimeLayout = grdOrcamentoProduto_DesignTimeLayout
        Me.grdOrcamentoProduto.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grdOrcamentoProduto.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdOrcamentoProduto.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrcamentoProduto.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdOrcamentoProduto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrcamentoProduto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOrcamentoProduto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrcamentoProduto.GroupByBoxVisible = False
        Me.grdOrcamentoProduto.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdOrcamentoProduto.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdOrcamentoProduto.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamentoProduto.Hierarchical = True
        Me.grdOrcamentoProduto.Location = New System.Drawing.Point(8, 197)
        Me.grdOrcamentoProduto.Name = "grdOrcamentoProduto"
        Me.grdOrcamentoProduto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamentoProduto.RecordNavigator = True
        Me.grdOrcamentoProduto.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdOrcamentoProduto.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamentoProduto.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdOrcamentoProduto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamentoProduto.Size = New System.Drawing.Size(964, 178)
        Me.grdOrcamentoProduto.TabIndex = 7
        Me.grdOrcamentoProduto.TabStop = False
        Me.grdOrcamentoProduto.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamentoProduto.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdOrcamentoProduto.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOrcamentoProduto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamentoProduto.VisualStyleManager = Me.vsmMain
        '
        'pagNotaFiscal
        '
        Me.pagNotaFiscal.Controls.Add(Me.dtpDataTerminoNotaFiscal)
        Me.pagNotaFiscal.Controls.Add(Me.dtpDataInicioNotaFiscal)
        Me.pagNotaFiscal.Controls.Add(Me.lblPeriodoNotaFiscal)
        Me.pagNotaFiscal.Controls.Add(Me.btnExcelGridNotaFiscalProduto)
        Me.pagNotaFiscal.Controls.Add(Me.btnAgruparGridNotaFiscalProduto)
        Me.pagNotaFiscal.Controls.Add(Me.btnConfigurarGridNotaFiscalProduto)
        Me.pagNotaFiscal.Controls.Add(Me.btnExcelGridNotaFiscal)
        Me.pagNotaFiscal.Controls.Add(Me.btnAgruparGridNotaFiscal)
        Me.pagNotaFiscal.Controls.Add(Me.btnConfigurarGridNotaFiscal)
        Me.pagNotaFiscal.Controls.Add(Me.grdNotaFiscal)
        Me.pagNotaFiscal.Controls.Add(Me.grdNotaFiscalProduto)
        Me.pagNotaFiscal.Key = "pagNotaFiscal"
        Me.pagNotaFiscal.Location = New System.Drawing.Point(1, 22)
        Me.pagNotaFiscal.Name = "pagNotaFiscal"
        Me.pagNotaFiscal.Size = New System.Drawing.Size(980, 384)
        Me.pagNotaFiscal.TabStop = True
        Me.pagNotaFiscal.Text = "Nota Fiscal"
        '
        'dtpDataTerminoNotaFiscal
        '
        '
        '
        '
        Me.dtpDataTerminoNotaFiscal.DropDownCalendar.Name = ""
        Me.dtpDataTerminoNotaFiscal.Location = New System.Drawing.Point(163, 8)
        Me.dtpDataTerminoNotaFiscal.Name = "dtpDataTerminoNotaFiscal"
        Me.dtpDataTerminoNotaFiscal.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataTerminoNotaFiscal.TabIndex = 13
        Me.dtpDataTerminoNotaFiscal.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'dtpDataInicioNotaFiscal
        '
        '
        '
        '
        Me.dtpDataInicioNotaFiscal.DropDownCalendar.Name = ""
        Me.dtpDataInicioNotaFiscal.Location = New System.Drawing.Point(57, 8)
        Me.dtpDataInicioNotaFiscal.Name = "dtpDataInicioNotaFiscal"
        Me.dtpDataInicioNotaFiscal.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataInicioNotaFiscal.TabIndex = 12
        Me.dtpDataInicioNotaFiscal.Value = New Date(2012, 6, 17, 0, 0, 0, 0)
        '
        'lblPeriodoNotaFiscal
        '
        Me.lblPeriodoNotaFiscal.AutoSize = True
        Me.lblPeriodoNotaFiscal.BackColor = System.Drawing.Color.Transparent
        Me.lblPeriodoNotaFiscal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPeriodoNotaFiscal.Location = New System.Drawing.Point(5, 11)
        Me.lblPeriodoNotaFiscal.Name = "lblPeriodoNotaFiscal"
        Me.lblPeriodoNotaFiscal.Size = New System.Drawing.Size(46, 14)
        Me.lblPeriodoNotaFiscal.TabIndex = 11
        Me.lblPeriodoNotaFiscal.Text = "Período:"
        '
        'btnExcelGridNotaFiscalProduto
        '
        Me.btnExcelGridNotaFiscalProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridNotaFiscalProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridNotaFiscalProduto.FlatAppearance.BorderSize = 0
        Me.btnExcelGridNotaFiscalProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridNotaFiscalProduto.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridNotaFiscalProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridNotaFiscalProduto.Location = New System.Drawing.Point(57, 358)
        Me.btnExcelGridNotaFiscalProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridNotaFiscalProduto.Name = "btnExcelGridNotaFiscalProduto"
        Me.btnExcelGridNotaFiscalProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridNotaFiscalProduto.TabIndex = 21
        Me.btnExcelGridNotaFiscalProduto.TabStop = False
        Me.btnExcelGridNotaFiscalProduto.UseVisualStyleBackColor = False
        '
        'btnAgruparGridNotaFiscalProduto
        '
        Me.btnAgruparGridNotaFiscalProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridNotaFiscalProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridNotaFiscalProduto.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridNotaFiscalProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridNotaFiscalProduto.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridNotaFiscalProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridNotaFiscalProduto.Location = New System.Drawing.Point(33, 358)
        Me.btnAgruparGridNotaFiscalProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridNotaFiscalProduto.Name = "btnAgruparGridNotaFiscalProduto"
        Me.btnAgruparGridNotaFiscalProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridNotaFiscalProduto.TabIndex = 20
        Me.btnAgruparGridNotaFiscalProduto.TabStop = False
        Me.btnAgruparGridNotaFiscalProduto.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridNotaFiscalProduto
        '
        Me.btnConfigurarGridNotaFiscalProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridNotaFiscalProduto.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridNotaFiscalProduto.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridNotaFiscalProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridNotaFiscalProduto.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridNotaFiscalProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridNotaFiscalProduto.Location = New System.Drawing.Point(9, 358)
        Me.btnConfigurarGridNotaFiscalProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridNotaFiscalProduto.Name = "btnConfigurarGridNotaFiscalProduto"
        Me.btnConfigurarGridNotaFiscalProduto.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridNotaFiscalProduto.TabIndex = 19
        Me.btnConfigurarGridNotaFiscalProduto.TabStop = False
        Me.btnConfigurarGridNotaFiscalProduto.UseVisualStyleBackColor = False
        '
        'btnExcelGridNotaFiscal
        '
        Me.btnExcelGridNotaFiscal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridNotaFiscal.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridNotaFiscal.FlatAppearance.BorderSize = 0
        Me.btnExcelGridNotaFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridNotaFiscal.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridNotaFiscal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridNotaFiscal.Location = New System.Drawing.Point(57, 171)
        Me.btnExcelGridNotaFiscal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridNotaFiscal.Name = "btnExcelGridNotaFiscal"
        Me.btnExcelGridNotaFiscal.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridNotaFiscal.TabIndex = 17
        Me.btnExcelGridNotaFiscal.TabStop = False
        Me.btnExcelGridNotaFiscal.UseVisualStyleBackColor = False
        '
        'btnAgruparGridNotaFiscal
        '
        Me.btnAgruparGridNotaFiscal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridNotaFiscal.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridNotaFiscal.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridNotaFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridNotaFiscal.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridNotaFiscal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridNotaFiscal.Location = New System.Drawing.Point(33, 171)
        Me.btnAgruparGridNotaFiscal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridNotaFiscal.Name = "btnAgruparGridNotaFiscal"
        Me.btnAgruparGridNotaFiscal.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridNotaFiscal.TabIndex = 16
        Me.btnAgruparGridNotaFiscal.TabStop = False
        Me.btnAgruparGridNotaFiscal.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridNotaFiscal
        '
        Me.btnConfigurarGridNotaFiscal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridNotaFiscal.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridNotaFiscal.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridNotaFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridNotaFiscal.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridNotaFiscal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridNotaFiscal.Location = New System.Drawing.Point(9, 171)
        Me.btnConfigurarGridNotaFiscal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridNotaFiscal.Name = "btnConfigurarGridNotaFiscal"
        Me.btnConfigurarGridNotaFiscal.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridNotaFiscal.TabIndex = 15
        Me.btnConfigurarGridNotaFiscal.TabStop = False
        Me.btnConfigurarGridNotaFiscal.UseVisualStyleBackColor = False
        '
        'grdNotaFiscal
        '
        Me.grdNotaFiscal.AlternatingColors = True
        Me.grdNotaFiscal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdNotaFiscal.AutoEdit = True
        grdNotaFiscal_DesignTimeLayout.LayoutString = resources.GetString("grdNotaFiscal_DesignTimeLayout.LayoutString")
        Me.grdNotaFiscal.DesignTimeLayout = grdNotaFiscal_DesignTimeLayout
        Me.grdNotaFiscal.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grdNotaFiscal.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdNotaFiscal.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdNotaFiscal.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdNotaFiscal.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdNotaFiscal.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdNotaFiscal.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdNotaFiscal.GroupByBoxVisible = False
        Me.grdNotaFiscal.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdNotaFiscal.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdNotaFiscal.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdNotaFiscal.Hierarchical = True
        Me.grdNotaFiscal.Location = New System.Drawing.Point(8, 35)
        Me.grdNotaFiscal.Name = "grdNotaFiscal"
        Me.grdNotaFiscal.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdNotaFiscal.RecordNavigator = True
        Me.grdNotaFiscal.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdNotaFiscal.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdNotaFiscal.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdNotaFiscal.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdNotaFiscal.Size = New System.Drawing.Size(964, 153)
        Me.grdNotaFiscal.TabIndex = 14
        Me.grdNotaFiscal.TabStop = False
        Me.grdNotaFiscal.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdNotaFiscal.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdNotaFiscal.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdNotaFiscal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdNotaFiscal.VisualStyleManager = Me.vsmMain
        '
        'grdNotaFiscalProduto
        '
        Me.grdNotaFiscalProduto.AlternatingColors = True
        Me.grdNotaFiscalProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdNotaFiscalProduto.AutoEdit = True
        Me.grdNotaFiscalProduto.ColumnAutoResize = True
        grdNotaFiscalProduto_DesignTimeLayout.LayoutString = resources.GetString("grdNotaFiscalProduto_DesignTimeLayout.LayoutString")
        Me.grdNotaFiscalProduto.DesignTimeLayout = grdNotaFiscalProduto_DesignTimeLayout
        Me.grdNotaFiscalProduto.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grdNotaFiscalProduto.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdNotaFiscalProduto.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdNotaFiscalProduto.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdNotaFiscalProduto.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdNotaFiscalProduto.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdNotaFiscalProduto.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdNotaFiscalProduto.GroupByBoxVisible = False
        Me.grdNotaFiscalProduto.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdNotaFiscalProduto.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.grdNotaFiscalProduto.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdNotaFiscalProduto.Hierarchical = True
        Me.grdNotaFiscalProduto.Location = New System.Drawing.Point(8, 197)
        Me.grdNotaFiscalProduto.Name = "grdNotaFiscalProduto"
        Me.grdNotaFiscalProduto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdNotaFiscalProduto.RecordNavigator = True
        Me.grdNotaFiscalProduto.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdNotaFiscalProduto.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdNotaFiscalProduto.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdNotaFiscalProduto.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdNotaFiscalProduto.Size = New System.Drawing.Size(964, 178)
        Me.grdNotaFiscalProduto.TabIndex = 18
        Me.grdNotaFiscalProduto.TabStop = False
        Me.grdNotaFiscalProduto.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdNotaFiscalProduto.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdNotaFiscalProduto.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdNotaFiscalProduto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdNotaFiscalProduto.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblPersonalidade)
        Me.grpFiltro.Controls.Add(Me.cboPersonalidade)
        Me.grpFiltro.Controls.Add(Me.btnProcurarParceiroNegocio)
        Me.grpFiltro.Controls.Add(Me.cboParceiroNegocioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblParceiroNegocioFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblPersonalidade
        '
        Me.lblPersonalidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPersonalidade.AutoSize = True
        Me.lblPersonalidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPersonalidade.Location = New System.Drawing.Point(841, 17)
        Me.lblPersonalidade.Name = "lblPersonalidade"
        Me.lblPersonalidade.Size = New System.Drawing.Size(78, 14)
        Me.lblPersonalidade.TabIndex = 8
        Me.lblPersonalidade.Text = "Personalidade:"
        '
        'cboPersonalidade
        '
        Me.cboPersonalidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPersonalidade.AutoSize = False
        Me.cboPersonalidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboPersonalidade.Location = New System.Drawing.Point(844, 34)
        Me.cboPersonalidade.Name = "cboPersonalidade"
        Me.cboPersonalidade.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPersonalidade.Size = New System.Drawing.Size(129, 20)
        Me.cboPersonalidade.TabIndex = 9
        '
        'btnProcurarParceiroNegocio
        '
        Me.btnProcurarParceiroNegocio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarParceiroNegocio.FlatAppearance.BorderSize = 0
        Me.btnProcurarParceiroNegocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarParceiroNegocio.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarParceiroNegocio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarParceiroNegocio.Location = New System.Drawing.Point(821, 16)
        Me.btnProcurarParceiroNegocio.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarParceiroNegocio.Name = "btnProcurarParceiroNegocio"
        Me.btnProcurarParceiroNegocio.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarParceiroNegocio.TabIndex = 7
        Me.btnProcurarParceiroNegocio.TabStop = False
        Me.btnProcurarParceiroNegocio.UseVisualStyleBackColor = True
        '
        'cboParceiroNegocioFiltro
        '
        Me.cboParceiroNegocioFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboParceiroNegocioFiltro.AutoSize = False
        Me.cboParceiroNegocioFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboParceiroNegocioFiltro.Location = New System.Drawing.Point(9, 34)
        Me.cboParceiroNegocioFiltro.Name = "cboParceiroNegocioFiltro"
        Me.cboParceiroNegocioFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboParceiroNegocioFiltro.Size = New System.Drawing.Size(829, 20)
        Me.cboParceiroNegocioFiltro.TabIndex = 1
        '
        'lblParceiroNegocioFiltro
        '
        Me.lblParceiroNegocioFiltro.AutoSize = True
        Me.lblParceiroNegocioFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblParceiroNegocioFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblParceiroNegocioFiltro.Name = "lblParceiroNegocioFiltro"
        Me.lblParceiroNegocioFiltro.Size = New System.Drawing.Size(107, 14)
        Me.lblParceiroNegocioFiltro.TabIndex = 0
        Me.lblParceiroNegocioFiltro.Text = "Parceiro de Negócio:"
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(982, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(785, 17)
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
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(882, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'usrCadParceiroNegocioRelacionamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadParceiroNegocioRelacionamento"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagOperacoesFinanceiras.ResumeLayout(False)
        CType(Me.grdContasRecebidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdContasAberto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDadosGerais.ResumeLayout(False)
        CType(Me.grpDadosGerais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosGerais.ResumeLayout(False)
        Me.grpDadosGerais.PerformLayout()
        Me.pagContatos.ResumeLayout(False)
        CType(Me.grpEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEndereco.ResumeLayout(False)
        Me.grpEndereco.PerformLayout()
        CType(Me.grdContato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagEnderecos.ResumeLayout(False)
        CType(Me.grdEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpEnderecoCobranca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEnderecoCobranca.ResumeLayout(False)
        Me.grpEnderecoCobranca.PerformLayout()
        Me.pagPedidoVenda.ResumeLayout(False)
        Me.pagPedidoVenda.PerformLayout()
        CType(Me.grdPedidoVendaProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPedidoVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagOrcamento.ResumeLayout(False)
        Me.pagOrcamento.PerformLayout()
        CType(Me.grdOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdOrcamentoProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagNotaFiscal.ResumeLayout(False)
        Me.pagNotaFiscal.PerformLayout()
        CType(Me.grdNotaFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdNotaFiscalProduto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboParceiroNegocioFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblParceiroNegocioFiltro As System.Windows.Forms.Label
    Friend WithEvents btnProcurarParceiroNegocio As System.Windows.Forms.Button
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagContatos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagEnderecos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagOperacoesFinanceiras As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdContasRecebidas As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagDadosGerais As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnConfigurarGridContasRecebidas As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridContasRecebidas As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridContasRecebidas As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridContato As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridContato As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridContato As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridEndereco As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridEndereco As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridEndereco As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridContasAberto As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridContasAberto As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridContasAberto As System.Windows.Forms.Button
    Friend WithEvents grdContasAberto As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblPersonalidade As System.Windows.Forms.Label
    Friend WithEvents cboPersonalidade As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents grpDadosGerais As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTipoInscricaoEstadual As System.Windows.Forms.Label
    Friend WithEvents cboTipoInscricaoEstadual As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarVendedorInterno As System.Windows.Forms.Button
    Friend WithEvents lblVendedorInterno As System.Windows.Forms.Label
    Friend WithEvents dtpDataCadastro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataCadastro As System.Windows.Forms.Label
    Friend WithEvents dtpDataFundacao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataFundacao As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarVendedor As System.Windows.Forms.Button
    Friend WithEvents lblVendedor As System.Windows.Forms.Label
    Friend WithEvents cboVendedor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtInscricaoEstadualSubstitutoTriburario As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoEstadualSubstitutoTriburario As System.Windows.Forms.Label
    Friend WithEvents txtTelefoneRecado As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTelefoneRecado As System.Windows.Forms.Label
    Friend WithEvents txtFax As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents txtTelefone2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTelefone2 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtTelefone1 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTelefone1 As System.Windows.Forms.Label
    Friend WithEvents txtInscricaoSuframa As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoSuframa As System.Windows.Forms.Label
    Friend WithEvents cboMunicipio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumero As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtComplemento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtBairro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents lblPais As System.Windows.Forms.Label
    Friend WithEvents cboPais As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCEP As System.Windows.Forms.Label
    Friend WithEvents txtCEP As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblComplemento As System.Windows.Forms.Label
    Friend WithEvents lblUF As System.Windows.Forms.Label
    Friend WithEvents cboUF As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMunicipio As System.Windows.Forms.Label
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblLogradouro As System.Windows.Forms.Label
    Friend WithEvents txtInscricaoMunicipal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoMunicipal As System.Windows.Forms.Label
    Friend WithEvents txtInscricaoEstadual As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoEstadual As System.Windows.Forms.Label
    Friend WithEvents txtCnpjCpf As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCnpjCpf As System.Windows.Forms.Label
    Friend WithEvents txtLogradouro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnProcurarCEP As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarPais As System.Windows.Forms.Button
    Friend WithEvents cboVendedorInterno As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents pagPedidoVenda As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagOrcamento As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnExcelGridOrcamento As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridOrcamento As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridOrcamento As System.Windows.Forms.Button
    Friend WithEvents grdOrcamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelGridPedido As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridPedido As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridPedido As System.Windows.Forms.Button
    Friend WithEvents grdOrcamentoProduto As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdPedidoVenda As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdPedidoVendaProduto As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelGridPedidoVendaProduto As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridPedidoVendaProduto As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridPedidoVendaProduto As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridOrcamentoProduto As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridOrcamentoProduto As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridOrcamentoProduto As System.Windows.Forms.Button
    Friend WithEvents grpEndereco As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCadastrarTipoContato As System.Windows.Forms.Button
    Friend WithEvents dtpDataAniversario As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataAniversario As System.Windows.Forms.Label
    Friend WithEvents txtCelularContato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCelularContato As System.Windows.Forms.Label
    Friend WithEvents txtTelefoneContato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipoContato As System.Windows.Forms.Label
    Friend WithEvents cboTipoContato As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtEmailContato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtComplementoContato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNomeContato As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblComplementoContato As System.Windows.Forms.Label
    Friend WithEvents lblEmailContato As System.Windows.Forms.Label
    Friend WithEvents lblTelefoneContato As System.Windows.Forms.Label
    Friend WithEvents lblNomeContato As System.Windows.Forms.Label
    Friend WithEvents btnExcluirContato As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvarContato As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdContato As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdEndereco As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpEnderecoCobranca As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluirEndereco As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvarEndereco As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnProcurarCepEndereco As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarPaisEndereco As System.Windows.Forms.Button
    Friend WithEvents cboMunicipioEndereco As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroEndereco As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtComplementoEndereco As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtBairroEndereco As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPaisEndereco As System.Windows.Forms.Label
    Friend WithEvents cboPaisEndereco As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCepEndereco As System.Windows.Forms.Label
    Friend WithEvents txtCepEndereco As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblComplementoEndereco As System.Windows.Forms.Label
    Friend WithEvents lblUFEndereco As System.Windows.Forms.Label
    Friend WithEvents cboUFEndereco As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMunicipioEndereco As System.Windows.Forms.Label
    Friend WithEvents lblBairroEndereco As System.Windows.Forms.Label
    Friend WithEvents lblNumeroEndereco As System.Windows.Forms.Label
    Friend WithEvents lblLogradouroEndereco As System.Windows.Forms.Label
    Friend WithEvents txtLogradouroEndereco As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblTipoEndereco As System.Windows.Forms.Label
    Friend WithEvents cboTipoEndereco As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents dtpDataTerminoPedidoVenda As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioPedidoVenda As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblPeriodoPedidoVenda As System.Windows.Forms.Label
    Friend WithEvents dtpDataTerminoOrcamento As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioOrcamento As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblPeriodoOrcamento As System.Windows.Forms.Label
    Friend WithEvents pagNotaFiscal As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents dtpDataTerminoNotaFiscal As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioNotaFiscal As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblPeriodoNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents btnExcelGridNotaFiscalProduto As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridNotaFiscalProduto As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridNotaFiscalProduto As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridNotaFiscal As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridNotaFiscal As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridNotaFiscal As System.Windows.Forms.Button
    Friend WithEvents grdNotaFiscal As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdNotaFiscalProduto As Janus.Windows.GridEX.GridEX

End Class
