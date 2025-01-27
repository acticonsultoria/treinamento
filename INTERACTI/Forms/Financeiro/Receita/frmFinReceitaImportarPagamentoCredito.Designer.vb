<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinReceitaImportarPagamentoCredito
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
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinReceitaImportarPagamentoCredito))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picTituloQuitado = New System.Windows.Forms.PictureBox()
        Me.lblTituloQuitado = New System.Windows.Forms.Label()
        Me.picTituloParcialmenteQuitado = New System.Windows.Forms.PictureBox()
        Me.lblTituloParcialmenteQuitado = New System.Windows.Forms.Label()
        Me.btnExcelGridXML = New System.Windows.Forms.Button()
        Me.btnAgruparGridXML = New System.Windows.Forms.Button()
        Me.btnConfigurarGridXML = New System.Windows.Forms.Button()
        Me.grpControleDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnConfirmar = New Janus.Windows.EditControls.UIButton()
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picTituloQuitado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTituloParcialmenteQuitado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControleDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleDados.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(1114, 523)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpLegenda)
        Me.pagDados.Controls.Add(Me.btnExcelGridXML)
        Me.pagDados.Controls.Add(Me.btnAgruparGridXML)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridXML)
        Me.pagDados.Controls.Add(Me.grpControleDados)
        Me.pagDados.Controls.Add(Me.grdListagem)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(1112, 500)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Financeiro"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.picTituloQuitado)
        Me.grpLegenda.Controls.Add(Me.lblTituloQuitado)
        Me.grpLegenda.Controls.Add(Me.picTituloParcialmenteQuitado)
        Me.grpLegenda.Controls.Add(Me.lblTituloParcialmenteQuitado)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(9, 440)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(188, 51)
        Me.grpLegenda.TabIndex = 10
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picTituloQuitado
        '
        Me.picTituloQuitado.BackColor = System.Drawing.Color.ForestGreen
        Me.picTituloQuitado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTituloQuitado.Location = New System.Drawing.Point(9, 22)
        Me.picTituloQuitado.Name = "picTituloQuitado"
        Me.picTituloQuitado.Size = New System.Drawing.Size(13, 14)
        Me.picTituloQuitado.TabIndex = 12
        Me.picTituloQuitado.TabStop = False
        '
        'lblTituloQuitado
        '
        Me.lblTituloQuitado.AutoSize = True
        Me.lblTituloQuitado.Location = New System.Drawing.Point(28, 22)
        Me.lblTituloQuitado.Name = "lblTituloQuitado"
        Me.lblTituloQuitado.Size = New System.Drawing.Size(44, 14)
        Me.lblTituloQuitado.TabIndex = 2
        Me.lblTituloQuitado.Text = "Quitado"
        '
        'picTituloParcialmenteQuitado
        '
        Me.picTituloParcialmenteQuitado.BackColor = System.Drawing.Color.SteelBlue
        Me.picTituloParcialmenteQuitado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTituloParcialmenteQuitado.Location = New System.Drawing.Point(82, 22)
        Me.picTituloParcialmenteQuitado.Name = "picTituloParcialmenteQuitado"
        Me.picTituloParcialmenteQuitado.Size = New System.Drawing.Size(13, 14)
        Me.picTituloParcialmenteQuitado.TabIndex = 16
        Me.picTituloParcialmenteQuitado.TabStop = False
        '
        'lblTituloParcialmenteQuitado
        '
        Me.lblTituloParcialmenteQuitado.AutoSize = True
        Me.lblTituloParcialmenteQuitado.Location = New System.Drawing.Point(101, 22)
        Me.lblTituloParcialmenteQuitado.Name = "lblTituloParcialmenteQuitado"
        Me.lblTituloParcialmenteQuitado.Size = New System.Drawing.Size(72, 14)
        Me.lblTituloParcialmenteQuitado.TabIndex = 1
        Me.lblTituloParcialmenteQuitado.Text = "Parc. Quitado"
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
        Me.grpControleDados.Location = New System.Drawing.Point(203, 440)
        Me.grpControleDados.Name = "grpControleDados"
        Me.grpControleDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControleDados.Size = New System.Drawing.Size(901, 51)
        Me.grpControleDados.TabIndex = 9
        Me.grpControleDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControleDados.VisualStyleManager = Me.vsmMain
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmar.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnConfirmar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnConfirmar.Location = New System.Drawing.Point(671, 17)
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
        Me.btnCancelar.Location = New System.Drawing.Point(783, 17)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnCancelar.Size = New System.Drawing.Size(109, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdListagem
        '
        Me.grdListagem.AllowDrop = True
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FocusCellFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 1
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(8, 15)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowCheckStateBehavior = Janus.Windows.GridEX.RowCheckStateBehavior.CheckStateDependsOnChild
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdListagem.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdListagem.Size = New System.Drawing.Size(1096, 418)
        Me.grdListagem.TabIndex = 0
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 0
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'frmFinReceitaImportarPagamentoCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 538)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmFinReceitaImportarPagamentoCredito"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importação Pagamento - Crédito"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picTituloQuitado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTituloParcialmenteQuitado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControleDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleDados.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControleDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnConfirmar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX

    Friend WithEvents btnConfigurarGridXML As System.Windows.Forms.Button
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnExcelGridXML As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridXML As System.Windows.Forms.Button
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picTituloQuitado As System.Windows.Forms.PictureBox
    Friend WithEvents lblTituloQuitado As System.Windows.Forms.Label
    Friend WithEvents picTituloParcialmenteQuitado As System.Windows.Forms.PictureBox
    Friend WithEvents lblTituloParcialmenteQuitado As System.Windows.Forms.Label
End Class
