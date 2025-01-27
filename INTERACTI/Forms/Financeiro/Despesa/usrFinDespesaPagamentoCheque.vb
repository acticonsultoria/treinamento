Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports System.Math

Public Class usrFinDespesaPagamentoCheque

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinDespesaPagamentoCheque As New clsUsrFinDespesaPagamentoCheque

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrFinDespesaPagamentoCheque_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboContaBancaria" : Call LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)
                        Case "cboNumeroDocumentoChequeTerceiro" : Call LoadCombo(cboNumeroDocumentoChequeTerceiro, "sp_select_combo_financeiro_receita_cheque_terceiro " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboContaBancaria" : Call btnCadastrarContaBancaria_Click(btnCadastrarContaBancaria, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFinDespesaPagamentoCheque_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: BAIXAR DUPLICATAS :::"

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
            oForm.NomeFormulario = Formulario.FinanceiroDespesaPagamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroDespesaPagamento)

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

    Private Sub btnPagar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar1.Click


        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi Selecionado algum Registro
            If VerificaSelecaoRow(grdListagem) = True Then

                cboTipoDocumentoPagamento.SelectedIndex = -1
                'Limpa Formulário
                cboContaBancaria.SelectedIndex = -1
                grdPagamento.DataSource = Nothing
                btnInserirPagamento.Tag = ""
                btnPagar.Tag = 0

                'Carrega Grid
                Call LoadGridDuplicatas(grdParcela)



                'Alterna Aba                
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Habilita Botão
                btnPagar.Enabled = True

                'Seta Focu
                cboContaBancaria.Focus()

                cboTipoDocumentoPagamento.Text = ""

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

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

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
                                     Formulario.FinanceiroDespesaPagamento)

            'Carrega Combo
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
                                     Formulario.FinanceiroDespesaPagamento, _
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
                                          Formulario.FinanceiroDespesaPagamento, _
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
            oForm.NomeFormulario = Formulario.FinanceiroDespesaPagamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura GridParcela
            Call ConfiguraGrid(grdParcela, Formulario.FinanceiroDespesaPagamento)

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

                Case "desconto", "juros" : Call CalculaValorDevido()

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
                                     Formulario.FinanceiroDespesaPagamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdParcela_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdParcela.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdParcela.Name, _
                                     Formulario.FinanceiroDespesaPagamento, _
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
                                          Formulario.FinanceiroDespesaPagamento, _
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

    Private Sub btnAtualizarCheque_Click(sender As Object, e As EventArgs) Handles btnAtualizarCheque.Click

        Try

            Call LoadCombo(cboCheque, "sp_select_combo_financeiro_titulo_cheque " & goUsuario.iEmpresa)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click

        Try

            Call Atualizar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
            oForm.NomeFormulario = Formulario.FinanceiroDespesaPagamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura GridPagamento
            Call ConfiguraGrid(grdPagamento, Formulario.FinanceiroDespesaPagamento)

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
                                                           "sp_select_static_form_tipo_documento_pagamento_despesa")


                    Case "grpCheque"
                        Call InsertPagamento(grdPagamento, _
                                             cboContaBancaria.Text, _
                                             cboTipoDocumentoPagamento.Text, _
                                             cboCheque.Text.Trim, _
                                             dtpDataPagamentoCheque.Value, _
                                             txtValorCheque.Value, _
                                             "", _
                                             txtFavorecidoCheque.Text.Trim, _
                                             IIf(cboPreDatadoCheque.SelectedValue = True, 1, 0), _
                                             IIf(dtpDataCompensacaoCheque.Visible = True, dtpDataCompensacaoCheque.Value, ""), _
                                             cboContaBancaria.SelectedValue, _
                                             cboTipoDocumentoPagamento.SelectedValue, _
                                             -1, _
                                             -1, _
                                             -1, _
                                             StatusDespesaPagamento.ChequeNaoCompensado, _
                                             "", _
                                             -1, _
                                             -1, _
                                             IIf(IsNumeric(btnInserirPagamento.Tag), btnInserirPagamento.Tag, grdPagamento.GetDataRows.Count + 1))

                     
                    Case "grpChequeTerceiro"

                        Dim sCodigo() As String = cboNumeroDocumentoChequeTerceiro.SelectedValue.ToString.Split("|")

                        Call InsertPagamento(grdPagamento, _
                                             cboContaBancaria.Text, _
                                             cboTipoDocumentoPagamento.Text, _
                                             cboNumeroDocumentoChequeTerceiro.Text.Trim, _
                                             dtpDataPagamentoChequeTerceiro.Value, _
                                             txtValorChequeTerceiro.Value, _
                                             txtBancoChequeTerceiro.Text.Trim, _
                                             "", _
                                             -1, _
                                             "", _
                                             cboContaBancaria.SelectedValue, _
                                             cboTipoDocumentoPagamento.SelectedValue, _
                                             sCodigo(0), _
                                             sCodigo(1), _
                                             sCodigo(2), _
                                             StatusDespesaPagamento.ChequeNaoCompensado, _
                                             "", _
                                             -1, _
                                             -1, _
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

    Private Sub cboTipoDocumentoPagamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocumentoPagamento.SelectedIndexChanged

        Try

            CarregarDadosTipoDocumento()

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
                Call oClsFinDespesaPagamentoCheque.LoadDadosChequeTerceiro(sCodigo(0), _
                                                                     sCodigo(1), _
                                                                     txtBancoChequeTerceiro, _
                                                                     txtAgenciaChequeTerceiro, _
                                                                     txtContaChequeTerceiro, _
                                                                     txtDataRecebimentoChequeTerceiro, _
                                                                     txtPreDatadoChequeTerceiro, _
                                                                     txtValorChequeTerceiro)

            Else

                txtBancoChequeTerceiro.Text = ""
                txtAgenciaChequeTerceiro.Text = ""
                txtContaChequeTerceiro.Text = ""
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
                                     Formulario.FinanceiroDespesaPagamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdPagamento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdPagamento.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPagamento.Name, _
                                     Formulario.FinanceiroDespesaPagamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdPagamento_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdPagamento.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdPagamento.Name, _
                                          Formulario.FinanceiroDespesaPagamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCheque_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCheque.SelectedIndexChanged

        Try

            'Carrega Dados do Cheque de Terceiro
            Call oClsFinDespesaPagamentoCheque.LoadDadosCheque(cboCheque.SelectedValue, _
                                                               txtFavorecidoCheque, _
                                                               txtValorCheque)

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFinDespesaPagamentoCheque_KeyDown))
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
            Call LoadCombo(cboTipoDocumentoPagamento, "sp_select_combo_static_tipo_documento_pagamento_cheque")
            Call LoadCombo(cboCheque, "sp_select_combo_financeiro_titulo_cheque " & goUsuario.iEmpresa)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)
            Call LoadComboSimNao(cboPreDatadoCheque)
            Call LoadComboSimNao(cboAdiantamentoFiltro) : cboAdiantamentoFiltro.SelectedValue = False
             
            'Seta Controles DateTime
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataVencimentoInicioFiltro.Value = Now.Date : dtpDataVencimentoInicioFiltro.Checked = False
            dtpDataVencimentoTerminoFiltro.Value = Now.Date : dtpDataVencimentoTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroDespesaPagamento)
            Call ConfiguraGrid(grdParcela, Formulario.FinanceiroDespesaPagamento)
            Call ConfiguraGrid(grdPagamento, Formulario.FinanceiroDespesaPagamento)

            'Seta Aba / Focu
            If Me.Tag = "NOVO" Then
                tabMain.TabPages.Remove(pagListagem)
                cboContaBancaria.Focus()
            Else
                tabMain.TabPages.Remove(pagDados)
                txtNumeroDocumentoFiltro.Focus()
            End If

            cboTipoDocumentoPagamento.Text = ""

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: BAIXAR DUPLICATAS :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            oClsFinDespesaPagamentoCheque.LoadGrid(grdListagem, _
                                             txtNumeroDocumentoFiltro.Text.Trim, _
                                             IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                             IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                             txtFornecedorFiltro.Text.Trim, _
                                             IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
                                             IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
                                             txtValorFiltro.Value, _
                                             IIf(cboAdiantamentoFiltro.SelectedIndex = -1, False, cboAdiantamentoFiltro.SelectedValue))

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

            'Verifica se foi Inserido algum Pagamento
            If grdPagamento.GetDataRows.Count = 0 Then
                frmMain.errInfo.SetError(lblContaBancaria, "Primeiramente Insira um ou mais Pagamento.")
                cboContaBancaria.Focus()
                Exit Function
            End If

            'Verifica se o Valor Devido é Menor que o Valor Pago
            If Round(grdParcela.GetTotalRow.Cells("valor_devido").Value, 2) > Round(grdParcela.GetTotalRow.Cells("valor_pago").Value, 2) Then

                'Váriaveis - Form
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

                'Verifica Opção Escolhida - Caso 0 sai da Validação
                If CInt(btnPagar.Tag) = 0 Then
                    Exit Function
                End If

            ElseIf Round(grdParcela.GetTotalRow.Cells("valor_devido").Value, 2) < Round(grdParcela.GetTotalRow.Cells("valor_pago").Value, 2) Then
                'Informa o Usuário da Necessidade de Preencher o Juros
                MsgBox("O Valor Pago é maior que o Valor Devido, favor corrigir o Valor ou preencher o Juros.", MsgBoxStyle.Information, Me.Parent.Text)
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Pagar Parcela
            oClsFinDespesaPagamentoCheque.UpdateParcela(grdParcela, _
                                                  btnPagar.Tag)

            'Pagar Parcela
            If bSistemaPerforma = True Then
                oClsFinDespesaPagamentoCheque.InsertPagamentoMultiplo(grdParcela, _
                                                        grdPagamento)
            Else
                oClsFinDespesaPagamentoCheque.InsertPagamento(grdParcela, _
                                                     grdPagamento)

            End If


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

    Private Sub CarregarDadosTipoDocumento()
        Try

            'Oculta Controles 
            grpCheque.Visible = False
            grpChequeTerceiro.Visible = False

            'Váriaveis Locais
            Dim dValorDevido As Double

            'Seta Valor Devido
            dValorDevido = grdParcela.GetTotalRow.Cells("valor_devido").Value
            If grdPagamento.GetDataRows.Count > 0 Then dValorDevido -= grdPagamento.GetTotalRow.Cells("valor").Value
            If dValorDevido < 0 Then dValorDevido = 0

            'Carrega o Tipo de Documento de Pagamento
            If cboTipoDocumentoPagamento.SelectedIndex <> -1 Then

                'Torna Controle Visivel
                GetControlByName(LoadFormTipoDocumentoPagamento(cboTipoDocumentoPagamento.SelectedValue, "sp_select_static_form_tipo_documento_pagamento_despesa"), Me).Visible = True


                If grpCheque.Visible = True Then
                    'Limpa Controles - Cheque
                    dtpDataPagamentoCheque.Value = grdParcela.GetRows(0).Cells.Item("data_vencimento").Value
                    txtValorCheque.Value = dValorDevido
                    cboCheque.Text = ""
                    cboCheque.SelectedIndex = -1
                    txtFavorecidoCheque.Text = ""
                    cboPreDatadoCheque.SelectedValue = False
                    lblDataCompensacaoCheque.Visible = False
                    dtpDataCompensacaoCheque.Visible = False
                    dtpDataCompensacaoCheque.Value = Now.Date
                ElseIf grpChequeTerceiro.Visible = True Then
                    'Limpa Controles - Cheque de Terceiro
                    Call LoadCombo(cboNumeroDocumentoChequeTerceiro, "sp_select_combo_financeiro_titulo_cheque_terceiro " & goUsuario.iEmpresa)
                    cboNumeroDocumentoChequeTerceiro.SelectedIndex = -1

                End If

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadGridDuplicatas(ByVal oGrid As GridEX, _
                                   ByVal oDataSet As DataSet)

        Try

            With oGrid

                Call ConfigurarDataMemberGrid(oGrid)
                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

            'Limpa Formulário
            cboContaBancaria.SelectedIndex = -1
            cboTipoDocumentoPagamento.SelectedIndex = -1
            grdPagamento.DataSource = Nothing
            btnInserirPagamento.Tag = ""
            btnPagar1.Tag = ""
            btnPagar.Tag = 0

            'Alterna Aba                
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)

            'Habilita Botão
            btnPagar.Enabled = True

            'Seta Focu
            cboContaBancaria.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridDuplicatas(ByVal oGrid As GridEX)

        Try

            'Limpa Grid
            oGrid.DataSource = Nothing

            Dim iFormaPagamento As Integer = -1

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDCNumeroDocumento As New DataColumn("numero_documento")
            Dim oDCParceiroNegocio As New DataColumn("parceiro_negocio")
            Dim oDCDataEmissao As New DataColumn("data_emissao")
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

            'Seta DataType
            oDCDataVencimento.DataType = Now.Date.GetType
            oDCValorTotal.DataType = 0.0.GetType
            oDCValorPago.DataType = 0.0.GetType
            oDCJuros.DataType = 0.0.GetType
            oDCDesconto.DataType = 0.0.GetType
            oDCValorDevido.DataType = 0.0.GetType

            'Adiciona Tabela ao DataSet
            oDataSet.Tables.Add(oDataTable)

            'Adiciona Colunas ao DataTable
            oDataTable.Columns.Add(oDCNumeroDocumento)
            oDataTable.Columns.Add(oDCParceiroNegocio)
            oDataTable.Columns.Add(oDCDataEmissao)
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

            'Adiciona Linhas ao DataTable
            For Each oRow As GridEXRow In gSelecaoRow
                Dim oDataRow As DataRow = oDataTable.NewRow
                oDataRow("numero_documento") = oRow.Cells("numero_documento").Value
                oDataRow("parceiro_negocio") = oRow.Cells("parceiro_negocio").Value
                oDataRow("data_emissao") = oRow.Cells("data_emissao").Value
                oDataRow("parcela") = oRow.Cells("parcela").Value
                oDataRow("descritivo") = oRow.Cells("descritivo").Value
                oDataRow("data_vencimento") = oRow.Cells("data_vencimento").Value
                oDataRow("valor_total") = oRow.Cells("valor").Value
                oDataRow("valor_pago") = oRow.Cells("valor_pago").Value
                oDataRow("juros") = oRow.Cells("juros").Value
                oDataRow("desconto") = oRow.Cells("desconto").Value
                oDataRow("valor_devido") = oRow.Cells("valor").Value - oRow.Cells("valor_pago").Value
                oDataRow("codigo_titulo_capa") = oRow.Cells("codigo_titulo_capa").Value
                oDataRow("numero_parcela") = oRow.Cells("numero_parcela").Value

                Try
                    iFormaPagamento = oRow.Cells.Item("codigo_forma_pagamento").Value
                Catch ex As Exception

                End Try


                oDataTable.Rows.Add(oDataRow)
            Next

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            If iFormaPagamento <> -1 Then
                cboTipoDocumentoPagamento.SelectedValue = iFormaPagamento
                Application.DoEvents()
                CarregarDadosTipoDocumento()
            End If


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CalculaValorDevido()

        Try

            'Calcula Valor Devido
            grdParcela.SetValue("valor_devido", grdParcela.CurrentRow.Cells("valor_total").Value - _
                                                grdParcela.CurrentRow.Cells("desconto").Value + _
                                                grdParcela.CurrentRow.Cells("juros").Value)

            'Calcula Valor Pago
            Call CalculaValorPago()

        Catch ex As Exception
            Throw ex
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
                    grdParcela.SetValue("valor_devido", grdParcela.CurrentRow.Cells("valor_total").Value - _
                                                        grdParcela.CurrentRow.Cells("desconto").Value + _
                                                        grdParcela.CurrentRow.Cells("juros").Value)

                    'Atualiza Linha
                    grdParcela.Refresh()

                Next

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PAGAMENTO :::"

    Private Sub Atualizar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            For Each oRow As GridEXRow In grdListagem.GetDataRows

                oClsFinDespesaPagamentoCheque.Atualizar(txtValorCheque.Value, _
                                                        cboCheque.Text)

            Next

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

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

            If grpCheque.Visible = True Then

                'Limpa Controles - Cheque
                dtpDataPagamentoCheque.Value = Now.Date
                txtValorCheque.Value = dValorDevido
                cboCheque.Text = ""
                cboCheque.SelectedIndex = -1
                txtFavorecidoCheque.Text = ""
                cboPreDatadoCheque.SelectedValue = False
                cboPreDatadoCheque.SelectedValue = False
                lblDataCompensacaoCheque.Visible = False
                dtpDataCompensacaoCheque.Visible = False
                dtpDataCompensacaoCheque.Value = Now.Date
                'Seta Focu
                cboCheque.Focus()

            ElseIf grpChequeTerceiro.Visible = True Then

                'Limpa Controles - Cheque de Terceiro
                cboNumeroDocumentoChequeTerceiro.SelectedIndex = -1
                'Seta Focu
                cboNumeroDocumentoChequeTerceiro.Focus()

            End If

            btnInserirPagamento.Tag = ""

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarPagamento()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FinanceiroDespesaPagamento, gcUpdate) = True Then

                With grdPagamento.CurrentRow.Cells

                    Call NovoPagamento()

                    Select Case LoadFormTipoDocumentoPagamento(cboTipoDocumentoPagamento.SelectedValue, _
                                                               "sp_select_static_form_tipo_documento_pagamento_despesa")

                        Case "grpCheque"
                            'Carrega Controles
                            cboContaBancaria.SelectedValue = .Item("codigo_banco_conta").Value
                            cboTipoDocumentoPagamento.SelectedValue = .Item("codigo_tipo_documento_pagamento").Value
                            cboCheque.SelectedValue = .Item("numero_documento").Value
                            dtpDataPagamentoCheque.Value = .Item("data_pagamento").Value
                            txtValorCheque.Value = .Item("valor").Value
                            txtFavorecidoCheque.Text = .Item("favorecido").Value
                            cboPreDatadoCheque.SelectedValue = .Item("pre_datado").Value
                            If IsDBNull(.Item("data_pre_datado").Value) = False Then dtpDataCompensacaoCheque.Value = .Item("data_pre_datado").Value
                            btnInserirPagamento.Tag = .Item("codigo").Value
                            'Seta Focu
                            cboCheque.Focus()

                        Case "grpChequeTerceiro"
                            'Carrega Controles
                            cboContaBancaria.SelectedValue = .Item("codigo_banco_conta").Value
                            cboTipoDocumentoPagamento.SelectedValue = .Item("codigo_tipo_documento_pagamento").Value
                            cboNumeroDocumentoChequeTerceiro.SelectedValue = CStr(.Item("codigo_titulo_capa_receita").Value & "|" & .Item("codigo_titulo_parcela_pagamento_receita").Value & "|" & .Item("numero_parcela_receita").Value)
                            'Seta Focu
                            cboNumeroDocumentoChequeTerceiro.Focus()

                    End Select

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

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

            If grdPagamento.GetDataRows.Count > 0 Then
                dValorPago = grdPagamento.GetTotalRow.Cells("valor").Value
            End If
            If IsNumeric(btnInserirPagamento.Tag) Then
                dValorPago -= grdPagamento.CurrentRow.Cells("valor").Value
            End If

            'Cheque
            If grpCheque.Visible = True Then

                ''Verifica se foi Preenchido o Campo - Número do Cheque
                'If ValidaCampo(cboCheque, lblNumeroCheque) = False Then
                '    Exit Function
                'End If

                'Verifica se foi Preenchido o Campo - Valor
                If ValidaCampo(txtValorCheque, lblValorCheque, True) = False Then
                    Exit Function
                End If

                'Verifica se o Valor Pago é Válido
                If ((CDbl(FormatNumber(dValorPago, 2)) + CDbl(FormatNumber(txtValorCheque.Value, 2))) - grdParcela.GetTotalRow.Cells("valor_devido").Value) > 0 Then
                    frmMain.errInfo.SetError(lblValorCheque, "O Valor Pago não pode ser maior que o Valor Devido. Caso ocorra favor preencher o Campo de Juros")
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

                'Verifica se o Valor Pago é Válido
                If ((CDbl(FormatNumber(dValorPago, 2)) + CDbl(FormatNumber(txtValorChequeTerceiro.Value, 2))) - grdParcela.GetTotalRow.Cells("valor_devido").Value) > 0 Then
                    frmMain.errInfo.SetError(lblValorChequeTerceiro, "O Valor Pago não pode ser maior que o Valor Devido. Caso ocorra favor preencher o Campo de Juros")
                    Exit Function
                End If

            End If

            'Seta Retorno da Função
            ValidacaoPagamento = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub DeletePagamento()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdPagamento) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Linha
                    For Each oRow As GridEXRow In gSelecaoRow
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

#End Region

#End Region
     
End Class
