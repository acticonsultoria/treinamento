Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.GridEX
Imports INTERACTI.SQLHelper

Public Class clsFrmPrdOrdemProducaoHistorico

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lCodigoOrdemProducao As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código Ordem de Produção
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_ordem_producao"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoOrdemProducao

            'Seta Parametros - Código de Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_producao_ordem_producao_historico", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("historico").DataMember = "historico"
                .RootTable.Columns.Item("data").DataMember = "data"
                .RootTable.Columns.Item("usuario").DataMember = "usuario"
                .RootTable.Columns.Item("codigo").DataMember = "codigo"

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
