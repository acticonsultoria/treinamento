<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadProdutoBOMImportar
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
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegendaItemFantasma = New System.Windows.Forms.PictureBox()
        Me.lblLegendaItemFantasma = New System.Windows.Forms.Label()
        Me.picLegendaGeraOP = New System.Windows.Forms.PictureBox()
        Me.lblLegendaGeraOP = New System.Windows.Forms.Label()
        Me.picLegendaMPHD = New System.Windows.Forms.PictureBox()
        Me.lblLegendaMPHD = New System.Windows.Forms.Label()
        Me.grpProduto = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtProdutoPai = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblItemPai = New System.Windows.Forms.Label()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.cboCodigoProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigoProduto = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.trvMain = New System.Windows.Forms.TreeView()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaItemFantasma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaGeraOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaMPHD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProduto.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
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
        Me.pagTabela.Controls.Add(Me.grpLegenda)
        Me.pagTabela.Controls.Add(Me.grpProduto)
        Me.pagTabela.Controls.Add(Me.trvMain)
        Me.pagTabela.Controls.Add(Me.grpControl)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(956, 512)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Importar BOM"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.picLegendaItemFantasma)
        Me.grpLegenda.Controls.Add(Me.lblLegendaItemFantasma)
        Me.grpLegenda.Controls.Add(Me.picLegendaGeraOP)
        Me.grpLegenda.Controls.Add(Me.lblLegendaGeraOP)
        Me.grpLegenda.Controls.Add(Me.picLegendaMPHD)
        Me.grpLegenda.Controls.Add(Me.lblLegendaMPHD)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(4, 458)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(215, 51)
        Me.grpLegenda.TabIndex = 9
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picLegendaItemFantasma
        '
        Me.picLegendaItemFantasma.BackColor = System.Drawing.Color.Firebrick
        Me.picLegendaItemFantasma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaItemFantasma.Location = New System.Drawing.Point(105, 13)
        Me.picLegendaItemFantasma.Name = "picLegendaItemFantasma"
        Me.picLegendaItemFantasma.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaItemFantasma.TabIndex = 17
        Me.picLegendaItemFantasma.TabStop = False
        '
        'lblLegendaItemFantasma
        '
        Me.lblLegendaItemFantasma.AutoSize = True
        Me.lblLegendaItemFantasma.Location = New System.Drawing.Point(126, 13)
        Me.lblLegendaItemFantasma.Name = "lblLegendaItemFantasma"
        Me.lblLegendaItemFantasma.Size = New System.Drawing.Size(76, 14)
        Me.lblLegendaItemFantasma.TabIndex = 3
        Me.lblLegendaItemFantasma.Text = "Item Fantasma"
        '
        'picLegendaGeraOP
        '
        Me.picLegendaGeraOP.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegendaGeraOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaGeraOP.Location = New System.Drawing.Point(9, 13)
        Me.picLegendaGeraOP.Name = "picLegendaGeraOP"
        Me.picLegendaGeraOP.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaGeraOP.TabIndex = 11
        Me.picLegendaGeraOP.TabStop = False
        '
        'lblLegendaGeraOP
        '
        Me.lblLegendaGeraOP.AutoSize = True
        Me.lblLegendaGeraOP.Location = New System.Drawing.Point(30, 13)
        Me.lblLegendaGeraOP.Name = "lblLegendaGeraOP"
        Me.lblLegendaGeraOP.Size = New System.Drawing.Size(48, 14)
        Me.lblLegendaGeraOP.TabIndex = 2
        Me.lblLegendaGeraOP.Text = "Gera OP"
        '
        'picLegendaMPHD
        '
        Me.picLegendaMPHD.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaMPHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaMPHD.Location = New System.Drawing.Point(9, 30)
        Me.picLegendaMPHD.Name = "picLegendaMPHD"
        Me.picLegendaMPHD.Size = New System.Drawing.Size(15, 15)
        Me.picLegendaMPHD.TabIndex = 19
        Me.picLegendaMPHD.TabStop = False
        '
        'lblLegendaMPHD
        '
        Me.lblLegendaMPHD.AutoSize = True
        Me.lblLegendaMPHD.Location = New System.Drawing.Point(30, 30)
        Me.lblLegendaMPHD.Name = "lblLegendaMPHD"
        Me.lblLegendaMPHD.Size = New System.Drawing.Size(90, 14)
        Me.lblLegendaMPHD.TabIndex = 1
        Me.lblLegendaMPHD.Text = "MP / Componente"
        '
        'grpProduto
        '
        Me.grpProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProduto.BackColor = System.Drawing.Color.Transparent
        Me.grpProduto.Controls.Add(Me.txtProdutoPai)
        Me.grpProduto.Controls.Add(Me.lblItemPai)
        Me.grpProduto.Controls.Add(Me.btnProcurarProduto)
        Me.grpProduto.Controls.Add(Me.cboCodigoProduto)
        Me.grpProduto.Controls.Add(Me.lblCodigoProduto)
        Me.grpProduto.Controls.Add(Me.txtDescricao)
        Me.grpProduto.Controls.Add(Me.lblDescricao)
        Me.grpProduto.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpProduto.Location = New System.Drawing.Point(4, 3)
        Me.grpProduto.Name = "grpProduto"
        Me.grpProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpProduto.Size = New System.Drawing.Size(948, 64)
        Me.grpProduto.TabIndex = 6
        Me.grpProduto.Text = "Dados do Produto"
        Me.grpProduto.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpProduto.VisualStyleManager = Me.vsmMain
        '
        'txtProdutoPai
        '
        Me.txtProdutoPai.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProdutoPai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoPai.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtProdutoPai.Location = New System.Drawing.Point(9, 34)
        Me.txtProdutoPai.MaxLength = 120
        Me.txtProdutoPai.Name = "txtProdutoPai"
        Me.txtProdutoPai.ReadOnly = True
        Me.txtProdutoPai.Size = New System.Drawing.Size(125, 20)
        Me.txtProdutoPai.TabIndex = 7
        Me.txtProdutoPai.TabStop = False
        '
        'lblItemPai
        '
        Me.lblItemPai.AutoSize = True
        Me.lblItemPai.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblItemPai.Location = New System.Drawing.Point(6, 17)
        Me.lblItemPai.Name = "lblItemPai"
        Me.lblItemPai.Size = New System.Drawing.Size(64, 14)
        Me.lblItemPai.TabIndex = 6
        Me.lblItemPai.Text = "Produto Pai:"
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.FlatAppearance.BorderSize = 0
        Me.btnProcurarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarProduto.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarProduto.Location = New System.Drawing.Point(273, 16)
        Me.btnProcurarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarProduto.TabIndex = 2
        Me.btnProcurarProduto.TabStop = False
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'cboCodigoProduto
        '
        Me.cboCodigoProduto.Location = New System.Drawing.Point(140, 34)
        Me.cboCodigoProduto.Name = "cboCodigoProduto"
        Me.cboCodigoProduto.Size = New System.Drawing.Size(150, 20)
        Me.cboCodigoProduto.TabIndex = 3
        '
        'lblCodigoProduto
        '
        Me.lblCodigoProduto.AutoSize = True
        Me.lblCodigoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProduto.Location = New System.Drawing.Point(137, 17)
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        Me.lblCodigoProduto.Size = New System.Drawing.Size(84, 14)
        Me.lblCodigoProduto.TabIndex = 1
        Me.lblCodigoProduto.Text = "Produto Modelo:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDescricao.Location = New System.Drawing.Point(296, 34)
        Me.txtDescricao.MaxLength = 120
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(643, 20)
        Me.txtDescricao.TabIndex = 5
        Me.txtDescricao.TabStop = False
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricao.Location = New System.Drawing.Point(293, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 4
        Me.lblDescricao.Text = "Descrição:"
        '
        'trvMain
        '
        Me.trvMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trvMain.CheckBoxes = True
        Me.trvMain.FullRowSelect = True
        Me.trvMain.ItemHeight = 20
        Me.trvMain.Location = New System.Drawing.Point(4, 73)
        Me.trvMain.Name = "trvMain"
        Me.trvMain.ShowLines = False
        Me.trvMain.ShowNodeToolTips = True
        Me.trvMain.Size = New System.Drawing.Size(948, 379)
        Me.trvMain.TabIndex = 7
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnInserir)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(225, 458)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(727, 51)
        Me.grpControl.TabIndex = 8
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(530, 17)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 21
        Me.btnInserir.Text = "Importar"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(627, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmCadProdutoBOMImportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 550)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadProdutoBOMImportar"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Importar BOM"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaItemFantasma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaGeraOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaMPHD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProduto.ResumeLayout(False)
        Me.grpProduto.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaItemFantasma As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaItemFantasma As System.Windows.Forms.Label
    Friend WithEvents picLegendaGeraOP As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaGeraOP As System.Windows.Forms.Label
    Friend WithEvents picLegendaMPHD As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaMPHD As System.Windows.Forms.Label
    Friend WithEvents grpProduto As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtProdutoPai As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblItemPai As System.Windows.Forms.Label
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents cboCodigoProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigoProduto As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents trvMain As System.Windows.Forms.TreeView
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
End Class
