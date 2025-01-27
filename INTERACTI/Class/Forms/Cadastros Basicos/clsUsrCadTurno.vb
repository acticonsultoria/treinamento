Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports INTERACTI.SQLHelper

Public Class clsUsrCadTurno

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private iCodigo As Integer
    Private sDescricao As String
    Private bSegunda As Boolean
    Private bTerca As Boolean
    Private bQuarta As Boolean
    Private bQuinta As Boolean
    Private bSexta As Boolean
    Private bSabado As Boolean
    Private bDomingo As Boolean
    Private dHoraEntradaSegunda As Double
    Private dHoraEntradaTerca As Double
    Private dHoraEntradaQuarta As Double
    Private dHoraEntradaQuinta As Double
    Private dHoraEntradaSexta As Double
    Private dHoraEntradaSabado As Double
    Private dHoraEntradaDomingo As Double
    Private dHoraSaidaSegunda As Double
    Private dHoraSaidaTerca As Double
    Private dHoraSaidaQuarta As Double
    Private dHoraSaidaQuinta As Double
    Private dHoraSaidaSexta As Double
    Private dHoraSaidaSabado As Double
    Private dHoraSaidaDomingo As Double
    Private dHoraAlmocoSegundaInicio As Double
    Private dHoraAlmocoTercaInicio As Double
    Private dHoraAlmocoQuartaInicio As Double
    Private dHoraAlmocoQuintaInicio As Double
    Private dHoraAlmocoSextaInicio As Double
    Private dHoraAlmocoSabadoInicio As Double
    Private dHoraAlmocoDomingoInicio As Double
    Private dHoraAlmocoSegundaTermino As Double
    Private dHoraAlmocoTercaTermino As Double
    Private dHoraAlmocoQuartaTermino As Double
    Private dHoraAlmocoQuintaTermino As Double
    Private dHoraAlmocoSextaTermino As Double
    Private dHoraAlmocoSabadoTermino As Double
    Private dHoraAlmocoDomingoTermino As Double
    Private dHoraIntervaloSegundaInicio As Double
    Private dHoraIntervaloTercaInicio As Double
    Private dHoraIntervaloQuartaInicio As Double
    Private dHoraIntervaloQuintaInicio As Double
    Private dHoraIntervaloSextaInicio As Double
    Private dHoraIntervaloSabadoInicio As Double
    Private dHoraIntervaloDomingoInicio As Double
    Private dHoraIntervaloSegundaTermino As Double
    Private dHoraIntervaloTercaTermino As Double
    Private dHoraIntervaloQuartaTermino As Double
    Private dHoraIntervaloQuintaTermino As Double
    Private dHoraIntervaloSextaTermino As Double
    Private dHoraIntervaloSabadoTermino As Double
    Private dHoraIntervaloDomingoTermino As Double
    Private dHoraAdicionalInicio As Double
    Private dHoraAdicionalTermino As Double
    Private iCodigoHoraExtraSegunda As Integer
    Private iHoraExtraAposSegunda As Integer
    Private iCodigoHoraExtraAposSegunda As Integer
    Private iCodigoHoraExtraTerca As Integer
    Private iHoraExtraAposTerca As Integer
    Private iCodigoHoraExtraAposTerca As Integer
    Private iCodigoHoraExtraQuarta As Integer
    Private iHoraExtraAposQuarta As Integer
    Private iCodigoHoraExtraAposQuarta As Integer
    Private iCodigoHoraExtraQuinta As Integer
    Private iHoraExtraAposQuinta As Integer
    Private iCodigoHoraExtraAposQuinta As Integer
    Private iCodigoHoraExtraSexta As Integer
    Private iHoraExtraAposSexta As Integer
    Private iCodigoHoraExtraAposSexta As Integer
    Private iCodigoHoraExtraSabado As Integer
    Private iHoraExtraAposSabado As Integer
    Private iCodigoHoraExtraAposSabado As Integer
    Private iCodigoHoraExtraDomingo As Integer
    Private iHoraExtraAposDomingo As Integer
    Private iCodigoHoraExtraAposDomingo As Integer

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

    Public Property Descricao() As String
        Get
            Return sDescricao
        End Get
        Set(ByVal value As String)
            sDescricao = value
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


    Public Property HoraEntradaSegunda() As Double
        Get
            Return dHoraEntradaSegunda
        End Get
        Set(ByVal value As Double)
            dHoraEntradaSegunda = value
        End Set
    End Property

    Public Property HoraEntradaTerca() As Double
        Get
            Return dHoraEntradaTerca
        End Get
        Set(ByVal value As Double)
            dHoraEntradaTerca = value
        End Set
    End Property

    Public Property HoraEntradaQuarta() As Double
        Get
            Return dHoraEntradaQuarta
        End Get
        Set(ByVal value As Double)
            dHoraEntradaQuarta = value
        End Set
    End Property

    Public Property HoraEntradaQuinta() As Double
        Get
            Return dHoraEntradaQuinta
        End Get
        Set(ByVal value As Double)
            dHoraEntradaQuinta = value
        End Set
    End Property

    Public Property HoraEntradaSexta() As Double
        Get
            Return dHoraEntradaSexta
        End Get
        Set(ByVal value As Double)
            dHoraEntradaSexta = value
        End Set
    End Property

    Public Property HoraEntradaSabado() As Double
        Get
            Return dHoraEntradaSabado
        End Get
        Set(ByVal value As Double)
            dHoraEntradaSabado = value
        End Set
    End Property

    Public Property HoraEntradaDomingo() As Double
        Get
            Return dHoraEntradaDomingo
        End Get
        Set(ByVal value As Double)
            dHoraEntradaDomingo = value
        End Set
    End Property


    Public Property HoraSaidaSegunda() As Double
        Get
            Return dHoraSaidaSegunda
        End Get
        Set(ByVal value As Double)
            dHoraSaidaSegunda = value
        End Set
    End Property

    Public Property HoraSaidaTerca() As Double
        Get
            Return dHoraSaidaTerca
        End Get
        Set(ByVal value As Double)
            dHoraSaidaTerca = value
        End Set
    End Property

    Public Property HoraSaidaQuarta() As Double
        Get
            Return dHoraSaidaQuarta
        End Get
        Set(ByVal value As Double)
            dHoraSaidaQuarta = value
        End Set
    End Property

    Public Property HoraSaidaQuinta() As Double
        Get
            Return dHoraSaidaQuinta
        End Get
        Set(ByVal value As Double)
            dHoraSaidaQuinta = value
        End Set
    End Property

    Public Property HoraSaidaSexta() As Double
        Get
            Return dHoraSaidaSexta
        End Get
        Set(ByVal value As Double)
            dHoraSaidaSexta = value
        End Set
    End Property

    Public Property HoraSaidaSabado() As Double
        Get
            Return dHoraSaidaSabado
        End Get
        Set(ByVal value As Double)
            dHoraSaidaSabado = value
        End Set
    End Property

    Public Property HoraSaidaDomingo() As Double
        Get
            Return dHoraSaidaDomingo
        End Get
        Set(ByVal value As Double)
            dHoraSaidaDomingo = value
        End Set
    End Property


    Public Property HoraAlmocoSegundaInicio() As Double
        Get
            Return dHoraAlmocoSegundaInicio
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoSegundaInicio = value
        End Set
    End Property

    Public Property HoraAlmocoTercaInicio() As Double
        Get
            Return dHoraAlmocoTercaInicio
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoTercaInicio = value
        End Set
    End Property

    Public Property HoraAlmocoQuartaInicio() As Double
        Get
            Return dHoraAlmocoQuartaInicio
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoQuartaInicio = value
        End Set
    End Property

    Public Property HoraAlmocoQuintaInicio() As Double
        Get
            Return dHoraAlmocoQuintaInicio
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoQuintaInicio = value
        End Set
    End Property

    Public Property HoraAlmocoSextaInicio() As Double
        Get
            Return dHoraAlmocoSextaInicio
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoSextaInicio = value
        End Set
    End Property

    Public Property HoraAlmocoSabadoInicio() As Double
        Get
            Return dHoraAlmocoSabadoInicio
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoSabadoInicio = value
        End Set
    End Property

    Public Property HoraAlmocoDomingoInicio() As Double
        Get
            Return dHoraAlmocoDomingoInicio
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoDomingoInicio = value
        End Set
    End Property

    Public Property HoraAlmocoSegundaTermino() As Double
        Get
            Return dHoraAlmocoSegundaTermino
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoSegundaTermino = value
        End Set
    End Property

    Public Property HoraAlmocoTercaTermino() As Double
        Get
            Return dHoraAlmocoTercaTermino
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoTercaTermino = value
        End Set
    End Property

    Public Property HoraAlmocoQuartaTermino() As Double
        Get
            Return dHoraAlmocoQuartaTermino
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoQuartaTermino = value
        End Set
    End Property

    Public Property HoraAlmocoQuintaTermino() As Double
        Get
            Return dHoraAlmocoQuintaTermino
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoQuintaTermino = value
        End Set
    End Property

    Public Property HoraAlmocoSextaTermino() As Double
        Get
            Return dHoraAlmocoSextaTermino
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoSextaTermino = value
        End Set
    End Property

    Public Property HoraAlmocoSabadoTermino() As Double
        Get
            Return dHoraAlmocoSabadoTermino
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoSabadoTermino = value
        End Set
    End Property

    Public Property HoraAlmocoDomingoTermino() As Double
        Get
            Return dHoraAlmocoDomingoTermino
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoDomingoTermino = value
        End Set
    End Property

    Public Property HoraIntervaloSegundaInicio() As Double
        Get
            Return dHoraIntervaloSegundaInicio
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloSegundaInicio = value
        End Set
    End Property

    Public Property HoraIntervaloTercaInicio() As Double
        Get
            Return dHoraIntervaloTercaInicio
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloTercaInicio = value
        End Set
    End Property

    Public Property HoraIntervaloQuartaInicio() As Double
        Get
            Return dHoraIntervaloQuartaInicio
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloQuartaInicio = value
        End Set
    End Property

    Public Property HoraIntervaloQuintaInicio() As Double
        Get
            Return dHoraIntervaloQuintaInicio
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloQuintaInicio = value
        End Set
    End Property

    Public Property HoraIntervaloSextaInicio() As Double
        Get
            Return dHoraIntervaloSextaInicio
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloSextaInicio = value
        End Set
    End Property

    Public Property HoraIntervaloSabadoInicio() As Double
        Get
            Return dHoraIntervaloSabadoInicio
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloSabadoInicio = value
        End Set
    End Property

    Public Property HoraIntervaloDomingoInicio() As Double
        Get
            Return dHoraIntervaloDomingoInicio
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloDomingoInicio = value
        End Set
    End Property

    Public Property HoraIntervaloSegundaTermino() As Double
        Get
            Return dHoraIntervaloSegundaTermino
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloSegundaTermino = value
        End Set
    End Property

    Public Property HoraIntervaloTercaTermino() As Double
        Get
            Return dHoraIntervaloTercaTermino
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloTercaTermino = value
        End Set
    End Property

    Public Property HoraIntervaloQuartaTermino() As Double
        Get
            Return dHoraIntervaloQuartaTermino
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloQuartaTermino = value
        End Set
    End Property

    Public Property HoraIntervaloQuintaTermino() As Double
        Get
            Return dHoraIntervaloQuintaTermino
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloQuintaTermino = value
        End Set
    End Property

    Public Property HoraIntervaloSextaTermino() As Double
        Get
            Return dHoraIntervaloSextaTermino
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloSextaTermino = value
        End Set
    End Property

    Public Property HoraIntervaloSabadoTermino() As Double
        Get
            Return dHoraIntervaloSabadoTermino
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloSabadoTermino = value
        End Set
    End Property

    Public Property HoraIntervaloDomingoTermino() As Double
        Get
            Return dHoraIntervaloDomingoTermino
        End Get
        Set(ByVal value As Double)
            dHoraIntervaloDomingoTermino = value
        End Set
    End Property

    Public Property HoraAdicionalNoturnoInicio() As Double
        Get
            Return dHoraAdicionalInicio
        End Get
        Set(ByVal value As Double)
            dHoraAdicionalInicio = value
        End Set
    End Property

    Public Property HoraAdicionalNoturnoTermino() As Double
        Get
            Return dHoraAdicionalTermino
        End Get
        Set(ByVal value As Double)
            dHoraAdicionalTermino = value
        End Set
    End Property

    Public Property CodigoHoraExtraSegunda() As Integer
        Get
            Return iCodigoHoraExtraSegunda
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraSegunda = value
        End Set
    End Property

    Public Property HoraExtraAposSegunda() As Integer
        Get
            Return iHoraExtraAposSegunda
        End Get
        Set(ByVal value As Integer)
            iHoraExtraAposSegunda = value
        End Set
    End Property

    Public Property CodigoHoraExtraAposSegunda() As Integer
        Get
            Return iCodigoHoraExtraAposSegunda
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraAposSegunda = value
        End Set
    End Property

    Public Property CodigoHoraExtraTerca() As Integer
        Get
            Return iCodigoHoraExtraTerca
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraTerca = value
        End Set
    End Property

    Public Property HoraExtraAposTerca() As Integer
        Get
            Return iHoraExtraAposTerca
        End Get
        Set(ByVal value As Integer)
            iHoraExtraAposTerca = value
        End Set
    End Property

    Public Property CodigoHoraExtraAposTerca() As Integer
        Get
            Return iCodigoHoraExtraAposTerca
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraAposTerca = value
        End Set
    End Property

    Public Property CodigoHoraExtraQuarta() As Integer
        Get
            Return iCodigoHoraExtraQuarta
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraQuarta = value
        End Set
    End Property

    Public Property HoraExtraAposQuarta() As Integer
        Get
            Return iHoraExtraAposQuarta
        End Get
        Set(ByVal value As Integer)
            iHoraExtraAposQuarta = value
        End Set
    End Property

    Public Property CodigoHoraExtraAposQuarta() As Integer
        Get
            Return iCodigoHoraExtraAposQuarta
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraAposQuarta = value
        End Set
    End Property

    Public Property CodigoHoraExtraQuinta() As Integer
        Get
            Return iCodigoHoraExtraQuinta
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraQuinta = value
        End Set
    End Property

    Public Property HoraExtraAposQuinta() As Integer
        Get
            Return iHoraExtraAposQuinta
        End Get
        Set(ByVal value As Integer)
            iHoraExtraAposQuinta = value
        End Set
    End Property

    Public Property CodigoHoraExtraAposQuinta() As Integer
        Get
            Return iCodigoHoraExtraAposQuinta
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraAposQuinta = value
        End Set
    End Property

    Public Property CodigoHoraExtraSexta() As Integer
        Get
            Return iCodigoHoraExtraSexta
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraSexta = value
        End Set
    End Property

    Public Property HoraExtraAposSexta() As Integer
        Get
            Return iHoraExtraAposSexta
        End Get
        Set(ByVal value As Integer)
            iHoraExtraAposSexta = value
        End Set
    End Property

    Public Property CodigoHoraExtraAposSexta() As Integer
        Get
            Return iCodigoHoraExtraAposSexta
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraAposSexta = value
        End Set
    End Property

    Public Property CodigoHoraExtraSabado() As Integer
        Get
            Return iCodigoHoraExtraSabado
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraSabado = value
        End Set
    End Property

    Public Property HoraExtraAposSabado() As Integer
        Get
            Return iHoraExtraAposSabado
        End Get
        Set(ByVal value As Integer)
            iHoraExtraAposSabado = value
        End Set
    End Property

    Public Property CodigoHoraExtraAposSabado() As Integer
        Get
            Return iCodigoHoraExtraAposSabado
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraAposSabado = value
        End Set
    End Property

    Public Property CodigoHoraExtraDomingo() As Integer
        Get
            Return iCodigoHoraExtraDomingo
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraDomingo = value
        End Set
    End Property

    Public Property HoraExtraAposDomingo() As Integer
        Get
            Return iHoraExtraAposDomingo
        End Get
        Set(ByVal value As Integer)
            iHoraExtraAposDomingo = value
        End Set
    End Property

    Public Property CodigoHoraExtraAposDomingo() As Integer
        Get
            Return iCodigoHoraExtraAposDomingo
        End Get
        Set(ByVal value As Integer)
            iCodigoHoraExtraAposDomingo = value
        End Set
    End Property


