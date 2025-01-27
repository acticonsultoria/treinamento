Imports System.Data
Imports System.Data.SqlClient
Imports SysACTi.SQLHelper

Public Class clsFrmCmpPedidoReprovar

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sHistorico As String
    Private lCodigo As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property Historico() As String
        Get
            Return sHistorico
        End Get
        Set(ByVal value As String)
            sHistorico = value
        End Set
    End Property

    Public Property Codigo() As Long
        Get
            Return lCodigo
        End Get
        Set(ByVal value As Long)
            lCodigo = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub ReprovarPedido()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        
        Try

            'Seta Parametros - Código Usuário
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_usuario"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iUsuario

            'Seta Parametros - Histórico
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "historico"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Text
            oSqlParameter(1).Value = sHistorico

            'Seta Parametros - Código Pedido
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.BigInt
            oSqlParameter(2).Value = lCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_pedido_reprovar", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
