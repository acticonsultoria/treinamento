Imports Janus.Windows.GridEX

Public Class frmCmpPedidoNovaEntradaFisica

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCmpPedidoEntrega As New clsUsrCmpPedidoEntrega
    Private lCodigoPedido As Long
    Private iCodigoPedidoItem As Integer
    Private iCodigoPedidoItemEntrega As Integer
    Private sNumeroPedido As String
    Private sDataPedido As String
    Private sParceiroNegocio As String
    Private sCodigoProduto As String
    Private dQuantidade As Double
    Private sDataPrevisaoEntrega As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoPedido() As Long
        Get
            Return lCodigoPedido
        End Get
        Set(ByVal value As Long)
            lCodigoPedido = value
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

    Public Property CodigoPedidoItemEntrega() As Integer
        Get
            Return iCodigoPedidoItemEntrega
        End Get
        Set(ByVal value As Integer)
            iCodigoPedidoItemEntrega = value
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

    Public Property DataPedido() As String
        Get
            Return sDataPedido
        End Get
        Set(ByVal value As String)
            sDataPedido = value
        End Set
    End Property

    Public Property ParceiroNegocio() As String
        Get
            Return sParceiroNegocio
        End Get
        Set(ByVal value As String)
            sParceiroNegocio = value
        End Set
    End Property

    Public Property CodigoProduto() As String
        Get
            Return sCodigoProduto
        End Get
        Set(ByVal value As String)
            sCodigoProduto = value
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

    Public Property DataPrevisaoEntrega() As String
        Get
            Return sDataPrevisaoEntrega
        End Get
        Set(ByVal value As String)
            sDataPrevisaoEntrega = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpPedidoProdutoEntregaHistorico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmCmpPedidoProdutoEntregaHistorico_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            frmMain.errInfo.Clear()

            If Validacao() = True Then

                Call Salvar()

                Me.Dispose()

            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

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

            'Carrega Controles
            txtNumeroPedido.Text = sNumeroPedido
            dtpDataPedido.Value = sDataPedido
            txtCliente.Text = sParceiroNegocio
            txtCodigoProduto.Text = sCodigoProduto
            txtQuantidade.Value = dQuantidade
            dtpDataEntregaInicioFiltro.Value = sDataPrevisaoEntrega

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Public Function Validacao() As Boolean

        Try

            Validacao = False

            If txtQuantidadeEntrega.Value <= 0 Then
                frmMain.errInfo.SetError(lblQuantidadeEntregue, "O Campo [ Quantidade Entregue ] não pode ser menor ou igual a 0.")
                txtQuantidadeEntrega.Focus()
                Exit Function
            End If

            If txtQuantidadeEntrega.Value > txtQuantidade.Value Then
                MsgBox("A quantidade entrega não pode ser maior do que a do pedido.", MsgBoxStyle.Information, "VALIDAÇÂO")
                Exit Function
            End If

            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Salvar()

        Try

            Cursor.Current = Cursors.WaitCursor

            Call oClsCmpPedidoEntrega.UpdateEntradaFisica(lCodigoPedido, _
                                                     iCodigoPedidoItem, _
                                                     iCodigoPedidoItemEntrega, _
                                                     dtpDataEntradaFisica.Value, _
                                                     txtQuantidadeEntrega.Value)

            frmMain.Informacao(Mensagem.RegistroAlterado)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class