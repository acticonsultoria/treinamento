<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCmp000000011
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
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCmp000000011))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.lblInformacao = New System.Windows.Forms.Label()
        Me.trvMain = New System.Windows.Forms.TreeView()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorFiltro = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorFiltro = New System.Windows.Forms.Label()
        Me.lblConsiderarPedidoVendaFiltro = New System.Windows.Forms.Label()
        Me.cboConsiderarPedidoVendaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblMarcaFiltro = New System.Windows.Forms.Label()
        Me.cboMarcaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.vsmMain.DefaultColorScheme = Nothing
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.lblInformacao)
        Me.pagLista.Controls.Add(Me.trvMain)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(998, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório Compras - CMP000000011"
        '
        'lblInformacao
        '
        Me.lblInformacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInformacao.BackColor = System.Drawing.Color.Transparent
        Me.lblInformacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblInformacao.ForeColor = System.Drawing.Color.Firebrick
        Me.lblInformacao.Location = New System.Drawing.Point(8, 452)
        Me.lblInformacao.Name = "lblInformacao"
        Me.lblInformacao.Size = New System.Drawing.Size(302, 28)
        Me.lblInformacao.TabIndex = 4
        Me.lblInformacao.Text = "Desmarque os Grupos de Item que deseja Eliminar do Relatório"
        Me.lblInformacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'trvMain
        '
        Me.trvMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvMain.CheckBoxes = True
        Me.trvMain.FullRowSelect = True
        Me.trvMain.ItemHeight = 20
        Me.trvMain.Location = New System.Drawing.Point(8, 77)
        Me.trvMain.Name = "trvMain"
        Me.trvMain.ShowLines = False
        Me.trvMain.ShowNodeToolTips = True
        Me.trvMain.Size = New System.Drawing.Size(302, 369)
        Me.trvMain.TabIndex = 3
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtValorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblValorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblConsiderarPedidoVendaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboConsiderarPedidoVendaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblMarcaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboMarcaFiltro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtValorFiltro
        '
        Me.txtValorFiltro.DecimalDigits = 2
        Me.txtValorFiltro.Location = New System.Drawing.Point(488, 37)
        Me.txtValorFiltro.Name = "txtValorFiltro"
        Me.txtValorFiltro.Size = New System.Drawing.Size(100, 20)
        Me.txtValorFiltro.TabIndex = 7
        Me.txtValorFiltro.Text = "0,00"
        Me.txtValorFiltro.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorFiltro
        '
        Me.lblValorFiltro.AutoSize = True
        Me.lblValorFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValorFiltro.Location = New System.Drawing.Point(485, 20)
        Me.lblValorFiltro.Name = "lblValorFiltro"
        Me.lblValorFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblValorFiltro.TabIndex = 6
        Me.lblValorFiltro.Text = "Valor:"
        '
        'lblConsiderarPedidoVendaFiltro
        '
        Me.lblConsiderarPedidoVendaFiltro.AutoSize = True
        Me.lblConsiderarPedidoVendaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConsiderarPedidoVendaFiltro.Location = New System.Drawing.Point(305, 20)
        Me.lblConsiderarPedidoVendaFiltro.Name = "lblConsiderarPedidoVendaFiltro"
        Me.lblConsiderarPedidoVendaFiltro.Size = New System.Drawing.Size(160, 14)
        Me.lblConsiderarPedidoVendaFiltro.TabIndex = 4
        Me.lblConsiderarPedidoVendaFiltro.Text = "Considerar Cliente Aguardando:"
        '
        'cboConsiderarPedidoVendaFiltro
        '
        Me.cboConsiderarPedidoVendaFiltro.Location = New System.Drawing.Point(308, 37)
        Me.cboConsiderarPedidoVendaFiltro.Name = "cboConsiderarPedidoVendaFiltro"
        Me.cboConsiderarPedidoVendaFiltro.Size = New System.Drawing.Size(174, 20)
        Me.cboConsiderarPedidoVendaFiltro.TabIndex = 5
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(882, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 8
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblMarcaFiltro
        '
        Me.lblMarcaFiltro.AutoSize = True
        Me.lblMarcaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarcaFiltro.Location = New System.Drawing.Point(5, 20)
        Me.lblMarcaFiltro.Name = "lblMarcaFiltro"
        Me.lblMarcaFiltro.Size = New System.Drawing.Size(40, 14)
        Me.lblMarcaFiltro.TabIndex = 0
        Me.lblMarcaFiltro.Text = "Marca:"
        '
        'cboMarcaFiltro
        '
        Me.cboMarcaFiltro.Location = New System.Drawing.Point(8, 37)
        Me.cboMarcaFiltro.Name = "cboMarcaFiltro"
        Me.cboMarcaFiltro.Size = New System.Drawing.Size(294, 20)
        Me.cboMarcaFiltro.TabIndex = 1
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
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(316, 77)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(674, 403)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.lblCongelarColuna)
        Me.grpControl.Controls.Add(Me.cboCongelarColuna)
        Me.grpControl.Controls.Add(Me.btnExcel)
        Me.grpControl.Controls.Add(Me.btnVisualizarImpressao)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(982, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(5, 22)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 13
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(100, 19)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 14
        Me.cboCongelarColuna.TabStop = False
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(629, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 12
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVisualizarImpressao
        '
        Me.btnVisualizarImpressao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarImpressao.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnVisualizarImpressao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarImpressao.Location = New System.Drawing.Point(726, 17)
        Me.btnVisualizarImpressao.Name = "btnVisualizarImpressao"
        Me.btnVisualizarImpressao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarImpressao.Size = New System.Drawing.Size(150, 23)
        Me.btnVisualizarImpressao.TabIndex = 0
        Me.btnVisualizarImpressao.Text = "Visualizar Impressão"
        Me.btnVisualizarImpressao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'usrCmp000000011
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCmp000000011"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnVisualizarImpressao As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblMarcaFiltro As System.Windows.Forms.Label
    Friend WithEvents cboMarcaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblConsiderarPedidoVendaFiltro As System.Windows.Forms.Label
    Friend WithEvents cboConsiderarPedidoVendaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtValorFiltro As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorFiltro As System.Windows.Forms.Label
    Friend WithEvents lblInformacao As System.Windows.Forms.Label
    Friend WithEvents trvMain As System.Windows.Forms.TreeView

End Class
