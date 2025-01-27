Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper

Public Class clsFrmFatEmissaoMDFeCancelar

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private lCodigoEmissaoCapa As Long
    Private sVersao As String
    Private sID As String
    Private iCodigoTipoAmbiente As Integer
    Private sVersaoAplicativo As String
    Private iStatus As Integer
    Private sMotivo As String
    Private sUF As String
    Private sChave As String
    Private sDataProcessamento As String
    Private sNumeroProtocolo As String
    Private sArquivoEnvio As String
    Private sArquivoRetorno As String
    Private sXMLCancelamentoEnvio As String
    Private sXMLCancelamentoRecepcao As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
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

    Public Property ID() As String
        Get
            Return sID
        End Get
        Set(ByVal value As String)
            sID = value
        End Set
    End Property

    Public Property CodigoTipoAmbiente() As Integer
        Get
            Return iCodigoTipoAmbiente
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoAmbiente = value
        End Set
    End Property

    Public Property VersaoAplicativo() As String
        Get
            Return sVersaoAplicativo
        End Get
        Set(ByVal value As String)
            sVersaoAplicativo = value
        End Set
    End Property

    Public Property Status() As Integer
        Get
            Return iStatus
        End Get
        Set(ByVal value As Integer)
            iStatus = value
        End Set
    End Property

    Public Property Motivo() As String
        Get
            Return sMotivo
        End Get
        Set(ByVal value As String)
            sMotivo = value
        End Set
    End Property

    Public Property UF() As String
        Get
            Return sUF
        End Get
        Set(ByVal value As String)
            sUF = value
        End Set
    End Property

    Public Property Chave() As String
        Get
            Return sChave
        End Get
        Set(ByVal value As String)
            sChave = value
        End Set
    End Property

    Public Property DataProcessamento() As String
        Get
            Return sDataProcessamento
        End Get
        Set(ByVal value As String)
            sDataProcessamento = value
        End Set
    End Property

    Public Property NumeroProtocolo() As String
        Get
            Return sNumeroProtocolo
        End Get
        Set(ByVal value As String)
            sNumeroProtocolo = value
        End Set
    End Property

    Public Property ArquivoEnvio() As String
        Get
            Return sArquivoEnvio
        End Get
        Set(ByVal value As String)
            sArquivoEnvio = value
        End Set
    End Property

    Public Property ArquivoRetorno() As String
        Get
            Return sArquivoRetorno
        End Get
        Set(ByVal value As String)
            sArquivoRetorno = value
        End Set
    End Property

    Public Property XMLCancelamentoEnvio() As String
        Get
            Return sXMLCancelamentoEnvio
        End Get
        Set(ByVal value As String)
            sXMLCancelamentoEnvio = value
        End Set
    End Property

    Public Property XMLCancelamentoRecepcao() As String
        Get
            Return sXMLCancelamentoRecepcao
        End Get
        Set(ByVal value As String)
            sXMLCancelamentoRecepcao = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub UpdateMDFeCancelamento(ByVal sMensagemSefaz As String, _
                                     ByVal sChaveAcesso As String, _
                                     ByVal sJustificativa As String, _
                                     ByVal sXMLCancelamentoEnvio As String, _
                                     ByVal sXMLCancelamentoRetorno As String)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Mensagem Sefaz
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem_sefaz"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 255
            oSqlParameter(i).Value = sMensagemSefaz : i += 1

            'Seta Parametros - Chave de Acesso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sChaveAcesso : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(StatusNotaFiscalEletronica.Cancelada) : i += 1

            'Seta Parametros - XML Cancelamento Envio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "xml_cancelamento_envio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sXMLCancelamentoEnvio : i += 1

            'Seta Parametros - XML Cancelamento Retorno
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "xml_cancelamento_retorno"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sXMLCancelamentoRetorno : i += 1

            'Seta Parametros - Justificativa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "justificativa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 255
            oSqlParameter(i).Value = sJustificativa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_capa_mdfe_cancelamento", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateMDFeCancelamento(ByVal lCodigoEmissaoCapa As Long, _
                                     ByVal sJustificativa As String)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(StatusManifestoEletronico.Cancelada) : i += 1

            'Seta Parametros - Justificativa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "justificativa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 255
            oSqlParameter(i).Value = sJustificativa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_capa_mdfe_cancelamento", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaMDFe() As Integer

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            ValidaMDFe = False

            'Seta Parametros - Chave de Acesso
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "chave_acesso"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 44
            oSqlParameter(0).Value = sChave

            'Seta Parametros - Número do Protocolo
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "numero_protocolo"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 15
            oSqlParameter(1).Value = sNumeroProtocolo

            'Seta Parametros - Codigo Empresa
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_empresa"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_inutilizacao_numeracao_mdfe", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaMDFe = iReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
