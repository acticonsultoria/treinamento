Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports INTERACTI.SQLHelper

Public Class clsUsrCadTurnoProducao

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
    Private iHoraEntradaSegunda As Integer
    Private iHoraEntradaTerca As Integer
    Private iHoraEntradaQuarta As Integer
    Private iHoraEntradaQuinta As Integer
    Private iHoraEntradaSexta As Integer
    Private iHoraEntradaSabado As Integer
    Private iHoraEntradaDomingo As Integer
    Private iMinutoEntradaSegunda As Integer
    Private iMinutoEntradaTerca As Integer
    Private iMinutoEntradaQuarta As Integer
    Private iMinutoEntradaQuinta As Integer
    Private iMinutoEntradaSexta As Integer
    Private iMinutoEntradaSabado As Integer
    Private iMinutoEntradaDomingo As Integer
    Private iHoraSaidaSegunda As Integer
    Private iHoraSaidaTerca As Integer
    Private iHoraSaidaQuarta As Integer
    Private iHoraSaidaQuinta As Integer
    Private iHoraSaidaSexta As Integer
    Private iHoraSaidaSabado As Integer
    Private iHoraSaidaDomingo As Integer
    Private iMinutoSaidaSegunda As Integer
    Private iMinutoSaidaTerca As Integer
    Private iMinutoSaidaQuarta As Integer
    Private iMinutoSaidaQuinta As Integer
    Private iMinutoSaidaSexta As Integer
    Private iMinutoSaidaSabado As Integer
    Private iMinutoSaidaDomingo As Integer
    Private dHoraAlmocoSegunda As Double
    Private dHoraAlmocoTerca As Double
    Private dHoraAlmocoQuarta As Double
    Private dHoraAlmocoQuinta As Double
    Private dHoraAlmocoSexta As Double
    Private dHoraAlmocoSabado As Double
    Private dHoraAlmocoDomingo As Double
    Private iHoraAdicionalNoturnoInicioSegunda As Integer
    Private iHoraAdicionalNoturnoInicioTerca As Integer
    Private iHoraAdicionalNoturnoInicioQuarta As Integer
    Private iHoraAdicionalNoturnoInicioQuinta As Integer
    Private iHoraAdicionalNoturnoInicioSexta As Integer
    Private iHoraAdicionalNoturnoInicioSabado As Integer
    Private iHoraAdicionalNoturnoInicioDomingo As Integer
    Private iMinutoAdicionalNoturnoInicioSegunda As Integer
    Private iMinutoAdicionalNoturnoInicioTerca As Integer
    Private iMinutoAdicionalNoturnoInicioQuarta As Integer
    Private iMinutoAdicionalNoturnoInicioQuinta As Integer
    Private iMinutoAdicionalNoturnoInicioSexta As Integer
    Private iMinutoAdicionalNoturnoInicioSabado As Integer
    Private iMinutoAdicionalNoturnoInicioDomingo As Integer
    Private iHoraAdicionalNoturnoTerminoSegunda As Integer
    Private iHoraAdicionalNoturnoTerminoTerca As Integer
    Private iHoraAdicionalNoturnoTerminoQuarta As Integer
    Private iHoraAdicionalNoturnoTerminoQuinta As Integer
    Private iHoraAdicionalNoturnoTerminoSexta As Integer
    Private iHoraAdicionalNoturnoTerminoSabado As Integer
    Private iHoraAdicionalNoturnoTerminoDomingo As Integer
    Private iMinutoAdicionalNoturnoTerminoSegunda As Integer
    Private iMinutoAdicionalNoturnoTerminoTerca As Integer
    Private iMinutoAdicionalNoturnoTerminoQuarta As Integer
    Private iMinutoAdicionalNoturnoTerminoQuinta As Integer
    Private iMinutoAdicionalNoturnoTerminoSexta As Integer
    Private iMinutoAdicionalNoturnoTerminoSabado As Integer
    Private iMinutoAdicionalNoturnoTerminoDomingo As Integer
    Private dHoraExtraPreTurnoSegunda As Double
    Private dHoraExtraPreTurnoTerca As Double
    Private dHoraExtraPreTurnoQuarta As Double
    Private dHoraExtraPreTurnoQuinta As Double
    Private dHoraExtraPreTurnoSexta As Double
    Private dHoraExtraPreTurnoSabado As Double
    Private dHoraExtraPreTurnoDomingo As Double
    Private dHoraExtraPosTurnoSegunda As Double
    Private dHoraExtraPosTurnoTerca As Double
    Private dHoraExtraPosTurnoQuarta As Double
    Private dHoraExtraPosTurnoQuinta As Double
    Private dHoraExtraPosTurnoSexta As Double
    Private dHoraExtraPosTurnoSabado As Double
    Private dHoraExtraPosTurnoDomingo As Double

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


    Public Property HoraEntradaSegunda() As Integer
        Get
            Return iHoraEntradaSegunda
        End Get
        Set(ByVal value As Integer)
            iHoraEntradaSegunda = value
        End Set
    End Property

    Public Property HoraEntradaTerca() As Integer
        Get
            Return iHoraEntradaTerca
        End Get
        Set(ByVal value As Integer)
            iHoraEntradaTerca = value
        End Set
    End Property

    Public Property HoraEntradaQuarta() As Integer
        Get
            Return iHoraEntradaQuarta
        End Get
        Set(ByVal value As Integer)
            iHoraEntradaQuarta = value
        End Set
    End Property

    Public Property HoraEntradaQuinta() As Integer
        Get
            Return iHoraEntradaQuinta
        End Get
        Set(ByVal value As Integer)
            iHoraEntradaQuinta = value
        End Set
    End Property

    Public Property HoraEntradaSexta() As Integer
        Get
            Return iHoraEntradaSexta
        End Get
        Set(ByVal value As Integer)
            iHoraEntradaSexta = value
        End Set
    End Property

    Public Property HoraEntradaSabado() As Integer
        Get
            Return iHoraEntradaSabado
        End Get
        Set(ByVal value As Integer)
            iHoraEntradaSabado = value
        End Set
    End Property

    Public Property HoraEntradaDomingo() As Integer
        Get
            Return iHoraEntradaDomingo
        End Get
        Set(ByVal value As Integer)
            iHoraEntradaDomingo = value
        End Set
    End Property

    Public Property MinutoEntradaSegunda() As Integer
        Get
            Return iMinutoEntradaSegunda
        End Get
        Set(ByVal value As Integer)
            iMinutoEntradaSegunda = value
        End Set
    End Property

    Public Property MinutoEntradaTerca() As Integer
        Get
            Return iMinutoEntradaTerca
        End Get
        Set(ByVal value As Integer)
            iMinutoEntradaTerca = value
        End Set
    End Property

    Public Property MinutoEntradaQuarta() As Integer
        Get
            Return iMinutoEntradaQuarta
        End Get
        Set(ByVal value As Integer)
            iMinutoEntradaQuarta = value
        End Set
    End Property

    Public Property MinutoEntradaQuinta() As Integer
        Get
            Return iMinutoEntradaQuinta
        End Get
        Set(ByVal value As Integer)
            iMinutoEntradaQuinta = value
        End Set
    End Property

    Public Property MinutoEntradaSexta() As Integer
        Get
            Return iMinutoEntradaSexta
        End Get
        Set(ByVal value As Integer)
            iMinutoEntradaSexta = value
        End Set
    End Property

    Public Property MinutoEntradaSabado() As Integer
        Get
            Return iMinutoEntradaSabado
        End Get
        Set(ByVal value As Integer)
            iMinutoEntradaSabado = value
        End Set
    End Property

    Public Property MinutoEntradaDomingo() As Integer
        Get
            Return iMinutoEntradaDomingo
        End Get
        Set(ByVal value As Integer)
            iMinutoEntradaDomingo = value
        End Set
    End Property

    Public Property HoraSaidaSegunda() As Integer
        Get
            Return iHoraSaidaSegunda
        End Get
        Set(ByVal value As Integer)
            iHoraSaidaSegunda = value
        End Set
    End Property

    Public Property HoraSaidaTerca() As Integer
        Get
            Return iHoraSaidaTerca
        End Get
        Set(ByVal value As Integer)
            iHoraSaidaTerca = value
        End Set
    End Property

    Public Property HoraSaidaQuarta() As Integer
        Get
            Return iHoraSaidaQuarta
        End Get
        Set(ByVal value As Integer)
            iHoraSaidaQuarta = value
        End Set
    End Property

    Public Property HoraSaidaQuinta() As Integer
        Get
            Return iHoraSaidaQuinta
        End Get
        Set(ByVal value As Integer)
            iHoraSaidaQuinta = value
        End Set
    End Property

    Public Property HoraSaidaSexta() As Integer
        Get
            Return iHoraSaidaSexta
        End Get
        Set(ByVal value As Integer)
            iHoraSaidaSexta = value
        End Set
    End Property

    Public Property HoraSaidaSabado() As Integer
        Get
            Return iHoraSaidaSabado
        End Get
        Set(ByVal value As Integer)
            iHoraSaidaSabado = value
        End Set
    End Property

    Public Property HoraSaidaDomingo() As Integer
        Get
            Return iHoraSaidaDomingo
        End Get
        Set(ByVal value As Integer)
            iHoraSaidaDomingo = value
        End Set
    End Property

    Public Property MinutoSaidaSegunda() As Integer
        Get
            Return iMinutoSaidaSegunda
        End Get
        Set(ByVal value As Integer)
            iMinutoSaidaSegunda = value
        End Set
    End Property

    Public Property MinutoSaidaTerca() As Integer
        Get
            Return iMinutoSaidaTerca
        End Get
        Set(ByVal value As Integer)
            iMinutoSaidaTerca = value
        End Set
    End Property

    Public Property MinutoSaidaQuarta() As Integer
        Get
            Return iMinutoSaidaQuarta
        End Get
        Set(ByVal value As Integer)
            iMinutoSaidaQuarta = value
        End Set
    End Property

    Public Property MinutoSaidaQuinta() As Integer
        Get
            Return iMinutoSaidaQuinta
        End Get
        Set(ByVal value As Integer)
            iMinutoSaidaQuinta = value
        End Set
    End Property

    Public Property MinutoSaidaSexta() As Integer
        Get
            Return iMinutoSaidaSexta
        End Get
        Set(ByVal value As Integer)
            iMinutoSaidaSexta = value
        End Set
    End Property

    Public Property MinutoSaidaSabado() As Integer
        Get
            Return iMinutoSaidaSabado
        End Get
        Set(ByVal value As Integer)
            iMinutoSaidaSabado = value
        End Set
    End Property

    Public Property MinutoSaidaDomingo() As Integer
        Get
            Return iMinutoSaidaDomingo
        End Get
        Set(ByVal value As Integer)
            iMinutoSaidaDomingo = value
        End Set
    End Property

    Public Property HoraAlmocoSegunda() As Double
        Get
            Return dHoraAlmocoSegunda
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoSegunda = value
        End Set
    End Property

    Public Property HoraAlmocoTerca() As Double
        Get
            Return dHoraAlmocoTerca
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoTerca = value
        End Set
    End Property

    Public Property HoraAlmocoQuarta() As Double
        Get
            Return dHoraAlmocoQuarta
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoQuarta = value
        End Set
    End Property

    Public Property HoraAlmocoQuinta() As Double
        Get
            Return dHoraAlmocoQuinta
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoQuinta = value
        End Set
    End Property

    Public Property HoraAlmocoSexta() As Double
        Get
            Return dHoraAlmocoSexta
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoSexta = value
        End Set
    End Property

    Public Property HoraAlmocoSabado() As Double
        Get
            Return dHoraAlmocoSabado
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoSabado = value
        End Set
    End Property

    Public Property HoraAlmocoDomingo() As Double
        Get
            Return dHoraAlmocoDomingo
        End Get
        Set(ByVal value As Double)
            dHoraAlmocoDomingo = value
        End Set
    End Property

    Public Property HoraAdicionalNoturnoInicioSegunda() As Integer
        Get
            Return iHoraAdicionalNoturnoInicioSegunda
        End Get
        Set(ByVal value As Integer)
            iHoraAdicionalNoturnoInicioSegunda = value
        End Set
    End Property

    Public Property HoraAdicionalNoturnoInicioTerca() As Integer
        Get
            Return iHoraAdicionalNoturnoInicioTerca
        End Get
        Set(ByVal value As Integer)
            iHoraAdicionalNoturnoInicioTerca = value
        End Set
    End Property

    Public Property HoraAdicionalNoturnoInicioQuarta() As Integer
        Get
            Return iHoraAdicionalNoturnoInicioQuarta
        End Get
        Set(ByVal value As Integer)
            iHoraAdicionalNoturnoInicioQuarta = value
        End Set
    End Property

    Public Property HoraAdicionalNoturnoInicioQuinta() As Integer
        Get
            Return iHoraAdicionalNoturnoInicioQuinta
        End Get
        Set(ByVal value As Integer)
            iHoraAdicionalNoturnoInicioQuinta = value
        End Set
    End Property

    Public Property HoraAdicionalNoturnoInicioSexta() As Integer
        Get
            Return iHoraAdicionalNoturnoInicioSexta
        End Get
        Set(ByVal value As Integer)
            iHoraAdicionalNoturnoInicioSexta = value
        End Set
    End Property

    Public Property HoraAdicionalNoturnoInicioSabado() As Integer
        Get
            Return iHoraAdicionalNoturnoInicioSabado
        End Get
        Set(ByVal value As Integer)
            iHoraAdicionalNoturnoInicioSabado = value
        End Set
    End Property

    Public Property HoraAdicionalNoturnoInicioDomingo() As Integer
        Get
            Return iHoraAdicionalNoturnoInicioDomingo
        End Get
        Set(ByVal value As Integer)
            iHoraAdicionalNoturnoInicioDomingo = value
        End Set
    End Property

    Public Property MinutoAdicionalNoturnoInicioSegunda() As Integer
        Get
            Return iMinutoAdicionalNoturnoInicioSegunda
        End Get
        Set(ByVal value As Integer)
            iMinutoAdicionalNoturnoInicioSegunda = value
        End Set
    End Property

    Public Property MinutoAdicionalNoturnoInicioTerca() As Integer
        Get
            Return iMinutoAdicionalNoturnoInicioTerca
        End Get
        Set(ByVal value As Integer)
            iMinutoAdicionalNoturnoInicioTerca = value
        End Set
    End Property

    Public Property MinutoAdicionalNoturnoInicioQuarta() As Integer
        Get
            Return iMinutoAdicionalNoturnoInicioQuarta
        End Get
        Set(ByVal value As Integer)
            iMinutoAdicionalNoturnoInicioQuarta = value
        End Set
    End Property

    Public Property MinutoAdicionalNoturnoInicioQuinta() As Integer
        Get
            Return iMinutoAdicionalNoturnoInicioQuinta
        End Get
        Set(ByVal value As Integer)
            iMinutoAdicionalNoturnoInicioQuinta = value
        End Set
    End Property

    Public Property MinutoAdicionalNoturnoInicioSexta() As Integer
        Get
            Return iMinutoAdicionalNoturnoInicioSexta
        End Get
        Set(ByVal value As Integer)
            iMinutoAdicionalNoturnoInicioSexta = value
        End Set
    End Property

    Public Property MinutoAdicionalNoturnoInicioSabado() As Integer
        Get
            Return iMinutoAdicionalNoturnoInicioSabado
        End Get
        Set(ByVal value As Integer)
            iMinutoAdicionalNoturnoInicioSabado = value
        End Set
    End Property

    Public Property MinutoAdicionalNoturnoInicioDomingo() As Integer
        Get
            Return iMinutoAdicionalNoturnoInicioDomingo
        End Get
        Set(ByVal value As Integer)
            iMinutoAdicionalNoturnoInicioDomingo = value
        End Set
    End Property

    Public Property HoraAdicionalNoturnoTerminoSegunda() As Integer
        Get
            Return iHoraAdicionalNoturnoTerminoSegunda
        End Get
        Set(ByVal value As Integer)
            iHoraAdicionalNoturnoTerminoSegunda = value
        End Set
    End Property

    Public Property HoraAdicionalNoturnoTerminoTerca() As Integer
        Get
            Return iHoraAdicionalNoturnoTerminoTerca
        End Get
        Set(ByVal value As Integer)
            iHoraAdicionalNoturnoTerminoTerca = value
        End Set
    End Property

    Public Property HoraAdicionalNoturnoTerminoQuarta() As Integer
        Get
            Return iHoraAdicionalNoturnoTerminoQuarta
        End Get
        Set(ByVal value As Integer)
            iHoraAdicionalNoturnoTerminoQuarta = value
        End Set
    End Property

    Public Property HoraAdicionalNoturnoTerminoQuinta() As Integer
        Get
            Return iHoraAdicionalNoturnoTerminoQuinta
        End Get
        Set(ByVal value As Integer)
            iHoraAdicionalNoturnoTerminoQuinta = value
        End Set
    End Property

    Public Property HoraAdicionalNoturnoTerminoSexta() As Integer
        Get
            Return iHoraAdicionalNoturnoTerminoSexta
        End Get
        Set(ByVal value As Integer)
            iHoraAdicionalNoturnoTerminoSexta = value
        End Set
    End Property

    Public Property HoraAdicionalNoturnoTerminoSabado() As Integer
        Get
            Return iHoraAdicionalNoturnoTerminoSabado
        End Get
        Set(ByVal value As Integer)
            iHoraAdicionalNoturnoTerminoSabado = value
        End Set
    End Property

    Public Property HoraAdicionalNoturnoTerminoDomingo() As Integer
        Get
            Return iHoraAdicionalNoturnoTerminoDomingo
        End Get
        Set(ByVal value As Integer)
            iHoraAdicionalNoturnoTerminoDomingo = value
        End Set
    End Property

    Public Property MinutoAdicionalNoturnoTerminoSegunda() As Integer
        Get
            Return iMinutoAdicionalNoturnoTerminoSegunda
        End Get
        Set(ByVal value As Integer)
            iMinutoAdicionalNoturnoTerminoSegunda = value
        End Set
    End Property

    Public Property MinutoAdicionalNoturnoTerminoTerca() As Integer
        Get
            Return iMinutoAdicionalNoturnoTerminoTerca
        End Get
        Set(ByVal value As Integer)
            iMinutoAdicionalNoturnoTerminoTerca = value
        End Set
    End Property

    Public Property MinutoAdicionalNoturnoTerminoQuarta() As Integer
        Get
            Return iMinutoAdicionalNoturnoTerminoQuarta
        End Get
        Set(ByVal value As Integer)
            iMinutoAdicionalNoturnoTerminoQuarta = value
        End Set
    End Property

    Public Property MinutoAdicionalNoturnoTerminoQuinta() As Integer
        Get
            Return iMinutoAdicionalNoturnoTerminoQuinta
        End Get
        Set(ByVal value As Integer)
            iMinutoAdicionalNoturnoTerminoQuinta = value
        End Set
    End Property

    Public Property MinutoAdicionalNoturnoTerminoSexta() As Integer
        Get
            Return iMinutoAdicionalNoturnoTerminoSexta
        End Get
        Set(ByVal value As Integer)
            iMinutoAdicionalNoturnoTerminoSexta = value
        End Set
    End Property

    Public Property MinutoAdicionalNoturnoTerminoSabado() As Integer
        Get
            Return iMinutoAdicionalNoturnoTerminoSabado
        End Get
        Set(ByVal value As Integer)
            iMinutoAdicionalNoturnoTerminoSabado = value
        End Set
    End Property

    Public Property MinutoAdicionalNoturnoTerminoDomingo() As Integer
        Get
            Return iMinutoAdicionalNoturnoTerminoDomingo
        End Get
        Set(ByVal value As Integer)
            iMinutoAdicionalNoturnoTerminoDomingo = value
        End Set
    End Property

    Public Property HoraExtraPreTurnoSegunda() As Double
        Get
            Return dHoraExtraPreTurnoSegunda
        End Get
        Set(ByVal value As Double)
            dHoraExtraPreTurnoSegunda = value
        End Set
    End Property

    Public Property HoraExtraPreTurnoTerca() As Double
        Get
            Return dHoraExtraPreTurnoTerca
        End Get
        Set(ByVal value As Double)
            dHoraExtraPreTurnoTerca = value
        End Set
    End Property

    Public Property HoraExtraPreTurnoQuarta() As Double
        Get
            Return dHoraExtraPreTurnoQuarta
        End Get
        Set(ByVal value As Double)
            dHoraExtraPreTurnoQuarta = value
        End Set
    End Property

    Public Property HoraExtraPreTurnoQuinta() As Double
        Get
            Return dHoraExtraPreTurnoQuinta
        End Get
        Set(ByVal value As Double)
            dHoraExtraPreTurnoQuinta = value
        End Set
    End Property

    Public Property HoraExtraPreTurnoSexta() As Double
        Get
            Return dHoraExtraPreTurnoSexta
        End Get
        Set(ByVal value As Double)
            dHoraExtraPreTurnoSexta = value
        End Set
    End Property

    Public Property HoraExtraPreTurnoSabado() As Double
        Get
            Return dHoraExtraPreTurnoSabado
        End Get
        Set(ByVal value As Double)
            dHoraExtraPreTurnoSabado = value
        End Set
    End Property

    Public Property HoraExtraPreTurnoDomingo() As Double
        Get
            Return dHoraExtraPreTurnoDomingo
        End Get
        Set(ByVal value As Double)
            dHoraExtraPreTurnoDomingo = value
        End Set
    End Property

    Public Property HoraExtraPosTurnoSegunda() As Double
        Get
            Return dHoraExtraPosTurnoSegunda
        End Get
        Set(ByVal value As Double)
            dHoraExtraPosTurnoSegunda = value
        End Set
    End Property

    Public Property HoraExtraPosTurnoTerca() As Double
        Get
            Return dHoraExtraPosTurnoTerca
        End Get
        Set(ByVal value As Double)
            dHoraExtraPosTurnoTerca = value
        End Set
    End Property

    Public Property HoraExtraPosTurnoQuarta() As Double
        Get
            Return dHoraExtraPosTurnoQuarta
        End Get
        Set(ByVal value As Double)
            dHoraExtraPosTurnoQuarta = value
        End Set
    End Property

    Public Property HoraExtraPosTurnoQuinta() As Double
        Get
            Return dHoraExtraPosTurnoQuinta
        End Get
        Set(ByVal value As Double)
            dHoraExtraPosTurnoQuinta = value
        End Set
    End Property

    Public Property HoraExtraPosTurnoSexta() As Double
        Get
            Return dHoraExtraPosTurnoSexta
        End Get
        Set(ByVal value As Double)
            dHoraExtraPosTurnoSexta = value
        End Set
    End Property

    Public Property HoraExtraPosTurnoSabado() As Double
        Get
            Return dHoraExtraPosTurnoSabado
        End Get
        Set(ByVal value As Double)
            dHoraExtraPosTurnoSabado = value
        End Set
    End Property

    Public Property HoraExtraPosTurnoDomingo() As Double
        Get
            Return dHoraExtraPosTurnoDomingo
        End Get
        Set(ByVal value As Double)
            dHoraExtraPosTurnoDomingo = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(85) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros -  Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSegunda : i += 1

            'Seta Parametros -  Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bTerca : i += 1

            'Seta Parametros -  Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bQuarta : i += 1

            'Seta Parametros -  Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bQuinta : i += 1

            'Seta Parametros -  Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSexta : i += 1

            'Seta Parametros -  Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSabado : i += 1

            'Seta Parametros -  Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bDomingo : i += 1

            'Seta Parametros - Hora Entrada Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraEntradaSegunda : i += 1

            'Seta Parametros - Hora Entrada Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraEntradaTerca : i += 1

            'Seta Parametros - Hora Entrada Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraEntradaQuarta : i += 1

            'Seta Parametros - Hora Entrada Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraEntradaQuinta : i += 1

            'Seta Parametros - Hora Entrada Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraEntradaSexta : i += 1

            'Seta Parametros - Hora Entrada Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraEntradaSabado : i += 1

            'Seta Parametros - Hora Entrada Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraEntradaDomingo : i += 1

            'Seta Parametros - Minuto Entrada Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoEntradaSegunda : i += 1

            'Seta Parametros - Minuto Entrada Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoEntradaTerca : i += 1

            'Seta Parametros - Minuto Entrada Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoEntradaQuarta : i += 1

            'Seta Parametros - Minuto Entrada Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoEntradaQuinta : i += 1

            'Seta Parametros - Minuto Entrada Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoEntradaSexta : i += 1

            'Seta Parametros - Minuto Entrada Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoEntradaSabado : i += 1

            'Seta Parametros - Minuto Entrada Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoEntradaDomingo : i += 1

            'Seta Parametros - Hora Saida Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraSaidaSegunda : i += 1

            'Seta Parametros - Hora Saida Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraSaidaTerca : i += 1

            'Seta Parametros - Hora Saida Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraSaidaQuarta : i += 1

            'Seta Parametros - Hora Saida Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraSaidaQuinta : i += 1

            'Seta Parametros - Hora Saida Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraSaidaSexta : i += 1

            'Seta Parametros - Hora Saida Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraSaidaSabado : i += 1

            'Seta Parametros - Hora Saida Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraSaidaDomingo : i += 1

            'Seta Parametros - Minuto Saida Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoSaidaSegunda : i += 1

            'Seta Parametros - Minuto Saida Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoSaidaTerca : i += 1

            'Seta Parametros - Minuto Saida Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoSaidaQuarta : i += 1

            'Seta Parametros - Minuto Saida Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoSaidaQuinta : i += 1

            'Seta Parametros - Minuto Saida Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoSaidaSexta : i += 1

            'Seta Parametros - Minuto Saida Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoSaidaSabado : i += 1

            'Seta Parametros - Minuto Saida Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoSaidaDomingo : i += 1

            'Seta Parametros - Hora Almoço Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSegunda : i += 1

            'Seta Parametros - Hora Almoço Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoTerca : i += 1

            'Seta Parametros - Hora Almoço Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuarta : i += 1

            'Seta Parametros - Hora Almoço Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuinta : i += 1

            'Seta Parametros - Hora Almoço Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSexta : i += 1

            'Seta Parametros - Hora Almoço Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSabado : i += 1

            'Seta Parametros - Hora Almoço Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoDomingo : i += 1

            'Seta Parametros - Hora Adicional Noturno Inicio Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_adicional_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoInicioSegunda : i += 1

            'Seta Parametros - Hora Adicional Noturno Inicio Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_adicional_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoInicioTerca : i += 1

            'Seta Parametros - Hora Adicional Noturno Inicio Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_adicional_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoInicioQuarta : i += 1

            'Seta Parametros - Hora Adicional Noturno Inicio Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_adicional_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoInicioQuinta : i += 1

            'Seta Parametros - Hora Adicional Noturno Inicio Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_adicional_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoInicioSexta : i += 1

            'Seta Parametros - Hora Adicional Noturno Inicio Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_adicional_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoInicioSabado : i += 1

            'Seta Parametros - Hora Adicional Noturno Inicio Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_adicional_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoInicioDomingo : i += 1

            'Seta Parametros - Minuto Adicional Noturno Inicio Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_adicional_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoInicioSegunda : i += 1

            'Seta Parametros - Minuto Adicional Noturno Inicio Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_adicional_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoInicioTerca : i += 1

            'Seta Parametros - Minuto Adicional Noturno Inicio Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_adicional_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoInicioQuarta : i += 1

            'Seta Parametros - Minuto Adicional Noturno Inicio Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_adicional_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoInicioQuinta : i += 1

            'Seta Parametros - Minuto Adicional Noturno Inicio Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_adicional_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoInicioSexta : i += 1

            'Seta Parametros - Minuto Adicional Noturno Inicio Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_adicional_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoInicioSabado : i += 1

            'Seta Parametros - Minuto Adicional Noturno Inicio Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_adicional_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoInicioDomingo : i += 1

            'Seta Parametros - Hora Adicional Noturno Termino Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_adicional_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoTerminoSegunda : i += 1

            'Seta Parametros - Hora Adicional Noturno Termino Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_adicional_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoTerminoTerca : i += 1

            'Seta Parametros - Hora Adicional Noturno Termino Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_adicional_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoTerminoQuarta : i += 1

            'Seta Parametros - Hora Adicional Noturno Termino Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_adicional_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoTerminoQuinta : i += 1

            'Seta Parametros - Hora Adicional Noturno Termino Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_adicional_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoTerminoSexta : i += 1

            'Seta Parametros - Hora Adicional Noturno Termino Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_adicional_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoTerminoSabado : i += 1

            'Seta Parametros - Hora Adicional Noturno Termino Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_adicional_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoTerminoDomingo : i += 1

            'Seta Parametros - Minuto Adicional Noturno Termino Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_adicional_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoTerminoSegunda : i += 1

            'Seta Parametros - Minuto Adicional Noturno Termino Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_adicional_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoTerminoTerca : i += 1

            'Seta Parametros - Minuto Adicional Noturno Termino Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_adicional_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoTerminoQuarta : i += 1

            'Seta Parametros - Minuto Adicional Noturno Termino Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_adicional_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoTerminoQuinta : i += 1

            'Seta Parametros - Minuto Adicional Noturno Termino Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_adicional_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoTerminoSexta : i += 1

            'Seta Parametros - Minuto Adicional Noturno Termino Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_adicional_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoTerminoSabado : i += 1

            'Seta Parametros - Minuto Adicional Noturno Termino Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_adicional_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoTerminoDomingo : i += 1

            'Seta Parametros - Hora Extra Pré-Turno Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pre_turno_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPreTurnoSegunda : i += 1

            'Seta Parametros - Hora Extra Pré-Turno Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pre_turno_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPreTurnoTerca : i += 1

            'Seta Parametros - Hora Extra Pré-Turno Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pre_turno_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPreTurnoQuarta : i += 1

            'Seta Parametros - Hora Extra Pré-Turno Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pre_turno_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPreTurnoQuinta : i += 1

            'Seta Parametros - Hora Extra Pré-Turno Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pre_turno_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPreTurnoSexta : i += 1

            'Seta Parametros - Hora Extra Pré-Turno Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pre_turno_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPreTurnoSabado : i += 1

            'Seta Parametros - Hora Extra Pré-Turno Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pre_turno_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPreTurnoDomingo : i += 1

            'Seta Parametros - Hora Extra Pós-Turno Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pos_turno_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPosTurnoSegunda : i += 1

            'Seta Parametros - Hora Extra Pós-Turno Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pos_turno_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPosTurnoTerca : i += 1

            'Seta Parametros - Hora Extra Pós-Turno Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pos_turno_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPosTurnoQuarta : i += 1

            'Seta Parametros - Hora Extra Pós-Turno Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pos_turno_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPosTurnoQuinta : i += 1

            'Seta Parametros - Hora Extra Pós-Turno Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pos_turno_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPosTurnoSexta : i += 1

            'Seta Parametros - Hora Extra Pós-Turno Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pos_turno_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPosTurnoSabado : i += 1

            'Seta Parametros - Hora Extra Pós-Turno Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pos_turno_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPosTurnoDomingo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_turno_producao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(86) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros -  Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSegunda : i += 1

            'Seta Parametros -  Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bTerca : i += 1

            'Seta Parametros -  Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bQuarta : i += 1

            'Seta Parametros -  Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bQuinta : i += 1

            'Seta Parametros -  Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSexta : i += 1

            'Seta Parametros -  Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bSabado : i += 1

            'Seta Parametros -  Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bDomingo : i += 1

            'Seta Parametros - Hora Entrada Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraEntradaSegunda : i += 1

            'Seta Parametros - Hora Entrada Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraEntradaTerca : i += 1

            'Seta Parametros - Hora Entrada Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraEntradaQuarta : i += 1

            'Seta Parametros - Hora Entrada Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraEntradaQuinta : i += 1

            'Seta Parametros - Hora Entrada Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraEntradaSexta : i += 1

            'Seta Parametros - Hora Entrada Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraEntradaSabado : i += 1

            'Seta Parametros - Hora Entrada Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraEntradaDomingo : i += 1

            'Seta Parametros - Minuto Entrada Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoEntradaSegunda : i += 1

            'Seta Parametros - Minuto Entrada Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoEntradaTerca : i += 1

            'Seta Parametros - Minuto Entrada Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoEntradaQuarta : i += 1

            'Seta Parametros - Minuto Entrada Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoEntradaQuinta : i += 1

            'Seta Parametros - Minuto Entrada Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoEntradaSexta : i += 1

            'Seta Parametros - Minuto Entrada Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoEntradaSabado : i += 1

            'Seta Parametros - Minuto Entrada Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoEntradaDomingo : i += 1

            'Seta Parametros - Hora Saida Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraSaidaSegunda : i += 1

            'Seta Parametros - Hora Saida Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraSaidaTerca : i += 1

            'Seta Parametros - Hora Saida Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraSaidaQuarta : i += 1

            'Seta Parametros - Hora Saida Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraSaidaQuinta : i += 1

            'Seta Parametros - Hora Saida Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraSaidaSexta : i += 1

            'Seta Parametros - Hora Saida Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraSaidaSabado : i += 1

            'Seta Parametros - Hora Saida Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraSaidaDomingo : i += 1

            'Seta Parametros - Minuto Saida Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoSaidaSegunda : i += 1

            'Seta Parametros - Minuto Saida Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoSaidaTerca : i += 1

            'Seta Parametros - Minuto Saida Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoSaidaQuarta : i += 1

            'Seta Parametros - Minuto Saida Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoSaidaQuinta : i += 1

            'Seta Parametros - Minuto Saida Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoSaidaSexta : i += 1

            'Seta Parametros - Minuto Saida Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoSaidaSabado : i += 1

            'Seta Parametros - Minuto Saida Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoSaidaDomingo : i += 1

            'Seta Parametros - Hora Almoço Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSegunda : i += 1

            'Seta Parametros - Hora Almoço Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoTerca : i += 1

            'Seta Parametros - Hora Almoço Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuarta : i += 1

            'Seta Parametros - Hora Almoço Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoQuinta : i += 1

            'Seta Parametros - Hora Almoço Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSexta : i += 1

            'Seta Parametros - Hora Almoço Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoSabado : i += 1

            'Seta Parametros - Hora Almoço Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_almoco_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraAlmocoDomingo : i += 1

            'Seta Parametros - Hora Adicional Noturno Inicio Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_adicional_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoInicioSegunda : i += 1

            'Seta Parametros - Hora Adicional Noturno Inicio Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_adicional_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoInicioTerca : i += 1

            'Seta Parametros - Hora Adicional Noturno Inicio Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_adicional_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoInicioQuarta : i += 1

            'Seta Parametros - Hora Adicional Noturno Inicio Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_adicional_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoInicioQuinta : i += 1

            'Seta Parametros - Hora Adicional Noturno Inicio Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_adicional_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoInicioSexta : i += 1

            'Seta Parametros - Hora Adicional Noturno Inicio Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_adicional_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoInicioSabado : i += 1

            'Seta Parametros - Hora Adicional Noturno Inicio Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_entrada_adicional_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoInicioDomingo : i += 1

            'Seta Parametros - Minuto Adicional Noturno Inicio Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_adicional_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoInicioSegunda : i += 1

            'Seta Parametros - Minuto Adicional Noturno Inicio Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_adicional_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoInicioTerca : i += 1

            'Seta Parametros - Minuto Adicional Noturno Inicio Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_adicional_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoInicioQuarta : i += 1

            'Seta Parametros - Minuto Adicional Noturno Inicio Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_adicional_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoInicioQuinta : i += 1

            'Seta Parametros - Minuto Adicional Noturno Inicio Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_adicional_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoInicioSexta : i += 1

            'Seta Parametros - Minuto Adicional Noturno Inicio Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_adicional_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoInicioSabado : i += 1

            'Seta Parametros - Minuto Adicional Noturno Inicio Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_entrada_adicional_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoInicioDomingo : i += 1

            'Seta Parametros - Hora Adicional Noturno Termino Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_adicional_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoTerminoSegunda : i += 1

            'Seta Parametros - Hora Adicional Noturno Termino Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_adicional_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoTerminoTerca : i += 1

            'Seta Parametros - Hora Adicional Noturno Termino Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_adicional_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoTerminoQuarta : i += 1

            'Seta Parametros - Hora Adicional Noturno Termino Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_adicional_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoTerminoQuinta : i += 1

            'Seta Parametros - Hora Adicional Noturno Termino Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_adicional_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoTerminoSexta : i += 1

            'Seta Parametros - Hora Adicional Noturno Termino Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_adicional_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoTerminoSabado : i += 1

            'Seta Parametros - Hora Adicional Noturno Termino Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_saida_adicional_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iHoraAdicionalNoturnoTerminoDomingo : i += 1

            'Seta Parametros - Minuto Adicional Noturno Termino Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_adicional_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoTerminoSegunda : i += 1

            'Seta Parametros - Minuto Adicional Noturno Termino Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_adicional_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoTerminoTerca : i += 1

            'Seta Parametros - Minuto Adicional Noturno Termino Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_adicional_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoTerminoQuarta : i += 1

            'Seta Parametros - Minuto Adicional Noturno Termino Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_adicional_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoTerminoQuinta : i += 1

            'Seta Parametros - Minuto Adicional Noturno Termino Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_adicional_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoTerminoSexta : i += 1

            'Seta Parametros - Minuto Adicional Noturno Termino Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_adicional_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoTerminoSabado : i += 1

            'Seta Parametros - Minuto Adicional Noturno Termino Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "minuto_saida_adicional_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMinutoAdicionalNoturnoTerminoDomingo : i += 1

            'Seta Parametros - Hora Extra Pré-Turno Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pre_turno_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPreTurnoSegunda : i += 1

            'Seta Parametros - Hora Extra Pré-Turno Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pre_turno_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPreTurnoTerca : i += 1

            'Seta Parametros - Hora Extra Pré-Turno Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pre_turno_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPreTurnoQuarta : i += 1

            'Seta Parametros - Hora Extra Pré-Turno Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pre_turno_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPreTurnoQuinta : i += 1

            'Seta Parametros - Hora Extra Pré-Turno Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pre_turno_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPreTurnoSexta : i += 1

            'Seta Parametros - Hora Extra Pré-Turno Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pre_turno_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPreTurnoSabado : i += 1

            'Seta Parametros - Hora Extra Pré-Turno Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pre_turno_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPreTurnoDomingo : i += 1

            'Seta Parametros - Hora Extra Pós-Turno Segunda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pos_turno_segunda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPosTurnoSegunda : i += 1

            'Seta Parametros - Hora Extra Pós-Turno Terça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pos_turno_terca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPosTurnoTerca : i += 1

            'Seta Parametros - Hora Extra Pós-Turno Quarta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pos_turno_quarta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPosTurnoQuarta : i += 1

            'Seta Parametros - Hora Extra Pós-Turno Quinta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pos_turno_quinta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPosTurnoQuinta : i += 1

            'Seta Parametros - Hora Extra Pós-Turno Sexta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pos_turno_sexta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPosTurnoSexta : i += 1

            'Seta Parametros - Hora Extra Pós-Turno Sabado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pos_turno_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPosTurnoSabado : i += 1

            'Seta Parametros - Hora Extra Pós-Turno Domingo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_extra_pos_turno_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dHoraExtraPosTurnoDomingo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_turno_producao", oSqlParameter)

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_turno_producao", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDados(ByVal iCodigo As Integer, _
                         ByVal txtDescricao As MaskedEditBox, _
                         ByVal chkSegunda As UICheckBox, _
                         ByVal chkTerca As UICheckBox, _
                         ByVal chkQuarta As UICheckBox, _
                         ByVal chkQuinta As UICheckBox, _
                         ByVal chkSexta As UICheckBox, _
                         ByVal chkSabado As UICheckBox, _
                         ByVal chkDomingo As UICheckBox, _
                         ByVal txtHoraEntradaSegunda As NumericEditBox, _
                         ByVal txtHoraEntradaTerca As NumericEditBox, _
                         ByVal txtHoraEntradaQuarta As NumericEditBox, _
                         ByVal txtHoraEntradaQuinta As NumericEditBox, _
                         ByVal txtHoraEntradaSexta As NumericEditBox, _
                         ByVal txtHoraEntradaSabado As NumericEditBox, _
                         ByVal txtHoraEntradaDomingo As NumericEditBox, _
                         ByVal txtMinutoEntradaSegunda As NumericEditBox, _
                         ByVal txtMinutoEntradaTerca As NumericEditBox, _
                         ByVal txtMinutoEntradaQuarta As NumericEditBox, _
                         ByVal txtMinutoEntradaQuinta As NumericEditBox, _
                         ByVal txtMinutoEntradaSexta As NumericEditBox, _
                         ByVal txtMinutoEntradaSabado As NumericEditBox, _
                         ByVal txtMinutoEntradaDomingo As NumericEditBox, _
                         ByVal txtHoraSaidaSegunda As NumericEditBox, _
                         ByVal txtHoraSaidaTerca As NumericEditBox, _
                         ByVal txtHoraSaidaQuarta As NumericEditBox, _
                         ByVal txtHoraSaidaQuinta As NumericEditBox, _
                         ByVal txtHoraSaidaSexta As NumericEditBox, _
                         ByVal txtHoraSaidaSabado As NumericEditBox, _
                         ByVal txtHoraSaidaDomingo As NumericEditBox, _
                         ByVal txtMinutoSaidaSegunda As NumericEditBox, _
                         ByVal txtMinutoSaidaTerca As NumericEditBox, _
                         ByVal txtMinutoSaidaQuarta As NumericEditBox, _
                         ByVal txtMinutoSaidaQuinta As NumericEditBox, _
                         ByVal txtMinutoSaidaSexta As NumericEditBox, _
                         ByVal txtMinutoSaidaSabado As NumericEditBox, _
                         ByVal txtMinutoSaidaDomingo As NumericEditBox, _
                         ByVal txtHoraAlmocoSegunda As MaskedEditBox, _
                         ByVal txtHoraAlmocoTerca As MaskedEditBox, _
                         ByVal txtHoraAlmocoQuarta As MaskedEditBox, _
                         ByVal txtHoraAlmocoQuinta As MaskedEditBox, _
                         ByVal txtHoraAlmocoSexta As MaskedEditBox, _
                         ByVal txtHoraAlmocoSabado As MaskedEditBox, _
                         ByVal txtHoraAlmocoDomingo As MaskedEditBox, _
                         ByVal txtHoraAdicionalNoturnoInicioSegunda As NumericEditBox, _
                         ByVal txtHoraAdicionalNoturnoInicioTerca As NumericEditBox, _
                         ByVal txtHoraAdicionalNoturnoInicioQuarta As NumericEditBox, _
                         ByVal txtHoraAdicionalNoturnoInicioQuinta As NumericEditBox, _
                         ByVal txtHoraAdicionalNoturnoInicioSexta As NumericEditBox, _
                         ByVal txtHoraAdicionalNoturnoInicioSabado As NumericEditBox, _
                         ByVal txtHoraAdicionalNoturnoInicioDomingo As NumericEditBox, _
                         ByVal txtMinutoAdicionalNoturnoInicioSegunda As NumericEditBox, _
                         ByVal txtMinutoAdicionalNoturnoInicioTerca As NumericEditBox, _
                         ByVal txtMinutoAdicionalNoturnoInicioQuarta As NumericEditBox, _
                         ByVal txtMinutoAdicionalNoturnoInicioQuinta As NumericEditBox, _
                         ByVal txtMinutoAdicionalNoturnoInicioSexta As NumericEditBox, _
                         ByVal txtMinutoAdicionalNoturnoInicioSabado As NumericEditBox, _
                         ByVal txtMinutoAdicionalNoturnoInicioDomingo As NumericEditBox, _
                         ByVal txtHoraAdicionalNoturnoTerminoSegunda As NumericEditBox, _
                         ByVal txtHoraAdicionalNoturnoTerminoTerca As NumericEditBox, _
                         ByVal txtHoraAdicionalNoturnoTerminoQuarta As NumericEditBox, _
                         ByVal txtHoraAdicionalNoturnoTerminoQuinta As NumericEditBox, _
                         ByVal txtHoraAdicionalNoturnoTerminoSexta As NumericEditBox, _
                         ByVal txtHoraAdicionalNoturnoTerminoSabado As NumericEditBox, _
                         ByVal txtHoraAdicionalNoturnoTerminoDomingo As NumericEditBox, _
                         ByVal txtMinutoAdicionalNoturnoTerminoSegunda As NumericEditBox, _
                         ByVal txtMinutoAdicionalNoturnoTerminoTerca As NumericEditBox, _
                         ByVal txtMinutoAdicionalNoturnoTerminoQuarta As NumericEditBox, _
                         ByVal txtMinutoAdicionalNoturnoTerminoQuinta As NumericEditBox, _
                         ByVal txtMinutoAdicionalNoturnoTerminoSexta As NumericEditBox, _
                         ByVal txtMinutoAdicionalNoturnoTerminoSabado As NumericEditBox, _
                         ByVal txtMinutoAdicionalNoturnoTerminoDomingo As NumericEditBox, _
                         ByVal txtHoraExtraPreTurnoSegunda As MaskedEditBox, _
                         ByVal txtHoraExtraPreTurnoTerca As MaskedEditBox, _
                         ByVal txtHoraExtraPreTurnoQuarta As MaskedEditBox, _
                         ByVal txtHoraExtraPreTurnoQuinta As MaskedEditBox, _
                         ByVal txtHoraExtraPreTurnoSexta As MaskedEditBox, _
                         ByVal txtHoraExtraPreTurnoSabado As MaskedEditBox, _
                         ByVal txtHoraExtraPreTurnoDomingo As MaskedEditBox, _
                         ByVal txtHoraExtraPosTurnoSegunda As MaskedEditBox, _
                         ByVal txtHoraExtraPosTurnoTerca As MaskedEditBox, _
                         ByVal txtHoraExtraPosTurnoQuarta As MaskedEditBox, _
                         ByVal txtHoraExtraPosTurnoQuinta As MaskedEditBox, _
                         ByVal txtHoraExtraPosTurnoSexta As MaskedEditBox, _
                         ByVal txtHoraExtraPosTurnoSabado As MaskedEditBox, _
                         ByVal txtHoraExtraPosTurnoDomingo As MaskedEditBox)

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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_turno_producao", oSqlParameter)

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
                txtHoraEntradaSegunda.Value = oSqlDataReader.Item("hora_entrada_segunda")
                txtHoraEntradaTerca.Value = oSqlDataReader.Item("hora_entrada_terca")
                txtHoraEntradaQuarta.Value = oSqlDataReader.Item("hora_entrada_quarta")
                txtHoraEntradaQuinta.Value = oSqlDataReader.Item("hora_entrada_quinta")
                txtHoraEntradaSexta.Value = oSqlDataReader.Item("hora_entrada_sexta")
                txtHoraEntradaSabado.Value = oSqlDataReader.Item("hora_entrada_sabado")
                txtHoraEntradaDomingo.Value = oSqlDataReader.Item("hora_entrada_domingo")
                txtMinutoEntradaSegunda.Value = oSqlDataReader.Item("minuto_entrada_segunda")
                txtMinutoEntradaTerca.Value = oSqlDataReader.Item("minuto_entrada_terca")
                txtMinutoEntradaQuarta.Value = oSqlDataReader.Item("minuto_entrada_quarta")
                txtMinutoEntradaQuinta.Value = oSqlDataReader.Item("minuto_entrada_quinta")
                txtMinutoEntradaSexta.Value = oSqlDataReader.Item("minuto_entrada_sexta")
                txtMinutoEntradaSabado.Value = oSqlDataReader.Item("minuto_entrada_sabado")
                txtMinutoEntradaDomingo.Value = oSqlDataReader.Item("minuto_entrada_domingo")
                txtHoraSaidaSegunda.Value = oSqlDataReader.Item("hora_saida_segunda")
                txtHoraSaidaTerca.Value = oSqlDataReader.Item("hora_saida_terca")
                txtHoraSaidaQuarta.Value = oSqlDataReader.Item("hora_saida_quarta")
                txtHoraSaidaQuinta.Value = oSqlDataReader.Item("hora_saida_quinta")
                txtHoraSaidaSexta.Value = oSqlDataReader.Item("hora_saida_sexta")
                txtHoraSaidaSabado.Value = oSqlDataReader.Item("hora_saida_sabado")
                txtHoraSaidaDomingo.Value = oSqlDataReader.Item("hora_saida_domingo")
                txtMinutoSaidaSegunda.Value = oSqlDataReader.Item("minuto_saida_segunda")
                txtMinutoSaidaTerca.Value = oSqlDataReader.Item("minuto_saida_terca")
                txtMinutoSaidaQuarta.Value = oSqlDataReader.Item("minuto_saida_quarta")
                txtMinutoSaidaQuinta.Value = oSqlDataReader.Item("minuto_saida_quinta")
                txtMinutoSaidaSexta.Value = oSqlDataReader.Item("minuto_saida_sexta")
                txtMinutoSaidaSabado.Value = oSqlDataReader.Item("minuto_saida_sabado")
                txtMinutoSaidaDomingo.Value = oSqlDataReader.Item("minuto_saida_domingo")
                txtHoraAlmocoSegunda.Text = oSqlDataReader.Item("hora_almoco_segunda")
                txtHoraAlmocoTerca.Text = oSqlDataReader.Item("hora_almoco_terca")
                txtHoraAlmocoQuarta.Text = oSqlDataReader.Item("hora_almoco_quarta")
                txtHoraAlmocoQuinta.Text = oSqlDataReader.Item("hora_almoco_quinta")
                txtHoraAlmocoSexta.Text = oSqlDataReader.Item("hora_almoco_sexta")
                txtHoraAlmocoSabado.Text = oSqlDataReader.Item("hora_almoco_sabado")
                txtHoraAlmocoDomingo.Text = oSqlDataReader.Item("hora_almoco_domingo")
                txtHoraAdicionalNoturnoInicioSegunda.Value = oSqlDataReader.Item("hora_entrada_adicional_segunda")
                txtHoraAdicionalNoturnoInicioTerca.Value = oSqlDataReader.Item("hora_entrada_adicional_terca")
                txtHoraAdicionalNoturnoInicioQuarta.Value = oSqlDataReader.Item("hora_entrada_adicional_quarta")
                txtHoraAdicionalNoturnoInicioQuinta.Value = oSqlDataReader.Item("hora_entrada_adicional_quinta")
                txtHoraAdicionalNoturnoInicioSexta.Value = oSqlDataReader.Item("hora_entrada_adicional_sexta")
                txtHoraAdicionalNoturnoInicioSabado.Value = oSqlDataReader.Item("hora_entrada_adicional_sabado")
                txtHoraAdicionalNoturnoInicioDomingo.Value = oSqlDataReader.Item("hora_entrada_adicional_domingo")
                txtMinutoAdicionalNoturnoInicioSegunda.Value = oSqlDataReader.Item("minuto_entrada_adicional_segunda")
                txtMinutoAdicionalNoturnoInicioTerca.Value = oSqlDataReader.Item("minuto_entrada_adicional_terca")
                txtMinutoAdicionalNoturnoInicioQuarta.Value = oSqlDataReader.Item("minuto_entrada_adicional_quarta")
                txtMinutoAdicionalNoturnoInicioQuinta.Value = oSqlDataReader.Item("minuto_entrada_adicional_quinta")
                txtMinutoAdicionalNoturnoInicioSexta.Value = oSqlDataReader.Item("minuto_entrada_adicional_sexta")
                txtMinutoAdicionalNoturnoInicioSabado.Value = oSqlDataReader.Item("minuto_entrada_adicional_sabado")
                txtMinutoAdicionalNoturnoInicioDomingo.Value = oSqlDataReader.Item("minuto_entrada_adicional_domingo")
                txtHoraAdicionalNoturnoTerminoSegunda.Value = oSqlDataReader.Item("hora_saida_adicional_segunda")
                txtHoraAdicionalNoturnoTerminoTerca.Value = oSqlDataReader.Item("hora_saida_adicional_terca")
                txtHoraAdicionalNoturnoTerminoQuarta.Value = oSqlDataReader.Item("hora_saida_adicional_quarta")
                txtHoraAdicionalNoturnoTerminoQuinta.Value = oSqlDataReader.Item("hora_saida_adicional_quinta")
                txtHoraAdicionalNoturnoTerminoSexta.Value = oSqlDataReader.Item("hora_saida_adicional_sexta")
                txtHoraAdicionalNoturnoTerminoSabado.Value = oSqlDataReader.Item("hora_saida_adicional_sabado")
                txtHoraAdicionalNoturnoTerminoDomingo.Value = oSqlDataReader.Item("hora_saida_adicional_domingo")
                txtMinutoAdicionalNoturnoTerminoSegunda.Value = oSqlDataReader.Item("minuto_saida_adicional_segunda")
                txtMinutoAdicionalNoturnoTerminoTerca.Value = oSqlDataReader.Item("minuto_saida_adicional_terca")
                txtMinutoAdicionalNoturnoTerminoQuarta.Value = oSqlDataReader.Item("minuto_saida_adicional_quarta")
                txtMinutoAdicionalNoturnoTerminoQuinta.Value = oSqlDataReader.Item("minuto_saida_adicional_quinta")
                txtMinutoAdicionalNoturnoTerminoSexta.Value = oSqlDataReader.Item("minuto_saida_adicional_sexta")
                txtMinutoAdicionalNoturnoTerminoSabado.Value = oSqlDataReader.Item("minuto_saida_adicional_sabado")
                txtMinutoAdicionalNoturnoTerminoDomingo.Value = oSqlDataReader.Item("minuto_saida_adicional_domingo")
                txtHoraExtraPreTurnoSegunda.Text = oSqlDataReader.Item("hora_extra_pre_turno_segunda")
                txtHoraExtraPreTurnoTerca.Text = oSqlDataReader.Item("hora_extra_pre_turno_terca")
                txtHoraExtraPreTurnoQuarta.Text = oSqlDataReader.Item("hora_extra_pre_turno_quarta")
                txtHoraExtraPreTurnoQuinta.Text = oSqlDataReader.Item("hora_extra_pre_turno_quinta")
                txtHoraExtraPreTurnoSexta.Text = oSqlDataReader.Item("hora_extra_pre_turno_sexta")
                txtHoraExtraPreTurnoSabado.Text = oSqlDataReader.Item("hora_extra_pre_turno_sabado")
                txtHoraExtraPreTurnoDomingo.Text = oSqlDataReader.Item("hora_extra_pre_turno_domingo")
                txtHoraExtraPosTurnoSegunda.Text = oSqlDataReader.Item("hora_extra_pos_turno_segunda")
                txtHoraExtraPosTurnoTerca.Text = oSqlDataReader.Item("hora_extra_pos_turno_terca")
                txtHoraExtraPosTurnoQuarta.Text = oSqlDataReader.Item("hora_extra_pos_turno_quarta")
                txtHoraExtraPosTurnoQuinta.Text = oSqlDataReader.Item("hora_extra_pos_turno_quinta")
                txtHoraExtraPosTurnoSexta.Text = oSqlDataReader.Item("hora_extra_pos_turno_sexta")
                txtHoraExtraPosTurnoSabado.Text = oSqlDataReader.Item("hora_extra_pos_turno_sabado")
                txtHoraExtraPosTurnoDomingo.Text = oSqlDataReader.Item("hora_extra_pos_turno_domingo")

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
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_turno_producao", oSqlParameter), Integer)

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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_turno_producao", oSqlParameter)

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
