Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Dundas.Charting.WinControl
Imports Dundas.Charting
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrIndPrdHorasApontadas

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrafico(ByVal oChart As Chart, _
                           ByVal oGrid As GridEX, _
                           ByVal oGridMensal As GridEX, _
                           ByVal sDataInicio As String, _
                           ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oDataReader(5) As DataTableReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataInicio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataTermino : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_indicador_producao_horas_apontadas", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)
            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGridMensal)
            'Carrega Grid
            oGridMensal.DataSource = oDataSet.DefaultViewManager
            oGridMensal.DataMember = oDataSet.Tables(2).TableName : oGridMensal.MoveFirst()

            oDataReader(0) = oDataSet.CreateDataReader(oDataSet.Tables(1))
            oDataReader(1) = oDataSet.CreateDataReader(oDataSet.Tables(1))
            oDataReader(2) = oDataSet.CreateDataReader(oDataSet.Tables(1))
            oDataReader(3) = oDataSet.CreateDataReader(oDataSet.Tables(1))
            oDataReader(4) = oDataSet.CreateDataReader(oDataSet.Tables(1))
            oDataReader(5) = oDataSet.CreateDataReader(oDataSet.Tables(1))

            oChart.Titles.Clear()
            oChart.Titles.Add("Horas Apontadas")
            oChart.Legends(0).LegendStyle = WinControl.LegendStyle.Row

            'Limpa Série
            oChart.Series.Clear()

            'Formatando o eixo X de acordo com o valor escolhido
            oChart.ChartAreas(0).AxisX.Title = "PERÍODO"
            oChart.ChartAreas(0).AxisY.Title = "HORAS"

            'Adiciona Série
            oChart.Series.Add("MONTAGEM")
            oChart.Series.Add("INSPECAO")
            oChart.Series.Add("RETRABALHO")
            oChart.Series.Add("SERVICO")
            oChart.Series.Add("DESPESAS")
            oChart.Series.Add("TOTAL")

            'Carrega Gráfico
            oChart.Series("MONTAGEM").Points.DataBind(oDataReader(0), "data", "montagem", "Tooltip=descricao")
            oChart.Series("INSPECAO").Points.DataBind(oDataReader(1), "data", "inspecao", "Tooltip=descricao2")
            oChart.Series("RETRABALHO").Points.DataBind(oDataReader(2), "data", "retrabalho", "Tooltip=descricao3")
            oChart.Series("SERVICO").Points.DataBind(oDataReader(3), "data", "servico", "Tooltip=descricao4")
            oChart.Series("DESPESAS").Points.DataBind(oDataReader(4), "data", "despesas", "Tooltip=descricao5")
            oChart.Series("TOTAL").Points.DataBind(oDataReader(5), "data", "total", "Tooltip=descricao6")

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
                oChart.Series(j).BorderColor = Color.FromArgb(255, 26, 59, 105)
                oChart.Series(j).ShadowOffset = 2

            Next

            oChart.Series("TOTAL").Type = Dundas.Charting.WinControl.SeriesChartType.Line
            oChart.Series("TOTAL").BorderWidth = 3

            oChart.Series("MONTAGEM").Color = Color.LightGreen
            oChart.Series("INSPECAO").Color = Color.LightBlue
            oChart.Series("RETRABALHO").Color = Color.LightGray
            oChart.Series("SERVICO").Color = Color.LightPink
            oChart.Series("DESPESAS").Color = Color.LightYellow
            oChart.Series("TOTAL").Color = Color.LightSeaGreen

            oChart.Name = "Horas Apontadas"

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
            oDataReader(3).Close()
            oDataReader(4).Close()
            oDataReader(5).Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGraficoMensal(ByVal oChart As Chart, _
                                 ByVal sData As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oDataReader(0) As DataTableReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sData : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_indicador_producao_horas_apontadas_mensal", oSqlParameter)

            oDataReader(0) = oDataSet.CreateDataReader(oDataSet.Tables(0))

            oChart.Titles.Clear()
            oChart.Titles.Add("Gráfico Mensal " + sData)
            oChart.Legends(0).LegendStyle = WinControl.LegendStyle.Row

            'Limpa Série
            oChart.Series.Clear()

            'Formatando o eixo X de acordo com o valor escolhido
            oChart.ChartAreas(0).AxisX.Title = "TIPO"
            oChart.ChartAreas(0).AxisY.Title = "HORAS"

            'Adiciona Série
            oChart.Series.Add("HORAS")

            'Carrega Gráfico
            oChart.Series("HORAS").Points.DataBind(oDataReader(0), "tipo", "valor", "Tooltip=descricao")

            'Configura Séries
            For j As Integer = 0 To oChart.Series.Count - 1

                oChart.Series(j).Type = Dundas.Charting.WinControl.SeriesChartType.Pie
                oChart.Series(j).ShowInLegend = True
                oChart.Series(j).SmartLabels.Enabled = True
                oChart.Series(j).MarkerSize = 1
                oChart.Series(j).BorderWidth = 1
                oChart.Series(j).EmptyPointStyle.Color = Color.Transparent
                oChart.Series(j).BorderStyle = ChartDashStyle.Solid
                oChart.Series(j).BorderColor = Color.Black
                oChart.Series(j).SmartLabels.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes
                oChart.Series(j).LabelFormat = "#,#0.0"
                oChart.Series(j).BorderColor = Color.FromArgb(255, 26, 59, 105)
                oChart.Series(j).ShadowOffset = 2
                oChart.Series(j).ShowLabelAsValue = True

            Next

            oChart.Series(0)("PieLabelStyle") = "Outside"

            oChart.Name = "INDICADOR APONTAMENTO DE HORAS MENSAIS"

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

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class

