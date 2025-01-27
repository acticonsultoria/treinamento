Imports Janus.Windows.GridEX
Imports System.IO

Public Class frmAdmChamadoComentario

#Region "::: VARIAVEIS :::"

    Private oClsUsrAdmChamado As New clsUsrAdmChamado

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmAdmChamadoInserirHistorico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Call ConfigurarForm()

    End Sub

    Private Sub frmAdmChamadoInserirHistorico_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Height = frmMain.tabMain.Height
        Me.Width = frmMain.tabMain.Width

    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click

        frmMain.errInfo.Clear()

        If Validacao() = True Then

            Call Salvar()

            Me.Dispose()

        End If

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Me.Dispose()

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarForm()

        Try

            txtComentario.Focus()

        Catch ex As Exception
            frmMain.Informacao(ex.Message, Color.Red)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            Cursor.Current = Cursors.WaitCursor

            Call oClsUsrAdmChamado.InsertComentario(txtCodigoChamado.Text, _
                                                    txtComentario.Text)

            frmMain.Informacao("Comentário incluído com sucesso!", Color.Blue)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            frmMain.Informacao(ex.Message, Color.Red)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            Validacao = False

            If ValidaCampo(txtComentario, lblHistorico, TipoCampo.texto) = False Then Exit Function

            Validacao = True

        Catch ex As Exception
            frmMain.Informacao(ex.Message, Color.Red)
        End Try

    End Function

#End Region

End Class