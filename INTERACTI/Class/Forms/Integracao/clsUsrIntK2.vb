Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo
Imports System.IO
Imports FirebirdSql.Data.FirebirdClient

Public Class clsUsrIntK2

#Region "::: FUNCTION / SUB :::"

#Region "::: TÍTULO :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = SQLHelper.ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_k2", oSqlParameter)

            'Confiugra DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.DataSource = oDataSet.DefaultViewManager

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Integrar(ByVal sPath As String)

        Try

            'Váriaveis
            Dim oFbConnection As FbConnection = New FbConnection("User=SYSDBA;Password=masterkey;Database=" & sPath & ";DataSource=localhost;Port=3050;Dialect=3;")
            Dim oFbCommand As FbCommand
            Dim oFbCommandCount As FbCommand
            Dim oFbDataReader As FbDataReader
            Dim oDataRow As DataRow
            Dim i As Integer
            Dim x As Integer
            Dim y As Integer
            Dim z As Integer
            Dim iTotal As Integer = 0

            oFbConnection.Open()

            For Each oRow As GridEXRow In gSelecaoRow

                'Informa a Query - Delete
                Call IntegrarQuery(oRow, "query_delete")

                If IsDBNull(oRow.Cells("query_destine").Value) = False Then

                    Dim oSqlDataAdapter As New SqlDataAdapter(oRow.Cells("query_destine").Value, goDatabase.sConnection)
                    Dim oDataSet As New DataSet("tabela")
                    oSqlDataAdapter.FillSchema(oDataSet, SchemaType.Source, "tabela")
                    oSqlDataAdapter.Fill(oDataSet, "tabela")
                    Dim oDataTable As DataTable
                    oDataTable = oDataSet.Tables("tabela")

                    'Query - Destino
                    oFbCommand = New FbCommand(oRow.Cells("query_source").Value, oFbConnection)
                    oFbDataReader = oFbCommand.ExecuteReader()

                    If IsDBNull(oRow.Cells("query_count").Value) = False Then
                        oFbCommandCount = New FbCommand(oRow.Cells("query_count").Value, oFbConnection)
                        iTotal = oFbCommandCount.ExecuteScalar()
                    End If

                    x = 1
                    y = 1
                    z = 1

                    'Exibe ProgressBar
                    If iTotal > 0 Then
                        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = iTotal
                        frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
                        frmMain.stbMain.Panels("pnlProgressBar").Visible = True
                    End If

                    'percorre o datareader e preenche o listbox
                    While oFbDataReader.Read

                        oDataRow = oDataTable.NewRow()

                        For i = 0 To oFbDataReader.FieldCount - 1
                            If oFbDataReader.GetName(i) = "ZZZ" Then
                                oDataRow(i) = z
                                z += 1
                            ElseIf oFbDataReader.GetName(i) = "XXX" Then
                                oDataRow(i) = x
                                x += 1
                            ElseIf oFbDataReader.GetName(i) = "YYY" Then
                                oDataRow(i) = Format(y, "0000")
                                y += 1
                            Else
                                If oFbDataReader.GetName(i).ToUpper.Contains("REPLACE_PONTO") = False Then
                                    oDataRow(i) = oFbDataReader.Item(i)
                                Else
                                    If IsDBNull(oFbDataReader.Item(i)) Then
                                        oDataRow(i) = DBNull.Value
                                    Else
                                        oDataRow(i) = Replace(oFbDataReader.Item(i), ".", "")
                                    End If
                                End If
                            End If
                        Next

                        'Exibe ProgressBar
                        If iTotal > 0 Then
                            frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue + 1
                            Application.DoEvents()
                        End If

                        oDataTable.Rows.Add(oDataRow)

                    End While

                    'Oculta ProgressBar
                    frmMain.stbMain.Panels("pnlProgressBar").Visible = False

                    'Fecha o DataReader
                    If oFbDataReader.IsClosed = False Then oFbDataReader.Close() : oFbDataReader = Nothing

                    Dim objCommandBuilder As New SqlCommandBuilder(oSqlDataAdapter)
                    oSqlDataAdapter.Update(oDataSet, "tabela")

                    'Informa o usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                End If

                'Informa a Query - Delete
                Call IntegrarQuery(oRow, "query_update")

                'Atualiza Data
                Call ExecuteQuery("EXECUTE sp_update_interacti_table_field 'tb_stc_integracao_k2', 'data_ultima_integracao', 'GETDATE()', 'WHERE (((codigo_empresa) = " & goUsuario.iEmpresa & ") AND ((tabela) = ''" & oRow.Cells("tabela").Value & "''))'")

            Next

            If oFbConnection.State = ConnectionState.Open Then oFbConnection.Close() : oFbConnection = Nothing

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub IntegrarQuery(ByVal oRow As GridEXRow, _
                             ByVal sColumn As String)

        Try

            'Váriaveis
            Dim oSqlConnection As New SqlConnection(goDatabase.sConnection)
            Dim oSqlCommand As SqlCommand
            Dim oDataRow As DataRow
            Dim i As Integer

            'Query - Destino
            oSqlConnection.Open()

            If IsDBNull(oRow.Cells(sColumn).Value) = False Then

                oSqlCommand = New SqlCommand(oRow.Cells(sColumn).Value, oSqlConnection)
                oSqlCommand.ExecuteNonQuery()

            End If

            If oSqlConnection.State = ConnectionState.Open Then oSqlConnection.Close() : oSqlConnection = Nothing

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
