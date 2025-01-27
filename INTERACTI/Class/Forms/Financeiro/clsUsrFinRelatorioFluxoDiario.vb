Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrFinRelatorioFluxoDiario

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As Janus.Windows.GridEX.GridEX, _
                        ByVal dDataPagamentoInicio As Date, _
                        ByVal dDataPagamentoTermino As Date)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oGridExColumn As GridEXColumn

        Dim oSqlParameter(2) As SqlParameter
        Dim oDataSet As New DataSet
        Try


            dDataPagamentoInicio = CDate(Format(dDataPagamentoInicio, "dd/MM/yyyy") & " 00:00:00")
            dDataPagamentoTermino = CDate(Format(dDataPagamentoTermino, "dd/MM/yyyy") & " 23:59:59")

            'Seta Parametros - Data Emissão Início
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "data_pagamento_inicio"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.DateTime
            oSqlParameter(0).Value = dDataPagamentoInicio

            'Seta Parametros - Data Emissão Término
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_pagamento_termino"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.DateTime
            oSqlParameter(1).Value = dDataPagamentoTermino


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_relatorio_sonaca_diario", oSqlParameter)

            With oGrid

                'Limpando os grupos e colunas
                .RootTable.FormatConditions.Clear()
                .RootTable.Groups.Clear()
                .RootTable.Columns.Clear()
                .GroupTotals = GroupTotals.Always
                .TotalRow = InheritableBoolean.False

                oGridExColumn = New GridEXColumn("codigo")
                oGridExColumn.Caption = "Tipo"
                .RootTable.Columns.Add(oGridExColumn)


                'Configurando os datamembers
                ConfigurarDataMemberGrid(oGrid)

                'Setando o valor do datasource
                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

       
                Dim dData As Date
                'Laço de repetição para inserir os dias
                For iCont As Integer = 0 To DateDiff(DateInterval.Day, CDate(Format(dDataPagamentoInicio, "dd/MM/yyyy")), CDate(Format(dDataPagamentoTermino, "dd/MM/yyyy")))

                    'Configurando a data
                    dData = DateAdd(DateInterval.Day, iCont, dDataPagamentoInicio)

                    'Adicionando a coluna
                    oDataSet.Tables(0).Columns.Add(Format(dData, "dd/MM/yyyy"), GetType(Double))

                    'Adicionando a coluna na grid
                    oGridExColumn = New GridEXColumn(Format(dData, "dd/MM/yyyy"))
                    oGridExColumn.Caption = Format(dData, "dd/MM/yyyy")
                    oGridExColumn.FormatString = "#,#0.00"
                    oGridExColumn.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                    oGridExColumn.TotalFormatString = "#,#0.00"
                    oGridExColumn.AggregateFunction = AggregateFunction.Sum
                    .RootTable.Columns.Add(oGridExColumn)
                Next



                ''Adicionando mais uma coluna de total
                'oDataSet.Tables(0).Columns.Add("total", GetType(Double))
                ''Adicionando a coluna na grid
                'oGridExColumn = New GridEXColumn("total")
                'oGridExColumn.Caption = "Total"
                'oGridExColumn.CellStyle.FontBold = TriState.True
                'oGridExColumn.FormatString = "0.00"
                'oGridExColumn.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                'oGridExColumn.TotalFormatString = "0.00"
                'oGridExColumn.AggregateFunction = AggregateFunction.Sum
                '.RootTable.Columns.Add(oGridExColumn)



                'Setando o valor do datasource
                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName


                Dim oFormatCondition As GridEXFormatCondition

                oFormatCondition = New GridEXFormatCondition(.RootTable.Columns("codigo"), ConditionOperator.Contains, "SALDO FINAL")
                oFormatCondition.FormatStyle.FontBold = TriState.True
                .RootTable.FormatConditions.Add(oFormatCondition)

                oFormatCondition = New GridEXFormatCondition(.RootTable.Columns("codigo"), ConditionOperator.Contains, "DESPESA")
                oFormatCondition.FormatStyle.BackColor = Color.IndianRed
                .RootTable.FormatConditions.Add(oFormatCondition)

                oFormatCondition = New GridEXFormatCondition(.RootTable.Columns("codigo"), ConditionOperator.Contains, "EMPRÉSTIMO")
                oFormatCondition.FormatStyle.BackColor = Color.IndianRed
                .RootTable.FormatConditions.Add(oFormatCondition)

                oFormatCondition = New GridEXFormatCondition(.RootTable.Columns("codigo"), ConditionOperator.Contains, "RECEITA")
                oFormatCondition.FormatStyle.BackColor = Color.SteelBlue
                .RootTable.FormatConditions.Add(oFormatCondition)



                'Abrindo um recordset para setar os valores dos dias
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_relatorio_sonaca_diario_valores", oSqlParameter)

                Dim sChave As String = ""
                Dim dTotal As Double = 0
                While oSqlDataReader.Read

                    'Se for um código diferente
                    If sChave <> oSqlDataReader.Item("codigo") Then
                        sChave = oSqlDataReader.Item("codigo")

                        'Encontrando a linha
                        .FindAll(.RootTable.Columns("codigo"), ConditionOperator.Equal, sChave)

                        'Inserindo o valor total
                        '.SetValue("total", dTotal)

                        'Zerando
                        dTotal = 0
                    End If

                    dTotal += oSqlDataReader.Item("valor")
                    'Setando o valor
                    .SetValue(CStr(oSqlDataReader.Item("data")), oSqlDataReader.Item("valor"))

                End While

                'Fechando o recordset
                oSqlDataReader.Close()




                Dim dSaldoInicial As Double = 0
                Dim dSaldoFinal As Double
                Dim dDespesa As Double
                Dim dReceita As Double
                Dim dEmprestimo As Double

                'Percorrendo todos os dias
                For iCont As Integer = 0 To DateDiff(DateInterval.Day, CDate(Format(dDataPagamentoInicio, "dd/MM/yyyy")), CDate(Format(dDataPagamentoTermino, "dd/MM/yyyy")))
                    Dim iCol As Integer = iCont + 1

                    'Agora será atualizado o saldo diário
                    .FindAll(.RootTable.Columns("codigo"), ConditionOperator.Equal, "SALDO INICIAL")

                    If dSaldoInicial = 0 Then
                        'Setando o valor
                        dSaldoInicial = ExecuteScalar(goDatabase.sConnection, CommandType.Text, "SELECT dbo.fn_saldo_inicial(1,'" & Format(CDate(.RootTable.Columns(iCol).Key), "dd/MM/yyyy") & "')")
                    Else
                        dSaldoInicial = dSaldoFinal
                    End If

                    'Setando o valor 
                    .SetValue(iCol, dSaldoInicial)

                    'Recebendo os valores
                    dDespesa = IIf(IsDBNull(.GetRow(1).Cells.Item(iCol).Value), 0, .GetRow(1).Cells.Item(iCol).Value)
                    dEmprestimo = IIf(IsDBNull(.GetRow(2).Cells.Item(iCol).Value), 0, .GetRow(2).Cells.Item(iCol).Value)
                    dReceita = IIf(IsDBNull(.GetRow(3).Cells.Item(iCol).Value), 0, .GetRow(3).Cells.Item(iCol).Value)

                    'Calculando o valor
                    dSaldoFinal = dSaldoInicial - (dDespesa + dEmprestimo) + dReceita

                    'Agora será atualizado o saldo diário
                    .FindAll(.RootTable.Columns("codigo"), ConditionOperator.Equal, "SALDO FINAL")

                    'Setando o valor
                    .SetValue(iCol, dSaldoFinal)

                   
                Next


                'Setando o valor das colunas
                .AutoSizeColumns()
                .FrozenColumns = 1
                .Row = 0
                .ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
            End With


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub



#End Region

End Class
