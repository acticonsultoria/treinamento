<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFinTransferenciaBanco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFinTransferenciaBanco))
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.lblSaldoFinalDestino = New System.Windows.Forms.Label()
        Me.txtSaldoFinalContaBancariaDestino = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblSaldoContaBancariaOrigem = New System.Windows.Forms.Label()
        Me.txtSaldoContaBancariaOrigem = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorTransferencia = New System.Windows.Forms.Label()
        Me.txtValorTransferencia = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboContaBancariaOrigem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblContaBancariaOrigem = New System.Windows.Forms.Label()
        Me.dtpData = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboContaBancariaDestino = New Janus.Windows.EditControls.UIComboBox()
        Me.lblContaBancariaDestino = New System.Windows.Forms.Label()
        Me.picSistema = New System.Windows.Forms.PictureBox()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox3.Controls.Add(Me.btnSalvar)
        Me.UiGroupBox3.Controls.Add(Me.btnSair)
        Me.UiGroupBox3.Location = New System.Drawing.Point(13, 267)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox3.Size = New System.Drawing.Size(489, 51)
        Me.UiGroupBox3.TabIndex = 1
        Me.UiGroupBox3.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(292, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(389, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.cboContaBancariaDestino)
        Me.UiGroupBox1.Controls.Add(Me.lblContaBancariaDestino)
        Me.UiGroupBox1.Controls.Add(Me.dtpData)
        Me.UiGroupBox1.Controls.Add(Me.txtNumeroDocumento)
        Me.UiGroupBox1.Controls.Add(Me.lblNumeroDocumento)
        Me.UiGroupBox1.Controls.Add(Me.lblSaldoFinalDestino)
        Me.UiGroupBox1.Controls.Add(Me.txtSaldoFinalContaBancariaDestino)
        Me.UiGroupBox1.Controls.Add(Me.lblSaldoContaBancariaOrigem)
        Me.UiGroupBox1.Controls.Add(Me.txtSaldoContaBancariaOrigem)
        Me.UiGroupBox1.Controls.Add(Me.lblValorTransferencia)
        Me.UiGroupBox1.Controls.Add(Me.txtValorTransferencia)
        Me.UiGroupBox1.Controls.Add(Me.cboContaBancariaOrigem)
        Me.UiGroupBox1.Controls.Add(Me.lblData)
        Me.UiGroupBox1.Controls.Add(Me.lblContaBancariaOrigem)
        Me.UiGroupBox1.Location = New System.Drawing.Point(13, 120)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(489, 144)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(255, 74)
        Me.txtNumeroDocumento.MaxLength = 30
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(225, 20)
        Me.txtNumeroDocumento.TabIndex = 9
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(252, 57)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 8
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'lblSaldoFinalDestino
        '
        Me.lblSaldoFinalDestino.AutoSize = True
        Me.lblSaldoFinalDestino.Location = New System.Drawing.Point(358, 98)
        Me.lblSaldoFinalDestino.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblSaldoFinalDestino.Name = "lblSaldoFinalDestino"
        Me.lblSaldoFinalDestino.Size = New System.Drawing.Size(101, 14)
        Me.lblSaldoFinalDestino.TabIndex = 12
        Me.lblSaldoFinalDestino.Text = "Saldo Final Destino:"
        '
        'txtSaldoFinalContaBancariaDestino
        '
        Me.txtSaldoFinalContaBancariaDestino.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSaldoFinalContaBancariaDestino.Location = New System.Drawing.Point(361, 114)
        Me.txtSaldoFinalContaBancariaDestino.Name = "txtSaldoFinalContaBancariaDestino"
        Me.txtSaldoFinalContaBancariaDestino.ReadOnly = True
        Me.txtSaldoFinalContaBancariaDestino.Size = New System.Drawing.Size(119, 20)
        Me.txtSaldoFinalContaBancariaDestino.TabIndex = 13
        Me.txtSaldoFinalContaBancariaDestino.TabStop = False
        Me.txtSaldoFinalContaBancariaDestino.Text = "0,00"
        Me.txtSaldoFinalContaBancariaDestino.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblSaldoContaBancariaOrigem
        '
        Me.lblSaldoContaBancariaOrigem.AutoSize = True
        Me.lblSaldoContaBancariaOrigem.Location = New System.Drawing.Point(358, 17)
        Me.lblSaldoContaBancariaOrigem.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblSaldoContaBancariaOrigem.Name = "lblSaldoContaBancariaOrigem"
        Me.lblSaldoContaBancariaOrigem.Size = New System.Drawing.Size(74, 14)
        Me.lblSaldoContaBancariaOrigem.TabIndex = 2
        Me.lblSaldoContaBancariaOrigem.Text = "Saldo Origem:"
        '
        'txtSaldoContaBancariaOrigem
        '
        Me.txtSaldoContaBancariaOrigem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSaldoContaBancariaOrigem.Location = New System.Drawing.Point(361, 34)
        Me.txtSaldoContaBancariaOrigem.Name = "txtSaldoContaBancariaOrigem"
        Me.txtSaldoContaBancariaOrigem.ReadOnly = True
        Me.txtSaldoContaBancariaOrigem.Size = New System.Drawing.Size(119, 20)
        Me.txtSaldoContaBancariaOrigem.TabIndex = 3
        Me.txtSaldoContaBancariaOrigem.TabStop = False
        Me.txtSaldoContaBancariaOrigem.Text = "0,00"
        Me.txtSaldoContaBancariaOrigem.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorTransferencia
        '
        Me.lblValorTransferencia.AutoSize = True
        Me.lblValorTransferencia.Location = New System.Drawing.Point(133, 57)
        Me.lblValorTransferencia.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblValorTransferencia.Name = "lblValorTransferencia"
        Me.lblValorTransferencia.Size = New System.Drawing.Size(35, 14)
        Me.lblValorTransferencia.TabIndex = 6
        Me.lblValorTransferencia.Text = "Valor:"
        '
        'txtValorTransferencia
        '
        Me.txtValorTransferencia.Location = New System.Drawing.Point(136, 74)
        Me.txtValorTransferencia.Name = "txtValorTransferencia"
        Me.txtValorTransferencia.Size = New System.Drawing.Size(113, 20)
        Me.txtValorTransferencia.TabIndex = 7
        Me.txtValorTransferencia.Text = "0,00"
        Me.txtValorTransferencia.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'cboContaBancariaOrigem
        '
        Me.cboContaBancariaOrigem.AutoSize = False
        Me.cboContaBancariaOrigem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboContaBancariaOrigem.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboContaBancariaOrigem.Location = New System.Drawing.Point(9, 34)
        Me.cboContaBancariaOrigem.Name = "cboContaBancariaOrigem"
        Me.cboContaBancariaOrigem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaBancariaOrigem.Size = New System.Drawing.Size(346, 20)
        Me.cboContaBancariaOrigem.TabIndex = 1
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(6, 57)
        Me.lblData.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(32, 14)
        Me.lblData.TabIndex = 4
        Me.lblData.Text = "Data:"
        '
        'lblContaBancariaOrigem
        '
        Me.lblContaBancariaOrigem.AutoSize = True
        Me.lblContaBancariaOrigem.Location = New System.Drawing.Point(6, 17)
        Me.lblContaBancariaOrigem.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblContaBancariaOrigem.Name = "lblContaBancariaOrigem"
        Me.lblContaBancariaOrigem.Size = New System.Drawing.Size(136, 14)
        Me.lblContaBancariaOrigem.TabIndex = 0
        Me.lblContaBancariaOrigem.Text = "Conta Bancária de Origem:"
        '
        'dtpData
        '
        '
        '
        '
        Me.dtpData.DropDownCalendar.Name = ""
        Me.dtpData.Location = New System.Drawing.Point(9, 74)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(121, 20)
        Me.dtpData.TabIndex = 5
        '
        'cboContaBancariaDestino
        '
        Me.cboContaBancariaDestino.AutoSize = False
        Me.cboContaBancariaDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboContaBancariaDestino.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboContaBancariaDestino.Location = New System.Drawing.Point(9, 114)
        Me.cboContaBancariaDestino.Name = "cboContaBancariaDestino"
        Me.cboContaBancariaDestino.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaBancariaDestino.Size = New System.Drawing.Size(346, 20)
        Me.cboContaBancariaDestino.TabIndex = 11
        '
        'lblContaBancariaDestino
        '
        Me.lblContaBancariaDestino.AutoSize = True
        Me.lblContaBancariaDestino.Location = New System.Drawing.Point(6, 97)
        Me.lblContaBancariaDestino.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblContaBancariaDestino.Name = "lblContaBancariaDestino"
        Me.lblContaBancariaDestino.Size = New System.Drawing.Size(138, 14)
        Me.lblContaBancariaDestino.TabIndex = 10
        Me.lblContaBancariaDestino.Text = "Conta Bancária de Destino:"
        '
        'picSistema
        '
        Me.picSistema.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picSistema.Image = Global.INTERACTI.My.Resources.Interacti
        Me.picSistema.Location = New System.Drawing.Point(13, 8)
        Me.picSistema.Name = "picSistema"
        Me.picSistema.Size = New System.Drawing.Size(489, 109)
        Me.picSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSistema.TabIndex = 11
        Me.picSistema.TabStop = False
        '
        'usrFinTransferenciaBanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.picSistema)
        Me.Controls.Add(Me.UiGroupBox3)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFinTransferenciaBanco"
        Me.Size = New System.Drawing.Size(516, 333)
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblContaBancariaOrigem As System.Windows.Forms.Label
    Friend WithEvents cboContaBancariaOrigem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblValorTransferencia As System.Windows.Forms.Label
    Friend WithEvents txtValorTransferencia As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblSaldoContaBancariaOrigem As System.Windows.Forms.Label
    Friend WithEvents txtSaldoContaBancariaOrigem As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblSaldoFinalDestino As System.Windows.Forms.Label
    Friend WithEvents txtSaldoFinalContaBancariaDestino As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents cboContaBancariaDestino As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblContaBancariaDestino As System.Windows.Forms.Label
    Friend WithEvents dtpData As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents picSistema As System.Windows.Forms.PictureBox

End Class
