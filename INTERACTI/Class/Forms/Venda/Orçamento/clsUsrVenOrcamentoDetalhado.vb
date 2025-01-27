Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrVenOrcamentoDetalhado

#Region "::: FUNCTION / SUB :::"

    Public Sub Save(ByVal oRowUpdate As Hashtable)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim oRow As GridEXRow
        Dim i As Integer = 0
        Dim oClsIntegracao As New clsIntegracao

        Try

            For Each oRow In oRowUpdate.Values

                'Limpa váriavel
                i = 0

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Pedido
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_pedido"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_pedido").Value : i += 1

                'Seta Parametros - Código Pedido Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_pedido_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_pedido_item").Value : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Data Previsão Entrega
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_previsao_entrega"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_previsao_entrega").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_pedido_item_entrega", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNumeroOrcamento As String, _
                        ByVal sCliente As String, _
                        ByVal sStatus As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(12) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_orcamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroOrcamento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCliente : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sStatus : i += 1


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_orcamento_detalhado", oSqlParameter)

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
