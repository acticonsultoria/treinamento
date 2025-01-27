Public Class usrAdmAlterarSenha

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsAdmAlterarSenha As New clsUsrAdmAlterarSenha

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrAdmAlterarSenha_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrAdmAlterarSenha_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                'Deleta Aba
                If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)

                'Fecha o Controle
                Me.Dispose()

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
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Label
            lblSistema.Text = gAplicacao & " Versão: " & Application.ProductVersion.ToString

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.AdministracaoAlterarSenha, gcUpdate)

            'Seta Focu
            txtSenhaAtual.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Parametros
            oClsAdmAlterarSenha.SenhaAtual = txtSenhaAtual.Text
            oClsAdmAlterarSenha.NovaSenha = txtNovaSenha.Text

            'Atualiza a Senha
            oClsAdmAlterarSenha.Update()

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Senha Atual
            If ValidaCampo(txtSenhaAtual, lblSenhaAtual, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Passa Parametros
            oClsAdmAlterarSenha.SenhaAtual = txtSenhaAtual.Text
            If oClsAdmAlterarSenha.ValidaSenhaAtual() = False Then
                frmMain.Informacao(Mensagem.ValorInformadoNaoValido, "Senha Atual")
                txtSenhaAtual.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Nova Senha
            If ValidaCampo(txtNovaSenha, lblNovaSenha, TipoCampo.texto) = False Then
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