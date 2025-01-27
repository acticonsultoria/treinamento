<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrdCalendario
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
        Dim JanusColorScheme3 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdCalendario))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.hprAjuda = New System.Windows.Forms.HelpProvider()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDiaSemana = New System.Windows.Forms.Label()
        Me.chkIncluirDomingo = New System.Windows.Forms.CheckBox()
        Me.chkIncluirSabado = New System.Windows.Forms.CheckBox()
        Me.txtMaquinaFiltro = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblMaquinaFiltro = New System.Windows.Forms.Label()
        Me.lblPeriodoFiltro = New System.Windows.Forms.Label()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.cboDiaSemana = New Janus.Windows.EditControls.UIComboBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnPlanejamento = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluirProduto = New Janus.Windows.EditControls.UIButton()
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme3.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme3.Name = "Scheme"
        JanusColorScheme3.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme3.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme3.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme3)
        '
        'pagListagem
        '
        Me.pagListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.UiGroupBox3)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 24)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(1089, 575)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Calendário"
        '
        'grdListagem
        '
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.DynamicFiltering = True
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(10, 78)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
        Me.grdListagem.Size = New System.Drawing.Size(1069, 430)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboDiaSemana)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDiaSemana)
        Me.grpFiltro.Controls.Add(Me.chkIncluirDomingo)
        Me.grpFiltro.Controls.Add(Me.chkIncluirSabado)
        Me.grpFiltro.Controls.Add(Me.txtMaquinaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblMaquinaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblPeriodoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(10, 5)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(1069, 67)
        Me.grpFiltro.TabIndex = 1
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'dtpDataTerminoFiltro
        '
        Me.dtpDataTerminoFiltro.Checked = False
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.DropDownCalendar.Visible = False
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(457, 31)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(108, 23)
        Me.dtpDataTerminoFiltro.TabIndex = 13
        Me.dtpDataTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataInicioFiltro
        '
        Me.dtpDataInicioFiltro.Checked = False
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.DropDownCalendar.Visible = False
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(343, 31)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(108, 23)
        Me.dtpDataInicioFiltro.TabIndex = 12
        Me.dtpDataInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblDiaSemana
        '
        Me.lblDiaSemana.AutoSize = True
        Me.lblDiaSemana.Location = New System.Drawing.Point(567, 15)
        Me.lblDiaSemana.Name = "lblDiaSemana"
        Me.lblDiaSemana.Size = New System.Drawing.Size(89, 16)
        Me.lblDiaSemana.TabIndex = 7
        Me.lblDiaSemana.Text = "Dia Semana:"
        '
        'chkIncluirDomingo
        '
        Me.chkIncluirDomingo.AutoSize = True
        Me.chkIncluirDomingo.Checked = True
        Me.chkIncluirDomingo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncluirDomingo.Location = New System.Drawing.Point(716, 39)
        Me.chkIncluirDomingo.Name = "chkIncluirDomingo"
        Me.chkIncluirDomingo.Size = New System.Drawing.Size(127, 20)
        Me.chkIncluirDomingo.TabIndex = 10
        Me.chkIncluirDomingo.Text = "Incluir Domingo"
        Me.chkIncluirDomingo.UseVisualStyleBackColor = True
        '
        'chkIncluirSabado
        '
        Me.chkIncluirSabado.AutoSize = True
        Me.chkIncluirSabado.Checked = True
        Me.chkIncluirSabado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncluirSabado.Location = New System.Drawing.Point(716, 15)
        Me.chkIncluirSabado.Name = "chkIncluirSabado"
        Me.chkIncluirSabado.Size = New System.Drawing.Size(120, 20)
        Me.chkIncluirSabado.TabIndex = 9
        Me.chkIncluirSabado.Text = "Incluir Sábado"
        Me.chkIncluirSabado.UseVisualStyleBackColor = True
        '
        'txtMaquinaFiltro
        '
        Me.txtMaquinaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaquinaFiltro.Location = New System.Drawing.Point(15, 32)
        Me.txtMaquinaFiltro.MaxLength = 100
        Me.txtMaquinaFiltro.Name = "txtMaquinaFiltro"
        Me.txtMaquinaFiltro.Size = New System.Drawing.Size(322, 23)
        Me.txtMaquinaFiltro.TabIndex = 3
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(965, 28)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 11
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblMaquinaFiltro
        '
        Me.lblMaquinaFiltro.AutoSize = True
        Me.lblMaquinaFiltro.Location = New System.Drawing.Point(12, 15)
        Me.lblMaquinaFiltro.Name = "lblMaquinaFiltro"
        Me.lblMaquinaFiltro.Size = New System.Drawing.Size(66, 16)
        Me.lblMaquinaFiltro.TabIndex = 2
        Me.lblMaquinaFiltro.Text = "Máquina:"
        '
        'lblPeriodoFiltro
        '
        Me.lblPeriodoFiltro.AutoSize = True
        Me.lblPeriodoFiltro.Location = New System.Drawing.Point(340, 15)
        Me.lblPeriodoFiltro.Name = "lblPeriodoFiltro"
        Me.lblPeriodoFiltro.Size = New System.Drawing.Size(62, 16)
        Me.lblPeriodoFiltro.TabIndex = 4
        Me.lblPeriodoFiltro.Text = "Período:"
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(1091, 600)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'cboDiaSemana
        '
        Me.cboDiaSemana.AutoSize = False
        Me.cboDiaSemana.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDiaSemana.Location = New System.Drawing.Point(570, 32)
        Me.cboDiaSemana.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboDiaSemana.Name = "cboDiaSemana"
        Me.cboDiaSemana.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDiaSemana.Size = New System.Drawing.Size(130, 23)
        Me.cboDiaSemana.TabIndex = 14
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(945, 18)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(111, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(834, 18)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(105, 23)
        Me.btnExcel.TabIndex = 1
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnPlanejamento
        '
        Me.btnPlanejamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPlanejamento.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnPlanejamento.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPlanejamento.Location = New System.Drawing.Point(15, 18)
        Me.btnPlanejamento.Name = "btnPlanejamento"
        Me.btnPlanejamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPlanejamento.Size = New System.Drawing.Size(153, 23)
        Me.btnPlanejamento.TabIndex = 5
        Me.btnPlanejamento.Text = "Novo Planejamento"
        Me.btnPlanejamento.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(737, 18)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 6
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluirProduto
        '
        Me.btnExcluirProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirProduto.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluirProduto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirProduto.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirProduto.Location = New System.Drawing.Point(640, 18)
        Me.btnExcluirProduto.Name = "btnExcluirProduto"
        Me.btnExcluirProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirProduto.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirProduto.TabIndex = 4
        Me.btnExcluirProduto.Text = "Excluir"
        Me.btnExcluirProduto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox3.Controls.Add(Me.btnExcluirProduto)
        Me.UiGroupBox3.Controls.Add(Me.btnSalvar)
        Me.UiGroupBox3.Controls.Add(Me.btnPlanejamento)
        Me.UiGroupBox3.Controls.Add(Me.btnExcel)
        Me.UiGroupBox3.Controls.Add(Me.btnSair)
        Me.UiGroupBox3.Location = New System.Drawing.Point(10, 514)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox3.Size = New System.Drawing.Size(1069, 51)
        Me.UiGroupBox3.TabIndex = 3
        Me.UiGroupBox3.VisualStyleManager = Me.vsmMain
        '
        'usrPrdCalendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrPrdCalendario"
        Me.Size = New System.Drawing.Size(1091, 600)
        Me.Tag = "S"
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents hprAjuda As System.Windows.Forms.HelpProvider
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDiaSemana As System.Windows.Forms.Label
    Friend WithEvents chkIncluirDomingo As System.Windows.Forms.CheckBox
    Friend WithEvents chkIncluirSabado As System.Windows.Forms.CheckBox
    Friend WithEvents txtMaquinaFiltro As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblMaquinaFiltro As System.Windows.Forms.Label
    Friend WithEvents lblPeriodoFiltro As System.Windows.Forms.Label
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboDiaSemana As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcluirProduto As Janus.Windows.EditControls.UIButton
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Private WithEvents btnPlanejamento As Janus.Windows.EditControls.UIButton
    Private WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton


End Class
