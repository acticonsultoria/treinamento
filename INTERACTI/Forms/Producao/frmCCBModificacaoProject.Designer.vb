<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCCBModificacaoProject
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
        Me.components = New System.ComponentModel.Container
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim grdAtividade_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim grdAtividade_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.Image")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCCBModificacaoProject))
        Dim grdAtividade_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.Image")
        Dim grdAtividade_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.Image")
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab
        Me.pagMain = New Janus.Windows.UI.Tab.UITabPage
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox
        Me.btnInserirProject = New Janus.Windows.EditControls.UIButton
        Me.txtDataInput = New Janus.Windows.GridEX.EditControls.EditBox
        Me.lblUsuario = New System.Windows.Forms.Label
        Me.txtUsuario = New Janus.Windows.GridEX.EditControls.EditBox
        Me.lblDataInput = New System.Windows.Forms.Label
        Me.lblDataInicio = New System.Windows.Forms.Label
        Me.dtpDataInicio = New System.Windows.Forms.DateTimePicker
        Me.grdAtividade = New Janus.Windows.GridEX.GridEX
        Me.mnuLinha = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuInserirLinhaAcima = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuInserirLinhaAbaixo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuExcluirLinha = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuInserirAtividadeLista = New System.Windows.Forms.ToolStripMenuItem
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox
        Me.btnNovo = New Janus.Windows.EditControls.UIButton
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton
        Me.cmdExportarTarefas = New Janus.Windows.EditControls.UIButton
        Me.btnSair = New Janus.Windows.EditControls.UIButton
        Me.sfdArquivoProject = New System.Windows.Forms.SaveFileDialog
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagMain.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grdAtividade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuLinha.SuspendLayout()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
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
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Location = New System.Drawing.Point(8, 8)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(892, 432)
        Me.tabMain.TabIndex = 1
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagMain})
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagMain
        '
        Me.pagMain.Controls.Add(Me.grdAtividade)
        Me.pagMain.Controls.Add(Me.grpDados)
        Me.pagMain.Controls.Add(Me.grpControl)
        Me.pagMain.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagMain.Key = "pagMain"
        Me.pagMain.Location = New System.Drawing.Point(1, 22)
        Me.pagMain.Name = "pagMain"
        Me.pagMain.Size = New System.Drawing.Size(890, 409)
        Me.pagMain.TabStop = True
        Me.pagMain.Text = "Point Of Embodiment - Implementação"
        '
        'grpDados
        '
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.btnInserirProject)
        Me.grpDados.Controls.Add(Me.txtDataInput)
        Me.grpDados.Controls.Add(Me.lblUsuario)
        Me.grpDados.Controls.Add(Me.txtUsuario)
        Me.grpDados.Controls.Add(Me.lblDataInput)
        Me.grpDados.Controls.Add(Me.lblDataInicio)
        Me.grpDados.Controls.Add(Me.dtpDataInicio)
        Me.grpDados.Location = New System.Drawing.Point(9, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(872, 64)
        Me.grpDados.TabIndex = 4
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'btnInserirProject
        '
        Me.btnInserirProject.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnInserirProject.Location = New System.Drawing.Point(87, 34)
        Me.btnInserirProject.Name = "btnInserirProject"
        Me.btnInserirProject.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnInserirProject.Size = New System.Drawing.Size(22, 20)
        Me.btnInserirProject.TabIndex = 42
        Me.btnInserirProject.Text = "..."
        Me.btnInserirProject.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtDataInput
        '
        Me.txtDataInput.BackColor = System.Drawing.SystemColors.Info
        Me.txtDataInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataInput.Location = New System.Drawing.Point(9, 34)
        Me.txtDataInput.MaxLength = 100
        Me.txtDataInput.Name = "txtDataInput"
        Me.txtDataInput.ReadOnly = True
        Me.txtDataInput.Size = New System.Drawing.Size(81, 20)
        Me.txtDataInput.TabIndex = 41
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(112, 18)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(33, 14)
        Me.lblUsuario.TabIndex = 38
        Me.lblUsuario.Text = "User:"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.SystemColors.Info
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Location = New System.Drawing.Point(115, 35)
        Me.txtUsuario.MaxLength = 100
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(218, 20)
        Me.txtUsuario.TabIndex = 39
        '
        'lblDataInput
        '
        Me.lblDataInput.AutoSize = True
        Me.lblDataInput.Location = New System.Drawing.Point(7, 18)
        Me.lblDataInput.Name = "lblDataInput"
        Me.lblDataInput.Size = New System.Drawing.Size(32, 14)
        Me.lblDataInput.TabIndex = 40
        Me.lblDataInput.Text = "Date:"
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.Location = New System.Drawing.Point(336, 18)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(58, 14)
        Me.lblDataInicio.TabIndex = 36
        Me.lblDataInicio.Text = "Start Date:"
        '
        'dtpDataInicio
        '
        Me.dtpDataInicio.CustomFormat = "dd/MM/yyyy"
        Me.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataInicio.Location = New System.Drawing.Point(339, 35)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.Size = New System.Drawing.Size(91, 20)
        Me.dtpDataInicio.TabIndex = 37
        '
        'grdAtividade
        '
        Me.grdAtividade.AlternatingColors = True
        Me.grdAtividade.BoundMode = Janus.Windows.GridEX.BoundMode.Unbound
        Me.grdAtividade.ContextMenuStrip = Me.mnuLinha
        grdAtividade_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("grdAtividade_DesignTimeLayout_Reference_0.Instance"), Object)
        grdAtividade_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("grdAtividade_DesignTimeLayout_Reference_1.Instance"), Object)
        grdAtividade_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("grdAtividade_DesignTimeLayout_Reference_2.Instance"), Object)
        grdAtividade_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {grdAtividade_DesignTimeLayout_Reference_0, grdAtividade_DesignTimeLayout_Reference_1, grdAtividade_DesignTimeLayout_Reference_2})
        grdAtividade_DesignTimeLayout.LayoutString = resources.GetString("grdAtividade_DesignTimeLayout.LayoutString")
        Me.grdAtividade.DesignTimeLayout = grdAtividade_DesignTimeLayout
        Me.grdAtividade.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdAtividade.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdAtividade.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdAtividade.FrozenColumns = 4
        Me.grdAtividade.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdAtividade.GroupByBoxVisible = False
        Me.grdAtividade.Location = New System.Drawing.Point(9, 77)
        Me.grdAtividade.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdAtividade.Name = "grdAtividade"
        Me.grdAtividade.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.grdAtividade.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdAtividade.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grdAtividade.SelectedFormatStyle.BackColor = System.Drawing.Color.Transparent
        Me.grdAtividade.Size = New System.Drawing.Size(872, 268)
        Me.grdAtividade.TabIndex = 3
        Me.grdAtividade.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdAtividade.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdAtividade.VisualStyleManager = Me.vsmMain
        '
        'mnuLinha
        '
        Me.mnuLinha.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInserirLinhaAcima, Me.mnuInserirLinhaAbaixo, Me.mnuExcluirLinha, Me.ToolStripMenuItem1, Me.mnuInserirAtividadeLista})
        Me.mnuLinha.Name = "mnuEstrutura"
        Me.mnuLinha.Size = New System.Drawing.Size(198, 98)
        '
        'mnuInserirLinhaAcima
        '
        Me.mnuInserirLinhaAcima.Name = "mnuInserirLinhaAcima"
        Me.mnuInserirLinhaAcima.Size = New System.Drawing.Size(197, 22)
        Me.mnuInserirLinhaAcima.Text = "Inserir linha acima"
        '
        'mnuInserirLinhaAbaixo
        '
        Me.mnuInserirLinhaAbaixo.Name = "mnuInserirLinhaAbaixo"
        Me.mnuInserirLinhaAbaixo.Size = New System.Drawing.Size(197, 22)
        Me.mnuInserirLinhaAbaixo.Text = "Inserir linha abaixo"
        '
        'mnuExcluirLinha
        '
        Me.mnuExcluirLinha.Name = "mnuExcluirLinha"
        Me.mnuExcluirLinha.Size = New System.Drawing.Size(197, 22)
        Me.mnuExcluirLinha.Text = "Excluir linha"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(194, 6)
        '
        'mnuInserirAtividadeLista
        '
        Me.mnuInserirAtividadeLista.Name = "mnuInserirAtividadeLista"
        Me.mnuInserirAtividadeLista.Size = New System.Drawing.Size(197, 22)
        Me.mnuInserirAtividadeLista.Text = "Inserir atividade de lista"
        '
        'grpControl
        '
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnNovo)
        Me.grpControl.Controls.Add(Me.btnSalvar)
        Me.grpControl.Controls.Add(Me.cmdExportarTarefas)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(9, 349)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(872, 51)
        Me.grpControl.TabIndex = 2
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnNovo
        '
        Me.btnNovo.Image = INTERACTI.My.Resources.Novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnNovo.Location = New System.Drawing.Point(400, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 44
        Me.btnNovo.Text = "Novo"
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(497, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 43
        Me.btnSalvar.Text = "Salvar"
        '
        'cmdExportarTarefas
        '
        Me.cmdExportarTarefas.Image = INTERACTI.My.Resources.pasta
        Me.cmdExportarTarefas.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.cmdExportarTarefas.ImageSize = New System.Drawing.Size(13, 16)
        Me.cmdExportarTarefas.Location = New System.Drawing.Point(594, 17)
        Me.cmdExportarTarefas.Name = "cmdExportarTarefas"
        Me.cmdExportarTarefas.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cmdExportarTarefas.Size = New System.Drawing.Size(172, 23)
        Me.cmdExportarTarefas.TabIndex = 0
        Me.cmdExportarTarefas.Text = "Exportar para o MS Project"
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(772, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        '
        'sfdArquivoProject
        '
        Me.sfdArquivoProject.DefaultExt = "mpp"
        Me.sfdArquivoProject.FileName = "Projeto1.mpp"
        Me.sfdArquivoProject.Filter = "Arquivos do MS Project (*.mpp)|*.mpp| All files |*.*"
        '
        'frmCCBModificacaoProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 448)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCCBModificacaoProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificação - Integração com o MS Project"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagMain.ResumeLayout(False)
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grdAtividade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuLinha.ResumeLayout(False)
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagMain As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cmdExportarTarefas As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdAtividade As Janus.Windows.GridEX.GridEX
    Friend WithEvents sfdArquivoProject As System.Windows.Forms.SaveFileDialog
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDataInicio As System.Windows.Forms.Label
    Friend WithEvents dtpDataInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDataInput As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents lblDataInput As System.Windows.Forms.Label
    Friend WithEvents mnuLinha As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuInserirLinhaAcima As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInserirLinhaAbaixo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExcluirLinha As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuInserirAtividadeLista As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnInserirProject As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
End Class
