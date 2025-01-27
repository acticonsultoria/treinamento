Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrImportarArquivoAFD

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private iCodigo As Integer
    Private sRegistro As String
    Private sNSR As String
    Private sPIS As String
    Private sHorario As String
    Private dtData As Date
    Private sNumero As String
    Private sEscolhaCpfCnpj As Integer
    Private sCpfCnpj As String
    Private sCei As String
    Private sNumeroFabricacao As String
    Private sRazaoSocial As String
    Private dtDataInicio As Date
    Private dtDataFinal As Date
    Private dtDataGgeracao As Date
    Private sHoraGeracao As String

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

    Public Property Registro() As String
        Get
            Return sRegistro
        End Get
        Set(ByVal value As String)
            sRegistro = value
        End Set
    End Property

    Public Property PIS() As String
        Get
            Return sPIS
        End Get
        Set(ByVal value As String)
            sPIS = value
        End Set
    End Property

    Public Property NSR() As String
        Get
            Return sNSR
        End Get
        Set(ByVal value As String)
            sNSR = value
        End Set
    End Property

    Public Property Horario() As String
        Get
            Return sHorario
        End Get
        Set(ByVal value As String)
            sHorario = value
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

    Public Property Numero() As String
        Get
            Return sNumero
        End Get
        Set(ByVal value As String)
            sNumero = value
        End Set
    End Property

    Public Property CpfCnpj() As String
        Get
            Return sCpfCnpj
        End Get
        Set(ByVal value As String)
            sCpfCnpj = value
        End Set
    End Property

    Public Property Cei() As String
        Get
            Return sCei
        End Get
        Set(ByVal value As String)
            sCei = value
        End Set
    End Property

    Public Property NumeroFabricacao() As String
        Get
            Return sNumeroFabricacao
        End Get
        Set(ByVal value As String)
            sNumeroFabricacao = value
        End Set
    End Property

    Public Property RazaoSocial() As String
        Get
            Return sRazaoSocial
        End Get
        Set(ByVal value As String)
            sRazaoSocial = value
        End Set
    End Property

    Public Property HoraGeracao() As String
        Get
            Return sHoraGeracao
        End Get
        Set(ByVal value As String)
            sHoraGeracao = value
        End Set
    End Property

    Public Property EscolhaCpfCnpj() As String
        Get
            Return sEscolhaCpfCnpj
        End Get
        Set(ByVal value As String)
            sEscolhaCpfCnpj = value
        End Set
    End Property

    Public Property DataInicio() As Date
        Get
            Return dtDataInicio
        End Get
        Set(ByVal value As Date)
            dtDataInicio = value
        End Set
    End Property

    Public Property DataFinal() As Date
        Get
            Return dtDataFinal
        End Get
        Set(ByVal value As Date)
            dtDataFinal = value
        End Set
    End Property

    Public Property DataGgeracao() As Date
        Get
            Return dtDataGgeracao
        End Get
        Set(ByVal value As Date)
            dtDataGgeracao = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub InsertMovimentacao(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer

        Try
            For Each oRow As GridEXRow In oGrid.GetDataRows

                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Funcionário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Conta Contábil
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "registro"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRow.Cells("registro").Value : i += 1

                'Seta Parametros - Conta Contábil
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "nsr"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRow.Cells("nsr").Value : i += 1

                'Seta Parametros - Conta Contábil
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "pis"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRow.Cells("pis").Value : i += 1

                'Seta Parametros - Data
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data").Value : i += 1

                'Seta Parametros - Conta Contábil
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "horario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRow.Cells("horario").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_arquivo_afd_movimentacao", oSqlParameter)
            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Insert(ByVal oGrid As GridEX, _
                      ByVal sNumero As String, _
                      ByVal sRegistro As String, _
                      ByVal sEscolhaCpfCnpj As String, _
                      ByVal sCpfCnpj As String, _
                      ByVal sCei As String, _
                      ByVal sNumeroFabricacao As String, _
                      ByVal sRazaoSocial As String, _
                      ByVal dtDataInicio As Date, _
                      ByVal dtDataFinal As Date, _
                      ByVal dtDataGgeracao As Date, _
                      ByVal sHoraGeracao As String)

        'Variaveis Locais
        Dim oSqlParameter(12) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int : i += 1

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sNumero : i += 1

            'Seta Parametros - Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "registro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = sRegistro : i += 1

            'Seta Parametros - Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "escolha_cpf_cnpj"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = sEscolhaCpfCnpj : i += 1

            'Seta Parametros - Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cpf_cnpj"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sCpfCnpj : i += 1

            'Seta Parametros - Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cei"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sCei : i += 1

            'Seta Parametros - Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_fabricacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sNumeroFabricacao : i += 1

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 150
            oSqlParameter(i).Value = sRazaoSocial : i += 1

            'Seta Parametros - Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtDataInicio : i += 1

            'Seta Parametros - Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtDataFinal : i += 1

            'Seta Parametros - Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_geracao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtDataGgeracao : i += 1

            'Seta Parametros - Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_geracao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sHoraGeracao

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_arquivo_afd", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_arquivo_afd", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteMovimentacao()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_arquivo_afd_movimentacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeletePonto()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_arquivo_afd_ponto", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function LoadFuncionario(ByVal sPis As String) As String

        'Variaveis Locais

        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        'For Each oRow As GridEX In oGrid
        Try

            'Seta Parametros - Número do Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sPis : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            LoadFuncionario = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_funcionario_codigo_pis", oSqlParameter)




        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try
        'Next
    End Function


#End Region

End Class
