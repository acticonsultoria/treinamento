Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math

Public Class usrCadPluviometria

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadPluviometria As New clsUsrCadPluviometria

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCadPluviometria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F5
                    Select Case sender.Name
                        Case "cboAreaFiltro" : Call LoadCombo(cboAreaFiltro, "sp_select_combo_cadastro_basico_area " & goUsuario.iEmpresa)
                    End Select

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboAreaFiltro" : Call btnCadastrarArea_Click(btnCadastrarArea, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadPluviometria_Load(sender As Object, e As EventArgs) Handles Me.Load

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
            oForm.NomeFormulario = Formulario.CadastroBasicoPluviometria
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoPluviometria)

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

    Private Sub btnCadastrarArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarArea.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadArea")

            'Carrega Combo
            LoadCombo(cboAreaFiltro, "sp_select_combo_cadastro_basico_area " & goUsuario.iEmpresa)

            'Seta Focu
            cboAreaFiltro.Focus()

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
                grdListagem.FrozenColumns = 1
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellUpdated

        Try

            'Verifica o Tipo de Linha
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub
            If grdListagem.CurrentRow.RowType <> RowType.Record Then Exit Sub

            'Atualiza Programação
            Call oClsCadPluviometria.Update(cboAreaFiltro.SelectedValue, _
                                            grdListagem.GetValue(e.Column.Key), _
                                            Format(grdListagem.CurrentRow.Cells("dia").Value, "00") & "/" & grdListagem.CurrentColumn.Key.ToString.Replace("_", "/"))

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoPluviometria, _
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
                                     Formulario.CadastroBasicoPluviometria)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.CadastroBasicoPluviometria, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadPluviometria_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            Call LoadCombo(cboAreaFiltro, "sp_select_combo_cadastro_basico_area " & goUsuario.iEmpresa)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Seta Controle
            dtpDataInicioFiltro.Value = Now.Date

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoPluviometria)

            'Seta Focu
            cboAreaFiltro.Focus()

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

            'Verifica se foi Selecionado o Campo - Área
            If ValidaCampo(cboAreaFiltro, lblAreaFiltro) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Quantidade de Meses
            If ValidaCampo(txtQuantidadeMesesFiltro, lblAno, True) = False Then
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim i As Integer

            'Exclui Colunas
            For i = grdListagem.RootTable.Columns.Count - 1 To 1 Step -1
                If grdListagem.RootTable.Columns(i).Key <> "dia" And grdListagem.RootTable.Columns(i).Visible = True Then
                    grdListagem.RootTable.Columns.Remove(grdListagem.RootTable.Columns(i).Key)
                End If
            Next

            'Carrega Colunas
            For i = 1 To txtQuantidadeMesesFiltro.Value

                Dim oColumn As New GridEXColumn
                oColumn.Caption = Format(DateAdd(DateInterval.Month, i - 1, dtpDataInicioFiltro.Value), "MM/yyyy")
                oColumn.Key = Format(DateAdd(DateInterval.Month, i - 1, dtpDataInicioFiltro.Value), "MM_yyyy")
                oColumn.Tag = "01/" & Format(DatePart(DateInterval.Month, DateAdd(DateInterval.Month, i - 1, dtpDataInicioFiltro.Value)), "00") & "/" & Format(DatePart(DateInterval.Year, DateAdd(DateInterval.Month, i - 1, dtpDataInicioFiltro.Value)), "0000")
                oColumn.Width = 65
                oColumn.HideWhenGrouped = InheritableBoolean.False
                oColumn.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.HeaderLineAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.InputMask = "Number4"
                oColumn.FilterRowComparison = ConditionOperator.Equal
                oColumn.FormatString = "#,#0.0000"
                oColumn.AggregateFunction = AggregateFunction.Sum
                oColumn.TotalFormatString = "#,#0.0000"
                oColumn.EditType = EditType.TextBox
                oColumn.CellStyle.BackColor = Color.FromArgb(255, 255, 225)
                oColumn.CellToolTip = CellToolTip.UseCellToolTipText
                oColumn.CellToolTipText = "Digite a Quantidade para alterá-la."
                'Adiciona Coluna
                grdListagem.RootTable.Columns.Add(oColumn)

            Next

            'Carrega Grid
            Call oClsCadPluviometria.LoadGrid(grdListagem, _
                                              IIf(cboAreaFiltro.SelectedIndex = -1, -1, cboAreaFiltro.SelectedValue), _
                                              dtpDataInicioFiltro.Value, _
                                              txtQuantidadeMesesFiltro.Value)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class


