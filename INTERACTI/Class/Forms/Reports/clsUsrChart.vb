Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Dundas.Charting.WinControl

Public Class clsUsrChart

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrafico(ByVal oChart As Chart, _
                           ByVal sQuery As String, _
                           ByVal oGrafico As Grafico)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader

        Try

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.Text, sQuery)

            'Limpa Série
            oChart.Series.Clear()

            'Carrega Gráfico
            oChart.DataBindTable(oSqlDataReader, oGrafico.sX)

            'Configura Séries
            For Each oSerie As Series In oGrafico.oSeries
                oChart.Series(oSerie.Name.ToString).Color = oSerie.Color
                oChart.Series(oSerie.Name.ToString).ShowInLegend = oSerie.ShowInLegend
                oChart.Series(oSerie.Name.ToString).LegendText = oSerie.LegendText
                oChart.Series(oSerie.Name.ToString).Type = oSerie.Type
                oChart.Series(oSerie.Name.ToString).SmartLabels.Enabled = oSerie.SmartLabels.Enabled
            Next

            'Exibe Label quando foi diferente de 0
            For Each oSeries As Series In oChart.Series
                For Each oDataPoint As DataPoint In oSeries.Points
                    If oDataPoint.YValues(0) <> 0 Then
                        oDataPoint.ShowLabelAsValue = True
                        oDataPoint("LabelStyle") = "Bottom"
                    End If
                Next
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

