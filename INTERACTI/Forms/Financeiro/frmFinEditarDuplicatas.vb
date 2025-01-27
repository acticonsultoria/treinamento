Imports Janus.Windows.GridEX
Imports Janus.Windows.CalendarCombo

Public Class frmFinEditarDuplicatas

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFinTituloReceita As New clsUsrFinReceitaLancamento
    Private oClsFrmFinEditarDuplicata As New clsFrmFinEditarDuplicata
    Private lCodigoTituloCapa As Long
    Private dValor As Double

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoTituloCapa() As Long
        Set(ByVal value As Long)
            lCodigoTituloCapa = value
        End Set
    End Property

    Public WriteOnly Property Valor() As Double
        Set(ByVal value As Double)
            dValor = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFinEditarDuplicatas_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If Validacao() = True Then

                'Desmembra a Parcela
                Call SalvarParcela()

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub GerarDuplicata() Handles txtIntervaloParcela.ValueChanged, _
                                         txtNumeroParcela.ValueChanged

        Try

            'Verifica Número de Parcela
            txtNumeroParcela.Value = IIf(txtNumeroParcela.Value = 0, 1, txtNumeroParcela.Value)

            'Gera Duplicata
            oClsFinTituloReceita.GerarParcela(grdDuplicata, _
                                              Now.Date, _
                                              txtValorFinal.Value, _
                                              txtNumeroParcela.Value, _
                                              txtIntervaloParcela.Value)

        Catch ex As Exception
            Throw ex
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

            'Carrega Controles
            Call oClsFinTituloReceita.LoadDadosFinanceiro(lCodigoTituloCapa, _
                                                          txtNumeroDocumento, _
                                                          txtParceiroNegocio, _
                                                          txtValorTituloOriginal)

            txtValorDevolvido.Value = dValor
            txtValorFinal.Value = txtValorTituloOriginal.Value - txtValorDevolvido.Value

            'Carrega Grid de Parcela
            Call oClsFinTituloReceita.LoadGridParcela(grdDuplicata, lCodigoTituloCapa)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se a Quantidade Total é igual a Quantidade das Entregas
            If txtValorFinal.Value <> grdDuplicata.GetTotalRow.Cells("valor").Value Then
                frmMain.errInfo.SetError(lblValorFinal, "A Soma dos Valores das Parcelas é diferente do Valor Final. Favor verificar.")
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub SalvarParcela()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Insere Parcelas
            oClsFinTituloReceita.CodigoReceitaCapa = lCodigoTituloCapa
            oClsFinTituloReceita.DeleteParcela(lCodigoTituloCapa)
            oClsFinTituloReceita.InsertParcela(grdDuplicata)

            'Executa Query
            Call ExecuteQuery("sp_update_financeiro_valor_parcela " & lCodigoTituloCapa & ", " & goUsuario.iEmpresa)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class