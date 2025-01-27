Public Class usrAjuda

#Region "::: CONTROLES :::"

    Private Sub usrAjuda_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try

            webAjuda.Navigate(sURLHelp)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

End Class
