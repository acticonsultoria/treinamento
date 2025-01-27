Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrCfgStatusOrdemProducao


#Region "::: FUNCTION / SUB :::"

    Public Sub Update(ByVal iStatus As Integer, _
                      ByVal sDescricao As String, _
                      ByVal sStatusAnterior As String, _
                      ByVal bApontamento1 As Boolean, _
                      ByVal bApontamento2 As Boolean)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iStatus : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "apontamento1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bApontamento1 : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "apontamento2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bApontamento2 : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status_anterior"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sStatusAnterior

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_static_status_ordem_producao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                              ByVal sDescricao As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sDescricao : i += 1


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_status_ordem_producao", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            oGrid.RootTable.RowHeight = -1
            oGrid.RootTable.Columns("status_anterior").WordWrap = True
            oGrid.RootTable.Columns("status_anterior").MaxLines = 3


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridStatusAnterior(ByVal oGrid As GridEX, _
                                     ByVal iStatus As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iStatus : i += 1

       

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_status_ordem_producao_anterior", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()


            For iRow As Integer = 0 To oGrid.GetDataRows.Count - 1

                oGrid.Row = iRow

                If oGrid.GetValue("selecionado") = 1 Then

                    oGrid.CurrentRow.CheckState = RowCheckState.Checked

                End If

            Next



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
