Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrCfgEmail

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private iCodigoFormaEnvio As Integer
    Private sEmail As String
    Private sUsuario As String
    Private sSenha As String
    Private sServidor As String
    Private sPorta As String
    Private bSSL As Boolean

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoFormaEnvio() As Integer
        Get
            Return iCodigoFormaEnvio
        End Get
        Set(ByVal value As Integer)
            iCodigoFormaEnvio = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return sEmail
        End Get
        Set(ByVal value As String)
            sEmail = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return sUsuario
        End Get
        Set(ByVal value As String)
            sUsuario = value
        End Set
    End Property

    Public Property Senha() As String
        Get
            Return sSenha
        End Get
        Set(ByVal value As String)
            sSenha = value
        End Set
    End Property

    Public Property Servidor() As String
        Get
            Return sServidor
        End Get
        Set(ByVal value As String)
            sServidor = value
        End Set
    End Property

    Public Property Porta() As String
        Get
            Return sPorta
        End Get
        Set(ByVal value As String)
            sPorta = value
        End Set
    End Property

    Public Property SSL() As Boolean
        Get
            Return bSSL
        End Get
        Set(ByVal value As Boolean)
            bSSL = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Save()

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código - Forma de Envio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_envio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoFormaEnvio : i += 1

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(iCodigoFormaEnvio = CInt(TipoEmail.Interacti), sEmail, DBNull.Value) : i += 1

            'Seta Parametros - Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(iCodigoFormaEnvio = CInt(TipoEmail.Interacti), sUsuario, DBNull.Value) : i += 1

            'Seta Parametros - Senha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "senha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(iCodigoFormaEnvio = CInt(TipoEmail.Interacti), sSenha, DBNull.Value) : i += 1

            'Seta Parametros - Servidor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "servidor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(iCodigoFormaEnvio = CInt(TipoEmail.Interacti), sServidor, DBNull.Value) : i += 1

            'Seta Parametros - Porta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "porta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4
            oSqlParameter(i).Value = IIf(iCodigoFormaEnvio = CInt(TipoEmail.Interacti), sPorta, DBNull.Value) : i += 1

            'Seta Parametros - SSL
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ssl"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(iCodigoFormaEnvio = CInt(TipoEmail.Interacti), bSSL, DBNull.Value) : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo Usuario
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_configuracao_email", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDados(ByVal cboFormaEnvio As UIComboBox, _
                         ByVal txtEmail As MaskedEditBox, _
                         ByVal txtUsuario As MaskedEditBox, _
                         ByVal txtSenha As EditBox, _
                         ByVal txtServidor As MaskedEditBox, _
                         ByVal txtPorta As MaskedEditBox, _
                         ByVal cboSSL As UIComboBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuario
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_email", oSqlParameter)

            While oSqlDataReader.Read

                cboFormaEnvio.SelectedValue = oSqlDataReader.Item("codigo_forma_envio")
                txtEmail.Text = oSqlDataReader.Item("email")
                txtUsuario.Text = oSqlDataReader.Item("usuario")
                txtSenha.Text = oSqlDataReader.Item("senha")
                txtServidor.Text = oSqlDataReader.Item("servidor")
                txtPorta.Text = oSqlDataReader.Item("porta")
                cboSSL.SelectedValue = oSqlDataReader.Item("ssl")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
