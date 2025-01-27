<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadProdutoPrecoVendaHistorico
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
        Dim grdHistorico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadProdutoPrecoVendaHistorico))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdHistorico = New Janus.Windows.GridEX.GridEX()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtMarca = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtCodigo2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblCodigo2 = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grdHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(958, 535)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.btnExcelGrid)
        Me.pagTabela.Controls.Add(Me.btnAgruparGrid)
        Me.pagTabela.Controls.Add(Me.btnConfigurarGrid)
        Me.pagTabela.Controls.Add(Me.grdHistorico)
        Me.pagTabela.Controls.Add(Me.grpDados)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(956, 512)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Histórico"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 432)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 38
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 432)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 37
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 432)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 36
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdHistorico
        '
        Me.grdHistorico.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdHistorico.AlternatingColors = True
        Me.grdHistorico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdHistorico.ColumnAutoResize = True
        grdHistorico_DesignTimeLayout.LayoutString = resources.GetString("grdHistorico_DesignTimeLayout.LayoutString")
        Me.grdHistorico.DesignTimeLayout = grdHistorico_DesignTimeLayout
        Me.grdHistorico.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdHistorico.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdHistorico.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdHistorico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdHistorico.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdHistorico.GroupByBoxVisible = False
        Me.grdHistorico.Location = New System.Drawing.Point(8, 77)
        Me.grdHistorico.Name = "grdHistorico"
        Me.grdHistorico.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdHistorico.RecordNavigator = True
        Me.grdHistorico.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdHistorico.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdHistorico.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdHistorico.Size = New System.Drawing.Size(940, 372)
        Me.grdHistorico.TabIndex = 3
        Me.grdHistorico.TabStop = False
        Me.grdHistorico.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdHistorico.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdHistorico.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdHistorico.VisualStyleManager = Me.vsmMain
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.lblCodigo)
        Me.grpDados.Controls.Add(Me.txtMarca)
        Me.grpDados.Controls.Add(Me.lblMarca)
        Me.grpDados.Controls.Add(Me.txtCodigo2)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Controls.Add(Me.lblCodigo2)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.txtCodigo)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(940, 64)
        Me.grpDados.TabIndex = 0
        Me.grpDados.Text = "Dados do Produto"
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigo.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigo.TabIndex = 8
        Me.lblCodigo.Text = "Código:"
        '
        'txtMarca
        '
        Me.txtMarca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarca.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarca.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMarca.Location = New System.Drawing.Point(734, 34)
        Me.txtMarca.MaxLength = 100
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(197, 20)
        Me.txtMarca.TabIndex = 15
        Me.txtMarca.TabStop = False
        '
        'lblMarca
        '
        Me.lblMarca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMarca.AutoSize = True
        Me.lblMarca.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarca.Location = New System.Drawing.Point(731, 17)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(40, 14)
        Me.lblMarca.TabIndex = 14
        Me.lblMarca.Text = "Marca:"
        '
        'txtCodigo2
        '
        Me.txtCodigo2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodigo2.Location = New System.Drawing.Point(138, 34)
        Me.txtCodigo2.Name = "txtCodigo2"
        Me.txtCodigo2.ReadOnly = True
        Me.txtCodigo2.Size = New System.Drawing.Size(123, 20)
        Me.txtCodigo2.TabIndex = 11
        Me.txtCodigo2.TabStop = False
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricao.Location = New System.Drawing.Point(264, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 12
        Me.lblDescricao.Text = "Descrição:"
        '
        'lblCodigo2
        '
        Me.lblCodigo2.AutoSize = True
        Me.lblCodigo2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigo2.Location = New System.Drawing.Point(135, 17)
        Me.lblCodigo2.Name = "lblCodigo2"
        Me.lblCodigo2.Size = New System.Drawing.Size(50, 14)
        Me.lblCodigo2.TabIndex = 10
        Me.lblCodigo2.Text = "Código ²:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDescricao.Location = New System.Drawing.Point(267, 34)
        Me.txtDescricao.MaxLength = 120
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(461, 20)
        Me.txtDescricao.TabIndex = 13
        Me.txtDescricao.TabStop = False
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodigo.Location = New System.Drawing.Point(9, 34)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(123, 20)
        Me.txtCodigo.TabIndex = 9
        Me.txtCodigo.TabStop = False
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 452)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(940, 51)
        Me.grpControl2.TabIndex = 2
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(840, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmCadProdutoPrecoVendaHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 550)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadProdutoPrecoVendaHistorico"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Histórico"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grdHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdHistorico As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtMarca As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents txtCodigo2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents lblCodigo2 As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
End Class
