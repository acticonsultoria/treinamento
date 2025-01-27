Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrFinDespesaLancamento

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinDespesaLancamento As New clsUsrFinDespesaLancamento

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrFinDespesaLancamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboFornecedor" : Call btnProcurarFornecedor_Click(btnProcurarFornecedor, System.EventArgs.Empty)
                        Case "txtFornecedorFiltro" : Call btnProcurarFornecedorFiltro_Click(btnProcurarFornecedorFiltro, System.EventArgs.Empty)
                        Case "cboCentroGasto" : Call btnProcurarCentroCusto_Click(btnProcurarCentroCusto, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnProcurarContaContabil_Click(btnProcurarContaContabil, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboTipoDocumento" : Call LoadCombo(cboTipoDocumento, "sp_select_combo_cadastro_basico_tipo_documento " & goUsuario.iEmpresa)
                        Case "cboFornecedor" : Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)
                        Case "cboMoeda" : Call LoadCombo(cboMoeda, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)
                        Case "cboCentroGasto" : Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboContaContabil" : Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)
                        Case "cboNotaFiscalEntrada" : Call LoadCombo(cboNotaFiscalEntrada, "sp_select_combo_faturamento_nota_fiscal_entrada " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboTipoDocumento" : Call btnCadastrarTipoDocumento_Click(btnCadastrarTipoDocumento, System.EventArgs.Empty)
                        Case "cboFornecedor" : Call btnCadastrarFornecedor_Click(btnCadastrarFornecedor, System.EventArgs.Empty)
                        Case "cboMoeda" : Call btnCadastrarMoeda_Click(btnCadastrarMoeda, System.EventArgs.Empty)
                        Case "cboCentroGasto" : Call btnCadastrarCentroGasto_Click(btnCadastrarCentroGasto, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnCadastrarContaContabil_Click(btnCadastrarContaContabil, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFinDespesaLancamento_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: TÍTULO :::"

    Private Sub tabDados_SelectedTabChanged(sender As Object, e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabDados.SelectedTabChanged

        Try

            btnImportarContaRateavel.Visible = False

            If tabDados.SelectedTab.Key = pagClassificacao.Key Then
                btnImportarContaRateavel.Visible = True
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCadastrarTipoDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTipoDocumento.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTipoDocumento")

            'Carrega Combo            
            LoadCombo(cboTipoDocumento, "sp_select_combo_cadastro_basico_tipo_documento " & goUsuario.iEmpresa)

            'Seta Focu
            cboTipoDocumento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarFornecedor.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")


            'Carrega Combo            
            LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)

            'Seta Focu
            cboFornecedor.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarMoeda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarMoeda.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadMoeda")

            'Carrega Combo            
            LoadCombo(cboMoeda, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)

            'Seta Focu
            cboMoeda.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarFornecedorFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarFornecedorFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.fornecedor
            oMaskedEditBoxFind = txtFornecedorFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            txtFornecedorFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarFornecedor.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.fornecedor
            oComboBoxFind = cboFornecedor

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboFornecedor.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDespesa)

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

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = False Then Exit Sub

            'Salva Dados do Registro
            Salvar()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDespesa)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboMoeda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoeda.SelectedIndexChanged

        Try

            'Verifica a Moeda
            If cboMoeda.SelectedIndex = -1 Then
                txtFatorCambial.Enabled = False
                txtFatorCambial.Value = 1
            ElseIf cboMoeda.SelectedValue = Moeda.Real Then
                txtFatorCambial.Enabled = False
                txtFatorCambial.Value = 1
            Else
                txtFatorCambial.Enabled = True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna Pressionada é Válida
            If IsNothing(grdListagem) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "duplicar" : Duplicar()
                Case "historico" : Historico()
                Case "editar" : Editar()
                Case "editar_parcela" : EditarDuplicata()
                Case "pagar" : Pagar()
                Case "cancelar" : CancelarPagamento()
                Case "duplicar_parcela" : DuplicarParcela()

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
                                     Formulario.FinanceiroDespesaLancamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FinanceiroDespesaLancamento, _
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
                                          Formulario.FinanceiroDespesaLancamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub FormCalculaValorTotal() Handles txtValor.ValueChanged, _
                                                txtDescontoValor.ValueChanged, _
                                                txtDescontoPercentual.ValueChanged

        'Calcula Valor Total
        txtValorTotal.Value = txtValor.Value - (txtValor.Value * txtDescontoPercentual.Value / 100) - txtDescontoValor.Value


    End Sub

    Private Sub FormCalculaValorTotal(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValor.ValueChanged, txtDescontoValor.ValueChanged, txtDescontoPercentual.ValueChanged

    End Sub

    Private Sub btnVincular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVincular.Click
        Try
            If ValidaCampo(cboTituloPrevisto, lblTituloPrevisto) = False Then Exit Sub
            If CStr(btnSalvar.Tag) = "" Then
                MsgBox("Primeiramente, salve o lançamento.", MsgBoxStyle.Question + MsgBoxStyle.OkOnly, Me.Parent.Text)
                Exit Sub
            End If

            oClsFinDespesaLancamento.LoadControlesTituloPrevisao(cboTituloPrevisto.SelectedValue, _
                                                                txtNumDocumentoPrevisto, _
                                                                txtValorPrevisto, _
                                                                dtpDataVencimentoPrevisto)

            oClsFinDespesaLancamento.UpdateVinculoTituloPrevisao(cboTituloPrevisto.SelectedValue)
            oClsFinDespesaLancamento.DeleteVinculoTituloPrevisao(cboTituloPrevisto.SelectedValue)
            cboTituloPrevisto.Enabled = False


        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboTituloPrevisto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTituloPrevisto.SelectedIndexChanged
        Try

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboFornecedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFornecedor.SelectedIndexChanged

        Try

            cboTituloPrevisto.DataSource = Nothing : cboTituloPrevisto.SelectedIndex = -1

            If cboFornecedor.SelectedIndex = -1 Then Exit Sub

            LoadCombo(cboTituloPrevisto, "sp_select_combo_financeiro_titulo_previsao " & goUsuario.iEmpresa & ", " & cboFornecedor.SelectedValue)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboTipoTituloFinanceiro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoTituloFinanceiro.SelectedIndexChanged
        Try
            'If cboTipoTituloFinanceiro.SelectedValue = 2 Then
            '    grpTituloPrevisto.Visible = False
            'Else
            '    grpTituloPrevisto.Visible = True
            'End If
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAtualizarDescritivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizarDescritivo.Click
        Try
            ExecuteQuery("sp_update_financeiro_titulo_descritivo " & btnSalvar.Tag & "," & goUsuario.iEmpresa & ",'" & txtDescritivo.Text & "'")
            frmMain.Informacao("Descritivo salvo com sucesso!", Color.Blue)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub grdControlesEdicao_Click(sender As Object, e As EventArgs) Handles grdControlesEdicao.Click

    End Sub

#End Region

#Region "::: PARCELA :::"

    Private Sub cboCondicaoPagamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCondicaoPagamento.SelectedIndexChanged

        Try

            If cboCondicaoPagamento.SelectedIndex = -1 Then

                txtNumeroParcela.Value = 0 : txtNumeroParcela.Enabled = True
                txtIntervaloParcela.Value = 0 : txtIntervaloParcela.Enabled = True

            Else

                txtNumeroParcela.Value = LoadCodigo("sp_load_cadastro_basico 'tb_cad_condicao_pagamento', 'numero_parcela', " & cboCondicaoPagamento.SelectedValue & "," & goUsuario.iEmpresa)
                txtIntervaloParcela.Value = LoadCodigo("sp_load_cadastro_basico 'tb_cad_condicao_pagamento', 'intervalo_parcela', " & cboCondicaoPagamento.SelectedValue & "," & goUsuario.iEmpresa)

                txtNumeroParcela.Enabled = False
                txtIntervaloParcela.Enabled = False

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCalcularDuplicata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularDuplicata.Click

        Try

            GerarDuplicata()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdDuplicata_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdDuplicata.CellValueChanged

        Try

            Select Case e.Column.Key

                Case "pago"
                    Dim j As Integer = grdDuplicata.CurrentRow.RowIndex
                    If grdDuplicata.GetValue(e.Column) = True Then
                        Dim oRow() As GridEXRow
                        oRow = grdDuplicata.GetDataRows
                        For i = 0 To UBound(oRow)
                            If j = oRow(i).RowIndex Then
                                Exit For
                            End If
                            grdDuplicata.Row = oRow(i).RowIndex
                            grdDuplicata.SetValue(e.Column, True)
                        Next
                    ElseIf grdDuplicata.GetValue(e.Column) = False Then
                        Dim oRow() As GridEXRow
                        oRow = grdDuplicata.GetDataRows
                        For i = UBound(oRow) To 0 Step -1
                            If j = oRow(i).RowIndex Then
                                Exit For
                            End If
                            grdDuplicata.Row = oRow(i).RowIndex
                            grdDuplicata.SetValue(e.Column, False)
                        Next
                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCondicaoPagamento_Click(sender As Object, e As EventArgs) Handles btnCadastrarCondicaoPagamento.Click

        Try

            Try

                'Abre Formulário de Cadastro
                LoadUsrControlForm(Me, "usrCadCondicaoPagamento")

                'Carrega Combo            
                LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)

                cboCondicaoPagamento.Focus()

            Catch ex As Exception
                TratamentoErro(ex.Message, Me.Name)
            End Try

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: CLASSIFICAÇÃO :::"

    Private Sub btnImportarContaRateavel_Click(sender As Object, e As EventArgs) Handles btnImportarContaRateavel.Click

        Try

            If IsNumeric(btnSalvar.Tag) = False Then btnSalvar_Click(btnSalvar, Nothing)

            Dim oForm As New frmFinTituloImportarContaRateavel
            oForm.CodigoTitulo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oForm.ShowDialog()

            oClsFinDespesaLancamento.LoadGridClassificacao(grdClassificacao, _
                                                           btnSalvar.Tag)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnAgruparGridClassificacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridClassificacao.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdClassificacao.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdClassificacao.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdClassificacao.GroupByBoxVisible = True
                grdClassificacao.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridClassificacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridClassificacao.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdClassificacao
            oForm.NomeFormulario = Formulario.FinanceiroDespesaLancamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdClassificacao, Formulario.FinanceiroDespesaLancamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridClassificacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridClassificacao.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdClassificacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroCusto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            oComboBoxFind = cboCentroGasto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarContaContabil.Click

        Try
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindPlanoContas"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Conta Contábil"
            oComboBoxFind = cboContaContabil
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGasto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo            
            LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabil.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")

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

            'Verifica se a Coluna Pressionada é Válida
            If IsNothing(grdClassificacao) Then Exit Sub

            Select Case grdClassificacao.CurrentColumn.Key

                Case "editar" : Call EditarClassificacao()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdClassificacao_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdClassificacao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdClassificacao, _
                                     Formulario.FinanceiroDespesaLancamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdClassificacao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdClassificacao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdClassificacao.Name, _
                                     Formulario.FinanceiroDespesaLancamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdClassificacao_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdClassificacao.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdClassificacao.Name, _
                                          Formulario.FinanceiroDespesaLancamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: NOTA FISCAL ENTRADA :::"

    Private Sub btnAgruparGridNotaFiscalEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridNotaFiscalEntrada.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdNotaFiscalEntrada.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdNotaFiscalEntrada.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdNotaFiscalEntrada.GroupByBoxVisible = True
                grdNotaFiscalEntrada.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridNotaFiscalEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridNotaFiscalEntrada.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdNotaFiscalEntrada
            oForm.NomeFormulario = Formulario.FinanceiroDespesaLancamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdNotaFiscalEntrada, Formulario.FinanceiroDespesaLancamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridNotaFiscalEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridNotaFiscalEntrada.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdNotaFiscalEntrada)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirNotaFiscalEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirNotaFiscalEntrada.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Nota Fiscal
            If ValidaCampo(cboNotaFiscalEntrada, lblNotaFiscalEntrada) = False Then
                Exit Sub
            End If

            'Insere Nota Fiscal de Entrada
            Call InserirNotaFiscalEntrada()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirNotaFiscalEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirNotaFiscalEntrada.Click

        Try

            'Exclui Nota Fiscal de Entrada
            Call DeleteNotaFiscalEntrada()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalEntrada_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdNotaFiscalEntrada.RowDoubleClick

        Try

            'Verifica se a Coluna Pressionada é Válida
            If IsNothing(grdNotaFiscalEntrada) Then Exit Sub

            Select Case grdClassificacao.CurrentColumn.Key
                Case "editar" : Call EditarNotaFiscalEntrada()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalEntrada_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdNotaFiscalEntrada.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNotaFiscalEntrada, _
                                     Formulario.FinanceiroDespesaLancamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalEntrada_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdNotaFiscalEntrada.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNotaFiscalEntrada.Name, _
                                     Formulario.FinanceiroDespesaLancamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalEntrada_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdNotaFiscalEntrada.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdNotaFiscalEntrada.Name, _
                                          Formulario.FinanceiroDespesaLancamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

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
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFinDespesaLancamento_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.FinanceiroDespesaLancamento, gcDelete)
            btnNovo.Enabled = VerificaDireito(Formulario.FinanceiroDespesaLancamento, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.FinanceiroDespesaLancamento, gcInsert)

            'Verifica Direito - Botão de Cadastro            
            btnCadastrarTipoDocumento.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoDocumento, gcInsert)
            btnCadastrarFornecedor.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarMoeda.Enabled = VerificaDireito(Formulario.CadastroBasicoMoeda, gcInsert)
            btnCadastrarCentroGasto.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)
            btnCadastrarContaContabil.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcInsert)

            'Carrega ComboBox - Vetor
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboTipoTituloFinanceiroFiltro : oComboBox(1) = cboTipoTituloFinanceiro
            LoadCombo(oComboBox, "sp_select_combo_static_tipo_titulo_financeiro")

            'Carrega ComboBox
            LoadCombo(cboTipoDocumento, "sp_select_combo_cadastro_basico_tipo_documento " & goUsuario.iEmpresa, False)
            LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_titulo")
            LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa, False)
            LoadCombo(cboMoeda, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa, False)
            LoadCombo(cboFormaPagamento, "sp_select_combo_static_tipo_documento_pagamento", False)
            LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa, False)
            LoadCombo(cboNotaFiscalEntrada, "sp_select_combo_faturamento_nota_fiscal_entrada " & goUsuario.iEmpresa, False)
            LoadCombo(cboContaBancariaFiltro, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)
            LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)

            'Seta Controle
            dtpDataEmissaoInicioFiltro.Checked = False : dtpDataEmissaoInicioFiltro.Value = Now.Date
            dtpDataEmissaoTerminoFiltro.Checked = False : dtpDataEmissaoTerminoFiltro.Value = Now.Date
            dtpDataVencimentoInicioFiltro.Checked = False : dtpDataVencimentoInicioFiltro.Value = Now.Date
            dtpDataVencimentoTerminoFiltro.Checked = False : dtpDataVencimentoTerminoFiltro.Value = Now.Date
            dtpDataPagamentoInicioFiltro.Checked = False : dtpDataPagamentoInicioFiltro.Value = Now.Date
            dtpDataPagamentoTerminoFiltro.Checked = False : dtpDataPagamentoTerminoFiltro.Value = Now.Date
            dtpDataInputInicioFiltro.Checked = False : dtpDataInputInicioFiltro.Value = Now.Date
            dtpDataInputTerminoFiltro.Checked = False : dtpDataInputTerminoFiltro.Value = Now.Date

            'Configura Grid
            ConfiguraGrid(grdListagem, Formulario.FinanceiroDespesaLancamento)
            ConfiguraGrid(grdClassificacao, Formulario.FinanceiroDespesaLancamento)
            ConfiguraGrid(grdNotaFiscalEntrada, Formulario.FinanceiroDespesaLancamento)

            'Seta Aba
            tabMain.TabPages.Remove(pagDespesa)

            grpTituloPrevisto.Visible = False

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
            oClsFinDespesaLancamento.LoadGrid(grdListagem, _
                                              txtNumeroDocumentoFiltro.Text.Trim, _
                                              txtSerieFiltro.Text.Trim, _
                                              txtFornecedorFiltro.Text.Trim, _
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
                                              txtDescritivoFiltro.Text.Trim, _
                                              IIf(dtpDataInputInicioFiltro.Checked = False, "", dtpDataInputInicioFiltro.Value), _
                                              IIf(dtpDataInputTerminoFiltro.Checked = False, "", dtpDataInputTerminoFiltro.Value))

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
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsFinDespesaLancamento.Delete()
                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de selecionar um ou mais Registros
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos." & vbCrLf & vbCrLf & _
                       "** Registros com status: ABERTO." & vbCrLf & _
                       "** Registros não vinculados a um Pedido de Compra / Entrada de NF.", MsgBoxStyle.Exclamation, Me.Parent.Text)
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
            cboTipoDocumento.SelectedIndex = IIf(cboTipoDocumento.Items.Count = 1, 0, -1)
            cboFornecedor.SelectedIndex = IIf(cboFornecedor.Items.Count = 1, 0, -1)
            dtpDataEmissao.Value = Now.Date
            cboTipoTituloFinanceiro.SelectedIndex = TipoTituloFinanceiro.Real
            cboMoeda.SelectedIndex = IIf(cboMoeda.Items.Count = 1, 0, -1)
            txtMultaPagamento.Value = 0
            txtJurosPagamento.Value = 0
            txtDescontoPagamento.Value = 0
            txtDescritivo.Text = ""
            txtValor.Value = 0
            txtDescontoValor.Value = 0
            txtDescontoPercentual.Value = 0
            txtValorTotal.Value = 0
            cboTituloPrevisto.SelectedIndex = -1
            txtValorPrevisto.Value = 0
            txtNumDocumentoPrevisto.Text = ""
            dtpDataVencimentoPrevisto.Value = Now.Date
            cboTituloPrevisto.Enabled = True
            'Limpa Controles - Duplicata
            cboFormaPagamento.SelectedIndex = IIf(cboFormaPagamento.Items.Count = 1, 0, -1)
            txtNumeroParcela.Value = 0
            txtIntervaloParcela.Value = 0
            grdDuplicata.DataSource = Nothing
            grdDuplicata.AllowEdit = InheritableBoolean.True
            cboCondicaoPagamento.SelectedIndex = -1

            'Limpa Controles - Classificação
            cboCentroGasto.SelectedIndex = -1
            cboContaContabil.SelectedIndex = -1
            txtValorClassificacao.Value = 0
            btnInserirClassificao.Tag = ""
            btnInserirClassificao.Enabled = True
            btnExcluirClassificacao.Enabled = True
            grdClassificacao.DataSource = Nothing
            grdClassificacao.AllowEdit = InheritableBoolean.True

            'Limpa Controles - Nota Fiscal
            cboNotaFiscalEntrada.SelectedIndex = -1
            txtSerieNotaFiscalEntrada.Text = ""
            txtDataEmissaoNotaFiscalEntrada.Text = ""
            txtFornecedorNotaFiscalEntrada.Text = ""
            txtValorNotaFiscalEntrada.Value = 0
            btnInserirNotaFiscalEntrada.Tag = ""
            grdNotaFiscalEntrada.DataSource = Nothing
            grdNotaFiscalEntrada.AllowEdit = InheritableBoolean.True

            'Habilita Controles
            grdDuplicata.AllowEdit = InheritableBoolean.True
            btnCalcularDuplicata.Enabled = True
            btnSalvar.Enabled = VerificaDireito(Formulario.FinanceiroDespesaLancamento, gcInsert)

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
            oClsFinDespesaLancamento.CodigoDespesaCapa = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsFinDespesaLancamento.NumeroDocumento = txtNumeroDocumento.Text.Trim
            oClsFinDespesaLancamento.Serie = txtSerie.Text.Trim
            oClsFinDespesaLancamento.TipoDocumento = cboTipoDocumento.SelectedValue
            oClsFinDespesaLancamento.ParceiroNegocio = cboFornecedor.SelectedValue
            oClsFinDespesaLancamento.DataEmissao = dtpDataEmissao.Value
            oClsFinDespesaLancamento.TipoTituloFinanceiro = cboTipoTituloFinanceiro.SelectedValue
            oClsFinDespesaLancamento.Moeda = cboMoeda.SelectedValue
            oClsFinDespesaLancamento.FatorCambial = txtFatorCambial.Value
            oClsFinDespesaLancamento.MultaPagamento = txtMultaPagamento.Value
            oClsFinDespesaLancamento.JurosPagamento = txtJurosPagamento.Value
            oClsFinDespesaLancamento.DescontoPagamento = txtDescontoPagamento.Value
            oClsFinDespesaLancamento.Descritivo = txtDescritivo.Text.Trim
            oClsFinDespesaLancamento.Valor = txtValor.Value
            oClsFinDespesaLancamento.DescontoValor = txtDescontoValor.Value
            oClsFinDespesaLancamento.DescontoPercentual = txtDescontoPercentual.Value
            oClsFinDespesaLancamento.FormaPagamento = cboFormaPagamento.SelectedValue
            oClsFinDespesaLancamento.NumeroParcela = txtNumeroParcela.Value
            oClsFinDespesaLancamento.IntervaloParcela = txtIntervaloParcela.Value
            oClsFinDespesaLancamento.CodigoCondicaoPagamento = IIf(cboCondicaoPagamento.SelectedIndex = -1, -1, cboCondicaoPagamento.SelectedValue)

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsFinDespesaLancamento.Update()
                oClsFinDespesaLancamento.DeleteParcela(btnSalvar.Tag)
                oClsFinDespesaLancamento.InsertParcela(grdDuplicata)
                oClsFinDespesaLancamento.DeleteClassificacao(btnSalvar.Tag)
                oClsFinDespesaLancamento.InsertClassificacao(grdClassificacao)
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsFinDespesaLancamento.Insert()
                oClsFinDespesaLancamento.InsertParcela(grdDuplicata)
                oClsFinDespesaLancamento.InsertClassificacao(grdClassificacao)
                frmMain.Informacao(Mensagem.RegistroInserido)
                btnSalvar.Tag = oClsFinDespesaLancamento.CodigoDespesaCapa
            End If

            'Verifica o Tipo do Título Financeiro
            If cboTipoTituloFinanceiro.SelectedValue = CInt(TipoTituloFinanceiro.Real) Then

                'Caso Título Quitado
                If VerificaSelecaoRowCheckedDiferente(grdDuplicata, _
                                                     "pago", _
                                                     "valor_pago", _
                                                     "0") = True Then


                    'Abre Formulário de Cadastro
                    Dim oForm As New frmCadBasico
                    oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True

                    If ((goDatabase.sInitialCatalog = "INTERACTI_PERFORMA_PRD") Or (goDatabase.sInitialCatalog = "INTERACTI_SOBERANO_PRD")) Then
                        If cboFormaPagamento.Text = "CHEQUE" Then
                            oForm.UsrControl = "usrFinDespesaPagamentoCheque"
                        Else
                            oForm.UsrControl = "usrFinDespesaPagamento"
                        End If
                    Else
                        oForm.UsrControl = "usrFinDespesaPagamento"
                    End If

                    oForm.Titulo = "Financeiro - Despesa - Baixar Duplicatas"

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

                    For Each oRow As GridEXRow In gSelecaoRow

                        'Adiciona Linhas ao DataTable
                        Dim oDataRow As DataRow = oDataTable.NewRow
                        oDataRow("numero_documento") = txtNumeroDocumento.Text
                        oDataRow("parcela") = oRow.RowIndex + 1 & " DE " & grdDuplicata.GetDataRows.Count
                        oDataRow("descritivo") = txtDescritivo.Text.Trim
                        oDataRow("data_vencimento") = oRow.Cells("data_vencimento").Value
                        oDataRow("valor_total") = oRow.Cells("valor").Value
                        oDataRow("valor_pago") = 0
                        oDataRow("juros") = 0
                        oDataRow("desconto") = 0
                        oDataRow("valor_devido") = oRow.Cells("valor").Value
                        oDataRow("codigo_titulo_capa") = oClsFinDespesaLancamento.CodigoDespesaCapa
                        oDataRow("numero_parcela") = oRow.RowIndex + 1
                        oDataTable.Rows.Add(oDataRow)

                    Next

                    'Seta Parâmetros
                    Dim oFormularioCadastroBasico(0) As FormularioCadastroBasico
                    oFormularioCadastroBasico(0).oValor = oDataSet : oFormularioCadastroBasico(0).sControle = "grdParcela"
                    oForm.CadastroBasico = oFormularioCadastroBasico

                    'Abre o Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                End If

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
            If VerificaDireito(Formulario.FinanceiroDespesaLancamento, gcUpdate) = True Then

                'Carrega Controles
                oClsFinDespesaLancamento.LoadControles(grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value, _
                                                       txtNumeroDocumento, _
                                                       txtSerie, _
                                                       cboTipoDocumento, _
                                                       cboFornecedor, _
                                                       dtpDataEmissao, _
                                                       cboTipoTituloFinanceiro, _
                                                       cboMoeda, _
                                                       txtFatorCambial, _
                                                       txtMultaPagamento, _
                                                       txtJurosPagamento, _
                                                       txtDescontoPagamento, _
                                                       txtDescritivo, _
                                                       txtValor, _
                                                       txtDescontoValor, _
                                                       txtDescontoPercentual, _
                                                       cboFormaPagamento, _
                                                       txtNumeroParcela, _
                                                       txtIntervaloParcela, _
                                                       txtNumDocumentoPrevisto, _
                                                       txtValorPrevisto, _
                                                       dtpDataVencimentoPrevisto, _
                                                       cboTituloPrevisto, _
                                                       cboCondicaoPagamento)

                btnSalvar.Tag = grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value

                'Carrega Grid de Parcela
                oClsFinDespesaLancamento.LoadGridParcela(grdDuplicata, _
                                                         grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value)

                'Carrega Grid de Classificação
                oClsFinDespesaLancamento.LoadGridClassificacao(grdClassificacao, _
                                                               grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value)

                'Desabilita Controles Caso não possa ser Editado o Registro
                If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusTitulo.Aberto) Then
                    grdDuplicata.AllowEdit = InheritableBoolean.True
                    grdClassificacao.AllowEdit = InheritableBoolean.True
                    btnCalcularDuplicata.Enabled = True
                    btnSalvar.Enabled = True
                    btnInserirClassificao.Enabled = True
                    btnExcluirClassificacao.Enabled = True
                Else
                    grdDuplicata.AllowEdit = InheritableBoolean.False
                    grdClassificacao.AllowEdit = InheritableBoolean.False
                    btnCalcularDuplicata.Enabled = False
                    btnSalvar.Enabled = False
                    btnInserirClassificao.Enabled = False
                    btnExcluirClassificacao.Enabled = False
                End If
                ' cboTituloPrevisto.Enabled = True
                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDespesa)
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

            Dim oForm As New frmLogAlteracao
            oForm.Tabela = "tb_fin_titulo_capa"
            oForm.Codigo = grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value

            oForm.ShowDialog()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Cancelar()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FinanceiroDespesaLancamento, gcAdministrator) = True Then

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
                    frmMain.Informacao(Mensagem.ValidacaoSelecionar)
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
            If VerificaDireito(Formulario.FinanceiroDespesaLancamento, gcAdministrator) = True Then

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
                    frmMain.Informacao(Mensagem.ValidacaoSelecionar)
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
            If VerificaDireito(Formulario.FinanceiroDespesaLancamento, gcInsert) = True Then

                'Váriaveis - Formulário
                Dim oForm As New frmFinTituloDuplicar
                oForm.Tipo = "D"
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

    Private Function Validacao() As Boolean

        Try

            'Verifica se foi Preenchido o Campo - Número Documento
            If txtNumeroDocumento.Text.Trim = "" Then
                'Verifica se o Usuário quer que o Sistema gere o Número do Documento Automaticamente
                If MsgBox("Deseja que o Sistema gere o Número do Documento Automaticamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then
                    txtNumeroDocumento.Text = oClsFinDespesaLancamento.GerarNumeroDocumento
                End If
            End If

            'Verifica se foi Preenchido o Campo - Tipo Documento
            If ValidaCampo(cboTipoDocumento, lblTipoDocumento) = False Then Return False

            'Verifica se foi Preenchido o Campo - Fornecedor
            If ValidaCampo(cboFornecedor, lblFornecedor) = False Then Return False
            'Verifica se a Data de Emissão é do mês anterior
            If DateDiff(DateInterval.Month, dtpDataEmissao.Value, Now.Date) >= 1 Then
                If MsgBox("A Data de Emissão do Documento é diferente do mês corrente." & vbCrLf & "Essa data pode alterar o Fluxo de Caixa do mês anterior." & vbCrLf & vbCrLf & "Deseja prosseguir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Parent.Text) = MsgBoxResult.No Then
                    dtpDataEmissao.Focus()
                    Return False
                End If
            End If

            'Verifica se o Código Banco ja foi cadastrado
            If oClsFinDespesaLancamento.ValidaDespesaCapa(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                                          txtNumeroDocumento.Text.Trim, _
                                                          txtSerie.Text.Trim, _
                                                          cboFornecedor.SelectedValue) = False Then
                frmMain.errInfo.SetError(lblNumeroDocumento, "Este N° Documento: " & txtNumeroDocumento.Text.Trim & IIf(txtSerie.Text.Trim = "", "", "/" & txtSerie.Text.Trim) & " já está associado a outro Registro.")
                txtNumeroDocumento.Focus()
                Return False
            End If

            'Verifica se foi Preenchido o Campo - Tipo
            If ValidaCampo(cboTipoTituloFinanceiro, lblTipoTituloFinanceiro) = False Then Return False

            'Verifica se foi Preenchido o Campo - Moeda
            If ValidaCampo(cboMoeda, lblMoeda) = False Then
                tabDados.SelectedTab = pagDados
                Return False
            End If

            'Verifica se o Desconto Condicional é menor que 100
            If txtDescontoPagamento.Value >= 100 Then
                frmMain.errInfo.SetError(lblDescontoPagamento, "O Desconto Condicional (%) não pode ser maior ou igual a 100%.")
                Return False
            End If

            'Verifica se foi Preenchido o Campo - Descritivo
            If ValidaCampo(txtDescritivo, lblDescritivo, TipoCampo.texto) = False Then Return False

            'Verifica se foi Preenchido o Campo - Valor Unitário
            If cboFormaPagamento.SelectedValue <> CInt(TipoDocumentoPagamento.CartaoCredito) Then
                If ValidaCampo(txtValor, lblValor, True) = False Then
                    Return False
                End If
            End If

            'Verifica se foi Preenchido o Campo - Desconto Valor
            If ValidaCampo(txtDescontoValor, lblDescontoValor, False) = False Then Return False

            'Verifica se foi Preenchido o Campo - Desconto Percentual
            If ValidaCampo(txtDescontoPercentual, lblDescontoPercentual, False) = False Then Return False

            'Verifica se foi Preenchido o Campo - Forma de Pagamento
            If ValidaCampo(cboFormaPagamento, lblFormaPagamento) = False Then
                tabDados.SelectedTab = pagDados
                Return False
            End If

            'Verifica se o Valor das Parcelas é igual ao Valor Total
            If grdDuplicata.GetDataRows.Count = 0 Then
                frmMain.Informacao(Mensagem.NaoFoiInformado, "Parcelas")
                btnCalcularDuplicata.Focus()
                Return False
            ElseIf grdDuplicata.GetTotalRow.Cells("valor").Value <> txtValorTotal.Value Then
                MsgBox("O Valor da(s) Parcela(s) não corresponde ao Valor Total do Título. Favor verificar.", MsgBoxStyle.Exclamation)
                Return False
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaSelecaoRowLancamento(ByVal oGrid As GridEX) As Boolean

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

                        'Verifica se foi Selecionado
                        If oRow.Cells("status").Value = CInt(StatusTitulo.Aberto) And _
                           IsDBNull(oRow.Cells("codigo_integracao").Value) Then

                            'Redimensiona Vetor caso necessário
                            If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                                ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                            End If

                            'Seta Retorno da Função
                            VerificaSelecaoRowLancamento = True

                            'Seta Valores
                            gSelecaoRow(UBound(gSelecaoRow)) = oRow

                        End If

                    Next

                End If

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: PARCELA :::"

    Private Sub EditarDuplicata()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FinanceiroDespesaLancamento, gcUpdate) = True Then

                'Verifica se a Duplicata já foi Baixada
                If grdListagem.CurrentRow.Cells.Item("valor_pago").Value = 0 Then

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
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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

                If grdListagem.CurrentRow.Parent.Cells("tipo_titulo_financeiro").Value <> "PREVISTO" Then

                    'Verifica se o usuário tem direito de alterar algum registro
                    If VerificaDireito(Formulario.FinanceiroDespesaPagamento, gcInsert) = True Then

                        'Abre Formulário de Cadastro
                        Dim oForm As New frmCadBasico
                        oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location: oForm.Tamanho = True

                        If ((goDatabase.sInitialCatalog = "INTERACTI_PERFORMA_PRD") Or (goDatabase.sInitialCatalog = "INTERACTI_SOBERANO_PRD")) Then
                            If grdListagem.CurrentRow.Parent.Cells("codigo_forma_pagamento").Value = 2 Then
                                oForm.UsrControl = "usrFinDespesaPagamentoCheque"
                            Else
                                oForm.UsrControl = "usrFinDespesaPagamento"
                            End If
                        Else
                            oForm.UsrControl = "usrFinDespesaPagamento"
                        End If

                        oForm.Titulo = "Financeiro - Despesa - Baixar Duplicatas"

                        'Variaveis Locais
                        Dim oDataSet As New DataSet
                        Dim oDataTable As New DataTable
                        Dim oDCNumeroDocumento As New DataColumn("numero_documento")
                        Dim oDCDataEmissao As New DataColumn("data_emissao")
                        Dim oDCParceiroNegocio As New DataColumn("parceiro_negocio")
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
                        'Seta DataType
                        oDCDataVencimento.DataType = Now.Date.GetType
                        oDCDataEmissao.DataType = Now.Date.GetType
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
                        oDataRow("descritivo") = grdListagem.CurrentRow.Parent.Cells("descritivo").Value
                        oDataRow("data_vencimento") = grdListagem.CurrentRow.Cells("data_vencimento").Value
                        oDataRow("valor_total") = grdListagem.CurrentRow.Cells("valor_parcela").Value
                        oDataRow("valor_pago") = grdListagem.CurrentRow.Cells("valor_pago").Value
                        oDataRow("juros") = grdListagem.CurrentRow.Cells("juros").Value
                        oDataRow("desconto") = grdListagem.CurrentRow.Cells("desconto").Value
                        oDataRow("valor_devido") = grdListagem.CurrentRow.Cells("valor_corrigido").Value
                        oDataRow("codigo_titulo_capa") = grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value
                        oDataRow("numero_parcela") = grdListagem.CurrentRow.Cells("numero_parcela").Value
                        oDataRow("parceiro_negocio") = grdListagem.CurrentRow.Parent.Cells("parceiro_negocio").Value
                        oDataTable.Rows.Add(oDataRow)

                        'Seta Parâmetros
                        Dim oFormularioCadastroBasico(0) As FormularioCadastroBasico
                        oFormularioCadastroBasico(0).oValor = oDataSet : oFormularioCadastroBasico(0).sControle = "grdParcela"

                        If Not grdListagem.CurrentRow.Parent.Cells("codigo_forma_pagamento").Value Is Nothing Then
                            If Not IsDBNull(grdListagem.CurrentRow.Parent.Cells("codigo_forma_pagamento").Value) Then
                                ReDim Preserve oFormularioCadastroBasico(1)
                                oFormularioCadastroBasico(1).oValor = grdListagem.CurrentRow.Parent.Cells("codigo_forma_pagamento").Value
                                oFormularioCadastroBasico(1).sControle = "cboTipoDocumentoPagamento"
                            End If

                        End If

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
                'Informa o Usuário que esta parcela já se encontra Quitada
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

                'Verifica se o usuário tem direito de alterar algum registro
                If VerificaDireito(Formulario.FinanceiroDespesaPagamento, gcAdministrator) = True Then

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

            Else
                'Informa o Usuário que o Título não foi quitado
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GerarDuplicata()

        Try

            'Verifica Número de Parcela
            txtNumeroParcela.Value = IIf(txtNumeroParcela.Value = 0, 1, txtNumeroParcela.Value)

            If cboCondicaoPagamento.SelectedIndex = -1 Then

                'Gera Duplicata
                oClsFinDespesaLancamento.GerarParcela(grdDuplicata, _
                                                      dtpDataEmissao.Value, _
                                                      txtValorTotal.Value, _
                                                      txtNumeroParcela.Value, _
                                                      txtIntervaloParcela.Value)

            Else

                oClsFinDespesaLancamento.GerarDuplicata(grdDuplicata, _
                                                        cboCondicaoPagamento.SelectedValue, _
                                                        txtValorTotal.Value, _
                                                        dtpDataEmissao.Value)

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
            If VerificaDireito(Formulario.FinanceiroDespesaLancamento, gcUpdate) = False Then
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
                oClsFinDespesaLancamento.InsertClassificacaoGrid(grdClassificacao, _
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
            If VerificaDireito(Formulario.FinanceiroDespesaLancamento, gcUpdate) = True Then

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
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

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
            If (txtValorTotal.Value < FormatNumber((dValorTotal - dValor + txtValorClassificacao.Value), 2)) Then
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

#Region "::: NOTA FISCAL ENTRADA :::"

    Private Sub InserirNotaFiscalEntrada()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoNotaFiscalEntrada() = True Then

                'Váriaveis - Update
                Dim lCodigoAntigo As Long = -1
                Dim sTipo As String = ""

                'Carrega Váriaveis
                If IsNumeric(btnInserirNotaFiscalEntrada.Tag) Then
                    If IsDBNull(grdNotaFiscalEntrada.CurrentRow.Cells("codigo_entrada_capa").Value) Then
                        lCodigoAntigo = grdNotaFiscalEntrada.CurrentRow.Cells("codigo_emissao_capa").Value
                        sTipo = "P"
                    Else
                        lCodigoAntigo = grdNotaFiscalEntrada.CurrentRow.Cells("codigo_entrada_capa").Value
                        sTipo = "T"
                    End If
                End If

                'Insere Registro na Grid
                oClsFinDespesaLancamento.InsertNotaFiscalEntradaoGrid(grdNotaFiscalEntrada, _
                                                                      cboNotaFiscalEntrada.Text, _
                                                                      txtSerieNotaFiscalEntrada.Text, _
                                                                      txtDataEmissaoNotaFiscalEntrada.Text, _
                                                                      txtFornecedorNotaFiscalEntrada.Text, _
                                                                      txtValorNotaFiscalEntrada.Value, _
                                                                      IIf(cboNotaFiscalEntrada.SelectedValue.ToString.Substring(0, 1) = "P", cboNotaFiscalEntrada.SelectedValue.ToString.Substring(1), -1), _
                                                                      IIf(cboNotaFiscalEntrada.SelectedValue.ToString.Substring(0, 1) = "T", cboNotaFiscalEntrada.SelectedValue.ToString.Substring(1), -1), _
                                                                      lCodigoAntigo, _
                                                                      sTipo)

                'Limpa Formulário
                Call NovoNotaFiscalEntrada()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarNotaFiscalEntrada()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FinanceiroDespesaLancamento, gcUpdate) = True Then

                'Carrega Controles
                cboNotaFiscalEntrada.SelectedValue = IIf(IsDBNull(grdNotaFiscalEntrada.CurrentRow.Cells("codigo_entrada_capa").Value), "P" & grdNotaFiscalEntrada.CurrentRow.Cells("codigo_emissao_capa").Value, "T" & grdNotaFiscalEntrada.CurrentRow.Cells("codigo_entrada_capa").Value)               
                txtValorNotaFiscalEntrada.Value = grdNotaFiscalEntrada.CurrentRow.Cells("valor").Value
                btnInserirNotaFiscalEntrada.Tag = grdNotaFiscalEntrada.CurrentRow.RowIndex

                'Seta Focu
                cboNotaFiscalEntrada.Focus()

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

    Private Sub DeleteNotaFiscalEntrada()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdNotaFiscalEntrada) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    For Each oRow As GridEXRow In gSelecaoRow
                        oRow.Delete()
                    Next

                    'Limpa Formulário
                    Call NovoNotaFiscalEntrada()

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

    Private Sub NovoNotaFiscalEntrada()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboNotaFiscalEntrada.Text = ""
            txtSerieNotaFiscalEntrada.Text = ""
            txtDataEmissaoNotaFiscalEntrada.Text = ""
            txtFornecedorNotaFiscalEntrada.Text = ""
            txtValorNotaFiscalEntrada.Value = 0

            'Seta Focu
            cboNotaFiscalEntrada.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoNotaFiscalEntrada() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoNotaFiscalEntrada = False


            'Verifica se foi Selecionado o Campo - Nota Fiscal
            If ValidaCampo(cboNotaFiscalEntrada, lblNotaFiscalEntrada) = False Then
                Exit Function
            End If

            'Verifica se já existe o Cliente Inserido
            If IsNumeric(btnInserirNotaFiscalEntrada.Tag) = False Then
                If VerificaExisteValorGrid(grdNotaFiscalEntrada, IIf(cboNotaFiscalEntrada.SelectedValue.ToString.Substring(0, 1) = "P", "codigo_emissao_capa", "codigo_entrada_capa"), cboNotaFiscalEntrada.SelectedValue.ToString.Substring(1), -1) = True Then
                    frmMain.errInfo.SetError(lblNotaFiscalEntrada, "Este Nota Fiscal: " & cboNotaFiscalEntrada.Text & " já se encontra cadastrada.")
                    cboNotaFiscalEntrada.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdNotaFiscalEntrada, IIf(cboNotaFiscalEntrada.SelectedValue.ToString.Substring(0, 1) = "P", "codigo_emissao_capa", "codigo_entrada_capa"), cboNotaFiscalEntrada.SelectedValue.ToString.Substring(1), grdNotaFiscalEntrada.CurrentRow.RowIndex) = True Then
                    frmMain.errInfo.SetError(lblNotaFiscalEntrada, "Este Nota Fiscal: " & cboNotaFiscalEntrada.Text & " já se encontra cadastrada.")
                    cboNotaFiscalEntrada.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Valor
            If ValidaCampo(txtValorNotaFiscalEntrada, lblValorNotaFiscalEntrada, True) = False Then
                Exit Function
            End If

            'Valida se a Soma do Valor é maior que o Valor Total
            Dim dValor, dValorTotal As Double

            If IsNumeric(btnInserirNotaFiscalEntrada.Tag) Then
                dValor = grdNotaFiscalEntrada.CurrentRow.Cells("valor").Value
            End If
            If grdNotaFiscalEntrada.GetDataRows.Count > 0 Then
                dValorTotal = grdNotaFiscalEntrada.GetTotalRow.Cells("valor").Value
            End If
            If (txtValorTotal.Value < FormatNumber((dValorTotal - dValor + txtValorClassificacao.Value), 2)) Then
                frmMain.errInfo.SetError(lblValorNotaFiscalEntrada, "A Soma dos Valores não pode ser maior que o Valor Total.")
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoNotaFiscalEntrada = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class

