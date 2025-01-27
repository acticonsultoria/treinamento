Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports System.IO

Public Class clsUsrFat000000003

#Region "::: VÁRIAVEIS :::"

    Private sRegistro10 As String
    Private sRegistro11 As String
    Private sRegistro50() As String
    Private sRegistro51() As String
    Private sRegistro54() As String
    Private sRegistro70() As String
    Private sRegistro74() As String
    Private sRegistro75() As String
    Private sRegistro90 As String

#End Region

#Region "::: CONSTRUTOR :::"

    Sub New()

        'Limpa Váriaveis
        sRegistro10 = ""
        sRegistro11 = ""
        ReDim sRegistro50(0)
        ReDim sRegistro51(0)
        ReDim sRegistro54(0)
        ReDim sRegistro70(0)
        ReDim sRegistro74(0)
        ReDim sRegistro75(0)
        sRegistro90 = ""

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub SintegraRegistro10(ByVal sDataEmissaoInicio As String, _
                                  ByVal sDataEmissaoTermino As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissaoInicio : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissaoTermino : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_sintegra_10", oSqlParameter)

            While oSqlDataReader.Read

                sRegistro10 = oSqlDataReader.Item("linha")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SintegraRegistro11(ByVal sDataEmissaoInicio As String, _
                                  ByVal sDataEmissaoTermino As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_sintegra_11", oSqlParameter)

            While oSqlDataReader.Read

                sRegistro11 = oSqlDataReader.Item("linha")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SintegraEmissaoRegistro50(ByVal sDataEmissaoInicio As String, _
                                         ByVal sDataEmissaoTermino As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissaoInicio : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissaoTermino : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_sintegra_emissao_50", oSqlParameter)

            While oSqlDataReader.Read

                If sRegistro50(UBound(sRegistro50)) <> "" Then
                    ReDim Preserve sRegistro50(UBound(sRegistro50) + 1)
                End If

                sRegistro50(UBound(sRegistro50)) = oSqlDataReader.Item("linha")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SintegraEntradaRegistro50(ByVal sDataEntradaInicio As String, _
                                         ByVal sDataEntradaTermino As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrada_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEntradaInicio : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrada_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEntradaTermino : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_sintegra_entrada_50", oSqlParameter)

            While oSqlDataReader.Read

                If sRegistro50(UBound(sRegistro50)) <> "" Then
                    ReDim Preserve sRegistro50(UBound(sRegistro50) + 1)
                End If

                sRegistro50(UBound(sRegistro50)) = oSqlDataReader.Item("linha")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SintegraEmissaoRegistro51(ByVal sDataEmissaoInicio As String, _
                                         ByVal sDataEmissaoTermino As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissaoInicio : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissaoTermino : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_sintegra_emissao_51", oSqlParameter)

            While oSqlDataReader.Read

                If sRegistro51(UBound(sRegistro51)) <> "" Then
                    ReDim Preserve sRegistro51(UBound(sRegistro51) + 1)
                End If

                sRegistro51(UBound(sRegistro51)) = oSqlDataReader.Item("linha")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SintegraEntradaRegistro51(ByVal sDataEntradaInicio As String, _
                                         ByVal sDataEntradaTermino As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrada_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEntradaInicio : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrada_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEntradaTermino : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_sintegra_entrada_51", oSqlParameter)

            While oSqlDataReader.Read

                If sRegistro51(UBound(sRegistro51)) <> "" Then
                    ReDim Preserve sRegistro51(UBound(sRegistro51) + 1)
                End If

                sRegistro51(UBound(sRegistro51)) = oSqlDataReader.Item("linha")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SintegraEmissaoRegistro54(ByVal sDataEmissaoInicio As String, _
                                         ByVal sDataEmissaoTermino As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i, iCont As Integer
        Dim lCodigo As Long

        Try

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissaoInicio : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissaoTermino : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_sintegra_emissao_54", oSqlParameter)

            While oSqlDataReader.Read

                If sRegistro54(UBound(sRegistro54)) <> "" Then
                    ReDim Preserve sRegistro54(UBound(sRegistro54) + 1)
                End If

                If lCodigo <> oSqlDataReader.Item("codigo") Then
                    lCodigo = oSqlDataReader.Item("codigo")
                    iCont = 1
                Else
                    iCont += 1
                End If

                sRegistro54(UBound(sRegistro54)) = oSqlDataReader.Item("linha").ToString.Replace("@@@", Format(iCont, "000"))

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SintegraEntradaRegistro54(ByVal sDataEntradaInicio As String, _
                                         ByVal sDataEntradaTermino As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i, iCont As Integer
        Dim lCodigo As Long

        Try

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrada_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEntradaInicio : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrada_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEntradaTermino : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_sintegra_entrada_54", oSqlParameter)

            While oSqlDataReader.Read

                If sRegistro54(UBound(sRegistro54)) <> "" Then
                    ReDim Preserve sRegistro54(UBound(sRegistro54) + 1)
                End If

                If lCodigo <> oSqlDataReader.Item("codigo") Then
                    lCodigo = oSqlDataReader.Item("codigo")
                    iCont = 1
                Else
                    iCont += 1
                End If

                sRegistro54(UBound(sRegistro54)) = oSqlDataReader.Item("linha").ToString.Replace("@@@", Format(iCont, "000"))

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SintegraEntradaRegistro70(ByVal sDataEntradaInicio As String, _
                                         ByVal sDataEntradaTermino As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrada_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEntradaInicio : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrada_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEntradaTermino : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_sintegra_entrada_70", oSqlParameter)

            While oSqlDataReader.Read

                If sRegistro70(UBound(sRegistro70)) <> "" Then
                    ReDim Preserve sRegistro70(UBound(sRegistro70) + 1)
                End If

                sRegistro70(UBound(sRegistro70)) = oSqlDataReader.Item("linha")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SintegraRegistro74(ByVal sDataEmissaoTermino As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissaoTermino : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_sintegra_74", oSqlParameter)

            While oSqlDataReader.Read

                If sRegistro74(UBound(sRegistro74)) <> "" Then
                    ReDim Preserve sRegistro74(UBound(sRegistro74) + 1)
                End If

                sRegistro74(UBound(sRegistro74)) = oSqlDataReader.Item("linha")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SintegraRegistro75(ByVal sDataEmissaoInicio As String, _
                                  ByVal sDataEmissaoTermino As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissaoInicio : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissaoTermino : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_sintegra_75", oSqlParameter)

            While oSqlDataReader.Read

                If sRegistro75(UBound(sRegistro75)) <> "" Then
                    ReDim Preserve sRegistro75(UBound(sRegistro75) + 1)
                End If

                sRegistro75(UBound(sRegistro75)) = oSqlDataReader.Item("linha")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SintegraRegistro90(ByVal sArquivo As String)

        'Variaveis Locais
        Dim oStreamWriter As New StreamWriter(sArquivo)
        Dim i As Integer

        Try

            oStreamWriter.WriteLine(sRegistro10)
            oStreamWriter.WriteLine(sRegistro11)
            For i = 0 To UBound(sRegistro50)
                If sRegistro50(i) <> "" And sRegistro50(i) Is Nothing = False Then oStreamWriter.WriteLine(sRegistro50(i))
            Next i
            For i = 0 To UBound(sRegistro51)
                If sRegistro51(i) <> "" And sRegistro51(i) Is Nothing = False Then oStreamWriter.WriteLine(sRegistro51(i))
            Next i
            For i = 0 To UBound(sRegistro54)
                If sRegistro54(i) <> "" And sRegistro54(i) Is Nothing = False Then oStreamWriter.WriteLine(sRegistro54(i))
            Next i
            For i = 0 To UBound(sRegistro70)
                If sRegistro70(i) <> "" And sRegistro70(i) Is Nothing = False Then oStreamWriter.WriteLine(sRegistro70(i))
            Next i
            For i = 0 To UBound(sRegistro74)
                If sRegistro74(i) <> "" And sRegistro74(i) Is Nothing = False Then oStreamWriter.WriteLine(sRegistro74(i))
            Next i
            For i = 0 To UBound(sRegistro75)
                If sRegistro75(i) <> "" And sRegistro75(i) Is Nothing = False Then oStreamWriter.WriteLine(sRegistro75(i))
            Next i

            Call LoadDadosEmitente()

            sRegistro90 = "90"
            sRegistro90 &= goEmitente.sCNPJ.Replace("-", "").Replace(".", "").Replace("/", "") & Space(14 - Len(goEmitente.sCNPJ.Replace("-", "").Replace(".", "").Replace("/", "")))
            sRegistro90 &= goEmitente.sInscricaoEstadual.Replace("-", "").Replace(".", "").Replace("/", "") & Space(14 - Len(goEmitente.sInscricaoEstadual.Replace("-", "").Replace(".", "").Replace("/", "")))
            sRegistro90 &= IIf(sRegistro50(UBound(sRegistro50)) <> "" And sRegistro50(UBound(sRegistro50)) Is Nothing = False, "50" & Format(sRegistro50.Length, "00000000"), "")
            sRegistro90 &= IIf(sRegistro51(UBound(sRegistro51)) <> "" And sRegistro51(UBound(sRegistro51)) Is Nothing = False, "51" & Format(sRegistro51.Length, "00000000"), "")
            sRegistro90 &= IIf(sRegistro54(UBound(sRegistro54)) <> "" And sRegistro54(UBound(sRegistro54)) Is Nothing = False, "54" & Format(sRegistro54.Length, "00000000"), "")
            sRegistro90 &= IIf(sRegistro70(UBound(sRegistro70)) <> "" And sRegistro70(UBound(sRegistro70)) Is Nothing = False, "70" & Format(sRegistro70.Length, "00000000"), "")
            sRegistro90 &= IIf(sRegistro74(UBound(sRegistro74)) <> "" And sRegistro74(UBound(sRegistro74)) Is Nothing = False, "74" & Format(sRegistro74.Length, "00000000"), "")
            sRegistro90 &= IIf(sRegistro75(UBound(sRegistro75)) <> "" And sRegistro75(UBound(sRegistro75)) Is Nothing = False, "75" & Format(sRegistro75.Length, "00000000"), "")
            sRegistro90 &= "99" & Format(IIf(sRegistro50(UBound(sRegistro50)) <> "" And sRegistro50(UBound(sRegistro50)) Is Nothing = False, sRegistro50.Length, 0) + _
                                         IIf(sRegistro51(UBound(sRegistro51)) <> "" And sRegistro51(UBound(sRegistro51)) Is Nothing = False, sRegistro51.Length, 0) + _
                                         IIf(sRegistro54(UBound(sRegistro54)) <> "" And sRegistro54(UBound(sRegistro54)) Is Nothing = False, sRegistro54.Length, 0) + _
                                         IIf(sRegistro70(UBound(sRegistro70)) <> "" And sRegistro70(UBound(sRegistro70)) Is Nothing = False, sRegistro70.Length, 0) + _
                                         IIf(sRegistro74(UBound(sRegistro74)) <> "" And sRegistro74(UBound(sRegistro74)) Is Nothing = False, sRegistro74.Length, 0) + _
                                         IIf(sRegistro75(UBound(sRegistro75)) <> "" And sRegistro75(UBound(sRegistro75)) Is Nothing = False, sRegistro75.Length, 0) + 3, "00000000")
            sRegistro90 &= Space(125 - Len(sRegistro90)) & "1"
            oStreamWriter.WriteLine(sRegistro90)
            oStreamWriter.Close()

        Catch ex As Exception
            oStreamWriter.Close()
            Throw ex
        End Try

    End Sub

#End Region

End Class
