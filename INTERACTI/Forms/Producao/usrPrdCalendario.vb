Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Public Class usrPrdCalendario

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrPrdCalendario As New clsUsrPrdCalendario

#End Region

#Region "::: CONTROLES :::"


    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            If grdListagem.GetCheckedRows.Count = 0 Then
                MsgBox("Selecione os registros a serem atualizados!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            For Each oRow In grdListagem.GetCheckedRows


                oClsUsrPrdCalendario.UpdateHorasDescricao(oRow.Cells.Item("codigo").Value, _
                                                          oRow.Cells.Item("horas").Value, _
                                                          oRow.Cells.Item("observacao").Value)
            Next

            frmMain.Informacao(Mensagem.RegistroSalvo)

            Call LoadGrid()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirProduto_Click(sender As Object, e As EventArgs) Handles btnExcluirProduto.Click

        Try

            If MsgBox("Deseja excluir permanentemente este(s) resgistro(s)? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                If grdListagem.GetCheckedRows.Count = 0 Then
                    MsgBox("Selecione os registros a serem deletedos!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                For Each oRow In grdListagem.GetCheckedRows
                    oClsUsrPrdCalendario.DeletePlanejamento(oRow.Cells.Item("codigo").Value)
                Next

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroExcluido)

                Call LoadGrid()

            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usr_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            Call ConfigurarUserControl()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Call LoadGrid()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Try
            Call ExportExcel(grdListagem)
        Catch ex As Exception
            frmMain.Informacao(ex.Message, Color.Red)
        End Try
    End Sub

#End Region


#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            Cursor.Current = Cursors.WaitCursor

            dtpDataInicioFiltro.Value = Now
            dtpDataTerminoFiltro.Value = Now

            Call LoadCombo(cboDiaSemana, "sp_select_dia_semana")

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            frmMain.Informacao(ex.Message, Color.Red)
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub LoadGrid()
        Try
            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdCalendario.LoadGrid(grdListagem, _
                                          txtMaquinaFiltro.Text.Trim, _
                                          IIf(dtpDataInicioFiltro.Checked = False, "", dtpDataInicioFiltro.Value),
                                          IIf(dtpDataTerminoFiltro.Checked = False, "", dtpDataTerminoFiltro.Value),
                                          IIf(cboDiaSemana.SelectedIndex = -1, -1, cboDiaSemana.SelectedValue), _
                                          chkIncluirSabado.Checked, _
                                          chkIncluirDomingo.Checked
                                          )

            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            frmMain.Informacao(ex.Message, Color.Red)
        End Try
    End Sub

    Private Sub btnPlanejamento_Click(sender As Object, e As EventArgs) Handles btnPlanejamento.Click

        Try

            Dim oForm As New frmCadCalendarioPlanejamento
            oForm.ShowDialog(Me)

            Call LoadGrid()

        Catch ex As Exception
            frmMain.Informacao(ex.Message, Color.Red)
        End Try

    End Sub

#End Region


End Class
