Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrCstGerar

#Region "::: VARIÁVEIS :::"

    'Variaveis da Classe
    Private iCodigo As Integer
    Private sConta As String
    Private dValorGGF As Double
    Private dValorEncargo As Double
    Private dValorDepreciacao As Double
    Private dValorManutencao As Double
    Private dValorDespesa As Double
    Private dValorReceita As Double
    Private dValorBom As Double
    Private dValorOutros As Double
    Private sDescricao As String
    Private sDescricaoDepreciacao As String
    Private sDescricaoManutencao As String
    Private dValorTotal As Double
    Private iMes As Integer
    Private iAno As Integer
    Private iCodigoConta As Integer
    Private sCentroCusto As String
    Private dSaldoInicial As Double
    Private sSubItem As String
    Private sCentroCustoEncargo As String

    Public Property DescricaoManutencao As String
        Get
            Return sDescricaoManutencao
        End Get
        Set(ByVal value As String)
            sDescricaoManutencao = value
        End Set
    End Property

    Public Property DescricaoDepreciacao As String
        Get
            Return sDescricaoDepreciacao
        End Get
        Set(ByVal value As String)
            sDescricaoDepreciacao = value
        End Set
    End Property

    Public Property ValorDepreciacao As Double
        Get
            Return dValorDepreciacao
        End Get
        Set(ByVal value As Double)
            dValorDepreciacao = value
        End Set
    End Property

    Public Property ValorManutencao As Double
        Get
            Return dValorManutencao
        End Get
        Set(ByVal value As Double)
            dValorManutencao = value
        End Set
    End Property

    Public Property CentroCustoEncargo As String
        Get
            Return sCentroCustoEncargo
        End Get
        Set(ByVal value As String)
            sCentroCustoEncargo = value
        End Set
    End Property

    Public Property Codigo As Integer
        Get
            Return iCodigo
        End Get
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property

    Public Property Conta As String
        Get
            Return sConta
        End Get
        Set(ByVal value As String)
            sConta = value
        End Set
    End Property

    Public Property SubItem As String
        Get
            Return sSubItem
        End Get
        Set(ByVal value As String)
            sSubItem = value
        End Set
    End Property

    Public Property ValorGGF As Double
        Get
            Return dValorGGF
        End Get
        Set(ByVal value As Double)
            dValorGGF = value
        End Set
    End Property

    Public Property ValorTotal As Double
        Get
            Return dValorTotal
        End Get
        Set(ByVal value As Double)
            dValorTotal = value
        End Set
    End Property

    Public Property ValorEncargo As Double
        Get
            Return dValorEncargo
        End Get
        Set(ByVal value As Double)
            dValorEncargo = value
        End Set
    End Property

    Public Property ValorOutros As Double
        Get
            Return dValorOutros
        End Get
        Set(ByVal value As Double)
            dValorOutros = value
        End Set
    End Property

    Public Property Descricao As String
        Get
            Return sDescricao
        End Get
        Set(ByVal value As String)
            sDescricao = value
        End Set
    End Property

    Public Property Mes As Integer
        Get
            Return iMes
        End Get
        Set(ByVal value As Integer)
            iMes = value
        End Set
    End Property

    Public Property Ano As Integer
        Get
            Return iAno
        End Get
        Set(ByVal value As Integer)
            iAno = value
        End Set
    End Property

    Public Property CodigoConta As Integer
        Get
            Return iCodigoConta
        End Get
        Set(ByVal value As Integer)
            iCodigoConta = value
        End Set
    End Property

    Public Property CentroCusto As String
        Get
            Return sCentroCusto
        End Get
        Set(ByVal value As String)
            sCentroCusto = value
        End Set
    End Property

    Public Property ValorDespesa As Double
        Get
            Return dValorDespesa
        End Get
        Set(ByVal value As Double)
            dValorDespesa = value
        End Set
    End Property

    Public Property ValorReceita As Double
        Get
            Return dValorReceita
        End Get
        Set(ByVal value As Double)
            dValorReceita = value
        End Set
    End Property

    Public Property ValorBom As Double
        Get
            Return dValorBom
        End Get
        Set(ByVal value As Double)
            dValorBom = value
        End Set
    End Property

    Public Property SaldoInicial As Double
        Get
            Return dSaldoInicial
        End Get
        Set(ByVal value As Double)
            dSaldoInicial = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub DeleteDepreciacao()

        Try

            'Limpa a tabela
            ExecuteNonQuery(goDatabase.sConnection, CommandType.Text, "truncate table tb_tmp_depreciacao")

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub CarregaCenario()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo"
            oSqlParameter(1).Direction = ParameterDirection.Output
            oSqlParameter(1).SqlDbType = SqlDbType.Int

            'Seta Parametros 
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "mes"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iMes

            'Seta Parametros 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "ano"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iAno


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_custo_cenario", oSqlParameter)

            'Seta Váriavel 
            iCodigo = oSqlParameter(1).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertGGF()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "conta_contabil"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 100
            oSqlParameter(1).Value = sConta

            'Seta Parametros
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "valor_ggf"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Float
            oSqlParameter(2).Value = dValorGGF

            'Seta Parametros 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_custo_capa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigo

            'Seta Parametros 
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "sub_item"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Size = 100
            oSqlParameter(4).Value = sSubItem

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_custo_ggf", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertInsumo()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_custo_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iCodigo

            'Seta Parametros 
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "mes"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iMes

            'Seta Parametros 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "ano"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iAno

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_custo_insumo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertBeneficiamento()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_custo_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iCodigo

            'Seta Parametros 
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "mes"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iMes

            'Seta Parametros 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "ano"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iAno

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_custo_beneficiamento", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertBeneficiamentoTSI()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_custo_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iCodigo

            'Seta Parametros 
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "mes"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iMes

            'Seta Parametros 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "ano"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iAno

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_custo_beneficiamento_tsi", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDepreciacaoTMP()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "descricao"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 100
            oSqlParameter(1).Value = sDescricaoDepreciacao

            'Seta Parametros
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "valor"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Float
            oSqlParameter(2).Value = dValorDepreciacao

            'Seta Parametros 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_custo_capa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_custo_depreciacao_tmp", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDepreciacao()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_custo_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_custo_depreciacao", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertManutencao()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "conta_contabil"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 100
            oSqlParameter(1).Value = sConta

            'Seta Parametros
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "valor"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Float
            oSqlParameter(2).Value = dValorManutencao

            'Seta Parametros 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_custo_capa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigo

            'Seta Parametros 
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "descricao"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Size = 100
            oSqlParameter(4).Value = sDescricaoManutencao

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_custo_manutencao", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDespesa()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "conta_contabil"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 100
            oSqlParameter(1).Value = sConta

            'Seta Parametros
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "valor"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Float
            oSqlParameter(2).Value = dValorDespesa

            'Seta Parametros 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_custo_capa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigo

            'Seta Parametros 
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "descricao"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Size = 100
            oSqlParameter(4).Value = sDescricao

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_custo_despesa", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertReceita()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "conta_contabil"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 100
            oSqlParameter(1).Value = sConta

            'Seta Parametros
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "valor"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Float
            oSqlParameter(2).Value = dValorReceita

            'Seta Parametros 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_custo_capa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigo

            'Seta Parametros 
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "descricao"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Size = 100
            oSqlParameter(4).Value = sDescricao

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_custo_receita", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertBom()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "conta_contabil"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 100
            oSqlParameter(1).Value = sConta

            'Seta Parametros
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "valor"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Float
            oSqlParameter(2).Value = dValorBom

            'Seta Parametros 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_custo_capa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigo

            'Seta Parametros 
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "descricao"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Size = 100
            oSqlParameter(4).Value = sDescricao

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_custo_bom", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertOutros()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "conta_contabil"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 100
            oSqlParameter(1).Value = sConta

            'Seta Parametros
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "valor"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Float
            oSqlParameter(2).Value = dValorOutros

            'Seta Parametros 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_custo_capa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigo

            'Seta Parametros 
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "descricao"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Size = 100
            oSqlParameter(4).Value = sDescricao

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_custo_outros", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertEncargo()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros - Código
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "valor"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Float
            oSqlParameter(1).Value = dValorEncargo

            'Seta Parametros 
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_custo_capa"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigo

            'Seta Parametros - Código
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "centro_custo"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Size = 100
            oSqlParameter(3).Value = sCentroCustoEncargo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_custo_encargo", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub FinalizarCusteio()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_custo_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iCodigo


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_custo_finalizar", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadEncargo(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try


            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_custo_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iCodigo

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_custo_gerar_encargo", oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega a Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGGF(ByVal oGrid As GridEX)


        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_custo_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iCodigo

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_custo_gerar_ggf", oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega a Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDepreciacao(ByVal oGrid As GridEX)


        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_custo_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iCodigo

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_custo_gerar_depreciacao", oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega a Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadManutencao(ByVal oGrid As GridEX)


        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_custo_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iCodigo

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_custo_gerar_manutencao", oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega a Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDespesa(ByVal oGrid As GridEX)


        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_custo_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iCodigo

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_custo_gerar_despesa", oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega a Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadBeneficiamento(ByVal oGrid As GridEX, _
                                  ByVal iMes As Integer, _
                                  ByVal iAno As Integer)


        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "mes"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iMes

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "ano"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iAno

            'Seta Parametros 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_custo_capa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigo

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_custo_gerar_beneficiamento", oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega a Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaGGF() As Boolean

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim iReturn As Integer

        Try

            'Seta Parametros
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_custo_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCodigo

            'Seta Parametros
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_custo_ggf", oSqlParameter), Integer)

            'Seta Retorno da Função
            Return (IIf(iReturn > 0, False, True))

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaEncargo() As Boolean

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim iReturn As Integer

        Try

            'Seta Parametros
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_custo_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCodigo

            'Seta Parametros
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_custo_encargo", oSqlParameter), Integer)

            'Seta Retorno da Função
            Return (IIf(iReturn > 0, False, True))

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaDespesa() As Boolean

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim iReturn As Integer

        Try

            'Seta Parametros
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_custo_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCodigo

            'Seta Parametros
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "conta_contabil"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoConta

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "centro_custo"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Value = sCentroCusto

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_custo_despesa", oSqlParameter), Integer)

            'Seta Retorno da Função
            Return (IIf(iReturn > 0, False, True))

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaCusto() As Boolean

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim iReturn As Integer

        Try

            'Seta Parametros
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_custo_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCodigo

            'Seta Parametros
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "conta_contabil"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoConta

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "centro_custo"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Value = sCentroCusto

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_custo_custo", oSqlParameter), Integer)

            'Seta Retorno da Função
            Return (IIf(iReturn > 0, False, True))

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function DeleteGGF() As Boolean

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_custo_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCodigo

            'Seta Parametros
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_custo_ggf", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function DeleteEncargo() As Boolean

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_custo_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCodigo

            'Seta Parametros
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_custo_encargo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function DeleteDespesa() As Boolean

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_custo_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCodigo

            'Seta Parametros
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_custo_despesa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function DeleteCusto() As Boolean

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_custo_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCodigo

            'Seta Parametros
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_custo_custo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub Salvar(ByVal iMes As Integer, _
                      ByVal iAno As Integer, _
                      ByVal dTotalEncargoAdmFabrica As Double, _
                      ByVal dTotalEncargoAdmRevenda As Double)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "mes"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iMes

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "ano"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iAno

            'Seta Parametros 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigo

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "encargo_adm_fabrica"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Float
            oSqlParameter(4).Value = dTotalEncargoAdmFabrica

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "encargo_adm_revenda"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Float
            oSqlParameter(5).Value = dTotalEncargoAdmRevenda

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_custo_cenario", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
