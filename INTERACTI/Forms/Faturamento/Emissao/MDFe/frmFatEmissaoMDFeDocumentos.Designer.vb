<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEmissaoMDFeDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEmissaoMDFeDocumentos))
        Dim grdUnidadeCarga_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdUnidadeCarga_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagUnidadeTransporte = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpUnidadeTransporte = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblNumeroLacres = New System.Windows.Forms.Label()
        Me.txtNumeroLacres = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.txtQuantidadeRateada = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboTipo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblQuantidadeRateada = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.pagUnidadeCarga = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpUnidadeCarga = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnInserirUnidadeCarga = New Janus.Windows.EditControls.UIButton()
        Me.btnExcluirUnidadeCarga = New Janus.Windows.EditControls.UIButton()
        Me.btnConfigurarGridUnidadeCarga = New System.Windows.Forms.Button()
        Me.btnExcelGridUnidadeCarga = New System.Windows.Forms.Button()
        Me.btnAgruparGridUnidadeCarga = New System.Windows.Forms.Button()
        Me.grdUnidadeCarga = New Janus.Windows.GridEX.GridEX()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblChaveAcesso = New System.Windows.Forms.Label()
        Me.grpControles = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnInserir = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.cboChaveAcesso = New Janus.Windows.EditControls.UIComboBox()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagUnidadeTransporte.SuspendLayout()
        CType(Me.grpUnidadeTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUnidadeTransporte.SuspendLayout()
        Me.pagUnidadeCarga.SuspendLayout()
        CType(Me.grpUnidadeCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUnidadeCarga.SuspendLayout()
        CType(Me.grdUnidadeCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpControles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControles.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(914, 567)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.tabDados)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grpControles)
        Me.pagDados.Key = "pagTabela"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(912, 544)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Unidade Transporte"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.FocusOnClick = False
        Me.tabDados.Location = New System.Drawing.Point(8, 76)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(896, 402)
        Me.tabDados.TabIndex = 1
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagUnidadeTransporte, Me.pagUnidadeCarga})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagUnidadeTransporte
        '
        Me.pagUnidadeTransporte.Controls.Add(Me.grpUnidadeTransporte)
        Me.pagUnidadeTransporte.Key = "pagDI"
        Me.pagUnidadeTransporte.Location = New System.Drawing.Point(1, 22)
        Me.pagUnidadeTransporte.Name = "pagUnidadeTransporte"
        Me.pagUnidadeTransporte.Size = New System.Drawing.Size(894, 379)
        Me.pagUnidadeTransporte.TabStop = True
        Me.pagUnidadeTransporte.Text = "Unidade de Transporte"
        '
        'grpUnidadeTransporte
        '
        Me.grpUnidadeTransporte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpUnidadeTransporte.BackColor = System.Drawing.Color.Transparent
        Me.grpUnidadeTransporte.Controls.Add(Me.lblNumeroLacres)
        Me.grpUnidadeTransporte.Controls.Add(Me.txtNumeroLacres)
        Me.grpUnidadeTransporte.Controls.Add(Me.txtQuantidadeRateada)
        Me.grpUnidadeTransporte.Controls.Add(Me.cboTipo)
        Me.grpUnidadeTransporte.Controls.Add(Me.lblQuantidadeRateada)
        Me.grpUnidadeTransporte.Controls.Add(Me.lblTipo)
        Me.grpUnidadeTransporte.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpUnidadeTransporte.Location = New System.Drawing.Point(8, 4)
        Me.grpUnidadeTransporte.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpUnidadeTransporte.Name = "grpUnidadeTransporte"
        Me.grpUnidadeTransporte.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpUnidadeTransporte.Size = New System.Drawing.Size(878, 66)
        Me.grpUnidadeTransporte.TabIndex = 9
        Me.grpUnidadeTransporte.Text = "Dados"
        Me.grpUnidadeTransporte.VisualStyleManager = Me.vsmMain
        '
        'lblNumeroLacres
        '
        Me.lblNumeroLacres.AutoSize = True
        Me.lblNumeroLacres.Location = New System.Drawing.Point(380, 16)
        Me.lblNumeroLacres.Name = "lblNumeroLacres"
        Me.lblNumeroLacres.Size = New System.Drawing.Size(99, 14)
        Me.lblNumeroLacres.TabIndex = 108
        Me.lblNumeroLacres.Text = "Número de Lacres:"
        '
        'txtNumeroLacres
        '
        Me.txtNumeroLacres.BackColor = System.Drawing.Color.White
        Me.txtNumeroLacres.DecimalDigits = 0
        Me.txtNumeroLacres.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroLacres.Location = New System.Drawing.Point(383, 33)
        Me.txtNumeroLacres.MaxLength = 8
        Me.txtNumeroLacres.Name = "txtNumeroLacres"
        Me.txtNumeroLacres.Size = New System.Drawing.Size(172, 20)
        Me.txtNumeroLacres.TabIndex = 107
        Me.txtNumeroLacres.TabStop = False
        Me.txtNumeroLacres.Text = "0"
        Me.txtNumeroLacres.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtQuantidadeRateada
        '
        Me.txtQuantidadeRateada.BackColor = System.Drawing.Color.White
        Me.txtQuantidadeRateada.DecimalDigits = 0
        Me.txtQuantidadeRateada.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtQuantidadeRateada.Location = New System.Drawing.Point(205, 33)
        Me.txtQuantidadeRateada.MaxLength = 8
        Me.txtQuantidadeRateada.Name = "txtQuantidadeRateada"
        Me.txtQuantidadeRateada.Size = New System.Drawing.Size(172, 20)
        Me.txtQuantidadeRateada.TabIndex = 8
        Me.txtQuantidadeRateada.TabStop = False
        Me.txtQuantidadeRateada.Text = "0"
        Me.txtQuantidadeRateada.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cboTipo
        '
        Me.cboTipo.AutoSize = False
        Me.cboTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipo.Location = New System.Drawing.Point(9, 33)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipo.Size = New System.Drawing.Size(190, 20)
        Me.cboTipo.TabIndex = 106
        '
        'lblQuantidadeRateada
        '
        Me.lblQuantidadeRateada.AutoSize = True
        Me.lblQuantidadeRateada.Location = New System.Drawing.Point(202, 16)
        Me.lblQuantidadeRateada.Name = "lblQuantidadeRateada"
        Me.lblQuantidadeRateada.Size = New System.Drawing.Size(108, 14)
        Me.lblQuantidadeRateada.TabIndex = 4
        Me.lblQuantidadeRateada.Text = "Quantidade Rateada:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipo.Location = New System.Drawing.Point(6, 16)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 14)
        Me.lblTipo.TabIndex = 105
        Me.lblTipo.Text = "Tipo:"
        '
        'pagUnidadeCarga
        '
        Me.pagUnidadeCarga.Controls.Add(Me.grpUnidadeCarga)
        Me.pagUnidadeCarga.Location = New System.Drawing.Point(1, 22)
        Me.pagUnidadeCarga.Name = "pagUnidadeCarga"
        Me.pagUnidadeCarga.Size = New System.Drawing.Size(894, 379)
        Me.pagUnidadeCarga.TabStop = True
        Me.pagUnidadeCarga.Text = "Unidade de Carga"
        '
        'grpUnidadeCarga
        '
        Me.grpUnidadeCarga.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpUnidadeCarga.BackColor = System.Drawing.Color.Transparent
        Me.grpUnidadeCarga.Controls.Add(Me.btnInserirUnidadeCarga)
        Me.grpUnidadeCarga.Controls.Add(Me.btnExcluirUnidadeCarga)
        Me.grpUnidadeCarga.Controls.Add(Me.btnConfigurarGridUnidadeCarga)
        Me.grpUnidadeCarga.Controls.Add(Me.btnExcelGridUnidadeCarga)
        Me.grpUnidadeCarga.Controls.Add(Me.btnAgruparGridUnidadeCarga)
        Me.grpUnidadeCarga.Controls.Add(Me.grdUnidadeCarga)
        Me.grpUnidadeCarga.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpUnidadeCarga.Location = New System.Drawing.Point(8, 4)
        Me.grpUnidadeCarga.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpUnidadeCarga.Name = "grpUnidadeCarga"
        Me.grpUnidadeCarga.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpUnidadeCarga.Size = New System.Drawing.Size(880, 371)
        Me.grpUnidadeCarga.TabIndex = 0
        Me.grpUnidadeCarga.Text = "Documentos"
        Me.grpUnidadeCarga.VisualStyleManager = Me.vsmMain
        '
        'btnInserirUnidadeCarga
        '
        Me.btnInserirUnidadeCarga.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserirUnidadeCarga.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnInserirUnidadeCarga.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirUnidadeCarga.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserirUnidadeCarga.Location = New System.Drawing.Point(690, 342)
        Me.btnInserirUnidadeCarga.Name = "btnInserirUnidadeCarga"
        Me.btnInserirUnidadeCarga.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirUnidadeCarga.Size = New System.Drawing.Size(91, 23)
        Me.btnInserirUnidadeCarga.TabIndex = 3
        Me.btnInserirUnidadeCarga.Text = "Inserir"
        Me.btnInserirUnidadeCarga.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExcluirUnidadeCarga
        '
        Me.btnExcluirUnidadeCarga.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluirUnidadeCarga.Image = CType(resources.GetObject("btnExcluirUnidadeCarga.Image"), System.Drawing.Image)
        Me.btnExcluirUnidadeCarga.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluirUnidadeCarga.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluirUnidadeCarga.Location = New System.Drawing.Point(787, 342)
        Me.btnExcluirUnidadeCarga.Name = "btnExcluirUnidadeCarga"
        Me.btnExcluirUnidadeCarga.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluirUnidadeCarga.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluirUnidadeCarga.TabIndex = 4
        Me.btnExcluirUnidadeCarga.Text = "Excluir"
        Me.btnExcluirUnidadeCarga.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnConfigurarGridUnidadeCarga
        '
        Me.btnConfigurarGridUnidadeCarga.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGridUnidadeCarga.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGridUnidadeCarga.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGridUnidadeCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGridUnidadeCarga.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGridUnidadeCarga.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGridUnidadeCarga.Location = New System.Drawing.Point(9, 318)
        Me.btnConfigurarGridUnidadeCarga.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGridUnidadeCarga.Name = "btnConfigurarGridUnidadeCarga"
        Me.btnConfigurarGridUnidadeCarga.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGridUnidadeCarga.TabIndex = 1
        Me.btnConfigurarGridUnidadeCarga.TabStop = False
        Me.btnConfigurarGridUnidadeCarga.UseVisualStyleBackColor = False
        '
        'btnExcelGridUnidadeCarga
        '
        Me.btnExcelGridUnidadeCarga.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExcelGridUnidadeCarga.BackColor = System.Drawing.Color.Transparent
        Me.btnExcelGridUnidadeCarga.FlatAppearance.BorderSize = 0
        Me.btnExcelGridUnidadeCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcelGridUnidadeCarga.Image = Global.INTERACTI.My.Resources.Resources.excel
        Me.btnExcelGridUnidadeCarga.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExcelGridUnidadeCarga.Location = New System.Drawing.Point(57, 318)
        Me.btnExcelGridUnidadeCarga.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGridUnidadeCarga.Name = "btnExcelGridUnidadeCarga"
        Me.btnExcelGridUnidadeCarga.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGridUnidadeCarga.TabIndex = 2
        Me.btnExcelGridUnidadeCarga.TabStop = False
        Me.btnExcelGridUnidadeCarga.UseVisualStyleBackColor = False
        '
        'btnAgruparGridUnidadeCarga
        '
        Me.btnAgruparGridUnidadeCarga.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGridUnidadeCarga.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGridUnidadeCarga.FlatAppearance.BorderSize = 0
        Me.btnAgruparGridUnidadeCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGridUnidadeCarga.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGridUnidadeCarga.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGridUnidadeCarga.Location = New System.Drawing.Point(33, 318)
        Me.btnAgruparGridUnidadeCarga.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGridUnidadeCarga.Name = "btnAgruparGridUnidadeCarga"
        Me.btnAgruparGridUnidadeCarga.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGridUnidadeCarga.TabIndex = 113
        Me.btnAgruparGridUnidadeCarga.TabStop = False
        Me.btnAgruparGridUnidadeCarga.UseVisualStyleBackColor = False
        '
        'grdUnidadeCarga
        '
        Me.grdUnidadeCarga.AllowDrop = True
        Me.grdUnidadeCarga.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdUnidadeCarga.AlternatingColors = True
        Me.grdUnidadeCarga.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdUnidadeCarga.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        Me.grdUnidadeCarga.ColumnAutoResize = True
        grdUnidadeCarga_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdUnidadeCarga_DesignTimeLayout_Reference_0.Instance"), Object)
        grdUnidadeCarga_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdUnidadeCarga_DesignTimeLayout_Reference_0})
        grdUnidadeCarga_DesignTimeLayout.LayoutString = resources.GetString("grdUnidadeCarga_DesignTimeLayout.LayoutString")
        Me.grdUnidadeCarga.DesignTimeLayout = grdUnidadeCarga_DesignTimeLayout
        Me.grdUnidadeCarga.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdUnidadeCarga.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdUnidadeCarga.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdUnidadeCarga.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdUnidadeCarga.FocusCellFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdUnidadeCarga.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdUnidadeCarga.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdUnidadeCarga.FrozenColumns = 3
        Me.grdUnidadeCarga.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdUnidadeCarga.GroupByBoxVisible = False
        Me.grdUnidadeCarga.Location = New System.Drawing.Point(6, 20)
        Me.grdUnidadeCarga.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdUnidadeCarga.Name = "grdUnidadeCarga"
        Me.grdUnidadeCarga.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdUnidadeCarga.RecordNavigator = True
        Me.grdUnidadeCarga.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.grdUnidadeCarga.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdUnidadeCarga.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdUnidadeCarga.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdUnidadeCarga.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdUnidadeCarga.Size = New System.Drawing.Size(868, 315)
        Me.grdUnidadeCarga.TabIndex = 0
        Me.grdUnidadeCarga.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdUnidadeCarga.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdUnidadeCarga.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdUnidadeCarga.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdUnidadeCarga.VisualStyleManager = Me.vsmMain
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.cboChaveAcesso)
        Me.grpDados.Controls.Add(Me.lblChaveAcesso)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(896, 66)
        Me.grpDados.TabIndex = 0
        Me.grpDados.Text = "Geral"
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'lblChaveAcesso
        '
        Me.lblChaveAcesso.AutoSize = True
        Me.lblChaveAcesso.Location = New System.Drawing.Point(6, 20)
        Me.lblChaveAcesso.Name = "lblChaveAcesso"
        Me.lblChaveAcesso.Size = New System.Drawing.Size(96, 14)
        Me.lblChaveAcesso.TabIndex = 0
        Me.lblChaveAcesso.Text = "Chave de Acesso:"
        '
        'grpControles
        '
        Me.grpControles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControles.BackColor = System.Drawing.Color.Transparent
        Me.grpControles.Controls.Add(Me.btnInserir)
        Me.grpControles.Controls.Add(Me.btnSair)
        Me.grpControles.Location = New System.Drawing.Point(8, 483)
        Me.grpControles.Name = "grpControles"
        Me.grpControles.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControles.Size = New System.Drawing.Size(896, 52)
        Me.grpControles.TabIndex = 2
        Me.grpControles.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControles.VisualStyleManager = Me.vsmMain
        '
        'btnInserir
        '
        Me.btnInserir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInserir.Image = CType(resources.GetObject("btnInserir.Image"), System.Drawing.Image)
        Me.btnInserir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserir.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnInserir.Location = New System.Drawing.Point(699, 17)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserir.Size = New System.Drawing.Size(91, 23)
        Me.btnInserir.TabIndex = 0
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(796, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboChaveAcesso
        '
        Me.cboChaveAcesso.AutoSize = False
        Me.cboChaveAcesso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboChaveAcesso.Location = New System.Drawing.Point(9, 37)
        Me.cboChaveAcesso.Name = "cboChaveAcesso"
        Me.cboChaveAcesso.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboChaveAcesso.Size = New System.Drawing.Size(377, 20)
        Me.cboChaveAcesso.TabIndex = 109
        '
        'frmFatEmissaoMDFeDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 582)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFatEmissaoMDFeDocumentos"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manifesto de Documentos Eletrônico"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagUnidadeTransporte.ResumeLayout(False)
        CType(Me.grpUnidadeTransporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUnidadeTransporte.ResumeLayout(False)
        Me.grpUnidadeTransporte.PerformLayout()
        Me.pagUnidadeCarga.ResumeLayout(False)
        CType(Me.grpUnidadeCarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUnidadeCarga.ResumeLayout(False)
        CType(Me.grdUnidadeCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControles As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblChaveAcesso As System.Windows.Forms.Label
    Friend WithEvents btnInserir As Janus.Windows.EditControls.UIButton
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagUnidadeTransporte As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpUnidadeTransporte As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtQuantidadeRateada As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboTipo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblQuantidadeRateada As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents pagUnidadeCarga As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpUnidadeCarga As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnInserirUnidadeCarga As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcluirUnidadeCarga As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnConfigurarGridUnidadeCarga As System.Windows.Forms.Button
    Friend WithEvents btnExcelGridUnidadeCarga As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGridUnidadeCarga As System.Windows.Forms.Button
    Friend WithEvents grdUnidadeCarga As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblNumeroLacres As System.Windows.Forms.Label
    Friend WithEvents txtNumeroLacres As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents cboChaveAcesso As Janus.Windows.EditControls.UIComboBox
End Class
