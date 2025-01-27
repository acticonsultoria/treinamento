Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class usrCadRoteiroProducao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadRoteiroProducao As New clsUsrCadRoteiroProducao

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadRoteiroProducao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCentroTrabalho" : Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa, False)
                        Case "cboOperacao" : Call cboCentroTrabalho_SelectedIndexChanged(cboCentroTrabalho, System.EventArgs.Empty)
                        Case "cboCodigoMaquina" : Call LoadCombo(cboCodigoMaquina, "sp_select_combo_cadastro_basico_maquina " & TipoMaquina.Injetora & ", " & goUsuario.iEmpresa, False)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboCentroTrabalho" : Call btnCadastrarCentroTrabalho_Click(btnCadastrarCentroTrabalho, System.EventArgs.Empty)
                        Case "cboOperacao" : Call btnCadastrarOperacao_Click(btnCadastrarOperacao, System.EventArgs.Empty)
                        Case "cboCodigoMaquina" : Call btnCadastrarMaquina_Click(btnCadastrarMaquina, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadRoteiroProducao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: ROTEIRO :::"

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
            oForm.NomeFormulario = Formulario.CadastroBasicoRoteiroProducao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoRoteiroProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário
            Call Novo()

            'Seta Focu
            txtCodigo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara Formulário
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            txtCodigo.Focus()

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

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If Validacao() = True Then

                'Salva Roteiro
                Call Salvar()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            'Carrega Grid
            Call LoadGrid()

            'Seta Focu
            txtCodigoFiltro.Focus()

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

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a célula pressionada é válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()

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
                                     Formulario.CadastroBasicoRoteiroProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoRoteiroProducao, _
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
                                          Formulario.CadastroBasicoRoteiroProducao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ROTEIRO LINHA :::"

    Private Sub btnAgruparGridRoteiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridRoteiro.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdRoteiro.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdRoteiro.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdRoteiro.GroupByBoxVisible = True
                grdRoteiro.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridRoteiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridRoteiro.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdRoteiro
            oForm.NomeFormulario = Formulario.CadastroBasicoRoteiroProducao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdRoteiro, Formulario.CadastroBasicoRoteiroProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridRoteiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridRoteiro.Click

        Try

            'Exporta Grid
            Call ExportExcel(grdRoteiro)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroTrabalho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroTrabalho.Click

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

    Private Sub btnCadastrarOperacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarOperacao.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadOperacao")

            If cboCentroTrabalho.SelectedIndex = -1 Then
                cboOperacao.DataSource = Nothing
                cboOperacao.Text = ""
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

    Private Sub btnInserirRoteiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirRoteiro.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If Validacao() = False Then Exit Sub

            'Salva Roteiro
            Call Salvar()

            'Valida Dados do Roteiro
            If ValidacaoRoteiro() = True Then

                'Salva Roteiro
                Call SalvarRoteiro()

                'Carrega Grid
                Call oClsCadRoteiroProducao.LoadGridRoteiroLinha(grdRoteiro, btnSalvar.Tag)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoRoteiro()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirRoteiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirRoteiro.Click

        Try

            'Deleta Roteiro
            Call DeleteRoteiro()

            'Limpa Formulário
            Call NovoRoteiro()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdRoteiro.FrozenColumns = 2
            Else
                grdRoteiro.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCentroTrabalho_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentroTrabalho.SelectedItemChanged

        Try

            'Verifica se foi Selecionado algum Centro de Trabalho
            If cboCentroTrabalho.SelectedIndex = -1 Then
                'Limpa Controle
                cboOperacao.DataSource = Nothing : cboOperacao.Text = ""
            Else
                cboAponta.Enabled = CType(LoadDescricao("sp_select_cadastro_basico_centro_trabalho_local_processamento " & goUsuario.iEmpresa & ", " & cboCentroTrabalho.SelectedValue), Boolean)
                If cboAponta.Enabled = False Then cboAponta.SelectedValue = False
                'Carrega Combo
                Call LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_operacao " & cboCentroTrabalho.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboAponta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAponta.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Centro de Trabalho
            If cboAponta.SelectedIndex = -1 Then
                cboApontaEquipamento.Enabled = False : cboApontaEquipamento.SelectedIndex = -1
                cboApontamentoConcorrente.Enabled = False : cboApontamentoConcorrente.SelectedIndex = -1
            Else
                If cboAponta.SelectedValue = False Then
                    cboApontaEquipamento.Enabled = False : cboApontaEquipamento.SelectedIndex = -1
                    cboApontamentoConcorrente.Enabled = False : cboApontamentoConcorrente.SelectedIndex = -1
                Else
                    cboApontaEquipamento.Enabled = True
                    cboApontamentoConcorrente.Enabled = True
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboReferenciaMolde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReferenciaMolde.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Centro de Trabalho
            If cboReferenciaMolde.SelectedIndex = -1 Then
                txtTempoSetupMaquina.Enabled = False : txtTempoSetupMaquina.Text = "00:00:00"
                txtTempoMaoObra.Enabled = False : txtTempoMaoObra.Text = "00:00:00"
                txtTempoMaquina.Enabled = False : txtTempoMaquina.Text = "00:00:00"
            Else
                If cboReferenciaMolde.SelectedValue = False Then
                    txtTempoSetupMaquina.Enabled = True
                    txtTempoMaoObra.Enabled = True
                    txtTempoMaquina.Enabled = True
                Else
                    txtTempoSetupMaquina.Enabled = False : txtTempoSetupMaquina.Text = "00:00:00"
                    txtTempoMaoObra.Enabled = False : txtTempoMaoObra.Text = "00:00:00"
                    txtTempoMaquina.Enabled = False : txtTempoMaquina.Text = "00:00:00"
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRoteiro_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdRoteiro.RowDoubleClick

        Try

            'Verifica se a célula pressionada é válida
            If IsNothing(grdRoteiro.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdRoteiro.CurrentColumn.Key

                Case "editar" : Call EditarRoteiro()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRoteiro_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdRoteiro.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRoteiro, _
                                     Formulario.CadastroBasicoRoteiroProducao)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdRoteiro)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRoteiro_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdRoteiro.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRoteiro.Name, _
                                     Formulario.CadastroBasicoRoteiroProducao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRoteiro_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdRoteiro.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdRoteiro.Name, _
                                          Formulario.CadastroBasicoRoteiroProducao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub tabDados_SelectedTabChanged(sender As Object, e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabDados.SelectedTabChanged

        Try

            'Verifica qual Aba está Selecionada
            Select Case tabDados.SelectedTab.Key

                Case "pagRoteiro" : cboCongelarColuna.Visible = True : lblCongelarColuna.Visible = True
                Case Else : cboCongelarColuna.Visible = False : lblCongelarColuna.Visible = False

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: MÁQUINA :::"

    Private Sub btnAgruparGridMaquina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridMaquina.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdMaquina.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdMaquina.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdMaquina.GroupByBoxVisible = True
                grdMaquina.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridMaquina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridMaquina.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdMaquina
            oForm.NomeFormulario = Formulario.CadastroBasicoRoteiroProducao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdMaquina, Formulario.CadastroBasicoRoteiroProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridMaquina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridMaquina.Click

        Try

            'Exporta Grid
            Call ExportExcel(grdMaquina)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarMaquina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarMaquina.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadMaquina")

            'Carrega Combo
            Call LoadCombo(cboCodigoMaquina, "sp_select_combo_cadastro_basico_maquina " & TipoMaquina.Injetora & ", " & goUsuario.iEmpresa, False)
            'Seta Focu
            cboCodigoMaquina.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirMaquina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirMaquina.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If Validacao() = False Then Exit Sub

            'Salva Roteiro
            Call Salvar()

            'Valida Dados do Formulário
            If ValidacaoMaquina() = True Then

                'Salva Maquina
                Call SalvarMaquina()

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoMaquina()

                'Carrega Grid
                Call oClsCadRoteiroProducao.LoadGridMaquina(grdMaquina, btnSalvar.Tag)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirMaquina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirMaquina.Click

        Try

            'Deleta Registros
            Call DeleteMaquina()

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoMaquina()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCodigoMaquina_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCodigoMaquina.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboCodigoMaquina.SelectedIndex = -1 Then
                'Limpa Controles
                txtDescricaoMaquina.Text = ""
            Else
                'Váriaveis Locais
                Dim oClsCadMaquina As New clsUsrCadMaquina
                'Carrega Controles
                Call oClsCadMaquina.LoadDadosMaquina(cboCodigoMaquina.SelectedValue, txtDescricaoMaquina)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdMaquina_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdMaquina.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdMaquina.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdMaquina.CurrentColumn.Key

                Case "editar" : Call EditarMaquina()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdMaquina_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdMaquina.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdMaquina, _
                                     Formulario.CadastroBasicoRoteiroProducao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdMaquina_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdMaquina.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdMaquina.Name, _
                                     Formulario.CadastroBasicoRoteiroProducao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdMaquina_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdMaquina.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdMaquina.Name, _
                                          Formulario.CadastroBasicoRoteiroProducao, _
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

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadRoteiroProducao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnInserirRoteiro.Enabled = VerificaDireito(Formulario.CadastroBasicoRoteiroProducao, gcDelete)
            btnExcluirRoteiro.Enabled = VerificaDireito(Formulario.CadastroBasicoRoteiroProducao, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoRoteiroProducao, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoRoteiroProducao, gcPrint)
            btnExcelGridRoteiro.Enabled = VerificaDireito(Formulario.CadastroBasicoRoteiroProducao, gcPrint)
            btnExcelGridMaquina.Enabled = VerificaDireito(Formulario.CadastroBasicoRoteiroProducao, gcPrint)

            'Verifica Direito - Botão Cadastro            
            btnCadastrarMaquina.Enabled = VerificaDireito(Formulario.CadastroBasicoMaquinaEquipamento, gcInsert)
            btnCadastrarCentroTrabalho.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)
            btnCadastrarOperacao.Enabled = VerificaDireito(Formulario.CadastroBasicoOperacao, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa, False)
            Call LoadComboSimNao(cboAponta)
            Call LoadComboSimNao(cboApontaEquipamento)
            Call LoadComboSimNao(cboApontamentoConcorrente)
            Call LoadComboSimNao(cboControlaQualidade)
            Call LoadComboSimNao(cboReferenciaMolde)
            Call LoadCombo(cboCodigoMaquina, "sp_select_combo_cadastro_basico_maquina " & TipoMaquina.Injetora & ", " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboModeloOrdemProducao, "sp_select_combo_static_relatorio_tipo 'ORDEM PRODUÇÃO'")
            Call LoadCombo(cboModeloOrdemProducaoFiltro, "sp_select_combo_static_relatorio_tipo 'ORDEM PRODUÇÃO'")

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoRoteiroProducao)
            Call ConfiguraGrid(grdRoteiro, Formulario.CadastroBasicoRoteiroProducao)
            Call ConfiguraGrid(grdMaquina, Formulario.CadastroBasicoRoteiroProducao)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdRoteiro)

            'Remove Páginas
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtCodigoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ROTEIRO :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call oClsCadRoteiroProducao.LoadGrid(grdListagem, _
                                                 txtCodigoFiltro.Text.Trim, _
                                                 IIf(cboModeloOrdemProducaoFiltro.SelectedIndex = -1, "", cboModeloOrdemProducaoFiltro.SelectedValue), _
                                                 txtDescricaoFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Formulário
            Call Novo()

            'Carrega Controles - Capa
            txtCodigo.Text = grdListagem.CurrentRow.Cells("codigo_roteiro").Value
            txtDescricao.Text = grdListagem.CurrentRow.Cells("descricao").Value
            cboModeloOrdemProducao.SelectedValue = grdListagem.CurrentRow.Cells("relatorio_tipo").Value
            btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value

            'Carrega Grid
            Call oClsCadRoteiroProducao.LoadGridRoteiroLinha(grdRoteiro, btnSalvar.Tag)

            'Carrega Grid - Máquina
            Call oClsCadRoteiroProducao.LoadGridMaquina(grdMaquina, btnSalvar.Tag)

            'Carrega Combo
            If IsNumeric(btnSalvar.Tag) Then
                Call LoadCombo(cboSequenciaPredecessora, "sp_select_combo_cadastro_basico_roteiro_producao_sequencia " & goUsuario.iEmpresa & ", " & btnSalvar.Tag)
            Else
                cboSequenciaPredecessora.DataSource = Nothing : cboSequenciaPredecessora.Text = ""
            End If

            'Alterna Aba
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)

            'Seta Aba
            tabDados.SelectedTab = pagRoteiro

            'Seta Focu
            txtCodigo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Capa
            txtCodigo.Text = ""
            txtDescricao.Text = ""
            txtDescricaoMaquina.Text = ""
            cboModeloOrdemProducao.Text = ""
            btnSalvar.Tag = ""

            'Limpa Controles - Linha
            txtSequencia.Value = 0
            For Each oRow As GridEXRow In grdRoteiro.GetDataRows
                txtSequencia.Value = IIf(oRow.Cells("sequencia").Value > txtSequencia.Value, oRow.Cells("sequencia").Value, txtSequencia.Value)
            Next
            txtSequencia.Value = txtSequencia.Value + 1
            cboCentroTrabalho.SelectedIndex = -1
            cboOperacao.SelectedIndex = -1
            cboSequenciaPredecessora.SelectedIndex = -1
            cboSequenciaPredecessora.DataSource = Nothing
            txtObservacao.Text = ""
            cboAponta.SelectedIndex = -1 : cboAponta.Enabled = True
            cboApontaEquipamento.SelectedIndex = -1 : cboApontaEquipamento.Enabled = True
            cboApontamentoConcorrente.SelectedIndex = -1 : cboApontamentoConcorrente.Enabled = True
            cboControlaQualidade.SelectedIndex = -1
            cboReferenciaMolde.SelectedIndex = -1
            txtTempoSetupMaquina.Text = ""
            txtTempoMaquina.Text = ""
            txtTempoMaoObra.Text = ""
            txtReferencia.Value = 0
            btnInserirRoteiro.Tag = ""
            grdRoteiro.DataSource = Nothing

            'Limpa Controles - Máquina
            cboCodigoMaquina.SelectedIndex = -1
            txtDescricaoMaquina.Text = ""
            btnInserirMaquina.Tag = ""
            grdMaquina.DataSource = Nothing

            'Seta Aba
            tabDados.SelectedTab = pagRoteiro

            'Seta Focu
            txtCodigo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCadRoteiroProducao.Delete()

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

    Private Sub Salvar()

        Try

            'Seta Parâmetros
            oClsCadRoteiroProducao.CodigoRoteiro = txtCodigo.Text.Trim
            oClsCadRoteiroProducao.Descricao = txtDescricao.Text.Trim
            oClsCadRoteiroProducao.RelatorioTipo = cboModeloOrdemProducao.SelectedValue
            oClsCadRoteiroProducao.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                Call oClsCadRoteiroProducao.Update()
            Else
                Call oClsCadRoteiroProducao.Insert()
                btnSalvar.Tag = oClsCadRoteiroProducao.Codigo
            End If

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Código
            If ValidaCampo(txtCodigo, lblCodigo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o Código é Válido
            If oClsCadRoteiroProducao.Validacao(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                txtCodigo.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblCodigo, "Este Código já está associado a outro registro.")
                txtCodigo.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Relatório
            If ValidaCampo(cboModeloOrdemProducao, lblModeloOrdemProducao) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ROTEIRO LINHA :::"

    Private Sub NovoRoteiro()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Contato
            txtSequencia.Value = 0
            For Each oRow As GridEXRow In grdRoteiro.GetDataRows
                txtSequencia.Value = IIf(oRow.Cells("sequencia").Value > txtSequencia.Value, oRow.Cells("sequencia").Value, txtSequencia.Value)
            Next
            txtSequencia.Value = txtSequencia.Value + 1
            cboCentroTrabalho.SelectedIndex = -1
            cboOperacao.SelectedIndex = -1
            cboSequenciaPredecessora.SelectedIndex = -1
            txtObservacao.Text = ""
            cboAponta.SelectedIndex = -1 : cboAponta.Enabled = True
            cboApontaEquipamento.SelectedIndex = -1 : cboApontaEquipamento.Enabled = True
            cboApontamentoConcorrente.SelectedIndex = -1 : cboApontamentoConcorrente.Enabled = True
            cboControlaQualidade.SelectedIndex = -1
            cboReferenciaMolde.SelectedIndex = -1
            txtTempoSetupMaquina.Text = ""
            txtTempoMaquina.Text = ""
            txtTempoMaoObra.Text = ""
            txtReferencia.Value = 0
            btnInserirRoteiro.Tag = ""

            'Carrega Combo
            If IsNumeric(btnSalvar.Tag) Then
                Call LoadCombo(cboSequenciaPredecessora, "sp_select_combo_cadastro_basico_roteiro_producao_sequencia " & goUsuario.iEmpresa & ", " & btnSalvar.Tag)
            Else
                cboSequenciaPredecessora.DataSource = Nothing : cboSequenciaPredecessora.Text = ""
            End If

            'Seta Focu
            txtSequencia.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteRoteiro()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdRoteiro) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCadRoteiroProducao.DeleteRoteiroLinha(btnSalvar.Tag)

                    'Prepara Formulário
                    Call NovoRoteiro()

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

    Private Sub EditarRoteiro()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoRoteiroProducao, gcUpdate) = True Then

                With grdRoteiro.CurrentRow.Cells

                    'Carrega Controles
                    txtSequencia.Value = .Item("sequencia").Value
                    cboCentroTrabalho.SelectedValue = .Item("codigo_centro_trabalho").Value
                    cboOperacao.SelectedValue = .Item("codigo_operacao").Value
                    txtObservacao.Text = IIf(IsDBNull(.Item("observacao").Value), "", .Item("observacao").Value)
                    cboReferenciaMolde.SelectedValue = .Item("referencia_molde").Value
                    txtTempoSetupMaquina.Text = .Item("tempo_setup_maquina").Value
                    txtTempoMaoObra.Text = .Item("tempo_mao_obra").Value
                    txtTempoMaquina.Text = .Item("tempo_maquina").Value
                    txtReferencia.Value = .Item("referencia").Value
                    cboAponta.SelectedValue = .Item("aponta").Value
                    cboApontaEquipamento.SelectedValue = .Item("aponta_equipamento").Value
                    cboApontamentoConcorrente.SelectedValue = .Item("apontamento_concorrente").Value
                    cboControlaQualidade.SelectedValue = .Item("controla_qualidade").Value
                    btnInserirRoteiro.Tag = .Item("sequencia").Value

                End With

                'Seta Focu
                txtSequencia.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarRoteiro()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirRoteiro.Tag) Then

                'Altera Registro
                Call oClsCadRoteiroProducao.UpdateRoteiroLinha(btnSalvar.Tag, _
                                                               txtSequencia.Value, _
                                                               cboCentroTrabalho.SelectedValue, _
                                                               cboOperacao.SelectedValue, _
                                                               IIf(cboSequenciaPredecessora.SelectedIndex = -1, -1, cboSequenciaPredecessora.Text), _
                                                               cboReferenciaMolde.SelectedValue, _
                                                               ((DatePart(DateInterval.Hour, CDate(txtTempoSetupMaquina.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtTempoSetupMaquina.Text)) + (DatePart(DateInterval.Second, CDate(txtTempoSetupMaquina.Text)) / 60)), _
                                                               IIf(txtReferencia.Value = 0, 0, ((DatePart(DateInterval.Hour, CDate(txtTempoMaoObra.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtTempoMaoObra.Text)) + (DatePart(DateInterval.Second, CDate(txtTempoMaoObra.Text)) / 60)) / txtReferencia.Value), _
                                                               IIf(txtReferencia.Value = 0, 0, ((DatePart(DateInterval.Hour, CDate(txtTempoMaquina.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtTempoMaquina.Text)) + (DatePart(DateInterval.Second, CDate(txtTempoMaquina.Text)) / 60)) / txtReferencia.Value), _
                                                               txtReferencia.Value, _
                                                               IIf(cboAponta.Enabled = True, cboAponta.SelectedValue, False), _
                                                               IIf(cboApontaEquipamento.Enabled = True, cboApontaEquipamento.SelectedValue, False), _
                                                               IIf(cboApontamentoConcorrente.Enabled = True, cboApontamentoConcorrente.SelectedValue, False), _
                                                               IIf(cboControlaQualidade.Enabled = True, cboControlaQualidade.SelectedValue, False), _
                                                               txtObservacao.Text.Trim, _
                                                               grdRoteiro.CurrentRow.Cells("sequencia").Value)

            Else

                'Insere Registro
                Call oClsCadRoteiroProducao.InsertRoteiroLinha(btnSalvar.Tag, _
                                                               txtSequencia.Value, _
                                                               cboCentroTrabalho.SelectedValue, _
                                                               cboOperacao.SelectedValue, _
                                                               IIf(cboSequenciaPredecessora.SelectedIndex = -1, -1, cboSequenciaPredecessora.Text), _
                                                               cboReferenciaMolde.SelectedValue, _
                                                               ((DatePart(DateInterval.Hour, CDate(txtTempoSetupMaquina.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtTempoSetupMaquina.Text)) + (DatePart(DateInterval.Second, CDate(txtTempoSetupMaquina.Text)) / 60)), _
                                                               IIf(txtReferencia.Value = 0, 0, ((DatePart(DateInterval.Hour, CDate(txtTempoMaoObra.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtTempoMaoObra.Text)) + (DatePart(DateInterval.Second, CDate(txtTempoMaoObra.Text)) / 60)) / txtReferencia.Value), _
                                                               IIf(txtReferencia.Value = 0, 0, ((DatePart(DateInterval.Hour, CDate(txtTempoMaquina.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtTempoMaquina.Text)) + (DatePart(DateInterval.Second, CDate(txtTempoMaquina.Text)) / 60)) / txtReferencia.Value), _
                                                               txtReferencia.Value, _
                                                               IIf(cboAponta.Enabled = True, cboAponta.SelectedValue, False), _
                                                               IIf(cboApontaEquipamento.Enabled = True, cboApontaEquipamento.SelectedValue, False), _
                                                               IIf(cboApontamentoConcorrente.Enabled = True, cboApontamentoConcorrente.SelectedValue, False), _
                                                               IIf(cboControlaQualidade.Enabled = True, cboControlaQualidade.SelectedValue, False), _
                                                               txtObservacao.Text.Trim)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoRoteiro() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoRoteiro = False

            'Verifica se foi Selecionado o Campo - Item
            If ValidaCampo(txtSequencia, lblSequencia, True) = False Then
                Exit Function
            End If

            'Verifica se já existe o Item Inserido
            If grdRoteiro.GetDataRows.Count > 0 Then
                If IsNumeric(btnInserirRoteiro.Tag) Then
                    If VerificaExisteValorGrid(grdRoteiro, "sequencia", txtSequencia.Value, IIf(IsNumeric(btnInserirRoteiro.Tag), grdRoteiro.CurrentRow.RowIndex, grdRoteiro.CurrentRow.Cells("sequencia").Value)) = True Then
                        frmMain.errInfo.SetError(lblSequencia, "Esta Sequência: " & txtSequencia.Value & " já se encontra cadastrado para este Roteiro.")
                        txtSequencia.Focus()
                        Exit Function
                    End If
                Else
                    If VerificaExisteValorGrid(grdRoteiro, "sequencia", txtSequencia.Value, IIf(IsNumeric(btnInserirRoteiro.Tag), grdRoteiro.CurrentRow.RowIndex, -1)) = True Then
                        frmMain.errInfo.SetError(lblSequencia, "Esta Sequência: " & txtSequencia.Value & " já se encontra cadastrado para este Roteiro.")
                        txtSequencia.Focus()
                        Exit Function
                    End If
                End If
            End If

            'Verifica se foi Selecionado o Campo - Centro de Trabalho
            If ValidaCampo(cboCentroTrabalho, lblCentroTrabalho) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Operação
            If ValidaCampo(cboOperacao, lblOperacao) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Aponta
            If cboAponta.Enabled = True Then
                If ValidaCampo(cboAponta, lblAponta) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Aponta Equipamento
            If cboApontaEquipamento.Enabled = True Then
                If ValidaCampo(cboApontaEquipamento, lblApontaEquipamento) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Aponta Concorrente
            If cboApontamentoConcorrente.Enabled = True Then
                If ValidaCampo(cboApontamentoConcorrente, lblApontamentoConcorrente) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Controla Qualidade
            If ValidaCampo(cboControlaQualidade, lblControlaQualidade) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Referência Molde
            If ValidaCampo(cboReferenciaMolde, lblReferenciaMolde) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Tempo de Setup
            If ValidaCampo(txtTempoSetupMaquina, lblTempoSetupMaquina, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Tempo de Mão de Obra
            If ValidaCampo(txtTempoMaoObra, lblTempoMaoObra, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Tempo de Máquina
            If ValidaCampo(txtTempoMaquina, lblTempoMaquina, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Referência
            If ValidaCampo(txtReferencia, lblReferencia, False) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoRoteiro = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: MÁQUINA :::"

    Private Sub SalvarMaquina()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirMaquina.Tag) Then

                'Váriaveis
                Dim iCodigoRegistroAntigo As Long = -1

                'Seta Váriavel
                If IsNumeric(btnInserirMaquina.Tag) Then
                    iCodigoRegistroAntigo = grdMaquina.CurrentRow.Cells("codigo").Value
                End If

                'Atualiza Registro da tb_cad_roteiro_producao_item
                Call oClsCadRoteiroProducao.UpdateMaquina(btnSalvar.Tag, _
                                                          cboCodigoMaquina.SelectedValue, _
                                                          iCodigoRegistroAntigo)

            Else

                'Insere Registro na tb_cad_roteiro_producao_item
                Call oClsCadRoteiroProducao.InsertMaquina(btnSalvar.Tag, _
                                                          cboCodigoMaquina.SelectedValue)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteMaquina()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdMaquina) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Maquina
                    Call oClsCadRoteiroProducao.DeleteMaquina(btnSalvar.Tag)

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

    Private Sub EditarMaquina()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoRoteiroProducao, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoMaquina()

                'Carrega Controles
                cboCodigoMaquina.SelectedValue = grdMaquina.CurrentRow.Cells("codigo").Value
                btnInserirMaquina.Tag = grdMaquina.CurrentRow.RowIndex

                'Seta Focu
                cboCodigoMaquina.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoMaquina()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles           
            cboCodigoMaquina.SelectedIndex = -1
            txtDescricaoMaquina.Text = ""
            btnInserirMaquina.Tag = ""

            'Seta Focu
            cboCodigoMaquina.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoMaquina() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoMaquina = False

            'Verifica se foi Selecionado o Campo - Tipo de Maquina
            If ValidaCampo(cboCodigoMaquina, lblCodigoMaquina) = False Then
                Exit Function
            End If

            'Verifica se o Maquina é Válido
            If IsNumeric(btnInserirMaquina.Tag) Then
                If VerificaExisteValorGrid(grdMaquina, "codigo", cboCodigoMaquina.SelectedValue, grdMaquina.CurrentRow.RowIndex) Then
                    frmMain.errInfo.SetError(lblCodigoMaquina, "Esta Máquina: " & cboCodigoMaquina.Text & " já está associado a Máquina: " & txtCodigo.Text.Trim & ".")
                    cboCodigoMaquina.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdMaquina, "codigo", cboCodigoMaquina.SelectedValue, -1) Then
                    frmMain.errInfo.SetError(lblCodigoMaquina, "Esta Máquina: " & cboCodigoMaquina.Text & " já está associado a Máquina: " & txtCodigo.Text.Trim & ".")
                    cboCodigoMaquina.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoMaquina = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class