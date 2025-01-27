Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrSGA000000003

#Region "::: FUNCTION / SUB :::"

    Public Sub Insert(ByVal iMesInicial As Integer, _
                      ByVal iAnoInicial As Integer, _
                      ByVal iMesTermino As Integer, _
                      ByVal iAnoTermino As Integer, _
                      ByVal sCodigos As String, _
                      ByVal iCodigoEmpresa As Integer)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "mes_inicial"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iMesInicial

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "ano_inicial"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iAnoInicial

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "mes_termino"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iMesTermino

            'Seta Parametros 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "ano_termino"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iAnoTermino

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigos"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Value = sCodigos

            'Seta Parametros 
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "codigo_empresa"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(5).Value = iCodigoEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_sga_protocolo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
