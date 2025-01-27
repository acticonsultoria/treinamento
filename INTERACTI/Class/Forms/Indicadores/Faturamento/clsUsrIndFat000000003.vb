Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Dundas.Charting.WinControl
Imports Janus.Windows.GridEX

Public Class clsUsrIndFat000000003

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_grid_chart_fat000000003", oSqlParameter)

            'Configura DataMember Grid
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

    Public Sub LoadGrafico(ByVal oChart As Chart, _
                           ByVal sDataInicio As String, _
                           ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_chart_fat000000003", oSqlParameter)

            'Limpa Série
            oChart.Series.Clear()

            'Carrega Gráfico
            oChart.DataBindCrossTab(oSqlDataReader, "empresa", "periodo", "valor", "")

            oChart.ChartAreas(0).Area3DStyle.Enable3D = False

            'Configura Séries - Empresa
            'oChart.Series(0).LegendText = "empresa"
            oChart.Series(0).ShowInLegend = True
            oChart.Series(0).Type = SeriesChartType.Area
            oChart.Series(0).MarkerStyle = MarkerStyle.Circle
            oChart.Series(0).MarkerColor = Color.Black
            oChart.Series(0).SmartLabels.Enabled = True
            oChart.Series(0).LabelFormat = "#,#0.00"
            oChart.Series(0)("TooltipOffset") = "Auto"

            'oChart.Series(1).LegendText = "empresa"
            oChart.Series(1).ShowInLegend = True
            oChart.Series(1).Type = SeriesChartType.Line
            oChart.Series(1).BorderWidth = 3
            oChart.Series(1).MarkerSize = 5
            oChart.Series(1).MarkerStyle = MarkerStyle.Circle
            oChart.Series(1).MarkerColor = Color.Black
            oChart.Series(1).SmartLabels.Enabled = True
            oChart.Series(1).LabelFormat = "#,#0.00"
            oChart.Series(1)("TooltipOffset") = "Auto"

            'oChart.Series(2).LegendText = "empresa"
            oChart.Series(2).ShowInLegend = True
            oChart.Series(2).Type = SeriesChartType.Line
            oChart.Series(2).BorderWidth = 3
            oChart.Series(2).MarkerSize = 5
            oChart.Series(2).MarkerStyle = MarkerStyle.Circle
            oChart.Series(2).MarkerColor = Color.Black
            oChart.Series(2).SmartLabels.Enabled = True
            oChart.Series(2).LabelFormat = "#,#0.00"
            oChart.Series(2)("TooltipOffset") = "Auto"

            'oChart.Series(3).LegendText = "empresa"
            oChart.Series(3).ShowInLegend = True
            oChart.Series(3).Type = SeriesChartType.Line
            oChart.Series(3).BorderWidth = 3
            oChart.Series(3).MarkerSize = 5
            oChart.Series(3).MarkerStyle = MarkerStyle.Circle
            oChart.Series(3).MarkerColor = Color.Black
            oChart.Series(3).SmartLabels.Enabled = True
            oChart.Series(3).LabelFormat = "#,#0.00"
            oChart.Series(3)("TooltipOffset") = "Auto"

            'oChart.Series(4).LegendText = "empresa"
            oChart.Series(4).ShowInLegend = True
            oChart.Series(4).Type = SeriesChartType.Line
            oChart.Series(4).BorderWidth = 3
            oChart.Series(4).MarkerSize = 5
            oChart.Series(4).MarkerStyle = MarkerStyle.Circle
            oChart.Series(4).MarkerColor = Color.Black
            oChart.Series(4).SmartLabels.Enabled = True
            oChart.Series(4).LabelFormat = "#,#0.00"
            oChart.Series(4)("TooltipOffset") = "Auto"

            'Exibe Label quando foi diferente de 0
            For Each oSeries As Series In oChart.Series
                For Each oDataPoint As DataPoint In oSeries.Points
                    If oDataPoint.YValues(0) <> 0 Then
                        oDataPoint.ShowLabelAsValue = True
                        oDataPoint("LabelStyle") = "Bottom"
                    End If
                Next
                oSeries.Font = New Font("Arial", 8)
            Next

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class

