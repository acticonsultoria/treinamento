Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports CrystalDecisions.CrystalReports.Engine

Public Class usrPrdOrdemProducao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsPrdOrdemProducao As New clsUsrPrdOrdemProducao
    Public bEditar As Boolean = False
#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrPrdOrdemProducao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)
                    
                Case Keys.F5
                    Select Case sender.name
                        Case "cboCentroTrabalhoFiltro" : Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)
                        Case "cboGrupoItemFiltro" : Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrPrdOrdemProducao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: ORDEM DE PRODUÇÃO :::"

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Try
            If ValidaRequisicao() = True Then

                Excluir()

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Function ValidaRequisicao() As Boolean

        Try

            'Seta Retorno da Função
            ValidaRequisicao = False

            For Each oRow In grdListagem.GetCheckedRows
                If oClsPrdOrdemProducao.ValidaRequisicao(grdListagem.CurrentRow.Cells.Item("codigo").Value) = False Then
                    MsgBox("Não é possivel excluir a ordem de produção " + grdListagem.CurrentRow.Cells.Item("ordem_producao").Value + " pois a Requisição " + oClsPrdOrdemProducao.Requisicao + " está vinculada a ela", vbExclamation, "Validação")
                    Exit Function
                End If

            Next

            'Seta Retorno da Função
            ValidaRequisicao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub btnInserirRoteiro_Click(sender As Object, e As EventArgs) Handles btnInserirRoteiro.Click

        Try
            Call InserirOperacao()
            txtSequencia.Text = 0
            cboCentroTrabalho.SelectedIndex = -1
            cboOperacao.SelectedIndex = -1
            txtObservacaoOPNova.Text = ""
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirRoteiro_Click(sender As Object, e As EventArgs) Handles btnExcluirRoteiro.Click
        Try
            Call ExcluirOperacao()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub UiButton2_Click(sender As Object, e As EventArgs) Handles UiButton2.Click
        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagNova)
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtOrdemProducaoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub



    Private Sub btnImportarExcel_Click(sender As Object, e As EventArgs) Handles btnImportarExcel.Click
        Try
            'Váriaveis Locais
            Dim oForm As New frmPrdOrdemProducaoImportarExcel

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub cboCentroTrabalho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCentroTrabalho.SelectedIndexChanged
        Try

            'Verifica se foi Selecionado algum Centro de Trabalho
            If cboCentroTrabalho.SelectedIndex = -1 Then
                'Limpa Controle
                Exit Sub
            Else
                'Carrega Combo
                Call LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_operacao " & cboCentroTrabalho.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadastrarOperacao_Click(sender As Object, e As EventArgs) Handles btnCadastrarOperacao.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadOperacao")

            If cboCentroTrabalho.SelectedIndex = -1 Then
                Exit Sub
            Else
                Call LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_operacao " & cboCentroTrabalho.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

            'Seta Focu
            cboOperacao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadastrarCentroTrabalho_Click(sender As Object, e As EventArgs) Handles btnCadastrarCentroTrabalho.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroTrabalho")

            'Carrega Combo
            Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroTrabalho.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub UiButton1_Click(sender As Object, e As EventArgs) Handles btnSalvarOPNova.Click
        Try
            If bEditar = False Then
                Call InserirOP()
            Else
                Call AtualizarOP()
                Call InserirApontamento()
            End If

            Call Nova()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

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
            oForm.NomeFormulario = Formulario.ProducaoOrdemProducao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ProducaoOrdemProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(sender As Object, e As EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridMO_Click(sender As Object, e As EventArgs) Handles btnExcelGridMO.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdCustoMO)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridMP_Click(sender As Object, e As EventArgs) Handles btnExcelGridMP.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdCustoMP)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimirCertificado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirCertificado.Click

        Try

            'Imprime Certificado
            Call ImprimirCertificado()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimirOrdemProducao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirOrdemProducao.Click

        Try

            'Imprime Ordem de Produção
            Call ImprimirVariasOrdemProducao()

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

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click

        Try

            'Atualiza Dados da Ordem de Produção
            Call AtualizarOrdemProducao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Salva Observação
            oClsPrdOrdemProducao.Salvar(txtOrdemProducao.Tag, _
                                        txtObservacao.Text.Trim)

            'Salva Apontamento
            oClsPrdOrdemProducao.SalvarApontamento(txtOrdemProducao.Tag, _
                                                   grdApontamento)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

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
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Remove(pagNova)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtOrdemProducaoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "view" : VisualizarOrdemProducao()
                Case "cancelar" : CancelarOrdemProducao()
                Case "quebra_ordem_producao" : DividirOrdemProducao()
                Case "ativar" : AtivarOrdemProducao()
                Case "historico" : HistoricoOrdemProducao()
                Case "imprimir" : ImprimirOrdemProducao()
                Case "email" : EmailOrdemProducao()
                Case "editar" : EditarOrdemProducao()
                Case "atualizar_pedido" : AtualizarPedido()
                Case "itens_bom" : ItensBom(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "reativar" : ReativarOrdemProducao()


            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.ProducaoOrdemProducao)

            'Carrega Combo


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ProducaoOrdemProducao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging, grdApontamento.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name,
                                          Formulario.ProducaoOrdemProducao,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellUpdated

        Try

            'Verifica se a Coluna é a Data de Aceite
            If e.Column.Key = "data_necessidade" Then

                'Váriaveis - Query
                Dim sQuery As String

                sQuery = "sp_update_interacti_table_field "
                sQuery &= "'tb_prd_ordem_producao', "
                sQuery &= "'data_necessidade', "
                If IsDBNull(grdListagem.GetValue("data_necessidade")) = False AndAlso IsDate(grdListagem.GetValue("data_necessidade")) Then
                    sQuery &= "'''" & grdListagem.GetValue("data_necessidade") & "''',"
                Else
                    sQuery &= "'NULL',"
                End If
                sQuery &= "'WHERE (((codigo) = " & grdListagem.GetValue("codigo") & "))'"

                'Atualiza Registro
                Call ExecuteQuery(sQuery)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: APONTAMENTO :::"
    Private Sub cboCodigoProdutoNova_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCodigoProdutoNova.SelectedIndexChanged
        Try
            If cboCodigoProdutoNova.SelectedIndex = -1 Then
                Exit Sub
            End If

            txtDescricaoNova.Text = LoadCodigo("sp_select_cadastro_basico_descricao_item " & cboCodigoProdutoNova.SelectedValue & ", " & goUsuario.iEmpresa)

            If bEditar = False Then
                If cboCodigoProdutoNova.Text.Contains("PF") Then
                    oClsPrdOrdemProducao.LoadGridRoteiroPadrao(grdRoteiro, 2)
                End If
                If cboCodigoProdutoNova.Text.Contains("CO") Then
                    oClsPrdOrdemProducao.LoadGridRoteiroPadrao(grdRoteiro, 1)
                End If
            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnGerarOrdemProducao_Click(sender As Object, e As EventArgs) Handles btnGerarOrdemProducao.Click
        Try
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagNova)
            grpOPNova.Enabled = True
            bEditar = False
            Call GerarNova()



        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

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
            oForm.NomeFormulario = Formulario.ProducaoOrdemProducao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdApontamento, Formulario.ProducaoOrdemProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColunaApontamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColunaApontamento.SelectedIndexChanged

        Try

            If cboCongelarColunaApontamento.SelectedIndex = -1 Then
                grdApontamento.FrozenColumns = 2
            Else
                grdApontamento.FrozenColumns = cboCongelarColunaApontamento.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdApontamento_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdApontamento.RowDoubleClick

        Try

            'Verifica se foi pressionado algum Registro
            If IsNothing(grdApontamento.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdApontamento.CurrentColumn.Key

                Case "finalizar_apontamento" : Call FinalizarApontamento()
                Case "apontamento" : Call ApontamentoManual()
                Case "tempo_parada" : Call EditarTempoParada()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdApontamento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdApontamento.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdApontamento.Name, _
                                     Formulario.ProducaoOrdemProducao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdApontamento_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdApontamento.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdApontamento, _
                                     Formulario.ProducaoOrdemProducao)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColunaApontamento, grdApontamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdApontamento_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdApontamento.CellValueChanged

        Try

            Select Case grdApontamento.CurrentColumn.Key

                Case "data_inicio"
                    If IsDate(grdApontamento.GetValue("data_inicio")) Then
                        If IsDate(grdApontamento.GetValue("data_termino")) AndAlso grdApontamento.GetValue("data_inicio") > grdApontamento.GetValue("data_termino") Then
                            grdApontamento.SetValue("data_inicio", grdApontamento.GetValue("data_termino"))
                        End If
                    End If

                Case "data_termino"
                    If IsDate(grdApontamento.GetValue("data_termino")) Then
                        If grdApontamento.GetValue("data_inicio") > grdApontamento.GetValue("data_termino") Then
                            grdApontamento.SetValue("data_termino", grdApontamento.GetValue("data_inicio"))
                        End If
                    End If

            End Select

            If IsDate(grdApontamento.GetValue("data_inicio")) And IsDate(grdApontamento.GetValue("data_termino")) Then
                grdApontamento.SetValue("tempo_efetuado", grdApontamento.GetValue("data_termino") - grdApontamento.GetValue("data_inicio"))
            End If

            grdApontamento.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub tabDados_SelectedTabChanged(sender As Object, e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabDados.SelectedTabChanged

        Try

            Select Case tabDados.SelectedTab.Key

                Case "pagApontamento" : lblCongelarColunaApontamento.Visible = True : cboCongelarColunaApontamento.Visible = True
                Case "pagCusto" : lblCongelarColunaApontamento.Visible = False : cboCongelarColunaApontamento.Visible = False

            End Select

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrPrdOrdemProducao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            Call LoadCombo(cboCentroTrabalhoFiltro, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)
            Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_ordem_producao")
            Call LoadCombo(cboCodigoProdutoNova, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", 1, NULL, " & CInt(TipoItem.produto))
            Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboOrdemProducaoOriginal, "sp_select_combo_producao_ordem_producao " & goUsuario.iEmpresa)
            'Configura Direito
            btnImprimirCertificado.Enabled = VerificaDireito(Formulario.ProducaoOrdemProducao, gcPrint)
            btnImprimirOrdemProducao.Enabled = VerificaDireito(Formulario.ProducaoOrdemProducao, gcPrint)

            'Seta Controles
            dtpDataInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ProducaoOrdemProducao)
            Call ConfiguraGrid(grdApontamento, Formulario.ProducaoOrdemProducao)
            Call ConfiguraGrid(grdCustoMO, Formulario.ProducaoOrdemProducao)
            Call ConfiguraGrid(grdCustoMP, Formulario.ProducaoOrdemProducao)

            'Seta Direito
            grdApontamento.EditMode = IIf(VerificaDireito(Formulario.ProducaoApontamento, gcAdministrator) = True, Janus.Windows.GridEX.EditMode.EditOn, Janus.Windows.GridEX.EditMode.EditOff)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Remove(pagNova)


            'Seta Focu
            txtOrdemProducaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ORDEM DE PRODUÇÃO :::"

