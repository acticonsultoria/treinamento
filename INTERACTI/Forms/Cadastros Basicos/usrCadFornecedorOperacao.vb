Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrCadFornecedorOperacao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadFornecedorOperacao As New clsUsrCadFornecedorOperacao

#End Region

#Region "::: CONTROLES :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    'If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click, btnSair2.Click

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

    Private Sub cboOperacao_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboOperacao.SelectedValueChanged
        Try

            LoadGridFornecedoresDisponiveis(cboOperacao.SelectedValue)
            LoadGridFornecedoresAtribuidos(cboOperacao.SelectedValue)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboFornecedor_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboFornecedor.SelectedValueChanged
        Try

            LoadGridOperacoesDisponiveis(cboFornecedor.SelectedValue)
            LoadGridOperacoesAtribuidas(cboFornecedor.SelectedValue)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdOperacoesDisponiveis_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdOperacoesDisponiveis.RowDoubleClick
        Try

            If IsNothing(sender.CurrentColumn) Then Exit Sub

            Select Case sender.CurrentColumn.Key
                Case "adicionar" : oClsCadFornecedorOperacao.Insert(cboFornecedor.SelectedValue,
                                                                    grdOperacoesDisponiveis.CurrentRow.Cells.Item("codigo_operacao").Value) : LoadGridsOperacoes()
            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdOperacoesAtribuidas_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdOperacoesAtribuidas.RowDoubleClick
        Try
            If IsNothing(sender.CurrentColumn) Then Exit Sub
            Select Case sender.CurrentColumn.Key
                Case "remover" : oClsCadFornecedorOperacao.Delete(cboFornecedor.SelectedValue,
                                                                  grdOperacoesAtribuidas.CurrentRow.Cells.Item("codigo_operacao").Value) : LoadGridsOperacoes()
            End Select
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdFornecedoresDisponiveis_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdFornecedoresDisponiveis.RowDoubleClick
        Try
            If IsNothing(sender.CurrentColumn) Then Exit Sub
            Select Case sender.CurrentColumn.Key
                Case "adicionar" : oClsCadFornecedorOperacao.Insert(grdFornecedoresDisponiveis.CurrentRow.Cells.Item("codigo_fornecedor").Value,
                                                                    cboOperacao.SelectedValue) : LoadGridsFornecedores()
            End Select
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdFornecedoresAtribuidos_RowDoubleClick(sender As Object, e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdFornecedoresAtribuidos.RowDoubleClick
        Try
            If IsNothing(sender.CurrentColumn) Then Exit Sub
            Select Case sender.CurrentColumn.Key

                Case "remover" : oClsCadFornecedorOperacao.Delete(grdFornecedoresAtribuidos.CurrentRow.Cells.Item("codigo_fornecedor").Value,
                                                                  cboOperacao.SelectedValue) : LoadGridsFornecedores()

                Case "subir_ordem" : oClsCadFornecedorOperacao.UpdateOrdem(grdFornecedoresAtribuidos.CurrentRow.Cells.Item("codigo_fornecedor").Value,
                                                                          cboOperacao.SelectedValue,
                                                                          grdFornecedoresAtribuidos.CurrentRow.Cells.Item("ordem").Value,
                                                                          True) : LoadGridsFornecedores()

                Case "descer_ordem" : oClsCadFornecedorOperacao.UpdateOrdem(grdFornecedoresAtribuidos.CurrentRow.Cells.Item("codigo_fornecedor").Value,
                                                                            cboOperacao.SelectedValue,
                                                                            grdFornecedoresAtribuidos.CurrentRow.Cells.Item("ordem").Value,
                                                                            False) : LoadGridsFornecedores()
            End Select
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAdicionarSelecionadosFornecedores_Click(sender As Object, e As EventArgs) Handles btnAdicionarSelecionadosFornecedores.Click
        Try
            If grdFornecedoresDisponiveis.GetCheckedRows.Count = 0 Then Exit Sub
            For Each oRow In grdFornecedoresDisponiveis.GetCheckedRows

                oClsCadFornecedorOperacao.Insert(oRow.Cells.Item("codigo_fornecedor").Value,
                                                 cboOperacao.SelectedValue)

            Next

            LoadGridsFornecedores()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnRemoverTodosFornecedores_Click(sender As Object, e As EventArgs) Handles btnRemoverTodosFornecedores.Click
        Try
            If grdFornecedoresAtribuidos.GetCheckedRows.Count = 0 Then Exit Sub

            For Each oRow In grdFornecedoresDisponiveis.GetCheckedRows

                oClsCadFornecedorOperacao.Delete(oRow.Cells.Item("codigo_fornecedor").Value,
                                                 cboOperacao.SelectedValue)

            Next
            LoadGridsFornecedores()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAdicionarOperacoesSelecionadas_Click(sender As Object, e As EventArgs) Handles btnAdicionarOperacoesSelecionadas.Click
        Try
            If grdOperacoesDisponiveis.GetCheckedRows.Count = 0 Then Exit Sub
            For Each oRow In grdOperacoesDisponiveis.GetCheckedRows

                oClsCadFornecedorOperacao.Insert(cboFornecedor.SelectedValue,
                                                 oRow.Cells.Item("codigo_operacao").Value)

            Next

            LoadGridsOperacoes()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnRemoverOperacoesSelecionadas_Click(sender As Object, e As EventArgs) Handles btnRemoverOperacoesSelecionadas.Click
        Try
            If grdOperacoesAtribuidas.GetCheckedRows.Count = 0 Then Exit Sub
            For Each oRow In grdOperacoesAtribuidas.GetCheckedRows

                oClsCadFornecedorOperacao.Delete(cboFornecedor.SelectedValue,
                                                 oRow.Cells.Item("codigo_operacao").Value)

            Next

            LoadGridsOperacoes()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"
    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " + goUsuario.iEmpresa.ToString())

            LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_operacao -1," + goUsuario.iEmpresa.ToString())

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGridOperacoesDisponiveis(ByVal iCodigoFornecedor As Integer)
        Try

            oClsCadFornecedorOperacao.LoadGridOperacoesDisponiveis(grdOperacoesDisponiveis, iCodigoFornecedor)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadGridOperacoesAtribuidas(ByVal iCodigoFornecedor As Integer)
        Try

            oClsCadFornecedorOperacao.LoadGridOperacoesAtribuidas(grdOperacoesAtribuidas, iCodigoFornecedor)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadGridFornecedoresDisponiveis(ByVal iCodigoOperacao As Integer)
        Try

            oClsCadFornecedorOperacao.LoadGridFornecedoresDisponiveis(grdFornecedoresDisponiveis, iCodigoOperacao)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadGridFornecedoresAtribuidos(ByVal iCodigoOperacao As Integer)
        Try

            oClsCadFornecedorOperacao.LoadGridFornecedoresAtribuidos(grdFornecedoresAtribuidos, iCodigoOperacao)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnProcurarOperacao_Click(sender As Object, e As EventArgs) Handles btnProcurarOperacao.Click
        Try
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindOperacao"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Operação"

            'Seta Parametros
            oComboBoxFind = cboOperacao
            oForm.ShowDialog(Me)

            cboOperacao.Focus()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnProcurarFornecedor_Click(sender As Object, e As EventArgs) Handles btnProcurarFornecedor.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.fornecedor
            oComboBoxFind = cboFornecedor
            oForm.ShowDialog(Me)

            cboFornecedor.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try
    End Sub

    Private Sub LoadGridsOperacoes()
        Try

            LoadGridOperacoesAtribuidas(cboFornecedor.SelectedValue)

            LoadGridOperacoesDisponiveis(cboFornecedor.SelectedValue)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadGridsFornecedores()
        Try

            LoadGridFornecedoresAtribuidos(cboOperacao.SelectedValue)

            LoadGridFornecedoresDisponiveis(cboOperacao.SelectedValue)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class
