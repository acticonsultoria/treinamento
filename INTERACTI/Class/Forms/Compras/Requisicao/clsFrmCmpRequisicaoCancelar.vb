Imports System.Data
Imports System.Data.SqlClient
Imports SysACTi.SQLHelper

Public Class clsFrmCmpRequisicaoCancelar

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sHistorico As String

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

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub CancelarRequisicao()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For i = 0 To UBound(gSelecaoRow)

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

                'Seta Parametros - Código Requisicao
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.BigInt
                oSqlParameter(2).Value = gSelecaoRow(i).Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_requisicao_cancelar", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
