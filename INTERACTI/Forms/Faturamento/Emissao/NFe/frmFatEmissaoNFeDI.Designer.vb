<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEmissaoNFeDI
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
        Me.components = New System.ComponentModel.Container
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim grdVolume_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim grdVolume_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEmissaoNFeDI))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage
        Me.grpDI = New Janus.Windows.EditControls.UIGroupBox
        Me.lblNumeroDI = New System.Windows.Forms.Label
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox
        Me.btnImportarPedidoVenda = New Janus.Windows.EditControls.UIButton
        Me.btnSair = New Janus.Windows.EditControls.UIButton
        Me.ofaMain = New Janus.Windows.Ribbon.OfficeFormAdorner(Me.components)
        Me.txtNumeroDI = New Janus.Windows.GridEX.EditControls.EditBox
        Me.dtpDataRegistro = New System.Windows.Forms.DateTimePicker
        Me.lblDataRegistro = New System.Windows.Forms.Label
        Me.txtLocalDesembaraco = New Janus.Windows.GridEX.EditControls.EditBox
        Me.lblLocalDesembaraco = New System.Windows.Forms.Label
        Me.cboUFLocalDesembaraco = New Janus.Windows.EditControls.UIComboBox
        Me.lblUFLocalDesembaraco = New System.Windows.Forms.Label
        Me.txtCodigoExportador = New Janus.Windows.GridEX.EditControls.EditBox
        Me.lblCodigoExportador = New System.Windows.Forms.Label
        Me.lblDataDesembaraco = New System.Windows.Forms.Label
        Me.dtpDataDesembaraco = New System.Windows.Forms.DateTimePicker
        Me.grpAdicao = New Janus.Windows.EditControls.UIGroupBox
        Me.txtFabricante = New Janus.Windows.GridEX.EditControls.EditBox
        Me.lblFabricante = New System.Windows.Forms.Label
        Me.lblAdicao = New System.Windows.Forms.Label
        Me.txtAdicao = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.txtNumeroPedido = New Janus.Windows.GridEX.EditControls.EditBox
        Me.lblNumeroPedido = New System.Windows.Forms.Label
        Me.txtItemPedido = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.lblItemPedido = New System.Windows.Forms.Label
        Me.lblNCM = New System.Windows.Forms.Label
        Me.cboNCM = New Janus.Windows.EditControls.UIComboBox
        Me.txtTotalFrete = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.lblTotalFrete = New System.Windows.Forms.Label
        Me.txtTotalSeguro = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.lblTotalSeguro = New System.Windows.Forms.Label
        Me.txtTotalDesconto = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.lblTotalDesconto = New System.Windows.Forms.Label
        Me.txtTotalOutrasDespesas = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.lblTotalOutrasDespesas = New System.Windows.Forms.Label
        Me.btnExcluirVolume = New Janus.Windows.EditControls.UIButton
        Me.btnInserirVolume = New Janus.Windows.EditControls.UIButton
        Me.grdVolume = New Janus.Windows.GridEX.GridEX
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpDI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDI.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.ofaMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpAdicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAdicao.SuspendLayout()
        CType(Me.grdVolume, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Location = New System.Drawing.Point(7, 9)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(897, 450)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grdVolume)
        Me.pagTabela.Controls.Add(Me.grpAdicao)
        Me.pagTabela.Controls.Add(Me.grpDI)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(895, 427)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Pedido de Venda"
        '
        'grpDI
        '
        Me.grpDI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDI.BackColor = System.Drawing.Color.Transparent
        Me.grpDI.Controls.Add(Me.lblDataDesembaraco)
        Me.grpDI.Controls.Add(Me.dtpDataDesembaraco)
        Me.grpDI.Controls.Add(Me.txtCodigoExportador)
        Me.grpDI.Controls.Add(Me.lblCodigoExportador)
        Me.grpDI.Controls.Add(Me.lblUFLocalDesembaraco)
        Me.grpDI.Controls.Add(Me.cboUFLocalDesembaraco)
        Me.grpDI.Controls.Add(Me.txtLocalDesembaraco)
        Me.grpDI.Controls.Add(Me.lblLocalDesembaraco)
        Me.grpDI.Controls.Add(Me.lblDataRegistro)
        Me.grpDI.Controls.Add(Me.dtpDataRegistro)
        Me.grpDI.Controls.Add(Me.txtNumeroDI)
        Me.grpDI.Controls.Add(Me.lblNumeroDI)
        Me.grpDI.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDI.Location = New System.Drawing.Point(8, 3)
        Me.grpDI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDI.Name = "grpDI"
        Me.grpDI.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDI.Size = New System.Drawing.Size(879, 67)
        Me.grpDI.TabIndex = 0
        Me.grpDI.Text = "DI"
        Me.grpDI.VisualStyleManager = Me.vsmMain
        '
        'lblNumeroDI
        '
        Me.lblNumeroDI.AutoSize = True
        Me.lblNumeroDI.Location = New System.Drawing.Point(6, 20)
        Me.lblNumeroDI.Name = "lblNumeroDI"
        Me.lblNumeroDI.Size = New System.Drawing.Size(34, 14)
        Me.lblNumeroDI.TabIndex = 0
        Me.lblNumeroDI.Text = "Nº DI:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnImportarPedidoVenda)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 367)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(879, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnImportarPedidoVenda
        '
        Me.btnImportarPedidoVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportarPedidoVenda.Image = Global.INTERACTI.My.Resources.Resources.importar
        Me.btnImportarPedidoVenda.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarPedidoVenda.Location = New System.Drawing.Point(573, 17)
        Me.btnImportarPedidoVenda.Name = "btnImportarPedidoVenda"
        Me.btnImportarPedidoVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportarPedidoVenda.Size = New System.Drawing.Size(200, 23)
        Me.btnImportarPedidoVenda.TabIndex = 0
        Me.btnImportarPedidoVenda.Text = "Importar Pedido de Venda"
        Me.btnImportarPedidoVenda.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(779, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'ofaMain
        '
        Me.ofaMain.Form = Me
        Me.ofaMain.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Silver
        Me.ofaMain.Office2007CustomColor = System.Drawing.Color.Empty
        '
        'txtNumeroDI
        '
        Me.txtNumeroDI.Location = New System.Drawing.Point(9, 37)
        Me.txtNumeroDI.MaxLength = 10
        Me.txtNumeroDI.Name = "txtNumeroDI"
        Me.txtNumeroDI.Size = New System.Drawing.Size(122, 20)
        Me.txtNumeroDI.TabIndex = 20
        '
        'dtpDataRegistro
        '
        Me.dtpDataRegistro.CustomFormat = "dd/MM/yyyy"
        Me.dtpDataRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataRegistro.Location = New System.Drawing.Point(137, 37)
        Me.dtpDataRegistro.Name = "dtpDataRegistro"
        Me.dtpDataRegistro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataRegistro.TabIndex = 21
        '
        'lblDataRegistro
        '
        Me.lblDataRegistro.AutoSize = True
        Me.lblDataRegistro.Location = New System.Drawing.Point(134, 20)
        Me.lblDataRegistro.Name = "lblDataRegistro"
        Me.lblDataRegistro.Size = New System.Drawing.Size(90, 14)
        Me.lblDataRegistro.TabIndex = 22
        Me.lblDataRegistro.Text = "Data do Registro:"
        '
        'txtLocalDesembaraco
        '
        Me.txtLocalDesembaraco.Location = New System.Drawing.Point(243, 37)
        Me.txtLocalDesembaraco.MaxLength = 60
        Me.txtLocalDesembaraco.Name = "txtLocalDesembaraco"
        Me.txtLocalDesembaraco.Size = New System.Drawing.Size(255, 20)
        Me.txtLocalDesembaraco.TabIndex = 24
        '
        'lblLocalDesembaraco
        '
        Me.lblLocalDesembaraco.AutoSize = True
        Me.lblLocalDesembaraco.Location = New System.Drawing.Point(240, 20)
        Me.lblLocalDesembaraco.Name = "lblLocalDesembaraco"
        Me.lblLocalDesembaraco.Size = New System.Drawing.Size(121, 14)
        Me.lblLocalDesembaraco.TabIndex = 23
        Me.lblLocalDesembaraco.Text = "Local do Desembaraço:"
        '
        'cboUFLocalDesembaraco
        '
        Me.cboUFLocalDesembaraco.Location = New System.Drawing.Point(504, 37)
        Me.cboUFLocalDesembaraco.Name = "cboUFLocalDesembaraco"
        Me.cboUFLocalDesembaraco.Size = New System.Drawing.Size(53, 20)
        Me.cboUFLocalDesembaraco.TabIndex = 25
        '
        'lblUFLocalDesembaraco
        '
        Me.lblUFLocalDesembaraco.AutoSize = True
        Me.lblUFLocalDesembaraco.Location = New System.Drawing.Point(501, 20)
        Me.lblUFLocalDesembaraco.Name = "lblUFLocalDesembaraco"
        Me.lblUFLocalDesembaraco.Size = New System.Drawing.Size(23, 14)
        Me.lblUFLocalDesembaraco.TabIndex = 26
        Me.lblUFLocalDesembaraco.Text = "UF:"
        '
        'txtCodigoExportador
        '
        Me.txtCodigoExportador.Location = New System.Drawing.Point(669, 37)
        Me.txtCodigoExportador.MaxLength = 60
        Me.txtCodigoExportador.Name = "txtCodigoExportador"
        Me.txtCodigoExportador.Size = New System.Drawing.Size(201, 20)
        Me.txtCodigoExportador.TabIndex = 28
        '
        'lblCodigoExportador
        '
        Me.lblCodigoExportador.AutoSize = True
        Me.lblCodigoExportador.Location = New System.Drawing.Point(666, 20)
        Me.lblCodigoExportador.Name = "lblCodigoExportador"
        Me.lblCodigoExportador.Size = New System.Drawing.Size(99, 14)
        Me.lblCodigoExportador.TabIndex = 27
        Me.lblCodigoExportador.Text = "Código Exportador:"
        '
        'lblDataDesembaraco
        '
        Me.lblDataDesembaraco.AutoSize = True
        Me.lblDataDesembaraco.Location = New System.Drawing.Point(560, 20)
        Me.lblDataDesembaraco.Name = "lblDataDesembaraco"
        Me.lblDataDesembaraco.Size = New System.Drawing.Size(102, 14)
        Me.lblDataDesembaraco.TabIndex = 30
        Me.lblDataDesembaraco.Text = "Data Desembaraço:"
        '
        'dtpDataDesembaraco
        '
        Me.dtpDataDesembaraco.CustomFormat = "dd/MM/yyyy"
        Me.dtpDataDesembaraco.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataDesembaraco.Location = New System.Drawing.Point(563, 37)
        Me.dtpDataDesembaraco.Name = "dtpDataDesembaraco"
        Me.dtpDataDesembaraco.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataDesembaraco.TabIndex = 29
        '
        'grpAdicao
        '
        Me.grpAdicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAdicao.BackColor = System.Drawing.Color.Transparent
        Me.grpAdicao.Controls.Add(Me.btnExcluirVolume)
        Me.grpAdicao.Controls.Add(Me.btnInserirVolume)
        Me.grpAdicao.Controls.Add(Me.txtTotalOutrasDespesas)
        Me.grpAdicao.Controls.Add(Me.lblTotalOutrasDespesas)
        Me.grpAdicao.Controls.Add(Me.txtTotalDesconto)
        Me.grpAdicao.Controls.Add(Me.lblTotalDesconto)
        Me.grpAdicao.Controls.Add(Me.txtTotalSeguro)
        Me.grpAdicao.Controls.Add(Me.lblTotalSeguro)
        Me.grpAdicao.Controls.Add(Me.txtTotalFrete)
        Me.grpAdicao.Controls.Add(Me.lblTotalFrete)
        Me.grpAdicao.Controls.Add(Me.lblNCM)
        Me.grpAdicao.Controls.Add(Me.cboNCM)
        Me.grpAdicao.Controls.Add(Me.txtItemPedido)
        Me.grpAdicao.Controls.Add(Me.lblItemPedido)
        Me.grpAdicao.Controls.Add(Me.txtNumeroPedido)
        Me.grpAdicao.Controls.Add(Me.lblNumeroPedido)
        Me.grpAdicao.Controls.Add(Me.txtAdicao)
        Me.grpAdicao.Controls.Add(Me.txtFabricante)
        Me.grpAdicao.Controls.Add(Me.lblFabricante)
        Me.grpAdicao.Controls.Add(Me.lblAdicao)
        Me.grpAdicao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpAdicao.Location = New System.Drawing.Point(8, 73)
        Me.grpAdicao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpAdicao.Name = "grpAdicao"
        Me.grpAdicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpAdicao.Size = New System.Drawing.Size(557, 148)
        Me.grpAdicao.TabIndex = 3
        Me.grpAdicao.Text = "Adição"
        Me.grpAdicao.VisualStyleManager = Me.vsmMain
        '
        'txtFabricante
        '
        Me.txtFabricante.Location = New System.Drawing.Point(115, 37)
        Me.txtFabricante.MaxLength = 60
        Me.txtFabricante.Name = "txtFabricante"
        Me.txtFabricante.Size = New System.Drawing.Size(312, 20)
        Me.txtFabricante.TabIndex = 24
        '
        'lblFabricante
        '
        Me.lblFabricante.AutoSize = True
        Me.lblFabricante.Location = New System.Drawing.Point(112, 20)
        Me.lblFabricante.Name = "lblFabricante"
        Me.lblFabricante.Size = New System.Drawing.Size(61, 14)
        Me.lblFabricante.TabIndex = 23
        Me.lblFabricante.Text = "Fabricante:"
        '
        'lblAdicao
        '
        Me.lblAdicao.AutoSize = True
        Me.lblAdicao.Location = New System.Drawing.Point(6, 20)
        Me.lblAdicao.Name = "lblAdicao"
        Me.lblAdicao.Size = New System.Drawing.Size(44, 14)
        Me.lblAdicao.TabIndex = 0
        Me.lblAdicao.Text = "Adição:"
        '
        'txtAdicao
        '
        Me.txtAdicao.DecimalDigits = 0
        Me.txtAdicao.Location = New System.Drawing.Point(9, 37)
        Me.txtAdicao.Name = "txtAdicao"
        Me.txtAdicao.Size = New System.Drawing.Size(100, 20)
        Me.txtAdicao.TabIndex = 31
        Me.txtAdicao.Text = "0"
        Me.txtAdicao.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtNumeroPedido
        '
        Me.txtNumeroPedido.Location = New System.Drawing.Point(115, 77)
        Me.txtNumeroPedido.MaxLength = 10
        Me.txtNumeroPedido.Name = "txtNumeroPedido"
        Me.txtNumeroPedido.Size = New System.Drawing.Size(206, 20)
        Me.txtNumeroPedido.TabIndex = 33
        '
        'lblNumeroPedido
        '
        Me.lblNumeroPedido.AutoSize = True
        Me.lblNumeroPedido.Location = New System.Drawing.Point(112, 60)
        Me.lblNumeroPedido.Name = "lblNumeroPedido"
        Me.lblNumeroPedido.Size = New System.Drawing.Size(57, 14)
        Me.lblNumeroPedido.TabIndex = 32
        Me.lblNumeroPedido.Text = "Nº Pedido:"
        '
        'txtItemPedido
        '
        Me.txtItemPedido.DecimalDigits = 0
        Me.txtItemPedido.Location = New System.Drawing.Point(327, 77)
        Me.txtItemPedido.Name = "txtItemPedido"
        Me.txtItemPedido.Size = New System.Drawing.Size(100, 20)
        Me.txtItemPedido.TabIndex = 35
        Me.txtItemPedido.Text = "0"
        Me.txtItemPedido.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblItemPedido
        '
        Me.lblItemPedido.AutoSize = True
        Me.lblItemPedido.Location = New System.Drawing.Point(324, 60)
        Me.lblItemPedido.Name = "lblItemPedido"
        Me.lblItemPedido.Size = New System.Drawing.Size(79, 14)
        Me.lblItemPedido.TabIndex = 34
        Me.lblItemPedido.Text = "Item do Pedido:"
        '
        'lblNCM
        '
        Me.lblNCM.AutoSize = True
        Me.lblNCM.Location = New System.Drawing.Point(6, 60)
        Me.lblNCM.Name = "lblNCM"
        Me.lblNCM.Size = New System.Drawing.Size(32, 14)
        Me.lblNCM.TabIndex = 37
        Me.lblNCM.Text = "NCM:"
        '
        'cboNCM
        '
        Me.cboNCM.Location = New System.Drawing.Point(9, 77)
        Me.cboNCM.Name = "cboNCM"
        Me.cboNCM.Size = New System.Drawing.Size(100, 20)
        Me.cboNCM.TabIndex = 36
        '
        'txtTotalFrete
        '
        Me.txtTotalFrete.DecimalDigits = 0
        Me.txtTotalFrete.Location = New System.Drawing.Point(9, 117)
        Me.txtTotalFrete.Name = "txtTotalFrete"
        Me.txtTotalFrete.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalFrete.TabIndex = 39
        Me.txtTotalFrete.Text = "0"
        Me.txtTotalFrete.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTotalFrete
        '
        Me.lblTotalFrete.AutoSize = True
        Me.lblTotalFrete.Location = New System.Drawing.Point(6, 100)
        Me.lblTotalFrete.Name = "lblTotalFrete"
        Me.lblTotalFrete.Size = New System.Drawing.Size(60, 14)
        Me.lblTotalFrete.TabIndex = 38
        Me.lblTotalFrete.Text = "Total Frete:"
        '
        'txtTotalSeguro
        '
        Me.txtTotalSeguro.DecimalDigits = 0
        Me.txtTotalSeguro.Location = New System.Drawing.Point(115, 117)
        Me.txtTotalSeguro.Name = "txtTotalSeguro"
        Me.txtTotalSeguro.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalSeguro.TabIndex = 41
        Me.txtTotalSeguro.Text = "0"
        Me.txtTotalSeguro.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTotalSeguro
        '
        Me.lblTotalSeguro.AutoSize = True
        Me.lblTotalSeguro.Location = New System.Drawing.Point(112, 100)
        Me.lblTotalSeguro.Name = "lblTotalSeguro"
        Me.lblTotalSeguro.Size = New System.Drawing.Size(70, 14)
        Me.lblTotalSeguro.TabIndex = 40
        Me.lblTotalSeguro.Text = "Total Seguro:"
        '
        'txtTotalDesconto
        '
        Me.txtTotalDesconto.DecimalDigits = 0
        Me.txtTotalDesconto.Location = New System.Drawing.Point(327, 117)
        Me.txtTotalDesconto.Name = "txtTotalDesconto"
        Me.txtTotalDesconto.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalDesconto.TabIndex = 43
        Me.txtTotalDesconto.Text = "0"
        Me.txtTotalDesconto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTotalDesconto
        '
        Me.lblTotalDesconto.AutoSize = True
        Me.lblTotalDesconto.Location = New System.Drawing.Point(324, 100)
        Me.lblTotalDesconto.Name = "lblTotalDesconto"
        Me.lblTotalDesconto.Size = New System.Drawing.Size(81, 14)
        Me.lblTotalDesconto.TabIndex = 42
        Me.lblTotalDesconto.Text = "Total Desconto:"
        '
        'txtTotalOutrasDespesas
        '
        Me.txtTotalOutrasDespesas.DecimalDigits = 0
        Me.txtTotalOutrasDespesas.Location = New System.Drawing.Point(221, 117)
        Me.txtTotalOutrasDespesas.Name = "txtTotalOutrasDespesas"
        Me.txtTotalOutrasDespesas.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalOutrasDespesas.TabIndex = 45
        Me.txtTotalOutrasDespesas.Text = "0"
        Me.txtTotalOutrasDespesas.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTotalOutrasDespesas
        '
        Me.lblTotalOutrasDespesas.AutoSize = True
        Me.lblTotalOutrasDespesas.Location = New System.Drawing.Point(218, 100)
        Me.lblTotalOutrasDespesas.Name = "lblTotalOutrasDespesas"
        Me.lblTotalOutrasDespesas.Size = New System.Drawing.Size(99, 14)
        Me.lblTotalOutrasDespesas.TabIndex = 44
        Me.lblTotalOutrasDespesas.Text = "Total Outras Desp.:"
        '
        'btnExcluirVolume
        '
        Me.btnExcluirVolume.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirVolume.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirVolume.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirVolume.Location = New System.Drawing.Point(457, 114)
        Me.btnExcluirVolume.Name = "btnExcluirVolume"
        Me.btnExcluirVolume.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirVolume.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirVolume.TabIndex = 47
        Me.btnExcluirVolume.Text = "Excluir"
        Me.btnExcluirVolume.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserirVolume
        '
        Me.btnInserirVolume.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirVolume.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirVolume.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirVolume.Location = New System.Drawing.Point(457, 85)
        Me.btnInserirVolume.Name = "btnInserirVolume"
        Me.btnInserirVolume.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirVolume.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirVolume.TabIndex = 46
        Me.btnInserirVolume.Text = "Inserir"
        Me.btnInserirVolume.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdVolume
        '
        Me.grdVolume.AllowDrop = True
        Me.grdVolume.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdVolume.AlternatingColors = True
        Me.grdVolume.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        grdVolume_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdVolume_DesignTimeLayout_Reference_0.Instance"), Object)
        grdVolume_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdVolume_DesignTimeLayout_Reference_0})
        grdVolume_DesignTimeLayout.LayoutString = resources.GetString("grdVolume_DesignTimeLayout.LayoutString")
        Me.grdVolume.DesignTimeLayout = grdVolume_DesignTimeLayout
        Me.grdVolume.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdVolume.FocusCellFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdVolume.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdVolume.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdVolume.FrozenColumns = 3
        Me.grdVolume.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdVolume.GroupByBoxVisible = False
        Me.grdVolume.Location = New System.Drawing.Point(8, 230)
        Me.grdVolume.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdVolume.Name = "grdVolume"
        Me.grdVolume.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdVolume.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdVolume.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdVolume.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdVolume.Size = New System.Drawing.Size(557, 134)
        Me.grdVolume.TabIndex = 4
        Me.grdVolume.TabStop = False
        Me.grdVolume.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdVolume.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdVolume.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdVolume.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdVolume.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdVolume.VisualStyleManager = Me.vsmMain
        '
        'frmFatEmissaoNFeDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 466)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEmissaoNFeDI"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nota Fiscal Eletrônica - Importar Pedido de Venda"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpDI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDI.ResumeLayout(False)
        Me.grpDI.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.ofaMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpAdicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAdicao.ResumeLayout(False)
        Me.grpAdicao.PerformLayout()
        CType(Me.grdVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnImportarPedidoVenda As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents ofaMain As Janus.Windows.Ribbon.OfficeFormAdorner
    Friend WithEvents grpDI As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNumeroDI As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDI As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtLocalDesembaraco As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblLocalDesembaraco As System.Windows.Forms.Label
    Friend WithEvents lblDataRegistro As System.Windows.Forms.Label
    Friend WithEvents dtpDataRegistro As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDataDesembaraco As System.Windows.Forms.Label
    Friend WithEvents dtpDataDesembaraco As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodigoExportador As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblCodigoExportador As System.Windows.Forms.Label
    Friend WithEvents lblUFLocalDesembaraco As System.Windows.Forms.Label
    Friend WithEvents cboUFLocalDesembaraco As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpAdicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtItemPedido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblItemPedido As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPedido As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblNumeroPedido As System.Windows.Forms.Label
    Friend WithEvents txtAdicao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtFabricante As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblFabricante As System.Windows.Forms.Label
    Friend WithEvents lblAdicao As System.Windows.Forms.Label
    Friend WithEvents lblNCM As System.Windows.Forms.Label
    Friend WithEvents cboNCM As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtTotalDesconto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalDesconto As System.Windows.Forms.Label
    Friend WithEvents txtTotalSeguro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalSeguro As System.Windows.Forms.Label
    Friend WithEvents txtTotalFrete As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalFrete As System.Windows.Forms.Label
    Friend WithEvents txtTotalOutrasDespesas As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotalOutrasDespesas As System.Windows.Forms.Label
    Friend WithEvents btnExcluirVolume As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserirVolume As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdVolume As Janus.Windows.GridEX.GridEX
End Class
