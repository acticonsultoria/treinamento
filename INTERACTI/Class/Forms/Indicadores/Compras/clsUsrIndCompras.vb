Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Dundas.Charting.WinControl
Imports Janus.Windows.GridEX

Public Class clsUsrIndCompras

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGridSintetico As GridEX, _
                        ByVal oGridAnalitico As GridEX, _
                        ByVal oChart As Chart, _
                        ByVal sTipo As String, _
                        ByVal sFornecedor As String, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal iMeta As Integer, _
                        ByVal sGrupoTecnologia As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlDataReader2 As SqlDataReader
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0
        Dim sProcedure As String = LoadCodigo("sp_select_static_indicador_procedure " & sTipo)
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

            'Seta Parametros - Código Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sFornecedor : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_tecnologia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sGrupoTecnologia : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, sProcedure, oSqlParameter)
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, sProcedure, oSqlParameter)
            oSqlDataReader2 = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, sProcedure, oSqlParameter)
            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGridSintetico)

            'Carrega Grid
            oGridSintetico.DataSource = oDataSet.DefaultViewManager
            oGridSintetico.DataMember = oDataSet.Tables(0).TableName


            'Formata o total
            If sTipo = "atraso" Then

                oGridSintetico.RootTable.Columns("valor").AggregateFunction = AggregateFunction.Average
                oGridSintetico.RootTable.Columns("valor").TotalFormatString = "Méd: 000"

            Else
                oGridSintetico.RootTable.Columns("valor").AggregateFunction = AggregateFunction.Sum
                oGridSintetico.RootTable.Columns("valor").TotalFormatString = "#,#0.00"


            End If

            '******  Preenche a grid de analitico *******
            oGridAnalitico.RootTable.Columns.Clear()


            For Each oDataColumn As DataColumn In oDataSet.Tables(1).Columns

                oGridAnalitico.RootTable.Columns.Add(oDataColumn.ColumnName)
                If oDataColumn.ColumnName.Contains("VALOR") Or oDataColumn.ColumnName.Contains("QUANTIDADE") Then
                    oGridAnalitico.RootTable.Columns(oDataColumn.ColumnName).AggregateFunction = AggregateFunction.Sum
                    oGridAnalitico.RootTable.Columns(oDataColumn.ColumnName).TextAlignment = TextAlignment.Far
                    oGridAnalitico.RootTable.Columns(oDataColumn.ColumnName).FormatString = "#,#0.00"
                    oGridAnalitico.RootTable.Columns(oDataColumn.ColumnName).TotalFormatString = "#,#0.00"
                    oGridAnalitico.FilterRowButtonStyle = FilterRowButtonStyle.ConditionOperatorDropDown
                End If



            Next

            Call ConfigurarDataMemberGrid(oGridAnalitico)
            oGridAnalitico.DataSource = oDataSet.DefaultViewManager
            oGridAnalitico.DataMember = oDataSet.Tables(1).TableName


            '******  Preenche a grid de analitico *******


            'Agora configura o gráfico

            'Limpa Série
            oChart.Series.Clear()

            Dim sNomeSerie As String = LoadCodigo("sp_select_static_indicador_nome_serie " & sTipo)
            Dim sNomeSerie2 As String = LoadCodigo("sp_select_static_indicador_nome_serie2 " & sTipo)

            'Adiciona Série
            oChart.Series.Add(sNomeSerie)

            'Carrega Gráfico
            oChart.Series(sNomeSerie).Points.DataBind(oSqlDataReader, "descricao", "valor", "Tooltip=descricao")

            'Configura Séries
            oChart.Series(sNomeSerie).ShowInLegend = True
            oChart.Series(sNomeSerie).SmartLabels.Enabled = True

            If sNomeSerie2 <> "" Then

                'Adiciona Série
                oChart.Series.Add(sNomeSerie2)

                'Carrega Gráfico
                oChart.Series(sNomeSerie2).Points.DataBind(oSqlDataReader2, "descricao2", "valor2", "Tooltip=descricao2")

                'Configura Séries
                oChart.Series(sNomeSerie2).ShowInLegend = True
                oChart.Series(sNomeSerie2).SmartLabels.Enabled = True

            End If

            oSqlDataReader.Close()
            oSqlDataReader2.Close()

            'Formata o gráfic

            FormataGrafico(oChart, _
                           oGridSintetico, _
                           sTipo, _
                           iMeta)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub FormataGrafico(ByVal oChart As Chart, _
                              ByVal oGridSintetico As GridEX, _
                              ByVal sTipo As String, _
                              ByVal iMeta As Integer)

        Try


            Dim sNomeSerie As String = LoadCodigo("sp_select_static_indicador_nome_serie " & sTipo)
            Dim sNomeSerie2 As String = LoadCodigo("sp_select_static_indicador_nome_serie2 " & sTipo)
            Dim sTipoGrafico As String = LoadCodigo("sp_select_static_indicador_tipo_grafico " & sTipo)
            Dim sEixoX As String = LoadCodigo("sp_select_static_indicador_eixo_x " & sTipo)
            Dim sEixoy As String = LoadCodigo("sp_select_static_indicador_eixo_y " & sTipo)

            oChart.Series(sNomeSerie).LabelFormat = "#,#0.00"
            oChart.Series(sNomeSerie).ShowInLegend = False

            oChart.ChartAreas(0).AxisX.Title = sEixoX
            oChart.ChartAreas(0).AxisY.Title = sEixoy


            Select Case sTipoGrafico
                Case "COLUMN"
                    oChart.Series(sNomeSerie).Type = SeriesChartType.Column
                    oChart.ChartAreas(0).Area3DStyle.Enable3D = False

                Case "LINE"
                    oChart.Series(sNomeSerie).Type = SeriesChartType.Line
                    oChart.ChartAreas(0).Area3DStyle.Enable3D = False

                Case "PIZZA"
                    oChart.Series(sNomeSerie).Type = SeriesChartType.Doughnut
                    oChart.ChartAreas(0).Area3DStyle.Enable3D = True


                Case Else


            End Select



            If sNomeSerie2 <> "" Then


                oChart.Series(sNomeSerie2).LabelFormat = "#,#0.00"
                oChart.Series(sNomeSerie).ShowInLegend = True
                oChart.Series(sNomeSerie2).ShowInLegend = True

                'oChart.ChartAreas(sNomeSerie2).AxisX.Title = sEixoX
                'oChart.ChartAreas(sNomeSerie2).AxisY.Title = sEixoy


                'Select Case sTipoGrafico
                '    Case "COLUMN"
                '        oChart.Series(sNomeSerie2).Type = SeriesChartType.Column
                '        oChart.ChartAreas(sNomeSerie2).Area3DStyle.Enable3D = False

                '    Case "LINE"
                '        oChart.Series(sNomeSerie2).Type = SeriesChartType.Line
                '        oChart.ChartAreas(sNomeSerie2).Area3DStyle.Enable3D = False

                '    Case "PIZZA"
                '        oChart.Series(sNomeSerie2).Type = SeriesChartType.Doughnut
                '        oChart.ChartAreas(sNomeSerie2).Area3DStyle.Enable3D = True


                '    Case Else


                'End Select

            End If



            If iMeta > 0 Then
                oChart.Series.Add("META").Type = SeriesChartType.Line
                oChart.Series("META").ShowInLegend = True
                oChart.Series("META").Type = Dundas.Charting.WinControl.SeriesChartType.Line
                oChart.Series("META").ShowLabelAsValue = False
                oChart.Series("META").MarkerStyle = Dundas.Charting.WinControl.MarkerStyle.Square
                oChart.Series("META").MarkerSize = 8
                oChart.Series("META").BorderWidth = 6
                oChart.Series("META").Color = Color.Green

                For Each oRow In oGridSintetico.GetRows

                    oChart.Series("META").Points.AddXY(oRow.Cells.Item("descricao").Value, _
                                                       iMeta)

                Next

            End If


            oChart.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
            oChart.ChartAreas(0).AxisX.Interval = 1
            oChart.ChartAreas(0).ReCalc()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'Public Sub LoadGrafico(ByVal oChart As Chart, _
    '                       ByVal sDataInicio As String, _
    '                       ByVal sDataTermino As String)

    '    'Variaveis Locais
    '    Dim oSqlDataReader As SqlDataReader
    '    Dim oSqlParameter(3) As SqlParameter
    '    Dim i As Integer = 0

    '    Try

    '        'Seta Parametros - Data Início
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "data_inicio"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.DateTime
    '        oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

    '        'Seta Parametros - Data Término
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "data_termino"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.DateTime
    '        oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

    '        'Seta Parametros - Código Empresa
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "codigo_empresa"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
    '        oSqlParameter(i).Value = goUsuario.iEmpresa

    '        'Executa Query
    '        oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_chart_cmp000000001", oSqlParameter)

    '        'Limpa Série
    '        oChart.Series.Clear()

    '        'Adiciona Série
    '        oChart.Series.Add("Default")

    '        'Carrega Gráfico
    '        oChart.Series("Default").Points.DataBind(oSqlDataReader, "estado", "valor", "Tooltip=tag")

    '        'Configura Séries
    '        oChart.Series("Default").ShowInLegend = True
    '        oChart.Series("Default").Type = SeriesChartType.Doughnut
    '        oChart.Series("Default").SmartLabels.Enabled = True
    '        oChart.ChartAreas("Default").Area3DStyle.Enable3D = True
    '        oChart.Series("Default").LabelFormat = "0.00%"

    '        'Exibe Label quando foi diferente de 0
    '        For Each oSeries As Series In oChart.Series
    '            For Each oDataPoint As DataPoint In oSeries.Points
    '                If oDataPoint.YValues(0) <> 0 Then
    '                    oDataPoint.ShowLabelAsValue = True
    '                    oDataPoint("LabelStyle") = "Outside"
    '                End If
    '            Next
    '            oSeries.Font = New Font("Arial", 8)
    '        Next

    '        'Fecha o SqlDataReader
    '        If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

    '    Catch SqlEx As SqlException
    '        Throw SqlEx
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

#End Region

End Class

