Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports CrystalDecisions.CrystalReports.Engine

Public Class usrPrdOrdemServico

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsPrdOrdemServico As New clsUsrPrdOrdemServico
    Public bEditar As Boolean = False

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    'Dim oClsPrdOrdemProducao As Object

    Private Sub usrPrdOrdemServico_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usrPrdOrdemServico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: ORDEM DE SERVIÇO :::"

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            Excluir()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnInserirRoteiro_Click(sender As Object, e As EventArgs) Handles btnInserirRoteiro.Click
        Try
            Call InserirOperacao()
            txtSequencia.Text = 0
            cboCentroTrabalho.SelectedIndex = -1
            cboOperacao.SelectedIndex = -1
            txtObservacaoRoteiro.Text = ""
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

    Private Sub btnVoltarOS_Click(sender As Object, e As EventArgs) Handles btnVoltarOS.Click
        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagNova)
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtOrdemServicoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnImportarExcel_Click(sender As Object, e As EventArgs)
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

    Private Sub btnSalvarOSNova_Click(sender As Object, e As EventArgs) Handles btnSalvarOSNova.Click

        Try

            frmMain.errInfo.Clear()

            Cursor.Current = Cursors.WaitCursor

            Salvar()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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
            oForm.NomeFormulario = Formulario.ProducaoOrdemServico
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ProducaoOrdemServico)

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

    Private Sub btnImprimirCertificado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Imprime Certificado
            Call ImprimirCertificado()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            'Imprime Ordem de Produção
            Call ImprimirVariasOrdemServico()

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
            TratamentoErro(ex.Message, Me.Name)
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
            Call AtualizarOrdemServico()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Salva Observação
            oClsPrdOrdemServico.Salvar(txtOrdemProducao.Tag, _
                                        txtObservacao.Text.Trim)

            'Salva Apontamento
            oClsPrdOrdemServico.SalvarApontamento(txtOrdemProducao.Tag, _
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
            txtOrdemServicoFiltro.Focus()

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
                 
                Case "cancelar" : CancelarOrdemServico()
                Case "editar" : EditarOrdemServico()
                Case "finalizar" : Finalizar()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.ProducaoOrdemServico)

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
                                     Formulario.ProducaoOrdemServico, _
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
                                          Formulario.ProducaoOrdemServico, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
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

    Private Sub cboPedidoVenda_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPedidoVenda.SelectedIndexChanged

        Try

            cboLinhaPV.SelectedIndex = -1
            cboLinhaPV.DataSource = Nothing

            If cboPedidoVenda.SelectedIndex = -1 Then Exit Sub

            LoadCombo(cboLinhaPV, "sp_select_combo_venda_pedido_ordem_servico_item " & cboPedidoVenda.SelectedValue & "," & goUsuario.iEmpresa & "," & IIf(IsNumeric(cboLinhaPV.Tag), CStr(cboLinhaPV.Tag), "NULL"), False)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboLinhaPV_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLinhaPV.SelectedIndexChanged

        Try

            If cboLinhaPV.SelectedIndex <> -1 Then

                Call oClsPrdOrdemServico.LoadDadosItem(cboPedidoVenda.SelectedValue, _
                                                       cboLinhaPV.SelectedValue, _
                                                       txtDescricaoNova, _
                                                       txtQtdPlanejadaNova, _
                                                       cboCentroCusto, _
                                                       txtPlanta, _
                                                       txtRef, _
                                                       txtOM)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: APONTAMENTO :::"

    Private Sub btnGerarOrdemServico_Click(sender As Object, e As EventArgs) Handles btnGerarOrdemServico.Click

        Try

            frmMain.errInfo.Clear()

            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagNova)
            grpOPNova.Enabled = True
            bEditar = False
            Nova()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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
            oForm.NomeFormulario = Formulario.ProducaoOrdemServico
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdApontamento, Formulario.ProducaoOrdemServico)

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
                                     Formulario.ProducaoOrdemServico, _
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
                                     Formulario.ProducaoOrdemServico)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColunaApontamento, grdApontamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdApontamento_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdApontamento.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdApontamento.Name, _
                                          Formulario.ProducaoOrdemServico, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

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
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usrPrdOrdemServico_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_ordem_producao")
            LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa, False)
            LoadCombo(cboCentroCusto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            LoadCombo(cboPedidoVenda, "sp_select_combo_venda_pedido_ordem_servico " & goUsuario.iEmpresa, False)

            cboTipo.Items.Clear()
            cboTipo.Items.Add("SERVIÇO", "SERVIÇO")

            'Configura Direito
            btnImprimir.Enabled = VerificaDireito(Formulario.ProducaoOrdemServico, gcPrint)
            btnInserirRoteiro.Enabled = True

            'Seta Controles
            dtpDataInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ProducaoOrdemServico)
            Call ConfiguraGrid(grdApontamento, Formulario.ProducaoOrdemServico)
            Call ConfiguraGrid(grdCustoMO, Formulario.ProducaoOrdemServico)
            Call ConfiguraGrid(grdCustoMP, Formulario.ProducaoOrdemServico)


            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Remove(pagNova)


            'Seta Focu
            txtOrdemServicoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region
     