#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros -  Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros -  Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros -  Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros -  Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros -  Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros -  Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros -  Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Segunda Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_segunda_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSegundaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Terça Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_terca_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoTercaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Quarta Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quarta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuartaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Quinta Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quinta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuintaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Sexta Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sexta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSextaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sabado_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSabadoInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Domingo Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_domingo_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoDomingoInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Segunda Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_segunda_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSegundaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Terça Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_terca_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoTercaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Quarta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quarta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuartaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Quinta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quinta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuintaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Sexta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sexta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSextaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Sabado Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sabado_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSabadoTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Domingo Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_domingo_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoDomingoTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Segunda Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_segunda_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSegundaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Terça Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_terca_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloTercaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Quarta Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_quarta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloQuartaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Quinta Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_quinta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloQuintaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Sexta Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_sexta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSextaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Sabado Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_sabado_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSabadoInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Domingo Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_domingo_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloDomingoInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Segunda Termino 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_segunda_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSegundaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Terça Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_terca_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloTercaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Quarta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_quarta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloQuartaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Quinta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_quinta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloQuintaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Sexta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_sexta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSextaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Sabado Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_sabado_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSabadoTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Domingo Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_domingo_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloDomingoTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Adicional Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "adicional_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAdicionalInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Adicional Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "adicional_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAdicionalTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraSegunda = -1, DBNull.Value, iCodigoHoraExtraSegunda) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposSegunda = -1, DBNull.Value, iCodigoHoraExtraAposSegunda) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Terca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraTerca = -1, DBNull.Value, iCodigoHoraExtraTerca) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Terca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Terca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposTerca = -1, DBNull.Value, iCodigoHoraExtraAposTerca) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraQuarta = -1, DBNull.Value, iCodigoHoraExtraQuarta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposQuarta = -1, DBNull.Value, iCodigoHoraExtraAposQuarta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraQuinta = -1, DBNull.Value, iCodigoHoraExtraQuinta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposQuinta = -1, DBNull.Value, iCodigoHoraExtraAposQuinta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraSexta = -1, DBNull.Value, iCodigoHoraExtraSexta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposSexta = -1, DBNull.Value, iCodigoHoraExtraAposSexta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraSabado = -1, DBNull.Value, iCodigoHoraExtraSabado) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposSabado = -1, DBNull.Value, iCodigoHoraExtraAposSabado) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraDomingo = -1, DBNull.Value, iCodigoHoraExtraDomingo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposDomingo = -1, DBNull.Value, iCodigoHoraExtraAposDomingo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_turno", oSqlParameter)

            iCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try
            
            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros -  Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros -  Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros -  Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros -  Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros -  Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros -  Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros -  Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Entrada Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "entrada_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraEntradaDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Saida Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "saida_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraSaidaDomingo : i += 1 : ReDim Preserve oSqlParameter(i)


            'Seta Parametros - Hora Almoço Segunda Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_segunda_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSegundaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Terça Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_terca_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoTercaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Quarta Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quarta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuartaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Quinta Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quinta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuintaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Sexta Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sexta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSextaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sabado_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSabadoInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Domingo Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_domingo_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoDomingoInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Segunda Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_segunda_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSegundaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Terça Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_terca_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoTercaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Quarta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quarta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuartaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Quinta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quinta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuintaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Sexta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sexta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSextaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Sabado Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sabado_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSabadoTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Almoço Domingo Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_domingo_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoDomingoTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Segunda Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_segunda_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSegundaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Terça Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_terca_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloTercaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Quarta Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_quarta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloQuartaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Quinta Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_quinta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloQuintaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Sexta Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_sexta_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSextaInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Sabado Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_sabado_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSabadoInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Domingo Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_domingo_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloDomingoInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Segunda Termino 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_segunda_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSegundaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Terça Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_terca_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloTercaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Quarta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_quarta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloQuartaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Quinta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_quinta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloQuintaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Sexta Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_sexta_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSextaTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Sabado Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_sabado_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloSabadoTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Intervalo Domingo Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_intervalo_domingo_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraIntervaloDomingoTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Adicional Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "adicional_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAdicionalInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Adicional Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "adicional_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAdicionalTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraSegunda = -1, DBNull.Value, iCodigoHoraExtraSegunda) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposSegunda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposSegunda = -1, DBNull.Value, iCodigoHoraExtraAposSegunda) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Terca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraTerca = -1, DBNull.Value, iCodigoHoraExtraTerca) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Terca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposTerca : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Terca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposTerca = -1, DBNull.Value, iCodigoHoraExtraAposTerca) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraQuarta = -1, DBNull.Value, iCodigoHoraExtraQuarta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposQuarta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposQuarta = -1, DBNull.Value, iCodigoHoraExtraAposQuarta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraQuinta = -1, DBNull.Value, iCodigoHoraExtraQuinta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposQuinta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposQuinta = -1, DBNull.Value, iCodigoHoraExtraAposQuinta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraSexta = -1, DBNull.Value, iCodigoHoraExtraSexta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposSexta : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposSexta = -1, DBNull.Value, iCodigoHoraExtraAposSexta) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraSabado = -1, DBNull.Value, iCodigoHoraExtraSabado) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposSabado = -1, DBNull.Value, iCodigoHoraExtraAposSabado) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraDomingo = -1, DBNull.Value, iCodigoHoraExtraDomingo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Hora Extra Após Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_apos_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraExtraAposDomingo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Hora Extra Após Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hora_extra_apos_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoHoraExtraAposDomingo = -1, DBNull.Value, iCodigoHoraExtraAposDomingo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_turno", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oRow As GridEXRow
        Dim i As Integer

        Try

            For Each oRow In gSelecaoRow

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código
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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_turno", oSqlParameter)

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
                         ByVal chkSegunda As UICheckBox,
                         ByVal chkTerca As UICheckBox,
                         ByVal chkQuarta As UICheckBox,
                         ByVal chkQuinta As UICheckBox,
                         ByVal chkSexta As UICheckBox,
                         ByVal chkSabado As UICheckBox,
                         ByVal chkDomingo As UICheckBox,
                         ByVal txtHoraEntradaSegunda As MaskedEditBox,
                         ByVal txtHoraEntradaTerca As MaskedEditBox,
                         ByVal txtHoraEntradaQuarta As MaskedEditBox,
                         ByVal txtHoraEntradaQuinta As MaskedEditBox,
                         ByVal txtHoraEntradaSexta As MaskedEditBox,
                         ByVal txtHoraEntradaSabado As MaskedEditBox,
                         ByVal txtHoraEntradaDomingo As MaskedEditBox,
                         ByVal txtHoraSaidaSegunda As MaskedEditBox,
                         ByVal txtHoraSaidaTerca As MaskedEditBox,
                         ByVal txtHoraSaidaQuarta As MaskedEditBox,
                         ByVal txtHoraSaidaQuinta As MaskedEditBox,
                         ByVal txtHoraSaidaSexta As MaskedEditBox,
                         ByVal txtHoraSaidaSabado As MaskedEditBox,
                         ByVal txtHoraSaidaDomingo As MaskedEditBox,
                         ByVal txtHoraAlmocoSegundaInicio As MaskedEditBox,
                         ByVal txtHoraAlmocoTercaInicio As MaskedEditBox,
                         ByVal txtHoraAlmocoQuartaInicio As MaskedEditBox,
                         ByVal txtHoraAlmocoQuintaInicio As MaskedEditBox,
                         ByVal txtHoraAlmocoSextaInicio As MaskedEditBox,
                         ByVal txtHoraAlmocoSabadoInicio As MaskedEditBox,
                         ByVal txtHoraAlmocoDomingoInicio As MaskedEditBox,
                         ByVal txtHoraAlmocoSegundaTermino As MaskedEditBox,
                         ByVal txtHoraAlmocoTercaTermino As MaskedEditBox,
                         ByVal txtHoraAlmocoQuartaTermino As MaskedEditBox,
                         ByVal txtHoraAlmocoQuintaTermino As MaskedEditBox,
                         ByVal txtHoraAlmocoSextaTermino As MaskedEditBox,
                         ByVal txtHoraAlmocoSabadoTermino As MaskedEditBox,
                         ByVal txtHoraAlmocoDomingoTermino As MaskedEditBox,
                         ByVal txtHoraIntervaloSegundaInicio As MaskedEditBox,
                         ByVal txtHoraIntervaloTercaInicio As MaskedEditBox,
                         ByVal txtHoraIntervaloQuartaInicio As MaskedEditBox,
                         ByVal txtHoraIntervaloQuintaInicio As MaskedEditBox,
                         ByVal txtHoraIntervaloSextaInicio As MaskedEditBox,
                         ByVal txtHoraIntervaloSabadoInicio As MaskedEditBox,
                         ByVal txtHoraIntervaloDomingoInicio As MaskedEditBox,
                         ByVal txtHoraIntervaloSegundaTermino As MaskedEditBox,
                         ByVal txtHoraIntervaloTercaTermino As MaskedEditBox,
                         ByVal txtHoraIntervaloQuartaTermino As MaskedEditBox,
                         ByVal txtHoraIntervaloQuintaTermino As MaskedEditBox,
                         ByVal txtHoraIntervaloSextaTermino As MaskedEditBox,
                         ByVal txtHoraIntervaloSabadoTermino As MaskedEditBox,
                         ByVal txtHoraIntervaloDomingoTermino As MaskedEditBox,
                         ByVal txtHoraAdicionalNoturnoInicio As MaskedEditBox,
                         ByVal txtHoraAdicionalNoturnoTermino As MaskedEditBox,
                         ByVal cboHoraExtraSegunda As UIComboBox,
                         ByVal txtHoraExtraAposSegunda As NumericEditBox,
                         ByVal cboHoraExtraAposSegunda As UIComboBox,
                         ByVal cboHoraExtraTerca As UIComboBox,
                         ByVal txtHoraExtraAposTerca As NumericEditBox,
                         ByVal cboHoraExtraAposTerca As UIComboBox,
                         ByVal cboHoraExtraQuarta As UIComboBox,
                         ByVal txtHoraExtraAposQuarta As NumericEditBox,
                         ByVal cboHoraExtraAposQuarta As UIComboBox,
                         ByVal cboHoraExtraQuinta As UIComboBox,
                         ByVal txtHoraExtraAposQuinta As NumericEditBox,
                         ByVal cboHoraExtraAposQuinta As UIComboBox,
                         ByVal cboHoraExtraSexta As UIComboBox,
                         ByVal txtHoraExtraAposSexta As NumericEditBox,
                         ByVal cboHoraExtraAposSexta As UIComboBox,
                         ByVal cboHoraExtraSabado As UIComboBox,
                         ByVal txtHoraExtraAposSabado As NumericEditBox,
                         ByVal cboHoraExtraAposSabado As UIComboBox,
                         ByVal cboHoraExtraDomingo As UIComboBox,
                         ByVal txtHoraExtraAposDomingo As NumericEditBox,
                         ByVal cboHoraExtraAposDomingo As UIComboBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
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
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_turno", oSqlParameter)

            While oSqlDataReader.Read

                'Preenche Controles
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                txtDescricao.Tag = iCodigo
                chkSegunda.Checked = oSqlDataReader.Item("segunda")
                chkTerca.Checked = oSqlDataReader.Item("terca")
                chkQuarta.Checked = oSqlDataReader.Item("quarta")
                chkQuinta.Checked = oSqlDataReader.Item("quinta")
                chkSexta.Checked = oSqlDataReader.Item("sexta")
                chkSabado.Checked = oSqlDataReader.Item("sabado")
                chkDomingo.Checked = oSqlDataReader.Item("domingo")
                txtHoraEntradaSegunda.Text = IIf(IsDBNull(oSqlDataReader.Item("entrada_segunda")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("entrada_segunda")).ToString("HH:mm:ss"))
                txtHoraEntradaTerca.Text = IIf(IsDBNull(oSqlDataReader.Item("entrada_terca")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("entrada_terca")).ToString("HH:mm:ss"))
                txtHoraEntradaQuarta.Text = IIf(IsDBNull(oSqlDataReader.Item("entrada_quarta")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("entrada_quarta")).ToString("HH:mm:ss"))
                txtHoraEntradaQuinta.Text = IIf(IsDBNull(oSqlDataReader.Item("entrada_quinta")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("entrada_quinta")).ToString("HH:mm:ss"))
                txtHoraEntradaSexta.Text = IIf(IsDBNull(oSqlDataReader.Item("entrada_sexta")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("entrada_sexta")).ToString("HH:mm:ss"))
                txtHoraEntradaSabado.Text = IIf(IsDBNull(oSqlDataReader.Item("entrada_sabado")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("entrada_sabado")).ToString("HH:mm:ss"))
                txtHoraEntradaDomingo.Text = IIf(IsDBNull(oSqlDataReader.Item("entrada_domingo")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("entrada_domingo")).ToString("HH:mm:ss"))
                txtHoraSaidaSegunda.Text = IIf(IsDBNull(oSqlDataReader.Item("saida_segunda")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("saida_segunda")).ToString("HH:mm:ss"))
                txtHoraSaidaTerca.Text = IIf(IsDBNull(oSqlDataReader.Item("saida_terca")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("saida_terca")).ToString("HH:mm:ss"))
                txtHoraSaidaQuarta.Text = IIf(IsDBNull(oSqlDataReader.Item("saida_quarta")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("saida_quarta")).ToString("HH:mm:ss"))
                txtHoraSaidaQuinta.Text = IIf(IsDBNull(oSqlDataReader.Item("saida_quinta")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("saida_quinta")).ToString("HH:mm:ss"))
                txtHoraSaidaSexta.Text = IIf(IsDBNull(oSqlDataReader.Item("saida_sexta")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("saida_sexta")).ToString("HH:mm:ss"))
                txtHoraSaidaSabado.Text = IIf(IsDBNull(oSqlDataReader.Item("saida_sabado")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("saida_sabado")).ToString("HH:mm:ss"))
                txtHoraSaidaDomingo.Text = IIf(IsDBNull(oSqlDataReader.Item("saida_domingo")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("saida_domingo")).ToString("HH:mm:ss"))
                txtHoraAlmocoSegundaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_segunda_inicio")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_almoco_segunda_inicio")).ToString("HH:mm:ss"))
                txtHoraAlmocoTercaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_terca_inicio")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_almoco_terca_inicio")).ToString("HH:mm:ss"))
                txtHoraAlmocoQuartaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_quarta_inicio")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_almoco_quarta_inicio")).ToString("HH:mm:ss"))
                txtHoraAlmocoQuintaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_quinta_inicio")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_almoco_quinta_inicio")).ToString("HH:mm:ss"))
                txtHoraAlmocoSextaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_sexta_inicio")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_almoco_sexta_inicio")).ToString("HH:mm:ss"))
                txtHoraAlmocoSabadoInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_sabado_inicio")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_almoco_sabado_inicio")).ToString("HH:mm:ss"))
                txtHoraAlmocoDomingoInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_domingo_inicio")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_almoco_domingo_inicio")).ToString("HH:mm:ss"))
                txtHoraAlmocoSegundaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_segunda_termino")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_almoco_segunda_termino")).ToString("HH:mm:ss"))
                txtHoraAlmocoTercaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_terca_termino")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_almoco_terca_termino")).ToString("HH:mm:ss"))
                txtHoraAlmocoQuartaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_quarta_termino")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_almoco_quarta_termino")).ToString("HH:mm:ss"))
                txtHoraAlmocoQuintaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_quinta_termino")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_almoco_quinta_termino")).ToString("HH:mm:ss"))
                txtHoraAlmocoSextaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_sexta_termino")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_almoco_sexta_termino")).ToString("HH:mm:ss"))
                txtHoraAlmocoSabadoTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_sabado_termino")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_almoco_sabado_termino")).ToString("HH:mm:ss"))
                txtHoraAlmocoDomingoTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_almoco_domingo_termino")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_almoco_domingo_termino")).ToString("HH:mm:ss"))
                txtHoraIntervaloSegundaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_segunda_inicio")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_intervalo_segunda_inicio")).ToString("HH:mm:ss"))
                txtHoraIntervaloTercaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_terca_inicio")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_intervalo_terca_inicio")).ToString("HH:mm:ss"))
                txtHoraIntervaloQuartaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_quarta_inicio")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_intervalo_quarta_inicio")).ToString("HH:mm:ss"))
                txtHoraIntervaloQuintaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_quinta_inicio")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_intervalo_quinta_inicio")).ToString("HH:mm:ss"))
                txtHoraIntervaloSextaInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_sexta_inicio")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_intervalo_sexta_inicio")).ToString("HH:mm:ss"))
                txtHoraIntervaloSabadoInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_sabado_inicio")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_intervalo_sabado_inicio")).ToString("HH:mm:ss"))
                txtHoraIntervaloDomingoInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_domingo_inicio")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_intervalo_domingo_inicio")).ToString("HH:mm:ss"))
                txtHoraIntervaloSegundaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_segunda_termino")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_intervalo_segunda_termino")).ToString("HH:mm:ss"))
                txtHoraIntervaloTercaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_terca_termino")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_intervalo_terca_termino")).ToString("HH:mm:ss"))
                txtHoraIntervaloQuartaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_quarta_termino")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_intervalo_quarta_termino")).ToString("HH:mm:ss"))
                txtHoraIntervaloQuintaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_quinta_termino")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_intervalo_quinta_termino")).ToString("HH:mm:ss"))
                txtHoraIntervaloSextaTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_sexta_termino")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_intervalo_sexta_termino")).ToString("HH:mm:ss"))
                txtHoraIntervaloSabadoTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_sabado_termino")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_intervalo_sabado_termino")).ToString("HH:mm:ss"))
                txtHoraIntervaloDomingoTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("hora_intervalo_domingo_termino")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("hora_intervalo_domingo_termino")).ToString("HH:mm:ss"))
                txtHoraAdicionalNoturnoInicio.Text = IIf(IsDBNull(oSqlDataReader.Item("adicional_inicio")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("adicional_inicio")).ToString("HH:mm:ss"))
                txtHoraAdicionalNoturnoTermino.Text = IIf(IsDBNull(oSqlDataReader.Item("adicional_termino")) = True, "00:00:00", Convert.ToDateTime(oSqlDataReader.Item("adicional_termino")).ToString("HH:mm:ss"))
                cboHoraExtraSegunda.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_segunda")
                txtHoraExtraAposSegunda.Value = oSqlDataReader.Item("hora_extra_apos_segunda")
                cboHoraExtraAposSegunda.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_segunda")
                cboHoraExtraTerca.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_terca")
                txtHoraExtraAposTerca.Value = oSqlDataReader.Item("hora_extra_apos_terca")
                cboHoraExtraAposTerca.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_terca")
                cboHoraExtraQuarta.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_quarta")
                txtHoraExtraAposQuarta.Value = oSqlDataReader.Item("hora_extra_apos_quarta")
                cboHoraExtraAposQuarta.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_quarta")
                cboHoraExtraQuinta.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_quinta")
                txtHoraExtraAposQuinta.Value = oSqlDataReader.Item("hora_extra_apos_quinta")
                cboHoraExtraAposQuinta.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_quinta")
                cboHoraExtraSexta.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_sexta")
                txtHoraExtraAposSexta.Value = oSqlDataReader.Item("hora_extra_apos_sexta")
                cboHoraExtraAposSexta.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_sexta")
                cboHoraExtraSabado.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_sabado")
                txtHoraExtraAposSabado.Value = oSqlDataReader.Item("hora_extra_apos_sabado")
                cboHoraExtraAposSabado.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_sabado")
                cboHoraExtraDomingo.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_domingo")
                txtHoraExtraAposDomingo.Value = oSqlDataReader.Item("hora_extra_apos_domingo")
                cboHoraExtraAposDomingo.SelectedValue = oSqlDataReader.Item("codigo_hora_extra_apos_domingo")


            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaDescricao(ByVal iCodigo As Integer, _
                                    ByVal sDescricao As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaDescricao = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_turno", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaDescricao = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sDescricao As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_turno", oSqlParameter)

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
