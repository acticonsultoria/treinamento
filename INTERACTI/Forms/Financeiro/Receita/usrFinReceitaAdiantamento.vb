Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrFinReceitaAdiantamento

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinReceitaAdiantamento As New clsUsrFinReceitaAdiantamento
    Private oClsFinReceitaPagamento As New clsUsrFinReceitaPagamento
    'Private oClsUsrFinBloqueioExtrato As New clsUsrFinBloqueioExtrato

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrFinReceitaAdiantamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCliente" : Call btnProcurarCliente_Click(btnProcurarCliente, System.EventArgs.Empty)
                        Case "txtClienteFiltro" : Call btnProcurarClienteFiltro_Click(btnProcurarClienteFiltro, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCliente" : Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
                        Case "cboCentroGasto" : Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboContaContabil" : Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.N : If e.Control = False Then Exit Sub

                    Select Case sender.Name
                        Case "cboCliente" : Call btnCadastrarCliente_Click(btnCadastrarCliente, System.EventArgs.Empty)
                        Case "cboCentroGasto" : Call btnCadastrarCentroGasto_Click(btnCadastrarCentroGasto, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnCadastrarContaContabil_Click(btnCadastrarContaContabil, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrFinReceitaAdiantamento_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: TÍTULO :::"

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
            oForm.NomeFormulario = Formulario.FinanceiroReceitaAdiantamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaLancamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarClienteFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarClienteFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oMaskedEditBoxFind = txtClienteFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            txtClienteFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCliente.Click

        Try

            'Carrega o form de parceiro de negócio
            If sender.Enabled = False Then Exit Sub Else LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCliente.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboCliente

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Cancela Registros
            Call Cancelar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAtivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtivar.Click

        Try

            'Ativar Registros
            Call Ativar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagReceita)

            'Seta Focu
            txtNumeroDocumento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Seta Focu
            txtNumeroDocumento.Focus()

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()
                'Seta Focu
                btnNovo.Focus()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagReceita)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboContaBancaria_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboContaBancaria.SelectedIndexChanged

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

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoDocumentoPagamento_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoDocumentoPagamento.SelectedIndexChanged

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
            dValorDevido = txtValor.Text

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
                ElseIf grpChequeTerceiro.Visible = True Then
                    'Limpa Controles - Cheque de Terceiro
                    Call LoadCombo(cboNumeroDocumentoChequeTerceiro, "sp_select_combo_financeiro_titulo_cheque_terceiro " & goUsuario.iEmpresa)
                    cboNumeroDocumentoChequeTerceiro.SelectedIndex = -1
                ElseIf grpOutros.Visible = True Then
                    'Limpa Controles - Outros
                    dtpDataPagamentoOutros.Value = Now.Date
                    txtValorOutros.Value = dValorDevido
                    txtNumeroDocumentoOutros.Text = ""
                ElseIf grpOutrosSimples.Visible = True Then
                    'Limpa Controles - Outros Simples
                    dtpDataPagamentoOutrosSimples.Value = Now.Date
                    txtValorOutrosSimples.Value = dValorDevido
                ElseIf grpCartaoCredito.Visible = True Then
                    'Carrega Combo
                    Call LoadCombo(cboBandeiraCartaoCredito, "sp_select_combo_cadastro_basico_bandeira_cartao_credito " & goUsuario.iEmpresa, False)
                    dtpDataPagamentoCartaoCredito.Value = Now.Date
                    txtValorCartaoCredito.Value = dValorDevido
                    txtNumeroParcelaCartaoCredito.Value = 1

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se foi Pressionado algum Registro
            If grdListagem.CurrentRow.RowType <> RowType.Record Then
                Exit Sub
            End If

            Select Case grdListagem.CurrentColumn.Key

                Case "duplicar" : Call Duplicar()
                Case "historico" : Call Historico()
                Case "editar" : Call Editar()
                Case "boleto_bancario" : Call BoletoBancario()
                Case "editar_parcela" : Call EditarDuplicata()
                Case "editar_parceiro_negocio" : Call EditarParceiroNegocio()
                Case "duplicar_parcela" : Call DuplicarParcela()
                Case "pagar" : Call Pagar()
                Case "cancelar" : Call CancelarPagamento()
                Case "email_boleto_bancario"
                    If IsDBNull(e.Row.Cells("codigo_boleto_bancario").Value) = False Then

                        'Abre a Tela de Emissão de Boleto Bancário
                        Call EmailBoletoBancario(grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value,
                                                 grdListagem.CurrentRow.Cells("numero_documento").Value,
                                                 grdListagem.CurrentRow.Cells("codigo_parceiro_negocio").Value)

                    Else

                        'Informa o Usuário que a Operação não pode ser Realizada
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não existe Boleto Bancário para este Título.")

                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.FinanceiroReceitaAdiantamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FinanceiroReceitaAdiantamento, _
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
                                          Formulario.FinanceiroReceitaAdiantamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_FormattingRow(sender As Object, e As RowLoadEventArgs) Handles grdListagem.FormattingRow

        Try

            If e.Row.RowType = RowType.Record AndAlso IsNothing(e.Row.Parent) Then

                Select Case e.Row.Cells("codigo_tipo_titulo_financeiro").Value

                    Case TipoTituloFinanceiro.Real
                        e.Row.Cells("boleto_bancario").ImageKey = "boleto_bancario" : e.Row.Cells("boleto_bancario").ToolTipText = "Duplo clique para gerar Boleto Bancário."
                    Case TipoTituloFinanceiro.Previsto
                        e.Row.Cells("boleto_bancario").ImageKey = Nothing : e.Row.Cells("boleto_bancario").ToolTipText = ""

                End Select

                If IsDBNull(e.Row.Cells("codigo_boleto_bancario").Value) = False Then
                    e.Row.Cells("email_boleto_bancario").ImageKey = "email" : e.Row.Cells("email_boleto_bancario").ToolTipText = "Duplo clique para enviar e-mail de Boleto Bancário."
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


#End Region

#Region "::: CLASSIFICAÇÃO :::"

    Private Sub btnCadastrarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Abre Formulário de Cadastro
            If sender.Enabled = False Then Exit Sub Else LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo            
            LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Abre Formulário de Cadastro
            If sender.Enabled = False Then Exit Sub Else LoadUsrControlForm(Me, "usrCadPlanoContas")

            'Carrega Combo            
            LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirClassificao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirClassificao.Click

        Try

            'Insere Classificação
            Call InserirClassificacao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirClassificacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirClassificacao.Click

        Try

            'Exclui Classificação
            Call DeleteClassificacao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdClassificacao_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdClassificacao.RowDoubleClick

        Try

            Select Case grdClassificacao.CurrentColumn.Key

                Case "editar" : Call EditarClassificacao()

            End Select

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFinReceitaAdiantamento_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.FinanceiroReceitaAdiantamento, gcDelete)
            btnNovo.Enabled = VerificaDireito(Formulario.FinanceiroReceitaAdiantamento, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.FinanceiroReceitaAdiantamento, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.FinanceiroReceitaAdiantamento, gcPrint)

            'Verifica Direito - Botão de Cadastro            
            btnCadastrarCliente.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarCentroGasto.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)
            btnCadastrarContaContabil.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcInsert)

            'Carrega ComboBox
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_titulo")
            Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboContaBancariaFiltro, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)
            Call LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)
            Call LoadCombo(cboTipoDocumentoPagamento, "sp_select_combo_static_tipo_documento_pagamento 'R'")
            Call LoadCombo(cboPedidoVenda, "sp_select_combo_adiantamento_pedido_venda " & goUsuario.iEmpresa)

            'Seta Controle
            dtpDataEmissaoInicioFiltro.Checked = False : dtpDataEmissaoInicioFiltro.Value = Now.Date
            dtpDataEmissaoTerminoFiltro.Checked = False : dtpDataEmissaoTerminoFiltro.Value = Now.Date
            dtpDataVencimentoInicioFiltro.Checked = False : dtpDataVencimentoInicioFiltro.Value = Now.Date
            dtpDataVencimentoTerminoFiltro.Checked = False : dtpDataVencimentoTerminoFiltro.Value = Now.Date
            dtpDataPagamentoInicioFiltro.Checked = False : dtpDataPagamentoInicioFiltro.Value = Now.Date
            dtpDataPagamentoTerminoFiltro.Checked = False : dtpDataPagamentoTerminoFiltro.Value = Now.Date
            dtpDataVencimento.Checked = False : dtpDataVencimento.Value = Now.Date
            dtpDataVencimento.Checked = False : dtpDataVencimento.Value = Now.Date

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaAdiantamento)

            'Seta Aba
            tabMain.TabPages.Remove(pagReceita)

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: TÍTULO :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Controles
            oClsFinReceitaAdiantamento.LoadGrid(grdListagem, _
                                              txtNumeroDocumentoFiltro.Text.Trim, _
                                              txtSerieFiltro.Text.Trim, _
                                              txtClienteFiltro.Text.Trim, _
                                              IIf(cboStatusFiltro.SelectedIndex = -1, -1, cboStatusFiltro.SelectedValue), _
                                              IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                              IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                              IIf(dtpDataVencimentoInicioFiltro.Checked = False, "", dtpDataVencimentoInicioFiltro.Value), _
                                              IIf(dtpDataVencimentoTerminoFiltro.Checked = False, "", dtpDataVencimentoTerminoFiltro.Value), _
                                              IIf(dtpDataPagamentoInicioFiltro.Checked = False, "", dtpDataPagamentoInicioFiltro.Value), _
                                              IIf(dtpDataPagamentoTerminoFiltro.Checked = False, "", dtpDataPagamentoTerminoFiltro.Value), _
                                              IIf(cboTipoTituloFinanceiroFiltro.SelectedIndex = -1, -1, cboTipoTituloFinanceiroFiltro.SelectedValue), _
                                              IIf(txtValorFiltro.Value = 0, -1, txtValorFiltro.Value), _
                                              IIf(cboContaBancariaFiltro.SelectedIndex = -1, -1, cboContaBancariaFiltro.SelectedValue), _
                                              txtDescritivoFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRowLancamento(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsFinReceitaAdiantamento.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de selecionar um ou mais Registros
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos." & vbCrLf & vbCrLf & _
                       "** Registros com status: ABERTO." & vbCrLf & _
                       "** Registros não vinculados a um Pedido de Venda / Emissão de Nota Fiscal (Serviço / Produto).", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Dados Gerais
            txtNumeroDocumento.Text = ""
            btnSalvar.Tag = ""
            txtSerie.Text = ""
            cboCliente.SelectedIndex = IIf(cboCliente.Items.Count = 1, 0, -1)
            dtpDataEmissao.Value = Now.Date
            txtDescritivo.Text = ""
            dtpDataVencimento.Value = Now.Date
            txtValor.Value = 0
            cboContaBancaria.SelectedIndex = -1
            cboTipoDocumentoPagamento.SelectedIndex = -1

            'Limpa Controles - Classificação
            cboCentroGasto.SelectedIndex = -1
            cboContaContabil.SelectedIndex = -1
            txtValorClassificacao.Value = 0
            btnInserirClassificao.Tag = ""
            btnInserirClassificao.Enabled = True
            btnExcluirClassificacao.Enabled = True
            grdClassificacao.DataSource = Nothing
            grdClassificacao.AllowEdit = InheritableBoolean.True

            'Váriaveis Locais
            Dim dValorDevido As Double
            'Seta Valor Devido
            dValorDevido = txtValor.Text
            If dValorDevido < 0 Then dValorDevido = 0

            'Limpa GroupBox
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
                grpBoleto.Visible = False

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
                grpCheque.Visible = False

            ElseIf grpChequeTerceiro.Visible = True Then

                'Limpa Controles - Cheque de Terceiro
                cboNumeroDocumentoChequeTerceiro.SelectedIndex = -1
                'Seta Focu
                cboNumeroDocumentoChequeTerceiro.Focus()
                grpChequeTerceiro.Visible = False

            ElseIf grpDescontoDuplicata.Visible = True Then

                'Limpa Controles
                txtNumeroDocumentoDescontoDuplicata.Text = ""
                dtpDataPagamentoDescontoDuplicata.Value = Now.Date
                txtValorDescontoDuplicata.Value = 0
                txtJurosDescontoDuplicata.Value = 0
                grpDescontoDuplicata.Visible = False

            ElseIf grpOutros.Visible = True Then

                'Limpa Controles - Outros
                dtpDataPagamentoOutros.Value = Now.Date
                txtValorOutros.Value = dValorDevido
                txtNumeroDocumentoOutros.Text = ""
                'Seta Focu
                txtNumeroDocumentoOutros.Focus()
                grpOutros.Visible = False

            ElseIf grpOutrosSimples.Visible = True Then

                'Limpa Controles - Outros Simples
                dtpDataPagamentoOutrosSimples.Value = Now.Date
                txtValorOutrosSimples.Value = dValorDevido
                'Seta Focu
                dtpDataPagamentoOutrosSimples.Focus()
                grpOutrosSimples.Visible = False

            ElseIf grpCartaoCredito.Visible = True Then

                'Limpa Controles - Cartão de Crédito
                cboMaquinaCartao.Text = ""
                cboBandeiraCartaoCredito.DataSource = Nothing : cboBandeiraCartaoCredito.Text = ""
                dtpDataPagamentoCartaoCredito.Value = Now.Date
                txtValorCartaoCredito.Value = 0
                txtNumeroParcelaCartaoCredito.Text = ""
                'Seta Focu
                cboMaquinaCartao.Focus()
                grpCartaoCredito.Visible = False

            End If

            'Habilita Controles
            btnSalvar.Enabled = VerificaDireito(Formulario.FinanceiroReceitaAdiantamento, gcInsert)

            'Alterna Aba
            tabDados.SelectedTab = pagDados

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsFinReceitaAdiantamento.CodigoReceitaCapa = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsFinReceitaAdiantamento.NumeroDocumento = txtNumeroDocumento.Text.Trim
            oClsFinReceitaAdiantamento.Serie = txtSerie.Text.Trim
            oClsFinReceitaAdiantamento.TipoDocumento = TipoDocumentoFinanceiro.Adiantamento
            oClsFinReceitaAdiantamento.ParceiroNegocio = cboCliente.SelectedValue
            oClsFinReceitaAdiantamento.DataEmissao = dtpDataEmissao.Value
            oClsFinReceitaAdiantamento.TipoTituloFinanceiro = TipoTituloFinanceiro.Real
            oClsFinReceitaAdiantamento.Moeda = 1
            oClsFinReceitaAdiantamento.FatorCambial = 1
            oClsFinReceitaAdiantamento.MultaPagamento = 0
            oClsFinReceitaAdiantamento.JurosPagamento = 0
            oClsFinReceitaAdiantamento.DescontoPagamento = 0
            oClsFinReceitaAdiantamento.Descritivo = txtDescritivo.Text.Trim
            oClsFinReceitaAdiantamento.DataVencimento = dtpDataVencimento.Value
            oClsFinReceitaAdiantamento.Valor = txtValor.Value
            oClsFinReceitaAdiantamento.DescontoValor = 0
            oClsFinReceitaAdiantamento.DescontoPercentual = 0
            oClsFinReceitaAdiantamento.FormaPagamento = cboTipoDocumentoPagamento.SelectedValue
            oClsFinReceitaAdiantamento.NumeroParcela = 1
            oClsFinReceitaAdiantamento.IntervaloParcela = 0
            oClsFinReceitaAdiantamento.CodigoPedidoVendaAdiantamento = IIf(cboPedidoVenda.SelectedIndex = -1, -1, cboPedidoVenda.SelectedValue)

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsFinReceitaAdiantamento.Update()
                oClsFinReceitaAdiantamento.DeleteParcela(btnSalvar.Tag)
                oClsFinReceitaAdiantamento.InsertParcelaAdiantamento()
                oClsFinReceitaAdiantamento.DeleteClassificacao(btnSalvar.Tag)
                oClsFinReceitaAdiantamento.InsertClassificacao(grdClassificacao)
                'Realiza o pagamento do Adiantamento
                PagarAdiantamento()
                btnSalvar.Enabled = False
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsFinReceitaAdiantamento.Insert()
                oClsFinReceitaAdiantamento.InsertParcelaAdiantamento()
                oClsFinReceitaAdiantamento.InsertClassificacao(grdClassificacao)
                btnSalvar.Tag = oClsFinReceitaAdiantamento.CodigoReceitaCapa
                'Realiza o pagamento do Adiantamento
                PagarAdiantamento()
                btnSalvar.Enabled = False
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FinanceiroReceitaAdiantamento, gcUpdate) = True Then

                cboContaBancaria.SelectedIndex = -1
                cboTipoDocumentoPagamento.SelectedIndex = -1

                'Carrega Controles
                oClsFinReceitaAdiantamento.LoadControlesAdiantamento(grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value, _
                                                                     txtNumeroDocumento, _
                                                                     txtSerie, _
                                                                     cboCliente, _
                                                                     dtpDataEmissao, _
                                                                     txtDescritivo, _
                                                                     txtValor)

                btnSalvar.Tag = grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value

                'Carrega Grid de Classificação
                oClsFinReceitaAdiantamento.LoadGridClassificacao(grdClassificacao, _
                                                               grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value)

                'Desabilita Controles Caso não possa ser Editado o Registro
                If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusTitulo.Aberto) Then
                    grdClassificacao.AllowEdit = InheritableBoolean.True
                    btnSalvar.Enabled = True
                    btnInserirClassificao.Enabled = True
                    btnExcluirClassificacao.Enabled = True
                Else
                    grdClassificacao.AllowEdit = InheritableBoolean.False
                    btnSalvar.Enabled = False
                    btnInserirClassificao.Enabled = False
                    btnExcluirClassificacao.Enabled = False
                End If

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagReceita)
                tabDados.SelectedTab = pagDados

                'Seta Focu
                txtNumeroDocumento.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Historico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Formulário
            Dim oForm As New frmFinTituloHistorico
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
            'Seta Parâmetros
            oForm.Grid = grdListagem
            oForm.Tipo = "R"
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Cancelar()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FinanceiroReceitaAdiantamento, gcAdministrator) = True Then

                'Verifica se foi selecionado algum registro válido
                If VerificaSelecaoRow(grdListagem, "status", StatusTitulo.Aberto) = True Then

                    'Váriavel - Formulário
                    Dim oForm As New frmFinTituloCancelar
                    oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)
                    'Carrega Grid
                    Call LoadGrid()

                Else
                    'Informa o Usuário da Necessidade de selecionar um ou mais Registros
                    MsgBox("Primeiramente Selecione um ou mais Registros Válidos." & vbCrLf & vbCrLf & _
                           "** Registros com status: ABERTO.", MsgBoxStyle.Exclamation, Me.Parent.Text)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Ativar()

        Try

            'Verifica se o usuário tem direito de Administrador
            If VerificaDireito(Formulario.FinanceiroReceitaAdiantamento, gcAdministrator) = True Then

                'Verifica se foi selecionado algum registro válido
                If VerificaSelecaoRow(grdListagem, "status", StatusTitulo.Cancelado) = True Then

                    'Verifica se o Usuário deseja Retornar o Status do Orçamento
                    If MsgBox("Deseja tornar ativo os Registros Selecionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                        'Váriaveis Locais
                        Dim oClsFinTituloCancelar As New clsFrmFinTituloCancelar

                        'Atualiza Status da Receita
                        oClsFinTituloCancelar.UpdateStatus("TÍTULO REATIVADO")

                        'Carrega a Grid
                        Call LoadGrid()

                    End If

                Else
                    'Informa o Usuário da Necessidade de selecionar um ou mais Registros
                    MsgBox("Primeiramente Selecione um ou mais Registros Válidos." & vbCrLf & vbCrLf & _
                           "*** Registros com Status: CANCELADO", MsgBoxStyle.Exclamation, Me.Parent.Text)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Duplicar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FinanceiroReceitaAdiantamento, gcInsert) = True Then

                'Váriaveis - Formulário
                Dim oForm As New frmFinTituloDuplicar
                oForm.Tipo = "R"
                oForm.Grid = grdListagem
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Carrega Grid
                Call LoadGrid()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoInserir)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub BoletoBancario()

        Try

            'Verifica o Tipo do Título Financeiro
            If grdListagem.CurrentRow.Cells("codigo_tipo_titulo_financeiro").Value = TipoTituloFinanceiro.Real Then


                If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusTitulo.ParcialmenteQuitado) Or
                grdListagem.CurrentRow.Cells("status").Value = CInt(StatusTitulo.Aberto) Then

                    'Abre Formulário de Boleto Bancário
                    Dim oForm As New frmFinReceitaBoletoBancarioDLL
                    oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
                    oForm.Cliente = grdListagem.CurrentRow.Cells("parceiro_negocio").Value
                    oForm.NumeroDocumento = grdListagem.CurrentRow.Cells("numero_documento").Value
                    oForm.CodigoTituloCapa = grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                Else

                    'Informa o Usuário que a Operação não pode ser Realizada
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Este Título já foi " & IIf(grdListagem.CurrentRow.Cells("status").Value = CInt(StatusTitulo.Cancelado), "Cancelado.", "Quitado."))

                End If

            Else

                'Informa o Usuário que a Operação não pode ser Realizada
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não é possível gerar Boleto Bancário para Título Previsto.")

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EmailBoletoBancario(ByVal lCodigoTituloCapa As Long,
                                    ByVal sNumeroDocumento As String,
                                    ByVal iCodigoParceiroNegocio As Integer)

        Try

            'Váriaveis Locais
            Dim oClsFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario
            Dim sArquivoBoleto As String = ""

            'Carrega Boleto
            oClsFinReceitaBoletoBancario.LoadArquivoBoletoPDF(lCodigoTituloCapa, sNumeroDocumento, sArquivoBoleto)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Enviar E-mail
            Call EnviarEmail(goUsuario.sEmpresa & " - Boleto Bancário Ref. NF: " & sNumeroDocumento & ".",
                             LoadDescricao("sp_select_financeiro_titulo_email " & goUsuario.iEmpresa & ", " & lCodigoTituloCapa),
                             sArquivoBoleto,
                             sArquivoBoleto,
                             "",
                             iCodigoParceiroNegocio,
                             "",
                             -1,
                             -1,
                             TipoAutotextoEmail.BoletoBancario)


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Número Documento
            If txtNumeroDocumento.Text.Trim = "" Then
                'Verifica se o Usuário quer que o Sistema gere o Número do Documento Automaticamente
                If MsgBox("Deseja que o Sistema gere o Número do Documento Automaticamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then
                    txtNumeroDocumento.Text = oClsFinReceitaAdiantamento.GerarNumeroDocumentoAdiantamento
                End If
            End If

            Dim dDataPagamento As DateTime
            Select Case LoadFormTipoDocumentoPagamento(cboTipoDocumentoPagamento.SelectedValue, _
                                                        "sp_select_static_form_tipo_documento_pagamento_receita")

                Case "grpBoleto"
                    dDataPagamento = dtpDataPagamentoBoleto.Value

                Case "grpOutros"
                   dDataPagamento = dtpDataPagamentoOutros.Value

                Case "grpSaldoCliente"
                    dDataPagamento = dtpDataPagamentoSaldoCliente.Value

                Case "grpDescontoDuplicata"
                    dDataPagamento = dtpDataPagamentoDescontoDuplicata.Value

                Case "grpOutrosSimples"
                    dDataPagamento = dtpDataPagamentoOutrosSimples.Value

                Case "grpCheque"
                    dDataPagamento= dtpDataPagamentoCheque.Value

                Case "grpChequeTerceiro"
                    dDataPagamento= dtpDataPagamentoChequeTerceiro.Value

            End Select

            'If oClsUsrFinBloqueioExtrato.VerificaBloqueio(dDataPagamento) = False Then
            '    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Data bloqueada, consulte o setor financeiro.")
            '    Exit Function
            'End If

            'Verifica se foi Preenchido o Campo - Número Documento
            If ValidaCampo(txtNumeroDocumento, lblNumeroDocumento, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Cliente
            If ValidaCampo(cboCliente, lblCliente) = False Then
                Exit Function
            End If

            'Verifica se a Data de Emissão é do mês anterior
            If DateDiff(DateInterval.Month, dtpDataEmissao.Value, Now.Date) >= 1 Then
                If MsgBox("A Data de Emissão do Documento é diferente do mês corrente." & vbCrLf & "Essa data pode alterar o Fluxo de Caixa do mês anterior." & vbCrLf & vbCrLf & "Deseja prosseguir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Parent.Text) = MsgBoxResult.No Then
                    dtpDataEmissao.Focus()
                    Exit Function
                End If
            End If

            'Verifica se o Código Banco ja foi cadastrado
            If oClsFinReceitaAdiantamento.ValidaReceitaCapa(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                                          txtNumeroDocumento.Text.Trim, _
                                                          txtSerie.Text.Trim, _
                                                          cboCliente.SelectedValue) = False Then
                frmMain.errInfo.SetError(lblNumeroDocumento, "Este N° Documento: " & txtNumeroDocumento.Text.Trim & "/" & IIf(txtSerie.Text.Trim = "", "", "/" & txtSerie.Text.Trim) & " já está associado a outro Registro.")
                txtNumeroDocumento.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descritivo
            If ValidaCampo(txtDescritivo, lblDescritivo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Unitário
            If ValidaCampo(txtValor, lblValor, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Pedido Compra
            If ValidaCampo(cboPedidoVenda, lblPedidoVenda) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function VerificaSelecaoRowLancamento(ByVal oGrid As GridEX) As Boolean

        Try

            'Variáveis Loais
            Dim oCheckedRow() As Janus.Windows.GridEX.GridEXRow
            Dim oRow As Janus.Windows.GridEX.GridEXRow

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            'Seta Retorno da Função
            VerificaSelecaoRowLancamento = False

            With oGrid

                'Verifica se foi selecionado algum registro para salvar
                If .GetCheckedRows.Length > 0 Then

                    'Recebendo o array de linhas selecionadas
                    oCheckedRow = .GetCheckedRows

                    'Varrendo os itens selecionados
                    For Each oRow In oCheckedRow

                       
                            'Redimensiona Vetor caso necessário
                            If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                                ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                            End If

                            'Seta Retorno da Função
                            VerificaSelecaoRowLancamento = True

                            'Seta Valores
                            gSelecaoRow(UBound(gSelecaoRow)) = oRow

                
                    Next

                End If

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EditarParceiroNegocio()

        Try

            ''Seta Cursor do Mouse
            'Cursor.Current = Cursors.WaitCursor

            ''Limpa Erro
            'frmMain.errInfo.Clear()

            ''Verifica se o usuário tem direito de alterar algum registro
            'If VerificaDireito(Formulario.FinanceiroReceitaAdiantamento, gcUpdate) = True Then

            '    'Váriavel - Formulário
            '    Dim oForm As New frmFinEditarParceiroNegocio

            '    'Seta Parâmetros
            '    oForm.CodigoTituloCapa = grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value
            '    oForm.CNPJParceiroNegocioAntigo = grdListagem.CurrentRow.Cells.Item("cnpj").Value
            '    oForm.Tipo = 1

            '    'Abre Formulário
            '    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            '    'Atualiza Grid
            '    Call LoadGrid()

            'Else
            '    'Informa o Usuário que ele não tem Direito
            '    frmMain.Informacao(Mensagem.DireitoAlteracao)
            'End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PARCELA :::"

    Private Sub EditarDuplicata()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FinanceiroReceitaAdiantamento, gcUpdate) = True Then

                'Verifica se a Duplicata já foi Baixada
                If grdListagem.CurrentRow.Cells.Item("valor_pago").Value = 0 Then

                    If IsDBNull(grdListagem.CurrentRow.Cells("codigo_duplicata_descontada").Value) Then

                        'Váriavel - Formulário
                        Dim oForm As New frmFinEditarDuplicata

                        'Seta Parâmetros
                        oForm.CodigoTituloCapa = grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value
                        oForm.NumeroParcela = grdListagem.CurrentRow.Cells.Item("numero_parcela").Text

                        'Abre Formulário
                        Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                        'Atualiza Grid
                        Call LoadGrid()

                    Else
                        'Informa o Usuário que ele não tem Direito
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                    End If

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Pagar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se a Parcela já está paga
            If grdListagem.CurrentRow.Cells("valor_corrigido").Value > grdListagem.CurrentRow.Cells("valor_pago").Value Then

                'Verifica o Tipo do Título
                If grdListagem.CurrentRow.Parent.Cells("tipo_titulo_financeiro").Value <> "PREVISTO" Then

                    'Verifica se a Duplicata já foi Descontada
                    If IsDBNull(grdListagem.CurrentRow.Cells("codigo_duplicata_descontada").Value) Then

                        'Verifica se o usuário tem direito de alterar algum registro
                        If VerificaDireito(Formulario.FinanceiroReceitaAdiantamento, gcInsert) = True Then

                            'Abre Formulário de Cadastro
                            Dim oForm As New frmCadBasico
                            oForm.UsrControl = "usrFinReceitaPagamento"
                            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
                            oForm.Titulo = "Financeiro - Receita - Baixar Duplicatas"

                            'Variaveis Locais
                            Dim oDataSet As New DataSet
                            Dim oDataTable As New DataTable
                            Dim oDCNumeroDocumento As New DataColumn("numero_documento")
                            Dim oDCDataEmissao As New DataColumn("data_emissao")
                            Dim oDCParcela As New DataColumn("parcela")
                            Dim oDCParceiroNegocio As New DataColumn("parceiro_negocio")
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
                            oDataTable.Columns.Add(oDCDataEmissao)
                            oDataTable.Columns.Add(oDCParcela)
                            oDataTable.Columns.Add(oDCParceiroNegocio)
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
                            oDCDataEmissao.DataType = Now.Date.GetType
                            oDCDataVencimento.DataType = Now.Date.GetType
                            oDCValorTotal.DataType = 0.0.GetType
                            oDCValorPago.DataType = 0.0.GetType
                            oDCJuros.DataType = 0.0.GetType
                            oDCDesconto.DataType = 0.0.GetType
                            oDCValorDevido.DataType = 0.0.GetType

                            'Adiciona Linhas ao DataTable
                            Dim oDataRow As DataRow = oDataTable.NewRow
                            oDataRow("numero_documento") = grdListagem.CurrentRow.Parent.Cells("numero_documento").Value
                            oDataRow("data_emissao") = grdListagem.CurrentRow.Parent.Cells("data_emissao").Value
                            oDataRow("parcela") = grdListagem.CurrentRow.Cells("parcela").Value
                            oDataRow("parceiro_negocio") = grdListagem.CurrentRow.Parent.Cells("parceiro_negocio").Value
                            oDataRow("descritivo") = grdListagem.CurrentRow.Parent.Cells("descritivo").Value
                            oDataRow("data_vencimento") = grdListagem.CurrentRow.Cells("data_vencimento").Value
                            oDataRow("valor_total") = grdListagem.CurrentRow.Cells("valor_parcela").Value
                            oDataRow("valor_pago") = grdListagem.CurrentRow.Cells("valor_pago").Value
                            oDataRow("juros") = grdListagem.CurrentRow.Cells("juros").Value
                            oDataRow("desconto") = grdListagem.CurrentRow.Cells("desconto").Value
                            oDataRow("valor_devido") = grdListagem.CurrentRow.Cells("valor_corrigido").Value
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
                            frmMain.Informacao(Mensagem.DireitoInserir)
                        End If

                    Else
                        'Informa o Usuário que ele não tem Direito
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                    End If

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                End If

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

    Private Sub PagarAdiantamento()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Variaveis
            Dim iCodigoTipoDocumento As Integer = oClsFinReceitaAdiantamento.TipoDocumento

            'Instância
            Dim oClsFinReceitaPagamento As New clsUsrFinReceitaPagamento

            'Atualiza parcela do título Adiantamento para pago
            oClsFinReceitaPagamento.UpdateParcelaAdiantamento(btnSalvar.Tag, _
                                                              dtpDataVencimento.Value, _
                                                              txtValor.Text, _
                                                              txtValor.Text)

            'Verifica se o tipo de documento é Adiantamento
            If iCodigoTipoDocumento <> TipoDocumentoFinanceiro.Adiantamento Then

                'Valida Dados do Formulário
                If ValidacaoPagamentoAdiantamento() = True Then

                    Select Case LoadFormTipoDocumentoPagamento(cboTipoDocumentoPagamento.SelectedValue, _
                                                         "sp_select_static_form_tipo_documento_pagamento_receita")

                        Case "grpBoleto"
                            Call oClsFinReceitaPagamento.InsertPagamentoAdiantamento(cboContaBancaria.Text, _
                                                 cboTipoDocumentoPagamento.Text, _
                                                 txtNumeroBoleto1.Text & " " & txtNumeroBoleto2.Text & " " & txtNumeroBoleto3.Text & " " & txtNumeroBoleto4.Text & " " & txtNumeroBoleto5.Text & " " & txtNumeroBoleto6.Text & " " & txtNumeroBoleto7.Text & " " & txtNumeroBoleto8.Text, _
                                                 dtpDataPagamentoBoleto.Value, _
                                                 txtValorBoleto.Value, _
                                                 0, _
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
                                                 btnSalvar.Tag)

                        Case "grpOutros"
                            Call oClsFinReceitaPagamento.InsertPagamentoAdiantamento(cboContaBancaria.Text, _
                                                 cboTipoDocumentoPagamento.Text, _
                                                 txtNumeroDocumentoOutros.Text.Trim, _
                                                 dtpDataPagamentoOutros.Value, _
                                                 txtValorOutros.Value, _
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
                                                 btnSalvar.Tag)

                        Case "grpSaldoCliente"
                            Call oClsFinReceitaPagamento.InsertPagamentoAdiantamento(cboContaBancaria.Text, _
                                                 cboTipoDocumentoPagamento.Text, _
                                                 "", _
                                                 dtpDataPagamentoSaldoCliente.Value, _
                                                 txtValorSaldoCliente.Value, _
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
                                                 btnSalvar.Tag)

                        Case "grpDescontoDuplicata"
                            Call oClsFinReceitaPagamento.InsertPagamentoAdiantamento(cboContaBancaria.Text, _
                                                 cboTipoDocumentoPagamento.Text, _
                                                 txtNumeroDocumentoDescontoDuplicata.Text.Trim, _
                                                 dtpDataPagamentoDescontoDuplicata.Value, _
                                                 txtValorDescontoDuplicata.Value, _
                                                 txtJurosDescontoDuplicata.Value, _
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
                                                 btnSalvar.Tag)

                        Case "grpOutrosSimples"
                            Call oClsFinReceitaPagamento.InsertPagamentoAdiantamento(cboContaBancaria.Text, _
                                                 cboTipoDocumentoPagamento.Text, _
                                                 "", _
                                                 dtpDataPagamentoOutrosSimples.Value, _
                                                 txtValorOutrosSimples.Value, _
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
                                                 btnSalvar.Tag)

                        Case "grpCheque"
                            Call oClsFinReceitaPagamento.InsertPagamentoAdiantamento(cboContaBancaria.Text, _
                                                 cboTipoDocumentoPagamento.Text, _
                                                 txtNumeroDocumentoCheque.Text.Trim, _
                                                 dtpDataPagamentoCheque.Value, _
                                                 txtValorCheque.Value, _
                                                 0, _
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
                                                 btnSalvar.Tag)

                        Case "grpChequeTerceiro"

                            Dim sCodigo() As String = cboNumeroDocumentoChequeTerceiro.SelectedValue.ToString.Split("|")

                            Call oClsFinReceitaPagamento.InsertPagamentoAdiantamento(cboContaBancaria.Text, _
                                                 cboTipoDocumentoPagamento.Text, _
                                                 cboNumeroDocumentoChequeTerceiro.Text.Trim, _
                                                 dtpDataPagamentoChequeTerceiro.Value, _
                                                 txtValorChequeTerceiro.Value, _
                                                 0, _
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
                                                 btnSalvar.Tag)

                    End Select

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoPagamentoAdiantamento()

                End If
            End If

            'Valida Dados do Formulário
            If ValidacaoPagamentoAdiantamento() = True Then

                Select Case LoadFormTipoDocumentoPagamento(cboTipoDocumentoPagamento.SelectedValue, _
                                                          "sp_select_static_form_tipo_documento_pagamento_receita")

                    Case "grpBoleto"
                        'Insere Adiantamento
                        Call oClsFinReceitaPagamento.InsertLancamentoAdiantamento(cboCliente.SelectedValue, _
                                                                        cboContaBancaria.SelectedValue, _
                                                                        txtNumeroBoleto1.Text & " " & txtNumeroBoleto2.Text & " " & txtNumeroBoleto3.Text & " " & txtNumeroBoleto4.Text & " " & txtNumeroBoleto5.Text & " " & txtNumeroBoleto6.Text & " " & txtNumeroBoleto7.Text & " " & txtNumeroBoleto8.Text, _
                                                                        txtValorBoleto.Value, _
                                                                        dtpDataPagamentoBoleto.Value, _
                                                                        btnSalvar.Tag)

                    Case "grpOutros"
                        'Insere Adiantamento
                        Call oClsFinReceitaPagamento.InsertLancamentoAdiantamento(cboCliente.SelectedValue, _
                                                                        cboContaBancaria.SelectedValue, _
                                                                        txtNumeroDocumentoOutros.Text.Trim, _
                                                                        txtValorOutros.Value, _
                                                                        dtpDataPagamentoOutros.Value, _
                                                                        btnSalvar.Tag)

                    Case "grpSaldoCliente"
                        'Insere Adiantamento
                        Call oClsFinReceitaPagamento.InsertLancamentoAdiantamento(cboCliente.SelectedValue, _
                                                                        cboContaBancaria.SelectedValue, _
                                                                        "", _
                                                                        txtValorSaldoCliente.Value, _
                                                                        dtpDataPagamentoSaldoCliente.Value, _
                                                                        btnSalvar.Tag)

                    Case "grpDescontoDuplicata"
                        'Insere Adiantamento
                        Call oClsFinReceitaPagamento.InsertLancamentoAdiantamento(cboCliente.SelectedValue, _
                                                                        cboContaBancaria.SelectedValue, _
                                                                        txtNumeroDocumentoDescontoDuplicata.Text.Trim, _
                                                                        txtValorDescontoDuplicata.Value, _
                                                                        dtpDataPagamentoDescontoDuplicata.Value, _
                                                                        btnSalvar.Tag)

                    Case "grpOutrosSimples"
                        'Insere Adiantamento
                        Call oClsFinReceitaPagamento.InsertLancamentoAdiantamento(cboCliente.SelectedValue, _
                                                                        cboContaBancaria.SelectedValue, _
                                                                        "", _
                                                                        txtValorOutrosSimples.Value, _
                                                                        dtpDataPagamentoOutrosSimples.Value, _
                                                                        btnSalvar.Tag)

                    Case "grpCheque"
                        'Insere Adiantamento
                        Call oClsFinReceitaPagamento.InsertLancamentoAdiantamento(cboCliente.SelectedValue, _
                                                                        cboContaBancaria.SelectedValue, _
                                                                        txtNumeroDocumentoCheque.Text.Trim, _
                                                                        txtValorCheque.Value, _
                                                                        dtpDataPagamentoCheque.Value, _
                                                                        btnSalvar.Tag)

                    Case "grpChequeTerceiro"
                        'Insere Adiantamento
                        Call oClsFinReceitaPagamento.InsertLancamentoAdiantamento(cboCliente.SelectedValue, _
                                                                        cboContaBancaria.SelectedValue, _
                                                                        cboNumeroDocumentoChequeTerceiro.Text.Trim, _
                                                                        txtValorChequeTerceiro.Value, _
                                                                        dtpDataPagamentoChequeTerceiro.Value, _
                                                                        btnSalvar.Tag)

                End Select

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoPagamentoAdiantamento()

            End If


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoPagamentoAdiantamento()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            cboContaBancaria.SelectedIndex = -1
            cboTipoDocumentoPagamento.SelectedIndex = -1

            'Váriaveis Locais
            Dim dValorDevido As Double

            'Seta Valor Devido
            dValorDevido = txtValor.Text
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

            ElseIf grpCartaoCredito.Visible = True Then

                'Limpa Controles - Cartão de Crédito
                cboMaquinaCartao.Text = ""
                cboBandeiraCartaoCredito.DataSource = Nothing : cboBandeiraCartaoCredito.Text = ""
                dtpDataPagamentoCartaoCredito.Value = Now.Date
                txtValorCartaoCredito.Value = 0
                txtNumeroParcelaCartaoCredito.Text = ""
                'Seta Focu
                cboMaquinaCartao.Focus()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoPagamentoAdiantamento() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoPagamentoAdiantamento = False

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
            Dim dValorDevido As Double = txtValor.Text

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

                'Verifica se foi Selecionado o Campo - Máquina - Cartão
                If ValidaCampo(cboMaquinaCartao, lblMaquinaCartao) = False Then
                    Return False
                End If

                'Verifica se foi Selecionado o Campo - Bandeira - Cartão de Crédito
                If ValidaCampo(cboBandeiraCartaoCredito, lblBandeiraCartaoCredito) = False Then
                    Return False
                End If

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

            'Seta Retorno da Função
            ValidacaoPagamentoAdiantamento = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub CancelarPagamento()

        Try

            'Verifica se a Parcela já está paga
            If grdListagem.CurrentRow.Cells("valor_pago").Value > 0 Then

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

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DuplicarParcela()

        Try

            'Verifica se a Parcela está Paga
            If grdListagem.CurrentRow.Cells("valor_pago").Value > 0 Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Esta Parcela já se encontra Paga.")
                Exit Sub
            End If

            'Verifica se o Usuário possui direito para Duplicar a Parcela
            If VerificaDireito(Formulario.FinanceiroReceitaAdiantamento, gcUpdate) = False Then
                frmMain.Informacao(Mensagem.DireitoAlteracao)
                Exit Sub
            End If

            'Váriavel - Formulário
            Dim oForm As New frmFinTituloDuplicarParcela

            'Seta Parâmetros
            oForm.DataParcela = grdListagem.CurrentRow.Cells("data_vencimento").Value
            oForm.Parcela = grdListagem.CurrentRow.Cells("parcela").Value
            oForm.Descritivo = grdListagem.CurrentRow.Parent.Cells("descritivo").Value
            oForm.Valor = grdListagem.CurrentRow.Cells("valor_parcela").Value
            oForm.CodigoTituloCapa = grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value
            oForm.NumeroParcela = grdListagem.CurrentRow.Cells("numero_parcela").Value

            'Abre Formulário
            oForm.ShowDialog(Me)

            'Recarrega Grid
            Call LoadGrid()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CLASSIFICAÇÃO :::"

    Private Sub InserirClassificacao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoClassificacao() = True Then

                'Váriaveis - Update
                Dim iCodigoCentroGastoAntigo As Integer = -1
                Dim sCodigoContaContabilAntigo As String = ""

                'Carrega Váriaveis
                If IsNumeric(btnInserirClassificao.Tag) Then
                    iCodigoCentroGastoAntigo = IIf(IsDBNull(grdClassificacao.CurrentRow.Cells("codigo_centro_custo").Value), -1, grdClassificacao.CurrentRow.Cells("codigo_centro_custo").Value)
                    sCodigoContaContabilAntigo = IIf(IsDBNull(grdClassificacao.CurrentRow.Cells("codigo_conta_contabil").Value), "", grdClassificacao.CurrentRow.Cells("codigo_conta_contabil").Value)
                End If

                'Insere Registro na Grid
                oClsFinReceitaAdiantamento.InsertClassificacaoGrid(grdClassificacao, _
                                                                 IIf(cboCentroGasto.SelectedIndex = -1, "", cboCentroGasto.Text), _
                                                                 IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.Text), _
                                                                 txtValorClassificacao.Value, _
                                                                 IIf(cboCentroGasto.SelectedIndex = -1, -1, cboCentroGasto.SelectedValue), _
                                                                 IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.SelectedValue), _
                                                                 IIf(IsNumeric(btnInserirClassificao.Tag), "U", "I"), _
                                                                 iCodigoCentroGastoAntigo, _
                                                                 sCodigoContaContabilAntigo)

                'Limpa Formulário
                Call NovoClassificacao()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarClassificacao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FinanceiroReceitaAdiantamento, gcUpdate) = True Then

                'Carrega Controles
                cboCentroGasto.SelectedValue = grdClassificacao.CurrentRow.Cells("codigo_centro_custo").Value
                cboContaContabil.SelectedValue = grdClassificacao.CurrentRow.Cells("codigo_conta_contabil").Value
                txtValorClassificacao.Value = grdClassificacao.CurrentRow.Cells("valor").Value
                btnInserirClassificao.Tag = grdClassificacao.CurrentRow.RowIndex

                'Seta Focu
                cboCentroGasto.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteClassificacao()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdClassificacao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Dim i As Integer

                    For i = 0 To UBound(gSelecaoRow)
                        gSelecaoRow(i).Delete()
                    Next

                    'Limpa Formulário
                    Call NovoClassificacao()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoClassificacao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboCentroGasto.SelectedIndex = -1
            cboContaContabil.SelectedIndex = -1
            txtValorClassificacao.Value = 0
            btnInserirClassificao.Tag = ""

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoClassificacao() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoClassificacao = False

            'Verifica se foi Selecionado o Campo - Centro de Gasto ou Conta Contábil
            If cboCentroGasto.SelectedIndex = -1 And cboContaContabil.SelectedIndex = -1 Then
                frmMain.errInfo.SetError(lblCentroGasto, "Primeiramente Selecione um Centro de Gasto ou uma Conta Contábil.")
                cboCentroGasto.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor
            If ValidaCampo(txtValorClassificacao, lblValorClassificacao, True) = False Then
                Exit Function
            End If

            'Valida se a Soma do Valor Classificação é maior que o Valor Total
            Dim dValor, dValorTotal As Double

            If IsNumeric(btnInserirClassificao.Tag) Then
                dValor = grdClassificacao.CurrentRow.Cells("valor").Value
            End If
            If grdClassificacao.GetDataRows.Count > 0 Then
                dValorTotal = grdClassificacao.GetTotalRow.Cells("valor").Value
            End If
            If (txtValor.Value < FormatNumber((dValorTotal - dValor + txtValorClassificacao.Value), 2)) Then
                frmMain.errInfo.SetError(lblValorClassificacao, "A Soma dos Valores (Classificação) não pode ser maior que o Valor Total.")
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoClassificacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

  
End Class

