Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrFinCashFlow

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrFinCashFlow As New clsUsrFinCashFlow

#End Region

#Region "::: CONTROLES :::"

#Region "::: COMUM :::"
    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Try
            Select Case tabDados.SelectedTab.Name
                Case pagDespesa.Name
                    ExportExcel(grdDespesa)
                Case pagReceita.Name
                    ExportExcel(grdReceita)
                Case pagResumo.Name
                    ExportExcel(grdResumo)
                Case pagSintetico.Name
                    ExportExcel(grdSintetico)

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub usrFinPagamentoContas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            If ValidaCampo(cboContaBancaria, lblContaBancaria) = False Then
                Exit Sub
            End If

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub


    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Try
            tabMain.TabPages.Add(pagListagem)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub



#End Region


#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: COMUM :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            dtpDataTermino.Value = DateAdd(DateInterval.Month, 12, Now)
            grdResumo.RootTable.Columns("mes12").Visible = False


            txtSaldoInicial.Value = LoadCodigo("sp_select_financeiro_saldo '" & CStr(Now) & "',null,11")
            Call LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default
            'Informa o Usuário sobre o Erro Ocorrido
            frmMain.Informacao(ex.Message, Color.Red)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            frmMain.errInfo.Clear()

            'Carrega a grid
            oClsUsrFinCashFlow.LoadGrid(grdDespesa, _
                                        grdReceita, _
                                        grdResumo, _
                                        cboContaBancaria.SelectedValue)


            oClsUsrFinCashFlow.LoadGridSintetico(grdSintetico, _
                                                 dtpDataTermino.Value, _
                                                 txtSaldoInicial.Value, _
                                                 cboContaBancaria.SelectedValue)


           
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default
            'Informa o Usuário sobre o Erro Ocorrido
            frmMain.Informacao(ex.Message, Color.Red)
        End Try

    End Sub

    

#End Region



#End Region



    Private Sub usrFinCashFlow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)
    End Sub
End Class