#Region "::: ORDEM DE SERVIÇO :::"

    Private Sub Excluir()
        Try

            If grdListagem.GetCheckedRows.Count = 0 Then

                frmMain.Informacao(Mensagem.ValidacaoSelecionar)

                Exit Sub

            End If

            'Questiona o usuario
            If MsgBox("Deseja excluir os registros selecionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") = vbNo Then Exit Sub

            'Exclui os itens
            oClsPrdOrdemServico.Delete(grdListagem)

            'Carrega novamente
            LoadGrid()

            'Informa o usuário
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Salvar()

        Try

            Cursor.Current = Cursors.WaitCursor

            If ValidacaoOS() = True Then

                If CStr(btnSalvarOSNova.Tag) = "" Then

                    oClsPrdOrdemServico.Insert(txtNumeroOSNova.Tag, _
                                               cboLinhaPV.SelectedValue, _
                                               dtpDataEmissao.Value, _
                                               txtQtdPlanejadaNova.Value, _
                                               cboTipo.SelectedValue, _
                                               cboCentroCusto.SelectedValue, _
                                               txtPlanta.Text, _
                                               txtRef.Text, _
                                               txtOM.Text, _
                                               txtObservacaoOSNova.Text, _
                                               btnSalvarOSNova, _
                                               cboPedidoVenda.SelectedValue)

                    frmMain.Informacao(Mensagem.RegistroInserido)

                Else

                    oClsPrdOrdemServico.Update(btnSalvarOSNova.Tag, _
                                               dtpDataEmissao.Value, _
                                               txtQtdPlanejadaNova.Value, _
                                               cboTipo.SelectedValue, _
                                               cboCentroCusto.SelectedValue, _
                                               txtPlanta.Text, _
                                               txtRef.Text, _
                                               txtOM.Text, _
                                               txtObservacaoOSNova.Text, _
                                               cboPedidoVenda.SelectedValue, _
                                               cboLinhaPV.SelectedValue)

                    frmMain.Informacao(Mensagem.RegistroAlterado)

                End If

                InserirApontamento()

            End If

            Cursor.Current = Cursors.Default

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

            'Seta Parametros
            oClsPrdOrdemServico.LoadGrid(grdListagem, _
                                          IIf(IsNumeric(txtOrdemServicoFiltro.Text) = False, -1, txtOrdemServicoFiltro.Text), _
                                          IIf(dtpDataInicioFiltro.Checked = False, "", dtpDataInicioFiltro.Value), _
                                          IIf(dtpDataTerminoFiltro.Checked = False, "", dtpDataTerminoFiltro.Value), _
                                          txtCodigoProdutoFiltro.Text, _
                                          sStatus, _
                                          IIf(cboTipoFiltro.SelectedIndex = -1, "", cboTipoFiltro.SelectedValue), _
                                          txtPlantaFiltro.Text, _
                                          txtREFFiltro.Text, _
                                          txtOMFiltro.Text)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizarOrdemServico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call oClsPrdOrdemServico.LoadGridApontamento(grdApontamento, _
                                                          grdListagem.CurrentRow.Cells("codigo").Value)

            'Carrega Grid - Custo M.P.
            Call oClsPrdOrdemServico.LoadGridCustoMP(grdCustoMP, _
                                                      grdListagem.CurrentRow.Cells("codigo").Value)

            'Carrega Grid - Custo M.O.
            Call oClsPrdOrdemServico.LoadGridCustoMO(grdCustoMO, _
                                                      grdListagem.CurrentRow.Cells("codigo").Value)

            Dim dCustoMO As Double = 0
            Dim dCustoMP As Double = 0

            If grdCustoMO.GetDataRows.Count > 0 Then dCustoMO = grdCustoMO.GetTotalRow.Cells("custo").Value
            If grdCustoMP.GetDataRows.Count > 0 Then dCustoMP = grdCustoMP.GetTotalRow.Cells("valor_total").Value

            'Carrega Gráfico de Custo
            Call oClsPrdOrdemServico.LoadGraficoCusto(chrCusto, _
                                                       dCustoMO, _
                                                       dCustoMP)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarOrdemServico()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.ProducaoOrdemServico, gcUpdate) = True Then

                If grdListagem.CurrentRow.Cells("status").Value = 4 Then
                    frmMain.Informacao("Não é possível realizar essa operação!", Color.Red)
                    Exit Sub
                End If

                btnSalvarOSNova.Tag = grdListagem.CurrentRow.Cells("codigo").Value
                cboPedidoVenda.Tag = grdListagem.GetValue("codigo_pedido")
                cboLinhaPV.Tag = grdListagem.GetValue("codigo_pedido_item")
                LoadCombo(cboPedidoVenda, "sp_select_combo_venda_pedido_ordem_servico " & goUsuario.iEmpresa & "," & IIf(IsNumeric(cboPedidoVenda.Tag), CStr(cboPedidoVenda.Tag), "NULL"), False)

                bEditar = True
                
                txtNumeroOSNova.Text = grdListagem.CurrentRow.Cells("ordem_servico").Value
                dtpDataEmissao.Value = grdListagem.CurrentRow.Cells("data_emissao").Value
                cboPedidoVenda.SelectedValue = grdListagem.CurrentRow.Cells("codigo_pedido").Value
                cboLinhaPV.SelectedValue = grdListagem.CurrentRow.Cells("codigo_pedido_item").Value
                txtQtdPlanejadaNova.Value = grdListagem.CurrentRow.Cells("quantidade").Value
                cboTipo.SelectedValue = grdListagem.CurrentRow.Cells("tipo").Value
                cboCentroCusto.SelectedValue = grdListagem.CurrentRow.Cells("codigo_centro_custo").Value
                txtPlanta.Text = grdListagem.CurrentRow.Cells("planta").Value
                txtRef.Text = grdListagem.CurrentRow.Cells("ref").Value
                txtOM.Text = grdListagem.CurrentRow.Cells("om").Value
                txtObservacaoOSNova.Text = grdListagem.CurrentRow.Cells("observacao").Value

                Dim iApontamento As Integer = 0

                iApontamento = LoadCodigo("sp_validade_producao_ordem_servico_apontamento " & btnSalvarOSNova.Tag & ", " & goUsuario.iEmpresa)

                If iApontamento > 0 Then
                    btnInserirRoteiro.Enabled = False
                    btnExcluirRoteiro.Enabled = False
                End If

                oClsPrdOrdemServico.LoadGridApontamento(grdRoteiro, _
                                                        grdListagem.CurrentRow.Cells("codigo").Value)

                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Remove(pagDados)
                tabMain.TabPages.Add(pagNova)

                LoadGrid()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Finalizar()

        Try

            If grdListagem.GetValue("status") = 4 Then
                MsgBox("Não é possível finalizar uma OS cancelada.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            If grdListagem.GetValue("status") = 3 Then
                MsgBox("Essa OS já está finalizada.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            'Verifica se o Usuário deseja Cancelar a Ordem de Produção
            If MsgBox("Deseja Finalizar a Ordem de Serviço?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then Exit Sub

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsPrdOrdemServico.FinalizarOrdemServico(grdListagem.CurrentRow.Cells.Item("codigo").Value)

            frmMain.Informacao(Mensagem.RegistroAlterado)

            LoadGrid()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CancelarOrdemServico()

        Try

            If grdListagem.GetValue("status") = 3 Then
                MsgBox("Não é possível cancelar uma OS finalizada.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            If grdListagem.GetValue("status") = 4 Then
                MsgBox("Essa OS já está cancelada.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            'Verifica se o Usuário deseja Cancelar a Ordem de Produção
            If MsgBox("Deseja Cancelar a Ordem de Serviço?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then Exit Sub

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sHistorico As String

            sHistorico = InputBox("Digite o motivo do cancelamento", "Justificativa", "")

            If sHistorico = "" Then
                MsgBox("Digite um motivo válido!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Validação")
                Exit Sub
            End If

            oClsPrdOrdemServico.CancelarOrdemServico(grdListagem.CurrentRow.Cells.Item("codigo").Value, sHistorico)

            frmMain.Informacao(Mensagem.RegistroAlterado)

            LoadGrid()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirOrdemServico()

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

    Private Sub ImprimirVariasOrdemServico()

        Try

            'Verifica se foi Selecionado Algum Registro
            If VerificaSelecaoRowDiferente(grdListagem, "status", StatusOrdemProducao.Cancelado) = True Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Váriaveis
                Dim sCodigoOrdemServico As String = ""

                For Each oRow As GridEXRow In gSelecaoRow
                    sCodigoOrdemServico &= IIf(sCodigoOrdemServico = "", "", ",") & oRow.Cells("codigo").Value
                Next

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Redimenciona Vetor
                ReDim goCrystalReport.sReportParameter(2)
                'Seta Parametros
                goCrystalReport.sReportParameter(0).sParamenter = "usuario"
                goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
                goCrystalReport.sReportParameter(1).sParamenter = "@codigo"
                goCrystalReport.sReportParameter(1).sValue = sCodigoOrdemServico
                goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
                goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
                goCrystalReport.sReport = goCrystalReport.sPath & "PRD000000001.rpt"

                Dim oReport As New usrReport
                oReport.Dock = DockStyle.Fill

                'Abre Relatório
                frmMain.LoadPageReport("PRD000000001", "Ordem de Serviço", oReport)

                'Atualiza Registro no Banco de Dados
                Call ExecuteQuery("UPDATE tb_prd_ordem_producao SET impresso = 1 WHERE (((codigo_empresa) = " & goUsuario.iEmpresa & ") AND ((codigo) IN (" + sCodigoOrdemServico + ")))")

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

    Private Function ValidacaoOS() As Boolean
        Try
            ValidacaoOS = False

            If ValidaCampo(cboPedidoVenda, lblPedidoVenda) = False Then
                Exit Function
            End If

            If ValidaCampo(cboLinhaPV, lblLinhaPV) = False Then
                Exit Function
            End If

            If ValidaCampo(txtQtdPlanejadaNova, lblQtdPlanejadaNova, TipoCampo.numero) = False Then
                Exit Function
            End If

            If ValidaCampo(cboTipo, lblTipo) = False Then
                Exit Function
            End If

            If ValidaCampo(cboCentroCusto, lblCentroCusto) = False Then
                Exit Function
            End If

            If IsNumeric(btnSalvar.Tag) Then

                If oClsPrdOrdemServico.ValidaPedido(cboPedidoVenda.SelectedValue, _
                                                cboLinhaPV.SelectedValue, _
                                                oClsPrdOrdemServico.CodigoOrdemServico) = False Then
                    frmMain.errInfo.SetError(lblPedidoVenda, "Este Pedido de Venda: " & cboPedidoVenda.Text & " já está associado a outro Registro.")
                    cboPedidoVenda.Focus()
                    Exit Function
                End If

            End If

            ValidacaoOS = True

        Catch ex As Exception
            Throw ex
        End Try
    End Function



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

            LoadCombo(cboPedidoVenda, "sp_select_combo_venda_pedido_ordem_servico " & goUsuario.iEmpresa, False)

            txtNumeroOSNova.Text = ""
            cboPedidoVenda.SelectedIndex = -1
            cboPedidoVenda.Text = ""
            cboLinhaPV.SelectedIndex = -1
            cboLinhaPV.Text = ""
            txtDescricaoNova.Text = ""
            txtQtdPlanejadaNova.Value = 0
            cboTipo.SelectedIndex = -1
            txtObservacaoOSNova.Text = ""
            btnSalvarOSNova.Tag = ""
            cboCentroCusto.SelectedIndex = -1
            cboCentroCusto.Text = ""
            txtPlanta.Text = ""
            txtRef.Text = ""
            txtOM.Text = ""
            cboPedidoVenda.Tag = ""
            cboLinhaPV.Tag = ""

            txtSequencia.Text = 0
            cboCentroTrabalho.SelectedIndex = -1
            cboOperacao.SelectedIndex = -1
            grdRoteiro.DataSource = Nothing

            oClsPrdOrdemServico.GerarNumero(txtNumeroOSNova)

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
                Call AtualizarOrdemServico()

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
                    Call oClsPrdOrdemServico.FinalizarApontamento(grdApontamento.CurrentRow.Cells("codigo_ordem_producao").Value, _
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
                iApontamento = LoadCodigo("sp_validade_producao_ordem_servico_apontamento " & btnSalvarOSNova.Tag & ", " & goUsuario.iEmpresa)
                If iApontamento > 0 Then
                    grpRoteiro.Enabled = False
                Else
                    grpRoteiro.Enabled = True
                    ExecuteQuery("DELETE FROM tb_prd_apontamento_servico where codigo_ordem_servico = " & btnSalvarOSNova.Tag)
                    For Each oRow In grdRoteiro.GetRows
                        oClsPrdOrdemServico.InsertApontamento(btnSalvarOSNova.Tag, _
                                                               oRow.Cells.Item("sequencia").Value, _
                                                               oRow.Cells.Item("codigo_centro_trabalho2").Value, _
                                                               oRow.Cells.Item("codigo_operacao2").Value, _
                                                               IIf(IsDBNull(oRow.Cells.Item("observacao").Value), "", oRow.Cells.Item("observacao").Value))
                    Next
                End If
            Else
                grpRoteiro.Enabled = True
                ExecuteQuery("DELETE FROM tb_prd_apontamento_servico where codigo_ordem_servico = " & btnSalvarOSNova.Tag)
                For Each oRow In grdRoteiro.GetRows
                    oClsPrdOrdemServico.InsertApontamento(btnSalvarOSNova.Tag, _
                                                           oRow.Cells.Item("sequencia").Value, _
                                                           oRow.Cells.Item("codigo_centro_trabalho2").Value, _
                                                           oRow.Cells.Item("codigo_operacao2").Value, _
                                                           IIf(IsDBNull(oRow.Cells.Item("observacao").Value), "", oRow.Cells.Item("observacao").Value))
                Next
            End If

            If ValidacaoOS() = True Then Nova()

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

            Try
                oDataSet = CType(grdRoteiro.DataSource.dataset, DataSet).Copy

                Dim oRow As DataRow = oDataSet.Tables(0).Rows.Add
                oRow("sequencia") = txtSequencia.Text
                oRow("descricao_centro_trabalho") = cboCentroTrabalho.Text
                oRow("codigo_centro_trabalho2") = cboCentroTrabalho.SelectedValue
                oRow("descricao_operacao") = cboOperacao.Text
                oRow("codigo_operacao2") = cboOperacao.SelectedValue
                oRow("observacao") = IIf(txtObservacaoRoteiro.Text = "", "", txtObservacaoRoteiro.Text)
            Catch ex As Exception
                Dim oDataTable As New DataTable
                Dim oDCSequencia As New DataColumn("sequencia")
                Dim oDCDescricaoCT As New DataColumn("descricao_centro_trabalho")
                Dim oDCCodCT As New DataColumn("codigo_centro_trabalho2")
                Dim oDCDescricaoOP As New DataColumn("descricao_operacao")
                Dim oDCCodigoOP As New DataColumn("codigo_operacao2")
                Dim oDCObservacao As New DataColumn("observacao")

                'Seta DataType
                oDCSequencia.DataType = 0.GetType
                oDCDescricaoCT.DataType = "".GetType
                oDCCodCT.DataType = 0.GetType
                oDCDescricaoOP.DataType = "".GetType
                oDCCodigoOP.DataType = 0.GetType
                oDCObservacao.DataType = "".GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCSequencia)
                oDataTable.Columns.Add(oDCDescricaoCT)
                oDataTable.Columns.Add(oDCCodCT)
                oDataTable.Columns.Add(oDCDescricaoOP)
                oDataTable.Columns.Add(oDCCodigoOP)
                oDataTable.Columns.Add(oDCObservacao)

                Dim oDataRow As DataRow = oDataTable.NewRow
                oDataRow("sequencia") = txtSequencia.Text
                oDataRow("descricao_centro_trabalho") = cboCentroTrabalho.Text
                oDataRow("codigo_centro_trabalho2") = cboCentroTrabalho.SelectedValue
                oDataRow("descricao_operacao") = cboOperacao.Text
                oDataRow("codigo_operacao2") = cboOperacao.SelectedValue
                oDataRow("observacao") = IIf(txtObservacaoRoteiro.Text = "", "", txtObservacaoRoteiro.Text)
                oDataTable.Rows.Add(oDataRow)
            End Try



            Call ConfigurarDataMemberGrid(grdRoteiro)

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

End Class
