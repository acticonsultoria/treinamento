Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsFrmCmpCotacaoInserirRequisicao

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private lCodigoRequisicao As Long
    Private lCodigoCotacao As Long
    Private lCodigoCotacaoLinha As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoRequisicao() As Long
        Get
            Return lCodigoRequisicao
        End Get
        Set(ByVal value As Long)
            lCodigoRequisicao = value
        End Set
    End Property

    Public Property CodigoCotacao() As Long
        Get
            Return lCodigoCotacao
        End Get
        Set(ByVal value As Long)
            lCodigoCotacao = value
        End Set
    End Property

    Public Property CodigoCotacaoLinha() As Long
        Get
            Return lCodigoCotacaoLinha
        End Get
        Set(ByVal value As Long)
            lCodigoCotacaoLinha = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByRef oGrid As Janus.Windows.GridEX.GridEX, ByVal lCodigoCotacao As Long)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim oDataSet As DataSet

        Try

            'Seta Parametros - Código da Cotação
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_cotacao"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoCotacao

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_cotacao_requisicoes", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("requisicao").DataMember = "numero_requisicao"
                .RootTable.Columns.Item("item").DataMember = "item"
                .RootTable.Columns.Item("quantidade").DataMember = "quantidade"

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function InsertCotacaoLinha() As Long

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try

            'Seta Parametros - Código da requisição
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_requisicao"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoRequisicao

            'Seta Parametros - Código da Cotação
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_cotacao_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = lCodigoCotacao

            'Seta Parametros - Código da Cotação Linha
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_cotacao_linha"
            oSqlParameter(2).Direction = ParameterDirection.Output
            oSqlParameter(2).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_cotacao_linha_requisicao", oSqlParameter)

            'Seta Retorno da Função
            InsertCotacaoLinha = oSqlParameter(2).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub InsertCotacaoFornecedorLinha()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter

        Try

            'Seta Parametros - Código da cotação linha
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_cotacao_linha"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoCotacaoLinha

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_cotacao_fornecedor_requisicao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
