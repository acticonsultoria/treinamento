<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenProdutoPrecoVenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenProdutoPrecoVenda))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpCustoMedido = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnPrecoMedio = New Janus.Windows.EditControls.UIButton()
        Me.lblPrecoUnidadeMedio = New System.Windows.Forms.Label()
        Me.txtPrecoUnidadeMedio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPrecoVendaMedio = New System.Windows.Forms.Label()
        Me.txtPrecoVendaMedio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMarkupMedio = New System.Windows.Forms.Label()
        Me.txtMarkupMedio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblGPMedio = New System.Windows.Forms.Label()
        Me.txtGPMedio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMargemMedio = New System.Windows.Forms.Label()
        Me.lblCustoMedio = New System.Windows.Forms.Label()
        Me.txtMargemMedio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtCustoMedio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.grpCustoTeorico = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnPrecoTeorico = New Janus.Windows.EditControls.UIButton()
        Me.lblPrecoUnidadeTeorico = New System.Windows.Forms.Label()
        Me.txtPrecoUnidadeTeorico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPrecoVendaTeorico = New System.Windows.Forms.Label()
        Me.txtPrecoVendaTeorico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMarkupTeorico = New System.Windows.Forms.Label()
        Me.txtMarkupTeorico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblGPTeorico = New System.Windows.Forms.Label()
        Me.txtGPTeorico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMargemTeorico = New System.Windows.Forms.Label()
        Me.lblCustoTeorico = New System.Windows.Forms.Label()
        Me.txtMargemTeorico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtCustoTeorico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.grpInformacoes = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtAtrasaPagamentos = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblAtrasaPagamentos = New System.Windows.Forms.Label()
        Me.txtComprouSimilares = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblComprouSimilares = New System.Windows.Forms.Label()
        Me.txtValorUltimaVenda = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtDataUltimaVenda = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataUltimaVenda = New System.Windows.Forms.Label()
        Me.lblValorUltimaVenda = New System.Windows.Forms.Label()
        Me.txtRecomendacaoVenda = New Janus.Windows.GridEX.EditControls.EditBox()
        Me.lblRecomendacaoVenda = New System.Windows.Forms.Label()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpMotivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblQuantidadeUnidade = New System.Windows.Forms.Label()
        Me.txtQuantidadeUnidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtMarca = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpCustoMedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCustoMedido.SuspendLayout()
        CType(Me.grpCustoTeorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCustoTeorico.SuspendLayout()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInformacoes.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMotivo.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(795, 444)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpCustoMedido)
        Me.pagTabela.Controls.Add(Me.grpCustoTeorico)
        Me.pagTabela.Controls.Add(Me.grpInformacoes)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Controls.Add(Me.grpMotivo)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(793, 421)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Definir Preço de Venda"
        '
        'grpCustoMedido
        '
        Me.grpCustoMedido.BackColor = System.Drawing.Color.Transparent
        Me.grpCustoMedido.Controls.Add(Me.btnPrecoMedio)
        Me.grpCustoMedido.Controls.Add(Me.lblPrecoUnidadeMedio)
        Me.grpCustoMedido.Controls.Add(Me.txtPrecoUnidadeMedio)
        Me.grpCustoMedido.Controls.Add(Me.lblPrecoVendaMedio)
        Me.grpCustoMedido.Controls.Add(Me.txtPrecoVendaMedio)
        Me.grpCustoMedido.Controls.Add(Me.lblMarkupMedio)
        Me.grpCustoMedido.Controls.Add(Me.txtMarkupMedio)
        Me.grpCustoMedido.Controls.Add(Me.lblGPMedio)
        Me.grpCustoMedido.Controls.Add(Me.txtGPMedio)
        Me.grpCustoMedido.Controls.Add(Me.lblMargemMedio)
        Me.grpCustoMedido.Controls.Add(Me.lblCustoMedio)
        Me.grpCustoMedido.Controls.Add(Me.txtMargemMedio)
        Me.grpCustoMedido.Controls.Add(Me.txtCustoMedio)
        Me.grpCustoMedido.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpCustoMedido.Location = New System.Drawing.Point(409, 70)
        Me.grpCustoMedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpCustoMedido.Name = "grpCustoMedido"
        Me.grpCustoMedido.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCustoMedido.Size = New System.Drawing.Size(376, 144)
        Me.grpCustoMedido.TabIndex = 2
        Me.grpCustoMedido.Text = "Preço de Venda - Custo Médio"
        Me.grpCustoMedido.VisualStyleManager = Me.vsmMain
        '
        'btnPrecoMedio
        '
        Me.btnPrecoMedio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrecoMedio.Image = Global.INTERACTI.My.Resources.aprovar
        Me.btnPrecoMedio.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.btnPrecoMedio.Location = New System.Drawing.Point(342, 54)
        Me.btnPrecoMedio.Name = "btnPrecoMedio"
        Me.btnPrecoMedio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPrecoMedio.Size = New System.Drawing.Size(25, 60)
        Me.btnPrecoMedio.TabIndex = 12
        Me.btnPrecoMedio.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblPrecoUnidadeMedio
        '
        Me.lblPrecoUnidadeMedio.AutoSize = True
        Me.lblPrecoUnidadeMedio.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecoUnidadeMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrecoUnidadeMedio.Location = New System.Drawing.Point(241, 77)
        Me.lblPrecoUnidadeMedio.Name = "lblPrecoUnidadeMedio"
        Me.lblPrecoUnidadeMedio.Size = New System.Drawing.Size(69, 14)
        Me.lblPrecoUnidadeMedio.TabIndex = 10
        Me.lblPrecoUnidadeMedio.Text = "Preço Und.:"
        '
        'txtPrecoUnidadeMedio
        '
        Me.txtPrecoUnidadeMedio.BackColor = System.Drawing.SystemColors.Info
        Me.txtPrecoUnidadeMedio.DecimalDigits = 2
        Me.txtPrecoUnidadeMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtPrecoUnidadeMedio.Location = New System.Drawing.Point(244, 94)
        Me.txtPrecoUnidadeMedio.Name = "txtPrecoUnidadeMedio"
        Me.txtPrecoUnidadeMedio.Size = New System.Drawing.Size(99, 20)
        Me.txtPrecoUnidadeMedio.TabIndex = 11
        Me.txtPrecoUnidadeMedio.TabStop = False
        Me.txtPrecoUnidadeMedio.Text = "0,00"
        Me.txtPrecoUnidadeMedio.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPrecoVendaMedio
        '
        Me.lblPrecoVendaMedio.AutoSize = True
        Me.lblPrecoVendaMedio.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecoVendaMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrecoVendaMedio.Location = New System.Drawing.Point(241, 37)
        Me.lblPrecoVendaMedio.Name = "lblPrecoVendaMedio"
        Me.lblPrecoVendaMedio.Size = New System.Drawing.Size(79, 14)
        Me.lblPrecoVendaMedio.TabIndex = 8
        Me.lblPrecoVendaMedio.Text = "Preço Venda:"
        '
        'txtPrecoVendaMedio
        '
        Me.txtPrecoVendaMedio.BackColor = System.Drawing.SystemColors.Info
        Me.txtPrecoVendaMedio.DecimalDigits = 2
        Me.txtPrecoVendaMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecoVendaMedio.Location = New System.Drawing.Point(244, 54)
        Me.txtPrecoVendaMedio.Name = "txtPrecoVendaMedio"
        Me.txtPrecoVendaMedio.Size = New System.Drawing.Size(99, 20)
        Me.txtPrecoVendaMedio.TabIndex = 9
        Me.txtPrecoVendaMedio.Text = "0,00"
        Me.txtPrecoVendaMedio.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMarkupMedio
        '
        Me.lblMarkupMedio.AutoSize = True
        Me.lblMarkupMedio.BackColor = System.Drawing.Color.Transparent
        Me.lblMarkupMedio.Location = New System.Drawing.Point(135, 97)
        Me.lblMarkupMedio.Name = "lblMarkupMedio"
        Me.lblMarkupMedio.Size = New System.Drawing.Size(45, 14)
        Me.lblMarkupMedio.TabIndex = 6
        Me.lblMarkupMedio.Text = "Markup:"
        '
        'txtMarkupMedio
        '
        Me.txtMarkupMedio.DecimalDigits = 2
        Me.txtMarkupMedio.Location = New System.Drawing.Point(138, 114)
        Me.txtMarkupMedio.Name = "txtMarkupMedio"
        Me.txtMarkupMedio.Size = New System.Drawing.Size(100, 20)
        Me.txtMarkupMedio.TabIndex = 7
        Me.txtMarkupMedio.Text = "0,00"
        Me.txtMarkupMedio.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblGPMedio
        '
        Me.lblGPMedio.AutoSize = True
        Me.lblGPMedio.BackColor = System.Drawing.Color.Transparent
        Me.lblGPMedio.Location = New System.Drawing.Point(135, 57)
        Me.lblGPMedio.Name = "lblGPMedio"
        Me.lblGPMedio.Size = New System.Drawing.Size(24, 14)
        Me.lblGPMedio.TabIndex = 4
        Me.lblGPMedio.Text = "GP:"
        '
        'txtGPMedio
        '
        Me.txtGPMedio.DecimalDigits = 2
        Me.txtGPMedio.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtGPMedio.Location = New System.Drawing.Point(138, 74)
        Me.txtGPMedio.Name = "txtGPMedio"
        Me.txtGPMedio.Size = New System.Drawing.Size(100, 20)
        Me.txtGPMedio.TabIndex = 5
        Me.txtGPMedio.Text = "0,00%"
        Me.txtGPMedio.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMargemMedio
        '
        Me.lblMargemMedio.AutoSize = True
        Me.lblMargemMedio.BackColor = System.Drawing.Color.Transparent
        Me.lblMargemMedio.Location = New System.Drawing.Point(135, 17)
        Me.lblMargemMedio.Name = "lblMargemMedio"
        Me.lblMargemMedio.Size = New System.Drawing.Size(48, 14)
        Me.lblMargemMedio.TabIndex = 2
        Me.lblMargemMedio.Text = "Margem:"
        '
        'lblCustoMedio
        '
        Me.lblCustoMedio.AutoSize = True
        Me.lblCustoMedio.BackColor = System.Drawing.Color.Transparent
        Me.lblCustoMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCustoMedio.Location = New System.Drawing.Point(6, 57)
        Me.lblCustoMedio.Name = "lblCustoMedio"
        Me.lblCustoMedio.Size = New System.Drawing.Size(80, 14)
        Me.lblCustoMedio.TabIndex = 0
        Me.lblCustoMedio.Text = "Custo Médio:"
        '
        'txtMargemMedio
        '
        Me.txtMargemMedio.DecimalDigits = 2
        Me.txtMargemMedio.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtMargemMedio.Location = New System.Drawing.Point(138, 34)
        Me.txtMargemMedio.Name = "txtMargemMedio"
        Me.txtMargemMedio.Size = New System.Drawing.Size(100, 20)
        Me.txtMargemMedio.TabIndex = 3
        Me.txtMargemMedio.Text = "0,00%"
        Me.txtMargemMedio.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtCustoMedio
        '
        Me.txtCustoMedio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCustoMedio.DecimalDigits = 2
        Me.txtCustoMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCustoMedio.Location = New System.Drawing.Point(9, 74)
        Me.txtCustoMedio.Name = "txtCustoMedio"
        Me.txtCustoMedio.Size = New System.Drawing.Size(123, 20)
        Me.txtCustoMedio.TabIndex = 1
        Me.txtCustoMedio.Text = "0,00"
        Me.txtCustoMedio.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'grpCustoTeorico
        '
        Me.grpCustoTeorico.BackColor = System.Drawing.Color.Transparent
        Me.grpCustoTeorico.Controls.Add(Me.btnPrecoTeorico)
        Me.grpCustoTeorico.Controls.Add(Me.lblPrecoUnidadeTeorico)
        Me.grpCustoTeorico.Controls.Add(Me.txtPrecoUnidadeTeorico)
        Me.grpCustoTeorico.Controls.Add(Me.lblPrecoVendaTeorico)
        Me.grpCustoTeorico.Controls.Add(Me.txtPrecoVendaTeorico)
        Me.grpCustoTeorico.Controls.Add(Me.lblMarkupTeorico)
        Me.grpCustoTeorico.Controls.Add(Me.txtMarkupTeorico)
        Me.grpCustoTeorico.Controls.Add(Me.lblGPTeorico)
        Me.grpCustoTeorico.Controls.Add(Me.txtGPTeorico)
        Me.grpCustoTeorico.Controls.Add(Me.lblMargemTeorico)
        Me.grpCustoTeorico.Controls.Add(Me.lblCustoTeorico)
        Me.grpCustoTeorico.Controls.Add(Me.txtMargemTeorico)
        Me.grpCustoTeorico.Controls.Add(Me.txtCustoTeorico)
        Me.grpCustoTeorico.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpCustoTeorico.Location = New System.Drawing.Point(8, 70)
        Me.grpCustoTeorico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpCustoTeorico.Name = "grpCustoTeorico"
        Me.grpCustoTeorico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpCustoTeorico.Size = New System.Drawing.Size(376, 144)
        Me.grpCustoTeorico.TabIndex = 1
        Me.grpCustoTeorico.Text = "Preço de Venda - Custo Teórico"
        Me.grpCustoTeorico.VisualStyleManager = Me.vsmMain
        '
        'btnPrecoTeorico
        '
        Me.btnPrecoTeorico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrecoTeorico.Image = Global.INTERACTI.My.Resources.aprovar
        Me.btnPrecoTeorico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.btnPrecoTeorico.Location = New System.Drawing.Point(342, 54)
        Me.btnPrecoTeorico.Name = "btnPrecoTeorico"
        Me.btnPrecoTeorico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnPrecoTeorico.Size = New System.Drawing.Size(25, 60)
        Me.btnPrecoTeorico.TabIndex = 12
        Me.btnPrecoTeorico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblPrecoUnidadeTeorico
        '
        Me.lblPrecoUnidadeTeorico.AutoSize = True
        Me.lblPrecoUnidadeTeorico.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecoUnidadeTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrecoUnidadeTeorico.Location = New System.Drawing.Point(241, 77)
        Me.lblPrecoUnidadeTeorico.Name = "lblPrecoUnidadeTeorico"
        Me.lblPrecoUnidadeTeorico.Size = New System.Drawing.Size(69, 14)
        Me.lblPrecoUnidadeTeorico.TabIndex = 10
        Me.lblPrecoUnidadeTeorico.Text = "Preço Und.:"
        '
        'txtPrecoUnidadeTeorico
        '
        Me.txtPrecoUnidadeTeorico.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrecoUnidadeTeorico.DecimalDigits = 2
        Me.txtPrecoUnidadeTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtPrecoUnidadeTeorico.Location = New System.Drawing.Point(244, 94)
        Me.txtPrecoUnidadeTeorico.Name = "txtPrecoUnidadeTeorico"
        Me.txtPrecoUnidadeTeorico.Size = New System.Drawing.Size(99, 20)
        Me.txtPrecoUnidadeTeorico.TabIndex = 11
        Me.txtPrecoUnidadeTeorico.TabStop = False
        Me.txtPrecoUnidadeTeorico.Text = "0,00"
        Me.txtPrecoUnidadeTeorico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPrecoVendaTeorico
        '
        Me.lblPrecoVendaTeorico.AutoSize = True
        Me.lblPrecoVendaTeorico.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecoVendaTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrecoVendaTeorico.Location = New System.Drawing.Point(241, 37)
        Me.lblPrecoVendaTeorico.Name = "lblPrecoVendaTeorico"
        Me.lblPrecoVendaTeorico.Size = New System.Drawing.Size(79, 14)
        Me.lblPrecoVendaTeorico.TabIndex = 8
        Me.lblPrecoVendaTeorico.Text = "Preço Venda:"
        '
        'txtPrecoVendaTeorico
        '
        Me.txtPrecoVendaTeorico.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrecoVendaTeorico.DecimalDigits = 2
        Me.txtPrecoVendaTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtPrecoVendaTeorico.Location = New System.Drawing.Point(244, 54)
        Me.txtPrecoVendaTeorico.Name = "txtPrecoVendaTeorico"
        Me.txtPrecoVendaTeorico.Size = New System.Drawing.Size(99, 20)
        Me.txtPrecoVendaTeorico.TabIndex = 9
        Me.txtPrecoVendaTeorico.Text = "0,00"
        Me.txtPrecoVendaTeorico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMarkupTeorico
        '
        Me.lblMarkupTeorico.AutoSize = True
        Me.lblMarkupTeorico.BackColor = System.Drawing.Color.Transparent
        Me.lblMarkupTeorico.Location = New System.Drawing.Point(135, 97)
        Me.lblMarkupTeorico.Name = "lblMarkupTeorico"
        Me.lblMarkupTeorico.Size = New System.Drawing.Size(45, 14)
        Me.lblMarkupTeorico.TabIndex = 6
        Me.lblMarkupTeorico.Text = "Markup:"
        '
        'txtMarkupTeorico
        '
        Me.txtMarkupTeorico.DecimalDigits = 2
        Me.txtMarkupTeorico.Location = New System.Drawing.Point(138, 114)
        Me.txtMarkupTeorico.Name = "txtMarkupTeorico"
        Me.txtMarkupTeorico.Size = New System.Drawing.Size(100, 20)
        Me.txtMarkupTeorico.TabIndex = 7
        Me.txtMarkupTeorico.Text = "0,00"
        Me.txtMarkupTeorico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblGPTeorico
        '
        Me.lblGPTeorico.AutoSize = True
        Me.lblGPTeorico.BackColor = System.Drawing.Color.Transparent
        Me.lblGPTeorico.Location = New System.Drawing.Point(135, 57)
        Me.lblGPTeorico.Name = "lblGPTeorico"
        Me.lblGPTeorico.Size = New System.Drawing.Size(24, 14)
        Me.lblGPTeorico.TabIndex = 4
        Me.lblGPTeorico.Text = "GP:"
        '
        'txtGPTeorico
        '
        Me.txtGPTeorico.DecimalDigits = 2
        Me.txtGPTeorico.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtGPTeorico.Location = New System.Drawing.Point(138, 74)
        Me.txtGPTeorico.Name = "txtGPTeorico"
        Me.txtGPTeorico.Size = New System.Drawing.Size(100, 20)
        Me.txtGPTeorico.TabIndex = 5
        Me.txtGPTeorico.Text = "0,00%"
        Me.txtGPTeorico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMargemTeorico
        '
        Me.lblMargemTeorico.AutoSize = True
        Me.lblMargemTeorico.BackColor = System.Drawing.Color.Transparent
        Me.lblMargemTeorico.Location = New System.Drawing.Point(135, 17)
        Me.lblMargemTeorico.Name = "lblMargemTeorico"
        Me.lblMargemTeorico.Size = New System.Drawing.Size(48, 14)
        Me.lblMargemTeorico.TabIndex = 2
        Me.lblMargemTeorico.Text = "Margem:"
        '
        'lblCustoTeorico
        '
        Me.lblCustoTeorico.AutoSize = True
        Me.lblCustoTeorico.BackColor = System.Drawing.Color.Transparent
        Me.lblCustoTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCustoTeorico.Location = New System.Drawing.Point(6, 57)
        Me.lblCustoTeorico.Name = "lblCustoTeorico"
        Me.lblCustoTeorico.Size = New System.Drawing.Size(87, 14)
        Me.lblCustoTeorico.TabIndex = 0
        Me.lblCustoTeorico.Text = "Custo Teórico:"
        '
        'txtMargemTeorico
        '
        Me.txtMargemTeorico.DecimalDigits = 2
        Me.txtMargemTeorico.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtMargemTeorico.Location = New System.Drawing.Point(138, 34)
        Me.txtMargemTeorico.Name = "txtMargemTeorico"
        Me.txtMargemTeorico.Size = New System.Drawing.Size(100, 20)
        Me.txtMargemTeorico.TabIndex = 3
        Me.txtMargemTeorico.Text = "0,00%"
        Me.txtMargemTeorico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtCustoTeorico
        '
        Me.txtCustoTeorico.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCustoTeorico.DecimalDigits = 2
        Me.txtCustoTeorico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCustoTeorico.Location = New System.Drawing.Point(9, 74)
        Me.txtCustoTeorico.Name = "txtCustoTeorico"
        Me.txtCustoTeorico.Size = New System.Drawing.Size(123, 20)
        Me.txtCustoTeorico.TabIndex = 1
        Me.txtCustoTeorico.Text = "0,00"
        Me.txtCustoTeorico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'grpInformacoes
        '
        Me.grpInformacoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInformacoes.BackColor = System.Drawing.Color.Transparent
        Me.grpInformacoes.Controls.Add(Me.txtAtrasaPagamentos)
        Me.grpInformacoes.Controls.Add(Me.lblAtrasaPagamentos)
        Me.grpInformacoes.Controls.Add(Me.txtComprouSimilares)
        Me.grpInformacoes.Controls.Add(Me.lblComprouSimilares)
        Me.grpInformacoes.Controls.Add(Me.txtValorUltimaVenda)
        Me.grpInformacoes.Controls.Add(Me.txtDataUltimaVenda)
        Me.grpInformacoes.Controls.Add(Me.lblDataUltimaVenda)
        Me.grpInformacoes.Controls.Add(Me.lblValorUltimaVenda)
        Me.grpInformacoes.Controls.Add(Me.txtRecomendacaoVenda)
        Me.grpInformacoes.Controls.Add(Me.lblRecomendacaoVenda)
        Me.grpInformacoes.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpInformacoes.Location = New System.Drawing.Point(8, 217)
        Me.grpInformacoes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpInformacoes.Name = "grpInformacoes"
        Me.grpInformacoes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpInformacoes.Size = New System.Drawing.Size(777, 141)
        Me.grpInformacoes.TabIndex = 3
        Me.grpInformacoes.Text = "Informações"
        Me.grpInformacoes.VisualStyleManager = Me.vsmMain
        '
        'txtAtrasaPagamentos
        '
        Me.txtAtrasaPagamentos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAtrasaPagamentos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAtrasaPagamentos.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtAtrasaPagamentos.Location = New System.Drawing.Point(668, 112)
        Me.txtAtrasaPagamentos.Name = "txtAtrasaPagamentos"
        Me.txtAtrasaPagamentos.ReadOnly = True
        Me.txtAtrasaPagamentos.Size = New System.Drawing.Size(100, 20)
        Me.txtAtrasaPagamentos.TabIndex = 9
        Me.txtAtrasaPagamentos.TabStop = False
        Me.txtAtrasaPagamentos.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblAtrasaPagamentos
        '
        Me.lblAtrasaPagamentos.AutoSize = True
        Me.lblAtrasaPagamentos.BackColor = System.Drawing.Color.Transparent
        Me.lblAtrasaPagamentos.Location = New System.Drawing.Point(556, 115)
        Me.lblAtrasaPagamentos.Name = "lblAtrasaPagamentos"
        Me.lblAtrasaPagamentos.Size = New System.Drawing.Size(105, 14)
        Me.lblAtrasaPagamentos.TabIndex = 8
        Me.lblAtrasaPagamentos.Text = "Atrasa Pagamentos:"
        '
        'txtComprouSimilares
        '
        Me.txtComprouSimilares.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtComprouSimilares.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComprouSimilares.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtComprouSimilares.Location = New System.Drawing.Point(668, 86)
        Me.txtComprouSimilares.Name = "txtComprouSimilares"
        Me.txtComprouSimilares.ReadOnly = True
        Me.txtComprouSimilares.Size = New System.Drawing.Size(100, 20)
        Me.txtComprouSimilares.TabIndex = 7
        Me.txtComprouSimilares.TabStop = False
        Me.txtComprouSimilares.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblComprouSimilares
        '
        Me.lblComprouSimilares.AutoSize = True
        Me.lblComprouSimilares.BackColor = System.Drawing.Color.Transparent
        Me.lblComprouSimilares.Location = New System.Drawing.Point(556, 89)
        Me.lblComprouSimilares.Name = "lblComprouSimilares"
        Me.lblComprouSimilares.Size = New System.Drawing.Size(99, 14)
        Me.lblComprouSimilares.TabIndex = 6
        Me.lblComprouSimilares.Text = "Comprou Similares:"
        '
        'txtValorUltimaVenda
        '
        Me.txtValorUltimaVenda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtValorUltimaVenda.DecimalDigits = 2
        Me.txtValorUltimaVenda.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtValorUltimaVenda.Location = New System.Drawing.Point(668, 34)
        Me.txtValorUltimaVenda.Name = "txtValorUltimaVenda"
        Me.txtValorUltimaVenda.ReadOnly = True
        Me.txtValorUltimaVenda.Size = New System.Drawing.Size(100, 20)
        Me.txtValorUltimaVenda.TabIndex = 3
        Me.txtValorUltimaVenda.TabStop = False
        Me.txtValorUltimaVenda.Text = "0,00"
        Me.txtValorUltimaVenda.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.txtValorUltimaVenda.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtDataUltimaVenda
        '
        Me.txtDataUltimaVenda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDataUltimaVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataUltimaVenda.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtDataUltimaVenda.Location = New System.Drawing.Point(668, 60)
        Me.txtDataUltimaVenda.Name = "txtDataUltimaVenda"
        Me.txtDataUltimaVenda.ReadOnly = True
        Me.txtDataUltimaVenda.Size = New System.Drawing.Size(100, 20)
        Me.txtDataUltimaVenda.TabIndex = 5
        Me.txtDataUltimaVenda.TabStop = False
        Me.txtDataUltimaVenda.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblDataUltimaVenda
        '
        Me.lblDataUltimaVenda.AutoSize = True
        Me.lblDataUltimaVenda.BackColor = System.Drawing.Color.Transparent
        Me.lblDataUltimaVenda.Location = New System.Drawing.Point(556, 63)
        Me.lblDataUltimaVenda.Name = "lblDataUltimaVenda"
        Me.lblDataUltimaVenda.Size = New System.Drawing.Size(97, 14)
        Me.lblDataUltimaVenda.TabIndex = 4
        Me.lblDataUltimaVenda.Text = "Data Última Venda:"
        '
        'lblValorUltimaVenda
        '
        Me.lblValorUltimaVenda.AutoSize = True
        Me.lblValorUltimaVenda.BackColor = System.Drawing.Color.Transparent
        Me.lblValorUltimaVenda.Location = New System.Drawing.Point(556, 37)
        Me.lblValorUltimaVenda.Name = "lblValorUltimaVenda"
        Me.lblValorUltimaVenda.Size = New System.Drawing.Size(100, 14)
        Me.lblValorUltimaVenda.TabIndex = 2
        Me.lblValorUltimaVenda.Text = "Valor Última Venda:"
        '
        'txtRecomendacaoVenda
        '
        Me.txtRecomendacaoVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecomendacaoVenda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRecomendacaoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRecomendacaoVenda.Location = New System.Drawing.Point(9, 34)
        Me.txtRecomendacaoVenda.MaxLength = 5000
        Me.txtRecomendacaoVenda.Multiline = True
        Me.txtRecomendacaoVenda.Name = "txtRecomendacaoVenda"
        Me.txtRecomendacaoVenda.ReadOnly = True
        Me.txtRecomendacaoVenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecomendacaoVenda.Size = New System.Drawing.Size(524, 98)
        Me.txtRecomendacaoVenda.TabIndex = 1
        Me.txtRecomendacaoVenda.TabStop = False
        '
        'lblRecomendacaoVenda
        '
        Me.lblRecomendacaoVenda.AutoSize = True
        Me.lblRecomendacaoVenda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRecomendacaoVenda.Location = New System.Drawing.Point(6, 17)
        Me.lblRecomendacaoVenda.Name = "lblRecomendacaoVenda"
        Me.lblRecomendacaoVenda.Size = New System.Drawing.Size(134, 14)
        Me.lblRecomendacaoVenda.TabIndex = 0
        Me.lblRecomendacaoVenda.Text = "Recomendação de Venda:"
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 361)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(777, 51)
        Me.grpControl2.TabIndex = 4
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(677, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpMotivo
        '
        Me.grpMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMotivo.BackColor = System.Drawing.Color.Transparent
        Me.grpMotivo.Controls.Add(Me.lblQuantidadeUnidade)
        Me.grpMotivo.Controls.Add(Me.txtQuantidadeUnidade)
        Me.grpMotivo.Controls.Add(Me.lblCodigo)
        Me.grpMotivo.Controls.Add(Me.txtMarca)
        Me.grpMotivo.Controls.Add(Me.lblMarca)
        Me.grpMotivo.Controls.Add(Me.lblDescricao)
        Me.grpMotivo.Controls.Add(Me.txtDescricao)
        Me.grpMotivo.Controls.Add(Me.txtCodigo)
        Me.grpMotivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpMotivo.Location = New System.Drawing.Point(8, 3)
        Me.grpMotivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMotivo.Name = "grpMotivo"
        Me.grpMotivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpMotivo.Size = New System.Drawing.Size(777, 64)
        Me.grpMotivo.TabIndex = 0
        Me.grpMotivo.Text = "Dados do Produto"
        Me.grpMotivo.VisualStyleManager = Me.vsmMain
        '
        'lblQuantidadeUnidade
        '
        Me.lblQuantidadeUnidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuantidadeUnidade.AutoSize = True
        Me.lblQuantidadeUnidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblQuantidadeUnidade.Location = New System.Drawing.Point(695, 17)
        Me.lblQuantidadeUnidade.Name = "lblQuantidadeUnidade"
        Me.lblQuantidadeUnidade.Size = New System.Drawing.Size(67, 14)
        Me.lblQuantidadeUnidade.TabIndex = 7
        Me.lblQuantidadeUnidade.Text = "Qtde. / Und.:"
        '
        'txtQuantidadeUnidade
        '
        Me.txtQuantidadeUnidade.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeUnidade.DecimalDigits = 2
        Me.txtQuantidadeUnidade.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtQuantidadeUnidade.Location = New System.Drawing.Point(698, 34)
        Me.txtQuantidadeUnidade.Name = "txtQuantidadeUnidade"
        Me.txtQuantidadeUnidade.ReadOnly = True
        Me.txtQuantidadeUnidade.Size = New System.Drawing.Size(70, 20)
        Me.txtQuantidadeUnidade.TabIndex = 6
        Me.txtQuantidadeUnidade.TabStop = False
        Me.txtQuantidadeUnidade.Text = "0,00"
        Me.txtQuantidadeUnidade.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigo.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'txtMarca
        '
        Me.txtMarca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarca.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarca.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMarca.Location = New System.Drawing.Point(571, 34)
        Me.txtMarca.MaxLength = 100
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(121, 20)
        Me.txtMarca.TabIndex = 5
        Me.txtMarca.TabStop = False
        '
        'lblMarca
        '
        Me.lblMarca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMarca.AutoSize = True
        Me.lblMarca.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarca.Location = New System.Drawing.Point(568, 17)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(40, 14)
        Me.lblMarca.TabIndex = 4
        Me.lblMarca.Text = "Marca:"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricao.Location = New System.Drawing.Point(135, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDescricao.Location = New System.Drawing.Point(138, 34)
        Me.txtDescricao.MaxLength = 120
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(427, 20)
        Me.txtDescricao.TabIndex = 3
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
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.TabStop = False
        '
        'frmVenProdutoPrecoVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 458)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVenProdutoPrecoVenda"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Preço de Venda"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpCustoMedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCustoMedido.ResumeLayout(False)
        Me.grpCustoMedido.PerformLayout()
        CType(Me.grpCustoTeorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCustoTeorico.ResumeLayout(False)
        Me.grpCustoTeorico.PerformLayout()
        CType(Me.grpInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInformacoes.ResumeLayout(False)
        Me.grpInformacoes.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        CType(Me.grpMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMotivo.ResumeLayout(False)
        Me.grpMotivo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpMotivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtMarca As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpInformacoes As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblRecomendacaoVenda As System.Windows.Forms.Label
    Friend WithEvents txtRecomendacaoVenda As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtAtrasaPagamentos As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblAtrasaPagamentos As System.Windows.Forms.Label
    Friend WithEvents txtComprouSimilares As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblComprouSimilares As System.Windows.Forms.Label
    Friend WithEvents txtValorUltimaVenda As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtDataUltimaVenda As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDataUltimaVenda As System.Windows.Forms.Label
    Friend WithEvents lblValorUltimaVenda As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadeUnidade As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadeUnidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents grpCustoMedido As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnPrecoMedio As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblPrecoUnidadeMedio As System.Windows.Forms.Label
    Friend WithEvents txtPrecoUnidadeMedio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPrecoVendaMedio As System.Windows.Forms.Label
    Friend WithEvents txtPrecoVendaMedio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMarkupMedio As System.Windows.Forms.Label
    Friend WithEvents txtMarkupMedio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblGPMedio As System.Windows.Forms.Label
    Friend WithEvents txtGPMedio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMargemMedio As System.Windows.Forms.Label
    Friend WithEvents lblCustoMedio As System.Windows.Forms.Label
    Friend WithEvents txtMargemMedio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtCustoMedio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents grpCustoTeorico As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnPrecoTeorico As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblPrecoUnidadeTeorico As System.Windows.Forms.Label
    Friend WithEvents txtPrecoUnidadeTeorico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPrecoVendaTeorico As System.Windows.Forms.Label
    Friend WithEvents txtPrecoVendaTeorico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMarkupTeorico As System.Windows.Forms.Label
    Friend WithEvents txtMarkupTeorico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblGPTeorico As System.Windows.Forms.Label
    Friend WithEvents txtGPTeorico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMargemTeorico As System.Windows.Forms.Label
    Friend WithEvents lblCustoTeorico As System.Windows.Forms.Label
    Friend WithEvents txtMargemTeorico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtCustoTeorico As Janus.Windows.GridEX.EditControls.NumericEditBox
End Class
