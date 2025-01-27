<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrDshWorkflow
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
        Dim grdCaixaEntrada_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrDshWorkflow))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.spcCaixaEntrada = New System.Windows.Forms.SplitContainer()
        Me.btnConfigurarGridCaixaEntrada = New System.Windows.Forms.Button()
        Me.grdCaixaEntrada = New Janus.Windows.GridEX.GridEX()
        Me.txtMensagemCaixaEntrada = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.spcCaixaEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcCaixaEntrada.Panel1.SuspendLayout()
        Me.spcCaixaEntrada.Panel2.SuspendLayout()
        Me.spcCaixaEntrada.SuspendLayout()
        CType(Me.grdCaixaEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem, Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.spcCaixaEntrada)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Padding = New System.Windows.Forms.Padding(8)
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Caixa de Entrada"
        '
        'spcCaixaEntrada
        '
        Me.spcCaixaEntrada.BackColor = System.Drawing.Color.Transparent
        Me.spcCaixaEntrada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcCaixaEntrada.Location = New System.Drawing.Point(8, 8)
        Me.spcCaixaEntrada.Name = "spcCaixaEntrada"
        Me.spcCaixaEntrada.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcCaixaEntrada.Panel1
        '
        Me.spcCaixaEntrada.Panel1.Controls.Add(Me.btnConfigurarGridCaixaEntrada)
        Me.spcCaixaEntrada.Panel1.Controls.Add(Me.grdCaixaEntrada)
        '
        'spcCaixaEntrada.Panel2
        '
        Me.spcCaixaEntrada.Panel2.Controls.Add(Me.txtMensagemCaixaEntrada)
        Me.spcCaixaEntrada.Size = New System.Drawing.Size(897, 527)
        Me.spcCaixaEntrada.SplitterDistance = 353
        Me.spcCaixaEntrada.SplitterWidth = 8
        Me.spcCaixaEntrada.TabIndex = 9
        '
        'btnConfigurarGridCaixaEntrada
        '
        Me.btnConfigurarGridCaixaEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridCaixaEntrada.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridCaixaEntrada.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridCaixaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridCaixaEntrada.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGridCaixaEntrada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridCaixaEntrada.Location = New System.Drawing.Point(1, 336)
        Me.btnConfigurarGridCaixaEntrada.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridCaixaEntrada.Name = "btnConfigurarGridCaixaEntrada"
        Me.btnConfigurarGridCaixaEntrada.Size = New System.Drawing.Size(48, 15)
        Me.btnConfigurarGridCaixaEntrada.TabIndex = 9
        Me.btnConfigurarGridCaixaEntrada.TabStop = False
        Me.btnConfigurarGridCaixaEntrada.UseVisualStyleBackColor = False
        '
        'grdCaixaEntrada
        '
        Me.grdCaixaEntrada.AllowChildTableGroups = True
        Me.grdCaixaEntrada.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdCaixaEntrada.AlternatingColors = True
        Me.grdCaixaEntrada.AutoEdit = True
        Me.grdCaixaEntrada.ColumnAutoResize = True
        grdCaixaEntrada_DesignTimeLayout.LayoutString = resources.GetString("grdCaixaEntrada_DesignTimeLayout.LayoutString")
        Me.grdCaixaEntrada.DesignTimeLayout = grdCaixaEntrada_DesignTimeLayout
        Me.grdCaixaEntrada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCaixaEntrada.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdCaixaEntrada.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdCaixaEntrada.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdCaixaEntrada.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdCaixaEntrada.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdCaixaEntrada.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdCaixaEntrada.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdCaixaEntrada.FrozenColumns = 5
        Me.grdCaixaEntrada.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdCaixaEntrada.GroupByBoxVisible = False
        Me.grdCaixaEntrada.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdCaixaEntrada.Hierarchical = True
        Me.grdCaixaEntrada.Location = New System.Drawing.Point(0, 0)
        Me.grdCaixaEntrada.Name = "grdCaixaEntrada"
        Me.grdCaixaEntrada.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdCaixaEntrada.RecordNavigator = True
        Me.grdCaixaEntrada.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdCaixaEntrada.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdCaixaEntrada.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdCaixaEntrada.SelectedFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.[True]
        Me.grdCaixaEntrada.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdCaixaEntrada.Size = New System.Drawing.Size(897, 353)
        Me.grdCaixaEntrada.TabIndex = 5
        Me.grdCaixaEntrada.TabStop = False
        Me.grdCaixaEntrada.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdCaixaEntrada.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdCaixaEntrada.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdCaixaEntrada.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdCaixaEntrada.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdCaixaEntrada.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdCaixaEntrada.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdCaixaEntrada.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdCaixaEntrada.VisualStyleManager = Me.vsmMain
        '
        'txtMensagemCaixaEntrada
        '
        Me.txtMensagemCaixaEntrada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMensagemCaixaEntrada.Location = New System.Drawing.Point(0, 0)
        Me.txtMensagemCaixaEntrada.MaxLength = 0
        Me.txtMensagemCaixaEntrada.Multiline = True
        Me.txtMensagemCaixaEntrada.Name = "txtMensagemCaixaEntrada"
        Me.txtMensagemCaixaEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensagemCaixaEntrada.Size = New System.Drawing.Size(897, 166)
        Me.txtMensagemCaixaEntrada.TabIndex = 0
        '
        'pagDados
        '
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagLista"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Caixa de Saída"
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'usrDshWorkflow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrDshWorkflow"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        Me.spcCaixaEntrada.Panel1.ResumeLayout(False)
        Me.spcCaixaEntrada.Panel2.ResumeLayout(False)
        Me.spcCaixaEntrada.Panel2.PerformLayout()
        CType(Me.spcCaixaEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcCaixaEntrada.ResumeLayout(False)
        CType(Me.grdCaixaEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents spcCaixaEntrada As System.Windows.Forms.SplitContainer
    Friend WithEvents btnConfigurarGridCaixaEntrada As System.Windows.Forms.Button
    Friend WithEvents grdCaixaEntrada As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtMensagemCaixaEntrada As Janus.Windows.GridEX.EditControls.EditBox

End Class
