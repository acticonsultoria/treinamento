Imports Janus.Windows.GridEX

Public Class frmManRequisicaoReprovar

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsManRequisicaoAprovar As New clsUsrManRequisicaoAprovar

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmManRequisicaoReprovar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmManRequisicaoReprovar_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnReprovar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReprovar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Reprova Requisição
                ReprovarRequisicao()

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmManRequisicaoReprovar_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub ReprovarRequisicao()

        Try

            'Verifica se o Usuário deseja Reprovar a Requisição
            If MsgBox("Deseja Reprovar o(s) Produto(s) da(s) Requisição(ões) de Manutenção?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Reprova Requisição
                Call oClsManRequisicaoAprovar.ReprovarRequisicao(txtJustificativa.Text.Trim)

                'Fecha o Formulário
                Me.Dispose()

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Justificativa
            If ValidaCampo(txtJustificativa, lblJustificativa, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Justificativa com menos de 15 caracteres
            If Len(txtJustificativa.Text.Trim) < 15 Then
                frmMain.Informacao(Mensagem.QuantidadeCaracter, "15")
                txtJustificativa.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Function

#End Region

End Class