Imports System.IO
Imports System.IO.File

Public Class usrFatEntradaNFASCON

#Region "::: VARIAVEIS :::"


    Private oClsUsrFatInformacoesEntrada As New clsUsrFatEntradaNFASCON

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarForm()

    End Sub

    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSairFCIGerada.Click

        'Deleta Aba
        frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub LoadGrid()
        Try
            oClsUsrFatInformacoesEntrada.LoadGrid(grdListagem, _
                                                  txtNotaFiscal.Text, _
                                                  IIf(dtpDataEmissaoInicio.Checked = True, dtpDataEmissaoInicio.Value, ""), _
                                                  IIf(dtpDataEmissaoFim.Checked = True, dtpDataEmissaoFim.Value, ""), _
                                                  txtEmitente.Text, _
                                                  IIf(dtpDataEntradaInicio.Checked = True, dtpDataEntradaInicio.Value, ""), _
                                                  IIf(dtpDataEntradaFim.Checked = True, dtpDataEntradaFim.Value, ""))

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfigurarForm()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor


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

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Try
            Call LoadGrid()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelFCIGerada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelFCIGerada.Click
        Try
            ExportExcel(grdListagem)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
End Class