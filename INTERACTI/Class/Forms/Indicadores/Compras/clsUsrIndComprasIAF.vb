Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Dundas.Charting.WinControl
Imports Dundas.Charting
Imports Janus.Windows.GridEX.EditControls
Imports System.IO
Imports System.Drawing.Imaging

Public Class clsUsrIndComprasIAF

    Private sStatus As String

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal oGridMensal As GridEX, _
                        ByVal iAno As Integer, _
                        ByVal iMes As Integer, _
                        ByVal lCodigoFornecedor As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ano"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iAno : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mes"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iMes : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoFornecedor : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_indicador_compras_iaf", oSqlParameter)

            'Configura DataMember
            ConfigurarDataMemberGrid(oGrid)
            ConfigurarDataMemberGrid(oGridMensal)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGridMensal.DataSource = oDataSet.DefaultViewManager
            oGridMensal.DataMember = oDataSet.Tables(1).TableName : oGridMensal.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadChartPlacar(ByVal oChart As Chart, _
                               ByVal iAno As Integer, _
                               ByVal iMes As Integer, _
                               ByVal iCodigoCategoria As Integer, _
                               ByVal sData As String, _
                               ByVal sStatus As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oDataReader(4) As DataTableReader
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ano"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iAno : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mes"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iMes : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_categoria"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCategoria : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sStatus = "", DBNull.Value, sStatus) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_indicador_compras_iaf_placar", oSqlParameter)


            'Cria um DataReader através da Table do DataSet
            oDataReader(0) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            oDataReader(1) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            oDataReader(2) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            oDataReader(3) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            oDataReader(4) = oDataSet.CreateDataReader(oDataSet.Tables(0))

            '******************** CONFIGURA GRÁFICO IAF *******************************

            'Define Título
            oChart.Titles.Clear()
            oChart.Titles.Add("Placar IAF - " & sData)
            oChart.Legends(0).LegendStyle = WinControl.LegendStyle.Row

            'Limpa Série
            oChart.Series.Clear()

            'Formatando o eixo X de acordo com o valor escolhido
            oChart.ChartAreas(0).AxisX.Title = "FORNECEDOR"
            oChart.ChartAreas(0).AxisY.Title = "PERCENTUAL"
            oChart.ChartAreas(0).AxisX.LabelsAutoFit = False
            oChart.ChartAreas(0).AxisX.LabelStyle.Font = New System.Drawing.Font("Micosoft Sans Serif", 7.0, System.Drawing.FontStyle.Regular)

            'Adiciona Série
            oChart.Series.Add("MEDIA IAF")
            oChart.Series.Add("IAF MENSAL")
            oChart.Series.Add("QUALIFICADO")
            oChart.Series.Add("EM DESENVOLVIMENTO")
            oChart.Series.Add("SOB AÇÕES CORRETIVAS")

            'Carrega Gráfico
            oChart.Series("MEDIA IAF").Points.DataBind(oDataReader(0), "fornecedor", "media_iaf", "Tooltip=descricao1")
            oChart.Series("IAF MENSAL").Points.DataBind(oDataReader(1), "fornecedor", "iaf", "Tooltip=descricao2")
            oChart.Series("QUALIFICADO").Points.DataBind(oDataReader(2), "fornecedor", "qualificado", "Tooltip=descricao3")
            oChart.Series("EM DESENVOLVIMENTO").Points.DataBind(oDataReader(3), "fornecedor", "em_desenvolvimento", "Tooltip=descricao4")
            oChart.Series("SOB AÇÕES CORRETIVAS").Points.DataBind(oDataReader(4), "fornecedor", "sob_acoes_corretivas", "Tooltip=descricao5")

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


            oChart.Series("MEDIA IAF").Color = Color.LightBlue
            oChart.Series("IAF MENSAL").Color = Color.LightGreen
            oChart.Series("QUALIFICADO").Type = Dundas.Charting.WinControl.SeriesChartType.Line
            oChart.Series("QUALIFICADO").Color = Color.Green
            oChart.Series("QUALIFICADO").BorderWidth = 4
            oChart.Series("EM DESENVOLVIMENTO").Type = Dundas.Charting.WinControl.SeriesChartType.Line
            oChart.Series("EM DESENVOLVIMENTO").Color = Color.Orange
            oChart.Series("EM DESENVOLVIMENTO").BorderWidth = 4
            oChart.Series("SOB AÇÕES CORRETIVAS").Type = Dundas.Charting.WinControl.SeriesChartType.Line
            oChart.Series("SOB AÇÕES CORRETIVAS").Color = Color.Red
            oChart.Series("SOB AÇÕES CORRETIVAS").BorderWidth = 4

            oChart.Name = "Placar IAF - " & sData

            oChart.ChartAreas(0).Area3DStyle.Enable3D = False
            oChart.ChartAreas(0).AxisY.MajorGrid.LineStyle = ChartDashStyle.Dot
            oChart.ChartAreas(0).AxisX.MajorGrid.LineStyle = ChartDashStyle.Dot
            oChart.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
            oChart.ChartAreas(0).AxisX.Interval = 1
            oChart.ChartAreas(0).ReCalc()
            oChart.Legends(0).Alignment = StringAlignment.Center
            oChart.Legends(0).Docking = LegendDocking.Bottom
            oChart.Legends(0).LegendStyle = LegendStyle.Row

            oDataReader(0).Close()
            oDataReader(1).Close()
            oDataReader(2).Close()
            oDataReader(3).Close()
            oDataReader(4).Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrafico(ByVal oChrIAF As Chart, _
                           ByVal iAno As Integer, _
                           ByVal iMes As Integer, _
                           ByVal lCodigoFornecedor As Long, _
                           ByVal sFornecedor As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oDataReader(5) As DataTableReader
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sStatus : i += 1

            'Seta Parametros - Data Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ano"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iAno : i += 1

            'Seta Parametros - Data Termino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mes"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iMes : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoFornecedor : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_indicador_compras_iaf2", oSqlParameter)

            sStatus = oSqlParameter(0).Value

            'Cria um DataReader através da Table do DataSet
            oDataReader(0) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            oDataReader(1) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            oDataReader(2) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            oDataReader(3) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            oDataReader(4) = oDataSet.CreateDataReader(oDataSet.Tables(0))
            oDataReader(5) = oDataSet.CreateDataReader(oDataSet.Tables(0))

            '******************** CONFIGURA GRÁFICO IAF *******************************

            'Define Título
            oChrIAF.Titles.Clear()
            oChrIAF.Titles.Add("IAF - " & sFornecedor & "                                                                                              STATUS: " & sStatus)
            oChrIAF.Legends(0).LegendStyle = WinControl.LegendStyle.Row

            'Limpa Série
            oChrIAF.Series.Clear()

            'Formatando o eixo X de acordo com o valor escolhido
            oChrIAF.ChartAreas(0).AxisX.Title = "PERÍODO"
            oChrIAF.ChartAreas(0).AxisY.Title = "PERCENTUAL"


            'Adiciona Série
            oChrIAF.Series.Add("ATENDIMENTO")
            oChrIAF.Series.Add("QUALIDADE")
            oChrIAF.Series.Add("IAF")
            oChrIAF.Series.Add("QUALIFICADO")
            oChrIAF.Series.Add("EM DESENVOLVIMENTO")
            oChrIAF.Series.Add("SOB AÇÕES CORRETIVAS")

            'Carrega Gráfico
            oChrIAF.Series("ATENDIMENTO").Points.DataBind(oDataReader(0), "data", "atendimento", "Tooltip=descricao1")
            oChrIAF.Series("QUALIDADE").Points.DataBind(oDataReader(1), "data", "qualidade", "Tooltip=descricao2")
            oChrIAF.Series("IAF").Points.DataBind(oDataReader(2), "data", "iaf", "Tooltip=descricao3")
            oChrIAF.Series("QUALIFICADO").Points.DataBind(oDataReader(3), "data", "qualificado", "Tooltip=descricao4")
            oChrIAF.Series("EM DESENVOLVIMENTO").Points.DataBind(oDataReader(4), "data", "em_desenvolvimento", "Tooltip=descricao5")
            oChrIAF.Series("SOB AÇÕES CORRETIVAS").Points.DataBind(oDataReader(5), "data", "sob_acoes_corretivas", "Tooltip=descricao6")

            'Configura Séries
            For j As Integer = 0 To oChrIAF.Series.Count - 1

                oChrIAF.Series(j).Type = Dundas.Charting.WinControl.SeriesChartType.Column
                oChrIAF.Series(j).ShowInLegend = True
                'oChrIAF.Series(j).ShowLabelAsValue = True
                oChrIAF.Series(j).SmartLabels.Enabled = True
                oChrIAF.Series(j).MarkerSize = 1
                oChrIAF.Series(j).BorderWidth = 1
                oChrIAF.Series(j).EmptyPointStyle.Color = Color.Transparent
                oChrIAF.Series(j).BorderStyle = ChartDashStyle.Solid
                oChrIAF.Series(j).BorderColor = Color.Black

                oChrIAF.Series(j).SmartLabels.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes
                oChrIAF.Series(j).LabelFormat = "#,#0.0"

            Next

            oChrIAF.Series("ATENDIMENTO").Color = Color.LightBlue
            oChrIAF.Series("QUALIDADE").Color = Color.LightGray
            oChrIAF.Series("IAF").Color = Color.LightGreen
            oChrIAF.Series("QUALIFICADO").Type = Dundas.Charting.WinControl.SeriesChartType.Line
            oChrIAF.Series("QUALIFICADO").Color = Color.Green
            oChrIAF.Series("QUALIFICADO").BorderWidth = 4
            oChrIAF.Series("EM DESENVOLVIMENTO").Type = Dundas.Charting.WinControl.SeriesChartType.Line
            oChrIAF.Series("EM DESENVOLVIMENTO").Color = Color.Orange
            oChrIAF.Series("EM DESENVOLVIMENTO").BorderWidth = 4
            oChrIAF.Series("SOB AÇÕES CORRETIVAS").Type = Dundas.Charting.WinControl.SeriesChartType.Line
            oChrIAF.Series("SOB AÇÕES CORRETIVAS").Color = Color.Red
            oChrIAF.Series("SOB AÇÕES CORRETIVAS").BorderWidth = 4

            oChrIAF.Name = "IAF - " & sFornecedor & "        STATUS:" & sStatus

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

    Public Sub InsertGrafico(ByVal picGrafico As PictureBox, _
                             ByVal sFornecedor As String, _
                             ByVal iAno As Integer, _
                             ByVal iMes As Integer)

        Try

            'Variaveis Locais
            Dim oSqlParameter(3) As SqlParameter
            Dim i As Integer = 0

            'Carrega Imagem
            Dim oMemoryStream As MemoryStream = New MemoryStream()
            picGrafico.Image.Save(oMemoryStream, ImageFormat.Png)
            Dim bytBLOBData(oMemoryStream.Length - 1) As Byte
            oMemoryStream.Position = 0
            oMemoryStream.Read(bytBLOBData, 0, oMemoryStream.Length)

            'Seta Parametros - Gráfico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "grafico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
            oSqlParameter(i).Value = bytBLOBData : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sFornecedor : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ano"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iAno : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mes"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iMes

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_iaf_grafico", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class

