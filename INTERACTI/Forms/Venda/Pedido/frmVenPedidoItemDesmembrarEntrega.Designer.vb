<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenPedidoItemDesmembrarEntrega
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
        Dim grdEntrega_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenPedidoItemDesmembrarEntrega))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.lblInformacao = New System.Windows.Forms.Label()
        Me.grdEntrega = New Janus.Windows.GridEX.GridEX()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtIntervaloEntrega = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblIntervaloEntrega = New System.Windows.Forms.Label()
        Me.txtNumeroEntrega = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroEntrega = New System.Windows.Forms.Label()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtItem = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnDesmembrarEntrega = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grdEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInformacoes.SuspendLayout()
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
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(682, 347)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.lblInformacao)
        Me.pagTabela.Controls.Add(Me.grdEntrega)
        Me.pagTabela.Controls.Add(Me.UiGroupBox1)
        Me.pagTabela.Controls.Add(Me.grpInformacoes)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(680, 324)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Dados da Entrega"
        '
        'lblInformacao
        '
        Me.lblInformacao.BackColor = System.Drawing.Color.Transparent
        Me.lblInformacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformacao.ForeColor = System.Drawing.Color.Blue
        Me.lblInformacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInformacao.Location = New System.Drawing.Point(5, 233)
        Me.lblInformacao.Name = "lblInformacao"
        Me.lblInformacao.Size = New System.Drawing.Size(360, 28)
        Me.lblInformacao.TabIndex = 3
        Me.lblInformacao.Text = "Obs.:Caso o Prazo de Entrega na coincida com o Prazo de entrega gerado pelo siste" & _
    "ma, altere manualmente na Listagem"
        Me.lblInformacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grdEntrega
        '
        Me.grdEntrega.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdEntrega.AutoEdit = True
        Me.grdEntrega.BlendColor = System.Drawing.SystemColors.WindowFrame
        grdEntrega_DesignTimeLayout.LayoutString = resources.GetString("grdEntrega_DesignTimeLayout.LayoutString")
        Me.grdEntrega.DesignTimeLayout = grdEntrega_DesignTimeLayout
        Me.grdEntrega.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdEntrega.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdEntrega.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdEntrega.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdEntrega.GroupByBoxVisible = False
        Me.grdEntrega.Location = New System.Drawing.Point(373, 76)
        Me.grdEntrega.Name = "grdEntrega"
        Me.grdEntrega.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdEntrega.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdEntrega.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdEntrega.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdEntrega.Size = New System.Drawing.Size(299, 185)
        Me.grdEntrega.TabIndex = 2
        Me.grdEntrega.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdEntrega.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdEntrega.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdEntrega.VisualStyleManager = Me.vsmMain
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.txtIntervaloEntrega)
        Me.UiGroupBox1.Controls.Add(Me.lblIntervaloEntrega)
        Me.UiGroupBox1.Controls.Add(Me.txtNumeroEntrega)
        Me.UiGroupBox1.Controls.Add(Me.lblNumeroEntrega)
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 70)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(356, 63)
        Me.UiGroupBox1.TabIndex = 1
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'txtIntervaloEntrega
        '
        Me.txtIntervaloEntrega.DecimalDigits = 0
        Me.txtIntervaloEntrega.Location = New System.Drawing.Point(159, 34)
        Me.txtIntervaloEntrega.Name = "txtIntervaloEntrega"
        Me.txtIntervaloEntrega.Size = New System.Drawing.Size(189, 20)
        Me.txtIntervaloEntrega.TabIndex = 3
        Me.txtIntervaloEntrega.Text = "0"
        Me.txtIntervaloEntrega.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblIntervaloEntrega
        '
        Me.lblIntervaloEntrega.AutoSize = True
        Me.lblIntervaloEntrega.Location = New System.Drawing.Point(156, 17)
        Me.lblIntervaloEntrega.Name = "lblIntervaloEntrega"
        Me.lblIntervaloEntrega.Size = New System.Drawing.Size(150, 14)
        Me.lblIntervaloEntrega.TabIndex = 2
        Me.lblIntervaloEntrega.Text = "Intervalo entre Entregas (dia):"
        '
        'txtNumeroEntrega
        '
        Me.txtNumeroEntrega.DecimalDigits = 0
        Me.txtNumeroEntrega.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroEntrega.Name = "txtNumeroEntrega"
        Me.txtNumeroEntrega.Size = New System.Drawing.Size(144, 20)
        Me.txtNumeroEntrega.TabIndex = 1
        Me.txtNumeroEntrega.Text = "0"
        Me.txtNumeroEntrega.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumeroEntrega
        '
        Me.lblNumeroEntrega.AutoSize = True
        Me.lblNumeroEntrega.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroEntrega.Name = "lblNumeroEntrega"
        Me.lblNumeroEntrega.Size = New System.Drawing.Size(83, 14)
        Me.lblNumeroEntrega.TabIndex = 0
        Me.lblNumeroEntrega.Text = "Nº de Entregas:"
        '
        'grpInformacoes
        '
        Me.grpInformacoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.txtQuantidade)
        Me.grpInformacoes.Controls.Add(Me.lblQuantidade)
        Me.grpInformacoes.Controls.Add(Me.txtItem)
        Me.grpInformacoes.Controls.Add(Me.lblItem)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(664, 64)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(562, 34)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.ReadOnly = True
        Me.txtQuantidade.Size = New System.Drawing.Size(91, 20)
        Me.txtQuantidade.TabIndex = 3
        Me.txtQuantidade.TabStop = False
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidade
        '
        Me.lblQuantidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(559, 17)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 2
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtItem
        '
        Me.txtItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtItem.Location = New System.Drawing.Point(9, 34)
        Me.txtItem.MaxLength = 0
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtItem.Size = New System.Drawing.Size(547, 20)
        Me.txtItem.TabIndex = 1
        Me.txtItem.TabStop = False
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(6, 17)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(29, 14)
        Me.lblItem.TabIndex = 0
        Me.lblItem.Text = "Item:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnDesmembrarEntrega)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 264)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(664, 51)
        Me.grpControl2.TabIndex = 4
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnDesmembrarEntrega
        '
        Me.btnDesmembrarEntrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDesmembrarEntrega.Image = Global.INTERACTI.My.Resources.calendario
        Me.btnDesmembrarEntrega.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnDesmembrarEntrega.Location = New System.Drawing.Point(408, 17)
        Me.btnDesmembrarEntrega.Name = "btnDesmembrarEntrega"
        Me.btnDesmembrarEntrega.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnDesmembrarEntrega.Size = New System.Drawing.Size(150, 23)
        Me.btnDesmembrarEntrega.TabIndex = 0
        Me.btnDesmembrarEntrega.Text = "Desmembrar Entrega"
        Me.btnDesmembrarEntrega.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(564, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmVenPedidoItemDesmembrarEntrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(696, 363)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVenPedidoItemDesmembrarEntrega"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Desmembrar Entrega"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grdEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInformacoes.ResumeLayout(False)
        Me.grpInformacoes.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnDesmembrarEntrega As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtItem As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdEntrega As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtIntervaloEntrega As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblIntervaloEntrega As System.Windows.Forms.Label
    Friend WithEvents txtNumeroEntrega As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroEntrega As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents lblInformacao As System.Windows.Forms.Label
End Class
