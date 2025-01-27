Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrFinRelatorioFluxoDiario

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinRelatorioSonacaDiario As New clsUsrFinRelatorioFluxoDiario
#End Region

#Region "::: CONTROLES :::"

    Private Sub usrFinDespesaCheque_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        'Carrega Dados da Grid
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
            ExportExcel(grdListagem)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica Direito
            'btnFiltrar.Enabled = VerificaDireito(Formulario.FinanceiroDespesaCheque, gcSelect)
            dtpDataPagamentoTerminoFiltro.Value = DateAdd(DateInterval.Month, 1, Now)

            'Seta Focu
            dtpDataPagamentoInicioFiltro.Focus()

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

            'Carrega Controles
            oClsFinRelatorioSonacaDiario.LoadGrid(grdListagem, _
                                           dtpDataPagamentoInicioFiltro.Value, _
                                          dtpDataPagamentoTerminoFiltro.Value)


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


#End Region

End Class
