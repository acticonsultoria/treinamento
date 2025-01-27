Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Dundas.Charting.WinControl
Imports Dundas.Charting
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrIndPedidoItemEntrega

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrafico(ByVal oChart As Chart, _
                           ByVal lCodigoItem As Long, _
                           ByVal sCodigoItem As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oDataReader(2) As DataTableReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_indicador_compras_pedido_item_entrega", oSqlParameter)

            oDataReader(0) = oDataSet.CreateDataReader(oDataSet.Tables(0))

            oChart.Titles.Clear()
            oChart.Titles.Add("PN TOPO - " + sCodigoItem)
            oChart.Legends(0).LegendStyle = WinControl.LegendStyle.Row

            'Limpa Série
            oChart.Series.Clear()

            oChart.ChartAreas(0).AxisX.Title = "ENTRADA"
            oChart.ChartAreas(0).AxisY.Title = "QUANTIDADE"

            'Adiciona Série
            oChart.Series.Add("PN TOPO")

            'Carrega Gráfico
            oChart.Series("PN TOPO").Points.DataBind(oDataReader(0), "descricao", "quantidade", "Tooltip=descricao")

            For j As Integer = 0 To oChart.Series.Count - 1

                oChart.Series(j).Type = Dundas.Charting.WinControl.SeriesChartType.Pie
                oChart.Series(j).ShowInLegend = True
                oChart.Series(j).ShowLabelAsValue = True
                oChart.Series(j).SmartLabels.Enabled = True
                oChart.Series(j).MarkerSize = 1
                oChart.Series(j).BorderWidth = 1

                oChart.Series(j).SmartLabels.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes
                oChart.Series(j).LabelFormat = "#,#0.0"

            Next

            oChart.Name = "PN TOPO - " + sCodigoItem

            oChart.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
            oChart.ChartAreas(0).AxisX.Interval = 1
            oChart.ChartAreas(0).ReCalc()
            oChart.Legends(0).Alignment = StringAlignment.Center
            oChart.Legends(0).Docking = LegendDocking.Bottom
            oChart.Legends(0).LegendStyle = LegendStyle.Row

            'Fecha Conexão
            oDataReader(0).Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class

