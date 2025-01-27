Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math

Public Class usrPrdTempoDiario

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrPrdTempoDiario As New ClsUsrPrdTempoDiario
    Private iFormulario As Integer
#End Region

#Region "::: CONTROLES :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     iFormulario, _
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
                                     iFormulario)

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

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor


            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            iFormularioGrid = iFormulario

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            Call LoadCombo(cboTipoFiltro, "sp_select_combo_static_tipo_visao")

            dtpDataFiltro.Value = "01/" & Month(Now) & "/" & Year(Now) : dtpDataFiltro.Checked = False
          
            ConfiguraGrid(grdListagem, iFormulario)

          

            'Verifica Direito
            cboTipoFiltro.Focus()

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

            If ValidaCampo(cboTipoFiltro, lblTipoFiltro) = False Then
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor


            'Carrega Grid
            oClsUsrPrdTempoDiario.LoadGrid(grdListagem,
                                    cboTipoFiltro.SelectedValue, _
                                    dtpDataFiltro.Value)



            grdListagem.RootTable.FormatConditions.Clear()


            'Formata a grid
            For iColumn As Integer = 0 To grdListagem.RootTable.Columns.Count - 1

                'Seta a coluna
                grdListagem.Col = iColumn

                Dim iVermelho As Integer = 4
                Dim iAmarelo As Integer = 6



                If grdListagem.CurrentColumn.Key.Contains("dia") Then

       

                    Dim oFormatConditionVermelho As New GridEXFormatCondition(grdListagem.CurrentColumn, ConditionOperator.LessThanOrEqualTo, iVermelho)
                    Dim oFormatStyleVermelho As New GridEXFormatStyle
                    oFormatStyleVermelho.BackColor = Color.Salmon
                    oFormatConditionVermelho.FormatStyle = oFormatStyleVermelho
                    oFormatConditionVermelho.TargetColumn = grdListagem.CurrentColumn
                    grdListagem.RootTable.FormatConditions.Add(oFormatConditionVermelho)

                    Dim oFormatConditionAmarelo As New GridEXFormatCondition(grdListagem.CurrentColumn, ConditionOperator.GreaterThan, iVermelho)
                    Dim oFormatStyleAmarelo As New GridEXFormatStyle
                    oFormatStyleAmarelo.BackColor = Color.Gold
                    oFormatConditionAmarelo.FormatStyle = oFormatStyleAmarelo
                    oFormatConditionAmarelo.TargetColumn = grdListagem.CurrentColumn
                    grdListagem.RootTable.FormatConditions.Add(oFormatConditionAmarelo)


                    Dim oFormatConditionVerde As New GridEXFormatCondition(grdListagem.CurrentColumn, ConditionOperator.GreaterThanOrEqualTo, iAmarelo)
                    Dim oFormatStyleVerde As New GridEXFormatStyle
                    oFormatStyleVerde.BackColor = Color.LightGreen
                    oFormatConditionVerde.FormatStyle = oFormatStyleVerde
                    oFormatConditionVerde.TargetColumn = grdListagem.CurrentColumn
                    grdListagem.RootTable.FormatConditions.Add(oFormatConditionVerde)



                    Dim oFormatConditionCinza As New GridEXFormatCondition(grdListagem.CurrentColumn, ConditionOperator.IsEmpty, iAmarelo)
                    Dim oFormatStyleCinza As New GridEXFormatStyle
                    oFormatStyleCinza.BackColor = Color.LightGray
                    oFormatConditionCinza.FormatStyle = oFormatStyleCinza
                    oFormatConditionCinza.TargetColumn = grdListagem.CurrentColumn
                    grdListagem.RootTable.FormatConditions.Add(oFormatConditionCinza)




                    With grdListagem.CurrentColumn

                        .Width = 50
                        .TotalFormatString = "#,#0.00"
                        .FormatString = "#,#0.00"
                        .AggregateFunction = AggregateFunction.Sum
                        .Caption = Replace(.Key, "dia_", "")

                        'Dim oFormatConditionVermelho As New GridEXFormatCondition
                        'oFormatConditionVermelho.FilterCondition.AddCondition(

                    End With

                End If

            Next


            grdListagem.Col = 1

            ''Percorre as linhas para pintar de acordo com os dados
            'grdListagem.KeepRowSettings = True

            'For iCol As Integer = 0 To grdListagem.RootTable.Columns.Count - 1

            '    'Seta a coluna
            '    grdListagem.Col = iCol


            '    'Agora percorre as linhas
            '    For iRow As Integer = 0 To grdListagem.GetRows.Count - 1

            '        'Seta o valor
            '        grdListagem.Row = iRow



            '        'Agora faz as validações

            '    Next

            'Next


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class


