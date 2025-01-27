<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrVenImportarOrcamentoGRV
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrVenImportarOrcamentoGRV))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtValorGRV = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblValorGRV = New System.Windows.Forms.Label()
        Me.lblStatusINTERACTI = New System.Windows.Forms.Label()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.cboRevisao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblRevisao = New System.Windows.Forms.Label()
        Me.txtNumeroOrcamento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrcamentoGRV = New System.Windows.Forms.Label()
        Me.btnImportar = New Janus.Windows.EditControls.UIButton()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
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
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(593, 151)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpFiltro)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagListagem"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(591, 128)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Importar Orçamento do GRV"
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.txtValorGRV)
        Me.grpFiltro.Controls.Add(Me.lblValorGRV)
        Me.grpFiltro.Controls.Add(Me.lblStatusINTERACTI)
        Me.grpFiltro.Controls.Add(Me.btnSair)
        Me.grpFiltro.Controls.Add(Me.cboRevisao)
        Me.grpFiltro.Controls.Add(Me.lblRevisao)
        Me.grpFiltro.Controls.Add(Me.txtNumeroOrcamento)
        Me.grpFiltro.Controls.Add(Me.lblOrcamentoGRV)
        Me.grpFiltro.Controls.Add(Me.btnImportar)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(573, 111)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.Text = "Filtro"
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'txtValorGRV
        '
        Me.txtValorGRV.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorGRV.DecimalDigits = 2
        Me.txtValorGRV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorGRV.Location = New System.Drawing.Point(222, 35)
        Me.txtValorGRV.Name = "txtValorGRV"
        Me.txtValorGRV.Size = New System.Drawing.Size(115, 20)
        Me.txtValorGRV.TabIndex = 5
        Me.txtValorGRV.TabStop = False
        Me.txtValorGRV.Text = "0,00"
        Me.txtValorGRV.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblValorGRV
        '
        Me.lblValorGRV.AutoSize = True
        Me.lblValorGRV.Location = New System.Drawing.Point(219, 18)
        Me.lblValorGRV.Name = "lblValorGRV"
        Me.lblValorGRV.Size = New System.Drawing.Size(61, 14)
        Me.lblValorGRV.TabIndex = 4
        Me.lblValorGRV.Text = "Valor GRV:"
        '
        'lblStatusINTERACTI
        '
        Me.lblStatusINTERACTI.AutoSize = True
        Me.lblStatusINTERACTI.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.lblStatusINTERACTI.Location = New System.Drawing.Point(6, 71)
        Me.lblStatusINTERACTI.Name = "lblStatusINTERACTI"
        Me.lblStatusINTERACTI.Size = New System.Drawing.Size(192, 25)
        Me.lblStatusINTERACTI.TabIndex = 11
        Me.lblStatusINTERACTI.Text = "AAAAAAAAAAAA"
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(459, 31)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 7
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboRevisao
        '
        Me.cboRevisao.AutoSize = False
        Me.cboRevisao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboRevisao.Location = New System.Drawing.Point(126, 35)
        Me.cboRevisao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboRevisao.Name = "cboRevisao"
        Me.cboRevisao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboRevisao.Size = New System.Drawing.Size(90, 20)
        Me.cboRevisao.TabIndex = 3
        '
        'lblRevisao
        '
        Me.lblRevisao.AutoSize = True
        Me.lblRevisao.Location = New System.Drawing.Point(123, 18)
        Me.lblRevisao.Name = "lblRevisao"
        Me.lblRevisao.Size = New System.Drawing.Size(49, 14)
        Me.lblRevisao.TabIndex = 2
        Me.lblRevisao.Text = "Revisão:"
        '
        'txtNumeroOrcamento
        '
        Me.txtNumeroOrcamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOrcamento.Location = New System.Drawing.Point(9, 35)
        Me.txtNumeroOrcamento.MaxLength = 20
        Me.txtNumeroOrcamento.Name = "txtNumeroOrcamento"
        Me.txtNumeroOrcamento.Size = New System.Drawing.Size(111, 20)
        Me.txtNumeroOrcamento.TabIndex = 1
        '
        'lblOrcamentoGRV
        '
        Me.lblOrcamentoGRV.AutoSize = True
        Me.lblOrcamentoGRV.Location = New System.Drawing.Point(6, 20)
        Me.lblOrcamentoGRV.Name = "lblOrcamentoGRV"
        Me.lblOrcamentoGRV.Size = New System.Drawing.Size(89, 14)
        Me.lblOrcamentoGRV.TabIndex = 0
        Me.lblOrcamentoGRV.Text = "Orçamento GRV:"
        '
        'btnImportar
        '
        Me.btnImportar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnImportar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportar.Location = New System.Drawing.Point(361, 32)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportar.Size = New System.Drawing.Size(91, 23)
        Me.btnImportar.TabIndex = 6
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Key = "pagDadosCliente"
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 22)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(980, 378)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Visible = False
        '
        'usrVenImportarOrcamentoGRV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "usrVenImportarOrcamentoGRV"
        Me.Size = New System.Drawing.Size(593, 151)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnImportar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents lblOrcamentoGRV As System.Windows.Forms.Label
    Friend WithEvents txtNumeroOrcamento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblStatusINTERACTI As System.Windows.Forms.Label
    Friend WithEvents cboRevisao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblRevisao As System.Windows.Forms.Label
    Friend WithEvents txtValorGRV As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblValorGRV As System.Windows.Forms.Label

End Class
