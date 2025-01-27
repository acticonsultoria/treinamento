<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrCustFuncionarioSalario
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
        Dim grdListagem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usrCustFuncionarioSalario))
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.tabMain = New Janus.Windows.UI.Tab.UITab()
        Me.pagLista = New Janus.Windows.UI.Tab.UITabPage()
        Me.grpDadosArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtLinhaInicio = New Janus.Windows.GridEX.EditControls.NumericEditBox()
        Me.cboConfiguracaoColunaAssistenciaMedica = New Janus.Windows.EditControls.UIComboBox()
        Me.lblLinhaInicio = New System.Windows.Forms.Label()
        Me.cboConfiguracaoColunaValeRefeicao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblConfiguracaoColunaValeRefeicao = New System.Windows.Forms.Label()
        Me.cboConfiguracaoColunaValeTransporte = New Janus.Windows.EditControls.UIComboBox()
        Me.lblConfiguracaoColunaValeTransporte = New System.Windows.Forms.Label()
        Me.cboConfiguracaoColunaSalario = New Janus.Windows.EditControls.UIComboBox()
        Me.lblConfiguracaoColunaSalario = New System.Windows.Forms.Label()
        Me.cboConfiguracaoColunaFGTS = New Janus.Windows.EditControls.UIComboBox()
        Me.lblConfiguracaoColunaProntuario = New System.Windows.Forms.Label()
        Me.lblConfiguracaoColunaFGTS = New System.Windows.Forms.Label()
        Me.cboConfiguracaoColunaIRRF = New Janus.Windows.EditControls.UIComboBox()
        Me.lblConfiguracaoColunaIRRF = New System.Windows.Forms.Label()
        Me.cboConfiguracaoColunaProntuario = New Janus.Windows.EditControls.UIComboBox()
        Me.cboConfiguracaoColunaValeAlimentacao = New Janus.Windows.EditControls.UIComboBox()
        Me.lblConfiguracaoColunaValeAlimentacao = New System.Windows.Forms.Label()
        Me.cboConfiguracaoColunaINSS = New Janus.Windows.EditControls.UIComboBox()
        Me.lblConfiguracaoColunaINSS = New System.Windows.Forms.Label()
        Me.cboConfiguracaoColunaDSR = New Janus.Windows.EditControls.UIComboBox()
        Me.lblConfiguracaoColunaDSR = New System.Windows.Forms.Label()
        Me.cboConfiguracaoColunaValorHoraExtra = New Janus.Windows.EditControls.UIComboBox()
        Me.lblConfiguracaoColunaValorHoraExtra = New System.Windows.Forms.Label()
        Me.cboConfiguracaoColunaQuantidadeHoraExtra = New Janus.Windows.EditControls.UIComboBox()
        Me.lblConfiguracaoColunaQuantidadeHoraExtra = New System.Windows.Forms.Label()
        Me.lblConfiguracaoColunaAssistenciaMedica = New System.Windows.Forms.Label()
        Me.grpArquivo = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtPlanilha = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.lblPlanilha = New System.Windows.Forms.Label()
        Me.txtArquivoExcel = New Janus.Windows.GridEX.EditControls.MaskedEditBox()
        Me.btnArquivoExcel = New Janus.Windows.EditControls.UIButton()
        Me.lblArquivoExcel = New System.Windows.Forms.Label()
        Me.grpFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.cboAno = New Janus.Windows.EditControls.UIComboBox()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.cboMes = New Janus.Windows.EditControls.UIComboBox()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.grdListagem = New Janus.Windows.GridEX.GridEX()
        Me.grpControle = New Janus.Windows.EditControls.UIGroupBox()
        Me.lblCongelarColuna = New System.Windows.Forms.Label()
        Me.cboCongelarColuna = New Janus.Windows.EditControls.UIComboBox()
        Me.btnExcel = New Janus.Windows.EditControls.UIButton()
        Me.btnSalvar = New Janus.Windows.EditControls.UIButton()
        Me.btnSair = New Janus.Windows.EditControls.UIButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.pagLista.SuspendLayout()
        CType(Me.grpDadosArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDadosArquivo.SuspendLayout()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArquivo.SuspendLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.tabMain.Size = New System.Drawing.Size(915, 566)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.pagLista})
        Me.tabMain.TabStop = False
        Me.tabMain.VisualStyleManager = Me.vsmMain
        '
        'pagLista
        '
        Me.pagLista.Controls.Add(Me.grpDadosArquivo)
        Me.pagLista.Controls.Add(Me.grpArquivo)
        Me.pagLista.Controls.Add(Me.grpFiltro)
        Me.pagLista.Controls.Add(Me.grdListagem)
        Me.pagLista.Controls.Add(Me.grpControle)
        Me.pagLista.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.pagLista.Key = "pagLista"
        Me.pagLista.Location = New System.Drawing.Point(1, 22)
        Me.pagLista.Name = "pagLista"
        Me.pagLista.Size = New System.Drawing.Size(913, 543)
        Me.pagLista.TabStop = True
        Me.pagLista.Text = "Funcionário - Salário / Encargos"
        '
        'grpDadosArquivo
        '
        Me.grpDadosArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpDadosArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpDadosArquivo.Controls.Add(Me.txtLinhaInicio)
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaAssistenciaMedica)
        Me.grpDadosArquivo.Controls.Add(Me.lblLinhaInicio)
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaValeRefeicao)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaValeRefeicao)
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaValeTransporte)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaValeTransporte)
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaSalario)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaSalario)
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaFGTS)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaProntuario)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaFGTS)
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaIRRF)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaIRRF)
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaProntuario)
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaValeAlimentacao)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaValeAlimentacao)
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaINSS)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaINSS)
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaDSR)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaDSR)
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaValorHoraExtra)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaValorHoraExtra)
        Me.grpDadosArquivo.Controls.Add(Me.cboConfiguracaoColunaQuantidadeHoraExtra)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaQuantidadeHoraExtra)
        Me.grpDadosArquivo.Controls.Add(Me.lblConfiguracaoColunaAssistenciaMedica)
        Me.grpDadosArquivo.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.grpDadosArquivo.Location = New System.Drawing.Point(8, 70)
        Me.grpDadosArquivo.Name = "grpDadosArquivo"
        Me.grpDadosArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpDadosArquivo.Size = New System.Drawing.Size(228, 410)
        Me.grpDadosArquivo.TabIndex = 1
        Me.grpDadosArquivo.Text = "Configuração da Planilha Excel"
        Me.grpDadosArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpDadosArquivo.VisualStyleManager = Me.vsmMain
        '
        'txtLinhaInicio
        '
        Me.txtLinhaInicio.DecimalDigits = 0
        Me.txtLinhaInicio.Location = New System.Drawing.Point(105, 331)
        Me.txtLinhaInicio.Name = "txtLinhaInicio"
        Me.txtLinhaInicio.Size = New System.Drawing.Size(115, 20)
        Me.txtLinhaInicio.TabIndex = 25
        Me.txtLinhaInicio.Text = "0"
        Me.txtLinhaInicio.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cboConfiguracaoColunaAssistenciaMedica
        '
        Me.cboConfiguracaoColunaAssistenciaMedica.AutoSize = False
        Me.cboConfiguracaoColunaAssistenciaMedica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaAssistenciaMedica.Location = New System.Drawing.Point(105, 305)
        Me.cboConfiguracaoColunaAssistenciaMedica.Name = "cboConfiguracaoColunaAssistenciaMedica"
        Me.cboConfiguracaoColunaAssistenciaMedica.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaAssistenciaMedica.Size = New System.Drawing.Size(115, 20)
        Me.cboConfiguracaoColunaAssistenciaMedica.TabIndex = 23
        '
        'lblLinhaInicio
        '
        Me.lblLinhaInicio.AutoSize = True
        Me.lblLinhaInicio.Location = New System.Drawing.Point(6, 334)
        Me.lblLinhaInicio.Name = "lblLinhaInicio"
        Me.lblLinhaInicio.Size = New System.Drawing.Size(63, 14)
        Me.lblLinhaInicio.TabIndex = 24
        Me.lblLinhaInicio.Text = "Linha Início:"
        '
        'cboConfiguracaoColunaValeRefeicao
        '
        Me.cboConfiguracaoColunaValeRefeicao.AutoSize = False
        Me.cboConfiguracaoColunaValeRefeicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaValeRefeicao.Location = New System.Drawing.Point(105, 253)
        Me.cboConfiguracaoColunaValeRefeicao.Name = "cboConfiguracaoColunaValeRefeicao"
        Me.cboConfiguracaoColunaValeRefeicao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaValeRefeicao.Size = New System.Drawing.Size(115, 20)
        Me.cboConfiguracaoColunaValeRefeicao.TabIndex = 19
        '
        'lblConfiguracaoColunaValeRefeicao
        '
        Me.lblConfiguracaoColunaValeRefeicao.AutoSize = True
        Me.lblConfiguracaoColunaValeRefeicao.Location = New System.Drawing.Point(6, 256)
        Me.lblConfiguracaoColunaValeRefeicao.Name = "lblConfiguracaoColunaValeRefeicao"
        Me.lblConfiguracaoColunaValeRefeicao.Size = New System.Drawing.Size(77, 14)
        Me.lblConfiguracaoColunaValeRefeicao.TabIndex = 18
        Me.lblConfiguracaoColunaValeRefeicao.Text = "Vale Refeição:"
        '
        'cboConfiguracaoColunaValeTransporte
        '
        Me.cboConfiguracaoColunaValeTransporte.AutoSize = False
        Me.cboConfiguracaoColunaValeTransporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaValeTransporte.Location = New System.Drawing.Point(105, 227)
        Me.cboConfiguracaoColunaValeTransporte.Name = "cboConfiguracaoColunaValeTransporte"
        Me.cboConfiguracaoColunaValeTransporte.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaValeTransporte.Size = New System.Drawing.Size(115, 20)
        Me.cboConfiguracaoColunaValeTransporte.TabIndex = 17
        '
        'lblConfiguracaoColunaValeTransporte
        '
        Me.lblConfiguracaoColunaValeTransporte.AutoSize = True
        Me.lblConfiguracaoColunaValeTransporte.Location = New System.Drawing.Point(6, 230)
        Me.lblConfiguracaoColunaValeTransporte.Name = "lblConfiguracaoColunaValeTransporte"
        Me.lblConfiguracaoColunaValeTransporte.Size = New System.Drawing.Size(87, 14)
        Me.lblConfiguracaoColunaValeTransporte.TabIndex = 16
        Me.lblConfiguracaoColunaValeTransporte.Text = "Vale Transporte:"
        '
        'cboConfiguracaoColunaSalario
        '
        Me.cboConfiguracaoColunaSalario.AutoSize = False
        Me.cboConfiguracaoColunaSalario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaSalario.Location = New System.Drawing.Point(105, 45)
        Me.cboConfiguracaoColunaSalario.Name = "cboConfiguracaoColunaSalario"
        Me.cboConfiguracaoColunaSalario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaSalario.Size = New System.Drawing.Size(115, 20)
        Me.cboConfiguracaoColunaSalario.TabIndex = 3
        '
        'lblConfiguracaoColunaSalario
        '
        Me.lblConfiguracaoColunaSalario.AutoSize = True
        Me.lblConfiguracaoColunaSalario.Location = New System.Drawing.Point(6, 48)
        Me.lblConfiguracaoColunaSalario.Name = "lblConfiguracaoColunaSalario"
        Me.lblConfiguracaoColunaSalario.Size = New System.Drawing.Size(43, 14)
        Me.lblConfiguracaoColunaSalario.TabIndex = 2
        Me.lblConfiguracaoColunaSalario.Text = "Salário:"
        '
        'cboConfiguracaoColunaFGTS
        '
        Me.cboConfiguracaoColunaFGTS.AutoSize = False
        Me.cboConfiguracaoColunaFGTS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaFGTS.Location = New System.Drawing.Point(105, 201)
        Me.cboConfiguracaoColunaFGTS.Name = "cboConfiguracaoColunaFGTS"
        Me.cboConfiguracaoColunaFGTS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaFGTS.Size = New System.Drawing.Size(115, 20)
        Me.cboConfiguracaoColunaFGTS.TabIndex = 15
        '
        'lblConfiguracaoColunaProntuario
        '
        Me.lblConfiguracaoColunaProntuario.AutoSize = True
        Me.lblConfiguracaoColunaProntuario.Location = New System.Drawing.Point(6, 22)
        Me.lblConfiguracaoColunaProntuario.Name = "lblConfiguracaoColunaProntuario"
        Me.lblConfiguracaoColunaProntuario.Size = New System.Drawing.Size(59, 14)
        Me.lblConfiguracaoColunaProntuario.TabIndex = 0
        Me.lblConfiguracaoColunaProntuario.Text = "Prontuário:"
        '
        'lblConfiguracaoColunaFGTS
        '
        Me.lblConfiguracaoColunaFGTS.AutoSize = True
        Me.lblConfiguracaoColunaFGTS.Location = New System.Drawing.Point(6, 204)
        Me.lblConfiguracaoColunaFGTS.Name = "lblConfiguracaoColunaFGTS"
        Me.lblConfiguracaoColunaFGTS.Size = New System.Drawing.Size(37, 14)
        Me.lblConfiguracaoColunaFGTS.TabIndex = 14
        Me.lblConfiguracaoColunaFGTS.Text = "FGTS:"
        '
        'cboConfiguracaoColunaIRRF
        '
        Me.cboConfiguracaoColunaIRRF.AutoSize = False
        Me.cboConfiguracaoColunaIRRF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaIRRF.Location = New System.Drawing.Point(105, 175)
        Me.cboConfiguracaoColunaIRRF.Name = "cboConfiguracaoColunaIRRF"
        Me.cboConfiguracaoColunaIRRF.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaIRRF.Size = New System.Drawing.Size(115, 20)
        Me.cboConfiguracaoColunaIRRF.TabIndex = 13
        '
        'lblConfiguracaoColunaIRRF
        '
        Me.lblConfiguracaoColunaIRRF.AutoSize = True
        Me.lblConfiguracaoColunaIRRF.Location = New System.Drawing.Point(6, 178)
        Me.lblConfiguracaoColunaIRRF.Name = "lblConfiguracaoColunaIRRF"
        Me.lblConfiguracaoColunaIRRF.Size = New System.Drawing.Size(32, 14)
        Me.lblConfiguracaoColunaIRRF.TabIndex = 12
        Me.lblConfiguracaoColunaIRRF.Text = "IRRF:"
        '
        'cboConfiguracaoColunaProntuario
        '
        Me.cboConfiguracaoColunaProntuario.AutoSize = False
        Me.cboConfiguracaoColunaProntuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaProntuario.Location = New System.Drawing.Point(105, 19)
        Me.cboConfiguracaoColunaProntuario.Name = "cboConfiguracaoColunaProntuario"
        Me.cboConfiguracaoColunaProntuario.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaProntuario.Size = New System.Drawing.Size(115, 20)
        Me.cboConfiguracaoColunaProntuario.TabIndex = 1
        '
        'cboConfiguracaoColunaValeAlimentacao
        '
        Me.cboConfiguracaoColunaValeAlimentacao.AutoSize = False
        Me.cboConfiguracaoColunaValeAlimentacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaValeAlimentacao.Location = New System.Drawing.Point(105, 279)
        Me.cboConfiguracaoColunaValeAlimentacao.Name = "cboConfiguracaoColunaValeAlimentacao"
        Me.cboConfiguracaoColunaValeAlimentacao.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaValeAlimentacao.Size = New System.Drawing.Size(115, 20)
        Me.cboConfiguracaoColunaValeAlimentacao.TabIndex = 21
        '
        'lblConfiguracaoColunaValeAlimentacao
        '
        Me.lblConfiguracaoColunaValeAlimentacao.AutoSize = True
        Me.lblConfiguracaoColunaValeAlimentacao.Location = New System.Drawing.Point(6, 282)
        Me.lblConfiguracaoColunaValeAlimentacao.Name = "lblConfiguracaoColunaValeAlimentacao"
        Me.lblConfiguracaoColunaValeAlimentacao.Size = New System.Drawing.Size(92, 14)
        Me.lblConfiguracaoColunaValeAlimentacao.TabIndex = 20
        Me.lblConfiguracaoColunaValeAlimentacao.Text = "Vale Alimentação:"
        '
        'cboConfiguracaoColunaINSS
        '
        Me.cboConfiguracaoColunaINSS.AutoSize = False
        Me.cboConfiguracaoColunaINSS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaINSS.Location = New System.Drawing.Point(105, 149)
        Me.cboConfiguracaoColunaINSS.Name = "cboConfiguracaoColunaINSS"
        Me.cboConfiguracaoColunaINSS.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaINSS.Size = New System.Drawing.Size(115, 20)
        Me.cboConfiguracaoColunaINSS.TabIndex = 11
        '
        'lblConfiguracaoColunaINSS
        '
        Me.lblConfiguracaoColunaINSS.AutoSize = True
        Me.lblConfiguracaoColunaINSS.Location = New System.Drawing.Point(6, 152)
        Me.lblConfiguracaoColunaINSS.Name = "lblConfiguracaoColunaINSS"
        Me.lblConfiguracaoColunaINSS.Size = New System.Drawing.Size(33, 14)
        Me.lblConfiguracaoColunaINSS.TabIndex = 10
        Me.lblConfiguracaoColunaINSS.Text = "INSS:"
        '
        'cboConfiguracaoColunaDSR
        '
        Me.cboConfiguracaoColunaDSR.AutoSize = False
        Me.cboConfiguracaoColunaDSR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaDSR.Location = New System.Drawing.Point(105, 123)
        Me.cboConfiguracaoColunaDSR.Name = "cboConfiguracaoColunaDSR"
        Me.cboConfiguracaoColunaDSR.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaDSR.Size = New System.Drawing.Size(115, 20)
        Me.cboConfiguracaoColunaDSR.TabIndex = 9
        '
        'lblConfiguracaoColunaDSR
        '
        Me.lblConfiguracaoColunaDSR.AutoSize = True
        Me.lblConfiguracaoColunaDSR.Location = New System.Drawing.Point(6, 126)
        Me.lblConfiguracaoColunaDSR.Name = "lblConfiguracaoColunaDSR"
        Me.lblConfiguracaoColunaDSR.Size = New System.Drawing.Size(31, 14)
        Me.lblConfiguracaoColunaDSR.TabIndex = 8
        Me.lblConfiguracaoColunaDSR.Text = "DSR:"
        '
        'cboConfiguracaoColunaValorHoraExtra
        '
        Me.cboConfiguracaoColunaValorHoraExtra.AutoSize = False
        Me.cboConfiguracaoColunaValorHoraExtra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaValorHoraExtra.Location = New System.Drawing.Point(105, 97)
        Me.cboConfiguracaoColunaValorHoraExtra.Name = "cboConfiguracaoColunaValorHoraExtra"
        Me.cboConfiguracaoColunaValorHoraExtra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaValorHoraExtra.Size = New System.Drawing.Size(115, 20)
        Me.cboConfiguracaoColunaValorHoraExtra.TabIndex = 7
        '
        'lblConfiguracaoColunaValorHoraExtra
        '
        Me.lblConfiguracaoColunaValorHoraExtra.AutoSize = True
        Me.lblConfiguracaoColunaValorHoraExtra.Location = New System.Drawing.Point(6, 100)
        Me.lblConfiguracaoColunaValorHoraExtra.Name = "lblConfiguracaoColunaValorHoraExtra"
        Me.lblConfiguracaoColunaValorHoraExtra.Size = New System.Drawing.Size(89, 14)
        Me.lblConfiguracaoColunaValorHoraExtra.TabIndex = 6
        Me.lblConfiguracaoColunaValorHoraExtra.Text = "Valor Hora Extra:"
        '
        'cboConfiguracaoColunaQuantidadeHoraExtra
        '
        Me.cboConfiguracaoColunaQuantidadeHoraExtra.AutoSize = False
        Me.cboConfiguracaoColunaQuantidadeHoraExtra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboConfiguracaoColunaQuantidadeHoraExtra.Location = New System.Drawing.Point(105, 71)
        Me.cboConfiguracaoColunaQuantidadeHoraExtra.Name = "cboConfiguracaoColunaQuantidadeHoraExtra"
        Me.cboConfiguracaoColunaQuantidadeHoraExtra.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboConfiguracaoColunaQuantidadeHoraExtra.Size = New System.Drawing.Size(115, 20)
        Me.cboConfiguracaoColunaQuantidadeHoraExtra.TabIndex = 5
        '
        'lblConfiguracaoColunaQuantidadeHoraExtra
        '
        Me.lblConfiguracaoColunaQuantidadeHoraExtra.AutoSize = True
        Me.lblConfiguracaoColunaQuantidadeHoraExtra.Location = New System.Drawing.Point(6, 74)
        Me.lblConfiguracaoColunaQuantidadeHoraExtra.Name = "lblConfiguracaoColunaQuantidadeHoraExtra"
        Me.lblConfiguracaoColunaQuantidadeHoraExtra.Size = New System.Drawing.Size(90, 14)
        Me.lblConfiguracaoColunaQuantidadeHoraExtra.TabIndex = 4
        Me.lblConfiguracaoColunaQuantidadeHoraExtra.Text = "Qtde. Hora Extra:"
        '
        'lblConfiguracaoColunaAssistenciaMedica
        '
        Me.lblConfiguracaoColunaAssistenciaMedica.AutoSize = True
        Me.lblConfiguracaoColunaAssistenciaMedica.Location = New System.Drawing.Point(6, 308)
        Me.lblConfiguracaoColunaAssistenciaMedica.Name = "lblConfiguracaoColunaAssistenciaMedica"
        Me.lblConfiguracaoColunaAssistenciaMedica.Size = New System.Drawing.Size(81, 14)
        Me.lblConfiguracaoColunaAssistenciaMedica.TabIndex = 22
        Me.lblConfiguracaoColunaAssistenciaMedica.Text = "Assist. Médica:"
        '
        'grpArquivo
        '
        Me.grpArquivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpArquivo.BackColor = System.Drawing.Color.Transparent
        Me.grpArquivo.Controls.Add(Me.txtPlanilha)
        Me.grpArquivo.Controls.Add(Me.lblPlanilha)
        Me.grpArquivo.Controls.Add(Me.txtArquivoExcel)
        Me.grpArquivo.Controls.Add(Me.btnArquivoExcel)
        Me.grpArquivo.Controls.Add(Me.lblArquivoExcel)
        Me.grpArquivo.Location = New System.Drawing.Point(245, 70)
        Me.grpArquivo.Name = "grpArquivo"
        Me.grpArquivo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpArquivo.Size = New System.Drawing.Size(660, 64)
        Me.grpArquivo.TabIndex = 2
        Me.grpArquivo.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpArquivo.VisualStyleManager = Me.vsmMain
        '
        'txtPlanilha
        '
        Me.txtPlanilha.Location = New System.Drawing.Point(9, 34)
        Me.txtPlanilha.MaxLength = 35
        Me.txtPlanilha.Name = "txtPlanilha"
        Me.txtPlanilha.Size = New System.Drawing.Size(132, 20)
        Me.txtPlanilha.TabIndex = 1
        '
        'lblPlanilha
        '
        Me.lblPlanilha.AutoSize = True
        Me.lblPlanilha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPlanilha.Location = New System.Drawing.Point(6, 17)
        Me.lblPlanilha.Name = "lblPlanilha"
        Me.lblPlanilha.Size = New System.Drawing.Size(46, 14)
        Me.lblPlanilha.TabIndex = 0
        Me.lblPlanilha.Text = "Planilha:"
        '
        'txtArquivoExcel
        '
        Me.txtArquivoExcel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArquivoExcel.BackColor = System.Drawing.SystemColors.Info
        Me.txtArquivoExcel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArquivoExcel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArquivoExcel.Location = New System.Drawing.Point(147, 34)
        Me.txtArquivoExcel.MaxLength = 50
        Me.txtArquivoExcel.Name = "txtArquivoExcel"
        Me.txtArquivoExcel.ReadOnly = True
        Me.txtArquivoExcel.Size = New System.Drawing.Size(482, 20)
        Me.txtArquivoExcel.TabIndex = 3
        Me.txtArquivoExcel.TabStop = False
        '
        'btnArquivoExcel
        '
        Me.btnArquivoExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivoExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnArquivoExcel.ImageSize = New System.Drawing.Size(13, 16)
        Me.btnArquivoExcel.Location = New System.Drawing.Point(628, 34)
        Me.btnArquivoExcel.Name = "btnArquivoExcel"
        Me.btnArquivoExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnArquivoExcel.Size = New System.Drawing.Size(23, 20)
        Me.btnArquivoExcel.TabIndex = 4
        Me.btnArquivoExcel.Text = "..."
        Me.btnArquivoExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'lblArquivoExcel
        '
        Me.lblArquivoExcel.AutoSize = True
        Me.lblArquivoExcel.Location = New System.Drawing.Point(144, 17)
        Me.lblArquivoExcel.Name = "lblArquivoExcel"
        Me.lblArquivoExcel.Size = New System.Drawing.Size(77, 14)
        Me.lblArquivoExcel.TabIndex = 2
        Me.lblArquivoExcel.Text = "Arquivo Excel:"
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltro.Controls.Add(Me.cboAno)
        Me.grpFiltro.Controls.Add(Me.lblAno)
        Me.grpFiltro.Controls.Add(Me.cboMes)
        Me.grpFiltro.Controls.Add(Me.lblMes)
        Me.grpFiltro.Location = New System.Drawing.Point(8, 3)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpFiltro.Size = New System.Drawing.Size(897, 64)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.grpFiltro.VisualStyleManager = Me.vsmMain
        '
        'cboAno
        '
        Me.cboAno.AutoSize = False
        Me.cboAno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboAno.Location = New System.Drawing.Point(130, 34)
        Me.cboAno.Name = "cboAno"
        Me.cboAno.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboAno.Size = New System.Drawing.Size(115, 20)
        Me.cboAno.TabIndex = 3
        '
        'lblAno
        '
        Me.lblAno.AutoSize = True
        Me.lblAno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAno.Location = New System.Drawing.Point(127, 17)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(30, 14)
        Me.lblAno.TabIndex = 2
        Me.lblAno.Text = "Ano:"
        '
        'cboMes
        '
        Me.cboMes.AutoSize = False
        Me.cboMes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMes.Location = New System.Drawing.Point(9, 34)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboMes.Size = New System.Drawing.Size(115, 20)
        Me.cboMes.TabIndex = 1
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMes.Location = New System.Drawing.Point(6, 17)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(30, 14)
        Me.lblMes.TabIndex = 0
        Me.lblMes.Text = "Mês:"
        '
        'grdListagem
        '
        Me.grdListagem.AlternatingColors = True
        Me.grdListagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        grdListagem_DesignTimeLayout.LayoutString = resources.GetString("grdListagem_DesignTimeLayout.LayoutString")
        Me.grdListagem.DesignTimeLayout = grdListagem_DesignTimeLayout
        Me.grdListagem.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdListagem.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Info
        Me.grdListagem.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.grdListagem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.grdListagem.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.grdListagem.GroupByBoxVisible = False
        Me.grdListagem.Location = New System.Drawing.Point(245, 143)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.grdListagem.RecordNavigator = True
        Me.grdListagem.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty
        Me.grdListagem.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.grdListagem.Size = New System.Drawing.Size(660, 337)
        Me.grdListagem.TabIndex = 3
        Me.grdListagem.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        Me.grdListagem.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grdListagem.TotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.grdListagem.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.grdListagem.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdListagem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grdListagem.VisualStyleManager = Me.vsmMain
        '
        'grpControle
        '
        Me.grpControle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpControle.BackColor = System.Drawing.Color.Transparent
        Me.grpControle.Controls.Add(Me.lblCongelarColuna)
        Me.grpControle.Controls.Add(Me.cboCongelarColuna)
        Me.grpControle.Controls.Add(Me.btnExcel)
        Me.grpControle.Controls.Add(Me.btnSalvar)
        Me.grpControle.Controls.Add(Me.btnSair)
        Me.grpControle.Location = New System.Drawing.Point(8, 483)
        Me.grpControle.Name = "grpControle"
        Me.grpControle.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.grpControle.Size = New System.Drawing.Size(897, 51)
        Me.grpControle.TabIndex = 4
        Me.grpControle.VisualStyleManager = Me.vsmMain
        '
        'lblCongelarColuna
        '
        Me.lblCongelarColuna.AutoSize = True
        Me.lblCongelarColuna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCongelarColuna.Location = New System.Drawing.Point(6, 21)
        Me.lblCongelarColuna.Name = "lblCongelarColuna"
        Me.lblCongelarColuna.Size = New System.Drawing.Size(89, 14)
        Me.lblCongelarColuna.TabIndex = 3
        Me.lblCongelarColuna.Text = "Congelar Coluna:"
        '
        'cboCongelarColuna
        '
        Me.cboCongelarColuna.AutoSize = False
        Me.cboCongelarColuna.Location = New System.Drawing.Point(101, 18)
        Me.cboCongelarColuna.Name = "cboCongelarColuna"
        Me.cboCongelarColuna.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.cboCongelarColuna.Size = New System.Drawing.Size(151, 20)
        Me.cboCongelarColuna.TabIndex = 4
        Me.cboCongelarColuna.TabStop = False
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.INTERACTI.My.Resources.excel
        Me.btnExcel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnExcel.Location = New System.Drawing.Point(603, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnExcel.Size = New System.Drawing.Size(91, 23)
        Me.btnExcel.TabIndex = 0
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.INTERACTI.My.Resources.salvar
        Me.btnSalvar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSalvar.ImageSize = New System.Drawing.Size(14, 14)
        Me.btnSalvar.Location = New System.Drawing.Point(700, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSalvar.Size = New System.Drawing.Size(91, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.btnSair.ImageSize = New System.Drawing.Size(19, 16)
        Me.btnSair.Location = New System.Drawing.Point(797, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver
        Me.btnSair.Size = New System.Drawing.Size(91, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005
        '
        'usrCustFuncionarioSalario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Name = "usrCustFuncionarioSalario"
        Me.Size = New System.Drawing.Size(915, 566)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.pagLista.ResumeLayout(False)
        CType(Me.grpDadosArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDadosArquivo.ResumeLayout(False)
        Me.grpDadosArquivo.PerformLayout()
        CType(Me.grpArquivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArquivo.ResumeLayout(False)
        Me.grpArquivo.PerformLayout()
        CType(Me.grpFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpControle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControle.ResumeLayout(False)
        Me.grpControle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
    Friend WithEvents pagLista As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents grpControle As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSair As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSalvar As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdListagem As Janus.Windows.GridEX.GridEX
    Friend WithEvents grpFiltro As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboMes As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents cboAno As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblAno As System.Windows.Forms.Label
    Friend WithEvents cboConfiguracaoColunaProntuario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblConfiguracaoColunaProntuario As System.Windows.Forms.Label
    Friend WithEvents txtLinhaInicio As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents lblLinhaInicio As System.Windows.Forms.Label
    Friend WithEvents lblArquivoExcel As System.Windows.Forms.Label
    Friend WithEvents txtArquivoExcel As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Private WithEvents btnArquivoExcel As Janus.Windows.EditControls.UIButton
    Friend WithEvents cboConfiguracaoColunaSalario As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblConfiguracaoColunaSalario As System.Windows.Forms.Label
    Friend WithEvents grpArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grpDadosArquivo As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents cboConfiguracaoColunaAssistenciaMedica As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents cboConfiguracaoColunaValeRefeicao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblConfiguracaoColunaValeRefeicao As System.Windows.Forms.Label
    Friend WithEvents cboConfiguracaoColunaValeTransporte As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblConfiguracaoColunaValeTransporte As System.Windows.Forms.Label
    Friend WithEvents cboConfiguracaoColunaFGTS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblConfiguracaoColunaFGTS As System.Windows.Forms.Label
    Friend WithEvents cboConfiguracaoColunaIRRF As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblConfiguracaoColunaIRRF As System.Windows.Forms.Label
    Friend WithEvents cboConfiguracaoColunaValeAlimentacao As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblConfiguracaoColunaValeAlimentacao As System.Windows.Forms.Label
    Friend WithEvents cboConfiguracaoColunaINSS As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblConfiguracaoColunaINSS As System.Windows.Forms.Label
    Friend WithEvents cboConfiguracaoColunaDSR As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblConfiguracaoColunaDSR As System.Windows.Forms.Label
    Friend WithEvents cboConfiguracaoColunaValorHoraExtra As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblConfiguracaoColunaValorHoraExtra As System.Windows.Forms.Label
    Friend WithEvents cboConfiguracaoColunaQuantidadeHoraExtra As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblConfiguracaoColunaQuantidadeHoraExtra As System.Windows.Forms.Label
    Friend WithEvents lblConfiguracaoColunaAssistenciaMedica As System.Windows.Forms.Label
    Friend WithEvents txtPlanilha As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lblPlanilha As System.Windows.Forms.Label
    Friend WithEvents lblCongelarColuna As System.Windows.Forms.Label
    Friend WithEvents cboCongelarColuna As Janus.Windows.EditControls.UIComboBox

End Class
