Imports System.Data
Imports System.Data.SqlClient
Imports SysACTi.SQLHelper

Public Class clsFrmCmpRequisicaoListaItem

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As Janus.Windows.GridEX.GridEX, _
                        ByVal sItem As String, _
                        ByVal iTipoItem As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter

        Try

            'Seta Parametros - Descrição
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "descricao"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 100
            oSqlParameter(0).Value = sItem

            'Seta Parametros - Código Tipo do Item
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_tipo_item"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = iTipoItem

            'Seta Parametros - Código da empresa
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_empresa"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_requisicao_lista_item", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("grupo_item").DataMember = "grupo_item"
                .RootTable.Columns.Item("item").DataMember = "item"
                .RootTable.Columns.Item("part_number").DataMember = "part_number"
                .RootTable.Columns.Item("codigo_grupo_item").DataMember = "codigo_grupo_item"
                .RootTable.Columns.Item("codigo_item").DataMember = "codigo_item"

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
