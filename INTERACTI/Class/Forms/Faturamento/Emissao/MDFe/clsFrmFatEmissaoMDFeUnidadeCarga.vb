Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsFrmFatEmissaoMDFeUnidadeCarga

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe - dados mdfe
    Private iCodigoTipoUnidade As Integer
    Private sIdentificacao As String
    Private lCodigoEmissaoCapa As Long
    Private sChaveAcesso As String
    Private iQuantidadeRateada As Integer
    Private iLacre As Integer
    Private iTipo As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoTipoUnidade() As Integer
        Get
            Return iCodigoTipoUnidade
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoUnidade = value
        End Set
    End Property

    Public Property Identificacao() As String
        Get
            Return sIdentificacao
        End Get
        Set(ByVal value As String)
            sIdentificacao = value
        End Set
    End Property

    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
        End Set
    End Property

    Public Property ChaveAcesso() As String
        Get
            Return sChaveAcesso
        End Get
        Set(ByVal value As String)
            sChaveAcesso = value
        End Set
    End Property

    Public Property QuantidadeRateada() As Integer
        Get
            Return iQuantidadeRateada
        End Get
        Set(ByVal value As Integer)
            iQuantidadeRateada = value
        End Set
    End Property

    Public Property Lacre() As Integer
        Get
            Return iLacre
        End Get
        Set(ByVal value As Integer)
            iLacre = value
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

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = lCodigoEmissaoCapa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_tipo_unidade_carga"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoTipoUnidade

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "identificacao_unidade_carga"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Value = sIdentificacao

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "chave_acesso"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Value = sChaveAcesso

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "quantidade_rateada"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Int
            oSqlParameter(5).Value = iQuantidadeRateada

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "numero_lacre"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Int
            oSqlParameter(6).Value = iLacre

            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "tipo"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Int
            oSqlParameter(7).Value = iTipo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_unidade_carga", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridNotaFiscalDocumentos(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "tipo"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iTipo

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_unidade_carga", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateNotaFiscal(ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = lCodigoEmissaoCapa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_tipo_unidade_carga"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoTipoUnidade

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "identificacao_unidade_carga"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Value = sIdentificacao

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "chave_acesso"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Value = sChaveAcesso

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "quantidade_rateada"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Int
            oSqlParameter(5).Value = iQuantidadeRateada

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "numero_lacre"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Int
            oSqlParameter(6).Value = iLacre

            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "tipo"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Int
            oSqlParameter(7).Value = iTipo

            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "codigo"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.BigInt
            oSqlParameter(8).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_unidade_carga", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
