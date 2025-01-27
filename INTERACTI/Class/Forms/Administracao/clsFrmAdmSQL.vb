Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsFrmAdmSQL

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sArquivo As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property Arquivo() As String
        Get
            Return sArquivo
        End Get
        Set(ByVal value As String)
            sArquivo = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub ExecuteQuery()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter

        Try

            'Seta Parametros - Arquivo
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "arquivo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 250
            oSqlParameter(0).Value = sArquivo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_execute_query", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
