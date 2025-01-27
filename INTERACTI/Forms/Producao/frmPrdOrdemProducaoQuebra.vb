Imports Janus.Windows.GridEX

Public Class frmPrdOrdemProducaoQuebra

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsPrdOrdemProducao As New clsUsrPrdOrdemProducao

    Private lCodigoOrdemProducao As Long
    Private sNumeroOrdemProducao As String
    Private sProduto As String
    Private dQuantidadePlanejada As Double
    Private dQuantidadeRejeito As Double
    Private dQuantidadeProduzida As Double

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoOrdemProducao() As Long
        Set(ByVal value As Long)
            lCodigoOrdemProducao = value
        End Set
    End Property

    Public WriteOnly Property NumeroOrdemProducao() As String
        Set(ByVal value As String)
            sNumeroOrdemProducao = value
        End Set
    End Property

    Public WriteOnly Property Produto() As String
        Set(ByVal value As String)
            sProduto = value
        End Set
    End Property

    Public WriteOnly Property QuantidadePlanejada() As Double
        Set(ByVal value As Double)
            dQuantidadePlanejada = value
        End Set
    End Property

    Public WriteOnly Property QuantidadeRejeito() As Double
        Set(ByVal value As Double)
            dQuantidadeRejeito = value
        End Set
    End Property

    Public WriteOnly Property QuantidadeProduzida() As Double
        Set(ByVal value As Double)
            dQuantidadeProduzida = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmPrdOrdemProducaoQuebra_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub btnDividirOrdemProducao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDividirOrdemProducao.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = False Then Exit Sub

            'Cancelar Pedido de Venda
            DividirOrdemProducao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Controles
            txtOrdemProducao.Text = sNumeroOrdemProducao
            txtProduto.Text = sProduto
            txtQuantidadePlanejada.Value = dQuantidadePlanejada
            txtQuantidadeRejeito.Value = dQuantidadeRejeito
            txtQuantidadeProduzida.Value = dQuantidadeProduzida

            'Seta Focu
            txtQuantidadeQuebra.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub DividirOrdemProducao()

        Try

            'Verifica se o Usuário deseja Cancelar o Pedido de Venda
            If MsgBox("Deseja Dividir a Ordem de Produção?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Divide Ordem de Produção
                oClsPrdOrdemProducao.DividirOrdemProducao(lCodigoOrdemProducao, _
                                                          txtJustificativa.Text.Trim, _
                                                          txtQuantidadeQuebra.Value, _
                                                          txtQuantidadePlanejada.Value)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadeQuebra, lblQuantidadeQuebra, True) = False Then
                Exit Function
            ElseIf txtQuantidadeQuebra.Value >= (txtQuantidadePlanejada.Value - txtQuantidadeRejeito.Value) Then
                frmMain.errInfo.SetError(lblQuantidadeQuebra, "A Quantidade Informada não pode ser Maior ou Igual que a Quantidade Planejada menos a Quantidade Rejeito.")
                txtQuantidadeQuebra.Focus()
                Exit Function
            End If

            If oClsPrdOrdemProducao.ValidaQuebra(lCodigoOrdemProducao) = True Then
                MsgBox("Existe pagamento de material para esta OP. Estorne estes pagamentos para realizar a Quebra de OP.", MsgBoxStyle.Information, "Validação")
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Function

#End Region

End Class