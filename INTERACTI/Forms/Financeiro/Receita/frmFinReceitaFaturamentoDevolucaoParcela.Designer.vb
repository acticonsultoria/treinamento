<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinReceitaFaturamentoDevolucaoParcela
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
        Dim grdParcela_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinReceitaFaturamentoDevolucaoParcela))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.lblInformacao = New System.Windows.Forms.Label()
        Me.grdParcela = New Janus.Windows.GridEX.GridEX()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtIntervaloParcelas = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblIntervaloParcelas = New System.Windows.Forms.Label()
        Me.txtNumeroParcelas = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroParcelas = New System.Windows.Forms.Label()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtDescritivo = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblDescritivo = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnGerarCredito = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grdParcela, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(622, 347)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.lblInformacao)
        Me.pagTabela.Controls.Add(Me.grdParcela)
        Me.pagTabela.Controls.Add(Me.UiGroupBox1)
        Me.pagTabela.Controls.Add(Me.grpInformacoes)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(620, 324)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Dados do Título"
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
        Me.lblInformacao.Text = "Obs.: Caso a Data de Vencimento não coincida com a Data de Vencimento gerado pelo" & _
    " sistema, altere manualmente na Listagem"
        Me.lblInformacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grdParcela
        '
        Me.grdParcela.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdParcela.AutoEdit = True
        Me.grdParcela.BlendColor = System.Drawing.SystemColors.WindowFrame
        grdParcela_DesignTimeLayout.LayoutString = resources.GetString("grdParcela_DesignTimeLayout.LayoutString")
        Me.grdParcela.DesignTimeLayout = grdParcela_DesignTimeLayout
        Me.grdParcela.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdParcela.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdParcela.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdParcela.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdParcela.GroupByBoxVisible = False
        Me.grdParcela.Location = New System.Drawing.Point(373, 76)
        Me.grdParcela.Name = "grdParcela"
        Me.grdParcela.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdParcela.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdParcela.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdParcela.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdParcela.Size = New System.Drawing.Size(239, 185)
        Me.grdParcela.TabIndex = 2
        Me.grdParcela.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdParcela.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdParcela.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdParcela.VisualStyleManager = Me.vsmMain
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.txtIntervaloParcelas)
        Me.UiGroupBox1.Controls.Add(Me.lblIntervaloParcelas)
        Me.UiGroupBox1.Controls.Add(Me.txtNumeroParcelas)
        Me.UiGroupBox1.Controls.Add(Me.lblNumeroParcelas)
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 70)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(357, 63)
        Me.UiGroupBox1.TabIndex = 1
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'txtIntervaloParcelas
        '
        Me.txtIntervaloParcelas.DecimalDigits = 0
        Me.txtIntervaloParcelas.Location = New System.Drawing.Point(159, 34)
        Me.txtIntervaloParcelas.Name = "txtIntervaloParcelas"
        Me.txtIntervaloParcelas.Size = New System.Drawing.Size(189, 20)
        Me.txtIntervaloParcelas.TabIndex = 3
        Me.txtIntervaloParcelas.Text = "0"
        Me.txtIntervaloParcelas.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblIntervaloParcelas
        '
        Me.lblIntervaloParcelas.AutoSize = True
        Me.lblIntervaloParcelas.Location = New System.Drawing.Point(156, 17)
        Me.lblIntervaloParcelas.Name = "lblIntervaloParcelas"
        Me.lblIntervaloParcelas.Size = New System.Drawing.Size(164, 14)
        Me.lblIntervaloParcelas.TabIndex = 2
        Me.lblIntervaloParcelas.Text = "Intervalo entre as Parcelas (dia):"
        '
        'txtNumeroParcelas
        '
        Me.txtNumeroParcelas.DecimalDigits = 0
        Me.txtNumeroParcelas.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroParcelas.Name = "txtNumeroParcelas"
        Me.txtNumeroParcelas.Size = New System.Drawing.Size(144, 20)
        Me.txtNumeroParcelas.TabIndex = 1
        Me.txtNumeroParcelas.Text = "0"
        Me.txtNumeroParcelas.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumeroParcelas
        '
        Me.lblNumeroParcelas.AutoSize = True
        Me.lblNumeroParcelas.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroParcelas.Name = "lblNumeroParcelas"
        Me.lblNumeroParcelas.Size = New System.Drawing.Size(82, 14)
        Me.lblNumeroParcelas.TabIndex = 0
        Me.lblNumeroParcelas.Text = "Nº de Parcelas:"
        '
        'grpInformacoes
        '
        Me.grpInformacoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.lblNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.txtNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.txtValor)
        Me.grpInformacoes.Controls.Add(Me.lblValor)
        Me.grpInformacoes.Controls.Add(Me.txtDescritivo)
        Me.grpInformacoes.Controls.Add(Me.lblDescritivo)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(604, 64)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 5
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumento.MaxLength = 0
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.ReadOnly = True
        Me.txtNumeroDocumento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(91, 20)
        Me.txtNumeroDocumento.TabIndex = 4
        Me.txtNumeroDocumento.TabStop = False
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValor.DecimalDigits = 2
        Me.txtValor.Location = New System.Drawing.Point(502, 34)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.ReadOnly = True
        Me.txtValor.Size = New System.Drawing.Size(91, 20)
        Me.txtValor.TabIndex = 3
        Me.txtValor.TabStop = False
        Me.txtValor.Text = "0,00"
        Me.txtValor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(499, 17)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(35, 14)
        Me.lblValor.TabIndex = 2
        Me.lblValor.Text = "Valor:"
        '
        'txtDescritivo
        '
        Me.txtDescritivo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescritivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescritivo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDescritivo.Location = New System.Drawing.Point(106, 34)
        Me.txtDescritivo.MaxLength = 0
        Me.txtDescritivo.Name = "txtDescritivo"
        Me.txtDescritivo.ReadOnly = True
        Me.txtDescritivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescritivo.Size = New System.Drawing.Size(390, 20)
        Me.txtDescritivo.TabIndex = 1
        Me.txtDescritivo.TabStop = False
        '
        'lblDescritivo
        '
        Me.lblDescritivo.AutoSize = True
        Me.lblDescritivo.Location = New System.Drawing.Point(103, 17)
        Me.lblDescritivo.Name = "lblDescritivo"
        Me.lblDescritivo.Size = New System.Drawing.Size(58, 14)
        Me.lblDescritivo.TabIndex = 0
        Me.lblDescritivo.Text = "Descritivo:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnGerarCredito)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 264)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(604, 51)
        Me.grpControl2.TabIndex = 4
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnGerarCredito
        '
        Me.btnGerarCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGerarCredito.Image = Global.INTERACTI.My.Resources.dinheiro
        Me.btnGerarCredito.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarCredito.Location = New System.Drawing.Point(348, 17)
        Me.btnGerarCredito.Name = "btnGerarCredito"
        Me.btnGerarCredito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnGerarCredito.Size = New System.Drawing.Size(150, 23)
        Me.btnGerarCredito.TabIndex = 0
        Me.btnGerarCredito.Text = "Gerar Crédito"
        Me.btnGerarCredito.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(504, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmFinReceitaFaturamentoDevolucaoParcela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(636, 363)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinReceitaFaturamentoDevolucaoParcela"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gerar Crédito"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grdParcela, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnGerarCredito As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDescritivo As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblDescritivo As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdParcela As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtIntervaloParcelas As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblIntervaloParcelas As System.Windows.Forms.Label
    Friend WithEvents txtNumeroParcelas As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroParcelas As System.Windows.Forms.Label
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents lblInformacao As System.Windows.Forms.Label
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.EditBox
End Class
