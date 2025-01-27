<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinReceitaCobrancaComentario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinReceitaCobrancaComentario))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorCorrigido = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblValorCorrigido = New System.Windows.Forms.Label()
        Me.txtValor = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtDataVencimento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataVencimento = New System.Windows.Forms.Label()
        Me.txtParcela = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblParcela = New System.Windows.Forms.Label()
        Me.txtCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblHistorico = New System.Windows.Forms.Label()
        Me.txtHistorico = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
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
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(629, 406)
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
        Me.pagTabela.Size = New System.Drawing.Size(627, 383)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Cobrança"
        '
        'grpInformacoes
        '
        Me.grpInformacoes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.txtValorCorrigido)
        Me.grpInformacoes.Controls.Add(Me.lblValorCorrigido)
        Me.grpInformacoes.Controls.Add(Me.txtValor)
        Me.grpInformacoes.Controls.Add(Me.lblValor)
        Me.grpInformacoes.Controls.Add(Me.txtDataVencimento)
        Me.grpInformacoes.Controls.Add(Me.lblDataVencimento)
        Me.grpInformacoes.Controls.Add(Me.txtParcela)
        Me.grpInformacoes.Controls.Add(Me.lblParcela)
        Me.grpInformacoes.Controls.Add(Me.txtCliente)
        Me.grpInformacoes.Controls.Add(Me.lblHistorico)
        Me.grpInformacoes.Controls.Add(Me.txtHistorico)
        Me.grpInformacoes.Controls.Add(Me.txtNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.lblNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.lblCliente)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(611, 318)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'txtValorCorrigido
        '
        Me.txtValorCorrigido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorCorrigido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorCorrigido.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtValorCorrigido.Location = New System.Drawing.Point(326, 74)
        Me.txtValorCorrigido.MaxLength = 20
        Me.txtValorCorrigido.Name = "txtValorCorrigido"
        Me.txtValorCorrigido.ReadOnly = True
        Me.txtValorCorrigido.Size = New System.Drawing.Size(99, 20)
        Me.txtValorCorrigido.TabIndex = 13
        Me.txtValorCorrigido.TabStop = False
        '
        'lblValorCorrigido
        '
        Me.lblValorCorrigido.AutoSize = True
        Me.lblValorCorrigido.Location = New System.Drawing.Point(323, 57)
        Me.lblValorCorrigido.Name = "lblValorCorrigido"
        Me.lblValorCorrigido.Size = New System.Drawing.Size(81, 14)
        Me.lblValorCorrigido.TabIndex = 12
        Me.lblValorCorrigido.Text = "Valor Corrigido:"
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtValor.Location = New System.Drawing.Point(221, 74)
        Me.txtValor.MaxLength = 20
        Me.txtValor.Name = "txtValor"
        Me.txtValor.ReadOnly = True
        Me.txtValor.Size = New System.Drawing.Size(99, 20)
        Me.txtValor.TabIndex = 11
        Me.txtValor.TabStop = False
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(218, 57)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(35, 14)
        Me.lblValor.TabIndex = 10
        Me.lblValor.Text = "Valor:"
        '
        'txtDataVencimento
        '
        Me.txtDataVencimento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataVencimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataVencimento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDataVencimento.Location = New System.Drawing.Point(114, 74)
        Me.txtDataVencimento.MaxLength = 20
        Me.txtDataVencimento.Name = "txtDataVencimento"
        Me.txtDataVencimento.ReadOnly = True
        Me.txtDataVencimento.Size = New System.Drawing.Size(101, 20)
        Me.txtDataVencimento.TabIndex = 9
        Me.txtDataVencimento.TabStop = False
        '
        'lblDataVencimento
        '
        Me.lblDataVencimento.AutoSize = True
        Me.lblDataVencimento.Location = New System.Drawing.Point(113, 57)
        Me.lblDataVencimento.Name = "lblDataVencimento"
        Me.lblDataVencimento.Size = New System.Drawing.Size(91, 14)
        Me.lblDataVencimento.TabIndex = 8
        Me.lblDataVencimento.Text = "Data Vencimento:"
        '
        'txtParcela
        '
        Me.txtParcela.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtParcela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtParcela.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtParcela.Location = New System.Drawing.Point(9, 74)
        Me.txtParcela.MaxLength = 20
        Me.txtParcela.Name = "txtParcela"
        Me.txtParcela.ReadOnly = True
        Me.txtParcela.Size = New System.Drawing.Size(99, 20)
        Me.txtParcela.TabIndex = 7
        Me.txtParcela.TabStop = False
        '
        'lblParcela
        '
        Me.lblParcela.AutoSize = True
        Me.lblParcela.Location = New System.Drawing.Point(8, 57)
        Me.lblParcela.Name = "lblParcela"
        Me.lblParcela.Size = New System.Drawing.Size(46, 14)
        Me.lblParcela.TabIndex = 6
        Me.lblParcela.Text = "Parcela:"
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCliente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCliente.Location = New System.Drawing.Point(114, 34)
        Me.txtCliente.MaxLength = 20
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(488, 20)
        Me.txtCliente.TabIndex = 5
        Me.txtCliente.TabStop = False
        '
        'lblHistorico
        '
        Me.lblHistorico.AutoSize = True
        Me.lblHistorico.BackColor = System.Drawing.Color.Transparent
        Me.lblHistorico.Location = New System.Drawing.Point(6, 97)
        Me.lblHistorico.Name = "lblHistorico"
        Me.lblHistorico.Size = New System.Drawing.Size(52, 14)
        Me.lblHistorico.TabIndex = 4
        Me.lblHistorico.Text = "Histórico:"
        '
        'txtHistorico
        '
        Me.txtHistorico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHistorico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHistorico.Location = New System.Drawing.Point(9, 114)
        Me.txtHistorico.MaxLength = 500
        Me.txtHistorico.Multiline = True
        Me.txtHistorico.Name = "txtHistorico"
        Me.txtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHistorico.Size = New System.Drawing.Size(593, 194)
        Me.txtHistorico.TabIndex = 0
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumento.MaxLength = 20
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.ReadOnly = True
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(99, 20)
        Me.txtNumeroDocumento.TabIndex = 1
        Me.txtNumeroDocumento.TabStop = False
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 0
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(111, 17)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 2
        Me.lblCliente.Text = "Cliente:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 324)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(611, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(414, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(511, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmFinReceitaCobrancaComentario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 422)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinReceitaCobrancaComentario"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cobrança - Comentário"
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
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblHistorico As System.Windows.Forms.Label
    Friend WithEvents txtHistorico As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents txtCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtValorCorrigido As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblValorCorrigido As System.Windows.Forms.Label
    Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents txtDataVencimento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataVencimento As System.Windows.Forms.Label
    Friend WithEvents txtParcela As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblParcela As System.Windows.Forms.Label
End Class
