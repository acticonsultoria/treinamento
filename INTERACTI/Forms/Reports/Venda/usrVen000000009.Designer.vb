<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrVen000000009
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
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrVen000000009))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboVendedor = New Janus.Windows.EditControls.UIComboBox()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.cboTipoItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoItem = New System.Windows.Forms.Label()
        Me.cboMunicipio = New Janus.Windows.EditControls.UIComboBox()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.cboUF = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.dtpDataPrevisaoEntregaTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPrevisaoEntregaInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPrevisaoEntregaFiltro = New System.Windows.Forms.Label()
        Me.dtpDataPedidoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPedidoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPedido = New System.Windows.Forms.Label()
        Me.cboCliente = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.picSistema = New System.Windows.Forms.PictureBox()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
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
        Me.tabMain.Size = New System.Drawing.Size(507, 473)
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
        Me.pagLista.Size = New System.Drawing.Size(505, 450)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório de Vendas - VEN000000009"
        '
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboVendedor)
        Me.grpFiltro.Controls.Add(Me.lblVendedor)
        Me.grpFiltro.Controls.Add(Me.cboTipoItem)
        Me.grpFiltro.Controls.Add(Me.lblTipoItem)
        Me.grpFiltro.Controls.Add(Me.cboMunicipio)
        Me.grpFiltro.Controls.Add(Me.lblUF)
        Me.grpFiltro.Controls.Add(Me.cboUF)
        Me.grpFiltro.Controls.Add(Me.lblMunicipio)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatus)
        Me.grpFiltro.Controls.Add(Me.dtpDataPrevisaoEntregaTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPrevisaoEntregaInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPrevisaoEntregaFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPedidoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPedidoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPedido)
        Me.grpFiltro.Controls.Add(Me.cboCliente)
        Me.grpFiltro.Controls.Add(Me.lblCliente)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 120)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(489, 267)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboVendedor
        '
        Me.cboVendedor.AutoSize = False
        Me.cboVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboVendedor.Location = New System.Drawing.Point(9, 117)
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboVendedor.Size = New System.Drawing.Size(471, 20)
        Me.cboVendedor.TabIndex = 17
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVendedor.Location = New System.Drawing.Point(6, 100)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(57, 14)
        Me.lblVendedor.TabIndex = 16
        Me.lblVendedor.Text = "Vendedor:"
        '
        'cboTipoItem
        '
        Me.cboTipoItem.AutoSize = False
        Me.cboTipoItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoItem.Location = New System.Drawing.Point(9, 237)
        Me.cboTipoItem.Name = "cboTipoItem"
        Me.cboTipoItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoItem.Size = New System.Drawing.Size(471, 20)
        Me.cboTipoItem.TabIndex = 15
        '
        'lblTipoItem
        '
        Me.lblTipoItem.AutoSize = True
        Me.lblTipoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoItem.Location = New System.Drawing.Point(6, 220)
        Me.lblTipoItem.Name = "lblTipoItem"
        Me.lblTipoItem.Size = New System.Drawing.Size(67, 14)
        Me.lblTipoItem.TabIndex = 14
        Me.lblTipoItem.Text = "Tipo de Item:"
        '
        'cboMunicipio
        '
        Me.cboMunicipio.AutoSize = False
        Me.cboMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMunicipio.Location = New System.Drawing.Point(73, 197)
        Me.cboMunicipio.Name = "cboMunicipio"
        Me.cboMunicipio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMunicipio.Size = New System.Drawing.Size(407, 20)
        Me.cboMunicipio.TabIndex = 13
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUF.Location = New System.Drawing.Point(6, 180)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(23, 14)
        Me.lblUF.TabIndex = 10
        Me.lblUF.Text = "UF:"
        '
        'cboUF
        '
        Me.cboUF.AutoSize = False
        Me.cboUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUF.Location = New System.Drawing.Point(9, 197)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUF.Size = New System.Drawing.Size(58, 20)
        Me.cboUF.TabIndex = 11
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMunicipio.Location = New System.Drawing.Point(70, 180)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(55, 14)
        Me.lblMunicipio.TabIndex = 12
        Me.lblMunicipio.Text = "Município:"
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(9, 157)
        Me.cboStatusFiltro.Name = "cboStatusFiltro"
        Me.cboStatusFiltro.SaveSettings = False
        Me.cboStatusFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboStatusFiltro.Size = New System.Drawing.Size(471, 20)
        Me.cboStatusFiltro.TabIndex = 9
        Me.cboStatusFiltro.ValuesDataMember = Nothing
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStatus.Location = New System.Drawing.Point(6, 140)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(38, 14)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Status"
        '
        'dtpDataPrevisaoEntregaTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataPrevisaoEntregaTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPrevisaoEntregaTerminoFiltro.Location = New System.Drawing.Point(372, 77)
        Me.dtpDataPrevisaoEntregaTerminoFiltro.Name = "dtpDataPrevisaoEntregaTerminoFiltro"
        Me.dtpDataPrevisaoEntregaTerminoFiltro.ShowCheckBox = True
        Me.dtpDataPrevisaoEntregaTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPrevisaoEntregaTerminoFiltro.TabIndex = 7
        Me.dtpDataPrevisaoEntregaTerminoFiltro.Value = New Date(2012, 3, 27, 0, 0, 0, 0)
        '
        'dtpDataPrevisaoEntregaInicioFiltro
        '
        '
        '
        '
        Me.dtpDataPrevisaoEntregaInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPrevisaoEntregaInicioFiltro.Location = New System.Drawing.Point(258, 77)
        Me.dtpDataPrevisaoEntregaInicioFiltro.Name = "dtpDataPrevisaoEntregaInicioFiltro"
        Me.dtpDataPrevisaoEntregaInicioFiltro.ShowCheckBox = True
        Me.dtpDataPrevisaoEntregaInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPrevisaoEntregaInicioFiltro.TabIndex = 6
        Me.dtpDataPrevisaoEntregaInicioFiltro.Value = New Date(2012, 3, 27, 0, 0, 0, 0)
        '
        'lblDataPrevisaoEntregaFiltro
        '
        Me.lblDataPrevisaoEntregaFiltro.AutoSize = True
        Me.lblDataPrevisaoEntregaFiltro.Location = New System.Drawing.Point(255, 60)
        Me.lblDataPrevisaoEntregaFiltro.Name = "lblDataPrevisaoEntregaFiltro"
        Me.lblDataPrevisaoEntregaFiltro.Size = New System.Drawing.Size(92, 14)
        Me.lblDataPrevisaoEntregaFiltro.TabIndex = 5
        Me.lblDataPrevisaoEntregaFiltro.Text = "Data de Previsão:"
        '
        'dtpDataPedidoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataPedidoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPedidoTerminoFiltro.Location = New System.Drawing.Point(123, 77)
        Me.dtpDataPedidoTerminoFiltro.Name = "dtpDataPedidoTerminoFiltro"
        Me.dtpDataPedidoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataPedidoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPedidoTerminoFiltro.TabIndex = 4
        Me.dtpDataPedidoTerminoFiltro.Value = New Date(2012, 3, 27, 0, 0, 0, 0)
        '
        'dtpDataPedidoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataPedidoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataPedidoInicioFiltro.Location = New System.Drawing.Point(9, 77)
        Me.dtpDataPedidoInicioFiltro.Name = "dtpDataPedidoInicioFiltro"
        Me.dtpDataPedidoInicioFiltro.ShowCheckBox = True
        Me.dtpDataPedidoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPedidoInicioFiltro.TabIndex = 3
        Me.dtpDataPedidoInicioFiltro.Value = New Date(2012, 3, 27, 0, 0, 0, 0)
        '
        'lblDataPedido
        '
        Me.lblDataPedido.AutoSize = True
        Me.lblDataPedido.Location = New System.Drawing.Point(6, 60)
        Me.lblDataPedido.Name = "lblDataPedido"
        Me.lblDataPedido.Size = New System.Drawing.Size(82, 14)
        Me.lblDataPedido.TabIndex = 2
        Me.lblDataPedido.Text = "Data do Pedido:"
        '
        'cboCliente
        '
        Me.cboCliente.AutoSize = False
        Me.cboCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCliente.Location = New System.Drawing.Point(9, 37)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCliente.Size = New System.Drawing.Size(471, 20)
        Me.cboCliente.TabIndex = 1
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCliente.Location = New System.Drawing.Point(6, 20)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente:"
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
        Me.grpControl.Location = New System.Drawing.Point(8, 390)
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
        'usrVen000000009
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrVen000000009"
        Me.Size = New System.Drawing.Size(507, 473)
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
    Friend WithEvents cboCliente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents dtpDataPrevisaoEntregaTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPrevisaoEntregaInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataPrevisaoEntregaFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataPedidoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPedidoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataPedido As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents cboMunicipio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblUF As System.Windows.Forms.Label
    Friend WithEvents cboUF As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMunicipio As System.Windows.Forms.Label
    Friend WithEvents cboTipoItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoItem As System.Windows.Forms.Label
    Friend WithEvents cboVendedor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblVendedor As System.Windows.Forms.Label

End Class
