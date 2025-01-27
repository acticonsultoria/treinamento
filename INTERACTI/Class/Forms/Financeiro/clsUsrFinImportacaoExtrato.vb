Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Microsoft.Office.Interop

Public Class clsUsrFinImportacaoExtrato

#Region "::: ENUMS :::"

    Private Enum Bradesco

        Data = 1
        Descricao = 2
        NumeroDocumento = 3
        Credito = 4
        Debito = 5
        Saldo = 6

    End Enum

    Private Enum Sicredi

        Data = 1
        Descricao = 2
        NumeroDocumento = 3
        Valor = 4
        Saldo = 5

    End Enum

    Private Enum Santander

        Data = 1
        Descricao = 3
        NumeroDocumento = 4
        Valor = 5
        Saldo = 6

    End Enum

    Private Enum HSBC

        Data = 1
        Descricao = 2
        NumeroDocumento = 4
        Valor = 5
        Tipo = 6
        Saldo = 7

    End Enum

#End Region

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sNumeroDocumento As String
    Private dValor As Double
    Private iCodigo As Integer
    Private sTipo As String
    Private sArquivo As String
    Private dtDataInput As Date
    Private dtData As Date
    Private sBanco As String
    Private sDescricao As String
    Private dSaldo As Double
    Private iCodigoPai As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property Saldo() As Double
        Get
            Return dSaldo
        End Get
        Set(ByVal value As Double)
            dSaldo = value
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

    Public Property Banco() As String
        Get
            Return sBanco
        End Get
        Set(ByVal value As String)
            sBanco = value
        End Set
    End Property

    Public Property Data() As Date
        Get
            Return dtData
        End Get
        Set(ByVal value As Date)
            dtData = value
        End Set
    End Property

    Public Property DataInput() As Date
        Get
            Return dtDataInput
        End Get
        Set(ByVal value As Date)
            dtDataInput = value
        End Set
    End Property

    Public Property Arquivo() As String
        Get
            Return sArquivo
        End Get
        Set(ByVal value As String)
            sArquivo = value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return sTipo
        End Get
        Set(ByVal value As String)
            sTipo = value
        End Set
    End Property

    Public Property NumeroDocumento() As String
        Get
            Return sNumeroDocumento
        End Get
        Set(ByVal value As String)
            sNumeroDocumento = value
        End Set
    End Property

    Public Property Valor() As Double
        Get
            Return dValor
        End Get
        Set(ByVal value As Double)
            dValor = value
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

    Public Property CodigoPai() As Integer
        Get
            Return iCodigoPai
        End Get
        Set(ByVal value As Integer)
            iCodigoPai = value
        End Set
    End Property



#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: ARQUIVO :::"

