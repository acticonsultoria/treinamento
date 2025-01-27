<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrPrdApontamentoAutomatizado
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim grdApontamento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdApontamento_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdApontamentoAutomatizado))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdApontamento = New Janus.Windows.GridEX.GridEX()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grpApontamento = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboTipo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.cboPeriodo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.cboTurno = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.cboOrdem = New Janus.Windows.EditControls.UIComboBox()
        Me.lblOrdem = New System.Windows.Forms.Label()
        Me.dtpDataInicio = New Janus.Windows.CalendarCombo.CalendarCombo()
        Me.cboFuncionario = New Janus.Windows.EditControls.UIComboBox()
        Me.cboOperacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.lblOPOperacao = New System.Windows.Forms.Label()
        Me.grpControlFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpApontamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpApontamento.SuspendLayout()
        CType(Me.grpControlFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControlFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(1179, 454)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grdApontamento)
        Me.pagLista.Controls.Add(Me.grpApontamento)
        Me.pagLista.Controls.Add(Me.grpControlFiltro)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(1177, 431)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Apontamento de Produção"
        '
        'grdApontamento
        '
        Me.grdApontamento.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdApontamento.AlternatingColors = True
        Me.grdApontamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdApontamento_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdApontamento_DesignTimeLayout_Reference_0.Instance"), Object)
        grdApontamento_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdApontamento_DesignTimeLayout_Reference_0})
        grdApontamento_DesignTimeLayout.LayoutString = resources.GetString("grdApontamento_DesignTimeLayout.LayoutString")
        Me.grdApontamento.DesignTimeLayout = grdApontamento_DesignTimeLayout
        Me.grdApontamento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdApontamento.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdApontamento.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdApontamento.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdApontamento.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdApontamento.FrozenColumns = 3
        Me.grdApontamento.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdApontamento.GroupByBoxVisible = False
        Me.grdApontamento.Location = New System.Drawing.Point(8, 76)
        Me.grdApontamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdApontamento.Name = "grdApontamento"
        Me.grdApontamento.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdApontamento.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdApontamento.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdApontamento.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdApontamento.Size = New System.Drawing.Size(1161, 292)
        Me.grdApontamento.TabIndex = 1
        Me.grdApontamento.TabStop = False
        Me.grdApontamento.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdApontamento.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdApontamento.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdApontamento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdApontamento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdApontamento.VisualStyleManager = Me.vsmMain
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
        'grpApontamento
        '
        Me.grpApontamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpApontamento.BackColor = System.Drawing.Color.Transparent
        Me.grpApontamento.Controls.Add(Me.cboTipo)
        Me.grpApontamento.Controls.Add(Me.lblTipo)
        Me.grpApontamento.Controls.Add(Me.lblDataInicio)
        Me.grpApontamento.Controls.Add(Me.cboPeriodo)
        Me.grpApontamento.Controls.Add(Me.lblPeriodo)
        Me.grpApontamento.Controls.Add(Me.cboTurno)
        Me.grpApontamento.Controls.Add(Me.lblTurno)
        Me.grpApontamento.Controls.Add(Me.cboOrdem)
        Me.grpApontamento.Controls.Add(Me.lblOrdem)
        Me.grpApontamento.Controls.Add(Me.dtpDataInicio)
        Me.grpApontamento.Controls.Add(Me.cboFuncionario)
        Me.grpApontamento.Controls.Add(Me.cboOperacao)
        Me.grpApontamento.Controls.Add(Me.lblFuncionario)
        Me.grpApontamento.Controls.Add(Me.lblOPOperacao)
        Me.grpApontamento.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpApontamento.Location = New System.Drawing.Point(8, 3)
        Me.grpApontamento.Name = "grpApontamento"
        Me.grpApontamento.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpApontamento.Size = New System.Drawing.Size(1161, 66)
        Me.grpApontamento.TabIndex = 0
        Me.grpApontamento.Text = "Apontamento"
        Me.grpApontamento.VisualStyleManager = Me.vsmMain
        '
        'cboTipo
        '
        Me.cboTipo.Location = New System.Drawing.Point(202, 34)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(201, 20)
        Me.cboTipo.TabIndex = 5
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipo.Location = New System.Drawing.Point(199, 17)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 14)
        Me.lblTipo.TabIndex = 4
        Me.lblTipo.Text = "Tipo:"
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataInicio.Location = New System.Drawing.Point(933, 17)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(59, 14)
        Me.lblDataInicio.TabIndex = 10
        Me.lblDataInicio.Text = "Data Início:"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.Location = New System.Drawing.Point(106, 34)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(90, 20)
        Me.cboPeriodo.TabIndex = 3
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPeriodo.Location = New System.Drawing.Point(103, 17)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(46, 14)
        Me.lblPeriodo.TabIndex = 2
        Me.lblPeriodo.Text = "Período:"
        '
        'cboTurno
        '
        Me.cboTurno.Location = New System.Drawing.Point(10, 34)
        Me.cboTurno.Name = "cboTurno"
        Me.cboTurno.Size = New System.Drawing.Size(90, 20)
        Me.cboTurno.TabIndex = 1
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTurno.Location = New System.Drawing.Point(6, 17)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(38, 14)
        Me.lblTurno.TabIndex = 0
        Me.lblTurno.Text = "Turno:"
        '
        'cboOrdem
        '
        Me.cboOrdem.Location = New System.Drawing.Point(409, 34)
        Me.cboOrdem.Name = "cboOrdem"
        Me.cboOrdem.Size = New System.Drawing.Size(343, 20)
        Me.cboOrdem.TabIndex = 7
        '
        'lblOrdem
        '
        Me.lblOrdem.AutoSize = True
        Me.lblOrdem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOrdem.Location = New System.Drawing.Point(406, 17)
        Me.lblOrdem.Name = "lblOrdem"
        Me.lblOrdem.Size = New System.Drawing.Size(42, 14)
        Me.lblOrdem.TabIndex = 6
        Me.lblOrdem.Text = "Ordem:"
        '
        'dtpDataInicio
        '
        '
        '
        '
        Me.dtpDataInicio.DropDownCalendar.Name = ""
        Me.dtpDataInicio.Location = New System.Drawing.Point(936, 34)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.Size = New System.Drawing.Size(87, 20)
        Me.dtpDataInicio.TabIndex = 11
        '
        'cboFuncionario
        '
        Me.cboFuncionario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFuncionario.BackColor = System.Drawing.Color.White
        Me.cboFuncionario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFuncionario.Location = New System.Drawing.Point(1028, 34)
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Size = New System.Drawing.Size(127, 20)
        Me.cboFuncionario.TabIndex = 13
        '
        'cboOperacao
        '
        Me.cboOperacao.Location = New System.Drawing.Point(758, 34)
        Me.cboOperacao.Name = "cboOperacao"
        Me.cboOperacao.Size = New System.Drawing.Size(172, 20)
        Me.cboOperacao.TabIndex = 9
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFuncionario.Location = New System.Drawing.Point(1025, 17)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(66, 14)
        Me.lblFuncionario.TabIndex = 12
        Me.lblFuncionario.Text = "Funcionário:"
        '
        'lblOPOperacao
        '
        Me.lblOPOperacao.AutoSize = True
        Me.lblOPOperacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOPOperacao.Location = New System.Drawing.Point(755, 17)
        Me.lblOPOperacao.Name = "lblOPOperacao"
        Me.lblOPOperacao.Size = New System.Drawing.Size(58, 14)
        Me.lblOPOperacao.TabIndex = 8
        Me.lblOPOperacao.Text = "Operação:"
        '
        'grpControlFiltro
        '
        Me.grpControlFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControlFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpControlFiltro.Controls.Add(Me.btnSalvar)
        Me.grpControlFiltro.Controls.Add(Me.btnNovo)
        Me.grpControlFiltro.Controls.Add(Me.btnSair)
        Me.grpControlFiltro.Location = New System.Drawing.Point(8, 371)
        Me.grpControlFiltro.Name = "grpControlFiltro"
        Me.grpControlFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControlFiltro.Size = New System.Drawing.Size(1161, 51)
        Me.grpControlFiltro.TabIndex = 2
        Me.grpControlFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnSalvar.Location = New System.Drawing.Point(964, 18)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(867, 18)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(1061, 18)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrPrdApontamentoAutomatizado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "usrPrdApontamentoAutomatizado"
        Me.Size = New System.Drawing.Size(1179, 454)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grdApontamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpApontamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpApontamento.ResumeLayout(False)
        Me.grpApontamento.PerformLayout()
        CType(Me.grpControlFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControlFiltro.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControlFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpApontamento As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblOPOperacao As System.Windows.Forms.Label
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents grdApontamento As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboFuncionario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboOperacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDataInicio As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboOrdem As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblOrdem As System.Windows.Forms.Label
    Friend WithEvents cboPeriodo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents cboTurno As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents lblDataInicio As System.Windows.Forms.Label
    Friend WithEvents cboTipo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label

End Class
