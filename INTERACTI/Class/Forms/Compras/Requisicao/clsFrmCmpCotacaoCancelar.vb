Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper

Public Class clsFrmCmpCotacaoCancelar

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sJustificativa As String
    Private lCotacaoCapa As Long

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

    Public Property CotacaoCapa() As Long
        Get
            Return lCotacaoCapa
        End Get
        Set(ByVal value As Long)
            lCotacaoCapa = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function CancelarCotacao() As Integer

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim iReturn As Integer = 0

        Try

            'Seta Parametros - Código Usuário
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_usuario"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iUsuario

            'Seta Parametros - Justificativa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "justificativa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Text
            oSqlParameter(1).Value = Justificativa

            'Seta Parametros - Número Requisicao
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_cotacao_capa"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.BigInt
            oSqlParameter(2).Value = CotacaoCapa

            'Executa Query
            iReturn += ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_cotacao_capa_cancelar", oSqlParameter)

            'Seta Retorno da Função
            CancelarCotacao = iReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadDadosCotacao(ByVal lCodigoCotacao As Long, ByRef otxtData As Janus.Windows.GridEX.EditControls.EditBox, ByRef otxtUsuario As Janus.Windows.GridEX.EditControls.EditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter

        Try

            'Seta Parametros - Número da Cotação
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoCotacao

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_dados_cotacao", oSqlParameter)

            If oSqlDataReader.Read Then

                otxtData.Text = oSqlDataReader.Item("data")
                otxtUsuario.Text = oSqlDataReader.Item("nome")

            End If

            oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
