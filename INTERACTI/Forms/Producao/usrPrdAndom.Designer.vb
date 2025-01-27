<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usrPrdAndom
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim cboCentroTrabalho_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrPrdAndom))
        Dim grdMaquinaAtual_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim grdFatosRelevantes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagListagem = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboCentroTrabalho = New Janus.Windows.GridEX.EditControls.CheckedComboBox()
        Me.lblCentroTrabalho = New System.Windows.Forms.Label()
        Me.tabDados = New Janus.Windows.UI.Tab.UITab()
        Me.pagVisao = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.grdMaquinaAtual = New Janus.Windows.GridEX.GridEX()
        Me.pagFatosRelevantes = New Janus.Windows.UI.Tab.UITabPage()
        Me.grdFatosRelevantes = New Janus.Windows.GridEX.GridEX()
        Me.jstMain = New Janus.Windows.Common.JanusSuperTip(Me.components)
        Me.pagSintetico = New Janus.Windows.UI.Tab.UITabPage()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagListagem.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDados.SuspendLayout()
        Me.pagVisao.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMaquinaAtual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagFatosRelevantes.SuspendLayout()
        CType(Me.grdFatosRelevantes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(966, 459)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagListagem})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagListagem
        '
        Me.pagListagem.Controls.Add(Me.grpFiltro)
        Me.pagListagem.Controls.Add(Me.tabDados)
        Me.pagListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagListagem.Key = "pagListagem"
        Me.pagListagem.Location = New System.Drawing.Point(1, 22)
        Me.pagListagem.Name = "pagListagem"
        Me.pagListagem.Size = New System.Drawing.Size(964, 436)
        Me.pagListagem.TabStop = True
        Me.pagListagem.Text = "ANDOM"
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboCentroTrabalho)
        Me.grpFiltro.Controls.Add(Me.lblCentroTrabalho)
        Me.grpFiltro.Location = New System.Drawing.Point(7, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(950, 68)
        Me.grpFiltro.TabIndex = 39
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboCentroTrabalho
        '
        Me.cboCentroTrabalho.AllowDrop = True
        Me.cboCentroTrabalho.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCentroTrabalho.ButtonCancelText = "Cancelar"
        Me.cboCentroTrabalho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cboCentroTrabalho_DesignTimeLayout.LayoutString = resources.GetString("cboCentroTrabalho_DesignTimeLayout.LayoutString")
        Me.cboCentroTrabalho.DesignTimeLayout = cboCentroTrabalho_DesignTimeLayout
        Me.cboCentroTrabalho.Location = New System.Drawing.Point(9, 34)
        Me.cboCentroTrabalho.Name = "cboCentroTrabalho"
        Me.cboCentroTrabalho.SaveSettings = False
        Me.cboCentroTrabalho.SettingsKey = "cboCentroTrabalho"
        Me.cboCentroTrabalho.Size = New System.Drawing.Size(935, 20)
        Me.cboCentroTrabalho.TabIndex = 35
        Me.cboCentroTrabalho.ValuesDataMember = Nothing
        '
        'lblCentroTrabalho
        '
        Me.lblCentroTrabalho.AutoSize = True
        Me.lblCentroTrabalho.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCentroTrabalho.Location = New System.Drawing.Point(6, 17)
        Me.lblCentroTrabalho.Name = "lblCentroTrabalho"
        Me.lblCentroTrabalho.Size = New System.Drawing.Size(102, 14)
        Me.lblCentroTrabalho.TabIndex = 34
        Me.lblCentroTrabalho.Text = "Centro de Trabalho:"
        '
        'tabDados
        '
        Me.tabDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDados.BackColor = System.Drawing.Color.Transparent
        Me.tabDados.FocusOnClick = False
        Me.tabDados.Location = New System.Drawing.Point(3, 77)
        Me.tabDados.Name = "tabDados"
        Me.tabDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabDados.ShowFocusRectangle = False
        Me.tabDados.Size = New System.Drawing.Size(955, 349)
        Me.tabDados.TabIndex = 38
        Me.tabDados.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagVisao, Me.pagFatosRelevantes})
        Me.tabDados.TabStop = False
        Me.tabDados.VisualStyleManager = Me.vsmMain
        '
        'pagVisao
        '
        Me.pagVisao.Controls.Add(Me.grpLegenda)
        Me.pagVisao.Controls.Add(Me.grdMaquinaAtual)
        Me.pagVisao.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagVisao.Key = "pagVisao"
        Me.pagVisao.Location = New System.Drawing.Point(1, 22)
        Me.pagVisao.Name = "pagVisao"
        Me.pagVisao.Size = New System.Drawing.Size(953, 326)
        Me.pagVisao.TabStop = True
        Me.pagVisao.Text = "Visão de Produção"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.Label1)
        Me.grpLegenda.Controls.Add(Me.PictureBox1)
        Me.grpLegenda.Controls.Add(Me.Label2)
        Me.grpLegenda.Controls.Add(Me.PictureBox2)
        Me.grpLegenda.Controls.Add(Me.Label3)
        Me.grpLegenda.Controls.Add(Me.PictureBox3)
        Me.grpLegenda.Controls.Add(Me.Label4)
        Me.grpLegenda.Controls.Add(Me.PictureBox4)
        Me.grpLegenda.Controls.Add(Me.Label5)
        Me.grpLegenda.Controls.Add(Me.PictureBox5)
        Me.grpLegenda.Controls.Add(Me.Label6)
        Me.grpLegenda.Controls.Add(Me.PictureBox6)
        Me.grpLegenda.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLegenda.Location = New System.Drawing.Point(3, 0)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(947, 32)
        Me.grpLegenda.TabIndex = 38
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(386, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 14)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "RNC"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Purple
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(367, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(13, 14)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(457, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 14)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Sem atividade"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(438, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(13, 14)
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Atrasado"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Firebrick
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(96, 13)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(13, 14)
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(201, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 14)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Produção"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Location = New System.Drawing.Point(182, 13)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(13, 14)
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(288, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 14)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Manutenção"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.DarkBlue
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Location = New System.Drawing.Point(269, 13)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(13, 14)
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Setup"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Location = New System.Drawing.Point(9, 13)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(13, 14)
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        '
        'grdMaquinaAtual
        '
        Me.grdMaquinaAtual.AlternatingColors = True
        Me.grdMaquinaAtual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdMaquinaAtual.CardSpacing = 0
        Me.grdMaquinaAtual.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Both
        grdMaquinaAtual_DesignTimeLayout.LayoutString = resources.GetString("grdMaquinaAtual_DesignTimeLayout.LayoutString")
        Me.grdMaquinaAtual.DesignTimeLayout = grdMaquinaAtual_DesignTimeLayout
        Me.grdMaquinaAtual.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdMaquinaAtual.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdMaquinaAtual.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdMaquinaAtual.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdMaquinaAtual.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdMaquinaAtual.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdMaquinaAtual.GroupByBoxVisible = False
        Me.grdMaquinaAtual.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdMaquinaAtual.Location = New System.Drawing.Point(3, 38)
        Me.grdMaquinaAtual.Name = "grdMaquinaAtual"
        Me.grdMaquinaAtual.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdMaquinaAtual.RecordNavigator = True
        Me.grdMaquinaAtual.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.grdMaquinaAtual.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdMaquinaAtual.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdMaquinaAtual.Size = New System.Drawing.Size(947, 282)
        Me.grdMaquinaAtual.TabIndex = 10
        Me.grdMaquinaAtual.TabStop = False
        Me.grdMaquinaAtual.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdMaquinaAtual.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdMaquinaAtual.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdMaquinaAtual.View = Janus.Windows.GridEX.View.CardView
        Me.grdMaquinaAtual.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdMaquinaAtual.VisualStyleManager = Me.vsmMain
        '
        'pagFatosRelevantes
        '
        Me.pagFatosRelevantes.Controls.Add(Me.grdFatosRelevantes)
        Me.pagFatosRelevantes.Key = "pagFatosRelevantes"
        Me.pagFatosRelevantes.Location = New System.Drawing.Point(1, 22)
        Me.pagFatosRelevantes.Name = "pagFatosRelevantes"
        Me.pagFatosRelevantes.Size = New System.Drawing.Size(953, 326)
        Me.pagFatosRelevantes.TabStop = True
        Me.pagFatosRelevantes.Text = "Fatos Relevantes"
        '
        'grdFatosRelevantes
        '
        Me.grdFatosRelevantes.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdFatosRelevantes.AlternatingColors = True
        Me.grdFatosRelevantes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdFatosRelevantes_DesignTimeLayout.LayoutString = resources.GetString("grdFatosRelevantes_DesignTimeLayout.LayoutString")
        Me.grdFatosRelevantes.DesignTimeLayout = grdFatosRelevantes_DesignTimeLayout
        Me.grdFatosRelevantes.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdFatosRelevantes.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdFatosRelevantes.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdFatosRelevantes.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdFatosRelevantes.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdFatosRelevantes.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdFatosRelevantes.GroupByBoxVisible = False
        Me.grdFatosRelevantes.Location = New System.Drawing.Point(3, 4)
        Me.grdFatosRelevantes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdFatosRelevantes.Name = "grdFatosRelevantes"
        Me.grdFatosRelevantes.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdFatosRelevantes.RecordNavigator = True
        Me.grdFatosRelevantes.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdFatosRelevantes.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdFatosRelevantes.Size = New System.Drawing.Size(948, 318)
        Me.grdFatosRelevantes.TabIndex = 13
        Me.grdFatosRelevantes.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        Me.grdFatosRelevantes.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdFatosRelevantes.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdFatosRelevantes.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdFatosRelevantes.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdFatosRelevantes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdFatosRelevantes.VisualStyleManager = Me.vsmMain
        '
        'jstMain
        '
        Me.jstMain.AutoPopDelay = 60000
        Me.jstMain.ImageList = Nothing
        Me.jstMain.ShowAlways = True
        '
        'pagSintetico
        '
        Me.pagSintetico.Location = New System.Drawing.Point(1, 22)
        Me.pagSintetico.Name = "pagSintetico"
        Me.pagSintetico.Size = New System.Drawing.Size(946, 291)
        Me.pagSintetico.TabStop = True
        Me.pagSintetico.Text = "Sintético"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'usrPrdAndom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrPrdAndom"
        Me.Size = New System.Drawing.Size(966, 459)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagListagem.ResumeLayout(False)
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.tabDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDados.ResumeLayout(False)
        Me.pagVisao.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMaquinaAtual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagFatosRelevantes.ResumeLayout(False)
        CType(Me.grdFatosRelevantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagListagem As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents jstMain As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents pagSintetico As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tabDados As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagVisao As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents grdMaquinaAtual As Janus.Windows.GridEX.GridEX
    Friend WithEvents pagFatosRelevantes As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdFatosRelevantes As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCentroTrabalho As Label
    Friend WithEvents cboCentroTrabalho As Janus.Windows.GridEX.EditControls.CheckedComboBox
End Class
