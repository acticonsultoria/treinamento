<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrdOrdemProducaoImportarOrdemProducao
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
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrdOrdemProducaoImportarOrdemProducao))
        Dim grdListagem_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpImportacao = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtOrdemProducaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOrdemProducaoFiltro = New System.Windows.Forms.Label()
        Me.btnProcurarCliente = New System.Windows.Forms.Button()
        Me.cboClienteFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.dtpDataTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataInicioFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnImportar = New Janus.Windows.EditControls.UIButton()
        Me.chkImportarServicoExterno = New Janus.Windows.EditControls.UICheckBox()
        Me.chkMarcarTodos = New Janus.Windows.EditControls.UICheckBox()
        Me.chkImportarProcessoProdutivo = New Janus.Windows.EditControls.UICheckBox()
        Me.chkImportarEstruturaProduto = New Janus.Windows.EditControls.UICheckBox()
        Me.chkImportarListaMaterial = New Janus.Windows.EditControls.UICheckBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.cboImportarEstrutura = New Janus.Windows.EditControls.UIComboBox()
        Me.lblImportarEstrutura = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpImportacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpImportacao.SuspendLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl2.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(916, 509)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grdListagem)
        Me.pagTabela.Controls.Add(Me.grpImportacao)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(914, 486)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Importação"
        '
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.AutoEdit = True
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_1.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0, grdListagem_DesignTimeLayout_Reference_1})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.DynamicFiltering = True
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.FrozenColumns = 4
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Hierarchical = True
        Me.grdListagem.Location = New System.Drawing.Point(8, 77)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(898, 313)
        Me.grdListagem.TabIndex = 3
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdListagem.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpImportacao
        '
        Me.grpImportacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpImportacao.BackColor = System.Drawing.Color.Transparent
        Me.grpImportacao.Controls.Add(Me.lblImportarEstrutura)
        Me.grpImportacao.Controls.Add(Me.cboImportarEstrutura)
        Me.grpImportacao.Controls.Add(Me.txtOrdemProducaoFiltro)
        Me.grpImportacao.Controls.Add(Me.lblOrdemProducaoFiltro)
        Me.grpImportacao.Controls.Add(Me.btnProcurarCliente)
        Me.grpImportacao.Controls.Add(Me.cboClienteFiltro)
        Me.grpImportacao.Controls.Add(Me.lblCliente)
        Me.grpImportacao.Controls.Add(Me.dtpDataTerminoFiltro)
        Me.grpImportacao.Controls.Add(Me.dtpDataInicioFiltro)
        Me.grpImportacao.Controls.Add(Me.lblDataInicioFiltro)
        Me.grpImportacao.Controls.Add(Me.btnFiltrar)
        Me.grpImportacao.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpImportacao.Location = New System.Drawing.Point(8, 5)
        Me.grpImportacao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpImportacao.Name = "grpImportacao"
        Me.grpImportacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpImportacao.Size = New System.Drawing.Size(898, 65)
        Me.grpImportacao.TabIndex = 0
        Me.grpImportacao.VisualStyleManager = Me.vsmMain
        '
        'txtOrdemProducaoFiltro
        '
        Me.txtOrdemProducaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdemProducaoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtOrdemProducaoFiltro.MaxLength = 60
        Me.txtOrdemProducaoFiltro.Name = "txtOrdemProducaoFiltro"
        Me.txtOrdemProducaoFiltro.Size = New System.Drawing.Size(88, 20)
        Me.txtOrdemProducaoFiltro.TabIndex = 23
        '
        'lblOrdemProducaoFiltro
        '
        Me.lblOrdemProducaoFiltro.AutoSize = True
        Me.lblOrdemProducaoFiltro.BackColor = System.Drawing.Color.Transparent
        Me.lblOrdemProducaoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblOrdemProducaoFiltro.Name = "lblOrdemProducaoFiltro"
        Me.lblOrdemProducaoFiltro.Size = New System.Drawing.Size(91, 14)
        Me.lblOrdemProducaoFiltro.TabIndex = 24
        Me.lblOrdemProducaoFiltro.Text = "Ordem Produção:"
        '
        'btnProcurarCliente
        '
        Me.btnProcurarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarCliente.FlatAppearance.BorderSize = 0
        Me.btnProcurarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCliente.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCliente.Location = New System.Drawing.Point(672, 16)
        Me.btnProcurarCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProcurarCliente.Name = "btnProcurarCliente"
        Me.btnProcurarCliente.Size = New System.Drawing.Size(17, 16)
        Me.btnProcurarCliente.TabIndex = 22
        Me.btnProcurarCliente.TabStop = False
        Me.btnProcurarCliente.UseVisualStyleBackColor = True
        '
        'cboClienteFiltro
        '
        Me.cboClienteFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboClienteFiltro.AutoSize = False
        Me.cboClienteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboClienteFiltro.Location = New System.Drawing.Point(311, 34)
        Me.cboClienteFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboClienteFiltro.Name = "cboClienteFiltro"
        Me.cboClienteFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboClienteFiltro.Size = New System.Drawing.Size(378, 20)
        Me.cboClienteFiltro.TabIndex = 3
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(308, 17)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 21
        Me.lblCliente.Text = "Cliente:"
        '
        'dtpDataTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataTerminoFiltro.DropDownCalendar.FirstMonth = New Date(2023, 4, 1, 0, 0, 0, 0)
        Me.dtpDataTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataTerminoFiltro.Location = New System.Drawing.Point(207, 34)
        Me.dtpDataTerminoFiltro.Name = "dtpDataTerminoFiltro"
        Me.dtpDataTerminoFiltro.ShowCheckBox = True
        Me.dtpDataTerminoFiltro.Size = New System.Drawing.Size(98, 20)
        Me.dtpDataTerminoFiltro.TabIndex = 2
        Me.dtpDataTerminoFiltro.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'dtpDataInicioFiltro
        '
        '
        '
        '
        Me.dtpDataInicioFiltro.DropDownCalendar.FirstMonth = New Date(2023, 4, 1, 0, 0, 0, 0)
        Me.dtpDataInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataInicioFiltro.Location = New System.Drawing.Point(103, 34)
        Me.dtpDataInicioFiltro.Name = "dtpDataInicioFiltro"
        Me.dtpDataInicioFiltro.ShowCheckBox = True
        Me.dtpDataInicioFiltro.Size = New System.Drawing.Size(98, 20)
        Me.dtpDataInicioFiltro.TabIndex = 1
        Me.dtpDataInicioFiltro.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'lblDataInicioFiltro
        '
        Me.lblDataInicioFiltro.AutoSize = True
        Me.lblDataInicioFiltro.Location = New System.Drawing.Point(100, 17)
        Me.lblDataInicioFiltro.Name = "lblDataInicioFiltro"
        Me.lblDataInicioFiltro.Size = New System.Drawing.Size(59, 14)
        Me.lblDataInicioFiltro.TabIndex = 9
        Me.lblDataInicioFiltro.Text = "Data Início:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(801, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 4
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnImportar)
        Me.grpControl2.Controls.Add(Me.chkImportarServicoExterno)
        Me.grpControl2.Controls.Add(Me.chkMarcarTodos)
        Me.grpControl2.Controls.Add(Me.chkImportarProcessoProdutivo)
        Me.grpControl2.Controls.Add(Me.chkImportarEstruturaProduto)
        Me.grpControl2.Controls.Add(Me.chkImportarListaMaterial)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 396)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(898, 81)
        Me.grpControl2.TabIndex = 0
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnImportar
        '
        Me.btnImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportar.Image = Global.INTERACTI.My.Resources.Resources.aprovar
        Me.btnImportar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportar.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnImportar.Location = New System.Drawing.Point(801, 17)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportar.Size = New System.Drawing.Size(91, 23)
        Me.btnImportar.TabIndex = 11
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'chkImportarServicoExterno
        '
        Me.chkImportarServicoExterno.Location = New System.Drawing.Point(9, 46)
        Me.chkImportarServicoExterno.Name = "chkImportarServicoExterno"
        Me.chkImportarServicoExterno.Size = New System.Drawing.Size(150, 23)
        Me.chkImportarServicoExterno.TabIndex = 10
        Me.chkImportarServicoExterno.Text = "Importar Serviço Externo"
        '
        'chkMarcarTodos
        '
        Me.chkMarcarTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMarcarTodos.Location = New System.Drawing.Point(684, 46)
        Me.chkMarcarTodos.Name = "chkMarcarTodos"
        Me.chkMarcarTodos.Size = New System.Drawing.Size(111, 23)
        Me.chkMarcarTodos.TabIndex = 7
        Me.chkMarcarTodos.Text = "Desmarcar Todos"
        '
        'chkImportarProcessoProdutivo
        '
        Me.chkImportarProcessoProdutivo.Location = New System.Drawing.Point(9, 17)
        Me.chkImportarProcessoProdutivo.Name = "chkImportarProcessoProdutivo"
        Me.chkImportarProcessoProdutivo.Size = New System.Drawing.Size(167, 23)
        Me.chkImportarProcessoProdutivo.TabIndex = 2
        Me.chkImportarProcessoProdutivo.Text = "Importar Processo Produtivo"
        '
        'chkImportarEstruturaProduto
        '
        Me.chkImportarEstruturaProduto.Location = New System.Drawing.Point(182, 46)
        Me.chkImportarEstruturaProduto.Name = "chkImportarEstruturaProduto"
        Me.chkImportarEstruturaProduto.Size = New System.Drawing.Size(166, 23)
        Me.chkImportarEstruturaProduto.TabIndex = 1
        Me.chkImportarEstruturaProduto.Text = "Importar Estrutura de Produto"
        '
        'chkImportarListaMaterial
        '
        Me.chkImportarListaMaterial.Location = New System.Drawing.Point(182, 17)
        Me.chkImportarListaMaterial.Name = "chkImportarListaMaterial"
        Me.chkImportarListaMaterial.Size = New System.Drawing.Size(150, 23)
        Me.chkImportarListaMaterial.TabIndex = 0
        Me.chkImportarListaMaterial.Text = "Importar Lista de Material"
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(801, 46)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 9
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboImportarEstrutura
        '
        Me.cboImportarEstrutura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboImportarEstrutura.AutoSize = False
        Me.cboImportarEstrutura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboImportarEstrutura.Location = New System.Drawing.Point(695, 34)
        Me.cboImportarEstrutura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboImportarEstrutura.Name = "cboImportarEstrutura"
        Me.cboImportarEstrutura.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboImportarEstrutura.Size = New System.Drawing.Size(100, 20)
        Me.cboImportarEstrutura.TabIndex = 25
        '
        'lblImportarEstrutura
        '
        Me.lblImportarEstrutura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblImportarEstrutura.AutoSize = True
        Me.lblImportarEstrutura.Location = New System.Drawing.Point(692, 18)
        Me.lblImportarEstrutura.Name = "lblImportarEstrutura"
        Me.lblImportarEstrutura.Size = New System.Drawing.Size(96, 14)
        Me.lblImportarEstrutura.TabIndex = 26
        Me.lblImportarEstrutura.Text = "Importar Estrutura:"
        '
        'frmPrdOrdemProducaoImportarOrdemProducao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 523)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmPrdOrdemProducaoImportarOrdemProducao"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Importar Ordem de Produção"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpImportacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpImportacao.ResumeLayout(False)
        Me.grpImportacao.PerformLayout()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpImportacao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents dtpDataTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataInicioFiltro As System.Windows.Forms.Label
    Friend WithEvents btnProcurarCliente As System.Windows.Forms.Button
    Friend WithEvents cboClienteFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents chkImportarProcessoProdutivo As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkImportarEstruturaProduto As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkImportarListaMaterial As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkMarcarTodos As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents txtOrdemProducaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOrdemProducaoFiltro As System.Windows.Forms.Label
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents chkImportarServicoExterno As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents btnImportar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblImportarEstrutura As Label
    Friend WithEvents cboImportarEstrutura As Janus.Windows.EditControls.UIComboBox
End Class
