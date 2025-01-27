Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrQA000000001

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iCodigoFornecedor As Integer, _
                        ByVal iStatus As Integer, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sDataEntradaInicio As String, _
                        ByVal sDataEntradaTermino As String, _
                        ByVal sDataLiberacaoInicio As String, _
                        ByVal sDataLiberacaoTermino As String, _
                        ByVal sAgrupadoPor As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFornecedor : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus : i += 1

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoInicio), sDataEmissaoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoTermino), sDataEmissaoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Entrada Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrada_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEntradaInicio), sDataEntradaInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Entrada Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrada_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEntradaTermino), sDataEntradaTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Liberação Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_liberacao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataLiberacaoInicio), sDataLiberacaoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Liberação Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_liberacao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataLiberacaoTermino), sDataLiberacaoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Agrupado Por
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agrupado_por"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sAgrupadoPor : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_grid_qa000000001", oSqlParameter)

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
