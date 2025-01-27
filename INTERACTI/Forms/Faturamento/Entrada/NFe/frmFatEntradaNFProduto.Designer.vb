<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEntradaNFProduto
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
        Dim grdEstoque_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdEstoque_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEntradaNFProduto))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosItem = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboCFOP = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCFOP = New System.Windows.Forms.Label()
        Me.btnCadastrarCFOP = New System.Windows.Forms.Button()
        Me.txtCodigoProdutoFornecedor = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtOutrasDespesas = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblOutrasDespesas = New System.Windows.Forms.Label()
        Me.txtValorFrete = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorFrete = New System.Windows.Forms.Label()
        Me.txtValorSeguro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorSeguro = New System.Windows.Forms.Label()
        Me.txtInformacoesAdicionais = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblInformacoesAdicionais = New System.Windows.Forms.Label()
        Me.lblIncideValorTotalNF = New System.Windows.Forms.Label()
        Me.cboIncideValorTotalNF = New Janus.Windows.EditControls.UIComboBox()
        Me.txtCodigoEAN = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoEAN = New System.Windows.Forms.Label()
        Me.txtValorDesconto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorDesconto = New System.Windows.Forms.Label()
        Me.btnCadastrarUnidadeMedida = New System.Windows.Forms.Button()
        Me.btnCadastrarNCM = New System.Windows.Forms.Button()
        Me.txtValorTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.txtValorUnitario = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnitario = New System.Windows.Forms.Label()
        Me.lblUnidadeMedida = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.lblNCM = New System.Windows.Forms.Label()
        Me.cboNCM = New Janus.Windows.EditControls.UIComboBox()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.cboUnidadeMedida = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoProdutoFornecedor = New System.Windows.Forms.Label()
        Me.grpControleDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvarDados = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltarDados = New Janus.Windows.EditControls.UIButton()
        Me.pagTributos = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvarTributos = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltarTributos = New Janus.Windows.EditControls.UIButton()
        Me.tabTributo = New Janus.Windows.UI.Tab.UITab()
        Me.pagICMS = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpICMSSTRetido = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtBaseCalculoICMSSTRetido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBaseCalculoICMSSTRetido = New System.Windows.Forms.Label()
        Me.txtValorICMSSTRetido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorICMSSTRetido = New System.Windows.Forms.Label()
        Me.grpICMSST = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboModalidadeBCICMSST = New Janus.Windows.EditControls.UIComboBox()
        Me.lblModalidadeBCICMSST = New System.Windows.Forms.Label()
        Me.txtBaseCalculoICMSST = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBaseCalculoICMSST = New System.Windows.Forms.Label()
        Me.txtIVA = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.txtAliquotaICMSST = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaICMSST = New System.Windows.Forms.Label()
        Me.txtPorcentagemReducaoBCICMSST = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPorcentagemReducaoBCICMSST = New System.Windows.Forms.Label()
        Me.grpSituacaoTributariaICMS = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboOrigem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOrigem = New System.Windows.Forms.Label()
        Me.cboSituacaoTributariaICMS = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSituacaoTributariaICMS = New System.Windows.Forms.Label()
        Me.grpICMS = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtBaseCalculoICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBaseCalculoICMS = New System.Windows.Forms.Label()
        Me.txtValorICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorICMS = New System.Windows.Forms.Label()
        Me.cboModalidadeBCICMS = New Janus.Windows.EditControls.UIComboBox()
        Me.lblModalidadeBCICMS = New System.Windows.Forms.Label()
        Me.txtAliquotaICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaICMS = New System.Windows.Forms.Label()
        Me.txtPorcentagemReducaoBCICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPorcentagemReducaoBCICMS = New System.Windows.Forms.Label()
        Me.pagICMSSimples = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpICMSSTRetidoSimples = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtBaseCalculoICMSSTRetidoSimples = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBaseCalculoICMSSTRetidoSimples = New System.Windows.Forms.Label()
        Me.txtValorICMSSTRetidoSimples = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorICMSSTRetidoSimples = New System.Windows.Forms.Label()
        Me.grpICMSSTSimples = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboModalidadeBCICMSSTSimples = New Janus.Windows.EditControls.UIComboBox()
        Me.lblModalidadeBCICMSSTSimples = New System.Windows.Forms.Label()
        Me.txtBaseCalculoICMSSTSimples = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBaseCalculoICMSSTSimples = New System.Windows.Forms.Label()
        Me.txtIVASimples = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblIVASimples = New System.Windows.Forms.Label()
        Me.txtAliquotaICMSSTSimples = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaICMSSTSimples = New System.Windows.Forms.Label()
        Me.txtPorcentagemReducaoBCICMSSTSimples = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPorcentagemReducaoBCICMSSTSimples = New System.Windows.Forms.Label()
        Me.grpICMSSimples = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorICMSSimples = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorICMSSimples = New System.Windows.Forms.Label()
        Me.cboModalidadeBCICMSSimples = New Janus.Windows.EditControls.UIComboBox()
        Me.lblModalidadeBCICMSSimples = New System.Windows.Forms.Label()
        Me.txtAliquotaICMSSimples = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaICMSSimples = New System.Windows.Forms.Label()
        Me.txtPorcentagemReducaoBCICMSSimples = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPorcentagemReducaoBCICMSSimples = New System.Windows.Forms.Label()
        Me.txtBaseCalculoICMSSimples = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBaseCalculoICMSSimples = New System.Windows.Forms.Label()
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCreditoICMSAproveitadoSimples = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCreditoICMSAproveitadoSimples = New System.Windows.Forms.Label()
        Me.txtAliquotaCalculoCreditoICMSSimples = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaCalculoCreditoICMSSimples = New System.Windows.Forms.Label()
        Me.cboOrigemSimples = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOrigemSimples = New System.Windows.Forms.Label()
        Me.cboSituacaoTributariaICMSSimples = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSituacaoTributariaICMSSimples = New System.Windows.Forms.Label()
        Me.pagIPI = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpValoresIPI = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorUnidadeIPI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnidadeIPI = New System.Windows.Forms.Label()
        Me.txtQuantidadeIPI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeIPI = New System.Windows.Forms.Label()
        Me.cboTipoCalculoIPI = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoCalculoIPI = New System.Windows.Forms.Label()
        Me.txtValorIPI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorIPI = New System.Windows.Forms.Label()
        Me.txtBaseCalculoIPI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBaseCalculoIPI = New System.Windows.Forms.Label()
        Me.txtAliquotaIPI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaIPI = New System.Windows.Forms.Label()
        Me.grpSituacaoTributariaIPI = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboSituacaoTributariaIPI = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSituacaoTributariaIPI = New System.Windows.Forms.Label()
        Me.pagPIS = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpPIS = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboTipoCalculoPIS = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoCalculoPIS = New System.Windows.Forms.Label()
        Me.txtBaseCalculoPIS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBaseCalculoPIS = New System.Windows.Forms.Label()
        Me.txtQuantidadeVendidaPIS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeVendidaPIS = New System.Windows.Forms.Label()
        Me.txtValorPIS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorPIS = New System.Windows.Forms.Label()
        Me.txtAliquotaPercentualPIS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaPercentualPIS = New System.Windows.Forms.Label()
        Me.txtAliquotaValorPIS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaValorPIS = New System.Windows.Forms.Label()
        Me.grpSituacaoTributariaPIS = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboSituacaoTributariaPIS = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSituacaoTributariaPIS = New System.Windows.Forms.Label()
        Me.pagCOFINS = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpCOFINS = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboTipoCalculoCOFINS = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoCalculoCOFINS = New System.Windows.Forms.Label()
        Me.txtBaseCalculoCOFINS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBaseCalculoCOFINS = New System.Windows.Forms.Label()
        Me.txtQuantidadeVendidaCOFINS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeVendidaCOFINS = New System.Windows.Forms.Label()
        Me.txtValorCOFINS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorCOFINS = New System.Windows.Forms.Label()
        Me.txtAliquotaPercentualCOFINS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaPercentualCOFINS = New System.Windows.Forms.Label()
        Me.txtAliquotaValorCOFINS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaValorCOFINS = New System.Windows.Forms.Label()
        Me.grpSituacaoTributariaCOFINS = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboSituacaoTributariaCOFINS = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSituacaoTributariaCOFINS = New System.Windows.Forms.Label()
        Me.pagImpostoImportacao = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpII = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorII = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorII = New System.Windows.Forms.Label()
        Me.txtValorIOF = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorIOF = New System.Windows.Forms.Label()
        Me.txtDespesaAduaneiraII = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDespesaAduaneiraII = New System.Windows.Forms.Label()
        Me.txtBaseCalculoII = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBaseCalculoII = New System.Windows.Forms.Label()
        Me.pagEstoque = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGridEstoque = New System.Windows.Forms.Button()
        Me.btnConfigurarGridEstoque = New System.Windows.Forms.Button()
        Me.grpSalvarLote = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnSalvarLote = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltarLote = New Janus.Windows.EditControls.UIButton()
        Me.grdEstoque = New Janus.Windows.GridEX.GridEX()
        Me.grpEstoque = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarProduto = New System.Windows.Forms.Button()
        Me.cboProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.btnAtualizarPedidoCompra = New System.Windows.Forms.Button()
        Me.lblQuantidadeDocumento = New System.Windows.Forms.Label()
        Me.txtQuantidadeDocumento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.cboNumeroDocumento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoOperacao = New System.Windows.Forms.Label()
        Me.cboTipoOperacao = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarUnidadeMedidaEstoque = New System.Windows.Forms.Button()
        Me.lblUnidadeMedidaEstoque = New System.Windows.Forms.Label()
        Me.cboUnidadeMedidaEstoque = New Janus.Windows.EditControls.UIComboBox()
        Me.lblQuantidadeEstoque = New System.Windows.Forms.Label()
        Me.txtQuantidadeEstoque = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtFatorConversao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblFatorConversao = New System.Windows.Forms.Label()
        Me.txtQuantidadeLote = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeLote = New System.Windows.Forms.Label()
        Me.btnCadastrarDeposito = New System.Windows.Forms.Button()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.cboDeposito = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDataFabricacao = New System.Windows.Forms.Label()
        Me.dtpDataFabricacao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblOCCapa = New System.Windows.Forms.Label()
        Me.txtOCCapa = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOCLinha = New System.Windows.Forms.Label()
        Me.txtOCLinha = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataValidade = New System.Windows.Forms.Label()
        Me.dtpDataValidade = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.txtLote = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnExcluirEstoque = New Janus.Windows.EditControls.UIButton()
        Me.btnInserirEstoque = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpDadosItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosItem.SuspendLayout()
        CType(Me.grpControleDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleDados.SuspendLayout()
        Me.pagTributos.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.tabTributo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTributo.SuspendLayout()
        Me.pagICMS.SuspendLayout()
        CType(Me.grpICMSSTRetido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpICMSSTRetido.SuspendLayout()
        CType(Me.grpICMSST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpICMSST.SuspendLayout()
        CType(Me.grpSituacaoTributariaICMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSituacaoTributariaICMS.SuspendLayout()
        CType(Me.grpICMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpICMS.SuspendLayout()
        Me.pagICMSSimples.SuspendLayout()
        CType(Me.grpICMSSTRetidoSimples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpICMSSTRetidoSimples.SuspendLayout()
        CType(Me.grpICMSSTSimples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpICMSSTSimples.SuspendLayout()
        CType(Me.grpICMSSimples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpICMSSimples.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        Me.pagIPI.SuspendLayout()
        CType(Me.grpValoresIPI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpValoresIPI.SuspendLayout()
        CType(Me.grpSituacaoTributariaIPI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSituacaoTributariaIPI.SuspendLayout()
        Me.pagPIS.SuspendLayout()
        CType(Me.grpPIS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPIS.SuspendLayout()
        CType(Me.grpSituacaoTributariaPIS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSituacaoTributariaPIS.SuspendLayout()
        Me.pagCOFINS.SuspendLayout()
        CType(Me.grpCOFINS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCOFINS.SuspendLayout()
        CType(Me.grpSituacaoTributariaCOFINS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSituacaoTributariaCOFINS.SuspendLayout()
        Me.pagImpostoImportacao.SuspendLayout()
        CType(Me.grpII, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpII.SuspendLayout()
        Me.pagEstoque.SuspendLayout()
        CType(Me.grpSalvarLote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSalvarLote.SuspendLayout()
        CType(Me.grdEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEstoque.SuspendLayout()
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
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(969, 445)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados, Me.pagTributos, Me.pagEstoque})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpDadosItem)
        Me.pagDados.Controls.Add(Me.grpControleDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(967, 422)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados Gerais"
        '
        'grpDadosItem
        '
        Me.grpDadosItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosItem.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosItem.Controls.Add(Me.cboCFOP)
        Me.grpDadosItem.Controls.Add(Me.lblCFOP)
        Me.grpDadosItem.Controls.Add(Me.btnCadastrarCFOP)
        Me.grpDadosItem.Controls.Add(Me.txtCodigoProdutoFornecedor)
        Me.grpDadosItem.Controls.Add(Me.txtOutrasDespesas)
        Me.grpDadosItem.Controls.Add(Me.lblOutrasDespesas)
        Me.grpDadosItem.Controls.Add(Me.txtValorFrete)
        Me.grpDadosItem.Controls.Add(Me.lblValorFrete)
        Me.grpDadosItem.Controls.Add(Me.txtValorSeguro)
        Me.grpDadosItem.Controls.Add(Me.lblValorSeguro)
        Me.grpDadosItem.Controls.Add(Me.txtInformacoesAdicionais)
        Me.grpDadosItem.Controls.Add(Me.lblInformacoesAdicionais)
        Me.grpDadosItem.Controls.Add(Me.lblIncideValorTotalNF)
        Me.grpDadosItem.Controls.Add(Me.cboIncideValorTotalNF)
        Me.grpDadosItem.Controls.Add(Me.txtCodigoEAN)
        Me.grpDadosItem.Controls.Add(Me.lblCodigoEAN)
        Me.grpDadosItem.Controls.Add(Me.txtValorDesconto)
        Me.grpDadosItem.Controls.Add(Me.lblValorDesconto)
        Me.grpDadosItem.Controls.Add(Me.btnCadastrarUnidadeMedida)
        Me.grpDadosItem.Controls.Add(Me.btnCadastrarNCM)
        Me.grpDadosItem.Controls.Add(Me.txtValorTotal)
        Me.grpDadosItem.Controls.Add(Me.lblValorTotal)
        Me.grpDadosItem.Controls.Add(Me.txtValorUnitario)
        Me.grpDadosItem.Controls.Add(Me.lblValorUnitario)
        Me.grpDadosItem.Controls.Add(Me.lblUnidadeMedida)
        Me.grpDadosItem.Controls.Add(Me.txtQuantidade)
        Me.grpDadosItem.Controls.Add(Me.lblQuantidade)
        Me.grpDadosItem.Controls.Add(Me.lblNCM)
        Me.grpDadosItem.Controls.Add(Me.cboNCM)
        Me.grpDadosItem.Controls.Add(Me.txtDescricao)
        Me.grpDadosItem.Controls.Add(Me.lblDescricao)
        Me.grpDadosItem.Controls.Add(Me.cboUnidadeMedida)
        Me.grpDadosItem.Controls.Add(Me.lblCodigoProdutoFornecedor)
        Me.grpDadosItem.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosItem.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosItem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDadosItem.Name = "grpDadosItem"
        Me.grpDadosItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosItem.Size = New System.Drawing.Size(951, 356)
        Me.grpDadosItem.TabIndex = 0
        Me.grpDadosItem.Text = "Dados do Produto"
        Me.grpDadosItem.VisualStyleManager = Me.vsmMain
        '
        'cboCFOP
        '
        Me.cboCFOP.AutoSize = False
        Me.cboCFOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCFOP.Location = New System.Drawing.Point(9, 37)
        Me.cboCFOP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCFOP.Name = "cboCFOP"
        Me.cboCFOP.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCFOP.Size = New System.Drawing.Size(107, 20)
        Me.cboCFOP.TabIndex = 2
        '
        'lblCFOP
        '
        Me.lblCFOP.AutoSize = True
        Me.lblCFOP.Location = New System.Drawing.Point(25, 20)
        Me.lblCFOP.Name = "lblCFOP"
        Me.lblCFOP.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOP.TabIndex = 1
        Me.lblCFOP.Text = "CFOP:"
        '
        'btnCadastrarCFOP
        '
        Me.btnCadastrarCFOP.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCFOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCFOP.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCFOP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCFOP.Location = New System.Drawing.Point(9, 21)
        Me.btnCadastrarCFOP.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCFOP.Name = "btnCadastrarCFOP"
        Me.btnCadastrarCFOP.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCFOP.TabIndex = 0
        Me.btnCadastrarCFOP.TabStop = False
        Me.btnCadastrarCFOP.UseVisualStyleBackColor = True
        '
        'txtCodigoProdutoFornecedor
        '
        Me.txtCodigoProdutoFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoProdutoFornecedor.Location = New System.Drawing.Point(122, 37)
        Me.txtCodigoProdutoFornecedor.MaxLength = 14
        Me.txtCodigoProdutoFornecedor.Name = "txtCodigoProdutoFornecedor"
        Me.txtCodigoProdutoFornecedor.Size = New System.Drawing.Size(202, 20)
        Me.txtCodigoProdutoFornecedor.TabIndex = 4
        '
        'txtOutrasDespesas
        '
        Me.txtOutrasDespesas.DecimalDigits = 2
        Me.txtOutrasDespesas.Location = New System.Drawing.Point(639, 77)
        Me.txtOutrasDespesas.Name = "txtOutrasDespesas"
        Me.txtOutrasDespesas.Size = New System.Drawing.Size(92, 20)
        Me.txtOutrasDespesas.TabIndex = 26
        Me.txtOutrasDespesas.Text = "0,00"
        Me.txtOutrasDespesas.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblOutrasDespesas
        '
        Me.lblOutrasDespesas.AutoSize = True
        Me.lblOutrasDespesas.Location = New System.Drawing.Point(636, 60)
        Me.lblOutrasDespesas.Name = "lblOutrasDespesas"
        Me.lblOutrasDespesas.Size = New System.Drawing.Size(95, 14)
        Me.lblOutrasDespesas.TabIndex = 25
        Me.lblOutrasDespesas.Text = "Outras Despesas:"
        '
        'txtValorFrete
        '
        Me.txtValorFrete.DecimalDigits = 2
        Me.txtValorFrete.Location = New System.Drawing.Point(443, 77)
        Me.txtValorFrete.Name = "txtValorFrete"
        Me.txtValorFrete.Size = New System.Drawing.Size(92, 20)
        Me.txtValorFrete.TabIndex = 22
        Me.txtValorFrete.Text = "0,00"
        Me.txtValorFrete.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorFrete
        '
        Me.lblValorFrete.AutoSize = True
        Me.lblValorFrete.Location = New System.Drawing.Point(440, 60)
        Me.lblValorFrete.Name = "lblValorFrete"
        Me.lblValorFrete.Size = New System.Drawing.Size(63, 14)
        Me.lblValorFrete.TabIndex = 21
        Me.lblValorFrete.Text = "Valor Frete:"
        '
        'txtValorSeguro
        '
        Me.txtValorSeguro.DecimalDigits = 2
        Me.txtValorSeguro.Location = New System.Drawing.Point(541, 77)
        Me.txtValorSeguro.Name = "txtValorSeguro"
        Me.txtValorSeguro.Size = New System.Drawing.Size(92, 20)
        Me.txtValorSeguro.TabIndex = 24
        Me.txtValorSeguro.Text = "0,00"
        Me.txtValorSeguro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorSeguro
        '
        Me.lblValorSeguro.AutoSize = True
        Me.lblValorSeguro.Location = New System.Drawing.Point(538, 60)
        Me.lblValorSeguro.Name = "lblValorSeguro"
        Me.lblValorSeguro.Size = New System.Drawing.Size(73, 14)
        Me.lblValorSeguro.TabIndex = 23
        Me.lblValorSeguro.Text = "Valor Seguro:"
        '
        'txtInformacoesAdicionais
        '
        Me.txtInformacoesAdicionais.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInformacoesAdicionais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInformacoesAdicionais.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInformacoesAdicionais.Location = New System.Drawing.Point(9, 117)
        Me.txtInformacoesAdicionais.MaxLength = 500
        Me.txtInformacoesAdicionais.Multiline = True
        Me.txtInformacoesAdicionais.Name = "txtInformacoesAdicionais"
        Me.txtInformacoesAdicionais.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInformacoesAdicionais.Size = New System.Drawing.Size(933, 229)
        Me.txtInformacoesAdicionais.TabIndex = 32
        '
        'lblInformacoesAdicionais
        '
        Me.lblInformacoesAdicionais.AutoSize = True
        Me.lblInformacoesAdicionais.Location = New System.Drawing.Point(6, 100)
        Me.lblInformacoesAdicionais.Name = "lblInformacoesAdicionais"
        Me.lblInformacoesAdicionais.Size = New System.Drawing.Size(122, 14)
        Me.lblInformacoesAdicionais.TabIndex = 31
        Me.lblInformacoesAdicionais.Text = "Informações Adicionais:"
        '
        'lblIncideValorTotalNF
        '
        Me.lblIncideValorTotalNF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIncideValorTotalNF.AutoSize = True
        Me.lblIncideValorTotalNF.Location = New System.Drawing.Point(734, 20)
        Me.lblIncideValorTotalNF.Name = "lblIncideValorTotalNF"
        Me.lblIncideValorTotalNF.Size = New System.Drawing.Size(82, 14)
        Me.lblIncideValorTotalNF.TabIndex = 7
        Me.lblIncideValorTotalNF.Text = "Incide Valor NF:"
        '
        'cboIncideValorTotalNF
        '
        Me.cboIncideValorTotalNF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboIncideValorTotalNF.AutoSize = False
        Me.cboIncideValorTotalNF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboIncideValorTotalNF.Location = New System.Drawing.Point(737, 37)
        Me.cboIncideValorTotalNF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboIncideValorTotalNF.Name = "cboIncideValorTotalNF"
        Me.cboIncideValorTotalNF.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboIncideValorTotalNF.Size = New System.Drawing.Size(92, 20)
        Me.cboIncideValorTotalNF.TabIndex = 8
        Me.cboIncideValorTotalNF.UseCompatibleTextRendering = True
        '
        'txtCodigoEAN
        '
        Me.txtCodigoEAN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigoEAN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoEAN.Location = New System.Drawing.Point(835, 37)
        Me.txtCodigoEAN.MaxLength = 14
        Me.txtCodigoEAN.Name = "txtCodigoEAN"
        Me.txtCodigoEAN.Size = New System.Drawing.Size(107, 20)
        Me.txtCodigoEAN.TabIndex = 10
        '
        'lblCodigoEAN
        '
        Me.lblCodigoEAN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodigoEAN.AutoSize = True
        Me.lblCodigoEAN.Location = New System.Drawing.Point(832, 20)
        Me.lblCodigoEAN.Name = "lblCodigoEAN"
        Me.lblCodigoEAN.Size = New System.Drawing.Size(67, 14)
        Me.lblCodigoEAN.TabIndex = 9
        Me.lblCodigoEAN.Text = "Código EAN:"
        '
        'txtValorDesconto
        '
        Me.txtValorDesconto.DecimalDigits = 2
        Me.txtValorDesconto.Location = New System.Drawing.Point(737, 77)
        Me.txtValorDesconto.Name = "txtValorDesconto"
        Me.txtValorDesconto.Size = New System.Drawing.Size(92, 20)
        Me.txtValorDesconto.TabIndex = 28
        Me.txtValorDesconto.Text = "0,00"
        Me.txtValorDesconto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorDesconto
        '
        Me.lblValorDesconto.AutoSize = True
        Me.lblValorDesconto.Location = New System.Drawing.Point(739, 60)
        Me.lblValorDesconto.Name = "lblValorDesconto"
        Me.lblValorDesconto.Size = New System.Drawing.Size(84, 14)
        Me.lblValorDesconto.TabIndex = 27
        Me.lblValorDesconto.Text = "Valor Desconto:"
        '
        'btnCadastrarUnidadeMedida
        '
        Me.btnCadastrarUnidadeMedida.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUnidadeMedida.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarUnidadeMedida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUnidadeMedida.Location = New System.Drawing.Point(235, 61)
        Me.btnCadastrarUnidadeMedida.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUnidadeMedida.Name = "btnCadastrarUnidadeMedida"
        Me.btnCadastrarUnidadeMedida.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarUnidadeMedida.TabIndex = 16
        Me.btnCadastrarUnidadeMedida.TabStop = False
        Me.btnCadastrarUnidadeMedida.UseVisualStyleBackColor = True
        '
        'btnCadastrarNCM
        '
        Me.btnCadastrarNCM.FlatAppearance.BorderSize = 0
        Me.btnCadastrarNCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarNCM.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarNCM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarNCM.Location = New System.Drawing.Point(9, 60)
        Me.btnCadastrarNCM.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarNCM.Name = "btnCadastrarNCM"
        Me.btnCadastrarNCM.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarNCM.TabIndex = 11
        Me.btnCadastrarNCM.TabStop = False
        Me.btnCadastrarNCM.UseVisualStyleBackColor = True
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTotal.DecimalDigits = 2
        Me.txtValorTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Location = New System.Drawing.Point(835, 77)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(107, 20)
        Me.txtValorTotal.TabIndex = 30
        Me.txtValorTotal.TabStop = False
        Me.txtValorTotal.Text = "0,00"
        Me.txtValorTotal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.Location = New System.Drawing.Point(832, 60)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(60, 14)
        Me.lblValorTotal.TabIndex = 29
        Me.lblValorTotal.Text = "Valor Total:"
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.DecimalDigits = 4
        Me.txtValorUnitario.Location = New System.Drawing.Point(330, 77)
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.Size = New System.Drawing.Size(107, 20)
        Me.txtValorUnitario.TabIndex = 20
        Me.txtValorUnitario.Text = "0,0000"
        Me.txtValorUnitario.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblValorUnitario
        '
        Me.lblValorUnitario.AutoSize = True
        Me.lblValorUnitario.Location = New System.Drawing.Point(327, 60)
        Me.lblValorUnitario.Name = "lblValorUnitario"
        Me.lblValorUnitario.Size = New System.Drawing.Size(74, 14)
        Me.lblValorUnitario.TabIndex = 19
        Me.lblValorUnitario.Text = "Valor Unitário:"
        '
        'lblUnidadeMedida
        '
        Me.lblUnidadeMedida.AutoSize = True
        Me.lblUnidadeMedida.Location = New System.Drawing.Point(251, 60)
        Me.lblUnidadeMedida.Name = "lblUnidadeMedida"
        Me.lblUnidadeMedida.Size = New System.Drawing.Size(58, 14)
        Me.lblUnidadeMedida.TabIndex = 17
        Me.lblUnidadeMedida.Text = "Und. Med.:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(122, 77)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(107, 20)
        Me.txtQuantidade.TabIndex = 15
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(119, 60)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 14
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'lblNCM
        '
        Me.lblNCM.AutoSize = True
        Me.lblNCM.Location = New System.Drawing.Point(25, 60)
        Me.lblNCM.Name = "lblNCM"
        Me.lblNCM.Size = New System.Drawing.Size(32, 14)
        Me.lblNCM.TabIndex = 12
        Me.lblNCM.Text = "NCM:"
        '
        'cboNCM
        '
        Me.cboNCM.AutoSize = False
        Me.cboNCM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNCM.Location = New System.Drawing.Point(9, 77)
        Me.cboNCM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboNCM.Name = "cboNCM"
        Me.cboNCM.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNCM.Size = New System.Drawing.Size(107, 20)
        Me.cboNCM.TabIndex = 13
        Me.cboNCM.UseCompatibleTextRendering = True
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(330, 37)
        Me.txtDescricao.MaxLength = 120
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(401, 20)
        Me.txtDescricao.TabIndex = 6
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(327, 20)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 5
        Me.lblDescricao.Text = "Descrição:"
        '
        'cboUnidadeMedida
        '
        Me.cboUnidadeMedida.AutoSize = False
        Me.cboUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedida.Location = New System.Drawing.Point(235, 77)
        Me.cboUnidadeMedida.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboUnidadeMedida.Name = "cboUnidadeMedida"
        Me.cboUnidadeMedida.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedida.Size = New System.Drawing.Size(89, 20)
        Me.cboUnidadeMedida.TabIndex = 18
        '
        'lblCodigoProdutoFornecedor
        '
        Me.lblCodigoProdutoFornecedor.AutoSize = True
        Me.lblCodigoProdutoFornecedor.Location = New System.Drawing.Point(119, 20)
        Me.lblCodigoProdutoFornecedor.Name = "lblCodigoProdutoFornecedor"
        Me.lblCodigoProdutoFornecedor.Size = New System.Drawing.Size(102, 14)
        Me.lblCodigoProdutoFornecedor.TabIndex = 3
        Me.lblCodigoProdutoFornecedor.Text = "Código Fornecedor:"
        '
        'grpControleDados
        '
        Me.grpControleDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControleDados.BackColor = System.Drawing.Color.Transparent
        Me.grpControleDados.Controls.Add(Me.btnSalvarDados)
        Me.grpControleDados.Controls.Add(Me.btnVoltarDados)
        Me.grpControleDados.Location = New System.Drawing.Point(8, 362)
        Me.grpControleDados.Name = "grpControleDados"
        Me.grpControleDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleDados.Size = New System.Drawing.Size(951, 51)
        Me.grpControleDados.TabIndex = 2
        Me.grpControleDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControleDados.VisualStyleManager = Me.vsmMain
        '
        'btnSalvarDados
        '
        Me.btnSalvarDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvarDados.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvarDados.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvarDados.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvarDados.Location = New System.Drawing.Point(754, 17)
        Me.btnSalvarDados.Name = "btnSalvarDados"
        Me.btnSalvarDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvarDados.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvarDados.TabIndex = 0
        Me.btnSalvarDados.Text = "Salvar"
        Me.btnSalvarDados.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltarDados
        '
        Me.btnVoltarDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltarDados.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltarDados.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltarDados.Location = New System.Drawing.Point(851, 17)
        Me.btnVoltarDados.Name = "btnVoltarDados"
        Me.btnVoltarDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltarDados.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltarDados.TabIndex = 1
        Me.btnVoltarDados.Text = "Voltar"
        Me.btnVoltarDados.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pagTributos
        '
        Me.pagTributos.Controls.Add(Me.UiGroupBox1)
        Me.pagTributos.Controls.Add(Me.tabTributo)
        Me.pagTributos.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagTributos.Key = "pagTributos"
        Me.pagTributos.Location = New System.Drawing.Point(1, 22)
        Me.pagTributos.Name = "pagTributos"
        Me.pagTributos.Size = New System.Drawing.Size(967, 422)
        Me.pagTributos.TabStop = True
        Me.pagTributos.Text = "Tributos"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.btnSalvarTributos)
        Me.UiGroupBox1.Controls.Add(Me.btnVoltarTributos)
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 362)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(951, 51)
        Me.UiGroupBox1.TabIndex = 1
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'btnSalvarTributos
        '
        Me.btnSalvarTributos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvarTributos.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvarTributos.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvarTributos.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvarTributos.Location = New System.Drawing.Point(754, 17)
        Me.btnSalvarTributos.Name = "btnSalvarTributos"
        Me.btnSalvarTributos.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvarTributos.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvarTributos.TabIndex = 0
        Me.btnSalvarTributos.Text = "Salvar"
        Me.btnSalvarTributos.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltarTributos
        '
        Me.btnVoltarTributos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltarTributos.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltarTributos.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltarTributos.Location = New System.Drawing.Point(851, 17)
        Me.btnVoltarTributos.Name = "btnVoltarTributos"
        Me.btnVoltarTributos.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltarTributos.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltarTributos.TabIndex = 1
        Me.btnVoltarTributos.Text = "Voltar"
        Me.btnVoltarTributos.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'tabTributo
        '
        Me.tabTributo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabTributo.BackColor = System.Drawing.Color.Transparent
        Me.tabTributo.FocusOnClick = False
        Me.tabTributo.Location = New System.Drawing.Point(8, 7)
        Me.tabTributo.Name = "tabTributo"
        Me.tabTributo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabTributo.ShowFocusRectangle = False
        Me.tabTributo.Size = New System.Drawing.Size(951, 352)
        Me.tabTributo.TabIndex = 0
        Me.tabTributo.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagICMS, Me.pagICMSSimples, Me.pagIPI, Me.pagPIS, Me.pagCOFINS, Me.pagImpostoImportacao})
        Me.tabTributo.TabStop = False
        Me.tabTributo.VisualStyleManager = Me.vsmMain
        '
        'pagICMS
        '
        Me.pagICMS.Controls.Add(Me.grpICMSSTRetido)
        Me.pagICMS.Controls.Add(Me.grpICMSST)
        Me.pagICMS.Controls.Add(Me.grpSituacaoTributariaICMS)
        Me.pagICMS.Controls.Add(Me.grpICMS)
        Me.pagICMS.Key = "pagICMS"
        Me.pagICMS.Location = New System.Drawing.Point(1, 22)
        Me.pagICMS.Name = "pagICMS"
        Me.pagICMS.Size = New System.Drawing.Size(949, 329)
        Me.pagICMS.TabStop = True
        Me.pagICMS.Text = "ICMS"
        '
        'grpICMSSTRetido
        '
        Me.grpICMSSTRetido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpICMSSTRetido.BackColor = System.Drawing.Color.Transparent
        Me.grpICMSSTRetido.Controls.Add(Me.txtBaseCalculoICMSSTRetido)
        Me.grpICMSSTRetido.Controls.Add(Me.lblBaseCalculoICMSSTRetido)
        Me.grpICMSSTRetido.Controls.Add(Me.txtValorICMSSTRetido)
        Me.grpICMSSTRetido.Controls.Add(Me.lblValorICMSSTRetido)
        Me.grpICMSSTRetido.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpICMSSTRetido.Location = New System.Drawing.Point(8, 213)
        Me.grpICMSSTRetido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpICMSSTRetido.Name = "grpICMSSTRetido"
        Me.grpICMSSTRetido.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpICMSSTRetido.Size = New System.Drawing.Size(933, 67)
        Me.grpICMSSTRetido.TabIndex = 3
        Me.grpICMSSTRetido.Text = "ICMS ST Retido"
        Me.grpICMSSTRetido.VisualStyleManager = Me.vsmMain
        '
        'txtBaseCalculoICMSSTRetido
        '
        Me.txtBaseCalculoICMSSTRetido.Enabled = False
        Me.txtBaseCalculoICMSSTRetido.Location = New System.Drawing.Point(9, 37)
        Me.txtBaseCalculoICMSSTRetido.Name = "txtBaseCalculoICMSSTRetido"
        Me.txtBaseCalculoICMSSTRetido.Size = New System.Drawing.Size(240, 20)
        Me.txtBaseCalculoICMSSTRetido.TabIndex = 1
        Me.txtBaseCalculoICMSSTRetido.Tag = ""
        Me.txtBaseCalculoICMSSTRetido.Text = "0,00"
        Me.txtBaseCalculoICMSSTRetido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblBaseCalculoICMSSTRetido
        '
        Me.lblBaseCalculoICMSSTRetido.AutoSize = True
        Me.lblBaseCalculoICMSSTRetido.Location = New System.Drawing.Point(6, 20)
        Me.lblBaseCalculoICMSSTRetido.Name = "lblBaseCalculoICMSSTRetido"
        Me.lblBaseCalculoICMSSTRetido.Size = New System.Drawing.Size(170, 14)
        Me.lblBaseCalculoICMSSTRetido.TabIndex = 0
        Me.lblBaseCalculoICMSSTRetido.Text = "BC ICMS ST Retido Anteriormente:"
        '
        'txtValorICMSSTRetido
        '
        Me.txtValorICMSSTRetido.Enabled = False
        Me.txtValorICMSSTRetido.Location = New System.Drawing.Point(255, 37)
        Me.txtValorICMSSTRetido.Name = "txtValorICMSSTRetido"
        Me.txtValorICMSSTRetido.Size = New System.Drawing.Size(240, 20)
        Me.txtValorICMSSTRetido.TabIndex = 3
        Me.txtValorICMSSTRetido.Tag = ""
        Me.txtValorICMSSTRetido.Text = "0,00"
        Me.txtValorICMSSTRetido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorICMSSTRetido
        '
        Me.lblValorICMSSTRetido.AutoSize = True
        Me.lblValorICMSSTRetido.Location = New System.Drawing.Point(252, 20)
        Me.lblValorICMSSTRetido.Name = "lblValorICMSSTRetido"
        Me.lblValorICMSSTRetido.Size = New System.Drawing.Size(153, 14)
        Me.lblValorICMSSTRetido.TabIndex = 2
        Me.lblValorICMSSTRetido.Text = "ICMS ST Retido Anteriormente:"
        '
        'grpICMSST
        '
        Me.grpICMSST.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpICMSST.BackColor = System.Drawing.Color.Transparent
        Me.grpICMSST.Controls.Add(Me.cboModalidadeBCICMSST)
        Me.grpICMSST.Controls.Add(Me.lblModalidadeBCICMSST)
        Me.grpICMSST.Controls.Add(Me.txtBaseCalculoICMSST)
        Me.grpICMSST.Controls.Add(Me.lblBaseCalculoICMSST)
        Me.grpICMSST.Controls.Add(Me.txtIVA)
        Me.grpICMSST.Controls.Add(Me.lblIVA)
        Me.grpICMSST.Controls.Add(Me.txtAliquotaICMSST)
        Me.grpICMSST.Controls.Add(Me.lblAliquotaICMSST)
        Me.grpICMSST.Controls.Add(Me.txtPorcentagemReducaoBCICMSST)
        Me.grpICMSST.Controls.Add(Me.lblPorcentagemReducaoBCICMSST)
        Me.grpICMSST.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpICMSST.Location = New System.Drawing.Point(8, 143)
        Me.grpICMSST.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpICMSST.Name = "grpICMSST"
        Me.grpICMSST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpICMSST.Size = New System.Drawing.Size(933, 67)
        Me.grpICMSST.TabIndex = 2
        Me.grpICMSST.Text = "ICMS ST"
        Me.grpICMSST.VisualStyleManager = Me.vsmMain
        '
        'cboModalidadeBCICMSST
        '
        Me.cboModalidadeBCICMSST.AutoSize = False
        Me.cboModalidadeBCICMSST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboModalidadeBCICMSST.Location = New System.Drawing.Point(9, 37)
        Me.cboModalidadeBCICMSST.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboModalidadeBCICMSST.Name = "cboModalidadeBCICMSST"
        Me.cboModalidadeBCICMSST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboModalidadeBCICMSST.Size = New System.Drawing.Size(283, 20)
        Me.cboModalidadeBCICMSST.TabIndex = 1
        Me.cboModalidadeBCICMSST.Tag = ""
        '
        'lblModalidadeBCICMSST
        '
        Me.lblModalidadeBCICMSST.AutoSize = True
        Me.lblModalidadeBCICMSST.Location = New System.Drawing.Point(6, 20)
        Me.lblModalidadeBCICMSST.Name = "lblModalidadeBCICMSST"
        Me.lblModalidadeBCICMSST.Size = New System.Drawing.Size(176, 14)
        Me.lblModalidadeBCICMSST.TabIndex = 0
        Me.lblModalidadeBCICMSST.Text = "Mod. Determinação da BC ICMS ST:"
        '
        'txtBaseCalculoICMSST
        '
        Me.txtBaseCalculoICMSST.Location = New System.Drawing.Point(544, 37)
        Me.txtBaseCalculoICMSST.Name = "txtBaseCalculoICMSST"
        Me.txtBaseCalculoICMSST.Size = New System.Drawing.Size(117, 20)
        Me.txtBaseCalculoICMSST.TabIndex = 7
        Me.txtBaseCalculoICMSST.Tag = ""
        Me.txtBaseCalculoICMSST.Text = "0,00"
        Me.txtBaseCalculoICMSST.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblBaseCalculoICMSST
        '
        Me.lblBaseCalculoICMSST.AutoSize = True
        Me.lblBaseCalculoICMSST.Location = New System.Drawing.Point(541, 20)
        Me.lblBaseCalculoICMSST.Name = "lblBaseCalculoICMSST"
        Me.lblBaseCalculoICMSST.Size = New System.Drawing.Size(66, 14)
        Me.lblBaseCalculoICMSST.TabIndex = 6
        Me.lblBaseCalculoICMSST.Text = "BC ICMS ST:"
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(298, 37)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(117, 20)
        Me.txtIVA.TabIndex = 3
        Me.txtIVA.Tag = ""
        Me.txtIVA.Text = "0,00"
        Me.txtIVA.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Location = New System.Drawing.Point(295, 20)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(27, 14)
        Me.lblIVA.TabIndex = 2
        Me.lblIVA.Text = "IVA:"
        '
        'txtAliquotaICMSST
        '
        Me.txtAliquotaICMSST.Location = New System.Drawing.Point(667, 37)
        Me.txtAliquotaICMSST.Name = "txtAliquotaICMSST"
        Me.txtAliquotaICMSST.Size = New System.Drawing.Size(113, 20)
        Me.txtAliquotaICMSST.TabIndex = 9
        Me.txtAliquotaICMSST.Tag = ""
        Me.txtAliquotaICMSST.Text = "0,00"
        Me.txtAliquotaICMSST.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaICMSST
        '
        Me.lblAliquotaICMSST.AutoSize = True
        Me.lblAliquotaICMSST.Location = New System.Drawing.Point(664, 20)
        Me.lblAliquotaICMSST.Name = "lblAliquotaICMSST"
        Me.lblAliquotaICMSST.Size = New System.Drawing.Size(91, 14)
        Me.lblAliquotaICMSST.TabIndex = 8
        Me.lblAliquotaICMSST.Text = "Alíquota ICMS ST:"
        '
        'txtPorcentagemReducaoBCICMSST
        '
        Me.txtPorcentagemReducaoBCICMSST.Location = New System.Drawing.Point(421, 37)
        Me.txtPorcentagemReducaoBCICMSST.Name = "txtPorcentagemReducaoBCICMSST"
        Me.txtPorcentagemReducaoBCICMSST.Size = New System.Drawing.Size(117, 20)
        Me.txtPorcentagemReducaoBCICMSST.TabIndex = 5
        Me.txtPorcentagemReducaoBCICMSST.Tag = ""
        Me.txtPorcentagemReducaoBCICMSST.Text = "0,00"
        Me.txtPorcentagemReducaoBCICMSST.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPorcentagemReducaoBCICMSST
        '
        Me.lblPorcentagemReducaoBCICMSST.AutoSize = True
        Me.lblPorcentagemReducaoBCICMSST.Location = New System.Drawing.Point(418, 20)
        Me.lblPorcentagemReducaoBCICMSST.Name = "lblPorcentagemReducaoBCICMSST"
        Me.lblPorcentagemReducaoBCICMSST.Size = New System.Drawing.Size(104, 14)
        Me.lblPorcentagemReducaoBCICMSST.TabIndex = 4
        Me.lblPorcentagemReducaoBCICMSST.Text = "% Red. BC ICMS ST:"
        '
        'grpSituacaoTributariaICMS
        '
        Me.grpSituacaoTributariaICMS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSituacaoTributariaICMS.BackColor = System.Drawing.Color.Transparent
        Me.grpSituacaoTributariaICMS.Controls.Add(Me.cboOrigem)
        Me.grpSituacaoTributariaICMS.Controls.Add(Me.lblOrigem)
        Me.grpSituacaoTributariaICMS.Controls.Add(Me.cboSituacaoTributariaICMS)
        Me.grpSituacaoTributariaICMS.Controls.Add(Me.lblSituacaoTributariaICMS)
        Me.grpSituacaoTributariaICMS.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpSituacaoTributariaICMS.Location = New System.Drawing.Point(8, 3)
        Me.grpSituacaoTributariaICMS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSituacaoTributariaICMS.Name = "grpSituacaoTributariaICMS"
        Me.grpSituacaoTributariaICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSituacaoTributariaICMS.Size = New System.Drawing.Size(933, 67)
        Me.grpSituacaoTributariaICMS.TabIndex = 0
        Me.grpSituacaoTributariaICMS.Text = "Situação Tributária do ICMS"
        Me.grpSituacaoTributariaICMS.VisualStyleManager = Me.vsmMain
        '
        'cboOrigem
        '
        Me.cboOrigem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboOrigem.AutoSize = False
        Me.cboOrigem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOrigem.Location = New System.Drawing.Point(421, 37)
        Me.cboOrigem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboOrigem.Name = "cboOrigem"
        Me.cboOrigem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboOrigem.Size = New System.Drawing.Size(503, 20)
        Me.cboOrigem.TabIndex = 3
        '
        'lblOrigem
        '
        Me.lblOrigem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOrigem.AutoSize = True
        Me.lblOrigem.BackColor = System.Drawing.Color.Transparent
        Me.lblOrigem.Location = New System.Drawing.Point(418, 20)
        Me.lblOrigem.Name = "lblOrigem"
        Me.lblOrigem.Size = New System.Drawing.Size(44, 14)
        Me.lblOrigem.TabIndex = 2
        Me.lblOrigem.Text = "Origem:"
        '
        'cboSituacaoTributariaICMS
        '
        Me.cboSituacaoTributariaICMS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSituacaoTributariaICMS.AutoSize = False
        Me.cboSituacaoTributariaICMS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSituacaoTributariaICMS.Location = New System.Drawing.Point(9, 37)
        Me.cboSituacaoTributariaICMS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSituacaoTributariaICMS.Name = "cboSituacaoTributariaICMS"
        Me.cboSituacaoTributariaICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSituacaoTributariaICMS.Size = New System.Drawing.Size(406, 20)
        Me.cboSituacaoTributariaICMS.TabIndex = 1
        '
        'lblSituacaoTributariaICMS
        '
        Me.lblSituacaoTributariaICMS.AutoSize = True
        Me.lblSituacaoTributariaICMS.BackColor = System.Drawing.Color.Transparent
        Me.lblSituacaoTributariaICMS.Location = New System.Drawing.Point(6, 20)
        Me.lblSituacaoTributariaICMS.Name = "lblSituacaoTributariaICMS"
        Me.lblSituacaoTributariaICMS.Size = New System.Drawing.Size(100, 14)
        Me.lblSituacaoTributariaICMS.TabIndex = 0
        Me.lblSituacaoTributariaICMS.Text = "Situação Tributária:"
        '
        'grpICMS
        '
        Me.grpICMS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpICMS.BackColor = System.Drawing.Color.Transparent
        Me.grpICMS.Controls.Add(Me.txtBaseCalculoICMS)
        Me.grpICMS.Controls.Add(Me.lblBaseCalculoICMS)
        Me.grpICMS.Controls.Add(Me.txtValorICMS)
        Me.grpICMS.Controls.Add(Me.lblValorICMS)
        Me.grpICMS.Controls.Add(Me.cboModalidadeBCICMS)
        Me.grpICMS.Controls.Add(Me.lblModalidadeBCICMS)
        Me.grpICMS.Controls.Add(Me.txtAliquotaICMS)
        Me.grpICMS.Controls.Add(Me.lblAliquotaICMS)
        Me.grpICMS.Controls.Add(Me.txtPorcentagemReducaoBCICMS)
        Me.grpICMS.Controls.Add(Me.lblPorcentagemReducaoBCICMS)
        Me.grpICMS.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpICMS.Location = New System.Drawing.Point(8, 73)
        Me.grpICMS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpICMS.Name = "grpICMS"
        Me.grpICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpICMS.Size = New System.Drawing.Size(933, 67)
        Me.grpICMS.TabIndex = 1
        Me.grpICMS.Text = "ICMS"
        Me.grpICMS.VisualStyleManager = Me.vsmMain
        '
        'txtBaseCalculoICMS
        '
        Me.txtBaseCalculoICMS.Location = New System.Drawing.Point(421, 37)
        Me.txtBaseCalculoICMS.Name = "txtBaseCalculoICMS"
        Me.txtBaseCalculoICMS.Size = New System.Drawing.Size(117, 20)
        Me.txtBaseCalculoICMS.TabIndex = 5
        Me.txtBaseCalculoICMS.Tag = ""
        Me.txtBaseCalculoICMS.Text = "0,00"
        Me.txtBaseCalculoICMS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblBaseCalculoICMS
        '
        Me.lblBaseCalculoICMS.AutoSize = True
        Me.lblBaseCalculoICMS.Location = New System.Drawing.Point(418, 20)
        Me.lblBaseCalculoICMS.Name = "lblBaseCalculoICMS"
        Me.lblBaseCalculoICMS.Size = New System.Drawing.Size(51, 14)
        Me.lblBaseCalculoICMS.TabIndex = 4
        Me.lblBaseCalculoICMS.Text = "BC ICMS:"
        '
        'txtValorICMS
        '
        Me.txtValorICMS.Location = New System.Drawing.Point(667, 37)
        Me.txtValorICMS.Name = "txtValorICMS"
        Me.txtValorICMS.Size = New System.Drawing.Size(113, 20)
        Me.txtValorICMS.TabIndex = 9
        Me.txtValorICMS.Tag = ""
        Me.txtValorICMS.Text = "0,00"
        Me.txtValorICMS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorICMS
        '
        Me.lblValorICMS.AutoSize = True
        Me.lblValorICMS.Location = New System.Drawing.Point(664, 20)
        Me.lblValorICMS.Name = "lblValorICMS"
        Me.lblValorICMS.Size = New System.Drawing.Size(62, 14)
        Me.lblValorICMS.TabIndex = 8
        Me.lblValorICMS.Text = "Valor ICMS:"
        '
        'cboModalidadeBCICMS
        '
        Me.cboModalidadeBCICMS.AutoSize = False
        Me.cboModalidadeBCICMS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboModalidadeBCICMS.Location = New System.Drawing.Point(9, 37)
        Me.cboModalidadeBCICMS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboModalidadeBCICMS.Name = "cboModalidadeBCICMS"
        Me.cboModalidadeBCICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboModalidadeBCICMS.Size = New System.Drawing.Size(283, 20)
        Me.cboModalidadeBCICMS.TabIndex = 1
        Me.cboModalidadeBCICMS.Tag = ""
        '
        'lblModalidadeBCICMS
        '
        Me.lblModalidadeBCICMS.AutoSize = True
        Me.lblModalidadeBCICMS.Location = New System.Drawing.Point(6, 20)
        Me.lblModalidadeBCICMS.Name = "lblModalidadeBCICMS"
        Me.lblModalidadeBCICMS.Size = New System.Drawing.Size(161, 14)
        Me.lblModalidadeBCICMS.TabIndex = 0
        Me.lblModalidadeBCICMS.Text = "Mod. Determinação da BC ICMS:"
        '
        'txtAliquotaICMS
        '
        Me.txtAliquotaICMS.Location = New System.Drawing.Point(544, 37)
        Me.txtAliquotaICMS.Name = "txtAliquotaICMS"
        Me.txtAliquotaICMS.Size = New System.Drawing.Size(117, 20)
        Me.txtAliquotaICMS.TabIndex = 7
        Me.txtAliquotaICMS.Tag = ""
        Me.txtAliquotaICMS.Text = "0,00"
        Me.txtAliquotaICMS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaICMS
        '
        Me.lblAliquotaICMS.AutoSize = True
        Me.lblAliquotaICMS.Location = New System.Drawing.Point(541, 20)
        Me.lblAliquotaICMS.Name = "lblAliquotaICMS"
        Me.lblAliquotaICMS.Size = New System.Drawing.Size(76, 14)
        Me.lblAliquotaICMS.TabIndex = 6
        Me.lblAliquotaICMS.Text = "Alíquota ICMS:"
        '
        'txtPorcentagemReducaoBCICMS
        '
        Me.txtPorcentagemReducaoBCICMS.Location = New System.Drawing.Point(298, 37)
        Me.txtPorcentagemReducaoBCICMS.Name = "txtPorcentagemReducaoBCICMS"
        Me.txtPorcentagemReducaoBCICMS.Size = New System.Drawing.Size(117, 20)
        Me.txtPorcentagemReducaoBCICMS.TabIndex = 3
        Me.txtPorcentagemReducaoBCICMS.Tag = ""
        Me.txtPorcentagemReducaoBCICMS.Text = "0,00"
        Me.txtPorcentagemReducaoBCICMS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPorcentagemReducaoBCICMS
        '
        Me.lblPorcentagemReducaoBCICMS.AutoSize = True
        Me.lblPorcentagemReducaoBCICMS.Location = New System.Drawing.Point(295, 20)
        Me.lblPorcentagemReducaoBCICMS.Name = "lblPorcentagemReducaoBCICMS"
        Me.lblPorcentagemReducaoBCICMS.Size = New System.Drawing.Size(89, 14)
        Me.lblPorcentagemReducaoBCICMS.TabIndex = 2
        Me.lblPorcentagemReducaoBCICMS.Text = "% Red. BC ICMS:"
        '
        'pagICMSSimples
        '
        Me.pagICMSSimples.Controls.Add(Me.grpICMSSTRetidoSimples)
        Me.pagICMSSimples.Controls.Add(Me.grpICMSSTSimples)
        Me.pagICMSSimples.Controls.Add(Me.grpICMSSimples)
        Me.pagICMSSimples.Controls.Add(Me.UiGroupBox3)
        Me.pagICMSSimples.Key = "pagICMSSimples"
        Me.pagICMSSimples.Location = New System.Drawing.Point(1, 22)
        Me.pagICMSSimples.Name = "pagICMSSimples"
        Me.pagICMSSimples.Size = New System.Drawing.Size(949, 329)
        Me.pagICMSSimples.TabStop = True
        Me.pagICMSSimples.Text = "ICMS"
        '
        'grpICMSSTRetidoSimples
        '
        Me.grpICMSSTRetidoSimples.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpICMSSTRetidoSimples.BackColor = System.Drawing.Color.Transparent
        Me.grpICMSSTRetidoSimples.Controls.Add(Me.txtBaseCalculoICMSSTRetidoSimples)
        Me.grpICMSSTRetidoSimples.Controls.Add(Me.lblBaseCalculoICMSSTRetidoSimples)
        Me.grpICMSSTRetidoSimples.Controls.Add(Me.txtValorICMSSTRetidoSimples)
        Me.grpICMSSTRetidoSimples.Controls.Add(Me.lblValorICMSSTRetidoSimples)
        Me.grpICMSSTRetidoSimples.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpICMSSTRetidoSimples.Location = New System.Drawing.Point(8, 253)
        Me.grpICMSSTRetidoSimples.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpICMSSTRetidoSimples.Name = "grpICMSSTRetidoSimples"
        Me.grpICMSSTRetidoSimples.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpICMSSTRetidoSimples.Size = New System.Drawing.Size(933, 67)
        Me.grpICMSSTRetidoSimples.TabIndex = 3
        Me.grpICMSSTRetidoSimples.Text = "ICMS ST Retido"
        Me.grpICMSSTRetidoSimples.VisualStyleManager = Me.vsmMain
        '
        'txtBaseCalculoICMSSTRetidoSimples
        '
        Me.txtBaseCalculoICMSSTRetidoSimples.Enabled = False
        Me.txtBaseCalculoICMSSTRetidoSimples.Location = New System.Drawing.Point(9, 37)
        Me.txtBaseCalculoICMSSTRetidoSimples.Name = "txtBaseCalculoICMSSTRetidoSimples"
        Me.txtBaseCalculoICMSSTRetidoSimples.Size = New System.Drawing.Size(240, 20)
        Me.txtBaseCalculoICMSSTRetidoSimples.TabIndex = 1
        Me.txtBaseCalculoICMSSTRetidoSimples.Tag = ""
        Me.txtBaseCalculoICMSSTRetidoSimples.Text = "0,00"
        Me.txtBaseCalculoICMSSTRetidoSimples.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblBaseCalculoICMSSTRetidoSimples
        '
        Me.lblBaseCalculoICMSSTRetidoSimples.AutoSize = True
        Me.lblBaseCalculoICMSSTRetidoSimples.Location = New System.Drawing.Point(6, 20)
        Me.lblBaseCalculoICMSSTRetidoSimples.Name = "lblBaseCalculoICMSSTRetidoSimples"
        Me.lblBaseCalculoICMSSTRetidoSimples.Size = New System.Drawing.Size(170, 14)
        Me.lblBaseCalculoICMSSTRetidoSimples.TabIndex = 0
        Me.lblBaseCalculoICMSSTRetidoSimples.Text = "BC ICMS ST Retido Anteriormente:"
        '
        'txtValorICMSSTRetidoSimples
        '
        Me.txtValorICMSSTRetidoSimples.Enabled = False
        Me.txtValorICMSSTRetidoSimples.Location = New System.Drawing.Point(255, 37)
        Me.txtValorICMSSTRetidoSimples.Name = "txtValorICMSSTRetidoSimples"
        Me.txtValorICMSSTRetidoSimples.Size = New System.Drawing.Size(240, 20)
        Me.txtValorICMSSTRetidoSimples.TabIndex = 3
        Me.txtValorICMSSTRetidoSimples.Tag = ""
        Me.txtValorICMSSTRetidoSimples.Text = "0,00"
        Me.txtValorICMSSTRetidoSimples.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorICMSSTRetidoSimples
        '
        Me.lblValorICMSSTRetidoSimples.AutoSize = True
        Me.lblValorICMSSTRetidoSimples.Location = New System.Drawing.Point(252, 20)
        Me.lblValorICMSSTRetidoSimples.Name = "lblValorICMSSTRetidoSimples"
        Me.lblValorICMSSTRetidoSimples.Size = New System.Drawing.Size(153, 14)
        Me.lblValorICMSSTRetidoSimples.TabIndex = 2
        Me.lblValorICMSSTRetidoSimples.Text = "ICMS ST Retido Anteriormente:"
        '
        'grpICMSSTSimples
        '
        Me.grpICMSSTSimples.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpICMSSTSimples.BackColor = System.Drawing.Color.Transparent
        Me.grpICMSSTSimples.Controls.Add(Me.cboModalidadeBCICMSSTSimples)
        Me.grpICMSSTSimples.Controls.Add(Me.lblModalidadeBCICMSSTSimples)
        Me.grpICMSSTSimples.Controls.Add(Me.txtBaseCalculoICMSSTSimples)
        Me.grpICMSSTSimples.Controls.Add(Me.lblBaseCalculoICMSSTSimples)
        Me.grpICMSSTSimples.Controls.Add(Me.txtIVASimples)
        Me.grpICMSSTSimples.Controls.Add(Me.lblIVASimples)
        Me.grpICMSSTSimples.Controls.Add(Me.txtAliquotaICMSSTSimples)
        Me.grpICMSSTSimples.Controls.Add(Me.lblAliquotaICMSSTSimples)
        Me.grpICMSSTSimples.Controls.Add(Me.txtPorcentagemReducaoBCICMSSTSimples)
        Me.grpICMSSTSimples.Controls.Add(Me.lblPorcentagemReducaoBCICMSSTSimples)
        Me.grpICMSSTSimples.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpICMSSTSimples.Location = New System.Drawing.Point(8, 183)
        Me.grpICMSSTSimples.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpICMSSTSimples.Name = "grpICMSSTSimples"
        Me.grpICMSSTSimples.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpICMSSTSimples.Size = New System.Drawing.Size(933, 67)
        Me.grpICMSSTSimples.TabIndex = 2
        Me.grpICMSSTSimples.Text = "ICMS ST"
        Me.grpICMSSTSimples.VisualStyleManager = Me.vsmMain
        '
        'cboModalidadeBCICMSSTSimples
        '
        Me.cboModalidadeBCICMSSTSimples.AutoSize = False
        Me.cboModalidadeBCICMSSTSimples.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboModalidadeBCICMSSTSimples.Enabled = False
        Me.cboModalidadeBCICMSSTSimples.Location = New System.Drawing.Point(9, 37)
        Me.cboModalidadeBCICMSSTSimples.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboModalidadeBCICMSSTSimples.Name = "cboModalidadeBCICMSSTSimples"
        Me.cboModalidadeBCICMSSTSimples.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboModalidadeBCICMSSTSimples.Size = New System.Drawing.Size(283, 20)
        Me.cboModalidadeBCICMSSTSimples.TabIndex = 1
        Me.cboModalidadeBCICMSSTSimples.Tag = ""
        '
        'lblModalidadeBCICMSSTSimples
        '
        Me.lblModalidadeBCICMSSTSimples.AutoSize = True
        Me.lblModalidadeBCICMSSTSimples.Location = New System.Drawing.Point(6, 20)
        Me.lblModalidadeBCICMSSTSimples.Name = "lblModalidadeBCICMSSTSimples"
        Me.lblModalidadeBCICMSSTSimples.Size = New System.Drawing.Size(176, 14)
        Me.lblModalidadeBCICMSSTSimples.TabIndex = 0
        Me.lblModalidadeBCICMSSTSimples.Text = "Mod. Determinação da BC ICMS ST:"
        '
        'txtBaseCalculoICMSSTSimples
        '
        Me.txtBaseCalculoICMSSTSimples.Enabled = False
        Me.txtBaseCalculoICMSSTSimples.Location = New System.Drawing.Point(544, 37)
        Me.txtBaseCalculoICMSSTSimples.Name = "txtBaseCalculoICMSSTSimples"
        Me.txtBaseCalculoICMSSTSimples.Size = New System.Drawing.Size(117, 20)
        Me.txtBaseCalculoICMSSTSimples.TabIndex = 7
        Me.txtBaseCalculoICMSSTSimples.Tag = ""
        Me.txtBaseCalculoICMSSTSimples.Text = "0,00"
        Me.txtBaseCalculoICMSSTSimples.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblBaseCalculoICMSSTSimples
        '
        Me.lblBaseCalculoICMSSTSimples.AutoSize = True
        Me.lblBaseCalculoICMSSTSimples.Location = New System.Drawing.Point(541, 20)
        Me.lblBaseCalculoICMSSTSimples.Name = "lblBaseCalculoICMSSTSimples"
        Me.lblBaseCalculoICMSSTSimples.Size = New System.Drawing.Size(66, 14)
        Me.lblBaseCalculoICMSSTSimples.TabIndex = 6
        Me.lblBaseCalculoICMSSTSimples.Text = "BC ICMS ST:"
        '
        'txtIVASimples
        '
        Me.txtIVASimples.Enabled = False
        Me.txtIVASimples.Location = New System.Drawing.Point(298, 37)
        Me.txtIVASimples.Name = "txtIVASimples"
        Me.txtIVASimples.Size = New System.Drawing.Size(117, 20)
        Me.txtIVASimples.TabIndex = 3
        Me.txtIVASimples.Tag = ""
        Me.txtIVASimples.Text = "0,00"
        Me.txtIVASimples.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblIVASimples
        '
        Me.lblIVASimples.AutoSize = True
        Me.lblIVASimples.Location = New System.Drawing.Point(295, 20)
        Me.lblIVASimples.Name = "lblIVASimples"
        Me.lblIVASimples.Size = New System.Drawing.Size(27, 14)
        Me.lblIVASimples.TabIndex = 2
        Me.lblIVASimples.Text = "IVA:"
        '
        'txtAliquotaICMSSTSimples
        '
        Me.txtAliquotaICMSSTSimples.Enabled = False
        Me.txtAliquotaICMSSTSimples.Location = New System.Drawing.Point(667, 37)
        Me.txtAliquotaICMSSTSimples.Name = "txtAliquotaICMSSTSimples"
        Me.txtAliquotaICMSSTSimples.Size = New System.Drawing.Size(113, 20)
        Me.txtAliquotaICMSSTSimples.TabIndex = 9
        Me.txtAliquotaICMSSTSimples.Tag = ""
        Me.txtAliquotaICMSSTSimples.Text = "0,00"
        Me.txtAliquotaICMSSTSimples.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaICMSSTSimples
        '
        Me.lblAliquotaICMSSTSimples.AutoSize = True
        Me.lblAliquotaICMSSTSimples.Location = New System.Drawing.Point(664, 20)
        Me.lblAliquotaICMSSTSimples.Name = "lblAliquotaICMSSTSimples"
        Me.lblAliquotaICMSSTSimples.Size = New System.Drawing.Size(91, 14)
        Me.lblAliquotaICMSSTSimples.TabIndex = 8
        Me.lblAliquotaICMSSTSimples.Text = "Alíquota ICMS ST:"
        '
        'txtPorcentagemReducaoBCICMSSTSimples
        '
        Me.txtPorcentagemReducaoBCICMSSTSimples.Enabled = False
        Me.txtPorcentagemReducaoBCICMSSTSimples.Location = New System.Drawing.Point(421, 37)
        Me.txtPorcentagemReducaoBCICMSSTSimples.Name = "txtPorcentagemReducaoBCICMSSTSimples"
        Me.txtPorcentagemReducaoBCICMSSTSimples.Size = New System.Drawing.Size(117, 20)
        Me.txtPorcentagemReducaoBCICMSSTSimples.TabIndex = 5
        Me.txtPorcentagemReducaoBCICMSSTSimples.Tag = ""
        Me.txtPorcentagemReducaoBCICMSSTSimples.Text = "0,00"
        Me.txtPorcentagemReducaoBCICMSSTSimples.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPorcentagemReducaoBCICMSSTSimples
        '
        Me.lblPorcentagemReducaoBCICMSSTSimples.AutoSize = True
        Me.lblPorcentagemReducaoBCICMSSTSimples.Location = New System.Drawing.Point(418, 20)
        Me.lblPorcentagemReducaoBCICMSSTSimples.Name = "lblPorcentagemReducaoBCICMSSTSimples"
        Me.lblPorcentagemReducaoBCICMSSTSimples.Size = New System.Drawing.Size(104, 14)
        Me.lblPorcentagemReducaoBCICMSSTSimples.TabIndex = 4
        Me.lblPorcentagemReducaoBCICMSSTSimples.Text = "% Red. BC ICMS ST:"
        '
        'grpICMSSimples
        '
        Me.grpICMSSimples.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpICMSSimples.BackColor = System.Drawing.Color.Transparent
        Me.grpICMSSimples.Controls.Add(Me.txtValorICMSSimples)
        Me.grpICMSSimples.Controls.Add(Me.lblValorICMSSimples)
        Me.grpICMSSimples.Controls.Add(Me.cboModalidadeBCICMSSimples)
        Me.grpICMSSimples.Controls.Add(Me.lblModalidadeBCICMSSimples)
        Me.grpICMSSimples.Controls.Add(Me.txtAliquotaICMSSimples)
        Me.grpICMSSimples.Controls.Add(Me.lblAliquotaICMSSimples)
        Me.grpICMSSimples.Controls.Add(Me.txtPorcentagemReducaoBCICMSSimples)
        Me.grpICMSSimples.Controls.Add(Me.lblPorcentagemReducaoBCICMSSimples)
        Me.grpICMSSimples.Controls.Add(Me.txtBaseCalculoICMSSimples)
        Me.grpICMSSimples.Controls.Add(Me.lblBaseCalculoICMSSimples)
        Me.grpICMSSimples.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpICMSSimples.Location = New System.Drawing.Point(8, 113)
        Me.grpICMSSimples.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpICMSSimples.Name = "grpICMSSimples"
        Me.grpICMSSimples.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpICMSSimples.Size = New System.Drawing.Size(933, 67)
        Me.grpICMSSimples.TabIndex = 1
        Me.grpICMSSimples.Text = "ICMS"
        Me.grpICMSSimples.VisualStyleManager = Me.vsmMain
        '
        'txtValorICMSSimples
        '
        Me.txtValorICMSSimples.Enabled = False
        Me.txtValorICMSSimples.Location = New System.Drawing.Point(667, 37)
        Me.txtValorICMSSimples.Name = "txtValorICMSSimples"
        Me.txtValorICMSSimples.Size = New System.Drawing.Size(113, 20)
        Me.txtValorICMSSimples.TabIndex = 9
        Me.txtValorICMSSimples.Tag = ""
        Me.txtValorICMSSimples.Text = "0,00"
        Me.txtValorICMSSimples.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorICMSSimples
        '
        Me.lblValorICMSSimples.AutoSize = True
        Me.lblValorICMSSimples.Location = New System.Drawing.Point(664, 20)
        Me.lblValorICMSSimples.Name = "lblValorICMSSimples"
        Me.lblValorICMSSimples.Size = New System.Drawing.Size(77, 14)
        Me.lblValorICMSSimples.TabIndex = 8
        Me.lblValorICMSSimples.Text = "Valor do ICMS:"
        '
        'cboModalidadeBCICMSSimples
        '
        Me.cboModalidadeBCICMSSimples.AutoSize = False
        Me.cboModalidadeBCICMSSimples.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboModalidadeBCICMSSimples.Enabled = False
        Me.cboModalidadeBCICMSSimples.Location = New System.Drawing.Point(9, 37)
        Me.cboModalidadeBCICMSSimples.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboModalidadeBCICMSSimples.Name = "cboModalidadeBCICMSSimples"
        Me.cboModalidadeBCICMSSimples.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboModalidadeBCICMSSimples.Size = New System.Drawing.Size(283, 20)
        Me.cboModalidadeBCICMSSimples.TabIndex = 1
        Me.cboModalidadeBCICMSSimples.Tag = ""
        '
        'lblModalidadeBCICMSSimples
        '
        Me.lblModalidadeBCICMSSimples.AutoSize = True
        Me.lblModalidadeBCICMSSimples.Location = New System.Drawing.Point(6, 20)
        Me.lblModalidadeBCICMSSimples.Name = "lblModalidadeBCICMSSimples"
        Me.lblModalidadeBCICMSSimples.Size = New System.Drawing.Size(161, 14)
        Me.lblModalidadeBCICMSSimples.TabIndex = 0
        Me.lblModalidadeBCICMSSimples.Text = "Mod. Determinação da BC ICMS:"
        '
        'txtAliquotaICMSSimples
        '
        Me.txtAliquotaICMSSimples.Enabled = False
        Me.txtAliquotaICMSSimples.Location = New System.Drawing.Point(544, 37)
        Me.txtAliquotaICMSSimples.Name = "txtAliquotaICMSSimples"
        Me.txtAliquotaICMSSimples.Size = New System.Drawing.Size(117, 20)
        Me.txtAliquotaICMSSimples.TabIndex = 7
        Me.txtAliquotaICMSSimples.Tag = ""
        Me.txtAliquotaICMSSimples.Text = "0,00"
        Me.txtAliquotaICMSSimples.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaICMSSimples
        '
        Me.lblAliquotaICMSSimples.AutoSize = True
        Me.lblAliquotaICMSSimples.Location = New System.Drawing.Point(541, 20)
        Me.lblAliquotaICMSSimples.Name = "lblAliquotaICMSSimples"
        Me.lblAliquotaICMSSimples.Size = New System.Drawing.Size(76, 14)
        Me.lblAliquotaICMSSimples.TabIndex = 6
        Me.lblAliquotaICMSSimples.Text = "Alíquota ICMS:"
        '
        'txtPorcentagemReducaoBCICMSSimples
        '
        Me.txtPorcentagemReducaoBCICMSSimples.Enabled = False
        Me.txtPorcentagemReducaoBCICMSSimples.Location = New System.Drawing.Point(298, 37)
        Me.txtPorcentagemReducaoBCICMSSimples.Name = "txtPorcentagemReducaoBCICMSSimples"
        Me.txtPorcentagemReducaoBCICMSSimples.Size = New System.Drawing.Size(117, 20)
        Me.txtPorcentagemReducaoBCICMSSimples.TabIndex = 3
        Me.txtPorcentagemReducaoBCICMSSimples.Tag = ""
        Me.txtPorcentagemReducaoBCICMSSimples.Text = "0,00"
        Me.txtPorcentagemReducaoBCICMSSimples.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPorcentagemReducaoBCICMSSimples
        '
        Me.lblPorcentagemReducaoBCICMSSimples.AutoSize = True
        Me.lblPorcentagemReducaoBCICMSSimples.Location = New System.Drawing.Point(295, 20)
        Me.lblPorcentagemReducaoBCICMSSimples.Name = "lblPorcentagemReducaoBCICMSSimples"
        Me.lblPorcentagemReducaoBCICMSSimples.Size = New System.Drawing.Size(89, 14)
        Me.lblPorcentagemReducaoBCICMSSimples.TabIndex = 2
        Me.lblPorcentagemReducaoBCICMSSimples.Text = "% Red. BC ICMS:"
        '
        'txtBaseCalculoICMSSimples
        '
        Me.txtBaseCalculoICMSSimples.Location = New System.Drawing.Point(421, 37)
        Me.txtBaseCalculoICMSSimples.Name = "txtBaseCalculoICMSSimples"
        Me.txtBaseCalculoICMSSimples.Size = New System.Drawing.Size(117, 20)
        Me.txtBaseCalculoICMSSimples.TabIndex = 5
        Me.txtBaseCalculoICMSSimples.Tag = ""
        Me.txtBaseCalculoICMSSimples.Text = "0,00"
        Me.txtBaseCalculoICMSSimples.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblBaseCalculoICMSSimples
        '
        Me.lblBaseCalculoICMSSimples.AutoSize = True
        Me.lblBaseCalculoICMSSimples.Location = New System.Drawing.Point(418, 20)
        Me.lblBaseCalculoICMSSimples.Name = "lblBaseCalculoICMSSimples"
        Me.lblBaseCalculoICMSSimples.Size = New System.Drawing.Size(51, 14)
        Me.lblBaseCalculoICMSSimples.TabIndex = 4
        Me.lblBaseCalculoICMSSimples.Text = "BC ICMS:"
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox3.Controls.Add(Me.txtCreditoICMSAproveitadoSimples)
        Me.UiGroupBox3.Controls.Add(Me.lblCreditoICMSAproveitadoSimples)
        Me.UiGroupBox3.Controls.Add(Me.txtAliquotaCalculoCreditoICMSSimples)
        Me.UiGroupBox3.Controls.Add(Me.lblAliquotaCalculoCreditoICMSSimples)
        Me.UiGroupBox3.Controls.Add(Me.cboOrigemSimples)
        Me.UiGroupBox3.Controls.Add(Me.lblOrigemSimples)
        Me.UiGroupBox3.Controls.Add(Me.cboSituacaoTributariaICMSSimples)
        Me.UiGroupBox3.Controls.Add(Me.lblSituacaoTributariaICMSSimples)
        Me.UiGroupBox3.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox3.Location = New System.Drawing.Point(8, 3)
        Me.UiGroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox3.Size = New System.Drawing.Size(933, 107)
        Me.UiGroupBox3.TabIndex = 0
        Me.UiGroupBox3.Text = "Situação Tributária do ICMS"
        Me.UiGroupBox3.VisualStyleManager = Me.vsmMain
        '
        'txtCreditoICMSAproveitadoSimples
        '
        Me.txtCreditoICMSAproveitadoSimples.Enabled = False
        Me.txtCreditoICMSAproveitadoSimples.Location = New System.Drawing.Point(255, 77)
        Me.txtCreditoICMSAproveitadoSimples.Name = "txtCreditoICMSAproveitadoSimples"
        Me.txtCreditoICMSAproveitadoSimples.Size = New System.Drawing.Size(240, 20)
        Me.txtCreditoICMSAproveitadoSimples.TabIndex = 7
        Me.txtCreditoICMSAproveitadoSimples.Tag = ""
        Me.txtCreditoICMSAproveitadoSimples.Text = "0,00"
        Me.txtCreditoICMSAproveitadoSimples.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblCreditoICMSAproveitadoSimples
        '
        Me.lblCreditoICMSAproveitadoSimples.AutoSize = True
        Me.lblCreditoICMSAproveitadoSimples.Location = New System.Drawing.Point(252, 60)
        Me.lblCreditoICMSAproveitadoSimples.Name = "lblCreditoICMSAproveitadoSimples"
        Me.lblCreditoICMSAproveitadoSimples.Size = New System.Drawing.Size(214, 14)
        Me.lblCreditoICMSAproveitadoSimples.TabIndex = 6
        Me.lblCreditoICMSAproveitadoSimples.Text = "Crédito do ICMS que pode ser Aproveitado:"
        '
        'txtAliquotaCalculoCreditoICMSSimples
        '
        Me.txtAliquotaCalculoCreditoICMSSimples.Enabled = False
        Me.txtAliquotaCalculoCreditoICMSSimples.Location = New System.Drawing.Point(9, 77)
        Me.txtAliquotaCalculoCreditoICMSSimples.Name = "txtAliquotaCalculoCreditoICMSSimples"
        Me.txtAliquotaCalculoCreditoICMSSimples.Size = New System.Drawing.Size(240, 20)
        Me.txtAliquotaCalculoCreditoICMSSimples.TabIndex = 5
        Me.txtAliquotaCalculoCreditoICMSSimples.Tag = ""
        Me.txtAliquotaCalculoCreditoICMSSimples.Text = "0,00"
        Me.txtAliquotaCalculoCreditoICMSSimples.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaCalculoCreditoICMSSimples
        '
        Me.lblAliquotaCalculoCreditoICMSSimples.AutoSize = True
        Me.lblAliquotaCalculoCreditoICMSSimples.Location = New System.Drawing.Point(6, 60)
        Me.lblAliquotaCalculoCreditoICMSSimples.Name = "lblAliquotaCalculoCreditoICMSSimples"
        Me.lblAliquotaCalculoCreditoICMSSimples.Size = New System.Drawing.Size(200, 14)
        Me.lblAliquotaCalculoCreditoICMSSimples.TabIndex = 4
        Me.lblAliquotaCalculoCreditoICMSSimples.Text = "Alíquota Aplicável de Cálculo do Crédito:"
        '
        'cboOrigemSimples
        '
        Me.cboOrigemSimples.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboOrigemSimples.AutoSize = False
        Me.cboOrigemSimples.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOrigemSimples.Location = New System.Drawing.Point(421, 37)
        Me.cboOrigemSimples.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboOrigemSimples.Name = "cboOrigemSimples"
        Me.cboOrigemSimples.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboOrigemSimples.Size = New System.Drawing.Size(503, 20)
        Me.cboOrigemSimples.TabIndex = 3
        '
        'lblOrigemSimples
        '
        Me.lblOrigemSimples.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOrigemSimples.AutoSize = True
        Me.lblOrigemSimples.BackColor = System.Drawing.Color.Transparent
        Me.lblOrigemSimples.Location = New System.Drawing.Point(418, 20)
        Me.lblOrigemSimples.Name = "lblOrigemSimples"
        Me.lblOrigemSimples.Size = New System.Drawing.Size(44, 14)
        Me.lblOrigemSimples.TabIndex = 2
        Me.lblOrigemSimples.Text = "Origem:"
        '
        'cboSituacaoTributariaICMSSimples
        '
        Me.cboSituacaoTributariaICMSSimples.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSituacaoTributariaICMSSimples.AutoSize = False
        Me.cboSituacaoTributariaICMSSimples.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSituacaoTributariaICMSSimples.Location = New System.Drawing.Point(9, 37)
        Me.cboSituacaoTributariaICMSSimples.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSituacaoTributariaICMSSimples.Name = "cboSituacaoTributariaICMSSimples"
        Me.cboSituacaoTributariaICMSSimples.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSituacaoTributariaICMSSimples.Size = New System.Drawing.Size(406, 20)
        Me.cboSituacaoTributariaICMSSimples.TabIndex = 1
        '
        'lblSituacaoTributariaICMSSimples
        '
        Me.lblSituacaoTributariaICMSSimples.AutoSize = True
        Me.lblSituacaoTributariaICMSSimples.BackColor = System.Drawing.Color.Transparent
        Me.lblSituacaoTributariaICMSSimples.Location = New System.Drawing.Point(6, 20)
        Me.lblSituacaoTributariaICMSSimples.Name = "lblSituacaoTributariaICMSSimples"
        Me.lblSituacaoTributariaICMSSimples.Size = New System.Drawing.Size(100, 14)
        Me.lblSituacaoTributariaICMSSimples.TabIndex = 0
        Me.lblSituacaoTributariaICMSSimples.Text = "Situação Tributária:"
        '
        'pagIPI
        '
        Me.pagIPI.Controls.Add(Me.grpValoresIPI)
        Me.pagIPI.Controls.Add(Me.grpSituacaoTributariaIPI)
        Me.pagIPI.Key = "pagIPI"
        Me.pagIPI.Location = New System.Drawing.Point(1, 22)
        Me.pagIPI.Name = "pagIPI"
        Me.pagIPI.Size = New System.Drawing.Size(949, 329)
        Me.pagIPI.TabStop = True
        Me.pagIPI.Text = "IPI"
        '
        'grpValoresIPI
        '
        Me.grpValoresIPI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpValoresIPI.BackColor = System.Drawing.Color.Transparent
        Me.grpValoresIPI.Controls.Add(Me.txtValorUnidadeIPI)
        Me.grpValoresIPI.Controls.Add(Me.lblValorUnidadeIPI)
        Me.grpValoresIPI.Controls.Add(Me.txtQuantidadeIPI)
        Me.grpValoresIPI.Controls.Add(Me.lblQuantidadeIPI)
        Me.grpValoresIPI.Controls.Add(Me.cboTipoCalculoIPI)
        Me.grpValoresIPI.Controls.Add(Me.lblTipoCalculoIPI)
        Me.grpValoresIPI.Controls.Add(Me.txtValorIPI)
        Me.grpValoresIPI.Controls.Add(Me.lblValorIPI)
        Me.grpValoresIPI.Controls.Add(Me.txtBaseCalculoIPI)
        Me.grpValoresIPI.Controls.Add(Me.lblBaseCalculoIPI)
        Me.grpValoresIPI.Controls.Add(Me.txtAliquotaIPI)
        Me.grpValoresIPI.Controls.Add(Me.lblAliquotaIPI)
        Me.grpValoresIPI.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpValoresIPI.Location = New System.Drawing.Point(8, 73)
        Me.grpValoresIPI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpValoresIPI.Name = "grpValoresIPI"
        Me.grpValoresIPI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpValoresIPI.Size = New System.Drawing.Size(933, 67)
        Me.grpValoresIPI.TabIndex = 1
        Me.grpValoresIPI.Text = "Valores"
        Me.grpValoresIPI.VisualStyleManager = Me.vsmMain
        '
        'txtValorUnidadeIPI
        '
        Me.txtValorUnidadeIPI.DecimalDigits = 4
        Me.txtValorUnidadeIPI.Enabled = False
        Me.txtValorUnidadeIPI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorUnidadeIPI.Location = New System.Drawing.Point(538, 37)
        Me.txtValorUnidadeIPI.Name = "txtValorUnidadeIPI"
        Me.txtValorUnidadeIPI.Size = New System.Drawing.Size(114, 20)
        Me.txtValorUnidadeIPI.TabIndex = 9
        Me.txtValorUnidadeIPI.Text = "0,0000"
        Me.txtValorUnidadeIPI.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblValorUnidadeIPI
        '
        Me.lblValorUnidadeIPI.AutoSize = True
        Me.lblValorUnidadeIPI.Location = New System.Drawing.Point(535, 20)
        Me.lblValorUnidadeIPI.Name = "lblValorUnidadeIPI"
        Me.lblValorUnidadeIPI.Size = New System.Drawing.Size(96, 14)
        Me.lblValorUnidadeIPI.TabIndex = 8
        Me.lblValorUnidadeIPI.Text = "Valor por Unidade:"
        '
        'txtQuantidadeIPI
        '
        Me.txtQuantidadeIPI.DecimalDigits = 4
        Me.txtQuantidadeIPI.Enabled = False
        Me.txtQuantidadeIPI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidadeIPI.Location = New System.Drawing.Point(418, 37)
        Me.txtQuantidadeIPI.Name = "txtQuantidadeIPI"
        Me.txtQuantidadeIPI.Size = New System.Drawing.Size(114, 20)
        Me.txtQuantidadeIPI.TabIndex = 7
        Me.txtQuantidadeIPI.Text = "0,0000"
        Me.txtQuantidadeIPI.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeIPI
        '
        Me.lblQuantidadeIPI.AutoSize = True
        Me.lblQuantidadeIPI.Location = New System.Drawing.Point(415, 20)
        Me.lblQuantidadeIPI.Name = "lblQuantidadeIPI"
        Me.lblQuantidadeIPI.Size = New System.Drawing.Size(61, 14)
        Me.lblQuantidadeIPI.TabIndex = 6
        Me.lblQuantidadeIPI.Text = "Qtde. Total:"
        '
        'cboTipoCalculoIPI
        '
        Me.cboTipoCalculoIPI.AutoSize = False
        Me.cboTipoCalculoIPI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoCalculoIPI.Location = New System.Drawing.Point(9, 37)
        Me.cboTipoCalculoIPI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoCalculoIPI.Name = "cboTipoCalculoIPI"
        Me.cboTipoCalculoIPI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoCalculoIPI.Size = New System.Drawing.Size(160, 20)
        Me.cboTipoCalculoIPI.TabIndex = 1
        '
        'lblTipoCalculoIPI
        '
        Me.lblTipoCalculoIPI.AutoSize = True
        Me.lblTipoCalculoIPI.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoCalculoIPI.Location = New System.Drawing.Point(6, 20)
        Me.lblTipoCalculoIPI.Name = "lblTipoCalculoIPI"
        Me.lblTipoCalculoIPI.Size = New System.Drawing.Size(83, 14)
        Me.lblTipoCalculoIPI.TabIndex = 0
        Me.lblTipoCalculoIPI.Text = "Tipo de Cálculo:"
        '
        'txtValorIPI
        '
        Me.txtValorIPI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorIPI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorIPI.Location = New System.Drawing.Point(658, 37)
        Me.txtValorIPI.Name = "txtValorIPI"
        Me.txtValorIPI.ReadOnly = True
        Me.txtValorIPI.Size = New System.Drawing.Size(122, 20)
        Me.txtValorIPI.TabIndex = 11
        Me.txtValorIPI.TabStop = False
        Me.txtValorIPI.Text = "0,00"
        Me.txtValorIPI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorIPI
        '
        Me.lblValorIPI.AutoSize = True
        Me.lblValorIPI.Location = New System.Drawing.Point(655, 20)
        Me.lblValorIPI.Name = "lblValorIPI"
        Me.lblValorIPI.Size = New System.Drawing.Size(63, 14)
        Me.lblValorIPI.TabIndex = 10
        Me.lblValorIPI.Text = "Valor do IPI:"
        '
        'txtBaseCalculoIPI
        '
        Me.txtBaseCalculoIPI.Enabled = False
        Me.txtBaseCalculoIPI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseCalculoIPI.Location = New System.Drawing.Point(175, 37)
        Me.txtBaseCalculoIPI.Name = "txtBaseCalculoIPI"
        Me.txtBaseCalculoIPI.Size = New System.Drawing.Size(117, 20)
        Me.txtBaseCalculoIPI.TabIndex = 3
        Me.txtBaseCalculoIPI.Text = "0,00"
        Me.txtBaseCalculoIPI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblBaseCalculoIPI
        '
        Me.lblBaseCalculoIPI.AutoSize = True
        Me.lblBaseCalculoIPI.Location = New System.Drawing.Point(172, 20)
        Me.lblBaseCalculoIPI.Name = "lblBaseCalculoIPI"
        Me.lblBaseCalculoIPI.Size = New System.Drawing.Size(85, 14)
        Me.lblBaseCalculoIPI.TabIndex = 2
        Me.lblBaseCalculoIPI.Text = "Base de Cálculo"
        '
        'txtAliquotaIPI
        '
        Me.txtAliquotaIPI.Enabled = False
        Me.txtAliquotaIPI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAliquotaIPI.Location = New System.Drawing.Point(298, 37)
        Me.txtAliquotaIPI.Name = "txtAliquotaIPI"
        Me.txtAliquotaIPI.Size = New System.Drawing.Size(114, 20)
        Me.txtAliquotaIPI.TabIndex = 5
        Me.txtAliquotaIPI.Text = "0,00"
        Me.txtAliquotaIPI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaIPI
        '
        Me.lblAliquotaIPI.AutoSize = True
        Me.lblAliquotaIPI.Location = New System.Drawing.Point(295, 20)
        Me.lblAliquotaIPI.Name = "lblAliquotaIPI"
        Me.lblAliquotaIPI.Size = New System.Drawing.Size(70, 14)
        Me.lblAliquotaIPI.TabIndex = 4
        Me.lblAliquotaIPI.Text = "Alíquota (%):"
        '
        'grpSituacaoTributariaIPI
        '
        Me.grpSituacaoTributariaIPI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSituacaoTributariaIPI.BackColor = System.Drawing.Color.Transparent
        Me.grpSituacaoTributariaIPI.Controls.Add(Me.cboSituacaoTributariaIPI)
        Me.grpSituacaoTributariaIPI.Controls.Add(Me.lblSituacaoTributariaIPI)
        Me.grpSituacaoTributariaIPI.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpSituacaoTributariaIPI.Location = New System.Drawing.Point(8, 3)
        Me.grpSituacaoTributariaIPI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSituacaoTributariaIPI.Name = "grpSituacaoTributariaIPI"
        Me.grpSituacaoTributariaIPI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSituacaoTributariaIPI.Size = New System.Drawing.Size(933, 67)
        Me.grpSituacaoTributariaIPI.TabIndex = 0
        Me.grpSituacaoTributariaIPI.Text = "Situação Tributária do IPI"
        Me.grpSituacaoTributariaIPI.VisualStyleManager = Me.vsmMain
        '
        'cboSituacaoTributariaIPI
        '
        Me.cboSituacaoTributariaIPI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSituacaoTributariaIPI.AutoSize = False
        Me.cboSituacaoTributariaIPI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSituacaoTributariaIPI.Location = New System.Drawing.Point(9, 37)
        Me.cboSituacaoTributariaIPI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSituacaoTributariaIPI.Name = "cboSituacaoTributariaIPI"
        Me.cboSituacaoTributariaIPI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSituacaoTributariaIPI.Size = New System.Drawing.Size(915, 20)
        Me.cboSituacaoTributariaIPI.TabIndex = 1
        '
        'lblSituacaoTributariaIPI
        '
        Me.lblSituacaoTributariaIPI.AutoSize = True
        Me.lblSituacaoTributariaIPI.BackColor = System.Drawing.Color.Transparent
        Me.lblSituacaoTributariaIPI.Location = New System.Drawing.Point(6, 20)
        Me.lblSituacaoTributariaIPI.Name = "lblSituacaoTributariaIPI"
        Me.lblSituacaoTributariaIPI.Size = New System.Drawing.Size(100, 14)
        Me.lblSituacaoTributariaIPI.TabIndex = 0
        Me.lblSituacaoTributariaIPI.Text = "Situação Tributária:"
        '
        'pagPIS
        '
        Me.pagPIS.Controls.Add(Me.grpPIS)
        Me.pagPIS.Controls.Add(Me.grpSituacaoTributariaPIS)
        Me.pagPIS.Key = "pagPIS"
        Me.pagPIS.Location = New System.Drawing.Point(1, 22)
        Me.pagPIS.Name = "pagPIS"
        Me.pagPIS.Size = New System.Drawing.Size(949, 329)
        Me.pagPIS.TabStop = True
        Me.pagPIS.Text = "PIS"
        '
        'grpPIS
        '
        Me.grpPIS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPIS.BackColor = System.Drawing.Color.Transparent
        Me.grpPIS.Controls.Add(Me.cboTipoCalculoPIS)
        Me.grpPIS.Controls.Add(Me.lblTipoCalculoPIS)
        Me.grpPIS.Controls.Add(Me.txtBaseCalculoPIS)
        Me.grpPIS.Controls.Add(Me.lblBaseCalculoPIS)
        Me.grpPIS.Controls.Add(Me.txtQuantidadeVendidaPIS)
        Me.grpPIS.Controls.Add(Me.lblQuantidadeVendidaPIS)
        Me.grpPIS.Controls.Add(Me.txtValorPIS)
        Me.grpPIS.Controls.Add(Me.lblValorPIS)
        Me.grpPIS.Controls.Add(Me.txtAliquotaPercentualPIS)
        Me.grpPIS.Controls.Add(Me.lblAliquotaPercentualPIS)
        Me.grpPIS.Controls.Add(Me.txtAliquotaValorPIS)
        Me.grpPIS.Controls.Add(Me.lblAliquotaValorPIS)
        Me.grpPIS.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpPIS.Location = New System.Drawing.Point(8, 73)
        Me.grpPIS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpPIS.Name = "grpPIS"
        Me.grpPIS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPIS.Size = New System.Drawing.Size(933, 67)
        Me.grpPIS.TabIndex = 1
        Me.grpPIS.Text = "PIS"
        Me.grpPIS.VisualStyleManager = Me.vsmMain
        '
        'cboTipoCalculoPIS
        '
        Me.cboTipoCalculoPIS.AutoSize = False
        Me.cboTipoCalculoPIS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoCalculoPIS.Location = New System.Drawing.Point(9, 37)
        Me.cboTipoCalculoPIS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoCalculoPIS.Name = "cboTipoCalculoPIS"
        Me.cboTipoCalculoPIS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoCalculoPIS.Size = New System.Drawing.Size(160, 20)
        Me.cboTipoCalculoPIS.TabIndex = 1
        '
        'lblTipoCalculoPIS
        '
        Me.lblTipoCalculoPIS.AutoSize = True
        Me.lblTipoCalculoPIS.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoCalculoPIS.Location = New System.Drawing.Point(6, 20)
        Me.lblTipoCalculoPIS.Name = "lblTipoCalculoPIS"
        Me.lblTipoCalculoPIS.Size = New System.Drawing.Size(83, 14)
        Me.lblTipoCalculoPIS.TabIndex = 0
        Me.lblTipoCalculoPIS.Text = "Tipo de Cálculo:"
        '
        'txtBaseCalculoPIS
        '
        Me.txtBaseCalculoPIS.Enabled = False
        Me.txtBaseCalculoPIS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseCalculoPIS.Location = New System.Drawing.Point(175, 37)
        Me.txtBaseCalculoPIS.Name = "txtBaseCalculoPIS"
        Me.txtBaseCalculoPIS.Size = New System.Drawing.Size(117, 20)
        Me.txtBaseCalculoPIS.TabIndex = 3
        Me.txtBaseCalculoPIS.Tag = ""
        Me.txtBaseCalculoPIS.Text = "0,00"
        Me.txtBaseCalculoPIS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblBaseCalculoPIS
        '
        Me.lblBaseCalculoPIS.AutoSize = True
        Me.lblBaseCalculoPIS.Location = New System.Drawing.Point(172, 20)
        Me.lblBaseCalculoPIS.Name = "lblBaseCalculoPIS"
        Me.lblBaseCalculoPIS.Size = New System.Drawing.Size(85, 14)
        Me.lblBaseCalculoPIS.TabIndex = 2
        Me.lblBaseCalculoPIS.Text = "Base de Cálculo"
        '
        'txtQuantidadeVendidaPIS
        '
        Me.txtQuantidadeVendidaPIS.DecimalDigits = 4
        Me.txtQuantidadeVendidaPIS.Enabled = False
        Me.txtQuantidadeVendidaPIS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidadeVendidaPIS.Location = New System.Drawing.Point(541, 37)
        Me.txtQuantidadeVendidaPIS.Name = "txtQuantidadeVendidaPIS"
        Me.txtQuantidadeVendidaPIS.Size = New System.Drawing.Size(114, 20)
        Me.txtQuantidadeVendidaPIS.TabIndex = 9
        Me.txtQuantidadeVendidaPIS.Tag = ""
        Me.txtQuantidadeVendidaPIS.Text = "0,0000"
        Me.txtQuantidadeVendidaPIS.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeVendidaPIS
        '
        Me.lblQuantidadeVendidaPIS.AutoSize = True
        Me.lblQuantidadeVendidaPIS.Location = New System.Drawing.Point(538, 20)
        Me.lblQuantidadeVendidaPIS.Name = "lblQuantidadeVendidaPIS"
        Me.lblQuantidadeVendidaPIS.Size = New System.Drawing.Size(78, 14)
        Me.lblQuantidadeVendidaPIS.TabIndex = 8
        Me.lblQuantidadeVendidaPIS.Text = "Qtde. Vendida:"
        '
        'txtValorPIS
        '
        Me.txtValorPIS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorPIS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorPIS.Location = New System.Drawing.Point(661, 37)
        Me.txtValorPIS.Name = "txtValorPIS"
        Me.txtValorPIS.ReadOnly = True
        Me.txtValorPIS.Size = New System.Drawing.Size(119, 20)
        Me.txtValorPIS.TabIndex = 11
        Me.txtValorPIS.TabStop = False
        Me.txtValorPIS.Tag = ""
        Me.txtValorPIS.Text = "0,00"
        Me.txtValorPIS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorPIS
        '
        Me.lblValorPIS.AutoSize = True
        Me.lblValorPIS.Location = New System.Drawing.Point(658, 20)
        Me.lblValorPIS.Name = "lblValorPIS"
        Me.lblValorPIS.Size = New System.Drawing.Size(53, 14)
        Me.lblValorPIS.TabIndex = 10
        Me.lblValorPIS.Text = "Valor PIS:"
        '
        'txtAliquotaPercentualPIS
        '
        Me.txtAliquotaPercentualPIS.Enabled = False
        Me.txtAliquotaPercentualPIS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAliquotaPercentualPIS.Location = New System.Drawing.Point(298, 37)
        Me.txtAliquotaPercentualPIS.Name = "txtAliquotaPercentualPIS"
        Me.txtAliquotaPercentualPIS.Size = New System.Drawing.Size(117, 20)
        Me.txtAliquotaPercentualPIS.TabIndex = 5
        Me.txtAliquotaPercentualPIS.Tag = ""
        Me.txtAliquotaPercentualPIS.Text = "0,00"
        Me.txtAliquotaPercentualPIS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaPercentualPIS
        '
        Me.lblAliquotaPercentualPIS.AutoSize = True
        Me.lblAliquotaPercentualPIS.Location = New System.Drawing.Point(295, 20)
        Me.lblAliquotaPercentualPIS.Name = "lblAliquotaPercentualPIS"
        Me.lblAliquotaPercentualPIS.Size = New System.Drawing.Size(70, 14)
        Me.lblAliquotaPercentualPIS.TabIndex = 4
        Me.lblAliquotaPercentualPIS.Text = "Alíquota (%):"
        '
        'txtAliquotaValorPIS
        '
        Me.txtAliquotaValorPIS.DecimalDigits = 4
        Me.txtAliquotaValorPIS.Enabled = False
        Me.txtAliquotaValorPIS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAliquotaValorPIS.Location = New System.Drawing.Point(421, 37)
        Me.txtAliquotaValorPIS.Name = "txtAliquotaValorPIS"
        Me.txtAliquotaValorPIS.Size = New System.Drawing.Size(114, 20)
        Me.txtAliquotaValorPIS.TabIndex = 7
        Me.txtAliquotaValorPIS.Tag = ""
        Me.txtAliquotaValorPIS.Text = "0,0000"
        Me.txtAliquotaValorPIS.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblAliquotaValorPIS
        '
        Me.lblAliquotaValorPIS.AutoSize = True
        Me.lblAliquotaValorPIS.Location = New System.Drawing.Point(418, 20)
        Me.lblAliquotaValorPIS.Name = "lblAliquotaValorPIS"
        Me.lblAliquotaValorPIS.Size = New System.Drawing.Size(73, 14)
        Me.lblAliquotaValorPIS.TabIndex = 6
        Me.lblAliquotaValorPIS.Text = "Alíquota (R$):"
        '
        'grpSituacaoTributariaPIS
        '
        Me.grpSituacaoTributariaPIS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSituacaoTributariaPIS.BackColor = System.Drawing.Color.Transparent
        Me.grpSituacaoTributariaPIS.Controls.Add(Me.cboSituacaoTributariaPIS)
        Me.grpSituacaoTributariaPIS.Controls.Add(Me.lblSituacaoTributariaPIS)
        Me.grpSituacaoTributariaPIS.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpSituacaoTributariaPIS.Location = New System.Drawing.Point(8, 3)
        Me.grpSituacaoTributariaPIS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSituacaoTributariaPIS.Name = "grpSituacaoTributariaPIS"
        Me.grpSituacaoTributariaPIS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSituacaoTributariaPIS.Size = New System.Drawing.Size(933, 67)
        Me.grpSituacaoTributariaPIS.TabIndex = 0
        Me.grpSituacaoTributariaPIS.Text = "Situação Tributária do PIS"
        Me.grpSituacaoTributariaPIS.VisualStyleManager = Me.vsmMain
        '
        'cboSituacaoTributariaPIS
        '
        Me.cboSituacaoTributariaPIS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSituacaoTributariaPIS.AutoSize = False
        Me.cboSituacaoTributariaPIS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSituacaoTributariaPIS.Location = New System.Drawing.Point(9, 37)
        Me.cboSituacaoTributariaPIS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSituacaoTributariaPIS.Name = "cboSituacaoTributariaPIS"
        Me.cboSituacaoTributariaPIS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSituacaoTributariaPIS.Size = New System.Drawing.Size(915, 20)
        Me.cboSituacaoTributariaPIS.TabIndex = 1
        '
        'lblSituacaoTributariaPIS
        '
        Me.lblSituacaoTributariaPIS.AutoSize = True
        Me.lblSituacaoTributariaPIS.BackColor = System.Drawing.Color.Transparent
        Me.lblSituacaoTributariaPIS.Location = New System.Drawing.Point(6, 20)
        Me.lblSituacaoTributariaPIS.Name = "lblSituacaoTributariaPIS"
        Me.lblSituacaoTributariaPIS.Size = New System.Drawing.Size(100, 14)
        Me.lblSituacaoTributariaPIS.TabIndex = 0
        Me.lblSituacaoTributariaPIS.Text = "Situação Tributária:"
        '
        'pagCOFINS
        '
        Me.pagCOFINS.Controls.Add(Me.grpCOFINS)
        Me.pagCOFINS.Controls.Add(Me.grpSituacaoTributariaCOFINS)
        Me.pagCOFINS.Key = "pagCOFINS"
        Me.pagCOFINS.Location = New System.Drawing.Point(1, 22)
        Me.pagCOFINS.Name = "pagCOFINS"
        Me.pagCOFINS.Size = New System.Drawing.Size(949, 329)
        Me.pagCOFINS.TabStop = True
        Me.pagCOFINS.Text = "COFINS"
        '
        'grpCOFINS
        '
        Me.grpCOFINS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCOFINS.BackColor = System.Drawing.Color.Transparent
        Me.grpCOFINS.Controls.Add(Me.cboTipoCalculoCOFINS)
        Me.grpCOFINS.Controls.Add(Me.lblTipoCalculoCOFINS)
        Me.grpCOFINS.Controls.Add(Me.txtBaseCalculoCOFINS)
        Me.grpCOFINS.Controls.Add(Me.lblBaseCalculoCOFINS)
        Me.grpCOFINS.Controls.Add(Me.txtQuantidadeVendidaCOFINS)
        Me.grpCOFINS.Controls.Add(Me.lblQuantidadeVendidaCOFINS)
        Me.grpCOFINS.Controls.Add(Me.txtValorCOFINS)
        Me.grpCOFINS.Controls.Add(Me.lblValorCOFINS)
        Me.grpCOFINS.Controls.Add(Me.txtAliquotaPercentualCOFINS)
        Me.grpCOFINS.Controls.Add(Me.lblAliquotaPercentualCOFINS)
        Me.grpCOFINS.Controls.Add(Me.txtAliquotaValorCOFINS)
        Me.grpCOFINS.Controls.Add(Me.lblAliquotaValorCOFINS)
        Me.grpCOFINS.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpCOFINS.Location = New System.Drawing.Point(8, 73)
        Me.grpCOFINS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpCOFINS.Name = "grpCOFINS"
        Me.grpCOFINS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCOFINS.Size = New System.Drawing.Size(933, 67)
        Me.grpCOFINS.TabIndex = 1
        Me.grpCOFINS.Text = "COFINS"
        Me.grpCOFINS.VisualStyleManager = Me.vsmMain
        '
        'cboTipoCalculoCOFINS
        '
        Me.cboTipoCalculoCOFINS.AutoSize = False
        Me.cboTipoCalculoCOFINS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoCalculoCOFINS.Location = New System.Drawing.Point(9, 37)
        Me.cboTipoCalculoCOFINS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTipoCalculoCOFINS.Name = "cboTipoCalculoCOFINS"
        Me.cboTipoCalculoCOFINS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoCalculoCOFINS.Size = New System.Drawing.Size(160, 20)
        Me.cboTipoCalculoCOFINS.TabIndex = 1
        '
        'lblTipoCalculoCOFINS
        '
        Me.lblTipoCalculoCOFINS.AutoSize = True
        Me.lblTipoCalculoCOFINS.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoCalculoCOFINS.Location = New System.Drawing.Point(6, 20)
        Me.lblTipoCalculoCOFINS.Name = "lblTipoCalculoCOFINS"
        Me.lblTipoCalculoCOFINS.Size = New System.Drawing.Size(83, 14)
        Me.lblTipoCalculoCOFINS.TabIndex = 0
        Me.lblTipoCalculoCOFINS.Text = "Tipo de Cálculo:"
        '
        'txtBaseCalculoCOFINS
        '
        Me.txtBaseCalculoCOFINS.Enabled = False
        Me.txtBaseCalculoCOFINS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseCalculoCOFINS.Location = New System.Drawing.Point(175, 37)
        Me.txtBaseCalculoCOFINS.Name = "txtBaseCalculoCOFINS"
        Me.txtBaseCalculoCOFINS.Size = New System.Drawing.Size(117, 20)
        Me.txtBaseCalculoCOFINS.TabIndex = 3
        Me.txtBaseCalculoCOFINS.Tag = ""
        Me.txtBaseCalculoCOFINS.Text = "0,00"
        Me.txtBaseCalculoCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblBaseCalculoCOFINS
        '
        Me.lblBaseCalculoCOFINS.AutoSize = True
        Me.lblBaseCalculoCOFINS.Location = New System.Drawing.Point(172, 20)
        Me.lblBaseCalculoCOFINS.Name = "lblBaseCalculoCOFINS"
        Me.lblBaseCalculoCOFINS.Size = New System.Drawing.Size(85, 14)
        Me.lblBaseCalculoCOFINS.TabIndex = 2
        Me.lblBaseCalculoCOFINS.Text = "Base de Cálculo"
        '
        'txtQuantidadeVendidaCOFINS
        '
        Me.txtQuantidadeVendidaCOFINS.DecimalDigits = 4
        Me.txtQuantidadeVendidaCOFINS.Enabled = False
        Me.txtQuantidadeVendidaCOFINS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidadeVendidaCOFINS.Location = New System.Drawing.Point(541, 37)
        Me.txtQuantidadeVendidaCOFINS.Name = "txtQuantidadeVendidaCOFINS"
        Me.txtQuantidadeVendidaCOFINS.Size = New System.Drawing.Size(114, 20)
        Me.txtQuantidadeVendidaCOFINS.TabIndex = 9
        Me.txtQuantidadeVendidaCOFINS.Tag = ""
        Me.txtQuantidadeVendidaCOFINS.Text = "0,0000"
        Me.txtQuantidadeVendidaCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeVendidaCOFINS
        '
        Me.lblQuantidadeVendidaCOFINS.AutoSize = True
        Me.lblQuantidadeVendidaCOFINS.Location = New System.Drawing.Point(538, 20)
        Me.lblQuantidadeVendidaCOFINS.Name = "lblQuantidadeVendidaCOFINS"
        Me.lblQuantidadeVendidaCOFINS.Size = New System.Drawing.Size(78, 14)
        Me.lblQuantidadeVendidaCOFINS.TabIndex = 8
        Me.lblQuantidadeVendidaCOFINS.Text = "Qtde. Vendida:"
        '
        'txtValorCOFINS
        '
        Me.txtValorCOFINS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorCOFINS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorCOFINS.Location = New System.Drawing.Point(661, 37)
        Me.txtValorCOFINS.Name = "txtValorCOFINS"
        Me.txtValorCOFINS.ReadOnly = True
        Me.txtValorCOFINS.Size = New System.Drawing.Size(119, 20)
        Me.txtValorCOFINS.TabIndex = 11
        Me.txtValorCOFINS.TabStop = False
        Me.txtValorCOFINS.Tag = ""
        Me.txtValorCOFINS.Text = "0,00"
        Me.txtValorCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorCOFINS
        '
        Me.lblValorCOFINS.AutoSize = True
        Me.lblValorCOFINS.Location = New System.Drawing.Point(658, 20)
        Me.lblValorCOFINS.Name = "lblValorCOFINS"
        Me.lblValorCOFINS.Size = New System.Drawing.Size(75, 14)
        Me.lblValorCOFINS.TabIndex = 10
        Me.lblValorCOFINS.Text = "Valor COFINS:"
        '
        'txtAliquotaPercentualCOFINS
        '
        Me.txtAliquotaPercentualCOFINS.Enabled = False
        Me.txtAliquotaPercentualCOFINS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAliquotaPercentualCOFINS.Location = New System.Drawing.Point(298, 37)
        Me.txtAliquotaPercentualCOFINS.Name = "txtAliquotaPercentualCOFINS"
        Me.txtAliquotaPercentualCOFINS.Size = New System.Drawing.Size(117, 20)
        Me.txtAliquotaPercentualCOFINS.TabIndex = 5
        Me.txtAliquotaPercentualCOFINS.Tag = ""
        Me.txtAliquotaPercentualCOFINS.Text = "0,00"
        Me.txtAliquotaPercentualCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaPercentualCOFINS
        '
        Me.lblAliquotaPercentualCOFINS.AutoSize = True
        Me.lblAliquotaPercentualCOFINS.Location = New System.Drawing.Point(295, 20)
        Me.lblAliquotaPercentualCOFINS.Name = "lblAliquotaPercentualCOFINS"
        Me.lblAliquotaPercentualCOFINS.Size = New System.Drawing.Size(70, 14)
        Me.lblAliquotaPercentualCOFINS.TabIndex = 4
        Me.lblAliquotaPercentualCOFINS.Text = "Alíquota (%):"
        '
        'txtAliquotaValorCOFINS
        '
        Me.txtAliquotaValorCOFINS.DecimalDigits = 4
        Me.txtAliquotaValorCOFINS.Enabled = False
        Me.txtAliquotaValorCOFINS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAliquotaValorCOFINS.Location = New System.Drawing.Point(421, 37)
        Me.txtAliquotaValorCOFINS.Name = "txtAliquotaValorCOFINS"
        Me.txtAliquotaValorCOFINS.Size = New System.Drawing.Size(114, 20)
        Me.txtAliquotaValorCOFINS.TabIndex = 7
        Me.txtAliquotaValorCOFINS.Tag = ""
        Me.txtAliquotaValorCOFINS.Text = "0,0000"
        Me.txtAliquotaValorCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblAliquotaValorCOFINS
        '
        Me.lblAliquotaValorCOFINS.AutoSize = True
        Me.lblAliquotaValorCOFINS.Location = New System.Drawing.Point(418, 20)
        Me.lblAliquotaValorCOFINS.Name = "lblAliquotaValorCOFINS"
        Me.lblAliquotaValorCOFINS.Size = New System.Drawing.Size(73, 14)
        Me.lblAliquotaValorCOFINS.TabIndex = 6
        Me.lblAliquotaValorCOFINS.Text = "Alíquota (R$):"
        '
        'grpSituacaoTributariaCOFINS
        '
        Me.grpSituacaoTributariaCOFINS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSituacaoTributariaCOFINS.BackColor = System.Drawing.Color.Transparent
        Me.grpSituacaoTributariaCOFINS.Controls.Add(Me.cboSituacaoTributariaCOFINS)
        Me.grpSituacaoTributariaCOFINS.Controls.Add(Me.lblSituacaoTributariaCOFINS)
        Me.grpSituacaoTributariaCOFINS.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpSituacaoTributariaCOFINS.Location = New System.Drawing.Point(8, 3)
        Me.grpSituacaoTributariaCOFINS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSituacaoTributariaCOFINS.Name = "grpSituacaoTributariaCOFINS"
        Me.grpSituacaoTributariaCOFINS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSituacaoTributariaCOFINS.Size = New System.Drawing.Size(933, 67)
        Me.grpSituacaoTributariaCOFINS.TabIndex = 0
        Me.grpSituacaoTributariaCOFINS.Text = "Situação Tributária COFINS"
        Me.grpSituacaoTributariaCOFINS.VisualStyleManager = Me.vsmMain
        '
        'cboSituacaoTributariaCOFINS
        '
        Me.cboSituacaoTributariaCOFINS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSituacaoTributariaCOFINS.AutoSize = False
        Me.cboSituacaoTributariaCOFINS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSituacaoTributariaCOFINS.Location = New System.Drawing.Point(9, 37)
        Me.cboSituacaoTributariaCOFINS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSituacaoTributariaCOFINS.Name = "cboSituacaoTributariaCOFINS"
        Me.cboSituacaoTributariaCOFINS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSituacaoTributariaCOFINS.Size = New System.Drawing.Size(915, 20)
        Me.cboSituacaoTributariaCOFINS.TabIndex = 1
        '
        'lblSituacaoTributariaCOFINS
        '
        Me.lblSituacaoTributariaCOFINS.AutoSize = True
        Me.lblSituacaoTributariaCOFINS.BackColor = System.Drawing.Color.Transparent
        Me.lblSituacaoTributariaCOFINS.Location = New System.Drawing.Point(6, 20)
        Me.lblSituacaoTributariaCOFINS.Name = "lblSituacaoTributariaCOFINS"
        Me.lblSituacaoTributariaCOFINS.Size = New System.Drawing.Size(100, 14)
        Me.lblSituacaoTributariaCOFINS.TabIndex = 0
        Me.lblSituacaoTributariaCOFINS.Text = "Situação Tributária:"
        '
        'pagImpostoImportacao
        '
        Me.pagImpostoImportacao.Controls.Add(Me.grpII)
        Me.pagImpostoImportacao.Key = "pagImpostoImportacao"
        Me.pagImpostoImportacao.Location = New System.Drawing.Point(1, 22)
        Me.pagImpostoImportacao.Name = "pagImpostoImportacao"
        Me.pagImpostoImportacao.Size = New System.Drawing.Size(949, 329)
        Me.pagImpostoImportacao.TabStop = True
        Me.pagImpostoImportacao.Text = "Imposto de Importação"
        '
        'grpII
        '
        Me.grpII.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpII.BackColor = System.Drawing.Color.Transparent
        Me.grpII.Controls.Add(Me.txtValorII)
        Me.grpII.Controls.Add(Me.lblValorII)
        Me.grpII.Controls.Add(Me.txtValorIOF)
        Me.grpII.Controls.Add(Me.lblValorIOF)
        Me.grpII.Controls.Add(Me.txtDespesaAduaneiraII)
        Me.grpII.Controls.Add(Me.lblDespesaAduaneiraII)
        Me.grpII.Controls.Add(Me.txtBaseCalculoII)
        Me.grpII.Controls.Add(Me.lblBaseCalculoII)
        Me.grpII.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpII.Location = New System.Drawing.Point(8, 3)
        Me.grpII.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpII.Name = "grpII"
        Me.grpII.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpII.Size = New System.Drawing.Size(933, 67)
        Me.grpII.TabIndex = 0
        Me.grpII.Text = "Imposto de Importação"
        Me.grpII.VisualStyleManager = Me.vsmMain
        '
        'txtValorII
        '
        Me.txtValorII.Location = New System.Drawing.Point(376, 37)
        Me.txtValorII.Name = "txtValorII"
        Me.txtValorII.Size = New System.Drawing.Size(116, 20)
        Me.txtValorII.TabIndex = 7
        Me.txtValorII.Text = "0,00"
        Me.txtValorII.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorII
        '
        Me.lblValorII.AutoSize = True
        Me.lblValorII.Location = New System.Drawing.Point(373, 20)
        Me.lblValorII.Name = "lblValorII"
        Me.lblValorII.Size = New System.Drawing.Size(57, 14)
        Me.lblValorII.TabIndex = 6
        Me.lblValorII.Text = "Valor do II:"
        '
        'txtValorIOF
        '
        Me.txtValorIOF.Location = New System.Drawing.Point(254, 37)
        Me.txtValorIOF.Name = "txtValorIOF"
        Me.txtValorIOF.Size = New System.Drawing.Size(116, 20)
        Me.txtValorIOF.TabIndex = 5
        Me.txtValorIOF.Text = "0,00"
        Me.txtValorIOF.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorIOF
        '
        Me.lblValorIOF.AutoSize = True
        Me.lblValorIOF.Location = New System.Drawing.Point(251, 20)
        Me.lblValorIOF.Name = "lblValorIOF"
        Me.lblValorIOF.Size = New System.Drawing.Size(69, 14)
        Me.lblValorIOF.TabIndex = 4
        Me.lblValorIOF.Text = "Valor do IOF:"
        '
        'txtDespesaAduaneiraII
        '
        Me.txtDespesaAduaneiraII.Location = New System.Drawing.Point(132, 37)
        Me.txtDespesaAduaneiraII.Name = "txtDespesaAduaneiraII"
        Me.txtDespesaAduaneiraII.Size = New System.Drawing.Size(116, 20)
        Me.txtDespesaAduaneiraII.TabIndex = 3
        Me.txtDespesaAduaneiraII.Text = "0,00"
        Me.txtDespesaAduaneiraII.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblDespesaAduaneiraII
        '
        Me.lblDespesaAduaneiraII.AutoSize = True
        Me.lblDespesaAduaneiraII.Location = New System.Drawing.Point(129, 20)
        Me.lblDespesaAduaneiraII.Name = "lblDespesaAduaneiraII"
        Me.lblDespesaAduaneiraII.Size = New System.Drawing.Size(111, 14)
        Me.lblDespesaAduaneiraII.TabIndex = 2
        Me.lblDespesaAduaneiraII.Text = "Despesa Aduaneiras:"
        '
        'txtBaseCalculoII
        '
        Me.txtBaseCalculoII.Location = New System.Drawing.Point(9, 37)
        Me.txtBaseCalculoII.Name = "txtBaseCalculoII"
        Me.txtBaseCalculoII.Size = New System.Drawing.Size(117, 20)
        Me.txtBaseCalculoII.TabIndex = 1
        Me.txtBaseCalculoII.Text = "0,00"
        Me.txtBaseCalculoII.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblBaseCalculoII
        '
        Me.lblBaseCalculoII.AutoSize = True
        Me.lblBaseCalculoII.Location = New System.Drawing.Point(6, 20)
        Me.lblBaseCalculoII.Name = "lblBaseCalculoII"
        Me.lblBaseCalculoII.Size = New System.Drawing.Size(88, 14)
        Me.lblBaseCalculoII.TabIndex = 0
        Me.lblBaseCalculoII.Text = "Base de Cálculo:"
        '
        'pagEstoque
        '
        Me.pagEstoque.Controls.Add(Me.btnAgruparGridEstoque)
        Me.pagEstoque.Controls.Add(Me.btnConfigurarGridEstoque)
        Me.pagEstoque.Controls.Add(Me.grpSalvarLote)
        Me.pagEstoque.Controls.Add(Me.grdEstoque)
        Me.pagEstoque.Controls.Add(Me.grpEstoque)
        Me.pagEstoque.Key = "pagEstoque"
        Me.pagEstoque.Location = New System.Drawing.Point(1, 22)
        Me.pagEstoque.Name = "pagEstoque"
        Me.pagEstoque.Size = New System.Drawing.Size(967, 422)
        Me.pagEstoque.TabStop = True
        Me.pagEstoque.Text = "Estoque"
        '
        'btnAgruparGridEstoque
        '
        Me.btnAgruparGridEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridEstoque.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridEstoque.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridEstoque.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridEstoque.Location = New System.Drawing.Point(33, 342)
        Me.btnAgruparGridEstoque.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridEstoque.Name = "btnAgruparGridEstoque"
        Me.btnAgruparGridEstoque.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridEstoque.TabIndex = 3
        Me.btnAgruparGridEstoque.TabStop = False
        Me.btnAgruparGridEstoque.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridEstoque
        '
        Me.btnConfigurarGridEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridEstoque.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridEstoque.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridEstoque.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridEstoque.Location = New System.Drawing.Point(9, 342)
        Me.btnConfigurarGridEstoque.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridEstoque.Name = "btnConfigurarGridEstoque"
        Me.btnConfigurarGridEstoque.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridEstoque.TabIndex = 2
        Me.btnConfigurarGridEstoque.TabStop = False
        Me.btnConfigurarGridEstoque.UseVisualStyleBackColor = False
        '
        'grpSalvarLote
        '
        Me.grpSalvarLote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSalvarLote.BackColor = System.Drawing.Color.Transparent
        Me.grpSalvarLote.Controls.Add(Me.lblCongelarColuna)
        Me.grpSalvarLote.Controls.Add(Me.cboCongelarColuna)
        Me.grpSalvarLote.Controls.Add(Me.btnSalvarLote)
        Me.grpSalvarLote.Controls.Add(Me.btnVoltarLote)
        Me.grpSalvarLote.Location = New System.Drawing.Point(8, 362)
        Me.grpSalvarLote.Name = "grpSalvarLote"
        Me.grpSalvarLote.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSalvarLote.Size = New System.Drawing.Size(951, 51)
        Me.grpSalvarLote.TabIndex = 4
        Me.grpSalvarLote.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpSalvarLote.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 5
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 6
        Me.cboCongelarColuna.TabStop = False
        '
        'btnSalvarLote
        '
        Me.btnSalvarLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvarLote.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvarLote.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvarLote.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvarLote.Location = New System.Drawing.Point(754, 17)
        Me.btnSalvarLote.Name = "btnSalvarLote"
        Me.btnSalvarLote.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvarLote.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvarLote.TabIndex = 0
        Me.btnSalvarLote.Text = "Salvar"
        Me.btnSalvarLote.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltarLote
        '
        Me.btnVoltarLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltarLote.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltarLote.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltarLote.Location = New System.Drawing.Point(851, 17)
        Me.btnVoltarLote.Name = "btnVoltarLote"
        Me.btnVoltarLote.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltarLote.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltarLote.TabIndex = 1
        Me.btnVoltarLote.Text = "Voltar"
        Me.btnVoltarLote.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdEstoque
        '
        Me.grdEstoque.AllowDrop = True
        Me.grdEstoque.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdEstoque.AlternatingColors = True
        Me.grdEstoque.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdEstoque.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        grdEstoque_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdEstoque_DesignTimeLayout_Reference_0.Instance"), Object)
        grdEstoque_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdEstoque_DesignTimeLayout_Reference_0})
        grdEstoque_DesignTimeLayout.LayoutString = resources.GetString("grdEstoque_DesignTimeLayout.LayoutString")
        Me.grdEstoque.DesignTimeLayout = grdEstoque_DesignTimeLayout
        Me.grdEstoque.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdEstoque.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdEstoque.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdEstoque.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdEstoque.FocusCellFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdEstoque.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdEstoque.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdEstoque.FrozenColumns = 2
        Me.grdEstoque.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdEstoque.GroupByBoxVisible = False
        Me.grdEstoque.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdEstoque.Location = New System.Drawing.Point(8, 156)
        Me.grdEstoque.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdEstoque.Name = "grdEstoque"
        Me.grdEstoque.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdEstoque.RecordNavigator = True
        Me.grdEstoque.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdEstoque.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdEstoque.Size = New System.Drawing.Size(951, 203)
        Me.grdEstoque.TabIndex = 1
        Me.grdEstoque.TabStop = False
        Me.grdEstoque.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdEstoque.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdEstoque.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdEstoque.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdEstoque.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdEstoque.VisualStyleManager = Me.vsmMain
        '
        'grpEstoque
        '
        Me.grpEstoque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEstoque.BackColor = System.Drawing.Color.Transparent
        Me.grpEstoque.Controls.Add(Me.btnCadastrarProduto)
        Me.grpEstoque.Controls.Add(Me.cboProduto)
        Me.grpEstoque.Controls.Add(Me.btnProcurarProduto)
        Me.grpEstoque.Controls.Add(Me.lblProduto)
        Me.grpEstoque.Controls.Add(Me.btnAtualizarPedidoCompra)
        Me.grpEstoque.Controls.Add(Me.lblQuantidadeDocumento)
        Me.grpEstoque.Controls.Add(Me.txtQuantidadeDocumento)
        Me.grpEstoque.Controls.Add(Me.lblNumeroDocumento)
        Me.grpEstoque.Controls.Add(Me.cboNumeroDocumento)
        Me.grpEstoque.Controls.Add(Me.lblTipoOperacao)
        Me.grpEstoque.Controls.Add(Me.cboTipoOperacao)
        Me.grpEstoque.Controls.Add(Me.btnCadastrarUnidadeMedidaEstoque)
        Me.grpEstoque.Controls.Add(Me.lblUnidadeMedidaEstoque)
        Me.grpEstoque.Controls.Add(Me.cboUnidadeMedidaEstoque)
        Me.grpEstoque.Controls.Add(Me.lblQuantidadeEstoque)
        Me.grpEstoque.Controls.Add(Me.txtQuantidadeEstoque)
        Me.grpEstoque.Controls.Add(Me.txtFatorConversao)
        Me.grpEstoque.Controls.Add(Me.lblFatorConversao)
        Me.grpEstoque.Controls.Add(Me.txtQuantidadeLote)
        Me.grpEstoque.Controls.Add(Me.lblQuantidadeLote)
        Me.grpEstoque.Controls.Add(Me.btnCadastrarDeposito)
        Me.grpEstoque.Controls.Add(Me.lblDeposito)
        Me.grpEstoque.Controls.Add(Me.cboDeposito)
        Me.grpEstoque.Controls.Add(Me.lblDataFabricacao)
        Me.grpEstoque.Controls.Add(Me.dtpDataFabricacao)
        Me.grpEstoque.Controls.Add(Me.lblOCCapa)
        Me.grpEstoque.Controls.Add(Me.txtOCCapa)
        Me.grpEstoque.Controls.Add(Me.lblOCLinha)
        Me.grpEstoque.Controls.Add(Me.txtOCLinha)
        Me.grpEstoque.Controls.Add(Me.lblDataValidade)
        Me.grpEstoque.Controls.Add(Me.dtpDataValidade)
        Me.grpEstoque.Controls.Add(Me.lblLote)
        Me.grpEstoque.Controls.Add(Me.txtLote)
        Me.grpEstoque.Controls.Add(Me.btnExcluirEstoque)
        Me.grpEstoque.Controls.Add(Me.btnInserirEstoque)
        Me.grpEstoque.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEstoque.Location = New System.Drawing.Point(8, 3)
        Me.grpEstoque.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpEstoque.Name = "grpEstoque"
        Me.grpEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEstoque.Size = New System.Drawing.Size(951, 144)
        Me.grpEstoque.TabIndex = 0
        Me.grpEstoque.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarProduto
        '
        Me.btnCadastrarProduto.Enabled = False
        Me.btnCadastrarProduto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarProduto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarProduto.Location = New System.Drawing.Point(437, 18)
        Me.btnCadastrarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarProduto.Name = "btnCadastrarProduto"
        Me.btnCadastrarProduto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarProduto.TabIndex = 4
        Me.btnCadastrarProduto.TabStop = False
        Me.btnCadastrarProduto.UseVisualStyleBackColor = True
        '
        'cboProduto
        '
        Me.cboProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboProduto.AutoSize = False
        Me.cboProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProduto.Enabled = False
        Me.cboProduto.HoverMode = Janus.Windows.EditControls.HoverMode.Highlight
        Me.cboProduto.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cboProduto.Location = New System.Drawing.Point(437, 34)
        Me.cboProduto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboProduto.Size = New System.Drawing.Size(364, 20)
        Me.cboProduto.TabIndex = 7
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProduto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProduto.Location = New System.Drawing.Point(784, 15)
        Me.btnProcurarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProduto.TabIndex = 6
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(453, 17)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(83, 14)
        Me.lblProduto.TabIndex = 5
        Me.lblProduto.Text = "Código Produto:"
        '
        'btnAtualizarPedidoCompra
        '
        Me.btnAtualizarPedidoCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtualizarPedidoCompra.Enabled = False
        Me.btnAtualizarPedidoCompra.FlatAppearance.BorderSize = 0
        Me.btnAtualizarPedidoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizarPedidoCompra.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnAtualizarPedidoCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAtualizarPedidoCompra.Location = New System.Drawing.Point(927, 18)
        Me.btnAtualizarPedidoCompra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAtualizarPedidoCompra.Name = "btnAtualizarPedidoCompra"
        Me.btnAtualizarPedidoCompra.Size = New System.Drawing.Size(15, 13)
        Me.btnAtualizarPedidoCompra.TabIndex = 9
        Me.btnAtualizarPedidoCompra.TabStop = False
        Me.btnAtualizarPedidoCompra.UseVisualStyleBackColor = True
        '
        'lblQuantidadeDocumento
        '
        Me.lblQuantidadeDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeDocumento.AutoSize = True
        Me.lblQuantidadeDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeDocumento.Location = New System.Drawing.Point(828, 17)
        Me.lblQuantidadeDocumento.Name = "lblQuantidadeDocumento"
        Me.lblQuantidadeDocumento.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeDocumento.TabIndex = 8
        Me.lblQuantidadeDocumento.Text = "Quantidade:"
        '
        'txtQuantidadeDocumento
        '
        Me.txtQuantidadeDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeDocumento.DecimalDigits = 4
        Me.txtQuantidadeDocumento.Enabled = False
        Me.txtQuantidadeDocumento.Location = New System.Drawing.Point(831, 34)
        Me.txtQuantidadeDocumento.Name = "txtQuantidadeDocumento"
        Me.txtQuantidadeDocumento.ReadOnly = True
        Me.txtQuantidadeDocumento.Size = New System.Drawing.Size(111, 20)
        Me.txtQuantidadeDocumento.TabIndex = 10
        Me.txtQuantidadeDocumento.TabStop = False
        Me.txtQuantidadeDocumento.Text = "0,0000"
        Me.txtQuantidadeDocumento.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(220, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 2
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'cboNumeroDocumento
        '
        Me.cboNumeroDocumento.AutoSize = False
        Me.cboNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNumeroDocumento.Enabled = False
        Me.cboNumeroDocumento.Location = New System.Drawing.Point(223, 34)
        Me.cboNumeroDocumento.Name = "cboNumeroDocumento"
        Me.cboNumeroDocumento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNumeroDocumento.Size = New System.Drawing.Size(208, 20)
        Me.cboNumeroDocumento.TabIndex = 3
        '
        'lblTipoOperacao
        '
        Me.lblTipoOperacao.AutoSize = True
        Me.lblTipoOperacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoOperacao.Location = New System.Drawing.Point(6, 17)
        Me.lblTipoOperacao.Name = "lblTipoOperacao"
        Me.lblTipoOperacao.Size = New System.Drawing.Size(96, 14)
        Me.lblTipoOperacao.TabIndex = 0
        Me.lblTipoOperacao.Text = "Tipo de Operação:"
        '
        'cboTipoOperacao
        '
        Me.cboTipoOperacao.AutoSize = False
        Me.cboTipoOperacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoOperacao.Location = New System.Drawing.Point(9, 34)
        Me.cboTipoOperacao.Name = "cboTipoOperacao"
        Me.cboTipoOperacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoOperacao.Size = New System.Drawing.Size(208, 20)
        Me.cboTipoOperacao.TabIndex = 1
        '
        'btnCadastrarUnidadeMedidaEstoque
        '
        Me.btnCadastrarUnidadeMedidaEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarUnidadeMedidaEstoque.Enabled = False
        Me.btnCadastrarUnidadeMedidaEstoque.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUnidadeMedidaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUnidadeMedidaEstoque.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarUnidadeMedidaEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUnidadeMedidaEstoque.Location = New System.Drawing.Point(116, 58)
        Me.btnCadastrarUnidadeMedidaEstoque.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUnidadeMedidaEstoque.Name = "btnCadastrarUnidadeMedidaEstoque"
        Me.btnCadastrarUnidadeMedidaEstoque.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarUnidadeMedidaEstoque.TabIndex = 13
        Me.btnCadastrarUnidadeMedidaEstoque.TabStop = False
        Me.btnCadastrarUnidadeMedidaEstoque.UseVisualStyleBackColor = True
        '
        'lblUnidadeMedidaEstoque
        '
        Me.lblUnidadeMedidaEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUnidadeMedidaEstoque.AutoSize = True
        Me.lblUnidadeMedidaEstoque.Location = New System.Drawing.Point(132, 57)
        Me.lblUnidadeMedidaEstoque.Name = "lblUnidadeMedidaEstoque"
        Me.lblUnidadeMedidaEstoque.Size = New System.Drawing.Size(69, 14)
        Me.lblUnidadeMedidaEstoque.TabIndex = 14
        Me.lblUnidadeMedidaEstoque.Text = "Und. Medida:"
        '
        'cboUnidadeMedidaEstoque
        '
        Me.cboUnidadeMedidaEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboUnidadeMedidaEstoque.AutoSize = False
        Me.cboUnidadeMedidaEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedidaEstoque.Enabled = False
        Me.cboUnidadeMedidaEstoque.Location = New System.Drawing.Point(116, 74)
        Me.cboUnidadeMedidaEstoque.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboUnidadeMedidaEstoque.Name = "cboUnidadeMedidaEstoque"
        Me.cboUnidadeMedidaEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedidaEstoque.Size = New System.Drawing.Size(101, 20)
        Me.cboUnidadeMedidaEstoque.TabIndex = 15
        '
        'lblQuantidadeEstoque
        '
        Me.lblQuantidadeEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeEstoque.AutoSize = True
        Me.lblQuantidadeEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeEstoque.Location = New System.Drawing.Point(327, 57)
        Me.lblQuantidadeEstoque.Name = "lblQuantidadeEstoque"
        Me.lblQuantidadeEstoque.Size = New System.Drawing.Size(78, 14)
        Me.lblQuantidadeEstoque.TabIndex = 18
        Me.lblQuantidadeEstoque.Text = "Qtde. Estoque:"
        '
        'txtQuantidadeEstoque
        '
        Me.txtQuantidadeEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeEstoque.DecimalDigits = 4
        Me.txtQuantidadeEstoque.Enabled = False
        Me.txtQuantidadeEstoque.Location = New System.Drawing.Point(330, 74)
        Me.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque"
        Me.txtQuantidadeEstoque.Size = New System.Drawing.Size(101, 20)
        Me.txtQuantidadeEstoque.TabIndex = 19
        Me.txtQuantidadeEstoque.Text = "0,0000"
        Me.txtQuantidadeEstoque.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'txtFatorConversao
        '
        Me.txtFatorConversao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtFatorConversao.DecimalDigits = 4
        Me.txtFatorConversao.Enabled = False
        Me.txtFatorConversao.Location = New System.Drawing.Point(223, 74)
        Me.txtFatorConversao.Name = "txtFatorConversao"
        Me.txtFatorConversao.Size = New System.Drawing.Size(101, 20)
        Me.txtFatorConversao.TabIndex = 17
        Me.txtFatorConversao.Text = "0,0000"
        Me.txtFatorConversao.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblFatorConversao
        '
        Me.lblFatorConversao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFatorConversao.AutoSize = True
        Me.lblFatorConversao.Location = New System.Drawing.Point(220, 57)
        Me.lblFatorConversao.Name = "lblFatorConversao"
        Me.lblFatorConversao.Size = New System.Drawing.Size(91, 14)
        Me.lblFatorConversao.TabIndex = 16
        Me.lblFatorConversao.Text = "Fator Conversão:"
        '
        'txtQuantidadeLote
        '
        Me.txtQuantidadeLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeLote.DecimalDigits = 4
        Me.txtQuantidadeLote.Enabled = False
        Me.txtQuantidadeLote.Location = New System.Drawing.Point(9, 74)
        Me.txtQuantidadeLote.Name = "txtQuantidadeLote"
        Me.txtQuantidadeLote.Size = New System.Drawing.Size(101, 20)
        Me.txtQuantidadeLote.TabIndex = 12
        Me.txtQuantidadeLote.Text = "0,0000"
        Me.txtQuantidadeLote.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeLote
        '
        Me.lblQuantidadeLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeLote.AutoSize = True
        Me.lblQuantidadeLote.Location = New System.Drawing.Point(6, 57)
        Me.lblQuantidadeLote.Name = "lblQuantidadeLote"
        Me.lblQuantidadeLote.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeLote.TabIndex = 11
        Me.lblQuantidadeLote.Text = "Quantidade:"
        '
        'btnCadastrarDeposito
        '
        Me.btnCadastrarDeposito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarDeposito.Enabled = False
        Me.btnCadastrarDeposito.FlatAppearance.BorderSize = 0
        Me.btnCadastrarDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarDeposito.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarDeposito.Location = New System.Drawing.Point(437, 57)
        Me.btnCadastrarDeposito.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarDeposito.Name = "btnCadastrarDeposito"
        Me.btnCadastrarDeposito.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarDeposito.TabIndex = 20
        Me.btnCadastrarDeposito.TabStop = False
        Me.btnCadastrarDeposito.UseVisualStyleBackColor = True
        '
        'lblDeposito
        '
        Me.lblDeposito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDeposito.AutoSize = True
        Me.lblDeposito.Location = New System.Drawing.Point(453, 57)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(52, 14)
        Me.lblDeposito.TabIndex = 21
        Me.lblDeposito.Text = "Depósito:"
        '
        'cboDeposito
        '
        Me.cboDeposito.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDeposito.AutoSize = False
        Me.cboDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDeposito.Enabled = False
        Me.cboDeposito.Location = New System.Drawing.Point(437, 74)
        Me.cboDeposito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDeposito.Size = New System.Drawing.Size(364, 20)
        Me.cboDeposito.TabIndex = 22
        '
        'lblDataFabricacao
        '
        Me.lblDataFabricacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDataFabricacao.AutoSize = True
        Me.lblDataFabricacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataFabricacao.Location = New System.Drawing.Point(220, 97)
        Me.lblDataFabricacao.Name = "lblDataFabricacao"
        Me.lblDataFabricacao.Size = New System.Drawing.Size(89, 14)
        Me.lblDataFabricacao.TabIndex = 25
        Me.lblDataFabricacao.Text = "Data Fabricação:"
        '
        'dtpDataFabricacao
        '
        Me.dtpDataFabricacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataFabricacao.DropDownCalendar.Name = ""
        Me.dtpDataFabricacao.Enabled = False
        Me.dtpDataFabricacao.Location = New System.Drawing.Point(223, 114)
        Me.dtpDataFabricacao.Name = "dtpDataFabricacao"
        Me.dtpDataFabricacao.Size = New System.Drawing.Size(101, 20)
        Me.dtpDataFabricacao.TabIndex = 26
        Me.dtpDataFabricacao.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblOCCapa
        '
        Me.lblOCCapa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOCCapa.AutoSize = True
        Me.lblOCCapa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOCCapa.Location = New System.Drawing.Point(434, 97)
        Me.lblOCCapa.Name = "lblOCCapa"
        Me.lblOCCapa.Size = New System.Drawing.Size(53, 14)
        Me.lblOCCapa.TabIndex = 29
        Me.lblOCCapa.Text = "OC Capa:"
        '
        'txtOCCapa
        '
        Me.txtOCCapa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtOCCapa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOCCapa.Enabled = False
        Me.txtOCCapa.Location = New System.Drawing.Point(437, 114)
        Me.txtOCCapa.MaxLength = 50
        Me.txtOCCapa.Name = "txtOCCapa"
        Me.txtOCCapa.Size = New System.Drawing.Size(107, 20)
        Me.txtOCCapa.TabIndex = 30
        '
        'lblOCLinha
        '
        Me.lblOCLinha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOCLinha.AutoSize = True
        Me.lblOCLinha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOCLinha.Location = New System.Drawing.Point(547, 97)
        Me.lblOCLinha.Name = "lblOCLinha"
        Me.lblOCLinha.Size = New System.Drawing.Size(54, 14)
        Me.lblOCLinha.TabIndex = 31
        Me.lblOCLinha.Text = "OC Linha:"
        '
        'txtOCLinha
        '
        Me.txtOCLinha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtOCLinha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOCLinha.Enabled = False
        Me.txtOCLinha.Location = New System.Drawing.Point(550, 114)
        Me.txtOCLinha.MaxLength = 50
        Me.txtOCLinha.Name = "txtOCLinha"
        Me.txtOCLinha.Size = New System.Drawing.Size(107, 20)
        Me.txtOCLinha.TabIndex = 32
        '
        'lblDataValidade
        '
        Me.lblDataValidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDataValidade.AutoSize = True
        Me.lblDataValidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataValidade.Location = New System.Drawing.Point(327, 97)
        Me.lblDataValidade.Name = "lblDataValidade"
        Me.lblDataValidade.Size = New System.Drawing.Size(76, 14)
        Me.lblDataValidade.TabIndex = 27
        Me.lblDataValidade.Text = "Data Validade:"
        '
        'dtpDataValidade
        '
        Me.dtpDataValidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataValidade.DropDownCalendar.Name = ""
        Me.dtpDataValidade.Enabled = False
        Me.dtpDataValidade.Location = New System.Drawing.Point(330, 114)
        Me.dtpDataValidade.Name = "dtpDataValidade"
        Me.dtpDataValidade.Size = New System.Drawing.Size(101, 20)
        Me.dtpDataValidade.TabIndex = 28
        Me.dtpDataValidade.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblLote
        '
        Me.lblLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLote.AutoSize = True
        Me.lblLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLote.Location = New System.Drawing.Point(6, 97)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(31, 14)
        Me.lblLote.TabIndex = 23
        Me.lblLote.Text = "Lote:"
        '
        'txtLote
        '
        Me.txtLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Enabled = False
        Me.txtLote.Location = New System.Drawing.Point(9, 114)
        Me.txtLote.MaxLength = 50
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(208, 20)
        Me.txtLote.TabIndex = 24
        '
        'btnExcluirEstoque
        '
        Me.btnExcluirEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirEstoque.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirEstoque.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirEstoque.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirEstoque.Location = New System.Drawing.Point(851, 111)
        Me.btnExcluirEstoque.Name = "btnExcluirEstoque"
        Me.btnExcluirEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirEstoque.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirEstoque.TabIndex = 34
        Me.btnExcluirEstoque.Text = "Excluir"
        Me.btnExcluirEstoque.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirEstoque
        '
        Me.btnInserirEstoque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirEstoque.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirEstoque.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirEstoque.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirEstoque.Location = New System.Drawing.Point(851, 82)
        Me.btnInserirEstoque.Name = "btnInserirEstoque"
        Me.btnInserirEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirEstoque.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirEstoque.TabIndex = 33
        Me.btnInserirEstoque.Text = "Inserir"
        Me.btnInserirEstoque.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmFatEntradaNFProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 460)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEntradaNFProduto"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada de NF - Produto"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpDadosItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosItem.ResumeLayout(False)
        Me.grpDadosItem.PerformLayout()
        CType(Me.grpControleDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleDados.ResumeLayout(False)
        Me.pagTributos.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.tabTributo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTributo.ResumeLayout(False)
        Me.pagICMS.ResumeLayout(False)
        CType(Me.grpICMSSTRetido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpICMSSTRetido.ResumeLayout(False)
        Me.grpICMSSTRetido.PerformLayout()
        CType(Me.grpICMSST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpICMSST.ResumeLayout(False)
        Me.grpICMSST.PerformLayout()
        CType(Me.grpSituacaoTributariaICMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSituacaoTributariaICMS.ResumeLayout(False)
        Me.grpSituacaoTributariaICMS.PerformLayout()
        CType(Me.grpICMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpICMS.ResumeLayout(False)
        Me.grpICMS.PerformLayout()
        Me.pagICMSSimples.ResumeLayout(False)
        CType(Me.grpICMSSTRetidoSimples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpICMSSTRetidoSimples.ResumeLayout(False)
        Me.grpICMSSTRetidoSimples.PerformLayout()
        CType(Me.grpICMSSTSimples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpICMSSTSimples.ResumeLayout(False)
        Me.grpICMSSTSimples.PerformLayout()
        CType(Me.grpICMSSimples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpICMSSimples.ResumeLayout(False)
        Me.grpICMSSimples.PerformLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        Me.UiGroupBox3.PerformLayout()
        Me.pagIPI.ResumeLayout(False)
        CType(Me.grpValoresIPI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpValoresIPI.ResumeLayout(False)
        Me.grpValoresIPI.PerformLayout()
        CType(Me.grpSituacaoTributariaIPI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSituacaoTributariaIPI.ResumeLayout(False)
        Me.grpSituacaoTributariaIPI.PerformLayout()
        Me.pagPIS.ResumeLayout(False)
        CType(Me.grpPIS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPIS.ResumeLayout(False)
        Me.grpPIS.PerformLayout()
        CType(Me.grpSituacaoTributariaPIS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSituacaoTributariaPIS.ResumeLayout(False)
        Me.grpSituacaoTributariaPIS.PerformLayout()
        Me.pagCOFINS.ResumeLayout(False)
        CType(Me.grpCOFINS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCOFINS.ResumeLayout(False)
        Me.grpCOFINS.PerformLayout()
        CType(Me.grpSituacaoTributariaCOFINS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSituacaoTributariaCOFINS.ResumeLayout(False)
        Me.grpSituacaoTributariaCOFINS.PerformLayout()
        Me.pagImpostoImportacao.ResumeLayout(False)
        CType(Me.grpII, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpII.ResumeLayout(False)
        Me.grpII.PerformLayout()
        Me.pagEstoque.ResumeLayout(False)
        CType(Me.grpSalvarLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSalvarLote.ResumeLayout(False)
        Me.grpSalvarLote.PerformLayout()
        CType(Me.grdEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEstoque.ResumeLayout(False)
        Me.grpEstoque.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagTributos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDadosItem As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorDesconto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorDesconto As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarUnidadeMedida As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarNCM As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCFOP As System.Windows.Forms.Button
    Friend WithEvents txtValorTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents txtValorUnitario As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnitario As System.Windows.Forms.Label
    Friend WithEvents lblUnidadeMedida As System.Windows.Forms.Label
    Friend WithEvents cboUnidadeMedida As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents lblNCM As System.Windows.Forms.Label
    Friend WithEvents cboNCM As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCFOP As System.Windows.Forms.Label
    Friend WithEvents cboCFOP As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents grpControleDados As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnSalvarDados As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltarDados As Janus.Windows.EditControls.UIButton
    Friend WithEvents tabTributo As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagICMS As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpICMSST As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboModalidadeBCICMSST As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblModalidadeBCICMSST As System.Windows.Forms.Label
    Friend WithEvents txtBaseCalculoICMSST As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblBaseCalculoICMSST As System.Windows.Forms.Label
    Friend WithEvents txtIVA As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblIVA As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaICMSST As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaICMSST As System.Windows.Forms.Label
    Friend WithEvents txtPorcentagemReducaoBCICMSST As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPorcentagemReducaoBCICMSST As System.Windows.Forms.Label
    Friend WithEvents grpSituacaoTributariaICMS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboSituacaoTributariaICMS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSituacaoTributariaICMS As System.Windows.Forms.Label
    Friend WithEvents grpICMS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboModalidadeBCICMS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblModalidadeBCICMS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaICMS As System.Windows.Forms.Label
    Friend WithEvents txtPorcentagemReducaoBCICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPorcentagemReducaoBCICMS As System.Windows.Forms.Label
    Friend WithEvents pagIPI As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpValoresIPI As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorUnidadeIPI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnidadeIPI As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeIPI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeIPI As System.Windows.Forms.Label
    Friend WithEvents cboTipoCalculoIPI As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoCalculoIPI As System.Windows.Forms.Label
    Friend WithEvents txtValorIPI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorIPI As System.Windows.Forms.Label
    Friend WithEvents txtBaseCalculoIPI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblBaseCalculoIPI As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaIPI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaIPI As System.Windows.Forms.Label
    Friend WithEvents grpSituacaoTributariaIPI As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboSituacaoTributariaIPI As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSituacaoTributariaIPI As System.Windows.Forms.Label
    Friend WithEvents pagPIS As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpPIS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboTipoCalculoPIS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoCalculoPIS As System.Windows.Forms.Label
    Friend WithEvents txtBaseCalculoPIS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblBaseCalculoPIS As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeVendidaPIS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeVendidaPIS As System.Windows.Forms.Label
    Friend WithEvents txtValorPIS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorPIS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaPercentualPIS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaPercentualPIS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaValorPIS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaValorPIS As System.Windows.Forms.Label
    Friend WithEvents grpSituacaoTributariaPIS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboSituacaoTributariaPIS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSituacaoTributariaPIS As System.Windows.Forms.Label
    Friend WithEvents pagCOFINS As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpCOFINS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboTipoCalculoCOFINS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoCalculoCOFINS As System.Windows.Forms.Label
    Friend WithEvents txtBaseCalculoCOFINS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblBaseCalculoCOFINS As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeVendidaCOFINS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeVendidaCOFINS As System.Windows.Forms.Label
    Friend WithEvents txtValorCOFINS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorCOFINS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaPercentualCOFINS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaPercentualCOFINS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaValorCOFINS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaValorCOFINS As System.Windows.Forms.Label
    Friend WithEvents grpSituacaoTributariaCOFINS As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboSituacaoTributariaCOFINS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSituacaoTributariaCOFINS As System.Windows.Forms.Label
    Friend WithEvents pagImpostoImportacao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpII As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorII As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorII As System.Windows.Forms.Label
    Friend WithEvents txtValorIOF As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorIOF As System.Windows.Forms.Label
    Friend WithEvents txtDespesaAduaneiraII As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDespesaAduaneiraII As System.Windows.Forms.Label
    Friend WithEvents txtBaseCalculoII As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblBaseCalculoII As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnSalvarTributos As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltarTributos As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtCodigoEAN As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoEAN As System.Windows.Forms.Label
    Friend WithEvents lblIncideValorTotalNF As System.Windows.Forms.Label
    Friend WithEvents cboIncideValorTotalNF As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents pagICMSSimples As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtCreditoICMSAproveitadoSimples As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCreditoICMSAproveitadoSimples As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaCalculoCreditoICMSSimples As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaCalculoCreditoICMSSimples As System.Windows.Forms.Label
    Friend WithEvents cboOrigemSimples As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblOrigemSimples As System.Windows.Forms.Label
    Friend WithEvents cboSituacaoTributariaICMSSimples As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSituacaoTributariaICMSSimples As System.Windows.Forms.Label
    Friend WithEvents grpICMSSTRetidoSimples As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtBaseCalculoICMSSTRetidoSimples As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblBaseCalculoICMSSTRetidoSimples As System.Windows.Forms.Label
    Friend WithEvents txtValorICMSSTRetidoSimples As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorICMSSTRetidoSimples As System.Windows.Forms.Label
    Friend WithEvents grpICMSSTSimples As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboModalidadeBCICMSSTSimples As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblModalidadeBCICMSSTSimples As System.Windows.Forms.Label
    Friend WithEvents txtBaseCalculoICMSSTSimples As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblBaseCalculoICMSSTSimples As System.Windows.Forms.Label
    Friend WithEvents txtIVASimples As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblIVASimples As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaICMSSTSimples As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaICMSSTSimples As System.Windows.Forms.Label
    Friend WithEvents txtPorcentagemReducaoBCICMSSTSimples As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPorcentagemReducaoBCICMSSTSimples As System.Windows.Forms.Label
    Friend WithEvents grpICMSSimples As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboModalidadeBCICMSSimples As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblModalidadeBCICMSSimples As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaICMSSimples As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaICMSSimples As System.Windows.Forms.Label
    Friend WithEvents txtPorcentagemReducaoBCICMSSimples As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPorcentagemReducaoBCICMSSimples As System.Windows.Forms.Label
    Friend WithEvents txtValorICMSSimples As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorICMSSimples As System.Windows.Forms.Label
    Friend WithEvents txtValorICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorICMS As System.Windows.Forms.Label
    Friend WithEvents txtBaseCalculoICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblBaseCalculoICMS As System.Windows.Forms.Label
    Friend WithEvents txtBaseCalculoICMSSimples As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblBaseCalculoICMSSimples As System.Windows.Forms.Label
    Friend WithEvents grpICMSSTRetido As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtBaseCalculoICMSSTRetido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblBaseCalculoICMSSTRetido As System.Windows.Forms.Label
    Friend WithEvents txtValorICMSSTRetido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorICMSSTRetido As System.Windows.Forms.Label
    Friend WithEvents cboOrigem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblOrigem As System.Windows.Forms.Label
    Friend WithEvents txtInformacoesAdicionais As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblInformacoesAdicionais As System.Windows.Forms.Label
    Friend WithEvents txtOutrasDespesas As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblOutrasDespesas As System.Windows.Forms.Label
    Friend WithEvents txtValorFrete As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorFrete As System.Windows.Forms.Label
    Friend WithEvents txtValorSeguro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorSeguro As System.Windows.Forms.Label
    Friend WithEvents pagEstoque As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpEstoque As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnInserirEstoque As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluirEstoque As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdEstoque As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpSalvarLote As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnSalvarLote As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltarLote As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCadastrarDeposito As System.Windows.Forms.Button
    Friend WithEvents lblDeposito As System.Windows.Forms.Label
    Friend WithEvents cboDeposito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDataFabricacao As System.Windows.Forms.Label
    Friend WithEvents dtpDataFabricacao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblOCCapa As System.Windows.Forms.Label
    Friend WithEvents txtOCCapa As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOCLinha As System.Windows.Forms.Label
    Friend WithEvents txtOCLinha As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataValidade As System.Windows.Forms.Label
    Friend WithEvents dtpDataValidade As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents txtLote As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtQuantidadeLote As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeLote As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeEstoque As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeEstoque As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtFatorConversao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblFatorConversao As System.Windows.Forms.Label
    Friend WithEvents btnConfigurarGridEstoque As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarUnidadeMedidaEstoque As System.Windows.Forms.Button
    Friend WithEvents lblUnidadeMedidaEstoque As System.Windows.Forms.Label
    Friend WithEvents cboUnidadeMedidaEstoque As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtCodigoProdutoFornecedor As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoProdutoFornecedor As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarProduto As System.Windows.Forms.Button
    Friend WithEvents cboProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents btnAtualizarPedidoCompra As System.Windows.Forms.Button
    Friend WithEvents lblQuantidadeDocumento As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeDocumento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents cboNumeroDocumento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoOperacao As System.Windows.Forms.Label
    Friend WithEvents cboTipoOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnAgruparGridEstoque As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
End Class
