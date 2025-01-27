<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadProdutoPrecoVendaRevisao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadProdutoPrecoVendaRevisao))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.trvMain = New System.Windows.Forms.TreeView()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnAjusteCustoTeorico = New Janus.Windows.EditControls.UIButton()
        Me.btnAjustePrecoCompra = New Janus.Windows.EditControls.UIButton()
        Me.btnAjustePrecoMinimo = New Janus.Windows.EditControls.UIButton()
        Me.btnAjustePrecoIdeal = New Janus.Windows.EditControls.UIButton()
        Me.txtAjustePrecoIdeal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAjustePrecoIdeal = New System.Windows.Forms.Label()
        Me.txtAjustePrecoMinimo = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAjustePrecoMinimo = New System.Windows.Forms.Label()
        Me.txtAjustePrecoCompra = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAjustePrecoCompra = New System.Windows.Forms.Label()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.txtAjusteCustoTeorico = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblAjusteCustoTeorico = New System.Windows.Forms.Label()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboRevisao = New Janus.Windows.EditControls.UIComboBox()
        Me.cboMarcaFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMarcaFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.cboRevisaoBase = New Janus.Windows.EditControls.UIComboBox()
        Me.lblRevisaoBase = New System.Windows.Forms.Label()
        Me.lblRevisao = New System.Windows.Forms.Label()
        Me.dtpDataInicio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(1067, 509)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.btnExcelGrid)
        Me.pagTabela.Controls.Add(Me.btnConfigurarGrid)
        Me.pagTabela.Controls.Add(Me.btnAgruparGrid)
        Me.pagTabela.Controls.Add(Me.grdListagem)
        Me.pagTabela.Controls.Add(Me.trvMain)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Controls.Add(Me.grpFiltro)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(1065, 486)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Revisão"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(425, 406)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 8
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(377, 406)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 7
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(401, 406)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 9
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.GroupRowFormatStyle.ForeColor = System.Drawing.Color.SteelBlue
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.Location = New System.Drawing.Point(376, 9)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(681, 414)
        Me.grdListagem.TabIndex = 2
        Me.grdListagem.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'trvMain
        '
        Me.trvMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvMain.CheckBoxes = True
        Me.trvMain.FullRowSelect = True
        Me.trvMain.ItemHeight = 20
        Me.trvMain.Location = New System.Drawing.Point(8, 116)
        Me.trvMain.Name = "trvMain"
        Me.trvMain.ShowLines = False
        Me.trvMain.ShowNodeToolTips = True
        Me.trvMain.Size = New System.Drawing.Size(359, 307)
        Me.trvMain.TabIndex = 1
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnAjusteCustoTeorico)
        Me.grpControl2.Controls.Add(Me.btnAjustePrecoCompra)
        Me.grpControl2.Controls.Add(Me.btnAjustePrecoMinimo)
        Me.grpControl2.Controls.Add(Me.btnAjustePrecoIdeal)
        Me.grpControl2.Controls.Add(Me.txtAjustePrecoIdeal)
        Me.grpControl2.Controls.Add(Me.lblAjustePrecoIdeal)
        Me.grpControl2.Controls.Add(Me.txtAjustePrecoMinimo)
        Me.grpControl2.Controls.Add(Me.lblAjustePrecoMinimo)
        Me.grpControl2.Controls.Add(Me.txtAjustePrecoCompra)
        Me.grpControl2.Controls.Add(Me.lblAjustePrecoCompra)
        Me.grpControl2.Controls.Add(Me.btnSalvar)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Controls.Add(Me.txtAjusteCustoTeorico)
        Me.grpControl2.Controls.Add(Me.lblAjusteCustoTeorico)
        Me.grpControl2.Location = New System.Drawing.Point(8, 426)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(1049, 51)
        Me.grpControl2.TabIndex = 3
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnAjusteCustoTeorico
        '
        Me.btnAjusteCustoTeorico.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnAjusteCustoTeorico.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.btnAjusteCustoTeorico.Location = New System.Drawing.Point(190, 18)
        Me.btnAjusteCustoTeorico.Name = "btnAjusteCustoTeorico"
        Me.btnAjusteCustoTeorico.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAjusteCustoTeorico.Size = New System.Drawing.Size(20, 20)
        Me.btnAjusteCustoTeorico.TabIndex = 2
        Me.btnAjusteCustoTeorico.TabStop = False
        Me.btnAjusteCustoTeorico.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAjustePrecoCompra
        '
        Me.btnAjustePrecoCompra.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnAjustePrecoCompra.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.btnAjustePrecoCompra.Location = New System.Drawing.Point(402, 18)
        Me.btnAjustePrecoCompra.Name = "btnAjustePrecoCompra"
        Me.btnAjustePrecoCompra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAjustePrecoCompra.Size = New System.Drawing.Size(20, 20)
        Me.btnAjustePrecoCompra.TabIndex = 5
        Me.btnAjustePrecoCompra.TabStop = False
        Me.btnAjustePrecoCompra.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAjustePrecoMinimo
        '
        Me.btnAjustePrecoMinimo.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnAjustePrecoMinimo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.btnAjustePrecoMinimo.Location = New System.Drawing.Point(609, 18)
        Me.btnAjustePrecoMinimo.Name = "btnAjustePrecoMinimo"
        Me.btnAjustePrecoMinimo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAjustePrecoMinimo.Size = New System.Drawing.Size(20, 20)
        Me.btnAjustePrecoMinimo.TabIndex = 8
        Me.btnAjustePrecoMinimo.TabStop = False
        Me.btnAjustePrecoMinimo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAjustePrecoIdeal
        '
        Me.btnAjustePrecoIdeal.Image = Global.INTERACTI.My.Resources.Resources.atualizar
        Me.btnAjustePrecoIdeal.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.btnAjustePrecoIdeal.Location = New System.Drawing.Point(806, 18)
        Me.btnAjustePrecoIdeal.Name = "btnAjustePrecoIdeal"
        Me.btnAjustePrecoIdeal.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAjustePrecoIdeal.Size = New System.Drawing.Size(20, 20)
        Me.btnAjustePrecoIdeal.TabIndex = 11
        Me.btnAjustePrecoIdeal.TabStop = False
        Me.btnAjustePrecoIdeal.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtAjustePrecoIdeal
        '
        Me.txtAjustePrecoIdeal.DecimalDigits = 2
        Me.txtAjustePrecoIdeal.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAjustePrecoIdeal.Location = New System.Drawing.Point(750, 18)
        Me.txtAjustePrecoIdeal.Name = "txtAjustePrecoIdeal"
        Me.txtAjustePrecoIdeal.Size = New System.Drawing.Size(57, 20)
        Me.txtAjustePrecoIdeal.TabIndex = 10
        Me.txtAjustePrecoIdeal.TabStop = False
        Me.txtAjustePrecoIdeal.Text = "0,00%"
        Me.txtAjustePrecoIdeal.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAjustePrecoIdeal
        '
        Me.lblAjustePrecoIdeal.AutoSize = True
        Me.lblAjustePrecoIdeal.BackColor = System.Drawing.Color.Transparent
        Me.lblAjustePrecoIdeal.Location = New System.Drawing.Point(635, 21)
        Me.lblAjustePrecoIdeal.Name = "lblAjustePrecoIdeal"
        Me.lblAjustePrecoIdeal.Size = New System.Drawing.Size(109, 14)
        Me.lblAjustePrecoIdeal.TabIndex = 9
        Me.lblAjustePrecoIdeal.Text = "% Ajuste Preço Ideal:"
        '
        'txtAjustePrecoMinimo
        '
        Me.txtAjustePrecoMinimo.DecimalDigits = 2
        Me.txtAjustePrecoMinimo.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAjustePrecoMinimo.Location = New System.Drawing.Point(553, 18)
        Me.txtAjustePrecoMinimo.Name = "txtAjustePrecoMinimo"
        Me.txtAjustePrecoMinimo.Size = New System.Drawing.Size(57, 20)
        Me.txtAjustePrecoMinimo.TabIndex = 7
        Me.txtAjustePrecoMinimo.TabStop = False
        Me.txtAjustePrecoMinimo.Text = "0,00%"
        Me.txtAjustePrecoMinimo.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAjustePrecoMinimo
        '
        Me.lblAjustePrecoMinimo.AutoSize = True
        Me.lblAjustePrecoMinimo.BackColor = System.Drawing.Color.Transparent
        Me.lblAjustePrecoMinimo.Location = New System.Drawing.Point(428, 21)
        Me.lblAjustePrecoMinimo.Name = "lblAjustePrecoMinimo"
        Me.lblAjustePrecoMinimo.Size = New System.Drawing.Size(119, 14)
        Me.lblAjustePrecoMinimo.TabIndex = 6
        Me.lblAjustePrecoMinimo.Text = "% Ajuste Preço Mínimo:"
        '
        'txtAjustePrecoCompra
        '
        Me.txtAjustePrecoCompra.DecimalDigits = 2
        Me.txtAjustePrecoCompra.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAjustePrecoCompra.Location = New System.Drawing.Point(346, 18)
        Me.txtAjustePrecoCompra.Name = "txtAjustePrecoCompra"
        Me.txtAjustePrecoCompra.Size = New System.Drawing.Size(57, 20)
        Me.txtAjustePrecoCompra.TabIndex = 4
        Me.txtAjustePrecoCompra.TabStop = False
        Me.txtAjustePrecoCompra.Text = "0,00%"
        Me.txtAjustePrecoCompra.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAjustePrecoCompra
        '
        Me.lblAjustePrecoCompra.AutoSize = True
        Me.lblAjustePrecoCompra.BackColor = System.Drawing.Color.Transparent
        Me.lblAjustePrecoCompra.Location = New System.Drawing.Point(216, 21)
        Me.lblAjustePrecoCompra.Name = "lblAjustePrecoCompra"
        Me.lblAjustePrecoCompra.Size = New System.Drawing.Size(124, 14)
        Me.lblAjustePrecoCompra.TabIndex = 3
        Me.lblAjustePrecoCompra.Text = "% Ajuste Preço Compra:"
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(852, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 12
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(949, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 13
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtAjusteCustoTeorico
        '
        Me.txtAjusteCustoTeorico.DecimalDigits = 2
        Me.txtAjusteCustoTeorico.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Percent
        Me.txtAjusteCustoTeorico.Location = New System.Drawing.Point(134, 18)
        Me.txtAjusteCustoTeorico.Name = "txtAjusteCustoTeorico"
        Me.txtAjusteCustoTeorico.Size = New System.Drawing.Size(57, 20)
        Me.txtAjusteCustoTeorico.TabIndex = 1
        Me.txtAjusteCustoTeorico.TabStop = False
        Me.txtAjusteCustoTeorico.Text = "0,00%"
        Me.txtAjusteCustoTeorico.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'lblAjusteCustoTeorico
        '
        Me.lblAjusteCustoTeorico.AutoSize = True
        Me.lblAjusteCustoTeorico.BackColor = System.Drawing.Color.Transparent
        Me.lblAjusteCustoTeorico.Location = New System.Drawing.Point(6, 21)
        Me.lblAjusteCustoTeorico.Name = "lblAjusteCustoTeorico"
        Me.lblAjusteCustoTeorico.Size = New System.Drawing.Size(122, 14)
        Me.lblAjusteCustoTeorico.TabIndex = 0
        Me.lblAjusteCustoTeorico.Text = "% Ajuste Custo Teórico:"
        '
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboRevisao)
        Me.grpFiltro.Controls.Add(Me.cboMarcaFiltro)
        Me.grpFiltro.Controls.Add(Me.lblMarcaFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.cboRevisaoBase)
        Me.grpFiltro.Controls.Add(Me.lblRevisaoBase)
        Me.grpFiltro.Controls.Add(Me.lblRevisao)
        Me.grpFiltro.Controls.Add(Me.dtpDataInicio)
        Me.grpFiltro.Controls.Add(Me.lblDataInicio)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(359, 104)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboRevisao
        '
        Me.cboRevisao.AutoSize = False
        Me.cboRevisao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboRevisao.Location = New System.Drawing.Point(10, 34)
        Me.cboRevisao.Name = "cboRevisao"
        Me.cboRevisao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboRevisao.Size = New System.Drawing.Size(119, 20)
        Me.cboRevisao.TabIndex = 1
        '
        'cboMarcaFiltro
        '
        Me.cboMarcaFiltro.AutoSize = False
        Me.cboMarcaFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMarcaFiltro.Location = New System.Drawing.Point(10, 74)
        Me.cboMarcaFiltro.Name = "cboMarcaFiltro"
        Me.cboMarcaFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMarcaFiltro.Size = New System.Drawing.Size(215, 20)
        Me.cboMarcaFiltro.TabIndex = 7
        '
        'lblMarcaFiltro
        '
        Me.lblMarcaFiltro.AutoSize = True
        Me.lblMarcaFiltro.BackColor = System.Drawing.Color.Transparent
        Me.lblMarcaFiltro.Location = New System.Drawing.Point(7, 57)
        Me.lblMarcaFiltro.Name = "lblMarcaFiltro"
        Me.lblMarcaFiltro.Size = New System.Drawing.Size(40, 14)
        Me.lblMarcaFiltro.TabIndex = 6
        Me.lblMarcaFiltro.Text = "Marca:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(259, 71)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 8
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboRevisaoBase
        '
        Me.cboRevisaoBase.AutoSize = False
        Me.cboRevisaoBase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboRevisaoBase.Location = New System.Drawing.Point(231, 34)
        Me.cboRevisaoBase.Name = "cboRevisaoBase"
        Me.cboRevisaoBase.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboRevisaoBase.Size = New System.Drawing.Size(119, 20)
        Me.cboRevisaoBase.TabIndex = 5
        '
        'lblRevisaoBase
        '
        Me.lblRevisaoBase.AutoSize = True
        Me.lblRevisaoBase.BackColor = System.Drawing.Color.Transparent
        Me.lblRevisaoBase.Location = New System.Drawing.Point(228, 17)
        Me.lblRevisaoBase.Name = "lblRevisaoBase"
        Me.lblRevisaoBase.Size = New System.Drawing.Size(77, 14)
        Me.lblRevisaoBase.TabIndex = 4
        Me.lblRevisaoBase.Text = "Revisão Base:"
        '
        'lblRevisao
        '
        Me.lblRevisao.AutoSize = True
        Me.lblRevisao.BackColor = System.Drawing.Color.Transparent
        Me.lblRevisao.Location = New System.Drawing.Point(6, 17)
        Me.lblRevisao.Name = "lblRevisao"
        Me.lblRevisao.Size = New System.Drawing.Size(49, 14)
        Me.lblRevisao.TabIndex = 0
        Me.lblRevisao.Text = "Revisão:"
        '
        'dtpDataInicio
        '
        '
        '
        '
        Me.dtpDataInicio.DropDownCalendar.Name = ""
        Me.dtpDataInicio.Location = New System.Drawing.Point(135, 34)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.Size = New System.Drawing.Size(90, 20)
        Me.dtpDataInicio.TabIndex = 3
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.BackColor = System.Drawing.Color.Transparent
        Me.lblDataInicio.Location = New System.Drawing.Point(132, 17)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(59, 14)
        Me.lblDataInicio.TabIndex = 2
        Me.lblDataInicio.Text = "Data Início:"
        '
        'frmCadProdutoPrecoVendaRevisao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 523)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadProdutoPrecoVendaRevisao"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Revisão - Tabela de Preço"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.grpControl2.PerformLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Private WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataInicio As System.Windows.Forms.Label
    Friend WithEvents dtpDataInicio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblAjusteCustoTeorico As System.Windows.Forms.Label
    Friend WithEvents lblRevisaoBase As System.Windows.Forms.Label
    Friend WithEvents txtAjusteCustoTeorico As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblRevisao As System.Windows.Forms.Label
    Friend WithEvents cboRevisaoBase As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents trvMain As System.Windows.Forms.TreeView
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Private WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtAjustePrecoIdeal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAjustePrecoIdeal As System.Windows.Forms.Label
    Friend WithEvents txtAjustePrecoMinimo As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAjustePrecoMinimo As System.Windows.Forms.Label
    Friend WithEvents txtAjustePrecoCompra As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblAjustePrecoCompra As System.Windows.Forms.Label
    Private WithEvents btnAjusteCustoTeorico As Janus.Windows.EditControls.UIButton
    Private WithEvents btnAjustePrecoCompra As Janus.Windows.EditControls.UIButton
    Private WithEvents btnAjustePrecoMinimo As Janus.Windows.EditControls.UIButton
    Private WithEvents btnAjustePrecoIdeal As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboRevisao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboMarcaFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMarcaFiltro As System.Windows.Forms.Label
End Class
