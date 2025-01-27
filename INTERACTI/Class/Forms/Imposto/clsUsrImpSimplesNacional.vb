Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrImpSimplesNacional

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private iTipoEmpresa As Integer
    Private dReceitaBrutaInicio As Double
    Private dReceitaBrutaFinal As Double
    Private dAliquota As Double
    Private dIRPJ As Double
    Private dCSLL As Double
    Private dCOFINS As Double
    Private dPIS As Double
    Private dCPP As Double
    Private dICMS As Double
    Private dISS As Double
    Private bFaixaAtiva As Boolean
    Private iCodigo As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property TipoEmpresa() As Integer
        Get
            Return iTipoEmpresa
        End Get
        Set(ByVal value As Integer)
            iTipoEmpresa = value
        End Set
    End Property

    Public Property ReceitaBrutaInicio() As Double
        Get
            Return dReceitaBrutaInicio
        End Get
        Set(ByVal value As Double)
            dReceitaBrutaInicio = value
        End Set
    End Property

    Public Property ReceitaBrutaFinal() As Double
        Get
            Return dReceitaBrutaFinal
        End Get
        Set(ByVal value As Double)
            dReceitaBrutaFinal = value
        End Set
    End Property

    Public Property Aliquota() As Double
        Get
            Return dAliquota
        End Get
        Set(ByVal value As Double)
            dAliquota = value
        End Set
    End Property

    Public Property IRPJ() As Double
        Get
            Return dIRPJ
        End Get
        Set(ByVal value As Double)
            dIRPJ = value
        End Set
    End Property

    Public Property CSLL() As Double
        Get
            Return dCSLL
        End Get
        Set(ByVal value As Double)
            dCSLL = value
        End Set
    End Property

    Public Property COFINS() As Double
        Get
            Return dCOFINS
        End Get
        Set(ByVal value As Double)
            dCOFINS = value
        End Set
    End Property

    Public Property PIS() As Double
        Get
            Return dPIS
        End Get
        Set(ByVal value As Double)
            dPIS = value
        End Set
    End Property

    Public Property CPP() As Double
        Get
            Return dCPP
        End Get
        Set(ByVal value As Double)
            dCPP = value
        End Set
    End Property

    Public Property ICMS() As Double
        Get
            Return dICMS
        End Get
        Set(ByVal value As Double)
            dICMS = value
        End Set
    End Property

    Public Property ISS() As Double
        Get
            Return dISS
        End Get
        Set(ByVal value As Double)
            dISS = value
        End Set
    End Property

    Public Property FaixaAtiva() As Boolean
        Get
            Return bFaixaAtiva
        End Get
        Set(ByVal value As Boolean)
            bFaixaAtiva = value
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

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(12) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Tipo de Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_empresa_simples_nacional"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoEmpresa : i += 1

            'Seta Parametros - Receita Bruta Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "receita_bruta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dReceitaBrutaInicio : i += 1

            'Seta Parametros - Receita Bruta Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "receita_bruta_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dReceitaBrutaFinal : i += 1

            'Seta Parametros - Alíquota
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquota : i += 1

            'Seta Parametros - IRPJ
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "irpj"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dIRPJ : i += 1

            'Seta Parametros - CSLL
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "csll"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCSLL : i += 1

            'Seta Parametros - COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCOFINS : i += 1

            'Seta Parametros - PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPIS : i += 1

            'Seta Parametros - CPP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cpp"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCPP : i += 1

            'Seta Parametros - ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dICMS : i += 1

            'Seta Parametros - ISS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dISS : i += 1

            'Seta Parametros - Faixa Ativa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "faixa_ativa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bFaixaAtiva

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_imposto_simples_nacional", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(13) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Tipo de Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_empresa_simples_nacional"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoEmpresa : i += 1

            'Seta Parametros - Receita Bruta Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "receita_bruta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dReceitaBrutaInicio : i += 1

            'Seta Parametros - Receita Bruta Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "receita_bruta_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dReceitaBrutaFinal : i += 1

            'Seta Parametros - Alíquota
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquota : i += 1

            'Seta Parametros - IRPJ
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "irpj"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dIRPJ : i += 1

            'Seta Parametros - CSLL
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "csll"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCSLL : i += 1

            'Seta Parametros - COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCOFINS : i += 1

            'Seta Parametros - PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPIS : i += 1

            'Seta Parametros - CPP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cpp"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCPP : i += 1

            'Seta Parametros - ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dICMS : i += 1

            'Seta Parametros - ISS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dISS : i += 1

            'Seta Parametros - Faixa Ativa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "faixa_ativa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bFaixaAtiva : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_imposto_simples_nacional", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_imposto_simples_nacional", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iTipoEmpresa As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Tipo Empresa Simples Nacional
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_empresa_simples_nacional"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoEmpresa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_imposto_simples_nacional", oSqlParameter)
            
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

#End Region

End Class
