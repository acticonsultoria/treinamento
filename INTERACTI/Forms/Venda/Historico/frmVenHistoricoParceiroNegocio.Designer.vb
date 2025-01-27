<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenHistoricoParceiroNegocio
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
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdVendas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenHistoricoParceiroNegocio))
        Dim grdCompras_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabHistorico = New Janus.Windows.UI.Tab.UITab()
        Me.pagHistorico = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.txtMunicipio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.txtUF = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCNPJ = New System.Windows.Forms.Label()
        Me.txtParceiroNegocio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblParceiroNegocio = New System.Windows.Forms.Label()
        Me.txtCNPJ = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdVendas = New Janus.Windows.GridEX.GridEX()
        Me.pagCompra = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdCompras = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHistorico.SuspendLayout()
        Me.pagHistorico.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grdVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagCompra.SuspendLayout()
        CType(Me.grdCompras, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'tabHistorico
        '
        Me.tabHistorico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabHistorico.Location = New System.Drawing.Point(7, 7)
        Me.tabHistorico.Name = "tabHistorico"
        Me.tabHistorico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabHistorico.Size = New System.Drawing.Size(899, 524)
        Me.tabHistorico.TabIndex = 1
        Me.tabHistorico.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagHistorico})
        Me.tabHistorico.TabStop = False
        Me.tabHistorico.VisualStyleManager = Me.vsmMain
        '
        'pagHistorico
        '
        Me.pagHistorico.Controls.Add(Me.grpDados)
        Me.pagHistorico.Controls.Add(Me.tabMain)
        Me.pagHistorico.Key = "pagHistorico"
        Me.pagHistorico.Location = New System.Drawing.Point(1, 22)
        Me.pagHistorico.Name = "pagHistorico"
        Me.pagHistorico.Size = New System.Drawing.Size(897, 501)
        Me.pagHistorico.TabStop = True
        Me.pagHistorico.Text = "Histórico do Parceiro de Negócio"
        '
        'grpDados
        '
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblMunicipio)
        Me.grpDados.Controls.Add(Me.txtMunicipio)
        Me.grpDados.Controls.Add(Me.lblUF)
        Me.grpDados.Controls.Add(Me.txtUF)
        Me.grpDados.Controls.Add(Me.lblCNPJ)
        Me.grpDados.Controls.Add(Me.txtParceiroNegocio)
        Me.grpDados.Controls.Add(Me.lblParceiroNegocio)
        Me.grpDados.Controls.Add(Me.txtCNPJ)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(881, 67)
        Me.grpDados.TabIndex = 6
        Me.grpDados.Text = "Dados do Parceiro de Negócio"
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMunicipio.Location = New System.Drawing.Point(638, 20)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(54, 14)
        Me.lblMunicipio.TabIndex = 17
        Me.lblMunicipio.Text = "Município:"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMunicipio.Location = New System.Drawing.Point(641, 37)
        Me.txtMunicipio.MaxLength = 14
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.ReadOnly = True
        Me.txtMunicipio.Size = New System.Drawing.Size(231, 20)
        Me.txtMunicipio.TabIndex = 18
        Me.txtMunicipio.TabStop = False
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUF.Location = New System.Drawing.Point(588, 20)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(23, 14)
        Me.lblUF.TabIndex = 15
        Me.lblUF.Text = "UF:"
        '
        'txtUF
        '
        Me.txtUF.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUF.Location = New System.Drawing.Point(591, 37)
        Me.txtUF.MaxLength = 14
        Me.txtUF.Name = "txtUF"
        Me.txtUF.ReadOnly = True
        Me.txtUF.Size = New System.Drawing.Size(44, 20)
        Me.txtUF.TabIndex = 16
        Me.txtUF.TabStop = False
        '
        'lblCNPJ
        '
        Me.lblCNPJ.AutoSize = True
        Me.lblCNPJ.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCNPJ.Location = New System.Drawing.Point(6, 20)
        Me.lblCNPJ.Name = "lblCNPJ"
        Me.lblCNPJ.Size = New System.Drawing.Size(35, 14)
        Me.lblCNPJ.TabIndex = 13
        Me.lblCNPJ.Text = "CNPJ:"
        '
        'txtParceiroNegocio
        '
        Me.txtParceiroNegocio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtParceiroNegocio.Location = New System.Drawing.Point(138, 37)
        Me.txtParceiroNegocio.MaxLength = 120
        Me.txtParceiroNegocio.Name = "txtParceiroNegocio"
        Me.txtParceiroNegocio.ReadOnly = True
        Me.txtParceiroNegocio.Size = New System.Drawing.Size(447, 20)
        Me.txtParceiroNegocio.TabIndex = 4
        Me.txtParceiroNegocio.TabStop = False
        '
        'lblParceiroNegocio
        '
        Me.lblParceiroNegocio.AutoSize = True
        Me.lblParceiroNegocio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblParceiroNegocio.Location = New System.Drawing.Point(135, 20)
        Me.lblParceiroNegocio.Name = "lblParceiroNegocio"
        Me.lblParceiroNegocio.Size = New System.Drawing.Size(107, 14)
        Me.lblParceiroNegocio.TabIndex = 3
        Me.lblParceiroNegocio.Text = "Parceiro de Negócio:"
        '
        'txtCNPJ
        '
        Me.txtCNPJ.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCNPJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCNPJ.Location = New System.Drawing.Point(9, 37)
        Me.txtCNPJ.MaxLength = 14
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.ReadOnly = True
        Me.txtCNPJ.Size = New System.Drawing.Size(123, 20)
        Me.txtCNPJ.TabIndex = 14
        Me.txtCNPJ.TabStop = False
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Location = New System.Drawing.Point(8, 76)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(881, 417)
        Me.tabMain.TabIndex = 1
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela, Me.pagCompra})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grdVendas)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(879, 394)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Vendas"
        '
        'grdVendas
        '
        Me.grdVendas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdVendas.AlternatingColors = True
        Me.grdVendas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdVendas.AutoEdit = True
        grdVendas_DesignTimeLayout.LayoutString = resources.GetString("grdVendas_DesignTimeLayout.LayoutString")
        Me.grdVendas.DesignTimeLayout = grdVendas_DesignTimeLayout
        Me.grdVendas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdVendas.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdVendas.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdVendas.FilterRowFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.[True]
        Me.grdVendas.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdVendas.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdVendas.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdVendas.FrozenColumns = 5
        Me.grdVendas.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdVendas.GroupByBoxVisible = False
        Me.grdVendas.Location = New System.Drawing.Point(8, 8)
        Me.grdVendas.Name = "grdVendas"
        Me.grdVendas.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdVendas.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdVendas.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdVendas.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdVendas.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdVendas.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdVendas.Size = New System.Drawing.Size(863, 378)
        Me.grdVendas.TabIndex = 3
        Me.grdVendas.TabStop = False
        Me.grdVendas.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdVendas.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdVendas.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdVendas.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdVendas.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdVendas.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdVendas.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdVendas.VisualStyleManager = Me.vsmMain
        '
        'pagCompra
        '
        Me.pagCompra.Controls.Add(Me.grdCompras)
        Me.pagCompra.Key = "pagCompra"
        Me.pagCompra.Location = New System.Drawing.Point(1, 22)
        Me.pagCompra.Name = "pagCompra"
        Me.pagCompra.Size = New System.Drawing.Size(879, 394)
        Me.pagCompra.TabStop = True
        Me.pagCompra.Text = "Compras"
        '
        'grdCompras
        '
        Me.grdCompras.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdCompras.AlternatingColors = True
        Me.grdCompras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCompras.AutoEdit = True
        grdCompras_DesignTimeLayout.LayoutString = resources.GetString("grdCompras_DesignTimeLayout.LayoutString")
        Me.grdCompras.DesignTimeLayout = grdCompras_DesignTimeLayout
        Me.grdCompras.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdCompras.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdCompras.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdCompras.FilterRowFormatStyle.FontItalic = Janus.Windows.GridEX.TriState.[True]
        Me.grdCompras.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdCompras.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdCompras.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdCompras.FrozenColumns = 5
        Me.grdCompras.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdCompras.GroupByBoxVisible = False
        Me.grdCompras.Location = New System.Drawing.Point(8, 8)
        Me.grdCompras.Name = "grdCompras"
        Me.grdCompras.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdCompras.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdCompras.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdCompras.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdCompras.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdCompras.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdCompras.Size = New System.Drawing.Size(863, 378)
        Me.grdCompras.TabIndex = 8
        Me.grdCompras.TabStop = False
        Me.grdCompras.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdCompras.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdCompras.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdCompras.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdCompras.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdCompras.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdCompras.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdCompras.VisualStyleManager = Me.vsmMain
        '
        'frmVenHistoricoParceiroNegocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 538)
        Me.Controls.Add(Me.tabHistorico)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVenHistoricoParceiroNegocio"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Histórico do Parceiro de Negócio"
        CType(Me.tabHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHistorico.ResumeLayout(False)
        Me.pagHistorico.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grdVendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagCompra.ResumeLayout(False)
        CType(Me.grdCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabHistorico As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagHistorico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtParceiroNegocio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblParceiroNegocio As System.Windows.Forms.Label
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents pagCompra As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents lblMunicipio As System.Windows.Forms.Label
    Friend WithEvents txtMunicipio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblUF As System.Windows.Forms.Label
    Friend WithEvents txtUF As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCNPJ As System.Windows.Forms.Label
    Friend WithEvents txtCNPJ As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grdVendas As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdCompras As Janus.Windows.GridEX.GridEX
End Class
