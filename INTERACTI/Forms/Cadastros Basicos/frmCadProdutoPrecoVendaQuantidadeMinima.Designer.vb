<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadProdutoPrecoVendaQuantidadeMinima
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadProdutoPrecoVendaQuantidadeMinima))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblPrecoVendaIdeal = New System.Windows.Forms.Label()
        Me.txtPrecoVendaIdeal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMarkupIdeal = New System.Windows.Forms.Label()
        Me.txtMarkupIdeal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblGPIdeal = New System.Windows.Forms.Label()
        Me.txtGPIdeal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMargemIdeal = New System.Windows.Forms.Label()
        Me.txtMargemIdeal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblPrecoVendaMinimo = New System.Windows.Forms.Label()
        Me.txtPrecoVendaMinimo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMarkupMinimo = New System.Windows.Forms.Label()
        Me.txtMarkupMinimo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblGPMinimo = New System.Windows.Forms.Label()
        Me.txtGPMinimo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMargemMinimo = New System.Windows.Forms.Label()
        Me.txtMargemMinimo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.grpMotivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPorcentagemCustos = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPorcentagemImposto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblPrecoCompraReais = New System.Windows.Forms.Label()
        Me.txtPrecoCompraReais = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCotacao = New System.Windows.Forms.Label()
        Me.txtCotacao = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMoeda = New System.Windows.Forms.Label()
        Me.lblCustoTeoricoMinimo = New System.Windows.Forms.Label()
        Me.cboMoeda = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPrecoCompra = New System.Windows.Forms.Label()
        Me.txtCustoTeorico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtPrecoCompra = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblMultiploVenda = New System.Windows.Forms.Label()
        Me.txtMultiploVenda = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtMarca = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(785, 306)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.UiGroupBox3)
        Me.pagTabela.Controls.Add(Me.UiGroupBox1)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Controls.Add(Me.grpMotivo)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(783, 283)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Definir Preço de Venda"
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox3.Controls.Add(Me.lblPrecoVendaIdeal)
        Me.UiGroupBox3.Controls.Add(Me.txtPrecoVendaIdeal)
        Me.UiGroupBox3.Controls.Add(Me.lblMarkupIdeal)
        Me.UiGroupBox3.Controls.Add(Me.txtMarkupIdeal)
        Me.UiGroupBox3.Controls.Add(Me.lblGPIdeal)
        Me.UiGroupBox3.Controls.Add(Me.txtGPIdeal)
        Me.UiGroupBox3.Controls.Add(Me.lblMargemIdeal)
        Me.UiGroupBox3.Controls.Add(Me.txtMargemIdeal)
        Me.UiGroupBox3.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox3.Location = New System.Drawing.Point(394, 111)
        Me.UiGroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox3.Size = New System.Drawing.Size(376, 111)
        Me.UiGroupBox3.TabIndex = 1
        Me.UiGroupBox3.Text = "Preço de Venda Ideal"
        Me.UiGroupBox3.VisualStyleManager = Me.vsmMain
        '
        'lblPrecoVendaIdeal
        '
        Me.lblPrecoVendaIdeal.AutoSize = True
        Me.lblPrecoVendaIdeal.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecoVendaIdeal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrecoVendaIdeal.Location = New System.Drawing.Point(138, 57)
        Me.lblPrecoVendaIdeal.Name = "lblPrecoVendaIdeal"
        Me.lblPrecoVendaIdeal.Size = New System.Drawing.Size(96, 14)
        Me.lblPrecoVendaIdeal.TabIndex = 6
        Me.lblPrecoVendaIdeal.Text = "Preço de Venda:"
        '
        'txtPrecoVendaIdeal
        '
        Me.txtPrecoVendaIdeal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrecoVendaIdeal.DecimalDigits = 2
        Me.txtPrecoVendaIdeal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtPrecoVendaIdeal.Location = New System.Drawing.Point(141, 74)
        Me.txtPrecoVendaIdeal.Name = "txtPrecoVendaIdeal"
        Me.txtPrecoVendaIdeal.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecoVendaIdeal.TabIndex = 7
        Me.txtPrecoVendaIdeal.Text = "0,00"
        Me.txtPrecoVendaIdeal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMarkupIdeal
        '
        Me.lblMarkupIdeal.AutoSize = True
        Me.lblMarkupIdeal.BackColor = System.Drawing.Color.Transparent
        Me.lblMarkupIdeal.Location = New System.Drawing.Point(32, 17)
        Me.lblMarkupIdeal.Name = "lblMarkupIdeal"
        Me.lblMarkupIdeal.Size = New System.Drawing.Size(45, 14)
        Me.lblMarkupIdeal.TabIndex = 0
        Me.lblMarkupIdeal.Text = "Markup:"
        '
        'txtMarkupIdeal
        '
        Me.txtMarkupIdeal.DecimalDigits = 2
        Me.txtMarkupIdeal.Location = New System.Drawing.Point(35, 34)
        Me.txtMarkupIdeal.Name = "txtMarkupIdeal"
        Me.txtMarkupIdeal.Size = New System.Drawing.Size(100, 20)
        Me.txtMarkupIdeal.TabIndex = 1
        Me.txtMarkupIdeal.Text = "0,00"
        Me.txtMarkupIdeal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblGPIdeal
        '
        Me.lblGPIdeal.AutoSize = True
        Me.lblGPIdeal.BackColor = System.Drawing.Color.Transparent
        Me.lblGPIdeal.Location = New System.Drawing.Point(138, 17)
        Me.lblGPIdeal.Name = "lblGPIdeal"
        Me.lblGPIdeal.Size = New System.Drawing.Size(24, 14)
        Me.lblGPIdeal.TabIndex = 2
        Me.lblGPIdeal.Text = "GP:"
        '
        'txtGPIdeal
        '
        Me.txtGPIdeal.DecimalDigits = 2
        Me.txtGPIdeal.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtGPIdeal.Location = New System.Drawing.Point(141, 34)
        Me.txtGPIdeal.Name = "txtGPIdeal"
        Me.txtGPIdeal.Size = New System.Drawing.Size(100, 20)
        Me.txtGPIdeal.TabIndex = 3
        Me.txtGPIdeal.Text = "0,00%"
        Me.txtGPIdeal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMargemIdeal
        '
        Me.lblMargemIdeal.AutoSize = True
        Me.lblMargemIdeal.BackColor = System.Drawing.Color.Transparent
        Me.lblMargemIdeal.Location = New System.Drawing.Point(244, 17)
        Me.lblMargemIdeal.Name = "lblMargemIdeal"
        Me.lblMargemIdeal.Size = New System.Drawing.Size(48, 14)
        Me.lblMargemIdeal.TabIndex = 4
        Me.lblMargemIdeal.Text = "Margem:"
        '
        'txtMargemIdeal
        '
        Me.txtMargemIdeal.DecimalDigits = 2
        Me.txtMargemIdeal.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtMargemIdeal.Location = New System.Drawing.Point(247, 34)
        Me.txtMargemIdeal.Name = "txtMargemIdeal"
        Me.txtMargemIdeal.Size = New System.Drawing.Size(100, 20)
        Me.txtMargemIdeal.TabIndex = 5
        Me.txtMargemIdeal.Text = "0,00%"
        Me.txtMargemIdeal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.lblPrecoVendaMinimo)
        Me.UiGroupBox1.Controls.Add(Me.txtPrecoVendaMinimo)
        Me.UiGroupBox1.Controls.Add(Me.lblMarkupMinimo)
        Me.UiGroupBox1.Controls.Add(Me.txtMarkupMinimo)
        Me.UiGroupBox1.Controls.Add(Me.lblGPMinimo)
        Me.UiGroupBox1.Controls.Add(Me.txtGPMinimo)
        Me.UiGroupBox1.Controls.Add(Me.lblMargemMinimo)
        Me.UiGroupBox1.Controls.Add(Me.txtMargemMinimo)
        Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 111)
        Me.UiGroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(376, 111)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.Text = "Preço de Venda Mínimo"
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'lblPrecoVendaMinimo
        '
        Me.lblPrecoVendaMinimo.AutoSize = True
        Me.lblPrecoVendaMinimo.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecoVendaMinimo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPrecoVendaMinimo.Location = New System.Drawing.Point(133, 57)
        Me.lblPrecoVendaMinimo.Name = "lblPrecoVendaMinimo"
        Me.lblPrecoVendaMinimo.Size = New System.Drawing.Size(96, 14)
        Me.lblPrecoVendaMinimo.TabIndex = 6
        Me.lblPrecoVendaMinimo.Text = "Preço de Venda:"
        '
        'txtPrecoVendaMinimo
        '
        Me.txtPrecoVendaMinimo.BackColor = System.Drawing.SystemColors.Info
        Me.txtPrecoVendaMinimo.DecimalDigits = 2
        Me.txtPrecoVendaMinimo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtPrecoVendaMinimo.Location = New System.Drawing.Point(136, 74)
        Me.txtPrecoVendaMinimo.Name = "txtPrecoVendaMinimo"
        Me.txtPrecoVendaMinimo.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecoVendaMinimo.TabIndex = 7
        Me.txtPrecoVendaMinimo.Text = "0,00"
        Me.txtPrecoVendaMinimo.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMarkupMinimo
        '
        Me.lblMarkupMinimo.AutoSize = True
        Me.lblMarkupMinimo.BackColor = System.Drawing.Color.Transparent
        Me.lblMarkupMinimo.Location = New System.Drawing.Point(27, 17)
        Me.lblMarkupMinimo.Name = "lblMarkupMinimo"
        Me.lblMarkupMinimo.Size = New System.Drawing.Size(45, 14)
        Me.lblMarkupMinimo.TabIndex = 0
        Me.lblMarkupMinimo.Text = "Markup:"
        '
        'txtMarkupMinimo
        '
        Me.txtMarkupMinimo.DecimalDigits = 2
        Me.txtMarkupMinimo.Location = New System.Drawing.Point(30, 34)
        Me.txtMarkupMinimo.Name = "txtMarkupMinimo"
        Me.txtMarkupMinimo.Size = New System.Drawing.Size(100, 20)
        Me.txtMarkupMinimo.TabIndex = 1
        Me.txtMarkupMinimo.Text = "0,00"
        Me.txtMarkupMinimo.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblGPMinimo
        '
        Me.lblGPMinimo.AutoSize = True
        Me.lblGPMinimo.BackColor = System.Drawing.Color.Transparent
        Me.lblGPMinimo.Location = New System.Drawing.Point(136, 17)
        Me.lblGPMinimo.Name = "lblGPMinimo"
        Me.lblGPMinimo.Size = New System.Drawing.Size(24, 14)
        Me.lblGPMinimo.TabIndex = 2
        Me.lblGPMinimo.Text = "GP:"
        '
        'txtGPMinimo
        '
        Me.txtGPMinimo.DecimalDigits = 2
        Me.txtGPMinimo.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtGPMinimo.Location = New System.Drawing.Point(136, 34)
        Me.txtGPMinimo.Name = "txtGPMinimo"
        Me.txtGPMinimo.Size = New System.Drawing.Size(100, 20)
        Me.txtGPMinimo.TabIndex = 3
        Me.txtGPMinimo.Text = "0,00%"
        Me.txtGPMinimo.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMargemMinimo
        '
        Me.lblMargemMinimo.AutoSize = True
        Me.lblMargemMinimo.BackColor = System.Drawing.Color.Transparent
        Me.lblMargemMinimo.Location = New System.Drawing.Point(239, 17)
        Me.lblMargemMinimo.Name = "lblMargemMinimo"
        Me.lblMargemMinimo.Size = New System.Drawing.Size(48, 14)
        Me.lblMargemMinimo.TabIndex = 4
        Me.lblMargemMinimo.Text = "Margem:"
        '
        'txtMargemMinimo
        '
        Me.txtMargemMinimo.DecimalDigits = 2
        Me.txtMargemMinimo.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtMargemMinimo.Location = New System.Drawing.Point(242, 34)
        Me.txtMargemMinimo.Name = "txtMargemMinimo"
        Me.txtMargemMinimo.Size = New System.Drawing.Size(100, 20)
        Me.txtMargemMinimo.TabIndex = 5
        Me.txtMargemMinimo.Text = "0,00%"
        Me.txtMargemMinimo.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 223)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(763, 51)
        Me.grpControl2.TabIndex = 3
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(566, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(663, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpMotivo
        '
        Me.grpMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMotivo.BackColor = System.Drawing.Color.Transparent
        Me.grpMotivo.Controls.Add(Me.Label2)
        Me.grpMotivo.Controls.Add(Me.txtPorcentagemCustos)
        Me.grpMotivo.Controls.Add(Me.Label1)
        Me.grpMotivo.Controls.Add(Me.txtPorcentagemImposto)
        Me.grpMotivo.Controls.Add(Me.lblPrecoCompraReais)
        Me.grpMotivo.Controls.Add(Me.txtPrecoCompraReais)
        Me.grpMotivo.Controls.Add(Me.lblCotacao)
        Me.grpMotivo.Controls.Add(Me.txtCotacao)
        Me.grpMotivo.Controls.Add(Me.lblMoeda)
        Me.grpMotivo.Controls.Add(Me.lblCustoTeoricoMinimo)
        Me.grpMotivo.Controls.Add(Me.cboMoeda)
        Me.grpMotivo.Controls.Add(Me.lblPrecoCompra)
        Me.grpMotivo.Controls.Add(Me.txtCustoTeorico)
        Me.grpMotivo.Controls.Add(Me.txtPrecoCompra)
        Me.grpMotivo.Controls.Add(Me.lblMultiploVenda)
        Me.grpMotivo.Controls.Add(Me.txtMultiploVenda)
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
        Me.grpMotivo.Size = New System.Drawing.Size(763, 107)
        Me.grpMotivo.TabIndex = 0
        Me.grpMotivo.VisualStyleManager = Me.vsmMain
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(555, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 14)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "% Custos:"
        '
        'txtPorcentagemCustos
        '
        Me.txtPorcentagemCustos.DecimalDigits = 2
        Me.txtPorcentagemCustos.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtPorcentagemCustos.Location = New System.Drawing.Point(555, 75)
        Me.txtPorcentagemCustos.Name = "txtPorcentagemCustos"
        Me.txtPorcentagemCustos.Size = New System.Drawing.Size(92, 20)
        Me.txtPorcentagemCustos.TabIndex = 19
        Me.txtPorcentagemCustos.Text = "0,00%"
        Me.txtPorcentagemCustos.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(457, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 14)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "% Impostos:"
        '
        'txtPorcentagemImposto
        '
        Me.txtPorcentagemImposto.DecimalDigits = 2
        Me.txtPorcentagemImposto.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtPorcentagemImposto.Location = New System.Drawing.Point(457, 75)
        Me.txtPorcentagemImposto.Name = "txtPorcentagemImposto"
        Me.txtPorcentagemImposto.Size = New System.Drawing.Size(92, 20)
        Me.txtPorcentagemImposto.TabIndex = 17
        Me.txtPorcentagemImposto.Text = "0,00%"
        Me.txtPorcentagemImposto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblPrecoCompraReais
        '
        Me.lblPrecoCompraReais.AutoSize = True
        Me.lblPrecoCompraReais.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecoCompraReais.Location = New System.Drawing.Point(320, 58)
        Me.lblPrecoCompraReais.Name = "lblPrecoCompraReais"
        Me.lblPrecoCompraReais.Size = New System.Drawing.Size(117, 14)
        Me.lblPrecoCompraReais.TabIndex = 14
        Me.lblPrecoCompraReais.Text = "Preço de Compra (R$):"
        '
        'txtPrecoCompraReais
        '
        Me.txtPrecoCompraReais.DecimalDigits = 2
        Me.txtPrecoCompraReais.Location = New System.Drawing.Point(320, 75)
        Me.txtPrecoCompraReais.Name = "txtPrecoCompraReais"
        Me.txtPrecoCompraReais.Size = New System.Drawing.Size(131, 20)
        Me.txtPrecoCompraReais.TabIndex = 15
        Me.txtPrecoCompraReais.Text = "0,00"
        Me.txtPrecoCompraReais.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblCotacao
        '
        Me.lblCotacao.AutoSize = True
        Me.lblCotacao.BackColor = System.Drawing.Color.Transparent
        Me.lblCotacao.Location = New System.Drawing.Point(79, 58)
        Me.lblCotacao.Name = "lblCotacao"
        Me.lblCotacao.Size = New System.Drawing.Size(50, 14)
        Me.lblCotacao.TabIndex = 10
        Me.lblCotacao.Text = "Cotação:"
        '
        'txtCotacao
        '
        Me.txtCotacao.DecimalDigits = 4
        Me.txtCotacao.Location = New System.Drawing.Point(82, 75)
        Me.txtCotacao.Name = "txtCotacao"
        Me.txtCotacao.Size = New System.Drawing.Size(103, 20)
        Me.txtCotacao.TabIndex = 11
        Me.txtCotacao.Text = "0,0000"
        Me.txtCotacao.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblMoeda
        '
        Me.lblMoeda.AutoSize = True
        Me.lblMoeda.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMoeda.Location = New System.Drawing.Point(8, 58)
        Me.lblMoeda.Name = "lblMoeda"
        Me.lblMoeda.Size = New System.Drawing.Size(42, 14)
        Me.lblMoeda.TabIndex = 8
        Me.lblMoeda.Text = "Moeda:"
        '
        'lblCustoTeoricoMinimo
        '
        Me.lblCustoTeoricoMinimo.AutoSize = True
        Me.lblCustoTeoricoMinimo.BackColor = System.Drawing.Color.Transparent
        Me.lblCustoTeoricoMinimo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblCustoTeoricoMinimo.Location = New System.Drawing.Point(650, 59)
        Me.lblCustoTeoricoMinimo.Name = "lblCustoTeoricoMinimo"
        Me.lblCustoTeoricoMinimo.Size = New System.Drawing.Size(76, 14)
        Me.lblCustoTeoricoMinimo.TabIndex = 20
        Me.lblCustoTeoricoMinimo.Text = "Custo Teórico:"
        '
        'cboMoeda
        '
        Me.cboMoeda.AutoSize = False
        Me.cboMoeda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMoeda.Location = New System.Drawing.Point(9, 75)
        Me.cboMoeda.Name = "cboMoeda"
        Me.cboMoeda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMoeda.Size = New System.Drawing.Size(67, 20)
        Me.cboMoeda.TabIndex = 9
        '
        'lblPrecoCompra
        '
        Me.lblPrecoCompra.AutoSize = True
        Me.lblPrecoCompra.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecoCompra.Location = New System.Drawing.Point(191, 58)
        Me.lblPrecoCompra.Name = "lblPrecoCompra"
        Me.lblPrecoCompra.Size = New System.Drawing.Size(93, 14)
        Me.lblPrecoCompra.TabIndex = 12
        Me.lblPrecoCompra.Text = "Preço de Compra:"
        '
        'txtCustoTeorico
        '
        Me.txtCustoTeorico.BackColor = System.Drawing.Color.White
        Me.txtCustoTeorico.DecimalDigits = 2
        Me.txtCustoTeorico.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtCustoTeorico.Location = New System.Drawing.Point(653, 76)
        Me.txtCustoTeorico.Name = "txtCustoTeorico"
        Me.txtCustoTeorico.Size = New System.Drawing.Size(100, 20)
        Me.txtCustoTeorico.TabIndex = 21
        Me.txtCustoTeorico.Text = "0,00"
        Me.txtCustoTeorico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'txtPrecoCompra
        '
        Me.txtPrecoCompra.DecimalDigits = 2
        Me.txtPrecoCompra.Location = New System.Drawing.Point(191, 75)
        Me.txtPrecoCompra.Name = "txtPrecoCompra"
        Me.txtPrecoCompra.Size = New System.Drawing.Size(123, 20)
        Me.txtPrecoCompra.TabIndex = 13
        Me.txtPrecoCompra.Text = "0,00"
        Me.txtPrecoCompra.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblMultiploVenda
        '
        Me.lblMultiploVenda.AutoSize = True
        Me.lblMultiploVenda.BackColor = System.Drawing.Color.Transparent
        Me.lblMultiploVenda.Location = New System.Drawing.Point(650, 17)
        Me.lblMultiploVenda.Name = "lblMultiploVenda"
        Me.lblMultiploVenda.Size = New System.Drawing.Size(79, 14)
        Me.lblMultiploVenda.TabIndex = 6
        Me.lblMultiploVenda.Text = "Múltiplo Venda:"
        '
        'txtMultiploVenda
        '
        Me.txtMultiploVenda.DecimalDigits = 4
        Me.txtMultiploVenda.Location = New System.Drawing.Point(653, 34)
        Me.txtMultiploVenda.Name = "txtMultiploVenda"
        Me.txtMultiploVenda.Size = New System.Drawing.Size(100, 20)
        Me.txtMultiploVenda.TabIndex = 7
        Me.txtMultiploVenda.Text = "0,0000"
        Me.txtMultiploVenda.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigo.Location = New System.Drawing.Point(6, 16)
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
        Me.txtMarca.Location = New System.Drawing.Point(431, 34)
        Me.txtMarca.MaxLength = 100
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(217, 20)
        Me.txtMarca.TabIndex = 5
        Me.txtMarca.TabStop = False
        '
        'lblMarca
        '
        Me.lblMarca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMarca.AutoSize = True
        Me.lblMarca.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarca.Location = New System.Drawing.Point(428, 17)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(40, 14)
        Me.lblMarca.TabIndex = 4
        Me.lblMarca.Text = "Marca:"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricao.Location = New System.Drawing.Point(135, 16)
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
        Me.txtDescricao.Location = New System.Drawing.Point(138, 33)
        Me.txtDescricao.MaxLength = 120
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(287, 20)
        Me.txtDescricao.TabIndex = 3
        Me.txtDescricao.TabStop = False
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodigo.Location = New System.Drawing.Point(9, 33)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(123, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.TabStop = False
        '
        'frmCadProdutoPrecoVendaQuantidadeMinima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 320)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadProdutoPrecoVendaQuantidadeMinima"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Preço de Venda"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        Me.UiGroupBox3.PerformLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
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
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpMotivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtMarca As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblPrecoVendaIdeal As System.Windows.Forms.Label
    Friend WithEvents txtPrecoVendaIdeal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMarkupIdeal As System.Windows.Forms.Label
    Friend WithEvents txtMarkupIdeal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblGPIdeal As System.Windows.Forms.Label
    Friend WithEvents txtGPIdeal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMargemIdeal As System.Windows.Forms.Label
    Friend WithEvents txtMargemIdeal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblPrecoVendaMinimo As System.Windows.Forms.Label
    Friend WithEvents txtPrecoVendaMinimo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMarkupMinimo As System.Windows.Forms.Label
    Friend WithEvents txtMarkupMinimo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblGPMinimo As System.Windows.Forms.Label
    Friend WithEvents txtGPMinimo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMargemMinimo As System.Windows.Forms.Label
    Friend WithEvents lblCustoTeoricoMinimo As System.Windows.Forms.Label
    Friend WithEvents txtMargemMinimo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents txtCustoTeorico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMultiploVenda As System.Windows.Forms.Label
    Friend WithEvents txtMultiploVenda As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPrecoCompra As System.Windows.Forms.Label
    Friend WithEvents txtPrecoCompra As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblPrecoCompraReais As System.Windows.Forms.Label
    Friend WithEvents txtPrecoCompraReais As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblCotacao As System.Windows.Forms.Label
    Friend WithEvents txtCotacao As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblMoeda As System.Windows.Forms.Label
    Friend WithEvents cboMoeda As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPorcentagemImposto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPorcentagemCustos As Janus.Windows.GridEX.EditControls.NumericEditBox
End Class
