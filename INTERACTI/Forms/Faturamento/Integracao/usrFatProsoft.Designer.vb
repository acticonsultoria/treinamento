<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFatProsoft
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
        Me.components = New System.ComponentModel.Container
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim grdNotaFiscal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFatProsoft))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage
        Me.grpNotas = New Janus.Windows.EditControls.UIGroupBox
        Me.grdNotaFiscal = New Janus.Windows.GridEX.GridEX
        Me.lblTipoOperacao = New System.Windows.Forms.Label
        Me.cboTipoOperacao = New Janus.Windows.EditControls.UIComboBox
        Me.dtpDataTerminoFiltro = New System.Windows.Forms.DateTimePicker
        Me.dtpDataInicioFiltro = New System.Windows.Forms.DateTimePicker
        Me.lblPeriodoFiltro = New System.Windows.Forms.Label
        Me.grpLocal = New Janus.Windows.EditControls.UIGroupBox
        Me.dirLocal = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox
        Me.drvLocal = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
        Me.lblLocal = New System.Windows.Forms.Label
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox
        Me.btnSair = New Janus.Windows.EditControls.UIButton
        Me.btnGerarArquivo = New Janus.Windows.EditControls.UIButton
        Me.btnEnviarEmail = New Janus.Windows.EditControls.UIButton
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNotas.SuspendLayout()
        CType(Me.grdNotaFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpLocal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLocal.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(914, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grpNotas)
        Me.pagLista.Controls.Add(Me.grpLocal)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(912, 453)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Listagem"
        '
        'grpNotas
        '
        Me.grpNotas.BackColor = System.Drawing.Color.Transparent
        Me.grpNotas.Controls.Add(Me.grdNotaFiscal)
        Me.grpNotas.Controls.Add(Me.lblTipoOperacao)
        Me.grpNotas.Controls.Add(Me.cboTipoOperacao)
        Me.grpNotas.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpNotas.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpNotas.Controls.Add(Me.lblPeriodoFiltro)
        Me.grpNotas.Location = New System.Drawing.Point(9, 12)
        Me.grpNotas.Name = "grpNotas"
        Me.grpNotas.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpNotas.Size = New System.Drawing.Size(631, 374)
        Me.grpNotas.TabIndex = 32
        Me.grpNotas.Text = "Notas - Exportar para Prosoft"
        Me.grpNotas.VisualStyleManager = Me.vsmMain
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
        Me.grdNotaFiscal.Location = New System.Drawing.Point(9, 102)
        Me.grdNotaFiscal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdNotaFiscal.Name = "grdNotaFiscal"
        Me.grdNotaFiscal.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdNotaFiscal.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdNotaFiscal.Size = New System.Drawing.Size(612, 261)
        Me.grdNotaFiscal.TabIndex = 38
        Me.grdNotaFiscal.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdNotaFiscal.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdNotaFiscal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdNotaFiscal.VisualStyleManager = Me.vsmMain
        '
        'lblTipoOperacao
        '
        Me.lblTipoOperacao.AutoSize = True
        Me.lblTipoOperacao.Location = New System.Drawing.Point(6, 58)
        Me.lblTipoOperacao.Name = "lblTipoOperacao"
        Me.lblTipoOperacao.Size = New System.Drawing.Size(96, 14)
        Me.lblTipoOperacao.TabIndex = 36
        Me.lblTipoOperacao.Text = "Tipo de Operação:"
        '
        'cboTipoOperacao
        '
        Me.cboTipoOperacao.AutoSize = False
        Me.cboTipoOperacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoOperacao.Location = New System.Drawing.Point(9, 75)
        Me.cboTipoOperacao.Name = "cboTipoOperacao"
        Me.cboTipoOperacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoOperacao.Size = New System.Drawing.Size(222, 20)
        Me.cboTipoOperacao.TabIndex = 37
        '
        'dtpDataTerminoFiltro
        '
        Me.dtpDataTerminoFiltro.Checked = False
        Me.dtpDataTerminoFiltro.CustomFormat = "dd/MM/yyyy"
        Me.dtpDataTerminoFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(123, 35)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 35
        '
        'dtpDataInicioFiltro
        '
        Me.dtpDataInicioFiltro.Checked = False
        Me.dtpDataInicioFiltro.CustomFormat = "dd/MM/yyyy"
        Me.dtpDataInicioFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(9, 35)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInicioFiltro.TabIndex = 34
        '
        'lblPeriodoFiltro
        '
        Me.lblPeriodoFiltro.AutoSize = True
        Me.lblPeriodoFiltro.Location = New System.Drawing.Point(6, 19)
        Me.lblPeriodoFiltro.Name = "lblPeriodoFiltro"
        Me.lblPeriodoFiltro.Size = New System.Drawing.Size(46, 14)
        Me.lblPeriodoFiltro.TabIndex = 33
        Me.lblPeriodoFiltro.Text = "Período:"
        '
        'grpLocal
        '
        Me.grpLocal.BackColor = System.Drawing.Color.Transparent
        Me.grpLocal.Controls.Add(Me.dirLocal)
        Me.grpLocal.Controls.Add(Me.drvLocal)
        Me.grpLocal.Controls.Add(Me.lblLocal)
        Me.grpLocal.Location = New System.Drawing.Point(646, 13)
        Me.grpLocal.Name = "grpLocal"
        Me.grpLocal.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLocal.Size = New System.Drawing.Size(259, 374)
        Me.grpLocal.TabIndex = 31
        Me.grpLocal.Text = "Destino Arquivo"
        Me.grpLocal.VisualStyleManager = Me.vsmMain
        '
        'dirLocal
        '
        Me.dirLocal.FormattingEnabled = True
        Me.dirLocal.IntegralHeight = False
        Me.dirLocal.Location = New System.Drawing.Point(9, 68)
        Me.dirLocal.Name = "dirLocal"
        Me.dirLocal.Size = New System.Drawing.Size(238, 296)
        Me.dirLocal.TabIndex = 20
        '
        'drvLocal
        '
        Me.drvLocal.FormattingEnabled = True
        Me.drvLocal.Location = New System.Drawing.Point(9, 38)
        Me.drvLocal.Name = "drvLocal"
        Me.drvLocal.Size = New System.Drawing.Size(227, 21)
        Me.drvLocal.TabIndex = 19
        '
        'lblLocal
        '
        Me.lblLocal.AutoSize = True
        Me.lblLocal.Location = New System.Drawing.Point(6, 20)
        Me.lblLocal.Name = "lblLocal"
        Me.lblLocal.Size = New System.Drawing.Size(36, 14)
        Me.lblLocal.TabIndex = 18
        Me.lblLocal.Text = "Local:"
        '
        'grpControl
        '
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnEnviarEmail)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Controls.Add(Me.btnGerarArquivo)
        Me.grpControl.Location = New System.Drawing.Point(9, 393)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(896, 51)
        Me.grpControl.TabIndex = 30
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(792, 17)
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
        Me.btnGerarArquivo.Location = New System.Drawing.Point(662, 17)
        Me.btnGerarArquivo.Name = "btnGerarArquivo"
        Me.btnGerarArquivo.Size = New System.Drawing.Size(124, 23)
        Me.btnGerarArquivo.TabIndex = 25
        Me.btnGerarArquivo.Text = "Gerar Arquivos"
        Me.btnGerarArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnEnviarEmail
        '
        Me.btnEnviarEmail.Image = Global.INTERACTI.My.Resources.Resources.email2
        Me.btnEnviarEmail.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnEnviarEmail.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnEnviarEmail.Location = New System.Drawing.Point(532, 17)
        Me.btnEnviarEmail.Name = "btnEnviarEmail"
        Me.btnEnviarEmail.Size = New System.Drawing.Size(124, 23)
        Me.btnEnviarEmail.TabIndex = 27
        Me.btnEnviarEmail.Text = "Enviar por E-mail"
        Me.btnEnviarEmail.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrFatProsoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFatProsoft"
        Me.Size = New System.Drawing.Size(914, 476)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNotas.ResumeLayout(False)
        Me.grpNotas.PerformLayout()
        CType(Me.grdNotaFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpLocal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLocal.ResumeLayout(False)
        Me.grpLocal.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnGerarArquivo As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpLocal As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dirLocal As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
    Friend WithEvents drvLocal As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
    Friend WithEvents lblLocal As System.Windows.Forms.Label
    Friend WithEvents grpNotas As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdNotaFiscal As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblTipoOperacao As System.Windows.Forms.Label
    Friend WithEvents cboTipoOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents dtpDataTerminoFiltro As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDataInicioFiltro As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPeriodoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnEnviarEmail As Janus.Windows.EditControls.UIButton

End Class
