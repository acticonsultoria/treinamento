Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports System.Math


Public Class usrFinReceitaPagamento

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinReceitaPagamento As New clsUsrFinReceitaPagamento
    Private bClienteUnico As Boolean
    Private iCodigoCliente As Integer
    Private dSaldoCliente As Double = 0

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"
    Private Sub cboContaBancaria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboContaBancaria.SelectedIndexChanged

        Try

            'Verifia se foi Selecionado Algum Registro
            If cboContaBancaria.Text = "" Then

                'Limpa Controles
                cboTipoDocumentoPagamento.DataSource = Nothing : cboTipoDocumentoPagamento.Text = ""

            Else
                'Carrega Combo
                Call LoadCombo(cboTipoDocumentoPagamento, "sp_select_combo_static_tipo_documento_pagamento 'R', " & cboContaBancaria.SelectedValue, True)

                'Habilita / Desabilita Controle
                cboTipoDocumentoPagamento.Enabled = IIf(cboTipoDocumentoPagamento.Items.Count = 1, False, True)

                If cboContaBancaria.SelectedValue = 0 Then
                    dSaldoCliente = CType(ExecuteQueryReturn("sp_select_financeiro_adiantamento_saldo_dados " & goUsuario.iEmpresa & ", " & iCodigoCliente & ", 'R'"), Double)
                Else
                    dSaldoCliente = 0
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadastrarCartaoCredito_Click(sender As Object, e As EventArgs) Handles btnCadastrarCartaoCredito.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCartaoCredito")

            'Carrega Combo            
            If cboContaBancaria.SelectedIndex = -1 Then
                cboCartaoCredito.DataSource = Nothing : cboCartaoCredito.Text = ""
            Else
                Call LoadCombo(cboCartaoCredito, "sp_select_combo_cadastro_basico_cartao_credito " & goUsuario.iEmpresa & ", " & cboContaBancaria.SelectedValue, False)
            End If


            'Seta Focu
            cboContaBancaria.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub usrFinReceitaPagamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCartaoCredito" : Call cboContaBancaria_SelectedIndexChanged(cboContaBancaria, System.EventArgs.Empty)
                        Case "cboContaBancaria" : Call LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)
                        Case "cboNumeroDocumentoChequeTerceiro" : Call LoadCombo(cboNumeroDocumentoChequeTerceiro, "sp_select_combo_financeiro_receita_cheque_terceiro " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboContaBancaria" : Call btnCadastrarContaBancaria_Click(btnCadastrarContaBancaria, System.EventArgs.Empty)
                        Case "cboCartaoCredito" : Call btnCadastrarCartaoCredito_Click(btnCadastrarCartaoCredito, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFinReceitaPagamento_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: LISTAGEM :::"

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdListagem.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdListagem.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdListagem.GroupByBoxVisible = True
                grdListagem.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

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
            oForm.NomeFormulario = Formulario.FinanceiroReceitaPagamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaPagamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click


        Try

            'Exportar para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formúlário
            If Validacao() = True Then
                'Salva Pagamento
                Call Salvar()
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 1
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowCheckStateChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles grdListagem.RowCheckStateChanged

        Try

            'Calcula Valor Total Selecionado
            lblValorTitulo.Text = "R$ " & FormatNumber(CalculaValorTotalSelecionado(grdListagem), 2, Microsoft.VisualBasic.TriState.True)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.FinanceiroReceitaPagamento)

            'Carrega Coluna
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FinanceiroReceitaPagamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FinanceiroReceitaPagamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PARCELA :::"

    Private Sub btnAgruparGridParcela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridParcela.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdParcela.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdParcela.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdParcela.GroupByBoxVisible = True
                grdParcela.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridParcela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridParcela.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdParcela
            oForm.NomeFormulario = Formulario.FinanceiroReceitaPagamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura GridParcela
            Call ConfiguraGrid(grdParcela, Formulario.FinanceiroReceitaPagamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridParcela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridParcela.Click


        Try

            'Exportar para Excel
            Call ExportExcel(grdParcela)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdParcela_CellEdited(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdParcela.CellEdited

        Try

            Select Case e.Column.Key

                Case "desconto", "juros", "multa" : Call CalculaValorDevido()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdParcela_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdParcela.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdParcela, _
                                     Formulario.FinanceiroReceitaPagamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdParcela_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdParcela.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdParcela.Name, _
                                     Formulario.FinanceiroReceitaPagamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdParcela_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdParcela.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdParcela.Name, _
                                          Formulario.FinanceiroReceitaPagamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PAGAMENTO :::"

    Private Sub btnVincularCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVincularCheque.Click

        Try

            'Verifica se foi Selecionado o Campo - Tipo Documento 
            If ValidaCampo(cboTipoDocumentoPagamento, lblTipoDocumentoPagamento) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Conta Bancária
            If ValidaCampo(cboContaBancaria, lblContaBancaria) = False Then
                Exit Sub
            End If

            'Váriavel - Formulário
            Dim oForm As New frmFinReceitaVincularCheque

            'Seta Parâmetros
            oForm.ValorDevido = grdParcela.GetTotalRow.Cells.Item("valor_total").Value
            oForm.CodigoTipoDocumentoPagamento = cboTipoDocumentoPagamento.SelectedValue
            oForm.CodigoContaBancaria = cboContaBancaria.SelectedValue

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Atualiza Grid
            oClsFinReceitaPagamento.LoadGridPagamento(grdPagamento)

            'Percorre os registros
            For i As Integer = 0 To grdParcela.RecordCount - 1

                grdParcela.Row = i

                grdParcela.SetValue("valor_pago", grdParcela.GetValue("valor_total"))

            Next

            Call CalculaValorPago()

            txtValorChequeAscon.Value = grdParcela.GetTotalRow.Cells("valor_devido").Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridPagamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridPagamento.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdPagamento.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdPagamento.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdPagamento.GroupByBoxVisible = True
                grdPagamento.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridPagamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridPagamento.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdPagamento
            oForm.NomeFormulario = Formulario.FinanceiroReceitaPagamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura GridPagamento
            Call ConfiguraGrid(grdPagamento, Formulario.FinanceiroReceitaPagamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridPagamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridPagamento.Click


        Try

            'Exportar para Excel
            Call ExportExcel(grdPagamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaBancaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaBancaria.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadBancoConta")

            'Carrega Combo            
            LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)

            'Seta Focu
            cboContaBancaria.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirPagamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirPagamento.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoPagamento() = True Then

                Select Case LoadFormTipoDocumentoPagamento(cboTipoDocumentoPagamento.SelectedValue, _
                                                           "sp_select_static_form_tipo_documento_pagamento_receita")

                    Case "grpBoleto"
                        Call InsertPagamento(grdPagamento, _
                                             cboContaBancaria.Text, _
                                             cboTipoDocumentoPagamento.Text, _
                                             txtNumeroBoleto1.Text & " " & txtNumeroBoleto2.Text & " " & txtNumeroBoleto3.Text & " " & txtNumeroBoleto4.Text & " " & txtNumeroBoleto5.Text & " " & txtNumeroBoleto6.Text & " " & txtNumeroBoleto7.Text & " " & txtNumeroBoleto8.Text, _
                                             dtpDataPagamentoBoleto.Value, _
                                             txtValorBoleto.Value, _
                                             0, _
                                             0,
                                             txtBancoBoleto.Text.Trim, _
                                             "", _
                                             -1, _
                                             "", _
                                             cboContaBancaria.SelectedValue, _
                                             cboTipoDocumentoPagamento.SelectedValue, _
                                             -1, _
                                             -1, _
                                             -1, _
                                             StatusReceitaPagamento.Quitado, _
                                             "", _
                                             IIf(IsNumeric(btnInserirPagamento.Tag), btnInserirPagamento.Tag, grdPagamento.GetDataRows.Count + 1))

                    Case "grpOutros"
                        Call InsertPagamento(grdPagamento, _
                                             cboContaBancaria.Text, _
                                             cboTipoDocumentoPagamento.Text, _
                                             txtNumeroDocumentoOutros.Text.Trim, _
                                             dtpDataPagamentoOutros.Value, _
                                             txtValorOutros.Value, _
                                             0, _
                                             0,
                                             "", _
                                             "", _
                                             -1, _
                                             "", _
                                             cboContaBancaria.SelectedValue, _
                                             cboTipoDocumentoPagamento.SelectedValue, _
                                             -1, _
                                             -1, _
                                             -1, _
                                             StatusReceitaPagamento.Quitado, _
                                             "", _
                                             IIf(IsNumeric(btnInserirPagamento.Tag), btnInserirPagamento.Tag, grdPagamento.GetDataRows.Count + 1))

                    Case "grpDescontoDuplicata"
                        Call InsertPagamento(grdPagamento, _
                                             cboContaBancaria.Text, _
                                             cboTipoDocumentoPagamento.Text, _
                                             txtNumeroDocumentoDescontoDuplicata.Text.Trim, _
                                             dtpDataPagamentoDescontoDuplicata.Value, _
                                             txtValorDescontoDuplicata.Value, _
                                             txtJurosDescontoDuplicata.Value, _
                                             0,
                                             "", _
                                             "", _
                                             -1, _
                                             "", _
                                             cboContaBancaria.SelectedValue, _
                                             cboTipoDocumentoPagamento.SelectedValue, _
                                             -1, _
                                             -1, _
                                             -1, _
                                             StatusReceitaPagamento.Quitado, _
                                             "", _
                                             IIf(IsNumeric(btnInserirPagamento.Tag), btnInserirPagamento.Tag, grdPagamento.GetDataRows.Count + 1))

                    Case "grpOutrosSimples"
                        Call InsertPagamento(grdPagamento, _
                                             cboContaBancaria.Text, _
                                             cboTipoDocumentoPagamento.Text, _
                                             "", _
                                             dtpDataPagamentoOutrosSimples.Value, _
                                             txtValorOutrosSimples.Value, _
                                             0, _
                                             0,
                                             "", _
                                             "", _
                                             -1, _
                                             "", _
                                             cboContaBancaria.SelectedValue, _
                                             cboTipoDocumentoPagamento.SelectedValue, _
                                             -1, _
                                             -1, _
                                             -1, _
                                             StatusReceitaPagamento.Quitado, _
                                             "", _
                                             IIf(IsNumeric(btnInserirPagamento.Tag), btnInserirPagamento.Tag, grdPagamento.GetDataRows.Count + 1))

                    Case "grpCheque"

                        'Valida Número Cheque
                        If oClsFinReceitaPagamento.ValidaCheque(txtNumeroDocumentoCheque.Text.Trim) = False Then

                            If MsgBox("Já existe um cheque com esse número no sistema. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                                txtNumeroDocumentoCheque.Focus()
                                Exit Sub

                            Else

                                Call InsertPagamento(grdPagamento, _
                                                     cboContaBancaria.Text, _
                                                     cboTipoDocumentoPagamento.Text, _
                                                     txtNumeroDocumentoCheque.Text.Trim, _
                                                     dtpDataPagamentoCheque.Value, _
                                                     txtValorCheque.Value, _
                                                     0, _
                                                     0,
                                                     "", _
                                                     txtFavorecidoCheque.Text.Trim, _
                                                     IIf(cboPreDatadoCheque.SelectedValue = True, 1, 0), _
                                                     IIf(dtpDataCompensacaoCheque.Visible = True, dtpDataCompensacaoCheque.Value, ""), _
                                                     cboContaBancaria.SelectedValue, _
                                                     cboTipoDocumentoPagamento.SelectedValue, _
                                                     -1, _
                                                     -1, _
                                                     -1, _
                                                     StatusReceitaPagamento.ChequeNaoCompensado, _
                                                     "", _
                                                     IIf(IsNumeric(btnInserirPagamento.Tag), btnInserirPagamento.Tag, grdPagamento.GetDataRows.Count + 1))

                            End If

                        Else

                            Call InsertPagamento(grdPagamento, _
                                                 cboContaBancaria.Text, _
                                                 cboTipoDocumentoPagamento.Text, _
                                                 txtNumeroDocumentoCheque.Text.Trim, _
                                                 dtpDataPagamentoCheque.Value, _
                                                 txtValorCheque.Value, _
                                                 0, _
                                                 0,
                                                 "", _
                                                 txtFavorecidoCheque.Text.Trim, _
                                                 IIf(cboPreDatadoCheque.SelectedValue = True, 1, 0), _
                                                 IIf(dtpDataCompensacaoCheque.Visible = True, dtpDataCompensacaoCheque.Value, ""), _
                                                 cboContaBancaria.SelectedValue, _
                                                 cboTipoDocumentoPagamento.SelectedValue, _
                                                 -1, _
                                                 -1, _
                                                 -1, _
                                                 StatusReceitaPagamento.ChequeNaoCompensado, _
                                                 "", _
                                                 IIf(IsNumeric(btnInserirPagamento.Tag), btnInserirPagamento.Tag, grdPagamento.GetDataRows.Count + 1))

                        End If

                    Case "grpSaldoCliente"
                        Call InsertPagamento(grdPagamento, _
                                             cboContaBancaria.Text, _
                                             cboTipoDocumentoPagamento.Text, _
                                             "", _
                                             dtpDataPagamentoSaldoCliente.Value, _
                                             txtValorSaldoCliente.Value, _
                                              0, _
                                              0, _
                                             "", _
                                             "", _
                                             -1, _
                                             "", _
                                             cboContaBancaria.SelectedValue, _
                                             cboTipoDocumentoPagamento.SelectedValue, _
                                             -1, _
                                             -1, _
                                             -1, _
                                             StatusReceitaPagamento.Quitado, _
                                             "", _
                                             IIf(IsNumeric(btnInserirPagamento.Tag), btnInserirPagamento.Tag, grdPagamento.GetDataRows.Count + 1))

                    Case "grpChequeTerceiro"

                        Dim sCodigo() As String = cboNumeroDocumentoChequeTerceiro.SelectedValue.ToString.Split("|")

                        Call InsertPagamento(grdPagamento, _
                                             cboContaBancaria.Text, _
                                             cboTipoDocumentoPagamento.Text, _
                                             cboNumeroDocumentoChequeTerceiro.Text.Trim, _
                                             dtpDataPagamentoChequeTerceiro.Value, _
                                             txtValorChequeTerceiro.Value, _
                                             0, _
                                             0,
                                             txtBancoChequeTerceiro.Text.Trim, _
                                             "", _
                                             -1, _
                                             "", _
                                             cboContaBancaria.SelectedValue, _
                                             cboTipoDocumentoPagamento.SelectedValue, _
                                             sCodigo(0), _
                                             sCodigo(1), _
                                             sCodigo(2), _
                                             StatusReceitaPagamento.ChequeNaoCompensado, _
                                             "", _
                                             IIf(IsNumeric(btnInserirPagamento.Tag), btnInserirPagamento.Tag, grdPagamento.GetDataRows.Count + 1))
                    Case "grpChequeAscon"
                        Call InsertPagamentoAscon(grdPagamento, _
                                             cboContaBancaria.Text, _
                                             cboTipoDocumentoPagamento.Text, _
                                             txtSeuNumeroAscon.Text.Trim, _
                                             dtpDataPagamentoAscon.Value, _
                                             txtValorChequeAscon.Value, _
                                             0, _
                                             0,
                                             "", _
                                             txtFavorecidoAscon.Text.Trim, _
                                             IIf(cboPreDatadoAscon.SelectedValue = True, 1, 0), _
                                             IIf(dtpDataPreDatadoAscon.Visible = True, dtpDataPreDatadoAscon.Value, ""), _
                                             cboContaBancaria.SelectedValue, _
                                             cboTipoDocumentoPagamento.SelectedValue, _
                                             -1, _
                                             -1, _
                                             -1, _
                                             StatusReceitaPagamento.ChequeNaoCompensado, _
                                             "", _
                                             txtCPFEmitenteAscon.Text, _
                                             txtNomeEmitenteAscon.Text, _
                                             txtBandaMagneticaAscon1.Text & " " & txtBandaMagneticaAscon2.Text & " " & txtBandaMagneticaAscon3.Text, _
                                             IIf(IsNumeric(btnInserirPagamento.Tag), btnInserirPagamento.Tag, grdPagamento.GetDataRows.Count + 1))
                    Case "grpCartaoCredito"
                        Call InsertPagamentoCartaoCredito(grdPagamento, _
                                             cboContaBancaria.Text, _
                                             cboTipoDocumentoPagamento.Text, _
                                             "", _
                                             dtpDataPagamentoCartaoCredito.Value, _
                                             txtValorCartaoCredito.Value, _
                                             "", _
                                             "", _
                                             -1, _
                                             "", _
                                             cboContaBancaria.SelectedValue, _
                                             cboTipoDocumentoPagamento.SelectedValue, _
                                             -1, _
                                             -1, _
                                             -1, _
                                             StatusDespesaPagamento.ChequeNaoCompensado, _
                                             "", _
                                             cboCartaoCredito.SelectedValue, _
                                             txtNumeroParcelaCartaoCredito.Value, _
                                             IIf(IsNumeric(btnInserirPagamento.Tag), btnInserirPagamento.Tag, grdPagamento.GetDataRows.Count + 1))
                End Select

                'Calcula Valor Pago
                Call CalculaValorPago()

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoPagamento()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirPagamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirPagamento.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta Kit
            Call DeletePagamento()

            'Calcula Valor Pago
            Call CalculaValorPago()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnPagar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar1.Click

        Try

      
            grdPagamento.DataSource = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi Selecionado algum Registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Carrega Grid
                Call LoadGridDuplicatas(grdParcela)

                'Carrega Combo - Conta Bancária
                Call LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa & ", " & IIf(bClienteUnico = True, iCodigoCliente, -1) & ", 'R'", True)
                Call LoadComboGrid(grdPagamento, "codigo_banco_conta", "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa & ", " & IIf(bClienteUnico = True, iCodigoCliente, -1) & ", 'R'", True)

                'Limpa Formulário
                cboContaBancaria.SelectedIndex = -1
                cboTipoDocumentoPagamento.SelectedIndex = -1
                grdPagamento.DataSource = Nothing
                btnInserirPagamento.Tag = ""
                btnPagar.Tag = 0

                'Alterna Aba                
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Habilita Botão
                btnPagar.Enabled = True

                'Seta Focu
                cboContaBancaria.Focus()

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        'Carrega Grid
        Call LoadGrid()

        'Alterna Aba
        tabMain.TabPages.Add(pagListagem)
        tabMain.TabPages.Remove(pagDados)

        'Seta Focu
        txtNumeroDocumentoFiltro.Focus()

    End Sub

    Private Sub cboTipoDocumentoPagamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocumentoPagamento.SelectedIndexChanged

        Try

            'Oculta Controles
            grpBoleto.Visible = False
            grpCheque.Visible = False
            grpChequeTerceiro.Visible = False
            grpOutros.Visible = False
            grpOutrosSimples.Visible = False
            grpDescontoDuplicata.Visible = False
            grpCartaoCredito.Visible = False
            grpSaldoCliente.Visible = False

            'Váriaveis Locais
            Dim dValorDevido As Double

            'Seta Valor Devido
            dValorDevido = grdParcela.GetTotalRow.Cells("valor_devido").Value
            If grdPagamento.GetDataRows.Count > 0 Then dValorDevido -= grdPagamento.GetTotalRow.Cells("valor").Value
            If dValorDevido < 0 Then dValorDevido = 0

            'Carrega o Tipo de Documento de Pagamento
            If cboTipoDocumentoPagamento.SelectedIndex <> -1 Then

                'Torna Controle Visivel
                GetControlByName(LoadFormTipoDocumentoPagamento(cboTipoDocumentoPagamento.SelectedValue, _
                                                                "sp_select_static_form_tipo_documento_pagamento_receita"), Me).Visible = True

                If grpBoleto.Visible = True Then
                    'Limpa Controles - Boleto
                    dtpDataPagamentoBoleto.Value = Now.Date
                    txtValorBoleto.Value = dValorDevido
                    txtNumeroBoleto1.Text = ""
                    txtNumeroBoleto2.Text = ""
                    txtNumeroBoleto3.Text = ""
                    txtNumeroBoleto4.Text = ""
                    txtNumeroBoleto5.Text = ""
                    txtNumeroBoleto6.Text = ""
                    txtNumeroBoleto7.Text = ""
                    txtNumeroBoleto8.Text = ""
                    txtBancoBoleto.Text = ""
                    grpChequeAscon.Visible = False
                    If bSistemaPerforma = True Then
                        btnVincularCheque.Visible = False
                    End If
                ElseIf grpCheque.Visible = True Then
                    'Limpa Controles - Cheque
                    dtpDataPagamentoCheque.Value = Now.Date
                    txtValorCheque.Value = dValorDevido
                    txtNumeroDocumentoCheque.Text = ""
                    txtFavorecidoCheque.Text = ""
                    cboPreDatadoCheque.SelectedValue = False
                    lblDataCompensacaoCheque.Visible = False
                    dtpDataCompensacaoCheque.Visible = False
                    dtpDataCompensacaoCheque.Value = Now.Date
                    grpChequeAscon.Visible = False
                    If bSistemaPerforma = True Then
                        btnVincularCheque.Visible = True
                    End If
                ElseIf grpChequeTerceiro.Visible = True Then
                    'Limpa Controles - Cheque de Terceiro
                    Call LoadCombo(cboNumeroDocumentoChequeTerceiro, "sp_select_combo_financeiro_titulo_cheque_terceiro " & goUsuario.iEmpresa)
                    cboNumeroDocumentoChequeTerceiro.SelectedIndex = -1
                    grpChequeAscon.Visible = False
                    If bSistemaPerforma = True Then
                        btnVincularCheque.Visible = True
                    End If
                ElseIf grpOutros.Visible = True Then
                    'Limpa Controles - Outros
                    dtpDataPagamentoOutros.Value = Now.Date
                    txtValorOutros.Value = dValorDevido
                    txtNumeroDocumentoOutros.Text = ""
                    grpChequeAscon.Visible = False
                    If bSistemaPerforma = True Then
                        btnVincularCheque.Visible = False
                    End If
                ElseIf grpOutrosSimples.Visible = True Then
                    'Limpa Controles - Outros Simples
                    dtpDataPagamentoOutrosSimples.Value = Now.Date
                    txtValorOutrosSimples.Value = dValorDevido
                    grpChequeAscon.Visible = False
                    If bSistemaPerforma = True Then
                        btnVincularCheque.Visible = False
                    End If
                ElseIf grpCartaoCredito.Visible = True Then
                    'Carrega Combo
                    'Call LoadCombo(cboCartaoCredito, "sp_select_combo_cadastro_basico_bandeira_cartao_credito " & goUsuario.iEmpresa, False)
                    dtpDataPagamentoCartaoCredito.Value = Now.Date
                    txtValorCartaoCredito.Value = dValorDevido
                    txtNumeroParcelaCartaoCredito.Value = 1
                    grpChequeAscon.Visible = False
                    If bSistemaPerforma = True Then
                        btnVincularCheque.Visible = False
                    End If
                ElseIf grpChequeAscon.Visible = True Then
                    'Carrega Combo
                    txtSeuNumeroAscon.Text = ""
                    dtpDataPagamentoAscon.Value = Now.Date
                    txtFavorecidoAscon.Text = ""
                    txtValorChequeAscon.Value = 0
                    cboPreDatadoAscon.SelectedIndex = -1
                    dtpDataPreDatadoAscon.Value = Now.Date
                    txtBandaMagneticaAscon1.Text = ""
                    txtCPFEmitenteAscon.Text = ""
                    txtNomeEmitenteAscon.Text = ""
                    If bSistemaPerforma = True Then
                        btnVincularCheque.Visible = False
                    End If
                ElseIf grpSaldoCliente.Visible = True Then
                    dtpDataPagamentoSaldoCliente.Value = Now.Date
                    txtValorSaldoCliente.Value = dValorDevido
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboPreDatadoCheque_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPreDatadoCheque.SelectedIndexChanged

        Try

            'Oculta Controles
            lblDataCompensacaoCheque.Visible = False
            dtpDataCompensacaoCheque.Visible = False

            'Exibe Controles
            If cboPreDatadoCheque.SelectedValue = True Then
                lblDataCompensacaoCheque.Visible = True
                dtpDataCompensacaoCheque.Visible = True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboNumeroDocumentoChequeTerceiro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNumeroDocumentoChequeTerceiro.SelectedIndexChanged

        Try

            'Carrega Dados do Cheque de Terceiro
            If cboNumeroDocumentoChequeTerceiro.SelectedIndex <> -1 Then

                Dim sCodigo() As String = cboNumeroDocumentoChequeTerceiro.SelectedValue.ToString.Split("|")

                'Carrega Dados do Cheque de Terceiro
                Call oClsFinReceitaPagamento.LoadDadosChequeTerceiro(sCodigo(0), _
                                                                     sCodigo(1), _
                                                                     sCodigo(2), _
                                                                     txtBancoChequeTerceiro, _
                                                                     txtDataRecebimentoChequeTerceiro, _
                                                                     txtPreDatadoChequeTerceiro, _
                                                                     txtValorChequeTerceiro)

            Else

                txtBancoChequeTerceiro.Text = ""
                txtDataRecebimentoChequeTerceiro.Text = ""
                txtPreDatadoChequeTerceiro.Text = ""
                txtValorChequeTerceiro.Text = ""

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdPagamento_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdPagamento.RowDoubleClick

        Try

            'Verifica o Tipo de Operação
            Select Case grdPagamento.CurrentColumn.Key

                Case "editar" : Call EditarPagamento()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdPagamento_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdPagamento.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPagamento, _
                                     Formulario.FinanceiroReceitaPagamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdPagamento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdPagamento.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPagamento.Name, _
                                     Formulario.FinanceiroReceitaPagamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdPagamento_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdPagamento.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdPagamento.Name, _
                                          Formulario.FinanceiroReceitaPagamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub TratarBoletoBancario(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumeroBoleto1.TextChanged, _
                                                                                                  txtNumeroBoleto2.TextChanged, _
                                                                                                  txtNumeroBoleto3.TextChanged, _
                                                                                                  txtNumeroBoleto4.TextChanged, _
                                                                                                  txtNumeroBoleto5.TextChanged, _
                                                                                                  txtNumeroBoleto6.TextChanged, _
                                                                                                  txtNumeroBoleto7.TextChanged, _
                                                                                                  txtNumeroBoleto8.TextChanged

        Try

            If sender.MaxLength = sender.Text.Length Then

                SendKeys.Send("{TAB}")

                If sender.Name = "txtNumeroBoleto8" Then
                    dtpDataPagamentoBoleto.Value = DateAdd(DateInterval.Day, CLng(Mid(sender.text, 1, 4)), gcDateInicioBoleto)
                    txtValorBoleto.Value = CDbl(Mid(sender.text, 5)) / 100
                End If

            ElseIf sender.Name = "txtNumeroBoleto1" Then
                If sender.Text.Length >= 3 Then
                    txtBancoBoleto.Text = LoadDadosBanco(Mid(sender.Text, 1, 3))
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFinReceitaPagamento_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnPagar1.Enabled = VerificaDireito(Formulario.FinanceiroReceitaPagamento, gcInsert)
            btnInserirPagamento.Enabled = VerificaDireito(Formulario.FinanceiroReceitaPagamento, gcInsert)
            btnExcluirPagamento.Enabled = VerificaDireito(Formulario.FinanceiroReceitaPagamento, gcDelete)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.FinanceiroReceitaPagamento, gcPrint)
            btnExcelGridParcela.Enabled = VerificaDireito(Formulario.FinanceiroReceitaPagamento, gcPrint)
            btnExcelGridPagamento.Enabled = VerificaDireito(Formulario.FinanceiroReceitaPagamento, gcPrint)

            'Verifica Direito - Botão de Cadastro
            btnCadastrarContaBancaria.Enabled = VerificaDireito(Formulario.CadastroBasicoBancoConta, gcInsert)

            'Carrega ComboBox
            Call LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)
            Call LoadCombo(cboTipoDocumentoPagamento, "sp_select_combo_static_tipo_documento_pagamento")
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)
            Call LoadComboSimNao(cboPreDatadoCheque)
            Call LoadComboSimNao(cboPreDatadoAscon)
            Call LoadComboSimNao(cboAdiantamentoFiltro) : cboAdiantamentoFiltro.SelectedValue = False
            Call LoadComboSimNao(cboTituloAVistaFiltro)

            'Seta DateTimer
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataVencimentoInicioFiltro.Value = Now.Date : dtpDataVencimentoInicioFiltro.Checked = False
            dtpDataVencimentoTerminoFiltro.Value = Now.Date : dtpDataVencimentoTerminoFiltro.Checked = False
            dtpDataReferenciaFiltro.Value = Now.Date

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaPagamento)
            Call ConfiguraGrid(grdParcela, Formulario.FinanceiroReceitaPagamento)
            Call ConfiguraGrid(grdPagamento, Formulario.FinanceiroReceitaPagamento)

            'Seta Aba / Focu
            If Me.Tag = "NOVO" Then
                tabMain.TabPages.Remove(pagListagem)
                cboContaBancaria.Focus()
            Else
                tabMain.TabPages.Remove(pagDados)
                txtNumeroDocumentoFiltro.Focus()
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: LISTAGEM :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            oClsFinReceitaPagamento.LoadGrid(grdListagem, _
                                             txtNumeroDocumentoFiltro.Text.Trim, _
                                             IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                             IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                             txtClienteFiltro.Text.Trim, _
                                             IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                             IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                             txtValorFiltro.Value, _
                                             dtpDataReferenciaFiltro.Value, _
                                             IIf(cboAdiantamentoFiltro.SelectedIndex = -1, False, cboAdiantamentoFiltro.SelectedValue), _
                                             IIf(cboTituloAVistaFiltro.SelectedIndex = -1, -1, IIf(cboTituloAVistaFiltro.SelectedValue = True, 1, 0)))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function CalculaValorTotalSelecionado(ByVal oGrid As GridEX) As Double

        Try

            'Variaveis Locais
            Dim dTotal As Double = 0

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            For Each oRow As GridEXRow In oGrid.GetCheckedRows
                dTotal += oRow.Cells("valor_corrigido").Value
            Next

            'Seta Retorno da Função
            Return dTotal

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Function

#End Region

#Region "::: PARCELA :::"

    Private Sub LoadGridDuplicatas(ByVal oGrid As GridEX)

        Try

            'Limpa Grid
            oGrid.DataSource = Nothing

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDCNumeroDocumento As New DataColumn("numero_documento")
            Dim oDCDataEmissao As New DataColumn("data_emissao")
            Dim oDCParcela As New DataColumn("parcela")
            Dim oDCCodigoParceiroNegocio As New DataColumn("codigo_parceiro_negocio")
            Dim oDCParceiroNegocio As New DataColumn("parceiro_negocio")
            Dim oDCDescritivo As New DataColumn("descritivo")
            Dim oDCDataVencimento As New DataColumn("data_vencimento")
            Dim oDCValorTotal As New DataColumn("valor_total")
            Dim oDCValorPago As New DataColumn("valor_pago")
            Dim oDCJuros As New DataColumn("juros")
            Dim oDCMulta As New DataColumn("multa")
            Dim oDCDesconto As New DataColumn("desconto")
            Dim oDCValorDevido As New DataColumn("valor_devido")
            Dim oDCCodigoTituloCapa As New DataColumn("codigo_titulo_capa")
            Dim oDCNumeroParcela As New DataColumn("numero_parcela")

            'Seta DataType
            oDCDataVencimento.DataType = Now.Date.GetType
            oDCValorTotal.DataType = 0.0.GetType
            oDCValorPago.DataType = 0.0.GetType
            oDCJuros.DataType = 0.0.GetType
            oDCMulta.DataType = 0.0.GetType
            oDCDesconto.DataType = 0.0.GetType
            oDCValorDevido.DataType = 0.0.GetType

            'Adiciona Tabela ao DataSet
            oDataSet.Tables.Add(oDataTable)

            'Adiciona Colunas ao DataTable
            oDataTable.Columns.Add(oDCNumeroDocumento)
            oDataTable.Columns.Add(oDCDataEmissao)
            oDataTable.Columns.Add(oDCParcela)
            oDataTable.Columns.Add(oDCDescritivo)
            oDataTable.Columns.Add(oDCParceiroNegocio)
            oDataTable.Columns.Add(oDCDataVencimento)
            oDataTable.Columns.Add(oDCCodigoParceiroNegocio)
            oDataTable.Columns.Add(oDCValorTotal)
            oDataTable.Columns.Add(oDCValorPago)
            oDataTable.Columns.Add(oDCJuros)
            oDataTable.Columns.Add(oDCMulta)
            oDataTable.Columns.Add(oDCDesconto)
            oDataTable.Columns.Add(oDCValorDevido)
            oDataTable.Columns.Add(oDCCodigoTituloCapa)
            oDataTable.Columns.Add(oDCNumeroParcela)

            'Adiciona Linhas ao DataTable
            For Each oRow As GridEXRow In gSelecaoRow
                Dim oDataRow As DataRow = oDataTable.NewRow
                oDataRow("numero_documento") = oRow.Cells("numero_documento").Value
                oDataRow("data_emissao") = oRow.Cells("data_emissao").Value
                oDataRow("parcela") = oRow.Cells("parcela").Value
                oDataRow("parceiro_negocio") = oRow.Cells("parceiro_negocio").Value
                oDataRow("descritivo") = oRow.Cells("descritivo").Value
                oDataRow("data_vencimento") = oRow.Cells("data_vencimento").Value
                oDataRow("codigo_parceiro_negocio") = oRow.Cells("codigo_parceiro_negocio").Value
                oDataRow("valor_total") = oRow.Cells("valor").Value
                oDataRow("valor_pago") = oRow.Cells("valor_pago").Value
                oDataRow("juros") = oRow.Cells("juros").Value
                oDataRow("multa") = IIf(IsNothing(oRow.Cells("multa").Value) = True, DBNull.Value, oRow.Cells("multa").Value)
                oDataRow("desconto") = oRow.Cells("desconto").Value
                oDataRow("valor_devido") = oRow.Cells("valor_corrigido").Value - oRow.Cells("valor_pago").Value
                oDataRow("codigo_titulo_capa") = oRow.Cells("codigo_titulo_capa").Value
                oDataRow("numero_parcela") = oRow.Cells("numero_parcela").Value
                oDataTable.Rows.Add(oDataRow)
            Next

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega GRid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            'Seta Váriavel
            bClienteUnico = True
            iCodigoCliente = 0

            'Verifica se existe somente um Cliente
            For Each oRow As GridEXRow In oGrid.GetDataRows
                If oRow.Cells("codigo_parceiro_negocio").Value <> iCodigoCliente And iCodigoCliente <> 0 Then
                    bClienteUnico = False
                End If
                If iCodigoCliente = 0 Then
                    iCodigoCliente = oRow.Cells("codigo_parceiro_negocio").Value
                End If
            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PAGAMENTO :::"

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Pagar Parcela
            oClsFinReceitaPagamento.UpdateParcela(grdParcela, btnPagar.Tag)

            'Pagar Parcela
            oClsFinReceitaPagamento.InsertPagamento(grdParcela, grdPagamento)

            'Obtém Linhas
            For Each oRow As GridEXRow In grdPagamento.GetDataRows

                'Verifica o Tipo de Pagamento
                If oRow.Cells("codigo_tipo_documento_pagamento").Value = CInt(TipoDocumentoPagamento.DuplicataDescontada) Then

                    'Váriavel Local
                    Dim lCodigoTituloDespesa As Long = 0
                    Dim lCodigoTituloReceita As Long = 0

                    'Insere Registro de Duplicata
                    oClsFinReceitaPagamento.InsertDuplicataDescontada(oRow.Cells("codigo_banco_conta").Value, _
                                                                      oRow.Cells("valor").Value, _
                                                                      oRow.Cells("data_pagamento").Value, _
                                                                      oRow.Cells("numero_documento").Value, _
                                                                      grdParcela.GetTotalRow.Cells("valor_devido").Value, _
                                                                      lCodigoTituloDespesa, _
                                                                      lCodigoTituloReceita)

                    'Insere Registro de Duplicata x Parcela
                    For Each oRowParcela As GridEXRow In grdParcela.GetDataRows
                        oClsFinReceitaPagamento.InsertDuplicataDescontadaParcela(lCodigoTituloReceita, _
                                                                                 lCodigoTituloDespesa, _
                                                                                 oRowParcela.Cells("codigo_titulo_capa").Value, _
                                                                                 oRowParcela.Cells("numero_parcela").Value, _
                                                                                 oRow.Cells("codigo_banco_conta").Value)
                    Next

                End If
            Next

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Desabilita Botão
            btnPagar.Enabled = False

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CalculaValorDevido()

        Try

            'Calcula Valor Devido
            grdParcela.SetValue("valor_devido", grdParcela.CurrentRow.Cells("valor_total").Value - _
                                                grdParcela.CurrentRow.Cells("desconto").Value + _
                                                grdParcela.CurrentRow.Cells("juros").Value +
                                                grdParcela.CurrentRow.Cells("multa").Value)

            'Calcula Valor Pago
            Call CalculaValorPago()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaValorPago()

        Try

            'Verifica se ja ocorreu algum Pagamento
            If grdPagamento.GetDataRows.Count = 0 Then

                For Each oRow As GridEXRow In grdParcela.GetDataRows
                    grdParcela.Row = oRow.RowIndex
                    grdParcela.SetValue("valor_pago", 0)
                Next

            Else

                'Váriaveis Locais
                Dim i As Integer
                Dim oRowParcela() As GridEXRow = grdParcela.GetDataRows
                Dim dValorPago As Double = grdPagamento.GetTotalRow.Cells("valor").Value

                For i = 0 To UBound(oRowParcela)

                    grdParcela.Row = oRowParcela(i).RowIndex

                    If grdParcela.GetValue("valor_devido") > dValorPago Then
                        grdParcela.SetValue("valor_pago", dValorPago)
                        dValorPago = 0
                    ElseIf grdParcela.GetValue("valor_devido") = dValorPago Then
                        grdParcela.SetValue("valor_pago", grdParcela.GetValue("valor_devido"))
                        dValorPago -= grdParcela.GetValue("valor_devido")
                    ElseIf grdParcela.GetValue("valor_devido") < dValorPago Then
                        grdParcela.SetValue("valor_pago", grdParcela.GetValue("valor_devido"))
                        dValorPago -= grdParcela.GetValue("valor_devido")
                    End If

                    'Calcula Valor Devido
                    grdParcela.SetValue("valor_devido", IIf(IsDBNull(grdParcela.CurrentRow.Cells("valor_total").Value), 0, grdParcela.CurrentRow.Cells("valor_total").Value) - _
                                                        IIf(IsDBNull(grdParcela.CurrentRow.Cells("desconto").Value), 0, grdParcela.CurrentRow.Cells("desconto").Value) + _
                                                        IIf(IsDBNull(grdParcela.CurrentRow.Cells("juros").Value), 0, grdParcela.CurrentRow.Cells("juros").Value) +
                                                        IIf(IsDBNull(grdParcela.CurrentRow.Cells("multa").Value), 0, grdParcela.CurrentRow.Cells("multa").Value))

                    'Atualiza Linha
                    grdParcela.Refresh()

                Next

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoPagamento()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Váriaveis Locais
            Dim dValorDevido As Double

            'Seta Valor Devido
            dValorDevido = grdParcela.GetTotalRow.Cells("valor_devido").Value
            If grdPagamento.GetDataRows.Count > 0 Then dValorDevido -= grdPagamento.GetTotalRow.Cells("valor").Value
            If dValorDevido < 0 Then dValorDevido = 0

            If grpBoleto.Visible = True Then

                'Limpa Controles - Boleto
                dtpDataPagamentoBoleto.Value = Now.Date
                txtValorBoleto.Value = dValorDevido
                txtNumeroBoleto1.Text = ""
                txtNumeroBoleto2.Text = ""
                txtNumeroBoleto3.Text = ""
                txtNumeroBoleto4.Text = ""
                txtNumeroBoleto5.Text = ""
                txtNumeroBoleto6.Text = ""
                txtNumeroBoleto7.Text = ""
                txtNumeroBoleto8.Text = ""
                txtBancoBoleto.Text = ""
                'Seta Focu
                txtNumeroBoleto1.Focus()

            ElseIf grpCheque.Visible = True Then

                'Limpa Controles - Cheque
                dtpDataPagamentoCheque.Value = Now.Date
                txtValorCheque.Value = dValorDevido
                txtNumeroDocumentoCheque.Text = ""
                txtFavorecidoCheque.Text = ""
                cboPreDatadoCheque.SelectedValue = False
                cboPreDatadoCheque.SelectedValue = False
                lblDataCompensacaoCheque.Visible = False
                dtpDataCompensacaoCheque.Visible = False
                dtpDataCompensacaoCheque.Value = Now.Date
                'Seta Focu
                txtNumeroDocumentoCheque.Focus()

            ElseIf grpChequeTerceiro.Visible = True Then

                'Limpa Controles - Cheque de Terceiro
                cboNumeroDocumentoChequeTerceiro.SelectedIndex = -1
                'Seta Focu
                cboNumeroDocumentoChequeTerceiro.Focus()

            ElseIf grpDescontoDuplicata.Visible = True Then

                'Limpa Controles
                txtNumeroDocumentoDescontoDuplicata.Text = ""
                dtpDataPagamentoDescontoDuplicata.Value = Now.Date
                txtValorDescontoDuplicata.Value = 0
                txtJurosDescontoDuplicata.Value = 0

            ElseIf grpOutros.Visible = True Then

                'Limpa Controles - Outros
                dtpDataPagamentoOutros.Value = Now.Date
                txtValorOutros.Value = dValorDevido
                txtNumeroDocumentoOutros.Text = ""
                'Seta Focu
                txtNumeroDocumentoOutros.Focus()

            ElseIf grpOutrosSimples.Visible = True Then

                'Limpa Controles - Outros Simples
                dtpDataPagamentoOutrosSimples.Value = Now.Date
                txtValorOutrosSimples.Value = dValorDevido
                'Seta Focu
                dtpDataPagamentoOutrosSimples.Focus()

            ElseIf grpSaldoCliente.Visible = True Then

                'Limpa Controles - Outros Simples
                dtpDataPagamentoSaldoCliente.Value = Now.Date
                txtValorSaldoCliente.Value = dValorDevido
                'Seta Focu
                dtpDataPagamentoSaldoCliente.Focus()

            End If

            btnInserirPagamento.Tag = ""

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarPagamento()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroReceitaPagamento, gcUpdate) = True Then

                With grdPagamento.CurrentRow.Cells

                    Call NovoPagamento()

                    Select Case LoadFormTipoDocumentoPagamento(cboTipoDocumentoPagamento.SelectedValue, _
                                                               "sp_select_static_form_tipo_documento_pagamento_receita")

                        Case "grpBoleto"
                            'Carrega Controles
                            cboContaBancaria.SelectedValue = .Item("codigo_banco_conta").Value
                            cboTipoDocumentoPagamento.SelectedValue = .Item("codigo_tipo_documento_pagamento").Value
                            Dim sNumeroDocumento() As String = .Item("numero_documento").Value.ToString.Split(" ")
                            txtNumeroBoleto1.Text = sNumeroDocumento(0)
                            txtNumeroBoleto2.Text = sNumeroDocumento(1)
                            txtNumeroBoleto3.Text = sNumeroDocumento(2)
                            txtNumeroBoleto4.Text = sNumeroDocumento(3)
                            txtNumeroBoleto5.Text = sNumeroDocumento(4)
                            txtNumeroBoleto6.Text = sNumeroDocumento(5)
                            txtNumeroBoleto7.Text = sNumeroDocumento(6)
                            txtNumeroBoleto8.Text = sNumeroDocumento(7)
                            dtpDataPagamentoBoleto.Value = .Item("data_pagamento").Value
                            txtValorBoleto.Value = .Item("valor").Value
                            btnInserirPagamento.Tag = .Item("codigo").Value
                            'Seta Focu
                            txtNumeroBoleto1.Focus()

                        Case "grpOutros"
                            'Carrega Controles
                            cboContaBancaria.SelectedValue = .Item("codigo_banco_conta").Value
                            cboTipoDocumentoPagamento.SelectedValue = .Item("codigo_tipo_documento_pagamento").Value
                            txtNumeroDocumentoOutros.Text = .Item("numero_documento").Value
                            dtpDataPagamentoOutros.Value = .Item("data_pagamento").Value
                            txtValorOutros.Value = .Item("valor").Value
                            btnInserirPagamento.Tag = .Item("codigo").Value
                            'Seta Focu
                            txtNumeroDocumentoOutros.Focus()

                        Case "grpDescontoDuplicata"
                            'Carrega Controles
                            cboContaBancaria.SelectedValue = .Item("codigo_banco_conta").Value
                            cboTipoDocumentoPagamento.SelectedValue = .Item("codigo_tipo_documento_pagamento").Value
                            txtNumeroDocumentoDescontoDuplicata.Text = .Item("numero_documento").Value
                            dtpDataPagamentoDescontoDuplicata.Value = .Item("data_pagamento").Value
                            txtValorDescontoDuplicata.Value = .Item("valor").Value
                            txtJurosDescontoDuplicata.Value = .Item("juros").Value
                            btnInserirPagamento.Tag = .Item("codigo").Value
                            'Seta Focu
                            txtNumeroDocumentoDescontoDuplicata.Focus()

                        Case "grpOutrosSimples"
                            'Carrega Controles
                            cboContaBancaria.SelectedValue = .Item("codigo_banco_conta").Value
                            cboTipoDocumentoPagamento.SelectedValue = .Item("codigo_tipo_documento_pagamento").Value
                            dtpDataPagamentoOutrosSimples.Value = .Item("data_pagamento").Value
                            txtValorOutrosSimples.Value = .Item("valor").Value
                            btnInserirPagamento.Tag = .Item("codigo").Value
                            'Seta Focu
                            dtpDataPagamentoOutrosSimples.Focus()

                        Case "grpCheque"
                            'Carrega Controles
                            cboContaBancaria.SelectedValue = .Item("codigo_banco_conta").Value
                            cboTipoDocumentoPagamento.SelectedValue = .Item("codigo_tipo_documento_pagamento").Value
                            txtNumeroDocumentoCheque.Text = .Item("numero_documento").Value
                            dtpDataPagamentoCheque.Value = .Item("data_pagamento").Value
                            txtValorCheque.Value = .Item("valor").Value
                            txtFavorecidoCheque.Text = .Item("favorecido").Value
                            cboPreDatadoCheque.SelectedValue = .Item("pre_datado").Value
                            dtpDataCompensacaoCheque.Value = .Item("data_pre_datado").Value
                            btnInserirPagamento.Tag = .Item("codigo").Value
                            'Seta Focu
                            txtNumeroDocumentoCheque.Focus()

                        Case "grpChequeTerceiro"
                            'Carrega Controles
                            cboContaBancaria.SelectedValue = .Item("codigo_banco_conta").Value
                            cboTipoDocumentoPagamento.SelectedValue = .Item("codigo_tipo_documento_pagamento").Value
                            cboNumeroDocumentoChequeTerceiro.SelectedValue = CStr(.Item("codigo_titulo_capa_receita").Value & "|" & .Item("codigo_titulo_parcela_pagamento_receita").Value & "|" & .Item("numero_parcela_receita").Value)
                            'Seta Focu
                            cboNumeroDocumentoChequeTerceiro.Focus()
                        Case "grpChequeAscon"
                            'Carrega Controles
                            cboContaBancaria.SelectedValue = .Item("codigo_banco_conta").Value
                            cboTipoDocumentoPagamento.SelectedValue = .Item("codigo_tipo_documento_pagamento").Value
                            Dim sNumeroDocumento() As String = .Item("banda_magnetica").Value.ToString.Split(" ")
                            txtBandaMagneticaAscon1.Text = sNumeroDocumento(0)
                            txtBandaMagneticaAscon2.Text = sNumeroDocumento(1)
                            txtBandaMagneticaAscon3.Text = sNumeroDocumento(2)
                            dtpDataPagamentoAscon.Value = .Item("data_pagamento").Value
                            txtFavorecidoAscon.Text = .Item("favorecido").Value
                            txtValorChequeAscon.Value = .Item("valor_cheque").Value
                            cboPreDatadoAscon.SelectedValue = .Item("pre_datado").Value
                            dtpDataPreDatadoAscon.Value = .Item("data_pre_datado").Value
                            txtCPFEmitenteAscon.Text = .Item("cpf_emitente").Value
                            txtNomeEmitenteAscon.Text = .Item("nome_emitente").Value()
                            'Seta Focu
                            txtNumeroBoleto1.Focus()
                    End Select

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub InsertPagamentoCartaoCredito(ByVal oGrid As GridEX, _
                               ByVal sContaBancaria As String, _
                               ByVal sTipoDocumentoPagamento As String, _
                               ByVal sNumeroDocumento As String, _
                               ByVal sDataPagamento As String, _
                               ByVal dValor As Double, _
                               ByVal sBanco As String, _
                               ByVal sFavorecido As String, _
                               ByVal iPreDatado As Integer, _
                               ByVal sDataPreDatado As String, _
                               ByVal iCodigoBancoConta As Integer, _
                               ByVal iCodigoTipoDocumentoPagamento As Integer, _
                               ByVal lCodigoTituloCapaReceita As Long, _
                               ByVal iCodigoTituloParcelaPagamentoReceita As Integer, _
                               ByVal iNumeroParcelaReceita As Integer, _
                               ByVal iStatus As Integer, _
                               ByVal sEmitente As String, _
                               ByVal iCodigoCartaoCredito As Integer, _
                               ByVal iNumeroParcelaCartaoCredito As Integer, _
                               ByVal iCodigo As Integer)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow

            Dim oDCContaBancaria As New DataColumn("conta_bancaria")
            Dim oDCTipoDocumentoPagamento As New DataColumn("tipo_documento_pagamento")
            Dim oDCNumeroDocumento As New DataColumn("numero_documento")
            Dim oDCDataPagamento As New DataColumn("data_pagamento")
            Dim oDCValor As New DataColumn("valor")
            Dim oDCValorAssociado As New DataColumn("valor_associado")
            Dim oDCBanco As New DataColumn("banco")
            Dim oDCFavorecido As New DataColumn("favorecido")
            Dim oDCPreDatado As New DataColumn("pre_datado")
            Dim oDCDataPreDatado As New DataColumn("data_pre_datado")
            Dim oDCCodigoBancoConta As New DataColumn("codigo_banco_conta")
            Dim oDCCodigoTipoDocumentoPagamento As New DataColumn("codigo_tipo_documento_pagamento")
            Dim oDCCodigoTituloCapaReceita As New DataColumn("codigo_titulo_capa_receita")
            Dim oDCCodigoTituloParcelaPagamentoReceita As New DataColumn("codigo_titulo_parcela_pagamento_receita")
            Dim oDCNumeroParcelaReceita As New DataColumn("numero_parcela_receita")
            Dim oDCStatus As New DataColumn("status")
            Dim oDCEmitente As New DataColumn("emitente")
            Dim oDCCodigoCartaoCredito As New DataColumn("codigo_cartao_credito")
            Dim oDCNumeroParcelaCartaoCredito As New DataColumn("numero_parcela_cartao_credito")
            Dim oDCCodigo As New DataColumn("codigo")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCContaBancaria)
                oDataTable.Columns.Add(oDCTipoDocumentoPagamento)
                oDataTable.Columns.Add(oDCNumeroDocumento)
                oDataTable.Columns.Add(oDCDataPagamento)
                oDataTable.Columns.Add(oDCValor)
                oDataTable.Columns.Add(oDCValorAssociado)
                oDataTable.Columns.Add(oDCBanco)
                oDataTable.Columns.Add(oDCFavorecido)
                oDataTable.Columns.Add(oDCPreDatado)
                oDataTable.Columns.Add(oDCDataPreDatado)
                oDataTable.Columns.Add(oDCCodigoBancoConta)
                oDataTable.Columns.Add(oDCCodigoTipoDocumentoPagamento)
                oDataTable.Columns.Add(oDCCodigoTituloCapaReceita)
                oDataTable.Columns.Add(oDCCodigoTituloParcelaPagamentoReceita)
                oDataTable.Columns.Add(oDCNumeroParcelaReceita)
                oDataTable.Columns.Add(oDCStatus)
                oDataTable.Columns.Add(oDCEmitente)
                oDataTable.Columns.Add(oDCCodigoCartaoCredito)
                oDataTable.Columns.Add(oDCNumeroParcelaCartaoCredito)
                oDataTable.Columns.Add(oDCCodigo)
                'Seta DataType
                oDCDataPagamento.DataType = Now.Date.GetType
                oDCValor.DataType = 0.0.GetType
                oDCValorAssociado.DataType = 0.0.GetType
                oDCPreDatado.DataType = False.GetType
                oDCDataPreDatado.DataType = Now.Date.GetType
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirPagamento.Tag) = False Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("conta_bancaria") = sContaBancaria
                oDataRow("tipo_documento_pagamento") = sTipoDocumentoPagamento
                oDataRow("numero_documento") = sNumeroDocumento
                oDataRow("data_pagamento") = sDataPagamento
                oDataRow("valor") = dValor
                oDataRow("valor_associado") = 0
                oDataRow("banco") = IIf(sBanco = "", DBNull.Value, sBanco)
                oDataRow("favorecido") = IIf(sFavorecido = "", DBNull.Value, sFavorecido)
                oDataRow("pre_datado") = IIf(iPreDatado = -1, DBNull.Value, IIf(iPreDatado = 1, True, False))
                oDataRow("data_pre_datado") = IIf(IsDate(sDataPreDatado), sDataPreDatado, DBNull.Value)
                oDataRow("codigo_banco_conta") = iCodigoBancoConta
                oDataRow("codigo_tipo_documento_pagamento") = iCodigoTipoDocumentoPagamento
                oDataRow("codigo_titulo_capa_receita") = IIf(lCodigoTituloCapaReceita = -1, DBNull.Value, lCodigoTituloCapaReceita)
                oDataRow("codigo_titulo_parcela_pagamento_receita") = IIf(iCodigoTituloParcelaPagamentoReceita = -1, DBNull.Value, iCodigoTituloParcelaPagamentoReceita)
                oDataRow("numero_parcela_receita") = IIf(iNumeroParcelaReceita = -1, DBNull.Value, iNumeroParcelaReceita)
                oDataRow("codigo_cartao_credito") = IIf(iCodigoCartaoCredito = -1, DBNull.Value, iCodigoCartaoCredito)
                oDataRow("numero_parcela_cartao_credito") = IIf(iNumeroParcelaCartaoCredito = -1, DBNull.Value, iNumeroParcelaCartaoCredito)
                oDataRow("status") = iStatus
                oDataRow("emitente") = IIf(sEmitente = "", DBNull.Value, sEmitente)
                oDataRow("codigo") = iCodigo
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(codigo = " & btnInserirPagamento.Tag & ")")(0)
                oDataRow("conta_bancaria") = sContaBancaria
                oDataRow("tipo_documento_pagamento") = sTipoDocumentoPagamento
                oDataRow("numero_documento") = sNumeroDocumento
                oDataRow("data_pagamento") = sDataPagamento
                oDataRow("valor") = dValor
                oDataRow("valor_associado") = 0
                oDataRow("banco") = IIf(sBanco = "", DBNull.Value, sBanco)
                oDataRow("favorecido") = IIf(sFavorecido = "", DBNull.Value, sFavorecido)
                oDataRow("pre_datado") = IIf(iPreDatado = -1, DBNull.Value, IIf(iPreDatado = 1, True, False))
                oDataRow("data_pre_datado") = IIf(IsDate(sDataPreDatado), sDataPreDatado, DBNull.Value)
                oDataRow("codigo_banco_conta") = iCodigoBancoConta
                oDataRow("codigo_tipo_documento_pagamento") = iCodigoTipoDocumentoPagamento
                oDataRow("codigo_titulo_capa_receita") = IIf(lCodigoTituloCapaReceita = -1, DBNull.Value, lCodigoTituloCapaReceita)
                oDataRow("codigo_titulo_parcela_pagamento_receita") = IIf(iCodigoTituloParcelaPagamentoReceita = -1, DBNull.Value, iCodigoTituloParcelaPagamentoReceita)
                oDataRow("numero_parcela_receita") = IIf(iNumeroParcelaReceita = -1, DBNull.Value, iNumeroParcelaReceita)
                oDataRow("codigo_cartao_credito") = IIf(iCodigoCartaoCredito = -1, DBNull.Value, iCodigoCartaoCredito)
                oDataRow("numero_parcela_cartao_credito") = IIf(iNumeroParcelaCartaoCredito = -1, DBNull.Value, iNumeroParcelaCartaoCredito)
                oDataRow("status") = iStatus
                oDataRow("emitente") = IIf(sEmitente = "", DBNull.Value, sEmitente)
            End If

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InsertPagamento(ByVal oGrid As GridEX, _
                                ByVal sContaBancaria As String, _
                                ByVal sTipoDocumentoPagamento As String, _
                                ByVal sNumeroDocumento As String, _
                                ByVal sDataPagamento As String, _
                                ByVal dValor As Double, _
                                ByVal dJuros As Double, _
                                ByVal dMulta As Double, _
                                ByVal sBanco As String, _
                                ByVal sFavorecido As String, _
                                ByVal iPreDatado As Integer, _
                                ByVal sDataPreDatado As String, _
                                ByVal iCodigoBancoConta As Integer, _
                                ByVal iCodigoTipoDocumentoPagamento As Integer, _
                                ByVal lCodigoTituloCapaReceita As Long, _
                                ByVal iCodigoTituloParcelaPagamentoReceita As Integer, _
                                ByVal iNumeroParcelaReceita As Integer, _
                                ByVal iStatus As Integer, _
                                ByVal sEmitente As String, _
                                ByVal iCodigo As Integer)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow

            Dim oDCContaBancaria As New DataColumn("conta_bancaria")
            Dim oDCTipoDocumentoPagamento As New DataColumn("tipo_documento_pagamento")
            Dim oDCNumeroDocumento As New DataColumn("numero_documento")
            Dim oDCDataPagamento As New DataColumn("data_pagamento")
            Dim oDCValor As New DataColumn("valor")
            Dim oDCJuros As New DataColumn("juros")
            Dim oDCMulta As New DataColumn("multa")
            Dim oDCValorAssociado As New DataColumn("valor_associado")
            Dim oDCBanco As New DataColumn("banco")
            Dim oDCFavorecido As New DataColumn("favorecido")
            Dim oDCPreDatado As New DataColumn("pre_datado")
            Dim oDCDataPreDatado As New DataColumn("data_pre_datado")
            Dim oDCCodigoBancoConta As New DataColumn("codigo_banco_conta")
            Dim oDCCodigoTipoDocumentoPagamento As New DataColumn("codigo_tipo_documento_pagamento")
            Dim oDCCodigoTituloCapaReceita As New DataColumn("codigo_titulo_capa_receita")
            Dim oDCCodigoTituloParcelaPagamentoReceita As New DataColumn("codigo_titulo_parcela_pagamento_receita")
            Dim oDCNumeroParcelaReceita As New DataColumn("numero_parcela_receita")
            Dim oDCStatus As New DataColumn("status")
            Dim oDCEmitente As New DataColumn("emitente")
            Dim oDCCodigo As New DataColumn("codigo")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCContaBancaria)
                oDataTable.Columns.Add(oDCTipoDocumentoPagamento)
                oDataTable.Columns.Add(oDCNumeroDocumento)
                oDataTable.Columns.Add(oDCDataPagamento)
                oDataTable.Columns.Add(oDCValor)
                oDataTable.Columns.Add(oDCJuros)
                oDataTable.Columns.Add(oDCMulta)
                oDataTable.Columns.Add(oDCValorAssociado)
                oDataTable.Columns.Add(oDCBanco)
                oDataTable.Columns.Add(oDCFavorecido)
                oDataTable.Columns.Add(oDCPreDatado)
                oDataTable.Columns.Add(oDCDataPreDatado)
                oDataTable.Columns.Add(oDCCodigoBancoConta)
                oDataTable.Columns.Add(oDCCodigoTipoDocumentoPagamento)
                oDataTable.Columns.Add(oDCCodigoTituloCapaReceita)
                oDataTable.Columns.Add(oDCCodigoTituloParcelaPagamentoReceita)
                oDataTable.Columns.Add(oDCNumeroParcelaReceita)
                oDataTable.Columns.Add(oDCStatus)
                oDataTable.Columns.Add(oDCEmitente)
                oDataTable.Columns.Add(oDCCodigo)
                'Seta DataType
                oDCDataPagamento.DataType = Now.Date.GetType
                oDCValor.DataType = 0.0.GetType
                oDCJuros.DataType = 0.0.GetType
                oDCMulta.DataType = 0.0.GetType
                oDCValorAssociado.DataType = 0.0.GetType
                oDCDataPreDatado.DataType = Now.Date.GetType
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirPagamento.Tag) = False Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("conta_bancaria") = sContaBancaria
                oDataRow("tipo_documento_pagamento") = sTipoDocumentoPagamento
                oDataRow("numero_documento") = sNumeroDocumento
                oDataRow("data_pagamento") = sDataPagamento
                oDataRow("valor") = dValor
                oDataRow("juros") = dJuros
                oDataRow("multa") = dMulta
                oDataRow("valor_associado") = 0
                oDataRow("banco") = IIf(sBanco = "", DBNull.Value, sBanco)
                oDataRow("favorecido") = IIf(sFavorecido = "", DBNull.Value, sFavorecido)
                oDataRow("pre_datado") = IIf(iPreDatado = -1, DBNull.Value, iPreDatado)
                oDataRow("data_pre_datado") = IIf(IsDate(sDataPreDatado), sDataPreDatado, DBNull.Value)
                oDataRow("codigo_banco_conta") = iCodigoBancoConta
                oDataRow("codigo_tipo_documento_pagamento") = iCodigoTipoDocumentoPagamento
                oDataRow("codigo_titulo_capa_receita") = IIf(lCodigoTituloCapaReceita = -1, DBNull.Value, lCodigoTituloCapaReceita)
                oDataRow("codigo_titulo_parcela_pagamento_receita") = IIf(iCodigoTituloParcelaPagamentoReceita = -1, DBNull.Value, iCodigoTituloParcelaPagamentoReceita)
                oDataRow("numero_parcela_receita") = IIf(iNumeroParcelaReceita = -1, DBNull.Value, iNumeroParcelaReceita)
                oDataRow("status") = iStatus
                oDataRow("emitente") = IIf(sEmitente = "", DBNull.Value, sEmitente)
                oDataRow("codigo") = iCodigo
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(codigo = " & btnInserirPagamento.Tag & ")")(0)
                oDataRow("conta_bancaria") = sContaBancaria
                oDataRow("tipo_documento_pagamento") = sTipoDocumentoPagamento
                oDataRow("numero_documento") = sNumeroDocumento
                oDataRow("data_pagamento") = sDataPagamento
                oDataRow("valor") = dValor
                oDataRow("juros") = dJuros
                oDataRow("multa") = dMulta
                oDataRow("valor_associado") = 0
                oDataRow("banco") = IIf(sBanco = "", DBNull.Value, sBanco)
                oDataRow("favorecido") = IIf(sFavorecido = "", DBNull.Value, sFavorecido)
                oDataRow("pre_datado") = IIf(iPreDatado = -1, DBNull.Value, iPreDatado)
                oDataRow("data_pre_datado") = IIf(IsDate(sDataPreDatado), sDataPreDatado, DBNull.Value)
                oDataRow("codigo_banco_conta") = iCodigoBancoConta
                oDataRow("codigo_tipo_documento_pagamento") = iCodigoTipoDocumentoPagamento
                oDataRow("codigo_titulo_capa_receita") = IIf(lCodigoTituloCapaReceita = -1, DBNull.Value, lCodigoTituloCapaReceita)
                oDataRow("codigo_titulo_parcela_pagamento_receita") = IIf(iCodigoTituloParcelaPagamentoReceita = -1, DBNull.Value, iCodigoTituloParcelaPagamentoReceita)
                oDataRow("numero_parcela_receita") = IIf(iNumeroParcelaReceita = -1, DBNull.Value, iNumeroParcelaReceita)
                oDataRow("status") = iStatus
                oDataRow("emitente") = IIf(sEmitente = "", DBNull.Value, sEmitente)
            End If

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InsertPagamentoAscon(ByVal oGrid As GridEX, _
                             ByVal sContaBancaria As String, _
                             ByVal sTipoDocumentoPagamento As String, _
                             ByVal sNumeroDocumento As String, _
                             ByVal sDataPagamento As String, _
                             ByVal dValor As Double, _
                             ByVal dJuros As Double, _
                             ByVal dMulta As Double, _
                             ByVal sBanco As String, _
                             ByVal sFavorecido As String, _
                             ByVal iPreDatado As Integer, _
                             ByVal sDataPreDatado As String, _
                             ByVal iCodigoBancoConta As Integer, _
                             ByVal iCodigoTipoDocumentoPagamento As Integer, _
                             ByVal lCodigoTituloCapaReceita As Long, _
                             ByVal iCodigoTituloParcelaPagamentoReceita As Integer, _
                             ByVal iNumeroParcelaReceita As Integer, _
                             ByVal iStatus As Integer, _
                             ByVal sEmitente As String, _
                             ByVal sCPFEmitente As String, _
                             ByVal sNomeEmitente As String, _
                             ByVal sBandaMagnetica As String, _
                             ByVal iCodigo As Integer)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow

            Dim oDCContaBancaria As New DataColumn("conta_bancaria")
            Dim oDCTipoDocumentoPagamento As New DataColumn("tipo_documento_pagamento")
            Dim oDCNumeroDocumento As New DataColumn("numero_documento")
            Dim oDCDataPagamento As New DataColumn("data_pagamento")
            Dim oDCValor As New DataColumn("valor")
            Dim oDCJuros As New DataColumn("juros")
            Dim oDCMulta As New DataColumn("multa")
            Dim oDCValorAssociado As New DataColumn("valor_associado")
            Dim oDCBanco As New DataColumn("banco")
            Dim oDCFavorecido As New DataColumn("favorecido")
            Dim oDCPreDatado As New DataColumn("pre_datado")
            Dim oDCDataPreDatado As New DataColumn("data_pre_datado")
            Dim oDCCodigoBancoConta As New DataColumn("codigo_banco_conta")
            Dim oDCCodigoTipoDocumentoPagamento As New DataColumn("codigo_tipo_documento_pagamento")
            Dim oDCCodigoTituloCapaReceita As New DataColumn("codigo_titulo_capa_receita")
            Dim oDCCodigoTituloParcelaPagamentoReceita As New DataColumn("codigo_titulo_parcela_pagamento_receita")
            Dim oDCNumeroParcelaReceita As New DataColumn("numero_parcela_receita")
            Dim oDCStatus As New DataColumn("status")
            Dim oDCEmitente As New DataColumn("emitente")
            Dim oDCCPFEmitente As New DataColumn("cpf_emitente")
            Dim oDCNomeEmitente As New DataColumn("nome_emitente")
            Dim oDCBandaMagnetica As New DataColumn("banda_magnetica")
            Dim oDCCodigo As New DataColumn("codigo")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCContaBancaria)
                oDataTable.Columns.Add(oDCTipoDocumentoPagamento)
                oDataTable.Columns.Add(oDCNumeroDocumento)
                oDataTable.Columns.Add(oDCDataPagamento)
                oDataTable.Columns.Add(oDCValor)
                oDataTable.Columns.Add(oDCJuros)
                oDataTable.Columns.Add(oDCMulta)
                oDataTable.Columns.Add(oDCValorAssociado)
                oDataTable.Columns.Add(oDCBanco)
                oDataTable.Columns.Add(oDCFavorecido)
                oDataTable.Columns.Add(oDCPreDatado)
                oDataTable.Columns.Add(oDCDataPreDatado)
                oDataTable.Columns.Add(oDCCodigoBancoConta)
                oDataTable.Columns.Add(oDCCodigoTipoDocumentoPagamento)
                oDataTable.Columns.Add(oDCCodigoTituloCapaReceita)
                oDataTable.Columns.Add(oDCCodigoTituloParcelaPagamentoReceita)
                oDataTable.Columns.Add(oDCNumeroParcelaReceita)
                oDataTable.Columns.Add(oDCStatus)
                oDataTable.Columns.Add(oDCEmitente)
                oDataTable.Columns.Add(oDCCPFEmitente)
                oDataTable.Columns.Add(oDCNomeEmitente)
                oDataTable.Columns.Add(oDCBandaMagnetica)
                oDataTable.Columns.Add(oDCCodigo)
                'Seta DataType
                oDCDataPagamento.DataType = Now.Date.GetType
                oDCValor.DataType = 0.0.GetType
                oDCJuros.DataType = 0.0.GetType
                oDCMulta.DataType = 0.0.GetType
                oDCValorAssociado.DataType = 0.0.GetType
                oDCDataPreDatado.DataType = Now.Date.GetType
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirPagamento.Tag) = False Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("conta_bancaria") = sContaBancaria
                oDataRow("tipo_documento_pagamento") = sTipoDocumentoPagamento
                oDataRow("numero_documento") = sNumeroDocumento
                oDataRow("data_pagamento") = sDataPagamento
                oDataRow("valor") = dValor
                oDataRow("juros") = dJuros
                oDataRow("multa") = dMulta
                oDataRow("valor_associado") = 0
                oDataRow("banco") = IIf(sBanco = "", DBNull.Value, sBanco)
                oDataRow("favorecido") = IIf(sFavorecido = "", DBNull.Value, sFavorecido)
                oDataRow("pre_datado") = IIf(iPreDatado = -1, DBNull.Value, iPreDatado)
                oDataRow("data_pre_datado") = IIf(IsDate(sDataPreDatado), sDataPreDatado, DBNull.Value)
                oDataRow("codigo_banco_conta") = iCodigoBancoConta
                oDataRow("codigo_tipo_documento_pagamento") = iCodigoTipoDocumentoPagamento
                oDataRow("codigo_titulo_capa_receita") = IIf(lCodigoTituloCapaReceita = -1, DBNull.Value, lCodigoTituloCapaReceita)
                oDataRow("codigo_titulo_parcela_pagamento_receita") = IIf(iCodigoTituloParcelaPagamentoReceita = -1, DBNull.Value, iCodigoTituloParcelaPagamentoReceita)
                oDataRow("numero_parcela_receita") = IIf(iNumeroParcelaReceita = -1, DBNull.Value, iNumeroParcelaReceita)
                oDataRow("status") = iStatus
                oDataRow("emitente") = IIf(sEmitente = "", DBNull.Value, sEmitente)
                oDataRow("cpf_emitente") = IIf(sCPFEmitente = "", DBNull.Value, sCPFEmitente)
                oDataRow("nome_emitente") = IIf(sNomeEmitente = "", DBNull.Value, sNomeEmitente)
                oDataRow("banda_magnetica") = IIf(sBandaMagnetica = "", DBNull.Value, sBandaMagnetica)
                oDataRow("codigo") = iCodigo
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(codigo = " & btnInserirPagamento.Tag & ")")(0)
                oDataRow("conta_bancaria") = sContaBancaria
                oDataRow("tipo_documento_pagamento") = sTipoDocumentoPagamento
                oDataRow("numero_documento") = sNumeroDocumento
                oDataRow("data_pagamento") = sDataPagamento
                oDataRow("valor") = dValor
                oDataRow("juros") = dJuros
                oDataRow("multa") = dMulta
                oDataRow("valor_associado") = 0
                oDataRow("banco") = IIf(sBanco = "", DBNull.Value, sBanco)
                oDataRow("favorecido") = IIf(sFavorecido = "", DBNull.Value, sFavorecido)
                oDataRow("pre_datado") = IIf(iPreDatado = -1, DBNull.Value, iPreDatado)
                oDataRow("data_pre_datado") = IIf(IsDate(sDataPreDatado), sDataPreDatado, DBNull.Value)
                oDataRow("codigo_banco_conta") = iCodigoBancoConta
                oDataRow("codigo_tipo_documento_pagamento") = iCodigoTipoDocumentoPagamento
                oDataRow("codigo_titulo_capa_receita") = IIf(lCodigoTituloCapaReceita = -1, DBNull.Value, lCodigoTituloCapaReceita)
                oDataRow("codigo_titulo_parcela_pagamento_receita") = IIf(iCodigoTituloParcelaPagamentoReceita = -1, DBNull.Value, iCodigoTituloParcelaPagamentoReceita)
                oDataRow("numero_parcela_receita") = IIf(iNumeroParcelaReceita = -1, DBNull.Value, iNumeroParcelaReceita)
                oDataRow("cpf_emitente") = IIf(sCPFEmitente = "", DBNull.Value, sCPFEmitente)
                oDataRow("nome_emitente") = IIf(sNomeEmitente = "", DBNull.Value, sNomeEmitente)
                oDataRow("banda_magnetica") = IIf(sBandaMagnetica = "", DBNull.Value, sBandaMagnetica)
                oDataRow("status") = iStatus
                oDataRow("emitente") = IIf(sEmitente = "", DBNull.Value, sEmitente)
            End If

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeletePagamento()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdPagamento) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Linha
                    For Each oRow In gSelecaoRow
                        oRow.Delete()
                    Next

                    'Calcula Valor Devido
                    Call CalculaValorDevido()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Inserido algum Pagamento
            If grdPagamento.GetDataRows.Count = 0 Then
                frmMain.errInfo.SetError(lblContaBancaria, "Primeiramente Insira um ou mais Pagamento.")
                cboContaBancaria.Focus()
                Exit Function
            End If

            'Verifica se o Valor Devido é Menor que o Valor Pago
            If Round(grdParcela.GetTotalRow.Cells("valor_devido").Value, 2) <> Round(grdParcela.GetTotalRow.Cells("valor_pago").Value, 2) And _
               cboTipoDocumentoPagamento.SelectedValue <> CInt(TipoDocumentoPagamento.DuplicataDescontada) Then

                'Váriaveis - Form
                If goDatabase.sInitialCatalog = "INTERACTI_MAGMA_PRD" Then
                    Dim oForm As New frmFinTituloPagamentoMenorMagma
                    'Seta Parâmetro
                    oForm.lblTotalDesconto.Text = "R$ " & FormatNumber(grdParcela.GetTotalRow.Cells("desconto").Value, 2, Microsoft.VisualBasic.TriState.True)
                    oForm.lblTotalDevido.Text = "R$ " & FormatNumber(grdParcela.GetTotalRow.Cells("valor_devido").Value, 2, Microsoft.VisualBasic.TriState.True)
                    oForm.lblTotalJuros.Text = "R$ " & FormatNumber(grdParcela.GetTotalRow.Cells("juros").Value, 2, Microsoft.VisualBasic.TriState.True)
                    oForm.lblTotalPago.Text = "R$ " & FormatNumber(grdParcela.GetTotalRow.Cells("valor_pago").Value, 2, Microsoft.VisualBasic.TriState.True)
                    oForm.lblTotalTitulo.Text = "R$ " & FormatNumber(grdParcela.GetTotalRow.Cells("valor_total").Value, 2, Microsoft.VisualBasic.TriState.True)
                    oForm.lblSaldo.Text = "(SALDO     R$ " & FormatNumber(grdParcela.GetTotalRow.Cells("valor_pago").Value - grdParcela.GetTotalRow.Cells("valor_devido").Value, 2, Microsoft.VisualBasic.TriState.True) & ")"
                    oForm.Botao = btnPagar
                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)
                Else
                    Dim oForm As New frmFinTituloPagamentoMenor
                    'Seta Parâmetro
                    oForm.lblTotalDesconto.Text = "R$ " & FormatNumber(grdParcela.GetTotalRow.Cells("desconto").Value, 2, Microsoft.VisualBasic.TriState.True)
                    oForm.lblTotalDevido.Text = "R$ " & FormatNumber(grdParcela.GetTotalRow.Cells("valor_devido").Value, 2, Microsoft.VisualBasic.TriState.True)
                    oForm.lblTotalJuros.Text = "R$ " & FormatNumber(grdParcela.GetTotalRow.Cells("juros").Value, 2, Microsoft.VisualBasic.TriState.True)
                    oForm.lblTotalPago.Text = "R$ " & FormatNumber(grdParcela.GetTotalRow.Cells("valor_pago").Value, 2, Microsoft.VisualBasic.TriState.True)
                    oForm.lblTotalTitulo.Text = "R$ " & FormatNumber(grdParcela.GetTotalRow.Cells("valor_total").Value, 2, Microsoft.VisualBasic.TriState.True)
                    oForm.lblSaldo.Text = "(SALDO     R$ " & FormatNumber(grdParcela.GetTotalRow.Cells("valor_pago").Value - grdParcela.GetTotalRow.Cells("valor_devido").Value, 2, Microsoft.VisualBasic.TriState.True) & ")"
                    oForm.Botao = btnPagar
                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                End If


                'Verifica Opção Escolhida - Caso 0 sai da Validação
                If CInt(btnPagar.Tag) = 0 Then
                    Exit Function
                End If

            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoPagamento() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoPagamento = False

            'Verifica se foi Selecionado o Campo - Conta Bancária
            If ValidaCampo(cboContaBancaria, lblContaBancaria) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Documento de Pagamento
            If ValidaCampo(cboTipoDocumentoPagamento, lblTipoDocumentoPagamento) = False Then
                Exit Function
            End If

            'Váriaveis Locais
            Dim dValorPago As Double
            Dim dValorPagamento As Double = 0
            Dim dValorDevido As Double = grdParcela.GetTotalRow.Cells("valor_devido").Value

            If grdPagamento.GetDataRows.Count > 0 Then
                dValorPago = grdPagamento.GetTotalRow.Cells("valor").Value
            End If
            If IsNumeric(btnInserirPagamento.Tag) Then
                dValorPago -= grdPagamento.CurrentRow.Cells("valor").Value
            End If

            'Outros - Simples
            If grpOutrosSimples.Visible = True Then

                'Verifica se foi Preenchido o Campo - Valor
                If ValidaCampo(txtValorOutrosSimples, lblValorOutrosSimples, True) = False Then
                    Exit Function
                End If

                'Seta Valor Pagamento
                dValorPagamento = txtValorOutrosSimples.Value

            End If

            'Outros
            If grpOutros.Visible = True Then

                'Verifica se foi Preenchido o Campo - Número do Documento
                If ValidaCampo(txtNumeroDocumentoOutros, lblNumeroDocumentoOutros, TipoCampo.texto) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Valor
                If ValidaCampo(txtValorOutros, lblValorOutros, True) = False Then
                    Exit Function
                End If

                'Seta Valor Pagamento
                dValorPagamento = txtValorOutros.Value

            End If

            'Cheque
            If grpCheque.Visible = True Then

                'Verifica se foi Preenchido o Campo - Número do Cheque
                If ValidaCampo(txtNumeroDocumentoCheque, lblNumeroDocumentoCheque, TipoCampo.texto) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Valor
                If ValidaCampo(txtValorCheque, lblValorCheque, True) = False Then
                    Exit Function
                End If

                'Seta Valor Pagamento
                dValorPagamento = txtValorCheque.Value

            End If

            'Desconto de Duplicata
            If grpDescontoDuplicata.Visible = True Then

                'Verifica se foi Selecionado o Campo - Número do Documento
                If ValidaCampo(txtNumeroDocumentoDescontoDuplicata, lblNumeroDocumentoDescontoDuplicata, TipoCampo.texto) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Valor
                If ValidaCampo(txtValorDescontoDuplicata, lblValorDescontoDuplicata, True) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Juros
                If ValidaCampo(txtJurosDescontoDuplicata, lblJurosDescontoDuplicata, False) = False Then
                    Exit Function
                End If

            End If

            'Cheque de Terceiros
            If grpChequeTerceiro.Visible = True Then

                'Verifica se foi Selecionado o Campo - Número do Cheque
                If ValidaCampo(cboNumeroDocumentoChequeTerceiro, lblNumeroDocumentoChequeTerceiro) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Valor
                If ValidaCampo(txtValorChequeTerceiro, lblValorChequeTerceiro, True) = False Then
                    Exit Function
                End If

                'Seta Valor Pagamento
                dValorPagamento = txtValorChequeTerceiro.Value

            End If

            'Boleto Bancário
            If grpBoleto.Visible = True Then

                'Verifica se foi Preenchido o Campo - Boleto 1
                If ValidaCampo(txtNumeroBoleto1, lblBancoBoleto, TipoCampo.numero) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Boleto 2
                If ValidaCampo(txtNumeroBoleto2, lblBancoBoleto, TipoCampo.numero) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Boleto 3
                If ValidaCampo(txtNumeroBoleto3, lblBancoBoleto, TipoCampo.numero) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Boleto 4
                If ValidaCampo(txtNumeroBoleto4, lblBancoBoleto, TipoCampo.numero) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Boleto 5
                If ValidaCampo(txtNumeroBoleto5, lblBancoBoleto, TipoCampo.numero) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Boleto 6
                If ValidaCampo(txtNumeroBoleto6, lblBancoBoleto, TipoCampo.numero) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Boleto 7
                If ValidaCampo(txtNumeroBoleto7, lblBancoBoleto, TipoCampo.numero) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Valor Boleto
                If ValidaCampo(txtValorBoleto, lblValorBoleto, True) = False Then
                    Exit Function
                End If

                'Seta Valor Pagamento
                dValorPagamento = txtValorBoleto.Value

            End If

            'Cartão de Crédito
            If grpCartaoCredito.Visible = True Then

                ''Verifica se foi Selecionado o Campo - Máquina - Cartão
                'If ValidaCampo(cboMaquinaCartao, lblMaquinaCartao) = False Then
                '    Return False
                'End If

                ''Verifica se foi Selecionado o Campo - Bandeira - Cartão de Crédito
                'If ValidaCampo(cboBandeiraCartaoCredito, lblBandeiraCartaoCredito) = False Then
                '    Return False
                'End If

                'Verifica se foi Preenchido o Campo - Valor
                If ValidaCampo(txtValorCartaoCredito, lblValorCartaoCredito, True) = False Then
                    Return False
                End If

                'Verifica se foi Selecionado o Campo - Nº Parcelas
                If ValidaCampo(txtNumeroParcelaCartaoCredito, lblNumeroParcelaCartaoCredito, True) = False Then
                    Return False
                End If

                'Seta Valor Pagamento
                dValorPagamento = txtValorCartaoCredito.Value

            End If

            'Saldo Cliente
            If grpSaldoCliente.Visible = True Then

                'Verifica se foi Preenchido o Campo - Saldo Cliente
                If ValidaCampo(txtValorSaldoCliente, lblValorSaldoCliente, True) = False Then
                    Return False
                End If

                'Seta Valor Pagamento
                dValorPagamento = txtValorSaldoCliente.Value

                If dValorPagamento > dSaldoCliente Then
                    frmMain.errInfo.SetError(lblValorSaldoCliente, "O Valor informado é maior que o saldo no cliente.")
                    txtValorSaldoCliente.Focus()
                    Return False
                End If

                'Seta Valor Pagamento
                dValorPagamento = txtValorSaldoCliente.Value

            End If

            'Verifica se o Valor Pago é Válido
            If ((CDbl(FormatNumber(dValorPago, 2)) + CDbl(FormatNumber(dValorPagamento, 2))) - CDbl(FormatNumber(dValorDevido, 2))) > 0 Then

                'Verifica se é um único Cliente
                If bClienteUnico = False OrElse grpSaldoCliente.Visible = True Then
                    MsgBox("O valor pago é maior que o valor devido. Favor preencher o campo Juros na lista de parcelas.", MsgBoxStyle.Information, Me.Parent.Text)
                    Return False
                ElseIf MsgBox("O valor pago é maior que o valor devidor. Isto é um adiantamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = vbNo Then
                    Return False
                End If

            End If

            'Seta Retorno da Função
            ValidacaoPagamento = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region


End Class
