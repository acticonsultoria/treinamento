<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFatEntradaNFASCON
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
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFatEntradaNFASCON))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagFCIGerada = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataEntradaFim = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataEntradaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDataEmissaoFim = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataEmissaoInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblDataFiltro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNotaFiscal = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblCodigoRecebimentoFiltro = New System.Windows.Forms.Label()
        Me.txtEmitente = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFCIGerada = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcelFCIGerada = New Janus.Windows.EditControls.UIButton()
        Me.btnSairFCIGerada = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagFCIGerada.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFCIGerada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFCIGerada.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(1198, 490)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagFCIGerada})
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagFCIGerada
        '
        Me.pagFCIGerada.Controls.Add(Me.UiGroupBox1)
        Me.pagFCIGerada.Controls.Add(Me.grdListagem)
        Me.pagFCIGerada.Controls.Add(Me.grpFCIGerada)
        Me.pagFCIGerada.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagFCIGerada.Key = "pagLista"
        Me.pagFCIGerada.Location = New System.Drawing.Point(1, 22)
        Me.pagFCIGerada.Name = "pagFCIGerada"
        Me.pagFCIGerada.Size = New System.Drawing.Size(1196, 467)
        Me.pagFCIGerada.TabStop = True
        Me.pagFCIGerada.Text = "Informações de Entrada"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.dtpDataEntradaFim)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataEntradaInicio)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataEmissaoFim)
        Me.UiGroupBox1.Controls.Add(Me.dtpDataEmissaoInicio)
        Me.UiGroupBox1.Controls.Add(Me.lblDataFiltro)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Controls.Add(Me.txtNotaFiscal)
        Me.UiGroupBox1.Controls.Add(Me.lblCodigoRecebimentoFiltro)
        Me.UiGroupBox1.Controls.Add(Me.txtEmitente)
        Me.UiGroupBox1.Controls.Add(Me.btnFiltrar)
        Me.UiGroupBox1.Location = New System.Drawing.Point(6, 4)
        Me.UiGroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(1180, 65)
        Me.UiGroupBox1.TabIndex = 5
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'dtpDataEntradaFim
        '
        Me.dtpDataEntradaFim.Checked = False
        Me.dtpDataEntradaFim.CustomFormat = "dd/MM/yyyy"
        Me.dtpDataEntradaFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataEntradaFim.Location = New System.Drawing.Point(832, 33)
        Me.dtpDataEntradaFim.Name = "dtpDataEntradaFim"
        Me.dtpDataEntradaFim.ShowCheckBox = True
        Me.dtpDataEntradaFim.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEntradaFim.TabIndex = 13
        '
        'dtpDataEntradaInicio
        '
        Me.dtpDataEntradaInicio.Checked = False
        Me.dtpDataEntradaInicio.CustomFormat = "dd/MM/yyyy"
        Me.dtpDataEntradaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataEntradaInicio.Location = New System.Drawing.Point(718, 33)
        Me.dtpDataEntradaInicio.Name = "dtpDataEntradaInicio"
        Me.dtpDataEntradaInicio.ShowCheckBox = True
        Me.dtpDataEntradaInicio.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEntradaInicio.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(715, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 14)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Data Entrada:"
        '
        'dtpDataEmissaoFim
        '
        Me.dtpDataEmissaoFim.Checked = False
        Me.dtpDataEmissaoFim.CustomFormat = "dd/MM/yyyy"
        Me.dtpDataEmissaoFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataEmissaoFim.Location = New System.Drawing.Point(249, 33)
        Me.dtpDataEmissaoFim.Name = "dtpDataEmissaoFim"
        Me.dtpDataEmissaoFim.ShowCheckBox = True
        Me.dtpDataEmissaoFim.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoFim.TabIndex = 10
        '
        'dtpDataEmissaoInicio
        '
        Me.dtpDataEmissaoInicio.Checked = False
        Me.dtpDataEmissaoInicio.CustomFormat = "dd/MM/yyyy"
        Me.dtpDataEmissaoInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataEmissaoInicio.Location = New System.Drawing.Point(135, 33)
        Me.dtpDataEmissaoInicio.Name = "dtpDataEmissaoInicio"
        Me.dtpDataEmissaoInicio.ShowCheckBox = True
        Me.dtpDataEmissaoInicio.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoInicio.TabIndex = 9
        '
        'lblDataFiltro
        '
        Me.lblDataFiltro.AutoSize = True
        Me.lblDataFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataFiltro.Location = New System.Drawing.Point(132, 16)
        Me.lblDataFiltro.Name = "lblDataFiltro"
        Me.lblDataFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataFiltro.TabIndex = 8
        Me.lblDataFiltro.Text = "Data Emissão:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nota Fiscal:"
        '
        'txtNotaFiscal
        '
        Me.txtNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaFiscal.Location = New System.Drawing.Point(9, 33)
        Me.txtNotaFiscal.MaxLength = 20
        Me.txtNotaFiscal.Name = "txtNotaFiscal"
        Me.txtNotaFiscal.Size = New System.Drawing.Size(120, 20)
        Me.txtNotaFiscal.TabIndex = 7
        '
        'lblCodigoRecebimentoFiltro
        '
        Me.lblCodigoRecebimentoFiltro.AutoSize = True
        Me.lblCodigoRecebimentoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoRecebimentoFiltro.Location = New System.Drawing.Point(360, 16)
        Me.lblCodigoRecebimentoFiltro.Name = "lblCodigoRecebimentoFiltro"
        Me.lblCodigoRecebimentoFiltro.Size = New System.Drawing.Size(50, 14)
        Me.lblCodigoRecebimentoFiltro.TabIndex = 4
        Me.lblCodigoRecebimentoFiltro.Text = "Emitente:"
        '
        'txtEmitente
        '
        Me.txtEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmitente.Location = New System.Drawing.Point(363, 33)
        Me.txtEmitente.MaxLength = 20
        Me.txtEmitente.Name = "txtEmitente"
        Me.txtEmitente.Size = New System.Drawing.Size(349, 20)
        Me.txtEmitente.TabIndex = 5
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(1080, 28)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 3
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(8, 77)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Transparent
        Me.grdListagem.Size = New System.Drawing.Size(1178, 323)
        Me.grdListagem.TabIndex = 5
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFCIGerada
        '
        Me.grpFCIGerada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFCIGerada.BackColor = System.Drawing.Color.Transparent
        Me.grpFCIGerada.Controls.Add(Me.btnExcelFCIGerada)
        Me.grpFCIGerada.Controls.Add(Me.btnSairFCIGerada)
        Me.grpFCIGerada.Location = New System.Drawing.Point(6, 408)
        Me.grpFCIGerada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpFCIGerada.Name = "grpFCIGerada"
        Me.grpFCIGerada.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFCIGerada.Size = New System.Drawing.Size(1180, 51)
        Me.grpFCIGerada.TabIndex = 4
        Me.grpFCIGerada.VisualStyleManager = Me.vsmMain
        '
        'btnExcelFCIGerada
        '
        Me.btnExcelFCIGerada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelFCIGerada.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelFCIGerada.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcelFCIGerada.Location = New System.Drawing.Point(983, 17)
        Me.btnExcelFCIGerada.Name = "btnExcelFCIGerada"
        Me.btnExcelFCIGerada.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcelFCIGerada.Size = New System.Drawing.Size(91, 23)
        Me.btnExcelFCIGerada.TabIndex = 0
        Me.btnExcelFCIGerada.Text = "Excel"
        Me.btnExcelFCIGerada.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSairFCIGerada
        '
        Me.btnSairFCIGerada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSairFCIGerada.Image = CType(resources.GetObject("btnSairFCIGerada.Image"), System.Drawing.Image)
        Me.btnSairFCIGerada.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSairFCIGerada.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSairFCIGerada.Location = New System.Drawing.Point(1080, 17)
        Me.btnSairFCIGerada.Name = "btnSairFCIGerada"
        Me.btnSairFCIGerada.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSairFCIGerada.Size = New System.Drawing.Size(91, 23)
        Me.btnSairFCIGerada.TabIndex = 3
        Me.btnSairFCIGerada.Text = "Sair"
        Me.btnSairFCIGerada.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrFatEntradaNFASCON
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFatEntradaNFASCON"
        Me.Size = New System.Drawing.Size(1198, 490)
        Me.Tag = "S"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagFCIGerada.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFCIGerada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFCIGerada.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagFCIGerada As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFCIGerada As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExcelFCIGerada As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSairFCIGerada As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNotaFiscal As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblCodigoRecebimentoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtEmitente As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents dtpDataEmissaoFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDataEmissaoInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDataFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataEntradaFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDataEntradaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
