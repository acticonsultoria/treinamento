Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrFinFluxoCaixa

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinFluxoCaixa As New clsUsrFinFluxoCaixa

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrFinFluxoCaixa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrFinFluxoCaixa_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: FLUXO CAIXA :::"

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "pagar" : Call Pagar()
                Case "cancelar" : Call CancelarPagamento()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.FinanceiroFluxoCaixa
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.EstoqueListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.FinanceiroFluxoCaixa)

            'Carrega Combo
            'Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FinanceiroFluxoCaixa, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFinFluxoCaixa_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Controles
            dtpDataInicioFiltro.Value = Now.Date : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False
            Call LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroFluxoCaixa)

            'Seta Focu
            dtpDataInicioFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FLUXO CAIXA :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            oClsFinFluxoCaixa.LoadGrid(grdListagem, _
                                       grdFluxoCaixaMensal, _
                                       IIf(dtpDataInicioFiltro.Checked = True, Format(dtpDataInicioFiltro.Value, "dd/MM/yyyy"), ""), _
                                       IIf(dtpDataTerminoFiltro.Checked = True, Format(dtpDataTerminoFiltro.Value, "dd/MM/yyyy"), ""), _
                                       IIf(cboContaBancaria.SelectedIndex <> -1, cboContaBancaria.SelectedValue, -1))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PARCELA :::"

    Private Sub Pagar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica o Tipo do Título
            If grdListagem.CurrentRow.Cells("codigo_tipo_titulo_financeiro").Value <> CInt(TipoTituloFinanceiro.Previsto) Then

                'Verifica se o usuário tem direito de alterar algum registro
                If VerificaDireito(Formulario.FinanceiroDespesaPagamento, gcInsert) = True And grdListagem.CurrentRow.Cells("tipo").Value = "D" Then
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.DireitoInserir)
                    Exit Sub
                End If

                'Verifica se o usuário tem direito de alterar algum registro
                If VerificaDireito(Formulario.FinanceiroReceitaPagamento, gcInsert) = True And grdListagem.CurrentRow.Cells("tipo").Value = "R" Then
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.DireitoInserir)
                    Exit Sub
                End If

                'Abre Formulário de Cadastro
                Dim oForm As New frmCadBasico
                oForm.UsrControl = IIf(grdListagem.CurrentRow.Cells("tipo").Value = "D", "usrFinDespesaPagamento", "usrFinReceitaPagamento")
                oForm.Titulo = "Financeiro - " & IIf(grdListagem.CurrentRow.Cells("tipo").Value = "D", "Despesa", "Receita") & " - Baixar Duplicatas"
                oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location: oForm.Tamanho = True

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCNumeroDocumento As New DataColumn("numero_documento")
                Dim oDCParcela As New DataColumn("parcela")
                Dim oDCDescritivo As New DataColumn("descritivo")
                Dim oDCDataVencimento As New DataColumn("data_vencimento")
                Dim oDCValorTotal As New DataColumn("valor_total")
                Dim oDCValorPago As New DataColumn("valor_pago")
                Dim oDCJuros As New DataColumn("juros")
                Dim oDCDesconto As New DataColumn("desconto")
                Dim oDCValorDevido As New DataColumn("valor_devido")
                Dim oDCCodigoTituloCapa As New DataColumn("codigo_titulo_capa")
                Dim oDCNumeroParcela As New DataColumn("numero_parcela")

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCNumeroDocumento)
                oDataTable.Columns.Add(oDCParcela)
                oDataTable.Columns.Add(oDCDescritivo)
                oDataTable.Columns.Add(oDCDataVencimento)
                oDataTable.Columns.Add(oDCValorTotal)
                oDataTable.Columns.Add(oDCValorPago)
                oDataTable.Columns.Add(oDCJuros)
                oDataTable.Columns.Add(oDCDesconto)
                oDataTable.Columns.Add(oDCValorDevido)
                oDataTable.Columns.Add(oDCCodigoTituloCapa)
                oDataTable.Columns.Add(oDCNumeroParcela)
                'Seta DataType
                oDCDataVencimento.DataType = Now.Date.GetType
                oDCValorTotal.DataType = 0.0.GetType
                oDCValorPago.DataType = 0.0.GetType
                oDCJuros.DataType = 0.0.GetType
                oDCDesconto.DataType = 0.0.GetType
                oDCValorDevido.DataType = 0.0.GetType

                'Adiciona Linhas ao DataTable
                Dim oDataRow As DataRow = oDataTable.NewRow
                oDataRow("numero_documento") = grdListagem.CurrentRow.Cells("numero_documento").Value
                oDataRow("parcela") = grdListagem.CurrentRow.Cells("parcela").Value
                oDataRow("descritivo") = grdListagem.CurrentRow.Cells("descritivo").Value
                oDataRow("data_vencimento") = grdListagem.CurrentRow.Cells("data_vencimento").Value
                oDataRow("valor_total") = grdListagem.CurrentRow.Cells("valor").Value
                oDataRow("valor_pago") = grdListagem.CurrentRow.Cells("valor_pago").Value
                oDataRow("juros") = grdListagem.CurrentRow.Cells("juros").Value
                oDataRow("desconto") = grdListagem.CurrentRow.Cells("desconto").Value
                oDataRow("valor_devido") = grdListagem.CurrentRow.Cells("valor").Value - grdListagem.CurrentRow.Cells("desconto").Value + grdListagem.CurrentRow.Cells("juros").Value - grdListagem.CurrentRow.Cells("valor_pago").Value
                oDataRow("codigo_titulo_capa") = grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value
                oDataRow("numero_parcela") = grdListagem.CurrentRow.Cells("numero_parcela").Value
                oDataTable.Rows.Add(oDataRow)

                'Seta Parâmetros
                Dim oFormularioCadastroBasico(0) As FormularioCadastroBasico
                oFormularioCadastroBasico(0).oValor = oDataSet : oFormularioCadastroBasico(0).sControle = "grdParcela"
                oForm.CadastroBasico = oFormularioCadastroBasico

                'Abre o Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Carrega a Grid
                Call LoadGrid()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CancelarPagamento()

        Try

            'Verifica se a Parcela já está paga
            If grdListagem.CurrentRow.Cells("valor_pago").Value > 0 Then

                'Verifica se o Tipo do Título é Despesa
                If grdListagem.CurrentRow.Cells("tipo").Value = "D" Then

                    'Verifica se o usuário tem direito de alterar algum registro
                    If VerificaDireito(Formulario.FinanceiroDespesaPagamentoCancelar, gcAdministrator) = True Then

                        'Verifica se o Usuário deseja Cancelar o Pagamento
                        If MsgBox("Deseja realmente Cancelar o Pagamento dessa Parcela?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                            'Váriavel - Classe
                            Dim oClsFinDespesaCancelarPagamento As New clsUsrFinDespesaCancelarPagamento

                            'Cancela o Pagamento
                            oClsFinDespesaCancelarPagamento.CancelarPagamentoIndividual(grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value, _
                                                                                        grdListagem.CurrentRow.Cells("numero_parcela").Value)

                            'Carrega Grid
                            Call LoadGrid()

                        End If

                    Else
                        'Informa o Usuário que ele não tem Direito
                        frmMain.Informacao(Mensagem.DireitoAdministrador)
                    End If

                ElseIf grdListagem.CurrentRow.Cells("tipo").Value = "R" Then

                    'Verifica se o usuário tem direito de alterar algum registro
                    If VerificaDireito(Formulario.FinanceiroReceitaPagamentoCancelar, gcAdministrator) = True Then

                        'Verifica se o Usuário deseja Cancelar o Pagamento
                        If MsgBox("Deseja realmente Cancelar o Pagamento dessa Parcela?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                            'Váriavel - Classe
                            Dim oClsFinReceitaCancelarPagamento As New clsUsrFinReceitaCancelarPagamento

                            'Cancela o Pagamento
                            oClsFinReceitaCancelarPagamento.CancelarPagamentoIndividual(grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value, _
                                                                                        grdListagem.CurrentRow.Cells("numero_parcela").Value)

                            'Carrega Grid
                            Call LoadGrid()

                        End If

                    Else
                        'Informa o Usuário que ele não tem Direito
                        frmMain.Informacao(Mensagem.DireitoAdministrador)
                    End If

                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

    Private Sub btnExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Try

            'Exporta Planilha para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

End Class
