Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls

Public Class frmFinTituloPagamentoMenor

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private oBotao As UIButton

#End Region

#Region "::: PROPERTIE :::"

    Public Property Botao() As UIButton
        Get
            Return oBotao
        End Get
        Set(ByVal value As UIButton)
            oBotao = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFinTituloPagamentoMenor_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmFinTituloPagamentoMenor_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        Try

            'Seta Váriavel de Retorno
            If rdbDesconto.Checked = True Then
                oBotao.Tag = MotivoPagamentoMenor.Desconto
            ElseIf rdbPagamentoParcial.Checked = True Then
                oBotao.Tag = MotivoPagamentoMenor.PagamentoParcial
            End If

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Seta Váriavel de Retorno
            oBotao.Tag = 0

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

#End Region

End Class