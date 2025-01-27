Imports Janus.Windows.GridEX

Public Class usrFindOperacao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrCadOperacao As New clsUsrCadOperacao

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrFindParceiroNegocio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If Not grdFindOperacao.CurrentRow Is Nothing Then
                        If IsNothing(oMaskedEditBoxFind) = False Then oMaskedEditBoxFind.Text = IIf(sRetornoParceiroNegocio = "CNPJ", grdFindOperacao.CurrentRow.Cells("cnpj").Value, grdFindOperacao.CurrentRow.Cells("razao_social").Value)
                        If IsNothing(oEditBoxFind) = False Then oEditBoxFind.Text = IIf(sRetornoParceiroNegocio = "CNPJ", grdFindOperacao.CurrentRow.Cells("cnpj").Value, grdFindOperacao.CurrentRow.Cells("razao_social").Value)
                        If IsNothing(oComboBoxFind) = False Then oComboBoxFind.SelectedValue = grdFindOperacao.CurrentRow.Cells("codigo").Value
                        sRetornoParceiroNegocio = ""
                        'Fecha Formulário
                        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
                    End If

                Case Keys.Escape
                    'Fecha Formulário
                    If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFindParceiroNegocio_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdFindOperacao
            oForm.NomeFormulario = Formulario.ComercialOrcamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdFindOperacao, Formulario.ComercialOrcamento)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdFindOperacao.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdFindOperacao.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdFindOperacao.GroupByBoxVisible = True
                grdFindOperacao.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdFindOperacao)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdFind_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdFindOperacao.RowDoubleClick

        Try

            If IsNothing(grdFindOperacao.CurrentRow) Then Exit Sub

            'Carrega Controles
            If IsNothing(oComboBoxFind) = False Then oComboBoxFind.SelectedValue = grdFindOperacao.CurrentRow.Cells("codigo").Value
            If IsNothing(oGridEX) = False Then oGridEX.SetValue("codigo_operacao", grdFindOperacao.CurrentRow.Cells("codigo").Value)

            'Fecha Formulário
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdFind_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdFindOperacao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFindOperacao.Name, _
                                     Formulario.ComercialOrcamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdFind_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdFindOperacao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFindOperacao, _
                                     Formulario.ComercialOrcamento)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdFind_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdFindOperacao.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdFindOperacao.Name, _
                                          Formulario.ComercialOrcamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFindParceiroNegocio_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Configura Grid
            ConfiguraGrid(grdFindOperacao, Formulario.ComercialOrcamento)

            oClsUsrCadOperacao.LoadGridFind(grdFindOperacao)

            grdFindOperacao.Focus()
            System.Windows.Forms.SendKeys.Send("{UP 1}")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

End Class
