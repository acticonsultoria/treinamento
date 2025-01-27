<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEmissaoNFeImportacaoNFProdutoXML
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
        Dim grdNF_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdNF_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEmissaoNFeImportacaoNFProdutoXML))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridXML = New System.Windows.Forms.Button()
        Me.btnAgruparGridXML = New System.Windows.Forms.Button()
        Me.btnConfigurarGridXML = New System.Windows.Forms.Button()
        Me.grpControleDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnConfirmar = New Janus.Windows.EditControls.UIButton()
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.grdNF = New Janus.Windows.GridEX.GridEX()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.cboCFOP = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCFOP = New System.Windows.Forms.Label()
        Me.txtNumeroDrawback = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDrawback = New System.Windows.Forms.Label()
        Me.grpEntrega = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboNaturezaOperacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblNaturezaOperacao = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpControleDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleDados.SuspendLayout()
        CType(Me.grdNF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEntrega.SuspendLayout()
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
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(1001, 523)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpEntrega)
        Me.pagDados.Controls.Add(Me.btnExcelGridXML)
        Me.pagDados.Controls.Add(Me.btnAgruparGridXML)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridXML)
        Me.pagDados.Controls.Add(Me.grpControleDados)
        Me.pagDados.Controls.Add(Me.grdNF)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(999, 500)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Nota Fiscal - Produtos"
        '
        'btnExcelGridXML
        '
        Me.btnExcelGridXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridXML.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridXML.FlatAppearance.BorderSize = 0
        Me.btnExcelGridXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridXML.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridXML.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridXML.Location = New System.Drawing.Point(57, 416)
        Me.btnExcelGridXML.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridXML.Name = "btnExcelGridXML"
        Me.btnExcelGridXML.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridXML.TabIndex = 3
        Me.btnExcelGridXML.TabStop = False
        Me.btnExcelGridXML.UseVisualStyleBackColor = False
        '
        'btnAgruparGridXML
        '
        Me.btnAgruparGridXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridXML.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridXML.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridXML.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridXML.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridXML.Location = New System.Drawing.Point(33, 416)
        Me.btnAgruparGridXML.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridXML.Name = "btnAgruparGridXML"
        Me.btnAgruparGridXML.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridXML.TabIndex = 2
        Me.btnAgruparGridXML.TabStop = False
        Me.btnAgruparGridXML.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridXML
        '
        Me.btnConfigurarGridXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridXML.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridXML.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridXML.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridXML.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridXML.Location = New System.Drawing.Point(9, 416)
        Me.btnConfigurarGridXML.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridXML.Name = "btnConfigurarGridXML"
        Me.btnConfigurarGridXML.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridXML.TabIndex = 1
        Me.btnConfigurarGridXML.TabStop = False
        Me.btnConfigurarGridXML.UseVisualStyleBackColor = False
        '
        'grpControleDados
        '
        Me.grpControleDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControleDados.BackColor = System.Drawing.Color.Transparent
        Me.grpControleDados.Controls.Add(Me.btnConfirmar)
        Me.grpControleDados.Controls.Add(Me.btnCancelar)
        Me.grpControleDados.Location = New System.Drawing.Point(8, 440)
        Me.grpControleDados.Name = "grpControleDados"
        Me.grpControleDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleDados.Size = New System.Drawing.Size(983, 51)
        Me.grpControleDados.TabIndex = 9
        Me.grpControleDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControleDados.VisualStyleManager = Me.vsmMain
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmar.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnConfirmar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnConfirmar.Location = New System.Drawing.Point(753, 17)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnConfirmar.Size = New System.Drawing.Size(106, 23)
        Me.btnConfirmar.TabIndex = 10
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.INTERACTI.My.Resources.Resources.cancelar
        Me.btnCancelar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCancelar.Location = New System.Drawing.Point(865, 17)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCancelar.Size = New System.Drawing.Size(109, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdNF
        '
        Me.grdNF.AllowDrop = True
        Me.grdNF.AlternatingColors = True
        Me.grdNF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdNF.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        grdNF_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdNF_DesignTimeLayout_Reference_0.Instance"), Object)
        grdNF_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdNF_DesignTimeLayout_Reference_0})
        grdNF_DesignTimeLayout.LayoutString = resources.GetString("grdNF_DesignTimeLayout.LayoutString")
        Me.grdNF.DesignTimeLayout = grdNF_DesignTimeLayout
        Me.grdNF.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdNF.FocusCellFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdNF.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdNF.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdNF.FrozenColumns = 1
        Me.grdNF.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdNF.GroupByBoxVisible = False
        Me.grdNF.Location = New System.Drawing.Point(8, 76)
        Me.grdNF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdNF.Name = "grdNF"
        Me.grdNF.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdNF.RecordNavigator = True
        Me.grdNF.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
        Me.grdNF.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdNF.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdNF.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdNF.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdNF.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdNF.Size = New System.Drawing.Size(983, 357)
        Me.grdNF.TabIndex = 0
        Me.grdNF.TabStop = False
        Me.grdNF.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdNF.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdNF.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdNF.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdNF.VisualStyleManager = Me.vsmMain
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'cboCFOP
        '
        Me.cboCFOP.AutoSize = False
        Me.cboCFOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCFOP.Location = New System.Drawing.Point(9, 34)
        Me.cboCFOP.Name = "cboCFOP"
        Me.cboCFOP.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCFOP.Size = New System.Drawing.Size(105, 20)
        Me.cboCFOP.TabIndex = 1
        '
        'lblCFOP
        '
        Me.lblCFOP.AutoSize = True
        Me.lblCFOP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCFOP.Location = New System.Drawing.Point(6, 17)
        Me.lblCFOP.Name = "lblCFOP"
        Me.lblCFOP.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOP.TabIndex = 0
        Me.lblCFOP.Text = "CFOP:"
        '
        'txtNumeroDrawback
        '
        Me.txtNumeroDrawback.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDrawback.Location = New System.Drawing.Point(120, 34)
        Me.txtNumeroDrawback.MaxLength = 50
        Me.txtNumeroDrawback.Name = "txtNumeroDrawback"
        Me.txtNumeroDrawback.Size = New System.Drawing.Size(194, 20)
        Me.txtNumeroDrawback.TabIndex = 3
        '
        'lblNumeroDrawback
        '
        Me.lblNumeroDrawback.AutoSize = True
        Me.lblNumeroDrawback.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroDrawback.Location = New System.Drawing.Point(117, 17)
        Me.lblNumeroDrawback.Name = "lblNumeroDrawback"
        Me.lblNumeroDrawback.Size = New System.Drawing.Size(100, 14)
        Me.lblNumeroDrawback.TabIndex = 2
        Me.lblNumeroDrawback.Text = "Número Drawback:"
        '
        'grpEntrega
        '
        Me.grpEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEntrega.BackColor = System.Drawing.Color.Transparent
        Me.grpEntrega.Controls.Add(Me.cboNaturezaOperacao)
        Me.grpEntrega.Controls.Add(Me.lblNaturezaOperacao)
        Me.grpEntrega.Controls.Add(Me.lblNumeroDrawback)
        Me.grpEntrega.Controls.Add(Me.txtNumeroDrawback)
        Me.grpEntrega.Controls.Add(Me.lblCFOP)
        Me.grpEntrega.Controls.Add(Me.cboCFOP)
        Me.grpEntrega.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEntrega.Location = New System.Drawing.Point(8, 3)
        Me.grpEntrega.Name = "grpEntrega"
        Me.grpEntrega.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEntrega.Size = New System.Drawing.Size(983, 66)
        Me.grpEntrega.TabIndex = 0
        Me.grpEntrega.VisualStyleManager = Me.vsmMain
        '
        'cboNaturezaOperacao
        '
        Me.cboNaturezaOperacao.AutoSize = False
        Me.cboNaturezaOperacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboNaturezaOperacao.Location = New System.Drawing.Point(320, 34)
        Me.cboNaturezaOperacao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboNaturezaOperacao.Name = "cboNaturezaOperacao"
        Me.cboNaturezaOperacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboNaturezaOperacao.Size = New System.Drawing.Size(374, 20)
        Me.cboNaturezaOperacao.TabIndex = 5
        '
        'lblNaturezaOperacao
        '
        Me.lblNaturezaOperacao.AutoSize = True
        Me.lblNaturezaOperacao.Location = New System.Drawing.Point(317, 17)
        Me.lblNaturezaOperacao.Name = "lblNaturezaOperacao"
        Me.lblNaturezaOperacao.Size = New System.Drawing.Size(120, 14)
        Me.lblNaturezaOperacao.TabIndex = 4
        Me.lblNaturezaOperacao.Text = "Natureza da Operação:"
        '
        'frmFatEmissaoNFeImportacaoNFProdutoXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 538)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmFatEmissaoNFeImportacaoNFProdutoXML"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importação de NFe - Produto"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpControleDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleDados.ResumeLayout(False)
        CType(Me.grdNF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEntrega.ResumeLayout(False)
        Me.grpEntrega.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControleDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnConfirmar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdNF As Janus.Windows.GridEX.GridEX

    Friend WithEvents btnConfigurarGridXML As System.Windows.Forms.Button
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnExcelGridXML As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridXML As System.Windows.Forms.Button
    Friend WithEvents grpEntrega As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblNumeroDrawback As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDrawback As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCFOP As System.Windows.Forms.Label
    Friend WithEvents cboCFOP As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboNaturezaOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblNaturezaOperacao As System.Windows.Forms.Label
End Class
