Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrAdmInteractiCompare

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrAdmInteractiCompare As New clsUsrAdmInteractiCompare

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrAdmInteractiCompare_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call Comparar() Else Control_Enter(sender)
                    
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrAdmInteractiCompare_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try

            'Configura UserControl
            Call ConfigurarUserControl()

        Catch ex As Exception
            'Tratamento de Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

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
            oForm.NomeFormulario = Formulario.AdministracaoSQLCompare
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.AdministracaoSQLCompare)

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
            'Tratamento de Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnComparar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComparar.Click

        Try

            'Compara os Bancos de Dados
            Call Comparar()

        Catch ex As Exception
            'Tratamento de Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExecutar_Click(sender As Object, e As EventArgs) Handles btnExecutar.Click

        Try

            'Executa Query
            Call Executar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o UserControl
            Me.Dispose()

        Catch ex As Exception
            'Tratamento de Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo de Linha
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "executar" : Call ExecutarIndividual()

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
                                     Formulario.AdministracaoSQLCompare)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.AdministracaoSQLCompare, _
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
                                          Formulario.AdministracaoSQLCompare, _
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

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrAdmInteractiCompare_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnComparar.Enabled = VerificaDireito(Formulario.AdministracaoSQLCompare, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.AdministracaoSQLCompare, gcPrint)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.AdministracaoSQLCompare)

            'Seta Focu
            txtNomeServidorOrigem.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Tratamento de Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Comparar()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Prenchido o Campo - Nome do Servidor de Oritem
            If ValidaCampo(txtNomeServidorOrigem, lblNomeServidorOrigem, TipoCampo.texto) = False Then
                Exit Sub
            End If

            'Verifica se foi Prenchido o Campo - Usuário de Oritem
            If ValidaCampo(txtUsuarioOrigem, lblUsuarioOrigem, TipoCampo.texto) = False Then
                Exit Sub
            End If

            'Verifica se foi Prenchido o Campo - Banco de Dados
            If ValidaCampo(txtBancoDadosOrigem, lblBancoDadosOrigem, TipoCampo.texto) = False Then
                Exit Sub
            End If
            
            'Verifica se foi Prenchido o Campo - Nome do Servidor de Destino
            If ValidaCampo(txtNomeServidorDestino, lblNomeServidorDestino, TipoCampo.texto) = False Then
                Exit Sub
            End If

            'Verifica se foi Prenchido o Campo - Usuário de Destino
            If ValidaCampo(txtUsuarioDestino, lblUsuarioDestino, TipoCampo.texto) = False Then
                Exit Sub
            End If

            'Verifica se foi Prenchido o Campo - Banco de Dados
            If ValidaCampo(txtBancoDadosDestino, lblBancoDadosDestino, TipoCampo.texto) = False Then
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Executando a comparação e preenchendo a grid
            Call oClsUsrAdmInteractiCompare.Comparar(grdListagem, _
                                                     "Password= " & txtSenhaOrigem.Text.Trim & ";Persist Security Info=True;User ID=" & txtUsuarioOrigem.Text.Trim & ";Initial Catalog=" & txtBancoDadosOrigem.Text.Trim & ";Data Source=" & txtNomeServidorOrigem.Text.Trim & ";Connect Timeout = 999;", _
                                                     "Password= " & txtSenhaDestino.Text.Trim & ";Persist Security Info=True;User ID=" & txtUsuarioDestino.Text.Trim & ";Initial Catalog=" & txtBancoDadosDestino.Text.Trim & ";Data Source=" & txtNomeServidorDestino.Text.Trim & ";Connect Timeout = 999;", _
                                                     txtBancoDadosOrigem.Text.Trim, _
                                                     txtBancoDadosDestino.Text.Trim, _
                                                     txtFiltro.Text)



            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Executar()

        Try

            'Verifica se o Usuário tem direito 
            If VerificaDireito(Formulario.AdministracaoSQLCompare, gcUpdate) = True Then

                'Verifica se foi Selecionado algum Registro
                If VerificaSelecaoRow(grdListagem) = True Then

                    'Verifica se o Usuário deseja Executar o Script
                    If MsgBox("Deseja executar o Script?" & vbCrLf & vbCrLf & "Isto afetará a sua Base de Dados.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                        For Each oRow As GridEXRow In gSelecaoRow
                            'Executa a Query
                            Call ExecuteQuery(oRow.Cells("script").Value, _
                                              "Password= " & txtSenhaDestino.Text.Trim & ";Persist Security Info=True;User ID=" & txtUsuarioDestino.Text.Trim & ";Initial Catalog=" & txtBancoDadosDestino.Text.Trim & ";Data Source=" & txtNomeServidorDestino.Text.Trim & ";Connect Timeout = 999;")
                        Next

                        'Informa o usuário sobre o Sucesso da Operação
                        frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                        'Recarrega a Grid
                        Call Comparar()

                    End If

                Else
                    'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                    frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExecutarIndividual()

        Try

            'Verifica se o Usuário tem direito 
            If VerificaDireito(Formulario.AdministracaoSQLCompare, gcUpdate) = True Then

                'Verifica se o Usuário deseja Executar o Script
                If MsgBox("Deseja executar o Script?" & vbCrLf & vbCrLf & "Isto afetará a sua Base de Dados.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Executa a Query
                    Call ExecuteQuery(grdListagem.CurrentRow.Cells("script").Value, _
                                      "Password= " & txtSenhaDestino.Text.Trim & ";Persist Security Info=True;User ID=" & txtUsuarioDestino.Text.Trim & ";Initial Catalog=" & txtBancoDadosDestino.Text.Trim & ";Data Source=" & txtNomeServidorDestino.Text.Trim & ";Connect Timeout = 999;")

                    'Informa o usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                    'Recarrega a Grid
                    Call Comparar()

                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
