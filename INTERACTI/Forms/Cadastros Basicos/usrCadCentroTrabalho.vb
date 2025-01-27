Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrCadCentroTrabalho

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadCentroTrabalho As New clsUsrCadCentroTrabalho

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadCentroTrabalho_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F3
                    Select Case sender.name
                        Case "cboCentroGasto" : Call btnProcurarCentroGasto_Click(btnProcurarCentroGasto, System.EventArgs.Empty)
                    End Select

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCalendario", "cboCalendarioFiltro"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboCalendario : oComboBox(1) = cboCalendarioFiltro
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_calendario " & goUsuario.iEmpresa)
                        Case "cboCentroGasto", "cboCentroGastoFiltro"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboCentroGasto : oComboBox(1) = cboCentroGastoFiltro
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboCodigoMaquina" : Call LoadCombo(cboCodigoMaquina, "sp_select_combo_cadastro_basico_maquina " & TipoMaquina.Injetora & ", " & goUsuario.iEmpresa, False)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboCalendario" : Call btnCadastrarCalendario_Click(btnCadastrarCalendario, System.EventArgs.Empty)
                        Case "cboCentroGasto" : Call btnCadastrarCentroGasto_Click(btnCadastrarCentroGasto, System.EventArgs.Empty)
                        Case "cboCodigoMaquina" : Call btnCadastrarMaquina_Click(btnCadastrarMaquina, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadCentroTrabalho_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: CENTRO DE TRABALHO :::"

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
            oForm.NomeFormulario = Formulario.CadastroBasicoCentroTrabalho
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoCentroTrabalho)

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

    Private Sub btnCadastrarCalendario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCalendario.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCalendario")

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboCalendario : oComboBox(1) = cboCalendarioFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_calendario " & goUsuario.iEmpresa)

            'Seta Focu
            cboCalendario.Focus()

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
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboCentroGasto : oComboBox(1) = cboCentroGastoFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroGasto.Focus()

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
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

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
                ''Prepara Formulário para Inserção de um Novo Registro
                'Call Novo()

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

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtCentroTrabalhoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboProcessamentoExterno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOperacional.SelectedValueChanged

        Try

            'Desabilita Controles
            cboCalendario.Enabled = False : cboCalendario.SelectedIndex = -1
            tabCalendario.Enabled = False

            'Verifica o Registro que foi Selecionado
            If cboOperacional.SelectedIndex <> -1 AndAlso cboOperacional.SelectedValue = True Then

                'Habilita Controles            

                cboCalendario.Enabled = True
                tabCalendario.Enabled = True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) = True Then Exit Sub

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
                                     Formulario.CadastroBasicoCentroTrabalho)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoCentroTrabalho, _
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
                                          Formulario.CadastroBasicoCentroTrabalho, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

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
            oForm.NomeFormulario = Formulario.CadastroBasicoCEntroTrabalho
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdMaquina, Formulario.CadastroBasicoCEntroTrabalho)

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
                Call LoadGridMaquina()

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

    Private Sub cboCodigoMaquina_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboCodigoMaquina.SelectedIndexChanged

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
                                     Formulario.CadastroBasicoCentroTrabalho)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdMaquina_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdMaquina.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdMaquina.Name, _
                                     Formulario.CadastroBasicoCentroTrabalho, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdMaquina_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdMaquina.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdMaquina.Name, _
                                          Formulario.CadastroBasicoCentroTrabalho, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadCentroTrabalho_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroTrabalho, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroTrabalho, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroTrabalho, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroTrabalho, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroTrabalho, gcPrint)
            btnExcelGridMaquina.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroTrabalho, gcPrint)

            'Verifica Direito - Botão Cadastro            
            btnCadastrarMaquina.Enabled = VerificaDireito(Formulario.CadastroBasicoMaquinaEquipamento, gcInsert)
            btnCadastrarCalendario.Enabled = VerificaDireito(Formulario.CadastroBasicoCalendario, gcInsert)
            btnCadastrarCentroGasto.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboCalendario : oComboBox(1) = cboCalendarioFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_calendario " & goUsuario.iEmpresa)
            oComboBox(0) = cboCentroGasto : oComboBox(1) = cboCentroGastoFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
            Call LoadComboSimNao(cboOperacionalFiltro)
            Call LoadComboSimNao(cboOperacional)
            Call LoadComboSimNao(cboAtivo)
            Call LoadComboSimNao(cboMultiplaOPApontamento)
            Call LoadComboSimNao(cboAtivoFiltro)
            Call LoadComboSimNao(cboMultiploApontamento)
            Call LoadCombo(cboCodigoMaquina, "sp_select_combo_cadastro_basico_maquina " & TipoMaquina.Injetora & ", " & goUsuario.iEmpresa, False)
            LoadCombo(cboCentroTrabalhoAlternativo, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoCentroTrabalho)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtCentroTrabalhoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CENTRO DE TRABALHO :::"

    Private Sub Delete()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadCentroTrabalho.Delete()

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

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            ' btnSalvar.Tag = ""
            txtDescricao.Text = ""
            cboOperacional.SelectedIndex = -1
            cboMultiplaOPApontamento.SelectedIndex = -1
            cboMultiploApontamento.SelectedIndex = -1
            cboAtivo.SelectedIndex = -1
            cboCalendario.SelectedIndex = -1
            cboCentroGasto.SelectedIndex = -1
            cboCentroTrabalhoAlternativo.SelectedIndex = -1
            chkSegunda.Checked = False
            chkTerca.Checked = False
            chkQuarta.Checked = False
            chkQuinta.Checked = False
            chkSexta.Checked = False
            chkSabado.Checked = False
            chkDomingo.Checked = False
            txtHoraSegunda.Text = "00:00:00"
            txtHoraTerca.Text = "00:00:00"
            txtHoraQuarta.Text = "00:00:00"
            txtHoraQuinta.Text = "00:00:00"
            txtHoraSexta.Text = "00:00:00"
            txtHoraSabado.Text = "00:00:00"
            txtHoraDomingo.Text = "00:00:00"

            'Limpa Controles - Máquina
            cboCodigoMaquina.Text = ""
            txtDescricaoMaquina.Text = ""
            btnInserirMaquina.Tag = ""
            grdMaquina.DataSource = Nothing

            btnSalvar.Tag = Nothing

            'Seta Focu
            txtDescricao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoCentroTrabalho, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                'Carrega Controles
                oClsCadCentroTrabalho.LoadDados(grdListagem.CurrentRow.Cells("codigo").Value,
                                                txtDescricao,
                                                cboOperacional,
                                                cboCalendario,
                                                cboCentroGasto,
                                                chkSegunda,
                                                chkTerca,
                                                chkQuarta,
                                                chkQuinta,
                                                chkSexta,
                                                txtHoraSegunda,
                                                txtHoraTerca,
                                                txtHoraQuarta,
                                                txtHoraQuinta,
                                                txtHoraSexta,
                                                txtHoraSabado,
                                                txtHoraDomingo,
                                                cboCentroTrabalhoAlternativo,
                                                cboAtivo,
                                                cboMultiploApontamento, _
                                                cboMultiplaOPApontamento)

                'Seta Controle
                btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value

                'Carrega Grid
                LoadGridMaquina()

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtDescricao.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadCentroTrabalho.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadCentroTrabalho.Descricao = txtDescricao.Text.Trim
            oClsCadCentroTrabalho.Operacional = cboOperacional.SelectedValue
            oClsCadCentroTrabalho.Ativo = IIf(cboAtivo.SelectedIndex = -1, 1, cboAtivo.SelectedValue)
            oClsCadCentroTrabalho.MultiploApontamento = IIf(cboMultiploApontamento.SelectedIndex = -1, 0, cboMultiploApontamento.SelectedValue)
            oClsCadCentroTrabalho.MultiplaOPApontamento = IIf(cboMultiplaOPApontamento.SelectedIndex = -1, 0, cboMultiplaOPApontamento.SelectedValue)
            oClsCadCentroTrabalho.LimiteInferior = 0
            oClsCadCentroTrabalho.LimiteSuperior = 0
            oClsCadCentroTrabalho.Calendario = IIf(cboCalendario.SelectedIndex = -1, -1, cboCalendario.SelectedValue)
            oClsCadCentroTrabalho.CentroGasto = IIf(cboCentroGasto.SelectedIndex = -1, -1, cboCentroGasto.SelectedValue)
            oClsCadCentroTrabalho.Segunda = chkSegunda.Checked
            oClsCadCentroTrabalho.Terca = chkTerca.Checked
            oClsCadCentroTrabalho.Quarta = chkQuarta.Checked
            oClsCadCentroTrabalho.Quinta = chkQuinta.Checked
            oClsCadCentroTrabalho.Sexta = chkSexta.Checked
            oClsCadCentroTrabalho.HorasSegunda = IIf(chkSegunda.Checked = False, 0, ((DatePart(DateInterval.Hour, CDate(txtHoraSegunda.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraSegunda.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraSegunda.Text)) / 60)))
            oClsCadCentroTrabalho.HorasTerca = IIf(chkTerca.Checked = False, 0, ((DatePart(DateInterval.Hour, CDate(txtHoraTerca.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraTerca.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraTerca.Text)) / 60)))
            oClsCadCentroTrabalho.HorasQuarta = IIf(chkQuarta.Checked = False, 0, ((DatePart(DateInterval.Hour, CDate(txtHoraQuarta.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraQuarta.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraQuarta.Text)) / 60)))
            oClsCadCentroTrabalho.HorasQuinta = IIf(chkQuinta.Checked = False, 0, ((DatePart(DateInterval.Hour, CDate(txtHoraQuinta.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraQuinta.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraQuinta.Text)) / 60)))
            oClsCadCentroTrabalho.HorasSexta = IIf(chkSexta.Checked = False, 0, ((DatePart(DateInterval.Hour, CDate(txtHoraSexta.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraSexta.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraSexta.Text)) / 60)))
            oClsCadCentroTrabalho.HorasSabado = IIf(chkSabado.Checked = False, 0, ((DatePart(DateInterval.Hour, CDate(txtHoraSabado.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraSabado.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraSabado.Text)) / 60)))
            oClsCadCentroTrabalho.HorasDomingo = IIf(chkDomingo.Checked = False, 0, ((DatePart(DateInterval.Hour, CDate(txtHoraDomingo.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtHoraDomingo.Text)) + (DatePart(DateInterval.Second, CDate(txtHoraDomingo.Text)) / 60)))
            oClsCadCentroTrabalho.CodigoCentroTrabalhoAlternativo = IIf(cboCentroTrabalhoAlternativo.SelectedIndex = -1, -1, cboCentroTrabalhoAlternativo.SelectedValue)
            'Verifica o Tipo de Operação
            If Len(btnSalvar.Tag) > 0 Then
                oClsCadCentroTrabalho.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                btnSalvar.Tag = oClsCadCentroTrabalho.Insert()
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            oClsCadCentroTrabalho.LoadGrid(grdListagem,
                                           txtCentroTrabalhoFiltro.Text.Trim,
                                           txtDescricaoFiltro.Text.Trim,
                                           IIf(cboOperacionalFiltro.SelectedIndex = -1, -1, cboOperacionalFiltro.SelectedValue),
                                           IIf(cboCalendarioFiltro.SelectedIndex = -1, -1, cboCalendarioFiltro.SelectedValue),
                                           IIf(cboCentroGastoFiltro.SelectedIndex = -1, -1, cboCentroGastoFiltro.SelectedValue),
                                           IIf(cboAtivoFiltro.SelectedIndex = -1, -1, cboAtivoFiltro.SelectedValue))

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


            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Processamento Externo
            If ValidaCampo(cboOperacional, lblOperacional) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Calendário
            If cboCalendario.Enabled = True Then
                If ValidaCampo(cboCalendario, lblCalendario) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Multiplo Apontamento
            If ValidaCampo(cboMultiploApontamento, lblMultiploApontamento) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

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
                Call oClsCadCentroTrabalho.UpdateMaquina(btnSalvar.Tag, _
                                                         cboCodigoMaquina.SelectedValue, _
                                                         iCodigoRegistroAntigo)

            Else

                'Insere Registro na tb_cad_roteiro_producao_item
                Call oClsCadCentroTrabalho.InsertMaquina(oClsCadCentroTrabalho.Codigo, _
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
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Maquina
                    Call oClsCadCentroTrabalho.DeleteMaquina(btnSalvar.Tag)

                    'Verifica Status da Grid
                    If grdMaquina.GetDataRows.Count > 0 Then
                        chkSegunda.Checked = False : chkSegunda.Enabled = False : txtHoraSegunda.Text = "00:00:00" : txtHoraSegunda.Enabled = False
                        chkTerca.Checked = False : chkTerca.Enabled = False : txtHoraTerca.Text = "00:00:00" : txtHoraTerca.Enabled = False
                        chkQuarta.Checked = False : chkQuarta.Enabled = False : txtHoraQuarta.Text = "00:00:00" : txtHoraQuarta.Enabled = False
                        chkQuinta.Checked = False : chkQuinta.Enabled = False : txtHoraQuinta.Text = "00:00:00" : txtHoraQuinta.Enabled = False
                        chkSexta.Checked = False : chkSexta.Enabled = False : txtHoraSexta.Text = "00:00:00" : txtHoraSexta.Enabled = False
                        chkSabado.Checked = False : chkSabado.Enabled = False : txtHoraSabado.Text = "00:00:00" : txtHoraSabado.Enabled = False
                        chkDomingo.Checked = False : chkDomingo.Enabled = False : txtHoraDomingo.Text = "00:00:00" : txtHoraDomingo.Enabled = False
                    Else
                        chkSegunda.Enabled = True : txtHoraSegunda.Enabled = True
                        chkTerca.Enabled = True : txtHoraTerca.Enabled = True
                        chkQuarta.Enabled = True : txtHoraQuarta.Enabled = True
                        chkQuinta.Enabled = True : txtHoraQuinta.Enabled = True
                        chkSexta.Enabled = True : txtHoraSexta.Enabled = True
                        chkSabado.Enabled = True : txtHoraSabado.Enabled = True
                        chkDomingo.Enabled = True : txtHoraDomingo.Enabled = True
                    End If

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
            If VerificaDireito(Formulario.CadastroBasicoCentroTrabalho, gcUpdate) = True Then

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

    Private Sub LoadGridMaquina()

        Try

            'Carrega Grid
            oClsCadCentroTrabalho.LoadGridMaquina(grdMaquina, btnSalvar.Tag)

            'Verifica Status da Grid
            If grdMaquina.GetDataRows.Count > 0 Then
                chkSegunda.Checked = False : chkSegunda.Enabled = False : txtHoraSegunda.Text = "00:00:00" : txtHoraSegunda.Enabled = False
                chkTerca.Checked = False : chkTerca.Enabled = False : txtHoraTerca.Text = "00:00:00" : txtHoraTerca.Enabled = False
                chkQuarta.Checked = False : chkQuarta.Enabled = False : txtHoraQuarta.Text = "00:00:00" : txtHoraQuarta.Enabled = False
                chkQuinta.Checked = False : chkQuinta.Enabled = False : txtHoraQuinta.Text = "00:00:00" : txtHoraQuinta.Enabled = False
                chkSexta.Checked = False : chkSexta.Enabled = False : txtHoraSexta.Text = "00:00:00" : txtHoraSexta.Enabled = False
                chkSabado.Checked = False : chkSabado.Enabled = False : txtHoraSabado.Text = "00:00:00" : txtHoraSabado.Enabled = False
                chkDomingo.Checked = False : chkDomingo.Enabled = False : txtHoraDomingo.Text = "00:00:00" : txtHoraDomingo.Enabled = False
            Else
                chkSegunda.Enabled = True : txtHoraSegunda.Enabled = True
                chkTerca.Enabled = True : txtHoraTerca.Enabled = True
                chkQuarta.Enabled = True : txtHoraQuarta.Enabled = True
                chkQuinta.Enabled = True : txtHoraQuinta.Enabled = True
                chkSexta.Enabled = True : txtHoraSexta.Enabled = True
                chkSabado.Enabled = True : txtHoraSabado.Enabled = True
                chkDomingo.Enabled = True : txtHoraDomingo.Enabled = True
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
                    frmMain.errInfo.SetError(lblCodigoMaquina, "Esta Máquina: " & cboCodigoMaquina.Text & " já está associado ao Centro de Trabalho: " & txtDescricao.Text.Trim & ".")
                    cboCodigoMaquina.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdMaquina, "codigo", cboCodigoMaquina.SelectedValue, -1) Then
                    frmMain.errInfo.SetError(lblCodigoMaquina, "Esta Máquina: " & cboCodigoMaquina.Text & " já está associado ao Centro de Trabalho: " & txtDescricao.Text.Trim & ".")
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

    Private Sub btnAtribuirFornecedor_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

#End Region

End Class
