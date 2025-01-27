Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrCfgPastaIntegracaoNFe

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sPastaArquivoNFe As String
    Private sPastaArquivoRetornoNFe As String
    Private sPastaArquivoCancelamentoNFe As String
    Private sPastaArquivoRetornoCancelamentoNFe As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property PastaArquivoNFe() As String
        Get
            Return sPastaArquivoNFe
        End Get
        Set(ByVal value As String)
            sPastaArquivoNFe = value
        End Set
    End Property

    Public Property PastaArquivoRetornoNFe() As String
        Get
            Return sPastaArquivoRetornoNFe
        End Get
        Set(ByVal value As String)
            sPastaArquivoRetornoNFe = value
        End Set
    End Property

    Public Property PastaArquivoCancelamentoNFe() As String
        Get
            Return sPastaArquivoCancelamentoNFe
        End Get
        Set(ByVal value As String)
            sPastaArquivoCancelamentoNFe = value
        End Set
    End Property

    Public Property PastaArquivoRetornoCancelamentoNFe() As String
        Get
            Return sPastaArquivoRetornoCancelamentoNFe
        End Get
        Set(ByVal value As String)
            sPastaArquivoRetornoCancelamentoNFe = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function Insert() As Integer

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros - Pasta Arquivo NFe
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "pasta_arquivo_nfe"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 255
            oSqlParameter(0).Value = sPastaArquivoNFe

            'Seta Parametros - Pasta Arquivo Retorno NFe
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "pasta_arquivo_retorno_nfe"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 255
            oSqlParameter(1).Value = sPastaArquivoRetornoNFe

            'Seta Parametros - Pasta Arquivo Cancelamento NFe
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "pasta_arquivo_cancelamento_nfe"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Size = 255
            oSqlParameter(2).Value = sPastaArquivoCancelamentoNFe

            'Seta Parametros - Pasta Arquivo Retorno Cancelamento NFe
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "pasta_arquivo_retorno_cancelamento_nfe"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Size = 255
            oSqlParameter(3).Value = sPastaArquivoRetornoCancelamentoNFe

            'Seta Parametros - Código Empresa
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_empresa"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(4).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_configuracao_pasta_integracao_nfe", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadDados(ByVal txtPastaArquivoNFe As MaskedEditBox, _
                         ByVal txtPastaArquivoRetornoNFe As MaskedEditBox, _
                         ByVal txtPastaArquivoCancelamentoNFe As MaskedEditBox, _
                         ByVal txtPastaArquivoRetornoCancelamentoNFe As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_pasta_integracao_nfe", oSqlParameter)

            While oSqlDataReader.Read

                txtPastaArquivoNFe.Text = oSqlDataReader.Item("pasta_arquivo_nfe")
                txtPastaArquivoRetornoNFe.Text = oSqlDataReader.Item("pasta_arquivo_retorno_nfe")
                txtPastaArquivoCancelamentoNFe.Text = oSqlDataReader.Item("pasta_arquivo_cancelamento_nfe")
                txtPastaArquivoRetornoCancelamentoNFe.Text = oSqlDataReader.Item("pasta_arquivo_retorno_cancelamento_nfe")

            End While

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
