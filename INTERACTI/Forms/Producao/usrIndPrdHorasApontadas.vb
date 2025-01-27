Imports Janus.Windows.GridEX

Public Class usrIndPrdHorasApontadas

#Region "::: VÁRIAVEIS :::"

    'Classe
    Private oClsUsrIndPrdHorasApontadas As New clsUsrIndPrdHorasApontadas

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

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click_1(sender As Object, e As EventArgs) Handles btnSair.Click

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

    Private Sub btnOcultar_Click(sender As Object, e As EventArgs) Handles btnOcultar.Click

        Try

            Select Case tabDados.SelectedTab.Name


                Case "pagGrafico1"

                    If grdListagem.Visible = True Then


                        grdListagem.Visible = False
                        btnExcelListagem.Visible = False

                        chrHorasApontadas.Width += grdListagem.Width + (grdListagem.Location.X - (chrHorasApontadas.Location.X + chrHorasApontadas.Width))

                        btnOcultar.Text = "Exibir Tabela"
                        chrHorasApontadas.ChartAreas(0).ReCalc()

                    Else

                        grdListagem.Visible = True
                        btnExcelListagem.Visible = True

                        chrHorasApontadas.Width = (grdListagem.Location.X - chrHorasApontadas.Location.X - 5)

                        btnOcultar.Text = "Ocultar Tabela"
                        chrHorasApontadas.ChartAreas(0).ReCalc()

                    End If

                Case "pagMensal"

                    If grdMensal.Visible = True Then


                        grdMensal.Visible = False
                        btnGridMensal.Visible = False

                        chrMensal.Width += grdMensal.Width + (grdMensal.Location.X - (chrMensal.Location.X + chrMensal.Width))

                        btnOcultar.Text = "Exibir Tabela"
                        chrMensal.ChartAreas(0).ReCalc()

                    Else

                        grdMensal.Visible = True
                        btnGridMensal.Visible = True

                        chrMensal.Width = (grdMensal.Location.X - chrMensal.Location.X - 5)

                        btnOcultar.Text = "Ocultar Tabela"
                        chrMensal.ChartAreas(0).ReCalc()

                    End If


            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelListagem_Click(sender As Object, e As EventArgs) Handles btnExcelListagem.Click

        Try

            Call ExportExcel(grdListagem)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdMensal_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdMensal.RowDoubleClick

        Try

            If IsNothing(sender.currentcolumn) Then Exit Sub

            Select Case grdMensal.CurrentColumn.Key

                Case "indicador" : Call VisualizarGraficoMensal(grdMensal.CurrentRow.Cells("data").Value)

            End Select

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnGridMensal_Click(sender As Object, e As EventArgs) Handles btnGridMensal.Click

        Try

            Call ExportExcel(grdMensal)

        Catch ex As Exception
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrIndFat000000001_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            Call ConfiguraGrid(grdListagem, Formulario.ProducaoIndicadorHorasApontadas)
            Call ConfiguraGrid(grdMensal, Formulario.ProducaoIndicadorHorasApontadas)

            dtpDataTerminoFiltro.Value = Today.Date

            dtpDataTerminoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor


            Call oClsUsrIndPrdHorasApontadas.LoadGrafico(chrHorasApontadas, _
                                                         grdListagem, _
                                                         grdMensal, _
                                                         dtpDataInicioFiltro.Value, _
                                                         dtpDataTerminoFiltro.Value)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarGraficoMensal(ByVal sData As String)

        Try

            Cursor.Current = Cursors.WaitCursor

            Call oClsUsrIndPrdHorasApontadas.LoadGraficoMensal(chrMensal, _
                                                               sData)


            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
