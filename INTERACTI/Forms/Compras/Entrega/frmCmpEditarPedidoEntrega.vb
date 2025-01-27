Imports Janus.Windows.GridEX

Public Class frmCmpEditarPedidoEntrega

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oclsUsrCmpPedidoEntrega As New clsUsrCmpPedidoEntrega
    Private iCodigoPedido As Long
    Private iCodigoPedidoItem As Integer
    Private iCodigo As Integer
    Private iCodigoItem As String
    Private sDescricao As String
    Private dQuantidade As Double
    Private sFornecedor As String
    Private sNumeroPedido As String
    Private sDataPrevisaoEntrega As String
    Private sDataEntrega As String
    Private sStatus As String
    Private bFinalizado As Boolean

#End Region

#Region "::: PROPERTIES :::"

    Public Property Finalizado() As Boolean
        Get
            Return bFinalizado
        End Get
        Set(ByVal value As Boolean)
            bFinalizado = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return sDescricao
        End Get
        Set(ByVal value As String)
            sDescricao = value
        End Set
    End Property

    Public Property NumeroPedido() As String
        Get
            Return sNumeroPedido
        End Get
        Set(ByVal value As String)
            sNumeroPedido = value
        End Set
    End Property

    Public Property Fornecedor() As String
        Get
            Return sFornecedor
        End Get
        Set(ByVal value As String)
            sFornecedor = value
        End Set
    End Property

    Public Property Codigo() As Integer
        Get
            Return iCodigo
        End Get
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property

    Public Property CodigoPedido() As Long
        Get
            Return iCodigoPedido
        End Get
        Set(ByVal value As Long)
            iCodigoPedido = value
        End Set
    End Property

    Public Property CodigoPedidoItem() As Integer
        Get
            Return iCodigoPedidoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoPedidoItem = value
        End Set
    End Property

    Public Property Quantidade() As Double
        Get
            Return dQuantidade
        End Get
        Set(ByVal value As Double)
            dQuantidade = value
        End Set
    End Property

    Public Property CodigoItem() As String
        Get
            Return iCodigoItem
        End Get
        Set(ByVal value As String)
            iCodigoItem = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    'If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        ConfigurarFormulario()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            If Validacao() = False Then Exit Sub

            Salvar()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        'Fecha o Controle
        Me.Dispose()
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
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            txtFornecedor.Text = sFornecedor
            txtItem.Text = sDescricao
            txtNumeroPedido.Text = sNumeroPedido
            txtQuantidade.Value = dQuantidade

            txtQuantidade.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If txtQuantidade.Value <= 0 Then
                MsgBox("A quantidade não pode ser menor ou igual a 0.", MsgBoxStyle.Exclamation, "Validação")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Salvar()

        Try

            oclsUsrCmpPedidoEntrega.AtualizarQuantidadeEntrega(iCodigoPedido, _
                                                               iCodigoPedidoItem, _
                                                               iCodigo,
                                                               txtQuantidade.Value)

            bFinalizado = True

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroAlterado)
            'MsgBox("Registro alterado com sucesso!")

            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class