<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCmpPedidoDataEntradaFisica
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
        Dim grdEntradaFisica_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCmpPedidoDataEntradaFisica))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdEntradaFisica = New Janus.Windows.GridEX.GridEX()
        Me.grpMotivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataEntradaFisica = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataEntradaFisica = New System.Windows.Forms.Label()
        Me.txtDataPedido = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataPedido = New System.Windows.Forms.Label()
        Me.txtCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtNumeroPedido = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroPedido = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabMain.SuspendLayout
        Me.pagTabela.SuspendLayout
        CType(Me.grdEntradaFisica,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.grpMotivo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpMotivo.SuspendLayout
        CType(Me.grpControl2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpControl2.SuspendLayout
        Me.SuspendLayout
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
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(705, 407)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = false
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.btnConfigurarGrid)
        Me.pagTabela.Controls.Add(Me.grdEntradaFisica)
        Me.pagTabela.Controls.Add(Me.grpMotivo)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(703, 384)
        Me.pagTabela.TabStop = true
        Me.pagTabela.Text = "Entrada Física"
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 304)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(48, 15)
        Me.btnConfigurarGrid.TabIndex = 14
        Me.btnConfigurarGrid.TabStop = false
        Me.btnConfigurarGrid.UseVisualStyleBackColor = false
        '
        'grdEntradaFisica
        '
        Me.grdEntradaFisica.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdEntradaFisica.AlternatingColors = true
        Me.grdEntradaFisica.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grdEntradaFisica.ColumnAutoResize = true
        grdEntradaFisica_DesignTimeLayout.LayoutString = resources.GetString("grdEntradaFisica_DesignTimeLayout.LayoutString")
        Me.grdEntradaFisica.DesignTimeLayout = grdEntradaFisica_DesignTimeLayout
        Me.grdEntradaFisica.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdEntradaFisica.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdEntradaFisica.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdEntradaFisica.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdEntradaFisica.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdEntradaFisica.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdEntradaFisica.GroupByBoxVisible = false
        Me.grdEntradaFisica.Location = New System.Drawing.Point(8, 121)
        Me.grdEntradaFisica.Name = "grdEntradaFisica"
        Me.grdEntradaFisica.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdEntradaFisica.RecordNavigator = true
        Me.grdEntradaFisica.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdEntradaFisica.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdEntradaFisica.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdEntradaFisica.Size = New System.Drawing.Size(687, 200)
        Me.grdEntradaFisica.TabIndex = 6
        Me.grdEntradaFisica.TabStop = false
        Me.grdEntradaFisica.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdEntradaFisica.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdEntradaFisica.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdEntradaFisica.VisualStyleManager = Me.vsmMain
        '
        'grpMotivo
        '
        Me.grpMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpMotivo.BackColor = System.Drawing.Color.Transparent
        Me.grpMotivo.Controls.Add(Me.dtpDataEntradaFisica)
        Me.grpMotivo.Controls.Add(Me.lblDataEntradaFisica)
        Me.grpMotivo.Controls.Add(Me.txtDataPedido)
        Me.grpMotivo.Controls.Add(Me.lblDataPedido)
        Me.grpMotivo.Controls.Add(Me.txtCliente)
        Me.grpMotivo.Controls.Add(Me.lblCliente)
        Me.grpMotivo.Controls.Add(Me.txtNumeroPedido)
        Me.grpMotivo.Controls.Add(Me.lblNumeroPedido)
        Me.grpMotivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMotivo.Location = New System.Drawing.Point(8, 3)
        Me.grpMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMotivo.Name = "grpMotivo"
        Me.grpMotivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMotivo.Size = New System.Drawing.Size(687, 111)
        Me.grpMotivo.TabIndex = 0
        Me.grpMotivo.Text = "Dados do Pedido"
        Me.grpMotivo.VisualStyleManager = Me.vsmMain
        '
        'dtpDataEntradaFisica
        '
        '
        '
        '
        Me.dtpDataEntradaFisica.DropDownCalendar.Name = ""
        Me.dtpDataEntradaFisica.Location = New System.Drawing.Point(9, 77)
        Me.dtpDataEntradaFisica.Name = "dtpDataEntradaFisica"
        Me.dtpDataEntradaFisica.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataEntradaFisica.TabIndex = 14
        '
        'lblDataEntradaFisica
        '
        Me.lblDataEntradaFisica.AutoSize = true
        Me.lblDataEntradaFisica.Location = New System.Drawing.Point(6, 60)
        Me.lblDataEntradaFisica.Name = "lblDataEntradaFisica"
        Me.lblDataEntradaFisica.Size = New System.Drawing.Size(103, 14)
        Me.lblDataEntradaFisica.TabIndex = 13
        Me.lblDataEntradaFisica.Text = "Data Entrada Física:"
        '
        'txtDataPedido
        '
        Me.txtDataPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataPedido.Location = New System.Drawing.Point(115, 37)
        Me.txtDataPedido.MaxLength = 250
        Me.txtDataPedido.Name = "txtDataPedido"
        Me.txtDataPedido.ReadOnly = true
        Me.txtDataPedido.Size = New System.Drawing.Size(100, 20)
        Me.txtDataPedido.TabIndex = 3
        Me.txtDataPedido.TabStop = false
        '
        'lblDataPedido
        '
        Me.lblDataPedido.AutoSize = true
        Me.lblDataPedido.Location = New System.Drawing.Point(112, 20)
        Me.lblDataPedido.Name = "lblDataPedido"
        Me.lblDataPedido.Size = New System.Drawing.Size(67, 14)
        Me.lblDataPedido.TabIndex = 2
        Me.lblDataPedido.Text = "Data Pedido:"
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtCliente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(221, 37)
        Me.txtCliente.MaxLength = 250
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = true
        Me.txtCliente.Size = New System.Drawing.Size(457, 20)
        Me.txtCliente.TabIndex = 5
        Me.txtCliente.TabStop = false
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = true
        Me.lblCliente.Location = New System.Drawing.Point(218, 20)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 4
        Me.lblCliente.Text = "Cliente:"
        '
        'txtNumeroPedido
        '
        Me.txtNumeroPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroPedido.Location = New System.Drawing.Point(9, 37)
        Me.txtNumeroPedido.MaxLength = 250
        Me.txtNumeroPedido.Name = "txtNumeroPedido"
        Me.txtNumeroPedido.ReadOnly = true
        Me.txtNumeroPedido.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroPedido.TabIndex = 1
        Me.txtNumeroPedido.TabStop = false
        '
        'lblNumeroPedido
        '
        Me.lblNumeroPedido.AutoSize = true
        Me.lblNumeroPedido.Location = New System.Drawing.Point(6, 20)
        Me.lblNumeroPedido.Name = "lblNumeroPedido"
        Me.lblNumeroPedido.Size = New System.Drawing.Size(57, 14)
        Me.lblNumeroPedido.TabIndex = 0
        Me.lblNumeroPedido.Text = "Nº Pedido:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 324)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(687, 51)
        Me.grpControl2.TabIndex = 2
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(490, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 4
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"),System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(587, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmCmpPedidoDataEntradaFisica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 14!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 422)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmCmpPedidoDataEntradaFisica"
        Me.ShowInTaskbar = false
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Entrada Física"
        CType(Me.tabMain,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabMain.ResumeLayout(false)
        Me.pagTabela.ResumeLayout(false)
        CType(Me.grdEntradaFisica,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.grpMotivo,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpMotivo.ResumeLayout(false)
        Me.grpMotivo.PerformLayout
        CType(Me.grpControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpControl2.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpMotivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDataPedido As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataPedido As System.Windows.Forms.Label
    Friend WithEvents txtCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPedido As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroPedido As System.Windows.Forms.Label
    Friend WithEvents grdEntradaFisica As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents dtpDataEntradaFisica As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataEntradaFisica As System.Windows.Forms.Label
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
End Class
