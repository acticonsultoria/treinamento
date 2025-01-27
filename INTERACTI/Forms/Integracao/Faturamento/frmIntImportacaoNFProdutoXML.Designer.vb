<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntImportacaoNFProdutoXML
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIntImportacaoNFProdutoXML))
        Dim grdRecebimento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdRecebimento_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdNF_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGridRecebimento = New System.Windows.Forms.Button()
        Me.btnAgruparGridRecebimento = New System.Windows.Forms.Button()
        Me.btnExcelGridXML = New System.Windows.Forms.Button()
        Me.btnAgruparGridXML = New System.Windows.Forms.Button()
        Me.btnConfigurarGridRecebimento = New System.Windows.Forms.Button()
        Me.btnConfigurarGridXML = New System.Windows.Forms.Button()
        Me.grpEntrega = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnCadastrarProduto = New System.Windows.Forms.Button()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.cboProduto = New Janus.Windows.EditControls.UIComboBox()
        Me.grdRecebimento = New Janus.Windows.GridEX.GridEX()
        Me.grpControleDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnConfirmar = New Janus.Windows.EditControls.UIButton()
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.grdNF = New Janus.Windows.GridEX.GridEX()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.grpEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEntrega.SuspendLayout()
        CType(Me.grdRecebimento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControleDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControleDados.SuspendLayout()
        CType(Me.grdNF, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(1001, 556)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.btnExcelGridRecebimento)
        Me.pagDados.Controls.Add(Me.btnAgruparGridRecebimento)
        Me.pagDados.Controls.Add(Me.btnExcelGridXML)
        Me.pagDados.Controls.Add(Me.btnAgruparGridXML)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridRecebimento)
        Me.pagDados.Controls.Add(Me.btnConfigurarGridXML)
        Me.pagDados.Controls.Add(Me.grpEntrega)
        Me.pagDados.Controls.Add(Me.grdRecebimento)
        Me.pagDados.Controls.Add(Me.grpControleDados)
        Me.pagDados.Controls.Add(Me.grdNF)
        Me.pagDados.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(999, 533)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Nota Fiscal - Produtos"
        '
        'btnExcelGridRecebimento
        '
        Me.btnExcelGridRecebimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridRecebimento.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridRecebimento.FlatAppearance.BorderSize = 0
        Me.btnExcelGridRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridRecebimento.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridRecebimento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridRecebimento.Location = New System.Drawing.Point(57, 453)
        Me.btnExcelGridRecebimento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridRecebimento.Name = "btnExcelGridRecebimento"
        Me.btnExcelGridRecebimento.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridRecebimento.TabIndex = 8
        Me.btnExcelGridRecebimento.TabStop = False
        Me.btnExcelGridRecebimento.UseVisualStyleBackColor = False
        '
        'btnAgruparGridRecebimento
        '
        Me.btnAgruparGridRecebimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridRecebimento.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridRecebimento.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridRecebimento.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridRecebimento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridRecebimento.Location = New System.Drawing.Point(33, 453)
        Me.btnAgruparGridRecebimento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridRecebimento.Name = "btnAgruparGridRecebimento"
        Me.btnAgruparGridRecebimento.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridRecebimento.TabIndex = 7
        Me.btnAgruparGridRecebimento.TabStop = False
        Me.btnAgruparGridRecebimento.UseVisualStyleBackColor = False
        '
        'btnExcelGridXML
        '
        Me.btnExcelGridXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridXML.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridXML.FlatAppearance.BorderSize = 0
        Me.btnExcelGridXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridXML.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridXML.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridXML.Location = New System.Drawing.Point(57, 181)
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
        Me.btnAgruparGridXML.Location = New System.Drawing.Point(33, 181)
        Me.btnAgruparGridXML.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridXML.Name = "btnAgruparGridXML"
        Me.btnAgruparGridXML.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridXML.TabIndex = 2
        Me.btnAgruparGridXML.TabStop = False
        Me.btnAgruparGridXML.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridRecebimento
        '
        Me.btnConfigurarGridRecebimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridRecebimento.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridRecebimento.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridRecebimento.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridRecebimento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridRecebimento.Location = New System.Drawing.Point(9, 453)
        Me.btnConfigurarGridRecebimento.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridRecebimento.Name = "btnConfigurarGridRecebimento"
        Me.btnConfigurarGridRecebimento.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridRecebimento.TabIndex = 6
        Me.btnConfigurarGridRecebimento.TabStop = False
        Me.btnConfigurarGridRecebimento.UseVisualStyleBackColor = False
        '
        'btnConfigurarGridXML
        '
        Me.btnConfigurarGridXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridXML.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridXML.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridXML.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridXML.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridXML.Location = New System.Drawing.Point(9, 181)
        Me.btnConfigurarGridXML.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridXML.Name = "btnConfigurarGridXML"
        Me.btnConfigurarGridXML.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridXML.TabIndex = 1
        Me.btnConfigurarGridXML.TabStop = False
        Me.btnConfigurarGridXML.UseVisualStyleBackColor = False
        '
        'grpEntrega
        '
        Me.grpEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpEntrega.BackColor = System.Drawing.Color.Transparent
        Me.grpEntrega.Controls.Add(Me.lblLote)
        Me.grpEntrega.Controls.Add(Me.txtDescricao)
        Me.grpEntrega.Controls.Add(Me.btnCadastrarProduto)
        Me.grpEntrega.Controls.Add(Me.lblProduto)
        Me.grpEntrega.Controls.Add(Me.btnExcluir)
        Me.grpEntrega.Controls.Add(Me.btnInserir)
        Me.grpEntrega.Controls.Add(Me.cboProduto)
        Me.grpEntrega.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEntrega.Location = New System.Drawing.Point(8, 205)
        Me.grpEntrega.Name = "grpEntrega"
        Me.grpEntrega.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEntrega.Size = New System.Drawing.Size(983, 74)
        Me.grpEntrega.TabIndex = 4
        Me.grpEntrega.VisualStyleManager = Me.vsmMain
        '
        'lblLote
        '
        Me.lblLote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLote.AutoSize = True
        Me.lblLote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLote.Location = New System.Drawing.Point(304, 13)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(59, 14)
        Me.lblLote.TabIndex = 28
        Me.lblLote.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(307, 30)
        Me.txtDescricao.MaxLength = 50
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(438, 20)
        Me.txtDescricao.TabIndex = 29
        '
        'btnCadastrarProduto
        '
        Me.btnCadastrarProduto.FlatAppearance.BorderSize = 0
        Me.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarProduto.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnCadastrarProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCadastrarProduto.Location = New System.Drawing.Point(9, 14)
        Me.btnCadastrarProduto.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCadastrarProduto.Name = "btnCadastrarProduto"
        Me.btnCadastrarProduto.Size = New System.Drawing.Size(13, 13)
        Me.btnCadastrarProduto.TabIndex = 7
        Me.btnCadastrarProduto.TabStop = False
        Me.btnCadastrarProduto.UseVisualStyleBackColor = True
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblProduto.Location = New System.Drawing.Point(25, 13)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 8
        Me.lblProduto.Text = "Produto:"
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(883, 41)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 45
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = CType(resources.GetObject("btnInserir.Image"), System.Drawing.Image)
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(883, 12)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 44
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboProduto
        '
        Me.cboProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboProduto.AutoSize = False
        Me.cboProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProduto.Location = New System.Drawing.Point(9, 30)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboProduto.Size = New System.Drawing.Size(292, 20)
        Me.cboProduto.TabIndex = 10
        '
        'grdRecebimento
        '
        Me.grdRecebimento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdRecebimento.AlternatingColors = True
        Me.grdRecebimento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRecebimento.AutoEdit = True
        grdRecebimento_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdRecebimento_DesignTimeLayout_Reference_0.Instance"), Object)
        grdRecebimento_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdRecebimento_DesignTimeLayout_Reference_0})
        grdRecebimento_DesignTimeLayout.LayoutString = resources.GetString("grdRecebimento_DesignTimeLayout.LayoutString")
        Me.grdRecebimento.DesignTimeLayout = grdRecebimento_DesignTimeLayout
        Me.grdRecebimento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdRecebimento.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdRecebimento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdRecebimento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdRecebimento.FrozenColumns = 2
        Me.grdRecebimento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdRecebimento.GroupByBoxVisible = False
        Me.grdRecebimento.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdRecebimento.Location = New System.Drawing.Point(8, 284)
        Me.grdRecebimento.Name = "grdRecebimento"
        Me.grdRecebimento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdRecebimento.RecordNavigator = True
        Me.grdRecebimento.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdRecebimento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdRecebimento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdRecebimento.Size = New System.Drawing.Size(983, 186)
        Me.grdRecebimento.TabIndex = 5
        Me.grdRecebimento.TabStop = False
        Me.grdRecebimento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdRecebimento.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdRecebimento.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdRecebimento.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdRecebimento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdRecebimento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdRecebimento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdRecebimento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdRecebimento.VisualStyleManager = Me.vsmMain
        '
        'grpControleDados
        '
        Me.grpControleDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControleDados.BackColor = System.Drawing.Color.Transparent
        Me.grpControleDados.Controls.Add(Me.btnConfirmar)
        Me.grpControleDados.Controls.Add(Me.btnCancelar)
        Me.grpControleDados.Location = New System.Drawing.Point(8, 473)
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
        grdNF_DesignTimeLayout.LayoutString = resources.GetString("grdNF_DesignTimeLayout.LayoutString")
        Me.grdNF.DesignTimeLayout = grdNF_DesignTimeLayout
        Me.grdNF.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdNF.FocusCellFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdNF.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdNF.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdNF.FrozenColumns = 1
        Me.grdNF.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdNF.GroupByBoxVisible = False
        Me.grdNF.Location = New System.Drawing.Point(8, 8)
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
        Me.grdNF.Size = New System.Drawing.Size(983, 190)
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
        'frmIntImportacaoNFProdutoXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 571)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmIntImportacaoNFProdutoXML"
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
        CType(Me.grdRecebimento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControleDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControleDados.ResumeLayout(False)
        CType(Me.grdNF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControleDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnConfirmar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdNF As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpEntrega As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents cboProduto As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdRecebimento As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnCadastrarProduto As System.Windows.Forms.Button
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnConfigurarGridXML As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGridRecebimento As System.Windows.Forms.Button
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents btnExcelGridXML As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridXML As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridRecebimento As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridRecebimento As System.Windows.Forms.Button
End Class
