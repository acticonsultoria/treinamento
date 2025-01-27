Imports Janus.Windows.GridEX

Public Class frmIntExportExcelTable

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFrmIntExportExcelTable As New clsFrmIntExportExcelTable

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmIntExportExcelTable_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarForm()

    End Sub

    Private Sub frmIntExportExcelTable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode
                Case Keys.Escape : Me.Dispose()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboTabela_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTabela.SelectedIndexChanged

        Try

            'Limpa Controles
            grdDados.DataSource = Nothing
            grdListagem.DataSource = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor 

            If cboTabela.SelectedIndex <> -1 Then
                oClsFrmIntExportExcelTable.Executar(grdDados, cboTabela.SelectedValue)
                oClsFrmIntExportExcelTable.LoadGrid(grdListagem, grdDados)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        'Exportando
        ExportExcel()

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarForm()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmIntExportExcelTable_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Configura Grid
            Call ConfiguraGrid(grdListagem, "EXCEL TABLE")

            'Carrega Combo
            Call LoadCombo(cboTabela, "sp_select_combo_integracao_excel " & goUsuario.iEmpresa, False)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub ExportExcel()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If chkGridFormatada.Checked = True Then

                'Váriavel - Dialog
                Dim oFileDialog As New SaveFileDialog
                oFileDialog.Filter = "Excel|*.xls"

                'Abrindo um save dialog para salvar o arquivo
                If oFileDialog.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                    Exit Sub
                End If

                'Váriavel - Arquivo
                Dim sArquivo As String = oFileDialog.FileName

                'Instanciando a classe para exportar para o Excel
                Dim oGridEXExporter As New Janus.Windows.GridEX.Export.GridEXExporter()

                'Váriaveis auxiliares
                Dim oRow As GridEXRow
                Dim oColumn As GridEXColumn
                Dim oColumns() As GridEXColumn
                Dim i As Integer

                'Redimensiona Vetor
                ReDim oColumns(0)

                'Percorrendo as colunas não "tickadas"
                For Each oRow In grdListagem.GetUncheckedRows
                    grdDados.RootTable.Columns(oRow.Cells.Item("codigo").Value).Visible = False
                Next

                For Each oColumn In grdDados.RootTable.Columns
                    If oColumn.Caption = "" Then
                        oColumn.Visible = False
                        If Not oColumns(UBound(oColumns)) Is Nothing Then
                            ReDim Preserve oColumns(UBound(oColumns) + 1)
                        End If
                        oColumns(UBound(oColumns)) = oColumn
                    End If
                Next

                'Indentificando a grid
                oGridEXExporter.GridEX = grdDados

                'Especificando o caminho para exportar com um File Stream
                Dim oStream As New System.IO.FileStream(sArquivo, System.IO.FileMode.Create)

                'Exportando 
                oGridEXExporter.Export(oStream)

                'Fechando o FileStream
                oStream.Close()

                'Iniciando o arquivo
                Process.Start(sArquivo)

                'Percorrendo as colunas não "tickadas"
                For Each oRow In grdListagem.GetUncheckedRows
                    grdDados.RootTable.Columns(oRow.Cells.Item("codigo").Value).Visible = True
                Next

                For i = 0 To UBound(oColumns)
                    If Not oColumns(i) Is Nothing Then
                        oColumns(i).Visible = True
                    End If
                Next

            Else
                'Exportando
                oClsFrmIntExportExcelTable.ExportExcel(grdListagem, grdDados)
            End If
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class