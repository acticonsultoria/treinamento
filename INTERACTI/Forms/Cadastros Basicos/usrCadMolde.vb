Imports Janus.Windows.GridEX
Imports System.IO

Public Class usrCadMolde

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadMolde As New clsUsrCadMolde

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadMolde_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F3
                    Select Case sender.Name
                        Case "cboCodigoProduto" : Call btnProcurarProduto_Click(btnProcurarProduto, System.EventArgs.Empty)                            
                    End Select

                Case Keys.F5
                    Select Case sender.Name
                        Case "cboMaquina" : Call LoadCombo(cboCodigoMaquina, "sp_select_combo_cadastro_basico_maquina " & TipoMaquina.Injetora & ", " & goUsuario.iEmpresa, False)
                        Case "cboCodigoProduto" : Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto) & ", NULL, 1", True)
                        Case "cboTipoArquivo" : Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa)
                        Case "cboCaracteristicaInspecionarQualidade" : Call LoadCombo(cboCaracteristicaInspecionarQualidade, "sp_select_combo_cadastro_basico_qualidade_caracteristicas_inspecionar " & goUsuario.iEmpresa, False)
                    End Select

                Case Keys.Oemplus, Keys.Add
                    Select Case sender.Name
                        Case "cboMaquina" : Call btnCadastrarMaquina_Click(btnCadastrarMaquina, System.EventArgs.Empty)
                        Case "cboCodigoProduto" : Call btnCadastrarProduto_Click(btnCadastrarProduto, System.EventArgs.Empty)
                        Case "cboTipoArquivo" : Call btnCadastrarTipoArquivo_Click(btnCadastrarTipoArquivo, System.EventArgs.Empty)
                        Case "cboCaracteristicaInspecionarQualidade" : Call btnCadastrarCaracteristicaInspecionarQualidade_Click(btnCadastrarCaracteristicaInspecionarQualidade, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadMolde_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: MOLDE :::"

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
            oForm.NomeFormulario = Formulario.CadastroBasicoMolde
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoMolde)

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

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtCodigoFiltro.Focus()

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

                Case "editar" : Editar()
                Case "visualizar" : Call VisualizarDocumento(grdListagem.CurrentRow.Cells("arquivo_interacti").Value)

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
                                     Formulario.CadastroBasicoMolde, _
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
                                     Formulario.CadastroBasicoMolde)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.CadastroBasicoMolde, _
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
            oForm.NomeFormulario = Formulario.CadastroBasicoMolde
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdMaquina, Formulario.CadastroBasicoMolde)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridMaquina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridMaquina.Click

        Try

            'Exporta Grid para Excel
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

            'Valida Dados do Formulário
            If ValidacaoMaquina() = True Then

                'Salva Maquina
                Call SalvarMaquina()

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoMaquina()

                'Carrega Grid
                Call oClsCadMolde.LoadGridMaquina(grdMaquina, btnSalvar.Tag)

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
            If IsNothing(grdMaquina.CurrentRow) Then Exit Sub

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
                                     Formulario.CadastroBasicoMolde)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdMaquina_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdMaquina.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdMaquina.Name, _
                                     Formulario.CadastroBasicoMolde, _
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
                                          Formulario.CadastroBasicoMolde, _
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
            oForm.NomeFormulario = Formulario.CadastroBasicoMolde
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdProduto, Formulario.CadastroBasicoMolde)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridProduto.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarProduto.Click

        Try

               'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo
            Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto) & ", NULL, 1", False)
            'Seta Focu
            cboCodigoProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProduto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemProducaoFind = "S"
            oComboBoxFind = cboCodigoProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCodigoProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirProduto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoProduto() = True Then

                'Salva Produto
                Call SalvarProduto()

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoProduto()

                'Carrega Grid
                Call oClsCadMolde.LoadGridProduto(grdProduto, btnSalvar.Tag)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirProduto.Click

        Try

            'Deleta Registros
            Call DeleteProduto()

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoProduto()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCodigoProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCodigoProduto.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboCodigoProduto.SelectedIndex = -1 Then
                'Limpa Controles
                txtDescricaoProduto.Text = ""
            Else
                'Váriaveis Locais
                Dim oClsCadProduto As New clsUsrCadProduto
                'Carrega Controles
                Call oClsCadProduto.LoadDadosProduto(cboCodigoProduto.SelectedValue, txtDescricaoProduto)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdProduto.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdProduto.CurrentRow) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdProduto.CurrentColumn.Key

                Case "editar" : Call EditarProduto()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdProduto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto, _
                                     Formulario.CadastroBasicoMolde)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto.Name, _
                                     Formulario.CadastroBasicoMolde, _
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
                                          Formulario.CadastroBasicoMolde, _
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
            oForm.NomeFormulario = Formulario.CadastroBasicomolde
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdQualidade, Formulario.CadastroBasicomolde)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridQualidade.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdQualidade)

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

    Private Sub btnInserirQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirQualidade.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoQualidade() = True Then

                'Salva Qualidade
                Call SalvarQualidade()

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoQualidade()

                'Carrega Grid
                Call oClsCadMolde.LoadGridQualidade(grdQualidade, btnSalvar.Tag)

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
                                     Formulario.CadastroBasicomolde)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdQualidade_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdQualidade.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdQualidade.Name, _
                                     Formulario.CadastroBasicomolde, _
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
                                          Formulario.CadastroBasicomolde, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

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
            oForm.NomeFormulario = Formulario.CadastroBasicoMolde
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.CadastroBasicoMolde)

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
                        Call InsertArquivoBD("tb_cad_molde", _
                                             txtDescricaoArquivo.Text.Trim, _
                                             txtRevisaoArquivo.Text.Trim, _
                                             txtArquivo.Text.Trim, _
                                             cboTipoArquivo.SelectedValue, _
                                             btnSalvar.Tag)

                    Else

                        'Atualiza Arquivo
                        Call UpdateArquivoBD("tb_cad_molde", _
                                             txtDescricaoArquivo.Text.Trim, _
                                             txtRevisaoArquivo.Text.Trim, _
                                             IIf(txtArquivo.Text.Trim = "", "", txtArquivo.Text.Trim), _
                                             cboTipoArquivo.SelectedValue, _
                                             grdArquivo.CurrentRow.Cells("path").Value, _
                                             btnSalvar.Tag)

                    End If

                    'Carrega Grid
                    Call LoadGridArquivoBD(grdArquivo, "tb_cad_molde", btnSalvar.Tag)

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
                                     Formulario.CadastroBasicoMolde)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name, _
                                     Formulario.CadastroBasicoMolde, _
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
                                          Formulario.CadastroBasicoMolde, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadMolde_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoMolde, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoMolde, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoMolde, gcPrint)
            btnExcelGridArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoMolde, gcPrint)
            btnExcelGridMaquina.Enabled = VerificaDireito(Formulario.CadastroBasicoMolde, gcPrint)
            btnExcelGridProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoMolde, gcPrint)
            btnExcelGridQualidade.Enabled = VerificaDireito(Formulario.CadastroBasicoMolde, gcPrint)
            btnExcluirProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoMolde, gcDelete)
            btnInserirProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoMolde, gcInsert)
            btnExcluirArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoMolde, gcDelete)
            btnInserirArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoMolde, gcInsert)

            'Verifica Direito - Botão Cadastrar
            btnCadastrarMaquina.Enabled = VerificaDireito(Formulario.CadastroBasicoMaquinaEquipamento, gcInsert)
            btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
            btnCadastrarCaracteristicaInspecionarQualidade.Enabled = VerificaDireito(Formulario.CadastroBasicoQualidadeCaracteristicasInspecionar, gcInsert)
            btnCadastrarCentroTrabalho.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroTrabalho, gcInsert)
            btnCadastrarTipoArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoArquivo, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto) & ", NULL, 1", False)
            Call LoadCombo(cboCaracteristicaInspecionarQualidade, "sp_select_combo_cadastro_basico_qualidade_caracteristicas_inspecionar " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)
            Call LoadCombo(cboCodigoMaquina, "sp_select_combo_cadastro_basico_maquina " & TipoMaquina.Injetora & ", " & goUsuario.iEmpresa, False)
            Call LoadComboSimNao(cboAtivo)
            Call LoadComboSimNao(cboApontaQualidade)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoMolde)
            Call ConfiguraGrid(grdMaquina, Formulario.CadastroBasicoMolde)
            Call ConfiguraGrid(grdProduto, Formulario.CadastroBasicoMolde)
            Call ConfiguraGrid(grdQualidade, Formulario.CadastroBasicoMolde)
            Call ConfiguraGrid(grdArquivo, Formulario.CadastroBasicoMolde)

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

