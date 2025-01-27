Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Dundas.Charting.WinControl
Imports Janus.Windows.GridEX

Public Class clsUsrIndComercial

#Region "::: FUNCTION / SUB :::"

    Public Sub ReloadGrafico(ByVal oGrid As GridEX, _
                             ByVal oChart As Chart, _
                             ByVal iCodigoTipoGrafico As Integer, _
                             ByVal iMeta As Integer, _
                             ByVal sTipoValor As String)

        'Variaveis Locais
        Dim oDataSet As New DataSet
        Dim oDataTable As New DataTable
        Dim oDataRow As DataRow
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0
        Dim sSerie1 As String = LoadCodigo("sp_select_static_indicador_campo " & iCodigoTipoGrafico & ",'SERIE1'")
        Dim sSerie2 As String = LoadCodigo("sp_select_static_indicador_campo " & iCodigoTipoGrafico & ",'SERIE2'")
        Dim sSerie3 As String = LoadCodigo("sp_select_static_indicador_campo " & iCodigoTipoGrafico & ",'SERIE3'")
        Dim sSerie4 As String = LoadCodigo("sp_select_static_indicador_campo " & iCodigoTipoGrafico & ",'SERIE4'")
        Dim sSerie5 As String = LoadCodigo("sp_select_static_indicador_campo " & iCodigoTipoGrafico & ",'SERIE5'")
        Dim sTipoTitulo As String = LoadCodigo("sp_select_static_indicador_campo " & iCodigoTipoGrafico & ",'TIPO2'")

        Try

            oDataTable = oDataSet.Tables.Add("table")

            oDataTable.Columns.Add("descricao", "".GetType)
            oDataTable.Columns.Add("serie1", 0.0.GetType)
            oDataTable.Columns.Add("serie2", 0.0.GetType)
            oDataTable.Columns.Add("serie3", 0.0.GetType)
            oDataTable.Columns.Add("serie4", 0.0.GetType)
            oDataTable.Columns.Add("serie5", 0.0.GetType)

            For Each oRow As GridEXRow In oGrid.GetCheckedRows

                oDataRow = oDataTable.Rows.Add
                oDataRow("descricao") = oRow.Cells("descricao").Value
                oDataRow("serie1") = oRow.Cells("serie1").Value
                oDataRow("serie2") = oRow.Cells("serie2").Value
                oDataRow("serie3") = oRow.Cells("serie3").Value
                oDataRow("serie4") = oRow.Cells("serie4").Value
                oDataRow("serie5") = oRow.Cells("serie5").Value

            Next

            oDataSet = oDataTable.DataSet.Copy

            'Agora configura o gráfico
            oChart.Series.Clear()

            'Adiciona Série
            oChart.Series.Add(sSerie1)

            'Carrega Gráfico
            oChart.Series(sSerie1).Points.DataBind(oDataSet.Tables(0).CreateDataReader, "descricao", "serie1", "Tooltip=serie1")

            'Configura Séries
            oChart.Series(sSerie1).ShowInLegend = True
            oChart.Series(sSerie1).SmartLabels.Enabled = True

            If sSerie2 <> "" Then
                oChart.Series.Add(sSerie2)
                oChart.Series(sSerie2).Points.DataBind(oDataSet.Tables(0).CreateDataReader, "descricao", "serie2", "Tooltip=serie2")
                oChart.Series(sSerie2).ShowInLegend = True
                oChart.Series(sSerie2).SmartLabels.Enabled = True

            End If

            If sSerie3 <> "" Then
                oChart.Series.Add(sSerie3)
                oChart.Series(sSerie3).Points.DataBind(oDataSet.Tables(0).CreateDataReader, "descricao", "serie3", "Tooltip=serie3")
                oChart.Series(sSerie3).ShowInLegend = True
                oChart.Series(sSerie3).SmartLabels.Enabled = True

            End If

            If sSerie4 <> "" Then
                oChart.Series.Add(sSerie4)
                oChart.Series(sSerie4).Points.DataBind(oDataSet.Tables(0).CreateDataReader, "descricao", "serie4", "Tooltip=serie4")
                oChart.Series(sSerie4).ShowInLegend = True
                oChart.Series(sSerie4).SmartLabels.Enabled = True

            End If

            If sSerie5 <> "" Then
                oChart.Series.Add(sSerie5)
                oChart.Series(sSerie5).Points.DataBind(oDataSet.Tables(0).CreateDataReader, "descricao", "serie5", "Tooltip=serie5")
                oChart.Series(sSerie5).ShowInLegend = True
                oChart.Series(sSerie5).SmartLabels.Enabled = True

            End If

            'Formata o gráfic
            FormataGrafico(oChart, _
                           oGrid, _
                           iCodigoTipoGrafico, _
                           iMeta, _
                           sTipoValor)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGridSintetico As GridEX, _
                        ByVal oGridAnalitico As GridEX, _
                        ByVal oChart As Chart, _
                        ByVal iCodigoTipoGrafico As Integer, _
                        ByVal dMeta As Double, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal sTipoFiltro As String, _
                        ByVal sFiltro As String, _
                        ByVal sTipoValor As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(12) As SqlParameter
        Dim i As Integer = 0
        Dim sProcedure As String = LoadCodigo("sp_select_static_indicador_campo " & iCodigoTipoGrafico & ",'NOME_PROCEDURE'")
        Dim sSerie1 As String = LoadCodigo("sp_select_static_indicador_campo " & iCodigoTipoGrafico & ",'SERIE1'")
        Dim sSerie2 As String = LoadCodigo("sp_select_static_indicador_campo " & iCodigoTipoGrafico & ",'SERIE2'")
        Dim sSerie3 As String = LoadCodigo("sp_select_static_indicador_campo " & iCodigoTipoGrafico & ",'SERIE3'")
        Dim sSerie4 As String = LoadCodigo("sp_select_static_indicador_campo " & iCodigoTipoGrafico & ",'SERIE4'")
        Dim sSerie5 As String = LoadCodigo("sp_select_static_indicador_campo " & iCodigoTipoGrafico & ",'SERIE5'")
        Dim sTipoTitulo As String = LoadCodigo("sp_select_static_indicador_campo " & iCodigoTipoGrafico & ",'TIPO2'")

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipoValor : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_filtro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipoFiltro : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "meta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMeta : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "filtro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sFiltro : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, sProcedure, oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGridSintetico)

            'Carrega Grid
            oGridSintetico.DataSource = oDataSet.DefaultViewManager
            oGridSintetico.DataMember = oDataSet.Tables(0).TableName

            oGridSintetico.RootTable.Columns("serie1").Caption = sSerie1
            oGridSintetico.RootTable.Columns("serie2").Caption = sSerie2
            oGridSintetico.RootTable.Columns("serie3").Caption = sSerie3
            oGridSintetico.RootTable.Columns("serie4").Caption = sSerie4
            oGridSintetico.RootTable.Columns("serie5").Caption = sSerie5

            oGridSintetico.RootTable.Columns("serie1").AggregateFunction = AggregateFunction.Sum
            oGridSintetico.RootTable.Columns("serie1").TotalFormatString = "#,#0.00"

            oGridSintetico.RootTable.Columns("serie2").AggregateFunction = AggregateFunction.Sum
            oGridSintetico.RootTable.Columns("serie2").TotalFormatString = "#,#0.00"

            oGridSintetico.RootTable.Columns("serie3").AggregateFunction = AggregateFunction.Sum
            oGridSintetico.RootTable.Columns("serie3").TotalFormatString = "#,#0.00"

            oGridSintetico.RootTable.Columns("serie4").AggregateFunction = AggregateFunction.Sum
            oGridSintetico.RootTable.Columns("serie4").TotalFormatString = "#,#0.00"

            oGridSintetico.RootTable.Columns("serie5").AggregateFunction = AggregateFunction.Sum
            oGridSintetico.RootTable.Columns("serie5").TotalFormatString = "#,#0.00"

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

            oGridSintetico.CheckAllRecords()

            '******  Preenche a grid de analitico *******

            'Agora configura o gráfico
            'Limpa Série
            oChart.Series.Clear()

            'Adiciona Série
            oChart.Series.Add(sSerie1)

            'Carrega Gráfico
            oChart.Series(sSerie1).Points.DataBind(oDataSet.Tables(0).CreateDataReader, "descricao", "serie1", "Tooltip=serie1")

            'Configura Séries
            oChart.Series(sSerie1).ShowInLegend = True
            oChart.Series(sSerie1).SmartLabels.Enabled = True

            If sSerie2 <> "" Then
                oChart.Series.Add(sSerie2)
                oChart.Series(sSerie2).Points.DataBind(oDataSet.Tables(0).CreateDataReader, "descricao", "serie2", "Tooltip=serie2")
                oChart.Series(sSerie2).ShowInLegend = True
                oChart.Series(sSerie2).SmartLabels.Enabled = True

            End If

            If sSerie3 <> "" Then
                oChart.Series.Add(sSerie3)
                oChart.Series(sSerie3).Points.DataBind(oDataSet.Tables(0).CreateDataReader, "descricao", "serie3", "Tooltip=serie3")
                oChart.Series(sSerie3).ShowInLegend = True
                oChart.Series(sSerie3).SmartLabels.Enabled = True

            End If

            If sSerie4 <> "" Then
                oChart.Series.Add(sSerie4)
                oChart.Series(sSerie4).Points.DataBind(oDataSet.Tables(0).CreateDataReader, "descricao", "serie4", "Tooltip=serie4")
                oChart.Series(sSerie4).ShowInLegend = True
                oChart.Series(sSerie4).SmartLabels.Enabled = True

            End If

            If sSerie5 <> "" Then
                oChart.Series.Add(sSerie5)
                oChart.Series(sSerie5).Points.DataBind(oDataSet.Tables(0).CreateDataReader, "descricao", "serie5", "Tooltip=serie5")
                oChart.Series(sSerie5).ShowInLegend = True
                oChart.Series(sSerie5).SmartLabels.Enabled = True

            End If

            If dMeta > 0 Then
                oChart.Series.Add("meta")
                oChart.Series("meta").Points.DataBind(oDataSet.Tables(0).CreateDataReader, "descricao", "meta", "Tooltip=meta")
                oChart.Series("meta").ShowInLegend = True
                oChart.Series("meta").SmartLabels.Enabled = True

            End If

            'Formata o gráfic
            FormataGrafico(oChart, _
                           oGridSintetico, _
                           iCodigoTipoGrafico, _
                           dMeta, _
                           sTipoValor)





        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub FormataGrafico(ByVal oChart As Chart, _
                              ByVal oGridSintetico As GridEX, _
                              ByVal sTipo As String, _
                              ByVal dMeta As Double, _
                              ByVal sTipoValor As String)

        Try



            Dim sEixoX As String = LoadCodigo("sp_select_static_indicador_campo " & sTipo & ",'EIXO_X'")
            Dim sEixoy As String = LoadCodigo("sp_select_static_indicador_campo " & sTipo & ",'EIXO_Y'")
            Dim bLabel As Boolean = LoadCodigo("sp_select_static_indicador_campo " & sTipo & ",'LABEL'")
            Dim sCor1 As String = LoadCodigo("sp_selecT_static_indicador_cor " & sTipo & ",'1'")
            Dim sCor2 As String = LoadCodigo("sp_selecT_static_indicador_cor " & sTipo & ",'2'")
            Dim sCor3 As String = LoadCodigo("sp_selecT_static_indicador_cor " & sTipo & ",'3'")
            Dim sCor4 As String = LoadCodigo("sp_selecT_static_indicador_cor " & sTipo & ",'4'")
            Dim sCor5 As String = LoadCodigo("sp_selecT_static_indicador_cor " & sTipo & ",'5'")

            Dim sFormato As String = "#,#0"
            oChart.Series(0).LabelFormat = sFormato


            oChart.ChartAreas(0).AxisX.Title = sEixoX
            oChart.ChartAreas(0).AxisY.Title = IIf(sTipoValor = "QUANTIDADE", "QTDE", sTipoValor)
            oChart.ChartAreas(0).AxisY.Margin = False

            oChart.ChartAreas(0).AxisX.Margin = False

            oChart.ChartAreas(0).AxisY.LabelStyle.Format = IIf(sTipoValor = "QUANTIDADE", "", "R$ ") & sFormato

            Dim sVetor(2) As String
            Dim sSerie As String
            Dim i As Integer = 0
            For Each oSerie In oChart.Series

                If oSerie.name <> "meta" Then

                    sSerie = oSerie.name
                    Dim sTipoGrafico As String = LoadCodigo("sp_select_static_indicador_campo " & sTipo & ",'TIPO_GRAFICO_SERIE" & CStr(i + 1) & "'")


                    'Configura o tipo de gráfico
                    Select Case sTipoGrafico

                        Case "COLUMN"
                            oChart.Series(sSerie).Type = SeriesChartType.Column
                            oChart.Series(sSerie).BorderWidth = 1
                        Case "LINE"
                            oChart.Series(sSerie).Type = SeriesChartType.Line
                        Case "PIZZA"
                            oChart.Series(sSerie).Type = SeriesChartType.Doughnut
                    End Select

                    'Configura a cor da série
                    Select Case i

                        Case 0
                            sVetor = sCor1.Split(",")
                        Case 1
                            sVetor = sCor2.Split(",")
                        Case 2
                            sVetor = sCor3.Split(",")
                        Case 3
                            sVetor = sCor4.Split(",")
                        Case 4
                            sVetor = sCor5.Split(",")
                    End Select

                    oChart.Series(sSerie).Color = Color.FromArgb(sVetor(0), sVetor(1), sVetor(2))


                    oChart.Series(sSerie).EmptyPointStyle.Color = Color.Transparent
                    oChart.Series(sSerie).ShowInLegend = True
                    oChart.Series(sSerie).BorderStyle = ChartDashStyle.Solid
                    oChart.Series(sSerie).LabelFormat = "R$ #,#0"
                    oChart.Series(sSerie).BorderColor = Color.Black
                    oChart.Series(sSerie).ShowLabelAsValue = bLabel
                    oChart.Series(sSerie).SmartLabels.Enabled = bLabel
                    oChart.Series(sSerie).SmartLabels.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes

                Else

                    sSerie = "meta"

                    oChart.Series(sSerie).Type = SeriesChartType.Line

                    oChart.Series(sSerie).EmptyPointStyle.Color = Color.Transparent
                    oChart.Series(sSerie).ShowInLegend = True
                    oChart.Series(sSerie).BorderStyle = ChartDashStyle.Solid
                    oChart.Series(sSerie).LabelFormat = "R$ #,#0"
                    oChart.Series(sSerie).BorderColor = Color.Black
                    oChart.Series(sSerie).ShowLabelAsValue = bLabel
                    oChart.Series(sSerie).SmartLabels.Enabled = bLabel
                    oChart.Series(sSerie).SmartLabels.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes



                End If

                i += 1

            Next

            oChart.ChartAreas(0).Area3DStyle.Enable3D = False
            oChart.ChartAreas(0).AxisY.MajorGrid.LineStyle = ChartDashStyle.Dot
            oChart.ChartAreas(0).AxisX.MajorGrid.LineStyle = ChartDashStyle.Dot

            oChart.Legends(0).Alignment = StringAlignment.Center
            oChart.Legends(0).Docking = LegendDocking.Top
            oChart.Legends(0).LegendStyle = LegendStyle.Row


       

            'Recalcula
            oChart.ChartAreas(0).AxisX.Interval = 1
            oChart.ChartAreas(0).ReCalc()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function VerificaDataCorte(ByVal iCodigo As Integer) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            VerificaDataCorte = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_indicador_financeiro_data_corte", oSqlParameter), Integer)

            'Seta Retorno da Função
            VerificaDataCorte = IIf(iReturn > 0, True, False)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidacaoFiltro(ByVal iCodigo As Integer, _
                                    ByVal sCampo As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidacaoFiltro = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "campo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCampo


            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_indicador_financeiro_filtro", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidacaoFiltro = IIf(iReturn > 0, True, False)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub VerificaCamposGrafico(ByVal iCodigo As Integer, _
                                     ByVal txtDescricao As EditControls.EditBox, _
                                     ByVal txtSerie1 As EditControls.MaskedEditBox, _
                                     ByVal txtSerie2 As EditControls.MaskedEditBox, _
                                     ByVal txtSerie3 As EditControls.MaskedEditBox, _
                                     ByVal txtSerie4 As EditControls.MaskedEditBox, _
                                     ByVal txtSerie5 As EditControls.MaskedEditBox, _
                                     ByVal dtpDataInicio As Janus.Windows.CalendarCombo.CalendarCombo, _
                                     ByVal dtpDataTermino As Janus.Windows.CalendarCombo.CalendarCombo)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0
        Dim oSQLDataReader As SqlDataReader
        Try

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Executa Query
            oSQLDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_indicador_campo_filtro", oSqlParameter)

            If oSQLDataReader.Read Then


                txtDescricao.Text = oSQLDataReader.Item("help")


                'Cria um vetor referenciando todos os combos
                Dim oVetorSerie(4) As EditControls.MaskedEditBox
                oVetorSerie(0) = txtSerie1
                oVetorSerie(1) = txtSerie2
                oVetorSerie(2) = txtSerie3
                oVetorSerie(3) = txtSerie4
                oVetorSerie(4) = txtSerie5


                'Laço de repetição para analisar cada campo
                For iSerie As Integer = 0 To 4

                    'Recebe o nome do campo, e tira o "cbo"
                    Dim sCampoBD As String = oVetorSerie(iSerie).Name.Replace("txt", "")

                    'Se o campo existir no BD 
                    If oSQLDataReader.Item(sCampoBD) <> "" Then

                        'Seta visível
                        oVetorSerie(iSerie).Visible = True

                        oVetorSerie(iSerie).Text = oSQLDataReader.Item(sCampoBD)

                        'Faz um split para quebrar as cores
                        Dim sCor As String() = oSQLDataReader.Item("cor_" & sCampoBD).ToString.Split(",")

                        'Seta a cor
                        oVetorSerie(iSerie).BackColor = Color.FromArgb(sCor(0), sCor(1), sCor(2))

                    Else
                        'Caso contrário, somente oculta o campo
                        oVetorSerie(iSerie).Visible = False
                    End If

                Next


                If oSQLDataReader.Item("periodo_data_inicio") = True Then

                    dtpDataInicio.Visible = True
                Else
                    dtpDataInicio.Visible = False
                    dtpDataInicio.Checked = False

                End If

                If oSQLDataReader.Item("periodo_data_termino") = True Then

                    dtpDataTermino.Visible = True
                Else
                    dtpDataTermino.Visible = False
                    dtpDataTermino.Checked = False

                End If


            End If
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AtualizarCores(ByVal iCodigo As Integer, _
                              ByVal iSerie As Integer, _
                              ByVal sCor As String, _
                              ByVal sTipoGrafico As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "series"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iSerie : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCor : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_grafico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipoGrafico

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_indicador_financeiro_cor", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class

