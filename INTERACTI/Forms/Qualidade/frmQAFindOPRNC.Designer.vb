<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQAFindOPRNC
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQAFindOPRNC))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grpDadosVendaCliente = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtCliente = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtProduto = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.txtNumeroOrdemProducao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.dtpDataInicio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.dtpDataTermino = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.lblNumeroOrdemProducao = New System.Windows.Forms.Label()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControlFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpDadosVendaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosVendaCliente.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControlFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControlFiltro.SuspendLayout()
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
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(7, 7)
        Me.tabMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(877, 566)
        Me.tabMain.TabIndex = 1
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grpDadosVendaCliente)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpControlFiltro)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(875, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Ordem de Produção"
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
        Me.btnAgruparGrid.TabIndex = 4
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
        Me.btnConfigurarGrid.TabIndex = 3
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grpDadosVendaCliente
        '
        Me.grpDadosVendaCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosVendaCliente.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosVendaCliente.Controls.Add(Me.txtCliente)
        Me.grpDadosVendaCliente.Controls.Add(Me.lblCliente)
        Me.grpDadosVendaCliente.Controls.Add(Me.txtProduto)
        Me.grpDadosVendaCliente.Controls.Add(Me.lblProduto)
        Me.grpDadosVendaCliente.Controls.Add(Me.txtNumeroOrdemProducao)
        Me.grpDadosVendaCliente.Controls.Add(Me.lblDataInicio)
        Me.grpDadosVendaCliente.Controls.Add(Me.dtpDataInicio)
        Me.grpDadosVendaCliente.Controls.Add(Me.dtpDataTermino)
        Me.grpDadosVendaCliente.Controls.Add(Me.lblNumeroOrdemProducao)
        Me.grpDadosVendaCliente.Controls.Add(Me.btnFiltrar)
        Me.grpDadosVendaCliente.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosVendaCliente.Location = New System.Drawing.Point(8, 3)
        Me.grpDadosVendaCliente.Name = "grpDadosVendaCliente"
        Me.grpDadosVendaCliente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosVendaCliente.Size = New System.Drawing.Size(857, 65)
        Me.grpDadosVendaCliente.TabIndex = 0
        Me.grpDadosVendaCliente.VisualStyleManager = Me.vsmMain
        '
        'txtCliente
        '
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(513, 34)
        Me.txtCliente.MaxLength = 60
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(175, 20)
        Me.txtCliente.TabIndex = 8
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCliente.Location = New System.Drawing.Point(510, 17)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 14)
        Me.lblCliente.TabIndex = 7
        Me.lblCliente.Text = "Cliente:"
        '
        'txtProduto
        '
        Me.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduto.Location = New System.Drawing.Point(356, 34)
        Me.txtProduto.MaxLength = 60
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(151, 20)
        Me.txtProduto.TabIndex = 6
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblProduto.Location = New System.Drawing.Point(353, 17)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 14)
        Me.lblProduto.TabIndex = 5
        Me.lblProduto.Text = "Produto:"
        '
        'txtNumeroOrdemProducao
        '
        Me.txtNumeroOrdemProducao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroOrdemProducao.Location = New System.Drawing.Point(268, 34)
        Me.txtNumeroOrdemProducao.MaxLength = 60
        Me.txtNumeroOrdemProducao.Name = "txtNumeroOrdemProducao"
        Me.txtNumeroOrdemProducao.Size = New System.Drawing.Size(82, 20)
        Me.txtNumeroOrdemProducao.TabIndex = 4
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataInicio.Location = New System.Drawing.Point(8, 18)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(59, 14)
        Me.lblDataInicio.TabIndex = 0
        Me.lblDataInicio.Text = "Data Inicio:"
        '
        'dtpDataInicio
        '
        '
        '
        '
        Me.dtpDataInicio.DropDownCalendar.Name = ""
        Me.dtpDataInicio.Location = New System.Drawing.Point(9, 34)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.ShowCheckBox = True
        Me.dtpDataInicio.Size = New System.Drawing.Size(118, 20)
        Me.dtpDataInicio.TabIndex = 1
        '
        'dtpDataTermino
        '
        '
        '
        '
        Me.dtpDataTermino.DropDownCalendar.Name = ""
        Me.dtpDataTermino.Location = New System.Drawing.Point(133, 34)
        Me.dtpDataTermino.Name = "dtpDataTermino"
        Me.dtpDataTermino.ShowCheckBox = True
        Me.dtpDataTermino.Size = New System.Drawing.Size(129, 20)
        Me.dtpDataTermino.TabIndex = 2
        '
        'lblNumeroOrdemProducao
        '
        Me.lblNumeroOrdemProducao.AutoSize = True
        Me.lblNumeroOrdemProducao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeroOrdemProducao.Location = New System.Drawing.Point(265, 17)
        Me.lblNumeroOrdemProducao.Name = "lblNumeroOrdemProducao"
        Me.lblNumeroOrdemProducao.Size = New System.Drawing.Size(39, 14)
        Me.lblNumeroOrdemProducao.TabIndex = 3
        Me.lblNumeroOrdemProducao.Text = "Nº OP:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnFiltrar.Location = New System.Drawing.Point(734, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(91, 23)
        Me.btnFiltrar.TabIndex = 9
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
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
        Me.grdListagem.FrozenColumns = 2
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(8, 75)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(857, 405)
        Me.grdListagem.TabIndex = 2
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControlFiltro
        '
        Me.grpControlFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControlFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpControlFiltro.Controls.Add(Me.btnSair)
        Me.grpControlFiltro.Location = New System.Drawing.Point(8, 483)
        Me.grpControlFiltro.Name = "grpControlFiltro"
        Me.grpControlFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControlFiltro.Size = New System.Drawing.Size(857, 51)
        Me.grpControlFiltro.TabIndex = 5
        Me.grpControlFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(757, 18)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmQAFindOPRNC
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(889, 581)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQAFindOPRNC"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Procurar Ordem De Produção"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpDadosVendaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosVendaCliente.ResumeLayout(False)
        Me.grpDadosVendaCliente.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControlFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControlFiltro.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grpDadosVendaCliente As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblNumeroOrdemProducao As System.Windows.Forms.Label
    Friend WithEvents lblDataInicio As System.Windows.Forms.Label
    Friend WithEvents dtpDataInicio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents dtpDataTermino As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents txtNumeroOrdemProducao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtCliente As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents txtProduto As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents grpControlFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
End Class
