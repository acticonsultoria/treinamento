<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadControleAdicionar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadControleAdicionar))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnAdicionar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpMotivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLargura = New System.Windows.Forms.Label()
        Me.lblPosicaoY = New System.Windows.Forms.Label()
        Me.lblPosicaoX = New System.Windows.Forms.Label()
        Me.txtLargura = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtPosicaoY = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtPosicaoX = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboControle = New Janus.Windows.EditControls.UIComboBox()
        Me.lblControle = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMotivo.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(348, 193)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Controls.Add(Me.grpMotivo)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(346, 170)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Adicionar Controle"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnAdicionar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 110)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(330, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdicionar.Image = Global.INTERACTI.My.Resources.add
        Me.btnAdicionar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAdicionar.Location = New System.Drawing.Point(133, 17)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAdicionar.Size = New System.Drawing.Size(91, 23)
        Me.btnAdicionar.TabIndex = 0
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(230, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpMotivo
        '
        Me.grpMotivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMotivo.BackColor = System.Drawing.Color.Transparent
        Me.grpMotivo.Controls.Add(Me.lblLargura)
        Me.grpMotivo.Controls.Add(Me.lblPosicaoY)
        Me.grpMotivo.Controls.Add(Me.lblPosicaoX)
        Me.grpMotivo.Controls.Add(Me.txtLargura)
        Me.grpMotivo.Controls.Add(Me.txtPosicaoY)
        Me.grpMotivo.Controls.Add(Me.txtPosicaoX)
        Me.grpMotivo.Controls.Add(Me.cboControle)
        Me.grpMotivo.Controls.Add(Me.lblControle)
        Me.grpMotivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMotivo.Location = New System.Drawing.Point(8, 3)
        Me.grpMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMotivo.Name = "grpMotivo"
        Me.grpMotivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMotivo.Size = New System.Drawing.Size(330, 104)
        Me.grpMotivo.TabIndex = 0
        Me.grpMotivo.VisualStyleManager = Me.vsmMain
        '
        'lblLargura
        '
        Me.lblLargura.AutoSize = True
        Me.lblLargura.BackColor = System.Drawing.Color.Transparent
        Me.lblLargura.Location = New System.Drawing.Point(218, 57)
        Me.lblLargura.Name = "lblLargura"
        Me.lblLargura.Size = New System.Drawing.Size(48, 14)
        Me.lblLargura.TabIndex = 6
        Me.lblLargura.Text = "Largura:"
        '
        'lblPosicaoY
        '
        Me.lblPosicaoY.AutoSize = True
        Me.lblPosicaoY.BackColor = System.Drawing.Color.Transparent
        Me.lblPosicaoY.Location = New System.Drawing.Point(112, 57)
        Me.lblPosicaoY.Name = "lblPosicaoY"
        Me.lblPosicaoY.Size = New System.Drawing.Size(58, 14)
        Me.lblPosicaoY.TabIndex = 4
        Me.lblPosicaoY.Text = "Posição Y:"
        '
        'lblPosicaoX
        '
        Me.lblPosicaoX.AutoSize = True
        Me.lblPosicaoX.BackColor = System.Drawing.Color.Transparent
        Me.lblPosicaoX.Location = New System.Drawing.Point(6, 57)
        Me.lblPosicaoX.Name = "lblPosicaoX"
        Me.lblPosicaoX.Size = New System.Drawing.Size(58, 14)
        Me.lblPosicaoX.TabIndex = 2
        Me.lblPosicaoX.Text = "Posição X:"
        '
        'txtLargura
        '
        Me.txtLargura.DecimalDigits = 0
        Me.txtLargura.Location = New System.Drawing.Point(221, 74)
        Me.txtLargura.Name = "txtLargura"
        Me.txtLargura.Size = New System.Drawing.Size(100, 20)
        Me.txtLargura.TabIndex = 7
        Me.txtLargura.Text = "0"
        Me.txtLargura.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtPosicaoY
        '
        Me.txtPosicaoY.DecimalDigits = 0
        Me.txtPosicaoY.Location = New System.Drawing.Point(115, 74)
        Me.txtPosicaoY.Name = "txtPosicaoY"
        Me.txtPosicaoY.Size = New System.Drawing.Size(100, 20)
        Me.txtPosicaoY.TabIndex = 5
        Me.txtPosicaoY.Text = "0"
        Me.txtPosicaoY.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtPosicaoX
        '
        Me.txtPosicaoX.DecimalDigits = 0
        Me.txtPosicaoX.Location = New System.Drawing.Point(9, 74)
        Me.txtPosicaoX.Name = "txtPosicaoX"
        Me.txtPosicaoX.Size = New System.Drawing.Size(100, 20)
        Me.txtPosicaoX.TabIndex = 3
        Me.txtPosicaoX.Text = "0"
        Me.txtPosicaoX.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cboControle
        '
        Me.cboControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboControle.AutoSize = False
        Me.cboControle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboControle.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboControle.Location = New System.Drawing.Point(9, 34)
        Me.cboControle.Name = "cboControle"
        Me.cboControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboControle.Size = New System.Drawing.Size(312, 20)
        Me.cboControle.TabIndex = 1
        '
        'lblControle
        '
        Me.lblControle.AutoSize = True
        Me.lblControle.BackColor = System.Drawing.Color.Transparent
        Me.lblControle.Location = New System.Drawing.Point(6, 17)
        Me.lblControle.Name = "lblControle"
        Me.lblControle.Size = New System.Drawing.Size(50, 14)
        Me.lblControle.TabIndex = 0
        Me.lblControle.Text = "Controle:"
        '
        'frmCadControleAdicionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 207)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadControleAdicionar"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuração - Adicionar Controle"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMotivo.ResumeLayout(False)
        Me.grpMotivo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnAdicionar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpMotivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblControle As System.Windows.Forms.Label
    Friend WithEvents cboControle As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblLargura As System.Windows.Forms.Label
    Friend WithEvents lblPosicaoY As System.Windows.Forms.Label
    Friend WithEvents lblPosicaoX As System.Windows.Forms.Label
    Friend WithEvents txtLargura As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtPosicaoY As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtPosicaoX As Janus.Windows.GridEX.EditControls.NumericEditBox
End Class
