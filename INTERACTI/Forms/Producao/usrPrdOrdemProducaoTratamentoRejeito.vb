Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class usrPrdOrdemProducaoTratamentoRejeito

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsPrdOrdemProducaoTratamentoRejeito As New clsUsrPrdOrdemProducaoTratamentoRejeito

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrPrdOrdemProducaoTratamentoRejeito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCentroTrabalho" : Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa, False)
                        Case "cboOperacao" : Call cboCentroTrabalho_SelectedIndexChanged(cboCentroTrabalho, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F3

                    Select Case sender.Name
                    End Select

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboCentroTrabalho" : Call btnCadastrarCentroTrabalho_Click(btnCadastrarCentroTrabalho, System.EventArgs.Empty)
                        Case "cboOperacao" : Call btnCadastrarOperacao_Click(btnCadastrarOperacao, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrPrdOrdemProducaoTratamentoRejeito_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: TRATAMENTO REJEITO :::"

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
            oForm.NomeFormulario = Formulario.ProducaoOrdemProducaoTratamentoRejeito
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ProducaoOrdemProducaoTratamentoRejeito)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Try

            'Exporta Grid para Excel
            ' Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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

            'Verifica se a Célula clicada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "retrabalho" : Call Retrabalho()
                Case "perda" : Call Perda()
                Case "reposicao" : Call Reposicao()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ProducaoOrdemProducaoTratamentoRejeito, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.ProducaoOrdemProducaoTratamentoRejeito)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.ProducaoOrdemProducaoTratamentoRejeito, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: RETRABALHO :::"

