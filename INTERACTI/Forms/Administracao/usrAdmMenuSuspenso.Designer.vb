<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrAdmMenuSuspenso
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
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnLimpar = New Janus.Windows.EditControls.UIButton()
        Me.picImagem = New System.Windows.Forms.PictureBox()
        Me.btnFoto = New Janus.Windows.EditControls.UIButton()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnExcluir = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.cboFormulario = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMenuSuperior = New System.Windows.Forms.Label()
        Me.cboMenuSuperior = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblImagem = New System.Windows.Forms.Label()
        Me.txtImagem = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblFormulario = New System.Windows.Forms.Label()
        Me.grpControl = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnAtualizarMenu = New Janus.Windows.EditControls.UIButton()
        Me.btnNovo = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
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
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.Transparent
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.pnlMenu)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grpControl)
        Me.pagDados.Key = "pagDados"
        Me.pagDados.Location = New System.Drawing.Point(1, 22)
        Me.pagDados.Name = "pagDados"
        Me.pagDados.Size = New System.Drawing.Size(913, 543)
        Me.pagDados.TabStop = True
        Me.pagDados.Text = "Cadastro de Menu"
        '
        'pnlMenu
        '
        Me.pnlMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMenu.AutoScroll = True
        Me.pnlMenu.BackColor = System.Drawing.SystemColors.Window
        Me.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMenu.Controls.Add(Me.mnuMain)
        Me.pnlMenu.Location = New System.Drawing.Point(8, 145)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(897, 335)
        Me.pnlMenu.TabIndex = 5
        '
        'mnuMain
        '
        Me.mnuMain.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.ShowItemToolTips = True
        Me.mnuMain.Size = New System.Drawing.Size(202, 24)
        Me.mnuMain.TabIndex = 0
        '
        'grpDados
        '
        Me.grpDados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.btnLimpar)
        Me.grpDados.Controls.Add(Me.picImagem)
        Me.grpDados.Controls.Add(Me.btnFoto)
        Me.grpDados.Controls.Add(Me.lblDescricao)
        Me.grpDados.Controls.Add(Me.txtDescricao)
        Me.grpDados.Controls.Add(Me.btnExcluir)
        Me.grpDados.Controls.Add(Me.btnSalvar)
        Me.grpDados.Controls.Add(Me.cboFormulario)
        Me.grpDados.Controls.Add(Me.lblMenuSuperior)
        Me.grpDados.Controls.Add(Me.cboMenuSuperior)
        Me.grpDados.Controls.Add(Me.lblCodigo)
        Me.grpDados.Controls.Add(Me.txtCodigo)
        Me.grpDados.Controls.Add(Me.lblImagem)
        Me.grpDados.Controls.Add(Me.txtImagem)
        Me.grpDados.Controls.Add(Me.lblFormulario)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Location = New System.Drawing.Point(8, 3)
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.Size = New System.Drawing.Size(897, 133)
        Me.grpDados.TabIndex = 0
        Me.grpDados.Text = "Dados do Menu"
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'btnLimpar
        '
        Me.btnLimpar.Image = Global.INTERACTI.My.Resources.limpar
        Me.btnLimpar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.btnLimpar.Location = New System.Drawing.Point(729, 103)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnLimpar.Size = New System.Drawing.Size(20, 20)
        Me.btnLimpar.TabIndex = 31
        Me.btnLimpar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'picImagem
        '
        Me.picImagem.BackColor = System.Drawing.SystemColors.Window
        Me.picImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImagem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.picImagem.Location = New System.Drawing.Point(710, 103)
        Me.picImagem.Name = "picImagem"
        Me.picImagem.Size = New System.Drawing.Size(20, 20)
        Me.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImagem.TabIndex = 30
        Me.picImagem.TabStop = False
        '
        'btnFoto
        '
        Me.btnFoto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnFoto.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnFoto.Location = New System.Drawing.Point(684, 103)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnFoto.Size = New System.Drawing.Size(20, 20)
        Me.btnFoto.TabIndex = 10
        Me.btnFoto.Text = "..."
        Me.btnFoto.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(312, 27)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(59, 14)
        Me.lblDescricao.TabIndex = 2
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(377, 25)
        Me.txtDescricao.MaxLength = 0
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(372, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.Image = Global.INTERACTI.My.Resources.excluir
        Me.btnExcluir.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcluir.ImageSize = New System.Drawing.Size(17, 15)
        Me.btnExcluir.Location = New System.Drawing.Point(797, 99)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcluir.Size = New System.Drawing.Size(91, 23)
        Me.btnExcluir.TabIndex = 12
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(797, 70)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 11
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'cboFormulario
        '
        Me.cboFormulario.Location = New System.Drawing.Point(103, 77)
        Me.cboFormulario.Name = "cboFormulario"
        Me.cboFormulario.Size = New System.Drawing.Size(646, 20)
        Me.cboFormulario.TabIndex = 7
        '
        'lblMenuSuperior
        '
        Me.lblMenuSuperior.AutoSize = True
        Me.lblMenuSuperior.Location = New System.Drawing.Point(6, 55)
        Me.lblMenuSuperior.Name = "lblMenuSuperior"
        Me.lblMenuSuperior.Size = New System.Drawing.Size(80, 14)
        Me.lblMenuSuperior.TabIndex = 4
        Me.lblMenuSuperior.Text = "Menu Superior:"
        '
        'cboMenuSuperior
        '
        Me.cboMenuSuperior.Location = New System.Drawing.Point(103, 51)
        Me.cboMenuSuperior.Name = "cboMenuSuperior"
        Me.cboMenuSuperior.Size = New System.Drawing.Size(646, 20)
        Me.cboMenuSuperior.TabIndex = 5
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(6, 29)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 14)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(103, 25)
        Me.txtCodigo.MaxLength = 50
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(203, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'lblImagem
        '
        Me.lblImagem.AutoSize = True
        Me.lblImagem.Location = New System.Drawing.Point(6, 108)
        Me.lblImagem.Name = "lblImagem"
        Me.lblImagem.Size = New System.Drawing.Size(46, 14)
        Me.lblImagem.TabIndex = 8
        Me.lblImagem.Text = "Imagem:"
        '
        'txtImagem
        '
        Me.txtImagem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtImagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImagem.Location = New System.Drawing.Point(103, 103)
        Me.txtImagem.MaxLength = 50
        Me.txtImagem.Name = "txtImagem"
        Me.txtImagem.ReadOnly = True
        Me.txtImagem.Size = New System.Drawing.Size(582, 20)
        Me.txtImagem.TabIndex = 9
        Me.txtImagem.TabStop = False
        '
        'lblFormulario
        '
        Me.lblFormulario.AutoSize = True
        Me.lblFormulario.Location = New System.Drawing.Point(6, 82)
        Me.lblFormulario.Name = "lblFormulario"
        Me.lblFormulario.Size = New System.Drawing.Size(60, 14)
        Me.lblFormulario.TabIndex = 6
        Me.lblFormulario.Text = "Formulário:"
        '
        'grpControl
        '
        Me.grpControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControl.BackColor = System.Drawing.Color.Transparent
        Me.grpControl.Controls.Add(Me.btnAtualizarMenu)
        Me.grpControl.Controls.Add(Me.btnNovo)
        Me.grpControl.Controls.Add(Me.btnSair)
        Me.grpControl.Location = New System.Drawing.Point(8, 483)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControl.Size = New System.Drawing.Size(897, 51)
        Me.grpControl.TabIndex = 1
        Me.grpControl.VisualStyleManager = Me.vsmMain
        '
        'btnAtualizarMenu
        '
        Me.btnAtualizarMenu.Image = Global.INTERACTI.My.Resources.atualizar
        Me.btnAtualizarMenu.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnAtualizarMenu.Location = New System.Drawing.Point(9, 17)
        Me.btnAtualizarMenu.Name = "btnAtualizarMenu"
        Me.btnAtualizarMenu.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnAtualizarMenu.Size = New System.Drawing.Size(150, 23)
        Me.btnAtualizarMenu.TabIndex = 13
        Me.btnAtualizarMenu.Text = "Atualizar Menu"
        Me.btnAtualizarMenu.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = Global.INTERACTI.My.Resources.novo
        Me.btnNovo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnNovo.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnNovo.Location = New System.Drawing.Point(700, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnNovo.Size = New System.Drawing.Size(91, 23)
        Me.btnNovo.TabIndex = 1
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = Global.INTERACTI.My.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrAdmMenuSuspenso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrAdmMenuSuspenso"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControl As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboFormulario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMenuSuperior As System.Windows.Forms.Label
    Friend WithEvents cboMenuSuperior As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblImagem As System.Windows.Forms.Label
    Friend WithEvents txtImagem As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblFormulario As System.Windows.Forms.Label
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnExcluir As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFoto As Janus.Windows.EditControls.UIButton
    Friend WithEvents picImagem As System.Windows.Forms.PictureBox
    Friend WithEvents btnNovo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnLimpar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAtualizarMenu As Janus.Windows.EditControls.UIButton

End Class
