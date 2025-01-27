<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenPedidoEscolherOrdemProducao
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
        Dim grdOrdemProducaoVisualizar_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenOrcamentoEscolherOrdemProducao))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grdOrdemProducaoVisualizar = New Janus.Windows.GridEX.GridEX()
        CType(Me.grdOrdemProducaoVisualizar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'grdOrdemProducaoVisualizar
        '
        Me.grdOrdemProducaoVisualizar.AlternatingColors = True
        Me.grdOrdemProducaoVisualizar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdOrdemProducaoVisualizar_DesignTimeLayout.LayoutString = resources.GetString("grdOrdemProducaoVisualizar_DesignTimeLayout.LayoutString")
        Me.grdOrdemProducaoVisualizar.DesignTimeLayout = grdOrdemProducaoVisualizar_DesignTimeLayout
        Me.grdOrdemProducaoVisualizar.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrdemProducaoVisualizar.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed
        Me.grdOrdemProducaoVisualizar.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrdemProducaoVisualizar.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOrdemProducaoVisualizar.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrdemProducaoVisualizar.GroupByBoxVisible = False
        Me.grdOrdemProducaoVisualizar.Location = New System.Drawing.Point(1, 0)
        Me.grdOrdemProducaoVisualizar.Name = "grdOrdemProducaoVisualizar"
        Me.grdOrdemProducaoVisualizar.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrdemProducaoVisualizar.RecordNavigator = True
        Me.grdOrdemProducaoVisualizar.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOrdemProducaoVisualizar.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrdemProducaoVisualizar.Size = New System.Drawing.Size(319, 215)
        Me.grdOrdemProducaoVisualizar.TabIndex = 4
        Me.grdOrdemProducaoVisualizar.TabStop = False
        Me.grdOrdemProducaoVisualizar.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrdemProducaoVisualizar.VisualStyleManager = Me.vsmMain
        '
        'frmVenOrcamentoEscolherOrdemProducao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 215)
        Me.Controls.Add(Me.grdOrdemProducaoVisualizar)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVenOrcamentoEscolherOrdemProducao"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Escolher Ordem de Produção para Visualizar"
        CType(Me.grdOrdemProducaoVisualizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grdOrdemProducaoVisualizar As Janus.Windows.GridEX.GridEX
End Class
