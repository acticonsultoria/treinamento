Imports System
Imports System.Text
Imports INTERACTI.SQLHelper
Imports System.Data.SqlClient

Public Class clsFrmLiberacao

#Region "::: FUNÇÕES / SUB :::"

    Public Function ValidaUsuario(ByVal sUsuario As String, _
                                  ByVal sSenha As String, _
                                  ByVal iCodigoFormulario As Formulario, _
                                  ByVal sDireito As String) As Integer

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).ParameterName = "usuario"
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sUsuario : i += 1

            'Seta Parametros - Senha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).ParameterName = "senha"
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = Cripitografar(sSenha) : i += 1

            'Seta Parametros - Senha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Formulário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).ParameterName = "codigo_formulario"
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFormulario : i += 1

            'Seta Parametros - Direito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).ParameterName = "direito"
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sDireito

            'Executa Query
            Return CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_administracao_usuario_formulario", oSqlParameter), Integer)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
