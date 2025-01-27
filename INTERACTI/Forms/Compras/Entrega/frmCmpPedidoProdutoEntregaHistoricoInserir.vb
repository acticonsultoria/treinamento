Imports Janus.Windows.GridEX

Public Class frmCmpPedidoProdutoEntregaHistoricoInserir

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oGrid As GridEX
    Private oClsCmpPedidoEntrega As New clsUsrCmpPedidoEntrega

    Private sNumeroPedido As String
    Private sDataPedido As String
    Private sParceiroNegocio As String
    Private sProduto As String
    Private dQuantidade As Double
    Private sUnidadeMedida As String
    Private dValorUnitario As Double
    Private dValorTotal As Double

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

    Public Property Produto() As String
        Get
            Return sProduto
        End Get
        Set(ByVal value As String)
            sProduto = value
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

    Public Property UnidadeMedida() As String
        Get
            Return sUnidadeMedida
        End Get
        Set(ByVal value As String)
            sUnidadeMedida = value
        End Set
    End Property

    Public Property ValorUnitario() As Double
        Get
            Return dValorUnitario
        End Get
        Set(ByVal value As Double)
            dValorUnitario = value
        End Set
    End Property

    Public Property ValorTotal() As Double
        Get
            Return dValorTotal
        End Get
        Set(ByVal value As Double)
            dValorTotal = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpPedidoProdutoEntregaHistoricoInserir_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmCmpPedidoProdutoEntregaHistoricoInserir_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposicionada Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Cancelar Item do Pedido
                SalvarHistorico()

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

            'Carrega Dados do Item
            txtNumeroPedido.Text = sNumeroPedido
            txtDataPedido.Text = sDataPedido
            txtCliente.Text = sParceiroNegocio
            txtItem.Text = sProduto
            txtQuantidade.Value = dQuantidade
            txtUnidadeMedida.Text = sUnidadeMedida
            txtValorUnitario.Value = dValorUnitario
            txtValorTotal.Value = dValorTotal

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub SalvarHistorico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Cancela Pedido
            Call oClsCmpPedidoEntrega.HistoricoProdutoEntrega(oGrid.CurrentRow.Cells("codigo_pedido").Value, _
                                                              oGrid.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                              oGrid.CurrentRow.Cells("codigo").Value, _
                                                              txtHistorico.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Histórico
            If ValidaCampo(txtHistorico, lblHistorico, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Histórico com menos de 15 caracteres
            If Len(txtHistorico.Text.Trim) < 15 Then
                frmMain.errInfo.SetError(lblHistorico, "o Histórico deve possuir ao menos 15 Caracteres.")
                txtHistorico.Focus()
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