Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrCadCentroGastoBudget

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadCentroGastoBudget As New clsUsrCadCentroGastoBudget

#End Region

#Region "::: ENUM :::"

    Private Enum StatusBudget
        AguardandoAprovacao = 1
        Aprovado = 2
        Reprovado = 3
    End Enum

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadCentroGastoBudget_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGridBudget() Else Control_Enter(sender)
                    
                Case Keys.F3
                    Select Case sender.name
                        Case "cboCentroGasto" : Call btnProcurarCentroGasto_Click(btnProcurarCentroGasto, System.EventArgs.Empty)
                        Case "cboCentroGastoFiltro" : Call btnProcurarCentroGastoFiltro_Click(btnProcurarCentroGastoFiltro, System.EventArgs.Empty)
                    End Select

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboDepartamento", "cboDepartamentoFiltro"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboDepartamento : oComboBox(1) = cboDepartamentoFiltro
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_departamento " & goUsuario.iEmpresa)
                        Case "cboCentroGasto", "cboCentroGastoFiltro"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboCentroGasto : oComboBox(1) = cboCentroGastoFiltro
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboDepartamento" : Call btnCadastrarDepartamento_Click(btnCadastrarDepartamento, System.EventArgs.Empty)
                        Case "cboCentroGasto" : Call btnCadastrarCentroGasto_Click(btnCadastrarCentroGasto, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadCentroGastoBudget_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: CENTRO DE GASTO BUDGET :::"

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
            oForm.NomeFormulario = Formulario.CadastroBasicoCentroGastoBudget
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoCentroGastoBudget)

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

    Private Sub btnProcurarCentroGastoFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroGastoFiltro.Click

        Try
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            oComboBoxFind = cboCentroGastoFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGastoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call DeleteBudget()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGridBudget()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoBudget()

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
            Call NovoBudget()

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
            If ValidacaoBudget() = True Then

                'Salva Dados do Registro
                Call SalvarBudget()
                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoBudget()

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
            Call LoadGridBudget()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtCodigoBudgetFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub dtpDataInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataInicio.ValueChanged

        Try

            If IsDate(dtpDataInicio.Value) Then dtpDataTermino.MinDate = dtpDataInicio.Value

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

                Case "aprovar" : Call AprovarRevisao()
                Case "nova_revisao" : Call NovoRevisao()
                Case "editar" : Call EditarBudget(grdListagem.CurrentRow.Cells("codigo").Value)

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
                                     Formulario.CadastroBasicoCentroGastoBudget)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoCentroGastoBudget, _
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
                                          Formulario.CadastroBasicoCentroGastoBudget, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CENTRO DE GASTO BUDGET - VALORES :::"

    Private Sub btnAgruparGridValores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridValores.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdValores.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdValores.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdValores.GroupByBoxVisible = True
                grdValores.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridValores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguraGridValores.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdValores
            oForm.NomeFormulario = Formulario.CadastroBasicoCentroGastoBudget
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdValores, Formulario.CadastroBasicoCentroGastoBudget)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridValores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridValores.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdValores)

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

    Private Sub btnCadastrarDepartamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarDepartamento.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadDepartamento")

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboCentroGasto : oComboBox(1) = cboCentroGastoFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_departamento " & goUsuario.iEmpresa)

            'Seta Focu
            cboDepartamento.Focus()

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

    Private Sub btnInserirLinha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirLinha.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Campos
            If ValidacaoValores() = True Then

                'Atualiza Registro
                Call SalvarValores()

                'Limpa Registros
                Call NovoValores()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirLinha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirLinha.Click

        Try

            'Deleta Registros
            Call DeleteValores()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdValores_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdValores.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdValores.CurrentColumn) = True Then Exit Sub

            Select Case grdValores.CurrentColumn.Key

                Case "editar" : Call EditarValores()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdValores_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdValores.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdValores, _
                                     Formulario.CadastroBasicoCentroGastoBudget)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdValores_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdValores.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdValores.Name, _
                                     Formulario.CadastroBasicoCentroGastoBudget, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdValores_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdValores.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdValores.Name, _
                                          Formulario.CadastroBasicoCentroGastoBudget, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadCentroGastoBudget_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGastoBudget, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGastoBudget, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGastoBudget, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGastoBudget, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGastoBudget, gcPrint)
            btnInserirLinha.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGastoBudget, gcInsert)
            btnExcluirLinha.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGastoBudget, gcDelete)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGastoBudget, gcPrint)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboDepartamento : oComboBox(1) = cboDepartamentoFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_departamento " & goUsuario.iEmpresa)
            oComboBox(0) = cboCentroGasto : oComboBox(1) = cboCentroGastoFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoCentroGastoBudget)
            Call ConfiguraGrid(grdValores, Formulario.CadastroBasicoCentroGastoBudget)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtCodigoBudgetFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CENTRO DE GASTO BUDGET :::"

    Private Sub AprovarRevisao()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoCentroGastoBudget, gcAdministrator) = True Then

                'Verifica o Status do Budget
                If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusBudget.AguardandoAprovacao) Then

                    'Verifica se o Usuário deseja Aprovar o Registro
                    If MsgBox("Deseja Aprovar o Registro Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                        'Aprova Revisão
                        Call oClsCadCentroGastoBudget.AprovarBudget(grdListagem.CurrentRow.Cells("codigo").Value)

                        'Carrega Grid
                        Call LoadGridBudget()

                    End If

                Else
                    'Informa o Usuário não pode aprovar o Budget
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Status do Registro não é Aguardando Aprovação.")
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteBudget()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem, "status", CInt(StatusBudget.AguardandoAprovacao)) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCadCentroGastoBudget.DeleteBudget()

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

    Private Sub NovoBudget()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles                    
            txtCodigo.Text = ""
            txtDescricao.Text = ""
            dtpDataInicio.Value = Now.Date
            dtpDataTermino.Value = Now.Date
            txtRevisao.Text = ""
            btnSalvar.Tag = ""

            'Limpa Controles - Valores
            cboCentroGasto.SelectedIndex = -1
            cboDepartamento.SelectedIndex = -1
            txtValor.Value = 0
            btnInserirLinha.Tag = ""
            grdValores.DataSource = Nothing

            'Seta Focu
            txtCodigo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoRevisao()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoCentroGastoBudget, gcInsert) = True Then

                'Verifica o Status do Budget
                If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusBudget.AguardandoAprovacao) Then

                    'Váriaveis Locais
                    Dim lCodigo As Long

                    'Insere Revisão
                    Call oClsCadCentroGastoBudget.InsertBudgetRevisao(grdListagem.CurrentRow.Cells("codigo").Value, _
                                                                      lCodigo)

                    'Edita Registro
                    Call EditarBudget(lCodigo)

                Else
                    'Informa o Usuário não pode aprovar o Budget
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Status do Registro não é Aguardando Aprovação.")
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarBudget(ByVal lCodigo As Long)

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoCentroGastoBudget, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoBudget()

                'Carrega Controles
                Call oClsCadCentroGastoBudget.EditarBudget(lCodigo, _
                                                           txtRevisao, _
                                                           txtCodigo, _
                                                           txtDescricao, _
                                                           dtpDataInicio, _
                                                           dtpDataTermino)

                'Carrega Grid - Valores
                Call oClsCadCentroGastoBudget.LoadGridValores(grdValores, _
                                                              lCodigo)

                'Seta Controle
                btnSalvar.Tag = lCodigo

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtCodigo.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarBudget()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadCentroGastoBudget.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadCentroGastoBudget.CodigoBudget = txtCodigo.Text.Trim
            oClsCadCentroGastoBudget.Descricao = txtDescricao.Text.Trim
            oClsCadCentroGastoBudget.DataInicio = dtpDataInicio.Value
            oClsCadCentroGastoBudget.DataTermino = dtpDataTermino.Value

            'Verifica o Tipo de Operação
            If Len(btnSalvar.Tag) > 0 Then

                'Atualiza Registros
                Call oClsCadCentroGastoBudget.UpdateBudget()
                Call oClsCadCentroGastoBudget.DeleteValores(oClsCadCentroGastoBudget.Codigo)
                Call oClsCadCentroGastoBudget.InsertValores(grdValores)
                'Informa o Usuário sobre o sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                'Insere Registros
                Call oClsCadCentroGastoBudget.InsertBudget()
                'Seta Váriavel
                btnSalvar.Tag = oClsCadCentroGastoBudget.Codigo
                Call oClsCadCentroGastoBudget.InsertValores(grdValores)
                'Informa o Usuário sobre o sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridBudget()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call oClsCadCentroGastoBudget.LoadGridBudget(grdListagem, _
                                                         txtCodigoBudgetFiltro.Text.Trim, _
                                                         txtDescricaoFiltro.Text.Trim, _
                                                         IIf(IsNumeric(txtRevisaoFiltro.Text.Trim), txtRevisaoFiltro.Text.Trim, -1), _
                                                         IIf(cboCentroGastoFiltro.SelectedIndex = -1, -1, cboCentroGastoFiltro.SelectedValue), _
                                                         IIf(cboDepartamentoFiltro.SelectedIndex = -1, -1, cboDepartamentoFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoBudget() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoBudget = False

            'Verifica se foi Preenchido o Campo - Centro de Trabalho
            If ValidaCampo(txtCodigo, lblCodigo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Valida se o Centro de Trabalho Budget é válido
            If oClsCadCentroGastoBudget.ValidaCodigoBudget(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                                           IIf(IsNumeric(txtRevisao.Text), txtRevisao.Text, 0), _
                                                           txtCodigo.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblCodigo, "Este Código: " & txtCodigo.Text.Trim & " já está associado a outro Registro")
                txtCodigo.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Inserido algum Registro na Grid
            If grdValores.GetDataRows.Count = 0 Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Primeiramente insira um ou mais Valores.")
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoBudget = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: CENTRO DE GASTO BUDGET - VALORES :::"

    Private Sub DeleteValores()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    For Each oRow As GridEXRow In gSelecaoRow
                        oRow.Delete()
                    Next

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

    Private Sub NovoValores()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Valores
            cboCentroGasto.SelectedIndex = -1
            cboDepartamento.SelectedIndex = -1
            txtValor.Value = 0
            btnInserirLinha.Tag = ""

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarValores()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoCentroGastoBudget, gcUpdate) = True Then

                'Carrega Dados
                cboCentroGasto.SelectedValue = grdValores.CurrentRow.Cells("codigo_centro_gasto").Value
                cboDepartamento.SelectedValue = grdValores.CurrentRow.Cells("codigo_departamento").Value
                txtValor.Value = grdValores.CurrentRow.Cells("valor").Value
                btnInserirLinha.Tag = grdValores.CurrentRow.Cells("codigo_centro_gasto").Value

                'Seta Focu
                cboCentroGasto.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarValores()

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCCentroGasto As New DataColumn("centro_gasto")
            Dim oDCDepartamento As New DataColumn("departamento")
            Dim oDCValor As New DataColumn("valor")
            Dim oDCCodigoCentroGasto As New DataColumn("codigo_centro_gasto")
            Dim oDCCodigoDepartamento As New DataColumn("codigo_departamento")

            'Verifica se o DataSource é Vazio
            If Not grdValores.DataSource Is Nothing Then
                oDataSet = grdValores.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                grdValores.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCCentroGasto)
                oDataTable.Columns.Add(oDCDepartamento)
                oDataTable.Columns.Add(oDCValor)
                oDataTable.Columns.Add(oDCCodigoCentroGasto)
                oDataTable.Columns.Add(oDCCodigoDepartamento)
                'Seta DataType
                oDCValor.DataType = 0.0.GetType
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirLinha.Tag) = False Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("centro_gasto") = cboCentroGasto.Text
                oDataRow("departamento") = IIf(cboDepartamento.SelectedIndex = -1, "", cboDepartamento.Text)
                oDataRow("valor") = txtValor.Value
                oDataRow("codigo_centro_gasto") = cboCentroGasto.SelectedValue
                oDataRow("codigo_departamento") = IIf(cboDepartamento.SelectedIndex = -1, DBNull.Value, cboDepartamento.SelectedValue)
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(codigo_centro_gasto = " & btnInserirLinha.Tag & ")")(0)
                oDataRow("centro_gasto") = cboCentroGasto.Text
                oDataRow("departamento") = IIf(cboDepartamento.SelectedIndex = -1, "", cboDepartamento.Text)
                oDataRow("valor") = txtValor.Value
                oDataRow("codigo_centro_gasto") = cboCentroGasto.SelectedValue
                oDataRow("codigo_departamento") = IIf(cboDepartamento.SelectedIndex = -1, DBNull.Value, cboDepartamento.SelectedValue)
            End If

            'Configura DataMember
            Call ConfigurarDataMemberGrid(grdValores)

            'Carrega Grid
            grdValores.DataSource = oDataSet.DefaultViewManager
            grdValores.DataMember = oDataSet.Tables(0).TableName

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoValores() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoValores = False

            'Verifica se foi Selecionado o Campo - Centro de Gasto
            If ValidaCampo(cboCentroGasto, lblCentroGasto, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Valida se o Centro de Trabalho Budget é Válido            
            Dim iRow As Integer = -1
            If IsNumeric(btnInserirLinha.Tag) Then iRow = grdValores.CurrentRow.RowIndex
            'Verifica se o Centro de Gasto está associado a Grid
            If VerificaExisteValorGrid(grdValores, "codigo_centro_gasto", cboCentroGasto.SelectedValue, iRow) = True Then
                frmMain.errInfo.SetError(lblCentroGasto, "Este Centro de Gasto: " & cboCentroGasto.Text & " já se encontra associado a este Budget.")
                cboCentroGasto.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor
            If ValidaCampo(txtValor, lblValor, True) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoValores = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