#Region "::: BRADESCO :::"

    Public Sub ImportarExtratoBradesco(ByVal iCodigoContaBancaria As Integer, _
                                       ByVal sArquivo As String, _
                                       ByVal dtData As Date)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

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
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoContaBancaria = -1, DBNull.Value, iCodigoContaBancaria) : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000
            oSqlParameter(i).Value = IIf(sArquivo = "", DBNull.Value, sArquivo) : i += 1

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtData : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato", oSqlParameter)

            iCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ImportarExtratoArquivoBradesco(ByVal sArquivo As String)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0
        Dim iRow As Integer = 11
        Dim bFlag As Boolean = False
        Dim oApplicationClass As New Excel.ApplicationClass
        'Abre o Arquivo
        oApplicationClass.Workbooks.Open(sArquivo)

        Try
            'Percorre Linha a Linha o Arquivo até não ter mais registros
            While 1

                'Verifica se acabou os registros
                If ValidaDado(oApplicationClass.Range(LoadRangeExcel(Bradesco.Data, iRow)).Value, True) = False Then

                    bFlag = True
                    For j As Integer = 0 To 7

                        If ValidaDado(oApplicationClass.Range(LoadRangeExcel(Bradesco.Data, iRow + j)).Value, True) = True And
                            ValidaDado(oApplicationClass.Range(LoadRangeExcel(Bradesco.NumeroDocumento, iRow + j)).Value, False) = True Then

                            bFlag = False
                            iRow = iRow + j

                            Exit For
                        End If
                    Next
                Else
                    bFlag = False

                End If

                If bFlag = True Then
                    Exit While
                End If
               
                'Seta Váriavel 
                i = 0

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
                oSqlParameter(i).Value = iCodigo : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_importacao_extrato"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigo : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_documento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Bradesco.NumeroDocumento, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Bradesco.Descricao, iRow)).Value : i += 1

                'Seta Parametros - Planilha
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Bradesco.Data, iRow)).Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tipo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = IIf(ValidaDado(oApplicationClass.Range(LoadRangeExcel(Bradesco.Credito, iRow)).Value) = False, "D", "R") : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                If ValidaDado(oApplicationClass.Range(LoadRangeExcel(Bradesco.Credito, iRow)).Value) = False Then
                    oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Bradesco.Debito, iRow)).Value * -1
                Else
                    oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Bradesco.Credito, iRow)).Value
                End If
                i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "saldo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = IIf((oApplicationClass.Range(LoadRangeExcel(Bradesco.Saldo, iRow)).Value) = " ", DBNull.Value, oApplicationClass.Range(LoadRangeExcel(Bradesco.Saldo, iRow)).Value)

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato_movimento", oSqlParameter)
                iRow += 1
            End While

            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
        Catch SqlEx As SqlException
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw SqlEx
        Catch ex As Exception
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: SANTANDER :::"

    Public Sub ImportarExtratoSantander(ByVal iCodigoContaBancaria As Integer, _
                                       ByVal sArquivo As String, _
                                       ByVal dtData As Date)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

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
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoContaBancaria = -1, DBNull.Value, iCodigoContaBancaria) : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000
            oSqlParameter(i).Value = IIf(sArquivo = "", DBNull.Value, sArquivo) : i += 1

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtData : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato", oSqlParameter)

            iCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ImportarExtratoArquivoSantander(ByVal sArquivo As String)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0
        Dim iRow As Integer = 5
        Dim bFlag As Boolean = False
        Dim oApplicationClass As New Excel.ApplicationClass
        'Abre o Arquivo
        oApplicationClass.Workbooks.Open(sArquivo)

        Try
            'Percorre Linha a Linha o Arquivo até não ter mais registros
            While 1


                'Verifica se acabou os registros
                If ValidaDado(oApplicationClass.Range(LoadRangeExcel(Santander.Data, iRow)).Value, True) = False Then

                    bFlag = True
                    For j As Integer = 0 To 7

                        If ValidaDado(oApplicationClass.Range(LoadRangeExcel(Santander.Data, iRow + j)).Value, True) = True And
                            ValidaDado(oApplicationClass.Range(LoadRangeExcel(Santander.NumeroDocumento, iRow + j)).Value, False) = True Then

                            bFlag = False
                            iRow = iRow + j

                            Exit For
                        End If

                    Next

                Else
                    bFlag = False

                End If

                'Verifica se acabou os registros
                If ValidaDado(oApplicationClass.Range(LoadRangeExcel(Santander.NumeroDocumento, iRow)).Value, True) = False Then

                    bFlag = True
                    For j As Integer = 0 To 7

                        If ValidaDado(oApplicationClass.Range(LoadRangeExcel(Santander.Data, iRow + j)).Value, True) = True And
                            ValidaDado(oApplicationClass.Range(LoadRangeExcel(Santander.NumeroDocumento, iRow + j)).Value, False) = True Then

                            bFlag = False
                            iRow = iRow + j

                            Exit For
                        End If

                    Next

                Else
                    bFlag = False

                End If

                If bFlag = True Then
                    Exit While
                End If

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_importacao_extrato"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigo : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_documento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Santander.NumeroDocumento, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Santander.Descricao, iRow)).Value : i += 1

                'Seta Parametros - Planilha
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Santander.Data, iRow)).Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tipo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = IIf((oApplicationClass.Range(LoadRangeExcel(Santander.Valor, iRow)).Value) >= 0, "R", "D") : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Santander.Valor, iRow)).Value : i += 1
                'If (oApplicationClass.Range(LoadRangeExcel(Santander.Valor, iRow)).Value) >= 0 Then
                '    oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Santander.Valor, iRow)).Value * -1
                'Else
                '    oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Santander.Valor, iRow)).Value
                'End If : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "saldo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = IIf(ValidaDado(oApplicationClass.Range(LoadRangeExcel(Santander.Saldo, iRow)).Value) = False, DBNull.Value, oApplicationClass.Range(LoadRangeExcel(Santander.Saldo, iRow)).Value) : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Output
                oSqlParameter(i).SqlDbType = SqlDbType.Int


                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato_movimento", oSqlParameter)

                iCodigoPai = oSqlParameter(i).Value

                iRow += 1
            End While

            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
        Catch SqlEx As SqlException
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw SqlEx
        Catch ex As Exception
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: HSBC :::"

    Public Sub ImportarExtratoHSBC(ByVal iCodigoContaBancaria As Integer, _
                                       ByVal sArquivo As String, _
                                       ByVal dtData As Date)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

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
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoContaBancaria = -1, DBNull.Value, iCodigoContaBancaria) : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000
            oSqlParameter(i).Value = IIf(sArquivo = "", DBNull.Value, sArquivo) : i += 1

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtData : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato", oSqlParameter)

            iCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ImportarExtratoArquivoHSBC(ByVal sArquivo As String)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0
        Dim iRow As Integer = 16
        Dim bFlag As Boolean = False
        Dim oApplicationClass As New Excel.ApplicationClass
        'Abre o Arquivo
        oApplicationClass.Workbooks.Open(sArquivo)

        Try
            'Percorre Linha a Linha o Arquivo até não ter mais registros
            While 1
                
                'Verifica se acabou os registros
                If ValidaDado(oApplicationClass.Range(LoadRangeExcel(HSBC.NumeroDocumento, iRow)).Value, True) = False Then

                    bFlag = True
                    For j As Integer = 0 To 7

                        'If ValidaDado(oApplicationClass.Range(LoadRangeExcel(HSBC.Data, iRow + j)).Value, True) = True And
                        If ValidaDado(oApplicationClass.Range(LoadRangeExcel(HSBC.NumeroDocumento, iRow + j)).Value, False) = True Then

                            bFlag = False
                            iRow = iRow + j

                            Exit For
                        End If
                    Next
                Else
                    bFlag = False

                End If

                If bFlag = True Then
                    Exit While
                End If

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_importacao_extrato"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigo : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_documento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(HSBC.NumeroDocumento, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(HSBC.Descricao, iRow)).Value : i += 1

                'Seta Parametros - Planilha
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(HSBC.Data, iRow)).Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tipo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(HSBC.Tipo, iRow)).Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                If (oApplicationClass.Range(LoadRangeExcel(HSBC.Valor, iRow)).Value) < 0 Then
                    oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(HSBC.Valor, iRow)).Value * -1
                Else
                    oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(HSBC.Valor, iRow)).Value
                End If : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "saldo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = DBNull.Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato_movimento", oSqlParameter)
                iRow += 1
            End While

            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
        Catch SqlEx As SqlException
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw SqlEx
        Catch ex As Exception
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: SICREDI EXCEL :::"

    Public Sub ImportarExtratoSicrediE(ByVal iCodigoContaBancaria As Integer, _
                                       ByVal sArquivo As String, _
                                       ByVal dtData As Date)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

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
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoContaBancaria = -1, DBNull.Value, iCodigoContaBancaria) : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000
            oSqlParameter(i).Value = IIf(sArquivo = "", DBNull.Value, sArquivo) : i += 1

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtData : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato", oSqlParameter)

            iCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ImportarExtratoArquivoSicrediE(ByVal sArquivo As String)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0
        Dim iRow As Integer = 11
        Dim bFlag As Boolean = False
        Dim oApplicationClass As New Excel.ApplicationClass
        'Abre o Arquivo
        oApplicationClass.Workbooks.Open(sArquivo)

        Try
            'Percorre Linha a Linha o Arquivo até não ter mais registros
            While 1


                'Verifica se acabou os registros
                If ValidaDado(oApplicationClass.Range(LoadRangeExcel(Sicredi.Data, iRow)).Value, True) = False Then

                    bFlag = True
                    For j As Integer = 0 To 7

                        If ValidaDado(oApplicationClass.Range(LoadRangeExcel(Sicredi.Data, iRow + j)).Value, True) = True And
                            ValidaDado(oApplicationClass.Range(LoadRangeExcel(Sicredi.NumeroDocumento, iRow + j)).Value, False) = True Then

                            bFlag = False
                            iRow = iRow + j

                            Exit For
                        End If

                    Next

                Else
                    bFlag = False

                End If

                'Verifica se acabou os registros
                If ValidaDado(oApplicationClass.Range(LoadRangeExcel(Sicredi.NumeroDocumento, iRow)).Value, True) = False Then

                    bFlag = True
                    For j As Integer = 0 To 7

                        If ValidaDado(oApplicationClass.Range(LoadRangeExcel(Sicredi.Data, iRow + j)).Value, True) = True And
                            ValidaDado(oApplicationClass.Range(LoadRangeExcel(Sicredi.NumeroDocumento, iRow + j)).Value, False) = True Then

                            bFlag = False
                            iRow = iRow + j

                            Exit For
                        End If

                    Next

                Else
                    bFlag = False

                End If

                If bFlag = True Then
                    Exit While
                End If

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_importacao_extrato"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigo : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_documento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Sicredi.NumeroDocumento, iRow)).Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Sicredi.Descricao, iRow)).Value : i += 1

                'Seta Parametros - Planilha
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Sicredi.Data, iRow)).Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tipo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = IIf((oApplicationClass.Range(LoadRangeExcel(Sicredi.Valor, iRow)).Value) < 0, "D", "R") : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                If (oApplicationClass.Range(LoadRangeExcel(Sicredi.Valor, iRow)).Value) < 0 Then
                    oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Sicredi.Valor, iRow)).Value * -1
                Else
                    oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Sicredi.Valor, iRow)).Value
                End If : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "saldo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = IIf(ValidaDado(oApplicationClass.Range(LoadRangeExcel(Sicredi.Saldo, iRow)).Value) = False, DBNull.Value, oApplicationClass.Range(LoadRangeExcel(Santander.Saldo, iRow)).Value) : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Output
                oSqlParameter(i).SqlDbType = SqlDbType.Int


                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato_movimento", oSqlParameter)

                iCodigoPai = oSqlParameter(i).Value

                iRow += 1
            End While

            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
        Catch SqlEx As SqlException
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw SqlEx
        Catch ex As Exception
            oApplicationClass.Workbooks.Close()
            oApplicationClass = Nothing
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: SICREDI TXT :::"

    Public Sub ImportarExtratoSicredi(ByVal iCodigoContaBancaria As Integer, _
                                       ByVal sArquivo As String, _
                                       ByVal dtData As Date)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

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
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoContaBancaria = -1, DBNull.Value, iCodigoContaBancaria) : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000
            oSqlParameter(i).Value = IIf(sArquivo = "", DBNull.Value, sArquivo) : i += 1

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtData : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato", oSqlParameter)

            iCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ImportarExtratoArquivoSicredi(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer

        Try
            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_importacao_extrato"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigo : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_documento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells.Item("numero_documento").Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells.Item("descricao").Value : i += 1

                'Seta Parametros - Planilha
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells.Item("data").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tipo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells.Item("tipo").Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells.Item("valor").Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "saldo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells.Item("saldo").Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Output
                oSqlParameter(i).SqlDbType = SqlDbType.Int

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato_movimento", oSqlParameter)

                iCodigoPai = oSqlParameter(i).Value

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CAIXA :::"

    Public Sub ImportarExtratoCaixa(ByVal iCodigoContaBancaria As Integer, _
                                       ByVal sArquivo As String, _
                                       ByVal dtData As Date)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

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
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoContaBancaria = -1, DBNull.Value, iCodigoContaBancaria) : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000
            oSqlParameter(i).Value = IIf(sArquivo = "", DBNull.Value, sArquivo) : i += 1

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtData : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato", oSqlParameter)

            iCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ImportarExtratoArquivoCaixa(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer

        Try
            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_importacao_extrato"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigo : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_documento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells.Item("numero_documento").Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells.Item("descricao").Value : i += 1

                'Seta Parametros - Planilha
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells.Item("data").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tipo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells.Item("tipo").Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells.Item("valor").Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "saldo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells.Item("saldo").Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Output
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                 
                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato_movimento", oSqlParameter)

                iCodigoPai = oSqlParameter(i).Value 

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ITAÚ :::"

    Public Sub ImportarExtratoItau(ByVal iCodigoContaBancaria As Integer, _
                                       ByVal sArquivo As String, _
                                       ByVal dtData As Date)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

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
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoContaBancaria = -1, DBNull.Value, iCodigoContaBancaria) : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000
            oSqlParameter(i).Value = IIf(sArquivo = "", DBNull.Value, sArquivo) : i += 1

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtData : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato", oSqlParameter)

            iCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ImportarExtratoArquivoItau(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer

        Try
            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_importacao_extrato"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigo : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_documento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells.Item("numero_documento").Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells.Item("descricao").Value : i += 1

                'Seta Parametros - Planilha
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells.Item("data").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tipo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells.Item("tipo").Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells.Item("valor").Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "saldo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells.Item("saldo").Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Output
                oSqlParameter(i).SqlDbType = SqlDbType.Int


                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato_movimento", oSqlParameter)

                iCodigoPai = oSqlParameter(i).Value

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: BANCO DO BRASIL :::"

    Public Sub ImportarExtratoBancoBrasil(ByVal iCodigoContaBancaria As Integer, _
                                       ByVal sArquivo As String, _
                                       ByVal dtData As Date)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

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
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoContaBancaria = -1, DBNull.Value, iCodigoContaBancaria) : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 4000
            oSqlParameter(i).Value = IIf(sArquivo = "", DBNull.Value, sArquivo) : i += 1

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtData : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato", oSqlParameter)

            iCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ImportarExtratoArquivoBancoBrasil(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer

        Try
            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_importacao_extrato"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigo : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_documento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells.Item("numero_documento").Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells.Item("descricao").Value : i += 1

                'Seta Parametros - Planilha
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells.Item("data").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tipo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells.Item("tipo").Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells.Item("valor").Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "saldo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells.Item("saldo").Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Output
                oSqlParameter(i).SqlDbType = SqlDbType.Int


                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato_movimento", oSqlParameter)

                iCodigoPai = oSqlParameter(i).Value

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: GERAL :::"

    Public Sub LoadCodigoBanco(ByVal lCodigoCodigoBancoConta As Long, _
                               ByRef lCodigoBanco As Long)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try 'Seta Parametros - Código Banco Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCodigoBancoConta : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_codigo_banco", oSqlParameter)

            'Verifica se foi encontrado algum registro
            If oSqlDataReader.HasRows = True Then

                While oSqlDataReader.Read

                    lCodigoBanco = oSqlDataReader.Item("codigo_banco")

                End While

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ValidaBanco(ByVal oGrid As GridEX, _
                           ByVal iCodigoBanco As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBanco : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_financeiro_importacao_extrato", oSqlParameter)

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

    Public Sub ImportarExtratoArquivoVinculoAutomatico()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_importacao_extrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato_movimentacao_vinculo_automatico", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridMovimento(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_importacao_extrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_importacao_extrato_movimento", oSqlParameter)

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

    Private Function LoadRangeExcel(ByVal iIndice As Integer, ByVal iRow As Integer) As String
        Try

            Dim sIndice As String = ""
            If iIndice > 26 Then
                If iIndice - 26 > 26 Then
                    sIndice = "B"
                    iIndice -= 52
                Else
                    sIndice = "A"
                    iIndice -= 26
                End If
            Else

                sIndice = ""
            End If
            sIndice += Chr(64 + iIndice)

            Return sIndice & iRow
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidaDado(ByVal oValor As Object,
                                Optional ByVal bData As Boolean = False,
                                Optional ByVal bDescricao As Boolean = False) As Boolean
        ValidaDado = True
        If oValor Is Nothing Then
            ValidaDado = False
        ElseIf IsDBNull(oValor) Then
            ValidaDado = False
        ElseIf CStr(oValor) = "" Then
            ValidaDado = False
        ElseIf IsDate(oValor) = False And bData = True Then
            ValidaDado = False
        ElseIf IsDBNull(oValor) = False And bDescricao = True Then
            ValidaDado = False
        End If

    End Function

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iCodigoBancoConta As Integer, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio) = False, DBNull.Value, sDataInicio) : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino) = False, DBNull.Value, sDataTermino) : i += 1

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_importacao_extrato", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo_importacao_extrato"))


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

    Public Sub LoadGridMovimentoEditar(ByVal oGrid As GridEX, _
                                       ByVal iCodigoImportacaoEditar As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Try
            'For Each oRow As GridEXRow In gSelecaoRow

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_importacao_extrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoImportacaoEditar : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_importacao_extrato_movimento", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

           
            'Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex

        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
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

                'Seta Parametros - Codigo Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_importacao_extrato"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_importacao_extrato").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_importacao_extrato", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Salvar(ByVal iCodigoTituloCapa As Integer, _
                      ByVal sNumeroParcela As String, _
                      ByVal iCodigoExtratoMovimento As Integer, _
                      ByVal iCodigoBancoTransferencia As Integer, _
                      ByVal iCodigoCentroCusto As Integer)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0
        Try

            'Seta Parametros
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_importacao_extrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigo = -1, DBNull.Value, iCodigo) : i += 1

            'Seta Parametros
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_importacao_extrato_movimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoExtratoMovimento = -1, DBNull.Value, iCodigoExtratoMovimento) : i += 1

            'Seta Parametros
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoTituloCapa = -1, DBNull.Value, iCodigoTituloCapa) : i += 1

            'Seta Parametros
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroParcela : i += 1

            'Seta Parametros
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta_transferencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoBancoTransferencia = -1, DBNull.Value, iCodigoBancoTransferencia) : i += 1

            'Seta Parametros
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCentroCusto = -1, DBNull.Value, iCodigoCentroCusto) : i += 1

            'Seta Parametros
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato_movimento_vinculo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Pagar(ByVal iCodigoImportacaoExtrato As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0
        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_importacao_extrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoImportacaoExtrato : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_extrato_pagamento", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteVinculo(ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            'For Each oRow As GridEXRow In gSelecaoRow

            'Seta Váriavel
            i = 0



            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_importacao_extrato_movimento_vinculo", oSqlParameter)

            'Exclui Linha
            'oRow.Delete()

            'Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

#End Region

End Class
