<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCadEmpresa
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
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCadEmpresa))
        Dim SuperTipSettings1 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings2 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings3 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings4 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings5 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Dim SuperTipSettings6 As Janus.Windows.Common.SuperTipSettings = New Janus.Windows.Common.SuperTipSettings()
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagDados = New Janus.Windows.UI.Tab.UITabPage()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtDespesaMensal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblDespesaMensal = New System.Windows.Forms.Label()
        Me.txtFaturamentoMensal = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblFaturamentoMensal = New System.Windows.Forms.Label()
        Me.txtFaturamentoAnual = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.lblFaturamentoAnual = New System.Windows.Forms.Label()
        Me.grpNFSe = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblRegimeEspecialTributacao = New System.Windows.Forms.Label()
        Me.cboRegimeEspecialTributacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblIncentivadorCultural = New System.Windows.Forms.Label()
        Me.cboIncentivadorCultural = New Janus.Windows.EditControls.UIComboBox()
        Me.txtInscricaoMunicipal = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoMunicipal = New System.Windows.Forms.Label()
        Me.grpLogo = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnLimparLogo = New Janus.Windows.EditControls.UIButton()
        Me.txtLogo = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnLogo = New Janus.Windows.EditControls.UIButton()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.grpEndereco = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnProcurarCEP = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtTelefone = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.cboMunicipio = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNumero = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtComplemento = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.txtBairro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.cboPais = New Janus.Windows.EditControls.UIComboBox()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.txtCEP = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.cboUF = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblLogradouro = New System.Windows.Forms.Label()
        Me.txtLogradouro = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.grpDados = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtSigla = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblSigla = New System.Windows.Forms.Label()
        Me.txtInscricaoEstadualST = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoEstadualST = New System.Windows.Forms.Label()
        Me.lblCNAE = New System.Windows.Forms.Label()
        Me.cboCNAE = New Janus.Windows.EditControls.UIComboBox()
        Me.txtInscricaoEstadual = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblInscricaoEstadual = New System.Windows.Forms.Label()
        Me.txtCNPJ = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblCNPJ = New System.Windows.Forms.Label()
        Me.lblRegimeTributario = New System.Windows.Forms.Label()
        Me.cboRegimeTributario = New Janus.Windows.EditControls.UIComboBox()
        Me.txtNomeFantasia = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblNomeFantasia = New System.Windows.Forms.Label()
        Me.txtRazaoSocial = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblRazaoSocial = New System.Windows.Forms.Label()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage()
        Me.jstTip = New Janus.Windows.Common.JanusSuperTip(Me.components)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagDados.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grpNFSe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNFSe.SuspendLayout()
        CType(Me.grpLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLogo.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpEndereco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEndereco.SuspendLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDados.SuspendLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControle.SuspendLayout()
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
        resources.ApplyResources(Me.tabMain, "tabMain")
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.ShowFocusRectangle = False
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagDados})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagDados
        '
        Me.pagDados.Controls.Add(Me.UiGroupBox1)
        Me.pagDados.Controls.Add(Me.grpNFSe)
        Me.pagDados.Controls.Add(Me.grpLogo)
        Me.pagDados.Controls.Add(Me.grpEndereco)
        Me.pagDados.Controls.Add(Me.grpDados)
        Me.pagDados.Controls.Add(Me.grpControle)
        resources.ApplyResources(Me.pagDados, "pagDados")
        Me.pagDados.Key = "padDados"
        Me.pagDados.Name = "pagDados"
        Me.pagDados.TabStop = True
        '
        'UiGroupBox1
        '
        resources.ApplyResources(Me.UiGroupBox1, "UiGroupBox1")
        Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.txtDespesaMensal)
        Me.UiGroupBox1.Controls.Add(Me.lblDespesaMensal)
        Me.UiGroupBox1.Controls.Add(Me.txtFaturamentoMensal)
        Me.UiGroupBox1.Controls.Add(Me.lblFaturamentoMensal)
        Me.UiGroupBox1.Controls.Add(Me.txtFaturamentoAnual)
        Me.UiGroupBox1.Controls.Add(Me.lblFaturamentoAnual)
        Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.UiGroupBox1.VisualStyleManager = Me.vsmMain
        '
        'txtDespesaMensal
        '
        Me.txtDespesaMensal.DecimalDigits = 4
        resources.ApplyResources(Me.txtDespesaMensal, "txtDespesaMensal")
        Me.txtDespesaMensal.Name = "txtDespesaMensal"
        Me.txtDespesaMensal.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblDespesaMensal
        '
        resources.ApplyResources(Me.lblDespesaMensal, "lblDespesaMensal")
        Me.lblDespesaMensal.Name = "lblDespesaMensal"
        '
        'txtFaturamentoMensal
        '
        Me.txtFaturamentoMensal.DecimalDigits = 4
        resources.ApplyResources(Me.txtFaturamentoMensal, "txtFaturamentoMensal")
        Me.txtFaturamentoMensal.Name = "txtFaturamentoMensal"
        Me.txtFaturamentoMensal.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblFaturamentoMensal
        '
        resources.ApplyResources(Me.lblFaturamentoMensal, "lblFaturamentoMensal")
        Me.lblFaturamentoMensal.Name = "lblFaturamentoMensal"
        '
        'txtFaturamentoAnual
        '
        Me.txtFaturamentoAnual.DecimalDigits = 4
        resources.ApplyResources(Me.txtFaturamentoAnual, "txtFaturamentoAnual")
        Me.txtFaturamentoAnual.Name = "txtFaturamentoAnual"
        Me.txtFaturamentoAnual.Value = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'lblFaturamentoAnual
        '
        resources.ApplyResources(Me.lblFaturamentoAnual, "lblFaturamentoAnual")
        Me.lblFaturamentoAnual.Name = "lblFaturamentoAnual"
        '
        'grpNFSe
        '
        resources.ApplyResources(Me.grpNFSe, "grpNFSe")
        Me.grpNFSe.BackColor = System.Drawing.Color.Transparent
        Me.grpNFSe.Controls.Add(Me.lblRegimeEspecialTributacao)
        Me.grpNFSe.Controls.Add(Me.cboRegimeEspecialTributacao)
        Me.grpNFSe.Controls.Add(Me.lblIncentivadorCultural)
        Me.grpNFSe.Controls.Add(Me.cboIncentivadorCultural)
        Me.grpNFSe.Controls.Add(Me.txtInscricaoMunicipal)
        Me.grpNFSe.Controls.Add(Me.lblInscricaoMunicipal)
        Me.grpNFSe.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpNFSe.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpNFSe.Name = "grpNFSe"
        Me.grpNFSe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpNFSe.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpNFSe.VisualStyleManager = Me.vsmMain
        '
        'lblRegimeEspecialTributacao
        '
        resources.ApplyResources(Me.lblRegimeEspecialTributacao, "lblRegimeEspecialTributacao")
        Me.lblRegimeEspecialTributacao.Name = "lblRegimeEspecialTributacao"
        '
        'cboRegimeEspecialTributacao
        '
        resources.ApplyResources(Me.cboRegimeEspecialTributacao, "cboRegimeEspecialTributacao")
        Me.cboRegimeEspecialTributacao.Name = "cboRegimeEspecialTributacao"
        Me.cboRegimeEspecialTributacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblIncentivadorCultural
        '
        resources.ApplyResources(Me.lblIncentivadorCultural, "lblIncentivadorCultural")
        Me.lblIncentivadorCultural.Name = "lblIncentivadorCultural"
        '
        'cboIncentivadorCultural
        '
        resources.ApplyResources(Me.cboIncentivadorCultural, "cboIncentivadorCultural")
        Me.cboIncentivadorCultural.Name = "cboIncentivadorCultural"
        Me.cboIncentivadorCultural.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtInscricaoMunicipal
        '
        resources.ApplyResources(Me.txtInscricaoMunicipal, "txtInscricaoMunicipal")
        Me.txtInscricaoMunicipal.MaxLength = 15
        Me.txtInscricaoMunicipal.Name = "txtInscricaoMunicipal"
        SuperTipSettings1.HeaderText = "Inscrição Municipal"
        SuperTipSettings1.ImageListProvider = Nothing
        SuperTipSettings1.Text = "Preencher Inscrição Municipal (somente números)"
        Me.jstTip.SetSuperTip(Me.txtInscricaoMunicipal, SuperTipSettings1)
        '
        'lblInscricaoMunicipal
        '
        resources.ApplyResources(Me.lblInscricaoMunicipal, "lblInscricaoMunicipal")
        Me.lblInscricaoMunicipal.Name = "lblInscricaoMunicipal"
        '
        'grpLogo
        '
        resources.ApplyResources(Me.grpLogo, "grpLogo")
        Me.grpLogo.BackColor = System.Drawing.Color.Transparent
        Me.grpLogo.Controls.Add(Me.btnLimparLogo)
        Me.grpLogo.Controls.Add(Me.txtLogo)
        Me.grpLogo.Controls.Add(Me.btnLogo)
        Me.grpLogo.Controls.Add(Me.lblLogo)
        Me.grpLogo.Controls.Add(Me.picLogo)
        Me.grpLogo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpLogo.Name = "grpLogo"
        Me.grpLogo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpLogo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpLogo.VisualStyleManager = Me.vsmMain
        '
        'btnLimparLogo
        '
        resources.ApplyResources(Me.btnLimparLogo, "btnLimparLogo")
        Me.btnLimparLogo.Image = Global.INTERACTI.My.Resources.Resources.limpar
        Me.btnLimparLogo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnLimparLogo.Name = "btnLimparLogo"
        Me.btnLimparLogo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        SuperTipSettings2.HeaderText = "Logo"
        SuperTipSettings2.ImageListProvider = Nothing
        SuperTipSettings2.Text = "Clique para apagar o Logo selecionado"
        Me.jstTip.SetSuperTip(Me.btnLimparLogo, SuperTipSettings2)
        Me.btnLimparLogo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'txtLogo
        '
        resources.ApplyResources(Me.txtLogo, "txtLogo")
        Me.txtLogo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLogo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogo.MaxLength = 60
        Me.txtLogo.Name = "txtLogo"
        Me.txtLogo.ReadOnly = True
        Me.txtLogo.TabStop = False
        '
        'btnLogo
        '
        resources.ApplyResources(Me.btnLogo, "btnLogo")
        Me.btnLogo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        SuperTipSettings3.HeaderText = "Logo"
        SuperTipSettings3.ImageListProvider = Nothing
        SuperTipSettings3.Text = "Clique para selecionar o Logo"
        Me.jstTip.SetSuperTip(Me.btnLogo, SuperTipSettings3)
        Me.btnLogo.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblLogo
        '
        resources.ApplyResources(Me.lblLogo, "lblLogo")
        Me.lblLogo.Name = "lblLogo"
        '
        'picLogo
        '
        resources.ApplyResources(Me.picLogo, "picLogo")
        Me.picLogo.BackColor = System.Drawing.SystemColors.Window
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLogo.Name = "picLogo"
        SuperTipSettings4.HeaderText = "Logo"
        SuperTipSettings4.ImageListProvider = Nothing
        SuperTipSettings4.Text = "O Logo selecionado será exibido em todos os relatórios." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Seu tamanho será redim" & _
    "ensionado para 40x25mm."
        Me.jstTip.SetSuperTip(Me.picLogo, SuperTipSettings4)
        Me.picLogo.TabStop = False
        '
        'grpEndereco
        '
        resources.ApplyResources(Me.grpEndereco, "grpEndereco")
        Me.grpEndereco.BackColor = System.Drawing.Color.Transparent
        Me.grpEndereco.Controls.Add(Me.btnProcurarCEP)
        Me.grpEndereco.Controls.Add(Me.lblEmail)
        Me.grpEndereco.Controls.Add(Me.txtEmail)
        Me.grpEndereco.Controls.Add(Me.lblTelefone)
        Me.grpEndereco.Controls.Add(Me.txtTelefone)
        Me.grpEndereco.Controls.Add(Me.cboMunicipio)
        Me.grpEndereco.Controls.Add(Me.txtNumero)
        Me.grpEndereco.Controls.Add(Me.txtComplemento)
        Me.grpEndereco.Controls.Add(Me.txtBairro)
        Me.grpEndereco.Controls.Add(Me.lblPais)
        Me.grpEndereco.Controls.Add(Me.cboPais)
        Me.grpEndereco.Controls.Add(Me.lblCEP)
        Me.grpEndereco.Controls.Add(Me.txtCEP)
        Me.grpEndereco.Controls.Add(Me.lblComplemento)
        Me.grpEndereco.Controls.Add(Me.lblUF)
        Me.grpEndereco.Controls.Add(Me.cboUF)
        Me.grpEndereco.Controls.Add(Me.lblMunicipio)
        Me.grpEndereco.Controls.Add(Me.lblBairro)
        Me.grpEndereco.Controls.Add(Me.lblNumero)
        Me.grpEndereco.Controls.Add(Me.lblLogradouro)
        Me.grpEndereco.Controls.Add(Me.txtLogradouro)
        Me.grpEndereco.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpEndereco.Name = "grpEndereco"
        Me.grpEndereco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpEndereco.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpEndereco.VisualStyleManager = Me.vsmMain
        '
        'btnProcurarCEP
        '
        Me.btnProcurarCEP.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.btnProcurarCEP, "btnProcurarCEP")
        Me.btnProcurarCEP.Image = Global.INTERACTI.My.Resources.Resources.search
        Me.btnProcurarCEP.Name = "btnProcurarCEP"
        Me.btnProcurarCEP.TabStop = False
        Me.btnProcurarCEP.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        resources.ApplyResources(Me.lblEmail, "lblEmail")
        Me.lblEmail.Name = "lblEmail"
        '
        'txtEmail
        '
        resources.ApplyResources(Me.txtEmail, "txtEmail")
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.MaxLength = 60
        Me.txtEmail.Name = "txtEmail"
        '
        'lblTelefone
        '
        resources.ApplyResources(Me.lblTelefone, "lblTelefone")
        Me.lblTelefone.Name = "lblTelefone"
        '
        'txtTelefone
        '
        resources.ApplyResources(Me.txtTelefone, "txtTelefone")
        Me.txtTelefone.Mask = "!(##) 0000-0000"
        Me.txtTelefone.MaxLength = 10
        Me.txtTelefone.Name = "txtTelefone"
        '
        'cboMunicipio
        '
        resources.ApplyResources(Me.cboMunicipio, "cboMunicipio")
        Me.cboMunicipio.Name = "cboMunicipio"
        Me.cboMunicipio.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtNumero
        '
        resources.ApplyResources(Me.txtNumero, "txtNumero")
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.MaxLength = 60
        Me.txtNumero.Name = "txtNumero"
        '
        'txtComplemento
        '
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtComplemento, "txtComplemento")
        Me.txtComplemento.MaxLength = 60
        Me.txtComplemento.Name = "txtComplemento"
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtBairro, "txtBairro")
        Me.txtBairro.MaxLength = 60
        Me.txtBairro.Name = "txtBairro"
        '
        'lblPais
        '
        resources.ApplyResources(Me.lblPais, "lblPais")
        Me.lblPais.Name = "lblPais"
        '
        'cboPais
        '
        resources.ApplyResources(Me.cboPais, "cboPais")
        Me.cboPais.Name = "cboPais"
        Me.cboPais.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblCEP
        '
        resources.ApplyResources(Me.lblCEP, "lblCEP")
        Me.lblCEP.Name = "lblCEP"
        '
        'txtCEP
        '
        resources.ApplyResources(Me.txtCEP, "txtCEP")
        Me.txtCEP.Mask = "00000-000"
        Me.txtCEP.MaxLength = 10
        Me.txtCEP.Name = "txtCEP"
        '
        'lblComplemento
        '
        resources.ApplyResources(Me.lblComplemento, "lblComplemento")
        Me.lblComplemento.Name = "lblComplemento"
        '
        'lblUF
        '
        resources.ApplyResources(Me.lblUF, "lblUF")
        Me.lblUF.Name = "lblUF"
        '
        'cboUF
        '
        resources.ApplyResources(Me.cboUF, "cboUF")
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'lblMunicipio
        '
        resources.ApplyResources(Me.lblMunicipio, "lblMunicipio")
        Me.lblMunicipio.Name = "lblMunicipio"
        '
        'lblBairro
        '
        resources.ApplyResources(Me.lblBairro, "lblBairro")
        Me.lblBairro.Name = "lblBairro"
        '
        'lblNumero
        '
        resources.ApplyResources(Me.lblNumero, "lblNumero")
        Me.lblNumero.Name = "lblNumero"
        '
        'lblLogradouro
        '
        resources.ApplyResources(Me.lblLogradouro, "lblLogradouro")
        Me.lblLogradouro.Name = "lblLogradouro"
        '
        'txtLogradouro
        '
        resources.ApplyResources(Me.txtLogradouro, "txtLogradouro")
        Me.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogradouro.MaxLength = 60
        Me.txtLogradouro.Name = "txtLogradouro"
        '
        'grpDados
        '
        resources.ApplyResources(Me.grpDados, "grpDados")
        Me.grpDados.BackColor = System.Drawing.Color.Transparent
        Me.grpDados.Controls.Add(Me.txtSigla)
        Me.grpDados.Controls.Add(Me.lblSigla)
        Me.grpDados.Controls.Add(Me.txtInscricaoEstadualST)
        Me.grpDados.Controls.Add(Me.lblInscricaoEstadualST)
        Me.grpDados.Controls.Add(Me.lblCNAE)
        Me.grpDados.Controls.Add(Me.cboCNAE)
        Me.grpDados.Controls.Add(Me.txtInscricaoEstadual)
        Me.grpDados.Controls.Add(Me.lblInscricaoEstadual)
        Me.grpDados.Controls.Add(Me.txtCNPJ)
        Me.grpDados.Controls.Add(Me.lblCNPJ)
        Me.grpDados.Controls.Add(Me.lblRegimeTributario)
        Me.grpDados.Controls.Add(Me.cboRegimeTributario)
        Me.grpDados.Controls.Add(Me.txtNomeFantasia)
        Me.grpDados.Controls.Add(Me.lblNomeFantasia)
        Me.grpDados.Controls.Add(Me.txtRazaoSocial)
        Me.grpDados.Controls.Add(Me.lblRazaoSocial)
        Me.grpDados.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDados.Name = "grpDados"
        Me.grpDados.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDados.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDados.VisualStyleManager = Me.vsmMain
        '
        'txtSigla
        '
        Me.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtSigla, "txtSigla")
        Me.txtSigla.MaxLength = 3
        Me.txtSigla.Name = "txtSigla"
        '
        'lblSigla
        '
        resources.ApplyResources(Me.lblSigla, "lblSigla")
        Me.lblSigla.Name = "lblSigla"
        '
        'txtInscricaoEstadualST
        '
        resources.ApplyResources(Me.txtInscricaoEstadualST, "txtInscricaoEstadualST")
        Me.txtInscricaoEstadualST.MaxLength = 15
        Me.txtInscricaoEstadualST.Name = "txtInscricaoEstadualST"
        SuperTipSettings5.HeaderText = "Inscrição Municipal"
        SuperTipSettings5.ImageListProvider = Nothing
        SuperTipSettings5.Text = "Preencher Inscrição Municipal (somente números)"
        Me.jstTip.SetSuperTip(Me.txtInscricaoEstadualST, SuperTipSettings5)
        '
        'lblInscricaoEstadualST
        '
        resources.ApplyResources(Me.lblInscricaoEstadualST, "lblInscricaoEstadualST")
        Me.lblInscricaoEstadualST.Name = "lblInscricaoEstadualST"
        '
        'lblCNAE
        '
        resources.ApplyResources(Me.lblCNAE, "lblCNAE")
        Me.lblCNAE.Name = "lblCNAE"
        '
        'cboCNAE
        '
        resources.ApplyResources(Me.cboCNAE, "cboCNAE")
        Me.cboCNAE.Name = "cboCNAE"
        Me.cboCNAE.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtInscricaoEstadual
        '
        resources.ApplyResources(Me.txtInscricaoEstadual, "txtInscricaoEstadual")
        Me.txtInscricaoEstadual.MaxLength = 14
        Me.txtInscricaoEstadual.Name = "txtInscricaoEstadual"
        SuperTipSettings6.HeaderText = "Inscrição Estadual"
        SuperTipSettings6.ImageListProvider = Nothing
        SuperTipSettings6.Text = resources.GetString("SuperTipSettings6.Text")
        Me.jstTip.SetSuperTip(Me.txtInscricaoEstadual, SuperTipSettings6)
        '
        'lblInscricaoEstadual
        '
        resources.ApplyResources(Me.lblInscricaoEstadual, "lblInscricaoEstadual")
        Me.lblInscricaoEstadual.Name = "lblInscricaoEstadual"
        '
        'txtCNPJ
        '
        resources.ApplyResources(Me.txtCNPJ, "txtCNPJ")
        Me.txtCNPJ.Mask = "00,000,000/0000-00"
        Me.txtCNPJ.MaxLength = 20
        Me.txtCNPJ.Name = "txtCNPJ"
        '
        'lblCNPJ
        '
        resources.ApplyResources(Me.lblCNPJ, "lblCNPJ")
        Me.lblCNPJ.Name = "lblCNPJ"
        '
        'lblRegimeTributario
        '
        resources.ApplyResources(Me.lblRegimeTributario, "lblRegimeTributario")
        Me.lblRegimeTributario.Name = "lblRegimeTributario"
        '
        'cboRegimeTributario
        '
        resources.ApplyResources(Me.cboRegimeTributario, "cboRegimeTributario")
        Me.cboRegimeTributario.Name = "cboRegimeTributario"
        Me.cboRegimeTributario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        '
        'txtNomeFantasia
        '
        resources.ApplyResources(Me.txtNomeFantasia, "txtNomeFantasia")
        Me.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeFantasia.MaxLength = 60
        Me.txtNomeFantasia.Name = "txtNomeFantasia"
        '
        'lblNomeFantasia
        '
        resources.ApplyResources(Me.lblNomeFantasia, "lblNomeFantasia")
        Me.lblNomeFantasia.Name = "lblNomeFantasia"
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtRazaoSocial, "txtRazaoSocial")
        Me.txtRazaoSocial.MaxLength = 60
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        '
        'lblRazaoSocial
        '
        resources.ApplyResources(Me.lblRazaoSocial, "lblRazaoSocial")
        Me.lblRazaoSocial.Name = "lblRazaoSocial"
        '
        'grpControle
        '
        resources.ApplyResources(Me.grpControle, "grpControle")
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Controls.Add(Me.btnSalvar)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'btnSair
        '
        resources.ApplyResources(Me.btnSair, "btnSair")
        Me.btnSair.Image = Global.INTERACTI.My.Resources.Resources.sair
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        resources.ApplyResources(Me.btnSalvar, "btnSalvar")
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Key = "pagVendas"
        resources.ApplyResources(Me.UiTabPage1, "UiTabPage1")
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.TabStop = True
        '
        'jstTip
        '
        Me.jstTip.AutoPopDelay = 3000
        Me.jstTip.ImageList = Nothing
        Me.jstTip.InitialDelay = 0
        Me.jstTip.ShowAlways = True
        '
        'usrCadEmpresa
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Name = "usrCadEmpresa"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagDados.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grpNFSe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNFSe.ResumeLayout(False)
        Me.grpNFSe.PerformLayout()
        CType(Me.grpLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLogo.ResumeLayout(False)
        Me.grpLogo.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpEndereco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEndereco.ResumeLayout(False)
        Me.grpEndereco.PerformLayout()
        CType(Me.grpDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDados.ResumeLayout(False)
        Me.grpDados.PerformLayout()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagDados As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents jstTip As Janus.Windows.Common.JanusSuperTip
    Friend WithEvents grpEndereco As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblTelefone As System.Windows.Forms.Label
    Friend WithEvents txtTelefone As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents cboMunicipio As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNumero As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtComplemento As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtBairro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPais As System.Windows.Forms.Label
    Friend WithEvents cboPais As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblCEP As System.Windows.Forms.Label
    Friend WithEvents txtCEP As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblComplemento As System.Windows.Forms.Label
    Friend WithEvents lblUF As System.Windows.Forms.Label
    Friend WithEvents cboUF As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMunicipio As System.Windows.Forms.Label
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblLogradouro As System.Windows.Forms.Label
    Friend WithEvents txtLogradouro As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents grpDados As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCNAE As System.Windows.Forms.Label
    Friend WithEvents cboCNAE As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtInscricaoEstadual As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoEstadual As System.Windows.Forms.Label
    Friend WithEvents txtCNPJ As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblCNPJ As System.Windows.Forms.Label
    Friend WithEvents lblRegimeTributario As System.Windows.Forms.Label
    Friend WithEvents cboRegimeTributario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents txtNomeFantasia As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblNomeFantasia As System.Windows.Forms.Label
    Friend WithEvents txtRazaoSocial As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblRazaoSocial As System.Windows.Forms.Label
    Friend WithEvents txtInscricaoEstadualST As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoEstadualST As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtSigla As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblSigla As System.Windows.Forms.Label
    Friend WithEvents grpLogo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtLogo As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents btnLogo As Janus.Windows.EditControls.UIButton
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents grpNFSe As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtInscricaoMunicipal As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblInscricaoMunicipal As System.Windows.Forms.Label
    Friend WithEvents lblRegimeEspecialTributacao As System.Windows.Forms.Label
    Friend WithEvents cboRegimeEspecialTributacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblIncentivadorCultural As System.Windows.Forms.Label
    Friend WithEvents cboIncentivadorCultural As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnLimparLogo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnProcurarCEP As System.Windows.Forms.Button
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDespesaMensal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblDespesaMensal As System.Windows.Forms.Label
    Friend WithEvents txtFaturamentoMensal As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblFaturamentoMensal As System.Windows.Forms.Label
    Friend WithEvents txtFaturamentoAnual As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblFaturamentoAnual As System.Windows.Forms.Label

End Class
