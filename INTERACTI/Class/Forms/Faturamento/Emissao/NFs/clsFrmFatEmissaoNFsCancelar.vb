Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper

Public Class clsFrmFatEmissaoNFsCancelar

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sJustificativa As String
    Private iCodigoCancelamento As Integer
    Private lCodigo As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property Justificativa() As String
        Get
            Return sJustificativa
        End Get
        Set(ByVal value As String)
            sJustificativa = value
        End Set
    End Property

    Public Property CodigoCancelamento() As Integer
        Get
            Return iCodigoCancelamento
        End Get
        Set(ByVal value As Integer)
            iCodigoCancelamento = value
        End Set
    End Property

    Public Property Codigo() As Long
        Get
            Return lCodigo
        End Get
        Set(ByVal value As Long)
            lCodigo = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub CancelarNotaFiscal()

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Cancelamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cancelamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoCancelamento = -1, DBNull.Value, iCodigoCancelamento) : i += 1

            'Seta Parametros - Mensagem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 200
            oSqlParameter(i).Value = "NOTA FISCAL CANCELADA COM SUCESSO" : i += 1

            'Seta Parametros - Justificativa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "justificativa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = Justificativa : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusNFSe.Cancelada
            
            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_nfse_status", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
