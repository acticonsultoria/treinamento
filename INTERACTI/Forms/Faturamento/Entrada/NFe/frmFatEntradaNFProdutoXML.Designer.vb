<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEntradaNFProdutoXML
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
        Dim SuperTipSettings14 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings15 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings16 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEntradaNFProdutoXML))
        Dim grdRecebimento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdRecebimento_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdRecebimento_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim SuperTipSettings17 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings18 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings19 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings20 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings21 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings22 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings23 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings24 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings25 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings26 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim grdXML_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridRecebimento = New System.Windows.Forms.Button()
        Me.btnAgruparGridRecebimento = New System.Windows.Forms.Button()
        Me.btnExcelGridXML = New System.Windows.Forms.Button()
        Me.btnAgruparGridXML = New System.Windows.Forms.Button()
        Me.btnConfigurarGridRecebimento = New System.Windows.Forms.Button()
        Me.btnConfigurarGridXML = New System.Windows.Forms.Button()
        Me.grpEntrega = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnBaixarMultiplo = New System.Windows.Forms.Button()
        Me.chkCadastrarProduto = New Janus.Windows.EditControls.UICheckBox()
        Me.btnProcurarContaContabil = New System.Windows.Forms.Button()
        Me.btnCadastrarContaContabil = New System.Windows.Forms.Button()
        Me.lblContaContabil = New System.Windows.Forms.Label()
        Me.cboContaContabil = New Janus.Windows.EditControls.UIComboBox()
        Me.btnProcurarCentroGasto = New System.Windows.Forms.Button()
        Me.btnCadastrarCentroGasto = New System.Windows.Forms.Button()
        Me.lblCentroGasto = New System.Windows.Forms.Label()
        Me.cboCentroGasto = New Janus.Windows.EditControls.UIComboBox()
        Me.btnAtualizarPedidoCompra = New System.Windows.Forms.Button()
        Me.lblQuantidadeDocumento = New System.Windows.Forms.Label()
        Me.txtQuantidadeDocumento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnCadastrarUnidadeMedida = New System.Windows.Forms.Button()
        Me.lblUnidadeMedida = New System.Windows.Forms.Label()
        Me.cboUnidadeMedida = New Janus.Windows.EditControls.UIComboBox()
        Me.lblQuantidadeEstoque = New System.Windows.Forms.Label()
        Me.txtQuantidadeEstoque = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDataFabricacao = New System.Windows.Forms.Label()
        Me.dtpDataFabricacao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.lblDataValidade = New System.Windows.Forms.Label()
        Me.dtpDataValidade = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.txtLote = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnCadastrarProduto = New System.Windows.Forms.Button()
        Me.lblCFOP = New System.Windows.Forms.Label()
        Me.cboCFOP = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFatorConversao = New System.Windows.Forms.Label()
        Me.txtFatorConversao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.btnCadastrarDeposito = New System.Windows.Forms.Button()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.cboNumeroDocumento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.cboDeposito = New Janus.Windows.EditControls.UIComboBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTipoOperacao = New System.Windows.Forms.Label()
        Me.cboTipoOperacao = New Janus.Windows.EditControls.UIComboBox()
        Me.cboProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.grdRecebimento = New Janus.Windows.GridEX.GridEX()
        Me.grpControleDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtAliquotaICMSUltimaNF = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaPISCOFINSPedido = New System.Windows.Forms.Label()
        Me.txtAliquotaPISCOFINSPedido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaIPIPedido = New System.Windows.Forms.Label()
        Me.txtAliquotaIPIPedido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAliquotaICMSPedido = New System.Windows.Forms.Label()
        Me.txtAliquotaICMSPedido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorUnitarioPedido = New System.Windows.Forms.Label()
        Me.btnConfirmar = New Janus.Windows.EditControls.UIButton()
        Me.txtValorUnitarioPedido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.lblAliquotaICMSUltimaNF = New System.Windows.Forms.Label()
        Me.grdXML = New Janus.Windows.GridEX.GridEX()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEntrega.SuspendLayout()
        CType(Me.grdRecebimento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControleDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleDados.SuspendLayout()
        CType(Me.grdXML, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(1001, 646)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnExcelGridRecebimento)
        Me.pagDados.Controls.Add(Me.btnAgruparGridRecebimento)
        Me.pagDados.Controls.Add(Me.btnExcelGridXML)
        Me.pagDados.Controls.Add(Me.btnAgruparGridXML)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridRecebimento)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridXML)
        Me.pagDados.Controls.Add(Me.grpEntrega)
        Me.pagDados.Controls.Add(Me.grdRecebimento)
        Me.pagDados.Controls.Add(Me.grpControleDados)
        Me.pagDados.Controls.Add(Me.grdXML)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(999, 623)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Nota Fiscal - Produtos"
        '
        'btnExcelGridRecebimento
        '
        Me.btnExcelGridRecebimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridRecebimento.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridRecebimento.FlatAppearance.BorderSize = 0
        Me.btnExcelGridRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridRecebimento.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridRecebimento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridRecebimento.Location = New System.Drawing.Point(57, 543)
        Me.btnExcelGridRecebimento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridRecebimento.Name = "btnExcelGridRecebimento"
        Me.btnExcelGridRecebimento.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridRecebimento.TabIndex = 8
        Me.btnExcelGridRecebimento.TabStop = False
        Me.btnExcelGridRecebimento.UseVisualStyleBackColor = False
        '
        'btnAgruparGridRecebimento
        '
        Me.btnAgruparGridRecebimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridRecebimento.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridRecebimento.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridRecebimento.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridRecebimento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridRecebimento.Location = New System.Drawing.Point(33, 543)
        Me.btnAgruparGridRecebimento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridRecebimento.Name = "btnAgruparGridRecebimento"
        Me.btnAgruparGridRecebimento.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridRecebimento.TabIndex = 7
        Me.btnAgruparGridRecebimento.TabStop = False
        Me.btnAgruparGridRecebimento.UseVisualStyleBackColor = False
        '
        'btnExcelGridXML
        '
        Me.btnExcelGridXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridXML.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridXML.FlatAppearance.BorderSize = 0
        Me.btnExcelGridXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridXML.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridXML.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridXML.Location = New System.Drawing.Point(57, 243)
        Me.btnExcelGridXML.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridXML.Name = "btnExcelGridXML"
        Me.btnExcelGridXML.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridXML.TabIndex = 3
        Me.btnExcelGridXML.TabStop = False
        Me.btnExcelGridXML.UseVisualStyleBackColor = False
        '
        'btnAgruparGridXML
        '
        Me.btnAgruparGridXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridXML.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridXML.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridXML.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridXML.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridXML.Location = New System.Drawing.Point(33, 243)
        Me.btnAgruparGridXML.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridXML.Name = "btnAgruparGridXML"
        Me.btnAgruparGridXML.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridXML.TabIndex = 2
        Me.btnAgruparGridXML.TabStop = False
        Me.btnAgruparGridXML.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridRecebimento
        '
        Me.btnConfigurarGridRecebimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridRecebimento.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridRecebimento.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridRecebimento.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridRecebimento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridRecebimento.Location = New System.Drawing.Point(9, 543)
        Me.btnConfigurarGridRecebimento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridRecebimento.Name = "btnConfigurarGridRecebimento"
        Me.btnConfigurarGridRecebimento.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridRecebimento.TabIndex = 6
        Me.btnConfigurarGridRecebimento.TabStop = False
        Me.btnConfigurarGridRecebimento.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridXML
        '
        Me.btnConfigurarGridXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridXML.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridXML.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridXML.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridXML.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridXML.Location = New System.Drawing.Point(9, 243)
        Me.btnConfigurarGridXML.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridXML.Name = "btnConfigurarGridXML"
        Me.btnConfigurarGridXML.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridXML.TabIndex = 1
        Me.btnConfigurarGridXML.TabStop = False
        Me.btnConfigurarGridXML.UseVisualStyleBackColor = False
        '
        'grpEntrega
        '
        Me.grpEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEntrega.BackColor = System.Drawing.Color.Transparent
        Me.grpEntrega.Controls.Add(Me.btnBaixarMultiplo)
        Me.grpEntrega.Controls.Add(Me.chkCadastrarProduto)
        Me.grpEntrega.Controls.Add(Me.btnProcurarContaContabil)
        Me.grpEntrega.Controls.Add(Me.btnCadastrarContaContabil)
        Me.grpEntrega.Controls.Add(Me.lblContaContabil)
        Me.grpEntrega.Controls.Add(Me.cboContaContabil)
        Me.grpEntrega.Controls.Add(Me.btnProcurarCentroGasto)
        Me.grpEntrega.Controls.Add(Me.btnCadastrarCentroGasto)
        Me.grpEntrega.Controls.Add(Me.lblCentroGasto)
        Me.grpEntrega.Controls.Add(Me.cboCentroGasto)
        Me.grpEntrega.Controls.Add(Me.btnAtualizarPedidoCompra)
        Me.grpEntrega.Controls.Add(Me.lblQuantidadeDocumento)
        Me.grpEntrega.Controls.Add(Me.txtQuantidadeDocumento)
        Me.grpEntrega.Controls.Add(Me.btnCadastrarUnidadeMedida)
        Me.grpEntrega.Controls.Add(Me.lblUnidadeMedida)
        Me.grpEntrega.Controls.Add(Me.cboUnidadeMedida)
        Me.grpEntrega.Controls.Add(Me.lblQuantidadeEstoque)
        Me.grpEntrega.Controls.Add(Me.txtQuantidadeEstoque)
        Me.grpEntrega.Controls.Add(Me.lblDataFabricacao)
        Me.grpEntrega.Controls.Add(Me.dtpDataFabricacao)
        Me.grpEntrega.Controls.Add(Me.btnProcurarProduto)
        Me.grpEntrega.Controls.Add(Me.lblDataValidade)
        Me.grpEntrega.Controls.Add(Me.dtpDataValidade)
        Me.grpEntrega.Controls.Add(Me.lblLote)
        Me.grpEntrega.Controls.Add(Me.txtLote)
        Me.grpEntrega.Controls.Add(Me.btnCadastrarProduto)
        Me.grpEntrega.Controls.Add(Me.lblCFOP)
        Me.grpEntrega.Controls.Add(Me.cboCFOP)
        Me.grpEntrega.Controls.Add(Me.lblFatorConversao)
        Me.grpEntrega.Controls.Add(Me.txtFatorConversao)
        Me.grpEntrega.Controls.Add(Me.lblProduto)
        Me.grpEntrega.Controls.Add(Me.btnExcluir)
        Me.grpEntrega.Controls.Add(Me.btnInserir)
        Me.grpEntrega.Controls.Add(Me.btnCadastrarDeposito)
        Me.grpEntrega.Controls.Add(Me.lblNumeroDocumento)
        Me.grpEntrega.Controls.Add(Me.cboNumeroDocumento)
        Me.grpEntrega.Controls.Add(Me.lblDeposito)
        Me.grpEntrega.Controls.Add(Me.cboDeposito)
        Me.grpEntrega.Controls.Add(Me.lblQuantidade)
        Me.grpEntrega.Controls.Add(Me.txtQuantidade)
        Me.grpEntrega.Controls.Add(Me.lblTipoOperacao)
        Me.grpEntrega.Controls.Add(Me.cboTipoOperacao)
        Me.grpEntrega.Controls.Add(Me.cboProduto)
        Me.grpEntrega.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEntrega.Location = New System.Drawing.Point(8, 267)
        Me.grpEntrega.Name = "grpEntrega"
        Me.grpEntrega.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEntrega.Size = New System.Drawing.Size(983, 144)
        Me.grpEntrega.TabIndex = 0
        Me.grpEntrega.VisualStyleManager = Me.vsmMain
        '
        'btnBaixarMultiplo
        '
        Me.btnBaixarMultiplo.FlatAppearance.BorderSize = 0
        Me.btnBaixarMultiplo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaixarMultiplo.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnBaixarMultiplo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBaixarMultiplo.Location = New System.Drawing.Point(319, 15)
        Me.btnBaixarMultiplo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBaixarMultiplo.Name = "btnBaixarMultiplo"
        Me.btnBaixarMultiplo.Size = New System.Drawing.Size(17, 16)
        Me.btnBaixarMultiplo.TabIndex = 48
        Me.btnBaixarMultiplo.TabStop = False
        Me.btnBaixarMultiplo.UseVisualStyleBackColor = True
        '
        'chkCadastrarProduto
        '
        Me.chkCadastrarProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkCadastrarProduto.Location = New System.Drawing.Point(872, 30)
        Me.chkCadastrarProduto.Name = "chkCadastrarProduto"
        Me.chkCadastrarProduto.Size = New System.Drawing.Size(105, 24)
        Me.chkCadastrarProduto.TabIndex = 47
        Me.chkCadastrarProduto.TabStop = False
        Me.chkCadastrarProduto.Text = "Cadastrar Produto "
        '
        'btnProcurarContaContabil
        '
        Me.btnProcurarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnProcurarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarContaContabil.Location = New System.Drawing.Point(839, 96)
        Me.btnProcurarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarContaContabil.Name = "btnProcurarContaContabil"
        Me.btnProcurarContaContabil.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarContaContabil.TabIndex = 42
        Me.btnProcurarContaContabil.TabStop = False
        Me.btnProcurarContaContabil.UseVisualStyleBackColor = True
        '
        'btnCadastrarContaContabil
        '
        Me.btnCadastrarContaContabil.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaContabil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaContabil.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaContabil.Location = New System.Drawing.Point(602, 98)
        Me.btnCadastrarContaContabil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaContabil.Name = "btnCadastrarContaContabil"
        Me.btnCadastrarContaContabil.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaContabil.TabIndex = 40
        Me.btnCadastrarContaContabil.TabStop = False
        Me.btnCadastrarContaContabil.Text = "btnCadastrarContaContabil"
        Me.btnCadastrarContaContabil.UseVisualStyleBackColor = True
        '
        'lblContaContabil
        '
        Me.lblContaContabil.AutoSize = True
        Me.lblContaContabil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContaContabil.Location = New System.Drawing.Point(618, 97)
        Me.lblContaContabil.Name = "lblContaContabil"
        Me.lblContaContabil.Size = New System.Drawing.Size(79, 14)
        Me.lblContaContabil.TabIndex = 41
        Me.lblContaContabil.Text = "Conta Contábil:"
        '
        'cboContaContabil
        '
        Me.cboContaContabil.AutoSize = False
        Me.cboContaContabil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaContabil.Location = New System.Drawing.Point(602, 114)
        Me.cboContaContabil.Name = "cboContaContabil"
        Me.cboContaContabil.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaContabil.Size = New System.Drawing.Size(254, 20)
        Me.cboContaContabil.TabIndex = 43
        '
        'btnProcurarCentroGasto
        '
        Me.btnProcurarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnProcurarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCentroGasto.Location = New System.Drawing.Point(575, 96)
        Me.btnProcurarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCentroGasto.Name = "btnProcurarCentroGasto"
        Me.btnProcurarCentroGasto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCentroGasto.TabIndex = 38
        Me.btnProcurarCentroGasto.TabStop = False
        Me.btnProcurarCentroGasto.UseVisualStyleBackColor = True
        '
        'btnCadastrarCentroGasto
        '
        Me.btnCadastrarCentroGasto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCentroGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCentroGasto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCentroGasto.Location = New System.Drawing.Point(231, 98)
        Me.btnCadastrarCentroGasto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCentroGasto.Name = "btnCadastrarCentroGasto"
        Me.btnCadastrarCentroGasto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCentroGasto.TabIndex = 36
        Me.btnCadastrarCentroGasto.TabStop = False
        Me.btnCadastrarCentroGasto.UseVisualStyleBackColor = True
        '
        'lblCentroGasto
        '
        Me.lblCentroGasto.AutoSize = True
        Me.lblCentroGasto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCentroGasto.Location = New System.Drawing.Point(247, 97)
        Me.lblCentroGasto.Name = "lblCentroGasto"
        Me.lblCentroGasto.Size = New System.Drawing.Size(89, 14)
        Me.lblCentroGasto.TabIndex = 37
        Me.lblCentroGasto.Text = "Centro de Gasto:"
        '
        'cboCentroGasto
        '
        Me.cboCentroGasto.AutoSize = False
        Me.cboCentroGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCentroGasto.Location = New System.Drawing.Point(231, 114)
        Me.cboCentroGasto.Name = "cboCentroGasto"
        Me.cboCentroGasto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroGasto.Size = New System.Drawing.Size(365, 20)
        Me.cboCentroGasto.TabIndex = 39
        '
        'btnAtualizarPedidoCompra
        '
        Me.btnAtualizarPedidoCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtualizarPedidoCompra.FlatAppearance.BorderSize = 0
        Me.btnAtualizarPedidoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizarPedidoCompra.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnAtualizarPedidoCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAtualizarPedidoCompra.Location = New System.Drawing.Point(841, 18)
        Me.btnAtualizarPedidoCompra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAtualizarPedidoCompra.Name = "btnAtualizarPedidoCompra"
        Me.btnAtualizarPedidoCompra.Size = New System.Drawing.Size(15, 13)
        SuperTipSettings14.HeaderText = "Atualizar Pedido de Compra"
        SuperTipSettings14.ImageListProvider = Nothing
        SuperTipSettings14.Text = "Clique para Atualizar a Quantidade x Unidade de Medida do Pedido de Compra confor" & _
    "me Nota Fiscal recebida"
        Me.jstTip.SetSuperTip(Me.btnAtualizarPedidoCompra, SuperTipSettings14)
        Me.btnAtualizarPedidoCompra.TabIndex = 13
        Me.btnAtualizarPedidoCompra.TabStop = False
        Me.btnAtualizarPedidoCompra.UseVisualStyleBackColor = True
        '
        'lblQuantidadeDocumento
        '
        Me.lblQuantidadeDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeDocumento.AutoSize = True
        Me.lblQuantidadeDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeDocumento.Location = New System.Drawing.Point(748, 17)
        Me.lblQuantidadeDocumento.Name = "lblQuantidadeDocumento"
        Me.lblQuantidadeDocumento.Size = New System.Drawing.Size(65, 14)
        SuperTipSettings15.HeaderText = "Quantidade"
        SuperTipSettings15.ImageListProvider = Nothing
        SuperTipSettings15.Text = "Quantidade pendente relativo ao Tipo de Operação:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Pedido de Compra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - " & _
    "Devolução de Nota Fiscal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Retorno de Remessa p/ Industr."
        Me.jstTip.SetSuperTip(Me.lblQuantidadeDocumento, SuperTipSettings15)
        Me.lblQuantidadeDocumento.TabIndex = 10
        Me.lblQuantidadeDocumento.Text = "Quantidade:"
        '
        'txtQuantidadeDocumento
        '
        Me.txtQuantidadeDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeDocumento.DecimalDigits = 4
        Me.txtQuantidadeDocumento.Location = New System.Drawing.Point(751, 34)
        Me.txtQuantidadeDocumento.Name = "txtQuantidadeDocumento"
        Me.txtQuantidadeDocumento.ReadOnly = True
        Me.txtQuantidadeDocumento.Size = New System.Drawing.Size(105, 20)
        SuperTipSettings16.HeaderText = "Quantidade"
        SuperTipSettings16.ImageListProvider = Nothing
        SuperTipSettings16.Text = "Quantidade pendente relativo ao Tipo de Operação:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Pedido de Compra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - " & _
    "Devolução de Nota Fiscal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Retorno de Remessa p/ Industr."
        Me.jstTip.SetSuperTip(Me.txtQuantidadeDocumento, SuperTipSettings16)
        Me.txtQuantidadeDocumento.TabIndex = 11
        Me.txtQuantidadeDocumento.TabStop = False
        Me.txtQuantidadeDocumento.Text = "0,0000"
        Me.txtQuantidadeDocumento.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'btnCadastrarUnidadeMedida
        '
        Me.btnCadastrarUnidadeMedida.FlatAppearance.BorderSize = 0
        Me.btnCadastrarUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarUnidadeMedida.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarUnidadeMedida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarUnidadeMedida.Location = New System.Drawing.Point(120, 58)
        Me.btnCadastrarUnidadeMedida.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarUnidadeMedida.Name = "btnCadastrarUnidadeMedida"
        Me.btnCadastrarUnidadeMedida.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarUnidadeMedida.TabIndex = 18
        Me.btnCadastrarUnidadeMedida.TabStop = False
        Me.btnCadastrarUnidadeMedida.UseVisualStyleBackColor = True
        '
        'lblUnidadeMedida
        '
        Me.lblUnidadeMedida.AutoSize = True
        Me.lblUnidadeMedida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUnidadeMedida.Location = New System.Drawing.Point(136, 57)
        Me.lblUnidadeMedida.Name = "lblUnidadeMedida"
        Me.lblUnidadeMedida.Size = New System.Drawing.Size(69, 14)
        Me.lblUnidadeMedida.TabIndex = 19
        Me.lblUnidadeMedida.Text = "Und. Medida:"
        '
        'cboUnidadeMedida
        '
        Me.cboUnidadeMedida.AutoSize = False
        Me.cboUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUnidadeMedida.Location = New System.Drawing.Point(120, 74)
        Me.cboUnidadeMedida.Name = "cboUnidadeMedida"
        Me.cboUnidadeMedida.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUnidadeMedida.Size = New System.Drawing.Size(105, 20)
        Me.cboUnidadeMedida.TabIndex = 20
        '
        'lblQuantidadeEstoque
        '
        Me.lblQuantidadeEstoque.AutoSize = True
        Me.lblQuantidadeEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeEstoque.Location = New System.Drawing.Point(339, 57)
        Me.lblQuantidadeEstoque.Name = "lblQuantidadeEstoque"
        Me.lblQuantidadeEstoque.Size = New System.Drawing.Size(78, 14)
        Me.lblQuantidadeEstoque.TabIndex = 23
        Me.lblQuantidadeEstoque.Text = "Qtde. Estoque:"
        '
        'txtQuantidadeEstoque
        '
        Me.txtQuantidadeEstoque.DecimalDigits = 4
        Me.txtQuantidadeEstoque.Location = New System.Drawing.Point(342, 74)
        Me.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque"
        Me.txtQuantidadeEstoque.Size = New System.Drawing.Size(105, 20)
        Me.txtQuantidadeEstoque.TabIndex = 24
        Me.txtQuantidadeEstoque.Text = "0,0000"
        Me.txtQuantidadeEstoque.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblDataFabricacao
        '
        Me.lblDataFabricacao.AutoSize = True
        Me.lblDataFabricacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataFabricacao.Location = New System.Drawing.Point(6, 97)
        Me.lblDataFabricacao.Name = "lblDataFabricacao"
        Me.lblDataFabricacao.Size = New System.Drawing.Size(89, 14)
        Me.lblDataFabricacao.TabIndex = 30
        Me.lblDataFabricacao.Text = "Data Fabricação:"
        '
        'dtpDataFabricacao
        '
        '
        '
        '
        Me.dtpDataFabricacao.DropDownCalendar.Name = ""
        Me.dtpDataFabricacao.Location = New System.Drawing.Point(9, 114)
        Me.dtpDataFabricacao.Name = "dtpDataFabricacao"
        Me.dtpDataFabricacao.Size = New System.Drawing.Size(105, 20)
        Me.dtpDataFabricacao.TabIndex = 31
        Me.dtpDataFabricacao.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProduto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProduto.Location = New System.Drawing.Point(617, 16)
        Me.btnProcurarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProduto.TabIndex = 7
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'lblDataValidade
        '
        Me.lblDataValidade.AutoSize = True
        Me.lblDataValidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataValidade.Location = New System.Drawing.Point(117, 97)
        Me.lblDataValidade.Name = "lblDataValidade"
        Me.lblDataValidade.Size = New System.Drawing.Size(76, 14)
        Me.lblDataValidade.TabIndex = 34
        Me.lblDataValidade.Text = "Data Validade:"
        '
        'dtpDataValidade
        '
        '
        '
        '
        Me.dtpDataValidade.DropDownCalendar.Name = ""
        Me.dtpDataValidade.Location = New System.Drawing.Point(120, 114)
        Me.dtpDataValidade.Name = "dtpDataValidade"
        Me.dtpDataValidade.Size = New System.Drawing.Size(105, 20)
        Me.dtpDataValidade.TabIndex = 35
        Me.dtpDataValidade.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblLote
        '
        Me.lblLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLote.AutoSize = True
        Me.lblLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLote.Location = New System.Drawing.Point(748, 57)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(85, 14)
        Me.lblLote.TabIndex = 28
        Me.lblLote.Text = "Lote Fabricante:"
        '
        'txtLote
        '
        Me.txtLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Location = New System.Drawing.Point(751, 74)
        Me.txtLote.MaxLength = 50
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(105, 20)
        Me.txtLote.TabIndex = 29
        '
        'btnCadastrarProduto
        '
        Me.btnCadastrarProduto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarProduto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarProduto.Location = New System.Drawing.Point(342, 18)
        Me.btnCadastrarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarProduto.Name = "btnCadastrarProduto"
        Me.btnCadastrarProduto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarProduto.TabIndex = 4
        Me.btnCadastrarProduto.TabStop = False
        Me.btnCadastrarProduto.UseVisualStyleBackColor = True
        '
        'lblCFOP
        '
        Me.lblCFOP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCFOP.AutoSize = True
        Me.lblCFOP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCFOP.Location = New System.Drawing.Point(637, 17)
        Me.lblCFOP.Name = "lblCFOP"
        Me.lblCFOP.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOP.TabIndex = 8
        Me.lblCFOP.Text = "CFOP:"
        '
        'cboCFOP
        '
        Me.cboCFOP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCFOP.AutoSize = False
        Me.cboCFOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCFOP.Location = New System.Drawing.Point(640, 34)
        Me.cboCFOP.Name = "cboCFOP"
        Me.cboCFOP.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCFOP.Size = New System.Drawing.Size(105, 20)
        Me.cboCFOP.TabIndex = 9
        '
        'lblFatorConversao
        '
        Me.lblFatorConversao.AutoSize = True
        Me.lblFatorConversao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFatorConversao.Location = New System.Drawing.Point(228, 57)
        Me.lblFatorConversao.Name = "lblFatorConversao"
        Me.lblFatorConversao.Size = New System.Drawing.Size(91, 14)
        Me.lblFatorConversao.TabIndex = 21
        Me.lblFatorConversao.Text = "Fator Conversão:"
        '
        'txtFatorConversao
        '
        Me.txtFatorConversao.DecimalDigits = 4
        Me.txtFatorConversao.Location = New System.Drawing.Point(231, 74)
        Me.txtFatorConversao.Name = "txtFatorConversao"
        Me.txtFatorConversao.Size = New System.Drawing.Size(105, 20)
        Me.txtFatorConversao.TabIndex = 22
        Me.txtFatorConversao.Text = "0,0000"
        Me.txtFatorConversao.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblProduto.Location = New System.Drawing.Point(358, 17)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 5
        Me.lblProduto.Text = "Produto:"
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(883, 111)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 45
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = CType(resources.GetObject("btnInserir.Image"), System.Drawing.Image)
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(883, 82)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 44
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCadastrarDeposito
        '
        Me.btnCadastrarDeposito.FlatAppearance.BorderSize = 0
        Me.btnCadastrarDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarDeposito.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarDeposito.Location = New System.Drawing.Point(453, 58)
        Me.btnCadastrarDeposito.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarDeposito.Name = "btnCadastrarDeposito"
        Me.btnCadastrarDeposito.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarDeposito.TabIndex = 25
        Me.btnCadastrarDeposito.TabStop = False
        Me.btnCadastrarDeposito.UseVisualStyleBackColor = True
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(228, 18)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 2
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'cboNumeroDocumento
        '
        Me.cboNumeroDocumento.AutoSize = False
        Me.cboNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNumeroDocumento.Location = New System.Drawing.Point(231, 34)
        Me.cboNumeroDocumento.Name = "cboNumeroDocumento"
        Me.cboNumeroDocumento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNumeroDocumento.Size = New System.Drawing.Size(105, 20)
        Me.cboNumeroDocumento.TabIndex = 3
        '
        'lblDeposito
        '
        Me.lblDeposito.AutoSize = True
        Me.lblDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDeposito.Location = New System.Drawing.Point(469, 57)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(52, 14)
        Me.lblDeposito.TabIndex = 26
        Me.lblDeposito.Text = "Depósito:"
        '
        'cboDeposito
        '
        Me.cboDeposito.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDeposito.AutoSize = False
        Me.cboDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDeposito.Location = New System.Drawing.Point(453, 74)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDeposito.Size = New System.Drawing.Size(292, 20)
        Me.cboDeposito.TabIndex = 27
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidade.Location = New System.Drawing.Point(6, 57)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 16
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(9, 74)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(105, 20)
        Me.txtQuantidade.TabIndex = 17
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
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
        Me.cboTipoOperacao.Size = New System.Drawing.Size(216, 20)
        Me.cboTipoOperacao.TabIndex = 1
        '
        'cboProduto
        '
        Me.cboProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboProduto.AutoSize = False
        Me.cboProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProduto.Location = New System.Drawing.Point(342, 34)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboProduto.Size = New System.Drawing.Size(292, 20)
        Me.cboProduto.TabIndex = 6
        '
        'grdRecebimento
        '
        Me.grdRecebimento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdRecebimento.AlternatingColors = True
        Me.grdRecebimento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRecebimento.AutoEdit = True
        grdRecebimento_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdRecebimento_DesignTimeLayout_Reference_0.Instance"), Object)
        grdRecebimento_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdRecebimento_DesignTimeLayout_Reference_1.Instance"), Object)
        grdRecebimento_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdRecebimento_DesignTimeLayout_Reference_0, grdRecebimento_DesignTimeLayout_Reference_1})
        grdRecebimento_DesignTimeLayout.LayoutString = resources.GetString("grdRecebimento_DesignTimeLayout.LayoutString")
        Me.grdRecebimento.DesignTimeLayout = grdRecebimento_DesignTimeLayout
        Me.grdRecebimento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdRecebimento.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdRecebimento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdRecebimento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdRecebimento.FrozenColumns = 2
        Me.grdRecebimento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdRecebimento.GroupByBoxVisible = False
        Me.grdRecebimento.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdRecebimento.Location = New System.Drawing.Point(8, 417)
        Me.grdRecebimento.Name = "grdRecebimento"
        Me.grdRecebimento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdRecebimento.RecordNavigator = True
        Me.grdRecebimento.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdRecebimento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdRecebimento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdRecebimento.Size = New System.Drawing.Size(983, 143)
        Me.grdRecebimento.TabIndex = 5
        Me.grdRecebimento.TabStop = False
        Me.grdRecebimento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdRecebimento.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdRecebimento.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdRecebimento.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdRecebimento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdRecebimento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdRecebimento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdRecebimento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdRecebimento.VisualStyleManager = Me.vsmMain
        '
        'grpControleDados
        '
        Me.grpControleDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControleDados.BackColor = System.Drawing.Color.Transparent
        Me.grpControleDados.Controls.Add(Me.txtAliquotaICMSUltimaNF)
        Me.grpControleDados.Controls.Add(Me.lblAliquotaPISCOFINSPedido)
        Me.grpControleDados.Controls.Add(Me.txtAliquotaPISCOFINSPedido)
        Me.grpControleDados.Controls.Add(Me.lblAliquotaIPIPedido)
        Me.grpControleDados.Controls.Add(Me.txtAliquotaIPIPedido)
        Me.grpControleDados.Controls.Add(Me.lblAliquotaICMSPedido)
        Me.grpControleDados.Controls.Add(Me.txtAliquotaICMSPedido)
        Me.grpControleDados.Controls.Add(Me.lblValorUnitarioPedido)
        Me.grpControleDados.Controls.Add(Me.btnConfirmar)
        Me.grpControleDados.Controls.Add(Me.txtValorUnitarioPedido)
        Me.grpControleDados.Controls.Add(Me.btnCancelar)
        Me.grpControleDados.Controls.Add(Me.lblAliquotaICMSUltimaNF)
        Me.grpControleDados.Location = New System.Drawing.Point(8, 563)
        Me.grpControleDados.Name = "grpControleDados"
        Me.grpControleDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleDados.Size = New System.Drawing.Size(983, 51)
        Me.grpControleDados.TabIndex = 9
        Me.grpControleDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControleDados.VisualStyleManager = Me.vsmMain
        '
        'txtAliquotaICMSUltimaNF
        '
        Me.txtAliquotaICMSUltimaNF.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAliquotaICMSUltimaNF.DecimalDigits = 2
        Me.txtAliquotaICMSUltimaNF.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaICMSUltimaNF.Location = New System.Drawing.Point(689, 17)
        Me.txtAliquotaICMSUltimaNF.Name = "txtAliquotaICMSUltimaNF"
        Me.txtAliquotaICMSUltimaNF.ReadOnly = True
        Me.txtAliquotaICMSUltimaNF.Size = New System.Drawing.Size(51, 20)
        SuperTipSettings17.HeaderText = "Quantidade"
        SuperTipSettings17.ImageListProvider = Nothing
        SuperTipSettings17.Text = "Quantidade pendente relativo ao Tipo de Operação:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Pedido de Compra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - " & _
    "Devolução de Nota Fiscal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Retorno de Remessa p/ Industr."
        Me.jstTip.SetSuperTip(Me.txtAliquotaICMSUltimaNF, SuperTipSettings17)
        Me.txtAliquotaICMSUltimaNF.TabIndex = 9
        Me.txtAliquotaICMSUltimaNF.TabStop = False
        Me.txtAliquotaICMSUltimaNF.Text = "0,00%"
        Me.txtAliquotaICMSUltimaNF.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaPISCOFINSPedido
        '
        Me.lblAliquotaPISCOFINSPedido.AutoSize = True
        Me.lblAliquotaPISCOFINSPedido.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblAliquotaPISCOFINSPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAliquotaPISCOFINSPedido.Location = New System.Drawing.Point(426, 20)
        Me.lblAliquotaPISCOFINSPedido.Name = "lblAliquotaPISCOFINSPedido"
        Me.lblAliquotaPISCOFINSPedido.Size = New System.Drawing.Size(85, 13)
        SuperTipSettings18.HeaderText = "Quantidade"
        SuperTipSettings18.ImageListProvider = Nothing
        SuperTipSettings18.Text = "Quantidade pendente relativo ao Tipo de Operação:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Pedido de Compra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - " & _
    "Devolução de Nota Fiscal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Retorno de Remessa p/ Industr."
        Me.jstTip.SetSuperTip(Me.lblAliquotaPISCOFINSPedido, SuperTipSettings18)
        Me.lblAliquotaPISCOFINSPedido.TabIndex = 6
        Me.lblAliquotaPISCOFINSPedido.Text = "% PIS/COFINS:"
        '
        'txtAliquotaPISCOFINSPedido
        '
        Me.txtAliquotaPISCOFINSPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAliquotaPISCOFINSPedido.DecimalDigits = 2
        Me.txtAliquotaPISCOFINSPedido.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaPISCOFINSPedido.Location = New System.Drawing.Point(517, 17)
        Me.txtAliquotaPISCOFINSPedido.Name = "txtAliquotaPISCOFINSPedido"
        Me.txtAliquotaPISCOFINSPedido.ReadOnly = True
        Me.txtAliquotaPISCOFINSPedido.Size = New System.Drawing.Size(51, 20)
        SuperTipSettings19.HeaderText = "Quantidade"
        SuperTipSettings19.ImageListProvider = Nothing
        SuperTipSettings19.Text = "Quantidade pendente relativo ao Tipo de Operação:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Pedido de Compra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - " & _
    "Devolução de Nota Fiscal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Retorno de Remessa p/ Industr."
        Me.jstTip.SetSuperTip(Me.txtAliquotaPISCOFINSPedido, SuperTipSettings19)
        Me.txtAliquotaPISCOFINSPedido.TabIndex = 7
        Me.txtAliquotaPISCOFINSPedido.TabStop = False
        Me.txtAliquotaPISCOFINSPedido.Text = "0,00%"
        Me.txtAliquotaPISCOFINSPedido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaIPIPedido
        '
        Me.lblAliquotaIPIPedido.AutoSize = True
        Me.lblAliquotaIPIPedido.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblAliquotaIPIPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAliquotaIPIPedido.Location = New System.Drawing.Point(327, 20)
        Me.lblAliquotaIPIPedido.Name = "lblAliquotaIPIPedido"
        Me.lblAliquotaIPIPedido.Size = New System.Drawing.Size(36, 13)
        SuperTipSettings20.HeaderText = "Quantidade"
        SuperTipSettings20.ImageListProvider = Nothing
        SuperTipSettings20.Text = "Quantidade pendente relativo ao Tipo de Operação:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Pedido de Compra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - " & _
    "Devolução de Nota Fiscal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Retorno de Remessa p/ Industr."
        Me.jstTip.SetSuperTip(Me.lblAliquotaIPIPedido, SuperTipSettings20)
        Me.lblAliquotaIPIPedido.TabIndex = 4
        Me.lblAliquotaIPIPedido.Text = "% IPI:"
        '
        'txtAliquotaIPIPedido
        '
        Me.txtAliquotaIPIPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAliquotaIPIPedido.DecimalDigits = 2
        Me.txtAliquotaIPIPedido.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaIPIPedido.Location = New System.Drawing.Point(369, 17)
        Me.txtAliquotaIPIPedido.Name = "txtAliquotaIPIPedido"
        Me.txtAliquotaIPIPedido.ReadOnly = True
        Me.txtAliquotaIPIPedido.Size = New System.Drawing.Size(51, 20)
        SuperTipSettings21.HeaderText = "Quantidade"
        SuperTipSettings21.ImageListProvider = Nothing
        SuperTipSettings21.Text = "Quantidade pendente relativo ao Tipo de Operação:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Pedido de Compra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - " & _
    "Devolução de Nota Fiscal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Retorno de Remessa p/ Industr."
        Me.jstTip.SetSuperTip(Me.txtAliquotaIPIPedido, SuperTipSettings21)
        Me.txtAliquotaIPIPedido.TabIndex = 5
        Me.txtAliquotaIPIPedido.TabStop = False
        Me.txtAliquotaIPIPedido.Text = "0,00%"
        Me.txtAliquotaIPIPedido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAliquotaICMSPedido
        '
        Me.lblAliquotaICMSPedido.AutoSize = True
        Me.lblAliquotaICMSPedido.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblAliquotaICMSPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAliquotaICMSPedido.Location = New System.Drawing.Point(213, 20)
        Me.lblAliquotaICMSPedido.Name = "lblAliquotaICMSPedido"
        Me.lblAliquotaICMSPedido.Size = New System.Drawing.Size(51, 13)
        SuperTipSettings22.HeaderText = "Quantidade"
        SuperTipSettings22.ImageListProvider = Nothing
        SuperTipSettings22.Text = "Quantidade pendente relativo ao Tipo de Operação:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Pedido de Compra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - " & _
    "Devolução de Nota Fiscal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Retorno de Remessa p/ Industr."
        Me.jstTip.SetSuperTip(Me.lblAliquotaICMSPedido, SuperTipSettings22)
        Me.lblAliquotaICMSPedido.TabIndex = 2
        Me.lblAliquotaICMSPedido.Text = "% ICMS:"
        '
        'txtAliquotaICMSPedido
        '
        Me.txtAliquotaICMSPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAliquotaICMSPedido.DecimalDigits = 2
        Me.txtAliquotaICMSPedido.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAliquotaICMSPedido.Location = New System.Drawing.Point(270, 17)
        Me.txtAliquotaICMSPedido.Name = "txtAliquotaICMSPedido"
        Me.txtAliquotaICMSPedido.ReadOnly = True
        Me.txtAliquotaICMSPedido.Size = New System.Drawing.Size(51, 20)
        SuperTipSettings23.HeaderText = "Quantidade"
        SuperTipSettings23.ImageListProvider = Nothing
        SuperTipSettings23.Text = "Quantidade pendente relativo ao Tipo de Operação:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Pedido de Compra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - " & _
    "Devolução de Nota Fiscal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Retorno de Remessa p/ Industr."
        Me.jstTip.SetSuperTip(Me.txtAliquotaICMSPedido, SuperTipSettings23)
        Me.txtAliquotaICMSPedido.TabIndex = 3
        Me.txtAliquotaICMSPedido.TabStop = False
        Me.txtAliquotaICMSPedido.Text = "0,00%"
        Me.txtAliquotaICMSPedido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorUnitarioPedido
        '
        Me.lblValorUnitarioPedido.AutoSize = True
        Me.lblValorUnitarioPedido.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblValorUnitarioPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValorUnitarioPedido.Location = New System.Drawing.Point(6, 21)
        Me.lblValorUnitarioPedido.Name = "lblValorUnitarioPedido"
        Me.lblValorUnitarioPedido.Size = New System.Drawing.Size(90, 13)
        SuperTipSettings24.HeaderText = "Quantidade"
        SuperTipSettings24.ImageListProvider = Nothing
        SuperTipSettings24.Text = "Quantidade pendente relativo ao Tipo de Operação:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Pedido de Compra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - " & _
    "Devolução de Nota Fiscal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Retorno de Remessa p/ Industr."
        Me.jstTip.SetSuperTip(Me.lblValorUnitarioPedido, SuperTipSettings24)
        Me.lblValorUnitarioPedido.TabIndex = 0
        Me.lblValorUnitarioPedido.Text = "Valor Unitário:"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmar.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnConfirmar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnConfirmar.Location = New System.Drawing.Point(786, 17)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnConfirmar.Size = New System.Drawing.Size(91, 23)
        Me.btnConfirmar.TabIndex = 10
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtValorUnitarioPedido
        '
        Me.txtValorUnitarioPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorUnitarioPedido.DecimalDigits = 4
        Me.txtValorUnitarioPedido.Location = New System.Drawing.Point(102, 18)
        Me.txtValorUnitarioPedido.Name = "txtValorUnitarioPedido"
        Me.txtValorUnitarioPedido.ReadOnly = True
        Me.txtValorUnitarioPedido.Size = New System.Drawing.Size(105, 20)
        SuperTipSettings25.HeaderText = "Quantidade"
        SuperTipSettings25.ImageListProvider = Nothing
        SuperTipSettings25.Text = "Quantidade pendente relativo ao Tipo de Operação:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Pedido de Compra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - " & _
    "Devolução de Nota Fiscal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Retorno de Remessa p/ Industr."
        Me.jstTip.SetSuperTip(Me.txtValorUnitarioPedido, SuperTipSettings25)
        Me.txtValorUnitarioPedido.TabIndex = 1
        Me.txtValorUnitarioPedido.TabStop = False
        Me.txtValorUnitarioPedido.Text = "0,0000"
        Me.txtValorUnitarioPedido.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.INTERACTI.My.Resources.Resources.cancelar
        Me.btnCancelar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCancelar.Location = New System.Drawing.Point(883, 17)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCancelar.Size = New System.Drawing.Size(91, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblAliquotaICMSUltimaNF
        '
        Me.lblAliquotaICMSUltimaNF.AutoSize = True
        Me.lblAliquotaICMSUltimaNF.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblAliquotaICMSUltimaNF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAliquotaICMSUltimaNF.Location = New System.Drawing.Point(574, 20)
        Me.lblAliquotaICMSUltimaNF.Name = "lblAliquotaICMSUltimaNF"
        Me.lblAliquotaICMSUltimaNF.Size = New System.Drawing.Size(109, 13)
        SuperTipSettings26.HeaderText = "Quantidade"
        SuperTipSettings26.ImageListProvider = Nothing
        SuperTipSettings26.Text = "Quantidade pendente relativo ao Tipo de Operação:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Pedido de Compra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - " & _
    "Devolução de Nota Fiscal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   - Retorno de Remessa p/ Industr."
        Me.jstTip.SetSuperTip(Me.lblAliquotaICMSUltimaNF, SuperTipSettings26)
        Me.lblAliquotaICMSUltimaNF.TabIndex = 8
        Me.lblAliquotaICMSUltimaNF.Text = "% ICMS Última NF:"
        '
        'grdXML
        '
        Me.grdXML.AllowDrop = True
        Me.grdXML.AlternatingColors = True
        Me.grdXML.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdXML.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        grdXML_DesignTimeLayout.LayoutString = resources.GetString("grdXML_DesignTimeLayout.LayoutString")
        Me.grdXML.DesignTimeLayout = grdXML_DesignTimeLayout
        Me.grdXML.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdXML.FocusCellFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdXML.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdXML.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdXML.FrozenColumns = 1
        Me.grdXML.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdXML.GroupByBoxVisible = False
        Me.grdXML.Location = New System.Drawing.Point(8, 8)
        Me.grdXML.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdXML.Name = "grdXML"
        Me.grdXML.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdXML.RecordNavigator = True
        Me.grdXML.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
        Me.grdXML.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdXML.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdXML.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdXML.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdXML.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdXML.Size = New System.Drawing.Size(983, 252)
        Me.grdXML.TabIndex = 0
        Me.grdXML.TabStop = False
        Me.grdXML.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdXML.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdXML.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdXML.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdXML.VisualStyleManager = Me.vsmMain
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'frmFatEntradaNFProdutoXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 661)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmFatEntradaNFProdutoXML"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada de NFe - Produto"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEntrega.ResumeLayout(False)
        Me.grpEntrega.PerformLayout()
        CType(Me.grdRecebimento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControleDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleDados.ResumeLayout(False)
        Me.grpControleDados.PerformLayout()
        CType(Me.grdXML, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControleDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnConfirmar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdXML As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpEntrega As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblFatorConversao As System.Windows.Forms.Label
    Friend WithEvents txtFatorConversao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents cboProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCadastrarDeposito As System.Windows.Forms.Button
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents cboNumeroDocumento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDeposito As System.Windows.Forms.Label
    Friend WithEvents cboDeposito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdRecebimento As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblCFOP As System.Windows.Forms.Label
    Friend WithEvents cboCFOP As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnCadastrarProduto As System.Windows.Forms.Button
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents txtLote As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataValidade As System.Windows.Forms.Label
    Friend WithEvents dtpDataValidade As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents lblTipoOperacao As System.Windows.Forms.Label
    Friend WithEvents cboTipoOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnConfigurarGridXML As System.Windows.Forms.Button
    Friend WithEvents lblDataFabricacao As System.Windows.Forms.Label
    Friend WithEvents dtpDataFabricacao As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnConfigurarGridRecebimento As System.Windows.Forms.Button
    Friend WithEvents lblQuantidadeEstoque As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeEstoque As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnCadastrarUnidadeMedida As System.Windows.Forms.Button
    Friend WithEvents lblUnidadeMedida As System.Windows.Forms.Label
    Friend WithEvents cboUnidadeMedida As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblQuantidadeDocumento As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeDocumento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnAtualizarPedidoCompra As System.Windows.Forms.Button
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnProcurarContaContabil As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarContaContabil As System.Windows.Forms.Button
    Friend WithEvents lblContaContabil As System.Windows.Forms.Label
    Friend WithEvents cboContaContabil As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnProcurarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCentroGasto As System.Windows.Forms.Button
    Friend WithEvents lblCentroGasto As System.Windows.Forms.Label
    Friend WithEvents cboCentroGasto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcelGridXML As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridXML As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridRecebimento As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridRecebimento As System.Windows.Forms.Button
    Friend WithEvents lblAliquotaIPIPedido As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaIPIPedido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaICMSPedido As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaICMSPedido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorUnitarioPedido As System.Windows.Forms.Label
    Friend WithEvents txtValorUnitarioPedido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaPISCOFINSPedido As System.Windows.Forms.Label
    Friend WithEvents txtAliquotaPISCOFINSPedido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtAliquotaICMSUltimaNF As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAliquotaICMSUltimaNF As System.Windows.Forms.Label
    Friend WithEvents chkCadastrarProduto As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents btnBaixarMultiplo As System.Windows.Forms.Button
End Class
