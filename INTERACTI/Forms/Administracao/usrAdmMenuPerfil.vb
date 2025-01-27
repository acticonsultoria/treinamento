Public Class usrAdmMenuPerfil

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private WithEvents oClsAdmMenuPerfil As New clsUsrAdmMenuPerfil
    Private iFormulario As Integer = -1
#End Region

#Region "::: CONTROLES :::"

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Insere Registro
                Call Salvar()
                'Prepara Formulário para Inserção de um Novo Registro
                Call Novo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)

            'Executa Tarefas Pendentes do Sistema
            Application.DoEvents()

            'Carrega Menu
            Dim oClsMain As New clsFrmMain
            Call oClsMain.LoadMenu(frmMain.mnuMain)

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Limpa Formulário
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub mnuMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oClsAdmMenuPerfil.Click

        Try

            'Limpa Controles
            Call Novo()

            txtFormulario.Tag = sender.name
            txtFormulario.Text = sender.text

            Call oClsAdmMenuPerfil.LoadGrid(grdListagem, _
                                            txtFormulario.Tag)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Formulário
            Call Novo()

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            'Carrega Menu
            mnuMain.Items.Clear()
            oClsAdmMenuPerfil.LoadMenuSuspenso(mnuMain)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            txtFormulario.Text = ""
            txtFormulario.Tag = -1

            Call oClsAdmMenuPerfil.LoadGrid(grdListagem, _
                                            txtFormulario.Tag)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtFormulario, lblFormulario, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Call oClsAdmMenuPerfil.Insert(grdListagem, _
                                          txtFormulario.Tag)

            'Carrega Menu
            Dim oClsMain As New clsFrmMain
            Call oClsMain.LoadMenu(frmMain.mnuMain)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
