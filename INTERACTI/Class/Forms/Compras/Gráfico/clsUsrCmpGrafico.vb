Imports System.Data
Imports System.Data.SqlClient
Imports SysACTi.SQLHelper
Imports Dundas.Charting.WinControl
Public Class clsUsrCmpGrafico

#Region "::: FUNCTION / SUB :::"
    Private Sub ChartSerieAdicionar(ByRef oChart As Chart, _
                              ByRef sKey As String)

        Try

            With oChart


                .Series.Add(sKey)
                .Series(sKey).Type = SeriesChartType.Column
                .Series(sKey).ShowLabelAsValue = True
                .Series(sKey).BorderStyle = ChartDashStyle.Solid
                .Series(sKey).BorderColor = Color.Black
                .Series(sKey).ShadowColor = Color.DarkGray
                .Series(sKey).ShadowOffset = 3
                '.Series(sKey).ShowLabelAsValue = False

            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadChartTotalPorPrioridade(ByVal oChart As Chart, _
                                           ByVal sDataInicio As String, _
                                           ByVal sDataTermino As String, _
                                           ByVal sPrioridade As String, _
                                           ByVal iNacionalidade As Integer)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros - Date
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "data_inicio"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Date
            oSqlParameter(0).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio)

            'Seta Parametros - Date
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_termino"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino)


            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_prioridade_abc"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sPrioridade

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "nacionalidade"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iNacionalidade

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_report_compras_prioridade_abc", oSqlParameter)

            'Adicionando as series
            oChart.Series.Clear()
            ChartSerieAdicionar(oChart, "Valor")
            ChartSerieAdicionar(oChart, "Quantidade")

            'oChart.Series("Quantidade").Points.Clear()
            'oChart.Series("Valor").Points.Clear()

            oChart.ChartAreas(0).AxisY.Maximum = 100


            With oChart

                'Percorrendo o data reader
                While oSqlDataReader.Read
                    oChart.Series("Quantidade").Points.AddXY(oSqlDataReader.Item("data_group"), oSqlDataReader.Item("qtd"))
                    oChart.Series("Valor").Points.AddXY(oSqlDataReader.Item("data_group"), oSqlDataReader.Item("valor"))
                End While


            End With

            'Fechando o data reader
            oSqlDataReader.Close()


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridTotalPrioridade(ByVal oGrid As Janus.Windows.GridEX.GridEX, _
                                       ByVal sDataInicio As String, _
                                       ByVal sDataTermino As String, _
                                       ByVal sPrioridade As String, _
                                       ByVal iNacionalidade As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros - Date
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "data_inicio"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Date
            oSqlParameter(0).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio)

            'Seta Parametros - Date
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_termino"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino)

            'Seta Parametros - Prioridade
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_prioridade_abc"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sPrioridade


            'Seta Parametros - Prioridade
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "nacionalidade"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iNacionalidade

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_report_compras_prioridade_abc_grid", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("numero_pedido").DataMember = "numero_pedido"
                .RootTable.Columns.Item("fornecedor").DataMember = "fornecedor"
                .RootTable.Columns.Item("prazo_entrega").DataMember = "prazo_entrega"
                .RootTable.Columns.Item("data_entrega").DataMember = "data_entrega"
                .RootTable.Columns.Item("item").DataMember = "item"
                .RootTable.Columns.Item("valor_unitario").DataMember = "valor_unitario"
                .RootTable.Columns.Item("quantidade").DataMember = "quantidade"
                .RootTable.Columns.Item("valor_total").DataMember = "valor_total"
                .RootTable.Columns.Item("atraso").DataMember = "atraso"
                .RootTable.Columns.Item("prioridade").DataMember = "prioridade"
                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadChartMaiorAtraso(ByVal oChart As Chart, _
                                         ByVal sDataInicio As String, _
                                         ByVal sDataTermino As String, _
                                         ByVal sPrioridade As String, _
                                         ByVal iFornecedor As Integer, _
                                         ByVal iNacionalidade As Integer)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros - Date
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "data_inicio"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Date
            oSqlParameter(0).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio)

            'Seta Parametros - Date
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_termino"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino)

            'Seta Parametros - Prioridade
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_prioridade_abc"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sPrioridade

            'Seta Parametros - Fornecedor
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_fornecedor"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iFornecedor

            'Seta Parametros - Fornecedor
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "nacionalidade"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iNacionalidade

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_report_compras_maior_atraso", oSqlParameter)

            'Adicionando as series
            oChart.Series.Clear()
            ChartSerieAdicionar(oChart, "Dias")

            'oChart.Series("Quantidade").Points.Clear()
            'oChart.Series("Valor").Points.Clear()


            oChart.ChartAreas(0).AxisX.Interval = 1

            With oChart

                'Percorrendo o data reader
                While oSqlDataReader.Read
                    oChart.Series("Dias").Points.AddXY(oSqlDataReader.Item("fornecedor"), oSqlDataReader.Item("atraso"))
                End While


            End With

            'Fechando o data reader
            oSqlDataReader.Close()


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub LoadGridMaiorAtraso(ByVal oGrid As Janus.Windows.GridEX.GridEX, _
                                       ByVal sDataInicio As String, _
                                       ByVal sDataTermino As String, _
                                       ByVal sPrioridade As String, _
                                       ByVal iFornecedor As Integer, _
                                       ByVal iNacionalidade As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros - Date
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "data_inicio"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Date
            oSqlParameter(0).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio)

            'Seta Parametros - Date
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_termino"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino)

            'Seta Parametros - Prioridade
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_prioridade_abc"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sPrioridade

            'Seta Parametros - Fornecedor
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_fornecedor"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iFornecedor

            'Seta Parametros - Nacionalidade
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "nacionalidade"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iNacionalidade

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_report_compras_maior_atraso_grid", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("numero_pedido").DataMember = "numero_pedido"
                .RootTable.Columns.Item("fornecedor").DataMember = "fornecedor"
                .RootTable.Columns.Item("prazo_entrega").DataMember = "prazo_entrega"
                .RootTable.Columns.Item("data_entrega").DataMember = "data_entrega"
                .RootTable.Columns.Item("item").DataMember = "item"
                .RootTable.Columns.Item("valor_unitario").DataMember = "valor_unitario"
                .RootTable.Columns.Item("quantidade").DataMember = "quantidade"
                .RootTable.Columns.Item("valor_total").DataMember = "valor_total"
                .RootTable.Columns.Item("atraso").DataMember = "atraso"
                .RootTable.Columns.Item("prioridade").DataMember = "prioridade"
                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub LoadChartMeta(ByVal oChart As Chart, _
                                         ByVal sDataInicio As String, _
                                         ByVal sDataTermino As String, _
                                         ByVal sPrioridade As String, _
                                         ByVal iFornecedor As Integer, _
                                         ByVal iAgrupamento As Integer, _
                                         ByVal iMeta As Integer, _
                                         ByVal iNacionalidade As Integer)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(5) As SqlParameter

        Try

            'Seta Parametros - Date
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "data_inicio"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Date
            oSqlParameter(0).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio)

            'Seta Parametros - Date
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_termino"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino)

            'Seta Parametros - Prioridade
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_prioridade_abc"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sPrioridade

            'Seta Parametros - Fornecedor
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_fornecedor"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iFornecedor

            'Seta Parametros - Agrupamento
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "agrupamento"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iAgrupamento

            'Seta Parametros - Nacionalidade
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "nacionalidade"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Int
            oSqlParameter(5).Value = iNacionalidade

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_report_compras_atrasos_agrupados", oSqlParameter)

            'Adicionando as series
            oChart.Series.Clear()
            ChartSerieAdicionar(oChart, "Dias")

            'oChart.Series("Quantidade").Points.Clear()
            'oChart.Series("Valor").Points.Clear()



            oChart.ChartAreas(0).AxisX.Minimum = 0
            'oChart.ChartAreas(0).AxisX.Interval = 20
            'oChart.ChartAreas(0).AxisX.Maximum = 20



            With oChart

                'Percorrendo o data reader
                While oSqlDataReader.Read
                    oChart.Series("Dias").Points.AddXY(oSqlDataReader.Item("atraso"), oSqlDataReader.Item("porcentagem"))
                End While


            End With

            'Fechando o data reader
            oSqlDataReader.Close()


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub LoadGridMeta(ByVal oGrid As Janus.Windows.GridEX.GridEX, _
                                       ByVal sDataInicio As String, _
                                       ByVal sDataTermino As String, _
                                       ByVal sPrioridade As String, _
                                       ByVal iFornecedor As Integer, _
                                       ByVal iNacionalidade As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros - Date
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "data_inicio"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Date
            oSqlParameter(0).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio)

            'Seta Parametros - Date
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_termino"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino)

            'Seta Parametros - Prioridade
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_prioridade_abc"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sPrioridade

            'Seta Parametros - Fornecedor
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_fornecedor"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iFornecedor

            'Seta Parametros - Nacionalidade
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "nacionalidade"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iNacionalidade


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_report_compras_atrasos_agrupados_grid", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("numero_pedido").DataMember = "numero_pedido"
                .RootTable.Columns.Item("fornecedor").DataMember = "fornecedor"
                .RootTable.Columns.Item("prazo_entrega").DataMember = "prazo_entrega"
                .RootTable.Columns.Item("data_entrega").DataMember = "data_entrega"
                .RootTable.Columns.Item("item").DataMember = "item"
                .RootTable.Columns.Item("valor_unitario").DataMember = "valor_unitario"
                .RootTable.Columns.Item("quantidade").DataMember = "quantidade"
                .RootTable.Columns.Item("valor_total").DataMember = "valor_total"
                .RootTable.Columns.Item("atraso").DataMember = "atraso"
                .RootTable.Columns.Item("prioridade").DataMember = "prioridade"
                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
