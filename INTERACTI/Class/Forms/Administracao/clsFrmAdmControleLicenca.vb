Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper

Public Class clsFrmAdmControleLicenca

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sDataValidacao As String
    Private sDataValidade As String
    Private sNumeroLicenca As String
    Private sTolerancia As String
    Private iTipo As Integer


#End Region

#Region "::: PROPERTIE :::"

    Public Property Tolerancia() As String
        Get
            Return sTolerancia
        End Get
        Set(ByVal value As String)
            sTolerancia = value
        End Set
    End Property

    Public Property Tipo() As Integer
        Get
            Return iTipo
        End Get
        Set(ByVal value As Integer)
            iTipo = value
        End Set
    End Property


    Public Property DataValidacao() As String
        Get
            Return sDataValidacao
        End Get
        Set(ByVal value As String)
            sDataValidacao = value
        End Set
    End Property

    Public Property DataValidade() As String
        Get
            Return sDataValidade
        End Get
        Set(ByVal value As String)
            sDataValidade = value
        End Set
    End Property

    Public Property NumeroLicenca() As String
        Get
            Return sNumeroLicenca
        End Get
        Set(ByVal value As String)
            sNumeroLicenca = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_validacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sDataValidacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sDataValidade : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_licenca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sNumeroLicenca : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tolerancia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(IsDBNull(sTolerancia), "", sTolerancia) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(IsDBNull(iTipo) = True, TipoControleLicenca.Interacti, iTipo) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_administracao_licenca", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

End Class
