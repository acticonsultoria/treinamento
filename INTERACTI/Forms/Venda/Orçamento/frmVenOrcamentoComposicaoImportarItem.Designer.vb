<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenOrcamentoComposicaoImportarItem
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
        Dim grdOrcamentoComposicaoImportarItem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenOrcamentoComposicaoImportarItem))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpImportacao = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarCliente = New System.Windows.Forms.Button()
        Me.cboClienteFiltro = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.dtpDataOrcamentoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataOrcamentoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblDataOrcamento = New System.Windows.Forms.Label()
        Me.txtNumeroOrcamentoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroOrcamentoFiltro = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grdOrcamentoComposicaoImportarItem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.chkMarcarTodos = New Janus.Windows.EditControls.UICheckBox()
        Me.btnImportar = New Janus.Windows.EditControls.UIButton()
        Me.chkAtualizarMargemLucro = New Janus.Windows.EditControls.UICheckBox()
        Me.chkAtualizarValorCustoHoras = New Janus.Windows.EditControls.UICheckBox()
        Me.chkAtualizarAliquotaImpostos = New Janus.Windows.EditControls.UICheckBox()
        Me.chkAtualizarDespesaFixa = New Janus.Windows.EditControls.UICheckBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.txtNumeroOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNumeroOrdemProducao = New System.Windows.Forms.Label()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpImportacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpImportacao.SuspendLayout()
        CType(Me.grdOrcamentoComposicaoImportarItem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pagTabela.Controls.Add(Me.grpImportacao)
        Me.pagTabela.Controls.Add(Me.grdOrcamentoComposicaoImportarItem)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 22)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(914, 486)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Importação"
        '
        'grpImportacao
        '
        Me.grpImportacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpImportacao.BackColor = System.Drawing.Color.Transparent
        Me.grpImportacao.Controls.Add(Me.txtNumeroOrdemProducao)
        Me.grpImportacao.Controls.Add(Me.lblNumeroOrdemProducao)
        Me.grpImportacao.Controls.Add(Me.btnProcurarCliente)
        Me.grpImportacao.Controls.Add(Me.cboClienteFiltro)
        Me.grpImportacao.Controls.Add(Me.lblCliente)
        Me.grpImportacao.Controls.Add(Me.dtpDataOrcamentoTerminoFiltro)
        Me.grpImportacao.Controls.Add(Me.dtpDataOrcamentoInicioFiltro)
        Me.grpImportacao.Controls.Add(Me.lblDataOrcamento)
        Me.grpImportacao.Controls.Add(Me.txtNumeroOrcamentoFiltro)
        Me.grpImportacao.Controls.Add(Me.lblNumeroOrcamentoFiltro)
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
        'btnProcurarCliente
        '
        Me.btnProcurarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarCliente.FlatAppearance.BorderSize = 0
        Me.btnProcurarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurarCliente.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnProcurarCliente.Location = New System.Drawing.Point(639, 16)
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
        Me.cboClienteFiltro.Location = New System.Drawing.Point(297, 34)
        Me.cboClienteFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboClienteFiltro.Name = "cboClienteFiltro"
        Me.cboClienteFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboClienteFiltro.Size = New System.Drawing.Size(360, 20)
        Me.cboClienteFiltro.TabIndex = 3
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(294, 17)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 21
        Me.lblCliente.Text = "Cliente:"
        '
        'dtpDataOrcamentoTerminoFiltro
        '
        '
        '
        '
        Me.dtpDataOrcamentoTerminoFiltro.DropDownCalendar.FirstMonth = New Date(2023, 4, 1, 0, 0, 0, 0)
        Me.dtpDataOrcamentoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataOrcamentoTerminoFiltro.Location = New System.Drawing.Point(193, 34)
        Me.dtpDataOrcamentoTerminoFiltro.Name = "dtpDataOrcamentoTerminoFiltro"
        Me.dtpDataOrcamentoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataOrcamentoTerminoFiltro.Size = New System.Drawing.Size(98, 20)
        Me.dtpDataOrcamentoTerminoFiltro.TabIndex = 2
        Me.dtpDataOrcamentoTerminoFiltro.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'dtpDataOrcamentoInicioFiltro
        '
        '
        '
        '
        Me.dtpDataOrcamentoInicioFiltro.DropDownCalendar.FirstMonth = New Date(2023, 4, 1, 0, 0, 0, 0)
        Me.dtpDataOrcamentoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataOrcamentoInicioFiltro.Location = New System.Drawing.Point(89, 34)
        Me.dtpDataOrcamentoInicioFiltro.Name = "dtpDataOrcamentoInicioFiltro"
        Me.dtpDataOrcamentoInicioFiltro.ShowCheckBox = True
        Me.dtpDataOrcamentoInicioFiltro.Size = New System.Drawing.Size(98, 20)
        Me.dtpDataOrcamentoInicioFiltro.TabIndex = 1
        Me.dtpDataOrcamentoInicioFiltro.Value = New Date(2012, 4, 2, 0, 0, 0, 0)
        '
        'lblDataOrcamento
        '
        Me.lblDataOrcamento.AutoSize = True
        Me.lblDataOrcamento.Location = New System.Drawing.Point(86, 17)
        Me.lblDataOrcamento.Name = "lblDataOrcamento"
        Me.lblDataOrcamento.Size = New System.Drawing.Size(88, 14)
        Me.lblDataOrcamento.TabIndex = 9
        Me.lblDataOrcamento.Text = "Data Orçamento:"
        '
        'txtNumeroOrcamentoFiltro
        '
        Me.txtNumeroOrcamentoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOrcamentoFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNumeroOrcamentoFiltro.MaxLength = 20
        Me.txtNumeroOrcamentoFiltro.Name = "txtNumeroOrcamentoFiltro"
        Me.txtNumeroOrcamentoFiltro.Size = New System.Drawing.Size(74, 20)
        Me.txtNumeroOrcamentoFiltro.TabIndex = 0
        '
        'lblNumeroOrcamentoFiltro
        '
        Me.lblNumeroOrcamentoFiltro.AutoSize = True
        Me.lblNumeroOrcamentoFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNumeroOrcamentoFiltro.Name = "lblNumeroOrcamentoFiltro"
        Me.lblNumeroOrcamentoFiltro.Size = New System.Drawing.Size(77, 14)
        Me.lblNumeroOrcamentoFiltro.TabIndex = 6
        Me.lblNumeroOrcamentoFiltro.Text = "N° Orçamento:"
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
        'grdOrcamentoComposicaoImportarItem
        '
        Me.grdOrcamentoComposicaoImportarItem.AlternatingColors = True
        Me.grdOrcamentoComposicaoImportarItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdOrcamentoComposicaoImportarItem_DesignTimeLayout.LayoutString = resources.GetString("grdOrcamentoComposicaoImportarItem_DesignTimeLayout.LayoutString")
        Me.grdOrcamentoComposicaoImportarItem.DesignTimeLayout = grdOrcamentoComposicaoImportarItem_DesignTimeLayout
        Me.grdOrcamentoComposicaoImportarItem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdOrcamentoComposicaoImportarItem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdOrcamentoComposicaoImportarItem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed
        Me.grdOrcamentoComposicaoImportarItem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdOrcamentoComposicaoImportarItem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdOrcamentoComposicaoImportarItem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdOrcamentoComposicaoImportarItem.GroupByBoxVisible = False
        Me.grdOrcamentoComposicaoImportarItem.Hierarchical = True
        Me.grdOrcamentoComposicaoImportarItem.Location = New System.Drawing.Point(8, 77)
        Me.grdOrcamentoComposicaoImportarItem.Name = "grdOrcamentoComposicaoImportarItem"
        Me.grdOrcamentoComposicaoImportarItem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdOrcamentoComposicaoImportarItem.RecordNavigator = True
        Me.grdOrcamentoComposicaoImportarItem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdOrcamentoComposicaoImportarItem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdOrcamentoComposicaoImportarItem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdOrcamentoComposicaoImportarItem.Size = New System.Drawing.Size(898, 313)
        Me.grdOrcamentoComposicaoImportarItem.TabIndex = 4
        Me.grdOrcamentoComposicaoImportarItem.TabStop = False
        Me.grdOrcamentoComposicaoImportarItem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdOrcamentoComposicaoImportarItem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdOrcamentoComposicaoImportarItem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdOrcamentoComposicaoImportarItem.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.chkMarcarTodos)
        Me.grpControl2.Controls.Add(Me.btnImportar)
        Me.grpControl2.Controls.Add(Me.chkAtualizarMargemLucro)
        Me.grpControl2.Controls.Add(Me.chkAtualizarValorCustoHoras)
        Me.grpControl2.Controls.Add(Me.chkAtualizarAliquotaImpostos)
        Me.grpControl2.Controls.Add(Me.chkAtualizarDespesaFixa)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(8, 396)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(898, 81)
        Me.grpControl2.TabIndex = 0
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'chkMarcarTodos
        '
        Me.chkMarcarTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMarcarTodos.Location = New System.Drawing.Point(597, 46)
        Me.chkMarcarTodos.Name = "chkMarcarTodos"
        Me.chkMarcarTodos.Size = New System.Drawing.Size(111, 23)
        Me.chkMarcarTodos.TabIndex = 7
        Me.chkMarcarTodos.Text = "Desmarcar Todos"
        '
        'btnImportar
        '
        Me.btnImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportar.Image = Global.INTERACTI.My.Resources.Resources.add
        Me.btnImportar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportar.Location = New System.Drawing.Point(714, 46)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportar.Size = New System.Drawing.Size(81, 23)
        Me.btnImportar.TabIndex = 8
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'chkAtualizarMargemLucro
        '
        Me.chkAtualizarMargemLucro.Location = New System.Drawing.Point(202, 46)
        Me.chkAtualizarMargemLucro.Name = "chkAtualizarMargemLucro"
        Me.chkAtualizarMargemLucro.Size = New System.Drawing.Size(167, 23)
        Me.chkAtualizarMargemLucro.TabIndex = 6
        Me.chkAtualizarMargemLucro.Text = "Atualizar Margem de Lucro"
        '
        'chkAtualizarValorCustoHoras
        '
        Me.chkAtualizarValorCustoHoras.Location = New System.Drawing.Point(202, 17)
        Me.chkAtualizarValorCustoHoras.Name = "chkAtualizarValorCustoHoras"
        Me.chkAtualizarValorCustoHoras.Size = New System.Drawing.Size(194, 23)
        Me.chkAtualizarValorCustoHoras.TabIndex = 2
        Me.chkAtualizarValorCustoHoras.Text = "Atualizar Valor de Custo de Horas"
        '
        'chkAtualizarAliquotaImpostos
        '
        Me.chkAtualizarAliquotaImpostos.Location = New System.Drawing.Point(9, 46)
        Me.chkAtualizarAliquotaImpostos.Name = "chkAtualizarAliquotaImpostos"
        Me.chkAtualizarAliquotaImpostos.Size = New System.Drawing.Size(187, 23)
        Me.chkAtualizarAliquotaImpostos.TabIndex = 1
        Me.chkAtualizarAliquotaImpostos.Text = "Atualizar Alíquota de Impostos"
        '
        'chkAtualizarDespesaFixa
        '
        Me.chkAtualizarDespesaFixa.Location = New System.Drawing.Point(9, 17)
        Me.chkAtualizarDespesaFixa.Name = "chkAtualizarDespesaFixa"
        Me.chkAtualizarDespesaFixa.Size = New System.Drawing.Size(187, 23)
        Me.chkAtualizarDespesaFixa.TabIndex = 0
        Me.chkAtualizarDespesaFixa.Text = "Atualizar % de Despesas Fixas"
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
        'txtNumeroOrdemProducao
        '
        Me.txtNumeroOrdemProducao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroOrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOrdemProducao.Location = New System.Drawing.Point(663, 34)
        Me.txtNumeroOrdemProducao.MaxLength = 20
        Me.txtNumeroOrdemProducao.Name = "txtNumeroOrdemProducao"
        Me.txtNumeroOrdemProducao.Size = New System.Drawing.Size(132, 20)
        Me.txtNumeroOrdemProducao.TabIndex = 23
        '
        'lblNumeroOrdemProducao
        '
        Me.lblNumeroOrdemProducao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumeroOrdemProducao.AutoSize = True
        Me.lblNumeroOrdemProducao.Location = New System.Drawing.Point(660, 18)
        Me.lblNumeroOrdemProducao.Name = "lblNumeroOrdemProducao"
        Me.lblNumeroOrdemProducao.Size = New System.Drawing.Size(106, 14)
        Me.lblNumeroOrdemProducao.TabIndex = 24
        Me.lblNumeroOrdemProducao.Text = "Ordem de Produção:"
        '
        'frmVenOrcamentoComposicaoImportarItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 523)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmVenOrcamentoComposicaoImportarItem"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Importar Item"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpImportacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpImportacao.ResumeLayout(False)
        Me.grpImportacao.PerformLayout()
        CType(Me.grdOrcamentoComposicaoImportarItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdOrcamentoComposicaoImportarItem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpImportacao As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtNumeroOrcamentoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroOrcamentoFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataOrcamentoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataOrcamentoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents lblDataOrcamento As System.Windows.Forms.Label
    Friend WithEvents btnProcurarCliente As System.Windows.Forms.Button
    Friend WithEvents cboClienteFiltro As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents chkAtualizarValorCustoHoras As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkAtualizarAliquotaImpostos As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkAtualizarDespesaFixa As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkAtualizarMargemLucro As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents btnImportar As Janus.Windows.EditControls.UIButton
    Friend WithEvents chkMarcarTodos As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents txtNumeroOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNumeroOrdemProducao As Label
End Class
