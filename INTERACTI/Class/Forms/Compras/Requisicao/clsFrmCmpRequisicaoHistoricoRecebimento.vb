Imports System.Data
Imports System.Data.SqlClient
Imports SysACTi.SQLHelper

Public Class clsFrmCmpRequisicaoHistoricoRecebimento

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As Janus.Windows.GridEX.GridEX, ByVal lRequisicao As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter

        Try

            'Seta Parametros - Número da Requisição
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_requisicao"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lRequisicao

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_requisicao_historico_recebimento", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("numero_documento").DataMember = "numero_documento"
                .RootTable.Columns.Item("data_emissao").DataMember = "data_emissao"
                .RootTable.Columns.Item("quantidade").DataMember = "quantidade"
                .RootTable.Columns.Item("data_recebimento").DataMember = "data_entrada"
                .RootTable.Columns.Item("usuario").DataMember = "usuario"

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
