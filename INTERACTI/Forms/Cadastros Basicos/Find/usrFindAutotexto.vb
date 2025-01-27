Imports Janus.Windows.GridEX

Public Class usrFindAutotexto
    
#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadAutotexto As New clsUsrCadAutotexto

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrFindAutotexto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)


        Try

            Select Case e.KeyCode

                Case Keys.Escape
                    'Deleta Aba
                    If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
                    'Fecha o Controle
                    Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFindAutotexto_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdFind
            oForm.NomeFormulario = Formulario.CadastroBasicoAutotexto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdFind, Formulario.CadastroBasicoAutotexto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

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
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdFind)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

        Try

            'Limpa Váriavel
            ReDim gSelecaoRow(0)

            'Verifica se foi Selecionado algum Registro
            For Each oRow As GridEXRow In grdFind.GetDataRows
                If IsDBNull(oRow.Cells("sequencia").Value) = False Then
                    If IsNothing(gSelecaoRow(UBound(gSelecaoRow))) = False Then
                        ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                    End If
                    gSelecaoRow(UBound(gSelecaoRow)) = oRow
                End If
            Next

            'Informa o Usuário da necessidade de Selecionar algum Registro
            If IsNothing(gSelecaoRow(UBound(gSelecaoRow))) = True Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                Exit Sub
            End If

            For Each oRow As GridEXRow In gSelecaoRow
                If IsNothing(oMaskedEditBoxFind) = False Then oMaskedEditBoxFind.Text &= IIf(oMaskedEditBoxFind.Text.Trim = "", "", vbCrLf) & oRow.Cells("autotexto").Value
                If IsNothing(oEditBoxFind) = False Then oEditBoxFind.Text &= IIf(oEditBoxFind.Text.Trim = "", "", vbCrLf) & oRow.Cells("autotexto").Value
            Next

            'Fecha o Formulário
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Try

            'Fecha o Formulário
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFind_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdFind.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFind.Name, _
                                     Formulario.CadastroBasicoAutotexto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFind_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdFind.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFind, _
                                     Formulario.CadastroBasicoAutotexto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFind_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdFind.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdFind.Name, _
                                          Formulario.CadastroBasicoAutotexto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFindAutotexto_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Configura Grid
            Call oClsCadAutotexto.LoadGridFind(grdFind, _
                                               CInt(iTipoAutoTextoFind))

            'Configura Grid
            Call ConfiguraGrid(grdFind, Formulario.CadastroBasicoAutotexto)

            'Seta Focu
            grdFind.Focus()
            grdFind.CurrentColumn = grdFind.RootTable.Columns.Item("autotexto")
            System.Windows.Forms.SendKeys.Send("{UP 1}")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

End Class
