Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Dundas.Charting.WinControl
Imports Janus.Windows.GridEX

Public Class clsUsrIndFin000000005

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iTipo As Integer, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipo : i += 1

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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_grid_chart_fin000000005", oSqlParameter)

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
                           ByVal iTipo As Integer, _
                           ByVal sDataInicio As String, _
                           ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipo : i += 1

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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_chart_fin000000005", oSqlParameter)

            'Limpa Série
            oChart.Series.Clear()

            'Carrega Gráfico
            oChart.DataBindTable(oSqlDataReader, "periodo")

            oChart.ChartAreas(0).Area3DStyle.Enable3D = False

            'Configura Série - Receita
            oChart.Series("valor").LegendText = "Receita"
            oChart.Series("valor").ShowInLegend = True
            oChart.Series("valor").Type = SeriesChartType.Column
            oChart.Series("valor").BorderWidth = 5
            oChart.Series("valor")("ShowMarkerLines") = True
            oChart.Series("valor").SmartLabels.Enabled = True
            oChart.Series("valor").LabelFormat = "#,#0.00"
            oChart.Series("valor")("TooltipOffset") = "Auto"

            'Configura Séries - Acumulado
            oChart.Series("acumulado").LegendText = "Receita Acumulado"
            oChart.Series("acumulado").ShowInLegend = True
            oChart.Series("acumulado").Type = SeriesChartType.Line
            oChart.Series("acumulado").BorderWidth = 5
            oChart.Series("acumulado").MarkerSize = 7
            oChart.Series("acumulado").MarkerStyle = MarkerStyle.Circle
            oChart.Series("acumulado").MarkerColor = Color.Black
            oChart.Series("acumulado").SmartLabels.Enabled = True
            oChart.Series("acumulado").LabelFormat = "#,#0.00"
            oChart.Series("acumulado")("TooltipOffset") = "Auto"


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

