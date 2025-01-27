<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrIntProsoftServico
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
        Dim grdNotaFiscal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrIntProsoftServico))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdNotaFiscal = New Janus.Windows.GridEX.GridEX()
        Me.grpNotas = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblTipoOperacao = New System.Windows.Forms.Label()
        Me.cboTipoOperacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnEnviarEmail = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnGerarArquivo = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdNotaFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNotas.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grdNotaFiscal)
        Me.pagLista.Controls.Add(Me.grpNotas)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Integração - Prosoft"
        '
        'grdNotaFiscal
        '
        Me.grdNotaFiscal.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdNotaFiscal.AlternatingColors = True
        grdNotaFiscal_DesignTimeLayout.LayoutString = resources.GetString("grdNotaFiscal_DesignTimeLayout.LayoutString")
        Me.grdNotaFiscal.DesignTimeLayout = grdNotaFiscal_DesignTimeLayout
        Me.grdNotaFiscal.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdNotaFiscal.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdNotaFiscal.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdNotaFiscal.GroupByBoxVisible = False
        Me.grdNotaFiscal.Location = New System.Drawing.Point(8, 80)
        Me.grdNotaFiscal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdNotaFiscal.Name = "grdNotaFiscal"
        Me.grdNotaFiscal.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdNotaFiscal.RecordNavigator = True
        Me.grdNotaFiscal.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdNotaFiscal.Size = New System.Drawing.Size(897, 399)
        Me.grdNotaFiscal.TabIndex = 39
        Me.grdNotaFiscal.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdNotaFiscal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdNotaFiscal.VisualStyleManager = Me.vsmMain
        '
        'grpNotas
        '
        Me.grpNotas.BackColor = System.Drawing.Color.Transparent
        Me.grpNotas.Controls.Add(Me.btnFiltrar)
        Me.grpNotas.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpNotas.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpNotas.Controls.Add(Me.lblTipoOperacao)
        Me.grpNotas.Controls.Add(Me.cboTipoOperacao)
        Me.grpNotas.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpNotas.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpNotas.Location = New System.Drawing.Point(8, 3)
        Me.grpNotas.Name = "grpNotas"
        Me.grpNotas.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpNotas.Size = New System.Drawing.Size(897, 67)
        Me.grpNotas.TabIndex = 32
        Me.grpNotas.Text = "Notas - Exportar para Prosoft"
        Me.grpNotas.VisualStyleManager = Me.vsmMain
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = CType(resources.GetObject("btnFiltrar.Image"), System.Drawing.Image)
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(797, 34)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 40
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'dtpDataEmissaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(9, 37)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 38
        Me.dtpDataEmissaoInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataEmissaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(123, 37)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 39
        Me.dtpDataEmissaoTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblTipoOperacao
        '
        Me.lblTipoOperacao.AutoSize = True
        Me.lblTipoOperacao.Location = New System.Drawing.Point(234, 20)
        Me.lblTipoOperacao.Name = "lblTipoOperacao"
        Me.lblTipoOperacao.Size = New System.Drawing.Size(96, 14)
        Me.lblTipoOperacao.TabIndex = 36
        Me.lblTipoOperacao.Text = "Tipo de Operação:"
        '
        'cboTipoOperacao
        '
        Me.cboTipoOperacao.AutoSize = False
        Me.cboTipoOperacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoOperacao.Location = New System.Drawing.Point(237, 37)
        Me.cboTipoOperacao.Name = "cboTipoOperacao"
        Me.cboTipoOperacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoOperacao.Size = New System.Drawing.Size(222, 20)
        Me.cboTipoOperacao.TabIndex = 37
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(6, 20)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(90, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 33
        Me.lblDataEmissaoFiltro.Text = "Data de Emissão:"
        '
        'grpControl
        '
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnEnviarEmail)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnGerarArquivo)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 30
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnEnviarEmail
        '
        Me.btnEnviarEmail.Image = Global.INTERACTI.My.Resources.Resources.email
        Me.btnEnviarEmail.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnEnviarEmail.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnEnviarEmail.Location = New System.Drawing.Point(536, 17)
        Me.btnEnviarEmail.Name = "btnEnviarEmail"
        Me.btnEnviarEmail.Size = New System.Drawing.Size(124, 23)
        Me.btnEnviarEmail.TabIndex = 27
        Me.btnEnviarEmail.Text = "Enviar por E-mail"
        Me.btnEnviarEmail.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(796, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(92, 23)
        Me.btnSair.TabIndex = 26
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnGerarArquivo
        '
        Me.btnGerarArquivo.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnGerarArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarArquivo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnGerarArquivo.Location = New System.Drawing.Point(666, 17)
        Me.btnGerarArquivo.Name = "btnGerarArquivo"
        Me.btnGerarArquivo.Size = New System.Drawing.Size(124, 23)
        Me.btnGerarArquivo.TabIndex = 25
        Me.btnGerarArquivo.Text = "Gerar Arquivos"
        Me.btnGerarArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrIntProsoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrIntProsoft"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdNotaFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNotas.ResumeLayout(False)
        Me.grpNotas.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnGerarArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpNotas As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTipoOperacao As System.Windows.Forms.Label
    Friend WithEvents cboTipoOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnEnviarEmail As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdNotaFiscal As Janus.Windows.GridEX.GridEX
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton

End Class
