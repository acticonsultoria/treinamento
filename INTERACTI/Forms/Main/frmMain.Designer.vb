<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim UiStatusBarPanel1 As Janus.Windows.UI.StatusBar.UIStatusBarPanel = New Janus.Windows.UI.StatusBar.UIStatusBarPanel()
        Dim UiStatusBarPanel2 As Janus.Windows.UI.StatusBar.UIStatusBarPanel = New Janus.Windows.UI.StatusBar.UIStatusBarPanel()
        Dim UiStatusBarPanel3 As Janus.Windows.UI.StatusBar.UIStatusBarPanel = New Janus.Windows.UI.StatusBar.UIStatusBarPanel()
        Dim UiStatusBarPanel4 As Janus.Windows.UI.StatusBar.UIStatusBarPanel = New Janus.Windows.UI.StatusBar.UIStatusBarPanel()
        Dim UiStatusBarPanel5 As Janus.Windows.UI.StatusBar.UIStatusBarPanel = New Janus.Windows.UI.StatusBar.UIStatusBarPanel()
        Dim UiStatusBarPanel6 As Janus.Windows.UI.StatusBar.UIStatusBarPanel = New Janus.Windows.UI.StatusBar.UIStatusBarPanel()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.errInfo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tmrHora = New System.Windows.Forms.Timer(Me.components)
        Me.errMsg = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.stbMain = New Janus.Windows.UI.StatusBar.UIStatusBar()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagPrincipal = New Janus.Windows.UI.Tab.UITabPage()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.tmrAviso = New System.Windows.Forms.Timer(Me.components)
        Me.lblInformativo = New System.Windows.Forms.Label()
        Me.tmrBaseTeste = New System.Windows.Forms.Timer(Me.components)
        CType(Me.errInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errMsg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMain.SuspendLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagPrincipal.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'errInfo
        '
        Me.errInfo.ContainerControl = Me
        '
        'tmrHora
        '
        Me.tmrHora.Interval = 1000
        '
        'errMsg
        '
        Me.errMsg.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errMsg.ContainerControl = Me
        Me.errMsg.Icon = CType(resources.GetObject("errMsg.Icon"), System.Drawing.Icon)
        '
        'vsmMain
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.MenuColor = System.Drawing.Color.WhiteSmoke
        JanusColorScheme1.Name = "Scheme"
        JanusColorScheme1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme1.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme1)
        Me.vsmMain.DefaultColorScheme = Nothing
        '
        'stbMain
        '
        Me.stbMain.Location = New System.Drawing.Point(0, 454)
        Me.stbMain.Name = "stbMain"
        Me.stbMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        UiStatusBarPanel1.BorderColor = System.Drawing.Color.Empty
        UiStatusBarPanel1.DrawBorder = False
        UiStatusBarPanel1.Key = "pnlProgressBar"
        UiStatusBarPanel1.PanelType = Janus.Windows.UI.StatusBar.StatusBarPanelType.ProgressBar
        UiStatusBarPanel1.ProgressBarValue = 0
        UiStatusBarPanel1.Width = 200
        UiStatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        UiStatusBarPanel2.BorderColor = System.Drawing.Color.Empty
        UiStatusBarPanel2.DrawBorder = False
        UiStatusBarPanel2.Key = "pnlInfo"
        UiStatusBarPanel2.ProgressBarValue = 0
        UiStatusBarPanel2.Width = 502
        UiStatusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        UiStatusBarPanel3.BorderColor = System.Drawing.Color.Empty
        UiStatusBarPanel3.Key = "pnlEmpresa"
        UiStatusBarPanel3.ProgressBarValue = 0
        UiStatusBarPanel3.Visible = False
        UiStatusBarPanel3.Width = 10
        UiStatusBarPanel4.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        UiStatusBarPanel4.BorderColor = System.Drawing.Color.Empty
        UiStatusBarPanel4.Key = "pnlUsuario"
        UiStatusBarPanel4.ProgressBarValue = 0
        UiStatusBarPanel4.Visible = False
        UiStatusBarPanel4.Width = 10
        UiStatusBarPanel5.BorderColor = System.Drawing.Color.Empty
        UiStatusBarPanel5.Image = CType(resources.GetObject("UiStatusBarPanel5.Image"), System.Drawing.Image)
        UiStatusBarPanel5.Key = "pnlFuncaoCalculadora"
        UiStatusBarPanel5.ProgressBarValue = 0
        UiStatusBarPanel5.Visible = False
        UiStatusBarPanel5.Width = 23
        UiStatusBarPanel6.BorderColor = System.Drawing.Color.Empty
        UiStatusBarPanel6.Key = "pnlDataHora"
        UiStatusBarPanel6.ProgressBarValue = 0
        UiStatusBarPanel6.Visible = False
        UiStatusBarPanel6.Width = 110
        Me.stbMain.Panels.AddRange(New Janus.Windows.UI.StatusBar.UIStatusBarPanel() {UiStatusBarPanel1, UiStatusBarPanel2, UiStatusBarPanel3, UiStatusBarPanel4, UiStatusBarPanel5, UiStatusBarPanel6})
        Me.stbMain.Size = New System.Drawing.Size(725, 25)
        Me.stbMain.TabIndex = 16
        Me.stbMain.TabStop = False
        Me.stbMain.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
        '
        'tlpMain
        '
        Me.tlpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpMain.AutoScroll = True
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.tabMain, 0, 1)
        Me.tlpMain.Controls.Add(Me.mnuMain, 0, 0)
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.Padding = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Size = New System.Drawing.Size(725, 454)
        Me.tlpMain.TabIndex = 17
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Location = New System.Drawing.Point(10, 15)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowCloseButton = True
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(705, 428)
        Me.tabMain.TabIndex = 15
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagPrincipal})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'pagPrincipal
        '
        Me.pagPrincipal.AllowClose = False
        Me.pagPrincipal.Controls.Add(Me.picImage)
        Me.pagPrincipal.Icon = CType(resources.GetObject("pagPrincipal.Icon"), System.Drawing.Icon)
        Me.pagPrincipal.Location = New System.Drawing.Point(1, 23)
        Me.pagPrincipal.Name = "pagPrincipal"
        Me.pagPrincipal.Padding = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.pagPrincipal.Size = New System.Drawing.Size(703, 404)
        Me.pagPrincipal.TabStop = True
        '
        'picImage
        '
        Me.picImage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picImage.BackColor = System.Drawing.SystemColors.Window
        Me.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImage.Location = New System.Drawing.Point(8, 9)
        Me.picImage.Name = "picImage"
        Me.picImage.Padding = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.picImage.Size = New System.Drawing.Size(687, 386)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picImage.TabIndex = 0
        Me.picImage.TabStop = False
        Me.picImage.Visible = False
        '
        'mnuMain
        '
        Me.mnuMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mnuMain.BackColor = System.Drawing.Color.Transparent
        Me.mnuMain.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuMain.GripMargin = New System.Windows.Forms.Padding(6, 2, 0, 6)
        Me.mnuMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.mnuMain.Location = New System.Drawing.Point(7, 8)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(711, 4)
        Me.mnuMain.TabIndex = 1
        Me.mnuMain.Text = "MenuStrip1"
        '
        'tmrAviso
        '
        Me.tmrAviso.Interval = 6000
        '
        'lblInformativo
        '
        Me.lblInformativo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInformativo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblInformativo.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformativo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInformativo.Location = New System.Drawing.Point(7, 455)
        Me.lblInformativo.Name = "lblInformativo"
        Me.lblInformativo.Size = New System.Drawing.Size(174, 24)
        Me.lblInformativo.TabIndex = 21
        Me.lblInformativo.Text = "BASE TESTE"
        Me.lblInformativo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrBaseTeste
        '
        Me.tmrBaseTeste.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 479)
        Me.Controls.Add(Me.lblInformativo)
        Me.Controls.Add(Me.tlpMain)
        Me.Controls.Add(Me.stbMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.errInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errMsg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagPrincipal.ResumeLayout(False)
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents errInfo As System.Windows.Forms.ErrorProvider
    Friend WithEvents tmrHora As System.Windows.Forms.Timer
    Friend WithEvents errMsg As System.Windows.Forms.ErrorProvider
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents stbMain As Janus.Windows.UI.StatusBar.UIStatusBar
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagPrincipal As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents tmrAviso As System.Windows.Forms.Timer
    Friend WithEvents lblInformativo As System.Windows.Forms.Label
    Friend WithEvents tmrBaseTeste As System.Windows.Forms.Timer

End Class