#Region "::: MOLDE :::"

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoMolde, gcUpdate) = True Then

                With grdListagem.CurrentRow.Cells

                    'Carrega Controles
                    txtCodigo.Text = .Item("codigo_molde").Value
                    btnSalvar.Tag = .Item("codigo").Value
                    txtDescricao.Text = .Item("descricao").Value
                    txtNumeroCavidades.Value = .Item("numero_cavidades").Value
                    txtPerdaCompulsoria.Value = .Item("perda_compulsoria").Value
                    txtTempoSetupMaquina.Text = .Item("tempo_setup").Value
                    txtTempoMaoObra.Text = .Item("tempo_mao_obra").Value
                    txtTempoMaquina.Text = .Item("tempo_maquina").Value
                    txtReferencia.Value = .Item("referencia").Value
                    cboAtivo.SelectedValue = .Item("ativo").Value

                    'Carrega Grid - Máquina
                    oClsCadMolde.LoadGridMaquina(grdMaquina, .Item("codigo").Value)

                    'Carrega Grid - Produto
                    oClsCadMolde.LoadGridProduto(grdProduto, .Item("codigo").Value)

                    'Carrega Grid - Qualidade
                    oClsCadMolde.LoadGridQualidade(grdQualidade, .Item("codigo").Value)

                    'Carrega Grid - Arquivo
                    oClsCadMolde.LoadGridArquivo(grdArquivo, .Item("codigo").Value)

                End With

                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)
                tabDados.SelectedTab = pagMaquina

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

    Private Sub Delete()

        Try

            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCadMolde.Delete()

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

    Private Sub Novo()

        Try

            'Limpa Controles
            txtCodigo.Text = ""
            btnSalvar.Tag = ""
            txtDescricao.Text = ""
            txtNumeroCavidades.Value = 0
            txtPerdaCompulsoria.Value = 0
            txtTempoSetupMaquina.Text = "00:00"
            txtTempoMaoObra.Text = "00:00"
            txtTempoMaquina.Text = "00:00"
            txtReferencia.Value = 0
            cboAtivo.SelectedIndex = -1

            'Limpa Controles - Máquina
            cboCodigoMaquina.SelectedIndex = -1
            txtDescricaoMaquina.Text = ""
            grdMaquina.DataSource = Nothing

            'Limpa Controles - Produto
            txtConjunto.Value = 0
            cboCodigoProduto.SelectedIndex = -1
            txtNumeroCavidadesProduto.Value = 0
            btnInserirProduto.Tag = ""
            grdProduto.DataSource = Nothing

            'Limpa Controles - Qualidade
            cboCaracteristicaInspecionarQualidade.SelectedIndex = -1
            cboApontaQualidade.SelectedIndex = -1
            txtValorNominalQualidade.Value = 0
            txtValorMinimoQualidade.Value = 0
            txtValorMaximoQualidade.Value = 0
            txtFrequenciaQualidade.Value = 0
            txtObservacaoQualidade.Text = ""
            btnInserirQualidade.Tag = ""
            grdQualidade.DataSource = Nothing

            'Limpa Controles - Arquivo  
            txtDescricaoArquivo.Text = ""
            cboTipoArquivo.SelectedIndex = -1
            txtArquivo.Text = ""
            btnInserirArquivo.Tag = ""
            grdArquivo.DataSource = Nothing

            'Insere Registro na tb_cad_molde
            Call oClsCadMolde.Insert()

            'Seta Váriavel
            btnSalvar.Tag = oClsCadMolde.Codigo

            'Seta Aba
            tabDados.SelectedTab = pagMaquina

            'Seta Focu
            txtCodigo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadMolde.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadMolde.CodigoMolde = txtCodigo.Text.Trim
            oClsCadMolde.Descricao = txtDescricao.Text.Trim
            oClsCadMolde.NumeroCavidades = txtNumeroCavidades.Value
            oClsCadMolde.PerdaCompulsoria = txtPerdaCompulsoria.Value
            oClsCadMolde.TempoSetup = ((DatePart(DateInterval.Hour, CDate(txtTempoSetupMaquina.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtTempoSetupMaquina.Text)) + (DatePart(DateInterval.Second, CDate(txtTempoSetupMaquina.Text)) / 60))
            oClsCadMolde.TempoMaoObra = ((DatePart(DateInterval.Hour, CDate(txtTempoMaoObra.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtTempoMaoObra.Text)) + (DatePart(DateInterval.Second, CDate(txtTempoMaoObra.Text)) / 60)) / txtReferencia.Value
            oClsCadMolde.TempoMaquina = ((DatePart(DateInterval.Hour, CDate(txtTempoMaquina.Text)) * 60) + DatePart(DateInterval.Minute, CDate(txtTempoMaquina.Text)) + (DatePart(DateInterval.Second, CDate(txtTempoMaquina.Text)) / 60)) / txtReferencia.Value
            oClsCadMolde.Referencia = txtReferencia.Value
            oClsCadMolde.Ativo = cboAtivo.SelectedValue

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                Call oClsCadMolde.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else

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

            'Seta Parametros
            Call oClsCadMolde.LoadGrid(grdListagem, _
                                       txtCodigoFiltro.Text.Trim, _
                                       txtDescricaoFiltro.Text.Trim, _
                                       txtNumeroCavidadesFiltro.Value)

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

            'Verifica se foi Preenchido o Campo - Código
            If ValidaCampo(txtCodigo, lblCodigo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o Código é válido
            If oClsCadMolde.ValidaCodigo(txtCodigo.Text.Trim, _
                                         IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)) = False Then
                frmMain.errInfo.SetError(lblCodigo, "Este Código: " & txtCodigo.Text & " já está associado a outro Registro.")
                txtCodigo.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Nº Cavidades
            If txtNumeroCavidades.Enabled = True Then
                If ValidaCampo(txtNumeroCavidades, lblNumeroCavidades, True) = False Then
                    Exit Function
                End If
            End If

            ''Verifica se foi Preechido o Campo - Nº de Cavidades Corretamente            
            'Dim bFlag As Boolean = False

            'For Each oRow As GridEXRow In grdProduto.GetDataRows
            '    If txtNumeroCavidades.Value > oRow.Cells("numero_cavidades").Value Then
            '        bFlag = True
            '        Exit For
            '    End If
            'Next

            'If bFlag = True Then
            '    If grdProduto.GetTotalRow.Cells("numero_cavidades").Value <> txtNumeroCavidades.Value Then
            '        frmMain.errInfo.SetError(lblNumeroCavidades, "O Número de Cavidades informado é Inválido se comparado ao Número de Cavidades dos Produtos.")
            '        txtNumeroCavidades.Focus()
            '        Exit Function
            '    End If
            'End If

            'Verifica se foi Preenchido o Campo - Perda Compulsória
            If ValidaCampo(txtPerdaCompulsoria, lblPerdaCompulsoria, False) = False Then
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

            'Verifica se foi Selecionado o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
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

                'Atualiza Registro da tb_cad_molde_item
                Call oClsCadMolde.UpdateMaquina(btnSalvar.Tag, _
                                                cboCodigoMaquina.SelectedValue, _
                                                iCodigoRegistroAntigo)

            Else

                'Insere Registro na tb_cad_molde_item
                Call oClsCadMolde.InsertMaquina(btnSalvar.Tag, _
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
                    Call oClsCadMolde.DeleteMaquina(btnSalvar.Tag)

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
            If VerificaDireito(Formulario.CadastroBasicoMolde, gcUpdate) = True Then

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

#Region "::: PRODUTO :::"

    Private Sub SalvarProduto()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirProduto.Tag) Then

                'Atualiza Registro da tb_cad_molde_item
                Call oClsCadMolde.UpdateProduto(btnSalvar.Tag, _
                                                txtConjunto.Value, _
                                                cboCodigoProduto.SelectedValue, _
                                                txtNumeroCavidadesProduto.Value, _
                                                grdProduto.CurrentRow.Cells("codigo").Value)

            Else

                'Insere Registro na tb_cad_molde_item
                Call oClsCadMolde.InsertProduto(btnSalvar.Tag, _
                                                txtConjunto.Value, _
                                                cboCodigoProduto.SelectedValue, _
                                                txtNumeroCavidadesProduto.Value)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteProduto()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdProduto) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Produto
                    Call oClsCadMolde.DeleteProduto(btnSalvar.tag)

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

    Private Sub EditarProduto()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoMolde, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoProduto()

                'Carrega Controles
                txtConjunto.Value = grdProduto.CurrentRow.Cells("conjunto").Value
                cboCodigoProduto.SelectedValue = grdProduto.CurrentRow.Cells("codigo_item").Value
                txtNumeroCavidadesProduto.Value = grdProduto.CurrentRow.Cells("numero_cavidades").Value
                btnInserirProduto.Tag = grdProduto.CurrentRow.RowIndex

                'Seta Focu
                txtConjunto.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoProduto()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles           
            cboCodigoProduto.SelectedIndex = -1
            txtDescricaoProduto.Text = ""
            txtNumeroCavidadesProduto.Value = 0
            btnInserirProduto.Tag = ""

            'Seta Focu
            txtConjunto.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoProduto() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoProduto = False

            'Verifica se foi Preenhcido o Campo - Conjunto
            If ValidaCampo(txtConjunto, lblConjunto, True) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Produto
            If ValidaCampo(cboCodigoProduto, lblCodigoProduto) = False Then
                Exit Function
            End If

            'Verifica se o Produto é Válido
            If IsNumeric(btnInserirProduto.Tag) Then
                If VerificaExisteValorGrid(grdProduto, "codigo", cboCodigoProduto.SelectedValue, grdProduto.CurrentRow.RowIndex) Then
                    frmMain.errInfo.SetError(lblCodigoProduto, "Este Produto: " & cboCodigoProduto.Text & " já está associado a Máquina: " & txtCodigo.Text.Trim & ".")
                    cboCodigoProduto.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdProduto, "codigo", cboCodigoProduto.SelectedValue, -1) Then
                    frmMain.errInfo.SetError(lblCodigoProduto, "Este Produto: " & cboCodigoProduto.Text & " já está associado a Máquina: " & txtCodigo.Text.Trim & ".")
                    cboCodigoProduto.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Nº Cavidades
            If ValidaCampo(txtNumeroCavidadesProduto, lblNumeroCavidadesProduto, True) = False Then
                Exit Function
            ElseIf txtNumeroCavidadesProduto.Value > txtNumeroCavidades.Value Then
                frmMain.errInfo.SetError(lblNumeroCavidadesProduto, "O Número de Cavidades informado é Inválido se comparado ao Número de Cavidades do Molde.")
                txtNumeroCavidadesProduto.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoProduto = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: QUALIDADE :::"

    Private Sub SalvarQualidade()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirQualidade.Tag) Then

                'Atualiza Registro
                Call oClsCadMolde.UpdateQualidade(btnSalvar.Tag, _
                                                  cboCaracteristicaInspecionarQualidade.SelectedValue, _
                                                  cboCentroTrabalho.SelectedValue, _
                                                  cboApontaQualidade.SelectedValue, _
                                                  txtValorNominalQualidade.Text.Trim, _
                                                  txtValorMinimoQualidade.Value, _
                                                  txtValorMaximoQualidade.Value, _
                                                  txtFrequenciaQualidade.Value, _
                                                  txtObservacaoQualidade.Text.Trim, _
                                                  grdQualidade.CurrentRow.Cells("codigo").Value)

            Else

                'Insere Registro
                Call oClsCadMolde.InsertQualidade(btnSalvar.Tag, _
                                                  cboCaracteristicaInspecionarQualidade.SelectedValue, _
                                                  cboCentroTrabalho.SelectedValue, _
                                                  cboApontaQualidade.SelectedValue, _
                                                  txtValorNominalQualidade.Text.Trim, _
                                                  txtValorMinimoQualidade.Value, _
                                                  txtValorMaximoQualidade.Value, _
                                                  txtFrequenciaQualidade.Value, _
                                                  txtObservacaoQualidade.Text.Trim)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarQualidade()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicomolde, gcUpdate) = True Then

                'Carrega Controles
                cboCaracteristicaInspecionarQualidade.SelectedValue = grdQualidade.CurrentRow.Cells("codigo_caracteristica_inspecionar").Value
                cboCentroTrabalho.SelectedValue = grdQualidade.CurrentRow.Cells("codigo_centro_trabalho").Value
                cboApontaQualidade.SelectedValue = grdQualidade.CurrentRow.Cells("aponta").Value
                If grdQualidade.CurrentRow.Cells("codigo_tipo_caracteristica_inspecionar").Value = CInt(QualidadeTipoCaracteristicaInspecionar.Valor) Then
                    txtValorNominalQualidade.Value = grdQualidade.CurrentRow.Cells("valor_nominal").Value
                    txtValorMinimoQualidade.Value = grdQualidade.CurrentRow.Cells("valor_minimo").Value
                    txtValorMaximoQualidade.Value = grdQualidade.CurrentRow.Cells("valor_maximo").Value
                End If
                txtFrequenciaQualidade.Value = grdQualidade.CurrentRow.Cells("frequencia").Value
                txtObservacaoQualidade.Text = grdQualidade.CurrentRow.Cells("observacao").Value
                btnInserirQualidade.Tag = grdQualidade.CurrentRow.Cells("codigo").Value

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

    Private Sub NovoQualidade()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles 
            cboCaracteristicaInspecionarQualidade.SelectedIndex = -1
            cboCentroTrabalho.SelectedIndex = -1
            cboApontaQualidade.SelectedIndex = -1
            txtValorNominalQualidade.Value = 0
            txtValorMinimoQualidade.Value = 0
            txtValorMaximoQualidade.Value = 0
            txtFrequenciaQualidade.Value = 0
            txtObservacaoQualidade.Text = ""
            btnInserirQualidade.Tag = ""

            'Seta Focu
            cboCaracteristicaInspecionarQualidade.Focus()

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
                    Call oClsCadMolde.DeleteQualidade(btnSalvar.Tag)

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

    Private Function ValidacaoQualidade() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoQualidade = False

            'Verifica se foi Selecionado o Campo - Caracteristicas a Inspecionar
            If ValidaCampo(cboCaracteristicaInspecionarQualidade, lblCaracteristicaInspecionarQualidade) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Centro de Trabalho
            If ValidaCampo(cboCentroTrabalho, lblCentroTrabalho) = False Then
                Exit Function
            End If

            ''Verifica se a Característica é Válida
            'Dim iCurrentRow As Integer = -1
            'If IsNumeric(btnInserirQualidade.Tag) Then iCurrentRow = grdQualidade.CurrentRow.RowIndex
            ''Percorre Grid
            'For Each oRow As GridEXRow In grdQualidade.GetDataRows
            '    If oRow.Cells("codigo_caracteristica_inspecionar").Value = cboCaracteristicaInspecionarQualidade.SelectedValue AndAlso _
            '       oRow.RowIndex <> iCurrentRow Then
            '        frmMain.errInfo.SetError(lblCaracteristicaInspecionarQualidade, "Esta Característica: " & cboCaracteristicaInspecionarQualidade.Text & " já se encontra cadastrado para este Produto.")
            '        cboCaracteristicaInspecionarQualidade.Focus()
            '        Exit Function
            '    End If
            'Next

            'Verifica se foi Selecionado o Campo - Aponta
            If ValidaCampo(cboApontaQualidade, lblApontaQualidade) = False Then
                Exit Function
            End If

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
                        modFunction.DeleteArquivoBD("tb_cad_molde", oRow.Cells("path").Value, btnSalvar.Tag)
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
            If VerificaDireito(Formulario.CadastroBasicoMolde, gcUpdate) = True Then

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
                    frmMain.errInfo.SetError(lblDescricao, "Esta Descrição / Revisão já se encontra associada a um Registro.")
                    txtDescricao.Focus()
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
