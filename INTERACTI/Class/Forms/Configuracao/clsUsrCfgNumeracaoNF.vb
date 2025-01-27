Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrCfgNumeracaoNF

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sCodigoModelo As String
    Private iNotaFiscal As Integer
    Private sSerie As String
    Private iCodigo As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoModelo() As String
        Get
            Return sCodigoModelo
        End Get
        Set(ByVal value As String)
            sCodigoModelo = value
        End Set
    End Property

    Public Property NotaFiscal() As Integer
        Get
            Return iNotaFiscal
        End Get
        Set(ByVal value As Integer)
            iNotaFiscal = value
        End Set
    End Property

    Public Property Serie() As String
        Get
            Return sSerie
        End Get
        Set(ByVal value As String)
            sSerie = value
        End Set
    End Property

    Public Property Codigo() As Integer
        Get
            Return iCodigo
        End Get
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Save()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros - Modelo
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_modelo_nota_fiscal"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 3
            oSqlParameter(0).Value = sCodigoModelo

            'Seta Parametros - Nota Fiscal
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "nota_fiscal"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iNotaFiscal

            'Seta Parametros - Série
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "serie"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sSerie

            'Seta Parametros - Codigo Empresa
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_empresa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(3).Value = goUsuario.iEmpresa

            'Seta Parametros - Código
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(4).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_configuracao_numeracao_nota_fiscal", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
