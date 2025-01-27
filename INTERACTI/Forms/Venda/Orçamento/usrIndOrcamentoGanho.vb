Imports Janus.Windows.GridEX

Public Class usrIndOrcamentoGanho

#Region "::: VÁRIAVEIS :::"

    'Classe
    Private oClsUsrIndOrcamentoGanho As New clsUsrIndOrcamentoGanho

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

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click

        Try

            ExportExcel(grdListagem)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnOcultar_Click(sender As Object, e As EventArgs) Handles btnOcultar.Click

        Try

            If grdListagem.Visible = True Then


                grdListagem.Visible = False
                btnExcel.Visible = False

                chrOrcamento.Width += grdListagem.Width + (grdListagem.Location.X - (chrOrcamento.Location.X + chrOrcamento.Width))

                btnOcultar.Text = "Exibir Tabela"
                chrOrcamento.ChartAreas(0).ReCalc()

            Else

                grdListagem.Visible = True
                btnExcel.Visible = True

                chrOrcamento.Width = (grdListagem.Location.X - chrOrcamento.Location.X - 5)

                btnOcultar.Text = "Ocultar Tabela"
                chrOrcamento.ChartAreas(0).ReCalc()

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

            dtpDataTerminoFiltro.Value = Now
            dtpDataInicioFiltro.Value = DateAdd(DateInterval.Month, -1, dtpDataTerminoFiltro.Value)

            ConfiguraGrid(grdListagem, Formulario.ComercialOrcamentoIndicadorGanho)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrIndOrcamentoGanho.LoadGrafico(chrOrcamento, _
                                                 grdListagem, _
                                                 dtpDataInicioFiltro.Value, _
                                                 dtpDataTerminoFiltro.Value)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
