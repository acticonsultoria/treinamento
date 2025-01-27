Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports INTERACTI.SQLHelper

Public Class clsUsrCadCentroTrabalho

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private iCodigo As Integer
    Private sCentroTrabalho As String
    Private sDescricao As String
    Private bOperacional As Boolean
    Private bAtivo As Boolean
    Private bMultiploApontamento As Boolean
    Private bMultiplaOPApontamento As Boolean
    Private dLimiteInferior As Double
    Private dLimiteSuperior As Double
    Private iCalendario As Integer
    Private iCodigoCentroGasto As Integer
    Private bSegunda As Boolean
    Private bTerca As Boolean
    Private bQuarta As Boolean
    Private bQuinta As Boolean
    Private bSexta As Boolean
    Private bSabado As Boolean
    Private bDomingo As Boolean
    Private dHorasSegunda As Double
    Private dHorasTerca As Double
    Private dHorasQuarta As Double
    Private dHorasQuinta As Double
    Private dHorasSexta As Double
    Private dHorasSabado As Double
    Private dHorasDomingo As Double
    Private iCodigoCentroTrabalhoAlternativo As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property Codigo() As Integer
        Get
            Return iCodigo
        End Get
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property

    Public Property CentroTrabalho() As String
        Get
            Return sCentroTrabalho
        End Get
        Set(ByVal value As String)
            sCentroTrabalho = value
        End Set
    End Property

    Public Property CodigoCentroTrabalhoAlternativo() As Integer
        Get
            Return iCodigoCentroTrabalhoAlternativo
        End Get
        Set(ByVal value As Integer)
            iCodigoCentroTrabalhoAlternativo = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return sDescricao
        End Get
        Set(ByVal value As String)
            sDescricao = value
        End Set
    End Property

    Public Property Operacional() As Boolean
        Get
            Return bOperacional
        End Get
        Set(ByVal value As Boolean)
            bOperacional = value
        End Set
    End Property

    Public Property Ativo() As Boolean
        Get
            Return bAtivo
        End Get
        Set(ByVal value As Boolean)
            bAtivo = value
        End Set
    End Property

    Public Property MultiploApontamento() As Boolean
        Get
            Return bMultiploApontamento
        End Get
        Set(ByVal value As Boolean)
            bMultiploApontamento = value
        End Set
    End Property
    Public Property MultiplaOPApontamento() As Boolean
        Get
            Return bMultiplaOPApontamento
        End Get
        Set(ByVal value As Boolean)
            bMultiplaOPApontamento = value
        End Set
    End Property
    Public Property LimiteInferior() As Double
        Get
            Return dLimiteInferior
        End Get
        Set(ByVal value As Double)
            dLimiteInferior = value
        End Set
    End Property

    Public Property LimiteSuperior() As Double
        Get
            Return dLimiteSuperior
        End Get
        Set(ByVal value As Double)
            dLimiteSuperior = value
        End Set
    End Property

    Public Property Calendario() As Integer
        Get
            Return iCalendario
        End Get
        Set(ByVal value As Integer)
            iCalendario = value
        End Set
    End Property

    Public Property CentroGasto() As Integer
        Get
            Return iCodigoCentroGasto
        End Get
        Set(ByVal value As Integer)
            iCodigoCentroGasto = value
        End Set
    End Property

    Public Property Segunda() As Boolean
        Get
            Return bSegunda
        End Get
        Set(ByVal value As Boolean)
            bSegunda = value
        End Set
    End Property

    Public Property Terca() As Boolean
        Get
            Return bTerca
        End Get
        Set(ByVal value As Boolean)
            bTerca = value
        End Set
    End Property

    Public Property Quarta() As Boolean
        Get
            Return bQuarta
        End Get
        Set(ByVal value As Boolean)
            bQuarta = value
        End Set
    End Property

    Public Property Quinta() As Boolean
        Get
            Return bQuinta
        End Get
        Set(ByVal value As Boolean)
            bQuinta = value
        End Set
    End Property

    Public Property Sexta() As Boolean
        Get
            Return bSexta
        End Get
        Set(ByVal value As Boolean)
            bSexta = value
        End Set
    End Property

    Public Property Sabado() As Boolean
        Get
            Return bSabado
        End Get
        Set(ByVal value As Boolean)
            bSabado = value
        End Set
    End Property

    Public Property Domingo() As Boolean
        Get
            Return bDomingo
        End Get
        Set(ByVal value As Boolean)
            bDomingo = value
        End Set
    End Property

    Public Property HorasSegunda() As Double
        Get
            Return dHorasSegunda
        End Get
        Set(ByVal value As Double)
            dHorasSegunda = value
        End Set
    End Property

    Public Property HorasTerca() As Double
        Get
            Return dHorasTerca
        End Get
        Set(ByVal value As Double)
            dHorasTerca = value
        End Set
    End Property

    Public Property HorasQuarta() As Double
        Get
            Return dHorasQuarta
        End Get
        Set(ByVal value As Double)
            dHorasQuarta = value
        End Set
    End Property

    Public Property HorasQuinta() As Double
        Get
            Return dHorasQuinta
        End Get
        Set(ByVal value As Double)
            dHorasQuinta = value
        End Set
    End Property

    Public Property HorasSexta() As Double
        Get
            Return dHorasSexta
        End Get
        Set(ByVal value As Double)
            dHorasSexta = value
        End Set
    End Property

    Public Property HorasSabado() As Double
        Get
            Return dHorasSabado
        End Get
        Set(ByVal value As Double)
            dHorasSabado = value
        End Set
    End Property

    Public Property HorasDomingo() As Double
        Get
            Return dHorasDomingo
        End Get
        Set(ByVal value As Double)
            dHorasDomingo = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: CENTRO DE TRABALHO :::"

    Public Function Insert() As Integer

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Centro de Trabalho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "centro_trabalho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCentroTrabalho : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - operacional
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "operacional"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bOperacional : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Multiplo Apontamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "multiplo_apontamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bMultiploApontamento : i += 1 : ReDim Preserve oSqlParameter(i)


            'Seta Parametros - Multipla OP Apontamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "multipla_op_apontamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bMultiplaOPApontamento : i += 1 : ReDim Preserve oSqlParameter(i)


            'Seta Parametros - Limite Inferior
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "limite_inferior"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dLimiteInferior : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Limite Superior
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "limite_superior"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dLimiteSuperior : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Calendário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_calendario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCalendario = -1, DBNull.Value, iCalendario) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Centro Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCentroGasto = -1, DBNull.Value, iCodigoCentroGasto) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Horas Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "horas_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHorasSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Horas Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "horas_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHorasTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Horas Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "horas_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHorasQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Horas Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "horas_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHorasQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Horas Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "horas_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHorasSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Horas Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "horas_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHorasSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Horas Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "horas_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHorasDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_trabalho_alternativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCentroTrabalhoAlternativo : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_centro_trabalho", oSqlParameter)

            iCodigo = oSqlParameter(i).Value

            Return iCodigo

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Centro de Trabalho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "centro_trabalho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCentroTrabalho : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - operacional
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "operacional"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bOperacional : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Multiplo Apontamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "multiplo_apontamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bMultiploApontamento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Multipla OP Apontamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "multipla_op_apontamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bMultiplaOPApontamento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Limite Inferior
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "limite_inferior"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dLimiteInferior : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Limite Superior
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "limite_superior"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dLimiteSuperior : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Calendário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_calendario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCalendario = -1, DBNull.Value, iCalendario) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Centro Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCentroGasto = -1, DBNull.Value, iCodigoCentroGasto) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Horas Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "horas_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHorasSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Horas Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "horas_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHorasTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Horas Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "horas_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHorasQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Horas Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "horas_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHorasQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Horas Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "horas_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHorasSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Horas Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "horas_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHorasSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Horas Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "horas_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHorasDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_trabalho_alternativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCentroTrabalhoAlternativo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_centro_trabalho", oSqlParameter)

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

                'Seta Parametros - Codigo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_centro_trabalho", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDados(ByVal iCodigo As Integer,
                         ByVal txtDescricao As MaskedEditBox,
                         ByVal cboOperacional As UIComboBox,
                         ByVal cboCalendario As UIComboBox,
                         ByVal cboCentroGasto As UIComboBox,
                         ByVal chkSegunda As UICheckBox,
                         ByVal chkTerca As UICheckBox,
                         ByVal chkQuarta As UICheckBox,
                         ByVal chkQuinta As UICheckBox,
                         ByVal chkSexta As UICheckBox,
                         ByVal txtHorasSegunda As MaskedEditBox,
                         ByVal txtHorasTerca As MaskedEditBox,
                         ByVal txtHorasQuarta As MaskedEditBox,
                         ByVal txtHorasQuinta As MaskedEditBox,
                         ByVal txtHorasSexta As MaskedEditBox,
                         ByVal txtHorasSabado As MaskedEditBox,
                         ByVal txtHorasDomingo As MaskedEditBox,
                         ByVal cboCentroTrabalhoAlternativo As UIComboBox,
                         ByVal cboAtivo As UIComboBox,
                         ByVal cboMultiploApontamento As UIComboBox, _
                         ByVal cboMultiplaOPApontamento As UIComboBox)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_centro_trabalho", oSqlParameter)

            While oSqlDataReader.Read

                'Preenche Controles
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                cboOperacional.SelectedValue = oSqlDataReader.Item("operacional")
                cboCalendario.SelectedValue = oSqlDataReader.Item("codigo_calendario")
                cboCentroGasto.SelectedValue = oSqlDataReader.Item("codigo_centro_custo")
                chkSegunda.Checked = oSqlDataReader.Item("segunda")
                chkTerca.Checked = oSqlDataReader.Item("terca")
                chkQuarta.Checked = oSqlDataReader.Item("quarta")
                chkQuinta.Checked = oSqlDataReader.Item("quinta")
                chkSexta.Checked = oSqlDataReader.Item("sexta")
                txtHorasSegunda.Text = oSqlDataReader.Item("horas_segunda")
                txtHorasTerca.Text = oSqlDataReader.Item("horas_terca")
                txtHorasQuarta.Text = oSqlDataReader.Item("horas_quarta")
                txtHorasQuinta.Text = oSqlDataReader.Item("horas_quinta")
                txtHorasSexta.Text = oSqlDataReader.Item("horas_sexta")
                txtHorasSabado.Text = oSqlDataReader.Item("horas_sabado")
                txtHorasDomingo.Text = oSqlDataReader.Item("horas_domingo")
                cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")
                cboMultiploApontamento.SelectedValue = oSqlDataReader.Item("multiplo_apontamento")
                cboMultiplaOPApontamento.SelectedValue = oSqlDataReader.Item("multipla_op_apontamento")

                If IsDBNull(oSqlDataReader.Item("codigo_centro_trabalho_alternativo")) Then
                    cboCentroTrabalhoAlternativo.SelectedIndex = -1
                Else
                    cboCentroTrabalhoAlternativo.SelectedValue = oSqlDataReader.Item("codigo_centro_trabalho_alternativo")
                End If

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaCentroTrabalho(ByVal iCodigo As Integer, _
                                         ByVal sCentroTrabalho As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaCentroTrabalho = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Centro Trabalho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "centro_trabalho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCentroTrabalho

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_centro_trabalho", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaCentroTrabalho = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGrid(ByVal oGrid As GridEX,
                        ByVal sCentroTrabalho As String,
                        ByVal sDescricao As String,
                        ByVal iOperacional As Integer,
                        ByVal iCodigoCalendario As Integer,
                        ByVal iCodigoCentroGasto As Integer,
                        ByVal bAtivo As Boolean)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Centro Trabalho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "centro_trabalho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCentroTrabalho : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Processamento Externo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "operacional"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(iOperacional = -1, DBNull.Value, iOperacional) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Calendário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_calendario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCalendario : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Centro Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCentroGasto : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bAtivo = -1, DBNull.Value, bAtivo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_centro_trabalho", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo_centro_trabalho"))

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDados(ByVal iCodigoCentroTrabalho As Integer, _
                         ByRef sDescricao As String, _
                         ByRef bAponta As Boolean)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCentroTrabalho : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_centro_trabalho", oSqlParameter)

            While oSqlDataReader.Read

                'Preenche Controles
                sDescricao = oSqlDataReader.Item("descricao")
                bAponta = IIf(oSqlDataReader.Item("processamento_externo") = True, False, True)

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertCentroTrabalhoPlanta(ByVal iCodigoPlanta As Integer, _
                                          ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Planta
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_planta"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoPlanta : i += 1

                'Seta Parametros - Código Centro Trabalho
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_centro_trabalho"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Checked
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "checked"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = oRow.Cells("x").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_producao_planta_centro_trabalho", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdatePosicaoCentroTrabalho(ByVal iCodigoPlanta As Integer, _
                                           ByVal iCodigoCentroTrabalho As Integer, _
                                           ByVal iX As Integer, _
                                           ByVal iY As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Planta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_planta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPlanta : i += 1

            'Seta Parametros - Código Centro Trabalho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_trabalho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCentroTrabalho : i += 1

            'Seta Parametros - Posição X
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "posicao_x"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iX : i += 1

            'Seta Parametros - Posição Y
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "posicao_y"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iY : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_producao_planta_centro_trabalho", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: MÁQUINA :::"

    Public Sub InsertMaquina(ByVal iCodigoCentroTrabalho As String, _
                             ByVal iCodigoMaquina As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Centro de Trabalho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_trabalho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCentroTrabalho : i += 1

            'Seta Parametros - Código Máquina
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_maquina"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMaquina : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_centro_trabalho_maquina", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateMaquina(ByVal iCodigoCentroTrabalho As Integer, _
                             ByVal iCodigoMaquina As Integer, _
                             ByVal iCodigoMaquinaAntigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Centro de Trabalho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_trabalho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCentroTrabalho : i += 1

            'Seta Parametros - Código Máquina
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_maquina"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMaquina : i += 1

            'Seta Parametros - Código Máquina Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_maquina_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMaquinaAntigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_centro_trabalho_maquina", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteMaquina(ByVal iCodigoCentroTrabalho As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Centro de Trabalho
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_centro_trabalho"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoCentroTrabalho : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Máquina
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_maquina"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_centro_trabalho_maquina", oSqlParameter)

                'Exclui Linha da Grid
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridMaquina(ByVal oGrid As GridEX, _
                               ByVal iCodigoCentroTrabalho As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Centro de Trabalho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_trabalho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCentroTrabalho : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_centro_trabalho_maquina", oSqlParameter)

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

#End Region

End Class
