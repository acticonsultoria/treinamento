Imports Janus.Windows.EditControls
Imports Janus.Windows.UI.Tab
Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO

Public Class usrManOrdemServico

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsManOrdemServico As New clsUsrManOrdemServico

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrManOrdemServico_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrManOrdemServico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: ORDEM DE SERVIÇO :::"

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.ManutencaoOrdemServico
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ManutencaoOrdemServico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Cancelar Registros
            Call CancelarOrdemServico()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizar.Click

        Try

            'Finalizar Ordem de Serviço
            Call FinalizarOrdemServico()

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
            tabMain.TabPages.Add(pagDados)

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Focu
            dtpDataOrdemServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Focu        
            dtpDataOrdemServico.Focus()

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

                'Seta Controle
                btnImprimir.Enabled = VerificaDireito(Formulario.ManutencaoOrdemServico, gcPrint)

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

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            'Imprime Ordem de Serviço
            Call ImprimirOrdemServico(oClsManOrdemServico.CodigoOrdemServico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Verifica se não foi gerado a Ordem de Servi
            If txtNumeroOrdemServico.Text = "" And IsNumeric(btnSalvar.Tag) Then

                'Verifica se o usuário deseja sair da Ordem de Serviço
                If MsgBox("Os Dados da Ordem de Serviço serão perdidos. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    Exit Sub
                End If
                
            End If

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba        
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroOrdemServicoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoManutencao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoManutencao.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboTipoManutencao.SelectedIndex > -1 Then

                Select cboTipoManutencao.SelectedValue

                    Case CInt(TipoManutencao.Corretiva)
                        'Carrega Combo - Requisição
                        Call LoadCombo(cboNumeroRequisicao, "sp_select_combo_manutencao_requisicao " & goUsuario.iEmpresa)
                        cboNumeroRequisicao.Enabled = True                        
                        cboManutencao.DataSource = Nothing : cboManutencao.Text = "" : cboManutencao.Enabled = True

                    Case CInt(TipoManutencao.Preventiva)
                        'Carrega Combo - Manutenção
                        Call LoadCombo(cboManutencao, "sp_select_combo_manutencao_preventiva " & goUsuario.iEmpresa)
                        cboNumeroRequisicao.Enabled = False : cboNumeroRequisicao.DataSource = Nothing : cboNumeroRequisicao.Text = ""
                        cboManutencao.Enabled = True

                    Case CInt(TipoManutencao.Preditiva)
                        'Carrega Combo - Manutenção
                        Call LoadCombo(cboManutencao, "sp_select_combo_cadastro_basico_manutencao " & goUsuario.iEmpresa)
                        cboNumeroRequisicao.Enabled = False : cboNumeroRequisicao.DataSource = Nothing : cboNumeroRequisicao.Text = ""
                        cboManutencao.Enabled = True

                End Select

            Else
                'Limpa Controles
                cboNumeroRequisicao.Enabled = False : cboNumeroRequisicao.DataSource = Nothing : cboNumeroRequisicao.Text = ""
                cboManutencao.Enabled = False : cboManutencao.DataSource = Nothing : cboManutencao.Text = ""
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboNumeroRequisicao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNumeroRequisicao.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboNumeroRequisicao.SelectedIndex > -1 Then

                'Carrega Combo
                Call LoadCombo(cboManutencao, "sp_select_combo_manutencao_requisicao_manutencao " & cboNumeroRequisicao.SelectedValue & ", " & goUsuario.iEmpresa)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar(grdListagem.CurrentRow.Cells.Item("codigo_ordem_servico").Value)
                Case "imprimir" : Call ImprimirOrdemServico(grdListagem.CurrentRow.Cells.Item("codigo_ordem_servico").Value)
                Case "email" : Call EmailOrdemServico()

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
                                     Formulario.ManutencaoOrdemServico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ManutencaoOrdemServico, _
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
                                          Formulario.ManutencaoOrdemServico, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub tabDados_SelectedTabChanged(sender As Object, e As TabEventArgs) Handles tabDados.SelectedTabChanged

        Try

            Select Case e.Page.Key

                Case "pagApontamento"
                    btnInserirApontamento.Visible = True
                    btnExcluirApontamento.Visible = True

                Case Else
                    btnInserirApontamento.Visible = False
                    btnExcluirApontamento.Visible = False

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: APONTAMENTO :::"

    Private Sub btnAgruparGridApontamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridApontamento.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdApontamento.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdApontamento.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdApontamento.GroupByBoxVisible = True
                grdApontamento.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridApontamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridApontamento.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdApontamento
            oForm.NomeFormulario = Formulario.ManutencaoOrdemServico
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdApontamento, Formulario.ManutencaoOrdemServico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirApontamento_Click(sender As Object, e As EventArgs) Handles btnInserirApontamento.Click

        Try

            'Inserir Apontamento
            Call InserirApontamento()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirApontamento_Click(sender As Object, e As EventArgs) Handles btnExcluirApontamento.Click

        Try

            'Excluir Apontamento
            Call ExcluirApontamento()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdApontamento_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdApontamento.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdApontamento.CurrentColumn) Then Exit Sub

            Select Case grdApontamento.CurrentColumn.Key

                Case "imprimir" : Call ImprimirApontamento(grdApontamento.CurrentRow.Cells("codigo_ordem_servico").Value, grdApontamento.CurrentRow.Cells("codigo").Value)
                Case "email" : Call EmailApontamento(grdApontamento.CurrentRow.Cells("codigo_ordem_servico").Value, grdApontamento.CurrentRow.Cells("codigo").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdApontamento_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdApontamento.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdApontamento, _
                                     Formulario.ManutencaoOrdemServico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdApontamento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdApontamento.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdApontamento.Name, _
                                     Formulario.ManutencaoOrdemServico, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdApontamento_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdApontamento.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdApontamento.Name, _
                                          Formulario.ManutencaoOrdemServico, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub btnAgruparGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridProduto.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdProduto.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdProduto.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdProduto.GroupByBoxVisible = True
                grdProduto.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridProduto.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdProduto
            oForm.NomeFormulario = Formulario.ManutencaoOrdemServico
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdProduto, Formulario.ManutencaoOrdemServico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridProduto.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdProduto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto, _
                                     Formulario.ManutencaoOrdemServico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto.Name, _
                                     Formulario.ManutencaoOrdemServico, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdProduto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdProduto.Name, _
                                          Formulario.ManutencaoOrdemServico, _
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

#Region "::: ORDEM DE SERVIÇO :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrManOrdemServico_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.ManutencaoOrdemServico, gcDelete)
            btnNovo.Enabled = VerificaDireito(Formulario.ManutencaoOrdemServico, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.ManutencaoOrdemServico, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ManutencaoOrdemServico, gcPrint)
            btnExcelGridProduto.Enabled = VerificaDireito(Formulario.ManutencaoOrdemServico, gcPrint)
            btnExcelGridApontamento.Enabled = VerificaDireito(Formulario.ManutencaoOrdemServico, gcPrint)

            'Carrega ComboBox            
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_ordem_servico_manutencao")
            Call LoadCombo(cboTipoManutencaoFiltro, "sp_select_combo_static_tipo_manutencao")
            Call LoadCombo(cboTipoManutencao, "sp_select_combo_static_tipo_manutencao")
            Call LoadCombo(cboManutencaoFiltro, "sp_select_combo_cadastro_basico_manutencao " & goUsuario.iEmpresa)

            'Configura DateTimer
            dtpDataOrdemServicoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataOrdemServicoInicioFiltro.Checked = False
            dtpDataOrdemServicoTerminoFiltro.Value = Now.Date : dtpDataOrdemServicoTerminoFiltro.Checked = False
            dtpDataConclusaoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataConclusaoInicioFiltro.Checked = False
            dtpDataConclusaoTerminoFiltro.Value = Now.Date : dtpDataConclusaoTerminoFiltro.Checked = False

            'Seta Aba
            tabMain.TabPages.Remove(pagDados)

            'Verifica o Direito do Usuário - Serviço
            If VerificaDireito(Formulario.ManutencaoOrdemServicoApontamento, gcSelect) = True Then
                'Verifica Direito - Botão de Cadastro
                btnInserirApontamento.Enabled = VerificaDireito(Formulario.ManutencaoOrdemServicoApontamento, gcInsert)
                btnExcluirApontamento.Enabled = VerificaDireito(Formulario.ManutencaoOrdemServicoApontamento, gcDelete)
            Else
                'Oculta Aba
                tabDados.TabPages.Remove(pagApontamento)
            End If

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ManutencaoOrdemServico)
            Call ConfiguraGrid(grdProduto, Formulario.ManutencaoOrdemServico)
            Call ConfiguraGrid(grdApontamento, Formulario.ManutencaoOrdemServico)

            'Seta Focu
            txtNumeroOrdemServicoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Controles
            Call oClsManOrdemServico.LoadGridOrdemServico(grdListagem, _
                                                          txtNumeroOrdemServicoFiltro.Text.Trim, _
                                                          IIf(dtpDataOrdemServicoInicioFiltro.Checked = False, "", dtpDataOrdemServicoInicioFiltro.Value), _
                                                          IIf(dtpDataOrdemServicoTerminoFiltro.Checked = False, "", dtpDataOrdemServicoTerminoFiltro.Value), _
                                                          IIf(cboTipoManutencaoFiltro.SelectedIndex = -1, -1, cboTipoManutencaoFiltro.SelectedValue), _
                                                          txtNumeroRequisicaoFiltro.Text.Trim, _
                                                          IIf(dtpDataConclusaoInicioFiltro.Checked = False, "", dtpDataConclusaoInicioFiltro.Value), _
                                                          IIf(dtpDataConclusaoTerminoFiltro.Checked = False, "", dtpDataConclusaoTerminoFiltro.Value), _
                                                          IIf(cboManutencaoFiltro.SelectedIndex = -1, -1, cboManutencaoFiltro.SelectedValue), _
                                                          IIf(cboStatusFiltro.SelectedIndex = -1, -1, cboStatusFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar(ByVal lCodigoOrdemServico As Long)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ManutencaoOrdemServico, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                'Seta Código
                oClsManOrdemServico.CodigoOrdemServico = lCodigoOrdemServico
                'Seta Controle
                btnSalvar.Tag = lCodigoOrdemServico

                'Carrega Controles
                Call oClsManOrdemServico.Editar(lCodigoOrdemServico, _
                                                txtNumeroOrdemServico, _
                                                dtpDataOrdemServico, _
                                                cboTipoManutencao, _
                                                cboNumeroRequisicao, _
                                                cboManutencao, _
                                                txtObservacao)

                'Carrega Grid de Produto
                Call LoadGridProduto()

                'Carrega Grid de Apontamento
                Call LoadGridApontamento()

                'Seta Controle
                btnImprimir.Enabled = VerificaDireito(Formulario.ManutencaoOrdemServico, gcPrint)

                'Seta Aba
                If tabDados.TabPages.Contains(pagProduto) Then
                    tabDados.SelectedTab = pagProduto
                ElseIf tabDados.TabPages.Contains(pagApontamento) Then
                    tabDados.SelectedTab = pagApontamento
                Else
                    tabDados.SelectedTab = pagDadosGerais
                End If

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                dtpDataOrdemServico.Focus()

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

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Dados Gerais
            txtNumeroOrdemServico.Text = ""
            dtpDataOrdemServico.Value = Now.Date
            cboTipoManutencao.SelectedIndex = -1
            cboNumeroRequisicao.Text = ""
            cboManutencao.Text = ""
            txtObservacao.Text = ""
            btnSalvar.Tag = ""

            'Limpa Grid
            grdApontamento.DataSource = Nothing
            grdProduto.DataSource = Nothing

            'Habilita Controles
            btnSalvar.Enabled = VerificaDireito(Formulario.ManutencaoOrdemServico, gcInsert)
            btnImprimir.Enabled = False

            'Seta Aba
            If tabDados.TabPages.Contains(pagProduto) Then
                tabDados.SelectedTab = pagProduto
                'Oculta Controles
                btnInserirApontamento.Visible = False
                btnExcluirApontamento.Visible = False
            ElseIf tabDados.TabPages.Contains(pagApontamento) Then
                tabDados.SelectedTab = pagApontamento
                'Oculta Controles
                btnInserirApontamento.Visible = True
                btnExcluirApontamento.Visible = True
            Else
                tabDados.SelectedTab = pagDadosGerais
                'Oculta Controles
                btnInserirApontamento.Visible = False
                btnExcluirApontamento.Visible = False
            End If

            'Seta Valor Default
            Call ConfigureValorDefault(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim iCodigoManutencao As Integer

            Select Case cboTipoManutencao.SelectedValue
                Case TipoManutencao.Corretiva : iCodigoManutencao = LoadCodigo("sp_select_manutencao_requisicao_manutencao_codigo " & cboNumeroRequisicao.SelectedValue & ", " & goUsuario.iEmpresa & ", " & cboManutencao.SelectedValue)
                Case TipoManutencao.Preditiva : iCodigoManutencao = cboManutencao.SelectedValue
                Case TipoManutencao.Preventiva : iCodigoManutencao = LoadCodigo("sp_select_manutencao_preventiva_manutencao_codigo " & goUsuario.iEmpresa & ", " & cboManutencao.SelectedValue)
            End Select
            

            'Seta Parametros
            oClsManOrdemServico.CodigoOrdemServico = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsManOrdemServico.DataOrdemServico = dtpDataOrdemServico.Value
            oClsManOrdemServico.CodigoTipoManutencao = cboTipoManutencao.SelectedValue
            oClsManOrdemServico.CodigoRequisicao = IIf(cboNumeroRequisicao.Enabled = True, cboNumeroRequisicao.SelectedValue, -1)
            oClsManOrdemServico.CodigoRequisicaoManutencao = IIf(cboNumeroRequisicao.Enabled = True, cboManutencao.SelectedValue, -1)
            oClsManOrdemServico.CodigoManutencao = iCodigoManutencao
            oClsManOrdemServico.CodigoManutencaoPreventiva = IIf(cboTipoManutencao.SelectedValue = TipoManutencao.Preventiva, cboManutencao.SelectedValue, -1)
            oClsManOrdemServico.Observacao = txtObservacao.Text.Trim

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) = False Then
                'Insere Registro
                oClsManOrdemServico.Insert()
                btnSalvar.Tag = oClsManOrdemServico.CodigoOrdemServico
                txtNumeroOrdemServico.Text = oClsManOrdemServico.NumeroOrdemServico
            Else
                'Atualiza Registro
                oClsManOrdemServico.Update()
            End If

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsManOrdemServico.Delete()
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

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Tipo Manutenção
            If ValidaCampo(cboTipoManutencao, lblTipoManutencao) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Nº Requisição
            If cboNumeroRequisicao.Enabled = True Then
                If ValidaCampo(cboNumeroRequisicao, lblNumeroRequisicao) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Serviço
            If ValidaCampo(cboManutencao, lblManutencao) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub CancelarOrdemServico()

        Try

            'Verifica se o usuário tem direito de Cancelar algum registro
            If VerificaDireito(Formulario.ManutencaoOrdemServico, gcAdministrator) = True Then

                'Verifica se a Ordem de Serviço pode ser Cancelado
                If VerificaSelecaoRow(grdListagem, "status", StatusOrdemServicoManutencao.EmAndamento) = True Then

                    'Váriaveis Locais
                    Dim oForm As New frmManOrdemServicoCancelar
                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)
                    'Carrega a Grid
                    Call LoadGrid()

                Else
                    'Informa o Usuário que a Ordem de Serviço não pode ser Cancelado
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

    Private Sub FinalizarOrdemServico()

        Try

            'Verifica se o usuário tem direito de Cancelar algum registro
            If VerificaDireito(Formulario.ManutencaoOrdemServico, gcAdministrator) = True Then

                'Verifica se a Ordem de Serviço pode ser Cancelado
                If VerificaSelecaoRow(grdListagem, "status", StatusOrdemServicoManutencao.EmAndamento) = True Then


                    'Verifica se o Usuário Deseja Finalizar as Ordens de Serviço
                    If MsgBox("Deseja Finalizar a(s) Ordem(ns) de Serviço(s) Selecionada(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                        'Atualiza Status
                        Call oClsManOrdemServico.AlterarStatus("Ordem de Serviço Finalizada.", StatusOrdemServicoManutencao.Concluido)

                    End If

                    'Carrega a Grid
                    Call LoadGrid()

                Else
                    'Informa o Usuário que a Ordem de Serviço não pode ser Cancelado
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

    Private Sub EmailOrdemServico()

        Try

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Abre Relatório
            oRptDocument.Load(goCrystalReport.sPath & "SRV000000001.rpt", _
                              CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Seta Parametros Relatório
            oRptDocument.SetParameterValue("@codigo_ordem_servico", grdListagem.CurrentRow.Cells("codigo_ordem_servico").Value)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
            oRptDocument.SetParameterValue("usuario", goUsuario.sNome)

            'Abre Conexão com o Banco de Dados
            For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            'Verifica se Pasta Existe
            If Directory.Exists(ApplicationPath() & "File\") = False Then Directory.CreateDirectory(ApplicationPath() & "File")

            'Arquivo
            Dim sArquivo As String = ApplicationPath() & "File\" & grdListagem.CurrentRow.Cells("numero_ordem_servico").Value.ToString.Replace("/", "-").Replace("\", "-") & ".pdf"

            'Exclui Arquivo caso exista
            If File.Exists(sArquivo) = True Then File.Delete(sArquivo)

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                      sArquivo)

            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'LoadContatoOrdemServico(grdListagem.CurrentRow.Cells("codigo_ordem_servico").Value), _
            'Enviar E-mail
            Call EnviarEmail("Ordem de Serviço " & grdListagem.CurrentRow.Cells("numero_ordem_servico").Value, _
                             "", _
                             sArquivo, _
                             sArquivo, _
                             "", _
                             grdListagem.CurrentRow.Cells("codigo_cliente").Value)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirOrdemServico(ByVal lCodigoOrdemServico As Long)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(2)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_ordem_servico"
            goCrystalReport.sReportParameter(1).sValue = lCodigoOrdemServico
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & "SRV000000001.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("SRV000000001", "Ordem de Serviço", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function VerificaSelecaoRowCancelar(ByVal oGrid As GridEX) As Boolean

        Try

            'Variáveis Loais
            Dim oRow As GridEXRow

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            'Seta Retorno da Função
            VerificaSelecaoRowCancelar = False

            With oGrid

                'Verifica se foi selecionado algum registro para salvar
                If .GetCheckedRows.Length > 0 Then

                    'Varrendo os itens selecionados
                    For Each oRow In .GetCheckedRows

                        'Verifica se a Ordem de Serviço é Válido
                        If ((oRow.Cells("valor_ordem_servico").Value - oRow.Cells("valor_cancelado").Value) > 0) Then

                            'Redimensiona Vetor caso necessário
                            If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                                ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                            End If

                            'Seta Retorno da Função
                            VerificaSelecaoRowCancelar = True

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

#Region "::: PRODUTO :::"

    Private Sub LoadGridProduto()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid de Item
            Call oClsManOrdemServico.LoadGridProduto(grdProduto, btnSalvar.Tag)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: APONTAMENTO :::"

    Private Sub ExcluirApontamento()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdApontamento) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Váriaveis Locais
                    Dim oClsManApontamento As New clsUsrManApontamento

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsManApontamento.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InserirApontamento()

        Try

            'Váriavel - Formulário
            Dim oForm As New frmCadBasico
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.UsrControl = "usrManApontamento"
            oForm.Titulo = Me.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo            
            Call LoadGridApontamento()

            'Seta Focu
            btnInserirApontamento.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridApontamento()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim oClsManApontamento As New clsUsrManApontamento

            'Carrega Grid de Apontamento
            oClsManApontamento.LoadGrid(grdApontamento, btnSalvar.Tag)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EmailApontamento(ByVal lCodigoOrdemServico As Long, _
                                 ByVal iCodigoApontamento As Integer)

        Try

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Relatório
            Dim sReport As String = "SRV000000002.rpt"

            'Abre Relatório
            oRptDocument.Load(goCrystalReport.sPath & sReport, _
                              CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Seta Parametros Relatório
            oRptDocument.SetParameterValue("@codigo_ordem_servico", lCodigoOrdemServico)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
            oRptDocument.SetParameterValue("@codigo", iCodigoApontamento)
            oRptDocument.SetParameterValue("usuario", goUsuario.sNome)

            'Abre Conexão com o Banco de Dados
            For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            'Arquivo
            Dim sArquivo As String = System.IO.Path.GetTempPath
            sArquivo &= txtNumeroOrdemServico.ToString.Replace("/", "-").Replace("\", "-") & ".pdf"

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                      sArquivo)

            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Enviar E-mail
            Call EnviarEmail("Relatório de Vista Técnica: " & txtNumeroOrdemServico.Text.Trim, _
                             "", _
                             sArquivo, _
                             sArquivo, _
                             "", _
                             -1)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirApontamento(ByVal lCodigoOrdemServico As Long, _
                                    ByVal iCodigoApontamento As Integer)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Relatório
            Dim sReport As String = "SRV000000002.rpt"

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(3)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_ordem_servico"
            goCrystalReport.sReportParameter(1).sValue = lCodigoOrdemServico
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
            goCrystalReport.sReportParameter(3).sParamenter = "@codigo"
            goCrystalReport.sReportParameter(3).sValue = iCodigoApontamento
            goCrystalReport.sReport = goCrystalReport.sPath & sReport

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("SRV000000001", "Relatório de Visita Técnica", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class