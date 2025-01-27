Imports System.Data
Imports System.Data.SqlClient
Imports SysACTi.SQLHelper

Public Class clsFrmCmpRequisicaoHistoricoCompra

#Region "::: FUNCTION / SUB :::"


    Public Sub LoadGrid(ByVal oGrid As Janus.Windows.GridEX.GridEX, ByVal iCodigoItem As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter

        Try

            'Seta Parametros - Código da empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_item"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = iCodigoItem

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_requisicao_historico_compras", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("nota_fiscal").DataMember = "numero_documento"
                .RootTable.Columns.Item("data_emissao").DataMember = "data_emissao"
                .RootTable.Columns.Item("fornecedor").DataMember = "nome_fantasia"
                .RootTable.Columns.Item("valor").DataMember = "valor_unitario"

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
