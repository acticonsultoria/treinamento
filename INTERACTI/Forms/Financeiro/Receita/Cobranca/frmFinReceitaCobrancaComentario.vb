Imports Janus.Windows.GridEX

Public Class frmFinReceitaCobrancaComentario

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFinReceitaCobrancaInput As New clsFrmFinReceitaCobrancaComentario
    Private oGrid As GridEX

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

    Private Sub frmFinReceitaCobrancaComentario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown


        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFinReceitaCobrancaComentario_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If Validacao() = True Then
                'Salva Histórico
                Call SalvarHistorico()
                'Fecha o Formulário
                Me.Dispose()
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

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFinReceitaCobrancaComentario_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Controle
            txtNumeroDocumento.Text = oGrid.CurrentRow.Cells("numero_documento").Value
            txtCliente.Text = oGrid.CurrentRow.Cells("parceiro_negocio").Value
            txtParcela.Text = oGrid.CurrentRow.Cells("parcela").Value
            txtDataVencimento.Text = oGrid.CurrentRow.Cells("data_vencimento").Value
            txtValor.Text = oGrid.CurrentRow.Cells("valor_parcela").Value
            txtValorCorrigido.Text = oGrid.CurrentRow.Cells("valor_corrigido").Value

            'Seta Focu
            txtHistorico.Focus()

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

            'Salva Histórico de Cobrança
            oClsFinReceitaCobrancaInput.CodigoTituloCapa = oGrid.CurrentRow.Cells("codigo_titulo_capa").Value
            oClsFinReceitaCobrancaInput.NumeroParcela = oGrid.CurrentRow.Cells("numero_parcela").Value
            oClsFinReceitaCobrancaInput.Historico = txtHistorico.Text.Trim
            oClsFinReceitaCobrancaInput.Salvar()

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

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
                frmMain.errInfo.SetError(lblHistorico, "O Histórico de Cobrança deve possuir ao menos 15 Caracteres.")
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