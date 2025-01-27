Imports System.Data
Imports System.Data.SqlClient
Imports SysACTi.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsFrmCmpPedidoDesmembrarEntrega

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private lPedidoLinha As Long
    Private sDataEntrega As String
    Private iQuantidade As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property PedidoLinha() As Long
        Get
            Return lPedidoLinha
        End Get
        Set(ByVal value As Long)
            lPedidoLinha = value
        End Set
    End Property

    Public Property Quantidade() As Integer
        Get
            Return iQuantidade
        End Get
        Set(ByVal value As Integer)
            iQuantidade = value
        End Set
    End Property

    Public Property DataEntrega() As String
        Get
            Return sDataEntrega
        End Get
        Set(ByVal value As String)
            sDataEntrega = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter

        Try

            'Seta Parametros - Código Pedido Linha
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_linha"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lPedidoLinha

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_compras_pedido_linha_entrega", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try

            'Seta Parametros - Código Pedido Linha
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_linha"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lPedidoLinha

            'Seta Parametros - Quantidade
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "quantidade"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Float
            oSqlParameter(1).Value = iQuantidade

            'Seta Parametros - Data Entrega
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_prazo_entrega"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            oSqlParameter(2).Value = CDate(sDataEntrega)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_pedido_linha_entrega", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lCodigoPedidoLinha As Long)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim oSqlDataReader As SqlDataReader

        Try

            'Seta Parametros - Código Cotação Fornecedor Linha
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_linha"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoPedidoLinha

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_pedido_linha_entrega", oSqlParameter)

            'Limpa Grid
            Call ClearUnboundGrid(oGrid)

            While oSqlDataReader.Read() = True

                'Adiciona Item
                oGrid.AddItem(oSqlDataReader.Item("data_prazo_entrega"), _
                         oSqlDataReader.Item("quantidade"))

            End While

            'Fecha SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
