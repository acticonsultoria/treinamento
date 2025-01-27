Imports Janus.Windows.EditControls

Public Class frmVenDadosProduto

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCadProduto As New clsUsrCadProduto
    Private lCodigoProduto As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoProduto() As Long
        Get
            Return lCodigoProduto
        End Get
        Set(ByVal value As Long)
            lCodigoProduto = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmVenDadosProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape
                    'Fecha o Controle
                    Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmVenDadosProduto_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            Call Salvar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub txtPrecoCompra_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecoCompra.LostFocus

        Try

            'Altera Margem de Lucro
            If txtPrecoCompra.Value > 0 Then
                txtMargemLucro.Value = ((txtPrecoVenda.Value - txtPrecoCompra.Value) * 100 / txtPrecoCompra.Value)
            Else
                txtMargemLucro.Value = 0
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub txtMargemLucro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMargemLucro.LostFocus

        Try

            'Altera Preço de Venda
            txtPrecoVenda.Value = (txtPrecoCompra.Value + (txtPrecoCompra.Value * txtMargemLucro.Value / 100))

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub txtPrecoVenda_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecoVenda.LostFocus

        Try

            'Altera Margem de Lucro
            If txtPrecoCompra.Value > 0 Then
                txtMargemLucro.Value = ((txtPrecoVenda.Value - txtPrecoCompra.Value) * 100 / txtPrecoCompra.Value)
            Else
                txtMargemLucro.Value = 0
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmVenDadosProduto_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Váriaveis Locais
            Dim sLocalizacao As String = ""
            Dim sCodigoProduto As String = ""
            Dim sDescricao As String = ""
            Dim dQuantidadeEstoque As Double = 0
            Dim dCustoMedio As Double = 0
            Dim dPrecoCompra As Double = 0
            Dim dMargem As Double = 0
            Dim dPrecoVenda As Double = 0

            'Carrega Dados do Produto
            oClsCadProduto.LoadDadosProduto(lCodigoProduto, _
                                            sCodigoProduto, _
                                            sDescricao, _
                                            dQuantidadeEstoque, _
                                            dCustoMedio, _
                                            dPrecoCompra, _
                                            dMargem, _
                                            dPrecoVenda)

            'Seta Controles
            Me.Text &= " " & sCodigoProduto
            txtDescricao.Text = sDescricao
            txtQuantidadeSistema.Value = dQuantidadeEstoque
            txtCustoMedio.Value = dCustoMedio
            txtPrecoCompra.Value = dPrecoCompra
            txtMargemLucro.Value = dMargem
            txtPrecoVenda.Value = dPrecoVenda

            'Verifica Direito de Alterar o Pedido de Compra / Margem / Preço de Venda
            Dim bDireito As Boolean = VerificaDireito(Formulario.CadastroBasicoProdutoPrecoVenda, gcInsert)
            txtPrecoCompra.Enabled = bDireito
            txtMargemLucro.Enabled = bDireito
            txtPrecoVenda.Enabled = bDireito

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Verifica se o Usuário deseja Atualizar os Dados do Produto
            If MsgBox("Deseja alterar os dados do Produto (Estoque / Localização)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Salva Produto
                oClsCadProduto.AtualizaProduto(lCodigoProduto, _
                                               txtPrecoCompra.Value, _
                                               txtMargemLucro.Value, _
                                               txtPrecoVenda.Value)

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class