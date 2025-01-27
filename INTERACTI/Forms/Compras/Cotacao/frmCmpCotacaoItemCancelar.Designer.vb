<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCmpCotacaoItemCancelar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCmpCotacaoItemCancelar))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.txtDataNecessidade = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataNecessidade = New System.Windows.Forms.Label()
        Me.txtDataCotacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataCotacao = New System.Windows.Forms.Label()
        Me.txtNumeroCotacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroRequisicao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRequisicao = New System.Windows.Forms.Label()
        Me.lblJustificativa = New System.Windows.Forms.Label()
        Me.txtJustificativa = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblNumeroCotacao = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(705, 407)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpControle)
        Me.pagTabela.Controls.Add(Me.grpDados)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(703, 384)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Dados do Item da Cotação"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnCancelar)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 324)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(687, 51)
        Me.grpControle.TabIndex = 1
        Me.grpControle.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.INTERACTI.My.Resources.cancelar
        Me.btnCancelar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCancelar.Location = New System.Drawing.Point(382, 17)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(200, 23)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar Item da Cotação"
        Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(588, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(90, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtItem)
        Me.grpDados.Controls.Add(Me.lblItem)
        Me.grpDados.Controls.Add(Me.txtDataNecessidade)
        Me.grpDados.Controls.Add(Me.lblDataNecessidade)
        Me.grpDados.Controls.Add(Me.txtDataCotacao)
        Me.grpDados.Controls.Add(Me.lblDataCotacao)
        Me.grpDados.Controls.Add(Me.txtNumeroCotacao)
        Me.grpDados.Controls.Add(Me.txtNumeroRequisicao)
        Me.grpDados.Controls.Add(Me.lblNumeroRequisicao)
        Me.grpDados.Controls.Add(Me.lblJustificativa)
        Me.grpDados.Controls.Add(Me.txtJustificativa)
        Me.grpDados.Controls.Add(Me.lblNumeroCotacao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(687, 318)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtItem
        '
        Me.txtItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItem.Location = New System.Drawing.Point(9, 74)
        Me.txtItem.MaxLength = 50
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(669, 20)
        Me.txtItem.TabIndex = 9
        Me.txtItem.TabStop = False
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(6, 57)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(29, 14)
        Me.lblItem.TabIndex = 8
        Me.lblItem.Text = "Item:"
        '
        'txtDataNecessidade
        '
        Me.txtDataNecessidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataNecessidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataNecessidade.Location = New System.Drawing.Point(327, 34)
        Me.txtDataNecessidade.MaxLength = 50
        Me.txtDataNecessidade.Name = "txtDataNecessidade"
        Me.txtDataNecessidade.ReadOnly = True
        Me.txtDataNecessidade.Size = New System.Drawing.Size(100, 20)
        Me.txtDataNecessidade.TabIndex = 7
        Me.txtDataNecessidade.TabStop = False
        '
        'lblDataNecessidade
        '
        Me.lblDataNecessidade.AutoSize = True
        Me.lblDataNecessidade.Location = New System.Drawing.Point(324, 17)
        Me.lblDataNecessidade.Name = "lblDataNecessidade"
        Me.lblDataNecessidade.Size = New System.Drawing.Size(98, 14)
        Me.lblDataNecessidade.TabIndex = 6
        Me.lblDataNecessidade.Text = "Data Necessidade:"
        '
        'txtDataCotacao
        '
        Me.txtDataCotacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataCotacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataCotacao.Location = New System.Drawing.Point(221, 34)
        Me.txtDataCotacao.MaxLength = 50
        Me.txtDataCotacao.Name = "txtDataCotacao"
        Me.txtDataCotacao.ReadOnly = True
        Me.txtDataCotacao.Size = New System.Drawing.Size(100, 20)
        Me.txtDataCotacao.TabIndex = 5
        Me.txtDataCotacao.TabStop = False
        '
        'lblDataCotacao
        '
        Me.lblDataCotacao.AutoSize = True
        Me.lblDataCotacao.Location = New System.Drawing.Point(218, 17)
        Me.lblDataCotacao.Name = "lblDataCotacao"
        Me.lblDataCotacao.Size = New System.Drawing.Size(90, 14)
        Me.lblDataCotacao.TabIndex = 4
        Me.lblDataCotacao.Text = "Data da Cotação:"
        '
        'txtNumeroCotacao
        '
        Me.txtNumeroCotacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroCotacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroCotacao.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroCotacao.MaxLength = 50
        Me.txtNumeroCotacao.Name = "txtNumeroCotacao"
        Me.txtNumeroCotacao.ReadOnly = True
        Me.txtNumeroCotacao.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroCotacao.TabIndex = 1
        Me.txtNumeroCotacao.TabStop = False
        '
        'txtNumeroRequisicao
        '
        Me.txtNumeroRequisicao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroRequisicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRequisicao.Location = New System.Drawing.Point(115, 34)
        Me.txtNumeroRequisicao.MaxLength = 20
        Me.txtNumeroRequisicao.Name = "txtNumeroRequisicao"
        Me.txtNumeroRequisicao.ReadOnly = True
        Me.txtNumeroRequisicao.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroRequisicao.TabIndex = 3
        Me.txtNumeroRequisicao.TabStop = False
        '
        'lblNumeroRequisicao
        '
        Me.lblNumeroRequisicao.AutoSize = True
        Me.lblNumeroRequisicao.Location = New System.Drawing.Point(112, 17)
        Me.lblNumeroRequisicao.Name = "lblNumeroRequisicao"
        Me.lblNumeroRequisicao.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroRequisicao.TabIndex = 2
        Me.lblNumeroRequisicao.Text = "Nº Requisição:"
        '
        'lblJustificativa
        '
        Me.lblJustificativa.AutoSize = True
        Me.lblJustificativa.Location = New System.Drawing.Point(6, 97)
        Me.lblJustificativa.Name = "lblJustificativa"
        Me.lblJustificativa.Size = New System.Drawing.Size(67, 14)
        Me.lblJustificativa.TabIndex = 10
        Me.lblJustificativa.Text = "Justificativa:"
        '
        'txtJustificativa
        '
        Me.txtJustificativa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJustificativa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJustificativa.Location = New System.Drawing.Point(9, 114)
        Me.txtJustificativa.MaxLength = 500
        Me.txtJustificativa.Multiline = True
        Me.txtJustificativa.Name = "txtJustificativa"
        Me.txtJustificativa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJustificativa.Size = New System.Drawing.Size(669, 193)
        Me.txtJustificativa.TabIndex = 11
        '
        'lblNumeroCotacao
        '
        Me.lblNumeroCotacao.AutoSize = True
        Me.lblNumeroCotacao.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroCotacao.Name = "lblNumeroCotacao"
        Me.lblNumeroCotacao.Size = New System.Drawing.Size(65, 14)
        Me.lblNumeroCotacao.TabIndex = 0
        Me.lblNumeroCotacao.Text = "Nº Cotação:"
        '
        'frmCmpCotacaoItemCancelar
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
        Me.Name = "frmCmpCotacaoItemCancelar"
        Me.Text = "Justificativa - Cancelar Item da Cotação"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblJustificativa As System.Windows.Forms.Label
    Friend WithEvents txtJustificativa As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents txtDataNecessidade As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataNecessidade As System.Windows.Forms.Label
    Friend WithEvents txtDataCotacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataCotacao As System.Windows.Forms.Label
    Friend WithEvents txtNumeroCotacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroRequisicao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroRequisicao As System.Windows.Forms.Label
    Friend WithEvents lblNumeroCotacao As System.Windows.Forms.Label
End Class
