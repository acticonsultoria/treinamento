Imports System.Threading
Public Class frmFinAvisoTituloAtraso

    Private Sub Tmr_aviso_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAviso.Tick
        'Pegando a posição em Y
        Dim destY As Integer = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        'Realizando o efeito de splash
        While Me.Location.Y <> destY
            'Setando a localização
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 1)
            'Tempo de sleep
            Thread.Sleep(0.1)
        End While
    End Sub

    Private Sub usr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tmrAviso.Interval = 50

        'Setando a localização 
        'Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height)
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)

        ''Setando o start do timer
        'tmrAviso.Start()
        If goDatabase.sInitialCatalog = "INTERACTI_ASCON_PRD" Then
            Me.Text = "Aviso de Vencimento de Títulos"
        Else
            Me.Text = "Aviso de Títulos em Atraso"
        End If

        Dim oClsFrmFinAvisoTituloAtraso As New clsFrmFinAvisoTituloAtraso

        oClsFrmFinAvisoTituloAtraso.LoadGrid(grdListagem)
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Try
            Me.Dispose()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo de Registro
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "excluir" : Call Delete()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Delete()

        Try

            Dim oClsFrmFinAvisoTituloAtraso As New clsFrmFinAvisoTituloAtraso
             
                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
            'If MsgBox("Deseja excluir permanentemente este título" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

            If MsgBox("Deseja excluir permanentemente este título?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Exclui Registro
                oClsFrmFinAvisoTituloAtraso.Delete(grdListagem)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroExcluido)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

                oClsFrmFinAvisoTituloAtraso.LoadGrid(grdListagem)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class