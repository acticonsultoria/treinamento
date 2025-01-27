Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop

Public Class clsUsrFin000000010

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGridLavalpa(ByVal oGrid As GridEX, _
                        ByVal sTipo As String, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sDataVencimentoInicio As String, _
                        ByVal sDataVencimentoTermino As String, _
                        ByVal sDataPagamentoInicio As String, _
                        ByVal sDataPagamentoTermino As String, _
                        ByVal sCodigoCentroCusto As String, _
                        ByVal bLavalpa As Integer, _
                        ByVal bLeSix As Integer, _
                        ByVal bMovimentacao As Boolean)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(12) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "movimentacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bMovimentacao : i += 1

            'Seta Parametros - Lavalpa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lavalpa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(bLavalpa = 2, DBNull.Value, IIf(bLavalpa = False, 0, 1)) : i += 1

            'Seta Parametros - Le Six
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "le_six"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(bLeSix = 2, DBNull.Value, IIf(bLeSix = False, 0, 1)) : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoInicio), sDataEmissaoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoTermino), sDataEmissaoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Vencimento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataVencimentoInicio), sDataVencimentoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Vencimento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataVencimentoTermino), sDataVencimentoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Pagamento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPagamentoInicio), sDataPagamentoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Pagamento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPagamentoTermino), sDataPagamentoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Centro Custo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoCentroCusto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_grid_fin000000010_lavalpa", oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo"))

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridNorsul(ByVal oGrid As GridEX, _
                              ByVal sTipo As String, _
                              ByVal sDataEmissaoInicio As String, _
                              ByVal sDataEmissaoTermino As String, _
                              ByVal sDataVencimentoInicio As String, _
                              ByVal sDataVencimentoTermino As String, _
                              ByVal sDataPagamentoInicio As String, _
                              ByVal sDataPagamentoTermino As String, _
                              ByVal sCodigoCentroCusto As String, _
                              ByVal bMovimentacao As Boolean)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "movimentacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bMovimentacao : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoInicio), sDataEmissaoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoTermino), sDataEmissaoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Vencimento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataVencimentoInicio), sDataVencimentoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Vencimento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataVencimentoTermino), sDataVencimentoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Pagamento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPagamentoInicio), sDataPagamentoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Pagamento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPagamentoTermino), sDataPagamentoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Centro Custo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoCentroCusto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_grid_fin000000010", oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo"))

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sTipo As String, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sDataVencimentoInicio As String, _
                        ByVal sDataVencimentoTermino As String, _
                        ByVal sDataPagamentoInicio As String, _
                        ByVal sDataPagamentoTermino As String, _
                        ByVal sCodigoCentroCusto As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoInicio), sDataEmissaoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoTermino), sDataEmissaoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Vencimento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataVencimentoInicio), sDataVencimentoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Vencimento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataVencimentoTermino), sDataVencimentoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Pagamento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPagamentoInicio), sDataPagamentoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Pagamento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPagamentoTermino), sDataPagamentoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Centro Custo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoCentroCusto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_grid_fin000000010", oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo"))

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub GerarPlanilha(ByVal dDataEmissaoInicio As String, _
                            ByVal dDataEmissaoTermino As String, _
                            ByVal dDataVencimentoInicio As String, _
                            ByVal dDataVencimentoTermino As String, _
                            ByVal dDataPagamentoInicio As String, _
                            ByVal dDataPagamentoTermino As String, _
                            ByVal sCodigoCentroCusto As String, _
                            ByVal bLavalpa As Integer, _
                            ByVal bLeSix As Integer, _
                            ByVal bMovimentacao As Boolean)



        Dim oApplicationClass As New ApplicationClass
        Dim oWorkbook As Workbook
        Dim oWorksheet As Worksheet



        Try
            oWorkbook = oApplicationClass.Workbooks.Add()
            oWorksheet = oWorkbook.Sheets.Add()
            oWorksheet.Name = "Relatório"

            If bLavalpa = "" And bLeSix = "" And bMovimentacao = "" Then

                Call GerarPlanilhaWorksheet(dDataEmissaoInicio, _
                                            dDataEmissaoTermino, _
                                            dDataVencimentoInicio, _
                                            dDataVencimentoTermino, _
                                            dDataPagamentoInicio, _
                                            dDataPagamentoTermino, _
                                            sCodigoCentroCusto, _
                                            oWorksheet)

            ElseIf bMovimentacao = "" And bLavalpa <> "" And bLeSix <> "" Then

                Call GerarPlanilhaWorksheetNorsul(dDataEmissaoInicio, _
                                                  dDataEmissaoTermino, _
                                                  dDataVencimentoInicio, _
                                                  dDataVencimentoTermino, _
                                                  dDataPagamentoInicio, _
                                                  dDataPagamentoTermino, _
                                                  sCodigoCentroCusto, _
                                                  bMovimentacao, _
                                                  oWorksheet)

            Else

                Call GerarPlanilhaWorksheetLavalpa(dDataEmissaoInicio, _
                                                   dDataEmissaoTermino, _
                                                   dDataVencimentoInicio, _
                                                   dDataVencimentoTermino, _
                                                   dDataPagamentoInicio, _
                                                   dDataPagamentoTermino, _
                                                   sCodigoCentroCusto, _
                                                   bLavalpa, _
                                                   bLeSix, _
                                                   bMovimentacao, _
                                                   oWorksheet)

            End If

            'Call GerarPlanilhaWorksheetResumo(dData, oWorksheetResumo)
            'Call GerarPlanilhaWorksheetGerencial(dData, oWorksheetGerencial)

            oApplicationClass.Visible = True


        Catch ex As Exception
            oWorkbook.Close(False)
            Throw ex
        End Try
    End Sub

    Private Sub GerarPlanilhaWorksheet(ByVal dDataEmissaoInicio As String, _
                                       ByVal dDataEmissaoTermino As String, _
                                       ByVal dDataVencimentoInicio As String, _
                                       ByVal dDataVencimentoTermino As String, _
                                       ByVal dDataPagamentoInicio As String, _
                                       ByVal dDataPagamentoTermino As String, _
                                       ByVal sCodigoCentroCusto As String, _
                                       ByRef oWorksheet As Worksheet)
        Try
            'Variaveis Locais
            Dim oDataSet As DataSet
            Dim i As Integer = 0
            Dim oSqlParameter(11) As SqlParameter

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataEmissaoInicio = "", DBNull.Value, dDataEmissaoInicio) : i = i + 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataEmissaoTermino = "", DBNull.Value, dDataEmissaoTermino) : i = i + 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataVencimentoInicio = "", DBNull.Value, dDataVencimentoInicio) : i = i + 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataVencimentoTermino = "", DBNull.Value, dDataVencimentoTermino) : i = i + 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataPagamentoInicio = "", DBNull.Value, dDataPagamentoInicio) : i = i + 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataPagamentoTermino = "", DBNull.Value, dDataPagamentoTermino) : i = i + 1

            'Seta Parametros - Centro Custo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoCentroCusto


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_fin000000010_excel", oSqlParameter)


            oWorksheet.Range("A:N").Font.Size = 8.5
            oWorksheet.Range("A:N").Font.Name = "Arial"
            ' oWorksheet.Range("A:N").WrapText = False

            oWorksheet.Range("B9", "D9").Merge()
            oWorksheet.Range("B9", "D9").Value = "DETALHAMENTO - CENTRO EMPRESARIAL LAVALPA LTDA"
            oWorksheet.Range("B9", "D9").Interior.Color = 16764057
            oWorksheet.Range("B9", "D9").Font.Bold = True
            oWorksheet.Range("B9", "D9").HorizontalAlignment = Excel.Constants.xlLeft

            oWorksheet.Range("B10", "D10").Merge()
            oWorksheet.Range("B10", "D10").Value = "ENTRADAS"
            oWorksheet.Range("B10", "D10").Interior.Color = 9868950
            oWorksheet.Range("B10", "D10").Font.Bold = True
            oWorksheet.Range("B10", "D10").HorizontalAlignment = Excel.Constants.xlLeft

            oWorksheet.Range("B11").Value = "Centro de Custo"
            oWorksheet.Range("B11").ColumnWidth = 30
            oWorksheet.Range("C11").Value = "Σ Valor Pago"
            oWorksheet.Range("C11").ColumnWidth = 14
            oWorksheet.Range("D11").Value = "Atividade"
            oWorksheet.Range("D11").ColumnWidth = 20
            oWorksheet.Range("E11").Value = "Nº Documento"
            oWorksheet.Range("E11").ColumnWidth = 14
            oWorksheet.Range("F11").Value = "Data Emissão"
            oWorksheet.Range("F11").ColumnWidth = 11
            oWorksheet.Range("G11").Value = "Parceiro de Negócio"
            oWorksheet.Range("G11").ColumnWidth = 35
            oWorksheet.Range("H11").Value = "Descritivo"
            oWorksheet.Range("H11").ColumnWidth = 43
            oWorksheet.Range("I11").Value = "Parcela"
            oWorksheet.Range("I11").ColumnWidth = 7
            oWorksheet.Range("J11").Value = "Data Vencimento"
            oWorksheet.Range("J11").ColumnWidth = 11
            oWorksheet.Range("K11").Value = "Valor Parcela"
            oWorksheet.Range("K11").ColumnWidth = 12
            oWorksheet.Range("L11").Value = "Data Pagamento"
            oWorksheet.Range("L11").ColumnWidth = 11
            oWorksheet.Range("M11").Value = "Valor Pago"
            oWorksheet.Range("M11").ColumnWidth = 13
            oWorksheet.Range("A:M").RowHeight = 11.25


            'oWorksheet.Range("C:V").Font.Size = 10
            'oWorksheet.Range("D:W").WrapText = True
            'oWorksheet.Range("D:W").ColumnWidth = 15.43

            'Dim iContJD As Integer = 4
            'Dim sInadimplencia As String = "=SOMA("
            '*****************************************************************************************************************************'
            '                                                     ENTRADA LAVALPA                                                         '
            '*****************************************************************************************************************************'
            Dim iCont As Integer = 1
            Dim iGrupo As Integer = 1
            Dim sInicioGrupo As String = ""
            Dim sTerminoGrupo As String = ""
            Dim sCentroCusto As String = ""
            Dim sSoma As String = ""
            For Each oDataRow As DataRow In oDataSet.Tables(0).Rows
                'Dados
                If oDataRow("codigo_empresa") <> 4 Then
                    Continue For
                End If

                sCentroCusto = oDataRow("centro_custo")
                oWorksheet.Range("B" & CStr(11 + iCont)).Value = oDataRow("centro_custo")
                oWorksheet.Range("C" & CStr(11 + iCont)).Value = oDataRow("valor_total")
                oWorksheet.Range("B" & CStr(11 + iCont), "D" & CStr(11 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                oWorksheet.Range("C" & CStr(11 + iCont)).Style = "Currency"

                sSoma = IIf(sSoma = "", "C" & CStr(11 + iCont), sSoma & ";C" & CStr(11 + iCont))
                sInicioGrupo = ""
                sTerminoGrupo = ""
                For Each oDataRowLinha As DataRow In oDataSet.Tables(2).Rows
                    If oDataRowLinha("codigo_empresa") <> 4 Then
                        Continue For
                    End If

                    If sCentroCusto <> oDataRowLinha("centro_custo") Then
                        ' oWorksheet.Range("E" & CStr((12 + iCont) - iGrupo), "E" & CStr(12 + (iCont - 1))).Rows.Group()
                        'iGrupo += 1
                        Continue For
                    End If


                    oWorksheet.Range("E" & CStr(12 + iCont)).Value = oDataRowLinha("numero_documento")
                    oWorksheet.Range("F" & CStr(12 + iCont)).Value = oDataRowLinha("data_emissao")
                    oWorksheet.Range("G" & CStr(12 + iCont)).Value = oDataRowLinha("parceiro_negocio")
                    oWorksheet.Range("H" & CStr(12 + iCont)).Value = oDataRowLinha("descritivo")
                    oWorksheet.Range("I" & CStr(12 + iCont)).Value = oDataRowLinha("numero_parcela")
                    oWorksheet.Range("J" & CStr(12 + iCont)).Value = oDataRowLinha("data_vencimento")
                    oWorksheet.Range("K" & CStr(12 + iCont)).Value = oDataRowLinha("valor_parcela")
                    oWorksheet.Range("L" & CStr(12 + iCont)).Value = oDataRowLinha("data_pagamento")
                    oWorksheet.Range("M" & CStr(12 + iCont)).Value = oDataRowLinha("valor_pago")

                    oWorksheet.Range("E" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("F" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("H" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("I" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlCenter
                    oWorksheet.Range("J" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("L" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("M" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(12 + iCont)).Style = "Currency"
                    oWorksheet.Range("M" & CStr(12 + iCont)).Style = "Currency"

                    If sInicioGrupo = "" Then
                        sInicioGrupo = "E" & CStr(12 + iCont)
                    End If

                    iCont += 1
                    iGrupo += 1
                Next
                sTerminoGrupo = "E" & CStr(12 + (iCont - 1))

                oWorksheet.Range(sInicioGrupo, sTerminoGrupo).Rows.Group()
                iCont += 1
            Next


            oWorksheet.Range("B" & CStr(12 + iCont)).Value = "TOTAL ENTRADAS C.E.L."
            oWorksheet.Range("B" & CStr(12 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
            If sSoma <> "" Then
                oWorksheet.Range("C" & CStr(12 + iCont)).FormulaLocal = "=SOMA(" & sSoma & ")"
            End If
            oWorksheet.Range("C" & CStr(12 + iCont)).Style = "Currency"

            '*****************************************************************************************************************************'
            '                                                     SAÍDA LAVALPA                                                         '
            '*****************************************************************************************************************************'
            sSoma = ""

            oWorksheet.Range("B" & CStr(14 + iCont), "D" & CStr(14 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(14 + iCont), "D" & CStr(14 + iCont)).Value = "SAÍDAS"
            oWorksheet.Range("B" & CStr(14 + iCont), "D" & CStr(14 + iCont)).Interior.Color = 9868950
            oWorksheet.Range("B" & CStr(14 + iCont), "D" & CStr(14 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(14 + iCont), "D" & CStr(14 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            For Each oDataRow As DataRow In oDataSet.Tables(1).Rows
                'Dados
                If oDataRow("codigo_empresa") <> 4 Then
                    Continue For
                End If

                sCentroCusto = oDataRow("centro_custo")
                oWorksheet.Range("B" & CStr(15 + iCont)).Value = oDataRow("centro_custo")
                oWorksheet.Range("C" & CStr(15 + iCont)).Value = oDataRow("valor_total") * -1
                oWorksheet.Range("B" & CStr(15 + iCont), "D" & CStr(15 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                oWorksheet.Range("C" & CStr(15 + iCont)).Style = "Currency"

                sSoma = IIf(sSoma = "", "C" & CStr(15 + iCont), sSoma & ";C" & CStr(15 + iCont))
                sInicioGrupo = ""
                sTerminoGrupo = ""
                For Each oDataRowLinha As DataRow In oDataSet.Tables(3).Rows
                    If oDataRowLinha("codigo_empresa") <> 4 Then
                        Continue For
                    End If

                    If sCentroCusto <> oDataRowLinha("centro_custo") Then
                        ' oWorksheet.Range("E" & CStr((12 + iCont) - iGrupo), "E" & CStr(12 + (iCont - 1))).Rows.Group()
                        'iGrupo += 1
                        Continue For
                    End If


                    oWorksheet.Range("E" & CStr(16 + iCont)).Value = oDataRowLinha("numero_documento")
                    oWorksheet.Range("F" & CStr(16 + iCont)).Value = oDataRowLinha("data_emissao")
                    oWorksheet.Range("G" & CStr(16 + iCont)).Value = oDataRowLinha("parceiro_negocio")
                    oWorksheet.Range("H" & CStr(16 + iCont)).Value = oDataRowLinha("descritivo")
                    oWorksheet.Range("I" & CStr(16 + iCont)).Value = oDataRowLinha("numero_parcela")
                    oWorksheet.Range("J" & CStr(16 + iCont)).Value = oDataRowLinha("data_vencimento")
                    oWorksheet.Range("K" & CStr(16 + iCont)).Value = oDataRowLinha("valor_parcela") * -1
                    oWorksheet.Range("L" & CStr(16 + iCont)).Value = oDataRowLinha("data_pagamento")
                    oWorksheet.Range("M" & CStr(16 + iCont)).Value = oDataRowLinha("valor_pago") * -1

                    oWorksheet.Range("E" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("F" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("H" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("I" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlCenter
                    oWorksheet.Range("J" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("L" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("M" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(16 + iCont)).Style = "Currency"
                    oWorksheet.Range("M" & CStr(16 + iCont)).Style = "Currency"

                    If sInicioGrupo = "" Then
                        sInicioGrupo = "E" & CStr(16 + iCont)
                    End If

                    iCont += 1
                    iGrupo += 1
                Next
                sTerminoGrupo = "E" & CStr(16 + (iCont - 1))

                oWorksheet.Range(sInicioGrupo, sTerminoGrupo).Rows.Group()
                iCont += 1
            Next


            oWorksheet.Range("B" & CStr(16 + iCont)).Value = "TOTAL SAÍDAS C.E.L."
            oWorksheet.Range("B" & CStr(16 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
            If sSoma <> "" Then
                oWorksheet.Range("C" & CStr(16 + iCont)).FormulaLocal = "=SOMA(" & sSoma & ")"
            End If

            oWorksheet.Range("C" & CStr(16 + iCont)).Style = "Currency"

            '*****************************************************************************************************************************'
            '                                                     ENTRADA NORSUL                                                        '
            '*****************************************************************************************************************************'
            sSoma = ""

            oWorksheet.Range("B" & CStr(18 + iCont), "D" & CStr(18 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(18 + iCont), "D" & CStr(18 + iCont)).Value = "DETALHAMENTO - NORSUL EMPREENDIMENTOS E ADM LTDA"
            oWorksheet.Range("B" & CStr(18 + iCont), "D" & CStr(18 + iCont)).Interior.Color = 16764057
            oWorksheet.Range("B" & CStr(18 + iCont), "D" & CStr(18 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(18 + iCont), "D" & CStr(18 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            oWorksheet.Range("B" & CStr(19 + iCont), "D" & CStr(19 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(19 + iCont), "D" & CStr(19 + iCont)).Value = "ENTRADAS"
            oWorksheet.Range("B" & CStr(19 + iCont), "D" & CStr(19 + iCont)).Interior.Color = 9868950
            oWorksheet.Range("B" & CStr(19 + iCont), "D" & CStr(19 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(19 + iCont), "D" & CStr(19 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            For Each oDataRow As DataRow In oDataSet.Tables(0).Rows
                'Dados
                If oDataRow("codigo_empresa") <> 1 Then
                    Continue For
                End If

                sCentroCusto = oDataRow("centro_custo")
                oWorksheet.Range("B" & CStr(20 + iCont)).Value = oDataRow("centro_custo")
                oWorksheet.Range("C" & CStr(20 + iCont)).Value = oDataRow("valor_total")
                oWorksheet.Range("B" & CStr(20 + iCont), "D" & CStr(20 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                oWorksheet.Range("C" & CStr(20 + iCont)).Style = "Currency"

                sSoma = IIf(sSoma = "", "C" & CStr(20 + iCont), sSoma & ";C" & CStr(20 + iCont))
                sInicioGrupo = ""
                sTerminoGrupo = ""
                For Each oDataRowLinha As DataRow In oDataSet.Tables(2).Rows
                    If oDataRowLinha("codigo_empresa") <> 1 Then
                        Continue For
                    End If

                    If sCentroCusto <> oDataRowLinha("centro_custo") Then
                        ' oWorksheet.Range("E" & CStr((12 + iCont) - iGrupo), "E" & CStr(12 + (iCont - 1))).Rows.Group()
                        'iGrupo += 1
                        Continue For
                    End If


                    oWorksheet.Range("E" & CStr(21 + iCont)).Value = oDataRowLinha("numero_documento")
                    oWorksheet.Range("F" & CStr(21 + iCont)).Value = oDataRowLinha("data_emissao")
                    oWorksheet.Range("G" & CStr(21 + iCont)).Value = oDataRowLinha("parceiro_negocio")
                    oWorksheet.Range("H" & CStr(21 + iCont)).Value = oDataRowLinha("descritivo")
                    oWorksheet.Range("I" & CStr(21 + iCont)).Value = oDataRowLinha("numero_parcela")
                    oWorksheet.Range("J" & CStr(21 + iCont)).Value = oDataRowLinha("data_vencimento")
                    oWorksheet.Range("K" & CStr(21 + iCont)).Value = oDataRowLinha("valor_parcela")
                    oWorksheet.Range("L" & CStr(21 + iCont)).Value = oDataRowLinha("data_pagamento")
                    oWorksheet.Range("M" & CStr(21 + iCont)).Value = oDataRowLinha("valor_pago")

                    oWorksheet.Range("E" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("F" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("H" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("I" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlCenter
                    oWorksheet.Range("J" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("L" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("M" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(21 + iCont)).Style = "Currency"
                    oWorksheet.Range("M" & CStr(21 + iCont)).Style = "Currency"

                    If sInicioGrupo = "" Then
                        sInicioGrupo = "E" & CStr(21 + iCont)
                    End If

                    iCont += 1
                    iGrupo += 1
                Next
                sTerminoGrupo = "E" & CStr(21 + (iCont - 1))

                oWorksheet.Range(sInicioGrupo, sTerminoGrupo).Rows.Group()
                iCont += 1
            Next


            oWorksheet.Range("B" & CStr(21 + iCont)).Value = "TOTAL ENTRADAS NORSUL"
            oWorksheet.Range("B" & CStr(21 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
            If sSoma <> "" Then
                oWorksheet.Range("C" & CStr(21 + iCont)).FormulaLocal = "=SOMA(" & sSoma & ")"
            End If

            oWorksheet.Range("C" & CStr(21 + iCont)).Style = "Currency"

            '*****************************************************************************************************************************'
            '                                                     SAÍDA NORSUL                                                         '
            '*****************************************************************************************************************************'
            sSoma = ""

            oWorksheet.Range("B" & CStr(23 + iCont), "D" & CStr(23 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(23 + iCont), "D" & CStr(23 + iCont)).Value = "SAÍDAS"
            oWorksheet.Range("B" & CStr(23 + iCont), "D" & CStr(23 + iCont)).Interior.Color = 9868950
            oWorksheet.Range("B" & CStr(23 + iCont), "D" & CStr(23 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(23 + iCont), "D" & CStr(23 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            For Each oDataRow As DataRow In oDataSet.Tables(1).Rows
                'Dados
                If oDataRow("codigo_empresa") <> 1 Then
                    Continue For
                End If

                sCentroCusto = oDataRow("centro_custo")
                oWorksheet.Range("B" & CStr(24 + iCont)).Value = oDataRow("centro_custo")
                oWorksheet.Range("C" & CStr(24 + iCont)).Value = oDataRow("valor_total") * -1
                oWorksheet.Range("B" & CStr(24 + iCont), "D" & CStr(24 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                oWorksheet.Range("C" & CStr(24 + iCont)).Style = "Currency"

                sSoma = IIf(sSoma = "", "C" & CStr(24 + iCont), sSoma & ";C" & CStr(24 + iCont))
                sInicioGrupo = ""
                sTerminoGrupo = ""
                For Each oDataRowLinha As DataRow In oDataSet.Tables(3).Rows
                    If oDataRowLinha("codigo_empresa") <> 1 Then
                        Continue For
                    End If

                    If sCentroCusto <> oDataRowLinha("centro_custo") Then
                        ' oWorksheet.Range("E" & CStr((12 + iCont) - iGrupo), "E" & CStr(12 + (iCont - 1))).Rows.Group()
                        'iGrupo += 1
                        Continue For
                    End If


                    oWorksheet.Range("E" & CStr(25 + iCont)).Value = oDataRowLinha("numero_documento")
                    oWorksheet.Range("F" & CStr(25 + iCont)).Value = oDataRowLinha("data_emissao")
                    oWorksheet.Range("G" & CStr(25 + iCont)).Value = oDataRowLinha("parceiro_negocio")
                    oWorksheet.Range("H" & CStr(25 + iCont)).Value = oDataRowLinha("descritivo")
                    oWorksheet.Range("I" & CStr(25 + iCont)).Value = oDataRowLinha("numero_parcela")
                    oWorksheet.Range("J" & CStr(25 + iCont)).Value = oDataRowLinha("data_vencimento")
                    oWorksheet.Range("K" & CStr(25 + iCont)).Value = oDataRowLinha("valor_parcela") * -1
                    oWorksheet.Range("L" & CStr(25 + iCont)).Value = oDataRowLinha("data_pagamento")
                    oWorksheet.Range("M" & CStr(25 + iCont)).Value = oDataRowLinha("valor_pago") * -1

                    oWorksheet.Range("E" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("F" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("H" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("I" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlCenter
                    oWorksheet.Range("J" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("L" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("M" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(25 + iCont)).Style = "Currency"
                    oWorksheet.Range("M" & CStr(25 + iCont)).Style = "Currency"

                    If sInicioGrupo = "" Then
                        sInicioGrupo = "E" & CStr(25 + iCont)
                    End If

                    iCont += 1
                    iGrupo += 1
                Next
                sTerminoGrupo = "E" & CStr(25 + (iCont - 1))

                oWorksheet.Range(sInicioGrupo, sTerminoGrupo).Rows.Group()
                iCont += 1
            Next


            oWorksheet.Range("B" & CStr(25 + iCont)).Value = "TOTAL SAÍDAS NORSUL"
            oWorksheet.Range("B" & CStr(25 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
            If sSoma <> "" Then
                oWorksheet.Range("C" & CStr(25 + iCont)).FormulaLocal = "=SOMA(" & sSoma & ")"
            End If

            oWorksheet.Range("C" & CStr(25 + iCont)).Style = "Currency"

            '*****************************************************************************************************************************'
            '                                                     ENTRADA GERMINEX                                                        '
            '*****************************************************************************************************************************'
            sSoma = ""

            oWorksheet.Range("B" & CStr(27 + iCont), "D" & CStr(27 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(27 + iCont), "D" & CStr(27 + iCont)).Value = "DETALHAMENTO - GERMINEX AGROPECUARIA LTDA"
            oWorksheet.Range("B" & CStr(27 + iCont), "D" & CStr(27 + iCont)).Interior.Color = 16764057
            oWorksheet.Range("B" & CStr(27 + iCont), "D" & CStr(27 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(27 + iCont), "D" & CStr(27 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            oWorksheet.Range("B" & CStr(28 + iCont), "D" & CStr(28 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(28 + iCont), "D" & CStr(28 + iCont)).Value = "ENTRADAS"
            oWorksheet.Range("B" & CStr(28 + iCont), "D" & CStr(28 + iCont)).Interior.Color = 9868950
            oWorksheet.Range("B" & CStr(28 + iCont), "D" & CStr(28 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(28 + iCont), "D" & CStr(28 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            For Each oDataRow As DataRow In oDataSet.Tables(0).Rows
                'Dados
                If oDataRow("codigo_empresa") <> 2 Then
                    Continue For
                End If

                sCentroCusto = oDataRow("centro_custo")
                oWorksheet.Range("B" & CStr(29 + iCont)).Value = oDataRow("centro_custo")
                oWorksheet.Range("C" & CStr(29 + iCont)).Value = oDataRow("valor_total")
                oWorksheet.Range("B" & CStr(29 + iCont), "D" & CStr(29 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                oWorksheet.Range("C" & CStr(29 + iCont)).Style = "Currency"

                sSoma = IIf(sSoma = "", "C" & CStr(29 + iCont), sSoma & ";C" & CStr(29 + iCont))
                sInicioGrupo = ""
                sTerminoGrupo = ""
                For Each oDataRowLinha As DataRow In oDataSet.Tables(2).Rows
                    If oDataRowLinha("codigo_empresa") <> 2 Then
                        Continue For
                    End If

                    If sCentroCusto <> oDataRowLinha("centro_custo") Then
                        ' oWorksheet.Range("E" & CStr((12 + iCont) - iGrupo), "E" & CStr(12 + (iCont - 1))).Rows.Group()
                        'iGrupo += 1
                        Continue For
                    End If


                    oWorksheet.Range("E" & CStr(30 + iCont)).Value = oDataRowLinha("numero_documento")
                    oWorksheet.Range("F" & CStr(30 + iCont)).Value = oDataRowLinha("data_emissao")
                    oWorksheet.Range("G" & CStr(30 + iCont)).Value = oDataRowLinha("parceiro_negocio")
                    oWorksheet.Range("H" & CStr(30 + iCont)).Value = oDataRowLinha("descritivo")
                    oWorksheet.Range("I" & CStr(30 + iCont)).Value = oDataRowLinha("numero_parcela")
                    oWorksheet.Range("J" & CStr(30 + iCont)).Value = oDataRowLinha("data_vencimento")
                    oWorksheet.Range("K" & CStr(30 + iCont)).Value = oDataRowLinha("valor_parcela")
                    oWorksheet.Range("L" & CStr(30 + iCont)).Value = oDataRowLinha("data_pagamento")
                    oWorksheet.Range("M" & CStr(30 + iCont)).Value = oDataRowLinha("valor_pago")

                    oWorksheet.Range("E" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("F" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("H" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("I" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlCenter
                    oWorksheet.Range("J" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("L" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("M" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(30 + iCont)).Style = "Currency"
                    oWorksheet.Range("M" & CStr(30 + iCont)).Style = "Currency"

                    If sInicioGrupo = "" Then
                        sInicioGrupo = "E" & CStr(30 + iCont)
                    End If

                    iCont += 1
                    iGrupo += 1
                Next
                sTerminoGrupo = "E" & CStr(30 + (iCont - 1))

                oWorksheet.Range(sInicioGrupo, sTerminoGrupo).Rows.Group()
                iCont += 1
            Next


            oWorksheet.Range("B" & CStr(30 + iCont)).Value = "TOTAL ENTRADAS GERMINEX"
            oWorksheet.Range("B" & CStr(30 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
            If sSoma <> "" Then
                oWorksheet.Range("C" & CStr(30 + iCont)).FormulaLocal = "=SOMA(" & sSoma & ")"
            End If

            oWorksheet.Range("C" & CStr(30 + iCont)).Style = "Currency"

            '*****************************************************************************************************************************'
            '                                                     SAÍDA GEMINEX                                                           '
            '*****************************************************************************************************************************'
            sSoma = ""

            oWorksheet.Range("B" & CStr(32 + iCont), "D" & CStr(32 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(32 + iCont), "D" & CStr(32 + iCont)).Value = "SAÍDAS"
            oWorksheet.Range("B" & CStr(32 + iCont), "D" & CStr(32 + iCont)).Interior.Color = 9868950
            oWorksheet.Range("B" & CStr(32 + iCont), "D" & CStr(32 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(32 + iCont), "D" & CStr(32 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            For Each oDataRow As DataRow In oDataSet.Tables(1).Rows
                'Dados
                If oDataRow("codigo_empresa") <> 2 Then
                    Continue For
                End If

                sCentroCusto = oDataRow("centro_custo")
                oWorksheet.Range("B" & CStr(33 + iCont)).Value = oDataRow("centro_custo")
                oWorksheet.Range("C" & CStr(33 + iCont)).Value = oDataRow("valor_total") * -1
                oWorksheet.Range("B" & CStr(33 + iCont), "D" & CStr(33 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                oWorksheet.Range("C" & CStr(33 + iCont)).Style = "Currency"

                sSoma = IIf(sSoma = "", "C" & CStr(33 + iCont), sSoma & ";C" & CStr(33 + iCont))
                sInicioGrupo = ""
                sTerminoGrupo = ""
                For Each oDataRowLinha As DataRow In oDataSet.Tables(3).Rows
                    If oDataRowLinha("codigo_empresa") <> 2 Then
                        Continue For
                    End If

                    If sCentroCusto <> oDataRowLinha("centro_custo") Then
                        ' oWorksheet.Range("E" & CStr((12 + iCont) - iGrupo), "E" & CStr(12 + (iCont - 1))).Rows.Group()
                        'iGrupo += 1
                        Continue For
                    End If


                    oWorksheet.Range("E" & CStr(34 + iCont)).Value = oDataRowLinha("numero_documento")
                    oWorksheet.Range("F" & CStr(34 + iCont)).Value = oDataRowLinha("data_emissao")
                    oWorksheet.Range("G" & CStr(34 + iCont)).Value = oDataRowLinha("parceiro_negocio")
                    oWorksheet.Range("H" & CStr(34 + iCont)).Value = oDataRowLinha("descritivo")
                    oWorksheet.Range("I" & CStr(34 + iCont)).Value = oDataRowLinha("numero_parcela")
                    oWorksheet.Range("J" & CStr(34 + iCont)).Value = oDataRowLinha("data_vencimento")
                    oWorksheet.Range("K" & CStr(34 + iCont)).Value = oDataRowLinha("valor_parcela") * -1
                    oWorksheet.Range("L" & CStr(34 + iCont)).Value = oDataRowLinha("data_pagamento")
                    oWorksheet.Range("M" & CStr(34 + iCont)).Value = oDataRowLinha("valor_pago") * -1

                    oWorksheet.Range("E" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("F" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("H" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("I" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlCenter
                    oWorksheet.Range("J" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("L" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("M" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(34 + iCont)).Style = "Currency"
                    oWorksheet.Range("M" & CStr(34 + iCont)).Style = "Currency"

                    If sInicioGrupo = "" Then
                        sInicioGrupo = "E" & CStr(34 + iCont)
                    End If

                    iCont += 1
                    iGrupo += 1
                Next
                sTerminoGrupo = "E" & CStr(34 + (iCont - 1))

                oWorksheet.Range(sInicioGrupo, sTerminoGrupo).Rows.Group()
                iCont += 1
            Next


            oWorksheet.Range("B" & CStr(34 + iCont)).Value = "TOTAL SAÍDAS GERMINEX"
            oWorksheet.Range("B" & CStr(34 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
            If sSoma <> "" Then
                oWorksheet.Range("C" & CStr(34 + iCont)).FormulaLocal = "=SOMA(" & sSoma & ")"
            End If

            oWorksheet.Range("C" & CStr(34 + iCont)).Style = "Currency"

            oWorksheet.Range("E11", "M11").Columns.Group()
            oWorksheet.Outline.ShowLevels(RowLevels:=1, ColumnLevels:=1)

            'oWorksheet.Range("D" & CStr(iContJD + 1), "H" & CStr(iContJD + 1)).Font.Bold = True
            'oWorksheet.Range("D" & CStr(iContJD + 1), "H" & CStr(iContJD + 1)).FormulaLocal = "=SOMA(D" & CStr(i) & ":D" & CStr(iContJD) & ")"
            'Dim iColOSDoc As Integer = iContJD + 1


            'oWorksheet.Columns.AutoFit()
            'oWorksheet.Range("D:W").ColumnWidth = 16
            'oWorksheet.Range("C:C").ColumnWidth = 30
            oWorksheet.Range("A:N").WrapText = False


        Catch ex As Exception
            Throw ex

        End Try
    End Sub

    Private Sub GerarPlanilhaWorksheetNorsul(ByVal dDataEmissaoInicio As String, _
                                             ByVal dDataEmissaoTermino As String, _
                                             ByVal dDataVencimentoInicio As String, _
                                             ByVal dDataVencimentoTermino As String, _
                                             ByVal dDataPagamentoInicio As String, _
                                             ByVal dDataPagamentoTermino As String, _
                                             ByVal sCodigoCentroCusto As String, _
                                             ByVal bMovimentacao As Boolean, _
                                             ByRef oWorksheet As Worksheet)
        Try
            'Variaveis Locais
            Dim oDataSet As DataSet
            Dim i As Integer = 0
            Dim oSqlParameter(12) As SqlParameter

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "movimentacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bMovimentacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataEmissaoInicio = "", DBNull.Value, dDataEmissaoInicio) : i = i + 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataEmissaoTermino = "", DBNull.Value, dDataEmissaoTermino) : i = i + 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataVencimentoInicio = "", DBNull.Value, dDataVencimentoInicio) : i = i + 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataVencimentoTermino = "", DBNull.Value, dDataVencimentoTermino) : i = i + 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataPagamentoInicio = "", DBNull.Value, dDataPagamentoInicio) : i = i + 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataPagamentoTermino = "", DBNull.Value, dDataPagamentoTermino) : i = i + 1

            'Seta Parametros - Centro Custo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoCentroCusto


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_fin000000010_excel", oSqlParameter)


            oWorksheet.Range("A:N").Font.Size = 8.5
            oWorksheet.Range("A:N").Font.Name = "Arial"
            ' oWorksheet.Range("A:N").WrapText = False

            oWorksheet.Range("B9", "D9").Merge()
            oWorksheet.Range("B9", "D9").Value = "DETALHAMENTO - CENTRO EMPRESARIAL LAVALPA LTDA"
            oWorksheet.Range("B9", "D9").Interior.Color = 16764057
            oWorksheet.Range("B9", "D9").Font.Bold = True
            oWorksheet.Range("B9", "D9").HorizontalAlignment = Excel.Constants.xlLeft

            oWorksheet.Range("B10", "D10").Merge()
            oWorksheet.Range("B10", "D10").Value = "ENTRADAS"
            oWorksheet.Range("B10", "D10").Interior.Color = 9868950
            oWorksheet.Range("B10", "D10").Font.Bold = True
            oWorksheet.Range("B10", "D10").HorizontalAlignment = Excel.Constants.xlLeft

            oWorksheet.Range("B11").Value = "Centro de Custo"
            oWorksheet.Range("B11").ColumnWidth = 30
            oWorksheet.Range("C11").Value = "Σ Valor Pago"
            oWorksheet.Range("C11").ColumnWidth = 14
            oWorksheet.Range("D11").Value = "Atividade"
            oWorksheet.Range("D11").ColumnWidth = 20
            oWorksheet.Range("E11").Value = "Nº Documento"
            oWorksheet.Range("E11").ColumnWidth = 14
            oWorksheet.Range("F11").Value = "Data Emissão"
            oWorksheet.Range("F11").ColumnWidth = 11
            oWorksheet.Range("G11").Value = "Parceiro de Negócio"
            oWorksheet.Range("G11").ColumnWidth = 35
            oWorksheet.Range("H11").Value = "Descritivo"
            oWorksheet.Range("H11").ColumnWidth = 43
            oWorksheet.Range("I11").Value = "Parcela"
            oWorksheet.Range("I11").ColumnWidth = 7
            oWorksheet.Range("J11").Value = "Data Vencimento"
            oWorksheet.Range("J11").ColumnWidth = 11
            oWorksheet.Range("K11").Value = "Valor Parcela"
            oWorksheet.Range("K11").ColumnWidth = 12
            oWorksheet.Range("L11").Value = "Data Pagamento"
            oWorksheet.Range("L11").ColumnWidth = 11
            oWorksheet.Range("M11").Value = "Valor Pago"
            oWorksheet.Range("M11").ColumnWidth = 13
            oWorksheet.Range("A:M").RowHeight = 11.25


            'oWorksheet.Range("C:V").Font.Size = 10
            'oWorksheet.Range("D:W").WrapText = True
            'oWorksheet.Range("D:W").ColumnWidth = 15.43

            'Dim iContJD As Integer = 4
            'Dim sInadimplencia As String = "=SOMA("
            '*****************************************************************************************************************************'
            '                                                     ENTRADA LAVALPA                                                         '
            '*****************************************************************************************************************************'
            Dim iCont As Integer = 1
            Dim iGrupo As Integer = 1
            Dim sInicioGrupo As String = ""
            Dim sTerminoGrupo As String = ""
            Dim sCentroCusto As String = ""
            Dim sSoma As String = ""
            For Each oDataRow As DataRow In oDataSet.Tables(0).Rows
                'Dados
                If oDataRow("codigo_empresa") <> 4 Then
                    Continue For
                End If

                sCentroCusto = oDataRow("centro_custo")
                oWorksheet.Range("B" & CStr(11 + iCont)).Value = oDataRow("centro_custo")
                oWorksheet.Range("C" & CStr(11 + iCont)).Value = oDataRow("valor_total")
                oWorksheet.Range("B" & CStr(11 + iCont), "D" & CStr(11 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                oWorksheet.Range("C" & CStr(11 + iCont)).Style = "Currency"

                sSoma = IIf(sSoma = "", "C" & CStr(11 + iCont), sSoma & ";C" & CStr(11 + iCont))
                sInicioGrupo = ""
                sTerminoGrupo = ""
                For Each oDataRowLinha As DataRow In oDataSet.Tables(2).Rows
                    If oDataRowLinha("codigo_empresa") <> 4 Then
                        Continue For
                    End If

                    If sCentroCusto <> oDataRowLinha("centro_custo") Then
                        ' oWorksheet.Range("E" & CStr((12 + iCont) - iGrupo), "E" & CStr(12 + (iCont - 1))).Rows.Group()
                        'iGrupo += 1
                        Continue For
                    End If


                    oWorksheet.Range("E" & CStr(12 + iCont)).Value = oDataRowLinha("numero_documento")
                    oWorksheet.Range("F" & CStr(12 + iCont)).Value = oDataRowLinha("data_emissao")
                    oWorksheet.Range("G" & CStr(12 + iCont)).Value = oDataRowLinha("parceiro_negocio")
                    oWorksheet.Range("H" & CStr(12 + iCont)).Value = oDataRowLinha("descritivo")
                    oWorksheet.Range("I" & CStr(12 + iCont)).Value = oDataRowLinha("numero_parcela")
                    oWorksheet.Range("J" & CStr(12 + iCont)).Value = oDataRowLinha("data_vencimento")
                    oWorksheet.Range("K" & CStr(12 + iCont)).Value = oDataRowLinha("valor_parcela")
                    oWorksheet.Range("L" & CStr(12 + iCont)).Value = oDataRowLinha("data_pagamento")
                    oWorksheet.Range("M" & CStr(12 + iCont)).Value = oDataRowLinha("valor_pago")

                    oWorksheet.Range("E" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("F" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("H" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("I" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlCenter
                    oWorksheet.Range("J" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("L" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("M" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(12 + iCont)).Style = "Currency"
                    oWorksheet.Range("M" & CStr(12 + iCont)).Style = "Currency"

                    If sInicioGrupo = "" Then
                        sInicioGrupo = "E" & CStr(12 + iCont)
                    End If

                    iCont += 1
                    iGrupo += 1
                Next
                sTerminoGrupo = "E" & CStr(12 + (iCont - 1))

                oWorksheet.Range(sInicioGrupo, sTerminoGrupo).Rows.Group()
                iCont += 1
            Next


            oWorksheet.Range("B" & CStr(12 + iCont)).Value = "TOTAL ENTRADAS C.E.L."
            oWorksheet.Range("B" & CStr(12 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
            If sSoma <> "" Then
                oWorksheet.Range("C" & CStr(12 + iCont)).FormulaLocal = "=SOMA(" & sSoma & ")"
            End If
            oWorksheet.Range("C" & CStr(12 + iCont)).Style = "Currency"

            '*****************************************************************************************************************************'
            '                                                     SAÍDA LAVALPA                                                         '
            '*****************************************************************************************************************************'
            sSoma = ""

            oWorksheet.Range("B" & CStr(14 + iCont), "D" & CStr(14 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(14 + iCont), "D" & CStr(14 + iCont)).Value = "SAÍDAS"
            oWorksheet.Range("B" & CStr(14 + iCont), "D" & CStr(14 + iCont)).Interior.Color = 9868950
            oWorksheet.Range("B" & CStr(14 + iCont), "D" & CStr(14 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(14 + iCont), "D" & CStr(14 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            For Each oDataRow As DataRow In oDataSet.Tables(1).Rows
                'Dados
                If oDataRow("codigo_empresa") <> 4 Then
                    Continue For
                End If

                sCentroCusto = oDataRow("centro_custo")
                oWorksheet.Range("B" & CStr(15 + iCont)).Value = oDataRow("centro_custo")
                oWorksheet.Range("C" & CStr(15 + iCont)).Value = oDataRow("valor_total") * -1
                oWorksheet.Range("B" & CStr(15 + iCont), "D" & CStr(15 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                oWorksheet.Range("C" & CStr(15 + iCont)).Style = "Currency"

                sSoma = IIf(sSoma = "", "C" & CStr(15 + iCont), sSoma & ";C" & CStr(15 + iCont))
                sInicioGrupo = ""
                sTerminoGrupo = ""
                For Each oDataRowLinha As DataRow In oDataSet.Tables(3).Rows
                    If oDataRowLinha("codigo_empresa") <> 4 Then
                        Continue For
                    End If

                    If sCentroCusto <> oDataRowLinha("centro_custo") Then
                        ' oWorksheet.Range("E" & CStr((12 + iCont) - iGrupo), "E" & CStr(12 + (iCont - 1))).Rows.Group()
                        'iGrupo += 1
                        Continue For
                    End If


                    oWorksheet.Range("E" & CStr(16 + iCont)).Value = oDataRowLinha("numero_documento")
                    oWorksheet.Range("F" & CStr(16 + iCont)).Value = oDataRowLinha("data_emissao")
                    oWorksheet.Range("G" & CStr(16 + iCont)).Value = oDataRowLinha("parceiro_negocio")
                    oWorksheet.Range("H" & CStr(16 + iCont)).Value = oDataRowLinha("descritivo")
                    oWorksheet.Range("I" & CStr(16 + iCont)).Value = oDataRowLinha("numero_parcela")
                    oWorksheet.Range("J" & CStr(16 + iCont)).Value = oDataRowLinha("data_vencimento")
                    oWorksheet.Range("K" & CStr(16 + iCont)).Value = oDataRowLinha("valor_parcela") * -1
                    oWorksheet.Range("L" & CStr(16 + iCont)).Value = oDataRowLinha("data_pagamento")
                    oWorksheet.Range("M" & CStr(16 + iCont)).Value = oDataRowLinha("valor_pago") * -1

                    oWorksheet.Range("E" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("F" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("H" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("I" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlCenter
                    oWorksheet.Range("J" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("L" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("M" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(16 + iCont)).Style = "Currency"
                    oWorksheet.Range("M" & CStr(16 + iCont)).Style = "Currency"

                    If sInicioGrupo = "" Then
                        sInicioGrupo = "E" & CStr(16 + iCont)
                    End If

                    iCont += 1
                    iGrupo += 1
                Next
                sTerminoGrupo = "E" & CStr(16 + (iCont - 1))

                oWorksheet.Range(sInicioGrupo, sTerminoGrupo).Rows.Group()
                iCont += 1
            Next


            oWorksheet.Range("B" & CStr(16 + iCont)).Value = "TOTAL SAÍDAS C.E.L."
            oWorksheet.Range("B" & CStr(16 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
            If sSoma <> "" Then
                oWorksheet.Range("C" & CStr(16 + iCont)).FormulaLocal = "=SOMA(" & sSoma & ")"
            End If

            oWorksheet.Range("C" & CStr(16 + iCont)).Style = "Currency"

            '*****************************************************************************************************************************'
            '                                                     ENTRADA NORSUL                                                        '
            '*****************************************************************************************************************************'
            sSoma = ""

            oWorksheet.Range("B" & CStr(18 + iCont), "D" & CStr(18 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(18 + iCont), "D" & CStr(18 + iCont)).Value = "DETALHAMENTO - NORSUL EMPREENDIMENTOS E ADM LTDA"
            oWorksheet.Range("B" & CStr(18 + iCont), "D" & CStr(18 + iCont)).Interior.Color = 16764057
            oWorksheet.Range("B" & CStr(18 + iCont), "D" & CStr(18 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(18 + iCont), "D" & CStr(18 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            oWorksheet.Range("B" & CStr(19 + iCont), "D" & CStr(19 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(19 + iCont), "D" & CStr(19 + iCont)).Value = "ENTRADAS"
            oWorksheet.Range("B" & CStr(19 + iCont), "D" & CStr(19 + iCont)).Interior.Color = 9868950
            oWorksheet.Range("B" & CStr(19 + iCont), "D" & CStr(19 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(19 + iCont), "D" & CStr(19 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            For Each oDataRow As DataRow In oDataSet.Tables(0).Rows
                'Dados
                If oDataRow("codigo_empresa") <> 1 Then
                    Continue For
                End If

                sCentroCusto = oDataRow("centro_custo")
                oWorksheet.Range("B" & CStr(20 + iCont)).Value = oDataRow("centro_custo")
                oWorksheet.Range("C" & CStr(20 + iCont)).Value = oDataRow("valor_total")
                oWorksheet.Range("B" & CStr(20 + iCont), "D" & CStr(20 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                oWorksheet.Range("C" & CStr(20 + iCont)).Style = "Currency"

                sSoma = IIf(sSoma = "", "C" & CStr(20 + iCont), sSoma & ";C" & CStr(20 + iCont))
                sInicioGrupo = ""
                sTerminoGrupo = ""
                For Each oDataRowLinha As DataRow In oDataSet.Tables(2).Rows
                    If oDataRowLinha("codigo_empresa") <> 1 Then
                        Continue For
                    End If

                    If sCentroCusto <> oDataRowLinha("centro_custo") Then
                        ' oWorksheet.Range("E" & CStr((12 + iCont) - iGrupo), "E" & CStr(12 + (iCont - 1))).Rows.Group()
                        'iGrupo += 1
                        Continue For
                    End If


                    oWorksheet.Range("E" & CStr(21 + iCont)).Value = oDataRowLinha("numero_documento")
                    oWorksheet.Range("F" & CStr(21 + iCont)).Value = oDataRowLinha("data_emissao")
                    oWorksheet.Range("G" & CStr(21 + iCont)).Value = oDataRowLinha("parceiro_negocio")
                    oWorksheet.Range("H" & CStr(21 + iCont)).Value = oDataRowLinha("descritivo")
                    oWorksheet.Range("I" & CStr(21 + iCont)).Value = oDataRowLinha("numero_parcela")
                    oWorksheet.Range("J" & CStr(21 + iCont)).Value = oDataRowLinha("data_vencimento")
                    oWorksheet.Range("K" & CStr(21 + iCont)).Value = oDataRowLinha("valor_parcela")
                    oWorksheet.Range("L" & CStr(21 + iCont)).Value = oDataRowLinha("data_pagamento")
                    oWorksheet.Range("M" & CStr(21 + iCont)).Value = oDataRowLinha("valor_pago")

                    oWorksheet.Range("E" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("F" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("H" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("I" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlCenter
                    oWorksheet.Range("J" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("L" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("M" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(21 + iCont)).Style = "Currency"
                    oWorksheet.Range("M" & CStr(21 + iCont)).Style = "Currency"

                    If sInicioGrupo = "" Then
                        sInicioGrupo = "E" & CStr(21 + iCont)
                    End If

                    iCont += 1
                    iGrupo += 1
                Next
                sTerminoGrupo = "E" & CStr(21 + (iCont - 1))

                oWorksheet.Range(sInicioGrupo, sTerminoGrupo).Rows.Group()
                iCont += 1
            Next


            oWorksheet.Range("B" & CStr(21 + iCont)).Value = "TOTAL ENTRADAS NORSUL"
            oWorksheet.Range("B" & CStr(21 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
            If sSoma <> "" Then
                oWorksheet.Range("C" & CStr(21 + iCont)).FormulaLocal = "=SOMA(" & sSoma & ")"
            End If

            oWorksheet.Range("C" & CStr(21 + iCont)).Style = "Currency"

            '*****************************************************************************************************************************'
            '                                                     SAÍDA NORSUL                                                         '
            '*****************************************************************************************************************************'
            sSoma = ""

            oWorksheet.Range("B" & CStr(23 + iCont), "D" & CStr(23 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(23 + iCont), "D" & CStr(23 + iCont)).Value = "SAÍDAS"
            oWorksheet.Range("B" & CStr(23 + iCont), "D" & CStr(23 + iCont)).Interior.Color = 9868950
            oWorksheet.Range("B" & CStr(23 + iCont), "D" & CStr(23 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(23 + iCont), "D" & CStr(23 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            For Each oDataRow As DataRow In oDataSet.Tables(1).Rows
                'Dados
                If oDataRow("codigo_empresa") <> 1 Then
                    Continue For
                End If

                sCentroCusto = oDataRow("centro_custo")
                oWorksheet.Range("B" & CStr(24 + iCont)).Value = oDataRow("centro_custo")
                oWorksheet.Range("C" & CStr(24 + iCont)).Value = oDataRow("valor_total") * -1
                oWorksheet.Range("B" & CStr(24 + iCont), "D" & CStr(24 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                oWorksheet.Range("C" & CStr(24 + iCont)).Style = "Currency"

                sSoma = IIf(sSoma = "", "C" & CStr(24 + iCont), sSoma & ";C" & CStr(24 + iCont))
                sInicioGrupo = ""
                sTerminoGrupo = ""
                For Each oDataRowLinha As DataRow In oDataSet.Tables(3).Rows
                    If oDataRowLinha("codigo_empresa") <> 1 Then
                        Continue For
                    End If

                    If sCentroCusto <> oDataRowLinha("centro_custo") Then
                        ' oWorksheet.Range("E" & CStr((12 + iCont) - iGrupo), "E" & CStr(12 + (iCont - 1))).Rows.Group()
                        'iGrupo += 1
                        Continue For
                    End If


                    oWorksheet.Range("E" & CStr(25 + iCont)).Value = oDataRowLinha("numero_documento")
                    oWorksheet.Range("F" & CStr(25 + iCont)).Value = oDataRowLinha("data_emissao")
                    oWorksheet.Range("G" & CStr(25 + iCont)).Value = oDataRowLinha("parceiro_negocio")
                    oWorksheet.Range("H" & CStr(25 + iCont)).Value = oDataRowLinha("descritivo")
                    oWorksheet.Range("I" & CStr(25 + iCont)).Value = oDataRowLinha("numero_parcela")
                    oWorksheet.Range("J" & CStr(25 + iCont)).Value = oDataRowLinha("data_vencimento")
                    oWorksheet.Range("K" & CStr(25 + iCont)).Value = oDataRowLinha("valor_parcela") * -1
                    oWorksheet.Range("L" & CStr(25 + iCont)).Value = oDataRowLinha("data_pagamento")
                    oWorksheet.Range("M" & CStr(25 + iCont)).Value = oDataRowLinha("valor_pago") * -1

                    oWorksheet.Range("E" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("F" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("H" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("I" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlCenter
                    oWorksheet.Range("J" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("L" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("M" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(25 + iCont)).Style = "Currency"
                    oWorksheet.Range("M" & CStr(25 + iCont)).Style = "Currency"

                    If sInicioGrupo = "" Then
                        sInicioGrupo = "E" & CStr(25 + iCont)
                    End If

                    iCont += 1
                    iGrupo += 1
                Next
                sTerminoGrupo = "E" & CStr(25 + (iCont - 1))

                oWorksheet.Range(sInicioGrupo, sTerminoGrupo).Rows.Group()
                iCont += 1
            Next


            oWorksheet.Range("B" & CStr(25 + iCont)).Value = "TOTAL SAÍDAS NORSUL"
            oWorksheet.Range("B" & CStr(25 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
            If sSoma <> "" Then
                oWorksheet.Range("C" & CStr(25 + iCont)).FormulaLocal = "=SOMA(" & sSoma & ")"
            End If

            oWorksheet.Range("C" & CStr(25 + iCont)).Style = "Currency"

            '*****************************************************************************************************************************'
            '                                                     ENTRADA GERMINEX                                                        '
            '*****************************************************************************************************************************'
            sSoma = ""

            oWorksheet.Range("B" & CStr(27 + iCont), "D" & CStr(27 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(27 + iCont), "D" & CStr(27 + iCont)).Value = "DETALHAMENTO - GERMINEX AGROPECUARIA LTDA"
            oWorksheet.Range("B" & CStr(27 + iCont), "D" & CStr(27 + iCont)).Interior.Color = 16764057
            oWorksheet.Range("B" & CStr(27 + iCont), "D" & CStr(27 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(27 + iCont), "D" & CStr(27 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            oWorksheet.Range("B" & CStr(28 + iCont), "D" & CStr(28 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(28 + iCont), "D" & CStr(28 + iCont)).Value = "ENTRADAS"
            oWorksheet.Range("B" & CStr(28 + iCont), "D" & CStr(28 + iCont)).Interior.Color = 9868950
            oWorksheet.Range("B" & CStr(28 + iCont), "D" & CStr(28 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(28 + iCont), "D" & CStr(28 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            For Each oDataRow As DataRow In oDataSet.Tables(0).Rows
                'Dados
                If oDataRow("codigo_empresa") <> 2 Then
                    Continue For
                End If

                sCentroCusto = oDataRow("centro_custo")
                oWorksheet.Range("B" & CStr(29 + iCont)).Value = oDataRow("centro_custo")
                oWorksheet.Range("C" & CStr(29 + iCont)).Value = oDataRow("valor_total")
                oWorksheet.Range("B" & CStr(29 + iCont), "D" & CStr(29 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                oWorksheet.Range("C" & CStr(29 + iCont)).Style = "Currency"

                sSoma = IIf(sSoma = "", "C" & CStr(29 + iCont), sSoma & ";C" & CStr(29 + iCont))
                sInicioGrupo = ""
                sTerminoGrupo = ""
                For Each oDataRowLinha As DataRow In oDataSet.Tables(2).Rows
                    If oDataRowLinha("codigo_empresa") <> 2 Then
                        Continue For
                    End If

                    If sCentroCusto <> oDataRowLinha("centro_custo") Then
                        ' oWorksheet.Range("E" & CStr((12 + iCont) - iGrupo), "E" & CStr(12 + (iCont - 1))).Rows.Group()
                        'iGrupo += 1
                        Continue For
                    End If


                    oWorksheet.Range("E" & CStr(30 + iCont)).Value = oDataRowLinha("numero_documento")
                    oWorksheet.Range("F" & CStr(30 + iCont)).Value = oDataRowLinha("data_emissao")
                    oWorksheet.Range("G" & CStr(30 + iCont)).Value = oDataRowLinha("parceiro_negocio")
                    oWorksheet.Range("H" & CStr(30 + iCont)).Value = oDataRowLinha("descritivo")
                    oWorksheet.Range("I" & CStr(30 + iCont)).Value = oDataRowLinha("numero_parcela")
                    oWorksheet.Range("J" & CStr(30 + iCont)).Value = oDataRowLinha("data_vencimento")
                    oWorksheet.Range("K" & CStr(30 + iCont)).Value = oDataRowLinha("valor_parcela")
                    oWorksheet.Range("L" & CStr(30 + iCont)).Value = oDataRowLinha("data_pagamento")
                    oWorksheet.Range("M" & CStr(30 + iCont)).Value = oDataRowLinha("valor_pago")

                    oWorksheet.Range("E" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("F" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("H" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("I" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlCenter
                    oWorksheet.Range("J" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("L" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("M" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(30 + iCont)).Style = "Currency"
                    oWorksheet.Range("M" & CStr(30 + iCont)).Style = "Currency"

                    If sInicioGrupo = "" Then
                        sInicioGrupo = "E" & CStr(30 + iCont)
                    End If

                    iCont += 1
                    iGrupo += 1
                Next
                sTerminoGrupo = "E" & CStr(30 + (iCont - 1))

                oWorksheet.Range(sInicioGrupo, sTerminoGrupo).Rows.Group()
                iCont += 1
            Next


            oWorksheet.Range("B" & CStr(30 + iCont)).Value = "TOTAL ENTRADAS GERMINEX"
            oWorksheet.Range("B" & CStr(30 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
            If sSoma <> "" Then
                oWorksheet.Range("C" & CStr(30 + iCont)).FormulaLocal = "=SOMA(" & sSoma & ")"
            End If

            oWorksheet.Range("C" & CStr(30 + iCont)).Style = "Currency"

            '*****************************************************************************************************************************'
            '                                                     SAÍDA GEMINEX                                                           '
            '*****************************************************************************************************************************'
            sSoma = ""

            oWorksheet.Range("B" & CStr(32 + iCont), "D" & CStr(32 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(32 + iCont), "D" & CStr(32 + iCont)).Value = "SAÍDAS"
            oWorksheet.Range("B" & CStr(32 + iCont), "D" & CStr(32 + iCont)).Interior.Color = 9868950
            oWorksheet.Range("B" & CStr(32 + iCont), "D" & CStr(32 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(32 + iCont), "D" & CStr(32 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            For Each oDataRow As DataRow In oDataSet.Tables(1).Rows
                'Dados
                If oDataRow("codigo_empresa") <> 2 Then
                    Continue For
                End If

                sCentroCusto = oDataRow("centro_custo")
                oWorksheet.Range("B" & CStr(33 + iCont)).Value = oDataRow("centro_custo")
                oWorksheet.Range("C" & CStr(33 + iCont)).Value = oDataRow("valor_total") * -1
                oWorksheet.Range("B" & CStr(33 + iCont), "D" & CStr(33 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                oWorksheet.Range("C" & CStr(33 + iCont)).Style = "Currency"

                sSoma = IIf(sSoma = "", "C" & CStr(33 + iCont), sSoma & ";C" & CStr(33 + iCont))
                sInicioGrupo = ""
                sTerminoGrupo = ""
                For Each oDataRowLinha As DataRow In oDataSet.Tables(3).Rows
                    If oDataRowLinha("codigo_empresa") <> 2 Then
                        Continue For
                    End If

                    If sCentroCusto <> oDataRowLinha("centro_custo") Then
                        ' oWorksheet.Range("E" & CStr((12 + iCont) - iGrupo), "E" & CStr(12 + (iCont - 1))).Rows.Group()
                        'iGrupo += 1
                        Continue For
                    End If


                    oWorksheet.Range("E" & CStr(34 + iCont)).Value = oDataRowLinha("numero_documento")
                    oWorksheet.Range("F" & CStr(34 + iCont)).Value = oDataRowLinha("data_emissao")
                    oWorksheet.Range("G" & CStr(34 + iCont)).Value = oDataRowLinha("parceiro_negocio")
                    oWorksheet.Range("H" & CStr(34 + iCont)).Value = oDataRowLinha("descritivo")
                    oWorksheet.Range("I" & CStr(34 + iCont)).Value = oDataRowLinha("numero_parcela")
                    oWorksheet.Range("J" & CStr(34 + iCont)).Value = oDataRowLinha("data_vencimento")
                    oWorksheet.Range("K" & CStr(34 + iCont)).Value = oDataRowLinha("valor_parcela") * -1
                    oWorksheet.Range("L" & CStr(34 + iCont)).Value = oDataRowLinha("data_pagamento")
                    oWorksheet.Range("M" & CStr(34 + iCont)).Value = oDataRowLinha("valor_pago") * -1

                    oWorksheet.Range("E" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("F" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("H" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("I" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlCenter
                    oWorksheet.Range("J" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("L" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("M" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(34 + iCont)).Style = "Currency"
                    oWorksheet.Range("M" & CStr(34 + iCont)).Style = "Currency"

                    If sInicioGrupo = "" Then
                        sInicioGrupo = "E" & CStr(34 + iCont)
                    End If

                    iCont += 1
                    iGrupo += 1
                Next
                sTerminoGrupo = "E" & CStr(34 + (iCont - 1))

                oWorksheet.Range(sInicioGrupo, sTerminoGrupo).Rows.Group()
                iCont += 1
            Next


            oWorksheet.Range("B" & CStr(34 + iCont)).Value = "TOTAL SAÍDAS GERMINEX"
            oWorksheet.Range("B" & CStr(34 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
            If sSoma <> "" Then
                oWorksheet.Range("C" & CStr(34 + iCont)).FormulaLocal = "=SOMA(" & sSoma & ")"
            End If

            oWorksheet.Range("C" & CStr(34 + iCont)).Style = "Currency"

            oWorksheet.Range("E11", "M11").Columns.Group()
            oWorksheet.Outline.ShowLevels(RowLevels:=1, ColumnLevels:=1)

            'oWorksheet.Range("D" & CStr(iContJD + 1), "H" & CStr(iContJD + 1)).Font.Bold = True
            'oWorksheet.Range("D" & CStr(iContJD + 1), "H" & CStr(iContJD + 1)).FormulaLocal = "=SOMA(D" & CStr(i) & ":D" & CStr(iContJD) & ")"
            'Dim iColOSDoc As Integer = iContJD + 1


            'oWorksheet.Columns.AutoFit()
            'oWorksheet.Range("D:W").ColumnWidth = 16
            'oWorksheet.Range("C:C").ColumnWidth = 30
            oWorksheet.Range("A:N").WrapText = False


        Catch ex As Exception
            Throw ex

        End Try
    End Sub

    Private Sub GerarPlanilhaWorksheetLavalpa(ByVal dDataEmissaoInicio As String, _
                                              ByVal dDataEmissaoTermino As String, _
                                              ByVal dDataVencimentoInicio As String, _
                                              ByVal dDataVencimentoTermino As String, _
                                              ByVal dDataPagamentoInicio As String, _
                                              ByVal dDataPagamentoTermino As String, _
                                              ByVal sCodigoCentroCusto As String, _
                                              ByVal bLavalpa As Integer, _
                                              ByVal bLeSix As Integer, _
                                              ByVal bMovimentacao As Boolean, _
                                              ByRef oWorksheet As Worksheet)
        Try
            'Variaveis Locais
            Dim oDataSet As DataSet
            Dim i As Integer = 0
            Dim oSqlParameter(14) As SqlParameter

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "movimentacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bMovimentacao : i += 1

            'Seta Parametros - Lavalpa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lavalpa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(bLavalpa = 2, DBNull.Value, IIf(bLavalpa = False, 0, 1)) : i += 1

            'Seta Parametros - Le Six
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "le_six"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(bLeSix = 2, DBNull.Value, IIf(bLeSix = False, 0, 1)) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataEmissaoInicio = "", DBNull.Value, dDataEmissaoInicio) : i = i + 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataEmissaoTermino = "", DBNull.Value, dDataEmissaoTermino) : i = i + 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataVencimentoInicio = "", DBNull.Value, dDataVencimentoInicio) : i = i + 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataVencimentoTermino = "", DBNull.Value, dDataVencimentoTermino) : i = i + 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataPagamentoInicio = "", DBNull.Value, dDataPagamentoInicio) : i = i + 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataPagamentoTermino = "", DBNull.Value, dDataPagamentoTermino) : i = i + 1

            'Seta Parametros - Centro Custo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoCentroCusto


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_fin000000010_excel_lavalpa", oSqlParameter)


            oWorksheet.Range("A:N").Font.Size = 8.5
            oWorksheet.Range("A:N").Font.Name = "Arial"
            ' oWorksheet.Range("A:N").WrapText = False

            oWorksheet.Range("B9", "D9").Merge()
            oWorksheet.Range("B9", "D9").Value = "DETALHAMENTO - CENTRO EMPRESARIAL LAVALPA LTDA"
            oWorksheet.Range("B9", "D9").Interior.Color = 16764057
            oWorksheet.Range("B9", "D9").Font.Bold = True
            oWorksheet.Range("B9", "D9").HorizontalAlignment = Excel.Constants.xlLeft

            oWorksheet.Range("B10", "D10").Merge()
            oWorksheet.Range("B10", "D10").Value = "ENTRADAS"
            oWorksheet.Range("B10", "D10").Interior.Color = 9868950
            oWorksheet.Range("B10", "D10").Font.Bold = True
            oWorksheet.Range("B10", "D10").HorizontalAlignment = Excel.Constants.xlLeft

            oWorksheet.Range("B11").Value = "Centro de Custo"
            oWorksheet.Range("B11").ColumnWidth = 30
            oWorksheet.Range("C11").Value = "Σ Valor Pago"
            oWorksheet.Range("C11").ColumnWidth = 14
            oWorksheet.Range("D11").Value = "Atividade"
            oWorksheet.Range("D11").ColumnWidth = 20
            oWorksheet.Range("E11").Value = "Nº Documento"
            oWorksheet.Range("E11").ColumnWidth = 14
            oWorksheet.Range("F11").Value = "Data Emissão"
            oWorksheet.Range("F11").ColumnWidth = 11
            oWorksheet.Range("G11").Value = "Parceiro de Negócio"
            oWorksheet.Range("G11").ColumnWidth = 35
            oWorksheet.Range("H11").Value = "Descritivo"
            oWorksheet.Range("H11").ColumnWidth = 43
            oWorksheet.Range("I11").Value = "Parcela"
            oWorksheet.Range("I11").ColumnWidth = 7
            oWorksheet.Range("J11").Value = "Data Vencimento"
            oWorksheet.Range("J11").ColumnWidth = 11
            oWorksheet.Range("K11").Value = "Valor Parcela"
            oWorksheet.Range("K11").ColumnWidth = 12
            oWorksheet.Range("L11").Value = "Data Pagamento"
            oWorksheet.Range("L11").ColumnWidth = 11
            oWorksheet.Range("M11").Value = "Valor Pago"
            oWorksheet.Range("M11").ColumnWidth = 13
            oWorksheet.Range("A:M").RowHeight = 11.25


            'oWorksheet.Range("C:V").Font.Size = 10
            'oWorksheet.Range("D:W").WrapText = True
            'oWorksheet.Range("D:W").ColumnWidth = 15.43

            'Dim iContJD As Integer = 4
            'Dim sInadimplencia As String = "=SOMA("
            '*****************************************************************************************************************************'
            '                                                     ENTRADA LAVALPA                                                         '
            '*****************************************************************************************************************************'
            Dim iCont As Integer = 1
            Dim iGrupo As Integer = 1
            Dim sInicioGrupo As String = ""
            Dim sTerminoGrupo As String = ""
            Dim sCentroCusto As String = ""
            Dim sSoma As String = ""
            For Each oDataRow As DataRow In oDataSet.Tables(0).Rows
                'Dados
                If oDataRow("codigo_empresa") <> 4 Then
                    Continue For
                End If

                sCentroCusto = oDataRow("centro_custo")
                oWorksheet.Range("B" & CStr(11 + iCont)).Value = oDataRow("centro_custo")
                oWorksheet.Range("C" & CStr(11 + iCont)).Value = oDataRow("valor_total")
                oWorksheet.Range("B" & CStr(11 + iCont), "D" & CStr(11 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                oWorksheet.Range("C" & CStr(11 + iCont)).Style = "Currency"

                sSoma = IIf(sSoma = "", "C" & CStr(11 + iCont), sSoma & ";C" & CStr(11 + iCont))
                sInicioGrupo = ""
                sTerminoGrupo = ""
                For Each oDataRowLinha As DataRow In oDataSet.Tables(2).Rows
                    If oDataRowLinha("codigo_empresa") <> 4 Then
                        Continue For
                    End If

                    If sCentroCusto <> oDataRowLinha("centro_custo") Then
                        ' oWorksheet.Range("E" & CStr((12 + iCont) - iGrupo), "E" & CStr(12 + (iCont - 1))).Rows.Group()
                        'iGrupo += 1
                        Continue For
                    End If


                    oWorksheet.Range("E" & CStr(12 + iCont)).Value = oDataRowLinha("numero_documento")
                    oWorksheet.Range("F" & CStr(12 + iCont)).Value = oDataRowLinha("data_emissao")
                    oWorksheet.Range("G" & CStr(12 + iCont)).Value = oDataRowLinha("parceiro_negocio")
                    oWorksheet.Range("H" & CStr(12 + iCont)).Value = oDataRowLinha("descritivo")
                    oWorksheet.Range("I" & CStr(12 + iCont)).Value = oDataRowLinha("numero_parcela")
                    oWorksheet.Range("J" & CStr(12 + iCont)).Value = oDataRowLinha("data_vencimento")
                    oWorksheet.Range("K" & CStr(12 + iCont)).Value = oDataRowLinha("valor_parcela")
                    oWorksheet.Range("L" & CStr(12 + iCont)).Value = oDataRowLinha("data_pagamento")
                    oWorksheet.Range("M" & CStr(12 + iCont)).Value = oDataRowLinha("valor_pago")

                    oWorksheet.Range("E" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("F" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("H" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("I" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlCenter
                    oWorksheet.Range("J" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("L" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("M" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(12 + iCont)).Style = "Currency"
                    oWorksheet.Range("M" & CStr(12 + iCont)).Style = "Currency"

                    If sInicioGrupo = "" Then
                        sInicioGrupo = "E" & CStr(12 + iCont)
                    End If

                    iCont += 1
                    iGrupo += 1
                Next
                sTerminoGrupo = "E" & CStr(12 + (iCont - 1))

                oWorksheet.Range(sInicioGrupo, sTerminoGrupo).Rows.Group()
                iCont += 1
            Next


            oWorksheet.Range("B" & CStr(12 + iCont)).Value = "TOTAL ENTRADAS C.E.L."
            oWorksheet.Range("B" & CStr(12 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(12 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
            If sSoma <> "" Then
                oWorksheet.Range("C" & CStr(12 + iCont)).FormulaLocal = "=SOMA(" & sSoma & ")"
            End If
            oWorksheet.Range("C" & CStr(12 + iCont)).Style = "Currency"

            '*****************************************************************************************************************************'
            '                                                     SAÍDA LAVALPA                                                         '
            '*****************************************************************************************************************************'
            sSoma = ""

            oWorksheet.Range("B" & CStr(14 + iCont), "D" & CStr(14 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(14 + iCont), "D" & CStr(14 + iCont)).Value = "SAÍDAS"
            oWorksheet.Range("B" & CStr(14 + iCont), "D" & CStr(14 + iCont)).Interior.Color = 9868950
            oWorksheet.Range("B" & CStr(14 + iCont), "D" & CStr(14 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(14 + iCont), "D" & CStr(14 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            For Each oDataRow As DataRow In oDataSet.Tables(1).Rows
                'Dados
                If oDataRow("codigo_empresa") <> 4 Then
                    Continue For
                End If

                sCentroCusto = oDataRow("centro_custo")
                oWorksheet.Range("B" & CStr(15 + iCont)).Value = oDataRow("centro_custo")
                oWorksheet.Range("C" & CStr(15 + iCont)).Value = oDataRow("valor_total") * -1
                oWorksheet.Range("B" & CStr(15 + iCont), "D" & CStr(15 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                oWorksheet.Range("C" & CStr(15 + iCont)).Style = "Currency"

                sSoma = IIf(sSoma = "", "C" & CStr(15 + iCont), sSoma & ";C" & CStr(15 + iCont))
                sInicioGrupo = ""
                sTerminoGrupo = ""
                For Each oDataRowLinha As DataRow In oDataSet.Tables(3).Rows
                    If oDataRowLinha("codigo_empresa") <> 4 Then
                        Continue For
                    End If

                    If sCentroCusto <> oDataRowLinha("centro_custo") Then
                        ' oWorksheet.Range("E" & CStr((12 + iCont) - iGrupo), "E" & CStr(12 + (iCont - 1))).Rows.Group()
                        'iGrupo += 1
                        Continue For
                    End If


                    oWorksheet.Range("E" & CStr(16 + iCont)).Value = oDataRowLinha("numero_documento")
                    oWorksheet.Range("F" & CStr(16 + iCont)).Value = oDataRowLinha("data_emissao")
                    oWorksheet.Range("G" & CStr(16 + iCont)).Value = oDataRowLinha("parceiro_negocio")
                    oWorksheet.Range("H" & CStr(16 + iCont)).Value = oDataRowLinha("descritivo")
                    oWorksheet.Range("I" & CStr(16 + iCont)).Value = oDataRowLinha("numero_parcela")
                    oWorksheet.Range("J" & CStr(16 + iCont)).Value = oDataRowLinha("data_vencimento")
                    oWorksheet.Range("K" & CStr(16 + iCont)).Value = oDataRowLinha("valor_parcela") * -1
                    oWorksheet.Range("L" & CStr(16 + iCont)).Value = oDataRowLinha("data_pagamento")
                    oWorksheet.Range("M" & CStr(16 + iCont)).Value = oDataRowLinha("valor_pago") * -1

                    oWorksheet.Range("E" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("F" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("H" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("I" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlCenter
                    oWorksheet.Range("J" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("L" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("M" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(16 + iCont)).Style = "Currency"
                    oWorksheet.Range("M" & CStr(16 + iCont)).Style = "Currency"

                    If sInicioGrupo = "" Then
                        sInicioGrupo = "E" & CStr(16 + iCont)
                    End If

                    iCont += 1
                    iGrupo += 1
                Next
                sTerminoGrupo = "E" & CStr(16 + (iCont - 1))

                oWorksheet.Range(sInicioGrupo, sTerminoGrupo).Rows.Group()
                iCont += 1
            Next


            oWorksheet.Range("B" & CStr(16 + iCont)).Value = "TOTAL SAÍDAS C.E.L."
            oWorksheet.Range("B" & CStr(16 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(16 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
            If sSoma <> "" Then
                oWorksheet.Range("C" & CStr(16 + iCont)).FormulaLocal = "=SOMA(" & sSoma & ")"
            End If

            oWorksheet.Range("C" & CStr(16 + iCont)).Style = "Currency"

            '*****************************************************************************************************************************'
            '                                                     ENTRADA NORSUL                                                        '
            '*****************************************************************************************************************************'
            sSoma = ""

            oWorksheet.Range("B" & CStr(18 + iCont), "D" & CStr(18 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(18 + iCont), "D" & CStr(18 + iCont)).Value = "DETALHAMENTO - NORSUL EMPREENDIMENTOS E ADM LTDA"
            oWorksheet.Range("B" & CStr(18 + iCont), "D" & CStr(18 + iCont)).Interior.Color = 16764057
            oWorksheet.Range("B" & CStr(18 + iCont), "D" & CStr(18 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(18 + iCont), "D" & CStr(18 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            oWorksheet.Range("B" & CStr(19 + iCont), "D" & CStr(19 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(19 + iCont), "D" & CStr(19 + iCont)).Value = "ENTRADAS"
            oWorksheet.Range("B" & CStr(19 + iCont), "D" & CStr(19 + iCont)).Interior.Color = 9868950
            oWorksheet.Range("B" & CStr(19 + iCont), "D" & CStr(19 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(19 + iCont), "D" & CStr(19 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            For Each oDataRow As DataRow In oDataSet.Tables(0).Rows
                'Dados
                If oDataRow("codigo_empresa") <> 1 Then
                    Continue For
                End If

                sCentroCusto = oDataRow("centro_custo")
                oWorksheet.Range("B" & CStr(20 + iCont)).Value = oDataRow("centro_custo")
                oWorksheet.Range("C" & CStr(20 + iCont)).Value = oDataRow("valor_total")
                oWorksheet.Range("B" & CStr(20 + iCont), "D" & CStr(20 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                oWorksheet.Range("C" & CStr(20 + iCont)).Style = "Currency"

                sSoma = IIf(sSoma = "", "C" & CStr(20 + iCont), sSoma & ";C" & CStr(20 + iCont))
                sInicioGrupo = ""
                sTerminoGrupo = ""
                For Each oDataRowLinha As DataRow In oDataSet.Tables(2).Rows
                    If oDataRowLinha("codigo_empresa") <> 1 Then
                        Continue For
                    End If

                    If sCentroCusto <> oDataRowLinha("centro_custo") Then
                        ' oWorksheet.Range("E" & CStr((12 + iCont) - iGrupo), "E" & CStr(12 + (iCont - 1))).Rows.Group()
                        'iGrupo += 1
                        Continue For
                    End If


                    oWorksheet.Range("E" & CStr(21 + iCont)).Value = oDataRowLinha("numero_documento")
                    oWorksheet.Range("F" & CStr(21 + iCont)).Value = oDataRowLinha("data_emissao")
                    oWorksheet.Range("G" & CStr(21 + iCont)).Value = oDataRowLinha("parceiro_negocio")
                    oWorksheet.Range("H" & CStr(21 + iCont)).Value = oDataRowLinha("descritivo")
                    oWorksheet.Range("I" & CStr(21 + iCont)).Value = oDataRowLinha("numero_parcela")
                    oWorksheet.Range("J" & CStr(21 + iCont)).Value = oDataRowLinha("data_vencimento")
                    oWorksheet.Range("K" & CStr(21 + iCont)).Value = oDataRowLinha("valor_parcela")
                    oWorksheet.Range("L" & CStr(21 + iCont)).Value = oDataRowLinha("data_pagamento")
                    oWorksheet.Range("M" & CStr(21 + iCont)).Value = oDataRowLinha("valor_pago")

                    oWorksheet.Range("E" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("F" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("H" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("I" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlCenter
                    oWorksheet.Range("J" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("L" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("M" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(21 + iCont)).Style = "Currency"
                    oWorksheet.Range("M" & CStr(21 + iCont)).Style = "Currency"

                    If sInicioGrupo = "" Then
                        sInicioGrupo = "E" & CStr(21 + iCont)
                    End If

                    iCont += 1
                    iGrupo += 1
                Next
                sTerminoGrupo = "E" & CStr(21 + (iCont - 1))

                oWorksheet.Range(sInicioGrupo, sTerminoGrupo).Rows.Group()
                iCont += 1
            Next


            oWorksheet.Range("B" & CStr(21 + iCont)).Value = "TOTAL ENTRADAS NORSUL"
            oWorksheet.Range("B" & CStr(21 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(21 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
            If sSoma <> "" Then
                oWorksheet.Range("C" & CStr(21 + iCont)).FormulaLocal = "=SOMA(" & sSoma & ")"
            End If

            oWorksheet.Range("C" & CStr(21 + iCont)).Style = "Currency"

            '*****************************************************************************************************************************'
            '                                                     SAÍDA NORSUL                                                         '
            '*****************************************************************************************************************************'
            sSoma = ""

            oWorksheet.Range("B" & CStr(23 + iCont), "D" & CStr(23 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(23 + iCont), "D" & CStr(23 + iCont)).Value = "SAÍDAS"
            oWorksheet.Range("B" & CStr(23 + iCont), "D" & CStr(23 + iCont)).Interior.Color = 9868950
            oWorksheet.Range("B" & CStr(23 + iCont), "D" & CStr(23 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(23 + iCont), "D" & CStr(23 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            For Each oDataRow As DataRow In oDataSet.Tables(1).Rows
                'Dados
                If oDataRow("codigo_empresa") <> 1 Then
                    Continue For
                End If

                sCentroCusto = oDataRow("centro_custo")
                oWorksheet.Range("B" & CStr(24 + iCont)).Value = oDataRow("centro_custo")
                oWorksheet.Range("C" & CStr(24 + iCont)).Value = oDataRow("valor_total") * -1
                oWorksheet.Range("B" & CStr(24 + iCont), "D" & CStr(24 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                oWorksheet.Range("C" & CStr(24 + iCont)).Style = "Currency"

                sSoma = IIf(sSoma = "", "C" & CStr(24 + iCont), sSoma & ";C" & CStr(24 + iCont))
                sInicioGrupo = ""
                sTerminoGrupo = ""
                For Each oDataRowLinha As DataRow In oDataSet.Tables(3).Rows
                    If oDataRowLinha("codigo_empresa") <> 1 Then
                        Continue For
                    End If

                    If sCentroCusto <> oDataRowLinha("centro_custo") Then
                        ' oWorksheet.Range("E" & CStr((12 + iCont) - iGrupo), "E" & CStr(12 + (iCont - 1))).Rows.Group()
                        'iGrupo += 1
                        Continue For
                    End If


                    oWorksheet.Range("E" & CStr(25 + iCont)).Value = oDataRowLinha("numero_documento")
                    oWorksheet.Range("F" & CStr(25 + iCont)).Value = oDataRowLinha("data_emissao")
                    oWorksheet.Range("G" & CStr(25 + iCont)).Value = oDataRowLinha("parceiro_negocio")
                    oWorksheet.Range("H" & CStr(25 + iCont)).Value = oDataRowLinha("descritivo")
                    oWorksheet.Range("I" & CStr(25 + iCont)).Value = oDataRowLinha("numero_parcela")
                    oWorksheet.Range("J" & CStr(25 + iCont)).Value = oDataRowLinha("data_vencimento")
                    oWorksheet.Range("K" & CStr(25 + iCont)).Value = oDataRowLinha("valor_parcela") * -1
                    oWorksheet.Range("L" & CStr(25 + iCont)).Value = oDataRowLinha("data_pagamento")
                    oWorksheet.Range("M" & CStr(25 + iCont)).Value = oDataRowLinha("valor_pago") * -1

                    oWorksheet.Range("E" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("F" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("H" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("I" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlCenter
                    oWorksheet.Range("J" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("L" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("M" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(25 + iCont)).Style = "Currency"
                    oWorksheet.Range("M" & CStr(25 + iCont)).Style = "Currency"

                    If sInicioGrupo = "" Then
                        sInicioGrupo = "E" & CStr(25 + iCont)
                    End If

                    iCont += 1
                    iGrupo += 1
                Next
                sTerminoGrupo = "E" & CStr(25 + (iCont - 1))

                oWorksheet.Range(sInicioGrupo, sTerminoGrupo).Rows.Group()
                iCont += 1
            Next


            oWorksheet.Range("B" & CStr(25 + iCont)).Value = "TOTAL SAÍDAS NORSUL"
            oWorksheet.Range("B" & CStr(25 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(25 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
            If sSoma <> "" Then
                oWorksheet.Range("C" & CStr(25 + iCont)).FormulaLocal = "=SOMA(" & sSoma & ")"
            End If

            oWorksheet.Range("C" & CStr(25 + iCont)).Style = "Currency"

            '*****************************************************************************************************************************'
            '                                                     ENTRADA GERMINEX                                                        '
            '*****************************************************************************************************************************'
            sSoma = ""

            oWorksheet.Range("B" & CStr(27 + iCont), "D" & CStr(27 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(27 + iCont), "D" & CStr(27 + iCont)).Value = "DETALHAMENTO - GERMINEX AGROPECUARIA LTDA"
            oWorksheet.Range("B" & CStr(27 + iCont), "D" & CStr(27 + iCont)).Interior.Color = 16764057
            oWorksheet.Range("B" & CStr(27 + iCont), "D" & CStr(27 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(27 + iCont), "D" & CStr(27 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            oWorksheet.Range("B" & CStr(28 + iCont), "D" & CStr(28 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(28 + iCont), "D" & CStr(28 + iCont)).Value = "ENTRADAS"
            oWorksheet.Range("B" & CStr(28 + iCont), "D" & CStr(28 + iCont)).Interior.Color = 9868950
            oWorksheet.Range("B" & CStr(28 + iCont), "D" & CStr(28 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(28 + iCont), "D" & CStr(28 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            For Each oDataRow As DataRow In oDataSet.Tables(0).Rows
                'Dados
                If oDataRow("codigo_empresa") <> 2 Then
                    Continue For
                End If

                sCentroCusto = oDataRow("centro_custo")
                oWorksheet.Range("B" & CStr(29 + iCont)).Value = oDataRow("centro_custo")
                oWorksheet.Range("C" & CStr(29 + iCont)).Value = oDataRow("valor_total")
                oWorksheet.Range("B" & CStr(29 + iCont), "D" & CStr(29 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                oWorksheet.Range("C" & CStr(29 + iCont)).Style = "Currency"

                sSoma = IIf(sSoma = "", "C" & CStr(29 + iCont), sSoma & ";C" & CStr(29 + iCont))
                sInicioGrupo = ""
                sTerminoGrupo = ""
                For Each oDataRowLinha As DataRow In oDataSet.Tables(2).Rows
                    If oDataRowLinha("codigo_empresa") <> 2 Then
                        Continue For
                    End If

                    If sCentroCusto <> oDataRowLinha("centro_custo") Then
                        ' oWorksheet.Range("E" & CStr((12 + iCont) - iGrupo), "E" & CStr(12 + (iCont - 1))).Rows.Group()
                        'iGrupo += 1
                        Continue For
                    End If


                    oWorksheet.Range("E" & CStr(30 + iCont)).Value = oDataRowLinha("numero_documento")
                    oWorksheet.Range("F" & CStr(30 + iCont)).Value = oDataRowLinha("data_emissao")
                    oWorksheet.Range("G" & CStr(30 + iCont)).Value = oDataRowLinha("parceiro_negocio")
                    oWorksheet.Range("H" & CStr(30 + iCont)).Value = oDataRowLinha("descritivo")
                    oWorksheet.Range("I" & CStr(30 + iCont)).Value = oDataRowLinha("numero_parcela")
                    oWorksheet.Range("J" & CStr(30 + iCont)).Value = oDataRowLinha("data_vencimento")
                    oWorksheet.Range("K" & CStr(30 + iCont)).Value = oDataRowLinha("valor_parcela")
                    oWorksheet.Range("L" & CStr(30 + iCont)).Value = oDataRowLinha("data_pagamento")
                    oWorksheet.Range("M" & CStr(30 + iCont)).Value = oDataRowLinha("valor_pago")

                    oWorksheet.Range("E" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("F" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("H" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("I" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlCenter
                    oWorksheet.Range("J" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("L" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("M" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(30 + iCont)).Style = "Currency"
                    oWorksheet.Range("M" & CStr(30 + iCont)).Style = "Currency"

                    If sInicioGrupo = "" Then
                        sInicioGrupo = "E" & CStr(30 + iCont)
                    End If

                    iCont += 1
                    iGrupo += 1
                Next
                sTerminoGrupo = "E" & CStr(30 + (iCont - 1))

                oWorksheet.Range(sInicioGrupo, sTerminoGrupo).Rows.Group()
                iCont += 1
            Next


            oWorksheet.Range("B" & CStr(30 + iCont)).Value = "TOTAL ENTRADAS GERMINEX"
            oWorksheet.Range("B" & CStr(30 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(30 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
            If sSoma <> "" Then
                oWorksheet.Range("C" & CStr(30 + iCont)).FormulaLocal = "=SOMA(" & sSoma & ")"
            End If

            oWorksheet.Range("C" & CStr(30 + iCont)).Style = "Currency"

            '*****************************************************************************************************************************'
            '                                                     SAÍDA GEMINEX                                                           '
            '*****************************************************************************************************************************'
            sSoma = ""

            oWorksheet.Range("B" & CStr(32 + iCont), "D" & CStr(32 + iCont)).Merge()
            oWorksheet.Range("B" & CStr(32 + iCont), "D" & CStr(32 + iCont)).Value = "SAÍDAS"
            oWorksheet.Range("B" & CStr(32 + iCont), "D" & CStr(32 + iCont)).Interior.Color = 9868950
            oWorksheet.Range("B" & CStr(32 + iCont), "D" & CStr(32 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(32 + iCont), "D" & CStr(32 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft

            For Each oDataRow As DataRow In oDataSet.Tables(1).Rows
                'Dados
                If oDataRow("codigo_empresa") <> 2 Then
                    Continue For
                End If

                sCentroCusto = oDataRow("centro_custo")
                oWorksheet.Range("B" & CStr(33 + iCont)).Value = oDataRow("centro_custo")
                oWorksheet.Range("C" & CStr(33 + iCont)).Value = oDataRow("valor_total") * -1
                oWorksheet.Range("B" & CStr(33 + iCont), "D" & CStr(33 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                oWorksheet.Range("C" & CStr(33 + iCont)).Style = "Currency"

                sSoma = IIf(sSoma = "", "C" & CStr(33 + iCont), sSoma & ";C" & CStr(33 + iCont))
                sInicioGrupo = ""
                sTerminoGrupo = ""
                For Each oDataRowLinha As DataRow In oDataSet.Tables(3).Rows
                    If oDataRowLinha("codigo_empresa") <> 2 Then
                        Continue For
                    End If

                    If sCentroCusto <> oDataRowLinha("centro_custo") Then
                        ' oWorksheet.Range("E" & CStr((12 + iCont) - iGrupo), "E" & CStr(12 + (iCont - 1))).Rows.Group()
                        'iGrupo += 1
                        Continue For
                    End If


                    oWorksheet.Range("E" & CStr(34 + iCont)).Value = oDataRowLinha("numero_documento")
                    oWorksheet.Range("F" & CStr(34 + iCont)).Value = oDataRowLinha("data_emissao")
                    oWorksheet.Range("G" & CStr(34 + iCont)).Value = oDataRowLinha("parceiro_negocio")
                    oWorksheet.Range("H" & CStr(34 + iCont)).Value = oDataRowLinha("descritivo")
                    oWorksheet.Range("I" & CStr(34 + iCont)).Value = oDataRowLinha("numero_parcela")
                    oWorksheet.Range("J" & CStr(34 + iCont)).Value = oDataRowLinha("data_vencimento")
                    oWorksheet.Range("K" & CStr(34 + iCont)).Value = oDataRowLinha("valor_parcela") * -1
                    oWorksheet.Range("L" & CStr(34 + iCont)).Value = oDataRowLinha("data_pagamento")
                    oWorksheet.Range("M" & CStr(34 + iCont)).Value = oDataRowLinha("valor_pago") * -1

                    oWorksheet.Range("E" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("F" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("H" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
                    oWorksheet.Range("I" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlCenter
                    oWorksheet.Range("J" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("L" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("M" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlRight
                    oWorksheet.Range("K" & CStr(34 + iCont)).Style = "Currency"
                    oWorksheet.Range("M" & CStr(34 + iCont)).Style = "Currency"

                    If sInicioGrupo = "" Then
                        sInicioGrupo = "E" & CStr(34 + iCont)
                    End If

                    iCont += 1
                    iGrupo += 1
                Next
                sTerminoGrupo = "E" & CStr(34 + (iCont - 1))

                oWorksheet.Range(sInicioGrupo, sTerminoGrupo).Rows.Group()
                iCont += 1
            Next


            oWorksheet.Range("B" & CStr(34 + iCont)).Value = "TOTAL SAÍDAS GERMINEX"
            oWorksheet.Range("B" & CStr(34 + iCont)).Font.Bold = True
            oWorksheet.Range("B" & CStr(34 + iCont)).HorizontalAlignment = Excel.Constants.xlLeft
            If sSoma <> "" Then
                oWorksheet.Range("C" & CStr(34 + iCont)).FormulaLocal = "=SOMA(" & sSoma & ")"
            End If

            oWorksheet.Range("C" & CStr(34 + iCont)).Style = "Currency"

            oWorksheet.Range("E11", "M11").Columns.Group()
            oWorksheet.Outline.ShowLevels(RowLevels:=1, ColumnLevels:=1)

            'oWorksheet.Range("D" & CStr(iContJD + 1), "H" & CStr(iContJD + 1)).Font.Bold = True
            'oWorksheet.Range("D" & CStr(iContJD + 1), "H" & CStr(iContJD + 1)).FormulaLocal = "=SOMA(D" & CStr(i) & ":D" & CStr(iContJD) & ")"
            'Dim iColOSDoc As Integer = iContJD + 1


            'oWorksheet.Columns.AutoFit()
            'oWorksheet.Range("D:W").ColumnWidth = 16
            'oWorksheet.Range("C:C").ColumnWidth = 30
            oWorksheet.Range("A:N").WrapText = False


        Catch ex As Exception
            Throw ex

        End Try
    End Sub

#End Region

End Class
