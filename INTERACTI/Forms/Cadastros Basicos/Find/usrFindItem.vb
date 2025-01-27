Imports Janus.Windows.GridEX

Public Class usrFindItem

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadProduto As New clsUsrCadProduto

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFindItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown


        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If Not grdFind.CurrentRow Is Nothing Then
                        If IsNothing(oMaskedEditBoxFind) = False Then oMaskedEditBoxFind.Text = grdFind.CurrentRow.Cells("descricao").Value
                        If IsNothing(oEditBoxFind) = False Then oEditBoxFind.Text = grdFind.CurrentRow.Cells("descricao").Value
                        If IsNothing(oComboBoxFind) = False Then oComboBoxFind.SelectedValue = grdFind.CurrentRow.Cells("codigo").Value
                        If IsNothing(oGridEX) = False Then
                            oGridEX.SetValue("codigo_item", grdFind.CurrentRow.Cells.Item("codigo").Value)
                            oGridEX.SetValue("codigo_produto_servico", grdFind.CurrentRow.Cells.Item("codigo_item").Value)
                            oGridEX.SetValue("descricao", grdFind.CurrentRow.Cells.Item("descricao").Value)
                            oGridEX.SetValue("ncm", grdFind.CurrentRow.Cells.Item("ncm").Value)
                            oGridEX.SetValue("codigo_ncm", grdFind.CurrentRow.Cells.Item("codigo_ncm").Value)
                            oGridEX.SetValue("codigo_origem_item", grdFind.CurrentRow.Cells.Item("codigo_origem_item").Value)
                        End If
                        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
                    End If

                Case Keys.Escape
                    If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
                    
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.TExt)
        End Try

    End Sub

    Private Sub frmFindItem_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdFind.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdFind.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdFind.GroupByBoxVisible = True
                grdFind.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.TExt)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdFind
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdFind, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.TExt)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdFind)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.TExt)
        End Try

    End Sub

    Private Sub grdFind_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdFind.RowDoubleClick

        Try

            'Seta Controles
            If IsNothing(oMaskedEditBoxFind) = False Then oMaskedEditBoxFind.Text = grdFind.CurrentRow.Cells("descricao").Value
            If IsNothing(oEditBoxFind) = False Then oEditBoxFind.Text = grdFind.CurrentRow.Cells("descricao").Value
            If IsNothing(oComboBoxFind) = False Then oComboBoxFind.SelectedValue = grdFind.CurrentRow.Cells("codigo").Value
            If IsNothing(oGridEX) = False Then
                oGridEX.SetValue("codigo_item", grdFind.CurrentRow.Cells.Item("codigo").Value)
                oGridEX.SetValue("codigo_produto_servico", grdFind.CurrentRow.Cells.Item("codigo_item").Value)
                oGridEX.SetValue("descricao", grdFind.CurrentRow.Cells.Item("descricao").Value)
                oGridEX.SetValue("ncm", grdFind.CurrentRow.Cells.Item("ncm").Value)
                oGridEX.SetValue("codigo_ncm", grdFind.CurrentRow.Cells.Item("codigo_ncm").Value)
                oGridEX.SetValue("codigo_origem_item", grdFind.CurrentRow.Cells.Item("codigo_origem_item").Value)
            End If
            If IsNothing(oGridExOrcamento) = False Then
                oGridExOrcamento.SetValue("codigo_produto", grdFind.CurrentRow.Cells("codigo_item").Value)
                oGridExOrcamento.SetValue("descricao", grdFind.CurrentRow.Cells("descricao").Value)
            End If
            'Fecha Formulário
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)                    

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.TExt)
        End Try

    End Sub

    Private Sub grdFind_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdFind.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFind.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.TExt)
        End Try

    End Sub

    Private Sub grdFind_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdFind.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFind, _
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.TExt)
        End Try

    End Sub

    Private Sub grdFind_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdFind.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdFind.Name, _
                                          Formulario.CadastroBasicoProduto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.TExt)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFindItem_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            If bIndicador = True Then

                Call oClsCadProduto.LoadGridFindIndicador(grdFind)

            Else
                'Configura Grid
                Call oClsCadProduto.LoadGridFind(grdFind, _
                                                 iCodigoTipoItemFind, _
                                                 sItemVendaFind, _
                                                 sItemCompraFind, _
                                                 sItemProducaoFind, _
                                                 sItemEstoqueFind, _
                                                 sItemAtivoFixoFind, _
                                                 sInsumoProducaoFind)

                If iCodigoTipoItemFind = CInt(TipoItem.produto) Then
                    Me.Parent.Text = "Procurar Produto"
                ElseIf iCodigoTipoItemFind = CInt(TipoItem.servico) Then
                    Me.Parent.Text = "Procurar Serviço"
                End If

            End If

            'Configura Grid
            Call ConfiguraGrid(grdFind, Formulario.CadastroBasicoProduto)

            'Seta Focu
            grdFind.Focus()
            grdFind.CurrentColumn = grdFind.RootTable.Columns.Item("descricao")
            System.Windows.Forms.SendKeys.Send("{UP 1}")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.TExt)
        End Try

    End Sub

#End Region

End Class
