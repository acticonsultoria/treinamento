<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindNotaFiscalAtivoImobilizado
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
        Dim grdFind_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdFind_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFindNotaFiscalAtivoImobilizado))
        Dim cboCFOPFiltro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdFind = New Janus.Windows.GridEX.GridEX()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblProdutoFiltro = New System.Windows.Forms.Label()
        Me.txtProdutoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboCFOPFiltro = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblCFOPFiltro = New System.Windows.Forms.Label()
        Me.dtpDataEmissaoInicioFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataEmissaoTerminoFiltro = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.txtEmitenteFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtNotaFiscalFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.lblDataEmissaoFiltro = New System.Windows.Forms.Label()
        Me.lblEmitenteFiltro = New System.Windows.Forms.Label()
        Me.lblNotaFiscalFiltro = New System.Windows.Forms.Label()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegendaAtivoImobilizado = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAcessorio = New System.Windows.Forms.Label()
        Me.picLegendaAcessorioAtivo = New System.Windows.Forms.PictureBox()
        Me.lblLegendaAtivoImobilizado = New System.Windows.Forms.Label()
        CType(Me.grdFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegendaAtivoImobilizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegendaAcessorioAtivo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnExcelGrid
        '
        Me.btnExcelGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGrid.FlatAppearance.BorderSize = 0
        Me.btnExcelGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGrid.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGrid.Location = New System.Drawing.Point(60, 393)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 3
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
        Me.btnAgruparGrid.Location = New System.Drawing.Point(36, 393)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 2
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
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(12, 393)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 1
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdFind
        '
        Me.grdFind.AlternatingColors = True
        Me.grdFind.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdFind.AutoEdit = True
        grdFind_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdFind_DesignTimeLayout_Reference_0.Instance"), Object)
        grdFind_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdFind_DesignTimeLayout_Reference_0})
        grdFind_DesignTimeLayout.LayoutString = resources.GetString("grdFind_DesignTimeLayout.LayoutString")
        Me.grdFind.DesignTimeLayout = grdFind_DesignTimeLayout
        Me.grdFind.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.grdFind.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdFind.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdFind.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdFind.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdFind.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdFind.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdFind.GroupByBoxVisible = False
        Me.grdFind.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdFind.Location = New System.Drawing.Point(8, 81)
        Me.grdFind.Name = "grdFind"
        Me.grdFind.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdFind.RecordNavigator = True
        Me.grdFind.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdFind.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdFind.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdFind.Size = New System.Drawing.Size(897, 329)
        Me.grdFind.TabIndex = 0
        Me.grdFind.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdFind.VisualStyleManager = Me.vsmMain
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.lblProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtProdutoFiltro)
        Me.grpFiltro.Controls.Add(Me.cboCFOPFiltro)
        Me.grpFiltro.Controls.Add(Me.lblCFOPFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoInicioFiltro)
        Me.grpFiltro.Controls.Add(Me.dtpDataEmissaoTerminoFiltro)
        Me.grpFiltro.Controls.Add(Me.txtEmitenteFiltro)
        Me.grpFiltro.Controls.Add(Me.txtNotaFiscalFiltro)
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.lblDataEmissaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblEmitenteFiltro)
        Me.grpFiltro.Controls.Add(Me.lblNotaFiscalFiltro)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 72)
        Me.grpFiltro.TabIndex = 4
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'lblProdutoFiltro
        '
        Me.lblProdutoFiltro.AutoSize = True
        Me.lblProdutoFiltro.Location = New System.Drawing.Point(610, 18)
        Me.lblProdutoFiltro.Name = "lblProdutoFiltro"
        Me.lblProdutoFiltro.Size = New System.Drawing.Size(47, 14)
        Me.lblProdutoFiltro.TabIndex = 9
        Me.lblProdutoFiltro.Text = "Produto:"
        '
        'txtProdutoFiltro
        '
        Me.txtProdutoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProdutoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProdutoFiltro.Location = New System.Drawing.Point(613, 35)
        Me.txtProdutoFiltro.MaxLength = 120
        Me.txtProdutoFiltro.Name = "txtProdutoFiltro"
        Me.txtProdutoFiltro.Size = New System.Drawing.Size(161, 20)
        Me.txtProdutoFiltro.TabIndex = 10
        '
        'cboCFOPFiltro
        '
        Me.cboCFOPFiltro.AllowDrop = True
        Me.cboCFOPFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCFOPFiltro.ButtonCancelText = "Cancelar"
        Me.cboCFOPFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboCFOPFiltro_DesignTimeLayout.LayoutString = resources.GetString("cboCFOPFiltro_DesignTimeLayout.LayoutString")
        Me.cboCFOPFiltro.DesignTimeLayout = cboCFOPFiltro_DesignTimeLayout
        Me.cboCFOPFiltro.Location = New System.Drawing.Point(499, 34)
        Me.cboCFOPFiltro.Name = "cboCFOPFiltro"
        Me.cboCFOPFiltro.SaveSettings = False
        Me.cboCFOPFiltro.SettingsKey = "cboDestinacaoFiltro"
        Me.cboCFOPFiltro.Size = New System.Drawing.Size(108, 20)
        Me.cboCFOPFiltro.TabIndex = 17
        Me.cboCFOPFiltro.ValuesDataMember = Nothing
        '
        'lblCFOPFiltro
        '
        Me.lblCFOPFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCFOPFiltro.AutoSize = True
        Me.lblCFOPFiltro.Location = New System.Drawing.Point(500, 17)
        Me.lblCFOPFiltro.Name = "lblCFOPFiltro"
        Me.lblCFOPFiltro.Size = New System.Drawing.Size(37, 14)
        Me.lblCFOPFiltro.TabIndex = 16
        Me.lblCFOPFiltro.Text = "CFOP:"
        '
        'dtpDataEmissaoInicioFiltro
        '
        Me.dtpDataEmissaoInicioFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataEmissaoInicioFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoInicioFiltro.Location = New System.Drawing.Point(271, 34)
        Me.dtpDataEmissaoInicioFiltro.Name = "dtpDataEmissaoInicioFiltro"
        Me.dtpDataEmissaoInicioFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoInicioFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoInicioFiltro.TabIndex = 7
        Me.dtpDataEmissaoInicioFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'dtpDataEmissaoTerminoFiltro
        '
        Me.dtpDataEmissaoTerminoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dtpDataEmissaoTerminoFiltro.DropDownCalendar.Name = ""
        Me.dtpDataEmissaoTerminoFiltro.Location = New System.Drawing.Point(385, 34)
        Me.dtpDataEmissaoTerminoFiltro.Name = "dtpDataEmissaoTerminoFiltro"
        Me.dtpDataEmissaoTerminoFiltro.ShowCheckBox = True
        Me.dtpDataEmissaoTerminoFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtpDataEmissaoTerminoFiltro.TabIndex = 8
        Me.dtpDataEmissaoTerminoFiltro.Value = New Date(2012, 1, 29, 0, 0, 0, 0)
        '
        'txtEmitenteFiltro
        '
        Me.txtEmitenteFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmitenteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmitenteFiltro.Location = New System.Drawing.Point(89, 34)
        Me.txtEmitenteFiltro.MaxLength = 60
        Me.txtEmitenteFiltro.Name = "txtEmitenteFiltro"
        Me.txtEmitenteFiltro.Size = New System.Drawing.Size(176, 20)
        Me.txtEmitenteFiltro.TabIndex = 5
        '
        'txtNotaFiscalFiltro
        '
        Me.txtNotaFiscalFiltro.IncludeLiterals = False
        Me.txtNotaFiscalFiltro.Location = New System.Drawing.Point(9, 34)
        Me.txtNotaFiscalFiltro.MaxLength = 9
        Me.txtNotaFiscalFiltro.Name = "txtNotaFiscalFiltro"
        Me.txtNotaFiscalFiltro.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNotaFiscalFiltro.Size = New System.Drawing.Size(74, 20)
        Me.txtNotaFiscalFiltro.TabIndex = 1
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(791, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 24
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDataEmissaoFiltro
        '
        Me.lblDataEmissaoFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataEmissaoFiltro.AutoSize = True
        Me.lblDataEmissaoFiltro.Location = New System.Drawing.Point(268, 17)
        Me.lblDataEmissaoFiltro.Name = "lblDataEmissaoFiltro"
        Me.lblDataEmissaoFiltro.Size = New System.Drawing.Size(75, 14)
        Me.lblDataEmissaoFiltro.TabIndex = 6
        Me.lblDataEmissaoFiltro.Text = "Data Emissão:"
        '
        'lblEmitenteFiltro
        '
        Me.lblEmitenteFiltro.AutoSize = True
        Me.lblEmitenteFiltro.Location = New System.Drawing.Point(86, 17)
        Me.lblEmitenteFiltro.Name = "lblEmitenteFiltro"
        Me.lblEmitenteFiltro.Size = New System.Drawing.Size(50, 14)
        Me.lblEmitenteFiltro.TabIndex = 4
        Me.lblEmitenteFiltro.Text = "Emitente:"
        '
        'lblNotaFiscalFiltro
        '
        Me.lblNotaFiscalFiltro.AutoSize = True
        Me.lblNotaFiscalFiltro.Location = New System.Drawing.Point(6, 17)
        Me.lblNotaFiscalFiltro.Name = "lblNotaFiscalFiltro"
        Me.lblNotaFiscalFiltro.Size = New System.Drawing.Size(63, 14)
        Me.lblNotaFiscalFiltro.TabIndex = 0
        Me.lblNotaFiscalFiltro.Text = "Nota Fiscal:"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.picLegendaAtivoImobilizado)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAcessorio)
        Me.grpLegenda.Controls.Add(Me.picLegendaAcessorioAtivo)
        Me.grpLegenda.Controls.Add(Me.lblLegendaAtivoImobilizado)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(8, 416)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(897, 51)
        Me.grpLegenda.TabIndex = 6
        Me.grpLegenda.Text = "Legenda"
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picLegendaAtivoImobilizado
        '
        Me.picLegendaAtivoImobilizado.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegendaAtivoImobilizado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAtivoImobilizado.Location = New System.Drawing.Point(9, 21)
        Me.picLegendaAtivoImobilizado.Name = "picLegendaAtivoImobilizado"
        Me.picLegendaAtivoImobilizado.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAtivoImobilizado.TabIndex = 16
        Me.picLegendaAtivoImobilizado.TabStop = False
        '
        'lblLegendaAcessorio
        '
        Me.lblLegendaAcessorio.AutoSize = True
        Me.lblLegendaAcessorio.Location = New System.Drawing.Point(140, 21)
        Me.lblLegendaAcessorio.Name = "lblLegendaAcessorio"
        Me.lblLegendaAcessorio.Size = New System.Drawing.Size(99, 14)
        Me.lblLegendaAcessorio.TabIndex = 1
        Me.lblLegendaAcessorio.Text = "Acessório de Ativo"
        '
        'picLegendaAcessorioAtivo
        '
        Me.picLegendaAcessorioAtivo.BackColor = System.Drawing.Color.Peru
        Me.picLegendaAcessorioAtivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegendaAcessorioAtivo.Location = New System.Drawing.Point(121, 21)
        Me.picLegendaAcessorioAtivo.Name = "picLegendaAcessorioAtivo"
        Me.picLegendaAcessorioAtivo.Size = New System.Drawing.Size(13, 14)
        Me.picLegendaAcessorioAtivo.TabIndex = 14
        Me.picLegendaAcessorioAtivo.TabStop = False
        '
        'lblLegendaAtivoImobilizado
        '
        Me.lblLegendaAtivoImobilizado.AutoSize = True
        Me.lblLegendaAtivoImobilizado.Location = New System.Drawing.Point(28, 21)
        Me.lblLegendaAtivoImobilizado.Name = "lblLegendaAtivoImobilizado"
        Me.lblLegendaAtivoImobilizado.Size = New System.Drawing.Size(87, 14)
        Me.lblLegendaAtivoImobilizado.TabIndex = 0
        Me.lblLegendaAtivoImobilizado.Text = "Ativo Imobilizado"
        '
        'frmFindNotaFiscalAtivoImobilizado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 472)
        Me.Controls.Add(Me.grpLegenda)
        Me.Controls.Add(Me.grpFiltro)
        Me.Controls.Add(Me.btnExcelGrid)
        Me.Controls.Add(Me.btnAgruparGrid)
        Me.Controls.Add(Me.btnConfigurarGrid)
        Me.Controls.Add(Me.grdFind)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFindNotaFiscalAtivoImobilizado"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Procurar Nota Fiscal de Ativo Imobilizado"
        CType(Me.grdFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegendaAtivoImobilizado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegendaAcessorioAtivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grdFind As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblProdutoFiltro As System.Windows.Forms.Label
    Friend WithEvents txtProdutoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboCFOPFiltro As Janus.Windows.GridEX.EditControls.CheckedComboBox
    Friend WithEvents lblCFOPFiltro As System.Windows.Forms.Label
    Friend WithEvents dtpDataEmissaoInicioFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataEmissaoTerminoFiltro As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtEmitenteFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtNotaFiscalFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblDataEmissaoFiltro As System.Windows.Forms.Label
    Friend WithEvents lblEmitenteFiltro As System.Windows.Forms.Label
    Friend WithEvents lblNotaFiscalFiltro As System.Windows.Forms.Label
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegendaAtivoImobilizado As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAcessorio As System.Windows.Forms.Label
    Friend WithEvents picLegendaAcessorioAtivo As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegendaAtivoImobilizado As System.Windows.Forms.Label
End Class
