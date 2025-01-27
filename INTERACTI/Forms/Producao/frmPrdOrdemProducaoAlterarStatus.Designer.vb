<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrdOrdemProducaoAlterarStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrdOrdemProducaoAlterarStatus))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagTabela = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpLegenda = New Janus.Windows.EditControls.UIGroupBox()
        Me.picLegenda11 = New System.Windows.Forms.PictureBox()
        Me.lblLegenda11 = New System.Windows.Forms.Label()
        Me.picLegenda13 = New System.Windows.Forms.PictureBox()
        Me.lblLegenda13 = New System.Windows.Forms.Label()
        Me.picLegenda12 = New System.Windows.Forms.PictureBox()
        Me.picLegenda5 = New System.Windows.Forms.PictureBox()
        Me.lblLegenda5 = New System.Windows.Forms.Label()
        Me.lblLegenda12 = New System.Windows.Forms.Label()
        Me.picLegenda7 = New System.Windows.Forms.PictureBox()
        Me.lblLegenda7 = New System.Windows.Forms.Label()
        Me.lblLegenda10 = New System.Windows.Forms.Label()
        Me.picLegenda10 = New System.Windows.Forms.PictureBox()
        Me.lblLegenda2 = New System.Windows.Forms.Label()
        Me.picLegenda2 = New System.Windows.Forms.PictureBox()
        Me.lblLegenda4 = New System.Windows.Forms.Label()
        Me.picLegenda4 = New System.Windows.Forms.PictureBox()
        Me.lblLegenda6 = New System.Windows.Forms.Label()
        Me.picLegenda6 = New System.Windows.Forms.PictureBox()
        Me.picLegenda8 = New System.Windows.Forms.PictureBox()
        Me.lblLegenda8 = New System.Windows.Forms.Label()
        Me.picLegenda1 = New System.Windows.Forms.PictureBox()
        Me.lblLegenda9 = New System.Windows.Forms.Label()
        Me.picLegenda9 = New System.Windows.Forms.PictureBox()
        Me.lblLegenda1 = New System.Windows.Forms.Label()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControl2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnStatus = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagTabela.SuspendLayout()
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLegenda.SuspendLayout()
        CType(Me.picLegenda11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegenda13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegenda12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegenda5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegenda7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegenda10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegenda2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegenda4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegenda6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegenda8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegenda1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLegenda9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Size = New System.Drawing.Size(843, 509)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagTabela})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagTabela
        '
        Me.pagTabela.Controls.Add(Me.grpLegenda)
        Me.pagTabela.Controls.Add(Me.grdListagem)
        Me.pagTabela.Controls.Add(Me.grpControl2)
        Me.pagTabela.Key = "pagTabela"
        Me.pagTabela.Location = New System.Drawing.Point(1, 24)
        Me.pagTabela.Name = "pagTabela"
        Me.pagTabela.Size = New System.Drawing.Size(841, 484)
        Me.pagTabela.TabStop = True
        Me.pagTabela.Text = "Alterar Status"
        '
        'grpLegenda
        '
        Me.grpLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpLegenda.BackColor = System.Drawing.Color.Transparent
        Me.grpLegenda.Controls.Add(Me.picLegenda11)
        Me.grpLegenda.Controls.Add(Me.lblLegenda11)
        Me.grpLegenda.Controls.Add(Me.picLegenda13)
        Me.grpLegenda.Controls.Add(Me.lblLegenda13)
        Me.grpLegenda.Controls.Add(Me.picLegenda12)
        Me.grpLegenda.Controls.Add(Me.picLegenda5)
        Me.grpLegenda.Controls.Add(Me.lblLegenda5)
        Me.grpLegenda.Controls.Add(Me.lblLegenda12)
        Me.grpLegenda.Controls.Add(Me.picLegenda7)
        Me.grpLegenda.Controls.Add(Me.lblLegenda7)
        Me.grpLegenda.Controls.Add(Me.lblLegenda10)
        Me.grpLegenda.Controls.Add(Me.picLegenda10)
        Me.grpLegenda.Controls.Add(Me.lblLegenda2)
        Me.grpLegenda.Controls.Add(Me.picLegenda2)
        Me.grpLegenda.Controls.Add(Me.lblLegenda4)
        Me.grpLegenda.Controls.Add(Me.picLegenda4)
        Me.grpLegenda.Controls.Add(Me.lblLegenda6)
        Me.grpLegenda.Controls.Add(Me.picLegenda6)
        Me.grpLegenda.Controls.Add(Me.picLegenda8)
        Me.grpLegenda.Controls.Add(Me.lblLegenda8)
        Me.grpLegenda.Controls.Add(Me.picLegenda1)
        Me.grpLegenda.Controls.Add(Me.lblLegenda9)
        Me.grpLegenda.Controls.Add(Me.picLegenda9)
        Me.grpLegenda.Controls.Add(Me.lblLegenda1)
        Me.grpLegenda.Location = New System.Drawing.Point(8, 421)
        Me.grpLegenda.Name = "grpLegenda"
        Me.grpLegenda.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLegenda.Size = New System.Drawing.Size(539, 55)
        Me.grpLegenda.TabIndex = 97
        Me.grpLegenda.VisualStyleManager = Me.vsmMain
        '
        'picLegenda11
        '
        Me.picLegenda11.BackColor = System.Drawing.Color.Cyan
        Me.picLegenda11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegenda11.Location = New System.Drawing.Point(276, 9)
        Me.picLegenda11.Name = "picLegenda11"
        Me.picLegenda11.Size = New System.Drawing.Size(13, 14)
        Me.picLegenda11.TabIndex = 38
        Me.picLegenda11.TabStop = False
        '
        'lblLegenda11
        '
        Me.lblLegenda11.AutoSize = True
        Me.lblLegenda11.Location = New System.Drawing.Point(295, 9)
        Me.lblLegenda11.Name = "lblLegenda11"
        Me.lblLegenda11.Size = New System.Drawing.Size(78, 16)
        Me.lblLegenda11.TabIndex = 37
        Me.lblLegenda11.Text = "Retrabalho"
        '
        'picLegenda13
        '
        Me.picLegenda13.BackColor = System.Drawing.Color.Purple
        Me.picLegenda13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegenda13.Location = New System.Drawing.Point(135, 24)
        Me.picLegenda13.Name = "picLegenda13"
        Me.picLegenda13.Size = New System.Drawing.Size(13, 14)
        Me.picLegenda13.TabIndex = 36
        Me.picLegenda13.TabStop = False
        '
        'lblLegenda13
        '
        Me.lblLegenda13.AutoSize = True
        Me.lblLegenda13.Location = New System.Drawing.Point(154, 24)
        Me.lblLegenda13.Name = "lblLegenda13"
        Me.lblLegenda13.Size = New System.Drawing.Size(154, 16)
        Me.lblLegenda13.TabIndex = 35
        Me.lblLegenda13.Text = "Em Setup Ferramentas"
        '
        'picLegenda12
        '
        Me.picLegenda12.BackColor = System.Drawing.Color.Black
        Me.picLegenda12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegenda12.Location = New System.Drawing.Point(135, 9)
        Me.picLegenda12.Name = "picLegenda12"
        Me.picLegenda12.Size = New System.Drawing.Size(13, 14)
        Me.picLegenda12.TabIndex = 34
        Me.picLegenda12.TabStop = False
        '
        'picLegenda5
        '
        Me.picLegenda5.BackColor = System.Drawing.Color.Red
        Me.picLegenda5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegenda5.Location = New System.Drawing.Point(411, 9)
        Me.picLegenda5.Name = "picLegenda5"
        Me.picLegenda5.Size = New System.Drawing.Size(13, 14)
        Me.picLegenda5.TabIndex = 32
        Me.picLegenda5.TabStop = False
        '
        'lblLegenda5
        '
        Me.lblLegenda5.AutoSize = True
        Me.lblLegenda5.Location = New System.Drawing.Point(430, 9)
        Me.lblLegenda5.Name = "lblLegenda5"
        Me.lblLegenda5.Size = New System.Drawing.Size(78, 16)
        Me.lblLegenda5.TabIndex = 31
        Me.lblLegenda5.Text = "Reprovada"
        '
        'lblLegenda12
        '
        Me.lblLegenda12.AutoSize = True
        Me.lblLegenda12.Location = New System.Drawing.Point(154, 9)
        Me.lblLegenda12.Name = "lblLegenda12"
        Me.lblLegenda12.Size = New System.Drawing.Size(117, 16)
        Me.lblLegenda12.TabIndex = 33
        Me.lblLegenda12.Text = "Em Programação"
        '
        'picLegenda7
        '
        Me.picLegenda7.BackColor = System.Drawing.Color.ForestGreen
        Me.picLegenda7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegenda7.Location = New System.Drawing.Point(276, 39)
        Me.picLegenda7.Name = "picLegenda7"
        Me.picLegenda7.Size = New System.Drawing.Size(13, 14)
        Me.picLegenda7.TabIndex = 30
        Me.picLegenda7.TabStop = False
        '
        'lblLegenda7
        '
        Me.lblLegenda7.AutoSize = True
        Me.lblLegenda7.Location = New System.Drawing.Point(295, 39)
        Me.lblLegenda7.Name = "lblLegenda7"
        Me.lblLegenda7.Size = New System.Drawing.Size(142, 16)
        Me.lblLegenda7.TabIndex = 29
        Me.lblLegenda7.Text = "Entregue / Finalizada"
        '
        'lblLegenda10
        '
        Me.lblLegenda10.AutoSize = True
        Me.lblLegenda10.Location = New System.Drawing.Point(430, 24)
        Me.lblLegenda10.Name = "lblLegenda10"
        Me.lblLegenda10.Size = New System.Drawing.Size(134, 16)
        Me.lblLegenda10.TabIndex = 28
        Me.lblLegenda10.Text = "Aguardando Cliente"
        '
        'picLegenda10
        '
        Me.picLegenda10.BackColor = System.Drawing.Color.Blue
        Me.picLegenda10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegenda10.Location = New System.Drawing.Point(411, 24)
        Me.picLegenda10.Name = "picLegenda10"
        Me.picLegenda10.Size = New System.Drawing.Size(13, 14)
        Me.picLegenda10.TabIndex = 27
        Me.picLegenda10.TabStop = False
        '
        'lblLegenda2
        '
        Me.lblLegenda2.AutoSize = True
        Me.lblLegenda2.Location = New System.Drawing.Point(295, 24)
        Me.lblLegenda2.Name = "lblLegenda2"
        Me.lblLegenda2.Size = New System.Drawing.Size(113, 16)
        Me.lblLegenda2.TabIndex = 26
        Me.lblLegenda2.Text = "Em Faturamento"
        '
        'picLegenda2
        '
        Me.picLegenda2.BackColor = System.Drawing.Color.DeepPink
        Me.picLegenda2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegenda2.Location = New System.Drawing.Point(276, 24)
        Me.picLegenda2.Name = "picLegenda2"
        Me.picLegenda2.Size = New System.Drawing.Size(13, 14)
        Me.picLegenda2.TabIndex = 25
        Me.picLegenda2.TabStop = False
        '
        'lblLegenda4
        '
        Me.lblLegenda4.AutoSize = True
        Me.lblLegenda4.Location = New System.Drawing.Point(430, 39)
        Me.lblLegenda4.Name = "lblLegenda4"
        Me.lblLegenda4.Size = New System.Drawing.Size(76, 16)
        Me.lblLegenda4.TabIndex = 23
        Me.lblLegenda4.Text = "Cancelada"
        '
        'picLegenda4
        '
        Me.picLegenda4.BackColor = System.Drawing.Color.Firebrick
        Me.picLegenda4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegenda4.Location = New System.Drawing.Point(411, 39)
        Me.picLegenda4.Name = "picLegenda4"
        Me.picLegenda4.Size = New System.Drawing.Size(13, 14)
        Me.picLegenda4.TabIndex = 24
        Me.picLegenda4.TabStop = False
        '
        'lblLegenda6
        '
        Me.lblLegenda6.AutoSize = True
        Me.lblLegenda6.Location = New System.Drawing.Point(154, 39)
        Me.lblLegenda6.Name = "lblLegenda6"
        Me.lblLegenda6.Size = New System.Drawing.Size(93, 16)
        Me.lblLegenda6.TabIndex = 20
        Me.lblLegenda6.Text = "Em Produção"
        '
        'picLegenda6
        '
        Me.picLegenda6.BackColor = System.Drawing.Color.Purple
        Me.picLegenda6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegenda6.Location = New System.Drawing.Point(135, 39)
        Me.picLegenda6.Name = "picLegenda6"
        Me.picLegenda6.Size = New System.Drawing.Size(13, 14)
        Me.picLegenda6.TabIndex = 19
        Me.picLegenda6.TabStop = False
        '
        'picLegenda8
        '
        Me.picLegenda8.BackColor = System.Drawing.Color.SteelBlue
        Me.picLegenda8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegenda8.Location = New System.Drawing.Point(9, 24)
        Me.picLegenda8.Name = "picLegenda8"
        Me.picLegenda8.Size = New System.Drawing.Size(13, 14)
        Me.picLegenda8.TabIndex = 18
        Me.picLegenda8.TabStop = False
        '
        'lblLegenda8
        '
        Me.lblLegenda8.AutoSize = True
        Me.lblLegenda8.Location = New System.Drawing.Point(28, 24)
        Me.lblLegenda8.Name = "lblLegenda8"
        Me.lblLegenda8.Size = New System.Drawing.Size(77, 16)
        Me.lblLegenda8.TabIndex = 17
        Me.lblLegenda8.Text = "Em Projeto"
        '
        'picLegenda1
        '
        Me.picLegenda1.BackColor = System.Drawing.Color.Gray
        Me.picLegenda1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegenda1.Location = New System.Drawing.Point(9, 9)
        Me.picLegenda1.Name = "picLegenda1"
        Me.picLegenda1.Size = New System.Drawing.Size(13, 14)
        Me.picLegenda1.TabIndex = 16
        Me.picLegenda1.TabStop = False
        '
        'lblLegenda9
        '
        Me.lblLegenda9.AutoSize = True
        Me.lblLegenda9.Location = New System.Drawing.Point(28, 39)
        Me.lblLegenda9.Name = "lblLegenda9"
        Me.lblLegenda9.Size = New System.Drawing.Size(91, 16)
        Me.lblLegenda9.TabIndex = 1
        Me.lblLegenda9.Text = "Em Processo"
        '
        'picLegenda9
        '
        Me.picLegenda9.BackColor = System.Drawing.Color.Orange
        Me.picLegenda9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLegenda9.Location = New System.Drawing.Point(9, 39)
        Me.picLegenda9.Name = "picLegenda9"
        Me.picLegenda9.Size = New System.Drawing.Size(13, 14)
        Me.picLegenda9.TabIndex = 14
        Me.picLegenda9.TabStop = False
        '
        'lblLegenda1
        '
        Me.lblLegenda1.AutoSize = True
        Me.lblLegenda1.Location = New System.Drawing.Point(28, 9)
        Me.lblLegenda1.Name = "lblLegenda1"
        Me.lblLegenda1.Size = New System.Drawing.Size(118, 16)
        Me.lblLegenda1.TabIndex = 0
        Me.lblLegenda1.Text = "Em Planejamento"
        '
        'grdListagem
        '
        Me.grdListagem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.DynamicFiltering = True
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdListagem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdListagem.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdListagem.Location = New System.Drawing.Point(8, 3)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(825, 412)
        Me.grdListagem.TabIndex = 4
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControl2
        '
        Me.grpControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl2.BackColor = System.Drawing.Color.Transparent
        Me.grpControl2.Controls.Add(Me.btnStatus)
        Me.grpControl2.Controls.Add(Me.btnSair)
        Me.grpControl2.Location = New System.Drawing.Point(553, 421)
        Me.grpControl2.Name = "grpControl2"
        Me.grpControl2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl2.Size = New System.Drawing.Size(280, 54)
        Me.grpControl2.TabIndex = 1
        Me.grpControl2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpControl2.VisualStyleManager = Me.vsmMain
        '
        'btnStatus
        '
        Me.btnStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStatus.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnStatus.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnStatus.Location = New System.Drawing.Point(6, 19)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnStatus.Size = New System.Drawing.Size(168, 23)
        Me.btnStatus.TabIndex = 33
        Me.btnStatus.Text = "Status"
        Me.btnStatus.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(180, 19)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'frmPrdOrdemProducaoAlterarStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 523)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrdOrdemProducaoAlterarStatus"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Alterar Status"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagTabela.ResumeLayout(False)
        CType(Me.grpLegenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLegenda.ResumeLayout(False)
        Me.grpLegenda.PerformLayout()
        CType(Me.picLegenda11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegenda13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegenda12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegenda5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegenda7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegenda10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegenda2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegenda4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegenda6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegenda8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegenda1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLegenda9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagTabela As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnStatus As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpLegenda As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picLegenda11 As PictureBox
    Friend WithEvents lblLegenda11 As Label
    Friend WithEvents picLegenda13 As PictureBox
    Friend WithEvents lblLegenda13 As Label
    Friend WithEvents picLegenda12 As PictureBox
    Friend WithEvents picLegenda5 As PictureBox
    Friend WithEvents lblLegenda5 As Label
    Friend WithEvents lblLegenda12 As Label
    Friend WithEvents picLegenda7 As PictureBox
    Friend WithEvents lblLegenda7 As Label
    Friend WithEvents lblLegenda10 As Label
    Friend WithEvents picLegenda10 As PictureBox
    Friend WithEvents lblLegenda2 As Label
    Friend WithEvents picLegenda2 As PictureBox
    Friend WithEvents lblLegenda4 As Label
    Friend WithEvents picLegenda4 As PictureBox
    Friend WithEvents lblLegenda6 As Label
    Friend WithEvents picLegenda6 As PictureBox
    Friend WithEvents picLegenda8 As PictureBox
    Friend WithEvents lblLegenda8 As Label
    Friend WithEvents picLegenda1 As PictureBox
    Friend WithEvents lblLegenda9 As Label
    Friend WithEvents picLegenda9 As PictureBox
    Friend WithEvents lblLegenda1 As Label
End Class
