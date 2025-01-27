Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrCust000000001

#Region "::: FUNCTION / SUB :::"
    
    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iMes As Integer, _
                        ByVal iAno As Integer, _
                        ByVal iCodigoGrupoItem As Integer, _
                        ByVal sCodigoProduto As String, _
                        ByVal sDescricao As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Mês
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mes"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMes : i += 1

            'Seta Parametros - Ano
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ano"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iAno : i += 1

            'Seta Parametros - Código Grupo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoProduto : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_grid_cust000000001", oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGrid)

            Dim oParentColumn(2) As DataColumn
            Dim oChildColumn(2) As DataColumn
            Dim oChildColumn2(2) As DataColumn

            oParentColumn(0) = oDataSet.Tables(0).Columns("codigo_item")
            oParentColumn(1) = oDataSet.Tables(0).Columns("codigo_modelo_roteiro_producao")
            oParentColumn(2) = oDataSet.Tables(0).Columns("revisao")
            oChildColumn(0) = oDataSet.Tables(1).Columns("codigo_item")
            oChildColumn(1) = oDataSet.Tables(1).Columns("codigo_modelo_roteiro_producao")
            oChildColumn(2) = oDataSet.Tables(1).Columns("revisao")
            oChildColumn2(0) = oDataSet.Tables(2).Columns("codigo_item")
            oChildColumn2(1) = oDataSet.Tables(2).Columns("codigo_modelo_roteiro_producao")
            oChildColumn2(2) = oDataSet.Tables(2).Columns("revisao")

            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oParentColumn, oChildColumn)
            oDataSet.Relations.Add(oDataSet.Tables(2).TableName, oParentColumn, oChildColumn2)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName
            oGrid.RootTable.ChildTables(1).DataMember = oDataSet.Tables(2).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
