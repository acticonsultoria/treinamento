Imports Janus.Windows.UI.Tab
Imports System.Threading
Imports System.Reflection
Imports System.Reflection.Assembly
Imports System.Drawing
Imports System.IO

Public Class frmMain

#Region "::: VARIAVEIS :::"

    'Variaveis Locais
    Private oClsFrmMain As New clsFrmMain
    Private oClsConfigXML As clsConfigXML

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'Verifica se o Usuário deseja sair da Aplicação
        If MsgBox("Deseja sair da Aplicação?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.No Then
            'Cancela Operação
            e.Cancel = True
        End If

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call ConfigurarFormulario()

    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            'Verifica se o Usuário autenticou no sistema
            If goUsuario.sUsuario = "" Then Exit Sub

            'Verifica se o Sistema Libera Tecla de Atalho
            If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'tecla_atalho'"), Boolean) = False Then Exit Sub

            Select Case e.KeyCode

                Case Keys.F4

                    'Verifica se o Usuário tem Direito
                    If VerificaDireito(Formulario.ComercialPDV, gcSelect) = True Then
                        'Limpa Erro
                        Me.errInfo.Clear()
                        'Variaveis Locais
                        Dim oUsrControl As UserControl
                        Dim oAssembly As Assembly = GetExecutingAssembly()
                        oUsrControl = oAssembly.CreateInstance("INTERACTI." & "usrVenPDV")
                        Call ConfigureMaskEdit(oUsrControl) : Call LoadControlesTraducao(oUsrControl)
                        Call Me.LoadPage("usrVenPDV", "Comercial - PDV", oUsrControl)
                    End If


                Case Keys.F7

                    'Verifica se o Usuário tem Direito
                    If VerificaDireito(Formulario.CadastroBasicoProdutoPrecoVenda, gcSelect) = True Then
                        'Limpa Erro
                        Me.errInfo.Clear()
                        'Variaveis Locais
                        Dim oUsrControl As UserControl
                        Dim oAssembly As Assembly = GetExecutingAssembly()
                        oUsrControl = oAssembly.CreateInstance("INTERACTI." & "usrCadProdutoPrecoVenda")
                        Call ConfigureMaskEdit(oUsrControl) : Call LoadControlesTraducao(oUsrControl)
                        Call Me.LoadPage("usrCadProdutoPrecoVenda", "Comercial - Cadastro Básicos - Produto - Preço de Venda", oUsrControl)
                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub tabMain_TabClosed(ByVal sender As Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabMain.TabClosed

        'Libera da Memória a Página Aberta
        tabMain.TabPages.Remove(e.Page)
        e.Page.Dispose()

    End Sub

    Private Sub tmrHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrHora.Tick

        'Atualiza Hora do Sistema
        stbMain.Panels("pnlDataHora").Text = Now

        'If bMensagem = True Then
        '    oToolStripItem.Image = IIf(oToolStripItem.Image Is Nothing, Global.INTERACTI.My.Resources.logo_interacti, Nothing)
        'End If

    End Sub

    Private Sub stbMain_PanelClick(sender As Object, e As Janus.Windows.UI.StatusBar.StatusBarEventArgs) Handles stbMain.PanelClick

        Try

            'Verifica Botão Clicado
            If e.Panel.Key.ToString = goUsuario.iIdioma.ToString Then Exit Sub

            Select Case e.Panel.Key

                Case "pnlFuncaoCalculadora" : Process.Start("calc.exe")

                Case CInt(Idioma.Portugues), CInt(Idioma.Ingles), CInt(Idioma.Espanhol)

                    'Seta Idioma do Usuário
                    goUsuario.iIdioma = e.Panel.Key

                    'Atualiza Dados
                    Call ExecuteQuery("EXECUTE sp_update_administracao_usuario_idioma " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario & ", " & e.Panel.Key)

                    'Carrega Idioma
                    Call oClsFrmMain.LoadMenu(mnuMain)

                    'Carrega Idioma (Formulários Abertos)
                    For Each oPage As UITabPage In tabMain.TabPages
                        If oPage.Name.Substring(0, 3) = "usr" Then
                            Dim oControl As Control = oPage.Controls.Find(oPage.Name, True)(0)
                            Call LoadControlesTraducao(oControl)
                        End If
                    Next

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub tmrAviso_Tick(sender As Object, e As EventArgs) Handles tmrAviso.Tick

        Try

            VerificarAviso()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub tmrBaseTeste_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBaseTeste.Tick

        Try

            If stbMain.Panels("pnlEmpresa").Text.Contains("BASE TESTE") Then

                'Habilita Label e Seta Cor
                lblInformativo.Text = "BASE TESTE"
                lblInformativo.Enabled = True : lblInformativo.Visible = True
                lblInformativo.ForeColor = IIf(lblInformativo.ForeColor = Color.Red, Color.Black, Color.Red)

                Application.DoEvents()
            Else

                'Desabilita label
                lblInformativo.Enabled = False : lblInformativo.Visible = False

            End If



        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub ConfigurarFormulario()

        Try

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmMain_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            If gSistema = "AGROACTI" Then
                gAplicacao = "AGROACTi - Sistemas Integrados de Gestão Agrônoma"
                Me.Icon = My.Resources.agroacti_ico
                pagPrincipal.Icon = My.Resources.agroacti_ico
            ElseIf gSistema = "INTERACTI" Then
                gAplicacao = "INTERACTi - Sistemas Integrados de Gestão Empresarial"
                Me.Icon = My.Resources.interacti_ico
                pagPrincipal.Icon = My.Resources.interacti_ico
            End If

1:          'Verifica se Existe o Arquivo Config.xml
            If File.Exists(ApplicationPath() & "XmlConfig\Config.xml") = False Then
                If MsgBox("Arquivo de Configuração do Banco de Dados não foi encontrado. Deseja gerar Arquivo?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, gAplicacao) = MsgBoxResult.Yes Then
                    Dim oForm As New frmAdmConfigXML
                    'Abre Formulário
                    oForm.ShowDialog(Me)
                    GoTo 1
                Else
                    'Fecha a Aplicação
                    End
                End If
            Else
                oClsConfigXML = New clsConfigXML
            End If

            'Carrega Dados do XML
            goDatabase.sConnection = oClsConfigXML.StringConnection
            goDatabase.sDataSource = oClsConfigXML.DataSource
            goDatabase.sInitialCatalog = oClsConfigXML.InitialCatalog
            goDatabase.sUserID = oClsConfigXML.UserID
            goDatabase.sPassword = oClsConfigXML.Password
            goCrystalReport.sPath = oClsConfigXML.ReportPath

            'Testa Conexão
            If TesteConection(goDatabase.sConnection) = False Then
                'Abre Formulário de Configuração
                Dim oForm As New frmAdmConfigXML
                oForm.ShowDialog(Me)
                GoTo 1
            End If

            'Seta Label
            Me.Text = gAplicacao & " Versão: " & Application.ProductVersion.ToString

            'Deixa invisível a mensagem da base teste
            lblInformativo.Visible = False

            'Abre Formulário de Login
            frmLogin.ShowDialog()

            'Verifica se foi autenticado algum usuário
            If IsNothing(goUsuario.sUsuario) Then End

            Try
                'Valida licença de API, na plataforma
                gLicencaAPIValida = ValidaLicencaAPI()
            Catch ex As Exception
                gLicencaAPIValida = True
            End Try

            'Habilita Timer
            tmrHora.Enabled = True
            tmrBaseTeste.Enabled = True

            'Carrega Página Principal
            Select Case gSistema
                Case "AGROACTI" : picImage.Image = New Bitmap(ApplicationPath() & "XMLConfig\AGROACTI.jpg")
                Case "INTERACTI" : picImage.Image = New Bitmap(ApplicationPath() & "XMLConfig\logo.bmp")
            End Select


            tmrAviso.Enabled = True
            tmrAviso.Interval = 600000

            'Habilita Painel
            stbMain.Panels("pnlEmpresa").Visible = True
            stbMain.Panels("pnlUsuario").Visible = True
            stbMain.Panels("pnlDataHora").Visible = True
            stbMain.Panels("pnlFuncaoCalculadora").Visible = True

            If goUsuario.iUsuario = 1 Then
                'Carrega Idioma
                oClsFrmMain.LoadBarraIdioma(stbMain)
            End If

            'Carrega Tela Inicial
            oClsFrmMain.LoadTelaInicial()

            picImage.Visible = True
            'picLogo.Visible = True

            'Try
            '    If VerificaDireito(Formulario.FinanceiroDespesaLancamento, gcSelect) = True Then
            '        Dim oClsFrmIntAvisoNFeDestinada As New clsFrmFinAvisoTituloAtraso
            '        If oClsFrmIntAvisoNFeDestinada.Validate() = True And goUsuario.iUsuario <> 1 Then
            '            Dim oFrmFatAvisoNFeDestinada As New frmFinAvisoTituloAtraso
            '            oFrmFatAvisoNFeDestinada.ShowDialog()
            '        End If
            '    End If
            'Catch ex As Exception

            'End Try

            Try
                If VerificaDireito(Formulario.EstoqueRequisicaoPagarMultiplo, gcAdministrator) = True Then
                    Dim oClsFrmAvisoEstoqueAprovacaoRequisicao As New clsAvisoEstoqueAprovacaoRequisicao
                    Dim oFrmAvisoEstoqueAprovacaoRequisicao As New frmAvisoEstoqueAprovacaoRequisicao

                    oFrmAvisoEstoqueAprovacaoRequisicao.ShowDialog()

                End If

            Catch ex As Exception
                Call TratamentoErro(ex.Message, Me.Text)
            End Try

            Try
                If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcAdministrator) = True Then
                    Dim oClsFrmAvisoFaturamentoOPsPendentes As New clsFrmAvisoFaturamentoOPsPendentes
                    Dim oFrmAvisoFaturamentoOPsPendentes As New frmAvisoFaturamentoOPsPendentes

                    oFrmAvisoFaturamentoOPsPendentes.ShowDialog()

                End If

            Catch ex As Exception
                Call TratamentoErro(ex.Message, Me.Text)
            End Try

            Try
                Call UpdateCotacaoBCB(Moeda.Euro)
            Catch ex As Exception

            End Try
            Try
                Call UpdateCotacaoBCB(Moeda.Dolar)
            Catch ex As Exception

            End Try

            If goUsuario.iUsuario <> 1 Then
                'Verifica Versão do Aplicativo
                Call oClsFrmMain.VerificaVersaoAplicativo()

            End If

            oClsFrmMain.EmailFinanceiroAvisoPrazo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function ControleLicencaInteracti() As Boolean

        Try

            'Seta Retorno
            ControleLicencaInteracti = False

            'Valida Licença
            If IsDate(goUsuario.sDataValidacao) = False Then
                Dim oForm As New frmAdmControleLicenca
                'Configura Mascara
                Call ConfigureMaskEdit(oForm)
                'Configura Tradução
                Call LoadControlesTraducao(oForm)
                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)
                If DateAdd(DateInterval.Day, 7, CDate(goUsuario.sDataValidade)) < Now.Date Then
                    Exit Function
                End If
            Else
                If CDate(goUsuario.sDataValidacao) > Now.Date Or _
                    CDate(goUsuario.sDataUltimoAcesso) > Now.Date Then
                    'Informa o Usuário da Conduta Ilegal
                    MsgBox("Foi detectado um erro de Licença no Interacti." & vbCrLf & "Favor contatar a ACTi através do e-mail suporte@acticonsultoria.com.br.", MsgBoxStyle.Critical, Me.Text)
                    Exit Function
                ElseIf DateAdd(DateInterval.Day, 7, CDate(goUsuario.sDataValidade)) < Now.Date Then
                    'Informa o Usuário sobre a expiração da Licença
                    MsgBox("Sua Licença expirou." & vbCrLf & "Favor contatar a ACTi através do e-mail suporte@acticonsultoria.com.br.", MsgBoxStyle.Critical, Me.Text)
                    Dim oForm As New frmAdmControleLicenca
                    'Configura Mascara
                    Call ConfigureMaskEdit(oForm)
                    'Configura Tradução
                    Call LoadControlesTraducao(oForm)
                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)
                    If DateAdd(DateInterval.Day, 7, CDate(goUsuario.sDataValidade)) < Now.Date Then
                        Exit Function
                    End If
                ElseIf CDate(goUsuario.sDataValidade) < Now.Date Then
                    'Informa o Usuárioobre a expiração da Licença
                    MsgBox("Sua Licença irá espirar em " & DateDiff(DateInterval.Day, CDate(goUsuario.sDataValidade), DateAdd(DateInterval.Day, 7, CDate(goUsuario.sDataValidade))) & " dia(s)." & vbCrLf & "Favor contatar a ACTi através do e-mail suporte@acticonsultoria.com.br.", MsgBoxStyle.Critical, Me.Text)
                End If
            End If

            'Seta Retorno
            ControleLicencaInteracti = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Function

    Private Sub AtualizaLicencaAPI()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Preparação das Váriaveis
            Dim sPassword As String = gcKeyAPI & Replace(Replace(Replace(goUsuario.sCNPJEmpresa, ".", ""), "/", ""), "-", "")
            Dim oClsFrmAdmLicenca As New clsFrmAdmControleLicenca

            oClsFrmAdmLicenca.DataValidacao = EncryptAPI(goUsuario.sDataValidacaoAPI, sPassword)
            oClsFrmAdmLicenca.DataValidade = EncryptAPI(goUsuario.sDataValidadeAPI, sPassword)
            oClsFrmAdmLicenca.NumeroLicenca = EncryptAPI(goUsuario.iNumeroLicencaAPI, sPassword)
            oClsFrmAdmLicenca.Tolerancia = EncryptAPI(goUsuario.iToleranciaAPI, sPassword)
            oClsFrmAdmLicenca.Tipo = TipoControleLicenca.API

            'Atualiza os dados da Licença
            oClsFrmAdmLicenca.Update()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function ControleLicencaAPI() As Boolean

        Try
            'Seta Retorno
            ControleLicencaAPI = False

            'Valida Licença - Primeiro Verifica se existe Data Validação Informada 
            'Se não existir, o sistema irá consultar a API e pegar a licença
            If IsDate(goUsuario.sDataValidacaoAPI) = False Then

                'Realiza Consulta da Licença através da API
                If ConsultarLicencaAPI(goUsuario.sCNPJEmpresa) = True Then

                    'Verifica se a Data Validade + Tolerância é maior que Hoje
                    If DateAdd(DateInterval.Day, IIf(IsNumeric(goUsuario.iToleranciaAPI), goUsuario.iToleranciaAPI, 7), CDate(goUsuario.sDataValidadeAPI)) >= Now.Date Then

                        'Atualiza Dados 
                        AtualizaLicencaAPI()

                    Else
                        'Verifica a data de validade da Licença Desktop - Onde a tolerância são 7 dias
                        If DateAdd(DateInterval.Day, 7, CDate(goUsuario.sDataValidade)) < Now.Date Then
                            'Informa o Usuário sobre a expiração da Licença
                            MsgBox("Sua Licença expirou." & vbCrLf & "Favor contatar a ACTi através do e-mail suporte@acticonsultoria.com.br.", MsgBoxStyle.Critical, Me.Text)

                        Else

                            'Verifica se a Licença está no período de tolerância
                            If CDate(goUsuario.sDataValidadeAPI) < Now.Date Then
                                'Informa o Usuárioobre a expiração da Licença
                                MsgBox("Sua Licença irá espirar em " & DateDiff(DateInterval.Day, CDate(goUsuario.sDataValidadeAPI), DateAdd(DateInterval.Day, IIf(IsNumeric(goUsuario.iToleranciaAPI), goUsuario.iToleranciaAPI, 7), CDate(goUsuario.sDataValidadeAPI))) & " dia(s)." & vbCrLf & "Favor contatar a ACTi através do e-mail suporte@acticonsultoria.com.br.", MsgBoxStyle.Critical, Me.Text)
                            End If

                        End If

                        'Fecha Função
                        Exit Function

                    End If

                Else
                    'Fecha Função
                    Exit Function
                End If

            Else

                'Caso o sistema já tenha importado a licença pela API ele fará as validações
                'Primeiro - Verifica se a Data Validade + Tolerância é menor que a data de hoje
                'Se for - O sistema consulta a API para verificar se já possui nova licença com data de validade atualizada
                If DateAdd(DateInterval.Day, IIf(IsNumeric(goUsuario.iToleranciaAPI), goUsuario.iToleranciaAPI, 7), CDate(goUsuario.sDataValidadeAPI)) < Now.Date Then

                    'Realiza Consulta da Licença através da API
                    If ConsultarLicencaAPI(goUsuario.sCNPJEmpresa) = True Then

                        'Verifica se a Data Validade + Tolerância é maior que Hoje
                        If DateAdd(DateInterval.Day, IIf(IsNumeric(goUsuario.iToleranciaAPI), goUsuario.iToleranciaAPI, 7), CDate(goUsuario.sDataValidadeAPI)) >= Now.Date Then

                            'Verifica se a Licença está no período de tolerância
                            If CDate(goUsuario.sDataValidadeAPI) < Now.Date Then
                                'Informa o Usuárioobre a expiração da Licença
                                MsgBox("Sua Licença irá espirar em " & DateDiff(DateInterval.Day, CDate(goUsuario.sDataValidadeAPI), DateAdd(DateInterval.Day, IIf(IsNumeric(goUsuario.iToleranciaAPI), goUsuario.iToleranciaAPI, 7), CDate(goUsuario.sDataValidadeAPI))) & " dia(s)." & vbCrLf & "Favor contatar a ACTi através do e-mail suporte@acticonsultoria.com.br.", MsgBoxStyle.Critical, Me.Text)
                            End If

                            'Atualiza Dados 
                            AtualizaLicencaAPI()

                        Else

                            'Verifica a data de validade da Licença Desktop
                            If DateAdd(DateInterval.Day, 7, CDate(goUsuario.sDataValidade)) < Now.Date Then
                                'Informa o Usuário sobre a expiração da Licença
                                MsgBox("Sua Licença expirou." & vbCrLf & "Favor contatar a ACTi através do e-mail suporte@acticonsultoria.com.br.", MsgBoxStyle.Critical, Me.Text)

                            End If

                            'Fecha Função
                            Exit Function
                        End If

                    Else
                        'Fecha Função
                        Exit Function
                    End If

                    'Se a Data Validade + Licença for maior que a data de hoje
                    'O sistema verifica se a licença está em seu período de tolerância
                ElseIf CDate(goUsuario.sDataValidadeAPI) < Now.Date Then
                    'Informa o Usuárioobre a expiração da Licença
                    MsgBox("Sua Licença irá espirar em " & DateDiff(DateInterval.Day, CDate(goUsuario.sDataValidadeAPI), DateAdd(DateInterval.Day, IIf(IsNumeric(goUsuario.iToleranciaAPI), goUsuario.iToleranciaAPI, 7), CDate(goUsuario.sDataValidadeAPI))) & " dia(s)." & vbCrLf & "Favor contatar a ACTi através do e-mail suporte@acticonsultoria.com.br.", MsgBoxStyle.Critical, Me.Text)
                End If

            End If

            'Seta Retorno
            ControleLicencaAPI = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Function

    Public Sub LoadPage(ByVal pStrName As String, ByVal pStrText As String, ByVal pUsrControl As UserControl, Optional ByVal bPedidoVenda As Boolean = False)

        Try

            'Seta Focu
            tabMain.SuspendLayout()

            'Verifica se o Formulário está aberto
            If tabMain.TabPages.Contains(pStrName) = True And bPedidoVenda = False Then

                'Seta Focu
                tabMain.SelectedTab = tabMain.TabPages(pStrName)

            Else

                'Seta Propriedades da Página
                Dim oTabPage As New UITabPage(pStrText)
                oTabPage.Size = New System.Drawing.Size(pagPrincipal.Width, pagPrincipal.Height)
                oTabPage.Name = pStrName
                oTabPage.Tag = pUsrControl.Tag
                oTabPage.Key = pStrName
                oTabPage.Padding = New Padding(8)
                Call ConfigureValorDefault(pUsrControl)
                oTabPage.Controls.Add(pUsrControl)

                'Adiciona Página
                tabMain.TabPages.Add(oTabPage)
                tabMain.SelectedTab = oTabPage

            End If

            tabMain.ResumeLayout()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Public Sub LoadPage(ByVal pStrName As String, ByVal pStrText As String, ByVal pUsrControl As UserControl, ByVal oTabMain As UITab)

        Try

            'Seta Focu
            oTabMain.SuspendLayout()

            'Verifica se o Formulário está aberto
            If oTabMain.TabPages.Contains(pStrName) = True Then

                'Seta Focu
                oTabMain.SelectedTab = oTabMain.TabPages(pStrName)

            Else

                'Seta Propriedades da Página
                Dim oTabPage As New UITabPage(pStrText)
                oTabPage.Size = New System.Drawing.Size(pagPrincipal.Width, pagPrincipal.Height)
                oTabPage.Name = pStrName
                oTabPage.Tag = pUsrControl.Tag
                oTabPage.Key = pStrName
                oTabPage.Padding = New Padding(8)
                Call ConfigureValorDefault(pUsrControl)
                oTabPage.Controls.Add(pUsrControl)

                'Adiciona Página
                oTabMain.TabPages.Add(oTabPage)
                oTabMain.SelectedTab = oTabPage

            End If

            oTabMain.ResumeLayout()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Public Sub LoadDashboard(ByVal oUsrControl As UserControl)

        Try


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub PrintPDF(ByRef oRptDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument, _
                              ByVal pStrName As String, _
                              ByVal pStrText As String, _
                              ByVal pUsrControl As UserControl, _
                              Optional ByVal oTabMain As UITab = Nothing, _
                              Optional ByVal sNomeArquivo As String = "")

        Try

            Dim sFile As String
            If sNomeArquivo = "" Then

                sFile = System.IO.Path.GetTempFileName.Replace(".tmp", ".pdf")
            Else

                sFile = System.IO.Path.GetTempPath & "\" & sNomeArquivo & ".pdf"

            End If


            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sFile)
            Process.Start(sFile)


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExibirCrystal(ByRef oRptDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument, _
                              ByVal pStrName As String, _
                              ByVal pStrText As String, _
                              ByVal pUsrControl As UserControl, _
                              Optional ByVal oTabMain As UITab = Nothing, _
                              Optional ByVal sNomeArquivo As String = "")
        Try

            If IsNothing(oTabMain) Then
                oTabMain = tabMain
            End If

            'Verifica se o Formulário está aberto
            If oTabMain.TabPages.Contains(pStrName) = True Then
                oTabMain.SelectedTab = oTabMain.TabPages(pStrName)
                Exit Sub
            End If

            'Seta Propriedades da Página
            Dim oTabPage As New UITabPage(pStrText)
            Dim oControl As New Control
            Dim oTab As New TabControl

            oTabPage.Padding = New Padding(8)
            oTabPage.Name = pStrName
            oTabPage.Tag = pUsrControl.Tag
            oTabPage.Key = pStrName

            'Adiciona Página
            oTabMain.TabPages.Add(oTabPage)
            oTabPage.Controls.Add(pUsrControl)
            'Seta Focu
            oTabMain.SelectedTab = oTabPage

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadPageReport(ByVal pStrName As String, _
                              ByVal pStrText As String, _
                              ByVal pUsrControl As UserControl, _
                              Optional ByVal oTabMain As UITab = Nothing, _
                              Optional ByVal sNomeArquivo As String = "", _
                              Optional ByVal bPDF As Boolean = True)

        Try

            Dim oRptDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            If Not System.IO.File.Exists(goCrystalReport.sReport) Then
                MsgBox("Report não existente!", MsgBoxStyle.Information, "Relatório")
                Exit Sub
            End If
            'Abre o Relatóri
            oRptDocument.Load(goCrystalReport.sReport, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            'Atualiza Relatório
            'rptDocument.Refresh()

            'Desabilita o Cache
            oRptDocument.ReportOptions.EnableSaveDataWithReport = False

            'Envia parametros para o Relatório
            For i As Integer = 0 To UBound(goCrystalReport.sReportParameter)
                If CStr(goCrystalReport.sReportParameter(i).sValue) = "NULL" Then
                    oRptDocument.SetParameterValue(goCrystalReport.sReportParameter(i).sParamenter, DBNull.Value)
                Else
                    oRptDocument.SetParameterValue(goCrystalReport.sReportParameter(i).sParamenter, goCrystalReport.sReportParameter(i).sValue)
                End If
            Next

            'Abre Conexão com o Banco de Dados        
            For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)

            Next i



            If bPDF = True Then

                Try
                    PrintPDF(oRptDocument, _
                             pStrName, _
                          pStrText, _
                         pUsrControl, _
                         oTabMain, _
                         sNomeArquivo)


                Catch ex As Exception

                    ExibirCrystal(oRptDocument, _
                                  pStrName, _
                                  pStrText, _
                                 pUsrControl, _
                                 oTabMain, _
                                 sNomeArquivo)


                End Try
                
            Else

                ExibirCrystal(oRptDocument, _
                            pStrName, _
                            pStrText, _
                        pUsrControl, _
                        oTabMain, _
                        sNomeArquivo)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Public Sub ClosePageButOne(ByVal pStrName As String)

        'Variaveis Locais
        Dim oTabPage As New UITabPage
        Dim oControl As New Control
        Dim i As Integer = 0

        Try

            'Verifica se ja foi aberto o Formulário
            While (tabMain.TabPages.Count > 1)
                If tabMain.TabPages(i).Name <> pStrName Then
                    'Remove Página
                    tabMain.TabPages.Remove(tabMain.TabPages(i))
                    i = 0
                End If
                i += 1
            End While

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Public Sub Informacao(ByVal iMensagem As Mensagem, _
                          Optional ByVal sCampo As String = "")

        'Váriaveis Locais
        Dim oThread As Thread
        Dim sMensagem As String

        Try

            'Carrega Mensagem
            sMensagem = LoadDescricao("sp_select_static_traducao_mensagem " & iMensagem & ", " & goUsuario.iIdioma & ", '" & sCampo.Replace("'", "") & "'")
            sMensagem = IIf(IsNothing(sMensagem), "", sMensagem)

            stbMain.Panels("pnlInfo").Text = sMensagem
            'stbMain.Panels("pnlInfo").FormatStyle.ForeColor = pColor

            oThread = New Thread(AddressOf ShowInformacao)
            oThread.IsBackground = True
            oThread.Start()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Public Sub Informacao(ByVal sMensagem As String, ByVal oColor As System.Drawing.Color)

        'Váriaveis Locais
        Dim oThread As Thread


        Try



            stbMain.Panels("pnlInfo").Text = sMensagem
            'stbMain.Panels("pnlInfo").FormatStyle.ForeColor = pColor

            oThread = New Thread(AddressOf ShowInformacao)
            oThread.IsBackground = True
            oThread.Start()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub ShowInformacao()

        Try

            Thread.Sleep(gcTempoMensagem)
            stbMain.Panels("pnlInfo").Text = ""

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub VerificarAviso()

        Try
            'Recebe a versão
            Dim sVersao As String = oClsFrmMain.LoadVersaoAplicativo

            Dim iIndex As Integer = 0

            'Verifica se é diferente
            If sVersao <> Application.ProductVersion.ToString Then

                mnuMain.Items(iIndex).Text = "Atualizar para versão [" & sVersao & "]"
                mnuMain.Items(iIndex).BackColor = Color.Red

            Else

                mnuMain.Items(iIndex).Text = "-"
                mnuMain.Items(iIndex).BackColor = Color.Transparent

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidaLicencaAPI()
        Try

            'Verifica se precisa validar
            Dim bLicencaAPIValida As Boolean = LoadCodigo("sp_validate_administracao_licenca_api " & goUsuario.iEmpresa)

            If bLicencaAPIValida = True Then
                Return bLicencaAPIValida
                Exit Function
            End If


            'Client para trazer os dados da string
            Dim oClient As New System.Net.WebClient
            Dim sResponse As String
            Dim sUrl As String = LoadEnderecoApiLicenca()
            sUrl += goUsuario.sCNPJEmpresa.Replace(",", "").Replace("-", "").Replace("/", "").Replace("\", "").Replace(".", "")

            'Faz o request
            sResponse = oClient.DownloadString(sUrl)


            'Verifica se chegou como "true"
            If sResponse.ToUpper.Contains("TRUE") Then
                ExecuteQuery("sp_update_administracao_licenca_api " & CStr(goUsuario.iEmpresa))
                Return True
            Else

                MsgBox("A licença do CNPJ " & goUsuario.sCNPJEmpresa & " está expirada! Favor confirmar a autorização no e-mail financeiro@acticonsultoria.com.br ", MsgBoxStyle.Exclamation, "Validação API")
                Return False
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class