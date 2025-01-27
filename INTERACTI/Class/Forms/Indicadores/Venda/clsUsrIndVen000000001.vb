Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Dundas.Charting.WinControl
Imports Janus.Windows.GridEX

Public Class clsUsrIndVen000000001

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iAgrupadoPor As Integer, _
                        ByVal iCodigoVendedor As Integer, _
                        ByVal sCodigoTipoComparativo As String, _
                        ByVal sCodigoComparativo As String, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Vendedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agrupado_por"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iAgrupadoPor : i += 1

            'Seta Parametros - Codigo Vendedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vendedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoVendedor : i += 1

            'Seta Parametros - Codigo Tipo Comparativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_comparativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sCodigoTipoComparativo : i += 1

            'Seta Parametros - Codigo Comparativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_comparativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.NVarChar
            oSqlParameter(i).Value = sCodigoComparativo : i += 1

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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_grid_chart_ven000000001", oSqlParameter)

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
                           ByVal iAgrupadoPor As Integer, _
                           ByVal iCodigoVendedor As Integer, _
                           ByVal sCodigoTipoComparativo As String, _
                           ByVal sCodigoComparativo As String, _
                           ByVal sDataInicio As String, _
                           ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Vendedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agrupado_por"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iAgrupadoPor : i += 1

            'Seta Parametros - Codigo Vendedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vendedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoVendedor : i += 1

            'Seta Parametros - Codigo Tipo Comparativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_comparativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sCodigoTipoComparativo : i += 1

            'Seta Parametros - Codigo Comparativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_comparativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.NVarChar
            oSqlParameter(i).Value = sCodigoComparativo : i += 1

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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_chart_ven000000001", oSqlParameter)

            'Limpa Série
            oChart.Series.Clear()

            If oSqlDataReader.HasRows = False Then
                oSqlDataReader.Close() : Exit Sub
            End If

            'Carrega Gráfico
            oChart.DataBindTable(oSqlDataReader, "periodo")

            oChart.ChartAreas(0).Area3DStyle.Enable3D = False

            'Configura Série - Receita
            oChart.Series("valor_vendedor").LegendText = "Valor Vendedor"
            oChart.Series("valor_vendedor").ShowInLegend = True
            oChart.Series("valor_vendedor").Type = SeriesChartType.Line
            oChart.Series("valor_vendedor").BorderWidth = 5
            oChart.Series("valor_vendedor")("ShowMarkerLines") = True
            oChart.Series("valor_vendedor").SmartLabels.Enabled = True
            oChart.Series("valor_vendedor").LabelFormat = "#,#0.00"
            oChart.Series("valor_vendedor")("TooltipOffset") = "Auto"

            'Configura Séries - Acumulado
            oChart.Series("valor_comparado").LegendText = "Valor Comparado"
            oChart.Series("valor_comparado").ShowInLegend = True
            oChart.Series("valor_comparado").Type = SeriesChartType.Line
            oChart.Series("valor_comparado").BorderWidth = 5
            oChart.Series("valor_comparado").MarkerSize = 7
            oChart.Series("valor_comparado").MarkerStyle = MarkerStyle.Circle
            oChart.Series("valor_comparado").MarkerColor = Color.Black
            oChart.Series("valor_comparado").SmartLabels.Enabled = True
            oChart.Series("valor_comparado").LabelFormat = "#,#0.00"
            oChart.Series("valor_comparado")("TooltipOffset") = "Auto"


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

