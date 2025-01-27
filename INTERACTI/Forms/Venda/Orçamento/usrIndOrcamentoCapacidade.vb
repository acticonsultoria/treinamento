Imports Janus.Windows.GridEX

Public Class usrIndOrcamentoCapacidade

#Region "::: VÁRIAVEIS :::"

    'Classe
    Private oClsUsrIndOrcamentoCapacidade As New clsUsrIndOrcamentoCapacidade
    Private x As Integer
    Private y As Integer

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrIndFat000000001_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call btnFiltrar_Click(btnFiltrar, System.EventArgs.Empty) Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrIndFat000000001_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click_1(sender As Object, e As EventArgs) Handles btnSair.Click, _
                                                                          btnSair2.Click

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

    Private Sub btnExcelHistorico_Click(sender As Object, e As EventArgs) Handles btnExcelDiario.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnGridNTOAberta_Click(sender As Object, e As EventArgs) Handles btnExcelMensal.Click

        Try

            Call ExportExcel(grdListagemMensal)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ComercialOrcamentoIndicadorCapacidade, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrarMensal_Click(sender As Object, e As EventArgs) Handles btnFiltrarMensal.Click

        Try

            frmMain.errInfo.Clear()

            LoadGridMensal()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnOcultar_Click(sender As Object, e As EventArgs) Handles btnOcultar.Click

        Try

            If grdListagem.Visible = True Then

                grdListagem.Visible = False
                btnExcelDiario.Visible = False
                x = chrCapacidadeDiaria.Location.X
                y = chrCapacidadeDiaria.Location.Y
                chrCapacidadeDiaria.Location = grdListagem.Location
                chrCapacidadeDiaria.Height += grdListagem.Height

                btnOcultar.Text = "Exibir Tabela"
                chrCapacidadeDiaria.ChartAreas(0).ReCalc()

            Else

                grdListagem.Visible = True
                btnExcelDiario.Visible = True

                chrCapacidadeDiaria.Location = New Point(x, y)
                chrCapacidadeDiaria.Height -= grdListagem.Height

                btnOcultar.Text = "Ocultar Tabela"
                chrCapacidadeDiaria.ChartAreas(0).ReCalc()

            End If

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
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usrIndFat000000001_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            ConfiguraGrid(grdListagem, Formulario.ComercialOrcamentoIndicadorCapacidade)

            dtpDataFiltroDiario.Value = Today.Date
            dtpDataFiltroMensal.Value = Today.Date

            ConfiguraGridColunas(grdListagem, _
                                 dtpDataFiltroDiario)

            tabMain.TabPages.Remove(pagListagemMensal)

            'Seta Focu
            dtpDataFiltroDiario.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub ConfiguraGridColunas(ByVal oGrid As GridEX, _
                                     ByVal oCalendar As Janus.Windows.CalendarCombo.CalendarCombo)

        Try

            Cursor.Current = Cursors.WaitCursor

            'Exclui Colunas
            For i = oGrid.RootTable.Columns.Count - 1 To 1 Step -1
                If oGrid.RootTable.Columns(i).Tag = "N" Then
                    oGrid.RootTable.Columns.Remove(oGrid.RootTable.Columns(i).Key)
                End If
            Next

            Dim sData As String

            sData = "01/" + CStr(Month(oCalendar.Value)) + "/" + CStr(Year(oCalendar.Value))

            oCalendar.Value = sData

            For i = 1 To System.DateTime.DaysInMonth(Year(oCalendar.Value), Month(oCalendar.Value))

                Dim oColumn As New GridEXColumn
                oColumn.Caption = Format(oCalendar.Value, "dd") + "-" + Format(oCalendar.Value, "MMM") + "-" + Format(oCalendar.Value, "yy")
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

                Select Case Weekday(oCalendar.Value)

                    'Se for domingo ou sábado
                    Case "1" : oColumn.Visible = False
                    Case "7" : oColumn.Visible = False

                End Select

                oGrid.RootTable.Columns.Add(oColumn)

                oCalendar.Value = oCalendar.Value.AddDays(1.0)

            Next

            oCalendar.Value = DateAdd(DateInterval.Day, -1, oCalendar.Value)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            ConfiguraGridColunas(grdListagem, _
                                 dtpDataFiltroDiario)

            oClsUsrIndOrcamentoCapacidade.LoadGraficoDiario(chrCapacidadeDiaria, _
                                                            grdListagem, _
                                                            dtpDataFiltroDiario.Value)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridMensal()

        Try

            Cursor.Current = Cursors.WaitCursor

            ConfiguraGridColunas(grdListagem, _
                                 dtpDataFiltroMensal)

            oClsUsrIndOrcamentoCapacidade.LoadGraficoMensal(chrCapacidadeMensal, _
                                                            grdListagemMensal, _
                                                            dtpDataFiltroMensal.Value)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
