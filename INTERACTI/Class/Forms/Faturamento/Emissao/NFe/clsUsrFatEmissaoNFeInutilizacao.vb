Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.GridEX
Imports INTERACTI.SQLHelper

Public Class clsUsrFatEmissaoNFeInutilizacao

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sVersao As String
    Private sID As String
    Private iCodigoTipoAmbiente As Integer
    Private sVersaoAplicativo As String
    Private iStatus As Integer
    Private sMotivo As String
    Private sUF As String
    Private iAno As Integer
    Private sCNPJ As String
    Private iModelo As Integer
    Private iSerie As Integer
    Private lNFeInicial As Long
    Private lNFeFinal As Long
    Private sDataProcessamento As String
    Private sNumeroProtocolo As String
    Private sArquivoEnvio As String
    Private sArquivoRetorno As String
    Private sArquivoEnvioXML As String
    Private sArquivoRetornoXML As String

#End Region

#Region "::: PROPERTIE :::"

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

    Public Property Ano() As Integer
        Get
            Return iAno
        End Get
        Set(ByVal value As Integer)
            iAno = value
        End Set
    End Property

    Public Property CNPJ() As String
        Get
            Return sCNPJ
        End Get
        Set(ByVal value As String)
            sCNPJ = value
        End Set
    End Property

    Public Property Modelo() As Integer
        Get
            Return iModelo
        End Get
        Set(ByVal value As Integer)
            iModelo = value
        End Set
    End Property

    Public Property Serie() As Integer
        Get
            Return iSerie
        End Get
        Set(ByVal value As Integer)
            iSerie = value
        End Set
    End Property

    Public Property NFeInicial() As Long
        Get
            Return lNFeInicial
        End Get
        Set(ByVal value As Long)
            lNFeInicial = value
        End Set
    End Property

    Public Property NFeFinal() As Long
        Get
            Return lNFeFinal
        End Get
        Set(ByVal value As Long)
            lNFeFinal = value
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

    Public Property ArquivoEnvioXML() As String
        Get
            Return sArquivoEnvioXML
        End Get
        Set(ByVal value As String)
            sArquivoEnvioXML = value
        End Set
    End Property

    Public Property ArquivoRetornoXML() As String
        Get
            Return sArquivoRetornoXML
        End Get
        Set(ByVal value As String)
            sArquivoRetornoXML = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Versão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "versao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4
            oSqlParameter(i).Value = sVersao : i += 1

            'Seta Parametros - ID
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "id"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 17
            oSqlParameter(i).Value = sID : i += 1

            'Seta Parametros - Código Tipo de Ambiente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_ambiente_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoAmbiente : i += 1

            'Seta Parametros - Versão do Aplicativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "versao_aplicativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sVersaoAplicativo : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus : i += 1

            'Seta Parametros - Motivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "motivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 255
            oSqlParameter(i).Value = sMotivo : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUF : i += 1

            'Seta Parametros - Ano
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ano"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iAno : i += 1

            'Seta Parametros - CNPJ
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCNPJ : i += 1

            'Seta Parametros - Modelo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iModelo : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSerie : i += 1

            'Seta Parametros - Nota Fiscal Inicial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal_inicial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNFeInicial : i += 1

            'Seta Parametros - Nota Fiscal Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNFeFinal : i += 1

            'Seta Parametros - Data do Processamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_processamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataProcessamento), sDataProcessamento, DBNull.Value) : i += 1

            'Seta Parametros - Número do Protocolo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_protocolo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = IIf(IsNumeric(sNumeroProtocolo), sNumeroProtocolo, DBNull.Value) : i += 1

            'Seta Parametros - Arquivo Envio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_envio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivoEnvio : i += 1

            'Seta Parametros - Arquivo Retorno
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_retorno"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivoRetorno : i += 1

            'Seta Parametros - Arquivo Envio XML
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_envio_xml"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sArquivoEnvioXML : i += 1

            'Seta Parametros - Arquivo Retorno XML
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_retorno_xml"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sArquivoRetornoXML : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_inutilizacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lNotaFiscal As Long, _
                        ByVal iSerie As Integer, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNotaFiscal : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iSerie : i += 1

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio) = True, sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino) = True, sDataTermino, DBNull.Value) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_inutilizacao", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaFaixaNumeracao() As Integer

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaFaixaNumeracao = False

            'Seta Parametros - Ano
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ano"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iAno : i += 1

            'Seta Parametros - Modelo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iModelo : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSerie : i += 1

            'Seta Parametros - Nota Fiscal Inicial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal_inicial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNFeInicial : i += 1

            'Seta Parametros - Nota Fiscal Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNFeFinal : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_inutilizacao_numeracao_nfe", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaFaixaNumeracao = iReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
