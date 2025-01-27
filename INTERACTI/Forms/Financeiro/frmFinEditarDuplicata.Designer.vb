<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinEditarDuplicata
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinEditarDuplicata))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagParcela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpPagamento = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataVencimento = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtValorDocumentoCorrigido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorDocumentoCorrigido = New System.Windows.Forms.Label()
        Me.txtSerieDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSerieDocumento = New System.Windows.Forms.Label()
        Me.txtValorParcela = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorParcela = New System.Windows.Forms.Label()
        Me.txtValorDocumento = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorDocumento = New System.Windows.Forms.Label()
        Me.lblDataVencimentoParcela = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagParcela.SuspendLayout()
        CType(Me.grpPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPagamento.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
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
        Me.tabMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(382, 192)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagParcela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagParcela
        '
        Me.pagParcela.Controls.Add(Me.grpPagamento)
        Me.pagParcela.Controls.Add(Me.UiGroupBox2)
        Me.pagParcela.Key = "pagTabela"
        Me.pagParcela.Location = New System.Drawing.Point(1, 22)
        Me.pagParcela.Name = "pagParcela"
        Me.pagParcela.Size = New System.Drawing.Size(380, 169)
        Me.pagParcela.TabStop = True
        Me.pagParcela.Text = "Dados da Duplicata"
        '
        'grpPagamento
        '
        Me.grpPagamento.BackColor = System.Drawing.Color.Transparent
        Me.grpPagamento.Controls.Add(Me.dtpDataVencimento)
        Me.grpPagamento.Controls.Add(Me.txtValorDocumentoCorrigido)
        Me.grpPagamento.Controls.Add(Me.lblValorDocumentoCorrigido)
        Me.grpPagamento.Controls.Add(Me.txtSerieDocumento)
        Me.grpPagamento.Controls.Add(Me.lblSerieDocumento)
        Me.grpPagamento.Controls.Add(Me.txtValorParcela)
        Me.grpPagamento.Controls.Add(Me.lblValorParcela)
        Me.grpPagamento.Controls.Add(Me.txtValorDocumento)
        Me.grpPagamento.Controls.Add(Me.lblValorDocumento)
        Me.grpPagamento.Controls.Add(Me.lblDataVencimentoParcela)
        Me.grpPagamento.Controls.Add(Me.txtNumeroDocumento)
        Me.grpPagamento.Controls.Add(Me.lblNumeroDocumento)
        Me.grpPagamento.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpPagamento.Location = New System.Drawing.Point(8, 3)
        Me.grpPagamento.Name = "grpPagamento"
        Me.grpPagamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpPagamento.Size = New System.Drawing.Size(364, 104)
        Me.grpPagamento.TabIndex = 0
        Me.grpPagamento.VisualStyleManager = Me.vsmMain
        '
        'dtpDataVencimento
        '
        '
        '
        '
        Me.dtpDataVencimento.DropDownCalendar.Name = ""
        Me.dtpDataVencimento.Location = New System.Drawing.Point(9, 74)
        Me.dtpDataVencimento.Name = "dtpDataVencimento"
        Me.dtpDataVencimento.Size = New System.Drawing.Size(126, 20)
        Me.dtpDataVencimento.TabIndex = 7
        '
        'txtValorDocumentoCorrigido
        '
        Me.txtValorDocumentoCorrigido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorDocumentoCorrigido.Location = New System.Drawing.Point(242, 74)
        Me.txtValorDocumentoCorrigido.Name = "txtValorDocumentoCorrigido"
        Me.txtValorDocumentoCorrigido.ReadOnly = True
        Me.txtValorDocumentoCorrigido.Size = New System.Drawing.Size(113, 20)
        Me.txtValorDocumentoCorrigido.TabIndex = 11
        Me.txtValorDocumentoCorrigido.TabStop = False
        Me.txtValorDocumentoCorrigido.Text = "0,00"
        Me.txtValorDocumentoCorrigido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorDocumentoCorrigido
        '
        Me.lblValorDocumentoCorrigido.AutoSize = True
        Me.lblValorDocumentoCorrigido.Location = New System.Drawing.Point(239, 57)
        Me.lblValorDocumentoCorrigido.Name = "lblValorDocumentoCorrigido"
        Me.lblValorDocumentoCorrigido.Size = New System.Drawing.Size(106, 14)
        Me.lblValorDocumentoCorrigido.TabIndex = 10
        Me.lblValorDocumentoCorrigido.Text = "Valor Doc. Corrigido:"
        '
        'txtSerieDocumento
        '
        Me.txtSerieDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSerieDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieDocumento.Location = New System.Drawing.Point(141, 34)
        Me.txtSerieDocumento.MaxLength = 20
        Me.txtSerieDocumento.Name = "txtSerieDocumento"
        Me.txtSerieDocumento.ReadOnly = True
        Me.txtSerieDocumento.Size = New System.Drawing.Size(95, 20)
        Me.txtSerieDocumento.TabIndex = 3
        Me.txtSerieDocumento.TabStop = False
        '
        'lblSerieDocumento
        '
        Me.lblSerieDocumento.AutoSize = True
        Me.lblSerieDocumento.Location = New System.Drawing.Point(138, 17)
        Me.lblSerieDocumento.Name = "lblSerieDocumento"
        Me.lblSerieDocumento.Size = New System.Drawing.Size(35, 14)
        Me.lblSerieDocumento.TabIndex = 2
        Me.lblSerieDocumento.Text = "Série:"
        '
        'txtValorParcela
        '
        Me.txtValorParcela.Location = New System.Drawing.Point(141, 74)
        Me.txtValorParcela.Name = "txtValorParcela"
        Me.txtValorParcela.Size = New System.Drawing.Size(95, 20)
        Me.txtValorParcela.TabIndex = 9
        Me.txtValorParcela.Text = "0,00"
        Me.txtValorParcela.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorParcela
        '
        Me.lblValorParcela.AutoSize = True
        Me.lblValorParcela.Location = New System.Drawing.Point(138, 57)
        Me.lblValorParcela.Name = "lblValorParcela"
        Me.lblValorParcela.Size = New System.Drawing.Size(74, 14)
        Me.lblValorParcela.TabIndex = 8
        Me.lblValorParcela.Text = "Valor Parcela:"
        '
        'txtValorDocumento
        '
        Me.txtValorDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorDocumento.Location = New System.Drawing.Point(242, 34)
        Me.txtValorDocumento.Name = "txtValorDocumento"
        Me.txtValorDocumento.ReadOnly = True
        Me.txtValorDocumento.Size = New System.Drawing.Size(113, 20)
        Me.txtValorDocumento.TabIndex = 5
        Me.txtValorDocumento.TabStop = False
        Me.txtValorDocumento.Text = "0,00"
        Me.txtValorDocumento.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorDocumento
        '
        Me.lblValorDocumento.AutoSize = True
        Me.lblValorDocumento.Location = New System.Drawing.Point(239, 17)
        Me.lblValorDocumento.Name = "lblValorDocumento"
        Me.lblValorDocumento.Size = New System.Drawing.Size(92, 14)
        Me.lblValorDocumento.TabIndex = 4
        Me.lblValorDocumento.Text = "Valor Documento:"
        '
        'lblDataVencimentoParcela
        '
        Me.lblDataVencimentoParcela.AutoSize = True
        Me.lblDataVencimentoParcela.Location = New System.Drawing.Point(6, 57)
        Me.lblDataVencimentoParcela.Name = "lblDataVencimentoParcela"
        Me.lblDataVencimentoParcela.Size = New System.Drawing.Size(91, 14)
        Me.lblDataVencimentoParcela.TabIndex = 6
        Me.lblDataVencimentoParcela.Text = "Data Vencimento:"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumento.MaxLength = 20
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.ReadOnly = True
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(126, 20)
        Me.txtNumeroDocumento.TabIndex = 1
        Me.txtNumeroDocumento.TabStop = False
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(104, 14)
        Me.lblNumeroDocumento.TabIndex = 0
        Me.lblNumeroDocumento.Text = "Número Documento:"
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.btnSair)
        Me.UiGroupBox2.Controls.Add(Me.btnSalvar)
        Me.UiGroupBox2.Location = New System.Drawing.Point(8, 110)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.Size = New System.Drawing.Size(364, 51)
        Me.UiGroupBox2.TabIndex = 1
        Me.UiGroupBox2.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(264, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(167, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmFinEditarDuplicata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(396, 207)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinEditarDuplicata"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Financeiro - Editar Duplicata"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagParcela.ResumeLayout(False)
        CType(Me.grpPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPagamento.ResumeLayout(False)
        Me.grpPagamento.PerformLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagParcela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpPagamento As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataVencimento As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtValorDocumentoCorrigido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorDocumentoCorrigido As System.Windows.Forms.Label
    Friend WithEvents txtSerieDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSerieDocumento As System.Windows.Forms.Label
    Friend WithEvents txtValorParcela As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorParcela As System.Windows.Forms.Label
    Friend WithEvents txtValorDocumento As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorDocumento As System.Windows.Forms.Label
    Friend WithEvents lblDataVencimentoParcela As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
End Class
