Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Dundas.Charting.WinControl
Imports Dundas.Charting
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrIndProjeto

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal iCodigoEtapa As Integer, _
                        ByVal dMeta As Double)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter
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
            oSqlParameter(i).ParameterName = "codigo_etapa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEtapa : i += 1

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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_indicador_compras2", oSqlParameter)

            'Configura DataMember
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

    Public Sub LoadGridGrafico(ByVal oGrid As GridEX, _
                               ByVal oChart As Chart, _
                               ByVal sDataInicio As String, _
                               ByVal sDataTermino As String, _
                               ByVal iCodigoEtapa As Integer, _
                               ByVal sEtapa As String, _
                               ByVal dMeta As Double)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oDataReader(2) As DataTableReader
        Dim oSqlParameter(4) As SqlParameter
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
            oSqlParameter(i).ParameterName = "codigo_etapa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEtapa : i += 1

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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_indicador_projeto_etapa", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet
            oGrid.DataMember = oDataSet.Tables(1).TableName

            oDataReader(0) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            oDataReader(1) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            oDataReader(2) = oDataSet.CreateDataReader(oDataSet.Tables(0))

            oChart.Titles.Clear()
            oChart.Titles.Add("INDICADOR DE PROJETO - ETAPA " + sEtapa)
            oChart.Legends(0).LegendStyle = WinControl.LegendStyle.Row

            'Limpa Série
            oChart.Series.Clear()

            'Formatando o eixo X de acordo com o valor escolhido
            oChart.ChartAreas(0).AxisX.Title = "PERÍODO"
            oChart.ChartAreas(0).AxisY.Title = "CICLO"


            'Adiciona Série
            oChart.Series.Add("CICLO ON TIME")
            oChart.Series.Add("CICLO ATRASADO")
            oChart.Series.Add("META")

            'Carrega Gráfico
            oChart.Series("CICLO ON TIME").Points.DataBind(oDataReader(0), "data", "ciclo_planejado", "Tooltip=descricao")
            oChart.Series("CICLO ATRASADO").Points.DataBind(oDataReader(1), "data", "ciclo_real", "Tooltip=descricao2")
            oChart.Series("META").Points.DataBind(oDataReader(2), "data", "meta", "Tooltip=descricao3")

            'Configura Séries
            For j As Integer = 0 To oChart.Series.Count - 1

                oChart.Series(j).Type = Dundas.Charting.WinControl.SeriesChartType.Column
                oChart.Series(j).ShowInLegend = True
                oChart.Series(j).ShowLabelAsValue = True
                oChart.Series(j).SmartLabels.Enabled = True
                oChart.Series(j).MarkerSize = 1
                oChart.Series(j).BorderWidth = 1
                oChart.Series(j).EmptyPointStyle.Color = Color.Transparent
                oChart.Series(j).BorderStyle = ChartDashStyle.Solid
                oChart.Series(j).BorderColor = Color.Black
                oChart.Series(j).SmartLabels.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes
                oChart.Series(j).LabelFormat = "#,#0.0"

            Next

            oChart.Series("CICLO ON TIME").Color = Color.LightGreen
            oChart.Series("CICLO ATRASADO").Color = Color.Firebrick
            oChart.Series("META").Color = Color.LightBlue
            oChart.Series("META").BorderStyle = ChartDashStyle.Solid
            oChart.Series("META").BorderColor = Color.Black
            oChart.Series("META").Type = Dundas.Charting.WinControl.SeriesChartType.Line
            oChart.Series("META").BorderWidth = 4
            oChart.Series("META").ShowLabelAsValue = False

            oChart.Name = "INDICADOR DE PROJETO - ETAPA " + sEtapa

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
            oDataReader(2).Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGraficoOnTimeMensal(ByVal oChart As Chart, _
                                       ByVal sDataInicio As String, _
                                       ByVal sDataTermino As String, _
                                       ByVal iTolerancia As Integer, _
                                       ByVal sCodigoFornecedor As String, _
                                       ByVal iMeta As Integer)

        'Variaveis Locais
        Dim oSqlDataSet As DataSet
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Data Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio) : i += 1

            'Seta Parametros - Data Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tolerancia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTolerancia : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoFornecedor : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "meta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iMeta : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_indicador_compras_atraso_dados", oSqlParameter)

            Dim oDataReader As DataTableReader
            Dim oDataReader2 As DataTableReader
            oDataReader = oSqlDataSet.CreateDataReader(oSqlDataSet.Tables(1))
            oDataReader2 = oSqlDataSet.CreateDataReader(oSqlDataSet.Tables(1))

            'Define Título
            oChart.Titles.Clear()
            oChart.Titles.Add("OnTime Mensal")
            oChart.Legends(0).LegendStyle = WinControl.LegendStyle.Row

            'Limpa Série
            oChart.Series.Clear()

            'Formatando o eixo X de acordo com o valor escolhido
            oChart.ChartAreas(0).AxisX.Title = "PERÍODO"
            oChart.ChartAreas(0).AxisY.Title = "QUANTIDADE ITEM"


            'Adiciona Série
            oChart.Series.Add("Quantidade OnTime")
            oChart.Series.Add("Quantidade Late")


            'Carrega Gráfico
            oChart.Series("Quantidade OnTime").Points.DataBind(oDataReader, "data_mensal", "quantidade_ontime_mensal", "Tooltip=descricao_mensal")
            oChart.Series("Quantidade Late").Points.DataBind(oDataReader2, "data_mensal", "quantidade_late_mensal", "Tooltip=descricao2_mensal")

            'Configura Séries
            oChart.Series("Quantidade OnTime").Type = Dundas.Charting.WinControl.SeriesChartType.Column
            oChart.Series("Quantidade OnTime").ShowInLegend = False
            oChart.Series("Quantidade OnTime").ShowLabelAsValue = True
            oChart.Series("Quantidade OnTime").SmartLabels.Enabled = False
            oChart.Series("Quantidade OnTime").MarkerSize = 1
            oChart.Series("Quantidade OnTime").BorderWidth = 1
            oChart.Series("Quantidade OnTime").Color = Color.Green

            oChart.Series("Quantidade Late").Type = Dundas.Charting.WinControl.SeriesChartType.Column
            oChart.Series("Quantidade Late").ShowInLegend = False
            oChart.Series("Quantidade Late").ShowLabelAsValue = True
            oChart.Series("Quantidade Late").SmartLabels.Enabled = False
            oChart.Series("Quantidade Late").MarkerSize = 1
            oChart.Series("Quantidade Late").BorderWidth = 1
            oChart.Series("Quantidade Late").Color = Color.Red


            oChart.Name = "PERFORMANCE DE FORNECEDORES - ATRASO"

            oChart.Series("Quantidade OnTime").SmartLabels.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes
            oChart.Series("Quantidade OnTime").LabelFormat = "#,#0.00"

            oChart.Series("Quantidade Late").SmartLabels.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes
            oChart.Series("Quantidade Late").LabelFormat = "#,#0.00"


            'Exibe Label quando foi diferente de 0
            For Each oSeries As Series In oChart.Series
                For Each oDataPoint As DataPoint In oSeries.Points
                    If oDataPoint.YValues(0) <> 0 Then
                        oDataPoint.ShowLabelAsValue = False
                        oDataPoint("XValue") = "valor"
                        'oDataPoint("LabelStyle") = "Inside"
                    End If
                Next
                oSeries.Font = New Font("Arial", 8)
            Next

            oChart.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
            oChart.ChartAreas(0).AxisX.Interval = 1
            oChart.ChartAreas(0).ReCalc()
            oChart.Series("Quantidade OnTime").ShowInLegend = True
            oChart.Series("Quantidade OnTime").SmartLabels.Enabled = True
            oChart.Series("Quantidade Late").ShowInLegend = True
            oChart.Series("Quantidade Late").SmartLabels.Enabled = True

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class

