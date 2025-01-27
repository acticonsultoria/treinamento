Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Dundas.Charting.WinControl
Imports Dundas.Charting
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrIndProjetoOTD

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGridGrafico(ByVal oChart As Chart, _
                               ByVal sDataInicio As String, _
                               ByVal sDataTermino As String, _
                               ByVal dMeta As Double)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oDataReader(2) As DataTableReader
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

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "meta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMeta : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_indicador_projeto_otd", oSqlParameter)

            oDataReader(0) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            oDataReader(1) = oDataSet.CreateDataReader(oDataSet.Tables(0))

            oChart.Titles.Clear()
            oChart.Titles.Add("INDICADOR OTD")
            oChart.Legends(0).LegendStyle = WinControl.LegendStyle.Row

            'Limpa Série
            oChart.Series.Clear()

            'Formatando o eixo X de acordo com o valor escolhido
            oChart.ChartAreas(0).AxisX.Title = "PERÍODO"
            oChart.ChartAreas(0).AxisY.Title = "PERCENTUAL"


            'Adiciona Série
            oChart.Series.Add("OTD")
            oChart.Series.Add("META")

            'Carrega Gráfico
            oChart.Series("OTD").Points.DataBind(oDataReader(0), "data", "otd", "Tooltip=descricao")
            oChart.Series("META").Points.DataBind(oDataReader(1), "data", "meta", "Tooltip=descricao2")

            'Configura Séries
            For j As Integer = 0 To oChart.Series.Count - 1

                oChart.Series(j).Type = Dundas.Charting.WinControl.SeriesChartType.Column
                oChart.Series(j).ShowInLegend = True
                oChart.Series(j).SmartLabels.Enabled = True
                oChart.Series(j).MarkerSize = 1
                oChart.Series(j).BorderWidth = 1
                oChart.Series(j).EmptyPointStyle.Color = Color.Transparent
                oChart.Series(j).BorderStyle = ChartDashStyle.Solid
                oChart.Series(j).BorderColor = Color.Black
                oChart.Series(j).SmartLabels.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes
                oChart.Series(j).LabelFormat = "#,#0.0"

            Next

            oChart.Series("OTD").Color = Color.LightGreen
            oChart.Series("OTD").ShowLabelAsValue = True
            oChart.Series("META").Color = Color.LightBlue
            oChart.Series("META").BorderStyle = ChartDashStyle.Solid
            oChart.Series("META").BorderColor = Color.Black
            oChart.Series("META").Type = Dundas.Charting.WinControl.SeriesChartType.Line
            oChart.Series("META").BorderWidth = 4

            oChart.Name = "INDICADOR OTD"

            oChart.ChartAreas(0).Area3DStyle.Enable3D = False
            oChart.ChartAreas(0).AxisY.MajorGrid.LineStyle = ChartDashStyle.Dot
            oChart.ChartAreas(0).AxisX.MajorGrid.LineStyle = ChartDashStyle.Dot
            oChart.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
            oChart.ChartAreas(0).AxisX.Interval = 1
            oChart.ChartAreas(0).ReCalc()
            oChart.Legends(0).Alignment = StringAlignment.Center
            oChart.Legends(0).Docking = LegendDocking.Bottom
            oChart.Legends(0).LegendStyle = LegendStyle.Row

            'Fecha Conexão
            oDataReader(0).Close()
            oDataReader(1).Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class

