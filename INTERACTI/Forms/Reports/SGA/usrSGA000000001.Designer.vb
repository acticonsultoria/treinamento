<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrSGA000000001
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrSGA000000001))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.picSistema = New System.Windows.Forms.PictureBox()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarCliente = New System.Windows.Forms.Button()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.cboCliente = New Janus.Windows.EditControls.UIComboBox()
        Me.txtCodigoCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoCliente = New System.Windows.Forms.Label()
        Me.cboCompetencia = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.cboEmpresa = New Janus.Windows.EditControls.UIComboBox()
        Me.lblDataCompetencia = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(507, 355)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.picSistema)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(505, 332)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório SGA - Cronograma - Visualização Mensal"
        '
        'picSistema
        '
        Me.picSistema.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picSistema.BackColor = System.Drawing.Color.White
        Me.picSistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSistema.Image = Global.INTERACTI.My.Resources.Resources.interacti
        Me.picSistema.Location = New System.Drawing.Point(8, 8)
        Me.picSistema.Name = "picSistema"
        Me.picSistema.Size = New System.Drawing.Size(489, 109)
        Me.picSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSistema.TabIndex = 15
        Me.picSistema.TabStop = False
        '
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnProcurarCliente)
        Me.grpFiltro.Controls.Add(Me.lblCliente)
        Me.grpFiltro.Controls.Add(Me.cboCliente)
        Me.grpFiltro.Controls.Add(Me.txtCodigoCliente)
        Me.grpFiltro.Controls.Add(Me.lblCodigoCliente)
        Me.grpFiltro.Controls.Add(Me.cboCompetencia)
        Me.grpFiltro.Controls.Add(Me.lblEmpresa)
        Me.grpFiltro.Controls.Add(Me.cboEmpresa)
        Me.grpFiltro.Controls.Add(Me.lblDataCompetencia)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 120)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(489, 147)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarCliente
        '
        Me.btnProcurarCliente.FlatAppearance.BorderSize = 0
        Me.btnProcurarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCliente.Image = CType(resources.GetObject("btnProcurarCliente.Image"), System.Drawing.Image)
        Me.btnProcurarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCliente.Location = New System.Drawing.Point(463, 59)
        Me.btnProcurarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCliente.Name = "btnProcurarCliente"
        Me.btnProcurarCliente.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCliente.TabIndex = 25
        Me.btnProcurarCliente.TabStop = False
        Me.btnProcurarCliente.UseVisualStyleBackColor = True
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(73, 60)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 23
        Me.lblCliente.Text = "Cliente:"
        '
        'cboCliente
        '
        Me.cboCliente.AutoSize = False
        Me.cboCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCliente.Location = New System.Drawing.Point(76, 77)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCliente.Size = New System.Drawing.Size(404, 20)
        Me.cboCliente.TabIndex = 24
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoCliente.Location = New System.Drawing.Point(9, 77)
        Me.txtCodigoCliente.MaxLength = 50
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(61, 20)
        Me.txtCodigoCliente.TabIndex = 22
        '
        'lblCodigoCliente
        '
        Me.lblCodigoCliente.AutoSize = True
        Me.lblCodigoCliente.Location = New System.Drawing.Point(6, 60)
        Me.lblCodigoCliente.Name = "lblCodigoCliente"
        Me.lblCodigoCliente.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigoCliente.TabIndex = 21
        Me.lblCodigoCliente.Text = "Código:"
        '
        'cboCompetencia
        '
        Me.cboCompetencia.CustomFormat = "MMM/yyyy"
        Me.cboCompetencia.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.cboCompetencia.DropDownCalendar.Name = ""
        Me.cboCompetencia.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cboCompetencia.Location = New System.Drawing.Point(9, 37)
        Me.cboCompetencia.Name = "cboCompetencia"
        Me.cboCompetencia.Size = New System.Drawing.Size(91, 20)
        Me.cboCompetencia.TabIndex = 9
        Me.cboCompetencia.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEmpresa.Location = New System.Drawing.Point(7, 100)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(52, 14)
        Me.lblEmpresa.TabIndex = 4
        Me.lblEmpresa.Text = "Empresa:"
        '
        'cboEmpresa
        '
        Me.cboEmpresa.AutoSize = False
        Me.cboEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEmpresa.Location = New System.Drawing.Point(9, 117)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboEmpresa.Size = New System.Drawing.Size(471, 20)
        Me.cboEmpresa.TabIndex = 5
        '
        'lblDataCompetencia
        '
        Me.lblDataCompetencia.AutoSize = True
        Me.lblDataCompetencia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataCompetencia.Location = New System.Drawing.Point(6, 20)
        Me.lblDataCompetencia.Name = "lblDataCompetencia"
        Me.lblDataCompetencia.Size = New System.Drawing.Size(97, 14)
        Me.lblDataCompetencia.TabIndex = 0
        Me.lblDataCompetencia.Text = "Data Competência:"
        '
        'grpControl
        '
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnVisualizarImpressao)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 271)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(489, 51)
        Me.grpControl.TabIndex = 1
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnVisualizarImpressao
        '
        Me.btnVisualizarImpressao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarImpressao.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnVisualizarImpressao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarImpressao.Location = New System.Drawing.Point(183, 17)
        Me.btnVisualizarImpressao.Name = "btnVisualizarImpressao"
        Me.btnVisualizarImpressao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarImpressao.Size = New System.Drawing.Size(200, 23)
        Me.btnVisualizarImpressao.TabIndex = 0
        Me.btnVisualizarImpressao.Text = "Visualizar Impressão"
        Me.btnVisualizarImpressao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(389, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrSGA000000001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrSGA000000001"
        Me.Size = New System.Drawing.Size(507, 355)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataCompetencia As System.Windows.Forms.Label
    Friend WithEvents picSistema As System.Windows.Forms.PictureBox
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents cboEmpresa As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnVisualizarImpressao As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboCompetencia As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnProcurarCliente As System.Windows.Forms.Button
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents cboCliente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtCodigoCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoCliente As System.Windows.Forms.Label

End Class
