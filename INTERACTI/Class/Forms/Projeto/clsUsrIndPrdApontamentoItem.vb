Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Dundas.Charting.WinControl
Imports Dundas.Charting
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrIndPrdApontamentoItem

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGridGrafico(ByVal oChart As Chart, _
                               ByVal oGrid As GridEX, _
                               ByVal lCodigoItem As Long, _
                               ByVal sCodigoItem As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oDataReader(1) As DataTableReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_indicador_producao_horas_apontadas_item", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)
            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(1).TableName : oGrid.MoveFirst()

            oDataReader(0) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            oDataReader(1) = oDataSet.CreateDataReader(oDataSet.Tables(0))

            oChart.Titles.Clear()
            oChart.Titles.Add("Horas Apontadas - PN " + sCodigoItem)
            oChart.Legends(0).LegendStyle = WinControl.LegendStyle.Row

            'Limpa Série
            oChart.Series.Clear()

            'Formatando o eixo X de acordo com o valor escolhido
            oChart.ChartAreas(0).AxisX.Title = "PERÍODO"
            oChart.ChartAreas(0).AxisY.Title = "HORAS"

            'Adiciona Série
            oChart.Series.Add("APONTAMENTO")
            oChart.Series.Add("TOTAL")

            'Carrega Gráfico
            oChart.Series("APONTAMENTO").Points.DataBind(oDataReader(0), "tipo", "quantidade", "Tooltip=descricao")
            oChart.Series("TOTAL").Points.DataBind(oDataReader(1), "tipo", "total", "Tooltip=descricao2")

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

            oChart.Series("TOTAL").Type = Dundas.Charting.WinControl.SeriesChartType.Line
            oChart.Series("TOTAL").BorderWidth = 3

            oChart.Name = "Horas Apontadas - PN " + sCodigoItem

            'Configurações da paleta Dundas
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

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class

