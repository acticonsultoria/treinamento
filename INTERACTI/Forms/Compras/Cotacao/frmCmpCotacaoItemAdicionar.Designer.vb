<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCmpCotacaoItemAdicionar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCmpCotacaoItemAdicionar))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpRequisicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtUnidadeMedida = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblUnidadeMedida = New System.Windows.Forms.Label()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtItem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.txtDataNecessidade = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataNecessidade = New System.Windows.Forms.Label()
        Me.txtNumeroRequisicao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroRequisicao = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtUsuarioCotacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblUsuarioCotacao = New System.Windows.Forms.Label()
        Me.cboNumeroCotacao = New Janus.Windows.EditControls.UIComboBox()
        Me.txtDataCotacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataCotacao = New System.Windows.Forms.Label()
        Me.lblNumeroCotacao = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpRequisicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRequisicao.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(657, 260)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpRequisicao)
        Me.pagTabela.Controls.Add(Me.grpControle)
        Me.pagTabela.Controls.Add(Me.grpDados)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(655, 237)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Dados do Item da Cotação"
        '
        'grpRequisicao
        '
        Me.grpRequisicao.BackColor = System.Drawing.Color.Transparent
        Me.grpRequisicao.Controls.Add(Me.txtQuantidade)
        Me.grpRequisicao.Controls.Add(Me.txtUnidadeMedida)
        Me.grpRequisicao.Controls.Add(Me.lblUnidadeMedida)
        Me.grpRequisicao.Controls.Add(Me.lblQuantidade)
        Me.grpRequisicao.Controls.Add(Me.txtItem)
        Me.grpRequisicao.Controls.Add(Me.lblItem)
        Me.grpRequisicao.Controls.Add(Me.txtDataNecessidade)
        Me.grpRequisicao.Controls.Add(Me.lblDataNecessidade)
        Me.grpRequisicao.Controls.Add(Me.txtNumeroRequisicao)
        Me.grpRequisicao.Controls.Add(Me.lblNumeroRequisicao)
        Me.grpRequisicao.Location = New System.Drawing.Point(8, 70)
        Me.grpRequisicao.Name = "grpRequisicao"
        Me.grpRequisicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpRequisicao.Size = New System.Drawing.Size(639, 104)
        Me.grpRequisicao.TabIndex = 1
        Me.grpRequisicao.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpRequisicao.VisualStyleManager = Me.vsmMain
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(251, 34)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.ReadOnly = True
        Me.txtQuantidade.Size = New System.Drawing.Size(115, 20)
        Me.txtQuantidade.TabIndex = 5
        Me.txtQuantidade.TabStop = False
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'txtUnidadeMedida
        '
        Me.txtUnidadeMedida.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidadeMedida.Location = New System.Drawing.Point(372, 34)
        Me.txtUnidadeMedida.MaxLength = 50
        Me.txtUnidadeMedida.Name = "txtUnidadeMedida"
        Me.txtUnidadeMedida.ReadOnly = True
        Me.txtUnidadeMedida.Size = New System.Drawing.Size(115, 20)
        Me.txtUnidadeMedida.TabIndex = 7
        Me.txtUnidadeMedida.TabStop = False
        '
        'lblUnidadeMedida
        '
        Me.lblUnidadeMedida.AutoSize = True
        Me.lblUnidadeMedida.Location = New System.Drawing.Point(369, 17)
        Me.lblUnidadeMedida.Name = "lblUnidadeMedida"
        Me.lblUnidadeMedida.Size = New System.Drawing.Size(101, 14)
        Me.lblUnidadeMedida.TabIndex = 6
        Me.lblUnidadeMedida.Text = "Unidade de Medida:"
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(248, 17)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 4
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtItem
        '
        Me.txtItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItem.Location = New System.Drawing.Point(10, 74)
        Me.txtItem.MaxLength = 50
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(620, 20)
        Me.txtItem.TabIndex = 9
        Me.txtItem.TabStop = False
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(7, 57)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(29, 14)
        Me.lblItem.TabIndex = 8
        Me.lblItem.Text = "Item:"
        '
        'txtDataNecessidade
        '
        Me.txtDataNecessidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataNecessidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataNecessidade.Location = New System.Drawing.Point(130, 34)
        Me.txtDataNecessidade.MaxLength = 50
        Me.txtDataNecessidade.Name = "txtDataNecessidade"
        Me.txtDataNecessidade.ReadOnly = True
        Me.txtDataNecessidade.Size = New System.Drawing.Size(115, 20)
        Me.txtDataNecessidade.TabIndex = 3
        Me.txtDataNecessidade.TabStop = False
        '
        'lblDataNecessidade
        '
        Me.lblDataNecessidade.AutoSize = True
        Me.lblDataNecessidade.Location = New System.Drawing.Point(127, 17)
        Me.lblDataNecessidade.Name = "lblDataNecessidade"
        Me.lblDataNecessidade.Size = New System.Drawing.Size(98, 14)
        Me.lblDataNecessidade.TabIndex = 2
        Me.lblDataNecessidade.Text = "Data Necessidade:"
        '
        'txtNumeroRequisicao
        '
        Me.txtNumeroRequisicao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroRequisicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroRequisicao.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroRequisicao.MaxLength = 20
        Me.txtNumeroRequisicao.Name = "txtNumeroRequisicao"
        Me.txtNumeroRequisicao.ReadOnly = True
        Me.txtNumeroRequisicao.Size = New System.Drawing.Size(115, 20)
        Me.txtNumeroRequisicao.TabIndex = 1
        Me.txtNumeroRequisicao.TabStop = False
        '
        'lblNumeroRequisicao
        '
        Me.lblNumeroRequisicao.AutoSize = True
        Me.lblNumeroRequisicao.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroRequisicao.Name = "lblNumeroRequisicao"
        Me.lblNumeroRequisicao.Size = New System.Drawing.Size(78, 14)
        Me.lblNumeroRequisicao.TabIndex = 0
        Me.lblNumeroRequisicao.Text = "Nº Requisição:"
        '
        'grpControle
        '
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnSalvar)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 177)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(639, 51)
        Me.grpControle.TabIndex = 2
        Me.grpControle.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(333, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(200, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Adicionar Item a Cotação"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(539, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtUsuarioCotacao)
        Me.grpDados.Controls.Add(Me.lblUsuarioCotacao)
        Me.grpDados.Controls.Add(Me.cboNumeroCotacao)
        Me.grpDados.Controls.Add(Me.txtDataCotacao)
        Me.grpDados.Controls.Add(Me.lblDataCotacao)
        Me.grpDados.Controls.Add(Me.lblNumeroCotacao)
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(639, 64)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtUsuarioCotacao
        '
        Me.txtUsuarioCotacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUsuarioCotacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuarioCotacao.Location = New System.Drawing.Point(251, 34)
        Me.txtUsuarioCotacao.MaxLength = 50
        Me.txtUsuarioCotacao.Name = "txtUsuarioCotacao"
        Me.txtUsuarioCotacao.ReadOnly = True
        Me.txtUsuarioCotacao.Size = New System.Drawing.Size(379, 20)
        Me.txtUsuarioCotacao.TabIndex = 5
        Me.txtUsuarioCotacao.TabStop = False
        '
        'lblUsuarioCotacao
        '
        Me.lblUsuarioCotacao.AutoSize = True
        Me.lblUsuarioCotacao.Location = New System.Drawing.Point(248, 17)
        Me.lblUsuarioCotacao.Name = "lblUsuarioCotacao"
        Me.lblUsuarioCotacao.Size = New System.Drawing.Size(105, 14)
        Me.lblUsuarioCotacao.TabIndex = 4
        Me.lblUsuarioCotacao.Text = "Usuário da Cotação:"
        '
        'cboNumeroCotacao
        '
        Me.cboNumeroCotacao.AutoSize = False
        Me.cboNumeroCotacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNumeroCotacao.Location = New System.Drawing.Point(9, 34)
        Me.cboNumeroCotacao.Name = "cboNumeroCotacao"
        Me.cboNumeroCotacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNumeroCotacao.Size = New System.Drawing.Size(115, 20)
        Me.cboNumeroCotacao.TabIndex = 1
        '
        'txtDataCotacao
        '
        Me.txtDataCotacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataCotacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataCotacao.Location = New System.Drawing.Point(130, 34)
        Me.txtDataCotacao.MaxLength = 50
        Me.txtDataCotacao.Name = "txtDataCotacao"
        Me.txtDataCotacao.ReadOnly = True
        Me.txtDataCotacao.Size = New System.Drawing.Size(115, 20)
        Me.txtDataCotacao.TabIndex = 3
        Me.txtDataCotacao.TabStop = False
        '
        'lblDataCotacao
        '
        Me.lblDataCotacao.AutoSize = True
        Me.lblDataCotacao.Location = New System.Drawing.Point(127, 17)
        Me.lblDataCotacao.Name = "lblDataCotacao"
        Me.lblDataCotacao.Size = New System.Drawing.Size(90, 14)
        Me.lblDataCotacao.TabIndex = 2
        Me.lblDataCotacao.Text = "Data da Cotação:"
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
        'frmCmpCotacaoItemAdicionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 275)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCmpCotacaoItemAdicionar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cotação - Adicionar Item"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpRequisicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRequisicao.ResumeLayout(False)
        Me.grpRequisicao.PerformLayout()
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
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDataCotacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataCotacao As System.Windows.Forms.Label
    Friend WithEvents lblNumeroCotacao As System.Windows.Forms.Label
    Friend WithEvents grpRequisicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtUnidadeMedida As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblUnidadeMedida As System.Windows.Forms.Label
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtItem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents txtDataNecessidade As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataNecessidade As System.Windows.Forms.Label
    Friend WithEvents txtNumeroRequisicao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroRequisicao As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioCotacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblUsuarioCotacao As System.Windows.Forms.Label
    Friend WithEvents cboNumeroCotacao As Janus.Windows.EditControls.UIComboBox
End Class
