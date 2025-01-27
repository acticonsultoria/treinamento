<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCfgOrcamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCfgOrcamento))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagConfiguracao = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControlDiretorios = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSairDiretorios = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDespesaMensal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDespesaMensal = New System.Windows.Forms.Label()
        Me.txtFaturamentoMensal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblFaturamentoMensal = New System.Windows.Forms.Label()
        Me.txtFaturamentoAnual = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblFaturamentoAnual = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagConfiguracao.SuspendLayout()
        CType(Me.grpControlDiretorios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControlDiretorios.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
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
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 476)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagConfiguracao})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagConfiguracao
        '
        Me.pagConfiguracao.Controls.Add(Me.grpControlDiretorios)
        Me.pagConfiguracao.Controls.Add(Me.grpDados)
        Me.pagConfiguracao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagConfiguracao.Key = "pagConfiguracao"
        Me.pagConfiguracao.Location = New System.Drawing.Point(1, 22)
        Me.pagConfiguracao.Name = "pagConfiguracao"
        Me.pagConfiguracao.Size = New System.Drawing.Size(913, 453)
        Me.pagConfiguracao.TabStop = True
        Me.pagConfiguracao.Text = "Configuração"
        '
        'grpControlDiretorios
        '
        Me.grpControlDiretorios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControlDiretorios.BackColor = System.Drawing.Color.Transparent
        Me.grpControlDiretorios.Controls.Add(Me.btnSairDiretorios)
        Me.grpControlDiretorios.Controls.Add(Me.btnSalvar)
        Me.grpControlDiretorios.Location = New System.Drawing.Point(8, 394)
        Me.grpControlDiretorios.Name = "grpControlDiretorios"
        Me.grpControlDiretorios.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControlDiretorios.Size = New System.Drawing.Size(897, 51)
        Me.grpControlDiretorios.TabIndex = 2
        Me.grpControlDiretorios.VisualStyleManager = Me.vsmMain
        '
        'btnSairDiretorios
        '
        Me.btnSairDiretorios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSairDiretorios.Image = CType(resources.GetObject("btnSairDiretorios.Image"), System.Drawing.Image)
        Me.btnSairDiretorios.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSairDiretorios.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSairDiretorios.Location = New System.Drawing.Point(797, 17)
        Me.btnSairDiretorios.Name = "btnSairDiretorios"
        Me.btnSairDiretorios.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSairDiretorios.Size = New System.Drawing.Size(91, 23)
        Me.btnSairDiretorios.TabIndex = 1
        Me.btnSairDiretorios.Text = "Sair"
        Me.btnSairDiretorios.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(700, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtDespesaMensal)
        Me.grpDados.Controls.Add(Me.lblDespesaMensal)
        Me.grpDados.Controls.Add(Me.txtFaturamentoMensal)
        Me.grpDados.Controls.Add(Me.lblFaturamentoMensal)
        Me.grpDados.Controls.Add(Me.txtFaturamentoAnual)
        Me.grpDados.Controls.Add(Me.lblFaturamentoAnual)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 65)
        Me.grpDados.TabIndex = 0
        Me.grpDados.Text = "Despesas Fixas"
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtDespesaMensal
        '
        Me.txtDespesaMensal.DecimalDigits = 4
        Me.txtDespesaMensal.Location = New System.Drawing.Point(225, 34)
        Me.txtDespesaMensal.Name = "txtDespesaMensal"
        Me.txtDespesaMensal.Size = New System.Drawing.Size(104, 20)
        Me.txtDespesaMensal.TabIndex = 2
        Me.txtDespesaMensal.Text = "0,0000"
        Me.txtDespesaMensal.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblDespesaMensal
        '
        Me.lblDespesaMensal.AutoSize = True
        Me.lblDespesaMensal.Location = New System.Drawing.Point(222, 17)
        Me.lblDespesaMensal.Name = "lblDespesaMensal"
        Me.lblDespesaMensal.Size = New System.Drawing.Size(90, 14)
        Me.lblDespesaMensal.TabIndex = 24
        Me.lblDespesaMensal.Text = "Despesa Mensal:"
        '
        'txtFaturamentoMensal
        '
        Me.txtFaturamentoMensal.DecimalDigits = 4
        Me.txtFaturamentoMensal.Location = New System.Drawing.Point(115, 34)
        Me.txtFaturamentoMensal.Name = "txtFaturamentoMensal"
        Me.txtFaturamentoMensal.Size = New System.Drawing.Size(104, 20)
        Me.txtFaturamentoMensal.TabIndex = 1
        Me.txtFaturamentoMensal.Text = "0,0000"
        Me.txtFaturamentoMensal.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblFaturamentoMensal
        '
        Me.lblFaturamentoMensal.AutoSize = True
        Me.lblFaturamentoMensal.Location = New System.Drawing.Point(112, 17)
        Me.lblFaturamentoMensal.Name = "lblFaturamentoMensal"
        Me.lblFaturamentoMensal.Size = New System.Drawing.Size(107, 14)
        Me.lblFaturamentoMensal.TabIndex = 22
        Me.lblFaturamentoMensal.Text = "Faturamento Mensal:"
        '
        'txtFaturamentoAnual
        '
        Me.txtFaturamentoAnual.DecimalDigits = 4
        Me.txtFaturamentoAnual.Location = New System.Drawing.Point(9, 34)
        Me.txtFaturamentoAnual.Name = "txtFaturamentoAnual"
        Me.txtFaturamentoAnual.Size = New System.Drawing.Size(100, 20)
        Me.txtFaturamentoAnual.TabIndex = 0
        Me.txtFaturamentoAnual.Text = "0,0000"
        Me.txtFaturamentoAnual.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblFaturamentoAnual
        '
        Me.lblFaturamentoAnual.AutoSize = True
        Me.lblFaturamentoAnual.Location = New System.Drawing.Point(6, 17)
        Me.lblFaturamentoAnual.Name = "lblFaturamentoAnual"
        Me.lblFaturamentoAnual.Size = New System.Drawing.Size(100, 14)
        Me.lblFaturamentoAnual.TabIndex = 20
        Me.lblFaturamentoAnual.Text = "Faturamento Anual:"
        '
        'usrCfgOrcamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCfgOrcamento"
        Me.Size = New System.Drawing.Size(915, 476)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagConfiguracao.ResumeLayout(False)
        CType(Me.grpControlDiretorios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControlDiretorios.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagConfiguracao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControlDiretorios As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSairDiretorios As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtFaturamentoAnual As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblFaturamentoAnual As System.Windows.Forms.Label
    Friend WithEvents txtDespesaMensal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDespesaMensal As System.Windows.Forms.Label
    Friend WithEvents txtFaturamentoMensal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblFaturamentoMensal As System.Windows.Forms.Label

End Class
