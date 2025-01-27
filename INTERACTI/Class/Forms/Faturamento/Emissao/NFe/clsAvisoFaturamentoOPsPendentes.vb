Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper 
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Microsoft.Office.Interop

Public Class clsFrmAvisoFaturamentoOPsPendentes

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As Janus.Windows.GridEX.GridEX)

        Dim oDataSet As DataSet
        Dim i As Integer = 0
        Dim oSqlParameter(i) As SqlParameter

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_aviso_op_pendente", oSqlParameter)

            With oGrid

                ConfigurarDataMemberGrid(oGrid)

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
