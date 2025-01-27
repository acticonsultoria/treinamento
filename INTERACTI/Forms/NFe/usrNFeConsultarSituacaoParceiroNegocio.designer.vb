<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrNFeConsultarSituacaoParceiroNegocio
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
        Me.components = New System.ComponentModel.Container
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrNFeConsultarSituacaoParceiroNegocio))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
        Me.btnCadastrar = New Janus.Windows.EditControls.UIButton
        Me.btnConsultar = New Janus.Windows.EditControls.UIButton
        Me.btnSair = New Janus.Windows.EditControls.UIButton
        Me.txtEmail = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.txtUsuario = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.txtSenha = New Janus.Windows.GridEX.EditControls.EditBox
        Me.txtServidor = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.txtPorta = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblValorCEP = New System.Windows.Forms.Label
        Me.lblCEP = New System.Windows.Forms.Label
        Me.lblValorUF = New System.Windows.Forms.Label
        Me.lblUF = New System.Windows.Forms.Label
        Me.lblValorMunicipio = New System.Windows.Forms.Label
        Me.lblMunicipio = New System.Windows.Forms.Label
        Me.lblValorBairro = New System.Windows.Forms.Label
        Me.lblComplemento = New System.Windows.Forms.Label
        Me.lblValorComplemento = New System.Windows.Forms.Label
        Me.lblValorLogradouro = New System.Windows.Forms.Label
        Me.lblLogradouro = New System.Windows.Forms.Label
        Me.lblNumero = New System.Windows.Forms.Label
        Me.lblValorNumero = New System.Windows.Forms.Label
        Me.lblBairro = New System.Windows.Forms.Label
        Me.lblValorSituacaoContribuinte = New System.Windows.Forms.Label
        Me.lblSituacaoContribuinte = New System.Windows.Forms.Label
        Me.lblValorSituacao = New System.Windows.Forms.Label
        Me.lblSituacao = New System.Windows.Forms.Label
        Me.lblValorCNAE = New System.Windows.Forms.Label
        Me.lblCNAE = New System.Windows.Forms.Label
        Me.lblValorDataInicioAtividade = New System.Windows.Forms.Label
        Me.lblDataInicioAtividade = New System.Windows.Forms.Label
        Me.lblValorRazaoSocial = New System.Windows.Forms.Label
        Me.lblRazaoSocial = New System.Windows.Forms.Label
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblNomeFantasia = New System.Windows.Forms.Label
        Me.lblValorNomeFantasia = New System.Windows.Forms.Label
        Me.lblInscricaoEstadual = New System.Windows.Forms.Label
        Me.lblValorInscricaoEstadual = New System.Windows.Forms.Label
        Me.txtCNPJContribuinte = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.lblCNPJContribuinte = New System.Windows.Forms.Label
        Me.picFornecedor = New System.Windows.Forms.PictureBox
        Me.lblUFContribuinte = New System.Windows.Forms.Label
        Me.cboUFContribuinte = New Janus.Windows.EditControls.UIComboBox
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.picFornecedor, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'UiGroupBox3
        '
        Me.UiGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox3.Controls.Add(Me.btnCadastrar)
        Me.UiGroupBox3.Controls.Add(Me.btnConsultar)
        Me.UiGroupBox3.Controls.Add(Me.btnSair)
        Me.UiGroupBox3.Location = New System.Drawing.Point(13, 226)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox3.Size = New System.Drawing.Size(588, 51)
        Me.UiGroupBox3.TabIndex = 6
        Me.UiGroupBox3.VisualStyleManager = Me.vsmMain
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnCadastrar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnCadastrar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnCadastrar.Location = New System.Drawing.Point(390, 17)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(91, 23)
        Me.btnCadastrar.TabIndex = 1
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = Global.INTERACTI.My.Resources.search
        Me.btnConsultar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnConsultar.Location = New System.Drawing.Point(293, 17)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(91, 23)
        Me.btnConsultar.TabIndex = 0
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(487, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Location = New System.Drawing.Point(9, 34)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(326, 20)
        Me.txtEmail.TabIndex = 1
        '
        'txtUsuario
        '
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtUsuario.Location = New System.Drawing.Point(9, 74)
        Me.txtUsuario.MaxLength = 100
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(220, 20)
        Me.txtUsuario.TabIndex = 3
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(235, 74)
        Me.txtSenha.MaxLength = 20
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtSenha.TabIndex = 5
        '
        'txtServidor
        '
        Me.txtServidor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtServidor.Location = New System.Drawing.Point(9, 114)
        Me.txtServidor.MaxLength = 100
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(165, 20)
        Me.txtServidor.TabIndex = 7
        '
        'txtPorta
        '
        Me.txtPorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorta.Location = New System.Drawing.Point(180, 114)
        Me.txtPorta.MaxLength = 4
        Me.txtPorta.Name = "txtPorta"
        Me.txtPorta.Size = New System.Drawing.Size(49, 20)
        Me.txtPorta.TabIndex = 9
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.Controls.Add(Me.lblValorCEP)
        Me.UiGroupBox2.Controls.Add(Me.lblCEP)
        Me.UiGroupBox2.Controls.Add(Me.lblValorUF)
        Me.UiGroupBox2.Controls.Add(Me.lblUF)
        Me.UiGroupBox2.Controls.Add(Me.lblValorMunicipio)
        Me.UiGroupBox2.Controls.Add(Me.lblMunicipio)
        Me.UiGroupBox2.Controls.Add(Me.lblValorBairro)
        Me.UiGroupBox2.Controls.Add(Me.lblComplemento)
        Me.UiGroupBox2.Controls.Add(Me.lblValorComplemento)
        Me.UiGroupBox2.Controls.Add(Me.lblValorLogradouro)
        Me.UiGroupBox2.Controls.Add(Me.lblLogradouro)
        Me.UiGroupBox2.Controls.Add(Me.lblNumero)
        Me.UiGroupBox2.Controls.Add(Me.lblValorNumero)
        Me.UiGroupBox2.Controls.Add(Me.lblBairro)
        Me.UiGroupBox2.Location = New System.Drawing.Point(151, 149)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox2.Size = New System.Drawing.Size(450, 71)
        Me.UiGroupBox2.TabIndex = 5
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        '
        'lblValorCEP
        '
        Me.lblValorCEP.AutoSize = True
        Me.lblValorCEP.Location = New System.Drawing.Point(387, 48)
        Me.lblValorCEP.Name = "lblValorCEP"
        Me.lblValorCEP.Size = New System.Drawing.Size(11, 14)
        Me.lblValorCEP.TabIndex = 13
        Me.lblValorCEP.Text = "-"
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCEP.Location = New System.Drawing.Point(327, 48)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(31, 14)
        Me.lblCEP.TabIndex = 12
        Me.lblCEP.Text = "CEP:"
        '
        'lblValorUF
        '
        Me.lblValorUF.AutoSize = True
        Me.lblValorUF.Location = New System.Drawing.Point(274, 48)
        Me.lblValorUF.Name = "lblValorUF"
        Me.lblValorUF.Size = New System.Drawing.Size(11, 14)
        Me.lblValorUF.TabIndex = 11
        Me.lblValorUF.Text = "-"
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUF.Location = New System.Drawing.Point(225, 48)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(23, 14)
        Me.lblUF.TabIndex = 10
        Me.lblUF.Text = "UF:"
        '
        'lblValorMunicipio
        '
        Me.lblValorMunicipio.AutoSize = True
        Me.lblValorMunicipio.Location = New System.Drawing.Point(98, 48)
        Me.lblValorMunicipio.Name = "lblValorMunicipio"
        Me.lblValorMunicipio.Size = New System.Drawing.Size(11, 14)
        Me.lblValorMunicipio.TabIndex = 9
        Me.lblValorMunicipio.Text = "-"
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMunicipio.Location = New System.Drawing.Point(7, 48)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(63, 14)
        Me.lblMunicipio.TabIndex = 8
        Me.lblMunicipio.Text = "Município:"
        '
        'lblValorBairro
        '
        Me.lblValorBairro.AutoSize = True
        Me.lblValorBairro.Location = New System.Drawing.Point(274, 30)
        Me.lblValorBairro.Name = "lblValorBairro"
        Me.lblValorBairro.Size = New System.Drawing.Size(11, 14)
        Me.lblValorBairro.TabIndex = 7
        Me.lblValorBairro.Text = "-"
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplemento.Location = New System.Drawing.Point(7, 30)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(89, 14)
        Me.lblComplemento.TabIndex = 4
        Me.lblComplemento.Text = "Complemento:"
        '
        'lblValorComplemento
        '
        Me.lblValorComplemento.AutoSize = True
        Me.lblValorComplemento.Location = New System.Drawing.Point(98, 30)
        Me.lblValorComplemento.Name = "lblValorComplemento"
        Me.lblValorComplemento.Size = New System.Drawing.Size(11, 14)
        Me.lblValorComplemento.TabIndex = 5
        Me.lblValorComplemento.Text = "-"
        '
        'lblValorLogradouro
        '
        Me.lblValorLogradouro.AutoSize = True
        Me.lblValorLogradouro.Location = New System.Drawing.Point(97, 11)
        Me.lblValorLogradouro.Name = "lblValorLogradouro"
        Me.lblValorLogradouro.Size = New System.Drawing.Size(11, 14)
        Me.lblValorLogradouro.TabIndex = 1
        Me.lblValorLogradouro.Text = "-"
        '
        'lblLogradouro
        '
        Me.lblLogradouro.AutoSize = True
        Me.lblLogradouro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogradouro.Location = New System.Drawing.Point(6, 11)
        Me.lblLogradouro.Name = "lblLogradouro"
        Me.lblLogradouro.Size = New System.Drawing.Size(75, 14)
        Me.lblLogradouro.TabIndex = 0
        Me.lblLogradouro.Text = "Logradouro:"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(327, 11)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(54, 14)
        Me.lblNumero.TabIndex = 2
        Me.lblNumero.Text = "Número:"
        '
        'lblValorNumero
        '
        Me.lblValorNumero.AutoSize = True
        Me.lblValorNumero.Location = New System.Drawing.Point(387, 11)
        Me.lblValorNumero.Name = "lblValorNumero"
        Me.lblValorNumero.Size = New System.Drawing.Size(11, 14)
        Me.lblValorNumero.TabIndex = 3
        Me.lblValorNumero.Text = "-"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBairro.Location = New System.Drawing.Point(225, 30)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(43, 14)
        Me.lblBairro.TabIndex = 6
        Me.lblBairro.Text = "Bairro:"
        '
        'lblValorSituacaoContribuinte
        '
        Me.lblValorSituacaoContribuinte.AutoSize = True
        Me.lblValorSituacaoContribuinte.Location = New System.Drawing.Point(229, 68)
        Me.lblValorSituacaoContribuinte.Name = "lblValorSituacaoContribuinte"
        Me.lblValorSituacaoContribuinte.Size = New System.Drawing.Size(11, 14)
        Me.lblValorSituacaoContribuinte.TabIndex = 13
        Me.lblValorSituacaoContribuinte.Text = "-"
        '
        'lblSituacaoContribuinte
        '
        Me.lblSituacaoContribuinte.AutoSize = True
        Me.lblSituacaoContribuinte.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSituacaoContribuinte.Location = New System.Drawing.Point(169, 68)
        Me.lblSituacaoContribuinte.Name = "lblSituacaoContribuinte"
        Me.lblSituacaoContribuinte.Size = New System.Drawing.Size(54, 14)
        Me.lblSituacaoContribuinte.TabIndex = 12
        Me.lblSituacaoContribuinte.Text = "Sit. NF-e:"
        '
        'lblValorSituacao
        '
        Me.lblValorSituacao.AutoSize = True
        Me.lblValorSituacao.Location = New System.Drawing.Point(97, 68)
        Me.lblValorSituacao.Name = "lblValorSituacao"
        Me.lblValorSituacao.Size = New System.Drawing.Size(11, 14)
        Me.lblValorSituacao.TabIndex = 11
        Me.lblValorSituacao.Text = "-"
        '
        'lblSituacao
        '
        Me.lblSituacao.AutoSize = True
        Me.lblSituacao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSituacao.Location = New System.Drawing.Point(6, 68)
        Me.lblSituacao.Name = "lblSituacao"
        Me.lblSituacao.Size = New System.Drawing.Size(56, 14)
        Me.lblSituacao.TabIndex = 10
        Me.lblSituacao.Text = "Situação:"
        '
        'lblValorCNAE
        '
        Me.lblValorCNAE.AutoSize = True
        Me.lblValorCNAE.Location = New System.Drawing.Point(218, 50)
        Me.lblValorCNAE.Name = "lblValorCNAE"
        Me.lblValorCNAE.Size = New System.Drawing.Size(11, 14)
        Me.lblValorCNAE.TabIndex = 7
        Me.lblValorCNAE.Text = "-"
        '
        'lblCNAE
        '
        Me.lblCNAE.AutoSize = True
        Me.lblCNAE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCNAE.Location = New System.Drawing.Point(169, 50)
        Me.lblCNAE.Name = "lblCNAE"
        Me.lblCNAE.Size = New System.Drawing.Size(39, 14)
        Me.lblCNAE.TabIndex = 6
        Me.lblCNAE.Text = "CNAE:"
        '
        'lblValorDataInicioAtividade
        '
        Me.lblValorDataInicioAtividade.AutoSize = True
        Me.lblValorDataInicioAtividade.Location = New System.Drawing.Point(97, 50)
        Me.lblValorDataInicioAtividade.Name = "lblValorDataInicioAtividade"
        Me.lblValorDataInicioAtividade.Size = New System.Drawing.Size(11, 14)
        Me.lblValorDataInicioAtividade.TabIndex = 5
        Me.lblValorDataInicioAtividade.Text = "-"
        '
        'lblDataInicioAtividade
        '
        Me.lblDataInicioAtividade.AutoSize = True
        Me.lblDataInicioAtividade.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataInicioAtividade.Location = New System.Drawing.Point(6, 50)
        Me.lblDataInicioAtividade.Name = "lblDataInicioAtividade"
        Me.lblDataInicioAtividade.Size = New System.Drawing.Size(79, 14)
        Me.lblDataInicioAtividade.TabIndex = 4
        Me.lblDataInicioAtividade.Text = "Dt Início Ativ.:"
        '
        'lblValorRazaoSocial
        '
        Me.lblValorRazaoSocial.AutoSize = True
        Me.lblValorRazaoSocial.Location = New System.Drawing.Point(97, 14)
        Me.lblValorRazaoSocial.Name = "lblValorRazaoSocial"
        Me.lblValorRazaoSocial.Size = New System.Drawing.Size(11, 14)
        Me.lblValorRazaoSocial.TabIndex = 1
        Me.lblValorRazaoSocial.Text = "-"
        '
        'lblRazaoSocial
        '
        Me.lblRazaoSocial.AutoSize = True
        Me.lblRazaoSocial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazaoSocial.Location = New System.Drawing.Point(6, 14)
        Me.lblRazaoSocial.Name = "lblRazaoSocial"
        Me.lblRazaoSocial.Size = New System.Drawing.Size(77, 14)
        Me.lblRazaoSocial.TabIndex = 0
        Me.lblRazaoSocial.Text = "Razão Social:"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.lblNomeFantasia)
        Me.UiGroupBox1.Controls.Add(Me.lblValorNomeFantasia)
        Me.UiGroupBox1.Controls.Add(Me.lblInscricaoEstadual)
        Me.UiGroupBox1.Controls.Add(Me.lblValorInscricaoEstadual)
        Me.UiGroupBox1.Controls.Add(Me.lblRazaoSocial)
        Me.UiGroupBox1.Controls.Add(Me.lblValorSituacaoContribuinte)
        Me.UiGroupBox1.Controls.Add(Me.lblValorRazaoSocial)
        Me.UiGroupBox1.Controls.Add(Me.lblSituacaoContribuinte)
        Me.UiGroupBox1.Controls.Add(Me.lblDataInicioAtividade)
        Me.UiGroupBox1.Controls.Add(Me.lblValorSituacao)
        Me.UiGroupBox1.Controls.Add(Me.lblValorDataInicioAtividade)
        Me.UiGroupBox1.Controls.Add(Me.lblSituacao)
        Me.UiGroupBox1.Controls.Add(Me.lblCNAE)
        Me.UiGroupBox1.Controls.Add(Me.lblValorCNAE)
        Me.UiGroupBox1.Location = New System.Drawing.Point(151, 48)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.Size = New System.Drawing.Size(450, 95)
        Me.UiGroupBox1.TabIndex = 4
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'lblNomeFantasia
        '
        Me.lblNomeFantasia.AutoSize = True
        Me.lblNomeFantasia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeFantasia.Location = New System.Drawing.Point(6, 32)
        Me.lblNomeFantasia.Name = "lblNomeFantasia"
        Me.lblNomeFantasia.Size = New System.Drawing.Size(90, 14)
        Me.lblNomeFantasia.TabIndex = 2
        Me.lblNomeFantasia.Text = "Nome Fantasia:"
        '
        'lblValorNomeFantasia
        '
        Me.lblValorNomeFantasia.AutoSize = True
        Me.lblValorNomeFantasia.Location = New System.Drawing.Point(97, 32)
        Me.lblValorNomeFantasia.Name = "lblValorNomeFantasia"
        Me.lblValorNomeFantasia.Size = New System.Drawing.Size(11, 14)
        Me.lblValorNomeFantasia.TabIndex = 3
        Me.lblValorNomeFantasia.Text = "-"
        '
        'lblInscricaoEstadual
        '
        Me.lblInscricaoEstadual.AutoSize = True
        Me.lblInscricaoEstadual.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInscricaoEstadual.Location = New System.Drawing.Point(302, 50)
        Me.lblInscricaoEstadual.Name = "lblInscricaoEstadual"
        Me.lblInscricaoEstadual.Size = New System.Drawing.Size(19, 14)
        Me.lblInscricaoEstadual.TabIndex = 8
        Me.lblInscricaoEstadual.Text = "IE:"
        '
        'lblValorInscricaoEstadual
        '
        Me.lblValorInscricaoEstadual.AutoSize = True
        Me.lblValorInscricaoEstadual.Location = New System.Drawing.Point(327, 50)
        Me.lblValorInscricaoEstadual.Name = "lblValorInscricaoEstadual"
        Me.lblValorInscricaoEstadual.Size = New System.Drawing.Size(11, 14)
        Me.lblValorInscricaoEstadual.TabIndex = 9
        Me.lblValorInscricaoEstadual.Text = "-"
        '
        'txtCNPJContribuinte
        '
        Me.txtCNPJContribuinte.Location = New System.Drawing.Point(151, 27)
        Me.txtCNPJContribuinte.Mask = "00,000,000/0000-00"
        Me.txtCNPJContribuinte.MaxLength = 20
        Me.txtCNPJContribuinte.Name = "txtCNPJContribuinte"
        Me.txtCNPJContribuinte.Size = New System.Drawing.Size(108, 20)
        Me.txtCNPJContribuinte.TabIndex = 1
        '
        'lblCNPJContribuinte
        '
        Me.lblCNPJContribuinte.AutoSize = True
        Me.lblCNPJContribuinte.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCNPJContribuinte.Location = New System.Drawing.Point(148, 10)
        Me.lblCNPJContribuinte.Name = "lblCNPJContribuinte"
        Me.lblCNPJContribuinte.Size = New System.Drawing.Size(35, 14)
        Me.lblCNPJContribuinte.TabIndex = 0
        Me.lblCNPJContribuinte.Text = "CNPJ:"
        '
        'picFornecedor
        '
        Me.picFornecedor.Image = Global.INTERACTI.My.Resources.fornecedor
        Me.picFornecedor.Location = New System.Drawing.Point(13, 26)
        Me.picFornecedor.Name = "picFornecedor"
        Me.picFornecedor.Size = New System.Drawing.Size(130, 130)
        Me.picFornecedor.TabIndex = 9
        Me.picFornecedor.TabStop = False
        '
        'lblUFContribuinte
        '
        Me.lblUFContribuinte.AutoSize = True
        Me.lblUFContribuinte.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUFContribuinte.Location = New System.Drawing.Point(262, 10)
        Me.lblUFContribuinte.Name = "lblUFContribuinte"
        Me.lblUFContribuinte.Size = New System.Drawing.Size(23, 14)
        Me.lblUFContribuinte.TabIndex = 2
        Me.lblUFContribuinte.Text = "UF:"
        '
        'cboUFContribuinte
        '
        Me.cboUFContribuinte.AutoSize = False
        Me.cboUFContribuinte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboUFContribuinte.Location = New System.Drawing.Point(265, 27)
        Me.cboUFContribuinte.Name = "cboUFContribuinte"
        Me.cboUFContribuinte.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboUFContribuinte.Size = New System.Drawing.Size(58, 20)
        Me.cboUFContribuinte.TabIndex = 3
        '
        'usrFatEmissaoNFeConsultarSituacaoParceiroNegocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblUFContribuinte)
        Me.Controls.Add(Me.cboUFContribuinte)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Controls.Add(Me.txtCNPJContribuinte)
        Me.Controls.Add(Me.lblCNPJContribuinte)
        Me.Controls.Add(Me.UiGroupBox2)
        Me.Controls.Add(Me.picFornecedor)
        Me.Controls.Add(Me.UiGroupBox3)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrFatEmissaoNFeConsultarSituacaoParceiroNegocio"
        Me.Size = New System.Drawing.Size(615, 292)
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.picFornecedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents picFornecedor As System.Windows.Forms.PictureBox
    Friend WithEvents btnConsultar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtEmail As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtUsuario As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtSenha As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents txtServidor As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtPorta As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblValorLogradouro As System.Windows.Forms.Label
    Friend WithEvents lblLogradouro As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblValorNumero As System.Windows.Forms.Label
    Friend WithEvents lblValorMunicipio As System.Windows.Forms.Label
    Friend WithEvents lblMunicipio As System.Windows.Forms.Label
    Friend WithEvents lblValorBairro As System.Windows.Forms.Label
    Friend WithEvents lblComplemento As System.Windows.Forms.Label
    Friend WithEvents lblValorComplemento As System.Windows.Forms.Label
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents lblValorRazaoSocial As System.Windows.Forms.Label
    Friend WithEvents lblRazaoSocial As System.Windows.Forms.Label
    Friend WithEvents lblValorCEP As System.Windows.Forms.Label
    Friend WithEvents lblCEP As System.Windows.Forms.Label
    Friend WithEvents lblValorUF As System.Windows.Forms.Label
    Friend WithEvents lblUF As System.Windows.Forms.Label
    Friend WithEvents lblValorCNAE As System.Windows.Forms.Label
    Friend WithEvents lblCNAE As System.Windows.Forms.Label
    Friend WithEvents lblValorDataInicioAtividade As System.Windows.Forms.Label
    Friend WithEvents lblDataInicioAtividade As System.Windows.Forms.Label
    Friend WithEvents lblValorSituacaoContribuinte As System.Windows.Forms.Label
    Friend WithEvents lblSituacaoContribuinte As System.Windows.Forms.Label
    Friend WithEvents lblValorSituacao As System.Windows.Forms.Label
    Friend WithEvents lblSituacao As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtCNPJContribuinte As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCNPJContribuinte As System.Windows.Forms.Label
    Friend WithEvents btnCadastrar As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblInscricaoEstadual As System.Windows.Forms.Label
    Friend WithEvents lblValorInscricaoEstadual As System.Windows.Forms.Label
    Friend WithEvents lblNomeFantasia As System.Windows.Forms.Label
    Friend WithEvents lblValorNomeFantasia As System.Windows.Forms.Label
    Friend WithEvents lblUFContribuinte As System.Windows.Forms.Label
    Friend WithEvents cboUFContribuinte As Janus.Windows.EditControls.UIComboBox

End Class