#Region "::: DADOS RETRABALHO :::"

    Private Sub btnGerarOrdemProducao_Click(sender As Object, e As EventArgs) Handles btnGerarOrdemProducao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If ValidacaoRetrabalho() = True Then

                'Verifica se o usuário deseja reprovar
                If MsgBox("Deseja Gerar Ordem de Produção (Retrabalho)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    'Salva Dados de Qualidade
                    Call SalvarRetrabalho()

                    'Desabilita Controles
                    btnGerarOrdemProducao.Enabled = False

                End If

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
            tabMain.TabPages.Remove(pagRetrabalho)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub tabDados_SelectedTabChanged(sender As Object, e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabDados.SelectedTabChanged

        Try

            'Verifica Página Atual
            Select Case e.Page.Key

                Case "pagQualidade"
                    cboRoteiro.Items.Clear()
                    For Each oRow As GridEXRow In grdRoteiro.GetDataRows
                        If oRow.Cells("controla_qualidade").Value = True Then
                            cboRoteiro.Items.Add(oRow.Cells("sequencia").Value, oRow.Cells("sequencia").Value)
                        End If
                    Next

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ROTEIRO :::"

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
            oForm.NomeFormulario = Formulario.ProducaoOrdemProducaoTratamentoRejeito
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdRoteiro, Formulario.ProducaoOrdemProducaoTratamentoRejeito)

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

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Roteiro
            If ValidacaoRoteiro() = True Then

                'Váriaveis Locais
                Dim sCentroTrabalho As String = ""
                Dim sDescricaoCentroTrabalho As String = ""
                Dim sOperacao As String = ""
                Dim sDescricaoOperacao As String = ""
                Dim iSequenciaAntiga As Integer = -1

                'Carrega Váriavel
                If IsNumeric(btnInserir.Tag) Then
                    iSequenciaAntiga = grdRoteiro.CurrentRow.Cells("sequencia").Value
                End If

                'Carrega Váriaveis
                Call oClsPrdOrdemProducaoTratamentoRejeito.LoadDadosOperacao(cboOperacao.SelectedValue, _
                                                                             sCentroTrabalho, _
                                                                             sDescricaoCentroTrabalho, _
                                                                             sOperacao, _
                                                                             sDescricaoOperacao)

                'Insere / Atualiza Roteiro (Grid)
                Call InsertRoteiro(grdRoteiro, _
                                   txtSequencia.Text.Trim, _
                                   sCentroTrabalho, _
                                   sDescricaoCentroTrabalho, _
                                   cboCentroTrabalho.SelectedValue, _
                                   sOperacao, _
                                   sDescricaoOperacao, _
                                   cboOperacao.SelectedValue, _
                                   IIf(cboSequenciaPredecessora.SelectedIndex = -1, -1, cboSequenciaPredecessora.SelectedValue), _
                                   cboAponta.SelectedValue, _
                                   cboApontaEquipamento.SelectedValue, _
                                   cboApontamentoConcorrente.SelectedValue, _
                                   cboControlaQualidade.SelectedValue, _
                                   txtTempoSetupMaquina.Text, _
                                   txtTempoMaoObra.Text, _
                                   txtTempoMaquina.Text, _
                                   txtReferencia.Value, _
                                   txtObservacao.Text.Trim, _
                                   iSequenciaAntiga)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoRoteiro()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Roteiro
            Call DeleteRoteiro()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCentroTrabalho_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentroTrabalho.SelectedIndexChanged

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
            Else
                If cboAponta.SelectedValue = False Then
                    cboApontaEquipamento.Enabled = False : cboApontaEquipamento.SelectedIndex = -1
                Else
                    cboApontaEquipamento.Enabled = True
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
                                     Formulario.ProducaoOrdemProducaoTratamentoRejeito)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRoteiro_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdRoteiro.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRoteiro.Name, _
                                     Formulario.ProducaoOrdemProducaoTratamentoRejeito, _
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
                                          Formulario.ProducaoOrdemProducaoTratamentoRejeito, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: QUALIDADE :::"

    Private Sub btnAgruparGridQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridQualidade.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdQualidade.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdQualidade.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdQualidade.GroupByBoxVisible = True
                grdQualidade.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridQualidade.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdQualidade
            oForm.NomeFormulario = Formulario.ProducaoOrdemProducaoTratamentoRejeito
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdQualidade, Formulario.ProducaoOrdemProducaoTratamentoRejeito)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCaracteristicaInspecionarQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCaracteristicaInspecionarQualidade.Click

        Try
            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadQualidadeCaracteristicaInspecionar")
         
            'Carrega Combo
            Call LoadCombo(cboCaracteristicaInspecionarQualidade, "sp_select_combo_cadastro_basico_qualidade_caracteristicas_inspecionar " & goUsuario.iEmpresa)

            'Seta Focu
            cboCaracteristicaInspecionarQualidade.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirQualidade.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoQualidade() = True Then

                'Váriveis Locais
                Dim iSequenciaAntiga As Integer = -1
                Dim iCodigoCaracteristicaInspecionarAntigo As Integer = -1

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserirQualidade.Tag) Then
                    iSequenciaAntiga = grdQualidade.CurrentRow.Cells("sequencia").Value
                    iCodigoCaracteristicaInspecionarAntigo = grdQualidade.CurrentRow.Cells("codigo_caracteristica_inspecionar").Value
                End If

                'Insere / Atualiza Qualidade (Grid)
                Call InsertQualidade(grdQualidade, _
                                     cboRoteiro.SelectedValue, _
                                     cboCaracteristicaInspecionarQualidade.SelectedValue, _
                                     IIf(txtValorNominalQualidade.Enabled = False, QualidadeTipoCaracteristicaInspecionar.SimNao, QualidadeTipoCaracteristicaInspecionar.Valor), _
                                     cboCaracteristicaInspecionarQualidade.Text, _
                                     txtValorNominalQualidade.Value, _
                                     txtValorMinimoQualidade.Value, _
                                     txtValorMaximoQualidade.Value, _
                                     txtFrequenciaQualidade.Value, _
                                     txtObservacaoQualidade.Text.Trim, _
                                     iSequenciaAntiga, _
                                     iCodigoCaracteristicaInspecionarAntigo)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoQualidade()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirQualidade.Click

        Try

            'Deleta Qualidade
            Call DeleteQualidade()

            'Limpa Formulário
            Call NovoQualidade()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCaracteristicaInspecionarQualidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCaracteristicaInspecionarQualidade.SelectedIndexChanged

        Try

            'Desabilita Controles
            txtValorNominalQualidade.Value = 0 : txtValorNominalQualidade.Enabled = False
            txtValorMinimoQualidade.Value = 0 : txtValorMinimoQualidade.Enabled = False
            txtValorMaximoQualidade.Value = 0 : txtValorMaximoQualidade.Enabled = False

            'Verifica se foi Selecionado algum Registro
            If cboCaracteristicaInspecionarQualidade.SelectedIndex > -1 Then

                'Váriaveis Locais
                Dim iCodigoTipoCaracteristicaInspecionar As Integer = CType(LoadDescricao("sp_select_cadastro_basico_qualidade_caracteristicas_inspecionar_tipo " & cboCaracteristicaInspecionarQualidade.SelectedValue & ", " & goUsuario.iEmpresa), Integer)

                'Verifica se é do Tipo Valor
                If iCodigoTipoCaracteristicaInspecionar = QualidadeTipoCaracteristicaInspecionar.Valor Then
                    'Habilita Controles
                    txtValorNominalQualidade.Enabled = True
                    txtValorMinimoQualidade.Enabled = True
                    txtValorMaximoQualidade.Enabled = True
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidade_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdQualidade.RowDoubleClick

        Try

            'Verifica se a célula pressionada é válida
            If IsNothing(grdQualidade.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdQualidade.CurrentColumn.Key

                Case "editar" : Call EditarQualidade()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidade_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdQualidade.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdQualidade, _
                                     Formulario.ProducaoOrdemProducaoTratamentoRejeito)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidade_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdQualidade.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdQualidade.Name, _
                                     Formulario.ProducaoOrdemProducaoTratamentoRejeito, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidade_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdQualidade.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdQualidade.Name, _
                                          Formulario.ProducaoOrdemProducaoTratamentoRejeito, _
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