#Region "::: ORDEM DE PRODUÇÃO :::"

    Private Sub Excluir()
        Try

            If grdListagem.GetCheckedRows.Count = 0 Then

                frmMain.Informacao(Mensagem.ValidacaoSelecionar)

                Exit Sub

            End If

            'Questiona o usuario
            If MsgBox("Deseja excluir os registros selecionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") = vbNo Then Exit Sub

            'Exclui os itens
            oClsPrdOrdemProducao.Delete(grdListagem)

            'Carrega novamente
            LoadGrid()

            'Informa o usuário
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InserirOP()
        Try

            If ValidacaoOP() = True Then

                If CStr(btnSalvarOPNova.Tag) = "" Then
                    oClsPrdOrdemProducao.Insert(txtNumeroOPNova.Tag, _
                                                cboCodigoProdutoNova.SelectedValue, _
                                                cboCodigoProdutoNova.Text, _
                                                txtDescricaoNova.Text, _
                                                txtQtdPlanejadaNova.Text, _
                                                dtpDataNecessidade.Text, _
                                                txtObservacaoOPNova.Text, _
                                                IIf(cboOrdemProducaoOriginal.SelectedIndex = -1, -1, cboOrdemProducaoOriginal.SelectedValue), _
                                                "", _
                                                "", _
                                                "", _
                                                "")

                    btnSalvarOPNova.Tag = oClsPrdOrdemProducao.CodigoOrdemProducao
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AtualizarOP()
        Try

            'If ValidacaoLocalizacao() = True Then

            '    oClsPrdOrdemProducao.UpdateLocalizacao("", _
            '                                           btnSalvarOPNova.Tag)

            'End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis locais
            Dim sStatus As String = ""
            Dim sCodigoGrupoItem As String = ""
            Dim i As Integer

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Grupo de Item
            If cboGrupoItemFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboGrupoItemFiltro.CheckedValues)
                    sCodigoGrupoItem &= IIf(sCodigoGrupoItem = "", "", ",") & cboGrupoItemFiltro.CheckedValues(i).ToString
                Next
            End If

            'Seta Parametros
            oClsPrdOrdemProducao.LoadGrid(grdListagem, _
                                          IIf(IsNumeric(txtOrdemProducaoFiltro.Text), txtOrdemProducaoFiltro.Text, -1), _
                                          IIf(cboCentroTrabalhoFiltro.SelectedIndex = -1, -1, cboCentroTrabalhoFiltro.SelectedValue), _
                                          IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                          IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""), _
                                          IIf(IsNumeric(txtPedidoVendaFiltro.Text.Replace(goUsuario.sSiglaEmpresa, "")), txtPedidoVendaFiltro.Text.Replace(goUsuario.sSiglaEmpresa, ""), -1), _
                                          txtCodigoProdutoFiltro.Text.Trim, _
                                          sStatus, _
                                          sCodigoGrupoItem)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizarOrdemProducao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call oClsPrdOrdemProducao.LoadGridApontamento(grdApontamento, _
                                                          grdListagem.CurrentRow.Cells("codigo").Value)

            'Carrega Grid - Custo M.P.
            Call oClsPrdOrdemProducao.LoadGridCustoMP(grdCustoMP, _
                                                      grdListagem.CurrentRow.Cells("codigo").Value)

            'Carrega Grid - Custo M.O.
            Call oClsPrdOrdemProducao.LoadGridCustoMO(grdCustoMO, _
                                                      grdListagem.CurrentRow.Cells("codigo").Value)

            Dim dCustoMO As Double = 0
            Dim dCustoMP As Double = 0

            If grdCustoMO.GetDataRows.Count > 0 Then dCustoMO = grdCustoMO.GetTotalRow.Cells("custo").Value
            If grdCustoMP.GetDataRows.Count > 0 Then dCustoMP = grdCustoMP.GetTotalRow.Cells("valor_total").Value

            'Carrega Gráfico de Custo
            Call oClsPrdOrdemProducao.LoadGraficoCusto(chrCusto, _
                                                       dCustoMO, _
                                                       dCustoMP)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarOrdemProducao()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.ProducaoOrdemProducao, gcUpdate) = True Then

                bEditar = True
                txtNumeroOPNova.Enabled = False
                dtpDataNecessidade.Enabled = False
                cboCodigoProdutoNova.Enabled = False
                txtQtdPlanejadaNova.Enabled = False
                cboOrdemProducaoOriginal.Enabled = False
                btnProcurarProduto.Enabled = False
                btnCadastrarProduto.Enabled = False
                txtDescricaoNova.Enabled = False

                'Carrega Controles
                txtNumeroOPNova.Text = grdListagem.CurrentRow.Cells("ordem_producao").Value
                btnSalvarOPNova.Tag = grdListagem.CurrentRow.Cells("codigo").Value
                dtpDataNecessidade.Value = IIf(IsDBNull(grdListagem.CurrentRow.Cells("data_necessidade").Value), Now.Date, grdListagem.CurrentRow.Cells("data_necessidade").Value)
                cboCodigoProdutoNova.SelectedValue = grdListagem.CurrentRow.Cells("codigo_item").Value
                txtQtdPlanejadaNova.Value = grdListagem.CurrentRow.Cells("quantidade_planejada").Value
                cboOrdemProducaoOriginal.SelectedValue = grdListagem.CurrentRow.Cells("codigo_ordem_producao_original").Value


                Call oClsPrdOrdemProducao.LoadGridApontamento(grdRoteiro, _
                                                              grdListagem.CurrentRow.Cells("codigo").Value)

                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Remove(pagDados)
                tabMain.TabPages.Add(pagNova)

                Call LoadGrid()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarOrdemProducao()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.ProducaoOrdemProducao, gcUpdate) = True Then

                'Carrega Controles
                txtOrdemProducao.Text = grdListagem.CurrentRow.Cells("ordem_producao").Value
                txtOrdemProducao.Tag = grdListagem.CurrentRow.Cells("codigo").Value
                txtProduto.Text = grdListagem.CurrentRow.Cells("codigo_produto").Value & " - " & grdListagem.CurrentRow.Cells("descricao").Value
                txtOrdemProducaoOriginal.Text = IIf(IsDBNull(grdListagem.CurrentRow.Cells("data_inicio").Value), "", grdListagem.CurrentRow.Cells("data_inicio").Value)
                txtTempoEstimado.Text = IIf(IsDBNull(grdListagem.CurrentRow.Cells("tempo_estimado_conclusao").Value), "", grdListagem.CurrentRow.Cells("tempo_estimado_conclusao").Value)
                txtPercentualConcluido.Text = FormatNumber(IIf(IsDBNull(grdListagem.CurrentRow.Cells("percentual_concluido").Value), 0.0, grdListagem.CurrentRow.Cells("percentual_concluido").Value), 2, Microsoft.VisualBasic.TriState.True)
                txtQuantidadePlanejada.Text = IIf(IsDBNull(grdListagem.CurrentRow.Cells("quantidade_planejada").Value), "", grdListagem.CurrentRow.Cells("quantidade_planejada").Value)
                txtQuantidadeRejeito.Text = IIf(IsDBNull(grdListagem.CurrentRow.Cells("quantidade_rejeito").Value), "", grdListagem.CurrentRow.Cells("quantidade_rejeito").Value)
                txtQuantidadeProduzida.Text = IIf(IsDBNull(grdListagem.CurrentRow.Cells("quantidade_produzida").Value), "", grdListagem.CurrentRow.Cells("quantidade_produzida").Value)
                txtObservacao.Text = grdListagem.CurrentRow.Cells("observacao").Value

                'Carrega Grid
                Call oClsPrdOrdemProducao.LoadGridApontamento(grdApontamento, _
                                                              grdListagem.CurrentRow.Cells("codigo").Value)

                'Carrega Grid - Custo M.P.
                Call oClsPrdOrdemProducao.LoadGridCustoMP(grdCustoMP, _
                                                          grdListagem.CurrentRow.Cells("codigo").Value)

                'Carrega Grid - Custo M.O.
                Call oClsPrdOrdemProducao.LoadGridCustoMO(grdCustoMO, _
                                                          grdListagem.CurrentRow.Cells("codigo").Value)

                Dim dCustoMO As Double = 0
                Dim dCustoMP As Double = 0

                If grdCustoMO.GetDataRows.Count > 0 Then dCustoMO = grdCustoMO.GetTotalRow.Cells("custo").Value
                If grdCustoMP.GetDataRows.Count > 0 Then dCustoMP = grdCustoMP.GetTotalRow.Cells("valor_total").Value

                'Carrega Gráfico de Custo
                Call oClsPrdOrdemProducao.LoadGraficoCusto(chrCusto, _
                                                           dCustoMO, _
                                                           dCustoMP)

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Remove(pagNova)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                btnVoltar.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DividirOrdemProducao()

        Try

            'Verifica se o usuário tem direito de Cancelar algum registro
            If VerificaDireito(Formulario.ProducaoOrdemProducao, gcAdministrator) = True Then

                'Váriaveis Locais
                Dim oForm As New frmPrdOrdemProducaoQuebra

                'Seta Parametros
                oForm.NumeroOrdemProducao = grdListagem.CurrentRow.Cells("ordem_producao").Value
                oForm.Produto = grdListagem.CurrentRow.Cells("codigo_produto").Value & " - " & grdListagem.CurrentRow.Cells("descricao").Value
                oForm.QuantidadePlanejada = grdListagem.CurrentRow.Cells("quantidade_planejada").Value
                oForm.QuantidadeProduzida = IIf(IsDBNull(grdListagem.CurrentRow.Cells("quantidade_produzida").Value), 0, grdListagem.CurrentRow.Cells("quantidade_produzida").Value)
                oForm.QuantidadeRejeito = IIf(IsDBNull(grdListagem.CurrentRow.Cells("quantidade_rejeito").Value), 0, grdListagem.CurrentRow.Cells("quantidade_rejeito").Value)
                oForm.CodigoOrdemProducao = grdListagem.CurrentRow.Cells("codigo").Value

                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Carrega a Grid
                Call LoadGrid()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CancelarOrdemProducao()

        Try

            'Verifica se já foi Pago a Requisição do Estoque
            If grdListagem.CurrentRow.Cells("quantidade_requisicao_paga").Value = 0 Then

                'Verifica se o usuário tem direito de Cancelar algum registro
                If VerificaDireito(Formulario.ProducaoOrdemProducao, gcAdministrator) = True Then

                    'Váriaveis Locais
                    Dim oForm As New frmPrdOrdemProducaoCancelar

                    'Seta Parametros
                    oForm.Grid = grdListagem
                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                    'Carrega a Grid
                    Call LoadGrid()

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.DireitoAdministrador)
                End If

            Else
                'Informa o Usuário que a Ordem de Produção não pode ser Cancelada
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Foi Pago a Requisição proveniente a esta Ordem de Produção.")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ReativarOrdemProducao()

        Try

            'Verifica se a OP está cancelada
            If grdListagem.CurrentRow.Cells("status").Value = 4 Then

                'Verifica se o usuário tem direito de Reativar algum registro
                If VerificaDireito(Formulario.ProducaoOrdemProducao, gcAdministrator) = True Then

                    'Váriaveis Locais
                    Dim oForm As New frmPrdOrdemProducaoReativar

                    'Seta Parametros
                    oForm.Grid = grdListagem
                    oForm.ShowDialog()

                    'Carrega a Grid
                    LoadGrid()

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.DireitoAdministrador)
                End If

            Else
                'Informa o Usuário que a Ordem de Produção não pode ser Cancelada
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Esta Ordem de Produção não está cancelada.")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoAtualizarPedido() As Boolean

        Try

            If grdListagem.CurrentRow.Cells("status").Value = StatusOrdemProducao.Cancelado Then
                MsgBox("Não é possível alterar uma OP Cancelada!", MsgBoxStyle.Exclamation, "Validação")
                Return False
            End If

            If grdListagem.CurrentRow.Cells("status").Value = StatusOrdemProducao.Concluido Then
                MsgBox("Não é possível alterar uma OP finalizada!", MsgBoxStyle.Exclamation, "Validação")
                Return False
            End If

            If IsDBNull(grdListagem.CurrentRow.Cells("codigo_pedido").Value) = False Then
                MsgBox("Essa OP já possui um pedido de venda relacionado!", MsgBoxStyle.Exclamation, "Validação")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub AtualizarPedido()

        Try

            If ValidacaoAtualizarPedido() = False Then Exit Sub

            'Verifica se o usuário tem direito de Administrador
            If VerificaDireito(Formulario.ProducaoOrdemProducao, gcAdministrator) = True Then

                Dim oForm As New frmPrdOrdemProducaoPedidoVenda
                oForm.CodigoOrdemProducao = grdListagem.CurrentRow.Cells("codigo").Value

                oForm.ShowDialog()

                LoadGrid()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtivarOrdemProducao()

        Try

            'Verifica o status do Orçamento
            If grdListagem.CurrentRow.Cells("status").Value = StatusOrdemProducao.Cancelado Then

                'Verifica se o usuário tem direito de Administrador
                If VerificaDireito(Formulario.ComercialOrcamento, gcAdministrator) = True Then

                    'Verifica se o Usuário deseja Retornar o Status da Ordem de Produção
                    If MsgBox("Deseja tornar ativo a Ordem de Produção: " & grdListagem.CurrentRow.Cells("ordem_producao").Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                        'Ativa Orçamento
                        oClsPrdOrdemProducao.AtivarOrdemProducao(grdListagem.CurrentRow.Cells("codigo").Value)
                        'Carrega a Grid
                        Call LoadGrid()

                    End If

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.DireitoAdministrador)
                End If

            Else
                'Informa o Usuário que a Ordem de Produção não pode ser Ativada
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoOrdemProducao()

        Try

            'Váriaveis Locais
            Dim oForm As New frmPrdOrdemProducaoHistorico

            'Seta Parametros
            oForm.Grid = grdListagem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EmailOrdemProducao()

        Try

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Abre Relatório
            oRptDocument.Load(goCrystalReport.sPath & "PRD000000001.rpt", _
                              CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Seta Parametros Relatório
            oRptDocument.SetParameterValue("@codigo", grdListagem.CurrentRow.Cells("codigo").Value)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
            oRptDocument.SetParameterValue("usuario", goUsuario.sNome)

            'Abre Conexão com o Banco de Dados
            For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                      ApplicationPath() & "File\ORDEM_PRODUCAO_" & grdListagem.CurrentRow.Cells("ordem_producao").Value & "_" & Format(Now, "yyyyMMdd_hhmm") & ".pdf")

            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Enviar E-mail
            Call EnviarEmail(goUsuario.sEmpresa & " - Ordem de Produção " & grdListagem.CurrentRow.Cells("ordem_producao").Value, _
                             "", _
                             ApplicationPath() & "File\ORDEM_PRODUCAO_" & grdListagem.CurrentRow.Cells("ordem_producao").Value & "_" & Format(Now, "yyyyMMdd_hhmm") & ".pdf", _
                             ApplicationPath() & "File\ORDEM_PRODUCAO_" & grdListagem.CurrentRow.Cells("ordem_producao").Value & "_" & Format(Now, "yyyyMMdd_hhmm") & ".pdf", _
                             "", _
                             -1)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirOrdemProducao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(2)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo"
            goCrystalReport.sReportParameter(1).sValue = grdListagem.CurrentRow.Cells("codigo").Value
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & "PRD000000001.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("PRD000000001", "Ordem de Produção", oReport)

            'Atualiza Registro no Banco de Dados
            'Call ExecuteQuery("UPDATE tb_prd_ordem_producao SET impresso = 1 WHERE (((codigo_empresa) = " & goUsuario.iEmpresa & ") AND ((codigo) = " + grdListagem.CurrentRow.Cells("codigo").Value + "))")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirVariasOrdemProducao()

        Try

            'Verifica se foi Selecionado Algum Registro
            If VerificaSelecaoRowDiferente(grdListagem, "status", StatusOrdemProducao.Cancelado) = True Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Váriaveis
                Dim sCodigoOrdemProducao As String = ""

                For Each oRow As GridEXRow In gSelecaoRow
                    sCodigoOrdemProducao &= IIf(sCodigoOrdemProducao = "", "", ",") & oRow.Cells("codigo").Value
                Next

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Redimenciona Vetor
                ReDim goCrystalReport.sReportParameter(2)
                'Seta Parametros
                goCrystalReport.sReportParameter(0).sParamenter = "usuario"
                goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
                goCrystalReport.sReportParameter(1).sParamenter = "@codigo"
                goCrystalReport.sReportParameter(1).sValue = sCodigoOrdemProducao
                goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
                goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
                goCrystalReport.sReport = goCrystalReport.sPath & "PRD000000001.rpt"

                Dim oReport As New usrReport
                oReport.Dock = DockStyle.Fill

                'Abre Relatório
                frmMain.LoadPageReport("PRD000000001", "Ordem de Produção", oReport)

                'Atualiza Registro no Banco de Dados
                Call ExecuteQuery("UPDATE tb_prd_ordem_producao SET impresso = 1 WHERE (((codigo_empresa) = " & goUsuario.iEmpresa & ") AND ((codigo) IN (" + sCodigoOrdemProducao + ")))")

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            Else

                'Informa o Usuário sobre a Necessidade de Selecionar um ou Mais Registros
                frmMain.Informacao(Mensagem.ValidacaoSelecionar, "Ordem de Produção Concluída.")

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoOP() As Boolean
        Try
            ValidacaoOP = False

            If ValidaCampo(cboCodigoProdutoNova, lblCodigoProduto) = False Then
                Exit Function
            End If

            If ValidaCampo(txtQtdPlanejadaNova, lblQtdPlanejadaNova, TipoCampo.numero) = False Then
                Exit Function
            End If

            If ValidaCampo(dtpDataNecessidade, lblDataNecessidade) = False Then
                Exit Function
            End If


            ValidacaoOP = True

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub ItensBom(ByVal lCodigoOrdemProducao As Long)

        Try

            If oClsPrdOrdemProducao.ValidaRequisicaoEstoque(lCodigoOrdemProducao) = True Then

                'Váriaveis Locais
                Dim oForm As New frmPrdItensBom
                oForm.txtCodigoItemFiltro.Text = grdListagem.CurrentRow.Cells("codigo_produto").Value
                oForm.txtPedidoVendaFiltro.Text = grdListagem.CurrentRow.Cells("numero_pedido_venda").Value
                oForm.txtOrdemProducaoFiltro.Text = grdListagem.CurrentRow.Cells("ordem_producao").Value
                oForm.CodigoOrdemProducao = lCodigoOrdemProducao
                oForm.ShowDialog(Me)
                LoadGrid()

            Else
                MsgBox("Essa Ordem de Produção já possui uma requisição de estoque. N° da Requisição existente: " + oClsPrdOrdemProducao.Requisicao, MsgBoxStyle.Exclamation, "Validação")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirCertificado()

        Try

            'Verifica se foi Selecionado Algum Registro
            If VerificaSelecaoRow(grdListagem, "status", StatusOrdemProducao.Concluido) = True Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Váriaveis
                Dim sCodigoOrdemProducao As String = ""

                For Each oRow As GridEXRow In gSelecaoRow
                    sCodigoOrdemProducao &= IIf(sCodigoOrdemProducao = "", "", ",") & oRow.Cells("codigo").Value
                Next

                'Redimenciona Vetor
                ReDim goCrystalReport.sReportParameter(2)
                'Seta Parametros
                goCrystalReport.sReportParameter(0).sParamenter = "usuario"
                goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
                goCrystalReport.sReportParameter(1).sParamenter = "@codigo_ordem_producao"
                goCrystalReport.sReportParameter(1).sValue = sCodigoOrdemProducao
                goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
                goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
                goCrystalReport.sReport = goCrystalReport.sPath & "PRD000000006.rpt"

                Dim oReport As New usrReport
                oReport.Dock = DockStyle.Fill

                'Abre Relatório
                frmMain.LoadPageReport("PRD000000006", "Certificado - Ordem de Produção", oReport)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            Else

                'Informa o Usuário sobre a Necessidade de Selecionar um ou Mais Registros
                frmMain.Informacao(Mensagem.ValidacaoSelecionar, "Ordem de Produção Concluída.")

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Nova()
        Try
            txtNumeroOPNova.Text = ""
            cboCodigoProdutoNova.SelectedIndex = -1
            txtDescricaoNova.Text = ""
            txtQtdPlanejadaNova.Value = 0
            cboOrdemProducaoOriginal.SelectedIndex = -1
            txtObservacaoOPNova.Text = ""
            btnSalvarOPNova.Tag = ""

            txtSequencia.Text = 0
            cboCentroTrabalho.SelectedIndex = -1
            cboOperacao.SelectedIndex = -1

            oClsPrdOrdemProducao.LoadGridRoteiroPadrao(grdRoteiro, 0)

            'Seta Focu
            txtOrdemProducaoFiltro.Focus()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GerarNova()
        Try
            txtNumeroOPNova.Text = ""
            cboCodigoProdutoNova.SelectedIndex = -1
            txtDescricaoNova.Text = ""
            txtQtdPlanejadaNova.Value = 0
            cboOrdemProducaoOriginal.SelectedIndex = -1

            txtObservacaoOPNova.Text = ""

            oClsPrdOrdemProducao.LoadGridRoteiroPadrao(grdRoteiro, 0)

            oClsPrdOrdemProducao.GerarNumero(txtNumeroOPNova)



        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "::: APONTAMENTO :::"
    Private Sub ApontamentoManual()

        Try

            'Verifica Direito
            If VerificaDireito(Formulario.ProducaoApontamentoManual, gcInsert) = True Then

                'Váriaveis - Formulário
                Dim oForm As New frmPrdApontamentoManual

                'Seta Váriaveis
                oForm.CodigoOrdemProducao = grdApontamento.CurrentRow.Cells("codigo_ordem_producao").Value
                oForm.Sequencia = grdApontamento.CurrentRow.Cells("sequencia").Value
                oForm.SequenciaConcorrente = grdApontamento.CurrentRow.Cells("sequencia_concorrente").Value
                oForm.OrdemProducao = txtOrdemProducao.Text.Trim
                oForm.Produto = txtProduto.Text.Trim
                oForm.CentroTrabalho = grdApontamento.CurrentRow.Cells("centro_trabalho").Value
                oForm.Operacao = grdApontamento.CurrentRow.Cells("operacao").Value

                'Abre Formulário
                oForm.ShowDialog()

                'Atualiza Ordem de Produção
                Call AtualizarOrdemProducao()

            Else

                'Informa o Usuário que ele não possui Direito
                frmMain.Informacao(Mensagem.DireitoInserir)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub FinalizarApontamento()

        Try

            'Verifica Direito
            If VerificaDireito(Formulario.ProducaoApontamentoManual, gcInsert) = True Then

                'Verifica se o Usuário deseja Finalizar o Apontamento
                If MsgBox("Deseja Finalizar o Apontamento: " & grdApontamento.CurrentRow.Cells("centro_trabalho").Value & " / " & grdApontamento.CurrentRow.Cells("operacao").Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    'Finaliza Apontamento
                    Call oClsPrdOrdemProducao.FinalizarApontamento(grdApontamento.CurrentRow.Cells("codigo_ordem_producao").Value, _
                                                                   grdApontamento.CurrentRow.Cells("sequencia").Value, _
                                                                   grdApontamento.CurrentRow.Cells("sequencia_concorrente").Value)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                    'Recarrega Dados da Ordem de Produção
                    Call btnAtualizar_Click(btnAtualizar, System.EventArgs.Empty)

                End If

            Else

                'Informa o Usuário que ele não possui Direito
                frmMain.Informacao(Mensagem.DireitoInserir)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InserirApontamento()
        Try
            Dim iApontamento As Integer = 0
            If bEditar = True Then
                iApontamento = LoadCodigo("sp_validade_producao_ordem_producao_apontamento " & btnSalvarOPNova.Tag & ", " & goUsuario.iEmpresa)
                If iApontamento > 0 Then
                    If MsgBox("Existem apontamentos para essa Ordem de Produção e essa operação irá excluí-los. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            ExecuteQuery("DELETE FROM tb_prd_apontamento where codigo_ordem_producao = " & btnSalvarOPNova.Tag)
            For Each oRow In grdRoteiro.GetRows
                oClsPrdOrdemProducao.InsertApontamento(btnSalvarOPNova.Tag, _
                                                       oRow.Cells.Item("sequencia").Value, _
                                                       oRow.Cells.Item("codigo_centro_trabalho2").Value, _
                                                       oRow.Cells.Item("codigo_operacao2").Value, _
                                                       oRow.Cells.Item("observacao").Value)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EditarTempoParada()

        Try

            'Verifica se foi Preenchido a Data de Início
            If IsDBNull(grdApontamento.CurrentRow.Cells("data_inicio").Value) = True Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não foi apontado a Abertura desta Operação.")
                Exit Sub
            End If

            'Verifica se o Aponta a Operação
            If grdApontamento.CurrentRow.Cells("aponta").Value = False Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Este Apontamento é feito de forma Automática. Não pode ser lançado Parada para ele.")
                Exit Sub
            End If

            'Váriaveis Locais
            Dim oForm As New frmPrdApontamentoParada

            'Seta Parâmetros
            oForm.CodigoOrdemProducao = grdApontamento.CurrentRow.Cells("codigo_ordem_producao").Value
            oForm.Sequencia = grdApontamento.CurrentRow.Cells("sequencia").Value
            oForm.SequenciaConcorrente = grdApontamento.CurrentRow.Cells("sequencia_concorrente").Value
            oForm.CodigoApontamentoFuncionario = grdApontamento.CurrentRow.Cells("codigo").Value
            oForm.OrdemProducao = txtOrdemProducao.Text.Trim
            oForm.CentroTrabalho = grdApontamento.CurrentRow.Cells("centro_trabalho").Value
            oForm.Operacao = grdApontamento.CurrentRow.Cells("operacao").Value
            oForm.DataInicio = grdApontamento.CurrentRow.Cells("data_inicio").Value
            oForm.DataTermino = IIf(IsDBNull(grdApontamento.CurrentRow.Cells("data_termino").Value), "", grdApontamento.CurrentRow.Cells("data_termino").Value)
            oForm.Funcionario = grdApontamento.CurrentRow.Cells("funcionario").Value

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

#Region "::: OPERAÇÃO :::"

    Private Sub InserirOperacao()
        Try
            Dim oDataSet = New DataSet

            oDataSet = CType(grdRoteiro.DataSource.dataset, DataSet).Copy

            Dim oRow As DataRow = oDataSet.Tables(0).Rows.Add
            oRow("sequencia") = txtSequencia.Text
            oRow("descricao_centro_trabalho") = cboCentroTrabalho.Text
            oRow("codigo_centro_trabalho2") = cboCentroTrabalho.SelectedValue
            oRow("descricao_operacao") = cboOperacao.Text
            oRow("codigo_operacao2") = cboOperacao.SelectedValue
            oRow("aponta") = True
            oRow("aponta_equipamento") = False
            oRow("apontamento_concorrente") = False
            oRow("controla_qualidade") = False
            oRow("tempo_setup_maquina") = 0
            oRow("tempo_mao_obra") = 0
            oRow("tempo_maquina") = 0
            oRow("observacao") = txtObservacaoRoteiro.Text
            oRow("referencia") = 0


            grdRoteiro.DataSource = oDataSet.DefaultViewManager
            grdRoteiro.DataMember = oDataSet.Tables(0).TableName : grdRoteiro.MoveFirst()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub ExcluirOperacao()
        Try
            If MsgBox("Deseja excluir permanentemente esse(s) registro(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then
                For Each oRow In grdRoteiro.GetCheckedRows
                    oRow.Delete()
                Next
            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
#End Region


#End Region

#End Region

End Class
