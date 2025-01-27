Imports System.IO
Imports Microsoft.Win32
Imports Janus.Windows.UI.Tab

Public Class frmLogin

#Region "::: VARIAVEIS :::"

    'Variaveis do Módulo
    Private oClsLogin As New clsFrmLogin

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'Verifica se foi pressionado a tecla enter
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            'Executa Clique do Botão - Logar
            Call btnLogar_Click(btnLogar, System.EventArgs.Empty)
        End If

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigureFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            If goUsuario.sUsuario = "" Then
                End
            Else
                Dispose()
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnLogar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Altentica Usuário
                If AutenticaUsuario() = True Then
                    'Fecha o Formulário
                    Me.Dispose()
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpresa.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado alguma Empresa
            If cboEmpresa.SelectedIndex = -1 Then
                txtUsuario.Text = ""
            Else
                txtUsuario.Text = CType(LoadDescricao("sp_select_administracao_ultimo_usuario '" & System.Net.Dns.GetHostName & "', " & cboEmpresa.SelectedValue), String)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigureFormulario()

        Try

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica o Sistema
            If gSistema = "INTERACTI" Then
                picAGROACTi.Visible = False
                picInteracti.Visible = True
            ElseIf gSistema = "AGROACTI" Then
                picInteracti.Visible = False
                picAGROACTi.Visible = True
            End If

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Torna Formulário Invisível
            Me.Visible = False
            'Seta Label
            Me.Text = gAplicacao & " Versão: " & Application.ProductVersion.ToString

            'Carrega Combo
            Call LoadCombo(cboEmpresa, "sp_select_combo_cadastro_basico_empresa", True)

            'Seta Label
            Dim oFileInfo As FileInfo = New FileInfo(ApplicationPath() & My.Application.Info.AssemblyName.ToString & ".exe")
            lblSistema.Text = "Bem Vindo ao " & gAplicacao & " - Versão: " & Application.ProductVersion.ToString & " - Última Atualização: " & Format(oFileInfo.CreationTime, "dd/MM/yyyy")

            'Verifica se foi preenchido o Usuário
            Call cboEmpresa_SelectedIndexChanged(cboEmpresa, System.EventArgs.Empty)

            'Torna Formulário Visivel
            Me.Visible = True

            If txtUsuario.Text <> "" Then
                txtSenha.Focus()
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function AutenticaUsuario() As Boolean

        Try

            'Seta Retorno da Função
            AutenticaUsuario = False

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsLogin.Usuario = txtUsuario.Text
            oClsLogin.Senha = txtSenha.Text
            oClsLogin.Empresa = cboEmpresa.SelectedValue

            'Verifica se o Usuário é Válido
            If oClsLogin.Login = False Then
                'Informa o Usuário que a Senha está errada
                frmMain.errInfo.SetError(lblUsuario, "Usuário ou Senha informado são inválidos.")
                txtUsuario.Focus()
                Exit Function
            End If

            'Verifica se o Usuário autenticou no sistema, caso não fecha o sistema
            If goUsuario.sUsuario = "" Then End

            'Verifica se o Usuário autenticado é diferente do Anterior
            If frmMain.stbMain.Panels("pnlUsuario").Text <> goUsuario.sUsuario Or frmMain.stbMain.Panels("pnlEmpresa").Text <> goUsuario.sEmpresa Then

                'Váriaveis
                Dim oPages(0) As UITabPage
                Dim oClsFrmMain As New clsFrmMain

                'Lista Páginas Abertas
                For Each oTabPage As UITabPage In frmMain.tabMain.TabPages
                    If oTabPage.Name <> "pagPrincipal" Then
                        If IsNothing(oPages(UBound(oPages))) = False Then
                            ReDim Preserve oPages(UBound(oPages) + 1)
                        End If
                        oPages(UBound(oPages)) = oTabPage
                    End If
                Next

                'Exclui Páginas
                If IsNothing(oPages) = False Then
                    For i As Integer = 0 To UBound(oPages)
                        frmMain.tabMain.TabPages.Remove(oPages(i))
                    Next
                End If

                'Recarrega o Menu
                Call oClsFrmMain.LoadMenu(frmMain.mnuMain)

                'Carrega Dados do Usuário
                frmMain.stbMain.Panels("pnlUsuario").Text = goUsuario.sUsuario
                frmMain.stbMain.Panels("pnlEmpresa").Text = goUsuario.sEmpresa

                'Carrega Configuração
                Call LoadConfiguracaoFonte()

            End If

            'Seta Retorno da Função
            AutenticaUsuario = True

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Empresa
            If ValidaCampo(cboEmpresa, lblEmpresa, False, "EMPRESA") = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Usuário
            If ValidaCampo(txtUsuario, lblUsuario, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Senha
            If ValidaCampo(txtSenha, lblSenha, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
