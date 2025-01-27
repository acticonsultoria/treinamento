<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrChartDinamico
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim ChartArea4 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend4 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Title4 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrChartDinamico))
        Dim JanusColorScheme4 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Me.chrGrafico = New Dundas.Charting.WinControl.Chart()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpGrafico = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboCampoData = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCampoData = New System.Windows.Forms.Label()
        Me.txtMeta = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMeta = New System.Windows.Forms.Label()
        Me.cboIntervalo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblIntervaloAgrupamento = New System.Windows.Forms.Label()
        Me.cboTipo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cboEixoY = New Janus.Windows.EditControls.UIComboBox()
        Me.lblValorEixoY = New System.Windows.Forms.Label()
        Me.cboSerie = New Janus.Windows.EditControls.UIComboBox()
        Me.btnGerarGrafico = New Janus.Windows.EditControls.UIButton()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.txtTotal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.chrGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGrafico.SuspendLayout()
        Me.SuspendLayout()
        '
        'chrGrafico
        '
        Me.chrGrafico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chrGrafico.BorderLineColor = System.Drawing.SystemColors.WindowText
        Me.chrGrafico.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chrGrafico.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea4.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea4.AxisX.Title = "Período (dias)"
        ChartArea4.AxisX.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea4.AxisY.Title = "Quantidade"
        ChartArea4.AxisY.TitleFont = New System.Drawing.Font("Arial", 8.25!)
        ChartArea4.BorderColor = System.Drawing.Color.Empty
        ChartArea4.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea4.Name = "Default"
        Me.chrGrafico.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Default"
        Me.chrGrafico.Legends.Add(Legend4)
        Me.chrGrafico.Location = New System.Drawing.Point(8, 77)
        Me.chrGrafico.Name = "chrGrafico"
        Me.chrGrafico.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Me.chrGrafico.Size = New System.Drawing.Size(965, 317)
        Me.chrGrafico.TabIndex = 7
        Title4.Name = "Title1"
        Me.chrGrafico.Titles.Add(Title4)
        Me.chrGrafico.UI.Toolbar.Enabled = True
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 396)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(965, 51)
        Me.grpControl.TabIndex = 8
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(865, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'vsmMain
        '
        JanusColorScheme4.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme4.Name = "Scheme"
        JanusColorScheme4.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme4.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme4.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme4)
        Me.vsmMain.DefaultColorScheme = Nothing
        '
        'grpGrafico
        '
        Me.grpGrafico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpGrafico.BackColor = System.Drawing.Color.Transparent
        Me.grpGrafico.Controls.Add(Me.cboCampoData)
        Me.grpGrafico.Controls.Add(Me.lblCampoData)
        Me.grpGrafico.Controls.Add(Me.txtMeta)
        Me.grpGrafico.Controls.Add(Me.lblMeta)
        Me.grpGrafico.Controls.Add(Me.cboIntervalo)
        Me.grpGrafico.Controls.Add(Me.lblIntervaloAgrupamento)
        Me.grpGrafico.Controls.Add(Me.cboTipo)
        Me.grpGrafico.Controls.Add(Me.lblTipo)
        Me.grpGrafico.Controls.Add(Me.cboEixoY)
        Me.grpGrafico.Controls.Add(Me.lblValorEixoY)
        Me.grpGrafico.Controls.Add(Me.cboSerie)
        Me.grpGrafico.Controls.Add(Me.btnGerarGrafico)
        Me.grpGrafico.Controls.Add(Me.lblSerie)
        Me.grpGrafico.Location = New System.Drawing.Point(8, 7)
        Me.grpGrafico.Name = "grpGrafico"
        Me.grpGrafico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpGrafico.Size = New System.Drawing.Size(966, 64)
        Me.grpGrafico.TabIndex = 0
        Me.grpGrafico.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpGrafico.VisualStyleManager = Me.vsmMain
        '
        'cboCampoData
        '
        Me.cboCampoData.AutoSize = False
        Me.cboCampoData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCampoData.Location = New System.Drawing.Point(601, 31)
        Me.cboCampoData.Name = "cboCampoData"
        Me.cboCampoData.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCampoData.Size = New System.Drawing.Size(143, 20)
        Me.cboCampoData.TabIndex = 9
        '
        'lblCampoData
        '
        Me.lblCampoData.AutoSize = True
        Me.lblCampoData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCampoData.Location = New System.Drawing.Point(598, 14)
        Me.lblCampoData.Name = "lblCampoData"
        Me.lblCampoData.Size = New System.Drawing.Size(61, 15)
        Me.lblCampoData.TabIndex = 8
        Me.lblCampoData.Text = "Campo Data:"
        '
        'txtMeta
        '
        Me.txtMeta.FormatString = "0"
        Me.txtMeta.Location = New System.Drawing.Point(750, 31)
        Me.txtMeta.Name = "txtMeta"
        Me.txtMeta.Size = New System.Drawing.Size(58, 20)
        Me.txtMeta.TabIndex = 11
        Me.txtMeta.Text = "0"
        Me.txtMeta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMeta
        '
        Me.lblMeta.AutoSize = True
        Me.lblMeta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMeta.Location = New System.Drawing.Point(747, 14)
        Me.lblMeta.Name = "lblMeta"
        Me.lblMeta.Size = New System.Drawing.Size(30, 15)
        Me.lblMeta.TabIndex = 10
        Me.lblMeta.Text = "Meta:"
        '
        'cboIntervalo
        '
        Me.cboIntervalo.AutoSize = False
        Me.cboIntervalo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboIntervalo.Location = New System.Drawing.Point(437, 31)
        Me.cboIntervalo.Name = "cboIntervalo"
        Me.cboIntervalo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboIntervalo.Size = New System.Drawing.Size(158, 20)
        Me.cboIntervalo.TabIndex = 7
        '
        'lblIntervaloAgrupamento
        '
        Me.lblIntervaloAgrupamento.AutoSize = True
        Me.lblIntervaloAgrupamento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblIntervaloAgrupamento.Location = New System.Drawing.Point(434, 14)
        Me.lblIntervaloAgrupamento.Name = "lblIntervaloAgrupamento"
        Me.lblIntervaloAgrupamento.Size = New System.Drawing.Size(129, 15)
        Me.lblIntervaloAgrupamento.TabIndex = 6
        Me.lblIntervaloAgrupamento.Text = "Intervalo Agrupamento (Data):"
        '
        'cboTipo
        '
        Me.cboTipo.AutoSize = False
        Me.cboTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipo.Location = New System.Drawing.Point(337, 31)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipo.Size = New System.Drawing.Size(94, 20)
        Me.cboTipo.TabIndex = 5
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipo.Location = New System.Drawing.Point(334, 14)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 15)
        Me.lblTipo.TabIndex = 4
        Me.lblTipo.Text = "Tipo:"
        '
        'cboEixoY
        '
        Me.cboEixoY.AutoSize = False
        Me.cboEixoY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboEixoY.Location = New System.Drawing.Point(173, 31)
        Me.cboEixoY.Name = "cboEixoY"
        Me.cboEixoY.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboEixoY.Size = New System.Drawing.Size(158, 20)
        Me.cboEixoY.TabIndex = 3
        '
        'lblValorEixoY
        '
        Me.lblValorEixoY.AutoSize = True
        Me.lblValorEixoY.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValorEixoY.Location = New System.Drawing.Point(170, 14)
        Me.lblValorEixoY.Name = "lblValorEixoY"
        Me.lblValorEixoY.Size = New System.Drawing.Size(38, 15)
        Me.lblValorEixoY.TabIndex = 2
        Me.lblValorEixoY.Text = "Eixo Y:"
        '
        'cboSerie
        '
        Me.cboSerie.AutoSize = False
        Me.cboSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboSerie.Location = New System.Drawing.Point(9, 31)
        Me.cboSerie.Name = "cboSerie"
        Me.cboSerie.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboSerie.Size = New System.Drawing.Size(158, 20)
        Me.cboSerie.TabIndex = 1
        '
        'btnGerarGrafico
        '
        Me.btnGerarGrafico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGerarGrafico.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnGerarGrafico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarGrafico.Location = New System.Drawing.Point(814, 30)
        Me.btnGerarGrafico.Name = "btnGerarGrafico"
        Me.btnGerarGrafico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnGerarGrafico.Size = New System.Drawing.Size(143, 23)
        Me.btnGerarGrafico.TabIndex = 12
        Me.btnGerarGrafico.Text = "Gerar Gráfico"
        Me.btnGerarGrafico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSerie.Location = New System.Drawing.Point(6, 14)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(81, 15)
        Me.lblSerie.TabIndex = 0
        Me.lblSerie.Text = "Séries do Gráfico:"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.DecimalDigits = 4
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.Location = New System.Drawing.Point(855, 106)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(110, 22)
        Me.txtTotal.TabIndex = 20
        Me.txtTotal.Text = "0,0000"
        Me.txtTotal.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTotal.Location = New System.Drawing.Point(806, 110)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(43, 16)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.Text = "Total:"
        '
        'usrChartDinamico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.grpGrafico)
        Me.Controls.Add(Me.grpControl)
        Me.Controls.Add(Me.chrGrafico)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "usrChartDinamico"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.Size = New System.Drawing.Size(982, 456)
        CType(Me.chrGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grpGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGrafico.ResumeLayout(False)
        Me.grpGrafico.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chrGrafico As Dundas.Charting.WinControl.Chart
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grpGrafico As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboCampoData As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCampoData As System.Windows.Forms.Label
    Friend WithEvents txtMeta As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMeta As System.Windows.Forms.Label
    Friend WithEvents cboIntervalo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblIntervaloAgrupamento As System.Windows.Forms.Label
    Friend WithEvents cboTipo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents cboEixoY As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblValorEixoY As System.Windows.Forms.Label
    Friend WithEvents cboSerie As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnGerarGrafico As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents txtTotal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
