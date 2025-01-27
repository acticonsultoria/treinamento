<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFindServico
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
        Dim grdFind_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFindServico))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdFind = New Janus.Windows.GridEX.GridEX()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblRevisaoTabelaPreco = New System.Windows.Forms.Label()
        Me.cboRevisaoTabelaPreco = New Janus.Windows.EditControls.UIComboBox()
        Me.txtPercentualBDI = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPercentualBDI = New System.Windows.Forms.Label()
        Me.txtPercentualComercial = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPercentualComercial = New System.Windows.Forms.Label()
        Me.txtPercentualNotaFiscal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPercentualNotaFiscal = New System.Windows.Forms.Label()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnImportar = New Janus.Windows.EditControls.UIButton()
        CType(Me.grdFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
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
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(25, 429)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 42
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(1, 429)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 40
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdFind
        '
        Me.grdFind.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdFind.AlternatingColors = True
        Me.grdFind.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdFind.AutoEdit = True
        Me.grdFind.ColumnAutoResize = True
        grdFind_DesignTimeLayout.LayoutString = resources.GetString("grdFind_DesignTimeLayout.LayoutString")
        Me.grdFind.DesignTimeLayout = grdFind_DesignTimeLayout
        Me.grdFind.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdFind.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdFind.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdFind.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdFind.FrozenColumns = 1
        Me.grdFind.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdFind.GroupByBoxVisible = False
        Me.grdFind.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdFind.Location = New System.Drawing.Point(0, 0)
        Me.grdFind.Name = "grdFind"
        Me.grdFind.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdFind.RecordNavigator = True
        Me.grdFind.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdFind.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdFind.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdFind.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdFind.Size = New System.Drawing.Size(1000, 446)
        Me.grdFind.TabIndex = 43
        Me.grdFind.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdFind.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdFind.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdFind.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdFind.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdFind.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdFind.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdFind.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdFind.VisualStyleManager = Me.vsmMain
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.lblRevisaoTabelaPreco)
        Me.grpControle.Controls.Add(Me.cboRevisaoTabelaPreco)
        Me.grpControle.Controls.Add(Me.txtPercentualBDI)
        Me.grpControle.Controls.Add(Me.lblPercentualBDI)
        Me.grpControle.Controls.Add(Me.txtPercentualComercial)
        Me.grpControle.Controls.Add(Me.lblPercentualComercial)
        Me.grpControle.Controls.Add(Me.txtPercentualNotaFiscal)
        Me.grpControle.Controls.Add(Me.lblPercentualNotaFiscal)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Controls.Add(Me.btnImportar)
        Me.grpControle.Location = New System.Drawing.Point(1, 449)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(999, 51)
        Me.grpControle.TabIndex = 44
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'lblRevisaoTabelaPreco
        '
        Me.lblRevisaoTabelaPreco.AutoSize = True
        Me.lblRevisaoTabelaPreco.Location = New System.Drawing.Point(388, 21)
        Me.lblRevisaoTabelaPreco.Name = "lblRevisaoTabelaPreco"
        Me.lblRevisaoTabelaPreco.Size = New System.Drawing.Size(72, 14)
        Me.lblRevisaoTabelaPreco.TabIndex = 26
        Me.lblRevisaoTabelaPreco.Text = "Tabela Preço:"
        '
        'cboRevisaoTabelaPreco
        '
        Me.cboRevisaoTabelaPreco.AutoSize = False
        Me.cboRevisaoTabelaPreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboRevisaoTabelaPreco.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboRevisaoTabelaPreco.Location = New System.Drawing.Point(477, 18)
        Me.cboRevisaoTabelaPreco.Name = "cboRevisaoTabelaPreco"
        Me.cboRevisaoTabelaPreco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboRevisaoTabelaPreco.Size = New System.Drawing.Size(150, 20)
        Me.cboRevisaoTabelaPreco.TabIndex = 27
        '
        'txtPercentualBDI
        '
        Me.txtPercentualBDI.DecimalDigits = 2
        Me.txtPercentualBDI.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtPercentualBDI.Location = New System.Drawing.Point(315, 18)
        Me.txtPercentualBDI.Name = "txtPercentualBDI"
        Me.txtPercentualBDI.Size = New System.Drawing.Size(67, 20)
        Me.txtPercentualBDI.TabIndex = 25
        Me.txtPercentualBDI.Text = "0,00%"
        Me.txtPercentualBDI.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPercentualBDI
        '
        Me.lblPercentualBDI.AutoSize = True
        Me.lblPercentualBDI.Location = New System.Drawing.Point(270, 21)
        Me.lblPercentualBDI.Name = "lblPercentualBDI"
        Me.lblPercentualBDI.Size = New System.Drawing.Size(39, 14)
        Me.lblPercentualBDI.TabIndex = 24
        Me.lblPercentualBDI.Text = "% BDI:"
        '
        'txtPercentualComercial
        '
        Me.txtPercentualComercial.DecimalDigits = 2
        Me.txtPercentualComercial.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtPercentualComercial.Location = New System.Drawing.Point(197, 18)
        Me.txtPercentualComercial.Name = "txtPercentualComercial"
        Me.txtPercentualComercial.Size = New System.Drawing.Size(67, 20)
        Me.txtPercentualComercial.TabIndex = 23
        Me.txtPercentualComercial.Text = "0,00%"
        Me.txtPercentualComercial.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPercentualComercial
        '
        Me.lblPercentualComercial.AutoSize = True
        Me.lblPercentualComercial.Location = New System.Drawing.Point(121, 21)
        Me.lblPercentualComercial.Name = "lblPercentualComercial"
        Me.lblPercentualComercial.Size = New System.Drawing.Size(70, 14)
        Me.lblPercentualComercial.TabIndex = 22
        Me.lblPercentualComercial.Text = "% Comercial:"
        '
        'txtPercentualNotaFiscal
        '
        Me.txtPercentualNotaFiscal.DecimalDigits = 2
        Me.txtPercentualNotaFiscal.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtPercentualNotaFiscal.Location = New System.Drawing.Point(48, 18)
        Me.txtPercentualNotaFiscal.Name = "txtPercentualNotaFiscal"
        Me.txtPercentualNotaFiscal.Size = New System.Drawing.Size(67, 20)
        Me.txtPercentualNotaFiscal.TabIndex = 21
        Me.txtPercentualNotaFiscal.Text = "0,00%"
        Me.txtPercentualNotaFiscal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPercentualNotaFiscal
        '
        Me.lblPercentualNotaFiscal.AutoSize = True
        Me.lblPercentualNotaFiscal.Location = New System.Drawing.Point(6, 21)
        Me.lblPercentualNotaFiscal.Name = "lblPercentualNotaFiscal"
        Me.lblPercentualNotaFiscal.Size = New System.Drawing.Size(36, 14)
        Me.lblPercentualNotaFiscal.TabIndex = 20
        Me.lblPercentualNotaFiscal.Text = "% NF:"
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(899, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImportar
        '
        Me.btnImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportar.Image = Global.INTERACTI.My.Resources.Resources.download
        Me.btnImportar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportar.Location = New System.Drawing.Point(802, 17)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportar.Size = New System.Drawing.Size(91, 23)
        Me.btnImportar.TabIndex = 1
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrFindServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.btnExcelGrid)
        Me.Controls.Add(Me.btnConfigurarGrid)
        Me.Controls.Add(Me.grdFind)
        Me.Controls.Add(Me.grpControle)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFindServico"
        Me.Size = New System.Drawing.Size(1000, 500)
        CType(Me.grdFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.grpControle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grdFind As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Private WithEvents btnImportar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtPercentualBDI As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPercentualBDI As System.Windows.Forms.Label
    Friend WithEvents txtPercentualComercial As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPercentualComercial As System.Windows.Forms.Label
    Friend WithEvents txtPercentualNotaFiscal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPercentualNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents lblRevisaoTabelaPreco As System.Windows.Forms.Label
    Friend WithEvents cboRevisaoTabelaPreco As Janus.Windows.EditControls.UIComboBox

End Class
