<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCmp000000003
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
        Dim cboPais_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCmp000000003))
        Dim cboUFFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboStatusFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboPais = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.cboUFFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblUFFiltro = New System.Windows.Forms.Label()
        Me.cboStatusFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.dtpDataPrevisaoEntregaTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPrevisaoEntregaInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPrevisaoEntregaFiltro = New System.Windows.Forms.Label()
        Me.dtpDataPedidoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataPedidoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataPedido = New System.Windows.Forms.Label()
        Me.cboFornecedor = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.picSistema = New System.Windows.Forms.PictureBox()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVisualizarImpressao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnProcurarItem = New System.Windows.Forms.Button()
        Me.cboItem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.btnProcurarFornecedor = New System.Windows.Forms.Button()
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
        JanusColorScheme3.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme3.Name = "Scheme"
        JanusColorScheme3.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme3.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme3.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme3)
        Me.vsmMain.DefaultColorScheme = Nothing
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(507, 446)
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
        Me.pagLista.Size = New System.Drawing.Size(505, 423)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório de Compras - CMP000000003"
        '
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnProcurarFornecedor)
        Me.grpFiltro.Controls.Add(Me.btnProcurarItem)
        Me.grpFiltro.Controls.Add(Me.cboItem)
        Me.grpFiltro.Controls.Add(Me.lblItem)
        Me.grpFiltro.Controls.Add(Me.cboPais)
        Me.grpFiltro.Controls.Add(Me.lblPais)
        Me.grpFiltro.Controls.Add(Me.cboUFFiltro)
        Me.grpFiltro.Controls.Add(Me.lblUFFiltro)
        Me.grpFiltro.Controls.Add(Me.cboStatusFiltro)
        Me.grpFiltro.Controls.Add(Me.lblStatus)
        Me.grpFiltro.Controls.Add(Me.dtpDataPrevisaoEntregaTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPrevisaoEntregaInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPrevisaoEntregaFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPedidoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataPedidoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDataPedido)
        Me.grpFiltro.Controls.Add(Me.cboFornecedor)
        Me.grpFiltro.Controls.Add(Me.lblFornecedor)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 120)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(489, 237)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboPais
        '
        Me.cboPais.AllowDrop = True
        Me.cboPais.ButtonCancelText = "Cancelar"
        Me.cboPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboPais_DesignTimeLayout.LayoutString = resources.GetString("cboPais_DesignTimeLayout.LayoutString")
        Me.cboPais.DesignTimeLayout = cboPais_DesignTimeLayout
        Me.cboPais.Location = New System.Drawing.Point(9, 203)
        Me.cboPais.Name = "cboPais"
        Me.cboPais.SaveSettings = False
        Me.cboPais.SettingsKey = "cboDestinacaoFiltro"
        Me.cboPais.Size = New System.Drawing.Size(357, 20)
        Me.cboPais.TabIndex = 11
        Me.cboPais.ValuesDataMember = Nothing
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPais.Location = New System.Drawing.Point(6, 186)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(30, 14)
        Me.lblPais.TabIndex = 10
        Me.lblPais.Text = "País:"
        '
        'cboUFFiltro
        '
        Me.cboUFFiltro.AllowDrop = True
        Me.cboUFFiltro.ButtonCancelText = "Cancelar"
        Me.cboUFFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboUFFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboUFFiltro_DesignTimeLayout.LayoutString")
        Me.cboUFFiltro.DesignTimeLayout = cboUFFiltro_DesignTimeLayout
        Me.cboUFFiltro.Location = New System.Drawing.Point(372, 203)
        Me.cboUFFiltro.Name = "cboUFFiltro"
        Me.cboUFFiltro.SaveSettings = False
        Me.cboUFFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboUFFiltro.Size = New System.Drawing.Size(108, 20)
        Me.cboUFFiltro.TabIndex = 13
        Me.cboUFFiltro.ValuesDataMember = Nothing
        '
        'lblUFFiltro
        '
        Me.lblUFFiltro.AutoSize = True
        Me.lblUFFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUFFiltro.Location = New System.Drawing.Point(369, 186)
        Me.lblUFFiltro.Name = "lblUFFiltro"
        Me.lblUFFiltro.Size = New System.Drawing.Size(23, 14)
        Me.lblUFFiltro.TabIndex = 12
        Me.lblUFFiltro.Text = "UF:"
        '
        'cboStatusFiltro
        '
        Me.cboStatusFiltro.AllowDrop = True
        Me.cboStatusFiltro.ButtonCancelText = "Cancelar"
        Me.cboStatusFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboStatusFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboStatusFiltro_DesignTimeLayout.LayoutString")
        Me.cboStatusFiltro.DesignTimeLayout = cboStatusFiltro_DesignTimeLayout
        Me.cboStatusFiltro.Location = New System.Drawing.Point(9, 163)
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
        Me.lblStatus.Location = New System.Drawing.Point(6, 146)
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
        Me.dtpDataPrevisaoEntregaTerminoFiltro.Location = New System.Drawing.Point(372, 123)
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
        Me.dtpDataPrevisaoEntregaInicioFiltro.Location = New System.Drawing.Point(258, 123)
        Me.dtpDataPrevisaoEntregaInicioFiltro.Name = "dtpDataPrevisaoEntregaInicioFiltro"
        Me.dtpDataPrevisaoEntregaInicioFiltro.ShowCheckBox = True
        Me.dtpDataPrevisaoEntregaInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPrevisaoEntregaInicioFiltro.TabIndex = 6
        Me.dtpDataPrevisaoEntregaInicioFiltro.Value = New Date(2012, 3, 27, 0, 0, 0, 0)
        '
        'lblDataPrevisaoEntregaFiltro
        '
        Me.lblDataPrevisaoEntregaFiltro.AutoSize = True
        Me.lblDataPrevisaoEntregaFiltro.Location = New System.Drawing.Point(255, 106)
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
        Me.dtpDataPedidoTerminoFiltro.Location = New System.Drawing.Point(123, 123)
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
        Me.dtpDataPedidoInicioFiltro.Location = New System.Drawing.Point(9, 123)
        Me.dtpDataPedidoInicioFiltro.Name = "dtpDataPedidoInicioFiltro"
        Me.dtpDataPedidoInicioFiltro.ShowCheckBox = True
        Me.dtpDataPedidoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataPedidoInicioFiltro.TabIndex = 3
        Me.dtpDataPedidoInicioFiltro.Value = New Date(2012, 3, 27, 0, 0, 0, 0)
        '
        'lblDataPedido
        '
        Me.lblDataPedido.AutoSize = True
        Me.lblDataPedido.Location = New System.Drawing.Point(6, 106)
        Me.lblDataPedido.Name = "lblDataPedido"
        Me.lblDataPedido.Size = New System.Drawing.Size(82, 14)
        Me.lblDataPedido.TabIndex = 2
        Me.lblDataPedido.Text = "Data do Pedido:"
        '
        'cboFornecedor
        '
        Me.cboFornecedor.AutoSize = False
        Me.cboFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboFornecedor.Location = New System.Drawing.Point(9, 37)
        Me.cboFornecedor.Name = "cboFornecedor"
        Me.cboFornecedor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFornecedor.Size = New System.Drawing.Size(471, 20)
        Me.cboFornecedor.TabIndex = 1
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFornecedor.Location = New System.Drawing.Point(6, 20)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(66, 14)
        Me.lblFornecedor.TabIndex = 0
        Me.lblFornecedor.Text = "Fornecedor:"
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
        'grpControl
        '
        Me.grpControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnVisualizarImpressao)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 363)
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
        'btnProcurarItem
        '
        Me.btnProcurarItem.FlatAppearance.BorderSize = 0
        Me.btnProcurarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarItem.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarItem.Location = New System.Drawing.Point(464, 62)
        Me.btnProcurarItem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarItem.Name = "btnProcurarItem"
        Me.btnProcurarItem.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarItem.TabIndex = 16
        Me.btnProcurarItem.TabStop = False
        Me.btnProcurarItem.UseVisualStyleBackColor = True
        '
        'cboItem
        '
        Me.cboItem.AutoSize = False
        Me.cboItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboItem.Location = New System.Drawing.Point(10, 80)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboItem.Size = New System.Drawing.Size(471, 20)
        Me.cboItem.TabIndex = 15
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblItem.Location = New System.Drawing.Point(7, 63)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(29, 14)
        Me.lblItem.TabIndex = 14
        Me.lblItem.Text = "Item:"
        '
        'btnProcurarFornecedor
        '
        Me.btnProcurarFornecedor.FlatAppearance.BorderSize = 0
        Me.btnProcurarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarFornecedor.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarFornecedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarFornecedor.Location = New System.Drawing.Point(464, 16)
        Me.btnProcurarFornecedor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarFornecedor.Name = "btnProcurarFornecedor"
        Me.btnProcurarFornecedor.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarFornecedor.TabIndex = 17
        Me.btnProcurarFornecedor.TabStop = False
        Me.btnProcurarFornecedor.UseVisualStyleBackColor = True
        '
        'usrCmp000000003
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCmp000000003"
        Me.Size = New System.Drawing.Size(507, 446)
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
    Friend WithEvents cboFornecedor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents dtpDataPrevisaoEntregaTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPrevisaoEntregaInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataPrevisaoEntregaFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataPedidoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataPedidoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataPedido As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboStatusFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents cboUFFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblUFFiltro As System.Windows.Forms.Label
    Friend WithEvents cboPais As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblPais As System.Windows.Forms.Label
    Friend WithEvents btnProcurarItem As System.Windows.Forms.Button
    Friend WithEvents cboItem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents btnProcurarFornecedor As System.Windows.Forms.Button

End Class
