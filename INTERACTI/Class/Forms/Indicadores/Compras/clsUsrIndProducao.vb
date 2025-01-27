Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Dundas.Charting.WinControl
Imports Janus.Windows.GridEX

Public Class clsUsrIndProducao

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal oChart As Chart, _
                        ByVal sTipo As String, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0
        Dim sProcedure As String = "sp_indicador_compras_" & sTipo
        Try

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, sProcedure, oSqlParameter)
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, sProcedure, oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(1).TableName : oGrid.MoveFirst()


            'Formata o total
            If sTipo = "atraso" Then

                oGrid.RootTable.Columns("valor").AggregateFunction = AggregateFunction.Average
                oGrid.RootTable.Columns("valor").TotalFormatString = "Méd: 000"

            Else
                oGrid.RootTable.Columns("valor").AggregateFunction = AggregateFunction.Sum
                oGrid.RootTable.Columns("valor").TotalFormatString = "#,#0.00"


            End If



            'Agora configura o gráfico

            'Limpa Série
            oChart.Series.Clear()

            'Adiciona Série
            oChart.Series.Add("Default")

            'Carrega Gráfico
            oChart.Series("Default").Points.DataBind(oSqlDataReader, "descricao", "valor", "Tooltip=descricao")

            'Configura Séries
            oChart.Series("Default").ShowInLegend = True
            oChart.Series("Default").SmartLabels.Enabled = True

            'Formata o gráfic
            FormataGrafico(oChart, _
                           sTipo)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub FormataGrafico(ByVal oChart As Chart, _
                              ByVal sTipo As String)

        Try

            Select Case sTipo
                Case "atraso"
                    oChart.Series("Default").Type = SeriesChartType.Column
                    oChart.Series("Default").LabelFormat = "0"
                    oChart.ChartAreas("Default").Area3DStyle.Enable3D = False
                    oChart.ChartAreas("Default").AxisX.Title = "Fornecedor"
                    oChart.ChartAreas("Default").AxisY.Title = "Média de dias"

                Case "mensal"
                    oChart.Series("Default").Type = SeriesChartType.Line
                    oChart.Series("Default").LabelFormat = "#,#0.00"
                    oChart.ChartAreas("Default").Area3DStyle.Enable3D = False
                    oChart.ChartAreas("Default").AxisX.Title = "Mês"
                    oChart.ChartAreas("Default").AxisY.Title = "Valor"


                Case "categoria"
                    oChart.Series("Default").Type = SeriesChartType.Doughnut
                    oChart.Series("Default").LabelFormat = "#,#0.00"
                    oChart.ChartAreas("Default").Area3DStyle.Enable3D = True

                    'Exibe Label quando foi diferente de 0
                    For Each oSeries As Series In oChart.Series
                        For Each oDataPoint As DataPoint In oSeries.Points
                            If oDataPoint.YValues(0) <> 0 Then
                                oDataPoint.ShowLabelAsValue = True
                                oDataPoint("LabelStyle") = "Outside"
                            End If
                        Next
                        oSeries.Font = New Font("Arial", 8)
                    Next

                Case "industrializacao"
                    oChart.Series("Default").Type = SeriesChartType.Column
                    oChart.Series("Default").LabelFormat = "#,#0.00"
                    oChart.ChartAreas("Default").Area3DStyle.Enable3D = False
                    oChart.ChartAreas("Default").AxisX.Title = "Fornecedor"
                    oChart.ChartAreas("Default").AxisY.Title = "Valor"

                Case Else


            End Select


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'Public Sub LoadGrafico(ByVal oChart As Chart, _
    '                       ByVal sDataInicio As String, _
    '                       ByVal sDataTermino As String)

    '    'Variaveis Locais
    '    Dim oSqlDataReader As SqlDataReader
    '    Dim oSqlParameter(3) As SqlParameter
    '    Dim i As Integer = 0

    '    Try

    '        'Seta Parametros - Data Início
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "data_inicio"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.DateTime
    '        oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

    '        'Seta Parametros - Data Término
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "data_termino"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.DateTime
    '        oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

    '        'Seta Parametros - Código Empresa
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "codigo_empresa"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
    '        oSqlParameter(i).Value = goUsuario.iEmpresa

    '        'Executa Query
    '        oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_chart_cmp000000001", oSqlParameter)

    '        'Limpa Série
    '        oChart.Series.Clear()

    '        'Adiciona Série
    '        oChart.Series.Add("Default")

    '        'Carrega Gráfico
    '        oChart.Series("Default").Points.DataBind(oSqlDataReader, "estado", "valor", "Tooltip=tag")

    '        'Configura Séries
    '        oChart.Series("Default").ShowInLegend = True
    '        oChart.Series("Default").Type = SeriesChartType.Doughnut
    '        oChart.Series("Default").SmartLabels.Enabled = True
    '        oChart.ChartAreas("Default").Area3DStyle.Enable3D = True
    '        oChart.Series("Default").LabelFormat = "0.00%"

    '        'Exibe Label quando foi diferente de 0
    '        For Each oSeries As Series In oChart.Series
    '            For Each oDataPoint As DataPoint In oSeries.Points
    '                If oDataPoint.YValues(0) <> 0 Then
    '                    oDataPoint.ShowLabelAsValue = True
    '                    oDataPoint("LabelStyle") = "Outside"
    '                End If
    '            Next
    '            oSeries.Font = New Font("Arial", 8)
    '        Next

    '        'Fecha o SqlDataReader
    '        If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

    '    Catch SqlEx As SqlException
    '        Throw SqlEx
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

#End Region

End Class

