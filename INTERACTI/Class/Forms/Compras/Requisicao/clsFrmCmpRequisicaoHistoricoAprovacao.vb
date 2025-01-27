Imports System.Data
Imports System.Data.SqlClient
Imports SysACTi.SQLHelper

Public Class clsFrmCmpRequisicaoHistoricoAprovacao

#Region "::: FUNCTION / SUB :::"


    Public Sub LoadGrid(ByVal oGrid As Janus.Windows.GridEX.GridEX, ByVal lCodigo As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter

        Try

            'Seta Parametros - Número da Requisição
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigo

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_requisicao_historico_aprovacao", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("usuario").DataMember = "usuario"
                .RootTable.Columns.Item("data").DataMember = "data"
                .RootTable.Columns.Item("motivo").DataMember = "motivo"

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
