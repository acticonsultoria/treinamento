Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports System
Imports System.IO
Imports System.Text

Public Class clsFrmAdmBackup

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sPath As String
    Private sMensagem As String
    Private sPastaArquivo As String
    Private sPastaArquivoFisico As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property Mensagem() As String
        Get
            Return sMensagem
        End Get
        Set(ByVal value As String)
            sMensagem = value
        End Set
    End Property

    Public Property Path() As String
        Get
            Return sPath
        End Get
        Set(ByVal value As String)
            sPath = value
        End Set
    End Property

    Public Property PastaArquivoFisico() As String
        Get
            Return sPastaArquivoFisico
        End Get
        Set(ByVal value As String)
            sPastaArquivoFisico = value
        End Set
    End Property

    Public Property PastaArquivo() As String
        Get
            Return sPastaArquivo
        End Get
        Set(ByVal value As String)
            sPastaArquivo = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"
     
    Public Sub Backup()

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Path
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "path"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 250
            oSqlParameter(i).Value = sPath : i += 1

            'Seta Parametros - Database
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "database"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = goDatabase.sInitialCatalog : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Pasta Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pasta_arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500 : i += 1

            'Seta Parametros - Pasta Arquivo Físico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pasta_arquivo_fisico"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_administracao_backup", oSqlParameter)

            sPastaArquivo = oSqlParameter(i - 1).Value
            sPastaArquivoFisico = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ValidaPasta()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Pasta Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pasta_arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500 : i += 1

            'Seta Parametros - Pasta Arquivo Físico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pasta_arquivo_fisico"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500 : i += 1

            'Seta Parametros - Mensagem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_administracao_backup_validacao", oSqlParameter)

            sMensagem = oSqlParameter(i).Value
            sPastaArquivo = oSqlParameter(i - 2).Value
            sPastaArquivoFisico = oSqlParameter(i - 1).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
