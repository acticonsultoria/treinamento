Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper

Public Class clsFrmCmpPedidoCancelar

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private lCodigoPedidoCapa As Long
    Private sHistorico As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoPedidoCapa() As Long
        Get
            Return lCodigoPedidoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoPedidoCapa = value
        End Set
    End Property

    Public Property Historico() As String
        Get
            Return sHistorico
        End Get
        Set(ByVal value As String)
            sHistorico = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub CancelarPedido()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros - Código Pedido Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoPedidoCapa

            'Seta Parametros - Codigo Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Seta Parametros - Histórico
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "historico"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Size = 255
            oSqlParameter(2).Value = sHistorico

            'Seta Parametros - Codigo Usuário
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_usuario"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = goUsuario.iUsuario

            'Seta Parametros - Status
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_tipo_pedido"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(4).Value = TipoPedido.Cancelado

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compra_pedido_capa_cancelar", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteContasPagar()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código Pedi Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoPedidoCapa

            'Seta Parametros - Codigo Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_despesa_pedido", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
