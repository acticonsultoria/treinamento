Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.GridEX
Imports INTERACTI.SQLHelper

Public Class clsUsrCmpNecessidade

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sCodigoProduto As String, _
                        ByVal sDescricao As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_produto"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 60
            oSqlParameter(0).Value = sCodigoProduto

            'Seta Parametros - Descrição
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "descricao"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 120
            oSqlParameter(1).Value = sDescricao

            'Seta Parametros - Código de Empresa
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_empresa"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_necessidade", oSqlParameter)
                        
            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
