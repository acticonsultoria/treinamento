<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEmissaoNFeRemessa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEmissaoNFeRemessa))
        Dim grdRemessa_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdRemessa_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaRegraVenda = New System.Windows.Forms.Label()
        Me.picLegendaRegraVenda = New System.Windows.Forms.PictureBox()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboDeposito = New Janus.Windows.EditControls.UIComboBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.btnProcurarCliente = New System.Windows.Forms.Button()
        Me.cboClienteFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.txtCNPJCPFFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCNPJCPFFiltro = New System.Windows.Forms.Label()
        Me.lblDepositoFiltro = New System.Windows.Forms.Label()
        Me.cboDestinacaoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDestinacaoFiltro = New System.Windows.Forms.Label()
        Me.grpPedidoVenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnImportar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdRemessa = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaRegraVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpPedidoVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPedidoVenda.SuspendLayout()
        CType(Me.grdRemessa, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(914, 567)
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
        Me.pagTabela.Controls.Add(Me.grpLegenda)
        Me.pagTabela.Controls.Add(Me.grpFiltro)
        Me.pagTabela.Controls.Add(Me.grpPedidoVenda)
        Me.pagTabela.Controls.Add(Me.grdRemessa)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(912, 544)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Remessa"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 464)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 4
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 464)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 3
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 464)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaRegraVenda)
        Me.grpLegenda.Controls.Add(Me.picLegendaRegraVenda)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 484)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(207, 51)
        Me.grpLegenda.TabIndex = 5
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaRegraVenda
        '
        Me.lblLegendaRegraVenda.AutoSize = True
        Me.lblLegendaRegraVenda.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaRegraVenda.Name = "lblLegendaRegraVenda"
        Me.lblLegendaRegraVenda.Size = New System.Drawing.Size(175, 14)
        Me.lblLegendaRegraVenda.TabIndex = 0
        Me.lblLegendaRegraVenda.Text = "NÃO possui Regra de Faturamento"
        '
        'picLegendaRegraVenda
        '
        Me.picLegendaRegraVenda.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaRegraVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaRegraVenda.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaRegraVenda.Name = "picLegendaRegraVenda"
        Me.picLegendaRegraVenda.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaRegraVenda.TabIndex = 16
        Me.picLegendaRegraVenda.TabStop = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboDeposito)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.btnProcurarCliente)
        Me.grpFiltro.Controls.Add(Me.cboClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCNPJCPFFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCNPJCPFFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDepositoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboDestinacaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDestinacaoFiltro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(896, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboDeposito
        '
        Me.cboDeposito.AutoSize = False
        Me.cboDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDeposito.Location = New System.Drawing.Point(213, 34)
        Me.cboDeposito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDeposito.Size = New System.Drawing.Size(199, 20)
        Me.cboDeposito.TabIndex = 3
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(796, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 9
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnProcurarCliente
        '
        Me.btnProcurarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarCliente.FlatAppearance.BorderSize = 0
        Me.btnProcurarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCliente.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCliente.Location = New System.Drawing.Point(638, 16)
        Me.btnProcurarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCliente.Name = "btnProcurarCliente"
        Me.btnProcurarCliente.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCliente.TabIndex = 6
        Me.btnProcurarCliente.TabStop = False
        Me.btnProcurarCliente.UseVisualStyleBackColor = True
        '
        'cboClienteFiltro
        '
        Me.cboClienteFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboClienteFiltro.AutoSize = False
        Me.cboClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboClienteFiltro.Location = New System.Drawing.Point(418, 34)
        Me.cboClienteFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboClienteFiltro.Name = "cboClienteFiltro"
        Me.cboClienteFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboClienteFiltro.Size = New System.Drawing.Size(237, 20)
        Me.cboClienteFiltro.TabIndex = 5
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.Location = New System.Drawing.Point(415, 17)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteFiltro.TabIndex = 4
        Me.lblClienteFiltro.Text = "Cliente:"
        '
        'txtCNPJCPFFiltro
        '
        Me.txtCNPJCPFFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCNPJCPFFiltro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCNPJCPFFiltro.Enabled = False
        Me.txtCNPJCPFFiltro.Location = New System.Drawing.Point(661, 34)
        Me.txtCNPJCPFFiltro.Mask = "00,000,000/0000-00"
        Me.txtCNPJCPFFiltro.MaxLength = 25
        Me.txtCNPJCPFFiltro.Name = "txtCNPJCPFFiltro"
        Me.txtCNPJCPFFiltro.ReadOnly = True
        Me.txtCNPJCPFFiltro.Size = New System.Drawing.Size(129, 20)
        Me.txtCNPJCPFFiltro.TabIndex = 8
        Me.txtCNPJCPFFiltro.TabStop = False
        '
        'lblCNPJCPFFiltro
        '
        Me.lblCNPJCPFFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCNPJCPFFiltro.AutoSize = True
        Me.lblCNPJCPFFiltro.Location = New System.Drawing.Point(658, 17)
        Me.lblCNPJCPFFiltro.Name = "lblCNPJCPFFiltro"
        Me.lblCNPJCPFFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblCNPJCPFFiltro.TabIndex = 7
        Me.lblCNPJCPFFiltro.Text = "CNPJ:"
        '
        'lblDepositoFiltro
        '
        Me.lblDepositoFiltro.AutoSize = True
        Me.lblDepositoFiltro.Location = New System.Drawing.Point(210, 17)
        Me.lblDepositoFiltro.Name = "lblDepositoFiltro"
        Me.lblDepositoFiltro.Size = New System.Drawing.Size(52, 14)
        Me.lblDepositoFiltro.TabIndex = 2
        Me.lblDepositoFiltro.Text = "Depósito:"
        '
        'cboDestinacaoFiltro
        '
        Me.cboDestinacaoFiltro.AutoSize = False
        Me.cboDestinacaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDestinacaoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.cboDestinacaoFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDestinacaoFiltro.Name = "cboDestinacaoFiltro"
        Me.cboDestinacaoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDestinacaoFiltro.Size = New System.Drawing.Size(198, 20)
        Me.cboDestinacaoFiltro.TabIndex = 1
        '
        'lblDestinacaoFiltro
        '
        Me.lblDestinacaoFiltro.AutoSize = True
        Me.lblDestinacaoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblDestinacaoFiltro.Name = "lblDestinacaoFiltro"
        Me.lblDestinacaoFiltro.Size = New System.Drawing.Size(64, 14)
        Me.lblDestinacaoFiltro.TabIndex = 0
        Me.lblDestinacaoFiltro.Text = "Destinação:"
        '
        'grpPedidoVenda
        '
        Me.grpPedidoVenda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPedidoVenda.BackColor = System.Drawing.Color.Transparent
        Me.grpPedidoVenda.Controls.Add(Me.lblCongelarColuna)
        Me.grpPedidoVenda.Controls.Add(Me.cboCongelarColuna)
        Me.grpPedidoVenda.Controls.Add(Me.btnImportar)
        Me.grpPedidoVenda.Controls.Add(Me.btnSair)
        Me.grpPedidoVenda.Location = New System.Drawing.Point(224, 484)
        Me.grpPedidoVenda.Name = "grpPedidoVenda"
        Me.grpPedidoVenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPedidoVenda.Size = New System.Drawing.Size(680, 51)
        Me.grpPedidoVenda.TabIndex = 6
        Me.grpPedidoVenda.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpPedidoVenda.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 0
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 1
        Me.cboCongelarColuna.TabStop = False
        '
        'btnImportar
        '
        Me.btnImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportar.Image = Global.INTERACTI.My.Resources.Resources.download
        Me.btnImportar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportar.Location = New System.Drawing.Point(483, 17)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportar.Size = New System.Drawing.Size(91, 23)
        Me.btnImportar.TabIndex = 2
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(580, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdRemessa
        '
        Me.grdRemessa.AllowChildTableGroups = True
        Me.grdRemessa.AlternatingColors = True
        Me.grdRemessa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRemessa.AutoEdit = True
        grdRemessa_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdRemessa_DesignTimeLayout_Reference_0.Instance"), Object)
        grdRemessa_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdRemessa_DesignTimeLayout_Reference_0})
        grdRemessa_DesignTimeLayout.LayoutString = resources.GetString("grdRemessa_DesignTimeLayout.LayoutString")
        Me.grdRemessa.DesignTimeLayout = grdRemessa_DesignTimeLayout
        Me.grdRemessa.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdRemessa.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdRemessa.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdRemessa.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdRemessa.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdRemessa.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdRemessa.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdRemessa.FrozenColumns = 2
        Me.grdRemessa.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdRemessa.GroupByBoxVisible = False
        Me.grdRemessa.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdRemessa.Hierarchical = True
        Me.grdRemessa.Location = New System.Drawing.Point(8, 77)
        Me.grdRemessa.Name = "grdRemessa"
        Me.grdRemessa.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdRemessa.RecordNavigator = True
        Me.grdRemessa.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdRemessa.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdRemessa.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdRemessa.Size = New System.Drawing.Size(896, 404)
        Me.grdRemessa.TabIndex = 1
        Me.grdRemessa.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdRemessa.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdRemessa.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdRemessa.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdRemessa.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdRemessa.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdRemessa.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdRemessa.UpdateOnLeave = False
        Me.grdRemessa.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdRemessa.VisualStyleManager = Me.vsmMain
        '
        'frmFatEmissaoNFeRemessa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 582)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEmissaoNFeRemessa"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Nota Fiscal Eletrônica - Remessa"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaRegraVenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpPedidoVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPedidoVenda.ResumeLayout(False)
        Me.grpPedidoVenda.PerformLayout()
        CType(Me.grdRemessa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpPedidoVenda As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnImportar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDepositoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtCNPJCPFFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCNPJCPFFiltro As System.Windows.Forms.Label
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaRegraVenda As System.Windows.Forms.Label
    Friend WithEvents picLegendaRegraVenda As System.Windows.Forms.PictureBox
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents cboClienteFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnProcurarCliente As System.Windows.Forms.Button
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdRemessa As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents cboDestinacaoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDestinacaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboDeposito As Janus.Windows.EditControls.UIComboBox
End Class
