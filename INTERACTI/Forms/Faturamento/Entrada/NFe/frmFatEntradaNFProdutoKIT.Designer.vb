<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEntradaNFProdutoKIT
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdComposicao_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdComposicao_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEntradaNFProdutoKIT))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtQuantidadeProduto = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidadeProduto = New System.Windows.Forms.Label()
        Me.txtCodigoProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblCodigoProduto = New System.Windows.Forms.Label()
        Me.grpComposicao = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtQuantidade = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.txtLote = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboComponenteOpcional = New Janus.Windows.EditControls.UIComboBox()
        Me.lblComponenteOpcional = New System.Windows.Forms.Label()
        Me.cboComponenteOriginal = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.lblComponenteOriginal = New System.Windows.Forms.Label()
        Me.grdComposicao = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpComposicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpComposicao.SuspendLayout()
        CType(Me.grdComposicao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
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
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(762, 497)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpDados)
        Me.pagTabela.Controls.Add(Me.grpComposicao)
        Me.pagTabela.Controls.Add(Me.grdComposicao)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(760, 474)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Lista de Componentes"
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtQuantidadeProduto)
        Me.grpDados.Controls.Add(Me.lblQuantidadeProduto)
        Me.grpDados.Controls.Add(Me.txtCodigoProduto)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Controls.Add(Me.lblCodigoProduto)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(744, 64)
        Me.grpDados.TabIndex = 0
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtQuantidadeProduto
        '
        Me.txtQuantidadeProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantidadeProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtQuantidadeProduto.DecimalDigits = 4
        Me.txtQuantidadeProduto.Location = New System.Drawing.Point(635, 34)
        Me.txtQuantidadeProduto.Name = "txtQuantidadeProduto"
        Me.txtQuantidadeProduto.ReadOnly = True
        Me.txtQuantidadeProduto.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidadeProduto.TabIndex = 16
        Me.txtQuantidadeProduto.TabStop = False
        Me.txtQuantidadeProduto.Text = "0,0000"
        Me.txtQuantidadeProduto.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidadeProduto
        '
        Me.lblQuantidadeProduto.AutoSize = True
        Me.lblQuantidadeProduto.Location = New System.Drawing.Point(632, 17)
        Me.lblQuantidadeProduto.Name = "lblQuantidadeProduto"
        Me.lblQuantidadeProduto.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidadeProduto.TabIndex = 15
        Me.lblQuantidadeProduto.Text = "Quantidade:"
        '
        'txtCodigoProduto
        '
        Me.txtCodigoProduto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoProduto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodigoProduto.Location = New System.Drawing.Point(9, 34)
        Me.txtCodigoProduto.MaxLength = 250
        Me.txtCodigoProduto.Name = "txtCodigoProduto"
        Me.txtCodigoProduto.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigoProduto.TabIndex = 1
        Me.txtCodigoProduto.TabStop = False
        Me.txtCodigoProduto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDescricao.Location = New System.Drawing.Point(135, 34)
        Me.txtDescricao.MaxLength = 250
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(494, 20)
        Me.txtDescricao.TabIndex = 3
        Me.txtDescricao.TabStop = False
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDescricao.Location = New System.Drawing.Point(132, 17)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição:"
        '
        'lblCodigoProduto
        '
        Me.lblCodigoProduto.AutoSize = True
        Me.lblCodigoProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCodigoProduto.Location = New System.Drawing.Point(6, 17)
        Me.lblCodigoProduto.Name = "lblCodigoProduto"
        Me.lblCodigoProduto.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigoProduto.TabIndex = 0
        Me.lblCodigoProduto.Text = "Código:"
        '
        'grpComposicao
        '
        Me.grpComposicao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpComposicao.BackColor = System.Drawing.Color.Transparent
        Me.grpComposicao.Controls.Add(Me.txtQuantidade)
        Me.grpComposicao.Controls.Add(Me.lblQuantidade)
        Me.grpComposicao.Controls.Add(Me.lblLote)
        Me.grpComposicao.Controls.Add(Me.txtLote)
        Me.grpComposicao.Controls.Add(Me.cboComponenteOpcional)
        Me.grpComposicao.Controls.Add(Me.lblComponenteOpcional)
        Me.grpComposicao.Controls.Add(Me.cboComponenteOriginal)
        Me.grpComposicao.Controls.Add(Me.btnExcluir)
        Me.grpComposicao.Controls.Add(Me.btnInserir)
        Me.grpComposicao.Controls.Add(Me.lblComponenteOriginal)
        Me.grpComposicao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpComposicao.Location = New System.Drawing.Point(8, 70)
        Me.grpComposicao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpComposicao.Name = "grpComposicao"
        Me.grpComposicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpComposicao.Size = New System.Drawing.Size(744, 64)
        Me.grpComposicao.TabIndex = 1
        Me.grpComposicao.VisualStyleManager = Me.vsmMain
        '
        'txtQuantidade
        '
        Me.txtQuantidade.DecimalDigits = 4
        Me.txtQuantidade.Location = New System.Drawing.Point(417, 34)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidade.TabIndex = 7
        Me.txtQuantidade.Text = "0,0000"
        Me.txtQuantidade.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(414, 17)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 14)
        Me.lblQuantidade.TabIndex = 6
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLote.Location = New System.Drawing.Point(258, 17)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(31, 14)
        Me.lblLote.TabIndex = 4
        Me.lblLote.Text = "Lote:"
        '
        'txtLote
        '
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Location = New System.Drawing.Point(261, 34)
        Me.txtLote.MaxLength = 50
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(150, 20)
        Me.txtLote.TabIndex = 5
        '
        'cboComponenteOpcional
        '
        Me.cboComponenteOpcional.AutoSize = False
        Me.cboComponenteOpcional.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboComponenteOpcional.Location = New System.Drawing.Point(135, 34)
        Me.cboComponenteOpcional.Name = "cboComponenteOpcional"
        Me.cboComponenteOpcional.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboComponenteOpcional.Size = New System.Drawing.Size(120, 20)
        Me.cboComponenteOpcional.TabIndex = 3
        '
        'lblComponenteOpcional
        '
        Me.lblComponenteOpcional.AutoSize = True
        Me.lblComponenteOpcional.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblComponenteOpcional.Location = New System.Drawing.Point(132, 17)
        Me.lblComponenteOpcional.Name = "lblComponenteOpcional"
        Me.lblComponenteOpcional.Size = New System.Drawing.Size(115, 14)
        Me.lblComponenteOpcional.TabIndex = 2
        Me.lblComponenteOpcional.Text = "Componente Opcional:"
        '
        'cboComponenteOriginal
        '
        Me.cboComponenteOriginal.AutoSize = False
        Me.cboComponenteOriginal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboComponenteOriginal.Location = New System.Drawing.Point(9, 34)
        Me.cboComponenteOriginal.Name = "cboComponenteOriginal"
        Me.cboComponenteOriginal.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboComponenteOriginal.Size = New System.Drawing.Size(120, 20)
        Me.cboComponenteOriginal.TabIndex = 1
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(644, 31)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 9
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(547, 31)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 8
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblComponenteOriginal
        '
        Me.lblComponenteOriginal.AutoSize = True
        Me.lblComponenteOriginal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblComponenteOriginal.Location = New System.Drawing.Point(6, 17)
        Me.lblComponenteOriginal.Name = "lblComponenteOriginal"
        Me.lblComponenteOriginal.Size = New System.Drawing.Size(109, 14)
        Me.lblComponenteOriginal.TabIndex = 0
        Me.lblComponenteOriginal.Text = "Componente Original:"
        '
        'grdComposicao
        '
        Me.grdComposicao.AllowDrop = True
        Me.grdComposicao.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdComposicao.AlternatingColors = True
        Me.grdComposicao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdComposicao.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        grdComposicao_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdComposicao_DesignTimeLayout_Reference_0.Instance"), Object)
        grdComposicao_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdComposicao_DesignTimeLayout_Reference_0})
        grdComposicao_DesignTimeLayout.LayoutString = resources.GetString("grdComposicao_DesignTimeLayout.LayoutString")
        Me.grdComposicao.DesignTimeLayout = grdComposicao_DesignTimeLayout
        Me.grdComposicao.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdComposicao.FocusCellFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdComposicao.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdComposicao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdComposicao.FrozenColumns = 3
        Me.grdComposicao.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdComposicao.GroupByBoxVisible = False
        Me.grdComposicao.Location = New System.Drawing.Point(8, 145)
        Me.grdComposicao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdComposicao.Name = "grdComposicao"
        Me.grdComposicao.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdComposicao.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdComposicao.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdComposicao.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdComposicao.Size = New System.Drawing.Size(744, 266)
        Me.grdComposicao.TabIndex = 2
        Me.grdComposicao.TabStop = False
        Me.grdComposicao.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdComposicao.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdComposicao.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdComposicao.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdComposicao.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 414)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(744, 51)
        Me.grpControl2.TabIndex = 3
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(644, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmFatEntradaNFProdutoKIT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 511)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEntradaNFProdutoKIT"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Composição do KIT"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpComposicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpComposicao.ResumeLayout(False)
        Me.grpComposicao.PerformLayout()
        CType(Me.grdComposicao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdComposicao As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpComposicao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboComponenteOpcional As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblComponenteOpcional As System.Windows.Forms.Label
    Friend WithEvents cboComponenteOriginal As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblComponenteOriginal As System.Windows.Forms.Label
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents lblCodigoProduto As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents txtLote As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtQuantidadeProduto As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidadeProduto As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
End Class
