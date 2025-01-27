<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadProdutoHistoricoCompra
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
        Dim grdOrcamentoGrupo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadProdutoHistoricoCompra))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpHistoricoCompras = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCodigoCompras = New System.Windows.Forms.Label()
        Me.txtMarcaCompras = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMarcaCompras = New System.Windows.Forms.Label()
        Me.txtCodigo2Compras = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricaoCompras = New System.Windows.Forms.Label()
        Me.lblCodigo2Compras = New System.Windows.Forms.Label()
        Me.txtDescricaoCompras = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCodigoCompras = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grdOrcamentoGrupo = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.grpHistoricoCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHistoricoCompras.SuspendLayout()
        CType(Me.grdOrcamentoGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'grpHistoricoCompras
        '
        Me.grpHistoricoCompras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpHistoricoCompras.BackColor = System.Drawing.Color.Transparent
        Me.grpHistoricoCompras.Controls.Add(Me.lblCodigoCompras)
        Me.grpHistoricoCompras.Controls.Add(Me.txtMarcaCompras)
        Me.grpHistoricoCompras.Controls.Add(Me.lblMarcaCompras)
        Me.grpHistoricoCompras.Controls.Add(Me.txtCodigo2Compras)
        Me.grpHistoricoCompras.Controls.Add(Me.lblDescricaoCompras)
        Me.grpHistoricoCompras.Controls.Add(Me.lblCodigo2Compras)
        Me.grpHistoricoCompras.Controls.Add(Me.txtDescricaoCompras)
        Me.grpHistoricoCompras.Controls.Add(Me.txtCodigoCompras)
        Me.grpHistoricoCompras.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpHistoricoCompras.Location = New System.Drawing.Point(12, 12)
        Me.grpHistoricoCompras.Name = "grpHistoricoCompras"
        Me.grpHistoricoCompras.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpHistoricoCompras.Size = New System.Drawing.Size(975, 64)
        Me.grpHistoricoCompras.TabIndex = 44
        Me.grpHistoricoCompras.Text = "Dados do Produto"
        Me.grpHistoricoCompras.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpHistoricoCompras.VisualStyleManager = Me.vsmMain
        '
        'lblCodigoCompras
        '
        Me.lblCodigoCompras.AutoSize = True
        Me.lblCodigoCompras.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoCompras.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigoCompras.Name = "lblCodigoCompras"
        Me.lblCodigoCompras.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigoCompras.TabIndex = 0
        Me.lblCodigoCompras.Text = "Código:"
        '
        'txtMarcaCompras
        '
        Me.txtMarcaCompras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarcaCompras.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMarcaCompras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaCompras.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMarcaCompras.Location = New System.Drawing.Point(787, 34)
        Me.txtMarcaCompras.MaxLength = 100
        Me.txtMarcaCompras.Name = "txtMarcaCompras"
        Me.txtMarcaCompras.ReadOnly = True
        Me.txtMarcaCompras.Size = New System.Drawing.Size(179, 20)
        Me.txtMarcaCompras.TabIndex = 9
        Me.txtMarcaCompras.TabStop = False
        '
        'lblMarcaCompras
        '
        Me.lblMarcaCompras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMarcaCompras.AutoSize = True
        Me.lblMarcaCompras.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarcaCompras.Location = New System.Drawing.Point(784, 17)
        Me.lblMarcaCompras.Name = "lblMarcaCompras"
        Me.lblMarcaCompras.Size = New System.Drawing.Size(40, 14)
        Me.lblMarcaCompras.TabIndex = 8
        Me.lblMarcaCompras.Text = "Marca:"
        '
        'txtCodigo2Compras
        '
        Me.txtCodigo2Compras.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigo2Compras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo2Compras.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodigo2Compras.Location = New System.Drawing.Point(138, 34)
        Me.txtCodigo2Compras.Name = "txtCodigo2Compras"
        Me.txtCodigo2Compras.ReadOnly = True
        Me.txtCodigo2Compras.Size = New System.Drawing.Size(123, 20)
        Me.txtCodigo2Compras.TabIndex = 3
        Me.txtCodigo2Compras.TabStop = False
        '
        'lblDescricaoCompras
        '
        Me.lblDescricaoCompras.AutoSize = True
        Me.lblDescricaoCompras.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricaoCompras.Location = New System.Drawing.Point(264, 17)
        Me.lblDescricaoCompras.Name = "lblDescricaoCompras"
        Me.lblDescricaoCompras.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricaoCompras.TabIndex = 6
        Me.lblDescricaoCompras.Text = "Descrição:"
        '
        'lblCodigo2Compras
        '
        Me.lblCodigo2Compras.AutoSize = True
        Me.lblCodigo2Compras.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigo2Compras.Location = New System.Drawing.Point(135, 17)
        Me.lblCodigo2Compras.Name = "lblCodigo2Compras"
        Me.lblCodigo2Compras.Size = New System.Drawing.Size(50, 14)
        Me.lblCodigo2Compras.TabIndex = 2
        Me.lblCodigo2Compras.Text = "Código ²:"
        '
        'txtDescricaoCompras
        '
        Me.txtDescricaoCompras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricaoCompras.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricaoCompras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricaoCompras.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDescricaoCompras.Location = New System.Drawing.Point(267, 34)
        Me.txtDescricaoCompras.MaxLength = 120
        Me.txtDescricaoCompras.Name = "txtDescricaoCompras"
        Me.txtDescricaoCompras.ReadOnly = True
        Me.txtDescricaoCompras.Size = New System.Drawing.Size(514, 20)
        Me.txtDescricaoCompras.TabIndex = 7
        Me.txtDescricaoCompras.TabStop = False
        '
        'txtCodigoCompras
        '
        Me.txtCodigoCompras.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigoCompras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoCompras.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodigoCompras.Location = New System.Drawing.Point(9, 34)
        Me.txtCodigoCompras.Name = "txtCodigoCompras"
        Me.txtCodigoCompras.ReadOnly = True
        Me.txtCodigoCompras.Size = New System.Drawing.Size(123, 20)
        Me.txtCodigoCompras.TabIndex = 1
        Me.txtCodigoCompras.TabStop = False
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
        Me.grdOrcamentoGrupo.Location = New System.Drawing.Point(12, 82)
        Me.grdOrcamentoGrupo.Name = "grdOrcamentoGrupo"
        Me.grdOrcamentoGrupo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamentoGrupo.RecordNavigator = True
        Me.grdOrcamentoGrupo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOrcamentoGrupo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamentoGrupo.Size = New System.Drawing.Size(979, 250)
        Me.grdOrcamentoGrupo.TabIndex = 45
        Me.grdOrcamentoGrupo.TabStop = False
        Me.grdOrcamentoGrupo.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdOrcamentoGrupo.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOrcamentoGrupo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamentoGrupo.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(12, 338)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(975, 51)
        Me.grpControl2.TabIndex = 46
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(875, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmCadProdutoHistoricoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 401)
        Me.Controls.Add(Me.grpControl2)
        Me.Controls.Add(Me.grdOrcamentoGrupo)
        Me.Controls.Add(Me.grpHistoricoCompras)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadProdutoHistoricoCompra"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Produto - Histórico de Compra"
        CType(Me.grpHistoricoCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHistoricoCompras.ResumeLayout(False)
        Me.grpHistoricoCompras.PerformLayout()
        CType(Me.grdOrcamentoGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grpHistoricoCompras As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCodigoCompras As System.Windows.Forms.Label
    Friend WithEvents txtMarcaCompras As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMarcaCompras As System.Windows.Forms.Label
    Friend WithEvents txtCodigo2Compras As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoCompras As System.Windows.Forms.Label
    Friend WithEvents lblCodigo2Compras As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoCompras As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCodigoCompras As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grdOrcamentoGrupo As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
End Class
