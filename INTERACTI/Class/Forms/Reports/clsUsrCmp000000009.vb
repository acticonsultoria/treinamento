Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrCmp000000009

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iCodigoFornecedor As Integer, _
                        ByVal iStatus As Integer, _
                        ByVal sDataPedidoInicio As String, _
                        ByVal sDataPedidoTermino As String, _
                        ByVal sDataPrevisaoEntregaInicio As String, _
                        ByVal sDataPrevisaoEntregaTermino As String, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sDataEntradaInicio As String, _
                        ByVal sDataEntradaTermino As String, _
                        ByVal sCodigoGrupoItem As String, _
                        ByVal sCodigoProduto As String, _
                        ByVal sDescricao As String, _
                        ByVal sAgrupadoPor As String, _
                        ByVal sAvaliarPor As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(15) As SqlParameter
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

            'Seta Parametros - Data Pedido Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pedido_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPedidoInicio), sDataPedidoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Pedido Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pedido_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPedidoTermino), sDataPedidoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Previsão Entrega Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_previsao_entrega_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPrevisaoEntregaInicio), sDataPrevisaoEntregaInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Previsão Entrega Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_previsao_entrega_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPrevisaoEntregaTermino), sDataPrevisaoEntregaTermino, DBNull.Value) : i += 1

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

            'Seta Parametros - Código Grupo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoGrupoItem : i += 1

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

            'Seta Parametros - Agrupado Por
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agrupado_por"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sAgrupadoPor : i += 1

            'Seta Parametros - Avaliar Por
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "avaliar_por"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sAvaliarPor : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_grid_cmp000000009", oSqlParameter)

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
