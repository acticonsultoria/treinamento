<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrdOrdemProducaoFinalizarOP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrdOrdemProducaoFinalizarOP))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picLegendaEmProducao = New System.Windows.Forms.PictureBox()
        Me.lblLegendaEmProducao = New System.Windows.Forms.Label()
        Me.picLegendaFinalizado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaCancelada = New System.Windows.Forms.Label()
        Me.picLegendaCancelada = New System.Windows.Forms.PictureBox()
        Me.lblLegendaFinalizada = New System.Windows.Forms.Label()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnLiberarProducao = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaEmProducao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaFinalizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaCancelada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(665, 509)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpLegenda)
        Me.pagTabela.Controls.Add(Me.grdListagem)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(663, 486)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Liberação de OP"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.Label1)
        Me.grpLegenda.Controls.Add(Me.PictureBox1)
        Me.grpLegenda.Controls.Add(Me.picLegendaEmProducao)
        Me.grpLegenda.Controls.Add(Me.lblLegendaEmProducao)
        Me.grpLegenda.Controls.Add(Me.picLegendaFinalizado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaCancelada)
        Me.grpLegenda.Controls.Add(Me.picLegendaCancelada)
        Me.grpLegenda.Controls.Add(Me.lblLegendaFinalizada)
        Me.grpLegenda.Location = New System.Drawing.Point(8, 382)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(163, 95)
        Me.grpLegenda.TabIndex = 95
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 14)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Liberado para Produção"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Purple
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(9, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(13, 14)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'picLegendaEmProducao
        '
        Me.picLegendaEmProducao.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaEmProducao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaEmProducao.Location = New System.Drawing.Point(9, 31)
        Me.picLegendaEmProducao.Name = "picLegendaEmProducao"
        Me.picLegendaEmProducao.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaEmProducao.TabIndex = 18
        Me.picLegendaEmProducao.TabStop = False
        '
        'lblLegendaEmProducao
        '
        Me.lblLegendaEmProducao.AutoSize = True
        Me.lblLegendaEmProducao.Location = New System.Drawing.Point(28, 31)
        Me.lblLegendaEmProducao.Name = "lblLegendaEmProducao"
        Me.lblLegendaEmProducao.Size = New System.Drawing.Size(109, 14)
        Me.lblLegendaEmProducao.TabIndex = 17
        Me.lblLegendaEmProducao.Text = "Aguardando Estoque"
        '
        'picLegendaFinalizado
        '
        Me.picLegendaFinalizado.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaFinalizado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaFinalizado.Location = New System.Drawing.Point(9, 11)
        Me.picLegendaFinalizado.Name = "picLegendaFinalizado"
        Me.picLegendaFinalizado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaFinalizado.TabIndex = 16
        Me.picLegendaFinalizado.TabStop = False
        '
        'lblLegendaCancelada
        '
        Me.lblLegendaCancelada.AutoSize = True
        Me.lblLegendaCancelada.Location = New System.Drawing.Point(28, 50)
        Me.lblLegendaCancelada.Name = "lblLegendaCancelada"
        Me.lblLegendaCancelada.Size = New System.Drawing.Size(58, 14)
        Me.lblLegendaCancelada.TabIndex = 1
        Me.lblLegendaCancelada.Text = "Cancelada"
        '
        'picLegendaCancelada
        '
        Me.picLegendaCancelada.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaCancelada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaCancelada.Location = New System.Drawing.Point(9, 50)
        Me.picLegendaCancelada.Name = "picLegendaCancelada"
        Me.picLegendaCancelada.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaCancelada.TabIndex = 14
        Me.picLegendaCancelada.TabStop = False
        '
        'lblLegendaFinalizada
        '
        Me.lblLegendaFinalizada.AutoSize = True
        Me.lblLegendaFinalizada.Location = New System.Drawing.Point(28, 11)
        Me.lblLegendaFinalizada.Name = "lblLegendaFinalizada"
        Me.lblLegendaFinalizada.Size = New System.Drawing.Size(55, 14)
        Me.lblLegendaFinalizada.TabIndex = 0
        Me.lblLegendaFinalizada.Text = "Finalizada"
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.DynamicFiltering = True
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Location = New System.Drawing.Point(8, 3)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(647, 373)
        Me.grdListagem.TabIndex = 4
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnLiberarProducao)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(177, 382)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(478, 95)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnLiberarProducao
        '
        Me.btnLiberarProducao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLiberarProducao.Image = CType(resources.GetObject("btnLiberarProducao.Image"), System.Drawing.Image)
        Me.btnLiberarProducao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnLiberarProducao.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnLiberarProducao.Location = New System.Drawing.Point(248, 41)
        Me.btnLiberarProducao.Name = "btnLiberarProducao"
        Me.btnLiberarProducao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnLiberarProducao.Size = New System.Drawing.Size(124, 23)
        Me.btnLiberarProducao.TabIndex = 33
        Me.btnLiberarProducao.Text = "Finalizar OP"
        Me.btnLiberarProducao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(378, 41)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmPrdOrdemProducaoFinalizarOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 523)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrdOrdemProducaoFinalizarOP"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Liberação de Ordem de Produção"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaEmProducao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaFinalizado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaCancelada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnLiberarProducao As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picLegendaEmProducao As PictureBox
    Friend WithEvents lblLegendaEmProducao As Label
    Friend WithEvents picLegendaFinalizado As PictureBox
    Friend WithEvents lblLegendaCancelada As Label
    Friend WithEvents picLegendaCancelada As PictureBox
    Friend WithEvents lblLegendaFinalizada As Label
End Class
