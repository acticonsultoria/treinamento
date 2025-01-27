Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrVen000000015

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal iCodigoVendedor As Integer, _
                        ByVal sUF As String, _
                        ByVal iNumeroMesesOrcamento As Integer, _
                        ByVal iNumeroMesesPedido As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            'Seta Parametros - Código Vendedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vendedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoVendedor : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUF : i += 1

            'Seta Parametros - Nº Meses Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_meses_orcamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroMesesOrcamento : i += 1

            'Seta Parametros - Nº Meses Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_meses_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroMesesPedido : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_grid_ven000000015", oSqlParameter)

            'Configura DataMember Grid
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
