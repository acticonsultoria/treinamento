<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrdPlanejamentoSequenciamento
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
        Dim grdProcesso_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdProcesso_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdPlanejamentoSequenciamento))
        Dim grdProcesso_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdProcesso = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboMaquina = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMaquina = New System.Windows.Forms.Label()
        Me.cboFuncionarioFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFuncionarioFiltro = New System.Windows.Forms.Label()
        Me.cboCentroTrabalhoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroTrabalhoFiltro = New System.Windows.Forms.Label()
        Me.jstMain = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.pagSintetico = New Janus.Windows.UI.Tab.UITabPage()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdProcesso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
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
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(966, 459)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.grdProcesso)
        Me.pagListagem.Controls.Add(Me.grpControl2)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(964, 436)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Sequenciamento"
        '
        'grdProcesso
        '
        Me.grdProcesso.AlternatingColors = True
        Me.grdProcesso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdProcesso_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdProcesso_DesignTimeLayout_Reference_0.Instance"), Object)
        grdProcesso_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdProcesso_DesignTimeLayout_Reference_1.Instance"), Object)
        grdProcesso_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdProcesso_DesignTimeLayout_Reference_0, grdProcesso_DesignTimeLayout_Reference_1})
        grdProcesso_DesignTimeLayout.LayoutString = resources.GetString("grdProcesso_DesignTimeLayout.LayoutString")
        Me.grdProcesso.DesignTimeLayout = grdProcesso_DesignTimeLayout
        Me.grdProcesso.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdProcesso.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdProcesso.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdProcesso.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdProcesso.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdProcesso.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdProcesso.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdProcesso.GroupByBoxVisible = False
        Me.grdProcesso.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdProcesso.Location = New System.Drawing.Point(8, 78)
        Me.grdProcesso.Name = "grdProcesso"
        Me.grdProcesso.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdProcesso.RecordNavigator = True
        Me.grdProcesso.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdProcesso.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdProcesso.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdProcesso.Size = New System.Drawing.Size(948, 294)
        Me.grdProcesso.TabIndex = 5
        Me.grdProcesso.TabStop = False
        Me.grdProcesso.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdProcesso.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdProcesso.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdProcesso.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdProcesso.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(9, 378)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(948, 51)
        Me.grpControl2.TabIndex = 11
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(851, 18)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 11
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboMaquina)
        Me.grpFiltro.Controls.Add(Me.lblMaquina)
        Me.grpFiltro.Controls.Add(Me.cboFuncionarioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFuncionarioFiltro)
        Me.grpFiltro.Controls.Add(Me.cboCentroTrabalhoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCentroTrabalhoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(948, 69)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboMaquina
        '
        Me.cboMaquina.AutoSize = False
        Me.cboMaquina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboMaquina.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboMaquina.Location = New System.Drawing.Point(625, 33)
        Me.cboMaquina.Name = "cboMaquina"
        Me.cboMaquina.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMaquina.Size = New System.Drawing.Size(229, 20)
        Me.cboMaquina.TabIndex = 5
        '
        'lblMaquina
        '
        Me.lblMaquina.AutoSize = True
        Me.lblMaquina.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMaquina.Location = New System.Drawing.Point(622, 17)
        Me.lblMaquina.Name = "lblMaquina"
        Me.lblMaquina.Size = New System.Drawing.Size(50, 14)
        Me.lblMaquina.TabIndex = 4
        Me.lblMaquina.Text = "Máquina:"
        '
        'cboFuncionarioFiltro
        '
        Me.cboFuncionarioFiltro.AutoSize = False
        Me.cboFuncionarioFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboFuncionarioFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboFuncionarioFiltro.Location = New System.Drawing.Point(13, 33)
        Me.cboFuncionarioFiltro.Name = "cboFuncionarioFiltro"
        Me.cboFuncionarioFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFuncionarioFiltro.Size = New System.Drawing.Size(371, 20)
        Me.cboFuncionarioFiltro.TabIndex = 1
        '
        'lblFuncionarioFiltro
        '
        Me.lblFuncionarioFiltro.AutoSize = True
        Me.lblFuncionarioFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFuncionarioFiltro.Location = New System.Drawing.Point(10, 17)
        Me.lblFuncionarioFiltro.Name = "lblFuncionarioFiltro"
        Me.lblFuncionarioFiltro.Size = New System.Drawing.Size(66, 14)
        Me.lblFuncionarioFiltro.TabIndex = 0
        Me.lblFuncionarioFiltro.Text = "Funcionário:"
        '
        'cboCentroTrabalhoFiltro
        '
        Me.cboCentroTrabalhoFiltro.AutoSize = False
        Me.cboCentroTrabalhoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        UiComboBoxItem5.Text = "SIM"
        UiComboBoxItem5.Value = True
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        UiComboBoxItem6.Text = "NÃO"
        UiComboBoxItem6.Value = False
        Me.cboCentroTrabalhoFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboCentroTrabalhoFiltro.Location = New System.Drawing.Point(390, 33)
        Me.cboCentroTrabalhoFiltro.Name = "cboCentroTrabalhoFiltro"
        Me.cboCentroTrabalhoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroTrabalhoFiltro.Size = New System.Drawing.Size(229, 20)
        Me.cboCentroTrabalhoFiltro.TabIndex = 3
        '
        'lblCentroTrabalhoFiltro
        '
        Me.lblCentroTrabalhoFiltro.AutoSize = True
        Me.lblCentroTrabalhoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCentroTrabalhoFiltro.Location = New System.Drawing.Point(387, 17)
        Me.lblCentroTrabalhoFiltro.Name = "lblCentroTrabalhoFiltro"
        Me.lblCentroTrabalhoFiltro.Size = New System.Drawing.Size(87, 14)
        Me.lblCentroTrabalhoFiltro.TabIndex = 2
        Me.lblCentroTrabalhoFiltro.Text = "Centro Trabalho:"
        '
        'jstMain
        '
        Me.jstMain.AutoPopDelay = 60000
        Me.jstMain.ImageList = Nothing
        Me.jstMain.ShowAlways = True
        '
        'pagSintetico
        '
        Me.pagSintetico.Location = New System.Drawing.Point(1, 22)
        Me.pagSintetico.Name = "pagSintetico"
        Me.pagSintetico.Size = New System.Drawing.Size(946, 291)
        Me.pagSintetico.TabStop = True
        Me.pagSintetico.Text = "Sintético"
        '
        'Timer1
        '
        '
        'usrPrdPlanejamentoSequenciamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrPrdPlanejamentoSequenciamento"
        Me.Size = New System.Drawing.Size(966, 459)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdProcesso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents jstMain As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents lblCentroTrabalhoFiltro As System.Windows.Forms.Label
    Friend WithEvents pagSintetico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdProcesso As Janus.Windows.GridEX.GridEX
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cboCentroTrabalhoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboFuncionarioFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFuncionarioFiltro As System.Windows.Forms.Label
    Friend WithEvents cboMaquina As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMaquina As System.Windows.Forms.Label

End Class
