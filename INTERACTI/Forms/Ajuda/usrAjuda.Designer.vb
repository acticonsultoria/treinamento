<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrAjuda
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.webAjuda = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'webAjuda
        '
        Me.webAjuda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webAjuda.Location = New System.Drawing.Point(0, 0)
        Me.webAjuda.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webAjuda.Name = "webAjuda"
        Me.webAjuda.Size = New System.Drawing.Size(596, 466)
        Me.webAjuda.TabIndex = 0
        '
        'usrAjuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.webAjuda)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "usrAjuda"
        Me.Size = New System.Drawing.Size(596, 466)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents webAjuda As System.Windows.Forms.WebBrowser

End Class
