Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports System.IO

Public Class usrCadProdutoNFE

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadProduto As New clsUsrCadProduto
    Private oFormularioCadastroBasico() As FormularioCadastroBasico
    Private MouseIsDown As Boolean = False

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadProduto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3

                    Select Case sender.Name
                       
                    End Select

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name

                        Case "cboGrupoItemFiltro", "cboGrupoItem"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboGrupoItemFiltro : oComboBox(1) = cboGrupoItem
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
                        Case "cboCodigoNCM" : Call LoadCombo(cboCodigoNCM, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)
                        Case "cboUnidadeMedidaOrigem", "cboUnidadeMedidaDestino", "cboUnidadeMedidaEstoque", "cboUnidadeMedidaCompra", "cboUnidadeMedidaVenda"
                            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
                        
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name

                        Case "cboGrupoItem" : Call btnCadastrarGrupoItem_Click(btnCadastrarGrupoItem, System.EventArgs.Empty)
                        Case "cboCodigoNCM" : Call btnCadastrarNCM_Click(btnCadastrarNCM, System.EventArgs.Empty)

                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadProduto_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: PRODUTO :::"

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
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoProduto)

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

    Private Sub btnEditarGrid_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditarGrid.Click

        Try

            'Váriaveis Locais
            Dim sCampo(1) As String

            'Carrega Valores
            sCampo(0) = "estoque_minimo"
            sCampo(1) = "estoque_maximo"

            'Habilita Grid
            Call EditarGrid(grdListagem, _
                            sCampo, _
                            IIf(grdListagem.Tag.ToString = "E", False, True))

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarGrupoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarGrupoItem.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindGrupoItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Grupo de Item"

            'Seta Parametros
            oComboBoxFind = cboGrupoItem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboGrupoItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarGrupoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarGrupoItem.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadGrupoItem")

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboGrupoItem : oComboBox(1) = cboGrupoItemFiltro
            LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)

            'Seta Focu
            cboGrupoItem.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarNCM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarNCM.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadNCM")

            'Carrega Combo
            Call LoadCombo(cboCodigoNCM, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)
            'Seta Focu
            cboCodigoNCM.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        'Deleta Registros
        Call Delete()

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

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            cboGrupoItem.Focus()

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
            cboGrupoItemFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboGrupoItem_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboGrupoItem.SelectedIndexChanged

        Try

           
            'Verifica se foi Selecionado Algum Registro
            If cboGrupoItem.SelectedIndex > -1 And VerificaDireito(Formulario.CadastroBasicoProdutoControlesDinamicos, gcSelect) = True Then

                'Carrega Controles
                Call CarregaControles(Me, _
                                      "tb_cad_item", _
                                      cboGrupoItem.SelectedValue, _
                                      IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1))

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 3
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
    Private Sub cboCodigoNCM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoNCM.SelectedIndexChanged

        Try

            If cboCodigoNCM.SelectedIndex = -1 Then
                'Limpa Controles
                txtDescricaoNCM.Text = ""
            Else
                'Carrega Dados do NCM
                Call LoadDescricao(txtDescricaoNCM, "sp_select_cadastro_basico_descricao_ncm " & cboCodigoNCM.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Célula é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "duplicar" : Call Duplicar()
                Case "visualizar" : Call VisualizarDocumento(grdListagem.CurrentRow.Cells("arquivo_interacti").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_CellUpdated(ByVal sender As Object, ByVal e As ColumnActionEventArgs) Handles grdListagem.CellUpdated

        Try

            'Query
            Dim sQuery As String = "WHERE (((codigo) = " & grdListagem.GetValue("codigo") & "))"

            If IsNumeric(grdListagem.GetValue(e.Column.Key)) Then

                'Atualiza Registro Numérico
                Call ExecuteQuery("sp_update_interacti_table_field 'tb_cad_item', '" & e.Column.Key & "', " & IIf(IsDBNull(grdListagem.GetValue(e.Column.Key)) = False, grdListagem.GetValue(e.Column.Key).ToString.Replace(".", "").Replace(",", "."), "'NULL'") & ",'" & sQuery & "'")

            Else

                'Atualiza Registro AlphaNumérico
                Call ExecuteQuery("sp_update_interacti_table_field 'tb_cad_item', '" & e.Column.Key & "', " & IIf(IsDBNull(grdListagem.GetValue(e.Column.Key)) = False, "'" & grdListagem.GetValue(e.Column.Key).ToString.Replace("'", "") & "'", "'NULL'") & ",'" & sQuery & "'")

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.CadastroBasicoProduto)

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
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.CadastroBasicoProduto, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadProduto_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Limpa Tag
            grdListagem.Tag = ""

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcPrint)
            btnExcelGridArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcPrint)
            btnExcelGridBOM.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcPrint)
            btnExcelGridClienteVenda.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcPrint)
            btnExcelGridFornecedor.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcPrint)
            btnExcelGridLocalizacao.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcPrint)
            btnExcelGridQualidade.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcPrint)
            btnExcelGridRoteiro.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcPrint)
            btnExcelGridEmbalagem.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcPrint)
            btnEditarGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcUpdate)

            'Verifica Direito - Botão Cadastro
            btnCadastrarGrupoItem.Enabled = VerificaDireito(Formulario.CadastroBasicoGrupoItem, gcInsert)
            btnCadastrarNCM.Enabled = VerificaDireito(Formulario.CadastroBasicoNCM, gcInsert)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboGrupoItemFiltro : oComboBox(1) = cboGrupoItem
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            
            Call LoadCombo(cboCodigoNCM, "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)
            Call LoadCombo(cboOrigemItem, "sp_select_combo_static_origem_item")
            Call LoadComboSimNao(cboInsumoProducaoFiltro)
            Call LoadComboSimNao(cboControlaQualidadeFiltro)
            Call LoadComboSimNao(cboInsumoProducao)
            Call LoadComboSimNao(cboAtivo)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)
            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            'Prepara Formulário
            Call Novo()

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoProduto)

            'Seta os textos



            'Seta Focu
            cboGrupoItemFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadProduto.Delete()

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

    Private Sub Editar(ByVal lCodigo As Long)

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProduto, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                'Adiciona Aba
                tabMain.TabPages.Add(pagDados)

                'Seta Controle
                btnSalvar.Tag = lCodigo

                'Carrega Controles
                oClsCadProduto.LoadControlesNFE(lCodigo, _
                                             cboGrupoItem, _
                                             txtCodigo, _
                                             txtCodigo2, _
                                             txtCodigoEAN, _
                                             txtDescricao, _
                                             txtReferencia, _
                                             cboAtivo, _
                                             cboCodigoNCM, _
                                             cboInsumoProducao, _
                                             txtPesoLiquido, _
                                             cboOrigemItem, _
                                             txtObservacao, _
                                             chkItemEstoque, _
                                             chkItemCompra, _
                                             chkItemVenda, _
                                             chkItemProducao, _
                                             chkAtivoFixo, _
                                             cboUnidadeMedida)

               

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.SelectedTab = pagDados

                'Seta Focu
                cboGrupoItem.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Duplicar()

        Try


            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert) = True Then

                'Questiona
                If MsgBox("Deseja duplicar o produto?", MsgBoxStyle.Question + vbYesNo, "Validar duplicar produto") = vbNo Then Exit Sub

                'Váriavel Local
                Dim lCodigoItem As Long

                'Duplica Registro
                Call oClsCadProduto.Duplicar(grdListagem.CurrentRow.Cells.Item("codigo").Value, _
                                             lCodigoItem)

                'Edita Registro
                Call Editar(lCodigoItem)

                'Seta Focu
                cboGrupoItem.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoInserir)
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

            'Insere Registro no Banco de Dados
            Call oClsCadProduto.InsertNovo()
            btnSalvar.Tag = oClsCadProduto.CodigoProduto

            'Limpa Controles
            cboGrupoItem.SelectedIndex = -1
            txtCodigo.Text = ""
            txtCodigo2.Text = ""
            txtCodigoEAN.Text = ""
            cboAtivo.SelectedValue = True
            txtDescricao.Text = ""
            txtReferencia.Text = ""
            chkItemEstoque.Checked = False
            chkItemCompra.Checked = False
            chkItemVenda.Checked = False
            If goUsuario.iCodigoTipoEmpresa = CInt(TipoEmpresa.Industria) Then
                chkItemProducao.Checked = False : chkItemProducao.Enabled = True
            Else
                chkItemProducao.Enabled = False
            End If
            chkAtivoFixo.Checked = False
            'Dados Gerais
            cboCodigoNCM.SelectedIndex = -1
            cboInsumoProducao.SelectedValue = False
            txtPesoLiquido.Value = 0
            cboOrigemItem.SelectedIndex = -1
            txtObservacao.Text = ""



            'Seta Focu
            cboGrupoItem.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadProduto.CodigoProduto = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadProduto.TipoItem = CInt(TipoItem.produto)
            oClsCadProduto.GrupoItem = IIf(cboGrupoItem.SelectedIndex = -1, -1, cboGrupoItem.SelectedValue)
            oClsCadProduto.CodigoItem = txtCodigo.Text.Trim
            oClsCadProduto.CodigoItem2 = txtCodigo2.Text.Trim
            oClsCadProduto.CodigoBarras = txtCodigoEAN.Text.Trim
            oClsCadProduto.Ativo = cboAtivo.SelectedValue
            oClsCadProduto.Descricao = txtDescricao.Text.Trim
            oClsCadProduto.Referencia = txtReferencia.Text.Trim
            oClsCadProduto.CodigoMarca = -1
            oClsCadProduto.Descricao2 = ""
            oClsCadProduto.CodigoNCM = IIf(cboCodigoNCM.SelectedIndex = -1, -1, cboCodigoNCM.SelectedValue)
            oClsCadProduto.InsumoProducao = IIf(cboInsumoProducao.SelectedIndex = -1, 0, cboInsumoProducao.SelectedValue)
            oClsCadProduto.PesoLiquido = txtPesoLiquido.Value
            oClsCadProduto.CodigoOrigemItem = IIf(cboOrigemItem.SelectedIndex = -1, -1, cboOrigemItem.SelectedValue)
            oClsCadProduto.CodigoPlanoControle = -1
            oClsCadProduto.CodigoFolhaOperacao = -1
            oClsCadProduto.CodigoEspecificacaoTecnica = -1
            oClsCadProduto.QuantidadeLinhasCertificado = 0
            oClsCadProduto.Observacao = txtObservacao.Text.Trim
            oClsCadProduto.Foto = Nothing
            oClsCadProduto.FormaVenda = -1
            oClsCadProduto.CodigoGrupoItemVenda = -1
            oClsCadProduto.LeadTime = 0
            oClsCadProduto.NecessitaFornecedorHomologado = False
            oClsCadProduto.ToleranciaQuantidadeRecebimento = 0
            oClsCadProduto.ToleranciaValorRecebimento = 0
            oClsCadProduto.ToleranciaDiasRecebimento = 0
            oClsCadProduto.QuantidadeMinima = 0
            oClsCadProduto.MultiploCompra = 0
            oClsCadProduto.CodigoUnidadeMedidaEstoque = -1
            oClsCadProduto.EstoqueMinimo = 0
            oClsCadProduto.EstoqueMaximo = 0
            oClsCadProduto.CodigoMetodologiaSaidaProdutoEstoque = 4
            oClsCadProduto.ControlaLote = False
            oClsCadProduto.GeraLoteInterno = False
            oClsCadProduto.CaracaterLote = ""
            oClsCadProduto.ControlaQualidade = False
            oClsCadProduto.ControlaTempoMaximoExposicao = False
            oClsCadProduto.TempoMaximoExposicao = 0
            oClsCadProduto.ControlaValidade = False
            oClsCadProduto.ControlaDataFabricacao = False
            oClsCadProduto.PercentualDesvalorizacao = 0
            oClsCadProduto.FrequenciaDesvalorizacaoDia = 0
            oClsCadProduto.CodigoTipoAtivoFixo = IIf(cboInsumoProducao.SelectedValue = True, 2, 1)
            oClsCadProduto.Estoque = chkItemEstoque.Checked
            oClsCadProduto.Compra = chkItemCompra.Checked
            oClsCadProduto.Venda = chkItemVenda.Checked
            oClsCadProduto.Producao = chkItemProducao.Checked
            oClsCadProduto.AtivoFixo = chkAtivoFixo.Checked
            oClsCadProduto.CodigoUnidadeMedidaVenda = IIf(chkItemVenda.Checked = True, cboUnidadeMedida.SelectedValue, -1)
            oClsCadProduto.CodigoUnidadeMedidaCompra = IIf(chkItemCompra.Checked = True, cboUnidadeMedida.SelectedValue, -1)
            oClsCadProduto.CodigoUnidadeMedidaEstoque = IIf(chkItemEstoque.Checked = True, cboUnidadeMedida.SelectedValue, -1)


            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then

                'Atualiza Item
                oClsCadProduto.UpdateNFE()


                'Exclui Dados dos Controle
                Call DeletaDadosControle("tb_cad_item", btnSalvar.Tag)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                'Insere Item
                oClsCadProduto.InsertNFE()

                'Obtém Código
                btnSalvar.Tag = oClsCadProduto.CodigoProduto

                

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

            ''Insere Dados Dinâmicos
            'If Me.Controls.Find("grpControleDinamico", True).Length > 0 Then

            '    Dim oControl As Control = Me.Controls.Find("grpControleDinamico", True)(0)
            '    For Each oControleSalvar As Control In oControl.Controls

            '        If TypeOf (oControleSalvar) Is MaskedEditBox Then
            '            Dim oMaskedEditBox As MaskedEditBox = oControleSalvar
            '            Call SalvaDadosControle("tb_cad_item", _
            '                                    btnSalvar.Tag, _
            '                                    oMaskedEditBox.Name, _
            '                                    oMaskedEditBox.Text.Trim)

            '        ElseIf TypeOf (oControleSalvar) Is UIComboBox Then
            '            Dim oUiComboBox As UIComboBox = oControleSalvar
            '            If oUiComboBox.SelectedIndex > -1 Then
            '                Call SalvaDadosControle("tb_cad_item", _
            '                                        btnSalvar.Tag, _
            '                                        oUiComboBox.Name, _
            '                                        oUiComboBox.SelectedValue)
            '            End If

            '        ElseIf TypeOf (oControleSalvar) Is NumericEditBox Then
            '            Dim oNumericEditBox As NumericEditBox = oControleSalvar
            '            oNumericEditBox.Value = 0
            '            Call SalvaDadosControle("tb_cad_item", _
            '                                    btnSalvar.Tag, _
            '                                    oNumericEditBox.Name, _
            '                                    oNumericEditBox.Value)
            '        End If

            '    Next


            'End If

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
            oClsCadProduto.LoadGrid(grdListagem, _
                                    IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue), _
                                    txtCodigoFiltro.Text.Trim, _
                                    txtCodigo2Filtro.Text.Trim, _
                                    txtCodigoEANFiltro.Text.Trim, _
                                    IIf(cboInsumoProducaoFiltro.SelectedIndex = -1, -1, IIf(cboInsumoProducaoFiltro.SelectedValue = True, 1, 0)), _
                                    IIf(cboControlaQualidadeFiltro.SelectedIndex = -1, -1, IIf(cboControlaQualidadeFiltro.SelectedValue = True, 1, 0)), _
                                    txtDescricaoFiltro.Text.Trim, _
                                    IIf(cboMarcaFiltro.SelectedIndex = -1, -1, cboMarcaFiltro.SelectedValue), _
                                    txtDescricao2Filtro.Text.Trim)

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

            'Verifica se foi Selecionado o Campo - Grupo do Item
            If ValidaCampo(cboGrupoItem, lblGrupoItem) = False Then
                Exit Function
            End If

            'Verifica se não está selecionado o Código
            If txtCodigo.Text.Trim = "" Then

                If MsgBox("Deseja que o sistema gere o Código do Produto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then
                    'Gera Número do Part Number e Código do Item
                    txtCodigo.Text = oClsCadProduto.GeraCodigoItem(cboGrupoItem.SelectedValue)
                End If

            End If

            'Verifica se foi Preenchido o Campo - Código
            If ValidaCampo(txtCodigo, lblCodigo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o Código preenchido é válido
            If oClsCadProduto.ValidaCodigoProduto(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                  txtCodigo.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblCodigo, "Este Código: " & txtCodigo.Text & " já está associado a outro Registro.")
                txtCodigo.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Código EAN
            If txtCodigoEAN.Text.Trim <> "" Then
                If ValidaCampo(txtCodigoEAN, lblCodigoEAN, TipoCampo.texto) = False Then
                    tabMain.SelectedTab = pagDados
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o item é de venda
            If chkItemVenda.Checked = True Then
                'Verifica se foi Selecionado o Campo - NCM
                If ValidaCampo(cboCodigoNCM, lblCodigoNCM) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Insumo de Produção
            If ValidaCampo(cboInsumoProducao, lblInsumoProducao) = False Then
                cboInsumoProducao.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Origem
            If ValidaCampo(cboOrigemItem, lblOrigemItem) = False Then
                cboOrigemItem.Focus()
                Exit Function
            End If

           
                'Verifica se foi Selecionado o Campo - Unidade de Medida Venda
            If ValidaCampo(cboUnidadeMedida, lblUnidadeMedida) = False Then
                cboUnidadeMedida.Focus()
                Exit Function
            End If

                ''Verifica se foi Preenchido o Campo - Fator de Conversao Unidade de Medida Venda
                'If ValidaCampo(txtFatorConversaoUnidadeMedidaVenda, lblFatorConversaoUnidadeMedidaVenda, True) = False Then
                '    tabDados.SelectedTab = pagVenda : txtFatorConversaoUnidadeMedidaVenda.Focus()
                '    Exit Function
                'End If


           

           


            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region


#End Region



End Class