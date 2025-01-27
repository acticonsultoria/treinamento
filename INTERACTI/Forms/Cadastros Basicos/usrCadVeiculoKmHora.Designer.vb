<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadVeiculoKmHora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadVeiculoKmHora))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem
        Dim UiComboBoxItem5 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem
        Dim UiComboBoxItem6 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage
        Me.grdListagem = New Janus.Windows.GridEX.GridEX
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.cboCentroGastoFiltro = New Janus.Windows.EditControls.UIComboBox
        Me.lblCentroGastoFiltro = New System.Windows.Forms.Label
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton
        Me.txtRenavanFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.lblRenavanFiltro = New System.Windows.Forms.Label
        Me.txtPlacaFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.lblPlacaFiltro = New System.Windows.Forms.Label
        Me.txtNumeroSerieFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.lblNumeroSerieFiltro = New System.Windows.Forms.Label
        Me.lblAnoFiltro = New System.Windows.Forms.Label
        Me.cboAnoFiltro = New Janus.Windows.EditControls.UIComboBox
        Me.txtDescricaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.lblDescricaoFiltro = New System.Windows.Forms.Label
        Me.cboTipoVeiculoFiltro = New Janus.Windows.EditControls.UIComboBox
        Me.lblTipoVeiculoFiltro = New System.Windows.Forms.Label
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox
        Me.btnExcel = New Janus.Windows.EditControls.UIButton
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton
        Me.btnSair = New Janus.Windows.EditControls.UIButton
        Me.UiComboBox1 = New Janus.Windows.EditControls.UIComboBox
        Me.UiComboBox2 = New Janus.Windows.EditControls.UIComboBox
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
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
        resources.ApplyResources(Me.tabMain, "tabMain")
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.UiGroupBox1)
        Me.pagLista.Controls.Add(Me.grpControl)
        resources.ApplyResources(Me.pagLista, "pagLista")
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Name = "pagLista"
        Me.pagLista.TabStop = True
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        resources.ApplyResources(grdListagem_DesignTimeLayout, "grdListagem_DesignTimeLayout")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        resources.ApplyResources(Me.grdListagem, "grdListagem")
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.TabStop = False
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.cboCentroGastoFiltro)
        Me.UiGroupBox1.Controls.Add(Me.lblCentroGastoFiltro)
        Me.UiGroupBox1.Controls.Add(Me.btnFiltrar)
        Me.UiGroupBox1.Controls.Add(Me.txtRenavanFiltro)
        Me.UiGroupBox1.Controls.Add(Me.lblRenavanFiltro)
        Me.UiGroupBox1.Controls.Add(Me.txtPlacaFiltro)
        Me.UiGroupBox1.Controls.Add(Me.lblPlacaFiltro)
        Me.UiGroupBox1.Controls.Add(Me.txtNumeroSerieFiltro)
        Me.UiGroupBox1.Controls.Add(Me.lblNumeroSerieFiltro)
        Me.UiGroupBox1.Controls.Add(Me.lblAnoFiltro)
        Me.UiGroupBox1.Controls.Add(Me.cboAnoFiltro)
        Me.UiGroupBox1.Controls.Add(Me.txtDescricaoFiltro)
        Me.UiGroupBox1.Controls.Add(Me.lblDescricaoFiltro)
        Me.UiGroupBox1.Controls.Add(Me.cboTipoVeiculoFiltro)
        Me.UiGroupBox1.Controls.Add(Me.lblTipoVeiculoFiltro)
        resources.ApplyResources(Me.UiGroupBox1, "UiGroupBox1")
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'cboCentroGastoFiltro
        '
        resources.ApplyResources(Me.cboCentroGastoFiltro, "cboCentroGastoFiltro")
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem1, "UiComboBoxItem1")
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem2, "UiComboBoxItem2")
        Me.cboCentroGastoFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboCentroGastoFiltro.Name = "cboCentroGastoFiltro"
        Me.cboCentroGastoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblCentroGastoFiltro
        '
        resources.ApplyResources(Me.lblCentroGastoFiltro, "lblCentroGastoFiltro")
        Me.lblCentroGastoFiltro.Name = "lblCentroGastoFiltro"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnFiltrar, "btnFiltrar")
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtRenavanFiltro
        '
        Me.txtRenavanFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtRenavanFiltro, "txtRenavanFiltro")
        Me.txtRenavanFiltro.MaxLength = 50
        Me.txtRenavanFiltro.Name = "txtRenavanFiltro"
        '
        'lblRenavanFiltro
        '
        resources.ApplyResources(Me.lblRenavanFiltro, "lblRenavanFiltro")
        Me.lblRenavanFiltro.Name = "lblRenavanFiltro"
        '
        'txtPlacaFiltro
        '
        Me.txtPlacaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtPlacaFiltro, "txtPlacaFiltro")
        Me.txtPlacaFiltro.Mask = "LLL-0000"
        Me.txtPlacaFiltro.Name = "txtPlacaFiltro"
        '
        'lblPlacaFiltro
        '
        resources.ApplyResources(Me.lblPlacaFiltro, "lblPlacaFiltro")
        Me.lblPlacaFiltro.Name = "lblPlacaFiltro"
        '
        'txtNumeroSerieFiltro
        '
        Me.txtNumeroSerieFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtNumeroSerieFiltro, "txtNumeroSerieFiltro")
        Me.txtNumeroSerieFiltro.MaxLength = 50
        Me.txtNumeroSerieFiltro.Name = "txtNumeroSerieFiltro"
        '
        'lblNumeroSerieFiltro
        '
        resources.ApplyResources(Me.lblNumeroSerieFiltro, "lblNumeroSerieFiltro")
        Me.lblNumeroSerieFiltro.Name = "lblNumeroSerieFiltro"
        '
        'lblAnoFiltro
        '
        resources.ApplyResources(Me.lblAnoFiltro, "lblAnoFiltro")
        Me.lblAnoFiltro.Name = "lblAnoFiltro"
        '
        'cboAnoFiltro
        '
        resources.ApplyResources(Me.cboAnoFiltro, "cboAnoFiltro")
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem3, "UiComboBoxItem3")
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem4, "UiComboBoxItem4")
        Me.cboAnoFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem3, UiComboBoxItem4})
        Me.cboAnoFiltro.Name = "cboAnoFiltro"
        Me.cboAnoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtDescricaoFiltro
        '
        Me.txtDescricaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtDescricaoFiltro, "txtDescricaoFiltro")
        Me.txtDescricaoFiltro.MaxLength = 50
        Me.txtDescricaoFiltro.Name = "txtDescricaoFiltro"
        '
        'lblDescricaoFiltro
        '
        resources.ApplyResources(Me.lblDescricaoFiltro, "lblDescricaoFiltro")
        Me.lblDescricaoFiltro.Name = "lblDescricaoFiltro"
        '
        'cboTipoVeiculoFiltro
        '
        resources.ApplyResources(Me.cboTipoVeiculoFiltro, "cboTipoVeiculoFiltro")
        UiComboBoxItem5.FormatStyle.Alpha = 0
        UiComboBoxItem5.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem5, "UiComboBoxItem5")
        UiComboBoxItem6.FormatStyle.Alpha = 0
        UiComboBoxItem6.IsSeparator = False
        resources.ApplyResources(UiComboBoxItem6, "UiComboBoxItem6")
        Me.cboTipoVeiculoFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem5, UiComboBoxItem6})
        Me.cboTipoVeiculoFiltro.Name = "cboTipoVeiculoFiltro"
        Me.cboTipoVeiculoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblTipoVeiculoFiltro
        '
        resources.ApplyResources(Me.lblTipoVeiculoFiltro, "lblTipoVeiculoFiltro")
        Me.lblTipoVeiculoFiltro.Name = "lblTipoVeiculoFiltro"
        '
        'grpControl
        '
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnExcel)
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Controls.Add(Me.btnSair)
        resources.ApplyResources(Me.grpControl, "grpControl")
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnExcel
        '
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnExcel, "btnExcel")
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnSalvar, "btnSalvar")
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        resources.ApplyResources(Me.btnSair, "btnSair")
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'UiComboBox1
        '
        resources.ApplyResources(Me.UiComboBox1, "UiComboBox1")
        Me.UiComboBox1.Name = "UiComboBox1"
        '
        'UiComboBox2
        '
        resources.ApplyResources(Me.UiComboBox2, "UiComboBox2")
        Me.UiComboBox2.Name = "UiComboBox2"
        '
        'usrCadVeiculoKmHora
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrCadVeiculoKmHora"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiComboBox1 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents UiComboBox2 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboCentroGastoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCentroGastoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtRenavanFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRenavanFiltro As System.Windows.Forms.Label
    Friend WithEvents txtPlacaFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPlacaFiltro As System.Windows.Forms.Label
    Friend WithEvents txtNumeroSerieFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroSerieFiltro As System.Windows.Forms.Label
    Friend WithEvents lblAnoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboAnoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtDescricaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricaoFiltro As System.Windows.Forms.Label
    Friend WithEvents cboTipoVeiculoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoVeiculoFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX

End Class
