<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadControleRelacionamento
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
        Dim grdFilho_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadControleRelacionamento))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdPai_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdFilho = New Janus.Windows.GridEX.GridEX()
        Me.grpControleFilho = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblControleFilho = New System.Windows.Forms.Label()
        Me.cboControleFilho = New Janus.Windows.EditControls.UIComboBox()
        Me.grdPai = New Janus.Windows.GridEX.GridEX()
        Me.grpControlePai = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblControlePai = New System.Windows.Forms.Label()
        Me.cboControlePai = New Janus.Windows.EditControls.UIComboBox()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdFilho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControleFilho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleFilho.SuspendLayout()
        CType(Me.grdPai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControlePai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControlePai.SuspendLayout()
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
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grdFilho)
        Me.pagLista.Controls.Add(Me.grpControleFilho)
        Me.pagLista.Controls.Add(Me.grdPai)
        Me.pagLista.Controls.Add(Me.grpControlePai)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 453)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Controle Dinâmico - Vínculo entre os Dados"
        '
        'grdFilho
        '
        Me.grdFilho.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdFilho.AlternatingColors = True
        Me.grdFilho.ColumnAutoResize = True
        grdFilho_DesignTimeLayout.LayoutString = resources.GetString("grdFilho_DesignTimeLayout.LayoutString")
        Me.grdFilho.DesignTimeLayout = grdFilho_DesignTimeLayout
        Me.grdFilho.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdFilho.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdFilho.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdFilho.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdFilho.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdFilho.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdFilho.GroupByBoxVisible = False
        Me.grdFilho.Location = New System.Drawing.Point(460, 76)
        Me.grdFilho.Name = "grdFilho"
        Me.grdFilho.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdFilho.RecordNavigator = True
        Me.grdFilho.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdFilho.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdFilho.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdFilho.Size = New System.Drawing.Size(445, 314)
        Me.grdFilho.TabIndex = 3
        Me.grdFilho.TabStop = False
        Me.grdFilho.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdFilho.VisualStyleManager = Me.vsmMain
        '
        'grpControleFilho
        '
        Me.grpControleFilho.BackColor = System.Drawing.Color.Transparent
        Me.grpControleFilho.Controls.Add(Me.lblControleFilho)
        Me.grpControleFilho.Controls.Add(Me.cboControleFilho)
        Me.grpControleFilho.Location = New System.Drawing.Point(460, 3)
        Me.grpControleFilho.Name = "grpControleFilho"
        Me.grpControleFilho.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleFilho.Size = New System.Drawing.Size(445, 64)
        Me.grpControleFilho.TabIndex = 1
        Me.grpControleFilho.VisualStyleManager = Me.vsmMain
        '
        'lblControleFilho
        '
        Me.lblControleFilho.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblControleFilho.AutoSize = True
        Me.lblControleFilho.Location = New System.Drawing.Point(6, 17)
        Me.lblControleFilho.Name = "lblControleFilho"
        Me.lblControleFilho.Size = New System.Drawing.Size(75, 14)
        Me.lblControleFilho.TabIndex = 0
        Me.lblControleFilho.Text = "Controle Filho:"
        '
        'cboControleFilho
        '
        Me.cboControleFilho.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboControleFilho.AutoSize = False
        Me.cboControleFilho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboControleFilho.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboControleFilho.Location = New System.Drawing.Point(9, 34)
        Me.cboControleFilho.Name = "cboControleFilho"
        Me.cboControleFilho.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboControleFilho.Size = New System.Drawing.Size(428, 20)
        Me.cboControleFilho.TabIndex = 1
        '
        'grdPai
        '
        Me.grdPai.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdPai.AlternatingColors = True
        Me.grdPai.ColumnAutoResize = True
        grdPai_DesignTimeLayout.LayoutString = resources.GetString("grdPai_DesignTimeLayout.LayoutString")
        Me.grdPai.DesignTimeLayout = grdPai_DesignTimeLayout
        Me.grdPai.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPai.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPai.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdPai.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPai.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPai.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPai.GroupByBoxVisible = False
        Me.grdPai.Location = New System.Drawing.Point(8, 76)
        Me.grdPai.Name = "grdPai"
        Me.grdPai.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPai.RecordNavigator = True
        Me.grdPai.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdPai.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdPai.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPai.Size = New System.Drawing.Size(443, 314)
        Me.grdPai.TabIndex = 2
        Me.grdPai.TabStop = False
        Me.grdPai.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPai.VisualStyleManager = Me.vsmMain
        '
        'grpControlePai
        '
        Me.grpControlePai.BackColor = System.Drawing.Color.Transparent
        Me.grpControlePai.Controls.Add(Me.lblControlePai)
        Me.grpControlePai.Controls.Add(Me.cboControlePai)
        Me.grpControlePai.Location = New System.Drawing.Point(8, 3)
        Me.grpControlePai.Name = "grpControlePai"
        Me.grpControlePai.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControlePai.Size = New System.Drawing.Size(443, 64)
        Me.grpControlePai.TabIndex = 0
        Me.grpControlePai.VisualStyleManager = Me.vsmMain
        '
        'lblControlePai
        '
        Me.lblControlePai.AutoSize = True
        Me.lblControlePai.Location = New System.Drawing.Point(6, 17)
        Me.lblControlePai.Name = "lblControlePai"
        Me.lblControlePai.Size = New System.Drawing.Size(67, 14)
        Me.lblControlePai.TabIndex = 0
        Me.lblControlePai.Text = "Controle Pai:"
        '
        'cboControlePai
        '
        Me.cboControlePai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboControlePai.AutoSize = False
        Me.cboControlePai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboControlePai.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboControlePai.Location = New System.Drawing.Point(9, 34)
        Me.cboControlePai.Name = "cboControlePai"
        Me.cboControlePai.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboControlePai.Size = New System.Drawing.Size(426, 20)
        Me.cboControlePai.TabIndex = 1
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 393)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 4
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(700, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
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
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrCadControleRelacionamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCadControleRelacionamento"
        Me.Size = New System.Drawing.Size(915, 476)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdFilho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControleFilho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleFilho.ResumeLayout(False)
        Me.grpControleFilho.PerformLayout()
        CType(Me.grdPai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControlePai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControlePai.ResumeLayout(False)
        Me.grpControlePai.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpControlePai As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdPai As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblControlePai As System.Windows.Forms.Label
    Friend WithEvents cboControlePai As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents grdFilho As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpControleFilho As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblControleFilho As System.Windows.Forms.Label
    Friend WithEvents cboControleFilho As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton

End Class
