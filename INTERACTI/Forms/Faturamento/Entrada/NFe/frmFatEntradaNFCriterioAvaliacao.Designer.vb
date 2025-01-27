<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEntradaNFCriterioAvaliacao
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
        Dim grdOpcao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdOpcao_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEntradaNFCriterioAvaliacao))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdOpcao = New Janus.Windows.GridEX.GridEX()
        Me.grpMotivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtObservacao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.txtCriterio = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCriterio = New System.Windows.Forms.Label()
        Me.txtEmitente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblEmitente = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grdOpcao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMotivo.SuspendLayout()
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
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(705, 408)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grdOpcao)
        Me.pagTabela.Controls.Add(Me.grpMotivo)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(703, 385)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Dados da avaliação"
        '
        'grdOpcao
        '
        Me.grdOpcao.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdOpcao.AlternatingColors = True
        Me.grdOpcao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdOpcao.ColumnAutoResize = True
        grdOpcao_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdOpcao_DesignTimeLayout_Reference_0.Instance"), Object)
        grdOpcao_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdOpcao_DesignTimeLayout_Reference_0})
        grdOpcao_DesignTimeLayout.LayoutString = resources.GetString("grdOpcao_DesignTimeLayout.LayoutString")
        Me.grdOpcao.DesignTimeLayout = grdOpcao_DesignTimeLayout
        Me.grdOpcao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdOpcao.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOpcao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOpcao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOpcao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOpcao.GroupByBoxVisible = False
        Me.grdOpcao.Location = New System.Drawing.Point(8, 118)
        Me.grdOpcao.Name = "grdOpcao"
        Me.grdOpcao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOpcao.RecordNavigator = True
        Me.grdOpcao.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdOpcao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOpcao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOpcao.Size = New System.Drawing.Size(687, 204)
        Me.grdOpcao.TabIndex = 39
        Me.grdOpcao.TabStop = False
        Me.grdOpcao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdOpcao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOpcao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOpcao.VisualStyleManager = Me.vsmMain
        '
        'grpMotivo
        '
        Me.grpMotivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMotivo.BackColor = System.Drawing.Color.Transparent
        Me.grpMotivo.Controls.Add(Me.txtObservacao)
        Me.grpMotivo.Controls.Add(Me.lblObservacao)
        Me.grpMotivo.Controls.Add(Me.txtCriterio)
        Me.grpMotivo.Controls.Add(Me.lblCriterio)
        Me.grpMotivo.Controls.Add(Me.txtEmitente)
        Me.grpMotivo.Controls.Add(Me.lblEmitente)
        Me.grpMotivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMotivo.Location = New System.Drawing.Point(8, 3)
        Me.grpMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMotivo.Name = "grpMotivo"
        Me.grpMotivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMotivo.Size = New System.Drawing.Size(687, 108)
        Me.grpMotivo.TabIndex = 0
        Me.grpMotivo.Text = "Avaliação"
        Me.grpMotivo.VisualStyleManager = Me.vsmMain
        '
        'txtObservacao
        '
        Me.txtObservacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacao.BackColor = System.Drawing.SystemColors.Info
        Me.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtObservacao.Location = New System.Drawing.Point(9, 76)
        Me.txtObservacao.MaxLength = 250
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(669, 20)
        Me.txtObservacao.TabIndex = 5
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.Location = New System.Drawing.Point(6, 59)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(70, 14)
        Me.lblObservacao.TabIndex = 4
        Me.lblObservacao.Text = "Observação:"
        '
        'txtCriterio
        '
        Me.txtCriterio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCriterio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCriterio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCriterio.Location = New System.Drawing.Point(9, 34)
        Me.txtCriterio.MaxLength = 250
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(305, 20)
        Me.txtCriterio.TabIndex = 1
        Me.txtCriterio.TabStop = False
        Me.txtCriterio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblCriterio
        '
        Me.lblCriterio.AutoSize = True
        Me.lblCriterio.Location = New System.Drawing.Point(5, 17)
        Me.lblCriterio.Name = "lblCriterio"
        Me.lblCriterio.Size = New System.Drawing.Size(41, 14)
        Me.lblCriterio.TabIndex = 0
        Me.lblCriterio.Text = "Critério"
        '
        'txtEmitente
        '
        Me.txtEmitente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmitente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEmitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmitente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtEmitente.Location = New System.Drawing.Point(320, 34)
        Me.txtEmitente.MaxLength = 250
        Me.txtEmitente.Name = "txtEmitente"
        Me.txtEmitente.Size = New System.Drawing.Size(358, 20)
        Me.txtEmitente.TabIndex = 3
        Me.txtEmitente.TabStop = False
        '
        'lblEmitente
        '
        Me.lblEmitente.AutoSize = True
        Me.lblEmitente.Location = New System.Drawing.Point(317, 17)
        Me.lblEmitente.Name = "lblEmitente"
        Me.lblEmitente.Size = New System.Drawing.Size(50, 14)
        Me.lblEmitente.TabIndex = 2
        Me.lblEmitente.Text = "Emitente:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 325)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(687, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
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
        'frmFatEntradaNFCriterioAvaliacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 422)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEntradaNFCriterioAvaliacao"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Critério de Avaliação"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grdOpcao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMotivo.ResumeLayout(False)
        Me.grpMotivo.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpMotivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtEmitente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblEmitente As System.Windows.Forms.Label
    Friend WithEvents txtCriterio As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents grdOpcao As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtObservacao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
End Class
