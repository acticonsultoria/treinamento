<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenOrcamentoGerarPedido
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
        Dim grdPedidoVendaOrcamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenOrcamentoGerarPedido))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNumeroOrcamentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroOrcamentoFiltro = New System.Windows.Forms.Label()
        Me.txtClienteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.grdPedidoVendaOrcamento = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnGerarPedido = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdPedidoVendaOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Location = New System.Drawing.Point(7, 9)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpFiltro)
        Me.pagTabela.Controls.Add(Me.grdPedidoVendaOrcamento)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(913, 543)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Orçamento"
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtNumeroOrcamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroOrcamentoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblClienteFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 64)
        Me.grpFiltro.TabIndex = 97
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroOrcamentoFiltro
        '
        Me.txtNumeroOrcamentoFiltro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroOrcamentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOrcamentoFiltro.Enabled = False
        Me.txtNumeroOrcamentoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroOrcamentoFiltro.MaxLength = 20
        Me.txtNumeroOrcamentoFiltro.Name = "txtNumeroOrcamentoFiltro"
        Me.txtNumeroOrcamentoFiltro.Size = New System.Drawing.Size(74, 20)
        Me.txtNumeroOrcamentoFiltro.TabIndex = 1
        '
        'lblNumeroOrcamentoFiltro
        '
        Me.lblNumeroOrcamentoFiltro.AutoSize = True
        Me.lblNumeroOrcamentoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroOrcamentoFiltro.Name = "lblNumeroOrcamentoFiltro"
        Me.lblNumeroOrcamentoFiltro.Size = New System.Drawing.Size(77, 14)
        Me.lblNumeroOrcamentoFiltro.TabIndex = 0
        Me.lblNumeroOrcamentoFiltro.Text = "N° Orçamento:"
        '
        'txtClienteFiltro
        '
        Me.txtClienteFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClienteFiltro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClienteFiltro.Enabled = False
        Me.txtClienteFiltro.Location = New System.Drawing.Point(89, 34)
        Me.txtClienteFiltro.MaxLength = 100
        Me.txtClienteFiltro.Name = "txtClienteFiltro"
        Me.txtClienteFiltro.Size = New System.Drawing.Size(799, 20)
        Me.txtClienteFiltro.TabIndex = 3
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.Location = New System.Drawing.Point(86, 17)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteFiltro.TabIndex = 2
        Me.lblClienteFiltro.Text = "Cliente:"
        '
        'grdPedidoVendaOrcamento
        '
        Me.grdPedidoVendaOrcamento.AlternatingColors = True
        Me.grdPedidoVendaOrcamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPedidoVendaOrcamento.AutoEdit = True
        grdPedidoVendaOrcamento_DesignTimeLayout.LayoutString = resources.GetString("grdPedidoVendaOrcamento_DesignTimeLayout.LayoutString")
        Me.grdPedidoVendaOrcamento.DesignTimeLayout = grdPedidoVendaOrcamento_DesignTimeLayout
        Me.grdPedidoVendaOrcamento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdPedidoVendaOrcamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPedidoVendaOrcamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPedidoVendaOrcamento.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdPedidoVendaOrcamento.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdPedidoVendaOrcamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPedidoVendaOrcamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPedidoVendaOrcamento.FrozenColumns = 1
        Me.grdPedidoVendaOrcamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPedidoVendaOrcamento.GroupByBoxVisible = False
        Me.grdPedidoVendaOrcamento.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdPedidoVendaOrcamento.Location = New System.Drawing.Point(8, 73)
        Me.grdPedidoVendaOrcamento.Name = "grdPedidoVendaOrcamento"
        Me.grdPedidoVendaOrcamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPedidoVendaOrcamento.RecordNavigator = True
        Me.grdPedidoVendaOrcamento.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdPedidoVendaOrcamento.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedidoVendaOrcamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdPedidoVendaOrcamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPedidoVendaOrcamento.Size = New System.Drawing.Size(897, 407)
        Me.grdPedidoVendaOrcamento.TabIndex = 1
        Me.grdPedidoVendaOrcamento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPedidoVendaOrcamento.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdPedidoVendaOrcamento.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdPedidoVendaOrcamento.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdPedidoVendaOrcamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdPedidoVendaOrcamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPedidoVendaOrcamento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdPedidoVendaOrcamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPedidoVendaOrcamento.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnGerarPedido)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 483)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(897, 51)
        Me.grpControl2.TabIndex = 3
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnGerarPedido
        '
        Me.btnGerarPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGerarPedido.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnGerarPedido.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarPedido.Location = New System.Drawing.Point(666, 17)
        Me.btnGerarPedido.Name = "btnGerarPedido"
        Me.btnGerarPedido.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnGerarPedido.Size = New System.Drawing.Size(125, 23)
        Me.btnGerarPedido.TabIndex = 0
        Me.btnGerarPedido.Text = "Gerar Pedido"
        Me.btnGerarPedido.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmVenOrcamentoGerarPedido
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
        Me.Name = "frmVenOrcamentoGerarPedido"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Orçamento - Gerar Pedido de Venda"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdPedidoVendaOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnGerarPedido As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdPedidoVendaOrcamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtNumeroOrcamentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroOrcamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtClienteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
End Class
