<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFatEntradaNFeAcaoEmLote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFatEntradaNFeAcaoEmLote))
        Dim grdDeposito_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagEstoque = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosEstoque = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSalvar2 = New Janus.Windows.EditControls.UIButton()
        Me.btnAlterarLocalizacao = New Janus.Windows.EditControls.UIButton()
        Me.btnAlterarDeposito = New Janus.Windows.EditControls.UIButton()
        Me.lblLocalizacao = New System.Windows.Forms.Label()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.cboDeposito = New Janus.Windows.EditControls.UIComboBox()
        Me.cboLocalizacao = New Janus.Windows.EditControls.UIComboBox()
        Me.btnSair2 = New Janus.Windows.EditControls.UIButton()
        Me.grdDeposito = New Janus.Windows.GridEX.GridEX()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagEstoque.SuspendLayout()
        CType(Me.grpDadosEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosEstoque.SuspendLayout()
        CType(Me.grdDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.ShowCloseButton = True
        Me.tabMain.Size = New System.Drawing.Size(914, 567)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagEstoque})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagEstoque
        '
        Me.pagEstoque.Controls.Add(Me.grpDadosEstoque)
        Me.pagEstoque.Controls.Add(Me.grdDeposito)
        Me.pagEstoque.Location = New System.Drawing.Point(1, 22)
        Me.pagEstoque.Name = "pagEstoque"
        Me.pagEstoque.Size = New System.Drawing.Size(912, 544)
        Me.pagEstoque.TabStop = True
        Me.pagEstoque.Text = "Dados do Estoque"
        '
        'grpDadosEstoque
        '
        Me.grpDadosEstoque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDadosEstoque.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosEstoque.Controls.Add(Me.btnSalvar2)
        Me.grpDadosEstoque.Controls.Add(Me.btnAlterarLocalizacao)
        Me.grpDadosEstoque.Controls.Add(Me.btnAlterarDeposito)
        Me.grpDadosEstoque.Controls.Add(Me.lblLocalizacao)
        Me.grpDadosEstoque.Controls.Add(Me.lblDeposito)
        Me.grpDadosEstoque.Controls.Add(Me.cboDeposito)
        Me.grpDadosEstoque.Controls.Add(Me.cboLocalizacao)
        Me.grpDadosEstoque.Controls.Add(Me.btnSair2)
        Me.grpDadosEstoque.Location = New System.Drawing.Point(8, 462)
        Me.grpDadosEstoque.Name = "grpDadosEstoque"
        Me.grpDadosEstoque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosEstoque.Size = New System.Drawing.Size(896, 75)
        Me.grpDadosEstoque.TabIndex = 5
        Me.grpDadosEstoque.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosEstoque.VisualStyleManager = Me.vsmMain
        '
        'btnSalvar2
        '
        Me.btnSalvar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar2.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar2.Location = New System.Drawing.Point(796, 12)
        Me.btnSalvar2.Name = "btnSalvar2"
        Me.btnSalvar2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar2.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar2.TabIndex = 27
        Me.btnSalvar2.Text = "Salvar"
        Me.btnSalvar2.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAlterarLocalizacao
        '
        Me.btnAlterarLocalizacao.Image = Global.INTERACTI.My.Resources.Resources.nota
        Me.btnAlterarLocalizacao.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAlterarLocalizacao.Location = New System.Drawing.Point(271, 40)
        Me.btnAlterarLocalizacao.Name = "btnAlterarLocalizacao"
        Me.btnAlterarLocalizacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAlterarLocalizacao.Size = New System.Drawing.Size(150, 23)
        Me.btnAlterarLocalizacao.TabIndex = 26
        Me.btnAlterarLocalizacao.Text = "Alterar Localização"
        Me.btnAlterarLocalizacao.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnAlterarDeposito
        '
        Me.btnAlterarDeposito.Image = Global.INTERACTI.My.Resources.Resources.truck
        Me.btnAlterarDeposito.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAlterarDeposito.Location = New System.Drawing.Point(271, 11)
        Me.btnAlterarDeposito.Name = "btnAlterarDeposito"
        Me.btnAlterarDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAlterarDeposito.Size = New System.Drawing.Size(150, 23)
        Me.btnAlterarDeposito.TabIndex = 23
        Me.btnAlterarDeposito.Text = "Alterar Depósito"
        Me.btnAlterarDeposito.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblLocalizacao
        '
        Me.lblLocalizacao.AutoSize = True
        Me.lblLocalizacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLocalizacao.Location = New System.Drawing.Point(6, 46)
        Me.lblLocalizacao.Name = "lblLocalizacao"
        Me.lblLocalizacao.Size = New System.Drawing.Size(68, 14)
        Me.lblLocalizacao.TabIndex = 24
        Me.lblLocalizacao.Text = "Localização:"
        '
        'lblDeposito
        '
        Me.lblDeposito.AutoSize = True
        Me.lblDeposito.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDeposito.Location = New System.Drawing.Point(6, 17)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(52, 14)
        Me.lblDeposito.TabIndex = 0
        Me.lblDeposito.Text = "Depósito:"
        '
        'cboDeposito
        '
        Me.cboDeposito.AutoSize = False
        Me.cboDeposito.Location = New System.Drawing.Point(80, 14)
        Me.cboDeposito.Name = "cboDeposito"
        Me.cboDeposito.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboDeposito.Size = New System.Drawing.Size(185, 20)
        Me.cboDeposito.TabIndex = 1
        Me.cboDeposito.TabStop = False
        '
        'cboLocalizacao
        '
        Me.cboLocalizacao.AutoSize = False
        Me.cboLocalizacao.Location = New System.Drawing.Point(80, 43)
        Me.cboLocalizacao.Name = "cboLocalizacao"
        Me.cboLocalizacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboLocalizacao.Size = New System.Drawing.Size(185, 20)
        Me.cboLocalizacao.TabIndex = 25
        Me.cboLocalizacao.TabStop = False
        '
        'btnSair2
        '
        Me.btnSair2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair2.Image = CType(resources.GetObject("btnSair2.Image"), System.Drawing.Image)
        Me.btnSair2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair2.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair2.Location = New System.Drawing.Point(796, 40)
        Me.btnSair2.Name = "btnSair2"
        Me.btnSair2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair2.Size = New System.Drawing.Size(91, 23)
        Me.btnSair2.TabIndex = 8
        Me.btnSair2.Text = "Sair"
        Me.btnSair2.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'grdDeposito
        '
        Me.grdDeposito.AlternatingColors = True
        Me.grdDeposito.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDeposito.AutoEdit = True
        grdDeposito_DesignTimeLayout.LayoutString = resources.GetString("grdDeposito_DesignTimeLayout.LayoutString")
        Me.grdDeposito.DesignTimeLayout = grdDeposito_DesignTimeLayout
        Me.grdDeposito.DynamicFiltering = True
        Me.grdDeposito.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdDeposito.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grdDeposito.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grdDeposito.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grdDeposito.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.grdDeposito.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdDeposito.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdDeposito.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdDeposito.GroupByBoxVisible = False
        Me.grdDeposito.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.grdDeposito.Location = New System.Drawing.Point(8, 7)
        Me.grdDeposito.Name = "grdDeposito"
        Me.grdDeposito.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdDeposito.RecordNavigator = True
        Me.grdDeposito.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.grdDeposito.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdDeposito.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdDeposito.Size = New System.Drawing.Size(896, 449)
        Me.grdDeposito.TabIndex = 1
        Me.grdDeposito.TabStop = False
        Me.grdDeposito.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Window
        Me.grdDeposito.TotalRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid
        Me.grdDeposito.TotalRowFormatStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grdDeposito.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdDeposito.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdDeposito.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdDeposito.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdDeposito.VisualStyleManager = Me.vsmMain
        '
        'frmFatEntradaNFeAcaoEmLote
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
        Me.Name = "frmFatEntradaNFeAcaoEmLote"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ação em Lote"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagEstoque.ResumeLayout(False)
        CType(Me.grpDadosEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosEstoque.ResumeLayout(False)
        Me.grpDadosEstoque.PerformLayout()
        CType(Me.grdDeposito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagEstoque As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpDadosEstoque As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnAlterarLocalizacao As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAlterarDeposito As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblLocalizacao As System.Windows.Forms.Label
    Friend WithEvents lblDeposito As System.Windows.Forms.Label
    Friend WithEvents cboDeposito As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboLocalizacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnSair2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdDeposito As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnSalvar2 As Janus.Windows.EditControls.UIButton
End Class
