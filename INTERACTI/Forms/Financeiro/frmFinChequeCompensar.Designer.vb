<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinChequeCompensar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinChequeCompensar))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataCompensacao = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataCompensacao = New System.Windows.Forms.Label()
        Me.txtPreDatadoPara = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPreDatadoPara = New System.Windows.Forms.Label()
        Me.txtDataPagamento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataPagamento = New System.Windows.Forms.Label()
        Me.txtParceiroNegocio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.lblParceiroNegocio = New System.Windows.Forms.Label()
        Me.txtContaBancaria = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblContaBancaria = New System.Windows.Forms.Label()
        Me.txtNumerCheque = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.numero_cheque = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCompensar = New Janus.Windows.EditControls.UIButton()
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
        Me.pagTabela.Text = "Dados do Cheque"
        '
        'grpInformacoes
        '
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.dtpDataCompensacao)
        Me.grpInformacoes.Controls.Add(Me.lblDataCompensacao)
        Me.grpInformacoes.Controls.Add(Me.txtPreDatadoPara)
        Me.grpInformacoes.Controls.Add(Me.lblPreDatadoPara)
        Me.grpInformacoes.Controls.Add(Me.txtDataPagamento)
        Me.grpInformacoes.Controls.Add(Me.lblDataPagamento)
        Me.grpInformacoes.Controls.Add(Me.txtParceiroNegocio)
        Me.grpInformacoes.Controls.Add(Me.txtNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.lblNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.lblParceiroNegocio)
        Me.grpInformacoes.Controls.Add(Me.txtContaBancaria)
        Me.grpInformacoes.Controls.Add(Me.lblContaBancaria)
        Me.grpInformacoes.Controls.Add(Me.txtNumerCheque)
        Me.grpInformacoes.Controls.Add(Me.numero_cheque)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(436, 144)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'dtpDataCompensacao
        '
        '
        '
        '
        Me.dtpDataCompensacao.DropDownCalendar.Name = ""
        Me.dtpDataCompensacao.Location = New System.Drawing.Point(219, 114)
        Me.dtpDataCompensacao.Name = "dtpDataCompensacao"
        Me.dtpDataCompensacao.Size = New System.Drawing.Size(109, 20)
        Me.dtpDataCompensacao.TabIndex = 13
        '
        'lblDataCompensacao
        '
        Me.lblDataCompensacao.AutoSize = True
        Me.lblDataCompensacao.Location = New System.Drawing.Point(216, 97)
        Me.lblDataCompensacao.Name = "lblDataCompensacao"
        Me.lblDataCompensacao.Size = New System.Drawing.Size(104, 14)
        Me.lblDataCompensacao.TabIndex = 12
        Me.lblDataCompensacao.Text = "Data Compensação:"
        '
        'txtPreDatadoPara
        '
        Me.txtPreDatadoPara.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPreDatadoPara.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPreDatadoPara.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPreDatadoPara.Location = New System.Drawing.Point(114, 114)
        Me.txtPreDatadoPara.MaxLength = 20
        Me.txtPreDatadoPara.Name = "txtPreDatadoPara"
        Me.txtPreDatadoPara.ReadOnly = True
        Me.txtPreDatadoPara.Size = New System.Drawing.Size(99, 20)
        Me.txtPreDatadoPara.TabIndex = 11
        Me.txtPreDatadoPara.TabStop = False
        '
        'lblPreDatadoPara
        '
        Me.lblPreDatadoPara.AutoSize = True
        Me.lblPreDatadoPara.Location = New System.Drawing.Point(111, 97)
        Me.lblPreDatadoPara.Name = "lblPreDatadoPara"
        Me.lblPreDatadoPara.Size = New System.Drawing.Size(89, 14)
        Me.lblPreDatadoPara.TabIndex = 10
        Me.lblPreDatadoPara.Text = "Pré-Datado para:"
        '
        'txtDataPagamento
        '
        Me.txtDataPagamento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataPagamento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDataPagamento.Location = New System.Drawing.Point(9, 114)
        Me.txtDataPagamento.MaxLength = 20
        Me.txtDataPagamento.Name = "txtDataPagamento"
        Me.txtDataPagamento.ReadOnly = True
        Me.txtDataPagamento.Size = New System.Drawing.Size(99, 20)
        Me.txtDataPagamento.TabIndex = 9
        Me.txtDataPagamento.TabStop = False
        '
        'lblDataPagamento
        '
        Me.lblDataPagamento.AutoSize = True
        Me.lblDataPagamento.Location = New System.Drawing.Point(6, 97)
        Me.lblDataPagamento.Name = "lblDataPagamento"
        Me.lblDataPagamento.Size = New System.Drawing.Size(88, 14)
        Me.lblDataPagamento.TabIndex = 8
        Me.lblDataPagamento.Text = "Data Pagamento:"
        '
        'txtParceiroNegocio
        '
        Me.txtParceiroNegocio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtParceiroNegocio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtParceiroNegocio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtParceiroNegocio.Location = New System.Drawing.Point(114, 74)
        Me.txtParceiroNegocio.MaxLength = 20
        Me.txtParceiroNegocio.Name = "txtParceiroNegocio"
        Me.txtParceiroNegocio.ReadOnly = True
        Me.txtParceiroNegocio.Size = New System.Drawing.Size(313, 20)
        Me.txtParceiroNegocio.TabIndex = 7
        Me.txtParceiroNegocio.TabStop = False
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(9, 74)
        Me.txtNumeroDocumento.MaxLength = 20
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.ReadOnly = True
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(99, 20)
        Me.txtNumeroDocumento.TabIndex = 5
        Me.txtNumeroDocumento.TabStop = False
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(6, 57)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 4
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'lblParceiroNegocio
        '
        Me.lblParceiroNegocio.AutoSize = True
        Me.lblParceiroNegocio.Location = New System.Drawing.Point(111, 57)
        Me.lblParceiroNegocio.Name = "lblParceiroNegocio"
        Me.lblParceiroNegocio.Size = New System.Drawing.Size(107, 14)
        Me.lblParceiroNegocio.TabIndex = 6
        Me.lblParceiroNegocio.Text = "Parceiro de Negócio:"
        '
        'txtContaBancaria
        '
        Me.txtContaBancaria.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtContaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContaBancaria.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtContaBancaria.Location = New System.Drawing.Point(114, 34)
        Me.txtContaBancaria.MaxLength = 20
        Me.txtContaBancaria.Name = "txtContaBancaria"
        Me.txtContaBancaria.ReadOnly = True
        Me.txtContaBancaria.Size = New System.Drawing.Size(313, 20)
        Me.txtContaBancaria.TabIndex = 3
        Me.txtContaBancaria.TabStop = False
        '
        'lblContaBancaria
        '
        Me.lblContaBancaria.AutoSize = True
        Me.lblContaBancaria.Location = New System.Drawing.Point(111, 17)
        Me.lblContaBancaria.Name = "lblContaBancaria"
        Me.lblContaBancaria.Size = New System.Drawing.Size(84, 14)
        Me.lblContaBancaria.TabIndex = 2
        Me.lblContaBancaria.Text = "Conta Bancária:"
        '
        'txtNumerCheque
        '
        Me.txtNumerCheque.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumerCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumerCheque.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNumerCheque.Location = New System.Drawing.Point(9, 34)
        Me.txtNumerCheque.MaxLength = 20
        Me.txtNumerCheque.Name = "txtNumerCheque"
        Me.txtNumerCheque.ReadOnly = True
        Me.txtNumerCheque.Size = New System.Drawing.Size(99, 20)
        Me.txtNumerCheque.TabIndex = 1
        Me.txtNumerCheque.TabStop = False
        '
        'numero_cheque
        '
        Me.numero_cheque.AutoSize = True
        Me.numero_cheque.Location = New System.Drawing.Point(6, 17)
        Me.numero_cheque.Name = "numero_cheque"
        Me.numero_cheque.Size = New System.Drawing.Size(62, 14)
        Me.numero_cheque.TabIndex = 0
        Me.numero_cheque.Text = "Nº Cheque:"
        '
        'grpControl2
        '
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnCompensar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 150)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(436, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnCompensar
        '
        Me.btnCompensar.Image = Global.INTERACTI.My.Resources.aprovar
        Me.btnCompensar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCompensar.Location = New System.Drawing.Point(178, 17)
        Me.btnCompensar.Name = "btnCompensar"
        Me.btnCompensar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCompensar.Size = New System.Drawing.Size(150, 23)
        Me.btnCompensar.TabIndex = 0
        Me.btnCompensar.Text = "Compensar Cheque"
        Me.btnCompensar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'frmFinChequeCompensar
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
        Me.Name = "frmFinChequeCompensar"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Financeiro - Compensar Cheque"
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
    Friend WithEvents btnCompensar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtParceiroNegocio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents lblParceiroNegocio As System.Windows.Forms.Label
    Friend WithEvents lblDataCompensacao As System.Windows.Forms.Label
    Friend WithEvents txtPreDatadoPara As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPreDatadoPara As System.Windows.Forms.Label
    Friend WithEvents txtDataPagamento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataPagamento As System.Windows.Forms.Label
    Friend WithEvents txtContaBancaria As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblContaBancaria As System.Windows.Forms.Label
    Friend WithEvents txtNumerCheque As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents numero_cheque As System.Windows.Forms.Label
    Friend WithEvents dtpDataCompensacao As Janus.Windows.CalendarCombo.CalendarCombo
End Class
