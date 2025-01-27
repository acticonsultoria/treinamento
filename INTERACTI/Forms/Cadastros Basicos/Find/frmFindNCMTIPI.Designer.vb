<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindNCMTIPI
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
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem7 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem8 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem9 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem10 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFindNCMTIPI))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.trvMain = New System.Windows.Forms.TreeView()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblSubposicao2 = New System.Windows.Forms.Label()
        Me.lblSubposicao1 = New System.Windows.Forms.Label()
        Me.lblPosicao = New System.Windows.Forms.Label()
        Me.lblCapitulo = New System.Windows.Forms.Label()
        Me.cboItem = New Janus.Windows.EditControls.UIComboBox()
        Me.cboSubposicao2 = New Janus.Windows.EditControls.UIComboBox()
        Me.cboSubposicao1 = New Janus.Windows.EditControls.UIComboBox()
        Me.cboPosicao = New Janus.Windows.EditControls.UIComboBox()
        Me.cboCapitulo = New Janus.Windows.EditControls.UIComboBox()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
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
        'trvMain
        '
        Me.trvMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trvMain.CheckBoxes = True
        Me.trvMain.FullRowSelect = True
        Me.trvMain.ItemHeight = 20
        Me.trvMain.Location = New System.Drawing.Point(8, 165)
        Me.trvMain.Name = "trvMain"
        Me.trvMain.ShowLines = False
        Me.trvMain.ShowNodeToolTips = True
        Me.trvMain.Size = New System.Drawing.Size(897, 313)
        Me.trvMain.TabIndex = 1
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblItem)
        Me.grpDados.Controls.Add(Me.lblSubposicao2)
        Me.grpDados.Controls.Add(Me.lblSubposicao1)
        Me.grpDados.Controls.Add(Me.lblPosicao)
        Me.grpDados.Controls.Add(Me.lblCapitulo)
        Me.grpDados.Controls.Add(Me.cboItem)
        Me.grpDados.Controls.Add(Me.cboSubposicao2)
        Me.grpDados.Controls.Add(Me.cboSubposicao1)
        Me.grpDados.Controls.Add(Me.cboPosicao)
        Me.grpDados.Controls.Add(Me.cboCapitulo)
        Me.grpDados.Location = New System.Drawing.Point(8, 4)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 152)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(6, 124)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(29, 14)
        Me.lblItem.TabIndex = 8
        Me.lblItem.Text = "Item:"
        '
        'lblSubposicao2
        '
        Me.lblSubposicao2.AutoSize = True
        Me.lblSubposicao2.Location = New System.Drawing.Point(6, 98)
        Me.lblSubposicao2.Name = "lblSubposicao2"
        Me.lblSubposicao2.Size = New System.Drawing.Size(76, 14)
        Me.lblSubposicao2.TabIndex = 6
        Me.lblSubposicao2.Text = "Subposição 2:"
        '
        'lblSubposicao1
        '
        Me.lblSubposicao1.AutoSize = True
        Me.lblSubposicao1.Location = New System.Drawing.Point(6, 72)
        Me.lblSubposicao1.Name = "lblSubposicao1"
        Me.lblSubposicao1.Size = New System.Drawing.Size(76, 14)
        Me.lblSubposicao1.TabIndex = 4
        Me.lblSubposicao1.Text = "Subposição 1:"
        '
        'lblPosicao
        '
        Me.lblPosicao.AutoSize = True
        Me.lblPosicao.Location = New System.Drawing.Point(6, 46)
        Me.lblPosicao.Name = "lblPosicao"
        Me.lblPosicao.Size = New System.Drawing.Size(48, 14)
        Me.lblPosicao.TabIndex = 2
        Me.lblPosicao.Text = "Posição:"
        '
        'lblCapitulo
        '
        Me.lblCapitulo.AutoSize = True
        Me.lblCapitulo.Location = New System.Drawing.Point(6, 20)
        Me.lblCapitulo.Name = "lblCapitulo"
        Me.lblCapitulo.Size = New System.Drawing.Size(48, 14)
        Me.lblCapitulo.TabIndex = 0
        Me.lblCapitulo.Text = "Capítulo:"
        '
        'cboItem
        '
        Me.cboItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboItem.AutoSize = False
        Me.cboItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboItem.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboItem.Location = New System.Drawing.Point(105, 121)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboItem.Size = New System.Drawing.Size(783, 20)
        Me.cboItem.TabIndex = 9
        '
        'cboSubposicao2
        '
        Me.cboSubposicao2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSubposicao2.AutoSize = False
        Me.cboSubposicao2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboSubposicao2.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboSubposicao2.Location = New System.Drawing.Point(105, 95)
        Me.cboSubposicao2.Name = "cboSubposicao2"
        Me.cboSubposicao2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSubposicao2.Size = New System.Drawing.Size(783, 20)
        Me.cboSubposicao2.TabIndex = 7
        '
        'cboSubposicao1
        '
        Me.cboSubposicao1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSubposicao1.AutoSize = False
        Me.cboSubposicao1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "SIM"
        UiComboBoxItem5.Value = True
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "NÃO"
        UiComboBoxItem6.Value = False
        Me.cboSubposicao1.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboSubposicao1.Location = New System.Drawing.Point(105, 69)
        Me.cboSubposicao1.Name = "cboSubposicao1"
        Me.cboSubposicao1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSubposicao1.Size = New System.Drawing.Size(783, 20)
        Me.cboSubposicao1.TabIndex = 5
        '
        'cboPosicao
        '
        Me.cboPosicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPosicao.AutoSize = False
        Me.cboPosicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem7.FormatStyle.Alpha = 0
        UiComboBoxItem7.IsSeparator = False
        UiComboBoxItem7.Text = "SIM"
        UiComboBoxItem7.Value = True
        UiComboBoxItem8.FormatStyle.Alpha = 0
        UiComboBoxItem8.IsSeparator = False
        UiComboBoxItem8.Text = "NÃO"
        UiComboBoxItem8.Value = False
        Me.cboPosicao.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem7, UiComboBoxItem8})
        Me.cboPosicao.Location = New System.Drawing.Point(105, 43)
        Me.cboPosicao.Name = "cboPosicao"
        Me.cboPosicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboPosicao.Size = New System.Drawing.Size(783, 20)
        Me.cboPosicao.TabIndex = 3
        '
        'cboCapitulo
        '
        Me.cboCapitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCapitulo.AutoSize = False
        Me.cboCapitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem9.FormatStyle.Alpha = 0
        UiComboBoxItem9.IsSeparator = False
        UiComboBoxItem9.Text = "SIM"
        UiComboBoxItem9.Value = True
        UiComboBoxItem10.FormatStyle.Alpha = 0
        UiComboBoxItem10.IsSeparator = False
        UiComboBoxItem10.Text = "NÃO"
        UiComboBoxItem10.Value = False
        Me.cboCapitulo.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem9, UiComboBoxItem10})
        Me.cboCapitulo.Location = New System.Drawing.Point(105, 17)
        Me.cboCapitulo.Name = "cboCapitulo"
        Me.cboCapitulo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCapitulo.Size = New System.Drawing.Size(783, 20)
        Me.cboCapitulo.TabIndex = 1
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 481)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmFindNCMTIPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 541)
        Me.Controls.Add(Me.grpControl)
        Me.Controls.Add(Me.trvMain)
        Me.Controls.Add(Me.grpDados)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFindNCMTIPI"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "NCM - Nomenclatura Comum do Mercosul"
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents trvMain As System.Windows.Forms.TreeView
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents lblSubposicao2 As System.Windows.Forms.Label
    Friend WithEvents lblSubposicao1 As System.Windows.Forms.Label
    Friend WithEvents lblPosicao As System.Windows.Forms.Label
    Friend WithEvents lblCapitulo As System.Windows.Forms.Label
    Friend WithEvents cboItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboSubposicao2 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboSubposicao1 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboPosicao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboCapitulo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
End Class
