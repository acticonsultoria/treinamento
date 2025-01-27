<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrdCenarioConfigurarDias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrdCenarioConfigurarDias))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim grdPeriodo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdPeriodo_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcluirSabados = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluirDomingos = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluirFDS = New Janus.Windows.EditControls.UIButton()
        Me.cboCentroTrabalho = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCentroTrabalho = New System.Windows.Forms.Label()
        Me.cboMaquina = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMaquina = New System.Windows.Forms.Label()
        Me.dtpPeriodo = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.grdPeriodo = New Janus.Windows.GridEX.GridEX()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grdPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(4, 396)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(594, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(397, 17)
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
        Me.btnSair.Location = New System.Drawing.Point(494, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.btnExcluirSabados)
        Me.grpDados.Controls.Add(Me.btnExcluirDomingos)
        Me.grpDados.Controls.Add(Me.btnExcluirFDS)
        Me.grpDados.Controls.Add(Me.cboCentroTrabalho)
        Me.grpDados.Controls.Add(Me.lblCentroTrabalho)
        Me.grpDados.Controls.Add(Me.cboMaquina)
        Me.grpDados.Controls.Add(Me.lblMaquina)
        Me.grpDados.Controls.Add(Me.dtpPeriodo)
        Me.grpDados.Controls.Add(Me.lblPeriodo)
        Me.grpDados.Controls.Add(Me.grdPeriodo)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(4, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(594, 387)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'btnExcluirSabados
        '
        Me.btnExcluirSabados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirSabados.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirSabados.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirSabados.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnExcluirSabados.Location = New System.Drawing.Point(6, 300)
        Me.btnExcluirSabados.Name = "btnExcluirSabados"
        Me.btnExcluirSabados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirSabados.Size = New System.Drawing.Size(157, 23)
        Me.btnExcluirSabados.TabIndex = 3
        Me.btnExcluirSabados.Text = "Excluir Sábados"
        Me.btnExcluirSabados.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluirDomingos
        '
        Me.btnExcluirDomingos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirDomingos.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirDomingos.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirDomingos.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnExcluirDomingos.Location = New System.Drawing.Point(6, 329)
        Me.btnExcluirDomingos.Name = "btnExcluirDomingos"
        Me.btnExcluirDomingos.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirDomingos.Size = New System.Drawing.Size(157, 23)
        Me.btnExcluirDomingos.TabIndex = 4
        Me.btnExcluirDomingos.Text = "Excluir Domingos"
        Me.btnExcluirDomingos.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluirFDS
        '
        Me.btnExcluirFDS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirFDS.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirFDS.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirFDS.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnExcluirFDS.Location = New System.Drawing.Point(5, 358)
        Me.btnExcluirFDS.Name = "btnExcluirFDS"
        Me.btnExcluirFDS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirFDS.Size = New System.Drawing.Size(157, 23)
        Me.btnExcluirFDS.TabIndex = 5
        Me.btnExcluirFDS.Text = "Excluir Finais de Semana"
        Me.btnExcluirFDS.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboCentroTrabalho
        '
        Me.cboCentroTrabalho.AutoSize = False
        Me.cboCentroTrabalho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboCentroTrabalho.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboCentroTrabalho.Location = New System.Drawing.Point(9, 34)
        Me.cboCentroTrabalho.Name = "cboCentroTrabalho"
        Me.cboCentroTrabalho.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCentroTrabalho.Size = New System.Drawing.Size(204, 20)
        Me.cboCentroTrabalho.TabIndex = 0
        '
        'lblCentroTrabalho
        '
        Me.lblCentroTrabalho.AutoSize = True
        Me.lblCentroTrabalho.Location = New System.Drawing.Point(6, 17)
        Me.lblCentroTrabalho.Name = "lblCentroTrabalho"
        Me.lblCentroTrabalho.Size = New System.Drawing.Size(102, 14)
        Me.lblCentroTrabalho.TabIndex = 0
        Me.lblCentroTrabalho.Text = "Centro de Trabalho:"
        '
        'cboMaquina
        '
        Me.cboMaquina.AutoSize = False
        Me.cboMaquina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "SIM"
        UiComboBoxItem3.Value = True
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        UiComboBoxItem4.Text = "NÃO"
        UiComboBoxItem4.Value = False
        Me.cboMaquina.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboMaquina.Location = New System.Drawing.Point(9, 76)
        Me.cboMaquina.Name = "cboMaquina"
        Me.cboMaquina.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMaquina.Size = New System.Drawing.Size(204, 20)
        Me.cboMaquina.TabIndex = 1
        '
        'lblMaquina
        '
        Me.lblMaquina.AutoSize = True
        Me.lblMaquina.Location = New System.Drawing.Point(6, 59)
        Me.lblMaquina.Name = "lblMaquina"
        Me.lblMaquina.Size = New System.Drawing.Size(50, 14)
        Me.lblMaquina.TabIndex = 2
        Me.lblMaquina.Text = "Máquina:"
        '
        'dtpPeriodo
        '
        Me.dtpPeriodo.CustomFormat = "MM/yyyy"
        Me.dtpPeriodo.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.dtpPeriodo.DropDownCalendar.Name = ""
        Me.dtpPeriodo.Location = New System.Drawing.Point(9, 118)
        Me.dtpPeriodo.Name = "dtpPeriodo"
        Me.dtpPeriodo.Size = New System.Drawing.Size(69, 20)
        Me.dtpPeriodo.TabIndex = 2
        Me.dtpPeriodo.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Location = New System.Drawing.Point(6, 101)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(46, 14)
        Me.lblPeriodo.TabIndex = 4
        Me.lblPeriodo.Text = "Período:"
        '
        'grdPeriodo
        '
        Me.grdPeriodo.AlternatingColors = True
        Me.grdPeriodo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdPeriodo_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdPeriodo_DesignTimeLayout_Reference_0.Instance"), Object)
        grdPeriodo_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdPeriodo_DesignTimeLayout_Reference_0})
        grdPeriodo_DesignTimeLayout.LayoutString = resources.GetString("grdPeriodo_DesignTimeLayout.LayoutString")
        Me.grdPeriodo.DesignTimeLayout = grdPeriodo_DesignTimeLayout
        Me.grdPeriodo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPeriodo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPeriodo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdPeriodo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPeriodo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPeriodo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPeriodo.GroupByBoxVisible = False
        Me.grdPeriodo.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdPeriodo.Location = New System.Drawing.Point(219, 9)
        Me.grdPeriodo.Name = "grdPeriodo"
        Me.grdPeriodo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPeriodo.RecordNavigator = True
        Me.grdPeriodo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdPeriodo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPeriodo.Size = New System.Drawing.Size(369, 370)
        Me.grdPeriodo.TabIndex = 6
        Me.grdPeriodo.TabStop = False
        Me.grdPeriodo.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdPeriodo.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPeriodo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPeriodo.VisualStyleManager = Me.vsmMain
        '
        'frmPrdCenarioConfigurarDias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 453)
        Me.Controls.Add(Me.grpDados)
        Me.Controls.Add(Me.grpControl2)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrdCenarioConfigurarDias"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar Dias"
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grdPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdPeriodo As Janus.Windows.GridEX.GridEX
    Friend WithEvents dtpPeriodo As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents cboMaquina As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMaquina As System.Windows.Forms.Label
    Friend WithEvents cboCentroTrabalho As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroTrabalho As System.Windows.Forms.Label
    Private WithEvents btnExcluirSabados As Janus.Windows.EditControls.UIButton
    Private WithEvents btnExcluirDomingos As Janus.Windows.EditControls.UIButton
    Private WithEvents btnExcluirFDS As Janus.Windows.EditControls.UIButton
End Class
