<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrFinDespesaCartaoCredito
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrFinDespesaCartaoCredito))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnPagar = New Janus.Windows.EditControls.UIButton()
        Me.cboBandeiraFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblBandeiraFiltro = New System.Windows.Forms.Label()
        Me.btnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.cboFuncionarioPortadorFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFuncionarioPortadorFiltro = New System.Windows.Forms.Label()
        Me.cboCartaoCreditoFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCartaoCreditoFiltro = New System.Windows.Forms.Label()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblFaturaAtraso = New System.Windows.Forms.Label()
        Me.picFaturaAtraso = New System.Windows.Forms.PictureBox()
        Me.picFaturaPaga = New System.Windows.Forms.PictureBox()
        Me.lblFaturaAberto = New System.Windows.Forms.Label()
        Me.picFaturaAberto = New System.Windows.Forms.PictureBox()
        Me.lblFaturaPaga = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImprimir = New Janus.Windows.EditControls.UIButton()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picFaturaAtraso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFaturaPaga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFaturaAberto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
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
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(1000, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.btnExcelGrid)
        Me.pagListagem.Controls.Add(Me.btnAgruparGrid)
        Me.pagListagem.Controls.Add(Me.btnConfigurarGrid)
        Me.pagListagem.Controls.Add(Me.grdListagem)
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.grpLegenda)
        Me.pagListagem.Controls.Add(Me.grpControle)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(998, 543)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "Controle de Cartão de Crédito"
        '
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(57, 463)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 87
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(33, 463)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 3
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(9, 463)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 1
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Location = New System.Drawing.Point(8, 76)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(982, 401)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnPagar)
        Me.grpFiltro.Controls.Add(Me.cboBandeiraFiltro)
        Me.grpFiltro.Controls.Add(Me.lblBandeiraFiltro)
        Me.grpFiltro.Controls.Add(Me.btnCancelar)
        Me.grpFiltro.Controls.Add(Me.cboFuncionarioPortadorFiltro)
        Me.grpFiltro.Controls.Add(Me.lblFuncionarioPortadorFiltro)
        Me.grpFiltro.Controls.Add(Me.cboCartaoCreditoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCartaoCreditoFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(982, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnPagar
        '
        Me.btnPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPagar.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnPagar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnPagar.Location = New System.Drawing.Point(785, 31)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(91, 23)
        Me.btnPagar.TabIndex = 6
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboBandeiraFiltro
        '
        Me.cboBandeiraFiltro.AutoSize = False
        Me.cboBandeiraFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboBandeiraFiltro.Location = New System.Drawing.Point(9, 34)
        Me.cboBandeiraFiltro.Name = "cboBandeiraFiltro"
        Me.cboBandeiraFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboBandeiraFiltro.Size = New System.Drawing.Size(218, 20)
        Me.cboBandeiraFiltro.TabIndex = 1
        '
        'lblBandeiraFiltro
        '
        Me.lblBandeiraFiltro.AutoSize = True
        Me.lblBandeiraFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblBandeiraFiltro.Name = "lblBandeiraFiltro"
        Me.lblBandeiraFiltro.Size = New System.Drawing.Size(53, 14)
        Me.lblBandeiraFiltro.TabIndex = 0
        Me.lblBandeiraFiltro.Text = "Bandeira:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = Global.INTERACTI.My.Resources.Resources.cancelar
        Me.btnCancelar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCancelar.Location = New System.Drawing.Point(882, 31)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(91, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboFuncionarioPortadorFiltro
        '
        Me.cboFuncionarioPortadorFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFuncionarioPortadorFiltro.AutoSize = False
        Me.cboFuncionarioPortadorFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "SIM"
        UiComboBoxItem1.Value = True
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "NÃO"
        UiComboBoxItem2.Value = False
        Me.cboFuncionarioPortadorFiltro.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2})
        Me.cboFuncionarioPortadorFiltro.Location = New System.Drawing.Point(549, 34)
        Me.cboFuncionarioPortadorFiltro.Name = "cboFuncionarioPortadorFiltro"
        Me.cboFuncionarioPortadorFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboFuncionarioPortadorFiltro.Size = New System.Drawing.Size(208, 20)
        Me.cboFuncionarioPortadorFiltro.TabIndex = 5
        '
        'lblFuncionarioPortadorFiltro
        '
        Me.lblFuncionarioPortadorFiltro.AutoSize = True
        Me.lblFuncionarioPortadorFiltro.Location = New System.Drawing.Point(546, 17)
        Me.lblFuncionarioPortadorFiltro.Name = "lblFuncionarioPortadorFiltro"
        Me.lblFuncionarioPortadorFiltro.Size = New System.Drawing.Size(110, 14)
        Me.lblFuncionarioPortadorFiltro.TabIndex = 4
        Me.lblFuncionarioPortadorFiltro.Text = "Funcionário Portador:"
        '
        'cboCartaoCreditoFiltro
        '
        Me.cboCartaoCreditoFiltro.AutoSize = False
        Me.cboCartaoCreditoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCartaoCreditoFiltro.Location = New System.Drawing.Point(233, 34)
        Me.cboCartaoCreditoFiltro.Name = "cboCartaoCreditoFiltro"
        Me.cboCartaoCreditoFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCartaoCreditoFiltro.Size = New System.Drawing.Size(310, 20)
        Me.cboCartaoCreditoFiltro.TabIndex = 3
        '
        'lblCartaoCreditoFiltro
        '
        Me.lblCartaoCreditoFiltro.AutoSize = True
        Me.lblCartaoCreditoFiltro.Location = New System.Drawing.Point(230, 17)
        Me.lblCartaoCreditoFiltro.Name = "lblCartaoCreditoFiltro"
        Me.lblCartaoCreditoFiltro.Size = New System.Drawing.Size(91, 14)
        Me.lblCartaoCreditoFiltro.TabIndex = 2
        Me.lblCartaoCreditoFiltro.Text = "Cartão de Crédito"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.lblFaturaAtraso)
        Me.grpLegenda.Controls.Add(Me.picFaturaAtraso)
        Me.grpLegenda.Controls.Add(Me.picFaturaPaga)
        Me.grpLegenda.Controls.Add(Me.lblFaturaAberto)
        Me.grpLegenda.Controls.Add(Me.picFaturaAberto)
        Me.grpLegenda.Controls.Add(Me.lblFaturaPaga)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 483)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(318, 51)
        Me.grpLegenda.TabIndex = 4
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'lblFaturaAtraso
        '
        Me.lblFaturaAtraso.AutoSize = True
        Me.lblFaturaAtraso.Location = New System.Drawing.Point(233, 21)
        Me.lblFaturaAtraso.Name = "lblFaturaAtraso"
        Me.lblFaturaAtraso.Size = New System.Drawing.Size(80, 14)
        Me.lblFaturaAtraso.TabIndex = 2
        Me.lblFaturaAtraso.Text = "Fatura Vencida"
        '
        'picFaturaAtraso
        '
        Me.picFaturaAtraso.BackColor = System.Drawing.Color.Firebrick
        Me.picFaturaAtraso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFaturaAtraso.Location = New System.Drawing.Point(214, 21)
        Me.picFaturaAtraso.Name = "picFaturaAtraso"
        Me.picFaturaAtraso.Size = New System.Drawing.Size(13, 14)
        Me.picFaturaAtraso.TabIndex = 16
        Me.picFaturaAtraso.TabStop = False
        '
        'picFaturaPaga
        '
        Me.picFaturaPaga.BackColor = System.Drawing.Color.ForestGreen
        Me.picFaturaPaga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFaturaPaga.Location = New System.Drawing.Point(124, 21)
        Me.picFaturaPaga.Name = "picFaturaPaga"
        Me.picFaturaPaga.Size = New System.Drawing.Size(13, 14)
        Me.picFaturaPaga.TabIndex = 14
        Me.picFaturaPaga.TabStop = False
        '
        'lblFaturaAberto
        '
        Me.lblFaturaAberto.AutoSize = True
        Me.lblFaturaAberto.Location = New System.Drawing.Point(28, 21)
        Me.lblFaturaAberto.Name = "lblFaturaAberto"
        Me.lblFaturaAberto.Size = New System.Drawing.Size(90, 14)
        Me.lblFaturaAberto.TabIndex = 1
        Me.lblFaturaAberto.Text = "Fatura em Aberto"
        '
        'picFaturaAberto
        '
        Me.picFaturaAberto.BackColor = System.Drawing.Color.SteelBlue
        Me.picFaturaAberto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFaturaAberto.Location = New System.Drawing.Point(9, 21)
        Me.picFaturaAberto.Name = "picFaturaAberto"
        Me.picFaturaAberto.Size = New System.Drawing.Size(13, 14)
        Me.picFaturaAberto.TabIndex = 8
        Me.picFaturaAberto.TabStop = False
        '
        'lblFaturaPaga
        '
        Me.lblFaturaPaga.AutoSize = True
        Me.lblFaturaPaga.Location = New System.Drawing.Point(143, 21)
        Me.lblFaturaPaga.Name = "lblFaturaPaga"
        Me.lblFaturaPaga.Size = New System.Drawing.Size(65, 14)
        Me.lblFaturaPaga.TabIndex = 0
        Me.lblFaturaPaga.Text = "Fatura Paga"
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnImprimir)
        Me.grpControle.Controls.Add(Me.lblCongelarColuna)
        Me.grpControle.Controls.Add(Me.cboCongelarColuna)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(335, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(655, 51)
        Me.grpControle.TabIndex = 5
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = Global.INTERACTI.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImprimir.Location = New System.Drawing.Point(458, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(91, 23)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 0
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 1
        Me.cboCongelarColuna.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(555, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrFinDespesaCartaoCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFinDespesaCartaoCredito"
        Me.Size = New System.Drawing.Size(1000, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picFaturaAtraso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFaturaPaga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFaturaAberto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.grpControle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picFaturaPaga As System.Windows.Forms.PictureBox
    Friend WithEvents lblFaturaAberto As System.Windows.Forms.Label
    Friend WithEvents picFaturaAberto As System.Windows.Forms.PictureBox
    Friend WithEvents lblFaturaPaga As System.Windows.Forms.Label
    Friend WithEvents cboCartaoCreditoFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCartaoCreditoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblFaturaAtraso As System.Windows.Forms.Label
    Friend WithEvents picFaturaAtraso As System.Windows.Forms.PictureBox
    Friend WithEvents cboFuncionarioPortadorFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblFuncionarioPortadorFiltro As System.Windows.Forms.Label
    Friend WithEvents cboBandeiraFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblBandeiraFiltro As System.Windows.Forms.Label
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnPagar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnImprimir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button

End Class
