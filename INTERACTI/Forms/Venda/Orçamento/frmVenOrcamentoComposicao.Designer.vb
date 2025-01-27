<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVenOrcamentoComposicao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim grdOrcamentoGrupo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenOrcamentoComposicao))
        Dim grdOrcamentoListaMaterial_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdOrcamentoListaMaterial_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim grdOrcamentoListaMaterial_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column12.Image")
        Dim grdOrcamentoListaMaterial_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column19.Image")
        Dim grdOrcamentoProcessoProdutivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdOrcamentoProcessoProdutivo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim grdOrcamentoProcessoProdutivo_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdOrcamentoServicoTerceiros_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdOrcamentoServicoTerceiros_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim ChartArea2 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend2 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim grdOrcamentoCheckListCliente_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.chrComposicao = New Dundas.Charting.WinControl.Chart()
        Me.grdOrcamentoGrupo = New Janus.Windows.GridEX.GridEX()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagListaMaterialGrupo = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdOrcamentoListaMaterial = New Janus.Windows.GridEX.GridEX()
        Me.pagProcessoProdutivo = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdOrcamentoProcessoProdutivo = New Janus.Windows.GridEX.GridEX()
        Me.pagServicoTerceiro = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpServicoTerceiros = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.cboFornecedor = New Janus.Windows.EditControls.UIComboBox()
        Me.txtValorUnitario = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnitario = New System.Windows.Forms.Label()
        Me.txtQuantidadeServico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblServicoTerceiros = New System.Windows.Forms.Label()
        Me.cboServicoTerceiros = New Janus.Windows.EditControls.UIComboBox()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.cboGrupo = New Janus.Windows.EditControls.UIComboBox()
        Me.btnInserirServico = New Janus.Windows.EditControls.UIButton()
        Me.lblQuantidadeServico = New System.Windows.Forms.Label()
        Me.grdOrcamentoServicoTerceiros = New Janus.Windows.GridEX.GridEX()
        Me.grpMotivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtFrete = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblFrete = New System.Windows.Forms.Label()
        Me.btnImportarEstrutura = New Janus.Windows.EditControls.UIButton()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.pagFormacaoPreco = New Janus.Windows.UI.Tab.UITabPage()
        Me.chrFormacaoPreco = New Dundas.Charting.WinControl.Chart()
        Me.grpFormacaoPreco = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorContrato = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorContrato = New System.Windows.Forms.Label()
        Me.txtDescontoPorcentagem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtValorDesconto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDesconto = New System.Windows.Forms.Label()
        Me.btnCalcularDesconto = New System.Windows.Forms.Button()
        Me.btnDespesaFixa = New System.Windows.Forms.Button()
        Me.btnDespesaVariavel = New System.Windows.Forms.Button()
        Me.txtValorComIPI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorComIPI = New System.Windows.Forms.Label()
        Me.txtAliquotaIPI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaIPI = New System.Windows.Forms.Label()
        Me.txtPrecoVenda = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtPrecoVendaPorcentagem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPrecoVenda = New System.Windows.Forms.Label()
        Me.txtLucro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtLucroPorcentagem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblLucro = New System.Windows.Forms.Label()
        Me.txtDespesaFixa = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtDespesaFixaPorcentagem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDespesaFixa = New System.Windows.Forms.Label()
        Me.txtDespesaVariavel = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtDespesaVariavelPorcentagem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDespesaVariavel = New System.Windows.Forms.Label()
        Me.txtCustoTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtCustoTotalPorcentagem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCustoTotal = New System.Windows.Forms.Label()
        Me.grpDespesaVariavel = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtAliquotaCSLL = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaCSLL = New System.Windows.Forms.Label()
        Me.btnImportarRegra = New Janus.Windows.EditControls.UIButton()
        Me.txtAliquotaIR = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaIR = New System.Windows.Forms.Label()
        Me.txtAliquotaICMSReduzida = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtComissaoPorcentagem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblComissao = New System.Windows.Forms.Label()
        Me.lblAliquotaICMSReduzida = New System.Windows.Forms.Label()
        Me.txtPorcentagemReducaoBCICMS = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPorcentagemReducaoBCICMS = New System.Windows.Forms.Label()
        Me.txtAliquotaISSPorcentagem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaISS = New System.Windows.Forms.Label()
        Me.txtAliquotaCOFINSPorcentagem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaCOFINS = New System.Windows.Forms.Label()
        Me.txtAliquotaPISPorcentagem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaPIS = New System.Windows.Forms.Label()
        Me.txtAliquotaICMSPorcentagem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaICMS = New System.Windows.Forms.Label()
        Me.pagChecklistCliente = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdOrcamentoCheckListCliente = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImportarContrato = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.chrComposicao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdOrcamentoGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagListaMaterialGrupo.SuspendLayout()
        CType(Me.grdOrcamentoListaMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagProcessoProdutivo.SuspendLayout()
        CType(Me.grdOrcamentoProcessoProdutivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagServicoTerceiro.SuspendLayout()
        CType(Me.grpServicoTerceiros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpServicoTerceiros.SuspendLayout()
        CType(Me.grdOrcamentoServicoTerceiros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMotivo.SuspendLayout()
        Me.pagFormacaoPreco.SuspendLayout()
        CType(Me.chrFormacaoPreco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFormacaoPreco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFormacaoPreco.SuspendLayout()
        CType(Me.grpDespesaVariavel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDespesaVariavel.SuspendLayout()
        Me.pagChecklistCliente.SuspendLayout()
        CType(Me.grdOrcamentoCheckListCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(787, 436)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela, Me.pagFormacaoPreco, Me.pagChecklistCliente})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.chrComposicao)
        Me.pagTabela.Controls.Add(Me.grdOrcamentoGrupo)
        Me.pagTabela.Controls.Add(Me.tabDados)
        Me.pagTabela.Controls.Add(Me.grpMotivo)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(785, 413)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Composição"
        '
        'chrComposicao
        '
        Me.chrComposicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrComposicao.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrComposicao.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrComposicao.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea1.Name = "Default"
        Me.chrComposicao.ChartAreas.Add(ChartArea1)
        Legend1.AutoFitText = False
        Legend1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.Name = "Default"
        Me.chrComposicao.Legends.Add(Legend1)
        Me.chrComposicao.Location = New System.Drawing.Point(640, 7)
        Me.chrComposicao.Name = "chrComposicao"
        Me.chrComposicao.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas
        Me.chrComposicao.Size = New System.Drawing.Size(136, 230)
        Me.chrComposicao.TabIndex = 112
        Me.chrComposicao.UI.Toolbar.Enabled = True
        '
        'grdOrcamentoGrupo
        '
        Me.grdOrcamentoGrupo.AlternatingColors = True
        grdOrcamentoGrupo_DesignTimeLayout.LayoutString = resources.GetString("grdOrcamentoGrupo_DesignTimeLayout.LayoutString")
        Me.grdOrcamentoGrupo.DesignTimeLayout = grdOrcamentoGrupo_DesignTimeLayout
        Me.grdOrcamentoGrupo.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grdOrcamentoGrupo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrcamentoGrupo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrcamentoGrupo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOrcamentoGrupo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrcamentoGrupo.GroupByBoxVisible = False
        Me.grdOrcamentoGrupo.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdOrcamentoGrupo.Hierarchical = True
        Me.grdOrcamentoGrupo.Location = New System.Drawing.Point(8, 75)
        Me.grdOrcamentoGrupo.Name = "grdOrcamentoGrupo"
        Me.grdOrcamentoGrupo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamentoGrupo.RecordNavigator = True
        Me.grdOrcamentoGrupo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOrcamentoGrupo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamentoGrupo.Size = New System.Drawing.Size(625, 155)
        Me.grdOrcamentoGrupo.TabIndex = 6
        Me.grdOrcamentoGrupo.TabStop = False
        Me.grdOrcamentoGrupo.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamentoGrupo.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdOrcamentoGrupo.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOrcamentoGrupo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamentoGrupo.VisualStyleManager = Me.vsmMain
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.Location = New System.Drawing.Point(8, 236)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(769, 174)
        Me.tabDados.TabIndex = 5
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListaMaterialGrupo, Me.pagProcessoProdutivo, Me.pagServicoTerceiro})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagListaMaterialGrupo
        '
        Me.pagListaMaterialGrupo.Controls.Add(Me.grdOrcamentoListaMaterial)
        Me.pagListaMaterialGrupo.Location = New System.Drawing.Point(1, 22)
        Me.pagListaMaterialGrupo.Name = "pagListaMaterialGrupo"
        Me.pagListaMaterialGrupo.Size = New System.Drawing.Size(767, 151)
        Me.pagListaMaterialGrupo.TabStop = True
        Me.pagListaMaterialGrupo.Text = "Lista Material"
        '
        'grdOrcamentoListaMaterial
        '
        Me.grdOrcamentoListaMaterial.AlternatingColors = True
        Me.grdOrcamentoListaMaterial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdOrcamentoListaMaterial_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdOrcamentoListaMaterial_DesignTimeLayout_Reference_0.Instance"), Object)
        grdOrcamentoListaMaterial_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdOrcamentoListaMaterial_DesignTimeLayout_Reference_1.Instance"), Object)
        grdOrcamentoListaMaterial_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdOrcamentoListaMaterial_DesignTimeLayout_Reference_2.Instance"), Object)
        grdOrcamentoListaMaterial_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdOrcamentoListaMaterial_DesignTimeLayout_Reference_0, grdOrcamentoListaMaterial_DesignTimeLayout_Reference_1, grdOrcamentoListaMaterial_DesignTimeLayout_Reference_2})
        grdOrcamentoListaMaterial_DesignTimeLayout.LayoutString = resources.GetString("grdOrcamentoListaMaterial_DesignTimeLayout.LayoutString")
        Me.grdOrcamentoListaMaterial.DesignTimeLayout = grdOrcamentoListaMaterial_DesignTimeLayout
        Me.grdOrcamentoListaMaterial.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdOrcamentoListaMaterial.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrcamentoListaMaterial.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrcamentoListaMaterial.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOrcamentoListaMaterial.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrcamentoListaMaterial.GroupByBoxVisible = False
        Me.grdOrcamentoListaMaterial.Location = New System.Drawing.Point(11, 9)
        Me.grdOrcamentoListaMaterial.Name = "grdOrcamentoListaMaterial"
        Me.grdOrcamentoListaMaterial.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamentoListaMaterial.RecordNavigator = True
        Me.grdOrcamentoListaMaterial.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdOrcamentoListaMaterial.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOrcamentoListaMaterial.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamentoListaMaterial.Size = New System.Drawing.Size(748, 134)
        Me.grdOrcamentoListaMaterial.TabIndex = 3
        Me.grdOrcamentoListaMaterial.TabStop = False
        Me.grdOrcamentoListaMaterial.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamentoListaMaterial.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdOrcamentoListaMaterial.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOrcamentoListaMaterial.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamentoListaMaterial.VisualStyleManager = Me.vsmMain
        '
        'pagProcessoProdutivo
        '
        Me.pagProcessoProdutivo.Controls.Add(Me.grdOrcamentoProcessoProdutivo)
        Me.pagProcessoProdutivo.Location = New System.Drawing.Point(1, 22)
        Me.pagProcessoProdutivo.Name = "pagProcessoProdutivo"
        Me.pagProcessoProdutivo.Size = New System.Drawing.Size(767, 151)
        Me.pagProcessoProdutivo.TabStop = True
        Me.pagProcessoProdutivo.Text = "Processo Produtivo"
        '
        'grdOrcamentoProcessoProdutivo
        '
        Me.grdOrcamentoProcessoProdutivo.AlternatingColors = True
        Me.grdOrcamentoProcessoProdutivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdOrcamentoProcessoProdutivo_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdOrcamentoProcessoProdutivo_DesignTimeLayout_Reference_0.Instance"), Object)
        grdOrcamentoProcessoProdutivo_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdOrcamentoProcessoProdutivo_DesignTimeLayout_Reference_1.Instance"), Object)
        grdOrcamentoProcessoProdutivo_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdOrcamentoProcessoProdutivo_DesignTimeLayout_Reference_0, grdOrcamentoProcessoProdutivo_DesignTimeLayout_Reference_1})
        grdOrcamentoProcessoProdutivo_DesignTimeLayout.LayoutString = resources.GetString("grdOrcamentoProcessoProdutivo_DesignTimeLayout.LayoutString")
        Me.grdOrcamentoProcessoProdutivo.DesignTimeLayout = grdOrcamentoProcessoProdutivo_DesignTimeLayout
        Me.grdOrcamentoProcessoProdutivo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrcamentoProcessoProdutivo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrcamentoProcessoProdutivo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOrcamentoProcessoProdutivo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrcamentoProcessoProdutivo.GroupByBoxVisible = False
        Me.grdOrcamentoProcessoProdutivo.Location = New System.Drawing.Point(11, 9)
        Me.grdOrcamentoProcessoProdutivo.Name = "grdOrcamentoProcessoProdutivo"
        Me.grdOrcamentoProcessoProdutivo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamentoProcessoProdutivo.RecordNavigator = True
        Me.grdOrcamentoProcessoProdutivo.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdOrcamentoProcessoProdutivo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOrcamentoProcessoProdutivo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamentoProcessoProdutivo.Size = New System.Drawing.Size(748, 134)
        Me.grdOrcamentoProcessoProdutivo.TabIndex = 2
        Me.grdOrcamentoProcessoProdutivo.TabStop = False
        Me.grdOrcamentoProcessoProdutivo.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdOrcamentoProcessoProdutivo.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOrcamentoProcessoProdutivo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamentoProcessoProdutivo.VisualStyleManager = Me.vsmMain
        '
        'pagServicoTerceiro
        '
        Me.pagServicoTerceiro.Controls.Add(Me.grpServicoTerceiros)
        Me.pagServicoTerceiro.Controls.Add(Me.grdOrcamentoServicoTerceiros)
        Me.pagServicoTerceiro.Location = New System.Drawing.Point(1, 22)
        Me.pagServicoTerceiro.Name = "pagServicoTerceiro"
        Me.pagServicoTerceiro.Size = New System.Drawing.Size(767, 151)
        Me.pagServicoTerceiro.TabStop = True
        Me.pagServicoTerceiro.Text = "Serviço de Terceiros"
        '
        'grpServicoTerceiros
        '
        Me.grpServicoTerceiros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpServicoTerceiros.BackColor = System.Drawing.Color.Transparent
        Me.grpServicoTerceiros.Controls.Add(Me.txtValorTotal)
        Me.grpServicoTerceiros.Controls.Add(Me.lblValorTotal)
        Me.grpServicoTerceiros.Controls.Add(Me.lblFornecedor)
        Me.grpServicoTerceiros.Controls.Add(Me.cboFornecedor)
        Me.grpServicoTerceiros.Controls.Add(Me.txtValorUnitario)
        Me.grpServicoTerceiros.Controls.Add(Me.lblValorUnitario)
        Me.grpServicoTerceiros.Controls.Add(Me.txtQuantidadeServico)
        Me.grpServicoTerceiros.Controls.Add(Me.lblServicoTerceiros)
        Me.grpServicoTerceiros.Controls.Add(Me.cboServicoTerceiros)
        Me.grpServicoTerceiros.Controls.Add(Me.lblGrupo)
        Me.grpServicoTerceiros.Controls.Add(Me.cboGrupo)
        Me.grpServicoTerceiros.Controls.Add(Me.btnInserirServico)
        Me.grpServicoTerceiros.Controls.Add(Me.lblQuantidadeServico)
        Me.grpServicoTerceiros.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpServicoTerceiros.Location = New System.Drawing.Point(11, 4)
        Me.grpServicoTerceiros.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpServicoTerceiros.Name = "grpServicoTerceiros"
        Me.grpServicoTerceiros.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpServicoTerceiros.Size = New System.Drawing.Size(748, 65)
        Me.grpServicoTerceiros.TabIndex = 4
        Me.grpServicoTerceiros.Text = "Dados do Serviço"
        Me.grpServicoTerceiros.VisualStyleManager = Me.vsmMain
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTotal.DecimalDigits = 2
        Me.txtValorTotal.Location = New System.Drawing.Point(557, 34)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(67, 20)
        Me.txtValorTotal.TabIndex = 16
        Me.txtValorTotal.TabStop = False
        Me.txtValorTotal.Text = "0,00"
        Me.txtValorTotal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.Location = New System.Drawing.Point(554, 17)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(60, 14)
        Me.lblValorTotal.TabIndex = 17
        Me.lblValorTotal.Text = "Valor Total:"
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(627, 17)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedor.TabIndex = 15
        Me.lblFornecedor.Text = "Fornecedor:"
        '
        'cboFornecedor
        '
        Me.cboFornecedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFornecedor.AutoSize = False
        Me.cboFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFornecedor.Location = New System.Drawing.Point(630, 34)
        Me.cboFornecedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboFornecedor.Name = "cboFornecedor"
        Me.cboFornecedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFornecedor.Size = New System.Drawing.Size(17, 20)
        Me.cboFornecedor.TabIndex = 4
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.BackColor = System.Drawing.Color.White
        Me.txtValorUnitario.DecimalDigits = 2
        Me.txtValorUnitario.Location = New System.Drawing.Point(480, 34)
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.Size = New System.Drawing.Size(71, 20)
        Me.txtValorUnitario.TabIndex = 3
        Me.txtValorUnitario.Text = "0,00"
        Me.txtValorUnitario.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorUnitario
        '
        Me.lblValorUnitario.AutoSize = True
        Me.lblValorUnitario.Location = New System.Drawing.Point(477, 17)
        Me.lblValorUnitario.Name = "lblValorUnitario"
        Me.lblValorUnitario.Size = New System.Drawing.Size(74, 14)
        Me.lblValorUnitario.TabIndex = 13
        Me.lblValorUnitario.Text = "Valor Unitário:"
        '
        'txtQuantidadeServico
        '
        Me.txtQuantidadeServico.BackColor = System.Drawing.Color.White
        Me.txtQuantidadeServico.DecimalDigits = 2
        Me.txtQuantidadeServico.Location = New System.Drawing.Point(412, 34)
        Me.txtQuantidadeServico.Name = "txtQuantidadeServico"
        Me.txtQuantidadeServico.Size = New System.Drawing.Size(62, 20)
        Me.txtQuantidadeServico.TabIndex = 2
        Me.txtQuantidadeServico.Text = "0,00"
        Me.txtQuantidadeServico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblServicoTerceiros
        '
        Me.lblServicoTerceiros.AutoSize = True
        Me.lblServicoTerceiros.Location = New System.Drawing.Point(178, 17)
        Me.lblServicoTerceiros.Name = "lblServicoTerceiros"
        Me.lblServicoTerceiros.Size = New System.Drawing.Size(107, 14)
        Me.lblServicoTerceiros.TabIndex = 9
        Me.lblServicoTerceiros.Text = "Serviço de Terceiros"
        '
        'cboServicoTerceiros
        '
        Me.cboServicoTerceiros.AutoSize = False
        Me.cboServicoTerceiros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboServicoTerceiros.Location = New System.Drawing.Point(181, 34)
        Me.cboServicoTerceiros.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboServicoTerceiros.Name = "cboServicoTerceiros"
        Me.cboServicoTerceiros.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboServicoTerceiros.Size = New System.Drawing.Size(225, 20)
        Me.cboServicoTerceiros.TabIndex = 1
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Location = New System.Drawing.Point(6, 17)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(40, 14)
        Me.lblGrupo.TabIndex = 7
        Me.lblGrupo.Text = "Grupo:"
        '
        'cboGrupo
        '
        Me.cboGrupo.AutoSize = False
        Me.cboGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupo.Location = New System.Drawing.Point(9, 34)
        Me.cboGrupo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupo.Size = New System.Drawing.Size(166, 20)
        Me.cboGrupo.TabIndex = 0
        '
        'btnInserirServico
        '
        Me.btnInserirServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirServico.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirServico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirServico.Location = New System.Drawing.Point(653, 31)
        Me.btnInserirServico.Name = "btnInserirServico"
        Me.btnInserirServico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirServico.Size = New System.Drawing.Size(89, 23)
        Me.btnInserirServico.TabIndex = 5
        Me.btnInserirServico.Text = "Inserir"
        Me.btnInserirServico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblQuantidadeServico
        '
        Me.lblQuantidadeServico.AutoSize = True
        Me.lblQuantidadeServico.Location = New System.Drawing.Point(409, 17)
        Me.lblQuantidadeServico.Name = "lblQuantidadeServico"
        Me.lblQuantidadeServico.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeServico.TabIndex = 11
        Me.lblQuantidadeServico.Text = "Quantidade:"
        '
        'grdOrcamentoServicoTerceiros
        '
        Me.grdOrcamentoServicoTerceiros.AlternatingColors = True
        Me.grdOrcamentoServicoTerceiros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdOrcamentoServicoTerceiros_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdOrcamentoServicoTerceiros_DesignTimeLayout_Reference_0.Instance"), Object)
        grdOrcamentoServicoTerceiros_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdOrcamentoServicoTerceiros_DesignTimeLayout_Reference_0})
        grdOrcamentoServicoTerceiros_DesignTimeLayout.LayoutString = resources.GetString("grdOrcamentoServicoTerceiros_DesignTimeLayout.LayoutString")
        Me.grdOrcamentoServicoTerceiros.DesignTimeLayout = grdOrcamentoServicoTerceiros_DesignTimeLayout
        Me.grdOrcamentoServicoTerceiros.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrcamentoServicoTerceiros.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrcamentoServicoTerceiros.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOrcamentoServicoTerceiros.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrcamentoServicoTerceiros.GroupByBoxVisible = False
        Me.grdOrcamentoServicoTerceiros.Location = New System.Drawing.Point(11, 76)
        Me.grdOrcamentoServicoTerceiros.Name = "grdOrcamentoServicoTerceiros"
        Me.grdOrcamentoServicoTerceiros.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamentoServicoTerceiros.RecordNavigator = True
        Me.grdOrcamentoServicoTerceiros.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdOrcamentoServicoTerceiros.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOrcamentoServicoTerceiros.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamentoServicoTerceiros.Size = New System.Drawing.Size(748, 67)
        Me.grdOrcamentoServicoTerceiros.TabIndex = 3
        Me.grdOrcamentoServicoTerceiros.TabStop = False
        Me.grdOrcamentoServicoTerceiros.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamentoServicoTerceiros.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdOrcamentoServicoTerceiros.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOrcamentoServicoTerceiros.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamentoServicoTerceiros.VisualStyleManager = Me.vsmMain
        '
        'grpMotivo
        '
        Me.grpMotivo.BackColor = System.Drawing.Color.Transparent
        Me.grpMotivo.Controls.Add(Me.txtFrete)
        Me.grpMotivo.Controls.Add(Me.lblFrete)
        Me.grpMotivo.Controls.Add(Me.btnImportarEstrutura)
        Me.grpMotivo.Controls.Add(Me.txtQuantidade)
        Me.grpMotivo.Controls.Add(Me.lblQuantidade)
        Me.grpMotivo.Controls.Add(Me.txtDescricao)
        Me.grpMotivo.Controls.Add(Me.lblDescricao)
        Me.grpMotivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMotivo.Location = New System.Drawing.Point(8, 3)
        Me.grpMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMotivo.Name = "grpMotivo"
        Me.grpMotivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMotivo.Size = New System.Drawing.Size(625, 65)
        Me.grpMotivo.TabIndex = 0
        Me.grpMotivo.Text = "Dados do Produto"
        Me.grpMotivo.VisualStyleManager = Me.vsmMain
        '
        'txtFrete
        '
        Me.txtFrete.DecimalDigits = 2
        Me.txtFrete.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtFrete.Location = New System.Drawing.Point(410, 34)
        Me.txtFrete.Name = "txtFrete"
        Me.txtFrete.Size = New System.Drawing.Size(86, 20)
        Me.txtFrete.TabIndex = 2
        Me.txtFrete.Text = "R$ 0,00"
        Me.txtFrete.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblFrete
        '
        Me.lblFrete.AutoSize = True
        Me.lblFrete.Location = New System.Drawing.Point(407, 17)
        Me.lblFrete.Name = "lblFrete"
        Me.lblFrete.Size = New System.Drawing.Size(35, 14)
        Me.lblFrete.TabIndex = 24
        Me.lblFrete.Text = "Frete:"
        '
        'btnImportarEstrutura
        '
        Me.btnImportarEstrutura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportarEstrutura.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnImportarEstrutura.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarEstrutura.Location = New System.Drawing.Point(502, 31)
        Me.btnImportarEstrutura.Name = "btnImportarEstrutura"
        Me.btnImportarEstrutura.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportarEstrutura.Size = New System.Drawing.Size(117, 23)
        Me.btnImportarEstrutura.TabIndex = 3
        Me.btnImportarEstrutura.Text = "Importar Estrutura"
        Me.btnImportarEstrutura.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(327, 34)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.ReadOnly = True
        Me.txtQuantidade.Size = New System.Drawing.Size(77, 20)
        Me.txtQuantidade.TabIndex = 1
        Me.txtQuantidade.TabStop = False
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidade
        '
        Me.lblQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(324, 17)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 4
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(9, 34)
        Me.txtDescricao.MaxLength = 250
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(312, 20)
        Me.txtDescricao.TabIndex = 0
        Me.txtDescricao.TabStop = False
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(6, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 0
        Me.lblDescricao.Text = "Descrição:"
        '
        'pagFormacaoPreco
        '
        Me.pagFormacaoPreco.Controls.Add(Me.chrFormacaoPreco)
        Me.pagFormacaoPreco.Controls.Add(Me.grpFormacaoPreco)
        Me.pagFormacaoPreco.Controls.Add(Me.grpDespesaVariavel)
        Me.pagFormacaoPreco.Key = "pagFormacaoPreco"
        Me.pagFormacaoPreco.Location = New System.Drawing.Point(1, 22)
        Me.pagFormacaoPreco.Name = "pagFormacaoPreco"
        Me.pagFormacaoPreco.Size = New System.Drawing.Size(785, 413)
        Me.pagFormacaoPreco.TabStop = True
        Me.pagFormacaoPreco.Text = "Formação de Preço"
        '
        'chrFormacaoPreco
        '
        Me.chrFormacaoPreco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrFormacaoPreco.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrFormacaoPreco.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrFormacaoPreco.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea2.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea2.AxisX.Title = "Período (dias)"
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea2.AxisY.Title = "Quantidade"
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea2.BorderColor = System.Drawing.Color.Empty
        ChartArea2.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea2.Name = "Default"
        Me.chrFormacaoPreco.ChartAreas.Add(ChartArea2)
        Legend2.AutoFitText = False
        Legend2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.Name = "Default"
        Me.chrFormacaoPreco.Legends.Add(Legend2)
        Me.chrFormacaoPreco.Location = New System.Drawing.Point(220, 0)
        Me.chrFormacaoPreco.Name = "chrFormacaoPreco"
        Me.chrFormacaoPreco.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas
        Me.chrFormacaoPreco.Size = New System.Drawing.Size(414, 409)
        Me.chrFormacaoPreco.TabIndex = 113
        Me.chrFormacaoPreco.UI.Toolbar.Enabled = True
        '
        'grpFormacaoPreco
        '
        Me.grpFormacaoPreco.BackColor = System.Drawing.Color.Transparent
        Me.grpFormacaoPreco.Controls.Add(Me.txtValorContrato)
        Me.grpFormacaoPreco.Controls.Add(Me.lblValorContrato)
        Me.grpFormacaoPreco.Controls.Add(Me.txtDescontoPorcentagem)
        Me.grpFormacaoPreco.Controls.Add(Me.txtValorDesconto)
        Me.grpFormacaoPreco.Controls.Add(Me.lblDesconto)
        Me.grpFormacaoPreco.Controls.Add(Me.btnCalcularDesconto)
        Me.grpFormacaoPreco.Controls.Add(Me.btnDespesaFixa)
        Me.grpFormacaoPreco.Controls.Add(Me.btnDespesaVariavel)
        Me.grpFormacaoPreco.Controls.Add(Me.txtValorComIPI)
        Me.grpFormacaoPreco.Controls.Add(Me.lblValorComIPI)
        Me.grpFormacaoPreco.Controls.Add(Me.txtAliquotaIPI)
        Me.grpFormacaoPreco.Controls.Add(Me.lblAliquotaIPI)
        Me.grpFormacaoPreco.Controls.Add(Me.txtPrecoVenda)
        Me.grpFormacaoPreco.Controls.Add(Me.txtPrecoVendaPorcentagem)
        Me.grpFormacaoPreco.Controls.Add(Me.lblPrecoVenda)
        Me.grpFormacaoPreco.Controls.Add(Me.txtLucro)
        Me.grpFormacaoPreco.Controls.Add(Me.txtLucroPorcentagem)
        Me.grpFormacaoPreco.Controls.Add(Me.lblLucro)
        Me.grpFormacaoPreco.Controls.Add(Me.txtDespesaFixa)
        Me.grpFormacaoPreco.Controls.Add(Me.txtDespesaFixaPorcentagem)
        Me.grpFormacaoPreco.Controls.Add(Me.lblDespesaFixa)
        Me.grpFormacaoPreco.Controls.Add(Me.txtDespesaVariavel)
        Me.grpFormacaoPreco.Controls.Add(Me.txtDespesaVariavelPorcentagem)
        Me.grpFormacaoPreco.Controls.Add(Me.lblDespesaVariavel)
        Me.grpFormacaoPreco.Controls.Add(Me.txtCustoTotal)
        Me.grpFormacaoPreco.Controls.Add(Me.txtCustoTotalPorcentagem)
        Me.grpFormacaoPreco.Controls.Add(Me.lblCustoTotal)
        Me.grpFormacaoPreco.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFormacaoPreco.Location = New System.Drawing.Point(8, 3)
        Me.grpFormacaoPreco.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpFormacaoPreco.Name = "grpFormacaoPreco"
        Me.grpFormacaoPreco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFormacaoPreco.Size = New System.Drawing.Size(206, 406)
        Me.grpFormacaoPreco.TabIndex = 0
        Me.grpFormacaoPreco.Text = "Dados"
        Me.grpFormacaoPreco.VisualStyleManager = Me.vsmMain
        '
        'txtValorContrato
        '
        Me.txtValorContrato.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorContrato.DecimalDigits = 2
        Me.txtValorContrato.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtValorContrato.Location = New System.Drawing.Point(9, 287)
        Me.txtValorContrato.Name = "txtValorContrato"
        Me.txtValorContrato.ReadOnly = True
        Me.txtValorContrato.Size = New System.Drawing.Size(100, 20)
        Me.txtValorContrato.TabIndex = 118
        Me.txtValorContrato.TabStop = False
        Me.txtValorContrato.Text = "R$ 0,00"
        Me.txtValorContrato.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorContrato
        '
        Me.lblValorContrato.AutoSize = True
        Me.lblValorContrato.Location = New System.Drawing.Point(6, 270)
        Me.lblValorContrato.Name = "lblValorContrato"
        Me.lblValorContrato.Size = New System.Drawing.Size(79, 14)
        Me.lblValorContrato.TabIndex = 119
        Me.lblValorContrato.Text = "Valor Contrato:"
        '
        'txtDescontoPorcentagem
        '
        Me.txtDescontoPorcentagem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescontoPorcentagem.DecimalDigits = 6
        Me.txtDescontoPorcentagem.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtDescontoPorcentagem.Location = New System.Drawing.Point(115, 244)
        Me.txtDescontoPorcentagem.Name = "txtDescontoPorcentagem"
        Me.txtDescontoPorcentagem.ReadOnly = True
        Me.txtDescontoPorcentagem.Size = New System.Drawing.Size(81, 20)
        Me.txtDescontoPorcentagem.TabIndex = 117
        Me.txtDescontoPorcentagem.TabStop = False
        Me.txtDescontoPorcentagem.Text = "0,000000%"
        Me.txtDescontoPorcentagem.Value = New Decimal(New Integer() {0, 0, 0, 393216})
        '
        'txtValorDesconto
        '
        Me.txtValorDesconto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorDesconto.DecimalDigits = 2
        Me.txtValorDesconto.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtValorDesconto.Location = New System.Drawing.Point(9, 244)
        Me.txtValorDesconto.Name = "txtValorDesconto"
        Me.txtValorDesconto.ReadOnly = True
        Me.txtValorDesconto.Size = New System.Drawing.Size(100, 20)
        Me.txtValorDesconto.TabIndex = 115
        Me.txtValorDesconto.TabStop = False
        Me.txtValorDesconto.Text = "R$ 0,00"
        Me.txtValorDesconto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblDesconto
        '
        Me.lblDesconto.AutoSize = True
        Me.lblDesconto.Location = New System.Drawing.Point(6, 227)
        Me.lblDesconto.Name = "lblDesconto"
        Me.lblDesconto.Size = New System.Drawing.Size(56, 14)
        Me.lblDesconto.TabIndex = 116
        Me.lblDesconto.Text = "Desconto:"
        '
        'btnCalcularDesconto
        '
        Me.btnCalcularDesconto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcularDesconto.FlatAppearance.BorderSize = 0
        Me.btnCalcularDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcularDesconto.Image = Global.INTERACTI.My.Resources.Resources.calculadora
        Me.btnCalcularDesconto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCalcularDesconto.Location = New System.Drawing.Point(179, 226)
        Me.btnCalcularDesconto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCalcularDesconto.Name = "btnCalcularDesconto"
        Me.btnCalcularDesconto.Size = New System.Drawing.Size(17, 16)
        Me.btnCalcularDesconto.TabIndex = 114
        Me.btnCalcularDesconto.TabStop = False
        Me.btnCalcularDesconto.UseVisualStyleBackColor = True
        '
        'btnDespesaFixa
        '
        Me.btnDespesaFixa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDespesaFixa.BackColor = System.Drawing.Color.Transparent
        Me.btnDespesaFixa.FlatAppearance.BorderSize = 0
        Me.btnDespesaFixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDespesaFixa.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnDespesaFixa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDespesaFixa.Location = New System.Drawing.Point(173, 100)
        Me.btnDespesaFixa.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDespesaFixa.Name = "btnDespesaFixa"
        Me.btnDespesaFixa.Size = New System.Drawing.Size(24, 15)
        Me.btnDespesaFixa.TabIndex = 24
        Me.btnDespesaFixa.TabStop = False
        Me.btnDespesaFixa.UseVisualStyleBackColor = False
        Me.btnDespesaFixa.Visible = False
        '
        'btnDespesaVariavel
        '
        Me.btnDespesaVariavel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDespesaVariavel.BackColor = System.Drawing.Color.Transparent
        Me.btnDespesaVariavel.FlatAppearance.BorderSize = 0
        Me.btnDespesaVariavel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDespesaVariavel.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnDespesaVariavel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDespesaVariavel.Location = New System.Drawing.Point(173, 58)
        Me.btnDespesaVariavel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDespesaVariavel.Name = "btnDespesaVariavel"
        Me.btnDespesaVariavel.Size = New System.Drawing.Size(24, 15)
        Me.btnDespesaVariavel.TabIndex = 23
        Me.btnDespesaVariavel.TabStop = False
        Me.btnDespesaVariavel.UseVisualStyleBackColor = False
        Me.btnDespesaVariavel.Visible = False
        '
        'txtValorComIPI
        '
        Me.txtValorComIPI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorComIPI.DecimalDigits = 2
        Me.txtValorComIPI.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtValorComIPI.Location = New System.Drawing.Point(9, 371)
        Me.txtValorComIPI.Name = "txtValorComIPI"
        Me.txtValorComIPI.ReadOnly = True
        Me.txtValorComIPI.Size = New System.Drawing.Size(100, 20)
        Me.txtValorComIPI.TabIndex = 11
        Me.txtValorComIPI.TabStop = False
        Me.txtValorComIPI.Text = "R$ 0,00"
        Me.txtValorComIPI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorComIPI
        '
        Me.lblValorComIPI.AutoSize = True
        Me.lblValorComIPI.Location = New System.Drawing.Point(6, 354)
        Me.lblValorComIPI.Name = "lblValorComIPI"
        Me.lblValorComIPI.Size = New System.Drawing.Size(72, 14)
        Me.lblValorComIPI.TabIndex = 21
        Me.lblValorComIPI.Text = "Valor Com IPI:"
        '
        'txtAliquotaIPI
        '
        Me.txtAliquotaIPI.DecimalDigits = 2
        Me.txtAliquotaIPI.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaIPI.Location = New System.Drawing.Point(9, 329)
        Me.txtAliquotaIPI.Name = "txtAliquotaIPI"
        Me.txtAliquotaIPI.Size = New System.Drawing.Size(50, 20)
        Me.txtAliquotaIPI.TabIndex = 10
        Me.txtAliquotaIPI.Text = "0,00%"
        Me.txtAliquotaIPI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaIPI
        '
        Me.lblAliquotaIPI.AutoSize = True
        Me.lblAliquotaIPI.Location = New System.Drawing.Point(6, 312)
        Me.lblAliquotaIPI.Name = "lblAliquotaIPI"
        Me.lblAliquotaIPI.Size = New System.Drawing.Size(20, 14)
        Me.lblAliquotaIPI.TabIndex = 19
        Me.lblAliquotaIPI.Text = "IPI:"
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPrecoVenda.DecimalDigits = 2
        Me.txtPrecoVenda.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtPrecoVenda.Location = New System.Drawing.Point(9, 202)
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.ReadOnly = True
        Me.txtPrecoVenda.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecoVenda.TabIndex = 8
        Me.txtPrecoVenda.TabStop = False
        Me.txtPrecoVenda.Text = "R$ 0,00"
        Me.txtPrecoVenda.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtPrecoVendaPorcentagem
        '
        Me.txtPrecoVendaPorcentagem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPrecoVendaPorcentagem.DecimalDigits = 2
        Me.txtPrecoVendaPorcentagem.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtPrecoVendaPorcentagem.Location = New System.Drawing.Point(115, 202)
        Me.txtPrecoVendaPorcentagem.Name = "txtPrecoVendaPorcentagem"
        Me.txtPrecoVendaPorcentagem.ReadOnly = True
        Me.txtPrecoVendaPorcentagem.Size = New System.Drawing.Size(81, 20)
        Me.txtPrecoVendaPorcentagem.TabIndex = 9
        Me.txtPrecoVendaPorcentagem.TabStop = False
        Me.txtPrecoVendaPorcentagem.Text = "0,00%"
        Me.txtPrecoVendaPorcentagem.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPrecoVenda
        '
        Me.lblPrecoVenda.AutoSize = True
        Me.lblPrecoVenda.Location = New System.Drawing.Point(6, 185)
        Me.lblPrecoVenda.Name = "lblPrecoVenda"
        Me.lblPrecoVenda.Size = New System.Drawing.Size(72, 14)
        Me.lblPrecoVenda.TabIndex = 16
        Me.lblPrecoVenda.Text = "Preço Venda:"
        '
        'txtLucro
        '
        Me.txtLucro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLucro.DecimalDigits = 2
        Me.txtLucro.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtLucro.Location = New System.Drawing.Point(9, 160)
        Me.txtLucro.Name = "txtLucro"
        Me.txtLucro.ReadOnly = True
        Me.txtLucro.Size = New System.Drawing.Size(100, 20)
        Me.txtLucro.TabIndex = 6
        Me.txtLucro.TabStop = False
        Me.txtLucro.Text = "R$ 0,00"
        Me.txtLucro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtLucroPorcentagem
        '
        Me.txtLucroPorcentagem.DecimalDigits = 6
        Me.txtLucroPorcentagem.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtLucroPorcentagem.Location = New System.Drawing.Point(115, 160)
        Me.txtLucroPorcentagem.Name = "txtLucroPorcentagem"
        Me.txtLucroPorcentagem.Size = New System.Drawing.Size(81, 20)
        Me.txtLucroPorcentagem.TabIndex = 7
        Me.txtLucroPorcentagem.Text = "0,000000%"
        Me.txtLucroPorcentagem.Value = New Decimal(New Integer() {0, 0, 0, 393216})
        '
        'lblLucro
        '
        Me.lblLucro.AutoSize = True
        Me.lblLucro.Location = New System.Drawing.Point(6, 143)
        Me.lblLucro.Name = "lblLucro"
        Me.lblLucro.Size = New System.Drawing.Size(38, 14)
        Me.lblLucro.TabIndex = 13
        Me.lblLucro.Text = "Lucro:"
        '
        'txtDespesaFixa
        '
        Me.txtDespesaFixa.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDespesaFixa.DecimalDigits = 2
        Me.txtDespesaFixa.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtDespesaFixa.Location = New System.Drawing.Point(9, 118)
        Me.txtDespesaFixa.Name = "txtDespesaFixa"
        Me.txtDespesaFixa.ReadOnly = True
        Me.txtDespesaFixa.Size = New System.Drawing.Size(100, 20)
        Me.txtDespesaFixa.TabIndex = 4
        Me.txtDespesaFixa.TabStop = False
        Me.txtDespesaFixa.Text = "R$ 0,00"
        Me.txtDespesaFixa.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtDespesaFixaPorcentagem
        '
        Me.txtDespesaFixaPorcentagem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDespesaFixaPorcentagem.DecimalDigits = 2
        Me.txtDespesaFixaPorcentagem.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtDespesaFixaPorcentagem.Location = New System.Drawing.Point(115, 118)
        Me.txtDespesaFixaPorcentagem.Name = "txtDespesaFixaPorcentagem"
        Me.txtDespesaFixaPorcentagem.ReadOnly = True
        Me.txtDespesaFixaPorcentagem.Size = New System.Drawing.Size(81, 20)
        Me.txtDespesaFixaPorcentagem.TabIndex = 5
        Me.txtDespesaFixaPorcentagem.TabStop = False
        Me.txtDespesaFixaPorcentagem.Text = "0,00%"
        Me.txtDespesaFixaPorcentagem.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblDespesaFixa
        '
        Me.lblDespesaFixa.AutoSize = True
        Me.lblDespesaFixa.Location = New System.Drawing.Point(6, 101)
        Me.lblDespesaFixa.Name = "lblDespesaFixa"
        Me.lblDespesaFixa.Size = New System.Drawing.Size(76, 14)
        Me.lblDespesaFixa.TabIndex = 10
        Me.lblDespesaFixa.Text = "Despesa Fixa:"
        '
        'txtDespesaVariavel
        '
        Me.txtDespesaVariavel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDespesaVariavel.DecimalDigits = 2
        Me.txtDespesaVariavel.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtDespesaVariavel.Location = New System.Drawing.Point(9, 76)
        Me.txtDespesaVariavel.Name = "txtDespesaVariavel"
        Me.txtDespesaVariavel.ReadOnly = True
        Me.txtDespesaVariavel.Size = New System.Drawing.Size(100, 20)
        Me.txtDespesaVariavel.TabIndex = 2
        Me.txtDespesaVariavel.TabStop = False
        Me.txtDespesaVariavel.Text = "R$ 0,00"
        Me.txtDespesaVariavel.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtDespesaVariavelPorcentagem
        '
        Me.txtDespesaVariavelPorcentagem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDespesaVariavelPorcentagem.DecimalDigits = 2
        Me.txtDespesaVariavelPorcentagem.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtDespesaVariavelPorcentagem.Location = New System.Drawing.Point(115, 76)
        Me.txtDespesaVariavelPorcentagem.Name = "txtDespesaVariavelPorcentagem"
        Me.txtDespesaVariavelPorcentagem.ReadOnly = True
        Me.txtDespesaVariavelPorcentagem.Size = New System.Drawing.Size(81, 20)
        Me.txtDespesaVariavelPorcentagem.TabIndex = 3
        Me.txtDespesaVariavelPorcentagem.TabStop = False
        Me.txtDespesaVariavelPorcentagem.Text = "0,00%"
        Me.txtDespesaVariavelPorcentagem.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblDespesaVariavel
        '
        Me.lblDespesaVariavel.AutoSize = True
        Me.lblDespesaVariavel.Location = New System.Drawing.Point(6, 59)
        Me.lblDespesaVariavel.Name = "lblDespesaVariavel"
        Me.lblDespesaVariavel.Size = New System.Drawing.Size(95, 14)
        Me.lblDespesaVariavel.TabIndex = 7
        Me.lblDespesaVariavel.Text = "Despesa Variável:"
        '
        'txtCustoTotal
        '
        Me.txtCustoTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCustoTotal.DecimalDigits = 2
        Me.txtCustoTotal.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency
        Me.txtCustoTotal.Location = New System.Drawing.Point(9, 34)
        Me.txtCustoTotal.Name = "txtCustoTotal"
        Me.txtCustoTotal.ReadOnly = True
        Me.txtCustoTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtCustoTotal.TabIndex = 0
        Me.txtCustoTotal.TabStop = False
        Me.txtCustoTotal.Text = "R$ 0,00"
        Me.txtCustoTotal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtCustoTotalPorcentagem
        '
        Me.txtCustoTotalPorcentagem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCustoTotalPorcentagem.DecimalDigits = 6
        Me.txtCustoTotalPorcentagem.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtCustoTotalPorcentagem.Location = New System.Drawing.Point(115, 34)
        Me.txtCustoTotalPorcentagem.Name = "txtCustoTotalPorcentagem"
        Me.txtCustoTotalPorcentagem.ReadOnly = True
        Me.txtCustoTotalPorcentagem.Size = New System.Drawing.Size(81, 20)
        Me.txtCustoTotalPorcentagem.TabIndex = 1
        Me.txtCustoTotalPorcentagem.TabStop = False
        Me.txtCustoTotalPorcentagem.Text = "0,000000%"
        Me.txtCustoTotalPorcentagem.Value = New Decimal(New Integer() {0, 0, 0, 393216})
        '
        'lblCustoTotal
        '
        Me.lblCustoTotal.AutoSize = True
        Me.lblCustoTotal.Location = New System.Drawing.Point(6, 17)
        Me.lblCustoTotal.Name = "lblCustoTotal"
        Me.lblCustoTotal.Size = New System.Drawing.Size(63, 14)
        Me.lblCustoTotal.TabIndex = 4
        Me.lblCustoTotal.Text = "Custo Total:"
        '
        'grpDespesaVariavel
        '
        Me.grpDespesaVariavel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDespesaVariavel.BackColor = System.Drawing.Color.Transparent
        Me.grpDespesaVariavel.Controls.Add(Me.txtAliquotaCSLL)
        Me.grpDespesaVariavel.Controls.Add(Me.lblAliquotaCSLL)
        Me.grpDespesaVariavel.Controls.Add(Me.btnImportarRegra)
        Me.grpDespesaVariavel.Controls.Add(Me.txtAliquotaIR)
        Me.grpDespesaVariavel.Controls.Add(Me.lblAliquotaIR)
        Me.grpDespesaVariavel.Controls.Add(Me.txtAliquotaICMSReduzida)
        Me.grpDespesaVariavel.Controls.Add(Me.txtComissaoPorcentagem)
        Me.grpDespesaVariavel.Controls.Add(Me.lblComissao)
        Me.grpDespesaVariavel.Controls.Add(Me.lblAliquotaICMSReduzida)
        Me.grpDespesaVariavel.Controls.Add(Me.txtPorcentagemReducaoBCICMS)
        Me.grpDespesaVariavel.Controls.Add(Me.lblPorcentagemReducaoBCICMS)
        Me.grpDespesaVariavel.Controls.Add(Me.txtAliquotaISSPorcentagem)
        Me.grpDespesaVariavel.Controls.Add(Me.lblAliquotaISS)
        Me.grpDespesaVariavel.Controls.Add(Me.txtAliquotaCOFINSPorcentagem)
        Me.grpDespesaVariavel.Controls.Add(Me.lblAliquotaCOFINS)
        Me.grpDespesaVariavel.Controls.Add(Me.txtAliquotaPISPorcentagem)
        Me.grpDespesaVariavel.Controls.Add(Me.lblAliquotaPIS)
        Me.grpDespesaVariavel.Controls.Add(Me.txtAliquotaICMSPorcentagem)
        Me.grpDespesaVariavel.Controls.Add(Me.lblAliquotaICMS)
        Me.grpDespesaVariavel.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDespesaVariavel.Location = New System.Drawing.Point(640, 4)
        Me.grpDespesaVariavel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDespesaVariavel.Name = "grpDespesaVariavel"
        Me.grpDespesaVariavel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDespesaVariavel.Size = New System.Drawing.Size(142, 435)
        Me.grpDespesaVariavel.TabIndex = 1
        Me.grpDespesaVariavel.Text = "Despesa Variável"
        Me.grpDespesaVariavel.Visible = False
        Me.grpDespesaVariavel.VisualStyleManager = Me.vsmMain
        '
        'txtAliquotaCSLL
        '
        Me.txtAliquotaCSLL.DecimalDigits = 2
        Me.txtAliquotaCSLL.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaCSLL.Location = New System.Drawing.Point(9, 328)
        Me.txtAliquotaCSLL.Name = "txtAliquotaCSLL"
        Me.txtAliquotaCSLL.Size = New System.Drawing.Size(121, 20)
        Me.txtAliquotaCSLL.TabIndex = 7
        Me.txtAliquotaCSLL.Text = "0,00%"
        Me.txtAliquotaCSLL.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaCSLL
        '
        Me.lblAliquotaCSLL.AutoSize = True
        Me.lblAliquotaCSLL.Location = New System.Drawing.Point(6, 311)
        Me.lblAliquotaCSLL.Name = "lblAliquotaCSLL"
        Me.lblAliquotaCSLL.Size = New System.Drawing.Size(78, 14)
        Me.lblAliquotaCSLL.TabIndex = 28
        Me.lblAliquotaCSLL.Text = "Alíquota CSLL:"
        '
        'btnImportarRegra
        '
        Me.btnImportarRegra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportarRegra.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnImportarRegra.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarRegra.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnImportarRegra.Location = New System.Drawing.Point(9, 399)
        Me.btnImportarRegra.Name = "btnImportarRegra"
        Me.btnImportarRegra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportarRegra.Size = New System.Drawing.Size(121, 23)
        Me.btnImportarRegra.TabIndex = 10
        Me.btnImportarRegra.Text = "Importar Regra"
        Me.btnImportarRegra.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtAliquotaIR
        '
        Me.txtAliquotaIR.DecimalDigits = 2
        Me.txtAliquotaIR.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaIR.Location = New System.Drawing.Point(9, 286)
        Me.txtAliquotaIR.Name = "txtAliquotaIR"
        Me.txtAliquotaIR.Size = New System.Drawing.Size(121, 20)
        Me.txtAliquotaIR.TabIndex = 6
        Me.txtAliquotaIR.Text = "0,00%"
        Me.txtAliquotaIR.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaIR
        '
        Me.lblAliquotaIR.AutoSize = True
        Me.lblAliquotaIR.Location = New System.Drawing.Point(6, 269)
        Me.lblAliquotaIR.Name = "lblAliquotaIR"
        Me.lblAliquotaIR.Size = New System.Drawing.Size(61, 14)
        Me.lblAliquotaIR.TabIndex = 26
        Me.lblAliquotaIR.Text = "Alíquota IR:"
        '
        'txtAliquotaICMSReduzida
        '
        Me.txtAliquotaICMSReduzida.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAliquotaICMSReduzida.DecimalDigits = 2
        Me.txtAliquotaICMSReduzida.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaICMSReduzida.Location = New System.Drawing.Point(9, 118)
        Me.txtAliquotaICMSReduzida.Name = "txtAliquotaICMSReduzida"
        Me.txtAliquotaICMSReduzida.ReadOnly = True
        Me.txtAliquotaICMSReduzida.Size = New System.Drawing.Size(121, 20)
        Me.txtAliquotaICMSReduzida.TabIndex = 2
        Me.txtAliquotaICMSReduzida.TabStop = False
        Me.txtAliquotaICMSReduzida.Text = "0,00%"
        Me.txtAliquotaICMSReduzida.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtComissaoPorcentagem
        '
        Me.txtComissaoPorcentagem.DecimalDigits = 2
        Me.txtComissaoPorcentagem.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtComissaoPorcentagem.Location = New System.Drawing.Point(9, 370)
        Me.txtComissaoPorcentagem.Name = "txtComissaoPorcentagem"
        Me.txtComissaoPorcentagem.Size = New System.Drawing.Size(121, 20)
        Me.txtComissaoPorcentagem.TabIndex = 8
        Me.txtComissaoPorcentagem.Text = "0,00%"
        Me.txtComissaoPorcentagem.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblComissao
        '
        Me.lblComissao.AutoSize = True
        Me.lblComissao.Location = New System.Drawing.Point(6, 353)
        Me.lblComissao.Name = "lblComissao"
        Me.lblComissao.Size = New System.Drawing.Size(57, 14)
        Me.lblComissao.TabIndex = 19
        Me.lblComissao.Text = "Comissão:"
        '
        'lblAliquotaICMSReduzida
        '
        Me.lblAliquotaICMSReduzida.AutoSize = True
        Me.lblAliquotaICMSReduzida.Location = New System.Drawing.Point(6, 101)
        Me.lblAliquotaICMSReduzida.Name = "lblAliquotaICMSReduzida"
        Me.lblAliquotaICMSReduzida.Size = New System.Drawing.Size(124, 14)
        Me.lblAliquotaICMSReduzida.TabIndex = 23
        Me.lblAliquotaICMSReduzida.Text = "Alíquota ICMS Reduzida:"
        '
        'txtPorcentagemReducaoBCICMS
        '
        Me.txtPorcentagemReducaoBCICMS.DecimalDigits = 2
        Me.txtPorcentagemReducaoBCICMS.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtPorcentagemReducaoBCICMS.Location = New System.Drawing.Point(9, 34)
        Me.txtPorcentagemReducaoBCICMS.Name = "txtPorcentagemReducaoBCICMS"
        Me.txtPorcentagemReducaoBCICMS.Size = New System.Drawing.Size(121, 20)
        Me.txtPorcentagemReducaoBCICMS.TabIndex = 0
        Me.txtPorcentagemReducaoBCICMS.Text = "0,00%"
        Me.txtPorcentagemReducaoBCICMS.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPorcentagemReducaoBCICMS
        '
        Me.lblPorcentagemReducaoBCICMS.AutoSize = True
        Me.lblPorcentagemReducaoBCICMS.Location = New System.Drawing.Point(6, 17)
        Me.lblPorcentagemReducaoBCICMS.Name = "lblPorcentagemReducaoBCICMS"
        Me.lblPorcentagemReducaoBCICMS.Size = New System.Drawing.Size(110, 14)
        Me.lblPorcentagemReducaoBCICMS.TabIndex = 21
        Me.lblPorcentagemReducaoBCICMS.Text = "% Redução BC ICMS:"
        '
        'txtAliquotaISSPorcentagem
        '
        Me.txtAliquotaISSPorcentagem.DecimalDigits = 2
        Me.txtAliquotaISSPorcentagem.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaISSPorcentagem.Location = New System.Drawing.Point(9, 244)
        Me.txtAliquotaISSPorcentagem.Name = "txtAliquotaISSPorcentagem"
        Me.txtAliquotaISSPorcentagem.Size = New System.Drawing.Size(121, 20)
        Me.txtAliquotaISSPorcentagem.TabIndex = 5
        Me.txtAliquotaISSPorcentagem.Text = "0,00%"
        Me.txtAliquotaISSPorcentagem.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaISS
        '
        Me.lblAliquotaISS.AutoSize = True
        Me.lblAliquotaISS.Location = New System.Drawing.Point(6, 227)
        Me.lblAliquotaISS.Name = "lblAliquotaISS"
        Me.lblAliquotaISS.Size = New System.Drawing.Size(68, 14)
        Me.lblAliquotaISS.TabIndex = 16
        Me.lblAliquotaISS.Text = "Alíquota ISS:"
        '
        'txtAliquotaCOFINSPorcentagem
        '
        Me.txtAliquotaCOFINSPorcentagem.DecimalDigits = 2
        Me.txtAliquotaCOFINSPorcentagem.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaCOFINSPorcentagem.Location = New System.Drawing.Point(9, 202)
        Me.txtAliquotaCOFINSPorcentagem.Name = "txtAliquotaCOFINSPorcentagem"
        Me.txtAliquotaCOFINSPorcentagem.Size = New System.Drawing.Size(121, 20)
        Me.txtAliquotaCOFINSPorcentagem.TabIndex = 4
        Me.txtAliquotaCOFINSPorcentagem.Text = "0,00%"
        Me.txtAliquotaCOFINSPorcentagem.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaCOFINS
        '
        Me.lblAliquotaCOFINS.AutoSize = True
        Me.lblAliquotaCOFINS.Location = New System.Drawing.Point(6, 185)
        Me.lblAliquotaCOFINS.Name = "lblAliquotaCOFINS"
        Me.lblAliquotaCOFINS.Size = New System.Drawing.Size(89, 14)
        Me.lblAliquotaCOFINS.TabIndex = 13
        Me.lblAliquotaCOFINS.Text = "Alíquota COFINS:"
        '
        'txtAliquotaPISPorcentagem
        '
        Me.txtAliquotaPISPorcentagem.DecimalDigits = 2
        Me.txtAliquotaPISPorcentagem.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaPISPorcentagem.Location = New System.Drawing.Point(9, 160)
        Me.txtAliquotaPISPorcentagem.Name = "txtAliquotaPISPorcentagem"
        Me.txtAliquotaPISPorcentagem.Size = New System.Drawing.Size(121, 20)
        Me.txtAliquotaPISPorcentagem.TabIndex = 3
        Me.txtAliquotaPISPorcentagem.Text = "0,00%"
        Me.txtAliquotaPISPorcentagem.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaPIS
        '
        Me.lblAliquotaPIS.AutoSize = True
        Me.lblAliquotaPIS.Location = New System.Drawing.Point(6, 143)
        Me.lblAliquotaPIS.Name = "lblAliquotaPIS"
        Me.lblAliquotaPIS.Size = New System.Drawing.Size(67, 14)
        Me.lblAliquotaPIS.TabIndex = 10
        Me.lblAliquotaPIS.Text = "Alíquota PIS:"
        '
        'txtAliquotaICMSPorcentagem
        '
        Me.txtAliquotaICMSPorcentagem.DecimalDigits = 2
        Me.txtAliquotaICMSPorcentagem.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaICMSPorcentagem.Location = New System.Drawing.Point(9, 76)
        Me.txtAliquotaICMSPorcentagem.Name = "txtAliquotaICMSPorcentagem"
        Me.txtAliquotaICMSPorcentagem.Size = New System.Drawing.Size(121, 20)
        Me.txtAliquotaICMSPorcentagem.TabIndex = 1
        Me.txtAliquotaICMSPorcentagem.Text = "0,00%"
        Me.txtAliquotaICMSPorcentagem.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaICMS
        '
        Me.lblAliquotaICMS.AutoSize = True
        Me.lblAliquotaICMS.Location = New System.Drawing.Point(6, 59)
        Me.lblAliquotaICMS.Name = "lblAliquotaICMS"
        Me.lblAliquotaICMS.Size = New System.Drawing.Size(76, 14)
        Me.lblAliquotaICMS.TabIndex = 7
        Me.lblAliquotaICMS.Text = "Alíquota ICMS:"
        '
        'pagChecklistCliente
        '
        Me.pagChecklistCliente.Controls.Add(Me.grdOrcamentoCheckListCliente)
        Me.pagChecklistCliente.Key = "pagChecklistCliente"
        Me.pagChecklistCliente.Location = New System.Drawing.Point(1, 22)
        Me.pagChecklistCliente.Name = "pagChecklistCliente"
        Me.pagChecklistCliente.Size = New System.Drawing.Size(785, 413)
        Me.pagChecklistCliente.TabStop = True
        Me.pagChecklistCliente.Text = "Requisitos do Item"
        '
        'grdOrcamentoCheckListCliente
        '
        Me.grdOrcamentoCheckListCliente.AlternatingColors = True
        Me.grdOrcamentoCheckListCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdOrcamentoCheckListCliente_DesignTimeLayout.LayoutString = resources.GetString("grdOrcamentoCheckListCliente_DesignTimeLayout.LayoutString")
        Me.grdOrcamentoCheckListCliente.DesignTimeLayout = grdOrcamentoCheckListCliente_DesignTimeLayout
        Me.grdOrcamentoCheckListCliente.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdOrcamentoCheckListCliente.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrcamentoCheckListCliente.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed
        Me.grdOrcamentoCheckListCliente.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrcamentoCheckListCliente.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOrcamentoCheckListCliente.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrcamentoCheckListCliente.GroupByBoxVisible = False
        Me.grdOrcamentoCheckListCliente.Location = New System.Drawing.Point(6, 3)
        Me.grdOrcamentoCheckListCliente.Name = "grdOrcamentoCheckListCliente"
        Me.grdOrcamentoCheckListCliente.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamentoCheckListCliente.RecordNavigator = True
        Me.grdOrcamentoCheckListCliente.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdOrcamentoCheckListCliente.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOrcamentoCheckListCliente.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamentoCheckListCliente.Size = New System.Drawing.Size(770, 407)
        Me.grdOrcamentoCheckListCliente.TabIndex = 5
        Me.grdOrcamentoCheckListCliente.TabStop = False
        Me.grdOrcamentoCheckListCliente.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamentoCheckListCliente.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnImportarContrato)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 449)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(785, 51)
        Me.grpControl2.TabIndex = 5
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnImportarContrato
        '
        Me.btnImportarContrato.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnImportarContrato.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarContrato.Location = New System.Drawing.Point(6, 17)
        Me.btnImportarContrato.Name = "btnImportarContrato"
        Me.btnImportarContrato.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportarContrato.Size = New System.Drawing.Size(117, 23)
        Me.btnImportarContrato.TabIndex = 4
        Me.btnImportarContrato.Text = "Importar Contrato"
        Me.btnImportarContrato.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(588, 17)
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
        Me.btnSair.Location = New System.Drawing.Point(685, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmVenOrcamentoComposicao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 512)
        Me.Controls.Add(Me.grpControl2)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmVenOrcamentoComposicao"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Composição"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.chrComposicao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdOrcamentoGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagListaMaterialGrupo.ResumeLayout(False)
        CType(Me.grdOrcamentoListaMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagProcessoProdutivo.ResumeLayout(False)
        CType(Me.grdOrcamentoProcessoProdutivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagServicoTerceiro.ResumeLayout(False)
        CType(Me.grpServicoTerceiros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpServicoTerceiros.ResumeLayout(False)
        Me.grpServicoTerceiros.PerformLayout()
        CType(Me.grdOrcamentoServicoTerceiros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMotivo.ResumeLayout(False)
        Me.grpMotivo.PerformLayout()
        Me.pagFormacaoPreco.ResumeLayout(False)
        CType(Me.chrFormacaoPreco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFormacaoPreco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFormacaoPreco.ResumeLayout(False)
        Me.grpFormacaoPreco.PerformLayout()
        CType(Me.grpDespesaVariavel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDespesaVariavel.ResumeLayout(False)
        Me.grpDespesaVariavel.PerformLayout()
        Me.pagChecklistCliente.ResumeLayout(False)
        CType(Me.grdOrcamentoCheckListCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpMotivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents grdOrcamentoProcessoProdutivo As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnImportarEstrutura As Janus.Windows.EditControls.UIButton
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagProcessoProdutivo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagServicoTerceiro As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagListaMaterialGrupo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdOrcamentoListaMaterial As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdOrcamentoServicoTerceiros As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdOrcamentoGrupo As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagFormacaoPreco As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents chrComposicao As Dundas.Charting.WinControl.Chart
    Friend WithEvents grpFormacaoPreco As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpDespesaVariavel As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtAliquotaCOFINSPorcentagem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaCOFINS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaPISPorcentagem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaPIS As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaICMSPorcentagem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaICMS As System.Windows.Forms.Label
    Friend WithEvents txtValorComIPI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorComIPI As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaIPI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaIPI As System.Windows.Forms.Label
    Friend WithEvents txtPrecoVenda As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtPrecoVendaPorcentagem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPrecoVenda As System.Windows.Forms.Label
    Friend WithEvents txtLucro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtLucroPorcentagem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblLucro As System.Windows.Forms.Label
    Friend WithEvents txtDespesaFixa As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtDespesaFixaPorcentagem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDespesaFixa As System.Windows.Forms.Label
    Friend WithEvents txtDespesaVariavel As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtDespesaVariavelPorcentagem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDespesaVariavel As System.Windows.Forms.Label
    Friend WithEvents txtCustoTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtCustoTotalPorcentagem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCustoTotal As System.Windows.Forms.Label
    Friend WithEvents txtComissaoPorcentagem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblComissao As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaISSPorcentagem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaISS As System.Windows.Forms.Label
    Friend WithEvents btnDespesaVariavel As System.Windows.Forms.Button
    Friend WithEvents btnDespesaFixa As System.Windows.Forms.Button
    Friend WithEvents chrFormacaoPreco As Dundas.Charting.WinControl.Chart
    Friend WithEvents txtPorcentagemReducaoBCICMS As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPorcentagemReducaoBCICMS As System.Windows.Forms.Label
    Friend WithEvents txtFrete As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblFrete As System.Windows.Forms.Label
    Friend WithEvents btnCalcularDesconto As System.Windows.Forms.Button
    Friend WithEvents grpServicoTerceiros As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnInserirServico As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents cboFornecedor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtValorUnitario As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnitario As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeServico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeServico As System.Windows.Forms.Label
    Friend WithEvents lblServicoTerceiros As System.Windows.Forms.Label
    Friend WithEvents cboServicoTerceiros As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents cboGrupo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtValorTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaICMSReduzida As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaICMSReduzida As System.Windows.Forms.Label
    Private WithEvents btnImportarRegra As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtDescontoPorcentagem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtValorDesconto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDesconto As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaCSLL As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaCSLL As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaIR As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaIR As System.Windows.Forms.Label
    Friend WithEvents btnImportarContrato As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtValorContrato As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorContrato As System.Windows.Forms.Label
    Friend WithEvents pagChecklistCliente As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdOrcamentoCheckListCliente As Janus.Windows.GridEX.GridEX
End Class
