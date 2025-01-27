Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Microsoft.Office.Interop

Public Class clsUsrFinImportacaoRazao

#Region "::: ENUMS :::"

    Private Enum Ascon

        Conta = 4
        Historico = 7
        Debito = 8
        Credito = 9
        Terceiro = 5
        CentroCusto = 6
        Data = 3


    End Enum
     
#End Region

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sMensagem As String
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
    Private lCodigoDespesaCapa As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property Mensagem() As String
        Get
            Return sMensagem
        End Get
        Set(ByVal value As String)
            sMensagem = value
        End Set
    End Property

    Public Property CodigoDespesaCapa() As Long
        Get
            Return lCodigoDespesaCapa
        End Get
        Set(ByVal value As Long)
            lCodigoDespesaCapa = value
        End Set
    End Property

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
     
#Region "::: GERAL :::"

    Public Sub LoadGridMovimento(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Try

            'Seta Parametros - Código Importacao Razao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_importacao_razao"
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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_importacao_razao_movimento", oSqlParameter)

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
                                Optional ByVal bNumero As Boolean = False,
                                Optional ByVal bDescricao As Boolean = False) As Boolean

        ValidaDado = True

        If oValor Is Nothing Then
            ValidaDado = False
        ElseIf IsDBNull(oValor) Then
            ValidaDado = False
        ElseIf CStr(oValor) = "" Then
            ValidaDado = False
        ElseIf IsNumeric(oValor) = False And bNumero = True Then
            ValidaDado = False
        ElseIf IsDBNull(oValor) = False And bDescricao = True Then
            ValidaDado = False
        ElseIf IsNumeric(oValor) = False And bNumero = False And oValor.ToString.Contains("DIV") = True Then
            ValidaDado = True
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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_importacao_razao", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo_importacao_razao"))


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
            oSqlParameter(i).ParameterName = "codigo_importacao_razao"
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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_importacao_razao_movimento", oSqlParameter)

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

                'Seta Parametros - Codigo Importação Razão
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_importacao_razao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_importacao_razao").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_importacao_razao", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ASCON :::"

    Public Sub ImportarRazao(ByVal iCodigoContaBancaria As Integer, _
                             ByVal sArquivo As String, _
                             ByVal dData As Date)

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

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dData : i += 1

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

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_razao", oSqlParameter)

            iCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ImportarRazaoArquivo(ByVal sArquivo As String)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0
        Dim iRow As Integer = 1
        Dim bFlag As Boolean = False
        Dim oApplicationClass As New Excel.ApplicationClass
        'Abre o Arquivo
        oApplicationClass.Workbooks.Open(sArquivo)
        oApplicationClass.Workbooks.Open(sArquivo).Sheets(1).Select()

        Try

            'Percorre Linha a Linha o Arquivo até não ter mais registros
            While 1

                'Verifica se acabou os registros
                If ValidaDado(oApplicationClass.Range(LoadRangeExcel(Ascon.Conta, iRow)).Value, True) = False Then
                    
                    bFlag = True
                    For j As Integer = 0 To 10

                        If ((ValidaDado(oApplicationClass.Range(LoadRangeExcel(Ascon.Conta, iRow)).Value, True) = True) Or
                           (ValidaDado(oApplicationClass.Range(LoadRangeExcel(Ascon.Conta, iRow)).Value, False) = True And iRow > 8)) Then

                            If ((IsNumeric(oApplicationClass.Range(LoadRangeExcel(Ascon.Conta, iRow)).Value) = True) Or
                               (ValidaDado(oApplicationClass.Range(LoadRangeExcel(Ascon.Conta, iRow)).Value, False) = True And iRow > 8)) Then

                                bFlag = False

                                Exit For
                            End If
                        End If

                        iRow = iRow + 1

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

                'Seta Parametros - Código Importacao Razao
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_importacao_razao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigo : i += 1

                'Seta Parametros - Conta
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "conta"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Ascon.Conta, iRow)).Value : i += 1

                'Seta Parametros - Terceiro
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "terceiro"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = IIf(IsNumeric(oApplicationClass.Range(LoadRangeExcel(Ascon.Terceiro, iRow)).Text) = False, "", oApplicationClass.Range(LoadRangeExcel(Ascon.Terceiro, iRow)).Text) : i += 1

                'Seta Parametros - Histórico
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "historico"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Ascon.Historico, iRow)).Value : i += 1

                'Seta Parametros - Centro Custo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "centro_custo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = IIf(IsNumeric(oApplicationClass.Range(LoadRangeExcel(Ascon.CentroCusto, iRow)).Value) = False, DBNull.Value, oApplicationClass.Range(LoadRangeExcel(Ascon.CentroCusto, iRow)).Value) : i += 1

                'Seta Parametros - Data
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Ascon.Data, iRow)).Value : i += 1

                'Seta Parametros - Tipo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tipo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = IIf(IsNumeric(oApplicationClass.Range(LoadRangeExcel(Ascon.Debito, iRow)).Value) = False, "C", "D") : i += 1

                'Seta Parametros - Valor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = IIf(IsNumeric(oApplicationClass.Range(LoadRangeExcel(Ascon.Debito, iRow)).Value) = False, oApplicationClass.Range(LoadRangeExcel(Ascon.Credito, iRow)).Value, oApplicationClass.Range(LoadRangeExcel(Ascon.Debito, iRow)).Value)

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_razao_movimento", oSqlParameter)

                'End If
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

    'Public Sub ImportarRazaoArquivoDespesa(ByVal sArquivo As String, _
    '                                       ByVal dtData As Date)

    '    'Variaveis Locais
    '    Dim oSqlParameter(9) As SqlParameter
    '    Dim i As Integer = 0
    '    Dim iRow As Integer = 1
    '    Dim bFlag As Boolean = False
    '    Dim oApplicationClass As New Excel.ApplicationClass
    '    'Abre o Arquivo
    '    oApplicationClass.Workbooks.Open(sArquivo)
    '    oApplicationClass.Workbooks.Open(sArquivo).Sheets(5).Select()

    '    Try

    '        'Percorre Linha a Linha o Arquivo até não ter mais registros
    '        While 1

    '            'Verifica se acabou os registros
    '            If ValidaDado(oApplicationClass.Range(LoadRangeExcel(Ascon.Conta, iRow)).Value, True) = False Or
    '               (oApplicationClass.Range(LoadRangeExcel(Ascon.Conta, iRow)).Font.Bold = True And
    '                ValidaDado(oApplicationClass.Range(LoadRangeExcel(Ascon.Conta, iRow)).Value, True)) Then

    '                bFlag = True
    '                For j As Integer = 0 To 10

    '                    If ValidaDado(oApplicationClass.Range(LoadRangeExcel(Ascon.Conta, iRow)).Value, True) = True And
    '                       ValidaDado(oApplicationClass.Range(LoadRangeExcel(Ascon.NomeConta, iRow)).Value, False) = True And
    '                       oApplicationClass.Range(LoadRangeExcel(Ascon.Conta, iRow)).Font.Bold = False Then

    '                        If IsNumeric(oApplicationClass.Range(LoadRangeExcel(Ascon.Conta, iRow)).Value) = True Then

    '                            bFlag = False

    '                            Exit For
    '                        End If
    '                    End If

    '                    iRow = iRow + 1

    '                Next
    '            Else
    '                bFlag = False

    '            End If

    '            If bFlag = True Then
    '                Exit While
    '            End If

    '            'Seta Váriavel 
    '            i = 0

    '            'Seta Parametros - Código Empresa
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "codigo_empresa"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
    '            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

    '            'Seta Parametros - Código
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "codigo"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = iCodigo : i += 1

    '            'Seta Parametros - Código Importacao Razao
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "codigo_importacao_razao"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = iCodigo : i += 1

    '            'Seta Parametros - Conta
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "conta"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Ascon.Conta, iRow)).Value : i += 1

    '            'Seta Parametros - Classificador
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "classificador"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Ascon.Classificador, iRow)).Text : i += 1

    '            'Seta Parametros - Nome Conta
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "nome_conta"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Ascon.NomeConta, iRow)).Value : i += 1

    '            'Seta Parametros - Centro Custo
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "centro_custo"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Ascon.CentroCusto, iRow)).Value : i += 1

    '            'Seta Parametros - Data
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "data"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
    '            oSqlParameter(i).Value = dtData : i += 1

    '            'Seta Parametros - Tipo
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "tipo"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = "D" : i += 1

    '            'Seta Parametros - Valor
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "valor"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Float
    '            oSqlParameter(i).Value = oApplicationClass.Range(LoadRangeExcel(Ascon.Valor, iRow)).Value

    '            'Executa Query
    '            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_importacao_razao_movimento", oSqlParameter)

    '            'End If
    '            iRow += 1

    '        End While

    '        oApplicationClass.Workbooks.Close()
    '        oApplicationClass = Nothing
    '    Catch SqlEx As SqlException
    '        oApplicationClass.Workbooks.Close()
    '        oApplicationClass = Nothing
    '        Throw SqlEx
    '    Catch ex As Exception
    '        oApplicationClass.Workbooks.Close()
    '        oApplicationClass = Nothing
    '        Throw ex
    '    End Try

    'End Sub

    Public Sub Insert(ByVal sDescritivo As String, _
                      ByVal dValor As Double, _
                      ByVal iCodigoImportacao As Integer, _
                      ByVal sCentroCusto As String, _
                      ByVal sConta As String, _
                      ByVal sTipo As String, _
                      ByVal sCodigoProsoft As String, _
                      ByVal dtData As Date)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1
             
            'Seta Parametros - Descritivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descritivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sDescritivo : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Importacao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_importacao_razao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoImportacao : i += 1

            'Seta Parametros - Centro Custo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sCentroCusto : i += 1

            'Seta Parametros - Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sConta : i += 1

            'Seta Parametros - Código Prosoft
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_prosoft"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sCodigoProsoft : i += 1

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtData : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_importacao_razao", oSqlParameter)

            'Seta Código
            lCodigoDespesaCapa = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaCentroCusto() As String

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim sReturn As String
        Try

            'Seta Retorno da Função
            ValidaCentroCusto = False

            'Seta Parametros - Código Importacao Razao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_importacao_razao"
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
            sReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_financeiro_importacao_razao_movimento", oSqlParameter), String)

            'Seta Retorno da Função
            ValidaCentroCusto = IIf(sReturn = "FALTA CC", False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaTerceiro() As String

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim sReturn As String
        Try

            'Seta Retorno da Função
            ValidaTerceiro = False

            'Seta Parametros - Código Importacao Razao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_importacao_razao"
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
            sReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_financeiro_importacao_razao_movimento_terceiro", oSqlParameter), String)

            sMensagem = sReturn

            'Seta Retorno da Função
            ValidaTerceiro = IIf(sReturn = "", True, False)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
