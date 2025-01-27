<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActMaps
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActMaps))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtMunicipioDestino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtMunicipioPadrao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMunicipioDestino = New System.Windows.Forms.Label()
        Me.txtCEPDestino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCEPDestino = New System.Windows.Forms.Label()
        Me.txtEnderecoDestino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEnderecoDestino = New System.Windows.Forms.Label()
        Me.lblCidadePadrao = New System.Windows.Forms.Label()
        Me.txtCEPPadrao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCEPPadrao = New System.Windows.Forms.Label()
        Me.txtEnderecoPadrao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEnderecoPadrao = New System.Windows.Forms.Label()
        Me.grpMapa = New Janus.Windows.EditControls.UIGroupBox()
        Me.webMain = New System.Windows.Forms.WebBrowser()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnIr = New Janus.Windows.EditControls.UIButton()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpMapa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMapa.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        Me.vsmMain.DefaultColorScheme = Nothing
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtMunicipioDestino)
        Me.grpFiltro.Controls.Add(Me.txtMunicipioPadrao)
        Me.grpFiltro.Controls.Add(Me.lblMunicipioDestino)
        Me.grpFiltro.Controls.Add(Me.txtCEPDestino)
        Me.grpFiltro.Controls.Add(Me.lblCEPDestino)
        Me.grpFiltro.Controls.Add(Me.txtEnderecoDestino)
        Me.grpFiltro.Controls.Add(Me.lblEnderecoDestino)
        Me.grpFiltro.Controls.Add(Me.lblCidadePadrao)
        Me.grpFiltro.Controls.Add(Me.txtCEPPadrao)
        Me.grpFiltro.Controls.Add(Me.lblCEPPadrao)
        Me.grpFiltro.Controls.Add(Me.txtEnderecoPadrao)
        Me.grpFiltro.Controls.Add(Me.lblEnderecoPadrao)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(7, 4)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(894, 107)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Endereço"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtMunicipioDestino
        '
        Me.txtMunicipioDestino.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMunicipioDestino.BackColor = System.Drawing.SystemColors.Info
        Me.txtMunicipioDestino.Location = New System.Drawing.Point(676, 77)
        Me.txtMunicipioDestino.MaxLength = 60
        Me.txtMunicipioDestino.Name = "txtMunicipioDestino"
        Me.txtMunicipioDestino.ReadOnly = True
        Me.txtMunicipioDestino.Size = New System.Drawing.Size(209, 20)
        Me.txtMunicipioDestino.TabIndex = 13
        Me.txtMunicipioDestino.TabStop = False
        '
        'txtMunicipioPadrao
        '
        Me.txtMunicipioPadrao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMunicipioPadrao.BackColor = System.Drawing.SystemColors.Info
        Me.txtMunicipioPadrao.Location = New System.Drawing.Point(676, 37)
        Me.txtMunicipioPadrao.MaxLength = 60
        Me.txtMunicipioPadrao.Name = "txtMunicipioPadrao"
        Me.txtMunicipioPadrao.ReadOnly = True
        Me.txtMunicipioPadrao.Size = New System.Drawing.Size(209, 20)
        Me.txtMunicipioPadrao.TabIndex = 12
        Me.txtMunicipioPadrao.TabStop = False
        '
        'lblMunicipioDestino
        '
        Me.lblMunicipioDestino.AutoSize = True
        Me.lblMunicipioDestino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMunicipioDestino.Location = New System.Drawing.Point(673, 60)
        Me.lblMunicipioDestino.Name = "lblMunicipioDestino"
        Me.lblMunicipioDestino.Size = New System.Drawing.Size(100, 14)
        Me.lblMunicipioDestino.TabIndex = 10
        Me.lblMunicipioDestino.Text = "Município - Destino:"
        '
        'txtCEPDestino
        '
        Me.txtCEPDestino.BackColor = System.Drawing.SystemColors.Info
        Me.txtCEPDestino.Location = New System.Drawing.Point(589, 77)
        Me.txtCEPDestino.Mask = "00000-###"
        Me.txtCEPDestino.MaxLength = 50
        Me.txtCEPDestino.Name = "txtCEPDestino"
        Me.txtCEPDestino.ReadOnly = True
        Me.txtCEPDestino.Size = New System.Drawing.Size(81, 20)
        Me.txtCEPDestino.TabIndex = 9
        Me.txtCEPDestino.TabStop = False
        '
        'lblCEPDestino
        '
        Me.lblCEPDestino.AutoSize = True
        Me.lblCEPDestino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCEPDestino.Location = New System.Drawing.Point(586, 60)
        Me.lblCEPDestino.Name = "lblCEPDestino"
        Me.lblCEPDestino.Size = New System.Drawing.Size(75, 14)
        Me.lblCEPDestino.TabIndex = 8
        Me.lblCEPDestino.Text = "CEP - Destino:"
        '
        'txtEnderecoDestino
        '
        Me.txtEnderecoDestino.BackColor = System.Drawing.SystemColors.Info
        Me.txtEnderecoDestino.Location = New System.Drawing.Point(9, 77)
        Me.txtEnderecoDestino.MaxLength = 60
        Me.txtEnderecoDestino.Name = "txtEnderecoDestino"
        Me.txtEnderecoDestino.ReadOnly = True
        Me.txtEnderecoDestino.Size = New System.Drawing.Size(574, 20)
        Me.txtEnderecoDestino.TabIndex = 7
        Me.txtEnderecoDestino.TabStop = False
        '
        'lblEnderecoDestino
        '
        Me.lblEnderecoDestino.AutoSize = True
        Me.lblEnderecoDestino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEnderecoDestino.Location = New System.Drawing.Point(6, 60)
        Me.lblEnderecoDestino.Name = "lblEnderecoDestino"
        Me.lblEnderecoDestino.Size = New System.Drawing.Size(102, 14)
        Me.lblEnderecoDestino.TabIndex = 6
        Me.lblEnderecoDestino.Text = "Endereço - Destino:"
        '
        'lblCidadePadrao
        '
        Me.lblCidadePadrao.AutoSize = True
        Me.lblCidadePadrao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCidadePadrao.Location = New System.Drawing.Point(673, 20)
        Me.lblCidadePadrao.Name = "lblCidadePadrao"
        Me.lblCidadePadrao.Size = New System.Drawing.Size(98, 14)
        Me.lblCidadePadrao.TabIndex = 4
        Me.lblCidadePadrao.Text = "Município - Padrão:"
        '
        'txtCEPPadrao
        '
        Me.txtCEPPadrao.BackColor = System.Drawing.SystemColors.Info
        Me.txtCEPPadrao.Location = New System.Drawing.Point(589, 37)
        Me.txtCEPPadrao.Mask = "00000-###"
        Me.txtCEPPadrao.MaxLength = 50
        Me.txtCEPPadrao.Name = "txtCEPPadrao"
        Me.txtCEPPadrao.ReadOnly = True
        Me.txtCEPPadrao.Size = New System.Drawing.Size(81, 20)
        Me.txtCEPPadrao.TabIndex = 3
        Me.txtCEPPadrao.TabStop = False
        '
        'lblCEPPadrao
        '
        Me.lblCEPPadrao.AutoSize = True
        Me.lblCEPPadrao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCEPPadrao.Location = New System.Drawing.Point(586, 20)
        Me.lblCEPPadrao.Name = "lblCEPPadrao"
        Me.lblCEPPadrao.Size = New System.Drawing.Size(73, 14)
        Me.lblCEPPadrao.TabIndex = 2
        Me.lblCEPPadrao.Text = "CEP - Padrão:"
        '
        'txtEnderecoPadrao
        '
        Me.txtEnderecoPadrao.BackColor = System.Drawing.SystemColors.Info
        Me.txtEnderecoPadrao.Location = New System.Drawing.Point(9, 37)
        Me.txtEnderecoPadrao.MaxLength = 60
        Me.txtEnderecoPadrao.Name = "txtEnderecoPadrao"
        Me.txtEnderecoPadrao.ReadOnly = True
        Me.txtEnderecoPadrao.Size = New System.Drawing.Size(574, 20)
        Me.txtEnderecoPadrao.TabIndex = 1
        Me.txtEnderecoPadrao.TabStop = False
        '
        'lblEnderecoPadrao
        '
        Me.lblEnderecoPadrao.AutoSize = True
        Me.lblEnderecoPadrao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEnderecoPadrao.Location = New System.Drawing.Point(6, 20)
        Me.lblEnderecoPadrao.Name = "lblEnderecoPadrao"
        Me.lblEnderecoPadrao.Size = New System.Drawing.Size(100, 14)
        Me.lblEnderecoPadrao.TabIndex = 0
        Me.lblEnderecoPadrao.Text = "Endereço - Padrão:"
        '
        'grpMapa
        '
        Me.grpMapa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMapa.BackColor = System.Drawing.Color.Transparent
        Me.grpMapa.Controls.Add(Me.webMain)
        Me.grpMapa.Location = New System.Drawing.Point(7, 114)
        Me.grpMapa.Name = "grpMapa"
        Me.grpMapa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMapa.Size = New System.Drawing.Size(894, 358)
        Me.grpMapa.TabIndex = 1
        Me.grpMapa.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpMapa.VisualStyleManager = Me.vsmMain
        '
        'webMain
        '
        Me.webMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webMain.Location = New System.Drawing.Point(3, 8)
        Me.webMain.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webMain.Name = "webMain"
        Me.webMain.Size = New System.Drawing.Size(888, 347)
        Me.webMain.TabIndex = 0
        Me.webMain.Url = New System.Uri("", System.UriKind.Relative)
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnIr)
        Me.grpControle.Controls.Add(Me.btnImprimir)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(7, 475)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(894, 51)
        Me.grpControle.TabIndex = 2
        Me.grpControle.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnIr
        '
        Me.btnIr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIr.Image = Global.INTERACTI.My.Resources.marcador
        Me.btnIr.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnIr.Location = New System.Drawing.Point(600, 17)
        Me.btnIr.Name = "btnIr"
        Me.btnIr.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnIr.Size = New System.Drawing.Size(91, 23)
        Me.btnIr.TabIndex = 0
        Me.btnIr.Text = "Ir"
        Me.btnIr.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(697, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImprimir.Size = New System.Drawing.Size(91, 23)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(794, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmActMaps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 534)
        Me.Controls.Add(Me.grpControle)
        Me.Controls.Add(Me.grpMapa)
        Me.Controls.Add(Me.grpFiltro)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmActMaps"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Exportar para Excel"
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpMapa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMapa.ResumeLayout(False)
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnIr As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpMapa As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents webMain As System.Windows.Forms.WebBrowser
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtMunicipioDestino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtMunicipioPadrao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMunicipioDestino As System.Windows.Forms.Label
    Friend WithEvents txtCEPDestino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCEPDestino As System.Windows.Forms.Label
    Friend WithEvents txtEnderecoDestino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblEnderecoDestino As System.Windows.Forms.Label
    Friend WithEvents lblCidadePadrao As System.Windows.Forms.Label
    Friend WithEvents txtCEPPadrao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCEPPadrao As System.Windows.Forms.Label
    Friend WithEvents txtEnderecoPadrao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblEnderecoPadrao As System.Windows.Forms.Label
End Class
