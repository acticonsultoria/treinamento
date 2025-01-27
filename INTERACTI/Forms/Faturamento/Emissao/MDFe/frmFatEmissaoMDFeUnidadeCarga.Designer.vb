<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEmissaoMDFeUnidadeCarga
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEmissaoMDFeUnidadeCarga))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblIdentificacao = New System.Windows.Forms.Label()
        Me.txtIdentificacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroLacres = New System.Windows.Forms.Label()
        Me.txtNumeroLacres = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtQuantidadeRateada = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboTipo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblQuantidadeRateada = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.grpControles = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpControles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControles.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(813, 182)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpDados)
        Me.pagTabela.Controls.Add(Me.grpControles)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(811, 159)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Dados"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblIdentificacao)
        Me.grpDados.Controls.Add(Me.txtIdentificacao)
        Me.grpDados.Controls.Add(Me.lblNumeroLacres)
        Me.grpDados.Controls.Add(Me.txtNumeroLacres)
        Me.grpDados.Controls.Add(Me.txtQuantidadeRateada)
        Me.grpDados.Controls.Add(Me.cboTipo)
        Me.grpDados.Controls.Add(Me.lblQuantidadeRateada)
        Me.grpDados.Controls.Add(Me.lblTipo)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(800, 77)
        Me.grpDados.TabIndex = 0
        Me.grpDados.Text = "Geral"
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblIdentificacao
        '
        Me.lblIdentificacao.AutoSize = True
        Me.lblIdentificacao.Location = New System.Drawing.Point(202, 20)
        Me.lblIdentificacao.Name = "lblIdentificacao"
        Me.lblIdentificacao.Size = New System.Drawing.Size(71, 14)
        Me.lblIdentificacao.TabIndex = 2
        Me.lblIdentificacao.Text = "Identificação:"
        '
        'txtIdentificacao
        '
        Me.txtIdentificacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdentificacao.Location = New System.Drawing.Point(205, 38)
        Me.txtIdentificacao.MaxLength = 60
        Me.txtIdentificacao.Name = "txtIdentificacao"
        Me.txtIdentificacao.Size = New System.Drawing.Size(236, 20)
        Me.txtIdentificacao.TabIndex = 3
        '
        'lblNumeroLacres
        '
        Me.lblNumeroLacres.AutoSize = True
        Me.lblNumeroLacres.Location = New System.Drawing.Point(623, 20)
        Me.lblNumeroLacres.Name = "lblNumeroLacres"
        Me.lblNumeroLacres.Size = New System.Drawing.Size(99, 14)
        Me.lblNumeroLacres.TabIndex = 6
        Me.lblNumeroLacres.Text = "Número de Lacres:"
        '
        'txtNumeroLacres
        '
        Me.txtNumeroLacres.BackColor = System.Drawing.Color.White
        Me.txtNumeroLacres.DecimalDigits = 0
        Me.txtNumeroLacres.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroLacres.Location = New System.Drawing.Point(626, 38)
        Me.txtNumeroLacres.MaxLength = 8
        Me.txtNumeroLacres.Name = "txtNumeroLacres"
        Me.txtNumeroLacres.Size = New System.Drawing.Size(165, 20)
        Me.txtNumeroLacres.TabIndex = 7
        Me.txtNumeroLacres.TabStop = False
        Me.txtNumeroLacres.Text = "0"
        Me.txtNumeroLacres.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtQuantidadeRateada
        '
        Me.txtQuantidadeRateada.BackColor = System.Drawing.Color.White
        Me.txtQuantidadeRateada.DecimalDigits = 0
        Me.txtQuantidadeRateada.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQuantidadeRateada.Location = New System.Drawing.Point(447, 38)
        Me.txtQuantidadeRateada.MaxLength = 8
        Me.txtQuantidadeRateada.Name = "txtQuantidadeRateada"
        Me.txtQuantidadeRateada.Size = New System.Drawing.Size(173, 20)
        Me.txtQuantidadeRateada.TabIndex = 5
        Me.txtQuantidadeRateada.TabStop = False
        Me.txtQuantidadeRateada.Text = "0"
        Me.txtQuantidadeRateada.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cboTipo
        '
        Me.cboTipo.AutoSize = False
        Me.cboTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipo.Location = New System.Drawing.Point(9, 38)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipo.Size = New System.Drawing.Size(190, 20)
        Me.cboTipo.TabIndex = 1
        '
        'lblQuantidadeRateada
        '
        Me.lblQuantidadeRateada.AutoSize = True
        Me.lblQuantidadeRateada.Location = New System.Drawing.Point(444, 20)
        Me.lblQuantidadeRateada.Name = "lblQuantidadeRateada"
        Me.lblQuantidadeRateada.Size = New System.Drawing.Size(108, 14)
        Me.lblQuantidadeRateada.TabIndex = 4
        Me.lblQuantidadeRateada.Text = "Quantidade Rateada:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipo.Location = New System.Drawing.Point(6, 20)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 14)
        Me.lblTipo.TabIndex = 0
        Me.lblTipo.Text = "Tipo:"
        '
        'grpControles
        '
        Me.grpControles.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpControles.BackColor = System.Drawing.Color.Transparent
        Me.grpControles.Controls.Add(Me.btnSalvar)
        Me.grpControles.Controls.Add(Me.btnSair)
        Me.grpControles.Location = New System.Drawing.Point(8, 101)
        Me.grpControles.Name = "grpControles"
        Me.grpControles.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControles.Size = New System.Drawing.Size(800, 52)
        Me.grpControles.TabIndex = 1
        Me.grpControles.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControles.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(603, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(700, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmFatEmissaoMDFeUnidadeCarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 197)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEmissaoMDFeUnidadeCarga"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manifesto de Documentos Eletrônico"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControles As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblNumeroLacres As System.Windows.Forms.Label
    Friend WithEvents txtNumeroLacres As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtQuantidadeRateada As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboTipo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblQuantidadeRateada As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblIdentificacao As System.Windows.Forms.Label
    Friend WithEvents txtIdentificacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
End Class
