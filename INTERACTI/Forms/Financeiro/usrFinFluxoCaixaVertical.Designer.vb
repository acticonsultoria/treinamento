<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFinFluxoCaixaVertical
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
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFinFluxoCaixaVertical))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboTipoTituloFinanceiroFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoTituloFinanceiroFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblPeriodoFiltro = New System.Windows.Forms.Label()
        Me.cboParceiroNegocioFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblParceiroNegocioFiltro = New System.Windows.Forms.Label()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
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
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(913, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Fluxo de Caixa - Vertical"
        '
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.cboTipoTituloFinanceiroFiltro)
        Me.grpFiltro.Controls.Add(Me.lblTipoTituloFinanceiroFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblPeriodoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboParceiroNegocioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblParceiroNegocioFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(115, 34)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 11
        '
        'dtpDataInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(9, 34)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataInicioFiltro.TabIndex = 10
        '
        'cboTipoTituloFinanceiroFiltro
        '
        Me.cboTipoTituloFinanceiroFiltro.AutoSize = False
        Me.cboTipoTituloFinanceiroFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoTituloFinanceiroFiltro.Location = New System.Drawing.Point(579, 34)
        Me.cboTipoTituloFinanceiroFiltro.Name = "cboTipoTituloFinanceiroFiltro"
        Me.cboTipoTituloFinanceiroFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoTituloFinanceiroFiltro.Size = New System.Drawing.Size(186, 20)
        Me.cboTipoTituloFinanceiroFiltro.TabIndex = 5
        '
        'lblTipoTituloFinanceiroFiltro
        '
        Me.lblTipoTituloFinanceiroFiltro.AutoSize = True
        Me.lblTipoTituloFinanceiroFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoTituloFinanceiroFiltro.Location = New System.Drawing.Point(576, 17)
        Me.lblTipoTituloFinanceiroFiltro.Name = "lblTipoTituloFinanceiroFiltro"
        Me.lblTipoTituloFinanceiroFiltro.Size = New System.Drawing.Size(74, 14)
        Me.lblTipoTituloFinanceiroFiltro.TabIndex = 4
        Me.lblTipoTituloFinanceiroFiltro.Text = "Tipo de Título:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 9
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblPeriodoFiltro
        '
        Me.lblPeriodoFiltro.AutoSize = True
        Me.lblPeriodoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblPeriodoFiltro.Name = "lblPeriodoFiltro"
        Me.lblPeriodoFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblPeriodoFiltro.TabIndex = 6
        Me.lblPeriodoFiltro.Text = "Período:"
        '
        'cboParceiroNegocioFiltro
        '
        Me.cboParceiroNegocioFiltro.AutoSize = False
        Me.cboParceiroNegocioFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboParceiroNegocioFiltro.Location = New System.Drawing.Point(221, 34)
        Me.cboParceiroNegocioFiltro.Name = "cboParceiroNegocioFiltro"
        Me.cboParceiroNegocioFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboParceiroNegocioFiltro.Size = New System.Drawing.Size(352, 20)
        Me.cboParceiroNegocioFiltro.TabIndex = 3
        '
        'lblParceiroNegocioFiltro
        '
        Me.lblParceiroNegocioFiltro.AutoSize = True
        Me.lblParceiroNegocioFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblParceiroNegocioFiltro.Location = New System.Drawing.Point(218, 17)
        Me.lblParceiroNegocioFiltro.Name = "lblParceiroNegocioFiltro"
        Me.lblParceiroNegocioFiltro.Size = New System.Drawing.Size(107, 14)
        Me.lblParceiroNegocioFiltro.TabIndex = 2
        Me.lblParceiroNegocioFiltro.Text = "Parceiro de Negócio:"
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 5
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(8, 76)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(897, 404)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControle
        '
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnExcel)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(897, 51)
        Me.grpControle.TabIndex = 3
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnExcel.Location = New System.Drawing.Point(700, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 2
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrFinFluxoCaixaVertical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFinFluxoCaixaVertical"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblPeriodoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblParceiroNegocioFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoTituloFinanceiroFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoTituloFinanceiroFiltro As System.Windows.Forms.Label
    Friend WithEvents cboParceiroNegocioFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo

End Class
