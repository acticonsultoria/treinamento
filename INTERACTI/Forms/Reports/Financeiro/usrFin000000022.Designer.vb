<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFin000000022
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFin000000022))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboAgrupadoPor = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAgrupadoPor = New System.Windows.Forms.Label()
        Me.lblDataVencimento = New System.Windows.Forms.Label()
        Me.cboTipoTituloFinanceiro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipoTituloFinanceiro = New System.Windows.Forms.Label()
        Me.dtpPeriodoTermino = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpPeriodoInicio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboContaBancaria = New Janus.Windows.EditControls.UIComboBox()
        Me.lblContaBancaria = New System.Windows.Forms.Label()
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
        Me.tabMain.Size = New System.Drawing.Size(507, 343)
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
        Me.pagLista.Size = New System.Drawing.Size(505, 320)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Relatório Financeiro - FIN000000022"
        '
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboAgrupadoPor)
        Me.grpFiltro.Controls.Add(Me.lblAgrupadoPor)
        Me.grpFiltro.Controls.Add(Me.lblDataVencimento)
        Me.grpFiltro.Controls.Add(Me.cboTipoTituloFinanceiro)
        Me.grpFiltro.Controls.Add(Me.lblTipoTituloFinanceiro)
        Me.grpFiltro.Controls.Add(Me.dtpPeriodoTermino)
        Me.grpFiltro.Controls.Add(Me.dtpPeriodoInicio)
        Me.grpFiltro.Controls.Add(Me.cboContaBancaria)
        Me.grpFiltro.Controls.Add(Me.lblContaBancaria)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 120)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(489, 137)
        Me.grpFiltro.TabIndex = 16
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboAgrupadoPor
        '
        Me.cboAgrupadoPor.AutoSize = False
        Me.cboAgrupadoPor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAgrupadoPor.Location = New System.Drawing.Point(11, 108)
        Me.cboAgrupadoPor.Name = "cboAgrupadoPor"
        Me.cboAgrupadoPor.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAgrupadoPor.Size = New System.Drawing.Size(222, 20)
        Me.cboAgrupadoPor.TabIndex = 23
        '
        'lblAgrupadoPor
        '
        Me.lblAgrupadoPor.AutoSize = True
        Me.lblAgrupadoPor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAgrupadoPor.Location = New System.Drawing.Point(8, 92)
        Me.lblAgrupadoPor.Name = "lblAgrupadoPor"
        Me.lblAgrupadoPor.Size = New System.Drawing.Size(77, 14)
        Me.lblAgrupadoPor.TabIndex = 22
        Me.lblAgrupadoPor.Text = "Agrupado por:"
        '
        'lblDataVencimento
        '
        Me.lblDataVencimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDataVencimento.AutoSize = True
        Me.lblDataVencimento.Location = New System.Drawing.Point(255, 91)
        Me.lblDataVencimento.Name = "lblDataVencimento"
        Me.lblDataVencimento.Size = New System.Drawing.Size(103, 14)
        Me.lblDataVencimento.TabIndex = 10
        Me.lblDataVencimento.Text = "Data de Pagamento:"
        '
        'cboTipoTituloFinanceiro
        '
        Me.cboTipoTituloFinanceiro.AutoSize = False
        Me.cboTipoTituloFinanceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipoTituloFinanceiro.Location = New System.Drawing.Point(11, 69)
        Me.cboTipoTituloFinanceiro.Name = "cboTipoTituloFinanceiro"
        Me.cboTipoTituloFinanceiro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipoTituloFinanceiro.Size = New System.Drawing.Size(470, 20)
        Me.cboTipoTituloFinanceiro.TabIndex = 19
        '
        'lblTipoTituloFinanceiro
        '
        Me.lblTipoTituloFinanceiro.AutoSize = True
        Me.lblTipoTituloFinanceiro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipoTituloFinanceiro.Location = New System.Drawing.Point(8, 53)
        Me.lblTipoTituloFinanceiro.Name = "lblTipoTituloFinanceiro"
        Me.lblTipoTituloFinanceiro.Size = New System.Drawing.Size(126, 14)
        Me.lblTipoTituloFinanceiro.TabIndex = 18
        Me.lblTipoTituloFinanceiro.Text = "Tipo de Título Financeiro:"
        '
        'dtpPeriodoTermino
        '
        '
        '
        '
        Me.dtpPeriodoTermino.DropDownCalendar.Name = ""
        Me.dtpPeriodoTermino.Location = New System.Drawing.Point(372, 108)
        Me.dtpPeriodoTermino.Name = "dtpPeriodoTermino"
        Me.dtpPeriodoTermino.ShowCheckBox = True
        Me.dtpPeriodoTermino.Size = New System.Drawing.Size(108, 20)
        Me.dtpPeriodoTermino.TabIndex = 12
        Me.dtpPeriodoTermino.Value = New Date(2013, 12, 4, 0, 0, 0, 0)
        '
        'dtpPeriodoInicio
        '
        '
        '
        '
        Me.dtpPeriodoInicio.DropDownCalendar.Name = ""
        Me.dtpPeriodoInicio.Location = New System.Drawing.Point(258, 108)
        Me.dtpPeriodoInicio.Name = "dtpPeriodoInicio"
        Me.dtpPeriodoInicio.Size = New System.Drawing.Size(108, 20)
        Me.dtpPeriodoInicio.TabIndex = 11
        Me.dtpPeriodoInicio.Value = New Date(2013, 12, 4, 0, 0, 0, 0)
        '
        'cboContaBancaria
        '
        Me.cboContaBancaria.AutoSize = False
        Me.cboContaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaBancaria.Location = New System.Drawing.Point(10, 32)
        Me.cboContaBancaria.Name = "cboContaBancaria"
        Me.cboContaBancaria.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaBancaria.Size = New System.Drawing.Size(470, 20)
        Me.cboContaBancaria.TabIndex = 4
        '
        'lblContaBancaria
        '
        Me.lblContaBancaria.AutoSize = True
        Me.lblContaBancaria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblContaBancaria.Location = New System.Drawing.Point(7, 15)
        Me.lblContaBancaria.Name = "lblContaBancaria"
        Me.lblContaBancaria.Size = New System.Drawing.Size(84, 14)
        Me.lblContaBancaria.TabIndex = 3
        Me.lblContaBancaria.Text = "Conta Bancária:"
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
        Me.grpControl.Location = New System.Drawing.Point(8, 260)
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
        'usrFin000000022
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFin000000022"
        Me.Size = New System.Drawing.Size(507, 343)
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
    Friend WithEvents cboAgrupadoPor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblAgrupadoPor As System.Windows.Forms.Label
    Friend WithEvents lblDataVencimento As System.Windows.Forms.Label
    Friend WithEvents cboTipoTituloFinanceiro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipoTituloFinanceiro As System.Windows.Forms.Label
    Friend WithEvents dtpPeriodoTermino As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpPeriodoInicio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents cboContaBancaria As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblContaBancaria As System.Windows.Forms.Label

End Class
