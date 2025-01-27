<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrdOrdemProducaoReativar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrdOrdemProducaoReativar))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblJustificativa = New System.Windows.Forms.Label()
        Me.txtJustificativa = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtQuantidadeProduzida = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtQuantidadeRejeito = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtQuantidadePlanejada = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeRejeito = New System.Windows.Forms.Label()
        Me.lblQuantidadeProduzida = New System.Windows.Forms.Label()
        Me.lblQuantidadePlanejada = New System.Windows.Forms.Label()
        Me.txtDataTermino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDataInicio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCodigoProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataTermino = New System.Windows.Forms.Label()
        Me.lblCodigoProduto = New System.Windows.Forms.Label()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.txtOrdemFabricacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducao = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
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
        Me.pagTabela.Text = "Justificativa"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblJustificativa)
        Me.grpDados.Controls.Add(Me.txtJustificativa)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Controls.Add(Me.txtQuantidadeProduzida)
        Me.grpDados.Controls.Add(Me.txtQuantidadeRejeito)
        Me.grpDados.Controls.Add(Me.txtQuantidadePlanejada)
        Me.grpDados.Controls.Add(Me.lblQuantidadeRejeito)
        Me.grpDados.Controls.Add(Me.lblQuantidadeProduzida)
        Me.grpDados.Controls.Add(Me.lblQuantidadePlanejada)
        Me.grpDados.Controls.Add(Me.txtDataTermino)
        Me.grpDados.Controls.Add(Me.txtDataInicio)
        Me.grpDados.Controls.Add(Me.txtCodigoProduto)
        Me.grpDados.Controls.Add(Me.lblDataTermino)
        Me.grpDados.Controls.Add(Me.lblCodigoProduto)
        Me.grpDados.Controls.Add(Me.lblDataInicio)
        Me.grpDados.Controls.Add(Me.txtOrdemFabricacao)
        Me.grpDados.Controls.Add(Me.lblOrdemProducao)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(687, 318)
        Me.grpDados.TabIndex = 0
        Me.grpDados.Text = "Dados da Ordem de Produção"
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblJustificativa
        '
        Me.lblJustificativa.AutoSize = True
        Me.lblJustificativa.Location = New System.Drawing.Point(6, 99)
        Me.lblJustificativa.Name = "lblJustificativa"
        Me.lblJustificativa.Size = New System.Drawing.Size(67, 14)
        Me.lblJustificativa.TabIndex = 16
        Me.lblJustificativa.Text = "Justificativa:"
        '
        'txtJustificativa
        '
        Me.txtJustificativa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJustificativa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJustificativa.Location = New System.Drawing.Point(9, 116)
        Me.txtJustificativa.MaxLength = 5000
        Me.txtJustificativa.Multiline = True
        Me.txtJustificativa.Name = "txtJustificativa"
        Me.txtJustificativa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJustificativa.Size = New System.Drawing.Size(669, 191)
        Me.txtJustificativa.TabIndex = 0
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(301, 36)
        Me.txtDescricao.MaxLength = 60
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(377, 20)
        Me.txtDescricao.TabIndex = 5
        Me.txtDescricao.TabStop = False
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(298, 19)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 4
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtQuantidadeProduzida
        '
        Me.txtQuantidadeProduzida.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeProduzida.Location = New System.Drawing.Point(473, 76)
        Me.txtQuantidadeProduzida.Name = "txtQuantidadeProduzida"
        Me.txtQuantidadeProduzida.ReadOnly = True
        Me.txtQuantidadeProduzida.Size = New System.Drawing.Size(110, 20)
        Me.txtQuantidadeProduzida.TabIndex = 15
        Me.txtQuantidadeProduzida.TabStop = False
        Me.txtQuantidadeProduzida.Text = "0,00"
        Me.txtQuantidadeProduzida.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtQuantidadeRejeito
        '
        Me.txtQuantidadeRejeito.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeRejeito.Location = New System.Drawing.Point(357, 76)
        Me.txtQuantidadeRejeito.Name = "txtQuantidadeRejeito"
        Me.txtQuantidadeRejeito.ReadOnly = True
        Me.txtQuantidadeRejeito.Size = New System.Drawing.Size(110, 20)
        Me.txtQuantidadeRejeito.TabIndex = 13
        Me.txtQuantidadeRejeito.TabStop = False
        Me.txtQuantidadeRejeito.Text = "0,00"
        Me.txtQuantidadeRejeito.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtQuantidadePlanejada
        '
        Me.txtQuantidadePlanejada.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadePlanejada.Location = New System.Drawing.Point(241, 76)
        Me.txtQuantidadePlanejada.Name = "txtQuantidadePlanejada"
        Me.txtQuantidadePlanejada.ReadOnly = True
        Me.txtQuantidadePlanejada.Size = New System.Drawing.Size(110, 20)
        Me.txtQuantidadePlanejada.TabIndex = 11
        Me.txtQuantidadePlanejada.TabStop = False
        Me.txtQuantidadePlanejada.Text = "0,00"
        Me.txtQuantidadePlanejada.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblQuantidadeRejeito
        '
        Me.lblQuantidadeRejeito.AutoSize = True
        Me.lblQuantidadeRejeito.Location = New System.Drawing.Point(354, 60)
        Me.lblQuantidadeRejeito.Name = "lblQuantidadeRejeito"
        Me.lblQuantidadeRejeito.Size = New System.Drawing.Size(71, 14)
        Me.lblQuantidadeRejeito.TabIndex = 12
        Me.lblQuantidadeRejeito.Text = "Qtde. Rejeito:"
        '
        'lblQuantidadeProduzida
        '
        Me.lblQuantidadeProduzida.AutoSize = True
        Me.lblQuantidadeProduzida.Location = New System.Drawing.Point(470, 59)
        Me.lblQuantidadeProduzida.Name = "lblQuantidadeProduzida"
        Me.lblQuantidadeProduzida.Size = New System.Drawing.Size(87, 14)
        Me.lblQuantidadeProduzida.TabIndex = 14
        Me.lblQuantidadeProduzida.Text = "Qtde. Produzida:"
        '
        'lblQuantidadePlanejada
        '
        Me.lblQuantidadePlanejada.AutoSize = True
        Me.lblQuantidadePlanejada.Location = New System.Drawing.Point(238, 59)
        Me.lblQuantidadePlanejada.Name = "lblQuantidadePlanejada"
        Me.lblQuantidadePlanejada.Size = New System.Drawing.Size(85, 14)
        Me.lblQuantidadePlanejada.TabIndex = 10
        Me.lblQuantidadePlanejada.Text = "Qtde. Planejada:"
        '
        'txtDataTermino
        '
        Me.txtDataTermino.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataTermino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataTermino.Location = New System.Drawing.Point(125, 76)
        Me.txtDataTermino.MaxLength = 20
        Me.txtDataTermino.Name = "txtDataTermino"
        Me.txtDataTermino.ReadOnly = True
        Me.txtDataTermino.Size = New System.Drawing.Size(110, 20)
        Me.txtDataTermino.TabIndex = 9
        Me.txtDataTermino.TabStop = False
        '
        'txtDataInicio
        '
        Me.txtDataInicio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataInicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataInicio.Location = New System.Drawing.Point(9, 76)
        Me.txtDataInicio.MaxLength = 20
        Me.txtDataInicio.Name = "txtDataInicio"
        Me.txtDataInicio.ReadOnly = True
        Me.txtDataInicio.Size = New System.Drawing.Size(110, 20)
        Me.txtDataInicio.TabIndex = 7
        Me.txtDataInicio.TabStop = False
        '
        'txtCodigoProduto
        '
        Me.txtCodigoProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoProduto.Location = New System.Drawing.Point(125, 36)
        Me.txtCodigoProduto.MaxLength = 60
        Me.txtCodigoProduto.Name = "txtCodigoProduto"
        Me.txtCodigoProduto.ReadOnly = True
        Me.txtCodigoProduto.Size = New System.Drawing.Size(170, 20)
        Me.txtCodigoProduto.TabIndex = 3
        Me.txtCodigoProduto.TabStop = False
        '
        'lblDataTermino
        '
        Me.lblDataTermino.AutoSize = True
        Me.lblDataTermino.Location = New System.Drawing.Point(122, 59)
        Me.lblDataTermino.Name = "lblDataTermino"
        Me.lblDataTermino.Size = New System.Drawing.Size(73, 14)
        Me.lblDataTermino.TabIndex = 8
        Me.lblDataTermino.Text = "Data Término:"
        '
        'lblCodigoProduto
        '
        Me.lblCodigoProduto.AutoSize = True
        Me.lblCodigoProduto.Location = New System.Drawing.Point(122, 19)
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        Me.lblCodigoProduto.Size = New System.Drawing.Size(98, 14)
        Me.lblCodigoProduto.TabIndex = 2
        Me.lblCodigoProduto.Text = "Código do Produto:"
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.Location = New System.Drawing.Point(6, 60)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(59, 14)
        Me.lblDataInicio.TabIndex = 6
        Me.lblDataInicio.Text = "Data Início:"
        '
        'txtOrdemFabricacao
        '
        Me.txtOrdemFabricacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrdemFabricacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdemFabricacao.Location = New System.Drawing.Point(9, 37)
        Me.txtOrdemFabricacao.MaxLength = 20
        Me.txtOrdemFabricacao.Name = "txtOrdemFabricacao"
        Me.txtOrdemFabricacao.ReadOnly = True
        Me.txtOrdemFabricacao.Size = New System.Drawing.Size(110, 20)
        Me.txtOrdemFabricacao.TabIndex = 1
        Me.txtOrdemFabricacao.TabStop = False
        '
        'lblOrdemProducao
        '
        Me.lblOrdemProducao.AutoSize = True
        Me.lblOrdemProducao.Location = New System.Drawing.Point(6, 20)
        Me.lblOrdemProducao.Name = "lblOrdemProducao"
        Me.lblOrdemProducao.Size = New System.Drawing.Size(106, 14)
        Me.lblOrdemProducao.TabIndex = 0
        Me.lblOrdemProducao.Text = "Nº Ordem Produção:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnCancelar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 325)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(687, 51)
        Me.grpControl2.TabIndex = 2
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnCancelar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCancelar.Location = New System.Drawing.Point(381, 17)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCancelar.Size = New System.Drawing.Size(200, 23)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Reativar Ordem de Produção"
        Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
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
        'frmPrdOrdemProducaoReativar
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
        Me.Name = "frmPrdOrdemProducaoReativar"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reativar Ordem de Produção"
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
    Private WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtJustificativa As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeProduzida As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtQuantidadeRejeito As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtQuantidadePlanejada As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeRejeito As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeProduzida As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadePlanejada As System.Windows.Forms.Label
    Friend WithEvents txtDataTermino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDataInicio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCodigoProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataTermino As System.Windows.Forms.Label
    Friend WithEvents lblCodigoProduto As System.Windows.Forms.Label
    Friend WithEvents lblDataInicio As System.Windows.Forms.Label
    Friend WithEvents txtOrdemFabricacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents lblJustificativa As System.Windows.Forms.Label
End Class
