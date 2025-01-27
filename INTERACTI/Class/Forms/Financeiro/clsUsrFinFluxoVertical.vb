Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrFinFluxoVertical

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sParceiroNegocio As String, _
                        ByVal sTipoTituloFinanceiro As String, _
                        ByVal dDataInicio As Date, _
                        ByVal dDataTermino As Date)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(13) As SqlParameter
        Dim i As Integer = 0

        Try

            'Setando para não perder as atualizações com o refresh
            oGrid.KeepRowSettings = True
            oGrid.FrozenColumns = 2

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipoTituloFinanceiro : i += 1

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_fluxo_caixa_vertical", oSqlParameter)

            'Limpando a grid
            oGrid.Tables(0).Columns.Clear()

            'INSERINDO AS COLUNAS NA GRID
            Dim oColumn As GridEXColumn

            oColumn = New GridEXColumn("empresa")
            oColumn.Caption = "Empresa"
            oColumn.Width = 100
            oColumn.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            oGrid.Tables(0).Columns.Add(oColumn)

            oColumn = New GridEXColumn("parceiro_negocio")
            oColumn.Caption = "Parceiro de Negócio"
            oColumn.AggregateFunction = AggregateFunction.Count
            oColumn.TotalFormatString = "Qtd: 0000"
            oColumn.CellToolTip = CellToolTip.TruncatedText
            oColumn.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            oColumn.Width = 300
            oGrid.Tables(0).Columns.Add(oColumn)

            oColumn = New GridEXColumn("codigo_empresa")
            oColumn.Visible = False
            oGrid.Tables(0).Columns.Add(oColumn)

            oColumn = New GridEXColumn("codigo_parceiro_negocio")
            oColumn.Visible = False
            oGrid.Tables(0).Columns.Add(oColumn)

            'Variável auxiliar
            Dim dData As Date
            Dim oDataColumn As DataColumn

            'Percorrendo todos os meses, para inserir na grid
            For iCont As Integer = 0 To DateDiff(DateInterval.Month, dDataInicio, dDataTermino)

                'Atribuindo a data
                dData = DateAdd(DateInterval.Month, iCont, dDataInicio)

                'Acrescentando na grid as datas
                oColumn = New GridEXColumn(Format(dData, "MM_yyyy"))
                oColumn.AggregateFunction = AggregateFunction.Sum
                oColumn.FormatString = "R$ 0.00"
                oColumn.TotalFormatString = "R$ 0.00"
                oColumn.ColumnType = ColumnType.ImageAndText
                oColumn.CellToolTip = CellToolTip.UseCellToolTipText
                oColumn.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oColumn.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far

                'Instanciando a coluna do dataset
                oDataColumn = New DataColumn(Format(dData, "MM_yyyy"))
                oDataColumn.DataType = 0.0.GetType
                'oDataColumn.DefaultValue = 0.0

                'Acrescentando no dataset
                oDataSet.Tables(0).Columns.Add(oDataColumn)

                'Setandoo caption
                oColumn.Caption = Format(dData, "MM/yyyy")

                'Adicionando na grid
                oGrid.Tables(0).Columns.Add(oColumn)

            Next

            'Instanciando na grid
            Call ConfigurarDataMemberGrid(oGrid)
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            'Agora abrindo um datareader para setar os valores
            'Primeiro aloca o espaço no datareader, depois seta os parâmetros
            ReDim Preserve oSqlParameter(5)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dDataInicio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dDataTermino : i += 1

            'Recebendo os dados
            Dim oSqlDataReader As SqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_fluxo_caixa_vertical_detalhe", oSqlParameter)

            'Percorrendo todos os resultados do datareader
            While oSqlDataReader.Read

                'Instanciando uma condição
                Dim oFilter As New GridEXFilterCondition
                oFilter.AddCondition(LogicalOperator.And, New GridEXFilterCondition(oGrid.RootTable.Columns("codigo_parceiro_negocio"), ConditionOperator.Equal, oSqlDataReader.Item("codigo_parceiro_negocio")))
                oFilter.AddCondition(LogicalOperator.And, New GridEXFilterCondition(oGrid.RootTable.Columns("codigo_empresa"), ConditionOperator.Equal, oSqlDataReader.Item("codigo_empresa")))

                'Encontrando a linha
                If oGrid.Find(oFilter, 0, 1) = True Then

                    'Setando o valor da data
                    oGrid.SetValue(oSqlDataReader.Item("data"), oSqlDataReader.Item("valor"))

                    'Setando o tooltip
                    oGrid.CurrentRow.Cells(oSqlDataReader.Item("data")).ToolTipText = oSqlDataReader.Item("descritivo")

                End If

            End While

            'Fechando o datareader
            oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
