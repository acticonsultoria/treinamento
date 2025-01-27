<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEmissaoNFeProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEmissaoNFeProduto))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabProduto = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosItem = New Janus.Windows.EditControls.UIGroupBox()
        Me.grpImportacao = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCodigoFabricante = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoFabricante = New System.Windows.Forms.Label()
        Me.cboNumeroDI = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNumeroDI = New System.Windows.Forms.Label()
        Me.txtOutrasDespesas = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.UiGroupBox6 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNumeroItemPedidoCompra = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtPedidoCompra = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPedidoCompra = New System.Windows.Forms.Label()
        Me.lblNumeroItemPedidoCompra = New System.Windows.Forms.Label()
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
        Me.btnCadastrarItem = New System.Windows.Forms.Button()
        Me.cboCodigo = New Janus.Windows.EditControls.UIComboBox()
        Me.btnCadastrarUnidadeMedida = New System.Windows.Forms.Button()
        Me.btnCadastrarNCM = New System.Windows.Forms.Button()
        Me.btnCadastrarCFOP = New System.Windows.Forms.Button()
        Me.btnProcurarItem = New System.Windows.Forms.Button()
        Me.txtValorTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.txtValorUnitario = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnitario = New System.Windows.Forms.Label()
        Me.lblUnidadeMedida = New System.Windows.Forms.Label()
        Me.cboUnidadeMedida = New Janus.Windows.EditControls.UIComboBox()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.lblNCM = New System.Windows.Forms.Label()
        Me.cboNCM = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCFOP = New System.Windows.Forms.Label()
        Me.cboCFOP = New Janus.Windows.EditControls.UIComboBox()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.grpControleDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkCalculoAutomatico = New Janus.Windows.EditControls.UICheckBox()
        Me.btnInserirDados = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltarDados = New Janus.Windows.EditControls.UIButton()
        Me.pagTributos = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnInserirTributos = New Janus.Windows.EditControls.UIButton()
        Me.btnVoltarTributos = New Janus.Windows.EditControls.UIButton()
        Me.tabTributo = New Janus.Windows.UI.Tab.UITab()
        Me.pagICMS = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpOrigemItem = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboOrigemItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOrigemItem = New System.Windows.Forms.Label()
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
        Me.cboSituacaoTributariaICMS = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSituacaoTributariaICMS = New System.Windows.Forms.Label()
        Me.grpICMS = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorICMS = New System.Windows.Forms.Label()
        Me.txtBaseCalculoICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBaseCalculoICMS = New System.Windows.Forms.Label()
        Me.cboModalidadeBCICMS = New Janus.Windows.EditControls.UIComboBox()
        Me.lblModalidadeBCICMS = New System.Windows.Forms.Label()
        Me.txtAliquotaICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaICMS = New System.Windows.Forms.Label()
        Me.txtPorcentagemReducaoBCICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPorcentagemReducaoBCICMS = New System.Windows.Forms.Label()
        Me.pagICMSSimples = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpOrigemItemSimples = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboOrigemItemSimples = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOrigemItemSimples = New System.Windows.Forms.Label()
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
        Me.cboModalidadeBCICMSSimples = New Janus.Windows.EditControls.UIComboBox()
        Me.lblModalidadeBCICMSSimples = New System.Windows.Forms.Label()
        Me.txtAliquotaICMSSimples = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaICMSSimples = New System.Windows.Forms.Label()
        Me.txtPorcentagemReducaoBCICMSSimples = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPorcentagemReducaoBCICMSSimples = New System.Windows.Forms.Label()
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboSituacaoTributariaICMSSimples = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSituacaoTributariaICMSSimples = New System.Windows.Forms.Label()
        Me.pagICMSPartilha = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpICMSPartilha = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorICMSRemetente = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorICMSRemetente = New System.Windows.Forms.Label()
        Me.txtValorFCP = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorFCP = New System.Windows.Forms.Label()
        Me.txtValorICMSDestino = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorICMSDestino = New System.Windows.Forms.Label()
        Me.txtPercentualICMSPartilha = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPercentualICMSPartilha = New System.Windows.Forms.Label()
        Me.txtPercentualICMSInterestadual = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPercentualICMSInterestadual = New System.Windows.Forms.Label()
        Me.txtPercentualFCPICMSPartilha = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBaseCalculoICMSPartilha = New System.Windows.Forms.Label()
        Me.txtPercentualICMSDestino = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPercentualICMSDestino = New System.Windows.Forms.Label()
        Me.txtBaseCalculoICMSPartilha = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPercentualFCPICMSPartilha = New System.Windows.Forms.Label()
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
        Me.cboCodigoEnquadramento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoEnquadramento = New System.Windows.Forms.Label()
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
        Me.txtAliquotaII = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaII = New System.Windows.Forms.Label()
        Me.txtAliquotaIOF = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaIOF = New System.Windows.Forms.Label()
        Me.txtDespesaAduaneiraII = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDespesaAduaneiraII = New System.Windows.Forms.Label()
        Me.txtBaseCalculoII = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblBaseCalculoII = New System.Windows.Forms.Label()
        CType(Me.tabProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabProduto.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpDadosItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosItem.SuspendLayout()
        CType(Me.grpImportacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpImportacao.SuspendLayout()
        CType(Me.UiGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox6.SuspendLayout()
        CType(Me.grpControleDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleDados.SuspendLayout()
        Me.pagTributos.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.tabTributo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTributo.SuspendLayout()
        Me.pagICMS.SuspendLayout()
        CType(Me.grpOrigemItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOrigemItem.SuspendLayout()
        CType(Me.grpICMSST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpICMSST.SuspendLayout()
        CType(Me.grpSituacaoTributariaICMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSituacaoTributariaICMS.SuspendLayout()
        CType(Me.grpICMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpICMS.SuspendLayout()
        Me.pagICMSSimples.SuspendLayout()
        CType(Me.grpOrigemItemSimples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOrigemItemSimples.SuspendLayout()
        CType(Me.grpICMSSTSimples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpICMSSTSimples.SuspendLayout()
        CType(Me.grpICMSSimples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpICMSSimples.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        Me.pagICMSPartilha.SuspendLayout()
        CType(Me.grpICMSPartilha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpICMSPartilha.SuspendLayout()
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
        'tabProduto
        '
        Me.tabProduto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabProduto.BackColor = System.Drawing.Color.Transparent
        Me.tabProduto.FocusOnClick = False
        Me.tabProduto.Location = New System.Drawing.Point(8, 8)
        Me.tabProduto.Name = "tabProduto"
        Me.tabProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabProduto.ShowFocusRectangle = False
        Me.tabProduto.Size = New System.Drawing.Size(944, 456)
        Me.tabProduto.TabIndex = 0
        Me.tabProduto.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados, Me.pagTributos})
        Me.tabProduto.TabStop = False
        Me.tabProduto.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpDadosItem)
        Me.pagDados.Controls.Add(Me.grpControleDados)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(942, 433)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados"
        '
        'grpDadosItem
        '
        Me.grpDadosItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosItem.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosItem.Controls.Add(Me.grpImportacao)
        Me.grpDadosItem.Controls.Add(Me.txtOutrasDespesas)
        Me.grpDadosItem.Controls.Add(Me.UiGroupBox6)
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
        Me.grpDadosItem.Controls.Add(Me.btnCadastrarItem)
        Me.grpDadosItem.Controls.Add(Me.cboCodigo)
        Me.grpDadosItem.Controls.Add(Me.btnCadastrarUnidadeMedida)
        Me.grpDadosItem.Controls.Add(Me.btnCadastrarNCM)
        Me.grpDadosItem.Controls.Add(Me.btnCadastrarCFOP)
        Me.grpDadosItem.Controls.Add(Me.btnProcurarItem)
        Me.grpDadosItem.Controls.Add(Me.txtValorTotal)
        Me.grpDadosItem.Controls.Add(Me.lblValorTotal)
        Me.grpDadosItem.Controls.Add(Me.txtValorUnitario)
        Me.grpDadosItem.Controls.Add(Me.lblValorUnitario)
        Me.grpDadosItem.Controls.Add(Me.lblUnidadeMedida)
        Me.grpDadosItem.Controls.Add(Me.cboUnidadeMedida)
        Me.grpDadosItem.Controls.Add(Me.txtQuantidade)
        Me.grpDadosItem.Controls.Add(Me.lblQuantidade)
        Me.grpDadosItem.Controls.Add(Me.lblNCM)
        Me.grpDadosItem.Controls.Add(Me.cboNCM)
        Me.grpDadosItem.Controls.Add(Me.lblCFOP)
        Me.grpDadosItem.Controls.Add(Me.cboCFOP)
        Me.grpDadosItem.Controls.Add(Me.txtDescricao)
        Me.grpDadosItem.Controls.Add(Me.lblDescricao)
        Me.grpDadosItem.Controls.Add(Me.lblCodigo)
        Me.grpDadosItem.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosItem.Location = New System.Drawing.Point(8, 4)
        Me.grpDadosItem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDadosItem.Name = "grpDadosItem"
        Me.grpDadosItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosItem.Size = New System.Drawing.Size(926, 367)
        Me.grpDadosItem.TabIndex = 0
        Me.grpDadosItem.Text = "Dados do Item"
        Me.grpDadosItem.VisualStyleManager = Me.vsmMain
        '
        'grpImportacao
        '
        Me.grpImportacao.BackColor = System.Drawing.Color.Transparent
        Me.grpImportacao.Controls.Add(Me.txtCodigoFabricante)
        Me.grpImportacao.Controls.Add(Me.lblCodigoFabricante)
        Me.grpImportacao.Controls.Add(Me.cboNumeroDI)
        Me.grpImportacao.Controls.Add(Me.lblNumeroDI)
        Me.grpImportacao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpImportacao.Location = New System.Drawing.Point(9, 290)
        Me.grpImportacao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpImportacao.Name = "grpImportacao"
        Me.grpImportacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpImportacao.Size = New System.Drawing.Size(312, 67)
        Me.grpImportacao.TabIndex = 36
        Me.grpImportacao.Text = "Dados de Importação"
        Me.grpImportacao.VisualStyleManager = Me.vsmMain
        '
        'txtCodigoFabricante
        '
        Me.txtCodigoFabricante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoFabricante.Location = New System.Drawing.Point(165, 37)
        Me.txtCodigoFabricante.MaxLength = 60
        Me.txtCodigoFabricante.Name = "txtCodigoFabricante"
        Me.txtCodigoFabricante.Size = New System.Drawing.Size(137, 20)
        Me.txtCodigoFabricante.TabIndex = 3
        '
        'lblCodigoFabricante
        '
        Me.lblCodigoFabricante.AutoSize = True
        Me.lblCodigoFabricante.Location = New System.Drawing.Point(162, 20)
        Me.lblCodigoFabricante.Name = "lblCodigoFabricante"
        Me.lblCodigoFabricante.Size = New System.Drawing.Size(97, 14)
        Me.lblCodigoFabricante.TabIndex = 2
        Me.lblCodigoFabricante.Text = "Código Fabricante:"
        '
        'cboNumeroDI
        '
        Me.cboNumeroDI.AutoSize = False
        Me.cboNumeroDI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNumeroDI.Location = New System.Drawing.Point(9, 37)
        Me.cboNumeroDI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboNumeroDI.Name = "cboNumeroDI"
        Me.cboNumeroDI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNumeroDI.Size = New System.Drawing.Size(150, 20)
        Me.cboNumeroDI.TabIndex = 1
        '
        'lblNumeroDI
        '
        Me.lblNumeroDI.AutoSize = True
        Me.lblNumeroDI.BackColor = System.Drawing.Color.Transparent
        Me.lblNumeroDI.Location = New System.Drawing.Point(6, 20)
        Me.lblNumeroDI.Name = "lblNumeroDI"
        Me.lblNumeroDI.Size = New System.Drawing.Size(49, 14)
        Me.lblNumeroDI.TabIndex = 0
        Me.lblNumeroDI.Text = "Nº da DI:"
        '
        'txtOutrasDespesas
        '
        Me.txtOutrasDespesas.DecimalDigits = 2
        Me.txtOutrasDespesas.Location = New System.Drawing.Point(115, 197)
        Me.txtOutrasDespesas.Name = "txtOutrasDespesas"
        Me.txtOutrasDespesas.Size = New System.Drawing.Size(100, 20)
        Me.txtOutrasDespesas.TabIndex = 32
        Me.txtOutrasDespesas.Text = "0,00"
        Me.txtOutrasDespesas.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'UiGroupBox6
        '
        Me.UiGroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox6.Controls.Add(Me.txtNumeroItemPedidoCompra)
        Me.UiGroupBox6.Controls.Add(Me.txtPedidoCompra)
        Me.UiGroupBox6.Controls.Add(Me.lblPedidoCompra)
        Me.UiGroupBox6.Controls.Add(Me.lblNumeroItemPedidoCompra)
        Me.UiGroupBox6.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox6.Location = New System.Drawing.Point(9, 220)
        Me.UiGroupBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UiGroupBox6.Name = "UiGroupBox6"
        Me.UiGroupBox6.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox6.Size = New System.Drawing.Size(312, 67)
        Me.UiGroupBox6.TabIndex = 35
        Me.UiGroupBox6.Text = "Dados de Compra"
        Me.UiGroupBox6.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroItemPedidoCompra
        '
        Me.txtNumeroItemPedidoCompra.DecimalDigits = 0
        Me.txtNumeroItemPedidoCompra.Location = New System.Drawing.Point(165, 37)
        Me.txtNumeroItemPedidoCompra.MaxLength = 6
        Me.txtNumeroItemPedidoCompra.Name = "txtNumeroItemPedidoCompra"
        Me.txtNumeroItemPedidoCompra.Size = New System.Drawing.Size(137, 20)
        Me.txtNumeroItemPedidoCompra.TabIndex = 3
        Me.txtNumeroItemPedidoCompra.Text = "0"
        Me.txtNumeroItemPedidoCompra.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtNumeroItemPedidoCompra.Value = 0
        Me.txtNumeroItemPedidoCompra.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
        '
        'txtPedidoCompra
        '
        Me.txtPedidoCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPedidoCompra.Location = New System.Drawing.Point(9, 37)
        Me.txtPedidoCompra.MaxLength = 15
        Me.txtPedidoCompra.Name = "txtPedidoCompra"
        Me.txtPedidoCompra.Size = New System.Drawing.Size(150, 20)
        Me.txtPedidoCompra.TabIndex = 1
        '
        'lblPedidoCompra
        '
        Me.lblPedidoCompra.AutoSize = True
        Me.lblPedidoCompra.BackColor = System.Drawing.Color.Transparent
        Me.lblPedidoCompra.Location = New System.Drawing.Point(6, 20)
        Me.lblPedidoCompra.Name = "lblPedidoCompra"
        Me.lblPedidoCompra.Size = New System.Drawing.Size(97, 14)
        Me.lblPedidoCompra.TabIndex = 0
        Me.lblPedidoCompra.Text = "Pedido de Compra:"
        '
        'lblNumeroItemPedidoCompra
        '
        Me.lblNumeroItemPedidoCompra.AutoSize = True
        Me.lblNumeroItemPedidoCompra.BackColor = System.Drawing.Color.Transparent
        Me.lblNumeroItemPedidoCompra.Location = New System.Drawing.Point(162, 20)
        Me.lblNumeroItemPedidoCompra.Name = "lblNumeroItemPedidoCompra"
        Me.lblNumeroItemPedidoCompra.Size = New System.Drawing.Size(44, 14)
        Me.lblNumeroItemPedidoCompra.TabIndex = 2
        Me.lblNumeroItemPedidoCompra.Text = "Nº Item:"
        '
        'lblOutrasDespesas
        '
        Me.lblOutrasDespesas.AutoSize = True
        Me.lblOutrasDespesas.Location = New System.Drawing.Point(112, 180)
        Me.lblOutrasDespesas.Name = "lblOutrasDespesas"
        Me.lblOutrasDespesas.Size = New System.Drawing.Size(95, 14)
        Me.lblOutrasDespesas.TabIndex = 31
        Me.lblOutrasDespesas.Text = "Outras Despesas:"
        '
        'txtValorFrete
        '
        Me.txtValorFrete.DecimalDigits = 2
        Me.txtValorFrete.Location = New System.Drawing.Point(221, 157)
        Me.txtValorFrete.Name = "txtValorFrete"
        Me.txtValorFrete.Size = New System.Drawing.Size(100, 20)
        Me.txtValorFrete.TabIndex = 28
        Me.txtValorFrete.Text = "0,00"
        Me.txtValorFrete.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorFrete
        '
        Me.lblValorFrete.AutoSize = True
        Me.lblValorFrete.Location = New System.Drawing.Point(218, 140)
        Me.lblValorFrete.Name = "lblValorFrete"
        Me.lblValorFrete.Size = New System.Drawing.Size(63, 14)
        Me.lblValorFrete.TabIndex = 27
        Me.lblValorFrete.Text = "Valor Frete:"
        '
        'txtValorSeguro
        '
        Me.txtValorSeguro.DecimalDigits = 2
        Me.txtValorSeguro.Location = New System.Drawing.Point(9, 197)
        Me.txtValorSeguro.Name = "txtValorSeguro"
        Me.txtValorSeguro.Size = New System.Drawing.Size(100, 20)
        Me.txtValorSeguro.TabIndex = 30
        Me.txtValorSeguro.Text = "0,00"
        Me.txtValorSeguro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorSeguro
        '
        Me.lblValorSeguro.AutoSize = True
        Me.lblValorSeguro.Location = New System.Drawing.Point(6, 180)
        Me.lblValorSeguro.Name = "lblValorSeguro"
        Me.lblValorSeguro.Size = New System.Drawing.Size(73, 14)
        Me.lblValorSeguro.TabIndex = 29
        Me.lblValorSeguro.Text = "Valor Seguro:"
        '
        'txtInformacoesAdicionais
        '
        Me.txtInformacoesAdicionais.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInformacoesAdicionais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInformacoesAdicionais.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInformacoesAdicionais.Location = New System.Drawing.Point(335, 77)
        Me.txtInformacoesAdicionais.MaxLength = 500
        Me.txtInformacoesAdicionais.Multiline = True
        Me.txtInformacoesAdicionais.Name = "txtInformacoesAdicionais"
        Me.txtInformacoesAdicionais.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInformacoesAdicionais.Size = New System.Drawing.Size(582, 280)
        Me.txtInformacoesAdicionais.TabIndex = 38
        '
        'lblInformacoesAdicionais
        '
        Me.lblInformacoesAdicionais.AutoSize = True
        Me.lblInformacoesAdicionais.Location = New System.Drawing.Point(332, 60)
        Me.lblInformacoesAdicionais.Name = "lblInformacoesAdicionais"
        Me.lblInformacoesAdicionais.Size = New System.Drawing.Size(122, 14)
        Me.lblInformacoesAdicionais.TabIndex = 37
        Me.lblInformacoesAdicionais.Text = "Informações Adicionais:"
        '
        'lblIncideValorTotalNF
        '
        Me.lblIncideValorTotalNF.AutoSize = True
        Me.lblIncideValorTotalNF.Location = New System.Drawing.Point(218, 60)
        Me.lblIncideValorTotalNF.Name = "lblIncideValorTotalNF"
        Me.lblIncideValorTotalNF.Size = New System.Drawing.Size(82, 14)
        Me.lblIncideValorTotalNF.TabIndex = 14
        Me.lblIncideValorTotalNF.Text = "Incide Valor NF:"
        '
        'cboIncideValorTotalNF
        '
        Me.cboIncideValorTotalNF.AutoSize = False
        Me.cboIncideValorTotalNF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboIncideValorTotalNF.Location = New System.Drawing.Point(221, 77)
        Me.cboIncideValorTotalNF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboIncideValorTotalNF.Name = "cboIncideValorTotalNF"
        Me.cboIncideValorTotalNF.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboIncideValorTotalNF.Size = New System.Drawing.Size(100, 20)
        Me.cboIncideValorTotalNF.TabIndex = 15
        Me.cboIncideValorTotalNF.UseCompatibleTextRendering = True
        '
        'txtCodigoEAN
        '
        Me.txtCodigoEAN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigoEAN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoEAN.Location = New System.Drawing.Point(797, 37)
        Me.txtCodigoEAN.MaxLength = 14
        Me.txtCodigoEAN.Name = "txtCodigoEAN"
        Me.txtCodigoEAN.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigoEAN.TabIndex = 7
        '
        'lblCodigoEAN
        '
        Me.lblCodigoEAN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodigoEAN.AutoSize = True
        Me.lblCodigoEAN.Location = New System.Drawing.Point(794, 20)
        Me.lblCodigoEAN.Name = "lblCodigoEAN"
        Me.lblCodigoEAN.Size = New System.Drawing.Size(67, 14)
        Me.lblCodigoEAN.TabIndex = 6
        Me.lblCodigoEAN.Text = "Código EAN:"
        '
        'txtValorDesconto
        '
        Me.txtValorDesconto.DecimalDigits = 2
        Me.txtValorDesconto.Location = New System.Drawing.Point(9, 157)
        Me.txtValorDesconto.Name = "txtValorDesconto"
        Me.txtValorDesconto.Size = New System.Drawing.Size(100, 20)
        Me.txtValorDesconto.TabIndex = 24
        Me.txtValorDesconto.Text = "0,00"
        Me.txtValorDesconto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorDesconto
        '
        Me.lblValorDesconto.AutoSize = True
        Me.lblValorDesconto.Location = New System.Drawing.Point(6, 140)
        Me.lblValorDesconto.Name = "lblValorDesconto"
        Me.lblValorDesconto.Size = New System.Drawing.Size(84, 14)
        Me.lblValorDesconto.TabIndex = 23
        Me.lblValorDesconto.Text = "Valor Desconto:"
        '
        'btnCadastrarItem
        '
        Me.btnCadastrarItem.FlatAppearance.BorderSize = 0
        Me.btnCadastrarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarItem.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarItem.Location = New System.Drawing.Point(9, 21)
        Me.btnCadastrarItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarItem.Name = "btnCadastrarItem"
        Me.btnCadastrarItem.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarItem.TabIndex = 0
        Me.btnCadastrarItem.TabStop = False
        Me.btnCadastrarItem.UseVisualStyleBackColor = True
        '
        'cboCodigo
        '
        Me.cboCodigo.AutoSize = False
        Me.cboCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCodigo.HoverMode = Janus.Windows.EditControls.HoverMode.Highlight
        Me.cboCodigo.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cboCodigo.Location = New System.Drawing.Point(9, 37)
        Me.cboCodigo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCodigo.Name = "cboCodigo"
        Me.cboCodigo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigo.Size = New System.Drawing.Size(206, 20)
        Me.cboCodigo.TabIndex = 3
        '
        'btnCadastrarUnidadeMedida
        '
        Me.btnCadastrarUnidadeMedida.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUnidadeMedida.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarUnidadeMedida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUnidadeMedida.Location = New System.Drawing.Point(115, 101)
        Me.btnCadastrarUnidadeMedida.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUnidadeMedida.Name = "btnCadastrarUnidadeMedida"
        Me.btnCadastrarUnidadeMedida.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarUnidadeMedida.TabIndex = 18
        Me.btnCadastrarUnidadeMedida.TabStop = False
        Me.btnCadastrarUnidadeMedida.UseVisualStyleBackColor = True
        '
        'btnCadastrarNCM
        '
        Me.btnCadastrarNCM.FlatAppearance.BorderSize = 0
        Me.btnCadastrarNCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarNCM.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarNCM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarNCM.Location = New System.Drawing.Point(115, 60)
        Me.btnCadastrarNCM.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarNCM.Name = "btnCadastrarNCM"
        Me.btnCadastrarNCM.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarNCM.TabIndex = 11
        Me.btnCadastrarNCM.TabStop = False
        Me.btnCadastrarNCM.UseVisualStyleBackColor = True
        '
        'btnCadastrarCFOP
        '
        Me.btnCadastrarCFOP.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCFOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCFOP.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCFOP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCFOP.Location = New System.Drawing.Point(9, 60)
        Me.btnCadastrarCFOP.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCFOP.Name = "btnCadastrarCFOP"
        Me.btnCadastrarCFOP.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCFOP.TabIndex = 8
        Me.btnCadastrarCFOP.TabStop = False
        Me.btnCadastrarCFOP.UseVisualStyleBackColor = True
        '
        'btnProcurarItem
        '
        Me.btnProcurarItem.FlatAppearance.BorderSize = 0
        Me.btnProcurarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItem.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItem.Location = New System.Drawing.Point(198, 19)
        Me.btnProcurarItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItem.Name = "btnProcurarItem"
        Me.btnProcurarItem.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItem.TabIndex = 2
        Me.btnProcurarItem.TabStop = False
        Me.btnProcurarItem.UseVisualStyleBackColor = True
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTotal.DecimalDigits = 2
        Me.txtValorTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Location = New System.Drawing.Point(115, 157)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtValorTotal.TabIndex = 26
        Me.txtValorTotal.TabStop = False
        Me.txtValorTotal.Text = "0,00"
        Me.txtValorTotal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.Location = New System.Drawing.Point(112, 140)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(60, 14)
        Me.lblValorTotal.TabIndex = 25
        Me.lblValorTotal.Text = "Valor Total:"
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.DecimalDigits = 7
        Me.txtValorUnitario.Location = New System.Drawing.Point(221, 117)
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.Size = New System.Drawing.Size(100, 20)
        Me.txtValorUnitario.TabIndex = 22
        Me.txtValorUnitario.Text = "0,0000000"
        Me.txtValorUnitario.Value = New Decimal(New Integer() {0, 0, 0, 458752})
        '
        'lblValorUnitario
        '
        Me.lblValorUnitario.AutoSize = True
        Me.lblValorUnitario.Location = New System.Drawing.Point(218, 100)
        Me.lblValorUnitario.Name = "lblValorUnitario"
        Me.lblValorUnitario.Size = New System.Drawing.Size(74, 14)
        Me.lblValorUnitario.TabIndex = 21
        Me.lblValorUnitario.Text = "Valor Unitário:"
        '
        'lblUnidadeMedida
        '
        Me.lblUnidadeMedida.AutoSize = True
        Me.lblUnidadeMedida.Location = New System.Drawing.Point(131, 100)
        Me.lblUnidadeMedida.Name = "lblUnidadeMedida"
        Me.lblUnidadeMedida.Size = New System.Drawing.Size(58, 14)
        Me.lblUnidadeMedida.TabIndex = 19
        Me.lblUnidadeMedida.Text = "Und. Med.:"
        '
        'cboUnidadeMedida
        '
        Me.cboUnidadeMedida.AutoSize = False
        Me.cboUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedida.Location = New System.Drawing.Point(115, 117)
        Me.cboUnidadeMedida.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboUnidadeMedida.Name = "cboUnidadeMedida"
        Me.cboUnidadeMedida.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedida.Size = New System.Drawing.Size(100, 20)
        Me.cboUnidadeMedida.TabIndex = 20
        '
        'txtQuantidade
        '
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(9, 117)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidade.TabIndex = 17
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(6, 100)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 16
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'lblNCM
        '
        Me.lblNCM.AutoSize = True
        Me.lblNCM.Location = New System.Drawing.Point(131, 60)
        Me.lblNCM.Name = "lblNCM"
        Me.lblNCM.Size = New System.Drawing.Size(32, 14)
        Me.lblNCM.TabIndex = 12
        Me.lblNCM.Text = "NCM:"
        '
        'cboNCM
        '
        Me.cboNCM.AutoSize = False
        Me.cboNCM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNCM.Location = New System.Drawing.Point(115, 77)
        Me.cboNCM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboNCM.Name = "cboNCM"
        Me.cboNCM.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNCM.Size = New System.Drawing.Size(100, 20)
        Me.cboNCM.TabIndex = 13
        Me.cboNCM.UseCompatibleTextRendering = True
        '
        'lblCFOP
        '
        Me.lblCFOP.AutoSize = True
        Me.lblCFOP.Location = New System.Drawing.Point(25, 60)
        Me.lblCFOP.Name = "lblCFOP"
        Me.lblCFOP.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOP.TabIndex = 9
        Me.lblCFOP.Text = "CFOP:"
        '
        'cboCFOP
        '
        Me.cboCFOP.AutoSize = False
        Me.cboCFOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCFOP.Location = New System.Drawing.Point(9, 77)
        Me.cboCFOP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCFOP.Name = "cboCFOP"
        Me.cboCFOP.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCFOP.Size = New System.Drawing.Size(100, 20)
        Me.cboCFOP.TabIndex = 10
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(221, 37)
        Me.txtDescricao.MaxLength = 120
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescricao.Size = New System.Drawing.Size(570, 20)
        Me.txtDescricao.TabIndex = 5
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(218, 20)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 4
        Me.lblDescricao.Text = "Descrição:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(25, 20)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "Código:"
        '
        'grpControleDados
        '
        Me.grpControleDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControleDados.BackColor = System.Drawing.Color.Transparent
        Me.grpControleDados.Controls.Add(Me.chkCalculoAutomatico)
        Me.grpControleDados.Controls.Add(Me.btnInserirDados)
        Me.grpControleDados.Controls.Add(Me.btnVoltarDados)
        Me.grpControleDados.Location = New System.Drawing.Point(8, 374)
        Me.grpControleDados.Name = "grpControleDados"
        Me.grpControleDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleDados.Size = New System.Drawing.Size(926, 51)
        Me.grpControleDados.TabIndex = 1
        Me.grpControleDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControleDados.VisualStyleManager = Me.vsmMain
        '
        'chkCalculoAutomatico
        '
        Me.chkCalculoAutomatico.Location = New System.Drawing.Point(9, 23)
        Me.chkCalculoAutomatico.Name = "chkCalculoAutomatico"
        Me.chkCalculoAutomatico.Size = New System.Drawing.Size(234, 16)
        Me.chkCalculoAutomatico.TabIndex = 0
        Me.chkCalculoAutomatico.Text = "Sistema Cálcula Imposto Automaticamente"
        '
        'btnInserirDados
        '
        Me.btnInserirDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirDados.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirDados.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirDados.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirDados.Location = New System.Drawing.Point(729, 17)
        Me.btnInserirDados.Name = "btnInserirDados"
        Me.btnInserirDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirDados.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirDados.TabIndex = 1
        Me.btnInserirDados.Text = "Inserir"
        Me.btnInserirDados.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltarDados
        '
        Me.btnVoltarDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltarDados.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltarDados.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltarDados.Location = New System.Drawing.Point(826, 17)
        Me.btnVoltarDados.Name = "btnVoltarDados"
        Me.btnVoltarDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVoltarDados.Size = New System.Drawing.Size(91, 23)
        Me.btnVoltarDados.TabIndex = 2
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
        Me.pagTributos.Size = New System.Drawing.Size(942, 433)
        Me.pagTributos.TabStop = True
        Me.pagTributos.Text = "Tributos"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.btnInserirTributos)
        Me.UiGroupBox1.Controls.Add(Me.btnVoltarTributos)
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 374)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(926, 51)
        Me.UiGroupBox1.TabIndex = 1
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'btnInserirTributos
        '
        Me.btnInserirTributos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirTributos.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirTributos.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirTributos.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirTributos.Location = New System.Drawing.Point(729, 17)
        Me.btnInserirTributos.Name = "btnInserirTributos"
        Me.btnInserirTributos.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirTributos.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirTributos.TabIndex = 0
        Me.btnInserirTributos.Text = "Inserir"
        Me.btnInserirTributos.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVoltarTributos
        '
        Me.btnVoltarTributos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoltarTributos.Image = Global.INTERACTI.My.Resources.Resources.seta_esquerda
        Me.btnVoltarTributos.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVoltarTributos.Location = New System.Drawing.Point(826, 17)
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
        Me.tabTributo.Size = New System.Drawing.Size(926, 364)
        Me.tabTributo.TabIndex = 0
        Me.tabTributo.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagICMS, Me.pagICMSSimples, Me.pagICMSPartilha, Me.pagIPI, Me.pagPIS, Me.pagCOFINS, Me.pagImpostoImportacao})
        Me.tabTributo.TabStop = False
        Me.tabTributo.VisualStyleManager = Me.vsmMain
        '
        'pagICMS
        '
        Me.pagICMS.Controls.Add(Me.grpOrigemItem)
        Me.pagICMS.Controls.Add(Me.grpICMSST)
        Me.pagICMS.Controls.Add(Me.grpSituacaoTributariaICMS)
        Me.pagICMS.Controls.Add(Me.grpICMS)
        Me.pagICMS.Key = "pagICMS"
        Me.pagICMS.Location = New System.Drawing.Point(1, 22)
        Me.pagICMS.Name = "pagICMS"
        Me.pagICMS.Size = New System.Drawing.Size(924, 341)
        Me.pagICMS.TabStop = True
        Me.pagICMS.Text = "ICMS"
        '
        'grpOrigemItem
        '
        Me.grpOrigemItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOrigemItem.BackColor = System.Drawing.Color.Transparent
        Me.grpOrigemItem.Controls.Add(Me.cboOrigemItem)
        Me.grpOrigemItem.Controls.Add(Me.lblOrigemItem)
        Me.grpOrigemItem.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpOrigemItem.Location = New System.Drawing.Point(8, 3)
        Me.grpOrigemItem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpOrigemItem.Name = "grpOrigemItem"
        Me.grpOrigemItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpOrigemItem.Size = New System.Drawing.Size(908, 67)
        Me.grpOrigemItem.TabIndex = 0
        Me.grpOrigemItem.Text = "Origem do Item"
        Me.grpOrigemItem.VisualStyleManager = Me.vsmMain
        '
        'cboOrigemItem
        '
        Me.cboOrigemItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboOrigemItem.AutoSize = False
        Me.cboOrigemItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOrigemItem.Location = New System.Drawing.Point(9, 37)
        Me.cboOrigemItem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboOrigemItem.Name = "cboOrigemItem"
        Me.cboOrigemItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboOrigemItem.Size = New System.Drawing.Size(890, 20)
        Me.cboOrigemItem.TabIndex = 1
        '
        'lblOrigemItem
        '
        Me.lblOrigemItem.AutoSize = True
        Me.lblOrigemItem.BackColor = System.Drawing.Color.Transparent
        Me.lblOrigemItem.Location = New System.Drawing.Point(6, 20)
        Me.lblOrigemItem.Name = "lblOrigemItem"
        Me.lblOrigemItem.Size = New System.Drawing.Size(81, 14)
        Me.lblOrigemItem.TabIndex = 0
        Me.lblOrigemItem.Text = "Origem do Item:"
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
        Me.grpICMSST.Location = New System.Drawing.Point(8, 213)
        Me.grpICMSST.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpICMSST.Name = "grpICMSST"
        Me.grpICMSST.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpICMSST.Size = New System.Drawing.Size(908, 67)
        Me.grpICMSST.TabIndex = 3
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
        Me.cboModalidadeBCICMSST.Size = New System.Drawing.Size(240, 20)
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
        Me.txtBaseCalculoICMSST.Location = New System.Drawing.Point(501, 37)
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
        Me.lblBaseCalculoICMSST.Location = New System.Drawing.Point(498, 20)
        Me.lblBaseCalculoICMSST.Name = "lblBaseCalculoICMSST"
        Me.lblBaseCalculoICMSST.Size = New System.Drawing.Size(66, 14)
        Me.lblBaseCalculoICMSST.TabIndex = 6
        Me.lblBaseCalculoICMSST.Text = "BC ICMS ST:"
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(255, 37)
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
        Me.lblIVA.Location = New System.Drawing.Point(252, 20)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(27, 14)
        Me.lblIVA.TabIndex = 2
        Me.lblIVA.Text = "IVA:"
        '
        'txtAliquotaICMSST
        '
        Me.txtAliquotaICMSST.Location = New System.Drawing.Point(624, 37)
        Me.txtAliquotaICMSST.Name = "txtAliquotaICMSST"
        Me.txtAliquotaICMSST.Size = New System.Drawing.Size(117, 20)
        Me.txtAliquotaICMSST.TabIndex = 9
        Me.txtAliquotaICMSST.Tag = ""
        Me.txtAliquotaICMSST.Text = "0,00"
        Me.txtAliquotaICMSST.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaICMSST
        '
        Me.lblAliquotaICMSST.AutoSize = True
        Me.lblAliquotaICMSST.Location = New System.Drawing.Point(621, 20)
        Me.lblAliquotaICMSST.Name = "lblAliquotaICMSST"
        Me.lblAliquotaICMSST.Size = New System.Drawing.Size(91, 14)
        Me.lblAliquotaICMSST.TabIndex = 8
        Me.lblAliquotaICMSST.Text = "Alíquota ICMS ST:"
        '
        'txtPorcentagemReducaoBCICMSST
        '
        Me.txtPorcentagemReducaoBCICMSST.Location = New System.Drawing.Point(378, 37)
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
        Me.lblPorcentagemReducaoBCICMSST.Location = New System.Drawing.Point(375, 20)
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
        Me.grpSituacaoTributariaICMS.Controls.Add(Me.cboSituacaoTributariaICMS)
        Me.grpSituacaoTributariaICMS.Controls.Add(Me.lblSituacaoTributariaICMS)
        Me.grpSituacaoTributariaICMS.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpSituacaoTributariaICMS.Location = New System.Drawing.Point(8, 73)
        Me.grpSituacaoTributariaICMS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSituacaoTributariaICMS.Name = "grpSituacaoTributariaICMS"
        Me.grpSituacaoTributariaICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSituacaoTributariaICMS.Size = New System.Drawing.Size(908, 67)
        Me.grpSituacaoTributariaICMS.TabIndex = 1
        Me.grpSituacaoTributariaICMS.Text = "Situação Tributária do ICMS"
        Me.grpSituacaoTributariaICMS.VisualStyleManager = Me.vsmMain
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
        Me.cboSituacaoTributariaICMS.Size = New System.Drawing.Size(890, 20)
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
        Me.grpICMS.Controls.Add(Me.txtValorICMS)
        Me.grpICMS.Controls.Add(Me.lblValorICMS)
        Me.grpICMS.Controls.Add(Me.txtBaseCalculoICMS)
        Me.grpICMS.Controls.Add(Me.lblBaseCalculoICMS)
        Me.grpICMS.Controls.Add(Me.cboModalidadeBCICMS)
        Me.grpICMS.Controls.Add(Me.lblModalidadeBCICMS)
        Me.grpICMS.Controls.Add(Me.txtAliquotaICMS)
        Me.grpICMS.Controls.Add(Me.lblAliquotaICMS)
        Me.grpICMS.Controls.Add(Me.txtPorcentagemReducaoBCICMS)
        Me.grpICMS.Controls.Add(Me.lblPorcentagemReducaoBCICMS)
        Me.grpICMS.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpICMS.Location = New System.Drawing.Point(8, 143)
        Me.grpICMS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpICMS.Name = "grpICMS"
        Me.grpICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpICMS.Size = New System.Drawing.Size(908, 67)
        Me.grpICMS.TabIndex = 2
        Me.grpICMS.Text = "ICMS"
        Me.grpICMS.VisualStyleManager = Me.vsmMain
        '
        'txtValorICMS
        '
        Me.txtValorICMS.Location = New System.Drawing.Point(624, 37)
        Me.txtValorICMS.Name = "txtValorICMS"
        Me.txtValorICMS.Size = New System.Drawing.Size(117, 20)
        Me.txtValorICMS.TabIndex = 9
        Me.txtValorICMS.Tag = ""
        Me.txtValorICMS.Text = "0,00"
        Me.txtValorICMS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorICMS
        '
        Me.lblValorICMS.AutoSize = True
        Me.lblValorICMS.Location = New System.Drawing.Point(621, 20)
        Me.lblValorICMS.Name = "lblValorICMS"
        Me.lblValorICMS.Size = New System.Drawing.Size(62, 14)
        Me.lblValorICMS.TabIndex = 8
        Me.lblValorICMS.Text = "Valor ICMS:"
        '
        'txtBaseCalculoICMS
        '
        Me.txtBaseCalculoICMS.Location = New System.Drawing.Point(378, 37)
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
        Me.lblBaseCalculoICMS.Location = New System.Drawing.Point(375, 20)
        Me.lblBaseCalculoICMS.Name = "lblBaseCalculoICMS"
        Me.lblBaseCalculoICMS.Size = New System.Drawing.Size(51, 14)
        Me.lblBaseCalculoICMS.TabIndex = 4
        Me.lblBaseCalculoICMS.Text = "BC ICMS:"
        '
        'cboModalidadeBCICMS
        '
        Me.cboModalidadeBCICMS.AutoSize = False
        Me.cboModalidadeBCICMS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboModalidadeBCICMS.Location = New System.Drawing.Point(9, 37)
        Me.cboModalidadeBCICMS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboModalidadeBCICMS.Name = "cboModalidadeBCICMS"
        Me.cboModalidadeBCICMS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboModalidadeBCICMS.Size = New System.Drawing.Size(240, 20)
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
        Me.txtAliquotaICMS.Location = New System.Drawing.Point(501, 37)
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
        Me.lblAliquotaICMS.Location = New System.Drawing.Point(498, 20)
        Me.lblAliquotaICMS.Name = "lblAliquotaICMS"
        Me.lblAliquotaICMS.Size = New System.Drawing.Size(76, 14)
        Me.lblAliquotaICMS.TabIndex = 6
        Me.lblAliquotaICMS.Text = "Alíquota ICMS:"
        '
        'txtPorcentagemReducaoBCICMS
        '
        Me.txtPorcentagemReducaoBCICMS.Location = New System.Drawing.Point(255, 37)
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
        Me.lblPorcentagemReducaoBCICMS.Location = New System.Drawing.Point(252, 20)
        Me.lblPorcentagemReducaoBCICMS.Name = "lblPorcentagemReducaoBCICMS"
        Me.lblPorcentagemReducaoBCICMS.Size = New System.Drawing.Size(89, 14)
        Me.lblPorcentagemReducaoBCICMS.TabIndex = 2
        Me.lblPorcentagemReducaoBCICMS.Text = "% Red. BC ICMS:"
        '
        'pagICMSSimples
        '
        Me.pagICMSSimples.Controls.Add(Me.grpOrigemItemSimples)
        Me.pagICMSSimples.Controls.Add(Me.grpICMSSTSimples)
        Me.pagICMSSimples.Controls.Add(Me.grpICMSSimples)
        Me.pagICMSSimples.Controls.Add(Me.UiGroupBox3)
        Me.pagICMSSimples.Key = "pagICMSSimples"
        Me.pagICMSSimples.Location = New System.Drawing.Point(1, 22)
        Me.pagICMSSimples.Name = "pagICMSSimples"
        Me.pagICMSSimples.Size = New System.Drawing.Size(924, 341)
        Me.pagICMSSimples.TabStop = True
        Me.pagICMSSimples.Text = "ICMS"
        '
        'grpOrigemItemSimples
        '
        Me.grpOrigemItemSimples.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpOrigemItemSimples.BackColor = System.Drawing.Color.Transparent
        Me.grpOrigemItemSimples.Controls.Add(Me.cboOrigemItemSimples)
        Me.grpOrigemItemSimples.Controls.Add(Me.lblOrigemItemSimples)
        Me.grpOrigemItemSimples.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpOrigemItemSimples.Location = New System.Drawing.Point(8, 3)
        Me.grpOrigemItemSimples.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpOrigemItemSimples.Name = "grpOrigemItemSimples"
        Me.grpOrigemItemSimples.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpOrigemItemSimples.Size = New System.Drawing.Size(908, 67)
        Me.grpOrigemItemSimples.TabIndex = 0
        Me.grpOrigemItemSimples.Text = "Origem do Item"
        Me.grpOrigemItemSimples.VisualStyleManager = Me.vsmMain
        '
        'cboOrigemItemSimples
        '
        Me.cboOrigemItemSimples.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboOrigemItemSimples.AutoSize = False
        Me.cboOrigemItemSimples.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOrigemItemSimples.Location = New System.Drawing.Point(9, 37)
        Me.cboOrigemItemSimples.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboOrigemItemSimples.Name = "cboOrigemItemSimples"
        Me.cboOrigemItemSimples.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboOrigemItemSimples.Size = New System.Drawing.Size(890, 20)
        Me.cboOrigemItemSimples.TabIndex = 1
        '
        'lblOrigemItemSimples
        '
        Me.lblOrigemItemSimples.AutoSize = True
        Me.lblOrigemItemSimples.BackColor = System.Drawing.Color.Transparent
        Me.lblOrigemItemSimples.Location = New System.Drawing.Point(6, 20)
        Me.lblOrigemItemSimples.Name = "lblOrigemItemSimples"
        Me.lblOrigemItemSimples.Size = New System.Drawing.Size(81, 14)
        Me.lblOrigemItemSimples.TabIndex = 0
        Me.lblOrigemItemSimples.Text = "Origem do Item:"
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
        Me.grpICMSSTSimples.Location = New System.Drawing.Point(8, 213)
        Me.grpICMSSTSimples.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpICMSSTSimples.Name = "grpICMSSTSimples"
        Me.grpICMSSTSimples.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpICMSSTSimples.Size = New System.Drawing.Size(908, 67)
        Me.grpICMSSTSimples.TabIndex = 3
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
        Me.cboModalidadeBCICMSSTSimples.Size = New System.Drawing.Size(240, 20)
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
        Me.txtBaseCalculoICMSSTSimples.Location = New System.Drawing.Point(501, 37)
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
        Me.lblBaseCalculoICMSSTSimples.Location = New System.Drawing.Point(498, 20)
        Me.lblBaseCalculoICMSSTSimples.Name = "lblBaseCalculoICMSSTSimples"
        Me.lblBaseCalculoICMSSTSimples.Size = New System.Drawing.Size(66, 14)
        Me.lblBaseCalculoICMSSTSimples.TabIndex = 6
        Me.lblBaseCalculoICMSSTSimples.Text = "BC ICMS ST:"
        '
        'txtIVASimples
        '
        Me.txtIVASimples.Enabled = False
        Me.txtIVASimples.Location = New System.Drawing.Point(255, 37)
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
        Me.lblIVASimples.Location = New System.Drawing.Point(252, 20)
        Me.lblIVASimples.Name = "lblIVASimples"
        Me.lblIVASimples.Size = New System.Drawing.Size(27, 14)
        Me.lblIVASimples.TabIndex = 2
        Me.lblIVASimples.Text = "IVA:"
        '
        'txtAliquotaICMSSTSimples
        '
        Me.txtAliquotaICMSSTSimples.Enabled = False
        Me.txtAliquotaICMSSTSimples.Location = New System.Drawing.Point(624, 37)
        Me.txtAliquotaICMSSTSimples.Name = "txtAliquotaICMSSTSimples"
        Me.txtAliquotaICMSSTSimples.Size = New System.Drawing.Size(117, 20)
        Me.txtAliquotaICMSSTSimples.TabIndex = 9
        Me.txtAliquotaICMSSTSimples.Tag = ""
        Me.txtAliquotaICMSSTSimples.Text = "0,00"
        Me.txtAliquotaICMSSTSimples.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaICMSSTSimples
        '
        Me.lblAliquotaICMSSTSimples.AutoSize = True
        Me.lblAliquotaICMSSTSimples.Location = New System.Drawing.Point(621, 20)
        Me.lblAliquotaICMSSTSimples.Name = "lblAliquotaICMSSTSimples"
        Me.lblAliquotaICMSSTSimples.Size = New System.Drawing.Size(91, 14)
        Me.lblAliquotaICMSSTSimples.TabIndex = 8
        Me.lblAliquotaICMSSTSimples.Text = "Alíquota ICMS ST:"
        '
        'txtPorcentagemReducaoBCICMSSTSimples
        '
        Me.txtPorcentagemReducaoBCICMSSTSimples.Enabled = False
        Me.txtPorcentagemReducaoBCICMSSTSimples.Location = New System.Drawing.Point(378, 37)
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
        Me.lblPorcentagemReducaoBCICMSSTSimples.Location = New System.Drawing.Point(375, 20)
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
        Me.grpICMSSimples.Controls.Add(Me.cboModalidadeBCICMSSimples)
        Me.grpICMSSimples.Controls.Add(Me.lblModalidadeBCICMSSimples)
        Me.grpICMSSimples.Controls.Add(Me.txtAliquotaICMSSimples)
        Me.grpICMSSimples.Controls.Add(Me.lblAliquotaICMSSimples)
        Me.grpICMSSimples.Controls.Add(Me.txtPorcentagemReducaoBCICMSSimples)
        Me.grpICMSSimples.Controls.Add(Me.lblPorcentagemReducaoBCICMSSimples)
        Me.grpICMSSimples.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpICMSSimples.Location = New System.Drawing.Point(8, 143)
        Me.grpICMSSimples.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpICMSSimples.Name = "grpICMSSimples"
        Me.grpICMSSimples.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpICMSSimples.Size = New System.Drawing.Size(908, 67)
        Me.grpICMSSimples.TabIndex = 2
        Me.grpICMSSimples.Text = "ICMS"
        Me.grpICMSSimples.VisualStyleManager = Me.vsmMain
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
        Me.cboModalidadeBCICMSSimples.Size = New System.Drawing.Size(240, 20)
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
        Me.txtAliquotaICMSSimples.Location = New System.Drawing.Point(378, 37)
        Me.txtAliquotaICMSSimples.Name = "txtAliquotaICMSSimples"
        Me.txtAliquotaICMSSimples.Size = New System.Drawing.Size(117, 20)
        Me.txtAliquotaICMSSimples.TabIndex = 5
        Me.txtAliquotaICMSSimples.Tag = ""
        Me.txtAliquotaICMSSimples.Text = "0,00"
        Me.txtAliquotaICMSSimples.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaICMSSimples
        '
        Me.lblAliquotaICMSSimples.AutoSize = True
        Me.lblAliquotaICMSSimples.Location = New System.Drawing.Point(375, 20)
        Me.lblAliquotaICMSSimples.Name = "lblAliquotaICMSSimples"
        Me.lblAliquotaICMSSimples.Size = New System.Drawing.Size(76, 14)
        Me.lblAliquotaICMSSimples.TabIndex = 4
        Me.lblAliquotaICMSSimples.Text = "Alíquota ICMS:"
        '
        'txtPorcentagemReducaoBCICMSSimples
        '
        Me.txtPorcentagemReducaoBCICMSSimples.Enabled = False
        Me.txtPorcentagemReducaoBCICMSSimples.Location = New System.Drawing.Point(255, 37)
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
        Me.lblPorcentagemReducaoBCICMSSimples.Location = New System.Drawing.Point(252, 20)
        Me.lblPorcentagemReducaoBCICMSSimples.Name = "lblPorcentagemReducaoBCICMSSimples"
        Me.lblPorcentagemReducaoBCICMSSimples.Size = New System.Drawing.Size(89, 14)
        Me.lblPorcentagemReducaoBCICMSSimples.TabIndex = 2
        Me.lblPorcentagemReducaoBCICMSSimples.Text = "% Red. BC ICMS:"
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox3.Controls.Add(Me.cboSituacaoTributariaICMSSimples)
        Me.UiGroupBox3.Controls.Add(Me.lblSituacaoTributariaICMSSimples)
        Me.UiGroupBox3.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox3.Location = New System.Drawing.Point(8, 73)
        Me.UiGroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox3.Size = New System.Drawing.Size(908, 67)
        Me.UiGroupBox3.TabIndex = 1
        Me.UiGroupBox3.Text = "Situação Tributária do ICMS"
        Me.UiGroupBox3.VisualStyleManager = Me.vsmMain
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
        Me.cboSituacaoTributariaICMSSimples.Size = New System.Drawing.Size(890, 20)
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
        'pagICMSPartilha
        '
        Me.pagICMSPartilha.Controls.Add(Me.grpICMSPartilha)
        Me.pagICMSPartilha.Location = New System.Drawing.Point(1, 22)
        Me.pagICMSPartilha.Name = "pagICMSPartilha"
        Me.pagICMSPartilha.Size = New System.Drawing.Size(924, 341)
        Me.pagICMSPartilha.TabStop = True
        Me.pagICMSPartilha.Text = "ICMS Partilha"
        '
        'grpICMSPartilha
        '
        Me.grpICMSPartilha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpICMSPartilha.BackColor = System.Drawing.Color.Transparent
        Me.grpICMSPartilha.Controls.Add(Me.txtValorICMSRemetente)
        Me.grpICMSPartilha.Controls.Add(Me.lblValorICMSRemetente)
        Me.grpICMSPartilha.Controls.Add(Me.txtValorFCP)
        Me.grpICMSPartilha.Controls.Add(Me.lblValorFCP)
        Me.grpICMSPartilha.Controls.Add(Me.txtValorICMSDestino)
        Me.grpICMSPartilha.Controls.Add(Me.lblValorICMSDestino)
        Me.grpICMSPartilha.Controls.Add(Me.txtPercentualICMSPartilha)
        Me.grpICMSPartilha.Controls.Add(Me.lblPercentualICMSPartilha)
        Me.grpICMSPartilha.Controls.Add(Me.txtPercentualICMSInterestadual)
        Me.grpICMSPartilha.Controls.Add(Me.lblPercentualICMSInterestadual)
        Me.grpICMSPartilha.Controls.Add(Me.txtPercentualFCPICMSPartilha)
        Me.grpICMSPartilha.Controls.Add(Me.lblBaseCalculoICMSPartilha)
        Me.grpICMSPartilha.Controls.Add(Me.txtPercentualICMSDestino)
        Me.grpICMSPartilha.Controls.Add(Me.lblPercentualICMSDestino)
        Me.grpICMSPartilha.Controls.Add(Me.txtBaseCalculoICMSPartilha)
        Me.grpICMSPartilha.Controls.Add(Me.lblPercentualFCPICMSPartilha)
        Me.grpICMSPartilha.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpICMSPartilha.Location = New System.Drawing.Point(8, 4)
        Me.grpICMSPartilha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpICMSPartilha.Name = "grpICMSPartilha"
        Me.grpICMSPartilha.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpICMSPartilha.Size = New System.Drawing.Size(908, 147)
        Me.grpICMSPartilha.TabIndex = 0
        Me.grpICMSPartilha.Text = "ICMS"
        Me.grpICMSPartilha.VisualStyleManager = Me.vsmMain
        '
        'txtValorICMSRemetente
        '
        Me.txtValorICMSRemetente.Location = New System.Drawing.Point(441, 114)
        Me.txtValorICMSRemetente.Name = "txtValorICMSRemetente"
        Me.txtValorICMSRemetente.Size = New System.Drawing.Size(191, 20)
        Me.txtValorICMSRemetente.TabIndex = 15
        Me.txtValorICMSRemetente.Tag = ""
        Me.txtValorICMSRemetente.Text = "0,00"
        Me.txtValorICMSRemetente.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorICMSRemetente
        '
        Me.lblValorICMSRemetente.AutoSize = True
        Me.lblValorICMSRemetente.Location = New System.Drawing.Point(438, 97)
        Me.lblValorICMSRemetente.Name = "lblValorICMSRemetente"
        Me.lblValorICMSRemetente.Size = New System.Drawing.Size(116, 14)
        Me.lblValorICMSRemetente.TabIndex = 14
        Me.lblValorICMSRemetente.Text = "Valor ICMS Remetente:"
        '
        'txtValorFCP
        '
        Me.txtValorFCP.Location = New System.Drawing.Point(9, 114)
        Me.txtValorFCP.Name = "txtValorFCP"
        Me.txtValorFCP.Size = New System.Drawing.Size(199, 20)
        Me.txtValorFCP.TabIndex = 11
        Me.txtValorFCP.Tag = ""
        Me.txtValorFCP.Text = "0,00"
        Me.txtValorFCP.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorFCP
        '
        Me.lblValorFCP.AutoSize = True
        Me.lblValorFCP.Location = New System.Drawing.Point(6, 97)
        Me.lblValorFCP.Name = "lblValorFCP"
        Me.lblValorFCP.Size = New System.Drawing.Size(57, 14)
        Me.lblValorFCP.TabIndex = 10
        Me.lblValorFCP.Text = "Valor FCP:"
        '
        'txtValorICMSDestino
        '
        Me.txtValorICMSDestino.Location = New System.Drawing.Point(217, 114)
        Me.txtValorICMSDestino.Name = "txtValorICMSDestino"
        Me.txtValorICMSDestino.Size = New System.Drawing.Size(218, 20)
        Me.txtValorICMSDestino.TabIndex = 13
        Me.txtValorICMSDestino.Tag = ""
        Me.txtValorICMSDestino.Text = "0,00"
        Me.txtValorICMSDestino.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorICMSDestino
        '
        Me.lblValorICMSDestino.AutoSize = True
        Me.lblValorICMSDestino.Location = New System.Drawing.Point(214, 97)
        Me.lblValorICMSDestino.Name = "lblValorICMSDestino"
        Me.lblValorICMSDestino.Size = New System.Drawing.Size(101, 14)
        Me.lblValorICMSDestino.TabIndex = 12
        Me.lblValorICMSDestino.Text = "Valor ICMS Destino:"
        '
        'txtPercentualICMSPartilha
        '
        Me.txtPercentualICMSPartilha.Location = New System.Drawing.Point(215, 34)
        Me.txtPercentualICMSPartilha.Name = "txtPercentualICMSPartilha"
        Me.txtPercentualICMSPartilha.Size = New System.Drawing.Size(220, 20)
        Me.txtPercentualICMSPartilha.TabIndex = 3
        Me.txtPercentualICMSPartilha.Tag = ""
        Me.txtPercentualICMSPartilha.Text = "0,00"
        Me.txtPercentualICMSPartilha.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPercentualICMSPartilha
        '
        Me.lblPercentualICMSPartilha.AutoSize = True
        Me.lblPercentualICMSPartilha.Location = New System.Drawing.Point(212, 17)
        Me.lblPercentualICMSPartilha.Name = "lblPercentualICMSPartilha"
        Me.lblPercentualICMSPartilha.Size = New System.Drawing.Size(85, 14)
        Me.lblPercentualICMSPartilha.TabIndex = 2
        Me.lblPercentualICMSPartilha.Text = "% ICMS Partilha:"
        '
        'txtPercentualICMSInterestadual
        '
        Me.txtPercentualICMSInterestadual.Location = New System.Drawing.Point(441, 74)
        Me.txtPercentualICMSInterestadual.Name = "txtPercentualICMSInterestadual"
        Me.txtPercentualICMSInterestadual.Size = New System.Drawing.Size(191, 20)
        Me.txtPercentualICMSInterestadual.TabIndex = 9
        Me.txtPercentualICMSInterestadual.Tag = ""
        Me.txtPercentualICMSInterestadual.Text = "0,00"
        Me.txtPercentualICMSInterestadual.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPercentualICMSInterestadual
        '
        Me.lblPercentualICMSInterestadual.AutoSize = True
        Me.lblPercentualICMSInterestadual.Location = New System.Drawing.Point(438, 57)
        Me.lblPercentualICMSInterestadual.Name = "lblPercentualICMSInterestadual"
        Me.lblPercentualICMSInterestadual.Size = New System.Drawing.Size(112, 14)
        Me.lblPercentualICMSInterestadual.TabIndex = 8
        Me.lblPercentualICMSInterestadual.Text = "% ICMS Interestadual:"
        '
        'txtPercentualFCPICMSPartilha
        '
        Me.txtPercentualFCPICMSPartilha.Location = New System.Drawing.Point(9, 74)
        Me.txtPercentualFCPICMSPartilha.Name = "txtPercentualFCPICMSPartilha"
        Me.txtPercentualFCPICMSPartilha.Size = New System.Drawing.Size(200, 20)
        Me.txtPercentualFCPICMSPartilha.TabIndex = 5
        Me.txtPercentualFCPICMSPartilha.Tag = ""
        Me.txtPercentualFCPICMSPartilha.Text = "0,00"
        Me.txtPercentualFCPICMSPartilha.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblBaseCalculoICMSPartilha
        '
        Me.lblBaseCalculoICMSPartilha.AutoSize = True
        Me.lblBaseCalculoICMSPartilha.Location = New System.Drawing.Point(6, 17)
        Me.lblBaseCalculoICMSPartilha.Name = "lblBaseCalculoICMSPartilha"
        Me.lblBaseCalculoICMSPartilha.Size = New System.Drawing.Size(51, 14)
        Me.lblBaseCalculoICMSPartilha.TabIndex = 0
        Me.lblBaseCalculoICMSPartilha.Text = "BC ICMS:"
        '
        'txtPercentualICMSDestino
        '
        Me.txtPercentualICMSDestino.Location = New System.Drawing.Point(215, 74)
        Me.txtPercentualICMSDestino.Name = "txtPercentualICMSDestino"
        Me.txtPercentualICMSDestino.Size = New System.Drawing.Size(220, 20)
        Me.txtPercentualICMSDestino.TabIndex = 7
        Me.txtPercentualICMSDestino.Tag = ""
        Me.txtPercentualICMSDestino.Text = "0,00"
        Me.txtPercentualICMSDestino.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPercentualICMSDestino
        '
        Me.lblPercentualICMSDestino.AutoSize = True
        Me.lblPercentualICMSDestino.Location = New System.Drawing.Point(212, 57)
        Me.lblPercentualICMSDestino.Name = "lblPercentualICMSDestino"
        Me.lblPercentualICMSDestino.Size = New System.Drawing.Size(86, 14)
        Me.lblPercentualICMSDestino.TabIndex = 6
        Me.lblPercentualICMSDestino.Text = "% ICMS Destino:"
        '
        'txtBaseCalculoICMSPartilha
        '
        Me.txtBaseCalculoICMSPartilha.Location = New System.Drawing.Point(9, 34)
        Me.txtBaseCalculoICMSPartilha.Name = "txtBaseCalculoICMSPartilha"
        Me.txtBaseCalculoICMSPartilha.Size = New System.Drawing.Size(200, 20)
        Me.txtBaseCalculoICMSPartilha.TabIndex = 1
        Me.txtBaseCalculoICMSPartilha.Tag = ""
        Me.txtBaseCalculoICMSPartilha.Text = "0,00"
        Me.txtBaseCalculoICMSPartilha.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPercentualFCPICMSPartilha
        '
        Me.lblPercentualFCPICMSPartilha.AutoSize = True
        Me.lblPercentualFCPICMSPartilha.Location = New System.Drawing.Point(6, 57)
        Me.lblPercentualFCPICMSPartilha.Name = "lblPercentualFCPICMSPartilha"
        Me.lblPercentualFCPICMSPartilha.Size = New System.Drawing.Size(42, 14)
        Me.lblPercentualFCPICMSPartilha.TabIndex = 4
        Me.lblPercentualFCPICMSPartilha.Text = "% FCP:"
        '
        'pagIPI
        '
        Me.pagIPI.Controls.Add(Me.grpValoresIPI)
        Me.pagIPI.Controls.Add(Me.grpSituacaoTributariaIPI)
        Me.pagIPI.Key = "pagIPI"
        Me.pagIPI.Location = New System.Drawing.Point(1, 22)
        Me.pagIPI.Name = "pagIPI"
        Me.pagIPI.Size = New System.Drawing.Size(924, 341)
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
        Me.grpValoresIPI.Size = New System.Drawing.Size(908, 67)
        Me.grpValoresIPI.TabIndex = 1
        Me.grpValoresIPI.Text = "Valores"
        Me.grpValoresIPI.VisualStyleManager = Me.vsmMain
        '
        'txtValorUnidadeIPI
        '
        Me.txtValorUnidadeIPI.DecimalDigits = 4
        Me.txtValorUnidadeIPI.Enabled = False
        Me.txtValorUnidadeIPI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorUnidadeIPI.Location = New System.Drawing.Point(501, 37)
        Me.txtValorUnidadeIPI.Name = "txtValorUnidadeIPI"
        Me.txtValorUnidadeIPI.Size = New System.Drawing.Size(117, 20)
        Me.txtValorUnidadeIPI.TabIndex = 9
        Me.txtValorUnidadeIPI.Text = "0,0000"
        Me.txtValorUnidadeIPI.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblValorUnidadeIPI
        '
        Me.lblValorUnidadeIPI.AutoSize = True
        Me.lblValorUnidadeIPI.Location = New System.Drawing.Point(498, 20)
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
        Me.txtQuantidadeIPI.Location = New System.Drawing.Point(378, 37)
        Me.txtQuantidadeIPI.Name = "txtQuantidadeIPI"
        Me.txtQuantidadeIPI.Size = New System.Drawing.Size(117, 20)
        Me.txtQuantidadeIPI.TabIndex = 7
        Me.txtQuantidadeIPI.Text = "0,0000"
        Me.txtQuantidadeIPI.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeIPI
        '
        Me.lblQuantidadeIPI.AutoSize = True
        Me.lblQuantidadeIPI.Location = New System.Drawing.Point(375, 20)
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
        Me.cboTipoCalculoIPI.Size = New System.Drawing.Size(117, 20)
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
        Me.txtValorIPI.Location = New System.Drawing.Point(624, 37)
        Me.txtValorIPI.Name = "txtValorIPI"
        Me.txtValorIPI.ReadOnly = True
        Me.txtValorIPI.Size = New System.Drawing.Size(117, 20)
        Me.txtValorIPI.TabIndex = 11
        Me.txtValorIPI.TabStop = False
        Me.txtValorIPI.Text = "0,00"
        Me.txtValorIPI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorIPI
        '
        Me.lblValorIPI.AutoSize = True
        Me.lblValorIPI.Location = New System.Drawing.Point(621, 20)
        Me.lblValorIPI.Name = "lblValorIPI"
        Me.lblValorIPI.Size = New System.Drawing.Size(63, 14)
        Me.lblValorIPI.TabIndex = 10
        Me.lblValorIPI.Text = "Valor do IPI:"
        '
        'txtBaseCalculoIPI
        '
        Me.txtBaseCalculoIPI.Enabled = False
        Me.txtBaseCalculoIPI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseCalculoIPI.Location = New System.Drawing.Point(132, 37)
        Me.txtBaseCalculoIPI.Name = "txtBaseCalculoIPI"
        Me.txtBaseCalculoIPI.Size = New System.Drawing.Size(117, 20)
        Me.txtBaseCalculoIPI.TabIndex = 3
        Me.txtBaseCalculoIPI.Text = "0,00"
        Me.txtBaseCalculoIPI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblBaseCalculoIPI
        '
        Me.lblBaseCalculoIPI.AutoSize = True
        Me.lblBaseCalculoIPI.Location = New System.Drawing.Point(129, 20)
        Me.lblBaseCalculoIPI.Name = "lblBaseCalculoIPI"
        Me.lblBaseCalculoIPI.Size = New System.Drawing.Size(85, 14)
        Me.lblBaseCalculoIPI.TabIndex = 2
        Me.lblBaseCalculoIPI.Text = "Base de Cálculo"
        '
        'txtAliquotaIPI
        '
        Me.txtAliquotaIPI.Enabled = False
        Me.txtAliquotaIPI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAliquotaIPI.Location = New System.Drawing.Point(255, 37)
        Me.txtAliquotaIPI.Name = "txtAliquotaIPI"
        Me.txtAliquotaIPI.Size = New System.Drawing.Size(117, 20)
        Me.txtAliquotaIPI.TabIndex = 5
        Me.txtAliquotaIPI.Text = "0,00"
        Me.txtAliquotaIPI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaIPI
        '
        Me.lblAliquotaIPI.AutoSize = True
        Me.lblAliquotaIPI.Location = New System.Drawing.Point(252, 20)
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
        Me.grpSituacaoTributariaIPI.Controls.Add(Me.cboCodigoEnquadramento)
        Me.grpSituacaoTributariaIPI.Controls.Add(Me.lblCodigoEnquadramento)
        Me.grpSituacaoTributariaIPI.Controls.Add(Me.cboSituacaoTributariaIPI)
        Me.grpSituacaoTributariaIPI.Controls.Add(Me.lblSituacaoTributariaIPI)
        Me.grpSituacaoTributariaIPI.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpSituacaoTributariaIPI.Location = New System.Drawing.Point(8, 3)
        Me.grpSituacaoTributariaIPI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSituacaoTributariaIPI.Name = "grpSituacaoTributariaIPI"
        Me.grpSituacaoTributariaIPI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpSituacaoTributariaIPI.Size = New System.Drawing.Size(908, 67)
        Me.grpSituacaoTributariaIPI.TabIndex = 0
        Me.grpSituacaoTributariaIPI.Text = "Situação Tributária do IPI"
        Me.grpSituacaoTributariaIPI.VisualStyleManager = Me.vsmMain
        '
        'cboCodigoEnquadramento
        '
        Me.cboCodigoEnquadramento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCodigoEnquadramento.AutoSize = False
        Me.cboCodigoEnquadramento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCodigoEnquadramento.Location = New System.Drawing.Point(378, 37)
        Me.cboCodigoEnquadramento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCodigoEnquadramento.Name = "cboCodigoEnquadramento"
        Me.cboCodigoEnquadramento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCodigoEnquadramento.Size = New System.Drawing.Size(524, 20)
        Me.cboCodigoEnquadramento.TabIndex = 13
        Me.cboCodigoEnquadramento.Tag = "|00|10|20|70|90|"
        '
        'lblCodigoEnquadramento
        '
        Me.lblCodigoEnquadramento.AutoSize = True
        Me.lblCodigoEnquadramento.Location = New System.Drawing.Point(375, 20)
        Me.lblCodigoEnquadramento.Name = "lblCodigoEnquadramento"
        Me.lblCodigoEnquadramento.Size = New System.Drawing.Size(136, 14)
        Me.lblCodigoEnquadramento.TabIndex = 12
        Me.lblCodigoEnquadramento.Text = "Classe de Enquadramento:"
        '
        'cboSituacaoTributariaIPI
        '
        Me.cboSituacaoTributariaIPI.AutoSize = False
        Me.cboSituacaoTributariaIPI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSituacaoTributariaIPI.Location = New System.Drawing.Point(9, 37)
        Me.cboSituacaoTributariaIPI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSituacaoTributariaIPI.Name = "cboSituacaoTributariaIPI"
        Me.cboSituacaoTributariaIPI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSituacaoTributariaIPI.Size = New System.Drawing.Size(363, 20)
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
        Me.pagPIS.Size = New System.Drawing.Size(924, 341)
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
        Me.grpPIS.Size = New System.Drawing.Size(908, 67)
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
        Me.cboTipoCalculoPIS.Size = New System.Drawing.Size(117, 20)
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
        Me.txtBaseCalculoPIS.Location = New System.Drawing.Point(132, 37)
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
        Me.lblBaseCalculoPIS.Location = New System.Drawing.Point(129, 20)
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
        Me.txtQuantidadeVendidaPIS.Location = New System.Drawing.Point(501, 37)
        Me.txtQuantidadeVendidaPIS.Name = "txtQuantidadeVendidaPIS"
        Me.txtQuantidadeVendidaPIS.Size = New System.Drawing.Size(117, 20)
        Me.txtQuantidadeVendidaPIS.TabIndex = 9
        Me.txtQuantidadeVendidaPIS.Tag = ""
        Me.txtQuantidadeVendidaPIS.Text = "0,0000"
        Me.txtQuantidadeVendidaPIS.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeVendidaPIS
        '
        Me.lblQuantidadeVendidaPIS.AutoSize = True
        Me.lblQuantidadeVendidaPIS.Location = New System.Drawing.Point(498, 20)
        Me.lblQuantidadeVendidaPIS.Name = "lblQuantidadeVendidaPIS"
        Me.lblQuantidadeVendidaPIS.Size = New System.Drawing.Size(78, 14)
        Me.lblQuantidadeVendidaPIS.TabIndex = 8
        Me.lblQuantidadeVendidaPIS.Text = "Qtde. Vendida:"
        '
        'txtValorPIS
        '
        Me.txtValorPIS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorPIS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorPIS.Location = New System.Drawing.Point(624, 37)
        Me.txtValorPIS.Name = "txtValorPIS"
        Me.txtValorPIS.ReadOnly = True
        Me.txtValorPIS.Size = New System.Drawing.Size(117, 20)
        Me.txtValorPIS.TabIndex = 11
        Me.txtValorPIS.TabStop = False
        Me.txtValorPIS.Tag = ""
        Me.txtValorPIS.Text = "0,00"
        Me.txtValorPIS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorPIS
        '
        Me.lblValorPIS.AutoSize = True
        Me.lblValorPIS.Location = New System.Drawing.Point(621, 20)
        Me.lblValorPIS.Name = "lblValorPIS"
        Me.lblValorPIS.Size = New System.Drawing.Size(53, 14)
        Me.lblValorPIS.TabIndex = 10
        Me.lblValorPIS.Text = "Valor PIS:"
        '
        'txtAliquotaPercentualPIS
        '
        Me.txtAliquotaPercentualPIS.Enabled = False
        Me.txtAliquotaPercentualPIS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAliquotaPercentualPIS.Location = New System.Drawing.Point(255, 37)
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
        Me.lblAliquotaPercentualPIS.Location = New System.Drawing.Point(252, 20)
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
        Me.txtAliquotaValorPIS.Location = New System.Drawing.Point(378, 37)
        Me.txtAliquotaValorPIS.Name = "txtAliquotaValorPIS"
        Me.txtAliquotaValorPIS.Size = New System.Drawing.Size(117, 20)
        Me.txtAliquotaValorPIS.TabIndex = 7
        Me.txtAliquotaValorPIS.Tag = ""
        Me.txtAliquotaValorPIS.Text = "0,0000"
        Me.txtAliquotaValorPIS.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblAliquotaValorPIS
        '
        Me.lblAliquotaValorPIS.AutoSize = True
        Me.lblAliquotaValorPIS.Location = New System.Drawing.Point(375, 20)
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
        Me.grpSituacaoTributariaPIS.Size = New System.Drawing.Size(908, 67)
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
        Me.cboSituacaoTributariaPIS.Size = New System.Drawing.Size(890, 20)
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
        Me.pagCOFINS.Size = New System.Drawing.Size(924, 341)
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
        Me.grpCOFINS.Size = New System.Drawing.Size(908, 67)
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
        Me.cboTipoCalculoCOFINS.Size = New System.Drawing.Size(117, 20)
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
        Me.txtBaseCalculoCOFINS.Location = New System.Drawing.Point(132, 37)
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
        Me.lblBaseCalculoCOFINS.Location = New System.Drawing.Point(129, 20)
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
        Me.txtQuantidadeVendidaCOFINS.Location = New System.Drawing.Point(501, 37)
        Me.txtQuantidadeVendidaCOFINS.Name = "txtQuantidadeVendidaCOFINS"
        Me.txtQuantidadeVendidaCOFINS.Size = New System.Drawing.Size(117, 20)
        Me.txtQuantidadeVendidaCOFINS.TabIndex = 9
        Me.txtQuantidadeVendidaCOFINS.Tag = ""
        Me.txtQuantidadeVendidaCOFINS.Text = "0,0000"
        Me.txtQuantidadeVendidaCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeVendidaCOFINS
        '
        Me.lblQuantidadeVendidaCOFINS.AutoSize = True
        Me.lblQuantidadeVendidaCOFINS.Location = New System.Drawing.Point(498, 20)
        Me.lblQuantidadeVendidaCOFINS.Name = "lblQuantidadeVendidaCOFINS"
        Me.lblQuantidadeVendidaCOFINS.Size = New System.Drawing.Size(78, 14)
        Me.lblQuantidadeVendidaCOFINS.TabIndex = 8
        Me.lblQuantidadeVendidaCOFINS.Text = "Qtde. Vendida:"
        '
        'txtValorCOFINS
        '
        Me.txtValorCOFINS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorCOFINS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorCOFINS.Location = New System.Drawing.Point(624, 37)
        Me.txtValorCOFINS.Name = "txtValorCOFINS"
        Me.txtValorCOFINS.ReadOnly = True
        Me.txtValorCOFINS.Size = New System.Drawing.Size(117, 20)
        Me.txtValorCOFINS.TabIndex = 11
        Me.txtValorCOFINS.TabStop = False
        Me.txtValorCOFINS.Tag = ""
        Me.txtValorCOFINS.Text = "0,00"
        Me.txtValorCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorCOFINS
        '
        Me.lblValorCOFINS.AutoSize = True
        Me.lblValorCOFINS.Location = New System.Drawing.Point(621, 20)
        Me.lblValorCOFINS.Name = "lblValorCOFINS"
        Me.lblValorCOFINS.Size = New System.Drawing.Size(75, 14)
        Me.lblValorCOFINS.TabIndex = 10
        Me.lblValorCOFINS.Text = "Valor COFINS:"
        '
        'txtAliquotaPercentualCOFINS
        '
        Me.txtAliquotaPercentualCOFINS.Enabled = False
        Me.txtAliquotaPercentualCOFINS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAliquotaPercentualCOFINS.Location = New System.Drawing.Point(255, 37)
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
        Me.lblAliquotaPercentualCOFINS.Location = New System.Drawing.Point(252, 20)
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
        Me.txtAliquotaValorCOFINS.Location = New System.Drawing.Point(378, 37)
        Me.txtAliquotaValorCOFINS.Name = "txtAliquotaValorCOFINS"
        Me.txtAliquotaValorCOFINS.Size = New System.Drawing.Size(117, 20)
        Me.txtAliquotaValorCOFINS.TabIndex = 7
        Me.txtAliquotaValorCOFINS.Tag = ""
        Me.txtAliquotaValorCOFINS.Text = "0,0000"
        Me.txtAliquotaValorCOFINS.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblAliquotaValorCOFINS
        '
        Me.lblAliquotaValorCOFINS.AutoSize = True
        Me.lblAliquotaValorCOFINS.Location = New System.Drawing.Point(375, 20)
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
        Me.grpSituacaoTributariaCOFINS.Size = New System.Drawing.Size(908, 67)
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
        Me.cboSituacaoTributariaCOFINS.Size = New System.Drawing.Size(890, 20)
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
        Me.pagImpostoImportacao.Size = New System.Drawing.Size(924, 341)
        Me.pagImpostoImportacao.TabStop = True
        Me.pagImpostoImportacao.Text = "Imposto de Importação"
        '
        'grpII
        '
        Me.grpII.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpII.BackColor = System.Drawing.Color.Transparent
        Me.grpII.Controls.Add(Me.txtAliquotaII)
        Me.grpII.Controls.Add(Me.lblAliquotaII)
        Me.grpII.Controls.Add(Me.txtAliquotaIOF)
        Me.grpII.Controls.Add(Me.lblAliquotaIOF)
        Me.grpII.Controls.Add(Me.txtDespesaAduaneiraII)
        Me.grpII.Controls.Add(Me.lblDespesaAduaneiraII)
        Me.grpII.Controls.Add(Me.txtBaseCalculoII)
        Me.grpII.Controls.Add(Me.lblBaseCalculoII)
        Me.grpII.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpII.Location = New System.Drawing.Point(8, 3)
        Me.grpII.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpII.Name = "grpII"
        Me.grpII.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpII.Size = New System.Drawing.Size(908, 67)
        Me.grpII.TabIndex = 0
        Me.grpII.Text = "Imposto de Importação"
        Me.grpII.VisualStyleManager = Me.vsmMain
        '
        'txtAliquotaII
        '
        Me.txtAliquotaII.Location = New System.Drawing.Point(376, 37)
        Me.txtAliquotaII.Name = "txtAliquotaII"
        Me.txtAliquotaII.Size = New System.Drawing.Size(116, 20)
        Me.txtAliquotaII.TabIndex = 7
        Me.txtAliquotaII.Text = "0,00"
        Me.txtAliquotaII.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaII
        '
        Me.lblAliquotaII.AutoSize = True
        Me.lblAliquotaII.Location = New System.Drawing.Point(373, 20)
        Me.lblAliquotaII.Name = "lblAliquotaII"
        Me.lblAliquotaII.Size = New System.Drawing.Size(56, 14)
        Me.lblAliquotaII.TabIndex = 6
        Me.lblAliquotaII.Text = "Alíquota II:"
        '
        'txtAliquotaIOF
        '
        Me.txtAliquotaIOF.Location = New System.Drawing.Point(254, 37)
        Me.txtAliquotaIOF.Name = "txtAliquotaIOF"
        Me.txtAliquotaIOF.Size = New System.Drawing.Size(116, 20)
        Me.txtAliquotaIOF.TabIndex = 5
        Me.txtAliquotaIOF.Text = "0,00"
        Me.txtAliquotaIOF.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaIOF
        '
        Me.lblAliquotaIOF.AutoSize = True
        Me.lblAliquotaIOF.Location = New System.Drawing.Point(251, 20)
        Me.lblAliquotaIOF.Name = "lblAliquotaIOF"
        Me.lblAliquotaIOF.Size = New System.Drawing.Size(68, 14)
        Me.lblAliquotaIOF.TabIndex = 4
        Me.lblAliquotaIOF.Text = "Alíquota IOF:"
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
        'frmFatEmissaoNFeProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 472)
        Me.Controls.Add(Me.tabProduto)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEmissaoNFeProduto"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Formulário de Emissão de NF-e Produto"
        CType(Me.tabProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabProduto.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpDadosItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosItem.ResumeLayout(False)
        Me.grpDadosItem.PerformLayout()
        CType(Me.grpImportacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpImportacao.ResumeLayout(False)
        Me.grpImportacao.PerformLayout()
        CType(Me.UiGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox6.ResumeLayout(False)
        Me.UiGroupBox6.PerformLayout()
        CType(Me.grpControleDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleDados.ResumeLayout(False)
        Me.pagTributos.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.tabTributo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTributo.ResumeLayout(False)
        Me.pagICMS.ResumeLayout(False)
        CType(Me.grpOrigemItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOrigemItem.ResumeLayout(False)
        Me.grpOrigemItem.PerformLayout()
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
        CType(Me.grpOrigemItemSimples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOrigemItemSimples.ResumeLayout(False)
        Me.grpOrigemItemSimples.PerformLayout()
        CType(Me.grpICMSSTSimples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpICMSSTSimples.ResumeLayout(False)
        Me.grpICMSSTSimples.PerformLayout()
        CType(Me.grpICMSSimples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpICMSSimples.ResumeLayout(False)
        Me.grpICMSSimples.PerformLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        Me.UiGroupBox3.PerformLayout()
        Me.pagICMSPartilha.ResumeLayout(False)
        CType(Me.grpICMSPartilha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpICMSPartilha.ResumeLayout(False)
        Me.grpICMSPartilha.PerformLayout()
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabProduto As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagTributos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDadosItem As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorDesconto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorDesconto As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarItem As System.Windows.Forms.Button
    Friend WithEvents cboCodigo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCadastrarUnidadeMedida As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarNCM As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCFOP As System.Windows.Forms.Button
    Friend WithEvents btnProcurarItem As System.Windows.Forms.Button
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
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents grpControleDados As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnInserirDados As Janus.Windows.EditControls.UIButton
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
    Friend WithEvents txtAliquotaII As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaII As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaIOF As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaIOF As System.Windows.Forms.Label
    Friend WithEvents txtDespesaAduaneiraII As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDespesaAduaneiraII As System.Windows.Forms.Label
    Friend WithEvents txtBaseCalculoII As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblBaseCalculoII As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnInserirTributos As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVoltarTributos As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtCodigoEAN As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoEAN As System.Windows.Forms.Label
    Friend WithEvents lblIncideValorTotalNF As System.Windows.Forms.Label
    Friend WithEvents cboIncideValorTotalNF As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents pagICMSSimples As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiGroupBox6 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtPedidoCompra As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPedidoCompra As System.Windows.Forms.Label
    Friend WithEvents lblNumeroItemPedidoCompra As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboSituacaoTributariaICMSSimples As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSituacaoTributariaICMSSimples As System.Windows.Forms.Label
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
    Friend WithEvents txtNumeroItemPedidoCompra As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtInformacoesAdicionais As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblInformacoesAdicionais As System.Windows.Forms.Label
    Friend WithEvents txtValorICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorICMS As System.Windows.Forms.Label
    Friend WithEvents txtBaseCalculoICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblBaseCalculoICMS As System.Windows.Forms.Label
    Friend WithEvents txtOutrasDespesas As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblOutrasDespesas As System.Windows.Forms.Label
    Friend WithEvents txtValorFrete As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorFrete As System.Windows.Forms.Label
    Friend WithEvents txtValorSeguro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorSeguro As System.Windows.Forms.Label
    Friend WithEvents grpImportacao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNumeroDI As System.Windows.Forms.Label
    Friend WithEvents txtCodigoFabricante As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoFabricante As System.Windows.Forms.Label
    Friend WithEvents cboNumeroDI As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents chkCalculoAutomatico As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents grpOrigemItem As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboOrigemItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblOrigemItem As System.Windows.Forms.Label
    Friend WithEvents grpOrigemItemSimples As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboOrigemItemSimples As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblOrigemItemSimples As System.Windows.Forms.Label
    Friend WithEvents cboCodigoEnquadramento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoEnquadramento As System.Windows.Forms.Label
    Friend WithEvents pagICMSPartilha As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpICMSPartilha As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtPercentualICMSInterestadual As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPercentualICMSInterestadual As System.Windows.Forms.Label
    Friend WithEvents txtPercentualFCPICMSPartilha As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblBaseCalculoICMSPartilha As System.Windows.Forms.Label
    Friend WithEvents txtPercentualICMSDestino As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPercentualICMSDestino As System.Windows.Forms.Label
    Friend WithEvents txtBaseCalculoICMSPartilha As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPercentualFCPICMSPartilha As System.Windows.Forms.Label
    Friend WithEvents txtValorFCP As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorFCP As System.Windows.Forms.Label
    Friend WithEvents txtValorICMSDestino As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorICMSDestino As System.Windows.Forms.Label
    Friend WithEvents txtPercentualICMSPartilha As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPercentualICMSPartilha As System.Windows.Forms.Label
    Friend WithEvents txtValorICMSRemetente As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorICMSRemetente As System.Windows.Forms.Label
End Class
