Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.GridEX
Imports INTERACTI.SQLHelper

Public Class clsFrmVenOrcamentoDadosCliente

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lCodigoCliente As Long, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim oDataSet As DataSet

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_cliente"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoCliente

            'Seta Parametros - Data Início
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_inicio"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.DateTime
            oSqlParameter(1).Value = sDataInicio

            'Seta Parametros - Data Termino
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_termino"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.DateTime
            oSqlParameter(2).Value = sDataTermino

            'Seta Parametros - Código Empresa
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_empresa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(3).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_orcamento_dados_compra_cliente", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("item").DataMember = "codigo_item"
                .RootTable.Columns.Item("descricao").DataMember = "descricao"
                .RootTable.Columns.Item("numero_documento").DataMember = "numero_documento"
                .RootTable.Columns.Item("data").DataMember = "data"
                .RootTable.Columns.Item("quantidade").DataMember = "quantidade"
                .RootTable.Columns.Item("valor_unitario").DataMember = "valor_unitario"
                .RootTable.Columns.Item("desconto").DataMember = "desconto"
                .RootTable.Columns.Item("valor_total").DataMember = "valor_total"

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
