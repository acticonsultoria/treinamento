<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFin000000030
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFin000000030))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaPedidoCompra = New System.Windows.Forms.Label()
        Me.lblEntregue = New System.Windows.Forms.Label()
        Me.picLegendaTipoOrcamento = New System.Windows.Forms.PictureBox()
        Me.picEntregue = New System.Windows.Forms.PictureBox()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboStatusFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblStatusFiltro = New System.Windows.Forms.Label()
        Me.txtFornecedor = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.btnFiltrarGrid = New Janus.Windows.EditControls.UIButton()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEmissao = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnConfiguraGridListagem = New System.Windows.Forms.Button()
        Me.btnExcelListagem = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.btnAtualizar = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaTipoOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEntregue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grpLegenda)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.btnConfiguraGridListagem)
        Me.pagLista.Controls.Add(Me.btnExcelListagem)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório Financeiro - FIN000000030"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaPedidoCompra)
        Me.grpLegenda.Controls.Add(Me.lblEntregue)
        Me.grpLegenda.Controls.Add(Me.picLegendaTipoOrcamento)
        Me.grpLegenda.Controls.Add(Me.picEntregue)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(131, 51)
        Me.grpLegenda.TabIndex = 103
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaPedidoCompra
        '
        Me.lblLegendaPedidoCompra.AutoSize = True
        Me.lblLegendaPedidoCompra.Location = New System.Drawing.Point(28, 13)
        Me.lblLegendaPedidoCompra.Name = "lblLegendaPedidoCompra"
        Me.lblLegendaPedidoCompra.Size = New System.Drawing.Size(55, 14)
        Me.lblLegendaPedidoCompra.TabIndex = 0
        Me.lblLegendaPedidoCompra.Text = "Em aberto"
        '
        'lblEntregue
        '
        Me.lblEntregue.AutoSize = True
        Me.lblEntregue.Location = New System.Drawing.Point(28, 32)
        Me.lblEntregue.Name = "lblEntregue"
        Me.lblEntregue.Size = New System.Drawing.Size(46, 14)
        Me.lblEntregue.TabIndex = 1
        Me.lblEntregue.Text = "Baixado"
        '
        'picLegendaTipoOrcamento
        '
        Me.picLegendaTipoOrcamento.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaTipoOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaTipoOrcamento.Location = New System.Drawing.Point(9, 13)
        Me.picLegendaTipoOrcamento.Name = "picLegendaTipoOrcamento"
        Me.picLegendaTipoOrcamento.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaTipoOrcamento.TabIndex = 4
        Me.picLegendaTipoOrcamento.TabStop = False
        '
        'picEntregue
        '
        Me.picEntregue.BackColor = System.Drawing.Color.ForestGreen
        Me.picEntregue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picEntregue.Location = New System.Drawing.Point(9, 32)
        Me.picEntregue.Name = "picEntregue"
        Me.picEntregue.Size = New System.Drawing.Size(13, 14)
        Me.picEntregue.TabIndex = 18
        Me.picEntregue.TabStop = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.txtFornecedor)
        Me.grpFiltro.Controls.Add(Me.txtCliente)
        Me.grpFiltro.Controls.Add(Me.lblFornecedor)
        Me.grpFiltro.Controls.Add(Me.btnFiltrarGrid)
        Me.grpFiltro.Controls.Add(Me.lblCliente)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissao)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 107)
        Me.grpFiltro.TabIndex = 2
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AutoSize = False
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboStatusFiltro.Location = New System.Drawing.Point(238, 76)
        Me.cboStatusFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboStatusFiltro.Size = New System.Drawing.Size(153, 20)
        Me.cboStatusFiltro.TabIndex = 18
        '
        'lblStatusFiltro
        '
        Me.lblStatusFiltro.AutoSize = True
        Me.lblStatusFiltro.Location = New System.Drawing.Point(235, 59)
        Me.lblStatusFiltro.Name = "lblStatusFiltro"
        Me.lblStatusFiltro.Size = New System.Drawing.Size(41, 14)
        Me.lblStatusFiltro.TabIndex = 17
        Me.lblStatusFiltro.Text = "Status:"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFornecedor.Location = New System.Drawing.Point(340, 36)
        Me.txtFornecedor.MaxLength = 20
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(377, 20)
        Me.txtFornecedor.TabIndex = 16
        '
        'txtCliente
        '
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(10, 36)
        Me.txtCliente.MaxLength = 20
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(320, 20)
        Me.txtCliente.TabIndex = 14
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFornecedor.Location = New System.Drawing.Point(337, 20)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(37, 14)
        Me.lblFornecedor.TabIndex = 12
        Me.lblFornecedor.Text = "Saída:"
        '
        'btnFiltrarGrid
        '
        Me.btnFiltrarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrarGrid.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrarGrid.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrarGrid.Location = New System.Drawing.Point(883, 74)
        Me.btnFiltrarGrid.Name = "btnFiltrarGrid"
        Me.btnFiltrarGrid.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrarGrid.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrarGrid.TabIndex = 11
        Me.btnFiltrarGrid.Text = "Filtrar"
        Me.btnFiltrarGrid.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCliente.Location = New System.Drawing.Point(7, 19)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente:"
        '
        'dtpDataEmissaoTerminoFiltro
        '
        Me.dtpDataEmissaoTerminoFiltro.Checked = False
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(124, 76)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 4
        '
        'dtpDataInicioFiltro
        '
        Me.dtpDataInicioFiltro.Checked = False
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(10, 76)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInicioFiltro.TabIndex = 3
        '
        'lblDataEmissao
        '
        Me.lblDataEmissao.AutoSize = True
        Me.lblDataEmissao.Location = New System.Drawing.Point(7, 59)
        Me.lblDataEmissao.Name = "lblDataEmissao"
        Me.lblDataEmissao.Size = New System.Drawing.Size(72, 14)
        Me.lblDataEmissao.TabIndex = 2
        Me.lblDataEmissao.Text = "Data Entrada:"
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnAtualizar)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(145, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(845, 51)
        Me.grpControl.TabIndex = 5
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(745, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnConfiguraGridListagem
        '
        Me.btnConfiguraGridListagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfiguraGridListagem.BackColor = System.Drawing.Color.Transparent
        Me.btnConfiguraGridListagem.FlatAppearance.BorderSize = 0
        Me.btnConfiguraGridListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguraGridListagem.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfiguraGridListagem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfiguraGridListagem.Location = New System.Drawing.Point(12, 463)
        Me.btnConfiguraGridListagem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfiguraGridListagem.Name = "btnConfiguraGridListagem"
        Me.btnConfiguraGridListagem.Size = New System.Drawing.Size(24, 15)
        Me.btnConfiguraGridListagem.TabIndex = 101
        Me.btnConfiguraGridListagem.TabStop = False
        Me.btnConfiguraGridListagem.UseVisualStyleBackColor = False
        '
        'btnExcelListagem
        '
        Me.btnExcelListagem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelListagem.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelListagem.FlatAppearance.BorderSize = 0
        Me.btnExcelListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelListagem.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelListagem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelListagem.Location = New System.Drawing.Point(36, 463)
        Me.btnExcelListagem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelListagem.Name = "btnExcelListagem"
        Me.btnExcelListagem.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelListagem.TabIndex = 102
        Me.btnExcelListagem.TabStop = False
        Me.btnExcelListagem.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 119)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 361)
        Me.grdListagem.TabIndex = 100
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtualizar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnAtualizar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAtualizar.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnAtualizar.Location = New System.Drawing.Point(636, 17)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAtualizar.Size = New System.Drawing.Size(103, 23)
        Me.btnAtualizar.TabIndex = 2
        Me.btnAtualizar.Text = "Atualizar Valor"
        Me.btnAtualizar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrFin000000030
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFin000000030"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaTipoOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEntregue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFiltrarGrid As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEmissao As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelListagem As System.Windows.Forms.Button
    Friend WithEvents btnConfiguraGridListagem As System.Windows.Forms.Button
    Friend WithEvents btnExportarRelatorio As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents txtFornecedor As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaPedidoCompra As System.Windows.Forms.Label
    Friend WithEvents lblEntregue As System.Windows.Forms.Label
    Friend WithEvents picLegendaTipoOrcamento As System.Windows.Forms.PictureBox
    Friend WithEvents picEntregue As System.Windows.Forms.PictureBox
    Friend WithEvents lblStatusFiltro As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnAtualizar As Janus.Windows.EditControls.UIButton

End Class
