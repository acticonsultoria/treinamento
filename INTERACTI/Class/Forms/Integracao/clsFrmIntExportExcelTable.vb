Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop.Excel

Public Class clsFrmIntExportExcelTable

#Region "::: VÁRIAVEIS :::"

    Private Const cLabel = "System.Windows.Forms.Label"
    Private Const cMaskedEditBox = "Janus.Windows.GridEX.EditControls.MaskedEditBox"
    Private Const cComboBox = "Janus.Windows.EditControls.UIComboBox"

    Private Const cExcelVermelho = "-16776961"
    Private Const cExcelVerde = "-16724992"
    Private Const cExcelAzul = "-4165632"

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal oGridExcel As GridEX)

        'Variaveis Locais
        Dim oColumn As GridEXColumn

        Try

            With oGrid

                oGrid.ClearItems()

                For Each oColumn In oGridExcel.RootTable.Columns

                    If oColumn.Visible = True And oColumn.Caption <> "" Then
                        .AddItem(1, _
                                 oColumn.Caption, _
                                 oColumn.Key).CheckState = RowCheckState.Checked
                    End If

                Next

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Executar(ByVal oGridDados As GridEX, _
                        ByVal sComando As String)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim oDataSet As DataSet
        Dim oDataColumn As DataColumn
        Dim oColumn As GridEXColumn

        Try

            'Executando o comando
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.Text, sComando)

            'Limpando as colunas
            oGridDados.RootTable.Columns.Clear()

            'Se houver registros
            For Each oDataColumn In oDataSet.Tables(0).Columns

                'Adicionando o key e o caption da coluna
                oColumn = New GridEXColumn(oDataColumn.ColumnName)
                oColumn.Caption = oDataColumn.Caption
                'Setando para unbound
                oColumn.BoundMode = ColumnBoundMode.Bound

                'Adicionado na grid
                oGridDados.RootTable.Columns.Add(oColumn)

            Next

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGridDados)

            'Carrega Grid
            oGridDados.DataSource = oDataSet.DefaultViewManager
            oGridDados.DataMember = oDataSet.Tables(0).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ExportExcel(ByVal oGrid As GridEX, _
                           ByVal oGridExcel As GridEX)

        Try

            'Variaveis Local
            Dim oApplicationClass As New Application
            Dim oWorkbook As Workbook
            Dim oWorksheet As Worksheet
            Dim oRow() As GridEXRow
            Dim oRowExcel As GridEXRow

            oWorkbook = oApplicationClass.Workbooks.Add()
            oWorksheet = oWorkbook.ActiveSheet()

            'Carrega Linhas
            oRow = oGrid.GetCheckedRows

            'Carrega Cabeçalho
            For i = 0 To UBound(oRow)
                oApplicationClass.Cells(1, i + 1) = oRow(i).Cells("campo").Value
                oWorksheet.Cells(1, i + 1).Font.Bold = True
            Next

            'Carrega Linha
            For Each oRowExcel In oGridExcel.GetDataRows
                If oRowExcel.RowType = RowType.Record Then
                    For i = 0 To UBound(oRow)
                        oApplicationClass.Cells(oRowExcel.RowIndex + 2, i + 1) = oRowExcel.Cells(oRow(i).Cells("codigo").Value).Text
                    Next
                End If
            Next

            'Abre Formulário            
            oWorksheet.Columns.AutoFit()
            oApplicationClass.Visible = True

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ExportExcelCabecalho(ByVal oGridCabecalho As GridEX, _
                                    ByVal oGridListagem As GridEX, _
                                    ByVal oGridExcel As GridEX)

        Try

            'Variaveis Local
            Dim oApplicationClass As New Application
            Dim oWorkbook As Workbook
            Dim oWorksheet As Worksheet
            Dim oRow() As GridEXRow
            Dim oRowListagem() As GridEXRow
            Dim iLinha As Integer = 1
            Dim oRowExcel As GridEXRow
            Dim iColuna As Integer

            oWorkbook = oApplicationClass.Workbooks.Add()
            oWorksheet = oWorkbook.ActiveSheet()

            'Recebendo o cabeçalho
            oRow = oGridCabecalho.GetCheckedRows
            'Carrega Linhas
            oRowListagem = oGridListagem.GetCheckedRows

            'Recebedo o número de colunas
            iColuna = UBound(oRowListagem)

            For i = 0 To UBound(oRow)

                oApplicationClass.Cells(iLinha, 1) = oRow(i).Cells("cabecalho").Value
                oWorksheet.Cells(iLinha, 1).font.bold = True
                oApplicationClass.Cells(iLinha, 2) = oRow(i).Cells("valor").Value
                oApplicationClass.Range("B" & CStr(iLinha), CStr(Chr(65 + iColuna)) & CStr(iLinha)).Merge()
                iLinha += 1

            Next

            'Adicionando a linha
            iLinha += 1

            'Carrega Cabeçalho
            For i = 0 To UBound(oRowListagem)
                oApplicationClass.Cells(iLinha, i + 1) = oRowListagem(i).Cells("campo").Value
                oWorksheet.Cells(iLinha, i + 1).Font.Bold = True
            Next

            iLinha += 1

            'Carrega Linha
            For Each oRowExcel In oGridExcel.GetDataRows
                If oRowExcel.RowType = RowType.Record Then
                    For i = 0 To UBound(oRowListagem)
                        oApplicationClass.Cells(iLinha, i + 1) = oRowExcel.Cells(oRowListagem(i).Cells("codigo").Value).Text
                    Next

                    If oGridExcel.RootTable.Columns.Contains("codigo_ccb_tipo_input") = True Then
                        Select Case oRowExcel.Cells("codigo_ccb_tipo_input").Value
                            Case 1 : oWorksheet.Range("A" & CStr(iLinha), CStr(Chr(65 + UBound(oRowListagem))) & CStr(iLinha)).Font.Color = cExcelVerde
                            Case 2 : oWorksheet.Range("A" & CStr(iLinha), CStr(Chr(65 + UBound(oRowListagem))) & CStr(iLinha)).Font.Color = cExcelAzul
                            Case 3 : oWorksheet.Range("A" & CStr(iLinha), CStr(Chr(65 + UBound(oRowListagem))) & CStr(iLinha)).Font.Color = cExcelVermelho
                        End Select
                    End If

                    iLinha += 1
                End If
            Next

            'Abre Formulário            
            oWorksheet.Columns.AutoFit()
            oApplicationClass.Visible = True

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
