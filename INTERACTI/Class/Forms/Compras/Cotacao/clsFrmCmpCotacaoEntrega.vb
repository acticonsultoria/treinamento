Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.GridEX
Imports INTERACTI.SQLHelper

Public Class clsFrmCmpCotacaoEntrega

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lCodigoCotacao As Long, _
                        ByVal iCodigoCotacaoItem As Integer, _
                        ByVal iCodigoCotacaoFornecedor As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros - Código Cotação
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_cotacao"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoCotacao

            'Seta Parametros - Código de Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Cotação Item
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_cotacao_item"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = iCodigoCotacaoItem

            'Seta Parametros - Código Cotação Fornecedor
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_cotacao_fornecedor"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(3).Value = iCodigoCotacaoFornecedor

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_cotacao_fornecedor_orcamento_entrega_desmembrar", oSqlParameter)
                        
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

    Public Sub Delete(ByVal lCodigoCotacao As Long, _
                      ByVal iCodigoCotacaoItem As Integer, _
                      ByVal iCodigoCotacaoFornecedor As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros - Código Cotação
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_cotacao"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoCotacao

            'Seta Parametros - Código de Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Cotação Item
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_cotacao_item"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = iCodigoCotacaoItem

            'Seta Parametros - Código Cotação Fornecedor
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_cotacao_fornecedor"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(3).Value = iCodigoCotacaoFornecedor

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_compras_cotacao_fornecedor_orcamento_entrega", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Insert(ByVal lCodigoCotacao As Long, _
                      ByVal iCodigoCotacaoItem As Integer, _
                      ByVal iCodigoCotacaoFornecedor As Integer, _
                      ByVal oRow() As GridEXRow)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer

        Try

            For i = 0 To UBound(oRow)

                'Seta Parametros - Código Cotação
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_cotacao"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoCotacao

                'Seta Parametros - Código de Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Seta Parametros - Código Cotação Item
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_cotacao_item"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(2).Value = iCodigoCotacaoItem

                'Seta Parametros - Código Cotação Fornecedor
                oSqlParameter(3) = New SqlParameter
                oSqlParameter(3).ParameterName = "codigo_cotacao_fornecedor"
                oSqlParameter(3).Direction = ParameterDirection.Input
                oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(3).Value = iCodigoCotacaoFornecedor

                'Seta Parametros - Prazo de Entrega
                oSqlParameter(4) = New SqlParameter
                oSqlParameter(4).ParameterName = "prazo_entrega"
                oSqlParameter(4).Direction = ParameterDirection.Input
                oSqlParameter(4).SqlDbType = SqlDbType.DateTime
                oSqlParameter(4).Value = oRow(i).Cells("prazo_entrega").Value

                'Seta Parametros - Quantidade
                oSqlParameter(5) = New SqlParameter
                oSqlParameter(5).ParameterName = "quantidade"
                oSqlParameter(5).Direction = ParameterDirection.Input
                oSqlParameter(5).SqlDbType = SqlDbType.Float
                oSqlParameter(5).Value = oRow(i).Cells("quantidade").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_cotacao_fornecedor_orcamento_entrega", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
