<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinReceitaBoletoBancarioDLL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinReceitaBoletoBancarioDLL))
        Dim grdBoletoBancario_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExportarPDF = New Janus.Windows.EditControls.UIButton()
        Me.btnEmail = New Janus.Windows.EditControls.UIButton()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.pnlBoletoBancario = New System.Windows.Forms.Panel()
        Me.webBrowser = New System.Windows.Forms.WebBrowser()
        Me.crvViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.grpContaBancaria = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCadastrarContaBancaria = New System.Windows.Forms.Button()
        Me.txtValorTotal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.lblContaBancaria = New System.Windows.Forms.Label()
        Me.cboContaBancaria = New Janus.Windows.EditControls.UIComboBox()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNumeroDocumento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnGerarBoletoBancario = New Janus.Windows.EditControls.UIButton()
        Me.btnVisualizarBoletoBancario = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grdBoletoBancario = New Janus.Windows.GridEX.GridEX()
        Me.rptDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
        Me.pnlBoletoBancario.SuspendLayout()
        CType(Me.grpContaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpContaBancaria.SuspendLayout()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInformacoes.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grdBoletoBancario, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Location = New System.Drawing.Point(12, 12)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(966, 402)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.grpControle)
        Me.pagDados.Controls.Add(Me.pnlBoletoBancario)
        Me.pagDados.Controls.Add(Me.grpContaBancaria)
        Me.pagDados.Controls.Add(Me.grpInformacoes)
        Me.pagDados.Controls.Add(Me.grpControl2)
        Me.pagDados.Controls.Add(Me.grdBoletoBancario)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(964, 379)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Dados da Receita"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnExportarPDF)
        Me.grpControle.Controls.Add(Me.btnEmail)
        Me.grpControle.Controls.Add(Me.btnImprimir)
        Me.grpControle.Location = New System.Drawing.Point(526, 319)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(428, 51)
        Me.grpControle.TabIndex = 4
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnExportarPDF
        '
        Me.btnExportarPDF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportarPDF.Image = Global.INTERACTI.My.Resources.Resources.pdf
        Me.btnExportarPDF.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExportarPDF.Location = New System.Drawing.Point(137, 17)
        Me.btnExportarPDF.Name = "btnExportarPDF"
        Me.btnExportarPDF.Size = New System.Drawing.Size(106, 23)
        Me.btnExportarPDF.TabIndex = 2
        Me.btnExportarPDF.Text = "Exportar PDF"
        Me.btnExportarPDF.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnEmail
        '
        Me.btnEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEmail.Image = Global.INTERACTI.My.Resources.Resources.email
        Me.btnEmail.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnEmail.Location = New System.Drawing.Point(1, 17)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(130, 23)
        Me.btnEmail.TabIndex = 1
        Me.btnEmail.Text = "Enviar E-mail"
        Me.btnEmail.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(249, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(170, 23)
        Me.btnImprimir.TabIndex = 0
        Me.btnImprimir.Text = "Imprimir Boleto Bancário"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'pnlBoletoBancario
        '
        Me.pnlBoletoBancario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBoletoBancario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBoletoBancario.Controls.Add(Me.webBrowser)
        Me.pnlBoletoBancario.Controls.Add(Me.crvViewer)
        Me.pnlBoletoBancario.Location = New System.Drawing.Point(526, 9)
        Me.pnlBoletoBancario.Name = "pnlBoletoBancario"
        Me.pnlBoletoBancario.Size = New System.Drawing.Size(429, 307)
        Me.pnlBoletoBancario.TabIndex = 14
        '
        'webBrowser
        '
        Me.webBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webBrowser.Location = New System.Drawing.Point(0, 3)
        Me.webBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBrowser.Name = "webBrowser"
        Me.webBrowser.Size = New System.Drawing.Size(427, 303)
        Me.webBrowser.TabIndex = 0
        '
        'crvViewer
        '
        Me.crvViewer.ActiveViewIndex = -1
        Me.crvViewer.AutoScroll = True
        Me.crvViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvViewer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crvViewer.Location = New System.Drawing.Point(0, 0)
        Me.crvViewer.Name = "crvViewer"
        Me.crvViewer.ShowGroupTreeButton = False
        Me.crvViewer.ShowParameterPanelButton = False
        Me.crvViewer.Size = New System.Drawing.Size(427, 305)
        Me.crvViewer.TabIndex = 1
        Me.crvViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'grpContaBancaria
        '
        Me.grpContaBancaria.BackColor = System.Drawing.Color.Transparent
        Me.grpContaBancaria.Controls.Add(Me.btnCadastrarContaBancaria)
        Me.grpContaBancaria.Controls.Add(Me.txtValorTotal)
        Me.grpContaBancaria.Controls.Add(Me.lblValorTotal)
        Me.grpContaBancaria.Controls.Add(Me.lblContaBancaria)
        Me.grpContaBancaria.Controls.Add(Me.cboContaBancaria)
        Me.grpContaBancaria.Location = New System.Drawing.Point(8, 70)
        Me.grpContaBancaria.Name = "grpContaBancaria"
        Me.grpContaBancaria.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpContaBancaria.Size = New System.Drawing.Size(509, 63)
        Me.grpContaBancaria.TabIndex = 1
        Me.grpContaBancaria.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrarContaBancaria
        '
        Me.btnCadastrarContaBancaria.FlatAppearance.BorderSize = 0
        Me.btnCadastrarContaBancaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarContaBancaria.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarContaBancaria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarContaBancaria.Location = New System.Drawing.Point(116, 18)
        Me.btnCadastrarContaBancaria.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarContaBancaria.Name = "btnCadastrarContaBancaria"
        Me.btnCadastrarContaBancaria.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarContaBancaria.TabIndex = 8
        Me.btnCadastrarContaBancaria.TabStop = False
        Me.btnCadastrarContaBancaria.UseVisualStyleBackColor = True
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtValorTotal.Location = New System.Drawing.Point(9, 34)
        Me.txtValorTotal.MaxLength = 20
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(101, 20)
        Me.txtValorTotal.TabIndex = 7
        Me.txtValorTotal.TabStop = False
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.Location = New System.Drawing.Point(6, 17)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(60, 14)
        Me.lblValorTotal.TabIndex = 6
        Me.lblValorTotal.Text = "Valor Total:"
        '
        'lblContaBancaria
        '
        Me.lblContaBancaria.AutoSize = True
        Me.lblContaBancaria.Location = New System.Drawing.Point(132, 17)
        Me.lblContaBancaria.Name = "lblContaBancaria"
        Me.lblContaBancaria.Size = New System.Drawing.Size(84, 14)
        Me.lblContaBancaria.TabIndex = 4
        Me.lblContaBancaria.Text = "Conta Bancária:"
        '
        'cboContaBancaria
        '
        Me.cboContaBancaria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboContaBancaria.AutoSize = False
        Me.cboContaBancaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboContaBancaria.Location = New System.Drawing.Point(116, 34)
        Me.cboContaBancaria.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboContaBancaria.Name = "cboContaBancaria"
        Me.cboContaBancaria.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboContaBancaria.Size = New System.Drawing.Size(384, 20)
        Me.cboContaBancaria.TabIndex = 5
        '
        'grpInformacoes
        '
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.txtCliente)
        Me.grpInformacoes.Controls.Add(Me.txtNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.lblNumeroDocumento)
        Me.grpInformacoes.Controls.Add(Me.lblCliente)
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 3)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(509, 64)
        Me.grpInformacoes.TabIndex = 0
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCliente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCliente.Location = New System.Drawing.Point(116, 34)
        Me.txtCliente.MaxLength = 20
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(384, 20)
        Me.txtCliente.TabIndex = 3
        Me.txtCliente.TabStop = False
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumeroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroDocumento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroDocumento.MaxLength = 20
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.ReadOnly = True
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(101, 20)
        Me.txtNumeroDocumento.TabIndex = 1
        Me.txtNumeroDocumento.TabStop = False
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(79, 14)
        Me.lblNumeroDocumento.TabIndex = 0
        Me.lblNumeroDocumento.Text = "Nº Documento:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(113, 17)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 2
        Me.lblCliente.Text = "Cliente:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnGerarBoletoBancario)
        Me.grpControl2.Controls.Add(Me.btnVisualizarBoletoBancario)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 319)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(509, 51)
        Me.grpControl2.TabIndex = 3
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnGerarBoletoBancario
        '
        Me.btnGerarBoletoBancario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGerarBoletoBancario.Image = Global.INTERACTI.My.Resources.Resources.barcode
        Me.btnGerarBoletoBancario.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnGerarBoletoBancario.Location = New System.Drawing.Point(57, 17)
        Me.btnGerarBoletoBancario.Name = "btnGerarBoletoBancario"
        Me.btnGerarBoletoBancario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnGerarBoletoBancario.Size = New System.Drawing.Size(170, 23)
        Me.btnGerarBoletoBancario.TabIndex = 0
        Me.btnGerarBoletoBancario.Text = "Gerar Boleto Bancário"
        Me.btnGerarBoletoBancario.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnVisualizarBoletoBancario
        '
        Me.btnVisualizarBoletoBancario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizarBoletoBancario.Image = Global.INTERACTI.My.Resources.Resources.preview
        Me.btnVisualizarBoletoBancario.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVisualizarBoletoBancario.Location = New System.Drawing.Point(233, 17)
        Me.btnVisualizarBoletoBancario.Name = "btnVisualizarBoletoBancario"
        Me.btnVisualizarBoletoBancario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVisualizarBoletoBancario.Size = New System.Drawing.Size(170, 23)
        Me.btnVisualizarBoletoBancario.TabIndex = 1
        Me.btnVisualizarBoletoBancario.Text = "Visualizar Boleto Bancário"
        Me.btnVisualizarBoletoBancario.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(409, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdBoletoBancario
        '
        Me.grdBoletoBancario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdBoletoBancario.AutoEdit = True
        grdBoletoBancario_DesignTimeLayout.LayoutString = resources.GetString("grdBoletoBancario_DesignTimeLayout.LayoutString")
        Me.grdBoletoBancario.DesignTimeLayout = grdBoletoBancario_DesignTimeLayout
        Me.grdBoletoBancario.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdBoletoBancario.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdBoletoBancario.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdBoletoBancario.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdBoletoBancario.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdBoletoBancario.GroupByBoxVisible = False
        Me.grdBoletoBancario.Location = New System.Drawing.Point(8, 142)
        Me.grdBoletoBancario.Name = "grdBoletoBancario"
        Me.grdBoletoBancario.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdBoletoBancario.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdBoletoBancario.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdBoletoBancario.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdBoletoBancario.Size = New System.Drawing.Size(509, 174)
        Me.grdBoletoBancario.TabIndex = 2
        Me.grdBoletoBancario.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdBoletoBancario.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdBoletoBancario.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdBoletoBancario.VisualStyleManager = Me.vsmMain
        '
        'frmFinReceitaBoletoBancarioDLL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(986, 422)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinReceitaBoletoBancarioDLL"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Financeiro - Receita - Gerar Boleto Bancário"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.pnlBoletoBancario.ResumeLayout(False)
        CType(Me.grpContaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpContaBancaria.ResumeLayout(False)
        Me.grpContaBancaria.PerformLayout()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInformacoes.ResumeLayout(False)
        Me.grpInformacoes.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grdBoletoBancario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnVisualizarBoletoBancario As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNumeroDocumento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents grpContaBancaria As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdBoletoBancario As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblContaBancaria As System.Windows.Forms.Label
    Friend WithEvents cboContaBancaria As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtValorTotal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents btnCadastrarContaBancaria As System.Windows.Forms.Button
    Friend WithEvents pnlBoletoBancario As System.Windows.Forms.Panel
    Public WithEvents webBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnGerarBoletoBancario As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExportarPDF As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnEmail As Janus.Windows.EditControls.UIButton
    Private WithEvents crvViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
End Class
