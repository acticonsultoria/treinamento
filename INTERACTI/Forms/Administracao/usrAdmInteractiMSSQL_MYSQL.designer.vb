<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrAdmInteractiMSSQL_MYSQL
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
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrAdmInteractiMSSQL_MYSQL))
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdListagem_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.oPrgBar = New System.Windows.Forms.ProgressBar()
        Me.grpDiretorio = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtStringConnection = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblStringConnection = New System.Windows.Forms.Label()
        Me.btnDiretorioSQLines = New Janus.Windows.EditControls.UIButton()
        Me.txtDiretorioSQLines = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDiretorioSQLines = New System.Windows.Forms.Label()
        Me.btnDiretorioOutput = New Janus.Windows.EditControls.UIButton()
        Me.btnDiretorioInput = New Janus.Windows.EditControls.UIButton()
        Me.txtDiretorioInput = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtDiretorioOutput = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblDiretorioInput = New System.Windows.Forms.Label()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.btnExcelGrid = New System.Windows.Forms.Button()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnVerificarPendente = New Janus.Windows.EditControls.UIButton()
        Me.btnMigrar = New Janus.Windows.EditControls.UIButton()
        Me.btnExecutar = New Janus.Windows.EditControls.UIButton()
        Me.btnAgruparGrid = New System.Windows.Forms.Button()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnFiltrar = New Janus.Windows.EditControls.UIButton()
        Me.txtDefinicaoFiltro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblDefinition = New System.Windows.Forms.Label()
        Me.cboTipo = New Janus.Windows.EditControls.UIComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.btnConfigurarGrid = New System.Windows.Forms.Button()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpDiretorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDiretorio.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(915, 467)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.oPrgBar)
        Me.pagLista.Controls.Add(Me.grpDiretorio)
        Me.pagLista.Controls.Add(Me.btnExcelGrid)
        Me.pagLista.Controls.Add(Me.grpControl)
        Me.pagLista.Controls.Add(Me.btnAgruparGrid)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.btnConfigurarGrid)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 444)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Interacti - MSSQL -> MYSQL"
        '
        'oPrgBar
        '
        Me.oPrgBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oPrgBar.Location = New System.Drawing.Point(510, 259)
        Me.oPrgBar.Name = "oPrgBar"
        Me.oPrgBar.Size = New System.Drawing.Size(392, 51)
        Me.oPrgBar.TabIndex = 7
        '
        'grpDiretorio
        '
        Me.grpDiretorio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDiretorio.BackColor = System.Drawing.Color.Transparent
        Me.grpDiretorio.Controls.Add(Me.txtStringConnection)
        Me.grpDiretorio.Controls.Add(Me.lblStringConnection)
        Me.grpDiretorio.Controls.Add(Me.btnDiretorioSQLines)
        Me.grpDiretorio.Controls.Add(Me.txtDiretorioSQLines)
        Me.grpDiretorio.Controls.Add(Me.lblDiretorioSQLines)
        Me.grpDiretorio.Controls.Add(Me.btnDiretorioOutput)
        Me.grpDiretorio.Controls.Add(Me.btnDiretorioInput)
        Me.grpDiretorio.Controls.Add(Me.txtDiretorioInput)
        Me.grpDiretorio.Controls.Add(Me.txtDiretorioOutput)
        Me.grpDiretorio.Controls.Add(Me.lblOutput)
        Me.grpDiretorio.Controls.Add(Me.lblDiretorioInput)
        Me.grpDiretorio.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDiretorio.Location = New System.Drawing.Point(510, 6)
        Me.grpDiretorio.Name = "grpDiretorio"
        Me.grpDiretorio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDiretorio.Size = New System.Drawing.Size(395, 191)
        Me.grpDiretorio.TabIndex = 0
        Me.grpDiretorio.VisualStyleManager = Me.vsmMain
        '
        'txtStringConnection
        '
        Me.txtStringConnection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStringConnection.Location = New System.Drawing.Point(9, 162)
        Me.txtStringConnection.MaxLength = 500
        Me.txtStringConnection.Name = "txtStringConnection"
        Me.txtStringConnection.Size = New System.Drawing.Size(377, 20)
        Me.txtStringConnection.TabIndex = 10
        '
        'lblStringConnection
        '
        Me.lblStringConnection.AutoSize = True
        Me.lblStringConnection.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStringConnection.Location = New System.Drawing.Point(6, 145)
        Me.lblStringConnection.Name = "lblStringConnection"
        Me.lblStringConnection.Size = New System.Drawing.Size(95, 14)
        Me.lblStringConnection.TabIndex = 9
        Me.lblStringConnection.Text = "String Connection:"
        '
        'btnDiretorioSQLines
        '
        Me.btnDiretorioSQLines.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDiretorioSQLines.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnDiretorioSQLines.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnDiretorioSQLines.Location = New System.Drawing.Point(366, 120)
        Me.btnDiretorioSQLines.Name = "btnDiretorioSQLines"
        Me.btnDiretorioSQLines.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnDiretorioSQLines.Size = New System.Drawing.Size(20, 20)
        Me.btnDiretorioSQLines.TabIndex = 8
        Me.btnDiretorioSQLines.Text = "..."
        Me.btnDiretorioSQLines.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtDiretorioSQLines
        '
        Me.txtDiretorioSQLines.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiretorioSQLines.Location = New System.Drawing.Point(9, 120)
        Me.txtDiretorioSQLines.MaxLength = 500
        Me.txtDiretorioSQLines.Name = "txtDiretorioSQLines"
        Me.txtDiretorioSQLines.Size = New System.Drawing.Size(377, 20)
        Me.txtDiretorioSQLines.TabIndex = 7
        '
        'lblDiretorioSQLines
        '
        Me.lblDiretorioSQLines.AutoSize = True
        Me.lblDiretorioSQLines.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDiretorioSQLines.Location = New System.Drawing.Point(6, 103)
        Me.lblDiretorioSQLines.Name = "lblDiretorioSQLines"
        Me.lblDiretorioSQLines.Size = New System.Drawing.Size(94, 14)
        Me.lblDiretorioSQLines.TabIndex = 6
        Me.lblDiretorioSQLines.Text = "Diretório SQLines:"
        '
        'btnDiretorioOutput
        '
        Me.btnDiretorioOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDiretorioOutput.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnDiretorioOutput.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnDiretorioOutput.Location = New System.Drawing.Point(366, 76)
        Me.btnDiretorioOutput.Name = "btnDiretorioOutput"
        Me.btnDiretorioOutput.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnDiretorioOutput.Size = New System.Drawing.Size(20, 20)
        Me.btnDiretorioOutput.TabIndex = 5
        Me.btnDiretorioOutput.Text = "..."
        Me.btnDiretorioOutput.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnDiretorioInput
        '
        Me.btnDiretorioInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDiretorioInput.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnDiretorioInput.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnDiretorioInput.Location = New System.Drawing.Point(366, 34)
        Me.btnDiretorioInput.Name = "btnDiretorioInput"
        Me.btnDiretorioInput.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnDiretorioInput.Size = New System.Drawing.Size(20, 20)
        Me.btnDiretorioInput.TabIndex = 4
        Me.btnDiretorioInput.Text = "..."
        Me.btnDiretorioInput.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtDiretorioInput
        '
        Me.txtDiretorioInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiretorioInput.Location = New System.Drawing.Point(9, 34)
        Me.txtDiretorioInput.MaxLength = 500
        Me.txtDiretorioInput.Name = "txtDiretorioInput"
        Me.txtDiretorioInput.Size = New System.Drawing.Size(377, 20)
        Me.txtDiretorioInput.TabIndex = 1
        '
        'txtDiretorioOutput
        '
        Me.txtDiretorioOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiretorioOutput.Location = New System.Drawing.Point(9, 76)
        Me.txtDiretorioOutput.MaxLength = 500
        Me.txtDiretorioOutput.Name = "txtDiretorioOutput"
        Me.txtDiretorioOutput.Size = New System.Drawing.Size(377, 20)
        Me.txtDiretorioOutput.TabIndex = 3
        '
        'lblOutput
        '
        Me.lblOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOutput.AutoSize = True
        Me.lblOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOutput.Location = New System.Drawing.Point(6, 59)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(85, 14)
        Me.lblOutput.TabIndex = 2
        Me.lblOutput.Text = "Diretório Output:"
        '
        'lblDiretorioInput
        '
        Me.lblDiretorioInput.AutoSize = True
        Me.lblDiretorioInput.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDiretorioInput.Location = New System.Drawing.Point(6, 17)
        Me.lblDiretorioInput.Name = "lblDiretorioInput"
        Me.lblDiretorioInput.Size = New System.Drawing.Size(76, 14)
        Me.lblDiretorioInput.TabIndex = 0
        Me.lblDiretorioInput.Text = "Diretório Input:"
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
        Me.btnExcelGrid.Location = New System.Drawing.Point(58, 418)
        Me.btnExcelGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcelGrid.Name = "btnExcelGrid"
        Me.btnExcelGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnExcelGrid.TabIndex = 4
        Me.btnExcelGrid.TabStop = False
        Me.btnExcelGrid.UseVisualStyleBackColor = False
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnVerificarPendente)
        Me.grpControl.Controls.Add(Me.btnMigrar)
        Me.grpControl.Controls.Add(Me.btnExecutar)
        Me.grpControl.Location = New System.Drawing.Point(510, 203)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(395, 50)
        Me.grpControl.TabIndex = 6
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnVerificarPendente
        '
        Me.btnVerificarPendente.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnVerificarPendente.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnVerificarPendente.Location = New System.Drawing.Point(354, 17)
        Me.btnVerificarPendente.Name = "btnVerificarPendente"
        Me.btnVerificarPendente.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnVerificarPendente.Size = New System.Drawing.Size(183, 23)
        Me.btnVerificarPendente.TabIndex = 3
        Me.btnVerificarPendente.Text = "Verificar Pendente"
        Me.btnVerificarPendente.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnMigrar
        '
        Me.btnMigrar.Image = Global.INTERACTI.My.Resources.Resources.run
        Me.btnMigrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnMigrar.Location = New System.Drawing.Point(163, 17)
        Me.btnMigrar.Name = "btnMigrar"
        Me.btnMigrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnMigrar.Size = New System.Drawing.Size(185, 23)
        Me.btnMigrar.TabIndex = 2
        Me.btnMigrar.Text = "Gerar e executar no MySQL"
        Me.btnMigrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnExecutar
        '
        Me.btnExecutar.Image = Global.INTERACTI.My.Resources.Resources.run
        Me.btnExecutar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExecutar.Location = New System.Drawing.Point(9, 17)
        Me.btnExecutar.Name = "btnExecutar"
        Me.btnExecutar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExecutar.Size = New System.Drawing.Size(148, 23)
        Me.btnExecutar.TabIndex = 0
        Me.btnExecutar.Text = "Gerar Script"
        Me.btnExecutar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAgruparGrid
        '
        Me.btnAgruparGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgruparGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnAgruparGrid.FlatAppearance.BorderSize = 0
        Me.btnAgruparGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgruparGrid.Image = Global.INTERACTI.My.Resources.Resources.merge
        Me.btnAgruparGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgruparGrid.Location = New System.Drawing.Point(34, 418)
        Me.btnAgruparGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgruparGrid.Name = "btnAgruparGrid"
        Me.btnAgruparGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnAgruparGrid.TabIndex = 3
        Me.btnAgruparGrid.TabStop = False
        Me.btnAgruparGrid.UseVisualStyleBackColor = False
        '
        'grpFiltro
        '
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.btnFiltrar)
        Me.grpFiltro.Controls.Add(Me.txtDefinicaoFiltro)
        Me.grpFiltro.Controls.Add(Me.lblDefinition)
        Me.grpFiltro.Controls.Add(Me.cboTipo)
        Me.grpFiltro.Controls.Add(Me.lblTipo)
        Me.grpFiltro.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpFiltro.Location = New System.Drawing.Point(9, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(492, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Image = Global.INTERACTI.My.Resources.Resources.procurar
        Me.btnFiltrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFiltrar.Location = New System.Drawing.Point(393, 31)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFiltrar.Size = New System.Drawing.Size(90, 23)
        Me.btnFiltrar.TabIndex = 4
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtDefinicaoFiltro
        '
        Me.txtDefinicaoFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDefinicaoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDefinicaoFiltro.Location = New System.Drawing.Point(191, 34)
        Me.txtDefinicaoFiltro.MaxLength = 50
        Me.txtDefinicaoFiltro.Name = "txtDefinicaoFiltro"
        Me.txtDefinicaoFiltro.Size = New System.Drawing.Size(185, 20)
        Me.txtDefinicaoFiltro.TabIndex = 3
        '
        'lblDefinition
        '
        Me.lblDefinition.AutoSize = True
        Me.lblDefinition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDefinition.Location = New System.Drawing.Point(188, 17)
        Me.lblDefinition.Name = "lblDefinition"
        Me.lblDefinition.Size = New System.Drawing.Size(55, 14)
        Me.lblDefinition.TabIndex = 2
        Me.lblDefinition.Text = "Definição:"
        '
        'cboTipo
        '
        Me.cboTipo.AutoSize = False
        Me.cboTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTipo.Location = New System.Drawing.Point(9, 34)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboTipo.Size = New System.Drawing.Size(176, 20)
        Me.cboTipo.TabIndex = 1
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTipo.Location = New System.Drawing.Point(6, 17)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 14)
        Me.lblTipo.TabIndex = 0
        Me.lblTipo.Text = "Tipo:"
        '
        'btnConfigurarGrid
        '
        Me.btnConfigurarGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfigurarGrid.BackColor = System.Drawing.Color.Transparent
        Me.btnConfigurarGrid.FlatAppearance.BorderSize = 0
        Me.btnConfigurarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarGrid.Image = Global.INTERACTI.My.Resources.Resources.config
        Me.btnConfigurarGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConfigurarGrid.Location = New System.Drawing.Point(10, 418)
        Me.btnConfigurarGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConfigurarGrid.Name = "btnConfigurarGrid"
        Me.btnConfigurarGrid.Size = New System.Drawing.Size(24, 15)
        Me.btnConfigurarGrid.TabIndex = 2
        Me.btnConfigurarGrid.TabStop = False
        Me.btnConfigurarGrid.UseVisualStyleBackColor = False
        '
        'grdListagem
        '
        Me.grdListagem.AllowChildTableGroups = True
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdListagem.BuiltInTextsData = resources.GetString("grdListagem.BuiltInTextsData")
        grdListagem_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdListagem_DesignTimeLayout_Reference_0.Instance"), Object)
        grdListagem_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdListagem_DesignTimeLayout_Reference_0})
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.DynamicFiltering = True
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.Location = New System.Drawing.Point(9, 76)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
        Me.grdListagem.Size = New System.Drawing.Size(492, 359)
        Me.grdListagem.TabIndex = 1
        Me.grdListagem.TabStop = False
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'ToolTip
        '
        Me.ToolTip.AutomaticDelay = 0
        Me.ToolTip.AutoPopDelay = 5000
        Me.ToolTip.InitialDelay = 0
        Me.ToolTip.ReshowDelay = 0
        Me.ToolTip.ShowAlways = True
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'usrAdmInteractiMSSQL_MYSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "usrAdmInteractiMSSQL_MYSQL"
        Me.Size = New System.Drawing.Size(915, 467)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpDiretorio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDiretorio.ResumeLayout(False)
        Me.grpDiretorio.PerformLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDefinicaoFiltro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDefinition As System.Windows.Forms.Label
    Friend WithEvents cboTipo As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnExecutar As Janus.Windows.EditControls.UIButton

    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnFiltrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcelGrid As System.Windows.Forms.Button
    Friend WithEvents btnAgruparGrid As System.Windows.Forms.Button
    Friend WithEvents btnConfigurarGrid As System.Windows.Forms.Button
    Friend WithEvents grpDiretorio As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDiretorioInput As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDiretorioOutput As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents lblDiretorioInput As System.Windows.Forms.Label
    Friend WithEvents btnDiretorioOutput As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnDiretorioInput As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnMigrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnDiretorioSQLines As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtDiretorioSQLines As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblDiretorioSQLines As System.Windows.Forms.Label
    Friend WithEvents txtStringConnection As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblStringConnection As System.Windows.Forms.Label
    Friend WithEvents btnVerificarPendente As Janus.Windows.EditControls.UIButton
    Friend WithEvents oPrgBar As System.Windows.Forms.ProgressBar

End Class
