Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrVen000000003

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sDataOrcamentoInicio As String, _
                        ByVal sDataOrcamentoTermino As String, _
                        ByVal iCodigoParceiroNegocio As Integer, _
                        ByVal iCodigoVendedor As Integer, _
                        ByVal sDataPrevisaoVendaInicio As String, _
                        ByVal sDataPrevisaoVendaTermino As String, _
                        ByVal iCodigoGrupoItem As Integer, _
                        ByVal iCodigoParceiroNegocioSegmento As Integer, _
                        ByVal iCodigoProbabilidadeVenda As Integer, _
                        ByVal sAgrupadoPor As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Código Vendedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vendedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoVendedor : i += 1

            'Seta Parametros - Data Orçamento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_orcamento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataOrcamentoInicio), sDataOrcamentoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Orçamento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_orcamento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataOrcamentoTermino), sDataOrcamentoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Previsão Venda Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_previsao_venda_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPrevisaoVendaInicio), sDataPrevisaoVendaInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Previsão Venda Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_previsao_venda_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPrevisaoVendaTermino), sDataPrevisaoVendaTermino, DBNull.Value) : i += 1

            'Seta Parametros - Código Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

            'Seta Parametros - Código Segmento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio_segmento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocioSegmento : i += 1

            'Seta Parametros - Código Probabilidade Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_probabilidade_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoProbabilidadeVenda : i += 1

            'Seta Parametros - Agrupado Por
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agrupado_por"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sAgrupadoPor : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_grid_ven000000003", oSqlParameter)

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
