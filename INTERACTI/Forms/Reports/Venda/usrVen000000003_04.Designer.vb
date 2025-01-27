<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrVen000000003_04
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrVen000000003_04))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboSegmento = New Janus.Windows.EditControls.UIComboBox()
        Me.lblSegmento = New System.Windows.Forms.Label()
        Me.cboGrupoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblGrupoItem = New System.Windows.Forms.Label()
        Me.dtpDataPrevisaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPrevisaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPrevisao = New System.Windows.Forms.Label()
        Me.cboVendedor = New Janus.Windows.EditControls.UIComboBox()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.picSistema = New System.Windows.Forms.PictureBox()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.cboProbabilidadeVendaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblProbabilidadeVendaFiltro = New System.Windows.Forms.Label()
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
        Me.pagLista.Text = "Relatório de Vendas - VEN000000003"
        '
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboProbabilidadeVendaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblProbabilidadeVendaFiltro)
        Me.grpFiltro.Controls.Add(Me.cboSegmento)
        Me.grpFiltro.Controls.Add(Me.lblSegmento)
        Me.grpFiltro.Controls.Add(Me.cboGrupoItem)
        Me.grpFiltro.Controls.Add(Me.lblGrupoItem)
        Me.grpFiltro.Controls.Add(Me.dtpDataPrevisaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPrevisaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPrevisao)
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
        'cboSegmento
        '
        Me.cboSegmento.AutoSize = False
        Me.cboSegmento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSegmento.Location = New System.Drawing.Point(9, 157)
        Me.cboSegmento.Name = "cboSegmento"
        Me.cboSegmento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSegmento.Size = New System.Drawing.Size(471, 20)
        Me.cboSegmento.TabIndex = 10
        '
        'lblSegmento
        '
        Me.lblSegmento.AutoSize = True
        Me.lblSegmento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSegmento.Location = New System.Drawing.Point(7, 140)
        Me.lblSegmento.Name = "lblSegmento"
        Me.lblSegmento.Size = New System.Drawing.Size(58, 14)
        Me.lblSegmento.TabIndex = 9
        Me.lblSegmento.Text = "Segmento:"
        '
        'cboGrupoItem
        '
        Me.cboGrupoItem.AutoSize = False
        Me.cboGrupoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboGrupoItem.Location = New System.Drawing.Point(9, 117)
        Me.cboGrupoItem.Name = "cboGrupoItem"
        Me.cboGrupoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboGrupoItem.Size = New System.Drawing.Size(471, 20)
        Me.cboGrupoItem.TabIndex = 7
        '
        'lblGrupoItem
        '
        Me.lblGrupoItem.AutoSize = True
        Me.lblGrupoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGrupoItem.Location = New System.Drawing.Point(7, 100)
        Me.lblGrupoItem.Name = "lblGrupoItem"
        Me.lblGrupoItem.Size = New System.Drawing.Size(77, 14)
        Me.lblGrupoItem.TabIndex = 8
        Me.lblGrupoItem.Text = "Grupo de Item:"
        '
        'dtpDataPrevisaoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataPrevisaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPrevisaoTerminoFiltro.Location = New System.Drawing.Point(123, 77)
        Me.dtpDataPrevisaoTerminoFiltro.Name = "dtpDataPrevisaoTerminoFiltro"
        Me.dtpDataPrevisaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataPrevisaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPrevisaoTerminoFiltro.TabIndex = 4
        '
        'dtpDataPrevisaoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataPrevisaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPrevisaoInicioFiltro.Location = New System.Drawing.Point(9, 77)
        Me.dtpDataPrevisaoInicioFiltro.Name = "dtpDataPrevisaoInicioFiltro"
        Me.dtpDataPrevisaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataPrevisaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPrevisaoInicioFiltro.TabIndex = 3
        '
        'lblDataPrevisao
        '
        Me.lblDataPrevisao.AutoSize = True
        Me.lblDataPrevisao.Location = New System.Drawing.Point(6, 60)
        Me.lblDataPrevisao.Name = "lblDataPrevisao"
        Me.lblDataPrevisao.Size = New System.Drawing.Size(77, 14)
        Me.lblDataPrevisao.TabIndex = 2
        Me.lblDataPrevisao.Text = "Data Previsão:"
        '
        'cboVendedor
        '
        Me.cboVendedor.AutoSize = False
        Me.cboVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboVendedor.Location = New System.Drawing.Point(9, 37)
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboVendedor.Size = New System.Drawing.Size(471, 20)
        Me.cboVendedor.TabIndex = 1
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVendedor.Location = New System.Drawing.Point(6, 20)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(57, 14)
        Me.lblVendedor.TabIndex = 0
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
        'cboProbabilidadeVendaFiltro
        '
        Me.cboProbabilidadeVendaFiltro.AutoSize = False
        Me.cboProbabilidadeVendaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProbabilidadeVendaFiltro.Location = New System.Drawing.Point(237, 77)
        Me.cboProbabilidadeVendaFiltro.Name = "cboProbabilidadeVendaFiltro"
        Me.cboProbabilidadeVendaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboProbabilidadeVendaFiltro.Size = New System.Drawing.Size(243, 20)
        Me.cboProbabilidadeVendaFiltro.TabIndex = 6
        '
        'lblProbabilidadeVendaFiltro
        '
        Me.lblProbabilidadeVendaFiltro.AutoSize = True
        Me.lblProbabilidadeVendaFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblProbabilidadeVendaFiltro.Location = New System.Drawing.Point(233, 60)
        Me.lblProbabilidadeVendaFiltro.Name = "lblProbabilidadeVendaFiltro"
        Me.lblProbabilidadeVendaFiltro.Size = New System.Drawing.Size(123, 14)
        Me.lblProbabilidadeVendaFiltro.TabIndex = 5
        Me.lblProbabilidadeVendaFiltro.Text = "Probabilidade de Venda:"
        '
        'usrVen000000003_04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrVen000000003_04"
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
    Friend WithEvents lblDataPrevisao As System.Windows.Forms.Label
    Friend WithEvents cboVendedor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblVendedor As System.Windows.Forms.Label
    Friend WithEvents cboGrupoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblGrupoItem As System.Windows.Forms.Label
    Friend WithEvents dtpDataPrevisaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPrevisaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboSegmento As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblSegmento As System.Windows.Forms.Label
    Friend WithEvents cboProbabilidadeVendaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblProbabilidadeVendaFiltro As System.Windows.Forms.Label

End Class
