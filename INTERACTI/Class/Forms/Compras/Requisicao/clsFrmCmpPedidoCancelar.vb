Imports System.Data
Imports System.Data.SqlClient
Imports SysACTi.SQLHelper

Public Class clsFrmCmpPedidoCancelar

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sJustificativa As String
    Private lCodigoPedidoCapa As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property Justificativa() As String
        Get
            Return sJustificativa
        End Get
        Set(ByVal value As String)
            sJustificativa = value
        End Set
    End Property

    Public Property Pedido() As Long
        Get
            Return lCodigoPedidoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoPedidoCapa = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub CancelarPedido()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try

            'Seta Parametros - Código Usuário
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_usuario"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iUsuario

            'Seta Parametros - Justificativa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "historico"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Text
            oSqlParameter(1).Value = Justificativa

            'Seta Parametros - Número Pedido
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.BigInt
            oSqlParameter(2).Value = Pedido

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_pedido_cancelar", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
