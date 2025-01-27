<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntEscolherImpressora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIntEscolherImpressora))
        Me.lblSistema = New System.Windows.Forms.Label()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.ofaMain = New Janus.Windows.Ribbon.OfficeFormAdorner(Me.components)
        Me.cboImpressora = New Janus.Windows.EditControls.UIComboBox()
        Me.lblImpressora = New System.Windows.Forms.Label()
        CType(Me.ofaMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSistema
        '
        Me.lblSistema.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSistema.Location = New System.Drawing.Point(150, 20)
        Me.lblSistema.Name = "lblSistema"
        Me.lblSistema.Size = New System.Drawing.Size(269, 14)
        Me.lblSistema.TabIndex = 6
        Me.lblSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(220, 52)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 12
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(123, 52)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(91, 23)
        Me.btnImprimir.TabIndex = 11
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'ofaMain
        '
        Me.ofaMain.Form = Me
        Me.ofaMain.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Silver
        Me.ofaMain.Office2007CustomColor = System.Drawing.Color.Empty
        '
        'cboImpressora
        '
        Me.cboImpressora.AutoSize = False
        Me.cboImpressora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboImpressora.Location = New System.Drawing.Point(15, 26)
        Me.cboImpressora.Name = "cboImpressora"
        Me.cboImpressora.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboImpressora.Size = New System.Drawing.Size(296, 20)
        Me.cboImpressora.TabIndex = 14
        '
        'lblImpressora
        '
        Me.lblImpressora.AutoSize = True
        Me.lblImpressora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblImpressora.Location = New System.Drawing.Point(12, 9)
        Me.lblImpressora.Name = "lblImpressora"
        Me.lblImpressora.Size = New System.Drawing.Size(64, 14)
        Me.lblImpressora.TabIndex = 13
        Me.lblImpressora.Text = "Impressora:"
        '
        'frmIntEscolherImpressora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(321, 85)
        Me.Controls.Add(Me.cboImpressora)
        Me.Controls.Add(Me.lblImpressora)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblSistema)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIntEscolherImpressora"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Escolha a Impressora"
        CType(Me.ofaMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSistema As System.Windows.Forms.Label
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents ofaMain As Janus.Windows.Ribbon.OfficeFormAdorner
    Friend WithEvents cboImpressora As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblImpressora As System.Windows.Forms.Label

End Class
