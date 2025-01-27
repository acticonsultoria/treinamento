Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Reflection
Imports System.Reflection.Assembly
Imports INTERACTI.modDeclaration

Public Class usrCmpCotacao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCmpCotacao As New clsUsrCmpCotacao
    Private lCodigoRequisicao As Long
    Private iCodigoRequisicaoItem As Integer
    Private lCodigoCotacao As Long = -1

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrCmpCotacao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try
            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGridCotacao() Else Control_Enter(sender)

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCodigoItem" : Call btnProcurarItem_Click(btnProcurarItem, System.EventArgs.Empty)
                        Case "cboCentroGastoItem" : Call btnProcurarCentroGasto_Click(btnProcurarCentroGasto, System.EventArgs.Empty)
                        Case "cboFornecedor" : Call btnProcurarFornecedor_Click(btnProcurarFornecedor, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCodigoItem" : Call cboTipoItem_SelectedIndexChanged(cboTipoItem, System.EventArgs.Empty)
                        Case "cboFornecedor" : Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)
                        Case "cboContaContabilItem" : Call LoadCombo(cboContaContabilItem, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)
                        Case "cboCentroGastoItem" : Call LoadCombo(cboCentroGastoItem, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboUnidadeMedidaItem" : Call LoadCombo(cboUnidadeMedidaItem, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa)
                        Case "cboCondicaoPagamentoOrcamento" : Call LoadCombo(cboCondicaoPagamentoOrcamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)
                        Case "cboMoedaOrcamento" : Call LoadCombo(cboMoedaOrcamento, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)
                        Case "cboTransportadoraOrcamento" : Call LoadCombo(cboTransportadoraOrcamento, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa)
                        Case "cboModalidadeTransporteOrcamento" : Call LoadCombo(cboModalidadeTransporteOrcamento, "sp_select_combo_cadastro_basico_modalidade_transporte " & goUsuario.iEmpresa)
                        Case "cboIncotermsOrcamento" : Call LoadCombo(cboIncotermsOrcamento, "sp_select_combo_cadastro_basico_incoterms " & goUsuario.iEmpresa)
                        Case "cboAgenteLogisticoOrcamento" : Call LoadCombo(cboAgenteLogisticoOrcamento, "sp_select_combo_cadastro_basico_agente_logistico " & goUsuario.iEmpresa)
                        Case "cboInstrucaoEmbarqueOrcamento" : Call LoadCombo(cboInstrucaoEmbarqueOrcamento, "sp_select_combo_cadastro_basico_instrucao_embarque " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboFornecedor" : Call btnCadastrarFornecedor_Click(btnCadastrarFornecedor, System.EventArgs.Empty)
                        Case "cboContaContabilItem" : Call btnCadastrarContaContabilItem_Click(btnCadastrarContaContabilItem, System.EventArgs.Empty)
                        Case "cboCentroGastoItem" : Call btnCadastrarCentroGastoItem_Click(btnCadastrarCentroGastoItem, System.EventArgs.Empty)
                        Case "cboUnidadeMedidaItem" : Call btnCadastrarUnidadeMedidaItem_Click(btnCadastrarUnidadeMedidaItem, System.EventArgs.Empty)
                        Case "cboCondicaoPagamentoOrcamento" : Call btnCadastrarCondicaoPagamentoOrcamento_Click(btnCadastrarCondicaoPagamentoOrcamento, System.EventArgs.Empty)
                        Case "cboMoedaOrcamento" : Call btnCadastrarMoedaOrcamento_Click(btnCadastrarMoedaOrcamento, System.EventArgs.Empty)
                        Case "cboTransportadoraOrcamento" : Call btnCadastrarTransportadoraOrcamento_Click(btnCadastrarTransportadoraOrcamento, System.EventArgs.Empty)
                        Case "cboModalidadeTransporteOrcamento" : Call btnCadastrarModalidadeTransporteOrcamento_Click(btnCadastrarModalidadeTransporteOrcamento, System.EventArgs.Empty)
                        Case "cboIncotermsOrcamento" : Call btnCadastrarIncotermsOrcamento_Click(btnCadastrarIncotermsOrcamento, System.EventArgs.Empty)
                        Case "cboAgenteLogisticoOrcamento" : Call btnCadastrarAgenteLogisticoOrcamento_Click(btnCadastrarAgenteLogisticoOrcamento, System.EventArgs.Empty)
                        Case "cboInstrucaoEmbarqueOrcamento" : Call btnCadastrarInstrucaoEmbarqueOrcamento_Click(btnCadastrarInstrucaoEmbarqueOrcamento, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCmpCotacaoMaterial_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub tabMain_ChangingSelectedTab(ByVal sender As Object, ByVal e As Janus.Windows.UI.Tab.TabCancelEventArgs) Handles tabMain.ChangingSelectedTab

        Try

            'Configura Formulário
            Call AlterarTabMain(e.Page.Name)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: COTAÇÃO :::"

    Private Sub btnEditarGrid_Click(sender As Object, e As EventArgs)

        Try

            'Váriaveis Locais
            Dim sCampo(1) As String

            'Carrega Valores
            sCampo(0) = "codigo_centro_custo"
            sCampo(1) = "codigo_conta_contabil"

            'Habilita Grid
            Call EditarGrid(grdListagem,
                            sCampo,
                            IIf(grdListagem.Tag.ToString = "E", False, True))

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Grid - Cotação
            Call LoadGridCotacao()

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

    Private Sub btnGerarCotacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarCotacao.Click

        Try

            'Gera Cotação
            Call GerarCotacao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColunaCotacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColunaCotacao.SelectedIndexChanged

        Try

            'Congelar Coluna
            If cboCongelarColunaCotacao.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 7
            Else
                grdListagem.FrozenColumns = cboCongelarColunaCotacao.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellUpdated

        Try

            'Query
            Dim sQuery As String = "WHERE codigo_requisicao = " & grdListagem.GetValue("codigo_requisicao") & " AND codigo = " & grdListagem.GetValue("codigo_requisicao_item") & " AND codigo_empresa = " & goUsuario.iEmpresa & ""

            Select Case e.Column.Key

                Case "codigo_centro_custo" : Call ExecuteQuery("sp_update_interacti_table_field 'tb_cmp_requisicao_item', '" & e.Column.Key & "', " & IIf(IsDBNull(grdListagem.GetValue(e.Column.Key)) = False, grdListagem.GetValue(e.Column.Key).ToString.Replace(".", "").Replace(",", "."), "'NULL'") & ",'" & sQuery & "'")
                Case "codigo_conta_contabil" : Call ExecuteQuery("sp_update_interacti_table_field 'tb_cmp_requisicao_item', '" & e.Column.Key & "', " & IIf(IsDBNull(grdListagem.GetValue(e.Column.Key)) = False, "'''" & grdListagem.GetValue(e.Column.Key).ToString.Replace("'", "''") & "'''", "'NULL'") & ",'" & sQuery & "'")
                Case "referencia" : UpdateReferencia()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se o Tipo da Linha é Record
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdListagem.CurrentColumn.Key



                Case "voltar_status" : Call RetornarStatus(grdListagem.CurrentRow)
                Case "inserir_cotacao" : Call InserirCotacao(grdListagem.CurrentRow)
                Case "cancelar" : Call CancelarItemCotacao(grdListagem.CurrentRow)
                Case "historico" : Call HistoricoCotacaoItem(grdListagem.CurrentRow)
                Case "visualizar" : Call VisualizarDocumento(grdListagem.CurrentRow.Cells("arquivo_interacti").Value)
                Case "numero_requisicao" : VisualizarRequisicaoCompra(grdListagem.GetValue("codigo_requisicao"))
                Case "arquivo" : Call ListaArquivo("tb_cmp_requisicao", grdListagem.CurrentRow.Cells("codigo_requisicao").Value)
                Case "aprovar_cotacao"

                    If grdListagem.GetValue("status") = 2 Then
                        Call AprovarCotacao(grdListagem.CurrentRow.Cells("codigo_cotacao").Value)
                    Else
                        frmMain.Informacao("Não é possível aprovar a cotação pois ela precisa constar no status de [COTANDO]!", Color.Red)
                    End If

                Case "editar"

                    If Not grdListagem.GetValue("codigo_cotacao") Is DBNull.Value Then
                        EditarCotacao(grdListagem.GetValue("codigo_cotacao"))
                    Else
                        frmMain.Informacao("Não é possível editar. Não existe um número de cotação para esse registro.", Color.Red)
                    End If

                Case "visualizar_ordem_producao" : Call EditarOrdemProducao(sender)


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem,
                                     Formulario.ComprasCotacao)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColunaCotacao, grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name,
                                     Formulario.ComprasCotacao,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name,
                                          Formulario.ComprasCotacao,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: REQUISIÇÃO :::"

    Private Sub btnQuantidadeAberto_Click(sender As Object, e As EventArgs) Handles btnQuantidadeAberto.Click

        Try

            'Verifica se foi Selecionado o Tipo do Item
            If cboCodigoItem.SelectedIndex = -1 Then Exit Sub

            'Váriavel - Formulário de Procurar Item
            Dim oForm As New frmCmpQuantidadeAberto

            'Seta Parametros
            oForm.CodigoItem = cboCodigoItem.SelectedValue

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItem.Click

        Try

            'Verifica se foi Selecionado o Tipo do Item
            If cboTipoItem.SelectedIndex = -1 Then Exit Sub

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = cboTipoItem.SelectedValue
            sItemCompraFind = "S"
            oComboBoxFind = cboCodigoItem


            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCodigoItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroGasto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboCodigoItem.SelectedIndex = -1, -1, cboCodigoItem.SelectedValue)
            oComboBoxFind = cboCentroGastoItem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGastoItem.Focus()

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

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboCodigoItem.SelectedIndex = -1, -1, cboCodigoItem.SelectedValue)
            'Seta Parametros
            oComboBoxFind = cboContaContabilItem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabilItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabilItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabilItem.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")

            'Carrega Combo
            If cboCodigoItem.SelectedIndex > -1 Then
                Call LoadCombo(cboContaContabilItem, "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", " & cboCodigoItem.SelectedValue, True)
            End If

            'Seta Focu
            cboContaContabilItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroGastoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGastoItem.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo
            If cboCodigoItem.SelectedIndex > -1 Then
                Call LoadCombo(cboCentroGastoItem, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ", " & cboCodigoItem.SelectedValue, True)
            End If

            'Seta Focu
            cboCentroGastoItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedidaItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedidaItem.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo            
            Call LoadCombo(cboUnidadeMedidaItem, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboUnidadeMedidaItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvarRequisicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarRequisicao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoRequisicao() = True Then

                'Salva Dados da Requisição
                Call SalvarRequisicao()
                'Informa o Usuário sobre o sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltarRequisicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltarRequisicao.Click

        Try

            'Adiciona Aba de Cotação
            tabMain.TabPages.Add(pagCotacao)

            'Carrega Grid
            Call LoadGridCotacao()

            'Verifica se o Usuário tem Direito de Ver o Perfil
            If VerificaDireito(Formulario.ComprasCotacaoDefinirFornecedor, gcSelect) = True Then
                tabMain.TabPages.Add(pagFornecedor)
            End If
            'Verifica se o Usuário tem Direito de Ver o Perfil
            If VerificaDireito(Formulario.ComprasCotacaoOrcamento, gcSelect) = True Then
                tabMain.TabPages.Add(pagOrcamento)
            End If
            'Verifica se o Usuário tem Direito de Ver o Perfil
            If VerificaDireito(Formulario.ComprasCotacaoAprovarOrcamento, gcSelect) = True Then
                tabMain.TabPages.Add(pagAprovacao)
            End If

            'Remove Aba de Requisição
            tabMain.TabPages.Remove(pagRequisicao)

            'Seta Focu
            tabMain.SelectedTab = pagCotacao
            txtNumeroCotacaoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoItem.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboTipoItem.SelectedIndex = -1 Then
                'Limpa Controle
                cboCodigoItem.SelectedIndex = -1 : cboCodigoItem.DataSource = Nothing : cboCodigoItem.Text = ""
                btnCadastrarItem.Enabled = False
            Else
                'Carrega Combo            
                Call LoadCombo(cboCodigoItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1, " & cboTipoItem.SelectedValue)

                'Habilita o Campo Marca se Necessário
                If cboTipoItem.SelectedValue = CInt(TipoItem.servico) Then
                    txtMarcaItem.Text = ""
                    txtMarcaItem.Enabled = False
                Else
                    txtMarcaItem.Enabled = True
                End If

                'Verifica Direito
                btnCadastrarItem.Enabled = VerificaDireito(IIf(cboTipoItem.SelectedValue = CInt(TipoItem.produto), Formulario.CadastroBasicoProduto, Formulario.CadastroBasicoServico), gcInsert)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCodigoItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoItem.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboCodigoItem.SelectedIndex = -1 Then

                'Limpa Controles
                txtDescricaoItem.Text = ""
                txtQuantidadeMinima.Value = 0
                txtMultiploCompra.Value = 0
                cboUnidadeMedidaItem.SelectedIndex = -1
                dtpDataNecessidadeItem.Value = Now.Date : dtpDataNecessidadeItem.Checked = False

            Else

                Dim oClsCmpRequisicao As New clsUsrCmpRequisicao

                'Carrega Dados do Produto
                Call oClsCmpRequisicao.LoadDadosItem(grdListagem.CurrentRow.Cells("codigo_requisicao").Value,
                                                     grdListagem.CurrentRow.Cells("codigo_requisicao_item").Value,
                                                     cboCodigoItem,
                                                     txtDescricaoItem,
                                                     cboUnidadeMedidaItem,
                                                     txtMarcaItem,
                                                     txtQuantidadeMinima,
                                                     txtMultiploCompra,
                                                     dtpDataNecessidadeItem,
                                                     txtQuantidadeAberto)

                'Carrega Combo
                Call LoadCombo(cboCentroGastoItem, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ", " & cboCodigoItem.SelectedValue, True)
                Call LoadCombo(cboContaContabilItem, "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", " & cboCodigoItem.SelectedValue, True)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FORNECEDOR :::"

    Private Sub btnExportarSolicitacaoOrcamento_Click(sender As Object, e As EventArgs) Handles btnExportarSolicitacaoOrcamento.Click
        Try
            ExportarSolicitacaoOrcamento()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnSalvarCondicaoCotacao_Click(sender As Object, e As EventArgs) Handles btnSalvarCondicaoCotacao.Click
        Try
            SalvarCondicaoCotacao()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub CondicaoPagamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCondicaoPagamentoDefinirFornecedor.LostFocus,
                                                                                                 cboModalidadeFreteDefinirFornecedor.LostFocus
        Try
            SalvarCondicaoCotacao()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
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

    Private Sub btnCadastrarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarFornecedor.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)

            'Seta Focu
            cboFornecedor.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirFornecedor.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoFornecedor() = True Then

                'Salva dados do Fornecedor
                Call SalvarFornecedor()
                'Prepara Formulário para Inserção de mais um Registro
                Call NovoFornecedor()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirFornecedor.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Registro - Cotação Fornecedor
            Call DeleteFornecedor()
            'Limpa Formulário
            Call NovoFornecedor()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboNumeroCotacaoFornecedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNumeroCotacaoFornecedor.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboNumeroCotacaoFornecedor.SelectedIndex = -1 Then

                'Limpa Controles
                txtDataCotacaoFornecedor.Text = ""
                txtDescritivoFornecedor.Text = ""
                cboFornecedor.SelectedIndex = -1
                dtpDataPrazoRespostaFornecedor.Value = Now.Date : dtpDataPrazoRespostaFornecedor.Checked = False
                txtObservacaoFornecedor.Text = ""
                btnInserirFornecedor.Tag = ""
                cboModalidadeFreteDefinirFornecedor.SelectedIndex = -1
                cboCondicaoPagamentoDefinirFornecedor.SelectedIndex = -1

                grdFornecedor.DataSource = Nothing

            Else

                lCodigoCotacao = cboNumeroCotacaoFornecedor.SelectedValue

                'Carrega Dados da Cotação
                Call oClsCmpCotacao.LoadDadosCotacaoFornecedor(cboNumeroCotacaoFornecedor.SelectedValue,
                                                     txtDataCotacaoFornecedor,
                                                     txtDescritivoFornecedor,
                                                     cboCondicaoPagamentoDefinirFornecedor,
                                                     cboModalidadeFreteDefinirFornecedor)

                'Carrega Grid - Cotação Fornecedor
                Call oClsCmpCotacao.LoadGridCotacaoFornecedor(grdFornecedor,
                                                              cboNumeroCotacaoFornecedor.SelectedValue)

                'Carrega Grid - Produtos da Cotação
                Call oClsCmpCotacao.LoadGridCotacaoProdutos(grdCotacaoProdutos,
                                                            cboNumeroCotacaoFornecedor.SelectedValue)


            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFornecedor_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdFornecedor.RowDoubleClick

        Try

            'Verifica se a Célula é Válida
            If IsNothing(grdFornecedor.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdFornecedor.CurrentColumn.Key

                Case "editar" : Call EditarFornecedor(grdFornecedor.CurrentRow)
                Case "email" : Call EmailFornecedor(grdFornecedor.CurrentRow)
                Case "imprimir" : Call ImprimirFornecedor(grdFornecedor.CurrentRow)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFornecedor_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdFornecedor.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFornecedor,
                                     Formulario.ComprasCotacaoDefinirFornecedor)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFornecedor_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdFornecedor.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFornecedor.Name,
                                     Formulario.ComprasCotacaoDefinirFornecedor,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Alterecao_TextChanged(sender As Object, e As EventArgs) Handles cboCondicaoPagamentoOrcamento.LostFocus,
                                                                                txtValorHonorario.LostFocus,
                                                                                txtValorFreteOrcamento.LostFocus,
                                                                                txtValorEstimadoCustoImportacao.LostFocus,
                                                                                txtFatorCambial.LostFocus,
                                                                                dtpDataValidadeOrcamento.LostFocus,
                                                                                cboTransportadoraOrcamento.LostFocus,
                                                                                cboMoedaOrcamento.LostFocus,
                                                                                cboModalidadeTransporteOrcamento.LostFocus,
                                                                                cboModalidadeFreteOrcamento.LostFocus,
                                                                                cboInstrucaoEmbarqueOrcamento.LostFocus,
                                                                                cboIncotermsOrcamento.LostFocus,
                                                                                cboFormaPagamentoOrcamento.LostFocus,
                                                                                cboAgenteLogisticoOrcamento.LostFocus

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Orçamento
            If ValidacaoOrcamentoAlterarCampos() = True Then

                'Salva Orçamento
                Call SalvarOrcamento()

            End If


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


#End Region

#Region "::: ORÇAMENTO :::"

#Region " ::: GERAL ::: "

    Private Sub btnCadastrarCondicaoPagamentoOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCondicaoPagamentoOrcamento.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCondicaoPagamento")

            'Carrega Combo            
            Call LoadCombo(cboCondicaoPagamentoOrcamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)

            'Seta Focu
            cboCondicaoPagamentoOrcamento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarMoedaOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarMoedaOrcamento.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadMoeda")

            'Carrega Combo            
            Call LoadCombo(cboMoedaOrcamento, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)

            'Seta Focu
            cboMoedaOrcamento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTransportadoraOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTransportadoraOrcamento.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTransportadora")

            'Carrega Combo            
            Call LoadCombo(cboTransportadoraOrcamento, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa)

            'Seta Focu
            cboTransportadoraOrcamento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarModalidadeTransporteOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarModalidadeTransporteOrcamento.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadModalidadeTransporte")

            'Carrega Combo            
            Call LoadCombo(cboModalidadeTransporteOrcamento, "sp_select_combo_cadastro_basico_modalidade_transporte " & goUsuario.iEmpresa)

            'Seta Focu
            cboModalidadeTransporteOrcamento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarIncotermsOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarIncotermsOrcamento.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadIncoterms")

            'Carrega Combo            
            Call LoadCombo(cboIncotermsOrcamento, "sp_select_combo_cadastro_basico_incoterms " & goUsuario.iEmpresa)

            'Seta Focu
            cboIncotermsOrcamento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarInstrucaoEmbarqueOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarInstrucaoEmbarqueOrcamento.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadInstrucaoEmbarque")

            'Carrega Combo            
            Call LoadCombo(cboInstrucaoEmbarqueOrcamento, "sp_select_combo_cadastro_basico_instrucao_embarque " & goUsuario.iEmpresa)

            'Seta Focu
            cboInstrucaoEmbarqueOrcamento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarAgenteLogisticoOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarAgenteLogisticoOrcamento.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            Call LoadCombo(cboAgenteLogisticoOrcamento, "sp_select_combo_cadastro_basico_agente_logistico " & goUsuario.iEmpresa)

            'Seta Focu
            cboAgenteLogisticoOrcamento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvarOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarOrcamento.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Orçamento
            If ValidacaoOrcamento() = True Then

                'Salva Orçamento
                Call SalvarOrcamento()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColunaOrcamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColunaOrcamento.SelectedIndexChanged

        Try

            Select Case tabOrcamento.SelectedTab.Key

                Case "pagProduto"
                    If cboCongelarColunaOrcamento.SelectedIndex = -1 Then
                        grdOrcamentoProduto.FrozenColumns = 2
                    Else
                        grdOrcamentoProduto.FrozenColumns = cboCongelarColunaOrcamento.SelectedValue
                    End If
                Case "pagServico"
                    If cboCongelarColunaOrcamento.SelectedIndex = -1 Then
                        grdOrcamentoServico.FrozenColumns = 2
                    Else
                        grdOrcamentoServico.FrozenColumns = cboCongelarColunaOrcamento.SelectedValue
                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboNumeroCotacaoOrcamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNumeroCotacaoOrcamento.SelectedIndexChanged

        Try

            'Limpa Grid
            grdArquivo.DataSource = Nothing
            grdOrcamentoServico.DataSource = Nothing
            grdOrcamentoProduto.DataSource = Nothing
            'Torna Aba Visível
            If pagProduto.TabVisible = False Then pagProduto.TabVisible = True
            If pagServico.TabVisible = False Then pagServico.TabVisible = True

            'Verifica se foi selecionado Algum Registro
            If cboNumeroCotacaoOrcamento.SelectedIndex = -1 Then

                'Limpa Controles
                txtDataCotacaoOrcamento.Text = ""
                txtDescritivoOrcamento.Text = ""
                cboFornecedorOrcamento.DataSource = Nothing
                cboFornecedorOrcamento.Text = ""
                cboCondicaoPagamentoOrcamento.SelectedIndex = -1
                cboFormaPagamentoOrcamento.SelectedIndex = -1
                cboMoedaOrcamento.SelectedIndex = -1
                cboModalidadeFreteOrcamento.SelectedIndex = -1
                cboTransportadoraOrcamento.SelectedIndex = -1
                txtValorFreteOrcamento.Value = 0
                cboModalidadeTransporteOrcamento.SelectedIndex = -1
                cboIncotermsOrcamento.SelectedIndex = -1
                cboAgenteLogisticoOrcamento.SelectedIndex = -1
                txtValorHonorario.Value = 0
                txtValorEstimadoCustoImportacao.Value = 0
                cboInstrucaoEmbarqueOrcamento.SelectedIndex = -1
                dtpDataValidadeOrcamento.Value = Now.Date : dtpDataValidadeOrcamento.Checked = False
                'Habilita Controles
                cboModalidadeTransporteOrcamento.Enabled = False
                cboIncotermsOrcamento.Enabled = False
                cboAgenteLogisticoOrcamento.Enabled = False
                txtValorHonorario.Enabled = False
                txtValorEstimadoCustoImportacao.Enabled = False
                cboInstrucaoEmbarqueOrcamento.Enabled = False
                'Limpa Controles - Arquivo
                txtArquivo.Text = ""
                txtTituloArquivo.Text = ""
                btnInserirArquivo.Tag = ""

            Else

                lCodigoCotacao = cboNumeroCotacaoOrcamento.SelectedValue

                'Carrega Dados da Cotação
                Call oClsCmpCotacao.LoadDadosCotacao(cboNumeroCotacaoOrcamento.SelectedValue,
                                                     txtDataCotacaoOrcamento,
                                                     txtDescritivoOrcamento)

                'Carrega Combo - Fornecedor
                LoadCombo(cboFornecedorOrcamento, "sp_select_combo_compras_cotacao_fornecedor " & cboNumeroCotacaoOrcamento.SelectedValue & ", " & goUsuario.iEmpresa, True)


            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboFornecedorOrcamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFornecedorOrcamento.SelectedIndexChanged

        Try

            cboModalidadeTransporteOrcamento.Enabled = False
            cboIncotermsOrcamento.Enabled = False
            cboAgenteLogisticoOrcamento.Enabled = False
            txtValorHonorario.Enabled = False
            txtValorEstimadoCustoImportacao.Enabled = False
            cboInstrucaoEmbarqueOrcamento.Enabled = False

            'Verifica se foi selecionado Algum Registro
            If cboFornecedorOrcamento.SelectedIndex = -1 Then

                'Limpa Controles
                LimparCamposGroupBox(grpDadosOrcamento)

                'Limpa Controles - Arquivo
                LimparCamposGroupBox(grpArquivo)
                btnInserirArquivo.Tag = ""
                'Limpa Controles - Observação
                txtObservacaoOrcamento.Text = ""
                'Limpa Grid
                grdOrcamentoServico.DataSource = Nothing
                grdOrcamentoProduto.DataSource = Nothing
                grdArquivo.DataSource = Nothing
                'Torna Aba Visível
                If pagProduto.TabVisible = False Then pagProduto.TabVisible = True
                If pagServico.TabVisible = False Then pagServico.TabVisible = True

            Else

                'Verifica a UF do Fornecedor
                If LoadUFParceiroNegocioCotacao(cboNumeroCotacaoOrcamento.SelectedValue,
                                                cboFornecedorOrcamento.SelectedValue) = gcUFExterior Then

                    'Habilita Controles
                    cboModalidadeTransporteOrcamento.Enabled = True
                    cboIncotermsOrcamento.Enabled = True
                    cboAgenteLogisticoOrcamento.Enabled = True
                    txtValorHonorario.Enabled = True
                    txtValorEstimadoCustoImportacao.Enabled = True
                    cboInstrucaoEmbarqueOrcamento.Enabled = True

                Else

                    'Desabilita Controles
                    cboModalidadeTransporteOrcamento.Enabled = False : cboModalidadeTransporteOrcamento.Text = ""
                    cboIncotermsOrcamento.Enabled = False : cboIncotermsOrcamento.Text = ""
                    cboAgenteLogisticoOrcamento.Enabled = False : cboAgenteLogisticoOrcamento.Text = ""
                    txtValorHonorario.Enabled = False : txtValorHonorario.Value = 0
                    txtValorEstimadoCustoImportacao.Enabled = False : txtValorEstimadoCustoImportacao.Value = 0
                    cboInstrucaoEmbarqueOrcamento.Enabled = False : cboInstrucaoEmbarqueOrcamento.Text = ""

                End If

                'Carrega Dados do Orçamento
                Call oClsCmpCotacao.LoadDadosCotacaoFornecedorOrcamento(cboNumeroCotacaoOrcamento.SelectedValue,
                                                                        cboFornecedorOrcamento.SelectedValue,
                                                                        cboCondicaoPagamentoOrcamento,
                                                                        cboFormaPagamentoOrcamento,
                                                                        cboMoedaOrcamento,
                                                                        txtFatorCambial,
                                                                        cboModalidadeFreteOrcamento,
                                                                        cboTransportadoraOrcamento,
                                                                        txtValorFreteOrcamento,
                                                                        cboModalidadeTransporteOrcamento,
                                                                        cboIncotermsOrcamento,
                                                                        cboAgenteLogisticoOrcamento,
                                                                        txtValorHonorario,
                                                                        txtValorEstimadoCustoImportacao,
                                                                        cboInstrucaoEmbarqueOrcamento,
                                                                        dtpDataValidadeOrcamento,
                                                                        txtObservacaoOrcamento)

                'Carrega Lista de Produtos
                Call oClsCmpCotacao.LoadGridCotacaoFornecedorOrcamentoItem(grdOrcamentoProduto,
                                                                           TipoItem.produto,
                                                                           cboNumeroCotacaoOrcamento.SelectedValue,
                                                                           cboFornecedorOrcamento.SelectedValue)

                'Carrega Lista de Serviços
                Call oClsCmpCotacao.LoadGridCotacaoFornecedorOrcamentoItem(grdOrcamentoServico,
                                                                           TipoItem.servico,
                                                                           cboNumeroCotacaoOrcamento.SelectedValue,
                                                                           cboFornecedorOrcamento.SelectedValue)

                'Carrega Lista de Arquivos
                Call LoadGridArquivo()

                'Verifica necessidade da Aba de Produto
                If grdOrcamentoProduto.GetDataRows.Count = 0 Then
                    If pagProduto.TabVisible Then
                        pagProduto.TabVisible = False
                    End If
                Else
                    If pagProduto.TabVisible = False Then
                        pagProduto.TabVisible = True
                    End If
                End If

                'Verifica necessidade da Aba de Servico
                If grdOrcamentoServico.GetDataRows.Count = 0 Then
                    If pagServico.TabVisible Then
                        pagServico.TabVisible = False
                    End If
                Else
                    If pagServico.TabVisible = False Then
                        pagServico.TabVisible = True
                    End If
                End If

            End If

            If pagProduto.TabVisible = True Then
                tabOrcamento.SelectedTab = pagProduto
            Else
                tabOrcamento.SelectedTab = pagServico
            End If

            'Carrega Dados de Compra
            If cboModalidadeFreteOrcamento.SelectedIndex = -1 Then
                cboModalidadeFreteOrcamento.SelectedValue = cboModalidadeFreteDefinirFornecedor.SelectedValue
            End If

            If cboCondicaoPagamentoOrcamento.SelectedIndex = -1 Then
                cboCondicaoPagamentoOrcamento.SelectedValue = cboCondicaoPagamentoDefinirFornecedor.SelectedValue
            End If

            cboFormaPagamentoOrcamento.SelectedValue = 10
            cboMoedaOrcamento.SelectedValue = 1

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboMoedaOrcamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoedaOrcamento.SelectedIndexChanged

        Try

            'Limpa Controles
            txtFatorCambial.Value = 1
            txtFatorCambial.ReadOnly = True
            txtFatorCambial.TabStop = False
            txtFatorCambial.BackColor = Color.WhiteSmoke

            'Verifica se foi Selecionado algum Item
            If cboMoedaOrcamento.SelectedIndex <> -1 Then
                If cboMoedaOrcamento.SelectedValue <> CInt(Moeda.Real) Then
                    txtFatorCambial.Value = 0
                    txtFatorCambial.ReadOnly = False
                    txtFatorCambial.TabStop = True
                    txtFatorCambial.BackColor = Color.White
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub tabOrcamento_SelectedTabChanged(sender As Object, e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabOrcamento.SelectedTabChanged

        Try

            Select Case e.Page.Key

                Case "pagProduto" : Call LoadComboColunasGrid(cboCongelarColunaOrcamento, grdOrcamentoProduto)
                Case "pagServico" : Call LoadComboColunasGrid(cboCongelarColunaOrcamento, grdOrcamentoProduto)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


#End Region

#Region " ::: PRODUTO ::: "

    Private Sub grdOrcamentoProduto_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grdOrcamentoProduto.CellValueChanged

        Try

            'Váriaveis Locais
            Dim sQuery As String

            'Seta Váriavel
            sQuery = grdOrcamentoProduto.GetValue("codigo_cotacao") & ", "
            sQuery &= grdOrcamentoProduto.GetValue("codigo_cotacao_item") & ", "
            sQuery &= cboFornecedorOrcamento.SelectedValue & ", "
            sQuery &= goUsuario.iEmpresa

            Select Case e.Column.Key

                Case "marca"
                    Call ExecuteQuery("sp_update_compras_cotacao_fornecedor_item_campo 'marca', '''" & grdOrcamentoProduto.GetValue("marca") & "'''," & sQuery)

                Case "valor_unitario", "pis_cofins_incluso", "ipi_incluso", "icms_incluso", "aliquota_ipi", "aliquota_pis_cofins", "aliquota_icms", "desconto_valor", "desconto_percentual"

                    If IsNumeric(grdOrcamentoProduto.GetValue(e.Column.Key)) = False Then
                        grdOrcamentoProduto.SetValue(e.Column.Key, 0)
                    End If

                    If e.Column.Key = "desconto_valor" Then
                        If grdOrcamentoProduto.GetValue("desconto_valor") > grdOrcamentoProduto.GetValue("valor_unitario") Then
                            grdOrcamentoProduto.SetValue("desconto_valor", 0)
                        End If
                        grdOrcamentoProduto.SetValue("desconto_percentual", grdOrcamentoProduto.GetValue("desconto_valor") / grdOrcamentoProduto.GetValue("valor_unitario") * 100)
                    ElseIf e.Column.Key = "desconto_percentual" Then
                        If grdOrcamentoProduto.GetValue("desconto_percentual") > 100 Then
                            grdOrcamentoProduto.SetValue("desconto_percentual", 0)
                        End If
                        grdOrcamentoProduto.SetValue("desconto_valor", grdOrcamentoProduto.GetValue("valor_unitario") * grdOrcamentoProduto.GetValue("desconto_percentual") / 100)
                    End If

                    'Váriaveis
                    Dim dValorUnitario As Double = grdOrcamentoProduto.GetValue("valor_unitario") - grdOrcamentoProduto.GetValue("desconto_valor")
                    Dim dAliquotaICMS As Double = 0
                    Dim dAliquotaPISCOFINS As Double = 0
                    Dim dAliquotaICMSPISCOFINS As Double = 0
                    dAliquotaICMS = IIf(grdOrcamentoProduto.GetValue("icms_incluso") = False, (grdOrcamentoProduto.GetValue("aliquota_icms") / 100), 0)
                    dAliquotaPISCOFINS = IIf(grdOrcamentoProduto.GetValue("pis_cofins_incluso") = False, (grdOrcamentoProduto.GetValue("aliquota_pis_cofins") / 100), 0)
                    dAliquotaICMSPISCOFINS = Math.Round(1 - (dAliquotaICMS + dAliquotaPISCOFINS), 2)
                    dValorUnitario = IIf(dAliquotaICMSPISCOFINS = 0, dValorUnitario, dValorUnitario / dAliquotaICMSPISCOFINS)
                    dValorUnitario = IIf(grdOrcamentoProduto.GetValue("ipi_incluso") = False, dValorUnitario * ((grdOrcamentoProduto.GetValue("aliquota_ipi") / 100.0) + 1), dValorUnitario)

                    'Seta Valor Total
                    grdOrcamentoProduto.SetValue("valor_total", dValorUnitario * grdOrcamentoProduto.GetValue("quantidade"))

                    'Atualiza Valor na Tabela
                    If e.Column.Key = "desconto_valor" Or e.Column.Key = "desconto_percentual" Then
                        Call ExecuteQuery("sp_update_compras_cotacao_fornecedor_item_campo 'desconto_valor', '" & CDbl(grdOrcamentoProduto.GetValue("desconto_valor")).ToString.Replace(",", ".") & "'," & sQuery)
                    Else
                        Call ExecuteQuery("sp_update_compras_cotacao_fornecedor_item_campo '" & e.Column.Key & "', '" & CDbl(grdOrcamentoProduto.GetValue(e.Column.Key)).ToString.Replace(",", ".") & "'," & sQuery)
                    End If

                    'Atualiza Quantidade
                    Call ExecuteQuery("sp_update_compras_cotacao_fornecedor_item_campo 'quantidade', '" & CDbl(grdOrcamentoProduto.GetValue("quantidade")).ToString.Replace(",", ".") & "'," & sQuery)

                Case "prazo_entrega"

                    If IsDate(grdOrcamentoProduto.GetValue("prazo_entrega")) = False OrElse grdOrcamentoProduto.GetValue("prazo_entrega").ToString.Length < 10 Then Exit Sub

                    'Verifica se a Data é menor que a Data Corrente
                    If grdOrcamentoProduto.GetValue("prazo_entrega") < Now.Date Then
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "A Data Informada não pode ser menor que a Data Corrente.")
                        grdOrcamentoProduto.SetValue("prazo_entrega", DBNull.Value)
                        Exit Sub
                    End If

                    'Váriaveis Locais
                    Dim iRowIndex As Integer = grdOrcamentoProduto.CurrentRow.RowIndex
                    Dim iColIndex As Integer = grdOrcamentoProduto.CurrentColumn.Index

                    'Verifica a Quantidade de Entrega
                    If IsDate(grdOrcamentoProduto.GetValue("prazo_entrega2")) Then
                        If grdOrcamentoProduto.GetValue("quantidade_entrega") > 1 And grdOrcamentoProduto.GetValue("prazo_entrega") <> grdOrcamentoProduto.GetValue("prazo_entrega2") Then
                            'Verifica se o Usuário deseja proceder a alteração
                            If MsgBox("Esta Entrega é Desmembrada. Deseja manter a atualização?" & vbCrLf & vbCrLf & "Obs.: A Entrega deixará de ser desmembrada.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                                grdOrcamentoProduto.SetValue("prazo_entrega", grdOrcamentoProduto.GetValue("prazo_entrega2"))
                                Exit Sub
                            End If
                        End If
                    End If

                    If IsDate(grdOrcamentoProduto.GetValue("prazo_entrega2")) = False OrElse grdOrcamentoProduto.GetValue("prazo_entrega") <> grdOrcamentoProduto.GetValue("prazo_entrega2") Then

                        'Exclui Registro da tb_cmp_cotacao_fornecedor_item_entrega
                        Call oClsCmpCotacao.DeleteCotacaoFornecedorOrcamentoItemEntrega(cboNumeroCotacaoOrcamento.SelectedValue,
                                                                                        grdOrcamentoProduto.GetValue("codigo_cotacao_item"),
                                                                                        cboFornecedorOrcamento.SelectedValue)

                        If IsDate(grdOrcamentoProduto.GetValue("prazo_entrega")) = True Then

                            'Insere Previsão de Entrega
                            Call oClsCmpCotacao.InsertCotacaoFornecedorOrcamentoItemEntrega(cboNumeroCotacaoOrcamento.SelectedValue,
                                                                                            grdOrcamentoProduto.GetValue("codigo_cotacao_item"),
                                                                                            cboFornecedorOrcamento.SelectedValue,
                                                                                            grdOrcamentoProduto.GetValue("prazo_entrega"),
                                                                                            grdOrcamentoProduto.GetValue("quantidade"))

                        End If

                        'Carrega Grid
                        Call oClsCmpCotacao.LoadGridCotacaoFornecedorOrcamentoItem(grdOrcamentoProduto,
                                                                                   TipoItem.produto,
                                                                                   cboNumeroCotacaoOrcamento.SelectedValue,
                                                                                   cboFornecedorOrcamento.SelectedValue)

                        'grdOrcamentoProduto.FocusCellDisplayMode = FocusCellDisplayMode.UseFocusCellFormatStyle
                        grdOrcamentoProduto.Row = iRowIndex
                        grdOrcamentoProduto.Col = iColIndex
                        grdOrcamentoProduto.EditMode = EditMode.EditOn

                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdOrcamentoProduto_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdOrcamentoProduto.RowDoubleClick

        Try

            'Verifica se a Linha pressionada é Válida
            If IsNothing(grdOrcamentoProduto.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdOrcamentoProduto.CurrentColumn.Key

                Case "historico" : Call HistoricoOrcamentoProduto()
                Case "desmembrar_entrega" : Call DesmembrarEntrega(grdOrcamentoProduto, TipoItem.produto)
                Case "numero_os" : Call EditarOrdemProducao(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdOrcamentoProduto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdOrcamentoProduto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamentoProduto,
                                     Formulario.ComprasCotacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdOrcamentoProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdOrcamentoProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamentoProduto.Name,
                                     Formulario.ComprasCotacao,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdOrcamentoProduto_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdOrcamentoProduto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdOrcamentoProduto.Name,
                                          Formulario.ComprasCotacao,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region " ::: SERVIÇO ::: "

    Private Sub grdOrcamentoServico_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grdOrcamentoServico.CellValueChanged

        Try

            'Váriaveis Locais
            Dim sQuery As String

            'Seta Váriavel
            sQuery = grdOrcamentoServico.GetValue("codigo_cotacao") & ", "
            sQuery &= grdOrcamentoServico.GetValue("codigo_cotacao_item") & ", "
            sQuery &= cboFornecedorOrcamento.SelectedValue & ", "
            sQuery &= goUsuario.iEmpresa

            Select Case e.Column.Key

                Case "pis_incluso", "aliquota_pis",
                     "cofins_incluso", "aliquota_cofins",
                     "ir_incluso", "aliquota_ir",
                     "csll_incluso", "aliquota_csll",
                     "inss_incluso", "aliquota_inss",
                     "iss_retido", "aliquota_iss",
                     "desconto_valor", "desconto_percentual",
                     "valor_unitario"

                    If IsNumeric(grdOrcamentoServico.GetValue(e.Column.Key)) = False Then
                        grdOrcamentoServico.SetValue(e.Column.Key, 0)
                    End If

                    If e.Column.Key = "desconto_valor" Then
                        If grdOrcamentoServico.GetValue("desconto_valor") > grdOrcamentoServico.GetValue("valor_unitario") Then
                            grdOrcamentoServico.SetValue("desconto_valor", 0)
                        End If
                        grdOrcamentoServico.SetValue("desconto_percentual", grdOrcamentoServico.GetValue("desconto_valor") / grdOrcamentoServico.GetValue("valor_unitario") * 100)
                    ElseIf e.Column.Key = "desconto_percentual" Then
                        If grdOrcamentoServico.GetValue("desconto_percentual") > 100 Then
                            grdOrcamentoServico.SetValue("desconto_percentual", 0)
                        End If
                        grdOrcamentoServico.SetValue("desconto_valor", grdOrcamentoServico.GetValue("valor_unitario") * grdOrcamentoServico.GetValue("desconto_percentual") / 100)
                    End If

                    'Váriaveis
                    Dim dValorUnitario As Double = grdOrcamentoServico.GetValue("valor_unitario") - grdOrcamentoServico.GetValue("desconto_valor")
                    Dim dValorUnitarioImposto As Double = dValorUnitario
                    dValorUnitarioImposto = IIf(grdOrcamentoServico.GetValue("iss_retido") = True, dValorUnitarioImposto - (dValorUnitario * grdOrcamentoServico.GetValue("aliquota_iss") / 100), dValorUnitarioImposto)
                    dValorUnitarioImposto = IIf(grdOrcamentoServico.GetValue("pis_incluso") = True, dValorUnitarioImposto - (dValorUnitario * grdOrcamentoServico.GetValue("aliquota_pis") / 100), dValorUnitarioImposto)
                    dValorUnitarioImposto = IIf(grdOrcamentoServico.GetValue("cofins_incluso") = True, dValorUnitarioImposto - (dValorUnitario * grdOrcamentoServico.GetValue("aliquota_cofins") / 100), dValorUnitarioImposto)
                    dValorUnitarioImposto = IIf(grdOrcamentoServico.GetValue("ir_incluso") = True, dValorUnitarioImposto - (dValorUnitario * grdOrcamentoServico.GetValue("aliquota_ir") / 100), dValorUnitarioImposto)
                    dValorUnitarioImposto = IIf(grdOrcamentoServico.GetValue("inss_incluso") = True, dValorUnitarioImposto - (dValorUnitario * grdOrcamentoServico.GetValue("aliquota_inss") / 100), dValorUnitarioImposto)
                    dValorUnitarioImposto = IIf(grdOrcamentoServico.GetValue("csll_incluso") = True, dValorUnitarioImposto - (dValorUnitario * grdOrcamentoServico.GetValue("aliquota_csll") / 100), dValorUnitarioImposto)

                    'Seta Valor Total
                    grdOrcamentoServico.SetValue("valor_total", dValorUnitarioImposto * grdOrcamentoServico.GetValue("quantidade"))

                    'Atualiza Valor na Tabela
                    If e.Column.Key = "desconto_valor" Or e.Column.Key = "desconto_percentual" Then
                        Call ExecuteQuery("sp_update_compras_cotacao_fornecedor_item_campo 'desconto_valor', '" & CDbl(grdOrcamentoServico.GetValue("desconto_valor")).ToString.Replace(",", ".") & "'," & sQuery)
                    Else
                        Call ExecuteQuery("sp_update_compras_cotacao_fornecedor_item_campo '" & e.Column.Key & "', '" & CDbl(grdOrcamentoServico.GetValue(e.Column.Key)).ToString.Replace(",", ".") & "'," & sQuery)
                    End If

                Case "prazo_entrega"

                    If IsDate(grdOrcamentoServico.GetValue("prazo_entrega")) = False OrElse grdOrcamentoServico.GetValue("prazo_entrega").ToString.Length < 10 Then Exit Sub

                    Dim iRowIndex As Integer = grdOrcamentoServico.CurrentRow.RowIndex
                    Dim iColIndex As Integer = grdOrcamentoServico.CurrentColumn.Index

                    'Verifica a Quantidade de Entrega
                    If IsDate(grdOrcamentoServico.GetValue("prazo_entrega2")) Then
                        If grdOrcamentoServico.GetValue("quantidade_entrega") > 1 And grdOrcamentoServico.GetValue("prazo_entrega") <> grdOrcamentoServico.GetValue("prazo_entrega2") Then
                            'Verifica se o Usuário deseja proceder a alteração
                            If MsgBox("Esta Entrega é Desmembrada. Deseja manter a atualização?" & vbCrLf & vbCrLf & "Obs.: A Entrega deixará de ser desmembrada.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                                grdOrcamentoServico.SetValue("prazo_entrega", grdOrcamentoServico.GetValue("prazo_entrega2"))
                                Exit Sub
                            End If
                        End If
                    End If

                    If IsDate(grdOrcamentoServico.GetValue("prazo_entrega2")) = False OrElse grdOrcamentoServico.GetValue("prazo_entrega") <> grdOrcamentoProduto.GetValue("prazo_entrega2") Then

                        'Exclui Registro da tb_cmp_cotacao_fornecedor_item_entrega
                        Call oClsCmpCotacao.DeleteCotacaoFornecedorOrcamentoItemEntrega(cboNumeroCotacaoOrcamento.SelectedValue,
                                                                                        grdOrcamentoServico.GetValue("codigo_cotacao_item"),
                                                                                        cboFornecedorOrcamento.SelectedValue)

                        If IsDate(grdOrcamentoServico.GetValue("prazo_entrega")) = True Then

                            'Insere Previsão de Entrega
                            Call oClsCmpCotacao.InsertCotacaoFornecedorOrcamentoItemEntrega(cboNumeroCotacaoOrcamento.SelectedValue,
                                                                                            grdOrcamentoServico.GetValue("codigo_cotacao_item"),
                                                                                            cboFornecedorOrcamento.SelectedValue,
                                                                                            grdOrcamentoServico.GetValue("prazo_entrega"),
                                                                                            grdOrcamentoServico.GetValue("quantidade"))

                        End If

                        'Carrega Grid
                        Call oClsCmpCotacao.LoadGridCotacaoFornecedorOrcamentoItem(grdOrcamentoServico,
                                                                                   TipoItem.servico,
                                                                                   cboNumeroCotacaoOrcamento.SelectedValue,
                                                                                   cboFornecedorOrcamento.SelectedValue)

                        'grdOrcamentoProduto.FocusCellDisplayMode = FocusCellDisplayMode.UseFocusCellFormatStyle
                        grdOrcamentoServico.Row = iRowIndex
                        grdOrcamentoServico.Col = iColIndex
                        grdOrcamentoServico.EditMode = EditMode.EditOn

                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdOrcamentoServico_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdOrcamentoServico.RowDoubleClick

        Try

            'Verifica se a Linha pressionada é Válida
            If IsNothing(grdOrcamentoServico.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdOrcamentoServico.CurrentColumn.Key

                Case "historico" : Call HistoricoOrcamentoServico()
                Case "desmembrar_entrega" : Call DesmembrarEntrega(grdOrcamentoServico, TipoItem.servico)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdOrcamentoServico_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdOrcamentoServico.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamentoServico,
                                     Formulario.ComprasCotacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdOrcamentoServico_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdOrcamentoServico.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamentoServico.Name,
                                     Formulario.ComprasCotacao,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdOrcamentoServico_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdOrcamentoServico.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdOrcamentoServico.Name,
                                          Formulario.ComprasCotacao,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.InitialDirectory = "c:\\dados"

            arqArquivo.Title = "Selecione o Arquivo"

            If arqArquivo.ShowDialog() = DialogResult.OK Then
                txtArquivo.Text = arqArquivo.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoArquivo() = False Then Exit Sub

            SalvarArquivo()
            LoadGridArquivo()
            NovoArquivo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirArquivo.Click

        Try

            DeleteArquivo()
            LoadGridArquivo()
            NovoArquivo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdArquivo_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdArquivo.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdArquivo.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdArquivo.CurrentColumn.Key

                Case "visualizar" : Call VisualizarDocumento(grdArquivo.CurrentRow.Cells("arquivo").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdArquivo.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo,
                                     Formulario.ComprasCotacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name,
                                     Formulario.ComprasCotacao,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_GroupsChanging(sender As Object, e As GroupsChangingEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdArquivo.Name,
                                          Formulario.ComprasCotacao,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: APROVAÇÃO :::"

    Private Sub btnAprovarOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprovarOrcamento.Click

        Try

            'Verifica se foi Preenchido o Campo - Descritivo do Orçamento
            'If ValidaCampo(txtDescritivoAprovacao, lblDescritivoAprovacao, TipoCampo.texto) = False Then
            '    Exit Sub
            'End If

            '
            Dim dValorTotalPedido As Double = grdVencedores.GetValue("valor_final")
            If dValorTotalPedido < 0 Then
                MsgBox("Valor Total é Menor que R$0,00", MsgBoxStyle.Information, "Geração de Pedido de Compra")
                Exit Sub
            End If

            'Verifica se foi Selecinado alguma Linha
            If VerificaSelecaoRow(grdAprovacao) = True Then

                'Verifica se o Usuário deseja Aprovar a Cotação
                If MsgBox("Deseja Aprovar a Cotação: " & cboNumeroCotacaoAprovacao.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    For Each oRow In gSelecaoRow

                        'Verifica se o Preço selecionado é o menor
                        If oRow.Cells("selecionado_preco").Value = False Then

                            'Abre Formulário para preencher a Justificativa
                            Dim oForm As New frmCadJustificativa
                            oForm.Table = "tb_cmp_cotacao_fornecedor_item"
                            oForm.Tipo = "PREÇO"
                            oForm.Codigo = cboNumeroCotacaoAprovacao.SelectedValue
                            oForm.Codigo2 = oRow.Cells("codigo_cotacao_fornecedor").Value
                            oForm.Codigo3 = oRow.Cells("codigo_cotacao_item").Value
                            oForm.txtMotivo.Text = "Não foi selecionado o Orçamento com menor Valor para o Item: " & vbCrLf & oRow.Cells("codigo_produto_servico").Value.ToString & " - " & oRow.Cells("descricao").Value.ToString

                            'Abre Formulário
                            oForm.ShowDialog(Me)

                            'Verifica o Retorno
                            If oForm.Retorno = "N" Then
                                'Carrega Grid
                                Call cboFormaAnaliseOrcamento_SelectedIndexChanged(cboFormaAnaliseOrcamento, System.EventArgs.Empty)
                                'Sai da Sub
                                Exit Sub
                            End If

                        End If

                    Next

                    'Aprova Cotação
                    oClsCmpCotacao.AprovarCotacao(cboNumeroCotacaoAprovacao.SelectedValue,
                                                  txtDescritivoAprovacao.Text.Trim,
                                                  txtObservacaoAprovacao.Text.Trim,
                                                  "COTAÇÃO APROVADA",
                                                  grdAprovacao)



                    Dim oClsCmpPedido As New clsUsrCmpPedido
                    Dim sMensagem As String = ""
                    Dim lCodigoPedidoPrimeiro As Long = -1


                    For iRowFornecedor As Integer = 0 To grdVencedores.GetRows.Count - 1

                        'Seta a linha 
                        grdVencedores.Row = iRowFornecedor

                        Dim lCodigoPedido As Long
                        Dim sNumeroPedido As String


                        Dim iCodigoFornecedor As Integer = LoadCodigo("sp_select_cadastro_basico_parceiro_negocio_codigo '" & grdVencedores.GetValue("fornecedor") & "'," & goUsuario.iEmpresa & "," & cboNumeroCotacaoAprovacao.SelectedValue)

                        Dim dValorAlcadaUsuario As Double = LoadCodigo("sp_load_compras_valor_alcada " & goUsuario.iUsuario & "," & goUsuario.iEmpresa)
                        Dim bAprovador As Boolean = LoadCodigo("sp_load_compras_cotacao_usuario_aprovador " & goUsuario.iUsuario & "," & goUsuario.iEmpresa)

                        'Insere Pedido de Compra
                        Call oClsCmpPedido.InsertPedido(iCodigoFornecedor,
                                                            IIf(IsDBNull(grdVencedores.GetValue("codigo_modalidade_frete")), -1, grdVencedores.GetValue("codigo_modalidade_frete")),
                                                            IIf(IsDBNull(grdVencedores.GetValue("codigo_transportadora")), -1, grdVencedores.GetValue("codigo_transportadora")),
                                                            IIf(IsDBNull(grdVencedores.GetValue("codigo_condicao_pagamento")), -1, grdVencedores.GetValue("codigo_condicao_pagamento")),
                                                            IIf(IsDBNull(grdVencedores.GetValue("codigo_forma_pagamento")), -1, grdVencedores.GetValue("codigo_forma_pagamento")),
                                                            IIf(IsDBNull(grdVencedores.GetValue("codigo_moeda")), -1, grdVencedores.GetValue("codigo_moeda")),
                                                            IIf(IsDBNull(grdVencedores.GetValue("fator_cambial")), 1, grdVencedores.GetValue("fator_cambial")),
                                                            IIf(IsDBNull(grdVencedores.GetValue("valor_frete")), 0, grdVencedores.GetValue("valor_frete")),
                                                            0,
                                                            0,
                                                            0,
                                                            0,
                                                            0,
                                                            IIf(IsDBNull(grdVencedores.GetValue("descritivo")), "", grdVencedores.GetValue("descritivo")),
                                                            lCodigoPedido,
                                                            sNumeroPedido)



                        grdVencedores.SetValue("codigo_pedido", lCodigoPedido)
                        grdVencedores.SetValue("numero_pedido", sNumeroPedido)

                        If lCodigoPedidoPrimeiro = -1 Then
                            lCodigoPedidoPrimeiro = lCodigoPedido
                        End If

                        sMensagem += IIf(sMensagem = "", "", ",") & sNumeroPedido


                        'Insere os itens 
                        For Each oRow In grdAprovacao.GetCheckedRows

                            If oRow.Cells.Item("codigo_fornecedor").Value = iCodigoFornecedor Then

                                Call oClsCmpPedido.InsertPedidoItem(lCodigoPedido, oRow)

                            End If

                        Next

                        If dValorAlcadaUsuario < dValorTotalPedido And bAprovador = 0 Then
                            'Envia email para responsavel para Aprovacao 
                            oClsCmpPedido.EnviarEmailAprovacaoSupervisorLegado(lCodigoPedido)

                        Else
                            'Aprova o pedido
                            Call oClsCmpPedido.Aprovar(lCodigoPedido)
                            oClsCmpPedido.EnviarEmailAprovacaoPedidoGerado(lCodigoPedido)


                        End If

                    Next

                    MsgBox("Pedidos gerados: " + sMensagem, MsgBoxStyle.Information, "Geração de Pedido de Compra")


                    Dim oUserControl As UserControl
                    Dim oAssembly As Assembly = GetExecutingAssembly()


                    oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrCmpPedido")
                    oUserControl.Dock = DockStyle.Fill
                    oUserControl.Tag = "ID:" + CStr(lCodigoPedidoPrimeiro)

                    frmMain.LoadPage("Pedido de Compra", "Pedido de Compra", oUserControl, True)


                    'Carrega Combo
                    Call LoadCombo(cboNumeroCotacaoAprovacao, "sp_select_combo_compras_cotacao_status " & goUsuario.iEmpresa & ", " & CInt(StatusComprasCotacao.Cotando).ToString, False)

                    'Informa o Usuário sobre o sucesso da Operação
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function VerificaAlcada(dValorPedido As Double) As Boolean

        Try

            Dim dValorAlcada As Double = LoadCodigo("sp_load_compras_valor_alcada_cotacao " & goUsuario.iUsuario & "," & goUsuario.iEmpresa)

            If dValorPedido > dValorAlcada Then
                MsgBox("Essa ação não pode ser realizada, pois o valor do pedido excede o limite autorizado para o usuário logado.", MsgBoxStyle.Exclamation, "Validação")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub cboNumeroCotacaoAprovacao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNumeroCotacaoAprovacao.SelectedIndexChanged

        Try

            'Limpa erro
            frmMain.errInfo.Clear()

            'Verifica se foi selecionado Algum Registro
            If cboNumeroCotacaoAprovacao.SelectedIndex = -1 Then

                'Limpa Controles
                txtDataCotacaoAprovacao.Text = ""
                txtDescritivoAprovacao.Text = ""
                cboFormaAnaliseOrcamento.SelectedIndex = -1
                txtObservacaoAprovacao.Text = ""
                grdAprovacao.DataSource = Nothing
                grdVencedores.DataSource = Nothing
                grdVencedores.DataSource = Nothing

            Else

                lCodigoCotacao = cboNumeroCotacaoAprovacao.SelectedValue

                'Carrega Dados da Cotação
                Call oClsCmpCotacao.LoadDadosCotacao(cboNumeroCotacaoAprovacao.SelectedValue, _
                                                     txtDataCotacaoAprovacao, _
                                                     txtDescritivoAprovacao)

                'Carrega Grid de Aprovação
                Call oClsCmpCotacao.LoadGridCotacaoAprovacao(grdAprovacao, _
                                                             cboNumeroCotacaoAprovacao.SelectedValue)

                'Carrega Grid de Frete
                Call oClsCmpCotacao.LoadGridFreteAprovacao(grdVencedores, _
                                                           cboNumeroCotacaoAprovacao.SelectedValue)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboFormaAnaliseOrcamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFormaAnaliseOrcamento.SelectedIndexChanged

        Try

            'Desmarca melhor Compra
            For Each oRow As GridEXRow In grdAprovacao.GetCheckedRows
                oRow.CheckState = RowCheckState.Unchecked
            Next

            'Atualiza a Grid
            grdAprovacao.Refresh()

            'Verifica se foi Selecionado alguma Forma de Análise
            If cboFormaAnaliseOrcamento.SelectedIndex <> -1 Then

                Call oClsCmpCotacao.LoadGridCotacaoAprovacao(grdAprovacao, _
                                                             cboNumeroCotacaoAprovacao.SelectedValue, _
                                                             cboFormaAnaliseOrcamento.SelectedValue)

                'Carrega Grid de Vencedor
                Call oClsCmpCotacao.LoadGridVencedorAprovacao(grdVencedores, _
                                                              grdAprovacao.GetCheckedRows)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColunaAprovacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColunaAprovacao.SelectedIndexChanged

        Try

            'Congelar Coluna
            If cboCongelarColunaAprovacao.SelectedIndex = -1 Then
                grdAprovacao.FrozenColumns = 2
            Else
                grdAprovacao.FrozenColumns = cboCongelarColunaAprovacao.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAprovacao_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdAprovacao.RowCheckStateChanged

        Try

            'Váriaveis Locais
            Dim lCodigoCotacao = grdAprovacao.CurrentRow.Cells("codigo_cotacao").Value
            Dim iCodigoCotacaoItem = grdAprovacao.CurrentRow.Cells("codigo_cotacao_item").Value
            Dim iCodigoCotacaoFornecedor = grdAprovacao.CurrentRow.Cells("codigo_cotacao_fornecedor").Value
            Dim oRow As GridEXRow

            'Desmarca a outra opção            
            For Each oRow In grdAprovacao.GetDataRows
                If oRow.Cells("codigo_cotacao").Value = lCodigoCotacao And _
                    oRow.Cells("codigo_cotacao_item").Value = iCodigoCotacaoItem And _
                    oRow.Cells("codigo_cotacao_fornecedor").Value <> iCodigoCotacaoFornecedor Then
                    oRow.CheckState = RowCheckState.Unchecked
                End If
            Next

            'Atualiza a Grid
            grdAprovacao.Refresh()

            'Carrega Grid de Vencedor
            Call oClsCmpCotacao.LoadGridVencedorAprovacao(grdVencedores, _
                                                          grdAprovacao.GetCheckedRows)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAprovacao_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdAprovacao.RowDoubleClick

        Try

            'Verifica se a Linha pressionada é Válida
            If IsNothing(grdAprovacao.CurrentColumn) = True Then Exit Sub

            'Verifica qual linha foi Pressionada
            Select Case grdAprovacao.CurrentColumn.Key

                Case "grafico" : Call GraficoEvolucaoPreco()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAprovacao_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdAprovacao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdAprovacao, _
                                     Formulario.ComprasCotacaoAprovarOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAprovacao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdAprovacao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdAprovacao.Name, _
                                     Formulario.ComprasCotacaoAprovarOrcamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAprovacao_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdAprovacao.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdAprovacao.Name, _
                                          Formulario.ComprasCotacao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdVencedores_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdVencedores.CellUpdated

        Try

            'Váriavel Clausula
            Dim sWhere As String

            sWhere = "WHERE (((codigo_cotacao) = " & grdVencedores.GetValue("codigo_cotacao") & ") "
            sWhere &= "AND ((codigo_empresa) = " & goUsuario.iEmpresa & ") "
            sWhere &= "AND ((codigo) = " & grdVencedores.GetValue("codigo_cotacao_fornecedor") & ")) "

            'Atualiza Banco de dados
            Select Case e.Column.Key
                Case "valor_frete"
                    If IsNumeric(grdVencedores.GetValue("valor_frete")) Then
                        Call ExecuteQuery("sp_update_interacti_table_field 'tb_cmp_cotacao_fornecedor', 'valor_frete', " & grdVencedores.GetValue("valor_frete").ToString.Replace(".", "").Replace(",", ".") & ",'" & sWhere & "'")
                    Else
                        grdVencedores.SetValue("valor_frete", 0)
                    End If
                Case "valor_desconto"
                    If IsNumeric(grdVencedores.GetValue("valor_desconto")) Then
                        Call ExecuteQuery("sp_update_interacti_table_field 'tb_cmp_cotacao_fornecedor', 'valor_desconto', " & grdVencedores.GetValue("valor_desconto").ToString.Replace(".", "").Replace(",", ".") & ",'" & sWhere & "'")
                        grdVencedores.SetValue("percentual_desconto", grdVencedores.GetValue("valor_desconto") / grdVencedores.GetValue("valor_pedido") * 100)
                    Else
                        grdVencedores.SetValue("valor_desconto", 0)
                        grdVencedores.SetValue("percentual_desconto", 0)
                    End If
                Case "percentual_desconto"
                    If IsNumeric(grdVencedores.GetValue("percentual_desconto")) Then
                        grdVencedores.SetValue("valor_desconto", grdVencedores.GetValue("valor_pedido") * grdVencedores.GetValue("percentual_desconto") / 100)
                        Call ExecuteQuery("sp_update_interacti_table_field 'tb_cmp_cotacao_fornecedor', 'valor_desconto', " & grdVencedores.GetValue("valor_desconto").ToString.Replace(".", "").Replace(",", ".") & ",'" & sWhere & "'")
                    Else
                        grdVencedores.SetValue("valor_desconto", 0)
                        grdVencedores.SetValue("percentual_desconto", 0)
                    End If
            End Select

            'Atualiza Grid
            grdVencedores.SetValue("valor_final", grdVencedores.GetValue("valor_pedido") + grdVencedores.GetValue("valor_frete") - grdVencedores.GetValue("valor_desconto"))

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCmpCotacao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo - Filtro
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_compras_cotacao")
            Call LoadComboColunasGrid(cboCongelarColunaCotacao, grdListagem)
            'Carrega Combo - Requisição
            Call LoadCombo(cboTipoItem, "sp_select_combo_static_tipo_item", False)
            Call LoadCombo(cboUnidadeMedidaItem, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa, False)
            'Carrega Combo - Definir Fornecedor
            Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa, False)
            'Carrega Combo - Orçamento
            Call LoadCombo(cboCondicaoPagamentoOrcamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCondicaoPagamentoDefinirFornecedor, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboFormaPagamentoOrcamento, "sp_select_combo_static_forma_pagamento", False)
            Call LoadCombo(cboMoedaOrcamento, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa, False)
            cboMoedaOrcamento.SelectedValue = 1
            Call LoadCombo(cboModalidadeFreteOrcamento, "sp_select_combo_static_modalidade_frete", False)
            Call LoadCombo(cboModalidadeFreteDefinirFornecedor, "sp_select_combo_static_modalidade_frete", False)

            Call LoadCombo(cboTransportadoraOrcamento, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboModalidadeTransporteOrcamento, "sp_select_combo_cadastro_basico_modalidade_transporte " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboIncotermsOrcamento, "sp_select_combo_cadastro_basico_incoterms " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboAgenteLogisticoOrcamento, "sp_select_combo_cadastro_basico_agente_logistico " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboInstrucaoEmbarqueOrcamento, "sp_select_combo_cadastro_basico_instrucao_embarque " & goUsuario.iEmpresa, False)

            'Carrega Combo - Aprovação
            Call LoadCombo(cboFormaAnaliseOrcamento, "sp_select_combo_static_forma_analise_orcamento", False)
            Call LoadComboColunasGrid(cboCongelarColunaAprovacao, grdAprovacao)
            'Carrega Combo - Grid
            Call LoadComboGrid(grdListagem, "codigo_centro_custo", "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
            Call LoadComboGrid(grdListagem, "codigo_conta_contabil", "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", -1")
            Call LoadCombo(cboNumeroCotacaoFornecedor, "sp_select_combo_compras_cotacao_status " & goUsuario.iEmpresa & ", " & CInt(StatusComprasCotacao.Cotando).ToString, False)
            Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboNumeroCotacaoOrcamento, "sp_select_combo_compras_cotacao_status " & goUsuario.iEmpresa & ", " & CInt(StatusComprasCotacao.Cotando).ToString, False)
            Call LoadCombo(cboNumeroCotacaoAprovacao, "sp_select_combo_compras_cotacao_status_aprovacao " & goUsuario.iEmpresa & ", " & CInt(StatusComprasCotacao.Cotando).ToString, False)
            'Verifica Direito - Cotação
            btnGerarCotacao.Enabled = VerificaDireito(Formulario.ComprasCotacao, gcInsert)
            btnInserirFornecedor.Enabled = VerificaDireito(Formulario.ComprasCotacaoDefinirFornecedor, gcInsert)
            btnExcluirFornecedor.Enabled = VerificaDireito(Formulario.ComprasCotacaoDefinirFornecedor, gcDelete)
            'Verifica Direito - Cadastro Básico - Requisição
            btnCadastrarContaContabilItem.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcInsert)
            btnCadastrarCentroGastoItem.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)
            btnCadastrarUnidadeMedidaItem.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)
            'Verifica Direito - Cadastro Básico - Definir Fornecedor
            btnCadastrarFornecedor.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            'Verifica Direito - Cadastro Básico - Orçamento
            btnCadastrarCondicaoPagamentoOrcamento.Enabled = VerificaDireito(Formulario.CadastroBasicoCondicaoPagamento, gcInsert)
            btnCadastrarMoedaOrcamento.Enabled = VerificaDireito(Formulario.CadastroBasicoMoeda, gcInsert)
            btnCadastrarTransportadoraOrcamento.Enabled = VerificaDireito(Formulario.CadastroBasicoTransportadora, gcInsert)
            btnCadastrarModalidadeTransporteOrcamento.Enabled = VerificaDireito(Formulario.CadastroBasicoModalidadeTransporte, gcInsert)
            btnCadastrarIncotermsOrcamento.Enabled = VerificaDireito(Formulario.CadastroBasicoIncoterms, gcInsert)
            btnCadastrarAgenteLogisticoOrcamento.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarInstrucaoEmbarqueOrcamento.Enabled = VerificaDireito(Formulario.CadastroBasicoInstrucaoEmbarque, gcInsert)


            'Configura Controles de Data - Filtro         
            dtpDataCotacaoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataCotacaoInicioFiltro.Checked = False
            dtpDataCotacaoTerminoFiltro.Value = Now.Date : dtpDataCotacaoTerminoFiltro.Checked = False
            'Configura Controles de Data - Dados da Requisição
            dtpDataNecessidadeItem.Value = Now.Date : dtpDataNecessidadeItem.Checked = False
            'Configura Controles de Data - Definir Fornecedor
            dtpDataPrazoRespostaFornecedor.Value = Now.Date : dtpDataPrazoRespostaFornecedor.Checked = False
            'Configura Controles de Data - Orçamento
            dtpDataValidadeOrcamento.Value = Now.Date : dtpDataValidadeOrcamento.Checked = False

            'Remove Aba de Requisição
            tabMain.TabPages.Remove(pagRequisicao)
            'Verifica se o Usuário tem Direito de Ver o Perfil
            If VerificaDireito(Formulario.ComprasCotacaoDefinirFornecedor, gcSelect) = False Then
                tabMain.TabPages.Remove(pagFornecedor)
            End If
            'Verifica se o Usuário tem Direito de Ver o Perfil
            If VerificaDireito(Formulario.ComprasCotacaoOrcamento, gcSelect) = False Then
                tabMain.TabPages.Remove(pagOrcamento)
            End If
            'Verifica se o Usuário tem Direito de Ver o Perfil
            If VerificaDireito(Formulario.ComprasCotacaoAprovarOrcamento, gcSelect) = False Then
                tabMain.TabPages.Remove(pagAprovacao)
            End If

            'Dim sStatus(0) As Object
            'sStatus(0) = 1
            'cboStatusFiltro.CheckedItems = sStatus

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasCotacao)
            Call ConfiguraGrid(grdFornecedor, Formulario.ComprasCotacaoDefinirFornecedor)
            Call ConfiguraGrid(grdAprovacao, Formulario.ComprasCotacaoAprovarOrcamento)
            Call ConfiguraGrid(grdOrcamentoProduto, Formulario.ComprasCotacao)
            Call ConfiguraGrid(grdOrcamentoServico, Formulario.ComprasCotacao)
            Call ConfiguraGrid(grdArquivo, Formulario.ComprasCotacao)

            'Seta Focu
            tabMain.SelectedTab = pagCotacao
            txtNumeroCotacaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub AlterarTabMain(ByVal sNomePagina As String)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Select Case sNomePagina

                Case "pagFornecedor"

                    'Carrega Combo
                    Call LoadCombo(cboNumeroCotacaoFornecedor, "sp_select_combo_compras_cotacao_status " & goUsuario.iEmpresa & ", " & CInt(StatusComprasCotacao.Cotando).ToString, False)
                    Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa, False)

                    'Limpa Controles
                    dtpDataPrazoRespostaFornecedor.Value = Now.Date : dtpDataPrazoRespostaFornecedor.Checked = False
                    txtObservacaoFornecedor.Text = ""
                    btnInserirFornecedor.Tag = ""
                    grdCotacaoProdutos.DataSource = Nothing

                    cboNumeroCotacaoFornecedor.Focus()

                    If lCodigoCotacao = -1 Then
                        cboNumeroCotacaoFornecedor.SelectedIndex = -1
                    Else
                        VerificaComboCodigoExistente(cboNumeroCotacaoFornecedor, lCodigoCotacao)
                    End If

                Case "pagOrcamento"
                    'Carrega Combo
                    Call LoadCombo(cboNumeroCotacaoOrcamento, "sp_select_combo_compras_cotacao_status " & goUsuario.iEmpresa & ", " & CInt(StatusComprasCotacao.Cotando).ToString, False)

                    'Altera Aba
                    tabOrcamento.SelectedTab = pagProduto

                    cboNumeroCotacaoOrcamento.Focus()

                    If lCodigoCotacao = -1 Then
                        cboNumeroCotacaoOrcamento.SelectedIndex = -1
                    Else
                        VerificaComboCodigoExistente(cboNumeroCotacaoOrcamento, lCodigoCotacao)
                    End If

                Case "pagAprovacao"
                    'Carrega Combo
                    Call LoadCombo(cboNumeroCotacaoAprovacao, "sp_select_combo_compras_cotacao_status_aprovacao " & goUsuario.iEmpresa & ", " & CInt(StatusComprasCotacao.Cotando).ToString, False)
                    'Seta Aba
                    tabAprovacao.SelectedTab = pagDadosAprovacao

                    cboNumeroCotacaoAprovacao.Focus()

                    If lCodigoCotacao = -1 Then
                        cboNumeroCotacaoAprovacao.SelectedIndex = -1
                    Else
                        VerificaComboCodigoExistente(cboNumeroCotacaoAprovacao, lCodigoCotacao)
                    End If

                Case "pagCotacao"
                    txtNumeroCotacaoFiltro.Focus()

            End Select

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: COTAÇÃO :::"

    Private Sub EditarCotacao(ByVal lCodigo As Long)

        Try

            If grdListagem.GetValue("status") <> 2 Then
                MsgBox("Só é possível editar cotações que estejam com status de [COTANDO].", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            Dim i As Integer = LoadCodigo("sp_load_compras_cotacao_editar " & lCodigo & "," & goUsuario.iEmpresa)

            If i > 0 Then
                tabMain.SelectedTab = pagOrcamento
                cboNumeroCotacaoOrcamento.SelectedValue = lCodigo
            Else
                tabMain.SelectedTab = pagFornecedor
                cboNumeroCotacaoFornecedor.SelectedValue = lCodigo
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AprovarCotacao(ByVal lCodigoCotacao As Long)
        Try

            'Troca aba
            tabMain.SelectedTab = pagAprovacao

            'Carregar os eventos
            Application.DoEvents()

            'Carrega os dados
            cboNumeroCotacaoAprovacao.SelectedValue = lCodigoCotacao


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadGridCotacao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sStatus As String = ""

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Grid - Cotação
            oClsCmpCotacao.LoadGridCotacao(grdListagem, _
                                           IIf(IsNumeric(txtNumeroCotacaoFiltro.Text.Trim), txtNumeroCotacaoFiltro.Text.Trim, -1), _
                                           IIf(IsNumeric(txtNumeroRequisicaoFiltro.Text.Trim), txtNumeroRequisicaoFiltro.Text.Trim, -1), _
                                           sStatus, _
                                           IIf(dtpDataCotacaoInicioFiltro.Checked = True, dtpDataCotacaoInicioFiltro.Value, ""), _
                                           IIf(dtpDataCotacaoTerminoFiltro.Checked = True, dtpDataCotacaoTerminoFiltro.Value, ""), _
                                           txtItemFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GerarCotacao()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem, "status", CInt(StatusComprasCotacao.AguardandoCotacao)) = True Then

                'Verifica se é Necessário Validar Centro de Custo
                If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_centro_custo'"), Boolean) = True Then
                    For Each oRow As GridEXRow In gSelecaoRow
                        If IsDBNull(oRow.Cells("codigo_centro_custo").Value) = True Then
                            frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Existe Requisições que não possui Centro de Custo. Favor Preencher.")
                            Exit Sub
                        End If
                    Next
                End If

                'Verifica se o Usuário deseja gerar cotação dos Registros Selecionados
                If MsgBox("Deseja gerar Cotação para o(s) Registro(s) Selecionado(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Váriavel - Código Cotação
                    Dim lCodigoCotacao As Long
                    'Insere Cotação
                    oClsCmpCotacao.InsertCotacao(lCodigoCotacao)
                    'Insere Cotação Item
                    oClsCmpCotacao.InsertCotacaoItem(lCodigoCotacao)
                    'Carrega Grid - Cotação
                    Call LoadGridCotacao()


                    'Seta a página
                    tabMain.SelectedTab = pagFornecedor

                    'Altera a aba
                    AlterarTabMain(pagFornecedor.Key)

                    'Seta a cotação
                    cboNumeroCotacaoFornecedor.SelectedValue = lCodigoCotacao

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

    Private Sub CancelarItemCotacao(ByVal oRow As GridEXRow)

        Try

            'Verifica se o Usuário tem direito de cancelar a Cotação
            If VerificaDireito(Formulario.ComprasCotacao, gcAdministrator) = True Then

                'Verifica se o Registro esta no status de cotando
                If oRow.Cells("status").Value = CInt(StatusComprasCotacao.Cotando) Then

                    'Váriavel - Formulário de Cancelamento de Item da Cotação
                    Dim oForm As New frmCmpCotacaoItemCancelar

                    'Seta Parâmetros
                    oForm.NumeroCotacao = oRow.Cells("numero_cotacao").Value
                    oForm.NumeroRequisicao = oRow.Cells("numero_requisicao").Value
                    oForm.DataCotacao = oRow.Cells("data_cotacao").Value
                    oForm.DataNecessidade = IIf(IsDBNull(oRow.Cells("data_necessidade").Value), "", oRow.Cells("data_necessidade").Value)
                    oForm.Item = oRow.Cells("codigo_item").Value & " - " & oRow.Cells("descricao").Value
                    oForm.CodigoCotacao = oRow.Cells("codigo_cotacao").Value
                    oForm.CodigoCotacaoItem = oRow.Cells("codigo_cotacao_item").Value

                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                    'Carrega Grid
                    Call LoadGridCotacao()

                Else
                    'Informa o Usuário que o Registro não pode ser alterado                    
                    frmMain.Informacao(Mensagem.RegistroNaoPodeCancelado)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoCotacaoItem(ByVal oRow As GridEXRow)

        Try

            'Verifica se existe cotação para o item 
            If IsDBNull(oRow.Cells.Item("codigo_cotacao_item").Value) = False Then

                'Váriavel - Formulário de Histórico
                Dim oForm As New frmCmpCotacaoItemHistorico

                'Seta Tamanho / Posição do Formulário
                oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

                'Seta Parâmentros
                oForm.NumeroCotacao = oRow.Cells("numero_cotacao").Value
                oForm.NumeroRequisicao = oRow.Cells("numero_requisicao").Value
                oForm.DataCotacao = oRow.Cells("data_cotacao").Value
                oForm.DataNecessidade = IIf(IsDBNull(oRow.Cells("data_necessidade").Value), "", oRow.Cells("data_necessidade").Value)
                oForm.Item = oRow.Cells("codigo_item").Value & " - " & oRow.Cells("descricao").Value
                oForm.CodigoCotacao = oRow.Cells("codigo_cotacao").Value
                oForm.CodigoCotacaoItem = oRow.Cells("codigo_cotacao_item").Value

                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            Else
                'Informa o Usuário que não existe Cotação para o Item selecionado
                frmMain.Informacao(Mensagem.NaoExisteHistorico)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InserirCotacao(ByVal Row As GridEXRow)

        Try

            'Verifica se o Usuário tem direito de cancelar a Cotação
            If VerificaDireito(Formulario.ComprasCotacao, gcAdministrator) = True Then

                'Verifica se o Registro esta no status de Aguardando Cotação
                If Row.Cells("status").Value = CInt(StatusComprasCotacao.AguardandoCotacao) Then

                    'Váriavel - Formulário de Adicionar de Item da Cotação
                    Dim oForm As New frmCmpCotacaoItemAdicionar

                    'Seta Parâmetros
                    oForm.NumeroRequisicao = Row.Cells("numero_requisicao").Value
                    oForm.DataNecessidade = IIf(IsDBNull(Row.Cells("data_necessidade").Value), "", Row.Cells("data_necessidade").Value)
                    oForm.Quantidade = Row.Cells("quantidade").Value
                    oForm.UnidadeMedida = Row.Cells("unidade_medida").Value
                    oForm.Item = Row.Cells("descricao").Value
                    oForm.CodigoRequisicao = Row.Cells("codigo_requisicao").Value
                    oForm.CodigoRequisicaoItem = Row.Cells("codigo_requisicao_item").Value

                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                    'Carrega Grid
                    Call LoadGridCotacao()

                Else
                    'Informa o Usuário que o Registro não pode ser alterado                    
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub RetornarStatus(ByVal oRow As GridEXRow)

        Try

            Select Case oRow.Cells("status").Value

                Case CInt(StatusComprasCotacao.Cotando)

                    'Verifica se o usuário tem direito de Ativar o Item da Cotação
                    If VerificaDireito(Formulario.ComprasCotacao, gcInsert) = True Then

                        'Verifica se o Usuário deseja Retornar o Status do Orçamento
                        If MsgBox("Deseja voltar o Status do Item da Cotação: " & grdListagem.CurrentRow.Cells("descricao").Value & " para Aguardando Cotação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                            'Ativa Item da Cotação
                            oClsCmpCotacao.AlterarStatusCotacaoItem(grdListagem.CurrentRow.Cells("codigo_cotacao").Value, _
                                                                    grdListagem.CurrentRow.Cells("codigo_cotacao_item").Value, _
                                                                    "Item subtraido da Cotação: " & grdListagem.CurrentRow.Cells("numero_cotacao").Value, _
                                                                    CInt(StatusComprasCotacao.AguardandoCotacao))

                            'Informa o Usuário sobre o sucesso da Operação
                            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                            'Carrega a Grid
                            Call LoadGridCotacao()

                        End If

                    Else
                        'Informa o Usuário que ele não tem Direito
                        frmMain.Informacao(Mensagem.DireitoAdministrador)
                    End If

                Case CInt(StatusComprasCotacao.Cancelado)

                    'Verifica se o usuário tem direito de Ativar o Item da Cotação
                    If VerificaDireito(Formulario.ComprasCotacaoCancelar, gcInsert) = True Then

                        'Verifica se o Usuário deseja Retornar o Status do Orçamento
                        If MsgBox("Deseja tornar ativo o Item da Cotação: " & grdListagem.CurrentRow.Cells("descricao").Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                            'Ativa Item da Cotação
                            oClsCmpCotacao.AlterarStatusCotacaoItem(grdListagem.CurrentRow.Cells("codigo_cotacao").Value, _
                                                                    grdListagem.CurrentRow.Cells("codigo_cotacao_item").Value, _
                                                                    "Reativado o Item da Cotação", _
                                                                    StatusComprasCotacao.Cotando)

                            'Informa o Usuário sobre o sucesso da Operação
                            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                            'Carrega a Grid
                            Call LoadGridCotacao()

                        End If

                    Else
                        'Informa o Usuário que ele não tem Direito
                        frmMain.Informacao(Mensagem.DireitoAdministrador)
                    End If

                Case Else
                    'Informa o usuário que essa operação não é válida
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)

            End Select

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub UpdateReferencia()

        Try

            If grdListagem.CurrentRow.Cells("status").Value = 1 Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            oClsCmpCotacao.UpdateReferencia(grdListagem.CurrentRow.Cells("codigo_cotacao").Value, _
                                            grdListagem.CurrentRow.Cells("codigo_cotacao_item").Value, _
                                            IIf(IsDBNull(grdListagem.CurrentRow.Cells("referencia").Value), "", grdListagem.CurrentRow.Cells("referencia").Value))

            LoadGridCotacao()

            frmMain.Informacao(Mensagem.RegistroAlterado)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarRequisicaoCompra(ByVal lCodigo As Long)

        Try

            Dim oUserControl As UserControl
            Dim oAssembly As Assembly = GetExecutingAssembly()

            oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrCmpRequisicao")
            oUserControl.Dock = DockStyle.Fill
            oUserControl.Tag = "ID:" + CStr(lCodigo)

            frmMain.LoadPage("Requisição de Compra", "Requisição de Compra", oUserControl, True)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Private Sub EditarOrdemProducao(ByVal oGrid As GridEX)

        Try


            Dim oUserControl As UserControl
            Dim oAssembly As Assembly = GetExecutingAssembly()

            oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrPrdOrdemProducaoManual")
            oUserControl.Dock = DockStyle.Fill
            oUserControl.Tag = "ID:" + CStr(oGrid.CurrentRow.Cells.Item("codigo_ordem_producao").Value)

            frmMain.LoadPage("Ordem Produção", "Ordem de Produção", oUserControl, True)

            Application.DoEvents()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: REQUISIÇÃO :::"

    Private Sub EditarRequisicao(ByVal Row As GridEXRow)

        Try

            'Verifica se o Usuário tem direito de alterar a Requisição
            If VerificaDireito(Formulario.ComprasRequisicao, gcUpdate) = True Then

                'Verifica se o Registro esta no status de cotando
                If Row.Cells("status").Value = CInt(StatusComprasCotacao.AguardandoCotacao) Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Váriavel - Classe da Requisição
                    Dim oClsCmpRequisicao As New clsUsrCmpRequisicao

                    lCodigoRequisicao = grdListagem.CurrentRow.Cells("codigo_requisicao").Value
                    iCodigoRequisicaoItem = grdListagem.CurrentRow.Cells("codigo_requisicao_item").Value

                    'Carrega Controles
                    Call oClsCmpRequisicao.LoadControlesRequisicao(grdListagem.CurrentRow.Cells("codigo_requisicao").Value, _
                                                                   grdListagem.CurrentRow.Cells("codigo_requisicao_item").Value, _
                                                                   txtNumeroRequisicao, _
                                                                   txtAprovadorRequisicao, _
                                                                   cboTipoItem, _
                                                                   cboCodigoItem, _
                                                                   txtComplementoItem, _
                                                                   txtMarcaItem, _
                                                                   cboContaContabilItem, _
                                                                   cboCentroGastoItem, _
                                                                   txtQuantidadeItem, _
                                                                   cboUnidadeMedidaItem, _
                                                                   dtpDataNecessidadeItem, _
                                                                   txtJustificativaItem)

                    'Alterna Aba
                    tabMain.TabPages.Remove(pagFornecedor)
                    tabMain.TabPages.Remove(pagOrcamento)
                    tabMain.TabPages.Remove(pagAprovacao)
                    tabMain.TabPages.Remove(pagCotacao)
                    tabMain.TabPages.Add(pagRequisicao)

                    'Seta Focu
                    cboTipoItem.Focus()

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Else
                    'Informa o Usuário que o Registro não pode ser alterado                    
                    frmMain.Informacao(Mensagem.RegistroNaoPodeAlterado)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarRequisicao()

        Try

            'Váriaveis Locais - Requisição
            Dim oClsCmpRequisicao As New clsUsrCmpRequisicao

            'Atualiza Requisição - Produto
            Call oClsCmpRequisicao.UpdateCotacaoItem(lCodigoRequisicao, _
                                                        iCodigoRequisicaoItem, _
                                                        cboCodigoItem.SelectedValue, _
                                                        txtDescricaoItem.Text.Trim, _
                                                        txtComplementoItem.Text.Trim, _
                                                        txtMarcaItem.Text.Trim, _
                                                        IIf(cboContaContabilItem.SelectedIndex = -1, "", cboContaContabilItem.SelectedValue), _
                                                        IIf(cboCentroGastoItem.SelectedIndex = -1, -1, cboCentroGastoItem.SelectedValue), _
                                                        txtQuantidadeItem.Value, _
                                                        cboUnidadeMedidaItem.SelectedValue, _
                                                        IIf(dtpDataNecessidadeItem.Checked = False, "", dtpDataNecessidadeItem.Value), _
                                                        txtJustificativaItem.Text.Trim)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoRequisicao() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoRequisicao = False

            ''Verifica se foi Selecionado o Campo - Conta Contábil
            'If ValidaCampo(cboContaContabilItem, lblContaContabilRequisicao) = False Then
            '    Exit Function
            'End If

            ''Verifica se foi Selecionado o Campo - Centro de Gasto
            'If ValidaCampo(cboCentroGastoItem, lblCentroGastoRequisicao) = False Then
            '    Exit Function
            'End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadeItem, lblQuantidadeItem, True) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Unidade de Medida
            If cboUnidadeMedidaItem.Enabled = True Then
                If ValidaCampo(cboUnidadeMedidaItem, lblUnidadeMedidaItem) = False Then
                    Exit Function
                End If
            End If

            'Verifica se a Data de Necessidade informada é válida
            If dtpDataNecessidadeItem.Checked = True Then
                If dtpDataNecessidadeItem.Value < Now.Date Then
                    frmMain.errInfo.SetError(lblDataNecessidadeItem, "A Data de Necessidade não pode ser menor que o dia corrente.")
                    dtpDataNecessidadeItem.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Centro de Gasto
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_centro_custo'") = True Then
                If ValidaCampo(cboCentroGastoItem, lblCentroGastoItem) = False Then
                    Exit Function
                End If
            End If

            ''Verifica se foi Selecionado o Campo - Conta Contábil
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_conta_contabil'") = True Then
                If ValidaCampo(cboContaContabilItem, lblContaContabilItem) = False Then
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoRequisicao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: FORNECEDOR :::"

    Private Sub ExportarSolicitacaoOrcamento()
        Try

            Dim oFolderDialog As New FolderBrowserDialog
            If oFolderDialog.ShowDialog = DialogResult.OK Then

                Dim sFolder As String = oFolderDialog.SelectedPath

                For Each oRow In grdFornecedor.GetRows

                    Dim oRptDocument As New ReportDocument

                    'Abre Relatório
                    oRptDocument.Load(goCrystalReport.sPath & "CMP000000004.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

                    'Seta Parametros Relatório
                    oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
                    oRptDocument.SetParameterValue("@codigo_cotacao", oRow.Cells.Item("codigo_cotacao").Value)
                    oRptDocument.SetParameterValue("@codigo_cotacao_fornecedor", oRow.Cells.Item("codigo_cotacao_fornecedor").Value)
                    oRptDocument.SetParameterValue("usuario", goUsuario.sNome)

                    'Abre Conexão com o Banco de Dados
                    For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                        oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
                    Next

                    'Váriavel Relatório
                    Dim sArquivoReport As String = sFolder & "\" & _
                                                    cboNumeroCotacaoFornecedor.Text.ToString.Replace("\", "-").Replace("/", "-") & " - " & _
                                                    "LEGADO USINAGEM - " & _
                                                    oRow.Cells.Item("fornecedor").Value.ToString.Replace("\", "-").Replace("/", "-") & _
                                                    ".pdf"

                    'Verifica se o Arquivo Existe
                    If File.Exists(sArquivoReport) = True Then File.Delete(sArquivoReport)

                    'Exporta para Arquivo PDF
                    oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sArquivoReport)

                    'Limpa Váriavel
                    oRptDocument = Nothing
                Next

                frmMain.Informacao("Solicitações exportadas com sucesso!", Color.Blue)




            End If



        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SalvarCondicaoCotacao()
        Try

            frmMain.errInfo.Clear()

            'If ValidaCampo(cboCondicaoPagamentoDefinirFornecedor, lblCondicaoPagamentoDefinirFornecedor) = False Then Exit Sub
            'If ValidaCampo(cboModalidadeFreteDefinirFornecedor, lblModalidadeFreteDefinirFornecedor) = False Then Exit Sub
            'If ValidaCampo(dtpDataNecessidadeDefinirFornecedor, lblDataNecessidadeDefinirFornecedor) = False Then Exit Sub

            oClsCmpCotacao.SalvarCondicaoCotacao(cboNumeroCotacaoFornecedor.SelectedValue,
                                                 txtDescritivoFornecedor.Text,
                                                 IIf(cboCondicaoPagamentoDefinirFornecedor.SelectedIndex = -1, -1, cboCondicaoPagamentoDefinirFornecedor.SelectedValue),
                                                 IIf(cboModalidadeFreteDefinirFornecedor.SelectedIndex = -1, -1, cboModalidadeFreteDefinirFornecedor.SelectedValue))


            'Informa o usuário
            frmMain.Informacao("Condições da cotação armazenadas com sucesso!", Color.Blue)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub DeleteFornecedor()

        Try

            If VerificaSelecaoRow(grdFornecedor) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCmpCotacao.DeleteCotacaoFornecedor()

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

    Private Sub EditarFornecedor(ByVal oRow As GridEXRow)

        Try

            'Carrega Controles
            cboFornecedor.SelectedValue = oRow.Cells("codigo_fornecedor").Value
            If IsDBNull(oRow.Cells("data_prazo_resposta").Value) = True Then
                dtpDataPrazoRespostaFornecedor.Value = Now.Date : dtpDataPrazoRespostaFornecedor.Checked = False
            Else
                dtpDataPrazoRespostaFornecedor.Value = oRow.Cells("data_prazo_resposta").Value : dtpDataPrazoRespostaFornecedor.Checked = True
            End If
            txtObservacaoFornecedor.Text = oRow.Cells("observacao").Value
            btnInserirFornecedor.Tag = oRow.Cells("codigo_cotacao_fornecedor").Value

            'Seta Focu
            cboFornecedor.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EmailFornecedor(ByVal oRow As GridEXRow)

        Try

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Abre Relatório
            oRptDocument.Load(goCrystalReport.sPath & "CMP000000004.rpt", _
                              CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Seta Parametros Relatório
            oRptDocument.SetParameterValue("@codigo_cotacao", oRow.Cells("codigo_cotacao").Value)
            oRptDocument.SetParameterValue("@codigo_cotacao_fornecedor", oRow.Cells("codigo_cotacao_fornecedor").Value)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
            oRptDocument.SetParameterValue("usuario", goUsuario.sNome)

            'Abre Conexão com o Banco de Dados
            For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            Dim sArquivo As String = ApplicationPath() & "File\COTACAO_" & cboNumeroCotacaoFornecedor.Text & "_" & Format(Now, "yyyyMMdd_hhmm") & ".pdf"

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                      sArquivo)

            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Enviar E-mail
            Call EnviarEmail(goUsuario.sEmpresa & " - Solicitação de Orçamento " & cboNumeroCotacaoFornecedor.Text, _
                             LoadContato(grdFornecedor.CurrentRow.Cells("codigo_fornecedor").Value, TipoContato.Comercial), _
                             sArquivo, _
                             sArquivo, _
                             "", _
                             grdFornecedor.CurrentRow.Cells("codigo_fornecedor").Value, _
                             "", _
                             -1, _
                             -1, _
                             TipoAutotextoEmail.SolicitacaoOrcamento)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirFornecedor(ByVal oRow As GridEXRow)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(3)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_cotacao"
            goCrystalReport.sReportParameter(1).sValue = oRow.Cells("codigo_cotacao").Value
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
            goCrystalReport.sReportParameter(3).sParamenter = "@codigo_cotacao_fornecedor"
            goCrystalReport.sReportParameter(3).sValue = oRow.Cells("codigo_cotacao_fornecedor").Value
            goCrystalReport.sReport = goCrystalReport.sPath & "CMP000000004.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("CMP000000004", "Solicitação de Orçamento", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoFornecedor()

        Try

            'Limpa Controles
            cboFornecedor.SelectedIndex = -1
            dtpDataPrazoRespostaFornecedor.Value = Now.Date : dtpDataPrazoRespostaFornecedor.Checked = False
            txtObservacaoFornecedor.Text = ""
            btnInserirFornecedor.Tag = ""

            'Seta Focu
            cboFornecedor.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarFornecedor()

        Try

            'Verifica o Tipo da Operação
            If IsNumeric(btnInserirFornecedor.Tag) = False Then

                'Insere Registro na tb_cmp_cotacao_fornecedor / tb_cmp_cotacao_fornecedor_item
                oClsCmpCotacao.InsertCotacaoFornecedor(cboNumeroCotacaoFornecedor.SelectedValue, _
                                                       txtDescritivoFornecedor.Text.Trim, _
                                                       cboFornecedor.SelectedValue, _
                                                       IIf(dtpDataPrazoRespostaFornecedor.Checked = True, dtpDataPrazoRespostaFornecedor.Value, ""), _
                                                       txtObservacaoFornecedor.Text.Trim)

            Else

                'Altera Registro na tb_cmp_cotacao_fornecedor / tb_cmp_cotacao_fornecedor_item
                oClsCmpCotacao.UpdateCotacaoFornecedor(cboNumeroCotacaoFornecedor.SelectedValue, _
                                                       btnInserirFornecedor.Tag, _
                                                       cboFornecedor.SelectedValue, _
                                                       IIf(dtpDataPrazoRespostaFornecedor.Checked = True, dtpDataPrazoRespostaFornecedor.Value, ""), _
                                                       txtObservacaoFornecedor.Text.Trim)

            End If

            'Carrega Grid - Cotação Fornecedor
            Call oClsCmpCotacao.LoadGridCotacaoFornecedor(grdFornecedor, _
                                                          cboNumeroCotacaoFornecedor.SelectedValue)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoFornecedor() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoFornecedor = False

            'Verifica se foi Selecionado o Campo - Cotação
            If ValidaCampo(cboNumeroCotacaoFornecedor, lblNumeroCotacaoFornecedor) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Fornecedor
            If ValidaCampo(cboFornecedor, lblFornecedor) = False Then
                Exit Function
            End If

            'Verifica se o Fornecedor já foi Inserido
            If oClsCmpCotacao.ValidaCotacaoFornecedor(cboNumeroCotacaoFornecedor.SelectedValue, _
                                                      cboFornecedor.SelectedValue, _
                                                      IIf(IsNumeric(btnInserirFornecedor.Tag), btnInserirFornecedor.Tag, 0)) = False Then
                frmMain.errInfo.SetError(lblFornecedor, "Este Fornecedor já está incluso nesta Cotação.")
                cboFornecedor.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoFornecedor = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ORÇAMENTO :::"


    Private Sub btnDefinirOrcamento_Click(sender As Object, e As EventArgs) Handles btnDefinirOrcamento.Click
        Try

            If cboNumeroCotacaoFornecedor.SelectedIndex = -1 Then Exit Sub

            tabMain.SelectedTab = pagOrcamento

            AlterarTabMain(pagOrcamento.Key)

            cboNumeroCotacaoOrcamento.SelectedValue = cboNumeroCotacaoFornecedor.SelectedValue


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnAnalisarCotacao_Click(sender As Object, e As EventArgs) Handles btnAnalisarCotacao.Click
        Try

            If cboNumeroCotacaoOrcamento.SelectedIndex = -1 Then Exit Sub

            tabMain.SelectedTab = pagAprovacao

            AlterarTabMain(pagAprovacao.Key)

            cboNumeroCotacaoAprovacao.SelectedValue = cboNumeroCotacaoOrcamento.SelectedValue


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Function ValidacaoOrcamento() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoOrcamento = False

            'Verifica se foi Selecionado o Campo - Cotação
            If ValidaCampo(cboNumeroCotacaoOrcamento, lblNumeroCotacaoOrcamento) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Fornecedor
            If ValidaCampo(cboFornecedorOrcamento, lblFornecedorOrcamento) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Condição de Pagamento
            If ValidaCampo(cboCondicaoPagamentoOrcamento, lblCondicaoPagamentoOrcamento) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Forma de Pagamento
            If ValidaCampo(cboFormaPagamentoOrcamento, lblFormaPagamentoOrcamento) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Moeda
            If ValidaCampo(cboMoedaOrcamento, lblMoedaOrcamento) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Modalidade do Frete
            If ValidaCampo(cboModalidadeFreteOrcamento, lblModalidadeFreteOrcamento) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor do Frete
            If ValidaCampo(txtValorFreteOrcamento, lblValorFreteOrcamento, False) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Modalidade de Transporte
            If cboModalidadeTransporteOrcamento.Enabled = True Then
                If ValidaCampo(cboModalidadeTransporteOrcamento, lblModalidadeTransporteOrcamento) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Incoterms
            If cboIncotermsOrcamento.Enabled = True Then
                If ValidaCampo(cboIncotermsOrcamento, lblIncotermsOrcamento) = False Then
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoOrcamento = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoOrcamentoAlterarCampos() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoOrcamentoAlterarCampos = False

            'Verifica se foi Selecionado o Campo - Cotação
            If ValidaCampo(cboNumeroCotacaoOrcamento, lblNumeroCotacaoOrcamento) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Fornecedor
            If ValidaCampo(cboFornecedorOrcamento, lblFornecedorOrcamento) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoOrcamentoAlterarCampos = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub SalvarOrcamento()

        Try

            'Salva Dados do Orçamento
            Call oClsCmpCotacao.UpdateCotacaoFornecedorOrcamento(cboNumeroCotacaoOrcamento.SelectedValue,
                                                                 txtDescritivoOrcamento.Text.Trim,
                                                                 cboFornecedorOrcamento.SelectedValue,
                                                                 IIf(cboCondicaoPagamentoOrcamento.SelectedIndex = -1, -1, cboCondicaoPagamentoOrcamento.SelectedValue),
                                                                 IIf(cboFormaPagamentoOrcamento.SelectedIndex = -1, -1, cboFormaPagamentoOrcamento.SelectedValue),
                                                                 IIf(cboMoedaOrcamento.SelectedIndex = -1, -1, cboMoedaOrcamento.SelectedValue),
                                                                 txtFatorCambial.Value,
                                                                 IIf(cboModalidadeFreteOrcamento.SelectedIndex = -1, -1, cboModalidadeFreteOrcamento.SelectedValue),
                                                                 IIf(cboTransportadoraOrcamento.SelectedIndex = -1, -1, cboTransportadoraOrcamento.SelectedValue),
                                                                 txtValorFreteOrcamento.Value,
                                                                 IIf(cboModalidadeTransporteOrcamento.SelectedIndex = -1, -1, cboModalidadeTransporteOrcamento.SelectedValue),
                                                                 IIf(cboIncotermsOrcamento.SelectedIndex = -1, -1, cboIncotermsOrcamento.SelectedValue),
                                                                 IIf(cboAgenteLogisticoOrcamento.SelectedIndex = -1, -1, cboAgenteLogisticoOrcamento.SelectedValue),
                                                                 txtValorHonorario.Value,
                                                                 txtValorEstimadoCustoImportacao.Value,
                                                                 IIf(cboInstrucaoEmbarqueOrcamento.SelectedIndex = -1, -1, cboInstrucaoEmbarqueOrcamento.SelectedValue),
                                                                 IIf(dtpDataValidadeOrcamento.Checked = True, dtpDataValidadeOrcamento.Value, ""),
                                                                 txtObservacaoOrcamento.Text.Trim)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DesmembrarEntrega(ByVal oGrid As GridEX, _
                                  ByVal iTipoItem As TipoItem)

        Try

            'Váriavel - Form
            Dim oForm As New frmCmpCotacaoDesmembrarEntrega

            'Seta Parâmetros
            oForm.CodigoCotacao = cboNumeroCotacaoOrcamento.SelectedValue
            oForm.CodigoCotacaoFornecedor = cboFornecedorOrcamento.SelectedValue
            oForm.CodigoCotacaoItem = oGrid.CurrentRow.Cells("codigo_cotacao_item").Value
            oForm.Item = oGrid.CurrentRow.Cells("codigo_servico").Value & " - " & oGrid.CurrentRow.Cells("descricao").Value
            oForm.Quantidade = oGrid.CurrentRow.Cells("quantidade").Value
            oForm.DataEntrega = oGrid.CurrentRow.Cells("data_desmembrada").Value & "|" & oGrid.CurrentRow.Cells("quantidade_desmembrada").Value

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Grid
            Call oClsCmpCotacao.LoadGridCotacaoFornecedorOrcamentoItem(oGrid, _
                                                                       iTipoItem, _
                                                                       cboNumeroCotacaoOrcamento.SelectedValue, _
                                                                       cboFornecedorOrcamento.SelectedValue)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoOrcamentoProduto()

        Try

            'Váriavel - Form
            Dim oForm As New frmCmpCotacaoItemOrcamentoHistorico

            'Seta Parâmetros
            oForm.Codigo = grdOrcamentoProduto.CurrentRow.Cells("codigo_item").Value
            oForm.CodigoItem = grdOrcamentoProduto.CurrentRow.Cells("codigo_produto").Value
            oForm.Descricao = grdOrcamentoProduto.CurrentRow.Cells("descricao").Value

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoOrcamentoServico()

        Try

            'Váriavel - Form
            Dim oForm As New frmCmpCotacaoItemOrcamentoHistorico

            'Seta Parâmetros
            oForm.Codigo = grdOrcamentoServico.CurrentRow.Cells("codigo_item").Value
            oForm.CodigoItem = grdOrcamentoServico.CurrentRow.Cells("codigo_servico").Value
            oForm.Descricao = grdOrcamentoServico.CurrentRow.Cells("descricao").Value

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

#Region "::: APROVAÇÃO :::"

    Private Sub GraficoEvolucaoPreco()

        Try

            'Váriaveis Locais
            Dim sQuery As String
            Dim oGrafico As New Grafico

            'Seta Query
            sQuery = "EXECUTE sp_grafico_compras_evolucao_preco_produto " & grdAprovacao.CurrentRow.Cells("codigo_item").Value & ", " & goUsuario.iEmpresa

            'Seta Eixo X
            oGrafico.sX = "data"

            'Seta Propriedades do Gráfico
            ReDim oGrafico.oSeries(0)

            'Seta Propriedades da Série - Valor
            oGrafico.oSeries(0) = New Dundas.Charting.WinControl.Series
            oGrafico.oSeries(0).Name = "valor"
            oGrafico.oSeries(0).Color = Color.Blue
            oGrafico.oSeries(0).ShowInLegend = True
            oGrafico.oSeries(0).LegendText = "Valor"
            oGrafico.oSeries(0).Type = Dundas.Charting.WinControl.SeriesChartType.SplineArea
            oGrafico.oSeries(0).SmartLabels.Enabled = True

            'Abre Gráfico
            Dim oUsrControl As New usrChart
            oUsrControl.Dock = DockStyle.Fill
            oUsrControl.Query = sQuery
            oUsrControl.Title = "Evolução do Preço do Item: " & grdAprovacao.CurrentRow.Cells("codigo_produto_servico").Value & " - " & grdAprovacao.CurrentRow.Cells("descricao").Value
            oUsrControl.Grafico = oGrafico

            'Configura Mascara
            Call ConfigureMaskEdit(oUsrControl) : Call LoadControlesTraducao(oUsrControl)

            'Carrega Página
            Call frmMain.LoadPage("CHREvolucaoPrecoProduto", "Gráfico - Evolução do Preço do Item: " & grdAprovacao.CurrentRow.Cells("codigo_produto_servico").Value, oUsrControl)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub DeleteArquivo()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdArquivo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    oClsCmpCotacao.ExcluirArquivo(lCodigoCotacao)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário sobre a necessidade de Selecionar um ou mais Itenss
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoArquivo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            LimparCamposGroupBox(grpArquivo)
            btnInserirArquivo.Tag = ""

            txtTituloArquivo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoArquivo() As Boolean

        Try

            If ValidaCampo(txtTituloArquivo, lblTituloArquivo, TipoCampo.texto) = False Then Return False
            If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then Return False
            If ValidaCampo(cboFornecedorOrcamento, lblFornecedorOrcamento) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub SalvarArquivo()

        Try

            Cursor.Current = Cursors.WaitCursor

            Dim oFileInfo As New System.IO.FileInfo(txtArquivo.Text.Trim)
            Dim sCaminho As String = LoadCodigo("sp_load_pasta_arquivo_compras_cotacao " & goUsuario.iEmpresa)
            Dim sFile As String = sCaminho & Format(Now, "yy_MM_dd_hh_mm_ss_") & oFileInfo.Name

            System.IO.File.Copy(txtArquivo.Text.Trim, sFile)

            oClsCmpCotacao.InsertArquivo(lCodigoCotacao,
                                         txtTituloArquivo.Text.Trim,
                                         sFile,
                                         cboFornecedorOrcamento.SelectedValue)

            frmMain.Informacao(Mensagem.RegistroInserido)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridArquivo()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCmpCotacao.LoadGridArquivo(grdArquivo,
                                           lCodigoCotacao,
                                           cboFornecedorOrcamento.SelectedValue)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarDocumento(ByVal sArquivo As String)

        Try

            'Verifica se foi Informado o Arquivo
            If sArquivo = "" Then

                'Informa o Usuário que não foi Informado o Arquivo
                frmMain.Informacao(Mensagem.NaoFoiInformado, "Arquivo")

            Else

                'Verifica se o Arquivo Existe
                If File.Exists(sArquivo) Then
                    'Abre o Arquivo
                    Dim oProcess As New Process
                    oProcess.Start(sArquivo)
                Else
                    'Informa o Usuário que o Arquivo Informado não foi Localizado.
                    frmMain.Informacao(Mensagem.ObjetoNaoEncontrado, "Arquivo")
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

#End Region

End Class
