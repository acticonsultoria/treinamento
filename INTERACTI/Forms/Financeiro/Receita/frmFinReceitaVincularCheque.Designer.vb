<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinReceitaVincularCheque
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
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinReceitaVincularCheque))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Me.tmrAviso = New System.Windows.Forms.Timer(Me.components)
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtSaldoDevido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblSaldoDevido = New System.Windows.Forms.Label()
        Me.txtValorDevido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorDevido = New System.Windows.Forms.Label()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo>Arrast" & _
    "e o Cabeçalho da Coluna aqui para Agrupar</GroupByBoxInfo></LocalizableData>"
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.Location = New System.Drawing.Point(12, 68)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(839, 366)
        Me.grdListagem.TabIndex = 2
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'grpLegenda
        '
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.btnSalvar)
        Me.grpLegenda.Controls.Add(Me.btnSair)
        Me.grpLegenda.Location = New System.Drawing.Point(12, 436)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(839, 51)
        Me.grpLegenda.TabIndex = 5
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(634, 16)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 6
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(731, 16)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 17
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.txtSaldoDevido)
        Me.UiGroupBox1.Controls.Add(Me.lblSaldoDevido)
        Me.UiGroupBox1.Controls.Add(Me.txtValorDevido)
        Me.UiGroupBox1.Controls.Add(Me.lblValorDevido)
        Me.UiGroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(839, 57)
        Me.UiGroupBox1.TabIndex = 6
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'txtSaldoDevido
        '
        Me.txtSaldoDevido.DecimalDigits = 2
        Me.txtSaldoDevido.Location = New System.Drawing.Point(155, 29)
        Me.txtSaldoDevido.MaxLength = 0
        Me.txtSaldoDevido.Name = "txtSaldoDevido"
        Me.txtSaldoDevido.Size = New System.Drawing.Size(137, 20)
        Me.txtSaldoDevido.TabIndex = 15
        Me.txtSaldoDevido.Text = "0,00"
        Me.txtSaldoDevido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblSaldoDevido
        '
        Me.lblSaldoDevido.AutoSize = True
        Me.lblSaldoDevido.Location = New System.Drawing.Point(152, 12)
        Me.lblSaldoDevido.Name = "lblSaldoDevido"
        Me.lblSaldoDevido.Size = New System.Drawing.Size(74, 13)
        Me.lblSaldoDevido.TabIndex = 14
        Me.lblSaldoDevido.Text = "Saldo Devido:"
        '
        'txtValorDevido
        '
        Me.txtValorDevido.DecimalDigits = 2
        Me.txtValorDevido.Location = New System.Drawing.Point(12, 29)
        Me.txtValorDevido.MaxLength = 0
        Me.txtValorDevido.Name = "txtValorDevido"
        Me.txtValorDevido.Size = New System.Drawing.Size(137, 20)
        Me.txtValorDevido.TabIndex = 13
        Me.txtValorDevido.Text = "0,00"
        Me.txtValorDevido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorDevido
        '
        Me.lblValorDevido.AutoSize = True
        Me.lblValorDevido.Location = New System.Drawing.Point(9, 12)
        Me.lblValorDevido.Name = "lblValorDevido"
        Me.lblValorDevido.Size = New System.Drawing.Size(71, 13)
        Me.lblValorDevido.TabIndex = 12
        Me.lblValorDevido.Text = "Valor Devido:"
        '
        'frmFinReceitaVincularCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 493)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Controls.Add(Me.grpLegenda)
        Me.Controls.Add(Me.grdListagem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinReceitaVincularCheque"
        Me.Text = "Vincular Cheques"
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrAviso As System.Windows.Forms.Timer
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtSaldoDevido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblSaldoDevido As System.Windows.Forms.Label
    Friend WithEvents txtValorDevido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorDevido As System.Windows.Forms.Label
End Class
