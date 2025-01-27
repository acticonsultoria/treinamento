Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrCadProcedimentoCirurgico

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadProcedimemtoCirurgico As New clsUsrCadProcedimentoCirurgico

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadProcedimentoCirurgico_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGridProcedimentoCirurgico() Else Control_Enter(sender)

                Case Keys.F3
                    Select Case sender.Name
                        Case "cboCodigoItem" : Call btnProcurarItem_Click(btnProcurarItem, System.EventArgs.Empty)
                    End Select

                Case Keys.F5
                    Select Case sender.Name
                        Case "cboCodigoItem" : Call LoadCombo(cboCodigoItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", 1, NULL, " & TipoItem.produto)
                        Case "cboUnidadeMedida" : Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
                    End Select

                Case Keys.Oemplus, Keys.Add
                    Select Case sender.Name
                        Case "cboCodigoItem" : Call btnCadastrarItem_Click(btnCadastrarItem, System.EventArgs.Empty)
                        Case "cboUnidadeMedida" : Call btnCadastrarUnidadeMedida_Click(btnCadastrarUnidadeMedida, System.EventArgs.Empty)
                    End Select
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadProcedimentoCirurgico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: PROCEDIMENTO CIRURGICO :::"

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
            oForm.NomeFormulario = Formulario.CadastroBasicoProcedimentoCirurgico
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoProcedimentoCirurgico)

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
            Call DeleteProcedimentoCirurgico()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGridProcedimentoCirurgico()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoProcedimentoCirurgico()

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
            Call NovoProcedimentoCirurgico()

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
            If ValidacaoProcedimentoCirurgico() = True Then

                'Salva Dados do Registro
                Call SalvarProcedimentoCirurgico()
                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoProcedimentoCirurgico()

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
            Call LoadGridProcedimentoCirurgico()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtDescricaoFiltro.Focus()

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

                Case "editar" : Call EditarProcedimentoCirurgico()

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
                                     Formulario.CadastroBasicoProcedimentoCirurgico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoProcedimentoCirurgico, _
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
                                          Formulario.CadastroBasicoProcedimentoCirurgico, _
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
            oForm.NomeFormulario = Formulario.CadastroBasicoProcedimentoCirurgico
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdProduto, Formulario.CadastroBasicoProcedimentoCirurgico)

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

    Private Sub btnCadastrarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarItem.Click

        Try

               'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo            
            Call LoadCombo(cboCodigoItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", 1, NULL, " & TipoItem.produto)

            'Seta Focu
            cboCodigoItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedida.Click

        Try

                'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo            
            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            'Seta Focu
            cboUnidadeMedida.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItem.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = LoadDescricao("sp_select_configuracao_interacti_texto " & goUsuario.iEmpresa & ",'formulario_find_produto_orcamento'")
            oForm.UsrControl = IIf(oForm.UsrControl = "", "usrFindItem", oForm.UsrControl)
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros            
            iCodigoTipoItemFind = TipoItem.produto
            sItemVendaFind = "S"
            sItemAtivoFixoFind = ""
            sItemEstoqueFind = ""
            sItemCompraFind = ""
            sItemProducaoFind = ""
            bInserirProdutoFind = True
            sTipoFind = "VENDAS"
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

    Private Sub btnInserirProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirProduto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Produto
            If ValidacaoProduto() = True Then

                'Váriaveis Locais
                Dim lCodigoProdutoAntigo As Long = -1

                If IsNumeric(btnInserirProduto.Tag) Then
                    lCodigoProdutoAntigo = grdProduto.CurrentRow.Cells("codigo_item").Value
                End If

                'Insere Registro na Grid
                Call oClsCadProcedimemtoCirurgico.InsertProdutoGrid(grdProduto, _
                                                                    cboCodigoItem.SelectedValue, _
                                                                    cboCodigoItem.Text, _
                                                                    txtDescricaoItem.Text, _
                                                                    txtQuantidade.Value, _
                                                                    cboUnidadeMedida.SelectedValue, _
                                                                    cboUnidadeMedida.Text, _
                                                                    lCodigoProdutoAntigo)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoProduto()

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

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCodigoItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoItem.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboCodigoItem.SelectedIndex = -1 Then
                txtDescricaoItem.Text = ""
            Else
                Dim oClsCadProduto As New clsUsrCadProduto
                oClsCadProduto.LoadDadosProduto(cboCodigoItem.SelectedValue, txtDescricaoItem)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagemProduto_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdProduto.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdProduto.CurrentColumn) Then Exit Sub

            Select Case grdProduto.CurrentColumn.Key

                Case "editar" : Call EditarProduto()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagemProduto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdProduto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto, _
                                     Formulario.CadastroBasicoProcedimentoCirurgico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagemProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto.Name, _
                                     Formulario.CadastroBasicoProcedimentoCirurgico, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagemProduto_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdProduto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdProduto.Name, _
                                          Formulario.CadastroBasicoProcedimentoCirurgico, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadProcedimentoCirurgico_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoProcedimentoCirurgico, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoProcedimentoCirurgico, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroBasicoProcedimentoCirurgico, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoProcedimentoCirurgico, gcPrint)
            btnInserirProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProcedimentoCirurgico, gcInsert)
            btnExcluirProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProcedimentoCirurgico, gcDelete)
            btnExcelGridProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProcedimentoCirurgico, gcPrint)

            'Verifica Direito - Cadastrar
            btnCadastrarItem.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
            btnCadastrarUnidadeMedida.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)

            'Carrega Combo
            Call LoadComboSimNao(cboAtivo)
            Call LoadCombo(cboCodigoItem, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", 1, NULL, " & CInt(TipoItem.produto))
            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoProcedimentoCirurgico)
            Call ConfiguraGrid(grdProduto, Formulario.CadastroBasicoProcedimentoCirurgico)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtDescricaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PROCEDIMENTO CIRURGICO :::"

    Private Sub DeleteProcedimentoCirurgico()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadProcedimemtoCirurgico.DeleteProcedimentoCirurgico()

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

    Private Sub NovoProcedimentoCirurgico()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Procedimento
            txtDescricao.Text = ""
            cboAtivo.SelectedValue = True
            btnSalvar.Tag = ""

            'Limpa Controles - Produto
            cboCodigoItem.Text = ""
            txtDescricao.Text = ""
            cboUnidadeMedida.Text = ""
            txtQuantidade.Value = 0
            btnInserirProduto.Tag = ""
            grdProduto.DataSource = Nothing

            'Seta Focu
            txtDescricao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarProcedimentoCirurgico()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoProcedimentoCirurgico, gcUpdate) = True Then

                'Seta Controles
                txtDescricao.Text = grdListagem.CurrentRow.Cells("descricao").Value
                cboAtivo.SelectedValue = grdListagem.CurrentRow.Cells("ativo").Value
                btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value

                'Carrega Grid - Linha
                oClsCadProcedimemtoCirurgico.LoadGridProduto(grdProduto, _
                                                             grdListagem.CurrentRow.Cells("codigo").Value)

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

    Private Sub SalvarProcedimentoCirurgico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadProcedimemtoCirurgico.CodigoProcedimento = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadProcedimemtoCirurgico.Descricao = txtDescricao.Text.Trim
            oClsCadProcedimemtoCirurgico.Ativo = cboAtivo.SelectedValue

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                Call oClsCadProcedimemtoCirurgico.UpdateProcedimentoCirurgico()
                Call oClsCadProcedimemtoCirurgico.DeleteProduto()
                Call oClsCadProcedimemtoCirurgico.InsertProduto(grdProduto)
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                Call oClsCadProcedimemtoCirurgico.InsertProcedimentoCirurgico()
                Call oClsCadProcedimemtoCirurgico.InsertProduto(grdProduto)
                btnSalvar.Tag = oClsCadProcedimemtoCirurgico.CodigoProcedimento
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridProcedimentoCirurgico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            Call oClsCadProcedimemtoCirurgico.LoadGridProcedimentoCirurgico(grdListagem, _
                                                                            txtDescricaoFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoProcedimentoCirurgico() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoProcedimentoCirurgico = False

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Valida se o Ano é válido
            If oClsCadProcedimemtoCirurgico.ValidaDescricao(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                                            txtDescricao.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblDescricao, "Esta Descrição já está associado a outro Registro")
                txtDescricao.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Ano
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoProcedimentoCirurgico = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: PRODUTO :::"

    Private Sub DeleteProduto()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdProduto) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Linha
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

    Private Sub NovoProduto()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboCodigoItem.Text = ""
            txtDescricaoItem.Text = ""
            cboUnidadeMedida.Text = ""
            txtQuantidade.Value = 0
            btnInserirProduto.Tag = ""

            'Seta Focu
            cboCodigoItem.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarProduto()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoProcedimentoCirurgico, gcUpdate) = True Then

                'Seta Controles
                cboCodigoItem.SelectedValue = grdProduto.CurrentRow.Cells("codigo_item").Value
                txtDescricaoItem.Text = grdProduto.CurrentRow.Cells("descricao").Value
                txtQuantidade.Value = grdProduto.CurrentRow.Cells("quantidade").Value
                cboUnidadeMedida.SelectedValue = grdProduto.CurrentRow.Cells("codigo_unidade_medida").Value
                btnInserirProduto.Tag = grdProduto.CurrentRow.Cells("codigo_item").Value

                'Seta Focu
                cboCodigoItem.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoProduto() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoProduto = False

            'Verifica se foi Selecionado o Campo - Data
            If ValidaCampo(cboCodigoItem, lblCodigoItem) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidade, lblQuantidade, True) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Unidade de Medida
            If ValidaCampo(cboUnidadeMedida, lblUnidadeMedida) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoProduto = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
