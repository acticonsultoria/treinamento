Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows

Public Class clsUsrAdmAlterarSenha

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sSenhaAtual As String
    Private sNovaSenha As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property SenhaAtual() As String
        Get
            Return sSenhaAtual
        End Get
        Set(ByVal value As String)
            sSenhaAtual = value
        End Set
    End Property

    Public Property NovaSenha() As String
        Get
            Return sNovaSenha
        End Get
        Set(ByVal value As String)
            sNovaSenha = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function Update() As Integer

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim iReturn As Integer

        Try

            'Seta Parametros - Nome
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_usuario"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iUsuario

            'Seta Parametros - E-mail
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "senha"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 20
            oSqlParameter(1).Value = Cripitografar(sNovaSenha)

            'Seta Parametros - Código Empresa
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_empresa"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_administracao_cadastro_usuario_senha", oSqlParameter)

            'Seta Retorno da Função
            Update = iReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaSenhaAtual() As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            ValidaSenhaAtual = False

            'Seta Parametros - Usuário
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_usuario"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iUsuario

            'Seta Parametros - Usuário Antigo
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "senha"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 20
            oSqlParameter(1).Value = Cripitografar(sSenhaAtual)

            'Seta Parametros - Código Empresa
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_empresa"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_administracao_usuario_senha", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaSenhaAtual = IIf(iReturn > 0, True, False)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
