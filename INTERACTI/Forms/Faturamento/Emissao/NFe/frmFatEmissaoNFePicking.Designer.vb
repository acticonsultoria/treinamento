<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEmissaoNFePicking
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
        Dim grdPicking_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdPicking_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEmissaoNFePicking))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLegendaRegraVenda = New System.Windows.Forms.Label()
        Me.picLegendaRegraVenda = New System.Windows.Forms.PictureBox()
        Me.grdPicking = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarCliente = New System.Windows.Forms.Button()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.cboClienteFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblClienteFiltro = New System.Windows.Forms.Label()
        Me.txtCNPJCPFFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCNPJCPFFiltro = New System.Windows.Forms.Label()
        Me.cboNumeroPickingFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNumeroPickingFiltro = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImportarPicking = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaRegraVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPicking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(914, 567)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.btnAgruparGrid)
        Me.pagTabela.Controls.Add(Me.btnConfigurarGrid)
        Me.pagTabela.Controls.Add(Me.grpLegenda)
        Me.pagTabela.Controls.Add(Me.grdPicking)
        Me.pagTabela.Controls.Add(Me.grpFiltro)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(912, 544)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Picking"
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 464)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 3
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 464)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpLegenda
        '
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblLegendaRegraVenda)
        Me.grpLegenda.Controls.Add(Me.picLegendaRegraVenda)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 484)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(179, 51)
        Me.grpLegenda.TabIndex = 4
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblLegendaRegraVenda
        '
        Me.lblLegendaRegraVenda.AutoSize = True
        Me.lblLegendaRegraVenda.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaRegraVenda.Name = "lblLegendaRegraVenda"
        Me.lblLegendaRegraVenda.Size = New System.Drawing.Size(145, 14)
        Me.lblLegendaRegraVenda.TabIndex = 0
        Me.lblLegendaRegraVenda.Text = "NÃO possui Regra de Venda"
        '
        'picLegendaRegraVenda
        '
        Me.picLegendaRegraVenda.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaRegraVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaRegraVenda.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaRegraVenda.Name = "picLegendaRegraVenda"
        Me.picLegendaRegraVenda.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaRegraVenda.TabIndex = 16
        Me.picLegendaRegraVenda.TabStop = False
        '
        'grdPicking
        '
        Me.grdPicking.AlternatingColors = True
        Me.grdPicking.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPicking.AutoEdit = True
        Me.grdPicking.CardBorders = False
        grdPicking_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdPicking_DesignTimeLayout_Reference_0.Instance"), Object)
        grdPicking_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdPicking_DesignTimeLayout_Reference_0})
        grdPicking_DesignTimeLayout.LayoutString = resources.GetString("grdPicking_DesignTimeLayout.LayoutString")
        Me.grdPicking.DesignTimeLayout = grdPicking_DesignTimeLayout
        Me.grdPicking.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdPicking.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdPicking.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdPicking.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdPicking.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdPicking.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdPicking.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdPicking.FrozenColumns = 5
        Me.grdPicking.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdPicking.GroupByBoxVisible = False
        Me.grdPicking.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdPicking.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPicking.Location = New System.Drawing.Point(8, 77)
        Me.grdPicking.Name = "grdPicking"
        Me.grdPicking.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdPicking.RecordNavigator = True
        Me.grdPicking.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdPicking.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPicking.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdPicking.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdPicking.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdPicking.Size = New System.Drawing.Size(896, 404)
        Me.grdPicking.TabIndex = 1
        Me.grdPicking.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        Me.grdPicking.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdPicking.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdPicking.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdPicking.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdPicking.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdPicking.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdPicking.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdPicking.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdPicking.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnProcurarCliente)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.cboClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblClienteFiltro)
        Me.grpFiltro.Controls.Add(Me.txtCNPJCPFFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCNPJCPFFiltro)
        Me.grpFiltro.Controls.Add(Me.cboNumeroPickingFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNumeroPickingFiltro)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(896, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarCliente
        '
        Me.btnProcurarCliente.FlatAppearance.BorderSize = 0
        Me.btnProcurarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCliente.Image = Global.INTERACTI.My.Resources.search
        Me.btnProcurarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCliente.Location = New System.Drawing.Point(493, 15)
        Me.btnProcurarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCliente.Name = "btnProcurarCliente"
        Me.btnProcurarCliente.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCliente.TabIndex = 9
        Me.btnProcurarCliente.TabStop = False
        Me.btnProcurarCliente.UseVisualStyleBackColor = True
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(796, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 8
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboClienteFiltro
        '
        Me.cboClienteFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboClienteFiltro.AutoSize = False
        Me.cboClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboClienteFiltro.Location = New System.Drawing.Point(9, 34)
        Me.cboClienteFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboClienteFiltro.Name = "cboClienteFiltro"
        Me.cboClienteFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboClienteFiltro.Size = New System.Drawing.Size(501, 20)
        Me.cboClienteFiltro.TabIndex = 1
        '
        'lblClienteFiltro
        '
        Me.lblClienteFiltro.AutoSize = True
        Me.lblClienteFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblClienteFiltro.Name = "lblClienteFiltro"
        Me.lblClienteFiltro.Size = New System.Drawing.Size(42, 14)
        Me.lblClienteFiltro.TabIndex = 0
        Me.lblClienteFiltro.Text = "Cliente:"
        '
        'txtCNPJCPFFiltro
        '
        Me.txtCNPJCPFFiltro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCNPJCPFFiltro.Enabled = False
        Me.txtCNPJCPFFiltro.Location = New System.Drawing.Point(516, 34)
        Me.txtCNPJCPFFiltro.Mask = "00,000,000/0000-00"
        Me.txtCNPJCPFFiltro.MaxLength = 25
        Me.txtCNPJCPFFiltro.Name = "txtCNPJCPFFiltro"
        Me.txtCNPJCPFFiltro.ReadOnly = True
        Me.txtCNPJCPFFiltro.Size = New System.Drawing.Size(129, 20)
        Me.txtCNPJCPFFiltro.TabIndex = 3
        Me.txtCNPJCPFFiltro.TabStop = False
        '
        'lblCNPJCPFFiltro
        '
        Me.lblCNPJCPFFiltro.AutoSize = True
        Me.lblCNPJCPFFiltro.Location = New System.Drawing.Point(513, 17)
        Me.lblCNPJCPFFiltro.Name = "lblCNPJCPFFiltro"
        Me.lblCNPJCPFFiltro.Size = New System.Drawing.Size(35, 14)
        Me.lblCNPJCPFFiltro.TabIndex = 2
        Me.lblCNPJCPFFiltro.Text = "CNPJ:"
        '
        'cboNumeroPickingFiltro
        '
        Me.cboNumeroPickingFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboNumeroPickingFiltro.AutoSize = False
        Me.cboNumeroPickingFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNumeroPickingFiltro.Location = New System.Drawing.Point(651, 34)
        Me.cboNumeroPickingFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboNumeroPickingFiltro.Name = "cboNumeroPickingFiltro"
        Me.cboNumeroPickingFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNumeroPickingFiltro.Size = New System.Drawing.Size(120, 20)
        Me.cboNumeroPickingFiltro.TabIndex = 11
        '
        'lblNumeroPickingFiltro
        '
        Me.lblNumeroPickingFiltro.AutoSize = True
        Me.lblNumeroPickingFiltro.Location = New System.Drawing.Point(648, 17)
        Me.lblNumeroPickingFiltro.Name = "lblNumeroPickingFiltro"
        Me.lblNumeroPickingFiltro.Size = New System.Drawing.Size(58, 14)
        Me.lblNumeroPickingFiltro.TabIndex = 10
        Me.lblNumeroPickingFiltro.Text = "Nº Picking:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnImportarPicking)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(196, 484)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(708, 51)
        Me.grpControl2.TabIndex = 5
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnImportarPicking
        '
        Me.btnImportarPicking.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportarPicking.Image = Global.INTERACTI.My.Resources.download
        Me.btnImportarPicking.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportarPicking.Location = New System.Drawing.Point(402, 17)
        Me.btnImportarPicking.Name = "btnImportarPicking"
        Me.btnImportarPicking.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportarPicking.Size = New System.Drawing.Size(200, 23)
        Me.btnImportarPicking.TabIndex = 0
        Me.btnImportarPicking.Text = "Importar Picking"
        Me.btnImportarPicking.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(608, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmFatEmissaoNFePicking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 582)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEmissaoNFePicking"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nota Fiscal Eletrônica - Importar Picking"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaRegraVenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPicking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnImportarPicking As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtCNPJCPFFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCNPJCPFFiltro As System.Windows.Forms.Label
    Friend WithEvents grdPicking As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblLegendaRegraVenda As System.Windows.Forms.Label
    Friend WithEvents picLegendaRegraVenda As System.Windows.Forms.PictureBox
    Friend WithEvents lblClienteFiltro As System.Windows.Forms.Label
    Friend WithEvents cboClienteFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnProcurarCliente As System.Windows.Forms.Button
    Friend WithEvents cboNumeroPickingFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNumeroPickingFiltro As System.Windows.Forms.Label
End Class
