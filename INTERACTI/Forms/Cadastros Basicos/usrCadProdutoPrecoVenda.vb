Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports System.IO
Imports Microsoft.Office.Interop

Public Class usrCadProdutoPrecoVenda

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadProdutoPrecoVenda As New clsUsrCadProdutoPrecoVenda
    Private sItemVenda As String = "S"
    Private sItemCompra As String = ""
    Private sItemProducao As String = ""
    Private sItemEstoque As String = ""
    Private sItemAtivoFixo As String = ""
    Private sInsumoProducao As String = ""

#End Region

#Region "::: STRUCTURE :::"

    Private Structure MensagemErro
        Dim Linha As String
        Dim Erro As String
    End Structure

    Private Structure Produto
        Dim sCodigoProduto As String
        Dim dValorCompra As Double
        Dim dCustoTeorico As Double
        Dim dPrecoVendaMinimo As Double
        Dim dPrecoVendaIdeal As Double
    End Structure

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadProdutoPrecoVenda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.Oemplus, Keys.Add
                    Select Case sender.Name
                        Case "grdListagem" : Call AdicionarObservacaoPrecoVenda()
                    End Select

                Case Keys.F3
                    Select Case sender.Name
                        Case "txtDescricaoFiltro" : Call btnProcurarItemFiltro_Click(btnProcurarProdutoFiltro, System.EventArgs.Empty)
                    End Select

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboGrupoItemFiltro" : Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Escape
                    Select Case sender.Name
                        Case "grdListagem" : cboGrupoItemFiltro.Focus()
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadProdutoPrecoVenda_Load(sender As Object, e As EventArgs) Handles Me.Load

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
            oForm.NomeFormulario = Formulario.CadastroBasicoProdutoPrecoVenda
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoProdutoPrecoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarItemFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProdutoFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemVendaFind = "S"
            oMaskedEditBoxFind = txtProdutoFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            txtProdutoFiltro.Focus()

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

    Private Sub btnEditarGrid_Click(sender As Object, e As EventArgs) Handles btnEditarGrid.Click

        Try

            'Váriaveis Locais
            Dim sCampo(9) As String

            'Carrega Valores
            sCampo(0) = "preco_compra"
            sCampo(1) = "custo_teorico"
            sCampo(2) = "margem_preco_minimo"
            sCampo(3) = "markup_preco_minimo"
            sCampo(4) = "gp_preco_minimo"
            sCampo(5) = "preco_minimo"
            sCampo(6) = "margem_preco_venda"
            sCampo(7) = "markup_preco_venda"
            sCampo(8) = "gp_preco_venda"
            sCampo(9) = "preco_venda"

            'Habilita Grid
            Call EditarGrid(grdListagem, _
                            sCampo, _
                            IIf(grdListagem.Tag.ToString = "E", False, True))

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarRevisao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarRevisao.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadProdutoPrecoVendaRevisao
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo
            Call LoadCombo(cboRevisaoFiltro, "sp_select_combo_cadastro_basico_produto_preco_venda_revisao " & goUsuario.iEmpresa)

            'Seta Focu
            cboRevisaoFiltro.Text = oForm.cboRevisao.Text.Trim
            cboRevisaoFiltro.Focus()

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

    Private Sub cboRevisaoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRevisaoFiltro.SelectedIndexChanged

        Try

            'Limpa Grid
            grdListagem.DataSource = Nothing
            
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
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtLegenda_LostFocus(sender As Object, e As EventArgs) Handles txtLegenda.LostFocus

        Try

            'Atualiza Banco de Dados
            If IsNumeric(txtLegenda.Text) Then
                Call ExecuteQuery("sp_update_interacti_table_field 'tb_cfg_interacti', 'delta_custo_medio_preco_compra_teorico', " & txtLegenda.Value.ToString.Replace(".", "").Replace(",", ".") & ", 'WHERE (((codigo_empresa) = " & goUsuario.iEmpresa & "))'")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtLegenda_ValueChanged(sender As Object, e As EventArgs) Handles txtLegenda.ValueChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim oFormatConditionLegenda As New GridEXFormatCondition(grdListagem.RootTable.Columns("delta_custo_medio_preco_compra_teorico"), ConditionOperator.LessThanOrEqualTo, txtLegenda.Value)

            For i As Integer = 0 To grdListagem.RootTable.FormatConditions.Count - 1
                grdListagem.RootTable.FormatConditions.Remove(grdListagem.RootTable.FormatConditions(0))
            Next

            oFormatConditionLegenda.FormatStyle.ForeColor = Color.Firebrick

            grdListagem.RootTable.FormatConditions.Add(oFormatConditionLegenda)
            grdListagem.Refresh()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellUpdated

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim dCustoMedio As Double = IIf(IsNumeric(grdListagem.GetValue("custo_medio")), grdListagem.GetValue("custo_medio"), 0)
            Dim dCustoTeorico As Double = IIf(IsNumeric(grdListagem.GetValue("custo_teorico")), grdListagem.GetValue("custo_teorico"), 0)
            Dim dPrecoCompra As Double = IIf(IsNumeric(grdListagem.GetValue("preco_compra")), grdListagem.GetValue("preco_compra"), 0)
            Dim dMargemPrecoMinimo As Double = IIf(IsNumeric(grdListagem.GetValue("margem_preco_minimo")), grdListagem.GetValue("margem_preco_minimo"), 0)
            Dim dMargemPrecoVenda As Double = IIf(IsNumeric(grdListagem.GetValue("margem_preco_venda")), grdListagem.GetValue("margem_preco_venda"), 0)
            Dim dMarkupPrecoMinimo As Double = IIf(IsNumeric(grdListagem.GetValue("markup_preco_minimo")), grdListagem.GetValue("markup_preco_minimo"), 0)
            Dim dMarkupPrecoVenda As Double = IIf(IsNumeric(grdListagem.GetValue("markup_preco_venda")), grdListagem.GetValue("markup_preco_venda"), 0)
            Dim dGPPrecoMinimo As Double = IIf(IsNumeric(grdListagem.GetValue("gp_preco_minimo")), grdListagem.GetValue("gp_preco_minimo"), 0)
            Dim dGPPrecoVenda As Double = IIf(IsNumeric(grdListagem.GetValue("gp_preco_venda")), grdListagem.GetValue("gp_preco_venda"), 0)
            Dim dPrecoMinimo As Double = IIf(IsNumeric(grdListagem.GetValue("preco_minimo")), grdListagem.GetValue("preco_minimo"), 0)
            Dim dPrecoVenda As Double = IIf(IsNumeric(grdListagem.GetValue("preco_venda")), grdListagem.GetValue("preco_venda"), 0)

            Select Case grdListagem.CurrentColumn.Key

                Case "custo_teorico"
                    dPrecoMinimo = dCustoTeorico + (dCustoTeorico * dMargemPrecoMinimo)
                    dMarkupPrecoMinimo = IIf(dCustoTeorico > 0, (dPrecoMinimo / dCustoTeorico), 0)
                    dGPPrecoMinimo = IIf(dPrecoMinimo > 0, (dPrecoMinimo - dCustoTeorico) / dPrecoMinimo, 0)
                    dPrecoVenda = dCustoTeorico + (dCustoTeorico * dMargemPrecoVenda)
                    dMarkupPrecoVenda = IIf(dCustoTeorico > 0, (dPrecoVenda / dCustoTeorico), 0)
                    dGPPrecoVenda = IIf(dPrecoVenda > 0, (dPrecoVenda - dCustoTeorico) / dPrecoVenda, 0)
                    grdListagem.SetValue("preco_minimo", dPrecoMinimo)
                    grdListagem.SetValue("margem_preco_minimo", dMargemPrecoMinimo)
                    grdListagem.SetValue("markup_preco_minimo", dMarkupPrecoMinimo)
                    grdListagem.SetValue("gp_preco_minimo", dGPPrecoMinimo)
                    grdListagem.SetValue("preco_venda", dPrecoVenda)
                    grdListagem.SetValue("margem_preco_venda", dMargemPrecoVenda)
                    grdListagem.SetValue("markup_preco_venda", dMarkupPrecoVenda)
                    grdListagem.SetValue("gp_preco_venda", dGPPrecoVenda)
                    grdListagem.SetValue("delta_custo_medio_preco_compra_teorico", IIf(dCustoMedio = 0, 0, (dCustoTeorico - dCustoMedio) / dCustoMedio))

                Case "margem_preco_minimo"
                    dPrecoMinimo = dCustoTeorico + (dCustoTeorico * dMargemPrecoMinimo)
                    dMarkupPrecoMinimo = IIf(dCustoTeorico > 0, (dPrecoMinimo / dCustoTeorico), 0)
                    dGPPrecoMinimo = IIf(dPrecoMinimo > 0, (dPrecoMinimo - dCustoTeorico) / dPrecoMinimo, 0)
                    grdListagem.SetValue("preco_minimo", dPrecoMinimo)
                    grdListagem.SetValue("markup_preco_minimo", dMarkupPrecoMinimo)
                    grdListagem.SetValue("gp_preco_minimo", dGPPrecoMinimo)

                Case "markup_preco_minimo"
                    dPrecoMinimo = dCustoTeorico * dMarkupPrecoMinimo
                    dMargemPrecoMinimo = IIf(dCustoTeorico > 0, (dPrecoMinimo - dCustoTeorico) / dCustoTeorico, 0)
                    dGPPrecoMinimo = IIf(dPrecoMinimo > 0, (dPrecoMinimo - dCustoTeorico) / dPrecoMinimo, 0)
                    grdListagem.SetValue("preco_minimo", dPrecoMinimo)
                    grdListagem.SetValue("margem_preco_minimo", dMargemPrecoMinimo)
                    grdListagem.SetValue("gp_preco_minimo", dGPPrecoMinimo)

                Case "gp_preco_minimo"
                    dPrecoMinimo = dCustoTeorico / (1 - dGPPrecoMinimo)
                    dMargemPrecoMinimo = IIf(dCustoTeorico > 0, (dPrecoMinimo - dCustoTeorico) / dCustoTeorico, 0)
                    dMarkupPrecoMinimo = IIf(dCustoTeorico > 0, (dPrecoMinimo / dCustoTeorico), 0)
                    grdListagem.SetValue("preco_minimo", dPrecoMinimo)
                    grdListagem.SetValue("margem_preco_minimo", dMargemPrecoMinimo)
                    grdListagem.SetValue("markup_preco_minimo", dMarkupPrecoMinimo)

                Case "preco_minimo"
                    dMargemPrecoMinimo = IIf(dCustoTeorico > 0, (dPrecoMinimo - dCustoTeorico) / dCustoTeorico, 0)
                    dMarkupPrecoMinimo = IIf(dCustoTeorico > 0, (dPrecoMinimo / dCustoTeorico), 0)
                    dGPPrecoMinimo = IIf(dPrecoMinimo > 0, (dPrecoMinimo - dCustoTeorico) / dPrecoMinimo, 0)
                    grdListagem.SetValue("margem_preco_minimo", dMargemPrecoMinimo)
                    grdListagem.SetValue("markup_preco_minimo", dMarkupPrecoMinimo)
                    grdListagem.SetValue("gp_preco_minimo", dGPPrecoMinimo)

                Case "margem_preco_venda"
                    dPrecoVenda = dCustoTeorico + (dCustoTeorico * dMargemPrecoVenda)
                    dMarkupPrecoVenda = IIf(dCustoTeorico > 0, (dPrecoVenda / dCustoTeorico), 0)
                    dGPPrecoVenda = IIf(dPrecoVenda > 0, (dPrecoVenda - dCustoTeorico) / dPrecoVenda, 0)
                    grdListagem.SetValue("preco_venda", dPrecoVenda)
                    grdListagem.SetValue("markup_preco_venda", dMarkupPrecoVenda)
                    grdListagem.SetValue("gp_preco_venda", dGPPrecoVenda)

                Case "markup_preco_venda"
                    dPrecoVenda = dCustoTeorico * dMarkupPrecoVenda
                    dMargemPrecoVenda = IIf(dCustoTeorico > 0, (dPrecoVenda - dCustoTeorico) / dCustoTeorico, 0)
                    dGPPrecoVenda = IIf(dPrecoVenda > 0, (dPrecoVenda - dCustoTeorico) / dPrecoVenda, 0)
                    grdListagem.SetValue("preco_venda", dPrecoVenda)
                    grdListagem.SetValue("margem_preco_venda", dMargemPrecoVenda)
                    grdListagem.SetValue("gp_preco_venda", dGPPrecoVenda)

                Case "gp_preco_venda"
                    dPrecoVenda = dCustoTeorico / (1 - dGPPrecoVenda)
                    dMargemPrecoVenda = IIf(dCustoTeorico > 0, (dPrecoVenda - dCustoTeorico) / dCustoTeorico, 0)
                    dMarkupPrecoVenda = IIf(dCustoTeorico > 0, (dPrecoVenda / dCustoTeorico), 0)
                    grdListagem.SetValue("preco_venda", dPrecoVenda)
                    grdListagem.SetValue("margem_preco_venda", dMargemPrecoVenda)
                    grdListagem.SetValue("markup_preco_venda", dMarkupPrecoVenda)

                Case "preco_venda"
                    dMargemPrecoVenda = IIf(dCustoTeorico > 0, (dPrecoVenda - dCustoTeorico) / dCustoTeorico, 0)
                    dMarkupPrecoVenda = IIf(dCustoTeorico > 0, (dPrecoVenda / dCustoTeorico), 0)
                    dGPPrecoVenda = IIf(dPrecoVenda > 0, (dPrecoVenda - dCustoTeorico) / dPrecoVenda, 0)
                    grdListagem.SetValue("margem_preco_venda", dMargemPrecoVenda)
                    grdListagem.SetValue("markup_preco_venda", dMarkupPrecoVenda)
                    grdListagem.SetValue("gp_preco_venda", dGPPrecoVenda)

            End Select

            'Query
            Dim sQuery As String = "WHERE (((revisao) = '" & grdListagem.GetValue("revisao") & "') AND ((codigo_item) = " & grdListagem.GetValue("codigo") & ") AND ((codigo_empresa) = " & goUsuario.iEmpresa & "))"

            Call oClsCadProdutoPrecoVenda.Save(grdListagem.GetValue("revisao"), _
                                               grdListagem.GetValue("codigo"), _
                                               grdListagem.GetValue("multiplo_venda"), _
                                               grdListagem.GetValue("custo_teorico"), _
                                               grdListagem.GetValue("preco_compra"), _
                                               grdListagem.GetValue("margem_preco_minimo"), _
                                               grdListagem.GetValue("markup_preco_minimo"), _
                                               grdListagem.GetValue("gp_preco_minimo"), _
                                               grdListagem.GetValue("preco_minimo"), _
                                               grdListagem.GetValue("margem_preco_venda"), _
                                               grdListagem.GetValue("markup_preco_venda"), _
                                               grdListagem.GetValue("gp_preco_venda"), _
                                               grdListagem.GetValue("preco_venda"))

            'Atualiza Grid
            grdListagem.Refresh()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_EditingCell(sender As Object, e As EditingCellEventArgs) Handles grdListagem.EditingCell

        Try

            'Verifica qual a Forma de Venda do Item
            If grdListagem.GetValue("codigo_forma_venda_item") = CInt(FormaVendaItem.Kit) Then e.Cancel = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.CadastroBasicoProdutoPrecoVenda)

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
                                     Formulario.CadastroBasicoProdutoPrecoVenda, _
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
                                          Formulario.CadastroBasicoProdutoPrecoVenda, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_KeyDown(sender As Object, e As KeyEventArgs) Handles grdListagem.KeyDown

        Try

                Select Case e.KeyCode

                    Case Keys.Enter
                        If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'multiplo_venda'"), Boolean) = True Then
                            Call EditarPrecoVendaMultiploVenda()
                        Else
                            Call EditarPrecoVenda()
                        End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Célula é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdListagem.CurrentColumn.Key

                Case "remover_preco_venda"
                Case "produto_preco_venda"
                    If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'multiplo_venda'"), Boolean) = True Then
                        Call EditarPrecoVendaMultiploVenda()
                    Else
                        Call EditarPrecoVenda()
                    End If
                Case "adicionar_observacao_preco_venda" : Call AdicionarObservacaoPrecoVenda()
                Case "historico_observacao_preco_venda" : Call HistoricoObservacaoPrecoVenda()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadProdutoPrecoVenda_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoPrecoVenda, gcPrint)
            btnEditarGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoProdutoPrecoVenda, gcUpdate)

            'Carrega Combo
            Call LoadCombo(cboRevisaoFiltro, "sp_select_combo_cadastro_basico_produto_preco_venda_revisao " & goUsuario.iEmpresa)
            Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)
            Call LoadCombo(cboMoedaFiltro, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)
            'Carrega Controle
            Call LoadValor(txtLegenda, "sp_select_configuracao_interacti_delta_custo_medio_preco_compra_teorico " & goUsuario.iEmpresa)
           
            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoProdutoPrecoVenda)
          
            'Seta Focu
            cboGrupoItemFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub RemoverPrecoVenda()

        Try

            'Verifica se o usuário deseja excluir o registro selecionado
            If MsgBox("Deseja excluir o Preço de Venda do Registro Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Exclui Registro
                Call oClsCadProdutoPrecoVenda.DeletePrecoVenda(grdListagem.CurrentRow.Cells("revisao").Value, _
                                                               grdListagem.CurrentRow.Cells("codigo").Value, _
                                                               grdListagem.CurrentRow.Cells("multiplo_compra").Value)

                'Recarrega a Grid
                Call LoadGrid()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AdicionarObservacaoPrecoVenda()

        Try

            'Váriaveis
            Dim lCodigoItem As Long
            Dim sRevisao As String
            Dim dMultiploVenda As Double

            'Verifica se o Usuário tem Direito
            If VerificaDireito(Formulario.CadastroBasicoProdutoPrecoVenda, gcAdministrator) = True Then

                'Váriavel - Formulário
                Dim oForm As New frmCadProdutoPrecoVendaObservacao

                lCodigoItem = grdListagem.GetValue("codigo")
                sRevisao = grdListagem.GetValue("revisao")
                dMultiploVenda = grdListagem.GetValue("multiplo_venda")

                'Seta Parâmetros
                oForm.CodigoProduto = grdListagem.GetValue("codigo_produto")
                oForm.Codigo = grdListagem.GetValue("codigo")
                oForm.SugestaoVenda = grdListagem.GetValue("sugestao_preco_venda")

                'Abre Formulário
                oForm.ShowDialog(Me)

                'Carrega Grid
                Call LoadGrid()

                Dim oCondition As New GridEXFilterCondition
                'Adiciona Condição
                oCondition.AddCondition(New GridEXFilterCondition(grdListagem.RootTable.Columns("codigo"), ConditionOperator.Equal, lCodigoItem))
                oCondition.AddCondition(New GridEXFilterCondition(grdListagem.RootTable.Columns("revisao"), ConditionOperator.Equal, sRevisao))
                oCondition.AddCondition(New GridEXFilterCondition(grdListagem.RootTable.Columns("multiplo_venda"), ConditionOperator.Equal, dMultiploVenda))
                'Seta Focu
                grdListagem.FindAll(oCondition)

            Else
                'Informa o Usuário que ele não possui Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoObservacaoPrecoVenda()

        Try

            'Váriavel - Formulário
            Dim oForm As New frmCadProdutoPrecoVendaHistorico

            'Seta Parâmetros
            oForm.CodigoProduto = grdListagem.CurrentRow.Cells("codigo_produto").Value
            oForm.CodigoProduto2 = grdListagem.CurrentRow.Cells("codigo_produto2").Value
            oForm.Descricao = grdListagem.CurrentRow.Cells("descricao").Value
            oForm.Marca = grdListagem.CurrentRow.Cells("marca").Value
            oForm.Codigo = grdListagem.CurrentRow.Cells("codigo").Value

            'Abre Formulário
            oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarPrecoVenda()

        Try

            'Verifica o Tipo de Item
            If grdListagem.CurrentRow.Cells("codigo_forma_venda_item").Value = CInt(FormaVendaItem.Kit) Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Este é um KIT, seu Preço de Venda é composto pelo Preço de Venda de seus itens.")
                Exit Sub
            End If

            'Váriavel - Formulário
            Dim oForm As New frmCadProdutoPrecoVenda

            'Seta Parâmetros
            oForm.Revisao = grdListagem.CurrentRow.Cells("revisao").Value
            oForm.CodigoProduto = grdListagem.CurrentRow.Cells("codigo_produto").Value
            oForm.CodigoProduto2 = grdListagem.CurrentRow.Cells("codigo_produto2").Value
            oForm.Descricao = grdListagem.CurrentRow.Cells("descricao").Value
            oForm.Marca = grdListagem.CurrentRow.Cells("marca").Value
            oForm.Codigo = grdListagem.CurrentRow.Cells("codigo").Value
            oForm.PrecoCompra = grdListagem.CurrentRow.Cells("preco_compra").Value
            oForm.CustoTeorico = grdListagem.CurrentRow.Cells("custo_teorico").Value
            oForm.MargemMinimo = grdListagem.CurrentRow.Cells("margem_preco_minimo").Value
            oForm.MarkupMinimo = grdListagem.CurrentRow.Cells("markup_preco_minimo").Value
            oForm.GPMinimo = grdListagem.CurrentRow.Cells("gp_preco_minimo").Value
            oForm.PrecoVendaMinimo = grdListagem.CurrentRow.Cells("preco_minimo").Value
            oForm.MargemIdeal = grdListagem.CurrentRow.Cells("margem_preco_venda").Value
            oForm.MarkupIdeal = grdListagem.CurrentRow.Cells("markup_preco_venda").Value
            oForm.GPIdeal = grdListagem.CurrentRow.Cells("gp_preco_venda").Value
            oForm.PrecoVendaIdeal = grdListagem.CurrentRow.Cells("preco_venda").Value
            oForm.Grid = grdListagem

            'Abre Formulário
            oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarPrecoVendaMultiploVenda()

        Try

            'Verifica o Tipo de Item
            If grdListagem.CurrentRow.Cells("codigo_forma_venda_item").Value = CInt(FormaVendaItem.Kit) Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Este é um KIT, seu Preço de Venda é composto pelo Preço de Venda de seus itens.")
                Exit Sub
            End If

            'Váriavel - Formulário
            Dim oForm As New frmCadProdutoPrecoVendaQuantidadeMinima
            Dim lCodigoItem As Long
            Dim sRevisao As String
            Dim dMultiploVenda As Double

            'Seta Parâmetros
            oForm.Revisao = grdListagem.GetValue("revisao")
            oForm.CodigoProduto = grdListagem.GetValue("codigo_produto")
            oForm.CodigoProduto2 = grdListagem.GetValue("codigo_produto2")
            oForm.Descricao = grdListagem.GetValue("descricao")
            oForm.Marca = grdListagem.GetValue("marca")
            oForm.Codigo = grdListagem.GetValue("codigo")
            oForm.PrecoCompra = grdListagem.GetValue("preco_compra")
            oForm.CustoTeorico = grdListagem.GetValue("custo_teorico")
            oForm.MargemMinimo = grdListagem.GetValue("margem_preco_minimo")
            oForm.MarkupMinimo = grdListagem.GetValue("markup_preco_minimo")
            oForm.GPMinimo = grdListagem.GetValue("gp_preco_minimo")
            oForm.PrecoVendaMinimo = grdListagem.GetValue("preco_minimo")
            oForm.MargemIdeal = grdListagem.GetValue("margem_preco_venda")
            oForm.MarkupIdeal = grdListagem.GetValue("markup_preco_venda")
            oForm.GPIdeal = grdListagem.GetValue("gp_preco_venda")
            oForm.PrecoVendaIdeal = grdListagem.GetValue("preco_venda")
            oForm.MultiploVenda = grdListagem.GetValue("multiplo_venda")
            oForm.CodigoMoeda = grdListagem.GetValue("codigo_moeda")
            oForm.Cotacao = grdListagem.GetValue("cotacao")
            oForm.PrecoCompraReais = grdListagem.GetValue("preco_compra_reais")
            oForm.PorcentagemCustos = grdListagem.GetValue("porcentagem_custos")
            oForm.PorcentagemImpostos = grdListagem.GetValue("porcentagem_impostos")
            oForm.Grid = grdListagem

            'Abre Formulário
            oForm.ShowDialog(Me)

            lCodigoItem = grdListagem.GetValue("codigo")
            sRevisao = grdListagem.GetValue("revisao")
            dMultiploVenda = oForm.MultiploVenda

            'Carrega Grid
            Call LoadGrid()
            
            Dim oCondition As New GridEXFilterCondition
            'Adiciona Condição
            oCondition.AddCondition(New GridEXFilterCondition(grdListagem.RootTable.Columns("codigo"), ConditionOperator.Equal, lCodigoItem))
            oCondition.AddCondition(New GridEXFilterCondition(grdListagem.RootTable.Columns("revisao"), ConditionOperator.Equal, sRevisao))
            oCondition.AddCondition(New GridEXFilterCondition(grdListagem.RootTable.Columns("multiplo_venda"), ConditionOperator.Equal, dMultiploVenda))
            'Seta Focu
            grdListagem.FindAll(oCondition)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Revisao
            If ValidaCampo(cboRevisaoFiltro, lblRevisaoFiltro) = False Then
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Cabeçalho
            grdListagem.RootTable.Columns("numero_orcamentos_periodo").Caption = "Nº Orçamentos Últm. " & txtNumeroMesesOrcamento.Value.ToString & " Meses"
            grdListagem.RootTable.Columns("numero_orcamentos_vitoriosos_periodo").Caption = "Nº Orçamentos Vitoriosos Últm. " & txtNumeroMesesOrcamento.Value.ToString & " Meses"
            grdListagem.RootTable.Columns("numero_pedidos_periodo").Caption = "Nº Pedidos Últm. " & txtNumeroMesesPedidoVenda.Value.ToString & " Meses"

            'Seta Parametros
            oClsCadProdutoPrecoVenda.LoadGrid(grdListagem, _
                                              cboRevisaoFiltro.SelectedValue, _
                                              IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue), _
                                              txtProdutoFiltro.Text.Trim, _
                                              IIf(cboMoedaFiltro.SelectedIndex = -1, -1, cboMoedaFiltro.SelectedValue), _
                                              txtCotacao.Value)

            'Move Registro
            grdListagem.MoveFirst()

            'Altera Legenda
            Call txtLegenda_ValueChanged(txtLegenda, System.EventArgs.Empty)

            'Seta Focu
            grdListagem.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Throw ex
        End Try

    End Sub

#End Region

End Class

