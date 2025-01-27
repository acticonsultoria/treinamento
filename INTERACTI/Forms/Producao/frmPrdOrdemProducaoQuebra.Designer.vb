<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrdOrdemProducaoQuebra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrdOrdemProducaoQuebra))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtQuantidadeQuebra = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeQuebra = New System.Windows.Forms.Label()
        Me.txtProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtQuantidadeProduzida = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtQuantidadeRejeito = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtQuantidadePlanejada = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeRejeito = New System.Windows.Forms.Label()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.lblQuantidadeProduzida = New System.Windows.Forms.Label()
        Me.lblQuantidadePlanejada = New System.Windows.Forms.Label()
        Me.txtOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducao = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnDividirOrdemProducao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.txtJustificativa = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblJustificativa = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
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
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(705, 408)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpDados)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(703, 385)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Dividir Ordem de Produção"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtJustificativa)
        Me.grpDados.Controls.Add(Me.lblJustificativa)
        Me.grpDados.Controls.Add(Me.txtQuantidadeQuebra)
        Me.grpDados.Controls.Add(Me.lblQuantidadeQuebra)
        Me.grpDados.Controls.Add(Me.txtProduto)
        Me.grpDados.Controls.Add(Me.txtQuantidadeProduzida)
        Me.grpDados.Controls.Add(Me.txtQuantidadeRejeito)
        Me.grpDados.Controls.Add(Me.txtQuantidadePlanejada)
        Me.grpDados.Controls.Add(Me.lblQuantidadeRejeito)
        Me.grpDados.Controls.Add(Me.lblProduto)
        Me.grpDados.Controls.Add(Me.lblQuantidadeProduzida)
        Me.grpDados.Controls.Add(Me.lblQuantidadePlanejada)
        Me.grpDados.Controls.Add(Me.txtOrdemProducao)
        Me.grpDados.Controls.Add(Me.lblOrdemProducao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(687, 319)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtQuantidadeQuebra
        '
        Me.txtQuantidadeQuebra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeQuebra.DecimalDigits = 4
        Me.txtQuantidadeQuebra.Location = New System.Drawing.Point(594, 34)
        Me.txtQuantidadeQuebra.Name = "txtQuantidadeQuebra"
        Me.txtQuantidadeQuebra.Size = New System.Drawing.Size(84, 20)
        Me.txtQuantidadeQuebra.TabIndex = 11
        Me.txtQuantidadeQuebra.Text = "0,0000"
        Me.txtQuantidadeQuebra.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeQuebra
        '
        Me.lblQuantidadeQuebra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeQuebra.AutoSize = True
        Me.lblQuantidadeQuebra.Location = New System.Drawing.Point(591, 17)
        Me.lblQuantidadeQuebra.Name = "lblQuantidadeQuebra"
        Me.lblQuantidadeQuebra.Size = New System.Drawing.Size(75, 14)
        Me.lblQuantidadeQuebra.TabIndex = 10
        Me.lblQuantidadeQuebra.Text = "Qtde. Quebra:"
        '
        'txtProduto
        '
        Me.txtProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.Location = New System.Drawing.Point(145, 34)
        Me.txtProduto.MaxLength = 60
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.ReadOnly = True
        Me.txtProduto.Size = New System.Drawing.Size(166, 20)
        Me.txtProduto.TabIndex = 3
        Me.txtProduto.TabStop = False
        '
        'txtQuantidadeProduzida
        '
        Me.txtQuantidadeProduzida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeProduzida.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeProduzida.DecimalDigits = 4
        Me.txtQuantidadeProduzida.Location = New System.Drawing.Point(504, 34)
        Me.txtQuantidadeProduzida.Name = "txtQuantidadeProduzida"
        Me.txtQuantidadeProduzida.ReadOnly = True
        Me.txtQuantidadeProduzida.Size = New System.Drawing.Size(84, 20)
        Me.txtQuantidadeProduzida.TabIndex = 9
        Me.txtQuantidadeProduzida.TabStop = False
        Me.txtQuantidadeProduzida.Text = "0,0000"
        Me.txtQuantidadeProduzida.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'txtQuantidadeRejeito
        '
        Me.txtQuantidadeRejeito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeRejeito.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeRejeito.DecimalDigits = 4
        Me.txtQuantidadeRejeito.Location = New System.Drawing.Point(412, 34)
        Me.txtQuantidadeRejeito.Name = "txtQuantidadeRejeito"
        Me.txtQuantidadeRejeito.ReadOnly = True
        Me.txtQuantidadeRejeito.Size = New System.Drawing.Size(86, 20)
        Me.txtQuantidadeRejeito.TabIndex = 7
        Me.txtQuantidadeRejeito.TabStop = False
        Me.txtQuantidadeRejeito.Text = "0,0000"
        Me.txtQuantidadeRejeito.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'txtQuantidadePlanejada
        '
        Me.txtQuantidadePlanejada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadePlanejada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadePlanejada.DecimalDigits = 4
        Me.txtQuantidadePlanejada.Location = New System.Drawing.Point(317, 34)
        Me.txtQuantidadePlanejada.Name = "txtQuantidadePlanejada"
        Me.txtQuantidadePlanejada.ReadOnly = True
        Me.txtQuantidadePlanejada.Size = New System.Drawing.Size(89, 20)
        Me.txtQuantidadePlanejada.TabIndex = 5
        Me.txtQuantidadePlanejada.TabStop = False
        Me.txtQuantidadePlanejada.Text = "0,0000"
        Me.txtQuantidadePlanejada.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeRejeito
        '
        Me.lblQuantidadeRejeito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeRejeito.AutoSize = True
        Me.lblQuantidadeRejeito.Location = New System.Drawing.Point(409, 18)
        Me.lblQuantidadeRejeito.Name = "lblQuantidadeRejeito"
        Me.lblQuantidadeRejeito.Size = New System.Drawing.Size(71, 14)
        Me.lblQuantidadeRejeito.TabIndex = 6
        Me.lblQuantidadeRejeito.Text = "Qtde. Rejeito:"
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(142, 17)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 2
        Me.lblProduto.Text = "Produto:"
        '
        'lblQuantidadeProduzida
        '
        Me.lblQuantidadeProduzida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeProduzida.AutoSize = True
        Me.lblQuantidadeProduzida.Location = New System.Drawing.Point(501, 17)
        Me.lblQuantidadeProduzida.Name = "lblQuantidadeProduzida"
        Me.lblQuantidadeProduzida.Size = New System.Drawing.Size(87, 14)
        Me.lblQuantidadeProduzida.TabIndex = 8
        Me.lblQuantidadeProduzida.Text = "Qtde. Produzida:"
        '
        'lblQuantidadePlanejada
        '
        Me.lblQuantidadePlanejada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadePlanejada.AutoSize = True
        Me.lblQuantidadePlanejada.Location = New System.Drawing.Point(314, 17)
        Me.lblQuantidadePlanejada.Name = "lblQuantidadePlanejada"
        Me.lblQuantidadePlanejada.Size = New System.Drawing.Size(85, 14)
        Me.lblQuantidadePlanejada.TabIndex = 4
        Me.lblQuantidadePlanejada.Text = "Qtde. Planejada:"
        '
        'txtOrdemProducao
        '
        Me.txtOrdemProducao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdemProducao.Location = New System.Drawing.Point(9, 34)
        Me.txtOrdemProducao.MaxLength = 20
        Me.txtOrdemProducao.Name = "txtOrdemProducao"
        Me.txtOrdemProducao.ReadOnly = True
        Me.txtOrdemProducao.Size = New System.Drawing.Size(130, 20)
        Me.txtOrdemProducao.TabIndex = 1
        Me.txtOrdemProducao.TabStop = False
        '
        'lblOrdemProducao
        '
        Me.lblOrdemProducao.AutoSize = True
        Me.lblOrdemProducao.Location = New System.Drawing.Point(6, 17)
        Me.lblOrdemProducao.Name = "lblOrdemProducao"
        Me.lblOrdemProducao.Size = New System.Drawing.Size(91, 14)
        Me.lblOrdemProducao.TabIndex = 0
        Me.lblOrdemProducao.Text = "Ordem Produção:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnDividirOrdemProducao)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 325)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(687, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnDividirOrdemProducao
        '
        Me.btnDividirOrdemProducao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDividirOrdemProducao.Image = Global.INTERACTI.My.Resources.dividir2
        Me.btnDividirOrdemProducao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnDividirOrdemProducao.Location = New System.Drawing.Point(381, 17)
        Me.btnDividirOrdemProducao.Name = "btnDividirOrdemProducao"
        Me.btnDividirOrdemProducao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnDividirOrdemProducao.Size = New System.Drawing.Size(200, 23)
        Me.btnDividirOrdemProducao.TabIndex = 0
        Me.btnDividirOrdemProducao.Text = "Dividir Ordem de Produção"
        Me.btnDividirOrdemProducao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(587, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtJustificativa
        '
        Me.txtJustificativa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJustificativa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJustificativa.Location = New System.Drawing.Point(9, 74)
        Me.txtJustificativa.MaxLength = 5000
        Me.txtJustificativa.Multiline = True
        Me.txtJustificativa.Name = "txtJustificativa"
        Me.txtJustificativa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJustificativa.Size = New System.Drawing.Size(669, 235)
        Me.txtJustificativa.TabIndex = 13
        '
        'lblJustificativa
        '
        Me.lblJustificativa.AutoSize = True
        Me.lblJustificativa.BackColor = System.Drawing.Color.Transparent
        Me.lblJustificativa.Location = New System.Drawing.Point(6, 57)
        Me.lblJustificativa.Name = "lblJustificativa"
        Me.lblJustificativa.Size = New System.Drawing.Size(67, 14)
        Me.lblJustificativa.TabIndex = 12
        Me.lblJustificativa.Text = "Justificativa:"
        '
        'frmPrdOrdemProducaoQuebra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 422)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrdOrdemProducaoQuebra"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dividir Ordem de Produção"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnDividirOrdemProducao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtQuantidadeQuebra As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeQuebra As System.Windows.Forms.Label
    Friend WithEvents txtProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtQuantidadeProduzida As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtQuantidadeRejeito As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtQuantidadePlanejada As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeRejeito As System.Windows.Forms.Label
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeProduzida As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadePlanejada As System.Windows.Forms.Label
    Friend WithEvents txtOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents txtJustificativa As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblJustificativa As System.Windows.Forms.Label
End Class
