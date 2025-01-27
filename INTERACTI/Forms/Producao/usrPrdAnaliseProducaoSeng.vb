Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrPrdAnaliseProducaoSeng

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrPrdAnaliseProducaoSeng As New clsUsrPrdAnaliseProducaoSeng
    Private oCurrentRow As GridEXRow

#End Region

#Region "::: DADOS GERAIS :::"

    Private Sub usrPrdPlanejamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                    'Case Keys.F3
                    '    Select Case sender.Name
                    '        Case "txtClienteFiltro" : Call btnProcurarCliente_Click(btnProcurarCliente, System.EventArgs.Empty)
                    '        Case "txtProdutoFiltro" : Call btnProcurarProduto_Click(btnProcurarProduto, System.EventArgs.Empty)
                    '    End Select

                    'Case Keys.F5
                    '    Select Case sender.Name
                    '        Case "cboNumeroPedidoVendaCliente" : Call LoadCombo(cboPedidoVendaFiltro, "sp_select_combo_venda_pedido_producao " & goUsuario.iEmpresa)
                    '    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrPrdPlanejamento_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: CONTROLES :::"

    Private Sub btnAgruparGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridProduto.Click

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

    Private Sub btnConfigurarGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridProduto.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.ProducaoAnaliseSeng
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ProducaoAnaliseSeng)

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

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            If ValidaItem() = True Then

                'Carrega Dados da Grid
                Call LoadGrid()

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

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.ProducaoAnaliseSeng)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ProducaoAnaliseSeng, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.ProducaoAnaliseSeng, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboPedidoVendaFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPedidoVendaFiltro.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboPedidoVendaFiltro.SelectedIndex <> -1 Then

                'Carrega Combo
                Call LoadCombo(cboCodigoItemFiltro, "sp_select_combo_cadastro_basico_produto_analise " & goUsuario.iEmpresa & ", " & cboPedidoVendaFiltro.SelectedValue, True)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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

    Private Sub btnConfigurarGridApontamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguraGridApontamento.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdApontamento
            oForm.NomeFormulario = Formulario.ProducaoAnaliseSeng
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ProducaoAnaliseSeng)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridApontamento_Click(sender As Object, e As EventArgs) Handles btnExcelGridApontamento.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdApontamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridRequisicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridRequisicao.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdRequisicao.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdRequisicao.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdRequisicao.GroupByBoxVisible = True
                grdRequisicao.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridRequisicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridRequisicao.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdRequisicao
            oForm.NomeFormulario = Formulario.ProducaoAnaliseSeng
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdRequisicao, Formulario.ProducaoAnaliseSeng)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridRequisicao_Click(sender As Object, e As EventArgs) Handles btnExcelGridRequisicao.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridBeneficiamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridBeneficiamento.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdRequisicao.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdRequisicao.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdRequisicao.GroupByBoxVisible = True
                grdRequisicao.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridBeneficiamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridBeneficiamento.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdBeneficiamento
            oForm.NomeFormulario = Formulario.ProducaoAnaliseSeng
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdBeneficiamento, Formulario.ProducaoAnaliseSeng)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridBeneficiamento_Click(sender As Object, e As EventArgs) Handles btnExcelGridBeneficiamento.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdBeneficiamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrPrdPlanejamento_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ProducaoAnaliseSeng, gcPrint)

            'Carrega Combo
            Call LoadCombo(cboPedidoVendaFiltro, "sp_select_combo_venda_pedido " & goUsuario.iEmpresa)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ProducaoAnaliseSeng)
            Call ConfiguraGrid(grdApontamento, Formulario.ProducaoAnaliseSeng)
            Call ConfiguraGrid(grdBeneficiamento, Formulario.ProducaoAnaliseSeng)
            Call ConfiguraGrid(grdRequisicao, Formulario.ProducaoAnaliseSeng)
            Call ConfiguraGrid(grdResumo, Formulario.ProducaoAnaliseSeng)

            'Seta Focu
            cboPedidoVendaFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PLANEJAMENTO :::"

    Private Sub LoadGrid()

        Try

            'Limpa erro
            frmMain.errInfo.Clear()


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call oClsUsrPrdAnaliseProducaoSeng.LoadGrid(grdListagem, _
                                                        grdApontamento, _
                                                        grdRequisicao, _
                                                        grdBeneficiamento, _
                                                        grdResumo, _
                                                        IIf(cboPedidoVendaFiltro.SelectedIndex = -1, -1, cboPedidoVendaFiltro.SelectedValue), _
                                                        IIf(cboCodigoItemFiltro.SelectedIndex = -1, -1, cboCodigoItemFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidaItem() As Boolean

        Try

            'Seta Retorno da Função
            ValidaItem = False

            If ValidaCampo(cboPedidoVendaFiltro, lblPedidoVendaFiltro) = False Then
                Exit Function
            End If

            If ValidaCampo(cboCodigoItemFiltro, lblCodigoItemFiltro) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidaItem = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
