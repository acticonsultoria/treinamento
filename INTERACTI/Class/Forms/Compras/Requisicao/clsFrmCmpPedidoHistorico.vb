Imports System.Data
Imports System.Data.SqlClient
Imports SysACTi.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsFrmCmpPedidoHistorico

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lCodigoPedido As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter

        Try

            'Seta Parametros - Código do Pedido
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoPedido

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_pedido_historico", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("usuario").DataMember = "usuario"
                .RootTable.Columns.Item("data").DataMember = "data_hora"
                .RootTable.Columns.Item("historico").DataMember = "historico"

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
