Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Dundas.Charting.WinControl
Imports Dundas.Charting
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrIndCompras2

    Private Enum TipoGrafico
        OnTimexPO = 1
        OnTimeMensal = 2
        IQF = 3
    End Enum

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal sGrupoTecnologia As String, _
                        ByVal sCodigoFornecedor As String, _
                        ByVal iTolerancia As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(5) As SqlParameter
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
            oSqlParameter(i).ParameterName = "codigo_grupo_tecnologia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sGrupoTecnologia = "", DBNull.Value, sGrupoTecnologia) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sCodigoFornecedor = "", DBNull.Value, sCodigoFornecedor) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tolerancia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iTolerancia : i += 1

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

    Public Sub LoadGridDados(ByVal oGrid As GridEX, _
                             ByVal sCodigoFornecedor As String, _
                             ByVal sDataInicio As String, _
                             ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.varchar
            oSqlParameter(i).Value = sCodigoFornecedor : i += 1

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

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_indicador_compras_dados", oSqlParameter)

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

    Public Sub LoadGraficoPO(ByVal oChrPO As Chart, _
                             ByVal oChrMensal As Chart, _
                             ByVal oChrIAF As Chart, _
                             ByVal sDataInicio As String, _
                             ByVal sDataTermino As String, _
                             ByVal iTolerancia As Integer, _
                             ByVal sCodigoFornecedor As String, _
                             ByVal iMeta As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oDataReader(5) As DataTableReader
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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_indicador_compras_atraso_dados", oSqlParameter)

            'Cria um DataReader através da Table do DataSet
            oDataReader(0) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            oDataReader(1) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            oDataReader(2) = oDataSet.CreateDataReader(oDataSet.Tables(1))
            oDataReader(3) = oDataSet.CreateDataReader(oDataSet.Tables(1))
            oDataReader(4) = oDataSet.CreateDataReader(oDataSet.Tables(2))
            oDataReader(5) = oDataSet.CreateDataReader(oDataSet.Tables(2))


            'Define Título
            oChrPO.Titles.Clear()
            oChrPO.Titles.Add("OnTime x PO")
            oChrPO.Legends(0).LegendStyle = WinControl.LegendStyle.Row

            'Limpa Série
            oChrPO.Series.Clear()

            'Formatando o eixo X de acordo com o valor escolhido
            oChrPO.ChartAreas(0).AxisX.Title = "PERÍODO"
            oChrPO.ChartAreas(0).AxisY.Title = "QUANTIDADE ITEM"

            'Adiciona Série
            oChrPO.Series.Add("Quantidade OnTime")
            oChrPO.Series.Add("Quantidade Late")


            'Carrega Gráfico
            oChrPO.Series("Quantidade OnTime").Points.DataBind(oDataReader(0), "data_po", "quantidade_ontime_po", "Tooltip=descricao_po")
            oChrPO.Series("Quantidade Late").Points.DataBind(oDataReader(1), "data_po", "quantidade_late_po", "Tooltip=descricao2_po")

            'Configura Séries
            For j As Integer = 0 To oChrPO.Series.Count - 1

                oChrPO.Series(j).Type = Dundas.Charting.WinControl.SeriesChartType.Column
                oChrPO.Series(j).ShowInLegend = True
                oChrPO.Series(j).ShowLabelAsValue = True
                oChrPO.Series(j).SmartLabels.Enabled = True
                oChrPO.Series(j).MarkerSize = 1
                oChrPO.Series(j).BorderWidth = 1
                oChrPO.Series(j).EmptyPointStyle.Color = Color.Transparent
                oChrPO.Series(j).BorderStyle = ChartDashStyle.Solid
                oChrPO.Series(j).BorderColor = Color.Black
                oChrPO.Series(j).SmartLabels.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes
                oChrPO.Series(j).LabelFormat = "#,#0.0"

            Next

            oChrPO.Series("Quantidade Late").Color = Color.Firebrick
            oChrPO.Series("Quantidade OnTime").Color = Color.LightGreen

            oChrPO.Name = "PERFORMANCE DE FORNECEDORES - ATRASO"

            oChrPO.ChartAreas(0).Area3DStyle.Enable3D = False
            oChrPO.ChartAreas(0).AxisY.MajorGrid.LineStyle = ChartDashStyle.Dot
            oChrPO.ChartAreas(0).AxisX.MajorGrid.LineStyle = ChartDashStyle.Dot
            oChrPO.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
            oChrPO.ChartAreas(0).AxisX.Interval = 1
            oChrPO.ChartAreas(0).ReCalc()
            oChrPO.Legends(0).Alignment = StringAlignment.Center
            oChrPO.Legends(0).Docking = LegendDocking.Bottom
            oChrPO.Legends(0).LegendStyle = LegendStyle.Row

            '********************* Configura Gráfico Mensal ***********************

            'Define Título
            oChrMensal.Titles.Clear()
            oChrMensal.Titles.Add("OnTime Mensal")
            oChrMensal.Legends(0).LegendStyle = WinControl.LegendStyle.Row

            'Limpa Série
            oChrMensal.Series.Clear()

            'Formatando o eixo X de acordo com o valor escolhido
            oChrMensal.ChartAreas(0).AxisX.Title = "PERÍODO"
            oChrMensal.ChartAreas(0).AxisY.Title = "QUANTIDADE ITEM"

            'Adiciona Série
            oChrMensal.Series.Add("Quantidade OnTime")
            oChrMensal.Series.Add("Quantidade Late")


            'Carrega Gráfico
            oChrMensal.Series("Quantidade OnTime").Points.DataBind(oDataReader(2), "data_mensal", "quantidade_ontime_mensal", "Tooltip=descricao_mensal")
            oChrMensal.Series("Quantidade Late").Points.DataBind(oDataReader(3), "data_mensal", "quantidade_late_mensal", "Tooltip=descricao2_mensal")

            'Configura Séries
            For k As Integer = 0 To oChrPO.Series.Count - 1

                oChrMensal.Series(k).Type = Dundas.Charting.WinControl.SeriesChartType.Column
                oChrMensal.Series(k).ShowInLegend = True
                oChrMensal.Series(k).ShowLabelAsValue = True
                oChrMensal.Series(k).SmartLabels.Enabled = True
                oChrMensal.Series(k).MarkerSize = 1
                oChrMensal.Series(k).BorderWidth = 1
                oChrMensal.Series(k).EmptyPointStyle.Color = Color.Transparent
                oChrMensal.Series(k).BorderStyle = ChartDashStyle.Solid
                oChrMensal.Series(k).BorderColor = Color.Black
                oChrMensal.Series(k).SmartLabels.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes
                oChrMensal.Series(k).LabelFormat = "#,#0.0"

            Next

            oChrMensal.Series("Quantidade Late").Color = Color.Firebrick
            oChrMensal.Series("Quantidade OnTime").Color = Color.LightGreen

            oChrMensal.Name = "PERFORMANCE DE FORNECEDORES - ATRASO"

            oChrMensal.ChartAreas(0).Area3DStyle.Enable3D = False
            oChrMensal.ChartAreas(0).AxisY.MajorGrid.LineStyle = ChartDashStyle.Dot
            oChrMensal.ChartAreas(0).AxisX.MajorGrid.LineStyle = ChartDashStyle.Dot
            oChrMensal.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
            oChrMensal.ChartAreas(0).AxisX.Interval = 1
            oChrMensal.ChartAreas(0).ReCalc()
            oChrMensal.Legends(0).Alignment = StringAlignment.Center
            oChrMensal.Legends(0).Docking = LegendDocking.Bottom
            oChrMensal.Legends(0).LegendStyle = LegendStyle.Row

            '******************** CONFIGURA GRÁFICO IAF *******************************

            'Define Título
            oChrIAF.Titles.Clear()
            oChrIAF.Titles.Add("IAF")
            oChrIAF.Legends(0).LegendStyle = WinControl.LegendStyle.Row

            'Limpa Série
            oChrIAF.Series.Clear()

            'Formatando o eixo X de acordo com o valor escolhido
            oChrIAF.ChartAreas(0).AxisX.Title = "PERÍODO"
            oChrIAF.ChartAreas(0).AxisY.Title = "QUANTIDADE ITEM"

            'Adiciona Série
            oChrIAF.Series.Add("Porcentagem IAF")
            oChrIAF.Series.Add("Meta")

            'Carrega Gráfico
            oChrIAF.Series("Porcentagem IAF").Points.DataBind(oDataReader(4), "data_iaf", "Porcentagem IAF", "Tooltip=descricao_iaf")
            oChrIAF.Series("Meta").Points.DataBind(oDataReader(5), "data_iaf", "meta", "Tooltip=descricao_iaf")

            'Configura Séries
            For l As Integer = 0 To oChrIAF.Series.Count - 1

                oChrIAF.Series(l).Type = Dundas.Charting.WinControl.SeriesChartType.Column
                oChrIAF.Series(l).ShowInLegend = True
                oChrIAF.Series(l).ShowLabelAsValue = True
                oChrIAF.Series(l).SmartLabels.Enabled = True
                oChrIAF.Series(l).MarkerSize = 1
                oChrIAF.Series(l).BorderWidth = 1
                oChrIAF.Series(l).EmptyPointStyle.Color = Color.Transparent
                oChrIAF.Series(l).BorderStyle = ChartDashStyle.Solid
                oChrIAF.Series(l).BorderColor = Color.Black
                oChrIAF.Series(l).SmartLabels.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes
                oChrIAF.Series(l).LabelFormat = "#,#0.0"

            Next

            oChrIAF.Series("Porcentagem IAF").Color = Color.LightBlue
            oChrIAF.Series("Meta").Color = Color.Red
            oChrIAF.Series("Meta").BorderWidth = 4
            oChrIAF.Series("Meta").Type = Dundas.Charting.WinControl.SeriesChartType.Line
            oChrIAF.Series("Meta").ShowLabelAsValue = False


            If oDataSet.Tables(2).Rows.Count = 1 Then
                oChrIAF.Series("Meta").Type = Dundas.Charting.WinControl.SeriesChartType.Column
            End If

            oChrIAF.Name = "PERFORMANCE DE FORNECEDORES - ATRASO"

            oChrIAF.ChartAreas(0).Area3DStyle.Enable3D = False
            oChrIAF.ChartAreas(0).AxisY.MajorGrid.LineStyle = ChartDashStyle.Dot
            oChrIAF.ChartAreas(0).AxisX.MajorGrid.LineStyle = ChartDashStyle.Dot
            oChrIAF.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
            oChrIAF.ChartAreas(0).AxisX.Interval = 1
            oChrIAF.ChartAreas(0).ReCalc()
            oChrIAF.Legends(0).Alignment = StringAlignment.Center
            oChrIAF.Legends(0).Docking = LegendDocking.Bottom
            oChrIAF.Legends(0).LegendStyle = LegendStyle.Row

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

    Public Sub LoadGraficoIAF(ByVal oChart As Chart, _
                              ByVal sDataInicio As String, _
                              ByVal sDataTermino As String, _
                              ByVal iTolerancia As Integer, _
                              ByVal sCodigoFornecedor As String, _
                              ByVal iMeta As Integer)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlDataReader2 As SqlDataReader
        Dim oSqlDataReader3 As SqlDataReader
        Dim oSqlParameter(6) As SqlParameter
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
            oSqlParameter(i).SqlDbType = SqlDbType.varchar
            oSqlParameter(i).Value = sCodigoFornecedor : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = TipoGrafico.IQF : i += 1

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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_indicador_compras_atraso_dados", oSqlParameter)
            'oSqlDataReader2 = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_indicador_compras_atraso_dados", oSqlParameter)
            oSqlDataReader3 = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_indicador_compras_atraso_dados", oSqlParameter)

            'Define Título
            oChart.Titles.Clear()
            oChart.Titles.Add("IAF")
            oChart.Legends(0).LegendStyle = WinControl.LegendStyle.Row

            'Limpa Série
            oChart.Series.Clear()

            'Formatando o eixo X de acordo com o valor escolhido
            oChart.ChartAreas(0).AxisX.Title = "PERÍODO"
            oChart.ChartAreas(0).AxisY.Title = "QUANTIDADE ITEM"


            'Adiciona Série
            oChart.Series.Add("Meta")
            oChart.Series.Add("Porcentagem IAF")
            'oChart.Series.Add("Quantidade Total")

            'Carrega Gráfico
            oChart.Series("Porcentagem IAF").Points.DataBind(oSqlDataReader, "data", "Porcentagem IAF", "Tooltip=descricao")
            'oChart.Series("Quantidade OnTime").Points.DataBind(oSqlDataReader2, "data", "quantidade_ontime", "Tooltip=descricao2")
            oChart.Series("Meta").Points.DataBind(oSqlDataReader3, "data", "meta", "Tooltip=descricao3")

            'Configura Séries
            For j As Integer = 0 To oChart.Series.Count - 1

                oChart.Series(j).Type = Dundas.Charting.WinControl.SeriesChartType.Line
                oChart.Series(j).ShowInLegend = True
                oChart.Series(j).ShowLabelAsValue = True
                oChart.Series(j).SmartLabels.Enabled = True
                oChart.Series(j).MarkerSize = 1
                oChart.Series(j).BorderWidth = 1

                oChart.Series(j).SmartLabels.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes
                oChart.Series(j).LabelFormat = "#,#0.00"

            Next

            oChart.Series("Porcentagem IAF").Type = Dundas.Charting.WinControl.SeriesChartType.Column
            oChart.Series("Porcentagem IAF").Color = Color.Blue
            'oChart.Series("Quantidade OnTime").Color = Color.Green
            oChart.Series("Meta").Color = Color.Red

            oChart.Name = "PERFORMANCE DE FORNECEDORES - ATRASO"

            ''Exibe Label quando foi diferente de 0
            'For Each oSeries As Series In oChart.Series
            '    For Each oDataPoint As DataPoint In oSeries.Points
            '        If oDataPoint.YValues(0) <> 0 Then
            '            oDataPoint.ShowLabelAsValue = False
            '            oDataPoint("XValue") = "valor"
            '            'oDataPoint("LabelStyle") = "Inside"
            '        End If
            '    Next
            '    oSeries.Font = New Font("Arial", 8)
            'Next

            oChart.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
            oChart.ChartAreas(0).AxisX.Interval = 1
            oChart.ChartAreas(0).ReCalc()

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()
            'If oSqlDataReader2.IsClosed = False Then oSqlDataReader2.Close()
            If oSqlDataReader3.IsClosed = False Then oSqlDataReader3.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class

