Imports Janus.Windows.GridEX

Public Class frmCmpPedidoReprovar

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCmpPedido As New clsUsrCmpPedido

    Private sNumeroPedido As String
    Private sDataPedido As String
    Private sFornecedor As String
    Private lCodigoPedido As Long
    Private iTipo As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property NumeroPedido() As String
        Set(ByVal value As String)
            sNumeroPedido = value
        End Set
    End Property

    Public WriteOnly Property DataPedido() As String
        Set(ByVal value As String)
            sDataPedido = value
        End Set
    End Property

    Public WriteOnly Property Fornecedor() As String
        Set(ByVal value As String)
            sFornecedor = value
        End Set
    End Property

    Public WriteOnly Property CodigoPedido() As Long
        Set(ByVal value As Long)
            lCodigoPedido = value
        End Set
    End Property

    Public Property Tipo As Integer
        Get
            Return iTipo
        End Get
        Set(value As Integer)
            iTipo = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpPedidoReprovar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCmpPedidoReprovar_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub btnReprovar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReprovar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                Select Case iTipo
                    Case 1 : CancelarPedidoCompra()
                    Case 2 : ReprovarPedidoCompra()
                End Select

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCmpPedidoReprovar_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Controles
            txtNumeroPedido.Text = sNumeroPedido
            txtDataPedido.Text = sDataPedido
            txtFornecedor.Text = sFornecedor

            Select Case iTipo
                Case 1 : Me.Text = "Cancelar Pedido de Compra" : btnReprovar.Text = "Cancelar"
                Case 2 : Me.Text = "Reprovar Pedido de Compra" : btnReprovar.Text = "Reprovar"
            End Select

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub ReprovarPedidoCompra()

        Try

            'Verifica se o Usuário deseja Reprovar o Pedido de Compra
            If MsgBox("Deseja Reprovar o Pedido de Compra?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Cancela Pedido
                Call oClsCmpPedido.ReprovarPedido(lCodigoPedido,
                                                  txtJustificativa.Text.Trim)

                'ENVIAR EMAIL AVISANDO O COMPRADOR
                oClsCmpPedido.EnviarEmailAprovacaoSupervisorRetornoLegado(lCodigoPedido, 0, 0)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CancelarPedidoCompra()

        Try

            If MsgBox("Deseja Cancelar o Pedido de Compra?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Cancela o pedido
                Call oClsCmpPedido.CancelarPedido(lCodigoPedido,
                                                  txtJustificativa.Text.Trim)

                'ENVIAR EMAIL AVISANDO O COMPRADOR
                oClsCmpPedido.EnviarEmailAprovacaoSupervisorRetornoLegado(lCodigoPedido, 0, 1)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

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