Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO

Public Class usrAdmInteractiSQL

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrAdmInteractiSQL As New clsUsrAdmInteractiSQL

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrAdmInteractiSQL_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try

            'Configura UserControl
            Call ConfigurarUserControl()

        Catch ex As Exception
            'Tratamento de Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrAdmInteractiSQL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.Escape
                    'Deleta Aba
                    If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
                    'Fecha o Controle
                    Me.Dispose()

                Case Keys.F5
                    Call btnExecutar_Click(btnExecutar, System.EventArgs.Empty)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
            oForm.NomeFormulario = Formulario.AdministracaoSQL
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.AdministracaoSQL)

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

    Private Sub btnAgruparGridResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridResultado.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdResultado.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdResultado.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdResultado.GroupByBoxVisible = True
                grdResultado.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridResultado.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdResultado)

        Catch ex As Exception
            'Tratamento de Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            'Tratamento de Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecutar.Click

        Try

            'Limpa Grid
            Call ClearUnboundGrid(grdResultado)

            'Executa Query
            oClsUsrAdmInteractiSQL.Executar(grdResultado, _
                                            txtDefinicao.Text)

            'Informa o usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

        Catch ex As Exception
            'Informa o Usuário sobre o Erro Ocorrido
            frmMain.Informacao(Mensagem.Erro, ex.Message)
        End Try

    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click

        Try

            'Limpa Textbox
            txtDefinicao.Text = ""

            'Limpa Colunas da Grid
            grdResultado.RootTable.Columns.Clear()

            'Limpa Linhas da Grid
            Call ClearUnboundGrid(grdResultado)

        Catch ex As Exception
            'Tratamento de Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se foi Pressionado alguma Coluna
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica qual Coluna foi Pressionada
            Select Case grdListagem.CurrentColumn.Key

                Case "definicao" : Call CarregarDefinicao()

            End Select

        Catch ex As Exception
            'Tratamento de Erro
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.AdministracaoSQL)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.AdministracaoSQL, _
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
                                          Formulario.AdministracaoSQL, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdResultado_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdResultado.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdResultado, _
                                     Formulario.AdministracaoSQL)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdResultado_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdResultado.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdResultado.Name, _
                                     Formulario.AdministracaoSQL, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdResultado_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdResultado.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdResultado.Name, _
                                          Formulario.AdministracaoSQL, _
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

            'Carrega Combo
            Call LoadCombo(cboTipo, "sp_select_combo_tipo_objeto_sql")

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrAdmInteractiSQL_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.AdministracaoSQL)
            Call ConfiguraGrid(grdResultado, Formulario.AdministracaoSQL)

            'Seta Focu
            cboTipo.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CarregarDefinicao()
        Try

            'Carregando a definição
            txtDefinicao.Text = oClsUsrAdmInteractiSQL.Definicao(grdListagem.GetValue("object_id"), grdListagem.GetValue("tipo"), grdListagem.GetValue("nome"))

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carregando os dados
            oClsUsrAdmInteractiSQL.LoadGrid(grdListagem, _
                                            IIf(cboTipo.SelectedIndex = -1, "", cboTipo.SelectedValue), _
                                            txtDefinicaoFiltro.Text)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region
   
End Class
