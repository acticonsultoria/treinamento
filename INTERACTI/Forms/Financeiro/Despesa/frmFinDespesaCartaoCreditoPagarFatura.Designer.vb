<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinDespesaCartaoCreditoPagarFatura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinDespesaCartaoCreditoPagarFatura))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.dtpDataPagamento = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPagamento = New System.Windows.Forms.Label()
        Me.txtDataVencimento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataVencimento = New System.Windows.Forms.Label()
        Me.txtBandeira = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblBandeira = New System.Windows.Forms.Label()
        Me.txtCartaoCredito = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCartaoCredito = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnPagar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
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
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(454, 233)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpInformacoes)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(452, 210)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Dados da Fatura"
        '
        'grpInformacoes
        '
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.txtValor)
        Me.grpInformacoes.Controls.Add(Me.lblValor)
        Me.grpInformacoes.Controls.Add(Me.dtpDataPagamento)
        Me.grpInformacoes.Controls.Add(Me.lblDataPagamento)
        Me.grpInformacoes.Controls.Add(Me.txtDataVencimento)
        Me.grpInformacoes.Controls.Add(Me.lblDataVencimento)
        Me.grpInformacoes.Controls.Add(Me.txtBandeira)
        Me.grpInformacoes.Controls.Add(Me.lblBandeira)
        Me.grpInformacoes.Controls.Add(Me.txtCartaoCredito)
        Me.grpInformacoes.Controls.Add(Me.lblCartaoCredito)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(436, 144)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'txtValor
        '
        Me.txtValor.DecimalDigits = 2
        Me.txtValor.Location = New System.Drawing.Point(219, 114)
        Me.txtValor.MaxLength = 0
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(99, 20)
        Me.txtValor.TabIndex = 9
        Me.txtValor.Text = "0,00"
        Me.txtValor.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(216, 97)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(35, 14)
        Me.lblValor.TabIndex = 8
        Me.lblValor.Text = "Valor:"
        '
        'dtpDataPagamento
        '
        '
        '
        '
        Me.dtpDataPagamento.DropDownCalendar.Name = ""
        Me.dtpDataPagamento.Location = New System.Drawing.Point(114, 114)
        Me.dtpDataPagamento.Name = "dtpDataPagamento"
        Me.dtpDataPagamento.Size = New System.Drawing.Size(99, 20)
        Me.dtpDataPagamento.TabIndex = 7
        '
        'lblDataPagamento
        '
        Me.lblDataPagamento.AutoSize = True
        Me.lblDataPagamento.Location = New System.Drawing.Point(111, 97)
        Me.lblDataPagamento.Name = "lblDataPagamento"
        Me.lblDataPagamento.Size = New System.Drawing.Size(88, 14)
        Me.lblDataPagamento.TabIndex = 6
        Me.lblDataPagamento.Text = "Data Pagamento:"
        '
        'txtDataVencimento
        '
        Me.txtDataVencimento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataVencimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataVencimento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDataVencimento.Location = New System.Drawing.Point(9, 114)
        Me.txtDataVencimento.MaxLength = 20
        Me.txtDataVencimento.Name = "txtDataVencimento"
        Me.txtDataVencimento.ReadOnly = True
        Me.txtDataVencimento.Size = New System.Drawing.Size(99, 20)
        Me.txtDataVencimento.TabIndex = 5
        Me.txtDataVencimento.TabStop = False
        '
        'lblDataVencimento
        '
        Me.lblDataVencimento.AutoSize = True
        Me.lblDataVencimento.Location = New System.Drawing.Point(6, 97)
        Me.lblDataVencimento.Name = "lblDataVencimento"
        Me.lblDataVencimento.Size = New System.Drawing.Size(91, 14)
        Me.lblDataVencimento.TabIndex = 4
        Me.lblDataVencimento.Text = "Data Vencimento:"
        '
        'txtBandeira
        '
        Me.txtBandeira.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBandeira.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBandeira.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtBandeira.Location = New System.Drawing.Point(9, 34)
        Me.txtBandeira.MaxLength = 20
        Me.txtBandeira.Name = "txtBandeira"
        Me.txtBandeira.ReadOnly = True
        Me.txtBandeira.Size = New System.Drawing.Size(418, 20)
        Me.txtBandeira.TabIndex = 1
        Me.txtBandeira.TabStop = False
        '
        'lblBandeira
        '
        Me.lblBandeira.AutoSize = True
        Me.lblBandeira.Location = New System.Drawing.Point(6, 17)
        Me.lblBandeira.Name = "lblBandeira"
        Me.lblBandeira.Size = New System.Drawing.Size(53, 14)
        Me.lblBandeira.TabIndex = 0
        Me.lblBandeira.Text = "Bandeira:"
        '
        'txtCartaoCredito
        '
        Me.txtCartaoCredito.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCartaoCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCartaoCredito.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCartaoCredito.Location = New System.Drawing.Point(9, 74)
        Me.txtCartaoCredito.MaxLength = 20
        Me.txtCartaoCredito.Name = "txtCartaoCredito"
        Me.txtCartaoCredito.ReadOnly = True
        Me.txtCartaoCredito.Size = New System.Drawing.Size(418, 20)
        Me.txtCartaoCredito.TabIndex = 3
        Me.txtCartaoCredito.TabStop = False
        '
        'lblCartaoCredito
        '
        Me.lblCartaoCredito.AutoSize = True
        Me.lblCartaoCredito.Location = New System.Drawing.Point(6, 57)
        Me.lblCartaoCredito.Name = "lblCartaoCredito"
        Me.lblCartaoCredito.Size = New System.Drawing.Size(94, 14)
        Me.lblCartaoCredito.TabIndex = 2
        Me.lblCartaoCredito.Text = "Cartão de Crédito:"
        '
        'grpControl2
        '
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnPagar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 150)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(436, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnPagar
        '
        Me.btnPagar.Image = Global.INTERACTI.My.Resources.aprovar
        Me.btnPagar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPagar.Location = New System.Drawing.Point(178, 17)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPagar.Size = New System.Drawing.Size(150, 23)
        Me.btnPagar.TabIndex = 0
        Me.btnPagar.Text = "Pagar Fatura"
        Me.btnPagar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(334, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmFinDespesaCartaoCreditoPagarFatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 248)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinDespesaCartaoCreditoPagarFatura"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Financeiro - Pagar Fatura"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
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
    Friend WithEvents btnPagar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDataVencimento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataVencimento As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamento As System.Windows.Forms.Label
    Friend WithEvents txtBandeira As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblBandeira As System.Windows.Forms.Label
    Friend WithEvents txtCartaoCredito As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCartaoCredito As System.Windows.Forms.Label
    Friend WithEvents dtpDataPagamento As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
End Class
