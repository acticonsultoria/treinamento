Imports Janus.Windows.GridEX

Public Class usrFinPrevisaoMensal

    'Variáveis da Classe
    Private oclsUsrFinPrevisaoMensal As New clsUsrFinPrevisaoMensal

#Region "::: CONTROLES :::"
    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try
            If tabDados.SelectedTab.Name = pagAnalitico.Name Then
                ExportExcel(grdListagem)
            ElseIf tabDados.SelectedTab.Name = pagMensal.Name Then
                ExportExcel(grdMensal)
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub usrFin000000024_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid()


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFin000000025_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Exporta para Excel
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

   
    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.FinanceiroPrevisaoMensal)


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FinanceiroPrevisaoMensal, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

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
            Me.Dock = DockStyle.Fill

            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Configura DateTimePicker
            dtpPeriodoInicioFiltro.Value = DateAdd(DateInterval.Month, 0, Now) : dtpPeriodoInicioFiltro.Checked = False
            dtpPeriodoTerminoFiltro.Value = DateAdd(DateInterval.Month, 1, Now) : dtpPeriodoTerminoFiltro.Checked = False

            cboTipoFiltro.Items.Clear()

            cboTipoFiltro.Items.Add("Data Emissão", "EMISSÃO")
            cboTipoFiltro.Items.Add("Data Vencimento", "VENCIMENTO")



            ConfiguraGrid(grdListagem, Formulario.FinanceiroPrevisaoMensal)
            ConfiguraGrid(grdMensal, Formulario.FinanceiroPrevisaoMensal)

            'Seta Focu
            dtpPeriodoInicioFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            frmMain.errInfo.Clear()

            If ValidaCampo(cboTipoFiltro, lblTipoFiltro) = False Then Exit Sub


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oclsUsrFinPrevisaoMensal.LoadGrid(grdListagem, _
                                      grdMensal, _
                                      cboTipoFiltro.SelectedValue, _
                                      dtpPeriodoInicioFiltro.Value, _
                                      dtpPeriodoTerminoFiltro.Value, _
                                      chkRecebido.Checked, _
                                      chkFaturado.Checked, _
                                      chkPrevisao.Checked, _
                                      chkForecast.Checked, _
                                      chkDespesa.Checked, _
                                      chkReceita.Checked)



            grdMensal.RemoveFilters()


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub



#End Region
End Class
