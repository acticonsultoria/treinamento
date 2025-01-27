Imports Janus.Windows.GridEX

Public Class frmVenProdutoPrecoVenda

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCadProduto As New clsUsrCadProduto

    'Váriaveis
    Private lCodigoItem As Long
    Private iCodigoCliente As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoItem() As Long
        Set(ByVal value As Long)
            lCodigoItem = value
        End Set
    End Property

    Public WriteOnly Property CodigoCliente() As Integer
        Set(ByVal value As Integer)
            iCodigoCliente = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmVenProdutoPrecoVenda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmVenProdutoPrecoVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Salva Dados
            Call Salvar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CalcularValor(sender As Object, e As EventArgs)

        Try

            If sender.tag <> "" Then Exit Sub

            'Váriaveis Locais
            Dim dCustoMedio As Double = IIf(IsNumeric(txtCustoMedio.Value), txtCustoMedio.Value, 0)
            Dim dMargemMedio As Double = IIf(IsNumeric(txtMargemMedio.Value), txtMargemMedio.Value, 0)
            Dim dMarkupMedio As Double = IIf(IsNumeric(txtMarkupMedio.Value), txtMarkupMedio.Value, 0)
            Dim dGPMedio As Double = IIf(IsNumeric(txtGPMedio.Value), txtGPMedio.Value, 0)
            Dim dPrecoVendaMedio As Double = IIf(IsNumeric(txtPrecoVendaMedio.Value), txtPrecoVendaMedio.Value, 0)
            Dim dPrecoUnidadeMedio As Double = IIf(IsNumeric(txtPrecoUnidadeMedio.Value), txtPrecoUnidadeMedio.Value, 0)

            Dim dCustoTeoricoTeorico As Double = IIf(IsNumeric(txtCustoTeorico.Value), txtCustoTeorico.Value, 0)
            Dim dMargemTeorico As Double = IIf(IsNumeric(txtMargemTeorico.Value), txtMargemTeorico.Value, 0)
            Dim dMarkupTeorico As Double = IIf(IsNumeric(txtMarkupTeorico.Value), txtMarkupTeorico.Value, 0)
            Dim dGPTeorico As Double = IIf(IsNumeric(txtGPTeorico.Value), txtGPTeorico.Value, 0)
            Dim dPrecoVendaTeorico As Double = IIf(IsNumeric(txtPrecoVendaTeorico.Value), txtPrecoVendaTeorico.Value, 0)
            Dim dPrecoUnidadeTeorico As Double = IIf(IsNumeric(txtPrecoUnidadeTeorico.Value), txtPrecoUnidadeTeorico.Value, 0)

            'Remove Evento
            txtMargemMedio.Tag = "A"
            txtGPMedio.Tag = "A"
            txtMarkupMedio.Tag = "A"
            txtPrecoVendaMedio.Tag = "A"
            txtPrecoUnidadeMedio.Tag = "A"
            txtMargemTeorico.Tag = "A"
            txtGPTeorico.Tag = "A"
            txtMarkupTeorico.Tag = "A"
            txtPrecoVendaTeorico.Tag = "A"
            txtPrecoUnidadeTeorico.Tag = "A"

            Select Case sender.Name

                Case "txtMargemMedio"
                    dPrecoVendaMedio = dCustoMedio + (dCustoMedio * dMargemMedio)
                    dMarkupMedio = IIf(dCustoMedio > 0, (dPrecoVendaMedio / dCustoMedio), 0)
                    dGPMedio = IIf(dPrecoVendaMedio > 0, (dPrecoVendaMedio - dCustoMedio) / dPrecoVendaMedio, 0)
                    txtGPMedio.Value = dGPMedio
                    txtMarkupMedio.Value = dMarkupMedio
                    txtPrecoVendaMedio.Value = dPrecoVendaMedio
                    txtPrecoUnidadeMedio.Value = dPrecoVendaMedio / txtQuantidadeUnidade.Value

                Case "txtMarkupMedio"
                    dPrecoVendaMedio = dCustoMedio * dMarkupMedio
                    dMargemMedio = IIf(dCustoMedio > 0, (dPrecoVendaMedio - dCustoMedio) / dCustoMedio, 0)
                    dGPMedio = IIf(dPrecoVendaMedio > 0, (dPrecoVendaMedio - dCustoMedio) / dPrecoVendaMedio, 0)
                    txtMargemMedio.Value = dMargemMedio
                    txtGPMedio.Value = dGPMedio
                    txtPrecoVendaMedio.Value = dPrecoVendaMedio
                    txtPrecoUnidadeMedio.Value = dPrecoVendaMedio / txtQuantidadeUnidade.Value

                Case "txtGPMedio"
                    If dGPMedio >= 1 Then txtGPMedio.Value = 0.99 : dGPMedio = 0.99
                    dPrecoVendaMedio = dCustoMedio / (1 - dGPMedio)
                    dMargemMedio = IIf(dCustoMedio > 0, (dPrecoVendaMedio - dCustoMedio) / dCustoMedio, 0)
                    dMarkupMedio = IIf(dCustoMedio > 0, (dPrecoVendaMedio / dCustoMedio), 0)
                    txtMargemMedio.Value = dMargemMedio
                    txtMarkupMedio.Value = dMarkupMedio
                    txtPrecoVendaMedio.Value = dPrecoVendaMedio
                    txtPrecoUnidadeMedio.Value = dPrecoVendaMedio / txtQuantidadeUnidade.Value

                Case "txtPrecoVendaMedio"
                    dMargemMedio = IIf(dCustoMedio > 0, (dPrecoVendaMedio - dCustoMedio) / dCustoMedio, 0)
                    dMarkupMedio = IIf(dCustoMedio > 0, (dPrecoVendaMedio / dCustoMedio), 0)
                    dGPMedio = IIf(dPrecoVendaMedio > 0, (dPrecoVendaMedio - dCustoMedio) / dPrecoVendaMedio, 0)
                    txtMargemMedio.Value = dMargemMedio
                    txtGPMedio.Value = dGPMedio
                    txtMarkupMedio.Value = dMarkupMedio
                    txtPrecoUnidadeMedio.Value = txtPrecoVendaMedio.Value / txtQuantidadeUnidade.Value

                Case "txtPrecoUnidadeMedio"
                    dPrecoVendaMedio = dPrecoUnidadeMedio * txtQuantidadeUnidade.Value
                    dMargemMedio = IIf(dCustoMedio > 0, (dPrecoVendaMedio - dCustoMedio) / dCustoMedio, 0)
                    dMarkupMedio = IIf(dCustoMedio > 0, (dPrecoVendaMedio / dCustoMedio), 0)
                    dGPMedio = IIf(dPrecoVendaMedio > 0, (dPrecoVendaMedio - dCustoMedio) / dPrecoVendaMedio, 0)
                    txtMargemMedio.Value = dMargemMedio
                    txtGPMedio.Value = dGPMedio
                    txtMarkupMedio.Value = dMarkupMedio

                Case "txtMargemTeorico"
                    dPrecoVendaTeorico = dCustoTeoricoTeorico + (dCustoTeoricoTeorico * dMargemTeorico)
                    dMarkupTeorico = IIf(dCustoTeoricoTeorico > 0, (dPrecoVendaTeorico / dCustoTeoricoTeorico), 0)
                    dGPTeorico = IIf(dPrecoVendaTeorico > 0, (dPrecoVendaTeorico - dCustoTeoricoTeorico) / dPrecoVendaTeorico, 0)
                    txtGPTeorico.Value = dGPTeorico
                    txtMarkupTeorico.Value = dMarkupTeorico
                    txtPrecoVendaTeorico.Value = dPrecoVendaTeorico
                    txtPrecoUnidadeTeorico.Value = dPrecoVendaTeorico / txtQuantidadeUnidade.Value

                Case "txtMarkupTeorico"
                    dPrecoVendaTeorico = dCustoTeoricoTeorico * dMarkupTeorico
                    dMargemTeorico = IIf(dCustoTeoricoTeorico > 0, (dPrecoVendaTeorico - dCustoTeoricoTeorico) / dCustoTeoricoTeorico, 0)
                    dGPTeorico = IIf(dPrecoVendaTeorico > 0, (dPrecoVendaTeorico - dCustoTeoricoTeorico) / dPrecoVendaTeorico, 0)
                    txtMargemTeorico.Value = dMargemTeorico
                    txtGPTeorico.Value = dGPTeorico
                    txtPrecoVendaTeorico.Value = dPrecoVendaTeorico
                    txtPrecoUnidadeTeorico.Value = dPrecoVendaTeorico / txtQuantidadeUnidade.Value

                Case "txtGPTeorico"
                    If dGPTeorico >= 1 Then txtGPTeorico.Value = 0.99 : dGPTeorico = 0.99
                    dPrecoVendaTeorico = dCustoTeoricoTeorico / (1 - dGPTeorico)
                    dMargemTeorico = IIf(dCustoTeoricoTeorico > 0, (dPrecoVendaTeorico - dCustoTeoricoTeorico) / dCustoTeoricoTeorico, 0)
                    dMarkupTeorico = IIf(dCustoTeoricoTeorico > 0, (dPrecoVendaTeorico / dCustoTeoricoTeorico), 0)
                    txtMargemTeorico.Value = dMargemTeorico
                    txtMarkupTeorico.Value = dMarkupTeorico
                    txtPrecoVendaTeorico.Value = dPrecoVendaTeorico
                    txtPrecoUnidadeTeorico.Value = dPrecoVendaTeorico / txtQuantidadeUnidade.Value

                Case "txtPrecoVendaTeorico"
                    dMargemTeorico = IIf(dCustoTeoricoTeorico > 0, (dPrecoVendaTeorico - dCustoTeoricoTeorico) / dCustoTeoricoTeorico, 0)
                    dMarkupTeorico = IIf(dCustoTeoricoTeorico > 0, (dPrecoVendaTeorico / dCustoTeoricoTeorico), 0)
                    dGPTeorico = IIf(dPrecoVendaTeorico > 0, (dPrecoVendaTeorico - dCustoTeoricoTeorico) / dPrecoVendaTeorico, 0)
                    txtMargemTeorico.Value = dMargemTeorico
                    txtGPTeorico.Value = dGPTeorico
                    txtMarkupTeorico.Value = dMarkupTeorico
                    txtPrecoUnidadeTeorico.Value = txtPrecoVendaTeorico.Value / txtQuantidadeUnidade.Value
                    
                Case "txtPrecoUnidadeTeorico"
                    dPrecoVendaTeorico = dPrecoUnidadeTeorico * txtQuantidadeUnidade.Value
                    dMargemTeorico = IIf(dCustoTeoricoTeorico > 0, (dPrecoVendaTeorico - dCustoTeoricoTeorico) / dCustoTeoricoTeorico, 0)
                    dMarkupTeorico = IIf(dCustoTeoricoTeorico > 0, (dPrecoVendaTeorico / dCustoTeoricoTeorico), 0)
                    dGPTeorico = IIf(dPrecoVendaTeorico > 0, (dPrecoVendaTeorico - dCustoTeoricoTeorico) / dPrecoVendaTeorico, 0)
                    txtMargemTeorico.Value = dMargemTeorico
                    txtGPTeorico.Value = dGPTeorico
                    txtMarkupTeorico.Value = dMarkupTeorico
                    txtPrecoUnidadeTeorico.Value = txtPrecoVendaTeorico.Value / txtQuantidadeUnidade.Value

            End Select

            'Remove Evento
            txtMargemMedio.Tag = ""
            txtGPMedio.Tag = ""
            txtMarkupMedio.Tag = ""
            txtPrecoVendaMedio.Tag = ""
            txtPrecoUnidadeMedio.Tag = ""
            txtMargemTeorico.Tag = ""
            txtGPTeorico.Tag = ""
            txtMarkupTeorico.Tag = ""
            txtPrecoVendaTeorico.Tag = ""
            txtPrecoUnidadeTeorico.Tag = ""

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmVenProdutoPrecoVenda_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Controles
            Call oClsCadProduto.LoadDadosProduto(lCodigoItem, _
                                                 iCodigoCliente, _
                                                 txtCodigo, _
                                                 txtDescricao, _
                                                 txtMarca, _
                                                 txtQuantidadeUnidade, _
                                                 txtCustoTeorico, _
                                                 txtMargemTeorico, _
                                                 txtMarkupTeorico, _
                                                 txtGPTeorico, _
                                                 txtPrecoVendaTeorico, _
                                                 txtPrecoUnidadeTeorico, _
                                                 txtCustoMedio, _
                                                 txtMargemMedio, _
                                                 txtMarkupMedio, _
                                                 txtGPMedio, _
                                                 txtPrecoVendaMedio, _
                                                 txtPrecoUnidadeMedio, _
                                                 txtRecomendacaoVenda, _
                                                 txtValorUltimaVenda, _
                                                 txtDataUltimaVenda, _
                                                 txtComprouSimilares, _
                                                 txtAtrasaPagamentos)

            'Adiciona ValueChanged
            Call AddValueChanged(Me, New DelegateValueChanged(AddressOf CalcularValor))

            txtCustoTeorico.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

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