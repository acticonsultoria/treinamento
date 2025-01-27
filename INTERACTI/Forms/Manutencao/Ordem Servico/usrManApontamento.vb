Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine

Public Class usrManApontamento

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsManApontamento As New clsUsrManApontamento

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrManApontamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F5
                    Select Case sender.Name
                        Case "cboNumeroOrdemServico" : Call LoadCombo(cboNumeroOrdemServico, "sp_select_combo_contrato " & goUsuario.iEmpresa)
                        Case "cboFuncionarioFiltro" : Call LoadCombo(cboFuncionarioFiltro, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa)
                        Case "cboFuncionario" : Call LoadCombo(cboFuncionario, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa)
                    End Select

                Case Keys.Oemplus, Keys.Add
                    Select Case sender.Name
                        Case "cboFuncionario" : Call btnCadastrarFuncionario_Click(btnCadastrarFuncionario, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrManApontamento_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: APONTAMENTO :::"

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
            oForm.NomeFormulario = Formulario.ManutencaoOrdemServicoApontamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ManutencaoOrdemServicoApontamento)

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

    Private Sub btnCadastrarFuncionario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarFuncionario.Click

        Try

           'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadFuncionario")

            'Carrega Combo          
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboFuncionarioFiltro : oComboBox(1) = cboFuncionario
            LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa)

            'Seta Focu
            cboFuncionario.Focus()

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

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Alterna Aba
            tabMain.TabPages.Add(pagDados)
            tabMain.TabPages.Remove(pagLista)

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

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
                'Prepara Formulário para Inserção de um Novo Registro
                Call Novo()

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

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Adiciona Aba
            tabMain.TabPages.Add(pagLista)
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroOrdemServicoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 4
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboNumeroOrdemServico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNumeroOrdemServico.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboNumeroOrdemServico.SelectedIndex = -1 Then

                'Limpa Controles
                txtNumeroRequisicao.Text = ""
                txtManutencao.Text = ""

            Else

                'Carrega Controles
                Call oClsManApontamento.LoadDadosOrdemServico(cboNumeroOrdemServico.SelectedValue, _
                                                              txtNumeroRequisicao, _
                                                              txtManutencao)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFuncionario.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboFuncionario.SelectedIndex = -1 Then
                'Limpa Controles
                cboAtividade.DataSource = Nothing : cboAtividade.Text = ""
            Else
                'Carrega Controles
                Call LoadCombo(cboAtividade, "sp_select_combo_cadastro_basico_funcionario_atividade " & cboFuncionario.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna Pressionada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()
                Case "imprimir" : Call Imprimir(grdListagem.CurrentRow.Cells("codigo_ordem_servico").Value, _
                                                grdListagem.CurrentRow.Cells("codigo").Value)
                Case "email" : Call Email(grdListagem.CurrentRow.Cells("codigo_ordem_servico").Value, _
                                          grdListagem.CurrentRow.Cells("codigo").Value, _
                                          grdListagem.CurrentRow.Cells("numero_ordem_servico").Value)

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
                                     Formulario.ManutencaoOrdemServicoApontamento)

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
                                     Formulario.ManutencaoOrdemServicoApontamento, _
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
                                          Formulario.ManutencaoOrdemServicoApontamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtInicioTrabalho_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInicioTrabalho.LostFocus

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Hora
            If ValidaCampo(txtInicioTrabalho, lblInicioTrabalho, TipoCampo.hora) = False Then
                Exit Sub
            End If

            If IsDate(txtTerminoTrabalho.Text) Then
                If IsDate(txtHoraParada.Text) Then
                    txtTotalHoraTrabalhada.Text = CalculoHoras(txtInicioTrabalho.Text, txtTerminoTrabalho.Text, txtHoraParada.Text)
                Else
                    txtTotalHoraTrabalhada.Text = CalculoHoras(txtInicioTrabalho.Text, txtTerminoTrabalho.Text)
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtTerminoTrabalho_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTerminoTrabalho.LostFocus

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Hora
            If ValidaCampo(txtTerminoTrabalho, lblTerminoTrabalho, TipoCampo.hora) = False Then
                Exit Sub
            End If

            If IsDate(txtInicioTrabalho.Text) Then
                If IsDate(txtHoraParada.Text) Then
                    txtTotalHoraTrabalhada.Text = CalculoHoras(txtInicioTrabalho.Text, txtTerminoTrabalho.Text, txtHoraParada.Text)
                Else
                    txtTotalHoraTrabalhada.Text = CalculoHoras(txtInicioTrabalho.Text, txtTerminoTrabalho.Text)
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtHoraParada_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHoraParada.LostFocus

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            If IsDate(txtInicioTrabalho.Text) And IsDate(txtTerminoTrabalho.Text) Then
                If IsDate(txtHoraParada.Text) Then
                    txtTotalHoraTrabalhada.Text = CalculoHoras(txtInicioTrabalho.Text, txtTerminoTrabalho.Text, txtHoraParada.Text)
                Else
                    txtTotalHoraTrabalhada.Text = CalculoHoras(txtInicioTrabalho.Text, txtTerminoTrabalho.Text)
                    txtHoraParada.Text = ""
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ATIVIDADES :::"

    Private Sub btnConfigurarGridAtividade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridAtividade.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdAtividade
            oForm.NomeFormulario = Formulario.ManutencaoOrdemServicoApontamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdAtividade, Formulario.ManutencaoOrdemServicoApontamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridAtividade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridAtividade.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdAtividade)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarAtividade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarAtividade.Click

        Try

           'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadAtividade")

            'Carrega Combo          
            LoadCombo(cboAtividade, "sp_select_combo_cadastro_basico_atividade " & goUsuario.iEmpresa)

            'Seta Focu
            cboAtividade.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirAtividade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirAtividade.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoAtividade() = True Then

                Dim iCodigoAntigo As Integer = -1

                If IsNumeric(btnInserirAtividade.Tag) Then
                    iCodigoAntigo = grdAtividade.CurrentRow.Cells("codigo").Value
                End If

                'Salva Dados do Registro
                Call InsertAtividade(grdAtividade, _
                                     cboAtividade.Text, _
                                     cboAtividade.SelectedValue, _
                                     iCodigoAntigo)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoAtividade()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirAtividade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirAtividade.Click

        Try

            'Deleta Atividade
            Call DeleteAtividade()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAtividade_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdAtividade.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdAtividade.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdAtividade.CurrentColumn.Key

                Case "editar" : Call EditarAtividade()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAtividade_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdAtividade.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdAtividade, _
                                     Formulario.ManutencaoOrdemServicoApontamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAtividade_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdAtividade.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdAtividade.Name, _
                                     Formulario.ManutencaoOrdemServicoApontamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnAgruparGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridArquivo.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdArquivo.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdArquivo.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdArquivo.GroupByBoxVisible = True
                grdArquivo.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridArquivo.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdArquivo
            oForm.NomeFormulario = Formulario.ComprasRequisicao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.ComprasRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridArquivo.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdArquivo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTipoArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTipoArquivo.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTipoArquivo")

            'Carrega Combo
            Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa)
            'Seta Focu
            cboTipoArquivo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Tipo de Arquivo
            If ValidaCampo(cboTipoArquivo, lblTipoArquivo) = False Then
                Exit Sub
            End If

            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.InitialDirectory = "c:\\dados"
            arqArquivo.Filter = LoadDescricao("sp_select_cadastro_basico_extensao_tipo_arquivo " & goUsuario.iEmpresa & "," & cboTipoArquivo.SelectedValue)
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

            If Validacao() = True Then

                'Salva Dados da Máquina
                Call Salvar()

                'Valida Dados do Formulário
                If ValidacaoArquivo() = True Then

                    If IsNumeric(btnInserirArquivo.Tag) = False Then

                        'Insere Arquivo
                        Call InsertArquivoBD("tb_man_apontamento", _
                                             txtDescricaoArquivo.Text.Trim, _
                                             txtRevisaoArquivo.Text.Trim, _
                                             txtArquivo.Text.Trim, _
                                             cboTipoArquivo.SelectedValue, _
                                             cboNumeroOrdemServico.SelectedValue, _
                                             btnSalvar.Tag)

                    Else

                        'Atualiza Arquivo
                        Call UpdateArquivoBD("tb_man_apontamento", _
                                             txtDescricaoArquivo.Text.Trim, _
                                             txtRevisaoArquivo.Text.Trim, _
                                             IIf(txtArquivo.Text.Trim = "", grdArquivo.CurrentRow.Cells("path").Value, txtArquivo.Text.Trim), _
                                             cboTipoArquivo.SelectedValue, _
                                             grdArquivo.CurrentRow.Cells("path").Value, _
                                             cboNumeroOrdemServico.SelectedValue, _
                                             btnSalvar.Tag)

                    End If

                    'Carrega Grid
                    Call LoadGridArquivoBD(grdArquivo, "tb_man_apontamento", cboNumeroOrdemServico.SelectedValue, btnSalvar.Tag)

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoArquivo()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirArquivo.Click

        Try

            'Deleta Registros
            Call DeleteArquivo()

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoArquivo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoArquivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoArquivo.SelectedIndexChanged

        Try

            'Limpa Controle
            txtArquivo.Text = ""

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdArquivo.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdArquivo.CurrentRow) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdArquivo.CurrentColumn.Key

                Case "editar" : Call EditarArquivo()
                Case "visualizar" : Call VisualizarDocumentoBD(grdArquivo.CurrentRow.Cells("arquivo").Value, grdArquivo.CurrentRow.Cells("extensao").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdArquivo.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo, _
                                     Formulario.ComprasRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name, _
                                     Formulario.ComprasRequisicao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdArquivo.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdArquivo.Name, _
                                          Formulario.ComprasRequisicao, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrManApontamento_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.ManutencaoOrdemServicoApontamento, gcDelete)
            btnExcluirAtividade.Enabled = VerificaDireito(Formulario.ManutencaoOrdemServicoApontamento, gcDelete)
            btnInserirAtividade.Enabled = VerificaDireito(Formulario.ManutencaoOrdemServicoApontamento, gcInsert)
            btnNovo1.Enabled = VerificaDireito(Formulario.ManutencaoOrdemServicoApontamento, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ManutencaoOrdemServicoApontamento, gcPrint)
            btnExcelGridAtividade.Enabled = VerificaDireito(Formulario.ManutencaoOrdemServicoApontamento, gcPrint)
            btnExcelGridArquivo.Enabled = VerificaDireito(Formulario.ManutencaoOrdemServicoApontamento, gcPrint)

            'Verifica Direito - Cadastrar
            btnCadastrarAtividade.Enabled = VerificaDireito(Formulario.CadastroBasicoAtividade, gcInsert)
            btnCadastrarFuncionario.Enabled = VerificaDireito(Formulario.CadastroBasicoFuncionario, gcInsert)

            'Carrega Combo            
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_ordem_servico_manutencao", False)
            Call LoadCombo(cboManutencaoFiltro, "sp_select_combo_cadastro_basico_manutencao " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboFuncionarioFiltro, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboFuncionario, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboAtividade, "sp_select_combo_cadastro_basico_atividade " & goUsuario.iEmpresa, False)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Sera Controles
            dtpDataInicioFiltro.Value = Now.Date : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ManutencaoOrdemServicoApontamento)
            Call ConfiguraGrid(grdAtividade, Formulario.ManutencaoOrdemServicoApontamento)
            Call ConfiguraGrid(grdArquivo, Formulario.ManutencaoOrdemServicoApontamento)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroOrdemServicoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: APONTAMENTO :::"

    Private Sub Editar()

        Try

            'Verifica se o Status da Diária é Aberto
            If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusDiaria.Aberto) Then

                'Verifica se o Usuário tem direito para Alterar os Dados
                If VerificaDireito(Formulario.ManutencaoOrdemServicoApontamento, gcUpdate) = True Then

                    'Limpa Formulário
                    Call Novo()

                    'Carrega Controles
                    Call oClsManApontamento.LoadControles(grdListagem.CurrentRow.Cells("codigo_ordem_servico").Value, _
                                                          grdListagem.CurrentRow.Cells("codigo").Value, _
                                                          cboNumeroOrdemServico, _
                                                          txtNumeroRequisicao, _
                                                          txtManutencao, _
                                                          cboFuncionario, _
                                                          txtEncarregado, _
                                                          dtpData, _
                                                          txtInicioTrabalho, _
                                                          txtTerminoTrabalho, _
                                                          txtHoraParada, _
                                                          txtTotalHoraTrabalhada, _
                                                          txtSituacaoInicial, _
                                                          txtSituacaoFinal, _
                                                          txtObservacao)

                    'Seta Controle
                    btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value

                    'Carrega Grid de Horas
                    Call oClsManApontamento.LoadGridAtividade(grdAtividade, _
                                                              grdListagem.CurrentRow.Cells("codigo_ordem_servico").Value, _
                                                              grdListagem.CurrentRow.Cells("codigo").Value)

                    'Carrega Grid
                    Call LoadGridArquivoBD(grdArquivo, _
                                           "tb_man_apontamento", _
                                           cboNumeroOrdemServico.SelectedValue, _
                                           btnSalvar.Tag)

                    'Seta Aba
                    tabAtividade.SelectedTab = pagDadosGerais

                    'Alterna Aba
                    tabMain.TabPages.Add(pagDados)
                    tabMain.TabPages.Remove(pagLista)

                    'Seta Focu
                    cboNumeroOrdemServico.Focus()

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.DireitoAlteracao)
                End If

            Else
                'Informa o Usuário
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Diária
            cboNumeroOrdemServico.SelectedIndex = -1
            txtNumeroRequisicao.Text = ""
            txtManutencao.Text = ""
            cboFuncionario.SelectedIndex = -1
            txtEncarregado.Text = ""
            dtpData.Value = Now.Date
            txtInicioTrabalho.Text = ""
            txtTerminoTrabalho.Text = ""
            txtHoraParada.Text = ""
            txtTotalHoraTrabalhada.Text = ""
            txtSituacaoInicial.Text = ""
            txtSituacaoFinal.Text = ""
            txtObservacao.Text = ""
            btnSalvar.Tag = ""

            'Carrega Combo
            Call LoadCombo(cboNumeroOrdemServico, "sp_select_combo_manutencao_ordem_servico " & goUsuario.iEmpresa & ", " & StatusOrdemServicoManutencao.EmAndamento)

            'Limpa Controles - Atividade
            cboAtividade.Text = ""
            btnInserirAtividade.Tag = ""
            grdAtividade.DataSource = Nothing

            'Seta Aba
            tabAtividade.SelectedTab = pagDadosGerais

            'Seta Focu
            cboNumeroOrdemServico.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Parametros
            oClsManApontamento.CodigoApontamento = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsManApontamento.CodigoOrdemServico = cboNumeroOrdemServico.SelectedValue
            oClsManApontamento.CodigoFuncionario = cboFuncionario.SelectedValue
            oClsManApontamento.Encarregado = txtEncarregado.Text.Trim
            oClsManApontamento.Data = dtpData.Value
            oClsManApontamento.InicioTrabalho = txtInicioTrabalho.Text
            oClsManApontamento.TerminoTrabalho = txtTerminoTrabalho.Text
            oClsManApontamento.HoraParada = txtHoraParada.Text
            oClsManApontamento.SituacaoInicial = txtSituacaoInicial.Text
            oClsManApontamento.SituacaoFinal = txtSituacaoFinal.Text
            oClsManApontamento.Observacao = txtObservacao.Text

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsManApontamento.Update()
                oClsManApontamento.DeleteAtividade()
                oClsManApontamento.InsertAtividade(grdAtividade)
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsManApontamento.Insert()
                oClsManApontamento.InsertAtividade(grdAtividade)
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsManApontamento.LoadGrid(grdListagem, _
                                        txtNumeroOrdemServicoFiltro.Text.Trim, _
                                        txtNumeroRequisicaoFiltro.Text.Trim, _
                                        txtRequisitanteFiltro.Text.Trim, _
                                        IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                        IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""), _
                                        IIf(cboFuncionarioFiltro.SelectedIndex = -1, -1, cboFuncionarioFiltro.SelectedValue), _
                                        IIf(cboStatusFiltro.SelectedIndex = -1, -1, cboStatusFiltro.SelectedValue), _
                                        IIf(cboManutencaoFiltro.SelectedIndex = -1, -1, cboManutencaoFiltro.SelectedValue))

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

            'Verifica se foi Selecionado o Campo - Nº Ordem Serviço
            If ValidaCampo(cboNumeroOrdemServico, lblNumeroOrdemServico) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Funcionário
            If ValidaCampo(cboFuncionario, lblFuncionario) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Início Trabalho
            If ValidaCampo(txtInicioTrabalho, lblInicioTrabalho, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Término Trabalho
            If ValidaCampo(txtTerminoTrabalho, lblTerminoTrabalho, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Parada
            If txtHoraParada.Text.Trim <> "" AndAlso ValidaCampo(txtHoraParada, lblHoraParada, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Situação Inicial
            If ValidaCampo(txtSituacaoInicial, lblSituacaoInicial, TipoCampo.texto) = False Then
                tabAtividade.SelectedTab = pagDadosGerais
                txtSituacaoInicial.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Situação Final
            If ValidaCampo(txtSituacaoFinal, lblSituacaoFinal, TipoCampo.texto) = False Then
                tabAtividade.SelectedTab = pagDadosGerais
                txtSituacaoFinal.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Email(ByVal lCodigoOrdemServico As Long, _
                      ByVal iCodigoApontamento As Integer, _
                      ByVal sNumeroOrdemServico As String)

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
            sArquivo &= sNumeroOrdemServico.ToString.Replace("/", "-").Replace("\", "-") & ".pdf"

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                      sArquivo)

            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Enviar E-mail
            Call EnviarEmail("Relatório de Vista Técnica: " & sNumeroOrdemServico.Trim, _
                             "", _
                             sArquivo, _
                             sArquivo, _
                             "", _
                             -1)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Imprimir(ByVal lCodigoOrdemServico As Long, _
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

#Region "::: ATIVIDADE :::"

    Private Sub InsertAtividade(ByVal oGrid As GridEX, _
                                ByVal sAtividade As String, _
                                ByVal iCodigo As Integer, _
                                ByVal iCodigoAntigo As Integer)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCAtividade As New DataColumn("atividade")
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
                oDataTable.Columns.Add(oDCCodigo)
                oDataTable.Columns.Add(oDCAtividade)
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirAtividade.Tag) = False Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("codigo") = iCodigo
                oDataRow("atividade") = sAtividade
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(codigo = " & iCodigoAntigo & ")")(0)
                oDataRow("atividade") = sAtividade
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

    Private Sub EditarAtividade()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ManutencaoOrdemServicoApontamento, gcUpdate) = True Then

                'Carrega Controles
                cboAtividade.SelectedValue = grdAtividade.CurrentRow.Cells("codigo").Value
                btnInserirAtividade.Tag = grdAtividade.CurrentRow.Cells("codigo").Value

                'Seta Focu
                cboAtividade.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoAtividade()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Contato
            cboAtividade.Text = ""
            btnInserirAtividade.Tag = ""

            'Seta Focu
            cboAtividade.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteAtividade()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdAtividade) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    For Each oRow As GridEXRow In gSelecaoRow
                        oRow.Delete()
                    Next

                    'Limpa Formulário
                    Call NovoAtividade()

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function ValidacaoAtividade() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoAtividade = False

            'Verifica se foi Selecionado o Campo - Atividade
            If ValidaCampo(cboAtividade, lblAtividade) = False Then
                Exit Function
            End If

            'Verifica se já foi inserido o Formulário
            If IsNumeric(btnInserirAtividade.Tag) = False Then
                If VerificaExisteValorGrid(grdAtividade, "codigo", cboAtividade.SelectedValue, -1) = True Then
                    frmMain.errInfo.SetError(lblAtividade, "Este Registro já se encontra cadastrado.")
                    cboAtividade.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdAtividade, "codigo", cboAtividade.SelectedValue, grdAtividade.CurrentRow.RowIndex) = True Then
                    frmMain.errInfo.SetError(lblAtividade, "Este Registro já se encontra cadastrado.")
                    cboAtividade.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoAtividade = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ARQUIVO :::"

    Private Sub DeleteArquivo()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdArquivo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    For Each oRow As GridEXRow In gSelecaoRow
                        'Exclui Registro do Banco de Dados
                        modFunction.DeleteArquivoBD("tb_man_apontamento", oRow.Cells("path").Value, cboNumeroOrdemServico.SelectedValue, btnSalvar.Tag)
                        'Exclui Registro da Grid
                        oRow.Delete()
                    Next

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

    Private Sub EditarArquivo()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ComprasRequisicao, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoArquivo()

                'Carrega Controles
                txtDescricaoArquivo.Text = grdArquivo.CurrentRow.Cells("descricao").Value
                txtRevisaoArquivo.Text = grdArquivo.CurrentRow.Cells("revisao").Value
                cboTipoArquivo.SelectedValue = grdArquivo.CurrentRow.Cells("codigo_tipo_arquivo").Value
                txtArquivo.Text = ""
                btnInserirArquivo.Tag = grdArquivo.CurrentRow.RowIndex

                'Seta Focu
                cboTipoArquivo.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
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
            txtDescricaoArquivo.Text = ""
            txtRevisaoArquivo.Text = ""
            cboTipoArquivo.SelectedIndex = -1
            txtArquivo.Text = ""
            btnInserirArquivo.Tag = ""

            'Seta Focu
            txtDescricaoArquivo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoArquivo() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoArquivo = False

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricaoArquivo, lblDescricaoArquivo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Revisão
            If ValidaCampo(txtRevisaoArquivo, lblRevisaoArquivo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Arquivo
            If ValidaCampo(cboTipoArquivo, lblTipoArquivo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Arquivo
            If IsNumeric(btnInserirArquivo.Tag) = False Then
                If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se o Produto é Válido
            Dim iRow As Integer = -1

            If IsNumeric(btnInserirArquivo.Tag) Then
                iRow = grdArquivo.CurrentRow.RowIndex
            End If

            For Each oRow As GridEXRow In grdArquivo.GetDataRows
                If oRow.Cells("descricao").Value = txtDescricaoArquivo.Text.Trim And oRow.Cells("revisao").Value = txtRevisaoArquivo.Text.Trim And oRow.RowIndex <> iRow Then
                    frmMain.errInfo.SetError(lblDescricaoArquivo, "Esta Descrição / Revisão já se encontra associada a um Registro.")
                    txtDescricaoArquivo.Focus()
                    Return False
                End If
            Next

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
