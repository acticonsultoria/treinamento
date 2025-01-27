Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Dundas.Charting.WinControl
Imports Dundas.Charting
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrIndFilaInspecaoRecebimento

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGridGrafico(ByVal oGrid As GridEX, _
                               ByVal oChart As Chart, _
                               ByVal sDataCorte As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oDataReader(2) As DataTableReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_corte"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataCorte : i += 1

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_indicador_qualidade_fila_inspecao_recebimento", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)
            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            oDataReader(0) = oDataSet.CreateDataReader(oDataSet.Tables(1))
            oDataReader(1) = oDataSet.CreateDataReader(oDataSet.Tables(1))
            oDataReader(2) = oDataSet.CreateDataReader(oDataSet.Tables(1))

            oChart.Titles.Clear()
            oChart.Titles.Add("Controle Fila Inspeção de Recebimento")
            oChart.Legends(0).LegendStyle = WinControl.LegendStyle.Row

            'Limpa Série
            oChart.Series.Clear()

            'Formatando o eixo X de acordo com o valor escolhido
            oChart.ChartAreas(0).AxisX.Title = "PERÍODO"
            oChart.ChartAreas(0).AxisY.Title = "QUANTIDADE"


            'Adiciona Série
            oChart.Series.Add("FILA")
            oChart.Series.Add("ENTRADA FISCAL")
            oChart.Series.Add("INSPECAO RECEBIMENTO")

            'Carrega Gráfico
            oChart.Series("FILA").Points.DataBind(oDataReader(0), "data", "fila", "Tooltip=descricao")
            oChart.Series("ENTRADA FISCAL").Points.DataBind(oDataReader(1), "data", "entrada_fiscal", "Tooltip=descricao2")
            oChart.Series("INSPECAO RECEBIMENTO").Points.DataBind(oDataReader(2), "data", "inspecao_recebimento", "Tooltip=descricao3")

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

            'Configura cor na paleta Dundas
            oChart.Series("FILA").Color = Color.FromArgb(65, 140, 240)
            oChart.Series("FILA").BorderColor = Color.FromArgb(255, 26, 59, 105)
            oChart.Series("FILA").ShadowOffset = 2
            oChart.Series("ENTRADA FISCAL").Color = Color.FromArgb(255, 180, 68)
            oChart.Series("ENTRADA FISCAL").BorderColor = Color.FromArgb(255, 26, 59, 105)
            oChart.Series("ENTRADA FISCAL").ShadowOffset = 2
            oChart.Series("ENTRADA FISCAL").Type = Dundas.Charting.WinControl.SeriesChartType.Line
            oChart.Series("ENTRADA FISCAL").BorderWidth = 3
            oChart.Series("INSPECAO RECEBIMENTO").Color = Color.FromArgb(232, 68, 12)
            oChart.Series("INSPECAO RECEBIMENTO").BorderColor = Color.FromArgb(255, 26, 59, 105)
            oChart.Series("INSPECAO RECEBIMENTO").ShadowOffset = 2
            oChart.Series("INSPECAO RECEBIMENTO").Type = Dundas.Charting.WinControl.SeriesChartType.Line
            oChart.Series("INSPECAO RECEBIMENTO").BorderWidth = 3

            oChart.Name = "Controle Fila Inspeção de Recebimento"

            oChart.ChartAreas(0).Area3DStyle.Enable3D = False
            oChart.ChartAreas(0).BackColor = Color.White
            oChart.ChartAreas(0).BorderColor = Color.FromArgb(255, 26, 59, 105)
            oChart.ChartAreas(0).ShadowOffset = 2
            oChart.ChartAreas(0).BorderStyle = ChartDashStyle.Solid
            oChart.ChartAreas(0).AxisY.MajorGrid.LineStyle = ChartDashStyle.Solid
            oChart.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.Silver
            oChart.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.Silver
            oChart.ChartAreas(0).AxisX.MajorGrid.LineStyle = ChartDashStyle.Solid
            oChart.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
            oChart.ChartAreas(0).AxisX.Interval = 1
            oChart.ChartAreas(0).ReCalc()
            oChart.Legends(0).Alignment = StringAlignment.Center
            oChart.Legends(0).Docking = LegendDocking.Bottom
            oChart.Legends(0).LegendStyle = LegendStyle.Row
            oChart.Legends(0).AutoFitText = False
            oChart.Legends(0).BackColor = Color.White
            oChart.Legends(0).BorderColor = Color.FromArgb(255, 26, 59, 105)
            oChart.Legends(0).BorderStyle = ChartDashStyle.Solid
            oChart.Legends(0).BorderWidth = 1
            oChart.Legends(0).DockInsideChartArea = True

            'Configura cor na paleta Dundas
            oChart.BackColor = Color.WhiteSmoke
            oChart.BackGradientEndColor = Color.White
            oChart.BackGradientType = GradientType.DiagonalLeft
            oChart.BorderLineColor = Color.FromArgb(255, 26, 59, 105)
            oChart.BorderLineStyle = ChartDashStyle.Solid
            oChart.BorderSkin.SkinStyle = BorderSkinStyle.Emboss
            oChart.BorderSkin.FrameBackColor = Color.CornflowerBlue
            oChart.BorderSkin.FrameBackGradientEndColor = Color.CornflowerBlue
            oChart.BorderSkin.PageColor = Color.FromArgb(255, 240, 240, 240)
            oChart.UI.Toolbar.BorderSkin.SkinStyle = BorderSkinStyle.Emboss
            oChart.UI.Toolbar.BorderSkin.FrameBackColor = Color.Gray
            oChart.UI.Toolbar.BorderSkin.PageColor = Color.Transparent

            'Fecha Conexão
            oDataReader(0).Close()
            oDataReader(1).Close()
            oDataReader(2).Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class

