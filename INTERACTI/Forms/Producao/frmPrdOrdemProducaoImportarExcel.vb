Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmPrdOrdemProducaoImportarExcel

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrPrdOrdemProducao As New clsUsrPrdOrdemProducao
    Private lCodigoOrdemProducao As Long = -1

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoOrdemProducao As Long
        Get
            Return lCodigoOrdemProducao
        End Get
        Set(value As Long)
            lCodigoOrdemProducao = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnArquivoExcel_Click(sender As Object, e As EventArgs) Handles btnArquivoExcel.Click
        Try
            Call ImportarArquivoExcelTemp()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Try
            If validarImportar() = False Then Exit Sub
            oClsUsrPrdOrdemProducao.InsertOrdemProducaoExcel()
            Me.Dispose()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub



    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        'Sair da tela
        Me.Dispose()
    End Sub
#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub ImportarArquivoExcelTemp()

        Dim oApplicationClass As New Excel.ApplicationClass

        Try
            frmMain.errInfo.Clear()
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim oArquivoExcel As New OpenFileDialog
            Dim i As Integer

            'Seta Dados do OpenFileDialog
            oArquivoExcel.Filter = "Arquivo Excel|*.xls;*.xlsx;*.csv"

            'Verifica se foi Selecionado algum Arquivo
            If oArquivoExcel.ShowDialog = DialogResult.OK Then

                'Exclui dados da tabela
                oClsUsrPrdOrdemProducao.DeleteProdutoExcel()

                'Seta Controles
                txtArquivoExcel.Text = oArquivoExcel.FileName

                'Abre o Arquivo
                oApplicationClass.Workbooks.Open(oArquivoExcel.FileName)



                'Percorre Linha a Linha o Arquivo
                For i = 2 To oApplicationClass.Rows.Count

                    'Verifica se acabou os registros
                    If oApplicationClass.Range("O" & i).Value Is Nothing Then
                        Exit For
                    End If

                    'If IsNumeric(oApplicationClass.Range("A" & i).Value) = False Then
                    '    Exit For
                    'End If

                    'Adiciona(Linha)
                    oClsUsrPrdOrdemProducao.InsertItemExcelTemp(oApplicationClass.Range("O" & i).Value, _
                                                              oApplicationClass.Range("C" & i).Value, _
                                                              oApplicationClass.Range("D" & i).Value, _
                                                              oApplicationClass.Range("E" & i).Value, _
                                                              oApplicationClass.Range("F" & i).Value, _
                                                              oApplicationClass.Range("G" & i).Value, _
                                                              oApplicationClass.Range("P" & i).Value, _
                                                              oApplicationClass.Range("S" & i).Value)

                Next

                oClsUsrPrdOrdemProducao.LoadGridProdutoExcel(grdListagem)
                oApplicationClass.Workbooks.Close()
                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default
            End If

        Catch ex As Exception
            oApplicationClass.Workbooks.Close()
            Throw ex
        End Try

    End Sub

    Private Function ValidarImportar() As Boolean
        Try
            ValidarImportar = False

            For Each oRow In grdListagem.GetRows
                If IsDBNull(oRow.Cells.Item("status").Value) = False Then
                    frmMain.Informacao("Linha " + CStr(oRow.RowIndex + 1) + " está com problema.", Color.Red)
                    Exit Function
                End If
            Next
            ValidarImportar = True

        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region
    
End Class