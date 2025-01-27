<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCfgBancoContaSaldoInicial
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCfgBancoContaSaldoInicial))
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpData = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.btnCadastrarContaBancaria = New System.Windows.Forms.Button()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.txtSaldo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboContaBancaria = New Janus.Windows.EditControls.UIComboBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblContaBancaria = New System.Windows.Forms.Label()
        Me.picDinheiro = New System.Windows.Forms.PictureBox()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.picDinheiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme2.Name = "Scheme"
        JanusColorScheme2.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme2.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme2)
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox3.Controls.Add(Me.btnSalvar)
        Me.UiGroupBox3.Controls.Add(Me.btnSair)
        Me.UiGroupBox3.Location = New System.Drawing.Point(13, 134)
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
        Me.btnSalvar.Location = New System.Drawing.Point(291, 17)
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
        Me.btnSair.Location = New System.Drawing.Point(388, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.dtpData)
        Me.UiGroupBox1.Controls.Add(Me.btnCadastrarContaBancaria)
        Me.UiGroupBox1.Controls.Add(Me.lblSaldo)
        Me.UiGroupBox1.Controls.Add(Me.txtSaldo)
        Me.UiGroupBox1.Controls.Add(Me.cboContaBancaria)
        Me.UiGroupBox1.Controls.Add(Me.lblData)
        Me.UiGroupBox1.Controls.Add(Me.lblContaBancaria)
        Me.UiGroupBox1.Location = New System.Drawing.Point(157, 8)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(345, 104)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'dtpData
        '
        '
        '
        '
        Me.dtpData.DropDownCalendar.Name = ""
        Me.dtpData.Location = New System.Drawing.Point(9, 74)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(95, 20)
        Me.dtpData.TabIndex = 4
        '
        'btnCadastrarContaBancaria
        '
        Me.btnCadastrarContaBancaria.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaBancaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaBancaria.Image = Global.INTERACTI.My.Resources.add
        Me.btnCadastrarContaBancaria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaBancaria.Location = New System.Drawing.Point(9, 18)
        Me.btnCadastrarContaBancaria.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaBancaria.Name = "btnCadastrarContaBancaria"
        Me.btnCadastrarContaBancaria.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaBancaria.TabIndex = 0
        Me.btnCadastrarContaBancaria.TabStop = False
        Me.btnCadastrarContaBancaria.UseVisualStyleBackColor = True
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(107, 57)
        Me.lblSaldo.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(37, 14)
        Me.lblSaldo.TabIndex = 5
        Me.lblSaldo.Text = "Saldo:"
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(110, 74)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldo.TabIndex = 6
        Me.txtSaldo.Text = "0,00"
        Me.txtSaldo.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'cboContaBancaria
        '
        Me.cboContaBancaria.AutoSize = False
        Me.cboContaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboContaBancaria.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboContaBancaria.Location = New System.Drawing.Point(9, 34)
        Me.cboContaBancaria.Name = "cboContaBancaria"
        Me.cboContaBancaria.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaBancaria.Size = New System.Drawing.Size(326, 20)
        Me.cboContaBancaria.TabIndex = 2
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(6, 57)
        Me.lblData.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(32, 14)
        Me.lblData.TabIndex = 3
        Me.lblData.Text = "Data:"
        '
        'lblContaBancaria
        '
        Me.lblContaBancaria.AutoSize = True
        Me.lblContaBancaria.Location = New System.Drawing.Point(25, 17)
        Me.lblContaBancaria.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblContaBancaria.Name = "lblContaBancaria"
        Me.lblContaBancaria.Size = New System.Drawing.Size(84, 14)
        Me.lblContaBancaria.TabIndex = 1
        Me.lblContaBancaria.Text = "Conta Bancária:"
        '
        'picDinheiro
        '
        Me.picDinheiro.Image = Global.INTERACTI.My.Resources.dinheiro2
        Me.picDinheiro.Location = New System.Drawing.Point(13, 6)
        Me.picDinheiro.Name = "picDinheiro"
        Me.picDinheiro.Size = New System.Drawing.Size(130, 128)
        Me.picDinheiro.TabIndex = 9
        Me.picDinheiro.TabStop = False
        '
        'usrCfgBancoContaSaldoInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.picDinheiro)
        Me.Controls.Add(Me.UiGroupBox3)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCfgBancoContaSaldoInicial"
        Me.Size = New System.Drawing.Size(516, 197)
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.picDinheiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picDinheiro As System.Windows.Forms.PictureBox
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblContaBancaria As System.Windows.Forms.Label
    Friend WithEvents cboContaBancaria As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents btnCadastrarContaBancaria As System.Windows.Forms.Button
    Friend WithEvents dtpData As Janus.Windows.CalendarCombo.CalendarCombo

End Class
