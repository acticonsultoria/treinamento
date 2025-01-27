Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrAdmAtualizarAplicativo

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sAplicativo As String
    Private sVersao As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property Aplicativo() As String
        Get
            Return sAplicativo
        End Get
        Set(ByVal value As String)
            sAplicativo = value
        End Set
    End Property

    Public Property Versao() As String
        Get
            Return sVersao
        End Get
        Set(ByVal value As String)
            sVersao = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function Insert() As Integer

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros - Pasta Arquivo NFe
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "aplicativo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 255
            oSqlParameter(0).Value = sAplicativo

            'Seta Parametros - Versão
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "versao"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 10
            oSqlParameter(1).Value = sVersao

            'Seta Parametros - Código do Usuário
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_usuario"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Empresa
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_empresa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(3).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_administracao_aplicativo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadDados(ByVal lblDataAtualizacao As Label, _
                         ByVal lblVersaoAtual As Label)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_administracao_aplicativo", oSqlParameter)

            While oSqlDataReader.Read

                lblDataAtualizacao.Text = oSqlDataReader.Item("data")
                lblVersaoAtual.Text = Application.ProductVersion.ToString

            End While

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
