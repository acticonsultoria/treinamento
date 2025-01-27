<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinEditarDuplicatas
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
        Dim grdDuplicata_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinEditarDuplicatas))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtIntervaloParcela = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblIntervaloParcela = New System.Windows.Forms.Label()
        Me.txtNumeroParcela = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroParcela = New System.Windows.Forms.Label()
        Me.grpValores = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorFinal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorFinal = New System.Windows.Forms.Label()
        Me.txtValorDevolvido = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorDevolvido = New System.Windows.Forms.Label()
        Me.txtValorTituloOriginal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTituloOriginal = New System.Windows.Forms.Label()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.txtParceiroNegocio = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblParceiroNegocio = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdDuplicata = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grpValores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpValores.SuspendLayout()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInformacoes.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grdDuplicata, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(528, 408)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grdDuplicata)
        Me.pagTabela.Controls.Add(Me.UiGroupBox1)
        Me.pagTabela.Controls.Add(Me.grpValores)
        Me.pagTabela.Controls.Add(Me.grpInformacoes)
        Me.pagTabela.Controls.Add(Me.grpControl)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(526, 385)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Dados da Parcela"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.txtIntervaloParcela)
        Me.UiGroupBox1.Controls.Add(Me.lblIntervaloParcela)
        Me.UiGroupBox1.Controls.Add(Me.txtNumeroParcela)
        Me.UiGroupBox1.Controls.Add(Me.lblNumeroParcela)
        Me.UiGroupBox1.Location = New System.Drawing.Point(278, 70)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(240, 64)
        Me.UiGroupBox1.TabIndex = 2
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'txtIntervaloParcela
        '
        Me.txtIntervaloParcela.DecimalDigits = 0
        Me.txtIntervaloParcela.Location = New System.Drawing.Point(123, 34)
        Me.txtIntervaloParcela.Name = "txtIntervaloParcela"
        Me.txtIntervaloParcela.Size = New System.Drawing.Size(108, 20)
        Me.txtIntervaloParcela.TabIndex = 3
        Me.txtIntervaloParcela.Text = "0"
        Me.txtIntervaloParcela.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblIntervaloParcela
        '
        Me.lblIntervaloParcela.AutoSize = True
        Me.lblIntervaloParcela.Location = New System.Drawing.Point(120, 17)
        Me.lblIntervaloParcela.Name = "lblIntervaloParcela"
        Me.lblIntervaloParcela.Size = New System.Drawing.Size(97, 14)
        Me.lblIntervaloParcela.TabIndex = 2
        Me.lblIntervaloParcela.Text = "Int. entre Parcelas:"
        '
        'txtNumeroParcela
        '
        Me.txtNumeroParcela.DecimalDigits = 0
        Me.txtNumeroParcela.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroParcela.Name = "txtNumeroParcela"
        Me.txtNumeroParcela.Size = New System.Drawing.Size(108, 20)
        Me.txtNumeroParcela.TabIndex = 1
        Me.txtNumeroParcela.Text = "0"
        Me.txtNumeroParcela.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumeroParcela
        '
        Me.lblNumeroParcela.AutoSize = True
        Me.lblNumeroParcela.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroParcela.Name = "lblNumeroParcela"
        Me.lblNumeroParcela.Size = New System.Drawing.Size(67, 14)
        Me.lblNumeroParcela.TabIndex = 0
        Me.lblNumeroParcela.Text = "Nº Parcelas:"
        '
        'grpValores
        '
        Me.grpValores.BackColor = System.Drawing.Color.Transparent
        Me.grpValores.Controls.Add(Me.txtValorFinal)
        Me.grpValores.Controls.Add(Me.lblValorFinal)
        Me.grpValores.Controls.Add(Me.txtValorDevolvido)
        Me.grpValores.Controls.Add(Me.lblValorDevolvido)
        Me.grpValores.Controls.Add(Me.txtValorTituloOriginal)
        Me.grpValores.Controls.Add(Me.lblValorTituloOriginal)
        Me.grpValores.Location = New System.Drawing.Point(8, 70)
        Me.grpValores.Name = "grpValores"
        Me.grpValores.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpValores.Size = New System.Drawing.Size(244, 99)
        Me.grpValores.TabIndex = 1
        Me.grpValores.VisualStyleManager = Me.vsmMain
        '
        'txtValorFinal
        '
        Me.txtValorFinal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorFinal.DecimalDigits = 2
        Me.txtValorFinal.Location = New System.Drawing.Point(125, 69)
        Me.txtValorFinal.Name = "txtValorFinal"
        Me.txtValorFinal.ReadOnly = True
        Me.txtValorFinal.Size = New System.Drawing.Size(110, 20)
        Me.txtValorFinal.TabIndex = 5
        Me.txtValorFinal.TabStop = False
        Me.txtValorFinal.Text = "0,00"
        Me.txtValorFinal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorFinal
        '
        Me.lblValorFinal.AutoSize = True
        Me.lblValorFinal.Location = New System.Drawing.Point(6, 72)
        Me.lblValorFinal.Name = "lblValorFinal"
        Me.lblValorFinal.Size = New System.Drawing.Size(60, 14)
        Me.lblValorFinal.TabIndex = 4
        Me.lblValorFinal.Text = "Valor Final:"
        '
        'txtValorDevolvido
        '
        Me.txtValorDevolvido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorDevolvido.DecimalDigits = 2
        Me.txtValorDevolvido.Location = New System.Drawing.Point(125, 43)
        Me.txtValorDevolvido.Name = "txtValorDevolvido"
        Me.txtValorDevolvido.ReadOnly = True
        Me.txtValorDevolvido.Size = New System.Drawing.Size(110, 20)
        Me.txtValorDevolvido.TabIndex = 3
        Me.txtValorDevolvido.TabStop = False
        Me.txtValorDevolvido.Text = "0,00"
        Me.txtValorDevolvido.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorDevolvido
        '
        Me.lblValorDevolvido.AutoSize = True
        Me.lblValorDevolvido.Location = New System.Drawing.Point(6, 46)
        Me.lblValorDevolvido.Name = "lblValorDevolvido"
        Me.lblValorDevolvido.Size = New System.Drawing.Size(85, 14)
        Me.lblValorDevolvido.TabIndex = 2
        Me.lblValorDevolvido.Text = "Valor Devolvido:"
        '
        'txtValorTituloOriginal
        '
        Me.txtValorTituloOriginal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTituloOriginal.DecimalDigits = 2
        Me.txtValorTituloOriginal.Location = New System.Drawing.Point(125, 17)
        Me.txtValorTituloOriginal.Name = "txtValorTituloOriginal"
        Me.txtValorTituloOriginal.ReadOnly = True
        Me.txtValorTituloOriginal.Size = New System.Drawing.Size(110, 20)
        Me.txtValorTituloOriginal.TabIndex = 1
        Me.txtValorTituloOriginal.TabStop = False
        Me.txtValorTituloOriginal.Text = "0,00"
        Me.txtValorTituloOriginal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorTituloOriginal
        '
        Me.lblValorTituloOriginal.AutoSize = True
        Me.lblValorTituloOriginal.Location = New System.Drawing.Point(6, 20)
        Me.lblValorTituloOriginal.Name = "lblValorTituloOriginal"
        Me.lblValorTituloOriginal.Size = New System.Drawing.Size(102, 14)
        Me.lblValorTituloOriginal.TabIndex = 0
        Me.lblValorTituloOriginal.Text = "Valor Título Original:"
        '
        'grpInformacoes
        '
        Me.grpInformacoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.lblNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.txtNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.txtParceiroNegocio)
        Me.grpInformacoes.Controls.Add(Me.lblParceiroNegocio)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(510, 64)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 1
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumento.MaxLength = 0
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.ReadOnly = True
        Me.txtNumeroDocumento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(110, 20)
        Me.txtNumeroDocumento.TabIndex = 1
        Me.txtNumeroDocumento.TabStop = False
        '
        'txtParceiroNegocio
        '
        Me.txtParceiroNegocio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtParceiroNegocio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtParceiroNegocio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtParceiroNegocio.Location = New System.Drawing.Point(125, 34)
        Me.txtParceiroNegocio.MaxLength = 0
        Me.txtParceiroNegocio.Name = "txtParceiroNegocio"
        Me.txtParceiroNegocio.ReadOnly = True
        Me.txtParceiroNegocio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtParceiroNegocio.Size = New System.Drawing.Size(376, 20)
        Me.txtParceiroNegocio.TabIndex = 3
        Me.txtParceiroNegocio.TabStop = False
        '
        'lblParceiroNegocio
        '
        Me.lblParceiroNegocio.AutoSize = True
        Me.lblParceiroNegocio.Location = New System.Drawing.Point(122, 17)
        Me.lblParceiroNegocio.Name = "lblParceiroNegocio"
        Me.lblParceiroNegocio.Size = New System.Drawing.Size(92, 14)
        Me.lblParceiroNegocio.TabIndex = 2
        Me.lblParceiroNegocio.Text = "Parceiro Negócio:"
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 325)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(510, 51)
        Me.grpControl.TabIndex = 4
        Me.grpControl.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(313, 17)
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
        Me.btnSair.Location = New System.Drawing.Point(410, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdDuplicata
        '
        Me.grdDuplicata.AlternatingColors = True
        Me.grdDuplicata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDuplicata.CellToolTipText = "Duplo Clique para editar o Registro"
        Me.grdDuplicata.ColumnAutoResize = True
        grdDuplicata_DesignTimeLayout.LayoutString = resources.GetString("grdDuplicata_DesignTimeLayout.LayoutString")
        Me.grdDuplicata.DesignTimeLayout = grdDuplicata_DesignTimeLayout
        Me.grdDuplicata.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdDuplicata.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdDuplicata.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdDuplicata.GroupByBoxVisible = False
        Me.grdDuplicata.Location = New System.Drawing.Point(278, 142)
        Me.grdDuplicata.Name = "grdDuplicata"
        Me.grdDuplicata.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdDuplicata.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdDuplicata.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdDuplicata.Size = New System.Drawing.Size(240, 180)
        Me.grdDuplicata.TabIndex = 3
        Me.grdDuplicata.TabStop = False
        Me.grdDuplicata.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdDuplicata.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdDuplicata.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdDuplicata.VisualStyleManager = Me.vsmMain
        '
        'frmFinEditarDuplicatas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(542, 424)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinEditarDuplicatas"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dados da Parcela"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grpValores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpValores.ResumeLayout(False)
        Me.grpValores.PerformLayout()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInformacoes.ResumeLayout(False)
        Me.grpInformacoes.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grdDuplicata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtParceiroNegocio As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblParceiroNegocio As System.Windows.Forms.Label
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents grpValores As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtValorFinal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorFinal As System.Windows.Forms.Label
    Friend WithEvents txtValorDevolvido As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorDevolvido As System.Windows.Forms.Label
    Friend WithEvents txtValorTituloOriginal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorTituloOriginal As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtIntervaloParcela As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblIntervaloParcela As System.Windows.Forms.Label
    Friend WithEvents txtNumeroParcela As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroParcela As System.Windows.Forms.Label
    Friend WithEvents grdDuplicata As Janus.Windows.GridEX.GridEX
End Class
