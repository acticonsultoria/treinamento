<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCfgNumeracaoComercialAcordoComercial
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCfgNumeracaoComercialAcordoComercial))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtExemplo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblExemplo = New System.Windows.Forms.Label()
        Me.cboFormato = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFormato = New System.Windows.Forms.Label()
        Me.txtNumeroAcordoComercial = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroCaracter = New System.Windows.Forms.Label()
        Me.txtNumeroCaracter = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtSigla = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSigla = New System.Windows.Forms.Label()
        Me.lblNumeroAcordoComercial = New System.Windows.Forms.Label()
        Me.picEmail = New System.Windows.Forms.PictureBox()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.picEmail, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox3.Controls.Add(Me.btnSalvar)
        Me.UiGroupBox3.Controls.Add(Me.btnSair)
        Me.UiGroupBox3.Location = New System.Drawing.Point(13, 155)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox3.Size = New System.Drawing.Size(462, 51)
        Me.UiGroupBox3.TabIndex = 1
        Me.UiGroupBox3.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(264, 17)
        Me.btnSalvar.Name = "btnSalvar"
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
        Me.btnSair.Location = New System.Drawing.Point(361, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtExemplo)
        Me.grpDados.Controls.Add(Me.lblExemplo)
        Me.grpDados.Controls.Add(Me.cboFormato)
        Me.grpDados.Controls.Add(Me.lblFormato)
        Me.grpDados.Controls.Add(Me.txtNumeroAcordoComercial)
        Me.grpDados.Controls.Add(Me.lblNumeroCaracter)
        Me.grpDados.Controls.Add(Me.txtNumeroCaracter)
        Me.grpDados.Controls.Add(Me.txtSigla)
        Me.grpDados.Controls.Add(Me.lblSigla)
        Me.grpDados.Controls.Add(Me.lblNumeroAcordoComercial)
        Me.grpDados.Location = New System.Drawing.Point(157, 8)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(318, 104)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtExemplo
        '
        Me.txtExemplo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtExemplo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtExemplo.Location = New System.Drawing.Point(204, 74)
        Me.txtExemplo.MaxLength = 5
        Me.txtExemplo.Name = "txtExemplo"
        Me.txtExemplo.ReadOnly = True
        Me.txtExemplo.Size = New System.Drawing.Size(104, 20)
        Me.txtExemplo.TabIndex = 11
        Me.txtExemplo.TabStop = False
        '
        'lblExemplo
        '
        Me.lblExemplo.AutoSize = True
        Me.lblExemplo.Location = New System.Drawing.Point(201, 57)
        Me.lblExemplo.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblExemplo.Name = "lblExemplo"
        Me.lblExemplo.Size = New System.Drawing.Size(50, 14)
        Me.lblExemplo.TabIndex = 10
        Me.lblExemplo.Text = "Exemplo:"
        '
        'cboFormato
        '
        Me.cboFormato.AutoSize = False
        Me.cboFormato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboFormato.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboFormato.Location = New System.Drawing.Point(9, 74)
        Me.cboFormato.Name = "cboFormato"
        Me.cboFormato.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFormato.Size = New System.Drawing.Size(189, 20)
        Me.cboFormato.TabIndex = 9
        '
        'lblFormato
        '
        Me.lblFormato.AutoSize = True
        Me.lblFormato.Location = New System.Drawing.Point(6, 57)
        Me.lblFormato.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblFormato.Name = "lblFormato"
        Me.lblFormato.Size = New System.Drawing.Size(49, 14)
        Me.lblFormato.TabIndex = 8
        Me.lblFormato.Text = "Formato:"
        '
        'txtNumeroAcordoComercial
        '
        Me.txtNumeroAcordoComercial.DecimalDigits = 0
        Me.txtNumeroAcordoComercial.Location = New System.Drawing.Point(204, 34)
        Me.txtNumeroAcordoComercial.MaxLength = 4
        Me.txtNumeroAcordoComercial.Name = "txtNumeroAcordoComercial"
        Me.txtNumeroAcordoComercial.Size = New System.Drawing.Size(104, 20)
        Me.txtNumeroAcordoComercial.TabIndex = 7
        Me.txtNumeroAcordoComercial.Text = "0"
        Me.txtNumeroAcordoComercial.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumeroCaracter
        '
        Me.lblNumeroCaracter.AutoSize = True
        Me.lblNumeroCaracter.Location = New System.Drawing.Point(91, 17)
        Me.lblNumeroCaracter.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblNumeroCaracter.Name = "lblNumeroCaracter"
        Me.lblNumeroCaracter.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroCaracter.TabIndex = 4
        Me.lblNumeroCaracter.Text = "Nº Caractéres:"
        '
        'txtNumeroCaracter
        '
        Me.txtNumeroCaracter.DecimalDigits = 0
        Me.txtNumeroCaracter.Location = New System.Drawing.Point(94, 34)
        Me.txtNumeroCaracter.MaxLength = 1
        Me.txtNumeroCaracter.Name = "txtNumeroCaracter"
        Me.txtNumeroCaracter.Size = New System.Drawing.Size(104, 20)
        Me.txtNumeroCaracter.TabIndex = 5
        Me.txtNumeroCaracter.Text = "0"
        Me.txtNumeroCaracter.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtSigla
        '
        Me.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSigla.Location = New System.Drawing.Point(9, 34)
        Me.txtSigla.MaxLength = 5
        Me.txtSigla.Name = "txtSigla"
        Me.txtSigla.Size = New System.Drawing.Size(79, 20)
        Me.txtSigla.TabIndex = 3
        '
        'lblSigla
        '
        Me.lblSigla.AutoSize = True
        Me.lblSigla.Location = New System.Drawing.Point(6, 17)
        Me.lblSigla.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblSigla.Name = "lblSigla"
        Me.lblSigla.Size = New System.Drawing.Size(33, 14)
        Me.lblSigla.TabIndex = 2
        Me.lblSigla.Text = "Sigla:"
        '
        'lblNumeroAcordoComercial
        '
        Me.lblNumeroAcordoComercial.AutoSize = True
        Me.lblNumeroAcordoComercial.Location = New System.Drawing.Point(201, 17)
        Me.lblNumeroAcordoComercial.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblNumeroAcordoComercial.Name = "lblNumeroAcordoComercial"
        Me.lblNumeroAcordoComercial.Size = New System.Drawing.Size(60, 14)
        Me.lblNumeroAcordoComercial.TabIndex = 6
        Me.lblNumeroAcordoComercial.Text = "Nº Acordo:"
        '
        'picEmail
        '
        Me.picEmail.Image = Global.INTERACTI.My.Resources.configuracao_nf
        Me.picEmail.Location = New System.Drawing.Point(13, 8)
        Me.picEmail.Name = "picEmail"
        Me.picEmail.Size = New System.Drawing.Size(130, 128)
        Me.picEmail.TabIndex = 9
        Me.picEmail.TabStop = False
        '
        'usrCfgNumeracaoComercialAcordoComercial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.picEmail)
        Me.Controls.Add(Me.UiGroupBox3)
        Me.Controls.Add(Me.grpDados)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCfgNumeracaoComercialAcordoComercial"
        Me.Size = New System.Drawing.Size(489, 218)
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.picEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picEmail As System.Windows.Forms.PictureBox
    Friend WithEvents lblNumeroAcordoComercial As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtSigla As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSigla As System.Windows.Forms.Label
    Friend WithEvents lblNumeroCaracter As System.Windows.Forms.Label
    Friend WithEvents txtNumeroCaracter As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtExemplo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblExemplo As System.Windows.Forms.Label
    Friend WithEvents cboFormato As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFormato As System.Windows.Forms.Label
    Friend WithEvents txtNumeroAcordoComercial As Janus.Windows.GridEX.EditControls.NumericEditBox

End Class