#Region "::: PERDA :::"

    Private Sub btnPerda_Click(sender As Object, e As EventArgs) Handles btnPerda.Click

        Try

            'Valida Formulário
            If ValidacaoPerda() = True Then

                'Verifica se o usuário deseja reprovar
                If MsgBox("Deseja Enviar para Perda a Quantidade Informada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    'Salva Perda
                    Call SalvarPerda()

                    'Informa o usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                    'Desabilita Controles
                    btnPerda.Enabled = False

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltarPerda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltarPerda.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagPerda)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: REPOSIÇÃO :::"

    Private Sub btnReposicao_Click(sender As Object, e As EventArgs) Handles btnReposicao.Click

        Try

            'Valida Formulário
            If ValidacaoReposicao() = True Then

                'Verifica se o usuário deseja reprovar
                If MsgBox("Deseja Gerar Ordem de Produção de Reposição?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    'Salva Perda
                    Call SalvarReposicao()

                    'Informa o usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                    'Desabilita Controles
                    btnReposicao.Enabled = False

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltarReposicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltarReposicao.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagReposicao)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrPrdOrdemProducaoTratamentoRejeito_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnInserir.Enabled = VerificaDireito(Formulario.ProducaoOrdemProducaoTratamentoRejeito, gcDelete)
            btnExcluir.Enabled = VerificaDireito(Formulario.ProducaoOrdemProducaoTratamentoRejeito, gcInsert)
            btnInserirQualidade.Enabled = VerificaDireito(Formulario.ProducaoOrdemProducaoTratamentoRejeito, gcDelete)
            btnExcluirQualidade.Enabled = VerificaDireito(Formulario.ProducaoOrdemProducaoTratamentoRejeito, gcInsert)

            'Verifica Direito - Botão Cadastro            
            btnCadastrarCentroTrabalho.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)
            btnCadastrarOperacao.Enabled = VerificaDireito(Formulario.CadastroBasicoOperacao, gcInsert)
            btnCadastrarCaracteristicaInspecionarQualidade.Enabled = VerificaDireito(Formulario.CadastroBasicoQualidadeCaracteristicasInspecionar, gcInsert)

            'Seta Controles
            dtpDataInicioFiltro.Value = Now.Date : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboCentroTrabalhoFiltro : oComboBox(1) = cboCentroTrabalho
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboOperacaoFiltro, "sp_select_combo_cadastro_basico_operacao -1, " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCaracteristicaInspecionarQualidade, "sp_select_combo_cadastro_basico_qualidade_caracteristicas_inspecionar " & goUsuario.iEmpresa, False)
            Call LoadComboSimNao(cboAponta)
            Call LoadComboSimNao(cboApontamentoConcorrente)
            Call LoadComboSimNao(cboApontaEquipamento)
            Call LoadComboSimNao(cboControlaQualidade)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ProducaoOrdemProducaoTratamentoRejeito)
            Call ConfiguraGrid(grdRoteiro, Formulario.ProducaoOrdemProducaoTratamentoRejeito)
            Call ConfiguraGrid(grdQualidade, Formulario.ProducaoOrdemProducaoTratamentoRejeito)

            'Remove Aba
            tabMain.TabPages.Remove(pagRetrabalho)
            tabMain.TabPages.Remove(pagPerda)
            tabMain.TabPages.Remove(pagReposicao)

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

#Region "::: TRATAMENTO - REJEITO :::"

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor = Cursors.WaitCursor

            'Carrega Grid
            Call oClsPrdOrdemProducaoTratamentoRejeito.LoadGridOrdemProducao(grdListagem, _
                                                                             txtNumeroDocumentoFiltro.Text.Trim, _
                                                                             IIf(IsNumeric(txtSequenciaFiltro.Text.Trim), txtSequenciaFiltro.Text.Trim, -1), _
                                                                             IIf(cboCentroTrabalhoFiltro.SelectedIndex = -1, -1, cboCentroTrabalhoFiltro.SelectedValue), _
                                                                             IIf(cboOperacaoFiltro.SelectedIndex = -1, -1, cboOperacaoFiltro.SelectedValue), _
                                                                             txtProdutoFiltro.Text.Trim, _
                                                                             IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                                                             IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""))

            'Seta Cursor do Mouse
            Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: RETRABALHO :::"

