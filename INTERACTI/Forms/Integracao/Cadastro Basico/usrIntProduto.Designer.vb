<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrIntProduto
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grdControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnExcelExemplo = New Janus.Windows.EditControls.UIButton()
        Me.btnImportar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.picSistema = New System.Windows.Forms.PictureBox()
        Me.grdArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.pgbImportacao = New Janus.Windows.EditControls.UIProgressBar()
        Me.chkCadastrarNCM = New Janus.Windows.EditControls.UICheckBox()
        Me.chkAtualizarRegistro = New Janus.Windows.EditControls.UICheckBox()
        Me.chkCadastrarUnidadeMedida = New Janus.Windows.EditControls.UICheckBox()
        Me.chkCadastrarGrupoItem = New Janus.Windows.EditControls.UICheckBox()
        Me.lblArquivo = New System.Windows.Forms.Label()
        Me.txtArquivo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnArquivo = New Janus.Windows.EditControls.UIButton()
        CType(Me.grdControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdControl.SuspendLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grdArquivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'vsmMain
        '
        JanusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme2.Name = "Scheme"
        JanusColorScheme2.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme2.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme2)
        '
        'grdControl
        '
        Me.grdControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdControl.BackColor = System.Drawing.Color.Transparent
        Me.grdControl.Controls.Add(Me.btnExcelExemplo)
        Me.grdControl.Controls.Add(Me.btnImportar)
        Me.grdControl.Controls.Add(Me.btnSair)
        Me.grdControl.Location = New System.Drawing.Point(8, 275)
        Me.grdControl.Name = "grdControl"
        Me.grdControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grdControl.Size = New System.Drawing.Size(489, 51)
        Me.grdControl.TabIndex = 1
        Me.grdControl.VisualStyleManager = Me.vsmMain
        '
        'btnExcelExemplo
        '
        Me.btnExcelExemplo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelExemplo.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcelExemplo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcelExemplo.Location = New System.Drawing.Point(9, 17)
        Me.btnExcelExemplo.Name = "btnExcelExemplo"
        Me.btnExcelExemplo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcelExemplo.Size = New System.Drawing.Size(200, 23)
        Me.btnExcelExemplo.TabIndex = 0
        Me.btnExcelExemplo.Text = "Exemplo - Layout Arquivo Excel"
        Me.btnExcelExemplo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnImportar
        '
        Me.btnImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportar.Image = Global.INTERACTI.My.Resources.download
        Me.btnImportar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnImportar.Location = New System.Drawing.Point(292, 17)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnImportar.Size = New System.Drawing.Size(91, 23)
        Me.btnImportar.TabIndex = 1
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(389, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.FocusOnClick = False
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(507, 358)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.picSistema)
        Me.pagDados.Controls.Add(Me.grdControl)
        Me.pagDados.Controls.Add(Me.grdArquivo)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(505, 335)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Integração - Importar Produtos"
        '
        'picSistema
        '
        Me.picSistema.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picSistema.BackColor = System.Drawing.Color.White
        Me.picSistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSistema.Image = Global.INTERACTI.My.Resources.Interacti
        Me.picSistema.Location = New System.Drawing.Point(8, 9)
        Me.picSistema.Name = "picSistema"
        Me.picSistema.Size = New System.Drawing.Size(489, 109)
        Me.picSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSistema.TabIndex = 16
        Me.picSistema.TabStop = False
        '
        'grdArquivo
        '
        Me.grdArquivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grdArquivo.Controls.Add(Me.pgbImportacao)
        Me.grdArquivo.Controls.Add(Me.chkCadastrarNCM)
        Me.grdArquivo.Controls.Add(Me.chkAtualizarRegistro)
        Me.grdArquivo.Controls.Add(Me.chkCadastrarUnidadeMedida)
        Me.grdArquivo.Controls.Add(Me.chkCadastrarGrupoItem)
        Me.grdArquivo.Controls.Add(Me.lblArquivo)
        Me.grdArquivo.Controls.Add(Me.txtArquivo)
        Me.grdArquivo.Controls.Add(Me.btnArquivo)
        Me.grdArquivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grdArquivo.Location = New System.Drawing.Point(8, 121)
        Me.grdArquivo.Name = "grdArquivo"
        Me.grdArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grdArquivo.Size = New System.Drawing.Size(489, 152)
        Me.grdArquivo.TabIndex = 0
        Me.grdArquivo.VisualStyleManager = Me.vsmMain
        '
        'pgbImportacao
        '
        Me.pgbImportacao.Location = New System.Drawing.Point(9, 127)
        Me.pgbImportacao.Name = "pgbImportacao"
        Me.pgbImportacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.pgbImportacao.ShowPercentage = True
        Me.pgbImportacao.Size = New System.Drawing.Size(471, 16)
        Me.pgbImportacao.TabIndex = 17
        Me.pgbImportacao.VisualStyleManager = Me.vsmMain
        '
        'chkCadastrarNCM
        '
        Me.chkCadastrarNCM.Location = New System.Drawing.Point(9, 102)
        Me.chkCadastrarNCM.Name = "chkCadastrarNCM"
        Me.chkCadastrarNCM.Size = New System.Drawing.Size(185, 15)
        Me.chkCadastrarNCM.TabIndex = 5
        Me.chkCadastrarNCM.Text = "Cadastrar NCM"
        '
        'chkAtualizarRegistro
        '
        Me.chkAtualizarRegistro.Location = New System.Drawing.Point(340, 102)
        Me.chkAtualizarRegistro.Name = "chkAtualizarRegistro"
        Me.chkAtualizarRegistro.Size = New System.Drawing.Size(140, 15)
        Me.chkAtualizarRegistro.TabIndex = 6
        Me.chkAtualizarRegistro.Text = "Atualizar Registros Iguais"
        '
        'chkCadastrarUnidadeMedida
        '
        Me.chkCadastrarUnidadeMedida.Location = New System.Drawing.Point(9, 81)
        Me.chkCadastrarUnidadeMedida.Name = "chkCadastrarUnidadeMedida"
        Me.chkCadastrarUnidadeMedida.Size = New System.Drawing.Size(185, 15)
        Me.chkCadastrarUnidadeMedida.TabIndex = 4
        Me.chkCadastrarUnidadeMedida.Text = "Cadastrar Unidade Medida"
        '
        'chkCadastrarGrupoItem
        '
        Me.chkCadastrarGrupoItem.Location = New System.Drawing.Point(9, 60)
        Me.chkCadastrarGrupoItem.Name = "chkCadastrarGrupoItem"
        Me.chkCadastrarGrupoItem.Size = New System.Drawing.Size(185, 15)
        Me.chkCadastrarGrupoItem.TabIndex = 3
        Me.chkCadastrarGrupoItem.Text = "Cadastrar Grupo de Item"
        '
        'lblArquivo
        '
        Me.lblArquivo.AutoSize = True
        Me.lblArquivo.Location = New System.Drawing.Point(6, 17)
        Me.lblArquivo.Name = "lblArquivo"
        Me.lblArquivo.Size = New System.Drawing.Size(48, 14)
        Me.lblArquivo.TabIndex = 0
        Me.lblArquivo.Text = "Arquivo:"
        '
        'txtArquivo
        '
        Me.txtArquivo.BackColor = System.Drawing.SystemColors.Info
        Me.txtArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArquivo.Location = New System.Drawing.Point(9, 34)
        Me.txtArquivo.MaxLength = 50
        Me.txtArquivo.Name = "txtArquivo"
        Me.txtArquivo.ReadOnly = True
        Me.txtArquivo.Size = New System.Drawing.Size(449, 20)
        Me.txtArquivo.TabIndex = 1
        Me.txtArquivo.TabStop = False
        '
        'btnArquivo
        '
        Me.btnArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnArquivo.Location = New System.Drawing.Point(457, 34)
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivo.Size = New System.Drawing.Size(23, 20)
        Me.btnArquivo.TabIndex = 2
        Me.btnArquivo.Text = "..."
        Me.btnArquivo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrIntProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrIntProduto"
        Me.Size = New System.Drawing.Size(507, 358)
        CType(Me.grdControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdControl.ResumeLayout(False)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.picSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grdArquivo.ResumeLayout(False)
        Me.grdArquivo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grdControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents grdArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblArquivo As System.Windows.Forms.Label
    Friend WithEvents txtArquivo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Private WithEvents btnArquivo As Janus.Windows.EditControls.UIButton
    Private WithEvents btnImportar As Janus.Windows.EditControls.UIButton
    Friend WithEvents chkCadastrarUnidadeMedida As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkCadastrarGrupoItem As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents picSistema As System.Windows.Forms.PictureBox
    Private WithEvents btnExcelExemplo As Janus.Windows.EditControls.UIButton
    Friend WithEvents chkAtualizarRegistro As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents chkCadastrarNCM As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents pgbImportacao As Janus.Windows.EditControls.UIProgressBar

End Class
