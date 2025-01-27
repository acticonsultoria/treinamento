<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrMkt000000003
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrMkt000000003))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataTerminoPedido = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioPedido = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPedido = New System.Windows.Forms.Label()
        Me.cboCliente = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.cboSegmento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSegmento = New System.Windows.Forms.Label()
        Me.dtpDataTermino = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblData = New System.Windows.Forms.Label()
        Me.cboVendedor = New Janus.Windows.EditControls.UIComboBox()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.picSistema = New System.Windows.Forms.PictureBox()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnProcurarCliente = New System.Windows.Forms.Button()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme2.Name = "Scheme"
        JanusColorScheme2.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme2.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme2)
        Me.vsmMain.DefaultColorScheme = Nothing
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(507, 393)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.picSistema)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(505, 370)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório de Marketing - MKT000000003"
        '
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnProcurarCliente)
        Me.grpFiltro.Controls.Add(Me.dtpDataTerminoPedido)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicioPedido)
        Me.grpFiltro.Controls.Add(Me.lblDataPedido)
        Me.grpFiltro.Controls.Add(Me.cboCliente)
        Me.grpFiltro.Controls.Add(Me.lblCliente)
        Me.grpFiltro.Controls.Add(Me.cboSegmento)
        Me.grpFiltro.Controls.Add(Me.lblSegmento)
        Me.grpFiltro.Controls.Add(Me.dtpDataTermino)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicio)
        Me.grpFiltro.Controls.Add(Me.lblData)
        Me.grpFiltro.Controls.Add(Me.cboVendedor)
        Me.grpFiltro.Controls.Add(Me.lblVendedor)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 120)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(489, 187)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'dtpDataTerminoPedido
        '
        '
        '
        '
        Me.dtpDataTerminoPedido.DropDownCalendar.Name = ""
        Me.dtpDataTerminoPedido.Location = New System.Drawing.Point(372, 157)
        Me.dtpDataTerminoPedido.Name = "dtpDataTerminoPedido"
        Me.dtpDataTerminoPedido.ShowCheckBox = True
        Me.dtpDataTerminoPedido.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataTerminoPedido.TabIndex = 11
        Me.dtpDataTerminoPedido.Value = New Date(2012, 3, 27, 0, 0, 0, 0)
        '
        'dtpDataInicioPedido
        '
        '
        '
        '
        Me.dtpDataInicioPedido.DropDownCalendar.Name = ""
        Me.dtpDataInicioPedido.Location = New System.Drawing.Point(258, 157)
        Me.dtpDataInicioPedido.Name = "dtpDataInicioPedido"
        Me.dtpDataInicioPedido.ShowCheckBox = True
        Me.dtpDataInicioPedido.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInicioPedido.TabIndex = 10
        Me.dtpDataInicioPedido.Value = New Date(2012, 3, 27, 0, 0, 0, 0)
        '
        'lblDataPedido
        '
        Me.lblDataPedido.AutoSize = True
        Me.lblDataPedido.Location = New System.Drawing.Point(255, 140)
        Me.lblDataPedido.Name = "lblDataPedido"
        Me.lblDataPedido.Size = New System.Drawing.Size(67, 14)
        Me.lblDataPedido.TabIndex = 9
        Me.lblDataPedido.Text = "Data Pedido:"
        '
        'cboCliente
        '
        Me.cboCliente.AutoSize = False
        Me.cboCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCliente.Location = New System.Drawing.Point(9, 77)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCliente.Size = New System.Drawing.Size(471, 20)
        Me.cboCliente.TabIndex = 3
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCliente.Location = New System.Drawing.Point(6, 60)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 2
        Me.lblCliente.Text = "Cliente:"
        '
        'cboSegmento
        '
        Me.cboSegmento.AutoSize = False
        Me.cboSegmento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSegmento.Location = New System.Drawing.Point(9, 37)
        Me.cboSegmento.Name = "cboSegmento"
        Me.cboSegmento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSegmento.Size = New System.Drawing.Size(471, 20)
        Me.cboSegmento.TabIndex = 1
        '
        'lblSegmento
        '
        Me.lblSegmento.AutoSize = True
        Me.lblSegmento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSegmento.Location = New System.Drawing.Point(6, 20)
        Me.lblSegmento.Name = "lblSegmento"
        Me.lblSegmento.Size = New System.Drawing.Size(58, 14)
        Me.lblSegmento.TabIndex = 0
        Me.lblSegmento.Text = "Segmento:"
        '
        'dtpDataTermino
        '
        '
        '
        '
        Me.dtpDataTermino.DropDownCalendar.Name = ""
        Me.dtpDataTermino.Location = New System.Drawing.Point(123, 157)
        Me.dtpDataTermino.Name = "dtpDataTermino"
        Me.dtpDataTermino.ShowCheckBox = True
        Me.dtpDataTermino.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataTermino.TabIndex = 8
        Me.dtpDataTermino.Value = New Date(2012, 3, 27, 0, 0, 0, 0)
        '
        'dtpDataInicio
        '
        '
        '
        '
        Me.dtpDataInicio.DropDownCalendar.Name = ""
        Me.dtpDataInicio.Location = New System.Drawing.Point(9, 157)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.ShowCheckBox = True
        Me.dtpDataInicio.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataInicio.TabIndex = 7
        Me.dtpDataInicio.Value = New Date(2012, 3, 27, 0, 0, 0, 0)
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(6, 140)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(62, 14)
        Me.lblData.TabIndex = 6
        Me.lblData.Text = "Data Visita:"
        '
        'cboVendedor
        '
        Me.cboVendedor.AutoSize = False
        Me.cboVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboVendedor.Location = New System.Drawing.Point(9, 117)
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboVendedor.Size = New System.Drawing.Size(471, 20)
        Me.cboVendedor.TabIndex = 5
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVendedor.Location = New System.Drawing.Point(6, 100)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(57, 14)
        Me.lblVendedor.TabIndex = 4
        Me.lblVendedor.Text = "Vendedor:"
        '
        'picSistema
        '
        Me.picSistema.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picSistema.BackColor = System.Drawing.Color.White
        Me.picSistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSistema.Image = Global.INTERACTI.My.Resources.Interacti
        Me.picSistema.Location = New System.Drawing.Point(8, 8)
        Me.picSistema.Name = "picSistema"
        Me.picSistema.Size = New System.Drawing.Size(489, 109)
        Me.picSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSistema.TabIndex = 15
        Me.picSistema.TabStop = False
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnVisualizarImpressao)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 310)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(489, 51)
        Me.grpControl.TabIndex = 1
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnVisualizarImpressao
        '
        Me.btnVisualizarImpressao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarImpressao.Image = Global.INTERACTI.My.Resources.imprimir
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
        'btnProcurarCliente
        '
        Me.btnProcurarCliente.FlatAppearance.BorderSize = 0
        Me.btnProcurarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCliente.Image = Global.INTERACTI.My.Resources.search
        Me.btnProcurarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCliente.Location = New System.Drawing.Point(463, 58)
        Me.btnProcurarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCliente.Name = "btnProcurarCliente"
        Me.btnProcurarCliente.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCliente.TabIndex = 12
        Me.btnProcurarCliente.TabStop = False
        Me.btnProcurarCliente.UseVisualStyleBackColor = True
        '
        'usrMkt000000003
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrMkt000000003"
        Me.Size = New System.Drawing.Size(507, 393)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents picSistema As System.Windows.Forms.PictureBox
    Friend WithEvents btnVisualizarImpressao As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboVendedor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblVendedor As System.Windows.Forms.Label
    Friend WithEvents dtpDataTermino As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents cboSegmento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSegmento As System.Windows.Forms.Label
    Friend WithEvents cboCliente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents dtpDataTerminoPedido As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioPedido As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataPedido As System.Windows.Forms.Label
    Friend WithEvents btnProcurarCliente As System.Windows.Forms.Button

End Class
