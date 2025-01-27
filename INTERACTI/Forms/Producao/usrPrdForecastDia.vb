Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math

Public Class usrPrdForecastDia

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsPrdForecast As New clsUsrPrdForecast

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrPrdForecastDia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F5
                    Select Case sender.Name
                        Case "cboGrupoItemFiltro" : Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrPrdForecastDia_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

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
            oForm.NomeFormulario = Formulario.ProducaoForecastDia
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ProducaoForecastDia)

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

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 0
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_CellValueChanged(sender As Object, e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.CellValueChanged

        Try

            'Verifica o Tipo de Linha
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub
            If grdListagem.CurrentRow.RowType <> RowType.Record Then Exit Sub

            'Verifica se foi alterado o Mês
            If grdListagem.CurrentColumn.Key.ToString.Substring(0, 3) = "DIA" Then

                'Atualiza Programação
                Call oClsPrdForecast.UpdateGrupoItem(grdListagem.GetValue("codigo"), _
                                                     grdListagem.GetValue(e.Column.Key), _
                                                     e.Column.Tag)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ProducaoForecastDia, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.ProducaoForecastDia)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.ProducaoForecastDia, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrPrdForecastDia_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ProducaoForecastDia)

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ProducaoForecastDia, gcPrint)

            'Seta Focu
            cboGrupoItemFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim i As Integer

            'Exclui Colunas
            For i = grdListagem.RootTable.Columns.Count - 1 To 1 Step -1
                If grdListagem.RootTable.Columns(i).Key.Substring(0, 3) = "DIA" Then
                    grdListagem.RootTable.Columns.Remove(grdListagem.RootTable.Columns(i).Key)
                End If
            Next

            'Carrega Colunas
            For i = 1 To System.DateTime.DaysInMonth(DatePart(DateInterval.Year, dtpMesFiltro.Value), DatePart(DateInterval.Month, dtpMesFiltro.Value))

                Dim oColumn As New GridEXColumn
                oColumn.Caption = Format(i, "00")
                oColumn.Key = "DIA" & i
                oColumn.Tag = Format(i, "00") & "/" & Format(DatePart(DateInterval.Month, dtpMesFiltro.Value), "00") & "/" & Format(DatePart(DateInterval.Year, dtpMesFiltro.Value), "0000")
                oColumn.Width = 50
                oColumn.HideWhenGrouped = InheritableBoolean.False
                oColumn.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.HeaderLineAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.InputMask = "Number2"
                oColumn.FilterRowComparison = ConditionOperator.Equal
                oColumn.FormatString = "#,#0.00"
                oColumn.AggregateFunction = AggregateFunction.Sum
                oColumn.TotalFormatString = "#,#0.00"
                oColumn.EditType = EditType.TextBox
                oColumn.CellStyle.BackColor = Color.FromArgb(255, 255, 225)
                oColumn.CellToolTip = CellToolTip.UseCellToolTipText
                oColumn.CellToolTipText = "Digite a Quantidade para alterá-la."
                'Adiciona Coluna
                grdListagem.RootTable.Columns.Add(oColumn)

            Next

            'Carrega Grid
            oClsPrdForecast.LoadGridGrupoItem(grdListagem, _
                                              IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue), _
                                              DatePart(DateInterval.Month, dtpMesFiltro.Value), _
                                              DatePart(DateInterval.Year, dtpMesFiltro.Value))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class


