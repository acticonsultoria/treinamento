Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Drawing.Printing

Public Class frmPrdApontamentoOFIssartel

#Region "::: VARIAVEIS :::"

    Private oClsPrdApontamentoIssartel As New clsUsrPrdApontamentoIssartel

#End Region

#Region "::: CONTROLES :::"



    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub


    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdApontamento
            oForm.NomeFormulario = Formulario.ProducaoApontamentoManual
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdApontamento, Formulario.ProducaoApontamentoManual)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Try
            Call LoadGrid()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try

            If ValidaCampo(txtLocalizacao, lblLocalizacao, TipoCampo.texto) = False Then
                Exit Sub
            End If

            Call Salvar()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub


    Private Sub grdApontamento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdApontamento.Name, _
                                     Formulario.ProducaoApontamentoManual, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdApontamento_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdApontamento, _
                                     Formulario.ProducaoApontamentoManual)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdApontamento_GroupsChanging(sender As Object, e As GroupsChangingEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdApontamento.Name, _
                                          Formulario.ProducaoApontamentoManual, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Carrega Combo
            Call LoadComboGrid(grdApontamento, "funcionario", "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa)
            Call LoadCombo(cboOrdemProducao, "sp_select_combo_producao_ordem_producao " & goUsuario.iEmpresa, False)

            'Configura Grid
            Call ConfiguraGrid(grdApontamento, Formulario.ProducaoApontamentoManual)


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub


    Private Sub Salvar()
        Try
            'Validação
            If Validacao() = False Then Exit Sub


            'Remove os filtros
            grdApontamento.RemoveFilters()



            'Laço para inserir
            For Each oRow In grdApontamento.GetRows

                If IsDBNull(oRow.Cells.Item("data_inicio").Value) Or oRow.Cells.Item("data_inicio").Value.ToString() = "" Then
                    Continue For
                End If

                If IsDBNull(oRow.Cells.Item("funcionario").Value) Or oRow.Cells.Item("funcionario").Value.ToString() = "" Then
                    Continue For
                End If

                If oRow.Cells.Item("tipo").Value = "ANTIGO" Then
                    Continue For
                End If


                'Atualiza
                Call oClsPrdApontamentoIssartel.UpdateApontamento(1, _
                                                         cboOrdemProducao.SelectedValue, _
                                                         oRow.Cells.Item("sequencia").Value, _
                                                         0, _
                                                         0, _
                                                         0, _
                                                         oRow.Cells.Item("funcionario").Value, _
                                                          -1, _
                                                         -1, _
                                                         -1, _
                                                         oRow.Cells.Item("quantidade_produzida").Value, _
                                                         oRow.Cells.Item("quantidade_produzida").Value, _
                                                         0, _
                                                         oRow.Cells.Item("data_inicio").Value, _
                                                         oRow.Cells.Item("data_termino").Value, _
                                                          txtLocalizacao.Text.Trim, _
                                                         oRow.Cells.Item("quantidade_produzida").Value,
                                                         False)

                '
            Next

            'Informa ao usuário
            frmMain.Informacao("Apontamentos inseridos com sucesso!", Color.Blue)

            'Fecha a tela
            Me.Dispose()

        Catch ex As Exception
            tratamentoerro(ex.message, Me.parent.tostring)
        End Try
    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False



            'Verifica se foi Selecionado o Campo - Funcionário
           

            'Verifica se foi Selecionado o Campo - Turno
            If ValidaCampo(cboOrdemProducao, lblOrdemProducao) = False Then
                Exit Function
            End If


            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub LoadGrid()
        Try

            frmmain.errinfo.clear()


            If ValidaCampo(cboOrdemProducao, lblOrdemProducao) = False Then Exit Sub


            oClsPrdApontamentoIssartel.LoadGridApontamentoLoteOF(grdApontamento, cboOrdemProducao.SelectedValue)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region


  
End Class
