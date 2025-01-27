Imports Janus.Windows.GridEX

Public Class frmCmpPedidoCancelarItem

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCmpPedido As New clsUsrCmpPedido
    Private lCodigoPedido As Long
    Private iCodigoPedidoItem As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoPedido() As Long
        Set(ByVal value As Long)
            lCodigoPedido = value
        End Set
    End Property

    Public WriteOnly Property CodigoPedidoItem() As Integer
        Set(ByVal value As Integer)
            iCodigoPedidoItem = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpPedidoCancelarItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCmpPedidoCancelarItem_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Cancelar Produto do Orçamento
                Cancelar()

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCmpPedidoCancelarItem_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Controles
            Call oClsCmpPedido.LoadDadosItem(lCodigoPedido, _
                                             iCodigoPedidoItem, _
                                             txtNumeroPedido, _
                                             txtDataPedido, _
                                             txtFornecedor, _
                                             txtItem, _
                                             txtQuantidade, _
                                             txtUnidadeMedida, _
                                             txtValorUnitario, _
                                             txtValorTotal)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Cancelar()

        Try

            'Verifica se o Usuário deseja Cancelar o Registro
            If MsgBox("Deseja Cancelar o Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Cancela Orçamento
                Call oClsCmpPedido.CancelarItem(lCodigoPedido, _
                                                iCodigoPedidoItem, _
                                                txtQuantidadeCancelar.Value, _
                                                txtJustificativa.Text.Trim)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Informado a Quantidade
            If ValidaCampo(txtQuantidadeCancelar, lblQuantidadeCancelar, True) = False Then
                Exit Function
            ElseIf txtQuantidadeCancelar.Value > txtQuantidade.Value Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "A Quantidade Cancelada não pode ser maior que a Quantidade.")
                txtQuantidadeCancelar.Focus()
                Exit Function
            End If

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
            Throw ex
        End Try

    End Function

#End Region

End Class