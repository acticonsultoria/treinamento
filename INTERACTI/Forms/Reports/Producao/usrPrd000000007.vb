Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math
Imports Janus.Windows.CalendarCombo

Public Class usrPrd000000007

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrPrd000000007 As New clsUsrPrd000000007

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrPrdVisaoPlanta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrPrdVisaoPlanta_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

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

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            Call LoadGrid()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelDados_Click(sender As Object, e As EventArgs) Handles btnExcelDados.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridDados_Click(sender As Object, e As EventArgs) Handles btnAgruparGridDados.Click

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

    Private Sub btnConfigurarGridDados_Click(sender As Object, e As EventArgs) Handles btnConfigurarGridDados.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.RelatorioPRD000000007
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioPRD000000007)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExcelConsolidado.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdConsolidado)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparConsolidado_Click(sender As Object, e As EventArgs) Handles btnAgruparConsolidado.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdConsolidado.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdConsolidado.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdConsolidado.GroupByBoxVisible = True
                grdConsolidado.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarConsolidado_Click(sender As Object, e As EventArgs) Handles btnConfigurarConsolidado.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdConsolidado
            oForm.NomeFormulario = Formulario.RelatorioPRD000000007
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdConsolidado, Formulario.RelatorioPRD000000007)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.RelatorioPRD000000007)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.RelatorioPRD000000007, _
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
                                          Formulario.RelatorioPRD000000007, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdConsolidado_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdConsolidado.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdConsolidado, _
                                     Formulario.RelatorioPRD000000007)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdConsolidado_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdConsolidado.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdConsolidado.Name, _
                                     Formulario.RelatorioPRD000000007, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdConsolidado_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdConsolidado.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdConsolidado.Name, _
                                          Formulario.RelatorioPRD000000007, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrPrdVisaoPlanta_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            Call ConfiguraGrid(grdListagem, Formulario.RelatorioPRD000000007)
            Call ConfiguraGrid(grdConsolidado, Formulario.RelatorioPRD000000007)

            dtpDataFiltro.Value = Today.Date

            Dim sData As String

            sData = "01/" + CStr(Month(dtpDataFiltro.Value)) + "/" + CStr(Year(dtpDataFiltro.Value))

            dtpDataFiltro.Value = sData

            For i = 1 To System.DateTime.DaysInMonth(Year(dtpDataFiltro.Value), Month(dtpDataFiltro.Value))

                Dim oColumn As New GridEXColumn
                oColumn.Caption = Format(dtpDataFiltro.Value, "dd") + "/" + Format(dtpDataFiltro.Value, "MMM")
                oColumn.Key = "dia" & i
                oColumn.Tag = "N"
                oColumn.Width = 90
                oColumn.HideWhenGrouped = InheritableBoolean.False
                oColumn.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.HeaderLineAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.FilterRowComparison = ConditionOperator.Equal
                oColumn.EditType = EditType.NoEdit
                oColumn.EditType = FilterEditType.TextBox
                oColumn.CellToolTip = CellToolTip.UseCellToolTipText
                oColumn.SelectableCells = SelectableCells.All

                Select Case Weekday(dtpDataFiltro.Value)

                    Case "1" : oColumn.CellStyle.BackColor = Color.FromArgb(0, 0, 0)
                    Case "7" : oColumn.CellStyle.BackColor = Color.FromArgb(0, 0, 0)

                End Select

                'Adiciona Coluna
                grdListagem.RootTable.Columns.Add(oColumn)

                dtpDataFiltro.Value = dtpDataFiltro.Value.AddDays(1.0)

            Next

            dtpDataFiltro.Value = DateAdd(DateInterval.Day, -1, dtpDataFiltro.Value)

            'Seta Focu
            dtpDataFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            'Exclui Colunas
            For i = grdListagem.RootTable.Columns.Count - 1 To 1 Step -1
                If grdListagem.RootTable.Columns(i).Tag = "N" Then
                    grdListagem.RootTable.Columns.Remove(grdListagem.RootTable.Columns(i).Key)
                End If
            Next

            Dim sData As String

            sData = "01/" + CStr(Month(dtpDataFiltro.Value)) + "/" + CStr(Year(dtpDataFiltro.Value))

            dtpDataFiltro.Value = sData

            For i = 1 To System.DateTime.DaysInMonth(Year(dtpDataFiltro.Value), Month(dtpDataFiltro.Value))

                Dim oColumn As New GridEXColumn
                oColumn.Caption = Format(dtpDataFiltro.Value, "dd") + "/" + Format(dtpDataFiltro.Value, "MMM")
                oColumn.Key = "dia" & i
                oColumn.Tag = "N"
                oColumn.Width = 90
                oColumn.HideWhenGrouped = InheritableBoolean.False
                oColumn.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.HeaderLineAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.FilterRowComparison = ConditionOperator.Equal
                oColumn.CellToolTip = CellToolTip.UseCellToolTipText
                oColumn.SelectableCells = SelectableCells.FilterRowCells

                Select Case Weekday(dtpDataFiltro.Value)

                    'Se for domingo, plota de preto
                    Case "1" : oColumn.CellStyle.BackColor = Color.FromArgb(0, 0, 0)

                End Select

                'Adiciona Coluna
                grdListagem.RootTable.Columns.Add(oColumn)

                    dtpDataFiltro.Value = dtpDataFiltro.Value.AddDays(1.0)

            Next

            dtpDataFiltro.Value = DateAdd(DateInterval.Day, -1, dtpDataFiltro.Value)

            Call oClsUsrPrd000000007.LoadGrid(grdListagem, _
                                              grdConsolidado, _
                                              dtpDataFiltro.Value)


            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