#Region "::: DADOS RETRABALHO :::"

    Private Sub Retrabalho()

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(Formulario.ProducaoOrdemProducaoTratamentoRejeito, gcInsert) = True Then

                'Carrega Controles
                txtOrdemProducao.Text = grdListagem.CurrentRow.Cells("ordem_producao").Value
                txtProduto.Text = grdListagem.CurrentRow.Cells("codigo_produto").Value + " - " + grdListagem.CurrentRow.Cells("descricao").Value
                txtRejeito.Text = grdListagem.CurrentRow.Cells("rejeito").Value
                txtQuantidade.Value = 0

                'Limpa Controles - Roteiro
                grdRoteiro.DataSource = Nothing
                txtSequencia.Value = grdRoteiro.GetDataRows.Count + 1
                cboCentroTrabalho.SelectedIndex = -1
                cboOperacao.SelectedIndex = -1
                cboSequenciaPredecessora.SelectedIndex = -1
                txtObservacao.Text = ""
                cboAponta.SelectedIndex = -1 : cboAponta.Enabled = True
                cboApontaEquipamento.SelectedIndex = -1 : cboApontaEquipamento.Enabled = True
                cboControlaQualidade.SelectedIndex = -1
                txtTempoSetupMaquina.Text = "00:00:00"
                txtTempoMaquina.Text = "00:00:00"
                txtTempoMaoObra.Text = "00:00:00"
                txtReferencia.Value = 0
                btnInserir.Tag = ""                

                'Limpa Controles 
                cboRoteiro.SelectedIndex = -1
                cboCaracteristicaInspecionarQualidade.SelectedIndex = -1
                txtValorNominalQualidade.Value = 0
                txtValorMinimoQualidade.Value = 0
                txtValorMaximoQualidade.Value = 0
                txtFrequenciaQualidade.Value = 0
                txtObservacaoQualidade.Text = ""
                btnInserirQualidade.Tag = ""
                grdQualidade.DataSource = Nothing

                'Seta Controle
                btnGerarOrdemProducao.Enabled = VerificaDireito(Formulario.ProducaoOrdemProducaoTratamentoRejeito, gcInsert)

                'Foca Aba
                tabDados.SelectedTab = pagRoteiro

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagRetrabalho)

                'Seta Focu
                txtSequencia.Focus()

            Else
                'Informa o Usuário que ele não possui Direito
                frmMain.Informacao(Mensagem.DireitoInserir)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    
    Private Sub SalvarRetrabalho()

        Try

            'Váriaveis
            Dim lCodigoOrdemProducao As Long = -1

            'Insere Ordem de Produção - Retrabalho
            Call oClsPrdOrdemProducaoTratamentoRejeito.InsertOrdemProducaoRetrabalho(grdListagem.CurrentRow.Cells("codigo_ordem_producao").Value, _
                                                                                     grdListagem.CurrentRow.Cells("sequencia").Value, _
                                                                                     grdListagem.CurrentRow.Cells("codigo").Value, _
                                                                                     txtQuantidade.Value, _
                                                                                     lCodigoOrdemProducao)

            'Insere Apontamento
            Call oClsPrdOrdemProducaoTratamentoRejeito.InsertRoteiroRetrabalho(lCodigoOrdemProducao, grdRoteiro)

            'Insere Qualidade
            Call oClsPrdOrdemProducaoTratamentoRejeito.InsertQualidadeRoteiroRetrabalho(lCodigoOrdemProducao, grdQualidade)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoRetrabalho() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoRetrabalho = False

            'Verifica se foi Preenchido o Roteiro
            If grdRoteiro.GetDataRows.Count = 0 Then
                frmMain.Informacao(Mensagem.ValidacaoInserir, "Roteiro de Produção")
                Exit Function
            End If

            'Verifica se foi Informado a Quantidade
            If ValidaCampo(txtQuantidade, lblQuantidade, True) = False Then
                Exit Function
            End If

            'Verifica se a Quantidade Informada é Maior que a Quantidade - Rejeito
            If txtQuantidade.Value > grdListagem.CurrentRow.Cells("quantidade_pendente").Value Then
                frmMain.errInfo.SetError(lblQuantidade, "A Quantidade informada para Retrabalho não pode ser maior que a Quantidade do Rejeito.")
                txtQuantidade.Focus()
                Exit Function
            End If

            'Verifica se foi Inserido algum Roteiro
            If grdRoteiro.GetDataRows.Count = 0 Then
                frmMain.Informacao(Mensagem.ValidacaoInserir, "Roteiro de Produção")
                tabDados.SelectedTab = pagRoteiro
                txtSequencia.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoRetrabalho = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ROTEIRO :::"

    Private Sub NovoRoteiro()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Roteiro
            txtSequencia.Value = grdRoteiro.GetDataRows.Count + 1
            cboCentroTrabalho.SelectedIndex = -1
            cboOperacao.SelectedIndex = -1
            cboSequenciaPredecessora.SelectedIndex = -1
            txtObservacao.Text = ""
            cboAponta.SelectedIndex = -1 : cboAponta.Enabled = True
            cboApontaEquipamento.SelectedIndex = -1 : cboApontaEquipamento.Enabled = True
            cboControlaQualidade.SelectedIndex = -1
            txtTempoSetupMaquina.Text = "00:00:00"
            txtTempoMaquina.Text = "00:00:00"
            txtTempoMaoObra.Text = "00:00:00"
            txtReferencia.Value = 0
            btnInserir.Tag = ""

            'Carrega Combo
            cboSequenciaPredecessora.DataSource = Nothing : cboSequenciaPredecessora.Text = ""
            For Each oRow As GridEXRow In grdRoteiro.GetDataRows
                cboSequenciaPredecessora.Items.Add(oRow.Cells("sequencia").Value, oRow.Cells("sequencia").Value)
            Next

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
                    For Each oRow As GridEXRow In gSelecaoRow
                        oRow.Delete()
                    Next

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

    Private Sub InsertRoteiro(ByVal oGrid As GridEX, _
                              ByVal iSequencia As Integer, _
                              ByVal sCentroTrabalho As String, _
                              ByVal sDescricaoCentroTrabalho As String, _
                              ByVal iCodigoCentroTrabalho As Integer, _
                              ByVal sOperacao As String, _
                              ByVal sDescricaoOperacao As String, _
                              ByVal iCodigoOperacao As Integer, _
                              ByVal iSequenciaPredecessora As Integer, _
                              ByVal bAponta As Boolean, _
                              ByVal bApontaEquipamento As Boolean, _
                              ByVal bApontamentoConcorrente As Boolean, _
                              ByVal bControlaQualidade As Boolean, _
                              ByVal dTempoSetupMaquina As String, _
                              ByVal dTempoMaoObra As String, _
                              ByVal dTempoMaquina As String, _
                              ByVal iReferencia As Integer, _
                              ByVal sObservacao As String, _
                              ByVal iSequenciaAntiga As Integer)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCSequencia As New DataColumn("sequencia")
            Dim oDCCentroTrabalho As New DataColumn("centro_trabalho")
            Dim oDCDescricaoCentroTrabalho As New DataColumn("descricao_centro_trabalho")
            Dim oDCCodigoCentroTrabalho As New DataColumn("codigo_centro_trabalho")
            Dim oDCOperacao As New DataColumn("operacao")
            Dim oDCDescricaoOperacao As New DataColumn("descricao_operacao")
            Dim oDCCodigoOperacao As New DataColumn("codigo_operacao")
            Dim oDCSequenciaPredecessora As New DataColumn("sequencia_predecessora")
            Dim oDCAponta As New DataColumn("aponta")
            Dim oDCApontaEquipamento As New DataColumn("aponta_equipamento")
            Dim oDCApontamentoConcorrente As New DataColumn("apontamento_concorrente")
            Dim oDCControlaQualidade As New DataColumn("controla_qualidade")
            Dim oDCTempoSetupMaquina As New DataColumn("tempo_setup_maquina")
            Dim oDCTempoMaoObra As New DataColumn("tempo_mao_obra")
            Dim oDCTempoMaquina As New DataColumn("tempo_maquina")
            Dim oDCReferenciaProduto As New DataColumn("referencia_produto")
            Dim oDCObservacao As New DataColumn("observacao")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCSequencia)
                oDataTable.Columns.Add(oDCCentroTrabalho)
                oDataTable.Columns.Add(oDCDescricaoCentroTrabalho)
                oDataTable.Columns.Add(oDCCodigoCentroTrabalho)
                oDataTable.Columns.Add(oDCOperacao)
                oDataTable.Columns.Add(oDCDescricaoOperacao)
                oDataTable.Columns.Add(oDCCodigoOperacao)
                oDataTable.Columns.Add(oDCSequenciaPredecessora)
                oDataTable.Columns.Add(oDCAponta)
                oDataTable.Columns.Add(oDCApontaEquipamento)
                oDataTable.Columns.Add(oDCApontamentoConcorrente)
                oDataTable.Columns.Add(oDCControlaQualidade)
                oDataTable.Columns.Add(oDCTempoSetupMaquina)
                oDataTable.Columns.Add(oDCTempoMaoObra)
                oDataTable.Columns.Add(oDCTempoMaquina)
                oDataTable.Columns.Add(oDCReferenciaProduto)
                oDataTable.Columns.Add(oDCObservacao)
                'Seta DataType
                oDCAponta.DataType = False.GetType
                oDCApontaEquipamento.DataType = False.GetType
                oDCApontamentoConcorrente.DataType = False.GetType
                oDCControlaQualidade.DataType = False.GetType
                oDCReferenciaProduto.DataType = 0.GetType
            End If

            'Verifica o Tipo de Operação
            If iSequenciaAntiga = -1 Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("sequencia") = iSequencia
                oDataRow("centro_trabalho") = sCentroTrabalho
                oDataRow("descricao_centro_trabalho") = sDescricaoCentroTrabalho
                oDataRow("codigo_centro_trabalho") = iCodigoCentroTrabalho
                oDataRow("operacao") = sOperacao
                oDataRow("descricao_operacao") = sDescricaoOperacao
                oDataRow("codigo_operacao") = iCodigoOperacao
                oDataRow("sequencia_predecessora") = IIf(iSequenciaPredecessora = -1, DBNull.Value, iSequenciaPredecessora)
                oDataRow("aponta") = bAponta
                oDataRow("aponta_equipamento") = bApontaEquipamento
                oDataRow("apontamento_concorrente") = bApontamentoConcorrente
                oDataRow("controla_qualidade") = bControlaQualidade
                oDataRow("tempo_setup_maquina") = dTempoSetupMaquina
                oDataRow("tempo_mao_obra") = dTempoMaoObra
                oDataRow("tempo_maquina") = dTempoMaquina
                oDataRow("referencia_produto") = iReferencia
                oDataRow("observacao") = sObservacao
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(sequencia = " & iSequenciaAntiga & ")")(0)
                oDataRow("sequencia") = iSequencia
                oDataRow("centro_trabalho") = sCentroTrabalho
                oDataRow("descricao_centro_trabalho") = sDescricaoCentroTrabalho
                oDataRow("codigo_centro_trabalho") = iCodigoCentroTrabalho
                oDataRow("operacao") = sOperacao
                oDataRow("descricao_operacao") = sDescricaoOperacao
                oDataRow("codigo_operacao") = iCodigoOperacao
                oDataRow("sequencia_predecessora") = IIf(iSequenciaPredecessora = -1, DBNull.Value, iSequenciaPredecessora)
                oDataRow("aponta") = bAponta
                oDataRow("aponta_equipamento") = bApontaEquipamento
                oDataRow("apontamento_concorrente") = bApontamentoConcorrente
                oDataRow("controla_qualidade") = bControlaQualidade
                oDataRow("tempo_setup_maquina") = dTempoSetupMaquina
                oDataRow("tempo_mao_obra") = dTempoMaoObra
                oDataRow("tempo_maquina") = dTempoMaquina
                oDataRow("referencia_produto") = iReferencia
                oDataRow("observacao") = sObservacao
            End If

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch ex As Exception
            'Trata Erro
            Throw ex
        End Try

    End Sub

    Private Sub EditarRoteiro()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ProducaoOrdemProducaoTratamentoRejeito, gcUpdate) = True Then

                'Carrega Controles
                txtSequencia.Value = grdRoteiro.CurrentRow.Cells("sequencia").Value
                cboCentroTrabalho.SelectedValue = grdRoteiro.CurrentRow.Cells("codigo_centro_trabalho").Value
                cboOperacao.SelectedValue = grdRoteiro.CurrentRow.Cells("codigo_operacao").Value
                cboSequenciaPredecessora.SelectedValue = grdRoteiro.CurrentRow.Cells("sequencia_predecessora").Value
                cboAponta.SelectedValue = grdRoteiro.CurrentRow.Cells("aponta").Value
                cboApontaEquipamento.SelectedValue = grdRoteiro.CurrentRow.Cells("aponta_equipamento").Value
                cboApontamentoConcorrente.SelectedValue = grdRoteiro.CurrentRow.Cells("apontamento_concorrente").Value
                cboControlaQualidade.SelectedValue = grdRoteiro.CurrentRow.Cells("controla_qualidade").Value
                txtTempoSetupMaquina.Text = grdRoteiro.CurrentRow.Cells("tempo_setup_maquina").Value
                txtTempoMaoObra.Text = grdRoteiro.CurrentRow.Cells("tempo_mao_obra").Value
                txtTempoMaquina.Text = grdRoteiro.CurrentRow.Cells("tempo_maquina").Value
                txtReferencia.Value = grdRoteiro.CurrentRow.Cells("referencia_produto").Value
                txtObservacao.Text = IIf(IsDBNull(grdRoteiro.CurrentRow.Cells("observacao").Value), "", grdRoteiro.CurrentRow.Cells("observacao").Value)
                btnInserir.Tag = grdRoteiro.CurrentRow.RowIndex

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

    Private Function ValidacaoRoteiro() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoRoteiro = False

            'Verifica se foi Selecionado o Campo - Item
            If ValidaCampo(txtSequencia, lblSequencia, True) = False Then
                Exit Function
            End If

            'Verifica se já existe o Item Inserido
            Dim iRowExcessao As Integer = IIf(IsNumeric(btnInserir.Tag), btnInserir.Tag, -1)
            If grdRoteiro.GetDataRows.Count > 0 Then
                If VerificaExisteValorGrid(grdRoteiro, "sequencia", txtSequencia.Value, iRowExcessao) = True Then
                    frmMain.errInfo.SetError(lblSequencia, "Esta Sequência: " & txtSequencia.Value & " já se encontra cadastrado para este Roteiro.")
                    txtSequencia.Focus()
                    Exit Function
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

            'Verifica se foi Selecionado o Campo - Apontamento Concorrente
            If cboApontamentoConcorrente.Enabled = True Then
                If ValidaCampo(cboApontamentoConcorrente, lblApontamentoConcorrente) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Controla Qualidade
            If cboControlaQualidade.Enabled = True Then
                If ValidaCampo(cboControlaQualidade, lblControlaQualidade) = False Then
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoRoteiro = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: QUALIDADE :::"

    Private Sub NovoQualidade()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles 
            cboRoteiro.SelectedIndex = -1
            cboCaracteristicaInspecionarQualidade.SelectedIndex = -1
            txtValorNominalQualidade.Value = 0
            txtValorMinimoQualidade.Value = 0
            txtValorMaximoQualidade.Value = 0
            txtFrequenciaQualidade.Value = 0
            txtObservacaoQualidade.Text = ""
            btnInserirQualidade.Tag = ""

            'Seta Focu
            cboRoteiro.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteQualidade()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdQualidade) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Registro
                    For Each oRow As GridEXRow In gSelecaoRow
                        oRow.Delete()
                    Next

                    'Limpa Formulário
                    Call NovoQualidade()

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

    Private Sub InsertQualidade(ByVal oGrid As GridEX, _
                                ByVal iSequencia As Integer, _
                                ByVal iCodigoCaracteristicaInspecionar As Integer, _
                                ByVal iCodigoTipoCaracteristicaInspecionar As Integer, _
                                ByVal sCaracteristicaInspecionar As String, _
                                ByVal dValorNominal As Double, _
                                ByVal dValorMinimo As Double, _
                                ByVal dValorMaximo As Double, _
                                ByVal iFrequencia As Integer, _
                                ByVal sObservacao As String, _
                                ByVal iSequenciaAntiga As Integer, _
                                ByVal iCodigoCaracteristicaInspecionarAntigo As Integer)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCSequencia As New DataColumn("sequencia")
            Dim oDCCodigoCaracteristicaInspecionar As New DataColumn("codigo_caracteristica_inspecionar")
            Dim oDCCodigoTipoCaracteristicaInspecionar As New DataColumn("codigo_tipo_caracteristica_inspecionar")
            Dim oDCCaracteristicaInspecionar As New DataColumn("caracteristica_inspecionar")
            Dim oDCValorNominal As New DataColumn("valor_nominal")
            Dim oDCValorMinimo As New DataColumn("valor_minimo")
            Dim oDCValorMaximo As New DataColumn("valor_maximo")
            Dim oDCFrequencia As New DataColumn("frequencia")
            Dim oDCObservacao As New DataColumn("observacao")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCSequencia)
                oDataTable.Columns.Add(oDCCodigoCaracteristicaInspecionar)
                oDataTable.Columns.Add(oDCCodigoTipoCaracteristicaInspecionar)
                oDataTable.Columns.Add(oDCCaracteristicaInspecionar)
                oDataTable.Columns.Add(oDCValorNominal)
                oDataTable.Columns.Add(oDCValorMinimo)
                oDataTable.Columns.Add(oDCValorMaximo)
                oDataTable.Columns.Add(oDCFrequencia)
                oDataTable.Columns.Add(oDCObservacao)
                'Seta DataType
                oDCValorNominal.DataType = 0.0.GetType
                oDCValorMinimo.DataType = 0.0.GetType
                oDCValorMaximo.DataType = 0.0.GetType
                oDCFrequencia.DataType = 0.GetType
            End If

            'Verifica o Tipo de Operação
            If iSequenciaAntiga = -1 Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("sequencia") = iSequencia
                oDataRow("codigo_caracteristica_inspecionar") = iCodigoCaracteristicaInspecionar
                oDataRow("codigo_tipo_caracteristica_inspecionar") = iCodigoTipoCaracteristicaInspecionar
                oDataRow("caracteristica_inspecionar") = sCaracteristicaInspecionar
                oDataRow("valor_nominal") = IIf(iCodigoTipoCaracteristicaInspecionar = QualidadeTipoCaracteristicaInspecionar.Valor, dValorNominal, DBNull.Value)
                oDataRow("valor_minimo") = IIf(iCodigoTipoCaracteristicaInspecionar = QualidadeTipoCaracteristicaInspecionar.Valor, dValorMinimo, DBNull.Value)
                oDataRow("valor_maximo") = IIf(iCodigoTipoCaracteristicaInspecionar = QualidadeTipoCaracteristicaInspecionar.Valor, dValorMaximo, DBNull.Value)
                oDataRow("frequencia") = iFrequencia
                oDataRow("observacao") = sObservacao
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(sequencia = " & iSequenciaAntiga & ") AND (codigo_caracteristica_inspecionar = " & iCodigoCaracteristicaInspecionar & ")")(0)
                oDataRow("sequencia") = iSequencia
                oDataRow("codigo_caracteristica_inspecionar") = iCodigoCaracteristicaInspecionar
                oDataRow("codigo_tipo_caracteristica_inspecionar") = iCodigoTipoCaracteristicaInspecionar
                oDataRow("caracteristica_inspecionar") = sCaracteristicaInspecionar
                oDataRow("valor_nominal") = IIf(iCodigoTipoCaracteristicaInspecionar = QualidadeTipoCaracteristicaInspecionar.Valor, dValorNominal, DBNull.Value)
                oDataRow("valor_minimo") = IIf(iCodigoTipoCaracteristicaInspecionar = QualidadeTipoCaracteristicaInspecionar.Valor, dValorMinimo, DBNull.Value)
                oDataRow("valor_maximo") = IIf(iCodigoTipoCaracteristicaInspecionar = QualidadeTipoCaracteristicaInspecionar.Valor, dValorMaximo, DBNull.Value)
                oDataRow("frequencia") = iFrequencia
                oDataRow("observacao") = sObservacao
            End If

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch ex As Exception
            'Trata Erro
            Throw ex
        End Try

    End Sub

    Private Sub EditarQualidade()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ProducaoOrdemProducaoTratamentoRejeito, gcUpdate) = True Then

                'Carrega Controles
                cboRoteiro.SelectedValue = grdQualidade.CurrentRow.Cells("sequencia").Value
                cboCaracteristicaInspecionarQualidade.SelectedValue = grdQualidade.CurrentRow.Cells("codigo_caracteristica_inspecionar").Value
                If grdQualidade.CurrentRow.Cells("codigo_tipo_caracteristica_inspecionar").Value = CInt(QualidadeTipoCaracteristicaInspecionar.Valor) Then
                    txtValorNominalQualidade.Value = grdQualidade.CurrentRow.Cells("valor_nominal").Value
                    txtValorMinimoQualidade.Value = grdQualidade.CurrentRow.Cells("valor_minimo").Value
                    txtValorMaximoQualidade.Value = grdQualidade.CurrentRow.Cells("valor_maximo").Value
                End If
                txtFrequenciaQualidade.Value = grdQualidade.CurrentRow.Cells("frequencia").Value
                txtObservacaoQualidade.Text = grdQualidade.CurrentRow.Cells("observacao").Value
                btnInserirQualidade.Tag = grdQualidade.CurrentRow.RowIndex

                'Seta Focu
                cboCaracteristicaInspecionarQualidade.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoQualidade() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoQualidade = False

            'Verifica se foi Selecionado o Campo - Centro de Trabalho / Operação
            If ValidaCampo(cboRoteiro, lblRoteiro) = False Then
                cboRoteiro.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Caracteristicas a Inspecionar
            If ValidaCampo(cboCaracteristicaInspecionarQualidade, lblCaracteristicaInspecionarQualidade) = False Then
                cboCaracteristicaInspecionarQualidade.Focus()
                Exit Function
            End If

            'Verifica se a Característica é Válida
            Dim iCurrentRow As Integer = IIf(IsNumeric(btnInserirQualidade.Tag), btnInserirQualidade.Tag, -1)

            'Percorre Grid
            For Each oRow As GridEXRow In grdQualidade.GetDataRows
                If oRow.Cells("codigo_caracteristica_inspecionar").Value = cboCaracteristicaInspecionarQualidade.SelectedValue AndAlso _
                   oRow.Cells("sequencia").Value = cboRoteiro.SelectedValue AndAlso _
                   oRow.RowIndex <> iCurrentRow Then
                    frmMain.errInfo.SetError(lblCaracteristicaInspecionarQualidade, "Esta Característica: " & cboCaracteristicaInspecionarQualidade.Text & " já se encontra cadastrado para este Produto.")
                    cboCaracteristicaInspecionarQualidade.Focus()
                    Exit Function
                End If
            Next

            'Verifica se foi Preenchido o Campo - Valor Nominal
            If txtValorNominalQualidade.Enabled = True Then
                If ValidaCampo(txtValorNominalQualidade, lblValorNominalQualidade, True) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Valor Mínimo
            If txtValorMinimoQualidade.Enabled = True Then
                If ValidaCampo(txtValorMinimoQualidade, lblValorMinimoQualidade, True) = False Then
                    Exit Function
                ElseIf txtValorMinimoQualidade.Value > txtValorNominalQualidade.Value Then
                    frmMain.errInfo.SetError(lblValorMinimoQualidade, "O Valor Mínimo não pode ser maior que o Valor Nominal.")
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Valor Máximo
            If txtValorMaximoQualidade.Enabled = True Then
                If ValidaCampo(txtValorMaximoQualidade, lblValorMaximoQualidade, True) = False Then
                    Exit Function
                ElseIf txtValorMaximoQualidade.Value < txtValorNominalQualidade.Value Then
                    frmMain.errInfo.SetError(lblValorMaximoQualidade, "O Valor Máximo não pode ser menor que o Valor Nominal.")
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Frequencia
            If ValidaCampo(txtFrequenciaQualidade, lblFrequenciaQualidade, True) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoQualidade = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

