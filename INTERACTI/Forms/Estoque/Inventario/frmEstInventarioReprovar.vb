Imports Janus.Windows.GridEX

Public Class frmEstInventarioReprovar

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEstIventarioReprovar As New clsFrmEstInventarioReprovar

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmEstInventarioReprovar_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmEstInventarioReprovar_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnReprovarInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReprovarInventario.Click

        Try

            'Verifica se foi Preenchido o Campo - Histórico
            If ValidaCampo(txtHistorico, lblHistorico, TipoCampo.texto) = False Then
                Exit Sub
            End If

            'Reprovar Inventario
            Call ReprovarInventario()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

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

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub ReprovarInventario()

        Try

            'Verifica se o Usuário Aprovar
            If MsgBox("Deseja Reprovar o Inventário Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Exclui Registro
                oClsEstIventarioReprovar.ReprovarInventario(txtNumeroInventario.Tag, _
                                                            txtHistorico.Text.Trim)


                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Fecha Formulário
                Me.Dispose()

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class