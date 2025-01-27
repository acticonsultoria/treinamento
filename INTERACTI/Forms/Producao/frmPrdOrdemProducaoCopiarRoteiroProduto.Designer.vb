<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrdOrdemProducaoCopiarRoteiroProduto
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
        Dim grdRoteiroImportacao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrdOrdemProducaoCopiarRoteiroProduto))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridRoteiro = New System.Windows.Forms.Button()
        Me.btnAgruparGridRoteiro = New System.Windows.Forms.Button()
        Me.btnConfigurarGridRoteiro = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCodigoProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCodigoProdutoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grdRoteiroImportacao = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImportar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdRoteiroImportacao, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(916, 509)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.btnExcelGridRoteiro)
        Me.pagTabela.Controls.Add(Me.btnAgruparGridRoteiro)
        Me.pagTabela.Controls.Add(Me.btnConfigurarGridRoteiro)
        Me.pagTabela.Controls.Add(Me.grpFiltro)
        Me.pagTabela.Controls.Add(Me.grdRoteiroImportacao)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(914, 486)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Importação"
        '
        'btnExcelGridRoteiro
        '
        Me.btnExcelGridRoteiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridRoteiro.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridRoteiro.FlatAppearance.BorderSize = 0
        Me.btnExcelGridRoteiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridRoteiro.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridRoteiro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridRoteiro.Location = New System.Drawing.Point(61, 403)
        Me.btnExcelGridRoteiro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridRoteiro.Name = "btnExcelGridRoteiro"
        Me.btnExcelGridRoteiro.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridRoteiro.TabIndex = 15
        Me.btnExcelGridRoteiro.TabStop = False
        Me.btnExcelGridRoteiro.UseVisualStyleBackColor = False
        '
        'btnAgruparGridRoteiro
        '
        Me.btnAgruparGridRoteiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridRoteiro.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridRoteiro.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridRoteiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridRoteiro.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridRoteiro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridRoteiro.Location = New System.Drawing.Point(37, 403)
        Me.btnAgruparGridRoteiro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridRoteiro.Name = "btnAgruparGridRoteiro"
        Me.btnAgruparGridRoteiro.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridRoteiro.TabIndex = 14
        Me.btnAgruparGridRoteiro.TabStop = False
        Me.btnAgruparGridRoteiro.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridRoteiro
        '
        Me.btnConfigurarGridRoteiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridRoteiro.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridRoteiro.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridRoteiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridRoteiro.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridRoteiro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridRoteiro.Location = New System.Drawing.Point(13, 403)
        Me.btnConfigurarGridRoteiro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridRoteiro.Name = "btnConfigurarGridRoteiro"
        Me.btnConfigurarGridRoteiro.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridRoteiro.TabIndex = 13
        Me.btnConfigurarGridRoteiro.TabStop = False
        Me.btnConfigurarGridRoteiro.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtCodigoProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCodigoProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(898, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtCodigoProdutoFiltro
        '
        Me.txtCodigoProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoProdutoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtCodigoProdutoFiltro.MaxLength = 60
        Me.txtCodigoProdutoFiltro.Name = "txtCodigoProdutoFiltro"
        Me.txtCodigoProdutoFiltro.Size = New System.Drawing.Size(187, 20)
        Me.txtCodigoProdutoFiltro.TabIndex = 0
        '
        'lblCodigoProdutoFiltro
        '
        Me.lblCodigoProdutoFiltro.AutoSize = True
        Me.lblCodigoProdutoFiltro.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigoProdutoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigoProdutoFiltro.Name = "lblCodigoProdutoFiltro"
        Me.lblCodigoProdutoFiltro.Size = New System.Drawing.Size(83, 14)
        Me.lblCodigoProdutoFiltro.TabIndex = 29
        Me.lblCodigoProdutoFiltro.Text = "Código Produto:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(801, 29)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 1
        Me.btnFiltrar.Tag = ""
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdRoteiroImportacao
        '
        Me.grdRoteiroImportacao.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdRoteiroImportacao.AlternatingColors = True
        Me.grdRoteiroImportacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdRoteiroImportacao_DesignTimeLayout.LayoutString = resources.GetString("grdRoteiroImportacao_DesignTimeLayout.LayoutString")
        Me.grdRoteiroImportacao.DesignTimeLayout = grdRoteiroImportacao_DesignTimeLayout
        Me.grdRoteiroImportacao.DynamicFiltering = True
        Me.grdRoteiroImportacao.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdRoteiroImportacao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdRoteiroImportacao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdRoteiroImportacao.FrozenColumns = 2
        Me.grdRoteiroImportacao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdRoteiroImportacao.GroupByBoxVisible = False
        Me.grdRoteiroImportacao.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdRoteiroImportacao.Location = New System.Drawing.Point(8, 79)
        Me.grdRoteiroImportacao.Name = "grdRoteiroImportacao"
        Me.grdRoteiroImportacao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdRoteiroImportacao.RecordNavigator = True
        Me.grdRoteiroImportacao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdRoteiroImportacao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdRoteiroImportacao.Size = New System.Drawing.Size(902, 341)
        Me.grdRoteiroImportacao.TabIndex = 10
        Me.grdRoteiroImportacao.TabStop = False
        Me.grdRoteiroImportacao.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdRoteiroImportacao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdRoteiroImportacao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdRoteiroImportacao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdRoteiroImportacao.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnImportar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 426)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(898, 51)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnImportar
        '
        Me.btnImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportar.Image = Global.INTERACTI.My.Resources.Resources.download
        Me.btnImportar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportar.Location = New System.Drawing.Point(701, 17)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportar.Size = New System.Drawing.Size(91, 23)
        Me.btnImportar.TabIndex = 0
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(798, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmPrdOrdemProducaoCopiarRoteiroProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 523)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrdOrdemProducaoCopiarRoteiroProduto"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Importar Roteiro"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdRoteiroImportacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnImportar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdRoteiroImportacao As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtCodigoProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCodigoProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelGridRoteiro As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridRoteiro As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridRoteiro As System.Windows.Forms.Button
End Class