#Region "::: PERDA :::"

    Private Sub Perda()

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(Formulario.ProducaoOrdemProducaoTratamentoRejeito, gcInsert) = True Then

                'Carrega Controles
                txtOrdemProducaoPerda.Text = grdListagem.CurrentRow.Cells("ordem_producao").Value
                txtProdutoPerda.Text = grdListagem.CurrentRow.Cells("codigo_produto").Value + " - " + grdListagem.CurrentRow.Cells("descricao").Value
                txtRejeitoPerda.Text = grdListagem.CurrentRow.Cells("rejeito").Value
                txtQuantidadePerda.Value = 0
                txtObservacaoPerda.Text = ""

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagPerda)

                'Seta Controle
                btnPerda.Enabled = VerificaDireito(Formulario.ProducaoOrdemProducaoTratamentoRejeito, gcInsert)

                'Seta Focu
                txtQuantidadePerda.Focus()

            Else
                'Informa o Usuário que ele não possui Direito
                frmMain.Informacao(Mensagem.DireitoInserir)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarPerda()

        Try

            'Insere a Perda
            Call oClsPrdOrdemProducaoTratamentoRejeito.InsertApontamentoRejeitoPerda(grdListagem.CurrentRow.Cells("codigo_ordem_producao").Value, _
                                                                                     grdListagem.CurrentRow.Cells("sequencia").Value, _
                                                                                     grdListagem.CurrentRow.Cells("sequencia_concorrente").Value, _
                                                                                     grdListagem.CurrentRow.Cells("codigo").Value, _
                                                                                     txtQuantidadePerda.Value, _
                                                                                     txtObservacaoPerda.Text.Trim)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoPerda() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoPerda = False

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadePerda, lblQuantidadePerda, True) = False Then
                Exit Function
            End If

            'Verifica se a Quantidade Informada é Maior que a Quantidade - Rejeito
            If txtQuantidadePerda.Value > grdListagem.CurrentRow.Cells("quantidade_pendente").Value Then
                frmMain.errInfo.SetError(lblQuantidadePerda, "A Quantidade informada para Perda não pode ser maior que a Quantidade do Rejeito.")
                txtQuantidadePerda.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoPerda = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: REPOSIÇÃO :::"

    Private Sub Reposicao()

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(Formulario.ProducaoOrdemProducaoTratamentoRejeito, gcInsert) = True Then

                'Carrega Controles
                txtOrdemProducaoReposicao.Text = grdListagem.CurrentRow.Cells("ordem_producao").Value
                txtProdutoReposicao.Text = grdListagem.CurrentRow.Cells("codigo_produto").Value + " - " + grdListagem.CurrentRow.Cells("descricao").Value
                txtRejeitoReposicao.Text = grdListagem.CurrentRow.Cells("rejeito").Value
                txtQuantidadeReposicao.Value = 0
                txtObservacaoReposicao.Text = ""

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagReposicao)

                'Seta Controle
                btnReposicao.Enabled = VerificaDireito(Formulario.ProducaoOrdemProducaoTratamentoRejeito, gcInsert)

                'Seta Focu
                txtQuantidadeReposicao.Focus()

            Else
                'Informa o Usuário que ele não possui Direito
                frmMain.Informacao(Mensagem.DireitoInserir)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarReposicao()

        Try

            'Insere a Perda
            Call oClsPrdOrdemProducaoTratamentoRejeito.InsertOrdemProducaoReposicao(grdListagem.CurrentRow.Cells("codigo_ordem_producao").Value, _
                                                                                    grdListagem.CurrentRow.Cells("sequencia").Value, _
                                                                                    grdListagem.CurrentRow.Cells("sequencia_concorrente").Value, _
                                                                                    grdListagem.CurrentRow.Cells("codigo").Value, _
                                                                                    txtQuantidadeReposicao.Value, _
                                                                                    txtObservacaoReposicao.Text.Trim)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoReposicao() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoReposicao = False

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadeReposicao, lblQuantidadeReposicao, True) = False Then
                Exit Function
            End If

            'Verifica se a Quantidade Informada é Maior que a Quantidade - Rejeito
            If txtQuantidadeReposicao.Value > grdListagem.CurrentRow.Cells("quantidade_pendente").Value Then
                frmMain.errInfo.SetError(lblQuantidadeReposicao, "A Quantidade informada para Reposicao não pode ser maior que a Quantidade do Rejeito.")
                txtQuantidadeReposicao.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoReposicao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class