Imports Janus.Windows.GridEX

Public Class frmIntExportExcel

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsFrmIntExportExcel As New clsFrmIntExportExcel
    Private oGrid As GridEX

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property Grid() As Janus.Windows.GridEX.GridEX
        Set(ByVal value As Janus.Windows.GridEX.GridEX)
            oGrid = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmIntExportExcel_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarForm()

    End Sub

    Private Sub frmIntExportExcel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode
                Case Keys.Escape : Me.Dispose()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Try

            'Exportando
            ExportExcel()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub chkSubTabela_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSubTabela.CheckedChanged
        Try
            If chkSubTabela.Checked = True Then
                chkGridFormatada.Checked = True
            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmIntExportExcel_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))


            If oGrid.RootTable.ChildTables.Count = 0 Then
                chkSubTabela.Enabled = False
                chkSubTabela.Checked = False
            Else
                chkSubTabela.Enabled = True
                chkSubTabela.Checked = True
            End If

            'Configura Grid
            Call ConfiguraGrid(grdListagem, "EXCEL")

            'Carrega Grid
            oClsFrmIntExportExcel.LoadGrid(grdListagem, oGrid)

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

            If chkGridFormatada.Checked = True And chkSomenteSelecionadas.Checked = False Then

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
                    oGrid.RootTable.Columns(oRow.Cells.Item("codigo").Value).Visible = False
                Next

                For Each oColumn In oGrid.RootTable.Columns
                    If oColumn.Caption = "" Then
                        oColumn.Visible = False
                        If Not oColumns(UBound(oColumns)) Is Nothing Then
                            ReDim Preserve oColumns(UBound(oColumns) + 1)
                        End If
                        oColumns(UBound(oColumns)) = oColumn
                    End If
                Next

                'Indentificando a grid
                oGridEXExporter.GridEX = oGrid
                oGridEXExporter.IncludeChildTables = chkSubTabela.Checked

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
                    oGrid.RootTable.Columns(oRow.Cells.Item("codigo").Value).Visible = True
                Next

                For i = 0 To UBound(oColumns)
                    If Not oColumns(i) Is Nothing Then
                        oColumns(i).Visible = True
                    End If
                Next

            Else
                'Exportando
                oClsFrmIntExportExcel.ExportExcel(grdListagem, oGrid, chkSomenteSelecionadas.Checked)

            End If
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

   
End Class