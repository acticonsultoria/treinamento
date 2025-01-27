<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinTituloPagamentoMenorMagma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinTituloPagamentoMenorMagma))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.rdbDesconto = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbPagamentoParcial = New Janus.Windows.EditControls.UIRadioButton()
        Me.lblExplicacao = New System.Windows.Forms.Label()
        Me.lblTotalPago = New System.Windows.Forms.Label()
        Me.lblTotalDevido = New System.Windows.Forms.Label()
        Me.lblTotalJuros = New System.Windows.Forms.Label()
        Me.lblTotalDesconto = New System.Windows.Forms.Label()
        Me.lblTotalTitulo = New System.Windows.Forms.Label()
        Me.lblLabelTotalPago = New System.Windows.Forms.Label()
        Me.lblLabelTotalDevido = New System.Windows.Forms.Label()
        Me.lblLabelTotalJuros = New System.Windows.Forms.Label()
        Me.lblLabelTotalDesconto = New System.Windows.Forms.Label()
        Me.lblLabelTotalTitulo = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnConfirmar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.rdbTarifas = New Janus.Windows.EditControls.UIRadioButton()
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
        Me.tabMain.Size = New System.Drawing.Size(452, 311)
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
        Me.pagTabela.Size = New System.Drawing.Size(450, 288)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Totais"
        '
        'grpInformacoes
        '
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.rdbTarifas)
        Me.grpInformacoes.Controls.Add(Me.lblSaldo)
        Me.grpInformacoes.Controls.Add(Me.rdbDesconto)
        Me.grpInformacoes.Controls.Add(Me.rdbPagamentoParcial)
        Me.grpInformacoes.Controls.Add(Me.lblExplicacao)
        Me.grpInformacoes.Controls.Add(Me.lblTotalPago)
        Me.grpInformacoes.Controls.Add(Me.lblTotalDevido)
        Me.grpInformacoes.Controls.Add(Me.lblTotalJuros)
        Me.grpInformacoes.Controls.Add(Me.lblTotalDesconto)
        Me.grpInformacoes.Controls.Add(Me.lblTotalTitulo)
        Me.grpInformacoes.Controls.Add(Me.lblLabelTotalPago)
        Me.grpInformacoes.Controls.Add(Me.lblLabelTotalDevido)
        Me.grpInformacoes.Controls.Add(Me.lblLabelTotalJuros)
        Me.grpInformacoes.Controls.Add(Me.lblLabelTotalDesconto)
        Me.grpInformacoes.Controls.Add(Me.lblLabelTotalTitulo)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(434, 219)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblSaldo.Location = New System.Drawing.Point(262, 88)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblSaldo.Size = New System.Drawing.Size(100, 19)
        Me.lblSaldo.TabIndex = 11
        Me.lblSaldo.Text = "(Saldo      R$ 0,00)"
        '
        'rdbDesconto
        '
        Me.rdbDesconto.Location = New System.Drawing.Point(30, 172)
        Me.rdbDesconto.Name = "rdbDesconto"
        Me.rdbDesconto.Size = New System.Drawing.Size(298, 14)
        Me.rdbDesconto.TabIndex = 13
        Me.rdbDesconto.Text = "Descontos"
        '
        'rdbPagamentoParcial
        '
        Me.rdbPagamentoParcial.Checked = True
        Me.rdbPagamentoParcial.Location = New System.Drawing.Point(30, 152)
        Me.rdbPagamentoParcial.Name = "rdbPagamentoParcial"
        Me.rdbPagamentoParcial.Size = New System.Drawing.Size(298, 15)
        Me.rdbPagamentoParcial.TabIndex = 12
        Me.rdbPagamentoParcial.TabStop = True
        Me.rdbPagamentoParcial.Text = "Pagamento Parcial dos Débitos"
        '
        'lblExplicacao
        '
        Me.lblExplicacao.AutoSize = True
        Me.lblExplicacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblExplicacao.Location = New System.Drawing.Point(6, 107)
        Me.lblExplicacao.Name = "lblExplicacao"
        Me.lblExplicacao.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.lblExplicacao.Size = New System.Drawing.Size(375, 29)
        Me.lblExplicacao.TabIndex = 5
        Me.lblExplicacao.Text = "O Total Pago foi diferente do Total Devido. Esta diferença foi porque houve:"
        '
        'lblTotalPago
        '
        Me.lblTotalPago.AutoSize = True
        Me.lblTotalPago.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotalPago.ForeColor = System.Drawing.Color.Blue
        Me.lblTotalPago.Location = New System.Drawing.Point(127, 88)
        Me.lblTotalPago.Name = "lblTotalPago"
        Me.lblTotalPago.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblTotalPago.Size = New System.Drawing.Size(44, 19)
        Me.lblTotalPago.TabIndex = 10
        Me.lblTotalPago.Text = "R$ 0,00"
        '
        'lblTotalDevido
        '
        Me.lblTotalDevido.AutoSize = True
        Me.lblTotalDevido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotalDevido.ForeColor = System.Drawing.Color.Blue
        Me.lblTotalDevido.Location = New System.Drawing.Point(127, 69)
        Me.lblTotalDevido.Name = "lblTotalDevido"
        Me.lblTotalDevido.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblTotalDevido.Size = New System.Drawing.Size(44, 19)
        Me.lblTotalDevido.TabIndex = 9
        Me.lblTotalDevido.Text = "R$ 0,00"
        '
        'lblTotalJuros
        '
        Me.lblTotalJuros.AutoSize = True
        Me.lblTotalJuros.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotalJuros.ForeColor = System.Drawing.Color.Blue
        Me.lblTotalJuros.Location = New System.Drawing.Point(127, 50)
        Me.lblTotalJuros.Name = "lblTotalJuros"
        Me.lblTotalJuros.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblTotalJuros.Size = New System.Drawing.Size(44, 19)
        Me.lblTotalJuros.TabIndex = 8
        Me.lblTotalJuros.Text = "R$ 0,00"
        '
        'lblTotalDesconto
        '
        Me.lblTotalDesconto.AutoSize = True
        Me.lblTotalDesconto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotalDesconto.ForeColor = System.Drawing.Color.Blue
        Me.lblTotalDesconto.Location = New System.Drawing.Point(127, 31)
        Me.lblTotalDesconto.Name = "lblTotalDesconto"
        Me.lblTotalDesconto.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblTotalDesconto.Size = New System.Drawing.Size(44, 19)
        Me.lblTotalDesconto.TabIndex = 7
        Me.lblTotalDesconto.Text = "R$ 0,00"
        '
        'lblTotalTitulo
        '
        Me.lblTotalTitulo.AutoSize = True
        Me.lblTotalTitulo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotalTitulo.ForeColor = System.Drawing.Color.Blue
        Me.lblTotalTitulo.Location = New System.Drawing.Point(127, 17)
        Me.lblTotalTitulo.Name = "lblTotalTitulo"
        Me.lblTotalTitulo.Size = New System.Drawing.Size(44, 14)
        Me.lblTotalTitulo.TabIndex = 6
        Me.lblTotalTitulo.Text = "R$ 0,00"
        '
        'lblLabelTotalPago
        '
        Me.lblLabelTotalPago.AutoSize = True
        Me.lblLabelTotalPago.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLabelTotalPago.Location = New System.Drawing.Point(6, 88)
        Me.lblLabelTotalPago.Name = "lblLabelTotalPago"
        Me.lblLabelTotalPago.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblLabelTotalPago.Size = New System.Drawing.Size(66, 19)
        Me.lblLabelTotalPago.TabIndex = 4
        Me.lblLabelTotalPago.Text = "Total Pago:"
        '
        'lblLabelTotalDevido
        '
        Me.lblLabelTotalDevido.AutoSize = True
        Me.lblLabelTotalDevido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLabelTotalDevido.Location = New System.Drawing.Point(6, 69)
        Me.lblLabelTotalDevido.Name = "lblLabelTotalDevido"
        Me.lblLabelTotalDevido.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblLabelTotalDevido.Size = New System.Drawing.Size(76, 19)
        Me.lblLabelTotalDevido.TabIndex = 3
        Me.lblLabelTotalDevido.Text = "Total Devido:"
        '
        'lblLabelTotalJuros
        '
        Me.lblLabelTotalJuros.AutoSize = True
        Me.lblLabelTotalJuros.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLabelTotalJuros.Location = New System.Drawing.Point(6, 50)
        Me.lblLabelTotalJuros.Name = "lblLabelTotalJuros"
        Me.lblLabelTotalJuros.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblLabelTotalJuros.Size = New System.Drawing.Size(88, 19)
        Me.lblLabelTotalJuros.TabIndex = 2
        Me.lblLabelTotalJuros.Text = "Total de Juros:"
        '
        'lblLabelTotalDesconto
        '
        Me.lblLabelTotalDesconto.AutoSize = True
        Me.lblLabelTotalDesconto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLabelTotalDesconto.Location = New System.Drawing.Point(6, 31)
        Me.lblLabelTotalDesconto.Name = "lblLabelTotalDesconto"
        Me.lblLabelTotalDesconto.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblLabelTotalDesconto.Size = New System.Drawing.Size(115, 19)
        Me.lblLabelTotalDesconto.TabIndex = 1
        Me.lblLabelTotalDesconto.Text = "Total de Descontos:"
        '
        'lblLabelTotalTitulo
        '
        Me.lblLabelTotalTitulo.AutoSize = True
        Me.lblLabelTotalTitulo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLabelTotalTitulo.Location = New System.Drawing.Point(6, 17)
        Me.lblLabelTotalTitulo.Name = "lblLabelTotalTitulo"
        Me.lblLabelTotalTitulo.Size = New System.Drawing.Size(36, 14)
        Me.lblLabelTotalTitulo.TabIndex = 0
        Me.lblLabelTotalTitulo.Text = "Total:"
        '
        'grpControl2
        '
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnConfirmar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 228)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(434, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmar.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnConfirmar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnConfirmar.Location = New System.Drawing.Point(237, 17)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnConfirmar.Size = New System.Drawing.Size(91, 23)
        Me.btnConfirmar.TabIndex = 0
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'rdbTarifas
        '
        Me.rdbTarifas.Location = New System.Drawing.Point(30, 192)
        Me.rdbTarifas.Name = "rdbTarifas"
        Me.rdbTarifas.Size = New System.Drawing.Size(298, 14)
        Me.rdbTarifas.TabIndex = 14
        Me.rdbTarifas.Text = "Tarifas"
        '
        'frmFinTituloPagamentoMenorMagma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 330)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinTituloPagamentoMenorMagma"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Definição de Juros e Desconto das Duplicatas"
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
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLabelTotalTitulo As System.Windows.Forms.Label
    Friend WithEvents lblLabelTotalPago As System.Windows.Forms.Label
    Friend WithEvents lblLabelTotalDevido As System.Windows.Forms.Label
    Friend WithEvents lblLabelTotalJuros As System.Windows.Forms.Label
    Friend WithEvents lblLabelTotalDesconto As System.Windows.Forms.Label
    Friend WithEvents lblExplicacao As System.Windows.Forms.Label
    Friend WithEvents lblTotalPago As System.Windows.Forms.Label
    Friend WithEvents lblTotalDevido As System.Windows.Forms.Label
    Friend WithEvents lblTotalJuros As System.Windows.Forms.Label
    Friend WithEvents lblTotalDesconto As System.Windows.Forms.Label
    Friend WithEvents lblTotalTitulo As System.Windows.Forms.Label
    Friend WithEvents rdbDesconto As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbPagamentoParcial As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Private WithEvents btnConfirmar As Janus.Windows.EditControls.UIButton
    Friend WithEvents rdbTarifas As Janus.Windows.EditControls.UIRadioButton
End Class
