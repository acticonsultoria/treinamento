<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinTituloDuplicar
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
        Dim grdTitulo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinTituloDuplicar))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdTitulo = New Janus.Windows.GridEX.GridEX()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboTipoIntervalo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoIntervalo = New System.Windows.Forms.Label()
        Me.txtIntervaloEntreTitulos = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblIntervaloEntreTitulos = New System.Windows.Forms.Label()
        Me.txtNumeroTitulos = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblNumeroTitulos = New System.Windows.Forms.Label()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtParceiroNegocio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.lblParceiroNegocio = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnDuplicar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.dtpDataBase = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataBase = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grdTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInformacoes.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
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
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(580, 457)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grdTitulo)
        Me.pagTabela.Controls.Add(Me.UiGroupBox1)
        Me.pagTabela.Controls.Add(Me.grpInformacoes)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(578, 434)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Dados do Título"
        '
        'grdTitulo
        '
        Me.grdTitulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdTitulo.AutoEdit = True
        Me.grdTitulo.BlendColor = System.Drawing.SystemColors.WindowFrame
        grdTitulo_DesignTimeLayout.LayoutString = resources.GetString("grdTitulo_DesignTimeLayout.LayoutString")
        Me.grdTitulo.DesignTimeLayout = grdTitulo_DesignTimeLayout
        Me.grdTitulo.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdTitulo.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdTitulo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdTitulo.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdTitulo.GroupByBoxVisible = False
        Me.grdTitulo.Location = New System.Drawing.Point(8, 142)
        Me.grdTitulo.Name = "grdTitulo"
        Me.grdTitulo.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdTitulo.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdTitulo.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdTitulo.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdTitulo.Size = New System.Drawing.Size(562, 229)
        Me.grdTitulo.TabIndex = 2
        Me.grdTitulo.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdTitulo.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdTitulo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdTitulo.VisualStyleManager = Me.vsmMain
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.dtpDataBase)
        Me.UiGroupBox1.Controls.Add(Me.lblDataBase)
        Me.UiGroupBox1.Controls.Add(Me.cboTipoIntervalo)
        Me.UiGroupBox1.Controls.Add(Me.lblTipoIntervalo)
        Me.UiGroupBox1.Controls.Add(Me.txtIntervaloEntreTitulos)
        Me.UiGroupBox1.Controls.Add(Me.lblIntervaloEntreTitulos)
        Me.UiGroupBox1.Controls.Add(Me.txtNumeroTitulos)
        Me.UiGroupBox1.Controls.Add(Me.lblNumeroTitulos)
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 70)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(562, 63)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'cboTipoIntervalo
        '
        Me.cboTipoIntervalo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoIntervalo.Location = New System.Drawing.Point(383, 34)
        Me.cboTipoIntervalo.Name = "cboTipoIntervalo"
        Me.cboTipoIntervalo.Size = New System.Drawing.Size(161, 20)
        Me.cboTipoIntervalo.TabIndex = 7
        '
        'lblTipoIntervalo
        '
        Me.lblTipoIntervalo.AutoSize = True
        Me.lblTipoIntervalo.Location = New System.Drawing.Point(380, 17)
        Me.lblTipoIntervalo.Name = "lblTipoIntervalo"
        Me.lblTipoIntervalo.Size = New System.Drawing.Size(30, 14)
        Me.lblTipoIntervalo.TabIndex = 6
        Me.lblTipoIntervalo.Text = "Tipo:"
        '
        'txtIntervaloEntreTitulos
        '
        Me.txtIntervaloEntreTitulos.DecimalDigits = 0
        Me.txtIntervaloEntreTitulos.Location = New System.Drawing.Point(253, 34)
        Me.txtIntervaloEntreTitulos.Name = "txtIntervaloEntreTitulos"
        Me.txtIntervaloEntreTitulos.Size = New System.Drawing.Size(124, 20)
        Me.txtIntervaloEntreTitulos.TabIndex = 5
        Me.txtIntervaloEntreTitulos.Text = "0"
        Me.txtIntervaloEntreTitulos.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtIntervaloEntreTitulos.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblIntervaloEntreTitulos
        '
        Me.lblIntervaloEntreTitulos.AutoSize = True
        Me.lblIntervaloEntreTitulos.Location = New System.Drawing.Point(250, 17)
        Me.lblIntervaloEntreTitulos.Name = "lblIntervaloEntreTitulos"
        Me.lblIntervaloEntreTitulos.Size = New System.Drawing.Size(101, 14)
        Me.lblIntervaloEntreTitulos.TabIndex = 4
        Me.lblIntervaloEntreTitulos.Text = "Int. entre os Títulos:"
        '
        'txtNumeroTitulos
        '
        Me.txtNumeroTitulos.DecimalDigits = 0
        Me.txtNumeroTitulos.Location = New System.Drawing.Point(123, 34)
        Me.txtNumeroTitulos.Name = "txtNumeroTitulos"
        Me.txtNumeroTitulos.Size = New System.Drawing.Size(124, 20)
        Me.txtNumeroTitulos.TabIndex = 3
        Me.txtNumeroTitulos.Text = "0"
        Me.txtNumeroTitulos.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtNumeroTitulos.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumeroTitulos
        '
        Me.lblNumeroTitulos.AutoSize = True
        Me.lblNumeroTitulos.Location = New System.Drawing.Point(120, 17)
        Me.lblNumeroTitulos.Name = "lblNumeroTitulos"
        Me.lblNumeroTitulos.Size = New System.Drawing.Size(71, 14)
        Me.lblNumeroTitulos.TabIndex = 2
        Me.lblNumeroTitulos.Text = "Nº de Títulos:"
        '
        'grpInformacoes
        '
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.txtParceiroNegocio)
        Me.grpInformacoes.Controls.Add(Me.txtNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.lblNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.lblParceiroNegocio)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(562, 64)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'txtParceiroNegocio
        '
        Me.txtParceiroNegocio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtParceiroNegocio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtParceiroNegocio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtParceiroNegocio.Location = New System.Drawing.Point(139, 34)
        Me.txtParceiroNegocio.MaxLength = 20
        Me.txtParceiroNegocio.Name = "txtParceiroNegocio"
        Me.txtParceiroNegocio.ReadOnly = True
        Me.txtParceiroNegocio.Size = New System.Drawing.Size(414, 20)
        Me.txtParceiroNegocio.TabIndex = 3
        Me.txtParceiroNegocio.TabStop = False
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumento.MaxLength = 20
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.ReadOnly = True
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(124, 20)
        Me.txtNumeroDocumento.TabIndex = 1
        Me.txtNumeroDocumento.TabStop = False
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 0
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'lblParceiroNegocio
        '
        Me.lblParceiroNegocio.AutoSize = True
        Me.lblParceiroNegocio.Location = New System.Drawing.Point(136, 17)
        Me.lblParceiroNegocio.Name = "lblParceiroNegocio"
        Me.lblParceiroNegocio.Size = New System.Drawing.Size(107, 14)
        Me.lblParceiroNegocio.TabIndex = 2
        Me.lblParceiroNegocio.Text = "Parceiro de Negócio:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnDuplicar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 374)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(562, 51)
        Me.grpControl2.TabIndex = 3
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnDuplicar
        '
        Me.btnDuplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDuplicar.Image = Global.INTERACTI.My.Resources.Resources.duplicar
        Me.btnDuplicar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnDuplicar.Location = New System.Drawing.Point(306, 17)
        Me.btnDuplicar.Name = "btnDuplicar"
        Me.btnDuplicar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnDuplicar.Size = New System.Drawing.Size(150, 23)
        Me.btnDuplicar.TabIndex = 0
        Me.btnDuplicar.Text = "Duplicar Título"
        Me.btnDuplicar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(462, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'dtpDataBase
        '
        '
        '
        '
        Me.dtpDataBase.DropDownCalendar.Name = ""
        Me.dtpDataBase.Location = New System.Drawing.Point(9, 34)
        Me.dtpDataBase.Name = "dtpDataBase"
        Me.dtpDataBase.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataBase.TabIndex = 1
        Me.dtpDataBase.Value = New Date(2015, 9, 15, 0, 0, 0, 0)
        '
        'lblDataBase
        '
        Me.lblDataBase.AutoSize = True
        Me.lblDataBase.Location = New System.Drawing.Point(7, 17)
        Me.lblDataBase.Name = "lblDataBase"
        Me.lblDataBase.Size = New System.Drawing.Size(60, 14)
        Me.lblDataBase.TabIndex = 0
        Me.lblDataBase.Text = "Data Base:"
        '
        'frmFinTituloDuplicar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(594, 472)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinTituloDuplicar"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Financeiro - Duplicar Título"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grdTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInformacoes.ResumeLayout(False)
        Me.grpInformacoes.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnDuplicar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtParceiroNegocio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents lblParceiroNegocio As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdTitulo As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtIntervaloEntreTitulos As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblIntervaloEntreTitulos As System.Windows.Forms.Label
    Friend WithEvents txtNumeroTitulos As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblNumeroTitulos As System.Windows.Forms.Label
    Friend WithEvents cboTipoIntervalo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoIntervalo As System.Windows.Forms.Label
    Friend WithEvents dtpDataBase As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataBase As System.Windows.Forms.Label
End Class
