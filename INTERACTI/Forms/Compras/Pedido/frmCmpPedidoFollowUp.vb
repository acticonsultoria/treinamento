Imports Janus.Windows.GridEX

Public Class frmCmpPedidoFollowUp

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oGrid As GridEX
    Private oClsCmpPedido As New clsUsrCmpPedido

#End Region

#Region "::: PROPERTIE :::"

    Public Property Grid() As GridEX
        Get
            Return oGrid
        End Get
        Set(ByVal value As GridEX)
            oGrid = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpPedidoFollowUp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCmpPedidoFollowUp_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
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

    Private Sub btnRecebeuPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecebeuPedido.Click

        Try

            'Fallow Up Positivo
            Call FallowUp(True)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnNaoRecebeuPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNaoRecebeuPedido.Click

        Try

            'Fallow Up Negativo
            Call FallowUp(False)

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCmpPedidoFollowUp_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Controles
            txtNumeroPedido.Text = oGrid.CurrentRow.Cells("numero_pedido").Value
            txtDataPedido.Text = oGrid.CurrentRow.Cells("data_pedido").Value
            txtCliente.Text = oGrid.CurrentRow.Cells("parceiro_negocio").Value

            'Seta Focu
            txtObervacao.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub FallowUp(ByVal bFallowUp As Boolean)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Cancela Pedido
            Call oClsCmpPedido.FollowUp(oGrid.CurrentRow.Cells("codigo_pedido").Value, _
                                        txtObervacao.Text.Trim, _
                                        bFallowUp)

            'Atualiza a Grid
            Call UpdateRegistroGrid(oGrid, "codigo_pedido = " & oGrid.CurrentRow.Cells("codigo_pedido").Value, "follow_up_executado", bFallowUp)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class