Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Dundas.Charting.WinControl
Imports Dundas.Charting
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrIndOrcamentoCapacidade

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGraficoDiario(ByVal oChart As Chart, _
                                 ByVal oGrid As GridEX, _
                                 ByVal sData As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oDataReader(1) As DataTableReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sData : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_indicador_comercial_orcamento_capacidade_diaria", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            oDataReader(0) = oDataSet.CreateDataReader(oDataSet.Tables(1))
            oDataReader(1) = oDataSet.CreateDataReader(oDataSet.Tables(1))

            oChart.Titles.Clear()
            oChart.Titles.Add("Demanda de Trabalho x Capacidade")
            oChart.Legends(0).LegendStyle = WinControl.LegendStyle.Row

            'Limpa Série
            oChart.Series.Clear()

            'Formatando o eixo X de acordo com o valor escolhido
            oChart.ChartAreas(0).AxisX.Title = "PERÍODO"
            oChart.ChartAreas(0).AxisY.Title = "QUANTIDADE (HORAS)"

            'Adiciona Série
            oChart.Series.Add("CAPACIDADE INTERNA")
            oChart.Series.Add("DEMANDA DE TRABALHO")

            'Carrega Gráfico
            oChart.Series("CAPACIDADE INTERNA").Points.DataBind(oDataReader(0), "data", "capacidade_interna", "Tooltip=descricao_capacidade_interna")
            oChart.Series("DEMANDA DE TRABALHO").Points.DataBind(oDataReader(1), "data", "demanda_trabalho", "Tooltip=descricao_demanda_trabalho")

            'Configura Séries
            For j As Integer = 0 To oChart.Series.Count - 1

                oChart.Series(j).Type = Dundas.Charting.WinControl.SeriesChartType.Line
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
            oChart.Series("DEMANDA DE TRABALHO").Type = Dundas.Charting.WinControl.SeriesChartType.Column
            oChart.Series("DEMANDA DE TRABALHO").Color = Color.FromArgb(65, 140, 240)
            oChart.Series("DEMANDA DE TRABALHO").BorderColor = Color.FromArgb(255, 26, 59, 105)
            oChart.Series("DEMANDA DE TRABALHO").ShadowOffset = 2

            oChart.Series("CAPACIDADE INTERNA").Type = Dundas.Charting.WinControl.SeriesChartType.Line
            oChart.Series("CAPACIDADE INTERNA").Color = Color.Peru
            oChart.Series("CAPACIDADE INTERNA").BorderWidth = 3
            oChart.Series("CAPACIDADE INTERNA").ShadowOffset = 2

            oChart.Name = "Demanda de Trabalho x Capacidade"

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

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGraficoMensal(ByVal oChart As Chart, _
                                 ByVal oGrid As GridEX, _
                                 ByVal sData As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oDataReader(11) As DataTableReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sData : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_indicador_comercial_orcamento_capacidade_mensal", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(3).TableName : oGrid.MoveFirst()

            'oDataReader(0) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            'oDataReader(1) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            'oDataReader(2) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            'oDataReader(3) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            'oDataReader(4) = oDataSet.CreateDataReader(oDataSet.Tables(1))
            'oDataReader(5) = oDataSet.CreateDataReader(oDataSet.Tables(1))
            'oDataReader(6) = oDataSet.CreateDataReader(oDataSet.Tables(1))
            'oDataReader(7) = oDataSet.CreateDataReader(oDataSet.Tables(1))
            'oDataReader(8) = oDataSet.CreateDataReader(oDataSet.Tables(1))
            'oDataReader(9) = oDataSet.CreateDataReader(oDataSet.Tables(1))
            'oDataReader(10) = oDataSet.CreateDataReader(oDataSet.Tables(2))
            'oDataReader(11) = oDataSet.CreateDataReader(oDataSet.Tables(0))

            'oChart.Titles.Clear()
            'oChart.Titles.Add("Controle Geral NTO")
            'oChart.Legends(0).LegendStyle = WinControl.LegendStyle.Row

            ''Limpa Série
            'oChart.Series.Clear()

            ''Formatando o eixo X de acordo com o valor escolhido
            'oChart.ChartAreas(0).AxisX.Title = "PERÍODO"
            'oChart.ChartAreas(0).AxisY.Title = "QUANTIDADE"

            ''Adiciona Série
            'oChart.Series.Add("TOTAL NTO")
            'oChart.Series.Add("TOTAL ABERTO")
            'oChart.Series.Add("TOTAL FINALIZADO")
            'oChart.Series.Add("TOTAL CANCELADO")

            ''Carrega Gráfico
            'oChart.Series("TOTAL NTO").Points.DataBind(oDataReader(0), "data", "total_nto", "Tooltip=descricao1")
            'oChart.Series("TOTAL ABERTO").Points.DataBind(oDataReader(1), "data", "total_aberto", "Tooltip=descricao2")
            'oChart.Series("TOTAL FINALIZADO").Points.DataBind(oDataReader(2), "data", "total_finalizado", "Tooltip=descricao3")
            'oChart.Series("TOTAL CANCELADO").Points.DataBind(oDataReader(3), "data", "total_cancelado", "Tooltip=descricao4")

            ''Configura Séries
            'For j As Integer = 0 To oChart.Series.Count - 1

            '    oChart.Series(j).Type = Dundas.Charting.WinControl.SeriesChartType.Line
            '    oChart.Series(j).ShowInLegend = True
            '    oChart.Series(j).SmartLabels.Enabled = True
            '    oChart.Series(j).MarkerSize = 1
            '    oChart.Series(j).BorderWidth = 3
            '    oChart.Series(j).EmptyPointStyle.Color = Color.Transparent
            '    oChart.Series(j).BorderStyle = ChartDashStyle.Solid
            '    oChart.Series(j).BorderColor = Color.Black
            '    oChart.Series(j).SmartLabels.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes
            '    oChart.Series(j).LabelFormat = "#,#0.0"
            '    oChart.Series(j).BorderColor = Color.FromArgb(255, 26, 59, 105)
            '    oChart.Series(j).ShadowOffset = 2

            'Next

            'oChart.Series("TOTAL NTO").Color = Color.ForestGreen

            'oChart.Name = "Controle Geral NTO"

            'oChart.ChartAreas(0).Area3DStyle.Enable3D = False
            'oChart.ChartAreas(0).BackColor = Color.White
            'oChart.ChartAreas(0).BorderColor = Color.FromArgb(255, 26, 59, 105)
            'oChart.ChartAreas(0).ShadowOffset = 2
            'oChart.ChartAreas(0).BorderStyle = ChartDashStyle.Solid
            'oChart.ChartAreas(0).AxisY.MajorGrid.LineStyle = ChartDashStyle.Solid
            'oChart.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.Silver
            'oChart.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.Silver
            'oChart.ChartAreas(0).AxisX.MajorGrid.LineStyle = ChartDashStyle.Solid
            'oChart.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
            'oChart.ChartAreas(0).AxisX.Interval = 1
            'oChart.ChartAreas(0).ReCalc()
            'oChart.Legends(0).Alignment = StringAlignment.Center
            'oChart.Legends(0).Docking = LegendDocking.Bottom
            'oChart.Legends(0).LegendStyle = LegendStyle.Row
            'oChart.Legends(0).AutoFitText = False
            'oChart.Legends(0).BackColor = Color.White
            'oChart.Legends(0).BorderColor = Color.FromArgb(255, 26, 59, 105)
            'oChart.Legends(0).BorderStyle = ChartDashStyle.Solid
            'oChart.Legends(0).BorderWidth = 1
            'oChart.Legends(0).DockInsideChartArea = True

            ''Configura cor na paleta Dundas
            'oChart.BackColor = Color.WhiteSmoke
            'oChart.BackGradientEndColor = Color.White
            'oChart.BackGradientType = GradientType.DiagonalLeft
            'oChart.BorderLineColor = Color.FromArgb(255, 26, 59, 105)
            'oChart.BorderLineStyle = ChartDashStyle.Solid
            'oChart.BorderSkin.SkinStyle = BorderSkinStyle.Emboss
            'oChart.BorderSkin.FrameBackColor = Color.CornflowerBlue
            'oChart.BorderSkin.FrameBackGradientEndColor = Color.CornflowerBlue
            'oChart.BorderSkin.PageColor = Color.FromArgb(255, 240, 240, 240)
            'oChart.UI.Toolbar.BorderSkin.SkinStyle = BorderSkinStyle.Emboss
            'oChart.UI.Toolbar.BorderSkin.FrameBackColor = Color.Gray
            'oChart.UI.Toolbar.BorderSkin.PageColor = Color.Transparent

            ''Fecha Conexão
            'oDataReader(0).Close()
            'oDataReader(1).Close()
            'oDataReader(2).Close()
            'oDataReader(3).Close()
            'oDataReader(4).Close()
            'oDataReader(5).Close()
            'oDataReader(6).Close()
            'oDataReader(7).Close()
            'oDataReader(8).Close()
            'oDataReader(9).Close()
            'oDataReader(10).Close()
            'oDataReader(11).Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class

