Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper

Public Class clsFrmFinReceitaCobrancaComentario

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private lCodigoTituloCapa As Long
    Private iNumeroParcela As Integer
    Private sHistorico As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoTituloCapa() As Long
        Get
            Return lCodigoTituloCapa
        End Get
        Set(ByVal value As Long)
            lCodigoTituloCapa = value
        End Set
    End Property

    Public Property NumeroParcela() As Integer
        Get
            Return iNumeroParcela
        End Get
        Set(ByVal value As Integer)
            iNumeroParcela = value
        End Set
    End Property

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

    Public Sub Salvar()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros - Código Titulo Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_titulo_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoTituloCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Seta Parametros - Número Parcela
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "numero_parcela"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = iNumeroParcela

            'Seta Parametros - Código Usuário
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_usuario"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = goUsuario.iUsuario

            'Seta Parametros - Histórico
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "historico"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Size = 500
            oSqlParameter(4).Value = sHistorico

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_parcela_cobranca", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
