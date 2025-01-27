<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEmissaoNFeImportacaoBoleta
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
        Dim grdBoleta_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdBoleta_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEmissaoNFeImportacaoBoleta))
        Dim grdBoleta_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpEntrega = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.btnProcurarCliente = New System.Windows.Forms.Button()
        Me.btnCadastrarCliente = New System.Windows.Forms.Button()
        Me.txtUFDestino = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumeroTicket = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNotaFiscal = New System.Windows.Forms.Label()
        Me.cboCliente = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcelGridXML = New System.Windows.Forms.Button()
        Me.btnAgruparGridXML = New System.Windows.Forms.Button()
        Me.btnConfigurarGridXML = New System.Windows.Forms.Button()
        Me.grpControleDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnConfirmar = New Janus.Windows.EditControls.UIButton()
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.grdBoleta = New Janus.Windows.GridEX.GridEX()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEntrega.SuspendLayout()
        CType(Me.grpControleDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleDados.SuspendLayout()
        CType(Me.grdBoleta, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pagDados.Controls.Add(Me.grdBoleta)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(999, 500)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Nota Fiscal - Produtos"
        '
        'grpEntrega
        '
        Me.grpEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEntrega.BackColor = System.Drawing.Color.Transparent
        Me.grpEntrega.Controls.Add(Me.lblCliente)
        Me.grpEntrega.Controls.Add(Me.btnProcurarCliente)
        Me.grpEntrega.Controls.Add(Me.btnCadastrarCliente)
        Me.grpEntrega.Controls.Add(Me.txtUFDestino)
        Me.grpEntrega.Controls.Add(Me.Label1)
        Me.grpEntrega.Controls.Add(Me.txtNumeroTicket)
        Me.grpEntrega.Controls.Add(Me.lblNotaFiscal)
        Me.grpEntrega.Controls.Add(Me.cboCliente)
        Me.grpEntrega.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEntrega.Location = New System.Drawing.Point(8, 3)
        Me.grpEntrega.Name = "grpEntrega"
        Me.grpEntrega.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEntrega.Size = New System.Drawing.Size(983, 66)
        Me.grpEntrega.TabIndex = 0
        Me.grpEntrega.VisualStyleManager = Me.vsmMain
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(140, 14)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 13
        Me.lblCliente.Text = "Cliente:"
        '
        'btnProcurarCliente
        '
        Me.btnProcurarCliente.FlatAppearance.BorderSize = 0
        Me.btnProcurarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCliente.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCliente.Location = New System.Drawing.Point(569, 13)
        Me.btnProcurarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCliente.Name = "btnProcurarCliente"
        Me.btnProcurarCliente.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCliente.TabIndex = 14
        Me.btnProcurarCliente.TabStop = False
        Me.btnProcurarCliente.UseVisualStyleBackColor = True
        '
        'btnCadastrarCliente
        '
        Me.btnCadastrarCliente.FlatAppearance.BorderSize = 0
        Me.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCliente.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarCliente.Location = New System.Drawing.Point(124, 15)
        Me.btnCadastrarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarCliente.Name = "btnCadastrarCliente"
        Me.btnCadastrarCliente.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarCliente.TabIndex = 12
        Me.btnCadastrarCliente.TabStop = False
        Me.btnCadastrarCliente.UseVisualStyleBackColor = True
        '
        'txtUFDestino
        '
        Me.txtUFDestino.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUFDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUFDestino.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUFDestino.Location = New System.Drawing.Point(593, 31)
        Me.txtUFDestino.MaxLength = 50
        Me.txtUFDestino.Name = "txtUFDestino"
        Me.txtUFDestino.ReadOnly = True
        Me.txtUFDestino.Size = New System.Drawing.Size(68, 20)
        Me.txtUFDestino.TabIndex = 9
        Me.txtUFDestino.TabStop = False
        Me.txtUFDestino.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(590, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 14)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "UF:"
        '
        'txtNumeroTicket
        '
        Me.txtNumeroTicket.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroTicket.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroTicket.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroTicket.Location = New System.Drawing.Point(15, 31)
        Me.txtNumeroTicket.MaxLength = 50
        Me.txtNumeroTicket.Name = "txtNumeroTicket"
        Me.txtNumeroTicket.ReadOnly = True
        Me.txtNumeroTicket.Size = New System.Drawing.Size(104, 20)
        Me.txtNumeroTicket.TabIndex = 7
        Me.txtNumeroTicket.TabStop = False
        Me.txtNumeroTicket.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblNotaFiscal
        '
        Me.lblNotaFiscal.AutoSize = True
        Me.lblNotaFiscal.Location = New System.Drawing.Point(12, 14)
        Me.lblNotaFiscal.Name = "lblNotaFiscal"
        Me.lblNotaFiscal.Size = New System.Drawing.Size(53, 14)
        Me.lblNotaFiscal.TabIndex = 6
        Me.lblNotaFiscal.Text = "Nº Ticket:"
        '
        'cboCliente
        '
        Me.cboCliente.AutoSize = False
        Me.cboCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCliente.Location = New System.Drawing.Point(125, 31)
        Me.cboCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCliente.Size = New System.Drawing.Size(462, 20)
        Me.cboCliente.TabIndex = 5
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
        'grdBoleta
        '
        Me.grdBoleta.AllowDrop = True
        Me.grdBoleta.AlternatingColors = True
        Me.grdBoleta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBoleta.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        grdBoleta_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdBoleta_DesignTimeLayout_Reference_0.Instance"), Object)
        grdBoleta_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdBoleta_DesignTimeLayout_Reference_1.Instance"), Object)
        grdBoleta_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdBoleta_DesignTimeLayout_Reference_0, grdBoleta_DesignTimeLayout_Reference_1})
        grdBoleta_DesignTimeLayout.LayoutString = resources.GetString("grdBoleta_DesignTimeLayout.LayoutString")
        Me.grdBoleta.DesignTimeLayout = grdBoleta_DesignTimeLayout
        Me.grdBoleta.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdBoleta.FocusCellFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdBoleta.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdBoleta.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdBoleta.FrozenColumns = 1
        Me.grdBoleta.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdBoleta.GroupByBoxVisible = False
        Me.grdBoleta.Location = New System.Drawing.Point(8, 76)
        Me.grdBoleta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdBoleta.Name = "grdBoleta"
        Me.grdBoleta.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdBoleta.RecordNavigator = True
        Me.grdBoleta.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
        Me.grdBoleta.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdBoleta.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdBoleta.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdBoleta.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdBoleta.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdBoleta.Size = New System.Drawing.Size(983, 357)
        Me.grdBoleta.TabIndex = 0
        Me.grdBoleta.TabStop = False
        Me.grdBoleta.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdBoleta.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdBoleta.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdBoleta.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdBoleta.VisualStyleManager = Me.vsmMain
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'frmFatEmissaoNFeImportacaoBoleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 538)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmFatEmissaoNFeImportacaoBoleta"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importação de NFe - Produto"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEntrega.ResumeLayout(False)
        Me.grpEntrega.PerformLayout()
        CType(Me.grpControleDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleDados.ResumeLayout(False)
        CType(Me.grdBoleta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControleDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnConfirmar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdBoleta As Janus.Windows.GridEX.GridEX

    Friend WithEvents btnConfigurarGridXML As System.Windows.Forms.Button
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnExcelGridXML As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridXML As System.Windows.Forms.Button
    Friend WithEvents grpEntrega As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboCliente As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumeroTicket As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents txtUFDestino As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents btnProcurarCliente As System.Windows.Forms.Button
    Friend WithEvents btnCadastrarCliente As System.Windows.Forms.Button
End Class
