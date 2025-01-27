<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinReceitaCobrancaTipo
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinReceitaCobrancaTipo))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.dtpDataLimite = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataLimite = New System.Windows.Forms.Label()
        Me.rdbInstrucaoProtesto = New Janus.Windows.EditControls.UIRadioButton()
        Me.rdbInstrucaoCobranca = New Janus.Windows.EditControls.UIRadioButton()
        Me.lblExplicacao = New System.Windows.Forms.Label()
        Me.lblLabelTotalTitulo = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnConfirmar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInformacoes.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme2.Name = "Scheme"
        JanusColorScheme2.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme2.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme2)
        Me.vsmMain.DefaultColorScheme = Nothing
        '
        'tabMain
        '
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(452, 203)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpInformacoes)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(450, 180)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Tipo de Aviso"
        '
        'grpInformacoes
        '
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.dtpDataLimite)
        Me.grpInformacoes.Controls.Add(Me.lblDataLimite)
        Me.grpInformacoes.Controls.Add(Me.rdbInstrucaoProtesto)
        Me.grpInformacoes.Controls.Add(Me.rdbInstrucaoCobranca)
        Me.grpInformacoes.Controls.Add(Me.lblExplicacao)
        Me.grpInformacoes.Controls.Add(Me.lblLabelTotalTitulo)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(434, 114)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'dtpDataLimite
        '
        '
        '
        '
        Me.dtpDataLimite.DropDownCalendar.Name = ""
        Me.dtpDataLimite.Location = New System.Drawing.Point(95, 85)
        Me.dtpDataLimite.Name = "dtpDataLimite"
        Me.dtpDataLimite.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataLimite.TabIndex = 5
        '
        'lblDataLimite
        '
        Me.lblDataLimite.AutoSize = True
        Me.lblDataLimite.Location = New System.Drawing.Point(27, 88)
        Me.lblDataLimite.Name = "lblDataLimite"
        Me.lblDataLimite.Size = New System.Drawing.Size(62, 14)
        Me.lblDataLimite.TabIndex = 4
        Me.lblDataLimite.Text = "Data Limite:"
        '
        'rdbInstrucaoProtesto
        '
        Me.rdbInstrucaoProtesto.Location = New System.Drawing.Point(30, 63)
        Me.rdbInstrucaoProtesto.Name = "rdbInstrucaoProtesto"
        Me.rdbInstrucaoProtesto.Size = New System.Drawing.Size(298, 16)
        Me.rdbInstrucaoProtesto.TabIndex = 3
        Me.rdbInstrucaoProtesto.Text = "Instrução de Protesto"
        '
        'rdbInstrucaoCobranca
        '
        Me.rdbInstrucaoCobranca.Checked = True
        Me.rdbInstrucaoCobranca.Location = New System.Drawing.Point(30, 40)
        Me.rdbInstrucaoCobranca.Name = "rdbInstrucaoCobranca"
        Me.rdbInstrucaoCobranca.Size = New System.Drawing.Size(298, 17)
        Me.rdbInstrucaoCobranca.TabIndex = 2
        Me.rdbInstrucaoCobranca.TabStop = True
        Me.rdbInstrucaoCobranca.Text = "Instrução de Cobrança"
        '
        'lblExplicacao
        '
        Me.lblExplicacao.AutoSize = True
        Me.lblExplicacao.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblExplicacao.Location = New System.Drawing.Point(6, 17)
        Me.lblExplicacao.Name = "lblExplicacao"
        Me.lblExplicacao.Size = New System.Drawing.Size(151, 13)
        Me.lblExplicacao.TabIndex = 0
        Me.lblExplicacao.Text = "Selecione o Tipo de Aviso:"
        '
        'lblLabelTotalTitulo
        '
        Me.lblLabelTotalTitulo.AutoSize = True
        Me.lblLabelTotalTitulo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblLabelTotalTitulo.Location = New System.Drawing.Point(6, 17)
        Me.lblLabelTotalTitulo.Name = "lblLabelTotalTitulo"
        Me.lblLabelTotalTitulo.Size = New System.Drawing.Size(101, 14)
        Me.lblLabelTotalTitulo.TabIndex = 0
        Me.lblLabelTotalTitulo.Text = "Total dos Títulos:"
        '
        'grpControl2
        '
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnConfirmar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 120)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(434, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmar.Image = Global.INTERACTI.My.Resources.aprovar
        Me.btnConfirmar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnConfirmar.Location = New System.Drawing.Point(237, 17)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnConfirmar.Size = New System.Drawing.Size(91, 23)
        Me.btnConfirmar.TabIndex = 0
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(334, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmFinReceitaCobrancaTipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 217)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinReceitaCobrancaTipo"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Relatório"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
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
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLabelTotalTitulo As System.Windows.Forms.Label
    Friend WithEvents lblExplicacao As System.Windows.Forms.Label
    Friend WithEvents rdbInstrucaoProtesto As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents rdbInstrucaoCobranca As Janus.Windows.EditControls.UIRadioButton
    Private WithEvents btnConfirmar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataLimite As System.Windows.Forms.Label
    Friend WithEvents dtpDataLimite As Janus.Windows.CalendarCombo.CalendarCombo
End Class
