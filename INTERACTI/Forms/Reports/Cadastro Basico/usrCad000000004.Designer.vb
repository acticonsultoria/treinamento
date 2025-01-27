<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCad000000004
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
        Dim cboParceiroNegocio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCad000000004))
        Dim cboUFFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboSegmentoFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cboVendedorFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.picSistema = New System.Windows.Forms.PictureBox()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboParceiroNegocio = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblParceiroNegocio = New System.Windows.Forms.Label()
        Me.txtMunicipio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.cboUFFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblUFFiltro = New System.Windows.Forms.Label()
        Me.cboSegmentoFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblSegmentoFiltro = New System.Windows.Forms.Label()
        Me.cboVendedorFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblVendedor = New System.Windows.Forms.Label()
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
        Me.tabMain.Size = New System.Drawing.Size(507, 393)
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
        Me.pagLista.Size = New System.Drawing.Size(505, 370)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório Cadastro Básico - CAD000000004"
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
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboParceiroNegocio)
        Me.grpFiltro.Controls.Add(Me.lblParceiroNegocio)
        Me.grpFiltro.Controls.Add(Me.txtMunicipio)
        Me.grpFiltro.Controls.Add(Me.lblMunicipio)
        Me.grpFiltro.Controls.Add(Me.cboUFFiltro)
        Me.grpFiltro.Controls.Add(Me.lblUFFiltro)
        Me.grpFiltro.Controls.Add(Me.cboSegmentoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblSegmentoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboVendedorFiltro)
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
        'cboParceiroNegocio
        '
        Me.cboParceiroNegocio.AllowDrop = True
        Me.cboParceiroNegocio.ButtonCancelText = "Cancelar"
        Me.cboParceiroNegocio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboParceiroNegocio_DesignTimeLayout.LayoutString = resources.GetString("cboParceiroNegocio_DesignTimeLayout.LayoutString")
        Me.cboParceiroNegocio.DesignTimeLayout = cboParceiroNegocio_DesignTimeLayout
        Me.cboParceiroNegocio.Location = New System.Drawing.Point(10, 117)
        Me.cboParceiroNegocio.Name = "cboParceiroNegocio"
        Me.cboParceiroNegocio.SaveSettings = False
        Me.cboParceiroNegocio.SettingsKey = "cboDestinacaoFiltro"
        Me.cboParceiroNegocio.Size = New System.Drawing.Size(470, 20)
        Me.cboParceiroNegocio.TabIndex = 5
        Me.cboParceiroNegocio.ValuesDataMember = Nothing
        '
        'lblParceiroNegocio
        '
        Me.lblParceiroNegocio.AutoSize = True
        Me.lblParceiroNegocio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblParceiroNegocio.Location = New System.Drawing.Point(7, 100)
        Me.lblParceiroNegocio.Name = "lblParceiroNegocio"
        Me.lblParceiroNegocio.Size = New System.Drawing.Size(42, 14)
        Me.lblParceiroNegocio.TabIndex = 4
        Me.lblParceiroNegocio.Text = "Cliente:"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMunicipio.Location = New System.Drawing.Point(135, 157)
        Me.txtMunicipio.MaxLength = 60
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(345, 20)
        Me.txtMunicipio.TabIndex = 9
        '
        'lblMunicipio
        '
        Me.lblMunicipio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMunicipio.Location = New System.Drawing.Point(132, 140)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(54, 14)
        Me.lblMunicipio.TabIndex = 8
        Me.lblMunicipio.Text = "Município:"
        '
        'cboUFFiltro
        '
        Me.cboUFFiltro.AllowDrop = True
        Me.cboUFFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboUFFiltro.ButtonCancelText = "Cancelar"
        Me.cboUFFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboUFFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboUFFiltro_DesignTimeLayout.LayoutString")
        Me.cboUFFiltro.DesignTimeLayout = cboUFFiltro_DesignTimeLayout
        Me.cboUFFiltro.Location = New System.Drawing.Point(10, 157)
        Me.cboUFFiltro.Name = "cboUFFiltro"
        Me.cboUFFiltro.SaveSettings = False
        Me.cboUFFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboUFFiltro.Size = New System.Drawing.Size(119, 20)
        Me.cboUFFiltro.TabIndex = 7
        Me.cboUFFiltro.ValuesDataMember = Nothing
        '
        'lblUFFiltro
        '
        Me.lblUFFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUFFiltro.AutoSize = True
        Me.lblUFFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUFFiltro.Location = New System.Drawing.Point(7, 140)
        Me.lblUFFiltro.Name = "lblUFFiltro"
        Me.lblUFFiltro.Size = New System.Drawing.Size(23, 14)
        Me.lblUFFiltro.TabIndex = 6
        Me.lblUFFiltro.Text = "UF:"
        '
        'cboSegmentoFiltro
        '
        Me.cboSegmentoFiltro.AllowDrop = True
        Me.cboSegmentoFiltro.ButtonCancelText = "Cancelar"
        Me.cboSegmentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboSegmentoFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboSegmentoFiltro_DesignTimeLayout.LayoutString")
        Me.cboSegmentoFiltro.DesignTimeLayout = cboSegmentoFiltro_DesignTimeLayout
        Me.cboSegmentoFiltro.Location = New System.Drawing.Point(10, 77)
        Me.cboSegmentoFiltro.Name = "cboSegmentoFiltro"
        Me.cboSegmentoFiltro.SaveSettings = False
        Me.cboSegmentoFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboSegmentoFiltro.Size = New System.Drawing.Size(470, 20)
        Me.cboSegmentoFiltro.TabIndex = 3
        Me.cboSegmentoFiltro.ValuesDataMember = Nothing
        '
        'lblSegmentoFiltro
        '
        Me.lblSegmentoFiltro.AutoSize = True
        Me.lblSegmentoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSegmentoFiltro.Location = New System.Drawing.Point(7, 60)
        Me.lblSegmentoFiltro.Name = "lblSegmentoFiltro"
        Me.lblSegmentoFiltro.Size = New System.Drawing.Size(58, 14)
        Me.lblSegmentoFiltro.TabIndex = 2
        Me.lblSegmentoFiltro.Text = "Segmento:"
        '
        'cboVendedorFiltro
        '
        Me.cboVendedorFiltro.AllowDrop = True
        Me.cboVendedorFiltro.ButtonCancelText = "Cancelar"
        Me.cboVendedorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboVendedorFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboVendedorFiltro_DesignTimeLayout.LayoutString")
        Me.cboVendedorFiltro.DesignTimeLayout = cboVendedorFiltro_DesignTimeLayout
        Me.cboVendedorFiltro.Location = New System.Drawing.Point(10, 37)
        Me.cboVendedorFiltro.Name = "cboVendedorFiltro"
        Me.cboVendedorFiltro.SaveSettings = False
        Me.cboVendedorFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboVendedorFiltro.Size = New System.Drawing.Size(470, 20)
        Me.cboVendedorFiltro.TabIndex = 1
        Me.cboVendedorFiltro.ValuesDataMember = Nothing
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVendedor.Location = New System.Drawing.Point(7, 20)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(57, 14)
        Me.lblVendedor.TabIndex = 0
        Me.lblVendedor.Text = "Vendedor:"
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
        'usrCad000000004
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCad000000004"
        Me.Size = New System.Drawing.Size(507, 393)
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
    Friend WithEvents lblVendedor As System.Windows.Forms.Label
    Friend WithEvents picSistema As System.Windows.Forms.PictureBox
    Friend WithEvents btnVisualizarImpressao As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboUFFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblUFFiltro As System.Windows.Forms.Label
    Friend WithEvents cboSegmentoFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblSegmentoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboVendedorFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents cboParceiroNegocio As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblParceiroNegocio As System.Windows.Forms.Label
    Friend WithEvents txtMunicipio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMunicipio As System.Windows.Forms.Label

End Class
